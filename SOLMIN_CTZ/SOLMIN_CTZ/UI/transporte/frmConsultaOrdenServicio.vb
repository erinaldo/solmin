Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.NEGOCIO.operaciones
Imports SOLMIN_CTZ.ENTIDADES.Operaciones

Public Class frmConsultaOrdenServicio

#Region "Atributos"
    Private objListOrdenServicioTransporteBE As New List(Of OrdenServicioTransporte)
    Private mCCMPN As String
    Private mCDVSN As String
    Private mCPLNDV As Int32
    Private mNORSRT As Int64
    Private mNCTZCN As Int64
    Private mCCLNT As String
    Private mTipoFiltro As Int16
#End Region

#Region "Properties"

    Public WriteOnly Property CCMPN() As String
        Set(ByVal value As String)
            mCCMPN = value
        End Set
    End Property

    Public WriteOnly Property CDVSN() As String
        Set(ByVal value As String)
            mCDVSN = value
        End Set
    End Property

    Public WriteOnly Property CPLNDV() As String
        Set(ByVal value As String)
            mCPLNDV = value
        End Set
    End Property

    Public WriteOnly Property TipoFiltro() As String
        Set(ByVal value As String)
            mTipoFiltro = value
        End Set
    End Property

    Public ReadOnly Property P_NCTZCN() As Int64
        Get
            Return mNCTZCN
        End Get
    End Property

    Public ReadOnly Property P_NORSRT() As Int64
        Get
            Return mNORSRT
        End Get
    End Property

    Public ReadOnly Property P_CCLNT() As String
        Get
            Return mCCLNT
        End Get
    End Property

#End Region

#Region "Eventos"

    Private Sub frmBuscarOrdenServicio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.txtCliente.pUsuario = ConfigurationWizard.UserName
        Me.txtCliente.CCMPN = mCCMPN
        Me.Alinear_Columnas_Grilla()
    End Sub

    Private Sub gdwDatos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gdwDatos.CellDoubleClick
        If Me.gdwDatos.RowCount = 0 OrElse e.RowIndex < 0 Then Exit Sub
        Me.Retornar_Valor(e.RowIndex)
    End Sub

    Private Sub gdwDatos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gdwDatos.CellClick
        If Me.gdwDatos.RowCount = 0 OrElse e.RowIndex < 0 Then Exit Sub
        Me.Seleccionar_Registro(e.RowIndex)
    End Sub

    Private Sub gdwDatos_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gdwDatos.KeyDown
        If Me.gdwDatos.RowCount = 0 OrElse Me.gdwDatos.CurrentCellAddress.Y = -1 Then Exit Sub
        Select Case e.KeyCode
            Case Keys.Up, Keys.Down, Keys.Enter
                Me.Seleccionar_Registro(Me.gdwDatos.CurrentCellAddress.Y)
        End Select
    End Sub

    Private Sub Seleccionar_Registro(ByVal lint_Registro As Integer)
        For lint_Indice As Integer = 0 To Me.gdwDatos.RowCount - 1
            If lint_Indice = lint_Registro Then
                Me.gdwDatos.Item(0, lint_Registro).Value = My.Resources.button_ok
            Else
                Me.gdwDatos.Item(0, lint_Indice).Value = My.Resources.runprog
            End If
        Next
    End Sub


#End Region

#Region "Métodos y Funciones"
    Private Sub Alinear_Columnas_Grilla()
        Me.gdwDatos.AutoGenerateColumns = False
        For lint_Contador As Integer = 0 To Me.gdwDatos.ColumnCount - 1
            Me.gdwDatos.Columns(lint_Contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub

    Private Sub Listar_Orden_Servicio()
        Dim objOrdenServicio As New Factura_Transporte_BLL
        Dim objetoParametro As New Hashtable

        objetoParametro.Add("PNCCLNT", Me.txtCliente.pCodigo)
        objetoParametro.Add("PSSESTOP", "C")
        objetoParametro.Add("PSCCMPN", Me.mCCMPN)
        objetoParametro.Add("PSCDVSN", Me.mCDVSN)
        objetoParametro.Add("PNCPLNDV", Me.mCPLNDV)
        Me.gdwDatos.DataSource = objOrdenServicio.Listar_Orden_Servicio_Facturacion(objetoParametro)
    End Sub

    Private Sub Retornar_Valor(ByVal Indice As Integer)
        If Me.mTipoFiltro = 0 Then
            Me.mNORSRT = Me.gdwDatos.Item("NORSRT", Indice).Value
        Else
            Me.mNCTZCN = Me.gdwDatos.Item("NCTZCN", Indice).Value
        End If
        Me.mCCLNT = Me.gdwDatos.Item("CCLNT", Indice).Value.ToString.Trim
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub


#End Region

    Private Sub btnBuscar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar1.Click
        If Me.txtCliente.pCodigo = 0 Then
            HelpClass.MsgBox("Falta elegir el Cliente", MessageBoxIcon.Information)
            Exit Sub
        End If
        Me.Listar_Orden_Servicio()
    End Sub

    Private Sub btnCancelar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar1.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAceptar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar1.Click
        If Me.gdwDatos.RowCount = 0 OrElse Me.gdwDatos.CurrentCellAddress.Y = -1 Then Exit Sub
        Me.Retornar_Valor(Me.gdwDatos.CurrentCellAddress.Y)

    End Sub
End Class
