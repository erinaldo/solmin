

Public Class ucInformacionTransportista
    Private _pTransportista As ENTIDADES.mantenimientos.Transportista
    
    


    Sub pAsignar(ByVal pTransportista As ENTIDADES.mantenimientos.Transportista)
        _pTransportista = pTransportista
        

        txtEstado.Enabled = False
        If _pTransportista Is Nothing Then
            txtCodigo.Text = ""
            txtRazonSocial.Text = ""
            txtCodigoTransportista.Text = ""

            txtNroRuc.Text = ""
            txtDescripcion.Text = ""
            txtDireccionTransportista.Text = ""
            txtTelefonoTransportista.Text = ""
            txtTractosAsignados.Text = ""
            txtAcopladosAsignados.Text = ""
            txtChoferesAsignados.Text = ""
            chkTercero.Checked = False
            txtEstado.Text = ""
            txtRazonSocial.Focus()
        Else
            txtCodigo.Text = _pTransportista.CTRSPT
            txtNroRuc.Text = _pTransportista.NRUCTR
            txtRazonSocial.Text = _pTransportista.TCMTRT
            txtCodigoTransportista.Text = _pTransportista.RUCPR2


            txtCodAS400.Text = _pTransportista.CTRSPT & " - " & _pTransportista.TRANSPORTISTA_AS
            txtCodAS400.Tag = _pTransportista.CTRSPT
            txtDescripcion.Text = _pTransportista.TABTRT
            txtDireccionTransportista.Text = _pTransportista.TDRCTR
            txtTelefonoTransportista.Text = _pTransportista.TLFTRP
            txtTractosAsignados.Text = _pTransportista.TRACTOS_ASIGNADOS
            txtAcopladosAsignados.Text = _pTransportista.ACOPLADOS_ASIGNADOS
            txtChoferesAsignados.Text = _pTransportista.CHOFERES_ASIGNADOS
            chkTercero.Checked = False
            'txtEstado.Text = IIf(.SESTRG = "A", "Activo", "Inactivo")
            txtEstado.Text = _pTransportista.SESTRG
            txtCompania.Text = _pTransportista.CCMPN
            txtDivision.Text = _pTransportista.CDVSN
            txtPlanta.Text = _pTransportista.CPLNDV
        End If
    End Sub

   

    Sub pLimpiar()
        _pTransportista = New ENTIDADES.mantenimientos.Transportista

        txtCodAS400.Text = ""
        txtNroRuc.Text = ""
        txtRazonSocial.Text = ""
        txtCodigoTransportista.Text = ""
        txtDescripcion.Text = ""
        txtDireccionTransportista.Text = ""
        txtTelefonoTransportista.Text = ""
        txtCodigo.Text = ""
        txtTractosAsignados.Text = ""
        txtAcopladosAsignados.Text = ""
        txtChoferesAsignados.Text = ""
        txtEstado.Text = ""
    End Sub

    Function Resultado() As ENTIDADES.mantenimientos.Transportista
        Dim beTransportista As New ENTIDADES.mantenimientos.Transportista
        beTransportista.CTRSPT = txtCodigo.Text.Trim
        beTransportista.NRUCTR = txtNroRuc.Text
        beTransportista.TCMTRT = txtRazonSocial.Text.Trim

        beTransportista.NEWCTRSPT = txtCodAS400.Text.Trim
        beTransportista.RUCPR2 = txtCodigoTransportista.Text
        beTransportista.TABTRT = txtDescripcion.Text.Trim
        beTransportista.TDRCTR = txtDireccionTransportista.Text.Trim
        beTransportista.TLFTRP = txtTelefonoTransportista.Text.Trim

        beTransportista.SESTRG = txtEstado.Text.Trim
        beTransportista.CCMPN = txtCompania.Text.Trim
        beTransportista.CDVSN = txtDivision.Text.Trim
        beTransportista.CPLNDV = Val(txtPlanta.Text.Trim)
        Return beTransportista
    End Function

    Sub pHabilitar_Control_Transportista(ByVal lbool_Estado As Boolean)

        Me.txtRazonSocial.Enabled = lbool_Estado

        txtNroRuc.ReadOnly = True
        txtCodigoTransportista.Enabled = lbool_Estado
        txtRazonSocial.Enabled = lbool_Estado
        txtDescripcion.Enabled = lbool_Estado
        txtDireccionTransportista.Enabled = lbool_Estado
        txtTelefonoTransportista.Enabled = lbool_Estado

        txtCodAS400.Enabled = lbool_Estado
        chkTercero.Enabled = False
        chkTercero.Checked = False
        txtEstado.Enabled = False
    End Sub


End Class
