Imports SOLMIN_ST.NEGOCIO.Operaciones

Public Class frmVistarptParteTransf

    Private _PSCCMPN As String = ""
    Public Property PSCCMPN() As String
        Get
            Return _PSCCMPN
        End Get
        Set(ByVal value As String)
            _PSCCMPN = value
        End Set
    End Property

    Private _PNCTPODC As String = ""
    Public Property PNCTPODC() As String
        Get
            Return _PNCTPODC
        End Get
        Set(ByVal value As String)
            _PNCTPODC = value
        End Set
    End Property

    Private _PNNDCCTC As String = ""
    Public Property PNNDCCTC() As String
        Get
            Return _PNNDCCTC
        End Get
        Set(ByVal value As String)
            _PNNDCCTC = value
        End Set
    End Property

    Private Sub frmVistarptParteTransf_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Imprimir()

    End Sub

    Private Sub Imprimir()
        Dim objCrep As New rptVistaParteTransferencia

        Dim ds As DataSet = (New Factura_Transporte_BLL()).Lista_Datos_Documento_Emitido(Me.PSCCMPN, Me.PNCTPODC, Me.PNNDCCTC)

        Dim dtCabPT As DataTable = ds.Tables(0).Copy

        Dim dtServicios As DataTable = ds.Tables(1).Copy
        dtServicios.TableName = "dtDetallePT"

        Dim dtRefObsCabecera As DataTable = ds.Tables(2).Copy
        dtRefObsCabecera.TableName = "dtObPT"

        Dim dtRefObsDetalle As DataTable = ds.Tables(3).Copy
        dtRefObsDetalle.TableName = "dtObPT"

        Dim importeTotal As Decimal = 0
        For Each row As DataRow In dtServicios.Rows
            importeTotal = importeTotal + Convert.ToDecimal(row("IVLDCS_A"))
        Next

        Dim importeEnLetras As String = ""
        If (dtCabPT.Rows(0)("MONEDA").ToString() = "USD") Then
            importeEnLetras = Ransa.Utilitario.HelpClass.NumeroLetras_RNS(Format(importeTotal, "###########0.00")).ToUpper & " Dolares Americanos"
        Else
            importeEnLetras = Ransa.Utilitario.HelpClass.NumeroLetras_RNS(Format(importeTotal, "###########0.00")).ToUpper & " Nuevos Soles"
        End If

        Dim fecha As String = dtCabPT.Rows(0)("FDCCTC").ToString()
        If (Not fecha.IsNullOrEmpty(fecha)) Then
            fecha = String.Format("{0}/{1}/{2}", fecha.Substring(6, 2), fecha.Substring(4, 2), fecha.Substring(0, 4))
        End If
        Dim fechaDoc As DateTime = Convert.ToDateTime(fecha)

        objCrep.SetDataSource(dtServicios)
        objCrep.Subreports.Item("subrptRefCabeceraPT").SetDataSource(dtRefObsCabecera.Copy)
        objCrep.Subreports.Item("subrptRefDetallePT").SetDataSource(dtRefObsDetalle.Copy)

        HelpClass.CrystalReportTextObject(objCrep, "txtCompania", dtCabPT.Rows(0)("TCMPCL_CCMPN").ToString())
        HelpClass.CrystalReportTextObject(objCrep, "txtDireccionCompania", dtCabPT.Rows(0)("TDRCOR_CCMPN").ToString())
        HelpClass.CrystalReportTextObject(objCrep, "txtUbigeo", String.Format("{0} {1} {2}", dtCabPT.Rows(0)("TDPRT_CCMPN").ToString(), dtCabPT.Rows(0)("TPRVN_CCMPN").ToString(), dtCabPT.Rows(0)("TDSTR_CCMPN").ToString()))

        HelpClass.CrystalReportTextObject(objCrep, "txtCliente", dtCabPT.Rows(0)("TCMPCL").ToString())
        HelpClass.CrystalReportTextObject(objCrep, "txtDireccion", dtCabPT.Rows(0)("TDRCOR").ToString())
        HelpClass.CrystalReportTextObject(objCrep, "txtDocumento", String.Format("R.U.C. {0}", dtCabPT.Rows(0)("NRUC").ToString()))
        HelpClass.CrystalReportTextObject(objCrep, "txtFecha", String.Format("Fecha Doc: {0}", fecha))
        HelpClass.CrystalReportTextObject(objCrep, "txtCodigo", dtCabPT.Rows(0)("CCLNT").ToString())

        HelpClass.CrystalReportTextObject(objCrep, "txtRUC", String.Format("RUC: {0}", dtCabPT.Rows(0)("NRUC_CCMPN").ToString()))
        HelpClass.CrystalReportTextObject(objCrep, "txtNumero", String.Format("Nº {0}", dtCabPT.Rows(0)("NDCCTC").ToString()))

        HelpClass.CrystalReportTextObject(objCrep, "txtImporteEnLetras", String.Format("Son: {0}", importeEnLetras))

        HelpClass.CrystalReportTextObject(objCrep, "txtMoneda", dtCabPT.Rows(0)("MONEDA").ToString())
        HelpClass.CrystalReportTextObject(objCrep, "txtSubTotal", Math.Round(importeTotal, 2).ToString())
        HelpClass.CrystalReportTextObject(objCrep, "txtMonedaTotal", dtCabPT.Rows(0)("MONEDA").ToString())
        HelpClass.CrystalReportTextObject(objCrep, "txtImporteTotal", Math.Round(importeTotal, 2).ToString())


        CrystalReportViewer1.ReportSource = objCrep
    End Sub
    Private Function AgregarDT(ByVal dt As DataTable, ByVal dtName As String) As DataTable
        dt.TableName = dtName
        Return dt
    End Function

    Private Sub CrystalReportViewer1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
