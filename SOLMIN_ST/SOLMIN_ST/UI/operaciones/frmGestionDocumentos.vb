Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Text

Public Class frmGestionDocumentos

#Region "Declarcion de Variables"
  Public Compania As String = String.Empty
  Public CompaniaDescripcion As String = String.Empty
  Public Division As String = String.Empty
  Public CodPlanta As String = String.Empty



  Private nCorrEnvio As Integer = 0
#End Region

#Region "Procedimiento y funciones"




#End Region

#Region "Eventos de Control"

  Private Sub Mostrar_Usuario()
    Try
      Dim objLogica As New NEGOCIO.Acceso_Opciones_Usuario_BLL
      Dim objhash As New Hashtable
      objhash.Add("MMCUSR", USUARIO)
      objhash.Add("CCMPN", Compania)
      Me.txtUsuario.Text = objLogica.Nombre_Usuario(objhash)
    Catch ex As Exception
      HelpClass.MsgBox(ex.Message, MessageBoxIcon.Information)
    End Try
  End Sub

  Private Sub frmGestionDocumentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Dim objDataTable As DataTable = ObtenerEstadosOperacion()
    Me.Mostrar_Usuario()
    Me.cboAreaResponsable.DataSource = objDataTable
    Me.cboAreaResponsable.DisplayMember = "ESTADO_NOPRCN"
    Me.cboAreaResponsable.ValueMember = "VALUE"
    Me.dtpFecha.Value = Date.Today
    Me.txtHora.Text = HelpClass.Now_Hora
    Me.cboAreaResponsable.SelectedIndex = 1
  End Sub

  Private Function ObtenerEstadosOperacion() As DataTable
    Dim oDt As New DataTable
    oDt.TableName = "dtResumenEstado"
    Dim oDr As DataRow
    oDt.Columns.Add("VALUE", Type.GetType("System.String"))
    oDt.Columns.Add("ESTADO_NOPRCN", Type.GetType("System.String"))

    oDr = oDt.NewRow
    oDr.Item(0) = "G"
    oDr.Item(1) = "GENERADO"
    oDt.Rows.Add(oDr)

    oDr = oDt.NewRow
    oDr.Item(0) = "O"
    oDr.Item(1) = "OPERACIONES"
    oDt.Rows.Add(oDr)

    oDr = oDt.NewRow
    oDr.Item(0) = "A"
    oDr.Item(1) = "ADMINISTRACION"
    oDt.Rows.Add(oDr)

    Return oDt

  End Function

  Private Sub txtDocumentos_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDocumentos.KeyDown
    If e.KeyCode = Keys.Enter Then
      ObtenerOperacion()
    End If
  End Sub

  Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
    If dtgDocumentos.Rows.Count = 0 Then Exit Sub
    CType(dtgDocumentos.DataSource, DataTable).Rows.Remove(CType(Me.dtgDocumentos.CurrentRow.DataBoundItem, DataRowView).Row)
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
    'Me.DialogResult = Windows.Forms.DialogResult.Cancel
    Me.Close()
    gintEstadoDocOperacion = 0
  End Sub

  Private Sub ObtenerOperacion()
    Dim oDt As New DataTable
    Dim objLogicaReportes As New ReportesVariados_BLL

    Dim ht As New Hashtable

    ht.Add("CCMPN", Compania)
    ht.Add("CDVSN", Division)
    ht.Add("CPLNDV", CodPlanta)
    ht.Add("CCLNT", 0)
    ht.Add("FINCOP_IN", 0)
    ht.Add("FINCOP_FI", 99999999)
    ht.Add("ESTADO", "T")
    ht.Add("NOPRCN", txtDocumentos.Text)
        'ht.Add("NGUITR", 0)
        ht.Add("NGUITR", "")
    ht.Add("CMEDTR", 0)
    ht.Add("CULUSA", "")
    ht.Add("ESTADO_OPER", "T")
    ht.Add("VARCON", 0)

    oDt = objLogicaReportes.Lista_Operaciones_Seguimiento_Administrativo(ht)
    If oDt.Rows.Count > 0 Then
      dtgDocumentos.AutoGenerateColumns = False
      If dtgDocumentos.DataSource Is Nothing Then
        dtgDocumentos.DataSource = oDt
      Else

        For Each oDr As DataRow In oDt.Rows
          If Not fblBuscaOperacion(oDr("NOPRCN")) Then
            dtgDocumentos.DataSource.ImportRow(oDr)
          End If
        Next
      End If
      txtDocumentos.Text = ""
    End If

  End Sub

  Private Function fblBuscaOperacion(ByVal psOperacion As String) As Boolean
    For Each dr As DataRow In dtgDocumentos.DataSource.Rows
      If psOperacion = dr("NOPRCN") Then
        Return True
      End If
    Next
    Return False
  End Function

  Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

    If dtgDocumentos.RowCount = 0 Then Exit Sub

    If txtResponsable.Text.Trim.Length = 0 Then
      MessageBox.Show("Ingrese un responsable", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      txtResponsable.Focus()
      Exit Sub
    End If

    If txtObs.Text.Trim.Length = 0 Then
      MessageBox.Show("Ingrese una Observación", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      txtResponsable.Focus()
      Exit Sub
    End If

    If txtHora.Text.Trim.Length > 1 Then
      If IsDate(txtHora.Text) = False Then
        MessageBox.Show("Hora Incorrecta", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtHora.Focus()
        Exit Sub
      End If
    End If

    Dim ofrmEnvio As New frmEnvioCorreoDocumentos
    ofrmEnvio.nSeguimiento = cboAreaResponsable.SelectedValue
    ofrmEnvio.sSeguimiento = cboAreaResponsable.Text.Trim
    ofrmEnvio.sFecha = dtpFecha.Value.ToShortDateString
    ofrmEnvio.sHora = IIf(txtHora.Text.Trim.Equals(":"), Now.Hour.ToString.PadLeft(2, "0") & ":" & Now.Minute.ToString.PadLeft(2, "0") & ":" & Now.Second.ToString.PadLeft(2, "0"), txtHora.Text)
    ofrmEnvio.sResponsable = txtResponsable.Text.Trim
    ofrmEnvio.sObs = txtObs.Text.Trim
    ofrmEnvio.oDtDocumentos = dtgDocumentos.DataSource
    ofrmEnvio.txtAsunto.Text = "Transferencia de Operaciones"

    ofrmEnvio.sUsuario = ConfigurationWizard.UserName
    ofrmEnvio.CompaniaDescripcion = CompaniaDescripcion
    ofrmEnvio.txtCopia.Text = ConfigurationWizard.UserName & "@RANSA.NET"

    If ofrmEnvio.ShowDialog = Windows.Forms.DialogResult.Yes Then
      Me.Close()
      gintEstadoDocOperacion = 1
    End If

  End Sub

  Private Sub txtHora_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtHora.Validating
    If txtHora.Text.Trim.Length > 1 Then
      If IsDate(txtHora.Text) = False Then
        MessageBox.Show("Hora Incorrecta", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtHora.Focus()
      End If
    End If

  End Sub

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    Dim ofrm As New frmFiltroOperacion
    Dim oDt As New DataTable
    ofrm.compania = Compania
    ofrm.Division = Division

    If ofrm.ShowDialog = Windows.Forms.DialogResult.Yes Then

      oDt = ofrm.oDtOperaciones
      If oDt.Rows.Count > 0 Then
        dtgDocumentos.AutoGenerateColumns = False
        If dtgDocumentos.DataSource Is Nothing Then
          dtgDocumentos.DataSource = oDt
        Else

          For Each oDr As DataRow In oDt.Rows
            If Not fblBuscaOperacion(oDr("NOPRCN")) Then
              dtgDocumentos.DataSource.ImportRow(oDr)
            End If
          Next
        End If

      End If

    End If
  End Sub

#End Region

  
    Private Sub tsmadjuntar_x_op_Click(sender As Object, e As EventArgs) Handles tsmadjuntar_x_op.Click
        Try
            'If dtgRecursosAsignados.CurrentRow Is Nothing Then
            '    Exit Sub
            'End If
            'If gwdDatos.CurrentRow Is Nothing Then
            '    Exit Sub
            'End If
            'gwdDatos

            'NOPRCN
            'If dtgDocumentos.CurrentRow.Cells("NOPRCN").Value = 0 Then
            '    MessageBox.Show("No tiene número operación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    Exit Sub
            'End If
            If dtgDocumentos.CurrentRow Is Nothing Then
                Exit Sub
            End If

            Dim CodCompania As String = Compania
            Dim NroOperacion As String = dtgDocumentos.CurrentRow.Cells("NOPRCN").Value
            Dim ofrmCargaAdjuntos As New StorageFileManager.frmCargaAdjuntos
            ofrmCargaAdjuntos.pCarpetaBucketDestino = System.Configuration.ConfigurationManager.AppSettings("bucketDestino").ToString
            ofrmCargaAdjuntos.pCodCompania = Compania
            ofrmCargaAdjuntos.pNroImagen = dtgDocumentos.CurrentRow.Cells("NMRGIM_O").Value
            ofrmCargaAdjuntos.pNroImagenGetUltimo = True
            ofrmCargaAdjuntos.pTablaRelacions = StorageFileManager.frmCargaAdjuntos.Tabla_Relacion.RZTR05
            ofrmCargaAdjuntos.pAsignarCargaMotivo("RZTR05", "05")
            ofrmCargaAdjuntos.pAsignar_ParametroTablaRelacion_RZTR05(CodCompania, NroOperacion)
            ofrmCargaAdjuntos.ShowDialog()

            If ofrmCargaAdjuntos.pDialog = True Then
                dtgDocumentos.CurrentRow.Cells("NMRGIM_O").Value = ofrmCargaAdjuntos.pNroImagen
                If ofrmCargaAdjuntos.pNroImagen > 0 Then
                    dtgDocumentos.CurrentRow.Cells("NMRGIM_IMG").Value = "X"
                Else
                    dtgDocumentos.CurrentRow.Cells("NMRGIM_IMG").Value = ""
                End If

            End If

            'dtgRecursosAsignados.CurrentRow.Cells("NMRGIM1").Value

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tsmadjuntar_x_sol_Click(sender As Object, e As EventArgs) Handles tsmadjuntar_x_sol.Click
        Try
            If dtgDocumentos.CurrentRow Is Nothing Then
                Exit Sub
            End If

            Dim CodCompania As String = Compania
            Dim NroSolicitud As Decimal = dtgDocumentos.CurrentRow.Cells("NCSOTR").Value

            Dim ofrmCargaAdjuntos As New StorageFileManager.frmCargaAdjuntos
            ofrmCargaAdjuntos.pCarpetaBucketDestino = System.Configuration.ConfigurationManager.AppSettings("bucketDestino").ToString
            ofrmCargaAdjuntos.pCodCompania = Compania
            ofrmCargaAdjuntos.pNroImagen = dtgDocumentos.CurrentRow.Cells("NMRGIM_S").Value
            ofrmCargaAdjuntos.pNroImagenGetUltimo = True
            ofrmCargaAdjuntos.pTablaRelacions = StorageFileManager.frmCargaAdjuntos.Tabla_Relacion.RZST07
            ofrmCargaAdjuntos.pAsignarCargaMotivo("RZST07", "02")
            ofrmCargaAdjuntos.pAsignar_ParametroTablaRelacion_RZST07(CodCompania, NroSolicitud)
            ofrmCargaAdjuntos.ShowDialog()

            If ofrmCargaAdjuntos.pDialog = True Then
                dtgDocumentos.CurrentRow.Cells("NMRGIM_S").Value = ofrmCargaAdjuntos.pNroImagen
                If ofrmCargaAdjuntos.pNroImagen > 0 Then
                    dtgDocumentos.CurrentRow.Cells("NMRGIM_IMG").Value = "X"
                Else
                    dtgDocumentos.CurrentRow.Cells("NMRGIM_IMG").Value = ""
                End If

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
