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

'
'Este código fuente fue generado automáticamente por wsdl, Versión=2.0.50727.42.
'
Namespace ProxyRansa.EnvioDespachos
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="SI_EnvioDespachos_Ransa_OutBinding", [Namespace]:="http://vm.milpo.ransa.enviodespachos")>  _
    Partial Public Class SI_EnvioDespachos_Ransa_OutService
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private SI_EnvioDespachos_Ransa_OutOperationCompleted As System.Threading.SendOrPostCallback
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = "http://vidpi301.votorantim.grupo:50000/XISOAPAdapter/MessageServlet?senderParty=P"& _ 
                "Y_MILPO_RANSA&senderService=BC_RANSA_SERVICES&receiverParty=&receiverService=&in"& _ 
                "terface=SI_EnvioDespachos_Ransa_Out&interfaceNamespace=http%3A%2F%2Fvm.milpo.ran"& _ 
                "sa.enviodespachos"
        End Sub
        
        '''<remarks/>
        Public Event SI_EnvioDespachos_Ransa_OutCompleted As SI_EnvioDespachos_Ransa_OutCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://sap.com/xi/WebService/soap1.1", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Bare)>  _
        Public Function SI_EnvioDespachos_Ransa_Out(<System.Xml.Serialization.XmlElementAttribute([Namespace]:="http://vm.milpo.ransa.enviodespachos")> ByVal MT_EnvioDespachos_Ransa_Request As DT_EnvioDespachos) As <System.Xml.Serialization.XmlArrayAttribute("MT_EnvioDespachos_Ransa_Response", [Namespace]:="http://vm.milpo.ransa.enviodespachos"), System.Xml.Serialization.XmlArrayItemAttribute("Return", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=false)> DT_RespuestaEnvioDespachosReturn()
            Dim results() As Object = Me.Invoke("SI_EnvioDespachos_Ransa_Out", New Object() {MT_EnvioDespachos_Ransa_Request})
            Return CType(results(0),DT_RespuestaEnvioDespachosReturn())
        End Function
        
        '''<remarks/>
        Public Function BeginSI_EnvioDespachos_Ransa_Out(ByVal MT_EnvioDespachos_Ransa_Request As DT_EnvioDespachos, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("SI_EnvioDespachos_Ransa_Out", New Object() {MT_EnvioDespachos_Ransa_Request}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndSI_EnvioDespachos_Ransa_Out(ByVal asyncResult As System.IAsyncResult) As DT_RespuestaEnvioDespachosReturn()
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),DT_RespuestaEnvioDespachosReturn())
        End Function
        
        '''<remarks/>
        Public Overloads Sub SI_EnvioDespachos_Ransa_OutAsync(ByVal MT_EnvioDespachos_Ransa_Request As DT_EnvioDespachos)
            Me.SI_EnvioDespachos_Ransa_OutAsync(MT_EnvioDespachos_Ransa_Request, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SI_EnvioDespachos_Ransa_OutAsync(ByVal MT_EnvioDespachos_Ransa_Request As DT_EnvioDespachos, ByVal userState As Object)
            If (Me.SI_EnvioDespachos_Ransa_OutOperationCompleted Is Nothing) Then
                Me.SI_EnvioDespachos_Ransa_OutOperationCompleted = AddressOf Me.OnSI_EnvioDespachos_Ransa_OutOperationCompleted
            End If
            Me.InvokeAsync("SI_EnvioDespachos_Ransa_Out", New Object() {MT_EnvioDespachos_Ransa_Request}, Me.SI_EnvioDespachos_Ransa_OutOperationCompleted, userState)
        End Sub
        
        Private Sub OnSI_EnvioDespachos_Ransa_OutOperationCompleted(ByVal arg As Object)
            If (Not (Me.SI_EnvioDespachos_Ransa_OutCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SI_EnvioDespachos_Ransa_OutCompleted(Me, New SI_EnvioDespachos_Ransa_OutCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
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
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://vm.milpo.ransa.enviodespachos")>  _
    Partial Public Class DT_EnvioDespachos
        
        Private nUMTRAField As String
        
        Private fECTRAField As String
        
        Private rUC_TRANSPORTEField As String
        
        Private pLACA_VEHICULOField As String
        
        Private cOD_BREVETEField As String
        
        Private nOM_CONDUCTORField As String
        
        Private tXT_ORGField As String
        
        Private tXT_DESField As String
        
        Private cABECERA_GRField() As DT_CabGRITEMS_CABGR
        
        Private cABECERA_BULTOField() As DT_CabBultoITEMS_CABBULTO
        
        Private iTEMField() As DT_ItemsITEMS
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property NUMTRA() As String
            Get
                Return Me.nUMTRAField
            End Get
            Set
                Me.nUMTRAField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property FECTRA() As String
            Get
                Return Me.fECTRAField
            End Get
            Set
                Me.fECTRAField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property RUC_TRANSPORTE() As String
            Get
                Return Me.rUC_TRANSPORTEField
            End Get
            Set
                Me.rUC_TRANSPORTEField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property PLACA_VEHICULO() As String
            Get
                Return Me.pLACA_VEHICULOField
            End Get
            Set
                Me.pLACA_VEHICULOField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property COD_BREVETE() As String
            Get
                Return Me.cOD_BREVETEField
            End Get
            Set
                Me.cOD_BREVETEField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property NOM_CONDUCTOR() As String
            Get
                Return Me.nOM_CONDUCTORField
            End Get
            Set
                Me.nOM_CONDUCTORField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property TXT_ORG() As String
            Get
                Return Me.tXT_ORGField
            End Get
            Set
                Me.tXT_ORGField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property TXT_DES() As String
            Get
                Return Me.tXT_DESField
            End Get
            Set
                Me.tXT_DESField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlArrayAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified),  _
         System.Xml.Serialization.XmlArrayItemAttribute("ITEMS_CABGR", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=false)>  _
        Public Property CABECERA_GR() As DT_CabGRITEMS_CABGR()
            Get
                Return Me.cABECERA_GRField
            End Get
            Set
                Me.cABECERA_GRField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlArrayAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified),  _
         System.Xml.Serialization.XmlArrayItemAttribute("ITEMS_CABBULTO", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=false)>  _
        Public Property CABECERA_BULTO() As DT_CabBultoITEMS_CABBULTO()
            Get
                Return Me.cABECERA_BULTOField
            End Get
            Set
                Me.cABECERA_BULTOField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlArrayAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified),  _
         System.Xml.Serialization.XmlArrayItemAttribute("ITEMS", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=false)>  _
        Public Property ITEM() As DT_ItemsITEMS()
            Get
                Return Me.iTEMField
            End Get
            Set
                Me.iTEMField = value
            End Set
        End Property
    End Class
    
    '''<comentarios/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true, [Namespace]:="http://vm.milpo.ransa.enviodespachos")>  _
    Partial Public Class DT_CabGRITEMS_CABGR
        
        Private nUMGRMField As String
        
        Private fECGRMField As String
        
        Private mOT_TRASLADOField As String
        
        Private tXT_CAB_GUIAField As String
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property NUMGRM() As String
            Get
                Return Me.nUMGRMField
            End Get
            Set
                Me.nUMGRMField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property FECGRM() As String
            Get
                Return Me.fECGRMField
            End Get
            Set
                Me.fECGRMField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property MOT_TRASLADO() As String
            Get
                Return Me.mOT_TRASLADOField
            End Get
            Set
                Me.mOT_TRASLADOField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property TXT_CAB_GUIA() As String
            Get
                Return Me.tXT_CAB_GUIAField
            End Get
            Set
                Me.tXT_CAB_GUIAField = value
            End Set
        End Property
    End Class
    
    '''<comentarios/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true, [Namespace]:="http://vm.milpo.ransa.enviodespachos")>  _
    Partial Public Class DT_CabBultoITEMS_CABBULTO
        
        Private nUMBTOField As String
        
        Private fECBTOField As String
        
        Private cANBTOField As Decimal
        
        Private cANBTOFieldSpecified As Boolean
        
        Private tIPBTOField As String
        
        Private pSOBTOField As Decimal
        
        Private pSOBTOFieldSpecified As Boolean
        
        Private tINDField As String
        
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
        Public Property FECBTO() As String
            Get
                Return Me.fECBTOField
            End Get
            Set
                Me.fECBTOField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property CANBTO() As Decimal
            Get
                Return Me.cANBTOField
            End Get
            Set
                Me.cANBTOField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property CANBTOSpecified() As Boolean
            Get
                Return Me.cANBTOFieldSpecified
            End Get
            Set
                Me.cANBTOFieldSpecified = value
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
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property PSOBTO() As Decimal
            Get
                Return Me.pSOBTOField
            End Get
            Set
                Me.pSOBTOField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property PSOBTOSpecified() As Boolean
            Get
                Return Me.pSOBTOFieldSpecified
            End Get
            Set
                Me.pSOBTOFieldSpecified = value
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
    End Class
    
    '''<comentarios/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true, [Namespace]:="http://vm.milpo.ransa.enviodespachos")>  _
    Partial Public Class DT_ItemsITEMS
        
        Private ocField As String
        
        Private oC_POSField As String
        
        Private mATERIALField As String
        
        Private cENTRO_ORIGField As String
        
        Private aLMACEN_ORIGField As String
        
        Private cENTRO_DESTField As String
        
        Private aLMACEN_DESTField As String
        
        Private cANTIDADField As Decimal
        
        Private cANTIDADFieldSpecified As Boolean
        
        Private uMEDIDAField As String
        
        Private tXT_DET_GUIAField As String
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property OC() As String
            Get
                Return Me.ocField
            End Get
            Set
                Me.ocField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType:="integer")>  _
        Public Property OC_POS() As String
            Get
                Return Me.oC_POSField
            End Get
            Set
                Me.oC_POSField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property MATERIAL() As String
            Get
                Return Me.mATERIALField
            End Get
            Set
                Me.mATERIALField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property CENTRO_ORIG() As String
            Get
                Return Me.cENTRO_ORIGField
            End Get
            Set
                Me.cENTRO_ORIGField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property ALMACEN_ORIG() As String
            Get
                Return Me.aLMACEN_ORIGField
            End Get
            Set
                Me.aLMACEN_ORIGField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property CENTRO_DEST() As String
            Get
                Return Me.cENTRO_DESTField
            End Get
            Set
                Me.cENTRO_DESTField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property ALMACEN_DEST() As String
            Get
                Return Me.aLMACEN_DESTField
            End Get
            Set
                Me.aLMACEN_DESTField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property CANTIDAD() As Decimal
            Get
                Return Me.cANTIDADField
            End Get
            Set
                Me.cANTIDADField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property CANTIDADSpecified() As Boolean
            Get
                Return Me.cANTIDADFieldSpecified
            End Get
            Set
                Me.cANTIDADFieldSpecified = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property UMEDIDA() As String
            Get
                Return Me.uMEDIDAField
            End Get
            Set
                Me.uMEDIDAField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property TXT_DET_GUIA() As String
            Get
                Return Me.tXT_DET_GUIAField
            End Get
            Set
                Me.tXT_DET_GUIAField = value
            End Set
        End Property
    End Class
    
    '''<comentarios/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true, [Namespace]:="http://vm.milpo.ransa.enviodespachos")>  _
    Partial Public Class DT_RespuestaEnvioDespachosReturn
        
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
    Public Delegate Sub SI_EnvioDespachos_Ransa_OutCompletedEventHandler(ByVal sender As Object, ByVal e As SI_EnvioDespachos_Ransa_OutCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class SI_EnvioDespachos_Ransa_OutCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As DT_RespuestaEnvioDespachosReturn()
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),DT_RespuestaEnvioDespachosReturn())
            End Get
        End Property
    End Class
End Namespace
