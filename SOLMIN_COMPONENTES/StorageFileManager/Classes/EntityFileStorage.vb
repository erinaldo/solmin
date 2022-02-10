Namespace Classes
    Public Class EntityFileStorage
        Private m_Archivo As String
        Private m_TipoArchivo As String
        Private m_Fecha As String
        Private m_Tamanho As String
        Private m_FileName As String
        Public Property FileName() As String
            Get
                Return m_FileName
            End Get
            Set(ByVal value As String)
                m_FileName = value
            End Set
        End Property

        Public Property Tamanho() As String
            Get
                Return m_Tamanho
            End Get
            Set(ByVal value As String)
                m_Tamanho = value
            End Set
        End Property

        Public Property Fecha() As String
            Get
                Return m_Fecha
            End Get
            Set(ByVal value As String)
                m_Fecha = value
            End Set
        End Property

        Public Property TipoArchivo() As String
            Get
                Return m_TipoArchivo
            End Get
            Set(ByVal value As String)
                m_TipoArchivo = value
            End Set
        End Property

        Public Property Archivo() As String
            Get
                Return m_Archivo
            End Get
            Set(ByVal value As String)
                m_Archivo = value
            End Set
        End Property

    End Class

End Namespace
