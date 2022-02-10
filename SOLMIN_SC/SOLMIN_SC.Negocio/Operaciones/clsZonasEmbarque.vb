Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Datos
Public Class clsZonasEmbarque
    Public Function Lista_Zonas_Embarque(ByVal PNCCLNT As Decimal, ByVal PSTZNAEM As String) As List(Of ZonaEmbarque_BE)
        Dim odaZonasEmbarque As New Datos.clsZonasEmbarque
        Dim oListZonasEmbarque As New List(Of ZonaEmbarque_BE)
        oListZonasEmbarque = odaZonasEmbarque.Lista_Zonas(PNCCLNT, PSTZNAEM)
        Return oListZonasEmbarque
    End Function

    Public Function Lista_Paises_Zonas_Embarque(ByVal PNCCLNT As Decimal, ByVal PSCZNAEM As String) As List(Of ZonaEmbarque_BE)
        Dim odaZonasEmbarque As New Datos.clsZonasEmbarque
        Dim oListPais__X_ZonaEmbarque As New List(Of ZonaEmbarque_BE)
        oListPais__X_ZonaEmbarque = odaZonasEmbarque.Lista_Paises_Zonas(PNCCLNT, PSCZNAEM)
        Return oListPais__X_ZonaEmbarque
    End Function
    Public Function Insertar_Zonas_Embarque(ByVal obeZonaEmbarque As ZonaEmbarque_BE) As Integer
        Dim odaZonasEmbarque As New Datos.clsZonasEmbarque
        Dim retorno As Int32 = 0
        Dim obeZonaEmbFind As New ZonaEmbarque_BE
        'Try
        retorno = odaZonasEmbarque.Insertar_Zonas_Embarque(obeZonaEmbarque)
        retorno = 1
        'Catch ex As Exception
        '    Throw New Exception(ex.Message)
        'End Try
        Return retorno
    End Function
    Public Function Actualiza_Zonas_Embarque(ByVal obeZonaEmbarque As ZonaEmbarque_BE) As Int32
        Dim odaZonasEmbarque As New Datos.clsZonasEmbarque
        Dim retorno As Int32 = 0
        retorno = odaZonasEmbarque.Actualiza_Zonas_Embarque(obeZonaEmbarque)
        Return retorno
    End Function
    Public Function Elimina_Zonas_Embarque(ByVal obeZonaEmbarque As ZonaEmbarque_BE) As Int32
        Dim odaZonasEmbarque As New Datos.clsZonasEmbarque
        Dim retorno As Int32 = 0
        retorno = odaZonasEmbarque.Elimina_Zonas_Embarque(obeZonaEmbarque)
        Return retorno
    End Function
    Public Function Actualizar_Zona_Pais_Embarque(ByVal obeZonaEmbarque As ZonaEmbarque_BE) As beMensaje
        Dim obeMensaje As New beMensaje
        Dim odaZonasEmbarque As New Datos.clsZonasEmbarque
        Dim obeZonaPaisEmbFind As New ZonaEmbarque_BE
        Dim retorno As Int32 = 0
        obeZonaPaisEmbFind = odaZonasEmbarque.Existe_X_Zona_Pais_Puerto_Cliente(obeZonaEmbarque.PNCCLNT, obeZonaEmbarque.PSCZNAEM, obeZonaEmbarque.PNCPAIS, obeZonaEmbarque.PSCPRTOE)
        If (obeZonaPaisEmbFind Is Nothing) Then
            obeMensaje.PBEXITO = True
            retorno = odaZonasEmbarque.Actualizar_Zona_Pais_Embarque(obeZonaEmbarque)
        Else
            obeMensaje.PBEXITO = False
            obeMensaje.PSMENSAJE = "Ya existe la relación. Verifique el puerto."
        End If
        Return obeMensaje
    End Function
    Public Function Insertar_Zona_Pais_Embarque(ByVal obeZonaEmbarque As ZonaEmbarque_BE) As beMensaje
        Dim obeMensaje As New beMensaje
        Dim odaZonasEmbarque As New Datos.clsZonasEmbarque
        Dim obeZonaPaisEmbFind As New ZonaEmbarque_BE
        Dim retorno As Int32 = 0
        obeZonaPaisEmbFind = odaZonasEmbarque.Existe_X_Pais_En_Otra_Zona_D_Cliente(obeZonaEmbarque.PNCCLNT, obeZonaEmbarque.PSCZNAEM, obeZonaEmbarque.PNCPAIS)
        If (obeZonaPaisEmbFind Is Nothing) Then
            obeZonaPaisEmbFind = odaZonasEmbarque.Existe_X_Zona_Pais_Puerto_Cliente(obeZonaEmbarque.PNCCLNT, obeZonaEmbarque.PSCZNAEM, obeZonaEmbarque.PNCPAIS, obeZonaEmbarque.PSCPRTOE)
            If (obeZonaPaisEmbFind Is Nothing) Then
                obeMensaje.PBEXITO = True
                retorno = odaZonasEmbarque.Insertar_Zona_Pais_Embarque(obeZonaEmbarque)
            Else
                obeMensaje.PBEXITO = False
                obeMensaje.PSMENSAJE = "Ya existe la relación. Verifique el puerto."
            End If
        Else
            obeMensaje.PBEXITO = False
            obeMensaje.PSMENSAJE += "No se pudo asignar la relación." & Chr(13) & "El país pertenece a otra Zona de Embarque.(" & obeZonaPaisEmbFind.PSCZNAEM & "-" & obeZonaPaisEmbFind.PSTZNAEM & ")"
            obeMensaje.PSMENSAJE = obeMensaje.PSMENSAJE & Chr(13) & "Seleccione otro País."
        End If
        Return obeMensaje
    End Function
    Public Function Elimina_Zonas_Pais_Embarque(ByVal obeZonaEmbarque As ZonaEmbarque_BE) As Int32
        Dim odaZonasEmbarque As New Datos.clsZonasEmbarque
        Dim retorno As Int32 = 0
        retorno = odaZonasEmbarque.Elimina_Zonas_Pais_Embarque(obeZonaEmbarque)
        Return retorno
    End Function

End Class
