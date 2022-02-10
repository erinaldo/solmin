
Public Class Control_Visor_Reporte
    Public Sub Ocultar_Imagen()
        Me.pbxBuscar.Visible = False
        Me.pbxBuscar.Enabled = False
    End Sub

    Public Sub Muestra_Imagen()
        Application.DoEvents()
        Me.pbxBuscar.Enabled = True
        Me.pbxBuscar.Update()
        Application.DoEvents()
        Me.pbxBuscar.Visible = True
        Application.DoEvents()
    End Sub
End Class
