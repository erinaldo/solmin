Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports RANSA.TYPEDEF.OrdenCompra
Imports Ransa.TypeDef.Cliente
Imports RANSA.NEGO
Imports RANSA.NEGO.slnSOLMIN_SAT.Almacen
Imports RANSA.NEGO.slnSOLMIN_SAT.Almacen.Reportes
Imports RANSA.NEGO.slnSOLMIN_SAT.Despacho.Reportes
Imports Ransa.TypeDef.Reportes
Imports RANSA.NEGO.slnSOLMIN
Imports RANSA.Utilitario

Public Class frmReporteRotacionProductoMensual
    Private oDsExcel As New DataSet
    Private tablafinal As DataTable
    Private objTemp As TipoDato_ResultaReporte
    Private pnCliente As Integer
    Private pnAnio As String


    Private Sub frmReporteRotacionProductoMensual_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        '-- Crear status por control con F4
        'ConfigurationAppSettings As New System.Configuration.AppSettingsReader
        Dim objAppConfig As cAppConfig = New cAppConfig
        ' Recuperamos los ultimos valores seleccionados

        txtAnio.Text = Date.Now.Year.ToString

        Dim intTemp As Int64 = 0
        Int64.TryParse(objAppConfig.GetValue("RepRecepcionPorAlmacenClienteCodigo", GetType(System.String)), intTemp)

        If (objSeguridadBN Is Nothing) Then
            MessageBox.Show("objeto vacio")
        Else
            Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
            txtCliente.pCargar(ClientePK)
            'MessageBox.Show(objSeguridadBN.pUsuario)
        End If
        'tsbAmpliar.Image = pbxAmpliar.Image

        objAppConfig = Nothing
        tsbExportarExcel.Enabled = True
    End Sub
    Private Sub pGeneraReporte()
        Dim objrptRotacion As New rptRotacionAnual
        Dim objDs As New DataSet
        Dim crParameterDiscreteValue As ParameterDiscreteValue
        Dim crParameterFieldDefinitions As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinitions
        Dim crParameterFieldLocation As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinition
        Dim crParameterValues As CrystalDecisions.Shared.ParameterValues
        Dim pProm As Decimal = 0
        Dim tabla2 As New DataTable
        tabla2.Columns.Add(New DataColumn("CMRCLR", GetType(String)))
        tabla2.Columns.Add(New DataColumn("TMRCD2", GetType(String)))
        tabla2.Columns.Add(New DataColumn("STOCK_INI", GetType(String)))
        For i As Integer = 1 To 12
            tabla2.Columns.Add(New DataColumn("INGRESOS_" + i.ToString.PadLeft(2, "0"), GetType(String)))
            tabla2.Columns.Add(New DataColumn("DESPACHO_" + i.ToString.PadLeft(2, "0"), GetType(String)))
            tabla2.Columns.Add(New DataColumn("STOCK_" + i.ToString.PadLeft(2, "0"), GetType(String)))
        Next
        '-----------------
        tabla2.Columns.Add(New DataColumn("STOCK_FIN", GetType(String)))
        tabla2.Columns.Add(New DataColumn("STOCK_PROM", GetType(String)))

        Dim oReporte As New brReporteDS()

        objDs = oReporte.dsReporteAnualRotacion(pnCliente, Convert.ToDouble(pnAnio))
        Dim dt As New DataTable
        dt = objDs.Tables(0)
        dt.TableName = "dtRotacionMensual"
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim dvR As New DataView(dt)
        dvR.Sort = "CMRCLR"
        dt = dvR.ToTable()
        Dim drSelect As DataRow()
        Dim objDataRow As DataRow
        For i As Integer = 0 To dt.Rows.Count - 1

            drSelect = dt.Select("CMRCLR='" + dt.Rows(i)("CMRCLR").ToString + "' ")
            objDataRow = tabla2.NewRow
            objDataRow.Item("CMRCLR") = dt.Rows(i)("CMRCLR").ToString.Trim
            objDataRow.Item("TMRCD2") = dt.Rows(i)("TMRCD2").ToString.Trim
            tabla2.Rows.Add(objDataRow)
            For Each dr As DataRow In drSelect
                'tabla2.Rows(dt.Rows.Count - 1).Item("MES" + dr("MES").ToString.Trim) = dr("MES").ToString.Trim
                'tabla2.Rows(tabla2.Rows.Count - 1).Item("INGRESOS_" + dr("MES").ToString.Trim) = Math.Round(Convert.ToDecimal(dr("INGRESOS").ToString.Trim), 2)
                tabla2.Rows(tabla2.Rows.Count - 1).Item("INGRESOS_" + dr("MES").ToString.Trim) = Convert.ToInt32(dr("INGRESOS"))
                tabla2.Rows(tabla2.Rows.Count - 1).Item("DESPACHO_" + dr("MES").ToString.Trim) = Convert.ToInt32(dr("DESPACHO"))
                tabla2.Rows(tabla2.Rows.Count - 1).Item("STOCK_" + dr("MES").ToString.Trim) = Convert.ToInt32(dr("VLRFIN"))



                If dr("MES") = "01" Then
                    tabla2.Rows(tabla2.Rows.Count - 1).Item("STOCK_INI") = Convert.ToInt32(dr("VLRINI"))


                End If

                If Convert.ToInt32(txtAnio.Text) < Date.Now.Year Then
                    If dr("MES") = "12" Then
                        tabla2.Rows(tabla2.Rows.Count - 1).Item("STOCK_FIN") = Convert.ToInt32(dr("VLRFIN"))

                    End If

                    For p As Integer = 1 To 12
                        If dr("MES") = p.ToString.PadLeft(2, "0") Then
                            pProm += dr("VLRFIN")
                        End If
                    Next
                    tabla2.Rows(tabla2.Rows.Count - 1).Item("STOCK_PROM") = Math.Round((pProm / 12), 2)

                Else
                    If dr("MES") = Date.Now.Month.ToString.PadLeft(2, "0") Then
                        tabla2.Rows(tabla2.Rows.Count - 1).Item("STOCK_FIN") = Convert.ToInt32(dr("VLRFIN"))

                    End If

                    For p As Integer = 1 To Date.Now.Month
                        If dr("MES") = p.ToString.PadLeft(2, "0") Then
                            pProm += dr("VLRFIN")
                        End If
                    Next
                    tabla2.Rows(tabla2.Rows.Count - 1).Item("STOCK_PROM") = Math.Round((pProm / Date.Now.Month), 2)

                End If

                tabla2.AcceptChanges()
            Next
            i = i + drSelect.Length - 1
            pProm = 0
        Next
        'codigo agregado 30/06/2011
        tablafinal = New DataTable
        tablafinal.Columns.Add(New DataColumn("CMRCLR", GetType(String)))
        tablafinal.Columns.Add(New DataColumn("TMRCD2", GetType(String)))
        tablafinal.Columns.Add(New DataColumn("STOCK_INI", GetType(String)))
        For i As Integer = 1 To 12
            tablafinal.Columns.Add(New DataColumn("INGRESOS_" + i.ToString.PadLeft(2, "0"), GetType(String)))
            tablafinal.Columns.Add(New DataColumn("DESPACHO_" + i.ToString.PadLeft(2, "0"), GetType(String)))
            tablafinal.Columns.Add(New DataColumn("STOCK_" + i.ToString.PadLeft(2, "0"), GetType(String)))
        Next

        tablafinal.Columns.Add(New DataColumn("STOCK_FIN", GetType(String)))
        tablafinal.Columns.Add(New DataColumn("STOCK_PROM", GetType(String)))

        tablafinal.Columns.Add(New DataColumn("SUMA_ING", GetType(String)))
        tablafinal.Columns.Add(New DataColumn("SUMA_DES", GetType(String)))

        tablafinal.Columns.Add(New DataColumn("PORCENTAJE", GetType(Decimal)))

        Dim tablaauxiliar As New DataTable
        tablaauxiliar = tabla2
        Dim sumaing As Double = 0
        Dim sumades As Double = 0
        Dim porcentaje As Double = 0
        Dim nCount = 0
        For Each row As DataRow In tablaauxiliar.Rows
            sumaing = 0
            sumades = 0
            porcentaje = 0
            For intColum As Integer = 1 To 12
                sumaing = sumaing + Val("" & row("INGRESOS_" & intColum.ToString.PadLeft(2, "0")) & "")
                sumades = sumades + Val("" & row("DESPACHO_" & intColum.ToString.PadLeft(2, "0")) & "")

            Next
            If sumaing <> 0 Then
                porcentaje = (sumades * 100) / sumaing
            Else
                porcentaje = (sumades * 100) / 100
            End If
            'sumaing = Convert.ToDouble(Val("" & row("INGRESOS_01") & "")) + Convert.ToDouble(Val("" & row("INGRESOS_02") & "")) + Convert.ToDouble(Val("" & row("INGRESOS_03") & "")) + Convert.ToDouble(val(""& row("INGRESOS_04") & "")) + Convert.ToDouble(val( "" & row("INGRESOS_05") & "")) + Convert.ToDouble(val ( "" & row("INGRESOS_06") & "")) + Convert.ToDouble( val( "row("INGRESOS_07")) + Convert.ToDouble(row("INGRESOS_08")) + Convert.ToDouble(row("INGRESOS_09")) + Convert.ToDouble(row("INGRESOS_10")) + Convert.ToDouble(row("INGRESOS_11")) + Convert.ToDouble(row("INGRESOS_12"))
            'sumades = Convert.ToDouble(row("DESPACHO_01")) + Convert.ToDouble(row("DESPACHO_02")) + Convert.ToDouble(row("DESPACHO_03")) + Convert.ToDouble(row("DESPACHO_04")) + Convert.ToDouble(row("DESPACHO_05")) + Convert.ToDouble(row("DESPACHO_06")) + Convert.ToDouble(row("DESPACHO_07")) + Convert.ToDouble(row("DESPACHO_08")) + Convert.ToDouble(row("DESPACHO_09")) + Convert.ToDouble(row("DESPACHO_10")) + Convert.ToDouble(row("DESPACHO_11")) + Convert.ToDouble(row("DESPACHO_12"))
            ' sumaing = Convert.ToDouble(row("INGRESOS_01")) + Convert.ToDouble(row("INGRESOS_02"))
            Dim newrow As DataRow
            newrow = tablafinal.NewRow

            Try

            
                newrow("CMRCLR") = row("CMRCLR")
                newrow("TMRCD2") = row("TMRCD2")
                newrow("STOCK_INI") = row("STOCK_INI")

                If row("INGRESOS_01") Is DBNull.Value Then
                    newrow("INGRESOS_01") = ""
                Else
                    If row("INGRESOS_01") = "0" Then
                        newrow("INGRESOS_01") = ""
                    Else
                        newrow("INGRESOS_01") = row("INGRESOS_01")
                    End If
                End If

                If row("DESPACHO_01") Is DBNull.Value Then
                    newrow("DESPACHO_01") = ""
                Else
                    If row("DESPACHO_01") = "0" Then
                        newrow("DESPACHO_01") = ""
                    Else
                        newrow("DESPACHO_01") = row("DESPACHO_01")
                    End If
                End If
                If row("STOCK_01") Is DBNull.Value Then
                    newrow("STOCK_01") = ""
                Else
                    If row("STOCK_01") = "0" Then
                        newrow("STOCK_01") = ""
                    Else
                        newrow("STOCK_01") = row("STOCK_01")
                    End If
                End If



                If row("INGRESOS_02") Is DBNull.Value Then
                    newrow("INGRESOS_02") = ""
                Else
                    If row("INGRESOS_02") = "0" Then
                        newrow("INGRESOS_02") = ""
                    Else
                        newrow("INGRESOS_02") = row("INGRESOS_02")
                    End If
                End If

                If row("DESPACHO_02") Is DBNull.Value Then
                    newrow("DESPACHO_02") = ""
                Else
                    If row("DESPACHO_02") = "0" Then
                        newrow("DESPACHO_02") = ""
                    Else
                        newrow("DESPACHO_02") = row("DESPACHO_02")
                    End If
                End If
                If row("STOCK_02") Is DBNull.Value Then
                    newrow("STOCK_02") = ""
                Else
                    If row("STOCK_02") = "0" Then
                        newrow("STOCK_02") = ""
                    Else
                        newrow("STOCK_02") = row("STOCK_02")
                    End If
                End If

                'newrow("INGRESOS_03") = IIf(row("INGRESOS_03") Is Convert.DBNull, "", IIf(row("INGRESOS_03") = "0", "", row("INGRESOS_03")))

                If row("INGRESOS_03") Is DBNull.Value Then
                    newrow("INGRESOS_03") = ""
                Else
                    If row("INGRESOS_03") = "0" Then
                        newrow("INGRESOS_03") = ""
                    Else
                        newrow("INGRESOS_03") = row("INGRESOS_03")
                    End If
                End If

                If row("DESPACHO_03") Is DBNull.Value Then
                    newrow("DESPACHO_03") = ""
                Else
                    If row("DESPACHO_03") = "0" Then
                        newrow("DESPACHO_03") = ""
                    Else
                        newrow("DESPACHO_03") = row("DESPACHO_03")
                    End If
                End If
                If row("STOCK_03") Is DBNull.Value Then
                    newrow("STOCK_03") = ""
                Else
                    If row("STOCK_03") = "0" Then
                        newrow("STOCK_03") = ""
                    Else
                        newrow("STOCK_03") = row("STOCK_03")
                    End If
                End If


                If row("INGRESOS_04") Is DBNull.Value Then
                    newrow("INGRESOS_04") = ""
                Else
                    If row("INGRESOS_04") = "0" Then
                        newrow("INGRESOS_04") = ""
                    Else
                        newrow("INGRESOS_04") = row("INGRESOS_04")
                    End If
                End If

                If row("DESPACHO_04") Is DBNull.Value Then
                    newrow("DESPACHO_04") = ""
                Else
                    If row("DESPACHO_04") = "0" Then
                        newrow("DESPACHO_04") = ""
                    Else
                        newrow("DESPACHO_04") = row("DESPACHO_04")
                    End If
                End If
                If row("STOCK_04") Is DBNull.Value Then
                    newrow("STOCK_04") = ""
                Else
                    If row("STOCK_04") = "0" Then
                        newrow("STOCK_04") = ""
                    Else
                        newrow("STOCK_04") = row("STOCK_04")
                    End If
                End If



                If row("INGRESOS_05") Is DBNull.Value Then
                    newrow("INGRESOS_05") = ""
                Else
                    If row("INGRESOS_05") = "0" Then
                        newrow("INGRESOS_05") = ""
                    Else
                        newrow("INGRESOS_05") = row("INGRESOS_04")
                    End If
                End If


                If row("DESPACHO_05") Is DBNull.Value Then
                    newrow("DESPACHO_05") = ""
                Else
                    If row("DESPACHO_05") = "0" Then
                        newrow("DESPACHO_05") = ""
                    Else
                        newrow("DESPACHO_05") = row("DESPACHO_05")
                    End If
                End If
                If row("STOCK_05") Is DBNull.Value Then
                    newrow("STOCK_05") = ""
                Else
                    If row("STOCK_05") = "0" Then
                        newrow("STOCK_05") = ""
                    Else
                        newrow("STOCK_05") = row("STOCK_05")
                    End If
                End If


                If row("INGRESOS_06") Is DBNull.Value Then
                    newrow("INGRESOS_06") = ""
                Else
                    If row("INGRESOS_06") = "0" Then
                        newrow("INGRESOS_06") = ""
                    Else
                        newrow("INGRESOS_06") = row("INGRESOS_06")
                    End If
                End If
                If row("DESPACHO_06") Is DBNull.Value Then
                    newrow("DESPACHO_06") = ""
                Else
                    If row("DESPACHO_06") = "0" Then
                        newrow("DESPACHO_06") = ""
                    Else
                        newrow("DESPACHO_06") = row("DESPACHO_06")
                    End If
                End If
                If row("STOCK_06") Is DBNull.Value Then
                    newrow("STOCK_06") = ""
                Else
                    If row("STOCK_06") = "0" Then
                        newrow("STOCK_06") = ""
                    Else
                        newrow("STOCK_06") = row("STOCK_06")
                    End If
                End If


                If row("INGRESOS_07") Is DBNull.Value Then
                    newrow("INGRESOS_07") = ""
                Else
                    If row("INGRESOS_07") = "0" Then
                        newrow("INGRESOS_07") = ""
                    Else
                        newrow("INGRESOS_07") = row("INGRESOS_07")
                    End If
                End If

                If row("DESPACHO_07") Is DBNull.Value Then
                    newrow("DESPACHO_07") = ""
                Else
                    If row("DESPACHO_07") = "0" Then
                        newrow("DESPACHO_07") = ""
                    Else
                        newrow("DESPACHO_07") = row("DESPACHO_07")
                    End If
                End If
                If row("STOCK_07") Is DBNull.Value Then
                    newrow("STOCK_07") = ""
                Else
                    If row("STOCK_07") = "0" Then
                        newrow("STOCK_07") = ""
                    Else
                        newrow("STOCK_07") = row("STOCK_07")
                    End If
                End If


                If row("INGRESOS_08") Is DBNull.Value Then
                    newrow("INGRESOS_08") = ""
                Else
                    If row("INGRESOS_08") = "0" Then
                        newrow("INGRESOS_08") = ""
                    Else
                        newrow("INGRESOS_08") = row("INGRESOS_08")
                    End If
                End If

                If row("DESPACHO_08") Is DBNull.Value Then
                    newrow("DESPACHO_08") = ""
                Else
                    If row("DESPACHO_08") = "0" Then
                        newrow("DESPACHO_08") = ""
                    Else
                        newrow("DESPACHO_08") = row("DESPACHO_08")
                    End If
                End If
                If row("STOCK_08") Is DBNull.Value Then
                    newrow("STOCK_08") = ""
                Else
                    If row("STOCK_08") = "0" Then
                        newrow("STOCK_08") = ""
                    Else
                        newrow("STOCK_08") = row("STOCK_08")
                    End If
                End If


                If row("INGRESOS_09") Is DBNull.Value Then
                    newrow("INGRESOS_09") = ""
                Else
                    If row("INGRESOS_09") = "0" Then
                        newrow("INGRESOS_09") = ""
                    Else
                        newrow("INGRESOS_09") = row("INGRESOS_09")
                    End If
                End If

                If row("DESPACHO_09") Is DBNull.Value Then
                    newrow("DESPACHO_09") = ""
                Else
                    If row("DESPACHO_09") = "0" Then
                        newrow("DESPACHO_09") = ""
                    Else
                        newrow("DESPACHO_09") = row("DESPACHO_09")
                    End If
                End If
                If row("STOCK_09") Is DBNull.Value Then
                    newrow("STOCK_09") = ""
                Else
                    If row("STOCK_09") = "0" Then
                        newrow("STOCK_09") = ""
                    Else
                        newrow("STOCK_09") = row("STOCK_09")
                    End If
                End If


                If row("INGRESOS_10") Is DBNull.Value Then
                    newrow("INGRESOS_10") = ""
                Else
                    If row("INGRESOS_10") = "0" Then
                        newrow("INGRESOS_10") = ""
                    Else
                        newrow("INGRESOS_10") = row("INGRESOS_10")
                    End If
                End If

                If row("DESPACHO_10") Is DBNull.Value Then
                    newrow("DESPACHO_10") = ""
                Else
                    If row("DESPACHO_10") = "0" Then
                        newrow("DESPACHO_10") = ""
                    Else
                        newrow("DESPACHO_10") = row("DESPACHO_10")
                    End If
                End If
                If row("STOCK_10") Is DBNull.Value Then
                    newrow("STOCK_10") = ""
                Else
                    If row("STOCK_10") = "0" Then
                        newrow("STOCK_10") = ""
                    Else
                        newrow("STOCK_10") = row("STOCK_10")
                    End If
                End If


                If row("INGRESOS_11") Is DBNull.Value Then
                    newrow("INGRESOS_11") = ""
                Else
                    If row("INGRESOS_11") = "0" Then
                        newrow("INGRESOS_11") = ""
                    Else
                        newrow("INGRESOS_11") = row("INGRESOS_11")
                    End If
                End If

                If row("DESPACHO_11") Is DBNull.Value Then
                    newrow("DESPACHO_11") = ""
                Else
                    If row("DESPACHO_11") = "0" Then
                        newrow("DESPACHO_11") = ""
                    Else
                        newrow("DESPACHO_11") = row("DESPACHO_11")
                    End If
                End If
                If row("STOCK_11") Is DBNull.Value Then
                    newrow("STOCK_11") = ""
                Else
                    If row("STOCK_11") = "0" Then
                        newrow("STOCK_11") = ""
                    Else
                        newrow("STOCK_11") = row("STOCK_11")
                    End If
                End If


                If row("INGRESOS_12") Is DBNull.Value Then
                    newrow("INGRESOS_12") = ""
                Else
                    If row("INGRESOS_12") = "0" Then
                        newrow("INGRESOS_12") = ""
                    Else
                        newrow("INGRESOS_12") = row("INGRESOS_12")
                    End If
                End If

                If row("DESPACHO_12") Is DBNull.Value Then
                    newrow("DESPACHO_12") = ""
                Else
                    If row("DESPACHO_12") = "0" Then
                        newrow("DESPACHO_12") = ""
                    Else
                        newrow("DESPACHO_12") = row("DESPACHO_12")
                    End If
                End If
                If row("STOCK_12") Is DBNull.Value Then
                    newrow("STOCK_12") = ""
                Else
                    If row("STOCK_12") = "0" Then
                        newrow("STOCK_12") = ""
                    Else
                        newrow("STOCK_12") = row("STOCK_12")
                    End If
                End If


                newrow("STOCK_FIN") = row("STOCK_FIN")
                newrow("STOCK_PROM") = row("STOCK_PROM")

                newrow("SUMA_ING") = IIf(sumaing = 0, "", sumaing)
                newrow("SUMA_DES") = iif( sumades=0,"",sumades)
                newrow("PORCENTAJE") = porcentaje


                tablafinal.Rows.Add(newrow)
                nCount = nCount + 1
            Catch ex As Exception
                MessageBox.Show(nCount.ToString)
            End Try

        Next


        Dim DtView As New DataView
        DtView = tablafinal.DefaultView
        DtView.Sort = "PORCENTAJE  Desc"
        tablafinal = DtView.ToTable

        objrptRotacion.SetDataSource(tablafinal)
        crParameterFieldDefinitions = objrptRotacion.DataDefinition.ParameterFields
        crParameterFieldLocation = crParameterFieldDefinitions.Item("Cliente")
        crParameterValues = crParameterFieldLocation.CurrentValues
        crParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        crParameterDiscreteValue.Value = Convert.ToString(txtCliente.pRazonSocial)
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldLocation.ApplyCurrentValues(crParameterValues)

        crParameterFieldDefinitions = objrptRotacion.DataDefinition.ParameterFields
        crParameterFieldLocation = crParameterFieldDefinitions.Item("CodigoCliente")
        crParameterValues = crParameterFieldLocation.CurrentValues
        crParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        crParameterDiscreteValue.Value = Convert.ToString(txtCliente.pCodigo)
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldLocation.ApplyCurrentValues(crParameterValues)

        crParameterFieldDefinitions = objrptRotacion.DataDefinition.ParameterFields
        crParameterFieldLocation = crParameterFieldDefinitions.Item("Anio")
        crParameterValues = crParameterFieldLocation.CurrentValues
        crParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        crParameterDiscreteValue.Value = pnAnio
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldLocation.ApplyCurrentValues(crParameterValues)

        crParameterFieldDefinitions = objrptRotacion.DataDefinition.ParameterFields
        crParameterFieldLocation = crParameterFieldDefinitions.Item("Usuario")
        crParameterValues = crParameterFieldLocation.CurrentValues
        crParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        crParameterDiscreteValue.Value = objSeguridadBN.pUsuario
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldLocation.ApplyCurrentValues(crParameterValues)


        objTemp = New TipoDato_ResultaReporte
        objTemp.pReporte = objrptRotacion


        'crvReporte.ReportSource = objrptRotacion


    End Sub

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click

        Dim strMensajeError As String = String.Empty
        If txtCliente.pCodigo = 0 Then
            strMensajeError = "Debe seleccionar un Cliente. "
            'MsgBox(ex.Message, "Aviso de sistema")
            MessageBox.Show(strMensajeError, "Aviso de sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            txtCliente.Focus()
            Exit Sub
        End If

        If txtAnio.Text.Length = 0 Then
            strMensajeError = "Ingrese Año. "
            MessageBox.Show(strMensajeError, "Aviso de sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            txtAnio.Focus()
            Exit Sub
        End If





        pcxEspera.Visible = True
        pcxEspera.Left = (HGReporte.Width / 2) - (pcxEspera.Width / 2)
        pcxEspera.Top = (HGReporte.Height / 2) - (pcxEspera.Height / 2)
        crvReporte.Visible = False

        tsbExportarPDF.Enabled = False
        tsbEnviarCorreo.Enabled = False
        tsbExportarExcel.Enabled = False



        pnCliente = Me.txtCliente.pCodigo
        pnAnio = txtAnio.Text

        bgwGifAnimado.RunWorkerAsync()


    End Sub

 

    Private Sub filldatatable()

    End Sub

    Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarExcel.Click
        exportarexcel()
    End Sub
    Private Sub exportarexcel()
        Dim dtExcel As New DataTable
        Dim objDsExcel As New DataSet
        dtExcel = tablafinal.Copy

        dtExcel.Columns("CMRCLR").ColumnName = "CODIGO"
        dtExcel.Columns("TMRCD2").ColumnName = "DESCRIPCION"
        dtExcel.Columns("STOCK_INI").ColumnName = ("STOCK INICIAL")
        dtExcel.Columns("INGRESOS_01").ColumnName = "ENERO \n INGRESO "
        dtExcel.Columns("DESPACHO_01").ColumnName = "ENERO \n DESPACHO "
        dtExcel.Columns("STOCK_01").ColumnName = "ENERO \n STOCK "
        dtExcel.Columns("INGRESOS_02").ColumnName = "FEBRERO \n INGRESO "
        dtExcel.Columns("DESPACHO_02").ColumnName = "FEBRERO \n DESPACHO "
        dtExcel.Columns("STOCK_02").ColumnName = "FEBRERO \n STOCK"
        dtExcel.Columns("INGRESOS_03").ColumnName = "MARZO \n INGRESO "
        dtExcel.Columns("DESPACHO_03").ColumnName = "MARZO \n DESPACHO "
        dtExcel.Columns("STOCK_03").ColumnName = "MARZO \n STOCK"
        dtExcel.Columns("INGRESOS_04").ColumnName = "ABRIL \n INGRESO "
        dtExcel.Columns("DESPACHO_04").ColumnName = "ABRIL \n DESPACHO "
        dtExcel.Columns("STOCK_04").ColumnName = "ABRIL \n STOCK"
        dtExcel.Columns("INGRESOS_05").ColumnName = "MAYO \n INGRESO "
        dtExcel.Columns("DESPACHO_05").ColumnName = "MAYO \n DESPACHO "
        dtExcel.Columns("STOCK_05").ColumnName = "MAYO \n STOCK"
        dtExcel.Columns("INGRESOS_06").ColumnName = "JUNIO \n INGRESO "
        dtExcel.Columns("DESPACHO_06").ColumnName = "JUNIO \n DESPACHO "
        dtExcel.Columns("STOCK_06").ColumnName = "JUNIO \n STOCK"
        dtExcel.Columns("INGRESOS_07").ColumnName = "JULIO \n INGRESO "
        dtExcel.Columns("DESPACHO_07").ColumnName = "JULIO \n DESPACHO "
        dtExcel.Columns("STOCK_07").ColumnName = "JULIO \n STOCK"
        dtExcel.Columns("INGRESOS_08").ColumnName = "AGOSTO \n INGRESO "
        dtExcel.Columns("DESPACHO_08").ColumnName = "AGOSTO \n DESPACHO "
        dtExcel.Columns("STOCK_08").ColumnName = "AGOSTO \n STOCK"
        dtExcel.Columns("INGRESOS_09").ColumnName = "SETIEMBRE \n INGRESO "
        dtExcel.Columns("DESPACHO_09").ColumnName = "SETIEMBRE \n DESPACHO "
        dtExcel.Columns("STOCK_09").ColumnName = "SETIEMBRE \n STOCK"
        dtExcel.Columns("INGRESOS_10").ColumnName = "OCTUBRE \n INGRESO "
        dtExcel.Columns("DESPACHO_10").ColumnName = "OCTUBRE \n DESPACHO "
        dtExcel.Columns("STOCK_10").ColumnName = "OCTUBRE \n STOCK"
        dtExcel.Columns("INGRESOS_11").ColumnName = "NOVIEMBRE \n INGRESO "
        dtExcel.Columns("DESPACHO_11").ColumnName = "NOVIEMBRE \n DESPACHO"
        dtExcel.Columns("STOCK_11").ColumnName = "NOVIEMBRE \n STOCK "
        dtExcel.Columns("INGRESOS_12").ColumnName = "DICIEMBRE  \n INGRESO "
        dtExcel.Columns("DESPACHO_12").ColumnName = "DICIEMBRE  \n DESPACHO "
        dtExcel.Columns("STOCK_12").ColumnName = "DICIEMBRE  \n STOCK "

        dtExcel.Columns("STOCK_FIN").ColumnName = ("STOCK FINAL")
        dtExcel.Columns("STOCK_PROM").ColumnName = ("STOCK PROMEDIO")

        dtExcel.Columns("SUMA_ING").ColumnName = "TOTAL  \n INGRESO "
        dtExcel.Columns("SUMA_DES").ColumnName = "TOTAL  \n DESPACHO "



        objDsExcel.Tables.Add(dtExcel)
        dtExcel.TableName = "Rotacion Mensual"
        Dim strlTitulo As New List(Of String)
        strlTitulo.Add("Cliente :\n" & IIf(Me.txtCliente.pCodigo = 0, "TODOS", Me.txtCliente.pCodigo & " - " & Me.txtCliente.pRazonSocial))
        strlTitulo.Add("Año :\n" & txtAnio.Text)
        HelpClass.ExportExcelConTitulos(objDsExcel, Me.Text, strlTitulo)

    End Sub

    Private Sub crvReporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub crvReporte_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub bgwGifAnimado_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwGifAnimado.DoWork
        Call pGeneraReporte()
    End Sub

    Private Sub bgwGifAnimado_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwGifAnimado.RunWorkerCompleted

        pcxEspera.Visible = False
        tsbExportarExcel.Enabled = True
        crvReporte.Visible = True
        crvReporte.ReportSource = objTemp.pReporte

    End Sub

    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Me.Close()

    End Sub
End Class