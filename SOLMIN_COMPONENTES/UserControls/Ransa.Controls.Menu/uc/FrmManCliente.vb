Imports System.Windows.Forms
Imports System.Text
Imports Db2Manager.RansaData.iSeries.DataObjects


Public Class FrmManCliente

  Private _pbeAccesoCliente As New beAccesoCliente
  Private _pEstado As New Estado

  Public Property pEstado() As Estado
    Get
      Return _pEstado
    End Get
    Set(ByVal value As Estado)
      _pEstado = value
    End Set
  End Property

  Public Enum Estado
    Nuevo
    Modificar
  End Enum

  Public Property pbeAccesoCliente() As beAccesoCliente
    Get
      Return _pbeAccesoCliente
    End Get
    Set(ByVal value As beAccesoCliente)
      _pbeAccesoCliente = value
    End Set
  End Property


  Private Sub FrmManCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Try


      txtUsuario.Enabled = False
      txtUsuario.Text = _pbeAccesoCliente.PSMMCUSR
      Cargar_Division_x_Usuario()
      If _pEstado = Estado.Modificar Then
        UcCliente_TxtF011.Enabled = False
        UcCliente_TxtF011.pCargar(_pbeAccesoCliente.PNCCLNT)
        txtCodigoInterno.Text = _pbeAccesoCliente.PSCINTER
        txtReferencia.Text = _pbeAccesoCliente.PSTRFRCL
        UcAyudaPlanta.Valor = _pbeAccesoCliente.PSTPLNTA
      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Try
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Try
      Me.DialogResult = Windows.Forms.DialogResult.Cancel
      Me.Close()
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
    Try

      Dim oclsUsuario_DAL As New clsUsuario_DAL
      Dim obeAccesoCliente As New beAccesoCliente

      Select Case _pEstado
        Case Estado.Nuevo

          Dim msgValidacion As String = Valida_Campos()

          If msgValidacion.Length > 0 Then
            MessageBox.Show("Falta ingresar lo siguiente:" & Chr(13) & msgValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
          Else
            obeAccesoCliente.PSMMCUSR = txtUsuario.Text
            obeAccesoCliente.PNCCLNT = UcCliente_TxtF011.pCodigo
            If UcAyudaPlanta.Resultado Is Nothing Then
              obeAccesoCliente.PNCPLNDV = 0
            Else
              obeAccesoCliente.PNCPLNDV = CType(UcAyudaPlanta.Resultado, bePlanta).PNCODIGO
            End If
            obeAccesoCliente.PSTCMPCL = txtReferencia.Text
            obeAccesoCliente.PSCINTER = txtCodigoInterno.Text.Trim.ToString
            If oclsUsuario_DAL.Registrar_Opciones_X_Cliente(obeAccesoCliente) = 1 Or oclsUsuario_DAL.Registrar_Opciones_X_Cliente(obeAccesoCliente) = 0 Then
              Me.DialogResult = Windows.Forms.DialogResult.OK
              Me.Close()
              Exit Sub
            End If
          End If

        Case Estado.Modificar

          Dim msgValidacion As String = Valida_Campos()

          If msgValidacion.Length > 0 Then
            MessageBox.Show("Falta ingresar lo siguiente:" & Chr(13) & msgValidacion, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
          Else
            obeAccesoCliente.PSMMCUSR = txtUsuario.Text
            obeAccesoCliente.PNCCLNT = UcCliente_TxtF011.pCodigo
            If UcAyudaPlanta.Resultado Is Nothing Then
              obeAccesoCliente.PNCPLNDV = 0
            Else
              obeAccesoCliente.PNCPLNDV = CType(UcAyudaPlanta.Resultado, bePlanta).PNCODIGO
            End If
            obeAccesoCliente.PSTCMPCL = txtReferencia.Text
            obeAccesoCliente.PSCINTER = txtCodigoInterno.Text.Trim.ToString
            If oclsUsuario_DAL.Modificar_Opciones_X_Cliente(obeAccesoCliente) = 1 Then
              Me.DialogResult = Windows.Forms.DialogResult.OK
              Me.Close()
              Exit Sub
            End If
          End If
      End Select

    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Function Valida_Campos() As String
    Dim sbMensaje As New StringBuilder
    If UcCliente_TxtF011.pCodigo = Nothing Then
      sbMensaje.AppendLine("* Cliente")
    End If
    Return sbMensaje.ToString
  End Function

  Private Sub Cargar_Referencia() Handles UcCliente_TxtF011.InformationChanged
    Try
      txtReferencia.Text = UcCliente_TxtF011.pRazonSocial
    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Sub Cargar_Division_x_Usuario()
    Try
      Dim obeCliente As New beAccesoCliente
      Dim oDAL As New clsUsuario_DAL
      Dim dt As New DataTable
      Dim listPlanta As New List(Of bePlanta)
      Dim obePlanta As New bePlanta
      obePlanta.PSMMCUSR = _pbeAccesoCliente.PSMMCUSR
      listPlanta = oDAL.SP_SOLMIN_SD_LISTAR_CBO_PLANTAS_X_USUARIO_CLIENTE(obePlanta)

      Dim oListColum As New Hashtable
      Dim oColumnas As New DataGridViewTextBoxColumn
      oColumnas.Name = "PNCODIGO"
      oColumnas.DataPropertyName = "PNCODIGO"
      oColumnas.HeaderText = "Código "
      oListColum.Add(1, oColumnas)

      oColumnas = New DataGridViewTextBoxColumn
      oColumnas.Name = "PSDESCRIPCION"
      oColumnas.DataPropertyName = "PSDESCRIPCION"
      oColumnas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
      oColumnas.HeaderText = "Descripción "
      oListColum.Add(2, oColumnas)

      Me.UcAyudaPlanta.DataSource = listPlanta
      Me.UcAyudaPlanta.ListColumnas = oListColum
      Me.UcAyudaPlanta.Cargas()
      Me.UcAyudaPlanta.DispleyMember = "PSDESCRIPCION"
      Me.UcAyudaPlanta.ValueMember = "PNCODIGO"

    Catch ex As Exception
      MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub
End Class
