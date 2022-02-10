Imports RANSA.NEGO.brBulto
Imports System.Text
Imports System.ComponentModel
Public Class frmObservacionItemOC

    <Browsable(True)> _
    Public Property VisualizarbtnActualizar() As Boolean
        Get
            Return btnActualizar.Visible
        End Get
        Set(ByVal value As Boolean)
            btnActualizar.Visible = value
            Me.txtObservaciones.ReadOnly = Not value
        End Set
    End Property

    Public oItemOC As New RANSA.TYPEDEF.OrdenCompra.ItemOC.TD_ItemOCPK
    Public Sub New(ByVal obeItemOC As RANSA.TYPEDEF.OrdenCompra.ItemOC.TD_ItemOCPK)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        oItemOC = obeItemOC
    End Sub

    Private Sub frmObservacionItemOC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim obrBulto As New RANSA.NEGO.brBulto
        Dim dtItemOC As New DataTable
        Dim filtro As New Hashtable
        filtro.Add("CCMPN", oItemOC.pCCMPN_Compania)
        filtro.Add("CDVSN", oItemOC.pCDVSN_Division)
        filtro.Add("CPLNDV", oItemOC.pCPLNDV_Planta)
        filtro.Add("CCLNT", oItemOC.pCCLNT_CodigoCliente)
        filtro.Add("CREFFW", oItemOC.pCREFFW_FrdForw.Trim)
        filtro.Add("NORCML", oItemOC.pNORCML_NroOrdenCompra.Trim)
        filtro.Add("NRITOC", oItemOC.pNRITOC_NroItemOC)
        dtItemOC = obrBulto.cargaObservacionesItemOC(filtro)
        If dtItemOC.Rows.Count > 0 Then
            For i As Integer = 0 To dtItemOC.Rows.Count - 1
                txtObservaciones.Text = txtObservaciones.Text & dtItemOC.Rows(i).Item("TDAITM").ToString.TrimEnd
                txtObservaciones.Text = txtObservaciones.Text.TrimStart
            Next
        End If
    End Sub



    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Dim retorno As Int32 = 0
        Dim obrBulto As New RANSA.NEGO.brBulto
        Dim filtro As New Hashtable
        Try
            filtro("CCMPN") = oItemOC.pCCMPN_Compania
            filtro("CDVSN") = oItemOC.pCDVSN_Division
            filtro("CPLNDV") = oItemOC.pCPLNDV_Planta
            filtro("CCLNT") = oItemOC.pCCLNT_CodigoCliente
            filtro("CREFFW") = oItemOC.pCREFFW_FrdForw.Trim
            filtro("NORCML") = oItemOC.pNORCML_NroOrdenCompra.Trim
            filtro("NRITOC") = oItemOC.pNRITOC_NroItemOC
            filtro("CULUSA") = objSeguridadBN.pUsuario
            filtro("TDAITM") = txtObservaciones.Text.Trim
            retorno = obrBulto.ActualizaObservacionesItemOC(filtro)
            If (retorno = 1) Then
                MessageBox.Show("La registro fue actualizado.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("La registro no pudo ser actualizado.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Ocurrió un error.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub frmObservacionItemOC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class
