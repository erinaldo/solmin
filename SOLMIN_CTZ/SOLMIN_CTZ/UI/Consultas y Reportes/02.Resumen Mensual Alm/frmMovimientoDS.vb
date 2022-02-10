Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_CTZ.NEGOCIO
Imports SOLMIN_CTZ.Entidades
Imports Ransa.Utilitario

Public Class frmMovimientoDS


    Private _pCCMPN As String
    Public Property pCCMPN() As String
        Get
            Return _pCCMPN
        End Get
        Set(ByVal value As String)
            _pCCMPN = value
        End Set
    End Property


    Private _pCodClientes As String
    Public Property pCodClientes() As String
        Get
            Return _pCodClientes
        End Get
        Set(ByVal value As String)
            _pCodClientes = value
        End Set
    End Property



    Private _pTipoMov As String
    Public Property pTipoMov() As String
        Get
            Return _pTipoMov
        End Get
        Set(ByVal value As String)
            _pTipoMov = value
        End Set
    End Property

    Private Sub frmMovimientoDS_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Movimiento Almacén Simple
        If _pTipoMov = "RECEPCION" Then
            Me.Text = "Recepción Almacén Simple"
        Else
            Me.Text = "Despacho Almacén Simple"
        End If

    End Sub

    Private Sub tsbExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportar.Click
        pcxEspera.Visible = True
        bgwGifAnimado.RunWorkerAsync()
        tsbExportar.Enabled = False
    End Sub

    Private Sub tsbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCancelar.Click
        Me.Close()
    End Sub


    Private Sub bgwGifAnimado_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwGifAnimado.DoWork
        pReporteStockProductoR01()
    End Sub

    Private Sub bgwGifAnimado_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwGifAnimado.RunWorkerCompleted
        pcxEspera.Visible = False
        tsbExportar.Enabled = True
    End Sub


    Private Sub pReporteStockProductoR01()
        Dim obrResumenMensualAlm As New clsResumenMensualAlmacenes
        Dim obeFiltro As New ResumenMensualAlmacenes

        Dim intIsInventarioActual As Integer = 1
        Dim strMensaje As String = String.Empty
        Dim DtReporte As New DataTable
        Try
            With obeFiltro
                .PSCCLNT = pCodClientes
                .PSCTPDP6 = "1"
                .PNFECINV = Ransa.Utilitario.HelpClass.CDate_a_Numero8Digitos(dteFechaInicial.Value)
                .PNFECFIN = Ransa.Utilitario.HelpClass.CDate_a_Numero8Digitos(dteFechaFinal.Value)
                If _pTipoMov = "RECEPCION" Then
                    .PSCTPOAT = "I"
                Else
                    .PSCTPOAT = "S"
                End If
                .PSSTPODP = "1"
            End With

            DtReporte = obrResumenMensualAlm.fodtMovimientosIngSalDSResumenMensual(obeFiltro)
        Catch ex As Exception
        End Try
        Try
            Dim DtReporteIng As New DataTable
            Dim intLinea As Integer = 0
            DtReporteIng = DtReporte.Copy
            DtReporteIng.Columns.RemoveAt(2)

            DtReporteIng.Columns(intLinea).ColumnName = "CLIENTE\n CÓDIGO "
            intLinea += 1
            DtReporteIng.Columns(intLinea).ColumnName = "CLIENTE\n RAZÓN SOCIAL"
            intLinea += 1
            DtReporteIng.Columns(intLinea).ColumnName = "\n FECHA"
            intLinea += 1
            DtReporteIng.Columns(intLinea).ColumnName = " CÓDIGO \n MERCADERIA"
            intLinea += 1
            DtReporteIng.Columns(intLinea).ColumnName = "CODIGO \n RANSA"
            intLinea += 1
            DtReporteIng.Columns(intLinea).ColumnName = "DETALLE \n MERCADERIA"
            intLinea += 1
            DtReporteIng.Columns(intLinea).ColumnName = "ORDEN \n SERVICIO"
            intLinea += 1
            DtReporteIng.Columns(intLinea).ColumnName = "NRO. \n SOLICITUD"
            intLinea += 1
            DtReporteIng.Columns(intLinea).ColumnName = "TIPO  ALMACEN"
            intLinea += 1
            DtReporteIng.Columns(intLinea).ColumnName = "ALMACEN"
            intLinea += 1
            DtReporteIng.Columns(intLinea).ColumnName = "MOVIMIENTO \n CANTIDAD"
            intLinea += 1
            DtReporteIng.Columns(intLinea).ColumnName = "MOVIMIENTO \n UNIDAD"
            intLinea += 1
            DtReporteIng.Columns(intLinea).ColumnName = "MOVIMIENTO \n PESO"
            intLinea += 1
            DtReporteIng.Columns(intLinea).ColumnName = "MOVIMIENTO \nUNIDAD "
            intLinea += 1
            DtReporteIng.Columns(intLinea).ColumnName = "GUIA \n RANSA"
            intLinea += 1
            DtReporteIng.Columns(intLinea).ColumnName = "GUIA \n CLIENTE"
            intLinea += 1
            DtReporteIng.Columns(intLinea).ColumnName = ".\n OBSERVACION"
            DtReporteIng.TableName = _pTipoMov



            Dim strTitulo As New List(Of String)
            strTitulo.Add("Fecha : \n" & Me.dteFechaInicial.Value.ToShortDateString & " - " & Me.dteFechaFinal.Value.ToShortDateString)

            Dim oDs As New DataSet
            oDs.Tables.Add(DtReporteIng)

            '==========================Exportamos==========================
            Ransa.Utilitario.HelpClass.ExportExcelConTitulos(oDs, Me.Text, strTitulo)
        Catch ex As Exception

        End Try

    End Sub


End Class
