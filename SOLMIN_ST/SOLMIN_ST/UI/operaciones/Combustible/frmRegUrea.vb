Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.ENTIDADES
Public Class frmRegUrea

#Region "Atributo"
    Private pNLQCMB As Decimal = 0
    Private pCCMPN As String = ""
    Private pNRITEM As Decimal = 0
    Public pDialogOK As Boolean = False
    Public pCodEstadoLiq As String = ""
    Public Enum Accion
        Nuevo
        Editar
    End Enum
    Public pAccion As Accion = Accion.Nuevo

#End Region

    Public Sub New(NLQCMB As Decimal, CCMPN As String, NRITEM As Decimal)
        MyBase.New()
        InitializeComponent()
        pNLQCMB = NLQCMB
        pCCMPN = CCMPN
        pNRITEM = NRITEM
    End Sub

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Try
            Dim oUrea_BLL As New Urea_BLL
            Dim oUrea As New Urea
            Dim msg As String = ""
            If Me.Validar_Inputs = True Then Exit Sub
            With oUrea
                .NLQCMB = pNLQCMB
                .NRITEM = pNRITEM
                .CCMPN = pCCMPN
                .NRODCM = txtRefDoc.Text.Trim
                .FCGURA = CType(HelpClass.CtypeDate(Me.dtpFechaCarga.Value), Double)
                .QLTSCM = Val(txtUreaAsignado.Text.Trim)
                .CSTGLN = Val(txtCostoGln.Text.Trim)
                .CULUSA = MainModule.USUARIO
                .NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                .CMNDA1 = cboMoneda.SelectedValue
            End With

            msg = oUrea_BLL.Registrar_Urea(oUrea)

            If pAccion = Accion.Nuevo Then
                If msg = "" Then
                    pDialogOK = True
                    txtRefDoc.Text = ""
                    txtRefDoc.Focus()
                    MessageBox.Show("Úrea Registrado", "Aviso", MessageBoxButtons.OK)
                Else
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
            If pAccion = Accion.Editar Then
                If msg = "" Then
                    pDialogOK = True
                    MessageBox.Show("Úrea Actualizado", "Aviso", MessageBoxButtons.OK)
                Else
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function Validar_Inputs() As Boolean
        Dim lstr_validacion As String = ""
        Dim lbool_existe_error As Boolean = False
        'If Me.txtRefDoc.TextLength = 0 Then
        '    lstr_validacion += "* Nro Vale " & Chr(13)
        'End If
        If Val(txtUreaAsignado.Text.Trim) = 0 Then
            lstr_validacion += "* Cantidad Úrea(lt)" & Chr(13)
        End If
        If Val(txtCostoGln.Text.Trim) = 0 Then
            lstr_validacion += "* Costo" & Chr(13)
        End If
        If lstr_validacion <> "" Then
            HelpClass.MsgBox("DEBE DE INGRESAR :" & Chr(13) & lstr_validacion)
            lbool_existe_error = True
        End If

        Return lbool_existe_error
    End Function

    Private Sub CargaMoneda()
        Dim obllMoneda As New NEGOCIO.Moneda_BLL
        Dim dt As New DataTable
        dt = obllMoneda.Listar_Monedas_Basica()
        cboMoneda.DataSource = dt
        cboMoneda.ValueMember = "pCMNDA1_Codigo"
        cboMoneda.DisplayMember = "pTMNDA_Detalle"
        cboMoneda.SelectedValue = 1
        cboMoneda.Enabled = False
    End Sub

    Private Sub frmRegValeCombustible_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            CargaMoneda()
            If pAccion = Accion.Editar Then
                Dim oUrea_BLL As New Urea_BLL
                Dim dtVale As New DataTable
                Dim oUrea As New Urea
                oUrea.CCMPN = pCCMPN
                oUrea.NLQCMB = pNLQCMB
                oUrea.NRITEM = pNRITEM

                dtVale = oUrea_BLL.Listar_Item_Urea(oUrea)
                If dtVale.Rows.Count > 0 Then
                    txtRefDoc.Text = ("" & dtVale.Rows(0)("NRODCM")).ToString.Trim
                    dtpFechaCarga.Value = Ransa.Utilitario.HelpClass.CNumero_a_Fecha(dtVale.Rows(0)("FCGURA"))
                    txtUreaAsignado.Text = Val(dtVale.Rows(0)("QLTSCM"))
                    txtCostoGln.Text = Val(dtVale.Rows(0)("CSTGLN"))
                    cboMoneda.SelectedValue = dtVale.Rows(0)("CMNDA1")
                    'txtRefDoc.Enabled = False
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

End Class