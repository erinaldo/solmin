Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports Ransa.Utilitario
Public Class frmUnidadesAsignacion


    Private _ccmpn As String = ""
    Public Property ccmpn() As String
        Get
            Return _ccmpn
        End Get
        Set(ByVal value As String)
            _ccmpn = value
        End Set
    End Property
    Private _cdvsn As String = ""
    Public Property cdvsn() As String
        Get
            Return _cdvsn
        End Get
        Set(ByVal value As String)
            _cdvsn = value
        End Set
    End Property
    Private _TIPO_RECURSO As String = ""
    Public Property TIPO_RECURSO() As String
        Get
            Return _TIPO_RECURSO
        End Get
        Set(ByVal value As String)
            _TIPO_RECURSO = value
        End Set
    End Property
    Private _PLACA As String = ""
    Public Property PLACA() As String
        Get
            Return _PLACA
        End Get
        Set(ByVal value As String)
            _PLACA = value
        End Set
    End Property

    Private Sub frmUnidadesAsignacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gwdUnidAlquiler.AutoGenerateColumns = False
            Dim oSolicitudTransporte As New Solicitud_Transporte_BLL
            Dim dtPlacaAsignado As New DataTable
            Dim ofrmUnidAsignacion As New frmUnidadesAsignacion
            dtPlacaAsignado = oSolicitudTransporte.Lista_Placa_Asignacion(_ccmpn, _cdvsn, _TIPO_RECURSO, _PLACA)
            gwdUnidAlquiler.DataSource = dtPlacaAsignado
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
