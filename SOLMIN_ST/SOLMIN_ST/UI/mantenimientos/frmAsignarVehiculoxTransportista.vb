Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports System.Data
Imports System.Collections.Generic

Public Class frmAsignarVehiculoxTransportista
    Private _RUC As String = ""
    Private _RAZONSOCIAL As String = ""
    Private _CCMP As String = ""
    Public Property CCMP() As String
        Get
            Return _CCMP
        End Get
        Set(ByVal value As String)
            _CCMP = value
        End Set
    End Property
    Private Sub frmAsignarVehiculoxTransportista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'cargarComboVehiculos()
        Try
            Dim objEntidad As New Tracto
            Dim obj As New Tracto_BLL
            objEntidad.NPLCUN = ""
            objEntidad.CCMPN = CCMP
            cboVehiculos.DataSource = HelpClass.GetDataSetNative(obj.Listar_Tracto(objEntidad))
            cboVehiculos.ValueField = "TMRCTR"
            cboVehiculos.KeyField = "NPLCUN"
            cboVehiculos.DataBind()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub cargarComboVehiculos()
    '    Try
    '        Dim objEntidad As New Tracto
    '        Dim obj As New Tracto_BLL
    '        objEntidad.NPLCUN = ""
    '        objEntidad.CCMPN = CCMP
    '        cboVehiculos.DataSource = HelpClass.GetDataSetNative(obj.Listar_Tracto(objEntidad))
    '        cboVehiculos.ValueField = "TMRCTR"
    '        cboVehiculos.KeyField = "NPLCUN"
    '        cboVehiculos.DataBind()
    '    Catch ex As Exception
    '    End Try
    'End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            If cboVehiculos.Codigo <> "" Then
                Registrar_VehiculoTransportista()
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub Registrar_VehiculoTransportista()
        Dim objEntidadTT As New TransportistaTracto
        Dim objLogica As New TransportistaTracto_BLL

        objEntidadTT.NRUCTR = _RUC
        objEntidadTT.NPLCUN = cboVehiculos.Codigo.Trim
        objEntidadTT.FECINI = HelpClass.TodayNumeric
        objEntidadTT.FECFIN = HelpClass.TodayNumeric
        objEntidadTT.TOBS = txtObsTractoTransportista.Text
        objEntidadTT.CUSCRT = MainModule.USUARIO
        objEntidadTT.FCHCRT = HelpClass.TodayNumeric
        objEntidadTT.HRACRT = HelpClass.NowNumeric
        objEntidadTT.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidadTT.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidadTT.POS_RUC_ANTERIOR = ""
        objEntidadTT.FLAG_SKIPCHECKS = 0
        objEntidadTT.SESTCM = ""
        objEntidadTT.CCMPN = CCMP

        Dim objExisteTT As New TransportistaTracto
        objExisteTT = objEntidadTT
        objExisteTT.CCMPN = CCMP
        'objExisteTT = objLogica.Registrar_TransportistaTracto(objExisteTT)

        'If objExisteTT.NRUCTR = "-1" Then 'ocurrió un error
        '    HelpClass.ErrorMsgBox()
        '    Exit Sub

        'ElseIf objExisteTT.POS_RUC_ANTERIOR = "" Then 'no existe
        '    objEntidadTT.FLAG_SKIPCHECKS = 1
        '    objEntidadTT = objLogica.Registrar_TransportistaTracto(objEntidadTT)
        '    If objEntidadTT.NRUCTR = "-1" Then
        '        HelpClass.ErrorMsgBox()
        '        Exit Sub

        '    End If

        'ElseIf objExisteTT.POS_RUC_ANTERIOR <> "" Then 'existe la combinacion NRUCTR-NPLCUN

        '    Dim objLogicaCia As New Transportista_BLL

        '    'valida q no se asigne a la misma cia q ya lo tiene
        '    If objExisteTT.POS_RUC_ANTERIOR = objEntidadTT.NRUCTR Then
        '        'se pretendio asignar a una cia q ya lo tuvo o tiene asignado
        '        If objExisteTT.SESTCM = "*" Then
        '            objEntidadTT.FLAG_SKIPCHECKS = 1
        '            objEntidadTT.CCMPN = CCMP
        '            objEntidadTT = objLogica.Registrar_TransportistaTracto(objEntidadTT)
        '            If objEntidadTT.NRUCTR = "-1" Then
        '                HelpClass.ErrorMsgBox()
        '                Exit Sub

        '            End If
        '        Else
        '            HelpClass.MsgBox("Tracto ya asignado.", MessageBoxIcon.Error)
        '            Exit Sub
        '        End If

        '    Else 'cambio de otra compañia
        '        Dim objCia1 As New Transportista
        '        objCia1.NRUCTR = objExisteTT.POS_RUC_ANTERIOR
        '        objCia1 = objLogicaCia.Listar_Transportista(objCia1).Item(0)

        '        Dim strMsg As String = "Tracto ya asignado a una compañía" & vbCrLf & _
        '                                "Tracto: " & objExisteTT.NPLCUN & vbCrLf & _
        '                                "Compañía: " & objCia1.TCMTRT & vbCrLf & _
        '                                "¿Desea cambiarlo a la compañía " & _RAZONSOCIAL & " ?"
        '        If MsgBox(strMsg, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
        '            objEntidadTT.FLAG_SKIPCHECKS = 1
        '            objEntidadTT.CCMPN = CCMP
        '            objEntidadTT = objLogica.Registrar_TransportistaTracto(objEntidadTT)
        '            If objEntidadTT.NRUCTR = "-1" Then
        '                HelpClass.ErrorMsgBox()
        '                Exit Sub

        '            End If
        '        End If

        '    End If

        'End If 'End de Existe la combinacion NRUCTR-NPLCUN

        objExisteTT = objLogica.Registrar_TransportistaTracto(objExisteTT)

        'If objExisteTT.NRUCTR = "-1" Then 'ocurrió un error
        '    HelpClass.ErrorMsgBox()
        '    Exit Sub

        'Else
        If objExisteTT.POS_RUC_ANTERIOR = "" Then 'no existe
            objEntidadTT.FLAG_SKIPCHECKS = 1
            objEntidadTT = objLogica.Registrar_TransportistaTracto(objEntidadTT)
            'If objEntidadTT.NRUCTR = "-1" Then
            '    HelpClass.ErrorMsgBox()
            '    Exit Sub

            'End If

        ElseIf objExisteTT.POS_RUC_ANTERIOR <> "" Then 'existe la combinacion NRUCTR-NPLCUN

            Dim objLogicaCia As New Transportista_BLL

            'valida q no se asigne a la misma cia q ya lo tiene
            If objExisteTT.POS_RUC_ANTERIOR = objEntidadTT.NRUCTR Then
                'se pretendio asignar a una cia q ya lo tuvo o tiene asignado
                If objExisteTT.SESTCM = "*" Then
                    objEntidadTT.FLAG_SKIPCHECKS = 1
                    objEntidadTT.CCMPN = CCMP
                    objEntidadTT = objLogica.Registrar_TransportistaTracto(objEntidadTT)
                    'If objEntidadTT.NRUCTR = "-1" Then
                    '    HelpClass.ErrorMsgBox()
                    '    Exit Sub
                    'End If
                Else
                    HelpClass.MsgBox("Tracto ya asignado.", MessageBoxIcon.Error)
                    Exit Sub
                End If

            Else 'cambio de otra compañia
                Dim objCia1 As New Transportista
                objCia1.NRUCTR = objExisteTT.POS_RUC_ANTERIOR
                Dim olbeCia1 As New List(Of Transportista)
                olbeCia1 = objLogicaCia.Listar_Transportista(objCia1)
                If olbeCia1.Count = 0 Then Exit Sub
                objCia1 = olbeCia1.Item(0)
                'objCia1 = objLogicaCia.Listar_Transportista(objCia1).Item(0)

                Dim strMsg As String = "Tracto ya asignado a una compañía" & vbCrLf & _
                                        "Tracto: " & objExisteTT.NPLCUN & vbCrLf & _
                                        "Compañía: " & objCia1.TCMTRT & vbCrLf & _
                                        "¿Desea cambiarlo a la compañía " & _RAZONSOCIAL & " ?"
                If MsgBox(strMsg, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    objEntidadTT.FLAG_SKIPCHECKS = 1
                    objEntidadTT.CCMPN = CCMP
                    objEntidadTT = objLogica.Registrar_TransportistaTracto(objEntidadTT)
                    'If objEntidadTT.NRUCTR = "-1" Then
                    '    HelpClass.ErrorMsgBox()
                    '    Exit Sub
                    'End If
                End If

            End If

        End If 'End de Existe la combinacion NRUCTR-NPLCUN
    End Sub

End Class
