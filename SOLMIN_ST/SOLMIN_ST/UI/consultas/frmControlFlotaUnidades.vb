Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports CrystalDecisions.CrystalReports.Engine
Imports Ransa.Utilitario

Public Class frmControlFlotaUnidades
#Region "Atributos"
    Private mCTPCRA As String = ""
    Private mCCMPN As String = ""
    Private mCDVSN As String = ""
    Private mCPLNDV As Double = 0
#End Region

#Region "Propiedades"
    Public WriteOnly Property CCMPN() As String
        Set(ByVal value As String)
            mCCMPN = value
        End Set
    End Property

    Public WriteOnly Property CDVSN() As String
        Set(ByVal value As String)
            mCDVSN = value
        End Set
    End Property

    Public WriteOnly Property CTPCRA() As String
        Set(ByVal value As String)
            mCTPCRA = value
        End Set
    End Property

    Public WriteOnly Property CPLNDV() As Double
        Set(ByVal value As Double)
            mCPLNDV = value
        End Set
    End Property

#End Region

#Region "Eventos"
    Private Sub frmControlFlotaUnidades_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Lista_Bitacora_Vehiculos()
    End Sub

    Private Sub btnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegresar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub dtgControlFlotaUnidades_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgControlFlotaUnidades.CellClick
        Select Case e.ColumnIndex
            Case 8 'Ubicacion GPS
                If Me.dtgControlFlotaUnidades.Item("GPSLON", Me.dtgControlFlotaUnidades.CurrentCellAddress.Y).Value.ToString <> "" Then
                    Dim objGpsBrowser As New frmMapa
                    With objGpsBrowser
                        .Latitud = Me.dtgControlFlotaUnidades.Item("GPSLAT", e.RowIndex).Value
                        .Longitud = Me.dtgControlFlotaUnidades.Item("GPSLON", e.RowIndex).Value
                        .Fecha = Me.dtgControlFlotaUnidades.Item("FECGPS", e.RowIndex).Value
                        .Hora = Me.dtgControlFlotaUnidades.Item("HORGPS", e.RowIndex).Value.ToString.Trim
                        .Flag = 1
                        .WindowState = FormWindowState.Maximized
                        .ShowForm(.Latitud, .Longitud, Me)
                    End With
                End If
                'Case 10
                '    If dtgControlFlotaUnidades.CurrentCellAddress.Y < 0 OrElse Me.dtgControlFlotaUnidades.Item("SEGWAP", Me.dtgControlFlotaUnidades.CurrentCellAddress.Y).Value = "" Then
                '        Exit Sub
                '    End If
                '    Dim NPLCUN As String = dtgControlFlotaUnidades.Item("NPLCUN", dtgControlFlotaUnidades.CurrentCellAddress.Y).Value.ToString.Trim()
                '    Dim strExiste As String = dtgControlFlotaUnidades.Item("SEGWAP", dtgControlFlotaUnidades.CurrentCellAddress.Y).Value.ToString.Trim()
                '    If strExiste = vbNullString Then Exit Sub
                '    Dim f As New frmRegistroWAP(NPLCUN)
                '    f.CCMPN = mCCMPN
                '    f.ShowForm(Me)
        End Select
    End Sub
#End Region

#Region "Metodos"
    Private Sub Alinear_Columnas_Grilla()
        Me.dtgControlFlotaUnidades.AutoGenerateColumns = False
        For lint_contador As Integer = 0 To Me.dtgControlFlotaUnidades.ColumnCount - 1
            Me.dtgControlFlotaUnidades.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub

    Private Sub Lista_Bitacora_Vehiculos()
        Dim objTractoBLL As New Tracto_BLL
        Dim objEntidad As New Tracto
        objEntidad.CCMPN = mCCMPN
        objEntidad.CDVSN = mCDVSN
        objEntidad.CPLNDV = mCPLNDV
        objEntidad.CTPCRA = mCTPCRA
        dtgControlFlotaUnidades.AutoGenerateColumns = False
        dtgControlFlotaUnidades.DataSource = objTractoBLL.Listar_Control_Flota(objEntidad)
    End Sub
#End Region

End Class
