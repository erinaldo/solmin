Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Negocio

Public Class frmEmbarcarPreEmbarque
    Private _pCCLNT As Decimal = 0
    Public Property pCCLNT() As Decimal
        Get
            Return _pCCLNT
        End Get
        Set(ByVal value As Decimal)
            _pCCLNT = value
        End Set
    End Property
    Private _pTCMPL As String = ""
    Public Property pTCMPL() As String
        Get
            Return _pTCMPL
        End Get
        Set(ByVal value As String)
            _pTCMPL = value
        End Set
    End Property

    Private _pListOrdPreEmbarcada As New List(Of beOrdenPreEmbarcadaFiltro)

    Private _pCCMPN As String = ""
    Private _pCCMPN_DESC As String = ""
    Private _pCDVSN As String = ""
    Private _pNCPLNDV As Decimal = 0

    Public Property pCCMPN() As String
        Get
            Return _pCCMPN
        End Get
        Set(ByVal value As String)
            _pCCMPN = value
        End Set
    End Property
    Public Property pCDVSN() As String
        Get
            Return _pCDVSN
        End Get
        Set(ByVal value As String)
            _pCDVSN = value
        End Set
    End Property

    Public Property pCCMPN_DESC() As String
        Get
            Return _pCCMPN_DESC
        End Get
        Set(ByVal value As String)
            _pCCMPN_DESC = value
        End Set
    End Property


    Public Property PNCPLNDV() As Decimal
        Get
            Return _pNCPLNDV
        End Get
        Set(ByVal value As Decimal)
            _pNCPLNDV = value
        End Set
    End Property

    Public Property pListOrdPreEmbarcada() As List(Of beOrdenPreEmbarcadaFiltro)
        Get
            Return _pListOrdPreEmbarcada
        End Get
        Set(ByVal value As List(Of beOrdenPreEmbarcadaFiltro))
            _pListOrdPreEmbarcada = value
        End Set
    End Property


    Private Sub btnEmbarcar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmbarcar.Click
        kgvItemOC.EndEdit()
        Dim oPreEmbarque As New clsPreEmbarque
        Dim oclsEmbarque As New clsEmbarque
        Dim NORSCI As Decimal = 0
        Dim NRITOC As Decimal = 0
        Dim NRPEMB As Decimal = 0
        Dim QRLCSC As Decimal = 0
        Dim SBITOC As String = ""
        Dim intCont, intRep As Integer
        Dim oFiltroEmbarcar As New SOLMIN_SC.Entidad.OrdenCompra_BE
        oFiltroEmbarcar.PNCCLNT = _pCCLNT
        Dim msg As String = ""
        Try
            Dim QIVUNIT As Decimal = 0
            Dim QQRLCSC As Decimal = 0
            Dim ValidarQEmbarcar As Boolean = True
            Dim ValidarPUnitario As Boolean = True
            intRep = kgvItemOC.Rows.Count
            oPreEmbarque.Cliente = _pCCLNT
            For intCont = 0 To intRep - 1
                If kgvItemOC.Rows(intCont).Cells("CHK_ITEM_SEL").Value = True Then
                    QQRLCSC = kgvItemOC.Rows(intCont).Cells("COLQRLCSC").Value
                    QIVUNIT = kgvItemOC.Rows(intCont).Cells("IVUNIT").Value
                    If QQRLCSC = 0 Then
                        ValidarQEmbarcar = False
                    End If
                    If QIVUNIT = 0 Then
                        ValidarPUnitario = False
                    End If
                End If
            Next
            If ValidarQEmbarcar = False Then
                msg = "Existen items con cantidad cero."
            End If
            If ValidarPUnitario = False Then
                msg = msg & Chr(13) & "Existen items con precio unitario cero."
            End If
            msg = msg.Trim
            If msg.Length > 0 Then
                msg = msg & Chr(13) & "Esto afectará la posterior distribución de costeo de orden de compra."
                msg = msg & Chr(13) & "Desea embarcar de todas maneras?"
                If MessageBox.Show(msg, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If
            End If
            NORSCI = Double.Parse(oPreEmbarque.Crear_Embarque(_pCCMPN, pCDVSN, "IM", PNCPLNDV).Rows(0).Item("NORSCI").ToString)
            Try
                If (ctbAgenteDeCarga.NoHayCodigo = False) Then
                    oclsEmbarque.Actualiza_Agente_Carga(NORSCI, ctbAgenteDeCarga.Codigo)
                End If
            Catch ex As Exception
            End Try
            For intCont = 0 To intRep - 1
                If kgvItemOC.Rows(intCont).Cells("CHK_ITEM_SEL").Value = True Then
                    oPreEmbarque.OC = kgvItemOC.Rows(intCont).Cells("COLNORCML").Value.ToString.Trim
                    oPreEmbarque.Parcial = kgvItemOC.Rows(intCont).Cells("COLNRPARC").Value
                    NRITOC = kgvItemOC.Rows(intCont).Cells("COLNRITOC").Value
                    NRPEMB = kgvItemOC.Rows(intCont).Cells("COLNRPEMB").Value
                    QRLCSC = kgvItemOC.Rows(intCont).Cells("COLQRLCSC").Value
                    SBITOC = kgvItemOC.Rows(intCont).Cells("COLSBITOC").Value.ToString.Trim
                    oPreEmbarque.Embarcar_PreEmbarque(NORSCI, NRITOC, NRPEMB, QRLCSC, SBITOC)
                End If
            Next
            msg = String.Format("Los ítems seleccionados fueron embarcados correctamente con Nro de Embarque:{0}", NORSCI)
            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
        End Try
    End Sub

    Private Sub frmEmbarcarPreEmbarque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCliente.Text = _pTCMPL.Trim
        kgvItemOC.AutoGenerateColumns = False
        CargarAgenteCarga()
        Dim obrclsPreEmbarque As New clsPreEmbarque
        Dim odtOrdenPreEmbarcada As New DataTable
        Try
            odtOrdenPreEmbarcada = obrclsPreEmbarque.ListarItemsXOrdenCompra_ParcialVarios(_pListOrdPreEmbarcada)
            kgvItemOC.DataSource = odtOrdenPreEmbarcada
            For Each Item As DataGridViewRow In kgvItemOC.Rows
                Item.Cells("CHK_ITEM_SEL").Value = True
            Next
            MostrarDatosAdicionalesPreEmbarque()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        lblCompania.Text = _pCCMPN & " - " & _pCCMPN_DESC
    End Sub

    Private Sub CargarAgenteCarga()
        Dim oAgenteCarga As New clsAgenteCarga
        oAgenteCarga.Crea_Lista()
        Dim odtAgenteCarga As New DataTable
        odtAgenteCarga = oAgenteCarga.Lista
        ctbAgenteDeCarga.DataSource = odtAgenteCarga
        ctbAgenteDeCarga.DisplayMember = "TNMAGC"
        ctbAgenteDeCarga.ValueMember = "CAGNCR"
        Me.ctbAgenteDeCarga.DataBind()


      
    End Sub


    Private Sub MostrarDatosAdicionalesPreEmbarque()
        lbAgenteCarga.Items.Clear()
        Dim oListAgentes As New List(Of String)
        Dim PNCAGNC As Decimal = 0
        For Each Item As DataGridViewRow In kgvItemOC.Rows
            PNCAGNC = Item.Cells("COLCAGNCR").Value
            If (PNCAGNC <> 0) Then
                If (Not oListAgentes.Contains(PNCAGNC)) Then
                    oListAgentes.Add(PNCAGNC)
                    lbAgenteCarga.Items.Add(PNCAGNC & "-" & Item.Cells("COLTNMAGC").Value)
                End If
            End If
        Next
        If oListAgentes.Count = 1 Then
            ctbAgenteDeCarga.Codigo = oListAgentes(0)
        Else
            ctbAgenteDeCarga.Limpiar()
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub lbAgenteCarga_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbAgenteCarga.SelectedIndexChanged
        Try
            If (lbAgenteCarga.Items.Count > 0) Then
                Dim Index As Int32 = 0
                Dim Item As String = lbAgenteCarga.Items.Item(lbAgenteCarga.SelectedIndex).ToString.Trim
                Index = Item.IndexOf("-")
                Dim PNCAGNC As Decimal = Item.Substring(0, Index)
                ctbAgenteDeCarga.Codigo = PNCAGNC.ToString
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

   
End Class
