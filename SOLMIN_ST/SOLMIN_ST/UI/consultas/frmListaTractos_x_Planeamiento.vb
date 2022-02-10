Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.mantenimientos

Public Class frmListaTractos_x_Planeamiento

#Region "Atributo"
    Private mCCMPN As String = ""
    Private mNPLNMT As Double = 0
    Private mNRUCTR As String = ""
    Private mNPLCTR As String = ""
    Private mNPLCAC As String = ""
    Private mCBRCNT As String = ""
    Private mCBRCND As String = ""
    Private mRUTA As String = ""
#End Region

#Region "Propiedades"
    Public WriteOnly Property CCMPN_1() As String
        Set(ByVal value As String)
            mCCMPN = value
        End Set
    End Property

    Public Property NPLNMT_1() As Double
        Get
            Return mNPLNMT
        End Get
        Set(ByVal value As Double)
            mNPLNMT = value
        End Set
    End Property

    Public ReadOnly Property NRUCTR_1()
        Get
            Return mNRUCTR
        End Get
    End Property

    Public ReadOnly Property NPLCTR_1()
        Get
            Return mNPLCTR
        End Get
    End Property

    Public ReadOnly Property NPLCAC_1()
        Get
            Return mNPLCAC
        End Get
    End Property

    Public ReadOnly Property CBRCNT_1()
        Get
            Return mCBRCNT
        End Get
    End Property

    Public ReadOnly Property CBRCND_1()
        Get
            Return mCBRCND
        End Get
    End Property

    Public ReadOnly Property RUTA_1()
        Get
            Return mRUTA
        End Get
    End Property

#End Region

#Region "Eventos"

    Private Sub frmListaTractos_x_Planeamiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.gwdDatos.AutoGenerateColumns = False
        Me.Alinear_Columnas_Grilla()
        Me.Lista_Tractos_x_Planeamiento()
        If Me.gwdDatos.RowCount = 0 Then
            HelpClass.MsgBox("Este Planeamiento no tiene Tracto Asignado")
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If

    End Sub

    Private Sub gwdDatos_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gwdDatos.CellDoubleClick
        If e.RowIndex = -1 Then Exit Sub
        Dim lint_Indice As Integer = Me.gwdDatos.CurrentCellAddress.Y
        mNRUCTR = Me.gwdDatos.Item("NRUCTR", e.RowIndex).Value
        If mNRUCTR.Equals("") Then
            HelpClass.MsgBox("Transportista y/o Tracto no registrado en el SOLMIN")
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Else
            mNPLCTR = Me.gwdDatos.Item("NPLCTR", e.RowIndex).Value
            mNPLCAC = Me.gwdDatos.Item("NPLCAC", e.RowIndex).Value
            mCBRCNT = Me.gwdDatos.Item("CBRCNT", e.RowIndex).Value
            mCBRCND = Me.gwdDatos.Item("CBRCND", e.RowIndex).Value
            mRUTA = Me.gwdDatos.Item("RUTA", e.RowIndex).Value
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

#End Region

#Region "Métodos y Funciones"

    Private Sub Lista_Tractos_x_Planeamiento()
        Dim obj_Logica As New GuiaTransportista_BLL
        Dim obj_Entidad As New GuiaTransportista
        Dim lint_Contador As Integer = 0
        Dim dvwr As DataGridViewRow

        obj_Entidad.NPLNMT = NPLNMT_1
        obj_Entidad.CCMPN = mCCMPN
        For Each objEntidad As GuiaTransportista In obj_Logica.Listar_Tractos_x_Planeamiento(obj_Entidad)
            lint_Contador = 0
            If objEntidad.CBRCN2 <> "" Then lint_Contador = 1
            For lint_Numerador As Integer = 0 To lint_Contador
                dvwr = New DataGridViewRow
                dvwr.CreateCells(Me.gwdDatos)
                dvwr.Cells(0).Value = objEntidad.NPLNMT
                dvwr.Cells(1).Value = objEntidad.NRUCTR
                dvwr.Cells(2).Value = objEntidad.NPLCTR
                dvwr.Cells(3).Value = objEntidad.NPLCAC
                dvwr.Cells(4).Value = IIf(lint_Numerador = 0, objEntidad.CBRCNT, objEntidad.CBRCN2)
                dvwr.Cells(5).Value = IIf(lint_Numerador = 0, objEntidad.CBRCND, objEntidad.CBRCND2)
                dvwr.Cells(6).Value = objEntidad.RUTA
                Me.gwdDatos.Rows.Add(dvwr)
            Next
        Next
    End Sub

    Private Sub Alinear_Columnas_Grilla()
        For lint_contador As Integer = 0 To Me.gwdDatos.ColumnCount - 1
            Me.gwdDatos.Columns(lint_contador).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub

#End Region

End Class
