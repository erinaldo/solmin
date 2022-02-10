Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Public Class frmLeerfacturas


#Region "Declaracion de Variables"

    Private _oCuentaCC As New CuentaCorriente
    Private oCuentaCorrienteNeg As New clsCuentaCorriente
    Public oDtResultado As New DataTable
    Public psTipoDocumento As String = String.Empty
    Public Property oCuentaCC() As CuentaCorriente
        Get
            Return _oCuentaCC
        End Get
        Set(ByVal value As CuentaCorriente)
            _oCuentaCC = value
        End Set
    End Property

#End Region

#Region "Eventos de Control"

    Private Sub txtFactura_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFactura.KeyDown

        If e.KeyCode = Keys.Enter Then

            If txtFactura.Text.Trim.Length = 0 Then Exit Sub

            Dim psTipo As String = String.Empty
            Dim psCliente As String = String.Empty
            Dim psRespuesta As String = String.Empty

            If Not IsNumeric(txtFactura.Text.Trim) Or txtFactura.Text.Length < 11 Then
                MessageBox.Show("El número que esta ingresando es incorrecto", "Aviso de sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtFactura.Text = String.Empty
                Exit Sub
            End If

            If Val(txtFactura.Text) > 0 Then
                Dim oDtDocumentos As New DataTable
                psTipo = fsValidaDocumento(txtFactura.Text.Trim, psRespuesta, oDtDocumentos)

                

                If Not String.IsNullOrEmpty(psRespuesta) Then
                    MessageBox.Show(psRespuesta, "Aviso de sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtFactura.Text = String.Empty
                    Exit Sub
                End If

                dtgFacturas.AutoGenerateColumns = False

                Dim dr As DataRow
                If dtgFacturas.DataSource Is Nothing Then

                    Dim oDtFacturas As New DataTable

                    FormatoDt(oDtFacturas)

                    dr = oDtFacturas.NewRow
                    dr("Tipo") = psTipo
                    dr("Numero") = txtFactura.Text.Substring(1, txtFactura.Text.Length - 1)
                    dr("Cliente") = oDtDocumentos.Rows(0).Item("TCMPCL")
                    dr("Codigo") = oDtDocumentos.Rows(0).Item("CCLNT")
                    dr("Fecha") = oDtDocumentos.Rows(0).Item("FE_CNTA_CNTE")
                    dr("Moneda") = oDtDocumentos.Rows(0).Item("SI_MONE")
                    dr("Soles") = oDtDocumentos.Rows(0).Item("IVLAFS")
                    dr("Dolares") = oDtDocumentos.Rows(0).Item("IVLAFD")

                    dr("CCMPN") = oDtDocumentos.Rows(0).Item("CCMPN")
                    dr("TCMPCM") = oDtDocumentos.Rows(0).Item("TCMPCM")
                    dr("CDVSN") = oDtDocumentos.Rows(0).Item("CDVSN")
                    dr("TCMPDV") = oDtDocumentos.Rows(0).Item("TCMPDV")

                    oDtFacturas.Rows.Add(dr)
                    dtgFacturas.DataSource = oDtFacturas
                Else
                    If Not fblBuscaFactura(txtFactura.Text.Trim, psTipo) Then
                        dr = dtgFacturas.DataSource.NewRow

                        dr("Tipo") = psTipo
                        dr("Numero") = txtFactura.Text.Substring(1, txtFactura.Text.Length - 1)
                        dr("Cliente") = oDtDocumentos.Rows(0).Item("TCMPCL")
                        dr("Codigo") = oDtDocumentos.Rows(0).Item("CCLNT")
                        dr("Fecha") = oDtDocumentos.Rows(0).Item("FE_CNTA_CNTE")
                        dr("Moneda") = oDtDocumentos.Rows(0).Item("SI_MONE")
                        dr("Soles") = oDtDocumentos.Rows(0).Item("IVLAFS")
                        dr("Dolares") = oDtDocumentos.Rows(0).Item("IVLAFD")

                        dr("CCMPN") = oDtDocumentos.Rows(0).Item("CCMPN")
                        dr("TCMPCM") = oDtDocumentos.Rows(0).Item("TCMPCM")
                        dr("CDVSN") = oDtDocumentos.Rows(0).Item("CDVSN")
                        dr("TCMPDV") = oDtDocumentos.Rows(0).Item("TCMPDV")

                        dtgFacturas.DataSource.Rows.Add(dr)
                    End If
                End If

                txtFactura.Text = String.Empty
            Else
                txtFactura.Text = String.Empty
            End If
      
        End If

    End Sub

    Private Sub FormatoDt(ByVal oDt As DataTable)
        oDt.Columns.Add("Tipo", GetType(String))
        oDt.Columns.Add("Numero", GetType(String))
        oDt.Columns.Add("Cliente", GetType(String))
        oDt.Columns.Add("Codigo", GetType(String))
        oDt.Columns.Add("Fecha", GetType(String))
        oDt.Columns.Add("Moneda", GetType(String))
        oDt.Columns.Add("Soles", GetType(Decimal))
        oDt.Columns.Add("Dolares", GetType(Decimal))

        oDt.Columns.Add("CCMPN", GetType(String))
        oDt.Columns.Add("TCMPCM", GetType(String))
        oDt.Columns.Add("CDVSN", GetType(String))
        oDt.Columns.Add("TCMPDV", GetType(String))
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        If dtgFacturas.Rows.Count > 0 Then
            oDtResultado = dtgFacturas.DataSource
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If

    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        If dtgFacturas.Rows.Count = 0 Then Exit Sub
        dtgFacturas.Rows.Remove(dtgFacturas.CurrentRow)
    End Sub

    Private Sub txtFactura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFactura.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.Handled = False
        Else
            If Not Char.IsControl(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

#End Region

#Region "Procedimientos y funciones"

    Private Function fblBuscaFactura(ByVal psNumFac As String, ByVal psTipo As String) As Boolean
        For Each dr As DataRow In dtgFacturas.DataSource.Rows
            If psNumFac.Substring(1, psNumFac.Length - 1) = dr("Numero") And psTipo = dr("Tipo") Then
                Return True
            End If
        Next
        Return False
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
    Private Function fnbolValidaCompaniaDivision(ByVal strComDiv As String) As Boolean

        If Not dtgFacturas.DataSource Is Nothing Then

            If dtgFacturas.DataSource.Rows.Count > 0 Then

                For Each dr As DataRow In dtgFacturas.DataSource.Rows
                    If strComDiv <> dr("CCMPN") & dr("CDVSN") Then
                        Return False
                    End If
                Next
            End If
        End If

        Return True

    End Function

    Private Function fsValidaDocumento(ByVal psNumero As String, ByRef psEstadoDoc As String, ByRef oDtDatosDoc As DataTable) As String

        oCuentaCorrienteNeg = New clsCuentaCorriente
        Dim stipo As String = String.Empty
        Dim odtCtaCte As New DataTable
        Dim psTipo As String = String.Empty

        oCuentaCC.NDCCTC = psNumero.Substring(1, psNumero.Length - 1)
        Try
            odtCtaCte = oCuentaCorrienteNeg.Buscar_PorNumero_Documento(oCuentaCC.NDCCTC, psNumero.Substring(0, 1))
        Catch : End Try

        If odtCtaCte.Rows.Count > 0 Then

            If Not fnbolValidaCompaniaDivision(odtCtaCte.Rows(0).Item("CCMPN") & odtCtaCte.Rows(0).Item("CDVSN")) Then
                psEstadoDoc = "La Compañia División deben ser las mismas"
                Return ""
            End If
            oDtDatosDoc = odtCtaCte.Copy

            Select Case psTipoDocumento
                Case "C" 'Cliente
                    If odtCtaCte.Rows(0).Item("EST_COBRANZA") = String.Empty And _
                           odtCtaCte.Rows(0).Item("EST_COBRADOR") = String.Empty And _
                           odtCtaCte.Rows(0).Item("EST_CLIENTE") = String.Empty Then
                        psEstadoDoc = "El documento se encuentra emitida, no se puede enviarse al Cliente"
                    Else
                        If odtCtaCte.Rows(0).Item("EST_COBRANZA") <> String.Empty And _
                        odtCtaCte.Rows(0).Item("EST_COBRADOR") = String.Empty Then
                            psEstadoDoc = "El documento se encuentra en Cobranza, no puede enviarse al Cliente"
                        Else
                            If odtCtaCte.Rows(0).Item("EST_CLIENTE") <> String.Empty Then
                                psEstadoDoc = "El documento ya se encuentra en Cliente"
                            End If
                        End If
                    End If

                Case "Z" 'Cobranza
                    If odtCtaCte.Rows(0).Item("EST_COBRANZA") <> String.Empty And _
                               odtCtaCte.Rows(0).Item("EST_COBRADOR") = String.Empty And _
                               odtCtaCte.Rows(0).Item("EST_CLIENTE") = String.Empty Then
                        psEstadoDoc = "El Documento ya se encuentra en Cobranza"
                    Else
                        If odtCtaCte.Rows(0).Item("EST_COBRADOR") <> String.Empty And _
                               odtCtaCte.Rows(0).Item("EST_CLIENTE") = String.Empty Then
                            psEstadoDoc = "El Documento se encuentra en Cobrador, no se puede entregar a Cobranza"
                        Else
                            If odtCtaCte.Rows(0).Item("EST_COBRADOR") <> String.Empty And _
                               odtCtaCte.Rows(0).Item("EST_CLIENTE") <> String.Empty Then
                                psEstadoDoc = "El Documento se encuentra en Cliente, no se puede entregar a Cobranza"
                            End If
                        End If
                    End If

                Case "R" 'Cobrador
                    If odtCtaCte.Rows(0).Item("EST_COBRADOR") <> String.Empty And _
                                   odtCtaCte.Rows(0).Item("EST_CLIENTE") = String.Empty Then
                        psEstadoDoc = "El Documento ya se encuentra en Cobrador"

                    Else
                        If odtCtaCte.Rows(0).Item("EST_COBRADOR") <> String.Empty And _
                                                           odtCtaCte.Rows(0).Item("EST_CLIENTE") <> String.Empty Then
                            psEstadoDoc = "El Documento se encuentra en Cliente, no se puede entregar al Cobrador"
                        End If
                    End If
            End Select

            stipo = fsValidaTipoDocumento(psNumero.Substring(0, 1))
            If stipo = String.Empty Then
                psEstadoDoc = "El tipo de documento no existe"
            End If

        Else
            psEstadoDoc = "Número de documento no existe"
        End If

        Return stipo

    End Function

#End Region

    Private Sub frmLeerfacturas_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub
End Class
