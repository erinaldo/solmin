Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TYPEDEF.Waybill
Imports RANSA.DATA.slnSOLMIN_SAT.DAO.WayBill

Public Class ucWaybill_PreDespacho
#Region " Atributos "
    ' Manejador de la Conexión
    Private objSqlManager As SqlManager
    Private strLugarEntregaAnt As String = ""
    Private blnAceptoLgDistinto As Boolean = False
    Private blnAceptoPaletizado As Boolean = False
    Private decCantidadBulto As Decimal = 0
    Private lstTD_BultoSelec As List(Of TD_Sel_Bulto_L01)
    Private intCCLNT As Int64 = 0
#End Region
#Region " Propiedades "
    Public WriteOnly Property pCCLNT_CodigoCliente() As Int64
        Set(ByVal value As Int64)
            intCCLNT = value
        End Set
    End Property

    Public ReadOnly Property pCTRLTE_CriterioLote() As String
        Get
            Return txtCriterioLote.Text
        End Get
    End Property

    Public ReadOnly Property pListaBultos() As List(Of TD_Sel_Bulto_L01)
        Get
            Return lstTD_BultoSelec
        End Get
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Function fblnBuscar(ByVal strBulto As String) As Boolean
        Dim objBultoSelec As TD_Sel_Bulto_L01 = New TD_Sel_Bulto_L01
        Dim blnResultado As Boolean = False
        For Each objBultoSelec In lstTD_BultoSelec
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
        For Each objBultoSelec In lstTD_BultoSelec
            If objBultoSelec.pCREFFW_CodigoBulto = strBulto Then
                ' Actualizamos los consolidados
                txtNroBultos.Text = dgBultosSeleccionados.RowCount
                decCantidadBulto -= objBultoSelec.pQREFFW_CantidadRecibida
                txtCantidadBultos.Text = decCantidadBulto
                lstTD_BultoSelec.Remove(objBultoSelec)
                blnResultado = True
                Exit For
            End If
        Next
        Return blnResultado
    End Function
#End Region
#Region " Métodos "
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

    Private Sub ucWaybill_DgF01_PDesp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objSqlManager = New SqlManager()
        lstTD_BultoSelec = New List(Of TD_Sel_Bulto_L01)
    End Sub

    Private Sub txtBulto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBulto.KeyDown
        If e.KeyCode = Keys.Enter And txtBulto.Text.Trim <> "" Then
            Dim strMensajeError As String = ""
            If fblnBuscar(txtBulto.Text) Then
                MessageBox.Show("Bulto ya fue registrado", "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim objBultoInf As TD_Inf_Bulto_L01 = daoWayBill.fobjObtener_Inf_Bulto_L01(objSqlManager, intCCLNT, txtBulto.Text.Trim, strMensajeError)

            If objBultoInf.pNOCURR_NroOcurrencia = 0 Then
                MessageBox.Show("Bulto no existe, ó existe un Error en la Información.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If objBultoInf.pNOCURR_NroOcurrencia <> 1 Then
                MessageBox.Show("Bulto tiene mas de un Lugar de Destino", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

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
            End With
            Dim objBultoSelec As TD_Sel_Bulto_L01 = New TD_Sel_Bulto_L01
            With objBultoSelec
                .pCCLNT_CodigoCliente = intCCLNT
                .pCREFFW_CodigoBulto = objBultoInf.pCREFFW_CodigoBulto
                .pQREFFW_CantidadRecibida = objBultoInf.pQREFFW_CantidadRecibida
                .pNROPLT_NroPaletizado = objBultoInf.pNROPLT_NroPaletizado
            End With
            lstTD_BultoSelec.Add(objBultoSelec)
            ' Actualizamos los consolidados
            txtNroBultos.Text = dgBultosSeleccionados.RowCount
            decCantidadBulto += objBultoInf.pQREFFW_CantidadRecibida
            txtCantidadBultos.Text = decCantidadBulto
            txtBulto.Text = ""
        End If
    End Sub
#End Region
End Class
