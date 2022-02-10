Public Class frmDetalleBulto


    Private _oDetalleServicio As Servicio_BE
    ''' <summary>
    ''' en esta Clase se llenan los paramentros para la consulta detalle de bulto
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property oDetalleServicio() As Servicio_BE
        Get
            Return _oDetalleServicio
        End Get
        Set(ByVal value As Servicio_BE)
            _oDetalleServicio = value
        End Set
    End Property

    Private Sub frmDetalleBulto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarItemBulto()
    End Sub

    Private Sub CargarItemBulto()
        '----------frmObservacionItemOC-------------
        Dim obrServicio As New clsServicio_BL
        dgBultosDetalle.AutoGenerateColumns = False
        dgBultosDetalle.DataSource = obrServicio.fdtListarDetalleBulto(oDetalleServicio)
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class
