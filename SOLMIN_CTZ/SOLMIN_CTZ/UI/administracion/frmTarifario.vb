Imports System.Data
Imports SOLMIN_CTZ.NEGOCIO
Imports SOLMIN_CTZ.Entidades

Public Class frmTarifario

    Private Sub frmTarifario_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

        'cliente
        Me.ctlClienteTarifa.DataSource = MainModule.objdst_TablasGlobales.Tables("CLIENTES").Copy()
        Me.ctlClienteTarifa.KeyField = "CCLNT"
        Me.ctlClienteTarifa.ValueField = "TCMPCL"
        Me.ctlClienteTarifa.DataBind()
 
        'Cliente Consulta
        Me.ctlClienteConsulta.DataSource = MainModule.objdst_TablasGlobales.Tables("CLIENTES").Copy()
        Me.ctlClienteConsulta.KeyField = "CCLNT"
        Me.ctlClienteConsulta.ValueField = "TCMPCL"
        Me.ctlClienteConsulta.DataBind()

        'Moneda de Pago
        Me.ctlClienteConsulta.DataSource = MainModule.objdst_TablasGlobales.Tables("MONEDAS").Copy()
        Me.ctlClienteConsulta.KeyField = "CCLNT"
        Me.ctlClienteConsulta.ValueField = "TCMPCL"
        Me.ctlClienteConsulta.DataBind()


    End Sub

End Class
