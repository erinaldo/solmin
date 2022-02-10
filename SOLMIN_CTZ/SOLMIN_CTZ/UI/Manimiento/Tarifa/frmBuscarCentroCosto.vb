Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Web
Imports IBM.Data.DB2
Imports Ransa.Utilitario
Imports SOLMIN_CTZ.Entidades.mantenimientos
Imports System.Xml
Imports System.Text
 

Public Class frmBuscarCentroCosto

#Region "Variables"
    Private bs As New BindingSource
    Private mDataSource As Object
    Private FiltroData As Object
    Private mFila As DataGridViewRow

    Private DESCRIPCCECO As String = "DESC_CECO"
    Private CODIGOCECO As String = "COD_CECO"
    Private CODIGOCECOSAP As String = "CODSAP_CECO"
    Private unidProd As New DataTable 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
    Public iniMacroServicio As String = String.Empty 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
    Public iniUnidadProductiva As String = String.Empty 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
    Public iniTipoActivo As String = String.Empty 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
    Public iniSector As String = String.Empty 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
#End Region

#Region "Popiedades"

    Private _Lista As List(Of CentroCostoTarifa)
    Public Property Lista() As List(Of CentroCostoTarifa)
        Get
            Return _Lista
        End Get
        Set(ByVal value As List(Of CentroCostoTarifa))
            _Lista = value
        End Set
    End Property


    Private _codCeCo As String
    Public Property codCeCo() As String
        Get
            Return _codCeCo
        End Get
        Set(ByVal value As String)
            _codCeCo = value
        End Set
    End Property


    Private _DescCeCo As String
    Public Property DescCeCo() As String
        Get
            Return _DescCeCo
        End Get
        Set(ByVal value As String)
            _DescCeCo = value
        End Set
    End Property

    Private _codCeBe As String
    Public Property codCeBe() As String
        Get
            Return _codCeBe
        End Get
        Set(ByVal value As String)
            _codCeBe = value
        End Set
    End Property


    Private _DescCeBe As String
    Public Property DescCeBe() As String
        Get
            Return _DescCeBe
        End Get
        Set(ByVal value As String)
            _DescCeBe = value
        End Set
    End Property
 
    Private _ccmpn As String
    Public Property CCMPN() As String
        Get
            Return _ccmpn
        End Get
        Set(ByVal value As String)
            _ccmpn = value
        End Set
    End Property
#End Region

#Region "Delegados"

    Private Sub frmBuscarCentroCosto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CargarCombos()
            CargarGrilla()
            txtCodigo.Focus()

            If iniMacroServicio <> String.Empty Then
                cboMacro.SelectedValue = iniMacroServicio
            End If

            If iniUnidadProductiva <> String.Empty Then
                cboUnid.SelectedValue = iniUnidadProductiva
            End If

            If iniTipoActivo <> String.Empty Then
                cboTipo.SelectedValue = iniTipoActivo
            End If

            If iniSector <> String.Empty Then
                cboSector.SelectedValue = iniSector
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
      
    End Sub

    Private Sub dgvCentroCostos_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCentroCostos.CellDoubleClick
        Try
            enviarDatos()
            DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' DialogResult = Windows.Forms.DialogResult.Cancel
        End Try
    End Sub

    'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
    'Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged
    '    Filtrar_criterio1(txtCodigo, CODIGOCECO)
    'End Sub

    'Private Sub txtCodCeCoSAP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodCeCoSAP.TextChanged
    '    Filtrar_criterio1(txtCodCeCoSAP, CODIGOCECOSAP)
    'End Sub

    'Private Sub txtDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.TextChanged
    '    Filtrar_criterio1(txtDescripcion, DESCRIPCCECO)
    'End Sub
    'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN

#End Region

#Region "Metodos"
   
    Private Sub CargarGrilla()
        'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
        'dgvCentroCostos.AutoGenerateColumns = False
        'If Lista.Count > 0 Then
        '    mDataSource = Lista
        '    bs.DataSource = mDataSource
        '    dgvCentroCostos.DataSource = bs
        '    dgvCentroCostos.Refresh()
        'Else
        '    dgvCentroCostos.DataSource = Nothing
        'End If

        'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN
    End Sub

    Private Sub enviarDatos()
        If dgvCentroCostos.RowCount > 0 Then
            codCeCo = dgvCentroCostos.CurrentRow.Cells("COD_CECO").Value.ToString().Trim
            DescCeCo = dgvCentroCostos.CurrentRow.Cells("CECO").Value.ToString().Trim
            codCeBe = dgvCentroCostos.CurrentRow.Cells("COD_CEBE").Value.ToString().Trim
            DescCeBe = dgvCentroCostos.CurrentRow.Cells("CEBE").Value.ToString().Trim
        End If
    End Sub

    'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
    'Private Sub Filtrar_criterio1(ByVal Control As ComponentFactory.Krypton.Toolkit.KryptonTextBox, ByVal Valor As String)
    '    If Control.Text <> "" Then
    '        If mDataSource Is Nothing Then Exit Sub
    '        Dim pre As Type = GetType(Predicado(Of ))
    '        Dim tipo As Type = mDataSource(0).GetType
    '        Dim tipos() As Type = {tipo}
    '        Dim obj As Type = pre.MakeGenericType(tipos)
    '        Dim oPred As Object = Activator.CreateInstance(obj, Valor, "*" & Control.Text.Trim.ToUpper & "*")
    '        If True Then
    '            'Filtrar
    '            FiltroData = mDataSource.FindAll(oPred.Predicado)
    '            bs.DataSource = FiltroData
    '            dgvCentroCostos.Refresh()
    '        Else
    '            'Buscar
    '            Dim pos As Integer = mDataSource.FindIndex(oPred.Predicado)
    '            If pos > -1 Then bs.Position = pos
    '        End If
    '    Else
    '        CargarGrilla()
    '    End If
    'End Sub
    'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN

    Private Sub CargarCombos() 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
        Dim dataRow As DataRow
        Dim output As New DataSet
        Dim negocio As New clsClaseGeneral
        output = negocio.Listar_Datos_Estructura_Cebe()

        If output.Tables.Count > 0 Then

            'Adicion de campos "Todos"
            dataRow = output.Tables("Table").NewRow()
            dataRow("CDSRSP") = -1
            dataRow("TDSRSP") = "Todos"
            output.Tables("Table").Rows.InsertAt(dataRow, 0)

            dataRow = output.Tables("Table1").NewRow()
            dataRow("CDSPSP") = -1
            dataRow("TDSPSP") = "Todos"
            output.Tables("Table1").Rows.InsertAt(dataRow, 0)

            dataRow = output.Tables("Table2").NewRow()
            dataRow("CDUPSP") = -1
            dataRow("TDUPSP") = "Todos"
            output.Tables("Table2").Rows.InsertAt(dataRow, 0)

            dataRow = output.Tables("Table3").NewRow()
            dataRow("CDSCSP") = -1
            dataRow("TDSCSP") = "Todos"
            output.Tables("Table3").Rows.InsertAt(dataRow, 0)

            dataRow = output.Tables("Table4").NewRow()
            dataRow("COD_TIPO") = -1
            dataRow("DESC_TIPO") = "Todos"
            output.Tables("Table4").Rows.InsertAt(dataRow, 0)

            'Lectura de los combos
            cboMacro.DataSource = output.Tables("Table")
            cboMacro.ValueMember = "CDSRSP"
            cboMacro.DisplayMember = "TDSRSP"

            cboSede.DataSource = output.Tables("Table1")
            cboSede.ValueMember = "CDSPSP"
            cboSede.DisplayMember = "TDSPSP"

            unidProd = output.Tables("Table2").Copy
            cboUnid.DataSource = output.Tables("Table2")
            cboUnid.ValueMember = "CDUPSP"
            cboUnid.DisplayMember = "TDUPSP"

            cboSector.DataSource = output.Tables("Table3")
            cboSector.ValueMember = "CDSCSP"
            cboSector.DisplayMember = "TDSCSP"

            cboTipo.DataSource = output.Tables("Table4")
            cboTipo.ValueMember = "COD_TIPO"
            cboTipo.DisplayMember = "DESC_TIPO"

            cboMacro.SelectedValue = -1
            cboSede.SelectedValue = -1
            cboUnid.SelectedValue = -1
            cboSector.SelectedValue = -1
            cboTipo.SelectedValue = -1
        Else
            cboMacro.DataSource = Nothing
            cboSede.DataSource = Nothing
            cboUnid.DataSource = Nothing
            cboSector.DataSource = Nothing
            cboTipo.DataSource = Nothing
        End If
    End Sub
#End Region
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Dim negocio As New clsClaseGeneral
            Dim oCentroCosto As New CentroCosto

            With oCentroCosto
                .PSCCMPN = CCMPN
                .PNCCNTCS = Val(Trim(txtCodigo.Text.Trim))
                .PSCCNCOS = Trim(txtCodCeCoSAP.Text.Trim)
                .PSCDSRSP = Trim(cboMacro.SelectedValue)
                .PSCDSPSP = Trim(cboSede.SelectedValue)
                .PSCDUPSP = Trim(cboUnid.SelectedValue)
                .PSCDSCSP = Trim(cboSector.SelectedValue)
                .PSTCNTCS = Trim(txtDescripcion.Text.Trim)
                .PSCDTASP = Trim(cboTipo.SelectedValue)
            End With
            dgvCentroCostos.AutoGenerateColumns = False
            dgvCentroCostos.DataSource = negocio.Buscar_CeCo(oCentroCosto)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub cboMacro_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMacro.SelectedValueChanged
        Try
            If unidProd.Rows.Count > 0 Then
                Dim dtTemp As DataTable = unidProd.Copy
                Dim dataView As DataView = dtTemp.DefaultView
                cboUnid.Text = String.Empty
                If cboMacro.SelectedValue <> "-1" Then
                    dataView.RowFilter = String.Format("CDSRSP = '{0}'", Trim(cboMacro.SelectedValue))
                End If
                dataView.Sort = "CDSRSP ASC"
                cboUnid.DataSource = dataView
                cboUnid.ValueMember = "CDUPSP"
                cboUnid.DisplayMember = "TDUPSP"
                cboUnid.Refresh()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub
End Class
