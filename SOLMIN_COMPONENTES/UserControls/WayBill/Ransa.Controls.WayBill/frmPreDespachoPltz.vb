Imports Ransa.DAO
Imports Ransa.DAO.WayBill

Public Class frmPreDespachoPltz

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public pCCLNT As Decimal = 0
    Public pCCMPN As String = ""
    Public pCDVSN As String = ""
    Public pCPLNDV As Decimal = 0
    Public pCPLNDV_DESC As String = ""
    Public pDialog As Boolean = False
    Public pUsuario As String = ""
#Region "Eventos"
    Private Sub frmGenPallet_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblPlantaNombre.Text = pCPLNDV_DESC
        kdgv_list_inventario.AutoGenerateColumns = False
        kdgvListPreDespacho.AutoGenerateColumns = False
        kdtgvDetalle.AutoGenerateColumns = False
    End Sub

    Private Sub tsbCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub


#End Region


    

     
    Private Sub rbBulto_CheckedChanged(sender As Object, e As EventArgs) Handles rbBulto.CheckedChanged
        lblFecha.Text = "Fecha Recepción:"
        lblfiltroCodigo.Text = "Bulto:"
    End Sub

    Private Sub rbPaletizado_CheckedChanged(sender As Object, e As EventArgs) Handles rbPaletizado.CheckedChanged
        lblFecha.Text = "Fecha Paletizado:"
        lblfiltroCodigo.Text = "Paletizado:"
    End Sub

    Private Sub Listar_Inventario()
        Dim oWayBill As cWayBill = New Ransa.DAO.WayBill.cWayBill
        Dim dt As New DataTable
        Dim pTipo As String = ""
        If rbBulto.Checked = True Then
            pTipo = "BLT"
        End If
        If rbPaletizado.Checked = True Then
            pTipo = "PLT"
        End If
        Dim TotPaginas As Decimal = 0
        Dim pFiltro As New Ransa.TYPEDEF.WayBill.TD_Sel_Bulto_L01
        pFiltro.pCCLNT_CodigoCliente = pCCLNT
        pFiltro.pCCMPN_Compania = pCCMPN
        pFiltro.pCDVSN_Division = pCDVSN
        pFiltro.pCPLNDV_Planta = pCPLNDV
        pFiltro.pFechaInicio = dtpInicio.Value.ToString("yyyyMMdd")
        pFiltro.pFechaFin = dtpFin.Value.ToString("yyyyMMdd")
        pFiltro.pCREFFW_CodigoBulto = txtBulto.Text.Trim.ToUpper
        dt = oWayBill.ListarInventario(pTipo, UcPaginacion1.PageNumber, UcPaginacion1.PageSize, TotPaginas, pFiltro)
        kdgv_list_inventario.DataSource = dt
        UcPaginacion1.PageCount = TotPaginas
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Listar_Inventario()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

 

    Private Sub btnAdicionar_Click_1(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        Try


            Dim oDr As DataGridViewRow
            Dim FilaReg As Int64 = 0
            kdgv_list_inventario.EndEdit()
            Dim cant_reg As Integer = 0
            Dim Tipo As String = ""
            Dim Codigo As String = ""
            Dim encontrado As Boolean = False
            Dim msgvalidacion As String = ""
            For Each item As DataGridViewRow In kdgv_list_inventario.Rows
                If item.Cells("CHK").Value = True Then

                    Tipo = item.Cells("TIPO").Value
                    Codigo = item.Cells("COD_BULTO").Value
                    encontrado = BuscarCodigo(Tipo, Codigo)

                    If encontrado = False Then
                        cant_reg = cant_reg + 1
                        oDr = New DataGridViewRow
                        oDr.CreateCells(kdgvListPreDespacho)
                        Me.kdgvListPreDespacho.Rows.Add(oDr)
                        FilaReg = kdgvListPreDespacho.Rows.Count - 1

                        kdgvListPreDespacho.Rows(FilaReg).Cells("P_TIPO").Value = item.Cells("TIPO").Value
                        kdgvListPreDespacho.Rows(FilaReg).Cells("P_CCLNT").Value = item.Cells("CCLNT").Value
                        kdgvListPreDespacho.Rows(FilaReg).Cells("P_IDPALETIZADO").Value = item.Cells("IDPALETIZADO").Value
                        kdgvListPreDespacho.Rows(FilaReg).Cells("P_COD_BULTO").Value = item.Cells("COD_BULTO").Value
                        kdgvListPreDespacho.Rows(FilaReg).Cells("P_TIPO_UNIDAD").Value = item.Cells("TIPO_UNIDAD").Value
                        kdgvListPreDespacho.Rows(FilaReg).Cells("P_CANT_BULTOS").Value = item.Cells("CANT_BULTOS").Value
                        kdgvListPreDespacho.Rows(FilaReg).Cells("P_NSEQIN").Value = item.Cells("NSEQIN").Value
                        kdgvListPreDespacho.Rows(FilaReg).Cells("P_FECHA_BULTO").Value = item.Cells("FECHA_BULTO").Value

                        item.Cells("CHK").Value = False
                    Else
                        msgvalidacion = msgvalidacion & Tipo & " - " & Codigo & " ya agregado." & Chr(10)
                        item.Cells("CHK").Value = False
                    End If


                End If
            Next
            msgvalidacion = msgvalidacion.Trim

            kdgv_list_inventario.EndEdit()

            If msgvalidacion.Length > 0 Then
                MessageBox.Show(msgvalidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If cant_reg = 0 Then
                MessageBox.Show("No ha seleccionado registros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

         



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function BuscarCodigo(Tipo As String, Codigo As String) As Integer
        Dim vTipo As String = ""
        Dim vCodigo As String = ""
        Dim encontrado As Boolean = False
        For Each item As DataGridViewRow In kdgvListPreDespacho.Rows
            vTipo = ("" & item.Cells("P_TIPO").Value).ToString.Trim
            vCodigo = ("" & item.Cells("P_COD_BULTO").Value).ToString.Trim
            If Tipo = vTipo And vCodigo = Codigo Then
                encontrado = True
                Exit For
            End If
        Next
        Return encontrado
    End Function

  
    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        Try
            If kdgvListPreDespacho.CurrentRow Is Nothing Then
                Exit Sub
            End If
            If MessageBox.Show("¿Está seguro de quitar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                kdgvListPreDespacho.Rows.RemoveAt(kdgvListPreDespacho.CurrentRow.Index)
                kdgvListPreDespacho.EndEdit()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

 
 

    Private Sub btnPreDespacho_Click(sender As Object, e As EventArgs) Handles btnPreDespacho.Click
        Try
            Dim oWayBill As New DAO.WayBill.cWayBill
            Dim oBulto As Ransa.TypeDef.WayBill.TD_Sel_Bulto_L01
            Dim lstTD_Bultos As New List(Of Ransa.TypeDef.WayBill.TD_Sel_Bulto_L01)


            If kdgvListPreDespacho.Rows.Count = 0 Then
                MessageBox.Show("No se tienen items.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            Dim nroPreDespacho As Decimal = 0
            'Dim strUsuario As String = ""
            Dim sMessage As String = ""
            For Each item As DataGridViewRow In kdgvListPreDespacho.Rows
                oBulto = New Ransa.TypeDef.WayBill.TD_Sel_Bulto_L01
                oBulto.pCCMPN_Compania = pCCMPN
                oBulto.pCDVSN_Division = pCDVSN
                oBulto.pCPLNDV_Planta = pCPLNDV
                oBulto.pCCLNT_CodigoCliente = pCCLNT
                oBulto.pCREFFW_CodigoBulto = item.Cells("P_COD_BULTO").Value
                oBulto.pNSEQIN_NrSecuencia = item.Cells("P_NSEQIN").Value
                oBulto.pNROPLT_NroPaletizado = item.Cells("P_IDPALETIZADO").Value
                lstTD_Bultos.Add(oBulto)
            Next

            RegistrarPreDespacho(lstTD_Bultos, "", pUsuario, sMessage, nroPreDespacho)

            If sMessage = "" Then
                pDialog = True
                Dim msg As String = "Proceso culminó satisfactoriamente." & vbNewLine & "Nro. Pre-Despacho : " & nroPreDespacho
                MessageBox.Show(msg, "Pre-Despacho:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Listar_Inventario()
                kdgvListPreDespacho.Rows.Clear()
            Else
                MessageBox.Show(sMessage, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

 
  
    Private Sub UcPaginacion1_PageChanged_1(sender As Object, e As EventArgs) Handles UcPaginacion1.PageChanged
        Try
            Listar_Inventario()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub kdgv_list_inventario_SelectionChanged(sender As Object, e As EventArgs) Handles kdgv_list_inventario.SelectionChanged
        Try
            Dim cod_tipo As String = ""
            cod_tipo = kdgv_list_inventario.CurrentRow.Cells("COD_TIPO").Value
            If cod_tipo = "PLT" Then
                Dim dt As New DataTable
                Dim oWayBill As New DAO.WayBill.cWayBill

                Dim pFiltro As New Ransa.TypeDef.WayBill.TD_Sel_Bulto_L01
                pFiltro.pCCLNT_CodigoCliente = pCCLNT
                pFiltro.pCCMPN_Compania = pCCMPN
                pFiltro.pCDVSN_Division = pCDVSN
                pFiltro.pCPLNDV_Planta = pCPLNDV
                pFiltro.pNROPLT_NroPaletizado = kdgv_list_inventario.CurrentRow.Cells("IDPALETIZADO").Value
                pFiltro.pNSEQIN_NrSecuencia = kdgv_list_inventario.CurrentRow.Cells("NSEQIN").Value
                dt = oWayBill.ListarBulto_X_paletizado(pFiltro)
                kdtgvDetalle.DataSource = dt
            Else
                kdtgvDetalle.DataSource = Nothing
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnQuitarTodo_Click(sender As Object, e As EventArgs) Handles btnQuitarTodo.Click
        Try
            If kdgvListPreDespacho.CurrentRow Is Nothing Then
                Exit Sub
            End If
            If MessageBox.Show("¿Está seguro de quitar todos los items?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                kdgvListPreDespacho.Rows.Clear()
                kdgvListPreDespacho.EndEdit()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
