Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace CheckComboBoxTest
    Public Class CCBoxItem
        Private val As String
        Public Property Value() As String
            Get
                Return val
            End Get
            Set(ByVal value As String)
                val = value
            End Set
        End Property

        Private m_name As String
        Public Property Name() As String
            Get
                Return m_name
            End Get
            Set(ByVal value As String)
                m_name = value
            End Set
        End Property

        Public Sub New()
        End Sub

        Public Sub New(ByVal name As String, ByVal val As String) 'sTRING
            Me.m_name = name
            Me.val = val
        End Sub

        Public Overloads Overrides Function ToString() As String
            Return String.Format("name: '{0}', value: {1}", m_name, val)
        End Function
    End Class
End Namespace