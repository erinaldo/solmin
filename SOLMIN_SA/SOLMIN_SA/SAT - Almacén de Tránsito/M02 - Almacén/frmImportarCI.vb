Imports RANSA.NEGO.CargaRecepcion_CC
'Imports Ransa.Negocio.UbicacionPlanta.Planta
Imports Ransa.DAO.OrdenCompra
Imports RANSA.Utilitario
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.TypeDef.OrdenCompra.OrdenCompra
Imports Ransa.TypeDef.OrdenCompra.ItemOC
Imports Ransa.TypeDef
Imports Ransa.NEGO
Imports Ransa.DATA

Public Class frmImportarCI

#Region "Variables"
    Private obj_Excel As Object
    Private obj_Workbook As Object
    Private obj_Worksheet As Object
    Private obj_SheetName As String
    Public nCliente As Decimal = 0
    Public Division As String = String.Empty
    Public Campania As String = String.Empty
    Private mListaBulto As New List(Of beBulto)
#End Region



#Region "Procedimientos y Funciones"

    Private Sub CargarArchivo()

        'Dim obrPlanta As New brPlanta
        Dim obrPlanta As New Ransa.Controls.UbicacionPlanta.Planta.brPlanta

        Dim i As Integer = 12

        Dim obebulto As New beBulto

        Me.OpenFileDialog.Multiselect = False
        'EL DIRECTORIO INICIAL ES MIS DOCUMENTOS
        Me.OpenFileDialog.InitialDirectory = (System.Environment.GetFolderPath _
        (System.Environment.SpecialFolder.Personal))
        'FILTRO LAS EXTENSIONES QUE QUIERO MOSTRAR
        Me.OpenFileDialog.Filter = "Excel Files (*.xls )|*.xls;|All files (*.*)|*.*"
        If Me.OpenFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then ' SI DIO CLICK EN ACEPTAR
            Me.TxtRutaXlsCabecera.Text = Me.OpenFileDialog.FileName


            ' -- RUTINA EXCEL   Instancia Excel  
            If obj_Excel Is Nothing Then
                obj_Excel = CreateObject("Excel.Application")

            End If
            obj_Workbook = obj_Excel.Workbooks.Open(Me.TxtRutaXlsCabecera.Text)
            ' -- Referencia la Hoja, por defecto la hoja activa  
            If obj_SheetName = vbNullString Then
                obj_Worksheet = obj_Workbook.ActiveSheet
            Else
                obj_Worksheet = obj_Workbook.Sheets(obj_SheetName)
            End If


            Dim strReferencia As String = obj_Worksheet.Cells(i, 4).Value
            mListaBulto.Clear()
            While (Not String.IsNullOrEmpty(strReferencia))
                strReferencia = obj_Worksheet.Cells(i, 4).Value
                If Not String.IsNullOrEmpty(strReferencia) Then
                    obebulto = New beBulto
                    obebulto.PSCCMPN = Campania    'Codigo Compania
                    obebulto.PSCDVSN = Division   'Cod Division
                    obebulto.PNCPLNDV = obrPlanta.Lista_Planta_X_Nombre(obj_Worksheet.Cells(i, 2).Value) 'Codigo Planta
                    obebulto.PNCCLNT = nCliente   'clientte
                    obebulto.PSNORCML = obj_Worksheet.Cells(i, 4).Value.ToString.Trim ' Orden de compra
                    obebulto.PSCREFFW = obj_Worksheet.Cells(i, 7).Value 'bulto
                     
                    obebulto.PSTCTCST = obj_Worksheet.Cells(i, 14).Value 'Centro de Costo  
                    obebulto.PSTCTCSA = obj_Worksheet.Cells(i, 15).Value ' Centro de Costo Aereo
                    obebulto.PSTCTCSF = obj_Worksheet.Cells(i, 16).Value '  Centro de Costo Fluvial 
                    obebulto.PSTCTAFE = obj_Worksheet.Cells(i, 17).Value '  Cuenta de Afectacion 

                    obebulto.PSUSUARIO = objSeguridadBN.pUsuario
                    mListaBulto.Add(obebulto)
                    i = i + 1
                End If
            End While
            dgCabecera.AutoGenerateColumns = False
            dgCabecera.DataSource = Nothing
            dgCabecera.DataSource = mListaBulto
            Limpiar()
            tsbGuardar.Enabled = True
        End If
    End Sub

    Private Function BuscaMediotransporte(ByVal strMedioTransporte As String) As Integer
        Dim nRetorno As Integer = 0
        Dim obrGeneral As New brGeneral
        Dim opbeGeneral As New beGeneral

        If Not String.IsNullOrEmpty(strMedioTransporte) Then

            Dim Mlist = obrGeneral.ListaMedioTransporte(opbeGeneral)

            For Each obeGeneral As beGeneral In Mlist
                If strMedioTransporte.Trim = obeGeneral.PSTNMMDT.Trim Then
                    nRetorno = obeGeneral.PNCMEDTR
                    Exit For
                End If
            Next
        End If

        Return nRetorno
    End Function

    Private Sub Limpiar()
        obj_Workbook = Nothing
        obj_Excel = Nothing
        obj_Worksheet = Nothing
    End Sub

#End Region

#Region "Eventos de Conttrol"

    Private Sub btnCargarCabecera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarCabecera.Click
        Try
            CargarArchivo()
        Catch ex As Exception
            HelpClass.ErrorMsgBox()
        End Try

    End Sub

    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        Dim CargaRecepcionNeg As New CargaRecepcion_CC
        Try
            For Each be As beBulto In mListaBulto
                If CargaRecepcionNeg.Actualizar_CuentasImputacion(be) = 0 Then
                    HelpClass.ErrorMsgBox()
                Else
                    Dim obeOrdenCompra As New beOrdenCompra
                    With obeOrdenCompra
                        .PNCCLNT = be.PNCCLNT
                        .PSNORCML = be.PSNORCML
                        .PSTCTCST = ("" & be.PSTCTCST & "").Trim
                        .PSTCTCSA = ("" & be.PSTCTCSA & "").Trim
                        .PSTCTAFE = ("" & be.PSTCTAFE & "").Trim
                        .PSTCTCSF = ("" & be.PSTCTCSF & "").Trim
                        .PSUSUARIO = objSeguridadBN.pUsuario
                        .PSNTRMNL = objSeguridadBN.pstrPCName
                        .PSTLUGEN = be.PSTLUGEN
                        .PNCMEDTS = be.PNCMEDTS
                    End With
                    If Not (obeOrdenCompra.PSTCTCST.Trim.Equals("") AndAlso obeOrdenCompra.PSTCTCSA.Trim.Equals("") AndAlso obeOrdenCompra.PSTCTAFE.Trim.Equals("") AndAlso obeOrdenCompra.PSTCTCSF.Trim.Equals("")) Then
                        InsertarCuentaImputacion(obeOrdenCompra)
                    End If

                End If
            Next
            HelpClass.MsgBox("Registro Satisfactorio.")
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            HelpClass.ErrorMsgBox()
        End Try



    End Sub

    Private Sub InsertarCuentaImputacion(ByVal obeOrdenCompra As beOrdenCompra)
        Dim obrOrdenCompra As New brOrdenDeCompra
        If obrOrdenCompra.fintInsertarCuentaImputacionOrdenDeCompra(obeOrdenCompra) = 0 Then
            HelpClass.ErrorMsgBox()
        End If
    End Sub


    Private Sub bsaCerrarVentana_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsaCerrarVentana.Click
        Me.Close()
        Me.Dispose()
    End Sub

#End Region

End Class
