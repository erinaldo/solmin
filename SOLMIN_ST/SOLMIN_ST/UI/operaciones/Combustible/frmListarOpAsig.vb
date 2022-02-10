 
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones


Public Class frmListarOpAsig

    Public pPlaca As String = ""
    Public pCCMPN As String = ""
    Public pCDVSN As String = ""
    Public pNroLiqComb As Decimal = 0
    Public pDialog As Boolean = False
    Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().


    End Sub

    Private Sub frmOperacionesxProveedor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            gwdOperacion.AutoGenerateColumns = False
            txtPlaca.Text = pPlaca
            txtPlaca.Enabled = False
            txtoperacion.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            If ckbFechaOperacion.Checked = False Then
                If Val(txtoperacion.Text.Trim) = 0 Then
                    MessageBox.Show("Ingrese operación.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End If
          
            Buscar_Operaciones()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub Buscar_Operaciones()
        Dim objParametro As New Hashtable
        objParametro.Add("CCMPN", pCCMPN)
        objParametro.Add("CDVSN", pCDVSN)
        objParametro.Add("NPLCUN", pPlaca)
        objParametro.Add("NOPRCN", Val(txtoperacion.Text))
        If ckbFechaOperacion.Checked = True Then
            objParametro("FECINI") = HelpClass.CFecha_a_Numero8Digitos(dtpFechaInicio.Value)
            objParametro("FECFIN") = HelpClass.CFecha_a_Numero8Digitos(dtpFechaFin.Value)
        Else
            objParametro("FECINI") = 0
            objParametro("FECFIN") = 0
        End If

        Dim obj_LogicaLiquidacion As New LiquidacionCombustible_BLL
        Dim dtresult As New DataTable
        dtresult = obj_LogicaLiquidacion.Listar_Operacion_Pendientes_Liquidacion_Combustible(objParametro)
        gwdOperacion.DataSource = dtresult
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
            gwdOperacion.EndEdit()
            If TieneSeleccion() = False Then
                If MessageBox.Show("No ha seleccionado ninguna operación.", "Aviso", MessageBoxButtons.OK) Then
                    Exit Sub
                End If
            End If

            Dim objOperacion As LiquidacionCombustible
            Dim obj_LiquidacionCombustible_Logica As New LiquidacionCombustible_BLL
            For Each item As DataGridViewRow In gwdOperacion.Rows
                If item.Cells("chkSel").Value = True Then
                    objOperacion = New LiquidacionCombustible
                    objOperacion.NLQCMB = pNroLiqComb
                    objOperacion.NOPRCN = item.Cells("NOPRCN").Value
                    objOperacion.CULUSA = MainModule.USUARIO
                    objOperacion.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                    obj_LiquidacionCombustible_Logica.Registrar_Detalle_Liquidacion_Combustible2(objOperacion)
                End If
              
            Next
            pDialog = True
            Buscar_Operaciones()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

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





End Class
