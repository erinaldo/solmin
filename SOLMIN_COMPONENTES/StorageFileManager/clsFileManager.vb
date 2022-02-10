Public Class clsFileManager

    Public Function getFolderAll(ByVal CCMPN As String, ByVal CCLNT As Int32) As DataTable
        Try
            Dim ws As New WsClientFileManager
            Dim objResult As DataTable
            'ws.Url = "http://localhost:19075/SOLMINDOCS/WsFileManager.asmx?wsdl"
            objResult = ws.getFolderAll(CCMPN, CCLNT)
            Return objResult
        Catch ex As Exception
            Return New DataTable
        End Try
    End Function

    Public Function getSubFolder(ByVal CCMPN As String, ByVal CCLNT As Int32, ByVal IdFolder As Int32, ByVal pNameFile As String) As DataSet
        Try
            Dim ws As New WsClientFileManager
            Dim objResult As DataSet
            objResult = ws.getSubFolder(CCMPN, CCLNT, IdFolder, pNameFile)
            Return objResult
        Catch ex As Exception
            Return New DataSet
        End Try
    End Function

    Public Function getFileData(ByVal obj As FileData) As FileData
        Try
            Dim ws As New WsClientFileManager
            Dim objResult As FileData
            objResult = ws.getFile(obj)
            Return objResult
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function saveFolder(ByVal obj As FileData) As FileData
        Dim objResult As New FileData
        Try
            Dim ws As New WsClientFileManager
            objResult = ws.createDirectory(obj)
            Return objResult
        Catch ex As Exception
            Return objResult
        End Try
    End Function


    Public Function saveFile(ByVal obj As FileData) As FileData
        Dim objResult As New FileData
        Try
            Dim ws As New WsClientFileManager
            objResult = ws.saveFile(obj)
            Return objResult
        Catch ex As Exception
            Return objResult
        End Try
    End Function


    Public Function deleteFile(ByVal obj As FileData) As Boolean
        Dim objResult As Boolean
        Try
            Dim ws As New WsClientFileManager
            objResult = ws.deleteFile(obj)
            Return objResult
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function modyfyFile(ByVal obj As FileData) As Boolean
        Dim objResult As Boolean
        Try
            Dim ws As New WsClientFileManager
            If ws.modifyFile(obj) = True Then
                objResult = True
            End If
            Return objResult
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function getFileCount(ByVal obj As FileData) As Decimal
        Try
            Dim ws As New WsClientFileManager
            Return ws.getFileCount(obj)
        Catch ex As Exception
            Return -1
        End Try
    End Function

End Class