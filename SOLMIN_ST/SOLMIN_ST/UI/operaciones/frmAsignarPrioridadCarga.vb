Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports System.Collections.Generic

Imports System.Text
Imports System.IO.Ports
Public Class frmAsignarPrioridadCarga

    Private _PSCCMPN As String
    Public Property PSCCMPN() As String
        Get
            Return _PSCCMPN
        End Get
        Set(ByVal value As String)
            _PSCCMPN = value
        End Set
    End Property

    Private _PNNGUITR As Decimal
    Public Property PNNGUITR() As Decimal
        Get
            Return _PNNGUITR
        End Get
        Set(ByVal value As Decimal)
            _PNNGUITR = value
        End Set
    End Property

    Private _PNCTRMNC As Decimal
    Public Property PNCTRMNC() As Decimal
        Get
            Return _PNCTRMNC
        End Get
        Set(ByVal value As Decimal)
            _PNCTRMNC = value
        End Set
    End Property

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim ObjPlanRuta As New PlanRuta
        ObjPlanRuta.PSCCMPN = _PSCCMPN
        ObjPlanRuta.PNNGUITR = _PNNGUITR
        ObjPlanRuta.PNCTRMNC = _PNCTRMNC
        ObjPlanRuta.PSUSRCRT = MainModule.USUARIO
        ObjPlanRuta.PSNTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina

        If rbRutina.Checked = True Then
            ObjPlanRuta.PSFLPRCG = "R"
        Else
            If rbtUrgente.Checked = True Then
                ObjPlanRuta.PSFLPRCG = "U"
            Else
                Exit Sub
            End If
        End If
        Dim ObjPlanRuta_BLL As New NEGOCIO.PlanRuta_BLL
        If ObjPlanRuta_BLL.Actualizar_PrioridadCarga(ObjPlanRuta) = 0 Then
            HelpClass.ErrorMsgBox()
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Else
            HelpClass.MsgBox("Se Modificó Satisfactoriamente")
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
        ObjPlanRuta_BLL.Listar_PrioridadCarga(ObjPlanRuta)
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmAsignarPrioridadCarga_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ObjPlanRuta As New PlanRuta
        ObjPlanRuta.PSCCMPN = _PSCCMPN
        ObjPlanRuta.PNNGUITR = _PNNGUITR
        ObjPlanRuta.PNCTRMNC = _PNCTRMNC

        Dim ObjPlanRuta_BLL As New NEGOCIO.PlanRuta_BLL
        Dim dt As DataTable = ObjPlanRuta_BLL.Listar_PrioridadCarga(ObjPlanRuta)

        If dt.Rows.Count > 0 Then
            Dim dr As DataRow = dt.Rows(0)
            If Not dr Is Nothing Then
                Me.txtcliente.Text = dr("CLIENTE").ToString
                Me.txtPlaca.Text = dr("PLACA").ToString + "-" + dr("ACOPLADO").ToString
                Me.txtRuta.Text = dr("RUTA").ToString
                Me.txtConductor.Text = dr("CONDUCTOR1").ToString
                Select Case dr("PRIORIDAD_CARGA").ToString
                    Case "R"
                        rbRutina.Checked = True
                    Case "U"
                        rbtUrgente.Checked = True
                    Case Else
                End Select
            End If
        End If

    End Sub
End Class