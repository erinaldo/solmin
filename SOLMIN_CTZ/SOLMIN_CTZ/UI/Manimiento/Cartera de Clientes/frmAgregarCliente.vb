Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports System.Text
Public Class frmAgregarCliente


    Private _NRCTCL As Decimal
    Public Property NRCTCL() As Decimal
        Get
            Return _NRCTCL
        End Get
        Set(ByVal value As Decimal)
            _NRCTCL = value
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

    '<[AHM]>
    Private _pCRGVTA As String = ""
    Public Property pCRGVTA() As String
        Get
            Return _pCRGVTA
        End Get
        Set(ByVal value As String)
            _pCRGVTA = value
        End Set
    End Property

    Private _pCodigoCompania As String = ""
    Public Property pCodigoCompania() As String
        Get
            Return _pCodigoCompania
        End Get
        Set(ByVal value As String)
            _pCodigoCompania = value
        End Set
    End Property

    Private Sub frmAgregarCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UcCliente.pVisualizaNegocio = True
    End Sub
    '</[AHM]>

    Private Sub tsbGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGrabar.Click
        Try
            Guardar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Function ValidarRelacionCartera(ByVal PNNRCTCL As Decimal, ByVal PNCCLNT As Decimal, ByVal PSCCMPN As String) As String
        Dim obrCliente As New clsCliente
        Dim dtCarteraAsociado As New DataTable
        dtCarteraAsociado = obrCliente.ListaCarteraAsociadoxCliente(_NRCTCL, UcCliente.pCodigo, _pCCMPN)
        Dim sb As New StringBuilder
        If dtCarteraAsociado.Rows.Count > 0 Then
            For Fila As Integer = 0 To dtCarteraAsociado.Rows.Count - 1
                sb.AppendLine(dtCarteraAsociado.Rows(Fila)("NRCTCL") & " - (" & ("" & dtCarteraAsociado.Rows(Fila)("CCMPN")).ToString.Trim & " - " & ("" & dtCarteraAsociado.Rows(Fila)("DESCAR")).ToString.Trim & ")")
            Next
        End If
        Return sb.ToString.Trim
    End Function

    '<[AHM]>
    Public Function PerteneceASalmon(ByVal pCodigoCompania As String) As Boolean
        Dim obrCliente As New clsCliente
        Return obrCliente.PerteneceASalmon(pCodigoCompania)
    End Function
    '</[AHM]>

    Private Sub Guardar()
        Dim oCliente As New Cliente
        Dim obrCliente As New clsCliente

        If UcCliente.pCodigo = 0 Then
            MsgBox("Debe Seleccionar Un Cliente", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If
        If _NRCTCL = 0 Then
            MsgBox("Debe Seleccionar Un Grupo Cliente", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If

        oCliente.CCLNT = UcCliente.pCodigo
        oCliente.NRCTCL = _NRCTCL
        oCliente.CCMPN = _pCCMPN

        Dim msgValRelacionCartera As String = ValidarRelacionCartera(_NRCTCL, UcCliente.pCodigo, _pCCMPN)
        If msgValRelacionCartera.Length > 0 Then
            'MessageBox.Show("No puede adicionar el cliente a este Grupo." & Chr(13) & "El cliente se encuentra en el siguiente grupo:" & Chr(13) & msgValRelacionCartera)
            Dim msgVal As String = ""
            msgVal = "El cliente se encuentra en el siguiente grupo cliente:" & Chr(13) & msgValRelacionCartera
            msgVal = msgVal & "Desea continuar?"
            If MessageBox.Show(msgVal, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        End If
        '<[AHM]>
        'VALIDA QUE LA CARTERA DE CLIENTES Y EL CLIENTE A AGREGAR PERTENEZCAN AL MISMO NEGOCIO (SOLO APLICA PARA SALMON)
        If Me.PerteneceASalmon(Me.pCodigoCompania) Then
            If Not Me.pCRGVTA = UcCliente.pNegocio Then
                MessageBox.Show("Cliente seleccionado debe de pertenecer a mismo Negocio que el grupo de clientes.")
                Exit Sub
            End If
        End If
        '</[AHM]>
        'Try

        'If oCliente.CCLNT <> 0 Then
        'If oCliente.NRCTCL <> 0 Then
        obrCliente.Agregar_Cliente_Cartera_Relacion(oCliente)
        MsgBox("Se guardó con éxito el registro", MsgBoxStyle.Information, "Aviso")
        Me.DialogResult = Windows.Forms.DialogResult.OK
        'If oCliente.Correcto = 1 Then
        '    MsgBox("Se guardó con éxito el registro", MsgBoxStyle.Information, "Aviso")
        '    Me.DialogResult = Windows.Forms.DialogResult.OK
        'Else
        '    MsgBox("No se pudo registrar la relación", MsgBoxStyle.Information, "Aviso")
        'End If
        'Else
        'MsgBox("Debe Seleccionar Un Grupo Cliente", MsgBoxStyle.Information, "Aviso")
        'End If
        'Else
        '    MsgBox("Debe Seleccionar Un Cliente", MsgBoxStyle.Information, "Aviso")
        'End If

        'Catch ex As Exception
        '    Throw New Exception(ex.Message)
        'End Try
    End Sub

    
End Class
