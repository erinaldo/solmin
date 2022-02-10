Imports SOLMIN_SC.Negocio
Imports System.Collections
Imports Ransa.Utilitario
Public Class frmRptSegAduanero

    Dim Filtro As New Hashtable()

  Dim objCrep As Object
    Dim objCrepResum As Object
    Private dtResultado As New DataTable
    Private Sub frmRptSegAduanero_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Cargar_Compania()
            cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)

            dtgDatos.AutoGenerateColumns = False
            Me.cmbCliente.pAccesoPorUsuario = True
            Me.cmbCliente.pRequerido = True
            Me.cmbCliente.pUsuario = HelpUtil.UserName
            verGrafico(False)
            CargarFiltroDatos()
            dtpFecIni.Value = Now.AddMonths(-1)
            VisorRep.DisplayStatusBar = True
            VisorRep.DisplayToolbar = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub CargarFiltroDatos()
        Dim dtEstado As New DataTable
        dtEstado.Columns.Add("VALUE")
        dtEstado.Columns.Add("DISPLAY")
        Dim dr As DataRow
        dr = dtEstado.NewRow
        dr("VALUE") = "T"
        dr("DISPLAY") = "::TODOS::"
        dtEstado.Rows.Add(dr)

        dr = dtEstado.NewRow
        dr("VALUE") = "A"
        dr("DISPLAY") = "EN ATENCION"
        dtEstado.Rows.Add(dr)

        dr = dtEstado.NewRow
        dr("VALUE") = "C"
        dr("DISPLAY") = "CERRADOS"
        dtEstado.Rows.Add(dr)

        cboEstado.DataSource = dtEstado
        cboEstado.ValueMember = "VALUE"
        cboEstado.DisplayMember = "DISPLAY"
        cboEstado.SelectedValue = "T"
        cboEstado.Enabled = False

        Dim dtCheckPoint As New DataTable
        dtCheckPoint.Columns.Add("VALUE")
        dtCheckPoint.Columns.Add("DISPLAY")
        Dim drCheck As DataRow
        drCheck = dtCheckPoint.NewRow
        drCheck("VALUE") = "124"
        drCheck("DISPLAY") = "FECHA ENTREGA ALMACEN"
        dtCheckPoint.Rows.Add(drCheck)

        For Each Item As DataRow In dtCheckPoint.Rows
            Item("DISPLAY") = Item("VALUE") & "-" & Item("DISPLAY")
        Next

        cboCheckPoint.DataSource = dtCheckPoint
        cboCheckPoint.ValueMember = "VALUE"
        cboCheckPoint.DisplayMember = "DISPLAY"
        cboCheckPoint.SelectedValue = "124"
        cboCheckPoint.Enabled = False


        Dim oclsEstado As New clsEstado
        Dim dtTipoOperacion As New DataTable
        dtTipoOperacion = oclsEstado.Listar_TipoOperacionEmbarque
        Dim drTipo As DataRow
        drTipo = dtTipoOperacion.NewRow
        drTipo("COD") = "T"
        drTipo("TEX") = "TODOS"
        dtTipoOperacion.Rows.InsertAt(drTipo, 0)
        cboTipoOperacion.DataSource = dtTipoOperacion
        cboTipoOperacion.DisplayMember = "TEX"
        cboTipoOperacion.ValueMember = "COD"
        'cboTipoOperacion.SelectedValue = "T"
        cboTipoOperacion.SelectedValue = "IM"
        cboTipoOperacion.Enabled = False



        Dim odtIdioma As New DataTable
        Dim drIdioma As DataRow
        odtIdioma.Columns.Add("VALUE")
        odtIdioma.Columns.Add("DISPLAY")
        drIdioma = odtIdioma.NewRow
        drIdioma("VALUE") = "ES"
        drIdioma("DISPLAY") = "Español"
        odtIdioma.Rows.Add(drIdioma)

        drIdioma = odtIdioma.NewRow
        drIdioma("VALUE") = "EN"
        drIdioma("DISPLAY") = "Inglés"
        odtIdioma.Rows.Add(drIdioma)

        cboIdioma.DataSource = odtIdioma
        cboIdioma.DisplayMember = "DISPLAY"
        cboIdioma.ValueMember = "VALUE"

        cboIdioma.SelectedValue = "ES"

    End Sub

    Private Sub Cargar_Compania()
        cmbCompania.Usuario = HelpUtil.UserName
        cmbCompania.CCMPN_CompaniaDefault = "EZ"
        cmbCompania.pActualizar()
    End Sub
  
    Private Function GetCompania() As String
        Return cmbCompania.CCMPN_CodigoCompania
    End Function
    Private Function GetDivision(ByVal CCMPN As String) As String
        If CCMPN = "EZ" Then
            Return HelpClass.getSetting("DivisionEZ")
        Else
            Return ""
        End If
    End Function

    Private Function Obtener_Descripcion_Cliente(ByVal CCLNT As Decimal) As String
        Dim dtb As New DataTable
        Dim TCMPCL As String = ""
        dtb = New clsCliente().Obtener_datos_cliente(CCLNT)
        If dtb.Rows.Count > 0 Then
            TCMPCL = Ransa.Utilitario.HelpClass.ToStringCvr(dtb.Rows(0).Item("TCMPCL"))
            TCMPCL = TCMPCL & " - " & Ransa.Utilitario.HelpClass.ToStringCvr(dtb.Rows(0).Item("TMTVBJ"))
        End If
        Return TCMPCL
    End Function

    Private Sub Completa_Cuadro_Aduanero_2010_Espaniol(ByRef pobjRep As rptMenAdn2010Ini, ByVal poDt As DataTable, ByVal pobjRepCont As clsRepContenedor, ByVal pobjRepDes As clsRepDespacho, ByVal pobjRepDesDiv As clsRepDespacho)
        Dim oDtAnt As New DataTable
        Dim oDtNormal As New DataTable
        Dim oDtAereo As New DataTable
        Dim oDtMaritimo As New DataTable
        Dim dblPromAereo As Double = 0
        Dim dblPromMaritimo As Double = 0
        Dim intContAereo As Integer = 0
        Dim intContMaritimo As Integer = 0

        oDtAnt.Columns.Add(New DataColumn("OS", GetType(System.String)))
        oDtAnt.Columns.Add(New DataColumn("DIFATETA", GetType(System.Double)))

        oDtNormal.Columns.Add(New DataColumn("OS", GetType(System.String)))
        oDtNormal.Columns.Add(New DataColumn("DIFATETA", GetType(System.Double)))

        oDtAereo.Columns.Add(New DataColumn("OS", GetType(System.String)))
        oDtAereo.Columns.Add(New DataColumn("QPSOAR", GetType(System.Double)))
        oDtAereo.Columns.Add(New DataColumn("DIFATETA", GetType(System.Double)))

        oDtMaritimo.Columns.Add(New DataColumn("OS", GetType(System.String)))
        oDtMaritimo.Columns.Add(New DataColumn("QPSOAR", GetType(System.Double)))
        oDtMaritimo.Columns.Add(New DataColumn("DIFATETA", GetType(System.Double)))

        Llenar_Tablas(oDtAnt, oDtNormal, oDtAereo, oDtMaritimo, poDt)

        CType(pobjRep.ReportDefinition.ReportObjects("txtDespacho"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = poDt.Rows.Count
        CType(pobjRep.ReportDefinition.ReportObjects("txtA20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.PIES20
        CType(pobjRep.ReportDefinition.ReportObjects("txtA40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.PIES40
        CType(pobjRep.ReportDefinition.ReportObjects("txtAF20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.FLACKPIES20
        CType(pobjRep.ReportDefinition.ReportObjects("txtAF40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.FLACKPIES40
        CType(pobjRep.ReportDefinition.ReportObjects("txtAO20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.OPENPIES20
        CType(pobjRep.ReportDefinition.ReportObjects("txtAO40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.OPENPIES40
        CType(pobjRep.ReportDefinition.ReportObjects("txtAR40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.REEFERPIES40
        CType(pobjRep.ReportDefinition.ReportObjects("txtAI20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.ISOPIES20
        CType(pobjRep.ReportDefinition.ReportObjects("txtAI40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.ISOPIES40
        CType(pobjRep.ReportDefinition.ReportObjects("txtAH20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.HIGHPIES20
        CType(pobjRep.ReportDefinition.ReportObjects("txtAH40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.HIGHPIES40

        CType(pobjRep.ReportDefinition.ReportObjects("txtB20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.PIES20SOBRE
        CType(pobjRep.ReportDefinition.ReportObjects("txtB40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.PIES40SOBRE
        CType(pobjRep.ReportDefinition.ReportObjects("txtBF20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.FLACKPIES20SOBRE
        CType(pobjRep.ReportDefinition.ReportObjects("txtBF40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.FLACKPIES40SOBRE
        CType(pobjRep.ReportDefinition.ReportObjects("txtBO20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.OPENPIES20SOBRE
        CType(pobjRep.ReportDefinition.ReportObjects("txtBO40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.OPENPIES40SOBRE
        CType(pobjRep.ReportDefinition.ReportObjects("txtBR40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.REEFERPIES40SOBRE
        CType(pobjRep.ReportDefinition.ReportObjects("txtBI20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.ISOPIES20SOBRE
        CType(pobjRep.ReportDefinition.ReportObjects("txtBI40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.ISOPIES40SOBRE
        CType(pobjRep.ReportDefinition.ReportObjects("txtBH20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.HIGHPIES20SOBRE
        CType(pobjRep.ReportDefinition.ReportObjects("txtBH40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.HIGHPIES40SOBRE

        If pobjRepCont.PIES20SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtC20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_20PIES
        End If
        If pobjRepCont.PIES40SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtC40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_40PIES
        End If
        If pobjRepCont.FLACKPIES20SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtCF20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_20PIESFLACK
        End If
        If pobjRepCont.FLACKPIES40SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtCF40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_40PIESFLACK
        End If
        If pobjRepCont.OPENPIES20SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtCO20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_20PIESOPEN
        End If
        If pobjRepCont.OPENPIES40SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtCO40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_40PIESOPEN
        End If
        If pobjRepCont.REEFERPIES40SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtCR40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_40PIESREEFER
        End If
        If pobjRepCont.ISOPIES20SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtCI20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_20PIESOPEN
        End If
        If pobjRepCont.ISOPIES40SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtCI40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_40PIESOPEN
        End If
        If pobjRepCont.HIGHPIES20SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtCH20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_20PIESHIGH
        End If
        If pobjRepCont.HIGHPIES40SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtCH40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_40PIESHIGH
        End If

        CType(pobjRep.ReportDefinition.ReportObjects("txtMarA"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Anticipados_Mar
        CType(pobjRep.ReportDefinition.ReportObjects("txtMarC"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Normal_Mar
        CType(pobjRep.ReportDefinition.ReportObjects("txtMarG"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Peso_Mar, "###,###,##0.00")
        CType(pobjRep.ReportDefinition.ReportObjects("txtAerA"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Anticipados_Aer
        CType(pobjRep.ReportDefinition.ReportObjects("txtAerC"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Normal_Aer
        CType(pobjRep.ReportDefinition.ReportObjects("txtAerG"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Peso_Aer, "###,###,##0.00")
        CType(pobjRep.ReportDefinition.ReportObjects("txtTerA"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Anticipados_Ter
        CType(pobjRep.ReportDefinition.ReportObjects("txtTerC"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Normal_Ter
        CType(pobjRep.ReportDefinition.ReportObjects("txtTerG"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Peso_Ter, "###,###,##0.00")

        CType(pobjRep.ReportDefinition.ReportObjects("txtMarB"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Anticipado_Maritimo, "###,###,##0.00")
        CType(pobjRep.ReportDefinition.ReportObjects("txtAerB"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Anticipado_Aereo, "###,###,##0.00")
        CType(pobjRep.ReportDefinition.ReportObjects("txtTerB"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Anticipado_Terrestre, "###,###,##0.00")
        CType(pobjRep.ReportDefinition.ReportObjects("txtMarD"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Normal_Maritimo, "###,###,##0.00")
        CType(pobjRep.ReportDefinition.ReportObjects("txtAerD"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Normal_Aereo, "###,###,##0.00")
        CType(pobjRep.ReportDefinition.ReportObjects("txtTerD"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Normal_Terrestre, "###,###,##0.00")

        CType(pobjRep.ReportDefinition.ReportObjects("txtMarE"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Fuera_Obj_Mar
        CType(pobjRep.ReportDefinition.ReportObjects("txtAerE"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Fuera_Obj_Aer
        CType(pobjRep.ReportDefinition.ReportObjects("txtTerE"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Fuera_Obj_Ter

        ''adicion
        CType(pobjRep.ReportDefinition.ReportObjects("txtMarE_1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDesDiv.Fuera_Obj_Mar
        CType(pobjRep.ReportDefinition.ReportObjects("txtAerE_1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDesDiv.Fuera_Obj_Aer
        CType(pobjRep.ReportDefinition.ReportObjects("txtTerE_1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDesDiv.Fuera_Obj_Ter
        ''adicion

        CType(pobjRep.ReportDefinition.ReportObjects("txtMarF"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Fuera_Obj_Maritimo, "###,###,##0.00")
        CType(pobjRep.ReportDefinition.ReportObjects("txtAerF"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Fuera_Obj_Aereo, "###,###,##0.00")
        CType(pobjRep.ReportDefinition.ReportObjects("txtTerF"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Fuera_Obj_Terrestre, "###,###,##0.00")

    End Sub


    Private Sub Completa_Cuadro_Aduanero_2010_Ingles(ByRef pobjRep As rptMenAdn2010_INGS, ByVal poDt As DataTable, ByVal pobjRepCont As clsRepContenedor, ByVal pobjRepDes As clsRepDespacho, ByVal pobjRepDesDiv As clsRepDespacho)
        Dim oDtAnt As New DataTable
        Dim oDtNormal As New DataTable
        Dim oDtAereo As New DataTable
        Dim oDtMaritimo As New DataTable
        Dim dblPromAereo As Double = 0
        Dim dblPromMaritimo As Double = 0
        Dim intContAereo As Integer = 0
        Dim intContMaritimo As Integer = 0

        oDtAnt.Columns.Add(New DataColumn("OS", GetType(System.String)))
        oDtAnt.Columns.Add(New DataColumn("DIFATETA", GetType(System.Double)))

        oDtNormal.Columns.Add(New DataColumn("OS", GetType(System.String)))
        oDtNormal.Columns.Add(New DataColumn("DIFATETA", GetType(System.Double)))

        oDtAereo.Columns.Add(New DataColumn("OS", GetType(System.String)))
        oDtAereo.Columns.Add(New DataColumn("QPSOAR", GetType(System.Double)))
        oDtAereo.Columns.Add(New DataColumn("DIFATETA", GetType(System.Double)))

        oDtMaritimo.Columns.Add(New DataColumn("OS", GetType(System.String)))
        oDtMaritimo.Columns.Add(New DataColumn("QPSOAR", GetType(System.Double)))
        oDtMaritimo.Columns.Add(New DataColumn("DIFATETA", GetType(System.Double)))

        Llenar_Tablas(oDtAnt, oDtNormal, oDtAereo, oDtMaritimo, poDt)

        CType(pobjRep.ReportDefinition.ReportObjects("txtDespacho"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = poDt.Rows.Count
        CType(pobjRep.ReportDefinition.ReportObjects("txtA20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.PIES20
        CType(pobjRep.ReportDefinition.ReportObjects("txtA40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.PIES40
        CType(pobjRep.ReportDefinition.ReportObjects("txtAF20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.FLACKPIES20
        CType(pobjRep.ReportDefinition.ReportObjects("txtAF40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.FLACKPIES40
        CType(pobjRep.ReportDefinition.ReportObjects("txtAO20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.OPENPIES20
        CType(pobjRep.ReportDefinition.ReportObjects("txtAO40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.OPENPIES40
        CType(pobjRep.ReportDefinition.ReportObjects("txtAR40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.REEFERPIES40
        CType(pobjRep.ReportDefinition.ReportObjects("txtAI20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.ISOPIES20
        CType(pobjRep.ReportDefinition.ReportObjects("txtAI40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.ISOPIES40
        CType(pobjRep.ReportDefinition.ReportObjects("txtAH20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.HIGHPIES20
        CType(pobjRep.ReportDefinition.ReportObjects("txtAH40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.HIGHPIES40

        CType(pobjRep.ReportDefinition.ReportObjects("txtB20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.PIES20SOBRE
        CType(pobjRep.ReportDefinition.ReportObjects("txtB40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.PIES40SOBRE
        CType(pobjRep.ReportDefinition.ReportObjects("txtBF20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.FLACKPIES20SOBRE
        CType(pobjRep.ReportDefinition.ReportObjects("txtBF40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.FLACKPIES40SOBRE
        CType(pobjRep.ReportDefinition.ReportObjects("txtBO20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.OPENPIES20SOBRE
        CType(pobjRep.ReportDefinition.ReportObjects("txtBO40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.OPENPIES40SOBRE
        CType(pobjRep.ReportDefinition.ReportObjects("txtBR40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.REEFERPIES40SOBRE
        CType(pobjRep.ReportDefinition.ReportObjects("txtBI20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.ISOPIES20SOBRE
        CType(pobjRep.ReportDefinition.ReportObjects("txtBI40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.ISOPIES40SOBRE
        CType(pobjRep.ReportDefinition.ReportObjects("txtBH20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.HIGHPIES20SOBRE
        CType(pobjRep.ReportDefinition.ReportObjects("txtBH40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.HIGHPIES40SOBRE

        If pobjRepCont.PIES20SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtC20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_20PIES
        End If
        If pobjRepCont.PIES40SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtC40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_40PIES
        End If
        If pobjRepCont.FLACKPIES20SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtCF20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_20PIESFLACK
        End If
        If pobjRepCont.FLACKPIES40SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtCF40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_40PIESFLACK
        End If
        If pobjRepCont.OPENPIES20SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtCO20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_20PIESOPEN
        End If
        If pobjRepCont.OPENPIES40SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtCO40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_40PIESOPEN
        End If
        If pobjRepCont.REEFERPIES40SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtCR40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_40PIESREEFER
        End If
        If pobjRepCont.ISOPIES20SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtCI20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_20PIESOPEN
        End If
        If pobjRepCont.ISOPIES40SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtCI40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_40PIESOPEN
        End If
        If pobjRepCont.HIGHPIES20SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtCH20"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_20PIESHIGH
        End If
        If pobjRepCont.HIGHPIES40SOBRE > 0 Then
            CType(pobjRep.ReportDefinition.ReportObjects("txtCH40"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepCont.Promedio_40PIESHIGH
        End If

        CType(pobjRep.ReportDefinition.ReportObjects("txtMarA"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Anticipados_Mar
        CType(pobjRep.ReportDefinition.ReportObjects("txtMarC"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Normal_Mar
        CType(pobjRep.ReportDefinition.ReportObjects("txtMarG"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Peso_Mar, "###,###,##0.00")
        CType(pobjRep.ReportDefinition.ReportObjects("txtAerA"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Anticipados_Aer
        CType(pobjRep.ReportDefinition.ReportObjects("txtAerC"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Normal_Aer
        CType(pobjRep.ReportDefinition.ReportObjects("txtAerG"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Peso_Aer, "###,###,##0.00")
        CType(pobjRep.ReportDefinition.ReportObjects("txtTerA"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Anticipados_Ter
        CType(pobjRep.ReportDefinition.ReportObjects("txtTerC"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Normal_Ter
        CType(pobjRep.ReportDefinition.ReportObjects("txtTerG"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Peso_Ter, "###,###,##0.00")

        CType(pobjRep.ReportDefinition.ReportObjects("txtMarB"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Anticipado_Maritimo, "###,###,##0.00")
        CType(pobjRep.ReportDefinition.ReportObjects("txtAerB"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Anticipado_Aereo, "###,###,##0.00")
        CType(pobjRep.ReportDefinition.ReportObjects("txtTerB"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Anticipado_Terrestre, "###,###,##0.00")
        CType(pobjRep.ReportDefinition.ReportObjects("txtMarD"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Normal_Maritimo, "###,###,##0.00")
        CType(pobjRep.ReportDefinition.ReportObjects("txtAerD"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Normal_Aereo, "###,###,##0.00")
        CType(pobjRep.ReportDefinition.ReportObjects("txtTerD"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Normal_Terrestre, "###,###,##0.00")

        CType(pobjRep.ReportDefinition.ReportObjects("txtMarE"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Fuera_Obj_Mar
        CType(pobjRep.ReportDefinition.ReportObjects("txtAerE"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Fuera_Obj_Aer
        CType(pobjRep.ReportDefinition.ReportObjects("txtTerE"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDes.Fuera_Obj_Ter

        ''adicion
        CType(pobjRep.ReportDefinition.ReportObjects("txtMarE_1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDesDiv.Fuera_Obj_Mar
        CType(pobjRep.ReportDefinition.ReportObjects("txtAerE_1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDesDiv.Fuera_Obj_Aer
        CType(pobjRep.ReportDefinition.ReportObjects("txtTerE_1"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = pobjRepDesDiv.Fuera_Obj_Ter
        ''adicion

        CType(pobjRep.ReportDefinition.ReportObjects("txtMarF"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Fuera_Obj_Maritimo, "###,###,##0.00")
        CType(pobjRep.ReportDefinition.ReportObjects("txtAerF"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Fuera_Obj_Aereo, "###,###,##0.00")
        CType(pobjRep.ReportDefinition.ReportObjects("txtTerF"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Format(pobjRepDes.Promedio_Fuera_Obj_Terrestre, "###,###,##0.00")


    End Sub

    Private Sub Llenar_Tablas(ByRef pobjAnt As DataTable, ByRef pobjNormal As DataTable, ByRef pobjAereo As DataTable, ByRef pobjMaritimo As DataTable, ByVal pobjDatos As DataTable)
        Dim intCont As Integer
        Dim oDr As DataRow

        For intCont = 0 To pobjDatos.Rows.Count - 1
            If pobjDatos.Rows(intCont).Item("COD_DESPACHO") = clsRepDespacho.TIPO_DESPACHO.NORMAL Then
                oDr = pobjNormal.NewRow
                oDr.Item("OS") = pobjDatos.Rows(intCont).Item("PNNMOS").ToString.Trim
                oDr.Item("DIFATETA") = pobjDatos.Rows(intCont).Item("DIFATETA").ToString.Trim
                pobjNormal.Rows.Add(oDr)
            Else
                If pobjDatos.Rows(intCont).Item("COD_DESPACHO") = clsRepDespacho.TIPO_DESPACHO.ANTICIPADO Then
                    oDr = pobjAnt.NewRow
                    oDr.Item("OS") = pobjDatos.Rows(intCont).Item("PNNMOS").ToString.Trim
                    oDr.Item("DIFATETA") = pobjDatos.Rows(intCont).Item("DIFATETA").ToString.Trim
                    pobjAnt.Rows.Add(oDr)
                End If
            End If
            If pobjDatos.Rows(intCont).Item("COD_TNMMDT") = clsRepDespacho.MEDIO_TRANSPORTE.AEREO Then
                oDr = pobjAereo.NewRow
                oDr.Item("OS") = pobjDatos.Rows(intCont).Item("PNNMOS").ToString.Trim
                oDr.Item("QPSOAR") = pobjDatos.Rows(intCont).Item("QPSOAR").ToString.Trim
                oDr.Item("DIFATETA") = pobjDatos.Rows(intCont).Item("DIFATETA").ToString.Trim
                pobjAereo.Rows.Add(oDr)
            Else
                If pobjDatos.Rows(intCont).Item("COD_TNMMDT") = clsRepDespacho.MEDIO_TRANSPORTE.MARITIMO Then
                    oDr = pobjMaritimo.NewRow
                    oDr.Item("OS") = pobjDatos.Rows(intCont).Item("PNNMOS").ToString.Trim
                    oDr.Item("QPSOAR") = pobjDatos.Rows(intCont).Item("QPSOAR").ToString.Trim
                    oDr.Item("DIFATETA") = pobjDatos.Rows(intCont).Item("DIFATETA").ToString.Trim
                    pobjMaritimo.Rows.Add(oDr)
                End If
            End If
        Next intCont
    End Sub

    Private Sub cmbCompania_Seleccionar(ByVal obeCompania As Ransa.Controls.UbicacionPlanta.Compania.beCompania) Handles cmbCompania.Seleccionar
        If cmbCompania.CCMPN_CodigoCompania <> cmbCompania.CCMPN_ANTERIOR Then
            VisorRep.ReportSource = Nothing
            cmbCompania.CCMPN_ANTERIOR = cmbCompania.CCMPN_CodigoCompania
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            VisorRep.ReportSource = Nothing
            dtgDatos.DataSource = Nothing
            If cmbCliente.pCodigo = 0 Then
                MessageBox.Show("Debe seleccionar un Cliente", "Aviso", MessageBoxButtons.OK)
                Exit Sub
            End If
            verGrafico(True)
            CargarFiltro()
            bgwProcesoReport.RunWorkerAsync()
        Catch ex As Exception
            verGrafico(False)
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try

    End Sub
    Private Sub verGrafico(ByVal Habilitar As Boolean)
        btnBuscar.Enabled = Not Habilitar
        lblBusqueda.Visible = Habilitar
        lblBusqueda.Text = "..Consultando.."
        pbxBuscar.Visible = Habilitar
        btnExportar.Enabled = Not Habilitar
    End Sub
    Public Sub CargarFiltro()
        Filtro = New Hashtable()
        Filtro.Add("FecIni", Format(Me.dtpFecIni.Value, "yyyyMMdd"))
        Filtro.Add("FecFin", Format(Me.dtpFecFin.Value, "yyyyMMdd"))
        Filtro.Add("Inicio", Format(Me.dtpFecIni.Value, "dd/MM/yyyy"))
        Filtro.Add("Fin", Format(Me.dtpFecFin.Value, "dd/MM/yyyy"))
        Filtro.Add("CCMPN", GetCompania())
        Filtro.Add("pIdioma", cboIdioma.SelectedValue.ToString.Trim)
        Filtro.Add("Cod_Cliente", Me.cmbCliente.pCodigo)
        Filtro.Add("Des_Cliente", Obtener_Descripcion_Cliente(Filtro("Cod_Cliente")))
        Filtro.Add("Mes", Format(Me.dtpFecIni.Value.Month, "00"))
        Filtro.Add("Año", Me.dtpFecIni.Value.AddYears(-1).Year)
        If cboTipoOperacion.SelectedValue = "0" Then
            Filtro.Add("TipoOperacion", "")
        Else
            Filtro.Add("TipoOperacion", cboTipoOperacion.SelectedValue)
        End If
        Filtro.Add("PNNESTDO", cboCheckPoint.SelectedValue)
        Filtro.Add("PSESTADO_EMB", cboEstado.SelectedValue)

    End Sub


    Public Sub CargarFiltroResumido()
        Filtro = New Hashtable()
        Filtro.Add("FecIni", Format(Me.dtpFecIni.Value, "yyyyMMdd"))
        Filtro.Add("FecFin", Format(Me.dtpFecFin.Value, "yyyyMMdd"))
        Filtro.Add("CCMPN", GetCompania)
        Filtro.Add("Inicio", Format(Me.dtpFecIni.Value, "dd/MM/yyyy"))
        Filtro.Add("Fin", Format(Me.dtpFecFin.Value, "dd/MM/yyyy"))
        Filtro.Add("Des_Cliente", Me.cmbCliente.pRazonSocial.ToString.Trim)
        Filtro.Add("Cod_Cliente", Me.cmbCliente.pCodigo)
        If cboTipoOperacion.SelectedValue = "0" Then
            Filtro.Add("TipoOperacion", "")
        Else
            Filtro.Add("TipoOperacion", cboTipoOperacion.SelectedValue)
        End If
        Filtro.Add("PNNESTDO", cboCheckPoint.SelectedValue)
        Filtro.Add("PSESTADO_EMB", cboEstado.SelectedValue)
    End Sub

    Private Sub ReporteResumido()

        Dim dblFecIni, dblFecFin, Cod_Cliente As Double
        Dim PNNESTDO As Decimal = 0
        Dim PSESTADO_EMB As String = ""

        Dim CCMPN As String = Filtro("CCMPN")
        Dim Des_Cliente As String = Filtro("Des_Cliente")
        dblFecIni = Filtro("FecIni")
        dblFecFin = Filtro("FecFin")
        Dim TipoOperacion As String = Filtro("TipoOperacion")
        Cod_Cliente = Filtro("Cod_Cliente")

        PNNESTDO = Filtro("PNNESTDO")
        PSESTADO_EMB = Filtro("PSESTADO_EMB")


        Dim objRep As New clsRepMenSA
        objCrepResum = New rptMenSA
        Dim objDt As DataTable
        Dim objDs As New DataSet
        Dim lstrPeriodo As String
        Dim inicio As String = Filtro("Inicio")
        Dim fin As String = Filtro("Fin")
        lstrPeriodo = inicio & " al " & fin
        objDt = objRep.dtRepMenAD(CCMPN, Des_Cliente, Cod_Cliente, dblFecIni, dblFecFin, lstrPeriodo, TipoOperacion, PNNESTDO, PSESTADO_EMB)

        objDt.TableName = "dtRepMenAdn"
        objDs.Tables.Add(objDt.Copy)
        objCrepResum.SetDataSource(objDs)
        CType(objCrepResum.ReportDefinition.ReportObjects("txtTitulo"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "SEGUIMIENTO ADUANERO " & lstrPeriodo.Trim

    End Sub

    Private Sub ReporteFormatoExtendido()

        Dim dblFecIni, dblFecFin, Cod_Cliente As Double
        Dim PNNESTDO As Decimal = 0
        Dim PSESTADO_EMB As String = ""
        Dim CCMPN As String = Filtro("CCMPN")
        Cod_Cliente = Filtro("Cod_Cliente")
        dblFecIni = Filtro("FecIni")
        dblFecFin = Filtro("FecFin")
        Dim inicio As String = Filtro("Inicio")
        Dim fin As String = Filtro("Fin")
        Dim pIdioma As String = Filtro("pIdioma")
        Dim Des_Cliente As String = Filtro("Des_Cliente")
        Dim TipoOperacion As String = Filtro("TipoOperacion")
        Dim Mes, Año As Integer
        Mes = Filtro("Mes")
        Año = Filtro("Año")
        PNNESTDO = Filtro("PNNESTDO")
        PSESTADO_EMB = Filtro("PSESTADO_EMB")



        '=====Declaro apra Envio de parametro====
        Dim crParameterDiscreteValue As CrystalDecisions.Shared.ParameterDiscreteValue
        Dim crParameterFieldDefinitions As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinitions
        Dim crParameterFieldLocation As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinition
        Dim crParameterValues As CrystalDecisions.Shared.ParameterValues
        '=====Declaro Variables=====

        Dim objRep As New clsRepMenAdn
        objCrep = New Object
        dtResultado.Rows.Clear()

        Dim objDtRegimen As New DataTable
        Dim objDs As New DataSet
        Dim lstrPeriodo As String
        '====Rango Fecha====
        Select Case pIdioma
            Case "EN"
                lstrPeriodo = "From " & inicio & " To " & fin
                objCrep = New rptMenAdn2010_INGS
            Case "ES"
                lstrPeriodo = "Entrega Almacén Desde " & inicio & " al " & fin
                objCrep = New rptMenAdn2010Ini
        End Select

        Dim dtResultRegimen As New DataTable
        dtResultado = objRep.dtRepMenAduanero(CCMPN, pIdioma, Des_Cliente, Cod_Cliente, dblFecIni, dblFecFin, Format(CType("01" & "/" & Mes & "/" & Año, Date), "yyyyMMdd"), TipoOperacion, PNNESTDO, PSESTADO_EMB)
        dtResultado.TableName = "dtRepMenSA"
        objDs.Tables.Add(dtResultado.Copy)
        '====Segundo Datatable (Entidad)====
        dtResultRegimen = objRep.TotalRegimen
        dtResultRegimen.TableName = "dtTotalRegimen"
        objDs.Tables.Add(dtResultRegimen.Copy)


        objDtRegimen = objRep.dtRegimen.Copy
        For Each Item As DataRow In objDtRegimen.Rows
            If Item("Codigo") = 0 Then
                Item("Regimen") = "INDEFINITE"
            End If
        Next
        objDtRegimen.TableName = "dtReRegimen"

        Dim numFilas As Int32 = 0
        numFilas = objDtRegimen.Rows.Count - 1
        For FILA As Integer = 0 To numFilas
            If (numFilas >= FILA) Then
                If (objDtRegimen.Rows(FILA)("Cantidad")) = 0 Then
                    objDtRegimen.Rows(FILA).Delete()
                    numFilas = numFilas - 1
                    FILA = FILA - 1
                End If
            End If
        Next
        objDtRegimen.AcceptChanges()
        '====Creamos Objeto RPT
        objCrep.SetDataSource(objDs)
        objCrep.Subreports.Item("rptDiferenciaDias").SetDataSource(objDs.Tables(0))

        objCrep.Subreports.Item("rptSub_Regimen").SetDataSource(objDtRegimen)
        '====Enviamos Parametro al Reporte====
        '---PARA LOS DIAS ALMACEN---
        Dim objDiasAlmacenNeg As New SOLMIN_SC.Negocio.clsTipoDato
        Dim objDiasAlmacen As New SOLMIN_SC.Entidad.beTipoDato
        objDiasAlmacen.PNNTPODT = 29
        '---PARA LOS DIAS ALMACEN---
        objDiasAlmacenNeg.Crea_DetalleTipoDato(objDiasAlmacen)
        CType(objCrep.ReportDefinition.ReportObjects("txtPeriodo"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = lstrPeriodo
        CType(objCrep.ReportDefinition.ReportObjects("txtMarTierra"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objDiasAlmacenNeg.RetornaDiasAlmacen("MARITIMO", cmbCliente.pCodigo)
        CType(objCrep.ReportDefinition.ReportObjects("txtAire"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = objDiasAlmacenNeg.RetornaDiasAlmacen("AEREO", cmbCliente.pCodigo)
        '====Completa Cuadro Aduanero 2010 (Envio por parametros de variables)====

        Select Case pIdioma
            Case "EN"
                Completa_Cuadro_Aduanero_2010_Ingles(objCrep, objDs.Tables("dtRepMenSA").Copy, objRep.Contenedores, objRep.Despachos, objRep.RepDespacho_Div_FueraObj)
            Case "ES"
                Completa_Cuadro_Aduanero_2010_Espaniol(objCrep, objDs.Tables("dtRepMenSA").Copy, objRep.Contenedores, objRep.Despachos, objRep.RepDespacho_Div_FueraObj)
        End Select

        '====Oculta Seccion Condición====
        crParameterFieldDefinitions = objCrep.DataDefinition.ParameterFields
        crParameterFieldLocation = crParameterFieldDefinitions.Item("@Chktiempo")
        crParameterValues = crParameterFieldLocation.CurrentValues
        crParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        crParameterDiscreteValue.Value = chkTiempo.Checked.ToString
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldLocation.ApplyCurrentValues(crParameterValues)

    End Sub

    Private Sub bgwProcesoReport_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwProcesoReport.DoWork
        ReporteFormatoExtendido()
        ReporteResumido()
    End Sub



    Private Sub bgwProcesoReport_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwProcesoReport.RunWorkerCompleted
        Try
            VisorRep.ReportSource = objCrep
            VisorRepResumen.ReportSource = objCrepResum
            Dim dtDatos As New DataTable
            Dim dtDatosDif As New DataTable
            dtDatos = dtResultado.Copy
            dtDatosDif = dtResultado.Copy
            dtgDatos.DataSource = dtDatosDif
            verGrafico(False)
        Catch ex As Exception
            verGrafico(False)
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TabResultado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabResultado.SelectedIndexChanged
        Dim NameTab As String = TabResultado.SelectedTab.Name
        Try
            Select Case NameTab
                Case "TabDatos"
                    btnExportar.Visible = True
                Case "TabReporte"
                    btnExportar.Visible = False
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Try
            If dtgDatos.Rows.Count = 0 Then
                Exit Sub
            End If
            Dim NPOI_SC As New HelpClass_NPOI_SC
            Dim lstrPeriodo As String = ""
            Dim dtExport As New DataTable
            Dim ColName As String = ""
            Dim ColCaption As String = ""
            Dim MdataColumna As String = ""

            Dim TableName As String = ""
            Dim ColTitle As String = ""
            Dim TipoDato As String = ""

            For Each Item As DataGridViewColumn In dtgDatos.Columns
                ColTitle = Item.HeaderText.Trim
                ColName = Item.DataPropertyName
                Select Case ColName
                    Case "ADVALOREM", "IGVPM", "OGASTOS", "TOTDER"
                        ColTitle = "Pago de Derecho |" & ColTitle
                End Select
                TipoDato = ""
                Select Case ColName
                    'NUMEROS
                    Case "NBLTAR", "NCONTEN", "QPSOAR", "EXW", _
                        "GFOB", "FOB", "FLETE", "SEGURO", "CIF", _
                          "ADVALOREM", "IGVPM", "OGASTOS", "TOTDER", _
                         "DIFATETA", "DIFDOCUMENTOS", "DIFNUMERACION", _
                        "DIFDERECHOS", "DIF_DOCCOMPLETO_NUMERACION", "DIF_PAGODERECHO_ENTREGAALM", "M3"
                        TipoDato = NPOI_SC.keyDatoNumero
                        'FECHAS
                    Case "FDCCMP", "FAPRAR", "FECALM", "DOCUMENTOS", "NUMERACION", "DERECHOS", "LEVANTE"
                        TipoDato = NPOI_SC.keyDatoFecha
                    Case Else
                        'TEXTO
                        TipoDato = NPOI_SC.keyDatoTexto
                End Select
                dtExport.Columns.Add(ColName)
                MdataColumna = NPOI_SC.FormatDato(ColTitle, TipoDato)
                dtExport.Columns(ColName).Caption = MdataColumna
            Next
            Dim dr As DataRow
            For Fila As Integer = 0 To dtgDatos.Rows.Count - 1
                dr = dtExport.NewRow
                For Columna As Integer = 0 To dtExport.Columns.Count - 1
                    ColName = dtExport.Columns(Columna).ColumnName
                    If (dtgDatos.Rows(Fila).Cells(ColName).Value IsNot Nothing) Then
                        If dtgDatos.Rows(Fila).Cells("NORSCI").Value = 20331 Then
                            Dim S As String = 20331
                        End If
                        If ColName = "NORCML" Then
                            dr(ColName) = FormatoOC(dtgDatos.Rows(Fila).Cells(ColName).FormattedValue, 5)
                        Else
                            dr(ColName) = dtgDatos.Rows(Fila).Cells(ColName).FormattedValue
                        End If
                    End If
                Next
                dtExport.Rows.Add(dr)
            Next
            'Dim oLisParametros As New SortedList
            'Dim ListColNFilas As String = "NORCML"
            'oLisParametros(0) = "Cliente:|" & cmbCliente.pCodigo & "-" & cmbCliente.pRazonSocial
            'oLisParametros(1) = "Entrega Almacén Desde  | " & Me.dtpFecIni.Value.ToShortDateString & " al " & Me.dtpFecFin.Value.ToShortDateString
            'Dim Titulo As String = "ACTIVIDAD MENSUAL ADUANAS"
            'HelpClass_NPOI_SC.ExportExcelGeneralRelease(dtExport, Titulo, ListColNFilas, oLisParametros)

            Dim ListaDatatable As New List(Of DataTable)
            ListaDatatable.Add(dtExport.Copy)

            Dim LisFiltros As New List(Of SortedList)
            Dim itemSortedList As SortedList

            itemSortedList = New SortedList
            itemSortedList.Add(itemSortedList.Count, "Cliente:|" & cmbCliente.pCodigo & "-" & cmbCliente.pRazonSocial)
            itemSortedList.Add(itemSortedList.Count, "Entrega Almacén Desde  | " & Me.dtpFecIni.Value.ToShortDateString & " al " & Me.dtpFecFin.Value.ToShortDateString)
            LisFiltros.Add(itemSortedList)

            Dim ListTitulo As New List(Of String)
            ListTitulo.Add("ACTIVIDAD MENSUAL ADUANAS")

            NPOI_SC.ExportExcelGeneralReleaseMultiple(ListaDatatable, ListTitulo, Nothing, LisFiltros, 0, Nothing)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function FormatoOC(ByVal OC As String, ByVal numOCFila As Int32) As String
        Dim norcml As String = ""
        Dim cadOC() As String
        cadOC = OC.Split(",")
        Dim sbNorcml As New System.Text.StringBuilder
        Dim strNorcmlFormat As String = ""
        Dim x As Int32 = 1
        For FILA As Integer = 0 To cadOC.Length - 1
            If x <= numOCFila Then
                sbNorcml.Append(cadOC(FILA))
                sbNorcml.Append(",")
            Else
                sbNorcml.Append(Chr(10))
                ' sbNorcml.Append(",")
                sbNorcml.Append(cadOC(FILA))
                x = 0
                If x = 0 Then
                    sbNorcml.Append(",")
                End If
            End If
            x = x + 1
        Next
        strNorcmlFormat = sbNorcml.ToString.Trim
        Dim a As String = ""
        strNorcmlFormat = strNorcmlFormat.Substring(0, strNorcmlFormat.LastIndexOf(","))
        Return strNorcmlFormat
    End Function


 
   
End Class
