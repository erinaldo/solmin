Imports System.Windows.Forms
Imports System.Text
Imports Ransa.Utilitario
Public Class ucOpcionMain
   
    Private _pMMCAPL_CodApl As String = ""
  Private _pMMCMNU_CodMnu As String = ""

  Private isCheckUsuario As Boolean = False

    Public Sub pCargar(ByVal CodApl As String, ByVal CodMenu As String)
        Try
            _pMMCAPL_CodApl = CodApl
            _pMMCMNU_CodMnu = CodMenu

            If _pMMCAPL_CodApl <> "" AndAlso _pMMCMNU_CodMnu <> "" Then
                Uc_CboAplicacion.pObtenerAplicacion(_pMMCAPL_CodApl)
                Uc_CboAplicacion.Enabled = False
                Uc_CboMenu.Enabled = False
                Uc_CboMenu.pObtenerMenu(_pMMCAPL_CodApl, _pMMCMNU_CodMnu)
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

    Private Sub Cambio_Aplicacion() Handles Uc_CboAplicacion.InformationChanged
        Try
            UcOpcionBusq.pActualizarDatosNothing()
            dgvUsuario.DataSource = Nothing
            Uc_CboMenu.pPSMMCAPL = Uc_CboAplicacion.pPSMMCAPL
            UcOpcionBusq.pInfo_MMCMNU_CodMenu = ""
            Uc_CboMenu.pClear()
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

                UcOpcionBusq.pInfo_MMCAPL_CodApl = Uc_CboAplicacion.pPSMMCAPL
                UcOpcionBusq.pInfo_MMCMNU_CodMenu = Uc_CboMenu.pPSMMCMNU

                obeOpcion.PSMMCAPL_CodApl = Uc_CboAplicacion.pPSMMCAPL
                obeOpcion.PSMMCMNU_CodMnu = Uc_CboMenu.pPSMMCMNU
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
        If Uc_CboAplicacion.pPSMMCAPL = "" Then
            sbMensaje.AppendLine("* Aplicación")
        End If
        If Uc_CboMenu.pPSMMCMNU = "" Then
            sbMensaje.AppendLine("* Menú")
        End If
        Return sbMensaje.ToString
    End Function

    Private Sub Cambio_Menu() Handles Uc_CboMenu.InformationChanged
        Try
            If Uc_CboMenu.pPSMMCAPL <> "" AndAlso Uc_CboMenu.pPSMMCMNU <> "" AndAlso Uc_CboMenu.pPSMMTMNU <> "" Then
                UcOpcionBusq_pBuscar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

  Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
    Try
      Dim ofrmManUserOption As New frmManUserOption
      If UcOpcionBusq.pInfo_MMCOPC_CodOpc <> 0 Then
        ofrmManUserOption.pEstado = frmManUserOption.Estado.Nuevo

        ofrmManUserOption.pbeAccesoOpcion.DES_APLC = UcOpcionBusq.pInfo_MMDAPL
        ofrmManUserOption.pbeAccesoOpcion.DES_MENU = UcOpcionBusq.pInfo_MMTMNU
        ofrmManUserOption.pbeAccesoOpcion.DES_OPCN = UcOpcionBusq.pInfo_MMDOPC

        ofrmManUserOption.pbeAccesoOpcion.PSMMCAPL = UcOpcionBusq.pInfo_MMCAPL_CodApl
        ofrmManUserOption.pbeAccesoOpcion.PSMMCMNU = UcOpcionBusq.pInfo_MMCMNU_CodMenu
        ofrmManUserOption.pbeAccesoOpcion.PNMMCOPC = UcOpcionBusq.pInfo_MMCOPC_CodOpc
        If ofrmManUserOption.ShowDialog = DialogResult.OK Then
          UcOpcionBusq_pBuscar()
        End If
      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
    Try
      Dim ofrmManUserOption As New frmManUserOption

      If dgvUsuario.CurrentRow IsNot Nothing Then
        ofrmManUserOption.pEstado = frmManUserOption.Estado.Modificar

        ofrmManUserOption.pbeAccesoOpcion.DES_APLC = ("" & dgvUsuario.CurrentRow.Cells("DES_APLC").Value).ToString.Trim
        ofrmManUserOption.pbeAccesoOpcion.DES_MENU = ("" & dgvUsuario.CurrentRow.Cells("DES_MENU").Value).ToString.Trim
        ofrmManUserOption.pbeAccesoOpcion.DES_OPCN = ("" & dgvUsuario.CurrentRow.Cells("DES_OPCN").Value).ToString.Trim

        ofrmManUserOption.pbeAccesoOpcion.PSMMCAPL = ("" & dgvUsuario.CurrentRow.Cells("MMCAPL").Value).ToString.Trim
        ofrmManUserOption.pbeAccesoOpcion.PSMMCMNU = ("" & dgvUsuario.CurrentRow.Cells("MMCMNU").Value).ToString.Trim
        ofrmManUserOption.pbeAccesoOpcion.PNMMCOPC = dgvUsuario.CurrentRow.Cells("MMCOPC").Value
        ofrmManUserOption.pbeAccesoOpcion.PSMMCUSR = ("" & dgvUsuario.CurrentRow.Cells("MMCUSR").Value).ToString.Trim

        ofrmManUserOption.pbeAccesoOpcion.PSSTSVIS = Me.dgvUsuario.CurrentRow.Cells("STSVIS").Value
        ofrmManUserOption.pbeAccesoOpcion.PSSTSADI = Me.dgvUsuario.CurrentRow.Cells("STSADI").Value
        ofrmManUserOption.pbeAccesoOpcion.PSSTSCHG = Me.dgvUsuario.CurrentRow.Cells("STSCHG").Value
        ofrmManUserOption.pbeAccesoOpcion.PSSTSELI = Me.dgvUsuario.CurrentRow.Cells("STSELI").Value

        ofrmManUserOption.pbeAccesoOpcion.PSSTSOP1 = Me.dgvUsuario.CurrentRow.Cells("STSOP1").Value
        ofrmManUserOption.pbeAccesoOpcion.PSSTSOP2 = Me.dgvUsuario.CurrentRow.Cells("STSOP2").Value
        ofrmManUserOption.pbeAccesoOpcion.PSSTSOP3 = Me.dgvUsuario.CurrentRow.Cells("STSOP3").Value

        If ofrmManUserOption.ShowDialog = DialogResult.OK Then
          UcOpcionBusq_pBuscar()
        End If
      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

    Try
      dgvUsuario.EndEdit()
      If HaySeleccionUsuario() = True Then
        If dgvUsuario.CurrentRow IsNot Nothing And dgvUsuario.Rows.Count > 0 Then
          If MessageBox.Show("Está seguro de eliminar " & Chr(13) & " todos los registros seleccionados ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim obeAccesoOpcion As beAccesoOpcion
            Dim oclsUsuario_DAL As New clsUsuario_DAL
            Dim Fila As Int32 = 0
            Dim retorno As Int32 = 0
            For Fila = 0 To dgvUsuario.RowCount - 1
              If dgvUsuario.Rows(Fila).Cells("CHK_USUARIO").Value = True Then
                obeAccesoOpcion = New beAccesoOpcion
                obeAccesoOpcion.PSMMCAPL = ("" & dgvUsuario.Item("MMCAPL", Fila).Value).ToString.Trim
                obeAccesoOpcion.PSMMCMNU = ("" & dgvUsuario.Item("MMCMNU", Fila).Value).ToString.Trim
                obeAccesoOpcion.PNMMCOPC = dgvUsuario.Item("MMCOPC", Fila).Value
                obeAccesoOpcion.PSMMCUSR = ("" & dgvUsuario.Item("MMCUSR", Fila).Value).ToString.Trim
                retorno = oclsUsuario_DAL.Eliminar_Opciones_X_Usuario(obeAccesoOpcion)
              End If
            Next
            UcOpcionBusq_pBuscar()
          End If
        End If
      Else
        MessageBox.Show("Debe seleccionar al menos un registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

  Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
    dgvUsuario.EndEdit()
    isCheckUsuario = Not isCheckUsuario
    If isCheckUsuario = True Then
      btnCheck.Image = My.Resources.btnMarcarItems
    Else
      btnCheck.Image = My.Resources.btnNoMarcarItems
    End If
    Poner_Check_Todo_Usuario(isCheckUsuario)
  End Sub

  Private Sub Poner_Check_Todo_Usuario(ByVal blnEstado As Boolean)
    Dim intCont As Integer
    For intCont = 0 To dgvUsuario.RowCount - 1
      dgvUsuario.Rows(intCont).Cells("CHK_USUARIO").Value = blnEstado
    Next
  End Sub

  Private Function HaySeleccionUsuario() As Boolean
    dgvUsuario.EndEdit()
    Dim intCont As Integer
    Dim HaySeleccionadosUsuario As Boolean = False
    For intCont = 0 To dgvUsuario.RowCount - 1
      If dgvUsuario.Rows(intCont).Cells("CHK_USUARIO").Value = True Then
        HaySeleccionadosUsuario = True
        Exit For
      End If
    Next
    Return HaySeleccionadosUsuario
  End Function

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click

        Try
            Dim NPOI_SC As New HelpClass_NPOI_SC
            Dim ColName As String = ""
            Dim MdataColumna As String = ""

            Dim TableName As String = ""
            Dim ColTitle As String = ""
            Dim TipoDato As String = ""

            Dim dtUsuarioxOpcion As New DataTable

            TipoDato = NPOI_SC.keyDatoNumero
            MdataColumna = NPOI_SC.FormatDato("N°", TipoDato)
            dtUsuarioxOpcion.Columns.Add("ITEM").Caption = MdataColumna

            TipoDato = NPOI_SC.keyDatoTexto
            MdataColumna = NPOI_SC.FormatDato("Usuario", TipoDato)
            dtUsuarioxOpcion.Columns.Add("MMCUSR").Caption = MdataColumna

            TipoDato = NPOI_SC.keyDatoTexto
            MdataColumna = NPOI_SC.FormatDato("Nombre", TipoDato)
            dtUsuarioxOpcion.Columns.Add("MMNUSR").Caption = MdataColumna

         
            Dim dr As DataRow
            For Fila As Integer = 0 To dgvUsuario.Rows.Count - 1
                dr = dtUsuarioxOpcion.NewRow
                dr("MMCUSR") = dgvUsuario.Rows(Fila).Cells("MMCUSR").Value
                dr("MMNUSR") = dgvUsuario.Rows(Fila).Cells("MMNUSR").Value
                dr("ITEM") = Fila + 1
                dtUsuarioxOpcion.Rows.Add(dr)
            Next
            'Dim oLisParametros As New SortedList
            'oLisParametros(0) = "Aplicacion:|" & UcOpcionBusq.pInfo_MMDAPL
            'oLisParametros(1) = "Menú:|" & UcOpcionBusq.pInfo_MMTMNU
            'oLisParametros(2) = "Opción:|" & UcOpcionBusq.pInfo_MMDOPC
            'oLisParametros(3) = "Fecha:|" & Now.ToString("dd/MM/yyyy")
            'oLisParametros(4) = "Hora:|" & Now.ToString("hh:mm:ss")
            'HelpClass_NPOI_SC.ExportExcelGeneralRelease(dtUsuarioxOpcion, "LISTADO USUARIOS POR OPCION", Nothing, oLisParametros)


            Dim ListaDatatable As New List(Of DataTable)
            ListaDatatable.Add(dtUsuarioxOpcion.Copy)

            Dim LisFiltros As New List(Of SortedList)
            Dim itemSortedList As SortedList

            itemSortedList = New SortedList
            itemSortedList.Add(itemSortedList.Count, "Aplicacion:|" & UcOpcionBusq.pInfo_MMDAPL)
            itemSortedList.Add(itemSortedList.Count, "Menú:|" & UcOpcionBusq.pInfo_MMTMNU)
            itemSortedList.Add(itemSortedList.Count, "Opción:|" & UcOpcionBusq.pInfo_MMDOPC)
            itemSortedList.Add(itemSortedList.Count, "Fecha:|" & Now.ToString("dd/MM/yyyy"))
            itemSortedList.Add(itemSortedList.Count, "Hora:|" & Now.ToString("hh:mm:ss"))
            LisFiltros.Add(itemSortedList)

            Dim ListTitulo As New List(Of String)
            ListTitulo.Add("LISTADO USUARIOS POR OPCION")
            NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListTitulo, Nothing, LisFiltros, 0, Nothing)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub

End Class
