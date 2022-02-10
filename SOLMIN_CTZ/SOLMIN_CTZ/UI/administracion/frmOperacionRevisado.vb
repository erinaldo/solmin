Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class frmOperacionRevisado

    Private Sub frmOperacionRevisado_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        UcServicioAtendido.pUsuario = ConfigurationWizard.UserName
        UcServicioAtendido.pDivision = Ransa.Controls.ServicioOperacion.eDivision.Todos
        Me.UcServicioAtendido.ServicioEstado = Ransa.Controls.ServicioOperacion.Comun.eServicioEstado.PorFacturar
        'UcServicioAtendido.MostrarBotonFactura = True
        UcServicioAtendido.pCargaInicial()


    End Sub

    Private Sub UcServicioAtendido_Facturar(ByVal olOperaciones As System.Collections.Generic.List(Of Ransa.Controls.ServicioOperacion.Servicio_BE), ByVal intTipo As Integer) Handles UcServicioAtendido.Facturar
        LlamarVistaPrevia(olOperaciones, intTipo)
    End Sub

    Private Sub LlamarVistaPrevia(ByVal olOperaciones As System.Collections.Generic.List(Of Ransa.Controls.ServicioOperacion.Servicio_BE), ByVal intTipo As Integer)

        Dim intCont As Integer
        Dim strRegionVenta As String = String.Empty
        Dim mListaFacturas As New List(Of SOLMIN_CTZ.Entidades.FacturaSIL)
        Dim oFacturaNeg As New SOLMIN_CTZ.NEGOCIO.clsFactura
        'Dim DtRegionVenta As New DataTable
        Dim objfrmVFactura As frmGenararFactura
        Dim Moneda As String = String.Empty
        Dim dblCCLNFC As Double = 0
        Dim Cant As Integer = 0
        Dim blRegion As Boolean = True
        Dim strConsistencia As String = String.Empty
        'Dim oDt As DataTable
        'Dim oFiltro As New SOLMIN_CTZ.Entidades.Filtro
        Dim oFiltro As New Hashtable
        Dim primerRegion As String = ""


        For intCont = 0 To olOperaciones.Count - 1
            'oFiltro.Parametro1 = "100" 'tipo cambio dolares
            'oFiltro.Parametro2 = Format(Now, "yyyyMMdd")
            'oDt = oFacturaNeg.Lista_Tipo_Cambio(oFiltro)
            'If oDt.Rows.Count = 0 Then
            '    MessageBox.Show("No se puede generar la factura por no existir Tipo de cambio a la fecha ", "Tipo de cambio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Exit Sub
            'End If
            Dim oFacturacion As New SOLMIN_CTZ.Entidades.FacturaSIL
            oFacturacion.TIPOFACTURA = intTipo
            oFacturacion.NOPRCN = olOperaciones.Item(intCont).NOPRCN
            oFacturacion.TCMPDV = olOperaciones.Item(intCont).TCMPDV
            oFacturacion.PSCDVSN = olOperaciones.Item(intCont).CDVSN
            oFacturacion.PSCCMPN = olOperaciones.Item(intCont).CCMPN
            oFacturacion.CCLNFC = olOperaciones.Item(intCont).CCLNFC
            oFacturacion.CPLNDV = olOperaciones.Item(intCont).CPLNDV
            oFacturacion.CMNDA1 = olOperaciones.Item(intCont).CMNDA1
            'FALTA PREGUNTAR A WALTER

            'oFacturacion.CCNTCS = lOperaciones.Item(intCont).CCNTCS

            If oFacturacion.CCLNFC <> dblCCLNFC And dblCCLNFC <> 0 Then
                MessageBox.Show("No puede generar la factura por que las operaciones seleccionadas " & Chr(10) & " cuentan con diferentes Clientes a Facturar", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            dblCCLNFC = oFacturacion.CCLNFC
            If Cant = 0 Then Moneda = olOperaciones.Item(intCont).TSGNMN
            If Moneda <> olOperaciones.Item(intCont).TSGNMN Then
                MessageBox.Show("No puede generar con diferentes monedas", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If intCont = 0 Then
                primerRegion = olOperaciones.Item(intCont).CRGVTA
            End If
            If olOperaciones.Item(intCont).CRGVTA <> primerRegion Then
                MessageBox.Show("No puede generar con diferentes Regiones de Venta ", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Moneda = olOperaciones.Item(intCont).TSGNMN
            'DtRegionVenta = oFacturaNeg.Lista_Region_Venta_X_Operacion(oFacturacion)

            'If DtRegionVenta.Rows.Count = 0 Then
            '    blRegion = False
            '    strConsistencia += oFacturacion.NOPRCN & System.Environment.NewLine
            'Else
            '    If strRegionVenta <> DtRegionVenta.Rows(0).Item("CRGVTA") And strRegionVenta <> "" Then
            '        MessageBox.Show("No puede generar con diferentes Regiones de Venta ", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '        Exit Sub
            '    End If
            '    oFacturacion.CRGVTA = strRegionVenta
            'End If
            mListaFacturas.Add(oFacturacion)
            Cant += 1
        Next intCont

        'If blRegion = False And Cant > 1 Then
        '    MessageBox.Show("La Operacion " & vbCrLf & strConsistencia & "tiene region venta anulada", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Exit Sub
        'End If
        If mListaFacturas.Count > 0 Then
            'Validamos si el Usuario Tiene Permisos paara Facturar
            'oFiltro = New SOLMIN_CTZ.Entidades.Filtro
            oFiltro = New Hashtable
            'oFiltro.Parametro1 = mListaFacturas(0).PSCCMPN 'strCodCom
            'oFiltro.Parametro2 = mListaFacturas(0).PSCDVSN 'strCodDiv
            Dim oDtGiro As DataTable
            oFiltro("CCMPN") = mListaFacturas(0).PSCCMPN 'strCodCom
            oFiltro("CDVSN") = mListaFacturas(0).PSCDVSN 'strCodDiv

            oDtGiro = oFacturaNeg.Lista_Giro_Negocio(oFiltro)
            If oDtGiro.Rows.Count > 0 Then
                objfrmVFactura = New frmGenararFactura(mListaFacturas)
                objfrmVFactura.MdiParent = Me.Parent.Parent
                objfrmVFactura.WindowState = FormWindowState.Maximized
                objfrmVFactura.Show()
            Else
                MessageBox.Show("Usted no tiene Acceso a facturar", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If

    End Sub


    Private Sub frmOperacionRevisado_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        UcServicioAtendido.Refrescar()
    End Sub

End Class
