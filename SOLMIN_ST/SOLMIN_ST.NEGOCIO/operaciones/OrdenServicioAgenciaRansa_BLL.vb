Imports SOLMIN_ST.DATOS.Operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones

Namespace Operaciones

  Public Class OrdenServicioAgenciaRansa_BLL

    Dim objDataAccessLayer As OrdenServicioAgenciaRansa_DAL

    Sub New()
      ' objDataAccessLayer = New OrdenServicioAgenciaRansa_DAL(Autenticacion_BLL.getReplacedConnectionString("DataBaseAgencias"))
      objDataAccessLayer = New OrdenServicioAgenciaRansa_DAL()
    End Sub
    Public Function Listar_Tablas_Agencias_Ransa() As DataSet
      Return objDataAccessLayer.Listar_Tablas_LIGORDAG()
    End Function

    Public Function Listar_Ordenes_Servicio_Agencia_Ransa(ByVal objParametros As List(Of String)) As DataTable
      Return objDataAccessLayer.Listar_OS_Agencias_Ransa(objParametros)
    End Function

    Public Function Registrar_Orden_Servicio(ByVal objLista As Hashtable) As String

      Dim lstr_resultado As String = ""
      Try
        Dim objAgenciasRansa As New OrdenServicioAgenciaRansa_DAL
        Dim objEntidad As New OrdenServicioAgenciaRansa
        Dim objParametros As New List(Of String)
        Dim objHashDatosOperacion As New Hashtable
        Dim objHashDatosMercaderia As New Hashtable

        With objEntidad
          ''Llenando las Variables ''Estaticas'' de la entidad
          .NOPRCN = "0"
          .CTPOSR = "L"
          .CTPSBS = "TA"
          .FINCOP = objLista("HOY")
          .FTRMOP = ""
          .NPLNMT = ""
          .SESTOP = "P"
          .CPLNCL = "1"
          .SORGMV = "A"
          .SINDPS = "R"
          .CCNCST = "117"
          .CUSCRT = "VBNET BAS"
          .FCHCRT = objLista("HOY")
          .HRACRT = objLista("HORA")
          .NTRMCR = ""
          .CCMPN = "EZ"
          .CDVSN = "T"
          .CPLNDV = "1"
          .NDCORM = objLista("AGE_NORSRT").ToString.Trim
        End With

        '1) Buscando la mercaderia de la orden de servicio de trasporte
        objParametros.Add(objLista("NORSRT"))

        If objAgenciasRansa.Obtener_Mecaderia_OS_TR(objParametros) = "0" Then
          lstr_resultado = "ERROR : No tiene número de Orden de Servicio en Trasportes!"
          GoTo ExitZone
        Else
          'Llenando las variables de la entidad
          objEntidad.CMRCDR = objAgenciasRansa.Obtener_Mecaderia_OS_TR(objParametros)
        End If

        '2) Obteniendo datos de la Operacion de Agencias Ransa
        objParametros.Clear()
        objParametros.Add(objLista("PNCDTR"))
        objHashDatosOperacion = objAgenciasRansa.Obtener_Informacion_OS_Agencia_Ransa(objParametros)

        If objHashDatosOperacion("TRFSRC") = "" And objHashDatosOperacion("TRFMRC") = "" And objHashDatosOperacion("CCLNFC") = "" And objHashDatosOperacion("NDCORM") = "" Then
          lstr_resultado = "ERROR : No tiene número de Orden de Servicio en Trasportes!"
          GoTo ExitZone
        Else
          'Llenando las variables de la entidad

          With objEntidad
            .NORSRT = objLista("NORSRT")
            .TRFSRC = objHashDatosOperacion("TRFSRC")
            .TRFMRC = objHashDatosOperacion("TRFMRC").ToString.Substring(0, 40)
            .CCLNFC = objHashDatosOperacion("DCASCI")
            .CCLNT = objHashDatosOperacion("DCASCI")
            '.NDCORM = objHashDatosOperacion("NDCORM")
          End With

        End If

        '3) Buscando el cliente de agencias Ransa
        If objLista("CCLNT") = "" Then
          objParametros.Clear()
          objParametros.Add(objHashDatosOperacion("DCASCI"))
          objEntidad.TNMBRM = objAgenciasRansa.Obtener_Cliente_OS_TR(objParametros)
        Else
          objEntidad.CCLNFC = objLista("CCLNT")
          objEntidad.CCLNT = objLista("CCLNT")
          objEntidad.TNMBRM = ""
        End If

        '4)Agregando Cantidad y Peso de Mercaderías
        objParametros.Clear()
        objParametros.Add(objLista("PNCDTR"))
        objHashDatosMercaderia = objAgenciasRansa.Listar_Cantidad_Volumen_OS_Agencias(objParametros)

        With objEntidad
          .QMRCDR = objHashDatosMercaderia("cantidad")
          .PMRCDR = objHashDatosMercaderia("peso")
        End With

        '4)Enviar a la operacion de Agencias Ransa
        lstr_resultado = objAgenciasRansa.Registrar_Operacion_Agencia_Ransa(objEntidad, objLista("PNCDTR"), objHashDatosOperacion("PNCDAC"))

      Catch ex As Exception
        lstr_resultado = "ERROR : Error al generar la operación."
      End Try

ExitZone:
      Return lstr_resultado
    End Function

  End Class

End Namespace