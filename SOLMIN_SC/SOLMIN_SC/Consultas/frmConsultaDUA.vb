Imports SOLMIN_SC.Negocio
Imports Ransa.Utilitario

Public Class frmConsultaDUA


    Private _DUA As String
    Public Property DUA() As String
        Get
            Return _DUA
        End Get
        Set(ByVal value As String)
            _DUA = value
        End Set
    End Property

    Private dtGeneral As DataTable
    Private dsDetail As DataSet
    Dim NUME_ORDEN As Decimal
    Dim CODI_ADUAN As Decimal
    Dim ANO_PRESE As Decimal
    Dim CODI_REGI As Decimal


    Private Sub Load_Information(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_Data_General()
        Load_Data_Detail()

    End Sub

    Sub Load_Data_General()

        Dim objBLL As New clsConsultaDUA_BLL
        dtGeneral = New DataTable
        dtGeneral = objBLL.Load_Data_General(_DUA)

        If dtGeneral.Rows.Count > 0 Then
            For Each dr As DataRow In dtGeneral.Rows
                ' Datos Generales
                txtNroDUA.Text = dr("DUA")
                txtFechaNumeracion.Text = CDate(dr("FNDCL")).Date
                txtMercaderia.Text = dr("MERCADERIA")
                txtEmpresaTransporte.Text = dr("NOMB_TRANS")
                txtMatriculaTransporte.Text = dr("DMAT")
                txtAlmacen.Text = dr("NOMB_ALMA")
                txtDeposito.Text = dr("NOMB_DEPO")
                txtBultos.Text = dr("TCANT_BULT")
                txtClaseBultos.Text = dr("CLASE_BULT")
                txtKgBrutos.Text = dr("TPESO_BRUT")
                txtKgNeto.Text = dr("TPESO_NETO")
                txtUnidadesFisicas.Text = dr("TQUNIFIS")
                txtUnidadesComerciales.Text = dr("TQUNICOM")
                txtCantidadSerie.Text = dr("CANT_SERIE")
                txtAduana.Text = dr("CODI_ADUAN")
                txtRegimen.Text = dr("CODI_REGI")
                txtNumManifiesto.Text = dr("ANO_PRESE") & "-" & dr("NUME_MANIF")

                ' Tributarios
                txtValorMercaderia.Text = dr("VMER_DOLAR")
                txtGastosFOB.Text = dr("GTOS_DOLAR")
                txtFOB.Text = dr("TFOB_DOLPO")
                txtFLETE.Text = dr("VFLE_DOLAR")
                txtSEGURO.Text = dr("TSEG_DOLAR")
                txtCIF.Text = dr("CIF_DOLAR")
                txtISC.Text = dr("PAG04")
                txtIGV.Text = dr("PAG05")
                txtIPM.Text = dr("PAG06")
                txtANTIDUMPING.Text = dr("PAG07")
                txtInteresCompensatorio.Text = dr("PAG08")
                txtMORA.Text = dr("PAG09")

                ' Aduaneros
                txtADVALOREM.Text = dr("PAG01")
                txtSOBRETASA.Text = dr("PAG02")
                txtDerechoEspecifico.Text = dr("PAG03")

                ' Tasas
                txtTasaDespacho.Text = dr("PAG10")

                ' Datos para consultar detail
                NUME_ORDEN = CDec(dr("NUME_ORDEN"))
                CODI_ADUAN = CDec(dr("CODI_ADUAN"))
                ANO_PRESE = CDec(dr("ANO_PRESE"))
                CODI_REGI = CDec(dr("CODI_REGI"))
                txtOrdenServicio.Text = String.Format("{0}{1}", ANO_PRESE, dr("NUME_ORDEN"))

            Next
        End If
    End Sub

    Sub Load_Data_Detail()

        Dim objBLL As New clsConsultaDUA_BLL
        dsDetail = New DataSet

        dsDetail = objBLL.Load_Data_Detail(CODI_ADUAN, ANO_PRESE, CODI_REGI, NUME_ORDEN)

        ' *********      Cargar Datos de Conocimiento     **********

        ' Datos Generales
        If dsDetail.Tables(0).Rows.Count = 1 Then
            For Each dr1 As DataRow In dsDetail.Tables(0).Rows
                txtNroBLAWB.Text = dr1("NRO_DOCEMB")
                txtFechaEmbarque.Text = HelpClass.CNumero8Digitos_a_FechaDefault(dr1("FCH_DOCEMB"))
                txtFechaLlegada.Text = HelpClass.CNumero8Digitos_a_FechaDefault(dr1("FCH_LLEG"))
                'txtFechaEstimLlegada.Text = HelpClass.CNumero8Digitos_a_FechaDefault(dr1("FEST_LLEGA"))
                txtPuertoEmbarque.Text = dr1("NOMB_PEMB")
                'txtEmpresaTransporte1.Text = dr1("DESC_EMPR")
                'txtMatricula.Text = dr1("MATRICULA")
                'txtPesoBruto.Text = dr1("KLS_DECLA")
                'txtPesoNeto.Text = dr1("PESO_NETO")
                'txtNroBultos.Text = dr1("BULTOS")
                txtClaseBultos.Text = dr1("CLASE_BULT")
                'txtFlete1.Text = dr1("FLETE")
                'txtGastos.Text = dr1("GASTOS")
                txtCantidadContenedores.Text = dr1("CCONTENER")
            Next
        End If

        'Contenedores
        dgvContenedores.AutoGenerateColumns = False
        dgvContenedores.DataSource = dsDetail.Tables(1)

        '  ********* FACTURAS Y SERIES *********

        ' Factura
        dgvFactura.AutoGenerateColumns = False
        Dim dtFactura As New DataTable
        Dim drFactura As DataRow
        dtFactura.Columns.Add("NUME_SECUF")
        dtFactura.Columns.Add("NUME_FACTU")
        dtFactura.Columns.Add("FCH_FACTU")
        dtFactura.Columns.Add("TERM_TRANS")
        dtFactura.Columns.Add("VFOB_FACTU")
        dtFactura.Columns.Add("VFLE_FACTU")
        dtFactura.Columns.Add("VSEG_FACTU")

        If dsDetail.Tables(2).Rows.Count > 0 Then
            For Each dr2 As DataRow In dsDetail.Tables(2).Rows
                drFactura = dtFactura.NewRow
                drFactura("NUME_SECUF") = dr2("NUME_SECUF")
                drFactura("NUME_FACTU") = dr2("NUME_FACTU")
                drFactura("FCH_FACTU") = HelpClass.CNumero8Digitos_a_FechaDefault(dr2("FCH_FACTU"))
                drFactura("TERM_TRANS") = dr2("TERM_TRANS")
                drFactura("VFOB_FACTU") = dr2("VFOB_FACTU")
                drFactura("VFLE_FACTU") = dr2("VFLE_FACTU")
                drFactura("VSEG_FACTU") = dr2("VSEG_FACTU")
                dtFactura.Rows.Add(drFactura)
            Next
            dgvFactura.DataSource = dtFactura
        End If


        ' Serie y Liquidacion serie
        dgvSeries.AutoGenerateColumns = False
        dgvSeries.DataSource = dsDetail.Tables(3)



        '**************  OBSERVACIONES ***********
        dgvObservaciones.AutoGenerateColumns = False

        dgvFactura.AutoGenerateColumns = False
        Dim dtObservaciones As New DataTable
        Dim drObservaciones As DataRow
        dtObservaciones.Columns.Add("NUME_REGI")
        dtObservaciones.Columns.Add("FCH_INC")
        dtObservaciones.Columns.Add("INCIDENCIA")

        If dsDetail.Tables(4).Rows.Count > 0 Then
            For Each dr3 As DataRow In dsDetail.Tables(4).Rows
                drObservaciones = dtObservaciones.NewRow
                drObservaciones("NUME_REGI") = dr3("NUME_REGI")
                drObservaciones("FCH_INC") = HelpClass.CNumero8Digitos_a_FechaDefault(dr3("FCH_INC"))
                drObservaciones("INCIDENCIA") = dr3("INCIDENCIA")
                dtObservaciones.Rows.Add(drObservaciones)
            Next
            dgvObservaciones.DataSource = dtObservaciones
        End If

    End Sub

    Private Sub Cerrar(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
End Class
