Imports CrystalDecisions.CrystalReports.Engine
Imports RANSA.TYPEDEF.OrdenCompra
'Imports Ransa.TypeDef.Cliente
Imports RANSA.NEGO
Imports RANSA.NEGO.slnSOLMIN_SAT.Almacen
Imports RANSA.NEGO.slnSOLMIN_SAT.Almacen.Reportes
Imports RANSA.NEGO.slnSOLMIN_SAT.Despacho.Reportes
Imports Ransa.TypeDef.Reportes
Imports Ransa.TYPEDEF
Imports RANSA.Utilitario
Imports Ransa.Controls.Cliente

Public Class frmRptInventarioXUbicacion

#Region "Declaracion de Variables"

    Private strReporteseleccionado As String = ""
    Private _widthLeftRight As Int32
    Private objTemp As TipoDato_ResultaReporte
    Private strDetalleReporte As String = ""
    Public Lista As List(Of beCliente)
    Public objCliente As beCliente
    Private a As Boolean
    Private b As Boolean
    Private c As Boolean
    Private d As Boolean

    Private dsResult As New DataSet

#End Region

#Region "Procedimientos y funciones"

    Private Sub UcCompania_Cmb011_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles UcCompania_Cmb011.Seleccionar
        Try
            UcDivision_Cmb011.Compania = obeCompania.CCMPN_CodigoCompania
            UcDivision_Cmb011.Usuario = objSeguridadBN.pUsuario
            UcDivision_Cmb011.pActualizar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub UcDivision_Cmb011_Seleccionar(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles UcDivision_Cmb011.Seleccionar
        Try
            UcPLanta_Cmb011.CodigoDivision = obeDivision.CDVSN_CodigoDivision
            UcPLanta_Cmb011.CodigoCompania = obeDivision.CCMPN_CodigoCompania
            UcPLanta_Cmb011.Usuario = objSeguridadBN.pUsuario
            UcPLanta_Cmb011.pActualizar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function fblnValidaInformacion() As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado As Boolean = True
        If txtCliente2.Resultado IsNot Nothing Then

            Dim Estado As String = txtCliente2.Resultado.GetType().ToString

            If Estado = "Ransa.Utilitario.beCliente" Then
                Dim ListaS As String
                ListaS = CType(txtCliente2.Resultado, beCliente).Codigo
                If ListaS Is Nothing Then
                    tsbExportarExcel_1.Enabled = False
                    strMensajeError &= "Debe seleccionar un Cliente. " & vbNewLine
                End If
            Else
                Dim ListaS As New List(Of String)
                ListaS = CType(txtCliente2.Resultado, List(Of String))

                If ListaS Is Nothing Then
                    tsbExportarExcel_1.Enabled = False
                    strMensajeError &= "Debe seleccionar un Cliente. " & vbNewLine
                Else
                    If ListaS.Count = 0 Then
                        tsbExportarExcel_1.Enabled = False
                        strMensajeError &= "Debe seleccionar un Cliente. " & vbNewLine
                    End If
                End If

            End If
        Else
            strMensajeError &= "Debe seleccionar un Cliente. " & vbNewLine

        End If
        If strMensajeError <> "" Then
            blnResultado = False
            MessageBox.Show(strMensajeError, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return blnResultado
    End Function

    Sub pGenerarReporte()
        Dim objAppConfig As cAppConfig = New cAppConfig


        If Me.rbtOrdenDeCompra.Checked Then

            Call pReporteInventarioAlmacenOc()
        ElseIf rbtItem.Checked Then
            Call pReporteInventarioAlmacenItem()
        Else
            pReporteInventarioAlmacenSubItem()
        End If

        strDetalleReporte = "Inventario de Almacén"

        objAppConfig.ConfigType = 1
        'objAppConfig.SetValue("RepRecepcionPorAlmacenClienteCodigo", txtCliente.pCodigo)
        objAppConfig = Nothing
    End Sub

    Private Sub OcultarModelo04(ByVal Estado As Boolean)
        Modelo04ToolStripMenuItem.Visible = Estado
        Modelo05GPToolStripMenuItem.Visible = Estado
        Modelo06PERENCOToolStripMenuItem.Visible = Estado
        Modelo04BultoXPedidoToolStripMenuItem.Visible = Estado 'CSR-HUNDRED
    End Sub

    Private Function ListaCodigoClientes() As String
        Dim strCadDocumentos As String = ""
        Dim ListaS As New List(Of String)
        Dim Est As String = txtCliente2.Resultado.GetType.ToString
        ListaS = CType(txtCliente2.Resultado, List(Of String))
        For Each i As String In ListaS
            strCadDocumentos += i & ","
        Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos
    End Function

    Private Sub pReporteInventarioAlmacenSubItem()
        Dim dtTemp As DataTable = Nothing
        Dim obeFiltro As New beFiltrosDespachoPorAlmacen
        Dim obrReporteAT As New brReporteAT
        Dim Est As String = txtCliente2.Resultado.GetType.ToString
        With obeFiltro
            '.PNCCLNT = txtCliente.pCodigo
            If Est = "Ransa.Utilitario.beCliente" Then
                .PSCCLNT = CType(txtCliente2.Resultado, beCliente).Codigo
            Else
                .PSCCLNT = ListaCodigoClientes()
            End If
            '.PSTCMPCL = txtCliente.pRazonSocial
            .PNFPROCE = dteFechaInventario.Value
            If txtUbicacionReferencial.Resultado IsNot Nothing Then
                .PSTUBRFR = CType(txtUbicacionReferencial.Resultado, beGeneral).PSTUBRFR
            Else
                .PSTUBRFR = ""
            End If
            .PSSTPING = "" & txtTipoMovimiento.Tag
            .PSCCMPN = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCDVSN = Me.UcDivision_Cmb011.Division
            .PNCPLNDV = Me.UcPLanta_Cmb011.Planta
            .PSSSNCRG = "" & Me.txtSentidoCarga.Tag & ""
        End With
        Dim objTemp2 As New TipoDato_ResultaReporte

        dsResult = obrReporteAT.frptInventarioAlmacen(obeFiltro)
        'dtTemp = obrReporteAT.frptInventarioAlmacen(obeFiltro)
        dtTemp = dsResult.Tables(0).Copy
        'añadido 11022014
        dtTemp.Columns.Remove("TPOOCM")
        dtTemp.Columns.Remove("TIPLIN")
        dtTemp.Columns.Remove("TRFRN")
        dtTemp.Columns.Remove("TCMAEM")


        If dtTemp.Rows.Count > 0 Then
            ' Generamos el Nuevo Tipo de Datos
            objTemp2.add_Table(dtTemp)
        End If
        objTemp = objTemp2
        dgInventarioUbicacionSubItem.AutoGenerateColumns = False
        dgInventarioUbicacionSubItem.DataSource = dtTemp
    End Sub

    Private Sub pReporteInventarioAlmacenItem()
        Dim dtTemp As DataTable = Nothing
        Dim obeFiltro As New beFiltrosDespachoPorAlmacen
        Dim obrReporteAT As New brReporteAT
        Dim Est As String = txtCliente2.Resultado.GetType.ToString
        With obeFiltro
            '.PNCCLNT = txtCliente.pCodigo
            If Est = "Ransa.Utilitario.beCliente" Then
                .PSCCLNT = CType(txtCliente2.Resultado, beCliente).Codigo
            Else
                .PSCCLNT = ListaCodigoClientes()
            End If
            '.PSTCMPCL = txtCliente.pRazonSocial
            .PNFPROCE = dteFechaInventario.Value
            If txtUbicacionReferencial.Resultado IsNot Nothing Then
                .PSTUBRFR = CType(txtUbicacionReferencial.Resultado, beGeneral).PSTUBRFR
            Else
                .PSTUBRFR = ""
            End If

            .PSSTPING = "" & txtTipoMovimiento.Tag
            .PSCCMPN = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCDVSN = Me.UcDivision_Cmb011.Division
            .PNCPLNDV = Me.UcPLanta_Cmb011.Planta
            .PSSSNCRG = "" & Me.txtSentidoCarga.Tag & ""
            .PSTIPMAT = Me.ucTipoMaterial_Cmb01.CCMPRN_CodigoTipoMaterial 'CSR-HUNDRED-071016-MATERIALES-PELIGROSOS
            .PSCMATPE = Me.ucCondicion_Cmb01.CCMPRN_CodigoCondicion 'CSR-HUNDRED-071016-MATERIALES-PELIGROSOS
        End With
        Dim objTemp2 As New TipoDato_ResultaReporte
        'Dim rptTemp As ReportDocument
        dsResult = obrReporteAT.frptInventarioAlmacen(obeFiltro)
        'dtTemp = obrReporteAT.frptInventarioAlmacen(obeFiltro)
        dtTemp = dsResult.Tables(0).Copy

        'CSR-HUNDRED-071016-MATERIALES-PELIGROSOS-INICIO
        'CAMBIAR EL TIPO DE DATO DE UNA COLUMNA
        'For i As Integer = 0 To dtTemp.Rows.Count - 1
        '    dtTemp.Rows(i).Item("FCHCAD") = HelpClass.FechaNum_a_Fecha(dtTemp.Rows(i).Item("FCHCAD").ToString())
        'Next
        'CSR-HUNDRED-071016-MATERIALES-PELIGROSOS-FIN
        If dtTemp.Rows.Count > 0 Then
            objTemp2.add_Table(dtTemp)
        End If
        objTemp = objTemp2

        Dim oDtExcel As New DataTable
        oDtExcel = EliminarRepetidoItems(dtTemp)
        dgInventarioUbicacionItem.AutoGenerateColumns = False
        dgInventarioUbicacionItem.DataSource = oDtExcel
    End Sub

    Private Sub pReporteInventarioAlmacenOc()

        Dim dtTemp As DataTable = Nothing
        Dim obeFiltro As New beFiltrosDespachoPorAlmacen
        Dim obrReporteAT As New brReporteAT
        Dim Est As String = txtCliente2.Resultado.GetType.ToString
        With obeFiltro
            '.PNCCLNT = txtCliente.pCodigo
            If Est = "Ransa.Utilitario.beCliente" Then
                .PSCCLNT = CType(txtCliente2.Resultado, beCliente).Codigo
            Else
                .PSCCLNT = ListaCodigoClientes()
            End If
            '.PSTCMPCL = txtCliente.pRazonSocial
            .PNFPROCE = dteFechaInventario.Value
            If txtUbicacionReferencial.Resultado IsNot Nothing Then
                .PSTUBRFR = CType(txtUbicacionReferencial.Resultado, beGeneral).PSTUBRFR
            Else
                .PSTUBRFR = ""
            End If

            .PSSTPING = "" & txtTipoMovimiento.Tag
            .PSCCMPN = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCDVSN = Me.UcDivision_Cmb011.Division
            .PNCPLNDV = Me.UcPLanta_Cmb011.Planta
            .PSSSNCRG = "" & Me.txtSentidoCarga.Tag & ""
        End With
        Dim objTemp2 As New TipoDato_ResultaReporte
        dsResult = obrReporteAT.frptInventarioAlmacen(obeFiltro)
        'dtTemp = obrReporteAT.frptInventarioAlmacen(obeFiltro)
        dtTemp = dsResult.Tables(0).Copy
        'añadido 11022014
        dtTemp.Columns.Remove("TPOOCM")
        dtTemp.Columns.Remove("TIPLIN")
        dtTemp.Columns.Remove("TRFRN")
        dtTemp.Columns.Remove("TCMAEM")


        If dtTemp.Rows.Count > 0 Then
            objTemp2.add_Table(dtTemp)
        End If
        objTemp = objTemp2
        Dim oDtExcel As New DataTable
        oDtExcel = EliminarRepetidoOC(dtTemp)
        dgInventarioUbicacionOC.AutoGenerateColumns = False
        dgInventarioUbicacionOC.DataSource = oDtExcel
    End Sub

    Private Function EliminarRepetidoOC(ByVal dtTemp As DataTable) As DataTable
        dtTemp.Select("", "CREFFW ASC")
        For i As Integer = dtTemp.Rows.Count - 1 To 1 Step -1
            If dtTemp.Rows(i).Item("CREFFW").ToString.Trim.Equals(dtTemp.Rows(i - 1).Item("CREFFW").ToString.Trim) And dtTemp.Rows(i).Item("CCLNT").ToString.Trim.Equals(dtTemp.Rows(i - 1).Item("CCLNT").ToString.Trim) Then
                dtTemp.Rows.RemoveAt(i)
            End If
        Next
        Return dtTemp
    End Function

    Private Sub ExportarExcel(ByVal intTipo As Integer)
        'Try
        Dim oDtExcel As New DataTable
        Dim strTitulo As String = ""
        'strTitulo = Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial
        oDtExcel = objTemp.Tables(0)

        Select Case intTipo
            Case 1
                If Me.rbtOrdenDeCompra.Checked Then
                    oDtExcel = objTemp.Tables(0).Copy
                    oDtExcel = EliminarRepetido(oDtExcel)
                    ExportarExcelOC1(oDtExcel, strTitulo, objTemp.Tables(0))
                ElseIf rbtItem.Checked Then
                    oDtExcel = EliminarRepetidoItems(oDtExcel)
                    ExportarExcelItem_1(oDtExcel, strTitulo, objTemp.Tables(0))
                Else
                    ExportarExcelSubItem_1(oDtExcel, strTitulo, objTemp.Tables(0))
                End If
            Case 2
                If Me.rbtOrdenDeCompra.Checked Then
                    ExportarExcelOC2(oDtExcel, strTitulo, objTemp.Tables(0))
                ElseIf rbtItem.Checked Then
                    ExportarExcelItem_2(oDtExcel, strTitulo, objTemp.Tables(0))
                Else
                    ExportarExcelSubItem_2(oDtExcel, strTitulo, objTemp.Tables(0))
                End If

            Case 3
                If Me.rbtOrdenDeCompra.Checked Then
                    oDtExcel = EliminarRepetido(oDtExcel)
                    ExportarExcelOC3(oDtExcel, strTitulo, objTemp.Tables(0))
                ElseIf rbtItem.Checked Then
                    ExportarExcelItem_3(oDtExcel, strTitulo, objTemp.Tables(0))

                Else
                    ExportarExcelSubItem_3(oDtExcel, strTitulo, objTemp.Tables(0))
                End If


            Case 4
                If Me.rbtOrdenDeCompra.Checked Then
                    oDtExcel = objTemp.Tables(0).Copy
                    oDtExcel = EliminarRepetido(oDtExcel)
                    ExportarExcelOC4(oDtExcel, strTitulo, objTemp.Tables(0))
                ElseIf rbtItem.Checked Then
                    oDtExcel = EliminarRepetidoItems(oDtExcel)
                    ExportarExcelItem_4(oDtExcel, strTitulo, objTemp.Tables(0))
                Else
                    ExportarExcelSubItem_4(oDtExcel, strTitulo, objTemp.Tables(0))
                End If

                'CSR-HUNDRED-INICIO
            Case 5

                Dim dtTemp As DataTable = Nothing
                Dim obrReporteAT As New brReporteAT
                Dim obeFiltro As New beFiltrosDespachoPorAlmacen
                Dim Est As String = txtCliente2.Resultado.GetType.ToString
                With obeFiltro

                    If Est = "Ransa.Utilitario.beCliente" Then
                        .PSCCLNT = CType(txtCliente2.Resultado, beCliente).Codigo
                    Else
                        .PSCCLNT = ListaCodigoClientes()
                    End If
                    '.PSTCMPCL = txtCliente.pRazonSocial
                    .PNFPROCE = dteFechaInventario.Value
                    If txtUbicacionReferencial.Resultado IsNot Nothing Then
                        .PSTUBRFR = CType(txtUbicacionReferencial.Resultado, beGeneral).PSTUBRFR
                    Else
                        .PSTUBRFR = ""
                    End If

                    .PSSTPING = "" & txtTipoMovimiento.Tag
                    .PSCCMPN = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
                    .PSCDVSN = Me.UcDivision_Cmb011.Division
                    .PNCPLNDV = Me.UcPLanta_Cmb011.Planta
                    .PSSSNCRG = "" & Me.txtSentidoCarga.Tag & ""
                End With

                dtTemp = obrReporteAT.ObtenerBultoInventarioXPedido(obeFiltro)

                If Me.rbtItem.Checked Then
                    oDtExcel = EliminarRepetidoItems(dtTemp)
                    ExportarExcelItem_5(oDtExcel, strTitulo, objTemp.Tables(0))
                End If
                'CSR-HUNDRED-101016-MATERIALES-PELIGROSOS-INICIO
            Case 6

                If rbtItem.Checked Then
                    'ExportarExcel_ModeloMatpel(oDtExcel, strTitulo, objTemp.Tables(0))
                    ExportarExcel_ModeloMatpel_v2(oDtExcel, strTitulo, objTemp.Tables(0))
                End If

            Case 7

                If rbtItem.Checked Then
                    'ExportarExcel_ModeloMatpel(oDtExcel, strTitulo, objTemp.Tables(0))
                    ExportarExcel_ModeloMatpel_Dimensiones(oDtExcel, strTitulo, objTemp.Tables(0))
                End If

                'CSR-HUNDRED-101016-MATERIALES-PELIGROSOS-FIN
        End Select
        'CSR-HUNDRED-FIN

        'Catch : End Try


    End Sub

    Private Function EliminarRepetidoItems(ByVal dtTemp As DataTable) As DataTable
        dtTemp.Select("", "CCLNT, CREFFW ,CIDPAQ  ASC")
        For i As Integer = dtTemp.Rows.Count - 1 To 1 Step -1
            If dtTemp.Rows(i).Item("CREFFW").ToString.Trim.Equals(dtTemp.Rows(i - 1).Item("CREFFW").ToString.Trim) And dtTemp.Rows(i).Item("CIDPAQ").ToString.Trim.Equals(dtTemp.Rows(i - 1).Item("CIDPAQ").ToString.Trim) And dtTemp.Rows(i).Item("CCLNT").ToString.Trim.Equals(dtTemp.Rows(i - 1).Item("CCLNT").ToString.Trim) Then
                dtTemp.Rows.RemoveAt(i)
            End If
        Next
        Return dtTemp
    End Function
    Private Function GeneraDataTableSubItem(ByVal oDt As DataTable) As DataTable
        Dim bolBultosIguales As Boolean = False

        For i As Integer = oDt.Rows.Count - 1 To 1 Step -1
            bolBultosIguales = False

            If oDt.Rows(i).Item("CCLNT").ToString.Trim.Equals(oDt.Rows(i - 1).Item("CCLNT").ToString.Trim) And _
            oDt.Rows(i).Item("TCMPCL").ToString.Trim.Equals(oDt.Rows(i - 1).Item("TCMPCL").ToString.Trim) And _
            oDt.Rows(i).Item("TUBRFR").ToString.Trim.Equals(oDt.Rows(i - 1).Item("TUBRFR").ToString.Trim) And _
            oDt.Rows(i).Item("TIPO_ALMACEN").ToString.Trim.Equals(oDt.Rows(i - 1).Item("TIPO_ALMACEN").ToString.Trim) And _
            oDt.Rows(i).Item("ALMACEN").ToString.Trim.Equals(oDt.Rows(i - 1).Item("ALMACEN").ToString.Trim) And _
            oDt.Rows(i).Item("ZONA").ToString.Trim.Equals(oDt.Rows(i - 1).Item("ZONA").ToString.Trim) And _
            oDt.Rows(i).Item("CREFFW").ToString.Trim.Equals(oDt.Rows(i - 1).Item("CREFFW").ToString.Trim) And _
            oDt.Rows(i).Item("DESCRIPCION").ToString.Trim.Equals(oDt.Rows(i - 1).Item("DESCRIPCION").ToString.Trim) And _
            oDt.Rows(i).Item("FINGAL").ToString.Trim.Equals(oDt.Rows(i - 1).Item("FINGAL").ToString.Trim) And _
             oDt.Rows(i).Item("HORIDE").ToString.Trim.Equals(oDt.Rows(i - 1).Item("HORIDE").ToString.Trim) And _
            oDt.Rows(i).Item("QREFFW").ToString.Trim.Equals(oDt.Rows(i - 1).Item("QREFFW").ToString.Trim) And _
            oDt.Rows(i).Item("TIPBTO").ToString.Trim.Equals(oDt.Rows(i - 1).Item("TIPBTO").ToString.Trim) And _
            oDt.Rows(i).Item("QVLBTO").ToString.Trim.Equals(oDt.Rows(i - 1).Item("QVLBTO").ToString.Trim) And _
            oDt.Rows(i).Item("QPSOBL").ToString.Trim.Equals(oDt.Rows(i - 1).Item("QPSOBL").ToString.Trim) And _
            oDt.Rows(i).Item("QVLBTO").ToString.Trim.Equals(oDt.Rows(i - 1).Item("QVLBTO").ToString.Trim) And _
            oDt.Rows(i).Item("NORAGN").ToString.Trim.Equals(oDt.Rows(i - 1).Item("NORAGN").ToString.Trim) And _
            oDt.Rows(i).Item("TTINTC").ToString.Trim.Equals(oDt.Rows(i - 1).Item("TTINTC").ToString.Trim) And _
            oDt.Rows(i).Item("TPRVCL").ToString.Trim.Equals(oDt.Rows(i - 1).Item("TPRVCL").ToString.Trim) And _
            oDt.Rows(i).Item("QAROCP").ToString.Trim.Equals(oDt.Rows(i - 1).Item("QAROCP").ToString.Trim) And _
            oDt.Rows(i).Item("TNOMCOM").ToString.Trim.Equals(oDt.Rows(i - 1).Item("TNOMCOM").ToString.Trim) And _
            oDt.Rows(i).Item("NORCML").ToString.Trim.Equals(oDt.Rows(i - 1).Item("NORCML").ToString.Trim) And _
            oDt.Rows(i).Item("PARCIAL").ToString.Trim.Equals(oDt.Rows(i - 1).Item("PARCIAL").ToString.Trim) Then
                oDt.Rows(i).Item("CCLNT") = DBNull.Value
                oDt.Rows(i).Item("TCMPCL") = DBNull.Value
                oDt.Rows(i).Item("TUBRFR") = DBNull.Value
                oDt.Rows(i).Item("TIPO_ALMACEN") = DBNull.Value
                oDt.Rows(i).Item("ALMACEN") = DBNull.Value
                oDt.Rows(i).Item("ZONA") = DBNull.Value
                oDt.Rows(i).Item("CREFFW") = DBNull.Value
                oDt.Rows(i).Item("DESCRIPCION") = DBNull.Value
                oDt.Rows(i).Item("FINGAL") = DBNull.Value
                oDt.Rows(i).Item("HORIDE") = DBNull.Value
                oDt.Rows(i).Item("QREFFW") = DBNull.Value
                oDt.Rows(i).Item("TIPBTO") = DBNull.Value
                oDt.Rows(i).Item("QVLBTO") = DBNull.Value
                oDt.Rows(i).Item("QPSOBL") = DBNull.Value
                oDt.Rows(i).Item("QVLBTO") = DBNull.Value
                oDt.Rows(i).Item("NORAGN") = DBNull.Value
                oDt.Rows(i).Item("TTINTC") = DBNull.Value
                oDt.Rows(i).Item("TPRVCL") = DBNull.Value
                oDt.Rows(i).Item("QAROCP") = DBNull.Value
                oDt.Rows(i).Item("TNOMCOM") = DBNull.Value
                oDt.Rows(i).Item("NORCML") = DBNull.Value
                oDt.Rows(i).Item("PARCIAL") = DBNull.Value
                oDt.Rows(i).Item("IMPORTE") = DBNull.Value
                bolBultosIguales = True

            End If

            If bolBultosIguales And oDt.Rows(i).Item("NRITOC").ToString.Trim.Equals(oDt.Rows(i - 1).Item("NRITOC").ToString.Trim) And _
            oDt.Rows(i).Item("TCITCL").ToString.Trim.Equals(oDt.Rows(i - 1).Item("TCITCL").ToString.Trim) Then
                oDt.Rows(i).Item("NRITOC") = DBNull.Value
                oDt.Rows(i).Item("TCITCL") = DBNull.Value
                oDt.Rows(i).Item("TDITES") = DBNull.Value
                oDt.Rows(i).Item("IVUNIT") = DBNull.Value
                oDt.Rows(i).Item("QSLCNB") = DBNull.Value
                oDt.Rows(i).Item("NFACPR") = DBNull.Value
                oDt.Rows(i).Item("FFACPR") = DBNull.Value
                oDt.Rows(i).Item("TUNDIT") = DBNull.Value
                oDt.Rows(i).Item("QPEPQT") = DBNull.Value
                oDt.Rows(i).Item("QVOPQT") = DBNull.Value
                oDt.Rows(i).Item("NGRPRV") = DBNull.Value
                oDt.Rows(i).Item("TLUGEN") = DBNull.Value
                oDt.Rows(i).Item("SSNCRG") = DBNull.Value
                oDt.Rows(i).Item("DIAS") = DBNull.Value
                oDt.Rows(i).Item("MARRET") = DBNull.Value
            End If
        Next

        Return oDt

    End Function
    Private Function EliminarRepetido(ByVal dtTemp As DataTable) As DataTable

        Dim dblValor As Decimal = Decimal.Zero
        dtTemp.Select("", "CCLNT, TUBRFR, CREFFW  ASC")
        For i As Integer = dtTemp.Rows.Count - 1 To 1 Step -1
            If dtTemp.Rows(i).Item("CREFFW").ToString.Trim.Equals(dtTemp.Rows(i - 1).Item("CREFFW").ToString.Trim) Then
                dblValor = dblValor + dtTemp.Rows(i).Item("IMPORTE")
                dtTemp.Rows.RemoveAt(i)
            Else
                dblValor = dblValor + dtTemp.Rows(i).Item("IMPORTE")
                dtTemp.Rows(i).Item("IMPORTE") = dblValor
                dblValor = 0
            End If

            If i = 1 Then
                dblValor = dblValor + dtTemp.Rows(i - 1).Item("IMPORTE")
                dtTemp.Rows(i - 1).Item("IMPORTE") = dblValor
                dblValor = 0
            End If
        Next
        Return dtTemp
    End Function

    Private Function SumarDataTable(ByVal oDt As DataTable, ByVal strNombreColumna As String) As Decimal
        Dim decSuma As Decimal = 0
        For index As Integer = 0 To oDt.Rows.Count - 1
            decSuma = decSuma + oDt.Rows(index).Item(strNombreColumna)
        Next
        Return decSuma
    End Function

    Private Sub ExportarExcelOC1(ByVal oDtExcel As DataTable, ByVal strTitulo As String, ByVal oDtRe As DataTable)
        Dim oDt As New DataTable
        Dim oDtInv As New DataTable
        Dim oDtFiltro As New DataTable
        Dim oDtFiltro2 As New DataTable
        Dim oDtResumen As New DataTable
        Dim NPOI As New HelpClass_NPOI_SA
        Dim oDt2 As DataTable
        Dim strSentidoCarga As String = ""
        oDt = oDtExcel.Copy


        'Eliminamos datos de item
        oDt.Columns.Remove("NRITOC")
        oDt.Columns.Remove("TCITCL")
        'oDt.Columns.Remove("TDITES")
        oDt.Columns.Remove("IVUNIT")
        oDt.Columns.Remove("QSLCNB")
        oDt.Columns.Remove("TUNDIT")
        oDt.Columns.Remove("QPEPQT")
        oDt.Columns.Remove("QVOPQT")
        'MODIFICADO - comentado
        '------------------------------------
        'oDt.Columns.Remove("TIPO_ALMACEN")
        'oDt.Columns.Remove("ALMACEN")
        '-----------------------------------
        oDt.Columns.Remove("NORAGN")
        oDt.Columns.Remove("NFACPR")
        oDt.Columns.Remove("FFACPR")

        oDt.Columns.Remove("CIDPAQ")
        oDt.Columns.Remove("SBITOC")
        oDt.Columns.Remove("TCITCL1")
        oDt.Columns.Remove("TDITES1")
        oDt.Columns.Remove("QCNRCP")
        oDt.Columns.Remove("TNMMDT_ENVIO")
        oDt.Columns.Remove("TMRCTR")

        oDt.Columns.Remove("QMTALT")
        oDt.Columns.Remove("QMTANC")
        oDt.Columns.Remove("QMTLRG")

        'oDt.Columns("QMTALT").ColumnName = "ALTURA"
        'oDt.Columns("QMTANC").ColumnName = "ANCHO"
        'oDt.Columns("QMTLRG").ColumnName = "LARGO"

        Dim oDs As New DataSet
        oDt.Columns("CCLNT").ColumnName = "CLIENTE"
        oDt.Columns("TCMPCL").ColumnName = "RAZÓN SOCIAL"
        oDt.Columns("TUBRFR").ColumnName = "UBICACIÓN"
        oDt.Columns("CREFFW").ColumnName = "CODIGO  BULTO"
        oDt.Columns("FINGAL").ColumnName = "FECHA  INGRESO"
        oDt.Columns("HORIDE").ColumnName = "HORA INGRESO"

        oDt.Columns("QREFFW").ColumnName = "QTA  BULTO"
        oDt.Columns("TIPBTO").ColumnName = "TIPO"
        oDt.Columns("QPSOBL").ColumnName = "PESO  BULTO"
        'oDt.Columns("QMTALT").ColumnName = "ALTURA"
        'oDt.Columns("QMTANC").ColumnName = "ANCHO"
        'oDt.Columns("QMTLRG").ColumnName = "LARGO"
        oDt.Columns("QVLBTO").ColumnName = "VOL. BULTO"
        oDt.Columns("TTINTC").ColumnName = "ORIGEN"
        oDt.Columns("TPRVCL").ColumnName = "PROVEEDOR"
        oDt.Columns("QAROCP").ColumnName = "AREA BULTO"
        oDt.Columns("TNOMCOM").ColumnName = "COMPRADOR "
        oDt.Columns("NORCML").ColumnName = "ORDEN COMPRA"
        oDt.Columns("NGRPRV").ColumnName = "GUIA PROVEEDOR"
        oDt.Columns("TLUGEN").ColumnName = "LUGAR DE ENTREGA"
        oDt.Columns("SSNCRG").ColumnName = "SENTIDO DE ENTREGA"
        oDt.Columns("DIAS").ColumnName = "DIAS EN ALMACEN"
        oDt.Columns("MARRET").ColumnName = "CUSTODIA RETENCION"
        oDt.Columns("TDITES").ColumnName = "DESCRIPCIÓN PRIMER ITEM"

        Dim oDtv1 As DataView = New DataView(oDt)
        oDt2 = oDtv1.ToTable(True, "LUGAR DE ENTREGA")

        For intRows As Integer = 0 To oDt2.Rows.Count - 1
            oDtFiltro = SelectDataTable(oDt, "[LUGAR DE ENTREGA] = '" + oDt2.Rows(intRows).Item(0) + "'")
            oDtFiltro.TableName = NombreTabla(oDt2.Rows(intRows).Item(0).ToString.Trim)
            oDs.Tables.Add(oDtFiltro)
        Next

        '************
        Dim oDtv3 As DataView = New DataView(oDtRe)
        Dim oDtv2 As DataView = New DataView(oDtRe)
        Dim oDt1 As New DataTable
        Dim oDt4 As New DataTable
        Dim oDt3 As New DataTable
        'Dim oDtFiltro As New DataTable
        Dim oDr As DataRow

        oDt1 = oDtv3.ToTable(True, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA", "CREFFW", "QREFFW", "QPSOBL", "QVLBTO")
        oDt4 = oDtv2.ToTable(True, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA")
        Dim oDtv4 As DataView = New DataView(oDt4)
        oDtv4.Sort = "CCLNT, TIPO_ALMACEN ASC"
        oDt3 = oDtv4.ToTable(False, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA")
        oDtResumen.Columns.Add("TCMPCL1")
        oDtResumen.Columns.Add("TIPO_ALMACEN1")
        oDtResumen.Columns.Add("ALMACEN1")
        oDtResumen.Columns.Add("ZONA")
        oDtResumen.Columns.Add("QREFFW")
        oDtResumen.Columns.Add("QPSOBL")
        oDtResumen.Columns.Add("QVLBTO")

        For i As Integer = 0 To oDt3.Rows.Count - 1
            oDtFiltro2 = SelectDataTable(oDt1, "CCLNT = '" + oDt3.Rows(i).Item("CCLNT").ToString.Trim + "' AND TIPO_ALMACEN = '" + oDt3.Rows(i).Item("TIPO_ALMACEN") + "' AND ALMACEN = '" + oDt3.Rows(i).Item("ALMACEN") + "' AND ZONA = '" + oDt3.Rows(i).Item("ZONA") + "' ")
            oDr = oDtResumen.NewRow()
            oDr("TCMPCL1") = oDt3.Rows(i).Item("TCMPCL")
            oDr("TIPO_ALMACEN1") = oDt3.Rows(i).Item("TIPO_ALMACEN")
            oDr("ALMACEN1") = oDt3.Rows(i).Item("ALMACEN")
            oDr("ZONA") = oDt3.Rows(i).Item("ZONA")
            oDr("QREFFW") = SumarDataTable(oDtFiltro2, "QREFFW")
            oDr("QPSOBL") = SumarDataTable(oDtFiltro2, "QPSOBL")
            oDr("QVLBTO") = SumarDataTable(oDtFiltro2, "QVLBTO")
            oDtResumen.Rows.Add(oDr)
        Next

        oDtResumen.Columns("TCMPCL1").ColumnName = "RAZON SOCIAL"
        oDtResumen.Columns("TIPO_ALMACEN1").ColumnName = "TIPO ALMACEN"
        oDtResumen.Columns("ALMACEN1").ColumnName = "ALMACEN"
        oDtResumen.Columns("ZONA").ColumnName = "ZONA"
        oDtResumen.Columns("QREFFW").ColumnName = "INVENTARIO \n CANTIDAD"
        oDtResumen.Columns("QPSOBL").ColumnName = "INVENTARIO \n PESO"
        oDtResumen.Columns("QVLBTO").ColumnName = "INVENTARIO \n VOLUMEN"

        oDtResumen.TableName = "Resumen"
        oDs.Tables.Add(oDtResumen)
        '************
        If Me.txtSentidoCarga.Tag Is Nothing OrElse Me.txtSentidoCarga.Tag = "" Then
            strSentidoCarga = "TODOS"
        Else
            strSentidoCarga = Me.txtSentidoCarga.Text
        End If

        Dim strlTitulo As New List(Of String)
        'strlTitulo.Add("Cliente:\n" & Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial)
        strlTitulo.Add("Planta:\n" & Me.UcPLanta_Cmb011.DescripcionPlanta)
        If (Me.txtUbicacionReferencial.Tag Is Nothing OrElse Me.txtUbicacionReferencial.Tag = "") AndAlso Me.txtUbicacionReferencial.Text = "" Then
            strlTitulo.Add("Ubicación :\nTODOS")
        Else
            strlTitulo.Add("Ubicación :\n" & Me.txtUbicacionReferencial.Text)
        End If
        If Me.txtTipoMovimiento.Tag Is Nothing OrElse Me.txtTipoMovimiento.Tag = "" Then
            strlTitulo.Add("Tipo de Mov.:\nTODOS")
        Else
            strlTitulo.Add("Tipo de Mov.:\n" & Me.txtTipoMovimiento.Text)
        End If
        strlTitulo.Add("Sentido de Carga:\n" & strSentidoCarga)
        strlTitulo.Add("Fechas  de Inventario:\n" & Me.dteFechaInventario.Value.Date)

        'Suma 
        Dim listSuma As New Hashtable
        listSuma.Add("Suma01", 10)
        listSuma.Add("Suma02", 12)
        listSuma.Add("Suma03", 16)
        Dim oDtRes As New DataTable
        'oDtRes = 
        'oDtRes = oDtResumen.Select("ORDER BY TCMPCL1,TIPO_ALMACEN1,ALMACEN1,ZONA ASC")

        Dim listColComb As New List(Of String)
        listColComb.Add("TCMPCL1")
        listColComb.Add("TIPO_ALMACEN1")
        listColComb.Add("ALMACEN1")
        HelpClass.ExportExcelConTitulosAlmacen(oDs, Me.Text, strlTitulo, listSuma, listColComb)


        'Dim oDtv1 As DataView = New DataView(oDtRe)
        'Dim oDtv2 As DataView = New DataView(oDtRe)
        'Dim oDt1 As New DataTable
        'Dim oDt3 As New DataTable
        ''Dim oDtFiltro As New DataTable
        'Dim oDr As DataRow
        'Dim oDs As New DataSet
        'oDt1 = oDtv1.ToTable(True, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA", "CREFFW", "QREFFW", "QPSOBL", "QVLBTO")
        'oDt3 = oDtv2.ToTable(True, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA")

        'oDtResumen.Columns.Add("TCMPCL1", Type.GetType("System.String")).Caption = NPOI.FormatDato("RAZÓN SOCIAL", HelpClass_NPOI_SA.keyDatoTexto)
        'oDtResumen.Columns.Add("TIPO_ALMACEN1", Type.GetType("System.String")).Caption = NPOI.FormatDato("TIPO ALMACEN", HelpClass_NPOI_SA.keyDatoTexto)
        'oDtResumen.Columns.Add("ALMACEN1", Type.GetType("System.String")).Caption = NPOI.FormatDato("ALMACEN", HelpClass_NPOI_SA.keyDatoTexto)
        'oDtResumen.Columns.Add("ZONA", Type.GetType("System.String")).Caption = NPOI.FormatDato("ZONA", HelpClass_NPOI_SA.keyDatoTexto)
        'oDtResumen.Columns.Add("QREFFW", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("INGRESOS | CANTIDAD", HelpClass_NPOI_SA.keyDatoNumero)
        'oDtResumen.Columns.Add("QPSOBL", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("INGRESOS | PESO", HelpClass_NPOI_SA.keyDatoNumero)
        'oDtResumen.Columns.Add("QVLBTO", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("INGRESOS | VOLUMEN", HelpClass_NPOI_SA.keyDatoNumero)

        'For i As Integer = 0 To oDt3.Rows.Count - 1
        '    oDtFiltro = SelectDataTable(oDt1, "CCLNT = '" + oDt3.Rows(i).Item("CCLNT").ToString.Trim + "' AND TIPO_ALMACEN = '" + oDt3.Rows(i).Item("TIPO_ALMACEN") + "' AND ALMACEN = '" + oDt3.Rows(i).Item("ALMACEN") + "' AND ZONA = '" + oDt3.Rows(i).Item("ZONA") + "' ")
        '    oDr = oDtResumen.NewRow()
        '    oDr("TCMPCL1") = oDt3.Rows(i).Item("TCMPCL")
        '    oDr("TIPO_ALMACEN1") = oDt3.Rows(i).Item("TIPO_ALMACEN")
        '    oDr("ALMACEN1") = oDt3.Rows(i).Item("ALMACEN")
        '    oDr("ZONA") = oDt3.Rows(i).Item("ZONA")
        '    oDr("QREFFW") = SumarDataTable(oDtFiltro, "QREFFW")
        '    oDr("QPSOBL") = SumarDataTable(oDtFiltro, "QPSOBL")
        '    oDr("QVLBTO") = SumarDataTable(oDtFiltro, "QVLBTO")
        '    oDtResumen.Rows.Add(oDr)
        'Next

        'oDtInv.Columns.Add("CCLNT", Type.GetType("System.String")).Caption = NPOI.FormatDato("CLIENTE", HelpClass_NPOI_SA.keyDatoTexto)
        'oDtInv.Columns.Add("TCMPCL", Type.GetType("System.String")).Caption = NPOI.FormatDato("RAZÓN SOCIAL", HelpClass_NPOI_SA.keyDatoTexto)
        'oDtInv.Columns.Add("TUBRFR", Type.GetType("System.String")).Caption = NPOI.FormatDato("UBICACIÓN", HelpClass_NPOI_SA.keyDatoTexto)
        'oDtInv.Columns.Add("CREFFW", Type.GetType("System.String")).Caption = NPOI.FormatDato("CODIGO BULTO", HelpClass_NPOI_SA.keyDatoTexto)
        'oDtInv.Columns.Add("FINGAL", Type.GetType("System.String")).Caption = NPOI.FormatDato("FECHA INGRESO", HelpClass_NPOI_SA.keyDatoFecha)
        'oDtInv.Columns.Add("QREFFW", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("QTA  BULTO", HelpClass_NPOI_SA.keyDatoNumero)
        'oDtInv.Columns.Add("TIPBTO", Type.GetType("System.String")).Caption = NPOI.FormatDato("TIPO BULTO", HelpClass_NPOI_SA.keyDatoTexto)
        'oDtInv.Columns.Add("QPSOBL", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("PESO BULTO", HelpClass_NPOI_SA.keyDatoNumero)
        'oDtInv.Columns.Add("QMTALT", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("ALTURA", HelpClass_NPOI_SA.keyDatoNumero)
        'oDtInv.Columns.Add("QMTANC", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("ANCHO", HelpClass_NPOI_SA.keyDatoNumero)
        'oDtInv.Columns.Add("QMTLRG", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("LARGO", HelpClass_NPOI_SA.keyDatoNumero)
        'oDtInv.Columns.Add("QVLBTO", Type.GetType("System.Decimal")).Caption = NPOI.FormatDato("VOL. BULTO", HelpClass_NPOI_SA.keyDatoNumero)
        'oDtInv.Columns.Add("TTINTC", Type.GetType("System.String")).Caption = NPOI.FormatDato("ORIGEN", HelpClass_NPOI_SA.keyDatoTexto)
        'oDtInv.Columns.Add("TPRVCL", Type.GetType("System.String")).Caption = NPOI.FormatDato("PROVEEDOR", HelpClass_NPOI_SA.keyDatoTexto)
        'oDtInv.Columns.Add("QAROCP", Type.GetType("System.String")).Caption = NPOI.FormatDato("AREA DEL BULTO (MT2)", HelpClass_NPOI_SA.keyDatoTexto)
        'oDtInv.Columns.Add("TNOMCOM", Type.GetType("System.String")).Caption = NPOI.FormatDato("COMPRADOR", HelpClass_NPOI_SA.keyDatoTexto)
        'oDtInv.Columns.Add("NORCML", Type.GetType("System.String")).Caption = NPOI.FormatDato("N° O/C", HelpClass_NPOI_SA.keyDatoTexto)
        'oDtInv.Columns.Add("NGRPRV", Type.GetType("System.String")).Caption = NPOI.FormatDato("GUIA PROVEEDOR", HelpClass_NPOI_SA.keyDatoTexto)
        'oDtInv.Columns.Add("TLUGEN", Type.GetType("System.String")).Caption = NPOI.FormatDato("LUGAR DE ENTREGA", HelpClass_NPOI_SA.keyDatoTexto)
        'oDtInv.Columns.Add("SSNCRG", Type.GetType("System.String")).Caption = NPOI.FormatDato("SENTIDO DE ENTREGA", HelpClass_NPOI_SA.keyDatoTexto)
        'oDtInv.Columns.Add("DIAS", Type.GetType("System.Int32")).Caption = NPOI.FormatDato("DIAS EN ALMACEN", HelpClass_NPOI_SA.keyDatoNumero)
        'oDtInv.Columns.Add("MARRET", Type.GetType("System.String")).Caption = NPOI.FormatDato("CUSTODIA RETENCION", HelpClass_NPOI_SA.keyDatoTexto)
        'oDtInv.Columns.Add("TDITES", Type.GetType("System.String")).Caption = NPOI.FormatDato("DESCRIPCIÓN PRIMER ITEM", HelpClass_NPOI_SA.keyDatoTexto)

        'For Each oDrs As DataRow In oDt.Rows
        '    oDtInv.ImportRow(oDrs)
        'Next

        'Dim oDtv3 As DataView = New DataView(oDtInv)
        'oDt2 = oDtv3.ToTable(True, "TLUGEN")
        'Dim oListDtReport As New List(Of DataTable)
        'For intRows As Integer = 0 To oDt2.Rows.Count - 1
        '    oDtFiltro = SelectDataTable(oDt, "[TLUGEN] = '" + oDt2.Rows(intRows).Item(0) + "'")
        '    oDtFiltro.TableName = NombreTabla(oDt2.Rows(intRows).Item(0).ToString.Trim)
        '    oListDtReport.Add(oDtFiltro)

        'Next


        ''oDtInv.TableName = "InventarioPorUbicacion"
        'oDtResumen.TableName = "Resumen"
        'oListDtReport.Add(oDtResumen)
        'Dim strlTitulo2 As New List(Of String)
        'oListDtReport.Add(oDtResumen)
        'Dim LisFiltros As New List(Of SortedList)
        'Dim itemSortedList As SortedList
        'For i As Integer = 0 To oListDtReport.Count - 1
        '    strlTitulo2.Add("INVENTARIO POR UBICACIÓN")
        '    itemSortedList = New SortedList
        '    'itemSortedList.Add(itemSortedList.Count, "Cliente :| " & IIf(CType(txtCliente2.Resultado, beCliente).Codigo, "TODOS", ListaCodigoClientes))
        '    itemSortedList.Add(itemSortedList.Count, "Planta :| " & Me.UcPLanta_Cmb011.DescripcionPlanta)
        '    If (Me.txtUbicacionReferencial.Tag Is Nothing OrElse Me.txtUbicacionReferencial.Tag = "") AndAlso Me.txtUbicacionReferencial.Text = "" Then
        '        itemSortedList.Add(itemSortedList.Count, "Ubicación :| TODOS ")
        '    Else
        '        itemSortedList.Add(itemSortedList.Count, "Ubicación :| " & Me.txtUbicacionReferencial.Text)
        '    End If
        '    If Me.txtTipoMovimiento.Tag Is Nothing OrElse Me.txtTipoMovimiento.Tag = "" Then
        '        itemSortedList.Add(itemSortedList.Count, "Tipo de Mov. :| TODOS ")
        '    Else
        '        itemSortedList.Add(itemSortedList.Count, "Tipo de Mov. :| " & Me.txtTipoMovimiento.Text)
        '    End If
        '    itemSortedList.Add(itemSortedList.Count, "Sentido de Carga :| " & strSentidoCarga)
        '    itemSortedList.Add(itemSortedList.Count, "Fechas  de Inventario :| " & Me.dteFechaInventario.Value.Date)
        '    LisFiltros.Add(itemSortedList)
        'Next
        '' strlTitulo2.Add("INVENTARIO POR UBICACIÓN")
        ''strlTitulo2.Add("RESUMEN INVENTARIO POR UBICACIÓN")

        'Dim ListFilDupl As New List(Of String)
        'Dim CombCol As String = "TCMPCL1:TCMPCL1/1"
        'CombCol = CombCol & "|TIPO_ALMACEN1:TCMPCL1,TIPO_ALMACEN1/1"
        'CombCol = CombCol & "|ALMACEN1:TCMPCL1,TIPO_ALMACEN1,ALMACEN1/1"
        'ListFilDupl.Add("")
        'ListFilDupl.Add(CombCol)

        'Dim listSuma As New Hashtable
        ''listSuma.Add("Suma01", 6)
        'listSuma.Add("Suma02", 8)
        ''listSuma.Add("Suma03", 9)

        'NPOI.ExportExcelGeneralReleaseMultiple(oListDtReport, strlTitulo2, Nothing, LisFiltros, 0, ListFilDupl, listSuma)
    End Sub

    Private Sub ExportarExcelOC2(ByVal oDtExcel As DataTable, ByVal strTitulo As String, ByVal oDtRe As DataTable)
        Dim oDt As New DataTable
        Dim oDtFiltro As New DataTable
        Dim oDt2 As DataTable
        Dim oDtResumen As New DataTable
        Dim strSentidoCarga As String = ""
        oDt = oDtExcel.Copy


        'Eliminamos datos de item
        oDt.Columns.Remove("NRITOC")
        oDt.Columns.Remove("TCITCL")
        oDt.Columns.Remove("TDITES")
        oDt.Columns.Remove("IVUNIT")
        oDt.Columns.Remove("QSLCNB")
        oDt.Columns.Remove("TUNDIT")
        oDt.Columns.Remove("QPEPQT")
        oDt.Columns.Remove("QVOPQT")
        oDt.Columns.Remove("NORAGN")
        oDt.Columns.Remove("NFACPR")
        oDt.Columns.Remove("FFACPR")

        oDt.Columns.Remove("CIDPAQ")
        oDt.Columns.Remove("SBITOC")
        oDt.Columns.Remove("TCITCL1")
        oDt.Columns.Remove("TDITES1")
        oDt.Columns.Remove("QCNRCP")
        oDt.Columns.Remove("TNMMDT_ENVIO")
        oDt.Columns.Remove("TMRCTR")

        oDt.Columns.Remove("QMTALT")
        oDt.Columns.Remove("QMTANC")
        oDt.Columns.Remove("QMTLRG")

        Dim oDs As New DataSet
        oDt.Columns("CCLNT").ColumnName = "CLIENTE"
        oDt.Columns("TCMPCL").ColumnName = "RAZÓN SOCIAL"
        oDt.Columns("TUBRFR").ColumnName = "UBICACIÓN"
        oDt.Columns("CREFFW").ColumnName = "CODIGO  BULTO"
        oDt.Columns("FINGAL").ColumnName = "FECHA  INGRESO"
        oDt.Columns("HORIDE").ColumnName = "HORA INGRESO"
        oDt.Columns("QREFFW").ColumnName = "QTA  BULTO"
        oDt.Columns("TIPBTO").ColumnName = "TIPO"
        oDt.Columns("QPSOBL").ColumnName = "PESO  BULTO"
        'oDt.Columns("QMTALT").ColumnName = "ALTURA"
        'oDt.Columns("QMTANC").ColumnName = "ANCHO"
        'oDt.Columns("QMTLRG").ColumnName = "LARGO"
        oDt.Columns("QVLBTO").ColumnName = "VOL. BULTO"
        oDt.Columns("TTINTC").ColumnName = "ORIGEN"
        oDt.Columns("TPRVCL").ColumnName = "PROVEEDOR"
        oDt.Columns("QAROCP").ColumnName = "AREA BULTO"
        oDt.Columns("TNOMCOM").ColumnName = "COMPRADOR "
        oDt.Columns("NORCML").ColumnName = "ORDEN COMPRA"
        oDt.Columns("NGRPRV").ColumnName = "GUIA PROVEEDOR"
        oDt.Columns("TLUGEN").ColumnName = "LUGAR DE ENTREGA"
        oDt.Columns("SSNCRG").ColumnName = "SENTIDO DE ENTREGA"
        oDt.Columns("DIAS").ColumnName = "DIAS EN ALMACEN"
        oDt.Columns("MARRET").ColumnName = "CUSTODIA RETENCION"

        Dim oDtv1 As DataView = New DataView(oDt)
        oDt2 = oDtv1.ToTable(True, "LUGAR DE ENTREGA")

        For intRows As Integer = 0 To oDt2.Rows.Count - 1
            oDtFiltro = SelectDataTable(oDt, "[LUGAR DE ENTREGA] = '" + oDt2.Rows(intRows).Item(0) + "'")
            oDtFiltro.TableName = NombreTabla(oDt2.Rows(intRows).Item(0).ToString.Trim)
            oDs.Tables.Add(oDtFiltro)
        Next
        '********
        Dim oDtv3 As DataView = New DataView(oDtRe)
        Dim oDtv2 As DataView = New DataView(oDtRe)
        Dim oDt1 As New DataTable
        Dim oDt4 As New DataTable
        Dim oDt3 As New DataTable
        Dim oDtFiltro2 As New DataTable
        Dim oDr As DataRow

        oDt1 = oDtv3.ToTable(True, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA", "CREFFW", "QREFFW", "QPSOBL", "QVLBTO")
        oDt4 = oDtv2.ToTable(True, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA")
        Dim oDtv4 As DataView = New DataView(oDt4)
        oDtv4.Sort = "CCLNT, TIPO_ALMACEN ASC"
        oDt3 = oDtv4.ToTable(False, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA")
        oDtResumen.Columns.Add("TCMPCL1")
        oDtResumen.Columns.Add("TIPO_ALMACEN1")
        oDtResumen.Columns.Add("ALMACEN1")
        oDtResumen.Columns.Add("ZONA")
        oDtResumen.Columns.Add("QREFFW")
        oDtResumen.Columns.Add("QPSOBL")
        oDtResumen.Columns.Add("QVLBTO")

        For i As Integer = 0 To oDt3.Rows.Count - 1
            oDtFiltro2 = SelectDataTable(oDt1, "CCLNT = '" + oDt3.Rows(i).Item("CCLNT").ToString.Trim + "' AND TIPO_ALMACEN = '" + oDt3.Rows(i).Item("TIPO_ALMACEN") + "' AND ALMACEN = '" + oDt3.Rows(i).Item("ALMACEN") + "' AND ZONA = '" + oDt3.Rows(i).Item("ZONA") + "' ")
            oDr = oDtResumen.NewRow()
            oDr("TCMPCL1") = oDt3.Rows(i).Item("TCMPCL")
            oDr("TIPO_ALMACEN1") = oDt3.Rows(i).Item("TIPO_ALMACEN")
            oDr("ALMACEN1") = oDt3.Rows(i).Item("ALMACEN")
            oDr("ZONA") = oDt3.Rows(i).Item("ZONA")
            oDr("QREFFW") = SumarDataTable(oDtFiltro2, "QREFFW")
            oDr("QPSOBL") = SumarDataTable(oDtFiltro2, "QPSOBL")
            oDr("QVLBTO") = SumarDataTable(oDtFiltro2, "QVLBTO")
            oDtResumen.Rows.Add(oDr)
        Next

        oDtResumen.Columns("TCMPCL1").ColumnName = "RAZON SOCIAL"
        oDtResumen.Columns("TIPO_ALMACEN1").ColumnName = "TIPO ALMACEN"
        oDtResumen.Columns("ALMACEN1").ColumnName = "ALMACEN"
        oDtResumen.Columns("ZONA").ColumnName = "ZONA"
        oDtResumen.Columns("QREFFW").ColumnName = "INVENTARIO \n CANTIDAD"
        oDtResumen.Columns("QPSOBL").ColumnName = "INVENTARIO \n PESO"
        oDtResumen.Columns("QVLBTO").ColumnName = "INVENTARIO \n VOLUMEN"

        oDtResumen.TableName = "Resumen"
        oDs.Tables.Add(oDtResumen)
        '*********
        If Me.txtSentidoCarga.Tag Is Nothing OrElse Me.txtSentidoCarga.Tag = "" Then
            strSentidoCarga = "TODOS"
        Else
            strSentidoCarga = Me.txtSentidoCarga.Text
        End If

        Dim strlTitulo As New List(Of String)
        'strlTitulo.Add("Cliente:\n" & Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial)
        strlTitulo.Add("Planta:\n" & Me.UcPLanta_Cmb011.DescripcionPlanta)
        If (Me.txtUbicacionReferencial.Tag Is Nothing OrElse Me.txtUbicacionReferencial.Tag = "") AndAlso Me.txtUbicacionReferencial.Text = "" Then
            strlTitulo.Add("Ubicación :\nTODOS")
        Else
            strlTitulo.Add("Ubicación :\n" & Me.txtUbicacionReferencial.Text)
        End If
        If Me.txtTipoMovimiento.Tag Is Nothing OrElse Me.txtTipoMovimiento.Tag = "" Then
            strlTitulo.Add("Tipo de Mov.:\nTODOS")
        Else
            strlTitulo.Add("Tipo de Mov.:\n" & Me.txtTipoMovimiento.Text)
        End If
        strlTitulo.Add("Sentido de Carga:\n" & strSentidoCarga)
        strlTitulo.Add("Fechas  de Inventario:\n" & Me.dteFechaInventario.Value.Date)

        'Suma 
        Dim listSuma As New Hashtable
        listSuma.Add("Suma01", 10)
        listSuma.Add("Suma02", 12)
        listSuma.Add("Suma03", 16)
        HelpClass.ExportExcelConTitulosAlmacen(oDs, Me.Text, strlTitulo, listSuma)
    End Sub

    Private Sub ExportarExcelOC3(ByVal oDtExcel As DataTable, ByVal strTitulo As String, ByVal oDtRe As DataTable)
        Dim oDt As New DataTable
        Dim oDtResumen As New DataTable
        Dim oDtFiltro As New DataTable
        Dim strSentidoCarga As String = ""
        oDt = oDtExcel.Copy


        'Eliminamos datos de item
        oDt.Columns.Remove("NRITOC")
        oDt.Columns.Remove("TCITCL")
        oDt.Columns.Remove("TDITES")
        oDt.Columns.Remove("IVUNIT")
        oDt.Columns.Remove("QSLCNB")
        oDt.Columns.Remove("TUNDIT")
        oDt.Columns.Remove("QPEPQT")
        oDt.Columns.Remove("QVOPQT")
        oDt.Columns.Remove("NORAGN")
        oDt.Columns.Remove("NFACPR")
        oDt.Columns.Remove("FFACPR")

        oDt.Columns.Remove("CIDPAQ")
        oDt.Columns.Remove("SBITOC")
        oDt.Columns.Remove("TCITCL1")
        oDt.Columns.Remove("TDITES1")
        oDt.Columns.Remove("QCNRCP")
        oDt.Columns.Remove("TNMMDT_ENVIO")
        oDt.Columns.Remove("TMRCTR")
        oDt.Columns.Remove("QMTALT")
        oDt.Columns.Remove("QMTANC")
        oDt.Columns.Remove("QMTLRG")


        Dim oDs As New DataSet
        oDt.Columns("CCLNT").ColumnName = "CLIENTE"
        oDt.Columns("TCMPCL").ColumnName = "RAZÓN SOCIAL"
        oDt.Columns("TUBRFR").ColumnName = "UBICACIÓN"
        oDt.Columns("CREFFW").ColumnName = "CODIGO  BULTO"
        oDt.Columns("FINGAL").ColumnName = "FECHA  INGRESO"
        oDt.Columns("HORIDE").ColumnName = "HORA INGRESO"
        oDt.Columns("QREFFW").ColumnName = "QTA  BULTO"
        oDt.Columns("TIPBTO").ColumnName = "TIPO"
        oDt.Columns("QPSOBL").ColumnName = "PESO  BULTO"
        'oDt.Columns("QMTALT").ColumnName = "ALTURA"
        'oDt.Columns("QMTANC").ColumnName = "ANCHO"
        'oDt.Columns("QMTLRG").ColumnName = "LARGO"
        oDt.Columns("QVLBTO").ColumnName = "VOL. BULTO"
        oDt.Columns("TTINTC").ColumnName = "ORIGEN"
        oDt.Columns("TPRVCL").ColumnName = "PROVEEDOR"
        oDt.Columns("QAROCP").ColumnName = "AREA BULTO"
        oDt.Columns("TNOMCOM").ColumnName = "COMPRADOR "
        oDt.Columns("NORCML").ColumnName = "ORDEN COMPRA"
        oDt.Columns("NGRPRV").ColumnName = "GUIA PROVEEDOR"
        oDt.Columns("TLUGEN").ColumnName = "LUGAR DE ENTREGA"
        oDt.Columns("SSNCRG").ColumnName = "SENTIDO DE ENTREGA"
        oDt.Columns("DIAS").ColumnName = "DIAS EN ALMACEN"
        oDt.Columns("MARRET").ColumnName = "CUSTODIA RETENCION"

        oDs.Tables.Add(oDt)

        '************
        Dim oDtv3 As DataView = New DataView(oDtRe)
        Dim oDtv2 As DataView = New DataView(oDtRe)
        Dim oDt1 As New DataTable
        Dim oDt4 As New DataTable
        Dim oDt3 As New DataTable
        Dim oDtFiltro2 As New DataTable
        Dim oDr As DataRow

        oDt1 = oDtv3.ToTable(True, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA", "CREFFW", "QREFFW", "QPSOBL", "QVLBTO")
        oDt4 = oDtv2.ToTable(True, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA")
        Dim oDtv4 As DataView = New DataView(oDt4)
        oDtv4.Sort = "CCLNT, TIPO_ALMACEN ASC"
        oDt3 = oDtv4.ToTable(False, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA")
        oDtResumen.Columns.Add("TCMPCL1")
        oDtResumen.Columns.Add("TIPO_ALMACEN1")
        oDtResumen.Columns.Add("ALMACEN1")
        oDtResumen.Columns.Add("ZONA")
        oDtResumen.Columns.Add("QREFFW")
        oDtResumen.Columns.Add("QPSOBL")
        oDtResumen.Columns.Add("QVLBTO")

        For i As Integer = 0 To oDt3.Rows.Count - 1
            oDtFiltro2 = SelectDataTable(oDt1, "CCLNT = '" + oDt3.Rows(i).Item("CCLNT").ToString.Trim + "' AND TIPO_ALMACEN = '" + oDt3.Rows(i).Item("TIPO_ALMACEN") + "' AND ALMACEN = '" + oDt3.Rows(i).Item("ALMACEN") + "' AND ZONA = '" + oDt3.Rows(i).Item("ZONA") + "' ")
            oDr = oDtResumen.NewRow()
            oDr("TCMPCL1") = oDt3.Rows(i).Item("TCMPCL")
            oDr("TIPO_ALMACEN1") = oDt3.Rows(i).Item("TIPO_ALMACEN")
            oDr("ALMACEN1") = oDt3.Rows(i).Item("ALMACEN")
            oDr("ZONA") = oDt3.Rows(i).Item("ZONA")
            oDr("QREFFW") = SumarDataTable(oDtFiltro2, "QREFFW")
            oDr("QPSOBL") = SumarDataTable(oDtFiltro2, "QPSOBL")
            oDr("QVLBTO") = SumarDataTable(oDtFiltro2, "QVLBTO")
            oDtResumen.Rows.Add(oDr)
        Next

        oDtResumen.Columns("TCMPCL1").ColumnName = "RAZON SOCIAL"
        oDtResumen.Columns("TIPO_ALMACEN1").ColumnName = "TIPO ALMACEN"
        oDtResumen.Columns("ALMACEN1").ColumnName = "ALMACEN"
        oDtResumen.Columns("ZONA").ColumnName = "ZONA"
        oDtResumen.Columns("QREFFW").ColumnName = "INVENTARIO \n CANTIDAD"
        oDtResumen.Columns("QPSOBL").ColumnName = "INVENTARIO \n PESO"
        oDtResumen.Columns("QVLBTO").ColumnName = "INVENTARIO \n VOLUMEN"

        oDtResumen.TableName = "Resumen"
        oDs.Tables.Add(oDtResumen)
        '*********

        If Me.txtSentidoCarga.Tag Is Nothing OrElse Me.txtSentidoCarga.Tag = "" Then
            strSentidoCarga = "TODOS"
        Else
            strSentidoCarga = Me.txtSentidoCarga.Text
        End If

        Dim strlTitulo As New List(Of String)
        'strlTitulo.Add("Cliente:\n" & Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial)
        strlTitulo.Add("Planta:\n" & Me.UcPLanta_Cmb011.DescripcionPlanta)
        If (Me.txtUbicacionReferencial.Tag Is Nothing OrElse Me.txtUbicacionReferencial.Tag = "") AndAlso Me.txtUbicacionReferencial.Text = "" Then
            strlTitulo.Add("Ubicación :\nTODOS")
        Else
            strlTitulo.Add("Ubicación :\n" & Me.txtUbicacionReferencial.Text)
        End If
        If Me.txtTipoMovimiento.Tag Is Nothing OrElse Me.txtTipoMovimiento.Tag = "" Then
            strlTitulo.Add("Tipo de Mov.:\nTODOS")
        Else
            strlTitulo.Add("Tipo de Mov.:\n" & Me.txtTipoMovimiento.Text)
        End If
        strlTitulo.Add("Sentido de Carga:\n" & strSentidoCarga)
        strlTitulo.Add("Fechas  de Inventario:\n" & Me.dteFechaInventario.Value.Date)

        'Suma 
        Dim listSuma As New Hashtable
        listSuma.Add("Suma01", 10)
        listSuma.Add("Suma02", 12)
        listSuma.Add("Suma03", 16)
        HelpClass.ExportExcelConTitulosAlmacen(oDs, Me.Text, strlTitulo, listSuma)
    End Sub

    Private Sub ExportarExcelOC4(ByVal oDtExcel As DataTable, ByVal strTitulo As String, ByVal oDtRe As DataTable)
        Dim oDt As New DataTable
        Dim oDtFiltro As New DataTable
        Dim oDtResumen As New DataTable
        Dim oDt2 As DataTable
        Dim strSentidoCarga As String = ""
        oDt = oDtExcel.Copy


        'Eliminamos datos de item
        oDt.Columns.Remove("NRITOC")
        oDt.Columns.Remove("TCITCL")
        oDt.Columns.Remove("TDITES")
        oDt.Columns.Remove("IVUNIT")
        oDt.Columns.Remove("QSLCNB")
        oDt.Columns.Remove("TUNDIT")
        oDt.Columns.Remove("QPEPQT")
        oDt.Columns.Remove("QVOPQT")
        'MODIFICADO 04-04-2013 - comentado
        '--------------------------------
        'oDt.Columns.Remove("TIPO_ALMACEN")
        'oDt.Columns.Remove("ALMACEN")
        '--------------------------------
        oDt.Columns.Remove("NORAGN")
        oDt.Columns.Remove("NFACPR")
        oDt.Columns.Remove("FFACPR")

        oDt.Columns.Remove("CIDPAQ")
        oDt.Columns.Remove("SBITOC")
        oDt.Columns.Remove("TCITCL1")
        oDt.Columns.Remove("TDITES1")
        oDt.Columns.Remove("QCNRCP")
        oDt.Columns.Remove("QMTALT")
        oDt.Columns.Remove("QMTANC")
        oDt.Columns.Remove("QMTLRG")

        Dim oDs As New DataSet
        oDt.Columns("CCLNT").ColumnName = "CLIENTE"
        oDt.Columns("TCMPCL").ColumnName = "RAZÓN SOCIAL"
        oDt.Columns("TUBRFR").ColumnName = "UBICACIÓN"
        oDt.Columns("CREFFW").ColumnName = "CODIGO  BULTO"
        oDt.Columns("FINGAL").ColumnName = "FECHA  INGRESO"
        oDt.Columns("HORIDE").ColumnName = "HORA INGRESO"
        oDt.Columns("QREFFW").ColumnName = "QTA  BULTO"
        oDt.Columns("TIPBTO").ColumnName = "TIPO"
        oDt.Columns("QPSOBL").ColumnName = "PESO  BULTO"
        'oDt.Columns("QMTALT").ColumnName = "ALTURA"
        'oDt.Columns("QMTANC").ColumnName = "ANCHO"
        'oDt.Columns("QMTLRG").ColumnName = "LARGO"
        oDt.Columns("QVLBTO").ColumnName = "VOL. BULTO"
        oDt.Columns("TTINTC").ColumnName = "ORIGEN"
        oDt.Columns("TPRVCL").ColumnName = "PROVEEDOR"
        oDt.Columns("QAROCP").ColumnName = "AREA BULTO"
        oDt.Columns("TNOMCOM").ColumnName = "COMPRADOR "
        oDt.Columns("NORCML").ColumnName = "ORDEN COMPRA"
        oDt.Columns("NGRPRV").ColumnName = "GUIA PROVEEDOR"
        oDt.Columns("TLUGEN").ColumnName = "LUGAR DE ENTREGA"
        oDt.Columns("SSNCRG").ColumnName = "SENTIDO DE ENTREGA"
        oDt.Columns("DIAS").ColumnName = "DIAS EN ALMACEN"
        oDt.Columns("MARRET").ColumnName = "CUSTODIA RETENCIO"
        oDt.Columns("TNMMDT_ENVIO").ColumnName = "MEDIO DE ENVÍO"
        oDt.Columns("TMRCTR").ColumnName = "NAVE DE PROCEDENCIA"

        Dim oDtv1 As DataView = New DataView(oDt)
        oDt2 = oDtv1.ToTable(True, "LUGAR DE ENTREGA")

        For intRows As Integer = 0 To oDt2.Rows.Count - 1
            oDtFiltro = SelectDataTable(oDt, "[LUGAR DE ENTREGA] = '" + oDt2.Rows(intRows).Item(0) + "'")
            oDtFiltro.TableName = NombreTabla(oDt2.Rows(intRows).Item(0).ToString.Trim)
            oDs.Tables.Add(oDtFiltro)
        Next

        '************
        Dim oDtv3 As DataView = New DataView(oDtRe)
        Dim oDtv2 As DataView = New DataView(oDtRe)
        Dim oDt1 As New DataTable
        Dim oDt4 As New DataTable
        Dim oDt3 As New DataTable
        Dim oDtFiltro2 As New DataTable
        Dim oDr As DataRow

        oDt1 = oDtv3.ToTable(True, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA", "CREFFW", "QREFFW", "QPSOBL", "QVLBTO")
        oDt4 = oDtv2.ToTable(True, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA")
        Dim oDtv4 As DataView = New DataView(oDt4)
        oDtv4.Sort = "CCLNT, TIPO_ALMACEN ASC"
        oDt3 = oDtv4.ToTable(False, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA")
        oDtResumen.Columns.Add("TCMPCL1")
        oDtResumen.Columns.Add("TIPO_ALMACEN1")
        oDtResumen.Columns.Add("ALMACEN1")
        oDtResumen.Columns.Add("ZONA")
        oDtResumen.Columns.Add("QREFFW")
        oDtResumen.Columns.Add("QPSOBL")
        oDtResumen.Columns.Add("QVLBTO")

        For i As Integer = 0 To oDt3.Rows.Count - 1
            oDtFiltro2 = SelectDataTable(oDt1, "CCLNT = '" + oDt3.Rows(i).Item("CCLNT").ToString.Trim + "' AND TIPO_ALMACEN = '" + oDt3.Rows(i).Item("TIPO_ALMACEN") + "' AND ALMACEN = '" + oDt3.Rows(i).Item("ALMACEN") + "' AND ZONA = '" + oDt3.Rows(i).Item("ZONA") + "' ")
            oDr = oDtResumen.NewRow()
            oDr("TCMPCL1") = oDt3.Rows(i).Item("TCMPCL")
            oDr("TIPO_ALMACEN1") = oDt3.Rows(i).Item("TIPO_ALMACEN")
            oDr("ALMACEN1") = oDt3.Rows(i).Item("ALMACEN")
            oDr("ZONA") = oDt3.Rows(i).Item("ZONA")
            oDr("QREFFW") = SumarDataTable(oDtFiltro2, "QREFFW")
            oDr("QPSOBL") = SumarDataTable(oDtFiltro2, "QPSOBL")
            oDr("QVLBTO") = SumarDataTable(oDtFiltro2, "QVLBTO")
            oDtResumen.Rows.Add(oDr)
        Next

        oDtResumen.Columns("TCMPCL1").ColumnName = "RAZON SOCIAL"
        oDtResumen.Columns("TIPO_ALMACEN1").ColumnName = "TIPO ALMACEN"
        oDtResumen.Columns("ALMACEN1").ColumnName = "ALMACEN"
        oDtResumen.Columns("ZONA").ColumnName = "ZONA"
        oDtResumen.Columns("QREFFW").ColumnName = "INVENTARIO \n CANTIDAD"
        oDtResumen.Columns("QPSOBL").ColumnName = "INVENTARIO \n PESO"
        oDtResumen.Columns("QVLBTO").ColumnName = "INVENTARIO \n VOLUMEN"

        oDtResumen.TableName = "Resumen"
        oDs.Tables.Add(oDtResumen)
        '*********

        If Me.txtSentidoCarga.Tag Is Nothing OrElse Me.txtSentidoCarga.Tag = "" Then
            strSentidoCarga = "TODOS"
        Else
            strSentidoCarga = Me.txtSentidoCarga.Text
        End If

        Dim strlTitulo As New List(Of String)
        'strlTitulo.Add("Cliente:\n" & Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial)
        strlTitulo.Add("Planta:\n" & Me.UcPLanta_Cmb011.DescripcionPlanta)
        If (Me.txtUbicacionReferencial.Tag Is Nothing OrElse Me.txtUbicacionReferencial.Tag = "") AndAlso Me.txtUbicacionReferencial.Text = "" Then
            strlTitulo.Add("Ubicación :\nTODOS")
        Else
            strlTitulo.Add("Ubicación :\n" & Me.txtUbicacionReferencial.Text)
        End If
        If Me.txtTipoMovimiento.Tag Is Nothing OrElse Me.txtTipoMovimiento.Tag = "" Then
            strlTitulo.Add("Tipo de Mov.:\nTODOS")
        Else
            strlTitulo.Add("Tipo de Mov.:\n" & Me.txtTipoMovimiento.Text)
        End If
        strlTitulo.Add("Sentido de Carga:\n" & strSentidoCarga)
        strlTitulo.Add("Fechas  de Inventario:\n" & Me.dteFechaInventario.Value.Date)

        'Suma 
        Dim listSuma As New Hashtable
        listSuma.Add("Suma01", 10)
        listSuma.Add("Suma02", 12)
        listSuma.Add("Suma03", 16)
        HelpClass.ExportExcelConTitulosAlmacen(oDs, Me.Text, strlTitulo, listSuma)
    End Sub

    Private Function NombreTabla(ByVal strNombreTabla As String) As String
        strNombreTabla = strNombreTabla.Replace(":", "-")
        strNombreTabla = strNombreTabla.Replace("?", "")
        strNombreTabla = strNombreTabla.Replace("/", "-")
        Return strNombreTabla
    End Function

    Private Function SelectDataTable(ByVal dt As DataTable, ByVal filter As String) As DataTable
        Dim rows As DataRow()
        Dim dtNew As DataTable
        dtNew = dt.Clone()
        rows = dt.Select(filter)
        For Each dr As DataRow In rows
            dtNew.ImportRow(dr)
        Next
        Return dtNew
    End Function

    Private Sub ExportarExcelSubItem_1(ByVal oDtExcel As DataTable, ByVal strTitulo As String, ByVal oDtRe As DataTable)
        Dim oDtAlternativo As New DataTable
        Dim objListdt As New List(Of DataTable)
        Dim oDs As New DataSet
        Dim strSentidoCarga As String = String.Empty

        oDtAlternativo = GeneraDtAlternativo_1(oDtExcel, True)
        oDtAlternativo.Columns("CCLNT").ColumnName = "CLIENTE"
        oDtAlternativo.Columns("TCMPCL").ColumnName = "RAZON SOCIAL"
        oDtAlternativo.Columns("TUBRFR").ColumnName = "UBICACIÓN"
        oDtAlternativo.Columns("CREFFW").ColumnName = "CODIGO  BULTO"
        oDtAlternativo.Columns("FINGAL").ColumnName = "FECHA  INGRESO"
        oDtAlternativo.Columns("HORIDE").ColumnName = "HORA INGRESO"
        oDtAlternativo.Columns("QREFFW").ColumnName = "QTA  BULTO"
        oDtAlternativo.Columns("TIPBTO").ColumnName = "TIPO"
        oDtAlternativo.Columns("QPSOBL").ColumnName = "PESO  BULTO"
        oDtAlternativo.Columns("QVLBTO").ColumnName = "VOL. BULTO"
        oDtAlternativo.Columns("TTINTC").ColumnName = "ORIGEN"
        oDtAlternativo.Columns("TPRVCL").ColumnName = "PROVEEDOR"
        oDtAlternativo.Columns("QAROCP").ColumnName = "AREA BULTO"
        oDtAlternativo.Columns("TNOMCOM").ColumnName = "COMPRADOR "
        oDtAlternativo.Columns("REFERENCIA").ColumnName = "REFERENCIA"
        oDtAlternativo.Columns("NORCML").ColumnName = "ORDEN COMPRA"
        oDtAlternativo.Columns("NRITOC").ColumnName = "ITEM"
        oDtAlternativo.Columns("TCITCL").ColumnName = "COD. ITEM"
        oDtAlternativo.Columns("TDITES").ColumnName = "DESCRIPCION DEL ITEM"
        oDtAlternativo.Columns("IVUNIT").ColumnName = "PRECIO UNITARIO "
        oDtAlternativo.Columns("QSLCNB").ColumnName = "SALDO  CANTIDAD"
        oDtAlternativo.Columns("TUNDIT").ColumnName = "UNIDAD"
        oDtAlternativo.Columns("QPEPQT").ColumnName = "PESO ITEM  "
        oDtAlternativo.Columns("QVOPQT").ColumnName = "VOL ITEM"
        oDtAlternativo.Columns("NGRPRV").ColumnName = "Nro GUIA"
        oDtAlternativo.Columns("TLUGEN").ColumnName = "LUGAR"
        oDtAlternativo.Columns("SSNCRG").ColumnName = "SENTIDO DE ENTREGA"
        oDtAlternativo.Columns("DIAS").ColumnName = "DIAS EN ALMACEN"
        oDtAlternativo.Columns("MARRET").ColumnName = "CUSTODIA RETENCION"
        oDtAlternativo.Columns("NORAGN").ColumnName = "Nº ORDEN DE SERVICIO"
        oDtAlternativo.Columns("NFACPR").ColumnName = "FACTURA COMERCIAL"
        oDtAlternativo.Columns("FFACPR").ColumnName = "FECHA FACTURA COMERCIAL"

        oDtAlternativo.Columns("SBITOC").ColumnName = "SUBITEM"
        oDtAlternativo.Columns("TCITCL1").ColumnName = "COD. SUBITEM"
        oDtAlternativo.Columns("TDITES1").ColumnName = "DESCRIPCION SUBITEM"
        oDtAlternativo.Columns("QCNRCP").ColumnName = "CANTIDAD "


        oDtAlternativo.TableName = "Inventario Almacen"
        oDs.Tables.Add(oDtAlternativo)

        '*********
        Dim oDtv3 As DataView = New DataView(oDtRe)
        Dim oDtv2 As DataView = New DataView(oDtRe)
        Dim oDtResumen As New DataTable
        Dim oDt1 As New DataTable
        Dim oDt4 As New DataTable
        Dim oDt3 As New DataTable
        Dim oDtFiltro2 As New DataTable
        Dim oDr As DataRow

        oDt1 = oDtv3.ToTable(True, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA", "CREFFW", "QREFFW", "QPSOBL", "QVLBTO")
        oDt4 = oDtv2.ToTable(True, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA")
        Dim oDtv4 As DataView = New DataView(oDt4)
        oDtv4.Sort = "CCLNT, TIPO_ALMACEN ASC"
        oDt3 = oDtv4.ToTable(False, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA")
        oDtResumen.Columns.Add("TCMPCL1")
        oDtResumen.Columns.Add("TIPO_ALMACEN1")
        oDtResumen.Columns.Add("ALMACEN1")
        oDtResumen.Columns.Add("ZONA")
        oDtResumen.Columns.Add("QREFFW")
        oDtResumen.Columns.Add("QPSOBL")
        oDtResumen.Columns.Add("QVLBTO")

        For i As Integer = 0 To oDt3.Rows.Count - 1
            oDtFiltro2 = SelectDataTable(oDt1, "CCLNT = '" + oDt3.Rows(i).Item("CCLNT").ToString.Trim + "' AND TIPO_ALMACEN = '" + oDt3.Rows(i).Item("TIPO_ALMACEN") + "' AND ALMACEN = '" + oDt3.Rows(i).Item("ALMACEN") + "' AND ZONA = '" + oDt3.Rows(i).Item("ZONA") + "' ")
            oDr = oDtResumen.NewRow()
            oDr("TCMPCL1") = oDt3.Rows(i).Item("TCMPCL")
            oDr("TIPO_ALMACEN1") = oDt3.Rows(i).Item("TIPO_ALMACEN")
            oDr("ALMACEN1") = oDt3.Rows(i).Item("ALMACEN")
            oDr("ZONA") = oDt3.Rows(i).Item("ZONA")
            oDr("QREFFW") = SumarDataTable(oDtFiltro2, "QREFFW")
            oDr("QPSOBL") = SumarDataTable(oDtFiltro2, "QPSOBL")
            oDr("QVLBTO") = SumarDataTable(oDtFiltro2, "QVLBTO")
            oDtResumen.Rows.Add(oDr)
        Next

        oDtResumen.Columns("TCMPCL1").ColumnName = "RAZON SOCIAL"
        oDtResumen.Columns("TIPO_ALMACEN1").ColumnName = "TIPO ALMACEN"
        oDtResumen.Columns("ALMACEN1").ColumnName = "ALMACEN"
        oDtResumen.Columns("ZONA").ColumnName = "ZONA"
        oDtResumen.Columns("QREFFW").ColumnName = "INVENTARIO \n CANTIDAD"
        oDtResumen.Columns("QPSOBL").ColumnName = "INVENTARIO \n PESO"
        oDtResumen.Columns("QVLBTO").ColumnName = "INVENTARIO \n VOLUMEN"

        oDtResumen.TableName = "Resumen"
        oDs.Tables.Add(oDtResumen)
        '*********

        If Me.txtSentidoCarga.Tag Is Nothing OrElse Me.txtSentidoCarga.Tag = "" Then
            strSentidoCarga = "TODOS"
        Else
            strSentidoCarga = Me.txtSentidoCarga.Text
        End If
        Dim strlTitulo As New List(Of String)
        ' strlTitulo.Add("Cliente :\n" & Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial)
        strlTitulo.Add("Planta :\n" & Me.UcPLanta_Cmb011.DescripcionPlanta)
        If (Me.txtUbicacionReferencial.Tag Is Nothing OrElse Me.txtUbicacionReferencial.Tag = "") AndAlso Me.txtUbicacionReferencial.Text = "" Then
            strlTitulo.Add("Ubicación :\nTODOS")
        Else
            strlTitulo.Add("Ubicación :\n" & Me.txtUbicacionReferencial.Text)
        End If
        If Me.txtTipoMovimiento.Tag Is Nothing OrElse Me.txtTipoMovimiento.Tag = "" Then
            strlTitulo.Add("Tipo de Mov.:\nTODOS")
        Else
            strlTitulo.Add("Tipo de Mov.:\n" & Me.txtTipoMovimiento.Text)
        End If
        strlTitulo.Add("Sentido de Carga:\n" & strSentidoCarga)
        strlTitulo.Add("Fechas  de Inventario:\n" & Me.dteFechaInventario.Value.Date)

        HelpClass.ExportExcelConTitulosAlmacen(oDs, Me.Text, strlTitulo)
    End Sub


    Private Sub ExportarExcelItem_1(ByVal oDtExcel As DataTable, ByVal strTitulo As String, ByVal oDtRe As DataTable)
        Dim oDtAlternativo As New DataTable

        Dim objListdt As New List(Of DataTable)
        Dim oDs As New DataSet
        Dim strSentidoCarga As String = String.Empty

        oDtAlternativo = GeneraDtAlternativo_1(oDtExcel)
        oDtAlternativo.Columns("CCLNT").ColumnName = "CLIENTE"
        oDtAlternativo.Columns("TCMPCL").ColumnName = "RAZON SOCIAL"
        oDtAlternativo.Columns("TUBRFR").ColumnName = "UBICACIÓN"
        oDtAlternativo.Columns("CREFFW").ColumnName = "CODIGO  BULTO"
        oDtAlternativo.Columns("FINGAL").ColumnName = "FECHA  INGRESO"
        oDtAlternativo.Columns("HORIDE").ColumnName = "HORA  INGRESO"
        oDtAlternativo.Columns("QREFFW").ColumnName = "QTA  BULTO"
        oDtAlternativo.Columns("TIPBTO").ColumnName = "TIPO"
        oDtAlternativo.Columns("QPSOBL").ColumnName = "PESO  BULTO"
        oDtAlternativo.Columns("QVLBTO").ColumnName = "VOL. BULTO"
        oDtAlternativo.Columns("TTINTC").ColumnName = "ORIGEN"
        oDtAlternativo.Columns("TPRVCL").ColumnName = "PROVEEDOR"
        oDtAlternativo.Columns("QAROCP").ColumnName = "AREA BULTO"
        oDtAlternativo.Columns("TNOMCOM").ColumnName = "COMPRADOR "

        oDtAlternativo.Columns("TPOOCM").ColumnName = "TIPO DE OC "

        oDtAlternativo.Columns("NORCML").ColumnName = "ORDEN COMPRA"

        oDtAlternativo.Columns("TIPLIN").ColumnName = "TIPO DE LÍNEA"
        oDtAlternativo.Columns("TRFRN").ColumnName = "USUARIO SOLICITANTE"
        oDtAlternativo.Columns("TCMAEM").ColumnName = "PROYECTO ÁREA"


        oDtAlternativo.Columns("NRITOC").ColumnName = "ITEM"
        oDtAlternativo.Columns("TCITCL").ColumnName = "COD. ITEM"
        oDtAlternativo.Columns("TDITES").ColumnName = "DESCRIPCION DEL ITEM"
        oDtAlternativo.Columns("IVUNIT").ColumnName = "PRECIO UNITARIO "
        oDtAlternativo.Columns("QSLCNB").ColumnName = "SALDO  CANTIDAD"
        oDtAlternativo.Columns("TUNDIT").ColumnName = "UNIDAD"
        oDtAlternativo.Columns("QPEPQT").ColumnName = "PESO ITEM  "
        oDtAlternativo.Columns("QVOPQT").ColumnName = "VOL ITEM"
        oDtAlternativo.Columns("NGRPRV").ColumnName = "Nro GUIA"
        oDtAlternativo.Columns("TLUGEN").ColumnName = "LUGAR"
        oDtAlternativo.Columns("SSNCRG").ColumnName = "SENTIDO DE ENTREGA"
        oDtAlternativo.Columns("DIAS").ColumnName = "DIAS EN ALMACEN"
        oDtAlternativo.Columns("MARRET").ColumnName = "CUSTODIA RETENCION"
        oDtAlternativo.Columns("NORAGN").ColumnName = "Nº ORDEN DE SERVICIO"
        oDtAlternativo.Columns("NFACPR").ColumnName = "FACTURA COMERCIAL"
        oDtAlternativo.Columns("FFACPR").ColumnName = "FECHA FACTURA COMERCIAL"


        oDtAlternativo.TableName = "Inventario Almacen"
        oDs.Tables.Add(oDtAlternativo)

        '*********
        Dim oDtv3 As DataView = New DataView(oDtRe)
        Dim oDtv2 As DataView = New DataView(oDtRe)
        Dim oDtResumen As New DataTable
        Dim oDt1 As New DataTable
        Dim oDt4 As New DataTable
        Dim oDt3 As New DataTable
        Dim oDtFiltro2 As New DataTable
        Dim oDr As DataRow

        oDt1 = oDtv3.ToTable(True, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA", "CREFFW", "QREFFW", "QPSOBL", "QVLBTO")
        oDt4 = oDtv2.ToTable(True, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA")
        Dim oDtv4 As DataView = New DataView(oDt4)
        oDtv4.Sort = "CCLNT, TIPO_ALMACEN ASC"
        oDt3 = oDtv4.ToTable(False, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA")
        oDtResumen.Columns.Add("TCMPCL1")
        oDtResumen.Columns.Add("TIPO_ALMACEN1")
        oDtResumen.Columns.Add("ALMACEN1")
        oDtResumen.Columns.Add("ZONA")
        oDtResumen.Columns.Add("QREFFW")
        oDtResumen.Columns.Add("QPSOBL")
        oDtResumen.Columns.Add("QVLBTO")

        For i As Integer = 0 To oDt3.Rows.Count - 1
            oDtFiltro2 = SelectDataTable(oDt1, "CCLNT = '" + oDt3.Rows(i).Item("CCLNT").ToString.Trim + "' AND TIPO_ALMACEN = '" + oDt3.Rows(i).Item("TIPO_ALMACEN") + "' AND ALMACEN = '" + oDt3.Rows(i).Item("ALMACEN") + "' AND ZONA = '" + oDt3.Rows(i).Item("ZONA") + "' ")
            oDr = oDtResumen.NewRow()
            oDr("TCMPCL1") = oDt3.Rows(i).Item("TCMPCL")
            oDr("TIPO_ALMACEN1") = oDt3.Rows(i).Item("TIPO_ALMACEN")
            oDr("ALMACEN1") = oDt3.Rows(i).Item("ALMACEN")
            oDr("ZONA") = oDt3.Rows(i).Item("ZONA")
            oDr("QREFFW") = SumarDataTable(oDtFiltro2, "QREFFW")
            oDr("QPSOBL") = SumarDataTable(oDtFiltro2, "QPSOBL")
            oDr("QVLBTO") = SumarDataTable(oDtFiltro2, "QVLBTO")
            oDtResumen.Rows.Add(oDr)
        Next

        oDtResumen.Columns("TCMPCL1").ColumnName = "RAZON SOCIAL"
        oDtResumen.Columns("TIPO_ALMACEN1").ColumnName = "TIPO ALMACEN"
        oDtResumen.Columns("ALMACEN1").ColumnName = "ALMACEN"
        oDtResumen.Columns("ZONA").ColumnName = "ZONA"
        oDtResumen.Columns("QREFFW").ColumnName = "INVENTARIO \n CANTIDAD"
        oDtResumen.Columns("QPSOBL").ColumnName = "INVENTARIO \n PESO"
        oDtResumen.Columns("QVLBTO").ColumnName = "INVENTARIO \n VOLUMEN"

        oDtResumen.TableName = "Resumen"
        oDs.Tables.Add(oDtResumen)
        '*********

        If Me.txtSentidoCarga.Tag Is Nothing OrElse Me.txtSentidoCarga.Tag = "" Then
            strSentidoCarga = "TODOS"
        Else
            strSentidoCarga = Me.txtSentidoCarga.Text
        End If
        Dim strlTitulo As New List(Of String)
        'strlTitulo.Add("Cliente :\n" & Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial)
        strlTitulo.Add("Planta :\n" & Me.UcPLanta_Cmb011.DescripcionPlanta)
        If (Me.txtUbicacionReferencial.Tag Is Nothing OrElse Me.txtUbicacionReferencial.Tag = "") AndAlso Me.txtUbicacionReferencial.Text = "" Then
            strlTitulo.Add("Ubicación :\nTODOS")
        Else
            strlTitulo.Add("Ubicación :\n" & Me.txtUbicacionReferencial.Text)
        End If
        If Me.txtTipoMovimiento.Tag Is Nothing OrElse Me.txtTipoMovimiento.Tag = "" Then
            strlTitulo.Add("Tipo de Mov.:\nTODOS")
        Else
            strlTitulo.Add("Tipo de Mov.:\n" & Me.txtTipoMovimiento.Text)
        End If
        strlTitulo.Add("Sentido de Carga:\n" & strSentidoCarga)
        strlTitulo.Add("Fechas  de Inventario:\n" & Me.dteFechaInventario.Value.Date)

        HelpClass.ExportExcelConTitulosAlmacen(oDs, Me.Text, strlTitulo)
    End Sub

    ''' <summary>
    ''' Esto esta implementado bajo el requerimiento del Cliente Conga
    ''' </summary>
    ''' <param name="oDtExcel"></param>
    ''' <param name="strTitulo"></param>
    ''' <remarks></remarks>
    Private Sub ExportarExcelItem_2(ByVal oDtExcel As DataTable, ByVal strTitulo As String, ByVal oDtRe As DataTable)
        Dim oDtAlternativo As New DataTable
        Dim objListdt As New List(Of DataTable)
        Dim oDs As New DataSet
        Dim strSentidoCarga As String = String.Empty

        oDtAlternativo = GeneraDtAlternativo_2(oDtExcel)

        oDtAlternativo.Columns("FINGAL").ColumnName = "FECHA  INGRESO"
        oDtAlternativo.Columns("HORIDE").ColumnName = "HORA  INGRESO"
        oDtAlternativo.Columns("CREFFW").ColumnName = "CODIGO  BULTO"
        oDtAlternativo.Columns("QREFFW").ColumnName = "QTA  BULTO"
        oDtAlternativo.Columns("TIPBTO").ColumnName = "TIPO"
        oDtAlternativo.Columns("QPSOBL").ColumnName = "PESO  BULTO"
        oDtAlternativo.Columns("QVLBTO").ColumnName = "VOL. BULTO"
        oDtAlternativo.Columns("TTINTC").ColumnName = "INCONTERM"
        oDtAlternativo.Columns("TPRVCL").ColumnName = "PROVEEDOR"
        oDtAlternativo.Columns("QAROCP").ColumnName = "AREA BULTO"
        'oDt.Columns("TNOMCOM").ColumnName = "COMPRADOR "
        oDtAlternativo.Columns("NORCML").ColumnName = "ORDEN COMPRA"
        oDtAlternativo.Columns("NRITOC").ColumnName = "ITEM"
        'oDt.Columns("TCITCL").ColumnName = "COD. ITEM"
        oDtAlternativo.Columns("TDITES").ColumnName = "DESCRIPCION DEL ITEM"
        oDtAlternativo.Columns("IVUNIT").ColumnName = "PRECIO UNITARIO "
        oDtAlternativo.Columns("QSLCNB").ColumnName = "SALDO  CANTIDAD"
        oDtAlternativo.Columns("TUNDIT").ColumnName = "UNIDAD"
        'oDt.Columns("QPEPQT").ColumnName = "PESO ITEM  "
        'oDt.Columns("QVOPQT").ColumnName = "VOL ITEM"
        oDtAlternativo.Columns("NGRPRV").ColumnName = "Nº GUIA PROVEEDROR"
        'oDt.Columns("TLUGEN").ColumnName = "LUGAR"
        'oDtAlternativo.Columns("SSNCRG").ColumnName = "SENTIDO DE ENTREGA"
        oDtAlternativo.Columns("DIAS").ColumnName = "DIAS EN ALMACEN"
        'oDtAlternativo.Columns("MARRET").ColumnName = "CUSTODIA RETENCION"


        oDtAlternativo.Columns("NORAGN").ColumnName = "Nº ORDEN DE SERVICIO"
        oDtAlternativo.Columns("NFACPR").ColumnName = "FACTURA COMERCIAL"
        oDtAlternativo.Columns("FFACPR").ColumnName = "FECHA FACTURA COMERCIAL"

        oDtAlternativo.TableName = "Inventario"
        oDs.Tables.Add(oDtAlternativo)

        '*********
        Dim oDtv3 As DataView = New DataView(oDtRe)
        Dim oDtv2 As DataView = New DataView(oDtRe)
        Dim oDtResumen As New DataTable
        Dim oDt1 As New DataTable
        Dim oDt4 As New DataTable
        Dim oDt3 As New DataTable
        Dim oDtFiltro2 As New DataTable
        Dim oDr As DataRow

        oDt1 = oDtv3.ToTable(True, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA", "CREFFW", "QREFFW", "QPSOBL", "QVLBTO")
        oDt4 = oDtv2.ToTable(True, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA")
        Dim oDtv4 As DataView = New DataView(oDt4)
        oDtv4.Sort = "CCLNT, TIPO_ALMACEN ASC"
        oDt3 = oDtv4.ToTable(False, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA")
        oDtResumen.Columns.Add("TCMPCL1")
        oDtResumen.Columns.Add("TIPO_ALMACEN1")
        oDtResumen.Columns.Add("ALMACEN1")
        oDtResumen.Columns.Add("ZONA")
        oDtResumen.Columns.Add("QREFFW")
        oDtResumen.Columns.Add("QPSOBL")
        oDtResumen.Columns.Add("QVLBTO")

        For i As Integer = 0 To oDt3.Rows.Count - 1
            oDtFiltro2 = SelectDataTable(oDt1, "CCLNT = '" + oDt3.Rows(i).Item("CCLNT").ToString.Trim + "' AND TIPO_ALMACEN = '" + oDt3.Rows(i).Item("TIPO_ALMACEN") + "' AND ALMACEN = '" + oDt3.Rows(i).Item("ALMACEN") + "' AND ZONA = '" + oDt3.Rows(i).Item("ZONA") + "' ")
            oDr = oDtResumen.NewRow()
            oDr("TCMPCL1") = oDt3.Rows(i).Item("TCMPCL")
            oDr("TIPO_ALMACEN1") = oDt3.Rows(i).Item("TIPO_ALMACEN")
            oDr("ALMACEN1") = oDt3.Rows(i).Item("ALMACEN")
            oDr("ZONA") = oDt3.Rows(i).Item("ZONA")
            oDr("QREFFW") = SumarDataTable(oDtFiltro2, "QREFFW")
            oDr("QPSOBL") = SumarDataTable(oDtFiltro2, "QPSOBL")
            oDr("QVLBTO") = SumarDataTable(oDtFiltro2, "QVLBTO")
            oDtResumen.Rows.Add(oDr)
        Next

        oDtResumen.Columns("TCMPCL1").ColumnName = "RAZON SOCIAL"
        oDtResumen.Columns("TIPO_ALMACEN1").ColumnName = "TIPO ALMACEN"
        oDtResumen.Columns("ALMACEN1").ColumnName = "ALMACEN"
        oDtResumen.Columns("ZONA").ColumnName = "ZONA"
        oDtResumen.Columns("QREFFW").ColumnName = "INVENTARIO \n CANTIDAD"
        oDtResumen.Columns("QPSOBL").ColumnName = "INVENTARIO \n PESO"
        oDtResumen.Columns("QVLBTO").ColumnName = "INVENTARIO \n VOLUMEN"

        oDtResumen.TableName = "Resumen"
        oDs.Tables.Add(oDtResumen)
        '*********

        If Me.txtSentidoCarga.Tag Is Nothing OrElse Me.txtSentidoCarga.Tag = "" Then
            strSentidoCarga = "TODOS"
        Else
            strSentidoCarga = Me.txtSentidoCarga.Text
        End If
        Dim strlTitulo As New List(Of String)
        'strlTitulo.Add("Cliente :\n" & Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial)
        strlTitulo.Add("Planta :\n" & Me.UcPLanta_Cmb011.DescripcionPlanta)
        If (Me.txtUbicacionReferencial.Tag Is Nothing OrElse Me.txtUbicacionReferencial.Tag = "") AndAlso Me.txtUbicacionReferencial.Text = "" Then
            strlTitulo.Add("Ubicación :\nTODOS")
        Else
            strlTitulo.Add("Ubicación :\n" & Me.txtUbicacionReferencial.Text)
        End If
        If Me.txtTipoMovimiento.Tag Is Nothing OrElse Me.txtTipoMovimiento.Tag = "" Then
            strlTitulo.Add("Tipo de Mov.:\nTODOS")
        Else
            strlTitulo.Add("Tipo de Mov.:\n" & Me.txtTipoMovimiento.Text)
        End If
        strlTitulo.Add("Sentido de Carga:\n" & strSentidoCarga)
        strlTitulo.Add("Fechas  de Inventario:\n" & Me.dteFechaInventario.Value.Date)

        HelpClass.ExportExcelConTitulosAlmacen(oDs, Me.Text, strlTitulo)
    End Sub

    Private Sub ExportarExcelSubItem_2(ByVal oDtExcel As DataTable, ByVal strTitulo As String, ByVal oDtRe As DataTable)
        Dim oDtAlternativo As New DataTable
        Dim objListdt As New List(Of DataTable)
        Dim oDs As New DataSet
        Dim strSentidoCarga As String = String.Empty

        oDtAlternativo = GeneraDtAlternativo_2(oDtExcel, True)

        oDtAlternativo.Columns("FINGAL").ColumnName = "FECHA  INGRESO"
        oDtAlternativo.Columns("HORIDE").ColumnName = "HORA  INGRESO"
        oDtAlternativo.Columns("CREFFW").ColumnName = "CODIGO  BULTO"
        oDtAlternativo.Columns("QREFFW").ColumnName = "QTA  BULTO"
        oDtAlternativo.Columns("TIPBTO").ColumnName = "TIPO"
        oDtAlternativo.Columns("QPSOBL").ColumnName = "PESO  BULTO"
        oDtAlternativo.Columns("QVLBTO").ColumnName = "VOL. BULTO"
        oDtAlternativo.Columns("TTINTC").ColumnName = "INCONTERM"
        oDtAlternativo.Columns("TPRVCL").ColumnName = "PROVEEDOR"
        oDtAlternativo.Columns("QAROCP").ColumnName = "AREA BULTO"
        oDtAlternativo.Columns("NORCML").ColumnName = "ORDEN COMPRA"
        oDtAlternativo.Columns("NRITOC").ColumnName = "ITEM"
        oDtAlternativo.Columns("TDITES").ColumnName = "DESCRIPCION DEL ITEM"
        oDtAlternativo.Columns("IVUNIT").ColumnName = "PRECIO UNITARIO "
        oDtAlternativo.Columns("QSLCNB").ColumnName = "SALDO  CANTIDAD"
        oDtAlternativo.Columns("TUNDIT").ColumnName = "UNIDAD"
        oDtAlternativo.Columns("NGRPRV").ColumnName = "Nº GUIA PROVEEDROR"
        oDtAlternativo.Columns("DIAS").ColumnName = "DIAS EN ALMACEN"
        oDtAlternativo.Columns("NORAGN").ColumnName = "Nº ORDEN DE SERVICIO"
        oDtAlternativo.Columns("NFACPR").ColumnName = "FACTURA COMERCIAL"
        oDtAlternativo.Columns("FFACPR").ColumnName = "FECHA FACTURA COMERCIAL"
        oDtAlternativo.Columns("SBITOC").ColumnName = "SUBITEM"
        oDtAlternativo.Columns("TCITCL1").ColumnName = "COD. SUBITEM"
        oDtAlternativo.Columns("TDITES1").ColumnName = "DESCRIPCION SUBITEM"
        oDtAlternativo.Columns("QCNRCP").ColumnName = "CANTIDAD "

        oDtAlternativo.TableName = "Inventario"
        oDs.Tables.Add(oDtAlternativo)

        '*********
        Dim oDtv3 As DataView = New DataView(oDtRe)
        Dim oDtv2 As DataView = New DataView(oDtRe)
        Dim oDtResumen As New DataTable
        Dim oDt1 As New DataTable
        Dim oDt4 As New DataTable
        Dim oDt3 As New DataTable
        Dim oDtFiltro2 As New DataTable
        Dim oDr As DataRow

        oDt1 = oDtv3.ToTable(True, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA", "CREFFW", "QREFFW", "QPSOBL", "QVLBTO")
        oDt4 = oDtv2.ToTable(True, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA")
        Dim oDtv4 As DataView = New DataView(oDt4)
        oDtv4.Sort = "CCLNT, TIPO_ALMACEN ASC"
        oDt3 = oDtv4.ToTable(False, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA")
        oDtResumen.Columns.Add("TCMPCL1")
        oDtResumen.Columns.Add("TIPO_ALMACEN1")
        oDtResumen.Columns.Add("ALMACEN1")
        oDtResumen.Columns.Add("ZONA")
        oDtResumen.Columns.Add("QREFFW")
        oDtResumen.Columns.Add("QPSOBL")
        oDtResumen.Columns.Add("QVLBTO")

        For i As Integer = 0 To oDt3.Rows.Count - 1
            oDtFiltro2 = SelectDataTable(oDt1, "CCLNT = '" + oDt3.Rows(i).Item("CCLNT").ToString.Trim + "' AND TIPO_ALMACEN = '" + oDt3.Rows(i).Item("TIPO_ALMACEN") + "' AND ALMACEN = '" + oDt3.Rows(i).Item("ALMACEN") + "' AND ZONA = '" + oDt3.Rows(i).Item("ZONA") + "' ")
            oDr = oDtResumen.NewRow()
            oDr("TCMPCL1") = oDt3.Rows(i).Item("TCMPCL")
            oDr("TIPO_ALMACEN1") = oDt3.Rows(i).Item("TIPO_ALMACEN")
            oDr("ALMACEN1") = oDt3.Rows(i).Item("ALMACEN")
            oDr("ZONA") = oDt3.Rows(i).Item("ZONA")
            oDr("QREFFW") = SumarDataTable(oDtFiltro2, "QREFFW")
            oDr("QPSOBL") = SumarDataTable(oDtFiltro2, "QPSOBL")
            oDr("QVLBTO") = SumarDataTable(oDtFiltro2, "QVLBTO")
            oDtResumen.Rows.Add(oDr)
        Next

        oDtResumen.Columns("TCMPCL1").ColumnName = "RAZON SOCIAL"
        oDtResumen.Columns("TIPO_ALMACEN1").ColumnName = "TIPO ALMACEN"
        oDtResumen.Columns("ALMACEN1").ColumnName = "ALMACEN"
        oDtResumen.Columns("ZONA").ColumnName = "ZONA"
        oDtResumen.Columns("QREFFW").ColumnName = "INVENTARIO \n CANTIDAD"
        oDtResumen.Columns("QPSOBL").ColumnName = "INVENTARIO \n PESO"
        oDtResumen.Columns("QVLBTO").ColumnName = "INVENTARIO \n VOLUMEN"

        oDtResumen.TableName = "Resumen"
        oDs.Tables.Add(oDtResumen)
        '*********

        If Me.txtSentidoCarga.Tag Is Nothing OrElse Me.txtSentidoCarga.Tag = "" Then
            strSentidoCarga = "TODOS"
        Else
            strSentidoCarga = Me.txtSentidoCarga.Text
        End If
        Dim strlTitulo As New List(Of String)
        'strlTitulo.Add("Cliente :\n" & Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial)
        strlTitulo.Add("Planta :\n" & Me.UcPLanta_Cmb011.DescripcionPlanta)
        If (Me.txtUbicacionReferencial.Tag Is Nothing OrElse Me.txtUbicacionReferencial.Tag = "") AndAlso Me.txtUbicacionReferencial.Text = "" Then
            strlTitulo.Add("Ubicación :\nTODOS")
        Else
            strlTitulo.Add("Ubicación :\n" & Me.txtUbicacionReferencial.Text)
        End If
        If Me.txtTipoMovimiento.Tag Is Nothing OrElse Me.txtTipoMovimiento.Tag = "" Then
            strlTitulo.Add("Tipo de Mov.:\nTODOS")
        Else
            strlTitulo.Add("Tipo de Mov.:\n" & Me.txtTipoMovimiento.Text)
        End If
        strlTitulo.Add("Sentido de Carga:\n" & strSentidoCarga)
        strlTitulo.Add("Fechas  de Inventario:\n" & Me.dteFechaInventario.Value.Date)

        HelpClass.ExportExcelConTitulosAlmacen(oDs, Me.Text, strlTitulo)
    End Sub

    Private Sub ExportarExcelSubItem_3(ByVal oDtExcel As DataTable, ByVal strTitulo As String, ByVal oDtRe As DataTable)
        Dim oDt As New DataTable
        Dim objListdt As New List(Of DataTable)
        Dim oDs As New DataSet
        Dim strSentidoCarga As String = String.Empty

        'oDt = oDtExcel.Copy
        oDt = GeneraDataTableSubItem(oDtExcel.Copy)
        oDt.Columns("CCLNT").ColumnName = "CLIENTE"
        oDt.Columns("TCMPCL").ColumnName = "RAZON SOCIAL"
        oDt.Columns("TUBRFR").ColumnName = "UBICACIÓN"
        oDt.Columns("CREFFW").ColumnName = "CODIGO  BULTO"
        oDt.Columns("FINGAL").ColumnName = "FECHA  INGRESO"
        oDt.Columns("HORIDE").ColumnName = "HORA  INGRESO"
        oDt.Columns("QREFFW").ColumnName = "QTA  BULTO"
        oDt.Columns("TIPBTO").ColumnName = "TIPO"
        oDt.Columns("QPSOBL").ColumnName = "PESO  BULTO"
        oDt.Columns("QVLBTO").ColumnName = "VOL. BULTO"
        oDt.Columns("TTINTC").ColumnName = "ORIGEN"
        oDt.Columns("TPRVCL").ColumnName = "PROVEEDOR"
        oDt.Columns("QAROCP").ColumnName = "AREA BULTO"
        oDt.Columns("TNOMCOM").ColumnName = "COMPRADOR "
        oDt.Columns("NORCML").ColumnName = "ORDEN COMPRA"
        oDt.Columns("NRITOC").ColumnName = "ITEM"
        oDt.Columns("TCITCL").ColumnName = "COD. ITEM"
        oDt.Columns("TCITPR").ColumnName = "COD. ITEM PROV"
        oDt.Columns("TDITES").ColumnName = "DESCRIPCION DEL ITEM"
        oDt.Columns("IVUNIT").ColumnName = "PRECIO UNITARIO "
        oDt.Columns("QSLCNB").ColumnName = "SALDO  CANTIDAD"
        oDt.Columns("TUNDIT").ColumnName = "UNIDAD"
        oDt.Columns("QPEPQT").ColumnName = "PESO ITEM  "
        oDt.Columns("QVOPQT").ColumnName = "VOL ITEM"
        oDt.Columns("NGRPRV").ColumnName = "Nro GUIA"
        oDt.Columns("TLUGEN").ColumnName = "LUGAR"
        oDt.Columns("SSNCRG").ColumnName = "SENTIDO DE ENTREGA"
        oDt.Columns("DIAS").ColumnName = "DIAS EN ALMACEN"
        oDt.Columns("MARRET").ColumnName = "CUSTODIA RETENCION"
        oDt.Columns("NORAGN").ColumnName = "Nº ORDEN DE SERVICIO"
        oDt.Columns("NFACPR").ColumnName = "FACTURA COMERCIAL"
        oDt.Columns("FFACPR").ColumnName = "FECHA FACTURA COMERCIAL"

        oDt.Columns("SBITOC").ColumnName = "SUBITEM"
        oDt.Columns("TCITCL1").ColumnName = "COD. SUBITEM"
        oDt.Columns("TDITES1").ColumnName = "DESCRIPCION SUBITEM"
        oDt.Columns("QCNRCP").ColumnName = "CANTIDAD "
        oDt.Columns.Remove("CIDPAQ")
        oDt.Columns.Remove("TNMMDT_ENVIO")
        oDt.Columns.Remove("TMRCTR")
        oDt.TableName = "Inventario Almacen "
        oDs.Tables.Add(oDt)

        '*************************Resumen**********************************'
        Dim oDtv3 As DataView = New DataView(oDtRe)
        Dim oDtv2 As DataView = New DataView(oDtRe)
        Dim oDtResumen As New DataTable
        Dim oDt1 As New DataTable
        Dim oDt4 As New DataTable
        Dim oDt3 As New DataTable
        Dim oDtFiltro2 As New DataTable
        Dim oDr As DataRow

        oDt1 = oDtv3.ToTable(True, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA", "CREFFW", "QREFFW", "QPSOBL", "QVLBTO")
        oDt4 = oDtv2.ToTable(True, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA")
        Dim oDtv4 As DataView = New DataView(oDt4)
        oDtv4.Sort = "CCLNT, TIPO_ALMACEN ASC"
        oDt3 = oDtv4.ToTable(False, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA")
        oDtResumen.Columns.Add("TCMPCL1")
        oDtResumen.Columns.Add("TIPO_ALMACEN1")
        oDtResumen.Columns.Add("ALMACEN1")
        oDtResumen.Columns.Add("ZONA")
        oDtResumen.Columns.Add("QREFFW")
        oDtResumen.Columns.Add("QPSOBL")
        oDtResumen.Columns.Add("QVLBTO")

        For i As Integer = 0 To oDt3.Rows.Count - 1
            oDtFiltro2 = SelectDataTable(oDt1, "CCLNT = '" + oDt3.Rows(i).Item("CCLNT").ToString.Trim + "' AND TIPO_ALMACEN = '" + oDt3.Rows(i).Item("TIPO_ALMACEN") + "' AND ALMACEN = '" + oDt3.Rows(i).Item("ALMACEN") + "' AND ZONA = '" + oDt3.Rows(i).Item("ZONA") + "' ")
            oDr = oDtResumen.NewRow()
            oDr("TCMPCL1") = oDt3.Rows(i).Item("TCMPCL")
            oDr("TIPO_ALMACEN1") = oDt3.Rows(i).Item("TIPO_ALMACEN")
            oDr("ALMACEN1") = oDt3.Rows(i).Item("ALMACEN")
            oDr("ZONA") = oDt3.Rows(i).Item("ZONA")
            oDr("QREFFW") = SumarDataTable(oDtFiltro2, "QREFFW")
            oDr("QPSOBL") = SumarDataTable(oDtFiltro2, "QPSOBL")
            oDr("QVLBTO") = SumarDataTable(oDtFiltro2, "QVLBTO")
            oDtResumen.Rows.Add(oDr)
        Next

        oDtResumen.Columns("TCMPCL1").ColumnName = "RAZON SOCIAL"
        oDtResumen.Columns("TIPO_ALMACEN1").ColumnName = "TIPO ALMACEN"
        oDtResumen.Columns("ALMACEN1").ColumnName = "ALMACEN"
        oDtResumen.Columns("ZONA").ColumnName = "ZONA"
        oDtResumen.Columns("QREFFW").ColumnName = "INVENTARIO \n CANTIDAD"
        oDtResumen.Columns("QPSOBL").ColumnName = "INVENTARIO \n PESO"
        oDtResumen.Columns("QVLBTO").ColumnName = "INVENTARIO \n VOLUMEN"

        oDtResumen.TableName = "Resumen"
        oDs.Tables.Add(oDtResumen)
        '*********

        If Me.txtSentidoCarga.Tag Is Nothing OrElse Me.txtSentidoCarga.Tag = "" Then
            strSentidoCarga = "TODOS"
        Else
            strSentidoCarga = Me.txtSentidoCarga.Text
        End If
        Dim strlTitulo As New List(Of String)
        'strlTitulo.Add("Cliente :\n" & Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial)
        strlTitulo.Add("Planta :\n" & Me.UcPLanta_Cmb011.DescripcionPlanta)
        If (Me.txtUbicacionReferencial.Tag Is Nothing OrElse Me.txtUbicacionReferencial.Tag = "") AndAlso Me.txtUbicacionReferencial.Text = "" Then
            strlTitulo.Add("Ubicación :\nTODOS")
        Else
            strlTitulo.Add("Ubicación :\n" & Me.txtUbicacionReferencial.Text)
        End If
        If Me.txtTipoMovimiento.Tag Is Nothing OrElse Me.txtTipoMovimiento.Tag = "" Then
            strlTitulo.Add("Tipo de Mov.:\nTODOS")
        Else
            strlTitulo.Add("Tipo de Mov.:\n" & Me.txtTipoMovimiento.Text)
        End If
        strlTitulo.Add("Sentido de Carga:\n" & strSentidoCarga)
        strlTitulo.Add("Fechas  de Inventario:\n" & Me.dteFechaInventario.Value.Date)

        HelpClass.ExportExcelConTitulosAlmacen(oDs, Me.Text, strlTitulo)
    End Sub

    Private Sub ExportarExcelSubItem_4(ByVal oDtExcel As DataTable, ByVal strTitulo As String, ByVal oDtRe As DataTable)
        Dim oDtAlternativo As New DataTable
        Dim objListdt As New List(Of DataTable)
        Dim oDs As New DataSet
        Dim strSentidoCarga As String = String.Empty

        oDtAlternativo = GeneraDtAlternativo_1(oDtExcel, True)

        oDtAlternativo.Columns("TUBRFR").ColumnName = "UBICACIÓN"
        oDtAlternativo.Columns("CREFFW").ColumnName = "CODIGO  BULTO"
        oDtAlternativo.Columns("FINGAL").ColumnName = "FECHA  INGRESO"
        oDtAlternativo.Columns("HORIDE").ColumnName = "HORA  INGRESO"
        oDtAlternativo.Columns("QREFFW").ColumnName = "QTA  BULTO"
        oDtAlternativo.Columns("TIPBTO").ColumnName = "TIPO"
        oDtAlternativo.Columns("QPSOBL").ColumnName = "PESO  BULTO"
        oDtAlternativo.Columns("QVLBTO").ColumnName = "VOL. BULTO"
        oDtAlternativo.Columns("TTINTC").ColumnName = "ORIGEN"
        oDtAlternativo.Columns("TPRVCL").ColumnName = "PROVEEDOR"
        oDtAlternativo.Columns("QAROCP").ColumnName = "AREA BULTO"
        oDtAlternativo.Columns("TNOMCOM").ColumnName = "COMPRADOR "
        oDtAlternativo.Columns("NORCML").ColumnName = "ORDEN COMPRA"
        oDtAlternativo.Columns("NRITOC").ColumnName = "ITEM"
        oDtAlternativo.Columns("TCITCL").ColumnName = "COD. ITEM"
        oDtAlternativo.Columns("TDITES").ColumnName = "DESCRIPCION DEL ITEM"
        oDtAlternativo.Columns("IVUNIT").ColumnName = "PRECIO UNITARIO "
        oDtAlternativo.Columns("QSLCNB").ColumnName = "SALDO  CANTIDAD"
        oDtAlternativo.Columns("TUNDIT").ColumnName = "UNIDAD"
        oDtAlternativo.Columns("QPEPQT").ColumnName = "PESO ITEM  "
        oDtAlternativo.Columns("QVOPQT").ColumnName = "VOL ITEM"
        oDtAlternativo.Columns("NGRPRV").ColumnName = "Nro GUIA"
        oDtAlternativo.Columns("TLUGEN").ColumnName = "LUGAR"
        oDtAlternativo.Columns("SSNCRG").ColumnName = "SENTIDO DE ENTREGA"
        oDtAlternativo.Columns("DIAS").ColumnName = "DIAS EN ALMACEN"
        oDtAlternativo.Columns("MARRET").ColumnName = "CUSTODIA RETENCION"
        oDtAlternativo.Columns("NORAGN").ColumnName = "Nº ORDEN DE SERVICIO"
        oDtAlternativo.Columns("NFACPR").ColumnName = "FACTURA COMERCIAL"
        oDtAlternativo.Columns("FFACPR").ColumnName = "FECHA FACTURA COMERCIAL"

        oDtAlternativo.Columns("SBITOC").ColumnName = "SUBITEM"
        oDtAlternativo.Columns("TCITCL1").ColumnName = "COD. SUBITEM"
        oDtAlternativo.Columns("TDITES1").ColumnName = "DESCRIPCION SUBITEM"
        oDtAlternativo.Columns("QCNRCP").ColumnName = "CANTIDAD "


        oDtAlternativo.TableName = "Inventario Almacen"
        oDs.Tables.Add(oDtAlternativo)

        '*************************Resumen**********************************'
        Dim oDtv3 As DataView = New DataView(oDtRe)
        Dim oDtv2 As DataView = New DataView(oDtRe)
        Dim oDtResumen As New DataTable
        Dim oDt1 As New DataTable
        Dim oDt4 As New DataTable
        Dim oDt3 As New DataTable
        Dim oDtFiltro2 As New DataTable
        Dim oDr As DataRow

        oDt1 = oDtv3.ToTable(True, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA", "CREFFW", "QREFFW", "QPSOBL", "QVLBTO")
        oDt4 = oDtv2.ToTable(True, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA")
        Dim oDtv4 As DataView = New DataView(oDt4)
        oDtv4.Sort = "CCLNT, TIPO_ALMACEN ASC"
        oDt3 = oDtv4.ToTable(False, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA")
        oDtResumen.Columns.Add("TCMPCL1")
        oDtResumen.Columns.Add("TIPO_ALMACEN1")
        oDtResumen.Columns.Add("ALMACEN1")
        oDtResumen.Columns.Add("ZONA")
        oDtResumen.Columns.Add("QREFFW")
        oDtResumen.Columns.Add("QPSOBL")
        oDtResumen.Columns.Add("QVLBTO")

        For i As Integer = 0 To oDt3.Rows.Count - 1
            oDtFiltro2 = SelectDataTable(oDt1, "CCLNT = '" + oDt3.Rows(i).Item("CCLNT").ToString.Trim + "' AND TIPO_ALMACEN = '" + oDt3.Rows(i).Item("TIPO_ALMACEN") + "' AND ALMACEN = '" + oDt3.Rows(i).Item("ALMACEN") + "' AND ZONA = '" + oDt3.Rows(i).Item("ZONA") + "' ")
            oDr = oDtResumen.NewRow()
            oDr("TCMPCL1") = oDt3.Rows(i).Item("TCMPCL")
            oDr("TIPO_ALMACEN1") = oDt3.Rows(i).Item("TIPO_ALMACEN")
            oDr("ALMACEN1") = oDt3.Rows(i).Item("ALMACEN")
            oDr("ZONA") = oDt3.Rows(i).Item("ZONA")
            oDr("QREFFW") = SumarDataTable(oDtFiltro2, "QREFFW")
            oDr("QPSOBL") = SumarDataTable(oDtFiltro2, "QPSOBL")
            oDr("QVLBTO") = SumarDataTable(oDtFiltro2, "QVLBTO")
            oDtResumen.Rows.Add(oDr)
        Next

        oDtResumen.Columns("TCMPCL1").ColumnName = "RAZON SOCIAL"
        oDtResumen.Columns("TIPO_ALMACEN1").ColumnName = "TIPO ALMACEN"
        oDtResumen.Columns("ALMACEN1").ColumnName = "ALMACEN"
        oDtResumen.Columns("ZONA").ColumnName = "ZONA"
        oDtResumen.Columns("QREFFW").ColumnName = "INVENTARIO \n CANTIDAD"
        oDtResumen.Columns("QPSOBL").ColumnName = "INVENTARIO \n PESO"
        oDtResumen.Columns("QVLBTO").ColumnName = "INVENTARIO \n VOLUMEN"

        oDtResumen.TableName = "Resumen"
        oDs.Tables.Add(oDtResumen)
        '*********

        If Me.txtSentidoCarga.Tag Is Nothing OrElse Me.txtSentidoCarga.Tag = "" Then
            strSentidoCarga = "TODOS"
        Else
            strSentidoCarga = Me.txtSentidoCarga.Text
        End If
        Dim strlTitulo As New List(Of String)
        'strlTitulo.Add("Cliente :\n" & Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial)
        strlTitulo.Add("Planta :\n" & Me.UcPLanta_Cmb011.DescripcionPlanta)
        If (Me.txtUbicacionReferencial.Tag Is Nothing OrElse Me.txtUbicacionReferencial.Tag = "") AndAlso Me.txtUbicacionReferencial.Text = "" Then
            strlTitulo.Add("Ubicación :\nTODOS")
        Else
            strlTitulo.Add("Ubicación :\n" & Me.txtUbicacionReferencial.Text)
        End If
        If Me.txtTipoMovimiento.Tag Is Nothing OrElse Me.txtTipoMovimiento.Tag = "" Then
            strlTitulo.Add("Tipo de Mov.:\nTODOS")
        Else
            strlTitulo.Add("Tipo de Mov.:\n" & Me.txtTipoMovimiento.Text)
        End If
        strlTitulo.Add("Sentido de Carga:\n" & strSentidoCarga)
        strlTitulo.Add("Fechas  de Inventario:\n" & Me.dteFechaInventario.Value.Date)

        HelpClass.ExportExcelConTitulosAlmacen(oDs, Me.Text, strlTitulo)
    End Sub

    Private Sub ExportarExcelItem_3(ByVal oDtExcel As DataTable, ByVal strTitulo As String, ByVal oDtRe As DataTable)
        Dim oDt As New DataTable
        Dim objListdt As New List(Of DataTable)
        Dim oDs As New DataSet
        Dim strSentidoCarga As String = String.Empty

        oDt = oDtExcel.Copy
        '------Agregado los campos eliminados que son solo  para el modelo1 11-02-2014
        oDt.Columns.Remove("TPOOCM")
        oDt.Columns.Remove("TIPLIN")
        oDt.Columns.Remove("TRFRN")
        oDt.Columns.Remove("TCMAEM")
        '''''''''''''''''''''

        oDt.Columns("CCLNT").ColumnName = "CLIENTE"
        oDt.Columns("TCMPCL").ColumnName = "RAZON SOCIAL"
        oDt.Columns("TUBRFR").ColumnName = "UBICACIÓN"
        oDt.Columns("CREFFW").ColumnName = "CODIGO  BULTO"

        oDt.Columns("FINGAL").ColumnName = "FECHA  INGRESO"
        oDt.Columns("HORIDE").ColumnName = "HORA  INGRESO"
        oDt.Columns("QREFFW").ColumnName = "QTA  BULTO"
        oDt.Columns("TIPBTO").ColumnName = "TIPO"
        oDt.Columns("QPSOBL").ColumnName = "PESO  BULTO"
        oDt.Columns("QVLBTO").ColumnName = "VOL. BULTO"
        oDt.Columns("TTINTC").ColumnName = "ORIGEN"
        oDt.Columns("TPRVCL").ColumnName = "PROVEEDOR"
        oDt.Columns("QAROCP").ColumnName = "AREA BULTO"
        oDt.Columns("TNOMCOM").ColumnName = "COMPRADOR "
        oDt.Columns("NORCML").ColumnName = "ORDEN COMPRA"
        oDt.Columns("NRITOC").ColumnName = "ITEM"
        oDt.Columns("TCITCL").ColumnName = "COD. ITEM"
        oDt.Columns("TCITPR").ColumnName = "COD. ITEM PROV."
        oDt.Columns("TDITES").ColumnName = "DESCRIPCION DEL ITEM"
        oDt.Columns("IVUNIT").ColumnName = "PRECIO UNITARIO "
        oDt.Columns("QSLCNB").ColumnName = "SALDO  CANTIDAD"
        oDt.Columns("TUNDIT").ColumnName = "UNIDAD"
        oDt.Columns("QPEPQT").ColumnName = "PESO ITEM  "
        oDt.Columns("QVOPQT").ColumnName = "VOL ITEM"
        oDt.Columns("NGRPRV").ColumnName = "Nro GUIA"
        oDt.Columns("TLUGEN").ColumnName = "LUGAR"
        oDt.Columns("SSNCRG").ColumnName = "SENTIDO DE ENTREGA"
        oDt.Columns("DIAS").ColumnName = "DIAS EN ALMACEN"
        oDt.Columns("MARRET").ColumnName = "CUSTODIA RETENCION"
        oDt.Columns("NORAGN").ColumnName = "Nº ORDEN DE SERVICIO"
        oDt.Columns("NFACPR").ColumnName = "FACTURA COMERCIAL"
        oDt.Columns("FFACPR").ColumnName = "FECHA FACTURA COMERCIAL"

        oDt.Columns.Remove("CIDPAQ")
        oDt.Columns.Remove("SBITOC")
        oDt.Columns.Remove("TCITCL1")
        oDt.Columns.Remove("TDITES1")
        oDt.Columns.Remove("QCNRCP")
        oDt.Columns.Remove("TNMMDT_ENVIO")
        oDt.Columns.Remove("TMRCTR")

        oDt.TableName = "Inventario Almacen "
        oDs.Tables.Add(oDt)

        '*********
        Dim oDtv3 As DataView = New DataView(oDtRe)
        Dim oDtv2 As DataView = New DataView(oDtRe)
        Dim oDtResumen As New DataTable
        Dim oDt1 As New DataTable
        Dim oDt4 As New DataTable
        Dim oDt3 As New DataTable
        Dim oDtFiltro2 As New DataTable
        Dim oDr As DataRow

        oDt1 = oDtv3.ToTable(True, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA", "CREFFW", "QREFFW", "QPSOBL", "QVLBTO")
        oDt4 = oDtv2.ToTable(True, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA")
        Dim oDtv4 As DataView = New DataView(oDt4)
        oDtv4.Sort = "CCLNT, TIPO_ALMACEN ASC"
        oDt3 = oDtv4.ToTable(False, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA")
        oDtResumen.Columns.Add("TCMPCL1")
        oDtResumen.Columns.Add("TIPO_ALMACEN1")
        oDtResumen.Columns.Add("ALMACEN1")
        oDtResumen.Columns.Add("ZONA")
        oDtResumen.Columns.Add("QREFFW")
        oDtResumen.Columns.Add("QPSOBL")
        oDtResumen.Columns.Add("QVLBTO")

        For i As Integer = 0 To oDt3.Rows.Count - 1
            oDtFiltro2 = SelectDataTable(oDt1, "CCLNT = '" + oDt3.Rows(i).Item("CCLNT").ToString.Trim + "' AND TIPO_ALMACEN = '" + oDt3.Rows(i).Item("TIPO_ALMACEN") + "' AND ALMACEN = '" + oDt3.Rows(i).Item("ALMACEN") + "' AND ZONA = '" + oDt3.Rows(i).Item("ZONA") + "' ")
            oDr = oDtResumen.NewRow()
            oDr("TCMPCL1") = oDt3.Rows(i).Item("TCMPCL")
            oDr("TIPO_ALMACEN1") = oDt3.Rows(i).Item("TIPO_ALMACEN")
            oDr("ALMACEN1") = oDt3.Rows(i).Item("ALMACEN")
            oDr("ZONA") = oDt3.Rows(i).Item("ZONA")
            oDr("QREFFW") = SumarDataTable(oDtFiltro2, "QREFFW")
            oDr("QPSOBL") = SumarDataTable(oDtFiltro2, "QPSOBL")
            oDr("QVLBTO") = SumarDataTable(oDtFiltro2, "QVLBTO")
            oDtResumen.Rows.Add(oDr)
        Next

        oDtResumen.Columns("TCMPCL1").ColumnName = "RAZON SOCIAL"
        oDtResumen.Columns("TIPO_ALMACEN1").ColumnName = "TIPO ALMACEN"
        oDtResumen.Columns("ALMACEN1").ColumnName = "ALMACEN"
        oDtResumen.Columns("ZONA").ColumnName = "ZONA"
        oDtResumen.Columns("QREFFW").ColumnName = "INVENTARIO \n CANTIDAD"
        oDtResumen.Columns("QPSOBL").ColumnName = "INVENTARIO \n PESO"
        oDtResumen.Columns("QVLBTO").ColumnName = "INVENTARIO \n VOLUMEN"

        oDtResumen.TableName = "Resumen"

        oDs.Tables.Add(oDtResumen)
        '*********

        If Me.txtSentidoCarga.Tag Is Nothing OrElse Me.txtSentidoCarga.Tag = "" Then
            strSentidoCarga = "TODOS"
        Else
            strSentidoCarga = Me.txtSentidoCarga.Text
        End If
        Dim strlTitulo As New List(Of String)
        'strlTitulo.Add("Cliente :\n" & Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial)
        strlTitulo.Add("Planta :\n" & Me.UcPLanta_Cmb011.DescripcionPlanta)
        If (Me.txtUbicacionReferencial.Tag Is Nothing OrElse Me.txtUbicacionReferencial.Tag = "") AndAlso Me.txtUbicacionReferencial.Text = "" Then
            strlTitulo.Add("Ubicación :\nTODOS")
        Else
            strlTitulo.Add("Ubicación :\n" & Me.txtUbicacionReferencial.Text)
        End If
        If Me.txtTipoMovimiento.Tag Is Nothing OrElse Me.txtTipoMovimiento.Tag = "" Then
            strlTitulo.Add("Tipo de Mov.:\nTODOS")
        Else
            strlTitulo.Add("Tipo de Mov.:\n" & Me.txtTipoMovimiento.Text)
        End If
        strlTitulo.Add("Sentido de Carga:\n" & strSentidoCarga)
        strlTitulo.Add("Fechas  de Inventario:\n" & Me.dteFechaInventario.Value.Date)

        HelpClass.ExportExcelConTitulosAlmacen(oDs, Me.Text, strlTitulo)
    End Sub
    'CSR-HUNDRED-101016-MATERIALES-PELIGROSOS-INICIO
    'Private Sub ExportarExcel_ModeloMatpel(ByVal oDtExcel As DataTable, ByVal strTitulo As String, ByVal oDtRe As DataTable)
    '    Dim oDt As New DataTable
    '    Dim dtReporte As New DataTable
    '    Dim objListdt As New List(Of DataTable)
    '    Dim oDs As New DataSet
    '    Dim strSentidoCarga As String = String.Empty

    '    'For i As Integer = 0 To oDtExcel.Rows.Count - 1
    '    '    If oDtExcel.Rows(i).Item("FCHCAD").ToString().Trim = "" Then
    '    '        oDtExcel.Rows(i).Item("FCHCAD") = "No tiene"
    '    '    End If
    '    'Next

    '    oDt = oDtExcel.Copy


    '    dtReporte.Columns.Add("CCLNT")
    '    dtReporte.Columns.Add("TCMPCL")
    '    dtReporte.Columns.Add("TUBRFR")
    '    dtReporte.Columns.Add("TIPO_ALMACEN")
    '    dtReporte.Columns.Add("ALMACEN")
    '    dtReporte.Columns.Add("ZONA")
    '    dtReporte.Columns.Add("CREFFW")
    '    dtReporte.Columns.Add("DESCRIPCION")
    '    dtReporte.Columns.Add("DES_MAT")
    '    dtReporte.Columns.Add("FINGAL")
    '    dtReporte.Columns.Add("HORIDE")
    '    dtReporte.Columns.Add("QREFFW", GetType(System.Decimal))

    '    dtReporte.Columns.Add("TIPBTO")
    '    dtReporte.Columns.Add("QPSOBL", GetType(System.Decimal))
    '    dtReporte.Columns.Add("QVLBTO", GetType(System.Decimal))
    '    dtReporte.Columns.Add("TTINTC")
    '    dtReporte.Columns.Add("TPRVCL")
    '    dtReporte.Columns.Add("QAROCP", GetType(System.Decimal))
    '    dtReporte.Columns.Add("NORCML")
    '    dtReporte.Columns.Add("PARCIAL")
    '    dtReporte.Columns.Add("IMPORTE", GetType(System.Decimal))
    '    dtReporte.Columns.Add("NRITOC")
    '    dtReporte.Columns.Add("TCITCL")
    '    dtReporte.Columns.Add("TDITES")
    '    dtReporte.Columns.Add("IVUNIT", GetType(System.Decimal))
    '    dtReporte.Columns.Add("QSLCNB", GetType(System.Decimal))
    '    dtReporte.Columns.Add("TUNDIT")
    '    dtReporte.Columns.Add("DES_CND")
    '    dtReporte.Columns.Add("FGIQBF")
    '    dtReporte.Columns.Add("DES_CLASE")
    '    dtReporte.Columns.Add("CUNMAT")
    '    dtReporte.Columns.Add("FCHCAD")
    '    dtReporte.Columns.Add("TLUGEN")
    '    dtReporte.Columns.Add("NGRPRV")
    '    dtReporte.Columns.Add("SSNCRG")
    '    dtReporte.Columns.Add("DIAS", GetType(System.Decimal))
    '    dtReporte.Columns.Add("MARRET")  'CSR-021116



    '    'dtReporte = oDtExcel.Copy

    '    For Each row As DataRow In oDtExcel.Rows
    '        Dim drow As DataRow
    '        drow = dtReporte.NewRow

    '        For Each col As DataColumn In dtReporte.Columns
    '            drow(col.ColumnName) = row(col.ColumnName)

    '        Next
    '        dtReporte.Rows.Add(drow)
    '    Next



    '    dtReporte.Columns("CCLNT").ColumnName = "CLIENTE"
    '    dtReporte.Columns("TCMPCL").ColumnName = "RAZÓN SOCIAL"
    '    dtReporte.Columns("TUBRFR").ColumnName = "UBICACIÓN"
    '    dtReporte.Columns("TIPO_ALMACEN").ColumnName = "TIPO_ALMACEN"
    '    dtReporte.Columns("ALMACEN").ColumnName = "ALMACEN"
    '    dtReporte.Columns("ZONA").ColumnName = "ZONA"
    '    dtReporte.Columns("CREFFW").ColumnName = "CÓDIGO BULTO"
    '    dtReporte.Columns("DESCRIPCION").ColumnName = "DESCRIPCIÓN"
    '    dtReporte.Columns("DES_MAT").ColumnName = "TIPO MATERIAL"
    '    dtReporte.Columns("FINGAL").ColumnName = "FECHA INGRESO"
    '    dtReporte.Columns("HORIDE").ColumnName = "HORA  INGRESO"
    '    dtReporte.Columns("QREFFW").ColumnName = "QTA BULTO"
    '    dtReporte.Columns("TIPBTO").ColumnName = "UNIDAD MEDIDA"
    '    dtReporte.Columns("QPSOBL").ColumnName = "PESO BULTO"
    '    dtReporte.Columns("QVLBTO").ColumnName = "VOL. BULTO"
    '    dtReporte.Columns("TTINTC").ColumnName = "ORIGEN"
    '    dtReporte.Columns("TPRVCL").ColumnName = "PROVEEDOR"
    '    dtReporte.Columns("QAROCP").ColumnName = "AREA BULTO"
    '    dtReporte.Columns("NORCML").ColumnName = "ORDEN COMPRA"
    '    dtReporte.Columns("PARCIAL").ColumnName = "PARCIAL"
    '    dtReporte.Columns("IMPORTE").ColumnName = "IMPORTE"
    '    dtReporte.Columns("NRITOC").ColumnName = "ITEM"
    '    dtReporte.Columns("TCITCL").ColumnName = "COD. ITEM"
    '    dtReporte.Columns("TDITES").ColumnName = "DESCRIPCIÓN DEL ITEM"
    '    dtReporte.Columns("IVUNIT").ColumnName = "PRECIO UNITARIO"
    '    dtReporte.Columns("QSLCNB").ColumnName = "SALDO CANTIDAD"
    '    dtReporte.Columns("DES_CND").ColumnName = "CONDICION"
    '    dtReporte.Columns("FGIQBF").ColumnName = "IQBF"
    '    dtReporte.Columns("DES_CLASE").ColumnName = "CLASE"
    '    dtReporte.Columns("CUNMAT").ColumnName = "COD. UN"
    '    dtReporte.Columns("FCHCAD").ColumnName = "FECHA DE CADUCIDAD"
    '    dtReporte.Columns("NGRPRV").ColumnName = "GUÍA PROVEEDOR"
    '    dtReporte.Columns("SSNCRG").ColumnName = "SENTIDO DE ENTREGA"
    '    dtReporte.Columns("DIAS").ColumnName = "DÍAS EN ALMACÉN"
    '    dtReporte.Columns("MARRET").ColumnName = "CUSTODIA RETENCION" 'csr-021116
    '    dtReporte.Columns("TUNDIT").ColumnName = "UNIDAD_MEDIDA"
    '    dtReporte.Columns("TLUGEN").ColumnName = "LUGAR ENTREGA"

    '    dtReporte.TableName = "Inventario Almacen "
    '    oDs.Tables.Add(dtReporte)

    '    If Me.txtSentidoCarga.Tag Is Nothing OrElse Me.txtSentidoCarga.Tag = "" Then
    '        strSentidoCarga = "TODOS"
    '    Else
    '        strSentidoCarga = Me.txtSentidoCarga.Text
    '    End If
    '    Dim strlTitulo As New List(Of String)
    '    'strlTitulo.Add("Cliente :\n" & Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial)
    '    strlTitulo.Add("Planta :\n" & Me.UcPLanta_Cmb011.DescripcionPlanta)
    '    If (Me.txtUbicacionReferencial.Tag Is Nothing OrElse Me.txtUbicacionReferencial.Tag = "") AndAlso Me.txtUbicacionReferencial.Text = "" Then
    '        strlTitulo.Add("Ubicación :\nTODOS")
    '    Else
    '        strlTitulo.Add("Ubicación :\n" & Me.txtUbicacionReferencial.Text)
    '    End If
    '    If Me.txtTipoMovimiento.Tag Is Nothing OrElse Me.txtTipoMovimiento.Tag = "" Then
    '        strlTitulo.Add("Tipo de Mov.:\nTODOS")
    '    Else
    '        strlTitulo.Add("Tipo de Mov.:\n" & Me.txtTipoMovimiento.Text)
    '    End If
    '    strlTitulo.Add("Sentido de Carga:\n" & strSentidoCarga)
    '    strlTitulo.Add("Fechas  de Inventario:\n" & Me.dteFechaInventario.Value.Date)

    '    HelpClass.ExportExcelConTitulosAlmacen(oDs, Me.Text, strlTitulo)
    'End Sub


    Private Sub ExportarExcel_ModeloMatpel_v2(ByVal oDtExcel As DataTable, ByVal strTitulo As String, ByVal oDtRe As DataTable)

        Dim ListaDatatable As New List(Of DataTable)
        Dim NPOI_SC As New HelpClass_NPOI_SC
        Dim MdataColumna As String = ""


        Dim oDt As New DataTable
        Dim dtReporte As New DataTable
        Dim objListdt As New List(Of DataTable)
        Dim oDs As New DataSet
        Dim strSentidoCarga As String = String.Empty

        'For i As Integer = 0 To oDtExcel.Rows.Count - 1
        '    If oDtExcel.Rows(i).Item("FCHCAD").ToString().Trim = "" Then
        '        oDtExcel.Rows(i).Item("FCHCAD") = "No tiene"
        '    End If
        'Next

        oDt = oDtExcel.Copy


        dtReporte.Columns.Add("CCLNT")
        dtReporte.Columns.Add("TCMPCL")
        dtReporte.Columns.Add("TUBRFR")
        dtReporte.Columns.Add("TIPO_ALMACEN")
        dtReporte.Columns.Add("ALMACEN")
        dtReporte.Columns.Add("ZONA")
        dtReporte.Columns.Add("CREFFW")
        dtReporte.Columns.Add("DESCRIPCION")
        dtReporte.Columns.Add("DES_MAT")
        dtReporte.Columns.Add("FINGAL")
        dtReporte.Columns.Add("HORIDE")
        dtReporte.Columns.Add("QREFFW", GetType(System.Decimal))

        dtReporte.Columns.Add("TIPBTO")
        dtReporte.Columns.Add("QPSOBL", GetType(System.Decimal))
        dtReporte.Columns.Add("QVLBTO", GetType(System.Decimal))
        dtReporte.Columns.Add("TTINTC")
        dtReporte.Columns.Add("TPRVCL")
        dtReporte.Columns.Add("QAROCP", GetType(System.Decimal))
        dtReporte.Columns.Add("NORCML")
        dtReporte.Columns.Add("PARCIAL")
        dtReporte.Columns.Add("IMPORTE", GetType(System.Decimal))
        dtReporte.Columns.Add("NRITOC")
        dtReporte.Columns.Add("TCITCL")
        dtReporte.Columns.Add("TDITES")
        dtReporte.Columns.Add("IVUNIT", GetType(System.Decimal))
        dtReporte.Columns.Add("QSLCNB", GetType(System.Decimal))
        dtReporte.Columns.Add("TUNDIT")
        dtReporte.Columns.Add("DES_CND")
        dtReporte.Columns.Add("FGIQBF")
        dtReporte.Columns.Add("DES_CLASE")
        dtReporte.Columns.Add("CUNMAT")
        dtReporte.Columns.Add("FCHCAD")
        dtReporte.Columns.Add("TLUGEN")
        dtReporte.Columns.Add("NGRPRV")
        dtReporte.Columns.Add("SSNCRG")
        dtReporte.Columns.Add("DIAS", GetType(System.Decimal))
        dtReporte.Columns.Add("MARRET")  'CSR-021116



        'dtReporte = oDtExcel.Copy

        For Each row As DataRow In oDtExcel.Rows
            Dim drow As DataRow
            drow = dtReporte.NewRow

            For Each col As DataColumn In dtReporte.Columns
                drow(col.ColumnName) = row(col.ColumnName)

            Next
            dtReporte.Rows.Add(drow)
        Next



        'dtReporte.Columns("CCLNT").ColumnName = "CLIENTE"
        dtReporte.Columns("CCLNT").Caption = NPOI_SC.FormatDato("CLIENTE", NPOI_SC.keyDatoTexto)

        'dtReporte.Columns("TCMPCL").ColumnName = "RAZÓN SOCIAL"
        dtReporte.Columns("TCMPCL").Caption = NPOI_SC.FormatDato("RAZÓN SOCIAL", NPOI_SC.keyDatoTexto)

        'dtReporte.Columns("TUBRFR").ColumnName = "UBICACIÓN"
        dtReporte.Columns("TUBRFR").Caption = NPOI_SC.FormatDato("UBICACIÓN", NPOI_SC.keyDatoTexto)

        'dtReporte.Columns("TIPO_ALMACEN").ColumnName = "TIPO_ALMACEN"
        dtReporte.Columns("TIPO_ALMACEN").Caption = NPOI_SC.FormatDato("TIPO_ALMACEN", NPOI_SC.keyDatoTexto)

        'dtReporte.Columns("ALMACEN").ColumnName = "ALMACEN"
        dtReporte.Columns("ALMACEN").Caption = NPOI_SC.FormatDato("ALMACEN", NPOI_SC.keyDatoTexto)

        'dtReporte.Columns("ZONA").ColumnName = "ZONA"
        dtReporte.Columns("ZONA").Caption = NPOI_SC.FormatDato("ZONA", NPOI_SC.keyDatoTexto)

        'dtReporte.Columns("CREFFW").ColumnName = "CÓDIGO BULTO"
        dtReporte.Columns("CREFFW").Caption = NPOI_SC.FormatDato("CÓDIGO BULTO", NPOI_SC.keyDatoTexto)

        'dtReporte.Columns("DESCRIPCION").ColumnName = "DESCRIPCIÓN"
        dtReporte.Columns("DESCRIPCION").Caption = NPOI_SC.FormatDato("DESCRIPCIÓN", NPOI_SC.keyDatoTexto)

        'dtReporte.Columns("DES_MAT").ColumnName = "TIPO MATERIAL"
        dtReporte.Columns("DES_MAT").Caption = NPOI_SC.FormatDato("TIPO MATERIAL", NPOI_SC.keyDatoTexto)

        'dtReporte.Columns("FINGAL").ColumnName = "FECHA INGRESO"
        dtReporte.Columns("FINGAL").Caption = NPOI_SC.FormatDato("FECHA INGRESO", NPOI_SC.keyDatoTexto)

        'dtReporte.Columns("HORIDE").ColumnName = "HORA  INGRESO"
        dtReporte.Columns("HORIDE").Caption = NPOI_SC.FormatDato("HORA  INGRESO", NPOI_SC.keyDatoTexto)

        'dtReporte.Columns("QREFFW").ColumnName = "QTA BULTO"
        dtReporte.Columns("QREFFW").Caption = NPOI_SC.FormatDato("QTA BULTO", NPOI_SC.keyDatoNumero)

        'dtReporte.Columns("TIPBTO").ColumnName = "UNIDAD MEDIDA"
        dtReporte.Columns("TIPBTO").Caption = NPOI_SC.FormatDato("UNIDAD MEDIDA", NPOI_SC.keyDatoTexto)

        'dtReporte.Columns("QPSOBL").ColumnName = "PESO BULTO"
        dtReporte.Columns("QPSOBL").Caption = NPOI_SC.FormatDato("PESO BULTO", NPOI_SC.keyDatoNumero)

        'dtReporte.Columns("QVLBTO").ColumnName = "VOL. BULTO"
        dtReporte.Columns("QVLBTO").Caption = NPOI_SC.FormatDato("VOL. BULTO", NPOI_SC.keyDatoNumero)

        'dtReporte.Columns("TTINTC").ColumnName = "ORIGEN"
        dtReporte.Columns("TTINTC").Caption = NPOI_SC.FormatDato("ORIGEN", NPOI_SC.keyDatoTexto)

        'dtReporte.Columns("TPRVCL").ColumnName = "PROVEEDOR"
        dtReporte.Columns("TPRVCL").Caption = NPOI_SC.FormatDato("PROVEEDOR", NPOI_SC.keyDatoTexto)

        'dtReporte.Columns("QAROCP").ColumnName = "AREA BULTO"
        dtReporte.Columns("QAROCP").Caption = NPOI_SC.FormatDato("AREA BULTO", NPOI_SC.keyDatoNumero)

        'dtReporte.Columns("NORCML").ColumnName = "ORDEN COMPRA"
        dtReporte.Columns("NORCML").Caption = NPOI_SC.FormatDato("ORDEN COMPRA", NPOI_SC.keyDatoTexto)

        'dtReporte.Columns("PARCIAL").ColumnName = "PARCIAL"
        dtReporte.Columns("PARCIAL").Caption = NPOI_SC.FormatDato("PARCIAL", NPOI_SC.keyDatoTexto)

        'dtReporte.Columns("IMPORTE").ColumnName = "IMPORTE"
        dtReporte.Columns("IMPORTE").Caption = NPOI_SC.FormatDato("IMPORTE", NPOI_SC.keyDatoNumero)

        'dtReporte.Columns("NRITOC").ColumnName = "ITEM"
        dtReporte.Columns("NRITOC").Caption = NPOI_SC.FormatDato("ITEM", NPOI_SC.keyDatoTexto)

        'dtReporte.Columns("TCITCL").ColumnName = "COD. ITEM"
        dtReporte.Columns("TCITCL").Caption = NPOI_SC.FormatDato("COD. ITEM", NPOI_SC.keyDatoTexto)

        'dtReporte.Columns("TDITES").ColumnName = "DESCRIPCIÓN DEL ITEM"
        dtReporte.Columns("TDITES").Caption = NPOI_SC.FormatDato("DESCRIPCIÓN DEL ITEM", NPOI_SC.keyDatoTexto)

        'dtReporte.Columns("IVUNIT").ColumnName = "PRECIO UNITARIO"
        dtReporte.Columns("IVUNIT").Caption = NPOI_SC.FormatDato("PRECIO UNITARIO", NPOI_SC.keyDatoNumero)

        'dtReporte.Columns("QSLCNB").ColumnName = "SALDO CANTIDAD"
        dtReporte.Columns("QSLCNB").Caption = NPOI_SC.FormatDato("SALDO CANTIDAD", NPOI_SC.keyDatoNumero)

        'dtReporte.Columns("DES_CND").ColumnName = "CONDICION"
        dtReporte.Columns("DES_CND").Caption = NPOI_SC.FormatDato("CONDICION", NPOI_SC.keyDatoTexto)

        'dtReporte.Columns("FGIQBF").ColumnName = "IQBF"
        dtReporte.Columns("FGIQBF").Caption = NPOI_SC.FormatDato("IQBF", NPOI_SC.keyDatoTexto)

        'dtReporte.Columns("DES_CLASE").ColumnName = "CLASE"
        dtReporte.Columns("DES_CLASE").Caption = NPOI_SC.FormatDato("CLASE", NPOI_SC.keyDatoTexto)

        'dtReporte.Columns("CUNMAT").ColumnName = "COD. UN"
        dtReporte.Columns("CUNMAT").Caption = NPOI_SC.FormatDato("COD. UN", NPOI_SC.keyDatoTexto)

        'dtReporte.Columns("FCHCAD").ColumnName = "FECHA DE CADUCIDAD"
        dtReporte.Columns("FCHCAD").Caption = NPOI_SC.FormatDato("FECHA DE CADUCIDAD", NPOI_SC.keyDatoTexto)

        'dtReporte.Columns("NGRPRV").ColumnName = "GUÍA PROVEEDOR"
        dtReporte.Columns("NGRPRV").Caption = NPOI_SC.FormatDato("GUÍA PROVEEDOR", NPOI_SC.keyDatoTexto)

        'dtReporte.Columns("SSNCRG").ColumnName = "SENTIDO DE ENTREGA"
        dtReporte.Columns("SSNCRG").Caption = NPOI_SC.FormatDato("SENTIDO DE ENTREGA", NPOI_SC.keyDatoTexto)

        'dtReporte.Columns("DIAS").ColumnName = "DÍAS EN ALMACÉN"
        dtReporte.Columns("DIAS").Caption = NPOI_SC.FormatDato("DÍAS EN ALMACÉN", NPOI_SC.keyDatoNumero)

        'dtReporte.Columns("MARRET").ColumnName = "CUSTODIA RETENCION" 'csr-021116
        dtReporte.Columns("MARRET").Caption = NPOI_SC.FormatDato("CUSTODIA RETENCION", NPOI_SC.keyDatoTexto)

        'dtReporte.Columns("TUNDIT").ColumnName = "UNIDAD_MEDIDA"
        dtReporte.Columns("TUNDIT").Caption = NPOI_SC.FormatDato("UNIDAD_MEDIDA", NPOI_SC.keyDatoTexto)

        'dtReporte.Columns("TLUGEN").ColumnName = "LUGAR ENTREGA"
        dtReporte.Columns("TLUGEN").Caption = NPOI_SC.FormatDato("LUGAR ENTREGA", NPOI_SC.keyDatoTexto)

        dtReporte.TableName = "Inventario Almacen "
        oDs.Tables.Add(dtReporte)


        Dim bulto As String = ""
        Dim oList As New List(Of String)
        For Each item As DataRow In dtReporte.Rows
            bulto = ("" & item("CREFFW")).ToString.Trim
            If Not oList.Contains(bulto) Then
                oList.Add(bulto)
            Else
                item("QREFFW") = 0
                item("QPSOBL") = 0
                item("QVLBTO") = 0
                item("QAROCP") = 0
                'item("DIAS") = 0

            End If

        Next

        ListaDatatable.Add(dtReporte.Copy)

        Dim LisFiltros As New List(Of SortedList)
        Dim itemSortedList As SortedList
        Dim ListTitulo As New List(Of String)
        itemSortedList = New SortedList

        If Me.txtSentidoCarga.Tag Is Nothing OrElse Me.txtSentidoCarga.Tag = "" Then
            strSentidoCarga = "TODOS"
        Else
            strSentidoCarga = Me.txtSentidoCarga.Text
        End If
        Dim strlTitulo As New List(Of String)

        'strlTitulo.Add("Planta :\n" & Me.UcPLanta_Cmb011.DescripcionPlanta)
        itemSortedList.Add(itemSortedList.Count, "Planta:|" & Me.UcPLanta_Cmb011.DescripcionPlanta)

        If (Me.txtUbicacionReferencial.Tag Is Nothing OrElse Me.txtUbicacionReferencial.Tag = "") AndAlso Me.txtUbicacionReferencial.Text = "" Then
            'strlTitulo.Add("Ubicación :\nTODOS")
            itemSortedList.Add(itemSortedList.Count, "Ubicación:|TODOS")
        Else
            itemSortedList.Add(itemSortedList.Count, "Ubicación:|" & Me.txtUbicacionReferencial.Text)
            'strlTitulo.Add("Ubicación :\n" & Me.txtUbicacionReferencial.Text)
        End If
        If Me.txtTipoMovimiento.Tag Is Nothing OrElse Me.txtTipoMovimiento.Tag = "" Then
            'strlTitulo.Add("Tipo de Mov.:\nTODOS")
            itemSortedList.Add(itemSortedList.Count, "Tipo de Mov:|TODOS")
        Else
            'strlTitulo.Add("Tipo de Mov.:\n" & Me.txtTipoMovimiento.Text)
            itemSortedList.Add(itemSortedList.Count, "Tipo de Mov:|" & Me.txtTipoMovimiento.Text)
        End If
        'strlTitulo.Add("Sentido de Carga:\n" & strSentidoCarga)
        itemSortedList.Add(itemSortedList.Count, "Sentido de Carga:|" & strSentidoCarga)
        'strlTitulo.Add("Fechas  de Inventario:\n" & Me.dteFechaInventario.Value.Date)
        itemSortedList.Add(itemSortedList.Count, "Fecha de Inventario:|" & Me.dteFechaInventario.Value.Date)


        LisFiltros.Add(itemSortedList)

        Dim ListNameCombDuplicado As New List(Of String)
        Dim CombCol As String = "CREFFW:CREFFW/1"
        CombCol = CombCol & "|CCLNT:CREFFW,CCLNT/1"
        CombCol = CombCol & "|TCMPCL:CREFFW,TCMPCL/1"
        CombCol = CombCol & "|TUBRFR:CREFFW,TUBRFR/1"
        CombCol = CombCol & "|TIPO_ALMACEN:CREFFW,TIPO_ALMACEN/1"

        CombCol = CombCol & "|ALMACEN:CREFFW,ALMACEN/1"
        CombCol = CombCol & "|ZONA:CREFFW,ZONA/1"
        CombCol = CombCol & "|DESCRIPCION:CREFFW,DESCRIPCION/1"
        CombCol = CombCol & "|DES_MAT:CREFFW,DES_MAT/1"
        CombCol = CombCol & "|FINGAL:CREFFW,FINGAL/1"


        CombCol = CombCol & "|HORIDE:CREFFW,HORIDE/1"
        CombCol = CombCol & "|QREFFW:CREFFW,QREFFW/0"


        CombCol = CombCol & "|QPSOBL:CREFFW,QPSOBL/0"
        CombCol = CombCol & "|QVLBTO:CREFFW,QVLBTO/0"
        'CombCol = CombCol & "|SSNCRG:CREFFW,SSNCRG/1"
        CombCol = CombCol & "|TIPBTO:CREFFW,TIPBTO/1"

        CombCol = CombCol & "|QAROCP:CREFFW,QAROCP/0"
        'CombCol = CombCol & "|DIAS:CREFFW,DIAS/0"


        ListNameCombDuplicado.Add(CombCol)



        ListTitulo.Add("INVENTARIO POR UBICACION")
        NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListTitulo, Nothing, LisFiltros, 0, ListNameCombDuplicado)

        'HelpClass.ExportExcelConTitulosAlmacen(oDs, Me.Text, strlTitulo)
    End Sub


    Private Sub ExportarExcel_ModeloMatpel_Dimensiones(ByVal oDtExcel As DataTable, ByVal strTitulo As String, ByVal oDtRe As DataTable)

        Dim ListaDatatable As New List(Of DataTable)
        Dim NPOI_SC As New HelpClass_NPOI_SC
        Dim MdataColumna As String = ""
        Dim odtExcelTemp As New DataTable
        odtExcelTemp = oDtExcel.Copy
        odtExcelTemp.Columns.Add("CANT_PAQ")
        odtExcelTemp.Columns.Add("LARGO_PAQ")
        odtExcelTemp.Columns.Add("ALTO_PAQ")
        odtExcelTemp.Columns.Add("ANCHO_PAQ")
        odtExcelTemp.Columns.Add("VOL_LINEA")
        odtExcelTemp.Columns.Add("PESO_LINEA")
        odtExcelTemp.Columns.Add("TIPO")



        Dim dtReporte As New DataTable

        Dim oDs As New DataSet
        Dim strSentidoCarga As String = String.Empty


        Dim odtTemp As New DataTable
        odtTemp = odtExcelTemp.Copy
        odtTemp.Clear()

      


        Dim bulto_actual As String = ""
        Dim bulto_sig As String = ""

        Dim Fila As Int32 = 0
        Dim dtDimension As New DataTable
        dtDimension = dsResult.Tables(1).Copy

       
        '***********
        ' Se adicionan las dimenesiones al final de los bultos
        '************

        Dim pccmpn, pcdvsn, pcplndv, pcclnt, pcodbulto, pcorrelativo As String
        For Each item_principal As DataRow In odtExcelTemp.Rows
            Dim drow As DataRow
            drow = odtTemp.NewRow
            For Each col As DataColumn In odtTemp.Columns
                drow(col.ColumnName) = item_principal(col.ColumnName)
            Next
            drow("TIPO") = "ITEM"
            bulto_actual = ("" & item_principal("CREFFW")).ToString.Trim
            If Fila < (odtExcelTemp.Rows.Count - 1) Then
                bulto_sig = ("" & odtExcelTemp.Rows(Fila + 1)("CREFFW")).ToString.Trim
            Else
                bulto_sig = ""
            End If

            odtTemp.Rows.Add(drow)

            If bulto_actual <> bulto_sig Then
                Dim drListDimension() As DataRow
                pccmpn = item_principal("CCMPN")
                pcdvsn = item_principal("CDVSN")
                pcplndv = item_principal("CPLNDV")
                pcclnt = item_principal("CCLNT")
                pcodbulto = item_principal("CREFFW")
                pcorrelativo = item_principal("NSEQIN")

                drListDimension = dtDimension.Select("CCMPN='" & pccmpn & "' AND CDVSN='" & pcdvsn & "' AND CPLNDV='" & pcplndv & "' AND CCLNT='" & pcclnt & "' AND CREFFW='" & pcodbulto & "' AND NSEQIN='" & pcorrelativo & "'")

                For Each itemDimension As DataRow In drListDimension

                    Dim drFilaItemPrincipal As DataRow

                    drFilaItemPrincipal = odtTemp.NewRow


                    drFilaItemPrincipal("TIPO") = "DIMENSIONES"
                    drFilaItemPrincipal("CCLNT") = itemDimension("CCLNT")
                    drFilaItemPrincipal("TCMPCL") = item_principal("TCMPCL")

                    drFilaItemPrincipal("TUBRFR") = item_principal("TUBRFR")
                    drFilaItemPrincipal("TIPO_ALMACEN") = item_principal("TIPO_ALMACEN")
                    drFilaItemPrincipal("ALMACEN") = item_principal("ALMACEN")
                    drFilaItemPrincipal("ZONA") = item_principal("ZONA")
                    drFilaItemPrincipal("DESCRIPCION") = item_principal("DESCRIPCION")
                    drFilaItemPrincipal("TIPBTO") = item_principal("TIPBTO")

                    drFilaItemPrincipal("DES_MAT") = item_principal("DES_MAT")
                    drFilaItemPrincipal("FINGAL") = item_principal("FINGAL")
                    drFilaItemPrincipal("HORIDE") = item_principal("HORIDE")

                    drFilaItemPrincipal("CREFFW") = itemDimension("CREFFW")

                    drFilaItemPrincipal("CANT_PAQ") = itemDimension("CANT_PAQ")
                    drFilaItemPrincipal("LARGO_PAQ") = itemDimension("LARGO_PAQ")
                    drFilaItemPrincipal("ALTO_PAQ") = itemDimension("ALTO_PAQ")
                    drFilaItemPrincipal("ANCHO_PAQ") = itemDimension("ANCHO_PAQ")
                    drFilaItemPrincipal("VOL_LINEA") = itemDimension("VOL_LINEA")
                    drFilaItemPrincipal("PESO_LINEA") = itemDimension("PESO_LINEA")
                   
                    odtTemp.Rows.Add(drFilaItemPrincipal)
                Next

            End If

            Fila = Fila + 1
        Next




        dtReporte.Columns.Add("CCLNT")
        dtReporte.Columns.Add("TCMPCL")
        dtReporte.Columns.Add("TUBRFR")
        dtReporte.Columns.Add("TIPO_ALMACEN")
        dtReporte.Columns.Add("ALMACEN")
        dtReporte.Columns.Add("ZONA")
        dtReporte.Columns.Add("CREFFW")
        dtReporte.Columns.Add("DESCRIPCION")
        dtReporte.Columns.Add("DES_MAT")
        dtReporte.Columns.Add("FINGAL")
        dtReporte.Columns.Add("HORIDE")
        dtReporte.Columns.Add("QREFFW", GetType(System.Decimal))
        dtReporte.Columns.Add("TIPBTO")
        dtReporte.Columns.Add("QPSOBL", GetType(System.Decimal))
        dtReporte.Columns.Add("QVLBTO", GetType(System.Decimal))
        dtReporte.Columns.Add("QAROCP", GetType(System.Decimal))
        dtReporte.Columns.Add("TTINTC")
        dtReporte.Columns.Add("TIPO")


        dtReporte.Columns.Add("CANT_PAQ", GetType(System.Decimal))
        dtReporte.Columns.Add("LARGO_PAQ", GetType(System.Decimal))
        dtReporte.Columns.Add("ALTO_PAQ", GetType(System.Decimal))
        dtReporte.Columns.Add("ANCHO_PAQ", GetType(System.Decimal))
        dtReporte.Columns.Add("VOL_LINEA", GetType(System.Decimal))
        dtReporte.Columns.Add("PESO_LINEA", GetType(System.Decimal))


        dtReporte.Columns.Add("TPRVCL")
        'dtReporte.Columns.Add("QAROCP", GetType(System.Decimal))
        dtReporte.Columns.Add("NORCML")
        dtReporte.Columns.Add("PARCIAL")
        dtReporte.Columns.Add("IMPORTE", GetType(System.Decimal))
        dtReporte.Columns.Add("NRITOC")
        dtReporte.Columns.Add("TCITCL")
        dtReporte.Columns.Add("TDITES")
        dtReporte.Columns.Add("IVUNIT", GetType(System.Decimal))
        dtReporte.Columns.Add("QSLCNB", GetType(System.Decimal))
        dtReporte.Columns.Add("TUNDIT")
        dtReporte.Columns.Add("DES_CND")
        dtReporte.Columns.Add("FGIQBF")
        dtReporte.Columns.Add("DES_CLASE")
        dtReporte.Columns.Add("CUNMAT")
        dtReporte.Columns.Add("FCHCAD")
        dtReporte.Columns.Add("TLUGEN")
        dtReporte.Columns.Add("NGRPRV")
        dtReporte.Columns.Add("SSNCRG")
        dtReporte.Columns.Add("DIAS", GetType(System.Decimal))
        dtReporte.Columns.Add("MARRET")  'CSR-021116




        For Each row As DataRow In odtTemp.Rows
            Dim drow As DataRow
            drow = dtReporte.NewRow
            For Each col As DataColumn In dtReporte.Columns
                drow(col.ColumnName) = row(col.ColumnName)
            Next
            dtReporte.Rows.Add(drow)
        Next

   
        dtReporte.Columns("CCLNT").Caption = NPOI_SC.FormatDato("CLIENTE", NPOI_SC.keyDatoTexto)
        dtReporte.Columns("TCMPCL").Caption = NPOI_SC.FormatDato("RAZÓN SOCIAL", NPOI_SC.keyDatoTexto)
        dtReporte.Columns("TUBRFR").Caption = NPOI_SC.FormatDato("UBICACIÓN", NPOI_SC.keyDatoTexto)
        dtReporte.Columns("TIPO_ALMACEN").Caption = NPOI_SC.FormatDato("TIPO_ALMACEN", NPOI_SC.keyDatoTexto)
        dtReporte.Columns("ALMACEN").Caption = NPOI_SC.FormatDato("ALMACEN", NPOI_SC.keyDatoTexto)
        dtReporte.Columns("ZONA").Caption = NPOI_SC.FormatDato("ZONA", NPOI_SC.keyDatoTexto)
        dtReporte.Columns("CREFFW").Caption = NPOI_SC.FormatDato("CÓDIGO BULTO", NPOI_SC.keyDatoTexto)
        dtReporte.Columns("DESCRIPCION").Caption = NPOI_SC.FormatDato("DESCRIPCIÓN", NPOI_SC.keyDatoTexto)
        dtReporte.Columns("DES_MAT").Caption = NPOI_SC.FormatDato("TIPO MATERIAL", NPOI_SC.keyDatoTexto)
        dtReporte.Columns("FINGAL").Caption = NPOI_SC.FormatDato("FECHA INGRESO", NPOI_SC.keyDatoFecha)
        dtReporte.Columns("HORIDE").Caption = NPOI_SC.FormatDato("HORA  INGRESO", NPOI_SC.keyDatoTexto)
        dtReporte.Columns("QREFFW").Caption = NPOI_SC.FormatDato("QTA BULTO", NPOI_SC.keyDatoNumero)
        dtReporte.Columns("TIPBTO").Caption = NPOI_SC.FormatDato("UNIDAD MEDIDA", NPOI_SC.keyDatoTexto)
        dtReporte.Columns("QPSOBL").Caption = NPOI_SC.FormatDato("PESO BULTO", NPOI_SC.keyDatoNumero)
        dtReporte.Columns("QVLBTO").Caption = NPOI_SC.FormatDato("VOL. BULTO", NPOI_SC.keyDatoNumero)
        dtReporte.Columns("TTINTC").Caption = NPOI_SC.FormatDato("ORIGEN", NPOI_SC.keyDatoTexto)
        dtReporte.Columns("TIPO").Caption = NPOI_SC.FormatDato("TIPO", NPOI_SC.keyDatoTexto)


        dtReporte.Columns("CANT_PAQ").Caption = NPOI_SC.FormatDato("CANT. PAQ.", NPOI_SC.keyDatoNumero)
        dtReporte.Columns("LARGO_PAQ").Caption = NPOI_SC.FormatDato("LARGO PAQ.", NPOI_SC.keyDatoNumero)
        dtReporte.Columns("ALTO_PAQ").Caption = NPOI_SC.FormatDato("ALTO PAQ.", NPOI_SC.keyDatoNumero)
        dtReporte.Columns("ANCHO_PAQ").Caption = NPOI_SC.FormatDato("ANCHO PAQ.", NPOI_SC.keyDatoNumero)
        dtReporte.Columns("VOL_LINEA").Caption = NPOI_SC.FormatDato("VOL LINEA", NPOI_SC.keyDatoNumero)
        dtReporte.Columns("PESO_LINEA").Caption = NPOI_SC.FormatDato("PESO LINEA", NPOI_SC.keyDatoNumero)

        dtReporte.Columns("TPRVCL").Caption = NPOI_SC.FormatDato("PROVEEDOR", NPOI_SC.keyDatoTexto)
        dtReporte.Columns("QAROCP").Caption = NPOI_SC.FormatDato("AREA BULTO", NPOI_SC.keyDatoNumero)
        dtReporte.Columns("NORCML").Caption = NPOI_SC.FormatDato("ORDEN COMPRA", NPOI_SC.keyDatoTexto)
        dtReporte.Columns("PARCIAL").Caption = NPOI_SC.FormatDato("PARCIAL", NPOI_SC.keyDatoTexto)
        dtReporte.Columns("IMPORTE").Caption = NPOI_SC.FormatDato("IMPORTE", NPOI_SC.keyDatoNumero)
        dtReporte.Columns("NRITOC").Caption = NPOI_SC.FormatDato("ITEM", NPOI_SC.keyDatoTexto)
        dtReporte.Columns("TCITCL").Caption = NPOI_SC.FormatDato("COD. ITEM", NPOI_SC.keyDatoTexto)
        dtReporte.Columns("TDITES").Caption = NPOI_SC.FormatDato("DESCRIPCIÓN DEL ITEM", NPOI_SC.keyDatoTexto)
        dtReporte.Columns("IVUNIT").Caption = NPOI_SC.FormatDato("PRECIO UNITARIO", NPOI_SC.keyDatoNumero)
        dtReporte.Columns("QSLCNB").Caption = NPOI_SC.FormatDato("SALDO CANTIDAD", NPOI_SC.keyDatoNumero)
        dtReporte.Columns("DES_CND").Caption = NPOI_SC.FormatDato("CONDICION", NPOI_SC.keyDatoTexto)
        dtReporte.Columns("FGIQBF").Caption = NPOI_SC.FormatDato("IQBF", NPOI_SC.keyDatoTexto)
        dtReporte.Columns("DES_CLASE").Caption = NPOI_SC.FormatDato("CLASE", NPOI_SC.keyDatoTexto)
        dtReporte.Columns("CUNMAT").Caption = NPOI_SC.FormatDato("COD. UN", NPOI_SC.keyDatoTexto)
        'dtReporte.Columns("FCHCAD").Caption = NPOI_SC.FormatDato("FECHA DE CADUCIDAD", NPOI_SC.keyDatoTexto)
        dtReporte.Columns("FCHCAD").Caption = NPOI_SC.FormatDato("FECHA DE CADUCIDAD", NPOI_SC.keyDatoFecha)
        dtReporte.Columns("NGRPRV").Caption = NPOI_SC.FormatDato("GUÍA PROVEEDOR", NPOI_SC.keyDatoTexto)
        dtReporte.Columns("SSNCRG").Caption = NPOI_SC.FormatDato("SENTIDO DE ENTREGA", NPOI_SC.keyDatoTexto)
        dtReporte.Columns("DIAS").Caption = NPOI_SC.FormatDato("DÍAS EN ALMACÉN", NPOI_SC.keyDatoNumero)
        dtReporte.Columns("MARRET").Caption = NPOI_SC.FormatDato("CUSTODIA RETENCION", NPOI_SC.keyDatoTexto)
        dtReporte.Columns("TUNDIT").Caption = NPOI_SC.FormatDato("UNIDAD_MEDIDA", NPOI_SC.keyDatoTexto)
        dtReporte.Columns("TLUGEN").Caption = NPOI_SC.FormatDato("LUGAR ENTREGA", NPOI_SC.keyDatoTexto)

        dtReporte.TableName = "Inventario Almacen "
        oDs.Tables.Add(dtReporte)


        Dim bulto As String = ""
        Dim oList As New List(Of String)
        For Each item As DataRow In dtReporte.Rows
            bulto = ("" & item("CREFFW")).ToString.Trim
            If Not oList.Contains(bulto) Then
                oList.Add(bulto)
            Else
                item("QREFFW") = 0
                item("QPSOBL") = 0
                item("QVLBTO") = 0
                item("QAROCP") = 0
            End If

        Next

        ListaDatatable.Add(dtReporte.Copy)

        Dim LisFiltros As New List(Of SortedList)
        Dim itemSortedList As SortedList
        Dim ListTitulo As New List(Of String)
        itemSortedList = New SortedList

        If Me.txtSentidoCarga.Tag Is Nothing OrElse Me.txtSentidoCarga.Tag = "" Then
            strSentidoCarga = "TODOS"
        Else
            strSentidoCarga = Me.txtSentidoCarga.Text
        End If
        Dim strlTitulo As New List(Of String)

        itemSortedList.Add(itemSortedList.Count, "Planta:|" & Me.UcPLanta_Cmb011.DescripcionPlanta)

        If (Me.txtUbicacionReferencial.Tag Is Nothing OrElse Me.txtUbicacionReferencial.Tag = "") AndAlso Me.txtUbicacionReferencial.Text = "" Then
            itemSortedList.Add(itemSortedList.Count, "Ubicación:|TODOS")
        Else
            itemSortedList.Add(itemSortedList.Count, "Ubicación:|" & Me.txtUbicacionReferencial.Text)
        End If
        If Me.txtTipoMovimiento.Tag Is Nothing OrElse Me.txtTipoMovimiento.Tag = "" Then
            itemSortedList.Add(itemSortedList.Count, "Tipo de Mov:|TODOS")
        Else
            itemSortedList.Add(itemSortedList.Count, "Tipo de Mov:|" & Me.txtTipoMovimiento.Text)
        End If
        itemSortedList.Add(itemSortedList.Count, "Sentido de Carga:|" & strSentidoCarga)
        itemSortedList.Add(itemSortedList.Count, "Fecha de Inventario:|" & Me.dteFechaInventario.Value.Date)


        LisFiltros.Add(itemSortedList)

        Dim ListNameCombDuplicado As New List(Of String)
        Dim CombCol As String = "CREFFW:CREFFW/1"
        CombCol = CombCol & "|CCLNT:CREFFW,CCLNT/1"
        CombCol = CombCol & "|TCMPCL:CREFFW,TCMPCL/1"
        CombCol = CombCol & "|TUBRFR:CREFFW,TUBRFR/1"
        CombCol = CombCol & "|TIPO_ALMACEN:CREFFW,TIPO_ALMACEN/1"

        CombCol = CombCol & "|ALMACEN:CREFFW,ALMACEN/1"
        CombCol = CombCol & "|ZONA:CREFFW,ZONA/1"
        CombCol = CombCol & "|DESCRIPCION:CREFFW,DESCRIPCION/1"
        CombCol = CombCol & "|DES_MAT:CREFFW,DES_MAT/1"
        CombCol = CombCol & "|FINGAL:CREFFW,FINGAL/1"


        CombCol = CombCol & "|HORIDE:CREFFW,HORIDE/1"
        CombCol = CombCol & "|QREFFW:CREFFW,QREFFW/0"


        CombCol = CombCol & "|QPSOBL:CREFFW,QPSOBL/0"
        CombCol = CombCol & "|QVLBTO:CREFFW,QVLBTO/0"
        CombCol = CombCol & "|TIPBTO:CREFFW,TIPBTO/1"

        CombCol = CombCol & "|QAROCP:CREFFW,QAROCP/0"

        ListNameCombDuplicado.Add(CombCol)



        ListTitulo.Add("INVENTARIO POR UBICACION")
        NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListTitulo, Nothing, LisFiltros, 0, ListNameCombDuplicado)

        'HelpClass.ExportExcelConTitulosAlmacen(oDs, Me.Text, strlTitulo)
    End Sub

     

    'CSR-HUNDRED-101016-MATERIALES-PELIGROSOS-FIN

    Private Sub ExportarExcelItem_4(ByVal oDtExcel As DataTable, ByVal strTitulo As String, ByVal oDtRe As DataTable)
        Dim oDtAlternativo As New DataTable
        Dim objListdt As New List(Of DataTable)
        Dim oDs As New DataSet
        Dim strSentidoCarga As String = String.Empty

        oDtAlternativo = GeneraDtAlternativo_1(oDtExcel)
        oDtAlternativo.Columns("CCLNT").ColumnName = "CLIENTE"
        oDtAlternativo.Columns("TCMPCL").ColumnName = "RAZON SOCIAL"
        oDtAlternativo.Columns("TUBRFR").ColumnName = "UBICACIÓN"
        oDtAlternativo.Columns("CREFFW").ColumnName = "CODIGO  BULTO"
        oDtAlternativo.Columns("FINGAL").ColumnName = "FECHA  INGRESO"
        oDtAlternativo.Columns("HORIDE").ColumnName = "HORA  INGRESO"
        oDtAlternativo.Columns("QREFFW").ColumnName = "QTA  BULTO"
        oDtAlternativo.Columns("TIPBTO").ColumnName = "TIPO"
        oDtAlternativo.Columns("QPSOBL").ColumnName = "PESO  BULTO"
        oDtAlternativo.Columns("QVLBTO").ColumnName = "VOL. BULTO"
        oDtAlternativo.Columns("TTINTC").ColumnName = "ORIGEN"
        oDtAlternativo.Columns("TPRVCL").ColumnName = "PROVEEDOR"
        oDtAlternativo.Columns("QAROCP").ColumnName = "AREA BULTO"
        oDtAlternativo.Columns("TNOMCOM").ColumnName = "COMPRADOR "
        oDtAlternativo.Columns("NORCML").ColumnName = "ORDEN COMPRA"
        oDtAlternativo.Columns("NRITOC").ColumnName = "ITEM"
        oDtAlternativo.Columns("TCITCL").ColumnName = "COD. ITEM"
        oDtAlternativo.Columns("TDITES").ColumnName = "DESCRIPCION DEL ITEM"
        oDtAlternativo.Columns("IVUNIT").ColumnName = "PRECIO UNITARIO "
        oDtAlternativo.Columns("QSLCNB").ColumnName = "SALDO  CANTIDAD"
        oDtAlternativo.Columns("TUNDIT").ColumnName = "UNIDAD"
        oDtAlternativo.Columns("QPEPQT").ColumnName = "PESO ITEM  "
        oDtAlternativo.Columns("QVOPQT").ColumnName = "VOL ITEM"
        oDtAlternativo.Columns("NGRPRV").ColumnName = "Nro GUIA"
        oDtAlternativo.Columns("TLUGEN").ColumnName = "LUGAR"
        oDtAlternativo.Columns("SSNCRG").ColumnName = "SENTIDO DE ENTREGA"
        oDtAlternativo.Columns("DIAS").ColumnName = "DIAS EN ALMACEN"
        oDtAlternativo.Columns("MARRET").ColumnName = "CUSTODIA RETENCION"
        oDtAlternativo.Columns("NORAGN").ColumnName = "Nº ORDEN DE SERVICIO"
        oDtAlternativo.Columns("NFACPR").ColumnName = "FACTURA COMERCIAL"
        oDtAlternativo.Columns("FFACPR").ColumnName = "FECHA FACTURA COMERCIAL"

        oDtAlternativo.TableName = "Inventario Almacen"
        oDs.Tables.Add(oDtAlternativo)

        '*********
        Dim oDtv3 As DataView = New DataView(oDtRe)
        Dim oDtv2 As DataView = New DataView(oDtRe)
        Dim oDtResumen As New DataTable
        Dim oDt1 As New DataTable
        Dim oDt4 As New DataTable
        Dim oDt3 As New DataTable
        Dim oDtFiltro2 As New DataTable
        Dim oDr As DataRow

        oDt1 = oDtv3.ToTable(True, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA", "CREFFW", "QREFFW", "QPSOBL", "QVLBTO")
        oDt4 = oDtv2.ToTable(True, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA")
        Dim oDtv4 As DataView = New DataView(oDt4)
        oDtv4.Sort = "CCLNT, TIPO_ALMACEN ASC"
        oDt3 = oDtv4.ToTable(False, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA")
        oDtResumen.Columns.Add("TCMPCL1")
        oDtResumen.Columns.Add("TIPO_ALMACEN1")
        oDtResumen.Columns.Add("ALMACEN1")
        oDtResumen.Columns.Add("ZONA")
        oDtResumen.Columns.Add("QREFFW")
        oDtResumen.Columns.Add("QPSOBL")
        oDtResumen.Columns.Add("QVLBTO")

        For i As Integer = 0 To oDt3.Rows.Count - 1
            oDtFiltro2 = SelectDataTable(oDt1, "CCLNT = '" + oDt3.Rows(i).Item("CCLNT").ToString.Trim + "' AND TIPO_ALMACEN = '" + oDt3.Rows(i).Item("TIPO_ALMACEN") + "' AND ALMACEN = '" + oDt3.Rows(i).Item("ALMACEN") + "' AND ZONA = '" + oDt3.Rows(i).Item("ZONA") + "' ")
            oDr = oDtResumen.NewRow()
            oDr("TCMPCL1") = oDt3.Rows(i).Item("TCMPCL")
            oDr("TIPO_ALMACEN1") = oDt3.Rows(i).Item("TIPO_ALMACEN")
            oDr("ALMACEN1") = oDt3.Rows(i).Item("ALMACEN")
            oDr("ZONA") = oDt3.Rows(i).Item("ZONA")
            oDr("QREFFW") = SumarDataTable(oDtFiltro2, "QREFFW")
            oDr("QPSOBL") = SumarDataTable(oDtFiltro2, "QPSOBL")
            oDr("QVLBTO") = SumarDataTable(oDtFiltro2, "QVLBTO")
            oDtResumen.Rows.Add(oDr)
        Next

        oDtResumen.Columns("TCMPCL1").ColumnName = "RAZON SOCIAL"
        oDtResumen.Columns("TIPO_ALMACEN1").ColumnName = "TIPO ALMACEN"
        oDtResumen.Columns("ALMACEN1").ColumnName = "ALMACEN"
        oDtResumen.Columns("ZONA").ColumnName = "ZONA"
        oDtResumen.Columns("QREFFW").ColumnName = "INVENTARIO \n CANTIDAD"
        oDtResumen.Columns("QPSOBL").ColumnName = "INVENTARIO \n PESO"
        oDtResumen.Columns("QVLBTO").ColumnName = "INVENTARIO \n VOLUMEN"

        oDtResumen.TableName = "Resumen"
        oDs.Tables.Add(oDtResumen)
        '*********

        If Me.txtSentidoCarga.Tag Is Nothing OrElse Me.txtSentidoCarga.Tag = "" Then
            strSentidoCarga = "TODOS"
        Else
            strSentidoCarga = Me.txtSentidoCarga.Text
        End If
        Dim strlTitulo As New List(Of String)
        'strlTitulo.Add("Cliente :\n" & Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial)
        strlTitulo.Add("Planta :\n" & Me.UcPLanta_Cmb011.DescripcionPlanta)
        If (Me.txtUbicacionReferencial.Tag Is Nothing OrElse Me.txtUbicacionReferencial.Tag = "") AndAlso Me.txtUbicacionReferencial.Text = "" Then
            strlTitulo.Add("Ubicación :\nTODOS")
        Else
            strlTitulo.Add("Ubicación :\n" & Me.txtUbicacionReferencial.Text)
        End If
        If Me.txtTipoMovimiento.Tag Is Nothing OrElse Me.txtTipoMovimiento.Tag = "" Then
            strlTitulo.Add("Tipo de Mov.:\nTODOS")
        Else
            strlTitulo.Add("Tipo de Mov.:\n" & Me.txtTipoMovimiento.Text)
        End If
        strlTitulo.Add("Sentido de Carga:\n" & strSentidoCarga)
        strlTitulo.Add("Fechas  de Inventario:\n" & Me.dteFechaInventario.Value.Date)

        HelpClass.ExportExcelConTitulosAlmacen(oDs, Me.Text, strlTitulo)
    End Sub

    Private Sub FormatoCabeceraExportarExcel_1(ByVal cpoDataTable As DataTable, Optional ByVal blSubItem As Boolean = False)
        cpoDataTable.Columns.Add("CCLNT", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("TCMPCL", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("TUBRFR", System.Type.GetType("System.String"))
        'Agregado 04-04-2013 
        '-----------------------------------------------------------------------
        cpoDataTable.Columns.Add("TIPO_ALMACEN", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("ALMACEN", System.Type.GetType("System.String"))
        '-----------------------------------------------------------------------
        cpoDataTable.Columns.Add("ZONA", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("CREFFW", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("FINGAL", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("HORIDE", System.Type.GetType("System.String"))

        cpoDataTable.Columns.Add("QREFFW", System.Type.GetType("System.Decimal"))
        cpoDataTable.Columns.Add("TIPBTO", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("QPSOBL", System.Type.GetType("System.Decimal"))
        cpoDataTable.Columns.Add("QVLBTO", System.Type.GetType("System.Decimal"))
        cpoDataTable.Columns.Add("QAROCP", System.Type.GetType("System.Decimal"))
        cpoDataTable.Columns.Add("TPRVCL", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("NGRPRV", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("NORAGN", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("NFACPR", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("FFACPR", System.Type.GetType("System.String"))

        cpoDataTable.Columns.Add("TNOMCOM", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("REFERENCIA", System.Type.GetType("System.String"))
        ''AGREGADO 11-02-2014
        cpoDataTable.Columns.Add("TPOOCM", System.Type.GetType("System.String"))

        cpoDataTable.Columns.Add("NORCML", System.Type.GetType("System.String"))

        cpoDataTable.Columns.Add("TTINTC", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("PARCIAL", System.Type.GetType("System.String"))


        cpoDataTable.Columns.Add("TIPLIN", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("TRFRN", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("TCMAEM", System.Type.GetType("System.String"))


        cpoDataTable.Columns.Add("NRITOC", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("TCITCL", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("TDITES", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("IVUNIT", System.Type.GetType("System.Decimal"))
        cpoDataTable.Columns.Add("QSLCNB", System.Type.GetType("System.Decimal"))
        cpoDataTable.Columns.Add("TUNDIT", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("IMPORTE", System.Type.GetType("System.Decimal"))
        cpoDataTable.Columns.Add("QPEPQT", System.Type.GetType("System.Decimal"))
        cpoDataTable.Columns.Add("QVOPQT", System.Type.GetType("System.Decimal"))

        cpoDataTable.Columns.Add("TLUGEN", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("SSNCRG", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("DIAS", System.Type.GetType("System.Int32"))
        cpoDataTable.Columns.Add("MARRET", System.Type.GetType("System.String"))

        If blSubItem Then
            cpoDataTable.Columns.Add("SBITOC", System.Type.GetType("System.String"))
            cpoDataTable.Columns.Add("TCITCL1", System.Type.GetType("System.String"))
            cpoDataTable.Columns.Add("TDITES1", System.Type.GetType("System.String"))
            cpoDataTable.Columns.Add("QCNRCP", System.Type.GetType("System.String"))
        End If

    End Sub

    Private Sub FormatoCabeceraExportarExcel_2(ByVal cpoDataTable As DataTable, Optional ByVal blSubItem As Boolean = False)
        'Agregado 04-04-2013
        '-----------------------------------------------------------------------
        cpoDataTable.Columns.Add("CLIENTE", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("RAZON SOCIAL", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("UBICACIÓN", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("TIPO_ALMACEN", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("ALMACEN", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("ZONA", System.Type.GetType("System.String"))
        '-----------------------------------------------------------------------
        '-----------------------------------------------------------------------
        cpoDataTable.Columns.Add("FINGAL", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("HORIDE", System.Type.GetType("System.String"))

        cpoDataTable.Columns.Add("CREFFW", System.Type.GetType("System.String"))

        cpoDataTable.Columns.Add("QREFFW", System.Type.GetType("System.Decimal"))
        cpoDataTable.Columns.Add("TIPBTO", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("QPSOBL", System.Type.GetType("System.Decimal"))
        cpoDataTable.Columns.Add("QVLBTO", System.Type.GetType("System.Decimal"))
        cpoDataTable.Columns.Add("QAROCP", System.Type.GetType("System.Decimal"))

        cpoDataTable.Columns.Add("TPRVCL", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("NGRPRV", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("NORAGN", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("NFACPR", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("FFACPR", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("REFERENCIA", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("NORCML", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("TTINTC", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("NRITOC", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("TDITES", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("IVUNIT", System.Type.GetType("System.Decimal"))
        cpoDataTable.Columns.Add("QSLCNB", System.Type.GetType("System.Decimal"))
        cpoDataTable.Columns.Add("TUNDIT", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("IMPORTE", System.Type.GetType("System.Decimal"))
        cpoDataTable.Columns.Add("DIAS", System.Type.GetType("System.Int32"))

        If blSubItem Then
            cpoDataTable.Columns.Add("SBITOC", System.Type.GetType("System.String"))
            cpoDataTable.Columns.Add("TCITCL1", System.Type.GetType("System.String"))
            cpoDataTable.Columns.Add("TDITES1", System.Type.GetType("System.String"))
            cpoDataTable.Columns.Add("QCNRCP", System.Type.GetType("System.String"))
        End If

    End Sub

    Private Sub FormatoCabeceraExportarExcel_4(ByVal cpoDataTable As DataTable, Optional ByVal blSubItem As Boolean = False)

        cpoDataTable.Columns.Add("TUBRFR", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("CREFFW", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("ZONA", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("FINGAL", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("HORIDE", System.Type.GetType("System.String"))
        '
        cpoDataTable.Columns.Add("QREFFW", System.Type.GetType("System.Decimal"))
        cpoDataTable.Columns.Add("TIPBTO", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("QPSOBL", System.Type.GetType("System.Decimal"))
        cpoDataTable.Columns.Add("QVLBTO", System.Type.GetType("System.Decimal"))
        cpoDataTable.Columns.Add("QAROCP", System.Type.GetType("System.Decimal"))
        cpoDataTable.Columns.Add("TPRVCL", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("NGRPRV", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("NORAGN", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("NFACPR", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("FFACPR", System.Type.GetType("System.String"))

        cpoDataTable.Columns.Add("TNOMCOM", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("NORCML", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("TTINTC", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("PARCIAL", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("NRITOC", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("TCITCL", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("TDITES", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("IVUNIT", System.Type.GetType("System.Decimal"))
        cpoDataTable.Columns.Add("QSLCNB", System.Type.GetType("System.Decimal"))
        cpoDataTable.Columns.Add("TUNDIT", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("IMPORTE", System.Type.GetType("System.Decimal"))
        cpoDataTable.Columns.Add("QPEPQT", System.Type.GetType("System.Decimal"))
        cpoDataTable.Columns.Add("QVOPQT", System.Type.GetType("System.Decimal"))

        cpoDataTable.Columns.Add("TLUGEN", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("SSNCRG", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("DIAS", System.Type.GetType("System.Int32"))
        cpoDataTable.Columns.Add("MARRET", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("TNMMDT_ENVIO", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("TMRCTR", System.Type.GetType("System.String"))

        If blSubItem Then
            cpoDataTable.Columns.Add("SBITOC", System.Type.GetType("System.String"))
            cpoDataTable.Columns.Add("TCITCL1", System.Type.GetType("System.String"))
            cpoDataTable.Columns.Add("TDITES1", System.Type.GetType("System.String"))
            cpoDataTable.Columns.Add("QCNRCP", System.Type.GetType("System.String"))
        End If

    End Sub

    Private Function GeneraDtAlternativo_1(ByVal oDt As DataTable, Optional ByVal blSubItem As Boolean = False) As DataTable
        Dim oDtAlt As New DataTable
        Dim drAlt As DataRow
        Dim strBulto As String = String.Empty

        FormatoCabeceraExportarExcel_1(oDtAlt, blSubItem)


        For Each dr As DataRow In oDt.Rows

            drAlt = oDtAlt.NewRow

            If dr("CREFFW").ToString().Trim <> strBulto Then
                drAlt("CCLNT") = dr("CCLNT")
                drAlt("TCMPCL") = dr("TCMPCL")
                drAlt("TUBRFR") = dr("TUBRFR")
                drAlt("CREFFW") = dr("CREFFW")
                'Agregado 04-04-2013 
                '-----------------------------------------
                drAlt("TIPO_ALMACEN") = dr("TIPO_ALMACEN")
                drAlt("ALMACEN") = dr("ALMACEN")
                '-----------------------------------------
                drAlt("ZONA") = dr("ZONA")
                drAlt("FINGAL") = dr("FINGAL")
                drAlt("HORIDE") = dr("HORIDE")

                drAlt("QREFFW") = dr("QREFFW")
                drAlt("TIPBTO") = dr("TIPBTO")
                drAlt("QPSOBL") = dr("QPSOBL")
                drAlt("QVLBTO") = dr("QVLBTO")
                drAlt("TTINTC") = dr("TTINTC")
                drAlt("TPRVCL") = dr("TPRVCL")
                drAlt("QAROCP") = dr("QAROCP")
               
                drAlt("TNOMCOM") = dr("TNOMCOM")
                ''AGREGADO 11-02-2014
                If oDt.Columns("TPOOCM") IsNot Nothing Then
                    drAlt("TPOOCM") = dr("TPOOCM")
                Else
                    drAlt("TPOOCM") = ""
                End If
                '----
                drAlt("NORCML") = dr("NORCML")


                drAlt("PARCIAL") = dr("PARCIAL")
                drAlt("REFERENCIA") = dr("REFERENCIA")
            Else
                drAlt("CCLNT") = ""
                drAlt("TCMPCL") = ""
                drAlt("TUBRFR") = ""
                drAlt("CREFFW") = ""
                'agregado 04-04-2013
                '-----------------------------------------
                drAlt("TIPO_ALMACEN") = ""
                drAlt("ALMACEN") = ""
                '-----------------------------------------
                drAlt("ZONA") = ""
                drAlt("FINGAL") = ""
                drAlt("HORIDE") = ""
                drAlt("QREFFW") = DBNull.Value
                drAlt("TIPBTO") = ""
                drAlt("QPSOBL") = DBNull.Value
                drAlt("QVLBTO") = DBNull.Value
                drAlt("TTINTC") = ""
                drAlt("TPRVCL") = ""
                drAlt("QAROCP") = DBNull.Value
                drAlt("TNOMCOM") = ""
                ''AGREGADO 11-02-2014
                drAlt("TPOOCM") = ""
                '----
                drAlt("NORCML") = ""

                drAlt("PARCIAL") = ""
                drAlt("REFERENCIA") = ""

            End If



            ''AGREGADO 11-02-2014
            If oDt.Columns("TIPLIN") IsNot Nothing Then
                drAlt("TIPLIN") = dr("TIPLIN")
            Else
                drAlt("TIPLIN") = ""
            End If
            If oDt.Columns("TRFRN") IsNot Nothing Then
                drAlt("TRFRN") = dr("TRFRN")
            Else
                drAlt("TRFRN") = ""
            End If
            If oDt.Columns("TCMAEM") IsNot Nothing Then
                drAlt("TCMAEM") = dr("TCMAEM")
            Else
                drAlt("TCMAEM") = ""
            End If

            '----------------


            strBulto = dr("CREFFW").ToString().Trim

            drAlt("NRITOC") = dr("NRITOC")
            drAlt("TCITCL") = dr("TCITCL")
            drAlt("TDITES") = dr("TDITES")
            drAlt("IVUNIT") = dr("IVUNIT")
            drAlt("QSLCNB") = dr("QSLCNB")
            drAlt("TUNDIT") = dr("TUNDIT")
            drAlt("QPEPQT") = dr("QPEPQT")
            drAlt("QVOPQT") = dr("QVOPQT")
            drAlt("NGRPRV") = dr("NGRPRV")
            drAlt("TLUGEN") = dr("TLUGEN")
            drAlt("SSNCRG") = dr("SSNCRG")
            drAlt("DIAS") = dr("DIAS")
            drAlt("MARRET") = dr("MARRET")
            drAlt("IMPORTE") = dr("IMPORTE")
            drAlt("NORAGN") = dr("NORAGN")
            drAlt("NFACPR") = dr("NFACPR")
            drAlt("FFACPR") = dr("FFACPR")

            If blSubItem Then
                drAlt("SBITOC") = dr("SBITOC")
                drAlt("TCITCL1") = dr("TCITCL1")
                drAlt("TDITES1") = dr("TDITES1")
                drAlt("QCNRCP") = dr("QCNRCP")
            End If

            oDtAlt.Rows.Add(drAlt)
        Next
        Return oDtAlt

    End Function

    Private Function GeneraDtAlternativo_4(ByVal oDt As DataTable, Optional ByVal blSubItem As Boolean = False) As DataTable
        Dim oDtAlt As New DataTable
        Dim drAlt As DataRow
        Dim strBulto As String = String.Empty

        FormatoCabeceraExportarExcel_4(oDtAlt, blSubItem)


        For Each dr As DataRow In oDt.Rows

            drAlt = oDtAlt.NewRow

            If dr("CREFFW").ToString().Trim <> strBulto Then
                drAlt("TUBRFR") = dr("TUBRFR")
                drAlt("CREFFW") = dr("CREFFW")
                drAlt("ZONA") = dr("ZONA")
                drAlt("FINGAL") = dr("FINGAL")
                drAlt("HORIDE") = dr("HORIDE")

                drAlt("QREFFW") = dr("QREFFW")
                drAlt("TIPBTO") = dr("TIPBTO")
                drAlt("QPSOBL") = dr("QPSOBL")
                drAlt("QVLBTO") = dr("QVLBTO")
                drAlt("TTINTC") = dr("TTINTC")
                drAlt("TPRVCL") = dr("TPRVCL")
                drAlt("QAROCP") = dr("QAROCP")
                drAlt("TNOMCOM") = dr("TNOMCOM")
                drAlt("NORCML") = dr("NORCML")
                drAlt("PARCIAL") = dr("PARCIAL")
            Else
                drAlt("TUBRFR") = ""
                drAlt("CREFFW") = ""
                drAlt("ZONA") = ""
                drAlt("FINGAL") = ""
                drAlt("HORIDE") = ""
                drAlt("QREFFW") = DBNull.Value
                drAlt("TIPBTO") = ""
                drAlt("QPSOBL") = DBNull.Value
                drAlt("QVLBTO") = DBNull.Value
                drAlt("TTINTC") = ""
                drAlt("TPRVCL") = ""
                drAlt("QAROCP") = DBNull.Value
                drAlt("TNOMCOM") = ""
                drAlt("NORCML") = ""
                drAlt("PARCIAL") = ""

            End If

            strBulto = dr("CREFFW").ToString().Trim

            drAlt("NRITOC") = dr("NRITOC")
            drAlt("TCITCL") = dr("TCITCL")
            drAlt("TDITES") = dr("TDITES")
            drAlt("IVUNIT") = dr("IVUNIT")
            drAlt("QSLCNB") = dr("QSLCNB")
            drAlt("TUNDIT") = dr("TUNDIT")
            drAlt("QPEPQT") = dr("QPEPQT")
            drAlt("QVOPQT") = dr("QVOPQT")
            drAlt("NGRPRV") = dr("NGRPRV")
            drAlt("TLUGEN") = dr("TLUGEN")
            drAlt("SSNCRG") = dr("SSNCRG")
            drAlt("DIAS") = dr("DIAS")
            drAlt("MARRET") = dr("MARRET")
            drAlt("IMPORTE") = dr("IMPORTE")
            drAlt("NORAGN") = dr("NORAGN")
            drAlt("NFACPR") = dr("NFACPR")
            drAlt("FFACPR") = dr("FFACPR")

            If blSubItem Then
                drAlt("SBITOC") = dr("SBITOC")
                drAlt("TCITCL1") = dr("TCITCL1")
                drAlt("TDITES1") = dr("TDITES1")
                drAlt("QCNRCP") = dr("QCNRCP")
            End If

            oDtAlt.Rows.Add(drAlt)
        Next

        Return oDtAlt

    End Function

    Private Function GeneraDtAlternativo_2(ByVal oDt As DataTable, Optional ByVal blSubItem As Boolean = False) As DataTable
        Dim oDtAlt As New DataTable
        Dim drAlt As DataRow
        Dim strBulto As String = String.Empty

        FormatoCabeceraExportarExcel_2(oDtAlt, blSubItem)
        Try
            For Each dr As DataRow In oDt.Rows
                drAlt = oDtAlt.NewRow
                If dr("CREFFW").ToString().Trim <> strBulto Then

                    'Agregado 04-04-2013
                    '--------------------------------
                    drAlt("CLIENTE") = dr("CCLNT")
                    drAlt("RAZON SOCIAL") = dr("TCMPCL")
                    drAlt("UBICACIÓN") = dr("TUBRFR")
                    drAlt("TIPO_ALMACEN") = dr("TIPO_ALMACEN")
                    drAlt("ALMACEN") = dr("ALMACEN")
                    drAlt("ZONA") = dr("ZONA")
                    '--------------------------------
                    drAlt("CREFFW") = dr("CREFFW")
                    drAlt("FINGAL") = dr("FINGAL")
                    drAlt("HORIDE") = dr("HORIDE")

                    drAlt("QREFFW") = dr("QREFFW")
                    drAlt("TIPBTO") = dr("TIPBTO")
                    drAlt("QPSOBL") = dr("QPSOBL")
                    drAlt("QVLBTO") = dr("QVLBTO")
                    drAlt("TTINTC") = dr("TTINTC")
                    drAlt("TPRVCL") = dr("TPRVCL")
                    drAlt("QAROCP") = dr("QAROCP")
                    drAlt("NORCML") = dr("NORCML")
                    drAlt("NORAGN") = dr("NORAGN")
                    drAlt("NFACPR") = dr("NFACPR")
                    drAlt("FFACPR") = dr("FFACPR")
                    drAlt("NGRPRV") = dr("NGRPRV")
                    drAlt("REFERENCIA") = dr("REFERENCIA")

                Else
                    'Agregado 04-04-2013
                    '--------------------------------
                    drAlt("CLIENTE") = ""
                    drAlt("RAZON SOCIAL") = ""
                    drAlt("UBICACIÓN") = ""
                    drAlt("TIPO_ALMACEN") = ""
                    drAlt("ALMACEN") = ""
                    drAlt("ZONA") = ""
                    '--------------------------------

                    drAlt("CREFFW") = dr("CREFFW")
                    drAlt("FINGAL") = dr("FINGAL")
                    drAlt("HORIDE") = dr("HORIDE")


                    drAlt("QREFFW") = DBNull.Value
                    drAlt("TIPBTO") = ""
                    drAlt("QPSOBL") = DBNull.Value
                    drAlt("QVLBTO") = DBNull.Value
                    drAlt("QAROCP") = DBNull.Value

                    drAlt("TTINTC") = dr("TTINTC")
                    drAlt("TPRVCL") = dr("TPRVCL")

                    drAlt("NORCML") = dr("NORCML")
                    drAlt("NORAGN") = dr("NORAGN")
                    drAlt("NFACPR") = dr("NFACPR")
                    drAlt("FFACPR") = dr("FFACPR")
                    drAlt("NGRPRV") = dr("NGRPRV")
                    drAlt("REFERENCIA") = DBNull.Value

                End If

                strBulto = dr("CREFFW").ToString().Trim

                drAlt("NRITOC") = dr("NRITOC")
                drAlt("TDITES") = dr("TDITES")
                drAlt("IVUNIT") = dr("IVUNIT")
                drAlt("QSLCNB") = dr("QSLCNB")
                drAlt("TUNDIT") = dr("TUNDIT")
                drAlt("DIAS") = dr("DIAS")
                drAlt("IMPORTE") = dr("IMPORTE")

                If blSubItem Then
                    drAlt("SBITOC") = dr("SBITOC")
                    drAlt("TCITCL1") = dr("TCITCL1")
                    drAlt("TDITES1") = dr("TDITES1")
                    drAlt("QCNRCP") = dr("QCNRCP")
                End If

                oDtAlt.Rows.Add(drAlt)
            Next
        Catch ex As Exception

        End Try


        Return oDtAlt
    End Function

    Private Sub CargarCliente()
        'Dim obrcliente As New Ransa.DAO.Cliente.cCliente
        'Dim obeCliente As New Ransa.TypeDef.Cliente.TD_Qry_Cliente_L01
        Dim obrcliente As New Ransa.Controls.Cliente.cCliente
        Dim obeCliente As New Ransa.Controls.Cliente.TD_Qry_Cliente_L01
        Dim oDtCliente As New DataTable

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        With obeCliente
            '.pCCLNT_Cliente = 0
            .pNROPAG_NroPagina = 1
            .pREGPAG_NroRegPorPagina = 1000
            .pUsuario = objSeguridadBN.pUsuario
            .pCCMPN_CodigoCompania = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
        End With
        oDtCliente = obrcliente.Listar(obeCliente, "S", 1000, 0)

        Lista = New List(Of beCliente)

        For Each dr As DataRow In oDtCliente.Rows
            objCliente = New beCliente
            objCliente.Codigo = dr("CCLNT")
            If dr("TMTVBJ").ToString.Trim = "" Then
                objCliente.Descripcion = String.Format("{0}", dr("TCMPCL").ToString.Trim)
            Else
                objCliente.Descripcion = String.Format("{0}-{1}", dr("TCMPCL").ToString.Trim, dr("TMTVBJ").ToString.Trim)
            End If

            objCliente.RUC = dr("NRUC")
            objCliente.Estado = 0
            Lista.Add(objCliente)
        Next

        Dim oListColum As New Hashtable

        Dim oColumnas1 As New DataGridViewCheckBoxColumn
        oColumnas1.Name = "CHK"
        oColumnas1.DataPropertyName = "CHK"
        oColumnas1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oColumnas1.HeaderText = "Check"
        oColumnas1.ReadOnly = False
        oColumnas1.Visible = True
        oListColum.Add(1, oColumnas1)

        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "Codigo"
        oColumnas.DataPropertyName = "Codigo"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oColumnas.HeaderText = "Código"
        oColumnas.ReadOnly = True
        oColumnas.Visible = True
        oListColum.Add(2, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "Descripcion"
        oColumnas.DataPropertyName = "Descripcion"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oColumnas.HeaderText = "Descripción"
        oColumnas.ReadOnly = True
        oColumnas.Visible = True
        oListColum.Add(3, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "RUC"
        oColumnas.DataPropertyName = "RUC"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oColumnas.HeaderText = "RUC"
        oColumnas.ReadOnly = True
        oColumnas.Visible = True
        oListColum.Add(4, oColumnas)

        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "Estado"
        oColumnas.DataPropertyName = "Estado"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        oColumnas.HeaderText = "Estado"
        oColumnas.Visible = False
        oColumnas.ReadOnly = True
        oListColum.Add(5, oColumnas)

        Me.txtCliente2.DataSource = Lista
        Me.txtCliente2.ListColumnas = oListColum
        Me.txtCliente2.Cargas()
        Me.txtCliente2.DispleyMember = "Descripcion"
        Me.txtCliente2.ValueMember = "Codigo"
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub HabilitarBotones(ByVal Habilitar As Boolean)
        btnGenerarReporte.Enabled = Habilitar
        tsbExportarExcel_1.Enabled = Habilitar
        tsbImprimir.Enabled = Habilitar
    End Sub

    Private Sub pListarReporteGrilla()
        If txtCliente2.Resultado IsNot Nothing Then
            If Me.rbtOrdenDeCompra.Checked Then                 'Primer RadioButton
                Call pReporteInventarioAlmacenOc()
            ElseIf rbtItem.Checked Then
                Call pReporteInventarioAlmacenItem()            'Segundo RadioButton
            Else
                Call pReporteInventarioAlmacenSubItem()         'Tercer Radiobutton
            End If
        End If

    End Sub

    Private Sub VisualizarGrilla(ByVal Vista As String)
        If Vista = "OC" Then
            dgInventarioUbicacionOC.Visible = True
            dgInventarioUbicacionItem.Visible = False
            dgInventarioUbicacionSubItem.Visible = False
        ElseIf Vista = "IT" Then
            dgInventarioUbicacionOC.Visible = False
            dgInventarioUbicacionItem.Visible = True
            dgInventarioUbicacionSubItem.Visible = False
        ElseIf Vista = "SU" Then
            dgInventarioUbicacionOC.Visible = False
            dgInventarioUbicacionItem.Visible = False
            dgInventarioUbicacionSubItem.Visible = True
        End If
    End Sub

#End Region

#Region "Eventos de Control"

    Private Sub frmRptInventarioXUbicacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
            UcCompania_Cmb011.pActualizar()
            UcCompania_Cmb011.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
            '-- Crear status por control con F4
            'ConfigurationAppSettings As New System.Configuration.AppSettingsReader
            Dim objAppConfig As cAppConfig = New cAppConfig
            ' Recuperamos los ultimos valores seleccionados
            Dim intTemp As Int64 = 0
            Int64.TryParse(objAppConfig.GetValue("RepRecepcionPorAlmacenClienteCodigo", GetType(System.String)), intTemp)

            Dim ClientePK As TD_ClientePK = New TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
            'txtCliente.pCargar(ClientePK)
            CargarCliente()
            CargarUbicacion()
            'tsbAmpliar.Image = pbxAmpliar.Image
            'dteFechaInicial.Value = Now
            'dteFechaInicial.Checked = False
            'dteFechaFinal.Value = Now
            'dteFechaFinal.Checked = False

            'If rbtItem.Checked = True Then
            '    klblCondicion.Visible = True
            '    klblTipoMaterial.Visible = True
            '    ucCondicion_Cmb01.Visible = True
            '    ucTipoMaterial_Cmb01.Visible = True
            '    Modelo05MatpelToolStripMenuItem.Visible = True
            '    Modelo05MatpelDimenToolStripMenuItem.Visible = True
            'End If
            habilitarOpcionesReporte("ITEM")


            objAppConfig = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    Private Sub btnGenerarReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarReporte.Click
        Try
            If fblnValidaInformacion() Then
                'pcxEspera.Visible = True
                'pcxEspera.Left = (KryptonHeaderGroup2.Width / 2) - (pcxEspera.Width / 2)
                'pcxEspera.Top = (KryptonHeaderGroup2.Height / 2) - (pcxEspera.Height / 2)
                tsbEnviarCorreo.Enabled = False
                Me.tsbExportarExcel_1.Enabled = False
                btnGenerarReporte.Enabled = False
                pListarReporteGrilla()
                HabilitarBotones(True)
                'crvReporte.Visible = False
                'a = dteFechaInicial.Checked
                'b = dteFechaFinal.Checked
                'c = dteFechaCompInicial.Checked
                'd = dteFechaCompFinal.Checked

                'bgwGifAnimado.RunWorkerAsync()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    'Private Sub bgwGifAnimado_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)
    '    Call pGenerarReporte()
    'End Sub

    'Private Sub bgwGifAnimado_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs)
    'pcxEspera.Visible = False
    'btnGenerarReporte.Enabled = True
    'tsbEnviarCorreo.Enabled = True
    'tsbExportarExcel_1.Enabled = True
    'crvReporte.Visible = True
    'crvReporte.ReportSource = objTemp.pReporte
    'End Sub

    Private Sub bsaSentidoCargaListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaSentidoCargaListar.Click
        Try
            Call mfblnBuscar_SentidoCarga(txtSentidoCarga.Tag, txtSentidoCarga.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtSentidoCarga_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSentidoCarga.KeyDown
        Try
            If e.KeyCode = Keys.F4 Then
                Call mfblnBuscar_SentidoCarga(txtSentidoCarga.Tag, txtSentidoCarga.Text)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub txtSentidoCarga_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSentidoCarga.TextChanged
        txtSentidoCarga.Tag = ""
    End Sub

    Private Sub txtSentidoCarga_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSentidoCarga.Validating
        Try
            If txtSentidoCarga.Text = "" Then
                txtSentidoCarga.Tag = ""
            Else
                If txtSentidoCarga.Text <> "" And "" & txtSentidoCarga.Tag = "" Then
                    Call mfblnBuscar_SentidoCarga(txtSentidoCarga.Tag, txtSentidoCarga.Text)
                    If txtSentidoCarga.Text = "" Then
                        e.Cancel = True
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

       
    End Sub

    Private Sub bsaTipoMovimientoListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaTipoMovimientoListar.Click
        Try
            Call mfdtBuscar_TipoMovimiento(txtTipoMovimiento.Tag, txtTipoMovimiento.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub txtTipoMovimiento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoMovimiento.KeyDown
        Try
            If e.KeyCode = Keys.F4 Then
                Call mfdtBuscar_TipoMovimiento(txtTipoMovimiento.Tag, txtTipoMovimiento.Text)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Sub txtTipoMovimiento_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTipoMovimiento.TextChanged
        txtTipoMovimiento.Tag = ""
    End Sub

    Private Sub txtTipoMovimiento_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTipoMovimiento.Validating
        If txtTipoMovimiento.Text = "" Then
            txtTipoMovimiento.Tag = ""
        Else
            If txtTipoMovimiento.Text <> "" And "" & txtTipoMovimiento.Tag = "" Then
                Call mfdtBuscar_TipoMovimiento(txtTipoMovimiento.Tag, txtTipoMovimiento.Text)
                If txtTipoMovimiento.Text = "" Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub tsbEnviarCorreo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEnviarCorreo.Click
        Call mpEnviarEMail(objTemp, strDetalleReporte, "Informe : " + strDetalleReporte)
    End Sub

    Private Sub tsbExportarResumenInventario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarResumenInventario.Click
        Dim ofrmResumenInventario As New frmResumenInventario
        With ofrmResumenInventario
            .PSCCMPN = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCDVSN = Me.UcDivision_Cmb011.Division
            .PSCPLNDV = Me.UcPLanta_Cmb011.Planta
            '.PNCCLNT = Me.txtCliente.pCodigo
            .PNFECFIN = dteFechaInventario.Value
            .PSSSNCRG = ""
        End With
        ofrmResumenInventario.ShowDialog()
    End Sub

    Private Sub Modelo01ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modelo01ToolStripMenuItem.Click
        Try
            ExportarExcel(1)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Modelo02ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modelo02ToolStripMenuItem.Click
        Try
            ExportarExcel(2)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Modelo03ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modelo03ToolStripMenuItem.Click
        Try
            ExportarExcel(3)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Modelo04ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modelo04ToolStripMenuItem.Click
        Try
            ExportarExcel(4)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'CSR-HUNDRED-INICIO
    Private Sub Modelo04BultoXPedidoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modelo04BultoXPedidoToolStripMenuItem.Click
        Try
            ExportarExcel(5)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    'CSR-HUNDRED-FIN

#End Region

    Private Sub rbtOrdenDeCompra_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtOrdenDeCompra.CheckedChanged
        Try

            'OcultarModelo04(True)
            'Modelo04BultoXPedidoToolStripMenuItem.Visible = False 'CSR-HUNDRED
            'If rbtOrdenDeCompra.Checked = True Then
            '    VisualizarGrilla("OC")
            '    pListarReporteGrilla()
            '    HabilitarBotones(True)
            '    klblCondicion.Visible = False
            '    klblTipoMaterial.Visible = False
            '    ucCondicion_Cmb01.Visible = False
            '    ucTipoMaterial_Cmb01.Visible = False
            '    Modelo05MatpelToolStripMenuItem.Visible = False
            '    Modelo05MatpelDimenToolStripMenuItem.Visible = False
            'End If
            habilitarOpcionesReporte("OC")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    Private Sub rbtItem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtItem.CheckedChanged
        Try
            'OcultarModelo04(False)
            'Modelo04BultoXPedidoToolStripMenuItem.Visible = True 'CSR-HUNDRED
            'If rbtItem.Checked = True Then
            '    VisualizarGrilla("IT")
            '    pListarReporteGrilla()
            '    HabilitarBotones(True)
            '    klblCondicion.Visible = True
            '    klblTipoMaterial.Visible = True
            '    ucCondicion_Cmb01.Visible = True
            '    ucTipoMaterial_Cmb01.Visible = True
            '    Modelo05MatpelToolStripMenuItem.Visible = True
            '    Modelo05MatpelDimenToolStripMenuItem.Visible = True
            'End If
            habilitarOpcionesReporte("ITEM")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    
    End Sub

    Private Sub KryptonRadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtSubItem.CheckedChanged
        Try
            'OcultarModelo04(False)
            'pListarReporteGrilla()
            'If rbtSubItem.Checked = True Then
            '    VisualizarGrilla("SU")
            '    pListarReporteGrilla()
            '    HabilitarBotones(True)
            '    klblCondicion.Visible = False
            '    klblTipoMaterial.Visible = False
            '    ucCondicion_Cmb01.Visible = False
            '    ucTipoMaterial_Cmb01.Visible = False
            '    Modelo05MatpelToolStripMenuItem.Visible = False
            '    Modelo05MatpelDimenToolStripMenuItem.Visible = False
            'End If
            habilitarOpcionesReporte("SUB_ITEM")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    
    End Sub

    Private Sub habilitarOpcionesReporte(tipoVista As String)
        Select Case tipoVista
            Case "OC"
                OcultarModelo04(True)
                Modelo04BultoXPedidoToolStripMenuItem.Visible = False 'CSR-HUNDRED


                VisualizarGrilla("OC")
                pListarReporteGrilla()
                HabilitarBotones(True)
                klblCondicion.Visible = False
                klblTipoMaterial.Visible = False
                ucCondicion_Cmb01.Visible = False
                ucTipoMaterial_Cmb01.Visible = False
                Modelo05MatpelToolStripMenuItem.Visible = False
                Modelo05MatpelDimenToolStripMenuItem.Visible = False

            Case "ITEM"

                OcultarModelo04(False)
                Modelo04BultoXPedidoToolStripMenuItem.Visible = True 'CSR-HUNDRED


                VisualizarGrilla("IT")
                pListarReporteGrilla()
                HabilitarBotones(True)
                klblCondicion.Visible = True
                klblTipoMaterial.Visible = True
                ucCondicion_Cmb01.Visible = True
                ucTipoMaterial_Cmb01.Visible = True
                Modelo05MatpelToolStripMenuItem.Visible = True
                Modelo05MatpelDimenToolStripMenuItem.Visible = True

            Case "SUB_ITEM"

                OcultarModelo04(False)
                pListarReporteGrilla()

                VisualizarGrilla("SU")
                pListarReporteGrilla()
                HabilitarBotones(True)
                klblCondicion.Visible = False
                klblTipoMaterial.Visible = False
                ucCondicion_Cmb01.Visible = False
                ucTipoMaterial_Cmb01.Visible = False
                Modelo05MatpelToolStripMenuItem.Visible = False
                Modelo05MatpelDimenToolStripMenuItem.Visible = False

        End Select
    End Sub

    Private Sub Modelo05GPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modelo05GPToolStripMenuItem.Click
        'If Me.txtCliente.pCodigo = 0 Then Exit Sub
        Try
            If txtCliente2.Resultado IsNot Nothing Then
                Dim Estado As String = txtCliente2.Resultado.GetType().ToString
                If Estado = "Ransa.Utilitario.beCliente" Then
                    Dim ListaS As String
                    ListaS = CType(txtCliente2.Resultado, beCliente).Codigo
                    If ListaS Is Nothing Then
                        Exit Sub
                    End If
                Else
                    Dim ListaS As New List(Of String)
                    ListaS = CType(txtCliente2.Resultado, List(Of String))

                    If ListaS Is Nothing Then
                        Exit Sub
                    Else
                        If ListaS.Count = 0 Then
                            Exit Sub
                        End If
                    End If

                End If
            Else
                Exit Sub

            End If

            Dim obrBulto As New brBulto
            Dim obeBulto As New Ransa.TypeDef.beBulto
            With obeBulto
                .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
                .PSCDVSN = UcDivision_Cmb011.Division
                .PNCPLNDV = UcPLanta_Cmb011.Planta
                '.PSCCLNT = Me.txtCliente.pCodigo
                Dim Est As String = txtCliente2.Resultado.GetType.ToString
                If Est = "Ransa.Utilitario.beCliente" Then
                    .PSCODCLIE = CType(txtCliente2.Resultado, beCliente).Codigo
                Else
                    .PSCODCLIE = ListaCodigoClientes()
                End If
                .PNFECINI = 0
                .PNFECFIN = IIf(Me.dteFechaInventario.Checked, HelpClass.CDate_a_Numero8Digitos(dteFechaInventario.Value), 0)
                .PSTUBRFR = txtUbicacionReferencial.Text
                'Modificado por ABraham Zorrilla
                .PSSSNCRG = "" & Me.txtSentidoCarga.Tag & ""
            End With
            'Dim dstTemp As New DataSet
            Dim odt As New DataTable
            'dstTemp = HelpClass.GetDataSetNative(Me.dtgCentroCostoREcepcion.DataSource)
            odt = obrBulto.ListarBultoInventarioGP(obeBulto)
            If odt.Rows.Count = 0 Then Exit Sub
            'dstTemp.Tables.Add(odt.Copy)
            'Me.txtCliente.pCodigo.ToString & " - " & Me.txtCliente.pRazonSocial.ToString
            'Call mpGenerarXLS("INVENTARIO_BULTO", dstTemp.Tables(0), "", Nothing, strlTitulo)
            'ExportarExcelModelo5GYP(odt)
            ExportarExcelModelo5GYP_V2(odt)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    'Private Sub ExportarExcelModelo5GYP(ByVal dtTemp As DataTable)


    '    Dim oDtRe As New DataTable
    '    Dim oDtResumen As New DataTable
    '    Dim oDtFiltro2 As New DataTable
    '    oDtRe = dtTemp.Copy
    '    Dim oDtv3 As DataView = New DataView(oDtRe)
    '    Dim oDtv2 As DataView = New DataView(oDtRe)
    '    Dim oDt1 As New DataTable
    '    Dim oDt4 As New DataTable
    '    Dim oDt3 As New DataTable
    '    Dim oDr As DataRow
    '    Dim oDs As New DataSet

    '    oDt1 = oDtv3.ToTable(False, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA", "QREFFW", "QPSOBL", "QVLBTO")
    '    oDt4 = oDtv2.ToTable(True, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA")
    '    Dim oDtv4 As DataView = New DataView(oDt4)
    '    oDtv4.Sort = "CCLNT, TIPO_ALMACEN ASC"
    '    oDt3 = oDtv4.ToTable(False, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA")
    '    oDtResumen.Columns.Add("TCMPCL1")
    '    oDtResumen.Columns.Add("TIPO_ALMACEN1")
    '    oDtResumen.Columns.Add("ALMACEN1")
    '    oDtResumen.Columns.Add("ZONA")
    '    oDtResumen.Columns.Add("QREFFW")
    '    oDtResumen.Columns.Add("QPSOBL")
    '    oDtResumen.Columns.Add("QVLBTO")

    '    For i As Integer = 0 To oDt3.Rows.Count - 1
    '        oDtFiltro2 = SelectDataTable(oDt1, "CCLNT = '" + oDt3.Rows(i).Item("CCLNT").ToString.Trim + "' AND TIPO_ALMACEN = '" + oDt3.Rows(i).Item("TIPO_ALMACEN") + "' AND ALMACEN = '" + oDt3.Rows(i).Item("ALMACEN") + "' AND ZONA = '" + oDt3.Rows(i).Item("ZONA") + "' ")
    '        oDr = oDtResumen.NewRow()
    '        oDr("TCMPCL1") = oDt3.Rows(i).Item("TCMPCL")
    '        oDr("TIPO_ALMACEN1") = oDt3.Rows(i).Item("TIPO_ALMACEN")
    '        oDr("ALMACEN1") = oDt3.Rows(i).Item("ALMACEN")
    '        oDr("ZONA") = oDt3.Rows(i).Item("ZONA")
    '        oDr("QREFFW") = SumarDataTable(oDtFiltro2, "QREFFW")
    '        oDr("QPSOBL") = SumarDataTable(oDtFiltro2, "QPSOBL")
    '        oDr("QVLBTO") = SumarDataTable(oDtFiltro2, "QVLBTO")
    '        oDtResumen.Rows.Add(oDr)
    '    Next

    '    oDtResumen.Columns("TCMPCL1").ColumnName = "RAZON SOCIAL"
    '    oDtResumen.Columns("TIPO_ALMACEN1").ColumnName = "TIPO ALMACEN"
    '    oDtResumen.Columns("ALMACEN1").ColumnName = "ALMACEN"
    '    oDtResumen.Columns("ZONA").ColumnName = "ZONA"
    '    oDtResumen.Columns("QREFFW").ColumnName = "INVENTARIO \n CANTIDAD"
    '    oDtResumen.Columns("QPSOBL").ColumnName = "INVENTARIO \n PESO"
    '    oDtResumen.Columns("QVLBTO").ColumnName = "INVENTARIO \n VOLUMEN"
    '    oDtResumen.TableName = "Resumen"

    '    '************ 

    '    dtTemp.Columns("CCLNT").ColumnName = "CLIENTE"
    '    dtTemp.Columns("TCMPCL").ColumnName = "RAZON SOCIAL"
    '    dtTemp.Columns("CREFFW").ColumnName = "CÓDIGO BULTO"
    '    dtTemp.Columns("UBICACION").ColumnName = "UBICACIÓN"
    '    dtTemp.Columns("DESCWB").ColumnName = "DESCRIPCIÓN"
    '    dtTemp.Columns("FREFFW").ColumnName = "FECHA INGRESO"
    '    dtTemp.Columns("HORIDE").ColumnName = "HORA INGRESO"

    '    dtTemp.Columns("QREFFW").ColumnName = "CANTIDAD BULTO"
    '    dtTemp.Columns("QPSOBL").ColumnName = "PESO BULTO"
    '    dtTemp.Columns("QMTALT").ColumnName = "ALTURA"
    '    dtTemp.Columns("QMTANC").ColumnName = "ANCHO"
    '    dtTemp.Columns("QMTLRG").ColumnName = "LARGO"
    '    dtTemp.Columns("QVLBTO").ColumnName = "VOLUMEN BULTO"
    '    dtTemp.Columns("NORCML").ColumnName = "N° O/C"
    '    dtTemp.Columns("TPRVCL").ColumnName = "PROVEEDOR"
    '    dtTemp.Columns("NGRPRV").ColumnName = "N° GUÍA PROVEEDOR"
    '    dtTemp.Columns("TLUGEN").ColumnName = "LOTE"
    '    dtTemp.Columns("TNMMDT").ColumnName = "MEDIO SUGERIDO"
    '    dtTemp.Columns("CONFIR").ColumnName = "MEDIO CONFIRMADO"
    '    dtTemp.Columns("DIAS").ColumnName = "DIAS EN ALMACEN"

    '    dtTemp.Columns("TOBSEN").ColumnName = "OBSERVACIONES CONFIRMACION"

    '    dtTemp.Columns("NCTAMA").ColumnName = "NRO. CTA MAYOR"
    '    dtTemp.Columns("CCNCOS").ColumnName = "CENTRO DE COSTE"
    '    dtTemp.Columns("NELPEP").ColumnName = "NRO. ELEMENTO PEP"
    '    dtTemp.Columns("NORSAP").ColumnName = "NRO. ORDEN"
    '    dtTemp.Columns("NGFSAP").ColumnName = "NRO. GRAFO"
    '    dtTemp.Columns("SINCUENTA").ColumnName = "SIN CUENTA"
    '    dtTemp.Columns("TCTCST").ColumnName = "CUENTA IMP. TERRESTRE"
    '    dtTemp.Columns("TCTCSA").ColumnName = "CUENTA IMP. AEREO"
    '    dtTemp.Columns("TCTCSF").ColumnName = "CUENTA IMP.FLUVIAL"
    '    dtTemp.Columns("TCTCAL").ColumnName = "CUENTA IMP. ALMACENAJE"
    '    dtTemp.Columns("REFERENCIA").ColumnName = "REFERENCIA"


    '    Dim oDtFiltro As New DataTable
    '    'Dim objListdt As New List(Of DataTable)

    '    Dim oDt2 As DataTable
    '    Dim oDtv1 As DataView = New DataView(dtTemp)
    '    oDt2 = oDtv1.ToTable(True, "LOTE")

    '    For intRows As Integer = 0 To oDt2.Rows.Count - 1
    '        oDtFiltro = SelectDataTable(dtTemp, "[LOTE] = '" + oDt2.Rows(intRows).Item(0) + "'")
    '        oDtFiltro.TableName = NombreTabla(oDt2.Rows(intRows).Item(0).ToString.Trim) & "  "
    '        oDs.Tables.Add(oDtFiltro)
    '    Next

    '    oDs.Tables.Add(oDtResumen)

    '    'Filtros
    '    Dim strSentidoCarga As String = ""
    '    If Me.txtSentidoCarga.Tag Is Nothing OrElse Me.txtSentidoCarga.Tag = "" Then
    '        strSentidoCarga = "Todos"
    '    Else
    '        strSentidoCarga = Me.txtSentidoCarga.Text
    '    End If
    '    Dim strlFiltro As New List(Of String)
    '    strlFiltro.Add("Planta :\n" & Me.UcPLanta_Cmb011.DescripcionPlanta)
    '    strlFiltro.Add("Sentido de Carga:\n" & strSentidoCarga)
    '    strlFiltro.Add("Fecha :\n" & dteFechaInventario.Value.Date)

    '    'Suma
    '    Dim listSuma As New Hashtable
    '    listSuma.Add("Suma01", 12)
    '    listSuma.Add("Suma02", 13)
    '    listSuma.Add("Suma03", 17)

    '    HelpClass.ExportExcelConTitulosAlmacen(oDs, Me.Text, strlFiltro, listSuma)
    'End Sub


    Private Sub ExportarExcelModelo5GYP_V2(ByVal dtTemp As DataTable)
        Dim ListaDatatable As New List(Of DataTable)

        Dim NPOI_SC As New HelpClass_NPOI_SC
        Dim MdataColumna As String = ""


        Dim oDtRe As New DataTable
        Dim oDtResumen As New DataTable
        Dim oDtFiltro2 As New DataTable
        oDtRe = dtTemp.Copy
        Dim oDtv3 As DataView = New DataView(oDtRe)
        Dim oDtv2 As DataView = New DataView(oDtRe)
        Dim oDt1 As New DataTable
        Dim oDt4 As New DataTable
        Dim oDt3 As New DataTable
        Dim oDr As DataRow
        Dim oDs As New DataSet

        oDt1 = oDtv3.ToTable(False, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA", "QREFFW", "QPSOBL", "QVLBTO")
        oDt4 = oDtv2.ToTable(True, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA")
        Dim oDtv4 As DataView = New DataView(oDt4)
        oDtv4.Sort = "CCLNT, TIPO_ALMACEN ASC"
        oDt3 = oDtv4.ToTable(False, "CCLNT", "TCMPCL", "TIPO_ALMACEN", "ALMACEN", "ZONA")
        oDtResumen.Columns.Add("TCMPCL1")
        oDtResumen.Columns.Add("TIPO_ALMACEN1")
        oDtResumen.Columns.Add("ALMACEN1")
        oDtResumen.Columns.Add("ZONA")
        oDtResumen.Columns.Add("QREFFW")
        oDtResumen.Columns.Add("QPSOBL")
        oDtResumen.Columns.Add("QVLBTO")

        For i As Integer = 0 To oDt3.Rows.Count - 1
            oDtFiltro2 = SelectDataTable(oDt1, "CCLNT = '" + oDt3.Rows(i).Item("CCLNT").ToString.Trim + "' AND TIPO_ALMACEN = '" + oDt3.Rows(i).Item("TIPO_ALMACEN") + "' AND ALMACEN = '" + oDt3.Rows(i).Item("ALMACEN") + "' AND ZONA = '" + oDt3.Rows(i).Item("ZONA") + "' ")
            oDr = oDtResumen.NewRow()
            oDr("TCMPCL1") = oDt3.Rows(i).Item("TCMPCL")
            oDr("TIPO_ALMACEN1") = oDt3.Rows(i).Item("TIPO_ALMACEN")
            oDr("ALMACEN1") = oDt3.Rows(i).Item("ALMACEN")
            oDr("ZONA") = oDt3.Rows(i).Item("ZONA")
            oDr("QREFFW") = SumarDataTable(oDtFiltro2, "QREFFW")
            oDr("QPSOBL") = SumarDataTable(oDtFiltro2, "QPSOBL")
            oDr("QVLBTO") = SumarDataTable(oDtFiltro2, "QVLBTO")
            oDtResumen.Rows.Add(oDr)
        Next


        'oDtResumen.Columns("TCMPCL1").ColumnName = "RAZON SOCIAL"
        oDtResumen.Columns("TCMPCL1").Caption = NPOI_SC.FormatDato("RAZON SOCIAL", NPOI_SC.keyDatoTexto)

        'oDtResumen.Columns("TIPO_ALMACEN1").ColumnName = "TIPO ALMACEN"
        oDtResumen.Columns("TIPO_ALMACEN1").Caption = NPOI_SC.FormatDato("TIPO ALMACEN", NPOI_SC.keyDatoTexto)

        'oDtResumen.Columns("ALMACEN1").ColumnName = "ALMACEN"
        oDtResumen.Columns("ALMACEN1").Caption = NPOI_SC.FormatDato("ALMACEN", NPOI_SC.keyDatoTexto)

        'oDtResumen.Columns("ZONA").ColumnName = "ZONA"
        oDtResumen.Columns("ZONA").Caption = NPOI_SC.FormatDato("ZONA", NPOI_SC.keyDatoTexto)

        'oDtResumen.Columns("QREFFW").ColumnName = "INVENTARIO \n CANTIDAD"
        oDtResumen.Columns("QREFFW").Caption = NPOI_SC.FormatDato("INVENTARIO CANTIDAD", NPOI_SC.keyDatoTexto)

        'oDtResumen.Columns("QPSOBL").ColumnName = "INVENTARIO \n PESO"

        oDtResumen.Columns("QPSOBL").Caption = NPOI_SC.FormatDato("INVENTARIO PESO", NPOI_SC.keyDatoTexto)

        'oDtResumen.Columns("QVLBTO").ColumnName = "INVENTARIO \n VOLUMEN"
        oDtResumen.Columns("QVLBTO").Caption = NPOI_SC.FormatDato("INVENTARIO VOLUMEN", NPOI_SC.keyDatoTexto)
        oDtResumen.TableName = "Resumen"

        '************ 
     


        'dtTemp.Columns("CCLNT").ColumnName = "CLIENTE"
        dtTemp.Columns("CCLNT").Caption = NPOI_SC.FormatDato("CLIENTE", NPOI_SC.keyDatoTexto)

        'dtTemp.Columns("TCMPCL").ColumnName = "RAZON SOCIAL"
        dtTemp.Columns("TCMPCL").Caption = NPOI_SC.FormatDato("RAZON SOCIAL", NPOI_SC.keyDatoTexto)

        'dtTemp.Columns("UBICACION").ColumnName = "UBICACIÓN"
        dtTemp.Columns("UBICACION").Caption = NPOI_SC.FormatDato("UBICACIÓN", NPOI_SC.keyDatoTexto)






        dtTemp.Columns("ZONA_ALMACEN").Caption = NPOI_SC.FormatDato("ZONA ALMACEN", NPOI_SC.keyDatoTexto)

        dtTemp.Columns("TIPO_ALMACEN").Caption = NPOI_SC.FormatDato("TIPO_ALMACEN", NPOI_SC.keyDatoTexto)
        dtTemp.Columns("ALMACEN").Caption = NPOI_SC.FormatDato("ALMACEN", NPOI_SC.keyDatoTexto)
        dtTemp.Columns("ZONA").Caption = NPOI_SC.FormatDato("ZONA", NPOI_SC.keyDatoTexto)


        'dtTemp.Columns("CREFFW").ColumnName = "CÓDIGO BULTO"
        dtTemp.Columns("CREFFW").Caption = NPOI_SC.FormatDato("CÓDIGO BULTO", NPOI_SC.keyDatoTexto)

        'dtTemp.Columns("DESCWB").ColumnName = "DESCRIPCIÓN"
        dtTemp.Columns("DESCWB").Caption = NPOI_SC.FormatDato("DESCRIPCIÓN", NPOI_SC.keyDatoTexto)

     
        'dtTemp.Columns("TIPO_MATERIAL").Caption = NPOI_SC.FormatDato("TIPO MATERIAL", NPOI_SC.keyDatoTexto)
     

        'dtTemp.Columns("FREFFW").ColumnName = "FECHA INGRESO"
        dtTemp.Columns("FREFFW").Caption = NPOI_SC.FormatDato("FECHA INGRESO", NPOI_SC.keyDatoTexto)

        'dtTemp.Columns("HORIDE").ColumnName = "HORA INGRESO"
        dtTemp.Columns("HORIDE").Caption = NPOI_SC.FormatDato("HORA INGRESO", NPOI_SC.keyDatoTexto)

        'dtTemp.Columns("QREFFW").ColumnName = "CANTIDAD BULTO"
        dtTemp.Columns("QREFFW").Caption = NPOI_SC.FormatDato("CANTIDAD BULTO", NPOI_SC.keyDatoTexto)


        'dtTemp.Columns("QPSOBL").ColumnName = "PESO BULTO"
        dtTemp.Columns("QPSOBL").Caption = NPOI_SC.FormatDato("PESO BULTO", NPOI_SC.keyDatoTexto)


        'dtTemp.Columns("QMTALT").ColumnName = "ALTURA"
        dtTemp.Columns("QMTALT").Caption = NPOI_SC.FormatDato("ALTURA", NPOI_SC.keyDatoTexto)

        'dtTemp.Columns("QMTANC").ColumnName = "ANCHO"
        dtTemp.Columns("QMTANC").Caption = NPOI_SC.FormatDato("ANCHO", NPOI_SC.keyDatoTexto)

        'dtTemp.Columns("QMTLRG").ColumnName = "LARGO"
        dtTemp.Columns("QMTLRG").Caption = NPOI_SC.FormatDato("LARGO", NPOI_SC.keyDatoTexto)


        'dtTemp.Columns("QVLBTO").ColumnName = "VOLUMEN BULTO"
        dtTemp.Columns("QVLBTO").Caption = NPOI_SC.FormatDato("VOLUMEN BULTO", NPOI_SC.keyDatoTexto)

        'dtTemp.Columns("NORCML").ColumnName = "N° O/C"
        dtTemp.Columns("NORCML").Caption = NPOI_SC.FormatDato("N° O/C", NPOI_SC.keyDatoTexto)

        'dtTemp.Columns("TPRVCL").ColumnName = "PROVEEDOR"
        dtTemp.Columns("TPRVCL").Caption = NPOI_SC.FormatDato("PROVEEDOR", NPOI_SC.keyDatoTexto)

        'dtTemp.Columns("NGRPRV").ColumnName = "N° GUÍA PROVEEDOR"
        dtTemp.Columns("NGRPRV").Caption = NPOI_SC.FormatDato("N° GUÍA PROVEEDOR", NPOI_SC.keyDatoTexto)

        dtTemp.Columns("TLUGEN").ColumnName = "LOTE"
        dtTemp.Columns("LOTE").Caption = NPOI_SC.FormatDato("LOTE", NPOI_SC.keyDatoTexto)

        'dtTemp.Columns("TNMMDT").ColumnName = "MEDIO SUGERIDO"
        dtTemp.Columns("TNMMDT").Caption = NPOI_SC.FormatDato("MEDIO SUGERIDO", NPOI_SC.keyDatoTexto)

        'dtTemp.Columns("CONFIR").ColumnName = "MEDIO CONFIRMADO"
        dtTemp.Columns("CONFIR").Caption = NPOI_SC.FormatDato("MEDIO CONFIRMADO", NPOI_SC.keyDatoTexto)

        'dtTemp.Columns("DIAS").ColumnName = "DIAS EN ALMACEN"
        dtTemp.Columns("DIAS").Caption = NPOI_SC.FormatDato("DIAS EN ALMACEN", NPOI_SC.keyDatoTexto)


        'dtTemp.Columns("TOBSEN").ColumnName = "OBSERVACIONES CONFIRMACION"
        dtTemp.Columns("TOBSEN").Caption = NPOI_SC.FormatDato("OBSERVACIONES CONFIRMACION", NPOI_SC.keyDatoTexto)

        'dtTemp.Columns("NCTAMA").ColumnName = "NRO. CTA MAYOR"
        dtTemp.Columns("NCTAMA").Caption = NPOI_SC.FormatDato("NRO. CTA MAYOR", NPOI_SC.keyDatoTexto)

        'dtTemp.Columns("CCNCOS").ColumnName = "CENTRO DE COSTE"
        dtTemp.Columns("CCNCOS").Caption = NPOI_SC.FormatDato("CENTRO DE COSTE", NPOI_SC.keyDatoTexto)

        'dtTemp.Columns("NELPEP").ColumnName = "NRO. ELEMENTO PEP"
        dtTemp.Columns("NELPEP").Caption = NPOI_SC.FormatDato("NRO. ELEMENTO PEP", NPOI_SC.keyDatoTexto)

        'dtTemp.Columns("NORSAP").ColumnName = "NRO. ORDEN"
        dtTemp.Columns("NORSAP").Caption = NPOI_SC.FormatDato("NRO. ORDEN", NPOI_SC.keyDatoTexto)

        'dtTemp.Columns("NGFSAP").ColumnName = "NRO. GRAFO"
        dtTemp.Columns("NGFSAP").Caption = NPOI_SC.FormatDato("NRO. GRAFO", NPOI_SC.keyDatoTexto)

        'dtTemp.Columns("SINCUENTA").ColumnName = "SIN CUENTA"
        dtTemp.Columns("SINCUENTA").Caption = NPOI_SC.FormatDato("SIN CUENTA", NPOI_SC.keyDatoTexto)

        'dtTemp.Columns("TCTCST").ColumnName = "CUENTA IMP. TERRESTRE"
        dtTemp.Columns("TCTCST").Caption = NPOI_SC.FormatDato("CUENTA IMP. TERRESTRE", NPOI_SC.keyDatoTexto)

        'dtTemp.Columns("TCTCSA").ColumnName = "CUENTA IMP. AEREO"
        dtTemp.Columns("TCTCSA").Caption = NPOI_SC.FormatDato("CUENTA IMP. AEREO", NPOI_SC.keyDatoTexto)

        'dtTemp.Columns("TCTCSF").ColumnName = "CUENTA IMP.FLUVIAL"
        dtTemp.Columns("TCTCSF").Caption = NPOI_SC.FormatDato("CUENTA IMP.FLUVIAL", NPOI_SC.keyDatoTexto)

        'dtTemp.Columns("TCTCAL").ColumnName = "CUENTA IMP. ALMACENAJE"
        dtTemp.Columns("TCTCAL").Caption = NPOI_SC.FormatDato("CUENTA IMP. ALMACENAJE", NPOI_SC.keyDatoTexto)

        'dtTemp.Columns("REFERENCIA").ColumnName = "REFERENCIA"
        dtTemp.Columns("REFERENCIA").Caption = NPOI_SC.FormatDato("REFERENCIA", NPOI_SC.keyDatoTexto)

        'Dim MSH As String = ""
        'For Each ITEM As DataColumn In dtTemp.Columns
        '    If Not ("" & ITEM.Caption).Contains("TITULO_COLUMNA") Then
        '        MSH = MSH & ITEM.Caption & ": SIN VALOR" & Chr(10)
        '    End If
        'Next
        'MessageBox.Show(MSH, "aVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning)


        Dim oDtFiltro As New DataTable
        'Dim objListdt As New List(Of DataTable)

        Dim oDt2 As DataTable
        Dim oDtv1 As DataView = New DataView(dtTemp)
        oDt2 = oDtv1.ToTable(True, "LOTE")

        For intRows As Integer = 0 To oDt2.Rows.Count - 1
            oDtFiltro = SelectDataTable(dtTemp, "[LOTE] = '" + oDt2.Rows(intRows).Item(0) + "'")
            oDtFiltro.TableName = NombreTabla(oDt2.Rows(intRows).Item(0).ToString.Trim) & "  "
            oDs.Tables.Add(oDtFiltro)

            ListaDatatable.Add(oDtFiltro.Copy)

        Next

        ListaDatatable.Add(oDtResumen.Copy)
 

        oDs.Tables.Add(oDtResumen)

        'Filtros
        Dim strSentidoCarga As String = ""
        If Me.txtSentidoCarga.Tag Is Nothing OrElse Me.txtSentidoCarga.Tag = "" Then
            strSentidoCarga = "Todos"
        Else
            strSentidoCarga = Me.txtSentidoCarga.Text
        End If
        'Dim strlFiltro As New List(Of String)
        'strlFiltro.Add("Planta :\n" & Me.UcPLanta_Cmb011.DescripcionPlanta)
        'strlFiltro.Add("Sentido de Carga:\n" & strSentidoCarga)
        'strlFiltro.Add("Fecha :\n" & dteFechaInventario.Value.Date)

        'Suma
        Dim listSuma As New Hashtable
        listSuma.Add("Suma01", 12)
        listSuma.Add("Suma02", 13)
        listSuma.Add("Suma03", 17)



        'ListaDatatable.Add(dtExport.Copy)

        Dim LisFiltros As New List(Of SortedList)
        Dim itemSortedList As SortedList
        Dim ListTitulo As New List(Of String)
        'For i As Integer to ListaDatatable.Count 
        For intRows As Integer = 0 To ListaDatatable.Count - 1

            itemSortedList = New SortedList
            itemSortedList.Add(itemSortedList.Count, "Planta:|" & Me.UcPLanta_Cmb011.DescripcionPlanta)
            itemSortedList.Add(itemSortedList.Count, "Sentido de Carga :|" & strSentidoCarga)
            itemSortedList.Add(itemSortedList.Count, "Fecha :|" & dteFechaInventario.Value.Date)
            LisFiltros.Add(itemSortedList)

            ListTitulo.Add("INVENTARIO POR UBICACION")
        Next


        'itemSortedList = New SortedList
        'itemSortedList.Add(itemSortedList.Count, "Planta:|" & Me.UcPLanta_Cmb011.DescripcionPlanta)
        'itemSortedList.Add(itemSortedList.Count, "Sentido de Carga :|" & strSentidoCarga)
        'itemSortedList.Add(itemSortedList.Count, "Fecha :|" & dteFechaInventario.Value.Date)
        'LisFiltros.Add(itemSortedList)

        'ListTitulo.Add("INVENTARIO POR UBICACION")

        NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListTitulo, Nothing, LisFiltros, 0, Nothing)



        'HelpClass.ExportExcelConTitulosAlmacen(oDs, Me.Text, strlFiltro, listSuma)
    End Sub



    Private Sub CargarUbicacion()
        'Try
        If txtCliente2.Resultado IsNot Nothing Then
            Dim oListColum As New Hashtable
            Dim oColumnas As New DataGridViewTextBoxColumn
            Dim objNegocio As New brUbicacionesXCliente
            Dim strCliente As String = ""
            Dim Est As String = txtCliente2.Resultado.GetType.ToString
            If Est = "Ransa.Utilitario.beCliente" Then
                strCliente = CType(txtCliente2.Resultado, beCliente).Codigo
            Else
                strCliente = ListaCodigoClientes()
            End If

            oListColum = New Hashtable

            oColumnas = New DataGridViewTextBoxColumn
            oColumnas.Name = "PNCCLNT"
            oColumnas.DataPropertyName = "PNCCLNT"
            oColumnas.HeaderText = "Cod. Cliente"
            oColumnas.Visible = True
            oListColum.Add(1, oColumnas)

            oColumnas = New DataGridViewTextBoxColumn
            oColumnas.Name = "PSTCMPCL"
            oColumnas.DataPropertyName = "PSTCMPCL"
            oColumnas.HeaderText = "Cliente "
            oColumnas.Visible = True
            oListColum.Add(2, oColumnas)

            oColumnas = New DataGridViewTextBoxColumn
            oColumnas.Name = "PSTUBRFR_1"
            oColumnas.DataPropertyName = "PSTUBRFR"
            oColumnas.HeaderText = "Ubicación"
            oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            oListColum.Add(3, oColumnas)

            oColumnas = New DataGridViewTextBoxColumn
            oColumnas.Name = "PSTUBRFR"
            oColumnas.DataPropertyName = "PSTUBRFR"
            oColumnas.HeaderText = "Ubicación "
            oColumnas.Visible = False
            oListColum.Add(4, oColumnas)


            txtUbicacionReferencial.DataSource = objNegocio.folistUbicacionXCliente(strCliente)
            txtUbicacionReferencial.ListColumnas = oListColum
            txtUbicacionReferencial.Cargas()
            txtUbicacionReferencial.Limpiar()
            txtUbicacionReferencial.ValueMember = "PSTUBRFR"
            txtUbicacionReferencial.DispleyMember = "PSTUBRFR"
        Else
            txtUbicacionReferencial.DataSource = Nothing
        End If

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub txtCliente_InformationChanged()
        CargarUbicacion()
    End Sub

    Private Sub Modelo06PERENCOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modelo06PERENCOToolStripMenuItem.Click
        Try
            ExportarModeloPerenco()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ExportarModeloPerenco()
        Dim oDtExcel As DataTable
        Dim strTitulo As String = ""
        'strTitulo = Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial
        oDtExcel = pReporteInventarioAlmacenModeloPerenco.Copy
        oDtExcel = EliminarRepetidoModeloPerenco(oDtExcel)
        ExportarExcelOCModelo06Perenco(oDtExcel, strTitulo)
    End Sub

    Private Function pReporteInventarioAlmacenModeloPerenco() As DataTable
        'Try
        Dim dtTemp As DataTable = Nothing
        Dim obeFiltro As New Ransa.TypeDef.Reportes.beFiltrosDespachoPorAlmacen
        Dim obrReporteAT As New brReporteAT
        With obeFiltro
            .PSCCMPN = Me.UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCDVSN = Me.UcDivision_Cmb011.Division
            .PNCPLNDV = Me.UcPLanta_Cmb011.Planta
            Dim Est As String = txtCliente2.Resultado.GetType.ToString
            If Est = "Ransa.Utilitario.beCliente" Then
                .PSCCLNT = CType(txtCliente2.Resultado, beCliente).Codigo
            Else
                .PSCCLNT = ListaCodigoClientes()
            End If
            .PNFPROCE = IIf(Me.dteFechaInventario.Checked, dteFechaInventario.Value, 0)
            .PSTUBRFR = txtUbicacionReferencial.Text()
            .PSSSNCRG = "" & Me.txtSentidoCarga.Tag & ""

        End With
        Return obrReporteAT.frptInventarioAlmacenModeloPerenco(obeFiltro)
        'Catch ex As Exception
        '    Return New DataTable
        'End Try
    End Function

    Private Function EliminarRepetidoModeloPerenco(ByVal dtTemp As DataTable) As DataTable

        Dim dblValor As Decimal = Decimal.Zero
        dtTemp.Select("", "CCLNT, TUBRFR, CREFFW  ASC")
        For i As Integer = dtTemp.Rows.Count - 1 To 1 Step -1
            If dtTemp.Rows(i).Item("CREFFW").ToString.Trim.Equals(dtTemp.Rows(i - 1).Item("CREFFW").ToString.Trim) Then
                dtTemp.Rows.RemoveAt(i)
            End If
        Next
        Return dtTemp
    End Function

    Private Sub ExportarExcelOCModelo06Perenco(ByVal oDtExcel As DataTable, ByVal strTitulo As String)
        Dim oDt As New DataTable
        Dim oDtRe As New DataTable
        Dim oDtFiltro As New DataTable
        Dim oDt2 As DataTable
        Dim strSentidoCarga As String = ""
        oDt = oDtExcel.Copy
        oDtRe = oDtExcel.Copy
        Dim oDs As New DataSet
        oDt.Columns("CCLNT").ColumnName = "CLIENTE"
        oDt.Columns("TCMPCL").ColumnName = "RAZON SOCIAL"
        oDt.Columns("CTPALM").ColumnName = "TIPO ALMACÉN"
        oDt.Columns("CALMC").ColumnName = "ALMACÉN"
        oDt.Columns("ZONA").ColumnName = "ZONA"
        oDt.Columns("TUBRFR").ColumnName = "UBICACIÓN"
        oDt.Columns("CREFFW").ColumnName = "BULTO"
        oDt.Columns("DESCWB").ColumnName = "DESCRIPCIÓN"
        oDt.Columns("FINGAL").ColumnName = "FECHA  INGRESO"
        oDt.Columns("HORIDE").ColumnName = "HORA  INGRESO"

        oDt.Columns("QREFFW").ColumnName = "QTA  BULTO"
        oDt.Columns("TIPBTO").ColumnName = "TIPO"
        oDt.Columns("QPSOBL").ColumnName = "PESO  BULTO"
        oDt.Columns("QVLBTO").ColumnName = "VOL. BULTO"
        oDt.Columns("TTINTC").ColumnName = "ORIGEN"
        oDt.Columns("TPRVCL").ColumnName = "PROVEEDOR"
        oDt.Columns("QAROCP").ColumnName = "M2"
        oDt.Columns("NORCML").ColumnName = "ORDEN COMPRA"
        oDt.Columns("NGRPRV").ColumnName = "GUÍA PROVEEDOR"
        oDt.Columns("TLUGEN").ColumnName = "LUGAR"
        oDt.Columns("SSNCRG").ColumnName = "SENTIDO"
        oDt.Columns("DIAS").ColumnName = "DIAS"
        oDt.Columns("TNMMDT").ColumnName = "VÍA"
        oDt.Columns("CLSTRF").ColumnName = "TARIFA"
        oDt.Columns("TABCLR").ColumnName = "ETIQUETA"
        oDt.Columns("TOBSEN").ColumnName = "OBSERVACIÓN"

        Dim oDtv1 As DataView = New DataView(oDt)
        oDt2 = oDtv1.ToTable(True, "LUGAR")

        For intRows As Integer = 0 To oDt2.Rows.Count - 1
            oDtFiltro = SelectDataTable(oDt, "[LUGAR] = '" + oDt2.Rows(intRows).Item(0) + "'")
            oDtFiltro.TableName = NombreTabla(oDt2.Rows(intRows).Item(0).ToString.Trim) & " "
            oDs.Tables.Add(oDtFiltro)
        Next

        '*********
        Dim oDtv3 As DataView = New DataView(oDtRe)
        Dim oDtv2 As DataView = New DataView(oDtRe)
        Dim oDtResumen As New DataTable
        Dim oDt1 As New DataTable
        Dim oDt4 As New DataTable
        Dim oDt3 As New DataTable
        Dim oDtFiltro2 As New DataTable
        Dim oDr As DataRow

        oDt1 = oDtv3.ToTable(True, "CCLNT", "TCMPCL", "CTPALM", "CALMC", "ZONA", "CREFFW", "QREFFW", "QPSOBL", "QVLBTO")
        oDt4 = oDtv2.ToTable(True, "CCLNT", "TCMPCL", "CTPALM", "CALMC", "ZONA")
        Dim oDtv4 As DataView = New DataView(oDt4)
        oDtv4.Sort = "CCLNT, CTPALM ASC"
        oDt3 = oDtv4.ToTable(False, "CCLNT", "TCMPCL", "CTPALM", "CALMC", "ZONA")
        oDtResumen.Columns.Add("TCMPCL1")
        oDtResumen.Columns.Add("TIPO_ALMACEN1")
        oDtResumen.Columns.Add("ALMACEN1")
        oDtResumen.Columns.Add("ZONA")
        oDtResumen.Columns.Add("QREFFW")
        oDtResumen.Columns.Add("QPSOBL")
        oDtResumen.Columns.Add("QVLBTO")

        For i As Integer = 0 To oDt3.Rows.Count - 1
            oDtFiltro2 = SelectDataTable(oDt1, "CCLNT = '" + oDt3.Rows(i).Item("CCLNT").ToString.Trim + "' AND CTPALM = '" + oDt3.Rows(i).Item("CTPALM") + "' AND CALMC = '" + oDt3.Rows(i).Item("CALMC") + "' AND ZONA = '" + oDt3.Rows(i).Item("ZONA") + "' ")
            oDr = oDtResumen.NewRow()
            oDr("TCMPCL1") = oDt3.Rows(i).Item("TCMPCL")
            oDr("TIPO_ALMACEN1") = oDt3.Rows(i).Item("CTPALM")
            oDr("ALMACEN1") = oDt3.Rows(i).Item("CALMC")
            oDr("ZONA") = oDt3.Rows(i).Item("ZONA")
            oDr("QREFFW") = SumarDataTable(oDtFiltro2, "QREFFW")
            oDr("QPSOBL") = SumarDataTable(oDtFiltro2, "QPSOBL")
            oDr("QVLBTO") = SumarDataTable(oDtFiltro2, "QVLBTO")
            oDtResumen.Rows.Add(oDr)
        Next

        oDtResumen.Columns("TCMPCL1").ColumnName = "RAZON SOCIAL"
        oDtResumen.Columns("TIPO_ALMACEN1").ColumnName = "TIPO ALMACEN"
        oDtResumen.Columns("ALMACEN1").ColumnName = "ALMACEN"
        oDtResumen.Columns("ZONA").ColumnName = "ZONA"
        oDtResumen.Columns("QREFFW").ColumnName = "INVENTARIO \n CANTIDAD"
        oDtResumen.Columns("QPSOBL").ColumnName = "INVENTARIO \n PESO"
        oDtResumen.Columns("QVLBTO").ColumnName = "INVENTARIO \n VOLUMEN"

        oDtResumen.TableName = "Resumen"
        oDs.Tables.Add(oDtResumen)
        '*********

        If Me.txtSentidoCarga.Tag Is Nothing OrElse Me.txtSentidoCarga.Tag = "" Then
            strSentidoCarga = "TODOS"
        Else
            strSentidoCarga = Me.txtSentidoCarga.Text
        End If

        Dim strlTitulo As New List(Of String)
        'strlTitulo.Add("Cliente:\n" & Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial)
        strlTitulo.Add("Planta:\n" & Me.UcPLanta_Cmb011.DescripcionPlanta)
        If (Me.txtUbicacionReferencial.Tag Is Nothing OrElse Me.txtUbicacionReferencial.Tag = "") AndAlso Me.txtUbicacionReferencial.Text = "" Then
            strlTitulo.Add("Ubicación :\nTODOS")
        Else
            strlTitulo.Add("Ubicación :\n" & Me.txtUbicacionReferencial.Text)
        End If

        strlTitulo.Add("Sentido de Carga:\n" & strSentidoCarga)
        strlTitulo.Add("Fechas  de Inventario:\n" & Me.dteFechaInventario.Value.Date)

        'Suma 
        Dim listSuma As New Hashtable
        'listSuma.Add("Suma01", 6)
        'listSuma.Add("Suma02", 8)
        'listSuma.Add("Suma03", 9)
        HelpClass.ExportExcelConTitulosAlmacen(oDs, Me.Text, strlTitulo, listSuma)
    End Sub

    Private Sub pReporteImprimirInventarioAlmacenOC()
        Dim dstTemp As New DataSet '= Nothing
        Dim rptTemp As New ReportDocument
        dstTemp.Tables.Add(objTemp.Tables(0).Copy)

        If dstTemp.Tables.Count > 0 Then
            rptTemp = New rptInventarioAlmacenOc
            dstTemp.Tables(0).TableName = "InventarioAlmacen"
            rptTemp.SetDataSource(dstTemp)
            rptTemp.Refresh()
            ' Ingresamos parametros adicionales
            rptTemp.SetParameterValue("pUsuario", objSeguridadBN.pUsuario)
            'rptTemp.SetParameterValue("pCliente", obeFiltro.PNCCLNT)
            'rptTemp.SetParameterValue("pRazonSocial", obeFiltro.PSTCMPCL)
            rptTemp.SetParameterValue("pFecha", dteFechaInventario.Value)
            Dim frmPrintForm As New PrintForm
            frmPrintForm.MaximizeBox = True
            frmPrintForm.ShowForm(rptTemp, Me)
        End If
    End Sub

    Private Sub pReporteImprimirInventarioAlmacenItem()
        Dim dstTemp As New DataSet '= Nothing
        Dim rptTemp As New ReportDocument
        dstTemp.Tables.Add(objTemp.Tables(0).Copy)

        If dstTemp.Tables.Count > 0 Then
            rptTemp = New rptInventarioAlmacenItem
            dstTemp.Tables(0).TableName = "InventarioAlmacen"
            rptTemp.SetDataSource(dstTemp)
            rptTemp.Refresh()
            ' Ingresamos parametros adicionales
            rptTemp.SetParameterValue("pUsuario", objSeguridadBN.pUsuario)
            'rptTemp.SetParameterValue("pCliente", obeFiltro.PNCCLNT)
            'rptTemp.SetParameterValue("pRazonSocial", obeFiltro.PSTCMPCL)
            rptTemp.SetParameterValue("pFecha", dteFechaInventario.Value)
            Dim frmPrintForm As New PrintForm
            frmPrintForm.MaximizeBox = True
            frmPrintForm.ShowForm(rptTemp, Me)
        End If
    End Sub

    Private Sub pReporteImprimirInventarioAlmacenSubItem()
        Dim dstTemp As New DataSet '= Nothing
        Dim rptTemp As New ReportDocument
        dstTemp.Tables.Add(objTemp.Tables(0).Copy)

        If dstTemp.Tables.Count > 0 Then
            rptTemp = New rptInventarioAlmacenSubItem
            dstTemp.Tables(0).TableName = "InventarioAlmacen"
            rptTemp.SetDataSource(dstTemp)
            rptTemp.Refresh()
            ' Ingresamos parametros adicionales
            rptTemp.SetParameterValue("pUsuario", objSeguridadBN.pUsuario)
            'rptTemp.SetParameterValue("pCliente", obeFiltro.PNCCLNT)
            'rptTemp.SetParameterValue("pRazonSocial", obeFiltro.PSTCMPCL)
            rptTemp.SetParameterValue("pFecha", dteFechaInventario.Value)
            Dim frmPrintForm As New PrintForm
            frmPrintForm.MaximizeBox = True
            frmPrintForm.ShowForm(rptTemp, Me)
        End If
    End Sub

    Private Sub tsbImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbImprimir.Click
        If Me.rbtOrdenDeCompra.Checked Then
            Call pReporteImprimirInventarioAlmacenOC()
        ElseIf rbtItem.Checked Then
            Call pReporteImprimirInventarioAlmacenItem()
        Else
            pReporteImprimirInventarioAlmacenSubItem()
        End If
    End Sub

    Private Sub txtCliente2_CambioDeTexto(ByVal objData As Object) Handles txtCliente2.CambioDeTexto
        CargarUbicacion()
    End Sub



    'CSR-HUNDRED-INICIO


    Private Sub ExportarExcelItem_5(ByVal oDtExcel As DataTable, ByVal strTitulo As String, ByVal oDtRe As DataTable)
        Dim oDtAlternativo As New DataTable
        Dim objListdt As New List(Of DataTable)
        Dim oDs As New DataSet
        Dim strSentidoCarga As String = String.Empty

        oDtAlternativo = GeneraDtAlternativo_5(oDtExcel)
        oDtAlternativo.Columns("CCLNT").ColumnName = "COD. CLIENTE"
        oDtAlternativo.Columns("TCMPCL").ColumnName = "RAZÓN SOCIAL"
        oDtAlternativo.Columns("TIPO_ALMACEN").ColumnName = "TIPO ALMACEN"
        oDtAlternativo.Columns("ALMACEN").ColumnName = "ALMACEN"
        oDtAlternativo.Columns("ZONA").ColumnName = "ZONA"
        oDtAlternativo.Columns("TUBRFR").ColumnName = "UBICACIÓN"
        oDtAlternativo.Columns("CREFFW").ColumnName = "BULTO"
        oDtAlternativo.Columns("DESCRIPCION").ColumnName = "DESCRIPCION"
        oDtAlternativo.Columns("FINGAL").ColumnName = "FECHA INGRESO"
        oDtAlternativo.Columns("HORIDE").ColumnName = "HORA  INGRESO"
        oDtAlternativo.Columns("QREFFW").ColumnName = "QTA. BULTO"
        oDtAlternativo.Columns("TIPBTO").ColumnName = "TIPO BULTO"
        oDtAlternativo.Columns("QPSOBL").ColumnName = "PESO BULTO"
        oDtAlternativo.Columns("QVLBTO").ColumnName = "VOL. BULTO"
        oDtAlternativo.Columns("QAROCP").ColumnName = "AREA BULTO"
        oDtAlternativo.Columns("TPRVCL").ColumnName = "PROVEEDOR"
        oDtAlternativo.Columns("NORCML").ColumnName = "ORDEN COMPRA"
        oDtAlternativo.Columns("NRITOC").ColumnName = "NRO. ITEM"
        oDtAlternativo.Columns("TCITCL").ColumnName = "COD. MATERIAL"
        oDtAlternativo.Columns("TDITES").ColumnName = "DESCRIPCION DEL MATERIAL"
        oDtAlternativo.Columns("QBLTSR").ColumnName = "SALDO CANTIDAD"
        oDtAlternativo.Columns("TUNDIT").ColumnName = "UNIDAD MEDIDA"
        oDtAlternativo.Columns("NRPDTS").ColumnName = "NRO. PEDIDO"
        oDtAlternativo.Columns("NROSEC").ColumnName = "NRO. SECUENCIA PEDIDO"
        oDtAlternativo.Columns("QPNDPD").ColumnName = "CANTIDAD PEDIDO PENDIENTE"

        oDtAlternativo.TableName = "Inventario Bultos x Pedidos "
        oDs.Tables.Add(oDtAlternativo)


        Dim strlTitulo As New List(Of String)
        strlTitulo.Add("Planta :\n" & Me.UcPLanta_Cmb011.DescripcionPlanta)


        If CType(txtUbicacionReferencial.Resultado, beGeneral) Is Nothing Then
            strlTitulo.Add("Ubicación :\nTODOS")
        Else
            Dim Ubicacion As String = CType(txtUbicacionReferencial.Resultado, beGeneral).PSTUBRFR
            strlTitulo.Add("Ubicación :\n" & Ubicacion)

        End If

        If Me.txtTipoMovimiento.Tag Is Nothing OrElse Me.txtTipoMovimiento.Tag = "" Then
            strlTitulo.Add("Tipo de Mov.:\nTODOS")
        Else
            strlTitulo.Add("Tipo de Mov.:\n" & Me.txtTipoMovimiento.Text)
        End If

        If Me.txtSentidoCarga.Tag Is Nothing OrElse Me.txtSentidoCarga.Tag = "" Then
            strlTitulo.Add("Sentido de Carga:\nTODOS")
        Else
            strlTitulo.Add("Sentido de Carga:\n" & Me.txtSentidoCarga.Text)
        End If

        strlTitulo.Add("Fechas  de Inventario:\n" & Me.dteFechaInventario.Value.Date)

        HelpClass.ExportExcelInventarioBultosXPedido(oDs, Me.Text, strlTitulo)
    End Sub


    Private Function GeneraDtAlternativo_5(ByVal oDt As DataTable, Optional ByVal blSubItem As Boolean = False) As DataTable
        Dim oDtAlt As New DataTable
        Dim drAlt As DataRow
        Dim strBulto As String = String.Empty

        FormatoCabeceraExportarExcel_5(oDtAlt, blSubItem)

        For Each dr As DataRow In oDt.Rows

            drAlt = oDtAlt.NewRow

            'If dr("CREFFW").ToString().Trim <> strBulto Then
            drAlt("CCLNT") = dr("CCLNT")
            drAlt("TCMPCL") = dr("TCMPCL")
            drAlt("TUBRFR") = dr("TUBRFR")
            drAlt("CREFFW") = dr("CREFFW")
            drAlt("TIPO_ALMACEN") = dr("TIPO_ALMACEN")
            drAlt("ALMACEN") = dr("ALMACEN")
            drAlt("DESCRIPCION") = dr("DESCRIPCION")
            drAlt("ZONA") = dr("ZONA")
            drAlt("FINGAL") = dr("FINGAL")
            drAlt("HORIDE") = dr("HORIDE")

            drAlt("QREFFW") = dr("QREFFW")
            drAlt("TIPBTO") = dr("TIPBTO")
            drAlt("QPSOBL") = dr("QPSOBL")
            drAlt("QVLBTO") = dr("QVLBTO")
            drAlt("TPRVCL") = dr("TPRVCL")
            drAlt("QAROCP") = dr("QAROCP")
            drAlt("NORCML") = dr("NORCML")
            'Else
            '    drAlt("CCLNT") = ""
            '    drAlt("TCMPCL") = ""
            '    drAlt("TUBRFR") = ""
            '    drAlt("CREFFW") = ""
            '    drAlt("TIPO_ALMACEN") = ""
            '    drAlt("ALMACEN") = ""
            '    drAlt("DESCRIPCION") = ""
            '    drAlt("ZONA") = ""
            '    drAlt("FINGAL") = ""
            '    drAlt("QREFFW") = DBNull.Value
            '    drAlt("TIPBTO") = ""
            '    drAlt("QPSOBL") = DBNull.Value
            '    drAlt("QVLBTO") = DBNull.Value
            '    drAlt("TPRVCL") = ""
            '    drAlt("QAROCP") = DBNull.Value
            '    drAlt("NORCML") = ""

            'End If
            strBulto = dr("CREFFW").ToString().Trim
            drAlt("NRITOC") = dr("NRITOC")
            drAlt("TCITCL") = dr("TCITCL")
            drAlt("TDITES") = dr("TDITES")
            drAlt("NRPDTS") = dr("NRPDTS")
            drAlt("NROSEC") = dr("NROSEC")

            Dim saldo As Decimal = dr("QPNDPD")
            Dim cantidadpendiente As Decimal = dr("QBLTSR")
            'Dim a As String = saldo.ToString("#00.00")

            drAlt("QPNDPD") = saldo.ToString("#00.00") 'formato 2 decimales 
            drAlt("QBLTSR") = cantidadpendiente.ToString("#00.00")  'formato 2 decimales

            drAlt("TUNDIT") = dr("TUNDIT")

            oDtAlt.Rows.Add(drAlt)
        Next
        Return oDtAlt

    End Function



    Private Sub FormatoCabeceraExportarExcel_5(ByVal cpoDataTable As DataTable, Optional ByVal blSubItem As Boolean = False)
        cpoDataTable.Columns.Add("CCLNT", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("TCMPCL", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("TIPO_ALMACEN", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("ALMACEN", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("ZONA", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("TUBRFR", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("CREFFW", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("DESCRIPCION", System.Type.GetType("System.String"))

        cpoDataTable.Columns.Add("FINGAL", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("HORIDE", System.Type.GetType("System.String"))

        cpoDataTable.Columns.Add("QREFFW", System.Type.GetType("System.Decimal"))
        cpoDataTable.Columns.Add("TIPBTO", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("QPSOBL", System.Type.GetType("System.Decimal"))
        cpoDataTable.Columns.Add("QVLBTO", System.Type.GetType("System.Decimal"))
        cpoDataTable.Columns.Add("QAROCP", System.Type.GetType("System.Decimal"))
        cpoDataTable.Columns.Add("TPRVCL", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("NORCML", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("NRITOC", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("TCITCL", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("TDITES", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("QBLTSR", System.Type.GetType("System.Decimal"))
        cpoDataTable.Columns.Add("TUNDIT", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("NRPDTS", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("NROSEC", System.Type.GetType("System.String"))
        cpoDataTable.Columns.Add("QPNDPD", System.Type.GetType("System.Decimal"))

    End Sub
    'CSR-HUNDRED-FIN

    Private Sub Modelo05MatpelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modelo05MatpelToolStripMenuItem.Click
        Try
            ExportarExcel(6)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Modelo05MatpelDimenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Modelo05MatpelDimenToolStripMenuItem.Click
        Try
            ExportarExcel(7)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

