Imports SOLMIN_ST.NEGOCIO.operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO
Imports Ransa.TypeDef.Transportista
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmVerActualizacionServicios

    Public pCCMPN As String
    Public NOPRCN As Decimal
    Public NGUITR As Decimal
    Public NCRRGU As Decimal
    Public Servicio As String

    Private Sub frmVerActualizacionServicios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SERVICIOS_HISTORIAL_ACUTALIZACION()
    
    End Sub


    Public Sub SERVICIOS_HISTORIAL_ACUTALIZACION()

        Dim Objeto_Logica As New GuiaTransportista_BLL
        Dim dt As New DataTable
        txtNroOperacion.Text = NOPRCN
        KryptonTextBox1.Text = NGUITR
        KryptonTextBox2.Text = Servicio
        dt = Objeto_Logica.LISTAR_SERVICIOS_HISTORIAL_ACUTALIZACION(pCCMPN, NOPRCN, NGUITR, NCRRGU)
        dt.Columns.Add("F_FCHCRT")
        dt.Columns.Add("F_HRACRT")
        For Each Item As DataRow In dt.Rows
            Item("F_FCHCRT") = HelpClass.CFecha_de_8_a_10(Item("FCHCRT").ToString.Trim)
            Item("F_HRACRT") = HelpClass.HoraNum_a_Hora_Default(Item("HRACRT").ToString.Trim)
        Next
        Me.dtServGRemCargGTransLiq.AutoGenerateColumns = False
        dtServGRemCargGTransLiq.DataSource = dt

    End Sub

End Class
