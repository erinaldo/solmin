Imports System.Windows.Forms
Imports System.Text

Public Class frmDimensiones

    Private gEnumOpc As EnumMan = EnumMan.Neutro
    Enum EnumMan
        Neutro
        Nuevo
        Editar
    End Enum

    Private _pNUMREQT As Decimal = 0D
    Public Property pNUMREQT() As Decimal
        Get
            Return _pNUMREQT
        End Get
        Set(ByVal value As Decimal)
            _pNUMREQT = value
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


    Private _pUsuario As String = ""
    Public Property pUsuario() As String
        Get
            Return _pUsuario
        End Get
        Set(ByVal value As String)
            _pUsuario = value
        End Set
    End Property


    Private Sub frmDimensiones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue
            dgvDimensiones.AutoGenerateColumns = False
            gEnumOpc = EnumMan.Neutro
            HabilitarOpcion(gEnumOpc)
            Estado_Controles(False)
            Lista_Dimensiones()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Sub Lista_Dimensiones()

        Dim ObjDimensiones As New Dimensiones
        Dim objDimensiones_BLL As New Dimensiones_BLL
        With ObjDimensiones
            .NUMREQT = _pNUMREQT
            .CCMPN = _pCCMPN
        End With
        dgvDimensiones.DataSource = objDimensiones_BLL.fListar_Dimensiones(ObjDimensiones)

    End Sub

    Private Sub Estado_Controles(ByVal estado As Boolean)
        txtLargo.Enabled = estado
        txtDescripcion.Enabled = estado
        txtAncho.Enabled = estado
        txtAlto.Enabled = estado
        txtPeso.Enabled = estado
    End Sub

    Private Sub dgvDimensiones_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvDimensiones.SelectionChanged
        Try
            If dgvDimensiones.CurrentRow Is Nothing Then
                Exit Sub
            End If
            gEnumOpc = EnumMan.Neutro
            HabilitarOpcion(EnumMan.Neutro)
            Estado_Controles(False)
            'HabilitarOpcionxEstadoRequerimiento()
            Limpiar_Controles()
            CargarDatosRequerimiento()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub HabilitarOpcion(ByVal opc As EnumMan)

        Select Case opc
            Case EnumMan.Neutro
                btnNuevo.Enabled = True
                btnModificar.Enabled = True
                btnGuardar.Visible = False
                btnGuardar.Enabled = False
                btnCancelar.Enabled = False
                btnEliminar.Enabled = True

            Case EnumMan.Nuevo
                btnNuevo.Enabled = False
                btnModificar.Enabled = False
                btnGuardar.Visible = True
                btnGuardar.Enabled = True
                btnCancelar.Enabled = True
                btnEliminar.Enabled = False

            Case EnumMan.Editar
                btnNuevo.Enabled = False
                btnModificar.Enabled = False
                btnGuardar.Visible = True
                btnGuardar.Enabled = True
                btnCancelar.Enabled = True
                btnEliminar.Enabled = False

        End Select

    End Sub

    Sub Limpiar_Controles()

        txtAlto.Text = ""
        txtAncho.Text = ""
        txtDescripcion.Text = ""
        txtLargo.Text = ""
        txtPeso.Text = ""
    End Sub

    Sub CargarDatosRequerimiento()

        If dgvDimensiones.Rows.Count > 0 Then
            txtDescripcion.Text = dgvDimensiones.CurrentRow.Cells("TDITES").Value
            txtLargo.Text = dgvDimensiones.CurrentRow.Cells("QMTLRG_D").Value
            txtAlto.Text = dgvDimensiones.CurrentRow.Cells("QMTALT_D").Value
            txtAncho.Text = dgvDimensiones.CurrentRow.Cells("QMTANC_D").Value
            txtPeso.Text = dgvDimensiones.CurrentRow.Cells("QPESO_D").Value
        End If

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Try

            Limpiar_Controles()
            gEnumOpc = EnumMan.Nuevo
            HabilitarOpcion(gEnumOpc)
            Estado_Controles(True)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try

            If dgvDimensiones.CurrentRow Is Nothing Then Exit Sub
            gEnumOpc = EnumMan.Editar
            HabilitarOpcion(EnumMan.Editar)
            Estado_Controles(True)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try

            Select Case gEnumOpc
                Case EnumMan.Nuevo

                    If Validar() Then Exit Sub
                    Dim Entidad As New Dimensiones
                    Dim Negocio As New Dimensiones_BLL
                    Entidad = AsignarDimensiones()
                    Entidad.CUSCRT = _pUsuario
                    Entidad.NTRMCR = Environment.MachineName
                    Negocio.fInsertar_Dimensiones(Entidad)

                    gEnumOpc = EnumMan.Neutro
                    HabilitarOpcion(EnumMan.Neutro)
                    Estado_Controles(False)
                    'MessageBox.Show("Registro ingresado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Lista_Dimensiones()

                Case EnumMan.Editar

                    If Validar() Then Exit Sub
                    Dim Entidad As New Dimensiones
                    Dim Negocio As New Dimensiones_BLL
                    Entidad = AsignarDimensiones()
                    Entidad.CULUSA = _pUsuario
                    Entidad.NTRMNL = Environment.MachineName
                    Negocio.fModificar_Dimensiones(Entidad)
                    gEnumOpc = EnumMan.Neutro
                    HabilitarOpcion(EnumMan.Neutro)
                    Estado_Controles(False)
                    'MessageBox.Show("Registro actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Lista_Dimensiones()

            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function Validar() As Boolean
        Dim strMensajeError As String = ""

        If txtDescripcion.Text.ToString.Trim = "" Then strMensajeError &= "* Ingrese una descripción" & vbNewLine
        If txtLargo.Text.ToString.Trim = "" Then strMensajeError &= "* Ingrese largo(m)" & vbNewLine
        If txtAncho.Text.ToString.Trim = "" Then strMensajeError &= "* Ingrese ancho(m)" & vbNewLine
        If txtAlto.Text.ToString.Trim = "" Then strMensajeError &= "* Ingrese alto(m)" & vbNewLine

        If strMensajeError.Length > 0 Then
            MessageBox.Show(strMensajeError, "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        End If
        Return False
    End Function

    Private Function AsignarDimensiones() As Dimensiones

        Dim Entidad As New Dimensiones

        Entidad.CCMPN = _pCCMPN
        Entidad.NUMREQT = _pNUMREQT

        If dgvDimensiones.Rows.Count > 0 Then
            Entidad.NCRREQT = CDec(dgvDimensiones.CurrentRow.Cells("NCRREQT").Value)
        Else
            Entidad.NCRREQT = 0
        End If

        Entidad.TDITES = txtDescripcion.Text.ToString.Trim
        Entidad.QMTALT = Val(txtAlto.Text)
        Entidad.QMTANC = Val(txtAncho.Text)
        Entidad.QMTLRG = Val(txtLargo.Text)
        Entidad.QPESO = Val(txtPeso.Text)
        Return Entidad

    End Function

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Try

            gEnumOpc = EnumMan.Neutro
            HabilitarOpcion(EnumMan.Neutro)
            Limpiar_Controles()
            Estado_Controles(False)
            CargarDatosRequerimiento()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            If dgvDimensiones.CurrentRow Is Nothing Then Exit Sub

            Dim Negocio As New Dimensiones_BLL
            Dim Entidad As New Dimensiones

            If MessageBox.Show("¿Desea eliminar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Entidad.CCMPN = dgvDimensiones.CurrentRow.Cells("CCMPN").Value
                Entidad.NUMREQT = CDec(dgvDimensiones.CurrentRow.Cells("NUMREQT").Value)
                Entidad.NCRREQT = CDec(dgvDimensiones.CurrentRow.Cells("NCRREQT").Value)
                Entidad.CUSCRT = _pUsuario
                Entidad.NTRMCR = Environment.MachineName
                Negocio.fEliminar_Dimensiones(Entidad)
                Limpiar_Controles()
                Lista_Dimensiones()
            End If
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class