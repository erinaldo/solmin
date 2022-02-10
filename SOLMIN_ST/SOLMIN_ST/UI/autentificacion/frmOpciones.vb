Public Class frmOpciones
    Dim connstr As String

    Enum SERVIDOR
        DESARROLLO
        PRODUCCION
        TEST
    End Enum


    Private _TipoServidor As SERVIDOR
    Public Property TipoServidor() As SERVIDOR
        Get
            Return _TipoServidor
        End Get
        Set(ByVal value As SERVIDOR)
            _TipoServidor = value
        End Set
    End Property

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        connstr = HelpClass.getSetting("DataBase_ServerChange")

        If Me.rdProduccion.Checked = True Then
            connstr = connstr.Replace("$Server", "RANSA")
            connstr = connstr.Replace("$Lib", "DC@RNSLIB")
            TipoServidor = SERVIDOR.PRODUCCION
        ElseIf RadioButton1.Checked = True Then
            connstr = connstr.Replace("$Server", "RANSAT01")
            connstr = connstr.Replace("$Lib", "DC@RNSLIB")
            TipoServidor = SERVIDOR.TEST
        Else
            connstr = connstr.Replace("$Server", "RANSA01")
            connstr = connstr.Replace("$Lib", "DC@DESLIB")
            TipoServidor = SERVIDOR.DESARROLLO
        End If

        Me.Close()

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Public Function getConn() As String
        Return connstr
    End Function

    Private Sub frmOpciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TipoServidor = SERVIDOR.DESARROLLO Then
            rdDesarrollo.Checked = True
        End If
    End Sub
End Class
