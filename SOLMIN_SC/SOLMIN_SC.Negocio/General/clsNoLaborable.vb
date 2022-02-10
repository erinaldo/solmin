Public Class clsNoLaborable
    Private dblFecIni As Double 'yyyyMMdd
    Private dblFecFin As Double 'yyyyMMdd
    Private oNoLaborable As Datos.clsNoLaborable

    Sub New()
        oNoLaborable = New Datos.clsNoLaborable
    End Sub

    Property Fin()
        Get
            Return dblFecFin
        End Get
        Set(ByVal value)
            dblFecFin = value
        End Set
    End Property


    Property Inicio()
        Get
            Return dblFecIni
        End Get
        Set(ByVal value)
            dblFecIni = value
        End Set
    End Property

    Public Function dtNoLaborables() As DataTable
        Return oNoLaborable.dtNoLaborables(dblFecIni, dblFecFin)
    End Function
End Class
