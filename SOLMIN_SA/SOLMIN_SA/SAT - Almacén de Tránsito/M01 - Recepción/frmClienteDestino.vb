Public Class frmClienteDestino
#Region "Atributos"

#End Region
#Region "Propiedades"
    ' Se proporciona el Codigo del Cliente 
    Public ReadOnly Property pintCodigoCliente_CCLNT() As Int64
        Get
            Return txtCliente.pCodigo
        End Get
    End Property
    ' Se proporciona la Razón Social del Cliente
    Public ReadOnly Property pstrRazonSocial_TCMPCL() As String
        Get
            Return txtCliente.pRazonSocial
        End Get
    End Property
#End Region
#Region " Procedimientos y Funciones "

#End Region
#Region " Eventos "
    Private Sub frmClienteDestino_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCliente.pUsuario = objSeguridadBN.pUsuario
    End Sub
#End Region
#Region " Métodos "

#End Region
End Class
