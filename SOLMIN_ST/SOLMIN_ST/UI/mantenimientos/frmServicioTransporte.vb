Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports SOLMIN_ST.NEGOCIO.Mantenimientos
Imports System.Data
Imports System.Collections.Generic
Public Class frmServicioTransporte
    Private gEnum_Mantenimiento As MANTENIMIENTO
    Private gEnum_mantenimientoDet As MANTENIMIENTO
    Private DataViewServicioTransporte As New Data.DataView

    Private Sub frmServicioTransporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.gwdDatos.AutoGenerateColumns = False
        Estado_Controles(False)
        Me.txtBuscar.Text = ""
        Listar()
        Me.Limpiar_Controles()
    End Sub

    Private Sub Listar()
        Dim objServicioTransporte As New ServicioTransporte_BLL
        DataViewServicioTransporte = objServicioTransporte.Busca_ServicioTransporteBuscar().DefaultView
        Me.gwdDatos.DataSource = DataViewServicioTransporte
    End Sub
    Private Sub Buscar()
        Dim objEntidad As New ServicioTransporte
        DataViewServicioTransporte.RowFilter = "TCMTPS like'%" & Me.txtBuscar.Text.ToUpper.Trim & "%'"
        Me.gwdDatos.DataSource = DataViewServicioTransporte
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
            Nuevo_Registro()
            gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
        ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            If txtCodigoServicioTransporte.Text = "" Then
                HelpClass.MsgBox("Seleccionar un registro de la tabla")
            Else
                Modificar_Registro()
                gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
            End If
        End If
        Listar()
    End Sub
    Private Sub Modificar_Registro()

        'Procedimiento para registrar una nueva solicitud de transportista
        Dim objEntidad As New ServicioTransporte
        Dim objServicioTransporte As New ServicioTransporte_BLL
        objEntidad.CTPOSR = Me.txtCodigoServicioTransporte.Text
        objEntidad.TCMTPS = Me.txtDescripCompTipoServTrans.Text
        objEntidad.TABTPS = Me.txtDescripAbrevTipoServicioTrans.Text
        'objEntidad.SESTRG = "A"
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad = objServicioTransporte.Modificar_ServicioTransporte(objEntidad)
        HelpClass.MsgBox("El registro se modifico satisfactoriamente")
        Limpiar_Controles()
        Estado_Controles(False)
        If objEntidad.CTPOSR = "0" Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        End If
        Listar()

    End Sub

    Private Sub Nuevo_Registro()

        'Procedimiento para registrar una nueva solicitud de transportista

        Dim objEntidad As New ServicioTransporte
        Dim objServicioTransporte As New ServicioTransporte_BLL
        objEntidad.CTPOSR = Me.txtCodigoServicioTransporte.Text
        objEntidad.TCMTPS = Me.txtDescripCompTipoServTrans.Text
        objEntidad.TABTPS = Me.txtDescripAbrevTipoServicioTrans.Text
        'objEntidad.SESTRG = "A"
        objEntidad.CUSCRT = MainModule.USUARIO
        objEntidad.FCHCRT = HelpClass.TodayNumeric
        objEntidad.HRACRT = HelpClass.NowNumeric
        objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad = objServicioTransporte.Registrar_ServicioTransporte(objEntidad)
        HelpClass.MsgBox("El registro se guardo satisfactoriamente")
        Limpiar_Controles()
        Estado_Controles(False)
        If objEntidad.CTPOSR = "0" Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        End If
        Listar()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Limpiar_Controles()
        Estado_Controles(True)
        gEnum_Mantenimiento = MANTENIMIENTO.NUEVO
        'Listar()
    End Sub
    Private Sub Estado_Controles(ByVal lbool_Estado As Boolean)

        Me.txtCodigoServicioTransporte.Enabled = lbool_Estado
        Me.txtDescripCompTipoServTrans.Enabled = lbool_Estado
        Me.txtDescripAbrevTipoServicioTrans.Enabled = lbool_Estado
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Limpiar_Controles()
        Estado_Controles(False)
    End Sub 

    Private Sub gwdDatos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellClick

        If e.RowIndex < 0 Or Me.gwdDatos.CurrentCellAddress.Y < 0 Then
            Exit Sub
        End If

        Dim lint_indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
        Me.txtCodigoServicioTransporte.Text = Me.gwdDatos.Item(0, lint_indice).Value.ToString().Trim()
        Me.txtDescripCompTipoServTrans.Text = Me.gwdDatos.Item(1, lint_indice).Value.ToString().Trim()
        Me.txtDescripAbrevTipoServicioTrans.Text = Me.gwdDatos.Item(2, lint_indice).Value.ToString().Trim()
        
        Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
        Me.Estado_Controles(True)

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If txtCodigoServicioTransporte.Text = "" Then
            HelpClass.MsgBox("Seleccione el registro a Eliminar")
        Else
            Cambiar_Estado_ServicioTransporte("*")
            Limpiar_Controles()
            Estado_Controles(False)
        End If
    End Sub

    Private Sub Cambiar_Estado_ServicioTransporte(ByVal lstr_Estado As String)

        Dim objEntidad As New ServicioTransporte
        Dim objServicioTransporte As New ServicioTransporte_BLL
        objEntidad.CTPOSR = Me.txtCodigoServicioTransporte.Text
        'objEntidad.SESTRG = lstr_Estado
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

        objEntidad = objServicioTransporte.Cambiar_Estado_ServicioTransporte(objEntidad)
        HelpClass.MsgBox("El registro se elimino satisfactoriamente")
        Limpiar_Controles()
        Estado_Controles(False)
        If objEntidad.CTPOSR = "0" Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        End If

        Listar()

    End Sub

    Private Sub Eliminar_Transportista()

        If Me.txtCodigoServicioTransporte.Text <> "0" Then

            Dim objEntidad As New ServicioTransporte
            Dim objServicioTransporte As New ServicioTransporte_BLL
            objEntidad.CTPOSR = Me.txtCodigoServicioTransporte.Text
            objEntidad = objServicioTransporte.Cambiar_Estado_ServicioTransporte(objEntidad)
            HelpClass.MsgBox("El registro se Elimino satisfactoriamente!")
            If objEntidad.CTPOSR = "0" Then
                HelpClass.ErrorMsgBox()
                Exit Sub
            End If

            Listar()
            Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO

        End If

    End Sub

    Private Sub Limpiar_Controles()

        Me.txtCodigoServicioTransporte.Text = ""
        Me.txtDescripCompTipoServTrans.Text = ""
        Me.txtDescripAbrevTipoServicioTrans.Text = ""
        
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Buscar()
    End Sub
End Class
