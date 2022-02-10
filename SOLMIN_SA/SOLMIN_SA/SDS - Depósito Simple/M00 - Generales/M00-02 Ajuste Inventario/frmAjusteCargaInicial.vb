Imports Ransa.Utilitario
Imports Ransa.TypeDef.Cliente
Imports RANSA.NEGO.slnSOLMIN_SDS
Imports RANSA.NEGO.slnSOLMIN_SDS.DespachoSDS
Imports RANSA.NEGO
Imports Ransa.TypeDef
Imports System.IO


Public Class frmAjusteCargaInicial

    Private obj_Excel As Object
    Private obj_Workbook As Object
    Private obj_Worksheet As Object
    Private obj_SheetName As String
    Private dtFamilia_Grupo As New DataTable
    Private dtAlmacen As New DataTable
    Private dtUnidMedida As New DataTable


    Private Sub frmAjusteCargaInicial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            'Dim objAppConfig As cAppConfig = New cAppConfig
            'Dim intTemp As Int64 = 0
            'Int64.TryParse(objAppConfig.GetValue("RECSDS_ClienteCodigo", GetType(System.String)), intTemp)

            'Dim ClientePK As TD_ClientePK = New TD_ClientePK(intTemp, objSeguridadBN.pUsuario)
            'txtCliente.pCargar(ClientePK)
            'objAppConfig = Nothing
            txtCliente.pUsuario = objSeguridadBN.pUsuario

            cargarTablasValidacion()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnCargarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarExcel.Click
        Try
            If dgvExcel.Rows.Count > 0 Then
                dgvExcel.DataSource = Nothing
            End If
            CargarGrilla()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Function SearchSeleccionadosMayorCero(ByVal obebeMercaderia As beMercaderia) As Boolean
        Return obebeMercaderia.PNQTRMC > 0
    End Function

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        Try
            If dgvExcel.Rows.Count > 0 Then

                If txtCliente.pCodigo = 0 Then
                    MessageBox.Show("Seleccione cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                Dim olst As New List(Of beMercaderia)
                olst = CType(dgvExcel.DataSource, List(Of beMercaderia))

                Dim oListaResumen As New List(Of beMercaderia)
                oListaResumen = olst.FindAll(AddressOf SearchSeleccionadosMayorCero)

                Dim mensaje As String = ValidarGrilla(oListaResumen)
                If (mensaje.Length > 0) Then
                    MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If



                Dim olistMercaderia As New List(Of beMercaderia)
                'Dim obrMercaderia As New brMercaderia
                Dim obeMercaderia As beMercaderia
                'Dim olistbeMercaderia As New List(Of beMercaderia)
                'Dim ListEnvio As New List(Of beMercaderia)

                'PSCMRCLR_NEW
                'PSTMRCD2
                'PNQTRMC
                'PSCUNCN5_NEW
                'PSCFMCLR
                'PSTFMCLR
                'PSCGRCLR
                'PSTGRCLR
                'PSCTPALM
                'PSCALMC
                'PSCZNALM



                For Each obeItem As beMercaderia In oListaResumen
                    obeMercaderia = New beMercaderia
                    obeMercaderia.CORRELATIVO = 0 'intCorrelativo
                    obeMercaderia.PSCMRCD = "" 'falta
                    obeMercaderia.PNNORDSR = 0 ' debe ser actualizado
                    obeMercaderia.PSCMRCLR = obeItem.PSCMRCLR_NEW
                    obeMercaderia.PSCFMCLR = obeItem.PSCFMCLR
                    obeMercaderia.PSCGRCLR = obeItem.PSCGRCLR
                    obeMercaderia.PNNCNTR = 0 ' debe ser actualizado  contrato
                    obeMercaderia.PNNCRCTC = 0  ' debe ser actualizado contrato
                    obeMercaderia.PNNAUTR = 0  ' debe ser actualizado contrato
                    obeMercaderia.PSCUNCNT = "" ' .PSCUNCN5 ' debe ser actualizado  contrato
                    obeMercaderia.PSCUNPST = "" ' .PSCUNPS5 ' debe ser actualizado  contrato
                    obeMercaderia.pSCUNVLT = "" ' .PSCUNVL5 ' debe ser actualizado  contrato
                    obeMercaderia.PSNORCCL = ""
                    obeMercaderia.PSNGUICL = ""
                    obeMercaderia.PSNRUCLL = ""
                    obeMercaderia.PSSTPING = "J" 'debe ser ctualizado
                    'Cantidad de transacción
                    obeMercaderia.PNQTRMC = obeItem.PNQTRMC
                    obeMercaderia.PNQTRMP = 0 'peso debe ser actualizado
                    obeMercaderia.PSCTPALM = obeItem.PSCTPALM
                    obeMercaderia.PSTALMC = ""
                    obeMercaderia.PSCALMC = obeItem.PSCALMC
                    obeMercaderia.PSTCMPAL = ""
                    obeMercaderia.PSCZNALM = obeItem.PSCZNALM
                    obeMercaderia.PSTCMZNA = ""
                    'Cantidad de Kardex
                    obeMercaderia.PNQSLMC2 = obeItem.PNQTRMC
                    obeMercaderia.PNQSLMP2 = 0 ' peso
                    obeMercaderia.PNQDSVGN = 0
                    obeMercaderia.PSFUNDS2 = "" '.PSFUNDS2 'debe ser actualizado 0/s
                    obeMercaderia.PSCTPDPS = "" ' .PSCTPDPS 'debe ser actualizado 0/s
                    obeMercaderia.PSCTPOCN = "0"
                    obeMercaderia.PSTOBSRV = "" ' debe ser actualizado
                    obeMercaderia.PNFRLZSR = HelpClass.CDate_a_Numero8Digitos(Now.Date)

                    obeMercaderia.PSCMRCLR_NEW = obeItem.PSCMRCLR_NEW
                    obeMercaderia.PSTMRCD2 = obeItem.PSTMRCD2
                    obeMercaderia.PSTMRCD3 = ""
                    obeMercaderia.PSCUNCN5_NEW = obeItem.PSCUNCN5_NEW

                    olistMercaderia.Add(obeMercaderia)


                    'PSCMRCLR_NEW
                    'PSTMRCD2
                    'PNQTRMC
                    'PSCUNCN5_NEW

                    'PSCFMCLR
                    'PSTFMCLR
                    'PSCGRCLR
                    'PSTGRCLR
                    'PSCTPALM
                    'PSCALMC
                    'PSCZNALM



                    '    For Each obeMerca As beMercaderia In olistbeMercaderia
                    '        obeMercaderia = New beMercaderia

                    '        With obeMercaderiaSeleccionada
                    '            obeMercaderia.CORRELATIVO = 0 'intCorrelativo
                    '            obeMercaderia.PSCMRCD = .PSCMRCD
                    '            obeMercaderia.PNNORDSR = .PNNORDSR
                    '            obeMercaderia.PSCMRCLR = .PSCMRCLR
                    '            obeMercaderia.PSCFMCLR = .PSCFMCLR
                    '            obeMercaderia.PSCGRCLR = .PSCGRCLR
                    '            obeMercaderia.PNNCNTR = .PNNCNTR
                    '            obeMercaderia.PNNCRCTC = .PNNCRCTC
                    '            obeMercaderia.PNNAUTR = .PNNAUTR
                    '            obeMercaderia.PSCUNCNT = .PSCUNCN5
                    '            obeMercaderia.PSCUNPST = .PSCUNPS5
                    '            obeMercaderia.pSCUNVLT = .PSCUNVL5
                    '            obeMercaderia.PSNORCCL = "" 'fSolicInforMovAlmacen.pstrNroOrdenCompra
                    '            obeMercaderia.PSNGUICL = "" 'fSolicInforMovAlmacen.pstrNroGuiaCliente
                    '            obeMercaderia.PSNRUCLL = "" 'fSolicInforMovAlmacen.pstrNroRUCCliente
                    '            obeMercaderia.PSSTPING = "Q" 'Cambio de código
                    '            'Cantidad de transacción
                    '            obeMercaderia.PNQTRMC = obeMerca.PNQSLMC2 '.PNQTRMC
                    '            obeMercaderia.PNQTRMP = obeMerca.PNQSLMP2 '.PNQTRMP
                    '            obeMercaderia.PSCTPALM = obeMerca.PSCTPALM
                    '            obeMercaderia.PSTALMC = obeMerca.PSTALMC
                    '            obeMercaderia.PSCALMC = obeMerca.PSCALMC
                    '            obeMercaderia.PSTCMPAL = obeMerca.PSTCMPAL
                    '            obeMercaderia.PSCZNALM = obeMerca.PSCZNALM
                    '            obeMercaderia.PSTCMZNA = obeMerca.PSTCMZNA
                    '            'Cantidad de Kardex
                    '            obeMercaderia.PNQSLMC2 = obeMerca.PNQSLMC2
                    '            obeMercaderia.PNQSLMP2 = obeMerca.PNQSLMP2
                    '            obeMercaderia.PNQDSVGN = 0
                    '            obeMercaderia.PSFUNDS2 = .PSFUNDS2
                    '            obeMercaderia.PSCTPDPS = .PSCTPDPS
                    '            obeMercaderia.PSCTPOCN = "0"
                    '            obeMercaderia.PSTOBSRV = .PSTOBSRV
                    '            obeMercaderia.PNFRLZSR = HelpClass.CDate_a_Numero8Digitos(Now.Date)

                    '            obeMercaderia.PSCMRCLR_NEW = .PSCMRCLR_NEW.Trim
                    '            obeMercaderia.PSTMRCD2 = .PSTMRCD2
                    '            obeMercaderia.PSTMRCD3 = .PSTMRCD3
                    '            obeMercaderia.PSCUNCN5_NEW = .PSCUNCN5_NEW
                    '        End With
                    '        olistMercaderia.Add(obeMercaderia)
                    '    Next
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



                Dim frm As New frmCargaInventario(txtCliente, olistMercaderia)

                frm.ShowDialog()
                If frm.DialogResult = Windows.Forms.DialogResult.OK Then
                    dgvExcel.DataSource = Nothing
                    MessageBox.Show("Proceso realizado correctamente.")
                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CargarGrilla()
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
        openFileDialog1.InitialDirectory = (System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal))
        openFileDialog1.Filter = "Excel Files (*.XLS;*.CSV;)|*.XLS;*.CSV;|All files (*.*)|*.*"

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            fileName = openFileDialog1.FileName
            extension = Path.GetExtension(openFileDialog1.FileName)
            source = Path.GetFileNameWithoutExtension(openFileDialog1.FileName)
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

        Dim n As Int64 = 7
        Dim NmCount As New NumericUpDown
        NmCount.Maximum = 65536

        Do Until i = 1 Or n = NmCount.Maximum
            n = n + 1
            If Trim(obj_Worksheet.Cells(n, 1).value) = "" Then
                i = 1
            End If
        Loop
        NmCount.Value = n

        '==================Crear lista de Objeto de tipo OC beOrdenDeCOMPRA
        Dim lbeMercaderia As New List(Of beMercaderia)
        Dim obeMercaderia As beMercaderia

        Dim InicioFila As Int32 = 0
        Dim Encontrado As Boolean = False
        Dim ListColumna As New SortedList
        ListColumna.Add(1, "MERCADERIA")
        ListColumna.Add(2, "DESCRIPCION MERCADERIA")
        ListColumna.Add(3, "CANTIDAD")
        ListColumna.Add(4, "UNIDAD DE MEDIDA")
        ListColumna.Add(5, "COD FAMILIA")
        ListColumna.Add(6, "FAMILIA")
        ListColumna.Add(7, "COD GRUPO")
        ListColumna.Add(8, "GRUPO")
        ListColumna.Add(9, "TIPO ALMACEN")
        ListColumna.Add(10, "ALMACEN")
        ListColumna.Add(11, "ZONA")

        Dim msgEncontrado As String = ""
        Dim Celda As String = ""
        Try
            For i = 1 To NmCount.Value - 1
                'MERCADERIA
                If ("" & obj_Worksheet.Cells(i, 1).Value).ToString.Trim = "MERCADERIA" Then
                    InicioFila = i
                    For Each item As DictionaryEntry In ListColumna
                        Celda = ("" & obj_Worksheet.Cells(i, item.Key).Value).ToString.Trim
                        If Celda = item.Value Then
                            Encontrado = True
                        Else
                            Encontrado = False
                            Exit For
                        End If
                    Next
                    Exit For
                End If
            Next
        Catch ex As Exception
            Encontrado = False
            msgEncontrado = ex.Message
        End Try

        If Encontrado = False Then
            Dim muestrMensaje As String = "Estructura no válida"
            If msgEncontrado.Length > 0 Then
                muestrMensaje = muestrMensaje & Chr(13) & msgEncontrado
            End If
            MessageBox.Show(muestrMensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Limpiar()
            Exit Sub
        End If

        For i = InicioFila To NmCount.Value - 2
            obeMercaderia = New beMercaderia
            With obeMercaderia

                Dim codMercaderia As String = ("" & obj_Worksheet.Cells(i + 1, 1).Value)
                If codMercaderia.Length > 30 Or codMercaderia.Length = 0 Then
                    MessageBox.Show("Código de mercadería: " & codMercaderia & " no válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Limpiar()
                    Exit Sub
                Else
                    .PSCMRCLR_NEW = codMercaderia
                End If

                Dim dscMercaderia As String = ("" & obj_Worksheet.Cells(i + 1, 2).Value)
                Dim srerror As String = ""
                dscMercaderia = oValida.validaCaracter(dscMercaderia, srerror)
                If dscMercaderia.Length > 50 Then
                    .PSTMRCD2 = dscMercaderia.Substring(0, 50)
                Else
                    .PSTMRCD2 = dscMercaderia
                End If

                Dim cantidad As String = ("" & obj_Worksheet.Cells(i + 1, 3).Value)
                If cantidad = "" Then
                    .PNQTRMC = 0
                Else
                    If Not IsNumeric(cantidad) Or cantidad.Length > 21 Or Val(cantidad) > 1.0E+15 Then
                        MessageBox.Show("Cantidad: " & cantidad & " no válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Limpiar()
                        Exit Sub
                    End If
                    .PNQTRMC = Val(cantidad)
                End If

                Dim undMedida As String = ("" & obj_Worksheet.Cells(i + 1, 4).Value).ToString.ToUpper
                If undMedida.Length > 3 Or undMedida.Length = 0 Then
                    MessageBox.Show("Unidad de medida: " & undMedida & " no válido. Tamaño máximo(Max:3).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Limpiar()
                    Exit Sub
                Else
                    If undMedida.Length = 0 Then
                        .PSCUNCN5_NEW = "UNI"
                    Else
                        .PSCUNCN5_NEW = undMedida
                    End If
                End If

                Dim codFamilia As String = ("" & obj_Worksheet.Cells(i + 1, 5).Value).ToString.ToUpper
                If codFamilia.Length > 3 Or codFamilia.Length = 0 Then
                    MessageBox.Show("Código familia: " & codFamilia & " no válido. Tamaño máximo(Max:3).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Limpiar()
                    Exit Sub
                Else
                    .PSCFMCLR = codFamilia
                End If

                .PSTFMCLR = ("" & obj_Worksheet.Cells(i + 1, 6).Value)

                Dim codGrupo As String = ("" & obj_Worksheet.Cells(i + 1, 7).Value).ToString.ToUpper
                If codGrupo.Length > 4 Or codGrupo.Length = 0 Then
                    MessageBox.Show("Código grupo: " & codGrupo & " no válido. Tamaño máximo(Max:4).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Limpiar()
                    Exit Sub
                Else
                    .PSCGRCLR = codGrupo
                End If

                .PSTGRCLR = ("" & obj_Worksheet.Cells(i + 1, 8).Value)

                Dim tipAlmacen As String = ("" & obj_Worksheet.Cells(i + 1, 9).Value).ToString.ToUpper
                If tipAlmacen.Length > 2 Or tipAlmacen.Length = 0 Then
                    MessageBox.Show("Tipo de almacén: " & tipAlmacen & " no válido. Tamaño máximo(Max:2).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Limpiar()
                    Exit Sub
                Else
                    .PSCTPALM = tipAlmacen
                End If

                Dim almacen As String = ("" & obj_Worksheet.Cells(i + 1, 10).Value).ToString.ToUpper
                If almacen.Length > 2 Or almacen.Length = 0 Then
                    MessageBox.Show("Almacén: " & almacen & " no válido. Tamaño máximo(Max:2).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Limpiar()
                    Exit Sub
                Else
                    .PSCALMC = almacen
                End If

                Dim zona As String = ("" & obj_Worksheet.Cells(i + 1, 11).Value).ToString.ToUpper
                If zona.Length > 2 Or zona.Length = 0 Then
                    MessageBox.Show("Zona: " & zona & " no válida. Tamaño máximo(Max:2).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Limpiar()
                    Exit Sub
                Else
                    .PSCZNALM = zona
                End If

            End With
            lbeMercaderia.Add(obeMercaderia)
        Next
        Limpiar()

        dgvExcel.AutoGenerateColumns = False
        dgvExcel.DataSource = lbeMercaderia

    End Sub

    Private Sub Limpiar()
        obj_Workbook.Close()
        obj_Excel = Nothing
        obj_Workbook = Nothing
        obj_Worksheet = Nothing
    End Sub


    Private Sub cargarTablasValidacion()
        Dim objNeg As Ransa.NEGO.brDespachoMasivo
        Dim strMensajeError As String = ""
        objNeg = New Ransa.NEGO.brDespachoMasivo()

        dtAlmacen = objNeg.ListarAlmacenValidacionCarga()
        dtFamilia_Grupo = objNeg.ListarGrupoFamiliaValidacionCarga(txtCliente.pCodigo)
        dtUnidMedida = clsGeneral.fdtBuscar_UnidadMedida(strMensajeError, "", "C")

    End Sub

    Private Function ValidarGrilla(ByVal list As List(Of beMercaderia)) As String
        Dim result As String = ""
        Dim oHasTipoAlmacenZona As New Hashtable
        Dim ohasFamiliaGrupo As New Hashtable   
        Dim oHasUnidadMedida As New Hashtable

        Dim Familia_Grupo As String = ""
        Dim Tipo_Almacen_Zona As String = ""
        Dim UnidadQ As String = ""

        For Each Item As beMercaderia In list
            Familia_Grupo = Item.PSCFMCLR.Trim & "_" & Item.PSCGRCLR.Trim
            Tipo_Almacen_Zona = Item.PSCTPALM.Trim & "_" & Item.PSCALMC & "_" & Item.PSCZNALM
            UnidadQ = Item.PSCUNCN5_NEW

            If Not oHasTipoAlmacenZona.Contains(Tipo_Almacen_Zona) Then
                oHasTipoAlmacenZona.Add(Tipo_Almacen_Zona, Tipo_Almacen_Zona)
            End If
            If Not ohasFamiliaGrupo.Contains(Familia_Grupo) Then
                ohasFamiliaGrupo.Add(Familia_Grupo, Familia_Grupo)
            End If


            If Not oHasUnidadMedida.Contains(UnidadQ) Then
                oHasUnidadMedida.Add(UnidadQ, UnidadQ)
            End If


        Next

        Dim TipoAlmZona() As String
        Dim drAlmacen() As DataRow
        For Each item As DictionaryEntry In oHasTipoAlmacenZona
            TipoAlmZona = item.Value.ToString.Split("_")
            drAlmacen = dtAlmacen.Select("CTPALM = '" & TipoAlmZona(0) & "' AND CALMC = '" & TipoAlmZona(1) & "' AND CZNALM = '" & TipoAlmZona(2) & "'")
            If drAlmacen.Length <= 0 Then
                result = "No existe(Tipo/Almacén/Zona) : " & TipoAlmZona(0) & " , " & TipoAlmZona(1) & " , " & TipoAlmZona(2)
                Return result
            End If
        Next

        Dim FamiliaGrupo() As String
        Dim drGrupoFamilia() As DataRow
        For Each item As DictionaryEntry In ohasFamiliaGrupo
            FamiliaGrupo = item.Value.ToString.Split("_")
            drGrupoFamilia = dtFamilia_Grupo.Select("CCLNT = " & txtCliente.pCodigo & " AND CFMCLR = '" & FamiliaGrupo(0) & "' AND CGRCLR = '" & FamiliaGrupo(1) & "'")
            If drGrupoFamilia.Length <= 0 Then
                result = "No existe (Familia/Grupo) : " & FamiliaGrupo(0) & " , " & FamiliaGrupo(1)
                Return result
            End If
        Next

        Dim drUnidad() As DataRow
        For Each item As DictionaryEntry In oHasUnidadMedida
            UnidadQ = item.Value.ToString.Trim
            drUnidad = dtUnidMedida.Select("UNIDAD = '" & UnidadQ & "'")
            If drUnidad.Length <= 0 Then
                result = "No existe (Unidad) : " & UnidadQ
                Return result
            End If
        Next

        Return result
    End Function

        Private Sub txtCliente_InformationChanged() Handles txtCliente.InformationChanged
        Try
            cargarTablasValidacion()
        Catch ex As Exception   
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
