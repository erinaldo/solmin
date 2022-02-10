Imports Db2Manager.RansaData.iSeries.DataObjects
Imports RANSA.TypeDef.Servicios.Almacenaje
Imports RANSA.DAO.Servicios.Almacenaje

Public Class ucItemAlmacenaje_DgF01
#Region " Definición Eventos "
    ' Mensaje
    Public Event ErrorMessage(ByVal Mensaje As String)
    Public Event Message(ByVal Mensaje As String)
    Public Event Confirm(ByVal Pregunta As String, ByRef blnCancelar As Boolean)
    Public Event EndProcessAdd()
    Public Event EndProcessDelete()
    ' Eventos a Procesar
    Public Event Agregar()
    ' Eventos a Informar
    Public Event DataLoadCompleted(ByVal ItemAlmacenaje As TD_Inf_LstItemAlmacenaje_L01)
    Public Event TableWithOutData()
    Public Event CurrentRowChanged(ByVal ItemAlmacenaje As TD_Inf_LstItemAlmacenaje_L01)
#End Region
#Region " Tipo "

#End Region
#Region " Atributos "
    '-------------------------------------------------
    ' Manejador de la Conexión
    '-------------------------------------------------
    Private oItemAlmacenaje As cItemAlmacenaje = New Ransa.DAO.Servicios.Almacenaje.cItemAlmacenaje
    '-------------------------------------------------
    ' Almacenamiento de Información
    '-------------------------------------------------
    Private oQry_LstItemAlmacenaje_L01 As TD_Qry_LstItemAlmacenaje_L01 = New Ransa.TypeDef.Servicios.Almacenaje.TD_Qry_LstItemAlmacenaje_L01
    Private oInf_LstItemAlmacenaje_L01 As TD_Inf_LstItemAlmacenaje_L01 = New Ransa.TypeDef.Servicios.Almacenaje.TD_Inf_LstItemAlmacenaje_L01
    '-------------------------------------------------
    ' Información del Estado
    '-------------------------------------------------
    Private intFilaActual As Int32 = 0
    Private blnCargando As Boolean = False
    '-------------------------------------------------
    ' Datos de Seguridad 
    '-------------------------------------------------
#End Region
#Region " Propiedades "
    Public Property BackGround() As Color
        Get
            Return dgItemAlmacenaje.StateCommon.Background.Color1
        End Get
        Set(ByVal value As Color)
            dgItemAlmacenaje.StateCommon.Background.Color1 = value
        End Set
    End Property
#End Region
#Region " Funciones y Procedimientos "
    Private Sub pCargarInformacion()
        If oQry_LstItemAlmacenaje_L01.pCCLNT_CodigoCliente <> 0 Then
            blnCargando = True
            dgItemAlmacenaje.DataSource = oItemAlmacenaje.Listar(oQry_LstItemAlmacenaje_L01)
            blnCargando = False
            If oItemAlmacenaje.ErrorMessage <> "" Then
                oInf_LstItemAlmacenaje_L01.pClear()
                RaiseEvent ErrorMessage(oItemAlmacenaje.ErrorMessage)
            Else
                ' Carga el Item y lanzo el evento respectivo
                If dgItemAlmacenaje.RowCount > 0 Then
                    With oInf_LstItemAlmacenaje_L01
                        .pCCLNT_CodigoCliente = oQry_LstItemAlmacenaje_L01.pCCLNT_CodigoCliente
                        .pNPRALM_NroOperacion = dgItemAlmacenaje.CurrentRow.Cells("M_NPRALM").Value
                        .pCREFFW_CodigoBulto = dgItemAlmacenaje.CurrentRow.Cells("M_CREFFW").Value
                    End With
                    intFilaActual = 0
                    RaiseEvent DataLoadCompleted(oInf_LstItemAlmacenaje_L01)
                Else
                    oInf_LstItemAlmacenaje_L01.pClear()
                    intFilaActual = -1
                    RaiseEvent TableWithOutData()
                End If
            End If
        Else
            Call pLimpiarContenido()
        End If
    End Sub

    Private Sub pLimpiarContenido()
        blnCargando = True
        dgItemAlmacenaje.DataSource = Nothing
        blnCargando = False
        ' Limpiamos el bulto Seleccionada
        oInf_LstItemAlmacenaje_L01.pClear()
        intFilaActual = -1
        RaiseEvent TableWithOutData()
    End Sub

    Private Sub pWaybills_Registrar()
        Dim oInf_AddItemAlmacenaje_L01 As TD_Inf_AddItemAlmacenaje_L01 = New TD_Inf_AddItemAlmacenaje_L01
        With oInf_AddItemAlmacenaje_L01
            .pCCLNT_CodigoCliente = oQry_LstItemAlmacenaje_L01.pCCLNT_CodigoCliente
            .pNPRALM_NroOperacion = oQry_LstItemAlmacenaje_L01.pNPRALM_NroOperacion
            .pUsuario = oQry_LstItemAlmacenaje_L01.pUsuario
            Select Case Mid(cbxTipoCodigo.Text, 1, 1)
                Case "B"
                    .pCREFFW_CodigoBulto = txtCodigo.Text
                Case "P"
                    Dim intTemp As Int64 = 0
                    If Not Int64.TryParse(txtCodigo.Text, intTemp) Then
                        RaiseEvent ErrorMessage("Debe ingresar un Nro. de Paleta válido.")
                        txtCodigo.SelectAll()
                        Exit Sub
                    Else
                        .pNROPLT_NroPaletizado = intTemp
                    End If
                Case "D"
                    Dim intTemp As Int64 = 0
                    If Not Int64.TryParse(txtCodigo.Text, intTemp) Then
                        RaiseEvent ErrorMessage("Debe ingresar un Nro. de Pre-Despacho.")
                        txtCodigo.SelectAll()
                        Exit Sub
                    Else
                        .pNROCTL_NroPreDespacho = intTemp
                    End If
                Case "S"
                    Dim intTemp As Int64 = 0
                    If Not Int64.TryParse(txtCodigo.Text, intTemp) Then
                        RaiseEvent ErrorMessage("Debe ingresar un Nro. de Pre-Despacho.")
                        txtCodigo.SelectAll()
                        Exit Sub
                    Else
                        .pNRGUSA_NroGuiaSalida = intTemp
                    End If
                Case "G"
                    Dim intTemp As Int64 = 0
                    If Not Int64.TryParse(txtCodigo.Text, intTemp) Then
                        RaiseEvent ErrorMessage("Debe ingresar un Nro. de Guía de Remisión válido.")
                        txtCodigo.SelectAll()
                        Exit Sub
                    Else
                        .pNGUIRM_NroGuiaRemision = intTemp
                    End If
            End Select
            If Not oItemAlmacenaje.Add(oInf_AddItemAlmacenaje_L01) Then
                RaiseEvent ErrorMessage(oItemAlmacenaje.ErrorMessage)
            Else
                Call pCargarInformacion()
                RaiseEvent EndProcessAdd()
            End If
            txtCodigo.SelectAll()
        End With
    End Sub
#End Region
#Region " Eventos "
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If oQry_LstItemAlmacenaje_L01.pCCLNT_CodigoCliente = 0 Then Exit Sub
        If cbxTipoCodigo.Text <> "" And txtCodigo.Text <> "" Then Call pWaybills_Registrar()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If dgItemAlmacenaje.RowCount <= 0 Then Exit Sub
        Dim blnConfirm As Boolean = False
        RaiseEvent Confirm("Desea eliminar el Bulto.", blnConfirm)
        If blnConfirm Then Exit Sub

        Dim oInf_DeleteItemAlmacenaje_L01 As TD_Inf_DeleteItemAlmacenaje_L01 = New TD_Inf_DeleteItemAlmacenaje_L01
        With oInf_DeleteItemAlmacenaje_L01
            .pCCLNT_CodigoCliente = oQry_LstItemAlmacenaje_L01.pCCLNT_CodigoCliente
            .pNPRALM_NroOperacion = dgItemAlmacenaje.CurrentRow.Cells("M_NPRALM").Value
            .pCREFFW_CodigoBulto = dgItemAlmacenaje.CurrentRow.Cells("M_CREFFW").Value
            .pUsuario = oQry_LstItemAlmacenaje_L01.pUsuario
        End With
        If oItemAlmacenaje.Delete(oInf_DeleteItemAlmacenaje_L01) Then
            dgItemAlmacenaje.Rows.Remove(dgItemAlmacenaje.CurrentRow)
            RaiseEvent Message("Proceso culminó satisfactoriamente.")
            RaiseEvent EndProcessDelete()
        Else
            RaiseEvent ErrorMessage(oItemAlmacenaje.ErrorMessage)
        End If
    End Sub

    Private Sub ucItemAlmacenaje_DgF01_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        oItemAlmacenaje.Dispose()
        oItemAlmacenaje = Nothing
    End Sub

    Private Sub dgItemAlmacenaje_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgItemAlmacenaje.CurrentCellChanged
        If blnCargando Then Exit Sub
        If dgItemAlmacenaje.CurrentCell Is Nothing Then
            intFilaActual = -1
            oInf_LstItemAlmacenaje_L01.pClear()
        Else
            If dgItemAlmacenaje.CurrentCell.RowIndex <> intFilaActual Then
                intFilaActual = dgItemAlmacenaje.CurrentCell.RowIndex
                With oInf_LstItemAlmacenaje_L01
                    .pCCLNT_CodigoCliente = oQry_LstItemAlmacenaje_L01.pCCLNT_CodigoCliente
                    .pNPRALM_NroOperacion = dgItemAlmacenaje.CurrentRow.Cells("M_NPRALM").Value
                    .pCREFFW_CodigoBulto = dgItemAlmacenaje.CurrentRow.Cells("M_NPRALM").Value
                End With
                RaiseEvent CurrentRowChanged(oInf_LstItemAlmacenaje_L01)
            End If
        End If
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        If oQry_LstItemAlmacenaje_L01.pCCLNT_CodigoCliente = 0 Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            If cbxTipoCodigo.Text <> "" And txtCodigo.Text <> "" Then Call pWaybills_Registrar()
        End If
    End Sub
#End Region
#Region " Métodos "
    Public Sub pActualizar(ByVal Filtro As TD_Qry_LstItemAlmacenaje_L01)
        ' Seteamos los valores que hasta ese momento se ha ingresado 
        With oQry_LstItemAlmacenaje_L01
            .pCCLNT_CodigoCliente = Filtro.pCCLNT_CodigoCliente
            .pNPRALM_NroOperacion = Filtro.pNPRALM_NroOperacion
            .pUsuario = Filtro.pUsuario
        End With
        ' Llamada al procedimiento de carga de información
        Call pCargarInformacion()
    End Sub

    Public Sub pRefrescar()
        ' Llamada al procedimiento de carga de información
        Call pCargarInformacion()
    End Sub

    Public Sub pClear()
        Call pLimpiarContenido()
    End Sub
#End Region
End Class