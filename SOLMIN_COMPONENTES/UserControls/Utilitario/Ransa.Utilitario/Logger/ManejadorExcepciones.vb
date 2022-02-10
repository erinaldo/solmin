'<[AHM]>
Public Class ManejadorExcepciones
    Public Function PublicarExcepcion(ByVal exception As Exception, ByVal guid As Guid) As Boolean
        Return (New Logger).RegistrarEvento(String.Format("Codigo:{0}{1}{2}{3}StackTrace: {4}{5}InnerException: {6}", _
                                                    guid, _
                                                    Environment.NewLine, _
                                                    exception.Message, _
                                                    Environment.NewLine, _
                                                    exception.StackTrace, _
                                                    Environment.NewLine, _
                                                    exception.InnerException))
    End Function
End Class
'</[AHM]>