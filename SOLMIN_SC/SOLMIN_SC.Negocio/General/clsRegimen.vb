Imports SOLMIN_SC.Entidad
Public Class clsRegimen
    'Private oRegimen As Datos.clsRegimen
    'Private intCodigo As Integer
    'Private oDt As DataTable

    'Sub New()
    '    oRegimen = New Datos.clsRegimen
    'End Sub

    'Property Codigo()
    '    Get
    '        Return intCodigo
    '    End Get
    '    Set(ByVal value)
    '        intCodigo = value
    '    End Set
    'End Property

    'Property Lista()
    '    Get
    '        Return oDt
    '    End Get
    '    Set(ByVal value)
    '        oDt = value
    '    End Set
    'End Property

    'Public Function Lista_Regimen(Optional ByVal pintFlag As Integer = 0) As DataTable
    '    Dim objDr As DataRow
    '    Dim objDt As DataTable

    '    objDt = oDt.Copy
    '    If objDt.Rows.Count > 0 And pintFlag = 0 Then
    '        objDr = objDt.NewRow
    '        objDr(0) = 3
    '        objDr(1) = 0
    '        objDr(2) = "TODOS"
    '        objDt.Rows.InsertAt(objDr, 0)
    '    End If
    '    Return objDt
    'End Function

    'Public Sub Crea_Lista()
    '    oDt = oRegimen.Lista_Regimen
    'End Sub

    Public Function ListarRegimen() As List(Of beRegimen)
        Dim odaclsRegimen As New Datos.clsRegimen
        Dim oListRegimen As New List(Of beRegimen)
        oListRegimen = odaclsRegimen.ListarRegimen()
        Return oListRegimen
    End Function
    Public Function ListarOperacionRegimen() As List(Of beOperacionRegimen)
        Dim odaclsRegimen As New Datos.clsRegimen
        Dim oListOPRegimen As New List(Of beOperacionRegimen)
        oListOPRegimen = odaclsRegimen.ListarOperacionRegimen()
        Return oListOPRegimen
    End Function

End Class
