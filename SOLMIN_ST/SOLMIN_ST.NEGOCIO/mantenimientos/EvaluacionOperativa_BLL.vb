Imports SOLMIN_ST.DATOS.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Namespace mantenimientos
    Public Class EvaluacionOperativa_BLL
        Dim objDataAccessLayer As New EvaluacionOperativa_DAL
#Region "Incidencias"


        Public Function Listar_Evaluacion_Operativa(ByVal Entidad As EvaluacionOperativa) As List(Of EvaluacionOperativa)
            Return objDataAccessLayer.Listar_Evaluacion_Operativa(Entidad)
        End Function

        Public Function Listar_categorias(ByVal PNTIPCAT As Integer, ByVal CCMPN As String) As DataTable
            Return objDataAccessLayer.Listar_categorias(PNTIPCAT, CCMPN)
        End Function
       
        Public Function Listar_Subcategorias(ByVal PNTIPCAT As Integer, ByVal PNCODCAT As Integer, ByVal CCMPN As String) As DataTable
            Return objDataAccessLayer.Listar_Subcategorias(PNTIPCAT, PNCODCAT, CCMPN)
        End Function

        Public Sub Registrar_Evaluacion_Operacion(ByVal olstEvaluacionOperativa As List(Of EvaluacionOperativa))
            For Each objEntidad As EvaluacionOperativa In olstEvaluacionOperativa
                objDataAccessLayer.Registrar_Evaluacion_Operacion(objEntidad)
            Next
        End Sub

        Public Sub Eliminar_Evaluacion_Operacion(ByVal olstEvaluacionOperativa As List(Of EvaluacionOperativa))
            For Each objEntidad As EvaluacionOperativa In olstEvaluacionOperativa
                objDataAccessLayer.Eliminar_Evaluacion_Operacion(objEntidad)
            Next
        End Sub

        Public Sub Actualizar_Evaluacion_Operacion(ByVal olstEvaluacionOperativa As List(Of EvaluacionOperativa))
            For Each objEntidad As EvaluacionOperativa In olstEvaluacionOperativa
                objDataAccessLayer.Actualizar_Evaluacion_Operacion(objEntidad)
            Next
        End Sub

#End Region

#Region "Evaluacion Operativa"

        Public Function LISTAR_EVA_OP_CONSULTA(ByVal Entidad As EvaluacionOperativa) As List(Of EvaluacionOperativa)
            Return objDataAccessLayer.LISTAR_EVA_OP_CONSULTA(Entidad)
        End Function

#End Region


#Region "Evaluacion Administrativa"



        Public Function LISTAR_EVA_ADMIN_CONSULTA(ByVal Entidad As EvaluacionOperativa) As List(Of EvaluacionOperativa)
            Return objDataAccessLayer.LISTAR_EVA_ADMIN_CONSULTA(Entidad)
        End Function

        Public Sub INSERTAR_EVA_ADMIN(ByVal olstEvaluacionOperativa As List(Of EvaluacionOperativa))
            For Each objEntidad As EvaluacionOperativa In olstEvaluacionOperativa
                objDataAccessLayer.INSERTAR_EVA_ADMIN(objEntidad)
            Next
        End Sub

        Public Sub ACTUALIZAR_EVA_ADMIN(ByVal olstEvaluacionOperativa As List(Of EvaluacionOperativa))
            For Each objEntidad As EvaluacionOperativa In olstEvaluacionOperativa
                objDataAccessLayer.ACTUALIZAR_EVA_ADMIN(objEntidad)
            Next
        End Sub

        Public Sub ELIMINAR_EVA_ADMIN(ByVal olstEvaluacionOperativa As List(Of EvaluacionOperativa))
            For Each objEntidad As EvaluacionOperativa In olstEvaluacionOperativa
                objDataAccessLayer.ELIMINAR_EVA_ADMIN(objEntidad)
            Next
        End Sub
#End Region


#Region "EVALUACION FINAL"
        Public Function LISTAR_EVA_FINAL_CONSULTA(ByVal Entidad As EvaluacionOperativa) As List(Of EvaluacionOperativa)
            Return objDataAccessLayer.LISTAR_EVA_FINAL_CONSULTA(Entidad)
        End Function
#End Region

        'Nuevo ------------  Mejorando el Cargado de los combox
        Public Function Listar_categorias2(ByVal Entidad As EvaluacionOperativa) As DataTable
            Return objDataAccessLayer.Listar_categorias2(Entidad)
        End Function
        Public Function Listar_Subcategorias2(ByVal Entidad As EvaluacionOperativa) As DataTable
            Return objDataAccessLayer.Listar_Subcategorias2(Entidad)
        End Function


#Region "Exportar a Excel Ovaluacion Operativa"

        Public Function Listar_CategoriasExcel(ByVal PNTIPCAT As Integer, ByVal CCMPN As String) As DataTable
            Return objDataAccessLayer.Listar_CategoriasExcel(PNTIPCAT, CCMPN)
        End Function

        Public Function INCIDENCIAS_CATEGORIA_PROVEEDOR(ByVal beFiltro As EvaluacionOperativa) As DataTable
            Return objDataAccessLayer.INCIDENCIAS_CATEGORIA_PROVEEDOR(beFiltro)
        End Function

        Public Function VIAJES_KILOMETROS_PROVEEDOR(ByVal beFiltro As EvaluacionOperativa) As DataTable
            Return objDataAccessLayer.VIAJES_KILOMETROS_PROVEEDOR(beFiltro)
        End Function
#End Region


#Region "Exportar a Excel Ovaluacion Administrativa"


        Public Function PROVEEDORES_PERIODO(ByVal ANIOMES As Integer, ByVal CCMPN As String) As DataTable
            Return objDataAccessLayer.PROVEEDORES_PERIODO(ANIOMES, CCMPN)
        End Function
        Public Function PROVEEDORES_EVA_ADMIN_MES(ByVal beFiltro As EvaluacionOperativa) As DataTable
            Return objDataAccessLayer.PROVEEDORES_EVA_ADMIN_MES(beFiltro)
        End Function

        Public Function EVALUACION_ADMINISTRATIVA_MES(ByVal beFiltro As EvaluacionOperativa) As DataTable
            Return objDataAccessLayer.EVALUACION_ADMINISTRATIVA_MES(beFiltro)
        End Function

#End Region

#Region "Evaluacion Final"
        Public Function EVA_FINAL_MES(ByVal Entidad As EvaluacionOperativa) As DataTable
            Return objDataAccessLayer.EVA_FINAL_MES(Entidad)
        End Function
#End Region
    End Class
End Namespace