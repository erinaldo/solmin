Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.Utilitario
Imports SOLMIN_CTZ.NEGOCIO
Imports SOLMIN_CTZ.Entidades
Imports Ransa.TypeDef.UbicacionPlanta.Division
Imports Ransa.Negocio.UbicacionPlanta.Division
Imports Ransa.DAO.UbicacionPlanta.Division



Public Class frmProcesValorizacion
    Private oValorizacion As beMantValorizacion
    Public _pbeValorizacion As New beMantValorizacion
    Public Property pbeValorizacion() As beMantValorizacion
        Get
            Return _pbeValorizacion
        End Get
        Set(ByVal value As beMantValorizacion)
            _pbeValorizacion = value
        End Set
    End Property
    Private Sub frmProcesValorizacion_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtImporteDolares.Text = pbeValorizacion.TOTDOLARES
        txtImporteSoles.Text = pbeValorizacion.TOTSOLES



    End Sub



    Private Sub btnProcesar_Click_1(sender As Object, e As EventArgs)
        Try
            btnCancelar.Enabled = False
            btnProcesar.Enabled = False
            Dim oValorizacion As New beMantValorizacion
            Dim obrValorizacion As New clsMantValorizacion
            Dim dtTransaccion As New DataTable
            Dim sErrorMesage As String = ""
            Dim sMesageAlerta As String = ""
            Dim sStatus As String = ""
            Dim sNro_Valorización As String = ""

            oValorizacion.CCMPN = pbeValorizacion.CCMPN
            oValorizacion.CCLNT = pbeValorizacion.CCLNT
            oValorizacion.NROVLR = pbeValorizacion.NROVLR
            oValorizacion.CULUSA = ConfigurationWizard.UserName
            oValorizacion.NTRMNL = HelpClass.NombreMaquina
            dtTransaccion = obrValorizacion.RegistrarValorizacionCabecera(oValorizacion)

            Dim dr As DataRow
            dtTransaccion.Columns.Add(New DataColumn("STATUS", GetType(String)))
            dtTransaccion.Columns.Add(New DataColumn("OBSRESULT", GetType(String)))
            dtTransaccion.Columns.Add(New DataColumn("NROSGV", GetType(String)))
            For Each row As DataRow In dtTransaccion.Rows
                dr = dtTransaccion.NewRow()
                dr("STATUS") = "S"
                dr("OBSRESULT") = "Actualización Exitosa"
                dr("NROSGV") = row("NROSGV").ToString.Trim
                dtTransaccion.Rows.Add(dr)
            Next

            For Each row As DataRow In dtTransaccion.Rows
                sStatus = row("STATUS").ToString.Trim
                sNro_Valorización = row("NROVLR").ToString.Trim
                oValorizacion.NROSGV = row("NROVLR").ToString.Trim
                If sStatus = "E" Then
                    sErrorMesage = sErrorMesage & row("OBSRESULT").ToString.Trim & Environment.NewLine
                End If
                If sStatus = "S" Then
                    sMesageAlerta = sMesageAlerta & row("OBSRESULT").ToString.Trim & Environment.NewLine
                End If
            Next
            If sStatus = "S" Then
                Dim dtDetalle As New DataTable
                Dim obrFiltroValorizacion As New clsMantValorizacion
                dtTransaccion = obrFiltroValorizacion.ListarOPxValorizacion(oValorizacion)
                For Each row As DataRow In dtTransaccion.Rows

                    oValorizacion.CCMPN = row("CCMPN")
                    oValorizacion.NROVLR = row("NROVLR")
                    oValorizacion.NROSGV = row("NROSGV")
                    oValorizacion.TPOPER = row("TPOPER")
                    oValorizacion.NOPRCN = row("NOPRCN")

                    oValorizacion.NCRROP = row("NCRROP")
                    oValorizacion.NGUITR = row("NGUITR")
                    oValorizacion.NCRRGU = row("NCRRGU")
                    oValorizacion.SESTOP = row("SESTOP")
                    oValorizacion.NLQDCN = row("NLQDCN")

                    oValorizacion.NSECFC = row("NSECFC")
                    oValorizacion.CDVSN = row("CDVSN")
                    oValorizacion.CPLNDV = row("CPLNDV")
                    oValorizacion.CSRVC = row("CSRVC")
                    oValorizacion.CMNDA1 = row("CMNDA1")

                    oValorizacion.QATNAN = row("QATNAN")
                    oValorizacion.IVLSRV = row("IVLSRV")
                    oValorizacion.ITPCMT = row("ITPCMT")

                    oValorizacion.CULUSA = row("CULUSA")
                    oValorizacion.NTRMNL = row("NTRMNL")

                    obrValorizacion.InsertaDetalleOperValorizacionPendiente(oValorizacion)
                Next
            End If

            sErrorMesage = sErrorMesage.Trim
            sMesageAlerta = sMesageAlerta.Trim
            If sStatus = "E" Then
                MessageBox.Show(sErrorMesage, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            If sStatus = "S" Then
                MessageBox.Show(sMesageAlerta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            btnCancelar.Enabled = True
            btnProcesar.Enabled = False
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnCancelar.Enabled = True
            btnProcesar.Enabled = False
        End Try

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

 
End Class
