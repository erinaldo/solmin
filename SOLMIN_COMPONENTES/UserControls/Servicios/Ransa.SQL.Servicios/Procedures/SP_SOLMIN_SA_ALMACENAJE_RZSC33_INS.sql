-- CAMBIAR RNSLIB POR RNSLIB
DROP PROCEDURE DC@RNSLIB.SP_SOLMIN_SA_ALMACENAJE_RZSC33_INS
GO
CREATE PROCEDURE DC@RNSLIB.SP_SOLMIN_SA_ALMACENAJE_RZSC33_INS(
		IN	IN_CCLNT		NUMERIC(6, 0),		-- Cliente
		IN	IN_NPRALM		NUMERIC(10, 0),		-- Nro. Operación.
		-- Depósito Tránsito - 7
		IN	IN_CREFFW		VARCHAR(20),
		IN	IN_NROPLT		NUMERIC(10, 0),
		IN	IN_NROCTL		NUMERIC(10, 0),
		IN	IN_NRGUSA		NUMERIC(10, 0),
		IN	IN_NGUIRM		NUMERIC(10, 0),
		-- Seguridad
		IN  IN_USUARI  		VARCHAR(10),
		OUT	OU_MSGERR		VARCHAR(200)	-- Mensaje de Error
        )
RESULT SETS 0
LANGUAGE SQL
BEGIN ATOMIC
	--------------------------------------
	-- Variables de Trabajo - Seguridad --
	--------------------------------------
	DECLARE	WK_FECHA		NUMERIC(10, 0)	DEFAULT 0;
	DECLARE	WK_HORA			NUMERIC(10, 0)	DEFAULT 0;
	--------------------------
	-- Variables de Trabajo --
	--------------------------
	DECLARE WK_TNPRAL		NUMERIC(10, 0)	DEFAULT 0;	-- Nro. Operación.
	DECLARE WK_NANPRC		NUMERIC(4, 0)	DEFAULT 0;	-- Año de Proceso
	DECLARE WK_NMES			NUMERIC(2, 0)	DEFAULT 0;	-- Mes de Proceso
	DECLARE WK_FECINI		NUMERIC(8, 0)	DEFAULT 0;	-- Fecha de Inicio de la Facturación
	DECLARE WK_FECFIN		NUMERIC(8, 0)	DEFAULT 0;	-- Fecha de Final de la Facturación
	DECLARE WK_NDIALI		NUMERIC(2, 0)	DEFAULT 0;	-- Nro. de días libres por cliente
	DECLARE WK_STPOUN		VARCHAR(1)		DEFAULT '';	-- Status de Tipo de Unidad
	
	DECLARE WK_TQAROC		DECIMAL(15, 5)	DEFAULT 0;
	DECLARE WK_TQPSOB		DECIMAL(15, 5)	DEFAULT 0;
	DECLARE WK_TQVLBT		DECIMAL(15, 5)	DEFAULT 0;
	DECLARE WK_TNDPER		DECIMAL(15, 5)	DEFAULT 0;
	DECLARE WK_TNDAFA		DECIMAL(15, 5)	DEFAULT 0;
	DECLARE WK_IMPFACT		DECIMAL(15, 5)	DEFAULT 0;
	DECLARE WK_FSLFFW		VARCHAR(200)	DEFAULT '';
	DECLARE WK_FECFAC		VARCHAR(900)	DEFAULT '';
	DECLARE WK_STRSQL		VARCHAR(2000)	DEFAULT '';
	
	-- Cursor para mostrar el resultado
	
	-- Creamos la tabla temporal que contiene los datos del Reporte
	Declare Global Temporary Table SESSION.tmpBultos(
	CREFFW		VARCHAR(20) ) WITH REPLACE Not Logged;
	
	-- Obtengo la fecha y hora actual
	SET	WK_FECHA = YEAR(CURRENT DATE) * 10000 + MONTH(CURRENT DATE) * 100 + DAY(CURRENT DATE);
	SET	WK_HORA  = HOUR(CURRENT TIME) * 10000 + MINUTE(CURRENT TIME) * 100 + SECOND(CURRENT TIME);
	SET OU_MSGERR = '';

	IF EXISTS( SELECT NPRALM FROM RZSC32 WHERE NPRALM = IN_NPRALM AND STPOFC = 'P' AND SESTRG <> '*') THEN	
	
		SELECT	NANPRC, NMES, FECINI, FECFIN, NDIALI, STPOUN
		INTO	WK_NANPRC, WK_NMES, WK_FECINI, WK_FECFIN, WK_NDIALI, WK_STPOUN
		FROM	RZSC32 
		WHERE	NPRALM = IN_NPRALM
		AND		CCLNT  = IN_CCLNT;
	
		-- Iniciamos la Selección de los Bultos a ser insertados en la tabla de bultos
		Insert Into SESSION.tmpBultos
		Select	Distinct BULTO
		From (	SELECT  CREFFW AS BULTO
				FROM    RZOL65
				WHERE   CCLNT  = IN_CCLNT
				And 	CREFFW = IN_CREFFW
				And		CREFFW <> ''
				UNION ALL
				SELECT  CREFFW AS BULTO
				FROM    RZOL65
				WHERE   CCLNT  = IN_CCLNT
				And 	NROCTL = IN_NROCTL
				And		NROCTL <> 0
				UNION ALL
				SELECT	CREFFW AS BULTO
				FROM	RZOL65Q 
				WHERE   CCLNT  = IN_CCLNT
				And 	NROPLT = IN_NROPLT
				And 	SESTRG <> '*'
				UNION ALL
				SELECT	DISTINCT CREFFW AS BULTO
				FROM	RZOL66
				WHERE   CCLNT  = IN_CCLNT
				And 	NRGUSA = IN_NRGUSA
				And 	NRGUSA <> 0
				UNION ALL
				SELECT	DISTINCT CREFFW AS BULTO
				FROM	RZOL66
				WHERE   CCLNT  = IN_CCLNT
				And 	NGUIRM = IN_NGUIRM
				And 	NGUIRM <> 0 ) t1;

		-- Filtros según Fecha de Facturación
		SET WK_FSLFFW = '(CASE WHEN FSLFFW = 0 THEN ' || WK_FECFIN || ' ELSE (CASE WHEN FSLFFW > ' || WK_FECFIN || ' THEN ' || WK_FECFIN || ' ELSE FSLFFW END) END)';
		SET WK_FECFAC = ' And ( ( ' || WK_FECINI || ' <= FREFFW AND ' || WK_FSLFFW || ' <= ' || WK_FECFIN || ' ) ' ||
							' OR( ' || WK_FECINI || ' <= FREFFW AND FREFFW <= ' || WK_FECFIN || ' AND ' || WK_FSLFFW || ' >  ' || WK_FECFIN || ' ) ' ||
							' OR( ' || WK_FECINI || ' >  FREFFW AND ' || WK_FSLFFW || ' >= ' || WK_FECINI || ' AND ' || WK_FSLFFW || ' <= ' || WK_FECFIN || ' ) ' ||
							' OR( ' || WK_FECINI || ' >  FREFFW AND ' || WK_FSLFFW || ' >  ' || WK_FECFIN || ' ) ) ';

		SET WK_TNPRAL = WK_NANPRC*100 + WK_NMES;

		-- Armamos la consulta final con toda la información
		SET WK_STRSQL ='DECLARE Global Temporary Table Bultos AS ( ' ||
					'	SELECT	CREFFW, NumberToDate(FREFFW) FREFFW, ' ||
							'	NumberToDate(FULFAC) FULFAC, ' ||
							'	CASE WHEN FULFAC = 0 THEN NumberToDate(FREFFW) ELSE NumberToDate(FULFAC) + 1 Day END FINIPR, ' ||
							'	CASE WHEN FSLFFW = 0 THEN NumberToDate(' || WK_FECFIN || ') ' ||
								'	 ELSE ( CASE WHEN FSLFFW > ' || WK_FECFIN || ' THEN NumberToDate(' || WK_FECFIN || ') ' ||
											'	 ELSE NumberToDate(FSLFFW) END ) END FFINPR, ' ||
							'	QAROCP, QPSOBL, QVLBTO, 0 NDPERM, 0 NDLIPE, 0 NDFACT, 0 NDAFAC, DECIMAL(0, 15, 5) IMPFACT, ' ||
							'	CASE WHEN FULFAC <> 0 THEN Days(NumberToDate(FULFAC)) - Days(NumberToDate(FREFFW)) + 1 ELSE 0 END NDLIAC ' ||
					'	FROM	RZOL65 ' ||
					'	WHERE	CCLNT = ' || IN_CCLNT  || ' And SESTRG <> ''*'' ' || WK_FECFAC ||
					'	AND EXISTS( SELECT t1.CREFFW FROM SESSION.tmpBultos t1 WHERE t1.CREFFW = RZOL65.CREFFW ) ' ||
					'	AND NOT EXISTS( SELECT t1.CREFFW FROM RZSC33 t1 WHERE t1.CCLNT = ' || IN_CCLNT  || 
									  '	AND t1.NPRALM LIKE ''' || WK_TNPRAL || '%'' AND t1.CREFFW = RZOL65.CREFFW AND SESTRG <>''*'' ) ' ||
					'	)WITH DATA WITH REPLACE Not Logged ' ;

		PREPARE dclstmt FROM WK_STRSQL;
		EXECUTE dclstmt;

		If Exists( SELECT CREFFW FROM Session.Bultos ) Then
			Update	Session.Bultos
			Set		NDPERM = Days(FFINPR) - Days(FREFFW) + 1,
					NDLIPE = Case When NDLIAC >= WK_NDIALI Then 0 
								  Else (Case When WK_NDIALI > (Days(FFINPR) - Days(FREFFW) + 1) then (Days(FFINPR) - Days(FREFFW) + 1) 
											 Else WK_NDIALI End) - NDLIAC End,
					NDLIAC = Case When NDLIAC > WK_NDIALI Then WK_NDIALI Else NDLIAC End;

			Update	Session.Bultos
			Set		NDFACT = Days(FINIPR - 1 day) - Days(FREFFW) - NDLIAC + 1,
					NDAFAC = Days(FFINPR) - Days(Ifnull(FULFAC, FINIPR - 1 day)) - NDLIPE,
					IMPFACT = ( Case When WK_STPOUN = 'A' Then QAROCP
									 When WK_STPOUN = 'P' Then QPSOBL 
									 Else QVLBTO End ) * IN_VALUNI * DECIMAL( Days(FFINPR) - Days(Ifnull(FULFAC, FINIPR - 1 day)) - NDLIPE, 15, 5 );
			
			SELECT	SUM(IFNULL(QAROCP, 0)), SUM(IFNULL(QPSOBL, 0)), SUM(IFNULL(QVLBTO, 0)), SUM(IFNULL(NDPERM, 0)), SUM(IFNULL(NDAFAC, 0)), SUM(IFNULL(IMPFACT, 0))
			INTO	WK_TQAROC, WK_TQPSOB, WK_TQVLBT, WK_TNDPER, WK_TNDAFA, WK_IMPFACT
			FROM	Session.Bultos;
			
			Update	RZSC32
			Set		TQAROC  = TQAROC  + IFNULL(WK_TQAROC, 0),
					TQPSOB  = TQPSOB  + IFNULL(WK_TQPSOB, 0),
					TQVLBT  = TQVLBT  + IFNULL(WK_TQVLBT, 0), 
					TNDPER  = TNDPER  + IFNULL(WK_TNDPER, 0), 
					TNDAFA  = TNDAFA  + IFNULL(WK_TNDAFA, 0),
					IMPFACT = IMPFACT + IFNULL(WK_IMPFACT, 0),
					CULUSA = IN_USUARI,
					FULTAC = WK_FECHA,
					HULTAC = WK_HORA,
					UPDATE_IDENT = UPDATE_IDENT + 1
			Where	NPRALM = IN_NPRALM
			and		CCLNT  = IN_CCLNT;
			
			INSERT INTO RZSC33(	CCLNT,		NPRALM,		CREFFW,		FREFFW,		FULFAC,		FECINI,		FECFIN,
								QAROCP,		QPSOBL,		QVLBTO,		NDPERM,		NDLIAC,		NDLIPE,		NDFACT,
								NDAFAC,		SESTRG,		CUSCRT,		FCHCRT,		HRACRT,		CULUSA,		FULTAC,
								HULTAC,		UPDATE_IDENT )
						SELECT	IN_CCLNT,	IN_NPRALM,	CREFFW,
								YEAR(FREFFW) * 10000 + MONTH(FREFFW) * 100 + DAY(FREFFW),
								IFNULL(YEAR(FULFAC) * 10000 + MONTH(FULFAC) * 100 + DAY(FULFAC), 0),
								YEAR(FINIPR) * 10000 + MONTH(FINIPR) * 100 + DAY(FINIPR),
								YEAR(FFINPR) * 10000 + MONTH(FFINPR) * 100 + DAY(FFINPR),
								QAROCP,		QPSOBL,		QVLBTO,		NDPERM,		NDLIAC,		NDLIPE,		NDFACT,
								NDAFAC,		'A',		IN_USUARI,	WK_FECHA,	WK_HORA,	IN_USUARI,	WK_FECHA,
								WK_HORA,	1
						FROM	Session.Bultos;
		End if;

	ELSE
		SET OU_MSGERR = 'Información no puede ser Agregada.';
	END IF;
END
GO
GRANT ALL PRIVILEGES ON PROCEDURE SP_SOLMIN_SA_ALMACENAJE_RZSC33_INS TO PUBLIC