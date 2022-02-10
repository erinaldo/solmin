Imports Ransa.TypeDef.OrdenCompra

Public Class frmListaOC_MIQ
    Private _pCCCLNT As Decimal = 0
    Public Property pCCCLNT() As Decimal
        Get
            Return _pCCCLNT
        End Get
        Set(ByVal value As Decimal)
            _pCCCLNT = value
        End Set
    End Property


    Private _pUSER As String = ""
    Public Property pUSER() As String
        Get
            Return _pUSER
        End Get
        Set(ByVal value As String)
            _pUSER = value
        End Set
    End Property


    Private _pCCCLNT_YRC As Decimal = 0
    Public Property pCCCLNT_YRC() As Decimal
        Get
            Return _pCCCLNT_YRC
        End Get
        Set(ByVal value As Decimal)
            _pCCCLNT_YRC = value
        End Set
    End Property


    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            kdgvOC.DataSource = Nothing
            txtOC.Text = txtOC.Text.Trim
            Dim oImportasOC As New ImportarOC.ImportarOcYRC
            Dim oDtOc As New DataTable
            Dim FechaIni As String = dtFechaIni.Value.ToString("dd/MM/yyyy")
            Dim FechaFin As String = dtFechaFin.Value.ToString("dd/MM/yyyy")
            Dim OrdenCompra As String = txtOC.Text.Trim
            If rbOC.Checked = True Then
                If txtOC.Text.Length = 0 Then
                    MessageBox.Show("Debe ingresar Orden de Compra", "Aviso", MessageBoxButtons.OK)
                    Exit Sub
                End If
                oDtOc = oImportasOC.GetOC_Varios(_pCCCLNT_YRC, OrdenCompra)
            ElseIf rbFechaOC.Checked = True Then
                oDtOc = oImportasOC.GetOC_X_Fecha_Act(_pCCCLNT_YRC, dtFechaIni.Value, dtFechaFin.Value)
            End If
            Dim DEMIS As String = ""
            Dim DFECCRE As String = ""
            Dim DFECACT As String = ""
            For Each Item As DataRow In oDtOc.Rows
                Item("SNROOC") = ("" & Item("SNROOC")).ToString.Trim
                DEMIS = ("" & Item("DEMIS")).ToString.Trim
                DFECCRE = ("" & Item("DFECCRE")).ToString.Trim
                DFECACT = ("" & Item("DFECACT")).ToString.Trim
                If DEMIS.Length >= 10 Then
                    Item("DEMIS") = DEMIS.Substring(0, 10)
                End If
                If DFECCRE.Length >= 10 Then
                    Item("DFECCRE") = DFECCRE.Substring(0, 10)
                End If
                If DFECACT.Length >= 10 Then
                    Item("DFECACT") = DFECACT.Substring(0, 10)
                End If
            Next
            Dim oListOc As New List(Of String)
            If oDtOc.Rows.Count > 0 Then
                Dim oOrdenCompra_DAL As New OrdenCompra_DAL
                oListOc = oOrdenCompra_DAL.ListarOCDistintas(_pCCCLNT)
            End If
            kdgvOC.DataSource = oDtOc
            Dim NORMCL As String = ""
            For Each Item As DataGridViewRow In kdgvOC.Rows
                NORMCL = ("" & Item.Cells("SNROOC").Value).ToString.Trim
                If oListOc.Contains(NORMCL) Then
                    Item.Cells("btnExist").Value = My.Resources.button_ok1
                    Item.Cells("btnExist").ToolTipText = "Orden Registrada"
                Else
                    Item.Cells("btnExist").Value = My.Resources.eliminarItem
                    Item.Cells("btnExist").ToolTipText = "Nueva Orden"
                End If
            Next
            'Me.txtNroOrdenCompra.Text = .Item("SNROOC").ToString()
            'txtFechaOrdenCompra.Value = .Item("DEMIS").ToString()
            'txtAreaSolicitante.Text = .Item("SARECOM").ToString()
            'cmbTermItern.pCargarPorCodigo = .Item("CINCOTE").ToString()
            'Select Case .Item("CURG").ToString()
            '    Case 0
            '        cmbPrioridad.pCargarPorCodigo = 1
            '    Case 1
            '        cmbPrioridad.pCargarPorCodigo = 3
            '    Case 2
            '        cmbPrioridad.pCargarPorCodigo = 4
            'End Select
            'cmbMoneda.pCargarPorAbreviatura = .Item("CMONEDA").ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub frmImportarDatos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dtFechaIni.Value = Now.AddDays(-15)
            kdgvOC.AutoGenerateColumns = False
            rbOC.Checked = True
            HabilitarOpcion()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try

    End Sub
    Private Sub HabilitarOpcion()
        If rbFechaOC.Checked = True Then
            txtOC.Enabled = False
            dtFechaIni.Enabled = True
            dtFechaFin.Enabled = True
        ElseIf rbOC.Checked = True Then
            txtOC.Enabled = True
            dtFechaIni.Enabled = False
            dtFechaFin.Enabled = False
        End If
    End Sub

    Private Sub rbFechaOC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFechaOC.CheckedChanged
        HabilitarOpcion()
    End Sub

    Private Sub rbOC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbOC.CheckedChanged
        HabilitarOpcion()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        Try
            If kdgvOC.CurrentRow Is Nothing Then
                Exit Sub
            End If
            Dim Fila As Int32 = kdgvOC.CurrentRow.Index
            Dim ofrmImportarOCLista As New frmImportarOC_MIQ
            ofrmImportarOCLista.pCCCLNT = _pCCCLNT
            ofrmImportarOCLista.pCCCLNT_YRC = _pCCCLNT_YRC
            ofrmImportarOCLista.pNORCML = ("" & kdgvOC.Rows(Fila).Cells("SNROOC").Value).ToString.Trim
            ofrmImportarOCLista.pFECHAOC = ("" & kdgvOC.Rows(Fila).Cells("DEMIS").Value).ToString.Trim
            ofrmImportarOCLista.pAREA_SOLICITANTE = ("" & kdgvOC.Rows(Fila).Cells("SARECOM").Value).ToString.Trim
            ofrmImportarOCLista.pINCOTERM = ("" & kdgvOC.Rows(Fila).Cells("CINCOTE").Value).ToString.Trim
            ofrmImportarOCLista.pPRIORIDAD = ("" & kdgvOC.Rows(Fila).Cells("CURG").Value).ToString.Trim
            ofrmImportarOCLista.pMONEDA = ("" & kdgvOC.Rows(Fila).Cells("CMONEDA").Value).ToString.Trim
            ofrmImportarOCLista.pUSER = _pUSER
            If ofrmImportarOCLista.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
    End Sub
End Class
