Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports solmin_st.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Consultas

Public Class frmTarifaInterna

    Private logica As GuiaTransportista_BLL
    Public Sub New()
        InitializeComponent()

        logica = New GuiaTransportista_BLL()

    End Sub


    Private _BotonVisibleSAP As Boolean = True
    Public Property BotonVisibleSAP() As Boolean
        Get
            Return _BotonVisibleSAP
        End Get
        Set(ByVal value As Boolean)
            _BotonVisibleSAP = value
        End Set
    End Property


    Private _NroOperacion As Decimal
    Public Property NroOperacion() As Decimal
        Get
            Return _NroOperacion
        End Get
        Set(ByVal value As Decimal)
            _NroOperacion = value
        End Set
    End Property


    Private _NroGuiaTransporte As Decimal
    Public Property NroGuiaTransporte() As Decimal
        Get
            Return _NroGuiaTransporte
        End Get
        Set(ByVal value As Decimal)
            _NroGuiaTransporte = value
        End Set
    End Property
    
    Private _Compania As String
    Public Property Compania() As String
        Get
            Return _Compania
        End Get
        Set(ByVal value As String)
            _Compania = value
        End Set
    End Property

    Private Sub CargarLista()
        dtDatos.DataSource = Nothing
        Dim lista As List(Of AsientoCO) = logica.Listar_Asiento_CO_X_Operacion(NroOperacion, NroGuiaTransporte, Compania)
        dtDatos.DataSource = lista    
    End Sub

    

    
    Private Sub frmTarifaInterna_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dtDatos.AutoGenerateColumns = False
            dtDetalle.AutoGenerateColumns = False
            CargarLista()
            Me.toolSAP.Visible = Me.BotonVisibleSAP
        Catch ex As Exception
            MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub dtDatos_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtDatos.SelectionChanged
        Try
            If dtDatos.CurrentRow Is Nothing Then Return
            dtDetalle.DataSource = Nothing
            Dim FilaSeleccionada As AsientoCO = DirectCast(dtDatos.CurrentRow.DataBoundItem, AsientoCO)
            If FilaSeleccionada Is Nothing Then Return
            dtDetalle.DataSource = logica.Listar_AsientoDetalle_CO(FilaSeleccionada.NCRDCO, Compania)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
     
    End Sub

   
    Private Sub toolSAP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolSAP.Click
        Try

            'Validamos la fila Seleccionada.
            If dtDatos.CurrentRow Is Nothing Then Return
            Dim FilaSeleccionada As AsientoCO = DirectCast(dtDatos.CurrentRow.DataBoundItem, AsientoCO)

            If FilaSeleccionada Is Nothing Then Return

            If FilaSeleccionada.NCCSAP <> 0 Then
                Throw New InvalidOperationException("Tarifa Interna ya se encuentra enviado a SAP")
            End If

            'TODO: ---CODIGO DE REENVIO
            logica.EnviarTarifaInternaSAP(FilaSeleccionada.NCRDCO.ToString.Trim.PadLeft(10, "0"), Compania)

            CargarLista()
            If Not logica.ObtenerNumeroCO(FilaSeleccionada.NCRDCO, FilaSeleccionada.NCCSAP, Compania) Then
                Throw New InvalidOperationException("No se pudo enviar la tarifa interna a SAP")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub
End Class