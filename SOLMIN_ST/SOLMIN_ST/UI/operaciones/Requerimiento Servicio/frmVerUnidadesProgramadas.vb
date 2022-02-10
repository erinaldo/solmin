Imports SOLMIN_ST.NEGOCIO.Operaciones

Public Class frmVerUnidadesProgramadas

    Private _NCSOTR As Decimal = 0D
    Public Property NCSOTR() As Decimal
        Get
            Return _NCSOTR
        End Get
        Set(ByVal value As Decimal)
            _NCSOTR = value
        End Set
    End Property

    Private _CCMPN As String = ""
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property

    Private Sub frmVerUnidadesProgramadas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        kgvUnidadProgramada.AutoGenerateColumns = False
        Dim oDetalle_Solicitud_Transporte As New Detalle_Solicitud_Transporte_BLL
        Dim dtJuntaxSolicitud As New DataTable
        kgvUnidadProgramada.DataSource = Nothing
        dtJuntaxSolicitud = oDetalle_Solicitud_Transporte.Listar_Juntas_x_Solicitud(_NCSOTR, _CCMPN)
        kgvUnidadProgramada.DataSource = dtJuntaxSolicitud
    End Sub

End Class