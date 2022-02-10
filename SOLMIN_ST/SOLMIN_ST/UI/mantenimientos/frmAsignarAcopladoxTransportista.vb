Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports System.Data
Imports System.Collections.Generic

Public Class frmAsignarAcopladoxTransportista
    Private _RUC As String = ""
    Private _RAZONSOCIAL As String = ""
    Private _CCMPN As String = ""
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property
    Private Sub frmAsignarAcopladoxTransportista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'cargarComboAcoplados()
        Try
            Dim objEntidad As New Acoplado
            Dim obj As New Acoplado_BLL
            objEntidad.NPLCAC = ""
            objEntidad.CCMPN = _CCMPN
            cboAcoplados.DataSource = HelpClass.GetDataSetNative(obj.Listar_Acoplado(objEntidad))
            cboAcoplados.ValueField = "TMRCVH"
            cboAcoplados.KeyField = "NPLCAC"
            cboAcoplados.DataBind()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
   
    End Sub

    'Private Sub cargarComboAcoplados()
    '    Try
    '        Dim objEntidad As New Acoplado
    '        Dim obj As New Acoplado_BLL
    '        objEntidad.NPLCAC = ""
    '        objEntidad.CCMPN = _CCMPN

    '        cboAcoplados.DataSource = HelpClass.GetDataSetNative(obj.Listar_Acoplado(objEntidad))
    '        cboAcoplados.ValueField = "TMRCVH"
    '        cboAcoplados.KeyField = "NPLCAC"
    '        cboAcoplados.DataBind()
    '    Catch ex As Exception
    '    End Try
    'End Sub

    Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            If cboAcoplados.Codigo <> "" Then
                Registrar_AcopladoTransportista()
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub Registrar_AcopladoTransportista()

        Dim objEntidadTA As New TransportistaAcoplado
        Dim objLogica As New TransportistaAcoplado_BLL

        objEntidadTA.NRUCTR = _RUC
        objEntidadTA.NPLCAC = cboAcoplados.Codigo
        objEntidadTA.FECINI = HelpClass.TodayNumeric
        objEntidadTA.FECFIN = HelpClass.TodayNumeric
        objEntidadTA.TOBS = txtObsAcopladoTransportista.Text
        objEntidadTA.CUSCRT = MainModule.USUARIO
        objEntidadTA.FCHCRT = HelpClass.TodayNumeric
        objEntidadTA.HRACRT = HelpClass.NowNumeric
        objEntidadTA.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidadTA.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidadTA.POS_RUC_ANTERIOR = ""
        objEntidadTA.FLAG_SKIPCHECKS = 0
        objEntidadTA.SESTAC = ""

        Dim objExisteTA As New TransportistaAcoplado
        objExisteTA = objEntidadTA
        objExisteTA = objLogica.Registrar_TransportistaAcoplado(objExisteTA)

        'If objExisteTA.NRUCTR = "-1" Then 'ocurrio un error
        '    HelpClass.ErrorMsgBox()
        '    Exit Sub
        'ElseIf objExisteTA.POS_RUC_ANTERIOR = "" Then 'no existe
        '    objEntidadTA.FLAG_SKIPCHECKS = 1
        '    objEntidadTA = objLogica.Registrar_TransportistaAcoplado(objEntidadTA)
        '    If objEntidadTA.NRUCTR = "-1" Then
        '        HelpClass.ErrorMsgBox()
        '        Exit Sub

        '    End If

        'ElseIf objEntidadTA.POS_RUC_ANTERIOR <> "" Then ' existe la combinacion NRUCTR-NPLCAC
        '    Dim objLogicaCia As New Transportista_BLL

        '    'valida q no se asigne a la misma cia q ya lo tiene
        '    If objExisteTA.POS_RUC_ANTERIOR = objEntidadTA.NRUCTR Then
        '        'se pretendio asignar a una cia q ya lo tuvo o tiene asignado
        '        If objExisteTA.SESTAC = "*" Then
        '            objEntidadTA.FLAG_SKIPCHECKS = 1
        '            objEntidadTA = objLogica.Registrar_TransportistaAcoplado(objEntidadTA)
        '            If objEntidadTA.NRUCTR = "-1" Then
        '                HelpClass.ErrorMsgBox()
        '                Exit Sub

        '            End If
        '        Else
        '            HelpClass.MsgBox("Acoplado ya asignado.", MessageBoxIcon.Error)
        '            Exit Sub
        '        End If
        '    Else ' cambio de otra compañia
        '        Dim objCia1 As New Transportista
        '        objCia1.NRUCTR = objExisteTA.POS_RUC_ANTERIOR

        '        Dim olbeCia1 As New List(Of Transportista)
        '        olbeCia1 = objLogicaCia.Listar_Transportista(objCia1)
        '        If olbeCia1.Count = 0 Then Exit Sub
        '        'objCia1 = objLogicaCia.Listar_Transportista(objCia1).Item(0)
        '        objCia1 = olbeCia1.Item(0)

        '        Dim strMsg As String = "Acoplado ya asignado a una compañía" & vbCrLf & _
        '                                "Acoplado: " & objExisteTA.NPLCAC & vbCrLf & _
        '                                "Compañía: " & objCia1.TCMTRT & vbCrLf & _
        '                                "¿Desea cambiarlo a la compañía " & _RAZONSOCIAL & " ?"

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
            objEntidadTA = objLogica.Registrar_TransportistaAcoplado(objEntidadTA)
            'If objEntidadTA.NRUCTR = "-1" Then
            '    HelpClass.ErrorMsgBox()
            '    Exit Sub

            'End If

        ElseIf objEntidadTA.POS_RUC_ANTERIOR <> "" Then ' existe la combinacion NRUCTR-NPLCAC
            Dim objLogicaCia As New Transportista_BLL

            'valida q no se asigne a la misma cia q ya lo tiene
            If objExisteTA.POS_RUC_ANTERIOR = objEntidadTA.NRUCTR Then
                'se pretendio asignar a una cia q ya lo tuvo o tiene asignado
                If objExisteTA.SESTAC = "*" Then
                    objEntidadTA.FLAG_SKIPCHECKS = 1
                    objEntidadTA = objLogica.Registrar_TransportistaAcoplado(objEntidadTA)
                    'If objEntidadTA.NRUCTR = "-1" Then
                    '    HelpClass.ErrorMsgBox()
                    '    Exit Sub
                    'End If
                Else
                    HelpClass.MsgBox("Acoplado ya asignado.", MessageBoxIcon.Error)
                    Exit Sub
                End If
            Else ' cambio de otra compañia
                Dim objCia1 As New Transportista
                objCia1.NRUCTR = objExisteTA.POS_RUC_ANTERIOR

                Dim olbeCia1 As New List(Of Transportista)
                olbeCia1 = objLogicaCia.Listar_Transportista(objCia1)
                If olbeCia1.Count = 0 Then Exit Sub
                'objCia1 = objLogicaCia.Listar_Transportista(objCia1).Item(0)
                objCia1 = olbeCia1.Item(0)

                Dim strMsg As String = "Acoplado ya asignado a una compañía" & vbCrLf & _
                                        "Acoplado: " & objExisteTA.NPLCAC & vbCrLf & _
                                        "Compañía: " & objCia1.TCMTRT & vbCrLf & _
                                        "¿Desea cambiarlo a la compañía " & _RAZONSOCIAL & " ?"

                If MsgBox(strMsg, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    objEntidadTA.FLAG_SKIPCHECKS = 1
                    objEntidadTA = objLogica.Registrar_TransportistaAcoplado(objEntidadTA)
                    'If objEntidadTA.NRUCTR = "-1" Then
                    '    HelpClass.ErrorMsgBox()
                    '    Exit Sub
                    'End If
                End If
            End If
        End If

    End Sub



End Class
