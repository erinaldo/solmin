Imports Ransa.NEGO
Imports Ransa.TYPEDEF
Imports Ransa.Utilitario

Public Class frmInterfase
#Region "Atributos"
    Private intCCLNT As Integer = 0
    Private strCREFFW As String = ""
    Private strCCMPN As String = ""
    Private strCDVSN As String = ""
    Private dblCPLNDV As Double = 0
#End Region
#Region " Propiedades "
    Public WriteOnly Property pCodigoCliente_CCLNT() As Int32
        Set(ByVal value As Int32)
            intCCLNT = value
        End Set
    End Property

    Public WriteOnly Property pCodigoCompania_CCMPN() As String
        Set(ByVal value As String)
            strCCMPN = value
        End Set
    End Property

    Public WriteOnly Property pCodigoDivision_CDVSN() As String
        Set(ByVal value As String)
            strCDVSN = value
        End Set
    End Property

    Public WriteOnly Property pCodigoPlanta_CPLNDV() As String
        Set(ByVal value As String)
            dblCPLNDV = value
        End Set
    End Property


    Public ReadOnly Property pCodigoRecepcion_CREFFW() As String
        Get
            pCodigoRecepcion_CREFFW = strCREFFW
        End Get
    End Property
#End Region
#Region " Procedimientos y Funciones "
    'Private Sub pIniciarProceso()
    '    If txtNroDocumentoES.Text = "" Then
    '        MessageBox.Show("Debe ingresar un Nro. Documento E/S...", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Exit Sub
    '    End If

    '    Dim obrBulto As New brBulto
    '    Dim obeBulto As New beBulto
    '    With obeBulto
    '        .PSDCENSA = txtNroDocumentoES.Text
    '        .PNCCLNT = intCCLNT
    '    End With
    '    Dim oDt As New DataTable
    '    oDt = obrBulto.fdtListaBultoParaTransferir(obeBulto, obeBulto.PSERROR)
    '    If obeBulto.PSERROR.Trim.Length > 0 Then
    '        If obeBulto.PSERROR.Trim = "-1" Then
    '            HelpClass.ErrorMsgBox()
    '            Exit Sub
    '        Else
    '            MessageBox.Show(obeBulto.PSERROR, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            txtNroDocumentoES.Text = ""
    '            Exit Sub
    '        End If
    '    End If
    '    If oDt.Rows.Count = 0 Then
    '        MessageBox.Show("Nro. Documento No existe", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Exit Sub
    '    End If
    '    If oDt.Rows.Count > 1 Then
    '        Dim ofrm As New frmListaInterfazSAP
    '        ofrm.DataSource = oDt
    '        If ofrm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '            obeBulto.PSDCENSA = ofrm.oDr.Item("DCENSA")
    '            obeBulto.PSNUMDES = ofrm.oDr.Item("NUMDES")
    '        Else
    '            Exit Sub
    '        End If
    '    Else
    '        obeBulto.PSDCENSA = oDt.Rows(0).Item("DCENSA")
    '        obeBulto.PSNUMDES = oDt.Rows(0).Item("NUMDES")
    '    End If
    '    With obeBulto
    '        .PSCCMPN = strCCMPN
    '        .PSCDVSN = strCDVSN
    '        .PNCPLNDV = dblCPLNDV
    '        .PNCCLNT = intCCLNT
    '        .PSUSUARIO = objSeguridadBN.pUsuario
    '    End With
    '    If obrBulto.fintRealizarTransferenciaBulto(obeBulto) = 1 Then
    '        strCREFFW = obeBulto.PSCREFFW
    '        Me.Close()
    '        'Else
    '        '    HelpClass.ErrorMsgBox()
    '    End If
    '    'fintRealizarTransferenciaBulto
    '    'If mfblnRealizar_TransferenciaBulto(intCCLNT, txtNroDocumentoES.Text, strCREFFW, strCCMPN, strCDVSN, dblCPLNDV) Then Me.Close()

    'End Sub
#End Region
#Region " Métodos "
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        'Call pIniciarProceso()
        Try
            If txtNroDocumentoES.Text.Trim = "" Then
                MessageBox.Show("Debe ingresar un Nro. Documento E/S...", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim obrBulto As New brBulto
            Dim obeBulto As New beBulto
            With obeBulto
                .PSDCENSA = txtNroDocumentoES.Text.Trim
                .PNCCLNT = intCCLNT
            End With
            Dim oDt As New DataTable
            oDt = obrBulto.fdtListaBultoParaTransferir(obeBulto, obeBulto.PSERROR)
            If obeBulto.PSERROR.Trim.Length > 0 Then
                'If obeBulto.PSERROR.Trim = "-1" Then
                '    HelpClass.ErrorMsgBox()
                '    Exit Sub
                'Else
                MessageBox.Show(obeBulto.PSERROR, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtNroDocumentoES.Text = ""
                Exit Sub
                'End If
            End If
            If oDt.Rows.Count = 0 Then
                MessageBox.Show("Nro. Documento No existe", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If oDt.Rows.Count > 1 Then
                Dim ofrm As New frmListaInterfazSAP
                ofrm.DataSource = oDt
                If ofrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    obeBulto.PSDCENSA = ofrm.oDr.Item("DCENSA")
                    obeBulto.PSNUMDES = ofrm.oDr.Item("NUMDES")
                Else
                    Exit Sub
                End If
            Else
                obeBulto.PSDCENSA = oDt.Rows(0).Item("DCENSA")
                obeBulto.PSNUMDES = oDt.Rows(0).Item("NUMDES")
            End If
            With obeBulto
                .PSCCMPN = strCCMPN
                .PSCDVSN = strCDVSN
                .PNCPLNDV = dblCPLNDV
                .PNCCLNT = intCCLNT
                .PSUSUARIO = objSeguridadBN.pUsuario
            End With
            If obrBulto.fintRealizarTransferenciaBulto(obeBulto) = 1 Then
                strCREFFW = obeBulto.PSCREFFW
                Me.Close()
                'Else
                '    HelpClass.ErrorMsgBox()
            End If
            'fintRealizarTransferenciaBulto
            'If mfblnRealizar_TransferenciaBulto(intCCLNT, txtNroDocumentoES.Text, strCREFFW, strCCMPN, strCDVSN, dblCPLNDV) Then Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
End Class