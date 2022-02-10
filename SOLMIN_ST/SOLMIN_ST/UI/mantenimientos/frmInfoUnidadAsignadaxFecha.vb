Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.seguimiento_wap

Public Class frmInfoUnidadAsignadaxFecha
    Private _CCMPN As String = ""
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property
    Public Sub ShowForm(ByVal owner As IWin32Window)
        'Forzando destruccion de memoria
        ClearMemory()
        'Mostrando el formulario
        Me.ShowDialog(owner)
    End Sub

    Public Sub New(ByVal lstr_NPLCUN As String, ByVal lstr_FecIni As String, ByVal lstr_FecFin As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If lstr_NPLCUN.Trim.Equals("") OrElse lstr_FecIni.Trim.Equals("") OrElse lstr_FecFin.Trim.Equals("") Then
            Exit Sub
        End If
        Try
            txtPlaca.Text = lstr_NPLCUN
            dtpFechaInicio.Value = HelpClass.CNumero_a_Fecha(lstr_FecIni)
            dtpFechaFin.Value = HelpClass.CNumero_a_Fecha(lstr_FecFin)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Listar_Unidades_Asignadas_por_Fecha()
        Me.Cursor = Cursors.WaitCursor
        Try
            Me.dtgDatos.AutoGenerateColumns = False
            Dim objLogica As New SeguimientoWAP_BLL
            Me.dtgDatos.DataSource = objLogica.Listar_Unidades_Asignadas_Por_Fecha(txtPlaca.Text, HelpClass.CtypeDate(dtpFechaInicio.Value), HelpClass.CtypeDate(dtpFechaFin.Value))
        Catch ex As Exception
            HelpClass.MsgBox(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
