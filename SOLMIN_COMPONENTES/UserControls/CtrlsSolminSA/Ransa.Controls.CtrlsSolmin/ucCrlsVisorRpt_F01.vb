Imports CrystalDecisions.CrystalReports.Engine

Public Class ucCrlsVisorRpt_F01
#Region " Definición Eventos "

#End Region
#Region " Tipo "

#End Region
#Region " Atributos "
    '-------------------------------------------------
    ' Manejador de la Conexión
    '-------------------------------------------------

    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------

    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------

    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
#End Region

#Region " Propiedades "
    Public Property pReportDocument() As ReportDocument
        Get
            Return crpVisorRPT.ReportSource
        End Get
        Set(ByVal value As ReportDocument)
            crpVisorRPT.ReportSource = value
            crpVisorRPT.Zoom(2)
        End Set
    End Property
#End Region
#Region " Funciones y Procedimientos "

#End Region
#Region " Eventos "
    Sub New(ByVal Value As ReportDocument)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        crpVisorRPT.ReportSource = Value
        crpVisorRPT.Zoom(2)
    End Sub
#End Region
#Region " Métodos "

#End Region
End Class
