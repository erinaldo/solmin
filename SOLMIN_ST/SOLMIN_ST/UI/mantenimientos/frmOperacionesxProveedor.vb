Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.NEGOCIO
Imports Ransa.Utilitario

Public Class frmOperacionesxProveedor
    Private objAlquilerUnidadBLL As New AlquilerUnidad_BLL
    Private objOperacionesXAlquiler As New OperacionesXAlquiler_BLL
    Private oAlquilerUnidad As New AlquilerUnidad

    Private _FechaInicio As String = ""
    Public Property FechaInicio() As String
        Get
            Return _FechaInicio
        End Get
        Set(ByVal value As String)
            _FechaInicio = value
        End Set
    End Property
    Private _FechaFin As String = ""
    Public Property FechaFin() As String
        Get
            Return _FechaFin
        End Get
        Set(ByVal value As String)
            _FechaFin = value
        End Set
    End Property

    'Private strRucProveedor As String = ""
    'Private strProveedor As String = ""
    'Private strCompania As String = ""
    'Private strTipoRecurso As String = ""
    'Private strPlaca As String = ""
    'Private strDesTipoRecurso As String = ""

    Sub New(ByVal objAlquiler As AlquilerUnidad)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        oAlquilerUnidad = objAlquiler
        'strCompania = Compania
        'strRucProveedor = RucProveedor
        'strProveedor = Proveedor
        'strTipoRecurso = TipoRecurso
        'strPlaca = Placa
        'strDesTipoRecurso = DesTipoRecurso
    End Sub

    Private Sub frmOperacionesxProveedor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            'txtProveedor.Tag = oAlquilerUnidad.NRUCTR
            'txtProveedor.Text = oAlquilerUnidad.TCMTRT
            txtTipoRecurso.Text = oAlquilerUnidad.TDSDES
            txtTipoRecurso.Tag = oAlquilerUnidad.STPRCS
            txtPlaca.Text = oAlquilerUnidad.NPLRCS
            dtpFechaInicio.Value = Date.Parse(FechaInicio)
            dtpFechaFin.Value = Date.Parse(FechaFin)
            TxtUsuarioCerrarAlquiler.Text = oAlquilerUnidad.CULUSA
            TxtUsuarioCerrarAlquiler.Enabled = False

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Dim objEntidad As New AlquilerUnidad
            objEntidad.CCMPN = oAlquilerUnidad.CCMPN
            objEntidad.CCLNT = txtClienteFiltro.pCodigo
            'objEntidad.NRUCTR = txtProveedor.Tag
            objEntidad.STPRCS = txtTipoRecurso.Tag
            objEntidad.NPLRCS = txtPlaca.Text
            If ckbFechaOperacion.Checked = True Then
                objEntidad.FINCOPINI = HelpClass.CFecha_a_Numero8Digitos(dtpFechaInicio.Value)
                objEntidad.FINCOPFIN = HelpClass.CFecha_a_Numero8Digitos(dtpFechaFin.Value)
            Else
                objEntidad.FINCOPINI = 0
                objEntidad.FINCOPFIN = 0
            End If

            gwdOperacion.AutoGenerateColumns = False
            gwdOperacion.DataSource = objAlquilerUnidadBLL.Listar_Operacion_X_Proveedor(objEntidad)
            For Each row As DataGridViewRow In gwdOperacion.Rows
                row.Cells(0).Value = True
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function TieneSeleccion() As Boolean
        Dim Tiene As Boolean = False
        For Each row As DataGridViewRow In gwdOperacion.Rows
            If row.Cells("chkSel").Value = True Then
                Tiene = True
                Exit For
            End If
        Next
        Return Tiene
    End Function

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            'chkSel
            'If Me.gwdOperacion.RowCount = 0 OrElse Me.gwdOperacion.CurrentCellAddress.Y < 0 Then
            If TieneSeleccion() = False Then
                If MessageBox.Show("No ha seleccionado ninguna operación." & Chr(13) & "Está seguro de cerrar el alquiler?", "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    If TxtObservacionCierreAlquiler.Text.Trim <> String.Empty Then
                        'Me.DialogResult = Windows.Forms.DialogResult.OK
                        CerrarAlquiler()
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    Else
                        MessageBox.Show("Ingrese observación de cierre.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If
            Else
                CerrarAlquiler()
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    Private Sub gwdOperacion_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdOperacion.CellContentClick
        If Me.gwdOperacion.RowCount = 0 Then Exit Sub
        Select Case e.ColumnIndex
            Case 0
                Me.gwdOperacion.EndEdit()
        End Select
    End Sub

    Private Sub ckbFechaOperacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ckbFechaOperacion.Checked = True Then
            dtpFechaInicio.Enabled = True
            dtpFechaFin.Enabled = True
        Else
            dtpFechaInicio.Enabled = False
            dtpFechaFin.Enabled = False
        End If
    End Sub

 

    Sub CerrarAlquiler()
        Try
            Dim olstOpeXAlquiler As New List(Of OperacionesXAlquiler)
            For Each row As DataGridViewRow In gwdOperacion.Rows
                If row.Cells("chkSel").Value = True Then
                    Dim objEntidad As New OperacionesXAlquiler
                    objEntidad.NRALQT = oAlquilerUnidad.NRALQT
                    objEntidad.NOPRCN = row.Cells("NOPRCN").Value
                    objEntidad.CCNCST = 0
                    objEntidad.NKMRTA = 0
                    'objEntidad.CRUTA = 0 'row.Cells("RUTA").Value
                    objEntidad.CUSCRT = MainModule.USUARIO
                    objEntidad.NTRMCR = Ransa.Utilitario.HelpClass.NombreMaquina
                    olstOpeXAlquiler.Add(objEntidad)
                End If
            Next
            objOperacionesXAlquiler.Registrar_Operacion_X_Alquiler(olstOpeXAlquiler)
            'objOperacionesXAlquiler.Actualizar_NroAlquiler_Operacion(olstOpeXAlquiler)
            ''MessageBox.Show("Se registró las Operaciones del Alquiler Nro. " & oAlquilerUnidad.NRALQT, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
