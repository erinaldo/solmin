Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Datos
Public Class clsCanal
    'Private objTabla As DataTable
    'Sub New()
    '    objTabla = New DataTable
    'End Sub

    'Property Tabla()
    '    Get
    '        Return objTabla
    '    End Get
    '    Set(ByVal value)
    '        objTabla = value
    '    End Set
    'End Property

    'Public Sub Lista_Canal(Optional ByVal pintTer As Integer = 0)
    '    Dim objDr As DataRow

    '    objTabla.Columns.Add(New DataColumn("NCANAL", GetType(String)))
    '    objTabla.Columns.Add(New DataColumn("TCANAL", GetType(String)))
    '    objTabla.Columns.Add(New DataColumn("TCANAL_ING", GetType(String)))

    '    If pintTer > 0 Then
    '        objDr = objTabla.NewRow
    '        objDr.Item("NCANAL") = "0"
    '        objDr.Item("TCANAL") = "TODOS"
    '        objDr.Item("TCANAL_ING") = "ALL"
    '        objTabla.Rows.Add(objDr)
    '    End If

    '    objDr = objTabla.NewRow
    '    objDr.Item("NCANAL") = "NARANJA"
    '    objDr.Item("TCANAL") = "NARANJA"
    '    objDr.Item("TCANAL_ING") = "ORANGE"
    '    objTabla.Rows.Add(objDr)

    '    objDr = objTabla.NewRow
    '    objDr.Item("NCANAL") = "ROJO"
    '    objDr.Item("TCANAL") = "ROJO"
    '    objDr.Item("TCANAL_ING") = "RED"
    '    objTabla.Rows.Add(objDr)

    '    objDr = objTabla.NewRow
    '    objDr.Item("NCANAL") = "VERDE"
    '    objDr.Item("TCANAL") = "VERDE"
    '    objDr.Item("TCANAL_ING") = "GREEN"
    '    objTabla.Rows.Add(objDr)
    'End Sub
  
    Public Function Lista_Canal(ByVal TipoEmbarque As String) As List(Of beCanal)
        Dim odalclsCanal As New Datos.clsCanal
        Return odalclsCanal.Lista_Canal(TipoEmbarque)
    End Function

End Class
