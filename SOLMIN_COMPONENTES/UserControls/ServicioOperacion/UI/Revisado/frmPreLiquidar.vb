Imports Ransa.Utilitario
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.Controls.ServicioOperacion.UcPorRevision
Public Class frmPreLiquidar
    Public CCLNT As Integer = 0
    Public NPRLQD As Int64 = 0
    Public CCMPN As String = ""
    Public CDVSN As String = ""
    Public CPLNDV As Integer = 0


    Public CDVSN_1 As String = ""
    Public CPLNDV_1 As String = ""
    Public CCMPN_1 As String = ""

    Private _ListFactura_Transporte As List(Of PreLiquidar_BE)


    Public Property ListFactura_Transporte() As List(Of PreLiquidar_BE)
        Get
            Return _ListFactura_Transporte
        End Get
        Set(ByVal value As List(Of PreLiquidar_BE))
            _ListFactura_Transporte = value
        End Set
    End Property


    Private Sub cblTipoDoc_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cblTipoDoc.SelectionChangeCommitted
        Try
            txtDocCliente.Enabled = (cblTipoDoc.SelectedValue <> "")
            txtSubDocCliente.Enabled = (cblTipoDoc.SelectedValue <> "")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
   

    Private Sub btnPreLiquidacion_Click(sender As Object, e As EventArgs) Handles btnPreLiquidacion.Click
        Try
            If cblTipoDoc.SelectedValue <> "" Then
                If txtDocCliente.Text.Trim = "" Then
                    MessageBox.Show("Ingrese documento cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End If

            Dim objListFactura_Transporte As New List(Of PreLiquidar_BE)
            Dim objEntidad As PreLiquidar_BE
            Dim NSECFC As String = ""
            Dim msg As String = ""
            Dim NPRLCF As Decimal = 0
            Dim lstrCadenaPreFactura As String = ""
            Dim objParametro As New Hashtable
            Dim obj_Logica As New clsPreLiquidar_BL
            Dim letra As String = ""
            objEntidad = New PreLiquidar_BE
            objEntidad.CCLNT = CCLNT
            objEntidad.CCMPN = CCMPN
            objEntidad.CDVSN = CDVSN
            objEntidad.CULUSA = ConfigurationWizard.UserName
            objEntidad.NTRMNL = HelpClass.NombreMaquina
            NSECFC = Lista_NSECFC()
            Dim newvalor As String = ""

            objEntidad.TPDCPE = cblTipoDoc.SelectedValue.ToString.Trim
            If cblTipoDoc.SelectedValue <> "" Then
                objEntidad.DCCLNT = txtDocCliente.Text.Trim
                objEntidad.SBCLNT = txtSubDocCliente.Text.Trim
            End If
 
            msg = obj_Logica.Registrar_PreLiquidacion(objEntidad, NSECFC, NPRLCF)

            If msg.Length = 0 Then
                HelpClass.MsgBox("Se realizó la Pre - Liquidación N° " & NPRLCF)
               
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                HelpClass.MsgBox("No culminó la Pre - Liquidación" & Chr(13) & msg, MessageBoxIcon.Warning)
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Function Lista_NSECFC() As String
        Dim strCadDocumentos As String = ""

        For Each row As DataGridViewRow In dgwPreFacturacion.Rows
            strCadDocumentos += row.Cells("NSECFC").Value.ToString & ","
        Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos
    End Function

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        Exit Sub
    End Sub


    Private Sub Listar_PreFacturacion()
        Me.dgwPreFacturacion.DataSource = Me.ListFactura_Transporte 'dt
        HeaderDatos.ValuesPrimary.Heading = ""
    End Sub
   
    Private Sub frmPreLiquidar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.dgwPreFacturacion.AutoGenerateColumns = False
            Dim OTipoDatoGeneral_BLL As New clsDatoGeneral_BLL
            Dim obeTipoDatoGeneral As New TipoDatoGeneral
            Dim oListTipoDatoGeneral As New List(Of TipoDatoGeneral)
            oListTipoDatoGeneral = OTipoDatoGeneral_BLL.Lista_Tipo_Dato_General(CCMPN_1, "TPDCLT")
            obeTipoDatoGeneral.CODIGO_TIPO = ""
            obeTipoDatoGeneral.DESC_TIPO = "::Seleccione::"
            oListTipoDatoGeneral.Insert(0, obeTipoDatoGeneral)
            cblTipoDoc.DataSource = oListTipoDatoGeneral
            cblTipoDoc.ValueMember = "CODIGO_TIPO"
            cblTipoDoc.DisplayMember = "DESC_TIPO"
            cblTipoDoc.SelectedValue = ""
            cblTipoDoc_SelectionChangeCommitted(cblTipoDoc, Nothing)
            Me.Listar_PreFacturacion()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class