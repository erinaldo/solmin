Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.NEGOCIO.operaciones
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.NEGOCIO


Public Class frmAsignacionManualGenOp

    Public pNCSOTR As Decimal = 0
    Public pCCLNT As Decimal = 0
    Public pCCMPN As String = ""
    Public pCDVSN As String = ""
    Public pCPLNDV As Decimal = 0
    Public pNORSRT As Decimal = 0

    Private pCTPOVJ As String = "E"
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click

        Try

            Dim ItemSolicitud As Decimal = Generar_Detalle_Solicitud_Transporte()
            If ItemSolicitud > 0 Then
                Me.Registrar_Operacion_Transporte(ItemSolicitud)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Function Generar_Detalle_Solicitud_Transporte() As Decimal

        Dim ItemSol As Decimal = 0
        Dim CorrSolServicio As Decimal = 0
        Dim Objeto_Entidad As New Detalle_Solicitud_Transporte
        Dim Objeto_Logica As New Junta_Transporte_BLL
        Objeto_Entidad.NCSOTR = pNCSOTR ' gwdDatos.CurrentRow.Cells("NCSOTR").Value 'Me._obj_Entidad.NCSOTR
        Objeto_Entidad.CCLNT = pCCLNT ' gwdDatos.CurrentRow.Cells("CCLNT_COD").Value '  Me._obj_Entidad.CCLNT
        Objeto_Entidad.NRUCTR = ""
        Objeto_Entidad.NPLCUN = ""
        Objeto_Entidad.NPLCAC = ""
        Objeto_Entidad.CBRCNT = ""
        Objeto_Entidad.CBRCN2 = ""
        Objeto_Entidad.CUSCRT = MainModule.USUARIO
        Objeto_Entidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
        Objeto_Entidad.CCMPN = pCCMPN ' gwdDatos.CurrentRow.Cells("CCMPN").Value 'Me._obj_Entidad.CCMPN
        Objeto_Entidad.CDVSN = pCDVSN ' gwdDatos.CurrentRow.Cells("CDVSN").Value 'Me._obj_Entidad.CDVSN
        Objeto_Entidad.CPLNDV = pCPLNDV 'gwdDatos.CurrentRow.Cells("CPLNDV").Value  ' Me._obj_Entidad.CPLNDV

        Dim msg As String = ""
        Dim oRespuesta As New beRespuestaOperacion
        oRespuesta = Objeto_Logica.Registrar_Detalle_Solicitud_Transporte(Objeto_Entidad, msg)
        If msg.Length > 0 Then
            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        ItemSol = oRespuesta.NCRRSR

        Return ItemSol

    End Function

    Private Sub Registrar_Operacion_Transporte(ItemSolicitud As Decimal)

        Try

            Dim objOperacionTransporte As New OperacionTransporte_BLL
            'Dim HoraAtencion As Decimal = (txtHoraInicio.Text.Replace(":", "").Trim & "00").PadLeft(6, "0")
            Dim HoraAtencion As Decimal = (mtb_hora_ini_op.Text.Replace(":", "").Trim & "00").PadLeft(6, "0")
            Dim oParam_OP As New ENTIDADES.beRespuestaOperacion
            oParam_OP.NCSOTR = pNCSOTR ' gwdDatos.CurrentRow.Cells("NCSOTR").Value  ' Me._obj_Entidad.NCSOTR
            oParam_OP.NCRRSR = ItemSolicitud
            oParam_OP.NORSRT = pNORSRT ' gwdDatos.CurrentRow.Cells("NORSRT").Value ' Me._obj_Entidad.NORSRT
            oParam_OP.CCMPN = pCCMPN ' gwdDatos.CurrentRow.Cells("CCMPN").Value  'Me._obj_Entidad.CCMPN
            oParam_OP.CDVSN = pCDVSN ' gwdDatos.CurrentRow.Cells("CDVSN").Value 'Me._obj_Entidad.CDVSN
            oParam_OP.CPLNDV = pCPLNDV ' gwdDatos.CurrentRow.Cells("CPLNDV").Value 'Me._obj_Entidad.CPLNDV
            oParam_OP.CUSCRT = MainModule.USUARIO
            oParam_OP.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
            oParam_OP.TIPO_REGISTRO = "NUEVO"
            oParam_OP.SORGMV = "" ' IIf(Me.txtOsAgenciasRansa.Text.Trim.Equals(""), "", "A")
            oParam_OP.NDCORM = "" ' IIf(Me.txtOsAgenciasRansa.Text.Trim.Equals(""), 0, Me.txtOsAgenciasRansa.Text)
            oParam_OP.PNCDTR = 0 ' Me.txtNroOperacionAgenciasRansa.Text
            oParam_OP.FATNSR = HelpClass.CtypeDate(dtp_fecha_ini_op.Value)   ' HelpClass.CtypeDate(Me.dtpFechaAtencionServicio.Value)
            oParam_OP.HATNSR = HoraAtencion
            oParam_OP.CTPOVJ = pCTPOVJ ' Me._obj_Entidad.CTPOVJ

            Dim oRespuestaOP As New ENTIDADES.beRespuestaOperacion
            Dim msgError As String = ""

            oRespuestaOP = objOperacionTransporte.Registrar_Operacion_Transporte(oParam_OP, msgError)
            If msgError.Length > 0 Then
                MessageBox.Show(msgError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
                'Else

                'If es_OS_TipoSeguimiento = False Then
                '    Dim msg_oi As String = ""

                '    Me.Generar_Orden_Interna(oRespuestaOP, msg_oi)
                '    If msg_oi.Length > 0 Then
                '        MessageBox.Show(msg_oi, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                '        Exit Sub
                '    End If

                'End If

                'If HoraAtencion > 0 Then

                '    Dim objHito As New HitoOperacion
                '    Dim objLogicaHito As New ControlHitos_BLL
                '    Dim msg As String = ""
                '    With objHito
                '        .NOPRCN = oRespuestaOP.NOPRCN
                '        .NGUIRM = 0
                '        .CTRMNC = 0
                '        .FRETES = HelpClass.CtypeDate(Me.dtpFechaAtencionServicio.Value)
                '        .HRAREA = HoraAtencion
                '        .CUSCRT = MainModule.USUARIO
                '        .TIPO_HITO = "F_INICIO"
                '    End With
                '    msg = objLogicaHito.RegistrarHito_Actualizacion(objHito)

                '    If msg.Length > 0 Then
                '        MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

                '        Exit Sub
                '    End If
                'End If
            End If



        Catch ex As Exception
            HelpClass.MsgBox(ex.Message, MessageBoxIcon.Error)

        End Try
    End Sub


End Class
