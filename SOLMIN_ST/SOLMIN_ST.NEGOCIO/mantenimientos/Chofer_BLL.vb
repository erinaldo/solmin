Imports SOLMIN_ST.DATOS.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
'****************************************************************************************************
'** Autor: Anddy Ramos
'** Fecha de Creación: 20/07/2009 
'** Descripción: capa de negocio.
'****************************************************************************************************
Namespace mantenimientos

  Public Class Chofer_BLL

    Dim objDataAccessLayer As New Chofer_DAL

    Public Function Registrar_Chofer(ByVal objEntidad As Chofer) As Chofer
      Return objDataAccessLayer.Registrar_Chofer(objEntidad)
    End Function

    Public Function Registrar_Chofer_Antiguo(ByVal objEntidad As Chofer) As Chofer
      Return objDataAccessLayer.Registrar_Chofer_Antiguo(objEntidad)
    End Function

    Public Function Modificar_Chofer(ByVal objEntidad As Chofer) As Chofer
      Return objDataAccessLayer.Modificar_Chofer(objEntidad)
    End Function

    Public Function Eliminar_Chofer(ByVal objEntidad As Chofer) As Chofer
      Return objDataAccessLayer.Eliminar_Chofer(objEntidad)
    End Function

    Public Function Listar_Chofer(ByVal objEntidad As Chofer) As List(Of Chofer)
            'Try
            Return objDataAccessLayer.Listar_Chofer(objEntidad)
            'Catch
            '          Return New List(Of Chofer)
            '      End Try
    End Function

    Public Function Listar_Chofer_Reporte(ByVal objEntidad As Chofer) As List(Of Chofer)
            'Try
            Return objDataAccessLayer.Listar_Chofer_Reporte(objEntidad)
            'Catch
            '          Return New List(Of Chofer)
            '      End Try
    End Function

    Public Function Listar_Chofer_Masivo_Reporte(ByVal objEntidad As Chofer) As DataTable 'List(Of Chofer)
      Return objDataAccessLayer.Listar_Chofer_Masivo_Reporte(objEntidad)
    End Function

    Public Function Obtener_brevete(ByVal objEntidad As Chofer) As Chofer
      Return objDataAccessLayer.Obtener_brevete(objEntidad)
    End Function

    Public Function Obtener_Estado_Chofer(ByVal lobjEntidad As Chofer) As String
      Return objDataAccessLayer.Obtener_Estado_Chofer(lobjEntidad)
    End Function

    Public Function Lista_Asistencia_Conductor(ByVal objHash As Hashtable) As DataTable
      Dim intFecIni As Int64 = Format(Date.Today.AddMonths(-1).AddDays(-Date.Today.AddMonths(-1).Day + 1), "yyyyMMdd")
      Dim intFecFin As Int64 = Format(Date.Today, "yyyyMMdd")
      objHash.Add("FECINI", intFecIni)
      objHash.Add("FECFIN", intFecFin)

      Return objDataAccessLayer.Lista_Asistencia_Conductor(objHash)
    End Function

    Public Function Aprobar_Conformidad_Datos_Conductor(ByVal objEntidad As Chofer, ByRef intEstado As Int16) As String
      Dim strResult As String = objDataAccessLayer.Aprobar_Conformidad_Datos_Conductor(objEntidad)
      If strResult = "" And intEstado = 2 Then
        strResult = "Se realizó la verificación"
        intEstado = 0
      Else
        strResult = "Se anuló la verificación"
        intEstado = 0
      End If
      Return strResult
    End Function

    Public Function Reporte_Asistencia_Conductor(ByVal objHash As Hashtable) As DataTable
      Dim intFecIni As Int64 = Format(Date.Today.AddMonths(-1).AddDays(-Date.Today.AddMonths(-1).Day + 1), "yyyyMMdd")
      Dim intFecFin As Int64 = Format(Date.Today, "yyyyMMdd")
      objHash.Add("FECINI", intFecIni)
      objHash.Add("FECFIN", intFecFin)

      Return objDataAccessLayer.Reporte_Asistencia_Conductor(objHash)
        End Function

        Public Function Lista_Asistencia_Conductor_Reporte(ByVal objHash As Hashtable) As DataTable
            Dim intFecIni As Int64 = Format(Date.Today.AddMonths(-1).AddDays(-Date.Today.AddMonths(-1).Day + 1), "yyyyMMdd")
            Dim intFecFin As Int64 = Format(Date.Today, "yyyyMMdd")
            objHash.Add("FECINI", intFecIni)
            objHash.Add("FECFIN", intFecFin)

            Return objDataAccessLayer.Lista_Asistencia_Conductor_Reporte(objHash)
        End Function

        'CSR-HUNDRED-feature/151116_Combustibles-inicio
        Public Function Lista_Conductor_General(ByVal Compania As String) As List(Of Chofer)
            Dim objGenericCollection As New List(Of Chofer)
            objGenericCollection = objDataAccessLayer.Lista_Conductor_General(Compania)
            Return objGenericCollection
        End Function
        'CSR-HUNDRED-feature/151116_Combustibles-fin

  End Class


End Namespace