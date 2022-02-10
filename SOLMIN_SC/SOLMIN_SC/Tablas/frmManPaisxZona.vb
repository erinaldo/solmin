Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Negocio
Public Class frmManPaisxZona
    Enum Accion
        Modificar
        Nuevo
    End Enum
    Private _pInfoZonaEmbarque As New ZonaEmbarque_BE
    Private _pInfoAccion As Accion = Accion.Nuevo
    Private oPuerto As New clsPuerto

    Public Property pInfoZonaEmbarque() As ZonaEmbarque_BE
        Get
            Return _pInfoZonaEmbarque
        End Get
        Set(ByVal value As ZonaEmbarque_BE)
            _pInfoZonaEmbarque = value
        End Set
    End Property

    Public Property pInfoAccion() As Accion
        Get
            Return _pInfoAccion
        End Get
        Set(ByVal value As Accion)
            _pInfoAccion = value
        End Set
    End Property

    Private Sub frmManPaisxZona_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            oPuerto.Crea_Lista()
            Dim brPais As New clsPais
            brPais.Crea_Lista()
            Dim odtPais As New DataTable
            odtPais = brPais.Lista_Pais(1)
            Dim dr As DataRow
            dr = odtPais.NewRow
            dr("CPAIS") = "-1"
            dr("TCMPPS") = "::Seleccione::"
            odtPais.Rows.InsertAt(dr, 0)
            Me.cmbPais.DataSource = odtPais
            Me.cmbPais.ValueMember = "CPAIS"
            Me.cmbPais.DisplayMember = "TCMPPS"
            txtZona.Text = _pInfoZonaEmbarque.PSTZNAEM
            Select Case pInfoAccion
                Case Accion.Modificar
                    txtZona.Enabled = False
                    cmbPais.SelectedValue = _pInfoZonaEmbarque.PNCPAIS
                    cmbPais_SelectionChangeCommitted(cmbPais, Nothing)
                    cmbPais.Enabled = False
                    If (_pInfoZonaEmbarque.PSCPRTOE = "") Then
                        cmbPuertoOrg.SelectedValue = "-1"
                    Else
                        cmbPuertoOrg.SelectedValue = _pInfoZonaEmbarque.PSCPRTOE
                    End If
                Case Accion.Nuevo
                    txtZona.Enabled = False
                    cmbPais.Enabled = True
                    cmbPais.SelectedValue = "-1"
                    cmbPais_SelectionChangeCommitted(cmbPais, Nothing)
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            Dim mgsValidacion As String = ""
            Dim obeMensaje As New beMensaje
            mgsValidacion = ValidaIngreso()
            If (mgsValidacion <> "") Then
                MessageBox.Show(mgsValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim obeZonaEmbarque As New ZonaEmbarque_BE
            Dim obrZonaEmbarque As New clsZonasEmbarque
            obeZonaEmbarque = ObtenerZonaPaisEmbarque()
            Select Case pInfoAccion
                Case Accion.Modificar
                    obeMensaje = obrZonaEmbarque.Actualizar_Zona_Pais_Embarque(obeZonaEmbarque)
                    If (obeMensaje.PBEXITO = True) Then
                        DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close()
                    Else
                        MessageBox.Show(obeMensaje.PSMENSAJE, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Case Accion.Nuevo
                    obeMensaje = obrZonaEmbarque.Insertar_Zona_Pais_Embarque(obeZonaEmbarque)
                    If (obeMensaje.PBEXITO = True) Then
                        DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close()
                    Else
                        MessageBox.Show(obeMensaje.PSMENSAJE, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub Filtrar_Puerto_Org(ByVal pdblPais As Double)
        cmbPuertoOrg.DataSource = Nothing
        Dim odtPuerto As New DataTable
        Dim dr As DataRow
        odtPuerto = oPuerto.Filtra_Puerto(pdblPais).Copy
        dr = odtPuerto.NewRow
        dr("CPRTOR") = "-1"
        dr("TCMPR1") = "::Seleccione::"
        odtPuerto.Rows.InsertAt(dr, 0)
        Me.cmbPuertoOrg.DataSource = odtPuerto
        Me.cmbPuertoOrg.DisplayMember = "TCMPR1"
        Me.cmbPuertoOrg.ValueMember = "CPRTOR"
    End Sub
    Private Function ObtenerZonaPaisEmbarque() As ZonaEmbarque_BE
        Dim obeZonaEmbarque As New ZonaEmbarque_BE
        obeZonaEmbarque.PNCCLNT = _pInfoZonaEmbarque.PNCCLNT
        obeZonaEmbarque.PSCZNAEM = _pInfoZonaEmbarque.PSCZNAEM
        obeZonaEmbarque.PNCPAIS = cmbPais.SelectedValue
        If (cmbPuertoOrg.SelectedValue = "-1") Then
            obeZonaEmbarque.PSCPRTOE = ""
        Else
            obeZonaEmbarque.PSCPRTOE = cmbPuertoOrg.SelectedValue.ToString.Trim
        End If
        Return obeZonaEmbarque
    End Function
    Private Function ValidaIngreso() As String
        Dim msg As String = ""
        If (cmbPais.SelectedValue = "-1") Then
            msg = "Debe seleccionar el País."
        End If
        Return msg
    End Function

    Private Sub cmbPais_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPais.SelectionChangeCommitted
        Try
            Filtrar_Puerto_Org(cmbPais.SelectedValue)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
