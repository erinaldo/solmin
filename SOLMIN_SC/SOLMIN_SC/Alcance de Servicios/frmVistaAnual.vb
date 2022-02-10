Imports System.Windows.Forms
Imports RANSA.TYPEDEF
Imports Ransa.Utilitario
Imports Ransa.Negocio.UbicacionPlanta
Imports Ransa.TypeDef.UbicacionPlanta
Imports Ransa.NEGO
Imports SOLMIN_SC.Negocio
Imports SOLMIN_SC.Entidad

Public Class frmVistaAnual

#Region "ATRIBUTOS"

    Private _CCMPN As String
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property

    Private _CDVSN As String
    Public Property CDVSN() As String
        Get
            Return _CDVSN
        End Get
        Set(ByVal value As String)
            _CDVSN = value
        End Set
    End Property

    Private _CCLNT As Decimal
    Public Property CCLNT() As Decimal
        Get
            Return _CCLNT
        End Get
        Set(ByVal value As Decimal)
            _CCLNT = value
        End Set
    End Property

    Dim dtGeneral As New DataTable
    Dim Tipo_Reporte As String = ""

#End Region

#Region "EVENTOS"


    Private Sub Vista_Anual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Control.CheckForIllegalCrossThreadCalls = False

            'Cargar División
            cmbDivision.Compania = _CCMPN
            cmbDivision.Usuario = HelpUtil.UserName
            cmbDivision.pActualizar()
            cmbDivision.DivisionDefault = _CDVSN

            'Cargar Clientes

            Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(0, HelpUtil.UserName)
            txtCliente.pCargar(ClientePK)
            If _CCLNT > 0 Then
                txtCliente.pCargar(_CCLNT)
            End If

            'Cargar Año
            txtAnio.Text = Now.Year

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Solo_Numeros(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnio.KeyPress
        Try
            e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Generar_Reporte(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarReporte.Click

        Try
            Tipo_Reporte = "R"
            If fblnValidaInformacion() = True Then

                pcxEspera.Visible = True
                btnGenerarReporte.Enabled = False
                btnExportar.Enabled = False
                bgwGifAnimado.RunWorkerAsync()

            End If
        Catch ex As Exception
            pcxEspera.Visible = False
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub bgwGifAnimado_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwGifAnimado.DoWork
        Try
            Generar_Reporte()

        Catch ex As Exception
            pcxEspera.Visible = False
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub bgwGifAnimado_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwGifAnimado.RunWorkerCompleted
        Try

            pcxEspera.Visible = False
            btnGenerarReporte.Enabled = True
            btnExportar.Enabled = True

            If dtGeneral.Rows.Count > 0 Or dtGeneral Is Nothing Then

                If Tipo_Reporte = "R" Then

                    Dim objFrm As New frmVisorAnual

                    objFrm.dtAnual = dtGeneral.Copy
                    objFrm.CCLNT = txtCliente.pRazonSocial
                    objFrm.ANIO = txtAnio.Text
                    objFrm.ShowDialog()

                Else

                    Dim lstFlistros As New List(Of String)
                    Dim dsReporte As New DataSet

                    dtGeneral.Columns.Remove("CDVSN")
                    dtGeneral.Columns.Remove("CCLNT")
                    dtGeneral.Columns.Remove("NANASR")
                    dtGeneral.Columns.Remove("NMSASR")
                    dtGeneral.Columns.Remove("NCRRLT")
                    dtGeneral.Columns.Remove("CUNDSR")

                    dtGeneral.Columns.Remove("QMDASC")
                    dtGeneral.Columns.Remove("TSRVC")

                    dtGeneral.Columns("TCMPDV").ColumnName = "DIVISIÓN"
                    dtGeneral.Columns("TDALSR").ColumnName = "DESCRIPCIÓN ALCANCE DE SERVICIO"
                    dtGeneral.Columns("TINDMD").ColumnName = "INDICADOR DE MEDICIÓN"

                    dtGeneral.Columns("TFRMMD").ColumnName = "FORMA DE MEDICIÓN"

                    dtGeneral.Columns("MES01").ColumnName = "ENE"
                    dtGeneral.Columns("MES02").ColumnName = "FEB"
                    dtGeneral.Columns("MES03").ColumnName = "MAR"
                    dtGeneral.Columns("MES04").ColumnName = "ABR"
                    dtGeneral.Columns("MES05").ColumnName = "MAY"
                    dtGeneral.Columns("MES06").ColumnName = "JUN"
                    dtGeneral.Columns("MES07").ColumnName = "JUL"
                    dtGeneral.Columns("MES08").ColumnName = "AGO"
                    dtGeneral.Columns("MES09").ColumnName = "SEP"
                    dtGeneral.Columns("MES10").ColumnName = "OCT"
                    dtGeneral.Columns("MES11").ColumnName = "NOV"
                    dtGeneral.Columns("MES12").ColumnName = "DIC"

                    dtGeneral.Columns.Add("KPIS", Type.GetType("System.String"))
                    For Each fila As DataRow In dtGeneral.Rows
                        fila("KPIS") = fila("QMDALS").ToString.Trim & " " & fila("TABRUN").ToString.Trim

                    Next

                    dtGeneral.Columns.Remove("QMDALS")
                    dtGeneral.Columns.Remove("TABRUN")
                    dtGeneral.Columns.Remove("TRFMED")

                    dtGeneral.Columns("KPIS").SetOrdinal(3)
                    dtGeneral.Columns("KPIS").ColumnName = "KPI´S"

                    dtGeneral.TableName = "Reporte"
                    dsReporte.Tables.Add(dtGeneral.Copy)
                    lstFlistros.Add("Cliente: \n" & txtCliente.pRazonSocial)
                    lstFlistros.Add("Año: \n" & txtAnio.Text)
                    Ransa.Utilitario.HelpClass.ExportExcelConTitulos(dsReporte, "ALCANCE DE SERVICIO ANUAL", lstFlistros)

                End If

            Else
                btnGenerarReporte.Enabled = True
                btnExportar.Enabled = True
                pcxEspera.Visible = False
                MessageBox.Show("No hay información a mostrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception

            pcxEspera.Visible = False
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "METODOS"

    Sub Generar_Reporte()

        Dim objBE As New beAlcanceServicio
        Dim objBLL As New clsAlcanceServicio

        dtGeneral = New DataTable

        With objBE

            .PSCCMPN = _CCMPN
            .PSCDVSN = cmbDivision.Division
            .PNCCLNT = txtCliente.pCodigo
            .PNNANASR = CDec(txtAnio.Text)

        End With

        dtGeneral = objBLL.fListaAlcanceServicioXClientexAnio(objBE)

    End Sub


    Private Function fblnValidaInformacion() As Boolean

        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True

        If txtCliente.pCodigo = 0D Then
            strMensajeError &= " * Debe seleccionar un cliente. " & vbNewLine
        End If
        If txtAnio.Text.Trim = "" Then
            strMensajeError &= " * Debe Ingresar un año. " & vbNewLine
        End If
        If strMensajeError <> "" Then
            blnResultado = False
            MessageBox.Show(strMensajeError, "Mensaje: ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return blnResultado

    End Function

#End Region


   
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Try
            Tipo_Reporte = "E"
            If fblnValidaInformacion() = True Then

                pcxEspera.Visible = True
                btnGenerarReporte.Enabled = False
                btnExportar.Enabled = False
                bgwGifAnimado.RunWorkerAsync()

            End If
        Catch ex As Exception
            pcxEspera.Visible = False
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
