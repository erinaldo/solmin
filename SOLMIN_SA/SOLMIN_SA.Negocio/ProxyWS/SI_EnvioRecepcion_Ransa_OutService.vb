﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión del motor en tiempo de ejecución:2.0.50727.5483
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
Imports Db2Manager.RansaData.iSeries.DataObjects

'
'Este código fuente fue generado automáticamente por wsdl, Versión=2.0.50727.42.
'
Namespace ProxyRansa.EnvioRecepcion
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="SI_EnvioRecepcion_Ransa_OutBinding", [Namespace]:="http://vm.milpo.ransa.enviorecepcion")>  _
    Partial Public Class SI_EnvioRecepcion_Ransa_OutService
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private SI_EnvioRecepcion_Ransa_OutOperationCompleted As System.Threading.SendOrPostCallback
        
        '''<remarks/>
        Public Sub New()
            If ConfigurationWizard.Server = "RANSAT01" Or ConfigurationWizard.Server = "RANSA01" Then
                Me.Url = "http://integracion.gromero.com.pe/milpo/qas/ConfirmacionRecepcion"
                Me.Credentials = New System.Net.NetworkCredential("XMPIRANSA", "b)W$(Gf~%$3]S>i$RewV6[znpGX%9ip[zgQHqUY}")

            Else
                Me.Url = "http://integracion.gromero.com.pe/milpo/prd/ConfirmacionRecepcion"
                Me.Credentials = New System.Net.NetworkCredential("XMPIRANSA", "b)W$(Gf~%$3]S>i$RewV6[znpGX%9ip[zgQHqUY}")

            End If


        End Sub
        
        '''<remarks/>
        Public Event SI_EnvioRecepcion_Ransa_OutCompleted As SI_EnvioRecepcion_Ransa_OutCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://sap.com/xi/WebService/soap1.1", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Bare)>  _
        Public Function SI_EnvioRecepcion_Ransa_Out(<System.Xml.Serialization.XmlElementAttribute([Namespace]:="http://vm.milpo.ransa.enviorecepcion")> ByVal MT_EnvioRecepcion_Ransa_Request As DT_EnvioRecepcion) As <System.Xml.Serialization.XmlArrayAttribute("MT_EnvioRecepcion_Ransa_Response", [Namespace]:="http://vm.milpo.ransa.enviorecepcion"), System.Xml.Serialization.XmlArrayItemAttribute("Return", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=false)> DT_RespuestEnvioRecepcionReturn()
            Dim results() As Object = Me.Invoke("SI_EnvioRecepcion_Ransa_Out", New Object() {MT_EnvioRecepcion_Ransa_Request})
            Return CType(results(0),DT_RespuestEnvioRecepcionReturn())
        End Function
        
        '''<remarks/>
        Public Function BeginSI_EnvioRecepcion_Ransa_Out(ByVal MT_EnvioRecepcion_Ransa_Request As DT_EnvioRecepcion, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("SI_EnvioRecepcion_Ransa_Out", New Object() {MT_EnvioRecepcion_Ransa_Request}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndSI_EnvioRecepcion_Ransa_Out(ByVal asyncResult As System.IAsyncResult) As DT_RespuestEnvioRecepcionReturn()
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),DT_RespuestEnvioRecepcionReturn())
        End Function
        
        '''<remarks/>
        Public Overloads Sub SI_EnvioRecepcion_Ransa_OutAsync(ByVal MT_EnvioRecepcion_Ransa_Request As DT_EnvioRecepcion)
            Me.SI_EnvioRecepcion_Ransa_OutAsync(MT_EnvioRecepcion_Ransa_Request, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SI_EnvioRecepcion_Ransa_OutAsync(ByVal MT_EnvioRecepcion_Ransa_Request As DT_EnvioRecepcion, ByVal userState As Object)
            If (Me.SI_EnvioRecepcion_Ransa_OutOperationCompleted Is Nothing) Then
                Me.SI_EnvioRecepcion_Ransa_OutOperationCompleted = AddressOf Me.OnSI_EnvioRecepcion_Ransa_OutOperationCompleted
            End If
            Me.InvokeAsync("SI_EnvioRecepcion_Ransa_Out", New Object() {MT_EnvioRecepcion_Ransa_Request}, Me.SI_EnvioRecepcion_Ransa_OutOperationCompleted, userState)
        End Sub
        
        Private Sub OnSI_EnvioRecepcion_Ransa_OutOperationCompleted(ByVal arg As Object)
            If (Not (Me.SI_EnvioRecepcion_Ransa_OutCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SI_EnvioRecepcion_Ransa_OutCompleted(Me, New SI_EnvioRecepcion_Ransa_OutCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
    End Class
    
    '''<comentarios/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://vm.milpo.ransa.enviorecepcion")>  _
    Partial Public Class DT_EnvioRecepcion
        
        Private nUMBTOField As String
        
        Private fECDOCField As String
        
        Private fECCDOCField As String
        
        Private rEFDOCField As String
        
        Private cANBTOField As String
        
        Private tIPBTOField As String
        
        Private pSOBTOField As String
        
        Private tINDField As String
        
        Private iTEMField() As DT_ItemsITEMS
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property NUMBTO() As String
            Get
                Return Me.nUMBTOField
            End Get
            Set
                Me.nUMBTOField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property FECDOC() As String
            Get
                Return Me.fECDOCField
            End Get
            Set
                Me.fECDOCField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property FECCDOC() As String
            Get
                Return Me.fECCDOCField
            End Get
            Set
                Me.fECCDOCField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property REFDOC() As String
            Get
                Return Me.rEFDOCField
            End Get
            Set
                Me.rEFDOCField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType:="integer")>  _
        Public Property CANBTO() As String
            Get
                Return Me.cANBTOField
            End Get
            Set
                Me.cANBTOField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property TIPBTO() As String
            Get
                Return Me.tIPBTOField
            End Get
            Set
                Me.tIPBTOField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType:="integer")>  _
        Public Property PSOBTO() As String
            Get
                Return Me.pSOBTOField
            End Get
            Set
                Me.pSOBTOField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property TIND() As String
            Get
                Return Me.tINDField
            End Get
            Set
                Me.tINDField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlArrayAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified), _
         System.Xml.Serialization.XmlArrayItemAttribute("ITEMS", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=False)> _
        Public Property ITEM() As DT_ItemsITEMS()
            Get
                Return Me.iTEMField
            End Get
            Set(ByVal value As DT_ItemsITEMS())
                Me.iTEMField = value
            End Set
        End Property
    End Class
    
    ''<comentarios/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://vm.milpo.ransa.enviorecepcion")> _
    Partial Public Class DT_ItemsITEMS

        Private ocField As String

        Private oC_POSField As String

        Private mATERIALField As String

        Private cENTROField As String

        Private aLMACENField As String

        Private cANTIDADField As Decimal

        Private cANTIDADFieldSpecified As Boolean

        Private uMEDIDAField As String

        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)> _
        Public Property OC() As String
            Get
                Return Me.ocField
            End Get
            Set(ByVal value As String)
                Me.ocField = value
            End Set
        End Property

        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType:="integer")> _
        Public Property OC_POS() As String
            Get
                Return Me.oC_POSField
            End Get
            Set(ByVal value As String)
                Me.oC_POSField = value
            End Set
        End Property

        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)> _
        Public Property MATERIAL() As String
            Get
                Return Me.mATERIALField
            End Get
            Set(ByVal value As String)
                Me.mATERIALField = value
            End Set
        End Property

        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)> _
        Public Property CENTRO() As String
            Get
                Return Me.cENTROField
            End Get
            Set(ByVal value As String)
                Me.cENTROField = value
            End Set
        End Property

        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)> _
        Public Property ALMACEN() As String
            Get
                Return Me.aLMACENField
            End Get
            Set(ByVal value As String)
                Me.aLMACENField = value
            End Set
        End Property

        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)> _
        Public Property CANTIDAD() As Decimal
            Get
                Return Me.cANTIDADField
            End Get
            Set(ByVal value As Decimal)
                Me.cANTIDADField = value
            End Set
        End Property

        '''<comentarios/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public Property CANTIDADSpecified() As Boolean
            Get
                Return Me.cANTIDADFieldSpecified
            End Get
            Set(ByVal value As Boolean)
                Me.cANTIDADFieldSpecified = value
            End Set
        End Property

        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)> _
        Public Property UMEDIDA() As String
            Get
                Return Me.uMEDIDAField
            End Get
            Set(ByVal value As String)
                Me.uMEDIDAField = value
            End Set
        End Property
    End Class
    
    '''<comentarios/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true, [Namespace]:="http://vm.milpo.ransa.enviorecepcion")>  _
    Partial Public Class DT_RespuestEnvioRecepcionReturn
        
        Private tYPEField As String
        
        Private mSGIDField As String
        
        Private nUMBERField As String
        
        Private mESSAGEField As String
        
        Private dOCNUMField As String
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property TYPE() As String
            Get
                Return Me.tYPEField
            End Get
            Set
                Me.tYPEField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property MSGID() As String
            Get
                Return Me.mSGIDField
            End Get
            Set
                Me.mSGIDField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType:="integer")>  _
        Public Property NUMBER() As String
            Get
                Return Me.nUMBERField
            End Get
            Set
                Me.nUMBERField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property MESSAGE() As String
            Get
                Return Me.mESSAGEField
            End Get
            Set
                Me.mESSAGEField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property DOCNUM() As String
            Get
                Return Me.dOCNUMField
            End Get
            Set
                Me.dOCNUMField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")>  _
    Public Delegate Sub SI_EnvioRecepcion_Ransa_OutCompletedEventHandler(ByVal sender As Object, ByVal e As SI_EnvioRecepcion_Ransa_OutCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class SI_EnvioRecepcion_Ransa_OutCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As DT_RespuestEnvioRecepcionReturn()
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),DT_RespuestEnvioRecepcionReturn())
            End Get
        End Property
    End Class
End Namespace