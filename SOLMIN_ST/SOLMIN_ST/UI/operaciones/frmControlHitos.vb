Imports System.Windows.Forms
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.ENTIDADES.Operaciones
'Imports Ransa.DAO.TipoAyuda

Public Class frmControlHitos

    Dim objHito As New ENTIDADES.HitoOperacion


    Public pNOPRCN As String = ""

    Public pNGUIRM As String = ""

    Public pCCMPN As String = ""

    Public pCTRMNC As String = ""

    Public pCCLNT As String = ""
    Private ListaIncidencia As New DataTable

    Public pSNTVJE As String = ""

    Private oHasHitoGT As New Hashtable
 
    '
    Public pDESTINO As String = ""
 

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub ListarHitos()
        'Carga los Items de los hitos de control
        Dim dtbListaHitos As New DataTable
        Dim objcontrolhito As New ControlHito
        Dim objHitooperacion As New HitoOperacion
        objcontrolhito.CCLNT = pCCLNT

        objcontrolhito.SNTVJE = pSNTVJE
        Dim objHito As New ControlHitos_BLL


       

        Dim ds As New DataSet
        Dim dtbHitosOperacion As New DataTable
        Dim dtGuia As New DataTable
      
        objHitooperacion.NOPRCN = pNOPRCN
        objHitooperacion.NGUIRM = pNGUIRM
        objHitooperacion.CTRMNC = pCTRMNC
        objHitooperacion.CCLNT = pCCLNT
        objHitooperacion.SNTVJE = pSNTVJE

        ds = objHito.ConsultaHitosRegistrados(objHitooperacion)
        dtbHitosOperacion = ds.Tables(0)
        dtGuia = ds.Tables(1)

        Me.dtgDatos.DataSource = dtbHitosOperacion
        dtgGuias.DataSource = dtGuia
        HabilitarCheckGuia(False)


    End Sub


    Private Sub HabilitarCheckGuia(ByVal parcial As Boolean)

        If dtgDatos.CurrentRow Is Nothing Then
            Exit Sub
        End If
        dtgGuias.EndEdit()
        Dim COD_HITO As String = dtgDatos.CurrentRow.Cells("NESTDO").Value


    


        If ckbEntregaParcial.Checked = True And (dtgDatos.CurrentRow.Cells("ENVIA_GR").Value = "S") Then
            dtpFecha.Enabled = False
            txtHoraInicio.Enabled = False
            cboIncidencia.Enabled = False
            txtObservacion.Enabled = False

            dtpFechaParcial.Enabled = True
            txtLugarParcial.Enabled = True
            txthoraparcial.Enabled = True
        Else
            dtpFecha.Enabled = True
            txtHoraInicio.Enabled = True
            cboIncidencia.Enabled = True
            txtObservacion.Enabled = True


            dtpFechaParcial.Enabled = False
            txtLugarParcial.Enabled = False
            txthoraparcial.Enabled = False


        End If


      

       

    End Sub



    Private Sub frmControlHitos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            dtpFecha.Value = Now

            'echa.ToString("dd/MM/yyyy, HH:mm:ss")
            txthoraparcial.Text = Now.ToString("HH:mm:ss")
            txtHoraInicio.Text = Now.ToString("HH:mm:ss")
            dtpFechaParcial.Value = Now

            Dim oblTipoDatoGeneral As New NEGOCIO.Operaciones.TipoDatoGeneral_BLL
            Dim oListTipoDato As New List(Of TipoDatoGeneral)
            oListTipoDato = oblTipoDatoGeneral.Lista_Tipo_Dato_General(pCCMPN, "STRQPL")
            For Each Item As TipoDatoGeneral In oListTipoDato
                oHasHitoGT(Item.CODIGO_TIPO) = Item.CODIGO_TIPO
            Next

            Me.dtgDatos.AutoGenerateColumns = False
            dtgGuias.AutoGenerateColumns = False
            Me.ckbEntregaParcial.Enabled = False
            txtLugarEntrega.Enabled = False
            txtLugarEntrega.Text = pDESTINO

            Dim dtbIncidencias As New DataTable



            Dim oListTipoIncidencias As New List(Of TipoDatoGeneral)
            oListTipoIncidencias = oblTipoDatoGeneral.Lista_Tipo_Dato_General(pCCMPN, "STINSH")
            dtbIncidencias.Columns.Add("TDSDES")
            dtbIncidencias.Columns.Add("CCMPRN")
            Dim drInc As DataRow
            For Each Item As TipoDatoGeneral In oListTipoIncidencias
                drInc = dtbIncidencias.NewRow
                drInc("CCMPRN") = Item.CODIGO_TIPO
                drInc("TDSDES") = Item.DESC_TIPO
                dtbIncidencias.Rows.Add(drInc)
            Next
            'dtbIncidencias = cTipoAyuda.ListarTablaAyuda("STINSH")
            ListaIncidencia = dtbIncidencias.Copy

            Dim dr As DataRow = dtbIncidencias.NewRow
            dr("TDSDES") = "--- Escoja Elemento ---"
            dr("CCMPRN") = "0"
            dtbIncidencias.Rows.InsertAt(dr, 0)

            With cboIncidencia
                .DataSource = dtbIncidencias
                .DisplayMember = "TDSDES"
                .ValueMember = "CCMPRN"
            End With

            Me.cboIncidencia.SelectedIndex = 0
            Me.lblOperacion.Text = pNOPRCN
            lblGuiaTransp.Text = pNGUIRM
            ListarHitos()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub LimpiarControles()
        cboIncidencia.SelectedIndex = 0
        Me.dtpFecha.Value = Today
        Me.txtObservacion.Text = String.Empty
        Me.txtLugarEntrega.Text = String.Empty
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            If dtgDatos.CurrentRow Is Nothing Then
                Exit Sub
            End If

            Dim GuardarHito As String = "N"
            Dim EsRegHoraObligatorio As String = dtgDatos.CurrentRow.Cells("ES_HORA_OBLIGAT").Value.ToString.Trim


            dtgGuias.EndEdit()
            If dtgDatos.CurrentRow.Cells("REQUIERE_GT").Value = "N" Then
                MessageBox.Show("Requiere de Guía Transportes", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim IdHito As Decimal = dtgDatos.CurrentRow.Cells("NESTDO").Value

            Dim validacion As New System.Text.StringBuilder
            Dim objLogicaHito As New ControlHitos_BLL

         

            If EsRegHoraObligatorio = "S" Then
                If Me.txtHoraInicio.Text = "00:00" Then
                    validacion.Append("* Ingresar hora." & Chr(13))
                End If
                Dim hrainicio As Date
                If DateTime.TryParse(Me.txtHoraInicio.Text, hrainicio) = False Then
                    validacion.Append("* Formato de hora incorrecto." & Chr(13))
                End If
            End If
           
            If ckbEntregaParcial.Checked = True And dtgDatos.CurrentRow.Cells("ENVIA_GR").Value = "S" Then

                If EsRegHoraObligatorio = "S" Then
                    If Me.txthoraparcial.Text = "00:00" Then
                        validacion.Append("* Ingresar hora parcial." & Chr(13))
                    End If
                    Dim hra_pracial As Date
                    If DateTime.TryParse(Me.txthoraparcial.Text.Trim, hra_pracial) = False Then
                        validacion.Append("* Formato de hora parcial incorrecto." & Chr(13))
                    End If
                   
                End If


            End If


            If validacion.Length > 0 Then
                MsgBox(validacion.ToString())
                Exit Sub
            End If


            Dim objHito As New HitoOperacion
            Dim oListGuiasRemision As New List(Of HitoOperacion)
            Dim msg As String = ""


            If dtgDatos.CurrentRow.Cells("ENVIA_GR").Value = "S" Then

                If ckbEntregaParcial.Checked = True Then

                    For Each Item As DataGridViewRow In dtgGuias.Rows
                        If Item.Cells("CHKGUIA").Value = True Then
                            Dim obeGuiaRem As New HitoOperacion
                            obeGuiaRem.CTRMNC = pCTRMNC
                            obeGuiaRem.NGUITR = pNGUIRM
                            obeGuiaRem.NOPRCN = pNOPRCN
                            obeGuiaRem.NESTDO = IdHito
                            obeGuiaRem.GR_CLIENTE = Item.Cells("GUIA_REM_CLIENTE").Value  '
                            obeGuiaRem.FRETES = HelpClass.CDate_a_Numero8Digitos(Me.dtpFechaParcial.Value)
                            obeGuiaRem.HRAREA = txthoraparcial.Text.Trim.Substring(0, 2) & txthoraparcial.Text.Trim.Substring(3, 2) & "00"
                            obeGuiaRem.LUGENTREGA = txtLugarParcial.Text.Trim
                            obeGuiaRem.CUSCRT = MainModule.USUARIO
                            obeGuiaRem.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
                            oListGuiasRemision.Add(obeGuiaRem)
                        End If
                    Next

                    GuardarHito = "N"
                Else

                    With objHito
                        .NOPRCN = pNOPRCN
                        .NESTDO = IdHito
                        .NGUIRM = pNGUIRM
                        .CTRMNC = pCTRMNC
                        .FRETES = HelpClass.CDate_a_Numero8Digitos(Me.dtpFecha.Value)
                        .HRAREA = txtHoraInicio.Text.Trim.Substring(0, 2) & txtHoraInicio.Text.Trim.Substring(3, 2) & "00"
                        .TOBEST = txtObservacion.Text.Trim
                        If Me.cboIncidencia.SelectedValue = "0" Then
                            .INCVJE = ""
                        Else
                            .INCVJE = Me.cboIncidencia.SelectedValue
                        End If
                        .LUGENTREGA = txtLugarEntrega.Text.Trim
                        .CUSCRT = MainModule.USUARIO
                        .NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina

                    End With


                    For Each Item As DataGridViewRow In dtgGuias.Rows
                        If Item.Cells("CHKGUIA").Value = True Then
                            Dim obeGuiaRem As New HitoOperacion
                            obeGuiaRem.CTRMNC = pCTRMNC
                            obeGuiaRem.NGUITR = pNGUIRM
                            obeGuiaRem.NOPRCN = pNOPRCN
                            obeGuiaRem.NESTDO = IdHito
                            obeGuiaRem.GR_CLIENTE = Item.Cells("GUIA_REM_CLIENTE").Value  '
                            obeGuiaRem.FRETES = HelpClass.CDate_a_Numero8Digitos(Me.dtpFecha.Value)
                            obeGuiaRem.HRAREA = txtHoraInicio.Text.Trim.Substring(0, 2) & txtHoraInicio.Text.Trim.Substring(3, 2) & "00"
                            obeGuiaRem.LUGENTREGA = txtLugarEntrega.Text.Trim
                            obeGuiaRem.CUSCRT = MainModule.USUARIO
                            obeGuiaRem.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
                            oListGuiasRemision.Add(obeGuiaRem)
                        End If
                    Next

                    GuardarHito = "S"

                End If

            Else

                With objHito
                    .NOPRCN = pNOPRCN
                    .NESTDO = IdHito
                    .NGUIRM = pNGUIRM
                    .CTRMNC = pCTRMNC
                    .FRETES = HelpClass.CDate_a_Numero8Digitos(Me.dtpFecha.Value)
                    .HRAREA = txtHoraInicio.Text.Trim.Substring(0, 2) & txtHoraInicio.Text.Trim.Substring(3, 2) & "00"
                    .TOBEST = txtObservacion.Text.Trim
                    If Me.cboIncidencia.SelectedValue = "0" Then
                        .INCVJE = ""
                    Else
                        .INCVJE = Me.cboIncidencia.SelectedValue
                    End If
                    .LUGENTREGA = txtLugarEntrega.Text.Trim
                    .CUSCRT = MainModule.USUARIO
                    .NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina

                End With

                GuardarHito = "S"
            End If

            If GuardarHito = "S" Then
                msg = objLogicaHito.RegistrarHito(objHito)
                If msg.Length > 0 Then
                    MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End If
            For Each obeGuiaRem As HitoOperacion In oListGuiasRemision
                objLogicaHito.ActualizarGuiaRemision(obeGuiaRem)
            Next
            MsgBox("Hito guardado correctamente")
            ListarHitos()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub




    Private Sub dtgDatos_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgDatos.SelectionChanged
        Me.ckbEntregaParcial.Enabled = False
        ckbEntregaParcial.Checked = False

        Try
            If dtgDatos.CurrentRow Is Nothing Then
                Exit Sub
            End If

           


            Dim hito As String
            hito = ("" & dtgDatos.CurrentRow.Cells("TCOLUM").Value.ToString()).Trim
            Me.txtHito.Text = hito.ToUpper()
            Dim obs As String = ("" & dtgDatos.CurrentRow.Cells("TOBEST").Value.ToString()).Trim
            Dim CodInciVje As String = ("" & dtgDatos.CurrentRow.Cells("INCVJE").Value).ToString.Trim
            Dim fecha As String = ("" & dtgDatos.CurrentRow.Cells("FRETES").Value).ToString.Trim
            Dim hora As String = ("" & dtgDatos.CurrentRow.Cells("HRAREA").Value).ToString.Trim

            If fecha <> "" Then
                dtpFecha.Value = fecha
            Else
                dtpFecha.Value = Now
            End If

            If hora <> "" Then
                txtHoraInicio.Text = hora
            Else
                txtHoraInicio.Text = Now.ToString("HH:mm:ss")
            End If

            If CodInciVje = "" Or CodInciVje = "0" Then
                cboIncidencia.SelectedValue = "0"
            Else
                cboIncidencia.SelectedValue = CodInciVje
            End If
            txtObservacion.Text = obs

            If dtgDatos.CurrentRow.Cells("ENVIA_GR").Value = "S" Then
                Me.ckbEntregaParcial.Enabled = True
                dtgGuias.Columns("CHKGUIA").Visible = True
                For Each Item As DataGridViewRow In dtgGuias.Rows
                    If Item.Cells("FLGCNL").Value = "X" Then
                        Item.Cells("CHKGUIA").Value = False
                    Else
                        Item.Cells("CHKGUIA").Value = True
                    End If
                Next

            Else
                dtgGuias.Columns("CHKGUIA").Visible = False
            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ckbEntregaParcial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbEntregaParcial.CheckedChanged

        If dtgGuias.Rows.Count = 0 Then
            ckbEntregaParcial.Checked = False
            Exit Sub
        End If

        HabilitarCheckGuia(ckbEntregaParcial.Checked)
        If ckbEntregaParcial.Checked = True Then
            dtpFechaParcial.Enabled = True
            txtLugarParcial.Enabled = True
            txthoraparcial.Enabled = True
        Else
            dtpFechaParcial.Enabled = False
            txtLugarParcial.Text = ""
            txtLugarParcial.Enabled = False
            txthoraparcial.Enabled = False
        End If

    End Sub

    

    Private Sub dtgDatos_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgDatos.CellClick
        Dim msg As String = ""
        Try
            If e.ColumnIndex >= 0 AndAlso dtgDatos.Columns(e.ColumnIndex).Name = "btnEliminar" Then

                If ("" & dtgDatos.CurrentRow.Cells("FRETES").Value).ToString.Trim <> "" Then
                    If MessageBox.Show("¿Está seguro de anular el registo del hito?", "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If

                    Dim objLogicaHito As New ControlHitos_BLL
                    Dim objHito As New HitoOperacion
                    Dim IdHito As Decimal = dtgDatos.CurrentRow.Cells("NESTDO").Value
                    objHito.NOPRCN = pNOPRCN
                    objHito.NESTDO = IdHito
                    objHito.NGUIRM = pNGUIRM
                    objHito.CTRMNC = pCTRMNC
                    objHito.CUSCRT = MainModule.USUARIO
                    objHito.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
                    msg = objLogicaHito.EliminarHito(objHito)
                    If msg.Length > 0 Then
                        MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                    ListarHitos()
                End If

              
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
