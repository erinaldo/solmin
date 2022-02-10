Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports System.Text

Public Class frmLiquidacionFlete_1

#Region "Eventos"

    Private Sub frmLiquidacionFlete_1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            Dim dtEstado As New DataTable
            dtEstado.Columns.Add("VALUE")
            dtEstado.Columns.Add("DISPLAY")

            Dim dr As DataRow
            dr = dtEstado.NewRow
            dr("DISPLAY") = "TODOS"
            dr("VALUE") = "-1"
            dtEstado.Rows.Add(dr)

            dr = dtEstado.NewRow
            dr("DISPLAY") = "ACTIVO"
            dr("VALUE") = "A"
            dtEstado.Rows.Add(dr)

            dr = dtEstado.NewRow
            dr("DISPLAY") = "ANULADO"
            dr("VALUE") = "*"
            dtEstado.Rows.Add(dr)

            cboEstado.DataSource = dtEstado
            cboEstado.ValueMember = "VALUE"
            cboEstado.DisplayMember = "DISPLAY"
            cboEstado.SelectedValue = "A"



            Dim dtEstadoSAP As New DataTable
            dtEstadoSAP.Columns.Add("VALUE")
            dtEstadoSAP.Columns.Add("DISPLAY")

            Dim drSAP As DataRow
            drSAP = dtEstadoSAP.NewRow
            drSAP("DISPLAY") = "TODOS"
            drSAP("VALUE") = "-1"
            dtEstadoSAP.Rows.Add(drSAP)

            drSAP = dtEstadoSAP.NewRow
            drSAP("DISPLAY") = "ENVIADOS"
            drSAP("VALUE") = "E"
            dtEstadoSAP.Rows.Add(drSAP)

            drSAP = dtEstadoSAP.NewRow
            drSAP("DISPLAY") = "NO ENVIADOS"
            drSAP("VALUE") = "N"
            dtEstadoSAP.Rows.Add(drSAP)

            cboEstadoSAP.DataSource = dtEstadoSAP
            cboEstadoSAP.ValueMember = "VALUE"
            cboEstadoSAP.DisplayMember = "DISPLAY"
            cboEstadoSAP.SelectedValue = "-1"

            'cboEstadoSAP

            Me.Cargar_Compania()
            Me.CargarTransportista()
            'Me.Alinear_Columnas_Grilla()
            Me.Validar_Acceso_Opciones_Usuario()

            gwOperacion.AutoGenerateColumns = False
            gwdDatos.AutoGenerateColumns = False

            dtpFechaInicio.Value = Date.Now
            dtpFechaFin.Value = Date.Now

            rbLiq.Checked = False
            chkop_CheckedChanged(Nothing, Nothing)

            gwOperacion.AutoGenerateColumns = False
            'Me.cargarComboPlanta() 'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        ''OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
        Dim boolEstado As Boolean
        boolEstado = True
        ''OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
        Try
            ''OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
            boolEstado = ValidarFiltroPlanta()
            If boolEstado = False Then Exit Sub
            ''OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS

            Me.Listar_Liquidacion_Flete()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

   
    Private Sub gwdDatos_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellDoubleClick

        Try
            If e.RowIndex < 0 Then Exit Sub
            If Me.gwdDatos.Columns(e.ColumnIndex).Name = "C_NRFSAP" Then
                If Me.cboCompania.CCMPN_CodigoCompania = "EZ" And Me.gwdDatos.Item("C_TCMTRT", e.RowIndex).Value.ToString.Trim.Equals("RANSA COMERCIAL S.A.") Then
                    Exit Sub
                End If
                If Not Me.gwdDatos.Item("C_NRFSAP", e.RowIndex).Value.ToString.Trim.Equals("Enviar SAP") Then Exit Sub

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    

   
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Try
            If Me.gwdDatos.RowCount = 0 Then Exit Sub

            Dim dtGrid As New DataGridView
            dtGrid = Me.gwdDatos
            Dim strlTitulo As String
            Dim strlFiltros As New List(Of String)
            strlTitulo = "Lista de Liquidación Flete - SAP"
            strlFiltros.Add("Compañia : \n" & cboCompania.CCMPN_Descripcion)
            strlFiltros.Add("División : \n" & cboDivision.DivisionDescripcion)
            'strlFiltros.Add("Planta : \n" & cboPlanta.DescripcionPlanta)
            ' 'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
            'strlFiltros.Add("Planta : \n" & cboPlanta.DescripcionPlanta)
            Dim strPlantas As String
            strPlantas = ""
            Dim strPSiguiente As String
            Dim strPAnterior As String
            strPSiguiente = ""
            strPAnterior = ""
            For i As Integer = 0 To gwdDatos.Rows.Count - 1
                strPSiguiente = CStr(gwdDatos.Rows(i).Cells("C_TPLNTA").Value)
                If strPAnterior <> strPSiguiente Then
                    strPlantas += strPSiguiente + ", "
                    strPAnterior = strPSiguiente
                End If
            Next
            strPlantas = Strings.Left(strPlantas, Len(Trim(strPlantas)) - 1)
            strlFiltros.Add("Planta : \n" & strPlantas)
            ' 'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
            Ransa.Utilitario.HelpClass.ExportExcelConTitulos(dtGrid, strlTitulo, strlFiltros)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnAnularLiquidaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnularLiquidaciones.Click
        Try
            Dim lint_Indice As Int32 = Me.gwdDatos.CurrentCellAddress.Y
            If Me.gwdDatos.RowCount = 0 OrElse lint_Indice < 0 Then Exit Sub
            Dim frm_ConsultaOperacion As New frmConsultaOperacionLiquidaciones
            Dim objetoParametro As New Hashtable
            With frm_ConsultaOperacion
                .Compania = Me.cboCompania.CCMPN_CodigoCompania
                .Division = Me.cboDivision.Division

                'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS

                .Planta = Me.gwdDatos.Item("C_CPLNDV", lint_Indice).Value
                ' 'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
                .NroLiquidacion = Me.gwdDatos.Item("C_NLQDCN", lint_Indice).Value
                .btnProcesar.Tag = Me.cboCompania.CCMPN_Descripcion
                Dim NOPRCN As Decimal = 0
                If gwOperacion.CurrentRow IsNot Nothing Then
                    NOPRCN = Me.gwOperacion.Item("D_NOPRCN", 0).Value
                End If
                .Tag = "División : " & Me.cboDivision.DivisionDescripcion & ", Nro. Operación : " & NOPRCN
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    HelpClass.MsgBox("Se Anuló Satisfactoriamente", MessageBoxIcon.Information)
                    Me.Listar_Liquidacion_Flete()
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

#End Region

#Region "Métodos y Funciones"

    Private Sub Listar_Liquidacion_Flete()

        Dim Objeto_Logica As New GuiaTransportista_BLL
        Dim objetoParametro As New Hashtable

        Dim strCodPlanta As String = "" 'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
        objetoParametro.Add("PNCTRSPT", Me.cboTransportista.pCodigoRNS)
        objetoParametro.Add("PSCCMPN", Me.cboCompania.CCMPN_CodigoCompania)
        objetoParametro.Add("PSCDVSN", Me.cboDivision.Division)

        'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
        objetoParametro.Add("PSCPLNDV", DevuelvePlantaSeleccionadas(cboPlanta))
        'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS

        

        Select Case cboEstadoSAP.SelectedValue
            Case "-1"
                objetoParametro.Add("PNNRFSAP_INI", 0)
                objetoParametro.Add("PNNRFSAP_FIN", 9999999999)
            Case "E"
                objetoParametro.Add("PNNRFSAP_INI", 1)
                objetoParametro.Add("PNNRFSAP_FIN", 9999999999)
            Case "N"
                objetoParametro.Add("PNNRFSAP_INI", 0)
                objetoParametro.Add("PNNRFSAP_FIN", 0)
        End Select


        If chkop.Checked = True Then
            If rbLiq.Checked = True Then
                objetoParametro.Add("PNNLQDCN", CType(Me.txtLiqOp.Text, Double))
            Else
                objetoParametro.Add("PNNLQDCN", 0)
            End If
            If rbop.Checked = True Then
                objetoParametro.Add("PNNOPRCN", CType(Me.txtLiqOp.Text, Double))
            Else
                objetoParametro.Add("PNNOPRCN", 0)
            End If

        Else
            objetoParametro.Add("PNFECINI", CType(HelpClass.CtypeDate(Me.dtpFechaInicio.Value), Double))
            objetoParametro.Add("PNFECFIN", CType(HelpClass.CtypeDate(Me.dtpFechaFin.Value), Double))
            objetoParametro.Add("PNNLQDCN", 0)
            objetoParametro.Add("PNNOPRCN", 0)
        End If

         

        objetoParametro.Add("PSSESTRG", cboEstado.SelectedValue)
        Dim oListLiqOperacion As New List(Of LiquidacionOperacion)
        oListLiqOperacion = Objeto_Logica.Listar_Liquidacion_Flete_Prov_Varios(objetoParametro)
        gwOperacion.DataSource = Nothing
        gwdDatos.DataSource = oListLiqOperacion

        For Each item As DataGridViewRow In gwdDatos.Rows
            If Val("" & item.Cells("SIN_REFSAP").Value) > 0 Then
                item.Cells("IMG_SAP").Value = SOLMIN_ST.My.Resources.Rojo
            Else
                item.Cells("IMG_SAP").Value = SOLMIN_ST.My.Resources.verde
            End If
        Next


     

     

 

    End Sub

    Private Sub Listar_Operacion_x_Liquidacion_Flete(ByVal lintNPRLQD As Int64)
        Dim strCodPlanta As String = "" 'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
        Dim Objeto_Logica As New GuiaTransportista_BLL
        Dim objetoParametro As New Hashtable

        objetoParametro.Add("PNNLQDCN", lintNPRLQD)
        objetoParametro.Add("PSCCMPN", Me.cboCompania.CCMPN_CodigoCompania)
        objetoParametro.Add("PSCDVSN", Me.cboDivision.Division)
        objetoParametro.Add("PNCPLNDV", gwdDatos.CurrentRow.Cells("C_CPLNDV").Value)
        'OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS
        

        Dim oListOperacion As New List(Of ClaseGeneral)
        oListOperacion = Objeto_Logica.Listar_Operacion_x_Liquidacion_Flete(objetoParametro)
        gwOperacion.DataSource = oListOperacion
        


    End Sub

    Private Sub Liquidacion_Flete_Enviar_SAP(ByVal lintNLQDCN As Int64)
        Dim objLogica As New GuiaTransportista_BLL
        Dim objParametro As New Hashtable
        objParametro.Add("PNNLQDCN", lintNLQDCN)
        objParametro.Add("PSCCMPN", Me.gwdDatos.Item("C_CCMPN", Me.gwdDatos.CurrentCellAddress.Y).Value)
        objParametro.Add("PSCDVSN", Me.gwdDatos.Item("C_CDVSN", Me.gwdDatos.CurrentCellAddress.Y).Value)
        Dim pintNRFSAP As Int64 = objLogica.Liquidacion_Flete_Enviar_SAP(objParametro)
        If pintNRFSAP = 0 Then
            HelpClass.MsgBox("Error, Liquidación no se envió al SAP", MessageBoxIcon.Information)
        Else
            HelpClass.MsgBox("Se envió al SAP satisfactoriamente", MessageBoxIcon.Information)
            Me.gwdDatos.Item("C_NRFSAP", Me.gwdDatos.CurrentCellAddress.Y).Value = pintNRFSAP
            Me.gwdDatos.Item("C_NRFSAP", Me.gwdDatos.CurrentCellAddress.Y).ToolTipText = ""
        End If
    End Sub

    

    

    Private Sub Cargar_Compania()
        cboCompania.Usuario = MainModule.USUARIO
        cboCompania.pActualizar()
        cboCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
        cboCompania_SelectionChangeCommitted(cboCompania.oBeCompania)
    End Sub

    Private Sub CargarTransportista()
        Dim obeTransportista As New Ransa.TypeDef.Transportista.TD_TransportistaPK
        obeTransportista.pCCMPN_Compania = Me.cboCompania.CCMPN_CodigoCompania
        cboTransportista.pCargar(obeTransportista)
    End Sub

    

    Private Sub Validar_Acceso_Opciones_Usuario()
        Dim objParametro As New Hashtable
        Dim objLogica As New NEGOCIO.Acceso_Opciones_Usuario_BLL
        Dim objEntidad As New ClaseGeneral

        objParametro.Add("MMCAPL", MainModule.getAppSetting("System_prefix"))
        objParametro.Add("MMCUSR", MainModule.USUARIO)
        objParametro.Add("MMNPVB", Me.Name.Trim)
        objEntidad = objLogica.Validar_Acceso_Opciones_Usuario(objParametro)

        If objEntidad.STSOP1 = "" Then
            btnAnularLiquidaciones.Visible = False
        End If
 

        If objEntidad.STSOP2 = "" Then
            Me.btnActualizar.Visible = False
        End If

    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click

        Try
            If Me.gwdDatos.RowCount = 0 OrElse Me.gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
            Dim intIndice As Integer = Me.gwdDatos.CurrentCellAddress.Y

            If Me.gwdDatos.Item("C_NRFSAP", intIndice).Value.ToString.Trim <> "Enviar SAP" Then
                HelpClass.MsgBox("La Liquidación tiene Referencia SAP", MessageBoxIcon.Information)
                Exit Sub
            End If

            If Me.gwdDatos.Item("C_NUMOPG", intIndice).Value <> 0 Then
                HelpClass.MsgBox("La Liquidación tiene Documento de Pago", MessageBoxIcon.Information)
                Exit Sub
            End If
            If MessageBox.Show("Desea actualizar la Liquidación N° " & Me.gwdDatos.Item("C_NLQDCN", intIndice).Value & " a la Fecha", "ACTUALIZAR", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Cancel Then Exit Sub
            Dim objLogica As New GuiaTransportista_BLL
            Dim objParametro As New Hashtable
            objParametro.Add("CCMPN", Me.gwdDatos.Item("C_CCMPN", intIndice).Value)
            objParametro.Add("CDVSN", Me.gwdDatos.Item("C_CDVSN", intIndice).Value)

            ''OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS 
            objParametro.Add("CPLNDV", Me.gwdDatos.Item("C_CPLNDV", intIndice).Value)
            ''OMVB REQ30072019 CONSULTAS CON SELECCIÓN DE PLANTAS 
            objParametro.Add("NLQDCN", Me.gwdDatos.Item("C_NLQDCN", intIndice).Value)
            objParametro.Add("FECACT", Format(Date.Today, "yyyyMMdd"))

            Dim intResult As Int16 = objLogica.Actualizar_Datos_Liquidacion_Flete_SAP_Prov_Varios(objParametro)
            If intResult = 0 Then
                HelpClass.MsgBox("Ocurrió un Error al momento de actualizar loa Datos de la Liquidación N° " & Me.gwdDatos.Item("C_NLQDCN", intIndice).Value, MessageBoxIcon.Information)
            Else
                HelpClass.MsgBox("Se Actualizó los Datos de la Liquidación N° " & Me.gwdDatos.Item("C_NLQDCN", intIndice).Value, MessageBoxIcon.Information)
                Me.btnBuscar_Click(Nothing, Nothing)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub txtLiqOp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLiqOp.KeyPress
        If e.KeyChar = "." Then
            e.Handled = True
            Exit Sub
        End If
        If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    End Sub
#End Region



    Private Sub gwdDatos_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gwdDatos.SelectionChanged
        Try
            gwOperacion.DataSource = Nothing
            If gwdDatos.CurrentRow IsNot Nothing Then
                Me.Listar_Operacion_x_Liquidacion_Flete(gwdDatos.CurrentRow.Cells("C_NLQDCN").Value)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function DevuelvePlantaSeleccionadas(ocboPlanta As SOLMIN_ST.CheckComboBoxTest.CheckedComboBox) As String
        Dim strCodPlanta As String
        strCodPlanta = ""
        For i As Integer = 0 To ocboPlanta.CheckedItems.Count - 1
            strCodPlanta += ocboPlanta.CheckedItems(i).Value & ","
        Next
        Dim v As Integer
        v = InStr(1, strCodPlanta, "0,")
        If v = 1 Then
            strCodPlanta = "0,"

        End If
        If strCodPlanta = "0," Then
            strCodPlanta = ""
            For i As Integer = 1 To ocboPlanta.Items.Count - 1
                strCodPlanta += ocboPlanta.Items(i).Value & ","
            Next
        End If
        If strCodPlanta.Trim.Length > 0 Then
            strCodPlanta = strCodPlanta.Trim.Substring(0, strCodPlanta.Trim.Length - 1)
        End If
        Return strCodPlanta

    End Function


    Private Sub cargarComboPlanta()
        Dim objLisEntidad As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
        Dim objLisEntidad2 As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
        Dim objLogica As New NEGOCIO.Planta_BLL
        cboPlanta.Text = ""
        If (cboCompania.CCMPN_CodigoCompania IsNot Nothing And cboDivision.Division IsNot Nothing) Then
            objLogica.Crea_Lista()
            objLisEntidad2 = objLogica.Lista_Planta(cboCompania.CCMPN_CodigoCompania, cboDivision.Division)
            Dim objEntidad As New ENTIDADES.mantenimientos.ClaseGeneral

            Dim OPlanta As New ClaseGeneral
            OPlanta.CPLNDV = 0
            OPlanta.TPLNTA = "TODOS"
            objLisEntidad2.Insert(0, OPlanta)

            For Each objEntidad In objLisEntidad2
                objLisEntidad.Add(objEntidad)
            Next
            cboPlanta.DisplayMember = "TPLNTA"
            cboPlanta.ValueMember = "CPLNDV"
            cboPlanta.DataSource = objLisEntidad
            For i As Integer = 0 To cboPlanta.Items.Count - 1
                If cboPlanta.Items.Item(i).Value = "0" Then
                    cboPlanta.SetItemChecked(i, True)
                End If
            Next
            If cboPlanta.Text = "" Then
                cboPlanta.SetItemChecked(0, True)
            End If
        End If
    End Sub

    Private Function ValidarFiltroPlanta() As Boolean
        Dim msg As String = ""
       
        If chkop.Checked = True Then
            If txtLiqOp.Text = "" Then
                msg = "Ingrese Liquidación/Operación"
            End If
        End If


        Dim lstr_validacion As String = ""
        Dim lbool_existe_error As Boolean = True
        For i As Integer = 0 To cboPlanta.CheckedItems.Count - 1
            lstr_validacion += cboPlanta.CheckedItems(i).Value & ","
        Next
        If lstr_validacion = "" Then
            lbool_existe_error = False
        End If
        If lbool_existe_error = False Then
            msg = msg & Chr(13) & "Seleccione alguna(s) Planta(s)"
        End If

        Return lbool_existe_error
    End Function




    Private Sub cboDivision_SelectionChangeCommitted(obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles cboDivision.SelectionChangeCommitted
        Try
            cargarComboPlanta()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cboCompania_SelectionChangeCommitted(obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cboCompania.SelectionChangeCommitted
        Try
            cboDivision.Usuario = MainModule.USUARIO
            cboDivision.Compania = obeCompania.CCMPN_CodigoCompania
            cboDivision.DivisionDefault = "T"
            cboDivision.pActualizar()

            cboDivision_SelectionChangeCommitted(cboDivision.obeDivision)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    

    

   

    Private Sub chkop_CheckedChanged(sender As Object, e As EventArgs) Handles chkop.CheckedChanged

        Select Case chkop.Checked
            Case True
              
                Me.dtpFechaFin.Enabled = False
                Me.dtpFechaInicio.Enabled = False
                GroupBox1.Enabled = True
                rbLiq.Checked = True
                txtLiqOp.Enabled = True


            Case False
              
                Me.dtpFechaFin.Enabled = True
                Me.dtpFechaInicio.Enabled = True

                GroupBox1.Enabled = False
                rbLiq.Checked = False
                rbop.Checked = False
                txtLiqOp.Enabled = False
        End Select
    End Sub

   

End Class
