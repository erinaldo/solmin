Imports SOLMIN_SC.Entidad
Imports SOLMIN_SC.Negocio
Imports System.Web
Imports System.Threading
Imports System.Text
Imports Ransa.Utilitario

Public Class frmListaColumna
    Enum TipoCopia
        ColumnaCliente
        ColumnaTodos
    End Enum
    Private _pTipoCopia As TipoCopia = TipoCopia.ColumnaTodos
    Private isCheck As Boolean = False
    Public Property pTipoCopia() As TipoCopia
        Get
            Return _pTipoCopia
        End Get
        Set(ByVal value As TipoCopia)
            _pTipoCopia = value
        End Set
    End Property

    Private _pCCLNT As Decimal = 0
    Public Property pCCLNT() As Decimal
        Get
            Return _pCCLNT
        End Get
        Set(ByVal value As Decimal)
            _pCCLNT = value
        End Set
    End Property

    Private _pCCMPN As String = ""
    Public Property pCCMPN() As String
        Get
            Return _pCCMPN
        End Get
        Set(ByVal value As String)
            _pCCMPN = value
        End Set
    End Property

    Private Sub Cargar_Compania()
        cmbCompania.Usuario = HelpUtil.UserName
        cmbCompania.CCMPN_CompaniaDefault = "EZ"
        cmbCompania.pActualizar()
    End Sub

    Private Sub LlenarDatos()
        dtgColumna.DataSource = Nothing
        Dim oDt As New DataTable
        Dim oTableroDatos As New clsTableroDatos
        oDt = oTableroDatos.Llenar_Tabla_X_Opcion(cmbCompania.CCMPN_CodigoCompania, cmbCliente.pCodigo, "A", 1, "")
        dtgColumna.DataSource = oDt
    End Sub

    

    Private Sub frmListaColumna_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            dtgColumna.AutoGenerateColumns = False
            Me.cmbCliente.pAccesoPorUsuario = True
            Me.cmbCliente.pRequerido = True
            Me.cmbCliente.pUsuario = HelpUtil.UserName
            Cargar_Compania()
            cmbCompania.HabilitarCompaniaActual(Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
            Select Case _pTipoCopia
                Case TipoCopia.ColumnaCliente
                    headerFiltroCliente.Visible = True
                    dtgColumna.DataSource = Nothing
                Case TipoCopia.ColumnaTodos
                    Dim oclsEmbarque As New clsEmbarque
                    Dim odtCampos As New DataTable
                    Dim oDrVw As DataGridViewRow
                    Dim Fila As Int32 = 0
                    odtCampos = oclsEmbarque.Lista_Campos_Embarque()
                    dtgColumna.Rows.Clear()
                    For Fila = 0 To odtCampos.Rows.Count - 1
                        oDrVw = New DataGridViewRow
                        oDrVw.CreateCells(Me.dtgColumna)
                        dtgColumna.Rows.Add(oDrVw)
                        Fila = dtgColumna.Rows.Count - 1
                        dtgColumna.Rows(Fila).Cells("NMRCRL").Value = 0
                        dtgColumna.Rows(Fila).Cells("TNMBCM").Value = ("" & odtCampos.Rows(Fila)("VALVAR")).ToString.Trim
                        dtgColumna.Rows(Fila).Cells("NSEPRE").Value = 100
                        dtgColumna.Rows(Fila).Cells("TCOLUM").Value = ("" & odtCampos.Rows(Fila)("NOMVAR")).ToString.Trim
                        dtgColumna.Rows(Fila).Cells("TDITIN").Value = ("" & odtCampos.Rows(Fila)("NOMVAR")).ToString.Trim
                        dtgColumna.Rows(Fila).Cells("STPCRE").Value = "S"
                        dtgColumna.Rows(Fila).Cells("QANCOL").Value = 100
                    Next
                    headerFiltroCliente.Visible = False
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
    End Sub
    Private Function GetDivision(ByVal CCMPN As String) As String
        If CCMPN = "EZ" Then
            Return HelpUtil.getSetting("DivisionEZ")
        Else
            Return ""
        End If
    End Function

  Private Sub tsbAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAceptar.Click
    Try
      Dim oTableroDatos As New clsTableroDatos
      Dim obeCampoReporte As beTrableroDatos
      dtgColumna.EndEdit()
      Dim PSCDVSN As String = GetDivision(_pCCMPN)
      For Each Item As DataGridViewRow In dtgColumna.Rows
        If Item.Cells("CHK_COLUMNA").Value IsNot Nothing Then
          If Item.Cells("CHK_COLUMNA").Value = True Then
            obeCampoReporte = New beTrableroDatos
            obeCampoReporte.PSCCMPN = _pCCMPN
            obeCampoReporte.PSCDVSN = PSCDVSN
            obeCampoReporte.PNCCLNT = _pCCLNT
            obeCampoReporte.PSTNMBCM = Item.Cells("TNMBCM").Value
            obeCampoReporte.PNNSEPRE = Item.Cells("NSEPRE").Value
            obeCampoReporte.PSTCOLUM = Item.Cells("TCOLUM").Value
            obeCampoReporte.PSTDITIN = Item.Cells("TDITIN").Value
            obeCampoReporte.PSSTPCRE = Item.Cells("STPCRE").Value
            obeCampoReporte.PNQANCOL = Item.Cells("QANCOL").Value
            oTableroDatos.Insertar_Columna_Embarque(obeCampoReporte)
          End If
        End If
      Next
      Me.DialogResult = Windows.Forms.DialogResult.OK
      Me.Close()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
    End Try
  End Sub

    Private Sub Poner_Check_Todo(ByVal blnEstado As Boolean)
        Dim intCont As Integer
        For intCont = 0 To dtgColumna.RowCount - 1
            dtgColumna.Rows(intCont).Cells("CHK_COLUMNA").Value = blnEstado
        Next
    End Sub


    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    Try
      LlenarDatos()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
    End Try
  End Sub

    Private Sub btnChecks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChecks.Click
        Try
            dtgColumna.EndEdit()
            isCheck = Not isCheck
            If isCheck = True Then
                btnChecks.Image = My.Resources.btnMarcarItems
            Else
                btnChecks.Image = My.Resources.btnNoMarcarItems
            End If
            Poner_Check_Todo(isCheck)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK)
        End Try
    End Sub
End Class
