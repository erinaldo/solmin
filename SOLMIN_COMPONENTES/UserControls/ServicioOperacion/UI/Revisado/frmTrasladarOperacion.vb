Public Class frmTrasladarOperacion

    Private oServicioOpeNeg As New clsServicio_BL
    Private _oServicio As Servicio_BE
    Public dtg As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Public Grabar As Boolean = False

    Public Property oServicio() As Servicio_BE
        Get
            Return _oServicio
        End Get
        Set(ByVal value As Servicio_BE)
            _oServicio = value
        End Set
    End Property

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim oDtSerivcio As New DataTable

        If UCtxtRevision.txtDecimales.Text.Length = 0 Then Exit Sub

        Try

            oServicio.FECINI = 0
            oServicio.FECFIN = 99999999

            oServicio.NSECFC = UCtxtRevision.txtDecimales.Text
            oDtSerivcio = oServicioOpeNeg.Lista_Servicios_Consolidado(oServicio)



            If oDtSerivcio.Rows.Count > 0 Then

                For intCont As Integer = 0 To dtg.Rows.Count - 1

                    If Convert.ToBoolean(dtg.Rows(intCont).Cells("chk2").Value) = True Then

                        If (oDtSerivcio.Rows(0).Item("CCLNFC") <> dtg.Rows(intCont).Cells("CCLNFC2").Value) Or _
                           (oDtSerivcio.Rows(0).Item("CCLNT") <> dtg.Rows(intCont).Cells("CCLNT2").Value) Then
                            MsgBox("Las Revisiones no pertenecen al mismo Cliente Operación y Cliente a Facturar", MsgBoxStyle.Information)
                            Exit Sub
                        End If

                        If oDtSerivcio.Rows(0).Item("CTPALJ") = "RE" Then
                            If oDtSerivcio.Rows(0).Item("CTPALJ") <> dtg.Rows(intCont).Cells("CTPALJ").Value Then
                                MsgBox("Las Operaciones de Reembolso deben ir juntas", MsgBoxStyle.Information)
                                Exit Sub
                            End If
                        End If

                        If oDtSerivcio.Rows(0).Item("STPODP") <> dtg.Rows(intCont).Cells("STPODP2").Value Then
                            MsgBox("Los procesos no deben de ser diferentes", MsgBoxStyle.Information)
                            Exit Sub
                        End If


                        If oDtSerivcio.Rows(0).Item("CMNDA1") <> dtg.Rows(intCont).Cells("CMNDA12").Value Then
                            MsgBox("Las Revisiones estan en diferentes monedas, No es posible generar un Nro.  de Revisión", MsgBoxStyle.Information)
                            Exit Sub
                        End If

                        If oDtSerivcio.Rows(0).Item("CRGVTA") <> dtg.Rows(intCont).Cells("CRGVTA2").Value Then
                            MsgBox("Los Servicios Pertenecen a Diferentes Regiones de Venta, No es posible generar un Nro.  de Revisión", MsgBoxStyle.Information)
                            Exit Sub
                        End If

                        If (oDtSerivcio.Rows(0).Item("CPLNDV") <> dtg.Rows(intCont).Cells("CPLNDV").Value)   Then
                            MsgBox("Las Revisiones no pertenecen a la misma Planta", MsgBoxStyle.Information)
                            Exit Sub
                        End If

                    End If
                Next intCont


                For intCont As Integer = 0 To dtg.Rows.Count - 1

                    If Convert.ToBoolean(dtg.Rows(intCont).Cells("chk2").Value) = True Then

                        oServicio.NOPRCN = dtg.Rows(intCont).Cells("NOPRCN_D").Value
                        oServicioOpeNeg.ActualizarServicio_Atendido(oServicio)
                    End If
                Next intCont

                MsgBox("La Operación (s) se actualizó al Nro de Revisión: " & CStr(oServicio.NSECFC), MsgBoxStyle.Information)
                Me.DialogResult = Windows.Forms.DialogResult.Yes
            Else
                MessageBox.Show("No existe en número de revisión", "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub
End Class
