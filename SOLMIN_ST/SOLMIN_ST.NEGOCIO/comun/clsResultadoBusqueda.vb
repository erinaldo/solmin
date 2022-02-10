Public Class clsResultadoBusqueda
    Private oListCampo_Resultado As New List(Of ENTIDADES.beResultadoBusqueda)
    Public Sub AddCampo(NombreColumnaCampo As String, Optional ConvertToDate As Boolean = False, Optional Sumarizar As Boolean = False, Optional FormatGuia As Boolean = False)
        Dim obeResultadoBusqueda As New ENTIDADES.beResultadoBusqueda
        obeResultadoBusqueda.NombreColumnaCampo = NombreColumnaCampo
        obeResultadoBusqueda.ConvertToDate = ConvertToDate
        obeResultadoBusqueda.Sumarizar = Sumarizar
        obeResultadoBusqueda.FormatGuia = FormatGuia

        oListCampo_Resultado.Add(obeResultadoBusqueda)
    End Sub

    Public Sub EjecutarBusquedaCampos(dt As DataTable)

        Dim ListDuplicado As New Hashtable
        Dim CeldaValorTexto As String = ""
        Dim CeldaValorSuma As Decimal = 0
        Dim strCeldaValor As String = ""
        Dim ColumnaListado As String = ""
        For Each item As DataRow In dt.Rows
            For Each obeResultado As ENTIDADES.beResultadoBusqueda In oListCampo_Resultado
                ColumnaListado = obeResultado.NombreColumnaCampo
                If obeResultado.Sumarizar = False Then

                    CeldaValorTexto = ("" & item(ColumnaListado)).ToString.Trim
                    If CeldaValorTexto <> "" And CeldaValorTexto <> "0" And Not ListDuplicado.Contains(ColumnaListado & "_" & CeldaValorTexto) Then
                        ListDuplicado(ColumnaListado & "_" & CeldaValorTexto) = ColumnaListado & "_" & CeldaValorTexto
                        If obeResultado.ConvertToDate = True Then
                            CeldaValorTexto = Ransa.Utilitario.HelpClass.CFecha_de_8_a_10(CeldaValorTexto)
                        End If

                        If obeResultado.FormatGuia = True Then
                            CeldaValorTexto = FormatearDocGuia(item("CTDGRM"), CeldaValorTexto)
                        End If
                        obeResultado.ResultadoText = obeResultado.ResultadoText & "," & CeldaValorTexto & Chr(13)
                    End If

                End If

                If obeResultado.Sumarizar = True Then
                    CeldaValorSuma = Val("" & item(ColumnaListado))
                    obeResultado.ResultadoSuma = obeResultado.ResultadoSuma + CeldaValorSuma
                End If

            Next
        Next
        For Each obeResultado As ENTIDADES.beResultadoBusqueda In oListCampo_Resultado
            obeResultado.ResultadoText = obeResultado.ResultadoText.Trim
            If obeResultado.ResultadoText.Length > 0 Then
                obeResultado.ResultadoText = obeResultado.ResultadoText.Substring(1)
            End If

        Next
    End Sub

    Public Function GetCampo(strCampo As String) As String
        Dim result As String = ""
        For Each obeResultado As ENTIDADES.beResultadoBusqueda In oListCampo_Resultado
            If obeResultado.NombreColumnaCampo = strCampo Then
                result = obeResultado.ResultadoText
                Exit For
            End If
        Next
        Return result
    End Function
    Public Function GetCampoSuma(strCampo As String) As Decimal
        Dim result As Decimal = 0
        For Each obeResultado As ENTIDADES.beResultadoBusqueda In oListCampo_Resultado
            If obeResultado.NombreColumnaCampo = strCampo Then
                result = obeResultado.ResultadoSuma
                Exit For
            End If
        Next
        Return result
    End Function

    Private Function FormatearDocGuia(Tipo As String, Documento As String) As String
        Dim tamanio As String = Documento.Length
        Select Case Tipo
            Case "F"
                If tamanio <= 10 Then
                    Documento = Documento.PadLeft(10, "0")
                    Documento = Documento.Substring(0, 3) & "-" & Documento.Substring(3, 7)
                End If

            Case "E"
                'If tamanio = 12 Then
                '    Documento = Documento.Substring(0, 4) & "-" & Documento.Substring(4, 8)
                'End If
                Documento = Documento.Substring(0, 4) & "-" & Documento.Substring(4)
        End Select
        Return Documento
    End Function


End Class
