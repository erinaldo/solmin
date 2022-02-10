Imports SOLMIN_ST.DATOS.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos

Namespace mantenimientos

    Public Class DocsAdjuntos_SolTransporte_BLL

        Dim objDataAccessLayer As New DocsAdjuntos_SolTransporte_DAL

        Public Function Listar_Documentos_Adjuntos(ByVal objEntidad As ENTIDADES.Operaciones.Solicitud_Transporte) As DataTable
            Return objDataAccessLayer.Listar_Documentos_Adjuntos(objEntidad)
        End Function
        Public Function Listar_Documentos_Adjuntos(ByVal ht As Hashtable) As DataTable
            Return objDataAccessLayer.Listar_Documentos_Adjuntos(ht)
        End Function

        Public Function Registrar_Documento_Adjunto(ByVal objEntidad As DocsAdjuntos_SolTransporte) As DocsAdjuntos_SolTransporte
            Return objDataAccessLayer.Registrar_Documento_Adjunto(objEntidad)
        End Function

        Public Function Modificar_Documento_Adjunto(ByVal objEntidad As DocsAdjuntos_SolTransporte) As DocsAdjuntos_SolTransporte
            Return objDataAccessLayer.Modificar_Documento_Adjunto(objEntidad)
        End Function

        Public Function Eliminar_Documento_Adjunto(ByVal objEntidad As DocsAdjuntos_SolTransporte) As DocsAdjuntos_SolTransporte
            Return objDataAccessLayer.Eliminar_Documento_Adjunto(objEntidad)
    End Function
    Public Function DocumentoTransporteListar(ByVal objEntidad As DocsAdjuntos_SolTransporte) As DataTable
      Return objDataAccessLayer.DocumentoTransporteListar(objEntidad)
    End Function

    Public Function DocumentoTransporteInsertar(ByVal objEntidad As DocsAdjuntos_SolTransporte) As Integer
      Return objDataAccessLayer.DocumentoTransporteInsertar(objEntidad)
    End Function

    End Class

End Namespace