Imports RANSA.NEGO
Imports Ransa.Controls.ServicioOperacion
Imports RANSA.TYPEDEF
Imports Ransa.Utilitario

Public Class frmOcupabilidadInventario

#Region "Variables"
    Private _oServicio As Servicio_BE
    Private odata As DataTable
#End Region

#Region "Eventos de Formulario"
    Private Sub frmOcupabilidadInventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarTipoAlmacen()
        Listar_Compania()
        txtAnio.Text = Now.Year
        Lista_Meses()
    End Sub

    Private Sub UcCompania_Cmb011_Seleccionar(ByVal obeCompania As Ransa.TYPEDEF.UbicacionPlanta.Compania.beCompania) Handles UcCompania_Cmb011.Seleccionar
        UcDivision_Cmb011.Compania = obeCompania.CCMPN_CodigoCompania
        UcDivision_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcDivision_Cmb011.pActualizar()
    End Sub

    Private Sub UcDivision_Cmb011_Seleccionar(ByVal obeDivision As Ransa.TYPEDEF.UbicacionPlanta.Division.beDivision) Handles UcDivision_Cmb011.Seleccionar
        UcPLanta_Cmb011.CodigoDivision = obeDivision.CDVSN_CodigoDivision
        UcPLanta_Cmb011.CodigoCompania = obeDivision.CCMPN_CodigoCompania
        UcPLanta_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcPLanta_Cmb011.pActualizar()
    End Sub

    Private Sub txtTipoAlmacen_CambioDeTexto(ByVal objData As Object) Handles txtTipoAlmacen.CambioDeTexto
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CALMC"
        oColumnas.DataPropertyName = "PSCALMC"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMPAL"
        oColumnas.DataPropertyName = "PSTCMPAL"
        oColumnas.HeaderText = "Almacén "
        oListColum.Add(2, oColumnas)
        Dim obrAlmacen As New brAlmacen
        If Not objData Is Nothing Then
            'CType(objData, beAlmacen).PNCPLNFC = 1
            CType(objData, beAlmacen).PNCPLNFC = UcPLanta_Cmb011.Planta
            txtAlmacen.DataSource = obrAlmacen.ListaAlmacen(objData)
        Else
            txtAlmacen.DataSource = Nothing
        End If
        txtAlmacen.ListColumnas = oListColum
        txtAlmacen.Cargas()
        txtAlmacen.Limpiar()
        txtAlmacen.ValueMember = "PSCALMC"
        txtAlmacen.DispleyMember = "PSTCMPAL"
    End Sub

    Private Sub tsbBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbBuscar.Click
        If Not AsValidarFiltro() Then
            Return
        End If
        ListarOcupabilidad()
    End Sub

    Private Sub tsbExportarXLS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarXLS.Click
     
        Try
            Dim oDt As New DataTable
            Dim odtNew As New DataTable
            Dim oDs As New DataSet
            Dim oblInventarioMercaderia As New blRegistroInventario()
            If dgDisInventario.RowCount > 0 Then

                odtNew = odata.Copy()
                odtNew.TableName = "Ocupabilidad Almacen"
                odtNew.Columns.Remove("CTPALM")
                odtNew.Columns.Remove("TALMC")
                odtNew.Columns(0).ColumnName = "ALMACÉN  \n CÓDIGO"
                odtNew.Columns(1).ColumnName = "ALMACÉN  \n DESCRIPCIÓN"
                odtNew.Columns(2).ColumnName = "ZONA  \n CÓDIGO"
                odtNew.Columns(3).ColumnName = "ZONA  \n DESCRIPCIÓN"
                odtNew.Columns(4).ColumnName = " TOTAL  \n UBICACIONES " + vbNewLine + "(A)"
                odtNew.Columns(5).ColumnName = " TOTAL UBICACIONES \n  OCUPADAS" + vbNewLine + "(B)"
                odtNew.Columns(6).ColumnName = "OCUPABILIDAD \n ALMACEN " + vbNewLine + "(B/A)"
                oDs.Tables.Add(odtNew)
                Dim lststrTitulo As New List(Of String)
                lststrTitulo.Add("Compañia : \n" & UcCompania_Cmb011.CCMPN_Descripcion)
                lststrTitulo.Add("División : \n" & UcDivision_Cmb011.DivisionDescripcion)
                lststrTitulo.Add("Planta : \n" & UcPLanta_Cmb011.DescripcionPlanta)
                lststrTitulo.Add("Tipo Almacén: \n" & CType(txtTipoAlmacen.Resultado, beAlmacen).PSTALMC)
                Try
                    'If CType(txtAlmacen.Resultado, beAlmacen).PSTCMPAL = Nothing Or CType(txtAlmacen.Resultado, beAlmacen).PSTCMPAL = String.Empty Then
                    lststrTitulo.Add("Almacén : \n" & CType(txtAlmacen.Resultado, beAlmacen).PSTCMPAL)
                    'End If
                Catch ex As Exception
                    lststrTitulo.Add("Almacén : \n" & "TODOS")
                End Try

                'strTitulo.Add("Almacén : \n" & CType(txtAlmacen.Resultado, beAlmacen).PSTCMPAL)
                lststrTitulo.Add("Año Mes : \n" & txtAnio.Text + " - " + cboMes.Text)
                '==========================Exportamos==========================
                HelpClass.ExportExcelConTitulos(oDs, Me.Text, lststrTitulo)
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al exportar: " + ex.Message, "Disponibilidad Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Me.Close()
    End Sub

    Private Sub txtAnio_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnio.KeyPress
        If Not e.KeyChar = ChrW(Keys.Back) Then
            If Not IsNumeric(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

#End Region

#Region "Eventos y Funciones"
    Sub Lista_Meses()
        Dim dtMeses As New DataTable
        Dim dr As DataRow
        Dim Mes As String = String.Empty
        Dim NumMes As String = String.Empty
        dtMeses.Columns.Add("CODMES")
        dtMeses.Columns.Add("DESMES")
        Dim CurrentCI = System.Threading.Thread.CurrentThread.CurrentCulture
        Dim Culture = New System.Globalization.CultureInfo("es-PE")
        For index As Integer = 1 To 12
            dr = dtMeses.NewRow()
            NumMes = StringRight("0" & index, 2)

            Mes = MonthName(index).ToUpper(Culture)
            dr.Item("CODMES") = NumMes
            dr.Item("DESMES") = Mes
            dtMeses.Rows.Add(dr)
        Next
        cboMes.DataSource = dtMeses
        cboMes.DisplayMember = "DESMES"
        cboMes.ValueMember = "CODMES"
        cboMes.SelectedValue = "01"
        System.Threading.Thread.CurrentThread.CurrentCulture = CurrentCI
    End Sub

    Public Function StringRight(ByVal cadena As String, ByVal numCaracteres As Int32) As String
        Try
            cadena = cadena.Trim
            If (cadena <> "") Then
                If (numCaracteres > cadena.Length) Then
                    numCaracteres = 0
                End If
                cadena = cadena.Substring(cadena.Length - numCaracteres, numCaracteres)
            End If
        Catch ex As Exception
        End Try
        Return cadena
    End Function

    Private Sub Listar_Compania()
        UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcCompania_Cmb011.pActualizar()
        UcCompania_Cmb011.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    End Sub

    Private Sub cargarTipoAlmacen()
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CTPALM"
        oColumnas.DataPropertyName = "PSCTPALM"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TALMC"
        oColumnas.DataPropertyName = "PSTALMC"
        oColumnas.HeaderText = "Tipo Almacén "
        oListColum.Add(2, oColumnas)
        Dim obrAlmacen As New brAlmacen
        txtTipoAlmacen.DataSource = obrAlmacen.ListaTipoDeAlmacen()
        txtTipoAlmacen.ListColumnas = oListColum
        txtTipoAlmacen.Cargas()
        txtTipoAlmacen.ValueMember = "PSCTPALM"
        txtTipoAlmacen.DispleyMember = "PSTALMC"

    End Sub

    Private Function AsValidarFiltro() As Boolean
        Dim booOk As Boolean = True
        Dim strMensajeError As String = String.Format("No se pudo realizar la consulta por lo siguiente: {0}", Environment.NewLine)
        If UcCompania_Cmb011.CCMPN_CodigoCompania = Nothing Or UcCompania_Cmb011.CCMPN_CodigoCompania.Trim() = String.Empty Then
            'MessageBox.Show("Debe de seleccionar Campaña.", "Ocupabilidad Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            strMensajeError += String.Format("- Debe de seleccionar Campaña. {0}", Environment.NewLine)
            booOk = False
        End If
        If UcDivision_Cmb011.Division = Nothing Then
            'MessageBox.Show("Debe de seleccionar Division.", "Ocupabilidad Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            strMensajeError += String.Format("- Debe de seleccionar División. {0}", Environment.NewLine)
            booOk = False
        End If
        If UcPLanta_Cmb011.Planta = Nothing Then
            If UcPLanta_Cmb011.Planta = 0 Then
                'MessageBox.Show("Debe de seleccionar Planta.", "Ocupabilidad Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                strMensajeError += String.Format("- Debe de seleccionar Planta. {0}", Environment.NewLine)
                booOk = False
            End If
        End If
        Try
            If CType(txtTipoAlmacen.Resultado, beAlmacen).PSCTPALM = Nothing Or CType(txtTipoAlmacen.Resultado, beAlmacen).PSCTPALM = String.Empty Then
                'MessageBox.Show("Debe de seleccionar Tipo de Almacen.", "Ocupabilidad Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                strMensajeError += String.Format("- Debe de seleccionar Tipo de Almacen. {0}", Environment.NewLine)
                booOk = False
            End If
        Catch ex As Exception
            strMensajeError += String.Format("- Debe de seleccionar Tipo de Almacen. {0}", Environment.NewLine)
            booOk = False
        End Try
        If txtAnio.Text = String.Empty Then
            'MessageBox.Show("Debe de Ingresar el Año.", "Ocupabilidad Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            strMensajeError += String.Format("- Debe de Ingresar el Año. {0}", Environment.NewLine)
            booOk = False
        End If
        If cboMes.SelectedValue = String.Empty Then
            'MessageBox.Show("Debe de Seleccionar el Mes.", "Disponibilidad Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            strMensajeError += String.Format("- Debe de Seleccionar el Mes. {0}", Environment.NewLine)
            booOk = False
        End If
        If Not booOk Then
            MessageBox.Show(strMensajeError, "Ocupabilidad Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        Return booOk
    End Function

    Private Sub ListarOcupabilidad()
        Try
            Dim objblRegistroInventario As New blRegistroInventario
            Dim dt As New DataTable
            dt = objblRegistroInventario.ListarOcupabilidadAlmacen(ObtenerOcupabilidad()).Tables(0)
            odata = dt.Copy()
            dgDisInventario.DataSource = dt
            If dgDisInventario.RowCount > 0 Then
                tsbExportarXLS.Enabled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Function ObtenerOcupabilidad() As beProductoxRegularizar
        Dim objbeProductoxRegularizar As New beProductoxRegularizar
        objbeProductoxRegularizar.PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
        objbeProductoxRegularizar.PSCCVSN = UcDivision_Cmb011.Division
        objbeProductoxRegularizar.PNCPLNDV = UcPLanta_Cmb011.Planta
        objbeProductoxRegularizar.PSCTPALM = CType(txtTipoAlmacen.Resultado, beAlmacen).PSCTPALM
        Try
            objbeProductoxRegularizar.PSCALMC = CType(txtAlmacen.Resultado, beAlmacen).PSCALMC
        Catch ex As Exception
            objbeProductoxRegularizar.PSCALMC = String.Empty
        End Try
        objbeProductoxRegularizar.PNFECINV = txtAnio.Text & cboMes.SelectedValue & HelpClass.DiasMesPorAño(Convert.ToInt64(txtAnio.Text), cboMes.SelectedValue)
        Return objbeProductoxRegularizar
    End Function
#End Region



End Class