Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Public Class frmConsultaPreFac

    'Private bs As New BindingSource

#Region "Propiedades"
    Public ORGVENTA As String = ""
     

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

    'clsFacturaPreDoc_BL  'PreLiquidacion_BLL
    'FacturaPreDoc_BE  'Factura_Transporte
    Private Sub frmConsultaPreFac_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            ListaConsultaPreFactura()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        Exit Sub
    End Sub
    Dim dt As New DataTable
    Private Sub ListaConsultaPreFactura()
        Dim obj_Logica As New clsFacturaPreDoc_BL
        Dim objetoParametro As New Hashtable
        'Dim dt As New DataTable
        objetoParametro.Add("NPRLQD", _mNPRLQD)
        objetoParametro.Add("PNCCLNT", pCCLNT)
        objetoParametro.Add("PSCCMPN", _mCompania)
        dgwPreFacturacion.AutoGenerateColumns = False
        'dt.DataSource = HelpClass.GetDataSetNative(obj_Logica.ListarPreFacturas_x_PreLiquidacion(objetoParametro))
        dt = obj_Logica.ListarPreFacturas_x_PreLiquidacion(objetoParametro)
        dgwPreFacturacion.DataSource = dt

    End Sub


    Private Sub TbtnQuitarPreFactura_Click(sender As Object, e As EventArgs) Handles TbtnQuitarPreFactura.Click
        Try
            If Me.dgwPreFacturacion.RowCount = 0 Then Exit Sub
            Dim obj_Logica As New clsFacturaPreDoc_BL
            Dim objEntidad As New FacturaPreDoc_BE
            Dim ListaParametros As New List(Of String)
            Dim objGenericCollection As New List(Of FacturaPreDoc_BE)
            Dim lintResultado As Integer = 0
            Me.dgwPreFacturacion.EndEdit()
            For Each row As DataGridViewRow In Me.dgwPreFacturacion.Rows
                If row.Cells("chk").Value = "S" Then
                    objEntidad = New FacturaPreDoc_BE
                    objEntidad.NSECFC = row.Cells("NSECFC").Value
                    objEntidad.NPRLQD = _mNPRLQD
                    objEntidad.CCMPN = _mCompania
                    objEntidad.CULUSA = ConfigurationWizard.UserName
                    objEntidad.FULTAC = HelpClass.TodayNumeric
                    objEntidad.HULTAC = HelpClass.NowNumeric
                    objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                    objEntidad.CCLNT = pCCLNT
                    objGenericCollection.Add(objEntidad)

                End If
            Next
            If objGenericCollection.Count = 0 Then Exit Sub
            lintResultado = obj_Logica.Quitar_Pre_Factura(objGenericCollection)
            If lintResultado = 1 Then
                HelpClass.MsgBox("Se anuló la/s Consistencia/s Satisfactoriamente")
                Me.ListaConsultaPreFactura()
            Else
                HelpClass.MsgBox("Ocurrió un Error, no se anuló la Consistencia", MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAdPreFactura_Click(sender As Object, e As EventArgs) Handles btnAdPreFactura.Click
        Try
            Dim ofrmPreFactura As New frmAddPreFact
            ofrmPreFactura.pCCMPN = _mCompania
            ofrmPreFactura.pCDVSN = pCDVSN
            ofrmPreFactura.pCCLNT = pCCLNT
            ofrmPreFactura.pCCLNFC = pCCLNFC
            ofrmPreFactura.pNPRLQD = _mNPRLQD
            ofrmPreFactura.ORGVENTA = ORGVENTA

            If ofrmPreFactura.ShowDialog() = Windows.Forms.DialogResult.OK Then
                ListaConsultaPreFactura()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class