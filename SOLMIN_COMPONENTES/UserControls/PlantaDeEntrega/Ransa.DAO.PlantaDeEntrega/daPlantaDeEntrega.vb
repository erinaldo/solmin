Imports Ransa.TypeDef.PlantaDeEntrega
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class daPlantaDeEntrega
    Inherits daBase(Of TypeDef.PlantaDeEntrega.bePlantaDeEntrega)

    Private objSql As New SqlManager

    Public Function ListarPlantaDeEntrega(ByVal obePlantaDeEntrega As bePlantaDeEntrega) As List(Of bePlantaDeEntrega)
        Dim oDt As New DataTable
        Dim olbePlantaDeEntrega As New List(Of bePlantaDeEntrega)
        Dim objParam As New Parameter
        Try

            objParam.Add("PNCCLNT", obePlantaDeEntrega.PNCCLNT)
            If obePlantaDeEntrega.PNCPRVCL <> 0 Then
                objParam.Add("PNCPRVCL", obePlantaDeEntrega.PNCPRVCL)
            End If
            If obePlantaDeEntrega.PNCPLNCL <> 0 Or Not obePlantaDeEntrega.PSTCMPPL.Trim.ToString.Equals("") Then
                If obePlantaDeEntrega.PNCPLNCL <> 0 Then
                    objParam.Add("PNCPLNCL", obePlantaDeEntrega.PNCPLNCL)
                Else
                    objParam.Add("PNCPLNCL", 0)
                End If
                If Not obePlantaDeEntrega.PSTCMPPL.Trim.ToString.Equals("") Then
                    objParam.Add("PSTCMPPL", obePlantaDeEntrega.PSTCMPPL)
                Else
                    objParam.Add("PSTCMPPL", "")
                End If
            End If

            objParam.Add("PAGESIZE", obePlantaDeEntrega.PageSize)
            objParam.Add("PAGENUMBER", obePlantaDeEntrega.PageNumber)
            objParam.Add("PAGECOUNT", 0, ParameterDirection.Output)
            If obePlantaDeEntrega.TIPOCLIENTE Then
                Return Listar("SP_SOLMIN_SA_SDS_LISTA_PLANTA_DE_ENTREGA_PROPIO", objParam)
            Else
                Return Listar("SP_SOLMIN_SA_SDS_LISTA_PLANTA_DE_ENTREGA_TERCERO", objParam)
            End If
        Catch ex As Exception
            Return olbePlantaDeEntrega
        End Try
    End Function

    Public Function ListarClienteTercero(ByVal obePlantaDeEntrega As bePlantaDeEntrega) As List(Of bePlantaDeEntrega)
        Dim oDt As New DataTable
        Dim olbePlantaDeEntrega As New List(Of bePlantaDeEntrega)
        Dim objParam As New Parameter
        Try

            objParam.Add("PNCCLNT", obePlantaDeEntrega.PNCCLNT)
            objParam.Add("PSSTPORL", obePlantaDeEntrega.PSSTPORL)
            objParam.Add("PNNRUCPR", obePlantaDeEntrega.PNNRUCPR)
            If obePlantaDeEntrega.PNCPRVCL <> 0 Or Not obePlantaDeEntrega.PSTPRVCL.Trim.Equals("") Then
                If obePlantaDeEntrega.PNCPRVCL <> 0 Then
                    objParam.Add("PNCPRVCL", obePlantaDeEntrega.PNCPRVCL)
                Else
                    objParam.Add("PNCPRVCL", 0)
                End If
                If Not obePlantaDeEntrega.PSTPRVCL.Trim.Equals("") Then
                    objParam.Add("PSTPRVCL", obePlantaDeEntrega.PSTPRVCL)
                Else
                    objParam.Add("PSTPRVCL", "")

                End If
            End If
            objParam.Add("PAGESIZE", obePlantaDeEntrega.PageSize)
            objParam.Add("PAGENUMBER", obePlantaDeEntrega.PageNumber)
            objParam.Add("PAGECOUNT", 0, ParameterDirection.Output)
            Return Listar("SP_SOLMIN_SA_SDS_LISTA_CLIENTE_TERCERO", objParam)
        Catch ex As Exception
            Return olbePlantaDeEntrega
        End Try
    End Function

    Public Overrides Sub SetStoredprocedures()

    End Sub

    Public Overrides Sub ToParameters(ByVal obj As TypeDef.PlantaDeEntrega.bePlantaDeEntrega)

    End Sub
End Class