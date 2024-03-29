﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
'
Namespace WSCargarDocumento
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="SolminWebSoap", [Namespace]:="http://ransa.biz/")>  _
    Partial Public Class SolminWeb
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private GuardarImagenOperationCompleted As System.Threading.SendOrPostCallback
        
        Private ExisteImagenOperationCompleted As System.Threading.SendOrPostCallback
        
        Private getImageOperationCompleted As System.Threading.SendOrPostCallback
        
        Private getFileExtensionOperationCompleted As System.Threading.SendOrPostCallback
        
        Private CambiarNombreOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.Ransa.Controls.ServicioOperacion.My.MySettings.Default.Ransa_Controls_ServicioOperacion_WSCargarDocumento_SolminWeb
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = true
                Me.useDefaultCredentialsSetExplicitly = false
            Else
                Me.useDefaultCredentialsSetExplicitly = true
            End If
        End Sub
        
        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = true)  _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = false))  _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = false)) Then
                    MyBase.UseDefaultCredentials = false
                End If
                MyBase.Url = value
            End Set
        End Property
        
        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property
        
        '''<remarks/>
        Public Event GuardarImagenCompleted As GuardarImagenCompletedEventHandler
        
        '''<remarks/>
        Public Event ExisteImagenCompleted As ExisteImagenCompletedEventHandler
        
        '''<remarks/>
        Public Event getImageCompleted As getImageCompletedEventHandler
        
        '''<remarks/>
        Public Event getFileExtensionCompleted As getFileExtensionCompletedEventHandler
        
        '''<remarks/>
        Public Event CambiarNombreCompleted As CambiarNombreCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://ransa.biz/GuardarImagen", RequestNamespace:="http://ransa.biz/", ResponseNamespace:="http://ransa.biz/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GuardarImagen(ByVal Imagen() As String, ByVal Nombre As String, ByVal Carpeta As String) As Boolean
            Dim results() As Object = Me.Invoke("GuardarImagen", New Object() {Imagen, Nombre, Carpeta})
            Return CType(results(0),Boolean)
        End Function
        
        '''<remarks/>
        Public Overloads Sub GuardarImagenAsync(ByVal Imagen() As String, ByVal Nombre As String, ByVal Carpeta As String)
            Me.GuardarImagenAsync(Imagen, Nombre, Carpeta, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GuardarImagenAsync(ByVal Imagen() As String, ByVal Nombre As String, ByVal Carpeta As String, ByVal userState As Object)
            If (Me.GuardarImagenOperationCompleted Is Nothing) Then
                Me.GuardarImagenOperationCompleted = AddressOf Me.OnGuardarImagenOperationCompleted
            End If
            Me.InvokeAsync("GuardarImagen", New Object() {Imagen, Nombre, Carpeta}, Me.GuardarImagenOperationCompleted, userState)
        End Sub
        
        Private Sub OnGuardarImagenOperationCompleted(ByVal arg As Object)
            If (Not (Me.GuardarImagenCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GuardarImagenCompleted(Me, New GuardarImagenCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://ransa.biz/ExisteImagen", RequestNamespace:="http://ransa.biz/", ResponseNamespace:="http://ransa.biz/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function ExisteImagen(ByVal Carpeta As String, ByVal Nombre As String) As Boolean
            Dim results() As Object = Me.Invoke("ExisteImagen", New Object() {Carpeta, Nombre})
            Return CType(results(0),Boolean)
        End Function
        
        '''<remarks/>
        Public Overloads Sub ExisteImagenAsync(ByVal Carpeta As String, ByVal Nombre As String)
            Me.ExisteImagenAsync(Carpeta, Nombre, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub ExisteImagenAsync(ByVal Carpeta As String, ByVal Nombre As String, ByVal userState As Object)
            If (Me.ExisteImagenOperationCompleted Is Nothing) Then
                Me.ExisteImagenOperationCompleted = AddressOf Me.OnExisteImagenOperationCompleted
            End If
            Me.InvokeAsync("ExisteImagen", New Object() {Carpeta, Nombre}, Me.ExisteImagenOperationCompleted, userState)
        End Sub
        
        Private Sub OnExisteImagenOperationCompleted(ByVal arg As Object)
            If (Not (Me.ExisteImagenCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ExisteImagenCompleted(Me, New ExisteImagenCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://ransa.biz/getImage", RequestNamespace:="http://ransa.biz/", ResponseNamespace:="http://ransa.biz/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function getImage(ByVal Carpeta As String, ByVal Nombre As String) As Object
            Dim results() As Object = Me.Invoke("getImage", New Object() {Carpeta, Nombre})
            Return CType(results(0),Object)
        End Function
        
        '''<remarks/>
        Public Overloads Sub getImageAsync(ByVal Carpeta As String, ByVal Nombre As String)
            Me.getImageAsync(Carpeta, Nombre, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub getImageAsync(ByVal Carpeta As String, ByVal Nombre As String, ByVal userState As Object)
            If (Me.getImageOperationCompleted Is Nothing) Then
                Me.getImageOperationCompleted = AddressOf Me.OngetImageOperationCompleted
            End If
            Me.InvokeAsync("getImage", New Object() {Carpeta, Nombre}, Me.getImageOperationCompleted, userState)
        End Sub
        
        Private Sub OngetImageOperationCompleted(ByVal arg As Object)
            If (Not (Me.getImageCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent getImageCompleted(Me, New getImageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://ransa.biz/getFileExtension", RequestNamespace:="http://ransa.biz/", ResponseNamespace:="http://ransa.biz/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function getFileExtension(ByVal Carpeta As String, ByVal Nombre As String) As String
            Dim results() As Object = Me.Invoke("getFileExtension", New Object() {Carpeta, Nombre})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub getFileExtensionAsync(ByVal Carpeta As String, ByVal Nombre As String)
            Me.getFileExtensionAsync(Carpeta, Nombre, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub getFileExtensionAsync(ByVal Carpeta As String, ByVal Nombre As String, ByVal userState As Object)
            If (Me.getFileExtensionOperationCompleted Is Nothing) Then
                Me.getFileExtensionOperationCompleted = AddressOf Me.OngetFileExtensionOperationCompleted
            End If
            Me.InvokeAsync("getFileExtension", New Object() {Carpeta, Nombre}, Me.getFileExtensionOperationCompleted, userState)
        End Sub
        
        Private Sub OngetFileExtensionOperationCompleted(ByVal arg As Object)
            If (Not (Me.getFileExtensionCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent getFileExtensionCompleted(Me, New getFileExtensionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://ransa.biz/CambiarNombre", RequestNamespace:="http://ransa.biz/", ResponseNamespace:="http://ransa.biz/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function CambiarNombre(ByVal carpeta As String, ByVal origen As String, ByVal destino As String) As Boolean
            Dim results() As Object = Me.Invoke("CambiarNombre", New Object() {carpeta, origen, destino})
            Return CType(results(0),Boolean)
        End Function
        
        '''<remarks/>
        Public Overloads Sub CambiarNombreAsync(ByVal carpeta As String, ByVal origen As String, ByVal destino As String)
            Me.CambiarNombreAsync(carpeta, origen, destino, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub CambiarNombreAsync(ByVal carpeta As String, ByVal origen As String, ByVal destino As String, ByVal userState As Object)
            If (Me.CambiarNombreOperationCompleted Is Nothing) Then
                Me.CambiarNombreOperationCompleted = AddressOf Me.OnCambiarNombreOperationCompleted
            End If
            Me.InvokeAsync("CambiarNombre", New Object() {carpeta, origen, destino}, Me.CambiarNombreOperationCompleted, userState)
        End Sub
        
        Private Sub OnCambiarNombreOperationCompleted(ByVal arg As Object)
            If (Not (Me.CambiarNombreCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent CambiarNombreCompleted(Me, New CambiarNombreCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
        
        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing)  _
                        OrElse (url Is String.Empty)) Then
                Return false
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024)  _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return true
            End If
            Return false
        End Function
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")>  _
    Public Delegate Sub GuardarImagenCompletedEventHandler(ByVal sender As Object, ByVal e As GuardarImagenCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class GuardarImagenCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Boolean
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Boolean)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")>  _
    Public Delegate Sub ExisteImagenCompletedEventHandler(ByVal sender As Object, ByVal e As ExisteImagenCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class ExisteImagenCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Boolean
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Boolean)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")>  _
    Public Delegate Sub getImageCompletedEventHandler(ByVal sender As Object, ByVal e As getImageCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class getImageCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Object
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Object)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")>  _
    Public Delegate Sub getFileExtensionCompletedEventHandler(ByVal sender As Object, ByVal e As getFileExtensionCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class getFileExtensionCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")>  _
    Public Delegate Sub CambiarNombreCompletedEventHandler(ByVal sender As Object, ByVal e As CambiarNombreCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class CambiarNombreCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Boolean
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Boolean)
            End Get
        End Property
    End Class
End Namespace
