Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Public Class frmAddPreFact
    Public pCCLNT As Decimal = 0
    Public pCCLNFC As Decimal = 0
    Public pCCMPN As String = ""
    Public pCDVSN As String = ""
    Public pNPRLQD As Decimal = 0
    Public ORGVENTA As String = ""
    'clsFacturaPreDoc_BL  'PreLiquidacion_BLL
    'FacturaPreDoc_BE  'Factura_Transporte
    Private Sub AddPreFact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dgwPreFacturacion.AutoGenerateColumns = False
            Listar_PreFactura()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Listar_PreFactura()
        Dim obj_Logica As New clsFacturaPreDoc_BL
        Dim objetoParametro As New Hashtable
        Dim dt As New DataTable
        objetoParametro.Add("PNCCLNT", pCCLNT)
        objetoParametro.Add("PNCCLNFC", pCCLNFC)
        objetoParametro.Add("PSCCMPN", pCCMPN)
        objetoParametro.Add("PSCDVSN", pCDVSN)

        'objetoParametro.Add("PNNROVLR", 0)
        ' objetoParametro.Add("PSTIPOVISTA", "")
        dt = obj_Logica.Listar_PreFactura(objetoParametro)
        Me.dgwPreFacturacion.DataSource = dt 'dt
    End Sub

    Function Lista_NSECFC() As String
        Dim strCadDocumentos As String = ""

        For Each row As DataGridViewRow In dgwPreFacturacion.Rows
            If row.Cells("chk").Value = "S" Then
                strCadDocumentos += row.Cells("NSECFC").Value.ToString & ","
            End If

        Next
        If strCadDocumentos <> "" Then strCadDocumentos = strCadDocumentos.Trim.Substring(0, strCadDocumentos.Trim.Length - 1)
        Return strCadDocumentos
    End Function

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try

            If dgwPreFacturacion.RowCount = 0 Then Exit Sub
            Dim objEntidad As New FacturaPreDoc_BE
            Dim objGenericCollection As New List(Of FacturaPreDoc_BE)
            'Dim objfrmListaPreFactura As New frmListaPreFactura
            Me.dgwPreFacturacion.EndEdit()
            If Consistencia_Organizacion_Venta(Me.dgwPreFacturacion) = False Then
                HelpClass.MsgBox("La Organización de Venta de las Consistencias seleccionadas no son las mismas.", MessageBoxIcon.Information)
                Exit Sub
            End If
            For Each item As DataGridViewRow In dgwPreFacturacion.Rows
                If item.Cells("chk").Value = "S" Then
                    If ORGVENTA <> item.Cells("TCRVTA_D").Value Then
                        MessageBox.Show("Organización de Venta de las consistencias no son las mismas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                End If
            Next

            'If Consistencia_Organizacion_Venta(frmPLFacElectronicoSD.dgwLiquidacion) = False Then '(Me.dgwPreFacturacion) = False Then
            '    HelpClass.MsgBox("La Organización de Venta de las Consistencias seleccionadas no son las mismas.", MessageBoxIcon.Information)
            '    Exit Sub
            'End If
            Dim objListFactura_Transporte As New List(Of FacturaPreDoc_BE)
            'Dim ACCION As String = ""
            Dim NSECFC As String = ""
            Dim msg As String = ""
            Dim objParametro As New Hashtable
            Dim obj_Logica As New clsFacturaPreDoc_BL
            objEntidad = New FacturaPreDoc_BE
            objEntidad.NPRLCF = pNPRLQD
            objEntidad.CCMPN = pCCMPN
            objEntidad.CDVSN = pCDVSN
            objEntidad.CPLNCL = 0
            objEntidad.CULUSA = ConfigurationWizard.UserName
            objEntidad.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
            objEntidad.CCLNT = pCCLNT
            NSECFC = Lista_NSECFC()

            'ACCION = "ADD"
            'HACER VALIDACION PARA QUE NO AGREGUE CON DIFERENTE ORGANIZACION

            If Lista_NSECFC.Length = 0 Then
                MessageBox.Show("No ha seleccionado ninguna Consistencia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            msg = obj_Logica.Actualizar_PreLiquidacion(objEntidad, NSECFC)  'REUTILIZAR EL PRELIQUIDAR

            If msg.Length = 0 Then
                HelpClass.MsgBox("Las Consistencias fueron adicionadas a la PL")
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
        Exit Sub
    End Sub
End Class