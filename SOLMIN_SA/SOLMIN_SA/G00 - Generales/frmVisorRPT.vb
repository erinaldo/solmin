Imports CrystalDecisions.CrystalReports.Engine

Public Class frmVisorRPT
#Region " Definici�n Eventos "

#End Region
#Region " Tipo "

#End Region
#Region " Atributos "
    '-------------------------------------------------
    ' Manejador de la Conexi�n
    '-------------------------------------------------

    '-------------------------------------------------
    ' Almacenamiento de Informaci�n
    '-------------------------------------------------

    '-------------------------------------------------
    ' Informaci�n del Estado
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
            crpVisorRPT.Zoom(1)


            crpVisorRPT.ShowLastPage()
            Dim LastPage As Integer = crpVisorRPT.GetCurrentPageNumber()
            crpVisorRPT.ShowFirstPage()

            If LastPage > 1 Then
                crpVisorRPT.ShowGroupTreeButton = True
                crpVisorRPT.DisplayGroupTree = True
            Else
                crpVisorRPT.ShowGroupTreeButton = False
                crpVisorRPT.DisplayGroupTree = False
            End If
        End Set
    End Property
#End Region
#Region " Funciones y Procedimientos "

#End Region
#Region " Eventos "
    Sub New(ByVal Value As ReportDocument)
        ' Llamada necesaria para el Dise�ador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicializaci�n despu�s de la llamada a InitializeComponent().
        crpVisorRPT.ReportSource = Value
        crpVisorRPT.Zoom(1)

    End Sub
#End Region
#Region " M�todos "

#End Region

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        crpVisorRPT.GetCurrentPageNumber()
        '.PrintReport()
    End Sub
End Class
