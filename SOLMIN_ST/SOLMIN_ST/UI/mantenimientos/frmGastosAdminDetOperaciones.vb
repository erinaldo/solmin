Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO.operaciones
Public Class frmGastosAdminDetOperaciones

    Dim objPlaneamiento As New Reportes_BLL
    Dim oPlaneamientoBE_GA As New Planeamiento()
    Private _obj_Entidad As New Detalle_Solicitud_Transporte
    Dim odsPlaneamiento As New DataSet()
    Private gEnum_Mantenimiento As MANTENIMIENTO
    Private FilaActual As Int32
    Private CCMPN_Compania As String
    Private FlagEliminar As Boolean = False
    Private obs As New BindingSource

    Private Sub frmGastosAdminDetOperaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Alinear_Columnas_Grilla()
            gwdDatosPlaneamiento.AutoGenerateColumns = False
            txtOS.Enabled = False
            txtNumOperacion.Enabled = False
            txtOperacion.Enabled = False
            HabilitarDesabilitarCombosMantenimiento(False)
            btnnNuevo.Enabled = True
            btnnGuardar.Enabled = False
            btnnEliminar.Enabled = False
            btnnCancelar.Enabled = False
            CargarTransportista(oPlaneamientoBE_GA.CCMPN, "")
            If (gwdDatosPlaneamiento.Rows.Count > 0) Then             
                Me.gwdDatosPlaneamiento.Rows(0).Selected = False
            End If
            Verifica_Si_PuedeAdicionar_Items()
        Catch ex As Exception

        End Try
      
       
    End Sub
    Private Sub Alinear_Columnas_Grilla()
        For lint_contador As Integer = 0 To Me.gwdDatosPlaneamiento.ColumnCount - 1
            Me.gwdDatosPlaneamiento.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub
    Private Sub ExtraerDatosAdicionalesDePlaneamiento()

         For Each dr As DataRow In odsPlaneamiento.Tables(0).Rows
            If (dr("NSBCRP").ToString().Trim() = "0") Then
                Continue For
            End If
            oPlaneamientoBE_GA.NCRRPL = IIf(String.IsNullOrEmpty(dr("NCRRPL").ToString().Trim()), "", dr("NCRRPL").ToString().Trim())
            oPlaneamientoBE_GA.NORINS = IIf(String.IsNullOrEmpty(dr("NORINS").ToString().Trim()), "", dr("NORINS").ToString().Trim())
            oPlaneamientoBE_GA.CLCLOR = IIf(String.IsNullOrEmpty(dr("CLCLOR").ToString().Trim()), "", dr("CLCLOR").ToString().Trim())
            oPlaneamientoBE_GA.CLCLDS = IIf(String.IsNullOrEmpty(dr("CLCLDS").ToString().Trim()), "", dr("CLCLDS").ToString().Trim())
            oPlaneamientoBE_GA.NCTZCN = IIf(String.IsNullOrEmpty(dr("NCTZCN").ToString().Trim()), "", dr("NCTZCN").ToString().Trim())
            oPlaneamientoBE_GA.NCRRCT = IIf(String.IsNullOrEmpty(dr("NCRRCT").ToString().Trim()), "", dr("NCRRCT").ToString().Trim())
            oPlaneamientoBE_GA.NCRRSR = IIf(String.IsNullOrEmpty(dr("NCRRSR").ToString().Trim()), "", dr("NCRRSR").ToString().Trim())
            oPlaneamientoBE_GA.TCNFVH = IIf(String.IsNullOrEmpty(dr("TCNFVH").ToString().Trim()), "", dr("TCNFVH").ToString().Trim())
            oPlaneamientoBE_GA.CRCRSO_S = IIf(String.IsNullOrEmpty(dr("SRCRSO").ToString().Trim()), "", dr("SRCRSO").ToString().Trim())
            oPlaneamientoBE_GA.CUNDMD = IIf(String.IsNullOrEmpty(dr("CUNDMD").ToString().Trim()), "", dr("CUNDMD").ToString().Trim())
            oPlaneamientoBE_GA.CMNTRN = IIf(String.IsNullOrEmpty(dr("CMNTRN").ToString().Trim()), "", dr("CMNTRN").ToString().Trim())


        Next
    End Sub
    Private Sub MostrarListadoPlaneamiento()
        odsPlaneamiento = objPlaneamiento.Lista_Planeamiento_X_Operacion(oPlaneamientoBE_GA)
        obs.DataSource = odsPlaneamiento.Tables(0)
        If (odsPlaneamiento IsNot Nothing) Then
            If (odsPlaneamiento.Tables(0).Rows.Count > 0) Then
                oPlaneamientoBE_GA.MAXSUBCORRELATIVO = Convert.ToInt32(odsPlaneamiento.Tables(0).Rows(0).Item("MAXSUBCORRELATIVO"))
                gwdDatosPlaneamiento.DataSource = obs
            Else
                MessageBox.Show("No tiene Ordenes Internas Asignadas ")
                Me.Close()
            End If
        End If
    End Sub
    Public Sub ShowForm(ByVal oPlaneamientoBE As Planeamiento, ByVal strTRFMRC As String, ByVal owner As IWin32Window)

        oPlaneamientoBE_GA = oPlaneamientoBE
        gwdDatosPlaneamiento.AutoGenerateColumns = False
        Try

            txtNumOperacion.Text = oPlaneamientoBE.NOPRCN.ToString()
            txtOS.Text = oPlaneamientoBE.NORSRT.ToString()
            txtOperacion.Text = strTRFMRC
            CCMPN_Compania = oPlaneamientoBE.CCMPN.ToString()
            MostrarListadoPlaneamiento()
            Me.ShowDialog(owner)


        Catch : End Try

    End Sub

    Private Sub gwdDatosPlaneamiento_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatosPlaneamiento.CellClick

        Try
            If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Or Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
                If Me.gwdDatosPlaneamiento.Rows.Count > 0 Then
                    Me.gwdDatosPlaneamiento.CurrentRow.Selected = False
                End If
                If (Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR) Then
                    Me.gwdDatosPlaneamiento.Rows(FilaActual).Selected = True
                End If

                MsgBox("Debe guardar el registro actual o cancelarlo.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Dim indice As Int32
            txtCorrelativo.Text = String.Empty
            txtSubCorrelativo.Text = String.Empty
            txtPlaneamiento.Text = String.Empty
            indice = Me.gwdDatosPlaneamiento.CurrentCellAddress.Y
            FilaActual = Me.gwdDatosPlaneamiento.CurrentCellAddress.Y

            Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR
            btnnGuardar.Text = "Modificar"
            btnnGuardar.Enabled = True
            btnnEliminar.Enabled = True
            btnnCancelar.Enabled = False
            btnnNuevo.Enabled = True

            CargaDatosPlaneamiento(indice)




        Catch ex As Exception

        End Try

    
    End Sub
   

    Private Sub CargaDatosPlaneamiento(ByVal lint_indicePlaneamiento As Int32)
        Dim strNRUCTR As String
        Dim strNBRCRT As String
        Dim strNPLCTR As String

        Try
            Dim objReporte As New Reportes_BLL
            strNRUCTR = IIf((String.IsNullOrEmpty(Me.gwdDatosPlaneamiento.Item("NRUCTR", lint_indicePlaneamiento).Value.ToString()) = True), "", Me.gwdDatosPlaneamiento.Item("NRUCTR", lint_indicePlaneamiento).Value.ToString())
            strNBRCRT = IIf(String.IsNullOrEmpty(Me.gwdDatosPlaneamiento.Item("CBRCNT", lint_indicePlaneamiento).Value.ToString()) = True, "", Me.gwdDatosPlaneamiento.Item("CBRCNT", lint_indicePlaneamiento).Value.ToString())
            strNPLCTR = IIf(String.IsNullOrEmpty(Me.gwdDatosPlaneamiento.Item("NPLCTR", lint_indicePlaneamiento).Value.ToString()) = True, "", Me.gwdDatosPlaneamiento.Item("NPLCTR", lint_indicePlaneamiento).Value.ToString())
            If Me.gwdDatosPlaneamiento.CurrentRow.Index < 0 OrElse lint_indicePlaneamiento < 0 Then
                Exit Sub
            End If

            txtOrdenServicio.Text = oPlaneamientoBE_GA.NORSRT.ToString()
            txtCorrelativo.Text = Me.gwdDatosPlaneamiento.Item("NCRRPL", lint_indicePlaneamiento).Value.ToString().Trim()
            txtSubCorrelativo.Text = Me.gwdDatosPlaneamiento.Item("NSBCRP", lint_indicePlaneamiento).Value.ToString().Trim()
            txtPlaneamiento.Text = oPlaneamientoBE_GA.NPLNMT.ToString()
            txtOrdenInterna.Text = Me.gwdDatosPlaneamiento.Item("NORINS", lint_indicePlaneamiento).Value.ToString().Trim()
            txtObservacion.Text = Me.gwdDatosPlaneamiento.Item("TOBSRC", lint_indicePlaneamiento).Value.ToString().Trim()
            Me.gwdDatosPlaneamiento.Item("NPLCTR", lint_indicePlaneamiento).Value.ToString().Trim()
            LimpiarCombosMantenimiento()
            If (Me.gwdDatosPlaneamiento.Item("NSBCRP", lint_indicePlaneamiento).Value.ToString().Trim() <> "0") Then
                CargarTransportista(oPlaneamientoBE_GA.CCMPN, strNRUCTR)
                CargarTracto(oPlaneamientoBE_GA.CCMPN, oPlaneamientoBE_GA.CDVSN, oPlaneamientoBE_GA.CPLNDV, strNRUCTR, strNPLCTR)
                CargaConductor(strNRUCTR, strNBRCRT)
            End If

        Catch ex As Exception
            HelpClass.ErrorMsgBox()
        End Try

    End Sub
    Private Sub LimpiarCombosMantenimiento()
        cboTracto.pClear()
        cboTransportista.pClear()
        Me.ctbConductor.Limpiar()
    End Sub
    Private Sub CargarTransportista(ByVal strCCMPN As String, ByVal strNRUCTR As String)

        Dim obeTransportista As New Ransa.TypeDef.Transportista.TD_TransportistaPK
        obeTransportista.pCCMPN_Compania = strCCMPN
        obeTransportista.pNRUCTR_RucTransportista = strNRUCTR
        Me.cboTransportista.pCargar(obeTransportista)

    End Sub

   

    Private Sub HabilitarDesabilitarCombosMantenimiento(ByVal habilitar As Boolean)
        cboTracto.Enabled = habilitar
        cboTransportista.Enabled = habilitar
        ctbConductor.Enabled = habilitar
        txtObservacion.Enabled = habilitar
    End Sub

  

    Private Function CalcularSiguienteSubCorrelativo() As Double
        Dim sig_subcorrelativo As Double = 0
        If (gwdDatosPlaneamiento.Rows.Count > 0) Then
            sig_subcorrelativo = Convert.ToDouble(Me.gwdDatosPlaneamiento.Item("NSBCRP", 0).Value)
            For index As Integer = 0 To gwdDatosPlaneamiento.Rows.Count - 1
                If (Convert.ToDouble(Me.gwdDatosPlaneamiento.Item("NSBCRP", index).Value) > sig_subcorrelativo) Then
                    sig_subcorrelativo = Convert.ToDouble(Me.gwdDatosPlaneamiento.Item("NSBCRP", index).Value)
                End If
            Next
        End If
        sig_subcorrelativo += 1
        Return sig_subcorrelativo
    End Function

 
    Private Function Validar_Planeamiento() As Boolean
        Dim lstr_validacion As String = ""
        Dim lbool_existe_error As Boolean = False

        If Me.cboTransportista.pRucTransportista.Trim().Equals("") Then
            lstr_validacion += "* TRANSPORTISTA" & Chr(13)
        End If


        If Me.cboTracto.pNroPlacaUnidad.Trim.Equals("") Then
            lstr_validacion += "* TRACTO" & Chr(13)
        End If

        If Me.ctbConductor.Codigo = "" Then
            lstr_validacion += "* CONDUCTOR" & Chr(13)
        End If


        If lstr_validacion <> "" Then
            HelpClass.MsgBox("FALTA ASIGNAR :" & Chr(13) & lstr_validacion)
            lbool_existe_error = True
        End If
        Return lbool_existe_error
    End Function

    Private Sub btnnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnNuevo.Click
        Try
            gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
            btnnNuevo.Enabled = False
            btnnGuardar.Text = "Guardar"
            btnnGuardar.Enabled = True
            btnnCancelar.Enabled = True
            btnnEliminar.Enabled = False
            ExtraerDatosAdicionalesDePlaneamiento()
            HabilitarDesabilitarCombosMantenimiento(True)
            LimpiarCombosMantenimiento()
            txtOrdenServicio.Text = oPlaneamientoBE_GA.NORSRT.ToString()
            txtSubCorrelativo.Text = (oPlaneamientoBE_GA.MAXSUBCORRELATIVO + 1).ToString() ' CalcularSiguienteSubCorrelativo().ToString()
            txtCorrelativo.Text = oPlaneamientoBE_GA.NCRRPL.ToString()
            txtNumOperacion.Text = oPlaneamientoBE_GA.NOPRCN.ToString()
            txtOrdenInterna.Text = oPlaneamientoBE_GA.NORINS.ToString()
            txtPlaneamiento.Text = oPlaneamientoBE_GA.NPLNMT.ToString()
            txtObservacion.Text = ""
            Me.gwdDatosPlaneamiento.CurrentRow.Selected = False
        Catch : End Try

    End Sub
    Private Sub Verifica_Si_PuedeAdicionar_Items()
        If (gwdDatosPlaneamiento.Rows.Count = 0) Then
            ToolStrip1.Enabled = False
        Else
            ToolStrip1.Enabled = True
        End If
    End Sub
    Private Sub AccionCancelar()
     
       
          If gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then

            HabilitarDesabilitarCombosMantenimiento(False)
            LimpiarCombosMantenimiento()
            If Me.gwdDatosPlaneamiento.Rows.Count > 0 Then
                Me.gwdDatosPlaneamiento.CurrentRow.Selected = False
            End If
            LimpiarTextos()

            btnnNuevo.Enabled = True
            btnnCancelar.Enabled = False
            btnnEliminar.Enabled = False
            btnnGuardar.Enabled = False
            gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL

        ElseIf gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then

            HabilitarDesabilitarCombosMantenimiento(False)
            If Me.gwdDatosPlaneamiento.Rows.Count > 0 Then
                Me.gwdDatosPlaneamiento.CurrentRow.Selected = False
            End If
            CargaDatosPlaneamiento(FilaActual)
            Me.gwdDatosPlaneamiento.Rows(FilaActual).Selected = True

            Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR
            btnnGuardar.Text = "Modificar"
            btnnGuardar.Enabled = True
            btnnEliminar.Enabled = True
            btnnCancelar.Enabled = False
            btnnNuevo.Enabled = True



        ElseIf gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then
            LimpiarCombosMantenimiento()

            btnnNuevo.Enabled = True
            btnnCancelar.Enabled = False
            btnnEliminar.Enabled = False
            btnnGuardar.Visible = True

            gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL

        ElseIf gEnum_Mantenimiento = MANTENIMIENTO.ELIMINAR Then

            HabilitarDesabilitarCombosMantenimiento(False)
            LimpiarCombosMantenimiento()
            If Me.gwdDatosPlaneamiento.Rows.Count > 0 Then
                Me.gwdDatosPlaneamiento.CurrentRow.Selected = False
            End If
            LimpiarTextos()

            btnnNuevo.Enabled = True
            btnnCancelar.Enabled = False
            btnnEliminar.Enabled = False
            btnnGuardar.Visible = True
            gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL

        End If


        ToolStripSeparator1.Visible = True
        ToolStripSeparator2.Visible = True

        'gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
       
        'btnnNuevo.Enabled = True
        'btnnCancelar.Enabled = False
        'btnnEliminar.Enabled = False
        'btnGuardar.Visible = True

      
    End Sub


    Private Sub btnnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnGuardar.Click

        Dim intResultado As Int32 = 0
        Dim oPlaneamiento As New Planeamiento()

        Dim oPlaneamientoBLL As New Planeamiento_BLL()

        Try
            If (gEnum_Mantenimiento <> MANTENIMIENTO.MODIFICAR) Then
                oPlaneamiento.NCRRPL = oPlaneamientoBE_GA.NCRRPL
                oPlaneamiento.NSBCRP = oPlaneamientoBE_GA.NSBCRP
                oPlaneamiento.NPLCTR = cboTracto.pNroPlacaUnidad
                oPlaneamiento.NPLNMT = oPlaneamientoBE_GA.NPLNMT
                oPlaneamiento.NCRRPL = Convert.ToDouble(txtCorrelativo.Text)
                oPlaneamiento.NSBCRP = Convert.ToInt32(txtSubCorrelativo.Text)
                oPlaneamiento.TOBSRC_S = txtObservacion.Text
                oPlaneamiento.SESTRC_S = ""
                oPlaneamiento.NRUCTR = cboTransportista.pRucTransportista
                oPlaneamiento.CBRCNT = ctbConductor.Codigo
                oPlaneamiento.CCMPN = oPlaneamientoBE_GA.CCMPN
                oPlaneamiento.CDVSN = oPlaneamientoBE_GA.CDVSN
                oPlaneamiento.CPLNDV = oPlaneamientoBE_GA.CPLNDV
                oPlaneamiento.CLCLOR = oPlaneamientoBE_GA.CLCLOR
                oPlaneamiento.CLCLDS = oPlaneamientoBE_GA.CLCLDS
                oPlaneamiento.NCTZCN = oPlaneamientoBE_GA.NCTZCN
                oPlaneamiento.NCRRCT = oPlaneamientoBE_GA.NCRRCT
                oPlaneamiento.NCRRSR = oPlaneamientoBE_GA.NCRRSR
                oPlaneamiento.NORINS = oPlaneamientoBE_GA.NORINS
                oPlaneamiento.CMNTRN = oPlaneamientoBE_GA.CMNTRN
                oPlaneamiento.TCNFVH = oPlaneamientoBE_GA.TCNFVH
                oPlaneamiento.CUSCRT = MainModule.USUARIO
                oPlaneamiento.FCHCRT = HelpClass.TodayNumeric
                oPlaneamiento.HRACRT = HelpClass.NowNumeric
                oPlaneamiento.CULUSA = MainModule.USUARIO
                oPlaneamiento.FULTAC = HelpClass.TodayNumeric
                oPlaneamiento.HULTAC = HelpClass.NowNumeric
                oPlaneamiento.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
                oPlaneamiento.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                oPlaneamiento.CRCRSO_S = oPlaneamientoBE_GA.CRCRSO_S
            End If
         
            If gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
                If (Validar_Planeamiento() = False) Then
                    intResultado = oPlaneamientoBLL.Registrar_Planeamiento_Item(oPlaneamiento)
                    If (intResultado = 0) Then
                        HelpClass.ErrorMsgBox()
                    ElseIf (intResultado = 2) Then
                        MessageBox.Show("Ingrese otro registro.El registro ya existe.")
                    Else
                        btnnNuevo.Enabled = True
                        btnnCancelar.Enabled = False
                        btnnEliminar.Enabled = True
                        btnnGuardar.Enabled = True
                        btnnGuardar.Text = "Modificar"
                        gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
                        HabilitarDesabilitarCombosMantenimiento(False)
                        MostrarListadoPlaneamiento()
                        MessageBox.Show("Se registró correctamente")
                        If (gwdDatosPlaneamiento.Rows.Count > 0) Then
                            Me.gwdDatosPlaneamiento.Rows(gwdDatosPlaneamiento.Rows.Count - 1).Selected = True
                        End If

                    End If
            End If

            ElseIf gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            If (Validar_Planeamiento() = False) Then
                intResultado = oPlaneamientoBLL.Modificar_Planeamiento_Item(oPlaneamiento)
                If (intResultado = 0) Then
                        HelpClass.ErrorMsgBox()
                    ElseIf (intResultado = 2) Then
                        MessageBox.Show("Ingrese otro registro.El registro ya existe.")
                    Else
                        btnnNuevo.Enabled = True
                        btnnCancelar.Enabled = False
                        btnnEliminar.Enabled = True
                        btnnGuardar.Enabled = True
                        btnnGuardar.Text = "Modificar"
                        gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR
                        HabilitarDesabilitarCombosMantenimiento(False)
                        MostrarListadoPlaneamiento()
                        MessageBox.Show("Se actualizó correctamente")
                End If
            End If

            ElseIf gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then
            btnnGuardar.Text = "Guardar"
            btnnNuevo.Enabled = False
            btnnCancelar.Enabled = True
            btnnEliminar.Enabled = False
            Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
            HabilitarDesabilitarCombosMantenimiento(True)

            End If


        Catch : End Try

    End Sub
    Private Sub CargarTracto(ByVal strCCMPN As String, ByVal strSDVSN As String, ByVal strCPLNDV As Int32, ByVal strRucTransportista As String, ByVal strNroPlacaUnidad As String)
        Try
            Dim obeTracto As New Ransa.TypeDef.Transportista.TD_TractoTransportistaPK
            obeTracto.pCCMPN_Compania = strCCMPN
            obeTracto.pCDVSN_Division = strSDVSN
            obeTracto.pCPLNDV_Planta = strCPLNDV
            obeTracto.pNRUCTR_RucTransportista = strRucTransportista
            obeTracto.pNPLCUN_NroPlacaUnidad = strNroPlacaUnidad
            cboTracto.pCargar(obeTracto)
        Catch : End Try

    End Sub

    Private Sub CargaConductor(ByVal strRucTransportista As String, ByVal strCBRCNT As String)

        Dim obj_logica As New Detalle_Solicitud_Transporte_BLL
        Dim obj_Table As DataTable = HelpClass.GetDataSetNative(obj_logica.Listar_Conductor_Solicitud(cboTransportista.pRucTransportista, CCMPN_Compania))
        Try
            With Me.ctbConductor
                .DataSource = obj_Table.Copy
                .KeyField = "CBRCNT"
                .ValueField = "TOBS"
                .DataBind()

            End With
            If (strCBRCNT <> "") Then
                ctbConductor.Codigo = strCBRCNT
            End If
        Catch : End Try

    End Sub
    Private Sub cboTransportista_InformationChanged() Handles cboTransportista.InformationChanged
        Try
            cboTracto.pClear()
            ctbConductor.Limpiar()
            CargarTracto(oPlaneamientoBE_GA.CCMPN, oPlaneamientoBE_GA.CDVSN, oPlaneamientoBE_GA.CPLNDV, cboTransportista.pRucTransportista, "")
            CargaConductor(cboTransportista.pRucTransportista, "")

            Dim obj_logica As New Detalle_Solicitud_Transporte_BLL
            Dim obj_Table As DataTable = HelpClass.GetDataSetNative(obj_logica.Listar_Conductor_Solicitud(cboTransportista.pRucTransportista, CCMPN_Compania))
            HabilitaDesabilitaComboCoductores(obj_Table)
        Catch : End Try
    End Sub
    Private Sub HabilitaDesabilitaComboCoductores(ByVal odt As DataTable)
        If (odt.Rows.Count > 0) Then
            ctbConductor.Enabled = True
        Else
            ctbConductor.Enabled = False
        End If

    End Sub
    Private Sub LimpiarTextos()
        txtCorrelativo.Text = String.Empty
        txtSubCorrelativo.Text = String.Empty
        txtPlaneamiento.Text = String.Empty
        txtOrdenInterna.Text = String.Empty
        txtObservacion.Text = String.Empty
        txtOrdenServicio.Text = String.Empty
    End Sub

    Private Sub btnnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnCancelar.Click
        Try
            AccionCancelar()
        Catch : End Try
    End Sub

    Private Sub btnnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnEliminar.Click
        Dim intResultado As Int32 = 0
        Try
            If MsgBox("Desea eliminar este registro?", MsgBoxStyle.OkCancel, "Eliminar") = MsgBoxResult.Ok Then
                gEnum_Mantenimiento = MANTENIMIENTO.ELIMINAR
                Dim oPlaneamiento As New Planeamiento()
                Dim oPlaneamientoBLL As New Planeamiento_BLL()
                oPlaneamiento.NPLNMT = Convert.ToDouble(txtPlaneamiento.Text)
                oPlaneamiento.NCRRPL = Convert.ToDouble(txtCorrelativo.Text)
                oPlaneamiento.NSBCRP = Convert.ToDouble(txtSubCorrelativo.Text)
                oPlaneamiento.CULUSA = MainModule.USUARIO
                oPlaneamiento.FULTAC = HelpClass.TodayNumeric
                oPlaneamiento.HULTAC = HelpClass.NowNumeric
                oPlaneamiento.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                oPlaneamiento.SESTRC_S = "*"
                intResultado = oPlaneamientoBLL.Eliminar_Planeamiento_Item(oPlaneamiento)
                If (intResultado <> 0) Then
                    AccionCancelar()
                    MostrarListadoPlaneamiento()
                    Me.gwdDatosPlaneamiento.CurrentRow.Selected = False
                    MessageBox.Show("Se ha eliminado el registro")
                    Verifica_Si_PuedeAdicionar_Items()
                End If               
            End If
        Catch : End Try

    End Sub

   
    Private Sub gwdDatosPlaneamiento_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gwdDatosPlaneamiento.KeyUp
        If Me.gwdDatosPlaneamiento.CurrentCellAddress.Y < 0 Then
            Exit Sub
        End If
        Select Case e.KeyCode
            Case Keys.Up, Keys.Down, Keys.Enter
                CargaDatosPlaneamiento(Me.gwdDatosPlaneamiento.CurrentCellAddress.Y)
        End Select
    End Sub

    

    Private Sub cboTransportista_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboTransportista.KeyPress
        Select Case Asc(e.KeyChar)
            Case 13
                cboTracto.Focus()
        End Select
    End Sub
End Class
