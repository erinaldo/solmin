
Imports SOLMIN_CTZ.NEGOCIO.Operaciones
Imports SOLMIN_CTZ.ENTIDADES.Operaciones
Imports CrystalDecisions.CrystalReports.Engine
Imports SOLMIN_CTZ.ENTIDADES.Mantenimientos
Imports SOLMIN_CTZ.NEGOCIO
Imports Db2Manager.RansaData.iSeries.DataObjects

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
            Me.Alinear_Columnas_Grilla()
            Me.Listar_PreFacturacion()
        Catch : End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

#End Region

#Region "Métodos"

    Private Sub Listar_PreFacturacion()
        Me.dgwPreFacturacion.DataSource = Me.ListFactura_Transporte 'dt

        Dim objParametro As New Hashtable
        Dim obj_Logica As New PreLiquidacion_BLL

        objParametro.Add("PNESTADO", 0)
        objParametro.Add("PSCCMPN", CCMPN)
        objParametro.Add("PSCDVSN", CDVSN)
        objParametro.Add("PNCPLNDV", CPLNDV)

        NPRLQD = obj_Logica.Obtener_Nro_PreLiquidacion(objParametro)

        HeaderDatos.ValuesPrimary.Heading = "Nro de Pre - Liquidación Refencial es : " + NPRLQD.ToString()
    End Sub

    Private Sub Alinear_Columnas_Grilla()
        Me.dgwPreFacturacion.AutoGenerateColumns = False
        For lint_Contador As Integer = 0 To Me.dgwPreFacturacion.ColumnCount - 1
            Me.dgwPreFacturacion.Columns(lint_Contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub

    Private Sub btnPreLiquidacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreLiquidacion.Click
        Dim objListFactura_Transporte As New List(Of Factura_Transporte)
        Dim objEntidad As Factura_Transporte

        Dim NDCPRF As String = ""
        Dim FDCPRF As String = ""
        Dim objParametro As New Hashtable
        Dim obj_Logica As New PreLiquidacion_BLL
        'Dim objfrmPreLiquidacion As New frmPreLiquidacion
        'objParametro.Add("PNESTADO", 1)
        'objParametro.Add("PSCCMPN", CCMPN)
        'objParametro.Add("PSCDVSN", CDVSN)
        'objParametro.Add("PNCPLNDV", CPLNDV)

        'NPRLQD = obj_Logica.Obtener_Nro_PreLiquidacion(objParametro)

        'For Each row As DataGridViewRow In dgwPreFacturacion.Rows
        objEntidad = New Factura_Transporte
        'objEntidad.NDCPRF = Int64.Parse(row.Cells("NDCPRF").Value)
        'objEntidad.FDCPRF = HelpClass.CDate_a_Numero8Digitos(row.Cells("FDCPRF_S").Value)
        'objEntidad.NPRLQD = NPRLQD
        objEntidad.CCMPN = CCMPN
        objEntidad.CDVSN = CDVSN
        objEntidad.CPLNCL = CPLNDV
        'objEntidad.FULTAC = HelpClass.TodayNumeric
        'objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.CULUSA = ConfigurationWizard.UserName
        objEntidad.NTRMNL = HelpClass.NombreMaquina
        'objListFactura_Transporte.Add(objEntidad)
        'Next

        NDCPRF = Lista_NDCPRF()
        FDCPRF = Lista_FDCPRF()

        Dim lintEstadoOperación As Integer = obj_Logica.Registrar_PreLiquidacion(objEntidad, NDCPRF, FDCPRF)
        If lintEstadoOperación > 0 Then
            HelpClass.MsgBox("Se realizó la Pre - Liquidación Satisfactoriamente N° " & lintEstadoOperación) 'NPRLQD)

            Imprimir_Reporte_Pre_Liquidacion(lintEstadoOperación) 'NPRLQD)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            HelpClass.MsgBox("Ocurrió un Error, no culminó la Pre - Liquidación", MessageBoxIcon.Error)
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Function Lista_NDCPRF() As String
        Dim strCadDocumentos As String = ""

        For Each row As DataGridViewRow In dgwPreFacturacion.Rows
            strCadDocumentos += row.Cells("NDCPRF").Value.ToString & ","
        Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos
    End Function


    Function Lista_FDCPRF() As String
        Dim strCadDocumentos As String = ""
        For Each row As DataGridViewRow In dgwPreFacturacion.Rows
            strCadDocumentos += HelpClass_ST.CDate_a_Numero8Digitos(row.Cells("FDCPRF_S").Value).ToString & ","
        Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos
    End Function



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
        HelpClass.CrystalReportTextObject(objetoRep, "lblUsuario", ConfigurationWizard.UserName)
        HelpClass.CrystalReportTextObject(objetoRep, "lblCompania", CCMPN_1)
        HelpClass.CrystalReportTextObject(objetoRep, "lblDivision", CDVSN_1)
        HelpClass.CrystalReportTextObject(objetoRep, "lblPlanta", CPLNDV_1)
        HelpClass.CrystalReportTextObject(objetoRep, "lblNroPreliquidacion", "N° " & lstr_Cadena.Trim)
        objetoRep.SetDataSource(objDs)
        objPrintForm.ShowForm(objetoRep, Me)

    End Sub

    Private Sub btnConsistencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsistencia.Click
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
        HelpClass.CrystalReportTextObject(objetoRep, "lblUsuario", ConfigurationWizard.UserName)
        HelpClass.CrystalReportTextObject(objetoRep, "lblCompania", CCMPN_1)
        HelpClass.CrystalReportTextObject(objetoRep, "lblDivision", CDVSN_1)
        HelpClass.CrystalReportTextObject(objetoRep, "lblPlanta", CPLNDV_1)
        HelpClass.CrystalReportTextObject(objetoRep, "lblNroPreliquidacion", "N° " & Me.NPRLQD.ToString.Trim)
        objetoRep.SetDataSource(objDs)
        objPrintForm.ShowForm(objetoRep, Me)
    End Sub

#End Region

End Class

