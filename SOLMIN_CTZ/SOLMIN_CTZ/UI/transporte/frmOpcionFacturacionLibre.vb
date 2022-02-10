Imports System.Text
Imports SOLMIN_CTZ.NEGOCIO.Operaciones
Imports SOLMIN_CTZ.ENTIDADES.Operaciones
Imports Db2Manager.RansaData.iSeries.DataObjects

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
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
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
        objParametro.Add("PNCTPDCF", txtTipoDoc.Tag)
        objParametro.Add("PNNDCMFC", txtFactura.Text)
        objParametro.Add("PSSESTOP", "F")
        'objParametro.Add("PNFECFAC", HelpClass.CDate_a_Numero8Digitos(dtpFechaFactura.Value))
        objParametro.Add("PSTRFSRC", txtMotivo.Text.Trim & "-" & ConfigurationWizard.UserName)
        objParametro.Add("PSCCMPN", strCompania)
        If obj_Logica.Validar_Facturacion_Libre(objParametro, sMensajeError) Then
            'Actualizar Factura
            If obj_Logica.Actualizar_Facturacion_Libre(objParametro) = 0 Then
                HelpClass.MsgBox("Las Operaciones se han Facturado con éxito.", MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                MessageBox.Show("Ha ocurrido un error al Facturar", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show(sMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

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
#End Region

End Class
