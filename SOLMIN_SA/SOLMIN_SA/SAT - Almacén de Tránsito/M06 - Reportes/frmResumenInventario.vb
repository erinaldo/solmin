Imports Ransa.TypeDef
Imports Ransa.NEGO
Imports Ransa.Utilitario

Public Class frmResumenInventario

#Region "Propiedades"
    Private _PSCCMPN As String
    Public Property PSCCMPN() As String
        Get
            Return _PSCCMPN
        End Get
        Set(ByVal value As String)
            _PSCCMPN = value
        End Set
    End Property

    Private _PSCDVSN As String
    Public Property PSCDVSN() As String
        Get
            Return _PSCDVSN
        End Get
        Set(ByVal value As String)
            _PSCDVSN = value
        End Set
    End Property


    Private _PSCPLNDV As String
    Public Property PSCPLNDV() As String
        Get
            Return _PSCPLNDV
        End Get
        Set(ByVal value As String)
            _PSCPLNDV = value
        End Set
    End Property

    Public WriteOnly Property PSSSNCRG() As String
        Set(ByVal value As String)
            Me.txtSentidoCarga.Tag = value
            Me.txtSentidoCarga.Text = value
            txtSentidoCarga_Validating(Nothing, Nothing)
        End Set
    End Property


    Public WriteOnly Property PNCCLNT() As Decimal
        Set(ByVal value As Decimal)
            Me.txtClient.pUsuario = objSeguridadBN.pUsuario
            Me.txtClient.pCargar(value)
        End Set
    End Property





    Private _PNFECFIN As Date

    Public WriteOnly Property PNFECFIN() As Date
        Set(ByVal value As Date)
            Me.dteFechaInventario.Value = value
        End Set
    End Property

#End Region


    Private Sub frmResumenInventario_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.txtClient.pUsuario = objSeguridadBN.pUsuario
        cargarComboPlanta()
    End Sub

    Private Sub bsaSentidoCargaListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaSentidoCargaListar.Click
        Call mfblnBuscar_SentidoCarga(txtSentidoCarga.Tag, txtSentidoCarga.Text)
    End Sub

    Private Sub txtSentidoCarga_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSentidoCarga.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call mfblnBuscar_SentidoCarga(txtSentidoCarga.Tag, txtSentidoCarga.Text)
        End If
    End Sub

    Private Sub txtSentidoCarga_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSentidoCarga.TextChanged
        txtSentidoCarga.Tag = ""
    End Sub

    Private Sub txtSentidoCarga_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSentidoCarga.Validating
        If txtSentidoCarga.Text = "" Then
            txtSentidoCarga.Tag = ""
        Else
            If txtSentidoCarga.Text <> "" And "" & txtSentidoCarga.Tag = "" Then
                Call mfblnBuscar_SentidoCarga(txtSentidoCarga.Tag, txtSentidoCarga.Text)
                If txtSentidoCarga.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub cargarComboPlanta()
        Dim obrPlanta As New brGeneral
        Dim obePlanta As New beGeneral
        With obePlanta
            .PSCCMPN = _PSCCMPN
            .PSCDVSN = _PSCDVSN
            .PSUSUARIO = objSeguridadBN.pUsuario
        End With

        Dim olbePlanta As New List(Of beGeneral)
        Try

            'olbePlanta = obrPlanta.Lista_Planta_X_Usuario(obePlanta)
            Me.cboPlanta.DisplayMember = "PSTPLNTA"
            Me.cboPlanta.ValueMember = "PNCPLNDV"
            Me.cboPlanta.DataSource = obrPlanta.Lista_Planta_X_Usuario(obePlanta)
            For i As Integer = 0 To cboPlanta.Items.Count - 1
                If cboPlanta.Items.Item(i).Value = _PSCPLNDV Then
                    cboPlanta.SetItemChecked(i, True)
                End If
            Next

        Catch ex As Exception
        End Try

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            Dim obrBulto As New brBulto
            Dim obeBulto As New beBulto
            With obeBulto
                .PNCCLNT = Me.txtClient.pCodigo
                .PSCCMPN = _PSCCMPN
                .PSCDVSN = _PSCDVSN
                For i As Integer = 0 To cboPlanta.CheckedItems.Count - 1
                    .PSPLANTA += cboPlanta.CheckedItems(i).Value & ","
                Next
                If .PSPLANTA.Trim.Length > 0 Then
                    .PSPLANTA = .PSPLANTA.Trim.Substring(0, .PSPLANTA.Trim.Length - 1)
                End If
                .PSSSNCRG = IIf(Me.txtSentidoCarga.Tag.ToString.Trim.Equals(""), "0", Me.txtSentidoCarga.Tag)
                .PSUSUARIO = objSeguridadBN.pUsuario
                .PNFECFIN = IIf(Me.dteFechaInventario.Checked, HelpClass.CDate_a_Numero8Digitos(dteFechaInventario.Value), 0)
            End With

            Dim strlCabecera As New List(Of String)
            strlCabecera.Add(_lblCliente.Text + " " + IIf(Me.txtClient.pCodigo.ToString.Equals("0"), "Todos", Me.txtClient.pRazonSocial))
            strlCabecera.Add("Planta :" + " " + IIf(Me.cboPlanta.Text.ToString.Trim.Equals(""), "Todos", Me.cboPlanta.Text))
            strlCabecera.Add("Sentido de Carga :" + " " + IIf(Me.txtSentidoCarga.Text.Trim.Equals(""), "Todos", Me.txtSentidoCarga.Text))
            If Me.dteFechaInventario.Checked = True Then
                strlCabecera.Add("Fecha Inventario :" + " " + dteFechaInventario.Value)
            End If
            HelpClass.ExportExcelInventario(strlCabecera, obrBulto.ListarBultoInventarioAll(obeBulto))
        Catch
        End Try
    End Sub
End Class
