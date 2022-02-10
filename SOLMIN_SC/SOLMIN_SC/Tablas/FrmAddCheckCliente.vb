Imports SOLMIN_SC.Negocio
Imports System.Web
Imports Ransa.Utilitario
Imports SOLMIN_SC.Entidad
Public Class FrmAddCheckCliente
    Private isCheck As Boolean = False
    Private _pCCLNT As Decimal = 0
    Public Property pCCLNT() As Decimal
        Get
            Return _pCCLNT
        End Get
        Set(ByVal value As Decimal)
            _pCCLNT = value
        End Set
    End Property

    Private _pCCMPN As String = ""
    Public Property pCCMPN() As String
        Get
            Return _pCCMPN
        End Get
        Set(ByVal value As String)
            _pCCMPN = value
        End Set
    End Property

    Private Sub Cargar_Tipo_CheckPoint()
        Dim oCheckPoint As New clsCheckPoint
        Dim dtCheckPoint As New DataTable
        dtCheckPoint = oCheckPoint.Cargar_Tipo_CheckPoint
        cmbTipoCheck.DataSource = dtCheckPoint
        cmbTipoCheck.ValueMember = "VALVAR"
        cmbTipoCheck.DisplayMember = "NOMVAR"
        cmbTipoCheck.SelectedValue = ""
    End Sub
    Private Sub FrmAddCheckCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dtgCheckpoint.AutoGenerateColumns = False
            Cargar_Tipo_CheckPoint()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            If cmbCliente.pCodigo = 0 Then
                MessageBox.Show("Seleccione Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim oDtDatosCheckPoint As New DataTable
            dtgCheckpoint.DataSource = Nothing
            Dim oCheckPoint As New clsCheckPoint
            Dim dblCliente As Double
            Dim CCMPN As String = _pCCMPN
            Dim CDVSN As String = GetDivision(CCMPN)
            dblCliente = Me.cmbCliente.pCodigo
            oDtDatosCheckPoint = oCheckPoint.Lista_CheckPoint_X_Cliente(dblCliente, CCMPN, CDVSN, cmbTipoCheck.SelectedValue, "A")
            dtgCheckpoint.DataSource = oDtDatosCheckPoint
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetDivision(ByVal CCMPN As String) As String
        If CCMPN = "EZ" Then
            Return HelpClass.getSetting("DivisionEZ")
        Else
            Return ""
        End If
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            dtgCheckpoint.EndEdit()
            Dim clsCheckPoint As New clsCheckPoint
            Dim obeCheckPoint As beCheckPoint
            For Each Item As DataGridViewRow In dtgCheckpoint.Rows
                If Item.Cells("CHK_COLUMNA").Value = True Then
                    obeCheckPoint = New beCheckPoint
                    obeCheckPoint.PNCCLNT = _pCCLNT
                    obeCheckPoint.PSCCMPN = _pCCMPN
                    obeCheckPoint.PSCDVSN = GetDivision(_pCCMPN)
                    obeCheckPoint.PNNESTDO = Item.Cells("NESTDO").Value
                    obeCheckPoint.PSTCOLUM = HelpClass.ToStringCvr(Item.Cells("TCOLUM").Value)
                    clsCheckPoint.Actualizar_Checkpoint(obeCheckPoint)
                End If
            Next
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        Try
            dtgCheckpoint.EndEdit()
            isCheck = Not isCheck
            If isCheck = True Then
                btnCheck.Image = My.Resources.btnMarcarItems
            Else
                btnCheck.Image = My.Resources.btnNoMarcarItems
            End If
            Poner_Check_Todo(isCheck)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try

    End Sub


    Private Sub Poner_Check_Todo(ByVal blnEstado As Boolean)
        Dim intCont As Integer
        For intCont = 0 To dtgCheckpoint.RowCount - 1
            dtgCheckpoint.Rows(intCont).Cells("CHK_COLUMNA").Value = blnEstado
        Next
    End Sub


End Class
