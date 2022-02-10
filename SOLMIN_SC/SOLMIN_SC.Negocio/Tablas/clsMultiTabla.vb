Public Class clsMultiTabla
    Private oMultiTabla As Datos.clsMultiTabla
    Private strTabla As String
    Private oDtTablas As DataTable
    Private oDtDetalles As DataTable

    Sub New()
        oMultiTabla = New Datos.clsMultiTabla
    End Sub

    Property Tabla()
        Get
            Return Me.strTabla
        End Get
        Set(ByVal value)
            Me.strTabla = value
        End Set
    End Property

    Property Lista_Tablas()
        Get
            Return oDtTablas
        End Get
        Set(ByVal value)
            oDtTablas = value
        End Set
    End Property

    Property Lista_Detalles()
        Get
            Return Me.oDtDetalles
        End Get
        Set(ByVal value)
            oDtDetalles = value
        End Set
    End Property

    Public Sub Crea_Tablas()
        Dim oDr As DataRow
        oDtTablas = New DataTable
        oDtTablas.Columns.Add(New DataColumn("COD", GetType(System.String)))
        oDtTablas.Columns.Add(New DataColumn("DES", GetType(System.String)))

        oDr = oDtTablas.NewRow
        oDr.Item("COD") = "C"
        oDr.Item("DES") = "Compañía de Transportes"
        oDtTablas.Rows.Add(oDr)

        oDr = oDtTablas.NewRow
        oDr.Item("COD") = "A"
        oDr.Item("DES") = "Embarcador"
        oDtTablas.Rows.Add(oDr)

        oDr = oDtTablas.NewRow
        oDr.Item("COD") = "V"
        oDr.Item("DES") = "Vapor"
        oDtTablas.Rows.Add(oDr)
    End Sub

    Public Sub Crea_Detalles()
        oDtDetalles = oMultiTabla.Lista_Tabla(Me.strTabla)
    End Sub

    Public Sub Mantenimiento_Vapor(ByVal pstrTipo As String, ByVal pstrCod As String, ByVal pstrDes As String, ByVal pstrEstado As String, ByVal pstrTerminal As String)
        oMultiTabla.Mantenimiento_Vapor(pstrTipo, pstrCod, pstrDes, pstrEstado, pstrTerminal)
    End Sub

    Public Sub Mantenimiento_CiaTransporte(ByVal pstrTipo As String, ByVal pdblCod As Double, ByVal pstrMedio As String, ByVal pstrDes As String, ByVal pstrEstado As String, ByVal pstrPais As String)
        oMultiTabla.Mantenimiento_CiaTransporte(pstrTipo, pdblCod, pstrMedio, pstrDes, pstrEstado, Double.Parse(pstrPais))
    End Sub

    Public Sub Mantenimiento_Embarcador(ByVal pstrTipo As String, ByVal pdblCod As Double, ByVal pstrDes As String, ByVal pstrEstado As String, ByVal pstrPais As String)
        oMultiTabla.Mantenimiento_Embarcador(pstrTipo, pdblCod, pstrDes, pstrEstado, Double.Parse(pstrPais))
    End Sub
End Class
