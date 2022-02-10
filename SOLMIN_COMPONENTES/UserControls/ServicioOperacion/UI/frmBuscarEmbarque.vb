Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Text
Public Class frmBuscarEmbarque


    Private _pCCLNT As Decimal
    Public Property pCCLNT() As Decimal
        Get
            Return _pCCLNT
        End Get
        Set(ByVal value As Decimal)
            _pCCLNT = value
        End Set
    End Property

    Private _pNOPRCN As Decimal
    Public Property pNOPRCN() As Decimal
        Get
            Return _pNOPRCN
        End Get
        Set(ByVal value As Decimal)
            _pNOPRCN = value
        End Set
    End Property


    Private _pDialogResult As Boolean = False
    Public Property pDialogResult() As Boolean
        Get
            Return _pDialogResult
        End Get
        Set(ByVal value As Boolean)
            _pDialogResult = value
        End Set
    End Property

    Private _NumServicios As Int32 = 0

    Private Sub frmBuscarEmbarque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim odtTipoBusqueda As New DataTable
            odtTipoBusqueda.Columns.Add("CODIGO")
            odtTipoBusqueda.Columns.Add("DESC")
            txtOperacion.Text = _pNOPRCN
            Dim dr As DataRow
            dr = odtTipoBusqueda.NewRow
            dr("CODIGO") = "E"
            dr("DESC") = "Embarque"
            odtTipoBusqueda.Rows.Add(dr)
            dr = odtTipoBusqueda.NewRow
            dr("CODIGO") = "O"
            dr("DESC") = "Orden Servicio"
            odtTipoBusqueda.Rows.Add(dr)

            cboBusqueda.ComboBox.DataSource = odtTipoBusqueda
            cboBusqueda.ComboBox.DisplayMember = "DESC"
            cboBusqueda.ComboBox.ValueMember = "CODIGO"

            Llenar_Embarques_x_Operacion(_pCCLNT, _pNOPRCN)

            Dim obrServicio As New clsServicioSC_BL
            Dim odtServicios As New DataTable
            Dim oParamServicio As New Servicio_BE
            oParamServicio.CCLNT = _pCCLNT
            oParamServicio.NOPRCN = _pNOPRCN
            oParamServicio.PNNORSCI = 0
            oParamServicio.PSBUSQUEDA = "OPERACION"
            odtServicios = obrServicio.Lista_Servicios_Operacion(oParamServicio)
            _NumServicios = odtServicios.Rows.Count

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     
    End Sub

    Private Function IsPosibleAdicionarEmbarque() As Boolean
        Dim CantidadServicios As Int32 = 0
        Dim CantidadEmbarques As Int32 = 0
        Dim ValidarAsignacion As Boolean = False
        CantidadServicios = _NumServicios
        CantidadEmbarques = dtgEmbarque.Rows.Count
        If (CantidadEmbarques = 0 OrElse CantidadServicios = 0 OrElse CantidadServicios = 1) Then
            ValidarAsignacion = True
        End If
        Return ValidarAsignacion
    End Function

    Private Sub Llenar_Embarques_x_Operacion(ByVal CCLNT As Decimal, ByVal NOPRCN As Decimal)
        dtgEmbarque.Rows.Clear()
        Dim oDt As New DataTable
        Dim obeServicio As New Servicio_BE
        obeServicio.CCLNT = CCLNT
        obeServicio.NOPRCN = NOPRCN
        Dim obrclsServicioSC_BL As New clsServicioSC_BL
        Dim odtServicioSC As New DataTable
        oDt = obrclsServicioSC_BL.Lista_Detalle_Servicios_SC(obeServicio)
        Dim oDrVw As DataGridViewRow
        Dim pos As Integer
        For i As Integer = 0 To oDt.Rows.Count - 1
            oDrVw = New DataGridViewRow
            oDrVw.CreateCells(Me.dtgEmbarque)
            Me.dtgEmbarque.Rows.Add(oDrVw)
            With Me.dtgEmbarque
                pos = i
                .Rows(pos).Cells("NORSCI").Value = oDt.Rows(i).Item("NORSCI").ToString.Trim
                .Rows(pos).Cells("NRITEM").Value = oDt.Rows(i).Item("NRITEM")
                .Rows(pos).Cells("ETD").Value = oDt.Rows(i).Item("ETD").ToString.Trim
                .Rows(pos).Cells("ETA").Value = oDt.Rows(i).Item("ETA").ToString.Trim
                .Rows(pos).Cells("AT").Value = oDt.Rows(i).Item("ATD").ToString.Trim
                .Rows(pos).Cells("FOB").Value = oDt.Rows(i).Item("FOB")
                .Rows(pos).Cells("FLETE").Value = oDt.Rows(i).Item("FLETE").ToString.Trim
                .Rows(pos).Cells("SEGURO").Value = oDt.Rows(i).Item("SEGURO")
                .Rows(pos).Cells("CIF").Value = oDt.Rows(i).Item("CIF").ToString.Trim
                .Rows(pos).Cells("FLAG_REGISTRO").Value = oDt.Rows(i).Item("FLAG_REGISTRO")
                .Rows(pos).Cells("ESTADO").Value = oDt.Rows(i).Item("ESTADO").ToString

                .Rows(pos).Cells("PNNMOS").Value = oDt.Rows(i).Item("PNNMOS")
                .Rows(pos).Cells("TPRVCL").Value = oDt.Rows(i).Item("TPRVCL")
                .Rows(pos).Cells("TDITES").Value = oDt.Rows(i).Item("TDITES").ToString.Trim
                .Rows(pos).Cells("NDOCEM").Value = oDt.Rows(i).Item("NDOCEM")
                .Rows(pos).Cells("CMEDTR").Value = oDt.Rows(i).Item("CMEDTR")
                .Rows(pos).Cells("TCANAL").Value = oDt.Rows(i).Item("TCANAL")
                .Rows(pos).Cells("TNMAGC").Value = oDt.Rows(i).Item("TNMAGC")
                .Rows(pos).Cells("REGIMEN").Value = oDt.Rows(i).Item("REGIMEN")
                .Rows(pos).Cells("DESPACHO").Value = oDt.Rows(i).Item("DESPACHO")
                .Rows(pos).Cells("TNRODU").Value = oDt.Rows(i).Item("TNRODU")

                .Rows(pos).Cells("FOB").Value = oDt.Rows(i).Item("FOB")
                .Rows(pos).Cells("FLETE").Value = oDt.Rows(i).Item("FLETE")
                .Rows(pos).Cells("SEGURO").Value = oDt.Rows(i).Item("SEGURO")
                .Rows(pos).Cells("CIF").Value = oDt.Rows(i).Item("CIF")
            End With
        Next
    End Sub
    Private Sub btnAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click
        Try
            txtBusqueda.Focus()
            Dim numEmbarque As Decimal = 0
            Dim msgValidacionEmbarque As String = ""
            Dim TipoBusqueda As String = ""
            Dim boolValidacion As Boolean = False
            Dim msgValidacion As New StringBuilder

            If (IsPosibleAdicionarEmbarque() = False) Then
                msgValidacion.Append("No puede adicionar más servicios.Tener en cuenta:")
                msgValidacion.AppendLine()
                msgValidacion.Append("Varios servicios deben ser asignados como máximo a un Embarque o")
                msgValidacion.AppendLine()
                msgValidacion.Append("Varios Embarques deben ser asignados a un Servicio.")
                MessageBox.Show(msgValidacion.ToString.Trim, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If (Not Decimal.TryParse(txtBusqueda.Text.Trim, numEmbarque)) Then
                MessageBox.Show("Ingrese " & cboBusqueda.ComboBox.Text.Trim, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim obrclsServicioSC_BL As New clsServicioSC_BL
            Dim oDrVw As DataGridViewRow
            Dim oDt As DataTable
            Dim dblEmbarque As Double = 0
            Dim intCont, intRow As Integer
            Dim pos As Integer
            Dim obeServicios As New Servicio_BE
            obeServicios.CCLNT = _pCCLNT
            TipoBusqueda = cboBusqueda.ComboBox.SelectedValue
            Select Case TipoBusqueda
                Case "E" 'X EMBARQUE
                    obeServicios.NORSCI = Convert.ToDecimal(txtBusqueda.Text.Trim)
                Case "O" ' X ORDEN SERVICIO
                    obeServicios.PNNMOS = Convert.ToDecimal(txtBusqueda.Text.Trim)
            End Select
            obeServicios.PSBUSQUEDA = TipoBusqueda
            'msgValidacionEmbarque = obrclsServicioSC_BL.ValidaIngresoEmbarqueAOperacion(obeServicios.CCLNT, obeServicios.NORSCI, obeServicios.PNNMOS, obeServicios.PSBUSQUEDA)

            If (msgValidacionEmbarque.Length <> 0) Then
                MessageBox.Show(msgValidacionEmbarque, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            oDt = obrclsServicioSC_BL.Lista_OC_X_Embarque_OS(obeServicios)

            With oDt
                If oDt.Rows.Count > 0 Then
                    For intRow = 0 To dtgEmbarque.Rows.Count - 1
                        For intCont = .Rows.Count - 1 To 0 Step -1
                            If (dtgEmbarque.Rows(intRow).Cells("NORSCI").Value.ToString.Trim = .Rows(intCont).Item("NORSCI").ToString.Trim) Then
                                oDt.Rows.RemoveAt(intCont)
                            End If
                        Next intCont
                    Next
                End If
            End With

            If oDt.Rows.Count > 0 Then
                For intCont = 0 To oDt.Rows.Count - 1
                    oDrVw = New DataGridViewRow
                    oDrVw.CreateCells(Me.dtgEmbarque)
                    oDrVw.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192)
                    dtgEmbarque.Rows.Add(oDrVw)
                    pos = dtgEmbarque.Rows.Count - 1
                    With dtgEmbarque
                        .Rows(pos).Cells("NORSCI").Value = oDt.Rows(intCont).Item("NORSCI")
                        .Rows(pos).Cells("ETD").Value = oDt.Rows(intCont).Item("ETD").ToString.Trim
                        .Rows(pos).Cells("ETA").Value = oDt.Rows(intCont).Item("ETA").ToString.Trim
                        .Rows(pos).Cells("AT").Value = oDt.Rows(intCont).Item("ATD").ToString.Trim
                        .Rows(pos).Cells("ESTADO").Value = oDt.Rows(intCont).Item("ESTADO").ToString
                        .Rows(pos).Cells("PNNMOS").Value = oDt.Rows(intCont).Item("PNNMOS")
                        .Rows(pos).Cells("TPRVCL").Value = oDt.Rows(intCont).Item("TPRVCL")
                        .Rows(pos).Cells("TDITES").Value = oDt.Rows(intCont).Item("TDITES")
                        .Rows(pos).Cells("NDOCEM").Value = oDt.Rows(intCont).Item("NDOCEM")
                        .Rows(pos).Cells("CMEDTR").Value = oDt.Rows(intCont).Item("CMEDTR")
                        .Rows(pos).Cells("TCANAL").Value = oDt.Rows(intCont).Item("TCANAL")
                        .Rows(pos).Cells("TNMAGC").Value = oDt.Rows(intCont).Item("TNMAGC")
                        .Rows(pos).Cells("REGIMEN").Value = oDt.Rows(intCont).Item("REGIMEN")
                        .Rows(pos).Cells("DESPACHO").Value = oDt.Rows(intCont).Item("DESPACHO")
                        .Rows(pos).Cells("TNRODU").Value = oDt.Rows(intCont).Item("TRANSPORTE")
                        .Rows(pos).Cells("FOB").Value = oDt.Rows(intCont).Item("FOB")
                        .Rows(pos).Cells("FLETE").Value = oDt.Rows(intCont).Item("FLETE")
                        .Rows(pos).Cells("SEGURO").Value = oDt.Rows(intCont).Item("SEGURO")
                        .Rows(pos).Cells("CIF").Value = oDt.Rows(intCont).Item("CIF")
                    End With
                Next
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function ValidarItemDetalleOperacion() As String
        Dim msg As String = ""
        If (dtgEmbarque.Rows.Count = 0) Then
            msg = "Debe ingresar Embarque."
        End If
        Return msg
    End Function
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Dim msgValidacion As String = ""
        Dim retorno As Int32 = 0
        Try
            msgValidacion = ValidarItemDetalleOperacion()
            If (msgValidacion.Length <> 0) Then
                MessageBox.Show(msgValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim obrServicio As New clsServicioSC_BL
            Dim oServicioDetalleEmbarque As Servicio_BE
            Dim oListServicioDetalleEmbarque As New List(Of Servicio_BE)
            For Fila As Int32 = 0 To Me.dtgEmbarque.Rows.Count - 1
                oServicioDetalleEmbarque = New Servicio_BE
                oServicioDetalleEmbarque.NOPRCN = _pNOPRCN
                oServicioDetalleEmbarque.CCLNT = _pCCLNT
                oServicioDetalleEmbarque.NORSCI = dtgEmbarque.Rows(Fila).Cells("NORSCI").Value
                oServicioDetalleEmbarque.PSUSUARIO = ConfigurationWizard.UserName
                oListServicioDetalleEmbarque.Add(oServicioDetalleEmbarque)
            Next
            retorno = obrServicio.Insertar_Servicio_Facturar_Embarques(oListServicioDetalleEmbarque)
            MessageBox.Show("Se actualizado los embarque con número operación:" & _pNOPRCN, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            _pDialogResult = True
            DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        Try
            Dim msgInformativo As String = ""
            Dim PNNORSCI As Decimal = 0
            Dim PNNRITEM As Decimal = 0
            Dim obrclsServicioSC_BL As New clsServicioSC_BL
            Dim retorno As Int32 = 0
            Dim PNFLAG_REGISTRO As Int32 = 0
            If (dtgEmbarque.CurrentRow IsNot Nothing) Then
                PNFLAG_REGISTRO = dtgEmbarque.CurrentRow.Cells("FLAG_REGISTRO").Value
                PNNORSCI = dtgEmbarque.CurrentRow.Cells("NORSCI").Value
                PNNRITEM = dtgEmbarque.CurrentRow.Cells("NRITEM").Value
                If (PNFLAG_REGISTRO = 1) Then
                    msgInformativo = String.Format("Está seguro de eliminar el embarque {0} asociado a la operación", PNNORSCI)
                    If (MessageBox.Show(msgInformativo, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                        Dim oEmbarqueServicio As New Servicio_BE
                        oEmbarqueServicio.CCLNT = pCCLNT
                        oEmbarqueServicio.NOPRCN = pNOPRCN
                        oEmbarqueServicio.NORSCI = PNNORSCI
                        oEmbarqueServicio.PSUSUARIO = ConfigurationWizard.UserName
                        oEmbarqueServicio.NRITEM = PNNRITEM
                        retorno = obrclsServicioSC_BL.Eliminar_Item_Embarque_Servicio_SC(oEmbarqueServicio)
                        If (retorno = 1) Then
                            _pDialogResult = True
                            dtgEmbarque.Rows.RemoveAt(dtgEmbarque.CurrentRow.Index)
                        End If
                    End If
                Else
                    dtgEmbarque.Rows.RemoveAt(dtgEmbarque.CurrentRow.Index)
                End If
            End If
        Catch ex As Exception

        End Try
     
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

End Class
