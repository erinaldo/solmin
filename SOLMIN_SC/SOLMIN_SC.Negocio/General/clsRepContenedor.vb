Public Class clsRepContenedor
    Private A20 As Double
    Private B20 As Double
    Private C20 As Double
    Private A40 As Double
    Private B40 As Double
    Private C40 As Double
    Private AF20 As Double
    Private BF20 As Double
    Private CF20 As Double
    Private AF40 As Double
    Private BF40 As Double
    Private CF40 As Double
    Private AO20 As Double
    Private BO20 As Double
    Private CO20 As Double
    Private AO40 As Double
    Private BO40 As Double
    Private CO40 As Double
    Private AR40 As Double
    Private BR40 As Double
    Private CR40 As Double
    Private AI20 As Double
    Private BI20 As Double
    Private CI20 As Double
    Private AI40 As Double
    Private BI40 As Double
    Private CI40 As Double
    Private AH20 As Double
    Private BH20 As Double
    Private CH20 As Double
    Private AH40 As Double
    Private BH40 As Double
    Private CH40 As Double

    Property PIES20()
        Get
            Return A20
        End Get
        Set(ByVal value)
            A20 = value
        End Set
    End Property

    Property PIES40()
        Get
            Return A40
        End Get
        Set(ByVal value)
            A40 = value
        End Set
    End Property

    Property FLACKPIES20()
        Get
            Return AF20
        End Get
        Set(ByVal value)
            AF20 = value
        End Set
    End Property

    Property FLACKPIES40()
        Get
            Return AF40
        End Get
        Set(ByVal value)
            AF40 = value
        End Set
    End Property

    Property OPENPIES20()
        Get
            Return AO20
        End Get
        Set(ByVal value)
            AO20 = value
        End Set
    End Property

    Property OPENPIES40()
        Get
            Return AO40
        End Get
        Set(ByVal value)
            AO40 = value
        End Set
    End Property

    Property REEFERPIES40()
        Get
            Return AR40
        End Get
        Set(ByVal value)
            AR40 = value
        End Set
    End Property

    Property ISOPIES20()
        Get
            Return AI20
        End Get
        Set(ByVal value)
            AI20 = value
        End Set
    End Property

    Property ISOPIES40()
        Get
            Return AI40
        End Get
        Set(ByVal value)
            AI40 = value
        End Set
    End Property

    Property HIGHPIES20()
        Get
            Return AH20
        End Get
        Set(ByVal value)
            AH20 = value
        End Set
    End Property

    Property HIGHPIES40()
        Get
            Return AH40
        End Get
        Set(ByVal value)
            AH40 = value
        End Set
    End Property

    Property PIES20SOBRE()
        Get
            Return B20
        End Get
        Set(ByVal value)
            B20 = value
        End Set
    End Property

    Property PIES40SOBRE()
        Get
            Return B40
        End Get
        Set(ByVal value)
            B40 = value
        End Set
    End Property

    Property FLACKPIES20SOBRE()
        Get
            Return BF20
        End Get
        Set(ByVal value)
            BF20 = value
        End Set
    End Property

    Property FLACKPIES40SOBRE()
        Get
            Return BF40
        End Get
        Set(ByVal value)
            BF40 = value
        End Set
    End Property

    Property OPENPIES20SOBRE()
        Get
            Return BO20
        End Get
        Set(ByVal value)
            BO20 = value
        End Set
    End Property

    Property OPENPIES40SOBRE()
        Get
            Return BO40
        End Get
        Set(ByVal value)
            BO40 = value
        End Set
    End Property

    Property REEFERPIES40SOBRE()
        Get
            Return BR40
        End Get
        Set(ByVal value)
            BR40 = value
        End Set
    End Property

    Property ISOPIES20SOBRE()
        Get
            Return BI20
        End Get
        Set(ByVal value)
            BI20 = value
        End Set
    End Property

    Property ISOPIES40SOBRE()
        Get
            Return BI40
        End Get
        Set(ByVal value)
            BI40 = value
        End Set
    End Property

    Property HIGHPIES20SOBRE()
        Get
            Return BH20
        End Get
        Set(ByVal value)
            BH20 = value
        End Set
    End Property

    Property HIGHPIES40SOBRE()
        Get
            Return BH40
        End Get
        Set(ByVal value)
            BH40 = value
        End Set
    End Property

    Function Promedio_20PIES() As Double
        Return C20 / B20
    End Function

    Function Promedio_40PIES() As Double
        Return C40 / B40
    End Function

    Function Promedio_20PIESFLACK() As Double
        Return CF20 / BF20
    End Function

    Function Promedio_40PIESFLACK() As Double
        Return CF40 / BF40
    End Function

    Function Promedio_20PIESOPEN() As Double
        Return CO20 / BO20
    End Function

    Function Promedio_40PIESOPEN() As Double
        Return CO40 / BO40
    End Function

    Function Promedio_40PIESREEFER() As Double
        Return CR40 / BR40
    End Function

    Function Promedio_20PIESISOTANQUE() As Double
        Return CI20 / BI20
    End Function

    Function Promedio_40PIESISOTANQUE() As Double
        Return CI40 / BI40
    End Function

    Function Promedio_20PIESHIGH() As Double
        Return CH20 / BH20
    End Function

    Function Promedio_40PIESHIGH() As Double
        Return CH40 / BH40
    End Function

    'Public Sub Contar_Tipo_Contenedor(ByVal pstrTipo As String, ByVal pdblCantidad As Double, ByVal pdblSobreEstadia As Double)
    '    Select Case pstrTipo
    '        Case "2" '"20 PIES STANDAR"
    '            A20 = A20 + pdblCantidad
    '            If pdblSobreEstadia > 0 Then
    '                B20 = B20 + pdblCantidad
    '                C20 = C20 + pdblSobreEstadia
    '            End If
    '        Case "3" '"40 PIES STANDAR"
    '            A40 = A40 + pdblCantidad
    '            If pdblSobreEstadia > 0 Then
    '                B40 = B40 + pdblCantidad
    '                C40 = C40 + pdblSobreEstadia
    '            End If
    '        Case "4" '"FLACK RACK 20 PIES"
    '            AF20 = AF20 + pdblCantidad
    '            If pdblSobreEstadia > 0 Then
    '                BF20 = BF20 + pdblCantidad
    '                CF20 = CF20 + pdblSobreEstadia
    '            End If
    '        Case "5" '"FLACK RACK 40 PIES"
    '            AF40 = AF40 + pdblCantidad
    '            If pdblSobreEstadia > 0 Then
    '                BF40 = BF40 + pdblCantidad
    '                CF40 = CF40 + pdblSobreEstadia
    '            End If
    '        Case "6" '"OPEN TOP 20 PIES"
    '            AO20 = AO20 + pdblCantidad
    '            If pdblSobreEstadia > 0 Then
    '                BO20 = BO20 + pdblCantidad
    '                CO20 = CO20 + pdblSobreEstadia
    '            End If
    '        Case "7" '"OPEN TOP 40 PIES"
    '            AO40 = AO40 + pdblCantidad
    '            If pdblSobreEstadia > 0 Then
    '                BO40 = BO40 + pdblCantidad
    '                CO40 = CO40 + pdblSobreEstadia
    '            End If
    '        Case "8" '"REEFER 40 PIES"
    '            AR40 = AR40 + pdblCantidad
    '            If pdblSobreEstadia > 0 Then
    '                BR40 = BR40 + pdblCantidad
    '                CR40 = CR40 + pdblSobreEstadia
    '            End If
    '        Case "9" '"ISOTANQUE 20 PIES"
    '            AI20 = AI20 + pdblCantidad
    '            If pdblSobreEstadia > 0 Then
    '                BI20 = BI20 + pdblCantidad
    '                CI20 = CI20 + pdblSobreEstadia
    '            End If
    '        Case "10" '"ISOTANQUE 40 PIES"
    '            AI40 = AI40 + pdblCantidad
    '            If pdblSobreEstadia > 0 Then
    '                BI40 = BI40 + pdblCantidad
    '                CI40 = CI40 + pdblCantidad
    '            End If
    '        Case "15" '"20 PIES HIGH CUBE"
    '            AH20 = AH20 + pdblCantidad
    '            If pdblSobreEstadia > 0 Then
    '                BH20 = BH20 + pdblCantidad
    '                CH20 = CH20 + pdblCantidad
    '            End If
    '        Case "16" '"40 PIES HIGH CUBE"
    '            AH40 = AH40 + pdblCantidad
    '            If pdblSobreEstadia > 0 Then
    '                BH40 = BH40 + pdblCantidad
    '                CH40 = CH40 + pdblCantidad
    '            End If
    '    End Select
    'End Sub

    Public Sub Contar_Tipo_Contenedor(ByVal pstrTipo As String, ByVal pdblCantidad As Double, ByVal pdblSobreEstadia As Double)
        Select Case pstrTipo
            Case "2" '"20 PIES STANDAR"
                A20 = A20 + pdblCantidad
                If pdblSobreEstadia > 0 Then
                    B20 = B20 + pdblCantidad
                    C20 = C20 + pdblSobreEstadia
                End If
            Case "3" '"40 PIES STANDAR"
                A40 = A40 + pdblCantidad
                If pdblSobreEstadia > 0 Then
                    B40 = B40 + pdblCantidad
                    C40 = C40 + pdblSobreEstadia
                End If
            Case "4" '"FLACK RACK 20 PIES"
                AF20 = AF20 + pdblCantidad
                If pdblSobreEstadia > 0 Then
                    BF20 = BF20 + pdblCantidad
                    CF20 = CF20 + pdblSobreEstadia
                End If
            Case "5" '"FLACK RACK 40 PIES"
                AF40 = AF40 + pdblCantidad
                If pdblSobreEstadia > 0 Then
                    BF40 = BF40 + pdblCantidad
                    CF40 = CF40 + pdblSobreEstadia
                End If
            Case "6" '"OPEN TOP 20 PIES"
                AO20 = AO20 + pdblCantidad
                If pdblSobreEstadia > 0 Then
                    BO20 = BO20 + pdblCantidad
                    CO20 = CO20 + pdblSobreEstadia
                End If
            Case "7" '"OPEN TOP 40 PIES"
                AO40 = AO40 + pdblCantidad
                If pdblSobreEstadia > 0 Then
                    BO40 = BO40 + pdblCantidad
                    CO40 = CO40 + pdblSobreEstadia
                End If
            Case "8" '"REEFER 40 PIES"
                AR40 = AR40 + pdblCantidad
                If pdblSobreEstadia > 0 Then
                    BR40 = BR40 + pdblCantidad
                    CR40 = CR40 + pdblSobreEstadia
                End If
            Case "9" '"ISOTANQUE 20 PIES"
                AI20 = AI20 + pdblCantidad
                If pdblSobreEstadia > 0 Then
                    BI20 = BI20 + pdblCantidad
                    CI20 = CI20 + pdblSobreEstadia
                End If
            Case "10" '"ISOTANQUE 40 PIES"
                AI40 = AI40 + pdblCantidad
                If pdblSobreEstadia > 0 Then
                    BI40 = BI40 + pdblCantidad
                    CI40 = CI40 + pdblCantidad
                End If
            Case "15" '"20 PIES HIGH CUBE"
                AH20 = AH20 + pdblCantidad
                If pdblSobreEstadia > 0 Then
                    BH20 = BH20 + pdblCantidad
                    CH20 = CH20 + pdblCantidad
                End If
            Case "16" '"40 PIES HIGH CUBE"
                AH40 = AH40 + pdblCantidad
                If pdblSobreEstadia > 0 Then
                    BH40 = BH40 + pdblCantidad
                    CH40 = CH40 + pdblCantidad
                End If
        End Select
    End Sub
End Class
