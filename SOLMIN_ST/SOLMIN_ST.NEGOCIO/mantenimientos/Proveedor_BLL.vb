Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.DATOS

Public Class Proveedor_BLL
    Dim objDataAccessLayer As New Proveedor_DAL

    Public Function Listar_Tipos(ByVal strCompania As String, ByVal strCodVar As String) As DataTable 'List(Of Proveedor)
        Return objDataAccessLayer.Listar_Tipos(strCompania, strCodVar)
    End Function

    Public Function Listar_Proveedores_Alquiler(ByVal objEntidad As Proveedor) As List(Of Proveedor)
        Return objDataAccessLayer.Listar_Proveedores_Alquiler(objEntidad)
    End Function
    Public Function Listar_Placa(ByVal objEntidad As Proveedor) As List(Of Proveedor)
        Return objDataAccessLayer.Listar_Placa(objEntidad)
    End Function
    Public Sub Registrar_Asignacion_Proveedor_Recurso(ByVal objEntidad As Proveedor, ByVal PSREASIGNAR As String)
        objDataAccessLayer.Registrar_Asignacion_Proveedor_Recurso(objEntidad, PSREASIGNAR)
    End Sub
    Public Function Validar_Existe_Placa_Proveedor(ByVal objEntidad As Proveedor, ByRef strMensajeError As String) As Boolean
        Return objDataAccessLayer.Validar_Existe_Placa_Proveedor(objEntidad, strMensajeError)
    End Function

    Public Function Eliminar_Asignacion_Proveedor_Recurso(ByVal objEntidad As Proveedor) As Integer
        Return objDataAccessLayer.Eliminar_Asignacion_Proveedor_Recurso(objEntidad)
    End Function

    Public Function Listar_Placa_Recurso_Asignado(ByVal PSCCMPN As String, ByVal PSTIPO As String, ByVal PSPLACA As String) As DataTable
        Return objDataAccessLayer.Listar_Placa_Recurso_Asignado(PSCCMPN, PSTIPO, PSPLACA)
    End Function

End Class
