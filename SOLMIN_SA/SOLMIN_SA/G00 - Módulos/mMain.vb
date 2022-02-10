Imports System.Drawing.Printing
Imports RANSA.NEGO.slnSOLMIN
Imports RANSA.NEGO.slnSOLMIN_SAT
Imports Ransa.Rutime.ZebraPrinters

Module mMain
#Region " Variables, Enumeraciones y estructuras "
    Public GLOBAL_IMPRESORA_ZEBRA As String = ""
#End Region
#Region " VariablesGlobales "
    '-- Constantes Datos Servicios
    Public GLOBAL_COMPANIA = RANSA.Utilitario.MainModuleDeploy.IdCompaniaDeploy
    Public Const GLOBAL_DIVISION = "R"
    '-- Variables Publicas
    Public pblnAcceso As Boolean = False                        ' Status de Acceso
    Public GLOBAL_EMRESA = "RANSA COMERCIAL"                    ' Nombre de la Empresa
    Public objSeguridadBN As clsSeguridad = Nothing             ' Objeto de la Seguridad
    Public oPrinterZebra As ZebraPrinter = New ZebraPrinter     ' Impresora Zebra para las Etiquetas
#End Region
#Region " Procedimientos y Funciones "
    Public Function GetDefaultPrinterName() As String
        Dim pd As PrintDocument = New PrintDocument
        Dim sTempDefaultPrinter As String = pd.PrinterSettings.PrinterName
        Return sTempDefaultPrinter
    End Function

    Public Sub SoloNumeros(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

#End Region
End Module
