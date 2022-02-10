Imports SOLMIN_ST.ENTIDADES
Imports SOLMIN_ST.NEGOCIO.seguimiento_wap

Public Class frmInformacionCicloWAP

#Region "Atributos"

  Public Objeto_Entidad_Ciclo_WAP As New RegistroWAP

#End Region

  Private Sub frmInformacionCicloWAP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.Obtener_Informacion_Ciclo_WAP()
  End Sub

  Private Sub Obtener_Informacion_Ciclo_WAP()
    Dim Obj_Entidad As New RegistroWAP
    Dim Obj_Logica As New SeguimientoWAP_BLL
    Me.txtCiclo.Text = Objeto_Entidad_Ciclo_WAP.CICLO
    Me.txtPlacaTracto.Text = Objeto_Entidad_Ciclo_WAP.NPLCTR
    Obj_Entidad = Obj_Logica.Obtener_Informacion_Ciclo_Wap(Objeto_Entidad_Ciclo_WAP)
    Me.dtpFechaCreacion.Value = CType(Obj_Entidad.FCHCRT, Date)
    Me.txtHoraCreacion.Text = Obj_Entidad.HRACRT
  End Sub

End Class
