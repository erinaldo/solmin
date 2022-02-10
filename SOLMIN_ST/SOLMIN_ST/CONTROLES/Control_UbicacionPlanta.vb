Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.ENTIDADES.Operaciones

Public Class Control_UbicacionPlanta

    Private bolBuscar As Double
    Private objCompaniaBLL As New NEGOCIO.Compania_BLL
    Private objDivision As New NEGOCIO.Division_BLL
    Private objPlanta As New NEGOCIO.Planta_BLL
    Private _lstrTipoCuenta As String

    Public Property lstrTipoCuenta() As String
        Get
            Return _lstrTipoCuenta
        End Get
        Set(ByVal value As String)
            _lstrTipoCuenta = value
        End Set
    End Property

    Private Sub Control_UbicacionPlanta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bolBuscar = False
        Cargar_Compania()
    End Sub

    Private Sub Cargar_Compania()
        objCompaniaBLL.Crea_Lista()
        bolBuscar = False
        cmbCompania.DataSource = objCompaniaBLL.Lista

        cmbCompania.ValueMember = "CCMPN"
        bolBuscar = True
        cmbCompania.DisplayMember = "TCMPCM"
        cmbCompania.SelectedValue = "EZ"
        If cmbCompania.SelectedIndex = -1 Then
            cmbCompania.SelectedIndex = 0
        End If
    'cmbCompania.SelectedIndex = 0
    End Sub

    Private Sub Cargar_Division()
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            bolBuscar = False
            objDivision.Crea_Lista(Me.cmbCompania.SelectedValue.ToString.Trim)
            cmbDivision.DataSource = objDivision.Lista_Division(Me.cmbCompania.SelectedValue.ToString.Trim)
            cmbDivision.ValueMember = "CDVSN"
            bolBuscar = True
            cmbDivision.DisplayMember = "TCMPDV"
            Me.cmbDivision.SelectedValue = "T"
            If Me.cmbDivision.SelectedIndex = -1 Then
                Me.cmbDivision.SelectedIndex = 0
            End If
            Me.Cursor = System.Windows.Forms.Cursors.Default
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Planta()
        Dim objLisEntidad As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
        Try
            If bolBuscar Then
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                bolBuscar = False
                objPlanta.Crea_Lista()
                objLisEntidad = objPlanta.Lista_Planta(Me.cmbCompania.SelectedValue, Me.cmbDivision.SelectedValue)
                cmbPlanta.DataSource = objLisEntidad
                cmbPlanta.ValueMember = "CPLNDV"
                bolBuscar = True
                cmbPlanta.DisplayMember = "TPLNTA"
                If objLisEntidad.Count > 0 Then
                    _lstrTipoCuenta = objLisEntidad.Item(0).CRGVTA
                Else
                    _lstrTipoCuenta = ""
                End If
                Me.Cursor = System.Windows.Forms.Cursors.Default
            End If
        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

   
    Private Sub cmbCompania_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCompania.SelectedIndexChanged
        If bolBuscar Then
            Cargar_Division()
        End If
    End Sub

    Private Sub cmbDivision_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDivision.SelectedIndexChanged
        If bolBuscar Then
            Cargar_Planta()
        End If
    End Sub
End Class
