Imports SOLMIN_CTZ.NEGOCIO
Imports SOLMIN_CTZ.Entidades.mantenimientos
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Windows.Forms
Public Class frmAutorizacionLiquidacion
    Private _pMMCAPL_CodApl As String = ""
    Private Sub frmAutorizacionLiquidacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pCargar("ST")
    End Sub
    Public Sub pCargar(ByVal CodApl As String)
        Try
            _pMMCAPL_CodApl = CodApl
            If _pMMCAPL_CodApl <> "" Then
                Uc_CboAplicacion1.pObtenerAplicacion(_pMMCAPL_CodApl)
                ListarOpcion()
                Buscar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Buscar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub Buscar()
        'Try
        Dim obrGeneral As New clsClaseGeneral
        Dim obeGeneral As New ClaseGeneral
        Dim oDtOpcion As DataTable
        If Uc_CboAplicacion1.pPSMMCAPL = "" Then
            MessageBox.Show("Debe de seleccionar una aplicación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf Me.cboOpcion.SelectedValue = 0 Then
            MessageBox.Show("Debe de seleccionar una Opción", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        With obeGeneral
            .MMCAPL = Uc_CboAplicacion1.pPSMMCAPL
            .NCROPC = Me.cboOpcion.SelectedValue
            .MMCUSR = IIf(Uc_CboUsuario1.pPSMMNUSR <> "", Uc_CboUsuario1.pPSMMCUSR, "")
        End With
        oDtOpcion = obrGeneral.Listar_Autorizacion_Usuario(obeGeneral)
        dtgUsuarios.AutoGenerateColumns = False
        If oDtOpcion.Rows.Count >= 0 Then
            Me.dtgUsuarios.DataSource = oDtOpcion
        End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub

    Private Sub Uc_CboAplicacion_InformationChanged() Handles Uc_CboAplicacion1.InformationChanged
        Try
            ListarOpcion()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Uc_CboUsuario1_InformationChanged() Handles Uc_CboUsuario1.InformationChanged
        Try
            Buscar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dtgUsuarios_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgUsuarios.CellContentDoubleClick
        Try
            Uc_CboUsuario1.pObtenerUsuario(Me.dtgUsuarios.CurrentRow.Cells("MMCUSR").Value())
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ListarOpcion()
        Dim obrGeneral As New clsClaseGeneral
        Dim obeGeneral As New ClaseGeneral
        Dim oDtOpcion As DataTable
        If Uc_CboAplicacion1.pPSMMCAPL = "" Then
            MessageBox.Show("Debe de seleccionar una aplicación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        With obeGeneral
            .MMCAPL = Uc_CboAplicacion1.pPSMMCAPL
        End With
        oDtOpcion = obrGeneral.Listar_Autorizacion_Liquidacion_Opcion(obeGeneral)
        'cboOpcion.Items.Clear()
        If oDtOpcion.Rows.Count >= 0 Then
            cboOpcion.DataSource = oDtOpcion
            cboOpcion.ValueMember = "NCROPC"
            cboOpcion.DisplayMember = "MMDOPC"
        End If
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try

            If Uc_CboAplicacion1.pPSMMCAPL = "" Then
                MessageBox.Show("Debe de seleccionar una aplicación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            ElseIf Me.cboOpcion.SelectedValue = 0 Then
                MessageBox.Show("Debe de seleccionar una Opción", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim oucfrmGenAutorizacion As New ucfrmGenAutorizacion()
            oucfrmGenAutorizacion.InicializarFormulario(Me)
            oucfrmGenAutorizacion.TipoAccion = "A" 'Agregar
            oucfrmGenAutorizacion.CodAplicacion = Uc_CboAplicacion1.pPSMMCAPL
            oucfrmGenAutorizacion.CodOpcion = Me.cboOpcion.SelectedValue
            oucfrmGenAutorizacion.CodUsuario = Uc_CboUsuario1.pPSMMCUSR
            oucfrmGenAutorizacion.ShowDialog()

            If oucfrmGenAutorizacion.pDialog = True Then
                Buscar()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Try
            If Me.dtgUsuarios.RowCount = 0 Then Exit Sub
            Dim dtGrid As New DataGridView
            dtGrid = Me.dtgUsuarios
            Dim strlTitulo As String
            Dim strlFiltros As New List(Of String)
            strlTitulo = "Lista de Autorizacion Liquidacion"
            'strlFiltros.Add("Compañia : \n" & cboCompania.CCMPN_Descripcion)
            'strlFiltros.Add("División : \n" & cboDivision.DivisionDescripcion)
            'strlFiltros.Add("Planta : \n" & cboPlanta.DescripcionPlanta)
            Ransa.Utilitario.HelpClass.ExportExcelConTitulos(dtGrid, strlTitulo, strlFiltros)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim obrGeneral As New clsClaseGeneral
            Dim obeGeneral As New ClaseGeneral
            dtgUsuarios.EndEdit()

            If Me.dtgUsuarios.CurrentCellAddress.Y = -1 Then Exit Sub

            Dim Cant As Int32 = 0
            For Each item As DataGridViewRow In dtgUsuarios.Rows
                If item.Cells("CHK").Value = True Then
                    Cant = 1
                    Exit For
                End If
            Next
            If Cant = 0 Then
                MessageBox.Show("No ha seleccionado algún registro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If


            If MessageBox.Show("¿Esta seguro de Eliminar el registro seleccionado?", "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                Dim msg As String = ""
                For Each item As DataGridViewRow In dtgUsuarios.Rows
                    If item.Cells("CHK").Value = True Then
                        With obeGeneral
                            .MMCUSR = Me.dtgUsuarios.CurrentRow.Cells("MMCUSR").Value().ToString.Trim
                            .MMCAPL = Me.dtgUsuarios.CurrentRow.Cells("MMCAPL").Value().ToString.Trim
                            .NCROPC = Me.dtgUsuarios.CurrentRow.Cells("NCROPC").Value()
                            .CODACC = Me.dtgUsuarios.CurrentRow.Cells("CODACC").Value().ToString.Trim
                            '.CHKAUT = "N"
                        End With
                        'msg = msg & obrGeneral.Insertar_Registro_Autorizacion(obeGeneral)
                        msg = msg & obrGeneral.Eliminar_autorizacion_usuario(obeGeneral)

                    End If
                Next

                If msg.Length = 0 Then
                    MessageBox.Show("Eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show(obeGeneral.Observaciones, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Buscar()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    'Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
    '    Try
    '        If Me.dtgUsuarios.CurrentCellAddress.Y = -1 Then Exit Sub
    '        Dim oucfrmGenAutorizacion As New ucfrmGenAutorizacion()
    '        oucfrmGenAutorizacion.InicializarFormulario(Me)
    '        oucfrmGenAutorizacion.TipoAccion = "M" 'Modificar
    '        oucfrmGenAutorizacion.CodAplicacion = Me.dtgUsuarios.CurrentRow.Cells("MMCAPL").Value()
    '        oucfrmGenAutorizacion.CodOpcion = Me.dtgUsuarios.CurrentRow.Cells("NCROPC").Value()
    '        oucfrmGenAutorizacion.CodUsuario = Me.dtgUsuarios.CurrentRow.Cells("MMCUSR").Value()
    '        oucfrmGenAutorizacion.ShowDialog()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    'Private Sub Uc_CboUsuario1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Uc_CboUsuario1.KeyPress
    '    Try
    '        MessageBox.Show("PRSIONASTE", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub
End Class