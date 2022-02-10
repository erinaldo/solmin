Imports RANSA.DATA
Imports RANSA.TYPEDEF
Imports Ransa.Utilitario


Public Class brUbicacionesXCliente


    Function Lista_UbicacionesXCliente(ByVal cliente As Decimal, ByVal ubicacion As String) As DataTable
        Dim dt As New DataTable
        Dim objDAO As New daUbicacionesXCliente

        'Dim dtNew As New DataTable
        'Dim drnew As DataRow

        dt = objDAO.Lista_UbicacionesXCliente(cliente, ubicacion)

        'If dt.Rows.Count > 0 Then

        'dtNew.Columns.Add("CCLNT")
        'dtNew.Columns.Add("TCMPCL")
        'dtNew.Columns.Add("TUBRFR")
        'dtNew.Columns.Add("FCHCRT")
        'dtNew.Columns.Add("HRACRT")
        'dtNew.Columns.Add("CUSCRT")

        'For Each dr As DataRow In dt.Rows
        '    drnew = dtNew.NewRow
        '    drnew("CCLNT") = dr("CCLNT")
        '    drnew("TCMPCL") = dr("TCMPCL")
        '    drnew("TUBRFR") = dr("TUBRFR")

        'drnew("FCHCRT") = NumeroAFecha(dr("FCHCRT"))
        'drnew("HRACRT") = Decimal_Hora(dr("HRACRT"))
        'drnew("CUSCRT") = dr("CUSCRT")

        'dtNew.Rows.Add(drnew)
        'Next
        'Else
        '    dtNew = Nothing
        'End If

        Return dt

    End Function

    Function folistUbicacionXCliente(ByVal strCodCliente As String) As List(Of beGeneral)
        Dim objDAL As New daUbicacionesXCliente
        Return objDAL.folistUbicacionXCliente(strCodCliente)
    End Function

    Function Insert_UbicacionesXCliente(ByVal cliente As Decimal, ByVal ubicacion As String, ByVal usuario As String) As Int32

        Dim objDAL As New daUbicacionesXCliente
        Return objDAL.Insert_UbicacionesXCliente(cliente, ubicacion, usuario)

    End Function

    Function Update_UbicacionesXCliente(ByVal cliente As Decimal, ByVal ubicacion As String, ByVal anterior As String, ByVal usuario As String, ByVal Estado As String) As Boolean

        Dim objDAL As New daUbicacionesXCliente
        Return objDAL.Update_UbicacionesXCliente(cliente, ubicacion, anterior, usuario, Estado)

    End Function

    Function Delete_UbicacionesXCliente(ByVal cliente As Decimal, ByVal ubicacion As String) As Boolean

        Dim objDAL As New daUbicacionesXCliente
        Return objDAL.Delete_UbicacionesXCliente(cliente, ubicacion)

    End Function


    Public Function NumeroAFecha(ByVal oFecha As Object) As String
        If oFecha = 0 Then Return ""

        Dim y As String = ""
        Dim m As String = ""
        Dim d As String = ""

        y = Left(oFecha.ToString(), 4)
        m = Right(Left(oFecha.ToString(), 6), 2)
        d = Right(oFecha.ToString(), 2)
        Return d & "/" & m & "/" & y
    End Function

    Public Function Decimal_Hora(ByVal oHora As Decimal) As String
        Dim Resultado As String = ""
        Dim s As Int32
        Dim h As Int32
        Dim m As Int32
        Select Case (oHora.ToString.Length)
            Case 6
                h = Int32.Parse(oHora.ToString.Substring(0, 2))
                m = Int32.Parse(oHora.ToString.Substring(2, 2))
                s = Int32.Parse(oHora.ToString.Substring(4, 2))
                If (m.ToString.Length > 1) Then
                    If (s.ToString.Length > 1) Then
                        Resultado = String.Format("{0}:{1}:{2}", h, m, s)
                    Else
                        Resultado = String.Format("{0}:{1}:0{2}", h, m, s)
                    End If
                ElseIf (s.ToString.Length > 1) Then
                    Resultado = String.Format("{0}:0{1}:{2}", h, m, s)
                Else
                    Resultado = String.Format("{0}:0{1}:0{2}", h, m, s)
                End If
            Case 5
                h = Int32.Parse(oHora.ToString.Substring(0, 1))
                m = Int32.Parse(oHora.ToString.Substring(1, 2))
                s = Int32.Parse(oHora.ToString.Substring(3, 2))
                If (m.ToString.Length > 1) Then
                    If (s.ToString.Length > 1) Then
                        Resultado = String.Format("0{0}:{1}:{2}", h, m, s)
                    Else
                        Resultado = String.Format("0{0}:{1}:0{2}", h, m, s)
                    End If
                ElseIf (s.ToString.Length > 1) Then
                    Resultado = String.Format("0{0}:0{1}:{2}", h, m, s)
                Else
                    Resultado = String.Format("0{0}:0{1}:0{2}", h, m, s)
                End If
            Case 4
                h = Int32.Parse(oHora.ToString.Substring(0, 2))
                Resultado = String.Format("{0}:00:00", h)
            Case 3
                h = Int32.Parse(oHora.ToString.Substring(0, 1))
                Resultado = String.Format("0{0}:00:00", h)
        End Select
        Return Resultado
    End Function


End Class
