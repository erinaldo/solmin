Public Class clsRepDespacho
    Private dblAnticipado_Mar As Double
    Private dblAnticipado_Aer As Double
    Private dblAnticipado_Ter As Double
    Private dblNormal_Mar As Double
    Private dblNormal_Aer As Double
    Private dblNormal_Ter As Double
    Private dblPeso_Mar As Double
    Private dblPeso_Aer As Double
    Private dblPeso_Ter As Double
    Private dblTiempo_Anticipado_Mar As Double
    Private dblTiempo_Anticipado_Aer As Double
    Private dblTiempo_Anticipado_Ter As Double
    Private dblTiempo_Normal_Mar As Double
    Private dblTiempo_Normal_Aer As Double
    Private dblTiempo_Normal_Ter As Double
    Private dblFuera_Obj_Mar As Double
    Private dblFuera_Obj_Aer As Double
    Private dblFuera_Obj_Ter As Double
    Private dblTiempo_Fuera_Obj_Mar As Double
    Private dblTiempo_Fuera_Obj_Aer As Double
    Private dblTiempo_Fuera_Obj_Ter As Double
    Private dblAnticipado_OS_ETA As Double
    Private dblNormal_OS_ETA As Double
    '---------------------------Tipo Dato---------------------------
    Private oTipoDatoNeg As New Negocio.clsTipoDato
    '---------------------------------------------------------------
    Enum MEDIO_TRANSPORTE
        AEREO = 1
        MARITIMO = 2
        POSTAL = 3
        TERRESTRE = 4
        FLUVIAL = 5
    End Enum
    Enum TIPO_DESPACHO
        NORMAL = 1
        ANTICIPADO = 2
        URGENTE = 3
        MUYURGENTE = 4
    End Enum

    Sub New()
        dblAnticipado_Mar = 0
        dblAnticipado_Aer = 0
        dblAnticipado_Ter = 0
        dblNormal_Mar = 0
        dblNormal_Aer = 0
        dblNormal_Ter = 0
        dblPeso_Mar = 0
        dblPeso_Aer = 0
        dblPeso_Ter = 0
        dblTiempo_Anticipado_Mar = 0
        dblTiempo_Anticipado_Aer = 0
        dblTiempo_Anticipado_Ter = 0
        dblTiempo_Normal_Mar = 0
        dblTiempo_Normal_Aer = 0
        dblTiempo_Normal_Ter = 0
        dblFuera_Obj_Mar = 0
        dblFuera_Obj_Aer = 0
        dblFuera_Obj_Ter = 0
        dblTiempo_Fuera_Obj_Mar = 0
        dblTiempo_Fuera_Obj_Aer = 0
        dblTiempo_Fuera_Obj_Ter = 0
        dblAnticipado_OS_ETA = 0
        dblNormal_OS_ETA = 0

        Dim oTipoDato As New Entidad.beTipoDato
        oTipoDato.PNNTPODT = 29
        oTipoDatoNeg.Crea_DetalleTipoDato(oTipoDato)
    End Sub

    Property Anticipado_ETA_DocCom()
        Get
            Return dblAnticipado_OS_ETA
        End Get
        Set(ByVal value)
            dblAnticipado_OS_ETA = value
        End Set
    End Property

    Property Normal_ETA_DocCom()
        Get
            Return dblNormal_OS_ETA
        End Get
        Set(ByVal value)
            dblNormal_OS_ETA = value
        End Set
    End Property

    Property Fuera_Obj_Mar()
        Get
            Return dblFuera_Obj_Mar
        End Get
        Set(ByVal value)
            dblFuera_Obj_Mar = value
        End Set
    End Property

    Property Fuera_Obj_Aer()
        Get
            Return dblFuera_Obj_Aer
        End Get
        Set(ByVal value)
            dblFuera_Obj_Aer = value
        End Set
    End Property

    Property Fuera_Obj_Ter()
        Get
            Return dblFuera_Obj_Ter
        End Get
        Set(ByVal value)
            dblFuera_Obj_Ter = value
        End Set
    End Property

    Property Peso_Mar()
        Get
            Return dblPeso_Mar
        End Get
        Set(ByVal value)
            dblPeso_Mar = value
        End Set
    End Property

    Property Peso_Aer()
        Get
            Return dblPeso_Aer
        End Get
        Set(ByVal value)
            dblPeso_Aer = value
        End Set
    End Property

    Property Peso_Ter()
        Get
            Return dblPeso_Ter
        End Get
        Set(ByVal value)
            dblPeso_Ter = value
        End Set
    End Property

    Property Normal_Mar()
        Get
            Return dblNormal_Mar
        End Get
        Set(ByVal value)
            dblNormal_Mar = value
        End Set
    End Property

    Property Normal_Aer()
        Get
            Return dblNormal_Aer
        End Get
        Set(ByVal value)
            dblNormal_Aer = value
        End Set
    End Property

    Property Normal_Ter()
        Get
            Return dblNormal_Ter
        End Get
        Set(ByVal value)
            dblNormal_Ter = value
        End Set
    End Property

    Property Anticipados_Mar()
        Get
            Return dblAnticipado_Mar
        End Get
        Set(ByVal value)
            dblAnticipado_Mar = value
        End Set
    End Property

    Property Anticipados_Aer()
        Get
            Return dblAnticipado_Aer
        End Get
        Set(ByVal value)
            dblAnticipado_Aer = value
        End Set
    End Property

    Property Anticipados_Ter()
        Get
            Return dblAnticipado_Ter
        End Get
        Set(ByVal value)
            dblAnticipado_Ter = value
        End Set
    End Property

    Public Function Promedio_Anticipado_Maritimo() As Double
        If dblAnticipado_Mar = 0 Then
            Return 0
        Else
            Return dblTiempo_Anticipado_Mar / dblAnticipado_Mar
        End If
    End Function

    Public Function Promedio_Anticipado_Aereo() As Double
        If dblAnticipado_Aer = 0 Then
            Return 0
        Else
            Return dblTiempo_Anticipado_Aer / dblAnticipado_Aer
        End If
    End Function

    Public Function Promedio_Anticipado_Terrestre() As Double
        If dblAnticipado_Ter = 0 Then
            Return 0
        Else
            Return dblTiempo_Anticipado_Ter / dblAnticipado_Ter
        End If
    End Function

    Public Function Promedio_Normal_Maritimo() As Double
        If dblNormal_Mar = 0 Then
            Return 0
        Else
            Return dblTiempo_Normal_Mar / dblNormal_Mar
        End If
    End Function

    Public Function Promedio_Normal_Aereo() As Double
        If dblNormal_Aer = 0 Then
            Return 0
        Else
            Return dblTiempo_Normal_Aer / dblNormal_Aer
        End If
    End Function

    Public Function Promedio_Normal_Terrestre() As Double
        If dblNormal_Ter = 0 Then
            Return 0
        Else
            Return dblTiempo_Normal_Ter / dblNormal_Ter
        End If
    End Function

    Public Function Promedio_Fuera_Obj_Maritimo() As Double
        If dblFuera_Obj_Mar = 0 Then
            Return 0
        Else
            Return dblTiempo_Fuera_Obj_Mar / dblFuera_Obj_Mar
        End If
    End Function

    Public Function Promedio_Fuera_Obj_Aereo() As Double
        If dblFuera_Obj_Aer = 0 Then
            Return 0
        Else
            Return dblTiempo_Fuera_Obj_Aer / dblFuera_Obj_Aer
        End If
    End Function

    Public Function Promedio_Fuera_Obj_Terrestre() As Double
        If dblFuera_Obj_Ter = 0 Then
            Return 0
        Else
            Return dblTiempo_Fuera_Obj_Ter / dblFuera_Obj_Ter
        End If
    End Function

    Public Sub Cuenta_Despacho(ByVal TipoDespacho As TIPO_DESPACHO, ByVal MedioTransporte As MEDIO_TRANSPORTE, ByVal pdblCant As Double, Optional ByVal pintCliente As Integer = 0)

        Dim pdblCantDias As Double = 0D
        pdblCantDias = oTipoDatoNeg.RetornaDiasAlmacen(MedioTransporte.ToString, pintCliente) 'enviamos la descripcion del medio transporte
        Select Case TipoDespacho
            Case TIPO_DESPACHO.ANTICIPADO
                If MedioTransporte = MEDIO_TRANSPORTE.MARITIMO Then
                    dblAnticipado_Mar = dblAnticipado_Mar + 1
                    dblTiempo_Anticipado_Mar = dblTiempo_Anticipado_Mar + pdblCant
                Else
                    If MedioTransporte = MEDIO_TRANSPORTE.AEREO Then
                        dblAnticipado_Aer = dblAnticipado_Aer + 1
                        dblTiempo_Anticipado_Aer = dblTiempo_Anticipado_Aer + pdblCant
                    Else
                        If MedioTransporte = MEDIO_TRANSPORTE.TERRESTRE Then
                            dblAnticipado_Ter = dblAnticipado_Ter + 1
                            dblTiempo_Anticipado_Ter = dblTiempo_Anticipado_Ter + pdblCant
                        End If
                    End If
                End If
            Case TIPO_DESPACHO.URGENTE
                If MedioTransporte = MEDIO_TRANSPORTE.MARITIMO Then
                    dblAnticipado_Mar = dblAnticipado_Mar + 1
                    dblTiempo_Anticipado_Mar = dblTiempo_Anticipado_Mar + pdblCant
                Else
                    If MedioTransporte = MEDIO_TRANSPORTE.AEREO Then
                        dblAnticipado_Aer = dblAnticipado_Aer + 1
                        dblTiempo_Anticipado_Aer = dblTiempo_Anticipado_Aer + pdblCant
                    Else
                        If MedioTransporte = MEDIO_TRANSPORTE.TERRESTRE Then
                            dblAnticipado_Ter = dblAnticipado_Ter + 1
                            dblTiempo_Anticipado_Ter = dblTiempo_Anticipado_Ter + pdblCant
                        End If
                    End If
                End If
            Case TIPO_DESPACHO.NORMAL
                If MedioTransporte = MEDIO_TRANSPORTE.MARITIMO Then
                    dblNormal_Mar = dblNormal_Mar + 1
                    dblTiempo_Normal_Mar = dblTiempo_Normal_Mar + pdblCant
                Else
                    If MedioTransporte = MEDIO_TRANSPORTE.AEREO Then
                        dblNormal_Aer = dblNormal_Aer + 1
                        dblTiempo_Normal_Aer = dblTiempo_Normal_Aer + pdblCant
                    Else
                        If MedioTransporte = MEDIO_TRANSPORTE.TERRESTRE Then
                            dblNormal_Ter = dblNormal_Ter + 1
                            dblTiempo_Normal_Ter = dblTiempo_Normal_Ter + pdblCant
                        End If
                    End If
                End If
        End Select
        Despacho_Con_Problema(MedioTransporte, pdblCant, pdblCantDias)
    End Sub


    Private Sub Despacho_Con_Problema(ByVal MedioTransporte As MEDIO_TRANSPORTE, ByVal pdblCant As Double, Optional ByVal pdblCantDias As Double = 0)
        Select Case MedioTransporte
            Case MEDIO_TRANSPORTE.MARITIMO
                If pdblCant > pdblCantDias Then '10
                    dblFuera_Obj_Mar = dblFuera_Obj_Mar + 1
                    dblTiempo_Fuera_Obj_Mar = dblTiempo_Fuera_Obj_Mar + pdblCant
                End If
            Case MEDIO_TRANSPORTE.AEREO
                If pdblCant > pdblCantDias Then '5
                    dblFuera_Obj_Aer = dblFuera_Obj_Aer + 1
                    dblTiempo_Fuera_Obj_Aer = dblTiempo_Fuera_Obj_Aer + pdblCant
                End If
            Case MEDIO_TRANSPORTE.TERRESTRE
                If pdblCant > pdblCantDias Then '10
                    dblFuera_Obj_Ter = dblFuera_Obj_Ter + 1
                    dblTiempo_Fuera_Obj_Ter = dblTiempo_Fuera_Obj_Ter + pdblCant
                End If
        End Select
    End Sub

    Public Sub Cuenta_Peso(ByVal MedioTransporte As MEDIO_TRANSPORTE, ByVal pdblCantidad As Double)
        If MedioTransporte = MEDIO_TRANSPORTE.MARITIMO Then
            dblPeso_Mar = dblPeso_Mar + pdblCantidad
        Else
            If MedioTransporte = MEDIO_TRANSPORTE.AEREO Then
                dblPeso_Aer = dblPeso_Aer + pdblCantidad
            Else
                If MedioTransporte = MEDIO_TRANSPORTE.TERRESTRE Then
                    dblPeso_Ter = dblPeso_Ter + pdblCantidad
                End If
            End If
        End If
    End Sub

    
End Class
