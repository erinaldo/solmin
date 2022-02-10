Imports Db2Manager.RansaData.iSeries.DataObjects
Imports SOLMIN_ST.NEGOCIO.mantenimientos
Imports SOLMIN_ST.ENTIDADES.Mantenimientos
Imports CrystalDecisions.CrystalReports.Engine
Imports Ransa.Utilitario

Public Class frmControlFlota

#Region "Declaracion de Variables"
    Private bolBuscar As Boolean = False
#End Region

#Region "Eventos"
    Private Sub frmControlFlota_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.pnlBotones.Refresh()
        Cargar_Compania()
    End Sub

    Private Sub cmbCompania_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCompania.SelectedIndexChanged
        If bolBuscar Then
            Cargar_Division()
            If cmbDivision.SelectedValue <> "" Then
                If cmbPlanta.SelectedValue <> "" Then
                    Cargar_Tipos_Carroceria()
                End If
            End If
        End If

    End Sub

    Private Sub cmbDivision_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDivision.SelectedIndexChanged
        If bolBuscar Then
            Cargar_Planta()
            If cmbPlanta.SelectedValue <> "" Then
                Cargar_Tipos_Carroceria()
            End If
        End If

    End Sub

    Private Sub cmbPlanta_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPlanta.SelectedIndexChanged
        If bolBuscar = True Then
            If cmbPlanta.SelectedValue <> "" Then
                Cargar_Tipos_Carroceria()
            End If
        End If

    End Sub

    Private Sub ControlFlotaUnidades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 'ByVal CodTipoCarroceria As Double
        Dim frmControlFlota As New frmControlFlotaUnidades
        With frmControlFlota
            .CTPCRA = sender.Tag.ToString
            .CCMPN = cmbCompania.SelectedValue
            .CDVSN = cmbDivision.SelectedValue
            .CPLNDV = cmbPlanta.SelectedValue
            .ShowDialog()
        End With
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub pnlBotones_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Cargar_Tipos_Carroceria()
    End Sub
#End Region

#Region "Metodos"

    Private Sub Cargar_Compania()
        Try
            Dim objCompaniaBLL As New NEGOCIO.Compania_BLL
            bolBuscar = False
            objCompaniaBLL.Crea_Lista()
            cmbCompania.DataSource = objCompaniaBLL.Lista
            cmbCompania.ValueMember = "CCMPN"
            cmbCompania.DisplayMember = "TCMPCM"
            bolBuscar = True
            'cmbCompania.SelectedValue = "EZ"
            'If cmbCompania.SelectedIndex = -1 Then
            '    cmbCompania.SelectedIndex = 0
            'End If

            Ransa.Utilitario.HelpClass.HabilitarCompaniaActual(Me.cmbCompania, Ransa.Utilitario.MainModuleDeploy.IdCompaniaDeploy)
            cmbCompania_SelectedIndexChanged(Nothing, Nothing)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Cargar_Division()
        Dim objDivision As New NEGOCIO.Division_BLL
        Try
            If (bolBuscar = True And Me.cmbCompania.SelectedValue IsNot Nothing) Then
                bolBuscar = False
                objDivision.Crea_Lista()
                cmbDivision.DataSource = objDivision.Lista_Division(Me.cmbCompania.SelectedValue.ToString.Trim)
                cmbDivision.ValueMember = "CDVSN"
                bolBuscar = True
                cmbDivision.DisplayMember = "TCMPDV"
                Me.cmbDivision.SelectedValue = "T"
                If Me.cmbDivision.SelectedIndex = -1 Then
                    Me.cmbDivision.SelectedIndex = 0
                End If
                cmbDivision_SelectedIndexChanged(Nothing, Nothing)
            End If
        Catch ex As Exception
            HelpClass.MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Planta()
        Dim objPlanta As New NEGOCIO.Planta_BLL
        Dim objLisEntidad As New List(Of ENTIDADES.mantenimientos.ClaseGeneral)
        Try
            If (bolBuscar = True And Me.cmbCompania.SelectedValue IsNot Nothing And Me.cmbDivision.SelectedValue IsNot Nothing) Then
                bolBuscar = False
                objPlanta.Crea_Lista()
                objLisEntidad = objPlanta.Lista_Planta(Me.cmbCompania.SelectedValue, Me.cmbDivision.SelectedValue)
                cmbPlanta.DataSource = objLisEntidad
                cmbPlanta.ValueMember = "CPLNDV"
                cmbPlanta.DisplayMember = "TPLNTA"
                Me.cmbPlanta.SelectedIndex = 0
                bolBuscar = True
                cmbPlanta_SelectedIndexChanged(Nothing, Nothing)
            End If
        Catch ex As Exception

            HelpClass.MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Cargar_Tipos_Carroceria()
        Me.pnlBotones.Controls.Clear()
        Me.pnlBotones.Padding = New Padding(10%, 15%, 10%, 15%)
        Me.pnlBotones.FlowDirection = FlowDirection.TopDown
        Me.pnlBotones.Refresh()
        Dim objLogica As New TipoCarroceria_BLL
        Dim objEntidad As New TipoCarroceria
        objEntidad.CCMPN = cmbCompania.SelectedValue
        objEntidad.CDVSN = cmbDivision.SelectedValue
        objEntidad.CPLNDV = CType(cmbPlanta.SelectedValue, Double)
        Dim olTipoCarroceria As List(Of TipoCarroceria)
        olTipoCarroceria = objLogica.Listar_TipoCarroceria_DeBitacoraVehiculo(objEntidad)
        Dim i = 10

        For Each oTipoCarroceria As TipoCarroceria In olTipoCarroceria
            Dim boton As New ComponentFactory.Krypton.Toolkit.KryptonButton
            'Definir Tamaño Dinamico a Boton de acuerdo al Nro. de Tipo de Carroceria obtenida.
            Dim Alto As Integer = Me.pnlBotones.Size.Height
            Dim Ancho As Integer = Me.pnlBotones.Size.Width
            Dim TamVertTotMaxBotones As Integer = Alto - (olTipoCarroceria.Count * 10)
            Me.pnlBotones.Controls.Add(boton)
            boton.Location = New System.Drawing.Point(Ancho / 3, i)
            boton.Name = "btn" & oTipoCarroceria.TCMCRA.Replace(" ", "")
            boton.Size = New System.Drawing.Size(Ancho / 2.1, TamVertTotMaxBotones / (olTipoCarroceria.Count / 2))
            boton.Text = oTipoCarroceria.TARCRA.Trim.ToString
            Dim AltoFont As Integer
            If Alto > 700 Then
                AltoFont = Alto / 40
            Else
                AltoFont = Alto / 50
            End If
            boton.Cursor = Cursors.Hand
            boton.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", AltoFont, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            boton.Values.ExtraText = ""
            boton.Values.Image = Nothing
            boton.Tag = oTipoCarroceria.CTPCRA
            boton.Values.ImageStates.ImageCheckedNormal = Nothing
            boton.Values.ImageStates.ImageCheckedPressed = Nothing
            boton.Values.ImageStates.ImageCheckedTracking = Nothing
            boton.Values.Text = oTipoCarroceria.TARCRA.Trim.ToString.ToUpper
            AddHandler boton.Click, AddressOf ControlFlotaUnidades_Click
            boton.Visible = True
            i = i + (TamVertTotMaxBotones / olTipoCarroceria.Count) + 10
        Next
    End Sub

#End Region




End Class
