Public Class Formato_Documento

    Public Shared Function FormatearDocGuiaRemision(Tipo As String, Documento As String) As String
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

    'Private Function formatear_nro_guia_remision(Tipo As String, Nro_Guia_S As String) As String
    '    Dim guia_final As String = ""
    '    Select Case Tipo
    '        Case ""
    '            Nro_Guia_S = Nro_Guia_S.PadLeft(10, "0")
    '            guia_final = Nro_Guia_S.Substring(0, 3) & "-" & Nro_Guia_S.Substring(3, 7)
    '        Case "E"
    '            Nro_Guia_S = Nro_Guia_S.PadLeft(12, "0")
    '            guia_final = Nro_Guia_S.Substring(0, 4) & "-" & Nro_Guia_S.Substring(4, 8)
    '        Case Else
    '            guia_final = Nro_Guia_S
    '    End Select
    '    Return guia_final
    'End Function


End Class
