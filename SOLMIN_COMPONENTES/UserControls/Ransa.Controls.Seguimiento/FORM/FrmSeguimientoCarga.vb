Imports Ransa.Utilitario
Imports System.Text

Public Class FrmSeguimientoCarga

  Private _PNCCLNT As Decimal = 0
  Private _PSCCMPN As String = ""
  Private _PSNORCML As String = ""
  Private _PNNRITEM_INI As Decimal = 0
  Private _PNNRITEM_FIN As Decimal = 0
  Private _PSCDVSN As String = ""
  Private _PSCEMB As String = ""
  Private _PSSESTRG As String = ""
  Private _CASO As Decimal = 0

  Public Property CASO() As Decimal
    Get
      Return (_CASO)
    End Get
    Set(ByVal value As Decimal)
      _CASO = value
    End Set
  End Property

  Public Property PNCCLNT() As Decimal
    Get
      Return (_PNCCLNT)
    End Get
    Set(ByVal value As Decimal)
      _PNCCLNT = value
    End Set
  End Property

  Public Property PSCCMPN() As String
    Get
      Return (_PSCCMPN)
    End Get
    Set(ByVal value As String)
      _PSCCMPN = value
    End Set
  End Property

  Public Property PSNORCML() As String
    Get
      Return (_PSNORCML)
    End Get
    Set(ByVal value As String)
      _PSNORCML = value
    End Set
  End Property

  Public Property PNNRITEM_INI() As Decimal
    Get
      Return (_PNNRITEM_INI)
    End Get
    Set(ByVal value As Decimal)
      _PNNRITEM_INI = value
    End Set
  End Property

  Public Property PNNRITEM_FIN() As Decimal
    Get
      Return (_PNNRITEM_FIN)
    End Get
    Set(ByVal value As Decimal)
      _PNNRITEM_FIN = value
    End Set
  End Property

  Public Property PSCDVSN() As String
    Get
      Return (_PSCDVSN)
    End Get
    Set(ByVal value As String)
      _PSCDVSN = value
    End Set
  End Property

  Public Property PSCEMB() As String
    Get
      Return (_PSCEMB)
    End Get
    Set(ByVal value As String)
      _PSCEMB = value
    End Set
  End Property

  Public Property PSSESTRG() As String
    Get
      Return (_PSSESTRG)
    End Get
    Set(ByVal value As String)
      _PSSESTRG = value
    End Set
  End Property

  Private Sub FrmSeguimientoCarga_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try
      dtgSegAduaneroReducido.AutoGenerateColumns = False
      kgvItemOC.AutoGenerateColumns = False
      kgvItemOC.DataSource = Nothing
      dtgSegAduaneroReducido.DataSource = Nothing
      UcSeguimiento1.pLoad()
      Cargar_Informacion()
    Catch ex As Exception
      MessageBox.Show(ex, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Public Sub Cargar_Informacion()
    Dim objEmbarque As New beEmbarqueEntidad
    Dim objNegocio As New clsEmbarque
    If CASO = 1 Then  'muestra solo PreEmbarque
            If TabOpciones.TabPages("TabEmbarque").Created = True Then
                TabOpciones.Controls.Remove(TabOpciones.TabPages("TabEmbarque"))
            End If
      ListarItemPorOrdenCompraParcial()
    End If
    If CASO = 2 Then  'muestra solo Embarque
            If TabOpciones.TabPages("TabPreEmbarque").Created = True Then
                TabOpciones.Controls.Remove(TabOpciones.TabPages("TabPreEmbarque"))
            End If
      objEmbarque.PNCCLNT = _PNCCLNT
      objEmbarque.PSCCMPN = _PSCCMPN
      objEmbarque.PSNORCML = _PSNORCML
      objEmbarque.PNNRITEM_INI = _PNNRITEM_INI
      objEmbarque.PNNRITEM_FIN = _PNNRITEM_FIN
      dtgSegAduaneroReducido.DataSource = objNegocio.Lista_SeguimientoAduanero(objEmbarque)
    End If
    If CASO = 3 Then 'PreEmbarque y Embarque
      Dim TabActivo As Int32 = TabOpciones.SelectedIndex
      Dim TabName = TabOpciones.TabPages(TabActivo).Name
      If Not Tab_Cargado(TabActivo) Then
        Select Case TabName
          Case "TabPreEmbarque"
            ListarItemPorOrdenCompraParcial()
          Case "TabEmbarque"
            objEmbarque.PNCCLNT = _PNCCLNT
            objEmbarque.PSCCMPN = _PSCCMPN
            objEmbarque.PSNORCML = _PSNORCML
            objEmbarque.PNNRITEM_INI = _PNNRITEM_INI
            objEmbarque.PNNRITEM_FIN = _PNNRITEM_FIN
            dtgSegAduaneroReducido.DataSource = objNegocio.Lista_SeguimientoAduanero(objEmbarque)
        End Select
        Cargar_Tab(TabActivo)
      End If
    End If
  End Sub

  Private Sub dtgSegAduaneroReducido_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgSegAduaneroReducido.SelectionChanged
    Try
      Dim NORSCI As Decimal = 0
      Dim lint_indice As Integer = 0
      If (dtgSegAduaneroReducido.DataSource IsNot Nothing) Then
        If (dtgSegAduaneroReducido.CurrentRow IsNot Nothing) Then
          lint_indice = dtgSegAduaneroReducido.CurrentCellAddress.Y
          NORSCI = dtgSegAduaneroReducido.Item("NORSCI_R", lint_indice).Value
        End If
        UcSeguimiento1.pActualizarInfoEmbarque(_PSCCMPN, _PSCDVSN, _PNCCLNT, NORSCI)
      End If
    Catch ex As Exception
      MessageBox.Show(ex, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub ListarItemPorOrdenCompraParcial()

    kgvItemOC.DataSource = Nothing
    Dim objEmbarque As New beEmbarqueEntidad
    Dim objNegocio As New clsEmbarque
    Dim odtItems_x_OCParcial As New DataTable

    objEmbarque.PSCCMPN = _PSCCMPN
    objEmbarque.PNCCLNT = _PNCCLNT
    objEmbarque.PSNORCML = _PSNORCML
    objEmbarque.PNNRITEM_INI = _PNNRITEM_INI
    objEmbarque.PNNRITEM_FIN = _PNNRITEM_FIN
    objEmbarque.PSCDVSN = _PSCDVSN
    odtItems_x_OCParcial = objNegocio.ListarItemsXOrdenCompraParcial(objEmbarque)

    Dim NameColumna As String = ""
    Dim NameCaption As String = ""
    Dim Columna As String = ""
    Dim COLUMNAS_CHK As New List(Of String)

    For Each COLUMNAS As DataGridViewColumn In kgvItemOC.Columns
      NameColumna = COLUMNAS.Name
      If (NameColumna.EndsWith("_DFECEST") = True OrElse NameColumna.EndsWith("_DFECREA") = True) Then
        COLUMNAS_CHK.Add(NameColumna)
      End If
    Next
    For Each Item As String In COLUMNAS_CHK
      If (kgvItemOC.Columns(Item) IsNot Nothing) Then
        kgvItemOC.Columns.Remove(Item)
      End If
    Next
    For Each dc As DataColumn In odtItems_x_OCParcial.Columns
      NameColumna = dc.ColumnName
      NameCaption = dc.Caption
      If (NameColumna.EndsWith("_DFECEST") = True OrElse NameColumna.EndsWith("_DFECREA") = True) Then
        If (kgvItemOC.Columns(NameColumna) IsNot Nothing) Then
          kgvItemOC.Columns.Remove(NameColumna)
        End If
      End If
    Next
    Dim oDcTx As DataGridViewColumn
    Dim ColName() As String
    For Each dc As DataColumn In odtItems_x_OCParcial.Columns
      NameColumna = dc.ColumnName
      NameCaption = dc.Caption
      If (NameColumna.EndsWith("_DFECEST") = True OrElse NameColumna.EndsWith("_DFECREA") = True) Then
        ColName = NameCaption.Split("-")
        oDcTx = New DataGridViewColumn(New DataGridViewTextBoxCell)
        oDcTx.Name = NameColumna
        oDcTx.HeaderText = ColName(0) & "   " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       " & ColName(1)
        oDcTx.Resizable = DataGridViewTriState.True
        oDcTx.SortMode = DataGridViewColumnSortMode.NotSortable
        oDcTx.DataPropertyName = NameColumna
        oDcTx.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oDcTx.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        oDcTx.ReadOnly = True
        kgvItemOC.Columns.Add(oDcTx)
      End If
    Next
    kgvItemOC.DataSource = odtItems_x_OCParcial
  End Sub

  Private bolTab0 As Boolean
  Private bolTab1 As Boolean

  Public Sub Cargar_Tab(ByVal pintTab As Integer)
    Select Case pintTab
      Case 0
        bolTab0 = True
      Case 1
        bolTab1 = True
    End Select
  End Sub

  Public Function Tab_Cargado(ByVal pintTab As Integer) As Boolean
    Select Case pintTab
      Case 0
        Return bolTab0
      Case 1
        Return bolTab1
    End Select
  End Function

  Private Sub TabOpciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabOpciones.SelectedIndexChanged
    Try
      If CASO = 3 Then
        Cargar_Informacion()
      End If
    Catch ex As Exception
      MessageBox.Show(ex, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub
End Class
