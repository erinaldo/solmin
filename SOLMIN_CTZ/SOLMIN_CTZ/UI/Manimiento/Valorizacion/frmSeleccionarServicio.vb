Imports Db2Manager.RansaData.iSeries.DataObjects

Imports Ransa.Utilitario
Imports System.Windows.Forms
Imports SOLMIN_CTZ.NEGOCIO
Imports SOLMIN_CTZ.Entidades

Public Class frmSeleccionarServicio

    Private _pCCMPN As String
    Public Property pCCMPN() As String
        Get
            Return _pCCMPN
        End Get
        Set(ByVal value As String)
            _pCCMPN = value
        End Set
    End Property

    Private _pCDVSN As String
    Public Property pCDVSN() As String
        Get
            Return _pCDVSN
        End Get
        Set(ByVal value As String)
            _pCDVSN = value
        End Set
    End Property

    Private _pCPLNDV As Double
    Public Property pCPLNDV() As Double
        Get
            Return _pCPLNDV
        End Get
        Set(ByVal value As Double)
            _pCPLNDV = value
        End Set
    End Property

    Private _pCCLNT As Double
    Public Property pCCLNT() As Double
        Get
            Return _pCCLNT
        End Get
        Set(ByVal value As Double)
            _pCCLNT = value
        End Set
    End Property

    Private _pNRTFSV As Double
    Public Property pNRTFSV() As Double
        Get
            Return _pNRTFSV
        End Get
        Set(ByVal value As Double)
            _pNRTFSV = value
        End Set
    End Property

    Private _pDESTAR As String
    Public Property pDESTAR() As String
        Get
            Return _pDESTAR
        End Get
        Set(ByVal value As String)
            _pDESTAR = value
        End Set
    End Property

    Private _pTSGNMN As String
    Public Property pTSGNMN() As String
        Get
            Return _pTSGNMN
        End Get
        Set(ByVal value As String)
            _pTSGNMN = value
        End Set
    End Property

    Private Sub frmAgregarServicioValorizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Listar_Servicios_Valorizacion()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Sub Listar_Servicios_Valorizacion()

        Dim Negocio As New clsMantValorizacion
        Dim Entidad As New beMantValorizacion
        dtgSeleccionarServicio.DataSource = Nothing
        dtgSeleccionarServicio.AutoGenerateColumns = False

        With Entidad
            .CCMPN = pCCMPN
            .CDVSN = pCDVSN
            .CPLNDV = pCPLNDV
            .CCLNT = pCCLNT
        End With

        dtgSeleccionarServicio.DataSource = Negocio.Listar_Servicios_Valorizacion(Entidad)

    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try

            If dtgSeleccionarServicio.CurrentRow Is Nothing Then
                Exit Sub
            End If

            pNRTFSV = dtgSeleccionarServicio.CurrentRow.Cells("NRTFSV").Value
            pDESTAR = dtgSeleccionarServicio.CurrentRow.Cells("DESTAR").Value.ToString.Trim
            pTSGNMN = dtgSeleccionarServicio.CurrentRow.Cells("TSGNMN").Value
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub dtgSeleccionarServicio_DoubleClick(sender As Object, e As EventArgs) Handles dtgSeleccionarServicio.DoubleClick
        Try

            pNRTFSV = dtgSeleccionarServicio.CurrentRow.Cells("NRTFSV").Value
            pDESTAR = dtgSeleccionarServicio.CurrentRow.Cells("DESTAR").Value.ToString.Trim
            pTSGNMN = dtgSeleccionarServicio.CurrentRow.Cells("TSGNMN").Value
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class


