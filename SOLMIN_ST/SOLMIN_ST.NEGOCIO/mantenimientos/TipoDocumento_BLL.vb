Imports SOLMIN_ST.DATOS.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports System.Collections.Generic

Namespace mantenimientos
  Public Class TipoDocumento_BLL

    Dim objDataAccessLayer As New TipoDocumento_DAL

    Public Function Listar_Tipo_Documento(ByVal objEntidad As TipoDocumento) As List(Of TipoDocumento)
      Return objDataAccessLayer.Listar_Tipo_Documento(objEntidad)
        End Function
        Public Function Listar_Tipo_Documentos_Para_Refacturar(ByVal objEntidad As TipoDocumento) As DataTable
            Return objDataAccessLayer.Listar_Tipo_Documentos_Para_Refacturar(objEntidad)
        End Function

        Public Function Listar_Tipo_Documentos_Para_Refacturar_FE(ByVal objEntidad As TipoDocumento) As DataTable
            Return objDataAccessLayer.Listar_Tipo_Documentos_Para_Refacturar_FE(objEntidad)
        End Function
  End Class
End Namespace

