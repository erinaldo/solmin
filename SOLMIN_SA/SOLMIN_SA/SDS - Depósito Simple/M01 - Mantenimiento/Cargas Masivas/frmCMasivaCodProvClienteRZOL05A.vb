Imports System.IO
Imports RANSA.Utilitario
Imports RANSA.NEGO
Public Class frmCMasivaCodProvClienteRZOL05A



    Private UltimaRuta As String = ""
    Private dtCarga_Prov As New DataTable
    Public Procesamiento As Boolean = False
    Public pCodCliente As Decimal = 0
    Public pDialog As Boolean = False
    Private oLisHashtProv As New Hashtable
    Private Sub btnCargaArchivo_Click(sender As Object, e As EventArgs) Handles btnCargaArchivo.Click

        CargaFormato_Proveedor()
        



    End Sub
    Private Sub CargaFormato_Proveedor()
        Dim obj_Excel As Object
        Dim obj_Workbook As Object
        Dim obj_Worksheet As Object

        Try
            Dim obj_SheetName As String
            Dim oUtil As New mUtilEstructura
            Dim openFileDialog1 As New OpenFileDialog()
            Dim fileName As String = ""
            Dim source As String = ""
            Dim extension As String = ""

            openFileDialog1.Multiselect = False
            If UltimaRuta = "" Then
                openFileDialog1.InitialDirectory = (System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal))
            Else
                openFileDialog1.InitialDirectory = UltimaRuta
            End If

            openFileDialog1.Filter = "Excel Files (*.XLS;*.CSV;)|*.XLS;*.CSV;|All files (*.*)|*.*"

            If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                fileName = openFileDialog1.FileName
                extension = Path.GetExtension(openFileDialog1.FileName)
                source = Path.GetFileNameWithoutExtension(openFileDialog1.FileName)
                UltimaRuta = Path.GetDirectoryName(openFileDialog1.FileName)
            Else
                Exit Sub
            End If


            If Len(Dir(fileName)) = 0 Then
                MsgBox("No se ha encontrado el archivo: " & fileName, vbCritical)
                Exit Sub
            End If
            '===================================================================
            ' -- RUTINA EXCEL   Instancia Excel  
            If obj_Excel Is Nothing Then
                obj_Excel = CreateObject("Excel.Application")
                obj_Workbook = obj_Excel.Workbooks.Open(fileName)
            End If




            ' -- Referencia la Hoja, por defecto la hoja activa  
            If obj_SheetName = vbNullString Then
                obj_Worksheet = obj_Workbook.ActiveSheet
            Else
                obj_Worksheet = obj_Workbook.Sheets(obj_SheetName)
            End If



            Dim i As Integer
            Dim NumSheets As Integer
            Dim NomSheets As String

            NumSheets = obj_Workbook.sheets.count()
            For i = 1 To NumSheets
                NomSheets = obj_Workbook.Sheets.Item(i).Name
            Next

            Dim MaxReg As Int64 = 65536


            dtCarga_Prov.Columns.Clear()
            dtCarga_Prov.Rows.Clear()

            Dim PosExcel As New Hashtable

            dtCarga_Prov.Columns.Add("RUC")
            dtCarga_Prov.Columns.Add("CODIGO_PROV_CLIENTE")
             


            Dim dtListaRegla As New DataTable
            dtListaRegla = AsignarReglaValidacionCarga_Proveedor()



            Dim ListadoValidacion As New List(Of String)
            Dim NombreColumna As String = ""
            For ColIndex As Integer = 0 To dtCarga_Prov.Columns.Count - 1
                NombreColumna = dtCarga_Prov.Columns(ColIndex).ColumnName
                PosExcel(NombreColumna) = ColIndex + 1
                ListadoValidacion.Add(NombreColumna)
            Next


            Dim FilaRegFormato As Integer = 3
            Dim CeldaColumnaExcel As String = ""
            Dim CeldaColumnaFormato As String = ""
            Dim FormatoOK As Boolean = True
            Dim msgEncontrado As String = ""
            Dim PosCol As Int64 = 0
            Try
                For ColIndex As Integer = 0 To dtCarga_Prov.Columns.Count - 1
                    CeldaColumnaFormato = dtCarga_Prov.Columns(ColIndex).ColumnName
                    PosCol = PosExcel(CeldaColumnaFormato)
                    CeldaColumnaExcel = ("" & obj_Worksheet.Cells(FilaRegFormato, PosCol).Value).ToString.Trim
                    If CeldaColumnaFormato <> CeldaColumnaExcel Then
                        FormatoOK = False
                        Exit For
                    End If
                Next
            Catch ex As Exception
                FormatoOK = False
                msgEncontrado = ex.Message
            End Try


            If FormatoOK = False Then

                Dim muestrMensaje As String = "Estructura no válida"
                If msgEncontrado.Length > 0 Then
                    muestrMensaje = muestrMensaje & Chr(10) & msgEncontrado

                End If
                MessageBox.Show(muestrMensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            dtCarga_Prov.Columns.Add("OBS_CARGA")
            dtCarga_Prov.Columns.Add("OBS_REGISTRO")

            Dim InicioFilaReg As Int64 = FilaRegFormato + 1
            Dim CeldaValor As String = ""
            Dim msg_carga_validacion As String = ""
            Dim msg_carga As String = ""

            Dim drReg As DataRow



            Dim dtUbicacion As New DataTable
            Dim oListCliente As New Hashtable
            Dim RUC_Proveedor As String = ""


            Dim obr As New brPlantaClienteProveedor()

            For i = InicioFilaReg To MaxReg
                msg_carga_validacion = ""
                CeldaValor = ("" & obj_Worksheet.Cells(i, PosExcel("RUC")).Value).ToString.Trim

                If CeldaValor = "" Then
                    Exit For
                End If
                drReg = dtCarga_Prov.NewRow

                For Each item As String In ListadoValidacion
                    CeldaValor = ("" & obj_Worksheet.Cells(i, PosExcel(item)).Value).ToString.Trim
                    msg_carga = oUtil.ValidarEstructuraColumna(dtListaRegla, item, CeldaValor)
                    If msg_carga <> "" Then msg_carga_validacion = msg_carga_validacion & msg_carga
                    drReg(item) = CeldaValor
                Next
                msg_carga_validacion = msg_carga_validacion.Trim


                RUC_Proveedor = ("" & obj_Worksheet.Cells(i, PosExcel("RUC")).Value).ToString.Trim
                If Not oLisHashtProv.Contains(RUC_Proveedor) Then
                    Dim msgValidacion As String = ""
                    msgValidacion = obr.ValidarRUCProveedor_Cmasivo_RZOL05A(RUC_Proveedor)
                    oLisHashtProv(RUC_Proveedor) = msgValidacion
                Else
                    msg_carga_validacion = oLisHashtProv(RUC_Proveedor)
                End If

                If msg_carga_validacion = "" Then
                    msg_carga_validacion = "OK"
                End If
                drReg("OBS_CARGA") = msg_carga_validacion
                dtCarga_Prov.Rows.Add(drReg)
            Next


            If obj_Workbook IsNot Nothing Then
                obj_Workbook.close()
            End If
            If obj_Excel IsNot Nothing Then
                obj_Excel.quit()
            End If
            dgvCargaProv.DataSource = dtCarga_Prov


        Catch ex As Exception

            If obj_Workbook IsNot Nothing Then
                obj_Workbook.close()
            End If
            If obj_Excel IsNot Nothing Then
                obj_Excel.quit()
            End If
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try




    End Sub

    Private Function AsignarReglaValidacionCarga_Proveedor() As DataTable
        Dim dtReglaValidacion As New DataTable
        Dim oUtil As New mUtilEstructura
        dtReglaValidacion = oUtil.EstructuraValidacionColumna

        Dim drRV As DataRow



        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "RUC"
        drRV("ENTEROS") = 15
        drRV("DECIMALES") = 15
        drRV("TIPO_DATO") = mUtilEstructura.TipoDato.NUMERICO.ToString
        drRV("OBLIGATORIEDAD") = "S"
        dtReglaValidacion.Rows.Add(drRV)


        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "CODIGO_PROV_CLIENTE"
        drRV("MAX_LONGITUD") = 15
        drRV("OBLIGATORIEDAD") = "S"
        drRV("TIPO_DATO") = mUtilEstructura.TipoDato.ALFANUMERICO.ToString
        dtReglaValidacion.Rows.Add(drRV)



        


        

        Return dtReglaValidacion
    End Function



    Private Sub btnexportar_Click(sender As Object, e As EventArgs) Handles btnexportar.Click
        Try
            Dim TabSel As String = TabControl1.SelectedTab.Name
            Select Case TabSel

                Case "tpCargaProv"
                    Dim ODs As New DataSet
                    Dim objDt As New DataTable
                    Dim loEncabezados As New Generic.List(Of Encabezados)

                    loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Poisiciones por Cliente"))
                    loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "Posiciones"))
                    loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "Poisiciones por Cliente"))
                    'loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
                    objDt = CType(Me.dgvCargaProv.DataSource, DataTable).Copy
                    ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(dgvCargaProv, objDt))
                    HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)

            End Select


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try
            Dim drError() As DataRow
            If dtCarga_Prov.Rows.Count = 0 Then
                MessageBox.Show("Sin registros a procesar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            drError = dtCarga_Prov.Select("OBS_CARGA <> 'OK'")
            If drError.Length > 0 Then
                MessageBox.Show("Sin registros válidos a procesar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            drError = dtCarga_Prov.Select("OBS_REGISTRO = 'OK'")
            If drError.Length > 0 Then
                MessageBox.Show("Cargue nuevamente.Registros ya procesados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If


            Dim obrGeneral As New brPlantaClienteProveedor

            Dim msgresult As String = ""
            Dim pRucProv As String = ""
            Dim CodProvCliente As String = ""
            For Each item As DataRow In dtCarga_Prov.Rows
                pRucProv = item("RUC")
                CodProvCliente = item("CODIGO_PROV_CLIENTE")
                msgresult = obrGeneral.RegistrarRelacionTercero_Cmasivo_RZOL05A(pCodCliente, pRucProv, CodProvCliente)
                If msgresult = "" Then
                    item("OBS_REGISTRO") = "OK"
                Else
                    item("OBS_REGISTRO") = msgresult
                End If

                pDialog = True
            Next

            dgvCargaProv.DataSource = dtCarga_Prov
            'pDialog = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmCargaMasivaPosicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dgvCargaProv.AutoGenerateColumns = False
         
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class