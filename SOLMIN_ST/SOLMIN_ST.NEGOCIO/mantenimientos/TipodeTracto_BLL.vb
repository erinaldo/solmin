Imports SOLMIN_ST.DATOS.Mantenimientos
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports System.Collections.Generic

Namespace mantenimientos
    Public Class TipodeTracto_BLL

        Dim objDataAccessLayer As New TipodeTracto_DAL

        Public Function Registrar_TipodeTracto(ByVal objEntidad As TipodeTracto) As TipodeTracto
            Return objDataAccessLayer.Registrar_TipodeTracto(objEntidad)
        End Function

        Public Function Modificar_TipodeTracto(ByVal objEntidad As TipodeTracto) As TipodeTracto
            Return objDataAccessLayer.Modificar_TipodeTracto(objEntidad)
        End Function

        Public Function Cambiar_Estado_TipodeTracto(ByVal objEntidad As TipodeTracto) As TipodeTracto
            Return objDataAccessLayer.Cambiar_Estado_TipodeTracto(objEntidad)
        End Function

        Public Function Listar_TipodeTracto(ByVal objEntidad As TipodeTracto) As List(Of TipodeTracto)
            Try
                Return objDataAccessLayer.Listar_TipodeTracto(objEntidad)
            Catch
                Return New List(Of TipodeTracto)
            End Try
        End Function

        Public Function Listar_TipodeTractoCbo() As List(Of TipodeTracto)
            Try
                Return objDataAccessLayer.Listar_TipodeTractoCbo()
            Catch
                Return New List(Of TipodeTracto)
            End Try
        End Function

        Public Function Busca_TipodeTracto(ByVal objEntidad As TipodeTracto) As List(Of TipodeTracto)
            Try
                Return objDataAccessLayer.Buscar_TipodeTracto(objEntidad)
            Catch
                Return New List(Of TipodeTracto)
            End Try
        End Function
        Public Function Listar_TipodeTracto_seleccion(ByVal CCMPN As String) As DataTable
            Return objDataAccessLayer.Listar_TipodeTracto_seleccion(CCMPN)
        End Function

    End Class
End Namespace

