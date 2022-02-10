Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports CrystalDecisions.CrystalReports.Engine
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports SOLMIN_ST.NEGOCIO

Public Class frmListaPreFactura

#Region "Atributos"

  Private _CCLNT As Integer = 0
    Private _NPRLQD As Int64 = 0
  Private _CCMPN As String = ""
  Private _CDVSN As String = ""
    Private _CPLNDV As Integer = 0

  Private _CCMPN_1 As String = ""
  Private _CDVSN_1 As String = ""
    Private _CPLNDV_1 As String = ""

    Private _ListFactura_Transporte As List(Of Factura_Transporte)
 

    Public Property CCLNT() As Integer
        Get
            Return _CCLNT
        End Get
        Set(ByVal value As Integer)
            _CCLNT = value
        End Set
    End Property

    Public Property NPRLQD() As Int64
        Get
            Return _NPRLQD
        End Get
        Set(ByVal value As Int64)
            _NPRLQD = value
        End Set
    End Property

    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property

    Public Property CDVSN() As String
        Get
            Return _CDVSN
        End Get
        Set(ByVal value As String)
            _CDVSN = value
        End Set
    End Property

    Public Property CPLNDV() As Integer
        Get
            Return _CPLNDV
        End Get
        Set(ByVal value As Integer)
            _CPLNDV = value
        End Set
    End Property

    Public Property CCMPN_1() As String
        Get
            Return _CCMPN_1
        End Get
        Set(ByVal value As String)
            _CCMPN_1 = value
        End Set
    End Property

    Public Property CDVSN_1() As String
        Get
            Return _CDVSN_1
        End Get
        Set(ByVal value As String)
            _CDVSN_1 = value
        End Set
    End Property

    Public Property CPLNDV_1() As String
        Get
            Return _CPLNDV_1
        End Get
        Set(ByVal value As String)
            _CPLNDV_1 = value
        End Set
    End Property

    Public Property ListFactura_Transporte() As List(Of Factura_Transporte)
        Get
            Return _ListFactura_Transporte
        End Get
        Set(ByVal value As List(Of Factura_Transporte))
            _ListFactura_Transporte = value
        End Set
    End Property

#End Region

#Region "Eventos"

    Private Sub frmPreLiquidacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            dgwPreFacturacion.AutoGenerateColumns = False

            Dim OTipoDatoGeneral_BLL As New TipoDatoGeneral_BLL
            Dim obeTipoDatoGeneral As New TipoDatoGeneral
            Dim oListTipoDatoGeneral As New List(Of TipoDatoGeneral)
            oListTipoDatoGeneral = OTipoDatoGeneral_BLL.Lista_Tipo_Dato_General(_CCMPN_1, "TPDCLT")
            obeTipoDatoGeneral.CODIGO_TIPO = ""
            obeTipoDatoGeneral.DESC_TIPO = "::Seleccione::"
            oListTipoDatoGeneral.Insert(0, obeTipoDatoGeneral)
            cblTipoDoc.DataSource = oListTipoDatoGeneral
            cblTipoDoc.ValueMember = "CODIGO_TIPO"
            cblTipoDoc.DisplayMember = "DESC_TIPO"
            cblTipoDoc.SelectedValue = ""
            cblTipoDoc_SelectionChangeCommitted(cblTipoDoc, Nothing)
            'Me.Alinear_Columnas_Grilla()
            Me.Listar_PreFacturacion()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

#End Region

#Region "Métodos"

    Private Sub Listar_PreFacturacion()
        Me.dgwPreFacturacion.DataSource = Me.ListFactura_Transporte 'dt
        'Dim objParametro As New Hashtable
        'Dim obj_Logica As New PreLiquidacion_BLL
        'objParametro.Add("PNESTADO", 0)
        'objParametro.Add("PSCCMPN", CCMPN)
        'objParametro.Add("PSCDVSN", CDVSN)
        'objParametro.Add("PNCPLNDV", CPLNDV)
        'NPRLQD = obj_Logica.Obtener_Nro_PreLiquidacion(objParametro)
        'HeaderDatos.ValuesPrimary.Heading = "Nro de Pre - Liquidación Refencial es : " + NPRLQD.ToString()
        HeaderDatos.ValuesPrimary.Heading = ""
    End Sub

    'Private Sub Alinear_Columnas_Grilla()
    '    Me.dgwPreFacturacion.AutoGenerateColumns = False
    '    For lint_Contador As Integer = 0 To Me.dgwPreFacturacion.ColumnCount - 1
    '        Me.dgwPreFacturacion.Columns(lint_Contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    '    Next
    'End Sub

    Private Sub btnPreLiquidacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreLiquidacion.Click

        Try
            If cblTipoDoc.SelectedValue <> "" Then
                If txtDocCliente.Text.Trim = "" Then
                    MessageBox.Show("Ingrese documento cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End If

            Dim objListFactura_Transporte As New List(Of Factura_Transporte)
            Dim objEntidad As Factura_Transporte
            Dim ACCION As String = ""
            Dim NDCPRF As String = ""
            Dim msg As String = ""
            'Dim NPRLQD As Decimal = 0

            Dim objParametro As New Hashtable
            Dim obj_Logica As New PreLiquidacion_BLL

            objEntidad = New Factura_Transporte
            objEntidad.CCMPN = CCMPN
            objEntidad.CDVSN = CDVSN
            objEntidad.CPLNCL = CPLNDV
            objEntidad.CULUSA = MainModule.USUARIO
            objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            NDCPRF = Lista_NDCPRF()
            ACCION = ""
            objEntidad.TPDCPE = cblTipoDoc.SelectedValue.ToString.Trim
            If cblTipoDoc.SelectedValue <> "" Then
                objEntidad.DCCLNT = txtDocCliente.Text.Trim
                objEntidad.SBCLNT = txtSubDocCliente.Text.Trim
            End If

            'NPRLQD = 0
            'FDCPRF = Lista_FDCPRF()
            'FDCPRF = ""
            'Dim lintEstadoOperación As Integer = obj_Logica.Registrar_PreLiquidacion(objEntidad, NDCPRF, FDCPRF)
            msg = obj_Logica.Registrar_PreLiquidacion(objEntidad, NDCPRF, NPRLQD, ACCION)

            If msg.Length = 0 Then
                Dim msgPL As String = "Se realizó la Pre - Liquidación Satisfactoriamente N° " & NPRLQD
                If MessageBox.Show(msgPL & Chr(10) & "Desea visualizar reporte PL ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Imprimir_Reporte_Pre_Liquidacion(NPRLQD)
                End If
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                HelpClass.MsgBox("No culminó la Pre - Liquidación" & Chr(13) & msg, MessageBoxIcon.Warning)
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Function Lista_NDCPRF() As String
        Dim strCadDocumentos As String = ""

        For Each row As DataGridViewRow In dgwPreFacturacion.Rows
            strCadDocumentos += row.Cells("NDCPRF").Value.ToString & ","
        Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos
    End Function


    'Function Lista_FDCPRF() As String
    '    Dim strCadDocumentos As String = ""
    '    For Each row As DataGridViewRow In dgwPreFacturacion.Rows
    '        strCadDocumentos += HelpClass.CDate_a_Numero8Digitos(row.Cells("FDCPRF_S").Value).ToString & ","
    '    Next
    '    If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
    '    Return strCadDocumentos
    'End Function



    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Public Sub Imprimir_Reporte_Pre_Liquidacion(ByVal lstr_Cadena As String)
        Dim obj_Logica As New PreLiquidacion_BLL
        Dim objPrintForm As New PrintForm
        Dim objDs As New DataSet
        Dim objetoRep As New rptPreLiquidacion
        Dim ListaParametros As New List(Of String)

        ListaParametros.Add(lstr_Cadena)
        ListaParametros.Add(Me.CCMPN)
        ListaParametros.Add(Me.CDVSN)
        ListaParametros.Add(Me.CPLNDV)

        ListaParametros.Add(HelpClass.TodayNumeric)
        objDs = obj_Logica.Imprimir_Reporte_Pre_Liquidacion(ListaParametros)
        If objDs.Tables.Count = 0 Then Exit Sub
        objDs.Tables(0).TableName = "RZTR06"
        HelpClass.CrystalReportTextObject(objetoRep, "lblUsuario", MainModule.USUARIO)
        HelpClass.CrystalReportTextObject(objetoRep, "lblCompania", CCMPN_1)
        HelpClass.CrystalReportTextObject(objetoRep, "lblDivision", CDVSN_1)
        HelpClass.CrystalReportTextObject(objetoRep, "lblPlanta", CPLNDV_1)
        HelpClass.CrystalReportTextObject(objetoRep, "lblNroPreliquidacion", "N° " & lstr_Cadena.Trim)
        objetoRep.SetDataSource(objDs)
        objPrintForm.ShowForm(objetoRep, Me)

    End Sub

    Private Sub btnConsistencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsistencia.Click
        Try
            Dim lstrCadenaPreFactura As String = ""
            For Each row As DataGridViewRow In dgwPreFacturacion.Rows
                lstrCadenaPreFactura = lstrCadenaPreFactura & "," & Int64.Parse(row.Cells("NDCPRF").Value)
            Next
            lstrCadenaPreFactura = lstrCadenaPreFactura.Trim.Substring(1)
            Dim obj_Logica As New PreLiquidacion_BLL
            Dim objPrintForm As New PrintForm
            Dim objDs As New DataSet
            Dim objetoRep As New rptPreLiquidacion
            Dim ListaParametros As New List(Of String)

            ListaParametros.Add(lstrCadenaPreFactura)
            ListaParametros.Add(Me.CCMPN)
            ListaParametros.Add(Me.CDVSN)
            ListaParametros.Add(Me.CPLNDV)
            ListaParametros.Add(HelpClass.TodayNumeric)
            objDs = obj_Logica.Imprimir_Consistencia_Pre_Liquidacion(ListaParametros)
            If objDs.Tables.Count = 0 Then Exit Sub
            objDs.Tables(0).TableName = "RZTR06"
            HelpClass.CrystalReportTextObject(objetoRep, "lblUsuario", MainModule.USUARIO)
            HelpClass.CrystalReportTextObject(objetoRep, "lblCompania", CCMPN_1)
            HelpClass.CrystalReportTextObject(objetoRep, "lblDivision", CDVSN_1)
            HelpClass.CrystalReportTextObject(objetoRep, "lblPlanta", CPLNDV_1)
            HelpClass.CrystalReportTextObject(objetoRep, "lblNroPreliquidacion", "N° " & Me.NPRLQD.ToString.Trim)
            objetoRep.SetDataSource(objDs)
            objPrintForm.ShowForm(objetoRep, Me)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

#End Region

    Private Sub cblTipoDoc_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cblTipoDoc.SelectionChangeCommitted
        Try
            txtDocCliente.Enabled = (cblTipoDoc.SelectedValue <> "")
            txtSubDocCliente.Enabled = (cblTipoDoc.SelectedValue <> "")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
