Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos

Public Class frmConsultaConductor

#Region "Atributo"
  Private _CCMPN As String = ""
  Private _CDVSN As String = ""
  Private _CPLNDV As Double = 0
  Private _NRUCTR As Int64 = 0
  Private _CTRSPT As Int64 = 0
    Private _pRazonSocial As String = ""
    Private _CMEDTR As Int64 = 4


#End Region

#Region "Properties"

    Public Property CMEDTR() As Int64
        Get
            Return _CMEDTR
        End Get
        Set(ByVal value As Int64)
            _CMEDTR = value
        End Set
    End Property

    Public WriteOnly Property CCMPN() As String
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property

  Public WriteOnly Property pRazonSocial() As String
    Set(ByVal value As String)
      _pRazonSocial = value
    End Set
  End Property

  Public WriteOnly Property NRUCTR() As Int64
    Set(ByVal value As Int64)
      _NRUCTR = value
    End Set
  End Property

  Public WriteOnly Property CTRSPT() As Int64
    Set(ByVal value As Int64)
      _CTRSPT = value
    End Set
  End Property

  Public ReadOnly Property CBRCNT() As String
    Get
      Return Me.cmbConductor.pBrevete
    End Get
  End Property

  Public WriteOnly Property CDVSN() As String
    Set(ByVal value As String)
      _CDVSN = value
    End Set
  End Property

  Public WriteOnly Property CPLNDV() As Double
    Set(ByVal value As Double)
      _CPLNDV = value
    End Set
  End Property

#End Region

#Region "Eventos"
  Private Sub frmConsultaConductor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Try
      Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue
      Dim obeConductor As New Ransa.TypeDef.Transportista.TD_ConductorPK
      obeConductor.pCCMPN_Compania = _CCMPN
      obeConductor.pNRUCTR_RucTransportista = _NRUCTR
      Me.cmbConductor.pCargar(obeConductor)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
  End Sub

  Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If CMEDTR = 4 AndAlso Me.cmbConductor.pBrevete = "" Then Exit Sub
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

    Private Sub btnNuevoContudtor1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNuevoContudtor1.Click
        Try
            Dim ofrmNuevoConductor As New frmNuevoConductor
            Dim obrConductor As New Chofer_BLL
            With ofrmNuevoConductor
                .CCMPN = _CCMPN
                .chkTercero.Visible = False
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Registrar_ConductorTransportista(.CBRCNT)
                    .objEntidad.CTRSPT = Me._CTRSPT
                    obrConductor.Registrar_Chofer_Antiguo(.objEntidad)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

  Private Sub Registrar_ConductorTransportista(ByVal strConductor As String)
    Dim objEntidadTC As New TransportistaConductor
    Dim objLogica As New TransportistaConductor_BLL
    objEntidadTC.NRUCTR = Me._NRUCTR
    objEntidadTC.CBRCNT = strConductor
    objEntidadTC.FECINI = HelpClass.TodayNumeric
    objEntidadTC.FECFIN = HelpClass.TodayNumeric
    objEntidadTC.TOBS = ""
    objEntidadTC.CUSCRT = MainModule.USUARIO
    objEntidadTC.FCHCRT = HelpClass.TodayNumeric
    objEntidadTC.HRACRT = HelpClass.NowNumeric
        objEntidadTC.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidadTC.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
    objEntidadTC.POS_RUC_ANTERIOR = ""
    objEntidadTC.FLAG_SKIPCHECKS = 0
    objEntidadTC.SESTCH = ""
    objEntidadTC.CCMPN = _CCMPN
    objEntidadTC.CDVSN = _CDVSN
    objEntidadTC.CPLNDV = _CPLNDV

    Dim objExisteTC As New TransportistaConductor
    objExisteTC = objEntidadTC
    objExisteTC = objLogica.Registrar_TransportistaConductor(objExisteTC)

        'If objExisteTC.NRUCTR = "-1" Then 'ocurrio un error
        '  HelpClass.ErrorMsgBox()
        '  Exit Sub
        'ElseIf objExisteTC.POS_RUC_ANTERIOR = "" Then 'no existe
        '  objEntidadTC.FLAG_SKIPCHECKS = 1
        '  objEntidadTC = objLogica.Registrar_TransportistaConductor(objEntidadTC)
        '  If objEntidadTC.NRUCTR = "-1" Then
        '    HelpClass.ErrorMsgBox()
        '    Exit Sub
        '    'Else
        '    'Listar_ResumenConductores()
        '  End If

        'ElseIf objEntidadTC.POS_RUC_ANTERIOR <> "" Then ' existe la combinacion NRUCTR-NPLCAC
        '  Dim objLogicaCia As New Transportista_BLL

        '  'valida q no se asigne a la misma cia q ya lo tiene
        '  If objExisteTC.POS_RUC_ANTERIOR = objEntidadTC.NRUCTR Then
        '    'se pretendio asignar a una cia q ya lo tuvo o tiene asignado
        '    If objExisteTC.SESTCH = "*" Then
        '      objEntidadTC.FLAG_SKIPCHECKS = 1
        '      objEntidadTC = objLogica.Registrar_TransportistaConductor(objEntidadTC)
        '      If objEntidadTC.NRUCTR = "-1" Then
        '        HelpClass.ErrorMsgBox()
        '        Exit Sub
        '        'Else
        '        'Listar_ResumenConductores()
        '      End If
        '    Else
        '      HelpClass.MsgBox("Conductor ya asignado.", MessageBoxIcon.Error)
        '      Exit Sub
        '    End If
        '  Else ' cambio de otra compañia
        '    Dim objCia1 As New Transportista
        '    objCia1.NRUCTR = objExisteTC.POS_RUC_ANTERIOR
        '    objCia1.CCMPN = _CCMPN
        '    objCia1.CDVSN = _CDVSN
        '    objCia1.CPLNDV = _CPLNDV

        '            Dim olbeCia1 As New List(Of Transportista)
        '            olbeCia1 = objLogicaCia.Listar_Transportista(objCia1)
        '            If olbeCia1.Count = 0 Then Exit Sub
        '            objCia1 = olbeCia1.Item(0)
        '            'objCia1 = objLogicaCia.Listar_Transportista(objCia1).Item(0)

        '    Dim strMsg As String = "Conductor ya asignado a una compañía" & vbCrLf & _
        '                            "Conductor: " & objExisteTC.CBRCNT & vbCrLf & _
        '                            "Compañía: " & objCia1.TCMTRT & vbCrLf & _
        '                            "¿Desea cambiarlo a la compañía " & Me._pRazonSocial & " ?"

        '    If MsgBox(strMsg, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
        '      objEntidadTC.FLAG_SKIPCHECKS = 1
        '      objEntidadTC = objLogica.Registrar_TransportistaConductor(objEntidadTC)
        '      If objEntidadTC.NRUCTR = "-1" Then
        '        HelpClass.ErrorMsgBox()
        '        Exit Sub
        '      End If
        '    End If

        '  End If
        'End If

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
                objCia1.CCMPN = _CCMPN
                objCia1.CDVSN = _CDVSN
                objCia1.CPLNDV = _CPLNDV

                Dim olbeCia1 As New List(Of Transportista)
                olbeCia1 = objLogicaCia.Listar_Transportista(objCia1)
                If olbeCia1.Count = 0 Then Exit Sub
                objCia1 = olbeCia1.Item(0)
                'objCia1 = objLogicaCia.Listar_Transportista(objCia1).Item(0)

                Dim strMsg As String = "Conductor ya asignado a una compañía" & vbCrLf & _
                                        "Conductor: " & objExisteTC.CBRCNT & vbCrLf & _
                                        "Compañía: " & objCia1.TCMTRT & vbCrLf & _
                                        "¿Desea cambiarlo a la compañía " & Me._pRazonSocial & " ?"

                If MsgBox(strMsg, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    objEntidadTC.FLAG_SKIPCHECKS = 1
                    objEntidadTC = objLogica.Registrar_TransportistaConductor(objEntidadTC)
                    'If objEntidadTC.NRUCTR = "-1" Then
                    '    HelpClass.ErrorMsgBox()
                    '    Exit Sub
                    'End If
                End If

            End If
        End If

  End Sub

#End Region

  
End Class
