
Public Class frmAuditoria

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

#Region "Propiedades"

    Private _USUARIO_CREACION As String
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


    Private _FECHA_CREACION As String
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


    Private _HORA_CREACION As String
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


    Private _TERMINAL_CREACION As String
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


    Private _USUARIO_ACTUALIZACION As String
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


    Private _FECHA_ACTUALIZACION As String
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


    Private _HORA_ACTUALIZACION As String
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


    Private _TERMINAL_ACTUALIZACION As String
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
#End Region

#Region "Eventos"
    Private Sub frmAuditoria_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.txtUsuarioCreador.Text = _USUARIO_CREACION
        Me.txtFechaCreacion.Text = _FECHA_CREACION
        Me.txtHoraCreacion.Text = _HORA_CREACION
        Me.txtTerminalUsado.Text = _TERMINAL_CREACION
        Me.txtUsuarioActualizado.Text = _USUARIO_ACTUALIZACION
        Me.txtFechaActualizado.Text = _FECHA_ACTUALIZACION
        Me.txtHoraActualizado.Text = _HORA_ACTUALIZACION
        Me.txtTerminalUsadoActualizar.Text = _TERMINAL_ACTUALIZACION
    End Sub

    Private Sub tsbCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCerrar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub


#End Region


End Class
