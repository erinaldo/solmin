Imports Ransa.Controls.Menu
Public Class FrmMenu
    Private _pMMCAPL_CodApl As String = ""
    Public Property pMMCAPL_CodApl() As String
        Get
            Return _pMMCAPL_CodApl
        End Get
        Set(ByVal value As String)
            _pMMCAPL_CodApl = value
        End Set
    End Property


    Private Sub FrmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If _pMMCAPL_CodApl <> "" Then
                Uc_CboAplicacion1.pObtenerAplicacion(_pMMCAPL_CodApl)
                Uc_CboAplicacion1.Enabled = False
                UcMenuBusq_pBuscar()
            End If
        Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

  Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown, txtDescripcion.KeyDown
    Try
      If e.KeyCode = Keys.Enter Then
        UcMenuBusq_pBuscar()
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub UcMenuBusq_pBuscar() Handles UcMenuBusq.pBuscar
    Try
      Dim oclsMenu_DAL As New clsMenu_DAL
      Dim obeMenu As New beMenu
      If Uc_CboAplicacion1.pPSMMCAPL = "" Then
        MessageBox.Show("Debe de seleccionar una aplicación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Exit Sub
      End If
      UcMenuBusq.pInfo_MMCAPL_CodApl = Uc_CboAplicacion1.pPSMMCAPL
      obeMenu.PSMMCAPL_CodApl = Uc_CboAplicacion1.pPSMMCAPL
      obeMenu.PSMMCMNU_CodMnu = txtCodigo.Text
      obeMenu.PSMMTMNU_DesMnu = txtDescripcion.Text.ToUpper
      UcMenuBusq.pActualizarDatos(obeMenu)
      If UcMenuBusq.pnumReg = 0 Then
        UcOpcionBusq.pActualizarDatosNothing()
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

    'Private Sub UcMenuBusq_EventChanged() Handles UcMenuBusq.EventChanged
    '  Try
    '    UcMenuBusq_pSelectionMenuChanged()
    '  Catch ex As Exception
    '    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '  End Try

    'End Sub

  Private Sub UcMenuBusq_pSelectionMenuChanged() Handles UcMenuBusq.pSelectionMenuChanged
    Try
      Dim oclsOpcion_DAL As New clsOpcion_DAL
      Dim obeOpcion As New beOpcion
      obeOpcion.PSMMCAPL_CodApl = UcMenuBusq.pInfo_MMCAPL_CodApl
      obeOpcion.PSMMCMNU_CodMnu = UcMenuBusq.pInfo_MMCMNU_CodMenu
      obeOpcion.PNMMCOPC_CodOpc_Ini = 0
      obeOpcion.PNMMCOPC_CodOpc_Fin = 99
      obeOpcion.PSMMDOPC_DesOpc = ""
      UcOpcionBusq.pActualizarDatos(obeOpcion)
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

  Private Sub UcMenuBusq_pMostrarOpcion() Handles UcMenuBusq.pMostrarOpcion
    Try
      Dim oFrmOpcion As New FrmOpcion
      oFrmOpcion.pMMCAPL_CodApl = UcMenuBusq.pInfo_MMCAPL_CodApl
      oFrmOpcion.pMMCMNU_CodMnu = UcMenuBusq.pInfo_MMCMNU_CodMenu
      oFrmOpcion.MdiParent = Me.ParentForm
      oFrmOpcion.Show()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

  Private Sub Uc_CboAplicacion_InformationChanged() Handles Uc_CboAplicacion1.InformationChanged
    Try
      UcMenuBusq.pInfo_MMCAPL_CodApl = Uc_CboAplicacion1.pPSMMCAPL
      UcMenuBusq_pBuscar()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub
End Class
