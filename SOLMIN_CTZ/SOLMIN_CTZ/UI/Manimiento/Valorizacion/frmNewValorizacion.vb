Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.Utilitario
Imports SOLMIN_CTZ.NEGOCIO
Imports SOLMIN_CTZ.Entidades
 



Public Class frmNewValorizacion


    Private BandNew As Boolean = True


    Public pCCLNT As Decimal = 0
    Public pCCMPN As String = ""
    Public pNROVLR As Decimal = 0
    Public pNROSGV As Decimal = 0
    Public myDialogResult As Boolean = False
 
  

    Private Sub CargarDivision()

        Me.cboDivision.Usuario = ConfigurationWizard.UserName
        Me.cboDivision.Compania = pCCMPN
        Me.cboDivision.DivisionDefault = "T"
        Me.cboDivision.pActualizar()
      
    End Sub



    Private Sub frmNewValorizacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            Me.dtgOperaciones.AutoGenerateColumns = False
            CargarComboDivision()
          

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try





    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            If Me.Validar_Datos_Filtro = True Then Exit Sub
            BuscarValorizacion()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Dim oListConsistencia As Hashtable
    Private Sub BuscarValorizacion()
        Dim oValorizacion As New beMantValorizacion
        Dim obrMantValorizacion As New clsMantValorizacion
        Dim dtListado As New DataTable
        With oValorizacion
            .CCMPN = pCCMPN
            .CDVSN = DevuelveDivisionSeleccionadas(cboDivision2)
            .CPLNDV = "0"
            .CCLNT = pCCLNT
            .NOPRCN = Val(txtoperacion.Text.Trim)
        End With
        'oListConsistencia = New Hashtable
        'Dim dtListadoConsist As New DataTable
        Dim dtOp As New DataTable
        'Dim dtOpConsist As New DataTable
        dtListado = obrMantValorizacion.ListarOperPendientesValorizacion(oValorizacion)
        'dtOp = dsListado.Tables(0).Copy
        'dtOpConsist = dsListado.Tables(1).Copy
        dtgOperaciones.DataSource = dtListado
      
    End Sub

 

    Private Function ValidarIngreso() As String
        Dim msg As String = ""
       
        Me.dtgOperaciones.EndEdit()
        If dtgOperaciones.Rows.Count = 0 Then
            msg = msg & " * Debe seleccionar las operaciones."
        Else
            Dim CantReg As Integer = 0
            For Each row As DataGridViewRow In Me.dtgOperaciones.Rows
                If row.Cells("chkColumn").Value = True Then
                    CantReg = CantReg + 1
                    If CantReg > 0 Then
                        Exit For
                    End If
                End If
            Next
            If CantReg = 0 Then
                msg = msg & " * No ha seleccionado operaciones."
            End If

        End If


     

        Return msg
    End Function

    Private Function Validar_Datos_Filtro() As Boolean
        Dim lstr_validacion As String = ""
        Dim lbool_existe_error As Boolean = False

        If DevuelveDivisionSeleccionadas(cboDivision2).Length = 0 Then
            lstr_validacion += "* SELECCIONE AL MENOS UNA DIVISION " & Chr(13)
        End If
        If lstr_validacion <> "" Then
            HelpClass.MsgBox("DEBE DE INGRESAR :" & Chr(13) & lstr_validacion)
            lbool_existe_error = True
        End If
        Return lbool_existe_error
    End Function


 

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click

        Try
            Dim msgValidacion As String = ""

            msgValidacion = ValidarIngreso()

            If msgValidacion.Length > 0 Then
                MessageBox.Show(msgValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If


            Dim oValorizacionCab As New beMantValorizacion
            Dim obrValorizacion As New clsMantValorizacion
            Dim dtTransaccion As New DataTable
            Dim sErrorMesage As String = ""
            Dim sMesageAlerta As String = ""
            Dim sStatus As String = ""

    
            oValorizacionCab.NROVLR = pNROVLR
            oValorizacionCab.NROSGV = pNROSGV


            Dim oValorizacionDet As New beMantValorizacion

            If oValorizacionCab.NROVLR > 0 Then
                Me.dtgOperaciones.EndEdit()
                For Each row As DataGridViewRow In Me.dtgOperaciones.Rows
                    If row.Cells("chkColumn").Value = True Then
                        oValorizacionDet.CCMPN = pCCMPN
                        oValorizacionDet.NROVLR = oValorizacionCab.NROVLR
                        oValorizacionDet.NROSGV = oValorizacionCab.NROSGV
                        '
                        oValorizacionDet.TPOPER = row.Cells("TPOPER").Value

                        oValorizacionDet.NOPRCN = row.Cells("NOPRCN").Value
                        'oValorizacionDet.NGUIRM = row.Cells("NGUIRM").Value
                        oValorizacionDet.NSECFC = row.Cells("NSECFC").Value
                        'PNNSECFC

                        oValorizacionDet.CCLNT = pCCLNT
                        oValorizacionDet.CDVSN = row.Cells("CDVSN").Value

                        oValorizacionDet.CPLNDV = row.Cells("CPLNDV").Value
                        oValorizacionDet.CULUSA = ConfigurationWizard.UserName
                        oValorizacionDet.NTRMNL = Ransa.Utilitario.HelpClass.NombreMaquina
                        obrValorizacion.InsertaDetalleOperValorizacionPendiente(oValorizacionDet)

                        myDialogResult = True

                    End If
                Next
            End If

 

            BuscarValorizacion()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub CargarComboDivision()
        Dim oDivision As New DataTable
        'Dim obrDivision As New brDivision
        Dim obrDivision As New Ransa.Controls.UbicacionPlanta.Division.brDivision
        Dim _Usuario As String
        Dim _CodCompania As String
        _Usuario = ConfigurationWizard.UserName
        _CodCompania = pCCMPN
        oDivision = obrDivision.Lista_Division_X_Usuario_Y_Compania(_Usuario, _CodCompania)

        Dim dt As New DataTable
        Dim dr As DataRow
        dt.Columns.Add(New DataColumn("CDVSN", GetType(String)))
        dt.Columns.Add(New DataColumn("TCMPDV", GetType(String)))

        For Each row As DataRow In oDivision.Rows
            dr = dt.NewRow()
            dr("CDVSN") = row("CDVSN").ToString.Trim
            dr("TCMPDV") = row("TCMPDV").ToString.Trim
            dt.Rows.Add(dr)
        Next

        cboDivision2.Text = ""
        cboDivision2.DisplayMember = "TCMPDV"
        cboDivision2.ValueMember = "CDVSN"
        cboDivision2.DataSource = dt

        cboDivision2.SetItemChecked(0, True)

    End Sub
    Private Function ValidarFiltroDivision() As Boolean
        Dim lstr_validacion As String = ""
        Dim lbool_existe_error As Boolean = True
        For i As Integer = 0 To cboDivision2.CheckedItems.Count - 1
            lstr_validacion += cboDivision2.CheckedItems(i).Value & ","
        Next
        If lstr_validacion = "" Then
            lbool_existe_error = False
        End If
        If lbool_existe_error = False Then HelpClass.MsgBox("Seleccione alguna(s) Division(es)" & Chr(13) & lstr_validacion, MessageBoxIcon.Information)
        Return lbool_existe_error
    End Function

    Private Sub cboDivision2_ItemChec(sender As Object, e As Windows.Forms.ItemCheckEventArgs) Handles cboDivision2.ItemChec
        Try
            If e.Index = 0 Then
                If e.NewValue = CheckState.Checked Then
                    For idx As Integer = 1 To Me.cboDivision2.Items.Count - 1
                        Me.cboDivision2.SetItemCheckState(idx, CheckState.Checked)
                    Next
                ElseIf e.NewValue = CheckState.Unchecked Then
                    For idx As Integer = 1 To Me.cboDivision2.Items.Count - 1
                        Me.cboDivision2.SetItemCheckState(idx, CheckState.Unchecked)
                    Next
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
     

    End Sub

    Private Function DevuelveDivisionSeleccionadas(MiCombo As Ransa.Utilitario.CheckComboBoxGeneral.CheckedComboBoxGeneral) As String
        Dim strCodDivision As String
        strCodDivision = ""
        For i As Integer = 0 To MiCombo.CheckedItems.Count - 1
            strCodDivision += MiCombo.CheckedItems(i).Value & ","
        Next
        Dim v As Integer
        v = InStr(1, strCodDivision, "0,")
        If v = 1 Then
            strCodDivision = "0,"

        End If
        If strCodDivision = "0," Then
            strCodDivision = ""
            For i As Integer = 1 To MiCombo.Items.Count - 1
                strCodDivision += MiCombo.Items(i).Value & ","
            Next
        End If
        If strCodDivision.Trim.Length > 0 Then
            strCodDivision = strCodDivision.Trim.Substring(0, strCodDivision.Trim.Length - 1)
        End If
        Return strCodDivision

    End Function

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
 
        Me.Close()
    End Sub

    Private Sub dtgOperaciones_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgOperaciones.CurrentCellDirtyStateChanged
        If dtgOperaciones.IsCurrentCellDirty Then
            dtgOperaciones.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub
    

    Dim Seleccionado As Boolean = True
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Try
            For Each row As DataGridViewRow In dtgOperaciones.Rows
                row.Cells("chkColumn").Value = Seleccionado
            Next
            dtgOperaciones.EndEdit()
            Seleccionado = Not Seleccionado
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
