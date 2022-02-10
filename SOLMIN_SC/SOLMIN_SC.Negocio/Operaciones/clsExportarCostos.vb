Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Text
Imports SOLMIN_SC

Namespace Operaciones

    Public Class clsExportarCostos
        ''' <summary>
        ''' Envia costo de importacion al cliente ABB
        ''' </summary>
        ''' <param name="obeCostos"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GuardarCostoImportacionCabecera(ByVal obeCostos As Hashtable) As Int32
            If ConfigurationWizard.Library() = "DC@DESLIB" Then
                Dim oIntegracionABB As New WSABB.IntegracionTest.IntegracionABBTest
                Return oIntegracionABB.IntegracionInsertarCostoDeImportacionCAB(HashToXmlString(obeCostos))
            Else
                Dim oIntegracionABB As New WSABB.Integracion.IntegracionABB
                Return oIntegracionABB.IntegracionInsertarCostoDeImportacionCAB(HashToXmlString(obeCostos))
            End If

        End Function

        ''' <summary>
        ''' Envia detalle de costo de importacion al Cliente ABB
        ''' </summary>
        ''' <param name="obeCostos"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GuardarCostoImportacionDetalle(ByVal obeCostos As Hashtable) As Int32
            If ConfigurationWizard.Library() = "DC@DESLIB" Then
                Dim oIntegracionABB As New WSABB.IntegracionTest.IntegracionABBTest
                Return oIntegracionABB.IntegracionInsertarCostoDeImportacionDET(HashToXmlString(obeCostos))
            Else
                Dim oIntegracionABB As New WSABB.Integracion.IntegracionABB
                Return oIntegracionABB.IntegracionInsertarCostoDeImportacionDET(HashToXmlString(obeCostos))
            End If
            
        End Function


        ''' <summary>
        ''' Envia Datos ABB - Integracion Embarque ABB
        ''' </summary>
        ''' <param name="obeCostos"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GuardarIntegracionEmbarqueCab(ByVal obeCostos As Hashtable) As Int32
            If ConfigurationWizard.Library() = "DC@DESLIB" Then
                Dim oIntegracionABB As New WSABB.IntegracionTest.IntegracionABBTest
                Return oIntegracionABB.IntegracionInsertarEmbarqueCAB(HashToXmlString(obeCostos))
            Else
                Dim oIntegracionABB As New WSABB.Integracion.IntegracionABB
                Return oIntegracionABB.IntegracionInsertarEmbarqueCAB(HashToXmlString(obeCostos))
            End If

        End Function

        ''' <summary>
        ''' Envia Detalle - Integracion Embarque ABB
        ''' </summary>
        ''' <param name="obeCostos"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GuardarIntegracionEmbarqueDetalle(ByVal obeCostos As Hashtable) As Int32
            If ConfigurationWizard.Library() = "DC@DESLIB" Then
                Dim oIntegracionABB As New WSABB.IntegracionTest.IntegracionABBTest
                Return oIntegracionABB.IntegracionInsertarEmbarqueDET(HashToXmlString(obeCostos))
            Else
                Dim oIntegracionABB As New WSABB.Integracion.IntegracionABB
                Return oIntegracionABB.IntegracionInsertarEmbarqueDET(HashToXmlString(obeCostos))
            End If
        End Function


        Public Shared Function HashToXmlString(ByVal objData As Hashtable) As String
            Dim objXmlData As New StringBuilder()
            objXmlData.Append("<DATATABLE>")
            objXmlData.Append("<ROW>")
            For Each de As DictionaryEntry In objData
                Dim key As String = DirectCast(de.Key, String)
                Dim val As String = DirectCast(de.Value, String)
                objXmlData.Append("<" & key & ">" & val & "</" & key & ">")
            Next
            objXmlData.Append("</ROW>")
            objXmlData.Append("</DATATABLE>")
            
            Return objXmlData.ToString()
        End Function

        Public Shared Sub AbrirDocumento(ByVal Path As String)
            Try
                Dim InfoProceso As New System.Diagnostics.ProcessStartInfo
                Dim Proceso As New System.Diagnostics.Process
                With InfoProceso
                    .FileName = Path
                    .CreateNoWindow = True
                    .ErrorDialog = True
                    .UseShellExecute = True
                    .WindowStyle = ProcessWindowStyle.Normal
                End With
                Proceso.StartInfo = InfoProceso
                Proceso.Start()
                Proceso.Dispose()
            Catch
            End Try
        End Sub

    End Class
End Namespace
