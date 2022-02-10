Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos

Public Class frmActualizarPesoNetoGuiaTransportes
 
    Public COD_TRANSPORTISTA As Int32 = 0
    Public GUIA_TRANSPORTISTA As Int64 = 0
  
    Public pNoprcn As Int64 = 0

    Public pDialogOK As Boolean = False
    Public pPesoGuiaT As Decimal = 0
    Public pPesoAlmacen As Decimal = 0


    Private Sub frmActualizarPesoNetoGuiaTransportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            lblnroop.Text = pNoprcn
            Listar_Registros()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Sub Listar_Registros()
        lblSinPeso.Text = ""
        Dim Logica As New GuiaTransportista_BLL
        Dim Entidad As New GuiaTransportista
        Dim dt As New DataTable
        Dim totPesoAlmacen As Decimal = 0
        Dim GRSinPeso As Int32 = 0

        dtgGuiaRemisionPesoNeto.DataSource = Nothing
        dtgGuiaRemisionPesoNeto.AutoGenerateColumns = False

        With Entidad
            .CTRMNC = COD_TRANSPORTISTA
            .NGUIRM = GUIA_TRANSPORTISTA
        End With
        Dim pesoGT As Decimal

        dt = Logica.Listar_Peso_Neto_Guia_Transporte_Por_Almacen(Entidad, pesoGT)
        txtPesoNetoGT.Text = Math.Round(pesoGT, 2)
        txtPesoTotalGRAlmacen.Text = "0"
        If dt.Rows.Count > 0 Then

            For Each dr As DataRow In dt.Rows
                totPesoAlmacen = totPesoAlmacen + dr("QPSOBL")
                If dr("QPSOBL") = 0 Then
                    GRSinPeso = GRSinPeso + 1
                End If
            Next
            txtPesoTotalGRAlmacen.Text = Math.Round(totPesoAlmacen, 2)           
            dtgGuiaRemisionPesoNeto.DataSource = dt
            
        End If


        pbimage.Image = My.Resources.text_block1
        If pesoGT = totPesoAlmacen Then
            pbimage.Image = My.Resources.verde
            lbldiferencia.Text = ""
        Else
            pbimage.Image = My.Resources.Rojo
            lbldiferencia.ForeColor = Color.Red

            lbldiferencia.Text = "Diferencia: " & (pesoGT - totPesoAlmacen)
        End If


        If dt.Rows.Count > 0 And GRSinPeso > 0 Then
            lblSinPeso.Text = GRSinPeso & " Guía(s) sin peso."
        End If


        pPesoGuiaT = pesoGT
        pPesoAlmacen = totPesoAlmacen
    End Sub

    Private Sub Cancelar(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub Actualizar(sender As Object, e As EventArgs) Handles btnActualizarPesoNetoGT.Click
        Try

            If (MessageBox.Show("Está seguro de actualizar el peso almacén como peso de la guía de transporte?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No) Then
                Exit Sub
            End If

            If dtgGuiaRemisionPesoNeto.Rows.Count > 0 Then

                Dim Logica As New GuiaTransportista_BLL
                Dim Entidad As New GuiaTransportista
                Dim dt As New DataTable

             
                With Entidad
                    .CTRMNC = dtgGuiaRemisionPesoNeto.CurrentRow.Cells("CTRMNC").Value
                    .NGUIRM = dtgGuiaRemisionPesoNeto.CurrentRow.Cells("NGUIRM").Value
                    .PMRCMC = CDbl(txtPesoTotalGRAlmacen.Text)

                End With



                dt = Logica.Actualizar_Peso_Neto_Guia_Transporte_Por_Almacen(Entidad)

                
                pDialogOK = True
                Listar_Registros()

                MessageBox.Show("Pesos actualizados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
 
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      

    End Sub

 
End Class
