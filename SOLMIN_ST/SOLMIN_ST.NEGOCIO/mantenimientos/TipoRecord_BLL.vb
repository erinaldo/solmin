Imports SOLMIN_ST.DATOS.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
'****************************************************************************************************
'** Autor: Rafael Gamboa
'** Fecha de Creación: 09/09/2009 
'** Descripción: capa de negocio.
'****************************************************************************************************
Namespace mantenimientos

  Public Class TipoRecord_BLL
    Dim objDataAccessLayer As New TipoRecord_DAL
 
        Public Function Listar_Tipo_Record(ByVal objEntidad As TipoRecord) As List(Of TipoRecord)
            'Try
            Return objDataAccessLayer.Listar_Tipo_Record(objEntidad)
            'Catch
            '    Return New List(Of TipoRecord)
            'End Try
        End Function
  End Class
End Namespace