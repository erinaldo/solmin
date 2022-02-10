
Imports SOLMIN_ST.ENTIDADES

Public Class frmSolicitudTransporteReqto

    Private _pRequerimientoServicio As AtencionRequerimiento = Nothing
    Public Property pRequerimientoServicio() As AtencionRequerimiento
        Get
            Return _pRequerimientoServicio
        End Get
        Set(ByVal value As AtencionRequerimiento)
            _pRequerimientoServicio = value
        End Set
    End Property

    Private _pEsRequerimiento As Boolean = True
    Public Property pEsRequerimiento() As Boolean
        Get
            Return _pEsRequerimiento
        End Get
        Set(ByVal value As Boolean)
            _pEsRequerimiento = value
        End Set
    End Property


    Private Sub frmSolicitudTransporteReqto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            UcSolicitudTransportes1.pRequerimientoServicio = _pRequerimientoServicio
            UcSolicitudTransportes1.pEsRequerimiento = True
            UcSolicitudTransportes1.pNombreForm = "frmSolicitudTransportes"
            UcSolicitudTransportes1.pInicializar()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class


