Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Negocio
Public Class frmDatosPreTarifa
    Private CCMPN As String = ""
    Public Property CodCompania() As String
        Get
            Return CCMPN
        End Get
        Set(ByVal value As String)
            CCMPN = value
        End Set
    End Property
    Private CDVSN As String = ""
    Public Property CodDivision() As String
        Get
            Return CDVSN
        End Get
        Set(ByVal value As String)
            CDVSN = value
        End Set
    End Property

    Private _NRO_TARIFA As Decimal = 0
    Public Property NRO_TARIFA() As Decimal
        Get
            Return _NRO_TARIFA
        End Get
        Set(ByVal value As Decimal)
            _NRO_TARIFA = value
        End Set
    End Property
    Private Sub frmDatosPreTarifa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim dtTarifa As New DataTable
            Dim oclsDespachoNacional As New clsDespachoNacional
            dtTarifa = oclsDespachoNacional.Listar_Datos_Tarifa_Asignada(CCMPN, CDVSN, _NRO_TARIFA)
            If dtTarifa.Rows.Count > 0 Then
                txtTarifa.Text = _NRO_TARIFA
                txtDesc.Text = ("" & dtTarifa.Rows(0)("NOMSER")).ToString.Trim
                txtmoneda.Text = dtTarifa.Rows(0)("TMNDA")
                txtValServicio.Text = dtTarifa.Rows(0)("IVLSRV")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
