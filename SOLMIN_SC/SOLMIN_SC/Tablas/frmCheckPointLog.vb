Imports SOLMIN_SC.Negocio
Public Class frmCheckPointLog
    Enum TipoLog
        Embarque
        PreEmbarque
        EmbarquePreEmbarque
    End Enum

    Private _pTipoLog As TipoLog
    Private _pCCLNT As Decimal = 0
    Private _pNORSCI As Decimal = 0
    Private _pNRPEMB As Decimal = 0
    Private _pNESTDO As Decimal = 0
    Private _pCHK As String = ""
    Public Property pTipoLog() As TipoLog
        Get
            Return _pTipoLog
        End Get
        Set(ByVal value As TipoLog)
            _pTipoLog = value
        End Set
    End Property
    Public Property pCCLNT() As Decimal
        Get
            Return _pCCLNT
        End Get
        Set(ByVal value As Decimal)
            _pCCLNT = value
        End Set
    End Property
    Public Property pNORSCI() As Decimal
        Get
            Return _pNORSCI
        End Get
        Set(ByVal value As Decimal)
            _pNORSCI = value
        End Set
    End Property
    Public Property pNRPEMB() As Decimal
        Get
            Return _pNRPEMB
        End Get
        Set(ByVal value As Decimal)
            _pNRPEMB = value
        End Set
    End Property
    Public Property pNESTDO() As Decimal
        Get
            Return _pNESTDO
        End Get
        Set(ByVal value As Decimal)
            _pNESTDO = value
        End Set
    End Property

    Public Property pCHK() As String
        Get
            Return _pCHK
        End Get
        Set(ByVal value As String)
            _pCHK = value
        End Set
    End Property



    Private Sub frmCheckPointLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim obrEmbarque As New clsEmbarque
            Dim odtDatos As New DataTable
            dtgCheckPointLog.AutoGenerateColumns = False
            dtgCheckPointLog.DataSource = Nothing
            lblCheckPoint.Text = _pCHK
            Select Case _pTipoLog
                Case TipoLog.Embarque
                    odtDatos = obrEmbarque.Listar_Log_X_Embarque_Aduana(_pCCLNT, _pNORSCI, _pNESTDO)
                Case TipoLog.PreEmbarque
                    odtDatos = obrEmbarque.Listar_Log_X_Carga_Internacional(_pCCLNT, _pNRPEMB, _pNESTDO)
                Case TipoLog.EmbarquePreEmbarque
                    odtDatos = obrEmbarque.Listar_Log_X_Carga_Internacional_Embarque_Aduana(_pCCLNT, _pNORSCI, _pNESTDO)
            End Select
            dtgCheckPointLog.DataSource = odtDatos
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class
