Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.mantenimientos

Public Class frmInformacionAcoplado
    Private vNPLCAC As String = ""
    Private vCCMPN As String
    Public Property CCMPN() As String
        Get
            Return vCCMPN
        End Get
        Set(ByVal value As String)
            vCCMPN = value
        End Set
    End Property
    Public Sub ShowForm(ByVal owner As IWin32Window)
        'Forzando destruccion de memoria
        ClearMemory()
        'Mostrando el formulario
        Me.ShowDialog(owner)
    End Sub

    Private Sub frmInformacionAcoplado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarComboTipoAcoplado()

        Dim objEntidad As New Acoplado
        Dim obj As New Acoplado_BLL
        objEntidad.NPLCAC = vNPLCAC
        objEntidad.CCMPN = vCCMPN
        Dim objGenericCollection As List(Of Acoplado)
        objGenericCollection = obj.Listar_Acoplado(objEntidad)

        If objGenericCollection.Count > 0 Then
            txtPlacaAcoplado.Text = objGenericCollection.Item(0).NPLCAC
            txtColorUnidad.Text = objGenericCollection.Item(0).TCLRUN
            txtPesoTara.Text = objGenericCollection.Item(0).QPSTRA
            txtNroEjes.Text = objGenericCollection.Item(0).NEJSUN
            txtCapacidadCarga.Text = objGenericCollection.Item(0).NCPCRU
            txtNroChasis.Text = objGenericCollection.Item(0).NSRCHU
            txtLongitudAcoplado.Text = objGenericCollection.Item(0).QLNGAC
            txtAnchoAcoplado.Text = objGenericCollection.Item(0).QANCAC
            txtAltoAcoplado.Text = objGenericCollection.Item(0).QALTAC
            cboTipoAcoplado.Codigo = objGenericCollection.Item(0).CTIACP
            txtNumeroMTC.Text = objGenericCollection.Item(0).NRGMT2
            txtConfiguracionEjes.Text = objGenericCollection.Item(0).TCNFG2
            txtMarcaVehiculo.Text = objGenericCollection.Item(0).TMRCVH
        End If

    End Sub

    Sub CargarComboTipoAcoplado()
        Try
            Dim objTipoAcoplado As New TipoAcoplado_BLL
            Dim objEntidad As New TipoAcoplado
            objEntidad.CCMPN = CCMPN
            cboTipoAcoplado.DataSource = HelpClass.GetDataSetNative(objTipoAcoplado.Listar_Tipo_Acoplado(objEntidad))
            cboTipoAcoplado.ValueField = "TDEACP"
            cboTipoAcoplado.KeyField = "CTIACP"
            cboTipoAcoplado.DataBind()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
