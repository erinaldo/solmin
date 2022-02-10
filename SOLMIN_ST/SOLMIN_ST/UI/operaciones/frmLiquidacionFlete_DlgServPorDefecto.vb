Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos

Public Class frmliquidacionFlete_DlgServPorDefecto
#Region " Atributos "
    Private sCompania As String = ""
    Private sDivision As String = ""
    Private nOperacion As Int64 = 0
    Private nNroGuiaTransportista As Int64 = 0
    Private sUsuario As String = ""
    Private sTerminal As String = ""
#End Region
#Region " Propiedades "
    
#End Region
#Region " Métodos y Funciones "

#End Region
#Region " Eventos "
    Sub New(ByVal Compania As String, ByVal Division As String, ByVal Operacion As Int64, ByVal GuiaTransportista As Int64, ByVal pDataSource As DataTable, ByVal Usuario As String, ByVal Terminal As String)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        sCompania = Compania
        sDivision = Division
        nOperacion = Operacion
        nNroGuiaTransportista = GuiaTransportista
        sUsuario = Usuario
        sTerminal = Terminal
        Me.dgServiciosPorDefecto.DataSource = pDataSource
    End Sub

    Private Sub btnAgregarServLiqu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarServLiqu.Click
        Dim oInfServ As TD_Obj_GRemAgregarServCargadasGTranspLiq = New TD_Obj_GRemAgregarServCargadasGTranspLiq
        With oInfServ
            .pNOPRCN_NroOperacion = nOperacion
            .pNGUITR_NroGuiaRemision = nNroGuiaTransportista
            .pMMCUSR_Usuario = MainModule.USUARIO
            .pNTRMNL_Terminal = Ransa.Utilitario.HelpClass.NombreMaquina
        End With
        Dim fTemp As frmLiquidacionFlete_DlgAgregarServ = New frmLiquidacionFlete_DlgAgregarServ(sCompania, sDivision, oInfServ)

        If fTemp.ShowDialog = Windows.Forms.DialogResult.OK Then
            oInfServ = fTemp.pInformacionServicio
            Dim dtTemp As DataTable = CType(dgServiciosPorDefecto.DataSource, DataTable)
            Dim rwTemp As DataRow = dtTemp.NewRow
            With rwTemp
                .Item("CHKBOX") = "S"
                .Item("CSRCTZ") = oInfServ.pCSRVC_Servicio
                .Item("TCMTRF") = fTemp.pDetalleServicio
                .Item("TRFSRG") = oInfServ.pTRFSRG_RefrenciaServicioGuia
                .Item("CMNTRN") = oInfServ.pCMNDGU_MonedaGuia
                .Item("ITRSRT") = oInfServ.pISRVGU_importeServicio
                .Item("QMRCDR") = oInfServ.pQCNDTG_CantServicioGuia
                .Item("CUNDMD") = oInfServ.pCUNDSR_Unidad
                .Item("SSRVFE") = "E"
                If oInfServ.pSFCTTR_StatusFacturado <> "" Then
                    .Item("SFCTTR") = "S"
                    'Else
                    '    .Item("SFCTTR") = ""
                End If

            End With
            dtTemp.Rows.Add(rwTemp)
        End If
        fTemp.Dispose()
        fTemp = Nothing
    End Sub

  Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
    ' Si no hay registro salimos sin problemas
    If dgServiciosPorDefecto.RowCount > 0 Then
      ' Procesar los registros
      Dim Objeto_Logica As GuiaTransportista_BLL = New GuiaTransportista_BLL
      Dim oServicio As TD_Obj_GRemAgregarServCargadasGTranspLiq
      Dim iCont As Int32 = 0
      Dim sMensajeError As String = ""
      ' Recorremos los registros de la grilla
      With dgServiciosPorDefecto
        While iCont < .RowCount
          If .Rows(iCont).Cells("M_CHKBOX").Value = "S" Then
            oServicio = New TD_Obj_GRemAgregarServCargadasGTranspLiq
            ' Registramos los valores
            oServicio.pNOPRCN_NroOperacion = nOperacion
            oServicio.pNGUITR_NroGuiaRemision = nNroGuiaTransportista
            oServicio.pCSRVC_Servicio = .Rows(iCont).Cells("M_CSRCTZ").Value
            oServicio.pTRFSRG_RefrenciaServicioGuia = .Rows(iCont).Cells("M_TRFSRG").Value
            oServicio.pCMNDGU_MonedaGuia = .Rows(iCont).Cells("M_CMNTRN").Value
            oServicio.pISRVGU_importeServicio = .Rows(iCont).Cells("M_ITRSRT").Value
            oServicio.pQCNDTG_CantServicioGuia = .Rows(iCont).Cells("M_QMRCDR").Value
            oServicio.pCUNDSR_Unidad = .Rows(iCont).Cells("M_CUNDMD").Value
                        If "" & .Rows(iCont).Cells("M_SFCTTR").Value & "" = "S" Then
                            oServicio.pSFCTTR_StatusFacturado = "X"
                        Else
                            oServicio.pSFCTTR_StatusFacturado = ""
                        End If
            oServicio.pMMCUSR_Usuario = sUsuario
            oServicio.pNTRMNL_Terminal = sTerminal
            oServicio.pCCMPN_Compania = sCompania
            ' Realizamos el registro
            sMensajeError = ""
            If Not Objeto_Logica.Agregar_GRemServCargadasGTranspLiq(oServicio, sMensajeError) Then
              MessageBox.Show("Error en el proceso de Liquidación de Servicio." & vbNewLine & vbNewLine & sMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
          End If
          iCont += 1
        End While
      End With
    End If
    Me.Close()
  End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnEliminarServLiqu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarServLiqu.Click
        If dgServiciosPorDefecto.RowCount <= 0 Then
            MessageBox.Show("No existe información de algún servicio.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If MessageBox.Show("¿Desea eliminar el registro?", "Mensaje:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        dgServiciosPorDefecto.Rows.Remove(dgServiciosPorDefecto.CurrentRow)
    End Sub

    Private Sub btnModificarServLiqu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarServLiqu.Click
        If dgServiciosPorDefecto.RowCount <= 0 Then
            MessageBox.Show("No existe información.", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim oInfServ As TD_Obj_GRemAgregarServCargadasGTranspLiq = New TD_Obj_GRemAgregarServCargadasGTranspLiq
        With oInfServ
            .pNOPRCN_NroOperacion = nOperacion
            .pNGUITR_NroGuiaRemision = nNroGuiaTransportista
            .pNCRRGU_CorrServ = 0
            .pCSRVC_Servicio = dgServiciosPorDefecto.CurrentRow.Cells("M_CSRCTZ").Value
            .pTRFSRG_RefrenciaServicioGuia = dgServiciosPorDefecto.CurrentRow.Cells("M_TRFSRG").Value
            .pCMNDGU_MonedaGuia = dgServiciosPorDefecto.CurrentRow.Cells("M_CMNTRN").Value
            .pISRVGU_importeServicio = dgServiciosPorDefecto.CurrentRow.Cells("M_ITRSRT").Value
            .pQCNDTG_CantServicioGuia = dgServiciosPorDefecto.CurrentRow.Cells("M_QMRCDR").Value
            .pCUNDSR_Unidad = dgServiciosPorDefecto.CurrentRow.Cells("M_CUNDMD").Value
            If dgServiciosPorDefecto.CurrentRow.Cells("M_SFCTTR").Value = "S" Then
                .pSFCTTR_StatusFacturado = "X"
            End If

            .pMMCUSR_Usuario = MainModule.USUARIO
            .pNTRMNL_Terminal = Ransa.Utilitario.HelpClass.NombreMaquina
        End With
        Dim fTemp As frmLiquidacionFlete_DlgAgregarServ = New frmLiquidacionFlete_DlgAgregarServ(sCompania, sDivision, oInfServ)
        If fTemp.ShowDialog = Windows.Forms.DialogResult.OK Then
            oInfServ = fTemp.pInformacionServicio
            With dgServiciosPorDefecto.CurrentRow
                .Cells("M_CSRCTZ").Value = oInfServ.pCSRVC_Servicio
                .Cells("M_TCMTRF").Value = fTemp.pDetalleServicio
                .Cells("M_TRFSRG").Value = oInfServ.pTRFSRG_RefrenciaServicioGuia
                .Cells("M_CMNTRN").Value = oInfServ.pCMNDGU_MonedaGuia
                .Cells("M_ITRSRT").Value = oInfServ.pISRVGU_importeServicio
                .Cells("M_QMRCDR").Value = oInfServ.pQCNDTG_CantServicioGuia
                .Cells("M_CUNDMD").Value = oInfServ.pCUNDSR_Unidad
                If oInfServ.pSFCTTR_StatusFacturado <> "" Then
                    .Cells("M_SFCTTR").Value = "S"
                Else
                    .Cells("M_SFCTTR").Value = ""
                End If

            End With
        End If
        fTemp.Dispose()
        fTemp = Nothing
    End Sub

    Private Sub dgServiciosPorDefecto_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgServiciosPorDefecto.CellContentClick
        With dgServiciosPorDefecto
            Select Case .Columns(e.ColumnIndex).Name
                Case "M_CHKBOX"
                    If .CurrentRow.Cells(e.ColumnIndex).Value = "S" And .CurrentRow.Cells("M_SSRVFE").Value <> "F" Then
                        .CurrentRow.Cells(e.ColumnIndex).Value = "N"
                    Else
                        .CurrentRow.Cells(e.ColumnIndex).Value = "S"
                    End If
                Case "M_SFCTTR"
                    If .CurrentRow.Cells(e.ColumnIndex).Value = "S" Then
                        .CurrentRow.Cells(e.ColumnIndex).Value = "N"
                    Else
                        .CurrentRow.Cells(e.ColumnIndex).Value = "S"
                    End If
            End Select
        End With
    End Sub
#End Region
End Class