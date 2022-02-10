Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Text

Public Class frmGestionDocumentos
#Region "Declarcion de Variables"

    Private oCuentaCorrienteNeg As New clsCuentaCorriente
    Private oSeguimiento As New clsSeguimientoDocumentos
    Private beSeguimiento As SeguimientoDocumentos

    Private _beCuentaCorriente As SOLMIN_CTZ.Entidades.CuentaCorriente
    Public Property beCuentaCorriente() As SOLMIN_CTZ.Entidades.CuentaCorriente
        Get
            Return _beCuentaCorriente
        End Get
        Set(ByVal value As SOLMIN_CTZ.Entidades.CuentaCorriente)
            _beCuentaCorriente = value
        End Set
    End Property
 
#End Region

#Region "Procedimiento y funciones"

    Private Sub CargarSeguimiento()
        cmbSeguimiento.DataSource = oSeguimiento.ListaSeguimientoDocumentos("EZ")
        cmbSeguimiento.ValueMember = "CDSGDC"
        cmbSeguimiento.DisplayMember = "TDSGDC"
    End Sub

    Private Sub FormatoDt(ByVal oDt As DataTable)
        oDt.Columns.Add("Tipo", GetType(String))
        oDt.Columns.Add("CodTipo", GetType(Decimal))
        oDt.Columns.Add("Numero", GetType(String))
        oDt.Columns.Add("Cliente", GetType(String))
        oDt.Columns.Add("Codigo", GetType(String))
        oDt.Columns.Add("Fecha", GetType(String))
        oDt.Columns.Add("Moneda", GetType(String))
        oDt.Columns.Add("Soles", GetType(Decimal))
        oDt.Columns.Add("Dolares", GetType(Decimal))
        oDt.Columns.Add("CCMPN", GetType(String))
        oDt.Columns.Add("CDVSN", GetType(String))
        oDt.Columns.Add("TDSGDC", GetType(String))
        oDt.Columns.Add("TCMPCM", GetType(String))

    End Sub

    Private Function fsValidaDocumento(ByVal psNumero As String, ByRef psEstadoDoc As String, ByRef oDtDatosDoc As DataTable) As String

        oCuentaCorrienteNeg = New clsCuentaCorriente
        Dim stipo As String = String.Empty
        Dim odtCtaCte As New DataTable
        Dim psTipo As String = String.Empty
        Dim NumeroDocumento As String = String.Empty

        NumeroDocumento = psNumero.Substring(1, psNumero.Length - 1)
        stipo = fsValidaTipoDocumento(psNumero.Substring(0, 1))
        If stipo = String.Empty Then
            psEstadoDoc = "El tipo de documento no existe"

        Else
            odtCtaCte = oCuentaCorrienteNeg.Buscar_PorNumero_Documento(NumeroDocumento, psNumero.Substring(0, 1))

            If odtCtaCte.Rows.Count > 0 Then

                If Not fnbolValidaCompaniaDivision(odtCtaCte.Rows(0).Item("CCMPN") & odtCtaCte.Rows(0).Item("CDVSN")) Then
                    psEstadoDoc = "La Compañia División deben ser las mismas"
                    Return ""
                End If
                oDtDatosDoc = odtCtaCte.Copy



            Else
                psEstadoDoc = "Número de documento no existe"
            End If
        End If



        Return stipo

    End Function

    Private Function fnbolValidaCompaniaDivision(ByVal strComDiv As String) As Boolean

        If Not dtgDocumentos.DataSource Is Nothing Then

            If dtgDocumentos.DataSource.Rows.Count > 0 Then

                For Each dr As DataRow In dtgDocumentos.DataSource.Rows
                    If strComDiv <> dr("CCMPN") & dr("CDVSN") Then
                        Return False
                    End If
                Next
            End If
        End If

        Return True

    End Function

    Private Function fsValidaTipoDocumento(ByVal pnTipoDoc As Integer) As String
        Dim Lista_TipoDocumento As New clsTipoDocumento
        Dim oDt As New DataTable
        Dim psTipo_Doc As String = String.Empty
        Lista_TipoDocumento.Crea_TipoDocumento()
        oDt = Lista_TipoDocumento.Lista_TipoDocumento()

        For Each dr As DataRow In oDt.Select("CTPODC = " & pnTipoDoc)
            psTipo_Doc = dr("TABTPD")
        Next

        Return psTipo_Doc
    End Function

    Private Function fblBuscaFactura(ByVal psNumFac As String, ByVal psTipo As String) As Boolean
        For Each dr As DataRow In dtgDocumentos.DataSource.Rows
            If psNumFac.Substring(1, psNumFac.Length - 1) = dr("Numero") And psTipo = dr("Tipo") Then
                Return True
            End If
        Next
        Return False
    End Function

#End Region

#Region "Eventos de Control"

    Private Sub frmGestionDocumentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarSeguimiento()
        txtHora.Text = Now.Hour.ToString.PadLeft(2, "0") & ":" & Now.Minute.ToString.PadLeft(2, "0") & ":" & Now.Second.ToString.PadLeft(2, "0")
        Mostrar_Usuario()
    End Sub

    Private Sub Mostrar_Usuario()
        Try
            Dim objLogica As New clsCompania
            Me.txtUsuario.Text = objLogica.Nombre_Usuario(ConfigurationWizard.UserName)
        Catch ex As Exception
            HelpClass.MsgBox(ex.Message, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub txtDocumentos_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDocumentos.KeyDown
        If e.KeyCode = Keys.Enter Then

            Dim psTipo As String = String.Empty
            Dim psRespuesta As String = String.Empty

            If txtDocumentos.Text.Trim.Length = 0 Then Exit Sub

            If Not IsNumeric(txtDocumentos.Text.Trim) Or txtDocumentos.Text.Length < 11 Then
                MessageBox.Show("El número que esta ingresando es incorrecto", "Aviso de sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtDocumentos.Text = String.Empty
                Exit Sub
            End If


            If Val(txtDocumentos.Text) > 0 Then
                Dim oDtDocumentos As New DataTable
                psTipo = fsValidaDocumento(txtDocumentos.Text.Trim, psRespuesta, oDtDocumentos)



                If Not String.IsNullOrEmpty(psRespuesta) Then
                    MessageBox.Show(psRespuesta, "Aviso de sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtDocumentos.Text = String.Empty
                    Exit Sub
                End If
                dtgDocumentos.AutoGenerateColumns = False
                Dim dr As DataRow
                If dtgDocumentos.DataSource Is Nothing Then
                    Dim oDtFacturas As New DataTable
                    FormatoDt(oDtFacturas)
                    dr = oDtFacturas.NewRow
                    dr("Tipo") = psTipo
                    dr("CodTipo") = txtDocumentos.Text.Substring(0, 1)
                    dr("Numero") = txtDocumentos.Text.Substring(1, txtDocumentos.Text.Length - 1)
                    dr("Cliente") = oDtDocumentos.Rows(0).Item("TCMPCL")
                    dr("Codigo") = oDtDocumentos.Rows(0).Item("CCLNT")
                    dr("Fecha") = oDtDocumentos.Rows(0).Item("FE_CNTA_CNTE")
                    dr("Moneda") = oDtDocumentos.Rows(0).Item("SI_MONE")
                    dr("Soles") = oDtDocumentos.Rows(0).Item("IVLAFS")
                    dr("Dolares") = oDtDocumentos.Rows(0).Item("IVLAFD")
                    dr("CCMPN") = oDtDocumentos.Rows(0).Item("CCMPN")
                    dr("CDVSN") = oDtDocumentos.Rows(0).Item("CDVSN")
                    dr("TDSGDC") = oDtDocumentos.Rows(0).Item("TDSGDC")
                    dr("TCMPCM") = oDtDocumentos.Rows(0).Item("TCMPCM")
                    oDtFacturas.Rows.Add(dr)
                    dtgDocumentos.DataSource = oDtFacturas
                Else
                    If Not fblBuscaFactura(txtDocumentos.Text.Trim, psTipo) Then
                        dr = dtgDocumentos.DataSource.NewRow
                        dr("Tipo") = psTipo
                        dr("CodTipo") = txtDocumentos.Text.Substring(0, 1)
                        dr("Numero") = txtDocumentos.Text.Substring(1, txtDocumentos.Text.Length - 1)
                        dr("Cliente") = oDtDocumentos.Rows(0).Item("TCMPCL")
                        dr("Codigo") = oDtDocumentos.Rows(0).Item("CCLNT")
                        dr("Fecha") = oDtDocumentos.Rows(0).Item("FE_CNTA_CNTE")
                        dr("Moneda") = oDtDocumentos.Rows(0).Item("SI_MONE")
                        dr("Soles") = oDtDocumentos.Rows(0).Item("IVLAFS")
                        dr("Dolares") = oDtDocumentos.Rows(0).Item("IVLAFD")
                        dr("CCMPN") = oDtDocumentos.Rows(0).Item("CCMPN")
                        dr("CDVSN") = oDtDocumentos.Rows(0).Item("CDVSN")
                        dr("TDSGDC") = oDtDocumentos.Rows(0).Item("TDSGDC")
                        dr("TCMPCM") = oDtDocumentos.Rows(0).Item("TCMPCM")
                        dtgDocumentos.DataSource.Rows.Add(dr)
                    End If
                End If

                txtDocumentos.Text = String.Empty
            Else
                txtDocumentos.Text = String.Empty
            End If

        End If
    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        If dtgDocumentos.Rows.Count = 0 Then Exit Sub
        CType(dtgDocumentos.DataSource, DataTable).Rows.Remove(CType(Me.dtgDocumentos.CurrentRow.DataBoundItem, DataRowView).Row)
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Function DevuelveArea(ByVal nCodigo As Integer) As String
        Select Case nCodigo
            Case 1
                Return "al area "
            Case 2, 3
                Return "al area de "
            Case 4
                Return "al "
        End Select

        Return ""
    End Function


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        If dtgDocumentos.RowCount = 0 Then Exit Sub

        If txtResponsable.Text.Trim.Length = 0 Then
            MessageBox.Show("Debe ingresar el responsable", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtResponsable.Focus()
            Exit Sub
        End If

        If txtObs.Text.Trim.Length = 0 Then
            MessageBox.Show("Debe ingresar la Observación", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtResponsable.Focus()
            Exit Sub
        End If

        If txtHora.Text.Trim.Length > 1 Then
            If IsDate(txtHora.Text) = False Then
                MessageBox.Show("Hora Incorrecta", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtHora.Focus()
                Exit Sub
            End If
        End If


        Dim strBody As New StringBuilder
        strBody.Append(System.Environment.NewLine)
        strBody.Append(" El usuario " & txtUsuario.Text & " ha transferido " & DevuelveArea(cmbSeguimiento.SelectedValue) & cmbSeguimiento.Text.Trim & " los siguientes documentos: " & System.Environment.NewLine & System.Environment.NewLine)

        strBody.Append(" Compañia : " & dtgDocumentos.DataSource.Rows(0).Item("TCMPCM") & System.Environment.NewLine)
        strBody.Append(" Fecha : " & dtpFecha.Value.ToShortDateString & System.Environment.NewLine)
        strBody.Append(" Hora : " & IIf(txtHora.Text.Trim.Length > 1, txtHora.Text & ":" & Now.Second.ToString.PadLeft(2, "0"), Now.Hour.ToString.PadLeft(2, "0") & ":" & Now.Minute.ToString.PadLeft(2, "0") & ":" & Now.Second.ToString.PadLeft(2, "0")) & System.Environment.NewLine)
        strBody.Append(" Responsable : " & txtResponsable.Text.Trim & System.Environment.NewLine)
        strBody.Append(" Observación : " & txtObs.Text.Trim.Replace(Chr(10), " ") & System.Environment.NewLine)

        strBody.Append(System.Environment.NewLine)

        strBody.Append(" Tipo" & Chr(9))
        strBody.Append(" Número" & Chr(9) & Chr(9))
        strBody.Append(" Código" & Chr(9))
        strBody.Append(" Cliente" & Chr(9) & Chr(9) & Chr(9) & Chr(9) & Chr(9))
        strBody.Append(" Fecha" & Chr(9) & Chr(9))
        strBody.Append(" Moneda" & Chr(9) & Chr(9))
        strBody.Append(" Soles" & Chr(9) & Chr(9))
        strBody.Append(" Dolares" & Chr(9) & Chr(9))
        strBody.Append(" Seguimiento Origen" & System.Environment.NewLine)
        strBody.Append(" ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------" & System.Environment.NewLine)

        Dim Soles As String = String.Empty
        Dim Dolares As String = String.Empty

        For Each dr As DataRow In dtgDocumentos.DataSource.Rows


            strBody.Append(" " & dr("Tipo").ToString.Trim & Chr(9))
            strBody.Append(dr("Numero").ToString.Trim & Chr(9))
            strBody.Append(dr("Codigo").ToString.Trim & Chr(9))
            'strBody.Append(dr("Cliente").ToString.Trim.PadLeft(35, "") & Chr(9))
            strBody.Append(dr("Cliente").ToString.Trim & Chr(9) & Chr(9))
            strBody.Append(dr("Fecha").ToString.Trim & Chr(9))
            strBody.Append(dr("Moneda").ToString.Trim & Chr(9) & Chr(9))

            Soles = Math.Round(dr("Soles"), 2).ToString.PadLeft(10, " ")
            Dolares = Math.Round(dr("Dolares"), 2).ToString.PadLeft(10, " ")


            strBody.Append(Soles & Chr(9))
            strBody.Append(Dolares & Chr(9) & Chr(9))
            strBody.Append(dr("TDSGDC") & System.Environment.NewLine)
        Next
        strBody.Append(System.Environment.NewLine)
        strBody.Append(" ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------" & System.Environment.NewLine)


        Dim ofrmEnvio As New frmEnvioCorreoDocumentos
        ofrmEnvio.sSeguimiento = cmbSeguimiento.Text.Trim
        ofrmEnvio.nSeguimiento = cmbSeguimiento.SelectedValue
        ofrmEnvio.sFecha = dtpFecha.Value.ToShortDateString
        ofrmEnvio.sHora = IIf(txtHora.Text.Trim.Equals(":"), Now.Hour.ToString.PadLeft(2, "0") & ":" & Now.Minute.ToString.PadLeft(2, "0") & ":" & Now.Second.ToString.PadLeft(2, "0"), txtHora.Text)
        ofrmEnvio.sResponsable = txtResponsable.Text.Trim
        ofrmEnvio.sObs = txtObs.Text.Trim
        ofrmEnvio.oDtDocumentos = dtgDocumentos.DataSource
        ofrmEnvio.txtAsunto.Text = "Transferencia de Documentos"
        'ofrmEnvio.txtBody.Text = strBody.ToString
        ofrmEnvio.sUsuario = txtUsuario.Text
        ofrmEnvio.txtCopia.Text = ConfigurationWizard.UserName & "@ransa.net"
        If ofrmEnvio.ShowDialog = Windows.Forms.DialogResult.Yes Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub

    Private Sub txtHora_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtHora.Validating
        If txtHora.Text.Trim.Length > 1 Then
            If IsDate(txtHora.Text) = False Then
                MessageBox.Show("Hora Incorrecta", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtHora.Focus()
            End If
        End If

    End Sub

#End Region

 
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CargarDocumentoSeleccionados(ByVal oDtDocumentos As DataTable)
        dtgDocumentos.AutoGenerateColumns = False
        Dim boolRepetido As Boolean = False
        If oDtDocumentos Is Nothing Then Exit Sub
        For intCont As Integer = 0 To oDtDocumentos.Rows.Count - 1
            '======Validar si existe
            boolRepetido = False
            For intX As Integer = 0 To Me.dtgDocumentos.Rows.Count - 1
                If dtgDocumentos.DataSource.Rows(intX).Item("CodTipo") = oDtDocumentos.Rows(intCont).Item("TI_DOCU") AndAlso dtgDocumentos.DataSource.Rows(intX).Item("Numero") = oDtDocumentos.Rows(intCont).Item("NU_DOCU") Then
                    boolRepetido = True
                    Exit For
                End If
            Next
            '=====fin validacion=====
            If boolRepetido = False Then
                Dim dr As DataRow
                If dtgDocumentos.DataSource Is Nothing Then
                    Dim oDtFacturas As New DataTable
                    FormatoDt(oDtFacturas)
                    dr = oDtFacturas.NewRow
                    dr("Tipo") = oDtDocumentos.Rows(intCont).Item("NO_DOCU")
                    dr("CodTipo") = oDtDocumentos.Rows(intCont).Item("TI_DOCU")
                    dr("Numero") = oDtDocumentos.Rows(intCont).Item("NU_DOCU")
                    dr("Cliente") = oDtDocumentos.Rows(intCont).Item("TCMPCL")
                    dr("Codigo") = oDtDocumentos.Rows(intCont).Item("CCLNT")
                    dr("Fecha") = oDtDocumentos.Rows(intCont).Item("FE_CNTA_CNTE")
                    dr("Moneda") = oDtDocumentos.Rows(intCont).Item("SI_MONE")
                    dr("Soles") = oDtDocumentos.Rows(intCont).Item("IVLAFS")
                    dr("Dolares") = oDtDocumentos.Rows(intCont).Item("IVLAFD")
                    dr("CCMPN") = oDtDocumentos.Rows(intCont).Item("CCMPN")
                    dr("CDVSN") = oDtDocumentos.Rows(intCont).Item("CDVSN")
                    dr("TDSGDC") = oDtDocumentos.Rows(intCont).Item("TDSGDC")
                    dr("TCMPCM") = oDtDocumentos.Rows(intCont).Item("TCMPCM")
                    oDtFacturas.Rows.Add(dr)
                    dtgDocumentos.DataSource = oDtFacturas
                Else
                    dr = dtgDocumentos.DataSource.NewRow
                    dr("Tipo") = oDtDocumentos.Rows(intCont).Item("NO_DOCU")
                    dr("CodTipo") = oDtDocumentos.Rows(intCont).Item("TI_DOCU")
                    dr("Numero") = oDtDocumentos.Rows(intCont).Item("NU_DOCU")
                    dr("Cliente") = oDtDocumentos.Rows(intCont).Item("TCMPCL")
                    dr("Codigo") = oDtDocumentos.Rows(intCont).Item("CCLNT")
                    dr("Fecha") = oDtDocumentos.Rows(intCont).Item("FE_CNTA_CNTE")
                    dr("Moneda") = oDtDocumentos.Rows(intCont).Item("SI_MONE")
                    dr("Soles") = oDtDocumentos.Rows(intCont).Item("IVLAFS")
                    dr("Dolares") = oDtDocumentos.Rows(intCont).Item("IVLAFD")
                    dr("CCMPN") = oDtDocumentos.Rows(intCont).Item("CCMPN")
                    dr("CDVSN") = oDtDocumentos.Rows(intCont).Item("CDVSN")
                    dr("TDSGDC") = oDtDocumentos.Rows(intCont).Item("TDSGDC")
                    dr("TCMPCM") = oDtDocumentos.Rows(intCont).Item("TCMPCM")
                    dtgDocumentos.DataSource.Rows.Add(dr)
                End If
            End If
        Next
       
    End Sub

    Private Sub btnBuscar_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar_1.Click
        Dim ofrm As New frmBuscarDocumento
        ofrm.beCuentaCorriente = _beCuentaCorriente
        If ofrm.ShowDialog = Windows.Forms.DialogResult.OK Then
            CargarDocumentoSeleccionados(ofrm.oDtResultado)
        End If
    End Sub


End Class
