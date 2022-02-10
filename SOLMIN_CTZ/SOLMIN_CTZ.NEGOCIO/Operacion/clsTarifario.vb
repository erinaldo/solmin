Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.DATOS

Public Class clsTarifario
    Private oTarifarioDato As SOLMIN_CTZ.DATOS.clsTarifario
    Private oDt As DataTable

    Sub New()
        oTarifarioDato = New SOLMIN_CTZ.DATOS.clsTarifario
    End Sub

    Property Lista()
        Get
            Return oDt
        End Get
        Set(ByVal value)
            oDt = value
        End Set
    End Property

    Public Function Buscar_Tarifario(ByVal pobjFiltro As Filtro) As String
        Dim oDr() As DataRow
        Dim strCadena As String = ""
        Dim strFiltro As String = ""
        Dim intCont As Integer

        If pobjFiltro.Parametro1 >= 0 Then
            strFiltro = "NRCTCL =" & Double.Parse(pobjFiltro.Parametro1.ToString.Trim)
        End If
        If pobjFiltro.Parametro2 <> vbNullString Then
            If strFiltro <> vbNullString Then
                strFiltro = strFiltro & " AND CMNDA1=" & Double.Parse(pobjFiltro.Parametro2.ToString.Trim)
            Else
                strFiltro = "CMNDA1 =" & Double.Parse(pobjFiltro.Parametro2.ToString.Trim)
            End If
        End If
        oDr = oDt.Select(strFiltro)
        For intCont = 0 To oDr.Length - 1
            strCadena = strCadena & oDr(intCont).Item("NRTARF").ToString.Trim
            If intCont <> oDr.Length - 1 Then
                strCadena = strCadena & ","
            End If
        Next intCont

        Return strCadena
    End Function

    Public Sub Buscar_Observacion(ByRef pobjTarifario As Tarifario)
        Dim intCont As Integer

        For intCont = 0 To oDt.Rows.Count - 1
            If oDt.Rows(intCont).Item("NRTARF").ToString.Trim = pobjTarifario.NRTARF Then
                pobjTarifario.TOBS = oDt.Rows(intCont).Item("TOBS").ToString.Trim
                Exit For
            End If
        Next intCont
    End Sub

    'Public Sub Lista_Tarifario()
    '    oDt = oTarifarioDato.Lista_Tarifario()
    'End Sub

    Public Sub Crear_Tarifario(ByVal pobjTarifario As Tarifario)
        Try
            oTarifarioDato.Crear_Tarifario(pobjTarifario)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Function Lista_Tarifario(ByVal pobjFiltro As Filtro) As DataTable
        Return oTarifarioDato.Lista_Tarifario(pobjFiltro)
    End Function
End Class

