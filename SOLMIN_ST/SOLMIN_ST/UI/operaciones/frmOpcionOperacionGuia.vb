Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO.Operaciones

Public Class frmOpcionOperacionGuia

#Region "Atributos"
    Private _OPCION As String
    Private _FechaInicio As String
    Private _FechaFin As String
    Private _Compania As String
    Private _Registro As String
    Private obj_Entidad As ConsumoNeumatico
    Private obj_EntidadCM As CostoMantenimiento
    Private objConNeu_BLL As New ConsumoNeumatico_BLL
    Private objCosMan_BLL As New CostoMantenimiento_BLL
    Private objOpeTra_BLL As New OperacionTransporte_BLL
    Private olConsumoNeumatico As List(Of ConsumoNeumatico)
    Private olCostoMantenimiento As List(Of CostoMantenimiento)
    Private olOperacionTransporte As List(Of OperacionTransporte)
    Private olConNeuOpe As List(Of ConsumoNeumatico)
    Private olCosManOpe As List(Of CostoMantenimiento)
    Private olCNNoEnc As List(Of ConsumoNeumatico)
    Private olCMNoEnc As List(Of CostoMantenimiento)
#End Region

#Region "Propiedades"
    Public ReadOnly Property OPCION() As String
        Get
            Return _OPCION
        End Get
    End Property
    Public ReadOnly Property FechaInicio2() As String
        Get
            Return _FechaInicio
        End Get
    End Property

    'Public WriteOnly Property FechaInicio() As String
    '    Set(ByVal value As String)
    '        _FechaInicio = value
    '    End Set
    'End Property


    Public Property FechaInicio() As String
        Get
            Return _FechaInicio
        End Get
        Set(ByVal value As String)
            _FechaInicio = value
        End Set
    End Property


    Public ReadOnly Property FechaFin() As String
        Get
            Return _FechaFin
        End Get
    End Property

    Public WriteOnly Property Compania() As String
        Set(ByVal value As String)
            _Compania = value
        End Set
    End Property
    '_Registro

    Public WriteOnly Property Registro() As String
        Set(ByVal value As String)
            _Registro = value
        End Set
    End Property
#End Region

#Region "Eventos"
    Private Sub frmOpcionOperacionGuia_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MostrarCostos()
        If _Registro = "N" Then
            dtgOperacion.Visible = True
            dtgOperacionCM.Visible = False
        Else
            dtgOperacion.Visible = False
            dtgOperacionCM.Visible = True
        End If
        dtpFechaInicio.Value = HelpClass.CNumero_a_Fecha(_FechaInicio)
        Dim Anio As Integer = HelpClass.CNumero_a_Fecha(_FechaInicio).Year
        Dim Mes As Integer = HelpClass.CNumero_a_Fecha(_FechaInicio).Month
        Dim Dias As Integer = System.DateTime.DaysInMonth(Anio, Mes)
        dtpFechaFin.Value = Dias.ToString() + "/" + IIf(Mes < 10, "0" & Mes.ToString(), Mes.ToString()) + "/" + Anio.ToString() ' HelpClass.CNumero_a_Fecha(Anio.ToString() + IIf(Mes < 10, "0" & Mes.ToString(), Mes.ToString()) + Dias.ToString())
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If _Registro = "N" Then
            Dim objConNeuOpe As New ConsumoNeumatico
            Dim obeCoNe As New ConsumoNeumatico
            Dim olVehiculo As New List(Of ConsumoNeumatico)
            obeCoNe.FECREG = _FechaInicio 'HelpClass.CFecha_a_Numero8Digitos(dtpFechaInicio.Value)
            obeCoNe.CCMPN = _Compania
            If olConNeuOpe IsNot Nothing And olConNeuOpe.Count > 0 Then
                If objConNeu_BLL.Validar_Existe_Consumo_Neumatico_Operacion(obeCoNe) > 0 Then
                    If objConNeu_BLL.Actualizar_Consumo_Neumatico_Operacion(olConNeuOpe).NLQNEM = 1 Then
                        objConNeuOpe = objConNeu_BLL.Registrar_Consumo_Neumatico_Operacion(olConNeuOpe)
                    Else
                        MessageBox.Show("No se eliminó las Operaciones de Consumos de Neumaticos ", "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Else
                    objConNeuOpe = objConNeu_BLL.Registrar_Consumo_Neumatico_Operacion(olConNeuOpe)
                End If
            End If

            If objConNeuOpe.NLQNEM <> 0 Then
                HelpClass.MsgBox("Se ha registrado los Consumo de Neumaticos satisfactoriamente", MessageBoxIcon.Information)
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK

        Else
            Try
                Dim objCosManOpe As New CostoMantenimiento
                Dim obeCoMa As New CostoMantenimiento
                obeCoMa.FECREG = _FechaInicio 'HelpClass.CFecha_a_Numero8Digitos(dtpFechaInicio.Value)
                obeCoMa.CCMPN = _Compania
                If olCosManOpe IsNot Nothing And olCosManOpe.Count > 0 Then
                    If objCosMan_BLL.Validar_Existe_Costo_Mantenimiento_Operacion(obeCoMa) > 0 Then
                        If objCosMan_BLL.Actualizar_Costo_Mantenimiento_Operacion(olCosManOpe).NLQMNT = 1 Then
                            objCosManOpe = objCosMan_BLL.Registrar_Costo_Mantenimiento_Operacion(olCosManOpe)
                        Else
                            MessageBox.Show("No se eliminó las Operaciones de Consumos de Neumaticos ", "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        objCosManOpe = objCosMan_BLL.Registrar_Costo_Mantenimiento_Operacion(olCosManOpe)
                    End If
                End If
                If objCosManOpe.NLQMNT <> 0 Then
                    HelpClass.MsgBox("Se ha registrado los Costos de Mantenimiento satisfactoriamente", MessageBoxIcon.Information)
                End If

                Me.DialogResult = Windows.Forms.DialogResult.OK
            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If _Registro = "N" Then
            Listar_Vehiculo()
            Listar_Operacion()
            Cargar_Grilla_Operaciones()
        Else
            Listar_Vehiculo_Mantenimiento()
            Listar_Operacion_Mantenimiento()
            Cargar_Grilla_Operaciones_Mantenimiento()
        End If

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If _Registro = "N" Then
            Dim lint_indice As Integer = Me.dtgOperacion.CurrentCellAddress.Y
            If lint_indice >= 0 Then
                Me.dtgOperacion.Rows.RemoveAt(lint_indice)
                olConNeuOpe.RemoveAt(lint_indice)
            End If
        Else
            Dim lint_indice As Integer = Me.dtgOperacionCM.CurrentCellAddress.Y
            If lint_indice >= 0 Then
                Me.dtgOperacionCM.Rows.RemoveAt(lint_indice)
                olCosManOpe.RemoveAt(lint_indice)
            End If
        End If

    End Sub

#End Region

#Region "Metodos y Funciones"

    Private Sub Validar_Suma_Costo_Consumo_Neumatico_Operacion(ByVal olVehiculo As List(Of ConsumoNeumatico))
        For Each obeVehiculo As ConsumoNeumatico In olVehiculo
            Dim SumaTot As Double = 0
            Dim DifConNeu As Double = 0
            Dim Placa As String = ""
            Dim MayorIGSTOP As Double = 0

            For Each obeConNeuc As ConsumoNeumatico In olConNeuOpe
                obeConNeuc.IGSTOP = Math.Round(obeConNeuc.IGSTOP, 2)
                If obeConNeuc.NPLCUN = obeVehiculo.NPLCUN Then
                    SumaTot += obeConNeuc.IGSTOP
                    If MayorIGSTOP = 0 Then
                        Placa = obeConNeuc.NPLCUN
                        MayorIGSTOP = (obeConNeuc.IGSTOP)
                    Else
                        If MayorIGSTOP < obeConNeuc.IGSTOP Then
                            Placa = obeConNeuc.NPLCUN
                            MayorIGSTOP = obeConNeuc.IGSTOP
                        End If
                    End If
                End If
            Next
            If (Math.Round(SumaTot, 2) - obeVehiculo.IMPTTL) > 0 Or (Math.Round(SumaTot, 2) - obeVehiculo.IMPTTL) < 0 Then
                DifConNeu = SumaTot - obeVehiculo.IMPTTL
                For Each obeConNeuc As ConsumoNeumatico In olConNeuOpe
                    If obeConNeuc.NPLCUN = Placa And obeConNeuc.IGSTOP = MayorIGSTOP Then
                        obeConNeuc.IGSTOP = obeConNeuc.IGSTOP - Math.Round(DifConNeu, 2)
                        Exit For
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub Validar_Suma_Costo_Consumo_Mantenimiento_Operacion(ByVal olVehiculo As List(Of CostoMantenimiento))
        For Each obeVehiculo As CostoMantenimiento In olVehiculo
            Dim SumaTot As Double = 0
            Dim DifCosMan As Double = 0
            Dim Placa As String = ""
            Dim MayorIGSTOP As Double = 0

            For Each obeCosManm As CostoMantenimiento In olCosManOpe
                obeCosManm.IGSTOP = Math.Round(obeCosManm.IGSTOP, 2)
                If obeCosManm.NPLCUN = obeVehiculo.NPLCUN Then
                    SumaTot += obeCosManm.IGSTOP
                    If MayorIGSTOP = 0 Then
                        Placa = obeCosManm.NPLCUN
                        MayorIGSTOP = (obeCosManm.IGSTOP)
                    Else
                        If MayorIGSTOP < obeCosManm.IGSTOP Then
                            Placa = obeCosManm.NPLCUN
                            MayorIGSTOP = obeCosManm.IGSTOP
                        End If
                    End If
                End If
            Next
            If (Math.Round(SumaTot, 2) - obeVehiculo.TOTALS) > 0 Or (Math.Round(SumaTot, 2) - obeVehiculo.TOTALS) < 0 Then
                DifCosMan = SumaTot - obeVehiculo.TOTALS
                For Each obeCosManm As CostoMantenimiento In olCosManOpe
                    If obeCosManm.NPLCUN = Placa And obeCosManm.IGSTOP = MayorIGSTOP Then
                        obeCosManm.IGSTOP = obeCosManm.IGSTOP - Math.Round(DifCosMan, 2)
                        Exit For
                    End If
                Next
            End If
        Next
    End Sub


    Private Sub MostrarCostos()

        Dim odtCosto As New DataTable
        odtCosto.Columns.Add("key")
        odtCosto.Columns.Add("value")

        odtCosto.Rows.Add(New Object() {"K", "Kilómetros"})
        odtCosto.Rows.Add(New Object() {"P", "Peso Mercadería"})
        If _Registro = "M" Then
            odtCosto.Rows.Add(New Object() {"O", "Cant. Operación"})
        End If

        cboCosto.DataSource = odtCosto
        cboCosto.ValueMember = "key"
        cboCosto.DisplayMember = "value"
        cboCosto.SelectedIndex = 0
    End Sub

    Private Sub Listar_Vehiculo()
        obj_Entidad = New ConsumoNeumatico
        olConsumoNeumatico = New List(Of ConsumoNeumatico)
        obj_Entidad.FECREG = _FechaInicio
        obj_Entidad.CCMPN = _Compania
        olConsumoNeumatico = objConNeu_BLL.Listar_Vehiculo_X_Mes_Anio(obj_Entidad)
    End Sub

    Private Sub Listar_Operacion()
        Dim objParametro As New Hashtable
        olOperacionTransporte = New List(Of OperacionTransporte)
        If rbnOperacion.Checked = True Then
            objParametro.Add("OPCION", "O")
        Else
            objParametro.Add("OPCION", "G")
        End If
        objParametro.Add("FECINI", HelpClass.CFecha_a_Numero8Digitos(dtpFechaInicio.Value))
        objParametro.Add("FECFIN", HelpClass.CFecha_a_Numero8Digitos(dtpFechaFin.Value))
        objParametro.Add("CCMPN", _Compania)
        olOperacionTransporte = objOpeTra_BLL.Listar_Operacion_X_Fecha_CN(objParametro)
    End Sub

    Private Sub Cargar_Grilla_Operaciones()
        olConNeuOpe = New List(Of ConsumoNeumatico)
        olCNNoEnc = New List(Of ConsumoNeumatico)
        Dim obeConNeu2 As ConsumoNeumatico
        Dim olConNeut As New List(Of ConsumoNeumatico)
        Dim obeConNemt As ConsumoNeumatico
        Dim adi As Integer = 0
        'Crear otra Lista de Consumo para sumar Importe Total de las Placas de Unidades que se repitan
        For Each obeConNeu As ConsumoNeumatico In olConsumoNeumatico
            If olConNeut.Count = 0 Then
                obeConNemt = New ConsumoNeumatico
                obeConNemt.NPLCUN = obeConNeu.NPLCUN
                obeConNemt.IMPTTL = obeConNeu.IMPTTL
                olConNeut.Add(obeConNemt)
                obeConNemt = Nothing
            Else
                For Each obeConNemt2 As ConsumoNeumatico In olConNeut
                    If obeConNemt2.NPLCUN = obeConNeu.NPLCUN Then
                        obeConNemt2.IMPTTL += obeConNeu.IMPTTL
                        adi = 1
                        Exit For
                    End If
                Next
                If adi = 0 Then
                    obeConNemt = New ConsumoNeumatico
                    obeConNemt.NPLCUN = obeConNeu.NPLCUN
                    obeConNemt.IMPTTL = obeConNeu.IMPTTL
                    olConNeut.Add(obeConNemt)
                End If
                adi = 0
            End If
        Next

        'Utilizar la Nueva Lista de Placas olConNeut para buscar en olOperacionTransporte
        For Each obeConNeu As ConsumoNeumatico In olConNeut
            Dim SumaKil As Double = 0
            Dim SumaPeso As Double = 0
            For Each obeOpeTra As OperacionTransporte In olOperacionTransporte
                If obeConNeu.NPLCUN = obeOpeTra.NPLCUN Then
                    obeConNeu2 = New ConsumoNeumatico
                    obeConNeu2.CCMPN = _Compania
                    obeConNeu2.FLQCNM = _FechaInicio
                    obeConNeu2.NPLCUN = obeOpeTra.NPLCUN
                    obeConNeu2.NOPRCN = obeOpeTra.NOPRCN
                    obeConNeu2.NKMRCR = obeOpeTra.QKMREC
                    obeConNeu2.PMRCMC = obeOpeTra.PMRCMC
                    obeConNeu2.CULUSA = MainModule.USUARIO
                    obeConNeu2.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                    olConNeuOpe.Add(obeConNeu2)
                    If cboCosto.SelectedValue = "K" Then
                        SumaKil += obeOpeTra.QKMREC
                    Else
                        SumaPeso += obeOpeTra.PMRCMC
                    End If
                End If
            Next
            If cboCosto.SelectedValue = "K" Then
                If SumaKil > 0 Then
                    For Each obeCsNm As ConsumoNeumatico In olConNeuOpe
                        If obeConNeu.NPLCUN = obeCsNm.NPLCUN Then
                            obeCsNm.IGSTOP = obeCsNm.NKMRCR * obeConNeu.IMPTTL / SumaKil
                        End If
                    Next
                Else
                    'Lista de Placas de Excel No Encontrados para mostrar en Popup
                    Dim CNNoEnc As New ConsumoNeumatico
                    CNNoEnc.NPLCUN = obeConNeu.NPLCUN
                    CNNoEnc.IMPTTL = obeConNeu.IMPTTL
                    olCNNoEnc.Add(CNNoEnc)
                End If
            Else
                If SumaPeso > 0 Then
                    For Each obeCsNm As ConsumoNeumatico In olConNeuOpe
                        If obeConNeu.NPLCUN = obeCsNm.NPLCUN Then
                            obeCsNm.IGSTOP = obeCsNm.PMRCMC * obeConNeu.IMPTTL / SumaPeso
                        End If
                    Next
                Else
                    Dim CNNoEnc As New ConsumoNeumatico
                    CNNoEnc.NPLCUN = obeConNeu.NPLCUN
                    CNNoEnc.IMPTTL = obeConNeu.IMPTTL
                    olCNNoEnc.Add(CNNoEnc)
                End If
            End If
        Next

        'Validar que Suma de Costos de Vehiculos de la RZST44 coincida con olConNeuOpe(prorrateado)
        Dim obeCoNe As New ConsumoNeumatico
        Dim olVehiculo As New List(Of ConsumoNeumatico)
        obeCoNe.FECREG = _FechaInicio
        obeCoNe.CCMPN = _Compania

        olVehiculo = objConNeu_BLL.Listar_Vehiculo_X_Mes_Anio(obeCoNe)
        Validar_Suma_Costo_Consumo_Neumatico_Operacion(olVehiculo)

        'Cargar el prorrateo en la grilla
        Cargar_Operacion()

        'Lista Placas no encontradas en RZTR05
        If olCNNoEnc.Count > 0 Then
            Dim ofrmOpcionConsumoOperacion As New frmOpcionConsumoOperacion
            With ofrmOpcionConsumoOperacion
                .olbeConNeu = olCNNoEnc
                .Flag = "N"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                End If
            End With
        End If
    End Sub

    Private Sub Cargar_Operacion()
        Me.dtgOperacion.Rows.Clear()
        'Dim rowData As DataRow
        Dim dwvrow As DataGridViewRow
        For Each obeConsNeu As ConsumoNeumatico In olConNeuOpe
            dwvrow = New DataGridViewRow
            dwvrow.CreateCells(Me.dtgOperacion)
            dwvrow.Cells(0).Value = obeConsNeu.NPLCUN
            dwvrow.Cells(1).Value = obeConsNeu.NOPRCN
            dwvrow.Cells(2).Value = obeConsNeu.NKMRCR
            dwvrow.Cells(3).Value = obeConsNeu.PMRCMC
            dwvrow.Cells(4).Value = obeConsNeu.IGSTOP
            Me.dtgOperacion.Rows.Add(dwvrow)
        Next
    End Sub

    Private Sub Cargar_Operacion_ConMan()
        Me.dtgOperacionCM.Rows.Clear()
        Dim dwvrow As DataGridViewRow
        For Each obeCostMan As CostoMantenimiento In olCosManOpe
            dwvrow = New DataGridViewRow
            dwvrow.CreateCells(Me.dtgOperacionCM)
            dwvrow.Cells(0).Value = obeCostMan.NPLCUN
            dwvrow.Cells(1).Value = obeCostMan.NOPRCN
            dwvrow.Cells(2).Value = obeCostMan.NKMRCR
            dwvrow.Cells(3).Value = obeCostMan.PMRCMC
            dwvrow.Cells(4).Value = obeCostMan.IGSTOP
            Me.dtgOperacionCM.Rows.Add(dwvrow)
        Next
    End Sub

    Private Sub Listar_Vehiculo_Mantenimiento()
        obj_EntidadCM = New CostoMantenimiento
        olCostoMantenimiento = New List(Of CostoMantenimiento)
        obj_EntidadCM.FECREG = _FechaInicio
        obj_EntidadCM.CCMPN = _Compania
        olCostoMantenimiento = objCosMan_BLL.Listar_Vehiculo_CM_X_Mes_Anio(obj_EntidadCM)
    End Sub

    Private Sub Listar_Operacion_Mantenimiento()
        Dim objParametro As New Hashtable
        olOperacionTransporte = New List(Of OperacionTransporte)
        If rbnOperacion.Checked = True Then
            objParametro.Add("OPCION", "O")
        Else
            objParametro.Add("OPCION", "G")
        End If
        objParametro.Add("FECINI", HelpClass.CFecha_a_Numero8Digitos(dtpFechaInicio.Value))
        objParametro.Add("FECFIN", HelpClass.CFecha_a_Numero8Digitos(dtpFechaFin.Value))
        objParametro.Add("CCMPN", _Compania)
        olOperacionTransporte = objOpeTra_BLL.Listar_Operacion_X_Fecha_CM(objParametro)
    End Sub

    Private Sub Cargar_Grilla_Operaciones_Mantenimiento()
        olCosManOpe = New List(Of CostoMantenimiento)
        olCMNoEnc = New List(Of CostoMantenimiento)
        Dim olCosMant As New List(Of CostoMantenimiento)
        Dim obeCosMntn As CostoMantenimiento
        Dim obeCosMan2 As CostoMantenimiento
        olCosManOpe = New List(Of CostoMantenimiento)
        Dim adi As Integer = 0
        'Crear otra Lista de Consumo para sumar Importe Total de las Placas de Unidades que se repitan
        For Each obeCosMan As CostoMantenimiento In olCostoMantenimiento
            If olCosMant.Count = 0 Then
                obeCosMntn = New CostoMantenimiento
                obeCosMntn.NPLCUN = obeCosMan.NPLCUN
                obeCosMntn.TOTALS = obeCosMan.TOTALS
                olCosMant.Add(obeCosMntn)
                obeCosMntn = Nothing
            Else
                For Each obeCosMant2 As CostoMantenimiento In olCosMant
                    If obeCosMant2.NPLCUN = obeCosMan.NPLCUN Then
                        obeCosMant2.TOTALS += obeCosMan.TOTALS
                        adi = 1
                        Exit For
                    End If
                Next
                If adi = 0 Then
                    obeCosMntn = New CostoMantenimiento
                    obeCosMntn.NPLCUN = obeCosMan.NPLCUN
                    obeCosMntn.TOTALS = obeCosMan.TOTALS
                    olCosMant.Add(obeCosMntn)
                End If
                adi = 0
            End If
        Next

        'Utilizar la Nueva Lista de Placas olConNeut para buscar en olOperacionTransporte
        For Each obeCosMan As CostoMantenimiento In olCosMant
            Dim Contador As Double = 0
            Dim SumaKM As Double = 0
            Dim SumaPM As Double = 0
            For Each obeOpeTra As OperacionTransporte In olOperacionTransporte
                If obeCosMan.NPLCUN = obeOpeTra.NPLCUN Then
                    obeCosMan2 = New CostoMantenimiento
                    obeCosMan2.CCMPN = _Compania
                    obeCosMan2.FLQCMM = _FechaInicio
                    obeCosMan2.NPLCUN = obeOpeTra.NPLCUN
                    obeCosMan2.NOPRCN = obeOpeTra.NOPRCN
                    obeCosMan2.NKMRCR = obeOpeTra.QKMREC
                    obeCosMan2.PMRCMC = obeOpeTra.PMRCMC
                    obeCosMan2.CULUSA = MainModule.USUARIO
                    obeCosMan2.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                    olCosManOpe.Add(obeCosMan2)
                    If cboCosto.SelectedValue = "K" Then
                        SumaKM += obeOpeTra.QKMREC
                    ElseIf cboCosto.SelectedValue = "P" Then
                        SumaPM += obeOpeTra.PMRCMC
                    Else
                        Contador += 1
                    End If

                End If
            Next
            'Valida si ha seleccionado prorratear por Kilometros
            If cboCosto.SelectedValue = "K" Then
                If SumaKM > 0 Then
                    For Each obeCsMn As CostoMantenimiento In olCosManOpe
                        If obeCosMan.NPLCUN = obeCsMn.NPLCUN Then
                            obeCsMn.IGSTOP = obeCsMn.NKMRCR * obeCosMan.TOTALS / SumaKM
                        End If
                    Next
                Else
                    'Lista de Placas de Excel No Encontrados para mostrar en Popup
                    Dim CMNoEnc As New CostoMantenimiento
                    CMNoEnc.NPLCUN = obeCosMan.NPLCUN
                    CMNoEnc.TOTALS = obeCosMan.TOTALS
                    olCMNoEnc.Add(CMNoEnc)
                End If
                'Valida si ha seleccionado prorratear por Peso Mercaderia
            ElseIf cboCosto.SelectedValue = "P" Then
                If SumaPM > 0 Then
                    For Each obeCsMn As CostoMantenimiento In olCosManOpe
                        If obeCosMan.NPLCUN = obeCsMn.NPLCUN Then
                            obeCsMn.IGSTOP = obeCsMn.PMRCMC * obeCosMan.TOTALS / SumaPM
                        End If
                    Next
                Else
                    'Lista de Placas de Excel No Encontrados para mostrar en Popup
                    Dim CMNoEnc As New CostoMantenimiento
                    CMNoEnc.NPLCUN = obeCosMan.NPLCUN
                    CMNoEnc.TOTALS = obeCosMan.TOTALS
                    olCMNoEnc.Add(CMNoEnc)
                End If
                'Valida si ha seleccionado prorratear por Operacion
            Else
                If Contador > 0 Then
                    For Each obeCsNm As CostoMantenimiento In olCosManOpe
                        If obeCosMan.NPLCUN = obeCsNm.NPLCUN Then
                            obeCsNm.IGSTOP = obeCosMan.TOTALS / Contador
                        End If
                    Next
                Else
                    'Lista de Placas de Excel No Encontrados para mostrar en Popup
                    Dim CMNoEnc As New CostoMantenimiento
                    CMNoEnc.NPLCUN = obeCosMan.NPLCUN
                    CMNoEnc.TOTALS = obeCosMan.TOTALS
                    olCMNoEnc.Add(CMNoEnc)
                End If
            End If
        Next

        'Validar que Suma de Costos de Vehiculos de la RZST44 coincida con olConNeuOpe(prorrateado)
        Dim obeCoMa As New CostoMantenimiento
        Dim olVehiculo As New List(Of CostoMantenimiento)
        obeCoMa.FECREG = _FechaInicio
        obeCoMa.CCMPN = _Compania

        olVehiculo = objCosMan_BLL.Listar_Vehiculo_CM_X_Mes_Anio(obeCoMa)
        Validar_Suma_Costo_Consumo_Mantenimiento_Operacion(olVehiculo)

        Cargar_Operacion_ConMan()
        If olCMNoEnc.Count > 0 Then
            Dim ofrmOpcionConsumoOperacion As New frmOpcionConsumoOperacion
            With ofrmOpcionConsumoOperacion
                .olbeCosMnt = olCMNoEnc
                .Flag = "M"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                End If
            End With
        End If
    End Sub

#End Region


End Class
