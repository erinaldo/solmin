Imports System.IO

Namespace Helpclass_txt

    Public Class HelpClass_Txt
        Public Shared Function FormatString(ByVal Orientacion As CharDirection, ByVal TipoRelleno As AutoCompleteType, ByVal Texto As String, ByVal cantidad As Int32) As String

            'If Texto.Trim = "" Then
            '    Texto = "/"
            'End If

            If Orientacion = CharDirection.Left Then
                Texto = Texto.Trim().PadRight(cantidad, IIf(TipoRelleno = AutoCompleteType.Numeric, "0", " "))
            Else
                Texto = Texto.Trim().PadLeft(cantidad, IIf(TipoRelleno = AutoCompleteType.Numeric, "0", " "))
            End If

            Return Texto
        End Function

    End Class

    Public Class DataFormat

        'ya lo completan como propiedad
        Public _columnname As String
        Public _columnlenght As Int32
        Public _columncharautocomplete As AutoCompleteType
        Public _columnchardirection As CharDirection

        Sub New(ByVal columnname As String, ByVal columnlenght As Int32, ByVal columncharautocomplete As AutoCompleteType, ByVal columnchardirection As CharDirection)
            _columnname = columnname
            _columnlenght = columnlenght
            _columncharautocomplete = columncharautocomplete
            _columnchardirection = columnchardirection
        End Sub

    End Class

    Public Enum AutoCompleteType
        White_Space = 0
        Numeric = 1
    End Enum

    Public Enum CharDirection
        Left = 0
        Right = 1
    End Enum
End Namespace


