Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones

Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos

Public Class frmAgregarLiquidaciones
    Private objCompaniaBLL As New NEGOCIO.Compania_BLL
    Private objPlanta As New NEGOCIO.Planta_BLL
    Private objDivision As New NEGOCIO.Division_BLL


    Private obj_Logica_TipoCombustible As New TipoCombustible_BLL

    Private bolBuscar As Boolean

    Public ccmpn As String = ""
    Public dvsn As String = ""
    
    'Public pla As String = ""
    Public NroLiqComb As Decimal = 0
    Public pEstado As String = ""
    Public pDialog As Boolean = False

    Public pPlaca As String = ""
    'Public pListValeCombustible As New List(Of ValeCombustible)
    'Public pRegistroMasivo As Boolean = False


    Private Sub frmAgregarLiquidaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim usua As String = "prueba2030"
            If NroLiqComb <> 0 Then
                ucPlaca.Visible = False
                txtPlaca.Visible = True
                txtPlaca.Enabled = False
                txtPlaca.Enabled = False
                txtPlaca.Text = pPlaca
                txtLiquidacion.Text = NroLiqComb
                btnRegis.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                btnActualiza.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
                KryptonHeaderGroup1.Panel.Enabled = True
                ListarInformacionEscaner()

                If pEstado = "C" Then
                    btnActualiza.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                    KryptonHeaderGroup1.Panel.Enabled = False
                End If


            Else
                'Cargar_Ultimo_KM_Final_Unidad
                Dim objLogica As New OperacionTransporte_BLL
                Dim dt As DataTable
                dt = objLogica.Cargar_Ultimo_KM_Final_Unidad(ccmpn, pPlaca)
                If dt.Rows.Count > 0 Then
                    txtKMInicial.Text = dt.Rows(0)("KM_ULT")
                End If


                Me.Cargar_Vehiculo()
                ucPlaca.Visible = True
                txtPlaca.Visible = False

                KryptonHeaderGroup1.Panel.Enabled = False

                btnRegis.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
                btnActualiza.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False


                'If pRegistroMasivo = True Then
                '    ucPlaca.Visible = False
                '    txtPlaca.Visible = True
                '    txtPlaca.Enabled = False
                '    txtPlaca.Enabled = False
                '    txtPlaca.Text = pPlaca
                '    ucPlaca.Valor = pPlaca
                'End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       


     


      



    End Sub

    Private Sub ListarInformacionEscaner()
        Dim objLogica As New OperacionTransporte_BLL
        Dim objParametro As New Hashtable
        objParametro.Add("PNNLQCMB", NroLiqComb)
        Dim dt As DataTable
        dt = objLogica.Carga_InfEscaner(objParametro)
        If dt.Rows.Count > 0 Then
            txtKMInicial.Text = dt.Rows(0)("KMSINI")
            txtKMFinal.Text = dt.Rows(0)("KMSFIN")
            txtKMRecorridos.Text = dt.Rows(0)("KMSRCR")
            'txtCantUrea.Text = Val(dt.Rows(0)("QLUREA")) ' cantidad Úrea en litros
            'txtCostoUrea.Text = Val(dt.Rows(0)("CGUREA")) ' Costo Urea ( x Galon)
            txtDSTVJE.Text = dt.Rows(0)("DSTVJE")
            txtCMVJE.Text = dt.Rows(0)("CMVJE")
            txtPROCC.Text = dt.Rows(0)("PROCC")
            txtCSMVJE.Text = dt.Rows(0)("CSMVJE")
            txtCDUCC.Text = dt.Rows(0)("CDUCC")
            txtVJECRU.Text = dt.Rows(0)("VJECRU")
            txtTMVJE.Text = dt.Rows(0)("TMVJE")
            txtVJERNE.Text = dt.Rows(0)("VJERNE")
            txtVJESBR.Text = dt.Rows(0)("VJESBR")
            txtCMVJENE.Text = dt.Rows(0)("CMVJENE")
            txtVMVJE.Text = dt.Rows(0)("VMVJE")
            txtDesplazamiento.Text = dt.Rows(0)("DSPVJE")
            txtSBRVLD.Text = dt.Rows(0)("SBRVLD")
            txtHRMVJE.Text = dt.Rows(0)("HRMVJE")
            txtTMRVJE.Text = dt.Rows(0)("TMRVJE")
            txtCMRVJE.Text = dt.Rows(0)("CMRVJE")
            txtDSTTAL.Text = dt.Rows(0)("DSTTAL")
            txtCOBTAL.Text = dt.Rows(0)("COBTAL")
            txtMTRTAL.Text = dt.Rows(0)("MTRTAL")
            txtTMRTAL.Text = dt.Rows(0)("TMRTAL")
            txtObs.Text = ("" & dt.Rows(0)("TOBS")).ToString.Trim
        End If

    End Sub

    Private Sub Cargar_Vehiculo()
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        Dim obj As New LiquidacionCombustible_BLL
        Dim lista As New List(Of LiquidacionCombustible)

        Dim objParametro As New Hashtable

        objParametro.Add("CCMPN", ccmpn)


        lista = obj.cargar_vehiculo(objParametro)
        Dim Etiquetas As New List(Of String)
        oListColum = New Hashtable
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "NPLCUN"
        oColumnas.DataPropertyName = "NPLCUN"
        oColumnas.HeaderText = "Placa"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TMRCTR"
        oColumnas.DataPropertyName = "TMRCTR"
        oColumnas.HeaderText = "Descripción"
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(2, oColumnas)

        Etiquetas.Add("Placa")
        Etiquetas.Add("Descripción")


        Me.ucPlaca.Etiquetas_Form = Etiquetas
        Me.ucPlaca.DataSource = lista
        Me.ucPlaca.ListColumnas = oListColum
        Me.ucPlaca.Cargas()
        Me.ucPlaca.ValueMember = "NPLCUN"
        Me.ucPlaca.DispleyMember = "TMRCTR"




    End Sub
     

    Private Sub btnSalir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    Private Sub btnRegis_Click(sender As Object, e As EventArgs) Handles btnRegis.Click
        Try
            Dim obj_LogicaCombustible As New LiquidacionCombustible
            Dim obj_LogicaLiquidacion As New LiquidacionCombustible_BLL
            Dim msgRegmasivo As String = ""
            Dim objParametro As New Hashtable

            If ucPlaca.Resultado Is Nothing Then
                MessageBox.Show("Seleccione placa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If


            objParametro.Add("PNCCMPN", ccmpn)
            objParametro.Add("PNCDVSN", dvsn)
            objParametro.Add("PNFLQDCN", HelpClass.TodayNumeric)
            objParametro.Add("PNCPLNDV", 0)
            objParametro.Add("PSCUSRCRT", MainModule.USUARIO)
            objParametro.Add("PSNTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)
            If ucPlaca.Resultado IsNot Nothing Then
                objParametro.Add("PSNPLCUN", CType(ucPlaca.Resultado, LiquidacionCombustible).NPLCUN)
            End If
            objParametro.Add("PSTOBS", txtObs.Text.Trim)

            Dim WK_NLQCMB As Decimal = 0
            Dim msgError As String = ""

            msgError = obj_LogicaLiquidacion.Registrar_Liquidacion_Tracto(objParametro, WK_NLQCMB)

            'If pRegistroMasivo = True And WK_NLQCMB > 0 Then
            '    msgRegmasivo = RegistrarMasivoVales(WK_NLQCMB)
            'End If

            If msgError <> "" Then
                MessageBox.Show(msgError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If WK_NLQCMB > 0 Then
                NroLiqComb = WK_NLQCMB
                txtLiquidacion.Text = NroLiqComb
                pDialog = True
                MessageBox.Show("Se generó liquidación número " & WK_NLQCMB, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ucPlaca.Enabled = False
                btnRegis.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.False
                btnActualiza.Enabled = ComponentFactory.Krypton.Toolkit.ButtonEnabled.True
                KryptonHeaderGroup1.Panel.Enabled = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    'Private Function RegistrarMasivoVales(numLiq As Decimal) As String
    '    Dim obrValeCombustible As New ValeCombustible_BLL
    '    Dim msglist As String = ""
    '    Dim msg As String = ""
    '    For Each item As ValeCombustible In pListValeCombustible
    '        item.NLQCMB = numLiq
    '        msg = obrValeCombustible.Registrar_Vale_CombustibleV2(item)
    '        If msg = "" Then
    '            Dim obeValeCombustible As New ValeCombustible
    '            With obeValeCombustible
    '                .NLQCMB = -1
    '                .CCMPN = ccmpn
    '                .NRITEM = item.NRITEM
    '                .CULUSA = MainModule.USUARIO
    '                .NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
    '            End With
    '            msg = obrValeCombustible.Eliminar_Vale_Liquidacion_Combustible(obeValeCombustible)
    '        Else
    '            msglist = msglist & Chr(10) & msg
    '        End If
    '    Next
    '    msglist = msglist.Trim
    '    Return msglist
    'End Function

    Private Sub btnActualiza_Click(sender As Object, e As EventArgs) Handles btnActualiza.Click
        Try
            Dim objParametro As New Hashtable
            Dim obj_LogicaLiquidacion As New LiquidacionCombustible_BLL
            objParametro.Add("PNNLQCMB", NroLiqComb)
            objParametro.Add("PNKMSINI", Val(txtKMInicial.Text.Trim))
            objParametro.Add("PNKMSFIN", Val(txtKMFinal.Text.Trim))
            objParametro.Add("PNKMSRCR", Val(txtKMRecorridos.Text.Trim))
            'objParametro.Add("PNQGUREA", Val(txtCantUrea.Text.Trim))
            'objParametro.Add("PNCGUREA", Val(txtCostoUrea.Text.Trim))
            objParametro.Add("PNDSTVJE", Val(txtDSTVJE.Text.Trim)) ' distancia del viaje
            objParametro.Add("PNCMVJE", Val(txtCMVJE.Text.Trim)) ' consumo medio viaje
            objParametro.Add("PNPROCC", Val(txtPROCC.Text.Trim)) ' promedio recorrido
            objParametro.Add("PNCSMVJE", Val(txtCSMVJE.Text.Trim)) ' consumo del viaje
            objParametro.Add("PNCDUCC", Val(txtCDUCC.Text.Trim)) ' codnuccion
            objParametro.Add("PNVJECRU", Val(txtVJECRU.Text.Trim)) ' viaje crucero
            objParametro.Add("PNTMVJE", Val(txtTMVJE.Text.Trim)) ' Tiempo Viaje
            objParametro.Add("PNVJERNE", Val(txtVJERNE.Text.Trim)) ' viaje regimen no economico
            objParametro.Add("PNVJESBR", Val(txtVJESBR.Text.Trim)) ' viaje sobrerevoluciones
            objParametro.Add("PNCMVJENE", Val(txtCMVJENE.Text.Trim)) ' consumo del viaje no economico
            objParametro.Add("PNVMVJE", Val(txtVMVJE.Text.Trim)) ' velocidad media del viaje
            objParametro.Add("PNDSPVJE", Val(txtDesplazamiento.Text.Trim))
            objParametro.Add("PNSBRVLD", Val(txtSBRVLD.Text.Trim)) ' sobrevelocidad del viaje
            objParametro.Add("PNHRMVJE", Val(txtHRMVJE.Text.Trim)) ' horas de motor viaje
            objParametro.Add("PNTMRVJE", Val(txtTMRVJE.Text.Trim)) ' tiempo ralenti viaje
            objParametro.Add("PNCMRVJE", Val(txtCMRVJE.Text.Trim)) ' consumo ralenti del viaje
            objParametro.Add("PNDSTTAL", Val(txtDSTTAL.Text.Trim)) ' distancia total
            objParametro.Add("PNCOBTAL", Val(txtCOBTAL.Text.Trim)) ' combustible total consumido
            objParametro.Add("PNMTRTAL", Val(txtMTRTAL.Text.Trim)) ' combustible total consumido
            objParametro.Add("PNTMRTAL", Val(txtTMRTAL.Text.Trim)) ' horas motor total
            objParametro.Add("PSCULUSA", MainModule.USUARIO)
            objParametro.Add("PSNTRMNL", Ransa.Utilitario.HelpClass.NombreMaquina)
            objParametro.Add("PSTOBS", txtObs.Text.Trim)
            obj_LogicaLiquidacion.registrar_inf_escaner_liquidacion(objParametro)
            pDialog = True
            ListarInformacionEscaner()
            MessageBox.Show("Registro actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


    'Sub solo_numeros(e As KeyPressEventArgs)
    '    If Char.IsNumber(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsControl(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsSeparator(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True
    '    End If
    'End Sub


   


    Private Sub btnSal_Click(sender As Object, e As EventArgs) Handles btnSal.Click
        Me.Close()
    End Sub

    Private Sub txtKMInicial_TextChanged(sender As Object, e As EventArgs) Handles txtKMInicial.TextChanged, txtKMFinal.TextChanged
        Try
            Dim Km_Inicial As Decimal = Val(txtKMInicial.Text.Trim)
            Dim Km_Final As Decimal = Val(txtKMFinal.Text.Trim)
            If Km_Final > 0 And Km_Final > Km_Inicial Then
                txtKMRecorridos.Text = Km_Final - Km_Inicial
            Else
                txtKMRecorridos.Text = "0"
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub
End Class