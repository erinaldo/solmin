Imports SOLMIN_SC.Entidad
Public Class clsTerminal
    Private oTerminal As Datos.clsTerminal
    Private oDt As DataTable

    Sub New()
        oTerminal = New Datos.clsTerminal
    End Sub

    Property Lista()
        Get
            Return oDt
        End Get
        Set(ByVal value)
            oDt = value
        End Set
    End Property

    Public Function Lista_Terminal(Optional ByVal pintFlag As Integer = 0) As DataTable
        Dim objDr As DataRow
        Dim objDt As DataTable

        objDt = oDt.Copy
        If objDt.Rows.Count > 0 And pintFlag = 0 Then
            objDr = objDt.NewRow
            objDr(0) = "0"
            objDr(1) = "TODOS"
            objDt.Rows.InsertAt(objDr, 0)
        End If
        Return objDt
    End Function

    Public Sub Crea_Lista()
        oDt = oTerminal.Lista_Terminal
    End Sub

    Public Function Lista_terminal_Todos() As List(Of beterminal)
        Dim Lista As New List(Of beTerminal)
        Dim dalTerminal As New Datos.clsTerminal
        Dim dt As New DataTable
        dt = dalTerminal.Lista_Terminal
        Dim obeTerminal As beTerminal
        For Each Item As DataRow In dt.Rows
            obeTerminal = New beTerminal
            obeTerminal.PSCTRMAL = Item("CTRMAL")
            obeTerminal.PSTTRMAL = Item("TTRMAL")
            Lista.Add(obeTerminal)
        Next
        Return Lista
    End Function
End Class
