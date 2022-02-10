Public Class clsEstadoNeg
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

    Public Sub Estado_Servicio()
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

    Public Sub Estado_Pendiente()
        Dim objDr As DataRow
        objTabla.Columns.Add(New DataColumn("COD", GetType(String)))
        objTabla.Columns.Add(New DataColumn("TEX", GetType(String)))
        objDr = objTabla.NewRow
        objDr.Item(0) = "0"
        objDr.Item(1) = "TODOS"
        objTabla.Rows.Add(objDr)

        objDr = objTabla.NewRow
        objDr.Item(0) = "S"
        objDr.Item(1) = "REVISADO"
        objTabla.Rows.Add(objDr)

        objDr = objTabla.NewRow
        objDr.Item(0) = "N"
        objDr.Item(1) = "POR REVISAR"
        objTabla.Rows.Add(objDr)
    End Sub


    Public Sub Estado_Operacion()
        Dim objDr As DataRow
        objTabla.Columns.Add(New DataColumn("COD", GetType(String)))
        objTabla.Columns.Add(New DataColumn("TEX", GetType(String)))
        objDr = objTabla.NewRow
        objDr.Item(0) = "0"
        objDr.Item(1) = "TODOS"
        objTabla.Rows.Add(objDr)

        objDr = objTabla.NewRow
        objDr.Item(0) = "1"
        objDr.Item(1) = "POR APROBAR"
        objTabla.Rows.Add(objDr)

        objDr = objTabla.NewRow
        objDr.Item(0) = "2"
        objDr.Item(1) = "POR FACTURAR"
        objTabla.Rows.Add(objDr)

        objDr = objTabla.NewRow
        objDr.Item(0) = "3"
        objDr.Item(1) = "FACTURADO"
        objTabla.Rows.Add(objDr)
    End Sub

End Class
