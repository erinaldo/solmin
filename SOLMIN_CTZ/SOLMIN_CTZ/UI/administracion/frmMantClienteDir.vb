Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports Db2Manager.RansaData.iSeries.DataObjects
Public Class frmMantClienteDir
    Dim blDirecServ As New clsDirecServ
    Dim blPlanta As New clsPlanta
    Dim blCliente As New clsCliente


    Private _PNCDIRSE As Decimal
    Public Property PNCDIRSE() As Decimal
        Get
            Return _PNCDIRSE
        End Get
        Set(ByVal value As Decimal)
            _PNCDIRSE = value
        End Set
    End Property



    Private Sub btnCancelarDet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarDet.Click
        Me.DialogResult = Windows.Forms.DialogResult.No
        Me.Close()
    End Sub



    Private Sub Cargar_Planta()

        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "Cplndv"
        oColumnas.DataPropertyName = "Cplndv"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "Tplnta"
        oColumnas.DataPropertyName = "Tplnta"
        oColumnas.HeaderText = "Planta"
        oListColum.Add(2, oColumnas)

        Dim listPlanta As New List(Of bePlanta)
        listPlanta = blPlanta.Lista_Planta()
        If listPlanta.Count > 0 Then
            cboPlanta.DataSource = listPlanta
        Else
            cboPlanta.DataSource = Nothing
        End If
        cboPlanta.ListColumnas = oListColum
        cboPlanta.Cargas()
        cboPlanta.Limpiar()
        cboPlanta.ValueMember = "Cplndv"
        cboPlanta.DispleyMember = "Tplnta"

     
    End Sub

    Private Sub Cargar_Cliente()

        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CCLNT"
        oColumnas.DataPropertyName = "CCLNT"
        oColumnas.HeaderText = "Código"

        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "DESCAR"
        oColumnas.DataPropertyName = "DESCAR"
        oColumnas.HeaderText = "Cliente"
        oListColum.Add(2, oColumnas)

        Dim listCliente As New List(Of Cliente)
        listCliente = blCliente.Lista_Cliente()
        If listCliente.Count > 0 Then
            cboCliente.DataSource = listCliente
        Else
            cboCliente.DataSource = Nothing
        End If
        cboCliente.ListColumnas = oListColum
        cboCliente.Cargas()
        cboCliente.Limpiar()
        cboCliente.ValueMember = "CCLNT"
        cboCliente.DispleyMember = "DESCAR"

    
    End Sub

    Private Sub Cargar_ZonaFacturacion()

        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CZNFCC"
        oColumnas.DataPropertyName = "CZNFCC"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TZNFCC"
        oColumnas.DataPropertyName = "TZNFCC"
        oColumnas.HeaderText = "Zona Facturación"
        oListColum.Add(2, oColumnas)

        Dim listbeZonaFacturacion As New List(Of beZonaFacturacion)
        listbeZonaFacturacion = blDirecServ.Lista_ZonaFacturacion()
        If listbeZonaFacturacion.Count > 0 Then
            cboZona.DataSource = listbeZonaFacturacion
        Else
            cboZona.DataSource = Nothing
        End If
        cboZona.ListColumnas = oListColum
        cboZona.Cargas()
        cboZona.Limpiar()
        cboZona.ValueMember = "CZNFCC"
        cboZona.DispleyMember = "TZNFCC"

     
    End Sub

    Private Sub frmMantClienteDir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cboZona.Obligatorio = False
            Dim dtTipoCodVar As New DataTable
            dtTipoCodVar = blDirecServ.Lista_TipoCODVAR("SDTCLN")
            cboTipo.ValueMember = "CCMPRN"
            cboTipo.DisplayMember = "TDSDES"
            cboTipo.DataSource = dtTipoCodVar
            If dtTipoCodVar.Rows.Count > 0 Then
                cboTipo.SelectedValue = "G"
            End If
            cboCliente.Focus()
            Cargar_Planta()
            Cargar_Cliente()
            Cargar_ZonaFacturacion()
            cboZona.Obligatorio = False
            cboZona.BackColor = Color.White
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnGrabarDet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabarDet.Click
        Try
            Dim retorno As String = String.Empty
            Dim objbeClienteDireccion As New beClienteDireccion
            If cboTipo.SelectedValue = "P" Then
                If CType(cboCliente.Resultado, SOLMIN_CTZ.Entidades.Cliente) Is Nothing Then
                    MessageBox.Show("Seleccione un Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                Else
                    objbeClienteDireccion.PNCCLNT = CType(cboCliente.Resultado, SOLMIN_CTZ.Entidades.Cliente).CCLNT
                End If

            Else
                objbeClienteDireccion.PNCCLNT = UcCliente.pCodigo
            End If
            objbeClienteDireccion.PSTIPO = cboTipo.SelectedValue.ToString()
            objbeClienteDireccion.PNCDIRSE = PNCDIRSE
            If CType(cboPlanta.Resultado, SOLMIN_CTZ.Entidades.bePlanta) Is Nothing Then
                MessageBox.Show("Seleccione una planta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            If objbeClienteDireccion.PNCCLNT = 0 Then
                MessageBox.Show("Seleccione un Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            If CType(cboZona.Resultado, SOLMIN_CTZ.Entidades.beZonaFacturacion) Is Nothing Then
                objbeClienteDireccion.PNCZNFCC = 0
            Else
                objbeClienteDireccion.PNCZNFCC = CType(cboZona.Resultado, SOLMIN_CTZ.Entidades.beZonaFacturacion).CZNFCC
            End If
            objbeClienteDireccion.PNCPLNDV = CType(cboPlanta.Resultado, SOLMIN_CTZ.Entidades.bePlanta).Cplndv
            Dim strMensaje As String = String.Empty
            strMensaje = blDirecServ.ValidarRegistroDirCliente(objbeClienteDireccion.PNCCLNT, objbeClienteDireccion.PNCDIRSE, objbeClienteDireccion.PNCPLNDV)
            If strMensaje.Trim.Length > 0 Then
                MessageBox.Show(strMensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            retorno = blDirecServ.RegistrarAsignacionClienteDirServicio(objbeClienteDireccion)
            MessageBox.Show(retorno, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DialogResult = Windows.Forms.DialogResult.No
        End Try
    End Sub

    Private Sub cboTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipo.SelectedIndexChanged
        Try
            If cboTipo.SelectedValue = "P" Then
                cboCliente.Visible = True
                UcCliente.Visible = False
            Else
                cboCliente.Visible = False
                UcCliente.Visible = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
