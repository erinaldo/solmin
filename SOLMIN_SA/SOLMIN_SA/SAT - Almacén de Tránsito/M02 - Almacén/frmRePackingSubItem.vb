Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.DAO.OrdenCompra
Imports Ransa.TypeDef.OrdenCompra.ItemOC
Imports Ransa.Rutime.CtrlsSolmin
Imports Ransa.TypeDef.OrdenCompra.SubItemOC
Imports System.Collections.Generic
Imports System.Collections.Specialized

Public Class frmRePackingSubItem

#Region "Propiedades"
    Private _Items As RANSA.TYPEDEF.OrdenCompra.ItemOC.TD_ItemOCPK
    Private _pDt As DataTable
    Public Property Items() As Ransa.TYPEDEF.OrdenCompra.ItemOC.TD_ItemOCPK
        Get
            Return _Items
        End Get
        Set(ByVal value As Ransa.TYPEDEF.OrdenCompra.ItemOC.TD_ItemOCPK)
            _Items = value
        End Set
    End Property
    Public Property pDt() As DataTable
        Get
            Return _pDt
        End Get
        Set(ByVal value As DataTable)
            _pDt = value
        End Set
    End Property
#End Region

    ' Manejador de la Conexion
    '-------------------------------------------------
    Private objSqlManager As SqlManager
    '-------------------------------------------------
    Private TD_ItemOC_Actual As TD_ItemOCPK = New Ransa.TYPEDEF.OrdenCompra.ItemOC.TD_ItemOCPK
    Private intFilaActual As Int32 = 0
    Private strMensajeError As String = ""


    Private Sub frmSubItemEnAlmacen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If pDt Is Nothing Then
            pDt = fndt()
        End If
        pActualizar(_Items)
    End Sub

    Public Sub pActualizar(ByVal Items As TD_ItemOCPK)
        TD_ItemOC_Actual.pCCLNT_CodigoCliente = Items.pCCLNT_CodigoCliente
        TD_ItemOC_Actual.pCREFFW_FrdForw = Items.pCREFFW_FrdForw
        TD_ItemOC_Actual.pCIDPAQ_CodIndentificacionPaquete = Items.pCIDPAQ_CodIndentificacionPaquete
        TD_ItemOC_Actual.pNORCML_NroOrdenCompra = Items.pNORCML_NroOrdenCompra
        TD_ItemOC_Actual.pNRITOC_NroItemOC = Items.pNRITOC_NroItemOC
        TD_ItemOC_Actual.pCCMPN_Compania = Items.pCCMPN_Compania
        TD_ItemOC_Actual.pCDVSN_Division = Items.pCDVSN_Division
        TD_ItemOC_Actual.pCPLNDV_Planta = Items.pCPLNDV_Planta
        ' Llamada al procedimiento de carga de información
        pCargarInformacion()
    End Sub

    Private Function fndt() As DataTable
        Dim dt As New DataTable
        dt.Columns.Add("CCLNT") 'oculto
        dt.Columns.Add("CREFFW") 'oculto
        dt.Columns.Add("CIDPAQ") 'Cód. Paquete
        dt.Columns.Add("NORCML") 'oculto
        dt.Columns.Add("NRITOC") 'Item
        dt.Columns.Add("SBITOC") 'SubItem

        dt.Columns.Add("TDITES") 'Descripcion
        dt.Columns.Add("QCNRCP", Type.GetType("System.Decimal")) 'Cant. en Bulto
        dt.Columns.Add("QREPAC", Type.GetType("System.Decimal")) 'Cant. RePacking

        Dim keys(5) As DataColumn
        keys(0) = dt.Columns("CCLNT")
        keys(1) = dt.Columns("CREFFW")
        keys(2) = dt.Columns("CIDPAQ")
        keys(3) = dt.Columns("NORCML")
        keys(4) = dt.Columns("NRITOC")
        keys(5) = dt.Columns("SBITOC")
        dt.PrimaryKey = keys
        Return dt
    End Function

    Private Sub pCargarInformacion()
        Try
            ' Iniciamos la carga de la información
            If TD_ItemOC_Actual.pCCLNT_CodigoCliente <> 0 Then
                strMensajeError = ""
                objSqlManager = New SqlManager()
                Dim dt As DataTable = CSubItemOrdenCompra.fdtListar_Bulto_SubItemsOC_L01(objSqlManager, TD_ItemOC_Actual, strMensajeError)
                Dim dtSubItem As DataTable = fndt()

                For Each row As DataRow In dt.Rows
                    Dim dr As DataRow = dtSubItem.NewRow
                    dr("CCLNT") = row("CCLNT").ToString() 'oculto
                    dr("CREFFW") = row("CREFFW").ToString() 'oculto
                    dr("CIDPAQ") = row("CIDPAQ").ToString() 'Cód. Paquete
                    dr("NORCML") = row("NORCML").ToString() 'Cód. Paquete
                    dr("NRITOC") = row("NRITOC").ToString() 'Item
                    dr("SBITOC") = row("SBITOC").ToString() 'SubItem

                    dr("TDITES") = row("TDITES").ToString() 'Descripcion
                    dr("QCNRCP") = row("QCNRCP").ToString() 'Cant. en Bulto

                    Dim keys(5) As Object
                    keys(0) = row("CCLNT").ToString() 'oculto
                    keys(1) = row("CREFFW").ToString() 'oculto
                    keys(2) = row("CIDPAQ").ToString() 'Cód. Paquete
                    keys(3) = row("NORCML").ToString() 'Cód. Paquete
                    keys(4) = row("NRITOC").ToString() 'Item
                    keys(5) = row("SBITOC").ToString() 'SubItem
                    Dim pDr2 As DataRow = pDt.Rows.Find(keys)
                    If pDr2 IsNot Nothing Then
                        dr("QREPAC") = pDr2("QREPAC").ToString
                    Else
                        dr("QREPAC") = "0" 'Re-Packing

                        Dim pDr As DataRow = pDt.NewRow
                        pDr("CCLNT") = row("CCLNT").ToString() 'oculto
                        pDr("CREFFW") = row("CREFFW").ToString() 'oculto
                        pDr("CIDPAQ") = row("CIDPAQ").ToString() 'Cód. Paquete
                        pDr("NORCML") = row("NORCML").ToString() 'Cód. Paquete
                        pDr("NRITOC") = row("NRITOC").ToString() 'Item
                        pDr("SBITOC") = row("SBITOC").ToString() 'SubItem

                        pDr("TDITES") = row("TDITES").ToString() 'Descripcion
                        pDr("QCNRCP") = row("QCNRCP").ToString() 'Cant. en Bulto
                        pDr("QREPAC") = "0" 'Re-Packing
                        pDt.Rows.Add(pDr)
                    End If
                    dtSubItem.Rows.Add(dr)
                Next
                Me.dgSubItemOC.DataSource = dtSubItem
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub dgSubItemOC_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgSubItemOC.CellEndEdit
        With dgSubItemOC
            If .Columns(e.ColumnIndex).Name = "QREPAC" Then
                If .CurrentRow.Cells("QREPAC").Value > .CurrentRow.Cells("QCNRCP").Value Or .CurrentRow.Cells("QREPAC").Value < 0 Then
                    MessageBox.Show("No puede recibir una cantidad mayor al Saldo o menor a Cero.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    .CurrentRow.Cells("QREPAC").Value = .CurrentRow.Cells("QCNRCP").Value
                Else
                    Dim keys(5) As Object
                    keys(0) = .CurrentRow.Cells("CCLNT").Value 'oculto
                    keys(1) = .CurrentRow.Cells("CREFFW").Value 'oculto
                    keys(2) = .CurrentRow.Cells("CIDPAQ").Value 'Cód. Paquete
                    keys(3) = .CurrentRow.Cells("NORCML").Value 'Cód. Paquete
                    keys(4) = .CurrentRow.Cells("NRITOC").Value 'Item
                    keys(5) = .CurrentRow.Cells("SBITOC").Value 'SubItem
                    Dim pDr2 As DataRow = pDt.Rows.Find(keys)
                    If pDr2 IsNot Nothing Then
                        pDr2("QREPAC") = .CurrentRow.Cells("QREPAC").Value
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.Close()
    End Sub
End Class
