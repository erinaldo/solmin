Imports SOLMIN_SC.Entidad
Imports System.Collections.Generic
Public Class clsIncoterm
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

    Public Sub Lista_Incoterm(Optional ByVal pintTer As Integer = 0)
        Dim objDr As DataRow

        objTabla.Columns.Add(New DataColumn("COD", GetType(String)))
        objTabla.Columns.Add(New DataColumn("TEX", GetType(String)))

        If pintTer > 0 Then
            objDr = objTabla.NewRow
            objDr.Item(0) = "0"
            objDr.Item(1) = "TODOS"
            objTabla.Rows.Add(objDr)
        End If

        objDr = objTabla.NewRow
        objDr.Item(0) = "EXW"
        objDr.Item(1) = "EXW"
        objTabla.Rows.Add(objDr)

        objDr = objTabla.NewRow
        objDr.Item(0) = "FOB"
        objDr.Item(1) = "FOB"
        objTabla.Rows.Add(objDr)

        objDr = objTabla.NewRow
        objDr.Item(0) = "CIF"
        objDr.Item(1) = "CIF"
        objTabla.Rows.Add(objDr)

        objDr = objTabla.NewRow
        objDr.Item(0) = "CFR"
        objDr.Item(1) = "CFR"
        objTabla.Rows.Add(objDr)
    End Sub
    Public Function Lista_Incoterm_RatioLanded() As List(Of beIncoterm)
        Dim oListIcoterm As New List(Of beIncoterm)
        Dim obeIcoterm As beIncoterm

        obeIcoterm = New beIncoterm
        obeIcoterm.PSCODIGO = "EXW"
        obeIcoterm.PSDESCRIPCION = "EXW"
        oListIcoterm.Add(obeIcoterm)

        obeIcoterm = New beIncoterm
        obeIcoterm.PSCODIGO = "FOB"
        obeIcoterm.PSDESCRIPCION = "FOB"
        oListIcoterm.Add(obeIcoterm)

        obeIcoterm = New beIncoterm
        obeIcoterm.PSCODIGO = "CIF"
        obeIcoterm.PSDESCRIPCION = "CIF"
        oListIcoterm.Add(obeIcoterm)

        Return oListIcoterm
    End Function
End Class
