
Imports SOLMIN_SC.Negocio
Imports Ransa.Utilitario
Imports SOLMIN_SC.Entidad

Public Class frmMantMaestroCheckpoint

#Region "PROPIEDADES"

    Private _pCompania As String
    Public Property pCompania() As String
        Get
            Return _pCompania
        End Get
        Set(ByVal value As String)
            _pCompania = value
        End Set
    End Property

    Private _pDivision As String
    Public Property pDivision() As String
        Get
            Return _pDivision
        End Get
        Set(ByVal value As String)
            _pDivision = value
        End Set
    End Property

    Private _pTipo As String
    Public Property pTipo() As String
        Get
            Return _pTipo
        End Get
        Set(ByVal value As String)
            _pTipo = value
        End Set
    End Property

    Private _pCodigo As Decimal
    Public Property pCodigo() As Decimal
        Get
            Return _pCodigo
        End Get
        Set(ByVal value As Decimal)
            _pCodigo = value
        End Set
    End Property

    Private _pDescripcion As String
    Public Property pDescripcion() As String
        Get
            Return _pDescripcion
        End Get
        Set(ByVal value As String)
            _pDescripcion = value
        End Set
    End Property

    Private _pUsuario As String
    Public Property pUsuario() As String
        Get
            Return _pUsuario
        End Get
        Set(ByVal value As String)
            _pUsuario = value
        End Set
    End Property

    Dim oCheckPoint As clsCheckPoint
    Dim dtCheckpoint As DataTable

#End Region


    Private Sub frmMantMaestroCheckpoint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cargar_Compania()
        cmbDivision.DivisionDefault = pDivision
        cmbDivision.pActualizar()
        cmbDivision_SelectionChangeCommitted(Nothing)
        If pCodigo > 0 Then

            cmbCompania.Habilitar = False
            cmbDivision.pHabilitado = False

            cmbTipo.SelectedValue = pTipo
            txtCodigo.Text = pCodigo
            txtDescripcion.Text = pDescripcion
        End If

    End Sub

    Private Sub Cargar_Compania()
        cmbCompania.Usuario = HelpUtil.UserName
        cmbCompania.pActualizar()
        cmbCompania.HabilitarCompaniaActual(_pCompania)
    End Sub

    Private Sub Cargar_Tipo_CheckPoint()

        Dim oCheckPoint As New clsCheckPoint
        Dim dtCheckPoint As New DataTable
        dtCheckPoint = oCheckPoint.Cargar_Tipo_CheckPoint


        dtCheckPoint.Rows.RemoveAt(0)
        cmbTipo.DataSource = dtCheckPoint
        cmbTipo.ValueMember = "VALVAR"
        cmbTipo.DisplayMember = "NOMVAR"

        If cmbDivision.Division = "S" Then
            cmbTipo.SelectedValue = "N"
        End If


    End Sub

    Private Sub Cargar_Tipo_CheckPoint_SIL()
        Dim oCheckPoint As New clsCheckPoint
        Dim dtCheckPoint As New DataTable
        dtCheckPoint = oCheckPoint.Cargar_Tipo_CheckPoint

        dtCheckPoint.Rows.RemoveAt(3)
        dtCheckPoint.Rows.RemoveAt(3)
        dtCheckPoint.Rows.RemoveAt(0)

        cmbTipo.DataSource = dtCheckPoint
        cmbTipo.ValueMember = "VALVAR"
        cmbTipo.DisplayMember = "NOMVAR"
        'cmbTipo.SelectedValue = ""
    End Sub

    Private Sub cmbCompania_SelectionChangeCommitted(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.SelectionChangeCommitted
        Try
            cmbDivision.Compania = obeCompania.CCMPN_CodigoCompania
            cmbDivision.Usuario = HelpUtil.UserName
            'If cmbDivision.Compania = "EZ" Then
            '    cmbDivision.DivisionDefault = "S"
            'End If
            cmbDivision.pActualizar()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbDivision_SelectionChangeCommitted(ByVal obeDivision As Ransa.Controls.UbicacionPlanta.Division.beDivision) Handles cmbDivision.SelectionChangeCommitted

        Try
            'If cmbDivision.Division = "S" Then
            'Cargar_Tipo_CheckPoint_SIL()
            'Else
            Cargar_Tipo_CheckPoint()
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress

        Try
            e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try


            If pCodigo > 0 Then
                If txtDescripcion.Text.Trim = "" Then
                    MessageBox.Show("Ingrese una descripción", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                oCheckPoint = New clsCheckPoint
                oCheckPoint.Modificar_Maestro_CheckPoint(cmbCompania.CCMPN_CodigoCompania, cmbDivision.Division, CDec(txtCodigo.Text.Trim), txtDescripcion.Text.Trim, cmbTipo.SelectedValue, pUsuario)
                MessageBox.Show("Registro actualizado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                If txtDescripcion.Text.Trim = "" Then
                    MessageBox.Show("Ingrese una descripción", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                oCheckPoint = New clsCheckPoint
                oCheckPoint.Insertar_Maestro_CheckPoint(cmbCompania.CCMPN_CodigoCompania, cmbDivision.Division, txtDescripcion.Text.Trim, cmbTipo.SelectedValue, pUsuario)
                MessageBox.Show("Registro ingresado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
