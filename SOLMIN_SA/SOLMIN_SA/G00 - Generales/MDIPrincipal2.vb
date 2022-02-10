Imports RANSA.NEGO
Imports RANSA.NEGO.slnSOLMIN
Imports System.Reflection
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class MDIPrincipal2
#Region " Atributos "
    Private blnSalirSinAviso As Boolean = False
#End Region

    Private Function pAccesoSistema() As Boolean
        ' Iniciamos las presentación
        Dim strMensajeConexion As String = ""
        Dim bolEsUnico As Boolean
        ' pplication.EnableVisualStyles()
        If clsSeguridad.ConnectionFileExists() And clsSeguridad.LoginFileExists Then
            Dim fSeleccionarSistema As frmSeleccionarSistema = New frmSeleccionarSistema("SA", clsSeguridad.Usuario, bolEsUnico)
            fSeleccionarSistema.StartPosition = FormStartPosition.CenterScreen
            If bolEsUnico Then
                objSeguridadBN = New clsSeguridad(fSeleccionarSistema.pstrTipoSistema, fSeleccionarSistema.pstrDetalleTipoSistema, fSeleccionarSistema.pstrTipoAlmacen, _
                                                                  System.Net.Dns.GetHostName())
                pblnAcceso = objSeguridadBN.pblnStatusConexion
                strMensajeConexion = objSeguridadBN.pstrMensajeConexion
            Else
                If fSeleccionarSistema.ShowDialog = Windows.Forms.DialogResult.OK Then
                    objSeguridadBN = New clsSeguridad(fSeleccionarSistema.pstrTipoSistema, fSeleccionarSistema.pstrDetalleTipoSistema, fSeleccionarSistema.pstrTipoAlmacen, _
                                                      System.Net.Dns.GetHostName())
                    pblnAcceso = objSeguridadBN.pblnStatusConexion
                    strMensajeConexion = objSeguridadBN.pstrMensajeConexion
                Else
                    fSeleccionarSistema.Dispose()
                    fSeleccionarSistema = Nothing
                    Exit Function
                End If
            End If
            fSeleccionarSistema.Dispose()
            fSeleccionarSistema = Nothing
        Else
            ' Elimino el Archivo si no se cumple la condición
            clsSeguridad.ConnectionFileDelete()
            Dim fLogin As frmLogin = New frmLogin
            If fLogin.ShowDialog = Windows.Forms.DialogResult.OK Then
                objSeguridadBN = New clsSeguridad(fLogin.pParametroSeguridad, System.Net.Dns.GetHostName())
                pblnAcceso = objSeguridadBN.pblnStatusConexion
                strMensajeConexion = objSeguridadBN.pstrMensajeConexion
            Else
                fLogin.Dispose()
                fLogin = Nothing
                Exit Function
            End If
            fLogin.Dispose()
            fLogin = Nothing
        End If

        If pblnAcceso Then
            Dim objAppConfig As cAppConfig = New cAppConfig
            ' Colocamos los valores del Usuario
            objAppConfig.ConfigType = 1
            objAppConfig.SetValue("UsuarioLogin", objSeguridadBN.pUsuario)
            objAppConfig.SetValue("RANSA.ConexionODBCUser", objSeguridadBN.pUsuario)
            objAppConfig = Nothing
        Else
            pblnAcceso = False
            MessageBox.Show("Usuario sin permiso para ingresar a la RED de la Empresa." & vbNewLine & strMensajeConexion, _
                            "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return pblnAcceso
    End Function

    Public Sub SolminStatusStrip1_EventDetalleSistema_Click() Handles SolminStatusStrip1.EventDetalleSistema_Click

        Me.SolminMenuStrip1.MMAPLC = SolminStatusStrip1.MMAPLC
        Me.SolminMenuStrip1.MMCUSR = objSeguridadBN.pUsuario
        Me.SolminMenuStrip1.MMCMNU = SolminStatusStrip1.MMCMNU

        Me.SolminMenuStrip1.DataBind = True
        Me.SolminToolStrip1.MMAPLC = SolminStatusStrip1.MMAPLC
        Me.SolminToolStrip1.MMCMNU = SolminStatusStrip1.MMCMNU
        Me.SolminToolStrip1.MMCUSR = objSeguridadBN.pUsuario
        Me.SolminToolStrip1.DataBind = True

        objSeguridadBN.ChangeTypeSystem(SolminStatusStrip1.MMCMNU, SolminStatusStrip1.MMTVAR)
    End Sub

    Public Sub SolminStatusStrip1_EventRutaImpresora_DoubleClick() Handles SolminStatusStrip1.EventRutaImpresora_DoubleClick
        Dim fImpresoras As frmInstalledPrinters = New frmInstalledPrinters(SolminStatusStrip1.RUTA_IMPRESORA)
        With fImpresoras
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                SolminStatusStrip1.RUTA_IMPRESORA = .pSelectedPrinter
                GLOBAL_IMPRESORA_ZEBRA = SolminStatusStrip1.RUTA_IMPRESORA 'oPrinterZebra.pGetPrinterPath(SolminStatusStrip1.RUTA_IMPRESORA)
                Me.SolminStatusStrip1.Text = GLOBAL_IMPRESORA_ZEBRA
            End If
            .Dispose()
            fImpresoras = Nothing
        End With
    End Sub

    Public Sub SolminStatusStrip1_EventBultosSinEtiquetasChecked(ByVal Checked As Boolean) Handles SolminStatusStrip1.EventBultosSinEtiquetasChecked
        tmrIniciarChekeoBulto.Enabled = Checked
    End Sub

  
    Private Sub tmrIniciarChekeoBulto_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrIniciarChekeoBulto.Tick
        ' Deshabilito el Timer
        tmrIniciarChekeoBulto.Enabled = False
        bgwCtrlEtiquetaBulto.RunWorkerAsync()
    End Sub

    Private Sub bgwCtrlEtiquetaBulto_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwCtrlEtiquetaBulto.DoWork
        ' Inicio el proceso de revisión de Bultos que aún no han sido etiquetadas
        If SolminStatusStrip1.CLIENTE = "" Then Exit Sub
        Call mpImprimir_BultosSinEtiquetar(SolminStatusStrip1.CLIENTE)
    End Sub

    Private Sub bgwCtrlEtiquetaBulto_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwCtrlEtiquetaBulto.RunWorkerCompleted
        ' Habilito el Timer para nuevamente chekear si existe nuevas bultos sin paletizar
        tmrIniciarChekeoBulto.Enabled = True
    End Sub

    Public Sub SolminStatusStrip1_EventImprimir_PaletasSinEtiquetar(ByVal Checked As Boolean) Handles SolminStatusStrip1.EventPaletasSinEtiquetasChecked
        tmrIniciarChekeoPaleta.Enabled = Checked
    End Sub

    Private Sub tmrIniciarChekeoPaleta_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrIniciarChekeoPaleta.Tick
        ' Deshabilito el Timer
        tmrIniciarChekeoPaleta.Enabled = False
        bgwCtrlEtiquetaPaleta.RunWorkerAsync()
    End Sub

    Private Sub bgwCtrlEtiquetaPaleta_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwCtrlEtiquetaPaleta.DoWork
        ' Inicio el proceso de revisión de las paletas que aún no han sido etiquetadas
        If SolminStatusStrip1.CLIENTE = "" Then Exit Sub
        Call mpImprimir_PaletasSinEtiquetar(SolminStatusStrip1.CLIENTE)
    End Sub

    Private Sub bgwCtrlEtiquetaPaleta_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwCtrlEtiquetaPaleta.RunWorkerCompleted
        ' Habilito el Timer para nuevamente chekear si existe nuevas paletas sin paletizar
        tmrIniciarChekeoPaleta.Enabled = True
    End Sub

    Private Sub pPresentarSistemas()

        Me.SolminStatusStrip1.MMAPLC = "SA"
        Me.SolminStatusStrip1.MMCMNU = objSeguridadBN.pstrTipoSistema
        Me.SolminStatusStrip1.MMCUSR = objSeguridadBN.pUsuario
        Me.SolminStatusStrip1.SERVIDOR = objSeguridadBN.pstrDetalleBaseDatos
        Me.SolminStatusStrip1.USUARIO = objSeguridadBN.pUsuario
        Me.SolminStatusStrip1.DataBind = True
        GLOBAL_IMPRESORA_ZEBRA = Me.SolminStatusStrip1.RUTA_IMPRESORA

        Me.SolminMenuStrip1.MMAPLC = SolminStatusStrip1.MMAPLC
        Me.SolminMenuStrip1.MMCMNU = SolminStatusStrip1.MMCMNU
        Me.SolminMenuStrip1.MMCUSR = objSeguridadBN.pUsuario
        Me.SolminMenuStrip1.DataBind = True

        Me.SolminToolStrip1.MMAPLC = SolminStatusStrip1.MMAPLC
        Me.SolminToolStrip1.MMCMNU = SolminStatusStrip1.MMCMNU
        Me.SolminToolStrip1.MMCUSR = objSeguridadBN.pUsuario
        Me.SolminToolStrip1.DataBind = True

        objSeguridadBN.ChangeTypeSystem(SolminStatusStrip1.MMCMNU, SolminStatusStrip1.MMTVAR)
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue
    End Sub

    Private Sub pCargarFuenteCodBarra()
        If My.Computer.FileSystem.DirectoryExists("C:\WINDOWS\Fonts") Then
            'My.Computer.FileSystem.CopyFile(Environment.CurrentDirectory() & " \Fuentes\IDAutomationHC39M.ttf", "c:\WINDOWS\Fonts\IDAutomationHC39M.ttf", True)
        End If
    End Sub

    Private Sub MDIPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Desactivar para las pruebas internas
        If ConfigurationWizard.LoginFileExists = False Then
            MsgBox("Debe de iniciar la sesion desde el aplicativo LOGIN")
            blnSalirSinAviso = True
            Application.Exit()
            Me.Close()
            Exit Sub
        End If


        If Not pAccesoSistema() Then
            blnSalirSinAviso = True
            Me.Close()
            Exit Sub
        End If
        Call pPresentarSistemas()
        Call pCargarFuenteCodBarra()
        Ransa.Utilitario.MainModuleDeploy.SetQueryStringParametersDeploy()
        'Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy = "EZ"
        GLOBAL_COMPANIA = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
        Try
            Using fl As New IO.StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\SOLMIN_SA_PATH")
                fl.WriteLine(Application.StartupPath)
                fl.Close()
                fl.Dispose()
            End Using
        Catch : End Try
    End Sub

    Private Sub MDIAlmacenTransito_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If Not blnSalirSinAviso Then objSeguridadBN.Dispose()


    End Sub

    Private Sub MDIAlmacen_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not blnSalirSinAviso Then
            If Not mfblnSalirAplicativo() Then e.Cancel = True
        End If
    End Sub


    Public Shared Function getAppVersion() As String
        Dim version As String = " 1.0"
        Try

            Dim verDeployed As System.Version

            Dim strVerDeployed As String

            If (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed) Then

                verDeployed = My.Application.Deployment.CurrentVersion

                strVerDeployed = verDeployed.ToString

            Else ' or if command line execution

                Dim asmThis As System.Reflection.Assembly = System.Reflection.Assembly.Load("CADView")

                Dim asnThis As System.Reflection.AssemblyName = asmThis.GetName()

                verDeployed = asnThis.Version

                strVerDeployed = verDeployed.ToString

            End If

            version = strVerDeployed

        Catch ex As Exception

        End Try
        Return version

    End Function

    Private Sub SolminStatusStrip1_EventObtenerVersion(ByRef strVersion As String) Handles SolminStatusStrip1.EventObtenerVersion
        strVersion = getAppVersion()
    End Sub


End Class
