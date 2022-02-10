Imports Ransa.TypeDef
Imports RANSA.NEGO
Public Class frmInventarioUbicacion
   Public obeMercaderia As New beMercaderia()   
    Private Sub frmInventarioUbicacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LimpiarControles()
            txtCliente.Text = obeMercaderia.PSTCMPCL
            txtMercaderia.Text = obeMercaderia.PSTMRCD2
            txtFamilia.Text = obeMercaderia.PSTFMCLR
            txtGrupo.Text = obeMercaderia.PSTGRCLR
            dgMercaderiaGuia.AutoGenerateColumns = False
            dgMercaderiaGuia.DataSource = Nothing
            dgMercaderiaGuia.DataSource = mfdtListar_OrdenesServicioPorMercaderia(obeMercaderia.PNCCLNT, obeMercaderia.PSCMRCLR)          
        Catch ex As Exception
        End Try
      
    End Sub
    Private Sub LimpiarControles()
        txtCliente.Text = ""
        txtMercaderia.Text = ""
        txtFamilia.Text = ""
        txtGrupo.Text = ""

        txtCliente.Enabled = False
        txtMercaderia.Enabled = False
        txtFamilia.Enabled = False
        txtGrupo.Enabled = False

    End Sub

    'Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
    '    If mfblnSalirOpcion() Then
    '        Me.Close()
    '    End If
    'End Sub

    Private Sub dgMercaderiaGuia_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgMercaderiaGuia.CellClick
        Try
            Dim ds As New DataSet()
            ds = New blInventarioMercaderia().ListarInventarioMercaderiaxUbicacion(obeMercaderia)
            dgMercaderiaGuia.DataSource = ds.Tables(0)
        Catch ex As Exception
        End Try
     
    End Sub
End Class
