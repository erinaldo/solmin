DROP PROCEDURE SP_SOLMIN_SA_SERVICIOS_DETALLE_RZSC31_INS
GO

CREATE PROCEDURE  SP_SOLMIN_SA_SERVICIOS_DETALLE_RZSC31_INS (
        IN IN_CCLNT NUMERIC(6, 0) ,
        IN IN_NOPRCN NUMERIC(10, 0) ,
        IN IN_STPODP VARCHAR(1) ,
        IN IN_CREFFW VARCHAR(20) ,
        IN IN_NROPLT NUMERIC(10, 0) ,
        IN IN_NROCTL NUMERIC(10, 0) ,
        IN IN_NRGUSA NUMERIC(10, 0) ,
        IN IN_NGUIRM NUMERIC(10, 0) ,
        IN IN_NORDSR NUMERIC(10, 0) ,
        IN IN_NSLCSR NUMERIC(4, 0) ,
        IN IN_NGUIRN NUMERIC(10, 0) ,
        IN IN_CPRCN1 NUMERIC(4, 0) ,
        IN IN_NSRCN1 NUMERIC(4, 0) ,
        IN IN_USUARI VARCHAR(10) ,
        IN IN_CCMPN VARCHAR(2) ,
        IN IN_CDVSN VARCHAR(1) ,
        IN IN_CPLNDV NUMERIC(3, 0) ,
        OUT OU_MSGERR VARCHAR(200) )

        LANGUAGE SQL
        BEGIN ATOMIC

--  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --

-- Variables de Trabajo - Seguridad   --

--  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --

DECLARE WK_FECHA NUMERIC ( 10 , 0 ) DEFAULT 0 ;

DECLARE WK_HORA NUMERIC ( 10 , 0 ) DEFAULT 0 ;

--  --  --  --  --  --  --  --  --  --  --  --  --

-- Variables de Trabajo   --

--  --  --  --  --  --  --  --  --  --  --  --  --

DECLARE WK_STRSQL VARCHAR ( 200 ) DEFAULT '' ;

DECLARE WK_SESTRG VARCHAR ( 1 ) DEFAULT '' ;

DECLARE WK_NCRRDC NUMERIC ( 3 , 0 ) DEFAULT 0 ;

--  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --

-- Variables de Trabajo - Almacén de Tránsito   --

--  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --

DECLARE WK_CREFFW VARCHAR ( 20 ) DEFAULT '' ;

--  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  ---

-- Variables de Trabajo - Depósito Simple / Autorizado   --

--  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  ---

DECLARE WK_NORDSR NUMERIC ( 10 , 0 ) DEFAULT 0 ;

DECLARE WK_NSLCSR NUMERIC ( 4 , 0 ) DEFAULT 0 ;



-- Cursor para mostrar el resultado



-- Creamos la tabla temporal que contiene los datos del Reporte



-- Obtengo la fecha y hora actual

SET WK_FECHA = YEAR ( CURRENT DATE ) * 10000 + MONTH ( CURRENT DATE ) * 100 + DAY ( CURRENT DATE ) ;

SET WK_HORA = HOUR ( CURRENT TIME ) * 10000 + MINUTE ( CURRENT TIME ) * 100 + SECOND ( CURRENT TIME ) ;

SET OU_MSGERR = '' ;



--  --  --  --  --  --  --  --  --  --  --  ---

-- ALMACÉN DE TRÁNSITO   --

--  --  --  --  --  --  --  --  --  --  --  ---

IF IN_STPODP = '7' THEN

-- Iniciamos el recorrido de los Bultos a ser insertados en la tabla de bultos

--         FOR_LOOP :

FOR FILA AS CU_01 CURSOR FOR

SELECT CREFFW AS BULTO

FROM RZOL65

WHERE CCLNT = IN_CCLNT

AND CREFFW = IN_CREFFW

AND CCMPN = IN_CCMPN

AND CDVSN = IN_CDVSN

AND CPLNDV = IN_CPLNDV

AND CREFFW <> ''

UNION ALL

SELECT CREFFW AS BULTO

FROM RZOL65

WHERE CCLNT = IN_CCLNT

AND NROCTL = IN_NROCTL

AND CCMPN = IN_CCMPN

AND CDVSN = IN_CDVSN

AND CPLNDV = IN_CPLNDV

AND NROCTL <> 0

UNION ALL

SELECT CREFFW AS BULTO

FROM RZOL65Q

WHERE CCLNT = IN_CCLNT

AND NROPLT = IN_NROPLT

AND SESTRG <> '*'

UNION ALL

SELECT DISTINCT CREFFW AS BULTO

FROM RZOL66

WHERE CCLNT = IN_CCLNT

AND NRGUSA = IN_NRGUSA

AND CCMPN = IN_CCMPN

AND CDVSN = IN_CDVSN

AND CPLNDV = IN_CPLNDV

AND NRGUSA <> 0

UNION ALL

SELECT DISTINCT CREFFW AS BULTO

FROM RZOL66

WHERE CCLNT = IN_CCLNT

AND NGUIRM = IN_NGUIRM

AND CCMPN = IN_CCMPN

AND CDVSN = IN_CDVSN

AND CPLNDV = IN_CPLNDV

AND NGUIRM <> 0

ORDER BY 1

DO

SET WK_CREFFW = '' ;

SET WK_SESTRG = '' ;

-- Verificamos si existen el ingreso a Almacen

SELECT RZ65 . CREFFW , RZ65 . SESTRG

INTO WK_CREFFW , WK_SESTRG

FROM RZOL65 RZ65

WHERE RZ65 . CCLNT = IN_CCLNT

AND RZ65 . CCMPN = IN_CCMPN

AND RZ65 . CDVSN = IN_CDVSN

AND RZ65 . CPLNDV = IN_CPLNDV

AND RZ65 . CREFFW = FILA . BULTO ;



IF WK_CREFFW = '' THEN

SET OU_MSGERR = OU_MSGERR || TRIM ( FILA . BULTO ) || '-Bulto no ha sido Creado.%' ;

ELSE

IF WK_SESTRG = '*' THEN

SET OU_MSGERR = OU_MSGERR || TRIM ( FILA . BULTO ) || '-Bulto está Anulado.%' ;

ELSE

IF EXISTS ( SELECT RZ31 . CREFFW

FROM RZSC31 RZ31

WHERE RZ31 . CCLNT = IN_CCLNT

AND RZ31 . NOPRCN = IN_NOPRCN

AND RZ31 . CREFFW = FILA . BULTO ) THEN

SET OU_MSGERR = OU_MSGERR || TRIM ( FILA . BULTO ) || '-Bulto ya está registrado.%' ;

ELSE

IF IN_NOPRCN <> 0 THEN

SELECT IFNULL ( MAX ( NCRRDC ) , 0 )

INTO WK_NCRRDC

FROM RZSC31

WHERE RZSC31 . CCLNT = IN_CCLNT

AND RZSC31 . NOPRCN = IN_NOPRCN ;



SET WK_NCRRDC = WK_NCRRDC + 1 ;



INSERT INTO RZSC31 ( CCLNT , NOPRCN , NCRRDC , CREFFW , NORDSR , NSLCSR , CPRCN1, NSRCN1, SESTRG , CUSCRT , FCHCRT , HRACRT , CULUSA , FULTAC , HULTAC , UPDATE_IDENT )

VALUES ( IN_CCLNT , IN_NOPRCN , WK_NCRRDC , FILA . BULTO , 0 , 0 , 'A' , IN_CPRCN1,IN_NSRCN1,IN_USUARI , WK_FECHA , WK_HORA , IN_USUARI , WK_FECHA , WK_HORA , 1 ) ;

END IF ;

END IF ;

END IF ;

END IF ;

END FOR ;

END IF ;

--  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --

-- DEPÓSITO SIMPLE / AUTORIZADO   --

--  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --  --

IF IN_STPODP = '1' OR IN_STPODP = '5' THEN

-- Iniciamos el recorrido de las mercaderías a ser insertados en la tabla de mercaderías

--    FOR_LOOP1 :

FOR FILA1 AS CU_01 CURSOR FOR

SELECT NORDSR , NSLCSR

FROM RZIT06

WHERE CCLNT3 = IN_CCLNT

AND NORDSR = IN_NORDSR

AND NSLCSR = IN_NSLCSR

UNION ALL

SELECT NORDSR , NSLCSR

FROM RZIT06

WHERE CCLNT3 = IN_CCLNT

AND NGUIRN = IN_NGUIRN

AND NGUIRN <> 0

ORDER BY 1 , 2

DO

SET WK_NORDSR = 0 ;

SET WK_NSLCSR = 0 ;

SET WK_SESTRG = '' ;

-- Verificamos si existen el ingreso a Almacen

SELECT NORDSR , NSLCSR , SESTRG

INTO WK_NORDSR , WK_NSLCSR , WK_SESTRG

FROM RZIT06 RZ06

WHERE RZ06 . NORDSR = FILA1 . NORDSR

AND RZ06 . NSLCSR = FILA1 . NSLCSR ;



IF WK_NORDSR = 0 THEN

SET OU_MSGERR = OU_MSGERR || TRIM ( FILA1 . NORDSR ) || '-Mercadería no ha sido Creado.%' ;

ELSE

IF WK_SESTRG = '*' THEN

SET OU_MSGERR = OU_MSGERR || TRIM ( FILA1 . NORDSR ) || '-Mercadería está Anulada.%' ;

ELSE

IF EXISTS ( SELECT RZ31 . CREFFW

FROM RZSC31 RZ31

WHERE RZ31 . CCLNT = IN_CCLNT

AND RZ31 . NOPRCN = IN_NOPRCN

AND RZ31 . NORDSR = FILA1 . NORDSR

AND RZ31 . NSLCSR = FILA1 . NSLCSR ) THEN

SET OU_MSGERR = OU_MSGERR || TRIM ( FILA1 . NORDSR ) || '-Mercadería ya está registrado.%' ;

ELSE

IF IN_NOPRCN <> 0 THEN

SELECT IFNULL ( MAX ( NCRRDC ) , 0 )

INTO WK_NCRRDC

FROM RZSC31

WHERE RZSC31 . CCLNT = IN_CCLNT

AND RZSC31 . NOPRCN = IN_NOPRCN ;



SET WK_NCRRDC = WK_NCRRDC + 1 ;

INSERT INTO RZSC31 ( CCLNT , NOPRCN , NCRRDC , CREFFW , NORDSR , NSLCSR , CPRCN1, NSRCN1, SESTRG , CUSCRT , FCHCRT , HRACRT , CULUSA , FULTAC , HULTAC , UPDATE_IDENT )

VALUES ( IN_CCLNT , IN_NOPRCN , WK_NCRRDC , '' , FILA1 . NORDSR , FILA1 . NSLCSR , IN_CPRCN1,IN_NSRCN1, 'A' , IN_USUARI , WK_FECHA , WK_HORA , IN_USUARI , WK_FECHA , WK_HORA , 1 ) ;

END IF ;

END IF ;

END IF ;

END IF ;

END FOR ;

END IF ;

END

GO
GRANT ALL PRIVILEGES ON PROCEDURE SP_SOLMIN_SA_SERVICIOS_DETALLE_RZSC31_INS TO PUBLIC