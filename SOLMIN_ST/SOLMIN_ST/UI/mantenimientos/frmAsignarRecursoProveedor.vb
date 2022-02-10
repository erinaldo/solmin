Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos

Public Class frmAsignarRecursoProveedor
    Private strCompania As String = ""
    Sub New(ByVal Compania As String)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        strCompania = Compania
    End Sub
    Private Sub frmAsignarRecursoProveedor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Cargar_Proveedor()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            If Validar_Datos_Obligatorio() Then Exit Sub
            Dim objTransportistaBLL As New Transportista_BLL
            Dim objEntidad As New Transportista
            objEntidad.NRUCTR = cboProveedor.pRucTransportista
            objEntidad.CCMPN = strCompania
            objEntidad.FLARSO = "S"
            objTransportistaBLL.Actualizar_Flag_Recurso_Proveedor(objEntidad)
            MessageBox.Show("Proveedor seleccionado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DialogResult = Windows.Forms.DialogResult.Yes
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Cargar_Proveedor()
        Dim obeProveedor As New Ransa.TypeDef.Transportista.TD_TransportistaPK
        obeProveedor.pCCMPN_Compania = strCompania
        'obeProveedor.pNRUCTR_RucTransportista = strRucProveedor
        cboProveedor.pCargar(obeProveedor)
    End Sub

    Private Function Validar_Datos_Obligatorio() As Boolean
        Dim strMensajeError As String = ""

        If cboProveedor.pRucTransportista.Trim.Equals("") Then strMensajeError &= "* Seleccione proveedor" & vbNewLine

        If strMensajeError.Length > 0 Then
            MessageBox.Show(strMensajeError, "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        End If
        Return False
    End Function

    Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class
