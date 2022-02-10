Imports RANSA.TypeDef.WayBill

Public Class frmControlOperacion
#Region " Atributos "
    Private pSTPODP As String = ""
#End Region
#Region " Procedimientos y Funciones "
    Public Property pSTPODP_TipoAlmacen() As String
        Get
            Return pSTPODP
        End Get
        Set(ByVal value As String)
            pSTPODP = value
        End Set
    End Property
#End Region
#Region " Eventos "
    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        Dim oControl As TD_Qry_CtrlOperacion = New TD_Qry_CtrlOperacion
        With oControl
            .pSTPODP_TipoAlmacen = pSTPODP
            .pCTPOAT_TipoOperacion = cmbTipoOperacion.pInformacionSelec.pCCMPRN_Codigo
            .pFTRMOP_FechaCierre = dteFechaCierre.Value
        End With
        dgControlOperacion.pActualizar(oControl)
    End Sub

    Private Sub dgControlOperacion_Confirmar(ByVal Pregunta As String, ByRef Cancelar As Boolean) Handles dgControlOperacion.Confirmar
        If MessageBox.Show(Pregunta, "Confirmar:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Cancel Then Cancelar = True
    End Sub

    Private Sub dgControlOperacion_ErrorMessage(ByVal ErrorMensaje As String) Handles dgControlOperacion.ErrorMessage
        MessageBox.Show(ErrorMensaje, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub dgControlOperacion_Message(ByVal Mensaje As String) Handles dgControlOperacion.Message
        MessageBox.Show(Mensaje, "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub frmControlOperacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dteFechaCierre.Value = Now
    End Sub
#End Region
#Region " Métodos "

#End Region
End Class
