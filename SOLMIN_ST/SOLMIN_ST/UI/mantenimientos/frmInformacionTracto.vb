Imports SOLMIN_ST.ENTIDADES.mantenimientos
Imports SOLMIN_ST.NEGOCIO.mantenimientos

Public Class frmInformacionTracto
    Private vNPLCUN As String = ""
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

    Private Sub frmInformacionTracto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Cargar_ComboTipoTracto()

            Dim objEntidad As New Tracto
            Dim obj As New Tracto_BLL
            objEntidad.NPLCUN = vNPLCUN
            objEntidad.CCMPN = CCMPN

            Dim objGenericCollection As List(Of Tracto)
            objGenericCollection = obj.Listar_Tracto(objEntidad)

            If objGenericCollection.Count > 0 Then
                txtNumPlacaUnidad.Text = objGenericCollection.Item(0).NPLCUN
                txtNumEjes.Text = objGenericCollection.Item(0).NEJSUN
                txtNumChasis.Text = objGenericCollection.Item(0).NSRCHU
                txtSerieMotor.Text = objGenericCollection.Item(0).NSRMTU
                txtFechaFabricacion.Text = objGenericCollection.Item(0).FFBRUN
                txtColorUnidad.Text = objGenericCollection.Item(0).TCLRUN
                txtCarroceriaUnidad.Text = objGenericCollection.Item(0).TCRRUN
                txtCapCargaUnidad.Text = objGenericCollection.Item(0).NCPCRU
                txtCodigoTipoTracto.Codigo = objGenericCollection.Item(0).CTITRA
                txtPesoTracto.Text = objGenericCollection.Item(0).QPSOTR
                txtMarcaModelo.Text = objGenericCollection.Item(0).TMRCTR
                txtNumEmpadMTC.Text = objGenericCollection.Item(0).NRGMT1
                txtNroRPM.Text = objGenericCollection.Item(0).NTERPM
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub Cargar_ComboTipoTracto()
        Try
            Dim objTipoTracto As New TipodeTracto_BLL
            Dim objEntidad As New TipodeTracto
            objEntidad.TDETRA = ""
            objEntidad.CCMPN = CCMPN
            With Me.txtCodigoTipoTracto
                .DataSource = HelpClass.GetDataSetNative(objTipoTracto.Listar_TipodeTracto(objEntidad))
                .KeyField = "CTITRA"
                .ValueField = "TDETRA"
                .DataBind()
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

End Class
