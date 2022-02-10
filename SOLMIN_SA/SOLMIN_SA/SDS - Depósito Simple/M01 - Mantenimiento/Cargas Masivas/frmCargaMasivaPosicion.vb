Imports System.IO
Imports RANSA.Utilitario
Imports RANSA.NEGO
Imports RANSA.TypeDef
Public Class frmCargaMasivaPosicion

    'Private obj_Excel As Object
    'Private obj_Workbook As Object
    'Private obj_Worksheet As Object
    'Private obj_SheetName As String
    Private ValidacionCargaAlmacen As Boolean = False
    Private ValidacionCargaUbicacion As Boolean = False


    Public pCliente As Decimal = 0
    Public pCCMPN As String = ""
    'Public pSector As String = ""
    Private UltimaRuta As String = ""
    Private dtCarga_Ubicacion As New DataTable
    Private dtAlmacen As New DataTable

    Public Procesamiento As Boolean = False
    Private Sub btnCargaArchivo_Click(sender As Object, e As EventArgs) Handles btnCargaArchivo.Click
        Try

            CargaFormato_Ubicacion()
        Catch ex As Exception

            MessageBox.Show("Seleccione cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Sub CargaFormato_Ubicacion()

        Dim obj_Excel As Object
        Dim obj_Workbook As Object
        Dim obj_Worksheet As Object
        Dim obj_SheetName As String

        Try
            Dim oUtil As New mUtilEstructura
            Dim oValida As New ValidarCaracterEspeciales
            If pCliente = 0 Then
                MessageBox.Show("Seleccione cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

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


            dtCarga_Ubicacion.Columns.Clear()
            dtCarga_Ubicacion.Rows.Clear()

            Dim PosExcel As New Hashtable

            dtCarga_Ubicacion.Columns.Add("TIPO_ALMACEN")
            dtCarga_Ubicacion.Columns.Add("ALMACEN")
            dtCarga_Ubicacion.Columns.Add("ZONA")
            dtCarga_Ubicacion.Columns.Add("UBICACION")


            Dim dtListaRegla As New DataTable
            dtListaRegla = AsignarReglaValidacionCarga_Ubicacion()



            Dim ListadoValidacion As New List(Of String)
            Dim NombreColumna As String = ""
            For ColIndex As Integer = 0 To dtCarga_Ubicacion.Columns.Count - 1
                NombreColumna = dtCarga_Ubicacion.Columns(ColIndex).ColumnName
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
                For ColIndex As Integer = 0 To dtCarga_Ubicacion.Columns.Count - 1
                    CeldaColumnaFormato = dtCarga_Ubicacion.Columns(ColIndex).ColumnName
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





            dtCarga_Ubicacion.Columns.Add("OBS_CARGA")
            dtCarga_Ubicacion.Columns.Add("OBS_REGISTRO")


            Dim InicioFilaReg As Int64 = FilaRegFormato + 1
            Dim CeldaValor As String = ""
            Dim msg_carga_validacion As String = ""
            Dim msg_carga As String = ""

            Dim drReg As DataRow
            Dim drExiste() As DataRow

            Dim CodTipoAlm As String = ""
            Dim CodAlm As String = ""
            Dim CodZona As String = ""
            Dim Posicion As String = ""


            Dim dtUbicacion As New DataTable


            For i = InicioFilaReg To MaxReg
                msg_carga_validacion = ""
                CeldaValor = ("" & obj_Worksheet.Cells(i, PosExcel("TIPO_ALMACEN")).Value).ToString.Trim
                If CeldaValor = "" Then
                    Exit For
                End If
                drReg = dtCarga_Ubicacion.NewRow

                For Each item As String In ListadoValidacion
                    CeldaValor = ("" & obj_Worksheet.Cells(i, PosExcel(item)).Value).ToString.Trim
                    msg_carga = oUtil.ValidarEstructuraColumna(dtListaRegla, item, CeldaValor)
                    If msg_carga <> "" Then msg_carga_validacion = msg_carga_validacion & msg_carga
                    drReg(item) = CeldaValor
                Next
                msg_carga_validacion = msg_carga_validacion.Trim


                CodTipoAlm = ("" & obj_Worksheet.Cells(i, PosExcel("TIPO_ALMACEN")).Value).ToString.Trim
                CodAlm = ("" & obj_Worksheet.Cells(i, PosExcel("ALMACEN")).Value).ToString.Trim
                CodZona = ("" & obj_Worksheet.Cells(i, PosExcel("ZONA")).Value).ToString.Trim
                Posicion = ("" & obj_Worksheet.Cells(i, PosExcel("UBICACION")).Value).ToString.Trim

                drExiste = dtAlmacen.Select("CTPALM = '" & CodTipoAlm & "' AND CALMC = '" & CodAlm & "' AND CZNALM = '" & CodZona & "'")
                If drExiste.Length = 0 Then
                    msg_carga_validacion = msg_carga_validacion & Chr(10) & " No existe(Tipo/Almacén/Zona)"
                End If

                msg_carga_validacion = msg_carga_validacion.Trim

                If msg_carga_validacion = "" Then

                    Dim obrUbicacion As New brUbicacion
                    Dim obeUbicacion As New beUbicacion
                    obeUbicacion.PSCCMPN = pCCMPN
                    obeUbicacion.PNCCLNT = pCliente
                    obeUbicacion.PSTALMC = CodTipoAlm
                    obeUbicacion.PSCALMC = CodAlm
                    obeUbicacion.PSCZNALM = CodZona
                    obeUbicacion.PSCPSCN = Posicion
                    dtUbicacion = obrUbicacion.Listar_ubicacion_Almacen_Zona(obeUbicacion)
                    If dtUbicacion.Rows.Count > 0 Then
                        msg_carga_validacion = msg_carga_validacion & Chr(10) & " Ya existe la posición."
                    End If
                    msg_carga_validacion = msg_carga_validacion.Trim

                End If

                If msg_carga_validacion = "" Then
                    msg_carga_validacion = "OK"
                End If
                drReg("OBS_CARGA") = msg_carga_validacion
                dtCarga_Ubicacion.Rows.Add(drReg)
            Next
            'Limpiar()
            dgvCargaInvUbic.DataSource = dtCarga_Ubicacion

            If obj_Workbook IsNot Nothing Then
                obj_Workbook.close()
            End If
            If obj_Excel IsNot Nothing Then
                obj_Excel.quit()
            End If

        Catch ex As Exception

            If obj_Workbook IsNot Nothing Then
                obj_Workbook.close()
            End If
            If obj_Excel IsNot Nothing Then
                obj_Excel.quit()
            End If
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        

        End Try

      

    End Sub

    Private Function AsignarReglaValidacionCarga_Ubicacion() As DataTable
        Dim dtReglaValidacion As New DataTable
        Dim oUtil As New mUtilEstructura
        dtReglaValidacion = oUtil.EstructuraValidacionColumna

        Dim drRV As DataRow



        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "TIPO_ALMACEN"
        drRV("MAX_LONGITUD") = 10
        drRV("TIPO_DATO") = mUtilEstructura.TipoDato.ALFANUMERICO.ToString
        drRV("OBLIGATORIEDAD") = "S"
        dtReglaValidacion.Rows.Add(drRV)


        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "ALMACEN"
        drRV("MAX_LONGITUD") = 10
        drRV("OBLIGATORIEDAD") = "S"
        drRV("TIPO_DATO") = mUtilEstructura.TipoDato.ALFANUMERICO.ToString
        dtReglaValidacion.Rows.Add(drRV)



        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "ZONA"
        drRV("MAX_LONGITUD") = 10
        drRV("OBLIGATORIEDAD") = "S"
        drRV("TIPO_DATO") = mUtilEstructura.TipoDato.ALFANUMERICO.ToString
        dtReglaValidacion.Rows.Add(drRV)


        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "UBICACION"
        drRV("MAX_LONGITUD") = 50
        drRV("OBLIGATORIEDAD") = "S"
        drRV("TIPO_DATO") = mUtilEstructura.TipoDato.ALFANUMERICO.ToString
        dtReglaValidacion.Rows.Add(drRV)


        Return dtReglaValidacion
    End Function

    'Private Sub Limpiar()
    '    obj_Workbook.Close()
    '    obj_Excel = Nothing
    '    obj_Workbook = Nothing
    '    obj_Worksheet = Nothing
    'End Sub

    Private Sub btnexportar_Click(sender As Object, e As EventArgs) Handles btnexportar.Click
        Try
            Dim TabSel As String = TabControl1.SelectedTab.Name
            Select Case TabSel

                Case "tpCargaUbicacion"
                    Dim ODs As New DataSet
                    Dim objDt As New DataTable
                    Dim loEncabezados As New Generic.List(Of Encabezados)

                    loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Poisiciones por Cliente"))
                    loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "Posiciones"))
                    loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "Poisiciones por Cliente"))
                    'loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
                    objDt = CType(Me.dgvCargaInvUbic.DataSource, DataTable).Copy
                    ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(dgvCargaInvUbic, objDt))
                    HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)

            End Select


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim drError() As DataRow
        If dtCarga_Ubicacion.Rows.Count = 0 Then
            MessageBox.Show("Sin registros a procesar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        drError = dtCarga_Ubicacion.Select("OBS_CARGA <> 'OK'")
        If drError.Length > 0 Then
            MessageBox.Show("Sin registros válidos a procesar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        drError = dtCarga_Ubicacion.Select("OBS_REGISTRO = 'OK'")
        If drError.Length > 0 Then
            MessageBox.Show("Cargue nuevamente.Registros ya procesados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If



        Dim obrMercaderia = New RANSA.NEGO.brMercaderia

        Dim USUARIO As String = objSeguridadBN.pUsuario
        Dim TERMINAL As String = HelpClass.NombreMaquina

        Dim obrUbicacion As New brUbicacion
        Dim obeUbicacion As beUbicacion
        Dim olistMercaderia As New List(Of RANSA.TypeDef.beMercaderia)
        Dim msgresult As String = ""
        Procesamiento = True
        For Each item As DataRow In dtCarga_Ubicacion.Rows
            obeUbicacion = New beUbicacion
            obeUbicacion.PSCCMPN = pCCMPN
            obeUbicacion.PSTALMC = item("TIPO_ALMACEN")
            obeUbicacion.PSCALMC = item("ALMACEN")
            obeUbicacion.PSCZNALM = item("ZONA")
            obeUbicacion.PSCSECTR = "G"
            obeUbicacion.PNCCLNT = pCliente
            obeUbicacion.PSCPSCN = item("UBICACION")
            obeUbicacion.PSUSUARIO = USUARIO
            msgresult = obrUbicacion.Registrar_ubicacion_Almacen_Zona_Masivo(obeUbicacion)
            If msgresult = "" Then
                item("OBS_REGISTRO") = "OK"
            Else
                item("OBS_REGISTRO") = msgresult
            End If
        Next
        dgvCargaInvUbic.DataSource = dtCarga_Ubicacion

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmCargaMasivaPosicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim objNeg As Ransa.NEGO.brDespachoMasivo
            Dim strMensajeError As String = ""
            objNeg = New Ransa.NEGO.brDespachoMasivo()
            dgvCargaInvUbic.AutoGenerateColumns = False
            dtAlmacen = objNeg.ListarAlmacenValidacionCarga()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class