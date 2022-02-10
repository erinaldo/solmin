Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports SOLMIN_ST.NEGOCIO.Mantenimientos
Imports System.Data
Imports System.Collections.Generic
Public Class frmMercaderiaTransportes
    Private gEnum_Mantenimiento As MANTENIMIENTO
    Private gEnum_mantenimientoDet As MANTENIMIENTO
    Private DataViewMercaderiaTransportes As New Data.DataView

    Private Sub frmMercaderiaTransportes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.gwdDatos.AutoGenerateColumns = False

        Me.txtBuscar.Text = ""
        Listar()
        Me.Limpiar_Controles()
        
    End Sub
    Private Sub Listar()
        Dim objMercaderiaTransportes As New MercaderiaTransportes_BLL
        DataViewMercaderiaTransportes = objMercaderiaTransportes.Busca_MercaderiaTransportesBuscar("EZ").DefaultView
        Me.gwdDatos.DataSource = DataViewMercaderiaTransportes
    End Sub
    Private Sub Buscar()
        DataViewMercaderiaTransportes.RowFilter = "TCMRCD like'%" & Me.txtBuscar.Text.ToUpper.Trim & "%'"
        Me.gwdDatos.DataSource = DataViewMercaderiaTransportes
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        If Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO Then
            Nuevo_Registro()
            gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
        ElseIf Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR Then
            If txtCodigoMercaderia.Text = "" Then
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
        Dim objEntidad As New MercaderiaTransportes
        Dim objMercaderiaTransportes As New MercaderiaTransportes_BLL
        objEntidad.CMRCDR = Me.txtCodigoMercaderia.Text
        objEntidad.TCMRCD = Me.txtDescripCompMerc.Text
        objEntidad.TAMRCD = Me.txtDescripAbrevMerc.Text
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CGRMRC = Me.txtCodigoGrupoMerc.Text
        objEntidad = objMercaderiaTransportes.Modificar_MercaderiaTransportes(objEntidad)
        HelpClass.MsgBox("El registro se modifico satisfactoriamente")
        Limpiar_Controles()
        Estado_Controles(False)
        If objEntidad.CMRCDR = "0" Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        End If
        Listar()

    End Sub

    Private Sub Nuevo_Registro()

        'Procedimiento para registrar una nueva solicitud de transportista

        Dim objEntidad As New MercaderiaTransportes
        Dim objMercaderiaTransportes As New MercaderiaTransportes_BLL

        objEntidad.TCMRCD = Me.txtDescripCompMerc.Text
        objEntidad.TAMRCD = Me.txtDescripAbrevMerc.Text
        objEntidad.CUSCRT = MainModule.USUARIO
        objEntidad.FCHCRT = HelpClass.TodayNumeric
        objEntidad.HRACRT = HelpClass.NowNumeric
        objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        objEntidad.CGRMRC = Me.txtCodigoGrupoMerc.Text
        objEntidad = objMercaderiaTransportes.Registrar_MercaderiaTransportes(objEntidad)
        HelpClass.MsgBox("El registro se guardo satisfactoriamente")
        Limpiar_Controles()
        Estado_Controles(False)
        If objEntidad.CMRCDR = "0" Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        End If
        Listar()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Limpiar_Controles()
        Estado_Controles(True)
        gEnum_Mantenimiento = MANTENIMIENTO.NUEVO

    End Sub

    Private Sub Estado_Controles(ByVal lbool_Estado As Boolean)

        Me.txtCodigoMercaderia.Enabled = lbool_Estado
        Me.txtDescripCompMerc.Enabled = lbool_Estado
        Me.txtDescripAbrevMerc.Enabled = lbool_Estado
        Me.txtCodigoGrupoMerc.Enabled = lbool_Estado

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Limpiar_Controles()
        Estado_Controles(False)

    End Sub

    Private Sub btnConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub gwdDatos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellClick

        If e.RowIndex < 0 Or Me.gwdDatos.CurrentCellAddress.Y < 0 Then
            Exit Sub
        End If

        Dim lint_indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
        Me.txtCodigoMercaderia.Text = Me.gwdDatos.Item(0, lint_indice).Value.ToString().Trim()
        Me.txtDescripCompMerc.Text = Me.gwdDatos.Item(1, lint_indice).Value.ToString().Trim()
        Me.txtDescripAbrevMerc.Text = Me.gwdDatos.Item(2, lint_indice).Value.ToString().Trim()
        Me.txtCodigoGrupoMerc.Text = Me.gwdDatos.Item(3, lint_indice).Value.ToString().Trim()

        Me.gEnum_Mantenimiento = MANTENIMIENTO.EDITAR
        Me.Estado_Controles(True)

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If txtCodigoMercaderia.Text = "" Then
            HelpClass.MsgBox("Seleccione el registro a Eliminar")
        Else
            Cambiar_Estado_MercaderiaTransportes("*")
            Limpiar_Controles()
            Estado_Controles(False)
        End If

    End Sub

    Private Sub Cambiar_Estado_MercaderiaTransportes(ByVal lstr_Estado As String)

        Dim objEntidad As New MercaderiaTransportes
        Dim objMercaderiaTransportes As New MercaderiaTransportes_BLL
        objEntidad.CMRCDR = Me.txtCodigoMercaderia.Text
        
        objEntidad.FULTAC = HelpClass.TodayNumeric
        objEntidad.HULTAC = HelpClass.NowNumeric
        objEntidad.CULUSA = MainModule.USUARIO
        objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

        objEntidad = objMercaderiaTransportes.Cambiar_Estado_MercaderiaTransportes(objEntidad)
        HelpClass.MsgBox("El registro se elimino satisfactoriamente")
        Limpiar_Controles()
        Estado_Controles(False)
        If objEntidad.CMRCDR = "0" Then
            HelpClass.ErrorMsgBox()
            Exit Sub
        End If

        Listar()

    End Sub

    Private Sub Eliminar_Transportista()

        If Me.txtCodigoMercaderia.Text <> "0" Then

            Dim objEntidad As New MercaderiaTransportes
            Dim objMercaderiaTransportes As New MercaderiaTransportes_BLL
            objEntidad.CMRCDR = Me.txtCodigoMercaderia.Text
            objEntidad = objMercaderiaTransportes.Cambiar_Estado_MercaderiaTransportes(objEntidad)
            HelpClass.MsgBox("El registro se Elimino satisfactoriamente!")
            If objEntidad.CMRCDR = "0" Then
                HelpClass.ErrorMsgBox()
                Exit Sub
            End If

            Listar()
            Me.gEnum_Mantenimiento = MANTENIMIENTO.NUEVO

        End If

    End Sub

    Private Sub Limpiar_Controles()

        Me.txtCodigoMercaderia.Text = ""
        Me.txtDescripCompMerc.Text = ""
        Me.txtDescripAbrevMerc.Text = ""
        Me.txtCodigoGrupoMerc.Text = ""

    End Sub
      
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Buscar()
    End Sub
End Class

