Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports System.Web
Imports Db2Manager.RansaData.iSeries.DataObjects
'Imports Ransa.TypeDef.Cliente
Imports Ransa.Controls.Cliente
'Imports Ransa.DAO.Cliente
Imports System.Text

Public Class frmCtaCteXCliente
    Private oCompania As clsCompania
    Private oDivision As clsDivision
    Private oPlanta As clsPlanta
    Private oDtPlanta As DataTable
    Private oDtRegionVenta As DataTable
    Private oRegionVenta As clsRegionVenta
    Private oFacturaNeg As SOLMIN_CTZ.NEGOCIO.clsFactura
    Private oMoneda As New SOLMIN_CTZ.NEGOCIO.clsMoneda
    Private _Evento As Integer
    Private Sub frmCtaCteXCliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.dtgCuentaCorriente.AutoGenerateColumns = False
        Me.dtgVentas.AutoGenerateColumns = False
        oPlanta = New clsPlanta
        oPlanta.Lista = DirectCast(HttpRuntime.Cache.Get("Planta"), clsPlanta).Lista.Copy
        oDivision = New clsDivision
        oDivision.Lista = DirectCast(HttpRuntime.Cache.Get("Division"), clsDivision).Lista.Copy
        oCompania = New clsCompania
        oCompania.Lista = DirectCast(HttpRuntime.Cache.Get("Compania"), clsCompania).Lista.Copy
        oRegionVenta = New SOLMIN_CTZ.NEGOCIO.clsRegionVenta

        Cargar_Compania()
        Cargar_Region_Venta()
        Cargar_Moneda()

        Dim oFiltro As New Filtro
        oFiltro.Parametro1 = "100"
        oFiltro.Parametro2 = Format(Now, "yyyyMMdd")
        oFacturaNeg = New clsFactura
        Me.crearGridXPeriodo()
        Me.crearGridXPeriodo_Detalle()
    End Sub
    Private Sub Cargar_Compania()
        UcCompania.Usuario = ConfigurationWizard.UserName
        UcCompania.pActualizar()
        UcCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)

    End Sub
    Private Sub UcCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania.Seleccionar
        UcDivision.Compania = obeCompania.CCMPN_CodigoCompania
        UcDivision.Usuario = ConfigurationWizard.UserName
        UcDivision.pActualizar()

    End Sub

    Private Sub UcDivision_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles UcDivision.Seleccionar

        oDtPlanta = oPlanta.Lista_Planta_Division(obeDivision.CCMPN_CodigoCompania, obeDivision.CDVSN_CodigoDivision)
        oDtPlanta.Columns.Remove("CCMPN")
        oDtPlanta.Columns.Remove("CDVSN")
        oDtPlanta.Columns.Remove("CRGVTA")
        Me.cmbPlanta.ValueMember = "CPLNDV"
        Me.cmbPlanta.DisplayMember = "TPLNTA"
        Me.cmbPlanta.DataSource = oDtPlanta
        For i As Integer = 0 To cmbPlanta.Items.Count - 1
            If cmbPlanta.Items.Item(i).Value = "-1" Then
                cmbPlanta.SetItemChecked(i, True)
            End If
        Next

    End Sub

    Private Sub chkPorPeriodo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPorPeriodo.CheckedChanged
        If chkPorPeriodo.Checked = True Then
            lblFechaIni.Visible = True
            lblFechaFin.Visible = True
            dtFechaInicio.Visible = True
            dtFechaFin.Visible = True
            Me.crearGridXPeriodo()
            Me.crearGridXPeriodo_Detalle()
        Else
            lblFechaIni.Visible = False
            lblFechaFin.Visible = False
            dtFechaInicio.Visible = False
            dtFechaFin.Visible = False
        End If
    End Sub

    Private Sub chkPorAnio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPorAnio.CheckedChanged
        If chkPorAnio.Checked = True Then
            lblanio.Visible = True
            txtAnio.Visible = True
            txtAnio.Text = Date.Now.Year
            lblanio.Location = New Point(377, 64)
            txtAnio.Location = New Point(419, 64)
            Me.crearGridXAnio()
            Me.crearGridXAnio_Detalle()
        Else
            lblanio.Visible = False
            txtAnio.Visible = False
            txtAnio.Text = ""
        End If
    End Sub
    Private Sub Cargar_Region_Venta()
        oRegionVenta.Crea_Lista()
        oDtRegionVenta = oRegionVenta.Lista_Region_Venta(UcCompania.CCMPN_CodigoCompania)
        oDtRegionVenta.Columns.Remove("CCMPN")
        Me.cmbRegionVenta.ValueMember = "CRGVTA"
        Me.cmbRegionVenta.DisplayMember = "TCRVTA"
        Me.cmbRegionVenta.DataSource = oDtRegionVenta

        For j As Integer = 0 To Me.cmbRegionVenta.Items.Count - 1
            If cmbRegionVenta.Items.Item(j).Value = "-1" Then
                cmbRegionVenta.SetItemChecked(j, True)
            End If
        Next
    End Sub

    Private Sub crearGridXPeriodo()
        Dim CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim TCMPCL As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim ITTFCS As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim ITTFCD As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim TPPCJE As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim COLMIMG As System.Windows.Forms.DataGridViewImageColumn

        Dim ESTILO_NUM As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        ESTILO_NUM.Alignment = DataGridViewContentAlignment.MiddleRight
        ESTILO_NUM.Format = "N3"
        dtgCuentaCorriente.Columns.Clear()
        dtgCuentaCorriente.DataSource = Nothing
        CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        CCLNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        CCLNT.DataPropertyName = "CCLNT"
        CCLNT.HeaderText = "Código"
        CCLNT.Name = "CCLNT"
        CCLNT.ReadOnly = True
        CCLNT.Width = 55
        dtgCuentaCorriente.Columns.Add(CCLNT)

        TCMPCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        TCMPCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        TCMPCL.DataPropertyName = "TCMPCL"
        TCMPCL.HeaderText = "Cliente"
        TCMPCL.Name = "TCMPCL"
        TCMPCL.ReadOnly = True
        dtgCuentaCorriente.Columns.Add(TCMPCL)
        'IVLAFS
        '
        ITTFCS = New System.Windows.Forms.DataGridViewTextBoxColumn
        ITTFCS.DataPropertyName = "IVLAFS"
        ITTFCS.HeaderText = "Importe Soles"
        ITTFCS.Name = "IVLAFS"
        ITTFCS.ReadOnly = True
        ITTFCS.DefaultCellStyle = ESTILO_NUM
        dtgCuentaCorriente.Columns.Add(ITTFCS)
        '
        'IVLAFD
        '
        ITTFCD = New System.Windows.Forms.DataGridViewTextBoxColumn
        ITTFCD.DataPropertyName = "IVLAFD"
        ITTFCD.HeaderText = "Importe Dolares"
        ITTFCD.Name = "IVLAFD"
        ITTFCD.ReadOnly = True
        ITTFCD.DefaultCellStyle = ESTILO_NUM
        dtgCuentaCorriente.Columns.Add(ITTFCD)

        TPPCJE = New System.Windows.Forms.DataGridViewTextBoxColumn
        TPPCJE.DataPropertyName = "TPPCJE"
        TPPCJE.HeaderText = "Porcentaje %"
        TPPCJE.Name = "TPPCJE"
        TPPCJE.ReadOnly = True
        TPPCJE.DefaultCellStyle = ESTILO_NUM
        dtgCuentaCorriente.Columns.Add(TPPCJE)



        COLMIMG = New System.Windows.Forms.DataGridViewImageColumn
        COLMIMG.HeaderText = "..."
        COLMIMG.Name = "IMG"
        COLMIMG.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        COLMIMG.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        COLMIMG.ReadOnly = True
        COLMIMG.Image = My.Resources.text_block
        dtgCuentaCorriente.Columns.Add(COLMIMG)

    End Sub
    Private Sub crearGridXPeriodo_Detalle()
        Dim CRBCTC As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim TCMTRF As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim IVLDCS As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim IVLDCD As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim COLMIMG As System.Windows.Forms.DataGridViewImageColumn

        Dim ESTILO_NUM As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        ESTILO_NUM.Alignment = DataGridViewContentAlignment.MiddleRight
        ESTILO_NUM.Format = "N3"
        dtgVentas.Columns.Clear()
        dtgVentas.DataSource = Nothing

        CRBCTC = New System.Windows.Forms.DataGridViewTextBoxColumn
        CRBCTC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        CRBCTC.DataPropertyName = "CRBCTC"
        CRBCTC.HeaderText = "Código"
        CRBCTC.Name = "CRBCTC"
        CRBCTC.ReadOnly = True
        CRBCTC.Width = 55
        dtgVentas.Columns.Add(CRBCTC)

        TCMTRF = New System.Windows.Forms.DataGridViewTextBoxColumn
        TCMTRF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        TCMTRF.DataPropertyName = "TCMTRF"
        TCMTRF.HeaderText = "Rubro"
        TCMTRF.Name = "TCMTRF"
        TCMTRF.ReadOnly = True
        dtgVentas.Columns.Add(TCMTRF)
        'IVLAFS
        '
        IVLDCS = New System.Windows.Forms.DataGridViewTextBoxColumn
        IVLDCS.DataPropertyName = "IVLDCS"
        IVLDCS.HeaderText = "Importe Soles"
        IVLDCS.Name = "IVLDCS"
        IVLDCS.ReadOnly = True
        IVLDCS.DefaultCellStyle = ESTILO_NUM
        dtgVentas.Columns.Add(IVLDCS)
        '
        'IVLAFD
        '
        IVLDCD = New System.Windows.Forms.DataGridViewTextBoxColumn
        IVLDCD.DataPropertyName = "IVLDCD"
        IVLDCD.HeaderText = "Importe Dolares"
        IVLDCD.Name = "IVLDCD"
        IVLDCD.ReadOnly = True
        IVLDCD.DefaultCellStyle = ESTILO_NUM
        dtgVentas.Columns.Add(IVLDCD)

        COLMIMG = New System.Windows.Forms.DataGridViewImageColumn
        COLMIMG.HeaderText = "..."
        COLMIMG.Name = "IMG"
        COLMIMG.ReadOnly = True
        COLMIMG.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        COLMIMG.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        COLMIMG.Image = My.Resources.text_block
        dtgVentas.Columns.Add(COLMIMG)

    End Sub
    Private Sub crearGridXAnio()
        Dim CCLNT As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim TCMPCL As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim MESENE As System.Windows.Forms.DataGridViewLinkColumn
        Dim MESFEB As System.Windows.Forms.DataGridViewLinkColumn
        Dim MESMAR As System.Windows.Forms.DataGridViewLinkColumn
        Dim MESABR As System.Windows.Forms.DataGridViewLinkColumn
        Dim MESMAY As System.Windows.Forms.DataGridViewLinkColumn
        Dim MESJUN As System.Windows.Forms.DataGridViewLinkColumn
        Dim MESJUL As System.Windows.Forms.DataGridViewLinkColumn
        Dim MESAGO As System.Windows.Forms.DataGridViewLinkColumn
        Dim MESSET As System.Windows.Forms.DataGridViewLinkColumn
        Dim MESOCT As System.Windows.Forms.DataGridViewLinkColumn
        Dim MESNOV As System.Windows.Forms.DataGridViewLinkColumn
        Dim MESDIC As System.Windows.Forms.DataGridViewLinkColumn
        Dim TOANIO As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim TOPCJE As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim ESTILO_NUM As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        ESTILO_NUM.Alignment = DataGridViewContentAlignment.MiddleRight

        ESTILO_NUM.Format = "N3"
        dtgCuentaCorriente.Columns.Clear()
        dtgCuentaCorriente.DataSource = Nothing
        CCLNT = New System.Windows.Forms.DataGridViewTextBoxColumn
        CCLNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        CCLNT.DataPropertyName = "CCLNT"
        CCLNT.HeaderText = "Código"
        CCLNT.Name = "CCLNT"
        CCLNT.ReadOnly = True
        CCLNT.Width = 55
        dtgCuentaCorriente.Columns.Add(CCLNT)

        TCMPCL = New System.Windows.Forms.DataGridViewTextBoxColumn
        TCMPCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        TCMPCL.DataPropertyName = "TCMPCL"
        TCMPCL.HeaderText = "Cliente"
        TCMPCL.Name = "TCMPCL"
        TCMPCL.ReadOnly = True
        TCMPCL.Width = 350
        dtgCuentaCorriente.Columns.Add(TCMPCL)

        MESENE = New System.Windows.Forms.DataGridViewLinkColumn
        MESENE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        MESENE.DataPropertyName = "MES01"
        MESENE.HeaderText = "Enero"
        MESENE.Name = "MESENE"
        MESENE.ReadOnly = True
        MESENE.DefaultCellStyle = ESTILO_NUM
        dtgCuentaCorriente.Columns.Add(MESENE)

        MESFEB = New System.Windows.Forms.DataGridViewLinkColumn
        MESFEB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        MESFEB.DataPropertyName = "MES02"
        MESFEB.HeaderText = "Febrero"
        MESFEB.Name = "MESFEB"
        MESFEB.ReadOnly = True
        MESFEB.DefaultCellStyle = ESTILO_NUM
        dtgCuentaCorriente.Columns.Add(MESFEB)

        MESMAR = New System.Windows.Forms.DataGridViewLinkColumn
        MESMAR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        MESMAR.DataPropertyName = "MES03"
        MESMAR.HeaderText = "Marzo"
        MESMAR.Name = "MESMAR"
        MESMAR.ReadOnly = True
        MESMAR.DefaultCellStyle = ESTILO_NUM
        dtgCuentaCorriente.Columns.Add(MESMAR)

        MESABR = New System.Windows.Forms.DataGridViewLinkColumn
        MESABR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        MESABR.DataPropertyName = "MES04"
        MESABR.HeaderText = "Abril"
        MESABR.Name = "MESABR"
        MESABR.ReadOnly = True
        MESABR.DefaultCellStyle = ESTILO_NUM
        dtgCuentaCorriente.Columns.Add(MESABR)

        MESMAY = New System.Windows.Forms.DataGridViewLinkColumn
        MESMAY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        MESMAY.DataPropertyName = "MES05"
        MESMAY.HeaderText = "Mayo"
        MESMAY.Name = "MESMAY"
        MESMAY.ReadOnly = True
        MESMAY.DefaultCellStyle = ESTILO_NUM
        dtgCuentaCorriente.Columns.Add(MESMAY)

        MESJUN = New System.Windows.Forms.DataGridViewLinkColumn
        MESJUN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        MESJUN.DataPropertyName = "MES06"
        MESJUN.HeaderText = "Junio"
        MESJUN.Name = "MESJUN"
        MESJUN.ReadOnly = True
        MESJUN.DefaultCellStyle = ESTILO_NUM
        dtgCuentaCorriente.Columns.Add(MESJUN)

        MESJUL = New System.Windows.Forms.DataGridViewLinkColumn
        MESJUL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        MESJUL.DataPropertyName = "MES07"
        MESJUL.HeaderText = "Julio"
        MESJUL.Name = "MESJUL"
        MESJUL.ReadOnly = True
        MESJUL.DefaultCellStyle = ESTILO_NUM
        dtgCuentaCorriente.Columns.Add(MESJUL)

        MESAGO = New System.Windows.Forms.DataGridViewLinkColumn
        MESAGO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        MESAGO.DataPropertyName = "MES08"
        MESAGO.HeaderText = "Agosto"
        MESAGO.Name = "MESAGO"
        MESAGO.ReadOnly = True
        MESAGO.DefaultCellStyle = ESTILO_NUM
        dtgCuentaCorriente.Columns.Add(MESAGO)

        MESSET = New System.Windows.Forms.DataGridViewLinkColumn
        MESSET.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        MESSET.DataPropertyName = "MES09"
        MESSET.HeaderText = "Setiembre"
        MESSET.Name = "MESSET"
        MESSET.ReadOnly = True
        MESSET.DefaultCellStyle = ESTILO_NUM
        dtgCuentaCorriente.Columns.Add(MESSET)

        MESOCT = New System.Windows.Forms.DataGridViewLinkColumn
        MESOCT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        MESOCT.DataPropertyName = "MES10"
        MESOCT.HeaderText = "Octubre"
        MESOCT.Name = "MESOCT"
        MESOCT.ReadOnly = True
        MESOCT.DefaultCellStyle = ESTILO_NUM
        dtgCuentaCorriente.Columns.Add(MESOCT)

        MESNOV = New System.Windows.Forms.DataGridViewLinkColumn
        MESNOV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        MESNOV.DataPropertyName = "MES11"
        MESNOV.HeaderText = "Noviembre"
        MESNOV.Name = "MESNOV"
        MESNOV.ReadOnly = True
        MESNOV.DefaultCellStyle = ESTILO_NUM
        dtgCuentaCorriente.Columns.Add(MESNOV)

        MESDIC = New System.Windows.Forms.DataGridViewLinkColumn
        MESDIC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        MESDIC.DataPropertyName = "MES12"
        MESDIC.HeaderText = "Diciembre"
        MESDIC.Name = "MESDIC"
        MESDIC.ReadOnly = True
        MESDIC.DefaultCellStyle = ESTILO_NUM
        dtgCuentaCorriente.Columns.Add(MESDIC)

        TOANIO = New System.Windows.Forms.DataGridViewTextBoxColumn
        TOANIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        TOANIO.DataPropertyName = "TOANIO"
        TOANIO.HeaderText = "Total Año"
        TOANIO.Name = "TOANIO"
        TOANIO.ReadOnly = True
        TOANIO.DefaultCellStyle = ESTILO_NUM
        dtgCuentaCorriente.Columns.Add(TOANIO)

        TOPCJE = New System.Windows.Forms.DataGridViewTextBoxColumn
        TOPCJE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        TOPCJE.DataPropertyName = "TOPCJE"
        TOPCJE.HeaderText = "Porcentaje %"
        TOPCJE.Name = "TOPCJE"
        TOPCJE.ReadOnly = True
        TOPCJE.DefaultCellStyle = ESTILO_NUM
        dtgCuentaCorriente.Columns.Add(TOPCJE)
    End Sub
    Private Sub crearGridXAnio_Detalle()
        Dim CRBCTC As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim TCMTRF As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim MESENE As System.Windows.Forms.DataGridViewLinkColumn
        Dim MESFEB As System.Windows.Forms.DataGridViewLinkColumn
        Dim MESMAR As System.Windows.Forms.DataGridViewLinkColumn
        Dim MESABR As System.Windows.Forms.DataGridViewLinkColumn
        Dim MESMAY As System.Windows.Forms.DataGridViewLinkColumn
        Dim MESJUN As System.Windows.Forms.DataGridViewLinkColumn
        Dim MESJUL As System.Windows.Forms.DataGridViewLinkColumn
        Dim MESAGO As System.Windows.Forms.DataGridViewLinkColumn
        Dim MESSET As System.Windows.Forms.DataGridViewLinkColumn
        Dim MESOCT As System.Windows.Forms.DataGridViewLinkColumn
        Dim MESNOV As System.Windows.Forms.DataGridViewLinkColumn
        Dim MESDIC As System.Windows.Forms.DataGridViewLinkColumn
        Dim TOANIO As System.Windows.Forms.DataGridViewTextBoxColumn
        Dim ESTILO_NUM As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        ESTILO_NUM.Alignment = DataGridViewContentAlignment.MiddleRight
        ESTILO_NUM.Format = "N3"

        dtgVentas.Columns.Clear()
        dtgVentas.DataSource = Nothing

        CRBCTC = New System.Windows.Forms.DataGridViewTextBoxColumn
        CRBCTC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        CRBCTC.DataPropertyName = "CRBCTC"
        CRBCTC.HeaderText = "Código"
        CRBCTC.Name = "CRBCTC"
        CRBCTC.ReadOnly = True
        CRBCTC.Width = 55
        dtgVentas.Columns.Add(CRBCTC)

        TCMTRF = New System.Windows.Forms.DataGridViewTextBoxColumn
        TCMTRF.DataPropertyName = "TCMTRF"
        TCMTRF.HeaderText = "Rubro"
        TCMTRF.Name = "TCMTRF"
        TCMTRF.ReadOnly = True
        TCMTRF.Width = 350
        dtgVentas.Columns.Add(TCMTRF)

        MESENE = New System.Windows.Forms.DataGridViewLinkColumn
        MESENE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        MESENE.DataPropertyName = "MES01"
        MESENE.HeaderText = "Enero"
        MESENE.Name = "MESENE"
        MESENE.ReadOnly = True
        MESENE.DefaultCellStyle = ESTILO_NUM
        dtgVentas.Columns.Add(MESENE)

        MESFEB = New System.Windows.Forms.DataGridViewLinkColumn
        MESFEB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        MESFEB.DataPropertyName = "MES02"
        MESFEB.HeaderText = "Febrero"
        MESFEB.Name = "MESFEB"
        MESFEB.ReadOnly = True
        MESFEB.DefaultCellStyle = ESTILO_NUM
        dtgVentas.Columns.Add(MESFEB)

        MESMAR = New System.Windows.Forms.DataGridViewLinkColumn
        MESMAR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        MESMAR.DataPropertyName = "MES03"
        MESMAR.HeaderText = "Marzo"
        MESMAR.Name = "MESMAR"
        MESMAR.ReadOnly = True
        MESMAR.DefaultCellStyle = ESTILO_NUM
        dtgVentas.Columns.Add(MESMAR)

        MESABR = New System.Windows.Forms.DataGridViewLinkColumn
        MESABR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        MESABR.DataPropertyName = "MES04"
        MESABR.HeaderText = "Abril"
        MESABR.Name = "MESABR"
        MESABR.ReadOnly = True
        MESABR.DefaultCellStyle = ESTILO_NUM
        dtgVentas.Columns.Add(MESABR)

        MESMAY = New System.Windows.Forms.DataGridViewLinkColumn
        MESMAY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        MESMAY.DataPropertyName = "MES05"
        MESMAY.HeaderText = "Mayo"
        MESMAY.Name = "MESMAY"
        MESMAY.ReadOnly = True
        MESMAY.DefaultCellStyle = ESTILO_NUM
        dtgVentas.Columns.Add(MESMAY)

        MESJUN = New System.Windows.Forms.DataGridViewLinkColumn
        MESJUN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        MESJUN.DataPropertyName = "MES06"
        MESJUN.HeaderText = "Junio"
        MESJUN.Name = "MESJUN"
        MESJUN.ReadOnly = True
        MESJUN.DefaultCellStyle = ESTILO_NUM
        dtgVentas.Columns.Add(MESJUN)

        MESJUL = New System.Windows.Forms.DataGridViewLinkColumn
        MESJUL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        MESJUL.DataPropertyName = "MES07"
        MESJUL.HeaderText = "Julio"
        MESJUL.Name = "MESJUL"
        MESJUL.ReadOnly = True
        MESJUL.DefaultCellStyle = ESTILO_NUM
        dtgVentas.Columns.Add(MESJUL)

        MESAGO = New System.Windows.Forms.DataGridViewLinkColumn
        MESAGO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        MESAGO.DataPropertyName = "MES08"
        MESAGO.HeaderText = "Agosto"
        MESAGO.Name = "MESAGO"
        MESAGO.ReadOnly = True
        MESAGO.DefaultCellStyle = ESTILO_NUM
        dtgVentas.Columns.Add(MESAGO)

        MESSET = New System.Windows.Forms.DataGridViewLinkColumn
        MESSET.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        MESSET.DataPropertyName = "MES09"
        MESSET.HeaderText = "Setiembre"
        MESSET.Name = "MESSET"
        MESSET.ReadOnly = True
        MESSET.DefaultCellStyle = ESTILO_NUM
        dtgVentas.Columns.Add(MESSET)

        MESOCT = New System.Windows.Forms.DataGridViewLinkColumn
        MESOCT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        MESOCT.DataPropertyName = "MES10"
        MESOCT.HeaderText = "Octubre"
        MESOCT.Name = "MESOCT"
        MESOCT.ReadOnly = True
        MESOCT.DefaultCellStyle = ESTILO_NUM
        dtgVentas.Columns.Add(MESOCT)

        MESNOV = New System.Windows.Forms.DataGridViewLinkColumn
        MESNOV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        MESNOV.DataPropertyName = "MES11"
        MESNOV.HeaderText = "Noviembre"
        MESNOV.Name = "MESNOV"
        MESNOV.ReadOnly = True
        MESNOV.DefaultCellStyle = ESTILO_NUM
        dtgVentas.Columns.Add(MESNOV)

        MESDIC = New System.Windows.Forms.DataGridViewLinkColumn
        MESDIC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        MESDIC.DataPropertyName = "MES12"
        MESDIC.HeaderText = "Diciembre"
        MESDIC.Name = "MESDIC"
        MESDIC.ReadOnly = True
        MESDIC.DefaultCellStyle = ESTILO_NUM
        dtgVentas.Columns.Add(MESDIC)

        TOANIO = New System.Windows.Forms.DataGridViewTextBoxColumn
        TOANIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        TOANIO.DataPropertyName = "TOANIO"
        TOANIO.HeaderText = "Total Año"
        TOANIO.Name = "TOANIO"
        TOANIO.ReadOnly = True
        TOANIO.DefaultCellStyle = ESTILO_NUM
        dtgVentas.Columns.Add(TOANIO)


    End Sub
    Private Sub Cargar_Moneda()
        Dim dtMoneda As New DataTable
        oMoneda.Crea_Moneda()
        dtMoneda = oMoneda.Lista_Moneda_x_All(1)
        Dim dtMonedaRep As New DataTable
        dtMonedaRep = dtMoneda.Copy
        dtMonedaRep.Rows.Clear()
        Dim Fila As Int32 = 0
        For Each Item As DataRow In dtMoneda.Rows
            If Item("CMNDA1") = 1 OrElse Item("CMNDA1") = 100 Then
                dtMonedaRep.ImportRow(Item)
                Fila = dtMonedaRep.Rows.Count - 1
                dtMonedaRep.Rows(Fila)("TMNDA") = dtMonedaRep.Rows(Fila)("CMNDA1") & " - " & ("" & dtMonedaRep.Rows(Fila)("TMNDA")).ToString.Trim
            End If
        Next
        cmbMoneda.DataSource = dtMonedaRep
        cmbMoneda.ValueMember = "CMNDA1"
        cmbMoneda.DisplayMember = "TMNDA"
        cmbMoneda.SelectedValue = 1
    End Sub
    Private Sub Listar_Ctacte_x_Cliente_Periodo()
        Dim oCtacteNegocio As New SOLMIN_CTZ.NEGOCIO.clsCuentaCorriente
        Dim oCtacteEntidad As New SOLMIN_CTZ.Entidades.CuentaCorriente
        Dim dtResult As DataTable
        Dim addsum As Decimal

        oCtacteEntidad.PSCCMPN = Me.UcCompania.CCMPN_CodigoCompania
        oCtacteEntidad.PSCDVSN = IIf(Me.UcDivision.Division = "-1", fstrListaDivisionXUsuario(), Me.UcDivision.Division)
        oCtacteEntidad.PSCPLNDV = IIf(Lista_Planta() = "-1", "", Lista_Planta())
        oCtacteEntidad.PNCCLNT = Me.UcCliente.pCodigo
        oCtacteEntidad.FechaInicio = Format(Me.dtFechaInicio.Value, "yyyyMMdd")
        oCtacteEntidad.FechaFin = Format(Me.dtFechaFin.Value, "yyyyMMdd")
        oCtacteEntidad.CRGVTA = Lista_RegionVenta()

        dtResult = oCtacteNegocio.Lista_CuentaCorriente_X_Cliente_Perido(oCtacteEntidad)
        If dtResult.Rows.Count > 0 Then
            Dim dv As New DataView(dtResult)
            dv.Sort = "IVLAFS asc"
            Dim dt As DataTable = dv.ToTable
            Dim num As Decimal = dt.Rows(0).Item("IVLAFS")
            If num < 0 Then
                addsum = -(num - 1)
                Dim dtCopy As DataTable
                dtCopy = dtResult.Copy
                For intX As Integer = 0 To dtCopy.Rows.Count - 1
                    dtCopy.Rows(intX).Item("IVLAFS") = dtCopy.Rows(intX).Item("IVLAFS") + addsum
                Next
                Dim sumTotal As Decimal = dtCopy.Compute("sum(IVLAFS)", "").ToString
                Dim s As Decimal = 0
                For intX As Integer = 0 To dtCopy.Rows.Count - 1
                    dtCopy.Rows(intX).Item("TPPCJE") = Math.Round((dtCopy.Rows(intX).Item("IVLAFS") / sumTotal) * 100, 3)
                    s = s + dtCopy.Rows(intX).Item("TPPCJE")
                Next
                For intX As Integer = 0 To dtCopy.Rows.Count - 1
                    dtResult.Rows(intX).Item("TPPCJE") = dtCopy.Rows(intX).Item("TPPCJE")
                Next
            Else
                Dim sumTotal As Decimal = dtResult.Compute("sum(IVLAFS)", "").ToString
                Dim s As Decimal = 0
                For intX As Integer = 0 To dtResult.Rows.Count - 1
                    dtResult.Rows(intX).Item("TPPCJE") = Math.Round((dtResult.Rows(intX).Item("IVLAFS") / sumTotal) * 100, 3)
                    s = s + dtResult.Rows(intX).Item("TPPCJE")
                Next
            End If
        End If

        Dim dtView As New DataView(dtResult)
        dtView.Sort = "TPPCJE DESC"
        dtResult = dtView.ToTable
        If cmbMoneda.SelectedValue = 1 Then
            Me.dtgCuentaCorriente.Columns("IVLAFS").Visible = True
            Me.dtgCuentaCorriente.Columns("IVLAFD").Visible = False
        Else
            Me.dtgCuentaCorriente.Columns("IVLAFS").Visible = False
            Me.dtgCuentaCorriente.Columns("IVLAFD").Visible = True
        End If
        Me.dtgCuentaCorriente.DataSource = dtResult
    End Sub
    Private Sub Listar_Ctacte_x_Cliente_Periodo_Detalle()
        Dim oCtacteNegocio As New SOLMIN_CTZ.NEGOCIO.clsCuentaCorriente
        Dim oCtacteEntidad As New SOLMIN_CTZ.Entidades.CuentaCorriente
        Dim dtResult As DataTable
        If Me.dtgCuentaCorriente.CurrentCellAddress.Y = -1 Then Exit Sub
        oCtacteEntidad.PSCCMPN = Me.UcCompania.CCMPN_CodigoCompania
        oCtacteEntidad.PSCDVSN = IIf(Me.UcDivision.Division = "-1", fstrListaDivisionXUsuario, Me.UcDivision.Division)
        oCtacteEntidad.PSCPLNDV = IIf(Lista_Planta() = "-1", "", Lista_Planta())
        oCtacteEntidad.PNCCLNT = Me.dtgCuentaCorriente.Item("CCLNT", Me.dtgCuentaCorriente.CurrentCellAddress.Y).Value
        oCtacteEntidad.FechaInicio = Format(Me.dtFechaInicio.Value, "yyyyMMdd")
        oCtacteEntidad.FechaFin = Format(Me.dtFechaFin.Value, "yyyyMMdd")
        oCtacteEntidad.CRGVTA = Lista_RegionVenta()

        dtResult = oCtacteNegocio.Lista_CuentaCorriente_X_Cliente_Perido_Detalle(oCtacteEntidad)
        If cmbMoneda.SelectedValue = 1 Then
            Me.dtgVentas.Columns("IVLDCS").Visible = True
            Me.dtgVentas.Columns("IVLDCD").Visible = False
        Else
            Me.dtgVentas.Columns("IVLDCD").Visible = True
            Me.dtgVentas.Columns("IVLDCS").Visible = False
        End If
        Me.dtgVentas.DataSource = dtResult
    End Sub
    Private Sub Listar_Ctacte_x_Cliente_Anio()
        Dim oCtacteNegocio As New SOLMIN_CTZ.NEGOCIO.clsCuentaCorriente
        Dim oCtacteEntidad As New SOLMIN_CTZ.Entidades.CuentaCorriente
        Dim dtResult As DataTable

        oCtacteEntidad.PSCCMPN = Me.UcCompania.CCMPN_CodigoCompania
        oCtacteEntidad.PSCDVSN = IIf(Me.UcDivision.Division = "-1", fstrListaDivisionXUsuario(), Me.UcDivision.Division)
        oCtacteEntidad.PSCPLNDV = IIf(Lista_Planta() = "-1", "", Lista_Planta())
        oCtacteEntidad.PNCCLNT = Me.UcCliente.pCodigo
        oCtacteEntidad.PNANIO = IIf(Me.txtAnio.Text = "", 0, Me.txtAnio.Text)
        oCtacteEntidad.CMNDA = Me.cmbMoneda.SelectedValue
        oCtacteEntidad.CRGVTA = Lista_RegionVenta()

        dtResult = oCtacteNegocio.Lista_CuentaCorriente_X_Cliente_Anio(oCtacteEntidad)
        If dtResult.Rows.Count > 0 Then
            Dim Suma As Decimal = 0
            Dim ColumName As String
            Dim addsum As Decimal
            For intX As Integer = 0 To dtResult.Rows.Count - 1
                For intY As Integer = 1 To 12
                    ColumName = String.Format("MES{0}", IIf(intY < 10, "0" & intY, intY))
                    Suma = Suma + IIf(IsDBNull(dtResult.Rows(intX).Item(ColumName)), 0, dtResult.Rows(intX).Item(ColumName))
                Next
                dtResult.Rows(intX).Item("TOANIO") = Suma
                Suma = 0
            Next
            If dtResult.Rows.Count > 0 Then
                Dim dv As New DataView(dtResult)
                dv.Sort = "TOANIO asc"
                Dim dt As DataTable = dv.ToTable
                Dim num As Decimal = dt.Rows(0).Item("TOANIO")
                If num < 0 Then
                    addsum = -(num - 1)
                    Dim dtCopy As DataTable
                    dtCopy = dtResult.Copy
                    For intX As Integer = 0 To dtCopy.Rows.Count - 1
                        dtCopy.Rows(intX).Item("TOANIO") = dtCopy.Rows(intX).Item("TOANIO") + addsum
                    Next
                    Dim sumTotal As Decimal = dtCopy.Compute("sum(TOANIO)", "").ToString
                    Dim s As Decimal = 0
                    For intX As Integer = 0 To dtCopy.Rows.Count - 1
                        dtCopy.Rows(intX).Item("TOPCJE") = Math.Round((dtCopy.Rows(intX).Item("TOANIO") / sumTotal) * 100, 3)
                        s = s + dtCopy.Rows(intX).Item("TOPCJE")
                    Next
                    For intX As Integer = 0 To dtCopy.Rows.Count - 1
                        dtResult.Rows(intX).Item("TOPCJE") = dtCopy.Rows(intX).Item("TOPCJE")
                    Next
                Else
                    Dim sumTotal As Decimal = dtResult.Compute("sum(TOANIO)", "").ToString
                    Dim s As Decimal = 0
                    For intX As Integer = 0 To dtResult.Rows.Count - 1
                        dtResult.Rows(intX).Item("TOPCJE") = Math.Round((dtResult.Rows(intX).Item("TOANIO") / sumTotal) * 100, 3)
                        s = s + dtResult.Rows(intX).Item("TOPCJE")
                    Next
                End If
            End If
        End If
        If dtResult.Rows.Count > 0 Then
            Dim dtView As New DataView(dtResult)
            dtView.Sort = "TOPCJE DESC"
            dtResult = dtView.ToTable
        End If
        Me.dtgCuentaCorriente.DataSource = dtResult
    End Sub
    Private Sub Listar_Ctacte_x_Cliente_Anio_Detalle()
        Dim oCtacteNegocio As New SOLMIN_CTZ.NEGOCIO.clsCuentaCorriente
        Dim oCtacteEntidad As New SOLMIN_CTZ.Entidades.CuentaCorriente
        Dim dtResult As DataTable
        If Me.dtgCuentaCorriente.CurrentCellAddress.Y = -1 Then Exit Sub
        oCtacteEntidad.PSCCMPN = Me.UcCompania.CCMPN_CodigoCompania
        oCtacteEntidad.PSCDVSN = IIf(Me.UcDivision.Division = "-1", fstrListaDivisionXUsuario, Me.UcDivision.Division)
        oCtacteEntidad.PSCPLNDV = IIf(Lista_Planta() = "-1", "", Lista_Planta())
        oCtacteEntidad.PNCCLNT = Me.dtgCuentaCorriente.Item("CCLNT", Me.dtgCuentaCorriente.CurrentCellAddress.Y).Value
        oCtacteEntidad.PNANIO = IIf(Me.txtAnio.Text = "", 0, Me.txtAnio.Text)
        oCtacteEntidad.CMNDA = Me.cmbMoneda.SelectedValue
        oCtacteEntidad.CRGVTA = Lista_RegionVenta()

        dtResult = oCtacteNegocio.Lista_CuentaCorriente_X_Cliente_Anio_Detalle(oCtacteEntidad)
        If dtResult.Rows.Count > 0 Then
            Dim Suma As Decimal = 0
            Dim ColumName As String
            For intX As Integer = 0 To dtResult.Rows.Count - 1
                For intY As Integer = 1 To 12
                    ColumName = String.Format("MES{0}", IIf(intY < 10, "0" & intY, intY))
                    Suma = Suma + IIf(IsDBNull(dtResult.Rows(intX).Item(ColumName)), 0, dtResult.Rows(intX).Item(ColumName))
                Next
                dtResult.Rows(intX).Item("TOANIO") = Suma
                Suma = 0
            Next
        End If
        Me.dtgVentas.DataSource = dtResult
    End Sub

    Private Function fstrListaDivisionXUsuario() As String
        'Dim strDivision As String = ""
        'Dim odaDivision As New Ransa.DAO.UbicacionPlanta.Division.daoDivision()
        'Dim olbeDivision As New List(Of Ransa.TypeDef.UbicacionPlanta.Division.beDivision)
        'olbeDivision = odaDivision.Lista_Division_X_Usuario(ConfigurationWizard.UserName())
        'For Each obeDivision As Ransa.TypeDef.UbicacionPlanta.Division.beDivision In olbeDivision
        '    strDivision = strDivision + obeDivision.CDVSN_CodigoDivision + ","
        'Next
        'If strDivision.Trim.Substring(strDivision.Trim.Length - 1, 1) = "," Then
        '    strDivision = strDivision.Trim.Substring(0, strDivision.Trim.Length - 1)
        'End If
        'Return strDivision


        Dim strDivision As String = ""
        'controls
        'Dim odaDivision As New Ransa.DAO.UbicacionPlanta.Division.daoDivision()
        Dim odaDivision As New Ransa.Controls.UbicacionPlanta.Division.daoDivision()
        Dim odtDivision As DataTable
        odtDivision = odaDivision.Lista_Division_X_Usuario_Y_Compania(ConfigurationWizard.UserName(), UcCompania.CCMPN_CodigoCompania)
        For Each odr As DataRow In odtDivision.Rows
            strDivision = strDivision + odr.Item("CDVSN") + ","
        Next
        If strDivision.Trim.Substring(strDivision.Trim.Length - 1, 1) = "," Then
            strDivision = strDivision.Trim.Substring(0, strDivision.Trim.Length - 1)
        End If
        Return strDivision

    End Function

    Private Function Lista_Planta() As String
        Dim strPlantas As String = ""
        For i As Integer = 0 To cmbPlanta.CheckedItems.Count - 1
            If (cmbPlanta.CheckedItems(i).Value <> "-1") Then
                For j As Integer = 0 To oDtPlanta.Rows.Count - 1
                    If (oDtPlanta.Rows(j).Item("CPLNDV") = cmbPlanta.CheckedItems(i).Value) Then
                        strPlantas += oDtPlanta.Rows(j).Item("CPLNDV") & ","
                    End If
                Next
            Else
                strPlantas = "-1,"
                Exit For
            End If
        Next
        If strPlantas.Trim.Length > 0 Then
            strPlantas = strPlantas.Trim.Substring(0, strPlantas.Trim.Length - 1)
        Else
            strPlantas = "-1"
        End If
        Return strPlantas
    End Function
    Private Function Lista_RegionVenta() As String
        Dim strRegionVenta As String = ""
        For i As Integer = 0 To cmbRegionVenta.CheckedItems.Count - 1
            If (cmbRegionVenta.CheckedItems(i).Value <> "-1") Then
                For j As Integer = 0 To oDtRegionVenta.Rows.Count - 1
                    If (oDtRegionVenta.Rows(j).Item("CRGVTA") = cmbRegionVenta.CheckedItems(i).Value) Then
                        strRegionVenta += oDtRegionVenta.Rows(j).Item("CRGVTA") & ","
                    End If
                Next
            Else
                strRegionVenta = ""
                Exit For
            End If
        Next
        If strRegionVenta.Trim.Length > 0 Then
            strRegionVenta = strRegionVenta.Trim.Substring(0, strRegionVenta.Trim.Length - 1)
        Else
            strRegionVenta = ""
        End If
        Return strRegionVenta
    End Function

    Private Sub btnBusca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusca.Click
        If chkPorPeriodo.Checked Then
            crearGridXPeriodo()
            Listar_Ctacte_x_Cliente_Periodo()
        ElseIf chkPorAnio.Checked Then
            If Me.txtAnio.Text.Trim = "" Then
                MessageBox.Show("Debe escribir un año", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            crearGridXAnio()
            Listar_Ctacte_x_Cliente_Anio()
        End If
    End Sub
    Private Sub dtgCuentaCorriente_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgCuentaCorriente.CurrentCellChanged
        If chkPorPeriodo.Checked Then
            crearGridXPeriodo_Detalle()
            Listar_Ctacte_x_Cliente_Periodo_Detalle()
        ElseIf chkPorAnio.Checked Then
            crearGridXAnio_Detalle()
            Listar_Ctacte_x_Cliente_Anio_Detalle()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim strTitulo As String = ""
        Dim olistTitulo As New List(Of String)
        If Me.dtgCuentaCorriente.Rows.Count = 0 Then Exit Sub

        olistTitulo.Add("Compañia :\n " & Me.UcCompania.CCMPN_Descripcion)
        olistTitulo.Add("División :\n " & Me.UcDivision.DivisionDescripcion)
        olistTitulo.Add("Planta :\n " & Me.cmbPlanta.Text)
        If Me.UcCliente.pRazonSocial <> "" Then
            olistTitulo.Add("Cliente :\n " & Me.UcCliente.pRazonSocial)
        End If
        olistTitulo.Add("Región :\n " & Me.cmbRegionVenta.Text)
        olistTitulo.Add("Moneda :\n " & Me.cmbMoneda.Text)
        If chkPorPeriodo.Checked Then
            strTitulo = "Reporte por Periodo"
            olistTitulo.Add("Fecha :\n " & Me.dtFechaInicio.Value.ToString.Substring(0, 10) & " Al " & Me.dtFechaFin.Value.ToString.Substring(0, 10))
        ElseIf chkPorAnio.Checked Then
            strTitulo = "Reporte por Año"
            olistTitulo.Add("Año :\n " & Me.txtAnio.Text)
        End If
        Ransa.Utilitario.HelpClass.ExportExcelConTitulos(Me.dtgCuentaCorriente, strTitulo, olistTitulo)
    End Sub
    Private Sub txtAnio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnio.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Function CrearFecha(ByVal Tipo As String, ByVal NumMes As Integer, ByVal Anio As Integer) As String
        Dim Fecha As String = ""
        Dim Dia As String = "01"
        Dim Mes As String = ""
        Mes = NumMes - 1
        If Mes.Trim.Length = 1 Then
            Mes = String.Format("0{0}", Mes)
        End If
        If Tipo = "I" Then
            Fecha = String.Format("{0}{1}{2}", Anio, Mes, Dia)
        ElseIf Tipo = "F" Then
            Dia = Date.DaysInMonth(Anio, Mes).ToString
            Fecha = String.Format("{0}{1}{2}", Anio, Mes, Dia)
        End If
        Return Fecha
    End Function
    Private Function ParametroFecha(ByVal NumMes As Integer, ByVal Anio As Integer) As String
        Dim Fecha As String = ""
        Dim Dia As String = "01"
        Dim Mes As String = ""
        Mes = NumMes - 1
        If Mes.Trim.Length = 1 Then
            Mes = String.Format("0{0}", Mes)
        End If
        Dia = Date.DaysInMonth(Anio, Mes).ToString
        Fecha = "Fecha: " & String.Format("01/{0}/{1}", Mes, Anio) & " - " & String.Format("{0}/{1}/{2}", Dia, Mes, Anio)
        Return Fecha
    End Function
    Private Function ConvertFecha(ByVal FechaDate As Date) As String
        Dim Fecha As String = ""
        Dim Dia As String = ""
        Dim Mes As String = ""
        Dim Anio As String = ""
        Dia = FechaDate.Day
        Mes = FechaDate.Month
        Anio = FechaDate.Year
        If Dia.Trim.Length = 1 Then
            Dia = String.Format("0{0}", Dia)
        End If
        If Mes.Trim.Length = 1 Then
            Mes = String.Format("0{0}", Mes)
        End If
        Fecha = String.Format("{0}/{1}/{2}", Dia, Mes, Anio)
        Return Fecha
    End Function
    Private Function ToCuentaCorrienteEntity(ByVal ColumnIndex As Integer, ByVal RowIndex As Integer) As CuentaCorriente
        Dim oCuentaCorriente As New CuentaCorriente
        Dim FechaInicio As String = ""
        Dim FechaFin As String = ""
        If Me.chkPorPeriodo.Checked = True Then
            FechaInicio = HelpClass.FormatoFechaAS400(Me.dtFechaInicio.Text)
            FechaFin = HelpClass.FormatoFechaAS400(Me.dtFechaFin.Text)
        Else
            FechaInicio = CrearFecha("I", ColumnIndex, Integer.Parse(Me.txtAnio.Text.Trim))
            FechaFin = CrearFecha("F", ColumnIndex, Integer.Parse(Me.txtAnio.Text.Trim))
        End If
        oCuentaCorriente.FechaInicio = FechaInicio
        oCuentaCorriente.FechaFin = FechaFin
        oCuentaCorriente.EstadoSap = ""
        oCuentaCorriente.PSCCMPN = Me.UcCompania.CCMPN_CodigoCompania
        If _Evento = 1 Then
            oCuentaCorriente.CCLNT = Me.dtgCuentaCorriente.Item("CCLNT", RowIndex).Value
        End If
        If _Evento = 2 Then
            oCuentaCorriente.CRBCTC = Me.dtgVentas.Item("CRBCTC", RowIndex).Value
            oCuentaCorriente.CCLNT = Me.dtgCuentaCorriente.Item("CCLNT", Me.dtgCuentaCorriente.CurrentCellAddress.Y).Value
        End If
        If UcDivision.Division = "-1" Then
            oCuentaCorriente.PSCDVSN = "%"
        Else
            oCuentaCorriente.PSCDVSN = UcDivision.Division
        End If
        oCuentaCorriente.PSEST_DOC = ""
        oCuentaCorriente.PNCDSGDC = 0
        oCuentaCorriente.CPLNDV = Lista_Planta()
        oCuentaCorriente.CTPODC = "0"
        oCuentaCorriente.NDCCTC = "0"
        oCuentaCorriente.PageNumber = 1
        oCuentaCorriente.PageCount = 0
        oCuentaCorriente.PageSize = 20
        oCuentaCorriente.CRGVTA = IIf(Lista_RegionVenta() = "", "-1", Lista_RegionVenta())
        Return oCuentaCorriente
    End Function
    Private Sub dtgCuentaCorriente_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgCuentaCorriente.CellDoubleClick
        If Me.dtgCuentaCorriente.RowCount = 0 Then Exit Sub
        _Evento = 1
        Try
            If Me.chkPorPeriodo.Checked = True Then
                If e.ColumnIndex = 5 Then
                    Dim ofrmVistaCtaCte As New frmVistaCuentaCorriente
                    ofrmVistaCtaCte.TipoAccion = "A"
                    ofrmVistaCtaCte.TituloConsulta = String.Format("Fecha: {0} - {1}", ConvertFecha(Me.dtFechaInicio.Value), ConvertFecha(Me.dtFechaFin.Value))
                    ofrmVistaCtaCte.MCuentaCorriente = ToCuentaCorrienteEntity(e.ColumnIndex, e.RowIndex)
                    ofrmVistaCtaCte.ShowDialog()
                End If
            Else
                If e.ColumnIndex > 1 And e.ColumnIndex < 14 Then
                    If IsDBNull(Me.dtgCuentaCorriente.Item(e.ColumnIndex, e.RowIndex).Value) Then Exit Sub
                    Dim ofrmVistaCtaCte As New frmVistaCuentaCorriente
                    ofrmVistaCtaCte.TipoAccion = "A"
                    ofrmVistaCtaCte.TituloConsulta = ParametroFecha(e.ColumnIndex, Integer.Parse(Me.txtAnio.Text.Trim))
                    ofrmVistaCtaCte.MCuentaCorriente = ToCuentaCorrienteEntity(e.ColumnIndex, e.RowIndex)
                    ofrmVistaCtaCte.ShowDialog()
                End If
            End If
           
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtgVentas_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgVentas.CellDoubleClick
        If Me.dtgVentas.RowCount = 0 Then Exit Sub
        _Evento = 2
        Try
            If Me.chkPorPeriodo.Checked = True Then
                If e.ColumnIndex = 4 Then
                    Dim ofrmVistaCtaCte As New frmVistaCuentaCorriente
                    ofrmVistaCtaCte.TipoAccion = "B"
                    ofrmVistaCtaCte.TituloConsulta = String.Format("Fecha: {0} - {1}", ConvertFecha(Me.dtFechaInicio.Value), ConvertFecha(Me.dtFechaFin.Value))
                    ofrmVistaCtaCte.MCuentaCorriente = ToCuentaCorrienteEntity(e.ColumnIndex, e.RowIndex)
                    ofrmVistaCtaCte.ShowDialog()
                End If
            Else
                If e.ColumnIndex > 1 And e.ColumnIndex < 14 Then
                    If IsDBNull(Me.dtgVentas.Item(e.ColumnIndex, e.RowIndex).Value) Then Exit Sub
                    Dim ofrmVistaCtaCte As New frmVistaCuentaCorriente
                    ofrmVistaCtaCte.TipoAccion = "B"
                    ofrmVistaCtaCte.TituloConsulta = ParametroFecha(e.ColumnIndex, Integer.Parse(Me.txtAnio.Text.Trim))
                    ofrmVistaCtaCte.MCuentaCorriente = ToCuentaCorrienteEntity(e.ColumnIndex, e.RowIndex)
                    ofrmVistaCtaCte.ShowDialog()
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class


