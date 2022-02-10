Imports SOLMIN_ST
Imports SOLMIN_ST.DATOS.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos

Namespace Operaciones

    Public Class OrdenInterna_BLL

        'Public Function Generar_Orden_Interna(ByVal objLista As List(Of String)) As Planeamiento

        '    'Objetos del negocio y entidad
        '    Dim objOrdenInterna As New OrdenInterna_DAL
        '    Dim objEntidad As New Planeamiento

        '    Dim objListaParametros1 As New List(Of String)
        '    objListaParametros1.Add(objLista(0)) ' NOPRCN
        '    objListaParametros1.Add(objLista(1)) ' CUSCRT
        '    objListaParametros1.Add(objLista(2)) ' FCHCRT
        '    objListaParametros1.Add(objLista(3)) ' HRACRT
        '    objListaParametros1.Add(objLista(4)) ' NTRMCR
        '    objListaParametros1.Add(objLista(8)) ' CCMPN
        '    'Generando la orden interna
        '    objEntidad = objOrdenInterna.Generar_Orden_Interna(objLista)
        '    Dim objListaParametros2 As New List(Of String)
        '    objListaParametros2.Add(objEntidad.CCLORI)
        '    objListaParametros2.Add(objEntidad.NORINS) 'NORINS
        '    objListaParametros2.Add(objLista(0)) 'NOPRCN
        '    objListaParametros2.Add(objLista(5)) 'NPLCTR
        '    objListaParametros2.Add(objLista(6)) 'NPLCAC
        '    objListaParametros2.Add(objLista(7)) 'CBRCNT
        '    objListaParametros2.Add(objLista(8)) 'CCMPN
        '    'si la orden interna ha sido generada, procede a actualizarla
        '    'en la tabla rztr08 (la tabla de recursos por planeamiento) 
        '    If objEntidad.NORINS > 0 Then
        '        objOrdenInterna.Actualizar_Planeamiento(objListaParametros2)
        '    End If
        '    kskkk()
        '    Return objEntidad

        'End Function

        Public Function Generar_Orden_Interna_SALM(ByVal oFiltro As ENTIDADES.Operaciones.OperacionTransporte, ByRef msgError As String) As ENTIDADES.beRespuestaOperacion
 
            Dim objOrdenInterna As New OrdenInterna_DAL
            Return objOrdenInterna.Generar_Orden_Interna_SALM(oFiltro, msgError)
 
        End Function

    End Class

End Namespace