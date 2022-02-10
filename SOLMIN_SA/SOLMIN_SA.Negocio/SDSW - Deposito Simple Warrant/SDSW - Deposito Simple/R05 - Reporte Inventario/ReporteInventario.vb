Imports IBM.Data.DB2.iSeries
Imports CrystalDecisions.CrystalReports.Engine
Imports Db2Manager.RansaData.iSeries.DataObjects
Namespace SOLMIN.ReporteInventarioW
    Public Class FiltrosReporteInventario
#Region "Atributos"
        Private strZona As String = ""
        Private strAlmacen As String = ""
#End Region
#Region "Propiedades"
        Public Property pstrZona() As String
            Get
                Return strZona
            End Get
            Set(ByVal value As String)
                strZona = value
            End Set
        End Property
        Public Property pstrAlmacen() As String
            Get
                Return strAlmacen
            End Get
            Set(ByVal value As String)
                strAlmacen = value
            End Set
        End Property
#End Region

    End Class

    Public Class clsInventario
        Inherits clsBasicClassSDSW
        Private strUsuarioSistema As String = ""
        Sub New(ByVal UsuarioSistema As String)
            strUsuarioSistema = UsuarioSistema
        End Sub
        Public Function frpt_Inventario(ByVal objFiltro As FiltrosReporteInventario, ByRef strMensajeError As String) As ReportDocument
            Dim rdocInventario As ReportDocument = Nothing
            Dim dtResultado As DataTable = Nothing
            strMensajeError = ""
            dtResultado = fdtSDSWResultadoConsulta(strMensajeError, "SDSW_GENE_REPORINVENT_01", objFiltro.pstrZona, objFiltro.pstrAlmacen)
            dtResultado.TableName = "dtReporteInventario"

            If strMensajeError = "" Then
                rdocInventario = New rptReporteInventario
                rdocInventario.SetDataSource(dtResultado)
                rdocInventario.Refresh()
                rdocInventario.SetParameterValue("pNumAlmacen", objFiltro.pstrAlmacen)
                rdocInventario.SetParameterValue("pNumZona", objFiltro.pstrZona)
                rdocInventario.SetParameterValue("pUsuario", strUsuarioSistema)
            End If
            Return rdocInventario
        End Function
    End Class
End Namespace

