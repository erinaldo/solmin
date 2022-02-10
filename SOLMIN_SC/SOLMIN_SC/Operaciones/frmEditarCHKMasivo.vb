Imports SOLMIN_SC.Negocio
Imports SOLMIN_SC.Entidad
Imports System.Threading
Public Class frmEditarCHKMasivo
    Private oclsCheckPEnvioPreChange As New Ransa.Servicio.EmailCheckPointAduana.clsCheckPEnvioPreChange
    Private _pCCLNT As Decimal = 0
    Private oHebra As Thread
    Public Property pCCLNT() As Decimal
        Get
            Return _pCCLNT
        End Get
        Set(ByVal value As Decimal)
            _pCCLNT = value
        End Set
    End Property
    Private _pNORCML As String = ""
    Public Property pNORCML() As String
        Get
            Return _pNORCML
        End Get
        Set(ByVal value As String)
            _pNORCML = value
        End Set
    End Property
    Private _pNRPARC As Decimal = 0
    Public Property pNRPARC() As Decimal
        Get
            Return _pNRPARC
        End Get
        Set(ByVal value As Decimal)
            _pNRPARC = value
        End Set
    End Property

    Private _pCCMPN As String = ""
    Private _pCDVSN As String = ""

    Public Property pCCMPN() As String
        Get
            Return _pCCMPN
        End Get
        Set(ByVal value As String)
            _pCCMPN = value
        End Set
    End Property

    Public Property pCDVSN() As String
        Get
            Return _pCDVSN
        End Get
        Set(ByVal value As String)
            _pCDVSN = value
        End Set
    End Property


    Private _pDtItemOCParcial As New DataTable
    Public Property pDtItemOCParcial() As DataTable
        Get
            Return _pDtItemOCParcial
        End Get
        Set(ByVal value As DataTable)
            _pDtItemOCParcial = value
        End Set
    End Property


    Private _meDialogResult As Boolean = False
    Public ReadOnly Property meDialogResult() As Boolean
        Get
            Return _meDialogResult
        End Get
    End Property

    Private dtListaClienteEnvioxModCheckpoint As New DataTable
    Private oDtCHK_OC_Parcial As New DataTable
    Private obeOrdenPreEmbarcadaFiltro As New beOrdenPreEmbarcadaFiltro
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim oPreEmbarque As New Negocio.clsPreEmbarque
        Dim oCheckPoint As New Negocio.clsCheckPoint
        Dim MESTDO As Double = 0
        Dim NRPEMB As Double = 0
        Dim DFECEST As Decimal = 0
        Dim DFECREA As Decimal = 0
        Dim PSTOBS As String = ""
        Dim NESTDO As Decimal = 0
        Dim EnviarCorreo As Boolean = False
        Try
            If dtpFechaEstimada.Checked Then
                DFECEST = Format(dtpFechaEstimada.Value, "yyyyMMdd")
            Else
                DFECEST = 0
            End If
            If dtpFechaReal.Checked Then
                DFECREA = Format(dtpFechaReal.Value, "yyyyMMdd")
            Else
                DFECREA = 0
            End If
            PSTOBS = txtObs.Text.Trim
            NESTDO = cmbCheckpoint.SelectedValue


            '**************ADICION ENVIO EMAIL X CAMBIO DE CHEKCPOINT********************
            If ((NESTDO = 107 OrElse NESTDO = 108) AndAlso dtpFechaEstimada.Checked) Then ' SI ES QUE ES UNA MODIFICACION A FECHA DE EMBARQUE O FECHA LLEGADA
                oclsCheckPEnvioPreChange = New Ransa.Servicio.EmailCheckPointAduana.clsCheckPEnvioPreChange

                Dim odaClienteEnvio As New Ransa.Servicio.EmailCheckPointAduana.ClsCheckClienteEnvio
                odaClienteEnvio.Asignar_Lista_Cliente_Envio_Notificacion(dtListaClienteEnvioxModCheckpoint)
                If (odaClienteEnvio.DebeNotificarEnvio_X_Cliente(Me.pCCLNT)) Then
                    'If (oclsCheckPEnvioPreChange.CanEnviarACliente(Me.pCCLNT)) Then
                    oclsCheckPEnvioPreChange.ListarItemsDatosInicialCheckPoint(_pCCMPN, _pCDVSN, Me.pNORCML, Me.pCCLNT, Me.pNRPARC)
                    EnviarCorreo = True
                End If
            End If
            '***********************************************************************

            'If DFECEST <> 0 OrElse DFECREA <> 0 Then

            Dim obeParamCheckPoint As beCheckPoint
            For Each row As DataRow In _pDtItemOCParcial.Rows
                obeParamCheckPoint = New beCheckPoint
                obeParamCheckPoint.PNNRPEMB = row("NRPEMB")
                obeParamCheckPoint.PNNESTDO = NESTDO
                obeParamCheckPoint.PNFESEST = DFECEST
                obeParamCheckPoint.PNFRETES = DFECREA
                obeParamCheckPoint.PSTOBS = PSTOBS
                obeParamCheckPoint.PSCEMB = "P"
                oCheckPoint.Grabar_Checkpoint_X_Preembarque(obeParamCheckPoint)
            Next
            _meDialogResult = True
            ActualizarListaCheckPoint_OC_Parcial()
            cmbCheckpoint_SelectionChangeCommitted(cmbCheckpoint, Nothing)

            '**************ADICION ENVIO EMAIL X CAMBIO DE CHEKCPOINT********************
            If (EnviarCorreo = True) Then
                oHebra = New Thread(AddressOf ProcesarEnvioEmail_x_Change_CHK)
                oHebra.Start()
            End If
            '*******************************************************************************
            MessageBox.Show("Se actualizaron las fechas con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Else
            'MessageBox.Show("Seleccione e ingrese por lo menos una de las Fechas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

 
    Private Sub ProcesarEnvioEmail_x_Change_CHK()
        Try
            Control.CheckForIllegalCrossThreadCalls = False
            Dim FECHA_FIN As Decimal = 0
            Dim Envio As Int32 = 0
            oclsCheckPEnvioPreChange.MailAccount = HelpUtil.getSetting("email_account")
            oclsCheckPEnvioPreChange.Mailpassword = HelpUtil.getSetting("email_password")

            oclsCheckPEnvioPreChange.MailAccount_Gmail = HelpUtil.getSetting("email_account_gmail")
            oclsCheckPEnvioPreChange.MailPassword_Gmail = HelpUtil.getSetting("email_password_gmail")
            oclsCheckPEnvioPreChange.Mailto_Error = HelpUtil.getSetting("emailto_error")


            oclsCheckPEnvioPreChange.pCULUSA = HelpUtil.UserName
            oclsCheckPEnvioPreChange.pCCLNT = Me.pCCLNT
            oclsCheckPEnvioPreChange.pNORCML = Me.pNORCML
            oclsCheckPEnvioPreChange.pNRPARC = Me.pNRPARC
            oclsCheckPEnvioPreChange.pCCMPN = _pCCMPN
            oclsCheckPEnvioPreChange.pCDVSN = _pCDVSN
            Envio = oclsCheckPEnvioPreChange.EnviarEmail_X_Modificacion_CheckPoint()
            oHebra.Abort()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Llenar_CheckPoint_X_Cliente()
        Dim oCheckPoint As New Negocio.clsCheckPoint
        Dim oDtCheckPointCliente As New DataTable
        oDtCheckPointCliente = oCheckPoint.Lista_CheckPoint_X_Cliente(_pCCLNT, _pCCMPN, _pCDVSN, "P", "A")
        If oDtCheckPointCliente.Rows.Count > 0 Then
            Dim view As DataView = New DataView(oDtCheckPointCliente)
            Dim distinctValues As DataTable = view.ToTable(True, "CEMB", "NOMVAR")

            cmbTipo.DataSource = distinctValues
            cmbTipo.ValueMember = "CEMB"
            cmbTipo.DisplayMember = "NOMVAR"

            cmbTipo.SelectedValue = "P"
            If (cmbTipo.SelectedValue = "P") Then
                cmbTipo.Enabled = False
            End If
            cmbCheckpoint.DataSource = oDtCheckPointCliente
            cmbCheckpoint.ValueMember = "NESTDO"
            cmbCheckpoint.DisplayMember = "TCOLUM"
        End If

    End Sub


    Private Sub frmEditarCHKMasivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        kgvItemOC.AutoGenerateColumns = False
        txtOrdenCompra.Text = _pNORCML
        txtParcial.Text = _pNRPARC
        obeOrdenPreEmbarcadaFiltro.PNCCLNT = _pCCLNT
        obeOrdenPreEmbarcadaFiltro.PSNORCML = _pNORCML
        obeOrdenPreEmbarcadaFiltro.PNNRPARC = _pNRPARC
        obeOrdenPreEmbarcadaFiltro.PSCCMPN = _pCCMPN
        obeOrdenPreEmbarcadaFiltro.PSCDVSN = _pCDVSN
        Try
            Llenar_CheckPoint_X_Cliente()
            ActualizarListaCheckPoint_OC_Parcial()
            kgvItemOC.DataSource = _pDtItemOCParcial
            cmbCheckpoint_SelectionChangeCommitted(cmbCheckpoint, Nothing)

            Dim odaClienteEnvio As New Ransa.Servicio.EmailCheckPointAduana.ClsCheckClienteEnvio
            dtListaClienteEnvioxModCheckpoint = odaClienteEnvio.Listar_FomatosNotificacion_X_Cliente(_pCCMPN, _pCDVSN, odaClienteEnvio.Tipo_Envio_Chk_x_PreEmbarque)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub

    Private Sub ActualizarListaCheckPoint_OC_Parcial()
        Dim obrclsPreEmbarque As New Negocio.clsPreEmbarque
        oDtCHK_OC_Parcial = obrclsPreEmbarque.Lista_Checkpoint_OC_Parcial(obeOrdenPreEmbarcadaFiltro)
    End Sub
    Private Sub cmbCheckpoint_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCheckpoint.SelectionChangeCommitted
        lbFechaEstimada.Items.Clear()
        lbFechaReal.Items.Clear()
        dtpFechaEstimada.Checked = False
        dtpFechaReal.Checked = False
        Dim NESTDO As Decimal = cmbCheckpoint.SelectedValue
        Dim oListFechaEstimada As New List(Of String)
        Dim oListFechaReal As New List(Of String)
        Dim FECHAESTIMADA As String = ""
        Dim FECHAREAL As String = ""
        Dim odrFechas() As DataRow
        odrFechas = oDtCHK_OC_Parcial.Select("CCLNT=" & _pCCLNT & " AND NORCML='" & _pNORCML & "' AND NRPARC=" & _pNRPARC & " AND NESTDO=" & NESTDO)
        Dim FECHA As New Date
        For Each dr As DataRow In odrFechas
            FECHAESTIMADA = dr("DFECEST").ToString.Trim
            FECHAREAL = dr("DFECREA").ToString.Trim
            If (Date.TryParse(FECHAESTIMADA, FECHA)) Then
                If (Not oListFechaEstimada.Contains(FECHAESTIMADA)) Then
                    oListFechaEstimada.Add(FECHAESTIMADA)
                End If
            End If
            If (Date.TryParse(FECHAREAL, FECHA)) Then
                If (Not oListFechaReal.Contains(FECHAREAL)) Then
                    oListFechaReal.Add(FECHAREAL)
                End If
            End If
        Next
        lbFechaEstimada.Items.AddRange(oListFechaEstimada.ToArray)
        lbFechaReal.Items.AddRange(oListFechaReal.ToArray)

        If (oListFechaEstimada.Count = 1) Then
            dtpFechaEstimada.Value = oListFechaEstimada(0)
            dtpFechaEstimada.Checked = True

        End If
        If (oListFechaReal.Count = 1) Then
            dtpFechaReal.Value = oListFechaReal(0)
            dtpFechaReal.Checked = True
        End If
    End Sub



    Public Function OBTENER_MESTDO_PREEMBARQUE_X_OC(ByVal odtListaCHK_OC_Parcial As DataTable, ByVal NRPEMB As Double, ByVal NESTDO As Double) As Double
        Dim MESTDO As Decimal = -1
        Dim objListaDr As DataRow()
        objListaDr = odtListaCHK_OC_Parcial.Select("NRPEMB=" & NRPEMB & "AND NESTDO=" & NESTDO)
        If (objListaDr.Length > 0) Then
            MESTDO = objListaDr(0)("MESTDO")
        End If
        Return MESTDO
    End Function

  

End Class
