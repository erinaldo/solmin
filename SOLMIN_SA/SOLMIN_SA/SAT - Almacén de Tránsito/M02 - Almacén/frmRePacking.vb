Imports RANSA.Utilitario
Imports System.Data
Imports RANSA.NEGO
Imports RANSA.NEGO.slnSOLMIN_SAT.Almacen
Imports Ransa.TypeDef

Public Class frmRePacking
#Region "Atributos"
    Private intCCLNT As Integer = 0
    Private strCREFFW As String = ""
    Private strCCMPN As String = ""
    Private strCDVSN As String = ""
    Private dblCPLNDV As Double = 0
    Private dblNSEQIN As Double = 0
    Private strNrBultoInicial As String = ""
    Dim objInfRepacking As clsInfRepacking = Nothing
#End Region
#Region "Propiedades"
    Public Property pCodigoCliente_CCLNT() As Int32
        Get
            pCodigoCliente_CCLNT = intCCLNT
        End Get
        Set(ByVal value As Int32)
            intCCLNT = value
        End Set
    End Property

    Public Property pCodigoRecepcion_CREFFW() As String
        Get
            pCodigoRecepcion_CREFFW = strCREFFW
        End Get
        Set(ByVal value As String)
            strCREFFW = value
        End Set
    End Property


    Public Property pCodigoCompania_CCMPN() As String
        Get
            pCodigoCompania_CCMPN = strCCMPN
        End Get
        Set(ByVal value As String)
            strCCMPN = value
        End Set
    End Property


    Public Property pCodigoDivision_CDVSN() As String
        Get
            pCodigoDivision_CDVSN = strCDVSN
        End Get
        Set(ByVal value As String)
            strCDVSN = value
        End Set
    End Property


    Public Property pCodigoPlanta_CPLNDV() As Double
        Get
            pCodigoPlanta_CPLNDV = dblCPLNDV
        End Get
        Set(ByVal value As Double)
            dblCPLNDV = value
        End Set
    End Property

    Public WriteOnly Property pNrCorrelativo_NSEQIN() As String
        Set(ByVal value As String)
            dblNSEQIN = value
        End Set
    End Property

#End Region
#Region "Procedimientos y Funciones"
    Private Sub pMostrarInfBultoOrigen()
        If Not mfblnObtener_InfRepacking(intCCLNT, strCREFFW, objInfRepacking, pCodigoCompania_CCMPN, pCodigoDivision_CDVSN, pCodigoPlanta_CPLNDV) Then Me.Close()
        With objInfRepacking
            txtCodigoRecepcionOrigen.Text = .pstrCodigoRecepcion_CREFFW
            txtFechaRecepcionOrigen.Text = .pstrFechaRecepcionAlmacen_FFec_FREFFW
            txtCantidadRecibidaOrigen.Text = .pdecCantidadRecibida_QREFFW
            txtTipoBultoOrigen.Text = .pstrTipoBulto_TIPBTO
            txtPesoBultoOrigen.Text = .pdecPesoBulto_QPSOBL
            txtUnidadBultoOrigen.Text = .pstrUnidadPeso_TUNPSO
            txtVolumenBultoOrigen.Text = .pdecVolumenBulto_QVLBTO
            txtUnidadVolumenOrigen.Text = .pstrUnidadVolumen_TUNVOL
            txtCantidadAreaOcupadaOrigen.Text = .pdecCantidadAreaOcupada_QAROCP
            txtUbicacionReferencialOrigen.Text = .pstrUbicacionReferencial_TUBRFR
            txtDescripcionWaybillOrigen.Text = .pstrDescripcionWayBill_DESCWB
        End With
        ' Información del Nuevo Bulto
        Call pMostrarInfNuevoBulto()
    End Sub

    Private Sub pMostrarInfNuevoBulto()
        With objInfRepacking
            ' Atributos del Nuevo Bulto
            mfblnObtener_NroBulto(False, txtCodigoRecepcionNuevo.Text, intCCLNT, pCodigoCompania_CCMPN, pCodigoDivision_CDVSN, pCodigoPlanta_CPLNDV)
            strNrBultoInicial = txtCodigoRecepcionNuevo.Text
            txtFechaRecepcionNuevo.Text = .pstrFechaRecepcionAlmacen_FFec_FREFFW
            txtCantidadRecibidaNuevo.Text = .pdecCantidadRecibida_QREFFW
            txtTipoBultoNuevo.Text = ("" & .pstrTipoBulto_TIPBTO).Trim
            txtPesoBultoNuevo.Text = .pdecPesoBulto_QPSOBL
            txtUnidadBultoNuevo.Text = ("" & .pstrUnidadPeso_TUNPSO).Trim
            txtVolumenBultoNuevo.Text = .pdecVolumenBulto_QVLBTO
            txtUnidadVolumenNuevo.Text = ("" & .pstrUnidadVolumen_TUNVOL).Trim
            txtCantidadAreaOcupadaNuevo.Text = .pdecCantidadAreaOcupada_QAROCP
            txtUbicacionReferencialNuevo.Text = ("" & .pstrUbicacionReferencial_TUBRFR).Trim
            txtDescripcionWaybillNuevo.Text = ("" & .pstrDescripcionWayBill_DESCWB).Trim
            ' Listamos los items del Bulto
            Dim obrBulto As New brBulto
            Dim obeBulto As New beBulto
            With obeBulto
                .PNCCLNT = intCCLNT
                .PSCCMPN = strCCMPN
                .PSCDVSN = strCDVSN
                .PNCPLNDV = dblCPLNDV
                .PSCREFFW = strCREFFW
                .PNNSEQIN = dblNSEQIN
            End With
            dgItemsBultoNuevo.DataSource = obrBulto.dtItemsDeBulto(obeBulto)
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaBulto))
            For Each row As DataGridViewRow In dgItemsBultoNuevo.Rows
                Dim NRSITEM As Integer = row.Cells("NRSITEM").Value
                If NRSITEM > 0 Then
                    row.Cells("SUBITEM").Value = My.Resources.retencion
                End If
            Next
        End With
    End Sub


    Private Function pblnValidarInformacion() As Boolean
        Dim strMensajeError As String = ""
        Dim blnResultado = True
        Dim blnResultadorForEach As Boolean = False
        Dim blnResultadorDimension As Boolean = False
        Dim decTemp As Decimal = 0
        ' Código del Bulto
        If Me.txtCodigoRecepcionNuevo.Text = "" Then _
            strMensajeError &= "- No ha ingresado el Nro. de Bulto." & vbNewLine
        ' Tipo de Bulto
        If Me.txtTipoBultoNuevo.Text.Trim = "" Then _
            strMensajeError &= "- No se ha definido el Tipo de Bulto." & vbNewLine
        ' Cantidad de Bultos Recibidos
        If Not Decimal.TryParse(Me.txtCantidadRecibidaNuevo.Text, decTemp) Then _
            strMensajeError &= "- Debe ingresar un Nro. válido para la Cantidad de Bulto." & vbNewLine
        If decTemp <= 0 Then _
            strMensajeError &= "- Debe ingresar una Cantidad de Bulto MAYOR a Cero" & vbNewLine
        If decTemp > Me.objInfRepacking.pdecCantidadRecibida_QREFFW Then _
            strMensajeError &= "- Debe ingresar una Cantidad de Bulto MENOR O IGUAL a la Cantidad Origen." & vbNewLine
        ' Peso de Bulto
        If Not Decimal.TryParse(Me.txtPesoBultoNuevo.Text, decTemp) Then _
            strMensajeError &= "- Debe ingresar un Nro. válido para el Peso del Bulto." & vbNewLine
        If decTemp < 0 Then _
            strMensajeError &= "- Debe ingresar un Peso del Bulto MAYOR o IGUAL a Cero" & vbNewLine
        ' Volumen de Bulto
        If Not Decimal.TryParse(Me.txtVolumenBultoNuevo.Text, decTemp) Then _
            strMensajeError &= "- Debe ingresar un Nro. válido para el Volumen del Bulto." & vbNewLine
        If decTemp < 0 Then _
            strMensajeError &= "- Debe ingresar un Volumen del Bulto MAYOR o IGUAL a Cero" & vbNewLine
        ' Validación de la Modificación de los Items
        For Each rwTemp As DataGridViewRow In dgItemsBultoNuevo.Rows
            If rwTemp.Cells("R_QBLTRP").Value > 0 Then
                blnResultadorForEach = True
                Exit For
            End If
        Next
        If Not blnResultadorForEach Then _
            strMensajeError &= "- No se han modificado la Cantidad de RePacking en Ítems." & vbNewLine
        ' Mostramos el resultado Final de la Validación

        'validacion adicionada 2021
        If dtgPaquetesDeBulto.Rows.Count > 0 Then

            For Each rwTemp As DataGridViewRow In dtgPaquetesDeBulto.Rows
                If rwTemp.Cells("DIM_REPACKING").Value > 0 Then
                    blnResultadorDimension = True
                    Exit For
                End If
            Next
            If Not blnResultadorDimension Then _
            strMensajeError &= "- No se han modificado la Cantidad de RePacking en Dimensiones" & vbNewLine

        End If
      


        If strMensajeError <> "" Then
            MessageBox.Show(strMensajeError, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Information)
            blnResultado = False
        End If
        Return blnResultado
    End Function
#End Region
#Region "Métodos"
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        Try
            Dim obrBultoRepacking As New brBulto
            Dim obeBultoRepacking As New beBulto
            If dgItemsBultoNuevo.RowCount <= 0 Then Exit Sub
            ' Evaluamos el resultado de la Validación
            If Not pblnValidarInformacion() Then Exit Sub

            Dim objBultoRepacking As clsBultoRepacking = New clsBultoRepacking
            ' Cargamos los valores para el Nuevo Bulto

            ' Verificando la Codificación del Bulto
            Dim strCodigoBultoDefinitivo As String = ""
            If Not mfblnObtener_NroBulto(False, strCodigoBultoDefinitivo, intCCLNT, strCCMPN, strCDVSN, dblCPLNDV) Then Exit Sub
            If strCodigoBultoDefinitivo = txtCodigoRecepcionNuevo.Text.Trim Then
                If Not mfblnObtener_NroBulto(True, strCodigoBultoDefinitivo, intCCLNT, strCCMPN, strCDVSN, dblCPLNDV) Then Exit Sub
                If strCodigoBultoDefinitivo <> txtCodigoRecepcionNuevo.Text.Trim Then
                    MessageBox.Show("Se ha asignado un Nuevo Nro. de Bulto." & vbNewLine & _
                                    "Bulto No " & strCodigoBultoDefinitivo, _
                                    "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtCodigoRecepcionNuevo.Text = strCodigoBultoDefinitivo
                End If
            Else
                'Si cumple esta condicion el registro de codigo bulto es manual
                If strNrBultoInicial = txtCodigoRecepcionNuevo.Text Then
                    If Not mfblnObtener_NroBulto(True, strCodigoBultoDefinitivo, intCCLNT, strCCMPN, strCDVSN, dblCPLNDV) Then Exit Sub
                    If strCodigoBultoDefinitivo <> txtCodigoRecepcionNuevo.Text.Trim Then
                        MessageBox.Show("Se ha asignado un Nuevo Nro. de Bulto." & vbNewLine & _
                                        "Bulto No " & strCodigoBultoDefinitivo, _
                                        "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtCodigoRecepcionNuevo.Text = strCodigoBultoDefinitivo
                    End If
                Else
                    obeBultoRepacking.PSCREFFW = txtCodigoRecepcionNuevo.Text
                    'Verificamos que no exista el bulto
                    If obrBultoRepacking.floObjtenerBulto(obeBultoRepacking).PSCREFFW <> "" Then
                        MessageBox.Show("Error, el Nro. de Bulto :" & txtCodigoRecepcionNuevo.Text & " ya encuentra registrada", _
                                                                "Mensaje:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If
            End If

            ' Final de la Verificación de la codificación del Bulto


            With objBultoRepacking
                .pintCodigoCliente_CCLNT = objInfRepacking.pintCodigoCliente_CCLNT
                .pstrCodigoRecepcion_CREFFW = txtCodigoRecepcionNuevo.Text.Trim
                .pstrCodigoBultoOrigen_CBLTOR = txtCodigoRecepcionOrigen.Text.Trim
                .pdteFechaRecepcionAlmacen_FREFFW = objInfRepacking.pdteFechaRecepcionAlmacen_FREFFW
                Decimal.TryParse(txtCantidadRecibidaNuevo.Text, .pdecCantidadRecibida_QREFFW)
                .pstrTipoBulto_TIPBTO = txtTipoBultoNuevo.Text.Trim
                Decimal.TryParse(txtPesoBultoNuevo.Text, .pdecPesoBulto_QPSOBL)
                .pstrUnidadPeso_TUNPSO = txtUnidadBultoNuevo.Text.Trim
                Decimal.TryParse(txtVolumenBultoNuevo.Text, .pdecVolumenBulto_QVLBTO)
                .pstrUnidadVolumen_TUNVOL = txtUnidadVolumenNuevo.Text.Trim
                Decimal.TryParse(txtCantidadAreaOcupadaNuevo.Text, .pdecCantidadAreaOcupada_QAROCP)
                .pstrUbicacionReferencial_TUBRFR = txtUbicacionReferencialNuevo.Text.Trim
                .pstrDescripcionWayBill_DESCWB = txtDescripcionWaybillNuevo.Text.Trim
                .pstrCodigoCompania_CCMPN = pCodigoCompania_CCMPN
                .pstrCodigoDivision_CDVSN = pCodigoDivision_CDVSN
                .pdblCodigoPlanta_CPLNDV = pCodigoPlanta_CPLNDV
                .pdblCorrelativo_NSEQIN = dblNSEQIN

            End With
            ' Cargamos los Item del Nuevo Bulto
            For Each rwTemp As DataGridViewRow In dgItemsBultoNuevo.Rows
                If rwTemp.Cells("R_QBLTRP").Value > 0 Then
                    Dim objItemBultoRepacking As clsItemBultoRepacking = New clsItemBultoRepacking
                    With objItemBultoRepacking
                        .pstrCodigoIdentificacionPaquete_CIDPAQ = ("" & rwTemp.Cells("R_CIDPAQ").Value).ToString.Trim
                        .pstrNroOrdenCompra_NORCML = ("" & rwTemp.Cells("R_NORCML").Value).ToString.Trim
                        Int32.TryParse(("" & rwTemp.Cells("R_NRITOC").Value).ToString.Trim, .pintNroItemOrdenCompra_NRITOC)
                        Decimal.TryParse(("" & rwTemp.Cells("R_QBLTRP").Value).ToString.Trim, .pdecCantidadRepacking_QBLTRP)
                        .Observaciones_Item_Bulto_TDAITM = IIf(rwTemp.Cells("D_TDAITM").Value Is Nothing, "", rwTemp.Cells("D_TDAITM").Value)
                        .pstrCodigoCompania_CCMPN = pCodigoCompania_CCMPN
                        .pstrCodigoDivision_CDVSN = pCodigoDivision_CDVSN
                        .pdblCodigoPlanta_CPLNDV = pCodigoPlanta_CPLNDV
                        .pdblCorrelativo_NSEQIN = dblNSEQIN
                        objBultoRepacking.AddItemBultoRepacking(objItemBultoRepacking)
                    End With
                    ' Cargamos los SubItem

                    If pdt IsNot Nothing Then
                        For Each row As DataRow In pdt.Rows
                            If rwTemp.Cells("R_NRITOC").Value = row("NRITOC").ToString And _
                                row("QREPAC").ToString > 0 Then
                                Dim objSubItemBultoRepacking As clsSubItemBultoRepacking = New clsSubItemBultoRepacking
                                With objSubItemBultoRepacking
                                    .pstrCodigoIdentificacionPaquete_CIDPAQ = row("CIDPAQ").ToString.Trim
                                    .pstrNroOrdenCompra_NORCML = row("NORCML").ToString.Trim
                                    .pintNroItemOrdenCompra_NRITOC = row("NRITOC").ToString.Trim

                                    .pstrCodigoSubItem_SBITOC = row("SBITOC").ToString.Trim
                                    .pdecCantidadRepacking_QCNRCP = row("QREPAC").ToString.Trim
                                    .pstrCodigoCompania_CCMPN = pCodigoCompania_CCMPN
                                    .pstrCodigoDivision_CDVSN = pCodigoDivision_CDVSN
                                    .pdblCodigoPlanta_CPLNDV = pCodigoPlanta_CPLNDV
                                    objBultoRepacking.AddSubItemBultoRepacking(objSubItemBultoRepacking)
                                End With
                            End If
                        Next
                    End If
                End If
            Next
            ' Volvemos a cargar la información a visualizar
            Dim strError As String = ""
            Dim strBulto As String = ""
            strBulto = mfblnRegistrar_BultoRepacking(objBultoRepacking, strError)
            If strError.Trim.Length > 0 Then
                'HelpClass.ErrorMsgBox()
                MessageBox.Show(strError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If



            'Actualizamos el bulto padre
            obeBultoRepacking.PSCCMPN = pCodigoCompania_CCMPN
            obeBultoRepacking.PSCDVSN = pCodigoDivision_CDVSN
            obeBultoRepacking.PNNSEQIN = dblNSEQIN
            obeBultoRepacking.PNCPLNDV = pCodigoPlanta_CPLNDV
            obeBultoRepacking.PNCCLNT = pCodigoCliente_CCLNT
            obeBultoRepacking.PSCREFFW = pCodigoRecepcion_CREFFW
            obeBultoRepacking.PNQREFFW = Decimal.Parse(txtCantidadRecibidaOrigen.Text) - Decimal.Parse(txtCantidadRecibidaNuevo.Text)
            obeBultoRepacking.PNQPSOBL = Decimal.Parse(txtPesoBultoOrigen.Text) - Decimal.Parse(txtPesoBultoNuevo.Text)
            obeBultoRepacking.PNQVLBTO = Decimal.Parse(txtVolumenBultoOrigen.Text) - Decimal.Parse(txtVolumenBultoNuevo.Text)
            obeBultoRepacking.PNQAROCP = Decimal.Parse(txtCantidadAreaOcupadaOrigen.Text) - Decimal.Parse(txtCantidadAreaOcupadaNuevo.Text)
            obeBultoRepacking.PSUSUARIO = objSeguridadBN.pUsuario
            obrBultoRepacking.ActualizarBulto_Repaking_Origen(obeBultoRepacking)



            'NUEVA VALIDACION

            If dtgPaquetesDeBulto.Rows.Count > 0 Then
                Dim obrBulto As New brBulto
                Dim oPaq As beBulto
                Dim CantRepacking As Decimal = 0
                For Each item As DataGridViewRow In dtgPaquetesDeBulto.Rows

                    CantRepacking = Val("" & item.Cells("DIM_REPACKING").Value)
                    If CantRepacking > 0 Then
                        oPaq = New beBulto
                        oPaq.PSCCMPN = obeBultoRepacking.PSCCMPN.Trim
                        oPaq.PSCDVSN = obeBultoRepacking.PSCDVSN.Trim
                        oPaq.PNCPLNDV = obeBultoRepacking.PNCPLNDV
                        oPaq.PNCCLNT = obeBultoRepacking.PNCCLNT
                        oPaq.PSCREFFW = txtCodigoRecepcionNuevo.Text.Trim
                        oPaq.PNNSEQIN = dblNSEQIN
                        oPaq.PNNCRRINOR = item.Cells("PNNCRRIN").Value
                        oPaq.PSCBLTOR = txtCodigoRecepcionOrigen.Text.Trim                       
                        oPaq.PNQCTPQT = item.Cells("DIM_REPACKING").Value
                        oPaq.PNQMTLRG = item.Cells("PNQMTLRG").Value
                        oPaq.PNQMTALT = item.Cells("PNQMTALT").Value
                        oPaq.PNQMTANC = item.Cells("PNQMTANC").Value
                        oPaq.PNQVOLMR = item.Cells("PNQVOLMR").Value
                        oPaq.PNQPSOMR = item.Cells("PNQPSOMR").Value
                        oPaq.PSUSUARIO = objSeguridadBN.pUsuario
                        obrBulto.fintInsertarBultoDetalleCargaRepacking(oPaq)

                    End If

                Next
                
            End If
  
            '++++++++++++++++

            HelpClass.MsgBox("El Bulto fue registrado satisfactoriamente." & Chr(13) & "Código Bulto: " & strBulto)
            Me.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub
    Private Sub RestarItems()
        Try
            Dim txtCantidadRecibidaNuevoStr As New Integer
            Dim txtCantidadAreaOcupadaOrigenStr As New Decimal
            Dim txtPesoBultoNuevoStr As New Decimal
            Dim txtVolumenBultoNuevoStr As New Decimal

            txtCantidadRecibidaNuevoStr = (Integer.Parse(txtCantidadRecibidaOrigen.Text.Trim()) - Integer.Parse(txtCantidadRecibidaNuevo.Text.Trim())).ToString()
            txtCantidadAreaOcupadaOrigenStr = (Decimal.Parse(txtCantidadAreaOcupadaOrigen.Text.Trim()) - Decimal.Parse(txtCantidadAreaOcupadaNuevo.Text.Trim())).ToString()
            txtPesoBultoNuevoStr = (Decimal.Parse(txtPesoBultoOrigen.Text.Trim()) - Decimal.Parse(txtPesoBultoNuevo.Text.Trim())).ToString()
            txtVolumenBultoNuevoStr = (Decimal.Parse(txtVolumenBultoOrigen.Text.Trim()) - Decimal.Parse(txtVolumenBultoNuevo.Text.Trim())).ToString()
            If (txtCantidadRecibidaNuevoStr < 0) Then

                txtCantidadRecibidaNuevo.Text = "0"
            Else
                txtCantidadRecibidaNuevo.Text = txtCantidadRecibidaNuevoStr.ToString()
            End If
            If (txtCantidadAreaOcupadaOrigenStr < 0) Then

                txtCantidadAreaOcupadaNuevo.Text = "0"
            Else
                txtCantidadAreaOcupadaNuevo.Text = txtCantidadAreaOcupadaOrigenStr.ToString()
            End If
            If (txtPesoBultoNuevoStr < 0) Then

                txtPesoBultoNuevo.Text = "0"
            Else
                txtPesoBultoNuevo.Text = txtPesoBultoNuevoStr.ToString()
            End If
            If (txtVolumenBultoNuevoStr < 0) Then

                txtVolumenBultoNuevo.Text = "0"
            Else
                txtVolumenBultoNuevo.Text = txtVolumenBultoNuevoStr.ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub dgItemsBultoNuevo_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgItemsBultoNuevo.CellEndEdit
        Try
            With dgItemsBultoNuevo
                If .Columns(e.ColumnIndex).Name = "R_QBLTRP" Then
                    If .CurrentRow.Cells("R_QBLTRP").Value > .CurrentRow.Cells("R_QBLTSR").Value Or .CurrentRow.Cells("R_QBLTRP").Value < 0 Then
                        MessageBox.Show("No puede recibir una cantidad mayor al Saldo o menor a Cero.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        .CurrentRow.Cells("R_QBLTRP").Value = .CurrentRow.Cells("R_QBLTSR").Value
                    End If
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

     
    End Sub

    'Private Sub frmRePacking_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    '    'If Not mfblnSalirOpcion() Then
    '    '    e.Cancel = True
    '    'End If
    'End Sub

    Private Sub frmRePacking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call pMostrarInfBultoOrigen()

            dtgPaquetesDeBulto.AutoGenerateColumns = False
            Dim obrBulto As New brBulto
            Dim obeBulto As New beBulto

            ' Valida que se obtenga el Bulto, caso contrario se sale de procedimiento
            obeBulto.PSCCMPN = strCCMPN
            obeBulto.PSCDVSN = strCDVSN
            obeBulto.PNCPLNDV = dblCPLNDV
            obeBulto.PNCCLNT = intCCLNT
            obeBulto.PSCREFFW = strCREFFW
            obeBulto.PNNSEQIN = dblNSEQIN
            Dim oList As New List(Of beBulto)
            oList = obrBulto.flistListarBultoDetalleCarga(obeBulto)
            dtgPaquetesDeBulto.DataSource = oList

            For Each item As DataGridViewRow In dtgPaquetesDeBulto.Rows
                item.Cells("DIM_REPACKING").Value = 0
            Next


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
#End Region

    Private pdt As DataTable = Nothing

    Private Sub dgItemsBultoNuevo_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgItemsBultoNuevo.CellMouseClick
        Try
            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then Exit Sub
            If Me.dgItemsBultoNuevo.Columns(e.ColumnIndex).Name.Trim.Equals("SUBITEM") Then
                If Me.dgItemsBultoNuevo.Rows(e.RowIndex).Cells("NRSITEM").Value = 0 Then Exit Sub
                If Me.dgItemsBultoNuevo.Rows(e.RowIndex).Cells("R_QBLTRP").Value > 0 Then
                    Dim Item As New Ransa.TypeDef.OrdenCompra.ItemOC.TD_ItemOCPK
                    Item.pCCLNT_CodigoCliente = pCodigoCliente_CCLNT
                    Item.pCREFFW_FrdForw = pCodigoRecepcion_CREFFW
                    Item.pCCMPN_Compania = pCodigoCompania_CCMPN
                    Item.pCDVSN_Division = pCodigoDivision_CDVSN
                    Item.pCPLNDV_Planta = pCodigoPlanta_CPLNDV

                    Item.pCIDPAQ_CodIndentificacionPaquete = Me.dgItemsBultoNuevo.CurrentRow.Cells("R_CIDPAQ").Value
                    Item.pNORCML_NroOrdenCompra = Me.dgItemsBultoNuevo.CurrentRow.Cells("R_NORCML").Value
                    Item.pNRITOC_NroItemOC = Me.dgItemsBultoNuevo.CurrentRow.Cells("R_NRITOC").Value
                    frmRePackingSubItem.Items = Item
                    frmRePackingSubItem.pDt = pdt
                    frmRePackingSubItem.ShowDialog()
                    pdt = frmRePackingSubItem.pDt
                Else
                    MessageBox.Show("La cantidad de Re-Packing debe ser mayor a cero")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub txtCantidadRecibidaNuevo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCantidadRecibidaNuevo.Validating
        Try
            RecalcularMediciones()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub RecalcularMediciones()



        Dim Q_Origen As Decimal = Decimal.Parse(txtCantidadRecibidaOrigen.Text.Trim)
        Dim A_Ocupada_Origen As Decimal = Decimal.Parse(txtCantidadAreaOcupadaOrigen.Text.Trim)
        Dim P_Bulto_Origen As Decimal = Decimal.Parse(txtPesoBultoOrigen.Text.Trim)
        Dim Vol_Origen As Decimal = Decimal.Parse(txtVolumenBultoOrigen.Text.Trim)

        Dim Q_Nuevo As Decimal = Decimal.Parse(txtCantidadRecibidaNuevo.Text.Trim)
        Dim A_Ocupada_Nuevo As Decimal = 0
        Dim P_Bulto_Nuevo As Decimal = 0
        Dim Vol_Nuevo As Decimal = 0
        If (Q_Origen = 0) Then
            A_Ocupada_Nuevo = 0
            P_Bulto_Nuevo = 0
            Vol_Nuevo = 0
        Else
            'A_Ocupada_Nuevo = ((Q_Nuevo * A_Ocupada_Origen) / Q_Origen)
            A_Ocupada_Nuevo = Math.Round(((Q_Nuevo * A_Ocupada_Origen) / Q_Origen), 2)
            'P_Bulto_Nuevo = ((Q_Nuevo * P_Bulto_Origen) / Q_Origen)
            'Vol_Nuevo = ((Q_Nuevo * Vol_Origen) / Q_Origen)
            P_Bulto_Nuevo = Math.Round(((Q_Nuevo * P_Bulto_Origen) / Q_Origen), 3)
            Vol_Nuevo = Math.Round(((Q_Nuevo * Vol_Origen) / Q_Origen), 3)

        End If


        txtCantidadAreaOcupadaNuevo.Text = A_Ocupada_Nuevo
        txtPesoBultoNuevo.Text = P_Bulto_Nuevo
        txtVolumenBultoNuevo.Text = Vol_Nuevo

    End Sub

    Private Sub dtgPaquetesDeBulto_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dtgPaquetesDeBulto.CellEndEdit
        Try
            'Dim CantPaq As Decimal = 0
            'Dim resultPat As Boolean = False

            With dtgPaquetesDeBulto
                If .Columns(e.ColumnIndex).Name = "DIM_REPACKING" Then
                    'If Val("" & .CurrentRow.Cells("DIM_REPACKING").Value) = 0 Then
                    '    .CurrentRow.Cells("DIM_REPACKING").Value = ""
                    'Else
                    'resultPat = Decimal.TryParse(.CurrentRow.Cells("DIM_REPACKING").Value, CantPaq)

                    If .CurrentRow.Cells("DIM_REPACKING").Value > .CurrentRow.Cells("PNQCTPQT").Value Or .CurrentRow.Cells("DIM_REPACKING").Value < 0 Then
                        MessageBox.Show("No puede recibir una cantidad mayor al Saldo o menor a Cero o un valor incorrecto", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        .CurrentRow.Cells("DIM_REPACKING").Value = .CurrentRow.Cells("PNQCTPQT").Value
                    End If
                    'End If

                End If
            End With

            Dim intPeso As Decimal = 0
            Dim intVolumen As Decimal = 0
            Dim M2 As Decimal = 0
            Dim CantPaquetes As Decimal = 0

         
           


            Dim obeBulto As beBulto
            For Each item As DataGridViewRow In dtgPaquetesDeBulto.Rows
                obeBulto = New beBulto
                obeBulto.PNQMTLRG = Val("" & item.Cells("PNQMTLRG").Value)
                obeBulto.PNQMTANC = Val("" & item.Cells("PNQMTANC").Value)
                obeBulto.PNQMTALT = Val("" & item.Cells("PNQMTALT").Value)
                obeBulto.PNQCTPQT = Val("" & item.Cells("DIM_REPACKING").Value)
                obeBulto.PNQPSOMR = Val("" & item.Cells("PNQPSOMR").Value)

                If obeBulto.PNQCTPQT > 0 Then

                    If (obeBulto.PNQMTLRG <> 0 OrElse obeBulto.PNQMTANC <> 0 OrElse obeBulto.PNQMTALT <> 0 OrElse obeBulto.PNQCTPQT <> 0) Then
                        intPeso += Math.Round(obeBulto.PNQCTPQT * obeBulto.PNQPSOMR, 2)
                        intVolumen += obeBulto.VOLUMENPAQUETE
                        'M2 = M2 + obeBulto.PNQCTPQT * Math.Round(obeBulto.PNQMTLRG, 2) * Math.Round(obeBulto.PNQMTANC, 2)
                        M2 = M2 + Math.Round(obeBulto.PNQCTPQT * obeBulto.PNQMTLRG * obeBulto.PNQMTANC, 2)
                        CantPaquetes = CantPaquetes + obeBulto.PNQCTPQT
                    End If
                End If

            Next
            'For Each obeBulto As beBulto In Me.dtgPaquetesDeBulto.DataSource
            '    If (obeBulto.PNQMTLRG <> 0 OrElse obeBulto.PNQMTANC <> 0 OrElse obeBulto.PNQMTALT <> 0 OrElse obeBulto.PNQCTPQT <> 0) Then
            '        intPeso += Math.Round(obeBulto.PNQCTPQT * obeBulto.PNQPSOMR, 2)
            '        intVolumen += obeBulto.VOLUMENPAQUETE
            '        'M2 = M2 + obeBulto.PNQCTPQT * Math.Round(obeBulto.PNQMTLRG, 2) * Math.Round(obeBulto.PNQMTANC, 2)
            '        M2 = M2 + Math.Round(obeBulto.PNQCTPQT * obeBulto.PNQMTLRG * obeBulto.PNQMTANC, 2)
            '        CantPaquetes = CantPaquetes + obeBulto.PNQCTPQT
            '    End If
            'Next
         

            txtPesoBultoNuevo.Text = Math.Round(intPeso, 3).ToString.Trim
            txtVolumenBultoNuevo.Text = Math.Round(intVolumen, 3).ToString.Trim
           

            txtCantidadAreaOcupadaNuevo.Text = M2.ToString.Trim
            txtCantidadRecibidaNuevo.Text = CantPaquetes.ToString.Trim






        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub
End Class
