Imports System.Text
Imports System.IO
'Imports Ransa.TypeDef.Cliente
Imports Ransa.TypeDef.Waybill
Imports RANSA.NEGO.slnSOLMIN_SAT.Almacen
Imports RANSA.NEGO.slnSOLMIN_SAT.Almacen.Procesos
Imports RANSA.NEGO.slnSOLMIN_SAT.PreDespacho.Procesos
Imports Ransa.DAO.WayBill
'Imports Ransa.TypeDef.UbicacionPlanta
Imports Ransa.NEGO
Imports Ransa.TYPEDEF
Imports Ransa.Utilitario
Imports RANSA.NEGO.slnSOLMIN_SAT.Recepcion
Imports Ransa.Controls.OrdenCompra
Imports RANSA.DAO.OrdenCompra

Public Class frmTrasladoOC
    Public oListBulto As New List(Of beBulto)
    Public _Bulto As Ransa.TYPEDEF.WayBill.TD_Sel_Bulto_L01

    Private _NORCML_OrdenCompra As String
    Private PSCIDPAQ As String = ""
    Private PNQBLTSR_PENDIENTE As Decimal = 0

    Public myDialogResult As Boolean = False



    Private _Compania As String
    Public Property Compania() As String
        Get
            Return _Compania
        End Get
        Set(ByVal value As String)
            _Compania = value
        End Set
    End Property


    Private _Division As String
    Public Property Division() As String
        Get
            Return _Division
        End Get
        Set(ByVal value As String)
            _Division = value
        End Set
    End Property


    Private _Planta As Decimal
    Public Property Planta() As Decimal
        Get
            Return _Planta
        End Get
        Set(ByVal value As Decimal)
            _Planta = value
        End Set
    End Property

    Public Property pNORCML() As String
        Get
            Return _NORCML_OrdenCompra
        End Get
        Set(ByVal value As String)
            _NORCML_OrdenCompra = value
        End Set
    End Property

    Public Property Bulto() As Ransa.TYPEDEF.WayBill.TD_Sel_Bulto_L01
        Get
            Return _Bulto
        End Get
        Set(ByVal value As Ransa.TYPEDEF.WayBill.TD_Sel_Bulto_L01)
            _Bulto = value
        End Set
    End Property

    Private oHasPaqIngresados As New Hashtable
    Private validar As Boolean = False

    Private Sub frmTrasladoOC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dgBultosDetalle.AutoGenerateColumns = False
            dgOrdenComprasSeleccionados.AutoGenerateColumns = False
            dgBultosDetalle.DataSource = oListBulto
            BuscarOC()
            lblOrigen.Text = lblOrigen.Text & oListBulto.Item(0).PSNORCML
            lblDestino.Text = lblDestino.Text & pNORCML
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BuscarOC()
        oHasPaqIngresados.Clear()
        Dim objPrimaryKey_Bulto As clsPrimaryKey_OrdenCompra = New clsPrimaryKey_OrdenCompra
        With objPrimaryKey_Bulto
            .pintCodigoCliente_CCLNT = Bulto.pCCLNT_CodigoCliente
            .pstrNroOrdenCompra_NORCML = pNORCML
            .Compania = Bulto.pCCMPN_Compania
            .Division = Bulto.pCDVSN_Division
            .Planta = Bulto.pCPLNDV_Planta

        End With
        dgOrdenComprasSeleccionados.AutoGenerateColumns = False
        dgOrdenComprasSeleccionados.SelectionMode = DataGridViewSelectionMode.CellSelect
        dgOrdenComprasSeleccionados.DataSource = mfdtListar_ItemOCResumenSeleccionados(objPrimaryKey_Bulto)


    End Sub


    Public Function BuscaBultoValidado(ByVal obeBulto As beBulto) As Boolean
        Dim retorno As Boolean = False
        retorno = (obeBulto.PSCIDPAQ.Trim = PSCIDPAQ AndAlso PNQBLTSR_PENDIENTE >= obeBulto.PNQBLTSR)
        Return retorno
    End Function

    Private Function ValidarCodigosPaquetes(ByRef oListBultos As List(Of beBulto)) As String

        Dim obeBulto As beBulto
        Dim obeBultoBuscado As beBulto

        Dim ValidarExistencia As Boolean = True
        Dim ValidaRepitencia As Boolean = False
        Dim sbPaqNoValidos As New StringBuilder
        Dim sbmsg As New StringBuilder
        Dim COD_PAQUETE_DESTINO As String = ""

        For Each dr As DataGridViewRow In dgOrdenComprasSeleccionados.Rows
            If (dr.Cells("D_CIDPAQ_DESTINO").Value IsNot Nothing) Then
                COD_PAQUETE_DESTINO = dr.Cells("D_CIDPAQ_DESTINO").Value.ToString.Trim
                If (COD_PAQUETE_DESTINO <> "") Then
                    PSCIDPAQ = COD_PAQUETE_DESTINO
                    PNQBLTSR_PENDIENTE = dr.Cells("QCNPEN").Value
                    If (oHasPaqIngresados.Contains(PSCIDPAQ)) Then
                        ValidaRepitencia = True
                        Exit For
                    Else
                        oHasPaqIngresados.Add(PSCIDPAQ, PSCIDPAQ)
                        obeBultoBuscado = oListBulto.Find(AddressOf BuscaBultoValidado)
                        If (obeBultoBuscado Is Nothing) Then
                            sbPaqNoValidos.Append(COD_PAQUETE_DESTINO)
                            sbPaqNoValidos.Append(",")
                            ValidarExistencia = False
                        Else
                            obeBulto = New beBulto
                            obeBulto.PSNORCML = obeBultoBuscado.PSNORCML.Trim
                            obeBulto.PSNORCML_DESTINO = ("" & dr.Cells("NORCML").Value).ToString.Trim

                            obeBulto.PNNRITOC = obeBultoBuscado.PNNRITOC
                            obeBulto.PNNRITOC_DESTINO = Decimal.Parse(dr.Cells("NRITOC").Value)

                            obeBulto.PNQBLTSR = obeBultoBuscado.PNQBLTSR

                            obeBulto.PSCIDPAQ = COD_PAQUETE_DESTINO

                            obeBulto.PNCCLNT = Bulto.pCCLNT_CodigoCliente
                            obeBulto.PSCCMPN = Bulto.pCCMPN_Compania
                            obeBulto.PSCDVSN = Bulto.pCDVSN_Division
                            obeBulto.PNCPLNDV = Bulto.pCPLNDV_Planta
                            obeBulto.PSCREFFW = Bulto.pCREFFW_CodigoBulto
                            obeBulto.PNNSEQIN = Bulto.pNSEQIN_NrSecuencia
                            obeBulto.PSCULUSA = objSeguridadBN.pUsuario

                            oListBultos.Add(obeBulto)
                        End If
                    End If
                End If
            End If
        Next

        If (ValidaRepitencia = True) Then
            sbmsg.AppendLine("La asignación se repite.")
            sbmsg.AppendLine("Un código de paquete solo debe ser asignado a una Orden de Compra y Nro Item.")
        ElseIf ValidarExistencia = False Then
            sbmsg.AppendLine("Existen códigos de paquetes que no se encuentran en la Información Bultos Origen")
            sbmsg.AppendLine("  o cuya cantidad pendiente destino son menores a la cantidad origen.")
            sbmsg.AppendLine("Verifique los siguientes códigos de paquetes:")
            sbmsg.Append(sbPaqNoValidos.ToString.Remove(sbPaqNoValidos.Length - 1, 1))
        End If

        Return sbmsg.ToString
    End Function
    Private Sub ValidarIngresoPaquete(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If (validar = False) Then
            Dim obeBultoBuscado As beBulto
            Dim COD_PAQUETE_DESTINO As String = ""
            Dim COD_PAQUETE_ACTUAL As String = ""
            Dim txt As DataGridViewTextBoxEditingControl = sender
            COD_PAQUETE_DESTINO = txt.Text.Trim
            PSCIDPAQ = COD_PAQUETE_DESTINO
            If (COD_PAQUETE_DESTINO <> "") Then
                PNQBLTSR_PENDIENTE = dgOrdenComprasSeleccionados.CurrentRow.Cells("QCNPEN").Value
                obeBultoBuscado = oListBulto.Find(AddressOf BuscaBultoValidado)
                If (obeBultoBuscado Is Nothing) Then
                    dgOrdenComprasSeleccionados.CurrentRow.Cells("D_CIDPAQ_DESTINO").Value = ""

                    If (COD_PAQUETE_DESTINO <> "") Then
                        MessageBox.Show("El código Paquete debe estar en el origen y la cantidad destino " & Chr(13) & "debe ser mayor a la cantidad origen", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    For FILA As Integer = 0 To dgOrdenComprasSeleccionados.Rows.Count - 1
                        If (FILA <> dgOrdenComprasSeleccionados.CurrentRow.Index) Then
                            COD_PAQUETE_ACTUAL = "" & dgOrdenComprasSeleccionados.Rows(FILA).Cells("D_CIDPAQ_DESTINO").Value & "%"
                            If (COD_PAQUETE_ACTUAL <> "") Then
                                If (COD_PAQUETE_DESTINO = COD_PAQUETE_ACTUAL) Then
                                    dgOrdenComprasSeleccionados.CurrentRow.Cells("D_CIDPAQ_DESTINO").Value = ""
                                    MessageBox.Show("Un código de Paquete debe ser asignado para solo una OC.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Exit For
                                End If
                            End If
                        End If

                    Next
                End If
            End If
        End If
        validar = True
    End Sub

    
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            If (oListBulto.Count = 0) Then
                MessageBox.Show("No existen Bultos Origen que Modificar.")
                Return
            End If
            Dim oListBultos As New List(Of beBulto)
            Dim obrBulto As New brBulto
            Dim retorno As Int32 = 0
            dgOrdenComprasSeleccionados.EndEdit()
            oHasPaqIngresados.Clear()
            Dim mgValidaPaquetes As String = ValidarCodigosPaquetes(oListBultos)
            If (mgValidaPaquetes <> "") Then
                MessageBox.Show(mgValidaPaquetes, "Validación Códigos Paquetes.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If (oListBultos.Count = 0) Then
                    MessageBox.Show("Ingrese los Códigos de Paquetes Destino.", "Ingreso Paquetes", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    retorno = obrBulto.RealizarTrasladoBultoItemOC(oListBultos)
                    If (retorno = 1) Then
                        myDialogResult = True
                        MessageBox.Show("Los Items Bulto seleccionados han sido trasladados correctamente.", "Traslado Bultos OC", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    Else
                        MessageBox.Show("No se pudo realizar el proceso.", "Traslado OC", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End If
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub


    Private Sub dgOrdenComprasSeleccionados_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgOrdenComprasSeleccionados.EditingControlShowing
        validar = False
        Try
            If (dgOrdenComprasSeleccionados.CurrentCell.ColumnIndex = 0) Then
                Dim txt As DataGridViewTextBoxEditingControl = e.Control
                AddHandler txt.Validating, AddressOf ValidarIngresoPaquete
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tsbAgregarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAgregarItem.Click
        Dim TD_OrdenCompraActual As Ransa.TYPEDEF.OrdenCompra.OrdenCompra.TD_OrdenCompraPK = New Ransa.TYPEDEF.OrdenCompra.OrdenCompra.TD_OrdenCompraPK
        ' Validamos de que haya un cliente seleccionado
        TD_OrdenCompraActual.pCCLNT_CodigoCliente = Bulto.pCCLNT_CodigoCliente
        TD_OrdenCompraActual.pNORCML_NroOrdenCompra = pNORCML

        If TD_OrdenCompraActual.pCCLNT_CodigoCliente = 0 Then Exit Sub
        ' Instanciamos el Formulario para poderlo mostrar con la información del Item a editar
        Dim oMItem = New Ransa.Controls.OrdenCompra.ucItemOC_MItem(TD_OrdenCompraActual, objSeguridadBN.pUsuario)
        oMItem.pHabilitarNroItem = True
        ' oMItem.phabilitarBulto = btnGenerarBulto.Visible
        oMItem.ShowDialog()
        BuscarOC()
        'pCargarInformacion()
    End Sub

    Private Sub tbnTrasladar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbnTrasladar.Click
        ''Trasladar
    End Sub
End Class
