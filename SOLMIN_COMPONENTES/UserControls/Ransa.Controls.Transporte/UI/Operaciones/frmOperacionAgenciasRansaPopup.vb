
Imports Ransa.Utilitario
Imports System.Collections
Imports System.Data
Imports System.Windows.Forms

Public Class frmOperacionAgenciasRansaPopup

    Private _codigo_cliente As String
    Private _OsAgencias As String
    Private _OperacionAgencias As String

    Public Property Operacion_Agencias() As String
        Get
            Return _OperacionAgencias
        End Get
        Set(ByVal value As String)
            _OperacionAgencias = value
        End Set
    End Property

    Public Property OrdenServio_AgenciasRansa() As String
        Get
            Return _OsAgencias
        End Get
        Set(ByVal value As String)
            _OsAgencias = value
        End Set
    End Property

    Public Property Codigo_Cliente() As String
        Get
            Return _codigo_cliente
        End Get
        Set(ByVal value As String)
            _codigo_cliente = value
        End Set
    End Property

    Private Sub Procesar_Busqueda(ByVal sender As Object)

        Dim validacion As String = ""
        Dim objVistaDatos As New Data.DataView
        Dim objTablaDatos As New Data.DataTable
        Dim objLista As New List(Of String)
        Dim objOrdenServicio As New OrdenServicioAgenciaRansa_BLL()

        objLista.Add(Me.txtClienteFiltro.pCodigo)
        objLista.Add(Me.txtOrdenServicio.Text)
        objLista.Add("FZ")
        objLista.Add("A")
        objLista.Add(1)
        objLista.Add(1)

        If TypeOf sender Is ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup Then
            objLista.Add(HelpClass.DateConvert(Me.dtpFechaInicio.Value))
            objLista.Add(HelpClass.DateConvert(Me.dtpFechaFin.Value))
        End If

        objTablaDatos = objOrdenServicio.Listar_Ordenes_Servicio_Agencia_Ransa(objLista)

        If objTablaDatos.Rows.Count <= 0 Then
            Exit Sub
        Else
            Me.dtgDatos.DataSource = objTablaDatos
            Formato_Grilla_Busqueda()
        End If

    End Sub

    Private Sub Formato_Grilla_Busqueda()
        Me.dtgDatos.Columns(0).HeaderText = "Orden Servicio"
        Me.dtgDatos.Columns(1).HeaderText = "Fecha Registro "
        Me.dtgDatos.Columns(2).HeaderText = "Operación"
        Me.dtgDatos.Columns(3).HeaderText = "Cliente"
        Me.dtgDatos.Columns(4).HeaderText = "Referencia"
        Me.dtgDatos.Columns(5).HeaderText = "Producto"
        Me.dtgDatos.Columns(6).HeaderText = "Regimen Aduana"
        Me.dtgDatos.Columns(7).HeaderText = "Tipo Operacion"
        Me.dtgDatos.Columns(8).HeaderText = "Observaciones"
        Me.dtgDatos.Columns(9).HeaderText = "Cod Régimen"
        Me.dtgDatos.Columns(10).HeaderText = "Cod Operación"
        Me.dtgDatos.Columns(11).HeaderText = "Transaccion"
        Me.dtgDatos.Columns(12).HeaderText = "Estado"
    End Sub

    Private Sub btnProcesarBusqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarBusqueda.Click
        Procesar_Busqueda(sender)
    End Sub

    Private Sub txtOrdenServicio_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOrdenServicio.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.Procesar_Busqueda(sender)
        End If
    End Sub

    Private Sub frmOperacionAgenciasRansaPopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Procesar_Busqueda(sender)
    End Sub

    Private Sub btnAsignarOrdenServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignarOrdenServicio.Click
        Me.Mostar_Orden_Agencias()
    End Sub

    Private Sub Mostar_Orden_Agencias()

        If Me.dtgDatos.CurrentCellAddress.Y < 0 Then
            Exit Sub
        End If

        'obteniendo el indice de la fila seleccionada
        Dim indice As Integer = Me.dtgDatos.CurrentCellAddress.Y
        Dim lstr_ordenservicio_agencias As String = Me.dtgDatos.Item(0, indice).Value
        Dim lstr_operacion_agencias As String = Me.dtgDatos.Item(11, indice).Value

        Me._OperacionAgencias = lstr_operacion_agencias
        Me._OsAgencias = lstr_ordenservicio_agencias

        Me.Close()

    End Sub

    Private Sub dtgDatos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgDatos.CellDoubleClick

        If Me.dtgDatos.RowCount <= 0 Then
            Exit Sub
        End If

        If e.RowIndex < 0 Then
            Exit Sub
        End If

        Me.Mostar_Orden_Agencias()

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

End Class
