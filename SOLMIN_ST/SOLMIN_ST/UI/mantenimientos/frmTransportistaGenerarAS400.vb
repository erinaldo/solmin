Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones
Public Class frmTransportistaGenerarAS400
    Enum Accion
        NUEVO
        MODIFICAR
        NEUTRO
    End Enum
    Private pAccion As Accion = Accion.NEUTRO
    Private oLisResponSeg As New List(Of TipoDatoGeneral)
    Private Sub Habilitar_Boton()
        txtcodigo_mant.Enabled = False
        txtcodsap_mant.Enabled = False
        txtrazon_mant.Enabled = False
        txtruc_mant.Enabled = False
        'cmbPolizaSeguro.Enabled = False
        cmbPolizaSeguro.ComboBox.Enabled = False

        txtPorSeguro.Enabled = False
        txtDireccionTransportista.Enabled = False
        txtAbrev.Enabled = False

        Select Case pAccion
            Case Accion.NEUTRO
                btnnuevo.Enabled = True
                btnGuardar.Visible = False
                btnCancelar.Visible = False
                btnModificar.Enabled = True

            Case Accion.MODIFICAR
                btnnuevo.Enabled = False
                btnGuardar.Visible = True
                btnCancelar.Visible = True
                btnModificar.Enabled = False

                txtcodsap_mant.Enabled = True
                txtrazon_mant.Enabled = True
                txtruc_mant.Enabled = True

                'cmbPolizaSeguro.Enabled = True
                cmbPolizaSeguro.ComboBox.Enabled = True
                txtPorSeguro.Enabled = True
                txtDireccionTransportista.Enabled = True
                txtAbrev.Enabled = True


            Case Accion.NUEVO
                btnnuevo.Enabled = False
                btnGuardar.Visible = True
                btnCancelar.Visible = True
                btnModificar.Enabled = False


                txtcodsap_mant.Enabled = True
                txtrazon_mant.Enabled = True
                txtruc_mant.Enabled = True

                'cmbPolizaSeguro.Enabled = True
                cmbPolizaSeguro.ComboBox.Enabled = True
                txtPorSeguro.Enabled = True
                txtDireccionTransportista.Enabled = True
                txtAbrev.Enabled = True

        End Select
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            UcPaginacion1.PageNumber = 1
            Listar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Listar()
        gwdDatos.DataSource = Nothing
        Dim TotPag As Decimal = 0
        Dim obrTransportistaAS400_BLL As New NEGOCIO.mantenimientos.TransportistaAS400_BLL
        Dim dtAS400 As New DataTable
        Dim obj As New ENTIDADES.mantenimientos.Transportista
        obj.CTRSPT = Val(txtcod.Text.Trim)
        obj.NRUCTR = txtruc.Text.Trim.ToUpper
        obj.TCMTRT = txtrazonsocial.Text.Trim.ToUpper
        obj.COD_SAP = txtfiltro_codsap.Text.Trim.ToUpper
        dtAS400 = obrTransportistaAS400_BLL.Listar_TransportistaAS400_LIST_RZTR10(obj, UcPaginacion1.PageNumber, UcPaginacion1.PageSize, TotPag)
        UcPaginacion1.PageCount = TotPag
        gwdDatos.DataSource = dtAS400


    
    End Sub


    Private Sub gwdDatos_SelectionChanged(sender As Object, e As EventArgs) Handles gwdDatos.SelectionChanged
        Try

            txtcodigo_mant.Text = ""
            txtcodsap_mant.Text = ""
            txtrazonsocial.Text = ""
            txtruc_mant.Text = ""

            cmbPolizaSeguro.SelectedValue = ""
            txtAbrev.Text = ""
            txtDireccionTransportista.Text = ""
            txtPorSeguro.Text = "0"


            



            pAccion = Accion.NEUTRO
            Habilitar_Boton()

            If gwdDatos.CurrentRow Is Nothing Then
                Exit Sub
            End If
            txtcodigo_mant.Text = gwdDatos.CurrentRow.Cells("CTRSPT").Value
            txtcodsap_mant.Text = ("" & gwdDatos.CurrentRow.Cells("RUCPR2").Value).ToString.Trim
            txtrazon_mant.Text = ("" & gwdDatos.CurrentRow.Cells("TCMTRT").Value).ToString.Trim
            txtruc_mant.Text = ("" & gwdDatos.CurrentRow.Cells("NRUCTR").Value).ToString.Trim

            txtDireccionTransportista.Text = ("" & gwdDatos.CurrentRow.Cells("DIREC").Value).ToString.Trim
            txtAbrev.Text = ("" & gwdDatos.CurrentRow.Cells("TABTRT").Value).ToString.Trim
            'cmbPolizaSeguro.SelectedValue = ("" & gwdDatos.CurrentRow.Cells("COD_RESPSEG").Value).ToString.Trim
            cmbPolizaSeguro.ComboBox.SelectedValue = ("" & gwdDatos.CurrentRow.Cells("COD_RESPSEG").Value).ToString.Trim
            txtPorSeguro.Text = gwdDatos.CurrentRow.Cells("PCRSGR").Value

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        Try
            pAccion = Accion.NUEVO



            txtcodigo_mant.Text = "0"
            txtrazon_mant.Text = ""
            txtcodsap_mant.Text = ""
            txtruc_mant.Text = ""

            'cmbPolizaSeguro.SelectedValue = ""
            cmbPolizaSeguro.ComboBox.SelectedValue = ""
            txtAbrev.Text = ""
            txtDireccionTransportista.Text = ""
            txtPorSeguro.Text = "0"


            Habilitar_Boton()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            pAccion = Accion.MODIFICAR
            Habilitar_Boton()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmTransportistaGenerarAS400_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            pAccion = Accion.NEUTRO
            gwdDatos.AutoGenerateColumns = False
            Habilitar_Boton()

            Dim oTipoDatoGeneral_BLL As New TipoDatoGeneral_BLL
            oLisResponSeg = oTipoDatoGeneral_BLL.Lista_Tipo_Dato_General_RZPR05("RESPSEGCARGA")
            Dim oTemp As New TipoDatoGeneral
            oTemp.CODIGO_TIPO = ""
            oTemp.DESC_TIPO = "::Seleccione::"
            oLisResponSeg.Insert(0, oTemp)

            cmbPolizaSeguro.DataSource = oLisResponSeg
            cmbPolizaSeguro.DisplayMember = "DESC_TIPO"
            cmbPolizaSeguro.ValueMember = "CODIGO_TIPO"
            
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try

            Dim msg_validar As String = ""
            If txtruc_mant.Text.Trim = "" Then
                msg_validar = msg_validar & "RUC" & Chr(13)
            End If
            If txtrazon_mant.Text.Trim = "" Then
                msg_validar = msg_validar & "Razón Social" & Chr(13)
            End If
            'If txtcodsap_mant.Text.Trim = "" Then
            '    msg_validar = msg_validar & "Código SAP" & Chr(13)
            'End If

            If cmbPolizaSeguro.SelectedValue = "" Then
                msg_validar = msg_validar & "Póliza Seguro" & Chr(13)
            End If
            If cmbPolizaSeguro.ComboBox.SelectedValue = "R" Then
                If Val(txtPorSeguro.Text.Trim) = 0 Then
                    msg_validar = msg_validar & "%Seguro mayor a cero." & Chr(13)
                End If
            End If


            msg_validar = msg_validar.Trim

            If msg_validar.Length > 0 Then
                MessageBox.Show("Ingrese:" & Chr(13) & msg_validar, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If




            Dim msg As String = ""
            Select Case pAccion
                Case Accion.NUEVO

                    Dim obj As New Transportista_BLL
                    Dim objEntidad As New Transportista
                    objEntidad.CTRSPT = 0
                    objEntidad.NRUCTR = txtruc_mant.Text.Trim
                    objEntidad.TCMTRT = txtrazon_mant.Text.Trim
                    objEntidad.CUSCRT = MainModule.USUARIO
                    objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
                    objEntidad.RUCPR2 = txtcodsap_mant.Text.Trim

                    objEntidad.TDRCTR = txtDireccionTransportista.Text.Trim
                    'objEntidad.CODRESPSEG = cmbPolizaSeguro.SelectedValue
                    objEntidad.CODRESPSEG = cmbPolizaSeguro.ComboBox.SelectedValue
                    objEntidad.RESPSEG = cmbPolizaSeguro.ComboBox.Text.Trim
                    objEntidad.PORSEGCARGA = txtPorSeguro.Text.Trim
                    objEntidad.TABTRT = txtAbrev.Text.Trim






                    msg = obj.Registrar_AS400_Transportista(objEntidad)
                    If msg.Length > 0 Then
                        MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    Else
                        MessageBox.Show("Transportista generado " & objEntidad.CTRSPT, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtcod.Text = objEntidad.CTRSPT
                        UcPaginacion1.PageNumber = 1
                        Listar()
                    End If


                Case Accion.MODIFICAR

                    Dim obj As New Transportista_BLL
                    Dim objEntidad As New Transportista
                    objEntidad.CTRSPT = gwdDatos.CurrentRow.Cells("CTRSPT").Value
                    objEntidad.NRUCTR = txtruc_mant.Text.Trim
                    objEntidad.TCMTRT = txtrazon_mant.Text.Trim
                    objEntidad.CUSCRT = MainModule.USUARIO
                    objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
                    objEntidad.RUCPR2 = txtcodsap_mant.Text.Trim

                    objEntidad.TDRCTR = txtDireccionTransportista.Text.Trim
                    objEntidad.CODRESPSEG = cmbPolizaSeguro.SelectedValue
                    objEntidad.RESPSEG = cmbPolizaSeguro.ComboBox.Text.Trim
                    objEntidad.PORSEGCARGA = txtPorSeguro.Text.Trim
                    objEntidad.TABTRT = txtAbrev.Text.Trim


                    msg = obj.Registrar_AS400_Transportista(objEntidad)
                    If msg.Length > 0 Then
                        MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    Else
                        MessageBox.Show("Transportista actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtcod.Text = objEntidad.CTRSPT
                        UcPaginacion1.PageNumber = 1
                        Listar()
                    End If

            End Select
            pAccion = Accion.NEUTRO
            Habilitar_Boton()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try
            gwdDatos_SelectionChanged(gwdDatos, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UcPaginacion1_PageChanged(sender As Object, e As EventArgs) Handles UcPaginacion1.PageChanged
        Try
            Listar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub cmbPolizaSeguro_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbPolizaSeguro.SelectionChangeCommitted
        Try
            Dim respSeg As String = cmbPolizaSeguro.SelectedValue
            If respSeg = "P" Then
                txtPorSeguro.Text = "0.00"
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class