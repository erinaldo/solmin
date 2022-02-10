Imports SOLMIN_ST.DATOS
Imports SOLMIN_ST.ENTIDADES.Mantenimientos

Namespace mantenimientos

    Public Class DocAdjuntoConductor_BLL

        Dim objDataAccessLayer As New DocAdjuntoConductor_DAL

        Public Function Listar_Documentos_Adjuntos(ByVal ht As Hashtable) As DataTable
            Return objDataAccessLayer.Listar_Documentos_Adjuntos(ht)
        End Function

        Public Function Registrar_Documento_Adjunto(ByVal objEntidad As DocAdjuntoConductor) As DocAdjuntoConductor
            Return objDataAccessLayer.Registrar_Documento_Adjunto(objEntidad)
        End Function

        Public Function Modificar_Documento_Adjunto(ByVal objEntidad As DocAdjuntoConductor) As DocAdjuntoConductor
            Return objDataAccessLayer.Modificar_Documento_Adjunto(objEntidad)
        End Function

        Public Function Eliminar_Documento_Adjunto(ByVal objEntidad As DocAdjuntoConductor) As DocAdjuntoConductor
            Return objDataAccessLayer.Eliminar_Documento_Adjunto(objEntidad)
        End Function

        Public Function Modificar_Documento_Adjunto_Obs(ByVal objEntidad As DocAdjuntoConductor) As DocAdjuntoConductor
            Return objDataAccessLayer.Modificar_Documento_Adjunto_Obs(objEntidad)
        End Function

        Public Function Listar_Documentos_Adjuntos_Rpt(ByVal ht As Hashtable) As DataTable
            Return objDataAccessLayer.Listar_Documentos_Adjuntos_Rpt(ht)
        End Function

    End Class

End Namespace