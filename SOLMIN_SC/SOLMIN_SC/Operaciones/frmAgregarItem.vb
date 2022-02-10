Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Negocio

Public Class frmAgregarItem

    Private isCheck As Boolean = False

    Private _pCCLNT As Decimal
    Public Property pCCLNT() As Decimal
        Get
            Return _pCCLNT
        End Get
        Set(ByVal value As Decimal)
            _pCCLNT = value
        End Set
    End Property

    Private _pCCMPN As String
    Public Property pCCMPN() As String
        Get
            Return _pCCMPN
        End Get
        Set(ByVal value As String)
            _pCCMPN = value
        End Set
    End Property

    Private _pNORSCI As Decimal
    Public Property pNORSCI() As Decimal
        Get
            Return _pNORSCI
        End Get
        Set(ByVal value As Decimal)
            _pNORSCI = value
        End Set
    End Property


    Dim objBLL As clsDetOC

    Dim dtAgregarItem As DataTable

    Private Sub Inicializar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtEmbarque.Text = _pNORSCI
    End Sub

    Private Sub Buscar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Consulta_Item_Seguimiento_PreEmbarque()
    End Sub

    Sub Consulta_Item_Seguimiento_PreEmbarque()

        If txtOC.Text.ToString.Trim.Length < 3 Then
            MessageBox.Show("Debe ingresar como mínimo 3 caracteres", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        objBLL = New clsDetOC
        dtAgregarItem = New DataTable
        dtAgregarItem = objBLL.Consulta_Item_Seguimiento_PreEmbarque(txtOC.Text.Trim.ToUpper, _pCCLNT, _pCCMPN, _pNORSCI)
        dtgBusqueda.DataSource = dtAgregarItem
        btnCheck.Image = SOLMIN_SC.My.Resources.Resources.btnNoMarcarItems

    End Sub


    Private Sub txtOC_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOC.KeyUp
        If e.KeyValue = 13 Then
            Consulta_Item_Seguimiento_PreEmbarque()
        End If
    End Sub

    Private Sub Poner_Check_Todo(ByVal blnEstado As Boolean)
        Dim intCont As Integer
        For intCont = 0 To dtgBusqueda.RowCount - 1
            If dtgBusqueda.Rows(intCont).Cells("QRLCSC").Value > 0 Then
                dtgBusqueda.Rows(intCont).Cells("VALIDAR").Value = blnEstado
            End If

            If blnEstado = True Then
                btnCheck.Image = SOLMIN_SC.My.Resources.Resources.btnMarcarItems
            Else
                btnCheck.Image = SOLMIN_SC.My.Resources.Resources.btnNoMarcarItems
            End If

        Next intCont
    End Sub

    Private Sub dtgBusqueda_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgBusqueda.CellContentClick

        Dim intCont As Integer
        If e.RowIndex = -1 And dtgBusqueda.Columns(e.ColumnIndex).Name = "VALIDAR" Then
            Me.Cursor = Cursors.WaitCursor
            For intCont = 0 To Me.dtgBusqueda.Rows.Count - 1
                If Double.Parse(Me.dtgBusqueda.Rows(intCont).Cells("QRLCSC").Value.ToString.Trim) > 0 Then
                    dtgBusqueda.Rows(intCont).Cells("VALIDAR").Value = Not dtgBusqueda.Rows(intCont).Cells("VALIDAR").Value
                End If
            Next intCont
            Me.Cursor = Cursors.Default
        End If

    End Sub

    Private Function FilasSeleccionadas() As Int32
        dtgBusqueda.EndEdit()
        Dim NumSeleccionados As Int32 = 0
        Dim intCont As Int32 = 0, intRep = 0
        intRep = dtgBusqueda.Rows.Count
        For intCont = 0 To intRep - 1
            If dtgBusqueda.Rows(intCont).Cells("VALIDAR").Value = True Then
                NumSeleccionados = NumSeleccionados + 1
            End If
        Next
        Return NumSeleccionados
    End Function

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Dim NumSeleccionados As Int32 = 0
        dtgBusqueda.EndEdit()
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
        Try
            If FilasSeleccionadas() > 0 Then
                intRep = dtgBusqueda.Rows.Count
                NORSCI = _pNORSCI
                oPreEmbarque.Cliente = CDbl(_pCCLNT)
                For intCont = 0 To intRep - 1
                    If dtgBusqueda.Rows(intCont).Cells("VALIDAR").Value = True Then
                        oPreEmbarque.OC = dtgBusqueda.Rows(intCont).Cells("NORCML").Value.ToString.Trim
                        oPreEmbarque.Parcial = dtgBusqueda.Rows(intCont).Cells("NRPARC").Value
                        NRITOC = dtgBusqueda.Rows(intCont).Cells("NRITOC").Value
                        NRPEMB = dtgBusqueda.Rows(intCont).Cells("NRPEMB").Value
                        QRLCSC = dtgBusqueda.Rows(intCont).Cells("QRLCSC").Value
                        SBITOC = dtgBusqueda.Rows(intCont).Cells("SBITOC").Value.ToString.Trim
                        oPreEmbarque.Embarcar_PreEmbarque(NORSCI, NRITOC, NRPEMB, QRLCSC, SBITOC)
                    End If
                Next intCont
                Dim msg As String = String.Format("Los ítems seleccionados fueron adicionados al Embarque: {0}" & Chr(13) & "Debe distribuir los costos de los item nuevamente.", _pNORSCI)
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                MessageBox.Show("Para adicionar debe selecionar los item requeridos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
          
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
        End Try


    End Sub

    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click

        isCheck = Not isCheck
        Poner_Check_Todo(isCheck)
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class
