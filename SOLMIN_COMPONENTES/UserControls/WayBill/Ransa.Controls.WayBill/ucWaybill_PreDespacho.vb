Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TypeDef.Waybill
Imports RANSA.DAO.WayBill
'Dagnino
Public Class ucWaybill_PreDespacho
#Region " Definición Eventos "
    '-------------------------------------------------
    ' Eventos a Informar
    '-------------------------------------------------
    Public Event pDisposeForm(ByVal bStatusProceso As Boolean)
#End Region
#Region " Tipo "

#End Region
#Region " Atributos "
    '-------------------------------------------------
    ' Manejador de la Conexión
    '-------------------------------------------------
    Private objSqlManager As SqlManager
    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    Private strLugarEntregaAnt As String = ""
    Private blnAceptoLgDistinto As Boolean = False
    Private blnAceptoPaletizado As Boolean = False
    Private decCantidadBulto As Decimal = 0
    Private lstBultos As List(Of TD_Sel_Bulto_L01)
    Private Bulto As Ransa.TypeDef.WayBill.TD_Qry_Bulto_L01
    Private pUsuario As String = ""
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------
    Private bStatusOperacion As Boolean = False
    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
#End Region
#Region " Propiedades "
    
#End Region
#Region " Funciones y Procedimientos "
    Private Function fblnBuscar(ByVal strBulto As String) As Boolean
        Dim objBultoSelec As TD_Sel_Bulto_L01 = New TD_Sel_Bulto_L01
        Dim blnResultado As Boolean = False
        For Each objBultoSelec In lstBultos
            If objBultoSelec.pCREFFW_CodigoBulto = strBulto Then
                blnResultado = True
                Exit For
            End If
        Next
        Return blnResultado
    End Function

    Private Function fblnEliminar(ByVal strBulto As String) As Boolean
        Dim objBultoSelec As TD_Sel_Bulto_L01 = New TD_Sel_Bulto_L01
        Dim blnResultado As Boolean = False
        For Each objBultoSelec In lstBultos
            If objBultoSelec.pCREFFW_CodigoBulto = strBulto Then
                ' Actualizamos los consolidados
                txtNroBultos.Text = dgBultosSeleccionados.RowCount
                decCantidadBulto -= objBultoSelec.pQREFFW_CantidadRecibida
                txtCantidadBultos.Text = decCantidadBulto
                lstBultos.Remove(objBultoSelec)
                blnResultado = True
                Exit For
            End If
        Next
        Return blnResultado
    End Function
#End Region
#Region " Métodos "
    Sub New(ByVal Filtro As Ransa.TypeDef.WayBill.TD_Qry_Bulto_L01, ByVal Usuario As String)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Bulto = Filtro
        pUsuario = Usuario
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        If (lstBultos.Count > 0) Then
            ' Rutina para registrar el PreDespacho y sus respectivos Waybills
            Dim oWayBill As cWayBill = New cWayBill()
            Dim sMessage As String = ""
            Dim nroPredespacho As String = String.Empty
            If fblnRegistrarBultosAlPreDespacho(oWayBill, lstBultos, txtCriterioLote.Text.Trim, pUsuario, sMessage, nroPredespacho) Then
                MessageBox.Show(sMessage, "Pre-Despacho:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                bStatusOperacion = True
                Me.Close()
            Else
                MessageBox.Show(sMessage, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            oWayBill.Dispose()
            oWayBill = Nothing
        Else
            MessageBox.Show("Debe de ingresar los bultos", "Pre-Despacho", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
      
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        bStatusOperacion = False
        Me.Close()
    End Sub

    Private Sub dgBultosSeleccionados_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgBultosSeleccionados.KeyDown
        If e.KeyCode = Keys.Delete And dgBultosSeleccionados.Rows.Count > 0 Then
            If MessageBox.Show("¿Desea eliminar el registro actual?", "Eliminar:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If fblnEliminar(dgBultosSeleccionados.CurrentRow.Cells("M_CREFFW").Value) Then
                    dgBultosSeleccionados.Rows.Remove(dgBultosSeleccionados.CurrentRow)
                Else
                    MessageBox.Show("Error, no se pudo borrar el registro. " & vbNewLine & "Cancele el proceso.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                e.SuppressKeyPress = True
            End If
        End If
    End Sub

    Private Sub ucWaybill_PreDespacho_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        RaiseEvent pDisposeForm(bStatusOperacion)
    End Sub

    Private Sub ucWaybill_DgF01_PDesp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objSqlManager = New SqlManager()
        lstBultos = New List(Of TD_Sel_Bulto_L01)
    End Sub

   
    Private Sub txtBulto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBulto.KeyDown
        If e.KeyCode = Keys.Enter And txtBulto.Text.Trim <> "" Then

            Dim strMensajeError As String = ""
            Bulto.pCREFFW_CodigoBulto = txtBulto.Text.Trim
            If fblnBuscar(txtBulto.Text.Trim) Then
                MessageBox.Show("Bulto ya fue registrado", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim objBultoInf As TD_Inf_Bulto_L01 = cWayBill.fobjObtener_Inf_Bulto_L01(objSqlManager, Bulto, strMensajeError)
            Dim oList As New List(Of TD_Inf_Bulto_L01)
            'oList = cWayBill.fobjObtener_Inf_Bulto_PendientePreDespacho(objSqlManager, Bulto, strMensajeError)


            If objBultoInf.pNOCURR_NroOcurrencia = 0 Then
                MessageBox.Show("Bulto no existe, ó existe un Error en la Información.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If objBultoInf.pNOCURR_NroOcurrencia <> 1 Then
                MessageBox.Show("Bulto tiene más de un Lugar de Destino", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            '------------------------------

            If strLugarEntregaAnt = "" Then strLugarEntregaAnt = objBultoInf.pTLUGEN_LugarEntrega

            If Not blnAceptoLgDistinto And strLugarEntregaAnt <> objBultoInf.pTLUGEN_LugarEntrega Then
                If MessageBox.Show("Destino del Bulto a ingresar no coincide con los Destinos de los Items " & vbNewLine & _
                                   "Seleccionados hasta el momento." & vbNewLine & vbNewLine & _
                                   "Destino del Bulto : " & objBultoInf.pTLUGEN_LugarEntrega & vbNewLine & vbNewLine & _
                                   "¿Desea permitir distintos destinos?.", "Mensaje:", MessageBoxButtons.YesNo, _
                                   MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    blnAceptoLgDistinto = True
                Else
                    Exit Sub
                End If
            End If
            If Not blnAceptoPaletizado And objBultoInf.pNROPLT_NroPaletizado <> 0 Then
                If MessageBox.Show("El Bulto a ingresar contiene un Nro de Paletizado que puede" & vbNewLine & _
                                   "estar asociada a más de un Bulto." & vbNewLine & vbNewLine & _
                                   "Nro de Paletizado : " & objBultoInf.pNROPLT_NroPaletizado & vbNewLine & vbNewLine & _
                                   "¿Desea incluir toda la Paleta?.", "Mensaje:", MessageBoxButtons.YesNo, _
                                   MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    blnAceptoPaletizado = True
                Else
                    Exit Sub
                End If
            End If
            Dim objBultoSelecc As TD_Sel_Bulto_L01 = New TD_Sel_Bulto_L01
            ' Registramos una nueva fila
            With dgBultosSeleccionados
                .Rows.Add()
                .Rows(.RowCount - 1).Cells("M_CREFFW").Value = objBultoInf.pCREFFW_CodigoBulto
                .Rows(.RowCount - 1).Cells("M_QREFFW").Value = objBultoInf.pQREFFW_CantidadRecibida
                .Rows(.RowCount - 1).Cells("M_TLUGEN").Value = objBultoInf.pTLUGEN_LugarEntrega
                .Rows(.RowCount - 1).Cells("M_NROPLT").Value = objBultoInf.pNROPLT_NroPaletizado
                .Rows(.RowCount - 1).Cells("M_NSEQIN").Value = objBultoInf.pNSEQIN_NrSecuencia

            End With
            Dim objBultoSelec As TD_Sel_Bulto_L01 = New TD_Sel_Bulto_L01
            With objBultoSelec
                .pCCMPN_Compania = Bulto.pCCMPN_CodigoCompania
                .pCDVSN_Division = Bulto.pCDVSN_CodigoDivision
                .pCPLNDV_Planta = Bulto.pCPLNDV_CodigoPlanta
                .pCCLNT_CodigoCliente = Bulto.pCCLNT_CodigoCliente
                .pCREFFW_CodigoBulto = objBultoInf.pCREFFW_CodigoBulto
                .pQREFFW_CantidadRecibida = objBultoInf.pQREFFW_CantidadRecibida
                .pNROPLT_NroPaletizado = objBultoInf.pNROPLT_NroPaletizado
                .pNSEQIN_NrSecuencia = objBultoInf.pNSEQIN_NrSecuencia
            End With
            lstBultos.Add(objBultoSelec)
            ' Actualizamos los consolidados
            txtNroBultos.Text = dgBultosSeleccionados.RowCount
            decCantidadBulto += objBultoInf.pQREFFW_CantidadRecibida
            txtCantidadBultos.Text = decCantidadBulto
            txtBulto.Text = ""
        End If
    End Sub
#End Region

    'Private Sub txtCriterioLote_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCriterioLote.KeyDown
    '    Try

    '        If e.KeyCode = Keys.Enter And txtCriterioLote.Text.Trim <> "" Then

    '            Dim strMensajeError As String = ""
    '            Bulto.pCREFFW_CodigoBulto = ""
    '            Bulto.pCRTLTE_CriterioLote = txtCriterioLote.Text.ToUpper



    '            Dim objBultoInf As New List(Of TD_Inf_Bulto_L01)
    '            objBultoInf = cWayBill.fobjObtener_Inf_Bulto_PendientePreDespacho(objSqlManager, Bulto, strMensajeError)

    '            If objBultoInf.Count = 0 Then
    '                MessageBox.Show("Bultos con criterio no existente.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                Exit Sub
    '            End If



    '            If objBultoInf(0).pNOCURR_NroOcurrencia > 1 Then
    '                If MessageBox.Show("Bultos tienen más de un Lugar de Destino." & Chr(13) & "¿Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
    '                    Exit Sub
    '                End If
    '            End If

    '            '------------------------------

    '            If strLugarEntregaAnt = "" Then strLugarEntregaAnt = objBultoInf(0).pTLUGEN_LugarEntrega

    '            If Not blnAceptoLgDistinto And strLugarEntregaAnt <> objBultoInf(0).pTLUGEN_LugarEntrega Then
    '                If MessageBox.Show("Destino del Bulto a ingresar no coincide con los Destinos de los Items " & vbNewLine & _
    '                                   "Seleccionados hasta el momento." & vbNewLine & vbNewLine & _
    '                                   "Destino del Bulto : " & objBultoInf(0).pTLUGEN_LugarEntrega & vbNewLine & vbNewLine & _
    '                                   "¿Desea permitir distintos destinos?.", "Mensaje:", MessageBoxButtons.YesNo, _
    '                                   MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
    '                    blnAceptoLgDistinto = True
    '                Else
    '                    Exit Sub
    '                End If
    '            End If
    '            If Not blnAceptoPaletizado And objBultoInf(0).pNROPLT_NroPaletizado <> 0 Then
    '                If MessageBox.Show("El Bulto a ingresar contiene un Nro de Paletizado que puede" & vbNewLine & _
    '                                   "estar asociada a más de un Bulto." & vbNewLine & vbNewLine & _
    '                                   "Nro de Paletizado : " & objBultoInf(0).pNROPLT_NroPaletizado & vbNewLine & vbNewLine & _
    '                                   "¿Desea incluir toda la Paleta?.", "Mensaje:", MessageBoxButtons.YesNo, _
    '                                   MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
    '                    blnAceptoPaletizado = True
    '                Else
    '                    Exit Sub
    '                End If
    '            End If

    '            Dim objBultoSelec As TD_Sel_Bulto_L01
    '            Dim qBultos As Decimal = 0

    '            For Each item As TD_Inf_Bulto_L01 In objBultoInf
    '                If Not fblnBuscar(item.pCREFFW_CodigoBulto) Then


    '                    With dgBultosSeleccionados
    '                        .Rows.Add()
    '                        .Rows(.RowCount - 1).Cells("M_CREFFW").Value = item.pCREFFW_CodigoBulto
    '                        .Rows(.RowCount - 1).Cells("M_QREFFW").Value = item.pQREFFW_CantidadRecibida
    '                        .Rows(.RowCount - 1).Cells("M_TLUGEN").Value = item.pTLUGEN_LugarEntrega
    '                        .Rows(.RowCount - 1).Cells("M_NROPLT").Value = item.pNROPLT_NroPaletizado
    '                        .Rows(.RowCount - 1).Cells("M_NSEQIN").Value = item.pNSEQIN_NrSecuencia

    '                    End With

    '                    qBultos = qBultos + item.pQREFFW_CantidadRecibida

    '                    objBultoSelec = New TD_Sel_Bulto_L01
    '                    With objBultoSelec
    '                        .pCCMPN_Compania = Bulto.pCCMPN_CodigoCompania
    '                        .pCDVSN_Division = Bulto.pCDVSN_CodigoDivision
    '                        .pCPLNDV_Planta = Bulto.pCPLNDV_CodigoPlanta
    '                        .pCCLNT_CodigoCliente = Bulto.pCCLNT_CodigoCliente
    '                        .pCREFFW_CodigoBulto = item.pCREFFW_CodigoBulto
    '                        .pQREFFW_CantidadRecibida = item.pQREFFW_CantidadRecibida
    '                        .pNROPLT_NroPaletizado = item.pNROPLT_NroPaletizado
    '                        .pNSEQIN_NrSecuencia = item.pNSEQIN_NrSecuencia
    '                    End With
    '                    lstBultos.Add(objBultoSelec)


    '                End If
    '            Next


    '            ' Actualizamos los consolidados
    '            txtNroBultos.Text = dgBultosSeleccionados.Rows.Count
    '            decCantidadBulto += qBultos
    '            txtCantidadBultos.Text = decCantidadBulto
    '            txtCriterioLote.Text = ""
    '            'txtBulto.Text = ""
    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub
End Class