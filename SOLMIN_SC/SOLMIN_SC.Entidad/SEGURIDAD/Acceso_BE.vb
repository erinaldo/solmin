﻿Imports System.Runtime.InteropServices

<StructLayout(LayoutKind.Sequential)> _
Public Class Acceso_BE

    Private _USUARIO_CREACION As String = ""
    ''' <summary>
    ''' Código Usuario Creador 
    ''' </summary>
    Public Property USUARIO_CREACION() As String
        Get
            Return _USUARIO_CREACION
        End Get
        Set(ByVal value As String)
            _USUARIO_CREACION = value
        End Set
    End Property

    Private _FECHA_CREACION As String = ""
    ''' <summary>
    ''' Fecha de  Creación
    ''' </summary>
    Public Property FECHA_CREACION() As String
        Get
            Return _FECHA_CREACION
        End Get
        Set(ByVal value As String)
            _FECHA_CREACION = value
        End Set
    End Property


    Private _HORA_CREACION As String = ""
    ''' <summary>
    ''' Hora de creación
    ''' </summary>
    Public Property HORA_CREACION() As String
        Get
            Return _HORA_CREACION
        End Get
        Set(ByVal value As String)
            _HORA_CREACION = value
        End Set
    End Property


    Private _TERMINAL_CREACION As String = ""
    ''' <summary>
    ''' Terminal usado al crear
    ''' </summary>
    Public Property TERMINAL_CREACION() As String
        Get
            Return _TERMINAL_CREACION
        End Get
        Set(ByVal value As String)
            _TERMINAL_CREACION = value
        End Set
    End Property


    Private _USUARIO_ACTUALIZACION As String = ""
    ''' <summary>
    ''' Cod Ultimo Usuario Actualizador
    ''' </summary>
    Public Property USUARIO_ACTUALIZACION() As String
        Get
            Return _USUARIO_ACTUALIZACION
        End Get
        Set(ByVal value As String)
            _USUARIO_ACTUALIZACION = value
        End Set
    End Property


    Private _FECHA_ACTUALIZACION As String = ""
    ''' <summary>
    ''' Fecha de Última Actualización
    ''' </summary>
    Public Property FECHA_ACTUALIZACION() As String
        Get
            Return _FECHA_ACTUALIZACION
        End Get
        Set(ByVal value As String)
            _FECHA_ACTUALIZACION = value
        End Set
    End Property


    Private _HORA_ACTUALIZACION As String = ""
    ''' <summary>
    ''' Hora de Última Actualización 
    ''' </summary>
    Public Property HORA_ACTUALIZACION() As String
        Get
            Return _HORA_ACTUALIZACION
        End Get
        Set(ByVal value As String)
            _HORA_ACTUALIZACION = value
        End Set
    End Property


    Private _TERMINAL_ACTUALIZACION As String = ""
    ''' <summary>
    ''' Terminal usado en la  actualización
    ''' </summary>
    Public Property TERMINAL_ACTUALIZACION() As String
        Get
            Return _TERMINAL_ACTUALIZACION
        End Get
        Set(ByVal value As String)
            _TERMINAL_ACTUALIZACION = value
        End Set
    End Property


    Private _STSOP1 As String
    Public Property STSOP1() As String
        Get
            Return _STSOP1
        End Get
        Set(ByVal value As String)
            _STSOP1 = value
        End Set
    End Property

    Private _STSOP2 As String
    Public Property STSOP2() As String
        Get
            Return _STSOP2
        End Get
        Set(ByVal value As String)
            _STSOP2 = value
        End Set
    End Property

    Private _STSOP3 As String
    Public Property STSOP3() As String
        Get
            Return _STSOP3
        End Get
        Set(ByVal value As String)
            _STSOP3 = value
        End Set
    End Property

    Private _STSADI As String
    Public Property STSADI() As String
        Get
            Return _STSADI
        End Get
        Set(ByVal value As String)
            _STSADI = value
        End Set
    End Property


    Private _STSVIS As String
    Public Property STSVIS() As String
        Get
            Return _STSVIS
        End Get
        Set(ByVal value As String)
            _STSVIS = value
        End Set
    End Property


    Private _STSCHG As String
    Public Property STSCHG() As String
        Get
            Return _STSCHG
        End Get
        Set(ByVal value As String)
            _STSCHG = value
        End Set
    End Property


    Private _STSELI As String
    Public Property STSELI() As String
        Get
            Return _STSELI
        End Get
        Set(ByVal value As String)
            _STSELI = value
        End Set
    End Property


    Private _STSOP1_BOL As Boolean = False
    Public Property STSOP1_BOL() As Boolean
        Get
            Return _STSOP1_BOL
        End Get
        Set(ByVal value As Boolean)
            _STSOP1_BOL = value
        End Set
    End Property

    Private _STSOP2_BOL As Boolean = False
    Public Property STSOP2_BOL() As Boolean
        Get
            Return _STSOP2_BOL
        End Get
        Set(ByVal value As Boolean)
            _STSOP2_BOL = value
        End Set
    End Property

    Private _STSOP3_BOL As Boolean = False
    Public Property STSOP3_BOL() As Boolean
        Get
            Return _STSOP3_BOL
        End Get
        Set(ByVal value As Boolean)
            _STSOP3_BOL = value
        End Set
    End Property

    Private _STSADI_BOL As Boolean = False
    Public Property STSADI_BOL() As Boolean
        Get
            Return _STSADI_BOL
        End Get
        Set(ByVal value As Boolean)
            _STSADI_BOL = value
        End Set
    End Property


    Private _STSVIS_BOL As Boolean = False
    Public Property STSVIS_BOL() As Boolean
        Get
            Return _STSVIS_BOL
        End Get
        Set(ByVal value As Boolean)
            _STSVIS_BOL = value
        End Set
    End Property


    Private _STSCHG_BOL As Boolean = False
    Public Property STSCHG_BOL() As Boolean
        Get
            Return _STSCHG_BOL
        End Get
        Set(ByVal value As Boolean)
            _STSCHG_BOL = value
        End Set
    End Property


    Private _STSELI_BOL As Boolean = False
    Public Property STSELI_BOL() As Boolean
        Get
            Return _STSELI_BOL
        End Get
        Set(ByVal value As Boolean)
            _STSELI_BOL = value
        End Set
    End Property


End Class
