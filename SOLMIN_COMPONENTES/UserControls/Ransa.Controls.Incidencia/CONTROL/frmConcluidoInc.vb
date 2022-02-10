Imports System.Windows.Forms
Imports Ransa.Utilitario
Imports RANSA.TYPEDEF

Public Class frmConcluidoInc

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


    Private Sub frmConcluidoInc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            dtpHora.Format = Windows.Forms.DateTimePickerFormat.Custom

            txtArea.Text = _pArea
            txtPlanta.Text = _Entidad.PSTPLNTA
            txtFecha.Text = _Entidad.FechaRegistro
            txtHora.Text = _Entidad.HoraRegistro

            txtTipoIncidencia.Text = _Entidad.PSTINCSI
            txtCliente.Text = _Entidad.PSTCMPCL
            txtCodigo.Text = _Entidad.PNNINCSI
            txtEstado.Text = "PARA CONCLUIR"
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


        CargaMoneda()
            Cargar_Asumidos()

            cboAsumido.SelectedValue = _Entidad.PSCDASCI
            txtPorcentaje.Text = _Entidad.PNPRCASC
            txtCosto.Text = _Entidad.PNICSTOS
            txtMoneda.Valor = _Entidad.PSTMNDA

            If _Entidad.PSFCHREVISION.ToString.Trim = "" Then
                dtpFecha.Value = Now.Date
            Else
                dtpFecha.Value = CDate(_Entidad.PSFCHREVISION.ToString.Trim)
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    Sub Cargar_Asumidos()

        Dim ObjBLL As New brSeguimiento
        Dim dtTipo As New DataTable
        Dim dr As DataRow

        dtTipo = ObjBLL.Lista_Seguimiento_Asumidos

        dr = dtTipo.NewRow
        dr("CDASCI") = ""
        dr("DESCRIPCION") = ":: Seleccione ::"
        dtTipo.Rows.InsertAt(dr, 0)

        cboAsumido.DataSource = dtTipo.Copy
        cboAsumido.ValueMember = "CDASCI"
        cboAsumido.DisplayMember = "DESCRIPCION"
        cboAsumido.SelectedValue = ""

    End Sub



    Private Sub CargaMoneda()
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CMNDA1"
        oColumnas.DataPropertyName = "PNCMNDA1"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TMNDA"
        oColumnas.DataPropertyName = "PSTMNDA"
        oColumnas.HeaderText = "Moneda "
        oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        oListColum.Add(2, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TSGNMN"
        oColumnas.DataPropertyName = "PSTSGNMN"
        oColumnas.HeaderText = "Signo "
        oListColum.Add(3, oColumnas)
        Dim obrGeneral As New brGeneral
        txtMoneda.DataSource = obrGeneral.ListaMoneda()
        txtMoneda.ListColumnas = oListColum
        txtMoneda.Cargas()
        txtMoneda.ValueMember = "PNCMNDA1"
        txtMoneda.DispleyMember = "PSTMNDA"
    End Sub


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try

            If Validar() Then Exit Sub

            If MessageBox.Show("La incidencia estará concluída.¿Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                Dim objBE As New beSeguimiento
                Dim objBLL As New brSeguimiento

                With objBE

                    objBE.PNNINCSI = CDec(txtCodigo.Text)
                    objBE.PSCDASCI = cboAsumido.SelectedValue
                    objBE.PNPRCASC = Val(txtPorcentaje.Text)
                    objBE.PNICSTOS = Val(txtCosto.Text)

                    If txtMoneda.Resultado Is Nothing Then
                        .PNCDMNDA = 0D
                    Else
                        .PNCDMNDA = CType(txtMoneda.Resultado, beGeneral).PNCMNDA1
                    End If

                    objBE.PNFCHTRI = HelpClass.CFecha_a_Numero8Digitos(dtpFecha.Value.Date.ToString)
                    objBE.PNHRATRI = CDec(String.Format("{0:HHmmss}", dtpHora.Value))

                    objBE.PSUSUARIO = _pUsuario
                    objBE.PSTOBRES2 = txtObservación.Text.ToString.Trim

                End With
                objBLL.intActualizarSeguimiento_Concluido(objBE)
                MessageBox.Show("Incidencia Nro " & CInt(txtCodigo.Text) & " ha sido concluído", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function Validar() As Boolean

        Dim strMensajeError As String = ""

        If cboAsumido.SelectedValue = "" Then strMensajeError &= "* Seleccione Asumido por." & vbNewLine
        If Val(txtPorcentaje.Text) > 100 Then strMensajeError &= "* Ingrese un porcentaje asumido correcto." & vbNewLine
        If txtCosto.Text.Trim = "" Then strMensajeError &= "* Ingrese un costo." & vbNewLine
        If txtMoneda.Resultado Is Nothing Then strMensajeError &= "* Seleccione un tipo de moneda." & vbNewLine

        If strMensajeError.Length > 0 Then
            MessageBox.Show(strMensajeError, "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
        End If
        Return False
    End Function

    Private Sub btnAdjuntar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdjuntar.Click

        Dim NMRGIM As String = _pNMRGIM
        Dim NINCSI As Decimal = _Entidad.PNNINCSI
        Dim PNCCLNT As Long = _pPNCCLNT

        'Dim objFrm As New frmAdjuntarDocumentos(NMRGIM, Nothing, PNCCLNT, "RZSC39", _CCMPN, _pUsuario, frmAdjuntarDocumentos.EnumAdjunto.Seguimiento, "SC")
        'objFrm.TipoModo = frmAdjuntarDocumentos.EnumModo.Edicion
        'objFrm.NINCSI = NINCSI
        'objFrm.ShowDialog()
        'If objFrm.myDialogResult = True Then

        'End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

End Class
