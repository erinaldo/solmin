Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Negocio
Public Class frmDetalleCostos
    Enum TipoSuma
        ImporteTotalDolar
        ImporteTotalSoles
        ImporteBaseDolar
        ImporteBaseSoles
    End Enum
    Private _pNORDSR As Decimal = 0
    Public Property pNORDSR() As Decimal
        Get
            Return _pNORDSR
        End Get
        Set(ByVal value As Decimal)
            _pNORDSR = value
        End Set
    End Property
    Private _pCODVAR As String = ""
    Public Property pCODVAR() As String
        Get
            Return _pCODVAR
        End Get
        Set(ByVal value As String)
            _pCODVAR = value
        End Set
    End Property
    Private _pListaCostoAgencias As New List(Of beCostoAgencia)
    Public Property pListaCostoAgencias() As List(Of beCostoAgencia)
        Get
            Return _pListaCostoAgencias
        End Get
        Set(ByVal value As List(Of beCostoAgencia))
            _pListaCostoAgencias = value
        End Set
    End Property
    Private _pListaCostosSeleccionados As New List(Of String)
    Public ReadOnly Property pListaCostosSeleccionados() As List(Of String)
        Get
            Return _pListaCostosSeleccionados
        End Get
    End Property

    Private Sub frmDetalleCostos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            kgvDetalleCostos.AutoGenerateColumns = False
            Dim PSCSRVRL As String = ""
            kgvDetalleCostos.Rows.Clear()
            txtOrdenServicio.Text = _pNORDSR
            Dim FILA As Int32 = 0
            Dim oDrVw As DataGridViewRow
            Dim pos As Integer = 0
            For pos = 0 To _pListaCostoAgencias.Count - 1
                If (_pListaCostoAgencias(pos).PSVARCOSTO = pCODVAR) Then
                    oDrVw = New DataGridViewRow
                    oDrVw.CreateCells(Me.kgvDetalleCostos)
                    Me.kgvDetalleCostos.Rows.Add(oDrVw)
                    FILA = kgvDetalleCostos.Rows.Count - 1
                    PSCSRVRL = _pListaCostoAgencias(pos).PNCSRVRL
                    kgvDetalleCostos.Rows(FILA).Cells("CSRVRL").Value = PSCSRVRL
                    kgvDetalleCostos.Rows(FILA).Cells("TCMTRF").Value = _pListaCostoAgencias(pos).PSTCMTRF
                    'kgvDetalleCostos.Rows(FILA).Cells("MONTO_DOL").Value = _pListaCostoAgencias(pos).PNIMPORTE_TOTAL_DOL
                    'kgvDetalleCostos.Rows(FILA).Cells("MONTO_SOL").Value = _pListaCostoAgencias(pos).PNIMPORTE_TOTAL_SOL
                    kgvDetalleCostos.Rows(FILA).Cells("MONTO_DOL").Value = _pListaCostoAgencias(pos).PNIMPORTE_BASE_DOL
                    kgvDetalleCostos.Rows(FILA).Cells("MONTO_SOL").Value = _pListaCostoAgencias(pos).PNIMPORTE_BASE_SOL
                    kgvDetalleCostos.Rows(FILA).Cells("PIGVA").Value = _pListaCostoAgencias(pos).PNIGV
                    kgvDetalleCostos.Rows(FILA).Cells("PIGVA_DOL").Value = _pListaCostoAgencias(pos).PNIMPORTE_IGV_DOL
                    kgvDetalleCostos.Rows(FILA).Cells("PIGVA_SOL").Value = _pListaCostoAgencias(pos).PNIMPORTE_IGV_SOL
                    'kgvDetalleCostos.Rows(FILA).Cells("MONTO_DOL_FINAL").Value = _pListaCostoAgencias(pos).PNIMPORTE_BASE_DOL
                    kgvDetalleCostos.Rows(FILA).Cells("MONTO_DOL_FINAL").Value = _pListaCostoAgencias(pos).PNIMPORTE_TOTAL_DOL
                    kgvDetalleCostos.Rows(FILA).Cells("CHKCOSTO").Value = _pListaCostoAgencias(pos).PBSELECCIONADO
                    kgvDetalleCostos.Rows(FILA).Cells("IMTPOC").Value = _pListaCostoAgencias(pos).PNIMTPOC
                    kgvDetalleCostos.Rows(FILA).Cells("TCMTPD").Value = _pListaCostoAgencias(pos).PSTCMTPD
                    kgvDetalleCostos.Rows(FILA).Cells("NUMDOC").Value = _pListaCostoAgencias(pos).PNNUMDOC
                    kgvDetalleCostos.Rows(FILA).Cells("TIPODOC").Value = _pListaCostoAgencias(pos).PNTIPODOC
                    kgvDetalleCostos.Rows(FILA).Cells("IDUNICO").Value = _pListaCostoAgencias(pos).PSIDUNICO
                    'kgvDetalleCostos.Rows(FILA).Cells("MONTO_SOL_FINAL").Value = _pListaCostoAgencias(pos).PNIMPORTE_BASE_SOL
                    kgvDetalleCostos.Rows(FILA).Cells("MONTO_SOL_FINAL").Value = _pListaCostoAgencias(pos).PNIMPORTE_TOTAL_SOL
                    kgvDetalleCostos.Rows(FILA).ReadOnly = Not _pListaCostoAgencias(pos).PBSELECCIONABLE
                    If (_pListaCostoAgencias(pos).PBSELECCIONABLE = True) Then
                        kgvDetalleCostos.Rows(FILA).Cells("CSRVRL").Style.BackColor = Color.FromArgb(255, 255, 192)
                    End If
                End If
            Next
            CalcularMontoSeleccionados()
            AlmacenarSeleccionados()
            kgvDetalleCostos.EndEdit()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub CalcularMontoSeleccionados()
        txtMontoBaseDol.Text = CalcularTotalSeleccionado(TipoSuma.ImporteBaseDolar)
        'txtMonto_dol_final.Text = CalcularTotalSeleccionado(TipoSuma.ImporteBaseDolar)
        'txtMonto_sol_final.Text = CalcularTotalSeleccionado(TipoSuma.ImporteBaseSoles)
        txtMonto_dol_final.Text = CalcularTotalSeleccionado(TipoSuma.ImporteTotalDolar)
        txtMonto_sol_final.Text = CalcularTotalSeleccionado(TipoSuma.ImporteTotalSoles)
    End Sub
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            Dim Monto As Decimal
            _pListaCostosSeleccionados.Clear()
            kgvDetalleCostos.EndEdit()
            Monto = CalcularTotalSeleccionado(TipoSuma.ImporteBaseDolar)
            Dim IDUNICO As String = ""
            For Fila As Integer = 0 To kgvDetalleCostos.Rows.Count - 1
                IDUNICO = kgvDetalleCostos.Rows(Fila).Cells("IDUNICO").Value
                For FilaCosto As Int32 = 0 To _pListaCostoAgencias.Count - 1
                    If (_pListaCostoAgencias(FilaCosto).PSVARCOSTO = pCODVAR AndAlso IDUNICO = _pListaCostoAgencias(FilaCosto).PSIDUNICO) Then
                        _pListaCostoAgencias(FilaCosto).PNIGV = kgvDetalleCostos.Rows(Fila).Cells("PIGVA").Value
                        '_pListaCostoAgencias(FilaCosto).PNIMPORTE_BASE_DOL = kgvDetalleCostos.Rows(Fila).Cells("MONTO_DOL_FINAL").Value
                        '_pListaCostoAgencias(FilaCosto).PNIMPORTE_BASE_SOL = kgvDetalleCostos.Rows(Fila).Cells("MONTO_SOL_FINAL").Value
                        _pListaCostoAgencias(FilaCosto).PNIMPORTE_BASE_DOL = kgvDetalleCostos.Rows(Fila).Cells("MONTO_DOL").Value
                        _pListaCostoAgencias(FilaCosto).PNIMPORTE_BASE_SOL = kgvDetalleCostos.Rows(Fila).Cells("MONTO_SOL").Value
                        _pListaCostoAgencias(FilaCosto).PNIMPORTE_IGV_DOL = kgvDetalleCostos.Rows(Fila).Cells("PIGVA_DOL").Value
                        _pListaCostoAgencias(FilaCosto).PNIMPORTE_IGV_SOL = kgvDetalleCostos.Rows(Fila).Cells("PIGVA_SOL").Value
                        Exit For
                    End If
                Next
            Next
            Dim PNCSRVRL As Decimal = 0
            If (Monto >= 0) Then
                AlmacenarSeleccionados()
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                MessageBox.Show("La selección debe ser con monto total mayor a cero.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AlmacenarSeleccionados()
        Dim IDUNICO As String = ""
        _pListaCostosSeleccionados.Clear()
        For Fila As Integer = 0 To kgvDetalleCostos.Rows.Count - 1
            If (kgvDetalleCostos.Rows(Fila).Cells("CHKCOSTO").Value = True) Then
                IDUNICO = kgvDetalleCostos.Rows(Fila).Cells("IDUNICO").Value
                If (Not _pListaCostosSeleccionados.Contains(IDUNICO)) Then
                    _pListaCostosSeleccionados.Add(IDUNICO)
                End If
            End If
        Next

    End Sub


    Private Function CalcularTotalSeleccionado(ByVal Tipo As TipoSuma) As Decimal
        kgvDetalleCostos.EndEdit()
        Dim VariableOfSuma As String = ""
        Select Case Tipo
            Case TipoSuma.ImporteBaseDolar
                VariableOfSuma = "MONTO_DOL"
            Case TipoSuma.ImporteBaseSoles
                VariableOfSuma = "MONTO_SOL"
                'VariableOfSuma = "MONTO_SOL_FINAL"
            Case TipoSuma.ImporteTotalDolar
                VariableOfSuma = "MONTO_DOL_FINAL"
                'VariableOfSuma = "MONTO_DOL"
            Case TipoSuma.ImporteTotalSoles
                VariableOfSuma = "MONTO_SOL_FINAL"
                'VariableOfSuma = "MONTO_SOL"
        End Select
        Dim Monto As Decimal = 0
        Dim VALOR As Decimal = 0
        Dim chk_sel As Boolean = False
        Dim CONV As Boolean = False
        For Fila As Integer = 0 To kgvDetalleCostos.Rows.Count - 1
            chk_sel = kgvDetalleCostos.Rows(Fila).Cells("CHKCOSTO").Value
            If (chk_sel = True) Then
                CONV = Decimal.TryParse(kgvDetalleCostos.Rows(Fila).Cells(VariableOfSuma).Value, VALOR)
                Monto = Monto + VALOR
            End If
        Next
        Return Monto
    End Function

    

    Private Sub kgvDetalleCostos_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles kgvDetalleCostos.RowEnter
        Try
          CalcularMontoSeleccionados
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub kgvDetalleCostos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles kgvDetalleCostos.CellContentClick
        Try
        CalcularMontoSeleccionados
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub kgvDetalleCostos_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles kgvDetalleCostos.CellContentDoubleClick
        Try
         CalcularMontoSeleccionados
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub kgvDetalleCostos_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles kgvDetalleCostos.CellEndEdit
        Try
            Dim Valor As String = ""
            Dim PIGV As Decimal = 0
            Dim Importe_dol As Decimal = 0
            Dim Importe_sol As Decimal = 0
            Dim IMTPOC As Decimal = 0

            Dim obeCalImporteBaseOfTotal As beCalculoImporte
            Dim ofnEmbarqueAduanas As New clsEmbarqueAduanas

            For Fila As Integer = 0 To kgvDetalleCostos.Rows.Count - 1
                Valor = ("" & kgvDetalleCostos.Rows(Fila).Cells("PIGVA").Value)
                If String.IsNullOrEmpty(Valor) Then
                    kgvDetalleCostos.Rows(Fila).Cells("PIGVA").Value = 0
                End If
                PIGV = kgvDetalleCostos.Rows(Fila).Cells("PIGVA").Value
                Importe_dol = kgvDetalleCostos.Rows(Fila).Cells("MONTO_DOL").Value
                Importe_sol = kgvDetalleCostos.Rows(Fila).Cells("MONTO_SOL").Value

                '******calculo importes**************


                obeCalImporteBaseOfTotal = ofnEmbarqueAduanas.ObtenerCalculoImportesBase_Base(Importe_dol, Importe_sol, PIGV)
                '***********************************************

                'kgvDetalleCostos.Rows(Fila).Cells("MONTO_DOL_FINAL").Value = obeCalImporteBaseOfTotal.PNIMPORTE_BASE_DOL
                kgvDetalleCostos.Rows(Fila).Cells("MONTO_DOL_FINAL").Value = obeCalImporteBaseOfTotal.PNIMPORTE_TOTAL_DOL
                kgvDetalleCostos.Rows(Fila).Cells("PIGVA_DOL").Value = obeCalImporteBaseOfTotal.PNIMPORTE_IGV_DOL

                'kgvDetalleCostos.Rows(Fila).Cells("MONTO_SOL_FINAL").Value = obeCalImporteBaseOfTotal.PNIMPORTE_BASE_SOL
                kgvDetalleCostos.Rows(Fila).Cells("MONTO_SOL_FINAL").Value = obeCalImporteBaseOfTotal.PNIMPORTE_TOTAL_SOL
                kgvDetalleCostos.Rows(Fila).Cells("PIGVA_SOL").Value = obeCalImporteBaseOfTotal.PNIMPORTE_IGV_SOL


            Next
            CalcularMontoSeleccionados()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Event_KeyPress_NumeroWithDecimal(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If HelpUtil.SoloNumerosConDecimal(CType(sender, TextBox), CShort(Asc(e.KeyChar))) = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub kgvDetalleCostos_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles kgvDetalleCostos.EditingControlShowing
        Dim colName As String = ""
        Try
            Dim Texto As New TextBox
            colName = kgvDetalleCostos.Columns(kgvDetalleCostos.CurrentCell.ColumnIndex).Name
            If TypeOf e.Control Is TextBox Then
                RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
            End If
            Select Case colName
                Case "PIGVA"
                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.Tag = "2-0"
                    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
