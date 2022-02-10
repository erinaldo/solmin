Imports SOLMIN_ST.NEGOCIO.Operaciones
Public Class frmCerrarLiqCombustible
    Public pNLQCMB As Decimal = 0
    Public pCCMPN As String = ""
    Public pDialog As Boolean = False

    Private TotKMRecorridos As Decimal = 0
    Private TotCantCombustible As Decimal = 0
    Private TotCantUrea As Decimal = 0
    Private TotCostoCombustible As Decimal = 0
    Private TotCostoUrea As Decimal = 0
    Private CostoCompleto As Boolean = True

    Private CodTipoLiq As String = ""
    'Public Enum TipoCierre
    '    Cierre
    'End Enum

    'Public pTipoCierre As TipoCierre = TipoCierre.Cierre

    Private Sub frmCerrarLiqCombustible_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dtgLiquidacion.AutoGenerateColumns = False


            ListarInformacionTotales()
            ListarOperacionesLiqCombustible()

            DistribucionCantCombustible_X_Cant_KMRecorrido()
            DistribucionCantUrea_X_Cant_KMRecorrido()
            DistribucionCostoCombustible_X_Cant_Combustible()
            DistribucionCostoUrea_X_Cant_Urea()
            MostrarResumenCantidad()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MostrarResumenCantidad()
        Dim km_real As Decimal = 0
        Dim cant_comb As Decimal = 0
        Dim cant_urea As Decimal = 0
        For Each item As DataGridViewRow In dtgLiquidacion.Rows
            km_real = km_real + Val("" & item.Cells("KM_ASIGNAR").Value)
            cant_comb = cant_comb + Val("" & item.Cells("QGLNCM").Value)
            cant_urea = cant_urea + Val("" & item.Cells("QGUREA").Value)
        Next
        txtkm_real.Text = km_real
        txtcant_comb.Text = cant_comb
        txtcant_urea.Text = cant_urea

        txtkm_real.ForeColor = Color.Black
        txtcant_comb.ForeColor = Color.Black
        txtcant_urea.ForeColor = Color.Black

        If TotKMRecorridos <> km_real Then
            txtkm_real.ForeColor = Color.Red
        End If
        If TotCantCombustible <> cant_comb Then
            txtcant_comb.ForeColor = Color.Red
        End If
        If TotCantUrea <> cant_urea Then
            txtcant_urea.ForeColor = Color.Red
        End If
     
    End Sub

    Private Sub ListarInformacionTotales()
        Dim objLogica As New OperacionTransporte_BLL
        Dim oUrea_BLL As New SOLMIN_ST.NEGOCIO.Urea_BLL
        Dim obj_LogicaCombustible As New Combustible_BLL

        Dim objParametro As New Hashtable
        objParametro.Add("PNNLQCMB", pNLQCMB)
        Dim dtLiquidacion As DataTable
        Dim dtVales As New DataTable
        dtLiquidacion = objLogica.Carga_InfEscaner(objParametro)
        If dtLiquidacion.Rows.Count > 0 Then

            CodTipoLiq = ("" & dtLiquidacion.Rows(0)("CTLQCB")).ToString.Trim

            TotKMRecorridos = Math.Round(dtLiquidacion.Rows(0)("KMSRCR"), 2)
            If dtLiquidacion.Rows(0)("FINCRG") <> 0 Then
                dtpInicioCarga.Value = Ransa.Utilitario.HelpClass.CNumero_a_Fecha(dtLiquidacion.Rows(0)("FINCRG"))
            End If
            If dtLiquidacion.Rows(0)("FCRVJE") <> 0 Then
                dtpCierreViaje.Value = Ransa.Utilitario.HelpClass.CNumero_a_Fecha(dtLiquidacion.Rows(0)("FCRVJE"))
            End If
        End If

        Dim oUrea As New SOLMIN_ST.ENTIDADES.Urea
        oUrea.CCMPN = pCCMPN
        oUrea.NLQCMB = pNLQCMB
        Dim dtUrea As New DataTable
        dtUrea = oUrea_BLL.Listar_Urea_Asignado_x_Liquidacion(oUrea)
        For Each item As DataRow In dtUrea.Rows
            TotCantUrea = TotCantUrea + item("QGLNCM")
            TotCostoUrea = TotCostoUrea + item("SUB_TOTAL")
        Next

        objParametro = New Hashtable
        objParametro.Add("PSCCMPN", pCCMPN)
        objParametro.Add("PNNLQCMB", pNLQCMB)
        dtVales = obj_LogicaCombustible.Listar_Vales_Asignados_x_Liquidacion(objParametro)
        For Each item As DataRow In dtVales.Rows
            TotCantCombustible = TotCantCombustible + item("QGLNCM")
            TotCostoCombustible = TotCostoCombustible + item("SUB_TOTAL")
            If item("SUB_TOTAL") = 0 Then
                CostoCompleto = False
            End If
        Next
        TotCantCombustible = Math.Round(TotCantCombustible, 2)
        TotCostoCombustible = Math.Round(TotCostoCombustible, 2)
        TotCantUrea = Math.Round(TotCantUrea, 2)
        TotCostoUrea = Math.Round(TotCostoUrea, 2)

        txtkmrecorridos.Text = TotKMRecorridos
        txtCantTotComb.Text = TotCantCombustible
        txtCostoTotReal.Text = TotCostoCombustible
        txtCantUrea.Text = TotCantUrea
        txtCostoTotUrea.Text = TotCostoUrea


    End Sub


    Private Sub DistribucionCostoUrea_X_Cant_Urea()
        Dim SubTotal As Decimal = 0
        Dim ImporteDistribuido As Decimal = 0
        Dim ImporteAcumulado As Decimal = 0
        Dim RedondeoDistribucion As Decimal = 0
        Dim FilaReg As Int32 = 0
        For Each item As DataGridViewRow In dtgLiquidacion.Rows
            SubTotal = SubTotal + item.Cells("QGUREA").Value
        Next
        For Each item As DataGridViewRow In dtgLiquidacion.Rows
            ImporteDistribuido = 0
            If SubTotal > 0 Then
                ImporteDistribuido = Math.Round((item.Cells("QGUREA").Value / SubTotal) * TotCostoUrea, 2, MidpointRounding.AwayFromZero)
            End If
            item.Cells("CTUREA").Value = ImporteDistribuido
            ImporteAcumulado = ImporteAcumulado + ImporteDistribuido
        Next

        RedondeoDistribucion = TotCostoUrea - ImporteAcumulado
        If dtgLiquidacion.Rows.Count > 0 Then
            FilaReg = dtgLiquidacion.Rows.Count - 1
            dtgLiquidacion.Rows(FilaReg).Cells("CTUREA").Value = dtgLiquidacion.Rows(FilaReg).Cells("CTUREA").Value + RedondeoDistribucion
        End If

    End Sub

    Private Sub DistribucionCostoCombustible_X_Cant_Combustible()
        Dim SubTotal As Decimal = 0
        Dim ImporteDistribuido As Decimal = 0
        Dim ImporteAcumulado As Decimal = 0
        Dim RedondeoDistribucion As Decimal = 0
        Dim FilaReg As Int32 = 0
        For Each item As DataGridViewRow In dtgLiquidacion.Rows
            SubTotal = SubTotal + item.Cells("QGLNCM").Value
        Next

        For Each item As DataGridViewRow In dtgLiquidacion.Rows
            ImporteDistribuido = 0
            If SubTotal > 0 Then
                ImporteDistribuido = Math.Round((item.Cells("QGLNCM").Value / SubTotal) * TotCostoCombustible, 2, MidpointRounding.AwayFromZero)
            End If
            item.Cells("CSTTCB").Value = ImporteDistribuido
            ImporteAcumulado = ImporteAcumulado + ImporteDistribuido
        Next

        RedondeoDistribucion = TotCostoCombustible - ImporteAcumulado
        If dtgLiquidacion.Rows.Count > 0 Then
            FilaReg = dtgLiquidacion.Rows.Count - 1
            dtgLiquidacion.Rows(FilaReg).Cells("CSTTCB").Value = dtgLiquidacion.Rows(FilaReg).Cells("CSTTCB").Value + RedondeoDistribucion
        End If

    End Sub

    Private Sub DistribucionCantCombustible_X_Cant_KMRecorrido()
        Dim SubTotal As Decimal = 0
        Dim ImporteDistribuido As Decimal = 0
        Dim ImporteAcumulado As Decimal = 0
        Dim RedondeoDistribucion As Decimal = 0
        Dim FilaReg As Int32 = 0
        For Each item As DataGridViewRow In dtgLiquidacion.Rows
            SubTotal = SubTotal + item.Cells("KM_ASIGNAR").Value
        Next
        For Each item As DataGridViewRow In dtgLiquidacion.Rows
            ImporteDistribuido = 0
            If SubTotal > 0 Then
                ImporteDistribuido = Math.Round((item.Cells("KM_ASIGNAR").Value / SubTotal) * TotCantCombustible, 2, MidpointRounding.AwayFromZero)
            End If
            item.Cells("QGLNCM").Value = ImporteDistribuido
            ImporteAcumulado = ImporteAcumulado + ImporteDistribuido
        Next

        RedondeoDistribucion = TotCantCombustible - ImporteAcumulado
        If dtgLiquidacion.Rows.Count > 0 Then
            FilaReg = dtgLiquidacion.Rows.Count - 1
            dtgLiquidacion.Rows(FilaReg).Cells("QGLNCM").Value = dtgLiquidacion.Rows(FilaReg).Cells("QGLNCM").Value + RedondeoDistribucion
        End If

    End Sub

    Private Sub DistribucionCantUrea_X_Cant_KMRecorrido()
        Dim SubTotal As Decimal = 0
        Dim ImporteDistribuido As Decimal = 0
        Dim ImporteAcumulado As Decimal = 0
        Dim RedondeoDistribucion As Decimal = 0
        Dim FilaReg As Int32 = 0
        For Each item As DataGridViewRow In dtgLiquidacion.Rows
            SubTotal = SubTotal + item.Cells("KM_ASIGNAR").Value
        Next
        For Each item As DataGridViewRow In dtgLiquidacion.Rows
            ImporteDistribuido = 0
            If SubTotal > 0 Then
                ImporteDistribuido = Math.Round((item.Cells("KM_ASIGNAR").Value / SubTotal) * TotCantUrea, 2, MidpointRounding.AwayFromZero)
            End If
            item.Cells("QGUREA").Value = ImporteDistribuido
            ImporteAcumulado = ImporteAcumulado + ImporteDistribuido
        Next

        RedondeoDistribucion = TotCantUrea - ImporteAcumulado
        If dtgLiquidacion.Rows.Count > 0 Then
            FilaReg = dtgLiquidacion.Rows.Count - 1
            dtgLiquidacion.Rows(FilaReg).Cells("QGUREA").Value = dtgLiquidacion.Rows(FilaReg).Cells("QGUREA").Value + RedondeoDistribucion
        End If

    End Sub



    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Try
            Dim msgval As String = ""
            Dim obj_LogicaCombustible As New Combustible_BLL
            Dim oLiquidacionCombustible_BLL As New LiquidacionCombustible_BLL

            If TotKMRecorridos = 0 Then
                msgval = msgval & "Total KM Liquidación debe ser mayor a 0." & Chr(10)
            End If

            Dim FechaInicioCarga As Int32 = dtpInicioCarga.Value.ToString("yyyyMMdd")
            Dim FechaCierreVje As Int32 = dtpCierreViaje.Value.ToString("yyyyMMdd")
            If FechaCierreVje < FechaInicioCarga Then
                msgval = msgval & "Fecha cierre debe ser mayor al de inicio carga." & Chr(10)
            End If



            Dim SumCantKM As Decimal = 0
            Dim SumCantComb As Decimal = 0
            Dim SumCantUrea As Decimal = 0
            Dim SumCostoComb As Decimal = 0
            Dim SumCostoUrea As Decimal = 0
            Dim KM_ES_0 As Boolean = False
            Dim oListComb As New List(Of ENTIDADES.Operaciones.LiquidacionCombustible)
            Dim oLiqCombBE As ENTIDADES.Operaciones.LiquidacionCombustible

            For Each item As DataGridViewRow In dtgLiquidacion.Rows

                SumCantKM = SumCantKM + item.Cells("KM_ASIGNAR").Value

                If Val("" & item.Cells("KM_ASIGNAR").Value) = 0 Then
                    KM_ES_0 = True
                End If

                SumCantComb = SumCantComb + item.Cells("QGLNCM").Value
                SumCantUrea = SumCantUrea + item.Cells("QGUREA").Value
                SumCostoComb = SumCostoComb + item.Cells("CSTTCB").Value
                SumCostoUrea = SumCostoUrea + item.Cells("CTUREA").Value


                oLiqCombBE = New ENTIDADES.Operaciones.LiquidacionCombustible
                oLiqCombBE.CCMPN = pCCMPN
                oLiqCombBE.NLQCMB = pNLQCMB
                oLiqCombBE.NOPRCN = item.Cells("NOPRCN").Value
                oLiqCombBE.NKMRCR = Val("" & item.Cells("KM_ASIGNAR").Value)
                oLiqCombBE.QGLNCM = Val("" & item.Cells("QGLNCM").Value)
                oLiqCombBE.CSTTCB = Val("" & item.Cells("CSTTCB").Value)
                oLiqCombBE.QGUREA = Val("" & item.Cells("QGUREA").Value)
                oLiqCombBE.CTUREA = Val("" & item.Cells("CTUREA").Value)



                oLiqCombBE.CULUSA = MainModule.USUARIO
                oLiqCombBE.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                oListComb.Add(oLiqCombBE)


            Next
            If KM_ES_0 = True Then
                msgval = msgval & "Verificar asignación KM . Debe ser mayor a 0." & Chr(10)
            End If
            If SumCantKM <> TotKMRecorridos Then
                msgval = msgval & "Distribución KM no coincide al recorrido." & Chr(10)
            End If
            If SumCantComb <> TotCantCombustible Then
                msgval = msgval & "Distribución cant. Combustible no coincide a Cantidad Total." & Chr(10)
            End If
            If SumCantUrea <> TotCantUrea Then
                msgval = msgval & "Distribución cant. Úrea no coincide a Cantidad Total." & Chr(10)
            End If
            If SumCostoComb <> TotCostoCombustible Then
                msgval = msgval & "Distribución costo combustible no coincide a Costo Total." & Chr(10)
            End If
            If SumCostoUrea <> TotCostoUrea Then
                msgval = msgval & "Distribución costo úrea no coincide a Costo Total." & Chr(10)
            End If

          
            If CostoCompleto = False Then
                msgval = msgval & "Costo Vale deben ser mayor a 0" & Chr(10)
            End If
            msgval = msgval.Trim

            If dtgLiquidacion.Rows.Count > 0 Or CodTipoLiq = "01" Then
                ' 01 : Liquidaciones con registro de operaciones
                ' obligatorio ingreso de operaciones
                If msgval <> "" Then
                    MessageBox.Show(msgval, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                Dim objParam As New Hashtable
                objParam.Add("PNNLQCMB", pNLQCMB)
                objParam.Add("PNFINCRG", FechaInicioCarga)
                objParam.Add("PNFCRVJE", FechaCierreVje)
                objParam.Add("PSCCMPN", pCCMPN)
                objParam.Add("PSCULUSA", MainModule.USUARIO)
                objParam.Add("PSNTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)

                Dim msg As String = ""
                msg = oLiquidacionCombustible_BLL.Cerrar_Liquidacion_Combustible(objParam)
                If msg <> "" Then
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                For Each item As ENTIDADES.Operaciones.LiquidacionCombustible In oListComb
                    obj_LogicaCombustible.Registrar_Distribucion_Cierre_Liquidacion(item)
                Next
                MessageBox.Show("Liquidación Cerrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                pDialog = True
                Me.Close()


            Else

                Dim objParam As New Hashtable
                objParam.Add("PNNLQCMB", pNLQCMB)
                objParam.Add("PNFINCRG", FechaInicioCarga)
                objParam.Add("PNFCRVJE", FechaCierreVje)
                objParam.Add("PSCCMPN", pCCMPN)
                objParam.Add("PSCULUSA", MainModule.USUARIO)
                objParam.Add("PSNTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)

                Dim msg As String = ""
                msg = oLiquidacionCombustible_BLL.Cerrar_Liquidacion_Combustible(objParam)
                If msg <> "" Then
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                pDialog = True
                Me.Close()


            End If

          
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub



    Private Sub ListarOperacionesLiqCombustible()
        Dim kmTotOperacion As Decimal = 0
        Dim PreCalculo As Decimal = 0
        Dim SumPreCalculo As Decimal = 0
        Dim RedondeoPreCalculo As Decimal = 0
        Dim FilaUlt As Int64 = 0
        Dim obj_LogicaCombustible As New Combustible_BLL
        Dim objParametro As New Hashtable
        objParametro.Add("PSCCMPN", pCCMPN)
        objParametro.Add("PNNLQCMB", pNLQCMB)
        Dim dt As New DataTable
        dt = obj_LogicaCombustible.Listar_Operaciones_Asignados_x_Liquidacion(objParametro)
        dtgLiquidacion.DataSource = dt
        kmTotOperacion = 0

        For Each item As DataGridViewRow In dtgLiquidacion.Rows
            kmTotOperacion = kmTotOperacion + item.Cells("KM_ASIGNAR").Value
        Next
        If TotKMRecorridos <> kmTotOperacion And kmTotOperacion > 0 Then
            For Each item As DataGridViewRow In dtgLiquidacion.Rows
                PreCalculo = Math.Round((item.Cells("KM_ASIGNAR").Value / kmTotOperacion) * TotKMRecorridos, 2)
                item.Cells("KM_ASIGNAR").Value = PreCalculo
                SumPreCalculo = SumPreCalculo + PreCalculo
            Next

            FilaUlt = dtgLiquidacion.Rows.Count - 1
            RedondeoPreCalculo = TotKMRecorridos - SumPreCalculo
            If FilaUlt >= 0 Then
                dtgLiquidacion.Rows(FilaUlt).Cells("KM_ASIGNAR").Value = dtgLiquidacion.Rows(FilaUlt).Cells("KM_ASIGNAR").Value + RedondeoPreCalculo
            End If
        End If
      
    End Sub

  

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub Event_KeyPress_NumeroWithDecimal(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If HelpClass.SoloNumerosConDecimal(CType(sender, TextBox), CShort(Asc(e.KeyChar))) = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub dtgLiquidacion_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dtgLiquidacion.EditingControlShowing
        Dim colName As String = ""
        Try
            Dim Texto As New TextBox
            If TypeOf e.Control Is TextBox Then
                RemoveHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal
            End If
            colName = dtgLiquidacion.Columns(dtgLiquidacion.CurrentCell.ColumnIndex).Name
            Select Case colName

                Case "KM_ASIGNAR"


                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.Tag = "10-2"
                    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal

                Case "QGLNCM"


                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.Tag = "10-2"
                    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal

                Case "QGUREA"


                    Texto = CType(e.Control, TextBox)
                    Texto.Text = Texto.Text.Trim
                    Texto.Tag = "10-2"
                    AddHandler CType(e.Control, TextBox).KeyPress, AddressOf Event_KeyPress_NumeroWithDecimal

            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dtgLiquidacion_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dtgLiquidacion.CellEndEdit
        Dim intCont As Integer = 0
        Dim strMensajeError As String = ""
        dtgLiquidacion.EndEdit()
        Try

            With dtgLiquidacion
                Select Case .Columns(e.ColumnIndex).Name
                    Case "KM_ASIGNAR"
                        DistribucionCantCombustible_X_Cant_KMRecorrido()
                        DistribucionCantUrea_X_Cant_KMRecorrido()
                        DistribucionCostoCombustible_X_Cant_Combustible()
                        DistribucionCostoUrea_X_Cant_Urea()

                        MostrarResumenCantidad()

                    Case "QGLNCM"
                        DistribucionCostoCombustible_X_Cant_Combustible()

                        MostrarResumenCantidad()

                    Case "QGUREA"
                        DistribucionCostoUrea_X_Cant_Urea()

                        MostrarResumenCantidad()
                End Select

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
 

    End Sub


End Class