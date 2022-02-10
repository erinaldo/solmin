Imports System.Text
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones
Public Class frmOpcionFacturacionLibre

#Region "Atributos"
    Private intEstado As Int32 = 0
    Private strCompania As String = ""
    Private strDivision As String = ""
    Private decPlanta As Decimal = 0
    Private boolCargado As Boolean = False
    Private iCodigoMoneda As Integer = 0
    Private strImporteSoles As String = ""
    Private strImporteDolares As String = ""
    Private strOperacionPreLiq As String = ""
#End Region

#Region "Properties"
    Public WriteOnly Property Estado() As Int32
        Set(ByVal value As Int32)
            intEstado = value
        End Set
    End Property

    Public WriteOnly Property Compania() As String
        Set(ByVal value As String)
            strCompania = value
        End Set
    End Property
    Public WriteOnly Property Division() As String
        Set(ByVal value As String)
            strDivision = value
        End Set
    End Property
    Public WriteOnly Property CodigoMoneda() As Integer
        Set(ByVal value As Integer)
            iCodigoMoneda = value
        End Set
    End Property
    Public WriteOnly Property ImporteSoles() As String
        Set(ByVal value As String)
            strImporteSoles = value
        End Set
    End Property
    Public WriteOnly Property ImporteDolares() As String
        Set(ByVal value As String)
            strImporteDolares = value
        End Set
    End Property

    Public WriteOnly Property OperacionPreLiq() As String
        Set(ByVal value As String)
            strOperacionPreLiq = value
        End Set
    End Property
#End Region
#Region "Eventos"
    Private Sub frmOpcionFacturacionLibre_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Me.txtImporteSoles.Text = strImporteSoles
            Me.txtImporteDolares.Text = strImporteDolares
            'Me.txtFactura.Focused = True
            'Me.txtFactura.Focus()
            'Me.txtFiltroTransportista.CharacterCasing = CharacterCasing.Upper
            'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-INICIO
            Dim negocio As New Factura_Transporte_BLL
            cboTipoDoc.DataSource = negocio.ListarTipoDocumento(strCompania)
            cboTipoDoc.ValueMember = "CTPODC"
            cboTipoDoc.DisplayMember = "TCMTPD"
            cboTipoDoc.SelectedValue = 51


            'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT-FIN

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            Dim msgValidacion As String
            msgValidacion = ValidarIngreso()
            If (msgValidacion.Length <> 0) Then
                MessageBox.Show(msgValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim obj_Logica As New Factura_Transporte_BLL
            Dim objParametro As New Hashtable
            Dim sMensajeError As String = ""
            If intEstado = 1 Then
                objParametro.Add("PNNOPRCN", strOperacionPreLiq.Trim)
                objParametro.Add("PNNOPRCN2", strOperacionPreLiq.Trim)
            Else
                objParametro.Add("PNNOPRCN", txtOperacion.Text.Trim)
                objParametro.Add("PNNOPRCN2", txtOperacion.Text.Trim)
            End If
            objParametro.Add("PNCTPDCF", cboTipoDoc.SelectedValue) 'ECM-HUNDRED-SGR-DEF-SALMON-ST-FASE2-VENTA-INTERNA-PT
            objParametro.Add("PNNDCMFC", txtFactura.Text)
            objParametro.Add("PSSESTOP", "F")
            'objParametro.Add("PNFECFAC", HelpClass.CDate_a_Numero8Digitos(dtpFechaFactura.Value))
            'objParametro.Add("PSTRFSRC", txtMotivo.Text.Trim & "-" & MainModule.USUARIO)
            objParametro.Add("PSCCMPN", strCompania)

            Dim motivo As String = txtMotivo.Text.Trim & "-" & MainModule.USUARIO
            Dim FlagDocSap As String = ""
            If chkSap.Checked = True Then
                FlagDocSap = "SI"
                motivo = motivo & "-SAP"
            End If
            objParametro.Add("PSTRFSRC", motivo)

            objParametro.Add("PSFLAGDOCSAP", FlagDocSap)

            If obj_Logica.Validar_Facturacion_Libre(objParametro, sMensajeError) Then
                'Actualizar Factura
                'If obj_Logica.Actualizar_Facturacion_Libre(objParametro) = 0 Then

                obj_Logica.Actualizar_Facturacion_Libre(objParametro)

                Dim oDt As DataTable
                oDt = Estimacion_Ingreso_Revertir(strCompania, cboTipoDoc.SelectedValue, txtFactura.Text.Trim)

                'If Db2Manager.RansaData.iSeries.DataObjects.ConfigurationWizard.Server = "RANSA" Then

                If oDt.Rows.Count > 0 Then
                    Dim IdEstimacion As Double, AnioContaSap As Double, FechaDocCtaCte As Double
                    Dim NroDocEstimacionSap As String, CodSociedadSap As String, NumDocElectronico As String

                    Dim dt_url_servicio As New DataTable
                    Dim oda_url_servicio As New NEGOCIO.UrlServicios_BLL
                    dt_url_servicio = oda_url_servicio.Listar_Url_Servicio("SDESTSAPSALM", "", "", 0)
                    Dim url_ws_servicio As String = ""
                    If dt_url_servicio.Rows.Count > 0 Then
                        url_ws_servicio = ("" & dt_url_servicio.Rows(0)("URL")).ToString.Trim
                    End If


                    For index As Integer = 0 To oDt.Rows.Count - 1
                        IdEstimacion = oDt.Rows(index).Item("IDESTM")
                        NroDocEstimacionSap = oDt.Rows(index).Item("NDESAP").ToString.Trim
                        CodSociedadSap = oDt.Rows(index).Item("CSCDSP").ToString.Trim
                        AnioContaSap = oDt.Rows(index).Item("ACNTSP")
                        NumDocElectronico = oDt.Rows(index).Item("NDCCTE").ToString.Trim
                        FechaDocCtaCte = oDt.Rows(index).Item("FECHA_ACTUAL").ToString.Trim
                        'INI-ECM-ActualizacionTarifario[RF001]-160516
                        Dim wssalmon As New NEGOCIO.ws_reversion_Ingreso.ws_salmon
                        wssalmon.Url = url_ws_servicio
                        wssalmon.ws_reversion_ingreso(IdEstimacion, CodSociedadSap, NroDocEstimacionSap, AnioContaSap, NumDocElectronico, FechaDocCtaCte)
                        'FIN-ECM-ActualizacionTarifario[RF001]-160516
                    Next
                End If
                'End If
                'Invocar el Servicio Web con los parametros devueltos del SP



                HelpClass.MsgBox("Las Operaciones ha sido regularizado con éxito.", MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
                'Else
                '    MessageBox.Show("Ha ocurrido un error al Facturar", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'End If
            Else
                MessageBox.Show(sMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub txtFactura_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFactura.GotFocus

    End Sub

    Private Sub txtFactura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFactura.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back)
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
#End Region
#Region "Métodos"
    Private Function ValidarIngreso() As String
        Dim msgValidacion As New StringBuilder
        If txtFactura.Text.Trim = "" Or txtFactura.Text.Trim = "0" Then
            msgValidacion.Append("Ingrese Nro. de Factura")
        ElseIf txtMotivo.Text.Trim = "" Then
            msgValidacion.Append("Ingrese Motivo de la Factura")
        End If
        Return msgValidacion.ToString.Trim
    End Function


    Private Function Estimacion_Ingreso_Revertir(ByVal compania As String, ByVal tipodoc As Decimal, ByVal strNumFact As Decimal) As DataTable
        Dim oDtNew As DataTable
        Dim oFiltro As New Hashtable
        Dim oFactura_Transporte_BLL As New Factura_Transporte_BLL

        oFiltro.Add("PSCCMPN", compania) 'Compañía
        oFiltro.Add("PNCTPODC", tipodoc) 'Tipo de Documento
        oFiltro.Add("PNNDCFCC", strNumFact) 'Nro. Documento 
        oFiltro.Add("PNNSECFC", 0) 'Nro. Revisión

        oDtNew = oFactura_Transporte_BLL.Estimacion_Ingreso_Revertir(oFiltro)

        Return oDtNew
    End Function


#End Region

End Class
