


Imports SOLMIN_CTZ.NEGOCIO
Imports SOLMIN_CTZ.Entidades
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.Utilitario

Public Class frmProvisionDeVentas
    ''' <summary>
    ''' Modified: Miguel Dagnino 20/10/2015
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmProvisionDeVentas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Cargar_Compania()
            Cargar_Region_Venta()
            Cargar_Mes()
            txtAnio.Text = Now.Year.ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    
    End Sub


    Private Sub Cargar_Compania()
        UcCompania.Usuario = ConfigurationWizard.UserName
        UcCompania.pActualizar()
        UcCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
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

    ''' <summary>
    ''' Cargar Region Venta (Negocio)
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Cargar_Region_Venta()
        Dim oRegionVenta As New SOLMIN_CTZ.NEGOCIO.clsRegionVenta
        oRegionVenta.Crea_Lista()
        Dim oDtRegionVenta As DataTable = oRegionVenta.fdtListaRegionVenta(UcCompania.CCMPN_CodigoCompania)
        Me.cmbRegionVenta.Properties.ValueMember = "CRGVTA"
        Me.cmbRegionVenta.Properties.DisplayMember = "TCRVTA"
        Me.cmbRegionVenta.Properties.DataSource = oDtRegionVenta
    End Sub

    Private Sub btnGenerarProvision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarProvision.Click
        Try
            Dim ofrmGenerarProvision As New frmGenerarProvision
            ofrmGenerarProvision.CCMPN = UcCompania.CCMPN_CodigoCompania
            If ofrmGenerarProvision.ShowDialog() Then
                BuscarCabProvision()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            BuscarCabProvision()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub BuscarCabProvision()
        Dim obrProvisionVentas As New clsProvisionDeVenta
        Dim obeProvisionVentas As New ProvisionVenta
        If Not fblnValidaInformacion() Then Exit Sub

        Dim strMeses As String = String.Empty
        For i As Integer = 0 To cmbMes.Properties.Items.Count - 1
            If cmbMes.Properties.Items(i).CheckState Then
                strMeses = strMeses & Val(Me.txtAnio.Text & cmbMes.Properties.Items(i).Value) & ","
            End If
        Next

        If strMeses.Length > 0 Then
            strMeses = strMeses.Substring(0, strMeses.Length - 1).ToString
        End If

        With obeProvisionVentas
            .CCMPN = UcCompania.CCMPN_CodigoCompania
            .CRGVTA = cmbRegionVenta.EditValue.ToString.Replace(" ", "")
            .ANIOMES = strMeses
        End With

        dtgDetProvision.AutoGenerateColumns = False
        dtgDetProvision.DataSource = Nothing

        dtgCabProvision.AutoGenerateColumns = False
        'INI-ECM-Estimación-de-Ingreso-Anulación[RF001]-100516
        Dim dtListaProvision As New DataTable
        dtListaProvision = obrProvisionVentas.fdtListaProviones(obeProvisionVentas)
        Dim bit = New Bitmap(16, 16)
        dtListaProvision.Columns.Add("EstadoEnvioSAP", bit.GetType())
        bit.Dispose()

        For Each row As DataRow In dtListaProvision.Rows
            Dim indice As Integer = Integer.Parse(row("STDPROV"))
            row(dtListaProvision.Columns.Count - 1) = imlEstadoEnvioSAP.Images(indice)
        Next
        dtgCabProvision.DataSource = dtListaProvision
        'FIN-ECM-Estimación-de-Ingreso-Anulación[RF001]-100516
    End Sub

    Private Sub Exportar_Provision_Formato01()

        Dim oDs As New DataSet
        Dim obrProvisionVentas As New clsProvisionDeVenta
        Dim obeProvisionVentas As New ProvisionVenta
        If Not fblnValidaInformacion() Then Exit Sub

        Dim strMeses As String = String.Empty
        For i As Integer = 0 To cmbMes.Properties.Items.Count - 1
            If cmbMes.Properties.Items(i).CheckState Then
                strMeses = strMeses & Val(Me.txtAnio.Text & cmbMes.Properties.Items(i).Value) & ","
            End If
        Next

        If strMeses.Length > 0 Then
            strMeses = strMeses.Substring(0, strMeses.Length - 1).ToString
        End If

        With obeProvisionVentas
            .CCMPN = UcCompania.CCMPN_CodigoCompania
            .CRGVTA = cmbRegionVenta.EditValue.ToString.Replace(" ", "")
            .ANIOMES = strMeses
        End With

        oDs = obrProvisionVentas.fdsListaProvisionesExportar(obeProvisionVentas, 1)
        If oDs Is Nothing Then Exit Sub
        Dim olstr As New List(Of String)

        olstr.Add("Compañia :\n " & Me.UcCompania.CCMPN_Descripcion)
        olstr.Add("Negocio:\n " & IIf(Me.cmbRegionVenta.Text.Trim.Equals(""), "TODOS", Me.cmbRegionVenta.Text))
        olstr.Add("Año:\n " & txtAnio.Text) 'olstr.Add("Mes Año:\n " & cmbMes.Text & " de " & txtAnio.Text)

        Dim olstrSuma As New Hashtable

         

        olstrSuma.Add(1.1, 31)
        olstrSuma.Add(1.2, 32)
        olstrSuma.Add(1.3, 43)
        olstrSuma.Add(1.4, 44)


        olstrSuma.Add(2.1, 32)
        olstrSuma.Add(2.2, 33)
        olstrSuma.Add(2.3, 34)
        olstrSuma.Add(2.4, 56)
        olstrSuma.Add(2.5, 57)


        Dim intCorrelativo As Integer = 2
        For intX As Integer = 2 To oDs.Tables.Count - 1
            Dim intNroColumns As Integer = 8
            Dim strNroColumns As String = String.Empty
            For intColumns As Integer = 7 To oDs.Tables(intX).Columns.Count
                If intCorrelativo.ToString.Length = 1 Then
                    strNroColumns = (intX + 1).ToString & ".0" & (intCorrelativo).ToString
                Else
                    strNroColumns = (intX + 1).ToString & "." & (intCorrelativo).ToString
                End If

                olstrSuma.Add(CType(strNroColumns, Decimal), intNroColumns)
                intNroColumns += 1
                intCorrelativo += 1
            Next

        Next

        Ransa.Utilitario.HelpClass.ExportExcel_Formato01(oDs, "Consulta de Provisiones", olstr, olstrSuma)


       

    End Sub

    

    Private Sub Exportar_Provision_Formato02()

        Dim oDs As New DataSet
        Dim obrProvisionVentas As New clsProvisionDeVenta
        Dim obeProvisionVentas As New ProvisionVenta
        If Not fblnValidaInformacion() Then Exit Sub

        Dim strMeses As String = String.Empty
        For i As Integer = 0 To cmbMes.Properties.Items.Count - 1
            If cmbMes.Properties.Items(i).CheckState Then
                strMeses = strMeses & Val(Me.txtAnio.Text & cmbMes.Properties.Items(i).Value) & ","
            End If
        Next

        If strMeses.Length > 0 Then
            strMeses = strMeses.Substring(0, strMeses.Length - 1).ToString
        End If

        With obeProvisionVentas
            .CCMPN = UcCompania.CCMPN_CodigoCompania
            .CRGVTA = cmbRegionVenta.EditValue.ToString.Replace(" ", "")
            .ANIOMES = strMeses
        End With

        oDs = obrProvisionVentas.fdsListaProvisionesExportar(obeProvisionVentas, 2)
        If oDs Is Nothing Then Exit Sub
        Dim olstr As New List(Of String)

        olstr.Add("Compañia :\n " & Me.UcCompania.CCMPN_Descripcion)
        olstr.Add("Negocio:\n " & IIf(Me.cmbRegionVenta.Text.Trim.Equals(""), "TODOS", Me.cmbRegionVenta.Text))
        olstr.Add("Año:\n " & txtAnio.Text) 'olstr.Add("Mes Año:\n " & cmbMes.Text & " de " & txtAnio.Text)

        Dim olstrSuma As New Hashtable

        olstrSuma.Add(1.1, 31)
        olstrSuma.Add(1.2, 32)
        olstrSuma.Add(1.3, 43)
        olstrSuma.Add(1.4, 44)


        olstrSuma.Add(2.1, 32)
        olstrSuma.Add(2.2, 33)
        olstrSuma.Add(2.3, 34)
        olstrSuma.Add(2.4, 56)
        olstrSuma.Add(2.5, 57)


        Dim intCorrelativo As Integer = 2
        For intX As Integer = 2 To oDs.Tables.Count - 1
            Dim intNroColumns As Integer = 10
            Dim strNroColumns As String = String.Empty
            For intColumns As Integer = 9 To oDs.Tables(intX).Columns.Count
                strNroColumns = (intX + 1).ToString & "." & intCorrelativo
                olstrSuma.Add(CType(strNroColumns, Decimal), intNroColumns)
                intNroColumns += 1
                intCorrelativo += 1
            Next

        Next

        Ransa.Utilitario.HelpClass.ExportExcel_Formato01(oDs, "Consulta de Provisiones", olstr, olstrSuma)

 

    End Sub
    Private Sub Exportar_Provision_Formato03()

        Dim oDs As New DataSet
        Dim obrProvisionVentas As New clsProvisionDeVenta
        Dim obeProvisionVentas As New ProvisionVenta
        If Not fblnValidaInformacion() Then Exit Sub

        Dim strMeses As String = String.Empty
        For i As Integer = 0 To cmbMes.Properties.Items.Count - 1
            If cmbMes.Properties.Items(i).CheckState Then
                strMeses = strMeses & Val(Me.txtAnio.Text & cmbMes.Properties.Items(i).Value) & ","
            End If
        Next

        If strMeses.Length > 0 Then
            strMeses = strMeses.Substring(0, strMeses.Length - 1).ToString
        End If

        With obeProvisionVentas
            .CCMPN = UcCompania.CCMPN_CodigoCompania
            .CRGVTA = cmbRegionVenta.EditValue.ToString.Replace(" ", "")
            .ANIOMES = strMeses
        End With

        oDs = obrProvisionVentas.fdsListaProvisionExportarCAT(obeProvisionVentas)
        If oDs Is Nothing Then Exit Sub
        Dim olstr As New List(Of String)   'JM
        
 

        Dim olstrSuma As New Hashtable
 
        olstrSuma.Add(1.1, 31)
        olstrSuma.Add(1.2, 32)
        olstrSuma.Add(1.3, 43)
        olstrSuma.Add(1.4, 44)


        olstrSuma.Add(2.1, 32)
        olstrSuma.Add(2.2, 33)
        olstrSuma.Add(2.3, 34)
        olstrSuma.Add(2.4, 55)
        olstrSuma.Add(2.5, 56)



        Dim intCorrelativo As Integer = 2
        For intX As Integer = 2 To oDs.Tables.Count - 1
            Dim intNroColumns As Integer = 10
            Dim strNroColumns As String = String.Empty
            For intColumns As Integer = 9 To oDs.Tables(intX).Columns.Count
                strNroColumns = (intX + 1).ToString & "." & intCorrelativo
                olstrSuma.Add(CType(strNroColumns, Decimal), intNroColumns)
                intNroColumns += 1
                intCorrelativo += 1
            Next
        Next

        If oDs.Tables.Count = 2 Then
            oDs.Tables(0).TableName = "cabecera"
            oDs.Tables(1).TableName = "detalle"
        Else
            oDs.Tables(0).TableName = "REPORTE CAT"
        End If

        Ransa.Utilitario.HelpClass.ExportExcel_Formato03(oDs, Nothing, olstr, olstrSuma)


       

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

    Private Sub dtgCabProvision_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgCabProvision.SelectionChanged
        Try
            BuscarDetProvision()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


    Private Sub BuscarDetProvision()
        If Me.dtgCabProvision.CurrentCellAddress.Y = -1 Then Exit Sub

        Dim obrProvisionVentas As New clsProvisionDeVenta
        Dim obeProvisionVentas As New ProvisionVenta
        With obeProvisionVentas
            .CCMPN = dtgCabProvision.CurrentRow.DataBoundItem.Item("CCMPN")
            .NMPRVT = dtgCabProvision.CurrentRow.DataBoundItem.Item("NMPRVT")
        End With
        dtgDetProvision.AutoGenerateColumns = False
        dtgDetProvision.DataSource = obrProvisionVentas.fdtDetalleProviones(obeProvisionVentas)
      

    End Sub



    Private Sub dtgDetProvision_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgDetProvision.CellDoubleClick
        If dtgDetProvision.CurrentCellAddress.Y = -1 Then Exit Sub
        If dtgDetProvision.Columns(e.ColumnIndex).Name = "Detalle" Then
            Try
                Dim ofrmListOperacionesProvision As New frmListOperacionesProvision
                Dim obeProvisionVenta As New ProvisionVenta

                With obeProvisionVenta
                    .CCMPN = dtgDetProvision.CurrentRow.DataBoundItem.item("CCMPN")
                    .NMPRVT = dtgDetProvision.CurrentRow.DataBoundItem.item("NMPRVT")
                    .CCNTCS = dtgDetProvision.CurrentRow.DataBoundItem.item("CCNTCS")
                    .CCLNFC = dtgDetProvision.CurrentRow.DataBoundItem.item("CCLNFC")

                End With
                ofrmListOperacionesProvision.obeProvisionVenta = obeProvisionVenta
                ofrmListOperacionesProvision.ShowDialog()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


        End If

    End Sub

 

    Private Sub tsmFormato01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmFormato01.Click
        Try
            Exportar_Provision_Formato01()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub tsmFormato02_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmFormato02.Click
        Try
            Exportar_Provision_Formato02()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    
    Private Sub tsmFormato03_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmFormato03.Click
        Try
            Exportar_Provision_Formato03()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'ECM-Estimación-de-Ingreso-Anulación[RF001]-100516
    Private Sub BtnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnular.Click
        Try
            Dim logica As New clsProvisionDeVenta
            Dim parametros As New ProvisionVenta

            With parametros
                .CCMPN = dtgDetProvision.CurrentRow.DataBoundItem.item("CCMPN") 'Compañía 
                .NMPRVT = dtgDetProvision.CurrentRow.DataBoundItem.item("NMPRVT") 'Provisión de Venta 
                .PSUSUARIO = ConfigurationWizard.UserName  'Usuario 
                .NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
            End With

            Select Case logica.ValidarAnulacionProvision(parametros)
                Case 1
                    logica.AnularProvision(parametros)
                    MessageBox.Show("Se realizó el proceso de anulación satisfactoriamente.", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call BuscarCabProvision()
                Case 2
                    MessageBox.Show("No se puede Anular la Provisión debido que contiene operaciones Provisionadas con reversión.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
