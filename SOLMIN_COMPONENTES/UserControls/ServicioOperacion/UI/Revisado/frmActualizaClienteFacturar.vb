
Public Class frmActualizaClienteFacturar

#Region "Declaracion de Variables"

    Private Estatico As New Estaticos
    Private oServicioOpeNeg As New clsServicio_BL
    Private _oServicio As Servicio_BE
    Private oDtRevisiones As New DataTable
    Public oDtg As New DataGridView



#End Region

#Region "Propiedades"

    Public Property oServicio() As Servicio_BE
        Get
            Return _oServicio
        End Get
        Set(ByVal value As Servicio_BE)
            _oServicio = value
        End Set
    End Property

#End Region

#Region "Eventos de Control"

    Private Sub frmActualizaClienteFacturar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oDtRevisiones.Columns.Add("Revision", GetType(String))
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Dim obe As Servicio_BE

        If UcClienteFact.pCodigo = 0 Then
            MessageBox.Show("Ingrese Cliente", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If validarInformacionCliente(oDtg) = False Then
            Exit Sub
        Else
            For Each dr As DataRow In oDtRevisiones.Rows
                obe = New Servicio_BE
                obe.CCLNFC = UcClienteFact.pCodigo
                obe.NSECFC = dr("Revision")
                oServicioOpeNeg.fintActualizaClienteFacturarPorRevision(obe)
            Next

            DialogResult = Windows.Forms.DialogResult.Yes

        End If
    End Sub

#End Region

#Region "Procedimientos y Funciones"

    Private Function validarInformacionCliente(ByVal dtg As DataGridView) As Boolean

        Dim b As Boolean = True
        Dim intProcesado As Integer = 0
        Dim intCont As Integer
        Dim cliOpePri As Integer = 0
        Dim cliFacPri As Integer = 0
        Dim cliOpeSig As Integer = 0
        Dim cliFacSig As Integer = 0
        Dim cliComp1 As String = ""
        Dim cliComp2 As String = ""
        Dim opeRG1 As String = "" 'Region Venta 1
        Dim opeRG2 As String = "" 'Region Venta 2
        Dim valCTPALJ1 As String = ""
        Dim valCTPALJ2 As String = ""
        Dim valCMNDA1 As String = ""
        Dim valCMNDA2 As String = ""
        Dim oDtRevision As New DataTable
        Dim PLANTA1 As String = ""
        Dim PLANTA2 As String = ""



        '=================Valida que este marcado y que pertenezca a la misma Region Venta===============
        For intCont = 0 To dtg.Rows.Count - 1
            If Convert.ToBoolean(dtg.Rows(intCont).Cells("chk").Value) = True Then
                intProcesado = intProcesado + 1
                oServicio.FECINI = 0
                oServicio.FECFIN = 99999999
                oServicio.CTPALJ = "0"

                Dim dr As DataRow

                dr = oDtRevisiones.NewRow
                dr(0) = dtg.Rows(intCont).Cells("NSECFC1").Value
                oDtRevisiones.Rows.Add(dr)

                If intProcesado = 1 Then
                    cliFacPri = dtg.Rows(intCont).Cells("CCLNT").Value
                    cliOpePri = dtg.Rows(intCont).Cells("CCLNFC").Value
                    cliComp1 = cliFacPri.ToString & "-" & cliOpePri.ToString
                    opeRG1 = dtg.Rows(intCont).Cells("CRGVTA").Value

                    oServicio.TIPO_REV = dtg.Rows(intCont).Cells("TIPO_REV").Value

                    oServicio.NSECFC = dtg.Rows(intCont).Cells("NSECFC1").Value

                    oDtRevision = oServicioOpeNeg.Lista_Servicios_Consolidado(oServicio)
                    If oDtRevision.Rows.Count > 0 Then
                        valCTPALJ1 = oDtRevision.Rows(0).Item("CTPALJ")
                    End If
                    PLANTA1 = dtg.Rows(intCont).Cells("CPLNDV1").Value
                    


                    valCMNDA1 = dtg.Rows(intCont).Cells("CMNDA1").Value
                Else
                    cliFacSig = dtg.Rows(intCont).Cells("CCLNT").Value
                    cliOpeSig = dtg.Rows(intCont).Cells("CCLNFC").Value
                    cliComp2 = cliFacSig.ToString & "-" & cliOpeSig.ToString
                    opeRG2 = dtg.Rows(intCont).Cells("CRGVTA").Value


                    oServicio.NSECFC = dtg.Rows(intCont).Cells("NSECFC1").Value
                    oDtRevision = oServicioOpeNeg.Lista_Servicios_Consolidado(oServicio)

                    If oDtRevision.Rows.Count > 0 Then
                        valCTPALJ2 = oDtRevision.Rows(0).Item("CTPALJ")
                    End If
                    PLANTA2 = dtg.Rows(intCont).Cells("CPLNDV1").Value
                     


                    valCMNDA2 = dtg.Rows(intCont).Cells("CMNDA1").Value
                End If
                'If cliComp1 <> cliComp2 And intProcesado > 1 Then
                '    b = False
                '    MsgBox("Operaciones no pertenecen al mismo Cliente Operación y Cliente a Facturar", MsgBoxStyle.Information)
                '    Exit For
                'End If
                If valCTPALJ1 <> valCTPALJ2 And intProcesado > 1 Then
                    If (valCTPALJ2 = Estatico.E_ESP_Reembolso Or valCTPALJ1 = Estatico.E_ESP_Reembolso) Then
                        b = False
                        MsgBox("Las Operaciones de Reembolso deben ir juntas", MsgBoxStyle.Information)
                        Exit For
                    ElseIf (valCTPALJ2 = Estatico.E_ESP_PesoPromedio Or valCTPALJ1 = Estatico.E_ESP_PesoPromedio) Then
                        b = False
                        MsgBox("Las Operaciones de Almacenaje Promedio deben ir juntas", MsgBoxStyle.Information)
                        Exit For

                    End If
                End If

                If PLANTA1 <> PLANTA2 And intProcesado > 1 Then
                    MsgBox("Las Plantas deben ir juntas", MsgBoxStyle.Information)
                    b = False
                    Exit For
                End If

                If opeRG1 <> opeRG2 And intProcesado > 1 Then
                    b = False
                    MsgBox("Los Servicios Pertenecen a Diferentes Regiones de Venta, No se puede actualizar el cliente a Facturar", MsgBoxStyle.Information)
                    Exit For
                End If
                If valCMNDA1 <> valCMNDA2 And intProcesado > 1 Then
                    b = False
                    MsgBox("Las operaciones estan en diferentes monedas, No se puede actualizar el cliente a Facturar", MsgBoxStyle.Information)
                    Exit For
                End If
            End If
        Next
        If Not b Then
            oDtRevision = New DataTable
        End If
        Return b
    End Function

#End Region

End Class
