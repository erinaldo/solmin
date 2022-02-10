Imports SOLMIN_ST.NEGOCIO.operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO
Imports Ransa.TypeDef.Transportista
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmAprobarMargen

#Region "Variables"

    Public _Observacion As String = ""
    Public _CCMPN As String = ""
    Public _NGUIRM As Decimal = 0
    Public _NOPRCN As Decimal = 0
    Public MargenNegativo As Boolean
    Private _IN_NMOPRP As Decimal = 0
    Public TituloForm As String = ""
    Public Accion As String = ""

#End Region

#Region "Propiedades"

    Public Property Observacion() As String
        Get
            Return _Observacion
        End Get
        Set(ByVal value As String)
            _Observacion = value
        End Set
    End Property
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property
    Public Property NGUIRM() As Decimal
        Get
            Return _NGUIRM
        End Get
        Set(ByVal value As Decimal)
            _NGUIRM = value
        End Set
    End Property
    Public Property pNOPRCN() As Decimal
        Get
            Return _NOPRCN
        End Get
        Set(ByVal value As Decimal)
            _NOPRCN = value
        End Set
    End Property
    Public Property pNMOPRP() As Decimal
        Get
            Return _IN_NMOPRP
        End Get
        Set(ByVal value As Decimal)
            _IN_NMOPRP = value
        End Set
    End Property
    '
 
#End Region

    Private Sub frmAprobarMargen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txtFecha.Text = HelpClass.CNumero_a_Fecha(HelpClass.TodayNumeric())
            Me.Text = TituloForm.Trim
            LISTA_SERVICIOS()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            If MargenNegativo Then
                Dim msje As String = ""
                Select Case (Accion.Trim)
                    Case "A"
                        msje = "Está seguro de aprobar?"
                    Case "R"
                        msje = "Está seguro de Rechazar?"
                End Select
                If MessageBox.Show(msje, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    DialogResult = Windows.Forms.DialogResult.OK
                    Observacion = txtObservacion.Text.Trim
                End If
            Else
                DialogResult = Windows.Forms.DialogResult.OK
                Observacion = txtObservacion.Text.Trim
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
#Region "Motodos"
    Public Sub LISTA_SERVICIOS()
        Dim Objeto_Logica As New GuiaTransportista_BLL
        Dim oLiquidacionGT As New TD_Obj_LiquidacionGuiaRemision
        Dim dt As New DataTable
        oLiquidacionGT.pCCMPN_Compania = CCMPN
        oLiquidacionGT.pNGUIRM_NroGuiaTransportista = NGUIRM
        oLiquidacionGT.pNOPRCN_NroOperacion = pNOPRCN
        dt = Objeto_Logica.Validar_Diferencia(oLiquidacionGT, _IN_NMOPRP)
        dgMargenes.AutoGenerateColumns = False
        dgMargenes.DataSource = dt
    End Sub

#End Region
    Private Sub dgMargenes_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dgMargenes.DataBindingComplete
        Try
            For index As Integer = 0 To dgMargenes.Rows.Count - 1
                If dgMargenes.Item("S_FMRG", index).Value = "X" Then
                    dgMargenes.Item("N_DIFSOLES", index).Style.ForeColor = Color.Red
                    MargenNegativo = True
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
