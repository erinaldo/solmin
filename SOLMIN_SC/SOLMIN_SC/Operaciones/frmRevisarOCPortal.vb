Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Negocio
Imports CTLServicios
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Web

Public Class frmRevisarOCPortal
    Private objImpInfo As New SOLMIN_SC.Negocio.clsImpInfEmbarcador
    Private objPortalDetalle As New SOLMIN_SC.Entidad.bePortalDetalle
    Private Sub frmRevisarOCPortal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ocultar_Controles()
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Mostrar_Controles()
        Me.Cursor = Cursors.WaitCursor
        cargarDtgOcPortar()
        Me.Cursor = Cursors.Default
    End Sub
#Region "Comun"
    Private Sub Limpiar_Controles()
        Me.dtgOCPortal.Rows.Clear()
    End Sub
    Private Sub Ocultar_Controles()
        Me.dtgOCPortal.Visible = False
        '   HGTotal.Visible = False
        btnActualizar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
        btnResumen.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
    End Sub
    Private Sub Mostrar_Controles()
        Me.dtgOCPortal.Visible = True
        '  HGTotal.Visible = True
        btnActualizar.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
        btnResumen.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
    End Sub
#End Region

    Private Sub cargarDtgOcPortar()
        'ObtengoCodigo YRC Portal
        If Not (UcCliente.pCodigo = 0) Then
            If CStr(objImpInfo.Obtener_Informacion_M001_Clientes(UcCliente.pNroRuc)).Length > 10 Then
                HelpUtil.MsgBox(objImpInfo.Obtener_Informacion_M001_Clientes(UcCliente.pNroRuc))
                Exit Sub
            Else
                objPortalDetalle.PSCLIENTE = objImpInfo.Obtener_Informacion_M001_Clientes(UcCliente.pNroRuc)
                objPortalDetalle.PSCLIENTE_SOL = UcCliente.pCodigo
                objPortalDetalle.PSCLIENTE_NOMBRE = UcCliente.pRazonSocial
            End If

            Dim oDt As DataTable
            'Se hace el llenado de la grilla
            If objPortalDetalle.PSCLIENTE <> 0 Then
                Dim intCont As Integer
                'Envio Codigo YRC-PORTAL y codigo Cliente SOLMIN
                oDt = objImpInfo.Obtener_Informacion_T002_OC_ITEMS(objPortalDetalle.PSCLIENTE)

                objPortalDetalle.PSTABLA = oDt.Clone
                objPortalDetalle.PSTABLA.Rows.Clear()

                If oDt.Rows.Count > 0 Then
                    Limpiar_Controles()
                    For intCont = 0 To oDt.Rows.Count - 1
                        Agrega_Row_OI()
                        With Me.dtgOCPortal
                            'Indicar los nombres de las columnas
                            .Rows(intCont).Cells("CCLIENT").Value = oDt.Rows(intCont).Item("CCLIENT")
                            .Rows(intCont).Cells("SNROOC").Value = oDt.Rows(intCont).Item("SNROOC")
                            .Rows(intCont).Cells("SNROITE").Value = oDt.Rows(intCont).Item("SNROITE")
                            .Rows(intCont).Cells("NCNTORD").Value = Format(CType(oDt.Rows(intCont).Item("NCNTORD"), Double), "###,###,###,##0")
                            .Rows(intCont).Cells("CUNDMED").Value = oDt.Rows(intCont).Item("CUNDMED")
                            .Rows(intCont).Cells("SNROPTE").Value = IIf(IsDBNull(oDt.Rows(intCont).Item("SNROPTE")), "", oDt.Rows(intCont).Item("SNROPTE"))
                            .Rows(intCont).Cells("SPREUNI").Value = Format(CType(oDt.Rows(intCont).Item("SPREUNI"), Double), "###,###,###,##0.00")
                            .Rows(intCont).Cells("SDESC").Value = IIf(IsDBNull(oDt.Rows(intCont).Item("SDESC")), "", oDt.Rows(intCont).Item("SDESC"))
                            If Not IsDBNull(oDt.Rows(intCont).Item("DREQ")) Then
                                .Rows(intCont).Cells("DREQ").Value = IIf(IsDBNull(oDt.Rows(intCont).Item("DREQ")), "", Format(oDt.Rows(intCont).Item("DREQ"), "dd/MM/yyyy"))
                            Else
                                .Rows(intCont).Cells("DREQ").Value = "0"
                            End If
                            .Rows(intCont).Cells("SLUGENT").Value = oDt.Rows(intCont).Item("SLUGENT")
                            '.Rows(intCont).Cells("SCOMENT").Value = oDt.Rows(intCont).Item("SCOMENT")
                            .Rows(intCont).Cells("NCNTRECORI").Value = Format(CType(oDt.Rows(intCont).Item("NCNTRECORI"), Double), "###,###,###,##0.00")
                            .Rows(intCont).Cells("NCNTSHPORI").Value = Format(CType(oDt.Rows(intCont).Item("NCNTSHPORI"), Double), "###,###,###,##0.00")
                            .Rows(intCont).Cells("NCNTRECDES").Value = Format(CType(oDt.Rows(intCont).Item("NCNTRECDES"), Double), "###,###,###,##0.00")
                            .Rows(intCont).Cells("NCNTRECALM").Value = Format(CType(oDt.Rows(intCont).Item("NCNTRECALM"), Double), "###,###,###,##0.00")
                            .Rows(intCont).Cells("NCNTTRADES").Value = Format(CType(oDt.Rows(intCont).Item("NCNTTRADES"), Double), "###,###,###,##0.00")
                            'Importamos a oDtGlobal
                            objPortalDetalle.PSTABLA.ImportRow(oDt.Rows(intCont))
                        End With
                    Next intCont

                    txtTotal.Text = objPortalDetalle.PSTABLA.Rows.Count
                    '---------------------------------------ACD
                Else
                    Ocultar_Controles()
                    HelpUtil.MsgBox("No hay registros por mostrar para esta consulta")
                End If
            End If
        Else
            Ocultar_Controles()
            HelpUtil.MsgBox("Debe seleccionar un Cliente")
        End If
    End Sub
    Private Sub Agrega_Row_OI()
        Dim oDrVw As New DataGridViewRow
        oDrVw.CreateCells(Me.dtgOCPortal)
        Me.dtgOCPortal.Rows.Add(oDrVw)
    End Sub

    Private Sub btnResumen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResumen.Click
        If objPortalDetalle.PSTABLA Is Nothing Then
            HelpUtil.MsgBox("No existe información para mostrar")
            Exit Sub
        End If
        Dim cargaRecibida As Integer = 0
        Dim cargaEmbarcada As Integer = 0
        Dim cargaAtendida As Integer = 0 'Recibido en Destino
        Dim cargaRecibidoAlmacen As Integer = 0
        Dim cargaTrasladoCliente As Integer = 0

        Dim frmResumen As frmRevisarOCPortalResumen

        frmResumen = New frmRevisarOCPortalResumen(objPortalDetalle)
        frmResumen.ShowInTaskbar = False
        frmResumen.StartPosition = FormStartPosition.CenterScreen
        'DataTables No Vacios
        Dim dtCargaRecibida As New DataTable
        Dim dtCargaEmbarcada As New DataTable
        Dim dtCargaAtendida As New DataTable
        Dim dtCargaRecibidoAlmacen As New DataTable
        Dim dtCargaTrasladoCliente As New DataTable
        '-------------------------------------------
        dtCargaRecibida = objPortalDetalle.PSTABLA.Clone
        dtCargaEmbarcada = objPortalDetalle.PSTABLA.Clone
        dtCargaAtendida = objPortalDetalle.PSTABLA.Clone
        dtCargaRecibidoAlmacen = objPortalDetalle.PSTABLA.Clone
        dtCargaTrasladoCliente = objPortalDetalle.PSTABLA.Clone

        For i As Integer = 0 To objPortalDetalle.PSTABLA.Rows.Count - 1
            If objPortalDetalle.PSTABLA.Rows(i).Item("NCNTRECORI") > 0 Then
                dtCargaRecibida.ImportRow(objPortalDetalle.PSTABLA.Rows(i))
                ' cargaRecibida = cargaRecibida + 1
            End If
            If objPortalDetalle.PSTABLA.Rows(i).Item("NCNTSHPORI") > 0 Then
                dtCargaEmbarcada.ImportRow(objPortalDetalle.PSTABLA.Rows(i))
                ' cargaEmbarcada = cargaEmbarcada + 1
            End If
            If objPortalDetalle.PSTABLA.Rows(i).Item("NCNTRECDES") > 0 Then
                dtCargaAtendida.ImportRow(objPortalDetalle.PSTABLA.Rows(i))
                ' cargaAtendida = cargaAtendida + 1
            End If
            If objPortalDetalle.PSTABLA.Rows(i).Item("NCNTRECALM") > 0 Then
                dtCargaRecibidoAlmacen.ImportRow(objPortalDetalle.PSTABLA.Rows(i))
                ' cargaRecibidoAlmacen = cargaRecibidoAlmacen + 1
            End If
            If objPortalDetalle.PSTABLA.Rows(i).Item("NCNTTRADES") > 0 Then
                dtCargaTrasladoCliente.ImportRow(objPortalDetalle.PSTABLA.Rows(i))
                'cargaTrasladoCliente = cargaTrasladoCliente + 1
            End If
        Next

        'Datatable Distintos
        cargaRecibida = Distinto(dtCargaRecibida, "SNROOC").Rows.Count
        cargaEmbarcada = Distinto(dtCargaEmbarcada, "SNROOC").Rows.Count
        cargaAtendida = Distinto(dtCargaAtendida, "SNROOC").Rows.Count
        cargaRecibidoAlmacen = Distinto(dtCargaRecibidoAlmacen, "SNROOC").Rows.Count
        cargaTrasladoCliente = Distinto(dtCargaTrasladoCliente, "SNROOC").Rows.Count


        frmResumen.txtCargaRecibida.Text = cargaRecibida
        frmResumen.txtCargaEmbarcada.Text = cargaEmbarcada
        frmResumen.txtCargaAtendida.Text = cargaAtendida
        frmResumen.txtRecibidoAlmacen.Text = cargaRecibidoAlmacen
        frmResumen.txtCargaTrasladoCliente.Text = cargaTrasladoCliente
        'frmResumen.txtCargatotal.Text = cargaRecibida + cargaEmbarcada + cargaAtendida
        frmResumen.ShowDialog()
    End Sub
    Private Function Distinto(ByVal tablaOrigen As DataTable, ByVal columnas As String) As DataTable
        Dim vista As New DataView(tablaOrigen)
        'Se retorna un distinct de las columnas solicitadas
        Return vista.ToTable(True, columnas)
    End Function

End Class
