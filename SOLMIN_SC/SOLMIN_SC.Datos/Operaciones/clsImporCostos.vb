Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_SC.Entidad
Imports Ransa.Utilitario
Public Class clsImporCostos
    Public Function ListarCabeceraDUAA(ByVal oDUAA As beDUAA) As beDUAA
        Dim obeDUAA As New beDUAA
        Dim oSqlMan As New SqlManager
        Dim odt As New DataTable
        Dim lobjParams As New Parameter
        lobjParams.Add("PNNORDSR", oDUAA.PNNORDSR)
        lobjParams.Add("PNCZNFCC", oDUAA.PNCZNFCC)
        odt = oSqlMan.ExecuteDataSet("SP_SOLSC_DUAA_DATOS_ASCINSA", lobjParams).Tables(0)
        If odt.Rows.Count > 0 Then
            obeDUAA.PSCCMPN = HelpClass.ToStringCvr(odt.Rows(0).Item("CCMPN"))
            obeDUAA.PSCDVSN = HelpClass.ToStringCvr(odt.Rows(0).Item("CDVSN"))
            obeDUAA.PNCZNFCC = HelpClass.ToDecimalCvr(odt.Rows(0).Item("CZNFCC"))
            obeDUAA.PNCPLNDV = HelpClass.ToDecimalCvr(odt.Rows(0).Item("CPLNDV"))
            obeDUAA.PSTPSRVA = HelpClass.ToStringCvr(odt.Rows(0).Item("TPSRVA"))
            obeDUAA.PNNORDSR = HelpClass.ToDecimalCvr(odt.Rows(0).Item("NORDSR"))
            obeDUAA.PNCCLNT = HelpClass.ToDecimalCvr(odt.Rows(0).Item("CCLNT"))
            obeDUAA.PSNMRDUA = HelpClass.ToStringCvr(odt.Rows(0).Item("NMRDUA"))

            obeDUAA.PSREFRNC = HelpClass.ToStringCvr(odt.Rows(0).Item("REFRNC")) 'Referencia Orden
            obeDUAA.PNVALMRC = HelpClass.ToDecimalCvr(odt.Rows(0).Item("VALMRC")) 'Valor Mercaderia*
            obeDUAA.PNVALFLT = HelpClass.ToDecimalCvr(odt.Rows(0).Item("VALFLT")) 'Valor Flete*
            obeDUAA.PNVALSEG = HelpClass.ToDecimalCvr(odt.Rows(0).Item("VALSEG")) 'Valor Seguro*
            obeDUAA.PNVALGAS = HelpClass.ToDecimalCvr(odt.Rows(0).Item("VALGAS")) 'Valor Gastos*
            obeDUAA.PNVALFOB = HelpClass.ToDecimalCvr(odt.Rows(0).Item("VALFOB")) 'Valor FOB*
            obeDUAA.PNIMPCIF = HelpClass.ToDecimalCvr(odt.Rows(0).Item("IMPCIF")) 'Valor CIF*
            obeDUAA.PNVALADV = HelpClass.ToDecimalCvr(odt.Rows(0).Item("VALADV")) 'Valor Advalorem*
            obeDUAA.PNVALSBT = HelpClass.ToDecimalCvr(odt.Rows(0).Item("VALSBT")) 'Valor Sobretasa*
            obeDUAA.PNVALDES = HelpClass.ToDecimalCvr(odt.Rows(0).Item("VALDES")) 'Valor Derecho Especifico*
            obeDUAA.PNVALISC = HelpClass.ToDecimalCvr(odt.Rows(0).Item("VALISC")) 'Valor ISC*
            obeDUAA.PNVALIGV = HelpClass.ToDecimalCvr(odt.Rows(0).Item("VALIGV")) 'Valor IGV*
            obeDUAA.PNVALIPM = HelpClass.ToDecimalCvr(odt.Rows(0).Item("VALIPM")) 'Valor IPM*
            obeDUAA.PNVALADP = HelpClass.ToDecimalCvr(odt.Rows(0).Item("VALADP")) 'Valor Antidump*
            obeDUAA.PNVALICP = HelpClass.ToDecimalCvr(odt.Rows(0).Item("VALICP")) 'Valor Interes Compensatorio*
            obeDUAA.PNVALMOR = HelpClass.ToDecimalCvr(odt.Rows(0).Item("VALMOR")) 'Valor Mora*
            obeDUAA.PNVALRNP = HelpClass.ToDecimalCvr(odt.Rows(0).Item("VALRNP")) 'Valor Reintegro Papel*
            obeDUAA.PSFACTUR = HelpClass.ToStringCvr(odt.Rows(0).Item("FACTUR")) 'Número Factura*
            obeDUAA.PSFFACTU = HelpClass.ToStringCvr(odt.Rows(0).Item("FFACTU")) 'Fecha Factura
            Return obeDUAA
        Else
            obeDUAA = Nothing
            Return obeDUAA
        End If

    End Function

    Public Function ListarDetalleDUAA(ByVal oDUAA As beDUAA) As List(Of beDUAA1)
        Dim oListbeDUAA1 As New List(Of beDUAA1)
        Dim lobjParams As New Parameter
        Dim oSqlMan As New SqlManager
        Dim numReg As Int32 = 0
        Dim VAL_OTROS_GASTOS As Decimal = 0
        Dim odt As New DataTable
        Dim obeDUAA1 As beDUAA1
        lobjParams.Add("PNNORDSR", oDUAA.PNNORDSR)
        lobjParams.Add("PNCZNFCC", oDUAA.PNCZNFCC)
        odt = oSqlMan.ExecuteDataSet("SP_SOLSC_DUAA1_DATOS_DETALLE_ASCINSA", lobjParams).Tables(0)
        numReg = odt.Rows.Count - 1

        For index As Integer = 0 To numReg
            obeDUAA1 = New beDUAA1
            obeDUAA1.PSCCMPN = HelpClass.ToStringCvr(odt.Rows(index).Item("CCMPN"))
            obeDUAA1.PSCDVSN = HelpClass.ToStringCvr(odt.Rows(index).Item("CDVSN"))
            obeDUAA1.PNCZNFCC = HelpClass.ToDecimalCvr(odt.Rows(index).Item("CZNFCC"))
            obeDUAA1.PNCPLNDV = HelpClass.ToDecimalCvr(odt.Rows(index).Item("CPLNDV"))
            obeDUAA1.PSTPSRVA = HelpClass.ToStringCvr(odt.Rows(index).Item("TPSRVA"))
            obeDUAA1.PNNORDSR = HelpClass.ToDecimalCvr(odt.Rows(index).Item("NORDSR"))
            obeDUAA1.PNNSERIE = HelpClass.ToDecimalCvr(odt.Rows(index).Item("NSERIE"))
            obeDUAA1.PSPARTID = HelpClass.ToStringCvr(odt.Rows(index).Item("PARTID"))
            obeDUAA1.PNNMITFC = HelpClass.ToDecimalCvr(odt.Rows(index).Item("NMITFC"))
            obeDUAA1.PSNMRODC = HelpClass.ToStringCvr(odt.Rows(index).Item("NMRODC"))
            obeDUAA1.PNNMITOC = HelpClass.ToDecimalCvr(odt.Rows(index).Item("NMITOC"))
            obeDUAA1.PNVALMRC = HelpClass.ToDecimalCvr(odt.Rows(index).Item("VALMRC"))
            obeDUAA1.PNVALFLT = HelpClass.ToDecimalCvr(odt.Rows(index).Item("VALFLT"))
            obeDUAA1.PNVALSEG = HelpClass.ToDecimalCvr(odt.Rows(index).Item("VALSEG"))
            obeDUAA1.PNVALGAS = HelpClass.ToDecimalCvr(odt.Rows(index).Item("VALGAS"))
            obeDUAA1.PNVALFOB = HelpClass.ToDecimalCvr(odt.Rows(index).Item("VALFOB"))
            obeDUAA1.PNIMPCIF = HelpClass.ToDecimalCvr(odt.Rows(index).Item("IMPCIF"))
            obeDUAA1.PNVALADV = HelpClass.ToDecimalCvr(odt.Rows(index).Item("VALADV"))
            obeDUAA1.PNVALSBT = HelpClass.ToDecimalCvr(odt.Rows(index).Item("VALSBT"))
            obeDUAA1.PNVALDES = HelpClass.ToDecimalCvr(odt.Rows(index).Item("VALDES"))
            obeDUAA1.PNVALISC = HelpClass.ToDecimalCvr(odt.Rows(index).Item("VALISC"))
            obeDUAA1.PNVALIGV = HelpClass.ToDecimalCvr(odt.Rows(index).Item("VALIGV"))
            obeDUAA1.PNVALIPM = HelpClass.ToDecimalCvr(odt.Rows(index).Item("VALIPM"))
            obeDUAA1.PNVALADP = HelpClass.ToDecimalCvr(odt.Rows(index).Item("VALADP"))
            obeDUAA1.PNVALICP = HelpClass.ToDecimalCvr(odt.Rows(index).Item("VALICP"))
            obeDUAA1.PNVALMOR = HelpClass.ToDecimalCvr(odt.Rows(index).Item("VALMOR"))
            obeDUAA1.PNVALRNP = HelpClass.ToDecimalCvr(odt.Rows(index).Item("VALRNP"))

            'VAL_OTROS_GASTOS = 0
            'VAL_OTROS_GASTOS = obeDUAA1.PNVALSBT + obeDUAA1.PNVALDES
            'VAL_OTROS_GASTOS += obeDUAA1.PNVALISC + obeDUAA1.PNVALADP
            'VAL_OTROS_GASTOS += obeDUAA1.PNVALICP + obeDUAA1.PNVALMOR
            'VAL_OTROS_GASTOS += obeDUAA1.PNVALRNP
            'obeDUAA1.PNVOTROSGASTOS = VAL_OTROS_GASTOS

            obeDUAA1.PNVLADVP = HelpClass.ToDecimalCvr(odt.Rows(index).Item("VLADVP"))
            obeDUAA1.PNVLSBTP = HelpClass.ToDecimalCvr(odt.Rows(index).Item("VLSBTP"))
            obeDUAA1.PNVLDESP = HelpClass.ToDecimalCvr(odt.Rows(index).Item("VLDESP"))
            obeDUAA1.PNVLISCP = HelpClass.ToDecimalCvr(odt.Rows(index).Item("VLISCP"))
            obeDUAA1.PNVLIGVP = HelpClass.ToDecimalCvr(odt.Rows(index).Item("VLIGVP"))
            obeDUAA1.PNVLIPMP = HelpClass.ToDecimalCvr(odt.Rows(index).Item("VLIPMP"))
            obeDUAA1.PNVLADPP = HelpClass.ToDecimalCvr(odt.Rows(index).Item("VLADPP"))
            obeDUAA1.PNVLICPP = HelpClass.ToDecimalCvr(odt.Rows(index).Item("VLICPP"))
            obeDUAA1.PNVLMORP = HelpClass.ToDecimalCvr(odt.Rows(index).Item("VLMORP"))
            obeDUAA1.PNVLRNPP = HelpClass.ToDecimalCvr(odt.Rows(index).Item("VLRNPP"))
            obeDUAA1.PSFACTU1 = HelpClass.ToStringCvr(odt.Rows(index).Item("FACTU1"))
            obeDUAA1.PSFFACT1 = HelpClass.ToStringCvr(odt.Rows(index).Item("FFACT1"))
            obeDUAA1.PSFACTU2 = HelpClass.ToStringCvr(odt.Rows(index).Item("FACTU2"))
            obeDUAA1.PSFFACT2 = HelpClass.ToStringCvr(odt.Rows(index).Item("FFACT2"))
            obeDUAA1.PSFACTU3 = HelpClass.ToStringCvr(odt.Rows(index).Item("FACTU3"))
            obeDUAA1.PSFFACT3 = HelpClass.ToStringCvr(odt.Rows(index).Item("FFACT3"))

            obeDUAA1.PSNMRFCT = HelpClass.ToStringCvr(odt.Rows(index).Item("NMRFCT"))
            If obeDUAA1.PSNMRFCT = "" Then
                obeDUAA1.PSNMRFCT = obeDUAA1.PSFACTU1
            End If
            If obeDUAA1.PSNMRFCT = "" Then
                obeDUAA1.PSNMRFCT = obeDUAA1.PSFACTU2
            End If
            If obeDUAA1.PSNMRFCT = "" Then
                obeDUAA1.PSNMRFCT = obeDUAA1.PSFACTU3
            End If
            oListbeDUAA1.Add(obeDUAA1)
        Next

        Return oListbeDUAA1
    End Function

    Public Function ListarCheckPointAgencia(ByVal NORDSR As String, ByVal ZONA As String) As DataTable
        Dim odt As New DataTable
        Dim oSqlMan As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("IN_NORDSR", NORDSR)
        lobjParams.Add("IN_ZONA", ZONA)
        odt = oSqlMan.ExecuteDataTable("SP_SOLSEGORD_IMP_CONSULTAOS", lobjParams)
        Return odt
    End Function

End Class
