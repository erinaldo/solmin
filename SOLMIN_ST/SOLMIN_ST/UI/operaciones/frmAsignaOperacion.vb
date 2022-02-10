
Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports Ransa.Utilitario
Imports System.Data
Imports System.Text
Imports SOLMIN_ST.ENTIDADES

Public Class frmAsignaOperacion

#Region "Propiedades"

    Private _OrdenReemplazo As String
    Public Property OrdenReemplazo() As String
        Get
            Return _OrdenReemplazo
        End Get
        Set(ByVal value As String)
            _OrdenReemplazo = value
        End Set
    End Property

    Private _CCMPN As String
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property

    Private _CDVSN As String
    Public Property CDVSN() As String
        Get
            Return _CDVSN
        End Get
        Set(ByVal value As String)
            _CDVSN = value
        End Set
    End Property


    Private _CCLINT As String = ""
    Public Property CCLINT() As String
        Get
            Return _CCLINT
        End Get
        Set(ByVal value As String)
            _CCLINT = value
        End Set
    End Property

#End Region

    Private Sub frmAsignaOperacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            txtClienteFiltro.pCargar(CCLINT)
            ckbFechaOperacion.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
 
    End Sub

    Private Sub ckbFechaOperacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbFechaOperacion.CheckedChanged
        Try
            If ckbFechaOperacion.Checked = True Then
                dtpFechaInicio.Enabled = True
                dtpFechaFin.Enabled = True
                txtOperacion.Text = ""
                txtOperacion.Enabled = False
            Else
                dtpFechaInicio.Enabled = False
                dtpFechaFin.Enabled = False
                txtOperacion.Enabled = True
                txtOperacion.Text = ""
                txtOperacion.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnconsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconsultar.Click
        Try
            cargarGrilla()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub gwdOperacion_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdOperacion.CellDoubleClick
        Try
            If gwdOperacion.RowCount > 0 Then
                OrdenReemplazo = Me.gwdOperacion.Item("NOPRCN", Me.gwdOperacion.CurrentCellAddress.Y).Value
                DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            If gwdOperacion.RowCount > 0 Then
                OrdenReemplazo = Me.gwdOperacion.Item("NOPRCN", Me.gwdOperacion.CurrentCellAddress.Y).Value
                DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtOperacion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOperacion.KeyPress
        Try
            If e.KeyChar = "." Then
                e.Handled = True
                Exit Sub
            End If
            If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#Region "Metodos"
    Private Sub cargarGrilla()
        Dim obj As New Solicitud_Transporte_BLL
        Dim objEntidad As New Solicitud_Transporte
        With objEntidad
            .CCMPN = CCMPN
            .CDVSN = CDVSN
            .CCLNT = txtClienteFiltro.pCodigo
            If ckbFechaOperacion.Checked Then
                .NOPRCN = 0
                .FE_INI = HelpClass.CFecha_a_Numero8Digitos(dtpFechaInicio.Value)
                .FE_FIN = HelpClass.CFecha_a_Numero8Digitos(dtpFechaFin.Value)
            Else
                If txtOperacion.Text.Trim.Equals("") Then
                    MessageBox.Show("Ingrese Operación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                Else
                    .NOPRCN = CDec(txtOperacion.Text)
                End If
                .FE_INI = 0
                .FE_FIN = 0
            End If
        End With
        gwdOperacion.AutoGenerateColumns = False
        gwdOperacion.DataSource = obj.LISTAR_OPERACIONES_ASIGNACION(objEntidad)
    End Sub
#End Region

End Class
