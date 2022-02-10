Imports System.Data
Imports System.Xml

Public MustInherit Class XmlParser

    Public Shared Function XmlData(ByVal DataStructure As DataTable) As Xml.XmlDocument

        Dim objXML As New XmlDocument()
        Try
            Dim objRootElement As XmlNode = objXML.CreateElement("DataTable")
            objXML.AppendChild(objRootElement)

            For filas As Integer = 0 To DataStructure.Rows.Count - 1

                Dim objNodoFila As XmlNode = objXML.CreateElement("DataRow")

                For columnas As Integer = 0 To DataStructure.Columns.Count - 1

                    Dim objNodoColumna As XmlNode = objXML.CreateElement(DataStructure.Columns(columnas).ColumnName)
                    Dim objNodoTexto As XmlText = objXML.CreateTextNode(IIf(DataStructure.Rows(filas).Item(columnas).ToString() = "", " ", DataStructure.Rows(filas).Item(columnas).ToString()))
                    objNodoColumna.AppendChild(objNodoTexto)
                    objNodoFila.AppendChild(objNodoColumna)

                Next
                objRootElement.AppendChild(objNodoFila)
            Next

        Catch ex As Exception
        End Try

        objXML.Save("d:\xmlxmldata.xml")
        Return objXML

    End Function

End Class
