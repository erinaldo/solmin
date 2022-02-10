Imports Ransa.NEGO
Imports RANSA.TypeDef
Imports RANSA.Utilitario

Public Class frmPuntoDeControlCheckpoinMasivo
#Region "Propiedades y Atributos"



    Private _ParamCheckPoint As beCheckPoint

    Public Property ParamCheckPoint() As beCheckPoint
        Get
            Return _ParamCheckPoint
        End Get
        Set(ByVal value As beCheckPoint)
            _ParamCheckPoint = value
        End Set
    End Property

    Private _CodCliente As Double
    ''' <summary>
    ''' Código del Cliente
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property CodCliente() As Double
        Get
            Return _CodCliente
        End Get
        Set(ByVal value As Double)
            _CodCliente = value
        End Set
    End Property

    Private _olpbebeOrdenCompra As List(Of beOrdenCompra)

    ''' <summary>
    ''' Lista de Guia de Remision al que se va hacer seguimiento 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property olpbeOrdenCompra() As List(Of beOrdenCompra)
        Get
            Return _olpbebeOrdenCompra
        End Get
        Set(ByVal value As List(Of beOrdenCompra))
            _olpbebeOrdenCompra = value
        End Set
    End Property

#End Region

#Region "Eventos"

    Private Sub frmPuntoDeControlCheckpoinMasivo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarCheckpoint()
        CargarListaGuiaRemision()

    End Sub

    Private Sub tsbGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGrabar.Click
        If ValidarDatos() Then
            GuardarCheckpointPorGuiaRemision()
        End If
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

#End Region

#Region "Metodos"
    ''' <summary>
    ''' Cargar Lista de Checkpoint por cliente
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarCheckpoint()
        Dim obrCheckpoint As New brCheckPoint
        Dim obeCheckpoint As New beCheckPoint
        With obeCheckpoint
            .PNCCLNT = ParamCheckPoint.PNCCLNT
            .PSCCMPN = ParamCheckPoint.PSCCMPN
            .PSCDVSN = ParamCheckPoint.PSCDVSN
            .PSCEMB = ""
        End With
        Me.cmbCheckpoint.DataSource = obrCheckpoint.Lista_CheckPoint_X_Cliente(obeCheckpoint)
        cmbCheckpoint.ValueMember = "PNNESTDO"
        cmbCheckpoint.DisplayMember = "PSTDESES"

    End Sub

    ''' <summary>
    ''' Carga Lista de Guia de remisión
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarListaGuiaRemision()
        dgItemOC.AutoGenerateColumns = False
        dgItemOC.DataSource = _olpbebeOrdenCompra
    End Sub

    ''' <summary>
    ''' Guardar Checkpoint de Guia Remision
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GuardarCheckpointPorGuiaRemision()

        Dim obrCheckpoint As New brCheckPoint
        Dim obeCheckpoint As beCheckPoint
        For Each obeItemOc As beOrdenCompra In Me.dgItemOC.DataSource
            obeCheckpoint = New beCheckPoint
            With obeCheckpoint
                .PNCCLNT = ParamCheckPoint.PNCCLNT
                .PSNORCML = ParamCheckPoint.PSNORCML
                .PNNRITOC = obeItemOc.PNNRITOC
                .PNNESTDO = Me.cmbCheckpoint.SelectedValue
                .PSUSUARIO = objSeguridadBN.pUsuario
                .PSSESTRG = "A"
                .PSFECESTIMADA = IIf(Me.dtpFechaEstimada.Checked, Me.dtpFechaEstimada.Value, "")
                .PSFECREAL = IIf(Me.dtpFechaReal.Checked, Me.dtpFechaReal.Value, "")
                .PSTOBEST = Me.txtObs.Text
            End With
            If obrCheckpoint.InsertarCheckPointXItemDeOc(obeCheckpoint) = 0 Then
                HelpClass.ErrorMsgBox()
                Exit Sub
            End If
        Next
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Function ValidarDatos() As Boolean
        If Not Me.dtpFechaEstimada.Checked And Not Me.dtpFechaReal.Checked And Me.txtObs.Text.Trim.Equals("") Then
            HelpClass.MsgBox("Registre Datos validos")
            Return False
        End If
        Return True
    End Function
#End Region



    
End Class
