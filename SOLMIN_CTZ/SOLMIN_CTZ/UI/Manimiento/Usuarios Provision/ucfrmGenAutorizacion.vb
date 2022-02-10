Imports SOLMIN_CTZ.NEGOCIO
Imports SOLMIN_CTZ.Entidades.mantenimientos
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Windows.Forms
Public Class ucfrmGenAutorizacion
    Private _oFrmPadre As Form
    Private _CodAplicacion As String = ""
    Private _CodOpcion As String = ""
    Private _CodUsuario As String = ""
    Private _TipoAccion As String = ""
    Public pDialog As Boolean = False
    Public Property CodAplicacion() As String
        Get
            Return _CodAplicacion
        End Get
        Set(ByVal value As String)
            _CodAplicacion = value
        End Set
    End Property
    Public Property CodOpcion() As String
        Get
            Return _CodOpcion
        End Get
        Set(ByVal value As String)
            _CodOpcion = value
        End Set
    End Property
    Public Property CodUsuario() As String
        Get
            Return _CodUsuario
        End Get
        Set(ByVal value As String)
            _CodUsuario = value
        End Set
    End Property
    Public Property TipoAccion() As String
        Get
            Return _TipoAccion
        End Get
        Set(ByVal value As String)
            _TipoAccion = value
        End Set
    End Property

    Private isCheckOpcion As Boolean = False
    Private Sub ucfrmGenAutorizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.CenterToScreen()
        Uc_CboUsuario1.pClear()
        If CodUsuario <> "" Then
            Uc_CboUsuario1.pObtenerUsuario(CodUsuario)
        End If
        'If TipoAccion = "A" Then
        '    Uc_CboUsuario1.Enabled = True
        'Else
        '    Uc_CboUsuario1.Enabled = False
        'End If
        Buscar()
    End Sub
    'Private Sub Uc_CboUsuario1_InformationChanged() Handles Uc_CboUsuario1.InformationChanged
    '    Try
    '        Buscar()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub
    Private Sub Buscar()
        Try
            Dim obrGeneral As New clsClaseGeneral
            Dim obeGeneral As New ClaseGeneral
            Dim oDtOpcion As DataTable
            With obeGeneral
                .MMCAPL = CodAplicacion
                .NCROPC = CodOpcion
                '.MMCUSR = Uc_CboUsuario1.pPSMMCUSR
            End With
            'oDtOpcion = obrGeneral.Listar_Registro_Autorizacion(obeGeneral)
            oDtOpcion = obrGeneral.Listar_Opciones_Autorizacion(obeGeneral)
            If oDtOpcion.Rows.Count >= 0 Then
                Me.dtgUsuarios.DataSource = oDtOpcion
            End If
            'ddd()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub InicializarFormulario(oFrmPadre As Form)
        _oFrmPadre = oFrmPadre
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            Dim obrGeneral As New clsClaseGeneral
            Dim obeGeneral As New ClaseGeneral

            If Uc_CboUsuario1.pPSMMCUSR = "" Then
                MessageBox.Show("Debe de seleccionar un Usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim cant As Integer = 0
            For Each item As DataGridViewRow In dtgUsuarios.Rows
                If item.Cells("CHKAUTO").Value = True Then
                    cant = 1
                    Exit For
                End If
            Next
            If cant = 0 Then
                MessageBox.Show("No ha seleccionado alguna opción.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If


            'Dim intCont As Integer
            Dim msg As String = ""
            For Each item As DataGridViewRow In dtgUsuarios.Rows

                If item.Cells("CHKAUTO").Value = True Then

                    With obeGeneral
                        .MMCUSR = Uc_CboUsuario1.pPSMMCUSR
                        .MMCAPL = CodAplicacion
                        .NCROPC = CodOpcion
                        .CODACC = item.Cells("CODACC").Value.ToString.Trim
                        '.CHKAUT = IIf((CHKAUTO = True), "S", "N")
                    End With

                    msg = obrGeneral.Asignar_autorizacion_usuario(obeGeneral)

                End If
            Next
            'For intCont = 0 To dtgUsuarios.RowCount - 1
            'Dim ChkAuto As Boolean
            'If IsDBNull(dtgUsuarios.Rows(intCont).Cells("CHKAUTO").Value) Then
            '    ChkAuto = False
            '    dtgUsuarios.Rows(intCont).Cells("CHKAUTO").Value = False
            'Else
            '    ChkAuto = dtgUsuarios.Rows(intCont).Cells("CHKAUTO").Value
            'End If

            'CHKAUTO

            'With obeGeneral
            '    .MMCUSR = Uc_CboUsuario1.pPSMMCUSR
            '    .MMCAPL = CodAplicacion
            '    .NCROPC = CodOpcion
            '    .CODACC = dtgUsuarios.Rows(intCont).Cells("CODACC").Value
            '    .CHKAUT = IIf((ChkAuto = True), "S", "N")
            'End With

            'msg = obrGeneral.Asignar_autorizacion_usuario(obeGeneral)
            'If Not obrGeneral.Asignar_autorizacion_usuario(obeGeneral) = True Then
            '    MessageBox.Show(obeGeneral.Observaciones, "Autorización Liquidación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If
            'Next
            pDialog = True
            If msg.Length > 0 Then
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Permisos asignados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Me.Close()

            'MessageBox.Show("Registrado", "Autorización Liquidación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Dim oFrmPadre As New frmAutorizacionLiquidacion()
            'oFrmPadre = _oFrmPadre
            'oFrmPadre.Buscar()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub dtgUsuarios_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dtgUsuarios.CurrentCellDirtyStateChanged
        If dtgUsuarios.IsCurrentCellDirty Then
            dtgUsuarios.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub
    'Private Sub dtgUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgUsuarios.CellContentClick
    '    Dim isCellChecked As Boolean = CBool(dtgUsuarios.Rows(e.RowIndex).Cells(0).Value)
    'End Sub

    Private Sub btncheck_Click(sender As Object, e As EventArgs) Handles btncheck.Click
        dtgUsuarios.EndEdit()
        isCheckOpcion = Not isCheckOpcion
        If isCheckOpcion = True Then
            btncheck.Image = My.Resources.btnMarcarItems
        Else
            btncheck.Image = My.Resources.btnNoMarcarItems
        End If
        Poner_Check_Todo_Opcion(isCheckOpcion)
    End Sub
    Private Sub Poner_Check_Todo_Opcion(ByVal blnEstado As Boolean)
        Dim intCont As Integer
        For intCont = 0 To dtgUsuarios.RowCount - 1
            dtgUsuarios.Rows(intCont).Cells("CHKAUTO").Value = blnEstado
        Next
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Buscar()
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub


End Class