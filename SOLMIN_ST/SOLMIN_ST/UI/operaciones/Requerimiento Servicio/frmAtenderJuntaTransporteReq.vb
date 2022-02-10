Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO.Mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.ENTIDADES
Imports System.Data

Public Class frmAtenderJuntaTransporteReq

    Private _Entidad As Junta_Transporte
    Public Property Entidad() As Junta_Transporte
        Get
            Return _Entidad
        End Get
        Set(ByVal value As Junta_Transporte)
            _Entidad = value
        End Set
    End Property

    Private Sub frmAtenderJuntaTransporteReq_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtNroJunta.Text = _Entidad.NPLNJT & " - " & _Entidad.NCRRPL
        txtFechaJunta.Text = _Entidad.FPLNJT
        txtHoraJunta.Text = _Entidad.HPLNJT
        Buscar()

    End Sub

    Private Sub Adicionar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click

        Try

            Dim ObjFrm As New frmBusquedaRequerimiento
            Dim Entidad As New AtencionRequerimiento
            Dim EntidadJunta As New Programacion_Unidad

            With Entidad
                .CCMPN = _Entidad.CCMPN
                .CDVSN = _Entidad.CDVSN
                .CPLNDV = _Entidad.CPLNDV
            End With

            With EntidadJunta
                .NPLNJT = _Entidad.NPLNJT
                .NCRRPL = _Entidad.NCRRPL
            End With

            ObjFrm.pEntidadRequerimiento = Entidad
            ObjFrm.pEntidadJunta = EntidadJunta

            If ObjFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Buscar()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Sub Buscar()

        Dim ObjBLL As New JuntaRequerimiento_BLL
        Dim ObjBE As New JuntaRequerimiento

        dgvJuntaReq.AutoGenerateColumns = False

        With ObjBE
            .NPLNJT = _Entidad.NPLNJT
            .NCRRPL = _Entidad.NCRRPL
        End With

        dgvJuntaReq.DataSource = ObjBLL.Lista_Requerimientos_X_Junta(ObjBE)

    End Sub

    Private Sub Eliminar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarReq.Click
        Try

            If dgvJuntaReq.CurrentRow IsNot Nothing Then


                Dim Entidad As New Programacion_Unidad
                Dim Negocio As New Programacion_Unid_Junta_BLL
                Dim Resultado As New List(Of Programacion_Unidad)

                dgvUnidades.AutoGenerateColumns = False

                With Entidad
                    .NPLNJT = dgvJuntaReq.CurrentRow.Cells("NPLNJT").Value
                    .NCRRPL = dgvJuntaReq.CurrentRow.Cells("NCRRPL").Value
                    .NUMREQT = dgvJuntaReq.CurrentRow.Cells("NUMREQT").Value
                End With

                Resultado = Negocio.Lista_Unidades_RequerimientosJunta(Entidad, _Entidad.CCMPN)

                If Resultado.Count > 0 Then
                    MessageBox.Show("Existen Unidades Programadas Asociadas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                If MessageBox.Show("¿Desea eliminar el requerimiento?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                    Dim ObjBLL As New JuntaRequerimiento_BLL
                    Dim ObjBE As New JuntaRequerimiento

                    With ObjBE
                        .NPLNJT = dgvJuntaReq.CurrentRow.Cells("NPLNJT").Value
                        .NCRRPL = dgvJuntaReq.CurrentRow.Cells("NCRRPL").Value
                        .NUMREQT = dgvJuntaReq.CurrentRow.Cells("NUMREQT").Value
                        .CULUSA = MainModule.USUARIO
                        .NTRMNL = Environment.MachineName
                    End With

                    If ObjBLL.Eliminar_Requerimientos_X_Junta(ObjBE) = 1 Then
                        Dim objAtencionRequerimiento As New AtencionRequerimiento_BLL
                        Dim objAteReq As New AtencionRequerimiento
                        objAteReq.NUMREQT = dgvJuntaReq.CurrentRow.Cells("NUMREQT").Value
                        objAteReq.CCMPN = _Entidad.CCMPN
                        objAteReq.CUSCRT = MainModule.USUARIO
                        objAteReq.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
                        objAtencionRequerimiento.Verificar_Solicitudes_Actualizar_Requerimiento(objAteReq)

                        Buscar()
                    End If
                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Agregar_Unidad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try

            If dgvJuntaReq.CurrentRow IsNot Nothing Then

                Dim ObjFrm As New frmAgregarUnidProg_JuntaReq
                Dim Entidad As New Programacion_Unidad

                ObjFrm.pCCMPN = _Entidad.CCMPN
                ObjFrm.pCDVSN = _Entidad.CDVSN
                ObjFrm.pCPLNDV = _Entidad.CPLNDV

                With Entidad
                    .NPLNJT = dgvJuntaReq.CurrentRow.Cells("NPLNJT").Value
                    .NCRRPL = dgvJuntaReq.CurrentRow.Cells("NCRRPL").Value
                    .NUMREQT = dgvJuntaReq.CurrentRow.Cells("NUMREQT").Value
                End With

                ObjFrm.pEntidad = Entidad

                If ObjFrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Cargar_Unidades(Nothing, Nothing)
                    dgvJuntaReq.CurrentRow.Cells("QANPRG").Value = CDec(dgvUnidades.Rows.Count)
                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Eliminar_Unidad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarUnid.Click

        Try

            If dgvUnidades.CurrentRow IsNot Nothing Then

                'If dgvUnidades.CurrentRow.Cells("SESASG").Value = "A" Then
                '    MessageBox.Show("La unidad programada se encuentra en estado : Asignado", "No se puede eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                '    Exit Sub
                'End If

                'VERIFICAR ESTADO

                Dim Entidad As New Programacion_Unidad
                Dim Respuesta As New DataTable
                Dim Negocio As New Programacion_Unid_Junta_BLL

                dgvUnidades.AutoGenerateColumns = False

                With Entidad
                    .NPLNJT = dgvUnidades.CurrentRow.Cells("NPLNJT_U").Value
                    .NCRRPL = dgvUnidades.CurrentRow.Cells("NCRRPL_U").Value
                    .NUMREQT = dgvUnidades.CurrentRow.Cells("NUMREQT_U").Value
                    .NCRRPA = dgvUnidades.CurrentRow.Cells("NCRRPA").Value

                End With

                Respuesta = Negocio.Estado_Unidad_RequerimientosJunta(Entidad, _Entidad.CCMPN)

                If Respuesta.Rows(0)("SESASG").ToString = "A" Then
                    MessageBox.Show("La unidad programada se encuentra en estado : Asignado", "No se puede eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                If MessageBox.Show("¿Desea eliminar la unidad?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                    Dim Entidad1 As New Programacion_Unidad
                    Dim Negocio1 As New Programacion_Unid_Junta_BLL

                    dgvUnidades.AutoGenerateColumns = False

                    With Entidad1
                        .NPLNJT = dgvUnidades.CurrentRow.Cells("NPLNJT_U").Value
                        .NCRRPL = dgvUnidades.CurrentRow.Cells("NCRRPL_U").Value
                        .NUMREQT = dgvUnidades.CurrentRow.Cells("NUMREQT_U").Value
                        .NCRRPA = dgvUnidades.CurrentRow.Cells("NCRRPA").Value
                        .CULUSA = MainModule.USUARIO
                        .NTRMNL = Environment.MachineName

                    End With

                    If Negocio1.Eliminar_Unidades_RequerimientosJunta(Entidad) = 1 Then

                        Cargar_Unidades(Nothing, Nothing)

                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Cargar_Unidades(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvJuntaReq.SelectionChanged

        Try

            If dgvJuntaReq.CurrentRow IsNot Nothing Then

                Dim Entidad As New Programacion_Unidad
                Dim Negocio As New Programacion_Unid_Junta_BLL

                dgvUnidades.AutoGenerateColumns = False

                With Entidad
                    .NPLNJT = dgvJuntaReq.CurrentRow.Cells("NPLNJT").Value
                    .NCRRPL = dgvJuntaReq.CurrentRow.Cells("NCRRPL").Value
                    .NUMREQT = dgvJuntaReq.CurrentRow.Cells("NUMREQT").Value
                End With

                dgvUnidades.DataSource = Negocio.Lista_Unidades_RequerimientosJunta(Entidad, _Entidad.CCMPN)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class
