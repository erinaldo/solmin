Imports Ransa.TypeDef.OrdenCompra.WSyrcRns

Namespace ImportarOC
    Public Class ImportarOcYRC
        Private objRansYrc As WSyrcRns.AddData
        Dim dstTemp As DataSet = Nothing


        Sub New()
            objRansYrc = New WSyrcRns.AddData
        End Sub

        Public Function GetOC(ByVal pIntCliente As Integer, ByVal pstrOc As String) As DataTable  'DataRow()
            Dim dtTemp As New DataTable
            dtTemp = objRansYrc.GetDataSet(WSyrcRns.typeTable.t001, "CCLIENT=" & pIntCliente & " AND SNROOC='" & pstrOc & "'").Tables("t001") '"CCLIENT,SNROOC", "29,'P39073'"
            Return dtTemp
        End Function

        Public Function GetItems(ByVal pIntCliente As Integer, ByVal pstrOc As String, Optional ByVal pstrItem As String = "") As DataTable  'DataRow()
            Dim dtTemp As New DataTable
            'dtTemp = objRansYrc.GetDataSet(WSyrcRns.typeTable.m002, "CCLIENT=" & pIntCliente & " AND SNROOC='" & pstrOc & "'" & " AND SNROITE='" & pstrItem & "'").Tables("t002") '"CCLIENT,SNROOC", "29,'P39073'"
            dtTemp = objRansYrc.GetDataSet(WSyrcRns.typeTable.t002, "CCLIENT=" & pIntCliente & " AND SNROOC='" & pstrOc & "'").Tables("t002") '"CCLIENT,SNROOC", "29,'P39073'"
            Return dtTemp
        End Function

        Public Function GetItem(ByVal pIntCliente As Integer, ByVal pstrOc As String, Optional ByVal pstrItem As String = "") As DataTable  'DataRow()
            Dim dtTemp As New DataTable
            dtTemp = objRansYrc.GetDataSet(WSyrcRns.typeTable.m002, "CCLIENT=" & pIntCliente & " AND SNROOC='" & pstrOc & "'" & " AND SNROITE='" & pstrItem & "'").Tables("t002") '"CCLIENT,SNROOC", "29,'P39073'"
            'dtTemp = objRansYrc.GetDataSet(WSyrcRns.typeTable.t002, "CCLIENT=" & pIntCliente & " AND SNROOC='" & pstrOc & "'").Tables("t002") '"CCLIENT,SNROOC", "29,'P39073'"
            Return dtTemp
        End Function

        Public Function GetOC_X_Fecha_Act(ByVal pIntCliente As Integer, ByVal FechaIni As DateTime, ByVal FechaFin As DateTime) As DataTable  'DataRow()
            Dim dtTemp As New DataTable
            Dim ExpresionIni As Int32 = 0
            Dim ExpresionFin As Int32 = 0
            ExpresionIni = FechaIni.Date.ToString("yyyyMMdd")
            ExpresionFin = FechaFin.Date.ToString("yyyyMMdd")
            dtTemp = objRansYrc.GetDataSet(WSyrcRns.typeTable.t001, "CCLIENT=" & pIntCliente & " AND CAST( CONVERT(CHAR(10),DFECACT,112) AS  INT) BETWEEN " & ExpresionIni & " and " & ExpresionFin).Tables("t001")
            Return dtTemp
        End Function

        Public Function GetOC_Varios(ByVal pIntCliente As Integer, ByVal pstrOc As String) As DataTable  'DataRow()
            Dim dtTemp As New DataTable
            'like '%112%'
            dtTemp = objRansYrc.GetDataSet(WSyrcRns.typeTable.t001, "CCLIENT=" & pIntCliente & " AND UPPER(SNROOC) LIKE '%" & pstrOc.ToUpper & "%'").Tables("t001") '"CCLIENT,SNROOC", "29,'P39073'"
            Return dtTemp
        End Function


    End Class
End Namespace

