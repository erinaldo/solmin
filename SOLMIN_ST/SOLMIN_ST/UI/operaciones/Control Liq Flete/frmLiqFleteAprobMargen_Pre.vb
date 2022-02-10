Imports SOLMIN_ST.NEGOCIO.operaciones
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports SOLMIN_ST.NEGOCIO
Imports Ransa.TypeDef.Transportista
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmLiqFleteAprobMargen_Pre

#Region " Atributos "
    Private bolBuscar As Boolean
    Public Objeto_Entidad_Guia As New GuiaTransportista
    Private lintEstadoOpcion As Integer = 0
#End Region

#Region " Métodos y Funciones "

    
    Private Sub Cargar_Compania()
        cmbCompania.Usuario = MainModule.USUARIO
        cmbCompania.pActualizar()
        cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
    End Sub

    Private Sub cmbCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.Seleccionar
        Try
            cmbDivision.Usuario = MainModule.USUARIO
            cmbDivision.Compania = obeCompania.CCMPN_CodigoCompania
            cmbDivision.DivisionDefault = "T"
            cmbDivision.pActualizar()
            If (cmbCompania.CCMPN_ANTERIOR <> cmbCompania.CCMPN_CodigoCompania) Then
                cmbCompania.CCMPN_ANTERIOR = cmbCompania.CCMPN_CodigoCompania
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    

   

    Private Sub Limpiar_Controles()
        Me.gwdDatos.DataSource = Nothing
        Me.dtGRemCargGTransLiq.DataSource = Nothing
    End Sub

    Private Sub Listar_Guias_Transportista()
        Dim Objeto_Logica As New GuiaTransportista_BLL

        Dim oLiquidacionGT As New TD_Obj_LiquidacionGuiaRemision
        oLiquidacionGT.pClear()
        With oLiquidacionGT
            .pCCMPN_Compania = Me.cmbCompania.CCMPN_CodigoCompania
            .pCDVSN_Division = Me.cmbDivision.Division
            .pTIPVIAJ = Me.cboTipo.SelectedValue
            .pNROVIAJ = IIf(Me.txtNroOperacion.Text.Trim = "", "0", Me.txtNroOperacion.Text.Trim)
        End With
        Me.gwdDatos.DataSource = Objeto_Logica.Listar_Operacion_Pendiente_Aprobacion_MRG(oLiquidacionGT)

  
 

    End Sub

    Private Sub Listar_GRemCargadasGTranspLiq_Operacion()
        Dim oFiltro As New TD_obj_ListarServicioXViaje
        Dim oGuiaTransportista As New GuiaTransportista_BLL
        Dim dt As DataTable
        oFiltro.pClear()
        With oFiltro
            .pCCMPN = Me.cmbCompania.CCMPN_CodigoCompania
            .pCDVSN = Me.cmbDivision.Division
            .pCTRMNC = Me.gwdDatos.CurrentRow.Cells("CTRMNC").Value
            .pNGUITR = Me.gwdDatos.CurrentRow.Cells("NGUIRM").Value
            .pTIPVIAJ = Me.cboTipo.SelectedValue
            .pNROVIAJ = IIf((Me.gwdDatos.CurrentRow.Cells("NOPRCN").Value).ToString = "", 0, (Me.gwdDatos.CurrentRow.Cells("NOPRCN").Value).ToString)
        End With

        dt = oGuiaTransportista.Listar_ServicioXViaje(oFiltro)
        Me.dtGRemCargGTransLiq.AutoGenerateColumns = False
        Me.dtGRemCargGTransLiq.DataSource = dt


       
    End Sub

   

    

    Private Function Validar_Datos_Filtro() As Boolean
        Dim lstr_validacion As String = ""
        Dim lbool_existe_error As Boolean = False

        If cmbCompania.CCMPN_CodigoCompania = "" Then
            lstr_validacion += "* COMPAÑIA " & Chr(13)
        End If
        If Me.cmbDivision.Division = "" Then
            lstr_validacion += "* DIVISION" & Chr(13)
        End If
      
        If lstr_validacion <> "" Then
            HelpClass.MsgBox("DEBE DE INGRESAR :" & Chr(13) & lstr_validacion)
            lbool_existe_error = True
        End If
        Return lbool_existe_error
    End Function

   



#End Region



    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Buscar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub Buscar()
        If Me.Validar_Datos_Filtro = True Then Exit Sub
        Me.Limpiar_Controles()
        Me.Listar_Guias_Transportista()
    End Sub

    

    Private Sub frmLiqFleteAprobMargen_Pre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            bolBuscar = False
            gwdDatos.AutoGenerateColumns = False

            Me.Cargar_Compania()
            Me.Cargar_Tipo()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    

    Private Sub btnAprobar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAprobar.Click
        Try
            If Me.gwdDatos.CurrentCellAddress.Y = -1 Then Exit Sub
            Dim oucfrmAprobarFlete As New ucfrmAprobarFlete()

            oucfrmAprobarFlete.AprobSugerido = Me.gwdDatos.CurrentRow.Cells("APRBSG").Value
            oucfrmAprobarFlete.MrgAprobacion = Me.gwdDatos.CurrentRow.Cells("MRGVAL").Value
            oucfrmAprobarFlete.CodCompania = Me.cmbCompania.CCMPN_CodigoCompania
            oucfrmAprobarFlete.CodDivision = Me.cmbDivision.Division
            oucfrmAprobarFlete.codTransportista = Me.gwdDatos.CurrentRow.Cells("CTRMNC").Value
            oucfrmAprobarFlete.GuiaTransporte = Me.gwdDatos.CurrentRow.Cells("NGUIRM").Value
            oucfrmAprobarFlete.TipoViaje = Me.gwdDatos.CurrentRow.Cells("TIPO_VJE").Value
            oucfrmAprobarFlete.NroViaje = gwdDatos.CurrentRow.Cells("NOPRCN").Value
            If oucfrmAprobarFlete.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Buscar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnRechazar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRechazar.Click
        Try
            If Me.gwdDatos.CurrentCellAddress.Y = -1 Then Exit Sub
            Dim oFiltro As New TD_obj_ActualizarStatusSeguinientoAprobacion
            Dim oGuiaTransportista As New GuiaTransportista_BLL
            If MessageBox.Show("Está seguro cancelar envío?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If

            With oFiltro
                .pCCMPN = Me.cmbCompania.CCMPN_CodigoCompania

                .pCTRMNC = Me.gwdDatos.CurrentRow.Cells("CTRMNC").Value
                .pNGUITR = Me.gwdDatos.CurrentRow.Cells("NGUIRM").Value
                .pTIPVIAJ = Me.gwdDatos.CurrentRow.Cells("TIPO_VJE").Value
                .pNROVIAJ = gwdDatos.CurrentRow.Cells("NOPRCN").Value
               
            End With

            oGuiaTransportista.Cancelar_Envio_Aprobacion_Viaje(oFiltro)
            MessageBox.Show("Envío cancelado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Buscar()
           

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        


    End Sub
    Private Sub Cargar_Tipo()

        Dim dtTipo As New DataTable
        dtTipo.Columns.Add("DISPLAY")
        dtTipo.Columns.Add("VALUE")
        Dim dr As DataRow

        dr = dtTipo.NewRow
        dr("DISPLAY") = "Exclusivo"
        dr("VALUE") = "E"
        dtTipo.Rows.Add(dr)

        cboTipo.DataSource = dtTipo
        cboTipo.DisplayMember = "DISPLAY"
        cboTipo.ValueMember = "VALUE"
        cboTipo.SelectedValue = "E"

    End Sub


    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        Try
            If Me.gwdDatos.RowCount = 0 Then Exit Sub
            Dim dtGrid As New DataGridView
            dtGrid = Me.gwdDatos
            Dim strlTitulo As String
            Dim strlFiltros As New List(Of String)
            strlTitulo = "Lista de pendientes de aprobación"
          
            Ransa.Utilitario.HelpClass.ExportExcelConTitulos(dtGrid, strlTitulo, strlFiltros)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub gwdDatos_SelectionChanged(sender As Object, e As EventArgs) Handles gwdDatos.SelectionChanged
        Try
            If Me.gwdDatos.CurrentCellAddress.Y = -1 Then Exit Sub
            Me.Listar_GRemCargadasGTranspLiq_Operacion()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAdjuntar_Click(sender As Object, e As EventArgs) Handles btnAdjuntar.Click
        Try
            If gwdDatos.CurrentRow Is Nothing Then
                Exit Sub
            End If
            Dim ofrmCargaAdjuntos As New StorageFileManager.frmCargaAdjuntos
            ofrmCargaAdjuntos.pCarpetaBucketDestino = System.Configuration.ConfigurationManager.AppSettings("bucketDestino").ToString
            ofrmCargaAdjuntos.pCodCompania = gwdDatos.CurrentRow.Cells("CCMPN").Value
            ofrmCargaAdjuntos.pAsignarCargaMotivo("RZTR05", "02")
            ofrmCargaAdjuntos.pNroImagen = gwdDatos.CurrentRow.Cells("NMRGIM").Value
            ofrmCargaAdjuntos.pNroImagenGetUltimo = True
            ofrmCargaAdjuntos.pTablaRelacions = StorageFileManager.frmCargaAdjuntos.Tabla_Relacion.RZTR05
            Dim CodCompania As String = gwdDatos.CurrentRow.Cells("CCMPN").Value
            Dim NroOperacion As String = gwdDatos.CurrentRow.Cells("NOPRCN").Value
            ofrmCargaAdjuntos.pAsignar_ParametroTablaRelacion_RZTR05(CodCompania, NroOperacion)
            ofrmCargaAdjuntos.ShowDialog()

            If ofrmCargaAdjuntos.pDialog = True Then
                gwdDatos.CurrentRow.Cells("NMRGIM").Value = ofrmCargaAdjuntos.pNroImagen
                If ofrmCargaAdjuntos.pNroImagen > 0 Then
                    gwdDatos.CurrentRow.Cells("NMRGIM_IMG").Value = "X"
                Else
                    gwdDatos.CurrentRow.Cells("NMRGIM_IMG").Value = ""
                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
