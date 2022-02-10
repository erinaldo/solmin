Imports System.Windows.Forms
Public Class ucRASimple_FRASimple

    Private _PNCCLNT As String
    Public Property PNCCLNT() As Object
        Get
            Return _PNCCLNT
        End Get
        Set(ByVal value As Object)
            _PNCCLNT = value
        End Set
    End Property

    Private _PSSTIPPR As String
    Public Property PSSTIPPR() As Object
        Get
            Return _PSSTIPPR
        End Get
        Set(ByVal value As Object)
            _PSSTIPPR = value
        End Set
    End Property

    Private _objResultado As Object
    Public Property objResultado() As Object
        Get
            Return _objResultado
        End Get
        Set(ByVal value As Object)
            _objResultado = value
        End Set
    End Property

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If ValidarFechas() Then
            Buscar()
        End If
    End Sub

    Private Function ValidarFechas() As Boolean
        If Not IsDate(ktbxFFin.Value) Then
            MessageBox.Show("El formato de la fecha fin es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
            Exit Function
        End If
        If Not IsDate(ktbxFIni.Value) Then
            MessageBox.Show("El formato de la fecha inicio es incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
            Exit Function
        End If
        If CDate(ktbxFFin.Value.Date.ToString) < CDate(ktbxFIni.Value.Date.ToString) Then
            MessageBox.Show("Ingreso de rango de fechas incorrecto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
            Exit Function
        End If
        Return True
    End Function

    Private Sub tsbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCancelar.Click
        Try
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tsbAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAceptar.Click
        If kdgvRecepcionAS.CurrentCellAddress.Y = -1 Then
            objResultado = Nothing
            Exit Sub
        End If
        objResultado = Me.kdgvRecepcionAS.CurrentRow.DataBoundItem
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub Buscar()
        Try
            Dim obrIncidencia As New brIncidencias
            Dim Lista As New List(Of beIncidencias)
            Dim obeIncidencias As New beIncidencias

            Dim vBusqueda As String
            Dim vIngreso As String
            vBusqueda = cbxBusquedaPor.SelectedValue
            vIngreso = ktbxGuiaIngreso.Text

            With obeIncidencias
                If PSSTIPPR = "R" Then
                    .PSCSRVC = "1"
                ElseIf PSSTIPPR = "D" Then
                    .PSCSRVC = "2"
                End If
                .PNCCLNT = CInt(PNCCLNT)

                If vBusqueda = "0" Then
                    .PNNGUIRN = 0
                    .PSNGUICL = ""
                    .PNCDPEPL = 0
                Else
                    If vBusqueda = "PNNGUIRN" Then
                        .PNNGUIRN = CInt(vIngreso)
                    Else
                        .PNNGUIRN = 0
                    End If

                    If vBusqueda = "PSNGUICL" Then
                        .PSNGUICL = vIngreso.ToString.Trim
                    Else
                        .PSNGUICL = ""
                    End If

                    If vBusqueda = "PNCDPEPL" Then
                        .PNCDPEPL = CInt(vIngreso)
                    Else
                        .PNCDPEPL = 0
                    End If
                End If

                .PNFRLZSR_INI = CInt(CDate(ktbxFIni.Value.Date).ToString("yyyyMMdd"))
                .PNFRLZSR_FIN = CInt(CDate(ktbxFFin.Value.Date).ToString("yyyyMMdd"))
            End With
            kdgvRecepcionAS.AutoGenerateColumns = False

            Lista = obrIncidencia.olisListarMovimientoAlmacenSimple(obeIncidencias)

            kdgvRecepcionAS.DataSource = Lista
        Catch ex As Exception
            MessageBox.Show("Error al cargar el DataGrid : " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
