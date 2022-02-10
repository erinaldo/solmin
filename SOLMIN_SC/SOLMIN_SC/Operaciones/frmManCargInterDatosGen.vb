Imports SOLMIN_SC.Entidad
Imports System.Text
Imports SOLMIN_SC.Negocio
Imports System.Threading
Public Class frmManCargInterDatosGen

#Region "CheckPoint"
    Private oCheckPoint As New Negocio.clsCheckPoint
    Private _meDialogResult As Boolean = False
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


    Public ReadOnly Property meDialogResult() As Boolean
        Get
            Return _meDialogResult
        End Get
    End Property

    Private oDtCHK_OC_Parcial_Item As New DataTable
    Private oclsCheckPEnvioPreChange As New Ransa.Servicio.EmailCheckPointAduana.clsCheckPEnvioPreChange

    Private _pCCLNT As Decimal = 0
    Private _pNRPEMB As Decimal = 0
    Private _pNORCML As String = ""
    Private _pNRPARC As Decimal = 0
    Private _pNRITOC As Decimal = 0
    Private _pSBITOC As String = ""

    Private QMaxCantidadIngreso As Decimal = 0
    Public Property pCCLNT() As Decimal
        Get
            Return _pCCLNT
        End Get
        Set(ByVal value As Decimal)
            _pCCLNT = value
        End Set
    End Property

    Public Property pNRPEMB() As Decimal
        Get
            Return _pNRPEMB
        End Get
        Set(ByVal value As Decimal)
            _pNRPEMB = value
        End Set
    End Property

    Public Property pNORCML() As String
        Get
            Return _pNORCML
        End Get
        Set(ByVal value As String)
            _pNORCML = value
        End Set
    End Property

    Public Property pNRPARC() As Decimal
        Get
            Return _pNRPARC
        End Get
        Set(ByVal value As Decimal)
            _pNRPARC = value
        End Set
    End Property

    Public Property pNRITOC() As Decimal
        Get
            Return _pNRITOC
        End Get
        Set(ByVal value As Decimal)
            _pNRITOC = value
        End Set
    End Property

    Public Property pSBITOC() As String
        Get
            Return _pSBITOC
        End Get
        Set(ByVal value As String)
            _pSBITOC = value
        End Set
    End Property


    Private oHebra As Thread
#End Region
   
#Region "Datos Generales"

#End Region

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim msgValidar As String = ValidarIngreso()
        Dim ErrorIngreso As Boolean = False
        If (msgValidar.Length <> 0) Then
            MessageBox.Show(msgValidar, "Validar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Try
            Dim obrPreEmbarque As New clsPreEmbarque
            Dim QRLCSC As Decimal = 0
            QRLCSC = Convert.ToDecimal(txtCantidad.Text.Trim)
            obrPreEmbarque.Act_Cantidad_Item_Ajuste(_pCCLNT, _pNRPEMB, _pNORCML, _pNRITOC, _pSBITOC, QRLCSC)
            LlenarDatosItem()
            _meDialogResult = True

            Dim retorno As Int32 = 0
            Dim obePreEmbarque_BE As New bePreEmbarque
            Dim clsPreEmbarque As New clsPreEmbarque
            obePreEmbarque_BE.PNNRPEMB = _pNRPEMB
            If (ctbAgenteDeCarga.NoHayCodigo) Then
                obePreEmbarque_BE.PNCAGNCR = 0
            Else
                obePreEmbarque_BE.PNCAGNCR = ctbAgenteDeCarga.Codigo
            End If
            retorno = clsPreEmbarque.Actualizar_Datos_X_Preembarque(obePreEmbarque_BE)
            Dim EnviarCorreo As Boolean = False
            dvCheckPoint.EndEdit()
            '**************ADICION ENVIO EMAIL X CAMBIO DE CHEKCPOINT********************
            oclsCheckPEnvioPreChange = New Ransa.Servicio.EmailCheckPointAduana.clsCheckPEnvioPreChange
            Dim odaClienteEnvio As New Ransa.Servicio.EmailCheckPointAduana.ClsCheckClienteEnvio
            odaClienteEnvio.Asignar_Lista_Cliente_Envio_Notificacion(dtListaClienteEnvioxModCheckpoint)
            If (odaClienteEnvio.DebeNotificarEnvio_X_Cliente(_pCCLNT)) Then
                'If (oclsCheckPEnvioPreChange.CanEnviarACliente(_pCCLNT)) Then
                oclsCheckPEnvioPreChange.ListarItemsDatosInicialCheckPoint(_pCCMPN, pCDVSN, _pNORCML, _pCCLNT, _pNRPARC)
                EnviarCorreo = True
            End If
            '***********************************************************************
            Dim obeParamCheckPoint As beCheckPoint
            For Each row As DataGridViewRow In dvCheckPoint.Rows
                obeParamCheckPoint = New beCheckPoint
                If row.Cells("DFECEST").Value = vbNullString Then
                    obeParamCheckPoint.PNFESEST = 0
                Else
                    obeParamCheckPoint.PNFESEST = Format(CType(row.Cells("DFECEST").Value, Date), "yyyyMMdd")
                End If
                If row.Cells("DFECREA").Value = vbNullString Then
                    obeParamCheckPoint.PNFRETES = 0
                Else
                    obeParamCheckPoint.PNFRETES = Format(CType(row.Cells("DFECREA").Value, Date), "yyyyMMdd")
                End If
                obeParamCheckPoint.PSTOBS = ("" & row.Cells("TOBS").Value).ToString.Trim
                obeParamCheckPoint.PNNESTDO = row.Cells("NESTDO").Value
                obeParamCheckPoint.PNNRPEMB = _pNRPEMB
                oCheckPoint.Grabar_Checkpoint_X_Preembarque(obeParamCheckPoint)
            Next
            LlenarCheckPointPorItem()
            _meDialogResult = True

            '**************ADICION ENVIO EMAIL X CAMBIO DE CHEKCPOINT********************
            If (EnviarCorreo = True) Then
                ProcesarEnvioEmail_x_Change_CHK()
            End If
            Me.Close()
            '*******************************************************************************
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
            oclsCheckPEnvioPreChange.pCCLNT = _pCCLNT
            oclsCheckPEnvioPreChange.pNORCML = _pNORCML
            oclsCheckPEnvioPreChange.pNRPARC = _pNRPARC
            oclsCheckPEnvioPreChange.pCCMPN = _pCCMPN
            oclsCheckPEnvioPreChange.pCDVSN = _pCDVSN
            Envio = oclsCheckPEnvioPreChange.EnviarEmail_X_Modificacion_CheckPoint()
            oHebra.Abort()
        Catch ex As Exception
        End Try
    End Sub


    Private Function ValidarIngreso() As String
        Dim msgSB As New StringBuilder
        Dim Valor_Cantidad As Decimal = 0
        txtCantidad.Text = txtCantidad.Text.Trim
        If (txtCantidad.Text = "" OrElse txtCantidad.Text = "0" OrElse Decimal.TryParse(txtCantidad.Text, Valor_Cantidad) = False) Then
            msgSB.Append("Debe ingresar valor mayor a 0")
        Else
            If (Valor_Cantidad > QMaxCantidadIngreso) Then
                msgSB.AppendLine()
                msgSB.Append(String.Format("La cantidad Seguimiento no puede ser mayor a {0}", Math.Round(QMaxCantidadIngreso, 0)))
            End If
        End If
        Return msgSB.ToString
    End Function

    Private Sub Event_KeyPress_NumeroWithDecimal(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If HelpUtil.SoloNumerosConDecimal(CType(sender, TextBox), CShort(Asc(e.KeyChar))) = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub CargarAgenteCarga()
        Dim oAgenteCarga As New clsAgenteCarga
        oAgenteCarga.Crea_Lista()
        Dim odtAgenteCarga As New DataTable
        odtAgenteCarga = oAgenteCarga.Lista
        ctbAgenteDeCarga.DataSource = odtAgenteCarga
        ctbAgenteDeCarga.DisplayMember = "TNMAGC"
        ctbAgenteDeCarga.ValueMember = "CAGNCR"
        Me.ctbAgenteDeCarga.DataBind()
    End Sub
     

    Private Sub LlenarDatosItem()
        Dim obrPreEmbarque As New Negocio.clsPreEmbarque
        Dim odtDatoItemPreEmbarque As New DataTable
        odtDatoItemPreEmbarque = obrPreEmbarque.ListarItemsXOrdenCompraParcial_x_Item(ObtenerFiltroPreEmbarqueItem())

        Dim CAGNCR As Decimal = 0
        Dim QRLCSC As Decimal = 0
        Dim QCNTIT As Decimal = 0
        Dim QPEND_PREEMBARQUE As Decimal = 0
        Dim TDITES As String = ""

        If odtDatoItemPreEmbarque.Rows.Count > 0 Then
            TDITES = ("" & odtDatoItemPreEmbarque.Rows(0)("TDITES")).ToString.Trim
            CAGNCR = odtDatoItemPreEmbarque.Rows(0)("CAGNCR")
            QRLCSC = odtDatoItemPreEmbarque.Rows(0)("QRLCSC")
            QCNTIT = odtDatoItemPreEmbarque.Rows(0)("QCNTIT")
            QPEND_PREEMBARQUE = odtDatoItemPreEmbarque.Rows(0)("QPEND_PREEMBARQUE")
            QMaxCantidadIngreso = odtDatoItemPreEmbarque.Rows(0)("QRLCSC") + odtDatoItemPreEmbarque.Rows(0)("QPEND_PREEMBARQUE")
        End If

        txtOrdenCompra.Text = _pNORCML
        txtSubItem.Text = _pSBITOC
        txtItem.Text = _pNRITOC
        txtDescripcion.Text = TDITES
        txtParcial.Text = _pNRPARC
        txtCantidad_Total.Text = QCNTIT
        txtCantidad_Pendiente.Text = QPEND_PREEMBARQUE
        txtCantidad.Text = QRLCSC

        If CAGNCR > 0 Then
            ctbAgenteDeCarga.Codigo = CAGNCR.ToString
        Else
            ctbAgenteDeCarga.Limpiar()
        End If

    End Sub

    Dim dtListaClienteEnvioxModCheckpoint As New DataTable
    Private Sub frmManCargInterDatosGen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CargarAgenteCarga()
            LlenarDatosItem()
            Llenar_CheckPoint_X_Cliente()
            LlenarCheckPointPorItem()
            Dim odaClienteEnvio As New Ransa.Servicio.EmailCheckPointAduana.ClsCheckClienteEnvio
            dtListaClienteEnvioxModCheckpoint = odaClienteEnvio.Listar_FomatosNotificacion_X_Cliente(_pCCMPN, _pCDVSN, odaClienteEnvio.Tipo_Envio_Chk_x_PreEmbarque)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub txtCantidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        Dim Texto As New TextBox
        RemoveHandler CType(sender, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
        Texto = CType(sender, TextBox)
        Texto.Text = Texto.Text.Trim
        Texto.Tag = "10-5"
        AddHandler CType(sender, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
    End Sub

    Public Function SoloNumeros(ByVal Keyascii As Short) As Short

        If InStr("1234567890", Chr(Keyascii)) = 0 Then
            SoloNumeros = 0
        Else
            SoloNumeros = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloNumeros = Keyascii
            Case 13
                SoloNumeros = Keyascii
            Case 32
                SoloNumeros = Keyascii
        End Select
        Return SoloNumeros
    End Function

   
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If (dvCheckPoint.CurrentRow Is Nothing) Then
            Exit Sub
        End If
        Dim oCheckPoint As New clsCheckPoint
        Dim msg As String = ""
        Try
            msg = String.Format("Está seguro de eliminar el CheckPoint:{0}", dvCheckPoint.CurrentRow.Cells("TDESES").Value.ToString.Trim)
            If (MessageBox.Show(msg, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                Dim NESTDO As String = dvCheckPoint.CurrentRow.Cells("NESTDO").Value
                Dim obeParamCheckPoint As beCheckPoint
                obeParamCheckPoint = New beCheckPoint
                obeParamCheckPoint.PNNRPEMB = _pNRPEMB
                obeParamCheckPoint.PNNESTDO = NESTDO
                obeParamCheckPoint.PNFESEST = 0
                obeParamCheckPoint.PNFRETES = 0
                obeParamCheckPoint.PSCEMB = dvCheckPoint.CurrentRow.Cells("CEMB").Value
                oCheckPoint.Grabar_Checkpoint_X_Preembarque(obeParamCheckPoint)
                Llenar_CheckPoint_X_Cliente()
                LlenarCheckPointPorItem()
                _meDialogResult = True
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al eliminar el CheckPoint", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ObtenerFiltroPreEmbarqueItem() As beOrdenPreEmbarcadaFiltro
        Dim obeOrdenPreEmbarcarda As New beOrdenPreEmbarcadaFiltro
        obeOrdenPreEmbarcarda.PNCCLNT = _pCCLNT
        obeOrdenPreEmbarcarda.PSNORCML = _pNORCML
        obeOrdenPreEmbarcarda.PNNRPARC = _pNRPARC
        obeOrdenPreEmbarcarda.PNNRITOC = _pNRITOC
        Return obeOrdenPreEmbarcarda
    End Function

    Private Sub LlenarCheckPointPorItem()
        ActualizarListaCheckPoint_OC_Parcial(ObtenerFiltroPreEmbarqueItem())
        Dim NESTDO As Decimal = 0
        Dim oDtCHK_OC_Parcial_Item As New DataTable
        Dim obrclsPreEmbarque As New Negocio.clsPreEmbarque
        Dim dr() As DataRow
        oDtCHK_OC_Parcial_Item = obrclsPreEmbarque.Lista_Checkpoint_OC_Parcial_Item(ObtenerFiltroPreEmbarqueItem())
        For Each Item As DataGridViewRow In dvCheckPoint.Rows
            NESTDO = Item.Cells("NESTDO").Value
            dr = oDtCHK_OC_Parcial_Item.Select("NESTDO=" & NESTDO & " AND NRPEMB=" & _pNRPEMB)
            If (dr.Length <> 0) Then
                Item.Cells("NRPEMB").Value = _pNRPEMB
                Item.Cells("DFECEST").Value = dr(0)("DFECEST").ToString.Trim
                Item.Cells("DFECREA").Value = dr(0)("DFECREA").ToString.Trim
                Item.Cells("TOBS").Value = dr(0)("TOBS").ToString.Trim
            End If
        Next
    End Sub
    Private Sub Llenar_CheckPoint_X_Cliente()
        dvCheckPoint.Rows.Clear()
        Dim FILA As Int32 = 0
        Dim oDtCHKxCliente As New DataTable
        Dim oDrVw As DataGridViewRow
        Dim intCont As Integer = 0
        oDtCHKxCliente = oCheckPoint.Lista_CheckPoint_X_Cliente(_pCCLNT, _pCCMPN, _pCDVSN, "P", "A")
        For Each dr As DataRow In oDtCHKxCliente.Rows
            oDrVw = New DataGridViewRow
            oDrVw.CreateCells(Me.dvCheckPoint)
            dvCheckPoint.Rows.Add(oDrVw)
            FILA = dvCheckPoint.Rows.Count - 1
            dvCheckPoint.Rows(FILA).Cells("NESTDO").Value = dr("NESTDO")
            dvCheckPoint.Rows(FILA).Cells("CEMB").Value = dr("CEMB").ToString.Trim
            dvCheckPoint.Rows(FILA).Cells("NOMCEMB").Value = dr("NOMVAR").ToString.Trim
            dvCheckPoint.Rows(FILA).Cells("TDESES").Value = dr("TCOLUM").ToString.Trim
        Next
    End Sub
    Private Sub ActualizarListaCheckPoint_OC_Parcial(ByVal obeOrdenPreEmbFiltro As beOrdenPreEmbarcadaFiltro)
        Dim obrclsPreEmbarque As New Negocio.clsPreEmbarque
        oDtCHK_OC_Parcial_Item = obrclsPreEmbarque.Lista_Checkpoint_OC_Parcial_Item(obeOrdenPreEmbFiltro)
    End Sub
    Private Sub dvCheckPoint_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dvCheckPoint.CellContentDoubleClick
        Try
            Dim columna As String = dvCheckPoint.Columns(e.ColumnIndex).Name
            If (dvCheckPoint.CurrentRow IsNot Nothing) Then
                If (columna = "CHKLOG") Then
                    Dim ofrmCheckPointLog As New frmCheckPointLog
                    ofrmCheckPointLog.pTipoLog = frmCheckPointLog.TipoLog.PreEmbarque
                    ofrmCheckPointLog.pCCLNT = _pCCLNT
                    ofrmCheckPointLog.pNRPEMB = _pNRPEMB
                    ofrmCheckPointLog.pNESTDO = dvCheckPoint.CurrentRow.Cells("NESTDO").Value
                    ofrmCheckPointLog.pCHK = dvCheckPoint.CurrentRow.Cells("TDESES").Value
                    ofrmCheckPointLog.ShowDialog()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dvCheckPoint_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dvCheckPoint.MouseDown
        Try
            If e.Button = Windows.Forms.MouseButtons.Right Then
                Me.cmsEliminar.Items(0).Visible = False
                If (dvCheckPoint.Rows.Count <= 0) Then Exit Sub
                Dim ColName As String = dvCheckPoint.Columns(Me.dvCheckPoint.CurrentCell.ColumnIndex).Name
                If ColName = "DFECEST" Or ColName = "DFECREA" Then
                    Me.cmsEliminar.Items(0).Visible = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    
    Private Sub cimBorrarFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cimBorrarFecha.Click
        Try
            Me.dvCheckPoint.CurrentCell.Value = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
