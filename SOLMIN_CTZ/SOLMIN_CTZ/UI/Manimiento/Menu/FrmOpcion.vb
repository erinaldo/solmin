Imports System.Text
Imports Ransa.Controls.Menu
Public Class FrmOpcion
    Private _pMMCAPL_CodApl As String = ""
    Public Property pMMCAPL_CodApl() As String
        Get
            Return _pMMCAPL_CodApl
        End Get
        Set(ByVal value As String)
            _pMMCAPL_CodApl = value
        End Set
    End Property

    Private _pMMCMNU_CodMnu As String = ""
    Public Property pMMCMNU_CodMnu() As String
        Get
            Return _pMMCMNU_CodMnu
        End Get
        Set(ByVal value As String)
            _pMMCMNU_CodMnu = value
        End Set
    End Property

  Private Sub FrmOpcion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try
      If _pMMCAPL_CodApl <> "" AndAlso _pMMCMNU_CodMnu <> "" Then
        Uc_CboAplicacion1.pObtenerAplicacion(_pMMCAPL_CodApl)
        Uc_CboAplicacion1.Enabled = False
        Uc_CboMenu1.Enabled = False
        Uc_CboMenu1.pObtenerMenu(_pMMCAPL_CodApl, _pMMCMNU_CodMnu)
        UcOpcionBusq_pBuscar()
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  
  End Sub

  Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown, txtDescripcion.KeyDown
    Try
      If e.KeyCode = Keys.Enter Then
        UcOpcionBusq_pBuscar()
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

    Private Sub BuscarOpcion(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            UcOpcionBusq_pBuscar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

  Private Sub Cambio_Aplicacion() Handles Uc_CboAplicacion1.InformationChanged
    Try
      UcOpcionBusq.pActualizarDatosNothing()
      dgvUsuario.DataSource = Nothing
      Uc_CboMenu1.pPSMMCAPL = Uc_CboAplicacion1.pPSMMCAPL
      UcOpcionBusq.pInfo_MMCMNU_CodMenu = ""
      Uc_CboMenu1.pClear()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

    Private Sub UcOpcionBusq_pBuscar() Handles UcOpcionBusq.pBuscar
    Try
      Dim obeOpcion As New beOpcion
      Dim msgValidacion As String = Valida_Campos()
      If msgValidacion.Length > 0 Then
        MessageBox.Show("Falta seleccionar lo siguiente:" & Chr(13) & msgValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Exit Sub
      Else

        UcOpcionBusq.pInfo_MMCAPL_CodApl = Uc_CboAplicacion1.pPSMMCAPL
        UcOpcionBusq.pInfo_MMCMNU_CodMenu = Uc_CboMenu1.pPSMMCMNU

        obeOpcion.PSMMCAPL_CodApl = Uc_CboAplicacion1.pPSMMCAPL
        obeOpcion.PSMMCMNU_CodMnu = Uc_CboMenu1.pPSMMCMNU
        If Me.txtCodigo.Text = Nothing Then
          obeOpcion.PNMMCOPC_CodOpc_Ini = 0
          obeOpcion.PNMMCOPC_CodOpc_Fin = 99
        Else
          obeOpcion.PNMMCOPC_CodOpc_Ini = Val(Me.txtCodigo.Text)
          obeOpcion.PNMMCOPC_CodOpc_Fin = Val(Me.txtCodigo.Text)
        End If
        obeOpcion.PSMMDOPC_DesOpc = txtDescripcion.Text.ToUpper
        UcOpcionBusq.pActualizarDatos(obeOpcion)
        If UcOpcionBusq.pnumReg = 0 Then
          dgvUsuario.DataSource = Nothing
        End If
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub


  Private Sub UcOpcionBusq_pSelectionOpcionChanged() Handles UcOpcionBusq.pSelectionOpcionChanged
    Try
      dgvUsuario.DataSource = Nothing
      dgvUsuario.AutoGenerateColumns = False
      Dim oUsuario_DAL As New clsUsuario_DAL
      Dim dt As New DataTable
      Dim obeUsuario As New beUsuario
      obeUsuario.PSMMCAPL_CodApl = UcOpcionBusq.pInfo_MMCAPL_CodApl
      obeUsuario.PSMMCMNU_CodMnu = UcOpcionBusq.pInfo_MMCMNU_CodMenu
      obeUsuario.PNMMCOPC_CodOpc = UcOpcionBusq.pInfo_MMCOPC_CodOpc
      dt = oUsuario_DAL.Listar_Usuario_x_Opcion(obeUsuario)
      dgvUsuario.DataSource = dt
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
   
  End Sub

  Private Function Valida_Campos() As String
    Dim sbMensaje As New StringBuilder
    If Uc_CboAplicacion1.pPSMMCAPL = "" Then
      sbMensaje.AppendLine("* Aplicación")
    End If
    If Uc_CboMenu1.pPSMMCMNU = "" Then
      sbMensaje.AppendLine("* Menú")
    End If
    Return sbMensaje.ToString
  End Function

  Private Sub Cambio_Menu() Handles Uc_CboMenu1.InformationChanged
    Try
      If Uc_CboMenu1.pPSMMCAPL <> "" AndAlso Uc_CboMenu1.pPSMMCMNU <> "" AndAlso Uc_CboMenu1.pPSMMTMNU <> "" Then
        UcOpcionBusq_pBuscar()
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub
End Class
