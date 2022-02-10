
Imports ransa.Controls.Operaciones
Imports ransa.Controls.mantenimientos
Imports System.Windows.Forms

Public Class frmGenerarOS

    Private lobjEntidad As OrdenServicioTransporte


  Public Sub New(ByVal objEntidad As OrdenServicioTransporte)

    ' This call is required by the Windows Form Designer.
    InitializeComponent()
    ' Add any initialization after the InitializeComponent() call.
    lobjEntidad = objEntidad
    CargarCombos()
    Me.txtCliente.CCMPN = objEntidad.CCMPN
    Me.txtCliente.pCargar(lobjEntidad.CCLNT)
    Me.ctbCentroCostoPropio.Codigo = 466
    Me.ctbCentroCostoTercero.Codigo = 467
    Me.ctbSectorGasto.Codigo = "M"

  End Sub

  Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
    If Validar() Then
            GenerarOS()
            'GenerarOSxDetalleCotizacion()
    End If
  End Sub

  Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
    Me.DialogResult = Windows.Forms.DialogResult.Cancel
  End Sub

  Private Function Validar() As Boolean
    Dim strError As String = "DEBE DE INGRESAR: " & Chr(13)

    If Me.txtCliente.pCodigo = 0 Then
      strError += "* CLIENTE FACTURACION" & Chr(13)
    End If
    If Me.ctbSectorGasto.NoHayCodigo Then
      strError += "* SECTRO X GASTO" & Chr(13)
    End If
    If Me.ctbCentroCostoPropio.NoHayCodigo Then
      strError += "* CENTRO COSTO PROPIO" & Chr(13)
    End If
    If Me.ctbCentroCostoTercero.NoHayCodigo Then
      strError += "* CENTRO COSTO TERCERO" & Chr(13)
    End If
    If strError.Trim.Length > 17 Then
      HelpClass.MsgBox(strError, MessageBoxIcon.Warning)
      Return False
    Else
      Return True
    End If
  End Function

  Private Sub CargarCombos()
    Dim objNegocioSectorXGastos As New SectorXGastos_BLL()
    With Me.ctbSectorGasto
      .DataSource = objNegocioSectorXGastos.Lista_SectorXGastos
      .KeyField = "COD"
      .ValueField = "DES"
      .DataBind()
    End With

    Dim objNegociosCentroCosto As New CentroCosto_BLL()
        Dim objEntidad As New CentroCosto
    objEntidad.CCMPN = lobjEntidad.CCMPN
    Dim objTabla As DataTable = HelpClass.GetDataSetNative(objNegociosCentroCosto.Listar_Centro_Costo(objEntidad))

    With ctbCentroCostoPropio
      .DataSource = objTabla.Copy
      .KeyField = "CCNTCS"
      .ValueField = "TCNTCS"
      .DataBind()
    End With

    With ctbCentroCostoTercero
      .DataSource = objTabla.Copy
      .KeyField = "CCNTCS"
      .ValueField = "TCNTCS"
      .DataBind()
    End With

  End Sub

  Private Sub GenerarOS()
    Dim objEntidad As New Hashtable
    Dim objNegocios As New OrdenServicio_BLL
    Try
      objEntidad.Add("PNNCTZCN", lobjEntidad.NCTZCN)
      objEntidad.Add("PNCCLNT", lobjEntidad.CCLNT)
      objEntidad.Add("PSCCMPN", lobjEntidad.CCMPN)
      objEntidad.Add("PSCDVSN", lobjEntidad.CDVSN)
      objEntidad.Add("PNCPLNDV", lobjEntidad.CPLNDV)
      objEntidad.Add("PNCCLNFC", txtCliente.pCodigo)
      objEntidad.Add("PSSSCGST", ctbSectorGasto.Codigo)
      objEntidad.Add("PNCCNCST", ctbCentroCostoPropio.Codigo)
      objEntidad.Add("PNCCNCS1", ctbCentroCostoTercero.Codigo)
      objEntidad.Add("PSCUSCRT", MainModule.USUARIO)
      objEntidad.Add("PNFCHCRT", HelpClass.TodayNumeric)
      objEntidad.Add("PNHRACRT", HelpClass.NowNumeric)
      objEntidad.Add("PSNTRMCR", HelpClass.NombreMaquina)

      Dim intResultado As Integer
      intResultado = objNegocios.GenerarOS(objEntidad)
      If intResultado = 0 Then
        Me.DialogResult = Windows.Forms.DialogResult.OK
      Else
        HelpClass.ErrorMsgBox()
      End If
    Catch ex As Exception
    End Try
    End Sub

    Private Sub GenerarOSxDetalleCotizacion()
        Dim objEntidad As New Hashtable
        Dim objNegocios As New OrdenServicio_BLL
        Try
            objEntidad.Add("PNNCTZCN", lobjEntidad.NCTZCN)
            objEntidad.Add("PNCCLNT", lobjEntidad.CCLNT)
            objEntidad.Add("PSCCMPN", lobjEntidad.CCMPN)
            objEntidad.Add("PSCDVSN", lobjEntidad.CDVSN)
            objEntidad.Add("PNCPLNDV", lobjEntidad.CPLNDV)
            objEntidad.Add("PNCCLNFC", txtCliente.pCodigo)
            objEntidad.Add("PSSSCGST", ctbSectorGasto.Codigo)
            objEntidad.Add("PNCCNCST", ctbCentroCostoPropio.Codigo)
            objEntidad.Add("PNCCNCS1", ctbCentroCostoTercero.Codigo)
            objEntidad.Add("PSCUSCRT", MainModule.USUARIO)
            objEntidad.Add("PNFCHCRT", HelpClass.TodayNumeric)
            objEntidad.Add("PNHRACRT", HelpClass.NowNumeric)
            objEntidad.Add("PSNTRMCR", HelpClass.NombreMaquina)
            objEntidad.Add("PNCRRCT", lobjEntidad.NCRRCT)

            Dim intResultado As Integer
            intResultado = Convert.ToInt32(objNegocios.GenerarOSxDetalleCotizacion(objEntidad))
            If intResultado = 0 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                HelpClass.ErrorMsgBox()
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class
