Imports SOLMIN_SC.Entidad
Public Class clsAgenteCarga
    Private oAgenteCarga As Datos.clsAgenteCarga
    Private oDt As DataTable

    Sub New()
        oAgenteCarga = New Datos.clsAgenteCarga
    End Sub

    Property Lista()
        Get
            Return oDt
        End Get
        Set(ByVal value)
            oDt = value
        End Set
    End Property

    Public Function Lista_Agente_Carga(Optional ByVal pintFlag As Integer = 0) As DataTable
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
        oDt = oAgenteCarga.Lista_Agente_Carga
    End Sub

    Public Function Lista_AgenteCarga_Todos() As List(Of beAgenteCarga)
        Dim Lista As New List(Of beAgenteCarga)
        Dim dalAgenteCarga As New Datos.clsAgenteCarga
        Dim dt As New DataTable
        dt = dalAgenteCarga.Lista_Agente_Carga
        Dim obeAgenteCarga As beAgenteCarga
        For Each Item As DataRow In dt.Rows
            obeAgenteCarga = New beAgenteCarga
            obeAgenteCarga.PNCAGNCR = Item("CAGNCR")
            obeAgenteCarga.PSTNMAGC = Item("TNMAGC")
            Lista.Add(obeAgenteCarga)
        Next
        Return Lista
    End Function
End Class
