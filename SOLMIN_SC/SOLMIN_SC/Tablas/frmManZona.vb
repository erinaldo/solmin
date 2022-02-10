Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Negocio
Public Class frmManZona
    Enum Accion
        Modificar
        Nuevo
    End Enum
    Private _pInfoZonaEmbarque As New ZonaEmbarque_BE
    Private _pInfoAccion As Accion = Accion.Nuevo

    Public Property pInfoZonaEmbarque() As ZonaEmbarque_BE
        Get
            Return _pInfoZonaEmbarque
        End Get
        Set(ByVal value As ZonaEmbarque_BE)
            _pInfoZonaEmbarque = value
        End Set
    End Property

    Public Property pInfoAccion() As Accion
        Get
            Return _pInfoAccion
        End Get
        Set(ByVal value As Accion)
            _pInfoAccion = value
        End Set
    End Property


    Private Sub frmManZona_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.cmbCliente.pAccesoPorUsuario = True
            Me.cmbCliente.pRequerido = True
            Me.cmbCliente.pUsuario = HelpUtil.UserName
            cmbCliente.pCargar(_pInfoZonaEmbarque.PNCCLNT)
            Select Case pInfoAccion
                Case Accion.Modificar
                    txtCodigoZona.Enabled = False
                    txtDescripcion.Enabled = True

                    txtCodigoZona.Text = _pInfoZonaEmbarque.PSCZNAEM
                    txtDescripcion.Text = _pInfoZonaEmbarque.PSTZNAEM
                    txtDescripcion.Focus()

                Case Accion.Nuevo

                    txtCodigoZona.Clear()
                    txtDescripcion.Clear()
                    txtCodigoZona.Focus()

                    txtCodigoZona.Enabled = True
                    txtDescripcion.Enabled = True
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        txtCodigoZona.Text = txtCodigoZona.Text.Trim
        txtDescripcion.Text = txtDescripcion.Text.Trim
        Try
            Dim mgsValidacion As String = ""
            Dim retorno As Int32 = 0
            mgsValidacion = ValidaIngreso()
            If (mgsValidacion <> "") Then
                MessageBox.Show(mgsValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim obeZonaEmbarque As New ZonaEmbarque_BE
            Dim obrZonaEmbarque As New clsZonasEmbarque
            Dim obeMensaje As New beMensaje
            obeZonaEmbarque = ObtenerZonaEmbarque()
            Select Case pInfoAccion
                Case Accion.Modificar
                    retorno = obrZonaEmbarque.Actualiza_Zonas_Embarque(obeZonaEmbarque)
                    DialogResult = Windows.Forms.DialogResult.OK
                Case Accion.Nuevo
                    retorno = obrZonaEmbarque.Insertar_Zonas_Embarque(obeZonaEmbarque)
                    DialogResult = Windows.Forms.DialogResult.OK
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function ObtenerZonaEmbarque() As ZonaEmbarque_BE
        Dim obeZonaEmbarque As New ZonaEmbarque_BE
        obeZonaEmbarque.PNCCLNT = _pInfoZonaEmbarque.PNCCLNT
        obeZonaEmbarque.PSCZNAEM = txtCodigoZona.Text.Trim.ToUpper
        obeZonaEmbarque.PSTZNAEM = txtDescripcion.Text.Trim
        Return obeZonaEmbarque
    End Function

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Function ValidaIngreso() As String
        txtDescripcion.Text = txtDescripcion.Text.Trim
        Dim msg As String = ""
        If (txtCodigoZona.Text.Trim = "") Then
            msg += "Ingrese Código Zona"
        End If
        If (txtDescripcion.Text.Trim = "") Then
            msg += Chr(13)
            msg += "Ingrese Descripción."
        End If
        Return msg
    End Function
End Class
