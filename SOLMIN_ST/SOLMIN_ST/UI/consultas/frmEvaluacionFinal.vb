Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports Ransa.TypeDef.ServTransp
Imports Ransa.TypeDef.Moneda
Imports Ransa.Utilitario
Imports System.Reflection
Imports SOLMIN_ST.NEGOCIO


Public Class frmEvaluacionFinal
    Dim _CCMPN As String = ""
    Private Sub frmEvaluacionFinal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            _CCMPN = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy.ToString.Trim
            '_CCMPN = "EZ"
            Cargar_Proveedor_Filtro()
            Cargar_Region_Venta()
            Cargar_Mes()
            txtAnio.Text = HelpClass.TodayAnio()
        Catch ex As Exception

        End Try
       

    End Sub

    Private Function fblnValidaInformacion() As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True

        If cmbRegionVenta.EditValue = "" Then
            strMensajeError &= "Debe seleccionar Región de Venta. " & vbNewLine
        End If

        If txtAnio.Text.Trim = "" OrElse txtAnio.Text = "0" OrElse txtAnio.Text.Trim <= "2000" Then
            strMensajeError &= "Debe Ingresar un año correcto. " & vbNewLine
        End If

        If cmbMes.EditValue = "" Then
            strMensajeError &= "Debe seleccionar almenos un mes. " & vbNewLine
        End If

        If strMensajeError <> "" Then
            blnResultado = False
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return blnResultado
    End Function

    ''' <summary>
    ''' Cargar Region Venta (Negocio)
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Cargar_Region_Venta()
        Dim oRegionVenta As New RegionVenta_BLL
        oRegionVenta.Crea_Lista()
        Dim oDtRegionVenta As DataTable = oRegionVenta.fdtListaRegionVenta(_CCMPN)
        Me.cmbRegionVenta.Properties.ValueMember = "CRGVTA"
        Me.cmbRegionVenta.Properties.DisplayMember = "TCRVTA"
        Me.cmbRegionVenta.Properties.DataSource = oDtRegionVenta

        cmbRegionVenta.SetEditValue("R04")
    End Sub

    ''' <summary>
    ''' Cargar Mes 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Cargar_Mes()
        cmbMes.Properties.DataSource = HelpClass.odtMeses ' dtMes
        cmbMes.Properties.ValueMember = "Codigo"
        cmbMes.Properties.DisplayMember = "Descripcion"
        cmbMes.SetEditValue(Now.Month.ToString.PadLeft(2, "0"))
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub


    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try

            If Not fblnValidaInformacion() Then Exit Sub

            'Obtenemos los Meses
            Dim strMeses As String = String.Empty
            For i As Integer = 0 To cmbMes.Properties.Items.Count - 1
                If cmbMes.Properties.Items(i).CheckState Then
                    strMeses = strMeses & cmbMes.Properties.Items(i).Value & ","
                End If
            Next

            If strMeses.Length > 0 Then
                strMeses = strMeses.Substring(0, strMeses.Length - 1).ToString
            End If

            Dim Entidad As New EvaluacionOperativa
            Dim ObjNegocioEvalOperativa As New EvaluacionOperativa_BLL
            Entidad.CRGVTA = cmbRegionVenta.EditValue.ToString.Replace(" ", "")
            Entidad.MESES = strMeses
            Entidad.NRUCTR = cmbProveedorFiltro.pRucTransportista
            Entidad.ANIO = Val(Me.txtAnio.Text)
            Entidad.CCMPN = _CCMPN
            dgvEvaFinal.AutoGenerateColumns = False
            Dim oList As New List(Of EvaluacionOperativa)
            oList = ObjNegocioEvalOperativa.LISTAR_EVA_FINAL_CONSULTA(Entidad)
            dgvEvaFinal.DataSource = oList
        Catch ex As Exception
            MessageBox.Show(ex.Message & Chr(13) & " Origen: " & ex.Source.ToString)
        End Try
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Try
            If Not fblnValidaInformacion() Then Exit Sub

            'Obtenemos los Meses
            Dim strMeses As String = String.Empty
            For i As Integer = 0 To cmbMes.Properties.Items.Count - 1
                strMeses = strMeses & cmbMes.Properties.Items(i).Value & ","
            Next

            If strMeses.Length > 0 Then
                strMeses = strMeses.Substring(0, strMeses.Length - 1).ToString
            End If

            Dim Entidad As New EvaluacionOperativa
            Dim HTProveedor As New Hashtable
            Dim ObjNegocioEvalOperativa As New EvaluacionOperativa_BLL

            Entidad.CRGVTA = cmbRegionVenta.EditValue.ToString.Replace(" ", "")
            Entidad.MESES = strMeses
            Entidad.NRUCTR = cmbProveedorFiltro.pRucTransportista
            Entidad.ANIO = Val(Me.txtAnio.Text)
            Entidad.CCMPN = _CCMPN

            Dim tbEvaFin As New DataTable
            tbEvaFin = ObjNegocioEvalOperativa.EVA_FINAL_MES(Entidad)
            Dim tb As New DataTable
            For i As Integer = 0 To tbEvaFin.Rows.Count - 1
                If HTProveedor.Contains(tbEvaFin.Rows.Item(i)(0).ToString.Trim) = False Then
                    HTProveedor.Add(tbEvaFin.Rows.Item(i)(0).ToString.Trim, tbEvaFin.Rows.Item(i)(1).ToString.Trim)
                End If
            Next
            'For Each item As Object In HT.Keys
            '    MessageBox.Show(item)
            '    'Console.WriteLine(String.Format("La llave es {0}", o))
            '    'Console.WriteLine(obj.Item(o.ToString()))
            'Next
            HelpClass_NPOI.ExportExcel_EvalFinal("Eval. Mensual", Listar_Meses_X_Anio_excel(txtAnio.Text), tbEvaFin, HTProveedor)
        Catch ex As Exception
            MessageBox.Show(ex.Message & Chr(13) & " Origen: " & ex.Source.ToString)
        End Try
    End Sub
#Region "Metodos"

    Public Shared Function ConvertToDataTable(Of T)(ByVal list As IList(Of t)) As DataTable
        Dim dt As New DataTable()
        Dim propiedades As PropertyInfo() = GetType(T).GetProperties
        For Each p As PropertyInfo In propiedades
            dt.Columns.Add(p.Name, p.PropertyType)
        Next
        For Each item As T In list
            Dim row As DataRow = dt.NewRow
            For Each p As PropertyInfo In propiedades
                row(p.Name) = p.GetValue(item, Nothing)
            Next
            dt.Rows.Add(row)
        Next
        Return dt
    End Function

    Private Sub Cargar_Proveedor_Filtro()
        Dim obeProveedor As New Ransa.TypeDef.Transportista.TD_TransportistaPK
        obeProveedor.pCCMPN_Compania = _CCMPN
        'obeTransportista.pNRUCTR_RucTransportista = .pNRUCTR_RucProveedor
        cmbProveedorFiltro.pCargar(obeProveedor)
    End Sub


    Private Sub ListarMeses(ByRef pSelectControl As ComponentFactory.Krypton.Toolkit.KryptonComboBox, ByVal Anio As Integer, ByVal STR As String)
        pSelectControl.DataSource = Listar_Meses_X_Anio(Anio, STR)
        pSelectControl.ValueMember = "VALUE"
        pSelectControl.DisplayMember = "MES"
    End Sub

    Public Shared Function Listar_Meses_X_Anio(ByVal oAnio As String, ByVal STR As String) As DataTable
        Dim odtMeses As New DataTable
        odtMeses.Columns.Add("VALUE")
        odtMeses.Columns.Add("ANIO")
        odtMeses.Columns.Add("MES")

        odtMeses.Rows.Add(New Object() {0, oAnio, STR})
        odtMeses.Rows.Add(New Object() {oAnio + "01", oAnio, "ENERO"})
        odtMeses.Rows.Add(New Object() {oAnio + "02", oAnio, "FEBRERO"})
        odtMeses.Rows.Add(New Object() {oAnio + "03", oAnio, "MARZO"})
        odtMeses.Rows.Add(New Object() {oAnio + "04", oAnio, "ABRIL"})
        odtMeses.Rows.Add(New Object() {oAnio + "05", oAnio, "MAYO"})
        odtMeses.Rows.Add(New Object() {oAnio + "06", oAnio, "JUNIO"})
        odtMeses.Rows.Add(New Object() {oAnio + "07", oAnio, "JULIO"})
        odtMeses.Rows.Add(New Object() {oAnio + "08", oAnio, "AGOSTO"})
        odtMeses.Rows.Add(New Object() {oAnio + "09", oAnio, "SETIEMBRE"})
        odtMeses.Rows.Add(New Object() {oAnio + "10", oAnio, "OCTUBRE"})
        odtMeses.Rows.Add(New Object() {oAnio + "11", oAnio, "NOVIEMBRE"})
        odtMeses.Rows.Add(New Object() {oAnio + "12", oAnio, "DICIEMBRE"})
        Return odtMeses
    End Function

    Public Shared Function Listar_Meses_X_Anio_excel(ByVal oAnio As String) As DataTable
        Dim odtMeses As New DataTable
        odtMeses.Columns.Add("VALUE")
        odtMeses.Columns.Add("ANIO")
        odtMeses.Columns.Add("MES")
        odtMeses.Rows.Add(New Object() {1, oAnio, "ENERO"})
        odtMeses.Rows.Add(New Object() {2, oAnio, "FEBRERO"})
        odtMeses.Rows.Add(New Object() {3, oAnio, "MARZO"})
        odtMeses.Rows.Add(New Object() {4, oAnio, "ABRIL"})
        odtMeses.Rows.Add(New Object() {5, oAnio, "MAYO"})
        odtMeses.Rows.Add(New Object() {6, oAnio, "JUNIO"})
        odtMeses.Rows.Add(New Object() {7, oAnio, "JULIO"})
        odtMeses.Rows.Add(New Object() {8, oAnio, "AGOSTO"})
        odtMeses.Rows.Add(New Object() {9, oAnio, "SETIEMBRE"})
        odtMeses.Rows.Add(New Object() {10, oAnio, "OCTUBRE"})
        odtMeses.Rows.Add(New Object() {11, oAnio, "NOVIEMBRE"})
        odtMeses.Rows.Add(New Object() {12, oAnio, "DICIEMBRE"})
        Return odtMeses
    End Function

#End Region

    Private Sub txtAnio_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnio.KeyPress
        If e.KeyChar = "." Then
            e.Handled = True
            Exit Sub
        End If
        If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    End Sub
End Class
