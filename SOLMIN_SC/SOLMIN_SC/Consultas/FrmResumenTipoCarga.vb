Imports SOLMIN_SC.Negocio
Imports Ransa.Utilitario
Imports SOLMIN_SC.Entidad
Public Class FrmResumenTipoCarga
    Private oListGenTipoCarga As New List(Of beTipoCarga)
    Private Sub FrmResumenTipoCarga_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ToolStripButton1.Visible = False
            Cargar_Compania()
            cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)

            dtgDatos.AutoGenerateColumns = False
            Me.cmbCliente.pAccesoPorUsuario = True
            Me.cmbCliente.pRequerido = True
            Me.cmbCliente.pUsuario = HelpUtil.UserName
            dtpFecIni.Value = Now.AddMonths(-1)
            TipoOperacion()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
  End Sub
    Private Sub TipoOperacion()
        Dim oclsEstado As New clsEstado
        Dim dtTipoOperacion As New DataTable
        dtTipoOperacion = oclsEstado.Listar_TipoOperacionEmbarque
        Dim dr As DataRow
        dr = dtTipoOperacion.NewRow
        dr("COD") = "T"
        dr("TEX") = "TODOS"
        dtTipoOperacion.Rows.InsertAt(dr, 0)
        cboTipoOperacion.DataSource = dtTipoOperacion
        cboTipoOperacion.DisplayMember = "TEX"
        cboTipoOperacion.ValueMember = "COD"
        cboTipoOperacion.SelectedValue = "IM"
        cboTipoOperacion.Enabled = False
    End Sub

    Private Sub Cargar_Compania()
        cmbCompania.Usuario = HelpUtil.UserName
        cmbCompania.CCMPN_CompaniaDefault = "EZ"
        cmbCompania.pActualizar()
    End Sub

    Private Function ListarDatosExportacionOrigen() As DataTable
        Dim MdataColumna As String = ""
        Dim TipoDato As String = ""
        Dim NPOI_SC As New HelpClass_NPOI_SC
        Dim ColName As String = ""
        Dim ColTitle As String = ""
        Dim dtExporOriginal As New DataTable
        For Each Item As DataGridViewColumn In dtgDatos.Columns
            ColTitle = Item.HeaderText.Trim
            ColName = Item.DataPropertyName
            TipoDato = ""
            Select Case ColName
                'NUMEROS
                Case "PNFLETE", "PNVOLUMEN", "PNPESO"
                    TipoDato = NPOI_SC.keyDatoNumero
                    'FECHAS
                Case "PSFECHA_ORDEN"
                    TipoDato = NPOI_SC.keyDatoFecha
                Case Else
                    'TEXTO
                    TipoDato = NPOI_SC.keyDatoTexto
            End Select
            dtExporOriginal.Columns.Add(ColName)
            MdataColumna = NPOI_SC.FormatDato(ColTitle, TipoDato)
            dtExporOriginal.Columns(ColName).Caption = MdataColumna
        Next
        Dim dr As DataRow
        For Fila As Integer = 0 To dtgDatos.Rows.Count - 1
            dr = dtExporOriginal.NewRow
            For Columna As Integer = 0 To dtExporOriginal.Columns.Count - 1
                ColName = dtExporOriginal.Columns(Columna).ColumnName
                If (dtgDatos.Rows(Fila).Cells(ColName).Value IsNot Nothing) Then
                    dr(ColName) = dtgDatos.Rows(Fila).Cells(ColName).FormattedValue
                End If
            Next
            dtExporOriginal.Rows.Add(dr)
        Next
        Return dtExporOriginal
    End Function


    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Try
            If dtgDatos.Rows.Count = 0 Then
                MessageBox.Show("No existen datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim NPOI As New HelpClass_NPOI_SC
            Dim odtExp As New DataTable
            Dim dtExporOriginal As New DataTable
            Dim oclsResumenTipoCarga As New clsResumenTipoCarga

            Dim oListTipoCarga As New List(Of beTipoCarga)
            Dim oCloneList As New CloneObject(Of beTipoCarga)
            oListTipoCarga = oCloneList.CloneListObject(oListGenTipoCarga)
            Dim TITULO As String = ""
            If oListTipoCarga IsNot Nothing OrElse oListTipoCarga.Count > 0 Then
                TITULO = "RESUMEN TIPO CARGA (" & oListTipoCarga(0).PNCCLNT & ") - " & oListTipoCarga(0).PSTCMPCL & " - " & oListTipoCarga(0).PSTMTVBJ
            Else
                TITULO = "RESUMEN TIPO CARGA (" & cmbCliente.pCodigo & ") - " & cmbCliente.pRazonSocial
            End If

            dtExporOriginal = ListarDatosExportacionOrigen()
            'dtExporOriginal.TableName = "T1/Listado Embarque"
            dtExporOriginal.TableName = "Listado Embarque"

            'odtExp = ResumirDatosTipoCarga(oListTipoCarga)
            odtExp = oclsResumenTipoCarga.ResumirDatosTipoCarga(oListTipoCarga)
            'odtExp.TableName = "T2/Resumen Carga"
            odtExp.TableName = "Resumen Carga"
          

            'Dim dsExport As New DataSet
            'dsExport.Tables.Add(dtExporOriginal)
            'dsExport.Tables.Add(odtExp)

            'Dim oLis As New List(Of String)
            'Dim ListTotalizables As New List(Of String)
            'ListTotalizables.Add("AEREO_VALOR")
            'ListTotalizables.Add("MARITIMO_VALOR")
            'ListTotalizables.Add("TERRESTRE_VALOR")
            'ListTotalizables.Add("POSTAL_VALOR")
            'ListTotalizables.Add("FLUVIAL_VALOR")
            'ListTotalizables.Add("SIN_MEDIO_VALOR")
            'ListTotalizables.Add("TOTALGENERAL_VALOR")
            'ListTotalizables.Add("DATOS")


            'Dim oLisParametros As New SortedList
            'oLisParametros(0) = "Desde:|" & dtpFecIni.Value.ToShortDateString & " Hasta " & dtpFecFin.Value.ToShortDateString

            'NPOI.ExportExcelResumenTipoCarga(dsExport, TITULO, 2, ListTotalizables, oLisParametros)

            Dim ListaDatatable As New List(Of DataTable)
            ListaDatatable.Add(dtExporOriginal.Copy)
            ListaDatatable.Add(odtExp.Copy)

            Dim ListTitulo As New List(Of String)
            ListTitulo.Add(TITULO)
            ListTitulo.Add(TITULO)

            Dim LisFiltros As New List(Of SortedList)
            Dim itemSortedList As SortedList

            itemSortedList = New SortedList
            itemSortedList.Add(itemSortedList.Count, "Desde:|" & dtpFecIni.Value.ToShortDateString & " Hasta " & dtpFecFin.Value.ToShortDateString)
            LisFiltros.Add(itemSortedList)

            itemSortedList = New SortedList
            itemSortedList.Add(itemSortedList.Count, "Desde:|" & dtpFecIni.Value.ToShortDateString & " Hasta " & dtpFecFin.Value.ToShortDateString)
            LisFiltros.Add(itemSortedList)

            Dim ListNameCombDuplicado As New List(Of String)
            Dim CombCol As String
            ''INFORMACIÓN GENERAL
            CombCol = "PAIS:PAIS/1|PUERTO:PAIS,PUERTO/1|FORWARDER:PAIS,PUERTO,FORWARDER/1|TIPO_CARGA:PAIS,PUERTO,FORWARDER,TIPO_CARGA/1|MERCADERIA:PAIS,PUERTO,FORWARDER,TIPO_CARGA,MERCADERIA/1"
            ListNameCombDuplicado.Add("")
            ListNameCombDuplicado.Add(CombCol)


            NPOI.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListTitulo, Nothing, LisFiltros, 1, ListNameCombDuplicado)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


   
    Private Function GetCompania() As String
        Return cmbCompania.CCMPN_CodigoCompania
    End Function
    Private Function GetDivision(ByVal CCMPN As String) As String
        If CCMPN = "EZ" Then
            Return HelpClass.getSetting("DivisionEZ")
        Else
            Return ""
        End If
    End Function


    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            If cmbCliente.pCodigo = 0 Then
                MessageBox.Show("Seleccione cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim oclsResumenTipoCarga As New clsResumenTipoCarga
            Dim oclsEmbarque As New clsEmbarque
            Dim FechaIni As Decimal = dtpFecIni.Value.ToString("yyyyMMdd")
            Dim FechaFin As Decimal = dtpFecFin.Value.ToString("yyyyMMdd")
            Dim CCLNT As Decimal = cmbCliente.pCodigo
            Dim CCMPN As String = GetCompania()
      oListGenTipoCarga.Clear()
      Dim Tipo_Operacion As String = cboTipoOperacion.SelectedValue
      If Tipo_Operacion = "0" Then
        Tipo_Operacion = ""
      End If
      'oListGenTipoCarga = oclsEmbarque.ListarEmbarqueTipoCarga(CCMPN, CCLNT, FechaIni, FechaFin)
      oListGenTipoCarga = oclsResumenTipoCarga.ListarEmbarqueTipoCarga(CCMPN, CCLNT, FechaIni, FechaFin, Tipo_Operacion)
      dtgDatos.DataSource = oListGenTipoCarga
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        Dim oDocApertura As New clsDocApertura
        Dim oclsCostoItem As New clsCostoItem
        Dim dtRegularizar As New DataTable
        Dim obeCostoTotalEmbarque As beCostoTotalEmbarque
        dtRegularizar = oDocApertura.ListaEmbarquesRegularizar


        Dim dtCostos As New DataTable
        Dim dr As DataRow
        dtCostos.Columns.Add("CCLNT", Type.GetType("System.Decimal"))
        dtCostos.Columns.Add("NORSCI")
        dtCostos.Columns.Add("CODVAR")
        dtCostos.Columns.Add("CMNDA1", Type.GetType("System.Decimal"))
        dtCostos.Columns.Add("NMONOC")
        dtCostos.Columns.Add("IVLORG", Type.GetType("System.Decimal"))
        dtCostos.Columns.Add("IVLDOL", Type.GetType("System.Decimal"))

        For Each Item As DataRow In dtRegularizar.Rows
            'VALSBT VALDES VALISC VALADP VALICP VALMOR VALRNP
            For Each ItemColumn As DataColumn In dtRegularizar.Columns
                Select Case ItemColumn.ColumnName
                    Case "VALSBT"
                        dr = dtCostos.NewRow
                        dr("CCLNT") = Item("CCLNT")
                        dr("NORSCI") = Item("NORSCI")
                        dr("CODVAR") = "SOBTAS"
                        dr("IVLORG") = Item("VALSBT")
                        dr("IVLDOL") = Item("VALSBT")
                        dr("CMNDA1") = 100
                        dr("NMONOC") = "USD"
                        If Item("VALSBT") > 0 Then
                            dtCostos.Rows.Add(dr)
                        End If
                     
                    Case "VALDES"
                        dr = dtCostos.NewRow
                        dr("CCLNT") = Item("CCLNT")
                        dr("NORSCI") = Item("NORSCI")
                        dr("CODVAR") = "DERESP"
                        dr("IVLORG") = Item("VALDES")
                        dr("IVLDOL") = Item("VALDES")
                        dr("CMNDA1") = 100
                        dr("NMONOC") = "USD"
                        If Item("VALDES") > 0 Then
                            dtCostos.Rows.Add(dr)
                        End If
                      

                    Case "VALISC"
                        dr = dtCostos.NewRow
                        dr("CCLNT") = Item("CCLNT")
                        dr("NORSCI") = Item("NORSCI")
                        dr("CODVAR") = "IMSECO"
                        dr("IVLORG") = Item("VALISC")
                        dr("IVLDOL") = Item("VALISC")
                        dr("CMNDA1") = 100
                        dr("NMONOC") = "USD"
                        If Item("VALISC") > 0 Then
                            dtCostos.Rows.Add(dr)
                        End If

                      

                    Case "VALADP"
                        dr = dtCostos.NewRow
                        dr("CCLNT") = Item("CCLNT")
                        dr("NORSCI") = Item("NORSCI")
                        dr("CODVAR") = "ANTDUM"
                        dr("IVLORG") = Item("VALADP")
                        dr("IVLDOL") = Item("VALADP")
                        dr("CMNDA1") = 100
                        dr("NMONOC") = "USD"
                        If Item("VALADP") > 0 Then
                            dtCostos.Rows.Add(dr)
                        End If

                       

                    Case "VALICP"
                        dr = dtCostos.NewRow
                        dr("CCLNT") = Item("CCLNT")
                        dr("NORSCI") = Item("NORSCI")
                        dr("CODVAR") = "INTCOM"
                        dr("IVLORG") = Item("VALICP")
                        dr("IVLDOL") = Item("VALICP")
                        dr("CMNDA1") = 100
                        dr("NMONOC") = "USD"
                        If Item("VALICP") > 0 Then
                            dtCostos.Rows.Add(dr)
                        End If

                      
                    Case "VALMOR"
                        dr = dtCostos.NewRow
                        dr("CCLNT") = Item("CCLNT")
                        dr("NORSCI") = Item("NORSCI")
                        dr("CODVAR") = "MORA"
                        dr("IVLORG") = Item("VALMOR")
                        dr("IVLDOL") = Item("VALMOR")
                        dr("CMNDA1") = 100
                        dr("NMONOC") = "USD"
                        If Item("VALMOR") > 0 Then
                            dtCostos.Rows.Add(dr)
                        End If





                    Case "VALRNP"
                        dr = dtCostos.NewRow
                        dr("CCLNT") = Item("CCLNT")
                        dr("NORSCI") = Item("NORSCI")
                        dr("CODVAR") = "TASDES"
                        dr("IVLORG") = Item("VALRNP")
                        dr("IVLDOL") = Item("VALRNP")
                        dr("CMNDA1") = 100
                        dr("NMONOC") = "USD"
                         dtCostos.Rows.Add(dr)

                End Select
            Next
        Next

       

        Dim oListConceptosDistribucion As New List(Of String)
        'oListConceptosDistribucion.Add("CIF")
        oListConceptosDistribucion.Add("SOBTAS")
        oListConceptosDistribucion.Add("DERESP")
        oListConceptosDistribucion.Add("IMSECO")
        oListConceptosDistribucion.Add("ANTDUM")
        oListConceptosDistribucion.Add("INTCOM")
        oListConceptosDistribucion.Add("MORA")
        oListConceptosDistribucion.Add("TASDES")


        For Each Item As DataRow In dtCostos.Rows
            obeCostoTotalEmbarque = New beCostoTotalEmbarque
            obeCostoTotalEmbarque.PNNORSCI = Item("NORSCI")
            obeCostoTotalEmbarque.PSCODVAR = Item("CODVAR")
            obeCostoTotalEmbarque.PNIVLORG = Item("IVLORG")
            obeCostoTotalEmbarque.PNIVLDOL = Item("IVLDOL")
            obeCostoTotalEmbarque.PNCMNDA1 = Item("CMNDA1")
            obeCostoTotalEmbarque.PSNMONOC = Item("NMONOC")
            oDocApertura.Guardar_Costos_Totales_Embarque("A", obeCostoTotalEmbarque)


        Next

        For Each Item As DataRow In dtCostos.Rows
            oclsCostoItem.Distribuir_Costos_Ordenes_Embarcadas(Item("CCLNT"), Item("NORSCI"), oListConceptosDistribucion)
        Next




    End Sub
End Class
