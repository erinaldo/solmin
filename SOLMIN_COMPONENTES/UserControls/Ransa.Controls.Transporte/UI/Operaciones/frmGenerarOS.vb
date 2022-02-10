Imports System.Windows.Forms
Imports Ransa.Utilitario

Public Class frmGenerarOS

    Private lobjEntidad As Operaciones.OrdenServicioTransporte

    Private _pUsuario As String
    Public Property pUsuario() As String
        Get
            Return _pUsuario
        End Get
        Set(ByVal value As String)
            _pUsuario = value
        End Set
    End Property

    Public Sub New(ByVal objEntidad As Operaciones.OrdenServicioTransporte)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        lobjEntidad = objEntidad
        CargarCombos()
        Me.txtCliente.CCMPN = objEntidad.CCMPN
        Me.txtCliente.pCargar(lobjEntidad.CCLNT)
        Me.ctbCentroCostoPropio.Codigo = 466
        Me.ctbCentroCostoTercero.Codigo = 467
        Me.ctbSectorGasto.Codigo = "M"

    End Sub


    Private Function VerificarMargen() As DataTable

        Dim objServicioMercaderia As New ServicioMercaderia_BLL
        Dim dtServicio As New DataTable
        Dim dtNegocio As New DataTable
        Dim CRGVTA As String = ""
        dtNegocio = objServicioMercaderia.ListaNegocioxCentroCosto(lobjEntidad.CCMPN, ctbCentroCostoPropio.Codigo)
        If dtNegocio.Rows.Count > 0 Then
            CRGVTA = ("" & dtNegocio.Rows(0)("CRGVTA")).ToString.Trim
        End If
        Dim MargenNegocio As Decimal = objServicioMercaderia.ListaMargenPemitidoxNegocio(lobjEntidad.CCMPN, CRGVTA)
        dtServicio = objServicioMercaderia.ListaServicioMercaderiaValidacion(lobjEntidad.CCMPN, lobjEntidad.NCTZCN, MargenNegocio)

        'dtServicio.Columns.Add("MONTOCOBRO_SOLES", Type.GetType("System.Decimal"))
        'dtServicio.Columns.Add("MONTOPAGO_SOLES", Type.GetType("System.Decimal"))
        'dtServicio.Columns.Add("MARGENPOR", Type.GetType("System.Decimal"))
        'dtServicio.Columns.Add("MARCA")

        'Dim HayServicioInfLimite As Boolean = False
        'For Each Item As DataRow In dtServicio.Rows
        '    'MONEDA DE COBRO 
        '    If Item("CMNTRN") = 1 Then 'SI ES SOLES
        '        Item("MONTOCOBRO_SOLES") = Item("ITRSRT")
        '    Else   ' SI ES DOLAR
        '        Item("MONTOCOBRO_SOLES") = Item("ITRSRT") * Item("TIPO_CAMBIO")
        '    End If
        '    'MONEDA DE PAGO
        '    If Item("CMNLQT") = 1 Then ' SI ESOLES
        '        Item("MONTOPAGO_SOLES") = Item("ILSFTR")
        '    Else  ' SI ES DOLARES
        '        Item("MONTOPAGO_SOLES") = Item("ILSFTR") * Item("TIPO_CAMBIO")
        '    End If
        '    'EVALUADO MARGEN CON RESPECTO AL COBRO
        '    If Item("MONTOCOBRO_SOLES") = 0 Then
        '        Item("MARGENPOR") = 0
        '    Else
        '        Item("MARGENPOR") = (Item("MONTOCOBRO_SOLES") - Item("MONTOPAGO_SOLES")) / Item("MONTOCOBRO_SOLES") * 100
        '        Item("MARGENPOR") = Math.Round(Item("MARGENPOR"), 2)
        '    End If
        '    If Item("MARGENPOR") < MargenNegocio Then
        '        Item("MARCA") = "X" 'MARGENES POR DEBAJO DE LO PERMITIDO
        '        OrdenServicioValidado = False
        '    Else
        '        Item("MARCA") = ""
        '    End If
        'Next
        'Dim drFueraLimite() As DataRow
        'drFueraLimite = dtServicio.Select("MARCA='X'")
        'HayServicioInfLimite = (drFueraLimite.Length > 0)
        'If HayServicioInfLimite = True Then
        '    msgVerificacion = "Solicite aprobación de O/S para activación."
        '    msgVerificacion = msgVerificacion & Chr(13) & "El margen(%) entre el cobrar y a pagar se encuentra"
        '    msgVerificacion = msgVerificacion & Chr(13) & "debajo del margen(%) permitido por el Negocio."
        'End If
        Return dtServicio
    End Function

    Private Function HayServiciosInferiorLimite(ByVal dtServicio As DataTable) As Boolean
        Dim drFueraLimite() As DataRow
        Dim HayServicioInfLimite As Boolean = False
        drFueraLimite = dtServicio.Select("MARCA='X'")
        HayServicioInfLimite = (drFueraLimite.Length > 0)
        Return HayServicioInfLimite
    End Function

    Private Sub ActualizarMargen(ByVal dtServicio As DataTable)
        Dim obeOrdenServicio As Operaciones.OrdenServicioTransporte
        Dim objOrdenServicio As New Operaciones.OrdenServicio_BLL
        Dim oHasVisitado As New Hashtable
        Dim Cod_Unico As String = ""
        For Each Item As DataRow In dtServicio.Rows
            If Item("MARCA") = "X" Then
                Cod_Unico = Item("NCTZCN") & "_" & Item("NCRRCT")
                If Not oHasVisitado.Contains(Cod_Unico) Then
                    oHasVisitado.Add(Cod_Unico, Cod_Unico)
                    obeOrdenServicio = New Operaciones.OrdenServicioTransporte
                    obeOrdenServicio.CCMPN = lobjEntidad.CCMPN
                    obeOrdenServicio.NCTZCN = Item("NCTZCN")
                    obeOrdenServicio.NCRRCT = Item("NCRRCT")
                    obeOrdenServicio.SESTOS = "" ' ESTADO POR CONFIRMAR(EN BLANCO)
                    obeOrdenServicio.CULUSA = _pUsuario
                    obeOrdenServicio.NTRMNL = HelpClass.NombreMaquina
                    objOrdenServicio.ActualizarEstadoOrdenServicio(obeOrdenServicio)
                End If
            End If
        Next
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Validar() Then
            Dim dtMargen As New DataTable
            Dim msgVerificacion As String = ""
            Dim msgError As String = ""
            Dim obeOrdenServicio As New Operaciones.OrdenServicioTransporte

            Dim objEntidad As New Hashtable
            Dim objNegocios As New Operaciones.OrdenServicio_BLL

            obeOrdenServicio.NCTZCN = lobjEntidad.NCTZCN
            obeOrdenServicio.CCLNT = lobjEntidad.CCLNT
            obeOrdenServicio.CCMPN = lobjEntidad.CCMPN
            obeOrdenServicio.CDVSN = lobjEntidad.CDVSN
            obeOrdenServicio.CPLNDV = lobjEntidad.CPLNDV
            obeOrdenServicio.CCNCST = ctbCentroCostoPropio.Codigo
            obeOrdenServicio.CCNCS1 = ctbCentroCostoTercero.Codigo
            Try
                msgVerificacion = objNegocios.VerificarConfiguracionOrdenServicio(obeOrdenServicio)
            Catch ex As Exception
                msgVerificacion = ""
                msgError = msgError & Chr(13) & ex.Message
            End Try
            If msgVerificacion.Length > 0 Then
                MessageBox.Show("No se puede Generar OS.Verificar:" & Chr(13) & msgVerificacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Try
                dtMargen = VerificarMargen()
                Dim HayServicioInfLimite As Boolean = False
                HayServicioInfLimite = HayServiciosInferiorLimite(dtMargen)

                If HayServicioInfLimite = True Then
                    msgVerificacion = "Solicite aprobación de O/S para activación."
                    msgVerificacion = msgVerificacion & Chr(13) & "El margen(%) entre el cobrar y a pagar se encuentra"
                    msgVerificacion = msgVerificacion & Chr(13) & "debajo del margen(%) permitido por el Negocio."
                End If

            Catch ex As Exception
                msgError = ex.Message
            End Try

            GenerarOS()

            Try
                ActualizarMargen(dtMargen)
            Catch ex As Exception
                msgError = msgError & Chr(13) & ex.Message
            End Try

            msgError = msgError.Trim
            If msgError.Length > 0 Then
                MessageBox.Show(msgError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            If msgVerificacion.Length > 0 Then
                MessageBox.Show(msgVerificacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            'GenerarOSxDetalleCotizacion()
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Function Validar() As Boolean
        Dim strError As String = "DEBE DE INGRESAR: " & Chr(13)

        If Me.txtCliente.pCodigo = 0 Then
            strError += "* CLIENTE FACTURACION" & Chr(13)
        End If
        If Me.ctbSectorGasto.NoHayCodigo Then
            strError += "* SECTRO X GASTO" & Chr(13)
        End If
        If Me.ctbCentroCostoPropio.NoHayCodigo Then
            strError += "* CENTRO COSTO PROPIO" & Chr(13)
        End If
        If Me.ctbCentroCostoTercero.NoHayCodigo Then
            strError += "* CENTRO COSTO TERCERO" & Chr(13)
        End If
        If strError.Trim.Length > 17 Then
            HelpClass.MsgBox(strError, MessageBoxIcon.Warning)
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub CargarCombos()
        Dim objNegocioSectorXGastos As New SectorXGastos_BLL()
        With Me.ctbSectorGasto
            .DataSource = objNegocioSectorXGastos.Lista_SectorXGastos
            .KeyField = "COD"
            .ValueField = "DES"
            .DataBind()
        End With

        Dim objNegociosCentroCosto As New mantenimiento.CentroCosto_BLL()
        Dim objEntidad As New mantenimientos.CentroCosto
        objEntidad.CCMPN = lobjEntidad.CCMPN
        Dim objTabla As DataTable = HelpClass.GetDataSetNative(objNegociosCentroCosto.Listar_Centro_Costo(objEntidad))

        With ctbCentroCostoPropio
            .DataSource = objTabla.Copy
            .KeyField = "CCNTCS"
            .ValueField = "TCNTCS"
            .DataBind()
        End With

        With ctbCentroCostoTercero
            .DataSource = objTabla.Copy
            .KeyField = "CCNTCS"
            .ValueField = "TCNTCS"
            .DataBind()
        End With

    End Sub

    Private Sub GenerarOS()
        Dim objEntidad As New Hashtable
        Dim objNegocios As New Operaciones.OrdenServicio_BLL
        Try
            objEntidad.Add("PNNCTZCN", lobjEntidad.NCTZCN)
            objEntidad.Add("PNCCLNT", lobjEntidad.CCLNT)
            objEntidad.Add("PSCCMPN", lobjEntidad.CCMPN)
            objEntidad.Add("PSCDVSN", lobjEntidad.CDVSN)
            objEntidad.Add("PNCPLNDV", lobjEntidad.CPLNDV)
            objEntidad.Add("PNCCLNFC", txtCliente.pCodigo)
            objEntidad.Add("PSSSCGST", ctbSectorGasto.Codigo)
            objEntidad.Add("PNCCNCST", ctbCentroCostoPropio.Codigo)
            objEntidad.Add("PNCCNCS1", ctbCentroCostoTercero.Codigo)
            objEntidad.Add("PSCUSCRT", _pUsuario)
            objEntidad.Add("PNFCHCRT", HelpClass.TodayNumeric)
            objEntidad.Add("PNHRACRT", HelpClass.NowNumeric)
            objEntidad.Add("PSNTRMCR", HelpClass.NombreMaquina)

            Dim intResultado As Integer
            intResultado = objNegocios.GenerarOS(objEntidad)
            If intResultado = 0 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                HelpClass.ErrorMsgBox()
            End If
        Catch ex As Exception
        End Try
    End Sub

    'Private Sub GenerarOSxDetalleCotizacion()
    '    Dim objEntidad As New Hashtable
    '    Dim objNegocios As New OrdenServicio_BLL
    '    Try
    '        objEntidad.Add("PNNCTZCN", lobjEntidad.NCTZCN)
    '        objEntidad.Add("PNCCLNT", lobjEntidad.CCLNT)
    '        objEntidad.Add("PSCCMPN", lobjEntidad.CCMPN)
    '        objEntidad.Add("PSCDVSN", lobjEntidad.CDVSN)
    '        objEntidad.Add("PNCPLNDV", lobjEntidad.CPLNDV)
    '        objEntidad.Add("PNCCLNFC", txtCliente.pCodigo)
    '        objEntidad.Add("PSSSCGST", ctbSectorGasto.Codigo)
    '        objEntidad.Add("PNCCNCST", ctbCentroCostoPropio.Codigo)
    '        objEntidad.Add("PNCCNCS1", ctbCentroCostoTercero.Codigo)
    '        objEntidad.Add("PSCUSCRT", _pUsuario)
    '        objEntidad.Add("PNFCHCRT", HelpClass.TodayNumeric)
    '        objEntidad.Add("PNHRACRT", HelpClass.NowNumeric)
    '        objEntidad.Add("PSNTRMCR", HelpClass.NombreMaquina)
    '        objEntidad.Add("PNCRRCT", lobjEntidad.NCRRCT)

    '        Dim intResultado As Integer
    '        intResultado = Convert.ToInt32(objNegocios.GenerarOSxDetalleCotizacion(objEntidad))
    '        If intResultado = 0 Then
    '            Me.DialogResult = Windows.Forms.DialogResult.OK
    '        Else
    '            HelpClass.ErrorMsgBox()
    '        End If
    '    Catch ex As Exception
    '    End Try
    'End Sub
End Class
