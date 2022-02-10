Imports SOLMIN_SC.Datos
Imports SOLMIN_SC.Entidad
Public Class clsDocumentoAdjunto
    Public Function Lista_Documentos_x_PreEmbarque(ByVal obeDocumentoAdjunto As beDocumentoAdjunto) As DataTable
        Dim dt As New DataTable
        Dim odaClsDocumentoAdjunto As New Datos.clsDocumentoAdjunto
        dt = odaClsDocumentoAdjunto.Lista_Documentos_x_PreEmbarque(obeDocumentoAdjunto)
        Return dt
    End Function
    Public Function Lista_Documentos_x_OrdenCompraParcial(ByVal obeDocumentoAdjunto As beDocumentoAdjunto) As DataTable
        Dim dt As New DataTable
        Dim odaClsDocumentoAdjunto As New Datos.clsDocumentoAdjunto
        dt = odaClsDocumentoAdjunto.Lista_Documentos_x_OrdenCompraParcial(obeDocumentoAdjunto)
        Return dt
    End Function
    Public Function Elimina_Documentos_x_PreEmbarque(ByVal obeDocumentoAdjunto As beDocumentoAdjunto) As Int32
        Dim retorno As Int32 = 0
        Dim odaClsDocumentoAdjunto As New Datos.clsDocumentoAdjunto
        retorno = odaClsDocumentoAdjunto.Elimina_Documentos_x_PreEmbarque(obeDocumentoAdjunto)
        Return retorno
    End Function
    Public Function Insertar_Documentos_x_PreEmbarque(ByVal obeDocumentoAdjunto As beDocumentoAdjunto) As Int32
        Dim retorno As Int32 = 0
        Dim odaClsDocumentoAdjunto As New Datos.clsDocumentoAdjunto
        retorno = odaClsDocumentoAdjunto.Insertar_Documentos_x_PreEmbarque(obeDocumentoAdjunto)
        Return retorno
    End Function


End Class
