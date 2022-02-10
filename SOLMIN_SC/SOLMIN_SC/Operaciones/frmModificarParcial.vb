Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Negocio
Imports System.Text
Public Class frmModificarParcial
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


    Private _pdItemParcial As New DataTable
    Public Property pdItemParcial() As DataTable
        Get
            Return _pdItemParcial
        End Get
        Set(ByVal value As DataTable)
            _pdItemParcial = value
        End Set
    End Property


    Private _pDialogResult As Boolean = False
    Public ReadOnly Property pDialogResult() As Boolean
        Get
            Return _pDialogResult
        End Get
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

    Private oListaPreEmbarques As New List(Of Decimal)

    Private Sub frmModificarParcial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gvItemParcial.AutoGenerateColumns = False
            gvItemParcial.DataSource = Nothing
            Dim NRPEMB As Decimal = 0
            txtOC.Text = _pNORCML
            txtParcialAnt.Text = _pNRPARC
            gvItemParcial.DataSource = pdItemParcial
            For Each Item As DataGridViewRow In gvItemParcial.Rows
                NRPEMB = Item.Cells("NRPEMB").Value
                If (Not oListaPreEmbarques.Contains(NRPEMB)) Then
                    oListaPreEmbarques.Add(NRPEMB)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Function ValidarNuevoParcial() As String
        Dim msg As String = ""
        Dim NroParcialNuevo As Decimal = 0
        Dim IsNumero As Boolean = False
        IsNumero = Decimal.TryParse(txtParcialNuevo.Text.Trim, NroParcialNuevo)
        If NroParcialNuevo = 0 Then
            msg = "Ingrese un Nro Parcial válido mayor a cero."
        Else
            Dim oPreEmbarque As New clsPreEmbarque
            Dim NRITOC As Decimal = 0
            Dim SBITOC As String = ""
            Dim NORCML As String = ""
            Dim numPreEmbNoValidos As Int32 = 0
            Dim msgValidacion As String = ""
            For Each Item As DataGridViewRow In gvItemParcial.Rows
                NORCML = Item.Cells("NORCML").Value.ToString.Trim
                NRITOC = Item.Cells("NRITOC").Value
                SBITOC = Item.Cells("SBITOC").Value.ToString.Trim
                msgValidacion = oPreEmbarque.Validar_Nro_Parcial_CargaInternacional_Item(_pCCMPN, _pCCLNT, NORCML, NRITOC, SBITOC, NroParcialNuevo)
                If msgValidacion.Length > 0 Then
                    numPreEmbNoValidos = numPreEmbNoValidos + 1
                    Exit For
                End If
            Next
            If numPreEmbNoValidos > 0 Then
                msg = msg & Chr(13) & "Existen item ya asociados al parcial."
            End If
            msg = msg.Trim
            ' msg = oPreEmbarque.Validar_Nro_Parcial_CargaInternacional(_pCCMPN, _pCCLNT, _pNORCML, NroParcialNuevo)
        End If
        Return msg
    End Function

    Dim oPreEmbarque As New clsPreEmbarque
    'msg = oPreEmbarque.Validar_Nro_Parcial_CargaInternacional_Item(_pCCMPN, _pCCLNT, _pNORCML, _pNRITOC, _pSBITOC, NroParcialNuevo)

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
                Dim NRPEMB As Decimal = 0
                Dim NRPARC As Decimal = 0
                Dim NRITOC As Decimal = 0
                Dim SBITOC As String = ""
                Dim NRPARC_NUEVO As Decimal = txtParcialNuevo.Text.Trim
                For Each Item As DataGridViewRow In gvItemParcial.Rows
                    NRPEMB = Item.Cells("NRPEMB").Value
                    NRPARC = Item.Cells("NRPARC").Value
                    NRITOC = Item.Cells("NRITOC").Value
                    SBITOC = Item.Cells("SBITOC").Value.ToString.Trim
                    retorno = oPreEmbarque.Actualizar_Nro_Parcial_CargaInternacional(NRPEMB, _pCCLNT, _pNORCML, NRITOC, SBITOC, NRPARC, NRPARC_NUEVO)
                Next
                _pDialogResult = True
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Avsio", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
