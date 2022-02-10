Public Class clsLiquidacion
    Private objTablaEmb As DataTable
    Private objTablaAdn As DataTable
    Private objTablaPre As DataTable
    Private objTablaSeg As DataTable
    Private objTablaAlm As DataTable
    Private objTablaTra As DataTable

    Sub New()
        objTablaEmb = New DataTable
        objTablaPre = New DataTable
        objTablaSeg = New DataTable
        objTablaAdn = New DataTable
        objTablaAlm = New DataTable
        objTablaTra = New DataTable
    End Sub

    Property TablaAlm()
        Get
            Return objTablaAlm
        End Get
        Set(ByVal value)
            Me.objTablaAlm = value
        End Set
    End Property

    Property TablaTra()
        Get
            Return objTablaTra
        End Get
        Set(ByVal value)
            Me.objTablaTra = value
        End Set
    End Property

    Property TablaAdn()
        Get
            Return objTablaAdn
        End Get
        Set(ByVal value)
            Me.objTablaAdn = value
        End Set
    End Property

    Property TablaSeg()
        Get
            Return objTablaSeg
        End Get
        Set(ByVal value)
            Me.objTablaSeg = value
        End Set
    End Property

    Property TablaPre()
        Get
            Return objTablaPre
        End Get
        Set(ByVal value)
            Me.objTablaPre = value
        End Set
    End Property

    Property TablaEmb()
        Get
            Return objTablaEmb
        End Get
        Set(ByVal value)
            objTablaEmb = value
        End Set
    End Property

    Public Sub Crear_Liquidacion_Adn()
        Dim objDr As DataRow

        objTablaAdn.Columns.Add(New DataColumn("CONCEPTO", GetType(String)))
        objTablaAdn.Columns.Add(New DataColumn("MONTO", GetType(Double)))

        objDr = objTablaAdn.NewRow
        objDr.Item(0) = "ADVALOREM"
        objDr.Item(1) = 0
        objTablaAdn.Rows.Add(objDr)

        objDr = objTablaAdn.NewRow
        objDr.Item(0) = "IGV"
        objDr.Item(1) = 0
        objTablaAdn.Rows.Add(objDr)

        objDr = objTablaAdn.NewRow
        objDr.Item(0) = "IPM"
        objDr.Item(1) = 0
        objTablaAdn.Rows.Add(objDr)

        objDr = objTablaAdn.NewRow
        objDr.Item(0) = "OTROS GASTOS"
        objDr.Item(1) = 0
        objTablaAdn.Rows.Add(objDr)

        objDr = objTablaAdn.NewRow
        objDr.Item(0) = "TOTAL DERECHOS US$"
        objDr.Item(1) = 0
        objTablaAdn.Rows.Add(objDr)

        objDr = objTablaAdn.NewRow
        objDr.Item(0) = "COMISION AGENCIAMIENTO"
        objDr.Item(1) = 0
        objTablaAdn.Rows.Add(objDr)

        objDr = objTablaAdn.NewRow
        objDr.Item(0) = "GASTOS OPERATIVOS AG."
        objDr.Item(1) = 0
        objTablaAdn.Rows.Add(objDr)

        objDr = objTablaAdn.NewRow
        objDr.Item(0) = "GASTOS AG. MARITIMO"
        objDr.Item(1) = 0
        objTablaAdn.Rows.Add(objDr)

        objDr = objTablaAdn.NewRow
        objDr.Item(0) = "GASTOS DE TERMINAL"
        objDr.Item(1) = 0
        objTablaAdn.Rows.Add(objDr)
    End Sub

    Public Sub Crear_Liquidacion_Seg()
        Dim objDr As DataRow

        objTablaSeg.Columns.Add(New DataColumn("CONCEPTO", GetType(String)))
        objTablaSeg.Columns.Add(New DataColumn("MONTO", GetType(Double)))

        objDr = objTablaSeg.NewRow
        objDr.Item(0) = "CARGO DEL EMBARCADOR US$"
        objDr.Item(1) = 0
        objTablaSeg.Rows.Add(objDr)

        objDr = objTablaSeg.NewRow
        objDr.Item(0) = "CARGO DE RANSA US$"
        objDr.Item(1) = 0
        objTablaSeg.Rows.Add(objDr)
    End Sub

    Public Sub Crear_Liquidacion_Emb()
        Dim objDr As DataRow

        objTablaEmb.Columns.Add(New DataColumn("CONCEPTO", GetType(String)))
        objTablaEmb.Columns.Add(New DataColumn("MONTO", GetType(Double)))

        objDr = objTablaEmb.NewRow
        objDr.Item(0) = "EXW US$"
        objDr.Item(1) = 0
        objTablaEmb.Rows.Add(objDr)

        objDr = objTablaEmb.NewRow
        objDr.Item(0) = "GFOB US$"
        objDr.Item(1) = 0
        objTablaEmb.Rows.Add(objDr)

        objDr = objTablaEmb.NewRow
        objDr.Item(0) = "FOB US$"
        objDr.Item(1) = 0
        objTablaEmb.Rows.Add(objDr)

        objDr = objTablaEmb.NewRow
        objDr.Item(0) = "SEGURO US$"
        objDr.Item(1) = 0
        objTablaEmb.Rows.Add(objDr)

        objDr = objTablaEmb.NewRow
        objDr.Item(0) = "FLETE US$"
        objDr.Item(1) = 0
        objTablaEmb.Rows.Add(objDr)

        objDr = objTablaEmb.NewRow
        objDr.Item(0) = "CIF US$"
        objDr.Item(1) = 0
        objTablaEmb.Rows.Add(objDr)

    End Sub

    Public Sub Crear_Liquidacion_Tra()
        Dim objDr As DataRow

        objTablaTra.Columns.Add(New DataColumn("CONCEPTO", GetType(String)))
        objTablaTra.Columns.Add(New DataColumn("MONTO", GetType(Double)))

        objDr = objTablaTra.NewRow
        objDr.Item(0) = "FLETE LOCAL"
        objDr.Item(1) = 0
        objTablaTra.Rows.Add(objDr)

        objDr = objTablaTra.NewRow
        objDr.Item(0) = "CARGA Y DESCARGA"
        objDr.Item(1) = 0
        objTablaTra.Rows.Add(objDr)
    End Sub

    Public Sub Crear_Liquidacion_Alm()
        Dim objDr As DataRow

        objTablaAlm.Columns.Add(New DataColumn("CONCEPTO", GetType(String)))
        objTablaAlm.Columns.Add(New DataColumn("MONTO", GetType(Double)))

        objDr = objTablaAlm.NewRow
        objDr.Item(0) = "ALMACENAJE LOCAL"
        objDr.Item(1) = 0
        objTablaAlm.Rows.Add(objDr)

        objDr = objTablaAlm.NewRow
        objDr.Item(0) = "CARGA Y DESCARGA"
        objDr.Item(1) = 0
        objTablaAlm.Rows.Add(objDr)
    End Sub
End Class
