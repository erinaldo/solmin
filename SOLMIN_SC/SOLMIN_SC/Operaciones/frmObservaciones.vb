Imports SOLMIN_SC.Negocio

Public Class frmObservaciones
    Private oPreEmbarque As clsPreEmbarque
    Private strNRPEMB As String
    Private strNRITEM As String

    Public Sub New(ByVal pdblCliente As Double, ByVal pstrNRPEMB As String, Optional ByVal pstrNRITEM As String = "")
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        oPreEmbarque = New clsPreEmbarque
        strNRPEMB = pstrNRPEMB
        strNRITEM = pstrNRITEM
    End Sub

    Private Function ValidaIngreso() As String
        Dim msg As String = ""
        txtObs.Text = txtObs.Text.Trim
        If (txtObs.Text.Length = 0) Then
            msg = "Debe ingresar la observación."
        End If
        Return msg
    End Function

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Dim msg As String = ""
        msg = ValidaIngreso()
        If (msg <> "") Then
            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Try
            oPreEmbarque.Preembarque = strNRPEMB
            If txtObs.Text <> String.Empty Then
                If strNRITEM <> String.Empty Then
                    oPreEmbarque.Modificar_Observacion(strNRITEM, Format(dtpFecha.Value, "yyyyMMdd"), txtObs.Text)
                Else
                    oPreEmbarque.Actualiza_Observaciones(Format(dtpFecha.Value, "yyyyMMdd"), txtObs.Text)
                End If
            End If
        Catch ex As Exception
        End Try
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub frmObservaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpFecha.Value = Now
        If strNRITEM <> String.Empty Then
            Dim dt As DataTable = oPreEmbarque.Listar_Observacion(strNRPEMB, strNRITEM)
            dtpFecha.Value = HelpUtil.Str8ToDate(dt.Rows(0).ItemArray(0).ToString())
            txtObs.Text = dt.Rows(0).ItemArray(1).ToString().Trim()
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
