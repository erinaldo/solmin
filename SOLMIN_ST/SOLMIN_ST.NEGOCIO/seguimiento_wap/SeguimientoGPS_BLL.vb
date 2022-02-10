Imports SOLMIN_ST.DATOS
Imports SOLMIN_ST.ENTIDADES
Public Class SeguimientoGPS_BLL


    Public Function Listar_Seguimiento_GPS(ByVal obeSeguimientoGPS As SeguimientoGPS) As List(Of SeguimientoGPS)
        Dim odaSeguimientoGPS As New SeguimientoGPS_DAL()
        Return odaSeguimientoGPS.Listar_Seguimiento_GPS(obeSeguimientoGPS)
    End Function
    Public Function Lista_GPS_RZTR11A(ByVal obeSeguimientoGPS As SeguimientoGPS, ByVal oListActual As List(Of SeguimientoGPS)) As List(Of SeguimientoGPS)
        Dim odaSeguimientoGPS As New SeguimientoGPS_DAL()
        'Dim econtrado As Boolean = False
        'Dim oListSeguimientoGPS As New List(Of SeguimientoGPS)
        'For Each Item As SeguimientoGPS In odaSeguimientoGPS.Lista_GPS_RZTR11A(obeSeguimientoGPS)
        '    econtrado = False
        '    For Each oItem As SeguimientoGPS In oListActual
        '        If (Item.NPLCTR = oItem.NPLCTR And Item.FECGPS = oItem.FECGPS And Item.HORA = oItem.HORA) Then
        '            econtrado = True
        '            Exit For
        '        End If
        '    Next
        '    If (econtrado = False) Then
        '        oListSeguimientoGPS.Add(Item)
        '    End If
        'Next
        Return odaSeguimientoGPS.Lista_GPS_RZTR11A(obeSeguimientoGPS)
    End Function

    Public Function Importar_Seguimiento_GPS(ByVal obeLitsSeguimientoGPS As List(Of SeguimientoGPS)) As Int32
        Dim odaSeguimientoGPS As New SeguimientoGPS_DAL()
        Dim retorno As Int32 = 0
        For Each obeSeguimientoGPS As SeguimientoGPS In obeLitsSeguimientoGPS
            retorno = odaSeguimientoGPS.Importar_Seguimiento_GPS(obeSeguimientoGPS)
        Next
        Return retorno
    End Function
    Public Function Insertar_Seguimiento_GPS(ByVal obeSeguimientoGPS As SeguimientoGPS) As Int32
        Dim odaSeguimientoGPS As New SeguimientoGPS_DAL()
        Return odaSeguimientoGPS.Insertar_Seguimiento_GPS(obeSeguimientoGPS)
    End Function
    Public Function VerificarExistenciaSeguimientoRZTR11S(ByVal obeSeguimientoGPS As SeguimientoGPS) As Int32
        Dim odaSeguimientoGPS As New SeguimientoGPS_DAL()
        Return odaSeguimientoGPS.VerificarExistenciaSeguimientoRZTR11S(obeSeguimientoGPS)
    End Function
    Public Function Eliminar_Seguimiento_GPS(ByVal obeSeguimientoGPS As SeguimientoGPS) As Int32
        Dim odaSeguimientoGPS As New SeguimientoGPS_DAL()
        Return odaSeguimientoGPS.Eliminar_Seguimiento_GPS(obeSeguimientoGPS)
    End Function
    Public Function ActualizarRZST20(ByVal Entidad As SeguimientoGPS) As Int32
        Dim odaSeguimientoGPS As New SeguimientoGPS_DAL()
        Return odaSeguimientoGPS.ActualizarRZST20(Entidad)
    End Function
End Class
