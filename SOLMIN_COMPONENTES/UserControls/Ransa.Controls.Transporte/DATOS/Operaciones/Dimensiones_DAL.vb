Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.Utilitario

Public Class Dimensiones_DAL

    Private objSql As New SqlManager

    Function fListar_Dimensiones(ByVal Obj As Dimensiones) As List(Of Dimensiones)

        Dim Lista As New List(Of Dimensiones)
        Dim dt As New DataTable
        Dim objParam As New Parameter
        Dim Entidad As Dimensiones

        objParam.Add("PSCCMPN", Obj.CCMPN)
        objParam.Add("PSNUMREQT", Obj.NUMREQT)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(Obj.CCMPN)
        dt = objSql.ExecuteDataTable("SP_SOLMIN_ST_DIMENSIONES_LIST", objParam)

        For Each fila As DataRow In dt.Rows
            Entidad = New Dimensiones

            Entidad.CCMPN = fila("CCMPN")
            Entidad.NUMREQT = fila("NUMREQT")
            Entidad.NCRREQT = fila("NCRREQT")
            Entidad.TDITES = fila("TDITES").ToString.Trim
            Entidad.QMTALT = Val(fila("QMTALT"))
            Entidad.QMTANC = Val(fila("QMTANC"))
            Entidad.QMTLRG = Val(fila("QMTLRG"))
            Entidad.QPESO = Val(fila("QPESO"))
            Lista.Add(Entidad)

        Next
        Return Lista

    End Function



    Public Sub Insertar_Dimensiones(ByVal obeDimensiones As Dimensiones)

        Dim objParam As New Parameter

        objParam.Add("PSCCMPN", obeDimensiones.CCMPN)
        objParam.Add("PNNUMREQT", obeDimensiones.NUMREQT)

        objParam.Add("PSTDITES", obeDimensiones.TDITES)

        objParam.Add("PNQMTLRG", obeDimensiones.QMTLRG)
        objParam.Add("PNQMTALT", obeDimensiones.QMTALT)
        objParam.Add("PNQMTANC", obeDimensiones.QMTANC)
        objParam.Add("PNQPESO", obeDimensiones.QPESO)
        objParam.Add("PSUSUARIO", obeDimensiones.CUSCRT)
        objParam.Add("PSNTRMNL", obeDimensiones.NTRMCR)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obeDimensiones.CCMPN)

        objSql.ExecuteNonQuery("SP_SOLMIN_ST_DIMENSIONES_INSERT", objParam)

    End Sub


    Public Sub Modificar_Dimensiones(ByVal obeDimensiones As Dimensiones)

        Dim objParam As New Parameter

        objParam.Add("PSCCMPN", obeDimensiones.CCMPN)
        objParam.Add("PNNUMREQT", obeDimensiones.NUMREQT)
        objParam.Add("PNNCRREQT", obeDimensiones.NCRREQT)

        objParam.Add("PSTDITES", obeDimensiones.TDITES)

        objParam.Add("PNQMTLRG", obeDimensiones.QMTLRG)
        objParam.Add("PNQMTALT", obeDimensiones.QMTALT)
        objParam.Add("PNQMTANC", obeDimensiones.QMTANC)

        objParam.Add("PNQPESO", obeDimensiones.QPESO)
        objParam.Add("PSUSUARIO", obeDimensiones.CULUSA)
        objParam.Add("PSNTRMNL", obeDimensiones.NTRMNL)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obeDimensiones.CCMPN)

        objSql.ExecuteNonQuery("SP_SOLMIN_ST_DIMENSIONES_UPDATE", objParam)


    End Sub

    Public Sub Eliminar_Dimensiones(ByVal obeDimensiones As Dimensiones)

        Dim objParam As New Parameter

        objParam.Add("PSCCMPN", obeDimensiones.CCMPN)
        objParam.Add("PNNUMREQT", obeDimensiones.NUMREQT)
        objParam.Add("PNNCRREQT", obeDimensiones.NCRREQT)

        objParam.Add("PSUSUARIO", obeDimensiones.CULUSA)
        objParam.Add("PSNTRMNL", obeDimensiones.NTRMNL)

        objSql.DefaultSchema = Autenticacion_DAL.GetLibrary(obeDimensiones.CCMPN)

        objSql.ExecuteNonQuery("SP_SOLMIN_ST_DIMENSIONES_DELETE", objParam)


    End Sub


End Class