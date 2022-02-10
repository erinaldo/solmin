
Imports SOLMIN_ST.DATOS
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.ENTIDADES.Operaciones

Public Class ControlHitos_BLL
    Dim objDal As New ControlHito_DAL

    Public Function ListarHitos(ByVal objeto As ControlHito) As DataTable
        'objeto.NESTDO = 0
        Return objDal.ListarHitos(objeto)
    End Function

    Public Function ConsultaHitosRegistrados(ByVal objeto As HitoOperacion) As DataSet
        Return objDal.ConsultaHitoRegistrado(objeto)
    End Function

    'Public Function ListaGuiasporHito(ByVal objeto As ControlHito) As DataTable
    '    Return objDal.ListaGuiasporHito(objeto)
    'End Function


    Public Function RegistrarHito(ByVal objeto As HitoOperacion) As String
        Return objDal.RegistrarHito(objeto)
    End Function

    Public Sub ActualizarGuiaRemision(ByVal objeto As HitoOperacion)
        objDal.ActualizarGuiaRemision(objeto)
    End Sub

    Public Function EliminarHito(ByVal objeto As HitoOperacion) As String
        Return objDal.EliminarHito(objeto)
    End Function

    Public Function ActualizarMasivoHito(ByVal objeto As HitoOperacion) As String
        Return objDal.ActualizarMasivoHito(objeto)
    End Function
    
    Public Function RegistrarHito_Actualizacion(ByVal objeto As HitoOperacion) As String
        Return objDal.RegistrarHito_Actualizacion(objeto)
    End Function
End Class
