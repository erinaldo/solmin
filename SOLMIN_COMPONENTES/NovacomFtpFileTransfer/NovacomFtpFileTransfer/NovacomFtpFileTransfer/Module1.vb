Imports NovacomFtpFileTransfer.net.ransa.asp
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports System.Data

Module Module1

    Sub Main(ByVal args() As String)

        Console.WriteLine("Consumo de archivos de GPS Novacom - Ransa Version . " & My.Application.Info.Version.ToString)
 
            Dim objWS As New NovacomFtpFileTransfer.net.ransa.asp.WsSolminSil
            Console.WriteLine("Recupeando los archivos de Novacom")
            Dim lstr_result As String = objWS.ListaArchivosDirectorio("200.60.23.181", "ransa", "ransa", "")
            If lstr_result.Trim = "<data></data>" Then
                Console.WriteLine("No hay archivos para descargar")
                Exit Sub
            End If
            Dim dst As New DataSet
            Dim objxml As New Xml.XmlTextReader(New IO.StringReader(lstr_result))
            dst.ReadXml(objxml)
            Console.WriteLine("Cantidad de archivos por descargar " & dst.Tables(0).Rows.Count)

            For i As Integer = 0 To dst.Tables(0).Rows.Count - 1
                Console.WriteLine("Item " & i)
                Console.WriteLine("Downloading >" & dst.Tables(0).Rows(i).Item("FILENAME").ToString.Trim)
                Console.WriteLine(objWS.DescargaArchivoFtp("200.60.23.181", "ransa", "ransa", "", dst.Tables(0).Rows(i).Item("FILENAME").ToString.Trim))
            Next


        For Each objLocalFile As String In IO.Directory.GetFiles("\\rancalapl2\AplicacionesMineria\WSMineria\___x_temp_files\")
            Try
                Dim contenido As String = ""
                Dim lstr_lineas_archivo As New List(Of String)

                'Copiando el archivo en el disco local de la PC
                If IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\LocalGPSFiles") = False Then
                    IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\LocalGPSFiles")
                End If

                Dim objFileInfo As New IO.FileInfo(objLocalFile)
                IO.File.Copy(objLocalFile, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\LocalGPSFiles\" & objFileInfo.Name, True)

                Using obj As New IO.StreamReader(objLocalFile)
                    While obj.EndOfStream = False
                        lstr_lineas_archivo.Add(obj.ReadLine)
                    End While
                    obj.Close()
                    obj.Dispose()
                End Using

                If lstr_lineas_archivo.Count > 0 Then

                    For x_linea As Integer = 0 To lstr_lineas_archivo.Count - 1
                        contenido = lstr_lineas_archivo(x_linea)

                        Dim lstr_gps_position As String = ""
                        Dim lstr_placa_nave As String = ""
                        Dim objEntidad As New List(Of String)

                        '0 averiguando el nombre del archivo
                        objEntidad.Add(objLocalFile)

                        '1 averiguando el  fecha
                        objEntidad.Add(contenido.Substring(6, 4) & contenido.Substring(3, 2) & contenido.Substring(0, 2))
                        contenido = contenido.Substring(20)

                        'Caso : Placa de nave
                        lstr_placa_nave = getPlacaAs400(getStringPart(contenido).ToUpper())
                        objEntidad.Add(lstr_placa_nave.ToUpper())
                        objEntidad.Add(getStringPart(contenido).ToUpper())
                        contenido = nextSeparator(contenido)

                        '2 averiguando el nombre de la nave
                        objEntidad.Add(getStringPart(contenido).ToUpper)
                        contenido = nextSeparator(contenido)

                        '3 averiguando la zona
                        objEntidad.Add(getStringPart(contenido).ToUpper)
                        contenido = nextSeparator(contenido)

                        '4 averiguando la distancia
                        objEntidad.Add(getStringPart(contenido).Replace(",", "."))
                        contenido = nextSeparator(contenido)

                        '5 averiguando la posicion
                        lstr_gps_position = getStringPart(contenido).Replace("�", "|").Replace("°", "|").Replace("'", "!").Replace("""", "?")

                        objEntidad.Add(lstr_gps_position)
                        contenido = nextSeparator(contenido)

                        '6 averiguando la velocidad en nudos
                        objEntidad.Add(getStringPart(contenido))
                        contenido = nextSeparator(contenido)

                        '7 averiguando el rumbo
                        objEntidad.Add(getStringPart(contenido).Replace(",", "."))
                        contenido = nextSeparator(contenido)

                        '8 averiguando el evento
                        objEntidad.Add(getStringPart(contenido).ToUpper)
                        contenido = nextSeparator(contenido)

                        'Agregando las posiciones gps convertidas
                        objEntidad.Add(GpsCoordenatesConvert(lstr_gps_position, 0))
                        objEntidad.Add(GpsCoordenatesConvert(lstr_gps_position, 1))

                        Console.ForegroundColor = ConsoleColor.Green
                        Console.WriteLine("Procesando >" & objLocalFile)
                        LogFile(Today.ToShortDateString & " > Archivo " & objLocalFile & IIf(Registrar(objEntidad) = True, " ha sido cargado correctamente", " ha fallado en la carga"))

                    Next
                End If

                IO.File.Delete(objLocalFile)
                Console.WriteLine("Eliminando >" & objLocalFile)

            Catch ex As Exception
                LogFile(Today.ToShortDateString & " > Fallo la carga de Novacom - Ransa por " & ex.Message & " en " & objLocalFile)
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Error por " & ex.Message & " en " & objLocalFile)
            End Try

        Next

    End Sub

    Private Function getPlacaAs400(ByVal PlacaSource As String) As String
        Dim lstr_resultado As String = ""
        Dim dst As New DataSet
        dst.ReadXml(New IO.StreamReader("Motonaves.xml"))

        For i As Integer = 0 To dst.Tables(0).Rows.Count - 1
            If dst.Tables(0).Rows(i).Item("PLACA").ToString().CompareTo(PlacaSource) = True Then
                lstr_resultado = dst.Tables(0).Rows(i).Item("AS400").ToString()
            End If
        Next
        Return lstr_resultado
    End Function
    'function para convertir grados,inuts,segundos a decimal
    Private Function GpsCoordenatesConvert(ByVal lstr_coodenates As String, ByVal tipo As Integer) As String
        Dim lstr_degrees As String
 
        Dim tope As Integer
        If tipo = 0 Then 'longitud
            tope = lstr_coodenates.IndexOf("S")
        Else
            lstr_coodenates = lstr_coodenates.Substring(lstr_coodenates.IndexOf(" ") + 1)
            tope = lstr_coodenates.IndexOf("W")
        End If

        Dim grados As String = lstr_coodenates.Substring(0, lstr_coodenates.IndexOf("|"))
        Dim minutos As String = lstr_coodenates.Substring(lstr_coodenates.IndexOf("|") + 1, Math.Abs(lstr_coodenates.IndexOf("|") - lstr_coodenates.IndexOf("!")) - 1)
        Dim segundos As String = lstr_coodenates.Substring(lstr_coodenates.IndexOf("!") + 1, Math.Abs(lstr_coodenates.IndexOf("!") - lstr_coodenates.IndexOf("?")) - 1)

        lstr_degrees = "-" & CDbl(grados) + (CDbl(minutos) / 60) + (CDbl(segundos) / 3600)

        Return lstr_degrees
    End Function

    Private Function getStringPart(ByVal cadena As String) As String
 

        Dim final As Integer = cadena.IndexOf("/")
        Dim resultado As String = ""

        If final = -1 Then
            final = cadena.Length
        End If

        For i As Integer = 0 To final - 1
            resultado = resultado & cadena.Substring(i, 1)
        Next

        Return resultado
    End Function
 
    Private Function nextSeparator(ByVal cadena As String) As String

        Dim final As Integer = cadena.IndexOf("/") + 1
        Return cadena.Substring(final)
    End Function

    Private Function Registrar(ByVal objEntidad As List(Of String)) As Boolean
        Dim l_result As Boolean = False
        Try

            'REGISTRANDO EN RZTR11B

            Dim objSql As New SqlManager
            Dim objParam As New Parameter
            Dim objParam2 As New Parameter
            objParam.Add("PARAM_NARFTP", objEntidad(0))
            objParam.Add("PARAM_FECREG", objEntidad(1))
            objParam.Add("PARAM_NPLCTR", objEntidad(2))
            objParam.Add("PARAM_NPLREF", objEntidad(3))
            objParam.Add("PARAM_TMRCTR", objEntidad(4))
            objParam.Add("PARAM_DESZON", objEntidad(5))
            objParam.Add("PARAM_DISNAV", objEntidad(6))
            objParam.Add("PARAM_POSGPS", objEntidad(7))
            objParam.Add("PARAM_NVENUD", objEntidad(8))
            objParam.Add("PARAM_DRUNAV", objEntidad(9))
            objParam.Add("PARAM_NOMEVT", objEntidad(10))

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_GUARDAR_GPS_MOTONAVES", objParam)

            'REGISTRANDO EN RZTR11A
            objParam2.Add("PARAM_NPLCTR", objEntidad(2))
            objParam2.Add("PARAM_GPSLAT", objEntidad(11))
            objParam2.Add("PARAM_GPSLON", objEntidad(12))
            objParam2.Add("PARAM_CUSCRT", "RANCALAPL2")
            objParam2.Add("PARAM_FECHA", objEntidad(1))
            objParam2.Add("PARAM_HORA", NowNumeric)

            objSql.ExecuteNonQuery("SP_SOLMIN_ST_GUARDAR_SEGUIMIENTO_MOTONAVE", objParam2)

            l_result = True
        Catch ex As Exception
            l_result = False
        End Try
        Return l_result
    End Function


    Public Function TodayNumeric() As String
        Return Today.Year & "" & IIf(Today.Month < 10, "0" & Today.Month, Today.Month) & "" & IIf(Today.Day < 10, "0" & Today.Day, Today.Day)
    End Function

    Public Function NowNumeric() As String
        Return IIf(Now.Hour < 10, "0" & Now.Hour, Now.Hour) & "" & IIf(Now.Minute < 10, "0" & Now.Minute, Now.Minute) & "" & IIf(Now.Second < 10, "0" & Now.Second, Now.Second)
    End Function

    Public Sub LogFile(ByVal Contenido As String)

        Using objFile As New IO.StreamWriter(My.Application.Info.DirectoryPath & "\logfile.txt", True)
            objFile.WriteLine(Contenido)
            objFile.Flush()
            objFile.Close()
            objFile.Dispose()
        End Using

    End Sub
     

End Module
