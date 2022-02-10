Imports System.Text
Public Class clsEmbarque

  Enum TIPO_BUSQUEDA
    OC_PARCIAL
    OC_PARCIAL_ITEM
  End Enum

  Public Function Lista_SeguimientoAduanero(ByVal objEntidad As beEmbarqueEntidad) As DataTable
    Dim oDAL As New clsEmbarqueDAL
    Dim dt As DataTable
    dt = oDAL.Lista_SeguimientoAduanero(objEntidad)
    Return dt
  End Function

  Public Function ListarItemsXOrdenCompraParcial(ByVal obj As beEmbarqueEntidad) As DataTable

    Dim oDAL As New clsEmbarqueDAL
    Dim NRPEMB As Decimal = 0
    Dim Principal As New DataSet
    Dim odtJoinItemOCParcial As New DataTable
    Dim dtCHKItemOCParcial As New DataTable
    Dim odtListaCHK As New DataTable

    Principal = oDAL.LISTA_ITEMS_X_ORDEN_COMPRA_CONSULTA(obj)
    odtJoinItemOCParcial = Principal.Tables("dtPreEmbarque")
    dtCHKItemOCParcial = Principal.Tables("dtDetalleCHK")
    odtListaCHK = Principal.Tables("dtCHKCliente")

    Dim TDESES_CHK As String = ""
    Dim NESTDO_CHK As String = ""
    Dim CCLNT As Decimal = 0
    Dim NRITOC As Decimal = 0
    For Each drCHKItem As DataRow In odtListaCHK.Rows
      NESTDO_CHK = drCHKItem("NESTDO")
      TDESES_CHK = drCHKItem("TDESES").ToString().Trim()
      odtJoinItemOCParcial.Columns.Add(NESTDO_CHK & "_DFECEST")
      odtJoinItemOCParcial.Columns.Add(NESTDO_CHK & "_DFECREA")
      odtJoinItemOCParcial.Columns(NESTDO_CHK & "_DFECEST").Caption = TDESES_CHK & "- ESTIMADO"
      odtJoinItemOCParcial.Columns(NESTDO_CHK & "_DFECREA").Caption = TDESES_CHK & "- REAL"
    Next
    Dim obeCHKFecha As beEmbarqueEntidad
    For Each drItem As DataRow In odtJoinItemOCParcial.Rows
      NRPEMB = drItem("NRPEMB")
      For Each drCHKItem As DataRow In odtListaCHK.Rows
        NESTDO_CHK = drCHKItem("NESTDO")
        obeCHKFecha = New beEmbarqueEntidad
        obeCHKFecha = FindCHKxPreEmbarque(dtCHKItemOCParcial, NRPEMB, NESTDO_CHK)
        drItem(NESTDO_CHK & "_DFECEST") = obeCHKFecha.PSDFECEST
        drItem(NESTDO_CHK & "_DFECREA") = obeCHKFecha.PSDFECREA
      Next
    Next
    Return odtJoinItemOCParcial
  End Function

  Private Function FindCHKxPreEmbarque(ByVal odtCHK As DataTable, ByVal NRPEMB As Decimal, ByVal NESTDO As Decimal) As beEmbarqueEntidad
    Dim obeCHKFecha As New beEmbarqueEntidad
    Dim dr() As DataRow
    Dim DFECEST As String = ""
    Dim DFECREA As String = ""
    Dim oListDFECEST As New List(Of String)
    Dim oListDFECREA As New List(Of String)
    Dim sbDFECEST As New StringBuilder
    Dim sbDFECREA As New StringBuilder
    Dim numReg As Int32 = 0
    Dim oHasObs As New Hashtable
    Dim sb As New StringBuilder

    dr = odtCHK.Select("NRPEMB=" & NRPEMB & " AND NESTDO=" & NESTDO)
    If (dr.Length > 0) Then
      DFECEST = dr(0)("DFECEST").ToString.Trim
      DFECREA = dr(0)("DFECREA").ToString.Trim

      If (DFECEST.Length > 0) Then
        If (Not oListDFECEST.Contains(DFECEST)) Then
          oListDFECEST.Add(DFECEST)
          sbDFECEST.Append(DFECEST)
          sbDFECEST.AppendLine()
        End If
      End If
      If (DFECREA.Length > 0) Then
        If (Not oListDFECREA.Contains(DFECREA)) Then
          oListDFECREA.Add(DFECREA)
          sbDFECREA.Append(DFECREA)
          sbDFECREA.AppendLine()
        End If
      End If
    End If
    If (oListDFECEST.Count = 1) Then
      obeCHKFecha.PSDFECEST = oListDFECEST(0).Trim
    Else
      obeCHKFecha.PSDFECEST = sbDFECEST.ToString.Trim
    End If

    If (oListDFECREA.Count = 1) Then
      obeCHKFecha.PSDFECREA = oListDFECREA(0).Trim
    Else
      obeCHKFecha.PSDFECREA = sbDFECREA.ToString.Trim
    End If
    Return obeCHKFecha
  End Function

End Class
