-- CAMBIAR RNSLIB POR DESLIB
DROP PROCEDURE DC@DESLIB.SP_SOLMIN_OC_RZOL38_DEL
GO
CREATE PROCEDURE DC@DESLIB.SP_SOLMIN_OC_RZOL38_DEL(
		IN	IN_CCLNT		NUMERIC(6, 0),
		IN	IN_NORCML		VARCHAR(35),
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

-- Verificamos si existen el ingreso a Almacen
IF Exists( Select NORCML
           From   RZOL66
           Where  CCLNT  = IN_CCLNT
           And    NORCML = IN_NORCML
           And    SESTRG <> '*' )  THEN
	SET OU_MSGERR = 'No se puede eliminar la O/C seleccionada debido a que existe una referencia en Almacén.';
ELSE
	IF NOT EXISTS(	Select NRITOC
					From   RZOL39
					Where  CCLNT  = IN_CCLNT
					And    NORCML = IN_NORCML
					And    SESTRG <> '*' ) THEN
		SET OU_MSGERR = '';
		-- Procedemos a eliminar lógicamente el item de la O/C
		Update RZOL38
        Set    SESTRG = '*',
               CULUSA = IN_USUARI,
               FULTAC = WK_FECHA,
               HULTAC = WK_HORA,
               UPDATE_IDENT = UPDATE_IDENT + 1
        Where  CCLNT  = IN_CCLNT
		And    NORCML = IN_NORCML
        And    SESTRG <> '*';
	ELSE
		SET OU_MSGERR = 'No se puede eliminar la O/C seleccionada debido a que existen Items que están Activos.';
	END IF;
END IF;

END
GO
GRANT ALL PRIVILEGES ON PROCEDURE SP_SOLMIN_OC_RZOL38_DEL TO PUBLIC