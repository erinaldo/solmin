Imports System.ComponentModel

Public Class frmOperacionTransporte

    Private Sub frmOperacionTransporte_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim obj As New NEGOCIO.DbBridge_BLL
        Dim dtb As DataTable = obj.GetTable("select * from rztr05")

    End Sub
 
End Class