Imports Ransa.TypeDef
Imports RANSA.Utilitario
Public Class frmObtenerVolumenBulto

#Region "Atributo"
    Private mQMTALT As Double = 0
    Private mQMTANC As Double = 0
    Private mQMTLRG As Double = 0
#End Region

#Region "Propiedades"
    Public Property QMTALT_1()
        Get
            Return mQMTALT
        End Get
        Set(ByVal value)
            mQMTALT = value
        End Set
    End Property

    Public Property QMTANC_1()
        Get
            Return mQMTANC
        End Get
        Set(ByVal value)
            mQMTANC = value
        End Set
    End Property

    Public Property QMTLRG_1()
        Get
            Return mQMTLRG
        End Get
        Set(ByVal value)
            mQMTLRG = value
        End Set
    End Property

#End Region
#Region "Eventos"

    Private Sub frmObtenerVolumenBulto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'If _obj_Bulto IsNot Nothing Then
        Carga_Volumen_Bulto()
        'End If
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        mQMTALT = CType(txtAltura.Text, Double)
        mQMTANC = CType(txtAncho.Text, Double)
        mQMTLRG = CType(txtLargo.Text, Double)

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
#End Region

#Region "Metodos y Funciones"

    Private Sub Carga_Volumen_Bulto()
        txtAltura.Text = mQMTALT
        txtAncho.Text = mQMTANC
        txtLargo.Text = mQMTLRG
    End Sub
#End Region



End Class
