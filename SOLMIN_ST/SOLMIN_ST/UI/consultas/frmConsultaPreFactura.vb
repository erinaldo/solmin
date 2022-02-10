Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports CrystalDecisions.CrystalReports.Engine
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports SOLMIN_ST.NEGOCIO
Imports SOLMIN_ST.NEGOCIO.mantenimiento
Imports SOLMIN_ST.ENTIDADES



Public Class frmConsultaPreFactura

#Region "Atributos"
    Private bs As New BindingSource
#End Region


#Region "Propiedades"

    Private _mNPRLQD As Decimal = 0

    Public Property mNPRLQD() As Decimal
        Get
            Return _mNPRLQD
        End Get
        Set(ByVal value As Decimal)
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

    Public pCDVSN As String = ""
    Public pCCLNT As Decimal = 0
    Public pCCLNFC As Decimal = 0
 

#End Region


    Private Sub frmConsultaPreFactura_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            ListaConsultaPreFactura()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

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
                    objEntidad.CULUSA = MainModule.USUARIO
                    objEntidad.FULTAC = HelpClass.TodayNumeric
                    objEntidad.HULTAC = HelpClass.NowNumeric
                    objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                    objGenericCollection.Add(objEntidad)

                End If
            Next
            If objGenericCollection.Count = 0 Then Exit Sub
            lintResultado = obj_Logica.Quitar_Pre_Factura(objGenericCollection)
            If lintResultado = 1 Then
                HelpClass.MsgBox("Se anuló la Consulta Pre - Factura Satisfactoriamente")
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



    Private Sub btnAdPreFactura_Click(sender As Object, e As EventArgs) Handles btnAdPreFactura.Click
        Try
            Dim ofrmPreFactura As New frmAddPreFactura
            ofrmPreFactura.pCCMPN = _mCompania
            ofrmPreFactura.pCDVSN = pCDVSN
            ofrmPreFactura.pCCLNT = pCCLNT
            ofrmPreFactura.pCCLNFC = pCCLNFC
            ofrmPreFactura.pNPRLQD = _mNPRLQD
            If ofrmPreFactura.ShowDialog() = Windows.Forms.DialogResult.OK Then
                ListaConsultaPreFactura()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
