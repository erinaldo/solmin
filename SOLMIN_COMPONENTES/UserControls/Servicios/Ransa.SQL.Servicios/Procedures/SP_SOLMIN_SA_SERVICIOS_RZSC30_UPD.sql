-- CAMBIAR RNSLIB POR DESLIB
DROP PROCEDURE DC@DESLIB.SP_SOLMIN_SA_SERVICIOS_RZSC30_UPD
GO
CREATE PROCEDURE DC@DESLIB.SP_SOLMIN_SA_SERVICIOS_RZSC30_UPD(
		IN	IN_CCLNT		NUMERIC(6, 0),
		IN	IN_NOPRCN		NUMERIC(10, 0),
		IN	IN_STIPPR		VARCHAR(1),
		IN	IN_CCLNFC		NUMERIC(6, 0),
		IN	IN_FECINI		NUMERIC(8, 0),
		IN	IN_FECFIN		NUMERIC(8, 0),
		IN	IN_CPRCN1		VARCHAR(4),
		IN	IN_NSRCN1		VARCHAR(7),
		IN  IN_USUARI  		VARCHAR(10),
		OUT	OU_MSGERR		VARCHAR(200)	-- Mensaje de Error
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
	
	IF IN_NOPRCN <> 0 THEN
		IF EXISTS( SELECT NRTFSV FROM RZSC30 WHERE CCLNT = IN_CCLNT AND NOPRCN = IN_NOPRCN AND SESTRG <> '*' ) THEN
			IF EXISTS( SELECT t1.NRCTSL FROM RZSC02 t1 WHERE t1.CCLNT = IN_CCLNT AND t1.NOPRCN = IN_NOPRCN AND t1.FLGFAC = 'S') THEN
				SET OU_MSGERR = 'Nro. de Operaci�n posee Servicios Facturados.';
			ELSE
				-- Actualizo la informaci�n de TODOS servicios adquiridos para una misma operaci�n siempre y cuando ninguno est� facturado
				UPDATE	RZSC30
				SET		STIPPR = IN_STIPPR,
						CCLNFC = IN_CCLNFC,
						FECINI = IN_FECINI,
						FECFIN = IN_FECFIN,
						CPRCN1 = IN_CPRCN1,
						NSRCN1 = IN_NSRCN1,
						CULUSA = IN_USUARI,
						FULTAC = WK_FECHA,
						HULTAC = WK_HORA,
						UPDATE_IDENT = UPDATE_IDENT + 1
				WHERE	CCLNT  = IN_CCLNT 
				AND		NOPRCN = IN_NOPRCN
				AND		SESTRG <> '*';
				
				UPDATE	RZSC02
				SET		CCLNFC = IN_CCLNFC,
						FECINI = IN_FECINI,
						FECFIN = IN_FECFIN,
						CULUSA = IN_USUARI,
						FULTAC = WK_FECHA,
						HULTAC = WK_HORA,
						UPDATE_IDENT = UPDATE_IDENT + 1
				WHERE	CCLNT  = IN_CCLNT 
				AND		NOPRCN = IN_NOPRCN 
				AND		FLGFAC <> 'S';
			END IF;
			-- Llamar al procedimiento de Actualizaci�n de Danny
		ELSE
			SET OU_MSGERR = 'No existe informaci�n asociada al Nro. de Operaci�n.';
		END IF;	
	ELSE
		SET OU_MSGERR = 'El Nro. de la Operaci�n debe ser diferente de Cero.';
	END IF;
	
END
GO
GRANT ALL PRIVILEGES ON PROCEDURE SP_SOLMIN_SA_SERVICIOS_RZSC30_UPD TO PUBLIC