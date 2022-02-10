Imports RANSA.DATA
Imports RANSA.TypeDef
Public Class CargaRecepcion_CC
    Dim oDatos As New daCargaRecepcion_CC

    ''' <summary>
    ''' Listar Carga Recepcionada Centro de Costo RZOL66
    ''' </summary>
    ''' <param name="obebulto ">Centro de Costo RZOL66</param>
    ''' <returns>Lista"be" <</returns>
    ''' <remarks></remarks>
    Public Function ListarCargaRecepcion_CC(ByVal obeBulto As beBulto) As List(Of beBulto)
        Return oDatos.ListarCargaRecepcionada_CentroCosto(obeBulto)
    End Function

    ''' <summary>
    ''' Actualiza Carga Recepcionada Centro de Costo RZOL66
    ''' </summary>
    ''' <param name="obebulto ">Centro de Costo RZOL66</param>
    ''' <returns>Int32</returns>
    ''' <remarks></remarks>
    Public Function Actualizar_Carga_Recepcionada_Centro_Costo(ByVal obebulto As beBulto) As Int32
        Return oDatos.Actualizar_Carga_Recepcionada_Centro_Costo(obebulto)
    End Function
    ''' <summary>
    ''' Actualiza cuentas de imputacion
    ''' </summary>
    ''' <param name="obebulto"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Actualizar_CuentasImputacion(ByVal obebulto As beBulto) As Int32
        Return oDatos.Actualizar_CuentasImputacion(obebulto)
    End Function

    ''' <summary>
    ''' Lista de bultos predespachados por código de pre despacho 
    ''' </summary>
    ''' <param name="obeBulto"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function listaBultosPorCodPreDespacho(ByVal obeBulto As beBulto) As List(Of beBulto)
        Return Nothing 'oDatos.listaBultosPorCodPreDespacho(obeBulto)
    End Function
End Class
