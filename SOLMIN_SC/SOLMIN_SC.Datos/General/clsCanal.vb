Imports SOLMIN_SC.Entidad
Public Class clsCanal
    Public Function Lista_Canal(ByVal TipoEmbarque As String) As List(Of beCanal)
        Dim oListCanal As New List(Of beCanal)
        Dim obeCanal As beCanal

        obeCanal = New beCanal
        obeCanal.PSNCANAL = "NARANJA"
        obeCanal.PSTCANAL = "NARANJA"
        obeCanal.PSTCANAL_ING = "ORANGE"
        oListCanal.Add(obeCanal)

        obeCanal = New beCanal
        obeCanal.PSNCANAL = "ROJO"
        obeCanal.PSTCANAL = "ROJO"
        obeCanal.PSTCANAL_ING = "RED"
        oListCanal.Add(obeCanal)


        Select Case TipoEmbarque
            Case "", "IM"
                obeCanal = New beCanal
                obeCanal.PSNCANAL = "VERDE"
                obeCanal.PSTCANAL = "VERDE"
                obeCanal.PSTCANAL_ING = "GREEN"
                oListCanal.Add(obeCanal)
            Case "EX"

        End Select
        Return oListCanal
    End Function

End Class
