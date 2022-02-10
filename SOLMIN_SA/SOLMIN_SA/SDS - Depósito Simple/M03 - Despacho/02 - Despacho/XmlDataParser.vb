Imports System.Xml
Imports System.IO
Imports System.Text

Public Enum XML_Type
    Columns_like_Attributes = 0
    Columns_like_Nodes = 1
End Enum

Public MustInherit Class XmlDataParser

    Public Shared Function XmlParser(ByVal dtb As DataTable, ByVal XmlDataType As XML_Type) As String

        Dim objDocument As New XmlDocument

        If XmlDataType = XML_Type.Columns_like_Attributes Then
            objDocument = Columns_like_Attributes(dtb)
        Else
            objDocument = Columns_like_Nodes(dtb)
        End If

        Return objDocument.InnerXml()

    End Function

    Public Shared Function XmlParser(ByVal dts As DataSet, ByVal XmlDataType As XML_Type) As String

        Dim objDocument As New XmlDocument

        If XmlDataType = XML_Type.Columns_like_Attributes Then
            objDocument = Columns_like_Attributes(dts.Tables(0))
        Else
            objDocument = Columns_like_Nodes(dts.Tables(0))
        End If

        Return objDocument.InnerXml()

    End Function

    Public Shared Function XmlParser(ByVal dtb As DataTable, ByVal XmlDataType As XML_Type, ByVal GroupNodeName As String, ByVal TableName As String) As Xml.XmlDocument

        If XmlDataType = XML_Type.Columns_like_Attributes Then
            Return Columns_like_Attributes(dtb, GroupNodeName, TableName)
        Else
            Return Columns_like_Nodes(dtb, GroupNodeName, TableName)
        End If

    End Function

    Private Shared Function Columns_like_Attributes(ByVal dtb As DataTable, Optional ByVal GroupName As String = "DataRow", Optional ByVal TableName As String = "DataTable") As XmlDocument

        Dim objXML As New XmlDocument()
        Try

            Dim objRootElement As XmlNode = objXML.CreateElement(TableName)
            objXML.AppendChild(objRootElement)

            For filas As Integer = 0 To dtb.Rows.Count - 1

                Dim objNodoFila As XmlNode = objXML.CreateElement(GroupName)

                For columnas As Integer = 0 To dtb.Columns.Count - 1

                    Dim objNodoAtributo As XmlAttribute = objXML.CreateAttribute(dtb.Columns(columnas).ColumnName)
                    objNodoAtributo.Value = dtb.Rows(filas).Item(columnas).ToString()
                    objNodoFila.Attributes.Append(objNodoAtributo)

                Next
                objRootElement.AppendChild(objNodoFila)
            Next

        Catch ex As Exception
        End Try

        Return objXML

    End Function

    Private Shared Function Columns_like_Nodes(ByVal dtb As DataTable, Optional ByVal GroupName As String = "DataRow", Optional ByVal TableName As String = "DataTable") As XmlDocument

        Dim objXML As New XmlDocument()
        Try
            Dim objRootElement As XmlNode = objXML.CreateElement(TableName)
            objXML.AppendChild(objRootElement)

            For filas As Integer = 0 To dtb.Rows.Count - 1

                Dim objNodoFila As XmlNode = objXML.CreateElement(GroupName)

                For columnas As Integer = 0 To dtb.Columns.Count - 1

                    Dim objNodoColumna As XmlNode = objXML.CreateElement(dtb.Columns(columnas).ColumnName)
                    Dim objNodoTexto As XmlText = objXML.CreateTextNode(IIf(dtb.Rows(filas).Item(columnas).ToString() = "", " ", dtb.Rows(filas).Item(columnas).ToString()))
                    objNodoColumna.AppendChild(objNodoTexto)
                    objNodoFila.AppendChild(objNodoColumna)

                Next
                objRootElement.AppendChild(objNodoFila)
            Next

        Catch ex As Exception
        End Try

        Return objXML

    End Function

    Public Shared Function XmltoDataSet(ByVal objxmlData As String) As DataSet
        Dim dst As New DataSet
        Dim objxml As New XmlTextReader(New IO.StringReader(objxmlData))
        dst.ReadXml(objxml)
        Return dst.Copy
    End Function

End Class
