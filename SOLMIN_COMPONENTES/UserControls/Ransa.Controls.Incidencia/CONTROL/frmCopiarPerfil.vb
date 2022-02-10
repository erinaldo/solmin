Imports System.Windows.Forms

Public Class frmCopiarPerfil

    Private _PSCCMPN As String
    Public Property PSCCMPN() As String
        Get
            Return _PSCCMPN
        End Get
        Set(ByVal value As String)
            _PSCCMPN = value
        End Set
    End Property

    Private _PSCCMPN_DES As String
    Public Property PSCCMPN_DES() As String
        Get
            Return _PSCCMPN_DES
        End Get
        Set(ByVal value As String)
            _PSCCMPN_DES = value
        End Set
    End Property

    Private _pUsuario As String
    Public Property pUsuario() As String
        Get
            Return _pUsuario
        End Get
        Set(ByVal value As String)
            _pUsuario = value
        End Set
    End Property

    Private _PSCDVSN As String
    Public Property PSCDVSN() As String
        Get
            Return _PSCDVSN
        End Get
        Set(ByVal value As String)
            _PSCDVSN = value
        End Set
    End Property

    Private _pClienteDestino As String
    Public Property pClienteDestino() As String
        Get
            Return _pClienteDestino
        End Get
        Set(ByVal value As String)
            _pClienteDestino = value
        End Set
    End Property

    Private _pCodCliente As Decimal
    Public Property pCodCliente() As Decimal
        Get
            Return _pCodCliente
        End Get
        Set(ByVal value As Decimal)
            _pCodCliente = value
        End Set
    End Property

    Private isCheckCliente As Boolean = False
    Dim dt As DataTable

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        Me.dtgIncidencias.DataSource = Nothing

        Dim ObjBLL As New brIncidencias
        Dim objBE As New beIncidencias
        Dim mensaje As String = ""
        Dim DS As New DataSet

        mensaje = Valida()
        If mensaje.Trim.Length > 0 Then
            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        objBE.PSCCMPN = _PSCCMPN
        objBE.PSCARINC = Lista_Divisiones()
        objBE.PNCCLNT = txtClienteOrigen.pCodigo
        objBE.ANIO = 2013
        DS = ObjBLL.olistListarMaestroIncidenciasClientePerfil(objBE)

        Dim dt1 As DataTable = DS.Tables(1).Copy

        Dim dv1 As New DataView(dt1)
        dv1.Sort = "TDARINC ASC"
        dt1 = dv1.ToTable

        Me.dtgIncidencias.DataSource = dt1.Copy

    End Sub



    Private Sub frmCopiarPerfil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.dtgIncidencias.AutoGenerateColumns = False

        txtClienteDestino.Text = _pClienteDestino
        txtCompania.Text = _PSCCMPN_DES

        ' --------------- CARGAR DIVISIÓN --------------
        Dim objDAL As New UbicacionPlanta.Division.daoDivision
        'Dim objDAL As New Ransa.DAO.UbicacionPlanta.Division.daoDivision
        dt = New DataTable
        dt = objDAL.Lista_Division_X_Usuario_Y_Compania(_pUsuario, _PSCCMPN)
        dt.Columns.Remove("CCMPN")
        Dim dr As DataRow
        dr = dt.NewRow
        dr("CDVSN") = "0"
        dr("TCMPDV") = "TODOS"
        dt.Rows.InsertAt(dr, 0)
        cmbDivision1.DisplayMember = "TCMPDV"
        cmbDivision1.ValueMember = "CDVSN"
        cmbDivision1.DataSource = dt
        cmbDivision1.SelectedValue = "0"

        For i As Integer = 0 To cmbDivision1.Items.Count - 1
            If cmbDivision1.Items.Item(i).Value = "0" Then
                cmbDivision1.SetItemChecked(i, True)
            End If
        Next
        '-------------------------------------------------------------

        Dim ClientePK As Ransa.Controls.Cliente.TD_ClientePK = New Ransa.Controls.Cliente.TD_ClientePK(0, _pUsuario)
        txtClienteOrigen.pCargar(ClientePK)

    End Sub

    Function Valida() As String
        Dim msg As String = ""
        Dim divisiones As String = ""
        divisiones = Lista_Divisiones()

        If divisiones.Trim = "" Then
            msg = "* Seleccione una división" & Environment.NewLine
        End If
        If txtClienteOrigen.pCodigo = 0D Then
            msg = msg & "* Seleccione un cliente" & Environment.NewLine
        End If

        Return msg
    End Function

    Private Sub btnCopiarPerfil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopiarPerfil.Click
        Try
            dtgIncidencias.EndEdit()
            If HaySeleccionCliente() = True Then
                If dtgIncidencias.CurrentRow IsNot Nothing And dtgIncidencias.Rows.Count > 0 Then

                    Dim ObjBLL As New brIncidencias
                    Dim ObjBE As New beIncidencias

                    Dim Fila As Int32 = 0
                    Dim retorno As Int32 = 0
                    For Fila = 0 To dtgIncidencias.RowCount - 1
                        If dtgIncidencias.Rows(Fila).Cells("CHECK").Value = True Then

                            With ObjBE
                                .PSCCMPN = _PSCCMPN
                                .PNCINCID = Me.dtgIncidencias.Item("CINCID", Fila).Value
                                .PNCCLNT = _pCodCliente
                                .PSUSUARIO = _pUsuario
                                .PSNTRMNL = Environment.MachineName
                            End With

                            ObjBLL.InsertarIncidenciasCliente(ObjBE)
                            Me.DialogResult = Windows.Forms.DialogResult.OK

                        End If
                    Next
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                End If
            Else
                MessageBox.Show("Debe seleccionar al menos un registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Poner_Check_Todo_Cliente(ByVal blnEstado As Boolean)
        Dim intCont As Integer
        For intCont = 0 To dtgIncidencias.RowCount - 1
            dtgIncidencias.Rows(intCont).Cells("CHECK").Value = blnEstado
        Next
    End Sub

    Private Function HaySeleccionCliente() As Boolean
        dtgIncidencias.EndEdit()
        Dim intCont As Integer
        Dim HaySeleccionadosCliente As Boolean = False
        For intCont = 0 To dtgIncidencias.RowCount - 1
            If dtgIncidencias.Rows(intCont).Cells("CHECK").Value = True Then
                HaySeleccionadosCliente = True
                Exit For
            End If
        Next
        Return HaySeleccionadosCliente
    End Function

    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click

        dtgIncidencias.EndEdit()
        isCheckCliente = Not isCheckCliente
        If isCheckCliente = True Then
            btnCheck.Image = My.Resources.btnMarcarItems
        Else
            btnCheck.Image = My.Resources.btnNoMarcarItems
        End If
        Poner_Check_Todo_Cliente(isCheckCliente)
    End Sub

    Private Function Lista_Divisiones() As String

        Dim strCadDocumentos As String = ""
        Dim valida As Boolean = False
        For i As Integer = 0 To cmbDivision1.CheckedItems.Count - 1
            For j As Integer = 0 To dt.Rows.Count - 1
                If (dt.Rows(j).Item("CDVSN") = cmbDivision1.CheckedItems(i).Value) Then
                    If (dt.Rows(j).Item("CDVSN") = "0") Then
                        valida = True
                    End If
                End If
            Next
        Next

        If valida = True Then
            For i As Integer = 0 To cmbDivision1.CheckedItems.Count - 1
                For j As Integer = 0 To dt.Rows.Count - 1
                    If (dt.Rows(j).Item("CDVSN") <> "0") Then
                        strCadDocumentos += dt.Rows(j).Item("CDVSN") & ","
                    End If
                Next
            Next
        Else
            For i As Integer = 0 To cmbDivision1.CheckedItems.Count - 1
                For j As Integer = 0 To dt.Rows.Count - 1
                    If (dt.Rows(j).Item("CDVSN") = cmbDivision1.CheckedItems(i).Value) Then
                        strCadDocumentos += dt.Rows(j).Item("CDVSN") & ","
                    End If
                Next
            Next
        End If

        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos

    End Function
End Class
