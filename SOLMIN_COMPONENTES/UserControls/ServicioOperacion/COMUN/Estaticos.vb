Public Class Estaticos
    '=====================ESTATICOS PARA SERVICIOS ESPECIALES=============================
    'Public Shared ESP_Reembolso As String = "RE"
    Public ReadOnly Property E_ESP_Reembolso() As String
        Get
            Return "RE"
        End Get
    End Property
    'Public Shared ESP_PesoPromedio As String = "PP"
    Public ReadOnly Property E_ESP_PesoPromedio() As String
        Get
            Return "PP"
        End Get
    End Property
    'Public Shared ESP_Permanencia As String = "PE"
    Public ReadOnly Property E_ESP_Permanencia() As String
        Get
            Return "PE"
        End Get
    End Property
    'Public Shared ESP_ManipuleoPeso As String = "MP"
    Public ReadOnly Property E_ESP_ManipuleoPeso() As String
        Get
            Return "MP"
        End Get
    End Property
    'Public Shared ESP_AlmacenajePeso As String = "AP"
    Public ReadOnly Property E_ESP_AlmacenajePeso() As String
        Get
            Return "AP"
        End Get
    End Property
    'Public Shared ESP_Almacenaje As String = "AL"
    Public ReadOnly Property E_ESP_Almacenaje() As String
        Get
            Return "AL"
        End Get
    End Property
    'Public Shared ESP_General As String = "GE"
    Public ReadOnly Property E_ESP_General() As String
        Get
            Return "GE"
        End Get
    End Property
    'Public Shared ESP_Adicional As String = "AD"
    Public ReadOnly Property E_ESP_Adicional() As String
        Get
            Return "AD"
        End Get
    End Property
    'Public Shared ESP_Manual As String = "MA"
    Public ReadOnly Property E_ESP_Manual() As String
        Get
            Return "MA"
        End Get
    End Property

    Public ReadOnly Property E_RangoViaje() As String
        Get
            Return "RV"
        End Get
    End Property

    Public ReadOnly Property E_RecuperoSeguro() As String
        Get
            Return "RS"
        End Get
    End Property

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
End Class
