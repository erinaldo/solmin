Imports System.Text

Public MustInherit Class Comun
    '=====================ESTATICOS PARA SERVICIOS ESPECIALES=============================
    'Public Shared ESP_Reembolso As String = "RE"
    'Public Shared ESP_PesoPromedio As String = "PP"
    'Public Shared ESP_Permanencia As String = "PE"
    'Public Shared ESP_ManipuleoPeso As String = "MP"
    'Public Shared ESP_AlmacenajePeso As String = "AP"
    'Public Shared ESP_Almacenaje As String = "AL"
    'Public Shared ESP_General As String = "GE"
    'Public Shared ESP_Adicional As String = "AD"
    'Public Shared ESP_Manual As String = "MA"
    '=====================================================================================
    '===================ESTATICO PARA ESTADO DE PANTALLA==================================
    Public Shared ESTADO_Nuevo As String = "N"
    Public Shared ESTADO_Modificado As String = "M"
    Public Shared ESTADO_Eliminado As String = "E"
    '=====================================================================================
    '===================ESTATICO PARA ESTADO DE TIPO PROCESO==============================
    Public Shared PROCESO_Almacenaje As String = "A"
    Public Shared PROCESO_Despacho As String = "D"
    Public Shared PROCESO_Recepcion As String = "R"
    Public Shared PROCESO_Otros As String = "O"
    '=====================================================================================
    '===================ESTATICO PARA ESTADO DE TIPO PROCESO==============================
    Public Shared UNIDAD_MT2 As String = "MT2"
    Public Shared UNIDAD_MT3 As String = "MT3"
    Public Shared UNIDAD_KGS As String = "KGS"
    '=====================================================================================
    '===================ESTATICO PARA LA TARIFACION SEGUN=================================
    Public Shared TARIFA_X_PROMEDIO As String = "1"
    Public Shared TARIFA_X_MAXIMO As String = "2"
    Public Shared TARIFA_X_MINIMO As String = "3"


    Public Shared Function RspMsgBox(ByVal Texto As String) As DialogResult
        Dim SistNom As String = Mensaje("Sistema")
        Return MessageBox.Show(Texto, SistNom, MessageBoxButtons.YesNo)
    End Function
    Public Shared Function FormatoFechaAS400(ByVal fecha As String) As String
        Dim Cadena() As String
        Cadena = Split(fecha, "/")
        Dim fechaFormatoAS400 As String
        If fecha.Length > 1 Then
            fechaFormatoAS400 = Cadena(2) & Cadena(1) & Cadena(0)
        Else
            fechaFormatoAS400 = "00000000"
        End If
        Return fechaFormatoAS400
    End Function
    Public Shared Function Mensaje(ByVal key As String) As String
        Dim msj As String = ""
        Select Case key
            Case "MsgErr"
                msj = "La operación no pudo completarse, Notifique este evento al Dpto. de Sistemas."
            Case "MENSAJE.EXITO"
                msj = "El Proceso se completo con Exito"
            Case "MENSAJE.ERROR"
                msj = "Error al Guardar el Registro"
            Case "MENSAJE.ERROR.EMBARQUE"
                msj = "Ingrese el Número de embarque correcto"
            Case "MENSAJE.CONFIRMA.ELIMINA.SERVICIO"
                msj = "Está seguro de eliminar el servicio seleccionado?"
            Case "MENSAJE.ERROR.ELIMINA.SERVICIO"
                msj = "No se puede eliminar porque ya ha sido facturada"
            Case "MENSAJE.ERROR.ELIMINA.SERVICIO2"
                msj = "No hay ningun Servicio Asociado a la Operación"
            Case "MENSAJE.VALIDA.PALETA"
                msj = "Debe ingresar un Nro. de Paleta válido."
            Case "MENSAJE.VALIDA.GUIA"
                msj = "Debe ingresar un Nro. de Guía de Remisión válido."
            Case "MENSAJE.VALIDA.DESPACHO"
                msj = "Debe ingresar un Nro. de Pre-Despacho."
            Case "Sistema"
                msj = "SOLMIN - Modulo de Contratos y Facturación"
            Case "MENSAJE.VALIDA.PALETA"
                msj = "Debe ingresar un Nro. de Paleta válido."
            Case "MENSAJE.VALIDA.GUIA"
                msj = "Debe ingresar un Nro. de Guía de Remisión válido."
            Case "MENSAJE.VALIDA.DESPACHO"
                msj = "Debe ingresar Guía de Salida."
            Case "MENSAJE.VALIDA.INGRESO"
                msj = "Debe ingresar Guía de Ingreso."
            Case "MENSAJE.VALIDA.DESPACHO"
                msj = "Debe ingresar un Nro. de Pre-Despacho."
            Case "MENSAJE.MANTENIMIENTO.NUEVO.ALMACEN"
                msj = "Nuevo Servicios Almacen"
            Case "MENSAJE.MANTENIMIENTO.NUEVO.SIL"
                msj = "Nuevo Servicio SIL"
            Case "MENSAJE.MANTENIMIENTO.MODIFICA.SERVICIO"
                msj = "Modificar Servicios"
        End Select
        Return msj
    End Function
    Public Shared Function FormatoFecha(ByVal fecha As String) As String
        Dim fechaFormato As String
        If fecha.Length = 8 Then
            fechaFormato = fecha.Substring(6, 2) & "/" & fecha.Substring(4, 2) & "/" & fecha.Substring(0, 4)
        ElseIf fecha.Length = 1 Then
            fechaFormato = ""
        Else
            fechaFormato = Microsoft.VisualBasic.Right(fecha, 2) & "/" & Microsoft.VisualBasic.Right(fecha, 2) & "/" & Microsoft.VisualBasic.Left(fecha, 4)
        End If
        Return fechaFormato
    End Function

    Public Shared Function SoloNumeros(ByVal Keyascii As Short) As Short

        If InStr("1234567890.", Chr(Keyascii)) = 0 Then
            SoloNumeros = 0
        Else
            SoloNumeros = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloNumeros = Keyascii
            Case 13
                SoloNumeros = Keyascii
            Case 32
                SoloNumeros = Keyascii
        End Select

    End Function
    Public Enum eTipoAlmacen
        NoAplica = 0
        DepSimple = 1
        DepAutorizado = 5
        AlmTransito = 7
    End Enum

    Public Enum eServicioEstado
        Defaults = 0
        Pendiente = 1
        PorFacturar = 2
    End Enum

    Public Shared Function SoloNumerosConDecimal(ByVal sender As Object, ByVal Keyascii As Short) As Short
        Dim TextBox As Object = Nothing
        If TypeOf sender Is TextBox Then
            'TextBox = System.Windows.Forms.TextBox
            TextBox = CType(sender, TextBox)
            'TextBox = CType(sender, TextBox)
        End If
        If TypeOf sender Is ToolStripTextBox Then
            TextBox = CType(sender, ToolStripTextBox)
        End If
        Dim NumeroTexto As String
        'TextBox = CType(sender, TextBox)
        Dim ArrayEnteroDecimal() As String
        Dim NEnteros As Int32 = 0
        Dim NDecimales As Int32 = 0
        If TextBox.Tag IsNot Nothing Then
            ArrayEnteroDecimal = TextBox.Tag.ToString.Split("-")
            If ArrayEnteroDecimal.Length = 2 Then
                NEnteros = Convert.ToInt32(ArrayEnteroDecimal(0))
                NDecimales = Convert.ToInt32(ArrayEnteroDecimal(1))
            End If
        End If
        Dim InicioEnteros As String = IIf(NEnteros = 0, "0", 1)
        Dim RegexExpresion As String = "^[0-9]{" & InicioEnteros & "," & NEnteros & "}(\.[0-9]{0," & NDecimales & "})?$"
        NumeroTexto = TextBox.Text.Trim
        Dim NumeroOriginal As String = NumeroTexto
        NumeroTexto = NumeroTexto.Trim & Chr(Keyascii)
        If RegularExpressions.Regex.IsMatch(NumeroTexto, RegexExpresion) = False Then
            NumeroTexto = NumeroOriginal
            SoloNumerosConDecimal = 0
        Else
            SoloNumerosConDecimal = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoloNumerosConDecimal = Keyascii
            Case 13
                SoloNumerosConDecimal = Keyascii
            Case 32
                SoloNumerosConDecimal = Keyascii
        End Select
    End Function


End Class
