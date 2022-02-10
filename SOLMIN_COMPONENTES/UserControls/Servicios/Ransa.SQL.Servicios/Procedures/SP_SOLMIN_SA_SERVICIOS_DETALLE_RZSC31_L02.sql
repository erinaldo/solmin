DROP PROCEDURE DC@DESLIB.SP_SOLMIN_SA_SERVICIOS_DETALLE_RZSC31_L02
GO
CREATE PROCEDURE DC@DESLIB.SP_SOLMIN_SA_SERVICIOS_DETALLE_RZSC31_L02(
                IN      IN_CCLNT                NUMERIC(6, 0),
                IN      IN_NOPRCN               NUMERIC(10, 0),
                IN      IN_CREFFW               VARCHAR(20),
                IN      IN_NROPLT               NUMERIC(10, 0),
                IN      IN_NROCTL               NUMERIC(10, 0),
                IN      IN_NRGUSA               NUMERIC(10, 0),
                IN      IN_NGUIRM               NUMERIC(10, 0),
                IN      IN_CCMPN                VARCHAR(2),
                IN      IN_CDVSN                VARCHAR(1),
                IN      IN_CPLNDV               NUMERIC(3),
                OUT     OU_MSGERR               VARCHAR(200)    -- Mensaje de Error
        )
RESULT SETS 1
LANGUAGE SQL
BEGIN ATOMIC
        --------------------------------------
        -- Variables de Trabajo - Seguridad --
        --------------------------------------
        DECLARE WK_FECHA        NUMERIC(10, 0)  DEFAULT 0;
        DECLARE WK_HORA         NUMERIC(10, 0)  DEFAULT 0;
        --------------------------
        -- Variables de Trabajo --
        --------------------------
        DECLARE WK_STRSQL       VARCHAR(200)    DEFAULT '';
        DECLARE WK_CREFFW       VARCHAR(20)             DEFAULT '';
        DECLARE WK_SESTRG       VARCHAR(1)              DEFAULT '';
        -- Cursor para mostrar el resultado
        DECLARE CU_02 SCROLL CURSOR WITH RETURN FOR S2;
        -- Creamos la tabla temporal que contiene los datos del Reporte
        Declare Global Temporary Table SESSION.tmpBultos(
                CREFFW          VARCHAR(20),    DESCWB          VARCHAR(40),    TUBRFR          VARCHAR(17),    QREFFW          NUMERIC(7, 0),
                TIPBTO          VARCHAR(10),    QPSOBL          DECIMAL(15, 5), TUNPSO          VARCHAR(10),    QVLBTO          NUMERIC(15, 5),
                TUNVOL          VARCHAR(10),    QAROCP          NUMERIC(6, 2),  SESTRG          VARCHAR(1)
        ) WITH REPLACE Not Logged;

        -- Obtengo la fecha y hora actual
        SET     WK_FECHA = YEAR(CURRENT DATE) * 10000 + MONTH(CURRENT DATE) * 100 + DAY(CURRENT DATE);
        SET     WK_HORA  = HOUR(CURRENT TIME) * 10000 + MINUTE(CURRENT TIME) * 100 + SECOND(CURRENT TIME);
        SET OU_MSGERR = '';

        -- Iniciamos el recorrido de los Bultos a ser insertados en la tabla de bultos
        FOR_LOOP:
        FOR FILA AS CU_01 CURSOR FOR
        SELECT  CREFFW AS BULTO
        FROM    RZOL65
        WHERE   CCLNT  = IN_CCLNT
        And     CREFFW = IN_CREFFW
        AND     CCMPN  = IN_CCMPN
        AND     CDVSN  = IN_CDVSN
        AND     CPLNDV = IN_CPLNDV
        And     CREFFW <> ''
        UNION ALL
        SELECT  CREFFW AS BULTO
        FROM    RZOL65
        WHERE   CCLNT  = IN_CCLNT
        And     NROCTL = IN_NROCTL
        AND     CCMPN  = IN_CCMPN
        AND     CDVSN  = IN_CDVSN
        AND     CPLNDV = IN_CPLNDV
        And     NROCTL <> 0
        UNION ALL
        SELECT  CREFFW AS BULTO
        FROM    RZOL65Q
        WHERE   CCLNT  = IN_CCLNT
        And     NROPLT = IN_NROPLT
        And     SESTRG <> '*'
        UNION ALL
        SELECT  DISTINCT CREFFW AS BULTO
        FROM    RZOL66
        WHERE   CCLNT  = IN_CCLNT
        And     NRGUSA = IN_NRGUSA
        AND     CCMPN  = IN_CCMPN
        AND     CDVSN  = IN_CDVSN
        AND     CPLNDV = IN_CPLNDV
        And     NRGUSA <> 0
        UNION ALL
        SELECT  DISTINCT CREFFW AS BULTO
        FROM    RZOL66
        WHERE   CCLNT  = IN_CCLNT
        And     NGUIRM = IN_NGUIRM
        AND     CCMPN  = IN_CCMPN
        AND     CDVSN  = IN_CDVSN
        AND     CPLNDV = IN_CPLNDV
        And     NGUIRM <> 0
        ORDER BY 1
        DO
                SET WK_CREFFW = '';
                SET WK_SESTRG = '';
                        -- Verificamos si existen el ingreso a Almacen
                Select  RZ65.CREFFW, RZ65.SESTRG
                Into    WK_CREFFW, WK_SESTRG
                From    RZOL65 RZ65
                Where   RZ65.CCLNT  = IN_CCLNT
                  AND   RZ65.CCMPN  = IN_CCMPN
                  AND   RZ65.CDVSN  = IN_CDVSN
                  AND   RZ65.CPLNDV = IN_CPLNDV
                And     RZ65.CREFFW = FILA.BULTO;

                IF WK_CREFFW = '' THEN
                        SET OU_MSGERR = OU_MSGERR || TRIM( FILA.BULTO ) || '-Bulto no ha sido Creado.%';
                ELSE
                        IF WK_SESTRG = '*' THEN
                                SET OU_MSGERR = OU_MSGERR || TRIM( FILA.BULTO ) || '-Bulto está Anulado.%';
                        ELSE
                                Insert Into SESSION.tmpBultos(CREFFW, DESCWB, TUBRFR, QREFFW, TIPBTO, QPSOBL, TUNPSO, QVLBTO, TUNVOL, QAROCP, SESTRG)
                                select  RZ65.CREFFW, RZ65.DESCWB, RZ65.TUBRFR, RZ65.QREFFW, RZ65.TIPBTO, RZ65.QPSOBL, RZ65.TUNPSO, RZ65.QVLBTO, RZ65.TUNVOL,
                                        RZ65.QAROCP, RZ65.SESTRG
                                From    RZOL65 RZ65
                                Where   RZ65.CCLNT  = IN_CCLNT
                                  AND   RZ65.CCMPN  = IN_CCMPN
                                  AND   RZ65.CDVSN  = IN_CDVSN
                                  AND   RZ65.CPLNDV = IN_CPLNDV
                                And     RZ65.CREFFW = FILA.BULTO;
                        END IF;
                END IF;
        END FOR;

        SET WK_STRSQL = '       select  CREFFW, DESCWB, TUBRFR, QREFFW, TIPBTO, QPSOBL, TUNPSO, QVLBTO, TUNVOL, QAROCP, SESTRG
                                                From    SESSION.tmpBultos';
        -- Realizamos la preparación de la Consulta para ser ejecutada
        PREPARE S2 FROM WK_STRSQL;
        OPEN CU_02;
END
GO
GRANT ALL PRIVILEGES ON PROCEDURE SP_SOLMIN_SA_SERVICIOS_DETALLE_RZSC31_L02 TO PUBLIC
