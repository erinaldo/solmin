Imports System.Windows.Forms
Imports Ransa.Utilitario
Imports RANSA.TYPEDEF

Public Class frmRevisionInc


    Private _CCMPN As String
    Public Property PSCCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property


    Private _pPNCCLNT As Decimal
    Public Property pPNCCLNT() As Decimal
        Get
            Return _pPNCCLNT
        End Get
        Set(ByVal value As Decimal)
            _pPNCCLNT = value
        End Set
    End Property

    Private _pNMRGIM As String
    Public Property pNMRGIM() As String
        Get
            Return _pNMRGIM
        End Get
        Set(ByVal value As String)
            _pNMRGIM = value
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

    '------------------------------------------------------------------------------------------------------------------------------------

    Private _pArea As String
    Public Property pArea() As String
        Get
            Return _pArea
        End Get
        Set(ByVal value As String)
            _pArea = value
        End Set
    End Property


    Private _Entidad As beSeguimiento
    Public Property Entidad() As beSeguimiento
        Get
            Return _Entidad
        End Get
        Set(ByVal value As beSeguimiento)
            _Entidad = value
        End Set
    End Property

    Private Sub frmRevisionInc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        dtpHora.Format = Windows.Forms.DateTimePickerFormat.Custom

        txtDivision.Text = _pArea
        txtPlanta.Text = _Entidad.PSTPLNTA
        txtFecha.Text = _Entidad.FechaRegistro
        txtHora.Text = _Entidad.HoraRegistro

        txtTipoIncidencia.Text = _Entidad.PSTINCSI
        txtCliente.Text = _Entidad.PSTCMPCL
        txtCodigo.Text = _Entidad.PNNINCSI
        txtEstado.Text = "PARA REVISAR"
        txtEstado_DB.Text = _Entidad.PSESTADO
        txtDescripcion.Text = _Entidad.PSTINCDT

        txtIncPara.Text = _Entidad.PSTTPINC
        txtNegocio.Text = _Entidad.PSTCRVTA

        txtCantidad.Text = _Entidad.PNQAINSM
        txtUnidad.Text = _Entidad.PSMEDIDA

        txtReportadoPor.Text = _Entidad.PSREPORTADO
        txtNivel.Text = _Entidad.PSNIVEL

        txtTipoAlmacen.Text = _Entidad.PSTALMC
        txtAlmacen.Text = _Entidad.PSTCMPAL
        txtZona.Text = _Entidad.PSTCMZNA
        txtResponsable.Text = _Entidad.PSTIRALC
        txtContacto.Text = _Entidad.PSPRSCNT
        txtDescripcion.Text = _Entidad.PSTINCDT

        Cargar_TipoSolucion()
        Cargar_Efecto()
        Cargar_Accion()
        Cargar_Clasificacion()

        cboTipoSolucion.SelectedValue = IIf(_Entidad.PSSTPSLC.ToString.Trim = "", "", _Entidad.PSSTPSLC)

        txtUsuario.pObtenerUsuario(_Entidad.PSCUSEVI)
        txtUsuario.Refresh()

        txtObservación.Text = _Entidad.PSTOBRES.ToString.Trim

        If _Entidad.PSFCHREVISION.ToString.Trim = "" Then
            dtpFecha.Value = Now.Date
        Else
            dtpFecha.Value = CDate(_Entidad.PSFCHREVISION.ToString.Trim)
        End If
        'dtpHora.Value = Date.Today.ToString("HH:mm:ss")

        'If _Entidad.PSHRAREVISION.ToString.Trim = "" Then
        '    dtpHora.Value = Now.Date
        'Else
        '    dtpHora.Value = CDate(_Entidad.PSHRAREVISION.ToString.Trim)
        'End If

    End Sub

    Sub Cargar_TipoSolucion()

        Dim ObjBLL As New brSeguimiento
        Dim dtTipo As New DataTable
        Dim dr As DataRow

        dtTipo = ObjBLL.Lista_Tipo_Solucion

        dr = dtTipo.NewRow
        dr("STPSLC") = ""
        dr("DESCRIPCION") = ":: Seleccione ::"
        dtTipo.Rows.InsertAt(dr, 0)

        cboTipoSolucion.DataSource = dtTipo.Copy
        cboTipoSolucion.ValueMember = "STPSLC"
        cboTipoSolucion.DisplayMember = "DESCRIPCION"
        cboTipoSolucion.SelectedValue = ""

    End Sub


    Sub Cargar_Efecto()

        Dim ObjBLL As New brSeguimiento
        Dim dtTipo As New DataTable
        Dim dr As DataRow

        dtTipo = ObjBLL.Lista_Efectos

        dr = dtTipo.NewRow
        dr("CDEFCT") = ""
        dr("TDEFCT") = ":: Seleccione ::"
        dtTipo.Rows.InsertAt(dr, 0)

        cmbEfecto.DataSource = dtTipo.Copy
        cmbEfecto.ValueMember = "CDEFCT"
        cmbEfecto.DisplayMember = "TDEFCT"
        cmbEfecto.SelectedValue = ""

    End Sub


    Sub Cargar_Accion()

        Dim ObjBLL As New brSeguimiento
        Dim dtTipo As New DataTable
        Dim dr As DataRow

        dtTipo = ObjBLL.Lista_Accion

        dr = dtTipo.NewRow
        dr("CDACCN") = ""
        dr("TDACCN") = ":: Seleccione ::"
        dtTipo.Rows.InsertAt(dr, 0)

        cmbAccion.DataSource = dtTipo.Copy
        cmbAccion.ValueMember = "CDACCN"
        cmbAccion.DisplayMember = "TDACCN"
        cmbAccion.SelectedValue = ""

    End Sub


    Sub Cargar_Clasificacion()

        Dim ObjBLL As New brSeguimiento
        Dim dtTipo As New DataTable
        'Dim dr As DataRow

        dtTipo = ObjBLL.Lista_Clasificacion

        'dr = dtTipo.NewRow
        'dr("CDACCN") = ""
        'dr("TDACCN") = ":: Seleccione ::"
        'dtTipo.Rows.InsertAt(dr, 0)

        cmbClasificacion.DataSource = dtTipo.Copy
        cmbClasificacion.ValueMember = "CDCLAS"
        cmbClasificacion.DisplayMember = "TDCLAS"
        cmbClasificacion.SelectedValue = "1"

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            If Validar() Then Exit Sub

            If MessageBox.Show("La incidencia estará revisada.¿ Desea continuar? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                Dim objBE As New beSeguimiento
                Dim objBLL As New brSeguimiento

                With objBE

                    objBE.PNNINCSI = CDec(txtCodigo.Text)
                    objBE.PSSTPSLC = cboTipoSolucion.SelectedValue
                    objBE.PSSACPINC = cmbEfecto.SelectedValue
                    objBE.PSSACCINC = cmbAccion.SelectedValue
                    objBE.PSSCLINC = cmbClasificacion.SelectedValue
                    objBE.PNFCHRVI = HelpClass.CFecha_a_Numero8Digitos(dtpFecha.Value.Date.ToString)
                    objBE.PNHRARVI = CDec(String.Format("{0:HHmmss}", dtpHora.Value))
                    objBE.PSCUSEVI = txtUsuario.pPSMMCUSR
                    objBE.PSUSUARIO = _pUsuario
                    objBE.PSTOBRES = txtObservación.Text.Trim
                End With
                objBLL.intActualizarSeguimiento_Revision(objBE)
                MessageBox.Show("Incidencia Nro " & CInt(txtCodigo.Text) & " ha sido revisado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function Validar() As Boolean
        Dim strMensajeError As String = ""
        If cboTipoSolucion.SelectedValue = "" Then strMensajeError &= "* Seleccionar un tipo de solución." & vbNewLine
        If cmbEfecto.SelectedValue = "" Then strMensajeError &= "* Seleccionar un efecto." & vbNewLine
        If cmbAccion.SelectedValue = "" Then strMensajeError &= "* Seleccionar una acción." & vbNewLine
        If txtUsuario.pPSMMCUSR = "" Then strMensajeError &= "* Asigne un usuario." & vbNewLine

        If strMensajeError.Length > 0 Then
            MessageBox.Show(strMensajeError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        End If
        Return False
    End Function

End Class
