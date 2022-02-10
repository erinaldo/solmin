
Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.ENTIDADES.mantenimientos


Public Class frmVerUnidadesProgramadas_Junta


    Private _Entidad As Programacion_Unidad
    Public Property Entidad() As Programacion_Unidad
        Get
            Return _Entidad
        End Get
        Set(ByVal value As Programacion_Unidad)
            _Entidad = value
        End Set
    End Property

    Private _pCCMPN As String = ""
    Public Property pCCMPN() As String
        Get
            Return _pCCMPN
        End Get
        Set(ByVal value As String)
            _pCCMPN = value
        End Set
    End Property

    Private _pNUMREQT As Decimal = 0D
    Public Property pNUMREQT() As Decimal
        Get
            Return _pNUMREQT
        End Get
        Set(ByVal value As Decimal)
            _pNUMREQT = value
        End Set
    End Property

    Private _pBarra As Boolean = True
    Public Property pBarra() As Boolean
        Get
            Return _pBarra
        End Get
        Set(ByVal value As Boolean)
            _pBarra = value
        End Set
    End Property


    Private Sub VerPreAsignacionUnidades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue

            dgvPreAsignacion.AutoGenerateColumns = False
            'Dim Compania As String = oListInicial.PSCCMPN
            'Dim Division As String = oListInicial.PSCDVSN
            'Dim Planta As Integer = oListInicial.PNCPLNDV
            'Carga_MedioTransporte()
            'cboMedioTransporteFiltro.SelectedValue = oListInicial.PNCMEDTR
            'Cargar_Combos()
            'cboLugarorigen.Valor = oListInicial.PNCLCLOR
            'cboLugarDestino.Valor = oListInicial.PNCLCLDS
            'pCargarInformacion(Compania, Division, Planta, oListInicial.PNCCLNT, cboMedioTransporteFiltro.SelectedValue, oListInicial.PNCLCLOR, oListInicial.PNCLCLDS)

            Dim Negocio As New Programacion_Unid_Junta_BLL

            Barra.Visible = _pBarra

            dgvPreAsignacion.DataSource = Negocio.Lista_Unidades_Programadas(_pCCMPN, _pNUMREQT, "T")

            If dgvPreAsignacion.CurrentRow IsNot Nothing Then
                txtTitulo.Text = "Nro Req : " & dgvPreAsignacion.CurrentRow.Cells("NUMREQT").Value
            End If


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


    Private Sub Aceptar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try

            If dgvPreAsignacion.CurrentRow IsNot Nothing Then

                If _pBarra = False Then
                    Exit Sub
                End If

                Dim Datos As New Programacion_Unidad

                With Datos
                    .NPLNJT = dgvPreAsignacion.CurrentRow.Cells("NPLNJT").Value
                    .NCRRPL = dgvPreAsignacion.CurrentRow.Cells("NCRRPL").Value
                    .NUMREQT = dgvPreAsignacion.CurrentRow.Cells("NUMREQT").Value
                    .NCRRPA = dgvPreAsignacion.CurrentRow.Cells("NCRRPA").Value

                    .NRUCTR = dgvPreAsignacion.CurrentRow.Cells("NRUCTR").Value
                    .NPLCUN = dgvPreAsignacion.CurrentRow.Cells("NPLCUN").Value
                    .NPLCAC = dgvPreAsignacion.CurrentRow.Cells("NPLCAC").Value
                    .CBRCNT = dgvPreAsignacion.CurrentRow.Cells("PSCBRCNT").Value
                    .CBRCN2 = dgvPreAsignacion.CurrentRow.Cells("CBRCN2").Value
                End With

                Entidad = Datos

                Me.DialogResult = Windows.Forms.DialogResult.OK

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Cancelar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Try
            Me.DialogResult = Windows.Forms.DialogResult.Cancel

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Asignar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPreAsignacion.CellContentDoubleClick

        Try

            If dgvPreAsignacion.CurrentRow IsNot Nothing Then

                'oInfo.PNNPRASG = lista.PNNPRASG

                Dim Datos As New Programacion_Unidad

                With Datos
                    .NPLNJT = dgvPreAsignacion.CurrentRow.Cells("NPLNJT").Value
                    .NCRRPL = dgvPreAsignacion.CurrentRow.Cells("NCRRPL").Value
                    .NUMREQT = dgvPreAsignacion.CurrentRow.Cells("NUMREQT").Value
                    .NCRRPA = dgvPreAsignacion.CurrentRow.Cells("NCRRPA").Value

                    .NRUCTR = dgvPreAsignacion.CurrentRow.Cells("NRUCTR").Value
                    .NPLCUN = dgvPreAsignacion.CurrentRow.Cells("NPLCUN").Value
                    .NPLCAC = dgvPreAsignacion.CurrentRow.Cells("NPLCAC").Value
                    .CBRCNT = dgvPreAsignacion.CurrentRow.Cells("PSCBRCNT").Value
                    .CBRCN2 = dgvPreAsignacion.CurrentRow.Cells("CBRCN2").Value
                End With

                Entidad = Datos
                Me.DialogResult = Windows.Forms.DialogResult.OK

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
End Class