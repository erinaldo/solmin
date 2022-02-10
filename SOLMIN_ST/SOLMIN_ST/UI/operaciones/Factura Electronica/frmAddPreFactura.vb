Imports SOLMIN_ST.NEGOCIO.Operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports CrystalDecisions.CrystalReports.Engine
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO
Public Class frmAddPreFactura
    Public pCCLNT As Decimal = 0
    Public pCCLNFC As Decimal = 0
    Public pCCMPN As String = ""
    Public pCDVSN As String = ""
    Public pNPRLQD As Decimal = 0
    Private Sub frmAddPreFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dgwPreFacturacion.AutoGenerateColumns = False
            Listar_PreFactura()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Listar_PreFactura()
        Dim obj_Logica As New PreLiquidacion_BLL
        Dim objetoParametro As New Hashtable
        objetoParametro.Add("PNCCLNT", pCCLNT)
        objetoParametro.Add("PNCCLNFC", pCCLNFC)
        objetoParametro.Add("PSCCMPN", pCCMPN)
        objetoParametro.Add("PSCDVSN", pCDVSN)
        objetoParametro.Add("PNCPLNDV", 0)
        objetoParametro.Add("PNFECINI", 0)
        objetoParametro.Add("PNFECFIN", 0)

        objetoParametro.Add("PNNROVLR", 0)
        objetoParametro.Add("PSTIPOVISTA", "")
        Me.dgwPreFacturacion.DataSource = obj_Logica.Listar_PreFactura(objetoParametro) 'dt
    End Sub


    Function Lista_NDCPRF() As String
        Dim strCadDocumentos As String = ""

        For Each row As DataGridViewRow In dgwPreFacturacion.Rows
            If row.Cells("chk").Value = "S" Then
                strCadDocumentos += row.Cells("NDCPRF").Value.ToString & ","
            End If

        Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos
    End Function

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Try

            If dgwPreFacturacion.RowCount = 0 Then Exit Sub
            Dim objEntidad As New Factura_Transporte
            Dim objGenericCollection As New List(Of Factura_Transporte)
            Dim objfrmListaPreFactura As New frmListaPreFactura
            Me.dgwPreFacturacion.EndEdit()
            If Consistencia_Organizacion_Venta(Me.dgwPreFacturacion) = False Then
                HelpClass.MsgBox("La Organización de Venta de las Pre-Facturas seleccionadas no son las mismas.", MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim objListFactura_Transporte As New List(Of Factura_Transporte)
            Dim ACCION As String = ""
            Dim NDCPRF As String = ""
            Dim msg As String = ""
            Dim objParametro As New Hashtable
            Dim obj_Logica As New PreLiquidacion_BLL
            objEntidad = New Factura_Transporte
            objEntidad.CCMPN = pCCMPN
            objEntidad.CDVSN = pCDVSN
            objEntidad.CPLNCL = 0
            objEntidad.CULUSA = MainModule.USUARIO
            objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            NDCPRF = Lista_NDCPRF()
            ACCION = "ADD"
            If Lista_NDCPRF.Length = 0 Then
                MessageBox.Show("No ha seleccionado ninguna Pre-Factura", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            msg = obj_Logica.Registrar_PreLiquidacion(objEntidad, NDCPRF, pNPRLQD, ACCION)

            If msg.Length = 0 Then
                HelpClass.MsgBox("Las Pre-Facturas fueron adicionadas a la PL")
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                HelpClass.MsgBox("No culminó la adición:" & Chr(13) & msg, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

 
    End Sub

    Private Function Consistencia_Organizacion_Venta(ByVal Sender As Object) As Boolean
        Dim lstr_Estado As Boolean = True
        Dim cOrgVenta As String = ""
        Dim dOrgVenta As String = ""
        Dim intIndice As Int32 = 0
        cOrgVenta = ""
        Sender.EndEdit()
        For lint_Contador As Integer = 0 To Sender.RowCount - 1
            If Sender.Item("chk", lint_Contador).Value = "S" Then
                If intIndice = 0 Then
                    cOrgVenta = Sender.Item("CRGVTA_D", lint_Contador).Value
                    dOrgVenta = Sender.Item("TCRVTA_D", lint_Contador).Value
                    lstr_Estado = True
                    intIndice += 1
                Else
                    If Sender.Item("CRGVTA_D", lint_Contador).Value.ToString.Trim <> cOrgVenta.Trim Then
                        lstr_Estado = False
                    End If
                End If
            End If

        Next
        Return lstr_Estado
    End Function

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class