Imports SOLMIN_CTZ.Entidades.Operaciones
Imports SOLMIN_CTZ.NEGOCIO.Operaciones
Imports System.Collections.Generic
Imports System.Text
Imports System.IO.Ports
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class frmAsignarPlanRuta

    Enum TIPO
        MODIFICAR
        ASIGNAR
    End Enum


    Enum TIPO_PLAN
        INICIAL
        VIAJE
    End Enum

    Private _TipoOperacion As TIPO
    Private _TipoPlanRuta As TIPO_PLAN
    Private _ObjServicioMercaderia As SOLMIN_CTZ.Entidades.ServicioMercaderia
    Private _ObjPlanRuta As PlanRuta

    Public Property TipoOperacion() As TIPO
        Get
            Return _TipoOperacion
        End Get
        Set(ByVal value As TIPO)
            _TipoOperacion = value
        End Set
    End Property

    Public Property TipoPlanRuta() As TIPO_PLAN
        Get
            Return _TipoPlanRuta
        End Get
        Set(ByVal value As TIPO_PLAN)
            _TipoPlanRuta = value
        End Set
    End Property

    Public Property ObjPlanRuta() As PlanRuta
        Get
            Return _ObjPlanRuta
        End Get
        Set(ByVal value As PlanRuta)
            _ObjPlanRuta = value
        End Set
    End Property

    Public Property ObjServicioMercaderia() As SOLMIN_CTZ.Entidades.ServicioMercaderia
        Get
            Return _ObjServicioMercaderia
        End Get
        Set(ByVal value As SOLMIN_CTZ.Entidades.ServicioMercaderia)
            _ObjServicioMercaderia = value
        End Set
    End Property

    Private Sub ActualizaPlanRuta()
        Me.ObtieneInformacion(ObjPlanRuta)
        If TipoPlanRuta = TIPO_PLAN.INICIAL Then
            Dim ObjPlanRuta_BLL As New SOLMIN_CTZ.NEGOCIO.PlanRuta_BLL
            If ObjPlanRuta_BLL.Actualiza_PlanRutaInicial(ObjPlanRuta) = 0 Then
                HelpClass.ErrorMsgBox()
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Else
                HelpClass.MsgBox("Se Actualizó Satisfactoriamente")
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Else
            Dim ObjPlanRuta_BLL As New SOLMIN_CTZ.NEGOCIO.PlanRuta_BLL
            If ObjPlanRuta_BLL.Actualiza_PlanRutaViaje(ObjPlanRuta) = 0 Then
                HelpClass.ErrorMsgBox()
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Else
                HelpClass.MsgBox("Se Actualizó Satisfactoriamente")
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub

    Private Sub ObtieneInformacion(ByVal objTemp As PlanRuta)
        objTemp.PNCLCLD = Me.txtLocalidadOrigen.Codigo
        objTemp.PNFECSEG = HelpClass.CtypeDate(Me.dtpFecha.Value)
        objTemp.PNHRASEG = Ransa.Utilitario.HelpClass.ConvertHoraNumeric(Me.txtHoraRegistro.Text)
        objTemp.PNQDSTVR = Me.txtKilometros.txtDecimales.Text
        objTemp.PSTOBS = Me.txtObservacion.Text
        objTemp.PSUSRCRT = ConfigurationWizard.UserName
        objTemp.PSNTRMCR = HelpClass.NombreMaquina
    End Sub

    Private Sub NuevoHojaRuta()

        If TipoPlanRuta = TIPO_PLAN.INICIAL Then
            Dim objPlanRuta As New PlanRuta
            Me.ObtieneInformacion(objPlanRuta)
            'Obtiene la Informacion del Formulario
            objPlanRuta.PNNCTZCN = Me._ObjServicioMercaderia.NCTZCN
            objPlanRuta.PNNCRRCT = Me._ObjServicioMercaderia.NCRRCT
            objPlanRuta.PNNCRRSR = Me._ObjServicioMercaderia.NCRRSR
            objPlanRuta.PSCCMPN = Me._ObjServicioMercaderia.CCMPN

            objPlanRuta.PSSIDAVL = "I"
            objPlanRuta.PSTPOREG = "P"
            Dim ObjPlanRuta_BLL As New SOLMIN_CTZ.NEGOCIO.PlanRuta_BLL
            If ObjPlanRuta_BLL.Registrar_PlanRutaInicial(objPlanRuta) = 0 Then
                HelpClass.ErrorMsgBox()
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Else
                HelpClass.MsgBox("Se Asignó Satisfactoriamente")
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Else
            Me.ObtieneInformacion(objPlanRuta)

            Dim ObjPlanRuta_BLL As New SOLMIN_CTZ.NEGOCIO.PlanRuta_BLL
            If ObjPlanRuta_BLL.Registrar_PlanRutaViaje(objPlanRuta) = 0 Then
                HelpClass.ErrorMsgBox()
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Else
                HelpClass.MsgBox("Se Asignó Satisfactoriamente")
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub

    Private Function Validar_Inputs() As Boolean
        Dim lstr_validacion As String = ""
        Dim lbool_existe_error As Boolean = False

        If Not IsDate(dtpFecha.Value) Then
            lstr_validacion += "* FECHA " & Chr(13)
        End If

        If Not IsDate(Me.txtHoraRegistro.Text) OrElse Me.txtHoraRegistro.Text = "00:00:00" Then
            lstr_validacion += "* HORA " & Chr(13)
        End If

        If Me.txtLocalidadOrigen.NoHayCodigo = True OrElse txtLocalidadOrigen.Codigo = 0 Then
            lstr_validacion += "* LUGAR ORIGEN & Chr(13)"
        End If


        If Me.txtKilometros.txtDecimales.Text = "" OrElse Not IsNumeric(Me.txtKilometros.txtDecimales.Text) Then
            lstr_validacion += "* KILOMETROS " & Chr(13)
        End If

        If Me.txtObservacion.Text.Trim = "" Then
            lstr_validacion += "* MOTIVO " & Chr(13)
        End If

        If lstr_validacion <> "" Then
            HelpClass.MsgBox("DEBE DE INGRESAR :" & Chr(13) & lstr_validacion, MessageBoxIcon.Warning)
            lbool_existe_error = True
        End If

        Return lbool_existe_error
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Validar_Inputs() Then Exit Sub
        If Me.TipoOperacion = TIPO.ASIGNAR Then
            Me.NuevoHojaRuta()
        Else
            Me.ActualizaPlanRuta()
        End If
    End Sub

    Private Sub txtKilometros_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = "." Then
            e.Handled = True
            Exit Sub
        End If
        If HelpClass.SoloNumeros(CShort(Asc(e.KeyChar))) = 0 Then e.Handled = True
    End Sub

    Private Sub frmAsignarPlanRuta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Lista los tipos de Documentos.
        Dim objLocalidad As New SOLMIN_CTZ.NEGOCIO.Localidad_BLL
        Dim dtTableLocalidad As New DataTable
        If Me.TipoPlanRuta = TIPO_PLAN.INICIAL Then
            If Me.TipoOperacion = TIPO.MODIFICAR Then
                dtTableLocalidad = objLocalidad.Listar_Localidades_Combo(Me.ObjPlanRuta.PSCCMPN)
            Else
                dtTableLocalidad = objLocalidad.Listar_Localidades_Combo(Me.ObjServicioMercaderia.CCMPN)
            End If
        Else
            dtTableLocalidad = objLocalidad.Listar_Localidades_Combo(Me.ObjPlanRuta.PSCCMPN)
        End If

        With Me.txtLocalidadOrigen
            .DataSource = dtTableLocalidad.Copy
            .KeyField = "CLCLD"
            .ValueField = "TCMLCL"
            .DataBind()
        End With

        If Me.TipoOperacion = TIPO.MODIFICAR Then
            Me.txtLocalidadOrigen.Codigo = ObjPlanRuta.PNCLCLD
            Me.dtpFecha.Value = IIf(ObjPlanRuta.PNFECSEG = 0, Date.Today, Ransa.Utilitario.HelpClass.FechaNum_a_Fecha(ObjPlanRuta.PNFECSEG))
            Me.txtHoraRegistro.Text = String.Format("{0:HH:mm:ss}", Ransa.Utilitario.HelpClass.CNumero_a_Hora(ObjPlanRuta.PNHRASEG))
            Me.txtKilometros.txtDecimales.Text = IIf(ObjPlanRuta.PNQDSTVR = 0, "", ObjPlanRuta.PNQDSTVR)
            Me.txtObservacion.Text = ObjPlanRuta.PSTOBS.Trim
        End If

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class
