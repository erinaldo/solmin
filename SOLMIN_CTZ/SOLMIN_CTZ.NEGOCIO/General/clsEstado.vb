Public Class clsEstado
    Private objTabla As DataTable

    Sub New()
        objTabla = New DataTable
    End Sub

    Property Tabla()
        Get
            Return objTabla
        End Get
        Set(ByVal value)
            objTabla = value
        End Set
    End Property

    Public Sub Estado_Atendido()
        Dim objDr As DataRow

        objTabla.Columns.Add(New DataColumn("COD", GetType(String)))
        objTabla.Columns.Add(New DataColumn("TEX", GetType(String)))

        objDr = objTabla.NewRow
        objDr.Item(0) = "0"
        objDr.Item(1) = "TODOS"
        objTabla.Rows.Add(objDr)

        objDr = objTabla.NewRow
        objDr.Item(0) = "A"
        objDr.Item(1) = "RECEPCIONADA"
        objTabla.Rows.Add(objDr)

        objDr = objTabla.NewRow
        objDr.Item(0) = "P"
        objDr.Item(1) = "EN ATENCION"
        objTabla.Rows.Add(objDr)

        objDr = objTabla.NewRow
        objDr.Item(0) = "C"
        objDr.Item(1) = "CERRADA"
        objTabla.Rows.Add(objDr)

        objDr = objTabla.NewRow
        objDr.Item(0) = "*"
        objDr.Item(1) = "ANULADA"
        objTabla.Rows.Add(objDr)
    End Sub

    Public Sub Estado_Aduanero()
        Dim objDr As DataRow

        objTabla.Columns.Add(New DataColumn("COD", GetType(String)))
        objTabla.Columns.Add(New DataColumn("TEX", GetType(String)))

        objDr = objTabla.NewRow
        objDr.Item(0) = "0"
        objDr.Item(1) = "TODOS"
        objTabla.Rows.Add(objDr)

        objDr = objTabla.NewRow
        objDr.Item(0) = "A"
        objDr.Item(1) = "EN ATENCION"
        objTabla.Rows.Add(objDr)

        objDr = objTabla.NewRow
        objDr.Item(0) = "C"
        objDr.Item(1) = "CERRADA"
        objTabla.Rows.Add(objDr)
    End Sub

    Public Sub Estado_Factura()

        Dim objDr As DataRow

        objTabla.Columns.Add(New DataColumn("COD", GetType(String)))
        objTabla.Columns.Add(New DataColumn("TEX", GetType(String)))

        objDr = objTabla.NewRow
        objDr.Item(0) = "-1"
        objDr.Item(1) = "TODOS"
        objTabla.Rows.Add(objDr)

        objDr = objTabla.NewRow
        objDr.Item(0) = "A"
        objDr.Item(1) = "A - ASIGNADOS"
        objTabla.Rows.Add(objDr)

        objDr = objTabla.NewRow
        objDr.Item(0) = "C"
        objDr.Item(1) = "C - CERRADOS"
        objTabla.Rows.Add(objDr)

        objDr = objTabla.NewRow
        objDr.Item(0) = "F"
        objDr.Item(1) = "F - FACTURADOS"
        objTabla.Rows.Add(objDr)

        objDr = objTabla.NewRow
        objDr.Item(0) = "*"
        objDr.Item(1) = "* - ANULADOS"
        objTabla.Rows.Add(objDr)

    End Sub
    Public Sub Estado_OI_Cierre()

        Dim objDr As DataRow

        objTabla.Columns.Add(New DataColumn("COD", GetType(String)))
        objTabla.Columns.Add(New DataColumn("TEX", GetType(String)))

        objDr = objTabla.NewRow
        objDr.Item(0) = "-1"
        objDr.Item(1) = "TODOS"
        objTabla.Rows.Add(objDr)

        objDr = objTabla.NewRow
        objDr.Item(0) = "F"
        objDr.Item(1) = "F - FACTURADO"
        objTabla.Rows.Add(objDr)

        objDr = objTabla.NewRow
        objDr.Item(0) = "*"
        objDr.Item(1) = "* - ANULADO"
        objTabla.Rows.Add(objDr)

    End Sub
    Public Sub Estado_Contrato()
        Dim objDr As DataRow

        objTabla.Columns.Add(New DataColumn("COD", GetType(String)))
        objTabla.Columns.Add(New DataColumn("TEX", GetType(String)))

        objDr = objTabla.NewRow
        objDr.Item(0) = "0"
        objDr.Item(1) = "TODOS"
        objTabla.Rows.Add(objDr)

        objDr = objTabla.NewRow
        objDr.Item(0) = "P"
        objDr.Item(1) = "PENDIENTE"
        objTabla.Rows.Add(objDr)

        objDr = objTabla.NewRow
        objDr.Item(0) = "A"
        objDr.Item(1) = "VIGENTE"
        objTabla.Rows.Add(objDr)

        objDr = objTabla.NewRow
        objDr.Item(0) = "C"
        objDr.Item(1) = "VENCIDO"
        objTabla.Rows.Add(objDr)

        objDr = objTabla.NewRow
        objDr.Item(0) = "R"
        objDr.Item(1) = "ANULADO"
        objTabla.Rows.Add(objDr)
    End Sub

    Public Sub Estado_Servicio()
        Dim objDr As DataRow

        objTabla.Columns.Add(New DataColumn("COD", GetType(String)))
        objTabla.Columns.Add(New DataColumn("TEX", GetType(String)))

        objDr = objTabla.NewRow
        objDr.Item(0) = "0"
        objDr.Item(1) = "TODOS"
        objTabla.Rows.Add(objDr)

        objDr = objTabla.NewRow
        objDr.Item(0) = "A"
        objDr.Item(1) = "ACTIVO"
        objTabla.Rows.Add(objDr)

        objDr = objTabla.NewRow
        objDr.Item(0) = "*"
        objDr.Item(1) = "INACTIVO"
        objTabla.Rows.Add(objDr)
    End Sub

    Public Function Estado_Contrato(ByVal pstrEstado As String) As DataTable
        Dim objDr As DataRow
        Dim oTabla As New DataTable

        oTabla.Columns.Add(New DataColumn("COD", GetType(String)))
        oTabla.Columns.Add(New DataColumn("TEX", GetType(String)))

        Select Case pstrEstado
            Case "A"
                objDr = oTabla.NewRow
                objDr.Item(0) = "A"
                objDr.Item(1) = "VIGENTE"
                oTabla.Rows.Add(objDr)

                objDr = oTabla.NewRow
                objDr.Item(0) = "C"
                objDr.Item(1) = "VENCIDO"
                oTabla.Rows.Add(objDr)

                objDr = oTabla.NewRow
                objDr.Item(0) = "R"
                objDr.Item(1) = "ANULADO"
                oTabla.Rows.Add(objDr)
            Case "P"
                objDr = oTabla.NewRow
                objDr.Item(0) = "P"
                objDr.Item(1) = "PENDIENTE"
                oTabla.Rows.Add(objDr)

                objDr = oTabla.NewRow
                objDr.Item(0) = "A"
                objDr.Item(1) = "VIGENTE"
                oTabla.Rows.Add(objDr)

                objDr = oTabla.NewRow
                objDr.Item(0) = "C"
                objDr.Item(1) = "VENCIDO"
                oTabla.Rows.Add(objDr)

                objDr = oTabla.NewRow
                objDr.Item(0) = "R"
                objDr.Item(1) = "ANULADO"
                oTabla.Rows.Add(objDr)
            Case "C"
                objDr = oTabla.NewRow
                objDr.Item(0) = "C"
                objDr.Item(1) = "VENCIDO"
                oTabla.Rows.Add(objDr)

                objDr = oTabla.NewRow
                objDr.Item(0) = "R"
                objDr.Item(1) = "ANULADO"
                oTabla.Rows.Add(objDr)
            Case "R"
                objDr = oTabla.NewRow
                objDr.Item(0) = "R"
                objDr.Item(1) = "ANULADO"
                oTabla.Rows.Add(objDr)
        End Select
        Return oTabla
    End Function

    Public Sub Estado_ServicioV2()
        Dim objDr As DataRow

        objTabla.Columns.Add(New DataColumn("COD", GetType(String)))
        objTabla.Columns.Add(New DataColumn("TEX", GetType(String)))

        objDr = objTabla.NewRow
        objDr.Item(0) = "0"
        objDr.Item(1) = "TODOS"
        objTabla.Rows.Add(objDr)

        objDr = objTabla.NewRow
        objDr.Item(0) = "S"
        objDr.Item(1) = "FACTURADO"
        objTabla.Rows.Add(objDr)

        objDr = objTabla.NewRow
        objDr.Item(0) = "N"
        objDr.Item(1) = "PENDIENTE"
        objTabla.Rows.Add(objDr)
    End Sub
End Class
