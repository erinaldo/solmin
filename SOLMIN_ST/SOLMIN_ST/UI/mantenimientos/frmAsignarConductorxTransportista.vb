Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports System.Data
Imports System.Collections.Generic

Public Class frmAsignarConductorxTransportista
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

    Private Sub frmAsignarConductorxTransportista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'cargarComboConductores()
        Try
            Dim obeConductor As New Ransa.TypeDef.Transportista.TD_ConductorPK
            obeConductor.pCCMPN_Compania = CCMPN
            Me.cmbConductor.pCargar(obeConductor)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            If cmbConductor.pBrevete <> "" Then
                Registrar_ConductorTransportista()
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub Registrar_ConductorTransportista()
        Dim objEntidadTC As New TransportistaConductor
        Dim objLogica As New TransportistaConductor_BLL
        objEntidadTC.NRUCTR = _RUC
        objEntidadTC.CBRCNT = cmbConductor.pBrevete
        objEntidadTC.FECINI = HelpClass.TodayNumeric
        objEntidadTC.FECFIN = HelpClass.TodayNumeric
        objEntidadTC.TOBS = txtObsConductorTransportista.Text
        objEntidadTC.CUSCRT = MainModule.USUARIO
        objEntidadTC.FCHCRT = HelpClass.TodayNumeric
        objEntidadTC.HRACRT = HelpClass.NowNumeric
        objEntidadTC.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidadTC.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidadTC.POS_RUC_ANTERIOR = ""
        objEntidadTC.FLAG_SKIPCHECKS = 0
        objEntidadTC.SESTCH = ""

        Dim objExisteTC As New TransportistaConductor
        objExisteTC = objEntidadTC
        objExisteTC = objLogica.Registrar_TransportistaConductor(objExisteTC)

        'If objExisteTC.NRUCTR = "-1" Then 'ocurrio un error
        '    HelpClass.ErrorMsgBox()
        '    Exit Sub
        'ElseIf objExisteTC.POS_RUC_ANTERIOR = "" Then 'no existe
        '    objEntidadTC.FLAG_SKIPCHECKS = 1
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
        '            objEntidadTC = objLogica.Registrar_TransportistaConductor(objEntidadTC)
        '            If objEntidadTC.NRUCTR = "-1" Then
        '                HelpClass.ErrorMsgBox()
        '                Exit Sub
        '                'Else
        '                'Listar_ResumenConductores()
        '            End If
        '        Else
        '            HelpClass.MsgBox("Conductor ya asignado.", MessageBoxIcon.Error)
        '            Exit Sub
        '        End If
        '    Else ' cambio de otra compañia
        '        Dim objCia1 As New Transportista
        '        objCia1.NRUCTR = objExisteTC.POS_RUC_ANTERIOR

        '        Dim olbeCia1 As New List(Of Transportista)
        '        olbeCia1 = objLogicaCia.Listar_Transportista(objCia1)
        '        If olbeCia1.Count = 0 Then Exit Sub
        '        objCia1 = olbeCia1.Item(0)
        '        'objCia1 = objLogicaCia.Listar_Transportista(objCia1).Item(0)

        '        Dim strMsg As String = "Conductor ya asignado a una compañía" & vbCrLf & _
        '                                "Conductor: " & objExisteTC.CBRCNT & vbCrLf & _
        '                                "Compañía: " & objCia1.TCMTRT & vbCrLf & _
        '                                "¿Desea cambiarlo a la compañía " & _RAZONSOCIAL & " ?"

        '        If MsgBox(strMsg, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
        '            objEntidadTC.FLAG_SKIPCHECKS = 1
        '            objEntidadTC = objLogica.Registrar_TransportistaConductor(objEntidadTC)
        '            If objEntidadTC.NRUCTR = "-1" Then
        '                HelpClass.ErrorMsgBox()
        '                Exit Sub

        '            End If
        '        End If

        '    End If

        'End If ' ==> IF existe la combinacion NRUCTR-NPLCAC


        'If objExisteTC.NRUCTR = "-1" Then 'ocurrio un error
        '    HelpClass.ErrorMsgBox()
        '    Exit Sub
        'Else
        If objExisteTC.POS_RUC_ANTERIOR = "" Then 'no existe
            objEntidadTC.FLAG_SKIPCHECKS = 1
            objEntidadTC = objLogica.Registrar_TransportistaConductor(objEntidadTC)
            'If objEntidadTC.NRUCTR = "-1" Then
            '    HelpClass.ErrorMsgBox()
            '    Exit Sub
            '    'Else
            '    'Listar_ResumenConductores()
            'End If

        ElseIf objEntidadTC.POS_RUC_ANTERIOR <> "" Then ' existe la combinacion NRUCTR-NPLCAC
            Dim objLogicaCia As New Transportista_BLL

            'valida q no se asigne a la misma cia q ya lo tiene
            If objExisteTC.POS_RUC_ANTERIOR = objEntidadTC.NRUCTR Then
                'se pretendio asignar a una cia q ya lo tuvo o tiene asignado
                If objExisteTC.SESTCH = "*" Then
                    objEntidadTC.FLAG_SKIPCHECKS = 1
                    objEntidadTC = objLogica.Registrar_TransportistaConductor(objEntidadTC)
                    'If objEntidadTC.NRUCTR = "-1" Then
                    '    HelpClass.ErrorMsgBox()
                    '    Exit Sub
                    '    'Else
                    '    'Listar_ResumenConductores()
                    'End If
                Else
                    HelpClass.MsgBox("Conductor ya asignado.", MessageBoxIcon.Error)
                    Exit Sub
                End If
            Else ' cambio de otra compañia
                Dim objCia1 As New Transportista
                objCia1.NRUCTR = objExisteTC.POS_RUC_ANTERIOR

                Dim olbeCia1 As New List(Of Transportista)
                olbeCia1 = objLogicaCia.Listar_Transportista(objCia1)
                If olbeCia1.Count = 0 Then Exit Sub
                objCia1 = olbeCia1.Item(0)
                'objCia1 = objLogicaCia.Listar_Transportista(objCia1).Item(0)

                Dim strMsg As String = "Conductor ya asignado a una compañía" & vbCrLf & _
                                        "Conductor: " & objExisteTC.CBRCNT & vbCrLf & _
                                        "Compañía: " & objCia1.TCMTRT & vbCrLf & _
                                        "¿Desea cambiarlo a la compañía " & _RAZONSOCIAL & " ?"

                If MsgBox(strMsg, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    objEntidadTC.FLAG_SKIPCHECKS = 1
                    objEntidadTC = objLogica.Registrar_TransportistaConductor(objEntidadTC)
                    'If objEntidadTC.NRUCTR = "-1" Then
                    '    HelpClass.ErrorMsgBox()
                    '    Exit Sub
                    'End If
                End If

            End If

        End If ' ==> IF existe la combinacion NRUCTR-NPLCAC

    End Sub

    'Private Sub cargarComboConductores()
    '    Try
    '        Dim obeConductor As New Ransa.TypeDef.Transportista.TD_ConductorPK
    '        obeConductor.pCCMPN_Compania = CCMPN
    '        Me.cmbConductor.pCargar(obeConductor)
    '    Catch ex As Exception
    '    End Try
    'End Sub
End Class
