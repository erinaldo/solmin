Imports SOLMIN_SC.Datos
Imports SOLMIN_SC.Entidad

Public Class clsAlcanceServicio
    Dim oDatos As New SOLMIN_SC.Datos.clsAlcanceServicio

    Public Function fintInsertarAlcanceServicioXCliente(ByVal obeAlcanceServicio As beAlcanceServicio) As Integer
        Return oDatos.fintInsertarAlcanceServicioXCliente(obeAlcanceServicio)
    End Function

    Public Function fintActualizarAlcanceServicioXCliente(ByVal obeAlcanceServicio As beAlcanceServicio) As Integer
        Return oDatos.fintActualizarAlcanceServicioXCliente(obeAlcanceServicio)
    End Function

    Public Function flistListarAlcanceServicioXCliente(ByVal obeAlcanceServicio As beAlcanceServicio) As List(Of beAlcanceServicio)
        Return oDatos.flistListarAlcanceServicioXCliente(obeAlcanceServicio)
    End Function


    Public Function flistListarAlcanceServicioXClientexAnio(ByVal obeAlcanceServicio As beAlcanceServicio) As List(Of beAlcanceServicio)
        Return oDatos.flistListarAlcanceServicioXClientexAnio(obeAlcanceServicio)
    End Function
    Public Function fintValidarAlcanceServicioXCliente(ByVal obeAlcanceServicio As beAlcanceServicio) As Integer
        Return oDatos.fintValidarAlcanceServicioXCliente(obeAlcanceServicio)
    End Function
    Public Function fstrInsertarRegistroAlcanceServicioXCliente(ByVal obeAlcanceServicio As beAlcanceServicio) As String
        Return oDatos.fstrInsertarRegistroAlcanceServicioXCliente(obeAlcanceServicio)
    End Function
    Public Function fstrActualizarRegistroAlcanceServicioXCliente(ByVal obeAlcanceServicio As beAlcanceServicio) As String
        Return oDatos.fstrActualizarRegistroAlcanceServicioXCliente(obeAlcanceServicio)
    End Function
    Public Function fListaAlcanceServicioXClientexAnio(ByVal obeAlcanceServicio As beAlcanceServicio) As DataTable

        Dim dtAnual As New DataTable
        Dim drInc As DataRow

        Dim dt As New DataTable
        Const MES_INI As Int32 = 1
        Const MES_FIN As Int32 = 12

        dt = oDatos.fListaAlcanceServicioXClientexAnio(obeAlcanceServicio)

        Dim dtResult As New DataTable
        Dim dsMaest As New DataTable
        dtResult = dt.Copy
        dsMaest = dt.Copy

        dtAnual.Columns.Add("CDVSN", Type.GetType("System.String"))
        dtAnual.Columns.Add("TCMPDV", Type.GetType("System.String"))
        dtAnual.Columns.Add("CCLNT", Type.GetType("System.Decimal"))

        dtAnual.Columns.Add("NANASR", Type.GetType("System.Decimal")) 'año
        dtAnual.Columns.Add("NMSASR", Type.GetType("System.Decimal")) 'mes
        dtAnual.Columns.Add("NCRRLT", Type.GetType("System.Decimal")) 'num correlativo

        dtAnual.Columns.Add("TDALSR", Type.GetType("System.String")) 'descripcion alcance servicio
        dtAnual.Columns.Add("TINDMD", Type.GetType("System.String")) 'indicador de medicion

        dtAnual.Columns.Add("QMDALS", Type.GetType("System.Decimal")) 'cantidad medida alcance servicio
        dtAnual.Columns.Add("CUNDSR", Type.GetType("System.String")) 'cod unidad servicio

        dtAnual.Columns.Add("TABRUN", Type.GetType("System.String")) ' descripcion abrev unid medida
        dtAnual.Columns.Add("TRFMED", Type.GetType("System.String")) ' descripcion referencia unidad

        dtAnual.Columns.Add("TFRMMD", Type.GetType("System.String")) ' forma medicion de indicador
        dtAnual.Columns.Add("QMDASC", Type.GetType("System.Decimal")) 'cantidad medida alcance de servicio cliente
        dtAnual.Columns.Add("TSRVC", Type.GetType("System.String")) 'Descripcion de servicio

        dtAnual.Columns.Add("MES01", Type.GetType("System.String")).Caption = "ENE"
        dtAnual.Columns.Add("MES02", Type.GetType("System.String")).Caption = "FEB"
        dtAnual.Columns.Add("MES03", Type.GetType("System.String")).Caption = "MAR"
        dtAnual.Columns.Add("MES04", Type.GetType("System.String")).Caption = "ABR"
        dtAnual.Columns.Add("MES05", Type.GetType("System.String")).Caption = "MAY"
        dtAnual.Columns.Add("MES06", Type.GetType("System.String")).Caption = "JUN"
        dtAnual.Columns.Add("MES07", Type.GetType("System.String")).Caption = "JUL"
        dtAnual.Columns.Add("MES08", Type.GetType("System.String")).Caption = "AGO"
        dtAnual.Columns.Add("MES09", Type.GetType("System.String")).Caption = "SEP"
        dtAnual.Columns.Add("MES10", Type.GetType("System.String")).Caption = "OCT"
        dtAnual.Columns.Add("MES11", Type.GetType("System.String")).Caption = "NOV"
        dtAnual.Columns.Add("MES12", Type.GetType("System.String")).Caption = "DIC"


        Dim CodFila As String = ""
        Dim LisIncVisitado As New Hashtable

        For Fila_M As Integer = 0 To dsMaest.Rows.Count - 1
            drInc = dtAnual.NewRow

            drInc("CDVSN") = dt.Rows(Fila_M)("CDVSN")
            drInc("TCMPDV") = dt.Rows(Fila_M)("TCMPDV").ToString.Trim
            drInc("CCLNT") = dt.Rows(Fila_M)("CCLNT")

            drInc("NANASR") = dt.Rows(Fila_M)("NANASR") 'año
            drInc("NMSASR") = dt.Rows(Fila_M)("NMSASR") 'mes
            drInc("NCRRLT") = dt.Rows(Fila_M)("NCRRLT") 'num correlativo

            drInc("TDALSR") = dt.Rows(Fila_M)("TDALSR").ToString.Trim 'descripcion alcance servicio
            drInc("TINDMD") = dt.Rows(Fila_M)("TINDMD") 'indicador de medicion

            drInc("QMDALS") = dt.Rows(Fila_M)("QMDALS") 'cantidad medida alcance servicio
            drInc("CUNDSR") = dt.Rows(Fila_M)("CUNDSR") 'cod unidad servicio
            drInc("TABRUN") = dt.Rows(Fila_M)("TABRUN") ' descripcion abrev unid medida
            drInc("TRFMED") = dt.Rows(Fila_M)("TRFMED") ' descripcion referencia unidad

            drInc("TFRMMD") = dt.Rows(Fila_M)("TFRMMD").ToString.Trim ' forma medicion de indicador
            drInc("QMDASC") = dt.Rows(Fila_M)("QMDASC") 'cantidad medida alcance de servicio cliente
            drInc("TSRVC") = dt.Rows(Fila_M)("TSRVC") 'Descripcion de servicio

            CodFila = drInc("CDVSN") & "_" & drInc("NMSASR") & "_" & drInc("NCRRLT")
            'drInc("CODIGO") = CodFila

            For FILA_MES As Integer = MES_INI To MES_FIN
                drInc("MES" & FILA_MES.ToString.PadLeft(2, "0")) = "" 'mes
            Next

            LisIncVisitado.Add(CodFila, Fila_M)
            dtAnual.Rows.Add(drInc)
        Next


        Dim codigo As String = ""
        Dim CDVSN As String = ""
        Dim NCRRLT As String = ""
        Dim NMSASR As String = ""
        Dim Columna_Mes As String = ""
        Dim Fila As Int32 = 0

        For Fila_Result As Integer = 0 To dtResult.Rows.Count - 1
            CDVSN = dtAnual.Rows(Fila_Result)("CDVSN")
            NCRRLT = dtAnual.Rows(Fila_Result)("NCRRLT")
            NMSASR = dtAnual.Rows(Fila_Result)("NMSASR")
            Columna_Mes = dtAnual.Rows(Fila_Result).Item("NMSASR").ToString.PadLeft(2, "0")
            codigo = CDVSN & "_" & NMSASR & "_" & NCRRLT
            Fila = LisIncVisitado(codigo)

            If dtAnual.Rows(Fila)("QMDASC").ToString = "0.00" Then
                dtAnual.Rows(Fila)("MES" & Columna_Mes) = ""
            Else
                dtAnual.Rows(Fila)("MES" & Columna_Mes) = dtAnual.Rows(Fila)("QMDASC").ToString
            End If

        Next

        Return dtAnual

    End Function
    Public Function fdtAlcanceServicioXClientexMes(ByVal obeAlcanceServicio As beAlcanceServicio) As DataTable
        Return oDatos.fdtAlcanceServicioXClientexMes(obeAlcanceServicio)
    End Function
End Class