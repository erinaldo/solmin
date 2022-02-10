Imports System.Runtime.InteropServices

Namespace Planta

    Public Class bePlanta
        Public Sub New()
            CPLNDV_CodigoPlanta = 0
            CCMPN_CodigoCompania = ""
            CDVSN_CodigoDivision = ""
            TPLNTA_DescripcionPlanta = ""
        End Sub


        Private _CCMPN_CodigoCompania As String
        Public Property CCMPN_CodigoCompania() As String
            Get
                Return _CCMPN_CodigoCompania
            End Get
            Set(ByVal value As String)
                _CCMPN_CodigoCompania = value
            End Set
        End Property


        Private _CDVSN_CodigoDivision As String
        Public Property CDVSN_CodigoDivision() As String
            Get
                Return _CDVSN_CodigoDivision
            End Get
            Set(ByVal value As String)
                _CDVSN_CodigoDivision = value
            End Set
        End Property


        Private _CPLNDV_CodigoPlanta As Double
        Public Property CPLNDV_CodigoPlanta() As Double
            Get
                Return _CPLNDV_CodigoPlanta
            End Get
            Set(ByVal value As Double)
                _CPLNDV_CodigoPlanta = value
            End Set
        End Property


        Private _TPLNTA_DescripcionPlanta As String
        Public Property TPLNTA_DescripcionPlanta() As String
            Get
                Return _TPLNTA_DescripcionPlanta
            End Get
            Set(ByVal value As String)
                _TPLNTA_DescripcionPlanta = value
            End Set
        End Property


        Private _Orden As Int32 = -1
        Public Property Orden() As Int32
            Get
                Return _Orden
            End Get
            Set(ByVal value As Int32)
                _Orden = value
            End Set
        End Property

        '<[AHM]>
        Private _CDSPSP_CodSedeSAP As String
        Public Property CDSPSP_CodSedeSAP() As String
            Get
                Return _CDSPSP_CodSedeSAP
            End Get
            Set(ByVal value As String)
                _CDSPSP_CodSedeSAP = value
            End Set
        End Property
        '</[AHM]>
    End Class

End Namespace
