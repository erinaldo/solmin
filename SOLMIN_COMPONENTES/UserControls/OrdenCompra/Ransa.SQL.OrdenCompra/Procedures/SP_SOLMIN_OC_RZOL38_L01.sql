drop procedure SP_SOLMIN_OC_RZOL38_L01
go
CREATE PROCEDURE SP_SOLMIN_OC_RZOL38_L01 (
        IN IN_CCLNT NUMERIC(6, 0) ,
        IN IN_NORCML VARCHAR(256) ,
        IN IN_CPRVCL NUMERIC(6, 0) ,
        IN IN_TDSCML VARCHAR(50) ,
        IN IN_FORCML_INI NUMERIC(8, 0) ,
        IN IN_FORCML_FIN NUMERIC(8, 0) ,
        IN IN_TTINTC VARCHAR(6) ,
        IN IN_CMEDTR NUMERIC(2, 0) ,
        IN IN_NREFCL VARCHAR(100) ,
        IN IN_REFDO1 VARCHAR(256) ,
        IN IN_NTPDES NUMERIC(2, 0) ,
        IN IN_SITUOC VARCHAR(1) ,
        IN IN_NROPAG NUMERIC(6, 0) ,
        IN IN_REGPAG NUMERIC(6, 0) ,
        OUT OU_TOTPAG NUMERIC(6, 0) )
        DYNAMIC RESULT SETS 1
        LANGUAGE SQL
        BEGIN
DECLARE WK_TOTPAG NUMERIC ( 6 , 0 ) DEFAULT 0 ;  -- NRO TOTAL DE PAGINAS SOBRE LA CONSULTA
DECLARE WK_NORCML VARCHAR ( 35 ) DEFAULT '' ;  -- ORDEN DE COMPRA TEMPORAL
DECLARE WK_CNTREG NUMERIC ( 6 , 0 ) DEFAULT 0 ;  -- CONTADOR DE REGISTROS
DECLARE WK_NRPAGS NUMERIC ( 6 , 0 ) DEFAULT 0 ;  -- NRO DE PAGINAS EN TOTAL PARA LA CONSULTA ESTABLECIDA

DECLARE STRSQL VARCHAR ( 6000 ) DEFAULT '' ;
DECLARE STRSQL_NORCML VARCHAR ( 300 ) DEFAULT '' ;
DECLARE STRSQL_CPRVCL VARCHAR ( 100 ) DEFAULT '' ;
DECLARE STRSQL_TDSCML VARCHAR ( 100 ) DEFAULT '' ;
DECLARE STRSQL_FORCML_INI VARCHAR ( 100 ) DEFAULT '' ;
DECLARE STRSQL_FORCML_FIN VARCHAR ( 100 ) DEFAULT '' ;
DECLARE STRSQL_TTINTC VARCHAR ( 100 ) DEFAULT '' ;
DECLARE STRSQL_CMEDTR VARCHAR ( 100 ) DEFAULT '' ;
DECLARE STRSQL_NREFCL VARCHAR ( 150 ) DEFAULT '' ;
DECLARE STRSQL_REFDO1 VARCHAR ( 300 ) DEFAULT '' ;
DECLARE STRSQL_NTPDES VARCHAR ( 100 ) DEFAULT '' ;
DECLARE STRSQL_SITUOC VARCHAR ( 300 ) DEFAULT '' ;

DECLARE CU_00 SCROLL CURSOR WITH RETURN FOR S0 ;
DECLARE CU_01 SCROLL CURSOR WITH RETURN FOR S1 ;
DECLARE CU_02 SCROLL CURSOR WITH RETURN FOR S2 ;

-- Filtros según Orden de Compra
IF IN_NORCML <> '' THEN
IF POSSTR ( IN_NORCML , ',' ) <> 0 THEN
SET IN_NORCML = REPLACE ( IN_NORCML , ',' , ''',''' ) ;
SET STRSQL_NORCML = ' And RZOL38.NORCML IN  ( ''' || IN_NORCML || ''') ' ;
ELSE
--SET IN_NORCML = REPLACE ( IN_NORCML , '*' , '%' ) ;
SET STRSQL_NORCML = ' And Trim( RZOL38.NORCML ) LIKE ''%'' || ''' || IN_NORCML || ''' || ''%'' ' ;
END IF ;
END IF ;
-- Filtros según un Proveedor seleccionado
IF IN_CPRVCL <> 0 THEN
SET STRSQL_CPRVCL = ' And RZOL38.CPRVCL = ' || IN_CPRVCL ;
END IF ;
-- Filtros según la descripción de la Orden de Compra
IF IN_TDSCML <> '' THEN
IF POSSTR ( IN_TDSCML , ',' ) <> 0 THEN
SET IN_TDSCML = REPLACE ( REPLACE ( IN_TDSCML , ' ' , '' ) , ',' , ''',''' ) ;
SET STRSQL_TDSCML = ' And RZOL38.TDSCML IN  ( ''' || IN_TDSCML || ''') ' ;
ELSE
SET IN_TDSCML = REPLACE ( REPLACE ( IN_TDSCML , ' ' , '' ) , '*' , '%' ) ;
SET STRSQL_TDSCML = ' And Trim(RZOL38.TDSCML) LIKE ''' || IN_TDSCML || ''' ' ;
END IF ;
END IF ;
-- Filtros según Fecha de creación de la Orden de Compra mayor o igual
IF IN_FORCML_INI > 0 THEN
SET STRSQL_FORCML_INI = ' And RZOL38.FORCML >= ' || IN_FORCML_INI ;
END IF ;
-- Filtros según Fecha de creación de la Orden de Compra menor o igual
IF IN_FORCML_FIN > 0 THEN
SET STRSQL_FORCML_FIN = ' And RZOL38.FORCML <= ' || IN_FORCML_FIN ;
END IF ;
-- Filtros según Término Internacional seleccionado
IF IN_TTINTC <> '' THEN
SET STRSQL_TTINTC = ' And RZOL38.TTINTC = ''' || IN_TTINTC || ''' ' ;
END IF ;
-- Filtros según Medio de Transporte seleccionado
IF IN_CMEDTR <> 0 THEN
SET STRSQL_CMEDTR = ' And RZOL38.CMEDTR = ' || IN_CMEDTR || ' ' ;
END IF ;
-- Filtros según la Referencia del Cliente de la Orden de Compra
IF IN_NREFCL <> '' THEN
IF POSSTR ( IN_NREFCL , ',' ) <> 0 THEN
SET IN_NREFCL = REPLACE ( REPLACE ( IN_NREFCL , ' ' , '' ) , ',' , ''',''' ) ;
SET STRSQL_NREFCL = ' And RZOL38.NREFCL IN  ( ''' || IN_NREFCL || ''') ' ;
ELSE
SET IN_NREFCL = REPLACE ( REPLACE ( IN_NREFCL , ' ' , '' ) , '*' , '%' ) ;
SET STRSQL_NREFCL = ' And Trim(RZOL38.NREFCL) LIKE ''' || IN_NREFCL || ''' ' ;
END IF ;
END IF ;
-- Filtros según la Referencia del Documento de la Orden de Compra
IF IN_REFDO1 <> '' THEN
IF POSSTR ( IN_REFDO1 , ',' ) <> 0 THEN
SET IN_REFDO1 = REPLACE ( REPLACE ( IN_REFDO1 , ' ' , '' ) , ',' , ''',''' ) ;
SET STRSQL_REFDO1 = ' And RZOL38.REFDO1 IN  ( ''' || IN_REFDO1 || ''') ' ;
ELSE
SET IN_REFDO1 = REPLACE ( REPLACE ( IN_REFDO1 , ' ' , '' ) , '*' , '%' ) ;
SET STRSQL_REFDO1 = ' And Trim(RZOL38.REFDO1) LIKE ''' || IN_REFDO1 || ''' ' ;
END IF ;
END IF ;
-- Filtros según Prioridad
IF IN_NTPDES <> 0 THEN
SET STRSQL_NTPDES = ' And RZOL38.NTPDES = ' || IN_NTPDES || ' ' ;
END IF ;
IF IN_SITUOC <> '' THEN
SET STRSQL_SITUOC = ' EXISTS( SELECT NORCML FROM RZOL39 WHERE CCLNT = RZOL38.CCLNT AND NORCML = RZOL38.NORCML AND (QCNTIT - QCNRCP) > 0 ) ' ;
-- Validamos que tipo de situación se desea
IF IN_SITUOC = 'P' THEN
SET STRSQL_SITUOC = ' And ' || STRSQL_SITUOC ;
ELSE
SET STRSQL_SITUOC = ' And Not ' || STRSQL_SITUOC ;
END IF ;
END IF ;

SET STRSQL = 'SELECT Count(NORCML) FROM RZOL38 WHERE CCLNT = ? And NORCML >= ? ' || STRSQL_NORCML || STRSQL_SITUOC || ' And SESTRG <> ''*'' ' || STRSQL_CPRVCL ||
STRSQL_TDSCML || STRSQL_FORCML_INI || STRSQL_FORCML_FIN || STRSQL_TTINTC || STRSQL_CMEDTR || STRSQL_NREFCL || STRSQL_REFDO1 || STRSQL_NTPDES ;
-- Preparamos el Macros que contiene la consulta de toda la información.
PREPARE S0 FROM STRSQL ;
OPEN CU_00 USING IN_CCLNT , WK_NORCML ;
FETCH LAST FROM CU_00 INTO WK_TOTPAG ;
CLOSE CU_00 ;

IF IN_REGPAG <= 0 THEN
SET IN_REGPAG = 1 ;
IF WK_TOTPAG > 0 THEN
SET IN_REGPAG = WK_TOTPAG ;
END IF ;
END IF ;

IF WK_TOTPAG > 0 THEN
IF MOD ( WK_TOTPAG , IN_REGPAG ) > 0 THEN
SET WK_TOTPAG = INTEGER ( WK_TOTPAG / IN_REGPAG ) + 1 ;
ELSE
SET WK_TOTPAG = INTEGER ( WK_TOTPAG / IN_REGPAG ) ;
END IF ;
ELSE
SET WK_TOTPAG = 1 ;
END IF ;

IF IN_NROPAG > WK_TOTPAG THEN
SET IN_NROPAG = WK_TOTPAG ;
END IF ;

SET OU_TOTPAG = WK_TOTPAG ;

SET STRSQL = 'SELECT NORCML FROM RZOL38 WHERE CCLNT = ? And NORCML >= ? ' || STRSQL_NORCML || STRSQL_SITUOC || ' And SESTRG <> ''*'' ' || STRSQL_CPRVCL ||
STRSQL_TDSCML || STRSQL_FORCML_INI || STRSQL_FORCML_FIN || STRSQL_TTINTC || STRSQL_CMEDTR || STRSQL_NREFCL || STRSQL_REFDO1 || STRSQL_NTPDES ||
' ORDER BY NORCML ASC FETCH FIRST ' || ( IN_REGPAG + 1 ) || ' ROWS ONLY ' ;
-- Preparamos el Macros que contiene la consulta de toda la información.
PREPARE S1 FROM STRSQL ;
-- Recorremos todas las páginas anteriores para obtener la última Orden de Compra
WHILE WK_CNTREG < ( IN_NROPAG - 1 ) DO
OPEN CU_01 USING IN_CCLNT , WK_NORCML ;
FETCH LAST FROM CU_01 INTO WK_NORCML ;
CLOSE CU_01 ;
-- AVANZAMOS EL CONTADOR DE PAGINAS
SET WK_CNTREG = WK_CNTREG + 1 ;
END WHILE ;

-- Armamos la consulta final con toda la información
SET STRSQL = '  SELECT  RZOL38.NORCML,
                                           (Select Trim(RZOL05.TPRVCL) From RZOL05 Where RZOL38.CPRVCL = RZOL05.CPRVCL ) as TPRVCL,
                                           (Select Trim(RZOL05.NRUCPR) From RZOL05 Where RZOL38.CPRVCL = RZOL05.CPRVCL ) as NRUCPR,
                                            NumberToDate(RZOL38.FORCML) as FORCML,
                                                RZOL38.TDSCML,
  RZOL38.TDEFIN,
                                           (SELECT RZZK02.TMNDA FROM RZZK02 WHERE RZOL38.CMNDA1 = RZZK02.CMNDA1 ) CMNDA1,
                                            RZOL38.TTINTC,
                                            RZOL38.NREFCL,
                                                RZOL38.TPAGME,
                                                RZOL38.REFDO1,
                                           (SELECT MAX(Trim(TDSDES)) FROM RZO103 WHERE CODVAR = ''NTPDES'' AND CCMPRN = RZOL38.NTPDES ) NTPDES,
                                                RZOL38.IVCOTO,
                                                RZOL38.IVTOCO,
                                                RZOL38.IVTOIM,
                                                RZOL38.SESTRG
                                FROM    RZOL38
                                WHERE   CCLNT = ? And NORCML >= ? ' || STRSQL_NORCML || STRSQL_SITUOC || ' And SESTRG <> ''*'' ' || STRSQL_CPRVCL || STRSQL_TDSCML ||
STRSQL_FORCML_INI || STRSQL_FORCML_FIN || STRSQL_TTINTC || STRSQL_CMEDTR || STRSQL_NREFCL || STRSQL_REFDO1 || STRSQL_NTPDES ||
' ORDER BY NORCML ASC FETCH FIRST ' || IN_REGPAG || ' ROWS ONLY ' ;
-- Realizamos la preparación de la Consulta para ser ejecutada
PREPARE S2 FROM STRSQL ;
OPEN CU_02 USING IN_CCLNT , WK_NORCML ;
END
go
grant all privileges on procedure SP_SOLMIN_OC_RZOL38_L01 to public
