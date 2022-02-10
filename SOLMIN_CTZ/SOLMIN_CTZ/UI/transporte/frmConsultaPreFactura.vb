Imports SOLMIN_CTZ.NEGOCIO.Operaciones
Imports SOLMIN_CTZ.ENTIDADES.Operaciones
Imports CrystalDecisions.CrystalReports.Engine
Imports SOLMIN_CTZ.ENTIDADES.Mantenimientos
Imports SOLMIN_CTZ.NEGOCIO
Imports SOLMIN_CTZ.NEGOCIO.mantenimiento
Imports SOLMIN_CTZ.ENTIDADES
Imports Db2Manager.RansaData.iSeries.DataObjects


Public Class frmConsultaPreFactura

#Region "Atributos"
    Private bs As New BindingSource
#End Region


#Region "Propiedades"

    Private _mNPRLQD As Integer = 0

    Public Property mNPRLQD() As Integer
        Get
            Return _mNPRLQD
        End Get
        Set(ByVal value As Integer)
            _mNPRLQD = value
        End Set
    End Property

    Private _mCompania As String = ""

    Public Property mCompania() As String
        Get
            Return _mCompania
        End Get
        Set(ByVal value As String)
            _mCompania = value
        End Set
    End Property

#End Region


    Private Sub frmConsultaPreFactura_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ListaConsultaPreFactura()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Dim objfrmPreLiquidacion As New frmPreLiquidacion()

    End Sub


    Private Sub ListaConsultaPreFactura()
        Dim obj_Logica As New PreLiquidacion_BLL
        Dim objetoParametro As New Hashtable
        objetoParametro.Add("NPRLQD", _mNPRLQD)
        objetoParametro.Add("PSCCMPN", _mCompania)
        dgwPreFacturacion.AutoGenerateColumns = False
        bs.DataSource = HelpClass.GetDataSetNative(obj_Logica.ListarPreFacturas_x_PreLiquidacion(objetoParametro))
        dgwPreFacturacion.DataSource = bs

    End Sub




    Private Sub TbtnQuitarPreFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TbtnQuitarPreFactura.Click
        Try
            If Me.dgwPreFacturacion.RowCount = 0 Then Exit Sub
            Dim obj_Logica As New PreLiquidacion_BLL
            Dim objEntidad As New Factura_Transporte
            Dim ListaParametros As New List(Of String)
            Dim objGenericCollection As New List(Of Factura_Transporte)
            Dim lintResultado As Integer = 0
            Me.dgwPreFacturacion.EndEdit()
            For Each row As DataGridViewRow In Me.dgwPreFacturacion.Rows
                If row.Cells("chk").Value = "S" Then
                    objEntidad = New Factura_Transporte
                    objEntidad.NDCPRF = row.Cells("NDCPRF").Value
                    objEntidad.NPRLQD = _mNPRLQD
                    objEntidad.CCMPN = _mCompania
                    'objEntidad.CCMPN = Me.cboCompania.SelectedValue
                    'objEntidad.CDVSN = Me.cboDivision.SelectedValue
                    'objEntidad.CPLNCL = 0
                    'objEntidad.FDCPRF = HelpClass.CFecha_a_Numero8Digitos(row.Cells("FDCPRF").Value)
                    objEntidad.CULUSA = ConfigurationWizard.UserName
                    objEntidad.FULTAC = HelpClass.TodayNumeric
                    objEntidad.HULTAC = HelpClass.NowNumeric
                    objEntidad.NTRMNL = HelpClass.NombreMaquina
                    objGenericCollection.Add(objEntidad)
                    ''tengo q modificar el store procedure agregando los parametros q e ingresado
                End If
            Next
            If objGenericCollection.Count = 0 Then Exit Sub
            'lintResultado = obj_Logica.Anular_Pre_Factura(objGenericCollection)
            lintResultado = obj_Logica.Quitar_Pre_Factura(objGenericCollection)
            If lintResultado = 1 Then
                HelpClass.MsgBox("Se anuló la Consulta Pre - Factura Satisfactoriamente")
                'Me.Listar_PreFactura(CType(Me.gwdDatos.SelectedRows(0).Cells("CCLNT").Value, Integer))
                Me.ListaConsultaPreFactura()
            Else
                HelpClass.MsgBox("Ocurrió un Error, no se anuló la Pre - Factura", MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgwPreFacturacion_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwPreFacturacion.CellContentClick

    End Sub



End Class
