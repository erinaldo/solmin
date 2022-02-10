Imports SOLMIN_ST.NEGOCIO.operaciones
Imports SOLMIN_ST.ENTIDADES.Operaciones
Imports Ransa.Utilitario
Public Class frmOperacionesXPreFactura


#Region "Variables"
    Private _odtListLote As DataTable
    Private _strLote As String
#End Region

#Region "Properties"

    Private _PNCCLNT As Decimal
    Public Property PNCCLNT() As Decimal
        Get
            Return _PNCCLNT
        End Get
        Set(ByVal value As Decimal)
            _PNCCLNT = value
        End Set
    End Property


    Private _PSCCMPN As String
    Public Property PSCCMPN() As String
        Get
            Return _PSCCMPN
        End Get
        Set(ByVal value As String)
            _PSCCMPN = value
        End Set
    End Property


    Private _PSCDVSN As String
    Public Property PSCDVSN() As String
        Get
            Return _PSCDVSN
        End Get
        Set(ByVal value As String)
            _PSCDVSN = value
        End Set
    End Property


    Private _PNNPRLQD As Decimal
    Public Property PNNPRLQD() As Decimal
        Get
            Return _PNNPRLQD
        End Get
        Set(ByVal value As Decimal)
            _PNNPRLQD = value
        End Set
    End Property


    Private _PNNDCPRF As Decimal
    Public Property PNNDCPRF() As Decimal
        Get
            Return _PNNDCPRF
        End Get
        Set(ByVal value As Decimal)
            _PNNDCPRF = value
        End Set
    End Property
#End Region

    Private Sub frmlotefactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.gwdDatos.AutoGenerateColumns = False
            Dim fact As New Factura_Transporte_BLL
            Me.gwdDatos.AutoGenerateColumns = False
            Dim obj_Logica As New PreLiquidacion_BLL
            Dim objParam As New Hashtable
            objParam.Add("PNCCLNT", Me.PNCCLNT)
            objParam.Add("PSCCMPN", Me.PSCCMPN)
            objParam.Add("PSCDVSN", Me.PSCDVSN)
            If _PNNPRLQD <> 0 Then
                objParam.Add("PNNPRLQD", Me.PNNPRLQD)
                Me.gwdDatos.DataSource = obj_Logica.Listar_Operaciones_PreLiquidacion(objParam)
            Else
                objParam.Add("PNNDCPRF", Me.PNNDCPRF)
                Me.gwdDatos.DataSource = obj_Logica.Listar_Operaciones_PreFactura(objParam)
            End If
            Dim estadoImg As String = ""
            Dim bmpImage As Bitmap = Nothing
            For Each item As DataGridViewRow In gwdDatos.Rows
                If Val("" & item.Cells("NROVLR").Value) > 0 Then

                    If item.Cells("IMPOCOS").Value = item.Cells("VLR_SOL").Value Or item.Cells("IMPOCOD").Value = item.Cells("VLR_DOL").Value Then
                        estadoImg = "S"
                    Else
                        estadoImg = "D"
                    End If
                Else
                    estadoImg = ""
                End If
                Select Case estadoImg
                    Case "S"
                        bmpImage = My.Resources.Resources.verde
                        item.Cells("STATUS").Value = bmpImage
                    Case "E"
                        bmpImage = My.Resources.Resources.Rojo
                        item.Cells("STATUS").Value = bmpImage

                    Case "D"
                        bmpImage = My.Resources.Resources.naranja
                        item.Cells("STATUS").Value = bmpImage

                    Case ""
                        bmpImage = My.Resources.Resources.CuadradoBlanco
                        item.Cells("STATUS").Value = bmpImage
                    Case Else
                        bmpImage = My.Resources.Resources.CuadradoBlanco
                        item.Cells("STATUS").Value = bmpImage
                End Select

            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub btnCancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Try
            If gwdDatos.Rows.Count <= 0 Then
                MessageBox.Show("No hay datos para procesar. Primero debe de procesar su reporte", "Mostrar Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If


            Dim titulo As String = ""
            '_PNNDCPRF
            If _PNNPRLQD > 0 Then
                titulo = " Pre-Liquidacion " & _PNNPRLQD
            End If
            If _PNNDCPRF > 0 Then
                titulo = " Pre-Factura " & _PNNDCPRF
            End If

            Dim ODs As New DataSet
            Dim objDt As New DataTable
            Dim loEncabezados As New Generic.List(Of Encabezados)
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.FILENAME, "Listado Operaciones"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.HOJA, "OPERACIONES"))
            loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.TITULO, "OPERACIONES " & titulo))
            'loEncabezados.Add(New Encabezados("", Encabezados.TIPOENCABEZADO.DECIMALES, "#,##0.00"))
            objDt = CType(Me.gwdDatos.DataSource, DataTable).Copy 'dstGeneral.Tables(0).Copy

            'For Each dr As DataRow In objDt.Rows
            '    dr("NORCML") = dr("NORCML").ToString.Replace(",", "," + Chr(10)).ToString
            '    dr.AcceptChanges()
            'Next
            ODs.Tables.Add(HelpClass_NPOI.TransformarGrilla(Me.gwdDatos, objDt))

            'For Each dc As DataColumn In ODs.Tables(0).Columns
            '    Select Case dc.Caption
            '        Case "NORCML", "NOPRCN", "NPLVHT", "NPLCAC", "NMNFCR", "NGUITR", "CCNCST", "CCNBNS", "NLQDCN"
            '            dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_STRING)
            '        Case "PBRTOR", "PTRAOR", "PNETO", "IMPCO", "IMPCO_SOLES", "IMPPA", _
            '             "IMPPA_SOLES", "GASTOS", "GASTOAVC", "QGLNCM", "COSTO", "IMPORTE_NETO", "MARGEN", "GASTOAVC"
            '            dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_DECIMAL, Encabezados.TIPOFORMATO.D2)
            '        Case "TC_COBRAR", "TC_PAGAR"
            '            dc.Caption = HelpClass_NPOI.FormatColumna(Encabezados.TIPODATO.TIP_DECIMAL, Encabezados.TIPOFORMATO.D3)
            '    End Select
            'Next
            HelpClass_NPOI.ExportExcelGenerico(loEncabezados, ODs)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
