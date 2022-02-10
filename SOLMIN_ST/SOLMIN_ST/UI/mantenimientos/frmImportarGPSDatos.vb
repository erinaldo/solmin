Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.NEGOCIO
Public Class frmImportarGPSDatos
    Public oInfobeSeguimientoGPS As New SeguimientoGPS
    Public oListActualGPS As New List(Of SeguimientoGPS)
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            gwdDatosGPS.EndEdit()
            If (gwdDatosGPS.Rows.Count <= 0) Then Exit Sub
            Dim obeSeguimiento As SeguimientoGPS
            Dim oblSeguimientoGPS As New SeguimientoGPS_BLL
            Dim oListbeSeguimiento As New List(Of SeguimientoGPS)
            Dim retorno As Int32 = 0
            For Each odrv As DataGridViewRow In gwdDatosGPS.Rows
                If (odrv.Cells("CHKIMPORT").Value = True) Then
                    obeSeguimiento = New SeguimientoGPS
                    obeSeguimiento = odrv.DataBoundItem
                    obeSeguimiento.trim()
                    obeSeguimiento.NCSOTR = oInfobeSeguimientoGPS.NCSOTR
                    obeSeguimiento.NCRRSR = oInfobeSeguimientoGPS.NCRRSR
                    obeSeguimiento.NPLCTR = oInfobeSeguimientoGPS.NPLCTR
                    obeSeguimiento.CULUSA = MainModule.USUARIO
                    obeSeguimiento.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina

                    oListbeSeguimiento.Add(obeSeguimiento)
                End If
            Next
            retorno = oblSeguimientoGPS.IMPORTAR_SEGUIMIENTO_GPS(oListbeSeguimiento)
            If (retorno = 0) Then
                MessageBox.Show("No se pudo realizar la operación", "Importar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim oblSeguimientoGPS As New SeguimientoGPS_BLL
        Try
            oInfobeSeguimientoGPS.FECGPS = dtFecha.Value.ToString("yyyyMMdd")
            gwdDatosGPS.DataSource = oblSeguimientoGPS.Lista_GPS_RZTR11A(oInfobeSeguimientoGPS, oListActualGPS)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmImportarGPSDatos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gwdDatosGPS.AutoGenerateColumns = False
        txtUnidad.ReadOnly = True
        txtUnidad.Text = oInfobeSeguimientoGPS.NPLCTR
        HabilitarColumnas()
    End Sub
    Public Sub HabilitarColumnas()
        Dim numCol As Int32 = 0
        numCol = gwdDatosGPS.Rows.Count - 1
        gwdDatosGPS.ReadOnly = False
        For index As Integer = 0 To numCol
            If (gwdDatosGPS.Columns(index).Name = "CHKIMPORT") Then
                gwdDatosGPS.Columns(index).ReadOnly = False
            Else
                gwdDatosGPS.Columns(index).ReadOnly = True
            End If
        Next
    End Sub
End Class
