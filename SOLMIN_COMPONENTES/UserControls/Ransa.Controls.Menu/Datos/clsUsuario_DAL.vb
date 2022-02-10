Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.Utilitario
Public Class clsUsuario_DAL
    Public Function Listar_Usuario_x_Opcion(ByVal obeUsuario As beUsuario) As DataTable
        Dim dt As New DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSMMCAPL", obeUsuario.PSMMCAPL_CodApl)
        lobjParams.Add("PSMMCMNU", obeUsuario.PSMMCMNU_CodMnu)
        lobjParams.Add("PSMMCOPC", obeUsuario.PNMMCOPC_CodOpc)
    dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SD_LISTA_USUARIOS_X_OPCION", lobjParams)
        Return dt
    End Function

    Public Function Listar_Usuario_x_Opcion_Export(ByVal PSMMCAPL As String, ByVal PSMMCMNU As String, ByVal LIST_PSMMCOPC As String) As DataTable
        Dim dt As New DataTable
        Dim lobjSql As New SqlManager
        Dim lobjParams As New Parameter
        lobjParams.Add("PSMMCAPL", PSMMCAPL)
        lobjParams.Add("PSMMCMNU", PSMMCMNU)
        lobjParams.Add("PSMMCOPC", LIST_PSMMCOPC)
        dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SD_LISTA_USUARIOS_X_OPCION_EXPORT", lobjParams)
        Return dt
    End Function


    'SP_SOLMIN_SD_LISTA_USUARIOS_X_OPCION_EXPORT

  Public Function Listar_Usuarios(ByVal obeUsuario As beUsuario) As List(Of beUsuario)
    Dim dt As New DataTable
    Dim oHashtable As New Hashtable
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter

    Dim listUsuario As New List(Of beUsuario)
    Dim oUsuario As beUsuario
    lobjParams.Add("PSMMCUSR", obeUsuario.PSMMCUSR)
    lobjParams.Add("PSMMNUSR", obeUsuario.PSMMNUSR)
    lobjParams.Add("PSSESTRG", obeUsuario.PSSESTRG)
    lobjParams.Add("PAGESIZE", obeUsuario.PageSize)
    lobjParams.Add("PAGENUMBER", obeUsuario.PageNumber)
    lobjParams.Add("PAGECOUNT", 0, ParameterDirection.Output)

    dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SD_LISTA_USUARIOS_X_PAGINACION", lobjParams)

    For Each dr As DataRow In dt.Rows
      oUsuario = New beUsuario
      oUsuario.PSMMCUSR = HelpClass.ToStringCvr(dr("MMCUSR"))
      oUsuario.PSMMNUSR = HelpClass.ToStringCvr(dr("MMNUSR"))
      oUsuario.PSMMCAII = HelpClass.ToStringCvr(dr("MMCAII"))
      oUsuario.PSMMCMII = HelpClass.ToStringCvr(dr("MMCMII"))
      oUsuario.PSCOROCC = HelpClass.ToStringCvr(dr("COROCC"))
      oUsuario.PSCCMPOR = HelpClass.ToStringCvr(dr("CCMPOR"))
      oUsuario.PSCDVSNU = HelpClass.ToStringCvr(dr("CDVSNU"))
      oUsuario.PSMMTUSR = HelpClass.ToStringCvr(dr("MMTUSR"))
      oUsuario.PNCNVUSR = HelpClass.ToStringCvr(dr("CNVUSR"))
      oUsuario.PSSORGZN = HelpClass.ToStringCvr(dr("SORGZN"))
      oUsuario.OPCIONES = HelpClass.ToStringCvr(dr("OPCIONES"))
      oUsuario.CLIENTES = HelpClass.ToStringCvr(dr("CLIENTES"))
      oUsuario.PLANTAS = HelpClass.ToStringCvr(dr("PLANTAS"))
      oUsuario.PSSESTRG = HelpClass.ToStringCvr(dr("SESTRG"))
      oUsuario.SESTRG_DESC = HelpClass.ToStringCvr(dr("SESTRG_DESC"))
      oUsuario.PageCount = lobjSql.ParameterCollection("PAGECOUNT")
      listUsuario.Add(oUsuario)
    Next
    Return listUsuario

  End Function

  Public Function Listar_Usuarios_Total(ByVal obeUsuario As beUsuario) As List(Of beUsuario)
    Dim dt As New DataTable
    Dim oHashtable As New Hashtable
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter

    Dim listUsuario As New List(Of beUsuario)
    Dim oUsuario As beUsuario
    lobjParams.Add("PSMMCUSR", obeUsuario.PSMMCUSR)
    lobjParams.Add("PSMMNUSR", obeUsuario.PSMMNUSR)
    lobjParams.Add("PSSESTRG", obeUsuario.PSSESTRG)

    dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SD_LISTA_USUARIOS", lobjParams)

    For Each dr As DataRow In dt.Rows
      oUsuario = New beUsuario
      oUsuario.PSMMCUSR = HelpClass.ToStringCvr(dr("MMCUSR"))
      oUsuario.PSMMNUSR = HelpClass.ToStringCvr(dr("MMNUSR"))
      oUsuario.PSMMCAII = HelpClass.ToStringCvr(dr("MMCAII"))
      oUsuario.PSMMCMII = HelpClass.ToStringCvr(dr("MMCMII"))
      oUsuario.PSCOROCC = HelpClass.ToStringCvr(dr("COROCC"))
      oUsuario.PSCCMPOR = HelpClass.ToStringCvr(dr("CCMPOR"))
      oUsuario.PSCDVSNU = HelpClass.ToStringCvr(dr("CDVSNU"))
      oUsuario.PSMMTUSR = HelpClass.ToStringCvr(dr("MMTUSR"))
      oUsuario.PNCNVUSR = HelpClass.ToStringCvr(dr("CNVUSR"))
      oUsuario.PSSORGZN = HelpClass.ToStringCvr(dr("SORGZN"))
      oUsuario.OPCIONES = HelpClass.ToStringCvr(dr("OPCIONES"))
      oUsuario.CLIENTES = HelpClass.ToStringCvr(dr("CLIENTES"))
      oUsuario.PLANTAS = HelpClass.ToStringCvr(dr("PLANTAS"))
      oUsuario.PSSESTRG = HelpClass.ToStringCvr(dr("SESTRG"))
      oUsuario.SESTRG_DESC = HelpClass.ToStringCvr(dr("SESTRG_DESC"))
      listUsuario.Add(oUsuario)
    Next
    Return listUsuario
  End Function


  Public Function Reporte_Usuarios(ByVal obeUsuario As beUsuario) As DataTable
    Dim dt As New DataTable
    Dim oHashtable As New Hashtable
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    Dim listUsuario As New List(Of beUsuario)
    lobjParams.Add("PSMMCUSR", obeUsuario.PSMMCUSR)
    lobjParams.Add("PSMMNUSR", obeUsuario.PSMMNUSR)
    lobjParams.Add("PSSESTRG", obeUsuario.PSSESTRG)

    dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SD_LISTA_USUARIOS_RPT", lobjParams)
    Return dt
  End Function


  'Public Function Listar_Usuarios_X_AccesoOpcion(ByVal obeUsuario As beUsuario) As List(Of beAccesoOpcion)
  '  Dim dt As New DataTable
  '  Dim lobjSql As New SqlManager
  '  Dim lobjParams As New Parameter

  '  Dim lstbeAccesoOpcion As New List(Of beAccesoOpcion)
  '  Dim obeAccesoOpcion As beAccesoOpcion

  '  lobjParams.Add("PSMMCUSR", obeUsuario.PSMMCUSR)
  '  lobjParams.Add("PSMMCAPL", obeUsuario.PSMMCAPL_CodApl)
  '  lobjParams.Add("PSMMCMNU", obeUsuario.PSMMCMNU_CodMnu)
  '  dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SD_LISTA_USUARIOS_X_ACCESO_OPCION", lobjParams)

  '  For Each dr As DataRow In dt.Rows
  '    obeAccesoOpcion = New beAccesoOpcion

  '  Next
  '  Return lstbeAccesoOpcion
  'End Function

  Public Function Listar_Usuarios_X_AccesoOpcion(ByVal obeUsuario As beUsuario, ByRef NumPaginas As Int64) As DataTable
    Dim dt As New DataTable
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    Dim lstbeAccesoOpcion As New List(Of beAccesoOpcion)
    'Dim obeAccesoOpcion As beAccesoOpcion
    lobjParams.Add("PSMMCUSR", obeUsuario.PSMMCUSR)
    lobjParams.Add("PSMMCAPL", obeUsuario.PSMMCAPL_CodApl)
    lobjParams.Add("PSMMCMNU", obeUsuario.PSMMCMNU_CodMnu)

    lobjParams.Add("PAGESIZE", obeUsuario.PageSize)
    lobjParams.Add("PAGENUMBER", obeUsuario.PageNumber)
    lobjParams.Add("PAGECOUNT", 0, ParameterDirection.Output)

    dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SD_LISTA_USUARIOS_X_ACCESO_OPCION_PAGINACION", lobjParams)
    NumPaginas = lobjSql.ParameterCollection("PAGECOUNT")
    Return dt
  End Function



  Public Function Listar_Perfil_AccesoOpcion(ByVal obeAccesoOpcion As beAccesoOpcion) As DataTable
    Dim dt As New DataTable
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter

    lobjParams.Add("PSMMCUSR", obeAccesoOpcion.PSMMCUSR)
    lobjParams.Add("PSMMCAPL", obeAccesoOpcion.PSMMCAPL)
    lobjParams.Add("PSMMCMNU", obeAccesoOpcion.PSMMCMNU)
    dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SD_LISTA_ACCESO_OPCION_PERFIL", lobjParams)
    Return dt
  End Function

  Public Function Listar_Perfil_AccesoPlanta(ByVal obeAccesoPlanta As beAccesoPlanta) As DataTable
    Dim dt As New DataTable
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter

    lobjParams.Add("PSMMCUSR", obeAccesoPlanta.PSMMCUSR)
    lobjParams.Add("PSCCMPN", obeAccesoPlanta.PSCCMPN)
    lobjParams.Add("PSCDVSN", obeAccesoPlanta.PSCDVSN)
    lobjParams.Add("PNCPLNDV", obeAccesoPlanta.PNCPLNDV)

    dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SD_LISTA_ACCESO_PLANTA_PERFIL", lobjParams)
    Return dt
  End Function

  Public Function Listar_Perfil_AccesoCliente(ByVal obeAccesoCliente As beAccesoCliente) As DataTable
    Dim dt As New DataTable
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter

    lobjParams.Add("PSMMCUSR", obeAccesoCliente.PSMMCUSR)
    dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SD_LISTA_ACCESO_CLIENTE_PERFIL", lobjParams)
    Return dt
  End Function


  Public Function Listar_Usuarios_X_AccesoCliente(ByVal obeUsuario As beUsuario) As DataTable
    Dim dt As New DataTable
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    lobjParams.Add("PSMMCUSR", obeUsuario.PSMMCUSR)
    dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SD_LISTA_USUARIOS_X_ACCESO_CLIENTE", lobjParams)
    Return dt
  End Function

  Public Function Listar_Usuarios_X_AccesoPlanta(ByVal obeUsuario As beUsuario) As DataTable
    Dim dt As New DataTable
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    lobjParams.Add("PSMMCUSR", obeUsuario.PSMMCUSR)
    dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SD_LISTA_USUARIOS_X_ACCESO_PLANTA", lobjParams)
    Return dt
  End Function

  Public Function Registrar_Usuarios(ByVal obeUsuario As beUsuario)
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    lobjParams.Add("PSMMCUSR", obeUsuario.PSMMCUSR)
    lobjParams.Add("PSMMNUSR", obeUsuario.PSMMNUSR)

    lobjParams.Add("PSMMCAII", obeUsuario.PSMMCAII) ' codigo aplicacion inicial
    lobjParams.Add("PSMMCMII", obeUsuario.PSMMCMII) ' codigo menu inicial
    lobjParams.Add("PSCOROCC", obeUsuario.PSCOROCC) ' codigo de operaciones cuenta corriente
    lobjParams.Add("PSCCMPOR", obeUsuario.PSCCMPOR) 'codigo compañia usuario
    lobjParams.Add("PSCDVSNU", obeUsuario.PSCDVSNU) 'codigo division usuario
    lobjParams.Add("PSMMTUSR", obeUsuario.PSMMTUSR) 'tipo de usuario (D/F)
    lobjParams.Add("PNCNVUSR", obeUsuario.PNCNVUSR) 'codigo de nivel de usuario
    lobjParams.Add("PSSORGZN", obeUsuario.PSSORGZN) 'flag de origen zona

    lobjParams.Add("PNFCHCRT", Format(Now, "yyyyMMdd")) 'fecha de creación
    lobjParams.Add("PNHRACRT", Format(Now, "HHmmss")) 'hora de creación
    lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName) 'usuario creador
    lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd")) 'fecha de actualización
    lobjParams.Add("PNHULTAC", Format(Now, "HHmmss")) 'hora de actualización
    lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName) 'usuario (actualización)
    lobjParams.Add("PSRESULT", 0, ParameterDirection.Output) 'variable result
    lobjSql.ExecuteNonQuery("SP_SOLMIN_SD_INSERT_USUARIOS", lobjParams)
    Return lobjSql.ParameterCollection("PSRESULT")
  End Function

  Public Function Modificar_Usuarios(ByVal obeUsuario As beUsuario)

    Dim resultado As Int32 = 0
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    lobjParams.Add("PSMMCUSR", obeUsuario.PSMMCUSR)
    lobjParams.Add("PSMMNUSR", obeUsuario.PSMMNUSR)

    lobjParams.Add("PSMMCAII", obeUsuario.PSMMCAII) ' codigo aplicacion inicial
    lobjParams.Add("PSMMCMII", obeUsuario.PSMMCMII) ' codigo menu inicial
    lobjParams.Add("PSCOROCC", obeUsuario.PSCOROCC) ' codigo de operaciones cuenta corriente
    lobjParams.Add("PSCCMPOR", obeUsuario.PSCCMPOR) 'codigo compañia usuario
    lobjParams.Add("PSCDVSNU", obeUsuario.PSCDVSNU) 'codigo division usuario
    lobjParams.Add("PSMMTUSR", obeUsuario.PSMMTUSR) 'tipo de usuario (D/F)
    lobjParams.Add("PNCNVUSR", obeUsuario.PNCNVUSR) 'codigo de nivel de usuario
    lobjParams.Add("PSSORGZN", obeUsuario.PSSORGZN) 'flag de origen zona

    lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd")) 'fecha de actualización
    lobjParams.Add("PNHULTAC", Format(Now, "HHmmss")) 'hora de actualización
    lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName) 'usuario (actualización)
    lobjSql.ExecuteNonQuery("SP_SOLMIN_SD_UPDATE_USUARIOS", lobjParams)
    resultado = 1
    Return resultado
  End Function

  Public Function Eliminar_Usuarios(ByVal obeUsuario As beUsuario)
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    lobjParams.Add("PSMMCUSR", obeUsuario.PSMMCUSR) 'codigo

    lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd")) 'fecha de actualización
    lobjParams.Add("PNHULTAC", Format(Now, "HHmmss")) 'hora de actualización
    lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName) 'usuario (actualización)
    lobjParams.Add("PSRESULT", 0, ParameterDirection.Output) 'variable result
    lobjSql.ExecuteNonQuery("SP_SOLMIN_SD_DELETE_USUARIOS", lobjParams)
    Return lobjSql.ParameterCollection("PSRESULT")
  End Function

  Public Function Restaurar_Usuarios(ByVal obeUsuario As beUsuario)
    Dim resultado As Int32 = 0
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    lobjParams.Add("PSMMCUSR", obeUsuario.PSMMCUSR) 'codigo

    lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd")) 'fecha de actualización
    lobjParams.Add("PNHULTAC", Format(Now, "HHmmss")) 'hora de actualización
    lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName) 'usuario (actualización)
    lobjParams.Add("PSRESULT", 0, ParameterDirection.Output) 'variable result
    lobjSql.ExecuteNonQuery("SP_SOLMIN_SD_RESTABLECER_USUARIOS", lobjParams)
    Return lobjSql.ParameterCollection("PSRESULT")
  End Function

  Public Function Registrar_Opciones_X_Usuario(ByVal obeAccesoOpcion As beAccesoOpcion)
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    lobjParams.Add("PSMMCAPL", obeAccesoOpcion.PSMMCAPL)
    lobjParams.Add("PSMMCMNU", obeAccesoOpcion.PSMMCMNU)
    lobjParams.Add("PSMMCOPC", obeAccesoOpcion.PNMMCOPC)
    lobjParams.Add("PSMMCUSR", obeAccesoOpcion.PSMMCUSR)

    lobjParams.Add("PSSTSVIS", obeAccesoOpcion.PSSTSVIS)
    lobjParams.Add("PSSTSADI", obeAccesoOpcion.PSSTSADI)
    lobjParams.Add("PSSTSCHG", obeAccesoOpcion.PSSTSCHG)
    lobjParams.Add("PSSTSELI", obeAccesoOpcion.PSSTSELI)

    lobjParams.Add("PSSTSOP1", obeAccesoOpcion.PSSTSOP1)
    lobjParams.Add("PSSTSOP2", obeAccesoOpcion.PSSTSOP2)
    lobjParams.Add("PSSTSOP3", obeAccesoOpcion.PSSTSOP3)

    lobjParams.Add("PNFCHCRT", Format(Now, "yyyyMMdd")) 'fecha de creación
    lobjParams.Add("PNHRACRT", Format(Now, "HHmmss")) 'hora de creación
    lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName) 'usuario creador
    lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd")) 'fecha de actualización
    lobjParams.Add("PNHULTAC", Format(Now, "HHmmss")) 'hora de actualización
    lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName) 'usuario (actualización)
    lobjParams.Add("PSRESULT", 0, ParameterDirection.Output) 'variable result
    lobjSql.ExecuteNonQuery("SP_SOLMIN_SD_INSERT_OPCIONES_X_USUARIO", lobjParams)
    Return lobjSql.ParameterCollection("PSRESULT")
  End Function

  Public Function Registrar_Perfil_Opciones(ByVal obeAccesoOpcion As beAccesoOpcion)
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter

    lobjParams.Add("PSMMCAPL", obeAccesoOpcion.PSMMCAPL)
    lobjParams.Add("PSMMCMNU", obeAccesoOpcion.PSMMCMNU)
    lobjParams.Add("PSMMCOPC", obeAccesoOpcion.PNMMCOPC)
    lobjParams.Add("PSMMCUSR", obeAccesoOpcion.PSMMCUSR)

    lobjParams.Add("PSSTSVIS", obeAccesoOpcion.PSSTSVIS)
    lobjParams.Add("PSSTSADI", obeAccesoOpcion.PSSTSADI)
    lobjParams.Add("PSSTSCHG", obeAccesoOpcion.PSSTSCHG)
    lobjParams.Add("PSSTSELI", obeAccesoOpcion.PSSTSELI)

    lobjParams.Add("PSSTSOP1", obeAccesoOpcion.PSSTSOP1)
    lobjParams.Add("PSSTSOP2", obeAccesoOpcion.PSSTSOP2)
    lobjParams.Add("PSSTSOP3", obeAccesoOpcion.PSSTSOP3)

    lobjParams.Add("PNFCHCRT", Format(Now, "yyyyMMdd")) 'fecha de creación
    lobjParams.Add("PNHRACRT", Format(Now, "HHmmss")) 'hora de creación
    lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName) 'usuario creador
    lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd")) 'fecha de actualización
    lobjParams.Add("PNHULTAC", Format(Now, "HHmmss")) 'hora de actualización
    lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName) 'usuario (actualización)
    lobjParams.Add("PSRESULT", 0, ParameterDirection.Output) 'variable result
    lobjSql.ExecuteNonQuery("SP_SOLMIN_SD_INSERT_PERFIL_OPCIONES", lobjParams)
    Return lobjSql.ParameterCollection("PSRESULT")

  End Function

  Public Function Registrar_Perfil_Plantas(ByVal obeAccesoPlanta As beAccesoPlanta)
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter

    lobjParams.Add("PSMMCUSR", obeAccesoPlanta.PSMMCUSR)
    lobjParams.Add("PSCCMPN", obeAccesoPlanta.PSCCMPN)
    lobjParams.Add("PSCDVSN", obeAccesoPlanta.PSCDVSN)
    lobjParams.Add("PNCPLNDV", obeAccesoPlanta.PNCPLNDV)

    lobjParams.Add("PSMMCAPL", obeAccesoPlanta.PSMMCAPL)
    lobjParams.Add("PSCRGVTA", obeAccesoPlanta.PSCRGVTA)
    lobjParams.Add("PSCSCDSP", obeAccesoPlanta.PSCSCDSP)

    lobjParams.Add("PNFCHCRT", Format(Now, "yyyyMMdd")) 'fecha de creación
    lobjParams.Add("PNHRACRT", Format(Now, "HHmmss")) 'hora de creación
    lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName) 'usuario creador
    lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd")) 'fecha de actualización
    lobjParams.Add("PNHULTAC", Format(Now, "HHmmss")) 'hora de actualización
    lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName) 'usuario (actualización)
    lobjParams.Add("PSRESULT", 0, ParameterDirection.Output) 'variable result
    lobjSql.ExecuteNonQuery("SP_SOLMIN_SD_INSERT_PERFIL_PLANTA", lobjParams)

    Return lobjSql.ParameterCollection("PSRESULT")

  End Function


  Public Function Modificar_Opciones_X_Usuario(ByVal obeAccesoOpcion As beAccesoOpcion)
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    lobjParams.Add("PSMMCAPL", obeAccesoOpcion.PSMMCAPL)
    lobjParams.Add("PSMMCMNU", obeAccesoOpcion.PSMMCMNU)
    lobjParams.Add("PSMMCOPC", obeAccesoOpcion.PNMMCOPC)
    lobjParams.Add("PSMMCUSR", obeAccesoOpcion.PSMMCUSR)

    lobjParams.Add("PSSTSVIS", obeAccesoOpcion.PSSTSVIS)
    lobjParams.Add("PSSTSADI", obeAccesoOpcion.PSSTSADI)
    lobjParams.Add("PSSTSCHG", obeAccesoOpcion.PSSTSCHG)
    lobjParams.Add("PSSTSELI", obeAccesoOpcion.PSSTSELI)

    lobjParams.Add("PSSTSOP1", obeAccesoOpcion.PSSTSOP1)
    lobjParams.Add("PSSTSOP2", obeAccesoOpcion.PSSTSOP2)
    lobjParams.Add("PSSTSOP3", obeAccesoOpcion.PSSTSOP3)

    lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd")) 'fecha de actualización
    lobjParams.Add("PNHULTAC", Format(Now, "HHmmss")) 'hora de actualización
    lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName) 'usuario (actualización)
    lobjParams.Add("PSRESULT", 0, ParameterDirection.Output) 'variable result
    lobjSql.ExecuteNonQuery("SP_SOLMIN_SD_UPDATE_OPCIONES_X_USUARIO", lobjParams)
    Return lobjSql.ParameterCollection("PSRESULT")
  End Function

  Public Function Eliminar_Opciones_X_Usuario(ByVal obeAccesoOpcion As beAccesoOpcion)
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter

    lobjParams.Add("PSMMCUSR", obeAccesoOpcion.PSMMCUSR)
    lobjParams.Add("PSMMCAPL", obeAccesoOpcion.PSMMCAPL)
    lobjParams.Add("PSMMCMNU", obeAccesoOpcion.PSMMCMNU)
    lobjParams.Add("PNMMCOPC", obeAccesoOpcion.PNMMCOPC)

    lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd")) 'fecha de actualización
    lobjParams.Add("PNHULTAC", Format(Now, "HHmmss")) 'hora de actualización
    lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName) 'usuario (actualización)
    lobjParams.Add("PSRESULT", 0, ParameterDirection.Output) 'variable result
    lobjSql.ExecuteNonQuery("SP_SOLMIN_SD_DELETE_OPCIONES_X_USUARIO", lobjParams)
    Return lobjSql.ParameterCollection("PSRESULT")
  End Function

  Public Function Registrar_Opciones_X_Cliente(ByVal obeAccesoCliente As beAccesoCliente)
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    Dim resultado As Int32 = 0
    lobjParams.Add("PSMMCUSR", obeAccesoCliente.PSMMCUSR)
    lobjParams.Add("PSNCCLNT", obeAccesoCliente.PNCCLNT)
    lobjParams.Add("PSCPLNDV", obeAccesoCliente.PNCPLNDV)
    lobjParams.Add("PSTCMPCL", obeAccesoCliente.PSTCMPCL)
    lobjParams.Add("PSCINTER", obeAccesoCliente.PSCINTER)

    lobjParams.Add("PNFCHCRT", Format(Now, "yyyyMMdd")) 'fecha de creación
    lobjParams.Add("PNHRACRT", Format(Now, "HHmmss")) 'hora de creación
    lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName) 'usuario creador
    lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd")) 'fecha de actualización
    lobjParams.Add("PNHULTAC", Format(Now, "HHmmss")) 'hora de actualización
    lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName) 'usuario (actualización)
    lobjParams.Add("PSRESULT", 0, ParameterDirection.Output) 'variable result

    lobjSql.ExecuteNonQuery("SP_SOLMIN_SD_INSERT_USUARIO_X_CLIENTE", lobjParams)
    Return lobjSql.ParameterCollection("PSRESULT")
  End Function


  Public Function Registrar_Perfil_Clientes(ByVal obeAccesoCliente As beAccesoCliente)
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    Dim resultado As Int32 = 0
    lobjParams.Add("PSMMCUSR", obeAccesoCliente.PSMMCUSR)
    lobjParams.Add("PSNCCLNT", obeAccesoCliente.PNCCLNT)
    lobjParams.Add("PSCPLNDV", obeAccesoCliente.PNCPLNDV)
    lobjParams.Add("PSTCMPCL", obeAccesoCliente.PSTCMPCL)
    lobjParams.Add("PSCINTER", obeAccesoCliente.PSCINTER)

    lobjParams.Add("PNFCHCRT", Format(Now, "yyyyMMdd")) 'fecha de creación
    lobjParams.Add("PNHRACRT", Format(Now, "HHmmss")) 'hora de creación
    lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName) 'usuario creador
    lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd")) 'fecha de actualización
    lobjParams.Add("PNHULTAC", Format(Now, "HHmmss")) 'hora de actualización
    lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName) 'usuario (actualización)
    lobjParams.Add("PSRESULT", 0, ParameterDirection.Output) 'variable result

    lobjSql.ExecuteNonQuery("SP_SOLMIN_SD_INSERT_PERFIL_CLIENTE", lobjParams)
    Return lobjSql.ParameterCollection("PSRESULT")
  End Function


  Public Function Modificar_Opciones_X_Cliente(ByVal obeAccesoCliente As beAccesoCliente)
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    Dim resultado As Int32 = 0
    lobjParams.Add("PSMMCUSR", obeAccesoCliente.PSMMCUSR)
    lobjParams.Add("PSNCCLNT", obeAccesoCliente.PNCCLNT)
    lobjParams.Add("PSCPLNDV", obeAccesoCliente.PNCPLNDV)
    lobjParams.Add("PSTCMPCL", obeAccesoCliente.PSTCMPCL)
    lobjParams.Add("PSCINTER", obeAccesoCliente.PSCINTER)

    lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd")) 'fecha de actualización
    lobjParams.Add("PNHULTAC", Format(Now, "HHmmss")) 'hora de actualización
    lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName) 'usuario (actualización)
    lobjParams.Add("PSRESULT", 0, ParameterDirection.Output) 'variable result

    lobjSql.ExecuteNonQuery("SP_SOLMIN_SD_UPDATE_USUARIO_X_CLIENTE", lobjParams)
    Return lobjSql.ParameterCollection("PSRESULT")

  End Function


  Public Function Eliminar_Opciones_X_Cliente(ByVal obeAccesoCliente As beAccesoCliente)
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter

    lobjParams.Add("PSMMCAPL", obeAccesoCliente.PSMMCUSR)
    lobjParams.Add("PNCCLNT", obeAccesoCliente.PNCCLNT)

    lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd")) 'fecha de actualización
    lobjParams.Add("PNHULTAC", Format(Now, "HHmmss")) 'hora de actualización
    lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName) 'usuario (actualización)

    lobjParams.Add("PSRESULT", 0, ParameterDirection.Output) 'variable result
    lobjSql.ExecuteNonQuery("SP_SOLMIN_SD_DELETE_USUARIO_X_CLIENTE", lobjParams)
    Return lobjSql.ParameterCollection("PSRESULT")
  End Function

  Public Function Registrar_Opciones_X_Planta(ByVal obeAccesoPlanta As beAccesoPlanta)
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter

    lobjParams.Add("PSMMCUSR", obeAccesoPlanta.PSMMCUSR)
    lobjParams.Add("PSCCMPN", obeAccesoPlanta.PSCCMPN)
    lobjParams.Add("PSCDVSN", obeAccesoPlanta.PSCDVSN)
    lobjParams.Add("PNCPLNDV", obeAccesoPlanta.PNCPLNDV)
    lobjParams.Add("PSMMCAPL", obeAccesoPlanta.PSMMCAPL)
    lobjParams.Add("PSCRGVTA", obeAccesoPlanta.PSCRGVTA)
    lobjParams.Add("PSCSCDSP", obeAccesoPlanta.PSCSCDSP)

    lobjParams.Add("PNFCHCRT", Format(Now, "yyyyMMdd")) 'fecha de creación
    lobjParams.Add("PNHRACRT", Format(Now, "HHmmss")) 'hora de creación
    lobjParams.Add("PSCUSCRT", ConfigurationWizard.UserName) 'usuario creador
    lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd")) 'fecha de actualización
    lobjParams.Add("PNHULTAC", Format(Now, "HHmmss")) 'hora de actualización
    lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName) 'usuario (actualización)
    lobjParams.Add("PSRESULT", 0, ParameterDirection.Output) 'variable result
    lobjSql.ExecuteNonQuery("SP_SOLMIN_SD_INSERT_USUARIO_X_PLANTA", lobjParams)
    Return lobjSql.ParameterCollection("PSRESULT")

  End Function

  Public Function Modificar_Opciones_X_Planta(ByVal obeAccesoPlanta As beAccesoPlanta)
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter

    lobjParams.Add("PSMMCUSR", obeAccesoPlanta.PSMMCUSR)
    lobjParams.Add("PSCCMPN", obeAccesoPlanta.PSCCMPN)
    lobjParams.Add("PSCDVSN", obeAccesoPlanta.PSCDVSN)
    lobjParams.Add("PNCPLNDV", obeAccesoPlanta.PNCPLNDV)
    lobjParams.Add("PSMMCAPL", obeAccesoPlanta.PSMMCAPL)
    lobjParams.Add("PSCRGVTA", obeAccesoPlanta.PSCRGVTA)
    lobjParams.Add("PSCSCDSP", obeAccesoPlanta.PSCSCDSP)

    lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd")) 'fecha de actualización
    lobjParams.Add("PNHULTAC", Format(Now, "HHmmss")) 'hora de actualización
    lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName) 'usuario (actualización)
    lobjParams.Add("PSRESULT", 0, ParameterDirection.Output) 'variable result

    lobjSql.ExecuteNonQuery("SP_SOLMIN_SD_UPDATE_USUARIO_X_PLANTA", lobjParams)
    Return lobjSql.ParameterCollection("PSRESULT")

  End Function

  Public Function Eliminar_Opciones_X_Planta(ByVal obeAccesoPlanta As beAccesoPlanta)
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter

    lobjParams.Add("PSMMCUSR", obeAccesoPlanta.PSMMCUSR)
    lobjParams.Add("PSCCMPN", obeAccesoPlanta.PSCCMPN)
    lobjParams.Add("PSCDVSN", obeAccesoPlanta.PSCDVSN)
    lobjParams.Add("PSCPLNDV", obeAccesoPlanta.PNCPLNDV)

    lobjParams.Add("PNFULTAC", Format(Now, "yyyyMMdd")) 'fecha de actualización
    lobjParams.Add("PNHULTAC", Format(Now, "HHmmss")) 'hora de actualización
    lobjParams.Add("PSCULUSA", ConfigurationWizard.UserName) 'usuario (actualización)

    lobjParams.Add("PSRESULT", 0, ParameterDirection.Output) 'variable result
    lobjSql.ExecuteNonQuery("SP_SOLMIN_SD_DELETE_USUARIO_X_PLANTA", lobjParams)
    Return lobjSql.ParameterCollection("PSRESULT")
  End Function

  Public Function Listar_Compania() As List(Of beCompania)
    Dim dt As New DataTable
    Dim listCompania As New List(Of beCompania)
    Dim obeCompania As beCompania
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SD_LISTAR_COMPANIA", lobjParams)
    For Each dr As DataRow In dt.Rows
      obeCompania = New beCompania
      obeCompania.PSCODIGO = HelpClass.ToStringCvr(dr("CCMPN"))
      obeCompania.PSDESCRIPCION = HelpClass.ToStringCvr(dr("TCMPCM"))
      listCompania.Add(obeCompania)
    Next
    Return listCompania
  End Function


  Public Function Listar_Division_X_Compania(ByVal obeDivision As beDivision) As List(Of beDivision)
    Dim dt As New DataTable
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    Dim listDisvision As New List(Of beDivision)
    Dim objDivision As beDivision
    lobjParams.Add("PSCCMPN", obeDivision.PSCODCIA)
    dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SD_LISTAR_DIVISION_X_COMPANIA", lobjParams)
    For Each dr As DataRow In dt.Rows
      objDivision = New beDivision
      objDivision.PSCODCIA = HelpClass.ToStringCvr(dr("CCMPN"))
      objDivision.PSCODIGO = HelpClass.ToStringCvr(dr("CDVSN"))
      objDivision.PSDESCRIPCION = HelpClass.ToStringCvr(dr("TCMPDV"))
      listDisvision.Add(objDivision)
    Next
    Return listDisvision
  End Function

  Public Function Listar_Planta_X_Compania_Division(ByVal obePlanta As bePlanta) As List(Of bePlanta)
    Dim dt As New DataTable
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    Dim listPlanta As New List(Of bePlanta)
    Dim objPlanta As bePlanta
    lobjParams.Add("PSCCMPN", obePlanta.PSCODCIA)
    lobjParams.Add("PSCDVSN", obePlanta.PSCODDIV)
    dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SD_LISTAR_PLANTA_X_COMPANIA_DIVISION", lobjParams)
    For Each dr As DataRow In dt.Rows
      objPlanta = New bePlanta
      objPlanta.PSCODCIA = HelpClass.ToStringCvr(dr("CCMPN"))
      objPlanta.PSCODDIV = HelpClass.ToStringCvr(dr("CDVSN"))
      objPlanta.PNCODIGO = HelpClass.ToDecimalCvr(dr("CPLNDV"))
      objPlanta.PSDESCRIPCION = HelpClass.ToStringCvr(dr("TPLNTA"))
      listPlanta.Add(objPlanta)
    Next
    Return listPlanta
  End Function


  Public Function SP_SOLMIN_SD_LISTAR_CBO_PLANTAS_X_USUARIO_CLIENTE(ByVal obePlanta As bePlanta) As List(Of bePlanta)
    Dim dt As New DataTable
    Dim lobjSql As New SqlManager
    Dim lobjParams As New Parameter
    Dim listPlanta As New List(Of bePlanta)
    Dim oPlanta As bePlanta
    lobjParams.Add("PSMMCUSR", obePlanta.PSMMCUSR)
    dt = lobjSql.ExecuteDataTable("SP_SOLMIN_SD_LISTAR_CBO_PLANTAS_X_USUARIO_CLIENTE", lobjParams)

    For Each dr As DataRow In dt.Rows
      oPlanta = New bePlanta
      oPlanta.PNCODIGO = HelpClass.ToDecimalCvr(dr("CPLNDV"))
      oPlanta.PSDESCRIPCION = HelpClass.ToStringCvr(dr("TPLNTA"))
      listPlanta.Add(oPlanta)
    Next
    Return listPlanta
  End Function

End Class
