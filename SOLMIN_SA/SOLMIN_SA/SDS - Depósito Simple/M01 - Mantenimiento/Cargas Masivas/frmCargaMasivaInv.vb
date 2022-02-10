Imports System.IO
Imports Ransa.Utilitario
Imports Ransa.NEGO.slnSOLMIN_SDS.MantenimientoSDS
Imports Ransa.NEGO.slnSOLMIN_SDS
Public Class frmCargaMasivaInv
    'Private obj_Excel As Object
    'Private obj_Workbook As Object
    'Private obj_Worksheet As Object
    'Private obj_SheetName As String
    Private ValidacionCargaAlmacen As Boolean = False
    Private ValidacionCargaUbicacion As Boolean = False

    Private dtAlmacen As New DataTable
    Private dtCarga_X_Almacen As New DataTable
    Private dtCarga_X_Ubicacion As New DataTable
    Private UltimaRuta As String = ""

    Private Sub frmCargaMasivaInv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            dgvCargaInvAlm.AutoGenerateColumns = False
            dgvCargaInvUbic.AutoGenerateColumns = False

            Dim objNeg As Ransa.NEGO.brDespachoMasivo
            Dim strMensajeError As String = ""
            objNeg = New Ransa.NEGO.brDespachoMasivo()

            dtAlmacen = objNeg.ListarAlmacenValidacionCarga()

            Listar_Compania()
            txtCliente.pUsuario = objSeguridadBN.pUsuario
            TabControl1_Selected(TabControl1, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Listar_Compania()
        UcCompania_Cmb011.Usuario = objSeguridadBN.pUsuario
        UcCompania_Cmb011.pActualizar()
        UcCompania_Cmb011.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    End Sub




    Private Sub btnCargaArchivo_Click(sender As Object, e As EventArgs) Handles btnCargaArchivo.Click

        'Try
        Dim TabSel As String = TabControl1.SelectedTab.Name
        Select Case TabSel
            Case "tpCargaAlmacen"
                CargaFormato_x_Almacen()
            Case "tpCargaUbicacion"
                CargaFormato_x_Ubicacion()

        End Select
        'Catch ex As Exception
        '    'Limpiar()
        '    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub



    Private Sub CargaFormato_x_Almacen()

        Dim obj_Excel As Object
        Dim obj_Workbook As Object
        Dim obj_Worksheet As Object
        Dim obj_SheetName As String


        Try

            Dim oUtil As New mUtilEstructura
            Dim oValida As New ValidarCaracterEspeciales
            If txtCliente.pCodigo = 0 Then
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

            'Dim dtCarga As New DataTable
            dtCarga_X_Almacen.Columns.Clear()
            dtCarga_X_Almacen.Rows.Clear()

            Dim PosExcel As New Hashtable
            dtCarga_X_Almacen.Columns.Add("SKU")
            dtCarga_X_Almacen.Columns.Add("TIPO_ALMACEN")
            dtCarga_X_Almacen.Columns.Add("ALMACEN")
            dtCarga_X_Almacen.Columns.Add("ZONA")
            dtCarga_X_Almacen.Columns.Add("CANTIDAD")

            Dim dtListaRegla As New DataTable
            dtListaRegla = AsignarReglaValidacionCargaInv_x_Almacen()



            Dim ListadoValidacion As New List(Of String)
            Dim NombreColumna As String = ""
            For ColIndex As Integer = 0 To dtCarga_X_Almacen.Columns.Count - 1
                NombreColumna = dtCarga_X_Almacen.Columns(ColIndex).ColumnName
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
                For ColIndex As Integer = 0 To dtCarga_X_Almacen.Columns.Count - 1
                    CeldaColumnaFormato = dtCarga_X_Almacen.Columns(ColIndex).ColumnName
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



            dtCarga_X_Almacen.Columns.Add("TMRCD2")
            dtCarga_X_Almacen.Columns.Add("NORDSR")
            dtCarga_X_Almacen.Columns.Add("NCNTR")
            dtCarga_X_Almacen.Columns.Add("NCRCTC")
            dtCarga_X_Almacen.Columns.Add("NAUTR")
            dtCarga_X_Almacen.Columns.Add("CUNCN5")
            dtCarga_X_Almacen.Columns.Add("CUNPS5")
            dtCarga_X_Almacen.Columns.Add("CUNVL5")
            dtCarga_X_Almacen.Columns.Add("FUNDS2")
            dtCarga_X_Almacen.Columns.Add("CTPDP6")


            dtCarga_X_Almacen.Columns.Add("OBS_CARGA")
            dtCarga_X_Almacen.Columns.Add("OBS_REGISTRO")



            Dim obrMercaderia As New Ransa.NEGO.brMercaderia



            Dim InicioFilaReg As Int64 = FilaRegFormato + 1
            Dim CeldaValor As String = ""
            Dim msg_carga_validacion As String = ""
            Dim msg_carga As String = ""

            Dim drReg As DataRow
            Dim drExiste() As DataRow

            Dim CodTipoAlm As String = ""
            Dim CodAlm As String = ""
            Dim CodZona As String = ""
            Dim dtOS As New DataTable
            Dim obeMercaderia As Ransa.TYPEDEF.beMercaderia
            Dim sku As String = ""
            For i = InicioFilaReg To MaxReg
                msg_carga_validacion = ""
                CeldaValor = ("" & obj_Worksheet.Cells(i, PosExcel("SKU")).Value).ToString.Trim
                If CeldaValor = "" Then
                    Exit For
                End If
                drReg = dtCarga_X_Almacen.NewRow

                For Each item As String In ListadoValidacion
                    CeldaValor = ("" & obj_Worksheet.Cells(i, PosExcel(item)).Value).ToString.Trim
                    msg_carga = oUtil.ValidarEstructuraColumna(dtListaRegla, item, CeldaValor)
                    If msg_carga <> "" Then msg_carga_validacion = msg_carga_validacion & msg_carga
                    drReg(item) = CeldaValor
                Next
                msg_carga_validacion = msg_carga_validacion.Trim

                sku = ("" & obj_Worksheet.Cells(i, PosExcel("SKU")).Value).ToString.Trim
                ' VALIDACION U. Valor
                CodTipoAlm = ("" & obj_Worksheet.Cells(i, PosExcel("TIPO_ALMACEN")).Value).ToString.Trim
                CodAlm = ("" & obj_Worksheet.Cells(i, PosExcel("ALMACEN")).Value).ToString.Trim
                CodZona = ("" & obj_Worksheet.Cells(i, PosExcel("ZONA")).Value).ToString.Trim

                drExiste = dtAlmacen.Select("CTPALM = '" & CodTipoAlm & "' AND CALMC = '" & CodAlm & "' AND CZNALM = '" & CodZona & "'")
                If drExiste.Length <= 0 Then
                    msg_carga_validacion = msg_carga_validacion & Chr(10) & " No existe(Tipo/Almacén/Zona)"
                End If

                If Val("" & obj_Worksheet.Cells(i, PosExcel("CANTIDAD")).Value.ToString.Trim) = 0 Then
                    msg_carga_validacion = msg_carga_validacion & Chr(10) & " Cantidad debe ser mayor a 0."
                End If


                msg_carga_validacion = msg_carga_validacion.Trim

                If msg_carga_validacion = "" Then

                    obeMercaderia = New Ransa.TYPEDEF.beMercaderia
                    obeMercaderia.PNCCLNT = txtCliente.pCodigo
                    obeMercaderia.PSCMRCLR = sku
                    dtOS = obrMercaderia.fListOrdenServicioxSKU(obeMercaderia)
                    If dtOS.Rows.Count = 0 Then
                        msg_carga_validacion = msg_carga_validacion & Chr(10) & "Sin O/S generada"

                    End If
                    If dtOS.Rows.Count > 1 Then
                        msg_carga_validacion = msg_carga_validacion & Chr(10) & "Más de 1 O/S generada"
                    End If
                    If dtOS.Rows.Count = 1 Then
                        drReg("NORDSR") = dtOS.Rows(0)("NORDSR")
                        drReg("NCNTR") = dtOS.Rows(0)("NCNTR")
                        drReg("NCRCTC") = dtOS.Rows(0)("NCRCTC")
                        drReg("NAUTR") = dtOS.Rows(0)("NAUTR")
                        drReg("CUNCN5") = dtOS.Rows(0)("CUNCN5")
                        drReg("CUNPS5") = dtOS.Rows(0)("CUNPS5")
                        drReg("CUNVL5") = dtOS.Rows(0)("CUNVL5")
                        drReg("FUNDS2") = dtOS.Rows(0)("FUNDS2")
                        drReg("CTPDP6") = dtOS.Rows(0)("CTPDP6")
                        drReg("TMRCD2") = ("" & dtOS.Rows(0)("TMRCD2")).ToString.Trim
                    End If

                End If

                'obOCItem.PNNORDSR = DtServicio.Rows(0).Item("NORDSR")
                'obOCItem.PNNCNTR = Val("" & DtServicio.Rows(0).Item("NCNTR")) ' debe ser actualizado  contrato
                'obOCItem.PNNCRCTC = Val("" & DtServicio.Rows(0).Item("NCRCTC"))  ' debe ser actualizado contrato
                'obOCItem.PNNAUTR = Val("" & DtServicio.Rows(0).Item("NAUTR"))  ' debe ser actualizado contrato
                'obOCItem.PSCUNCNT = ("" & DtServicio.Rows(0).Item("CUNCN5")).ToString.Trim   ' .PSCUNCN5 ' debe ser actualizado  contrato
                'obOCItem.PSCUNPST = ("" & DtServicio.Rows(0).Item("CUNPS5")).ToString.Trim   ' .PSCUNPS5 ' debe ser actualizado  contrato
                'obOCItem.pSCUNVLT = ("" & DtServicio.Rows(0).Item("CUNVL5")).ToString.Trim   ' .PSCUNVL5 ' debe ser actualizado  contrato
                'obOCItem.PSFUNDS2 = ("" & DtServicio.Rows(0).Item("FUNDS2")).ToString.Trim
                'obOCItem.PSCTPDPS = ("" & DtServicio.Rows(0).Item("CTPDP6")).ToString.Trim
                If msg_carga_validacion = "" Then
                    msg_carga_validacion = "OK"
                End If
                drReg("OBS_CARGA") = msg_carga_validacion
                dtCarga_X_Almacen.Rows.Add(drReg)
            Next
            'Limpiar()
            dgvCargaInvAlm.DataSource = dtCarga_X_Almacen

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

    Private Function AsignarReglaValidacionCargaInv_x_Almacen() As DataTable
        Dim dtReglaValidacion As New DataTable
        Dim oUtil As New mUtilEstructura
        dtReglaValidacion = oUtil.EstructuraValidacionColumna

        Dim drRV As DataRow

        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "SKU"
        drRV("MAX_LONGITUD") = 30
        drRV("TIPO_DATO") = mUtilEstructura.TipoDato.ALFANUMERICO.ToString
        drRV("OBLIGATORIEDAD") = "S"
        dtReglaValidacion.Rows.Add(drRV)

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
        drRV("COLUMNA") = "CANTIDAD"
        drRV("OBLIGATORIEDAD") = "S"
        drRV("ENTEROS") = 10
        drRV("DECIMALES") = 5
        drRV("TIPO_DATO") = mUtilEstructura.TipoDato.NUMERICO.ToString
        dtReglaValidacion.Rows.Add(drRV)




        Return dtReglaValidacion
    End Function


    Private Function AsignarReglaValidacionCargaInv_x_Ubicacion() As DataTable
        Dim dtReglaValidacion As New DataTable
        Dim oUtil As New mUtilEstructura
        dtReglaValidacion = oUtil.EstructuraValidacionColumna

        Dim drRV As DataRow

        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "SKU"
        drRV("MAX_LONGITUD") = 30
        drRV("TIPO_DATO") = mUtilEstructura.TipoDato.ALFANUMERICO.ToString
        drRV("OBLIGATORIEDAD") = "S"
        dtReglaValidacion.Rows.Add(drRV)

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



        drRV = dtReglaValidacion.NewRow
        drRV("COLUMNA") = "CANTIDAD"
        drRV("OBLIGATORIEDAD") = "S"
        drRV("ENTEROS") = 10
        drRV("DECIMALES") = 5
        drRV("TIPO_DATO") = mUtilEstructura.TipoDato.NUMERICO.ToString
        dtReglaValidacion.Rows.Add(drRV)




        Return dtReglaValidacion
    End Function



    Private Sub CargaFormato_x_Ubicacion()

        Dim obj_Excel As Object
        Dim obj_Workbook As Object
        Dim obj_Worksheet As Object
        Dim obj_SheetName As String

        Try

            Dim oUtil As New mUtilEstructura
            Dim oValida As New ValidarCaracterEspeciales
            If txtCliente.pCodigo = 0 Then
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

            'Dim dtCarga As New DataTable
            dtCarga_X_Ubicacion.Columns.Clear()
            dtCarga_X_Ubicacion.Rows.Clear()

            Dim PosExcel As New Hashtable
            dtCarga_X_Ubicacion.Columns.Add("SKU")
            dtCarga_X_Ubicacion.Columns.Add("TIPO_ALMACEN")
            dtCarga_X_Ubicacion.Columns.Add("ALMACEN")
            dtCarga_X_Ubicacion.Columns.Add("ZONA")
            dtCarga_X_Ubicacion.Columns.Add("UBICACION")
            dtCarga_X_Ubicacion.Columns.Add("CANTIDAD")

            Dim dtListaRegla As New DataTable
            dtListaRegla = AsignarReglaValidacionCargaInv_x_Ubicacion()



            Dim ListadoValidacion As New List(Of String)
            Dim NombreColumna As String = ""
            For ColIndex As Integer = 0 To dtCarga_X_Ubicacion.Columns.Count - 1
                NombreColumna = dtCarga_X_Ubicacion.Columns(ColIndex).ColumnName
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
                For ColIndex As Integer = 0 To dtCarga_X_Ubicacion.Columns.Count - 1
                    CeldaColumnaFormato = dtCarga_X_Ubicacion.Columns(ColIndex).ColumnName
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



            dtCarga_X_Ubicacion.Columns.Add("TMRCD2")
            dtCarga_X_Ubicacion.Columns.Add("NORDSR")
            dtCarga_X_Ubicacion.Columns.Add("NCNTR")
            dtCarga_X_Ubicacion.Columns.Add("NCRCTC")
            dtCarga_X_Ubicacion.Columns.Add("NAUTR")
            dtCarga_X_Ubicacion.Columns.Add("CUNCN5")
            dtCarga_X_Ubicacion.Columns.Add("CUNPS5")
            dtCarga_X_Ubicacion.Columns.Add("CUNVL5")
            dtCarga_X_Ubicacion.Columns.Add("FUNDS2")
            dtCarga_X_Ubicacion.Columns.Add("CTPDP6")


            dtCarga_X_Ubicacion.Columns.Add("OBS_CARGA")
            dtCarga_X_Ubicacion.Columns.Add("OBS_REGISTRO")



            Dim obrMercaderia As New Ransa.NEGO.brMercaderia



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
            Dim dsresult As New DataSet
            Dim dtOS As New DataTable
            Dim dtUbicacion As New DataTable
            Dim obeMercaderia As Ransa.TYPEDEF.beMercaderia
            Dim sku As String = ""
            For i = InicioFilaReg To MaxReg
                msg_carga_validacion = ""
                CeldaValor = ("" & obj_Worksheet.Cells(i, PosExcel("SKU")).Value)
                If CeldaValor = "" Then
                    Exit For
                End If
                drReg = dtCarga_X_Ubicacion.NewRow

                For Each item As String In ListadoValidacion
                    CeldaValor = ("" & obj_Worksheet.Cells(i, PosExcel(item)).Value).ToString.Trim
                    msg_carga = oUtil.ValidarEstructuraColumna(dtListaRegla, item, CeldaValor)
                    If msg_carga <> "" Then msg_carga_validacion = msg_carga_validacion & msg_carga
                    drReg(item) = CeldaValor
                Next
                msg_carga_validacion = msg_carga_validacion.Trim

                sku = ("" & obj_Worksheet.Cells(i, PosExcel("SKU")).Value).ToString.Trim
                ' VALIDACION U. Valor
                CodTipoAlm = ("" & obj_Worksheet.Cells(i, PosExcel("TIPO_ALMACEN")).Value).ToString.Trim
                CodAlm = ("" & obj_Worksheet.Cells(i, PosExcel("ALMACEN")).Value).ToString.Trim
                CodZona = ("" & obj_Worksheet.Cells(i, PosExcel("ZONA")).Value).ToString.Trim
                Posicion = ("" & obj_Worksheet.Cells(i, PosExcel("UBICACION")).Value).ToString.Trim

                If Val("" & obj_Worksheet.Cells(i, PosExcel("CANTIDAD")).Value) = 0 Then
                    msg_carga_validacion = msg_carga_validacion & Chr(10) & " Cantidad debe ser mayor a 0."
                End If

                msg_carga_validacion = msg_carga_validacion.Trim

                If msg_carga_validacion = "" Then

                    obeMercaderia = New Ransa.TYPEDEF.beMercaderia
                    obeMercaderia.PNCCLNT = txtCliente.pCodigo
                    obeMercaderia.PSCMRCLR = sku
                    obeMercaderia.PSCTPALM = CodTipoAlm
                    obeMercaderia.PSCALMC = CodAlm
                    obeMercaderia.PSCZNALM = CodZona
                    obeMercaderia.PSCPSCN = Posicion
                    dsresult = obrMercaderia.fListOrdenServicioSKU_Ubicacion(obeMercaderia)
                    dtOS = dsresult.Tables(0)
                    dtUbicacion = dsresult.Tables(1)

                    drExiste = dtAlmacen.Select("CTPALM = '" & CodTipoAlm & "' AND CALMC = '" & CodAlm & "' AND CZNALM = '" & CodZona & "'")
                    If drExiste.Length = 0 Then
                        msg_carga_validacion = msg_carga_validacion & Chr(10) & " No existe(Tipo/Almacén/Zona)"
                    Else
                        If dtUbicacion.Rows.Count = 0 Then
                            msg_carga_validacion = msg_carga_validacion & Chr(10) & " No existe la posición."
                        End If
                    End If

                    If dtOS.Rows.Count = 0 Then
                        msg_carga_validacion = msg_carga_validacion & Chr(10) & "Sin O/S generada"
                    End If
                    If dtOS.Rows.Count > 1 Then
                        msg_carga_validacion = msg_carga_validacion & Chr(10) & "Más de 1 O/S generada"
                    End If

                    If dtOS.Rows.Count = 1 Then
                        drReg("NORDSR") = dtOS.Rows(0)("NORDSR")
                        drReg("NCNTR") = dtOS.Rows(0)("NCNTR")
                        drReg("NCRCTC") = dtOS.Rows(0)("NCRCTC")
                        drReg("NAUTR") = dtOS.Rows(0)("NAUTR")
                        drReg("CUNCN5") = dtOS.Rows(0)("CUNCN5")
                        drReg("CUNPS5") = dtOS.Rows(0)("CUNPS5")
                        drReg("CUNVL5") = dtOS.Rows(0)("CUNVL5")
                        drReg("FUNDS2") = dtOS.Rows(0)("FUNDS2")
                        drReg("CTPDP6") = dtOS.Rows(0)("CTPDP6")
                        drReg("TMRCD2") = ("" & dtOS.Rows(0)("TMRCD2")).ToString.Trim
                    End If


                End If
                msg_carga_validacion = msg_carga_validacion.Trim


                'obOCItem.PNNORDSR = DtServicio.Rows(0).Item("NORDSR")
                'obOCItem.PNNCNTR = Val("" & DtServicio.Rows(0).Item("NCNTR")) ' debe ser actualizado  contrato
                'obOCItem.PNNCRCTC = Val("" & DtServicio.Rows(0).Item("NCRCTC"))  ' debe ser actualizado contrato
                'obOCItem.PNNAUTR = Val("" & DtServicio.Rows(0).Item("NAUTR"))  ' debe ser actualizado contrato
                'obOCItem.PSCUNCNT = ("" & DtServicio.Rows(0).Item("CUNCN5")).ToString.Trim   ' .PSCUNCN5 ' debe ser actualizado  contrato
                'obOCItem.PSCUNPST = ("" & DtServicio.Rows(0).Item("CUNPS5")).ToString.Trim   ' .PSCUNPS5 ' debe ser actualizado  contrato
                'obOCItem.pSCUNVLT = ("" & DtServicio.Rows(0).Item("CUNVL5")).ToString.Trim   ' .PSCUNVL5 ' debe ser actualizado  contrato
                'obOCItem.PSFUNDS2 = ("" & DtServicio.Rows(0).Item("FUNDS2")).ToString.Trim
                'obOCItem.PSCTPDPS = ("" & DtServicio.Rows(0).Item("CTPDP6")).ToString.Trim
                If msg_carga_validacion = "" Then
                    msg_carga_validacion = "OK"
                End If
                drReg("OBS_CARGA") = msg_carga_validacion
                dtCarga_X_Ubicacion.Rows.Add(drReg)
            Next
            'Limpiar()
            dgvCargaInvUbic.DataSource = dtCarga_X_Ubicacion

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

    'Private Sub Limpiar()
    '    obj_Workbook.Close()
    '    obj_Excel = Nothing
    '    obj_Workbook = Nothing
    '    obj_Worksheet = Nothing
    'End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim TabSel As String = TabControl1.SelectedTab.Name
            Select Case TabSel
                Case "tpCargaAlmacen"
                    CargarInventarioMasivoAlmacen()
                Case "tpCargaUbicacion"
                    CargarInventarioMasivoUbicacion()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub

    Private Sub CargarInventarioMasivoUbicacion()

        Dim drError() As DataRow
        If dtCarga_X_Ubicacion.Rows.Count = 0 Then
            MessageBox.Show("Sin registros a procesar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        drError = dtCarga_X_Ubicacion.Select("OBS_CARGA <> 'OK'")
        If drError.Length > 0 Then
            MessageBox.Show("Sin registros válidos a procesar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        drError = dtCarga_X_Ubicacion.Select("OBS_REGISTRO ='OK'")
        If drError.Length > 0 Then
            MessageBox.Show("Cargue nuevamente.Registro ya procesados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If



        Dim obrMercaderia = New Ransa.NEGO.brMercaderia
        Dim USUARIO As String = objSeguridadBN.pUsuario
        Dim TERMINAL As String = HelpClass.NombreMaquina


        Dim obeMercaderia As Ransa.TypeDef.beMercaderia
        Dim olistMercaderia As New List(Of Ransa.TypeDef.beMercaderia)

        For Each item As DataRow In dtCarga_X_Ubicacion.Rows
            obeMercaderia = New Ransa.TypeDef.beMercaderia
            obeMercaderia.CORRELATIVO = 0 'intCorrelativo
            obeMercaderia.PSCMRCD = "" 'falta
            obeMercaderia.PSNORCCL = ""
            obeMercaderia.PSNGUICL = ""
            obeMercaderia.PSNRUCLL = ""
            obeMercaderia.PSSTPING = "J" 'debe ser ctualizado
            'Cantidad de transacción
            obeMercaderia.PNQTRMC = item("CANTIDAD")
            obeMercaderia.PNQTRMP = 0 'peso debe ser actualizado
            obeMercaderia.PSCTPALM = item("TIPO_ALMACEN")  'obeItem.PSCTPALM
            obeMercaderia.PSCALMC = item("ALMACEN")
            obeMercaderia.PSCZNALM = item("ZONA")
            obeMercaderia.Ubicacion = item("UBICACION")
            'Cantidad de Kardex
            obeMercaderia.PNQSLMC2 = item("CANTIDAD")
            obeMercaderia.PNQSLMP2 = 0 ' peso
            obeMercaderia.PNQDSVGN = 0

            obeMercaderia.PSCTPOCN = "0"
            obeMercaderia.PSTOBSRV = "" ' debe ser actualizado
            obeMercaderia.PNFRLZSR = HelpClass.CDate_a_Numero8Digitos(Now.Date)
            obeMercaderia.PSCMRCLR_NEW = item("SKU")
            obeMercaderia.PSTMRCD2 = item("TMRCD2")
            obeMercaderia.PSTMRCD3 = ""
            obeMercaderia.PSCUNCN5_NEW = "UNI"
            obeMercaderia.PNNORDSR = item("NORDSR") ' debe ser actualizado
            obeMercaderia.PSCMRCLR = item("SKU")   ' obeItem.PSCMRCLR_NEW
            obeMercaderia.PNNCNTR = item("NCNTR") ' debe ser actualizado  contrato
            obeMercaderia.PNNCRCTC = item("NCRCTC") ' debe ser actualizado contrato
            obeMercaderia.PNNAUTR = item("NAUTR")  ' debe ser actualizado contrato
            obeMercaderia.PSCUNCNT = item("CUNCN5")   ' .PSCUNCN5 ' debe ser actualizado  contrato
            obeMercaderia.PSCUNPST = item("CUNPS5")   ' .PSCUNPS5 ' debe ser actualizado  contrato
            obeMercaderia.pSCUNVLT = item("CUNVL5")  ' .PSCUNVL5 ' debe ser actualizado  contrato
            obeMercaderia.PSFUNDS2 = item("FUNDS2")
            obeMercaderia.PSCTPDPS = item("CTPDP6")
            olistMercaderia.Add(obeMercaderia)

        Next

        'Llenamos información de cabecera
        olistMercaderia.Item(0).PNNANOCM = 0 '.pobjInformacionIngresada.pintAnioUnidad_NANOCM
        olistMercaderia.Item(0).PNCCLNT = Me.txtCliente.pCodigo  '.pobjInformacionIngresada.pintCodigoCliente_CCLNT
        olistMercaderia.Item(0).PNCTRSP = 999999 '.pobjInformacionIngresada.pintEmpresaTransporte_CTRSP
        olistMercaderia.Item(0).PNNLELCH = 0 ' .pobjInformacionIngresada.pintNroDocIdentidadChofer_NLELCH
        olistMercaderia.Item(0).PNNRUCT = 1 ' .pobjInformacionIngresada.pintNroRUCEmpTransporte_NRUCT
        olistMercaderia.Item(0).PNCSRVC = 2 '.pobjInformacionIngresada.pintServicio_CSRVC
        olistMercaderia.Item(0).PSTNMBCH = "" '.pobjInformacionIngresada.pstrChofer_TNMBCH
        olistMercaderia.Item(0).PSCCMPN = Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy
        olistMercaderia.Item(0).PSCDVSN = objSeguridadBN.pDivision
        olistMercaderia.Item(0).PSTMRCCM = "" ' .pobjInformacionIngresada.pstrMarcaUnidad_TMRCCM
        olistMercaderia.Item(0).PSNBRVCH = "" ' .pobjInformacionIngresada.pstrNroBrevete_NBRVCH
        olistMercaderia.Item(0).PSNPLCCM = "" '.pobjInformacionIngresada.pstrNroPlacaCamion_NPLCCM
        olistMercaderia.Item(0).PSTOBSER = ""  '.pobjInformacionIngresada.pstrObservaciones_TOBSER
        olistMercaderia.Item(0).PSTCMPCL = Me.txtCliente.pRazonSocial  '.pobjInformacionIngresada.pstrRazonSocialCliente_TCMPCL
        olistMercaderia.Item(0).PSTCMPTR = "VARIOS" ' .pobjInformacionIngresada.pstrRazonSocialEmpTransporte_TCMPTR
        olistMercaderia.Item(0).GenerarServicio = False
        olistMercaderia.Item(0).PSUSUARIO = objSeguridadBN.pUsuario
        olistMercaderia.Item(0).PNFRLZSR = Now.ToString("yyyyMMdd")
        olistMercaderia.Item(0).PSNTRMNL = objSeguridadBN.pstrPCName
        olistMercaderia.Item(0).PSSTPODP = objSeguridadBN.pstrTipoAlmacen


        '========== Creamos la OC  ===================
        Dim strOC As String = "CMASIVO-" & Now.ToString("yyyyMMdd") & "-" & HelpClass.NowNumeric
        Dim obeOrdenCompra As New Ransa.TypeDef.beOrdenCompra
        With obeOrdenCompra
            .PNCCLNT = txtCliente.pCodigo
            .PSNORCML = strOC '"CM-" & Now.ToString("yyyyMMdd")
            .PSTPOOCM = ""
            .PNFORCML = Now.ToString("yyyyMMdd")
            .PNFSOLIC = Now.ToString("yyyyMMdd")
            .PNCPRVCL = 0
            .PSTDSCML = strOC
            .PSTCMAEM = ""
            .PSTTINTC = "LOC"
            .PSNREFCL = ""
            .PSTPAGME = ""
            .PSREFDO1 = ""
            .PNNTPDES = 1
            .PNCMNDA1 = 0
            .PSTEMPFAC = ""
            .PSTNOMCOM = ""
            .PSTCTCST = ""
            .PSCREGEMB = ""
            .PNCMEDTR = 4
            .PSTDEFIN = ""
            .PSTCNDPG = ""
            .PNIVCOTO = 0
            .PNIVTOCO = 0
            .PNIVTOIM = 0
            .PSTDAITM = ""
            .PSCUSCRT = USUARIO
            .PSCULUSA = USUARIO
            .PSTPOOCM = ""
        End With
        Dim obrOrdenDeCompra As New Ransa.NEGO.brOrdenDeCompra
        Dim rpta As Integer = obrOrdenDeCompra.InsertarOrdenDeCompra(obeOrdenCompra)
        If rpta <> 1 Then
            MessageBox.Show("Error registro OC cabecera", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        '========== Creamos la OC con el Nro. de guía Ransa ===================
        Dim pstrError As String = ""
        If rpta = 1 Then
            ' ===========Si se creó satisfactoriamente el OC creamos el detalle (Items)
            Dim intItem As Integer = 10
            Dim TD_Item As Ransa.TypeDef.OrdenCompra.ItemOC.TD_ItemOC
            Dim LineaReg As Int64 = 1
            For Each item As Ransa.TypeDef.beMercaderia In olistMercaderia
                TD_Item = New Ransa.TypeDef.OrdenCompra.ItemOC.TD_ItemOC
                With TD_Item
                    .pCCLNT_CodigoCliente = txtCliente.pCodigo   'olbeMercaderia.Item(0).PNCCLNT
                    .pNORCML_NroOrdenCompra = strOC '"REGMASIVO-" & Now.ToString("yyyyMMdd") & "-" & HelpClass.NowNumeric 'txtOrdenCompra.Text.Trim
                    .pNRITOC_NroItemOC = intItem
                    .pTCITCL_CodigoCliente = item.PSCMRCLR_NEW
                    .pTDITES_DescripcionES = item.PSTMRCD2
                    .pTDITIN_DescripcionIN = ""
                    .pQCNTIT_Cantidad = item.PNQTRMC
                    .pTUNDIT_Unidad = item.PSCUNCN5_NEW
                    .pIVUNIT_ImporteUnitario = 0
                    .pIVTOIT_ImporteTotal = 0
                    .pQTOLMAX_ToleranciaMax = 0
                    .pQTOLMIN_ToleranciaMin = 0
                    .pFMPDME_FechaEstEntregaDte = Now.Date
                    .pFMPIME_FechaReqPlantaDte = Now.Date
                    .pTLUGOR_LugarOrigen = ""
                    .pTLUGEN_LugarEntrega = ""
                    .pTCTCST_CentroDeCosto = ""
                    .pTRFRN_RefSolicitante = ""
                    .pFLGPEN_FlagSeguimiento = ""
                    'Actualizamos el registro 
                    item.PNNRITOC = intItem
                    item.PSNORCCL = .pNORCML_NroOrdenCompra
                End With

                Dim objSqlManager As Db2Manager.RansaData.iSeries.DataObjects.SqlManager = New Db2Manager.RansaData.iSeries.DataObjects.SqlManager
                Dim brpta As Boolean = True
                brpta = Ransa.DAO.OrdenCompra.cItemOrdenCompra.Grabar(objSqlManager, TD_Item, USUARIO, pstrError)
                If brpta = False Then
                    MessageBox.Show("Error registro OC detalle SKU " & TD_Item.pTCITCL_CodigoCliente & " Línea SKU " & LineaReg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                ' ===========Si se creó satisfactoriamente el OC creamos el detalle (Items)
                intItem += 10

                LineaReg = LineaReg + 1
            Next

        End If

        'Verificar si existe Codigo de Mercaderia


        '==========Ejecutamos el proceso de recepcion
        Dim intNroRecepcion As Decimal = 0
        intNroRecepcion = obrMercaderia.fintRecepcionMercaderia(olistMercaderia)

        If intNroRecepcion = 0 Then
            pstrError = "Error producido en la operación de recepción"
            dtCarga_X_Almacen.Rows(0)("OBS_REGISTRO") = pstrError
            MessageBox.Show(pstrError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else

            'Dim obrUbicacion As New Ransa.NEGO.brUbicacion()
            Dim obrUbicacion As New Ransa.Controls.brUbicacion
            'Dim obeUbicacion As Ransa.TypeDef.beUbicacion
            Dim obeUbicacion As Ransa.Controls.beUbicacion
            For Each item As Ransa.TypeDef.beMercaderia In olistMercaderia
                'obeUbicacion = New Ransa.TypeDef.beUbicacion
                obeUbicacion = New Ransa.Controls.beUbicacion

                obeUbicacion.PSCTPALM = item.PSCTPALM
                obeUbicacion.PSCALMC = item.PSCALMC
                obeUbicacion.PSCSECTR = "G"
                obeUbicacion.PSCPSCN = item.Ubicacion
                obeUbicacion.PNNORDSR = item.PNNORDSR
                obeUbicacion.PNNCRRIN = 0
                obeUbicacion.PNNSLCSR = 0
                obeUbicacion.PNFTRNS = 0
                obeUbicacion.PNQTRMC1 = item.PNQTRMC
                obeUbicacion.PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
                obeUbicacion.PSCDVSN = "R"
                obeUbicacion.PNCSRVC = 1
                obeUbicacion.PSCULUSA = USUARIO
                obeUbicacion.PNNGUIRN = intNroRecepcion
                obeUbicacion.PSNTRMNL = objSeguridadBN.pstrPCName
                obrUbicacion.RegistrarInventario_X_Ubicacion(obeUbicacion)

            Next

            dtCarga_X_Ubicacion.Rows(0)("OBS_REGISTRO") = "OK"
            dgvCargaInvUbic.DataSource = dtCarga_X_Ubicacion

            Dim objFiltro As New Ransa.TypeDef.beDespacho
            With objFiltro
                .PNCCLNT = txtCliente.pCodigo
                .PNNGUIRN = intNroRecepcion
                .pRazonSocial = txtCliente.pCodigo
            End With
            mReporteIngSalRansa(objFiltro)
        End If

    End Sub

    Private Sub CargarInventarioMasivoAlmacen()
        Dim drError() As DataRow
        If dtCarga_X_Almacen.Rows.Count = 0 Then
            MessageBox.Show("Sin registros a procesar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        drError = dtCarga_X_Almacen.Select("OBS_CARGA <> 'OK'")
        If drError.Length > 0 Then
            MessageBox.Show("Sin registros válidos a procesar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        drError = dtCarga_X_Almacen.Select("OBS_REGISTRO = 'OK'")
        If drError.Length > 0 Then
            MessageBox.Show("Cargue nuevamente.Registro ya procesados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'dtCarga_X_Almacen()


        Dim obrMercaderia = New RANSA.NEGO.brMercaderia
        Dim USUARIO As String = objSeguridadBN.pUsuario
        Dim TERMINAL As String = HelpClass.NombreMaquina


        Dim obeMercaderia As RANSA.TypeDef.beMercaderia
        Dim olistMercaderia As New List(Of RANSA.TypeDef.beMercaderia)

        For Each item As DataRow In dtCarga_X_Almacen.Rows
            obeMercaderia = New RANSA.TypeDef.beMercaderia
            obeMercaderia.CORRELATIVO = 0 'intCorrelativo
            obeMercaderia.PSCMRCD = "" 'falta
            obeMercaderia.PSNORCCL = ""
            obeMercaderia.PSNGUICL = ""
            obeMercaderia.PSNRUCLL = ""
            obeMercaderia.PSSTPING = "J" 'debe ser ctualizado
            'Cantidad de transacción
            obeMercaderia.PNQTRMC = item("CANTIDAD")
            obeMercaderia.PNQTRMP = 0 'peso debe ser actualizado
            obeMercaderia.PSCTPALM = item("TIPO_ALMACEN")  'obeItem.PSCTPALM
            obeMercaderia.PSCALMC = item("ALMACEN")
            obeMercaderia.PSCZNALM = item("ZONA")
            'Cantidad de Kardex
            obeMercaderia.PNQSLMC2 = item("CANTIDAD")
            obeMercaderia.PNQSLMP2 = 0 ' peso
            obeMercaderia.PNQDSVGN = 0

            obeMercaderia.PSCTPOCN = "0"
            obeMercaderia.PSTOBSRV = "" ' debe ser actualizado
            obeMercaderia.PNFRLZSR = HelpClass.CDate_a_Numero8Digitos(Now.Date)
            obeMercaderia.PSCMRCLR_NEW = item("SKU")
            obeMercaderia.PSTMRCD2 = item("TMRCD2")
            obeMercaderia.PSTMRCD3 = ""
            obeMercaderia.PSCUNCN5_NEW = "UNI"
            obeMercaderia.PNNORDSR = item("NORDSR") ' debe ser actualizado
            obeMercaderia.PSCMRCLR = item("SKU")   ' obeItem.PSCMRCLR_NEW
            obeMercaderia.PNNCNTR = item("NCNTR") ' debe ser actualizado  contrato
            obeMercaderia.PNNCRCTC = item("NCRCTC") ' debe ser actualizado contrato
            obeMercaderia.PNNAUTR = item("NAUTR")  ' debe ser actualizado contrato
            obeMercaderia.PSCUNCNT = item("CUNCN5")   ' .PSCUNCN5 ' debe ser actualizado  contrato
            obeMercaderia.PSCUNPST = item("CUNPS5")   ' .PSCUNPS5 ' debe ser actualizado  contrato
            obeMercaderia.pSCUNVLT = item("CUNVL5")  ' .PSCUNVL5 ' debe ser actualizado  contrato
            obeMercaderia.PSFUNDS2 = item("FUNDS2")
            obeMercaderia.PSCTPDPS = item("CTPDP6")
            olistMercaderia.Add(obeMercaderia)

        Next

        'Llenamos información de cabecera
        olistMercaderia.Item(0).PNNANOCM = 0 '.pobjInformacionIngresada.pintAnioUnidad_NANOCM
        olistMercaderia.Item(0).PNCCLNT = Me.txtCliente.pCodigo  '.pobjInformacionIngresada.pintCodigoCliente_CCLNT
        olistMercaderia.Item(0).PNCTRSP = 999999 '.pobjInformacionIngresada.pintEmpresaTransporte_CTRSP
        olistMercaderia.Item(0).PNNLELCH = 0 ' .pobjInformacionIngresada.pintNroDocIdentidadChofer_NLELCH
        olistMercaderia.Item(0).PNNRUCT = 1 ' .pobjInformacionIngresada.pintNroRUCEmpTransporte_NRUCT
        olistMercaderia.Item(0).PNCSRVC = 2 '.pobjInformacionIngresada.pintServicio_CSRVC
        olistMercaderia.Item(0).PSTNMBCH = "" '.pobjInformacionIngresada.pstrChofer_TNMBCH
        olistMercaderia.Item(0).PSCCMPN = RANSA.Utilitario.MainModuleDeploy.IdCompaniaDeploy
        olistMercaderia.Item(0).PSCDVSN = objSeguridadBN.pDivision
        olistMercaderia.Item(0).PSTMRCCM = "" ' .pobjInformacionIngresada.pstrMarcaUnidad_TMRCCM
        olistMercaderia.Item(0).PSNBRVCH = "" ' .pobjInformacionIngresada.pstrNroBrevete_NBRVCH
        olistMercaderia.Item(0).PSNPLCCM = "" '.pobjInformacionIngresada.pstrNroPlacaCamion_NPLCCM
        olistMercaderia.Item(0).PSTOBSER = ""  '.pobjInformacionIngresada.pstrObservaciones_TOBSER
        olistMercaderia.Item(0).PSTCMPCL = Me.txtCliente.pRazonSocial  '.pobjInformacionIngresada.pstrRazonSocialCliente_TCMPCL
        olistMercaderia.Item(0).PSTCMPTR = "VARIOS" ' .pobjInformacionIngresada.pstrRazonSocialEmpTransporte_TCMPTR
        olistMercaderia.Item(0).GenerarServicio = False
        olistMercaderia.Item(0).PSUSUARIO = objSeguridadBN.pUsuario
        olistMercaderia.Item(0).PNFRLZSR = Now.ToString("yyyyMMdd")
        olistMercaderia.Item(0).PSNTRMNL = objSeguridadBN.pstrPCName
        olistMercaderia.Item(0).PSSTPODP = objSeguridadBN.pstrTipoAlmacen


        '========== Creamos la OC  ===================
        Dim strOC As String = "CMASIVO-" & Now.ToString("yyyyMMdd") & "-" & HelpClass.NowNumeric
        Dim obeOrdenCompra As New RANSA.TypeDef.beOrdenCompra
        With obeOrdenCompra
            .PNCCLNT = txtCliente.pCodigo
            .PSNORCML = strOC '"CM-" & Now.ToString("yyyyMMdd")
            .PSTPOOCM = ""
            .PNFORCML = Now.ToString("yyyyMMdd")
            .PNFSOLIC = Now.ToString("yyyyMMdd")
            .PNCPRVCL = 0
            .PSTDSCML = strOC
            .PSTCMAEM = ""
            .PSTTINTC = "LOC"
            .PSNREFCL = ""
            .PSTPAGME = ""
            .PSREFDO1 = ""
            .PNNTPDES = 1
            .PNCMNDA1 = 0
            .PSTEMPFAC = ""
            .PSTNOMCOM = ""
            .PSTCTCST = ""
            .PSCREGEMB = ""
            .PNCMEDTR = 4
            .PSTDEFIN = ""
            .PSTCNDPG = ""
            .PNIVCOTO = 0
            .PNIVTOCO = 0
            .PNIVTOIM = 0
            .PSTDAITM = ""
            .PSCUSCRT = USUARIO
            .PSCULUSA = USUARIO
            .PSTPOOCM = ""
        End With
        Dim obrOrdenDeCompra As New RANSA.NEGO.brOrdenDeCompra
        Dim rpta As Integer = obrOrdenDeCompra.InsertarOrdenDeCompra(obeOrdenCompra)
        If rpta <> 1 Then
            MessageBox.Show("Error registro OC cabecera", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        '========== Creamos la OC con el Nro. de guía Ransa ===================
        Dim pstrError As String = ""
        If rpta = 1 Then
            ' ===========Si se creó satisfactoriamente el OC creamos el detalle (Items)
            Dim intItem As Integer = 10
            Dim TD_Item As RANSA.TypeDef.OrdenCompra.ItemOC.TD_ItemOC
            Dim LineaReg As Int64 = 1
            For Each item As RANSA.TypeDef.beMercaderia In olistMercaderia
                TD_Item = New RANSA.TypeDef.OrdenCompra.ItemOC.TD_ItemOC
                With TD_Item
                    .pCCLNT_CodigoCliente = txtCliente.pCodigo   'olbeMercaderia.Item(0).PNCCLNT
                    .pNORCML_NroOrdenCompra = strOC '"REGMASIVO-" & Now.ToString("yyyyMMdd") & "-" & HelpClass.NowNumeric 'txtOrdenCompra.Text.Trim
                    .pNRITOC_NroItemOC = intItem
                    .pTCITCL_CodigoCliente = item.PSCMRCLR_NEW
                    .pTDITES_DescripcionES = item.PSTMRCD2
                    .pTDITIN_DescripcionIN = ""
                    .pQCNTIT_Cantidad = item.PNQTRMC
                    .pTUNDIT_Unidad = item.PSCUNCN5_NEW
                    .pIVUNIT_ImporteUnitario = 0
                    .pIVTOIT_ImporteTotal = 0
                    .pQTOLMAX_ToleranciaMax = 0
                    .pQTOLMIN_ToleranciaMin = 0
                    .pFMPDME_FechaEstEntregaDte = Now.Date
                    .pFMPIME_FechaReqPlantaDte = Now.Date
                    .pTLUGOR_LugarOrigen = ""
                    .pTLUGEN_LugarEntrega = ""
                    .pTCTCST_CentroDeCosto = ""
                    .pTRFRN_RefSolicitante = ""
                    .pFLGPEN_FlagSeguimiento = ""
                    'Actualizamos el registro 
                    item.PNNRITOC = intItem
                    item.PSNORCCL = .pNORCML_NroOrdenCompra
                End With

                Dim objSqlManager As Db2Manager.RansaData.iSeries.DataObjects.SqlManager = New Db2Manager.RansaData.iSeries.DataObjects.SqlManager
                Dim brpta As Boolean = True
                brpta = RANSA.DAO.OrdenCompra.cItemOrdenCompra.Grabar(objSqlManager, TD_Item, USUARIO, pstrError)
                If brpta = False Then
                    MessageBox.Show("Error registro OC detalle SKU " & TD_Item.pTCITCL_CodigoCliente & " Línea SKU " & LineaReg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                ' ===========Si se creó satisfactoriamente el OC creamos el detalle (Items)
                intItem += 10

                LineaReg = LineaReg + 1
            Next

        End If

        'Verificar si existe Codigo de Mercaderia

        'Dim obeMercaderia As beMercaderia
        'For Each obOCItem As beMercaderia In olbeMercaderia

        '    '============== Asigna el valor de la OS
        '    obOCItem.PNNORDSR = DtServicio.Rows(0).Item("NORDSR")

        '    obOCItem.PNNCNTR = Val("" & DtServicio.Rows(0).Item("NCNTR")) ' debe ser actualizado  contrato
        '    obOCItem.PNNCRCTC = Val("" & DtServicio.Rows(0).Item("NCRCTC"))  ' debe ser actualizado contrato
        '    obOCItem.PNNAUTR = Val("" & DtServicio.Rows(0).Item("NAUTR"))  ' debe ser actualizado contrato
        '    obOCItem.PSCUNCNT = ("" & DtServicio.Rows(0).Item("CUNCN5")).ToString.Trim   ' .PSCUNCN5 ' debe ser actualizado  contrato
        '    obOCItem.PSCUNPST = ("" & DtServicio.Rows(0).Item("CUNPS5")).ToString.Trim   ' .PSCUNPS5 ' debe ser actualizado  contrato
        '    obOCItem.pSCUNVLT = ("" & DtServicio.Rows(0).Item("CUNVL5")).ToString.Trim   ' .PSCUNVL5 ' debe ser actualizado  contrato

        '    obOCItem.PSFUNDS2 = ("" & DtServicio.Rows(0).Item("FUNDS2")).ToString.Trim
        '    obOCItem.PSCTPDPS = ("" & DtServicio.Rows(0).Item("CTPDP6")).ToString.Trim

        '    '============== Asigna el valor de la OS

        'Next

        '==========Ejecutamos el proceso de recepcion
        Dim intNroRecepcion As Decimal = 0
        intNroRecepcion = obrMercaderia.fintRecepcionMercaderia(olistMercaderia)

        If intNroRecepcion = 0 Then
            pstrError = "Error producido en la operación de recepción"
            dtCarga_X_Almacen.Rows(0)("OBS_REGISTRO") = pstrError
            MessageBox.Show(pstrError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else


            dtCarga_X_Almacen.Rows(0)("OBS_REGISTRO") = "OK"
            dgvCargaInvAlm.DataSource = dtCarga_X_Almacen

            Dim objFiltro As New Ransa.TypeDef.beDespacho
            With objFiltro
                .PNCCLNT = txtCliente.pCodigo
                .PNNGUIRN = intNroRecepcion
                .pRazonSocial = txtCliente.pCodigo
            End With
            mReporteIngSalRansa(objFiltro)
        End If
    End Sub


    Private Sub TabControl1_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl1.Selected
        Dim TabSel As String = TabControl1.SelectedTab.Name
        Select Case TabSel
            Case "tpCargaAlmacen"
                btnCargaArchivo.Visible = True
                btnGuardar.Visible = True
                btnexportar.Visible = True
            Case "tpCargaUbicacion"
                btnCargaArchivo.Visible = True
                btnGuardar.Visible = True
                btnexportar.Visible = True
        End Select
    End Sub

    Private Sub btnexportar_Click(sender As Object, e As EventArgs) Handles btnexportar.Click
        Try
            Dim TabSel As String = TabControl1.SelectedTab.Name
            Select Case TabSel
                Case "tpCargaAlmacen"
                    Dim ODs As New DataSet
                    Dim objDt As New DataTable
                    Dim loEncabezados As New Generic.List(Of Encabezados)

                    loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Karex_Almacen"))
                    loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "KardexAlmacen"))
                    loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "Carga Inventario por Almacén"))

                    objDt = CType(Me.dgvCargaInvAlm.DataSource, DataTable).Copy



                    ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(dgvCargaInvAlm, objDt))


                    HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)
                Case "tpCargaUbicacion"
                    Dim ODs As New DataSet
                    Dim objDt As New DataTable
                    Dim loEncabezados As New Generic.List(Of Encabezados)

                    loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Karex_Almacen"))
                    loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "KardexAlmacen"))
                    loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "Carga Inventario por Ubicación"))
                    'loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
                    objDt = CType(Me.dgvCargaInvUbic.DataSource, DataTable).Copy



                    ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(dgvCargaInvUbic, objDt))


                    HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)

            End Select


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
End Class