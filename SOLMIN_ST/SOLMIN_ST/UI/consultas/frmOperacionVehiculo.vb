Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Mantenimientos

Public Class frmOperacionVehiculo
    Private _Parametros As List(Of String)
    Public Property Parametros() As List(Of String)
        Get
            Return _Parametros
        End Get
        Set(ByVal value As List(Of String))
            _Parametros = value
        End Set
    End Property

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmOperacionVehiculo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim objLogica As New Reportes_BLL
        gwdDatos.DataSource = objLogica.Reporte_Rendimiento_Vehicular_Operacion(Parametros)
    End Sub
End Class
