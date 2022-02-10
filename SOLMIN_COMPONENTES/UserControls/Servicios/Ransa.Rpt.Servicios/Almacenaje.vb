Imports CrystalDecisions.CrystalReports.Engine
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.TypeDef.Servicios.Almacenaje

Namespace Almacenaje
    Public Class rAlmacenaje
        Implements IDisposable
#Region " Atributos "
        '-------------------------------------------------
        ' Manejador de la Conexion
        '-------------------------------------------------
        Private oSqlManager As SqlManager
        '-------------------------------------------------
        ' Almacenamiento de Información
        '-------------------------------------------------
        Private sErrorMessage As String = ""
        '-------------------------------------------------
        ' Información del Estado
        '-------------------------------------------------
        Private disposedValue As Boolean = False        ' Para detectar llamadas redundantes
        '-------------------------------------------------
        ' Datos de Seguridad 
        '-------------------------------------------------
#End Region
#Region " Propiedades "
        Public ReadOnly Property ErrorMessage() As String
            Get
                Return sErrorMessage
            End Get
        End Property
#End Region
#Region " Funciones y Procedimientos "

#End Region
#Region " Métodos "
        Sub New()
            oSqlManager = New SqlManager
        End Sub

        ''' <summary>
        ''' Reporte de Cálculo del Almacenaje en Ransa - Negocio Mineria
        ''' </summary>
        Public Function rCalculoAlmacenaje(ByVal oPkey_Almacenaje As TD_Pkey_Almacenaje, ByVal pUsuario As String) As ReportDocument
            Dim objParametros As Parameter = New Parameter
            Dim dstTemp As DataSet
            Dim rptTemp As ReportDocument = Nothing
            sErrorMessage = ""
            ' Ingresamos los parametros del Procedure
            With objParametros
                .Add("IN_CCLNT", oPkey_Almacenaje.pCCLNT_CodigoCliente)
                .Add("IN_NPRALM", oPkey_Almacenaje.pNPRALM_NroOperacion)
            End With
            Try
                dstTemp = oSqlManager.ExecuteDataSet("SP_SOLMIN_SA_ALMACENAJE_RZSC32_R01", objParametros)
                If dstTemp.Tables.Count > 0 Then
                    dstTemp.Tables(0).TableName = "rCalculoAlmacenajeCab"
                    dstTemp.Tables(1).TableName = "rCalculoAlmacenajeDet"
                    rptTemp = New urAlmacenaje_F01
                    rptTemp.SetDataSource(dstTemp)
                    rptTemp.Refresh()
                    rptTemp.SetParameterValue("pUsuario", pUsuario)
                End If
            Catch ex As Exception
                rptTemp = New ReportDocument
                sErrorMessage = "Error producido en la funcion : << rCalculoAlmacenaje >> de la clase << rAlmacenaje >> " & vbNewLine & _
                                "Tipo de Operación : << Llamada Procedimiento : SP_SOLMIN_SA_ALMACENAJE_RZSC32_R01 >> " & vbNewLine & _
                                "Motivo del Error : " & ex.Message
            Finally
                objParametros = Nothing
            End Try
            Return rptTemp
        End Function
#End Region
#Region " IDisposable Support "
        ' IDisposable
        Protected Overridable Sub Dispose(ByVal disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    ' TODO: Liberar recursos administrados cuando se llamen explícitamente
                    oSqlManager.Dispose()
                    oSqlManager = Nothing
                End If
                ' TODO: Liberar recursos no administrados compartidos
            End If
            Me.disposedValue = True
        End Sub

        ' Visual Basic agregó este código para implementar correctamente el modelo descartable.
        Public Sub Dispose() Implements IDisposable.Dispose
            ' No cambie este código. Coloque el código de limpieza en Dispose (ByVal que se dispone como Boolean).
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
#End Region
    End Class
End Namespace