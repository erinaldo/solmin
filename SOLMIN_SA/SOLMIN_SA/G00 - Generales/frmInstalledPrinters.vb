Imports System.Drawing.Printing

Public Class frmInstalledPrinters


#Region " Atributos "
    Private sSelectedPrinter As String = ""
#End Region
#Region " Propiedades "
    Public ReadOnly Property pSelectedPrinter() As String
        Get
            Return sSelectedPrinter
        End Get
    End Property
#End Region
#Region " Métodos y Funciones "

#End Region
#Region " Eventos "
    Sub New(ByVal sPrinterName As String)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        sSelectedPrinter = sPrinterName
    End Sub

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click
        sSelectedPrinter = cbxImpresoras.Text
    End Sub

    Private Sub frmInstalledPrinters_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim pd As PrintDocument = New PrintDocument
        Dim bExistsPrinter As Boolean = False
        ' Default printer       
        Dim sTempDefaultPrinter As String = pd.PrinterSettings.PrinterName
        Dim sTempPrinter As String
        ' recorre las impresoras instaladas   
        If PrinterSettings.InstalledPrinters.Count = 0 Then
            MessageBox.Show("No existe impresoras instaladas.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If
        For Each sTempPrinter In PrinterSettings.InstalledPrinters
            cbxImpresoras.Items.Add(sTempPrinter)
            ' Validamos que la impresora proporcionada al instanciar el formulario exista para poderla resaltar
            If sSelectedPrinter <> "" Then If sSelectedPrinter.ToUpper.Trim = sTempPrinter.ToUpper.Trim Then bExistsPrinter = True
        Next
        If bExistsPrinter Then
            cbxImpresoras.Text = sSelectedPrinter
        Else
            cbxImpresoras.Text = sTempDefaultPrinter
        End If
    End Sub
#End Region
End Class