Imports SOLMIN_ST.NEGOCIO.operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Public Class frmSegMargen

    Private _NOPRCN As Decimal = 0
    Public Property NOPRCN() As Decimal
        Get
            Return _NOPRCN
        End Get
        Set(ByVal value As Decimal)
            _NOPRCN = value
        End Set
    End Property

    Private _CCMPN As String = ""
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property


    Private Sub frmSegMargen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dgMargenes.AutoGenerateColumns = False
            Dim oGuiaTransporte As New GuiaTransportista_BLL
            Dim dt As New DataTable
            dt = oGuiaTransporte.Listar_Seguimiento_Operacion_Margen(_CCMPN, _NOPRCN)
            dgMargenes.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
