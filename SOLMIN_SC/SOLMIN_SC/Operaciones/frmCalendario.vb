Imports SOLMIN_SC.Negocio
'Imports SOLMIN_SC.Utilitario
Imports Ransa.Utilitario
Imports SOLMIN_SC.Entidad
Public Class frmCalendario
    Dim CargaAnio As Boolean = False
    Dim Anio As Int32 = 0
    Private Sub frmCalendario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ndanio.Minimum = 1
            ndanio.Maximum = HelpClass.MaxFecha
            ndanio.Value = HelpClass.TodayAnio
            CargaAnio = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ActualizarCargaFormatoCalendario(ByVal Cargar As Boolean)
        UcCalendarioAnual1.ActualizarCalendario(ndanio.Value, Cargar)
    End Sub
    
    Private Sub ndanio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ndanio.ValueChanged
        If (CargaAnio = True) Then
            If (Anio <> ndanio.Value) Then
                ActualizarCargaFormatoCalendario(False)
                Anio = ndanio.Value
            End If
        End If

    End Sub

    'Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    '    ActualizarCargaFormatoCalendario(True)
    'End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        ActualizarCargaFormatoCalendario(True)
    End Sub
End Class
