Imports Db2Manager.RansaData.iSeries.DataObjects

Imports Ransa.Utilitario
Imports System.Windows.Forms
Imports SOLMIN_CTZ.NEGOCIO
Imports SOLMIN_CTZ.Entidades

Public Class frmModValorizacion
    

    Private oValorizacionFiltro As New beMantValorizacion
    Private checkallTransporte As Boolean = False
    Private cOrgVenta As String = ""
    Public pCDVSN As String = ""
    Public pCCLNT As Decimal = 0
    Public pCCMPN As String = ""
    Public pNROVLR As Decimal = 0
    Public pNROSGV As Decimal = 0

    Private objDivision As New SOLMIN_CTZ.NEGOCIO.clsDivision

    Enum MANTENIMIENTO_OPC
        NEUTRAL = 0
        NUEVO = 1
        EDITAR = 2
        ELIMINAR = 3
        MODIFICAR = 4
    End Enum


    

    'Private pUsuRegistro As String
    'Public Property UsuRegistro() As String
    '    Get
    '        Return pUsuRegistro
    '    End Get
    '    Set(ByVal value As String)
    '        pUsuRegistro = value
    '    End Set
    'End Property

    Sub Cargar_Division()

        Dim objDivision As New SOLMIN_CTZ.NEGOCIO.clsDivision
        Dim dt As New DataTable
        objDivision.Crea_Lista()
        dt = objDivision.Lista_Division(pCCMPN)
        Me.cbodivision.ComboBox.ValueMember = "CDVSN"
        Me.cbodivision.ComboBox.DisplayMember = "TCMPDV"
        Me.cbodivision.ComboBox.DataSource = dt
        'Me.cbodivision.ComboBox.SelectedValue = "T"

        cbodivision_SelectedIndexChanged(Nothing, Nothing)

    End Sub


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)
        Try
            dtgDetValorizacion.AutoGenerateColumns = False
            dtgDetValorizacion.DataSource = Nothing

            checkall = False
            checkallTransporte = False


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmModValorizacion_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try

            dtgDetValorizacion.AutoGenerateColumns = False
            Cargar_Division()

            'ListarOperacionesxDivision()


            ' chkvalorizacion_CheckedChanged(chkvalorizacion, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGenerarPL_Click_1(sender As Object, e As EventArgs) Handles btnGenerarPL.Click
        Try

            Dim smgValidacion As String = ValidarOperacionesTransportePendientePL()
            If smgValidacion.Length > 0 Then
                MessageBox.Show(smgValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If dtgDetValorizacion.RowCount = 0 Then Exit Sub
            Dim objEntidad As New beFactura_Transporte
            Dim objGenericCollection As New List(Of beFactura_Transporte)
            Dim objfrmListaPreFactura As New frmListaPreFacturaPl
            Me.dtgDetValorizacion.EndEdit()

            'If Consistencia_Organizacion_Venta(Me.dtgOpValorizacion) = False Then
            '    HelpClass.MsgBox("La Organización de Venta de las Pre-Facturas seleccionadas no son las mismas.", MessageBoxIcon.Information)
            '    Exit Sub
            'End If
            Dim VLR_CANT As Decimal = 0
            Dim CompSoles As Boolean = False
            Dim CompDolar As Boolean = False
            Dim msgComparacion As String = ""
            Dim pCodDivision As String = ""
            'Dim pCDVSN As CDVSN
            For Each row As DataGridViewRow In dtgDetValorizacion.Rows
                If row.Cells("CHK").Value = True Then
                    objEntidad = New beFactura_Transporte
                    objEntidad.NDCPRF = row.Cells("NDCPRF").Value
                    objEntidad.IMPOCOS = row.Cells("IMPORTE_S").Value
                    objEntidad.IMPOCOD = row.Cells("IMPORTE_D").Value
                    'dtgDetValorizacion.CurrentRow.Cells("CCMPN").Value = objEntidad.CCMPN
                    objEntidad.CCMPN = pCCMPN
                    objEntidad.CDVSN = row.Cells("CDVSN").Value ' Me.cboDivision.SelectedValue
                    ' pCodDivision = row.Cells("CDVSN").Value
                    objGenericCollection.Add(objEntidad)
                End If
            Next
            'CCLNT CType(Me.dtgOpValorizacion.SelectedRows(0).Cells("CCLNT").Value, Integer)
            If objGenericCollection.Count = 0 Then Exit Sub
            With objfrmListaPreFactura
                .CCLNT = pCCLNT
                '.CCLNT = dtgDetValorizacion.CurrentRow.Cells("CCLNT").Value
                '.CCMPN = dtgDetValorizacion.CurrentRow.Cells("CCMPN").Value
                .CCMPN = pCCMPN
                .CDVSN = pCodDivision ' Me.cboDivision.SelectedValue
                '.CPLNDV = 0
                '.CPLNDV_1 = "TODOS"
                .pNROVLR = pNROVLR
                '.pNROVLR = dtgDetValorizacion.CurrentRow.Cells("NROVLR").Value
                .ListFactura_Transporte = objGenericCollection
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then

                    ListarOperacionesPendientes()
                End If
            End With




            'Dim frm As New frmListaPreFacturaPl
            ''frm.pCCMPN = dtgDetValorizacion.CurrentRow.Cells("CCMPN").Value
            ''frm.pCCLNT = dtgValorizacion.CurrentRow.Cells("CCLNT").Value
            ''frm.pNROVLR = dtgDetValorizacion.CurrentRow.Cells("NROVLR").Value
            '' frm.pNROSGV = dtgValorizacion.CurrentRow.Cells("NROSGV").Value
            ''frm.VLR_SOL = dtgDetValorizacion.CurrentRow.Cells("IMPORTE_S").Value
            ''frm.VLR_DOL = dtgDetValorizacion.CurrentRow.Cells("IMPORTE_D").Value

            ''If ShowDialog() = Windows.Forms.DialogResult.OK Then

            ''    ListarOperacionesPendientes()
            ''End If

            'Dim ofrmMantValorizacion As New frmMantValorizacion

            ' ''ofrmMantValorizacion.pCCMPN = Me.cboCompania.CCMPN_CodigoCompania
            ''ofrmMantValorizacion.pCCLNT = dtgDetValorizacion.CurrentRow.Cells("CCLNT").Value
            ''ofrmMantValorizacion.pCDVSN = dtgDetValorizacion.CurrentRow.Cells("CDVSN").Value
            ' ''ofrmMantValorizacion.pCDVSN = Me.cbodivision.
            ''ofrmMantValorizacion.ShowDialog()
            ''If ofrmMantValorizacion.myDialogResult = True Then
            ''    ListarOperacionesPendientes()
            ''End If
            'frm.Show()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private checkall As Boolean = False
    Private Sub btnCheck_Click(sender As Object, e As EventArgs)

        Try
            For Each item As DataGridViewRow In dtgDetValorizacion.Rows
                item.Cells("CHK").Value = Not checkall
            Next
            dtgDetValorizacion.EndEdit()
            checkall = Not checkall
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub






    Private Function ValidarOperacionesTransportePendientePL() As String
        Dim strvalidacion As String = ""
        dtgDetValorizacion.EndEdit()
        Dim CantOp As Int32 = 0
        For Each item As DataGridViewRow In dtgDetValorizacion.Rows
            If item.Cells("CHK").Value = True Then
                If (item.Cells("TPOPER").Value = "T" And item.Cells("NDCPRF").Value <> 0 And item.Cells("NPRLQD").Value = 0) = False Then
                    strvalidacion = "Debe seleccionar solo operaciones Pendientes PL(PreFacturados)."
                    Exit For
                End If
                CantOp = CantOp + 1
            End If
        Next
        If CantOp = 0 Then
            strvalidacion = "No ha seleccionado operaciones"
        End If
        Return strvalidacion
    End Function
    'Private Sub btnCheckTransp_Click(sender As Object, e As EventArgs)
    '    Try
    '        For Each item As DataGridViewRow In dtgOpValorizacion.Rows
    '            If item.Cells("TPOPER").Value = "T" And item.Cells("NDCPRF").Value <> 0 And item.Cells("NPRLQD").Value = 0 Then
    '                item.Cells("CHK").Value = Not checkallTransporte
    '            Else
    '                item.Cells("CHK").Value = False
    '            End If 
    '        Next
    '        dtgOpValorizacion.EndEdit()
    '        checkallTransporte = Not checkallTransporte
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub ListarOperacionesPendientes()
        Dim frm As New frmMantValorizacion
        Dim obrFiltroValorizacion As New clsMantValorizacion
        Dim oValorizacionFiltro As New beMantValorizacion
        oValorizacionFiltro = New beMantValorizacion
        oValorizacionFiltro.CDVSN = frm.dtgOpValorizacion.CurrentRow.Cells("CDVSN").Value
        oValorizacionFiltro.CCMPN = frm.dtgOpValorizacion.CurrentRow.Cells("CCMPN").Value
        oValorizacionFiltro.CCLNT = frm.dtgOpValorizacion.CurrentRow.Cells("CCLNT").Value
        oValorizacionFiltro.NROVLR = frm.dtgOpValorizacion.CurrentRow.Cells("NROVLR").Value
        oValorizacionFiltro.NROSGV = frm.dtgOpValorizacion.CurrentRow.Cells("NROSGV").Value
        dtgDetValorizacion.DataSource = obrFiltroValorizacion.ListarOPxEnvioValorizacion(oValorizacionFiltro)
    End Sub
    Private Sub ListarOperacionesxDivision()
        Dim frm As New frmMantValorizacion
        Dim obrFiltroValorizacion As New clsMantValorizacion
        oValorizacionFiltro = New beMantValorizacion
        oValorizacionFiltro.CDVSN = cbodivision.ComboBox.SelectedValue
        oValorizacionFiltro.CCMPN = pCCMPN
        oValorizacionFiltro.CCLNT = pCCLNT
        oValorizacionFiltro.NROVLR = pNROVLR
        oValorizacionFiltro.NROSGV = pNROSGV
        dtgDetValorizacion.DataSource = obrFiltroValorizacion.ListarOPXDivisionValorizacion(oValorizacionFiltro)
    End Sub


    Private Sub cbodivision_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbodivision.SelectedIndexChanged
        If cbodivision.ComboBox.SelectedValue <> "" Then
            ListarOperacionesxDivision()
        End If
    End Sub


    Private Sub dtgDetValorizacion_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgDetValorizacion.CellContentClick

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dispose()
        
    End Sub


   
    Private Sub cbodivision_Click(sender As Object, e As EventArgs) Handles cbodivision.Click

    End Sub
End Class
