Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class frmListaPreFacturaPl
#Region "Atributos"
    Public CCLNT As Integer = 0
    Public NPRLQD As Int64 = 0
    Public CCMPN As String = ""
    Public CDVSN As String = ""
    'Public CPLNDV As Integer = 0
    'Public CCMPN_1 As String = ""
    'Public CDVSN_1 As String = ""
    'Public CPLNDV_1 As String = ""
    Public ListFactura_Transporte As New List(Of beFactura_Transporte)
    Public pNROVLR As Decimal = 0
    Public pTipoOP As String = ""
    'Public Property CCLNT() As Integer
    '    Get
    '        Return _CCLNT
    '    End Get
    '    Set(ByVal value As Integer)
    '        _CCLNT = value
    '    End Set
    'End Property

    'Public Property NPRLQD() As Int64
    '    Get
    '        Return _NPRLQD
    '    End Get
    '    Set(ByVal value As Int64)
    '        _NPRLQD = value
    '    End Set
    'End Property

    'Public Property CCMPN() As String
    '    Get
    '        Return _CCMPN
    '    End Get
    '    Set(ByVal value As String)
    '        _CCMPN = value
    '    End Set
    'End Property

    'Public Property CDVSN() As String
    '    Get
    '        Return _CDVSN
    '    End Get
    '    Set(ByVal value As String)
    '        _CDVSN = value
    '    End Set
    'End Property

    'Public Property CPLNDV() As Integer
    '    Get
    '        Return _CPLNDV
    '    End Get
    '    Set(ByVal value As Integer)
    '        _CPLNDV = value
    '    End Set
    'End Property

    'Public Property CCMPN_1() As String
    '    Get
    '        Return _CCMPN_1
    '    End Get
    '    Set(ByVal value As String)
    '        _CCMPN_1 = value
    '    End Set
    'End Property

    'Public Property CDVSN_1() As String
    '    Get
    '        Return _CDVSN_1
    '    End Get
    '    Set(ByVal value As String)
    '        _CDVSN_1 = value
    '    End Set
    'End Property

    'Public Property CPLNDV_1() As String
    '    Get
    '        Return _CPLNDV_1
    '    End Get
    '    Set(ByVal value As String)
    '        _CPLNDV_1 = value
    '    End Set
    'End Property

    'Public Property ListFactura_Transporte() As List(Of beFactura_Transporte)
    '    Get
    '        Return _ListFactura_Transporte
    '    End Get
    '    Set(ByVal value As List(Of beFactura_Transporte))
    '        _ListFactura_Transporte = value
    '    End Set
    'End Property

#End Region
    Private Sub btnSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub Listar_PreFacturacion()
        Me.dgwPreFacturacion.DataSource = Me.ListFactura_Transporte 'dt
        HeaderDatos.ValuesPrimary.Heading = ""
    End Sub

    Private Sub Alinear_Columnas_Grilla()
        Me.dgwPreFacturacion.AutoGenerateColumns = False
        For lint_Contador As Integer = 0 To Me.dgwPreFacturacion.ColumnCount - 1
            Me.dgwPreFacturacion.Columns(lint_Contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub

    Function Lista_NSECFC() As String
        Dim strCadDocumentos As String = ""

        For Each row As DataGridViewRow In dgwPreFacturacion.Rows
            strCadDocumentos += row.Cells("NSECFC").Value.ToString & ","
        Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos
    End Function

    Private Sub btnPreLiquidacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreLiquidacion.Click

        Try
            If cblTipoDoc.SelectedValue <> "" Then
                If txtDocCliente.Text.Trim = "" Then
                    MessageBox.Show("Ingrese documento cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End If

            Dim objListFactura_Transporte As New List(Of beFactura_Transporte)
            Dim objEntidad As beFactura_Transporte
            'Dim ACCION As String = ""
            'Dim NDCPRF As String = ""
            Dim msg As String = ""
            'Dim ListaConsis As String = ""
            'Dim NPRLQD As Decimal = 0

            Dim objParametro As New Hashtable
            Dim obj_Logica As New clsPreLiquidacionBL

            objEntidad = New beFactura_Transporte
            objEntidad.CCMPN = CCMPN
            objEntidad.CDVSN = CDVSN
            'objEntidad.CPLNCL = CPLNDV
            objEntidad.CCLNT = CCLNT
            objEntidad.CULUSA = ConfigurationWizard.UserName
            objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            'ListaConsis = Lista_NDCPRF()
            'ACCION = ""
            'If pTipoOP = "T" Then
            '    objEntidad.LISTA_A_PL = Lista_NDCPRF()
            'End If
            'If pTipoOP = "A" Then
            '    objEntidad.LISTA_A_PL = Lista_Consistencia()
            'End If

            objEntidad.LISTA_A_PL = ObtenerListado()

            objEntidad.NROVLR = pNROVLR
            objEntidad.TPDCPE = cblTipoDoc.SelectedValue.ToString.Trim
            If cblTipoDoc.SelectedValue <> "" Then
                objEntidad.DCCLNT = txtDocCliente.Text.Trim
                objEntidad.SBCLNT = txtSubDocCliente.Text.Trim
            End If
            If pTipoOP = "T" Then
                msg = obj_Logica.Registrar_PL_Transporte_X_Valorizacion(objEntidad, NPRLQD)
            End If
            If pTipoOP = "A" Then
                msg = obj_Logica.Registrar_PL_Admin_X_Valorizacion(objEntidad, NPRLQD)
            End If


            If msg.Length = 0 Then
                HelpClass.MsgBox("Se realizó la Pre - Liquidación Satisfactoriamente N° " & NPRLQD)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                HelpClass.MsgBox("No culminó la Pre - Liquidación" & Chr(13) & msg, MessageBoxIcon.Warning)
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub



     


    Function ObtenerListado() As String
        Dim strCadDocumentos As String = ""

        If pTipoOP = "T" Then
            For Each row As DataGridViewRow In dgwPreFacturacion.Rows
                strCadDocumentos += row.Cells("NDCPRF").Value.ToString & ","
            Next
        End If
        If pTipoOP = "A" Then
            For Each row As DataGridViewRow In dgwPreFacturacion.Rows
                strCadDocumentos += row.Cells("NSECFC").Value.ToString & ","
            Next
        End If
     
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos
    End Function
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
    Private Sub cblTipoDoc_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cblTipoDoc.SelectionChangeCommitted
        Try
            txtDocCliente.Enabled = (cblTipoDoc.SelectedValue <> "")
            txtSubDocCliente.Enabled = (cblTipoDoc.SelectedValue <> "")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmListaPreFacturaPl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim OTipoDatoGeneral_BLL As New clsAyudaGeneral
            Dim obeTipoDatoGeneral As New beAyudaGeneral
            Dim oListTipoDatoGeneral As New List(Of beAyudaGeneral)
            oListTipoDatoGeneral = OTipoDatoGeneral_BLL.ListaTablaAyudaGeneral("TPDCLT", "")  'OTipoDatoGeneral_BLL.Lista_Tipo_Dato_General(_CCMPN_1, "TPDCLT")
            obeTipoDatoGeneral.PSCODIGO = ""
            obeTipoDatoGeneral.PSDESCRIPCION = "::Seleccione::"
            'obeTipoDatoGeneral.CODIGO_TIPO = ""
            'obeTipoDatoGeneral.DESC_TIPO = "::Seleccione::"
            oListTipoDatoGeneral.Insert(0, obeTipoDatoGeneral)
            cblTipoDoc.DataSource = oListTipoDatoGeneral
            cblTipoDoc.ValueMember = "PSCODIGO"
            cblTipoDoc.DisplayMember = "PSDESCRIPCION"
            cblTipoDoc.SelectedValue = ""
            cblTipoDoc_SelectionChangeCommitted(cblTipoDoc, Nothing)
            Me.Alinear_Columnas_Grilla()
            Me.Listar_PreFacturacion()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class