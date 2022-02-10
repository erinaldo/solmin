Imports RANSA.DATA
Imports RANSA.TypeDef
Public Class brSerieMercaderia
    'Public Function RegistrarSerie(ByVal obeSerie As TypeDef.beSerie) As TypeDef.beSerie
    '    Return New daSerieMercaderia().RegistrarSerie(obeSerie)
    'End Function
    'Public Function ActualizarSerie(ByVal obeSerie As TypeDef.beSerie) As TypeDef.beSerie
    '    Return New daSerieMercaderia().ActualizarSerie(obeSerie)
    'End Function
    'Public Function EliminarSerie(ByVal obeSerie As TypeDef.beSerie) As Int32
    '    Return New daSerieMercaderia().EliminarSerie(obeSerie)
    'End Function

    Public Function RegistrarSerie(ByVal obeSerie As RANSA.Controls.Serie.beSerie) As RANSA.Controls.Serie.beSerie
        Return New daSerieMercaderia().RegistrarSerie(obeSerie)
    End Function
    Public Function ActualizarSerie(ByVal obeSerie As RANSA.Controls.Serie.beSerie) As RANSA.Controls.Serie.beSerie
        Return New daSerieMercaderia().ActualizarSerie(obeSerie)
    End Function
    Public Function EliminarSerie(ByVal obeSerie As RANSA.Controls.Serie.beSerie) As Int32
        Return New daSerieMercaderia().EliminarSerie(obeSerie)
    End Function

End Class
