Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.NEGOCIO
Imports SOLMIN_CTZ.Entidades
Imports Ransa.Utilitario
Imports Ransa.Controls.ServicioOperacion
Imports Ransa.Controls.ServTransp
Imports System.Threading
Public Class frmListaTarifas

#Region "Declaracion de variables"
    Private _oContrato As SOLMIN_CTZ.Entidades.Contrato
    Private oHebraEnvioEmailReq As Thread
    Public Property oContrato() As SOLMIN_CTZ.Entidades.Contrato
        Get
            Return _oContrato
        End Get
        Set(ByVal value As SOLMIN_CTZ.Entidades.Contrato)
            _oContrato = value
        End Set
    End Property
    Private oPlanta As SOLMIN_CTZ.NEGOCIO.clsPlanta = New SOLMIN_CTZ.NEGOCIO.clsPlanta
    Private oServicio As SOLMIN_CTZ.NEGOCIO.clsServicio = New SOLMIN_CTZ.NEGOCIO.clsServicio
    Private oDtPlanta As New DataTable

    Private _pCodigoCompania As String = ""
    Public Property pCodigoCompania() As String
        Get
            Return _pCodigoCompania
        End Get
        Set(ByVal value As String)
            _pCodigoCompania = value
        End Set
    End Property


    Enum EnumTIPO_FORM
        CONSULTA
        EDICION
    End Enum


    Private _TipoEnumForm As EnumTIPO_FORM = EnumTIPO_FORM.CONSULTA
    Public Property pTipoEnumForm() As EnumTIPO_FORM
        Get
            Return _TipoEnumForm
        End Get
        Set(ByVal value As EnumTIPO_FORM)
            _TipoEnumForm = value
        End Set
    End Property

#End Region

#Region "Eventos de Control"

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
      

        If oContrato.SESTRG = "C" Or oContrato.SESTRG = "R" Then
            MessageBox.Show("No puede agregar tarifas a un contrato anulado/vencido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub           
        End If
 

        Try
            Dim TipoTarifaGenerar As String = cbtGeneraTipo.ComboBox.SelectedValue
            Dim objTarifa As New Tarifa
            Select Case TipoTarifaGenerar
                Case "01"

                    objTarifa.NRCTSL = _oContrato.NRCTSL
                    objTarifa.CCMPN = _oContrato.CCMPN
                    Dim frmAdmin As New frmGenTarifaAdmin(Nothing, objTarifa, _oContrato, Nothing, frmGenTarifaAdmin.EnumTipo.Nuevo)
                    frmAdmin.pCodigoCompania = Me.pCodigoCompania

                    If frmAdmin.ShowDialog = Windows.Forms.DialogResult.OK Then

                        cboEstado.SelectedValue = "P"
                        ListarTarifas()
                    End If

                Case "02"

                    objTarifa.NRCTSL = _oContrato.NRCTSL
                    objTarifa.CCMPN = _oContrato.CCMPN
                    Dim frmOS As New frmGenTarifaOS(Nothing, objTarifa, _oContrato, Nothing, frmGenTarifaOS.EnumTipo.Nuevo)
                    frmOS.pCodigoCompania = Me.pCodigoCompania

                    If frmOS.ShowDialog = Windows.Forms.DialogResult.OK Then

                        cboEstado.SelectedValue = "P"
                        ListarTarifas()
                    End If

            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

       
    End Sub

    Private Sub frmListaTarifas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Cargar()
            CargarRubro()
            CargarRubroServicio()
            'CargarTarifas()
            ListarTarifas()

            Dim dtTipo As New DataTable
            dtTipo.Columns.Add("COD")
            dtTipo.Columns.Add("DESC")
            Dim dr As DataRow
            dr = dtTipo.NewRow
            dr("COD") = "01"
            dr("DESC") = "Administrativo"
            dtTipo.Rows.Add(dr)

            dr = dtTipo.NewRow
            dr("COD") = "02"
            dr("DESC") = "Orden Servicio"
            dtTipo.Rows.Add(dr)

            cbtGeneraTipo.ComboBox.DataSource = dtTipo
            cbtGeneraTipo.ComboBox.DisplayMember = "DESC"
            cbtGeneraTipo.ComboBox.ValueMember = "COD"
            cbtGeneraTipo.ComboBox.SelectedValue = "01"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        Try
            If dtgTarifaContrato.CurrentCellAddress.Y = -1 Then Exit Sub

            Dim OS As Decimal = dtgTarifaContrato.CurrentRow.Cells("NORSRT").Value

            If OS > 0 Then
                Dim objTarifa As Tarifa
                Dim objRango As SOLMIN_CTZ.Entidades.Rango
                Dim frm As frmGenTarifaOS
                Dim rowActual As Integer = 0
                rowActual = dtgTarifaContrato.CurrentCellAddress.Y
                objTarifa = New Tarifa
                objRango = New SOLMIN_CTZ.Entidades.Rango
                objTarifa.NRCTSL = _oContrato.NRCTSL
                objTarifa.CCMPN = _oContrato.CCMPN
                objTarifa.CDVSN = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("CDVSN")
                objTarifa.CPLNDV = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("CPLNDV")
                objTarifa.NRTFSV = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("NRTFSV")
                objTarifa.NRRUBR = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("NRRUBR")
                objTarifa.NRSRRB = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("NRSRRB")
                objTarifa.SESTRG = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("Estado")
                objTarifa.FTRTSG = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("FTRTSG")


                frm = New frmGenTarifaOS(Nothing, objTarifa, _oContrato, objRango, frmGenTarifaOS.EnumTipo.Edicion)
                frm.pCodigoCompania = Me.pCodigoCompania
                If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    'CargarTarifas()
                    ListarTarifas()
                End If


            Else

                Dim objTarifa As Tarifa
                Dim objRango As SOLMIN_CTZ.Entidades.Rango
                Dim frm As frmGenTarifaAdmin
                Dim rowActual As Integer = 0
                rowActual = dtgTarifaContrato.CurrentCellAddress.Y
                objTarifa = New Tarifa
                objRango = New SOLMIN_CTZ.Entidades.Rango
                objTarifa.NRCTSL = _oContrato.NRCTSL
                objTarifa.CCMPN = _oContrato.CCMPN
                objTarifa.CDVSN = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("CDVSN")
                objTarifa.CPLNDV = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("CPLNDV")
                objTarifa.NRTFSV = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("NRTFSV")
                objTarifa.NRRUBR = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("NRRUBR")
                objTarifa.NRSRRB = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("NRSRRB")
                objTarifa.CMNDA1 = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("CMNDA1")
                objTarifa.IVLSRV = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("IVLSRV")
                objTarifa.CUNDMD = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("CUNDMD")
                objTarifa.CCNTCS = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("CCNTCS")
                objRango.DESRNG = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("DESTAR")
                objTarifa.STPTRA = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("STPTRA")
                objTarifa.VALCTE = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("VALCTE")
                objTarifa.PRLBPG = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("PRLBPG")
                objTarifa.FAPLBR = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("FAPLBR")
                objTarifa.SESTRG = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("Estado")
                objTarifa.NRRELF = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("NRRELF")

                objTarifa.TTPOMR = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("TTPOMR")
                objTarifa.CTPALM = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("CTPALM")
                objTarifa.NDIAPL = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("NDIAPL")


                objTarifa.TOBS = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("TOBS")

                objTarifa.CDTREF = CType("0" & Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("CDTREF"), Double)
                objTarifa.DIACOR = CType("0" & Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("DIACOR"), Int32)

                '<[AHM]>
                'objTarifa.CDSDSP = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("CDSDSP")
                objTarifa.CDSRSP = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("CDSRSP")
                objTarifa.CDTSSP = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("CDTSSP")
                objTarifa.CDTASP = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("CDTASP")
                'objTarifa.CDSPSP = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("CDSPSP")
                objTarifa.CDUPSP = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("CDUPSP")
                objTarifa.CDSCSP = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("CDSCSP")
                '</[AHM]>

                'RCS-HUNDRED-INICIO
                objTarifa.ISRVTI = CType(Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("ISRVTI"), Double)
                objTarifa.CENCOS = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("CENCOS")
                objTarifa.CENCO2 = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("CENCO2")



                'RCS-HUNDRED-FIN

                'frm = New frmGenTarifaAdmin(Nothing, objTarifa, _oContrato, objRango, frmDefTarifa.EnumTipo.Edicion)
                frm = New frmGenTarifaAdmin(Nothing, objTarifa, _oContrato, objRango, frmGenTarifaAdmin.EnumTipo.Edicion)
                frm.pCodigoCompania = Me.pCodigoCompania
                If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then

                    ListarTarifas()
                End If


            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     


        
    End Sub

    Private Sub btnExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click
        Try
            ExportarExcel()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region "Procedimientos de y Funciones"


    Private Sub Cargar()
        Me.txtDatNumContrato.Text = _oContrato.NCNTRT
        Me.mskDatIniContrato.Text = _oContrato.FechaInicio
        Me.mskDatFinContrato.Text = _oContrato.FechaFin

        UcDivision.Compania = _oContrato.CCMPN
        UcDivision.Usuario = ConfigurationWizard.UserName
        UcDivision.pActualizar()


        Dim dtEstadoTarifa As New DataTable
        dtEstadoTarifa.Columns.Add("DISPLAY")
        dtEstadoTarifa.Columns.Add("VALUE")
        Dim dr As DataRow

        dr = dtEstadoTarifa.NewRow
        dr("DISPLAY") = "TODOS"
        dr("VALUE") = "T"
        dtEstadoTarifa.Rows.Add(dr)

        dr = dtEstadoTarifa.NewRow
        dr("DISPLAY") = "PENDIENTE"
        dr("VALUE") = "P"
        dtEstadoTarifa.Rows.Add(dr)


        dr = dtEstadoTarifa.NewRow
        dr("DISPLAY") = "EN APROBACION"
        dr("VALUE") = "B"
        dtEstadoTarifa.Rows.Add(dr)


        dr = dtEstadoTarifa.NewRow
        dr("DISPLAY") = "ACTIVO"
        dr("VALUE") = "A"
        dtEstadoTarifa.Rows.Add(dr)

        dr = dtEstadoTarifa.NewRow
        dr("DISPLAY") = "ANULADO"
        dr("VALUE") = "*"
        dtEstadoTarifa.Rows.Add(dr)

        dr = dtEstadoTarifa.NewRow
        dr("DISPLAY") = "CERRADO"
        dr("VALUE") = "C"
        dtEstadoTarifa.Rows.Add(dr)

        cboEstado.DataSource = dtEstadoTarifa
        cboEstado.DisplayMember = "DISPLAY"
        cboEstado.ValueMember = "VALUE"
        cboEstado.SelectedValue = "A"

        cboEstado_SelectionChangeCommitted(cboEstado, Nothing)
    End Sub

    Private Sub CargarRubro()
        Dim oFiltro As New SOLMIN_CTZ.Entidades.Filtro
        Dim oDtAux As New DataTable
        Dim oDr As DataRow
        Dim oDTabla As New DataTable
        oDtAux.Columns.Add("NRRUBR", GetType(String))
        oDtAux.Columns.Add("NOMRUB", GetType(String))
        Dim oDtSer As New DataTable

        If UcDivision.Division.ToString.Trim = "-1" Then
            oDTabla = Nothing
        Else
            oFiltro.Parametro1 = _oContrato.CCMPN
            oFiltro.Parametro2 = UcDivision.Division
            oDTabla = oServicio.Lista_Servicio_X_Compania_Division_X_Rubro(oFiltro)
        End If

        oDr = oDtAux.NewRow
        oDr("NOMRUB") = "TODOS"
        oDr("NRRUBR") = "0"
        oDtAux.Rows.Add(oDr)

        If oDTabla IsNot Nothing Then
            For Each dr As DataRow In oDTabla.Rows
                oDr = oDtAux.NewRow
                oDr("NRRUBR") = dr("NRRUBR")
                oDr("NOMRUB") = dr("NOMRUB")
                oDtAux.Rows.Add(oDr)
            Next
        End If
        oDTabla = oDtAux

        cboRubro.ValueMember = "NRRUBR"
        cboRubro.DisplayMember = "NOMRUB"
        cboRubro.DataSource = oDTabla
        cboRubro.StateCommon.Back.Color1 = Nothing
    End Sub

    Private Sub CargarRubroServicio()
        Dim oFiltro As New SOLMIN_CTZ.Entidades.Filtro
        Dim oDtAux As New DataTable
        Dim oDr As DataRow
        Dim oDTabla As New DataTable
        oDtAux.Columns.Add("NRSRRB", GetType(String))
        oDtAux.Columns.Add("NOMSER", GetType(String))
        Dim oDtSer As New DataTable

        If cboRubro.SelectedValue.ToString.Trim = "0" Then
            oDTabla = Nothing
        Else
            oFiltro.Parametro1 = _oContrato.CCMPN
            oFiltro.Parametro2 = UcDivision.Division
            oFiltro.Parametro3 = cboRubro.SelectedValue
            oDTabla = oServicio.Lista_Servicio_X_Compania_Division_X_Rubro_Servicio(oFiltro)
        End If

        oDr = oDtAux.NewRow
        oDr("NOMSER") = "TODOS"
        oDr("NRSRRB") = "0"
        oDtAux.Rows.Add(oDr)

        If oDTabla IsNot Nothing Then
            For Each dr As DataRow In oDTabla.Rows
                oDr = oDtAux.NewRow
                oDr("NRSRRB") = dr("NRSRRB")
                oDr("NOMSER") = dr("NOMSER")
                oDtAux.Rows.Add(oDr)
            Next
        End If
        
        oDTabla = oDtAux

        cboRubroServicio.ValueMember = "NRSRRB"
        cboRubroServicio.DisplayMember = "NOMSER"
        cboRubroServicio.DataSource = oDTabla
        cboRubroServicio.StateCommon.Back.Color1 = Nothing
    End Sub

    Private Sub UcDivision_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles UcDivision.Seleccionar
        Try
            UcPLanta_Cmb011.CodigoDivision = obeDivision.CDVSN_CodigoDivision
            UcPLanta_Cmb011.CodigoCompania = obeDivision.CCMPN_CodigoCompania
            UcPLanta_Cmb011.Usuario = ConfigurationWizard.UserName
            UcPLanta_Cmb011.pActualizar()

            CargarRubro()
            CargarRubroServicio()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     

    End Sub

     

   

   


     

    Private Sub ExportarExcel()
        'Try
        txtCodTarifa.Text = txtCodTarifa.Text.Trim
        Dim objTarifa As New Tarifa
        Dim oTarifaNeg As New clsTarifa
        Dim odsExportar As DataSet

        objTarifa.NRCTSL = _oContrato.NRCTSL
        objTarifa.CCMPN = _oContrato.CCMPN
        objTarifa.NRRUBR = cboRubro.SelectedValue
        objTarifa.NRSRRB = cboRubroServicio.SelectedValue
        objTarifa.CDVSN = UcDivision.Division
        objTarifa.CPLNDV = UcPLanta_Cmb011.Planta
        objTarifa.SESTRG = cboEstado.SelectedValue
        If txtCodTarifa.Text = "" Then
            objTarifa.NRTFSV = -1
        Else
            objTarifa.NRTFSV = txtCodTarifa.Text
        End If
        objTarifa.NORSRT = Val(txtOS.Text.Trim)
        odsExportar = oTarifaNeg.fdtListarTarifaExportar(objTarifa)

        If odsExportar Is Nothing Then Exit Sub

        Dim dsExport As New DataSet
        Dim dtExport As New DataTable
        Dim oContrato As New SOLMIN_CTZ.Entidades.Contrato
        Dim obrContrato As New clsContrato
        Dim olistCliente As New List(Of SOLMIN_CTZ.Entidades.Contrato)

        oContrato.CCMPN = _oContrato.CCMPN
        oContrato.NRCTSL = _oContrato.NRCTSL
        olistCliente = obrContrato.flisCargarClienteXContrato(oContrato)
         

        dtExport = odsExportar.Tables(0)
        dtExport.TableName = "Tarifario General"

        dsExport.Tables.Add(dtExport.Copy)
        dtExport = odsExportar.Tables(1)

        dtExport.TableName = "Tarifario Tipo Flete"
        dsExport.Tables.Add(dtExport.Copy)

       

        Dim ohstFiltro As New Hashtable
        Dim olstr_Table01 As New List(Of String)
        Dim olstr_Table02 As New List(Of String)

        olstr_Table01.Add("Grupo :\n" & _oContrato.DESCAR.Trim)
        olstr_Table02.Add("Grupo :\n" & _oContrato.DESCAR.Trim)
        Dim intFila As Integer = 0
        For Each oCliente As SOLMIN_CTZ.Entidades.Contrato In olistCliente
            If intFila = 0 Then
                olstr_Table01.Add("Cliente:\n " & oCliente.CCLNT & " - " & oCliente.TCMPCL & " " & oCliente.TMTVBJ)
                intFila = 3
            Else
                olstr_Table01.Add("\n " & oCliente.CCLNT & " - " & oCliente.TCMPCL & " " & oCliente.TMTVBJ)
                intFila += 1
            End If
        Next
        olstr_Table01.Add("Contrato :\n" & _oContrato.NCNTRT)
        olstr_Table02.Add("Contrato :\n" & _oContrato.NCNTRT)
        olstr_Table01.Add("División :\n" & UcDivision.DivisionDescripcion.Trim)
        olstr_Table02.Add("División :\n" & UcDivision.DivisionDescripcion.Trim)
        olstr_Table01.Add("Planta   :\n" & UcPLanta_Cmb011.DescripcionPlanta.Trim)
        olstr_Table02.Add("Planta   :\n" & UcPLanta_Cmb011.DescripcionPlanta.Trim)

        ohstFiltro.Add(0, olstr_Table01)
        ohstFiltro.Add(1, olstr_Table02)

        Ransa.Utilitario.HelpClass.ExportExcel_Formato02(dsExport, "REPORTE DE TARIFAS POR CONTRATO", ohstFiltro)

      

    End Sub


#End Region


    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        Try
            ListarTarifas()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub ListarTarifas()
        dtgTarifaContrato.DataSource = Nothing
        txtCodTarifa.Text = txtCodTarifa.Text.Trim
        Dim objTarifa As New Tarifa
        Dim oTarifaNeg As New clsTarifa
        Dim oDt As DataTable

        objTarifa.NRCTSL = _oContrato.NRCTSL
        objTarifa.CCMPN = _oContrato.CCMPN
        objTarifa.NRRUBR = cboRubro.SelectedValue
        objTarifa.NRSRRB = cboRubroServicio.SelectedValue
        objTarifa.CDVSN = UcDivision.Division
        objTarifa.CPLNDV = UcPLanta_Cmb011.Planta
        objTarifa.SESTRG = cboEstado.SelectedValue
        If txtCodTarifa.Text = "" Then
            objTarifa.NRTFSV = -1
        Else
            objTarifa.NRTFSV = txtCodTarifa.Text
        End If
        objTarifa.NORSRT = Val(txtOS.Text.Trim)
        oDt = oTarifaNeg.Lista_Tarifa_X_Contrato(objTarifa)
        dtgTarifaContrato.AutoGenerateColumns = False
        dtgTarifaContrato.DataSource = oDt

      

    End Sub

    Private Sub Event_KeyPress_NumeroWithDecimal(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If clsComun.SoloNumerosConDecimal(sender, CShort(Asc(e.KeyChar))) = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCodTarifa_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodTarifa.KeyPress
        CType(sender, TextBox).Tag = "10-0"
        Event_KeyPress_NumeroWithDecimal(sender, e)
    End Sub

    

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            If Me.dtgTarifaContrato.CurrentCellAddress.Y = -1 Then Exit Sub
            dtgTarifaContrato.EndEdit()

            Dim cant_sel As Integer = 0
            For Each item As DataGridViewRow In dtgTarifaContrato.Rows
                If item.Cells("chk").Value = True Then
                    cant_sel = cant_sel + 1
                    Exit For
                End If
            Next
            If cant_sel = 0 Then
                MessageBox.Show("No ha seleccionado alguna tarifa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            For Each item As DataGridViewRow In dtgTarifaContrato.Rows
                If ("" & item.Cells("Estado").Value).ToString.Trim = "*" Then
                    MessageBox.Show("No seleccionar tarifas anuladas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit For
                End If
            Next
 
            If MessageBox.Show("Está seguro que desea Anular o Cerrar este registro ?.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim obrTarifa As New clsTarifa
                'Dim Estado As String = Me.dtgTarifaContrato.CurrentRow.Cells("Estado").Value
                Dim objTarifa2 As Tarifa

                For Each item As DataGridViewRow In dtgTarifaContrato.Rows
                    If item.Cells("chk").Value = True Then
                        objTarifa2 = New Tarifa
                        objTarifa2.CCMPN = item.Cells("CCMPN").Value
                        'objTarifa2.NORSRT = dtgTarifaContrato.CurrentRow.Cells("NORSRT").Value
                        objTarifa2.NRCTSL = _oContrato.NRCTSL
                        objTarifa2.NRTFSV = item.Cells("NRTFSV").Value
                        obrTarifa.Anular_Tarifa_X_Servicio(objTarifa2)
                    End If
                Next
                
                ListarTarifas()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

 
    Private Sub cboRubro_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboRubro.SelectionChangeCommitted
        Try
            CargarRubroServicio()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cboEstado_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEstado.SelectionChangeCommitted
        Try
            ValidarEstado()
            ListarTarifas()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub ValidarEstado()
        Dim estado As String = cboEstado.SelectedValue
        Select Case _TipoEnumForm
            Case EnumTIPO_FORM.CONSULTA
                btnAgregar.Visible = False
                btnModificar.Visible = False
                btnEliminar.Visible = False
                btnExportarExcel.Visible = True
                btnBuscar.Visible = True
                tsbSalir.Visible = True
 

            Case EnumTIPO_FORM.EDICION

                Select Case estado
                    Case "T"
                        btnAgregar.Visible = True
                        btnModificar.Visible = True
                        btnEliminar.Visible = True
                        btnExportarExcel.Visible = True
                        btnBuscar.Visible = True
                        tsbSalir.Visible = True
                        btnActivar.Visible = True
                        btnCopiar.Visible = True


                    Case "A"
                        btnAgregar.Visible = True
                        btnModificar.Visible = True
                        btnEliminar.Visible = True
                        btnExportarExcel.Visible = True
                        btnBuscar.Visible = True
                        tsbSalir.Visible = True
                        btnActivar.Visible = False
                        btnModificar.Text = "Visualizar"
                        btnCopiar.Visible = True

                    Case "*"
                        btnAgregar.Visible = False
                        btnModificar.Visible = True
                        btnEliminar.Visible = False
                        btnExportarExcel.Visible = True
                        btnBuscar.Visible = True
                        tsbSalir.Visible = True
                        btnActivar.Visible = False
                        btnModificar.Text = "Visualizar"
                        btnCopiar.Visible = False


                    Case "C"
                        btnAgregar.Visible = False
                        btnModificar.Visible = True
                        btnEliminar.Visible = False
                        btnExportarExcel.Visible = True
                        btnBuscar.Visible = True
                        tsbSalir.Visible = True
                        btnActivar.Visible = False
                        btnModificar.Text = "Visualizar"
                        btnCopiar.Visible = False

                    Case "P"
                        btnAgregar.Visible = True
                        btnModificar.Visible = True
                        btnEliminar.Visible = True
                        btnExportarExcel.Visible = True
                        btnBuscar.Visible = True
                        tsbSalir.Visible = True
                        btnActivar.Visible = True
                        btnModificar.Text = "Modificar"
                        btnCopiar.Visible = False



                    Case "B" 'Similar al estado "A"
                        btnAgregar.Visible = False
                        btnModificar.Visible = True
                        btnEliminar.Visible = False
                        btnExportarExcel.Visible = True
                        btnBuscar.Visible = True
                        tsbSalir.Visible = True                    
                        btnActivar.Visible = False
                        btnModificar.Text = "Visualizar"
                        btnCopiar.Visible = False


                End Select
        End Select
    End Sub


    Private Sub dtgTarifaContrato_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgTarifaContrato.SelectionChanged
        Try

            If Me.dtgTarifaContrato.CurrentCellAddress.Y <> -1 Then

                If Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("ESTADO") = "P" Then
                    btnModificar.Text = "Modificar"
                    btnActivar.Visible = True
                Else
                    btnModificar.Text = "Visualizar"
                    btnActivar.Visible = False
                End If
                


            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

 

  

    
    Private Sub dtgTarifaContrato_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgTarifaContrato.CellDoubleClick
        If Me.dtgTarifaContrato.CurrentCellAddress.Y = -1 Then Exit Sub
        Try
            If dtgTarifaContrato.Columns(e.ColumnIndex).Name = "AUDI" Then
                Dim ofrmAuditoria As New frmAuditoria
                With ofrmAuditoria

                    .txtUsuarioCreador.Text = CType(dtgTarifaContrato.CurrentRow.DataBoundItem, DataRowView).Row.Item("CUSCRT")
                    .txtFechaCreacion.Text = Ransa.Utilitario.HelpClass.CNumero8Digitos_a_Fecha(CType(dtgTarifaContrato.CurrentRow.DataBoundItem, DataRowView).Row.Item("FCHCRT"))
                    .txtHoraCreacion.Text = Ransa.Utilitario.HelpClass.HoraNum_a_Hora(CType(dtgTarifaContrato.CurrentRow.DataBoundItem, DataRowView).Row.Item("HRACRT"))

                    .txtFechaActualizado.Text = Ransa.Utilitario.HelpClass.CNumero8Digitos_a_Fecha(CType(dtgTarifaContrato.CurrentRow.DataBoundItem, DataRowView).Row.Item("FULTAC"))
                    .txtUsuarioActualizado.Text = CType(dtgTarifaContrato.CurrentRow.DataBoundItem, DataRowView).Row.Item("CULUSA")
                    .txtHoraActualizado.Text = Ransa.Utilitario.HelpClass.HoraNum_a_Hora(CType(dtgTarifaContrato.CurrentRow.DataBoundItem, DataRowView).Row.Item("HULTAC"))

                End With


                ofrmAuditoria.ShowDialog()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private HasEnvioEmail As New Hashtable



   


    Private Sub btnActivar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActivar.Click


        Try
            Dim objTarifa As New Tarifa
            Dim obrTarifa As New clsTarifa
            Dim oDs As DataSet
            Dim oDtValidacionMrg As DataTable
            Dim oDtListadoServicio As DataTable

            Dim ValidarMargen As Boolean = False

            If Me.dtgTarifaContrato.CurrentCellAddress.Y < 0 Then
                Exit Sub
            End If
            Dim es_tarifa_enviado_aprobacion As Boolean = False


            If oContrato.SESTRG = "C" Or oContrato.SESTRG = "R" Then
                MessageBox.Show("No puede activar tarifas a un contrato anulado/vencido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If


            If Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("ESTADO") = "P" Then

                '-----La nueva Validacion---solo pra transportes...division "T" -------------------
                Dim OS As Decimal = dtgTarifaContrato.CurrentRow.Cells("NORSRT").Value
                If OS > 0 Then
                    Dim msgError As String = ""
                    '==================================================================
                    'Listamos la validacion margen orden de servicio 
                    With objTarifa
                        .CCMPN = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("CCMPN")
                        .NRCTSL = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("NRCTSL")
                        .NRTFSV = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("NRTFSV")
                    End With
                    oDs = obrTarifa.Lista_Validar_Margen_Tarifa(objTarifa, msgError)
                    oDtValidacionMrg = oDs.Tables(0)
                    oDtListadoServicio = oDs.Tables(1)

                    If msgError.Length > 0 Then
                        MessageBox.Show(msgError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If

                    If oDtValidacionMrg.Rows.Count > 0 Then
                        Dim msgAlerta As String = ""
                        'Armamos el mensaje
                        For Each dr As DataRow In oDtValidacionMrg.Rows
                            If dr("STATUS").ToString.Trim = "A" Then
                                msgAlerta = msgAlerta & dr("OBSRESULT").ToString & vbNewLine
                            End If

                        Next
                        'Pregunta si Envia correo para aprobar
                        If msgAlerta.Length > 0 Then
                            If MessageBox.Show(msgAlerta & Chr(13) & "Desea enviar para aprobación?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                                Exit Sub
                            End If
                        End If

                        With objTarifa
                            .CCMPN = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("CCMPN")
                            .NRCTSL = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("NRCTSL")
                            .NRTFSV = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("NRTFSV")
                            .MRGPOR = oDtValidacionMrg.Rows.Item(0)("MRGPOR")
                            .NLBFLT = oDtValidacionMrg.Rows.Item(0)("NLBFLT")
                        End With
                        es_tarifa_enviado_aprobacion = True
                        obrTarifa.Enviar_Aprobar_Tarifa(objTarifa)
                        MessageBox.Show("Tarifa enviada para aprobación.", "Aviso", MessageBoxButtons.OK)
                        'Enviar correo
                        Dim dtMargen As New DataTable
                        Dim msgVerificacion As String = ""
                        dtMargen = oDtListadoServicio
                        HasEnvioEmail = New Hashtable
                        HasEnvioEmail("NRTFSV") = dtMargen.Rows.Item(0)("TARIFA")   'Ref Nro Tarifa
                        HasEnvioEmail("SERVICIO_D") = dtgTarifaContrato.CurrentRow.Cells("SERVICIO_D").Value
                        HasEnvioEmail("TCMPCL") = dtMargen.Rows.Item(0)("CLIENTE")   'Cliente
                        HasEnvioEmail("NORSRT") = dtMargen.Rows.Item(0)("ORDEN_SERVICIO")   'Orden Servicio
                        HasEnvioEmail("APROBSUG") = oDtValidacionMrg.Rows.Item(0)("APROBSUG") 'Aprobador Sugerido
                        HasEnvioEmail("MRGPOR") = oDtValidacionMrg.Rows.Item(0)("MRGPOR") '%Aprobador
                        HasEnvioEmail("DT_SERV") = dtMargen
                        oHebraEnvioEmailReq = New Thread(AddressOf Enviar_Aprobacion)
                        oHebraEnvioEmailReq.Start()
                        ListarTarifas()

                    End If
                End If

                If es_tarifa_enviado_aprobacion = False Then
                    Dim obeTarifa As New Tarifa
                    With obeTarifa
                        .CCMPN = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("CCMPN")
                        .STPTRA = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("STPTRA")
                        .NRCTSL = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("NRCTSL")
                        .NRTFSV = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("NRTFSV")
                    End With
                    obrTarifa.fintActivarTarifa(obeTarifa)
                    MessageBox.Show("Se activó la tarifa : " & Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("NRTFSV"), "Aviso", MessageBoxButtons.OK)
                    ListarTarifas()
                End If
              
            End If


        Catch ex As Exception

            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Enviar_Aprobacion()
        Try
            Control.CheckForIllegalCrossThreadCalls = False
            Dim oEntidad As New OrdenServicioTransporte
            Dim DT_SERV As New DataTable
            DT_SERV = HasEnvioEmail("DT_SERV")

            Dim Envio As New EnvioEmailAprobacionMargen_BLL
            Envio.CULUSA = ConfigurationWizard.UserName
            Envio.MailAccount = System.Configuration.ConfigurationManager.AppSettings("MailFrom")
            Envio.Mailpassword = System.Configuration.ConfigurationManager.AppSettings("MailFromClave")
            Envio.MailAccount_Gmail = System.Configuration.ConfigurationManager.AppSettings("MailCO")
            Envio.MailPassword_Gmail = System.Configuration.ConfigurationManager.AppSettings("MailCOClave")
            Envio.Mailto_Error = System.Configuration.ConfigurationManager.AppSettings("emailto_error")

            If Envio.Enviar_Email_Requerimiento_Servicio_Notificacion(HasEnvioEmail, DT_SERV) = 1 Then
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    

    Private Sub btnCopiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopiar.Click
        Try


          

            Dim lista As String = ""
            Dim CantSel As Integer = 0
            Dim seleccion_no_activos As Integer = 0
            For i As Integer = 0 To Me.dtgTarifaContrato.RowCount - 1
                If dtgTarifaContrato.Rows(i).Cells("Chk").Value Then
                    lista = lista + dtgTarifaContrato.Rows(i).Cells("NRTFSV").Value.ToString.Trim + ","
                    CantSel = CantSel + 1

                    If dtgTarifaContrato.Rows(i).Cells("Estado").Value <> "A" Then
                        seleccion_no_activos = seleccion_no_activos + 1
                    End If
                End If
            Next

            If seleccion_no_activos > 0 Then
                MessageBox.Show("Las tarifas a copiar deben estar activos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If CantSel = 0 Then
                MessageBox.Show("No ha seleccionado la tarifa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim objTarifa As New Tarifa
            Dim oTarifaNeg As New clsTarifa

            objTarifa.NRCTSL = _oContrato.NRCTSL
            objTarifa.sNRTFSV = lista.Substring(0, lista.Length - 1)
            objTarifa.CCMPN = _oContrato.CCMPN
            objTarifa.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
            objTarifa.CUSCRT = StringExtension.SubString(ConfigurationWizard.UserName, 0, 10)

            If oTarifaNeg.CopiarTarifa(objTarifa) = 1 Then
                MessageBox.Show("Se realizó la operación satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cboEstado.SelectedValue = "P"
                'dtgTarifaContrato.Columns("chk").Visible = False
                ListarTarifas()
                'Else
                '    MessageBox.Show("Error al realizar el proceso de copia, Notifíquese con departamento de sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub dtgTarifaContrato_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgTarifaContrato.CellContentClick
        Me.dtgTarifaContrato.EndEdit()

    End Sub

    
    Private Function VerificarServiciosMargen_origen(ByVal MargenNegocio As Decimal) As DataTable
        'TRAE SERVICIOS
        Dim objServicioMercaderia As New SOLMIN_CTZ.NEGOCIO.clsFleteMargen

        Dim objEntidad As New DetalleTarifaTipoFlete
        Dim dtServicio As New DataTable
        'Dim MargenNegocio As Decimal
        Dim CRGVTA As String = ""

        Dim CODTARIFA As Integer = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("NRTFSV")
      
        With objEntidad
            .CCMPN = dtgTarifaContrato.CurrentRow.Cells("CCMPN").Value
            .NRCTSL = _oContrato.NRCTSL
            .NRTFSV = CODTARIFA
        End With
        dtServicio = objServicioMercaderia.Listar_Detalle_Tarifa_Tipo_Flete(objEntidad, MargenNegocio)
        Return dtServicio

    End Function

    ' Fin  Validando............................................................................

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs)
        Try
            Dim objTarifa As New Tarifa
            objTarifa.NRCTSL = _oContrato.NRCTSL
            objTarifa.CCMPN = _oContrato.CCMPN

            Dim frm As New frmGenTarifaAdmin(Nothing, objTarifa, _oContrato, Nothing, frmGenTarifaAdmin.EnumTipo.Nuevo)
            frm.pCodigoCompania = Me.pCodigoCompania

            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then

                cboEstado.SelectedValue = "P"
                ListarTarifas()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnOrdenServicio_Click(sender As Object, e As EventArgs)
        Try
            Dim objTarifa As New Tarifa
            objTarifa.NRCTSL = _oContrato.NRCTSL
            objTarifa.CCMPN = _oContrato.CCMPN

            Dim frm As New frmGenTarifaOS(Nothing, objTarifa, _oContrato, Nothing, frmGenTarifaOS.EnumTipo.Nuevo)
            frm.pCodigoCompania = Me.pCodigoCompania

            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                'CargarTarifas()
                cboEstado.SelectedValue = "P"
                ListarTarifas()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

     

    Private Sub btnAdjuntar_Click(sender As Object, e As EventArgs) Handles btnAdjuntar.Click
        Try
            If dtgTarifaContrato.CurrentRow Is Nothing Then
                Exit Sub
            End If
        
            Dim idContrato As Decimal = Me.dtgTarifaContrato.CurrentRow.DataBoundItem.Item("NRCTSL")
            Dim idTarifa As Decimal = dtgTarifaContrato.CurrentRow.DataBoundItem.Item("NRTFSV")
            Dim CodCompania As String = dtgTarifaContrato.CurrentRow.DataBoundItem.Item("CCMPN")

           

            Dim ofrmCargaAdjuntos As New StorageFileManager.frmCargaAdjuntos
            ofrmCargaAdjuntos.pCarpetaBucketDestino = System.Configuration.ConfigurationManager.AppSettings("bucketDestino").ToString
            ofrmCargaAdjuntos.pCodCompania = dtgTarifaContrato.CurrentRow.DataBoundItem.Item("CCMPN")
            'ofrmCargaAdjuntos.pCodListaMotivo = "RZSC03"
            'ofrmCargaAdjuntos.pCodRefMotivoDefault = "01"
            ofrmCargaAdjuntos.pAsignarCargaMotivo("RZSC03", "02")
            ofrmCargaAdjuntos.pNroImagen = dtgTarifaContrato.CurrentRow.Cells("NMRGIM").Value
            ofrmCargaAdjuntos.pNroImagenGetUltimo = True
            ofrmCargaAdjuntos.pTablaRelacions = StorageFileManager.frmCargaAdjuntos.Tabla_Relacion.RZSC03

            ofrmCargaAdjuntos.pAsignar_ParametroTablaRelacion_RZSC03(CodCompania, idContrato, idTarifa)

            ofrmCargaAdjuntos.ShowDialog()
            If ofrmCargaAdjuntos.pDialog = True Then
                dtgTarifaContrato.CurrentRow.Cells("NMRGIM").Value = ofrmCargaAdjuntos.pNroImagen
                If ofrmCargaAdjuntos.pNroImagen > 0 Then
                    dtgTarifaContrato.CurrentRow.Cells("NMRGIM_IMG").Value = "X"
                Else
                    dtgTarifaContrato.CurrentRow.Cells("NMRGIM_IMG").Value = ""
                End If

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
