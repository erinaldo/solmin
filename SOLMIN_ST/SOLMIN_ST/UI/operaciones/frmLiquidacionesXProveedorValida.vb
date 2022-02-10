Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.NEGOCIO.Operaciones

Public Class frmLiquidacionesXProveedorValida

    Private _pNOPRCN As Decimal = 0
    Public Property pNOPRCN() As Decimal
        Get
            Return _pNOPRCN
        End Get
        Set(ByVal value As Decimal)
            _pNOPRCN = value
        End Set
    End Property

    Private _pNGUIRM As Decimal = 0
    Public Property pNGUIRM() As Decimal
        Get
            Return _pNGUIRM
        End Get
        Set(ByVal value As Decimal)
            _pNGUIRM = value
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

    Private _pCDVSN As String = ""
    Public Property pCDVSN() As String
        Get
            Return _pCDVSN
        End Get
        Set(ByVal value As String)
            _pCDVSN = value
        End Set
    End Property

    Private _pNMOPRP As Decimal = 0
    Public Property pNMOPRP() As Decimal
        Get
            Return _pNMOPRP
        End Get
        Set(ByVal value As Decimal)
            _pNMOPRP = value
        End Set
    End Property

    Enum Tipovalidacion
        ViajeExclusivo
        ViajeReparto
    End Enum

    Private _pTipoValidacion As Tipovalidacion = Tipovalidacion.ViajeExclusivo
    Public Property pTipoValidacion() As Tipovalidacion
        Get
            Return _pTipoValidacion
        End Get
        Set(ByVal value As Tipovalidacion)
            _pTipoValidacion = value
        End Set
    End Property


    Private Sub frmLiquidacionesXProveedorValida_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            TabControl1.TabPages.Remove(TabPage2)

            dtGRemCargGTransLiq.AutoGenerateColumns = False
            Dim oblGuiaTransporte As New GuiaTransportista_BLL
            Dim ds As New DataSet

            Dim dtServicio As New DataTable
            Select Case _pTipoValidacion
                Case Tipovalidacion.ViajeExclusivo
                    ds = oblGuiaTransporte.Listar_Servicio_Guia_Prov_Validacion(_pCCMPN, _pNOPRCN, _pNGUIRM)
                Case Tipovalidacion.ViajeReparto
                    ds = oblGuiaTransporte.Listar_Servicio_Guia_Reparto_Prov_Validacion(_pCCMPN, _pCDVSN, _pNMOPRP)

            End Select

            dtGRemCargGTransLiq.DataSource = ds.Tables(0)
            'dtServiciosTarifaInterna.DataSource = ds.Tables(1)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            'Valida Proveedor
            Dim strMensajeError As String = ""
            For indice As Integer = 0 To dtGRemCargGTransLiq.Rows.Count - 1
                If dtGRemCargGTransLiq.Item("NRUCTR", indice).Value.ToString.Trim = "" Then
                    strMensajeError = " Verificar. Todos los servicios deben contar con  su proveedor" & vbNewLine
                    Exit For
                End If
            Next

            If strMensajeError.Length > 0 Then
                MessageBox.Show(strMensajeError, "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            'Valida Homologacion
            'Dim strProv As String = ""

            'For indice As Integer = 0 To dtGRemCargGTransLiq.Rows.Count - 1
            '    Dim strResultado As String = ""
            '    Dim objNegocio As New Solicitud_Transporte_BLL
            '    Dim objHashTable As New Hashtable
            '    objHashTable.Add("CCMPN", _pCCMPN)
            '    objHashTable.Add("NRUCTR", dtGRemCargGTransLiq.Item("NRUCTR", indice).Value.ToString.Trim)
            '    objHashTable.Add("FECVRF", Format(Date.Today, "yyyyMMdd"))
            '    strResultado = objNegocio.Obtener_Validacion_Homologacion_Proveedor(objHashTable)
            '    If strResultado.Trim <> "" Then
            '        strProv = dtGRemCargGTransLiq.Item("NRUCTR", indice).Value.ToString.Trim
            '        strMensajeError &= "* " & strProv & ". " & strResultado & vbNewLine
            '    End If
            'Next

            'Valida que un Proveedor no pueda tener distintas liquidaciones
            Dim oHasNumLiquidaciones As New Hashtable


            Dim strProve As String = ""
            For indice As Integer = 0 To dtGRemCargGTransLiq.Rows.Count - 1
                Dim strRUCProv As String = ""
                strRUCProv = dtGRemCargGTransLiq.Item("NRUCTR", indice).Value.ToString.Trim & "_" & dtGRemCargGTransLiq.Item("NLQDCN", indice).Value.ToString.Trim()
                If Not oHasNumLiquidaciones.Contains(strRUCProv) Then
                    oHasNumLiquidaciones.Add(strRUCProv, 1)
                Else
                    oHasNumLiquidaciones(strRUCProv) = oHasNumLiquidaciones(strRUCProv) + 1
                End If
                'Dim strRUC As String = ""
                ''Dim intNroLiq As Decimal = 0
                'If indice = 0 Then
                '    strRUC = dtGRemCargGTransLiq.Item("NRUCTR", indice).Value.ToString.Trim()
                '    'intNroLiq = dtGRemCargGTransLiq.Item("NLQDCN", indice).Value
                'Else
                '    If strRUC = dtGRemCargGTransLiq.Item("NRUCTR", indice).Value.ToString.Trim() Then
                '        strMensajeError &= "* El Proveedor " & strRUCProv & " tiene distintas liquidaciones. " & vbNewLine
                '    Else
                '        strRUC = dtGRemCargGTransLiq.Item("NRUCTR", indice).Value.ToString.Trim()
                '    End If
                'End If
            Next
            For Each item As DictionaryEntry In oHasNumLiquidaciones
                If item.Value > 1 Then
                    strMensajeError &= "* El Proveedor " & item.Key.ToString.Split("_")(0) & " no puede tener más de una liquidación." & vbNewLine
                End If
            Next



            'Dim strProve As String = ""
            'For indice As Integer = 0 To dtGRemCargGTransLiq.Rows.Count - 1
            '    Dim strRUCProv As String = ""
            '    strRUCProv = dtGRemCargGTransLiq.Item("NRUCTR", indice).Value.ToString.Trim() & " - " & dtGRemCargGTransLiq.Item("TCMTRT", indice).Value.ToString.Trim()
            '    Dim strRUC As String = ""
            '    'Dim intNroLiq As Decimal = 0
            '    If indice = 0 Then
            '        strRUC = dtGRemCargGTransLiq.Item("NRUCTR", indice).Value.ToString.Trim()
            '        'intNroLiq = dtGRemCargGTransLiq.Item("NLQDCN", indice).Value
            '    Else
            '        If strRUC = dtGRemCargGTransLiq.Item("NRUCTR", indice).Value.ToString.Trim() Then
            '            strMensajeError &= "* El Proveedor " & strRUCProv & " tiene distintas liquidaciones. " & vbNewLine
            '        Else
            '            strRUC = dtGRemCargGTransLiq.Item("NRUCTR", indice).Value.ToString.Trim()
            '        End If
            '    End If

            'Next

            If strMensajeError.Length > 0 Then
                MessageBox.Show(strMensajeError, "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                DialogResult = Windows.Forms.DialogResult.Yes
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class
