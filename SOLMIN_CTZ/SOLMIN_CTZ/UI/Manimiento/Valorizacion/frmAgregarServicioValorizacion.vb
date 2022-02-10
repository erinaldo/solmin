Imports Db2Manager.RansaData.iSeries.DataObjects

Imports Ransa.Utilitario
Imports System.Windows.Forms
Imports SOLMIN_CTZ.NEGOCIO
Imports SOLMIN_CTZ.Entidades

Public Class frmAgregarServicioValorizacion

    Public pCCMPN As String = ""
    Public pCDVSN As String = ""
    Public pCPLNDV As Double = 0
    Public pCCLNT As Double = 0
    Public pNROVLR As Double = 0
    'Public pPrimerRegistro As Boolean = False
    Public pNRTFSV As Double = 0
 


    Private Sub frmAgregarServicioValorizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Cargar_Division()


            UcPLanta_Cmb011_SelectionChangeCommitted(Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Sub Cargar_Division()
        UcDivision.Compania = pCCMPN
        UcDivision.Usuario = ConfigurationWizard.UserName
        UcDivision.DivisionDefault = "T"
        UcDivision.Division = "T"
        UcDivision.pActualizar()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub UcDivision_Seleccionar(obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles UcDivision.Seleccionar
        Try
            UcPLanta_Cmb011.CodigoCompania = UcDivision.Compania
            UcPLanta_Cmb011.CodigoDivision = UcDivision.Division
            UcPLanta_Cmb011.Usuario = ConfigurationWizard.UserName
            If UcDivision.Division = "T" Then
                UcPLanta_Cmb011.PlantaDefault = 42
                UcPLanta_Cmb011.Planta = 42
            End If
            UcPLanta_Cmb011.pActualizar()

            ' UcPLanta_Cmb011_SelectionChangeCommitted(Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    

    End Sub

    'Private Sub btnVerServicios_Click(sender As Object, e As EventArgs) Handles btnVerServicios.Click
    '    Try
    '        Dim pfrmSeleccionarServicio As New frmSeleccionarServicio

    '        pfrmSeleccionarServicio.pCCMPN = pCCMPN
    '        pfrmSeleccionarServicio.pCDVSN = UcDivision.Division
    '        pfrmSeleccionarServicio.pCPLNDV = UcPLanta_Cmb011.Planta
    '        pfrmSeleccionarServicio.pCCLNT = pCCLNT

    '        If pfrmSeleccionarServicio.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '            pNRTFSV = pfrmSeleccionarServicio.pNRTFSV
    '            txtServicio.Text = pfrmSeleccionarServicio.pDESTAR
    '            txtMoneda.Text = pfrmSeleccionarServicio.pTSGNMN
    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try

            If cboServicio.SelectedValue = 0 Then
                MessageBox.Show("Seleccione servicio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim Negocio As New clsMantValorizacion
            Dim Entidad As New beMantValorizacion
            Dim mensaje As String = ""

            With Entidad
                .CCMPN = pCCMPN
                .CCLNT = pCCLNT
                .NROVLR = pNROVLR
                .NOPRCN = 0
                .NRTFSV = cboServicio.SelectedValue
                .CRROP = 0
                .FATNSR = CDec(Me.dtpFechaServicio.Value.ToString("yyyyMMdd"))
                .CDVSN = UcDivision.Division
                .CPLNDV = UcPLanta_Cmb011.Planta

            End With

            mensaje = Negocio.Generar_Operacion_Rango_Valorizacion(Entidad)

            If mensaje.Trim.Length > 0 Then
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Servicio Asignado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub UcPLanta_Cmb011_SelectionChangeCommitted(obePlanta As Ransa.Controls.UbicacionPlanta.Planta.bePlanta) Handles UcPLanta_Cmb011.SelectionChangeCommitted
 

        Try

            Dim Negocio As New clsMantValorizacion
            Dim Entidad As New beMantValorizacion
            With Entidad
                .CCMPN = pCCMPN
                .CDVSN = UcDivision.Division
                .CPLNDV = UcPLanta_Cmb011.Planta
                .CCLNT = pCCLNT
            End With
            Dim dt As New DataTable
            dt = Negocio.Listar_Servicios_Valorizacion(Entidad)

            Dim dr As DataRow
            dr = dt.NewRow
            dr("NRTFSV") = 0
            dr("DESTAR") = "::Seleccione::"
            dt.Rows.Add(dr)

            cboServicio.DataSource = dt
            cboServicio.DisplayMember = "DESTAR"
            cboServicio.ValueMember = "NRTFSV"
            cboServicio.SelectedValue = 0

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

      

    End Sub
End Class


