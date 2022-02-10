Imports System.Windows.Forms

Public Class frmRegistroIncidenciaCliente

    Private _pCompania As String
    Public Property pCompania() As String
        Get
            Return _pCompania
        End Get
        Set(ByVal value As String)
            _pCompania = value
        End Set
    End Property

    Private _pDivision As String
    Public Property pDivision() As String
        Get
            Return _pDivision
        End Get
        Set(ByVal value As String)
            _pDivision = value
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

    Private _pClienteDes As String
    Public Property pClienteDes() As String
        Get
            Return _pClienteDes
        End Get
        Set(ByVal value As String)
            _pClienteDes = value
        End Set
    End Property

    Private _pCliente As Decimal
    Public Property pCliente() As Decimal
        Get
            Return _pCliente
        End Get
        Set(ByVal value As Decimal)
            _pCliente = value
        End Set
    End Property

    'Private _pIncidencia As Decimal
    'Public Property pIncidencia() As Decimal
    '    Get
    '        Return _pIncidencia
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _pIncidencia = value
    '    End Set
    'End Property


    Private Sub frmRegistroIncidenciaCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        UcCompania_Cmb011.Usuario = _pUsuario
        UcCompania_Cmb011.pActualizar()
        UcCompania_Cmb011.HabilitarCompaniaActual(_pCompania)
        txtCliente.Text = txtCliente.Text & _pClienteDes

    End Sub

    Private Sub UcCompania_Cmb011_Seleccionar(ByVal obeCompania As Ransa.TypeDef.UbicacionPlanta.Compania.beCompania) Handles UcCompania_Cmb011.Seleccionar
        Try
            UcDivision_Cmb011.Compania = obeCompania.CCMPN_CodigoCompania
            UcDivision_Cmb011.Usuario = _pUsuario
            UcDivision_Cmb011.DivisionDefault = _pDivision
            UcDivision_Cmb011.pActualizar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UcDivision_Cmb011_Seleccionar(ByVal obeDivision As Ransa.TypeDef.UbicacionPlanta.Division.beDivision) Handles UcDivision_Cmb011.Seleccionar
        Try
            txtIncidencia.Valor = ""
            ListarIncidencias()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ListarIncidencias()

        Dim DT As New DataTable
        Dim obrIncidencia As New brIncidencias
        Dim obeIncidencias As New beIncidencias
        Dim obj As New beIncidencias
        Dim Lista As New List(Of beIncidencias)
        With obeIncidencias
            .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
            .PSCDVSN = UcDivision_Cmb011.Division
        End With
        Dim oListColum As New Hashtable
        Dim oColumnas As New DataGridViewTextBoxColumn
        oColumnas.Name = "CINCID"
        oColumnas.DataPropertyName = "PNCINCID"
        oColumnas.HeaderText = "Código "
        oListColum.Add(1, oColumnas)
        oColumnas = New DataGridViewTextBoxColumn
        oColumnas.Name = "TINCSI"
        oColumnas.DataPropertyName = "PSTINCSI"
        oColumnas.HeaderText = "Incidencia"
        oListColum.Add(2, oColumnas)
        DT = obrIncidencia.olistListarMaestroIncidencias(obeIncidencias)
        For Each dr As DataRow In DT.Rows
            obj = New beIncidencias
            obj.PNCINCID = dr("CINCID")
            obj.PSTINCSI = dr("TINCSI")
            Lista.Add(obj)
        Next
        txtIncidencia.DataSource = Lista
        txtIncidencia.ListColumnas = oListColum
        txtIncidencia.Cargas()
        txtIncidencia.ValueMember = "PNCINCID"
        txtIncidencia.DispleyMember = "PSTINCSI"

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Try
            Me.DialogResult = Windows.Forms.DialogResult.Cancel

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Try
            Dim mensaje As String = ""
            mensaje = Valida()
            If mensaje.Trim.Length > 0 Then
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim ObjBLL As New brIncidencias
            Dim ObjBE As New beIncidencias

            With ObjBE
                .PSCCMPN = UcCompania_Cmb011.CCMPN_CodigoCompania
                .PNCINCID = CType(txtIncidencia.Resultado, beIncidencias).PNCINCID
                .PNCCLNT = _pCliente
                .PSUSUARIO = _pUsuario
                .PSNTRMNL = Environment.MachineName
            End With

            ObjBLL.InsertarIncidenciasCliente(ObjBE)
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Function Valida() As String

        Dim mensaje As String = ""
        If txtIncidencia.Resultado Is Nothing Then mensaje &= "* Seleccionar un tipo incidencia." & vbNewLine
        Return mensaje
    End Function

End Class
