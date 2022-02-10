Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports System.Data
Imports System.Collections.Generic
Imports Ransa.Utilitario

'****************************************************************************************************
'** Autor: Rafael Gamboa
'** Descripción: capa de presentación.
'****************************************************************************************************

Public Class frmTransportista_Propio
   
    Private gEnumOpcMan As Opcion = Opcion.Neutral
    Const TipoValidacion As String = "P"
    Dim TabSeleccionado As String = ""
    Private pPlantaDefault As Decimal = 0

    Enum Opcion
        Neutral
        Nuevo
        Modificar
    End Enum

    Dim Actual_TabPage As String
    Dim Actual_UcControl As String
    Dim Tab_Anterior As String = ""

    Private Sub HabilitarBoton(ByVal op As Opcion)

        Select Case op
            Case Opcion.Neutral
                btnNuevo.Enabled = True
                btnModificar.Enabled = True
                btnGuardar.Visible = False
                btnCancelar.Enabled = False
                btnEliminar.Enabled = True
                btnHomologado.Enabled = True
                btnImprimirDetalle.Enabled = True
                btnImprimirTRTodos.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
                btnExportarExcel.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
                btnBusqueda.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True

                btnNuevo_Mant.Enabled = True
                btnModificar_Mant.Enabled = True
                btnEliminar_Mant.Enabled = True
                btnImprimirDetalle.Enabled = True

                btnBuscarFiltroVehiculo.Enabled = True
                btnBuscarFiltroAcoplado.Enabled = True
                btnBuscarFiltroBrevete.Enabled = True
                btnExportarMant.Enabled = True


                If TabTransportistaPropio.TabPages.Count > 0 Then
                    CType(TabTransportistaPropio.TabPages(Actual_TabPage).Controls(Actual_UcControl), ucInformacionTransportista).pHabilitar_Control_Transportista(False)
                End If

            Case Opcion.Nuevo
                btnNuevo.Enabled = False
                btnModificar.Enabled = False
                btnGuardar.Visible = True
                btnGuardar.Enabled = True
                btnCancelar.Enabled = True
                btnEliminar.Enabled = False
                btnHomologado.Enabled = False
                btnImprimirDetalle.Enabled = False
                btnImprimirTRTodos.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                btnExportarExcel.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                btnBusqueda.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False

                btnNuevo_Mant.Enabled = False
                btnModificar_Mant.Enabled = False
                btnEliminar_Mant.Enabled = False
                btnImprimirDetalle.Enabled = False

                btnBuscarFiltroVehiculo.Enabled = False
                btnBuscarFiltroAcoplado.Enabled = False
                btnBuscarFiltroBrevete.Enabled = False
                btnExportarMant.Enabled = False


                If TabTransportistaPropio.TabPages.Count > 0 Then
                    CType(TabTransportistaPropio.TabPages(Actual_TabPage).Controls(Actual_UcControl), ucInformacionTransportista).pHabilitar_Control_Transportista(True)
                End If

            Case Opcion.Modificar
                btnNuevo.Enabled = False
                btnModificar.Enabled = False
                btnGuardar.Visible = True
                btnGuardar.Enabled = True
                btnCancelar.Enabled = True
                btnEliminar.Enabled = False
                btnHomologado.Enabled = False
                btnImprimirDetalle.Enabled = False
                btnImprimirTRTodos.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                btnExportarExcel.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                btnBusqueda.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False

                btnNuevo_Mant.Enabled = False
                btnModificar_Mant.Enabled = False
                btnEliminar_Mant.Enabled = False
                btnImprimirDetalle.Enabled = False

                btnBuscarFiltroVehiculo.Enabled = False
                btnBuscarFiltroAcoplado.Enabled = False
                btnBuscarFiltroBrevete.Enabled = False
                btnExportarMant.Enabled = False

                If TabTransportistaPropio.TabPages.Count > 0 Then
                    CType(TabTransportistaPropio.TabPages(Actual_TabPage).Controls(Actual_UcControl), ucInformacionTransportista).pHabilitar_Control_Transportista(True)
                End If

        End Select

    End Sub




    Private Sub frmTransportista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Dim obj As New TipoDatoGeneral_BLL
            Dim lista As New List(Of TipoDatoGeneral)
            lista = obj.Lista_Tipo_Dato_General("", "STPLMT")
            If lista.Count > 0 Then
                pPlantaDefault = lista(0).CODIGO_TIPO
            End If
            If pPlantaDefault > 0 Then
                lblPlanta.Visible = False
                cmbPlanta.Visible = False
            End If

            'Cargar_Tipo_Vehiculo()
            'Cargar_Tipo_Acoplado()
            gEnumOpcMan = Opcion.Neutral
            btnBuscar.Visible = False
            Cargar_Compania()

          

            Validar_Acceso_Opciones_Usuario()
            Limpiar_Controles_Transportista()
            gwdResTractosTransportista.AutoGenerateColumns = False
            gwdResAcopladosTransportista.AutoGenerateColumns = False
            gwdResConductoresTransportista.AutoGenerateColumns = False
            gEnumOpcMan = Opcion.Neutral
            Listar_Transportista()
            Actual_TabPage = TabTransportistaPropio.SelectedTab.Name.ToString
            Actual_UcControl = Actual_TabPage
            TabTransportistaPropio_SelectedIndexChanged_1(Nothing, Nothing)
            TabTransportista_SelectedIndexChanged(Nothing, Nothing)

            HabilitarBoton(Opcion.Neutral)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    'Sub Cargar_Tipo_Vehiculo()

    '    Dim dt As New DataTable
    '    Dim dr As DataRow
    '    dt.Columns.Add("STPVHP", Type.GetType("System.String"))
    '    dt.Columns.Add("STPVHP_S", Type.GetType("System.String"))

    '    dr = dt.NewRow
    '    dr("STPVHP") = "0"
    '    dr("STPVHP_S") = "TODOS"
    '    dt.Rows.Add(dr)

    '    dr = dt.NewRow
    '    dr("STPVHP") = "P"
    '    dr("STPVHP_S") = "Propio"
    '    dt.Rows.Add(dr)

    '    dr = dt.NewRow
    '    dr("STPVHP") = "A"
    '    dr("STPVHP_S") = "Alquilado"
    '    dt.Rows.Add(dr)

    '    cmbTipoFiltroVehiculo.DataSource = dt.Copy
    '    cmbTipoFiltroVehiculo.DisplayMember = "STPVHP_S"
    '    cmbTipoFiltroVehiculo.ValueMember = "STPVHP"

    'End Sub

    'Sub Cargar_Tipo_Acoplado()

    '    Dim dt As New DataTable
    '    Dim dr As DataRow
    '    dt.Columns.Add("STPACP", Type.GetType("System.String"))
    '    dt.Columns.Add("STPACP_S", Type.GetType("System.String"))

    '    dr = dt.NewRow
    '    dr("STPACP") = "0"
    '    dr("STPACP_S") = "TODOS"
    '    dt.Rows.Add(dr)

    '    dr = dt.NewRow
    '    dr("STPACP") = "P"
    '    dr("STPACP_S") = "Propio"
    '    dt.Rows.Add(dr)

    '    dr = dt.NewRow
    '    dr("STPACP") = "A"
    '    dr("STPACP_S") = "Alquilado"
    '    dt.Rows.Add(dr)

    '    cmbFiltroTipoAcoplado.DataSource = dt.Copy
    '    cmbFiltroTipoAcoplado.DisplayMember = "STPACP_S"
    '    cmbFiltroTipoAcoplado.ValueMember = "STPACP"

    'End Sub

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
            Me.btnNuevo_Mant.Visible = False
        End If
        If objEntidad.STSCHG = "" Then
            Me.btnGuardar.Visible = False
            Me.btnModificar_Mant.Visible = False
            Me.Separator2.Visible = False
        End If
        If objEntidad.STSADI = "" And objEntidad.STSCHG = "" Then
            Me.btnCancelar.Visible = False
            Me.Separator3.Visible = False
        End If
        If objEntidad.STSELI = "" Then
            Me.btnEliminar.Visible = False

            Me.btnEliminar_Mant.Visible = False
        End If
        If objEntidad.STSVIS = "" Then
            Me.btnImprimirDetalle.Visible = False
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

    

    'Private Sub Cargar_Planta()
    '    Dim objPlanta As New NEGOCIO.Planta_BLL
    '    Dim objLisEntidad As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
    '    'Try
    '    '    If (bolBuscar = True And Me.cmbCompania.SelectedValue IsNot Nothing And Me.cmbDivision.SelectedValue IsNot Nothing) Then
    '    '        bolBuscar = False
    '    objPlanta.Crea_Lista()
    '    objLisEntidad = objPlanta.Lista_Planta(Me.cmbCompania.SelectedValue, Me.cmbDivision.SelectedValue)
    '    cmbPlanta.DataSource = objLisEntidad
    '    cmbPlanta.ValueMember = "CPLNDV"
    '    cmbPlanta.DisplayMember = "TPLNTA"
    '    'bolBuscar = True
    '    Me.cmbPlanta.SelectedIndex = 0
    '    'cmbPlanta_SelectedIndexChanged(Nothing, Nothing)
    '    'End If
    '    'Catch ex As Exception

    '    '    HelpClass.MsgBox(ex.Message)
    '    'End Try

    'End Sub
   

   

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
            cmbDivision_SelectionChangeCommitted(Nothing, Nothing)
          
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbDivision_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDivision.SelectionChangeCommitted
      
        Try
            If pPlantaDefault = 0 Then
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
            lstr_PestanaActiva = Me.TabTransportistaPropio.SelectedTab.Name
            gEnumOpcMan = Opcion.Nuevo
          
            gwdResTractosTransportista.DataSource = Nothing
            gwdResAcopladosTransportista.DataSource = Nothing
            gwdResConductoresTransportista.DataSource = Nothing
            Nuevo_Tab()

            HabilitarBoton(Opcion.Nuevo)

            Actual_TabPage = "TAB_NUEVO"
            Actual_UcControl = Actual_TabPage
            TabTransportistaPropio.SelectTab("TAB_NUEVO")
            'Estado_Controles_Transportista(True)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



        'If lstr_PestanaActiva = "TabDatosTransportista" Then
        '    vCodTransportista = "0"
        '    chkTercero.Enabled = True
        '    Limpiar_Controles_Transportista()
        '    Estado_Controles_Transportista(True)

        'ElseIf lstr_PestanaActiva = "TabVehiculos" Then
        '    Dim obrTracto As New Tracto_BLL

        '    Dim ofrmNewTracto As New frmNuevoTracto(True)

        '    With ofrmNewTracto
        '        .CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
        '        If .ShowDialog() = Windows.Forms.DialogResult.OK Then
        '            Registrar_VehiculoTransportista(.NPLCUN, .TOBS)
        '            .objEntidad.CTRSPT = gwdDatos.CurrentRow.Cells("CTRSPT").Value
        '            obrTracto.Registrar_Tracto_Antiguo(.objEntidad)
        '            Listar_ResumenVehiculos()
        '        End If
        '        'AccionCancelar()
        '    End With
        'ElseIf lstr_PestanaActiva = "TabAcoplados" Then
        '    Dim obrAcoplado As New Acoplado_BLL
        '    Dim ofrmNewAcoplado As New frmNuevoAcoplado(True)
        '    With ofrmNewAcoplado
        '        .CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
        '        If .ShowDialog() = Windows.Forms.DialogResult.OK Then
        '            Registrar_AcopladoTransportista(.NPLCAC, .TOBS)
        '            .objEntidad.CTRSPT = gwdDatos.CurrentRow.Cells("CTRSPT").Value
        '            obrAcoplado.Registrar_Acoplado_Antiguo(.objEntidad)
        '            Listar_ResumenAcoplados()
        '        End If
        '        'AccionCancelar()
        '    End With

        'ElseIf lstr_PestanaActiva = "TabConductores" Then
        '    Dim ofrmNuevoConductor As New frmNuevoConductor(True)
        '    With ofrmNuevoConductor
        '        .chkTercero.Visible = False
        '        '.btnNuevo.Visible = False
        '        .ToolStripSeparator1.Visible = False
        '        .CCMPN = Me.gwdDatos.CurrentRow.Cells("CCMPN").Value
        '        If .ShowDialog = Windows.Forms.DialogResult.OK Then
        '            Dim obrConductor As New Chofer_BLL
        '            Registrar_ConductorTransportista(.CBRCNT, .TOBS)
        '            .objEntidad.CTRSPT = gwdDatos.CurrentRow.Cells("CTRSPT").Value
        '            obrConductor.Registrar_Chofer_Antiguo(.objEntidad)
        '            Listar_ResumenConductores()
        '        End If
        '        'AccionCancelar()
        '    End With
        'End If

    End Sub

    Private Function ValidarTransportista() As String

        Dim objResultado As New Transportista
        objResultado = CType(TabTransportistaPropio.TabPages(Actual_TabPage).Controls(Actual_UcControl), ucInformacionTransportista).Resultado()

        Dim msgVal As String = ""
        If objResultado.NRUCTR.ToString.Trim = "" Then
            msgVal = "Ingrese el RUC"
        End If
        If objResultado.NRUCTR.Trim.Length <> 11 Then
            msgVal = msgVal & Chr(13) & "El RUC debe tener 11 caracteres."

        End If
        If objResultado.TCMTRT.Trim = "" Then
            msgVal = msgVal & Chr(13) & "Ingrese la razón social."

        End If
        If objResultado.RUCPR2.Trim = "" Then
            msgVal = msgVal & Chr(13) & "Ingrese Cuenta Acreedor SAP."

        End If
        msgVal = msgVal.Trim
        Return msgVal
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
          
            Dim msgVal As String = ""

            'Select Case lstr_PestanaActiva
            '    Case "TabDatosTransportista"
            '        Select Case gEnumOpcMan
            '            Case Opcion.Nuevo
            '                msgVal = ValidarTransportista()
            '                If msgVal.Length > 0 Then
            '                    MessageBox.Show(msgVal, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '                    Exit Sub
            '                    'If Me.txtNroRuc.Text = "" Then
            '                    '    MsgBox("Ingrese el RUC", MsgBoxStyle.Exclamation)
            '                    '    Exit Sub
            '                    'ElseIf Me.txtNroRuc.Text.Length <> 11 Then
            '                    '    MsgBox("El RUC debe tener 11 caracteres.", MsgBoxStyle.Exclamation)
            '                    '    Exit Sub
            '                    'ElseIf Me.txtRazonSocial.Text = "" Then
            '                    '    MsgBox("Ingrese la razón social.", MsgBoxStyle.Exclamation)
            '                    '    Exit Sub
            '                    'ElseIf Me.txtCodigoTransportista.Text = "" Then
            '                    '    MsgBox("Ingrese Cuenta Acreedor SAP.", MsgBoxStyle.Exclamation)
            '                    '    Exit Sub
            '                Else
            '                    Dim oTransportistaBLL As New Transportista_BLL
            '                    Dim dtTransportista As New DataTable
            '                    Dim objEntidad As Transportista
            '                    objEntidad = New Transportista
            '                    objEntidad.NRUCTR = Me.txtNroRuc.Text.Trim
            '                    objEntidad.CCMPN = Me.cmbCompania.SelectedValue
            '                    objEntidad.SESTRG = "*"
            '                    objEntidad.NEWCTRSPT = cboTranspAS400.Codigo
            '                    If objEntidad.NEWCTRSPT = "" Then
            '                        objEntidad.NEWCTRSPT = "0"
            '                    End If
            '                    dtTransportista = oTransportistaBLL.Listar_Transportista_X_RUC(objEntidad)
            '                    If dtTransportista.Rows.Count > 0 Then
            '                        Dim RUC_SOLMIN As String = ("" & dtTransportista.Rows(0)("RUC_SOLMIN")).ToString.Trim
            '                        Dim RUC_AS As String = ("" & dtTransportista.Rows(0)("RUC_AS")).ToString.Trim
            '                        If RUC_SOLMIN <> RUC_AS Then
            '                            MessageBox.Show("El transportista AS400 no coincide con el RUC especificado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '                            Exit Sub
            '                        Else
            '                            If MessageBox.Show("El transportista se encuentra en estado inactivo.Desea activar y reemplazar con los datos ingresados", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            '                                objEntidad = New Transportista
            '                                oTransportistaBLL = New Transportista_BLL
            '                                objEntidad.CCMPN = Me.cmbCompania.SelectedValue
            '                                objEntidad.NRUCTR = Me.txtNroRuc.Text.Trim
            '                                objEntidad.CULUSA = MainModule.USUARIO
            '                                objEntidad.NTRMNL = HelpClass.NombreMaquina
            '                                oTransportistaBLL.ActivarTransportista(objEntidad)
            '                                vCodTransportista = dtTransportista.Rows(0)("CTRSPT")
            '                                Modificar_Transportista()
            '                            End If
            '                        End If
            '                    Else
            '                        Registrar_Transportista()
            '                        txtNroRuc.Focus()
            '                    End If
            '                End If




            Select Case gEnumOpcMan
                Case Opcion.Nuevo
                    msgVal = ValidarTransportista()
                    If msgVal.Length > 0 Then
                        MessageBox.Show(msgVal, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                      
                    Else

                        Dim objResultado As New Transportista
                        objResultado = CType(TabTransportistaPropio.TabPages(Actual_TabPage).Controls(Actual_UcControl), ucInformacionTransportista).Resultado()

                        Dim oTransportistaBLL As New Transportista_BLL
                        Dim dtTransportista As New DataTable
                        Dim objEntidad As Transportista
                        objEntidad = New Transportista
                        objEntidad.NRUCTR = objResultado.NRUCTR
                        objEntidad.CCMPN = Me.cmbCompania.SelectedValue
                        objEntidad.SESTRG = "*"
                        objEntidad.NEWCTRSPT = objResultado.NEWCTRSPT
                        If objEntidad.NEWCTRSPT = "" Then
                            objEntidad.NEWCTRSPT = "0"
                        End If
                        dtTransportista = oTransportistaBLL.Listar_Transportista_X_RUC(objEntidad)
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
                                    objEntidad.NRUCTR = objResultado.NRUCTR
                                    objEntidad.CULUSA = MainModule.USUARIO
                                    objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                                    oTransportistaBLL.ActivarTransportista(objEntidad)
                                    'vCodTransportista = dtTransportista.Rows(0)("CTRSPT")
                                    Modificar_Transportista()
                                End If
                            End If
                        Else
                            Registrar_Transportista()

                        End If
                    End If

                Case Opcion.Modificar
 
                    Dim objResultado As New Transportista
                    objResultado = CType(TabTransportistaPropio.TabPages(Actual_TabPage).Controls(Actual_UcControl), ucInformacionTransportista).Resultado()
                    msgVal = ValidarTransportista()
                    If objResultado.NEWCTRSPT.ToString.Trim = "" Then
                        msgVal = msgVal & Chr(13) & "Seleccione un código de transportista AS400."
                    End If
                    msgVal = msgVal.Trim
                    If msgVal.Length > 0 Then
                        MessageBox.Show(msgVal, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                    Modificar_Transportista()
                    'If objResultado.NRUCTR.ToString.Trim <> "" Then
                    '    If objResultado.NEWCTRSPT.ToString.Trim = "" Then
                    '        MsgBox("Seleccione un código de transportista AS400.", MsgBoxStyle.Exclamation)
                    '        Exit Sub
                    '    Else
                    '        'Dim estado As String = ("" & gwdDatos.CurrentRow.Cells("SESTRG").Value).ToString.Trim
                    '        'If estado = "*" Then
                    '        '    MessageBox.Show("No se puede modificar el transportista. El transportista está anulado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    '        '    Exit Sub
                    '        'End If
                    '        Modificar_Transportista()
                    '        'If Me.gwdDatos.Rows.Count > 0 Then
                    '        '    Me.Limpiar_Controles_Transportista()
                    '        '    'Me.gwdDatos.CurrentRow.Selected = False
                    '        'End If
                    '    End If
                    'End If
            End Select
            'If Me.gEnumOpcMan = Opcion.Nuevo Then

            '    'ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            'ElseIf gEnumOpcMan = Opcion.Modificar Then


            'End If
            'pulso el boton 'modificar'
            'ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then
            'ElseIf Me.gEnumOpcMan = Opcion.Modificar Then

            'Dim estado As String = ("" & gwdDatos.CurrentRow.Cells("SESTRG").Value).ToString.Trim
            'If estado = "*" Then
            '    MessageBox.Show("No se puede modificar el transportista. El transportista está anulado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    Exit Sub
            'End If

            ' Me.Estado_Controles_Transportista(True)
            'btnGuardar.Text = "Guardar"
            'controles habilitados para cancelar en cualkier momento la modificacion en caliente
            'btnNuevo.Enabled = False
            'btnCancelar.Enabled = True
            'btnEliminar.Enabled = False
            'prepara para la sgte accion del btnGuardar (guardar en BD)
            'Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
            'End If

            'ElseIf lstr_PestanaActiva = "TabVehiculos" Then

            'ElseIf lstr_PestanaActiva = "TabAcoplados" Then

            'ElseIf lstr_PestanaActiva = "TabConductores" Then

            'End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        '  If lstr_PestanaActiva = "TabDatosTransportista" Then
        'If Me.gEnumOpcMan = Opcion.Nuevo Then
        '    'If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
        '    If Me.txtNroRuc.Text = "" Then
        '        MsgBox("Ingrese el RUC", MsgBoxStyle.Exclamation)
        '        Exit Sub
        '    ElseIf Me.txtNroRuc.Text.Length <> 11 Then
        '        MsgBox("El RUC debe tener 11 caracteres.", MsgBoxStyle.Exclamation)
        '        Exit Sub
        '    ElseIf Me.txtRazonSocial.Text = "" Then
        '        MsgBox("Ingrese la razón social.", MsgBoxStyle.Exclamation)
        '        Exit Sub
        '    ElseIf Me.txtCodigoTransportista.Text = "" Then
        '        MsgBox("Ingrese Cuenta Acreedor SAP.", MsgBoxStyle.Exclamation)
        '        Exit Sub
        '    Else

        '        Dim oTransportistaBLL As New Transportista_BLL
        '        Dim dtTransportista As New DataTable
        '        Dim objEntidad As Transportista
        '        objEntidad = New Transportista
        '        objEntidad.NRUCTR = Me.txtNroRuc.Text.Trim
        '        objEntidad.CCMPN = Me.cmbCompania.SelectedValue
        '        objEntidad.SESTRG = "*"
        '        objEntidad.NEWCTRSPT = cboTranspAS400.Codigo
        '        dtTransportista = oTransportistaBLL.Listar_Transportista_X_RUC(objEntidad)

        '        If dtTransportista.Rows.Count > 0 Then
        '            Dim RUC_SOLMIN As String = ("" & dtTransportista.Rows(0)("RUC_SOLMIN")).ToString.Trim
        '            Dim RUC_AS As String = ("" & dtTransportista.Rows(0)("RUC_AS")).ToString.Trim
        '            If RUC_SOLMIN <> RUC_AS Then
        '                'MsgBox("El transportista AS400 no coincide con el RUC especificado.", MsgBoxStyle.Critica)
        '                MsgBox("El transportista AS400 no coincide con el RUC especificado.", MsgBoxStyle.Critical)
        '                Exit Sub
        '            Else
        '                If MessageBox.Show("El transportista se encuentra en estado inactivo.Desea activar y reemplazar con los datos ingresados", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        '                    objEntidad = New Transportista
        '                    oTransportistaBLL = New Transportista_BLL
        '                    objEntidad.CCMPN = Me.cmbCompania.SelectedValue
        '                    objEntidad.NRUCTR = Me.txtNroRuc.Text.Trim
        '                    objEntidad.CULUSA = MainModule.USUARIO
        '                    objEntidad.NTRMNL = HelpClass.NombreMaquina
        '                    oTransportistaBLL.ActivarTransportista(objEntidad)
        '                    vCodTransportista = dtTransportista.Rows(0)("CTRSPT")
        '                    Modificar_Transportista()
        '                End If
        '            End If
        '        Else
        '            Registrar_Transportista()
        '            txtNroRuc.Focus()
        '        End If

        '        'Registrar_Transportista()
        '        'txtNroRuc.Focus()

        '    End If
        '    'ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
        'ElseIf gEnumOpcMan = Opcion.Modificar Then
        '    If Me.txtNroRuc.Text <> "" Then
        '        If cboTranspAS400.Codigo = "" Then
        '            MsgBox("Seleccione un código de transportista AS400.", MsgBoxStyle.Exclamation)
        '            Exit Sub
        '        Else


        '            'Dim estado As String = ("" & gwdDatos.CurrentRow.Cells("SESTRG").Value).ToString.Trim
        '            'If estado = "*" Then
        '            '    MessageBox.Show("No se puede modificar el transportista. El transportista está anulado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '            '    Exit Sub
        '            'End If

        '            Modificar_Transportista()
        '            If Me.gwdDatos.Rows.Count > 0 Then
        '                Me.Limpiar_Controles_Transportista()
        '                'Me.gwdDatos.CurrentRow.Selected = False
        '            End If
        '        End If
        '    End If
        '    'pulso el boton 'modificar'
        '    'ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.MODIFICAR Then
        'ElseIf Me.gEnumOpcMan = Opcion.Modificar Then

        '    Dim estado As String = ("" & gwdDatos.CurrentRow.Cells("SESTRG").Value).ToString.Trim
        '    If estado = "*" Then
        '        MessageBox.Show("No se puede modificar el transportista. El transportista está anulado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '        Exit Sub
        '    End If

        '    Me.Estado_Controles_Transportista(True)
        '    'btnGuardar.Text = "Guardar"
        '    'controles habilitados para cancelar en cualkier momento la modificacion en caliente
        '    'btnNuevo.Enabled = False
        '    'btnCancelar.Enabled = True
        '    'btnEliminar.Enabled = False
        '    'prepara para la sgte accion del btnGuardar (guardar en BD)
        '    'Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
        'End If

        ''ElseIf lstr_PestanaActiva = "TabVehiculos" Then

        ''ElseIf lstr_PestanaActiva = "TabAcoplados" Then

        ''ElseIf lstr_PestanaActiva = "TabConductores" Then
        '  End If
        'gwdDatos.CurrentCell = gwdDatos.Item(0, _indiceGrilla)
    End Sub


    Private Function GetPlantaSeleccionada() As Decimal
        Dim planta As Decimal = pPlantaDefault
        If planta = 0 Then
            planta = cmbPlanta.SelectedValue
        End If
        Return planta
    End Function
    Private Sub Registrar_VehiculoTransportista(ByVal strVehiculo As String, ByVal strObservacion As String, ByVal STPVHP As String)
        Dim objEntidadTT As New TransportistaTracto
        Dim objLogica As New TransportistaTracto_BLL


        Dim objResultado As New Transportista
        objResultado = CType(TabTransportistaPropio.TabPages(Actual_TabPage).Controls(Actual_UcControl), ucInformacionTransportista).Resultado()

        objEntidadTT.NRUCTR = objResultado.NRUCTR 'txtNroRuc.Text 'Me.ctbTransportista.Codigo
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
        objEntidadTT.CCMPN = objResultado.CCMPN
        objEntidadTT.CDVSN = cmbDivision.SelectedValue
        objEntidadTT.CPLNDV = GetPlantaSeleccionada()
        objEntidadTT.STPVHP = STPVHP


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

        '            If STPVHP.ToString.Trim <> "" Then

        '                Dim objBLL As New Tracto_BLL
        '                Dim objBE As New Tracto

        '                objBE.CCMPN = objResultado.CCMPN
        '                objBE.CDVSN = cmbDivision.SelectedValue
        '                objBE.CPLNDV = cmbPlanta.SelectedValue
        '                objBE.NRUCTR = objResultado.NRUCTR
        '                objBE.NPLCUN = strVehiculo
        '                objBE.STPVHP = STPVHP
        '                objBE.CULUSA = MainModule.USUARIO
        '                objBE.NTRMNL = HelpClass.NombreMaquina

        '                objBLL.Modificar_Asignacion_Tracto_Transportista(objBE)

        '            End If

        '            MessageBox.Show("Tracto ya asignado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '            Exit Sub
        '        End If

        '    Else 'cambio de otra compañia
        '        Dim objCia1 As New Transportista
        '        objCia1.NRUCTR = objExisteTT.POS_RUC_ANTERIOR
        '        objCia1.CCMPN = objResultado.CCMPN
        '        objCia1.CDVSN = cmbDivision.SelectedValue
        '        objCia1.CPLNDV = cmbPlanta.SelectedValue

        '        Dim olbeCia1 As New List(Of Transportista)
        '        olbeCia1 = objLogicaCia.Listar_Transportista(objCia1)
        '        If olbeCia1.Count = 0 Then Exit Sub
        '        objCia1 = objLogicaCia.Listar_Transportista(objCia1).Item(0)

        '        '"¿Desea cambiarlo a la compañía " & txtRazonSocial.Text & " ?"
        '        Dim strMsg As String = "Tracto ya asignado a una compañía" & vbCrLf & _
        '                                "Tracto: " & objExisteTT.NPLCUN & vbCrLf & _
        '                                "Compañía: " & objCia1.TCMTRT & vbCrLf & _
        '                                "¿Desea cambiarlo a la compañía " & objResultado.TCMTRT & " ?"
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


                    If STPVHP.ToString.Trim <> "" Then

                        Dim objBLL As New Tracto_BLL
                        Dim objBE As New Tracto

                        objBE.CCMPN = objResultado.CCMPN
                        objBE.CDVSN = cmbDivision.SelectedValue
                        objBE.CPLNDV = GetPlantaSeleccionada()
                        objBE.NRUCTR = objResultado.NRUCTR
                        objBE.NPLCUN = strVehiculo
                        objBE.STPVHP = STPVHP
                        objBE.CULUSA = MainModule.USUARIO
                        objBE.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

                        objBLL.Modificar_Asignacion_Tracto_Transportista(objBE)

                    End If

                    MessageBox.Show("Tracto ya asignado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

            Else 'cambio de otra compañia
                Dim objCia1 As New Transportista
                objCia1.NRUCTR = objExisteTT.POS_RUC_ANTERIOR
                objCia1.CCMPN = objResultado.CCMPN
                objCia1.CDVSN = cmbDivision.SelectedValue
                objCia1.CPLNDV = GetPlantaSeleccionada()

                Dim olbeCia1 As New List(Of Transportista)
                olbeCia1 = objLogicaCia.Listar_Transportista(objCia1)
                If olbeCia1.Count = 0 Then Exit Sub

                objCia1 = olbeCia1.Item(0)

                '"¿Desea cambiarlo a la compañía " & txtRazonSocial.Text & " ?"
                Dim strMsg As String = "Tracto ya asignado a una compañía" & vbCrLf & _
                                        "Tracto: " & objExisteTT.NPLCUN & vbCrLf & _
                                        "Compañía: " & objCia1.TCMTRT & vbCrLf & _
                                        "¿Desea cambiarlo a la compañía " & objResultado.TCMTRT & " ?"
                If MsgBox(strMsg, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    objEntidadTT.FLAG_SKIPCHECKS = 1
                    'no se actualiza el tipo vehiculo(Propio-Alquilado)
                    'objEntidadTT = objLogica.Registrar_TransportistaTracto(objEntidadTT)
                    objEntidadTT = objLogica.Registrar_TransportistaTracto_V2(objEntidadTT)
                End If

            End If

        End If


    End Sub


    Private Sub Registrar_AcopladoTransportista(ByVal strAcoplado As String, ByVal strObservacion As String, ByVal STPACP As String)

        Dim objEntidadTA As New TransportistaAcoplado
        Dim objLogica As New TransportistaAcoplado_BLL

        Dim objResultado As New Transportista
        objResultado = CType(TabTransportistaPropio.TabPages(Actual_TabPage).Controls(Actual_UcControl), ucInformacionTransportista).Resultado()


        objEntidadTA.NRUCTR = objResultado.NRUCTR 'txtNroRuc.Text
        objEntidadTA.NPLCAC = strAcoplado 'cboAcoplados.Codigo
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
        objEntidadTA.CCMPN = objResultado.CCMPN
        objEntidadTA.CDVSN = cmbDivision.SelectedValue
        objEntidadTA.CPLNDV = GetPlantaSeleccionada()
        objEntidadTA.STPACP = STPACP

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

        '            If STPACP.ToString.Trim <> "" Then

        '                Dim objBLL As New Acoplado_BLL
        '                Dim objBE As New Acoplado

        '                objBE.CCMPN = objResultado.CCMPN
        '                objBE.CDVSN = cmbDivision.SelectedValue
        '                objBE.CPLNDV = cmbPlanta.SelectedValue
        '                objBE.NRUCTR = objResultado.NRUCTR
        '                objBE.NPLCAC = strAcoplado
        '                objBE.STPACP = STPACP
        '                objBE.CULUSA = MainModule.USUARIO
        '                objBE.NTRMNL = HelpClass.NombreMaquina

        '                objBLL.Modificar_Asignacion_Acoplado_Transportista(objBE)

        '            End If

        '            MessageBox.Show("Acoplado ya asignado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '            Exit Sub
        '        End If
        '    Else ' cambio de otra compañia
        '        Dim objCia1 As New Transportista
        '        objCia1.NRUCTR = objExisteTA.POS_RUC_ANTERIOR
        '        objCia1.CCMPN = objResultado.CCMPN
        '        objCia1.CDVSN = cmbDivision.SelectedValue
        '        objCia1.CPLNDV = cmbPlanta.SelectedValue

        '        Dim olbeCia1 As New List(Of Transportista)
        '        olbeCia1 = objLogicaCia.Listar_Transportista(objCia1)
        '        If olbeCia1.Count = 0 Then Exit Sub
        '        'objCia1 = objLogicaCia.Listar_Transportista(objCia1).Item(0)
        '        objCia1 = olbeCia1.Item(0)

        '        Dim strMsg As String = "Acoplado ya asignado a una compañía" & vbCrLf & _
        '                                "Acoplado: " & objExisteTA.NPLCAC & vbCrLf & _
        '                                "Compañía: " & objCia1.TCMTRT & vbCrLf & _
        '                                "¿Desea cambiarlo a la compañía " & objResultado.TCMTRT & " ?"

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


        'If objExisteTA.NRUCTR = "-1" Then 'ocurrio un error
        '    HelpClass.ErrorMsgBox()
        '    Exit Sub
        'Else
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



                    If STPACP.ToString.Trim <> "" Then

                        Dim objBLL As New Acoplado_BLL
                        Dim objBE As New Acoplado

                        objBE.CCMPN = objResultado.CCMPN
                        objBE.CDVSN = cmbDivision.SelectedValue
                        objBE.CPLNDV = GetPlantaSeleccionada()
                        objBE.NRUCTR = objResultado.NRUCTR
                        objBE.NPLCAC = strAcoplado
                        objBE.STPACP = STPACP
                        objBE.CULUSA = MainModule.USUARIO
                        objBE.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

                        objBLL.Modificar_Asignacion_Acoplado_Transportista(objBE)

                    End If

                    MessageBox.Show("Acoplado ya asignado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            Else ' cambio de otra compañia
                Dim objCia1 As New Transportista
                objCia1.NRUCTR = objExisteTA.POS_RUC_ANTERIOR
                objCia1.CCMPN = objResultado.CCMPN
                objCia1.CDVSN = cmbDivision.SelectedValue
                objCia1.CPLNDV = GetPlantaSeleccionada()

                Dim olbeCia1 As New List(Of Transportista)
                olbeCia1 = objLogicaCia.Listar_Transportista(objCia1)
                If olbeCia1.Count = 0 Then Exit Sub

                objCia1 = olbeCia1.Item(0)

                Dim strMsg As String = "Acoplado ya asignado a una compañía" & vbCrLf & _
                                        "Acoplado: " & objExisteTA.NPLCAC & vbCrLf & _
                                        "Compañía: " & objCia1.TCMTRT & vbCrLf & _
                                        "¿Desea cambiarlo a la compañía " & objResultado.TCMTRT & " ?"

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

        Dim objResultado As New Transportista
        objResultado = CType(TabTransportistaPropio.TabPages(Actual_TabPage).Controls(Actual_UcControl), ucInformacionTransportista).Resultado()

        objEntidadTC.NRUCTR = objResultado.NRUCTR 'txtNroRuc.Text
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

        objEntidadTC.CCMPN = objResultado.CCMPN
        objEntidadTC.CDVSN = cmbDivision.SelectedValue
        objEntidadTC.CPLNDV = GetPlantaSeleccionada()

        Dim objExisteTC As New TransportistaConductor
        objExisteTC = objEntidadTC
        objExisteTC.CCMPN = objResultado.CCMPN
        objExisteTC = objLogica.Registrar_TransportistaConductor(objExisteTC)

        'If objExisteTC.NRUCTR = "-1" Then 'ocurrio un error
        '    HelpClass.ErrorMsgBox()
        '    Exit Sub
        'ElseIf objExisteTC.POS_RUC_ANTERIOR = "" Then 'no existe
        '    objEntidadTC.FLAG_SKIPCHECKS = 1
        '    objEntidadTC.CCMPN = objResultado.CCMPN
        '    objEntidadTC = objLogica.Registrar_TransportistaConductor(objEntidadTC)
        '    If objEntidadTC.NRUCTR = "-1" Then
        '        HelpClass.ErrorMsgBox()
        '        Exit Sub
        '        'Else
        '        'Listar_ResumenConductores()
        '    End If

        'ElseIf objEntidadTC.POS_RUC_ANTERIOR <> "" Then ' existe la combinacion NRUCTR-NPLCAC
        '    Dim objLogicaCia As New Transportista_BLL

        '    'valida q no se asigne a la misma cia q ya lo tiene
        '    If objExisteTC.POS_RUC_ANTERIOR = objEntidadTC.NRUCTR Then
        '        'se pretendio asignar a una cia q ya lo tuvo o tiene asignado
        '        If objExisteTC.SESTCH = "*" Then
        '            objEntidadTC.FLAG_SKIPCHECKS = 1
        '            objEntidadTC.CCMPN = objResultado.CCMPN
        '            objEntidadTC = objLogica.Registrar_TransportistaConductor(objEntidadTC)
        '            If objEntidadTC.NRUCTR = "-1" Then
        '                HelpClass.ErrorMsgBox()
        '                Exit Sub
        '                'Else
        '                'Listar_ResumenConductores()
        '            End If
        '        Else
        '            'HelpClass.MsgBox("Conductor ya asignado.", MessageBoxIcon.Error)
        '            MessageBox.Show("Conductor ya asignado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '            Exit Sub
        '        End If
        '    Else ' cambio de otra compañia
        '        Dim objCia1 As New Transportista
        '        objCia1.NRUCTR = objExisteTC.POS_RUC_ANTERIOR
        '        objCia1.CCMPN = objResultado.CCMPN
        '        objCia1.CDVSN = cmbDivision.SelectedValue
        '        objCia1.CPLNDV = cmbPlanta.SelectedValue

        '        Dim olbeCia1 As New List(Of Transportista)
        '        olbeCia1 = objLogicaCia.Listar_Transportista(objCia1)
        '        If olbeCia1.Count = 0 Then Exit Sub
        '        'objCia1 = objLogicaCia.Listar_Transportista(objCia1).Item(0)
        '        objCia1 = olbeCia1.Item(0)

        '        Dim strMsg As String = "Conductor ya asignado a una compañía" & vbCrLf & _
        '                                "Conductor: " & objExisteTC.CBRCNT & vbCrLf & _
        '                                "Compañía: " & objCia1.TCMTRT & vbCrLf & _
        '                                "¿Desea cambiarlo a la compañía " & objResultado.TCMTRT & " ?"

        '        If MsgBox(strMsg, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
        '            objEntidadTC.FLAG_SKIPCHECKS = 1
        '            objEntidadTC.CCMPN = cmbCompania.SelectedValue
        '            objEntidadTC = objLogica.Registrar_TransportistaConductor(objEntidadTC)
        '            If objEntidadTC.NRUCTR = "-1" Then
        '                HelpClass.ErrorMsgBox()
        '                Exit Sub
        '            End If
        '        End If

        '    End If
        'End If

        'If objExisteTC.NRUCTR = "-1" Then 'ocurrio un error
        '    HelpClass.ErrorMsgBox()
        '    Exit Sub
        'Else
        If objExisteTC.POS_RUC_ANTERIOR = "" Then 'no existe
            objEntidadTC.FLAG_SKIPCHECKS = 1
            objEntidadTC.CCMPN = objResultado.CCMPN
            objEntidadTC = objLogica.Registrar_TransportistaConductor(objEntidadTC)
           

        ElseIf objEntidadTC.POS_RUC_ANTERIOR <> "" Then ' existe la combinacion NRUCTR-NPLCAC
            Dim objLogicaCia As New Transportista_BLL

            'valida q no se asigne a la misma cia q ya lo tiene
            If objExisteTC.POS_RUC_ANTERIOR = objEntidadTC.NRUCTR Then
                'se pretendio asignar a una cia q ya lo tuvo o tiene asignado
                If objExisteTC.SESTCH = "*" Then
                    objEntidadTC.FLAG_SKIPCHECKS = 1
                    objEntidadTC.CCMPN = objResultado.CCMPN
                    objEntidadTC = objLogica.Registrar_TransportistaConductor(objEntidadTC)
                   
                Else

                    MessageBox.Show("Conductor ya asignado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            Else ' cambio de otra compañia
                Dim objCia1 As New Transportista
                objCia1.NRUCTR = objExisteTC.POS_RUC_ANTERIOR
                objCia1.CCMPN = objResultado.CCMPN
                objCia1.CDVSN = cmbDivision.SelectedValue
                objCia1.CPLNDV = GetPlantaSeleccionada()

                Dim olbeCia1 As New List(Of Transportista)
                olbeCia1 = objLogicaCia.Listar_Transportista(objCia1)
                If olbeCia1.Count = 0 Then Exit Sub

                objCia1 = olbeCia1.Item(0)

                Dim strMsg As String = "Conductor ya asignado a una compañía" & vbCrLf & _
                                        "Conductor: " & objExisteTC.CBRCNT & vbCrLf & _
                                        "Compañía: " & objCia1.TCMTRT & vbCrLf & _
                                        "¿Desea cambiarlo a la compañía " & objResultado.TCMTRT & " ?"

                If MsgBox(strMsg, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    objEntidadTC.FLAG_SKIPCHECKS = 1
                    objEntidadTC.CCMPN = cmbCompania.SelectedValue
                    objEntidadTC = objLogica.Registrar_TransportistaConductor(objEntidadTC)
                     
                End If

            End If
        End If

    End Sub

#Region "TRANSPORTISTA"

    'Private Sub cargarComboTransportistaAS400()
    '    'Try

    '    Dim obrTransportistaAS400_BLL As New TransportistaAS400_BLL
    '    With Me.cboTranspAS400
    '        .DataSource = Nothing
    '        .DataSource = HelpClass.GetDataSetNative(obrTransportistaAS400_BLL.Listar_TransportistaAS400(Me.cmbCompania.SelectedValue))
    '        .KeyField = "CTRSPT"
    '        .ValueField = "TCMTRT"
    '        .DataBind()
    '    End With
    '    'Catch ex As Exception
    '    'End Try
    'End Sub

    Private Sub Registrar_Transportista()
        Dim obj As New Transportista_BLL
        Dim objEntidad As New Transportista
        Dim objResultado As New Transportista

        objResultado = CType(TabTransportistaPropio.TabPages(Actual_TabPage).Controls(Actual_UcControl), ucInformacionTransportista).Resultado()

        objEntidad.NRUCTR = objResultado.NRUCTR
        If objResultado.NEWCTRSPT = "" Then
            objEntidad.CTRSPT = 0
        Else
            objEntidad.CTRSPT = objResultado.NEWCTRSPT 'Integer.Parse(cboTranspAS400.Codigo)
        End If

        objEntidad.TCMTRT = objResultado.TCMTRT
        objEntidad.TABTRT = objResultado.TABTRT
        objEntidad.TDRCTR = objResultado.TDRCTR
        objEntidad.TLFTRP = objResultado.TLFTRP
        objEntidad.SINDRC = "P"
        objEntidad.CUSCRT = MainModule.USUARIO
        objEntidad.FCHCRT = HelpClass.TodayNumeric
        objEntidad.HRACRT = HelpClass.NowNumeric
        objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CCMPN = Me.cmbCompania.SelectedValue
        objEntidad.CDVSN = Me.cmbDivision.SelectedValue
        objEntidad.CPLNDV = GetPlantaSeleccionada()
        objEntidad.RUCPR2 = objResultado.RUCPR2
        objEntidad = obj.Registrar_Transportista(objEntidad)

        If objEntidad.CTRSPT > 0 Then
            'cargarComboTransportistaAS400()
            'lñll()
            'cboTranspAS400.Codigo = objEntidad.CTRSPT
            ''Me.gEnum_Mantenimiento = MANTENIMIENTO.NEUTRAL
            gEnumOpcMan = Opcion.Neutral
         
            HabilitarBoton(Opcion.Neutral)

            Actualiza_Tab(objResultado.NRUCTR)

            Actual_TabPage = TabTransportistaPropio.SelectedTab.Name.ToString
            Actual_UcControl = Actual_TabPage
            TabTransportistaPropio_SelectedIndexChanged_1(Nothing, Nothing)


        End If

      
    End Sub

    Private Sub Modificar_Transportista()
        Dim objEntidad As New Transportista
        Dim obj As New Transportista_BLL

        Dim objResultado As New Transportista
        objResultado = CType(TabTransportistaPropio.TabPages(Actual_TabPage).Controls(Actual_UcControl), ucInformacionTransportista).Resultado()
        objEntidad.NRUCTR = objResultado.NRUCTR 'Me.txtNroRuc.Text      
        objEntidad.CTRSPT = objResultado.NEWCTRSPT
        objEntidad.TCMTRT = objResultado.TCMTRT 'Me.txtRazonSocial.Text
        objEntidad.TABTRT = objResultado.TABTRT 'Me.txtDescripcion.Text
        objEntidad.TDRCTR = objResultado.TDRCTR 'Me.txtDireccionTransportista.Text
        objEntidad.TLFTRP = objResultado.TLFTRP 'Me.txtTelefonoTransportista.Text
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.NEWCTRSPT = objResultado.NEWCTRSPT 'cboTranspAS400.Codigo
        objEntidad.SINDRC = "P"
        objEntidad.CCMPN = objResultado.CCMPN
        objEntidad.RUCPR2 = objResultado.RUCPR2
        objEntidad = obj.Modificar_Transportista(objEntidad)
        If objEntidad.CTRSPT > "0" Then
            gEnumOpcMan = Opcion.Neutral
            HabilitarBoton(Opcion.Neutral)
            Actualiza_Tab(objResultado.NRUCTR)
            Actual_TabPage = TabTransportistaPropio.SelectedTab.Name.ToString
            Actual_UcControl = Actual_TabPage
            TabTransportistaPropio_SelectedIndexChanged_1(Nothing, Nothing)
        End If
      
    End Sub


    Private Sub Actualiza_Tab(ByVal RUC As String)

       Dim obj As New Transportista_BLL
        Dim Lista As New List(Of Transportista)
        Dim objEntidad As New Transportista
        objEntidad.CCMPN = cmbCompania.SelectedValue
        objEntidad.CDVSN = cmbDivision.SelectedValue
        objEntidad.CPLNDV = GetPlantaSeleccionada()
        objEntidad.NRUCTR = RUC
        objEntidad.SESTRG = "A"
        objEntidad.SINDRC = "P"
        Lista = obj.Listar_Transportista_Por_Tipo(objEntidad, 1, 20, 1)

        'Dim obrTransportistaAS400_BLL As New NEGOCIO.mantenimientos.TransportistaAS400_BLL
        'Dim dtAS400 As New DataTable
        'dtAS400 = HelpClass.GetDataSetNative(obrTransportistaAS400_BLL.Listar_TransportistaAS400(Me.cmbCompania.SelectedValue))
        For Each Transp As Transportista In Lista
            'CType(TabTransportistaPropio.TabPages(Actual_TabPage).Controls(Actual_UcControl), ucInformacionTransportista).pAsignar(dtAS400.Copy, Transp)
            CType(TabTransportistaPropio.TabPages(Actual_TabPage).Controls(Actual_UcControl), ucInformacionTransportista).pAsignar(Transp)
            CType(TabTransportistaPropio.TabPages(Actual_TabPage).Controls(Actual_UcControl), ucInformacionTransportista).Name = "TAB_" & Transp.CCMPN & "_" & Transp.NRUCTR & "_" & Transp.CTRSPT
            Actual_TabPage = "TAB_" & Transp.CCMPN & "_" & Transp.NRUCTR & "_" & Transp.CTRSPT
            Actual_UcControl = Actual_TabPage
            CType(TabTransportistaPropio.TabPages(Actual_TabPage).Controls(Actual_UcControl), ucInformacionTransportista).Text = Transp.TABTRT
        Next

    End Sub



    Private Sub Eliminar_Transportista()
        Dim objEntidad As New Transportista
        Dim obj As New Transportista_BLL

        Dim objResultado As New Transportista
        objResultado = CType(TabTransportistaPropio.TabPages(Actual_TabPage).Controls(Actual_UcControl), ucInformacionTransportista).Resultado()

        objEntidad.CTRSPT = objResultado.CTRSPT
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CCMPN = objResultado.CCMPN

        objEntidad = obj.Eliminar_Transportista(objEntidad)
        gEnumOpcMan = Opcion.Neutral
        HabilitarBoton(Opcion.Neutral)

        TabTransportistaPropio.TabPages.RemoveAt(TabTransportistaPropio.SelectedIndex)

     
    End Sub


    Private Sub Limpiar_Controles_Transportista()

        If Actual_UcControl IsNot Nothing Then
            CType(TabTransportistaPropio.TabPages(Actual_TabPage).Controls(Actual_UcControl), ucInformacionTransportista).pLimpiar()
        End If

   

    End Sub



    Private Sub Nuevo_Tab()

        Dim TabPagina As TabPage
        Dim ControlInfo As ucInformacionTransportista

        'Dim obrTransportistaAS400_BLL As New NEGOCIO.mantenimientos.TransportistaAS400_BLL
        'Dim dtAS400 As New DataTable

        'dtAS400 = HelpClass.GetDataSetNative(obrTransportistaAS400_BLL.Listar_TransportistaAS400(Me.cmbCompania.SelectedValue))

        TabPagina = New TabPage
        ControlInfo = New ucInformacionTransportista

     
        'ControlInfo.pAsignar(dtAS400, Nothing)
        ControlInfo.pAsignar(Nothing)
        ControlInfo.Dock = DockStyle.Fill
        ControlInfo.Name = "TAB_NUEVO"
        TabPagina.Name = "TAB_NUEVO"
        TabPagina.Text = "NUEVO REGISTRO"

        TabPagina.Controls.Add(ControlInfo)
        TabTransportistaPropio.TabPages.Add(TabPagina)

        Tab_Anterior = "TAB_NUEVO"

    End Sub


    

#End Region

#Region "VEHICULO POR TRANSPORTISTA"

 


    Private Sub Eliminar_VehiculoTransportista()
        Dim objEntidad As New TransportistaTracto
        Dim obj As New TransportistaTracto_BLL


        Dim objResultado As New Transportista
        objResultado = CType(TabTransportistaPropio.TabPages(Actual_TabPage).Controls(Actual_UcControl), ucInformacionTransportista).Resultado()

        objEntidad.NRUCTR = objResultado.NRUCTR 'Me.txtNroRuc.Text
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
        Listar_ResumenVehiculos()

       
     
    End Sub

    Private Sub Listar_ResumenVehiculos()
        gwdResTractosTransportista.DataSource = Nothing
        Dim objEntidad As New TransportistaTracto
        Dim obj As New TransportistaTracto_BLL

        Dim objResultado As New Transportista
        objResultado = CType(TabTransportistaPropio.TabPages(Actual_TabPage).Controls(Actual_UcControl), ucInformacionTransportista).Resultado()


        objEntidad.NRUCTR = objResultado.NRUCTR
        If TabTransportistaPropio.TabPages.Count = 0 Then Exit Sub
        objEntidad.CCMPN = cmbCompania.SelectedValue
        objEntidad.CDVSN = cmbDivision.SelectedValue
        objEntidad.CPLNDV = GetPlantaSeleccionada()

        objEntidad.NPLCUN = txtFiltroVehiculo.Text.Trim ' ""
        objEntidad.STPVHP = "0" ' cmbTipoFiltroVehiculo.SelectedValue ' "0"

        Dim totalPag As Decimal = 0
        Dim dt As New DataTable
        dt = obj.Listar_TractosPorTransportista(objEntidad, ucpagTracto.PageNumber, ucpagTracto.PageSize, totalPag)
        ucpagTracto.PageCount = totalPag
        gwdResTractosTransportista.DataSource = dt
    End Sub

#End Region

#Region "ACOPLADO POR TRANSPORTISTA"

   
    Private Sub Eliminar_AcopladoTransportista()
        If gwdResAcopladosTransportista.CurrentRow.Cells("NPLCAC").Value.ToString.Trim <> "0" AndAlso _
           gwdResAcopladosTransportista.CurrentRow.Cells("NPLCAC").Value.ToString.Trim <> "" Then

            Dim objEntidad As New TransportistaAcoplado
            Dim obj As New TransportistaAcoplado_BLL

            Dim objResultado As New Transportista
            objResultado = CType(TabTransportistaPropio.TabPages(Actual_TabPage).Controls(Actual_UcControl), ucInformacionTransportista).Resultado()

            objEntidad.NRUCTR = objResultado.NRUCTR 'txtNroRuc.Text
            objEntidad.NPLCAC = gwdResAcopladosTransportista.CurrentRow.Cells("NPLCAC").Value
            objEntidad.CULUSA = MainModule.USUARIO
            objEntidad.FULTAC = HelpClass.TodayNumeric
            objEntidad.HULTAC = HelpClass.NowNumeric
            objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
          

           
            objEntidad.CCMPN = gwdResAcopladosTransportista.CurrentRow.Cells("CCMPN").Value
            objEntidad.CDVSN = gwdResAcopladosTransportista.CurrentRow.Cells("CDVSN").Value
            objEntidad.CPLNDV = gwdResAcopladosTransportista.CurrentRow.Cells("CPLNDV").Value


            obj.Eliminar_TransportistaAcoplado(objEntidad)
            ucpag_acoplado.PageNumber = 1
            Listar_Acoplados_x_Transportista()
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

    '    Dim objResultado As New Transportista
    '    objResultado = CType(TabTransportistaPropio.TabPages(Actual_TabPage).Controls(Actual_UcControl), ucInformacionTransportista).Resultado()


    '    objEntidad.NRUCTR = objResultado.NRUCTR
    '    objEntidad.CCMPN = Me.cmbCompania.SelectedValue
    '    objEntidad.CDVSN = Me.cmbDivision.SelectedValue
    '    objEntidad.CPLNDV = GetPlantaSeleccionada()

    '    objEntidad.STPACP = "0"
    '    objEntidad.NPLCAC = ""


    '    gwdResAcopladosTransportista.DataSource = obj.Listar_AcopladosPorTransportista(objEntidad)
    'End Sub

#End Region

#Region "CONDUCTORES POR TRANSPORTISTA"

    Private Sub Eliminar_ConductorTransportista()
        If gwdResConductoresTransportista.CurrentRow.Cells("CBRCNT").Value.ToString.Trim <> "0" And _
           gwdResConductoresTransportista.CurrentRow.Cells("CBRCNT").Value.ToString.Trim <> "" Then

            Dim objEntidad As New TransportistaConductor
            Dim obj As New TransportistaConductor_BLL

            Dim objResultado As New Transportista
            objResultado = CType(TabTransportistaPropio.TabPages(Actual_TabPage).Controls(Actual_UcControl), ucInformacionTransportista).Resultado()

            objEntidad.NRUCTR = objResultado.NRUCTR 'txtNroRuc.Text
            objEntidad.CBRCNT = gwdResConductoresTransportista.CurrentRow.Cells("CBRCNT").Value
            objEntidad.CULUSA = MainModule.USUARIO
            objEntidad.FULTAC = HelpClass.TodayNumeric
            objEntidad.HULTAC = HelpClass.NowNumeric
            objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            objEntidad.CCMPN = gwdResConductoresTransportista.CurrentRow.Cells("CCMPN_C").Value.ToString.Trim
            objEntidad.CDVSN = gwdResConductoresTransportista.CurrentRow.Cells("CDVSN_C").Value.ToString.Trim
            objEntidad.CPLNDV = gwdResConductoresTransportista.CurrentRow.Cells("CPLNDV_C").Value

            obj.Eliminar_TransportistaConductor(objEntidad)
            ucpag_conductor.PageNumber = 1
            ListarConductor_X_Transportista()
            'Listar_ResumenConductores()

            'objEntidad = obj.Eliminar_TransportistaConductor(objEntidad)

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

    '    Dim objResultado As New Transportista
    '    objResultado = CType(TabTransportistaPropio.TabPages(Actual_TabPage).Controls(Actual_UcControl), ucInformacionTransportista).Resultado()

    '    objEntidad.NRUCTR = objResultado.NRUCTR
    '    objEntidad.CCMPN = Me.cmbCompania.SelectedValue
    '    objEntidad.CDVSN = Me.cmbDivision.SelectedValue
    '    objEntidad.CPLNDV = GetPlantaSeleccionada() 'Me.cmbPlanta.SelectedValue

    '    objEntidad.CBRCNT = ""


    '    gwdResConductoresTransportista.DataSource = obj.Listar_ConductoresPorTransportista(objEntidad)

 
    'End Sub

#End Region

    

    

    

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Try
           


            Select Case gEnumOpcMan
                Case Opcion.Nuevo
                    'el orden de habilitar enumopc es por el evento del tab al removerlo
                    HabilitarBoton(Opcion.Neutral)
                    Dim indice As Integer = TabTransportistaPropio.SelectedIndex
                    gEnumOpcMan = Opcion.Neutral
                    Actual_TabPage = ""
                    TabTransportistaPropio.TabPages.RemoveAt(indice)
                Case Opcion.Modificar
                    gEnumOpcMan = Opcion.Neutral
                    HabilitarBoton(Opcion.Neutral)
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
         
            If TabTransportistaPropio.TabPages.Count = 0 Then
                Exit Sub
            End If

            Dim objResultado As New Transportista
            objResultado = CType(TabTransportistaPropio.TabPages(Actual_TabPage).Controls(Actual_UcControl), ucInformacionTransportista).Resultado()

            Dim lstr_PestanaActiva As String = Me.TabTransportistaPropio.SelectedTab.Name
            Dim estado As String = objResultado.SESTRG
            If estado = "*" Then
                MessageBox.Show("No se puede eliminar el transportista. El transportista ya se encuentra eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If



            Dim TieneDetalle As Boolean = False

          

            If MessageBox.Show("Desea eliminar este registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                If objResultado.NRUCTR <> "" Then
                    'se verifica si el transportista tiene registros relacionados
                    Dim Transportista_BLL As New Transportista_BLL
                    Dim CTRSPT As Decimal = objResultado.CTRSPT
                    Dim CCMPN As String = objResultado.CCMPN
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

            

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try


    End Sub

 

  

    

   

    

   
    Private Sub txtNroRuc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8, 13
            Case Else : e.Handled = True
        End Select
    End Sub

    Private Sub txtFiltroTransportista_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            Select Case e.KeyCode
                'Case Keys.Enter : buscar()
                Case Keys.Enter : Listar_Transportista()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

   

    

    
    'Private Sub gwdResAcopladosTransportista_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdResAcopladosTransportista.CellContentClick
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

   

    'Private Sub gwdResConductoresTransportista_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdResConductoresTransportista.CellContentClick
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
 

    'Private Sub gwdResTractosTransportista_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdResTractosTransportista.CellContentClick
    '    If e.RowIndex < 0 OrElse gwdResTractosTransportista.CurrentCellAddress.Y < 0 Then
    '        Exit Sub
    '    End If
    '    Try
    '        'llenarControlesTabTranspTracto()
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

    Private Sub ButtonSpecHeaderGroup1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TabTransportistaPropio.Visible = Not TabTransportistaPropio.Visible
     
    End Sub

   

    Private Sub btnImprimirTRTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try
            Dim objEntidad As New Transportista
            Dim objPrintForm As New PrintForm
            Dim oDs As New DataSet
            Dim oDt As DataTable
            Dim objReporte As New rptListaTransportista
            Dim objLogical As New Transportista_BLL


            Dim objResultado As New Transportista
            objResultado = CType(TabTransportistaPropio.TabPages(Actual_TabPage).Controls(Actual_UcControl), ucInformacionTransportista).Resultado()

            objEntidad.NRUCTR = objResultado.NRUCTR
            objEntidad.CCMPN = Me.cmbCompania.SelectedValue
            objEntidad.CDVSN = Me.cmbDivision.SelectedValue
            objEntidad.CPLNDV = GetPlantaSeleccionada() ' Me.cmbPlanta.SelectedValue
           
            objEntidad.SESTRG = "A"
          
            oDt = HelpClass.GetDataSetNative(objLogical.Listar_Transportista(objEntidad))
            If oDt.Rows.Count = 0 Then
                Exit Sub
            End If
            oDt.TableName = "TRANSPORTISTA"
            oDs.Tables.Add(oDt.Copy)
            objReporte.SetDataSource(oDs)
            objPrintForm.ShowForm(objReporte, Me)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try

    End Sub

    
    Private Sub Crear_Estructura_Reporte_Transportista(ByRef poDt As DataTable)
        poDt.Columns.Add(New DataColumn("NRUCTR", GetType(System.String)))  'Compañia
        poDt.Columns.Add(New DataColumn("TCMTRT", GetType(System.String))) 'Tipo de Documento
        poDt.Columns.Add(New DataColumn("TABTRT", GetType(System.String))) 'Numero de Documento
        poDt.Columns.Add(New DataColumn("TLFTRP", GetType(System.String))) 'Indice de Renovacion = 0
        poDt.Columns.Add(New DataColumn("TDRCTR", GetType(System.String))) 'Correlativo del Detalle
        poDt.Columns.Add(New DataColumn("SINDRC", GetType(System.String))) 'Servicio
        poDt.Columns.Add(New DataColumn("TRACTOS_ASIGNADOS", GetType(System.String))) 'Flag tipo control = ""
        poDt.Columns.Add(New DataColumn("ACOPLADOS_ASIGNADOS", GetType(System.String))) 'Unidad del Servicio
        poDt.Columns.Add(New DataColumn("CHOFERES_ASIGNADOS", GetType(System.String))) 'Cantidad del Servicio
        poDt.Columns.Add(New DataColumn("ESTADO_HOMOLOGACION", GetType(System.String))) 'Moneda de la Tarifa        
    End Sub


   
    Private Function Validar_Proveedor_Homologado() As String
        Dim objNegocio As New Solicitud_Transporte_BLL
        Dim objHashTable As New Hashtable
        Dim objResultado As New Transportista
        objResultado = CType(TabTransportistaPropio.TabPages(Actual_TabPage).Controls(Actual_UcControl), ucInformacionTransportista).Resultado()
        'objHashTable.Add("CCMPN", Me.cmbCompania.SelectedValue)
        objHashTable.Add("CCMPN", objResultado.CCMPN)
        objHashTable.Add("NRUCTR", objResultado.NRUCTR)
        objHashTable.Add("FECVRF", Format(Date.Today, "yyyyMMdd"))
        Return objNegocio.Obtener_Validacion_Homologacion_Proveedor(objHashTable)
    End Function

   

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
           
            If TabTransportistaPropio.TabPages.Count = 0 Then
                Exit Sub
            End If

            Dim objResultado As New Transportista
            objResultado = CType(TabTransportistaPropio.TabPages(Actual_TabPage).Controls(Actual_UcControl), ucInformacionTransportista).Resultado()


            Dim estado As String = objResultado.SESTRG
            If estado = "*" Then
                MessageBox.Show("No se puede modificar el transportista. El transportista está anulado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

          

            gEnumOpcMan = Opcion.Modificar
            
            HabilitarBoton(Opcion.Modificar)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    

    Private Sub Listar_Transportista()
        Dim Lista As New List(Of Transportista)
        gwdResTractosTransportista.DataSource = Nothing
        gwdResAcopladosTransportista.DataSource = Nothing
        gwdResConductoresTransportista.DataSource = Nothing
        Limpiar_Controles_Transportista()
        Dim obj As New Transportista_BLL
        Dim objEntidad As New Transportista
        objEntidad.CCMPN = Me.cmbCompania.SelectedValue
        objEntidad.CDVSN = Me.cmbDivision.SelectedValue
        objEntidad.CPLNDV = GetPlantaSeleccionada() ' Me.cmbPlanta.SelectedValue
        objEntidad.NRUCTR = ""
        objEntidad.SESTRG = "A"
        objEntidad.SINDRC = "P"
        Lista = obj.Listar_Transportista_Por_Tipo(objEntidad, 1, 20, 1)

        TabTransportistaPropio.TabPages.Clear()
        Dim TabPagina As TabPage
        Dim ControlInfo As ucInformacionTransportista
        'Dim obrTransportistaAS400_BLL As New NEGOCIO.mantenimientos.TransportistaAS400_BLL
        'Dim dtAS400 As New DataTable
        'dtAS400 = HelpClass.GetDataSetNative(obrTransportistaAS400_BLL.Listar_TransportistaAS400(Me.cmbCompania.SelectedValue))
        'dddd()
        For Each Item As Transportista In Lista
            TabPagina = New TabPage
            ControlInfo = New ucInformacionTransportista
           
            'ControlInfo.pAsignar(dtAS400.Copy, Item)
            ControlInfo.pAsignar(Item)
            ControlInfo.Dock = DockStyle.Fill
            ControlInfo.Name = "TAB_" & Item.CCMPN & "_" & Item.NRUCTR & "_" & Item.CTRSPT

            TabPagina.Name = "TAB_" & Item.CCMPN & "_" & Item.NRUCTR & "_" & Item.CTRSPT
            TabPagina.Text = Item.TABTRT
            TabPagina.Controls.Add(ControlInfo)
            TabTransportistaPropio.TabPages.Add(TabPagina)
        Next

    End Sub


   


    Private Sub TabTransportistaPropio_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabTransportistaPropio.SelectedIndexChanged
        Try
            If TabTransportistaPropio.TabPages.Count > 0 Then
                If Actual_TabPage = "TAB_NUEVO" Then

                    If Actual_TabPage <> TabTransportistaPropio.SelectedTab.Name Then
                        If (gEnumOpcMan = Opcion.Modificar Or gEnumOpcMan = Opcion.Nuevo) Then
                            TabTransportistaPropio.SelectTab(Actual_TabPage)
                            MessageBox.Show("Debe guardar o cancelar la acción", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If
                    End If

                ElseIf Actual_TabPage <> "TAB_NUEVO" Then

                    If gEnumOpcMan = Opcion.Modificar Or gEnumOpcMan = Opcion.Nuevo Then

                        If Actual_TabPage <> TabTransportistaPropio.SelectedTab.Name Then
                            TabTransportistaPropio.SelectTab(Actual_TabPage)
                            MessageBox.Show("Debe guardar o cancelar la acción", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If

                    ElseIf gEnumOpcMan = Opcion.Neutral Then

                        Actual_TabPage = TabTransportistaPropio.SelectedTab.Name.ToString
                        Actual_UcControl = Actual_TabPage
                        gEnumOpcMan = Opcion.Neutral
                        HabilitarBoton(Opcion.Neutral)
                        gwdResTractosTransportista.DataSource = Nothing
                        gwdResAcopladosTransportista.DataSource = Nothing
                        gwdResConductoresTransportista.DataSource = Nothing
                      

                        Buscar_Filtro_Vehiculo(Nothing, Nothing)
                        Buscar_Filtro_Acoplado(Nothing, Nothing)
                        Buscar_Filtro_Brevete(Nothing, Nothing)

                    End If
                    
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub



    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo_Mant.Click
        Try
           
            gEnumOpcMan = Opcion.Neutral
          
            Dim lstr_PestanaActiva As String
            lstr_PestanaActiva = Me.TabTransportista.SelectedTab.Name
            Dim objResultado As New Transportista
            objResultado = CType(TabTransportistaPropio.TabPages(Actual_TabPage).Controls(Actual_UcControl), ucInformacionTransportista).Resultado
            Select Case lstr_PestanaActiva
                Case "TabVehiculos", "TabAcoplados", "TabConductores"

                    If TabTransportista.TabPages.Count = 0 Then
                        Exit Sub
                    End If
                    Dim estado As String = objResultado.SESTRG
                    If estado = "*" Then
                        MessageBox.Show("No se puede adicionar detalles. El transportista está anulado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
            End Select
           
            Select Case lstr_PestanaActiva
                Case "TabVehiculos"
                    Dim obrTracto As New Tracto_BLL
                    Dim ofrmNewTracto As New frmNuevoTracto(True)
                    ofrmNewTracto.btnModificar.Visible = False
                    Dim objResultado1 As New Transportista
                    objResultado1 = CType(TabTransportistaPropio.TabPages(Actual_TabPage).Controls(Actual_UcControl), ucInformacionTransportista).Resultado

                    With ofrmNewTracto

                        .TIPO = "P"
                        .CCMPN = cmbCompania.SelectedValue
                        .CDVSN = objResultado1.CDVSN
                        .CPLNDV = objResultado1.CPLNDV
                        .NRUCTR = objResultado1.NRUCTR

                        If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                            Registrar_VehiculoTransportista(.NPLCUN, .TOBS, .STPVHP)
                            .objEntidad.CTRSPT = objResultado.CTRSPT

                            Buscar_Filtro_Vehiculo(Nothing, Nothing)
                        End If

                    End With

                Case "TabAcoplados"
                    Dim obrAcoplado As New Acoplado_BLL
                    Dim ofrmNewAcoplado As New frmNuevoAcoplado(True)
                    ofrmNewAcoplado.btnModificar.Visible = False
                    Dim objResultado2 As New Transportista
                    objResultado2 = CType(TabTransportistaPropio.TabPages(Actual_TabPage).Controls(Actual_UcControl), ucInformacionTransportista).Resultado

                    With ofrmNewAcoplado
                        .CCMPN = cmbCompania.SelectedValue
                        .TIPO = "P"
                        .CCMPN = cmbCompania.SelectedValue
                        .CDVSN = objResultado2.CDVSN
                        .CPLNDV = objResultado2.CPLNDV
                        .NRUCTR = objResultado2.NRUCTR

                        If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                            Registrar_AcopladoTransportista(.NPLCAC, .TOBS, .STPACP)
                            .objEntidad.CTRSPT = objResultado.CTRSPT

                            Buscar_Filtro_Acoplado(Nothing, Nothing)
                        End If

                    End With

                Case "TabConductores"

                    Dim ofrmNuevoConductor As New frmNuevoConductor(True)
                    With ofrmNuevoConductor
                        .chkTercero.Visible = False
                        .btnNuevo.Visible = False
                        .ToolStripSeparator1.Visible = False
                        .CCMPN = cmbCompania.SelectedValue
                        .btnModificar.Visible = False
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            Dim obrConductor As New Chofer_BLL
                            Registrar_ConductorTransportista(.CBRCNT, .TOBS)
                            .objEntidad.CTRSPT = objResultado.CTRSPT
                            obrConductor.Registrar_Chofer_Antiguo(.objEntidad)

                            Buscar_Filtro_Brevete(Nothing, Nothing)
                        End If

                    End With

                  

            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
 
    End Sub



    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar_Mant.Click

        Try
            If TabTransportistaPropio.TabPages.Count = 0 Then
                Exit Sub
            End If

          
            Dim lstr_PestanaActiva As String = Me.TabTransportista.SelectedTab.Name

            Dim objResultado As New Transportista
            objResultado = CType(TabTransportistaPropio.TabPages(Actual_TabPage).Controls(Actual_UcControl), ucInformacionTransportista).Resultado()

            Dim estado As String = objResultado.SESTRG

            If estado = "*" Then
                MessageBox.Show("No se puede eliminar el transportista. El transportista ya se encuentra eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If



            Dim TieneDetalle As Boolean = False

            Select Case lstr_PestanaActiva

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
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnImprimirDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirDetalle.Click

        Try
            If TabTransportistaPropio.TabPages.Count > 0 Then

                Dim objResultado As New Transportista
                objResultado = CType(TabTransportistaPropio.TabPages(Actual_TabPage).Controls(Actual_UcControl), ucInformacionTransportista).Resultado()

                Dim f As New frmOpRptTransportista_Propio(objResultado.NRUCTR)
                f.StartPosition = FormStartPosition.CenterScreen
                With f
                    .CCMPN = cmbCompania.SelectedValue
                    .CDVSN = cmbDivision.SelectedValue
                    .CPLNDV = GetPlantaSeleccionada() ' cmbPlanta.SelectedValue
                    .Show(Me)
                End With

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnHomologado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHomologado.Click

        Try
            Dim strResultado As String = Validar_Proveedor_Homologado()
            If strResultado.Trim = "" Then
                strResultado = "Apto"
            End If
            MessageBox.Show("Estado Homologación : " & strResultado, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


    Private Sub btnModificar_Mant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar_Mant.Click

        Try

            Select Case TabTransportista.SelectedTab.Name

                Case "TabVehiculos"

                    Dim objFRM As New frmTractoPropio_Mant

                   

                    Dim objResultado As New Transportista
                    objResultado = CType(TabTransportistaPropio.TabPages(Actual_TabPage).Controls(Actual_UcControl), ucInformacionTransportista).Resultado()

                    objFRM.CCMPN = Me.gwdResTractosTransportista.Item("CCMPN_VH", gwdResTractosTransportista.CurrentCellAddress.Y).Value.ToString.Trim
                    objFRM.CDVSN = Me.gwdResTractosTransportista.Item("CDVSN_VH", gwdResTractosTransportista.CurrentCellAddress.Y).Value.ToString.Trim
                    objFRM.CPLNDV = Me.gwdResTractosTransportista.Item("CPLNDV_VH", gwdResTractosTransportista.CurrentCellAddress.Y).Value.ToString.Trim
                    objFRM.pRazonSocial = objResultado.TCMTRT
                    objFRM.NRUCTR = objResultado.NRUCTR
                    objFRM.NPLCUN = Me.gwdResTractosTransportista.Item("NPLCUN", gwdResTractosTransportista.CurrentCellAddress.Y).Value.ToString.Trim
                    objFRM.STPVHP = Me.gwdResTractosTransportista.Item("STPVHP", gwdResTractosTransportista.CurrentCellAddress.Y).Value.ToString.Trim

                    If objFRM.ShowDialog = Windows.Forms.DialogResult.OK Then
                        TabTransportistaPropio_SelectedIndexChanged_1(Nothing, Nothing)
                    End If

                Case "TabAcoplados"

                    Dim objFRM As New frmTractoAcoplado_Mant

                    objFRM.CCMPN = Me.gwdResAcopladosTransportista.Item("CCMPN", gwdResAcopladosTransportista.CurrentCellAddress.Y).Value.ToString.Trim
                    objFRM.CDVSN = Me.gwdResAcopladosTransportista.Item("CDVSN", gwdResAcopladosTransportista.CurrentCellAddress.Y).Value.ToString.Trim
                    objFRM.CPLNDV = Me.gwdResAcopladosTransportista.Item("CPLNDV", gwdResAcopladosTransportista.CurrentCellAddress.Y).Value

                    Dim objResultado As New Transportista
                    objResultado = CType(TabTransportistaPropio.TabPages(Actual_TabPage).Controls(Actual_UcControl), ucInformacionTransportista).Resultado()

                    objFRM.pRazonSocial = objResultado.TCMTRT
                    objFRM.NRUCTR = objResultado.NRUCTR
                    objFRM.NPLCAC = Me.gwdResAcopladosTransportista.Item("NPLCAC", gwdResAcopladosTransportista.CurrentCellAddress.Y).Value.ToString.Trim
                    objFRM.STPACP = Me.gwdResAcopladosTransportista.Item("STPACP", gwdResAcopladosTransportista.CurrentCellAddress.Y).Value.ToString.Trim

                    If objFRM.ShowDialog = Windows.Forms.DialogResult.OK Then
                        TabTransportistaPropio_SelectedIndexChanged_1(Nothing, Nothing)
                    End If

            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub TabTransportista_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabTransportista.SelectedIndexChanged

        Try

            Select Case TabTransportista.SelectedTab.Name

                Case "TabVehiculos"
                    btnModificar_Mant.Enabled = True
                Case "TabAcoplados"
                    btnModificar_Mant.Enabled = True
                Case Else
                    btnModificar_Mant.Enabled = False
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub Buscar_Filtro_Vehiculo(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarFiltroVehiculo.Click

        Try

            'gwdResTractosTransportista.DataSource = Nothing
            'Dim objEntidad As New TransportistaTracto
            'Dim Lista As New DataTable
            'Dim obj As New TransportistaTracto_BLL

            'Dim objResultado As New Transportista
            'objResultado = CType(TabTransportistaPropio.TabPages(Actual_TabPage).Controls(Actual_UcControl), ucInformacionTransportista).Resultado()

            'objEntidad.NRUCTR = objResultado.NRUCTR
            'If TabTransportistaPropio.TabPages.Count = 0 Then Exit Sub
            'objEntidad.CCMPN = cmbCompania.SelectedValue
            'objEntidad.CDVSN = cmbDivision.SelectedValue
            'objEntidad.CPLNDV = GetPlantaSeleccionada()
            'objEntidad.NPLCUN = txtFiltroVehiculo.Text.Trim
            'objEntidad.STPVHP = cmbTipoFiltroVehiculo.SelectedValue
            'gwdResTractosTransportista.DataSource = obj.Listar_TractosPorTransportista(objEntidad)

            ucpagTracto.PageNumber = 1
            Listar_ResumenVehiculos()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub Buscar_Filtro_Acoplado(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarFiltroAcoplado.Click

        Try

            'gwdResAcopladosTransportista.DataSource = Nothing
            'Dim objEntidad As New TransportistaAcoplado
            'Dim obj As New TransportistaAcoplado_BLL

            'Dim objResultado As New Transportista
            'objResultado = CType(TabTransportistaPropio.TabPages(Actual_TabPage).Controls(Actual_UcControl), ucInformacionTransportista).Resultado()

            'objEntidad.NRUCTR = objResultado.NRUCTR
            'objEntidad.CCMPN = Me.cmbCompania.SelectedValue
            'objEntidad.CDVSN = Me.cmbDivision.SelectedValue
            'objEntidad.CPLNDV = GetPlantaSeleccionada() ' Me.cmbPlanta.SelectedValue
            'objEntidad.STPACP = Me.cmbFiltroTipoAcoplado.SelectedValue
            'objEntidad.NPLCAC = Me.txtFiltroAcoplado.Text.Trim


            'gwdResAcopladosTransportista.DataSource = obj.Listar_AcopladosPorTransportista(objEntidad)
            ucpag_acoplado.PageNumber = 1
            Listar_Acoplados_x_Transportista()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub Listar_Acoplados_x_Transportista()
        gwdResAcopladosTransportista.DataSource = Nothing
        Dim objEntidad As New TransportistaAcoplado
        Dim obj As New TransportistaAcoplado_BLL

        Dim objResultado As New Transportista
        objResultado = CType(TabTransportistaPropio.TabPages(Actual_TabPage).Controls(Actual_UcControl), ucInformacionTransportista).Resultado()

        objEntidad.NRUCTR = objResultado.NRUCTR
        objEntidad.CCMPN = Me.cmbCompania.SelectedValue
        objEntidad.CDVSN = Me.cmbDivision.SelectedValue
        objEntidad.CPLNDV = GetPlantaSeleccionada() ' Me.cmbPlanta.SelectedValue
        objEntidad.STPACP = "0" 'Me.cmbFiltroTipoAcoplado.SelectedValue
        objEntidad.NPLCAC = Me.txtFiltroAcoplado.Text.Trim

        Dim oList As New List(Of ENTIDADES.mantenimientos.TransportistaAcoplado)
        Dim totalReg As Decimal = 0
        oList = obj.Listar_AcopladosPorTransportista(objEntidad, ucpag_acoplado.PageNumber, ucpag_acoplado.PageSize, totalReg)
        ucpag_acoplado.PageCount = totalReg
        gwdResAcopladosTransportista.DataSource = oList
    End Sub

    Private Sub Buscar_Filtro_Brevete(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarFiltroBrevete.Click

        Try

            'Dim objEntidad As New TransportistaConductor
            'Dim obj As New TransportistaConductor_BLL
            'gwdResConductoresTransportista.DataSource = Nothing

            'Dim objResultado As New Transportista
            'objResultado = CType(TabTransportistaPropio.TabPages(Actual_TabPage).Controls(Actual_UcControl), ucInformacionTransportista).Resultado()

            'objEntidad.NRUCTR = objResultado.NRUCTR
            'objEntidad.CCMPN = Me.cmbCompania.SelectedValue
            'objEntidad.CDVSN = Me.cmbDivision.SelectedValue
            'objEntidad.CPLNDV = GetPlantaSeleccionada() ' Me.cmbPlanta.SelectedValue

            'objEntidad.CBRCNT = txtFiltroBrevete.Text.Trim


            'gwdResConductoresTransportista.DataSource = obj.Listar_ConductoresPorTransportista(objEntidad)

            ucpag_conductor.PageNumber = 1
            ListarConductor_X_Transportista()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ListarConductor_X_Transportista()

        Dim objEntidad As New TransportistaConductor
        Dim obj As New TransportistaConductor_BLL
        gwdResConductoresTransportista.DataSource = Nothing

        Dim objResultado As New Transportista
        objResultado = CType(TabTransportistaPropio.TabPages(Actual_TabPage).Controls(Actual_UcControl), ucInformacionTransportista).Resultado()

        objEntidad.NRUCTR = objResultado.NRUCTR
        objEntidad.CCMPN = Me.cmbCompania.SelectedValue
        objEntidad.CDVSN = Me.cmbDivision.SelectedValue
        objEntidad.CPLNDV = GetPlantaSeleccionada() ' Me.cmbPlanta.SelectedValue

        objEntidad.CBRCNT = txtFiltroBrevete.Text.Trim

        Dim cant_pag As Decimal = 0
        Dim oList As New List(Of ENTIDADES.mantenimientos.TransportistaConductor)
        oList = obj.Listar_ConductoresPorTransportista(objEntidad, ucpag_conductor.PageNumber, ucpag_conductor.PageSize, cant_pag)
        ucpag_conductor.PageCount = cant_pag
        gwdResConductoresTransportista.DataSource = oList 'obj.Listar_ConductoresPorTransportista(objEntidad)

    End Sub
    '  'IN_NROPAG, PAGESIZE, TOTPAG

    Private Sub Exportar_Detalle(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarMant.Click

        Try

            '****************** EXPORTAR VEHÍCULOS  ****************  

            Dim NPOI_SC As New Ransa.Utilitario.HelpClass_NPOI_SC
            Dim Data_Vehiculo As New DataTable
            Data_Vehiculo = gwdResTractosTransportista.DataSource

            Dim dtExcel_Vehiculo As New DataTable
            Dim dr1 As DataRow

            dtExcel_Vehiculo.Columns.Add("NPLCUN").Caption = NPOI_SC.FormatDato("Placa Vehículo", NPOI_SC.keyDatoTexto)
            dtExcel_Vehiculo.Columns.Add("TMRCTR").Caption = NPOI_SC.FormatDato("Marca", NPOI_SC.keyDatoTexto)
            dtExcel_Vehiculo.Columns.Add("STPVHP_S").Caption = NPOI_SC.FormatDato("Tipo Vehículo", NPOI_SC.keyDatoTexto)
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
                dr1("STPVHP_S") = fila("STPVHP_S")
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
            dtExcel_Acoplado.Columns.Add("STPACP_S").Caption = NPOI_SC.FormatDato("Tipo Acoplado", NPOI_SC.keyDatoTexto)
            dtExcel_Acoplado.Columns.Add("NEJSUN").Caption = NPOI_SC.FormatDato("Ejes", NPOI_SC.keyDatoTexto)
            dtExcel_Acoplado.Columns.Add("FECINI").Caption = NPOI_SC.FormatDato("Fec. Ini. Asignación", NPOI_SC.keyDatoFecha)
            dtExcel_Acoplado.Columns.Add("FECFIN").Caption = NPOI_SC.FormatDato("Fec. Fin. Asignación", NPOI_SC.keyDatoFecha)
            dtExcel_Acoplado.Columns.Add("SESTAC").Caption = NPOI_SC.FormatDato("Estado Asignación", NPOI_SC.keyDatoTexto)
            dtExcel_Acoplado.Columns.Add("TOBS").Caption = NPOI_SC.FormatDato("Observaciones", NPOI_SC.keyDatoTexto)
         
            For Each fila As TransportistaAcoplado In Data_Acoplado
                dr2 = dtExcel_Acoplado.NewRow

                dr2("NPLCAC") = fila.NPLCAC
                dr2("STPACP_S") = fila.STPACP_S
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

            Dim objResultado As New Transportista
            objResultado = CType(TabTransportistaPropio.TabPages(Actual_TabPage).Controls(Actual_UcControl), ucInformacionTransportista).Resultado()

            Dim oLisFiltro As New List(Of SortedList)
            Dim F As New SortedList
            F.Add(0, "Compañia:| " & cmbCompania.Text)
            F.Add(1, "División:|" & cmbDivision.Text)
            'F.Add(2, "Planta:| " & cmbPlanta.Text)
            F.Add(3, "Transportista:| " & objResultado.NRUCTR & " - " & objResultado.TCMTRT.ToString.Trim)

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

    'Private Sub txtFiltroVehiculo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFiltroVehiculo.KeyDown
    '    Try
    '        If e.KeyCode = Keys.Enter Then
    '            Buscar_Filtro_Vehiculo(Nothing, Nothing)
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    'Private Sub txtFiltroAcoplado_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFiltroAcoplado.KeyDown
    '    Try
    '        If e.KeyCode = Keys.Enter Then
    '            Buscar_Filtro_Acoplado(Nothing, Nothing)
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    'Private Sub txtFiltroBrevete_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFiltroBrevete.KeyDown
    '    Try
    '        If e.KeyCode = Keys.Enter Then
    '            Buscar_Filtro_Brevete(Nothing, Nothing)
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub ucpagTracto_PageChanged(sender As Object, e As EventArgs) Handles ucpagTracto.PageChanged
        Try
            Listar_ResumenVehiculos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ucpag_acoplado_PageChanged(sender As Object, e As EventArgs) Handles ucpag_acoplado.PageChanged
        Try
            Listar_Acoplados_x_Transportista()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ucpag_conductor_PageChanged(sender As Object, e As EventArgs) Handles ucpag_conductor.PageChanged
        Try
            ListarConductor_X_Transportista()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
