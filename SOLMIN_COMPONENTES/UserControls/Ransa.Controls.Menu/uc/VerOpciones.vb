Imports System.Windows.Forms

Public Class FrmVerOpciones

  Private _pMMCAPL_CodApl As String = ""
  Public Property pMMCAPL_CodApl() As String
    Get
      Return _pMMCAPL_CodApl
    End Get
    Set(ByVal value As String)
      _pMMCAPL_CodApl = value
    End Set
  End Property

  Private _pMMCMNU_CodMnu As String = ""
  Public Property pMMCMNU_CodMnu() As String
    Get
      Return _pMMCMNU_CodMnu
    End Get
    Set(ByVal value As String)
      _pMMCMNU_CodMnu = value
    End Set
  End Property

  Private _pMMCOPC As String = ""
  Public Property pMMCOPC() As Int32
    Get
      Return _pMMCOPC
    End Get
    Set(ByVal value As Int32)
      _pMMCOPC = value
    End Set
  End Property


  Private _pMMDOPC As String = ""
  Public Property pMMDOPC() As String
    Get
      Return _pMMDOPC
    End Get
    Set(ByVal value As String)
      _pMMDOPC = value
    End Set
  End Property


  Private Sub VerOpciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try
      dgvOpcion.AutoGenerateColumns = False
      pBuscarOpcion()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

  Public Sub pBuscarOpcion()

    Dim obeOpcion As New beOpcion
    Dim oclsOpcion_DAL As New clsOpcion_DAL
    obeOpcion.PSMMCAPL_CodApl = _pMMCAPL_CodApl
    obeOpcion.PSMMCMNU_CodMnu = _pMMCMNU_CodMnu

    If Me.txtCodigo.Text = Nothing Then
      obeOpcion.PNMMCOPC_CodOpc_Ini = 0
      obeOpcion.PNMMCOPC_CodOpc_Fin = 99
    Else
      obeOpcion.PNMMCOPC_CodOpc_Ini = Val(Me.txtCodigo.Text)
      obeOpcion.PNMMCOPC_CodOpc_Fin = Val(Me.txtCodigo.Text)
    End If
    obeOpcion.PSMMDOPC_DesOpc = txtDescripcion.Text.ToUpper
    dgvOpcion.DataSource = oclsOpcion_DAL.Listar_MenuOpcion(obeOpcion)

  End Sub

  Private Sub Buscar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    Try
      pBuscarOpcion()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
    Try
      Me.DialogResult = Windows.Forms.DialogResult.Cancel
      Me.Close()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub Enviar_Datos(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvOpcion.CellDoubleClick
    Try
      If dgvOpcion.CurrentRow IsNot Nothing And dgvOpcion.Rows.Count > 0 Then
        Dim oFrmManAccesoOpcion As New FrmManAccesoOpcion
        Dim lint_indice As Integer = Me.dgvOpcion.CurrentCellAddress.Y
        'Me.dgvOpcion.Item("MMCOPC", lint_indice).Value
        'Me.dgvOpcion.Item("MMDOPC", lint_indice).Value.ToString.Trim()
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub txtCodigo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown, txtDescripcion.KeyDown
    Try
      If e.KeyCode = Keys.Enter Then
        pBuscarOpcion()
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub
End Class
