Imports Ransa.NEGO
Imports Ransa.DATA
Imports System.Data
Imports Ransa.Utilitario
Imports Ransa.TypeDef

Public Class frmObservacionesPedido

    Dim olDatos As New List(Of beObservacionPedido)
    Dim objLista As New List(Of beObservacionPedido)
    Dim objTemporal As New List(Of ObservacionPedido)
    Dim _CodigoMercaderia As String = ""
    Dim _NombreMercaderia As String = ""
    Dim _CantidadMercaderia As String = ""
    Dim _tipooperacion As String = ""
    Dim _NroPedido As String = ""
    Dim _NroCorrelativo As String = ""

    Public Property TipoOperacion() As String
        Get
            Return _tipooperacion
        End Get
        Set(ByVal value As String)
            _tipooperacion = value.Trim
        End Set
    End Property

    Public Property CodigoMercaderia() As String
        Get
            Return _CodigoMercaderia
        End Get
        Set(ByVal value As String)
            _CodigoMercaderia = value.Trim
        End Set
    End Property

    Public Property NombreMercaderia() As String
        Get
            Return _NombreMercaderia
        End Get
        Set(ByVal value As String)
            _NombreMercaderia = value.Trim
        End Set
    End Property

    Public Property CantidadMercaderia() As String
        Get
            Return _CantidadMercaderia
        End Get
        Set(ByVal value As String)
            _CantidadMercaderia = value.Trim
        End Set
    End Property

    Public Property NroCorrelativo() As String
        Get
            Return _NroCorrelativo
        End Get
        Set(ByVal value As String)
            _NroCorrelativo = value
        End Set
    End Property

    Public Property NroPedido() As String
        Get
            Return _NroPedido
        End Get
        Set(ByVal value As String)
            _NroPedido = value
        End Set
    End Property

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Public Property getData() As List(Of beObservacionPedido)
        Get
            Return objLista
        End Get
        Set(ByVal value As List(Of beObservacionPedido))
            objLista = value
        End Set
    End Property


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        BeObservacionPedidoBindingSource.EndEdit()
        If TipoOperacion <> "Nuevo" Then

            Dim obrObj As New brObservacionesPedido
            Dim obeObj As New beObservacionPedido
            obeObj.PNCDPEPL = NroPedido
            obeObj.PNCDREGP = NroCorrelativo
      If obrObj.fintEliminar_Observaciones_Pedido(obeObj) = 1 Then

        Dim olbeFiltro As New List(Of RANSA.TypeDef.beObservacionPedido)

        For Each obePedido As RANSA.TypeDef.beObservacionPedido In Me.dtgDatos.DataSource

          'If obePedido.PSTOBSGS.Trim <> "" Then
          obePedido.PNCDPEPL = NroPedido
          obePedido.PNCDREGP = NroCorrelativo
          obePedido.PSUSUARIO = objSeguridadBN.pUsuario
          olbeFiltro.Add(obePedido)
          'End If

        Next
        obrObj.fintRegistrarObeservaciones(olbeFiltro)
      Else
        HelpClass.ErrorMsgBox()
        Exit Sub
      End If
    Else
      Dim olbeFiltro As New List(Of RANSA.TypeDef.beObservacionPedido)
      For Each obePedido As RANSA.TypeDef.beObservacionPedido In Me.dtgDatos.DataSource
        olbeFiltro.Add(obePedido)
      Next
      getData = olbeFiltro
    End If
    Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub frmObservacionesPedido_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.txtMercaderia.Text = Me.NombreMercaderia
        Me.txtCantidad.Text = Me.CantidadMercaderia
        Dim objObservaciones As New brObservacionesPedido
        Dim objEntidad As New beObservacionPedido
        If TipoOperacion <> "Nuevo" Then
            'obteniendo los datos del pedido y del item
            objEntidad.PNCDPEPL = NroPedido
            objEntidad.PNCDREGP = NroCorrelativo
            BeObservacionPedidoBindingSource.DataSource = objObservaciones.Listado_Observaciones(objEntidad)
        Else
            If getData() IsNot Nothing Then
                BeObservacionPedidoBindingSource.DataSource = getData()
            End If

        End If
    End Sub
 
End Class
