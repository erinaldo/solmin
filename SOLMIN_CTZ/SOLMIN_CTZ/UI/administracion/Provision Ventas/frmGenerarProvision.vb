Imports SOLMIN_CTZ.NEGOCIO
Imports Ransa.Utilitario
Imports SOLMIN_CTZ.Entidades
Public Class frmGenerarProvision
    ''' <summary>
    ''' Modified: Miguel Dagnino 19/10/2015
    ''' </summary>
    ''' <remarks></remarks>
    Private bolEstado As Boolean
    Private _CCMPN As String
    Private Marcar As Image
    Private Desmarcar As Image
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property

    Private Sub frmGenerarProvision_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Cargar_Mes()
            Cargar_Region_Venta()
            txtAnio.Text = Now.Year
            Marcar = btnMarcarItems.BackgroundImage
            Desmarcar = btnMarcarItems.Image

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     

    End Sub

    Private Sub btnGenerarProvision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarProvision.Click

        Try
            GenerarProvision()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function fblnValidaGenerarProv() As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True

        If _CCMPN = "" Then
            strMensajeError &= "Compañia invalida." & vbNewLine
        End If
        If dtgOperaciones.RowCount = 0 Then
            strMensajeError &= "No hay operaciones para provisionar " & vbNewLine
        End If

        If cmbRegionVenta.SelectedValue = "" Then
            strMensajeError &= "Debe seleccionar negocio." & vbNewLine
        End If

        If txtAnio.Text.Trim = "" OrElse txtAnio.Text = "0" OrElse txtAnio.Text.Trim <= "2000" OrElse Not IsNumeric(txtAnio.Text) Then
            strMensajeError &= "Debe Ingresar un correcto. " & vbNewLine
        End If

        If cmbMes.SelectedValue = "" Then
            strMensajeError &= "Debe seleccionar mes." & vbNewLine
        End If

        If strMensajeError <> "" Then
            blnResultado = False
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return blnResultado
    End Function

    Private Sub GenerarProvision()
        Me.dtgOperaciones.EndEdit()
        Dim obrProvisionVentas As New clsProvisionDeVenta
        Dim ocabProvisionVentas As New ProvisionVenta
        'Dim olstdetProvisionVentas As New List(Of ProvisionVenta)
        Dim ultimoControl As Decimal
        Dim nroOperacion As Decimal
        Dim nroCorrelativoDoc As Integer = 0
        Dim intNroProvision As Integer
        Dim fechaProvision As Date
        Dim fecFacturaContado As Integer = 0
        Try
            If Not fblnValidaGenerarProv() Then Exit Sub

            With ocabProvisionVentas
                .CCMPN = _CCMPN
                .CRGVTA = Me.cmbRegionVenta.SelectedValue
                .CPLNDV = 0
                .CZNFCC = 0
                .CGRONG = "01"
                .ANOMES = Val(Me.txtAnio.Text & cmbMes.SelectedValue)
            End With

            fechaProvision = Me.ObtenerUltimoDiaMes(cmbMes.SelectedValue, Me.txtAnio.Text)

            If fechaProvision.Year > 1 Then
                Int32.TryParse(fechaProvision.ToString("yyyyMMdd"), fecFacturaContado)
            End If

            For Each item As ProvisionVenta In objListProvisionVenta
                If nroOperacion <> item.NOPRCN() Then
                    nroOperacion = item.NOPRCN()
                    ultimoControl = obrProvisionVentas.fIntObtenerUltimoControl()
                    nroCorrelativoDoc = 10
                End If

                item.CTPODC = 70
                item.NDCFCC = ultimoControl
                item.NCRDCC = nroCorrelativoDoc
                item.FDCFCC = fecFacturaContado

                nroCorrelativoDoc = nroCorrelativoDoc + 10
            Next

            intNroProvision = obrProvisionVentas.fintGenerProvision(ocabProvisionVentas, objListProvisionVenta)
            If intNroProvision < -1 Then
                Select Case intNroProvision
                    Case -2
                        MsgBox("Ya existe provisión para el mes de : " & Me.cmbMes.SelectedItem.Item("Descripcion"), MsgBoxStyle.Information)
                    Case Else
                        MsgBox("Debe de existir provisión creado en el mes anterior. ", MsgBoxStyle.Information)
                End Select
                Exit Sub
            End If
            If intNroProvision = -1 Then
                HelpClass.ErrorMsgBox()
            Else
                MsgBox("Se generó el Nro. de Provisión: " & CStr(intNroProvision), MsgBoxStyle.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            HelpClass.ErrorMsgBox()
        End Try

    End Sub

    ''' <summary>
    ''' Cargar Mes 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Cargar_Mes()
        cmbMes.DataSource = HelpClass.odtMeses ' dtMes
        cmbMes.ValueMember = "Codigo"
        cmbMes.DisplayMember = "Descripcion"
        cmbMes.SelectedValue = Now.Month.ToString.PadLeft(2, "0")
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    ''' <summary>
    ''' Cargar Region Venta (Negocio)
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Cargar_Region_Venta()
        Dim oRegionVenta As New SOLMIN_CTZ.NEGOCIO.clsRegionVenta
        oRegionVenta.Crea_Lista()
        Dim oDtRegionVenta As DataTable = oRegionVenta.fdtListaRegionVenta(_CCMPN)
        Me.cmbRegionVenta.ValueMember = "CRGVTA"
        Me.cmbRegionVenta.DisplayMember = "TCRVTA"
        Me.cmbRegionVenta.DataSource = oDtRegionVenta
        cmbRegionVenta.SelectedValue = "R04"
    End Sub

    Private Function fblnValidaInformacion() As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True

        If cmbRegionVenta.SelectedValue = "" Then
            strMensajeError &= "Debe seleccionar Región de Venta. " & vbNewLine
        End If

        If txtAnio.Text.Trim = "" OrElse txtAnio.Text = "0" OrElse txtAnio.Text.Trim <= "2000" Then
            strMensajeError &= "Debe Ingresar un año correcto. " & vbNewLine
        End If

        If cmbMes.SelectedValue = "" Then
            strMensajeError &= "Debe seleccionar almenos un mes. " & vbNewLine
        End If

        If strMensajeError <> "" Then
            blnResultado = False
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return blnResultado
    End Function

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim obrProvisionVentas As New clsProvisionDeVenta
        Dim obeProvisionVentas As New ProvisionVenta
        If Not fblnValidaInformacion() Then Exit Sub
        With obeProvisionVentas
            .CCMPN = _CCMPN
            .CRGVTA = cmbRegionVenta.SelectedValue
            .ANOMES = Val(Me.txtAnio.Text & cmbMes.SelectedValue)
        End With
        'ponemos en enabled 
        gbFiltro.Enabled = False
        btnGenerarProvision.Enabled = False
        Try
            bolEstado = False
            dtgOperaciones.AutoGenerateColumns = False
            objListProvisionVenta = obrProvisionVentas.fdtListaOperacionesParaProvionar(obeProvisionVentas)
            dtgOperaciones.DataSource = objListProvisionVenta
            TipoDeCambio()
            If dtgOperaciones.DataSource IsNot Nothing AndAlso dtgOperaciones.DataSource.count > 0 Then
                'Si hay información activamos el enabled
                gbFiltro.Enabled = True
                btnGenerarProvision.Enabled = True
                Llenar_Combo()
                bolEstado = True
            End If
        Catch ex As Exception
            HelpClass.ErrorMsgBox()
        End Try

    End Sub

#Region "Llenar Combos"
    Private objListProvisionVenta As New List(Of ProvisionVenta)

    Private Sub Limpiar_Combo()
        cmbClienteOp.DataSource = Nothing
        cmbClienteFac.DataSource = Nothing
    End Sub

    Private Sub Llenar_Combo()
        Limpiar_Combo()
        Llenar_ClienteOp()
        Llenar_ClienteFac()
    End Sub

    Private Sub Llenar_ClienteOp()


        Me.cmbClienteOp.DataSource = flisClienteOp()
        cmbClienteOp.DisplayMember = "CLI_OPE"
        cmbClienteOp.ValueMember = "CCLNT"
        cmbClienteOp.SelectedValue = 0D
    End Sub

    Private Sub Llenar_ClienteFac()


        Me.cmbClienteFac.DataSource = flisClienteFac()
        cmbClienteFac.DisplayMember = "CLI_FAC"
        cmbClienteFac.ValueMember = "CCLNT"
        cmbClienteFac.SelectedValue = 0D
    End Sub

    Private Function flisClienteOp() As List(Of ProvisionVenta)
        Dim objLisResulOProvisionVenta As New List(Of ProvisionVenta)
        Dim objProvisionVenta As ProvisionVenta
        Dim intCont As Integer
        Dim intRow As Integer
        Dim intExiste As Integer = 1
        If Me.objListProvisionVenta.Count > 0 Then
            objProvisionVenta = New ProvisionVenta
            objProvisionVenta.CCLNT = 0
            objProvisionVenta.CLI_OPE = " TODOS"
            objLisResulOProvisionVenta.Add(objProvisionVenta)
        End If
        For intRow = objListProvisionVenta.Count - 1 To 0 Step -1
            For intCont = 0 To objLisResulOProvisionVenta.Count - 1
                If objLisResulOProvisionVenta.Item(intCont).CCLNT = objListProvisionVenta.Item(intRow).CCLNT Then

                    intExiste = 0
                    Exit For
                Else
                    intExiste = 1
                End If
            Next
            If intExiste = 1 Then
                If objListProvisionVenta.Item(intRow).CCLNT <> 0 Then
                    objLisResulOProvisionVenta.Add(objListProvisionVenta.Item(intRow))
                End If
            End If
        Next
        Dim oucOrdena As UCOrdena(Of ProvisionVenta)
        oucOrdena = New UCOrdena(Of ProvisionVenta)("CLI_OPE", UCOrdena(Of ProvisionVenta).TipoOrdenacion.Ascendente)
        objLisResulOProvisionVenta.Sort(oucOrdena)
        Return objLisResulOProvisionVenta
    End Function

    Private Function flisClienteFac() As List(Of ProvisionVenta)
        Dim objLisResulOProvisionVenta As New List(Of ProvisionVenta)
        Dim objProvisionVenta As ProvisionVenta
        Dim intCont As Integer
        Dim intRow As Integer
        Dim intExiste As Integer = 1
        If Me.objListProvisionVenta.Count > 0 Then
            objProvisionVenta = New ProvisionVenta
            objProvisionVenta.CCLNFC = 0
            objProvisionVenta.CLI_FAC = " TODOS"
            objLisResulOProvisionVenta.Add(objProvisionVenta)
        End If
        For intRow = objListProvisionVenta.Count - 1 To 0 Step -1
            For intCont = 0 To objLisResulOProvisionVenta.Count - 1
                If objLisResulOProvisionVenta.Item(intCont).CCLNFC = objListProvisionVenta.Item(intRow).CCLNFC Then

                    intExiste = 0
                    Exit For
                Else
                    intExiste = 1
                End If
            Next
            If intExiste = 1 Then
                If objListProvisionVenta.Item(intRow).CCLNFC <> 0 Then
                    objLisResulOProvisionVenta.Add(objListProvisionVenta.Item(intRow))
                End If
            End If
        Next
        Dim oucOrdena As UCOrdena(Of ProvisionVenta)
        oucOrdena = New UCOrdena(Of ProvisionVenta)("CLI_FAC", UCOrdena(Of ProvisionVenta).TipoOrdenacion.Ascendente)
        objLisResulOProvisionVenta.Sort(oucOrdena)
        Return objLisResulOProvisionVenta
    End Function

 


#End Region
    Private Sub dtgOperaciones_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dtgOperaciones.DataBindingComplete
        Try

            Dim oList As New List(Of ProvisionVenta)
            Dim decTotalImporte As Decimal
            oList = Me.dtgOperaciones.DataSource
            
            If oList IsNot Nothing Then
                For Each item As ProvisionVenta In oList
                    decTotalImporte += item.ITTPRS
                Next
                hgProvision.ValuesSecondary.Heading = "Monto a cobrar : S/. " & Format(decTotalImporte, "###,###,###,###.00")
            End If
          
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cmbClienteOp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbClienteOp.SelectedIndexChanged
        If bolEstado Then
            Me.dtgOperaciones.DataSource = objListProvisionVenta.FindAll(match_Normal)
        End If

    End Sub

    Private match_Normal As New Predicate(Of ProvisionVenta)(AddressOf Busca_Normal)

    Public Function Busca_Normal(ByVal RolOpcionBE As ProvisionVenta) As Boolean
        If (RolOpcionBE.CCLNT = Me.cmbClienteOp.SelectedValue OrElse Me.cmbClienteOp.SelectedValue = 0) AndAlso (RolOpcionBE.CCLNFC = Me.cmbClienteFac.SelectedValue OrElse Me.cmbClienteFac.SelectedValue = 0) AndAlso (txtNroOperacion.Text = 0 OrElse RolOpcionBE.NOPRCN = txtNroOperacion.Text) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private match_PorOperacion As New Predicate(Of ProvisionVenta)(AddressOf Busca_PorOperacion)

    Public Function Busca_PorOperacion(ByVal RolOpcionBE As ProvisionVenta) As Boolean
        If RolOpcionBE.NOPRCN = txtNroOperacion.Text Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub txtNroOperacion_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNroOperacion.KeyUp
        Try
            If e.KeyValue = Keys.Enter Or e.KeyValue = Keys.Tab Then
                If txtNroOperacion.Text = "" Then
                    txtNroOperacion.Text = 0
                End If
                If IsNumeric(txtNroOperacion.Text) Then
                    Me.dtgOperaciones.DataSource = objListProvisionVenta.FindAll(match_Normal)
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub txtNroOperacion_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNroOperacion.Leave
        If txtNroOperacion.Text = "" Then
            txtNroOperacion.Text = 0
        End If
        If IsNumeric(txtNroOperacion.Text) Then
            Me.dtgOperaciones.DataSource = objListProvisionVenta.FindAll(match_Normal)
        End If
    End Sub

    Private Sub btnMarcarItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarcarItems.Click
        Me.Cursor = Cursors.WaitCursor
        If dtgOperaciones.RowCount > 0 Then
            If Existe_Check() Then
                Poner_Check_Todo_OC(False)
                btnMarcarItems.Image = Desmarcar
            Else
                Poner_Check_Todo_OC(True)
                btnMarcarItems.Image = Marcar
            End If
        End If
        Me.dtgOperaciones.EndEdit()
        Me.Cursor = Cursors.Default
    End Sub

    Private Function Existe_Check() As Boolean
        Dim intCont As Integer
        For intCont = 0 To dtgOperaciones.Rows.Count - 1
            If dtgOperaciones.Rows(intCont).Cells("chk").Value = True Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub Poner_Check_Todo_OC(ByVal blnEstado As Boolean)
        Dim intCont As Integer
        For intCont = 0 To dtgOperaciones.RowCount - 1
            dtgOperaciones.Rows(intCont).Cells("chk").Value = blnEstado
        Next intCont

    End Sub

    Private Sub cmbClienteFac_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbClienteFac.SelectedIndexChanged
        If bolEstado Then
            Me.dtgOperaciones.DataSource = objListProvisionVenta.FindAll(match_Normal)
        End If
    End Sub

    Public Function ObtenerUltimoDiaMes(ByVal intMonth, ByVal intYear) As Date
        Return DateSerial(intYear, intMonth + 1, 0)
    End Function

    'CSR-HUNDRED-ESTIMACION-INGRESO-INICIO
    Private Sub TipoDeCambio()
        Dim oDt As DataTable
        Dim oFacturaNeg As New SOLMIN_CTZ.NEGOCIO.clsFactura
        'Dim oFiltro As New Filtro
        Dim oFiltro As New Hashtable


        oFiltro("CMNDA1") = "100" 'tipo cambio dolares
        oFiltro("FCMBO") = Format(Date.Today.Date, "yyyyMMdd")
   


        oDt = oFacturaNeg.Lista_Tipo_Cambio(oFiltro)
        lblError.Text = ""
        If oDt.Rows.Count > 0 Then
            lbltipoCambio.Text = " Tipo de Cambio : " & oDt.Rows(0).Item("IVNTA").ToString.Trim
            btnGenerarProvision.Enabled = True
            lbltipoCambio.Visible = True
            lblError.Visible = False
        Else
            lblError.Text = "* No se puede generar la Provisión por no existir tipo de cambio para la fecha "
            btnGenerarProvision.Enabled = False
            lblError.Visible = True
            lbltipoCambio.Visible = False
        End If
    End Sub
    'CSR-HUNDRED-ESTIMACION-INGRESO-FIN


End Class
