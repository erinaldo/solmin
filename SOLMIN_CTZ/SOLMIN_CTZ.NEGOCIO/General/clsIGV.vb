Imports SOLMIN_CTZ.DATOS

Public Class clsIGV
    Private oIGVDato As SOLMIN_CTZ.DATOS.clsIGV
    Private oDt As DataTable

    Sub New()
        oIGVDato = New SOLMIN_CTZ.DATOS.clsIGV
    End Sub

    Property Lista()
        Get
            Return oDt
        End Get
        Set(ByVal value)
            oDt = value
        End Set
    End Property

    'Public Sub Crea_Lista()
    '    oDt = oIGVDato.Lista_IGV
    'End Sub

End Class
