Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO

Public Class frmMantGrupoCliente

    Private _oGrupoCliente As New Cliente
    Public Property oGrupoCliente() As Cliente
        Get
            Return _oGrupoCliente
        End Get
        Set(ByVal value As Cliente)
            _oGrupoCliente = value
        End Set
    End Property

    Private _pCCMPN As String = ""
    Public Property pCCMPN() As String
        Get
            Return _pCCMPN
        End Get
        Set(ByVal value As String)
            _pCCMPN = value
        End Set
    End Property

    Private _CRGVTA As String
    Public Property CRGVTA() As String
        Get
            Return _CRGVTA
        End Get
        Set(ByVal value As String)
            _CRGVTA = value
        End Set
    End Property



    Private Function ValidarIngreso() As String
        Dim msg As String = ""
        txtDescripcionCli1.Text = txtDescripcionCli1.Text.Trim
        If txtDescripcionCli1.Text.Trim().Length = 0 Then
            msg = "* Ingrese Descripción (1)"
        ElseIf ucRegionVenta.Resultado Is Nothing Then
            msg = "Seleccione el Negocio"
        End If
        Return msg
    End Function

    Private Sub tsbGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGrabar.Click
        'Guardar()
        Try
            Dim msgValidacion As String = ValidarIngreso()
            If msgValidacion.Length > 0 Then
                MessageBox.Show(msgValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim oCliente As New Cliente
            Dim obrCliente As New clsCliente
            oCliente.DESCAR = Me.txtDescripcionCli1.Text.Trim.ToUpper
            oCliente.NOMCAR = Me.txtDescripcionCli2.Text.Trim.ToUpper
            oCliente.CCMPN = _pCCMPN


            If ucRegionVenta.Resultado Is Nothing Then
                oCliente.CRGVTA = ""
            Else
                oCliente.CRGVTA = CType(ucRegionVenta.Resultado, RegionVenta).CRGVTA
            End If

            If _oGrupoCliente.NRCTCL = 0 Then
                obrCliente.Agregar_Cliente_Cartera(oCliente)
            Else
                oCliente.NRCTCL = _oGrupoCliente.NRCTCL

                obrCliente.Actualizar_Cliente_Cartera(oCliente)
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    'Private Sub Guardar()
    '    Dim oCliente As New Cliente
    '    Dim obrCliente As New clsCliente
    '    oCliente.DESCAR = Me.txtDescripcionCli1.Text.Trim.ToUpper
    '    oCliente.NOMCAR = Me.txtDescripcionCli2.Text.Trim.ToUpper
    '    oCliente.CCMPN = _pCCMPN
    '    Try
    '        If _oGrupoCliente.NRCTCL = 0 Then
    '            obrCliente.Agregar_Cliente_Cartera(oCliente)
    '        Else
    '            oCliente.NRCTCL = _oGrupoCliente.NRCTCL

    '            obrCliente.Actualizar_Cliente_Cartera(oCliente)
    '        End If
    '        Me.DialogResult = Windows.Forms.DialogResult.OK
    '    Catch ex As Exception
    '        HelpClass.ErrorMsgBox()
    '    End Try
    'End Sub

    Private Sub frmMantGrupoCliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            CargaRegionVenta()
            txtCompania.Text = _pCCMPN
            If _oGrupoCliente.NRCTCL <> 0 Then
                Me.txtCodigoCli.Text = _oGrupoCliente.NRCTCL
                Me.txtDescripcionCli1.Text = _oGrupoCliente.DESCAR
                Me.txtDescripcionCli2.Text = _oGrupoCliente.NOMCAR
                If _oGrupoCliente.CRGVTA = "" Then
                    ucRegionVenta.Valor = Nothing
                Else
                    ucRegionVenta.Valor = _oGrupoCliente.CRGVTA
                End If
                ucRegionVenta.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargaRegionVenta()
        Dim brRegionVenta As New clsRegionVenta
        brRegionVenta.Crea_Lista()
        Dim dtRegioVenta As New DataTable
        dtRegioVenta = brRegionVenta.Lista
        Dim oListRegioVenta As New List(Of RegionVenta)
        Dim obeRegionVenta As RegionVenta

        For Each Item As DataRow In dtRegioVenta.Rows
            If Item("CCMPN") = _pCCMPN Then
                obeRegionVenta = New RegionVenta
                obeRegionVenta.CCMPN = ("" & Item("CCMPN")).ToString.Trim
                obeRegionVenta.CSCDSP = ("" & Item("CSCDSP")).ToString.Trim
                obeRegionVenta.TCRVTA = ("" & Item("TCRVTA")).ToString.Trim
                obeRegionVenta.CRGVTA = ("" & Item("CRGVTA")).ToString.Trim
                oListRegioVenta.Add(obeRegionVenta)
            End If
        Next
     
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CRGVTA"
        oColumnas.DataPropertyName = "CRGVTA"
        oColumnas.HeaderText = "Código"
        oListColum.Add(1, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TCRVTA"
        oColumnas.DataPropertyName = "TCRVTA"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oColumnas.HeaderText = "Descripción"
        oListColum.Add(2, oColumnas)

        ucRegionVenta.DataSource = oListRegioVenta
        ucRegionVenta.ListColumnas = oListColum
        ucRegionVenta.Cargas()
        ucRegionVenta.DispleyMember = "TCRVTA"
        ucRegionVenta.ValueMember = "CRGVTA"

        If _CRGVTA <> "" Then
            ucRegionVenta.Valor = _CRGVTA
        End If

    End Sub

End Class
