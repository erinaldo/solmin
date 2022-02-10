Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports System.Text


Public Class frmAsignarGFH
#Region "Properties"
    Private mCCMPN As String = ""
    Private mCDVSN As String = ""
    Private mCPLNDV As Double = 0
    Private mNRUCTR As Double = 0
    Private mACOPL As String = ""
    Private mNPLCUN As String = ""
    Private mCTPCRA As String = ""
    Private mTCMCRA As String = ""

    Public WriteOnly Property Compania() As String
        Set(ByVal value As String)
            mCCMPN = value
        End Set
    End Property

    Public WriteOnly Property Division() As String
        Set(ByVal value As String)
            mCDVSN = value
        End Set
    End Property

    Public WriteOnly Property Planta() As Double
        Set(ByVal value As Double)
            mCPLNDV = value
        End Set
    End Property

    Public WriteOnly Property NroRucTransportista() As Double
        Set(ByVal value As Double)
            mNRUCTR = value
        End Set
    End Property

    Public Property CodTipoCarroceria() As String
        Get
            Return mCTPCRA
        End Get
        Set(ByVal value As String)
            mCTPCRA = value
        End Set
    End Property

    Public Property NroAcoplado() As String
        Get
            Return mACOPL
        End Get
        Set(ByVal value As String)
            mACOPL = value
        End Set
    End Property

    Public WriteOnly Property NroPlacaUnidad() As String
        Set(ByVal value As String)
            mNPLCUN = value
        End Set
    End Property

    Public ReadOnly Property TipoCarroceria() As String
        Get
            Return mTCMCRA
        End Get
    End Property
#End Region

#Region "Eventos"
    Private Sub frmAsignarUbicacionUnidad_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Cargar_Combo_Tracto(mNRUCTR, mNPLCUN)
        Cargar_Combo_Acoplado(mNRUCTR, mACOPL)
        Cargar_Tipo_Carroceria()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        If Me.Validar_Inputs = True Then Exit Sub

        Dim objEntidad As New Tracto
        Dim objTracto_BLL As New Tracto_BLL
        objEntidad.CCMPN = mCCMPN
        objEntidad.CDVSN = mCDVSN
        objEntidad.CPLNDV = mCPLNDV
        objEntidad.NRUCTR = mNRUCTR
        objEntidad.NPLCUN = mNPLCUN
        If Me.cboTipoVehiculo.Resultado IsNot Nothing Then
            If CType(Me.cboTipoVehiculo.Resultado, TipoCarroceria).CTPCRA = "" Then
                objEntidad.CTPCRA = 0
            Else
                objEntidad.CTPCRA = CType(Me.cboTipoVehiculo.Resultado, TipoCarroceria).CTPCRA
            End If
        End If
        objEntidad.NPLCAC = cboAcoplados.pNroAcoplado
        objEntidad.TCMCND = cboListaCondicion.Text
        objEntidad.FECSEG = CType(HelpClass.CtypeDate(Me.dtpFecha.Value), Double)
        objEntidad.HRASEG = CType(HelpClass.ConvertHoraNumeric(txtHora.Text), Double)
        objEntidad.TDSDES = txtUbicacion.Text.Trim
        objEntidad.CUSCRT = MainModule.USUARIO
        objEntidad.FCHCRT = HelpClass.TodayNumeric
        objEntidad.HRACRT = HelpClass.NowNumeric
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

        If objTracto_BLL.Registrar_Bitacora_Vehiculo(objEntidad).NMRCRL > 0 Then
            MessageBox.Show("Se ha registrado satisfactoriamente")
            mACOPL = cboAcoplados.pNroAcoplado

            If Me.cboTipoVehiculo.Resultado IsNot Nothing Then
                If CType(Me.cboTipoVehiculo.Resultado, TipoCarroceria).CTPCRA = "" Then
                    mCTPCRA = 0
                    mTCMCRA = ""
                Else
                    mCTPCRA = CType(Me.cboTipoVehiculo.Resultado, TipoCarroceria).CTPCRA
                    mTCMCRA = CType(Me.cboTipoVehiculo.Resultado, TipoCarroceria).TCMCRA
                End If
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If

    End Sub
#End Region

#Region "Métodos y Funciones"

    Private Sub Cargar_Tipo_Carroceria()
        Dim objTipoCarroceria As New TipoCarroceria_BLL

        Dim objLogica As New TipoCarroceria_BLL
        Dim objLista As New List(Of TipoCarroceria)
        objLista = objLogica.Listar_TipoCarroceria(mCCMPN)

        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CTPCRA"
        oColumnas.DataPropertyName = "CTPCRA"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCMCRA"
        oColumnas.DataPropertyName = "TCMCRA"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oColumnas.HeaderText = "Descripción"
        oListColum.Add(2, oColumnas)
        Me.cboTipoVehiculo.DataSource = objLista
        Me.cboTipoVehiculo.ListColumnas = oListColum
        Me.cboTipoVehiculo.Cargas()
        Me.cboTipoVehiculo.DispleyMember = "TCMCRA"
        Me.cboTipoVehiculo.ValueMember = "CTPCRA"
        If mCTPCRA <> "0" Then
            Me.cboTipoVehiculo.Valor = mCTPCRA
            cboTipoVehiculo.Enabled = False
        Else
            Me.cboTipoVehiculo.Limpiar()
            cboTipoVehiculo.Enabled = True
        End If
    End Sub

    Private Sub Cargar_Combo_Acoplado(Optional ByVal NroRucTransportista As String = "", Optional ByVal NroAcoplado As String = "")
        Try
            Dim obeAcoplado As New Ransa.TypeDef.Transportista.TD_AcopladoTransportistaPK
            obeAcoplado.pCCMPN_Compania = mCCMPN
            obeAcoplado.pCDVSN_Division = mCDVSN
            obeAcoplado.pCPLNDV_Planta = mCPLNDV
            obeAcoplado.pNRUCTR_RucTransportista = NroRucTransportista
            obeAcoplado.pNPLCAC_NroAcoplado = NroAcoplado
            Me.cboAcoplados.pCargar(obeAcoplado)
            If cboAcoplados.pNroAcoplado <> "" Then
                cboAcoplados.Enabled = False
            Else
                cboAcoplados.Enabled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Cargar_Combo_Tracto(Optional ByVal NroRucTransportista As String = "", Optional ByVal NroPlacaUnidad As String = "")
        Try
            Dim obeTracto As New Ransa.TypeDef.Transportista.TD_TractoTransportistaPK
            obeTracto.pCCMPN_Compania = mCCMPN
            obeTracto.pCDVSN_Division = mCDVSN
            obeTracto.pCPLNDV_Planta = mCPLNDV
            obeTracto.pNRUCTR_RucTransportista = NroRucTransportista
            'ctbVehiculo.pCargar(obeTracto)
            obeTracto.pNPLCUN_NroPlacaUnidad = NroPlacaUnidad
            cboVehiculos.pCargar(obeTracto)
        Catch ex As Exception
        End Try
    End Sub

    Private Function Validar_Inputs() As Boolean
        Dim lstr_validacion As String = ""
        Dim lbool_existe_error As Boolean = False
        If Me.cboVehiculos.pNroPlacaUnidad = "" Then
            lstr_validacion += "* TRACTO " & Chr(13)
        End If
        If Me.cboTipoVehiculo.Resultado IsNot Nothing Then
            If CType(Me.cboTipoVehiculo.Resultado, TipoCarroceria).CTPCRA = "" Then
                lstr_validacion += "* TIPO DE VEHICULO" & Chr(13)
            End If
        End If
        If cboListaCondicion.Text = "" Then
            lstr_validacion += "* CONDICIÓN " & Chr(13)
        End If
        If HelpClass.CDate_a_Numero8Digitos(Me.dtpFecha.Value) = 0 Then
            lstr_validacion += "* FECHA " & Chr(13)
        End If
        If txtHora.Text = "  :  :" Then
            txtHora.Text = "00:00:00"
        End If
        If HelpClass.ConvertHoraNumeric(txtHora.Text) = 0 Then
            lstr_validacion += "* HORA " & Chr(13)
        Else
            Dim isValidTime As Boolean = IsDate(txtHora.Text)
            If isValidTime = True Then
            Else
                lstr_validacion += "* HORA INVALIDA" & Chr(13)
            End If
        End If

        If txtUbicacion.Text = "" Then
            lstr_validacion += "* UBICACIÓN " & Chr(13)
        End If
        If lstr_validacion <> "" Then
            HelpClass.MsgBox("DEBE DE INGRESAR :" & Chr(13) & lstr_validacion)
            lbool_existe_error = True
        End If

        Return lbool_existe_error
    End Function
#End Region


    'Private Sub txtHora_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHora.TextChanged
    '    Dim isValidTime As Boolean
    '    If isValidTime = IsDate(dtpFecha.Value) = True Then

    '    Else
    '        MessageBox.Show("DEBE INGRESAR HORA VÁLIDA", "ERROR", MessageBoxButtons.OK)
    '        dtpFecha.Focus()
    '    End If
    'End Sub
End Class
