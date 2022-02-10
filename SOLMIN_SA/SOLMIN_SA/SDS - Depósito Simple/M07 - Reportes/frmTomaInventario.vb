Imports Ransa.TypeDef.Cliente
Imports RANSA.TypeDef
Imports RANSA.NEGO.slnSOLMIN_SDS
Imports RANSA.NEGO
Imports RANSA.Utilitario

Public Class frmTomaInventario

#Region " Atributos "
#End Region
#Region " Propiedades "
#End Region
#Region " Funciones y Procedimientos "
    Private Sub Cargar_Clientes()
        Dim intTemp As Int64 = 0
        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
        txtCliente.pCargar(ClientePK)
    End Sub
    Private Sub Cargar_Permiso()
        Dim objParametro As New Hashtable
        Dim objLogica As New brUsuario
        Dim objEntidad As New beUsuario

        objParametro.Add("MMCAPL", objLogica.getAppSetting("System_prefix"))
        objParametro.Add("MMCUSR", objSeguridadBN.pUsuario)
        objParametro.Add("MMNPVB", Me.Name.Trim)
        objEntidad = objLogica.Validar_Usuario_Autorizado(objParametro)

        If objEntidad.STSOP1 = "" Then
            tsbInicializar.Visible = False
        Else
            tsbInicializar.Visible = True
        End If
    End Sub
#End Region
#Region " Eventos "

    Private Sub frmRecepcionGuia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Cargar_Clientes()
            Cargar_Permiso()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        Try
            dgTomaInventario.DataSource = Nothing
            Dim dt As DataTable = New blTomaInvertario().ProcesarTomaInvertario(txtCliente.pCodigo)
            If (dt.Rows.Count > 0) Then
                dgTomaInventario.DataSource = dt
            Else
                dgTomaInventario.DataSource = Nothing
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tsbInicializar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbInicializar.Click
        Try
            Try
                If (MessageBox.Show("Está seguro de eliminar el inventario", "Eliminar Inventario", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK) Then
                    Dim CCLNT As String = txtCliente.pCodigo
                    Dim i As Integer = New blTomaInvertario().InicializarInvertario(CCLNT)
                    If i > 0 Then
                        MessageBox.Show("Inicializacion Conforme")
                        btnProcesar_Click(Nothing, Nothing)
                    Else
                        MessageBox.Show("Ocurrion un error al Inicializacion el Inventario")
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Ocurrion un error al Inicializacion el Inventario")
            End Try


          
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tsbExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportar.Click
        Try
            'Call mpGenerarXLS("TomaInventario", dgTomaInventario.DataSource)
            Dim olDtg As New List(Of DataGridView)
            olDtg.Add(dgTomaInventario)
            HelpClass.ExportarExcel_HTML(olDtg)
        Catch ex As Exception
        End Try
    End Sub
#End Region
End Class
