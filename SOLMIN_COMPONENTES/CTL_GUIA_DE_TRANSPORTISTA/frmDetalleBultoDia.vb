Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.ENTIDADES

Public Class frmDetalleBultoDia

#Region "Atributos"
  Private objEntidad As GuiaOCManifiestoCarga
#End Region

  Public Sub New(ByVal objCarga As GuiaOCManifiestoCarga)
    ' Llamada necesaria para el Diseñador de Windows Forms.
    InitializeComponent()
    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    objEntidad = New GuiaOCManifiestoCarga
    objEntidad = objCarga
  End Sub

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

    Dim objGuiaOCManifiestoCarga As New GuiaTransportista_BLL
    Dim ODT As DataTable
    Dim objParametro As New Hashtable
    objParametro.Add("CCMPN", objEntidad.CCMPN)
    objParametro.Add("CDVSN", objEntidad.CDVSN)
    objParametro.Add("CPLNDV", objEntidad.CPLNDV)
    objParametro.Add("CCLNT", objEntidad.CCLNT)
    objParametro.Add("FECINI", HelpClass.CtypeDate(Me.dtpFechaInicio.Value))
    objParametro.Add("FECFIN", HelpClass.CtypeDate(Me.dtpFechaFin.Value))
    objParametro.Add("NGRPRV", Me.txtGuiaProveedor.Text.Trim)
    objParametro.Add("CREFFW", Me.txtBulto.Text.Trim)

    ODT = objGuiaOCManifiestoCarga.Lista_Bultos_x_Dia(objParametro)

    dtgDetalleBultos.DataSource = ODT
  End Sub

  Private Sub frmDetalleBultoDia_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Me.txtCliente.Text = objEntidad.TCMPCL
    Me.dtgDetalleBultos.AutoGenerateColumns = False

    'Me.Listar_Medio_Transporte()
  End Sub

  'Private Sub Listar_Medio_Transporte()
  '  Dim objLogica As New MedioTransporte_BLL
  '  Me.cmbMedioEnvio.DataSource = objLogica.Lista_MedioTrasnporteTabla(objEntidad.CCMPN)
  '  Me.cmbMedioEnvio.ValueMember = "CMEDTR"
  '  Me.cmbMedioEnvio.DisplayMember = "TNMMDT"
  '  Me.cmbMedioEnvio.SelectedValue = objEntidad.CTPMDT
  'End Sub

  Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
    If Me.dtgDetalleBultos.RowCount < 0 Then Exit Sub
    Dim lintContador As Int32 = 0
    Dim objEntidadManifiestoCarga As SOLMIN_ST.ENTIDADES.GuiaOCManifiestoCarga
    Dim objGuiaOCManifiestoCarga As New GuiaTransportista_BLL
    Try
      Me.dtgDetalleBultos.EndEdit()
      For lintIndice As Integer = 0 To Me.dtgDetalleBultos.RowCount - 1
        If Me.dtgDetalleBultos.Item("SEL", lintIndice).Value = True Then
          objEntidadManifiestoCarga = New SOLMIN_ST.ENTIDADES.GuiaOCManifiestoCarga
          objEntidadManifiestoCarga.CTRMNC = objEntidad.CTRMNC
          objEntidadManifiestoCarga.NGUIRM = objEntidad.NGUIRM
          objEntidadManifiestoCarga.NRGUCL = objEntidad.NRGUCL
          objEntidadManifiestoCarga.CCLNT = objEntidad.CCLNT
          objEntidadManifiestoCarga.NORCMC = Me.dtgDetalleBultos.Item("NORCML", lintIndice).Value.ToString.Trim
          objEntidadManifiestoCarga.NRITOC = CType(Me.dtgDetalleBultos.Item("NRITOC", lintIndice).Value, Int32)
          objEntidadManifiestoCarga.QCNTIT = CType(Me.dtgDetalleBultos.Item("QSLCNB", lintIndice).Value, Double)
          objEntidadManifiestoCarga.CREFFW = Me.dtgDetalleBultos.Item("CREFFW", lintIndice).Value.ToString.Trim
          objEntidadManifiestoCarga.NSEQIN = Me.dtgDetalleBultos.Item("NSEQIN", lintIndice).Value.ToString.Trim
          objEntidadManifiestoCarga.FULTAC = HelpClass.TodayNumeric
          objEntidadManifiestoCarga.HULTAC = HelpClass.NowNumeric
          objEntidadManifiestoCarga.CULUSA = Me.Tag.ToString.Trim
                    objEntidadManifiestoCarga.NTRMNL = ""
          objEntidadManifiestoCarga.CCMPN = objEntidad.CCMPN

          objGuiaOCManifiestoCarga.Registrar_ManifiestoCarga(objEntidadManifiestoCarga)
          lintContador += 1
          Me.dtgDetalleBultos.Item("SEL", lintIndice).Value = False
        End If
      Next
      If lintContador > 0 Then
        HelpClass.MsgBox("El Proceso culminó Satisfactoriamente", MessageBoxIcon.Information)
        Me.DialogResult = Windows.Forms.DialogResult.OK
      End If
    Catch ex As Exception
      HelpClass.MsgBox(ex.Message, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub btnSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalir.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

  Private Sub dtgDetalleBultos_ColumnHeaderMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dtgDetalleBultos.ColumnHeaderMouseDoubleClick
    If Me.dtgDetalleBultos.Rows.Count = 0 Then Exit Sub
    Select Case e.ColumnIndex
      Case 0
        Dim lintEstado As Boolean = Me.dtgDetalleBultos.Item(0, 0).Value
        For lintCount As Integer = 0 To Me.dtgDetalleBultos.RowCount - 1
          Me.dtgDetalleBultos.Item(0, lintCount).Value = Not lintEstado
          Me.dtgDetalleBultos.EndEdit()
        Next
    End Select
  End Sub
End Class
