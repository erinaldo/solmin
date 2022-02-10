Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class frmOperacionConsolidada

   

    Private Sub frmOperacionConsolidada_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        UcServicioPorFacturar1.pUsuario = ConfigurationWizard.UserName
        UcServicioPorFacturar1.pCompaniaActual = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
        UcServicioPorFacturar1.pCargaInicial()
    End Sub

    Private Sub UcServicioAtendido_FacturarElectronica(ByVal olOperaciones As System.Collections.Generic.List(Of Ransa.Controls.ServicioOperacion.Servicio_BE), ByVal intTipo As Integer, pTipoLista As Ransa.Utilitario.HelpClass.TipoLista) Handles UcServicioPorFacturar1.FacturarElectronicaConsistencia
        LlamarVistaPrevia(olOperaciones, intTipo)
    End Sub

    'Private Sub UcServicioAtendido_Facturar(ByVal olOperaciones As System.Collections.Generic.List(Of Ransa.Controls.ServicioOperacion.Servicio_BE), ByVal intTipo As Integer) Handles UcServicioPorFacturar1.FacturarConsistencia
    '    LlamarVistaPrevia(olOperaciones, intTipo)
    'End Sub

    'Private Sub UcServicioAtendido_Boleta(ByVal olOperaciones As System.Collections.Generic.List(Of Ransa.Controls.ServicioOperacion.Servicio_BE), ByVal intTipo As Integer) Handles UcServicioPorFacturar1.GenerarBoletaConsistencia
    '    LlamarVistaPreviaBoleta(olOperaciones, intTipo)
    'End Sub


#Region "Parte Transferencia"

    'Private Sub UcServicioAtendido_ParteTransferencia(ByVal olOperaciones As System.Collections.Generic.List(Of Ransa.Controls.ServicioOperacion.Servicio_BE), ByVal intTipo As Integer) Handles UcServicioPorFacturar1.ParteTransferenciaConsistencia
    '    LlamarVistaPreviaParteTransferencia(olOperaciones, intTipo)
    'End Sub
#End Region


    'Private Sub LlamarVistaPreviaBoleta(ByVal olOperaciones As System.Collections.Generic.List(Of Ransa.Controls.ServicioOperacion.Servicio_BE), ByVal intTipo As Integer)
    '    Dim intCont As Integer
    '    Dim strRegionVenta As String = String.Empty
    '    Dim mListaFacturas As New List(Of SOLMIN_CTZ.Entidades.FacturaSIL)
    '    Dim oFacturaNeg As New SOLMIN_CTZ.NEGOCIO.clsFactura
    '    Dim DtRegionVenta As New DataTable
    '    Dim objfrmVFactura As frmGenararFactura
    '    Dim Moneda As String = String.Empty
    '    Dim dblCCLNFC As Double = 0
    '    Dim Cant As Integer = 0
    '    Dim blRegion As Boolean = True
    '    Dim strConsistencia As String = String.Empty
    '    Dim oDt As DataTable
    '    'Dim oFiltro As New SOLMIN_CTZ.Entidades.Filtro
    '    Dim oFiltro As New Hashtable
    '    Dim primerRegion As String = ""
    '    For intCont = 0 To olOperaciones.Count - 1
    '        'oFiltro.Parametro1 = "100" 'tipo cambio dolares
    '        'oFiltro.Parametro2 = Format(Now, "yyyyMMdd")
    '        'oDt = oFacturaNeg.Lista_Tipo_Cambio(oFiltro)
    '        'If oDt.Rows.Count = 0 Then
    '        '    MessageBox.Show("No se puede generar la Boleta por no existir Tipo de cambio a la fecha ", "Tipo de cambio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        '    Exit Sub
    '        'End If
    '        Dim oFacturacion As New SOLMIN_CTZ.Entidades.FacturaSIL
    '        oFacturacion.TIPOFACTURA = intTipo

    '        '=============Si es de tipo 1  se genera por tipo de revision else por tipo Operacion===========
    '        If Not olOperaciones.Item(intCont).TIPO = "1" Then
    '            oFacturacion.NOPRCN = olOperaciones.Item(intCont).NOPRCN
    '            oFacturacion.NSECFC = 0
    '        Else
    '            oFacturacion.NOPRCN = 0
    '            oFacturacion.NSECFC = olOperaciones.Item(intCont).NSECFC
    '        End If

    '        oFacturacion.TCMPDV = olOperaciones.Item(intCont).TCMPDV
    '        oFacturacion.PSCDVSN = olOperaciones.Item(intCont).CDVSN
    '        oFacturacion.PSCCMPN = olOperaciones.Item(intCont).CCMPN
    '        oFacturacion.CCLNFC = olOperaciones.Item(intCont).CCLNFC
    '        oFacturacion.CPLNDV = olOperaciones.Item(intCont).CPLNDV
    '        oFacturacion.CMNDA1 = olOperaciones.Item(intCont).CMNDA1

    '        oFacturacion.CCLNOP = olOperaciones.Item(intCont).CCLNT 'Desarrollador 3 JD

    '        'oFacturacion.CCNTCS = Val(olOperaciones.Item(intCont).CCNTCS)

    '        If oFacturacion.CCLNFC <> dblCCLNFC And dblCCLNFC <> 0 Then
    '            MessageBox.Show("No puede generar la factura por que las operaciones seleccionadas " & Chr(10) & " cuentan con diferentes Clientes a Facturar", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '            Exit Sub
    '        End If
    '        dblCCLNFC = oFacturacion.CCLNFC
    '        If Cant = 0 Then Moneda = olOperaciones.Item(intCont).TSGNMN
    '        If Moneda <> olOperaciones.Item(intCont).TSGNMN Then
    '            MessageBox.Show("No puede generar con diferentes monedas", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '            Exit Sub
    '        End If
    '        Moneda = olOperaciones.Item(intCont).TSGNMN

    '        If intCont = 0 Then
    '            primerRegion = olOperaciones.Item(intCont).CRGVTA
    '        End If
    '        If olOperaciones.Item(intCont).CRGVTA <> primerRegion Then
    '            MessageBox.Show("No puede generar con diferentes Regiones de Venta ", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '            Exit Sub
    '        End If


    '        'If Not olOperaciones.Item(intCont).TIPO = "1" Then
    '        '    DtRegionVenta = oFacturaNeg.Lista_Region_Venta_X_Operacion(oFacturacion)

    '        '    If DtRegionVenta.Rows.Count = 0 Then
    '        '        blRegion = False
    '        '        strConsistencia += oFacturacion.NOPRCN & System.Environment.NewLine
    '        '    Else
    '        '        If strRegionVenta <> DtRegionVenta.Rows(0).Item("CRGVTA") And strRegionVenta <> "" Then
    '        '            MessageBox.Show("No puede generar con diferentes Regiones de Venta ", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        '            Exit Sub
    '        '        End If
    '        '    End If
    '        'Else

    '        '    If Cant = 0 Then strRegionVenta = olOperaciones.Item(intCont).CRGVTA
    '        '    If strRegionVenta = olOperaciones.Item(intCont).CRGVTA Then
    '        '        If strRegionVenta.Trim.Length = 0 Then
    '        '            blRegion = False
    '        '            strConsistencia += oFacturacion.NSECFC & System.Environment.NewLine
    '        '        Else
    '        '            If strRegionVenta <> olOperaciones.Item(intCont).CRGVTA Then
    '        '                MessageBox.Show("No puede generar con diferentes Regiones de Venta ", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        '                Exit Sub
    '        '            End If
    '        '        End If
    '        '    End If
    '        '    strRegionVenta = olOperaciones.Item(intCont).CRGVTA
    '        '    oFacturacion.CRGVTA = strRegionVenta
    '        'End If
    '        oFacturacion.CRGVTA = primerRegion
    '        mListaFacturas.Add(oFacturacion)
    '        Cant += 1
    '    Next intCont

    '    If blRegion = False And Cant > 1 Then
    '        MessageBox.Show("La Operacion " & vbCrLf & strConsistencia & "tiene region venta anulada", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        Exit Sub
    '    End If
    '    If mListaFacturas.Count > 0 Then
    '        'Validamos si el Usuario Tiene Permisos paara Facturar
    '        'oFiltro = New SOLMIN_CTZ.Entidades.Filtro
    '        oFiltro = New Hashtable
    '        'oFiltro.Parametro1 = mListaFacturas(0).PSCCMPN 'strCodCom
    '        'oFiltro.Parametro2 = mListaFacturas(0).PSCDVSN 'strCodDiv
    '        mListaFacturas(0).PSCTPDCI = "LE"
    '        'oFiltro.Parametro10 = mListaFacturas(0).PSCTPDCI
    '        Dim oDtGiro As DataTable
    '        oFiltro("CCMPN") = mListaFacturas(0).PSCCMPN 'strCodCom
    '        oFiltro("CDVSN") = mListaFacturas(0).PSCDVSN 'strCodDiv
    '        'lobjParams.Add("PSCCMPN", pobjFiltro("CCMPN"))
    '        'lobjParams.Add("PSCDVSN", pobjFiltro("CDVSN"))
    '        oDtGiro = oFacturaNeg.Lista_Giro_Negocio(oFiltro)
    '        If oDtGiro.Rows.Count > 0 Then
    '            objfrmVFactura = New frmGenararFactura(mListaFacturas)
    '            objfrmVFactura.MdiParent = Me.Parent.Parent
    '            objfrmVFactura.WindowState = FormWindowState.Maximized
    '            objfrmVFactura.Show()
    '        Else
    '            MessageBox.Show("Usted no tiene Acceso a facturar", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        End If
    '    End If
    'End Sub

    Private Sub LlamarVistaPrevia(ByVal olOperaciones As System.Collections.Generic.List(Of Ransa.Controls.ServicioOperacion.Servicio_BE), ByVal intTipo As Integer)

        Dim intCont As Integer
        Dim strRegionVenta As String = String.Empty
        Dim mListaFacturas As New List(Of SOLMIN_CTZ.Entidades.FacturaSIL)
        Dim oFacturaNeg As New SOLMIN_CTZ.NEGOCIO.clsFactura
        Dim DtRegionVenta As New DataTable
        Dim objfrmVFactura As frmGenararFactura
        Dim Moneda As String = String.Empty
        Dim dblCCLNFC As Double = 0
        Dim Cant As Integer = 0
        Dim blRegion As Boolean = True
        Dim strConsistencia As String = String.Empty
        Dim oDt As DataTable
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

            '=============Si es de tipo 1  se genera por tipo de revision else por tipo Operacion===========
            If Not olOperaciones.Item(intCont).TIPO = "1" Then
                oFacturacion.NOPRCN = olOperaciones.Item(intCont).NOPRCN
                oFacturacion.NSECFC = 0
            Else
                oFacturacion.NOPRCN = 0
                oFacturacion.NSECFC = olOperaciones.Item(intCont).NSECFC
            End If


            oFacturacion.TCMPDV = olOperaciones.Item(intCont).TCMPDV
            oFacturacion.PSCDVSN = olOperaciones.Item(intCont).CDVSN
            oFacturacion.PSCCMPN = olOperaciones.Item(intCont).CCMPN
            oFacturacion.CCLNFC = olOperaciones.Item(intCont).CCLNFC
            oFacturacion.CPLNDV = olOperaciones.Item(intCont).CPLNDV
            oFacturacion.CMNDA1 = olOperaciones.Item(intCont).CMNDA1

            oFacturacion.CCLNOP = olOperaciones.Item(intCont).CCLNT 'Desarrollador 3 JD

            'oFacturacion.CCNTCS = Val(olOperaciones.Item(intCont).CCNTCS)

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
            Moneda = olOperaciones.Item(intCont).TSGNMN


            If intCont = 0 Then
                primerRegion = olOperaciones.Item(intCont).CRGVTA
            End If
            If olOperaciones.Item(intCont).CRGVTA <> primerRegion Then
                MessageBox.Show("No puede generar con diferentes Regiones de Venta ", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            'If Not olOperaciones.Item(intCont).TIPO = "1" Then
            '    DtRegionVenta = oFacturaNeg.Lista_Region_Venta_X_Operacion(oFacturacion)

            '    If DtRegionVenta.Rows.Count = 0 Then
            '        blRegion = False
            '        strConsistencia += oFacturacion.NOPRCN & System.Environment.NewLine
            '    Else
            '        If strRegionVenta <> DtRegionVenta.Rows(0).Item("CRGVTA") And strRegionVenta <> "" Then
            '            MessageBox.Show("No puede generar con diferentes Regiones de Venta ", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '            Exit Sub
            '        End If
            '    End If
            'Else

            '    If Cant = 0 Then strRegionVenta = olOperaciones.Item(intCont).CRGVTA
            '    If strRegionVenta = olOperaciones.Item(intCont).CRGVTA Then
            '        If strRegionVenta.Trim.Length = 0 Then
            '            blRegion = False
            '            strConsistencia += oFacturacion.NSECFC & System.Environment.NewLine
            '        Else
            '            If strRegionVenta <> olOperaciones.Item(intCont).CRGVTA Then
            '                MessageBox.Show("No puede generar con diferentes Regiones de Venta ", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '                Exit Sub
            '            End If
            '        End If
            '    End If
            '    strRegionVenta = olOperaciones.Item(intCont).CRGVTA
            '    oFacturacion.CRGVTA = strRegionVenta
            'End If
            oFacturacion.CRGVTA = primerRegion
            mListaFacturas.Add(oFacturacion)
            Cant += 1
        Next intCont

        If blRegion = False And Cant > 1 Then
            MessageBox.Show("La Operacion " & vbCrLf & strConsistencia & "tiene region venta anulada", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If mListaFacturas.Count > 0 Then
            'Validamos si el Usuario Tiene Permisos paara Facturar
            'oFiltro = New SOLMIN_CTZ.Entidades.Filtro
            oFiltro = New Hashtable
            'oFiltro.Parametro1 = mListaFacturas(0).PSCCMPN 'strCodCom
            'oFiltro.Parametro2 = mListaFacturas(0).PSCDVSN 'strCodDiv
            mListaFacturas(0).PSCTPDCI = "RU"
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

    'Private Sub LlamarVistaPreviaParteTransferencia(ByVal olOperaciones As System.Collections.Generic.List(Of Ransa.Controls.ServicioOperacion.Servicio_BE), ByVal intTipo As Integer)
    '    Dim intCont As Integer
    '    Dim strRegionVenta As String = String.Empty
    '    Dim mListaFacturas As New List(Of SOLMIN_CTZ.Entidades.FacturaSIL)
    '    Dim oFacturaNeg As New SOLMIN_CTZ.NEGOCIO.clsFactura
    '    Dim DtRegionVenta As New DataTable
    '    Dim objfrmVFactura As frmGenararFacturaElectronica
    '    Dim Moneda As String = String.Empty
    '    Dim dblCCLNFC As Double = 0
    '    Dim Cant As Integer = 0
    '    Dim blRegion As Boolean = True
    '    Dim strConsistencia As String = String.Empty
    '    Dim oDt As DataTable
    '    'Dim oFiltro As New SOLMIN_CTZ.Entidades.Filtro
    '    Dim oFiltro As New Hashtable
    '    Dim primerRegion As String = ""
    '    For intCont = 0 To olOperaciones.Count - 1
    '        'oFiltro.Parametro1 = "100" 'tipo cambio dolares
    '        'oFiltro.Parametro2 = Format(Now, "yyyyMMdd")
    '        'oDt = oFacturaNeg.Lista_Tipo_Cambio(oFiltro)
    '        'If oDt.Rows.Count = 0 Then
    '        '    MessageBox.Show("No se puede generar Parte Transferencia por no existir Tipo de cambio a la fecha ", "Tipo de cambio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        '    Exit Sub
    '        'End If
    '        Dim oFacturacion As New SOLMIN_CTZ.Entidades.FacturaSIL
    '        oFacturacion.TIPOFACTURA = intTipo

    '        '=============Si es de tipo 1  se genera por tipo de revision else por tipo Operacion===========
    '        If Not olOperaciones.Item(intCont).TIPO = "1" Then
    '            oFacturacion.NOPRCN = olOperaciones.Item(intCont).NOPRCN
    '            oFacturacion.NSECFC = 0
    '        Else
    '            oFacturacion.NOPRCN = 0
    '            oFacturacion.NSECFC = olOperaciones.Item(intCont).NSECFC
    '        End If

    '        oFacturacion.TCMPDV = olOperaciones.Item(intCont).TCMPDV
    '        oFacturacion.PSCDVSN = olOperaciones.Item(intCont).CDVSN
    '        oFacturacion.PSCCMPN = olOperaciones.Item(intCont).CCMPN
    '        oFacturacion.CCLNFC = olOperaciones.Item(intCont).CCLNFC
    '        oFacturacion.CPLNDV = olOperaciones.Item(intCont).CPLNDV
    '        oFacturacion.CMNDA1 = olOperaciones.Item(intCont).CMNDA1

    '        'oFacturacion.CCNTCS = Val(olOperaciones.Item(intCont).CCNTCS)

    '        If oFacturacion.CCLNFC <> dblCCLNFC And dblCCLNFC <> 0 Then
    '            MessageBox.Show("No puede generar la factura por que las operaciones seleccionadas " & Chr(10) & " cuentan con diferentes Clientes a Facturar", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '            Exit Sub
    '        End If
    '        dblCCLNFC = oFacturacion.CCLNFC
    '        If Cant = 0 Then Moneda = olOperaciones.Item(intCont).TSGNMN
    '        If Moneda <> olOperaciones.Item(intCont).TSGNMN Then
    '            MessageBox.Show("No puede generar con diferentes monedas", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '            Exit Sub
    '        End If
    '        Moneda = olOperaciones.Item(intCont).TSGNMN

    '        If intCont = 0 Then
    '            primerRegion = olOperaciones.Item(intCont).CRGVTA
    '        End If
    '        If olOperaciones.Item(intCont).CRGVTA <> primerRegion Then
    '            MessageBox.Show("No puede generar con diferentes Regiones de Venta ", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '            Exit Sub
    '        End If

    '        'If Not olOperaciones.Item(intCont).TIPO = "1" Then
    '        '    DtRegionVenta = oFacturaNeg.Lista_Region_Venta_X_Operacion(oFacturacion)

    '        '    If DtRegionVenta.Rows.Count = 0 Then
    '        '        blRegion = False
    '        '        strConsistencia += oFacturacion.NOPRCN & System.Environment.NewLine
    '        '    Else
    '        '        If strRegionVenta <> DtRegionVenta.Rows(0).Item("CRGVTA") And strRegionVenta <> "" Then
    '        '            MessageBox.Show("No puede generar con diferentes Regiones de Venta ", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        '            Exit Sub
    '        '        End If
    '        '    End If
    '        'Else

    '        '    If Cant = 0 Then strRegionVenta = olOperaciones.Item(intCont).CRGVTA
    '        '    If strRegionVenta = olOperaciones.Item(intCont).CRGVTA Then
    '        '        If strRegionVenta.Trim.Length = 0 Then
    '        '            blRegion = False
    '        '            strConsistencia += oFacturacion.NSECFC & System.Environment.NewLine
    '        '        Else
    '        '            If strRegionVenta <> olOperaciones.Item(intCont).CRGVTA Then
    '        '                MessageBox.Show("No puede generar con diferentes Regiones de Venta ", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        '                Exit Sub
    '        '            End If
    '        '        End If
    '        '    End If
    '        '    strRegionVenta = olOperaciones.Item(intCont).CRGVTA
    '        '    oFacturacion.CRGVTA = strRegionVenta
    '        'End If
    '        oFacturacion.CRGVTA = primerRegion
    '        mListaFacturas.Add(oFacturacion)
    '        Cant += 1
    '    Next intCont

    '    If blRegion = False And Cant > 1 Then
    '        MessageBox.Show("La Operacion " & vbCrLf & strConsistencia & "tiene region venta anulada", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        Exit Sub
    '    End If
    '    If mListaFacturas.Count > 0 Then
    '        'Validamos si el Usuario Tiene Permisos paara Facturar
    '        'oFiltro = New SOLMIN_CTZ.Entidades.Filtro
    '        oFiltro = New Hashtable
    '        'oFiltro.Parametro1 = mListaFacturas(0).PSCCMPN 'strCodCom
    '        'oFiltro.Parametro2 = mListaFacturas(0).PSCDVSN 'strCodDiv
    '        mListaFacturas(0).PSCTPDCI = "PT"
    '        'oFiltro.Parametro10 = mListaFacturas(0).PSCTPDCI
    '        Dim oDtGiro As DataTable
    '        oFiltro("CCMPN") = mListaFacturas(0).PSCCMPN 'strCodCom
    '        oFiltro("CDVSN") = mListaFacturas(0).PSCDVSN 'strCodDiv




    '        oDtGiro = oFacturaNeg.Lista_Giro_Negocio(oFiltro)
    '        If oDtGiro.Rows.Count > 0 Then
    '            objfrmVFactura = New frmGenararFacturaElectronica(mListaFacturas, True)
    '            objfrmVFactura.MdiParent = Me.Parent.Parent
    '            objfrmVFactura.WindowState = FormWindowState.Maximized
    '            objfrmVFactura.Show()
    '        Else
    '            MessageBox.Show("Usted no tiene Acceso a facturar", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        End If
    '    End If
    'End Sub

    Private Sub frmOperacionConsolidada_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        UcServicioPorFacturar1.RealizarBusqueda()
    End Sub
End Class
