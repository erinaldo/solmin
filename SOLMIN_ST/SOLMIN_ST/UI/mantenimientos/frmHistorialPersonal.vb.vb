Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports System.Collections.Generic
Imports System.Text
Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.NEGOCIO.operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.MANTENIMIENTO

Public Class frmHistorialPersonal

    Private _objContratistaBE As New Personal_Contratista
    Public Property objContratistaBE() As Personal_Contratista
        Get
            Return _objContratistaBE
        End Get
        Set(ByVal value As Personal_Contratista)
            _objContratistaBE = value
        End Set
    End Property

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmHistorialPersonal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim objPersonalBL As New Personal_Contratista_BL
        Me.dgvHistorial.DataSource = objPersonalBL.Listar_Historial_Rutas_Pasajero(_objContratistaBE)
    End Sub
End Class
