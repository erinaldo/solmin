Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmOpRptTransportista
    Private objPrintForm As PrintForm
    Private _NRUCTR As String = ""


    Private _CCMPN As String
    Public Property CCMPN() As String
        Get
            Return _CCMPN
        End Get
        Set(ByVal value As String)
            _CCMPN = value
        End Set
    End Property

    Private _CDVSN As String
    Public Property CDVSN() As String
        Get
            Return _CDVSN
        End Get
        Set(ByVal value As String)
            _CDVSN = value
        End Set
    End Property


    Private _CPLNDV As Double
    Public Property CPLNDV() As Double
        Get
            Return _CPLNDV
        End Get
        Set(ByVal value As Double)
            _CPLNDV = value
        End Set
    End Property


    Public Sub ShowForm(ByVal owner As IWin32Window)
        'Forzando destruccion de memoria
        ClearMemory()
        'Mostrando el formulario
        Me.ShowDialog(owner)
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        imprimir()
        Me.Close()
    End Sub

    Public Sub imprimir()
        Dim objDs As New DataSet
        Dim objPrintForm As New PrintForm
        Dim objRepT As New rptTransportista

        Dim objTransportista As New Transportista
        Dim objRepTransportista As New Transportista_BLL

        Dim objVehiculo As New TransportistaTracto
        Dim objRepVehiculo As New TransportistaTracto_BLL

        Dim objAcoplado As New TransportistaAcoplado
        Dim objRepAcoplado As New TransportistaAcoplado_BLL

        Dim objConductor As New TransportistaConductor
        Dim objRepConductor As New TransportistaConductor_BLL

        'Datos Generales del Transportista
        objTransportista.NRUCTR = _NRUCTR
        objTransportista.CCMPN = _CCMPN
        objRepT.SetDataSource(AgregarDT(objRepTransportista.Listar_TransportistaRPT(objTransportista), "TRANSPORTISTA").Copy)

        Try
            Dim lstr_MostrarSubRptVehiculo As Integer = 0
            Dim lstr_MostrarSubRptAcoplado As Integer = 0
            Dim lstr_MostrarSubRptConductor As Integer = 0

            'Datos de Vehiculos
            If Me.chkVehiculos.Checked Then
                lstr_MostrarSubRptVehiculo = 1
                objVehiculo.NRUCTR = objTransportista.NRUCTR
                objVehiculo.CCMPN = _CCMPN
                objVehiculo.CDVSN = _CDVSN
                objVehiculo.CPLNDV = _CPLNDV


                Dim dtbVehiculos As New DataTable
                'dtbVehiculos = objRepVehiculo.Listar_TractosPorTransportista(objVehiculo)
                If dtbVehiculos.Rows.Count > 0 Then
                    objRepT.OpenSubreport("rptTransportistaVehiculo.rpt").SetDataSource(dtbVehiculos)
                    objRepT.Refresh()
                End If
            End If


            'Datos de Acoplados 
            If Me.chkAcoplados.Checked Then
                lstr_MostrarSubRptAcoplado = 1
                objAcoplado.NRUCTR = objTransportista.NRUCTR
                objAcoplado.CCMPN = _CCMPN
                objAcoplado.CDVSN = _CDVSN
                objAcoplado.CPLNDV = _CPLNDV

                Dim dtbAcoplados As DataTable = objRepAcoplado.Listar_AcopladosPorTransportista_Reporte(objAcoplado)
                If dtbAcoplados.Rows.Count > 0 Then
                    objRepT.OpenSubreport("rptTransportistaAcoplado.rpt").SetDataSource(dtbAcoplados)
                    objRepT.Refresh()
                End If
            End If


            'Datos de Conductores
            If Me.chkConductores.Checked Then
                lstr_MostrarSubRptConductor = 1
                objConductor.NRUCTR = objTransportista.NRUCTR
                objConductor.CCMPN = _CCMPN
                objConductor.CDVSN = _CDVSN
                objConductor.CPLNDV = _CPLNDV

                Dim dtbConductores As DataTable = objRepConductor.Listar_ConductoresPorTransportista_Reporte(objConductor)
                If dtbConductores.Rows.Count > 0 Then
                    objRepT.OpenSubreport("rptTransportistaConductor.rpt").SetDataSource(dtbConductores)
                    objRepT.Refresh()
                End If
            End If

            objRepT.SetParameterValue("pMostrarSubRepVehiculo", lstr_MostrarSubRptVehiculo)
            objRepT.SetParameterValue("pMostrarSubRptAcoplado", lstr_MostrarSubRptAcoplado)
            objRepT.SetParameterValue("pMostrarSubRptConductor", lstr_MostrarSubRptConductor)


            objPrintForm.ShowForm(objRepT, Me)
        Catch ex As Exception
            MsgBox("Error: " & "ex.Message: " & ex.Message & vbCrLf & " EX.Source: " & ex.Source)
        End Try
    End Sub

    Private Function AgregarDT(ByVal dt As DataTable, ByVal dtName As String) As DataTable
        dt.TableName = dtName
        Return dt
    End Function

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class
