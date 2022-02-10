Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.NEGOCIO



Public Class frmVerUnidadesProgramadasXReq
    Private _NUMREQT As Decimal = 0
    Public Property NUMREQT() As Decimal
        Get
            Return _NUMREQT
        End Get
        Set(ByVal value As Decimal)
            If _NUMREQT = value Then
                Return
            End If
            _NUMREQT = value
        End Set
    End Property

    Private _CCMPN As String = ""
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            If _CCMPN = value Then
                Return
            End If
            _CCMPN = value
        End Set
    End Property
    Private Sub frmVerUnidadesProgramadasXReq_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            dgvPreAsignacion.AutoGenerateColumns = False
            Cargar_Unidades_Programadas()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Cargar_Unidades_Programadas()
        dgvPreAsignacion.DataSource = Nothing

        Dim Negocio As New Programacion_Unid_Junta_BLL
        dgvPreAsignacion.AutoGenerateColumns = False
        dgvPreAsignacion.DataSource = Negocio.Lista_Unidades_Programadas(_CCMPN, _NUMREQT, "T")
    End Sub
End Class
