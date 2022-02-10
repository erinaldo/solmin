-- CAMBIAR RNSLIB POR DESLIB
DROP PROCEDURE DC@DESLIB.SP_SOLMIN_SA_SERVICIOS_DETALLE_RZSC31_DEL
GO
CREATE PROCEDURE DC@DESLIB.SP_SOLMIN_SA_SERVICIOS_DETALLE_RZSC31_DEL(
		IN	IN_CCLNT		NUMERIC(6, 0),
		IN	IN_NOPRCN		NUMERIC(10, 0),
		IN	IN_STPODP		VARCHAR(1),
		IN	IN_CREFFW		VARCHAR(20),
		IN	IN_NORDSR		NUMERIC(10, 0),
		IN	IN_NSLCSR		NUMERIC(4, 0),
        IN  IN_USUARI  		VARCHAR(10),
		OUT OU_MSGERR		VARCHAR(200)	-- Mensaje de Error
        )
RESULT SETS 0
LANGUAGE SQL
BEGIN ATOMIC
	--------------------------------------
	-- Variables de Trabajo - Seguridad --
	--------------------------------------
	DECLARE	WK_FECHA	NUMERIC(10, 0)	DEFAULT 0;
	DECLARE	WK_HORA		NUMERIC(10, 0)	DEFAULT 0;
	--------------------------
	-- Variables de Trabajo --
	--------------------------

	-- Obtengo la fecha y hora actual
	SET	WK_FECHA = YEAR(CURRENT DATE) * 10000 + MONTH(CURRENT DATE) * 100 + DAY(CURRENT DATE);
	SET	WK_HORA  = HOUR(CURRENT TIME) * 10000 + MINUTE(CURRENT TIME) * 100 + SECOND(CURRENT TIME);
	SET OU_MSGERR = '';

	-------------------------
	-- ALMACÉN DE TRÁNSITO --
	-------------------------
	IF IN_STPODP = '7' THEN
		IF IN_NOPRCN <> 0 THEN
			IF Exists( Select CREFFW
					   From   RZSC31
					   Where  CCLNT  = IN_CCLNT
					   And    NOPRCN = IN_NOPRCN
					   And    CREFFW = IN_CREFFW  )  THEN
			    
				Delete From RZSC31
				Where  CCLNT  = IN_CCLNT
				And    NOPRCN = IN_NOPRCN
				And    CREFFW = IN_CREFFW;
			ELSE
				SET OU_MSGERR = 'Bulto no esta asociado a la Operación.';
			END IF;
		END IF;
	END IF;
	----------------------------------
	-- DEPÓSITO SIMPLE / AUTORIZADO --
	----------------------------------
	IF IN_STPODP = '1' THEN
		IF IN_NOPRCN <> 0 THEN
			IF Exists( SELECT	CREFFW
					   FROM		RZSC31
					   WHERE	CCLNT  = IN_CCLNT
					   AND		NOPRCN = IN_NOPRCN
					   AND		NORDSR = IN_NORDSR
					   AND		NSLCSR = IN_NSLCSR  )  THEN
			    
				DELETE FROM RZSC31
				WHERE	CCLNT  = IN_CCLNT
				AND		NOPRCN = IN_NOPRCN
				AND		NORDSR = IN_NORDSR
				AND		NSLCSR = IN_NSLCSR;
			ELSE
				SET OU_MSGERR = 'Mercadería no esta asociado a la Operación.';
			END IF;
		END IF;
	END IF;
END

GO
GRANT ALL PRIVILEGES ON PROCEDURE SP_SOLMIN_SA_SERVICIOS_DETALLE_RZSC31_DEL TO PUBLIC