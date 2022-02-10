Imports SOLMIN_TR.DATOS.Entidades
Imports SOLMIN_TR.NEGOCIO
Imports System.Data

Public Class frmSeleccionarPlaneamiento

    Private objEntidadRecursoPlaneamiento As New RecursoPlaneamiento

    Public Sub showForm(ByVal objEntidad As RecursoPlaneamiento, ByVal owner As IWin32Window)

        Me.objEntidadRecursoPlaneamiento = objEntidad
        Dim objPlaneamiento As New PlaneamientoDAO
        Me.dtgDatos.DataSource = objPlaneamiento.Listar_Vehiculos_x_Planeamiento(objEntidad)

        'Dando ancho de columnas
        Me.dtgDatos.Columns(0).HeaderText = "VEHICULO"
        Me.dtgDatos.Columns(0).Width = 60
        Me.dtgDatos.Columns(1).HeaderText = "ACOPLADO"
        Me.dtgDatos.Columns(1).Width = 60
        Me.dtgDatos.Columns(2).HeaderText = "BREVETE"
        Me.dtgDatos.Columns(2).Width = 120
        Me.dtgDatos.Columns(3).HeaderText = "CHOFER"
        Me.dtgDatos.Columns(3).Width = 300

        Me.ShowDialog(owner)

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
  
    Public Function Obtener_Recurso_Planeamiento() As RecursoPlaneamiento
        Return objEntidadRecursoPlaneamiento
    End Function

    Private Sub seleccionar(ByVal indice As Integer)

        With objEntidadRecursoPlaneamiento
            .NPLCTR = Me.dtgDatos.Item(0, indice).Value.ToString
            .NPLCAC = Me.dtgDatos.Item(1, indice).Value.ToString
            .CBRCNT = Me.dtgDatos.Item(2, indice).Value.ToString
            .TNMBCH = Me.dtgDatos.Item(3, indice).Value.ToString
        End With

    End Sub 

    Private Sub dtgDatos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgDatos.DoubleClick

        If Me.dtgDatos.Rows.Count < 0 Then
            Exit Sub
        End If

        If Me.dtgDatos.CurrentCellAddress.Y < 0 Then
            Exit Sub
        End If

        If sender.Rows(dtgDatos.CurrentCellAddress.Y).Cells(0).Value Is DBNull.Value Then
            Exit Sub
        End If

        seleccionar(Me.dtgDatos.CurrentCellAddress.Y)

        Me.Close()
    End Sub

End Class
