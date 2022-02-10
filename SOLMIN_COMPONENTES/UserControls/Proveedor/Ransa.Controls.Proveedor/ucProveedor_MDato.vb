Imports Ransa.TypeDef.Proveedor
Imports Ransa.DAO.Proveedor
Public Class ucProveedor_MDato
    Public pUsuario As String = ""
    Public Event CerrarForm()
    Public oInfoProveedor As New beProveedor     

#Region "Atributos"

    Private IsNuevo As Boolean = False

#End Region

#Region "Variables"

    Private oEntidad As beProveedor
    Private _IsNuevo As Boolean = False

    Private _dialogResult As Boolean = False

    Public ReadOnly Property myDialogResult() As Boolean
        Get
            Return _dialogResult
        End Get
    End Property



#End Region

    Public Sub ShowForm(ByVal esNuevo As Boolean)

        Try

            IsNuevo = esNuevo
            Dim obrProveedor As New cProveedor
            Dim odtPais As New DataTable
            odtPais = obrProveedor.ListarPais()
            Dim dr As DataRow
            dr = odtPais.NewRow
            dr("CPAIS") = -1
            dr("TCMPPS") = ":Seleccione:"
            odtPais.Rows.InsertAt(dr, 0)

            dbPNCPAIS.DataSource = odtPais
            dbPNCPAIS.DisplayMember = "TCMPPS"
            dbPNCPAIS.ValueMember = "CPAIS"

            oEntidad = TryCast(Me.Tag, beProveedor)
            SetDataSource(oEntidad)
            If IsNuevo Then
                SetEnabled(True)
            Else
                SetEnabled(False)
                txtPNNRUCPR.Enabled = False
            End If

        Catch ex As Exception

        End Try


    End Sub
    Private Sub txtPNNRUCPR_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPNNRUCPR.KeyPress
        Try
            If InStr("1234567890", Chr(AscW(e.KeyChar))) = 0 Then
                e.Handled = True
            End If
            Select Case AscW(e.KeyChar)
                Case 8, 13
                    e.Handled = False
            End Select
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtPNNDSDMP_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPNNDSDMP.KeyPress
        Try
            If InStr("1234567890", Chr(AscW(e.KeyChar))) = 0 Then
                e.Handled = True
            End If
            Select Case AscW(e.KeyChar)
                Case 8, 13
                    e.Handled = False
            End Select
        Catch ex As Exception
        End Try
    End Sub



    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        Try


            Dim obrProveedor As New cProveedor
            Dim strValidar As String = ""
            Dim retorno As Int32 = 0
            Dim strText As String
            strText = "No se pudo realizar la operación."
            strValidar = ValidarIngreso()
            If (strValidar.Trim <> "") Then
                MessageBox.Show(strValidar, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            GetDataSource()
            If IsNuevo Then
                Dim obeproveedor As New beProveedor
                obeproveedor.PSNRUCPRSTR = txtPNNRUCPR.Text.Trim
                obeproveedor = obrProveedor.ObtenerProveedor(obeproveedor)

                If (obeproveedor.PNCPRVCL <> -1) Then
                    Dim msgstr As String = ""
                    msgstr = msgstr + " Ya existe el  proveedor " & obeproveedor.PSTPRVCL & " con RUC : " & txtPNNRUCPR.Text.Trim & Chr(13)
                    'msgstr = msgstr + "¿ Desesea crear un nuevo proveedor con el mismo RUC ?"

                    MessageBox.Show(msgstr, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                    'If (MessageBox.Show(msgstr, "Confirmar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                    '    oInfoProveedor = InsertarProveedor()
                    '    If (oInfoProveedor.PNCPRVCL <> -1) Then
                    '        strText = "El registro se insertó satisfactoriamente."
                    '        MessageBox.Show(strText, "Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    '        _dialogResult = True
                    '        RaiseEvent CerrarForm()
                    '    Else
                    '        MessageBox.Show(strText, "Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    '    End If
                    'Else
                    '    Exit Sub
                    'End If
                Else
                    oInfoProveedor = InsertarProveedor()
                    If (oInfoProveedor.PNCPRVCL <> -1) Then
                        strText = "El registro se insertó satisfactoriamente."
                        MessageBox.Show(strText, "Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        _dialogResult = True
                        RaiseEvent CerrarForm()
                    Else
                        MessageBox.Show(strText, "Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If


                End If
            Else
                oEntidad.PSCULUSA = pUsuario
                oEntidad.PNFULTAC = Now.Date.ToString("yyyyMMdd")
                oEntidad.PNHULTAC = Now.Date.ToString("hhmmss")
                oEntidad.PNUPDATE_IDENT += 1


            

                retorno = obrProveedor.ActualizarProveedorGeneral(oEntidad)
                If (retorno = 1) Then
                    strText = "El registro se actualizó satisfactoriamente"
                    MessageBox.Show(strText, "Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    _dialogResult = True
                    RaiseEvent CerrarForm()
                Else
                    MessageBox.Show(strText, "Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
                End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function InsertarProveedor() As beProveedor
        Dim obrProveedor As New cProveedor
        Dim oProveedor As New beProveedor
        oProveedor = obrProveedor.RegistrarProveedorGeneral(oEntidad)
        oProveedor.PNNRUCPR = Val(txtPNNRUCPR.Text.Trim)
        oProveedor.PSTPRVCL = txtPSTPRVCL.Text.Trim
        Return oProveedor
    End Function
    Private Function ValidarIngreso() As String
        Dim str As String = ""
        If (txtPSTPRVCL.Text.Trim = "") Then
            str = " Debe ingresar la descripción del Proveedor" & Chr(13)
        End If


        If IsNuevo Then

            If dbPNCPAIS.SelectedValue Is Nothing Then
                str = str + " Seleccione país correcto. " & Chr(13)
            Else

                If (dbPNCPAIS.SelectedValue = "-1") Then
                    str = str + " Seleccione país " & Chr(13)
                End If

                If dbPNCPAIS.SelectedValue.ToString.Trim = "589" Then

                    If txtPNNRUCPR.Text.Trim.Length < 11 Then
                        str = str + " Ingrese RUC - 11 dígitos." & Chr(13)
                    End If
                End If

            End If

        Else


            If dbPNCPAIS.SelectedValue Is Nothing Then
                str = str + " Seleccione país correcto. " & Chr(13)
            Else
                If (dbPNCPAIS.SelectedValue = "-1") Then
                    str = str + " Seleccione país " & Chr(13)
                End If
            End If

        End If

     


        'If (dbPNCPAIS.SelectedValue = "-1") Then
        '    str = str + " Seleccione pais " & Chr(13)
        'End If

        'If dbPNCPAIS.SelectedValue.ToString.Trim = "589" Then

        '    If txtPNNRUCPR.Text.Trim.Length < 11 Then
        '        str = str + " Ingrese RUC - 11 dígitos." & Chr(13)
        '    End If
        'End If
        '589

        Return str
    End Function
    Private Sub SetDataSource(ByVal obj As beProveedor)
        If Not IsNuevo Then
            With obj
                dbPNCPAIS.SelectedValue = .PNCPAIS
                If (dbPNCPAIS.Text.Trim = "") Then
                    dbPNCPAIS.SelectedIndex = 0
                End If
                txtPNCPRVCL.Text = .PNCPRVCL
                txtPNNDSDMP.Text = .PNNDSDMP
                txtPNNRUCPR.Text = .PNNRUCPR
                txtPSTDRPRC.Text = .PSTDRPRC
                txtPSTEMAI2.Text = .PSTEMAI2
                txtPSTEMAI3.Text = .PSTEMAI3
                txtPSTLFNO1.Text = .PSTLFNO1
                txtPSTLFNO2.Text = .PSTLFNO2
                txtPSTNACPR.Text = .PSTNACPR
                txtPSTNROFX.Text = .PSTNROFX
                txtPSTPRCL1.Text = .PSTPRCL1
                txtPSTPRSCN.Text = .PSTPRSCN
                txtPSTPRVCL.Text = .PSTPRVCL
            End With
        End If
    End Sub

    Private Sub GetDataSource()
        If (IsNuevo = True) Then
            oEntidad = New beProveedor
        End If
        With oEntidad
            .PNCPAIS = Val(dbPNCPAIS.SelectedValue)
            .PNNDSDMP = IIf(String.IsNullOrEmpty(txtPNNDSDMP.Text.Trim), 0, Val(txtPNNDSDMP.Text.Trim))
            .PNNRUCPR = Val(txtPNNRUCPR.Text.Trim)
            .PSTDRPRC = txtPSTDRPRC.Text.Trim
            .PSTEMAI2 = txtPSTEMAI2.Text.Trim
            .PSTEMAI3 = txtPSTEMAI3.Text.Trim
            .PSTLFNO1 = txtPSTLFNO1.Text.Trim
            .PSTLFNO2 = txtPSTLFNO2.Text.Trim
            .PSTNACPR = txtPSTNACPR.Text.Trim
            .PSTNROFX = txtPSTNROFX.Text.Trim
            .PSTPRCL1 = txtPSTPRCL1.Text.Trim
            .PSTPRSCN = txtPSTPRSCN.Text.Trim
            .PSTPRVCL = txtPSTPRVCL.Text.Trim

        End With
    End Sub

    Private Sub SetEnabled(ByVal bValor As Boolean)
        txtPNCPRVCL.Enabled = False
        txtPNNDSDMP.Enabled = True
        txtPNNRUCPR.Enabled = True
        txtPSTDRPRC.Enabled = True
        txtPSTEMAI2.Enabled = True
        txtPSTEMAI3.Enabled = True
        txtPSTLFNO1.Enabled = True
        txtPSTLFNO2.Enabled = True
        txtPSTNACPR.Enabled = True
        txtPSTNROFX.Enabled = True
        txtPSTPRCL1.Enabled = True
        txtPSTPRSCN.Enabled = True
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        RaiseEvent CerrarForm()
    End Sub



End Class
