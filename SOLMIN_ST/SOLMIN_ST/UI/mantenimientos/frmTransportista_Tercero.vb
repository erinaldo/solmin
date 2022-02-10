Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports System.Data
Imports System.Collections.Generic
Imports Ransa.Utilitario

 
Public Class frmTransportista_Tercero
 
    Private gEnumOpcMan As Opcion = Opcion.Neutral

    Private TabSeleccionado As String = ""
    Private pPLantaDefault As Decimal = 0
    Private oLisResponSeg As New List(Of TipoDatoGeneral)
    Enum Opcion
        Neutral
        Nuevo
        Modificar
    End Enum
   
    Private Sub HabilitarBoton(ByVal tabOpcion As String, ByVal op As Opcion)
        Select Case tabOpcion
            Case "TabDatosTransportista"
                Select Case op
                    Case Opcion.Neutral
                        btnNuevo.Enabled = True
                        btnModificar.Enabled = True
                        btnGuardar.Visible = False
                        btnCancelar.Enabled = False
                        btnEliminar.Enabled = True
                        btnImprimirTR.Enabled = True
                        btnExportarDetalle.Enabled = True
                        btnBuscarFiltroAcoplado.Enabled = True
                        btnBuscarFiltroBrevete.Enabled = True
                        btnBuscarFiltroVehiculo.Enabled = True
                        btnImprimirTRTodos.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
                        btnExportarExcel.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
                        btnBusqueda.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True


                       

                        Me.Estado_Controles_Transportista(False)

                    Case Opcion.Nuevo
                        btnNuevo.Enabled = False
                        btnModificar.Enabled = False
                        btnGuardar.Visible = True
                        btnGuardar.Enabled = True
                        btnCancelar.Enabled = True
                        btnEliminar.Enabled = False
                        btnImprimirTR.Enabled = False
                        btnBuscarFiltroAcoplado.Enabled = False
                        btnBuscarFiltroBrevete.Enabled = False
                        btnBuscarFiltroVehiculo.Enabled = False
                        btnExportarDetalle.Enabled = False
                        btnImprimirTRTodos.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                        btnExportarExcel.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                        btnBusqueda.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True

                      
                    Case Opcion.Modificar
                        btnNuevo.Enabled = False
                        btnModificar.Enabled = False
                        btnGuardar.Visible = True
                        btnGuardar.Enabled = True
                        btnCancelar.Enabled = True
                        btnEliminar.Enabled = False
                        btnImprimirTR.Enabled = False
                        btnBuscarFiltroAcoplado.Enabled = False
                        btnBuscarFiltroBrevete.Enabled = False
                        btnBuscarFiltroVehiculo.Enabled = False
                        btnExportarDetalle.Enabled = False
                        btnImprimirTRTodos.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                        btnExportarExcel.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                        btnBusqueda.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True

                End Select
            Case "TabVehiculos"

                Select Case op
                    Case Opcion.Neutral
                        btnNuevo.Enabled = True
                        btnModificar.Enabled = False
                        btnGuardar.Visible = False
                        btnCancelar.Enabled = False
                        btnEliminar.Enabled = True
                        btnImprimirTR.Enabled = True
                        btnBuscarFiltroAcoplado.Enabled = True
                        btnBuscarFiltroBrevete.Enabled = True
                        btnBuscarFiltroVehiculo.Enabled = True
                        btnExportarDetalle.Enabled = True
                        btnImprimirTRTodos.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
                        btnExportarExcel.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
                        btnBusqueda.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
                        Me.Estado_Controles_Transportista(False)

                End Select
            Case "TabAcoplados"

                Select Case op
                    Case Opcion.Neutral
                        btnNuevo.Enabled = True
                        btnModificar.Enabled = False
                        btnGuardar.Visible = False
                        btnCancelar.Enabled = False
                        btnEliminar.Enabled = True
                        btnImprimirTR.Enabled = True
                        btnBuscarFiltroAcoplado.Enabled = True
                        btnBuscarFiltroBrevete.Enabled = True
                        btnBuscarFiltroVehiculo.Enabled = True
                        btnExportarDetalle.Enabled = True
                        btnImprimirTRTodos.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
                        btnExportarExcel.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
                        btnBusqueda.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
                        Me.Estado_Controles_Transportista(False)

                End Select
            Case "TabConductores"
                Select Case op
                    Case Opcion.Neutral
                        btnNuevo.Enabled = True
                        btnModificar.Enabled = False
                        btnGuardar.Visible = False
                        btnCancelar.Enabled = False
                        btnEliminar.Enabled = True
                        btnImprimirTR.Enabled = True
                        btnBuscarFiltroAcoplado.Enabled = True
                        btnBuscarFiltroBrevete.Enabled = True
                        btnBuscarFiltroVehiculo.Enabled = True
                        btnExportarDetalle.Enabled = True
                        btnImprimirTRTodos.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
                        btnExportarExcel.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
                        btnBusqueda.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True

                        Me.Estado_Controles_Transportista(False)

                End Select
        End Select
    End Sub


 

     

    Private Function GetPlantaSeleccionada() As Decimal
        Dim planta As Decimal = pPlantaDefault
        If planta = 0 Then
            planta = cmbPlanta.SelectedValue
        End If
        Return planta
    End Function

    Private Sub frmTransportista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Dim obj As New TipoDatoGeneral_BLL
            Dim lista As New List(Of TipoDatoGeneral)
            lista = obj.Lista_Tipo_Dato_General("", "STPLMT")
            If lista.Count > 0 Then
                pPLantaDefault = lista(0).CODIGO_TIPO
            End If
            If pPLantaDefault > 0 Then
                lblPlanta.Visible = False
                cmbPlanta.Visible = False
            End If

            Dim oTipoDatoGeneral_BLL As New TipoDatoGeneral_BLL
            oLisResponSeg = oTipoDatoGeneral_BLL.Lista_Tipo_Dato_General_RZPR05("RESPSEGCARGA")
            Dim oTemp As New TipoDatoGeneral
            oTemp.CODIGO_TIPO = ""
            oTemp.DESC_TIPO = "::Seleccione::"
            oLisResponSeg.Insert(0, oTemp)

            cmbPolizaSeguro.DataSource = oLisResponSeg
            cmbPolizaSeguro.DisplayMember = "DESC_TIPO"
            cmbPolizaSeguro.ValueMember = "CODIGO_TIPO"


          

            Me.txtFiltroTransportista.MaxLength = 15
            gEnumOpcMan = Opcion.Neutral
            TabSeleccionado = TabTransportista.SelectedTab.Name
            Me.Cargar_Compania()


   
            HabilitarBoton(Me.TabTransportista.SelectedTab.Name, Opcion.Neutral)
            Me.Validar_Acceso_Opciones_Usuario()
            CargarEstadoTransportista()
           
            Me.Limpiar_Controles_Transportista()

            Me.gwdDatos.AutoGenerateColumns = False
            gwdResTractosTransportista.AutoGenerateColumns = False
            gwdResAcopladosTransportista.AutoGenerateColumns = False
            gwdResConductoresTransportista.AutoGenerateColumns = False



            Me.txtFiltroTransportista.CharacterCasing = CharacterCasing.Upper

            chkTercero.Checked = True
            chkTercero.Enabled = False

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub CargarEstadoTransportista()
        Dim dtEstado As New DataTable
        dtEstado.Columns.Add("DISPLAY")
        dtEstado.Columns.Add("VALUE")

        Dim dr As DataRow
        dr = dtEstado.NewRow
        dr("DISPLAY") = "ACTIVO"
        dr("VALUE") = "1"
        dtEstado.Rows.Add(dr)

        dr = dtEstado.NewRow
        dr("DISPLAY") = "INACTIVO"
        dr("VALUE") = "2"
        dtEstado.Rows.Add(dr)

        cboEstado.DataSource = dtEstado
        cboEstado.DisplayMember = "DISPLAY"
        cboEstado.ValueMember = "VALUE"

        cboEstado.SelectedValue = "1"

    End Sub

    Private Sub Validar_Acceso_Opciones_Usuario()
        Dim objParametro As New Hashtable
        Dim objLogica As New NEGOCIO.Acceso_Opciones_Usuario_BLL
        Dim objEntidad As New ClaseGeneral

        objParametro.Add("MMCAPL", MainModule.getAppSetting("System_prefix"))
        objParametro.Add("MMCUSR", MainModule.USUARIO)
        objParametro.Add("MMNPVB", Me.Name.Trim)
        objEntidad = objLogica.Validar_Acceso_Opciones_Usuario(objParametro)

        If objEntidad.STSADI = "" Then
            Me.btnNuevo.Visible = False
            Me.Separator1.Visible = False
        End If
        If objEntidad.STSCHG = "" Then
            Me.btnGuardar.Visible = False
            Me.Separator2.Visible = False
        End If
        If objEntidad.STSADI = "" And objEntidad.STSCHG = "" Then
            Me.btnCancelar.Visible = False
            Me.Separator3.Visible = False
        End If
        If objEntidad.STSELI = "" Then
            Me.btnEliminar.Visible = False
            Me.Separator4.Visible = False
        End If
        If objEntidad.STSVIS = "" Then
            Me.btnImprimirTR.Visible = False
        End If

        Me.btnHabilitar.Visible = False
       

    End Sub

    

 

    Private Sub Cargar_Compania()

        Dim objCompaniaBLL As New NEGOCIO.Compania_BLL

        objCompaniaBLL.Crea_Lista()
        cmbCompania.DataSource = objCompaniaBLL.Lista
        cmbCompania.ValueMember = "CCMPN"
        cmbCompania.DisplayMember = "TCMPCM"
       

        Ransa.Utilitario.HelpClass.HabilitarCompaniaActual(Me.cmbCompania, Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)

        cmbCompania_SelectionChangeCommitted(Nothing, Nothing)
       
    End Sub

     

    
   

   
    

    Private Sub cmbCompania_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCompania.SelectionChangeCommitted
     

        Try
            Dim objDivision As New NEGOCIO.Division_BLL
          
            objDivision.Crea_Lista()
            cmbDivision.DataSource = objDivision.Lista_Division(Me.cmbCompania.SelectedValue.ToString.Trim)
            cmbDivision.ValueMember = "CDVSN"
            cmbDivision.DisplayMember = "TCMPDV"
            Me.cmbDivision.SelectedValue = "T"

            If Me.cmbDivision.SelectedIndex = -1 Then
                Me.cmbDivision.SelectedIndex = 0
            End If
            cmbDivision_SelectionChangeCommitted(cmbDivision, Nothing)
           
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbDivision_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDivision.SelectionChangeCommitted

        Try
            If pPLantaDefault = 0 Then
                Dim objPlanta As New NEGOCIO.Planta_BLL
                Dim objLisEntidad As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
                objPlanta.Crea_Lista()
                objLisEntidad = objPlanta.Lista_Planta(Me.cmbCompania.SelectedValue, Me.cmbDivision.SelectedValue)
                cmbPlanta.DataSource = objLisEntidad
                cmbPlanta.ValueMember = "CPLNDV"
                cmbPlanta.DisplayMember = "TPLNTA"
                Me.cmbPlanta.SelectedIndex = 0
            End If
        
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
   



    

    

    



    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        Try
            Dim lstr_PestanaActiva As String
            lstr_PestanaActiva = Me.TabTransportista.SelectedTab.Name


            Select Case lstr_PestanaActiva
                Case "TabVehiculos", "TabAcoplados", "TabConductores"
                    If gwdDatos.CurrentRow Is Nothing Then
                        Exit Sub
                    End If
                    Dim estado As String = ("" & gwdDatos.CurrentRow.Cells("SESTRG").Value).ToString.Trim
                    If estado = "*" Then
                        MessageBox.Show("No se puede adicionar detalles. El transportista está anulado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
            End Select
         


            Select Case lstr_PestanaActiva
                Case "TabDatosTransportista"
                    gEnumOpcMan = Opcion.Nuevo

                    chkTercero.Enabled = False
                    gwdResTractosTransportista.DataSource = Nothing
                    gwdResAcopladosTransportista.DataSource = Nothing
                    gwdResConductoresTransportista.DataSource = Nothing


                    'cboTranspAS400.Limpiar()
                    txtCod_AS.Text = ""
                    txtCod_AS.Tag = "0"

                    txtCodigoSAP.Text = ""
                    txtNroRuc.Text = ""
                    txtRazonSocial.Text = ""
                    txtDescripcion.Text = ""
                    txtDireccionTransportista.Text = ""
                    txtTelefonoTransportista.Text = ""

                    cmbPolizaSeguro.ComboBox.SelectedValue = ""
                    txtPorSeguro.Text = "0.00"

                    Me.HeaderDatos.ValuesPrimary.Heading = "Información de Transportista"

                    'Me.txtNroRuc.Enabled = True
                    Me.txtNroRuc.ReadOnly = False

                    'txtCodigoSAP.Enabled = True
                    txtCodigoSAP.Enabled = False

                    txtRazonSocial.Enabled = True
                    txtDescripcion.Enabled = True
                    txtDireccionTransportista.Enabled = True
                    txtTelefonoTransportista.Enabled = True
                    'cboTranspAS400.Enabled = True
                    btnTransp_AS.Enabled = True

                    chkTercero.Enabled = False
                    chkTercero.Checked = True


                    cmbPolizaSeguro.ComboBox.Enabled = True
                    txtPorSeguro.Enabled = True


                    HabilitarBoton(lstr_PestanaActiva, Opcion.Nuevo)

                Case "TabVehiculos"
                    Dim obrTracto As New Tracto_BLL
                    Dim ofrmNewTracto As New frmNuevoTracto(True)
                    ofrmNewTracto.btnModificar.Visible = False
                    With ofrmNewTracto
                        .TIPO = "T"
                        .CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
                        If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                            Registrar_VehiculoTransportista(.NPLCUN, .TOBS)
                            '.objEntidad.CTRSPT = gwdDatos.CurrentRow.Cells("CTRSPT").Value
                            'obrTracto.Registrar_Tracto_Antiguo(.objEntidad)

                            Buscar_Filtro_Vehiculo(Nothing, Nothing)
                        End If

                    End With

                Case "TabAcoplados"
                    Dim obrAcoplado As New Acoplado_BLL
                    Dim ofrmNewAcoplado As New frmNuevoAcoplado(True)
                    ofrmNewAcoplado.btnModificar.Visible = False
                    With ofrmNewAcoplado
                        .TIPO = "T"
                        .CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
                        If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                            Registrar_AcopladoTransportista(.NPLCAC, .TOBS)
                            '.objEntidad.CTRSPT = gwdDatos.CurrentRow.Cells("CTRSPT").Value
                            'obrAcoplado.Registrar_Acoplado_Antiguo(.objEntidad)

                            Buscar_Filtro_Acoplado(Nothing, Nothing)
                        End If

                    End With

                Case "TabConductores"

                    Dim ofrmNuevoConductor As New frmNuevoConductor(True)
                    With ofrmNuevoConductor
                        .chkTercero.Visible = False
                        .btnNuevo.Visible = False
                        .btnModificar.Visible = False
                        .ToolStripSeparator1.Visible = False
                        .CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            Dim obrConductor As New Chofer_BLL
                            Registrar_ConductorTransportista(.CBRCNT, .TOBS)
                            '.objEntidad.CTRSPT = gwdDatos.CurrentRow.Cells("CTRSPT").Value
                            'obrConductor.Registrar_Chofer_Antiguo(.objEntidad)

                            Buscar_Filtro_Brevete(Nothing, Nothing)
                        End If
                        'AccionCancelar()
                    End With
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try




    End Sub

    Private Function ValidarTransportista() As String
        Dim msgVal As String = ""
        If Me.txtNroRuc.Text = "" Then
            msgVal = "Ingrese el RUC"
        End If
        If Me.txtNroRuc.Text.Length <> 11 Then
            msgVal = msgVal & Chr(13) & "El RUC debe tener 11 caracteres."

        End If
        If Me.txtRazonSocial.Text = "" Then
            msgVal = msgVal & Chr(13) & "Ingrese la razón social."

        End If
       
        If cmbPolizaSeguro.SelectedValue = "" Then
            msgVal = msgVal & "Póliza Seguro" & Chr(13)
        End If
        If cmbPolizaSeguro.ComboBox.SelectedValue = "R" Then
            If Val(txtPorSeguro.Text.Trim) = 0 Then
                msgVal = msgVal & "%Seguro mayor a cero." & Chr(13)
            End If
        End If

        msgVal = msgVal.Trim
        Return msgVal
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Dim lstr_PestanaActiva As String
        lstr_PestanaActiva = Me.TabTransportista.SelectedTab.Name
        Dim msgVal As String = ""

       


        Try
            Select Case lstr_PestanaActiva
                Case "TabDatosTransportista"
                    Select Case gEnumOpcMan
                        Case Opcion.Nuevo
                            msgVal = ValidarTransportista()
                            If msgVal.Length > 0 Then
                                MessageBox.Show(msgVal, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Exit Sub

                            End If

                            Dim oTransportistaBLL As New Transportista_BLL
                            Dim dtTransportista As New DataTable
                            Dim objEntidad As Transportista
                            objEntidad = New Transportista
                            objEntidad.NRUCTR = Me.txtNroRuc.Text.Trim
                            objEntidad.CCMPN = Me.cmbCompania.SelectedValue
                            objEntidad.SESTRG = "*"
                            'objEntidad.NEWCTRSPT = cboTranspAS400.Codigo
                            objEntidad.NEWCTRSPT = Val("" & txtCod_AS.Tag)
                            If objEntidad.NEWCTRSPT = "" Then
                                objEntidad.NEWCTRSPT = "0"
                            End If
                            dtTransportista = oTransportistaBLL.Listar_Transportista_X_RUC(objEntidad)
                            ' SE VERIFICA SI ESTÁ ANULADO PARA SER REACTIVADO
                            If dtTransportista.Rows.Count > 0 Then
                                Dim RUC_SOLMIN As String = ("" & dtTransportista.Rows(0)("RUC_SOLMIN")).ToString.Trim
                                Dim RUC_AS As String = ("" & dtTransportista.Rows(0)("RUC_AS")).ToString.Trim
                                If RUC_SOLMIN <> RUC_AS Then
                                    MessageBox.Show("El transportista AS400 no coincide con el RUC especificado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    Exit Sub
                                Else
                                    If MessageBox.Show("El transportista se encuentra en estado inactivo.Desea activar y reemplazar con los datos ingresados", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                        objEntidad = New Transportista
                                        oTransportistaBLL = New Transportista_BLL
                                        objEntidad.CCMPN = Me.cmbCompania.SelectedValue
                                        objEntidad.NRUCTR = Me.txtNroRuc.Text.Trim
                                        objEntidad.CULUSA = MainModule.USUARIO
                                        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                                        oTransportistaBLL.ActivarTransportista(objEntidad)

                                        Modificar_Transportista()
                                    End If
                                End If
                            Else
                                Registrar_Transportista()
                                txtNroRuc.Focus()
                            End If


                        Case Opcion.Modificar

                            msgVal = ValidarTransportista()
                            'If cboTranspAS400.Codigo = "" Then
                            '    msgVal = msgVal & Chr(13) & "Seleccione un código de transportista AS400."
                            'End If
                            If Val("" & txtCod_AS.Tag) = 0 Then
                                msgVal = msgVal & Chr(13) & "Seleccione un código de transportista AS400."
                            End If

                            msgVal = msgVal.Trim

                            If msgVal.Length > 0 Then
                                MessageBox.Show(msgVal, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Exit Sub
                            End If
                            Modificar_Transportista()


                    End Select


            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub Registrar_VehiculoTransportista(ByVal strVehiculo As String, ByVal strObservacion As String)
        Dim objEntidadTT As New TransportistaTracto
        Dim objLogica As New TransportistaTracto_BLL

        objEntidadTT.NRUCTR = txtNroRuc.Text
        objEntidadTT.NPLCUN = strVehiculo
        objEntidadTT.FECINI = HelpClass.TodayNumeric
        objEntidadTT.FECFIN = HelpClass.TodayNumeric
        objEntidadTT.TOBS = strObservacion
        objEntidadTT.CUSCRT = MainModule.USUARIO
        objEntidadTT.FCHCRT = HelpClass.TodayNumeric
        objEntidadTT.HRACRT = HelpClass.NowNumeric
        objEntidadTT.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidadTT.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidadTT.POS_RUC_ANTERIOR = ""
        objEntidadTT.FLAG_SKIPCHECKS = 0
        objEntidadTT.SESTCM = ""
        objEntidadTT.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
        objEntidadTT.CDVSN = cmbDivision.SelectedValue
        objEntidadTT.CPLNDV = GetPlantaSeleccionada() ' cmbPlanta.SelectedValue
        objEntidadTT.STPVHP = ""

        Dim objExisteTT As New TransportistaTracto
        objExisteTT = objEntidadTT
        objExisteTT = objLogica.Registrar_TransportistaTracto_V2(objExisteTT)

        'If objExisteTT.NRUCTR = "-1" Then 'ocurrió un error
        '    HelpClass.ErrorMsgBox()
        '    Exit Sub

        'ElseIf objExisteTT.POS_RUC_ANTERIOR = "" Then 'no existe
        '    objEntidadTT.FLAG_SKIPCHECKS = 1
        '    objEntidadTT = objLogica.Registrar_TransportistaTracto_V2(objEntidadTT)
        '    If objEntidadTT.NRUCTR = "-1" Then
        '        HelpClass.ErrorMsgBox()
        '        Exit Sub
        '        'Else
        '        'Listar_ResumenVehiculos()
        '    End If

        'ElseIf objExisteTT.POS_RUC_ANTERIOR <> "" Then 'existe la combinacion NRUCTR-NPLCUN

        '    Dim objLogicaCia As New Transportista_BLL

        '    'valida q no se asigne a la misma cia q ya lo tiene
        '    If objExisteTT.POS_RUC_ANTERIOR = objEntidadTT.NRUCTR Then
        '        'se pretendio asignar a una cia q ya lo tuvo o tiene asignado
        '        If objExisteTT.SESTCM = "*" Then
        '            objEntidadTT.FLAG_SKIPCHECKS = 1
        '            objEntidadTT = objLogica.Registrar_TransportistaTracto_V2(objEntidadTT)
        '            If objEntidadTT.NRUCTR = "-1" Then
        '                HelpClass.ErrorMsgBox()
        '                Exit Sub
        '                'Else
        '                '   Listar_ResumenVehiculos()
        '            End If
        '        Else
        '            ' HelpClass.MsgBox("Tracto ya asignado.", MessageBoxIcon.Error)
        '            MessageBox.Show("Tracto ya asignado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '            Exit Sub
        '        End If

        '    Else 'cambio de otra compañia
        '        Dim objCia1 As New Transportista
        '        objCia1.NRUCTR = objExisteTT.POS_RUC_ANTERIOR
        '        objCia1.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
        '        objCia1.CDVSN = cmbDivision.SelectedValue 'Me.gwdDatos.CurrentRow.Cells("CDVSN").Value
        '        objCia1.CPLNDV = cmbPlanta.SelectedValue 'Me.gwdDatos.CurrentRow.Cells("CPLNDV").Value
        '        objCia1.SESTRG = ""
        '        Dim olbeCia1 As New List(Of Transportista)
        '        olbeCia1 = objLogicaCia.Listar_Transportista(objCia1)
        '        If olbeCia1.Count = 0 Then Exit Sub
        '        objCia1 = objLogicaCia.Listar_Transportista(objCia1).Item(0)

        '        Dim strMsg As String = "Tracto ya asignado a una compañía" & vbCrLf & _
        '                                "Tracto: " & objExisteTT.NPLCUN & vbCrLf & _
        '                                "Compañía: " & objCia1.TCMTRT & vbCrLf & _
        '                                "¿Desea cambiarlo a la compañía " & txtRazonSocial.Text & " ?"
        '        If MsgBox(strMsg, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
        '            objEntidadTT.FLAG_SKIPCHECKS = 1
        '            objEntidadTT = objLogica.Registrar_TransportistaTracto(objEntidadTT)
        '            If objEntidadTT.NRUCTR = "-1" Then
        '                HelpClass.ErrorMsgBox()
        '                Exit Sub

        '            End If
        '        End If

        '    End If

        'End If


        'If objExisteTT.NRUCTR = "-1" Then 'ocurrió un error
        '    HelpClass.ErrorMsgBox()
        '    Exit Sub

        'Else
        If objExisteTT.POS_RUC_ANTERIOR = "" Then 'no existe
            objEntidadTT.FLAG_SKIPCHECKS = 1
            objEntidadTT = objLogica.Registrar_TransportistaTracto_V2(objEntidadTT)


        ElseIf objExisteTT.POS_RUC_ANTERIOR <> "" Then 'existe la combinacion NRUCTR-NPLCUN

            Dim objLogicaCia As New Transportista_BLL

            'valida q no se asigne a la misma cia q ya lo tiene
            If objExisteTT.POS_RUC_ANTERIOR = objEntidadTT.NRUCTR Then
                'se pretendio asignar a una cia q ya lo tuvo o tiene asignado
                If objExisteTT.SESTCM = "*" Then
                    objEntidadTT.FLAG_SKIPCHECKS = 1
                    objEntidadTT = objLogica.Registrar_TransportistaTracto_V2(objEntidadTT)

                Else

                    MessageBox.Show("Tracto ya asignado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

            Else 'cambio de otra compañia
                Dim objCia1 As New Transportista
                objCia1.NRUCTR = objExisteTT.POS_RUC_ANTERIOR
                objCia1.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
                objCia1.CDVSN = cmbDivision.SelectedValue
                objCia1.CPLNDV = GetPlantaSeleccionada() ' cmbPlanta.SelectedValue
                objCia1.SESTRG = ""
                Dim olbeCia1 As New List(Of Transportista)
                olbeCia1 = objLogicaCia.Listar_Transportista(objCia1)
                If olbeCia1.Count = 0 Then Exit Sub

                objCia1 = olbeCia1.Item(0)

                Dim strMsg As String = "Tracto ya asignado a una compañía" & vbCrLf & _
                                        "Tracto: " & objExisteTT.NPLCUN & vbCrLf & _
                                        "Compañía: " & objCia1.TCMTRT & vbCrLf & _
                                        "¿Desea cambiarlo a la compañía " & txtRazonSocial.Text & " ?"
                If MsgBox(strMsg, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    objEntidadTT.FLAG_SKIPCHECKS = 1
                    'objEntidadTT = objLogica.Registrar_TransportistaTracto(objEntidadTT)
                    objEntidadTT = objLogica.Registrar_TransportistaTracto_V2(objEntidadTT)

                End If
            End If
        End If

    End Sub


    Private Sub Registrar_AcopladoTransportista(ByVal strAcoplado As String, ByVal strObservacion As String)

        Dim objEntidadTA As New TransportistaAcoplado
        Dim objLogica As New TransportistaAcoplado_BLL

        objEntidadTA.NRUCTR = txtNroRuc.Text
        objEntidadTA.NPLCAC = strAcoplado
        objEntidadTA.FECINI = HelpClass.TodayNumeric
        objEntidadTA.FECFIN = HelpClass.TodayNumeric
        objEntidadTA.TOBS = strObservacion
        objEntidadTA.CUSCRT = MainModule.USUARIO
        objEntidadTA.FCHCRT = HelpClass.TodayNumeric
        objEntidadTA.HRACRT = HelpClass.NowNumeric
        objEntidadTA.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidadTA.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidadTA.POS_RUC_ANTERIOR = ""
        objEntidadTA.FLAG_SKIPCHECKS = 0
        objEntidadTA.SESTAC = ""
        objEntidadTA.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
        objEntidadTA.CDVSN = cmbDivision.SelectedValue
        objEntidadTA.CPLNDV = GetPlantaSeleccionada() ' cmbPlanta.SelectedValue
        objEntidadTA.STPACP = ""

        Dim objExisteTA As New TransportistaAcoplado
        objExisteTA = objEntidadTA
        objExisteTA = objLogica.Registrar_TransportistaAcoplado_V2(objExisteTA)

        'If objExisteTA.NRUCTR = "-1" Then 'ocurrio un error
        '    HelpClass.ErrorMsgBox()
        '    Exit Sub
        'ElseIf objExisteTA.POS_RUC_ANTERIOR = "" Then 'no existe
        '    objEntidadTA.FLAG_SKIPCHECKS = 1
        '    objEntidadTA = objLogica.Registrar_TransportistaAcoplado_V2(objEntidadTA)
        '    If objEntidadTA.NRUCTR = "-1" Then
        '        HelpClass.ErrorMsgBox()
        '        Exit Sub
        '        'Else
        '        'Listar_ResumenAcoplados()
        '    End If

        'ElseIf objEntidadTA.POS_RUC_ANTERIOR <> "" Then ' existe la combinacion NRUCTR-NPLCAC
        '    Dim objLogicaCia As New Transportista_BLL

        '    'valida q no se asigne a la misma cia q ya lo tiene
        '    If objExisteTA.POS_RUC_ANTERIOR = objEntidadTA.NRUCTR Then
        '        'se pretendio asignar a una cia q ya lo tuvo o tiene asignado
        '        If objExisteTA.SESTAC = "*" Then
        '            objEntidadTA.FLAG_SKIPCHECKS = 1
        '            objEntidadTA = objLogica.Registrar_TransportistaAcoplado_V2(objEntidadTA)
        '            If objEntidadTA.NRUCTR = "-1" Then
        '                HelpClass.ErrorMsgBox()
        '                Exit Sub
        '                'Else
        '                'Listar_ResumenAcoplados()
        '            End If
        '        Else
        '            'HelpClass.MsgBox("Acoplado ya asignado.", MessageBoxIcon.Error)
        '            MessageBox.Show("Acoplado ya asignado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '            Exit Sub
        '        End If
        '    Else ' cambio de otra compañia
        '        Dim objCia1 As New Transportista
        '        objCia1.NRUCTR = objExisteTA.POS_RUC_ANTERIOR
        '        objCia1.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
        '        objCia1.CDVSN = cmbDivision.SelectedValue 'Me.gwdDatos.CurrentRow.Cells("CDVSN").Value
        '        objCia1.CPLNDV = cmbPlanta.SelectedValue 'Me.gwdDatos.CurrentRow.Cells("CPLNDV").Value
        '        'objCia1 = objLogicaCia.Listar_Transportista(objCia1).Item(0)
        '        objCia1.SESTRG = ""
        '        Dim olbeCia1 As New List(Of Transportista)
        '        olbeCia1 = objLogicaCia.Listar_Transportista(objCia1)
        '        If olbeCia1.Count = 0 Then Exit Sub
        '        'objCia1 = objLogicaCia.Listar_Transportista(objCia1).Item(0)
        '        objCia1 = olbeCia1.Item(0)

        '        Dim strMsg As String = "Acoplado ya asignado a una compañía" & vbCrLf & _
        '                                "Acoplado: " & objExisteTA.NPLCAC & vbCrLf & _
        '                                "Compañía: " & objCia1.TCMTRT & vbCrLf & _
        '                                "¿Desea cambiarlo a la compañía " & txtRazonSocial.Text & " ?"

        '        If MsgBox(strMsg, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
        '            objEntidadTA.FLAG_SKIPCHECKS = 1
        '            objEntidadTA = objLogica.Registrar_TransportistaAcoplado(objEntidadTA)
        '            If objEntidadTA.NRUCTR = "-1" Then
        '                HelpClass.ErrorMsgBox()
        '                Exit Sub
        '            End If
        '        End If
        '    End If
        'End If



        If objExisteTA.POS_RUC_ANTERIOR = "" Then 'no existe
            objEntidadTA.FLAG_SKIPCHECKS = 1
            objEntidadTA = objLogica.Registrar_TransportistaAcoplado_V2(objEntidadTA)


        ElseIf objEntidadTA.POS_RUC_ANTERIOR <> "" Then ' existe la combinacion NRUCTR-NPLCAC
            Dim objLogicaCia As New Transportista_BLL

            'valida q no se asigne a la misma cia q ya lo tiene
            If objExisteTA.POS_RUC_ANTERIOR = objEntidadTA.NRUCTR Then
                'se pretendio asignar a una cia q ya lo tuvo o tiene asignado
                If objExisteTA.SESTAC = "*" Then
                    objEntidadTA.FLAG_SKIPCHECKS = 1
                    objEntidadTA = objLogica.Registrar_TransportistaAcoplado_V2(objEntidadTA)

                Else

                    MessageBox.Show("Acoplado ya asignado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            Else ' cambio de otra compañia
                Dim objCia1 As New Transportista
                objCia1.NRUCTR = objExisteTA.POS_RUC_ANTERIOR
                objCia1.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
                objCia1.CDVSN = cmbDivision.SelectedValue
                objCia1.CPLNDV = GetPlantaSeleccionada() ' cmbPlanta.SelectedValue

                objCia1.SESTRG = ""
                Dim olbeCia1 As New List(Of Transportista)
                olbeCia1 = objLogicaCia.Listar_Transportista(objCia1)
                If olbeCia1.Count = 0 Then Exit Sub

                objCia1 = olbeCia1.Item(0)

                Dim strMsg As String = "Acoplado ya asignado a una compañía" & vbCrLf & _
                                        "Acoplado: " & objExisteTA.NPLCAC & vbCrLf & _
                                        "Compañía: " & objCia1.TCMTRT & vbCrLf & _
                                        "¿Desea cambiarlo a la compañía " & txtRazonSocial.Text & " ?"

                If MsgBox(strMsg, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    objEntidadTA.FLAG_SKIPCHECKS = 1
                    'objEntidadTA = objLogica.Registrar_TransportistaAcoplado(objEntidadTA)
                    objEntidadTA = objLogica.Registrar_TransportistaAcoplado_V2(objEntidadTA)

                End If
            End If
        End If

    End Sub

    Private Sub Registrar_ConductorTransportista(ByVal strConductor As String, ByVal strObservacion As String)
        Dim objEntidadTC As New TransportistaConductor
        Dim objLogica As New TransportistaConductor_BLL
        objEntidadTC.NRUCTR = txtNroRuc.Text
        objEntidadTC.CBRCNT = strConductor
        objEntidadTC.FECINI = HelpClass.TodayNumeric
        objEntidadTC.FECFIN = HelpClass.TodayNumeric
        objEntidadTC.TOBS = strObservacion
        objEntidadTC.CUSCRT = MainModule.USUARIO
        objEntidadTC.FCHCRT = HelpClass.TodayNumeric
        objEntidadTC.HRACRT = HelpClass.NowNumeric
        objEntidadTC.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidadTC.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidadTC.POS_RUC_ANTERIOR = ""
        objEntidadTC.FLAG_SKIPCHECKS = 0
        objEntidadTC.SESTCH = ""

        objEntidadTC.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
        objEntidadTC.CDVSN = cmbDivision.SelectedValue
        objEntidadTC.CPLNDV = GetPlantaSeleccionada() 'cmbPlanta.SelectedValue

        Dim objExisteTC As New TransportistaConductor
        objExisteTC = objEntidadTC
        objExisteTC.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
        objExisteTC = objLogica.Registrar_TransportistaConductor(objExisteTC)

        If objExisteTC.NRUCTR = "-1" Then 'ocurrio un error
            HelpClass.ErrorMsgBox()
            Exit Sub
        ElseIf objExisteTC.POS_RUC_ANTERIOR = "" Then 'no existe
            objEntidadTC.FLAG_SKIPCHECKS = 1
            objEntidadTC.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
            objEntidadTC = objLogica.Registrar_TransportistaConductor(objEntidadTC)


        ElseIf objEntidadTC.POS_RUC_ANTERIOR <> "" Then ' existe la combinacion NRUCTR-NPLCAC
            Dim objLogicaCia As New Transportista_BLL

            'valida q no se asigne a la misma cia q ya lo tiene
            If objExisteTC.POS_RUC_ANTERIOR = objEntidadTC.NRUCTR Then
                'se pretendio asignar a una cia q ya lo tuvo o tiene asignado
                If objExisteTC.SESTCH = "*" Then
                    objEntidadTC.FLAG_SKIPCHECKS = 1
                    objEntidadTC.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
                    objEntidadTC = objLogica.Registrar_TransportistaConductor(objEntidadTC)

                Else

                    MessageBox.Show("Conductor ya asignado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            Else ' cambio de otra compañia
                Dim objCia1 As New Transportista
                objCia1.NRUCTR = objExisteTC.POS_RUC_ANTERIOR
                objCia1.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
                objCia1.CDVSN = cmbDivision.SelectedValue
                objCia1.CPLNDV = GetPlantaSeleccionada() ' cmbPlanta.SelectedValue
                objCia1.SESTRG = ""

                Dim olbeCia1 As New List(Of Transportista)
                olbeCia1 = objLogicaCia.Listar_Transportista(objCia1)
                If olbeCia1.Count = 0 Then Exit Sub
                objCia1 = olbeCia1.Item(0)


                Dim strMsg As String = "Conductor ya asignado a una compañía" & vbCrLf & _
                                        "Conductor: " & objExisteTC.CBRCNT & vbCrLf & _
                                        "Compañía: " & objCia1.TCMTRT & vbCrLf & _
                                        "¿Desea cambiarlo a la compañía " & txtRazonSocial.Text & " ?"

                If MsgBox(strMsg, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    objEntidadTC.FLAG_SKIPCHECKS = 1
                    objEntidadTC.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
                    objEntidadTC = objLogica.Registrar_TransportistaConductor(objEntidadTC)

                End If

            End If
        End If
    End Sub

#Region "TRANSPORTISTA"

    'Private Sub cargarComboTransportistaAS400()

    '    Dim obrTransportistaAS400_BLL As New TransportistaAS400_BLL
    '    With Me.cboTranspAS400
    '        .DataSource = Nothing
    '        .DataSource = HelpClass.GetDataSetNative(obrTransportistaAS400_BLL.Listar_TransportistaAS400(Me.cmbCompania.SelectedValue))
    '        .KeyField = "CTRSPT"
    '        .ValueField = "TCMTRT"
    '        .DataBind()
    '    End With

    'End Sub

    Private Sub Registrar_Transportista()
        Dim obj As New Transportista_BLL
        Dim objEntidad As New Transportista
        objEntidad.NRUCTR = Me.txtNroRuc.Text
        'If cboTranspAS400.Codigo.Equals("") Then
        '    objEntidad.CTRSPT = 0
        'Else
        '    objEntidad.CTRSPT = Integer.Parse(cboTranspAS400.Codigo)
        'End If

        If Val("" & txtCod_AS.Tag) = 0 Then
            objEntidad.CTRSPT = 0
        Else
            objEntidad.CTRSPT = Val("" & txtCod_AS.Tag)
        End If


        objEntidad.TCMTRT = Me.txtRazonSocial.Text
        objEntidad.TABTRT = Me.txtDescripcion.Text
        objEntidad.TDRCTR = Me.txtDireccionTransportista.Text
        objEntidad.TLFTRP = Me.txtTelefonoTransportista.Text
        objEntidad.SINDRC = IIf(Me.chkTercero.Checked, "T", "P")
        objEntidad.CUSCRT = MainModule.USUARIO
        objEntidad.FCHCRT = HelpClass.TodayNumeric
        objEntidad.HRACRT = HelpClass.NowNumeric
        objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CCMPN = Me.cmbCompania.SelectedValue
        objEntidad.CDVSN = Me.cmbDivision.SelectedValue
        objEntidad.CPLNDV = GetPlantaSeleccionada() ' Me.cmbPlanta.SelectedValue
        objEntidad.RUCPR2 = Me.txtCodigoSAP.Text




        objEntidad.CODRESPSEG = cmbPolizaSeguro.ComboBox.SelectedValue
        objEntidad.RESPSEG = cmbPolizaSeguro.ComboBox.Text.Trim
        objEntidad.PORSEGCARGA = txtPorSeguro.Text.Trim

      


        objEntidad = obj.Registrar_Transportista(objEntidad)

        If objEntidad.CTRSPT > 0 Then
            'cargarComboTransportistaAS400()

            gEnumOpcMan = Opcion.Neutral
            HabilitarBoton(TabTransportista.SelectedTab.Name, Opcion.Neutral)
            Listar_Transportista()
        End If


    End Sub

    Private Sub Modificar_Transportista()
        Dim objEntidad As New Transportista
        Dim obj As New Transportista_BLL

        objEntidad.NRUCTR = Me.txtNroRuc.Text

        'objEntidad.CTRSPT = cboTranspAS400.Codigo
        objEntidad.CTRSPT = Val("" & txtCod_AS.Tag)
        objEntidad.TCMTRT = Me.txtRazonSocial.Text
        objEntidad.TABTRT = Me.txtDescripcion.Text
        objEntidad.TDRCTR = Me.txtDireccionTransportista.Text
        objEntidad.TLFTRP = Me.txtTelefonoTransportista.Text
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        'objEntidad.NEWCTRSPT = cboTranspAS400.Codigo
        objEntidad.NEWCTRSPT = Val("" & txtCod_AS.Tag)
        objEntidad.SINDRC = IIf(Me.chkTercero.Checked, "T", "P")
        objEntidad.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
        objEntidad.RUCPR2 = Me.txtCodigoSAP.Text

        objEntidad.CODRESPSEG = cmbPolizaSeguro.ComboBox.SelectedValue
        objEntidad.RESPSEG = cmbPolizaSeguro.ComboBox.Text.Trim
        objEntidad.PORSEGCARGA = txtPorSeguro.Text.Trim


        objEntidad = obj.Modificar_Transportista(objEntidad)

        '8888:
        If objEntidad.CTRSPT > "0" Then
            gEnumOpcMan = Opcion.Neutral
            HabilitarBoton(TabTransportista.SelectedTab.Name, Opcion.Neutral)
            Listar_Transportista()
        End If


    End Sub

    Private Sub Eliminar_Transportista()
        Dim objEntidad As New Transportista
        Dim obj As New Transportista_BLL

        objEntidad.CTRSPT = Me.gwdDatos.CurrentRow.Cells("CTRSPT").Value
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value

        objEntidad = obj.Eliminar_Transportista(objEntidad)
        gEnumOpcMan = Opcion.Neutral
        HabilitarBoton(TabTransportista.SelectedTab.Name, Opcion.Neutral)
        Listar_Transportista()


    End Sub


    Private Sub Limpiar_Controles_Transportista()
        'cboTranspAS400.Limpiar()
        txtCod_AS.Text = ""
        txtCod_AS.Tag = "0"
        txtCodigoSAP.Text = ""
        txtNroRuc.Text = ""
        txtRazonSocial.Text = ""
        txtDescripcion.Text = ""
        txtDireccionTransportista.Text = ""
        txtTelefonoTransportista.Text = ""

        cmbPolizaSeguro.ComboBox.SelectedValue = ""
        txtPorSeguro.Text = "0.00"

 

        Me.HeaderDatos.ValuesPrimary.Heading = "Información de Transportista"
    End Sub

    Private Sub Estado_Controles_Transportista(ByVal lbool_Estado As Boolean)
        'Me.txtNroRuc.Enabled = lbool_Estado
        Me.txtNroRuc.ReadOnly = Not lbool_Estado

        'txtCodigoSAP.Enabled = lbool_Estado
        txtCodigoSAP.Enabled = False
        txtRazonSocial.Enabled = lbool_Estado
        txtDescripcion.Enabled = lbool_Estado
        txtDireccionTransportista.Enabled = lbool_Estado
        txtTelefonoTransportista.Enabled = lbool_Estado
        'cboTranspAS400.Enabled = lbool_Estado
        btnTransp_AS.Enabled = lbool_Estado
        chkTercero.Enabled = lbool_Estado
        chkTercero.Checked = lbool_Estado


        cmbPolizaSeguro.ComboBox.Enabled = lbool_Estado
        txtPorSeguro.Enabled = lbool_Estado

    End Sub

#End Region

#Region "VEHICULO POR TRANSPORTISTA"




    Private Sub Eliminar_VehiculoTransportista()
        Dim objEntidad As New TransportistaTracto
        Dim obj As New TransportistaTracto_BLL
        'Try
        objEntidad.NRUCTR = Me.txtNroRuc.Text
        objEntidad.NPLCUN = gwdResTractosTransportista.CurrentRow.Cells("NPLCUN").Value
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

        objEntidad.CCMPN = gwdResTractosTransportista.CurrentRow.Cells("CCMPN_VH").Value
        objEntidad.CDVSN = gwdResTractosTransportista.CurrentRow.Cells("CDVSN_VH").Value
        objEntidad.CPLNDV = gwdResTractosTransportista.CurrentRow.Cells("CPLNDV_VH").Value

        obj.Eliminar_TransportistaTracto(objEntidad)

        ucpagTracto.PageNumber = 1
        ListarTracto_x_Transportista()

        'Listar_ResumenVehiculos()

        'objEntidad = obj.Eliminar_TransportistaTracto(objEntidad)
        'If objEntidad.NRUCTR = 0 Then
        '    HelpClass.ErrorMsgBox()
        '    Exit Sub
        'Else
        '    Listar_ResumenVehiculos()
        'End If

    End Sub

    'Private Sub Listar_ResumenVehiculos()
    '    gwdResTractosTransportista.DataSource = Nothing
    '    Dim objEntidad As New TransportistaTracto
    '    Dim obj As New TransportistaTracto_BLL
    '    objEntidad.NRUCTR = txtNroRuc.Text
    '    If gwdDatos.CurrentCellAddress.Y < 0 Then Exit Sub
    '    objEntidad.CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
    '    objEntidad.CDVSN = cmbDivision.SelectedValue
    '    objEntidad.CPLNDV = GetPlantaSeleccionada() ' cmbPlanta.SelectedValue

    '    gwdResTractosTransportista.DataSource = obj.Listar_TractosPorTransportista(objEntidad)
    'End Sub

#End Region

#Region "ACOPLADO POR TRANSPORTISTA"


    Private Sub Eliminar_AcopladoTransportista()
        If gwdResAcopladosTransportista.CurrentRow.Cells("NPLCAC").Value.ToString.Trim <> "0" AndAlso _
           gwdResAcopladosTransportista.CurrentRow.Cells("NPLCAC").Value.ToString.Trim <> "" Then

            Dim objEntidad As New TransportistaAcoplado
            Dim obj As New TransportistaAcoplado_BLL

            objEntidad.NRUCTR = txtNroRuc.Text
            objEntidad.NPLCAC = gwdResAcopladosTransportista.CurrentRow.Cells("NPLCAC").Value
            objEntidad.CULUSA = MainModule.USUARIO
            objEntidad.FULTAC = HelpClass.TodayNumeric
            objEntidad.HULTAC = HelpClass.NowNumeric
            objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

            objEntidad.CCMPN = gwdResAcopladosTransportista.CurrentRow.Cells("CCMPN_AC").Value
            objEntidad.CDVSN = gwdResAcopladosTransportista.CurrentRow.Cells("CDVSN_AC").Value
            objEntidad.CPLNDV = gwdResAcopladosTransportista.CurrentRow.Cells("CPLNDV_AC").Value

            obj.Eliminar_TransportistaAcoplado(objEntidad)
            ucpag_acoplado.PageNumber = 1
            ListarAcoplados_x_Transportista()
            'Listar_ResumenAcoplados()

            'objEntidad = obj.Eliminar_TransportistaAcoplado(objEntidad)

            'If objEntidad.NRUCTR = "0" Then
            '    HelpClass.ErrorMsgBox()
            '    Exit Sub
            'Else
            '    Listar_ResumenAcoplados()
            'End If
        End If
    End Sub

    'Private Sub Listar_ResumenAcoplados()

    '    gwdResAcopladosTransportista.DataSource = Nothing
    '    Dim objEntidad As New TransportistaAcoplado
    '    Dim obj As New TransportistaAcoplado_BLL

    '    objEntidad.NRUCTR = txtNroRuc.Text
    '    objEntidad.CCMPN = Me.cmbCompania.SelectedValue
    '    objEntidad.CDVSN = Me.cmbDivision.SelectedValue
    '    objEntidad.CPLNDV = GetPlantaSeleccionada() ' Me.cmbPlanta.SelectedValue


    '    gwdResAcopladosTransportista.DataSource = obj.Listar_AcopladosPorTransportista(objEntidad)
    'End Sub

#End Region

#Region "CONDUCTORES POR TRANSPORTISTA"

    Private Sub Eliminar_ConductorTransportista()
        If gwdResConductoresTransportista.CurrentRow.Cells("CBRCNT").Value.ToString.Trim <> "0" And _
           gwdResConductoresTransportista.CurrentRow.Cells("CBRCNT").Value.ToString.Trim <> "" Then

            Dim objEntidad As New TransportistaConductor
            Dim obj As New TransportistaConductor_BLL

            objEntidad.NRUCTR = txtNroRuc.Text
            objEntidad.CBRCNT = gwdResConductoresTransportista.CurrentRow.Cells("CBRCNT").Value
            objEntidad.CULUSA = MainModule.USUARIO
            objEntidad.FULTAC = HelpClass.TodayNumeric
            objEntidad.HULTAC = HelpClass.NowNumeric
            objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            objEntidad.CCMPN = gwdResConductoresTransportista.CurrentRow.Cells("CCMPN_C").Value
            objEntidad.CDVSN = gwdResConductoresTransportista.CurrentRow.Cells("CDVSN_C").Value
            objEntidad.CPLNDV = gwdResConductoresTransportista.CurrentRow.Cells("CPLNDV_C").Value

            'objEntidad = obj.Eliminar_TransportistaConductor(objEntidad)
            obj.Eliminar_TransportistaConductor(objEntidad)

            ucpag_conductor.PageNumber = 1
            Listar_Conductor_x_Transportista()
            'Listar_ResumenConductores()

            'If objEntidad.NRUCTR = "0" Then
            '    HelpClass.ErrorMsgBox()
            '    Exit Sub
            'Else
            '    Listar_ResumenConductores()
            'End If
        End If
    End Sub

    'Private Sub Listar_ResumenConductores()
    '    Dim objEntidad As New TransportistaConductor
    '    Dim obj As New TransportistaConductor_BLL
    '    gwdResConductoresTransportista.DataSource = Nothing
    '    objEntidad.NRUCTR = txtNroRuc.Text
    '    objEntidad.CCMPN = Me.cmbCompania.SelectedValue
    '    objEntidad.CDVSN = Me.cmbDivision.SelectedValue
    '    objEntidad.CPLNDV = GetPlantaSeleccionada() ' Me.cmbPlanta.SelectedValue

    '    gwdResConductoresTransportista.DataSource = obj.Listar_ConductoresPorTransportista(objEntidad)
    'End Sub

#End Region







    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Try
            gEnumOpcMan = Opcion.Neutral
            HabilitarBoton(TabTransportista.SelectedTab.Name, Opcion.Neutral)

            Asignar_Datos()
 

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Try
            If gwdDatos.CurrentRow Is Nothing Then
                Exit Sub
            End If

            Dim lstr_PestanaActiva As String = Me.TabTransportista.SelectedTab.Name
            Dim estado As String = ("" & gwdDatos.CurrentRow.Cells("SESTRG").Value).ToString.Trim
            If estado = "*" Then
                MessageBox.Show("No se puede eliminar el transportista. El transportista ya se encuentra eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If



            Dim TieneDetalle As Boolean = False

            Select Case lstr_PestanaActiva
                Case "TabDatosTransportista"

                    If MessageBox.Show("Desea eliminar este registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                        If Me.txtNroRuc.Text <> "" Then
                            'se verifica si el transportista tiene registros relacionados
                            Dim Transportista_BLL As New Transportista_BLL
                            Dim CTRSPT As Decimal = gwdDatos.CurrentRow.Cells("CTRSPT").Value
                            Dim CCMPN As String = gwdDatos.CurrentRow.Cells("CCMPN").Value
                            Dim numMov As Int32 = Transportista_BLL.VerificarMovimientoTransportista(CTRSPT, CCMPN)
                            If numMov > 0 Then
                                MessageBox.Show("El transportista no puede ser eliminado.Tiene liquidaciones asociados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Exit Sub
                            End If
                            TieneDetalle = (gwdResTractosTransportista.Rows.Count > 0) OrElse (gwdResAcopladosTransportista.Rows.Count > 0) OrElse (gwdResConductoresTransportista.Rows.Count > 0)

                            If TieneDetalle = True Then
                                If MsgBox("Este transportista tiene asignado vehículos, acoplados y/o conductores. Confirma que desea eliminarlo?", MsgBoxStyle.OkCancel, "Eliminar") = MsgBoxResult.Ok Then
                                    Eliminar_Transportista()

                                Else
                                    Exit Sub
                                End If
                            Else 'no tiene registros relacionados
                                Eliminar_Transportista()

                            End If
                        End If

                    End If

                Case "TabVehiculos"
                    If gwdResTractosTransportista.Rows.Count > 0 Then
                        If MessageBox.Show("Desea eliminar este registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                            Eliminar_VehiculoTransportista()

                        End If
                    End If
                Case "TabAcoplados"
                    If gwdResAcopladosTransportista.Rows.Count > 0 Then
                        If MessageBox.Show("Desea eliminar este registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                            Eliminar_AcopladoTransportista()

                        End If
                    End If
                Case "TabConductores"
                    If gwdResConductoresTransportista.Rows.Count > 0 Then
                        If MessageBox.Show("Desea eliminar este registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                            Eliminar_ConductorTransportista()

                        End If
                    End If
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try




    End Sub



    Private Sub Asignar_Datos()
        Dim lint_indice As Integer = Me.gwdDatos.CurrentCellAddress.Y

        Limpiar_Controles_Transportista()

        If gwdDatos.CurrentRow IsNot Nothing Then

            txtCodigoSAP.Text = Me.gwdDatos.Item("RUCPR2", lint_indice).Value

            'cboTranspAS400.Codigo = Me.gwdDatos.Item("CTRSPT", lint_indice).Value
            If gwdDatos.Item("CTRSPT_AS", lint_indice).Value > 0 Then
                txtCod_AS.Text = gwdDatos.Item("CTRSPT_AS", lint_indice).Value & " - " & ("" & gwdDatos.Item("TRANSPORTISTA_AS", lint_indice).Value).ToString.Trim
                txtCod_AS.Tag = gwdDatos.Item("CTRSPT_AS", lint_indice).Value
            Else
                txtCod_AS.Text = ""
                txtCod_AS.Tag = "0"
            End If


            txtNroRuc.Text = Me.gwdDatos.Item("NRUCTR", lint_indice).Value.ToString().Trim()
            txtRazonSocial.Text = Me.gwdDatos.Item("TCMTRT", lint_indice).Value.ToString().Trim()
            txtDescripcion.Text = Me.gwdDatos.Item("TABTRT", lint_indice).Value.ToString().Trim()
            txtDireccionTransportista.Text = Me.gwdDatos.Item("TDRCTR", lint_indice).Value.ToString().Trim()
            txtTelefonoTransportista.Text = Me.gwdDatos.Item("TLFTRP", lint_indice).Value.ToString().Trim()
            Me.HeaderDatos.ValuesPrimary.Heading = "Información de transportista / Razón Social: " & txtRazonSocial.Text & "; RUC: " & txtNroRuc.Text.Trim
            chkTercero.Checked = Me.gwdDatos.Item("SINDRC", lint_indice).Value.ToString().Trim().ToUpper.Equals("T")


            cmbPolizaSeguro.ComboBox.SelectedValue = gwdDatos.Item("CODRESPSEG", lint_indice).Value.ToString().Trim()
            txtPorSeguro.Text = gwdDatos.Item("PORSEGCARGA", lint_indice).Value



        End If



    End Sub









    Private Sub txtNroRuc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroRuc.KeyPress, txtCodigoSAP.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8, 13
            Case Else : e.Handled = True
        End Select
    End Sub

    Private Sub txtFiltroTransportista_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFiltroTransportista.KeyDown
        Try
            Select Case e.KeyCode

                Case Keys.Enter : Listar_Transportista()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub



    Private Sub TabTransportista_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabTransportista.SelectedIndexChanged

        Try
            If TabSeleccionado <> TabTransportista.SelectedTab.Name Then
                If (gEnumOpcMan = Opcion.Modificar Or gEnumOpcMan = Opcion.Nuevo) Then
                    TabTransportista.SelectTab(TabSeleccionado)
                    MessageBox.Show("Debe guardar o cancelar la acción", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                ElseIf gEnumOpcMan = Opcion.Neutral Then
                    HabilitarBoton(TabTransportista.SelectedTab.Name, Opcion.Neutral)
                End If
            End If
            TabSeleccionado = TabTransportista.SelectedTab.Name
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub





    'Private Sub gwdResAcopladosTransportista_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdResAcopladosTransportista.CellContentDoubleClick
    '    If e.RowIndex < 0 OrElse gwdResAcopladosTransportista.CurrentCellAddress.Y < 0 Then
    '        Exit Sub
    '    End If

    '    Try
    '        If "NPLCAC" = gwdResAcopladosTransportista.Columns(gwdResAcopladosTransportista.CurrentCellAddress.X).Name Then
    '            Dim NPLCAC As Object = gwdResAcopladosTransportista.Item("NPLCAC", gwdResAcopladosTransportista.CurrentCellAddress.Y).Value
    '            If NPLCAC IsNot Nothing AndAlso NPLCAC IsNot DBNull.Value Then
    '                Dim f As New frmInformacionAcoplado(NPLCAC.ToString)
    '                f.CCMPN = cmbCompania.SelectedValue.ToString()
    '                f.ShowForm(Me)
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try



    'End Sub



    'Private Sub gwdResConductoresTransportista_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdResConductoresTransportista.CellContentDoubleClick
    '    If e.RowIndex < 0 OrElse gwdResConductoresTransportista.CurrentCellAddress.Y < 0 Then
    '        Exit Sub
    '    End If

    '    Try
    '        If "CBRCNT" = gwdResConductoresTransportista.Columns(gwdResConductoresTransportista.CurrentCellAddress.X).Name Then
    '            Dim lstr_CBRCNT As Object = gwdResConductoresTransportista.Item("CBRCNT", gwdResConductoresTransportista.CurrentCellAddress.Y).Value
    '            If lstr_CBRCNT IsNot Nothing AndAlso lstr_CBRCNT IsNot DBNull.Value Then
    '                Dim f As New frmInformacionChofer(lstr_CBRCNT.ToString)
    '                f.CCMPN = cmbCompania.SelectedValue.ToString()
    '                f.ShowForm(Me)
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try


    'End Sub





    Private Function AgregarDT(ByVal dt As DataTable, ByVal dtName As String) As DataTable
        dt.TableName = dtName
        Return dt
    End Function





    'Private Sub gwdResTractosTransportista_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdResTractosTransportista.CellContentDoubleClick
    '    If e.RowIndex < 0 OrElse gwdResTractosTransportista.CurrentCellAddress.Y < 0 Then
    '        Exit Sub
    '    End If
    '    Try

    '        Dim CCMPN As String = cmbCompania.SelectedValue.ToString()
    '        If "NPLCUN" = gwdResTractosTransportista.Columns(gwdResTractosTransportista.CurrentCellAddress.X).Name Then
    '            Dim NPLCUN As Object
    '            NPLCUN = gwdResTractosTransportista.Item("NPLCUN", gwdResTractosTransportista.CurrentCellAddress.Y).Value
    '            If NPLCUN IsNot DBNull.Value AndAlso NPLCUN IsNot Nothing Then
    '                Dim f As New frmInformacionTracto(NPLCUN.ToString)
    '                f.CCMPN = CCMPN
    '                f.ShowForm(Me)
    '            End If

    '        ElseIf "NPLACP" = gwdResTractosTransportista.Columns(gwdResTractosTransportista.CurrentCellAddress.X).Name Then
    '            Dim NPLACP As Object
    '            NPLACP = gwdResTractosTransportista.Item("NPLACP", gwdResTractosTransportista.CurrentCellAddress.Y).Value
    '            If NPLACP IsNot DBNull.Value AndAlso NPLACP IsNot Nothing AndAlso NPLACP <> vbNullString Then
    '                Dim f As New frmInformacionAcoplado(NPLACP.ToString)
    '                f.CCMPN = CCMPN
    '                f.ShowForm(Me)
    '            End If

    '        ElseIf "CBRCND" = gwdResTractosTransportista.Columns(gwdResTractosTransportista.CurrentCellAddress.X).Name Then
    '            Dim CBRCND As Object
    '            CBRCND = gwdResTractosTransportista.Item("CBRCND", gwdResTractosTransportista.CurrentCellAddress.Y).Value
    '            If CBRCND IsNot DBNull.Value AndAlso CBRCND IsNot Nothing Then
    '                Dim f As New frmInformacionChofer(CBRCND.ToString)
    '                f.CCMPN = CCMPN
    '                f.ShowForm(Me)
    '            End If

    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
    '    End Try


    'End Sub

    Private Sub ButtonSpecHeaderGroup1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSpecHeaderGroup1.Click
        gwdDatos.Visible = Not gwdDatos.Visible
        Select Case HeaderDatos.Dock
            Case DockStyle.Fill
                HeaderDatos.Dock = DockStyle.Bottom
                ButtonSpecHeaderGroup1.Image = My.Resources.UP
            Case DockStyle.Bottom
                HeaderDatos.Dock = DockStyle.Fill
                ButtonSpecHeaderGroup1.Image = My.Resources.DOWN
        End Select
    End Sub



    Private Sub btnImprimirTRTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirTRTodos.Click

        Try
            Dim objEntidad As New Transportista
            Me.Cursor = Cursors.WaitCursor
            Dim objPrintForm As New PrintForm
            Dim oDs As New DataSet
            Dim oDt As DataTable
            Dim objReporte As New rptListaTransportista
            Dim objLogical As New Transportista_BLL
            objEntidad.NRUCTR = Me.txtFiltroTransportista.Text
            objEntidad.CCMPN = Me.cmbCompania.SelectedValue
            objEntidad.CDVSN = Me.cmbDivision.SelectedValue
            objEntidad.CPLNDV = GetPlantaSeleccionada() ' Me.cmbPlanta.SelectedValue
            Dim estado_trans As String = cboEstado.SelectedValue
            Select Case estado_trans
                Case "1"
                    objEntidad.SESTRG = "A"
                Case "2"
                    objEntidad.SESTRG = "*"
            End Select

            objEntidad.SINDRC = cboTipo.SelectedValue
            'oDt = HelpClass.GetDataSetNative(objLogical.Listar_Transportista_Por_Tipo(objEntidad))
            If oDt.Rows.Count = 0 Then
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
            oDt.TableName = "TRANSPORTISTA"
            oDs.Tables.Add(oDt.Copy)
            objReporte.SetDataSource(oDs)
            objPrintForm.ShowForm(objReporte, Me)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarExcel.Click


        '****************** EXPORTAR TRANSPORTISTA  ****************  

        Dim NPOI_SC As New Ransa.Utilitario.HelpClass_NPOI_SC
        Dim Data_Transportista As New List(Of Transportista)
        Data_Transportista = gwdDatos.DataSource

        If Data_Transportista Is Nothing Then
            Exit Sub
        End If

        Dim dtExcel_Transportista As New DataTable
        Dim dr1 As DataRow

        dtExcel_Transportista.Columns.Add("CTRSPT").Caption = NPOI_SC.FormatDato("Código", NPOI_SC.keyDatoTexto)
        dtExcel_Transportista.Columns.Add("RUCPR2").Caption = NPOI_SC.FormatDato("Código SAP", NPOI_SC.keyDatoTexto)
        dtExcel_Transportista.Columns.Add("NRUCTR").Caption = NPOI_SC.FormatDato("RUC", NPOI_SC.keyDatoTexto)
        dtExcel_Transportista.Columns.Add("TCMTRT").Caption = NPOI_SC.FormatDato("Razón social", NPOI_SC.keyDatoTexto)
        dtExcel_Transportista.Columns.Add("TLFTRP").Caption = NPOI_SC.FormatDato("Teléfono", NPOI_SC.keyDatoTexto)
        dtExcel_Transportista.Columns.Add("TDRCTR").Caption = NPOI_SC.FormatDato("Dirección", NPOI_SC.keyDatoTexto)
        'dtExcel_Transportista.Columns.Add("TRACTOS_ASIGNADOS").Caption = NPOI_SC.FormatDato("Tractos Asignados", NPOI_SC.keyDatoFecha)
        'dtExcel_Transportista.Columns.Add("ACOPLADOS_ASIGNADOS").Caption = NPOI_SC.FormatDato("Acoplados Asignados", NPOI_SC.keyDatoFecha)
        'dtExcel_Transportista.Columns.Add("CHOFERES_ASIGNADOS").Caption = NPOI_SC.FormatDato("Choferes Asignados", NPOI_SC.keyDatoFecha)
        dtExcel_Transportista.Columns.Add("SESTRG").Caption = NPOI_SC.FormatDato("Estado", NPOI_SC.keyDatoFecha)

        For Each fila As Transportista In Data_Transportista
            dr1 = dtExcel_Transportista.NewRow

            dr1("CTRSPT") = fila.CTRSPT
            dr1("NRUCTR") = fila.NRUCTR
            dr1("TCMTRT") = fila.TCMTRT
            dr1("TLFTRP") = fila.TLFTRP
            dr1("TDRCTR") = fila.TDRCTR
            dr1("RUCPR2") = ("" & fila.RUCPR2).Trim
            'dr1("TRACTOS_ASIGNADOS") = fila.TRACTOS_ASIGNADOS
            'dr1("ACOPLADOS_ASIGNADOS") = fila.ACOPLADOS_ASIGNADOS
            'dr1("CHOFERES_ASIGNADOS") = fila.CHOFERES_ASIGNADOS
            dr1("SESTRG") = fila.SESTRG

            dtExcel_Transportista.Rows.Add(dr1)

        Next


        Dim ListaDatatable As New List(Of DataTable)
        Dim ListaTitulos As New List(Of String)

        Dim oLisFiltro As New List(Of SortedList)
        Dim F As New SortedList
        F.Add(0, "Compañia:| " & cmbCompania.Text)
        F.Add(1, "División:|" & cmbDivision.Text)
        'F.Add(2, "Planta:| " & cmbPlanta.Text)

        dtExcel_Transportista.TableName = "TRANSPORTISTA"
        ListaDatatable.Add(dtExcel_Transportista.Copy)
        ListaTitulos.Add("TRANSPORTISTAS")
        oLisFiltro.Add(F)

        NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListaTitulos, Nothing, oLisFiltro, 0)




    End Sub
    'Private Function Grilla_SetDatasource() As DataTable
    '    Dim dtExportarExcel As New DataTable
    '    Crear_Estructura_Reporte_Transportista(dtExportarExcel)
    '    Dim dr As DataRow
    '    For i As Integer = 0 To Me.gwdDatos.Rows.Count - 1
    '        dr = dtExportarExcel.NewRow
    '        dr("NRUCTR") = Me.gwdDatos.Item("NRUCTR", i).Value
    '        dr("TCMTRT") = Me.gwdDatos.Item("TCMTRT", i).Value
    '        dr("TABTRT") = Me.gwdDatos.Item("TABTRT", i).Value
    '        dr("TLFTRP") = Me.gwdDatos.Item("TLFTRP", i).Value
    '        dr("TDRCTR") = Me.gwdDatos.Item("TDRCTR", i).Value
    '        dr("SINDRC") = Me.gwdDatos.Item("SINDRC", i).Value
    '        dr("TRACTOS_ASIGNADOS") = Me.gwdDatos.Item("TRACTOS_ASIGNADOS", i).Value
    '        dr("ACOPLADOS_ASIGNADOS") = Me.gwdDatos.Item("ACOPLADOS_ASIGNADOS", i).Value
    '        dr("CHOFERES_ASIGNADOS") = Me.gwdDatos.Item("CHOFERES_ASIGNADOS", i).Value
    '        Dim objNegocio As New Solicitud_Transporte_BLL
    '        Dim objHashTable As New Hashtable
    '        objHashTable.Add("CCMPN", Me.cmbCompania.SelectedValue)
    '        objHashTable.Add("NRUCTR", Me.gwdDatos.Item("NRUCTR", i).Value)
    '        objHashTable.Add("FECVRF", Format(Date.Today, "yyyyMMdd"))
    '        Dim strRESULTADO As String = objNegocio.Obtener_Validacion_Homologacion_Proveedor(objHashTable)
    '        dr("ESTADO_HOMOLOGACION") = IIf(strRESULTADO.Trim = "", "Apto", strRESULTADO.Trim)
    '        dtExportarExcel.Rows.Add(dr)
    '    Next
    '    Return dtExportarExcel

    'End Function
    'Private Sub Crear_Estructura_Reporte_Transportista(ByRef poDt As DataTable)
    '    poDt.Columns.Add(New DataColumn("NRUCTR", GetType(System.String)))  'Compañia
    '    poDt.Columns.Add(New DataColumn("TCMTRT", GetType(System.String))) 'Tipo de Documento
    '    poDt.Columns.Add(New DataColumn("TABTRT", GetType(System.String))) 'Numero de Documento
    '    poDt.Columns.Add(New DataColumn("TLFTRP", GetType(System.String))) 'Indice de Renovacion = 0
    '    poDt.Columns.Add(New DataColumn("TDRCTR", GetType(System.String))) 'Correlativo del Detalle
    '    poDt.Columns.Add(New DataColumn("SINDRC", GetType(System.String))) 'Servicio
    '    poDt.Columns.Add(New DataColumn("TRACTOS_ASIGNADOS", GetType(System.String))) 'Flag tipo control = ""
    '    poDt.Columns.Add(New DataColumn("ACOPLADOS_ASIGNADOS", GetType(System.String))) 'Unidad del Servicio
    '    poDt.Columns.Add(New DataColumn("CHOFERES_ASIGNADOS", GetType(System.String))) 'Cantidad del Servicio
    '    poDt.Columns.Add(New DataColumn("ESTADO_HOMOLOGACION", GetType(System.String))) 'Moneda de la Tarifa        
    'End Sub
    Private Sub btnImprimirTR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirTR.Click


        Try
            If Me.gwdDatos.Rows.Count > 0 AndAlso Me.gwdDatos.CurrentCellAddress.Y >= 0 Then

                Dim f As New frmOpRptTransportista(Me.gwdDatos.Item("NRUCTR", Me.gwdDatos.CurrentCellAddress.Y).Value)
                f.StartPosition = FormStartPosition.CenterScreen
                With f
                    .CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
                    .CDVSN = Me.gwdDatos.CurrentRow.Cells("CDVSN").Value
                    .CPLNDV = Me.gwdDatos.CurrentRow.Cells("CPLNDV").Value
                    .Show(Me)
                End With


            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Function Validar_Proveedor_Homologado() As String
        Dim objNegocio As New Solicitud_Transporte_BLL
        Dim objHashTable As New Hashtable
        objHashTable.Add("CCMPN", Me.cmbCompania.SelectedValue)
        objHashTable.Add("NRUCTR", Me.gwdDatos.Item("NRUCTR", Me.gwdDatos.CurrentCellAddress.Y).Value)
        objHashTable.Add("FECVRF", Format(Date.Today, "yyyyMMdd"))
        Return objNegocio.Obtener_Validacion_Homologacion_Proveedor(objHashTable)
    End Function

    Private Sub gwdDatos_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellDoubleClick
        Try
            'If e.ColumnIndex = 14 Then
            If gwdDatos.Columns(e.ColumnIndex).Name = "ESTADO_HOMOLOGACION" Then
                'ESTADO_HOMOLOGACION
                Dim strResultado As String = Validar_Proveedor_Homologado()
                If strResultado.Trim = "" Then
                    strResultado = "Apto"
                    Me.gwdDatos.Item("ESTADO_HOMOLOGACION", gwdDatos.CurrentCellAddress.Y).Value = My.Resources.button_ok1
                Else
                    Me.gwdDatos.Item("ESTADO_HOMOLOGACION", gwdDatos.CurrentCellAddress.Y).Value = My.Resources.button_cancel
                End If
                HelpClass.MsgBox("Estado Homologación : " & strResultado, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub





    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            Select Case TabTransportista.SelectedTab.Name
                Case "TabDatosTransportista"
                    If gwdDatos.CurrentRow Is Nothing Then
                        Exit Sub
                    End If
                    Dim estado As String = ("" & gwdDatos.CurrentRow.Cells("SESTRG").Value).ToString.Trim
                    If estado = "*" Then
                        MessageBox.Show("No se puede modificar el transportista. El transportista está anulado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                    gEnumOpcMan = Opcion.Modificar

                    HabilitarBoton(TabTransportista.SelectedTab.Name, Opcion.Modificar)
                    'Me.txtNroRuc.Enabled = False
                    Me.txtNroRuc.ReadOnly = True
                    'txtCodigoSAP.Enabled = True
                    txtCodigoSAP.Enabled = False
                    txtRazonSocial.Enabled = True
                    txtDescripcion.Enabled = True
                    txtDireccionTransportista.Enabled = True
                    txtTelefonoTransportista.Enabled = True
                    'cboTranspAS400.Enabled = True
                    btnTransp_AS.Enabled = True
                    chkTercero.Enabled = False
                    chkTercero.Checked = True


                    cmbPolizaSeguro.ComboBox.Enabled = True
                    txtPorSeguro.Enabled = True

            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    
    Private Sub Listar_Transportista()
        Me.gwdDatos.DataSource = Nothing
        gwdResTractosTransportista.DataSource = Nothing
        gwdResAcopladosTransportista.DataSource = Nothing
        gwdResConductoresTransportista.DataSource = Nothing
        Limpiar_Controles_Transportista()

        Dim obj As New Transportista_BLL
        Dim objEntidad As New Transportista
        objEntidad.CCMPN = Me.cmbCompania.SelectedValue
        objEntidad.CDVSN = Me.cmbDivision.SelectedValue
        objEntidad.CPLNDV = GetPlantaSeleccionada() ' Me.cmbPlanta.SelectedValue
        objEntidad.TCMTRT = Me.txtFiltroTransportista.Text.Trim.ToUpper
        objEntidad.NRUCTR = txtruc.Text.Trim.ToUpper

        objEntidad.SINDRC = "T" ' cboTipo.SelectedValue

        Dim estado_trans As String = cboEstado.SelectedValue
        Select Case estado_trans
            Case "1"
                objEntidad.SESTRG = "A"
            Case "2"
                objEntidad.SESTRG = "*"
        End Select

        ' IN_NROPAG As Decimal, PAGESIZE As Decimal, ByRef TOTPAG As Decimal
        Dim totalPaginas As Decimal = 0
        Dim oList As New List(Of ENTIDADES.mantenimientos.Transportista)
        oList = obj.Listar_Transportista_Por_Tipo(objEntidad, UcPaginacion1.PageNumber, UcPaginacion1.PageSize, totalPaginas)
        UcPaginacion1.PageCount = totalPaginas
        Me.gwdDatos.DataSource = oList

      
    End Sub


    Private Sub btnBusqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusqueda.Click

        Try
            UcPaginacion1.PageNumber = 1
            gEnumOpcMan = Opcion.Neutral
            HabilitarBoton(TabTransportista.SelectedTab.Name, Opcion.Neutral)
            Listar_Transportista()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub gwdDatos_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gwdDatos.SelectionChanged
        Try
            
            gEnumOpcMan = Opcion.Neutral
            HabilitarBoton(TabTransportista.SelectedTab.Name, Opcion.Neutral)
           
            Asignar_Datos()
          
            Buscar_Filtro_Vehiculo(Nothing, Nothing)
            Buscar_Filtro_Acoplado(Nothing, Nothing)
            Buscar_Filtro_Brevete(Nothing, Nothing)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Exportar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarDetalle.Click

        Try

            '****************** EXPORTAR VEHÍCULOS  ****************  

            Dim NPOI_SC As New Ransa.Utilitario.HelpClass_NPOI_SC
            Dim Data_Vehiculo As New DataTable
            Data_Vehiculo = gwdResTractosTransportista.DataSource

            Dim dtExcel_Vehiculo As New DataTable
            Dim dr1 As DataRow

            dtExcel_Vehiculo.Columns.Add("NPLCUN").Caption = NPOI_SC.FormatDato("Placa Vehículo", NPOI_SC.keyDatoTexto)
            dtExcel_Vehiculo.Columns.Add("TMRCTR").Caption = NPOI_SC.FormatDato("Marca", NPOI_SC.keyDatoTexto)
            dtExcel_Vehiculo.Columns.Add("NEJSUN").Caption = NPOI_SC.FormatDato("Ejes", NPOI_SC.keyDatoTexto)
            dtExcel_Vehiculo.Columns.Add("NPLACP").Caption = NPOI_SC.FormatDato("Placa Acoplado", NPOI_SC.keyDatoTexto)
            dtExcel_Vehiculo.Columns.Add("CBRCND").Caption = NPOI_SC.FormatDato("Brevete Conductor", NPOI_SC.keyDatoTexto)
            dtExcel_Vehiculo.Columns.Add("NOMCHOFER").Caption = NPOI_SC.FormatDato("Nombre Conductor", NPOI_SC.keyDatoTexto)
            dtExcel_Vehiculo.Columns.Add("FECINI").Caption = NPOI_SC.FormatDato("Fec. Ini. Asignación", NPOI_SC.keyDatoFecha)
            dtExcel_Vehiculo.Columns.Add("FECFIN").Caption = NPOI_SC.FormatDato("Fec. Fin  Asignación", NPOI_SC.keyDatoFecha)
            dtExcel_Vehiculo.Columns.Add("SESTCM").Caption = NPOI_SC.FormatDato("Estado Asignación", NPOI_SC.keyDatoTexto)
            dtExcel_Vehiculo.Columns.Add("TOBS_VH").Caption = NPOI_SC.FormatDato("Observaciones", NPOI_SC.keyDatoTexto)

            For Each fila As DataRow In Data_Vehiculo.Rows
                dr1 = dtExcel_Vehiculo.NewRow

                dr1("NPLCUN") = fila("NPLCUN")
                dr1("TMRCTR") = fila("TMRCTR").ToString.Trim
                dr1("NEJSUN") = fila("NEJSUN")
                dr1("NPLACP") = fila("NPLACP")
                dr1("CBRCND") = fila("CBRCND")
                dr1("NOMCHOFER") = fila("NOMCHOFER")
                dr1("FECINI") = fila("FECINI")
                dr1("FECFIN") = fila("FECFIN")
                dr1("SESTCM") = fila("SESTCM")
                dr1("TOBS_VH") = fila("TOBS").ToString.Trim

                dtExcel_Vehiculo.Rows.Add(dr1)

            Next

            '*****************  EXPORTAR ACOPLADOS  ************************

            Dim Data_Acoplado As New List(Of TransportistaAcoplado)
            Data_Acoplado = gwdResAcopladosTransportista.DataSource

            Dim dtExcel_Acoplado As New DataTable
            Dim dr2 As DataRow

            dtExcel_Acoplado.Columns.Add("NPLCAC").Caption = NPOI_SC.FormatDato("Placa Acoplado", NPOI_SC.keyDatoTexto)
            dtExcel_Acoplado.Columns.Add("TMRCVH").Caption = NPOI_SC.FormatDato("Marca", NPOI_SC.keyDatoTexto)
            dtExcel_Acoplado.Columns.Add("NEJSUN").Caption = NPOI_SC.FormatDato("Ejes", NPOI_SC.keyDatoTexto)
            dtExcel_Acoplado.Columns.Add("FECINI").Caption = NPOI_SC.FormatDato("Fec. Ini. Asignación", NPOI_SC.keyDatoFecha)
            dtExcel_Acoplado.Columns.Add("FECFIN").Caption = NPOI_SC.FormatDato("Fec. Fin. Asignación", NPOI_SC.keyDatoFecha)
            dtExcel_Acoplado.Columns.Add("SESTAC").Caption = NPOI_SC.FormatDato("Estado Asignación", NPOI_SC.keyDatoTexto)
            dtExcel_Acoplado.Columns.Add("TOBS").Caption = NPOI_SC.FormatDato("Observaciones", NPOI_SC.keyDatoTexto)

            For Each fila As TransportistaAcoplado In Data_Acoplado
                dr2 = dtExcel_Acoplado.NewRow

                dr2("NPLCAC") = fila.NPLCAC
                dr2("TMRCVH") = fila.TMRCVH.ToString.Trim
                dr2("NEJSUN") = fila.NEJSUN
                dr2("FECINI") = fila.FECINI
                dr2("FECFIN") = fila.FECFIN
                dr2("SESTAC") = fila.SESTAC
                dr2("TOBS") = fila.TOBS.ToString.Trim

                dtExcel_Acoplado.Rows.Add(dr2)

            Next

            '*****************  EXPORTAR CONDUCTORES  ************************

            Dim Data_Conductor As New List(Of TransportistaConductor)
            Data_Conductor = gwdResConductoresTransportista.DataSource

            Dim dtExcel_Conductor As New DataTable
            Dim dr3 As DataRow

            dtExcel_Conductor.Columns.Add("CBRCNT").Caption = NPOI_SC.FormatDato("Brevete", NPOI_SC.keyDatoTexto)
            dtExcel_Conductor.Columns.Add("TNMCMC").Caption = NPOI_SC.FormatDato("Nombres", NPOI_SC.keyDatoTexto)
            dtExcel_Conductor.Columns.Add("TAPPAC").Caption = NPOI_SC.FormatDato("A Paterno", NPOI_SC.keyDatoTexto)
            dtExcel_Conductor.Columns.Add("TAPMAC").Caption = NPOI_SC.FormatDato("A Materno", NPOI_SC.keyDatoTexto)
            dtExcel_Conductor.Columns.Add("FECINI").Caption = NPOI_SC.FormatDato("Fec. Ini. Asignación", NPOI_SC.keyDatoFecha)
            dtExcel_Conductor.Columns.Add("FECFIN").Caption = NPOI_SC.FormatDato("Fec. Fin. Asignación", NPOI_SC.keyDatoFecha)
            dtExcel_Conductor.Columns.Add("SESTCH").Caption = NPOI_SC.FormatDato("Estado Asignación", NPOI_SC.keyDatoTexto)
            dtExcel_Conductor.Columns.Add("TOBS").Caption = NPOI_SC.FormatDato("Observaciones", NPOI_SC.keyDatoTexto)

            For Each fila As TransportistaConductor In Data_Conductor
                dr3 = dtExcel_Conductor.NewRow

                dr3("CBRCNT") = fila.CBRCNT
                dr3("TNMCMC") = fila.TNMCMC.ToString.Trim
                dr3("TAPPAC") = fila.TAPPAC.ToString.Trim
                dr3("TAPMAC") = fila.TAPMAC.ToString.Trim
                dr3("FECINI") = fila.FECINI
                dr3("FECFIN") = fila.FECFIN
                dr3("SESTCH") = fila.SESTCH
                dr3("TOBS") = fila.TOBS.ToString.Trim
                dtExcel_Conductor.Rows.Add(dr3)

            Next

            Dim ListaDatatable As New List(Of DataTable)
            Dim ListaTitulos As New List(Of String)

            Dim oLisFiltro As New List(Of SortedList)
            Dim F As New SortedList
            F.Add(0, "Compañia:| " & cmbCompania.Text)
            F.Add(1, "División:|" & cmbDivision.Text)
            'F.Add(2, "Planta:| " & cmbPlanta.Text)
            F.Add(3, "Transportista:| " & Me.gwdDatos.CurrentRow.Cells("NRUCTR").Value & " - " & Me.gwdDatos.CurrentRow.Cells("TCMTRT").Value)

            If dtExcel_Vehiculo.Rows.Count > 0 Then
                dtExcel_Vehiculo.TableName = "VEHÍCULOS_ASIGNADOS"
                ListaDatatable.Add(dtExcel_Vehiculo.Copy)
                ListaTitulos.Add("VEHÍCULOS ASIGNADOS")
                oLisFiltro.Add(F)
            End If

            If dtExcel_Acoplado.Rows.Count > 0 Then
                dtExcel_Acoplado.TableName = "ACOPLADOS_ASIGNADOS"
                ListaDatatable.Add(dtExcel_Acoplado.Copy)
                ListaTitulos.Add("ACOPLADOS ASIGNADOS")
                oLisFiltro.Add(F)
            End If

            If dtExcel_Conductor.Rows.Count > 0 Then
                dtExcel_Conductor.TableName = "CONDUCTORES_ASIGNADOS"
                ListaDatatable.Add(dtExcel_Conductor.Copy)
                ListaTitulos.Add("CONDUCTORES ASIGNADOS")
                oLisFiltro.Add(F)
            End If

            If ListaDatatable.Count = 0 Then
                Exit Sub
            End If

            NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListaTitulos, Nothing, oLisFiltro, 0)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub Buscar_Filtro_Vehiculo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarFiltroVehiculo.Click

        Try
            ucpagTracto.PageNumber = 1
            ListarTracto_x_Transportista()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub ListarTracto_x_Transportista()
        gwdResTractosTransportista.DataSource = Nothing
        Dim objEntidad As New TransportistaTracto
        Dim Lista As New DataTable
        Dim obj As New TransportistaTracto_BLL
        If gwdDatos.CurrentRow Is Nothing Then
            Exit Sub
        End If

        objEntidad.NRUCTR = Me.gwdDatos.CurrentRow.Cells("NRUCTR").Value
        objEntidad.CCMPN = cmbCompania.SelectedValue
        objEntidad.CDVSN = cmbDivision.SelectedValue
        objEntidad.CPLNDV = GetPlantaSeleccionada() ' cmbPlanta.SelectedValue
        objEntidad.NPLCUN = txtFiltroVehiculo.Text.Trim
        objEntidad.STPVHP = "0" 'Lista todos

        'IN_NROPAG, PAGESIZE, TOTPAG
        Dim totalPag As Decimal = 0
        Dim dtLista As New DataTable
        dtLista = obj.Listar_TractosPorTransportista(objEntidad, ucpagTracto.PageNumber, ucpagTracto.PageSize, totalPag)
        ucpagTracto.PageCount = totalPag
        gwdResTractosTransportista.DataSource = dtLista

    End Sub



    Private Sub Buscar_Filtro_Acoplado(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarFiltroAcoplado.Click

        Try

            'gwdResAcopladosTransportista.DataSource = Nothing
            'Dim objEntidad As New TransportistaAcoplado
            'Dim obj As New TransportistaAcoplado_BLL

            'If gwdDatos.CurrentRow Is Nothing Then
            '    Exit Sub
            'End If

            'objEntidad.NRUCTR = Me.gwdDatos.CurrentRow.Cells("NRUCTR").Value
            'objEntidad.CCMPN = Me.cmbCompania.SelectedValue
            'objEntidad.CDVSN = Me.cmbDivision.SelectedValue
            'objEntidad.CPLNDV = GetPlantaSeleccionada() ' Me.cmbPlanta.SelectedValue
            'objEntidad.STPACP = "0" 'Lista todos
            'objEntidad.NPLCAC = txtFiltroAcoplado.Text.Trim

            'gwdResAcopladosTransportista.DataSource = obj.Listar_AcopladosPorTransportista(objEntidad)

            ucpag_acoplado.PageNumber = 1
            ListarAcoplados_x_Transportista()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub ListarAcoplados_x_Transportista()

        gwdResAcopladosTransportista.DataSource = Nothing
        Dim objEntidad As New TransportistaAcoplado
        Dim obj As New TransportistaAcoplado_BLL

        If gwdDatos.CurrentRow Is Nothing Then
            Exit Sub
        End If

        objEntidad.NRUCTR = Me.gwdDatos.CurrentRow.Cells("NRUCTR").Value
        objEntidad.CCMPN = Me.cmbCompania.SelectedValue
        objEntidad.CDVSN = Me.cmbDivision.SelectedValue
        objEntidad.CPLNDV = GetPlantaSeleccionada() ' Me.cmbPlanta.SelectedValue
        objEntidad.STPACP = "0" 'Lista todos
        objEntidad.NPLCAC = txtFiltroAcoplado.Text.Trim

        Dim totpag As Decimal = 0

        Dim oList As New List(Of ENTIDADES.mantenimientos.TransportistaAcoplado)
        oList = obj.Listar_AcopladosPorTransportista(objEntidad, ucpag_acoplado.PageNumber, ucpag_acoplado.PageSize, totpag)
        ucpag_acoplado.PageCount = totpag
        gwdResAcopladosTransportista.DataSource = oList

    End Sub


    Private Sub Buscar_Filtro_Brevete(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarFiltroBrevete.Click

        Try

            'Dim objEntidad As New TransportistaConductor
            'Dim obj As New TransportistaConductor_BLL
            'gwdResConductoresTransportista.DataSource = Nothing


            'If gwdDatos.CurrentRow Is Nothing Then
            '    Exit Sub
            'End If

            'objEntidad.NRUCTR = Me.gwdDatos.CurrentRow.Cells("NRUCTR").Value
            'objEntidad.CCMPN = Me.cmbCompania.SelectedValue
            'objEntidad.CDVSN = Me.cmbDivision.SelectedValue
            'objEntidad.CPLNDV = GetPlantaSeleccionada() ' Me.cmbPlanta.SelectedValue
            'objEntidad.CBRCNT = txtFiltroBrevete.Text.Trim

            'gwdResConductoresTransportista.DataSource = obj.Listar_ConductoresPorTransportista(objEntidad)

            ucpag_conductor.PageNumber = 1
            Listar_Conductor_x_Transportista()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub Listar_Conductor_x_Transportista()
        Dim objEntidad As New TransportistaConductor
        Dim obj As New TransportistaConductor_BLL
        gwdResConductoresTransportista.DataSource = Nothing


        If gwdDatos.CurrentRow Is Nothing Then
            Exit Sub
        End If

        objEntidad.NRUCTR = Me.gwdDatos.CurrentRow.Cells("NRUCTR").Value
        objEntidad.CCMPN = Me.cmbCompania.SelectedValue
        objEntidad.CDVSN = Me.cmbDivision.SelectedValue
        objEntidad.CPLNDV = GetPlantaSeleccionada() ' Me.cmbPlanta.SelectedValue
        objEntidad.CBRCNT = txtFiltroBrevete.Text.Trim

        Dim cant_pag As Decimal = 0
        Dim oList As New List(Of ENTIDADES.mantenimientos.TransportistaConductor)
        oList = obj.Listar_ConductoresPorTransportista(objEntidad, ucpag_conductor.PageNumber, ucpag_conductor.PageSize, cant_pag)
        ucpag_conductor.PageCount = cant_pag
        gwdResConductoresTransportista.DataSource = oList ' obj.Listar_ConductoresPorTransportista(objEntidad)


    End Sub

    Private Sub UcPaginacion1_PageChanged(sender As Object, e As EventArgs) Handles UcPaginacion1.PageChanged
        Try
            Listar_Transportista()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ucpagTracto_PageChanged(sender As Object, e As EventArgs) Handles ucpagTracto.PageChanged
        Try
            ListarTracto_x_Transportista()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ucpag_conductor_PageChanged(sender As Object, e As EventArgs) Handles ucpag_conductor.PageChanged
        Try
            Listar_Conductor_x_Transportista()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnTranspas_Click(sender As Object, e As EventArgs) Handles btnTransp_AS.Click
        Try

            Dim ofrm As New frmTransportistaBuscarAS400
            ofrm.pCCMPN = cmbCompania.SelectedValue
            If ofrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                txtCod_AS.Text = ofrm.pCTRSPT & " - " & ofrm.pTCMTRT
                txtCod_AS.Tag = ofrm.pCTRSPT
            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbPolizaSeguro_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbPolizaSeguro.SelectionChangeCommitted
        Try
            Dim respSeg As String = cmbPolizaSeguro.SelectedValue
            If respSeg = "P" Then
                txtPorSeguro.Text = "0.00"
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
