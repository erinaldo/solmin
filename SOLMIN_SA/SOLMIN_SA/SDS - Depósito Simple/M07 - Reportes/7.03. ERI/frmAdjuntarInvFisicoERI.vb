Imports RANSA.NEGO.CargaRecepcion_CC
Imports Ransa.Negocio.UbicacionPlanta.Planta
Imports Ransa.TypeDef
Imports Ransa.NEGO

Public Class frmAdjuntarInvFisicoERI

#Region "Variables"
    Private obj_Excel As Object
    Private obj_Workbook As Object
    Private obj_Worksheet As Object
    Private obj_SheetName As String
    Private NmCount As Decimal = 0D
    Private lstbeAdjuntarMercaderia As New List(Of beAdjuntarMercaderia)
#End Region

#Region "Propiedades"

    Private _PSCCMPN As String
    Private _PNCPLNDV As Decimal
    Private _PNCCLNT As Decimal
    Private _PSNroEri As String
    Private _PSCRGVTA As String

    ''' <summary>
    ''' Propiedad Campaña
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PSCCMPN() As String
        Get
            Return _PSCCMPN
        End Get
        Set(ByVal value As String)
            _PSCCMPN = value
        End Set
    End Property

    ''' <summary>
    ''' Propiedad Planta
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PNCPLNDV() As Decimal
        Get
            Return _PNCPLNDV
        End Get
        Set(ByVal value As Decimal)
            _PNCPLNDV = value
        End Set
    End Property

    ''' <summary>
    ''' Propiedad Cod. Cliente
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PNCCLNT() As Decimal
        Get
            Return _PNCCLNT
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
        End Set
    End Property

    Public Property PSNroEri() As String
        Get
            Return (_PSNroEri)
        End Get
        Set(ByVal value As String)
            _PSNroEri = value
        End Set
    End Property


    Public Property PSCRGVTA() As String
        Get
            Return (_PSCRGVTA)
        End Get
        Set(ByVal value As String)
            _PSCRGVTA = value
        End Set
    End Property


#End Region

#Region "Eventos de Formulario"
    Private Sub frmAdjuntarInvFisicoERI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNroDocEri.Text = PSNroEri
    End Sub

    Private Sub kbConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kbConsulta.Click
        Try
            Dim NumSheets As Integer
            Dim NomSheets As String
            Dim i As Integer
            Dim n As Integer
            'No Seleccionar Multiples Archivos 
            Me.OpenFileDialog.Multiselect = False
            'EL DIRECTORIO INICIAL ES MIS DOCUMENTOS
            Me.OpenFileDialog.InitialDirectory = (System.Environment.GetFolderPath _
            (System.Environment.SpecialFolder.Personal))
            'FILTRO LAS EXTENSIONES QUE QUIERO MOSTRAR
            Me.OpenFileDialog.Filter = "Excel Files (*.XLS;*.CSV;)|*.XLS;*.CSV;|All files (*.*)|*.*"
            If Me.OpenFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.txtRuta.Text = Me.OpenFileDialog.FileName
                obj_Excel = CreateObject("Excel.Application")
                Dim CurrentCI = System.Threading.Thread.CurrentThread.CurrentCulture

                System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
                obj_Workbook = obj_Excel.Workbooks.Open(Me.txtRuta.Text)
                NumSheets = obj_Workbook.sheets.count()
                For i = 1 To NumSheets
                    NomSheets = obj_Workbook.Sheets.Item(i).Name
                Next
                n = 0
                i = 0
                obj_Worksheet = obj_Workbook.Sheets(obj_Workbook.Sheets.Item(1).Name)
                Do Until i = 3 Or n = 1000
                    n = n + 1
                    If Trim(obj_Worksheet.Cells(n + 2, 2).value) = String.Empty Then
                        i = 3
                    End If
                Loop
                NmCount = n - 1
                kbAbrir.Enabled = True
                System.Threading.Thread.CurrentThread.CurrentCulture = CurrentCI
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub kbAbrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kbAbrir.Click
        Try
            Dim i As Integer
            ' -- Verifica si existe el archivo   
            If Len(Dir(Me.txtRuta.Text)) = 0 Then
                MessageBox.Show("No se ha encontrado el archivo: " & Me.txtRuta.Text, "Generar Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            Dim CurrentCI = System.Threading.Thread.CurrentThread.CurrentCulture

            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
            '===================================================================
            ' -- RUTINA EXCEL   Instancia Excel  
            If obj_Excel Is Nothing Then
                obj_Excel = CreateObject("Excel.Application")
                
                obj_Workbook = obj_Excel.Workbooks.Open(Me.txtRuta.Text)
            End If
            ' -- Referencia la Hoja, por defecto la hoja activa  
            If obj_SheetName = vbNullString Then
                obj_Worksheet = obj_Workbook.ActiveSheet
            Else
                obj_Worksheet = obj_Workbook.Sheets(obj_SheetName)
            End If
            '==================Crear lista================== 
            Dim intContaErrorCodMercaderia As Integer = 0
            Dim intContaErrorStock As Integer = 0
            Dim intContaErrorUnidad As Integer = 0
            For i = 1 To NmCount
                'If Not validate_qty(obj_Worksheet.Cells(i + 2, 2).value.ToString()) Then
                If obj_Worksheet.Cells(i + 2, 2).value.ToString().Length > 35 Then
                    intContaErrorCodMercaderia = 1
                End If
                If Not validate_qty(obj_Worksheet.Cells(i + 2, 4).value.ToString()) Then
                    intContaErrorStock = 1
                End If
                If Len(obj_Worksheet.Cells(i + 2, 5).value.ToString()) > 4 Then
                    intContaErrorUnidad = 1
                End If
                If intContaErrorCodMercaderia > 0 Then
                    MessageBox.Show("El campo: Códio Mercaderia no tiene el formato correcto", "Generar Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                    Exit For

                End If
                If intContaErrorStock > 0 Then
                    MessageBox.Show("El campo: Stock no tiene el formato correcto", "Generar Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                    Exit For
                End If
                If intContaErrorUnidad > 0 Then
                    MessageBox.Show("El campo: Unidad no tiene el formato correcto", "Generar Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                    Exit For
                End If
            Next
            Me.dgDetInventario.AutoGenerateColumns = False
            Dim objbeAdjuntarMercaderia As beAdjuntarMercaderia
            Dim booOk As Boolean = True
            For i = 1 To NmCount
                objbeAdjuntarMercaderia = New beAdjuntarMercaderia
                objbeAdjuntarMercaderia.PSCORRELA = i.ToString()
                objbeAdjuntarMercaderia.PSCMRCLR = obj_Worksheet.Cells(i + 2, 2).value()
                objbeAdjuntarMercaderia.PSTMRCD2 = obj_Worksheet.Cells(i + 2, 3).value()
                objbeAdjuntarMercaderia.PNQSFMC = obj_Worksheet.Cells(i + 2, 4).value()
                objbeAdjuntarMercaderia.PSCUNCN5 = obj_Worksheet.Cells(i + 2, 5).value()
                For Each objbeAdjuntar As beAdjuntarMercaderia In lstbeAdjuntarMercaderia
                    If objbeAdjuntar.PSCMRCLR = obj_Worksheet.Cells(i + 2, 2).value() Then
                        booOk = False
                        Exit For
                    End If
                Next
                If Not booOk Then
                    MessageBox.Show("No debe de repetirse el mismo código de material en varios registros.", "Generar Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                lstbeAdjuntarMercaderia.Add(objbeAdjuntarMercaderia)
            Next
            Me.dgDetInventario.DataSource = lstbeAdjuntarMercaderia
            Call Limpiar()
            KillAllExcels()
            Me.tsbProcesar.Enabled = True
            System.Threading.Thread.CurrentThread.CurrentCulture = CurrentCI
        Catch ex As Exception
            MessageBox.Show("Archivo xls no tiene el formato correcto : " + ex.Message, "Generar Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Se procesó correctamente
            'Error al procesar 
            Call Limpiar()
        Finally
            'lstbeAdjuntarMercaderia = Nothing
        End Try
    End Sub

    Private Sub tsbProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbProcesar.Click
        If MessageBox.Show("¿Desea procesar el Nro. Doc. ERI?", "Generar Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim objblRegistroInventario As New blRegistroInventario
            Dim objbeActEstadoCabEri As New beActualizaEstadoCabERI
            objbeActEstadoCabEri.PSCCMPN = PSCCMPN
            objbeActEstadoCabEri.PSCRGVTA = PSCRGVTA
            objbeActEstadoCabEri.PNCPLNDV = PNCPLNDV
            objbeActEstadoCabEri.PNCCLNT = PNCCLNT
            objbeActEstadoCabEri.PNNROERI = PSNroEri
            objbeActEstadoCabEri.PSCUSERI = objSeguridadBN.pUsuario
            objbeActEstadoCabEri.NTRMCR = objSeguridadBN.pstrPCName
            objbeActEstadoCabEri.PSSTSERI = "P"
            Dim objbeActualizaStockFisicoEri As beActualizaStockFisicoERI
            Dim lstbeActualizaStockFisicoEri As New List(Of beActualizaStockFisicoERI)
            For Each objbeAdjuntarMercaderia As beAdjuntarMercaderia In lstbeAdjuntarMercaderia
                objbeActualizaStockFisicoEri = New beActualizaStockFisicoERI
                objbeActualizaStockFisicoEri.PSCCMPN = PSCCMPN
                objbeActualizaStockFisicoEri.PSCRGVTA = PSCRGVTA
                objbeActualizaStockFisicoEri.PNCPLNDV = PNCPLNDV
                objbeActualizaStockFisicoEri.PNCCLNT = PNCCLNT
                objbeActualizaStockFisicoEri.PNNROERI = PSNroEri
                objbeActualizaStockFisicoEri.PSCMRCLR = objbeAdjuntarMercaderia.PSCMRCLR
                objbeActualizaStockFisicoEri.PNQSFMC = objbeAdjuntarMercaderia.PNQSFMC
                objbeActualizaStockFisicoEri.PNQSFMP = 0
                objbeActualizaStockFisicoEri.PSCUSERI = objSeguridadBN.pUsuario
                objbeActualizaStockFisicoEri.NTRMCR = objSeguridadBN.pstrPCName
                lstbeActualizaStockFisicoEri.Add(objbeActualizaStockFisicoEri)
            Next
            Dim intRetorno As Integer = objblRegistroInventario.ActualizaEstadoCabERI(objbeActEstadoCabEri, lstbeActualizaStockFisicoEri)
            If intRetorno = 1 Then
                MessageBox.Show("Se procesó correctamente", "Generar Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()

            Else
                MessageBox.Show("Error al procesar ", "Generar Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub bsaCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrar.Click
        Me.Close()
    End Sub
#End Region

#Region "Metodos y Funciones"
    Private Function validate_qty(ByVal qty As String) As Boolean
        Try
            Dim objRegExp As New System.Text.RegularExpressions.Regex("^[+-]?(\d+(\.\d+)?|\.\d+)$")
            Return objRegExp.Match(qty).Success
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub Limpiar()
        obj_Workbook = Nothing
        obj_Excel = Nothing
        obj_Worksheet = Nothing
    End Sub


    Sub KillAllExcels()
        Dim proc As System.Diagnostics.Process
        For Each proc In System.Diagnostics.Process.GetProcessesByName("EXCEL")
            If proc.MainWindowTitle.Trim.Length = 0 Then
                'proc.GetCurrentProcess.StartInfo
                proc.Kill()
            End If
        Next
    End Sub


#End Region

End Class