Imports SOLMIN_ST.ENTIDADES.Operaciones

Public Class frmOpcionConsumoOperacion

#Region "Atributos"
    Private _olbeCosMnt As List(Of CostoMantenimiento)
    Private _olbeConNeu As List(Of ConsumoNeumatico)
    Private _Flag As String
#End Region

#Region "Propiedades"
    Public WriteOnly Property olbeCosMnt() As List(Of CostoMantenimiento)
        Set(ByVal value As List(Of CostoMantenimiento))
            _olbeCosMnt = value
        End Set
    End Property

    Public WriteOnly Property olbeConNeu() As List(Of ConsumoNeumatico)
        Set(ByVal value As List(Of ConsumoNeumatico))
            _olbeConNeu = value
        End Set
    End Property
    Public WriteOnly Property Flag() As String
        Set(ByVal value As String)
            _Flag = value
        End Set
    End Property

#End Region

#Region "Eventos"
    Private Sub frmOpcionConsumoOperacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Cargar_Grilla()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
#End Region

#Region "Metodos y Funciones"

    Private Sub Cargar_Grilla()
        While dtgConOpe.Rows.Count > 0
            dtgConOpe.Rows.RemoveAt(0)
        End While
        dtgConOpe.AutoGenerateColumns = False

        If _Flag = "N" Then
            dtgConOpe.DataSource = _olbeConNeu
            dtgConOpe.Columns(2).Visible = True
            dtgConOpe.Columns(1).Visible = False
        Else
            dtgConOpe.DataSource = _olbeCosMnt
            dtgConOpe.Columns(1).Visible = True
            dtgConOpe.Columns(2).Visible = False
        End If
    End Sub

#End Region

End Class
