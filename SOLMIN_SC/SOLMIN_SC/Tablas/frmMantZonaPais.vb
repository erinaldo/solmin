Imports SOLMIN_SC.Negocio
Imports SOLMIN_SC.Entidad
Imports Ransa.Utilitario

Public Class frmMantZonaPais

  Enum Accion
    Modificar
    Nuevo
  End Enum

  Private _pInfoZonaEmbarque As New ZonaEmbarque_BE
  Private _pInfoAccion As Accion = Accion.Nuevo

  Public Property pInfoZonaEmbarque() As ZonaEmbarque_BE
    Get
      Return _pInfoZonaEmbarque
    End Get
    Set(ByVal value As ZonaEmbarque_BE)
      _pInfoZonaEmbarque = value
    End Set
  End Property

  Public Property pInfoAccion() As Accion
    Get
      Return _pInfoAccion
    End Get
    Set(ByVal value As Accion)
      _pInfoAccion = value
    End Set
  End Property


  Private Sub frmMantZonaPais_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Me.cmbCliente.pAccesoPorUsuario = True
    Me.cmbCliente.pRequerido = True
    Me.cmbCliente.pUsuario = HelpUtil.UserName

    dtgZona.AutoGenerateColumns = False
    dgvPaisZona.AutoGenerateColumns = False
  End Sub

  Private Function ObtenerPais_X_ZonaEmbarque() As ZonaEmbarque_BE

    Dim obeZonaPaisEmbarque As New ZonaEmbarque_BE
    If (dgvPaisZona.Rows.Count > 0) Then
      Dim obeZonaPaisEmbarqueFind As New ZonaEmbarque_BE
      obeZonaPaisEmbarqueFind = dgvPaisZona.CurrentRow.DataBoundItem
      obeZonaPaisEmbarque.PNCCLNT = obeZonaPaisEmbarqueFind.PNCCLNT
      obeZonaPaisEmbarque.PSCZNAEM = obeZonaPaisEmbarqueFind.PSCZNAEM.Trim
      obeZonaPaisEmbarque.PSTZNAEM = obeZonaPaisEmbarqueFind.PSTZNAEM.Trim
      obeZonaPaisEmbarque.PNCPAIS = obeZonaPaisEmbarqueFind.PNCPAIS
      obeZonaPaisEmbarque.PSTCMPPS = obeZonaPaisEmbarqueFind.PSTCMPPS
      obeZonaPaisEmbarque.PSCPRTOE = obeZonaPaisEmbarqueFind.PSCPRTOE
      obeZonaPaisEmbarque.PSTCMPR1 = obeZonaPaisEmbarqueFind.PSTCMPR1
    Else
      Dim obeZonaEmbarqueFind As New ZonaEmbarque_BE
      obeZonaEmbarqueFind = dtgZona.CurrentRow.DataBoundItem
      obeZonaPaisEmbarque.PNCCLNT = obeZonaEmbarqueFind.PNCCLNT
      obeZonaPaisEmbarque.PSCZNAEM = obeZonaEmbarqueFind.PSCZNAEM.Trim
      obeZonaPaisEmbarque.PSTZNAEM = obeZonaEmbarqueFind.PSTZNAEM.Trim
    End If
    Return obeZonaPaisEmbarque

  End Function

  Private Function ObtenerZonaEmbarque() As ZonaEmbarque_BE
    Dim obeZonaEmbarque As New ZonaEmbarque_BE
    If (dtgZona.Rows.Count > 0) Then
      Dim obeZonaEmbarqueFind As New ZonaEmbarque_BE
      obeZonaEmbarqueFind = dtgZona.CurrentRow.DataBoundItem
      obeZonaEmbarque.PNCCLNT = obeZonaEmbarqueFind.PNCCLNT
      obeZonaEmbarque.PSCZNAEM = obeZonaEmbarqueFind.PSCZNAEM.Trim
      obeZonaEmbarque.PSTZNAEM = obeZonaEmbarqueFind.PSTZNAEM.Trim
    Else
      obeZonaEmbarque.PNCCLNT = cmbCliente.pCodigo
    End If
    Return obeZonaEmbarque
  End Function

  Private Sub Listar_Zonas()
    Dim obrZonaEmbarque As New clsZonasEmbarque
    Dim oListZonasEmbarque As New List(Of ZonaEmbarque_BE)
    oListZonasEmbarque = obrZonaEmbarque.Lista_Zonas_Embarque(cmbCliente.pCodigo, txtZona.Text.Trim)
    dtgZona.DataSource = Nothing
    dtgZona.DataSource = oListZonasEmbarque
    ListarZonaPaisEmbarque()
  End Sub

  Private Sub ListarZonaPaisEmbarque()
    dgvPaisZona.DataSource = Nothing
    If (dtgZona.CurrentRow IsNot Nothing) Then
      Dim obeZonaEmbarque As New ZonaEmbarque_BE
      Dim obrZonaPaisEmbarque As New clsZonasEmbarque
      Dim oListZonaPaisEmbarque As New List(Of ZonaEmbarque_BE)
      obeZonaEmbarque = dtgZona.CurrentRow.DataBoundItem
      Dim PNCCLNT As Decimal = obeZonaEmbarque.PNCCLNT
      Dim PSCZNAEM As String = obeZonaEmbarque.PSCZNAEM
      oListZonaPaisEmbarque = obrZonaPaisEmbarque.Lista_Paises_Zonas_Embarque(PNCCLNT, PSCZNAEM)
      dgvPaisZona.DataSource = oListZonaPaisEmbarque
    End If

  End Sub


  Private Sub txtZona_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    If (e.KeyChar = ControlChars.Cr) Then
      btnBuscar_Z_Click(btnBuscar_Z, Nothing)
    End If
  End Sub

  Private Sub dtgZona_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgZona.CellClick
    If e.RowIndex >= 0 Then
      Try
        ListarZonaPaisEmbarque()
      Catch ex As Exception
        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
    End If
  End Sub

  Private Sub dtgZona_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgZona.KeyUp
    If dtgZona.CurrentCellAddress.Y < 0 Then
      Exit Sub
    End If
    If (e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down) Then
      Try
        ListarZonaPaisEmbarque()
      Catch ex As Exception
        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
    End If
  End Sub

  Private Sub btnBuscar_Z_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar_Z.Click
    If (cmbCliente.pCodigo = 0) Then
      MessageBox.Show("Debe de seleccionar el Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Exit Sub
    End If
    Try
      Listar_Zonas()

    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub btnEliminar_Z_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar_Z.Click
    If (cmbCliente.pCodigo = 0) Then
      MessageBox.Show("Debe de seleccionar el Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Exit Sub
    End If
    Try
      Dim obeZonaEmbarque As New ZonaEmbarque_BE
      Dim obrZonaEmbarque As New clsZonasEmbarque
      Dim retorno As Int32 = 0
      If (dtgZona.Rows.Count = 0) Then
        Exit Sub
      End If
      If (dgvPaisZona.Rows.Count > 0) Then
        MessageBox.Show("Antes de eliminar la zona debe de eliminar sus Países relacionados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Exit Sub
      End If
      obeZonaEmbarque = ObtenerZonaEmbarque()
      If (MessageBox.Show("Está seguro de eliminar la zona:" & obeZonaEmbarque.PSTZNAEM, "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then
        retorno = obrZonaEmbarque.Elimina_Zonas_Embarque(obeZonaEmbarque)
        If (retorno = 1) Then
          Listar_Zonas()
        Else
          MessageBox.Show("No se pudo eliminar la zona", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub btnModificar_Z_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar_Z.Click
    If (cmbCliente.pCodigo = 0) Then
      MessageBox.Show("Debe de seleccionar el Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Exit Sub
    End If
    If (dtgZona.Rows.Count = 0) Then
      Exit Sub
    End If
    Try
      If (dtgZona.Rows.Count > 0) Then
        Dim ofrmManZona As New frmManZona
        ofrmManZona.pInfoAccion = frmManZona.Accion.Modificar
        ofrmManZona.pInfoZonaEmbarque = ObtenerZonaEmbarque()
        If (ofrmManZona.ShowDialog = Windows.Forms.DialogResult.OK) Then
          Listar_Zonas()
        End If
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub btnNuevo_Z_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo_Z.Click
    If (cmbCliente.pCodigo = 0) Then
      MessageBox.Show("Debe de seleccionar el Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Exit Sub
    End If
    Try
      Dim ofrmManZona As New frmManZona
      Dim obeZonaEmbarque As New ZonaEmbarque_BE
      ofrmManZona.pInfoAccion = frmManZona.Accion.Nuevo
      obeZonaEmbarque = ObtenerZonaEmbarque()
      ofrmManZona.pInfoZonaEmbarque = obeZonaEmbarque
      If (ofrmManZona.ShowDialog = Windows.Forms.DialogResult.OK) Then
        Listar_Zonas()
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
    If (cmbCliente.pCodigo = 0) Then
      MessageBox.Show("Debe de seleccionar el Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Exit Sub
    End If
    If (dgvPaisZona.Rows.Count = 0) Then
      Exit Sub
    End If
    Try
      Dim obeZonaEmbarque As New ZonaEmbarque_BE
      Dim obrZonaEmbarque As New clsZonasEmbarque
      Dim retorno As Int32 = 0
      obeZonaEmbarque = ObtenerPais_X_ZonaEmbarque()
      If (MessageBox.Show("Está seguro de eliminar la relación " & Chr(13) & "País :" & obeZonaEmbarque.PSTCMPPS & " Puerto:" & obeZonaEmbarque.PSTCMPR1, "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then
        retorno = obrZonaEmbarque.Elimina_Zonas_Pais_Embarque(obeZonaEmbarque)
        If (retorno = 1) Then
          ListarZonaPaisEmbarque()
        Else
          MessageBox.Show("No se pudo eliminar la relación.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
    If (cmbCliente.pCodigo = 0) Then
      MessageBox.Show("Debe de seleccionar el Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Exit Sub
    End If
    If (dtgZona.Rows.Count <= 0) Then
      MessageBox.Show("Debe de seleccionar una Zona", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
      Exit Sub
    End If
    Try
      Dim ofrmManPaisxZona As New frmManPaisxZona
      ofrmManPaisxZona.pInfoAccion = frmManZona.Accion.Nuevo
      ofrmManPaisxZona.pInfoZonaEmbarque = ObtenerPais_X_ZonaEmbarque()
      If (ofrmManPaisxZona.ShowDialog = Windows.Forms.DialogResult.OK) Then
        ListarZonaPaisEmbarque()
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub Exportar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    Try

            Dim NPOI_SC As New HelpClass_NPOI_SC
      Dim dtExport As New DataTable
      Dim ColName As String = ""
      Dim MdataColumna As String = ""

      Dim TableName As String = ""
      Dim ColTitle As String = ""
      Dim TipoDato As String = ""

      If dtgZona.Rows.Count > 0 Then
        For Each Item As DataGridViewColumn In dtgZona.Columns
          ColTitle = Item.HeaderText.Trim
          ColName = Item.Name
          TipoDato = ""
          If Item.Visible = True Then
                        TipoDato = NPOI_SC.keyDatoTexto
            dtExport.Columns.Add(ColName)
                        MdataColumna = NPOI_SC.FormatDato(ColTitle, TipoDato)
            dtExport.Columns(ColName).Caption = MdataColumna
          End If
        Next

        Dim dr As DataRow
        For Fila As Integer = 0 To dtgZona.Rows.Count - 1
          dr = dtExport.NewRow
          For Columna As Integer = 0 To dtExport.Columns.Count - 1
            ColName = dtExport.Columns(Columna).ColumnName
            If (dtgZona.Rows(Fila).Cells(ColName).Value IsNot Nothing) Then
              dr(ColName) = dtgZona.Rows(Fila).Cells(ColName).Value
            End If
          Next
          dtExport.Rows.Add(dr)
        Next
                'Dim oLisParametros As New SortedList
                'oLisParametros(0) = "Fecha:|" & Now.ToString("dd/MM/yyyy")
                '        oLisParametros(1) = "Hora:|" & Now.ToString("hh:mm:ss")

                Dim ListaDatatable As New List(Of DataTable)
                ListaDatatable.Add(dtExport.Copy)

                Dim ListTitulo As New List(Of String)
                ListTitulo.Add("LISTADO DE PAISES POR ZONA")

                Dim LisFiltros As New List(Of SortedList)
                Dim itemSortedList As SortedList
                itemSortedList = New SortedList
                itemSortedList.Add(itemSortedList.Count, "Fecha:|" & Now.ToString("dd/MM/yyyy"))
                itemSortedList.Add(itemSortedList.Count, "Hora:|" & Now.ToString("hh:mm:ss"))
                LisFiltros.Add(itemSortedList)

                NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListTitulo, Nothing, LisFiltros, 0, Nothing)
                'HelpClass_NPOI_SC.ExportExcelGeneralRelease(dtExport, Titulo, Nothing, oLisParametros)
      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

End Class
