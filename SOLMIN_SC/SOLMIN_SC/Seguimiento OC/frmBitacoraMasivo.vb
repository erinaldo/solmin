Imports solmin_sc.Negocio
Imports SOLMIN_SC.Entidad
Imports RANSA.Utilitario

Public Class frmBitacoraMasivo
#Region "Propiedades y Atributos"


 

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
        dtpFechaEstimada.Value = Now.Date
        CargarListaGuiaRemision()

    End Sub

    Private Sub tsbGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGrabar.Click
        If ValidarDatos() Then
            GuardarBitacora()
        End If
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

#End Region

#Region "Metodos"
  

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
    Private Sub GuardarBitacora()

        Dim obrCheckpoint As New clsBitacora
        Dim obeCheckpoint As beBitacora
        For Each obeItemOc As beOrdenCompra In Me.dgItemOC.DataSource
            obeCheckpoint = New beBitacora
            With obeCheckpoint
                .PNCCLNT = obeItemOc.PNCCLNT
                .PSNORCML = obeItemOc.PSNORCML
                .PNNRITOC = obeItemOc.PNNRITOC
                .PSCUSCRT = HelpUtil.UserName
                .PSSESTRG = "A"
                .PNTFCOBS = Ransa.Utilitario.HelpClass.CDate_a_Numero8Digitos(Me.dtpFechaEstimada.Value)
                .PSTOBS = Me.txtObs.Text
            End With
            If obrCheckpoint.insertar_bitacora_itemOC(obeCheckpoint) = 0 Then
                HelpClass.ErrorMsgBox()
                Exit Sub
            End If
        Next
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Function ValidarDatos() As Boolean
        If Me.txtObs.Text.Trim.Equals("") Then
            HelpClass.MsgBox("Registre Datos validos")
            Return False
        End If
        Return True
    End Function
#End Region



 
End Class
