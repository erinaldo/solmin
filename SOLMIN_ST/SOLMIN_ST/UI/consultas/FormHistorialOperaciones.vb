Imports SOLMIN_ST.NEGOCIO.Operaciones
Public Class FormHistorialOperaciones

    Private _Compania As String
    Public Property Compania() As String
        Get
            Return _Compania
        End Get
        Set(ByVal value As String)
            _Compania = value
        End Set
    End Property

    Private _Division As String
    Public Property Division() As String
        Get
            Return _Division
        End Get
        Set(ByVal value As String)
            _Division = value
        End Set
    End Property


    Private _Operacion As Double
    Public Property Operacion() As Double
        Get
            Return _Operacion
        End Get
        Set(ByVal value As Double)
            _Operacion = value
        End Set
    End Property
    Private Sub FormHistorialOperaciones_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Listar_Documentos_Emitidos_x_Operacion()
    End Sub
    Private Sub Listar_Documentos_Emitidos_x_Operacion()
        Dim parametros As New Hashtable
        Dim ReFacturaDAL As New ReFacturacion_BLL
        Dim dt As DataTable

        parametros.Add("PSCCMPN", Compania)
        parametros.Add("PSCDVSN", Division)
        parametros.Add("PNNOPRCN", Operacion)
        dt = ReFacturaDAL.Listar_Documentos_Emitidos_x_Operacion(parametros)
        Me.dgwDocumentosEmitidos.Rows.Clear()
        For i As Integer = 0 To dt.Rows.Count - 1
            Me.dgwDocumentosEmitidos.Rows.Add(1)
            Me.dgwDocumentosEmitidos.Item("NOPRCN", i).Value = dt.Rows(i).Item("NOPRCN")
            Me.dgwDocumentosEmitidos.Item("NGUIRM", i).Value = dt.Rows(i).Item("NGUIRM")
            Me.dgwDocumentosEmitidos.Item("TCMTRF", i).Value = dt.Rows(i).Item("TCMTRF")
            Me.dgwDocumentosEmitidos.Item("QCNDTG", i).Value = dt.Rows(i).Item("QCNDTG")
            Me.dgwDocumentosEmitidos.Item("CUNDSR", i).Value = dt.Rows(i).Item("CUNDSR")
            Me.dgwDocumentosEmitidos.Item("ISRVGU", i).Value = dt.Rows(i).Item("ISRVGU")
            Me.dgwDocumentosEmitidos.Item("TMNDA", i).Value = dt.Rows(i).Item("TMNDA").ToString.Trim
            Me.dgwDocumentosEmitidos.Item("TCMTPD", i).Value = dt.Rows(i).Item("TCMTPD").ToString.Trim
            Me.dgwDocumentosEmitidos.Item("NDCMFC", i).Value = dt.Rows(i).Item("NDCMFC")
            Me.dgwDocumentosEmitidos.Item("FECFAC", i).Value = HelpClass.CFecha_de_8_a_10(dt.Rows(i).Item("FECFAC"))
        Next
    End Sub
End Class
