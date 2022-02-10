Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports System.Web
Imports SIF.Control2005.User

Public Class frmMantContratos

    Private oCompania As clsCompania


    Private _NRCTCL As Decimal
    Public Property NRCTCL() As Decimal
        Get
            Return _NRCTCL
        End Get
        Set(ByVal value As Decimal)
            _NRCTCL = value
        End Set
    End Property


    Private _NRCTSL As Decimal
    Public Property NRCTSL() As Decimal
        Get
            Return _NRCTSL
        End Get
        Set(ByVal value As Decimal)
            _NRCTSL = value
        End Set
    End Property


    Private _SESTRG As String
    Public Property SESTRG() As String
        Get
            Return _SESTRG
        End Get
        Set(ByVal value As String)
            _SESTRG = value
        End Set
    End Property

    Private _CCMPN As String
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property



    Private Sub tsbGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGrabar.Click
        'Guardar()
        Try
            If flbolValidas() Then
                Exit Sub
            End If
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Dim oContrato As New SOLMIN_CTZ.Entidades.Contrato
            '==============INsertamos los clientes seleccionados
            Dim obrContrato As New clsContrato
      

            oContrato.CCMPN = _CCMPN 'oUsuario.Compania
            oContrato.NRCTCL = _NRCTCL
            oContrato.NRCTSL = _NRCTSL

            oContrato.NCNTRT = Me.txtDatNumContrato.Text.Trim
            oContrato.DESCTR = Me.txtDatDescContrato.Text.Trim
            oContrato.TCNCTO = Me.txtDatContContrato.Text.Trim
            oContrato.TMACTO = Me.txtDatCorreoContrato.Text.Trim
            oContrato.NTLCTO = Me.txtDatTelContrato.Text.Trim
            If Me.mskDatIniContrato.Text.Trim = "/  /" Then
                oContrato.FECINI = 0
            Else
                oContrato.FECINI = Format(CType(Me.mskDatIniContrato.Text.Trim, Date), "yyyyMMdd")
            End If
            If Me.mskDatFinContrato.Text.Trim = "/  /" Then
                oContrato.FECFIN = 0
            Else
                oContrato.FECFIN = Format(CType(Me.mskDatFinContrato.Text.Trim, Date), "yyyyMMdd")
            End If
            oContrato.SESTRG = cmbEstadoCont.SelectedValue
            If NRCTSL = 0 Then
                NRCTSL = obrContrato.fIntCrearContrato(oContrato)
                '================================
                Dim olisClienteContrato As New List(Of SOLMIN_CTZ.Entidades.Contrato)
                For intX As Integer = 0 To Me.dtgRelacionCliente.RowCount - 1
                    If dtgRelacionCliente.Rows(intX).Cells("Chk").Value Then
                        oContrato = New SOLMIN_CTZ.Entidades.Contrato
                        oContrato.NRCTSL = NRCTSL
                        oContrato.CCMPN = CCMPN
                        oContrato.CCLNT = dtgRelacionCliente.Rows(intX).Cells("CCLNT_R").Value
                        olisClienteContrato.Add(oContrato)
                    End If
                Next
                If obrContrato.fIntInsertarClienteXContrato(olisClienteContrato) = -1 Then
                    HelpClass.MsgBox("Error al guardar los clientes del contrato")
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    Exit Sub
                End If
                Me.Cursor = System.Windows.Forms.Cursors.Default
                HelpClass.MsgBox("Se agregó un nuevo contrato correctamente")
            Else
                obrContrato.Actualizar_Datos_Contrato(oContrato)
                Me.Cursor = System.Windows.Forms.Cursors.Default
                HelpClass.MsgBox("Se modificó correctamente")
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub frmMantContratos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Cargar()
        Try
            Dim obrEstado As New clsEstado
            Me.cmbEstadoCont.DataSource = obrEstado.Estado_Contrato(_SESTRG)
            Me.cmbEstadoCont.ValueMember = "COD"
            Me.cmbEstadoCont.DisplayMember = "TEX"

            If _NRCTSL <> 0 Then
                btnAddCliente.Enabled = True

                txtDatNumContrato.Enabled = False


                'Cargar Cliente 
                Dim oContrato As New SOLMIN_CTZ.Entidades.Contrato
                Dim obrContrato As New clsContrato
                oContrato.CCMPN = _CCMPN
                oContrato.NRCTSL = NRCTSL
                dtgRelacionCliente.AutoGenerateColumns = False
                dtgRelacionCliente.Columns("Chk").Visible = False
                Me.dtgRelacionCliente.DataSource = obrContrato.flisCargarClienteXContrato(oContrato)


                'cmbClientes.Properties.ValueMember = "CCLNT"
                'cmbClientes.Properties.DisplayMember = "TCMPCL"
                'cmbClientes.CheckAll()
                'Dim oCliente As New clsCliente
                'Dim obeCliente As New Cliente
                'obeCliente.CCMPN = _CCMPN
                'obeCliente.NRCTCL = _NRCTCL
                'Me.cmbClientes.Properties.DataSource = oCliente.floListaClienteXGrupo(obeCliente)
                'cmbClientes.Properties.ValueMember = "CCLNT"
                'cmbClientes.Properties.DisplayMember = "TCMPCL"


                'Cargar_Datos_Contrato()

                oContrato.NRCTSL = _NRCTSL
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                oContrato = obrContrato.Cargar_Datos_Contrato(oContrato)
                Me.txtDatNumContrato.Text = oContrato.NCNTRT.Trim
                Me.txtDatDescContrato.Text = oContrato.DESCTR.Trim
                Me.txtDatObsContrato.Text = oContrato.TOBS.Trim
                Me.txtDatContContrato.Text = oContrato.TCNCTO.Trim
                Me.txtDatCorreoContrato.Text = oContrato.TMACTO.Trim
                Me.txtDatTelContrato.Text = oContrato.NTLCTO.Trim
                Me.mskDatIniContrato.Text = oContrato.FechaInicio
                Me.mskDatFinContrato.Text = oContrato.FechaFin

                Dim oEstado As New clsEstado
                Me.cmbEstadoCont.DataSource = oEstado.Estado_Contrato(_SESTRG)
                Me.cmbEstadoCont.ValueMember = "COD"
                Me.cmbEstadoCont.DisplayMember = "TEX"
                Me.Cursor = System.Windows.Forms.Cursors.Default
            Else
                btnAddCliente.Enabled = False
                Cargar_ClientesXGrupo()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub Cargar_ClientesXGrupo()
        'Cargar Cliente 
        Dim oCliente As New clsCliente
        Dim obeCliente As New Cliente
        obeCliente.CCMPN = _CCMPN
        obeCliente.NRCTCL = _NRCTCL
        dtgRelacionCliente.AutoGenerateColumns = False
        Me.dtgRelacionCliente.DataSource = oCliente.floListaClienteXGrupo(obeCliente)


    End Sub



    Private Function flbolValidas() As Boolean
        Dim strMensaje As String = String.Empty
        Me.dtgRelacionCliente.EndEdit()
        Dim intCont As Integer = 0
        If (txtDatNumContrato.Text.Trim = "") Then
            strMensaje = "* Ingrese el Número de contrato" & Chr(10)
            txtDatNumContrato.Focus()
        End If
        If Not IsDate(mskDatFinContrato.Text.Trim) Or Not IsDate(mskDatIniContrato.Text.Trim) Then
            strMensaje = strMensaje & "* Ingrese la Fecha correcta" & Chr(10)
        End If

        If NRCTSL = 0 Then
            For IntX As Integer = 0 To dtgRelacionCliente.RowCount - 1
                If dtgRelacionCliente.Rows(IntX).Cells("Chk").Value Then
                    intCont += 1
                End If
            Next
            If intCont = 0 Then
                strMensaje = strMensaje & "* Debe de seleccionar por lo menos un Cliente" & Chr(10)
            End If

        End If
     
        If strMensaje.Trim.Length > 0 Then
            MsgBox(strMensaje, MsgBoxStyle.Information)
            Return True
        End If
        Return False
    End Function


    'Private Sub Cargar()
    '    Dim obrEstado As New clsEstado
    '    Me.cmbEstadoCont.DataSource = obrEstado.Estado_Contrato(_SESTRG)
    '    Me.cmbEstadoCont.ValueMember = "COD"
    '    Me.cmbEstadoCont.DisplayMember = "TEX"

    'End Sub

    'Private Sub Cargar_Datos_Contrato()
    'Try
    'Dim oContrato As New SOLMIN_CTZ.Entidades.Contrato
    'Dim obrContrato As New clsContrato
    'oContrato.NRCTSL = _NRCTSL
    'Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
    'oContrato = obrContrato.Cargar_Datos_Contrato(oContrato)
    'Me.txtDatNumContrato.Text = oContrato.NCNTRT.Trim
    'Me.txtDatDescContrato.Text = oContrato.DESCTR.Trim
    'Me.txtDatObsContrato.Text = oContrato.TOBS.Trim
    'Me.txtDatContContrato.Text = oContrato.TCNCTO.Trim
    'Me.txtDatCorreoContrato.Text = oContrato.TMACTO.Trim
    'Me.txtDatTelContrato.Text = oContrato.NTLCTO.Trim
    'Me.mskDatIniContrato.Text = oContrato.FechaInicio
    'Me.mskDatFinContrato.Text = oContrato.FechaFin

    'Dim oEstado As New clsEstado
    'Me.cmbEstadoCont.DataSource = oEstado.Estado_Contrato(_SESTRG)
    'Me.cmbEstadoCont.ValueMember = "COD"
    'Me.cmbEstadoCont.DisplayMember = "TEX"

    'Me.Cursor = System.Windows.Forms.Cursors.Default
    'Catch ex As Exception
    '    Me.Cursor = System.Windows.Forms.Cursors.Default
    '    HelpClass.MsgBox(ex.Message)
    'End Try
    'End Sub

    'Private Sub Guardar()
    '    Try
    '        If flbolValidas() Then
    '            Exit Sub
    '        End If
    '        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
    '        Dim oContrato As New SOLMIN_CTZ.Entidades.Contrato
    '        Dim obrContrato As New clsContrato
    '        oContrato.CCMPN = _CCMPN 'oUsuario.Compania
    '        oContrato.NRCTCL = _NRCTCL
    '        oContrato.NRCTSL = _NRCTSL

    '        oContrato.NCNTRT = Me.txtDatNumContrato.Text.Trim
    '        oContrato.DESCTR = Me.txtDatDescContrato.Text.Trim
    '        oContrato.TCNCTO = Me.txtDatContContrato.Text.Trim
    '        oContrato.TMACTO = Me.txtDatCorreoContrato.Text.Trim
    '        oContrato.NTLCTO = Me.txtDatTelContrato.Text.Trim
    '        If Me.mskDatIniContrato.Text.Trim = "/  /" Then
    '            oContrato.FECINI = 0
    '        Else
    '            oContrato.FECINI = Format(CType(Me.mskDatIniContrato.Text.Trim, Date), "yyyyMMdd")
    '        End If
    '        If Me.mskDatFinContrato.Text.Trim = "/  /" Then
    '            oContrato.FECFIN = 0
    '        Else
    '            oContrato.FECFIN = Format(CType(Me.mskDatFinContrato.Text.Trim, Date), "yyyyMMdd")
    '        End If
    '        oContrato.SESTRG = cmbEstadoCont.SelectedValue
    '        If NRCTSL = 0 Then
    '            obrContrato.Crear_Contrato(oContrato)
    '            Me.Cursor = System.Windows.Forms.Cursors.Default
    '            HelpClass.MsgBox("Se agregó un nuevo contrato correctamente")
    '        Else
    '            obrContrato.Actualizar_Datos_Contrato(oContrato)
    '            Me.Cursor = System.Windows.Forms.Cursors.Default
    '            HelpClass.MsgBox("Se modificó correctamente")
    '        End If

    '        Me.DialogResult = Windows.Forms.DialogResult.OK
    '    Catch ex As Exception
    '        Me.Cursor = System.Windows.Forms.Cursors.Default
    '        HelpClass.MsgBox(ex.Message)
    '    End Try
    'End Sub

 




    Private Sub cmbClientes_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.txtDatNumContrato.Text.Trim.Length > 0 Then
            Me.txtDatContContrato.Text = ""
        End If
    End Sub

    Private Sub btnBuscarContratoSAD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarContratoSAD.Click
   
        dtgRelacionCliente.EndEdit()
        Dim ofrmBuscarContratoSAD As New SIF.Control2005.User.FrmBuscarDocumento

        Dim lobjSql As New SqlManager
        Dim ostrCodCliente As String = String.Empty
        For intX As Integer = 0 To Me.dtgRelacionCliente.RowCount - 1
            If dtgRelacionCliente.Rows(intX).Cells("Chk").Value Then
                ostrCodCliente = ostrCodCliente & dtgRelacionCliente.Rows(intX).Cells("CCLNT_R").Value & ","
            End If
        Next
        Try
            If ostrCodCliente.Length > 0 Then
                ostrCodCliente = ostrCodCliente.Substring(0, ostrCodCliente.Length - 1)
            End If
            ofrmBuscarContratoSAD.strCodigoCliente = ostrCodCliente
            ofrmBuscarContratoSAD.strConnection = lobjSql.Conectar()
            ofrmBuscarContratoSAD.ShowDialog()
            txtDatNumContrato.Text = ofrmBuscarContratoSAD.strNumContrato

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub

    Private Sub dtgRelacionCliente_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgRelacionCliente.CellContentClick
        Try
            Me.dtgRelacionCliente.EndEdit()
            Dim Colname As String = Me.dtgRelacionCliente.Columns(e.ColumnIndex).Name
            Select Case Colname
                Case "Chk"
                    Me.txtDatNumContrato.Text = ""
                Case "COL_ELIMIN"


                    If dtgRelacionCliente.Rows.Count = 1 Then
                        MessageBox.Show("Para eliminar debe haber más de un cliente relacionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If

                    If MessageBox.Show("¿ Está seguro de eliminar cliente?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                        Dim oContrato As New SOLMIN_CTZ.Entidades.Contrato
                        Dim obrContrato As New clsContrato

                        oContrato.CCMPN = _CCMPN
                        oContrato.NRCTSL = NRCTSL
                        oContrato.CCLNT = dtgRelacionCliente.CurrentRow.Cells("CCLNT_R").Value
                        obrContrato.EliminarClienteXContrato(oContrato)

                        MessageBox.Show("Cliente eliminado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)


                        oContrato.CCMPN = _CCMPN
                        oContrato.NRCTSL = NRCTSL
                        dtgRelacionCliente.AutoGenerateColumns = False
                        dtgRelacionCliente.Columns("Chk").Visible = False
                        Me.dtgRelacionCliente.DataSource = obrContrato.flisCargarClienteXContrato(oContrato)

                       


                        'dtgRelacionCliente.AutoGenerateColumns = False
                        'dtgRelacionCliente.Columns("Chk").Visible = False


                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    
        'If Me.dtgRelacionCliente.Columns(e.ColumnIndex).Name = "Chk" Then
        '    Me.txtDatNumContrato.Text = ""
        'End If


    End Sub


    Private Sub dtgRelacionCliente_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs)

        Try
            For intRows As Integer = 0 To Me.dtgRelacionCliente.RowCount - 1
                dtgRelacionCliente.Rows(intRows).Cells("chk").Value = True
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnAddCliente_Click(sender As Object, e As EventArgs) Handles btnAddCliente.Click
        Try


            Dim oContrato As New SOLMIN_CTZ.Entidades.Contrato
            Dim obrContrato As New clsContrato

            oContrato.CCMPN = _CCMPN
            oContrato.NRCTSL = NRCTSL


            Dim ofrm As New frmAgregarClienteContrato
            ofrm.pCCMPN = _CCMPN
            ofrm.pNRCTCL = NRCTCL
            ofrm.pNRCTSL = NRCTSL

            Dim pClienteEnLista As New List(Of String)
            For Each item As DataGridViewRow In dtgRelacionCliente.Rows
                pClienteEnLista.Add(("" & item.Cells("CCLNT_R").Value).ToString.Trim)
            Next
            ofrm.pClienteEnLista = pClienteEnLista

            ofrm.ShowDialog()
            If ofrm.pDialog = True Then
                dtgRelacionCliente.AutoGenerateColumns = False
                dtgRelacionCliente.Columns("Chk").Visible = False
                Me.dtgRelacionCliente.DataSource = obrContrato.flisCargarClienteXContrato(oContrato)
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
