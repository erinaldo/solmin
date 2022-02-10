Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Negocio
Imports System.Text
Public Class frmModificarlParcialItem
    Private _pCCMPN As String = ""
    Public Property pCCMPN() As String
        Get
            Return _pCCMPN
        End Get
        Set(ByVal value As String)
            _pCCMPN = value
        End Set
    End Property
    Private _pCCLNT As Decimal = 0
    Public Property pCCLNT() As Decimal
        Get
            Return _pCCLNT
        End Get
        Set(ByVal value As Decimal)
            _pCCLNT = value
        End Set
    End Property
    Private _pNORCML As String = ""
    Public Property pNORCML() As String
        Get
            Return _pNORCML
        End Get
        Set(ByVal value As String)
            _pNORCML = value
        End Set
    End Property
    Private _pNRPARC As Decimal = 0
    Public Property pNRPARC() As Decimal
        Get
            Return _pNRPARC
        End Get
        Set(ByVal value As Decimal)
            _pNRPARC = value
        End Set
    End Property

    Private _pNRITOC As Decimal = 0
    Public Property pNRITOC() As Decimal
        Get
            Return _pNRITOC
        End Get
        Set(ByVal value As Decimal)
            _pNRITOC = value
        End Set
    End Property

    Private _pSBITOC As String = ""
    Public Property pSBITOC() As String
        Get
            Return _pSBITOC
        End Get
        Set(ByVal value As String)
            _pSBITOC = value
        End Set
    End Property

    '
    Private _pNRPEMB As Decimal = 0
    Public Property pNRPEMB() As Decimal
        Get
            Return _pNRPEMB
        End Get
        Set(ByVal value As Decimal)
            _pNRPEMB = value
        End Set
    End Property



    Private _pDialogResult As Boolean = False
    Public Property pDialogResult() As Boolean
        Get
            Return _pDialogResult
        End Get
        Set(ByVal value As Boolean)
            _pDialogResult = value
        End Set
    End Property

    Private Function ValidarNuevoParcial() As String
        Dim msg As String = ""
        Dim NroParcialNuevo As Decimal = 0
        Dim IsNumero As Boolean = False
        IsNumero = Decimal.TryParse(txtParcialNuevo.Text.Trim, NroParcialNuevo)
        If NroParcialNuevo = 0 Then
            msg = "Ingrese un Nro Parcial válido mayor a cero."
        Else
            Dim oPreEmbarque As New clsPreEmbarque
            msg = oPreEmbarque.Validar_Nro_Parcial_CargaInternacional_Item(_pCCMPN, _pCCLNT, _pNORCML, _pNRITOC, _pSBITOC, NroParcialNuevo)
        End If
        Return msg
    End Function



    Private Sub frmModificarlParcialItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            txtOC.Text = Me._pNORCML
            txtItem.Text = Me._pNRITOC
            txtSubItem.Text = Me._pSBITOC
            txtParcialAnt.Text = Me._pNRPARC
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        txtParcialNuevo.Text = txtParcialNuevo.Text.Trim
        Dim msg As String = ""
        Dim oPreEmbarque As New clsPreEmbarque
        Try
            msg = ValidarNuevoParcial()
            If msg.Length > 0 Then
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If txtParcialNuevo.Text = txtParcialAnt.Text.Trim Then
                Exit Sub
            End If
            If MessageBox.Show("Está seguro de cambiar el número de parcial ? ", "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim retorno As Int32 = 0
                Dim NRPARC_NUEVO As Decimal = txtParcialNuevo.Text.Trim
                retorno = oPreEmbarque.Actualizar_Nro_Parcial_CargaInternacional(_pNRPEMB, _pCCLNT, _pNORCML, _pNRITOC, _pSBITOC, _pNRPARC, NRPARC_NUEVO)
                _pDialogResult = True
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Avsio", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
