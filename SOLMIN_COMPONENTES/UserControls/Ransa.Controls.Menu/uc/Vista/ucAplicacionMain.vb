Imports System.Windows.Forms
Public Class ucAplicacionMain

    Private _Apli_Inicial As String
    Public Property Apli_Inicial() As String
        Get
            Return _Apli_Inicial
        End Get
        Set(ByVal value As String)
            _Apli_Inicial = value
        End Set
    End Property

    Public Sub pCargar()
        Try
            If _Apli_Inicial.ToString.Trim.Length > 0 Then
                txtDescripcion.Text = _Apli_Inicial.ToString.Trim
            End If
            UcAplicacionBusq_pBuscarAplicacion()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown, txtDescripcion.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                UcAplicacionBusq_pBuscarAplicacion()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub UcAplicacionBusq_pBuscarAplicacion() Handles UcAplicacionBusq.pBuscarAplicacion
        Try
            Dim obeAplicacion As New beAplicacion
            obeAplicacion.PSMMCAPL_CodApl = txtCodigo.Text
            obeAplicacion.PSMMDAPL_DesApl = txtDescripcion.Text.ToUpper
            UcAplicacionBusq.pActualizarDatos(obeAplicacion)
            If UcAplicacionBusq.pnumReg = 0 Then
                UcMenuBusq.pActualizarDatosNothing()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub UcAplicacionBusq_pSelectionFilaAplicacionChanged() Handles UcAplicacionBusq.pSelectionFilaAplicacionChanged
        Try
            Dim obeMenu As New beMenu
            obeMenu.PSMMCAPL_CodApl = UcAplicacionBusq.pInfo_MMCAPL_CodApl
            UcMenuBusq.pActualizarDatos(obeMenu)
            UcMenuBusq.pVerBotonOpcion = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UcAplicacionBusq_EventChanged()
        Try
            UcAplicacionBusq_pBuscarAplicacion()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub UcMenuBusq_EventChanged() Handles UcAplicacionBusq.EventChanged
        Try
            Dim obeMenu As New beMenu
            obeMenu.PSMMCAPL_CodApl = UcAplicacionBusq.pInfo_MMCAPL_CodApl
            UcMenuBusq.pActualizarDatos(obeMenu)
            UcMenuBusq.pVerBotonOpcion = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub UcMenuBusq_pMostrarMenu() Handles UcAplicacionBusq.pMostrarMenu
        Try
            Dim oFrmMenuMain As New FrmMenuMain
            oFrmMenuMain.pMMCAPL_CodApl = UcAplicacionBusq.pInfo_MMCAPL_CodApl
            oFrmMenuMain.MdiParent = Me.ParentForm.ParentForm
            oFrmMenuMain.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub UcMenuBusq_pMostrarOpcion() Handles UcMenuBusq.pMostrarOpcion

        Try
            Dim oFrmOpcionMain As New FrmOpcionMain
            oFrmOpcionMain.pMMCAPL_CodApl = UcMenuBusq.pInfo_MMCAPL_CodApl.ToString.Trim
            oFrmOpcionMain.pMMCMNU_CodMnu = UcMenuBusq.pInfo_MMCMNU_CodMenu.ToString.Trim
            oFrmOpcionMain.MdiParent = Me.ParentForm.ParentForm
            oFrmOpcionMain.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class
