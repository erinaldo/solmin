Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.ENTIDADES.mantenimientos

Public Class frmActualizarFecha

#Region "Variables y Propiedades"

    Private _CLCLOR As String
    Private _CCMPN As String
    Private _CLCLDS As String
    Private _CCLNT As String
    Private _CMEDTR As String
    Private DiasEstimados_ETA As Decimal = 0
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property

    Public Property CLCLOR() As String
        Get
            Return _CLCLOR
        End Get
        Set(ByVal value As String)
            _CLCLOR = value
        End Set
    End Property

    Public Property CLCLDS() As String
        Get
            Return _CLCLDS
        End Get
        Set(ByVal value As String)
            _CLCLDS = value
        End Set
    End Property

    Public Property CCLNT() As String
        Get
            Return _CCLNT
        End Get
        Set(ByVal value As String)
            _CCLNT = value
        End Set
    End Property

    Public Property CMEDTR() As String
        Get
            Return _CMEDTR
        End Get
        Set(ByVal value As String)
            _CMEDTR = value
        End Set
    End Property

#End Region

#Region "Metodos y Eventos"

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Try
            Dim lstr_validacion As String = ""
            If Me.dtpFechaEstimadaLlegada.Checked = True Then
                If HelpClass.CtypeDate(Me.dtpFechaEstimadaSalida.Value) > HelpClass.CtypeDate(Me.dtpFechaEstimadaLlegada.Value) Then
                    lstr_validacion += "* FECHA ESTIMADA DE SALIDA MAYOR A ESTIMADA DE LLEGADA" & Chr(13)
                End If
                If HelpClass.CtypeDate(Me.dtpFechaEstimadaSalida.Value) > HelpClass.CtypeDate(Me.dtpFechaEstimadaLlegada.Value) Then
                    lstr_validacion += "* FECHA ESTIMADA DE SALIDA MAYOR A REAL DE LLEGADA" & Chr(13)
                End If
            End If
            If Me.dtpFechaRealLlegada.Checked = True Then
                If HelpClass.CtypeDate(Me.dtpFechaRealSalida.Value) > HelpClass.CtypeDate(Me.dtpFechaRealLlegada.Value) Then
                    lstr_validacion += "* FECHA REAL DE SALIDA MAYOR A REAL DE LLEGADA" & Chr(13)
                End If
                If HelpClass.CtypeDate(Me.dtpFechaEstimadaSalida.Value) > HelpClass.CtypeDate(Me.dtpFechaEstimadaLlegada.Value) Then
                    lstr_validacion += "* FECHA REAL DE SALIDA MAYOR A ESTIMADA DE LLEGADA" & Chr(13)
                End If
            End If
            'validacion obligatoria de hora de inicio
            Dim d As New Date
            If Me.txtHoraInicio.Text = "00:00" Then
                lstr_validacion += "* DEBE INGRESAR HORA DE INICIO DE TRASLADO" & Chr(13)
            End If
            If Date.TryParse(Me.txtHoraInicio.Text, d) = False Then
                lstr_validacion += "* INGRESE HORA REAL DE INICIO" & Chr(13)
            End If

            If dtpFechaRealLlegada.Checked Then
                If Me.txtHoraFin.Text = "00:00" Then
                    lstr_validacion += "* DEBE INGRESAR HORA DE FIN DE TRASLADO" & Chr(13)
                End If
                If Date.TryParse(Me.txtHoraFin.Text, d) = False Then
                    lstr_validacion += "* INGRESE HORA REAL FIN" & Chr(13)
                End If
            End If

            If lstr_validacion <> "" Then
                HelpClass.MsgBox("ADVERTENCIA :" & Chr(13) & lstr_validacion)
            Else
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

#End Region


    Private Sub frmActualizarFecha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            lblmensaje.Text = ""
            DiasEstimados_ETA = CalcularFechaLlegada()
            Me.lblDiasEstimados.Text = "..."
            If DiasEstimados_ETA > -1 Then
                Me.lblDiasEstimados.Text = Val(DiasEstimados_ETA)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     

    End Sub

    Private Sub dtpFechaRealLlegada_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaRealLlegada.ValueChanged
        Me.txtHoraFin.Enabled = dtpFechaRealLlegada.Checked
        If dtpFechaRealLlegada.Checked = False Then
            Me.txtHoraFin.Text = "00:00"
        End If
    End Sub

    Private Sub btnCalcularFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcularFecha.Click
        AsignarETA()
       

    End Sub

    Private Sub AsignarETA()

        lblmensaje.Text = ""
        'Dim distancia As Decimal = CalcularFechaLlegada()
        If DiasEstimados_ETA = -1 Then
            lblmensaje.ForeColor = Color.Red
            lblmensaje.Text = "Sin config. para calc. ETA"
            ' MsgBox("Sin config. para calc. ETA", MsgBoxStyle.Exclamation)
        Else
            Dim fecha As Date = Me.dtpFechaRealSalida.Value
            Dim qdias As Decimal = DiasEstimados_ETA
            If qdias > 0 Then
                qdias = qdias - 1
            End If
            fecha = fecha.AddDays(qdias)
            dtpFechaEstimadaLlegada.Checked = True
            Me.dtpFechaEstimadaLlegada.Value = fecha
            lblmensaje.Text = "ETA recalculado"
            lblmensaje.ForeColor = Color.Blue
            'MsgBox("Fecha Estimada de Llegada ha sido calculada correctamente")
        End If

    End Sub


    Private Function CalcularFechaLlegada() As Decimal
        Dim diasEstimados As Decimal = -1
        'Calcula El tiempo Estimado
        'Obteniendo el listado de distancias que tiene el cliente seleccionado
        Dim objDistancias As New DuracionDias_BLL
        'Dim lstDuraciondistancia As New List(Of DuracionDias)
        Dim objEntidad As New DuracionDias
        'Dim objGuiaTransportista As New GuiaTransportista_BLL
        'Dim objEntidadGuiaTransportista As New GuiaTransportista
        Dim dt As New DataTable

        objEntidad.CCLNT = _CCLNT
        objEntidad.CCMPN = _CCMPN
        objEntidad.CLCLOR = CLCLOR
        objEntidad.CLCLDS = CLCLDS
        objEntidad.CMEDTR = CMEDTR
        dt = objDistancias.ListarDuracionDias_x_Cliente(objEntidad)

        If dt.Rows.Count > 0 Then
            diasEstimados = dt.Rows(0)("QDSEST")
            If diasEstimados > 0 Then
                diasEstimados = diasEstimados - 1
            End If
        End If

        ''recorriendo
        'Dim distancia As Decimal = 0
        'For Each objDuraccionDistancia As DuracionDias In lstDuraciondistancia
        '    If objDuraccionDistancia.CLCLOR = CLCLOR AndAlso objDuraccionDistancia.CLCLDS = CLCLDS And objDuraccionDistancia.CMEDTR = CMEDTR Then
        '        distancia = objDuraccionDistancia.QDSEST
        '    End If
        'Next

        Return diasEstimados
    End Function

    Private Sub dtpFechaRealSalida_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaRealSalida.ValueChanged
        Try
            If dtpFechaRealSalida.Focused = False Then
                Exit Sub
            End If
            AsignarETA()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
