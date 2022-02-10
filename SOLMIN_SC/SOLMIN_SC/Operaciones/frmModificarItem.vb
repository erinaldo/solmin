
Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Negocio

Public Class frmModificarItem

#Region "Variables"

    Private _pCCLNT As Decimal = 0
    Public Property pCCLNT() As Decimal
        Get
            Return _pCCLNT
        End Get
        Set(ByVal value As Decimal)
            _pCCLNT = value
        End Set
    End Property

    Private _pNORSCI As Decimal = 0
    Public Property pNORSCI() As Decimal
        Get
            Return _pNORSCI
        End Get
        Set(ByVal value As Decimal)
            _pNORSCI = value
        End Set
    End Property

    Private _pNRPEMB As Decimal = 0
    Public Property pNRPEMB() As Decimal
        Get
            Return _pNRPEMB
        End Get
        Set(ByVal value As Decimal)
            _pNRPEMB = value
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

    Private _pNRITEM As Decimal = 0
    Public Property pNRITEM() As Decimal
        Get
            Return _pNRITEM
        End Get
        Set(ByVal value As Decimal)
            _pNRITEM = value
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

    Private _pQRLCSC As Decimal = 0
    Public Property pQRLCSC() As Decimal
        Get
            Return _pQRLCSC
        End Get
        Set(ByVal value As Decimal)
            _pQRLCSC = value
        End Set
    End Property

    Private _pCPTDAR As String = ""
    Public Property pCPTDAR() As String
        Get
            Return _pCPTDAR
        End Get
        Set(ByVal value As String)
            _pCPTDAR = value
        End Set
    End Property

    Private _pNFCTCM As String = ""
    Public Property pNFCTCM() As String
        Get
            Return _pNFCTCM
        End Get
        Set(ByVal value As String)
            _pNFCTCM = value
        End Set
    End Property

    Private _pNMITFC As String = ""
    Public Property pNMITFC() As String
        Get
            Return _pNMITFC
        End Get
        Set(ByVal value As String)
            _pNMITFC = value
        End Set
    End Property

#End Region



    Dim Q_Solicitada As Decimal = 0
    Dim Q_PreEmbarque As Decimal = 0
    Dim Q_Embarque As Decimal = 0
    Dim Q_Actual_Embarcada As Decimal = 0

    Private Sub frmModificarItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txtEmbarque.Text = _pNORSCI
            txtPreEmbarque.Text = _pNRPEMB
            txtOC.Text = _pNORCML
            If _pSBITOC <> "" Then
                txtItem.Text = _pNRITEM & "/" & _pSBITOC
            Else
                txtItem.Text = _pNRITEM
            End If
            txtCantidad.Text = Convert.ToDouble(_pQRLCSC)
            txtPartida.Text = _pCPTDAR.Trim
            txtNroFactura.Text = _pNFCTCM.Trim
            txtItemFactura.Text = _pNMITFC

            Dim Disponible_Item As Decimal = 0
            ObtenerDisponibilidad()
            Disponible_Item = Q_Solicitada - Q_PreEmbarque - Q_Embarque + Q_Actual_Embarcada
            lblInfo.Text = ""
            lblInfo.Text = "Máximo para ingresar: " & Disponible_Item

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     

    End Sub

    

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            ObtenerDisponibilidad()

            Dim resultado As Integer
            Dim Disponible As Decimal
            Dim actualizar As Boolean = True
            If txtCantidad.Text = "" OrElse CDec(txtCantidad.Text) = 0D Then
                MessageBox.Show("La cantidad ingresada debe ser mayor a 0", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If txtItemFactura.Text = "" Then
                txtItemFactura.Text = 0
            End If
            Disponible = Q_Solicitada - Q_PreEmbarque - Q_Embarque + Q_Actual_Embarcada
            If CDec(txtCantidad.Text) > Disponible Then
                If MessageBox.Show("La cantidad ingresada excede al máximo permitido (" & Disponible & ")" & Environment.NewLine & "¿Desea continuar de todas maneras?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    actualizar = True
                Else
                    actualizar = False
                End If

            End If
            If actualizar = True Then
                Dim objBLL As New clsDetOC
                resultado = objBLL.SP_SOLMIN_SC_ACTUALIZAR_ITEM_EMBARQUE(_pCCLNT, _pNORSCI, _pNRPEMB, txtCantidad.Text, _pNORCML, _pNRITEM, _pSBITOC, txtNroFactura.Text.Trim, txtItemFactura.Text, txtPartida.Text, Q_Actual_Embarcada)
                If resultado = 1 Then
                    MessageBox.Show("Se actualizó correctamente.Si los costos fueron distribuidos manualmente" & Chr(13) & " se requiere distribuirlos nuevamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ObtenerDisponibilidad()
        Dim objBLL As New clsDetOC
        Dim dtCantidadAsignadas As New DataTable
        dtCantidadAsignadas = New DataTable
        dtCantidadAsignadas = objBLL.LISTA_CANTIDADES_EMBARQUE_ADUANA(_pCCLNT, _pNORCML, _pNRITEM, _pSBITOC, _pNORSCI, _pNRPEMB)
        Q_Solicitada = dtCantidadAsignadas.Rows(0)("CANTIDAD_SOLICITADA")
        Q_PreEmbarque = dtCantidadAsignadas.Rows(0)("TOTAL_PRE_EMBARQUE")
        Q_Embarque = dtCantidadAsignadas.Rows(0)("TOTAL_EMBARCADO")
        Q_Actual_Embarcada = dtCantidadAsignadas.Rows(0)("CANTIDAD_ACTUAL_EMBARCADA")
    End Sub

    Private Sub txtItemFactura_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back)
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class
