Imports SOLMIN_CTZ.NEGOCIO.operaciones
Imports SOLMIN_CTZ.ENTIDADES.Operaciones

Public Class frmOperacionesXPreFactura


#Region "Variables"
    Private _odtListLote As DataTable
    Private _strLote As String
#End Region

#Region "Properties"

    Private _PNCCLNT As Decimal
    Public Property PNCCLNT() As Decimal
        Get
            Return _PNCCLNT
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
        End Set
    End Property


    Private _PSCCMPN As String
    Public Property PSCCMPN() As String
        Get
            Return _PSCCMPN
        End Get
        Set(ByVal value As String)
            _PSCCMPN = value
        End Set
    End Property


    Private _PSCDVSN As String
    Public Property PSCDVSN() As String
        Get
            Return _PSCDVSN
        End Get
        Set(ByVal value As String)
            _PSCDVSN = value
        End Set
    End Property


    Private _PNNPRLQD As Decimal
    Public Property PNNPRLQD() As Decimal
        Get
            Return _PNNPRLQD
        End Get
        Set(ByVal value As Decimal)
            _PNNPRLQD = value
        End Set
    End Property


    Private _PNNDCPRF As Decimal
    Public Property PNNDCPRF() As Decimal
        Get
            Return _PNNDCPRF
        End Get
        Set(ByVal value As Decimal)
            _PNNDCPRF = value
        End Set
    End Property
#End Region

    Private Sub frmlotefactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.gwdDatos.AutoGenerateColumns = False
        Dim fact As New Factura_Transporte_BLL
        Me.gwdDatos.AutoGenerateColumns = False
        Dim obj_Logica As New PreLiquidacion_BLL
        Dim objParam As New Hashtable
        objParam.Add("PNCCLNT", Me.PNCCLNT)
        objParam.Add("PSCCMPN", Me.PSCCMPN)
        objParam.Add("PSCDVSN", Me.PSCDVSN)
        If _PNNPRLQD <> 0 Then
            objParam.Add("PNNPRLQD", Me.PNNPRLQD)
            Me.gwdDatos.DataSource = obj_Logica.Listar_Operaciones_PreLiquidacion(objParam)
        Else
            objParam.Add("PNNDCPRF", Me.PNNDCPRF)
            Me.gwdDatos.DataSource = obj_Logica.Listar_Operaciones_PreFactura(objParam)
        End If
    End Sub

    Private Sub btnCancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

End Class
