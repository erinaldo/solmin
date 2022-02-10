Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Data
Public Class Imagen_DAL

    Public Function Get_Nro_Imagen_RZSC03(ByVal objCargaAdjuntos As CargaAdjuntos) As Decimal
        Dim dt As DataTable
        Dim NroImg As Decimal = 0
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", objCargaAdjuntos.CCMPN)
        lobjParams.Add("PNNRCTSL", objCargaAdjuntos.NRCTSL)
        lobjParams.Add("PNNRTFSV", objCargaAdjuntos.NRTFSV)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CTZ_GET_NRO_IMG_RZSC03", lobjParams)
        If dt.Rows.Count > 0 Then
            NroImg = dt.Rows(0)("NMRGIM")
        End If
        Return NroImg
    End Function

    Public Function Get_Nro_Imagen_RZTR05(ByVal objCargaAdjuntos As CargaAdjuntos) As Decimal
        Dim dt As DataTable
        Dim NroImg As Decimal = 0
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", objCargaAdjuntos.CCMPN)
        lobjParams.Add("PNNOPRCN", objCargaAdjuntos.NOPRCN)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CTZ_GET_NRO_IMG_RZTR05", lobjParams)
        If dt.Rows.Count > 0 Then
            NroImg = dt.Rows(0)("NMRGIM")
        End If
        Return NroImg
    End Function

    Public Function Get_Nro_Imagen_RZTR76(ByVal objCargaAdjuntos As CargaAdjuntos) As Decimal
        Dim dt As DataTable
        Dim NroImg As Decimal = 0
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", objCargaAdjuntos.CCMPN)
        lobjParams.Add("PNNLQCMB", objCargaAdjuntos.NLQCMB)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CTZ_GET_NRO_IMG_RZTR76", lobjParams)
        If dt.Rows.Count > 0 Then
            NroImg = dt.Rows(0)("NMRGIM")
        End If
        Return NroImg
    End Function

    Public Function Get_Nro_Imagen_RZST07(ByVal objCargaAdjuntos As CargaAdjuntos) As Decimal
        Dim dt As DataTable
        Dim NroImg As Decimal = 0
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", objCargaAdjuntos.CCMPN)
        lobjParams.Add("PNNCSOTR", objCargaAdjuntos.NCSOTR)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CTZ_GET_NRO_IMG_RZST07", lobjParams)
        If dt.Rows.Count > 0 Then
            NroImg = dt.Rows(0)("NMRGIM")
        End If
        Return NroImg

    End Function


    Public Function Get_Nro_Imagen_RZOL65P(ByVal objCargaAdjuntos As CargaAdjuntos) As Decimal
        Dim dt As DataTable
        Dim NroImg As Decimal = 0
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", objCargaAdjuntos.CCLNT)
        lobjParams.Add("PNNROPLT", objCargaAdjuntos.NROPLT)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CTZ_GET_NRO_IMG_RZOL65P", lobjParams)
        If dt.Rows.Count > 0 Then
            NroImg = dt.Rows(0)("NMRGIM")
        End If
        Return NroImg

    End Function


    Public Function Get_Nro_Imagen_RZOL65I(ByVal objCargaAdjuntos As CargaAdjuntos) As Decimal
        Dim dt As DataTable
        Dim NroImg As Decimal = 0
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", objCargaAdjuntos.CCMPN)
        lobjParams.Add("PSCDVSN", objCargaAdjuntos.CDVSN)
        lobjParams.Add("PNCCLNT", objCargaAdjuntos.CCLNT)
        lobjParams.Add("PSCREFFW", objCargaAdjuntos.CREFFW)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CTZ_GET_NRO_IMG_RZOL65I", lobjParams)
        If dt.Rows.Count > 0 Then
            NroImg = dt.Rows(0)("NMRGIM")
        End If
        Return NroImg
 

    End Function

    Public Function Get_Nro_Imagen_RZOL67(ByVal objCargaAdjuntos As CargaAdjuntos) As Decimal
        Dim dt As DataTable
        Dim NroImg As Decimal = 0
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", objCargaAdjuntos.CCMPN)
        lobjParams.Add("PNNRCTRL", objCargaAdjuntos.NRCTRL)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CTZ_GET_NRO_IMG_RZOL67", lobjParams)
        If dt.Rows.Count > 0 Then
            NroImg = dt.Rows(0)("NMRGIM")
        End If
        Return NroImg

    End Function


    Public Function Get_Nro_Imagen_RZOL65(ByVal objCargaAdjuntos As CargaAdjuntos) As Decimal
        Dim dt As DataTable
        Dim NroImg As Decimal = 0
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSCCMPN", objCargaAdjuntos.CCMPN)
        lobjParams.Add("PSCDVSN", objCargaAdjuntos.CDVSN)
        lobjParams.Add("PNCPLNDV", objCargaAdjuntos.CPLNDV)
        lobjParams.Add("PNCCLNT", objCargaAdjuntos.CCLNT)
        lobjParams.Add("PSCREFFW", objCargaAdjuntos.CREFFW)
        lobjParams.Add("PNNSEQIN", objCargaAdjuntos.NSEQIN)

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CTZ_GET_NRO_IMG_RZOL65", lobjParams)
        If dt.Rows.Count > 0 Then
            NroImg = dt.Rows(0)("NMRGIM")
        End If
        Return NroImg


    End Function


    Public Function Get_Nro_Imagen_RZIM36(ByVal objCargaAdjuntos As CargaAdjuntos) As Decimal
        Dim dt As DataTable
        Dim NroImg As Decimal = 0
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PNCCLNT", objCargaAdjuntos.CCLNT)
        lobjParams.Add("PNNGUIRM", objCargaAdjuntos.NGUIRM)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CTZ_GET_NRO_IMG_RZIM36", lobjParams)
        If dt.Rows.Count > 0 Then
            NroImg = dt.Rows(0)("NMRGIM")
        End If
        Return NroImg


    End Function


    Public Function Get_Nro_Imagen_RZSC53(ByVal objCargaAdjuntos As CargaAdjuntos) As Decimal
        Dim dt As DataTable
        Dim NroImg As Decimal = 0
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PARAM_CCMPN", objCargaAdjuntos.CCMPN)
        lobjParams.Add("PARAM_NROVLR", objCargaAdjuntos.NROVLR)

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CTZ_GET_NRO_IMG_RZSC53", lobjParams)
        If dt.Rows.Count > 0 Then
            NroImg = dt.Rows(0)("NMRGIM")
        End If
        Return NroImg
    End Function


    Public Function Get_Nro_Imagen_RZSC58(ByVal objCargaAdjuntos As CargaAdjuntos) As Decimal
        Dim dt As DataTable
        Dim NroImg As Decimal = 0
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PARAM_CCMPN", objCargaAdjuntos.CCMPN)
        lobjParams.Add("PARAM_TPCTRL", objCargaAdjuntos.TPCTRL)
        lobjParams.Add("PARAM_NRCTRL", objCargaAdjuntos.NRCTRL)

        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CTZ_GET_NRO_IMG_RZSC58", lobjParams)
        If dt.Rows.Count > 0 Then
            NroImg = dt.Rows(0)("NMRGIM")
        End If
        Return NroImg
    End Function


    Public Function Get_Nro_Imagen_RZTR31(ByVal objCargaAdjuntos As CargaAdjuntos) As Decimal
        Dim dt As DataTable
        Dim NroImg As Decimal = 0
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PARAM_CCMPN", objCargaAdjuntos.CCMPN)
        lobjParams.Add("PARAM_NLQDCN", objCargaAdjuntos.NLQDCN)


        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_CTZ_GET_NRO_IMG_RZTR31", lobjParams)
        If dt.Rows.Count > 0 Then
            NroImg = dt.Rows(0)("NMRGIM")
        End If
        Return NroImg
    End Function



     
 

End Class
