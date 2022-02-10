Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos

Public Class frmLiquidacionFlete_DlgMostrarGuiasRem
#Region " Atributos "
    Private pCTRMNC As Int32 = 0
    Private pNGUIRM As Int64 = 0
    Private pNRGUCL As Int64 = 0
    Private pFCGUCL As Date
    Private pLSTGRE As String = ""
    Private pCCMPN As String = ""
    Private pNGUIRS As String = ""
#End Region
#Region " Propiedades "
    Public ReadOnly Property pGuiaRemPrincipal() As Int64
        Get
            Return pNRGUCL
        End Get
    End Property


    Public ReadOnly Property pGuiaRemPrincipalTxt() As String
        Get
            Return pNGUIRS
        End Get
    End Property

 
    Public ReadOnly Property pFechaGuiaPrincipal() As Date
        Get
            Return pFCGUCL
        End Get
    End Property

    Public ReadOnly Property pListaGuiasHijas() As String
        Get
            Return pLSTGRE
        End Get
    End Property
 
#End Region
#Region " Procedimientos y Funciones "
    Private Sub Listar_GRemPendientesGTranspLiq()
        Dim Objeto_Logica As New GuiaTransportista_BLL
        Dim oGuiaTransportistaPK As New TD_GuiaTransportistaPK
        'Dim dwvrow As DataGridViewRow

        'LIMPIANDO EL dtgGuiasPendientes
        'Me.dtgGuiasPendientes.Rows.Clear()

        oGuiaTransportistaPK.pCTRMNC_CodigoTransportista = pCTRMNC
        oGuiaTransportistaPK.pNGUIRM_NroGuiaTransportista = pNGUIRM
        oGuiaTransportistaPK.pCCMPN_Ccompania = pCCMPN


        dtgGuiasPendientes.DataSource = Objeto_Logica.Listar_GRemPendientesGTranspLiquidacion(oGuiaTransportistaPK)

        'LLENANDO EL dtgGuiasPendientes
        'For Each objEntidad As TD_Obj_GuiaRemisionGTransp In Objeto_Logica.Listar_GRemPendientesGTranspLiquidacion(oGuiaTransportistaPK)
        '    dwvrow = New DataGridViewRow
        '    dwvrow.CreateCells(Me.dtgGuiasPendientes)
        '    dwvrow.Cells(0).Value = objEntidad.pNGUIRM_NroGuiaTransportista
        '    dwvrow.Cells(1).Value = objEntidad.pNRGUCL_NroGuiaRemision
        '    dwvrow.Cells(2).Value = objEntidad.pTCMPCL_RazonSocialCliente
        '    dwvrow.Cells(3).Value = objEntidad.pFCGUCL_FechaGuiaRemision
        '    dwvrow.Cells(4).Value = objEntidad.pCCLNT_CodigoCliente
        '    Me.dtgGuiasPendientes.Rows.Add(dwvrow)
        'Next

        If dtgGuiasPendientes.RowCount <= 0 Then
            btnAceptar.Enabled = False
        End If
    End Sub
#End Region
#Region " Eventos "
    'Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

    '    Try
    '        Dim iCont As Int32 = 0
    '        ' Seteamos el DialogResult
    '        Me.DialogResult = Windows.Forms.DialogResult.OK
    '        ' Seteamos las variables
    '        pNRGUCL = dtgGuiasPendientes.CurrentRow.Cells("NRGUCL").Value
    '        pFCGUCL = dtgGuiasPendientes.CurrentRow.Cells("FCGUCL").Value

    '        dtgGuiasPendientes.AutoGenerateColumns = False
    '        ' Bucle para obtener todas las demás guías de remisión
    '        With dtgGuiasPendientes
    '            pLSTGRE = ""
    '            While iCont < .RowCount
    '                If pNRGUCL = 0 Then
    '                    pNRGUCL = .Rows(iCont).Cells("NRGUCL").Value
    '                    pFCGUCL = .Rows(iCont).Cells("FCGUCL").Value
    '                    pNGUIRS = ("" & .Rows(iCont).Cells("NGUIRS").Value).ToString.Trim
    '                Else
    '                    If .Rows(iCont).Cells("NRGUCL").Value <> pNRGUCL Then
    '                        If pLSTGRE <> "" Then pLSTGRE = pLSTGRE & ","
    '                        pLSTGRE = pLSTGRE & .Rows(iCont).Cells("NRGUCL").Value
    '                    End If
    '                End If
    '                iCont += 1
    '            End While
    '        End With
    '        Me.Close()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try


    'End Sub

    'Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    '    ' Seteamos el DialogResult
    '    Me.DialogResult = Windows.Forms.DialogResult.Cancel
    '    ' Limpiamos las variables
    '    pNRGUCL = 0
    '    pLSTGRE = ""
    '    Me.Close()
    'End Sub

    Private Sub frmLiquidacionFlete_DlgMostrarGuiasRem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dtgGuiasPendientes.AutoGenerateColumns = False
            Call Listar_GRemPendientesGTranspLiq()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'For lint_contador As Integer = 0 To Me.dtgGuiasPendientes.ColumnCount - 1
        '    Me.dtgGuiasPendientes.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        'Next

    End Sub
#End Region
#Region " Métodos "
    Sub New(ByVal EmpTransporte As Int32, ByVal NroGuiaTransportista As Int64, ByVal strCompania As String)
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        pCTRMNC = EmpTransporte
        pNGUIRM = NroGuiaTransportista
        pCCMPN = strCompania
    End Sub
#End Region

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Try
            ' Seteamos el DialogResult
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            ' Limpiamos las variables
            pNRGUCL = 0
            pLSTGRE = ""
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        Try
            Dim iCont As Int32 = 0
            ' Seteamos el DialogResult
            Me.DialogResult = Windows.Forms.DialogResult.OK
            ' Seteamos las variables
            pNRGUCL = dtgGuiasPendientes.CurrentRow.Cells("NRGUCL").Value
            pFCGUCL = dtgGuiasPendientes.CurrentRow.Cells("FCGUCL").Value
            pNGUIRS = ("" & dtgGuiasPendientes.CurrentRow.Cells("NGUIRS").Value).ToString.Trim

            dtgGuiasPendientes.AutoGenerateColumns = False
            ' Bucle para obtener todas las demás guías de remisión
            With dtgGuiasPendientes
                pLSTGRE = ""
                While iCont < .RowCount
                    If pNRGUCL = 0 Then
                        pNRGUCL = .Rows(iCont).Cells("NRGUCL").Value
                        pFCGUCL = .Rows(iCont).Cells("FCGUCL").Value

                    Else
                        If .Rows(iCont).Cells("NRGUCL").Value <> pNRGUCL Then
                            If pLSTGRE <> "" Then pLSTGRE = pLSTGRE & ","
                            pLSTGRE = pLSTGRE & .Rows(iCont).Cells("NRGUCL").Value
                        End If
                    End If
                    iCont += 1
                End While
            End With
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dtgGuiasPendientes_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgGuiasPendientes.CellContentDoubleClick
        Try
            btn_aceptar_Click(btn_aceptar, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
