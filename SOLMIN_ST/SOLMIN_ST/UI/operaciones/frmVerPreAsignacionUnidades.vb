Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.ENTIDADES.mantenimientos

Public Class frmVerPreAsignacionUnidades

  Public oListInicial As New PreAsignacionUnidades_BE

  Private oInfo As New PreAsignacionUnidades_BE
  Public ReadOnly Property pSeleccion() As PreAsignacionUnidades_BE
    Get
      Return oInfo
    End Get
  End Property

  Private Sub VerPreAsignacionUnidades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try

      dgvPreAsignacion.AutoGenerateColumns = False

      Dim Compania As String = oListInicial.PSCCMPN
      Dim Division As String = oListInicial.PSCDVSN
      Dim Planta As Integer = oListInicial.PNCPLNDV
      UcCliente_TxtF011.pCargar(oListInicial.PNCCLNT)

      Carga_MedioTransporte()
      cboMedioTransporteFiltro.SelectedValue = oListInicial.PNCMEDTR
      Cargar_Combos()
      cboLugarorigen.Valor = oListInicial.PNCLCLOR
      cboLugarDestino.Valor = oListInicial.PNCLCLDS

      pCargarInformacion(Compania, Division, Planta, oListInicial.PNCCLNT, cboMedioTransporteFiltro.SelectedValue, oListInicial.PNCLCLOR, oListInicial.PNCLCLDS)
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

  Sub pCargarInformacion(ByVal Compania As String, ByVal Division As String, ByVal Planta As Integer, ByVal Cliente As Integer, ByVal Medio As Integer, ByVal Origen As Integer, ByVal Destino As Integer)

    Dim oPreAsignacionUnidades_BE As New PreAsignacionUnidades_BE
    Dim oPreAsignacionUnidades_BLL As New PreAsignacionUnidades_BLL
    Dim lstPreAsignacionUnidades_BE As New List(Of PreAsignacionUnidades_BE)

    oPreAsignacionUnidades_BE.PSCCMPN = Compania
    oPreAsignacionUnidades_BE.PSCDVSN = Division
    oPreAsignacionUnidades_BE.PNCPLNDV = Planta

    oPreAsignacionUnidades_BE.PNCCLNT = Cliente
    oPreAsignacionUnidades_BE.PNCMEDTR = Medio
    oPreAsignacionUnidades_BE.PNCLCLOR = Origen
    oPreAsignacionUnidades_BE.PNCLCLDS = Destino

    lstPreAsignacionUnidades_BE = oPreAsignacionUnidades_BLL.Ver_PreAsignacionUnidades(oPreAsignacionUnidades_BE)
    dgvPreAsignacion.DataSource = lstPreAsignacionUnidades_BE

  End Sub

  Private Sub dgvPreAsignacion_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPreAsignacion.CellDoubleClick
    Try

      Dim index As Int32 = dgvPreAsignacion.CurrentCellAddress.Y
      Dim lista As New PreAsignacionUnidades_BE
      lista = dgvPreAsignacion.Rows(index).DataBoundItem

      oInfo.PNNPRASG = lista.PNNPRASG
      oInfo.PNNRUCTR = lista.PNNRUCTR
      oInfo.PSNPLCUN = lista.PSNPLCUN
      oInfo.PSNPLCAC = lista.PSNPLCAC
      oInfo.PSCBRCNT = lista.PSCBRCNT
      oInfo.PSCBRCN2 = lista.PSCBRCN2
      Me.DialogResult = Windows.Forms.DialogResult.OK
      Me.Close()

    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

  Private Sub Carga_MedioTransporte()
    Dim obj_Logica_MedioTransporte As New NEGOCIO.MedioTransporte_BLL
    Dim objTabla As DataTable = obj_Logica_MedioTransporte.Lista_MedioTrasnporteTabla(oListInicial.PSCCMPN)
    Me.cboMedioTransporteFiltro.DataSource = objTabla.Copy
    Me.cboMedioTransporteFiltro.ValueMember = "CMEDTR"
    Me.cboMedioTransporteFiltro.DisplayMember = "TNMMDT"
  End Sub

  Private Sub Cargar_Combos()
    Dim objDt As List(Of LocalidadRuta)
    Dim obj_Logica_Localidad As New Localidad_BLL
    objDt = obj_Logica_Localidad.Listar_Localidades(oListInicial.PSCCMPN)

    Dim oListColum As New Hashtable
    Dim oColumnas As New DataGridViewTextBoxColumn
    oColumnas.Name = "CLCLD"
    oColumnas.DataPropertyName = "CLCLD"
    oColumnas.HeaderText = "Código "
    oListColum.Add(1, oColumnas)

    oColumnas = New DataGridViewTextBoxColumn
    oColumnas.Name = "TCMLCL"
    oColumnas.DataPropertyName = "TCMLCL"
    oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    oColumnas.HeaderText = "Descripción "
    oListColum.Add(2, oColumnas)

    Me.cboLugarorigen.DataSource = objDt
    Me.cboLugarorigen.ListColumnas = oListColum
    Me.cboLugarorigen.Cargas()
    Me.cboLugarorigen.DispleyMember = "TCMLCL"
    Me.cboLugarorigen.ValueMember = "CLCLD"

    Dim oListColum2 As New Hashtable
    oColumnas = New DataGridViewTextBoxColumn
    oColumnas.Name = "CLCLD"
    oColumnas.DataPropertyName = "CLCLD"
    oColumnas.HeaderText = "Código "
    oListColum2.Add(1, oColumnas)

    oColumnas = New DataGridViewTextBoxColumn
    oColumnas.Name = "TCMLCL"
    oColumnas.DataPropertyName = "TCMLCL"
    oColumnas.HeaderText = "Descripción "
    oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    oListColum2.Add(2, oColumnas)

    Me.cboLugarDestino.DataSource = objDt
    Me.cboLugarDestino.ListColumnas = oListColum2
    Me.cboLugarDestino.Cargas()
    Me.cboLugarDestino.DispleyMember = "TCMLCL"
    Me.cboLugarDestino.ValueMember = "CLCLD"

  End Sub

  Private Sub Aceptar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
    Try

      If dgvPreAsignacion.CurrentRow IsNot Nothing Then

        Dim index As Int32 = dgvPreAsignacion.CurrentCellAddress.Y
        Dim lista As New PreAsignacionUnidades_BE
        lista = dgvPreAsignacion.Rows(index).DataBoundItem

        oInfo.PNNPRASG = lista.PNNPRASG
        oInfo.PNNRUCTR = lista.PNNRUCTR
        oInfo.PSNPLCUN = lista.PSNPLCUN
        oInfo.PSNPLCAC = lista.PSNPLCAC
        oInfo.PSCBRCNT = lista.PSCBRCNT
        oInfo.PSCBRCN2 = lista.PSCBRCN2
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub Cancelar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
    Try
      Me.DialogResult = Windows.Forms.DialogResult.Cancel
      Me.Close()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

End Class
