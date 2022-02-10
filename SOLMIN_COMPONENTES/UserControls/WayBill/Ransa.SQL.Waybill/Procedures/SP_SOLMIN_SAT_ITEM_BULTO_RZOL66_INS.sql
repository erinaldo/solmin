-- CAMBIAR RNSLIB POR DESLIB
DROP PROCEDURE DC@DESLIB.SP_SOLMIN_SAT_ITEM_BULTO_RZOL66_INS
GO
CREATE PROCEDURE DC@DESLIB.SP_SOLMIN_SAT_ITEM_BULTO_RZOL66_INS(
		IN IN_CCLNT		NUMERIC(6, 0),		-- Cliente
        IN IN_CREFFW	VARCHAR(20),		-- Bulto
        IN IN_NORCML	VARCHAR(35),		-- Orden de Compra
        IN IN_NRITOC	NUMERIC(6, 0),		-- Item OC
        IN IN_NFACPR	VARCHAR(15),		-- Nro de Factura
        IN IN_FFACPR	NUMERIC(8, 0),		-- Fecha Factura
        IN IN_NGRPRV	VARCHAR(20),		-- Nro Guia Proveedor
        IN IN_QBLTSR	NUMERIC(15, 5),		-- Cantidad Recibida
        IN IN_QPEPQT	NUMERIC(15, 5),		-- Peso de la Cantidad Recibida
		IN IN_TUNPSO	VARCHAR(10),		-- Unidad Peso
		IN IN_QVOPQT	NUMERIC(15, 5),		-- Volumen de la Cantidad Recibida
		IN IN_TUNVOL	VARCHAR(10),		-- Unidad Volumen
        IN IN_TDAITM	VARCHAR(1000),		-- Observaciones
        -- Variables relacionadas a la seguridad
        IN IN_USUARI  	VARCHAR(10)			-- Usuario
        )
RESULT SETS 0
LANGUAGE SQL
BEGIN 
--------------------------------------
-- Variables de Trabajo - Seguridad --
--------------------------------------
DECLARE	WK_FECHA	NUMERIC(10, 0)	DEFAULT 0;
DECLARE	WK_HORA		NUMERIC(10, 0)	DEFAULT 0;
--------------------------
-- Variables de Trabajo --
--------------------------
DECLARE strCIDPAQ	VARCHAR(20)		DEFAULT '';
DECLARE strTDAITM	VARCHAR(1000)	DEFAULT '';
DECLARE strOBSTEM	VARCHAR(45)		DEFAULT '';
DECLARE intNCRRDC	NUMERIC(3, 0)	DEFAULT 0;

-- Obtengo la fecha y hora actual
SET	WK_FECHA = YEAR(CURRENT DATE) * 10000 + MONTH(CURRENT DATE) * 100 + DAY(CURRENT DATE);
SET	WK_HORA  = HOUR(CURRENT TIME) * 10000 + MINUTE(CURRENT TIME) * 100 + SECOND(CURRENT TIME);
SET strTDAITM = IN_TDAITM;

SELECT	RIGHT('000' || ( IFNULL( MAX( CIDPAQ ), 0) + 1 ), 3)
INTO	strCIDPAQ
FROM	RZol66
WHERE	CCLNT  = IN_CCLNT
AND		CREFFW = IN_CREFFW;

-- Registramos el Item del Bulto
Insert Into RZol66( CCLNT,		CREFFW,		CIDPAQ,		NORCML,		NRITOC,		NFACPR,		NRITFP,		FFACPR,		NGUIPR,		QCNTDC, 
					QBLTSR,		QSLCNB,		SSTBLT,		SITMAT, 	QBLRCO,		TTIPPQ,		QPEPQT,		TUNPSO,		QVOPQT,		TUNVOL, 
					QMTALT,		QMTANC,		QMTLRG,		NRWBLL,		NFACMR,		SESTRG,		FLGQDM,		CREEMB, 	LANCOS,		NFCPRT, 
					NITPRT,		FFCPRT,		NGRPRV,		STRNSM,		NRGUSA,		NSEQCR,		CUSCRT,		FCHCRT,		HRACRT,		CULUSA, 
					FULTAC,		HULTAC, 	UPDATE_IDENT )
			values(	IN_CCLNT,	IN_CREFFW,	strCIDPAQ,	IN_NORCML,	IN_NRITOC,	IN_NFACPR,	'',			IN_FFACPR,	0,			0,
					IN_QBLTSR,	IN_QBLTSR,	0,			'', 		IN_QBLTSR,	'',			IN_QPEPQT,	IN_TUNPSO,	IN_QVOPQT,	IN_TUNVOL, 
					0,			0,			0,			0,			'',			'A',		'',			'', 		0,			'', 
					'',			0,			IN_NGRPRV,	'',			0,			0,			IN_USUARI,	WK_FECHA,	WK_HORA,	IN_USUARI, 
					WK_FECHA,	WK_HORA, 	1);

-- Actualizamos los valores recibidos en el detalle de la Orden de Compra
Update	RZOL39
Set		QCNRCP = QCNRCP + IN_QBLTSR,
		QSTKIT = QSTKIT + IN_QBLTSR,
		UPDATE_IDENT = UPDATE_IDENT + 1
Where	CCLNT = IN_CCLNT
And		NORCML = IN_NORCML
And		NRITOC = IN_NRITOC;

-- Validamos si el Cliente requiere CheckPoint
IF EXISTS(	SELECT	CEMB FROM RZOL51
			WHERE   CEMB   = 'R'
			AND     NESTDO IN (SELECT NESTDO FROM RZOL45 WHERE SESTRG = 'A' AND CCLNT = IN_CCLNT) ) THEN
	-- Marcamos los checkPoint correspondientes al ingreso del OC al almacén
	CALL SP_SOLMIN_SA_SAT_CHKPNT_INS(IN_CCLNT, IN_NORCML, IN_NRITOC, IN_QBLTSR, 'R', IN_USUARI);
END IF;

-- Eliminamos las observaciones que puedan estar registradas
Delete From RZOL66K 
Where  CCLNT = IN_CCLNT
And    CREFFW = IN_CREFFW
And    NORCML = IN_NORCML
And    NRITOC = IN_NRITOC;

WHILE LENGTH(strTDAITM) > 0 DO
	IF LENGTH( strTDAITM ) > 45 THEN
		SET	strOBSTEM = SUBSTR(strTDAITM, 1, 45);
		SET	strTDAITM = SUBSTR(strTDAITM, 46);
	ELSE
		SET	strOBSTEM = strTDAITM;
		SET strTDAITM = '';
	END IF;
	SET intNCRRDC = intNCRRDC + 1;
	
	Insert Into RZOL66K(CCLNT,		CREFFW,		NORCML,		NRITOC,		NCRRDC,		TDAITM,		USRCRT,		FCHCRT,		HRACRT,		UPDATE_IDENT ) 
				Values (IN_CCLNT,	IN_CREFFW,	IN_NORCML,	IN_NRITOC,	intNCRRDC,	strOBSTEM,	IN_USUARI,	WK_FECHA,	WK_HORA,	1);
END WHILE; 

COMMIT;

END
GO
GRANT ALL PRIVILEGES ON PROCEDURE SP_SOLMIN_SAT_ITEM_BULTO_RZOL66_INS TO PUBLIC