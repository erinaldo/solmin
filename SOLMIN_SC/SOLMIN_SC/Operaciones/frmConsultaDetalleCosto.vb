Imports SOLMIN_SC.Negocio
Public Class frmConsultaDetalleCosto
    Private _pNORSCI As Decimal = 0
    Public Property pNORSCI() As Decimal
        Get
            Return _pNORSCI
        End Get
        Set(ByVal value As Decimal)
            _pNORSCI = value
        End Set
    End Property
    Private _pCODVAR As String = ""
    Public Property pCODVAR() As String
        Get
            Return _pCODVAR
        End Get
        Set(ByVal value As String)
            _pCODVAR = value
        End Set
    End Property

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmConsultaDetalleCosto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            kgvDetalleCostos.AutoGenerateColumns = False
            kgvDetalleCostos.DataSource = Nothing
            Dim oDocApertura As New clsDocApertura
            Dim odtDetalleCostos As New DataTable
            odtDetalleCostos = oDocApertura.Listar_Costo_Detalle_Embarque_Rubro_Agencia(_pNORSCI, _pCODVAR)
            kgvDetalleCostos.DataSource = odtDetalleCostos
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub
End Class
