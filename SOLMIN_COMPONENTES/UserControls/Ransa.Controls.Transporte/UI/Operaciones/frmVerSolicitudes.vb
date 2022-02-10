Imports System.Windows.Forms

Public Class frmVerSolicitudes
    Private _Entidad As Operaciones.Solicitud_Transporte
    Public Property Entidad() As Operaciones.Solicitud_Transporte
        Get
            Return _Entidad
        End Get
        Set(ByVal value As Operaciones.Solicitud_Transporte)
            _Entidad = value
        End Set
    End Property


    Private Sub frmVerSolicitudes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            dgvDatosSolicitud.AutoGenerateColumns = False
            Cargar_Solicitudes()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Cargar_Solicitudes()
        dgvDatosSolicitud.DataSource = Nothing
        Dim objSolicitudTransporte As New RequerimientoServicio_BLL
        dgvDatosSolicitud.DataSource = objSolicitudTransporte.Listar_Solicitud_Transporte_Estado_Requerimiento(_Entidad)
    End Sub
End Class
