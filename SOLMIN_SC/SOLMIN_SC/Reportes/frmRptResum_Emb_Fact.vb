Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Negocio
Public Class frmRptResum_Emb_Fact
    Private obeListEstadoEmbarque As New List(Of beEstado)
    Private obeListEstadoServicio As New List(Of beEstado)
    Private obeListEstadoPendiente As New List(Of beEstado)

    Private Sub frmRptResum_Emb_Fact_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim obrEstado As New clsEstado
        kdgvDatos.AutoGenerateColumns = False

        dtpInicio.Value = Date.Now.AddDays(-30)

        Me.cmbCliente.pAccesoPorUsuario = True
        Me.cmbCliente.pRequerido = True
        Me.cmbCliente.pUsuario = HelpUtil.UserName

        'obeListEstadoEmbarque = obrEstado.Estado_Consulta_Embarque
        'obeListEstadoServicio = obrEstado.Estado_Consulta_Servicio
        'obeListEstadoPendiente = obrEstado.Estado_Consulta_Pendiente_Servicio

        cmbEstadoEmbarque.DataSource = obeListEstadoEmbarque
        cmbEstadoEmbarque.DisplayMember = "PSDESCRIPCION"
        cmbEstadoEmbarque.ValueMember = "PSCODIGO"
        cmbEstadoEmbarque.SelectedValue = "T"

        cmbEstadoServicio.DataSource = obeListEstadoServicio
        cmbEstadoServicio.DisplayMember = "PSDESCRIPCION"
        cmbEstadoServicio.ValueMember = "PSCODIGO"
        cmbEstadoServicio.SelectedValue = "T"

        cmbEstadoPendiente.DataSource = obeListEstadoPendiente
        cmbEstadoPendiente.DisplayMember = "PSDESCRIPCION"
        cmbEstadoPendiente.ValueMember = "PSCODIGO"
        cmbEstadoPendiente.SelectedValue = "T"

        cmbEstadoServicio.Visible = False
        lblcmbEstadoServicio.Visible = False
        cmbEstadoPendiente.Visible = False
        lblcmbEstadoPendiente.Visible = False
    End Sub

    Private Sub tsExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsExportar.Click

    End Sub

    Private Sub cmbEstadoEmbarque_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEstadoEmbarque.SelectionChangeCommitted
        If (cmbEstadoEmbarque.SelectedValue = "C") Then
            cmbEstadoServicio.Visible = True
            cmbEstadoServicio.SelectedValue = "T"
            lblcmbEstadoServicio.Visible = True
        Else
            cmbEstadoServicio.Visible = False
            lblcmbEstadoServicio.Visible = False
        End If

        cmbEstadoPendiente.Visible = False
        lblcmbEstadoPendiente.Visible = False
    End Sub

    Private Sub cmbEstadoServicio_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEstadoServicio.SelectionChangeCommitted
        If (cmbEstadoServicio.SelectedValue = "N") Then
            cmbEstadoPendiente.Visible = True
            cmbEstadoPendiente.SelectedValue = "T"
            lblcmbEstadoPendiente.Visible = True
        Else
            cmbEstadoPendiente.Visible = False
            lblcmbEstadoPendiente.Visible = False
        End If
    End Sub

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    kdgvDatos.DataSource = Nothing
    If (cmbCliente.pCodigo = 0) Then
      MessageBox.Show("Debe seleccionar el cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
      Exit Sub
    End If
    Dim PSFLAG_SEG As String = ""
    Dim PSFLAG_SERV As String = ""
    Dim PSFLAG_SECUENCIA As String = ""
    Dim obrRepGeneral As New clsRepGenerales
    Dim obeServicioConsulta As New beServicioConsulta
    obeServicioConsulta.PSSCCLNT = IIf(cmbCliente.pCodigo = 0, "", cmbCliente.pCodigo)
    obeServicioConsulta.PNFECINI = Convert.ToDateTime(dtpInicio.Value).ToString("yyyyMMdd")
    obeServicioConsulta.PNFECFIN = Convert.ToDateTime(dtpFin.Value).ToString("yyyyMMdd")
    Select Case cmbEstadoEmbarque.SelectedValue.ToString.Trim
      Case "T"
        PSFLAG_SEG = ""
      Case "A"
        PSFLAG_SEG = "A"
      Case "C"
        PSFLAG_SEG = "C"
    End Select
    If (cmbEstadoServicio.Visible = True) Then
      Select Case cmbEstadoServicio.SelectedValue.ToString.Trim
        Case "T"
          PSFLAG_SERV = ""
        Case "N"
          PSFLAG_SERV = "N"
          If (cmbEstadoPendiente.Visible = True) Then
            Select Case cmbEstadoPendiente.SelectedValue.ToString.Trim
              Case "T"
                PSFLAG_SECUENCIA = ""
              Case "PR"
                PSFLAG_SECUENCIA = "PR"
              Case "RE"
                PSFLAG_SECUENCIA = "RE"
            End Select
          End If
        Case "S"
          PSFLAG_SERV = "S"
      End Select
    End If
    obeServicioConsulta.PSSESTRG_SEG = PSFLAG_SEG
    obeServicioConsulta.PSFLGFAC_SERV = PSFLAG_SERV
    obeServicioConsulta.PSFLAG_SECUENCIA = PSFLAG_SECUENCIA
    Dim odt As New DataTable
    odt = obrRepGeneral.Lista_Datos_Resumen_Mensual_Emb_Facturados(obeServicioConsulta)
    kdgvDatos.DataSource = odt
  End Sub
End Class
