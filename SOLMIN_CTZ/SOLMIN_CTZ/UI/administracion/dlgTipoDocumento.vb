Imports SOLMIN_CTZ.Entidades
Imports SOLMIN_CTZ.NEGOCIO
Imports System.Web
Imports Db2Manager.RansaData.iSeries.DataObjects

Public Class dlgTipoDocumento
    Private oTipoDocumento As SOLMIN_CTZ.NEGOCIO.clsTipoDocumento
    Dim _widthLeftRight As Int32
    Private Sub dlgTipoDocumento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TipoDocumento
        oTipoDocumento = New SOLMIN_CTZ.NEGOCIO.clsTipoDocumento
        Cargar_TipoDocumento()
    End Sub
    Private Sub Cargar_TipoDocumento()
        oTipoDocumento.Crea_TipoDocumento()

        lbTipoDocumento.DataSource = oTipoDocumento.Lista_TipoDocumento(1)
        lbTipoDocumento.ValueMember = "CTPODC"
        lbTipoDocumento.DisplayMember = "TCMTPD"
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim cadena As String = ""
        Me.Hide()
        If lbTipoDocumento.SelectedItems.Count <> 0 Then
            For Each view As DataRowView In lbTipoDocumento.SelectedItems
                cadena = view(lbTipoDocumento.ValueMember).ToString() & ", " & cadena
            Next
        End If
        cadena = cadena.Substring(0, cadena.Length - 2)
        'frmCtaCte.txtTipoDocumento.Text = cadena
        'MsgBox(cadena)
        Me.Close()
    End Sub

    Private Sub ButtonSpecHeaderGroup1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSpecHeaderGroup1.Click
        'Suspend layout changes until all splitter properties have been updated
        stcVertical.SuspendLayout()
        ' Is the left header group currently expanded?
        If stcVertical.FixedPanel = FixedPanel.None Then
            ' ''tsbAmpliar.Image = pbxReducir.Image
            ' ''tsbAmpliar.Text = "  Reducir"
            ' Make the left panel of the splitter fixed in size
            stcVertical.FixedPanel = FixedPanel.Panel1
            stcVertical.IsSplitterFixed = True
            ' Remember the current height of the header group
            _widthLeftRight = KryptonHeaderGroup2.Height
            ' We have not changed the orientation of the header yet, so the width of 
            ' the splitter panel is going to be the height of the collapsed header group
            Dim newWidth As Integer = KryptonHeaderGroup2.PreferredSize.Width
            ' Make the header group fixed just as the new height
            stcVertical.Panel1MinSize = newWidth
            stcVertical.SplitterDistance = newWidth
            ' Change header to be vertical and button to near edge
            ' ''hgListaReportes.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
            ' ''hgFiltros.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Right
            'bsaVistaPreviaGS.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
            'bsaVistaPreviaGS.Orientation = ComponentFactory.Krypton.Toolkit.PaletteButtonOrientation.FixedRight
            'bsaGenerarGuiaRemision.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
            'bsaGenerarGuiaRemision.Orientation = ComponentFactory.Krypton.Toolkit.PaletteButtonOrientation.FixedRight
            'bsaVistaPreviaGR.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Near
            'bsaVistaPreviaGR.Orientation = ComponentFactory.Krypton.Toolkit.PaletteButtonOrientation.FixedRight
        Else
            ' ''tsbAmpliar.Image = pbxAmpliar.Image
            ' ''tsbAmpliar.Text = "  Ampliar"
            ' Make the bottom panel not-fixed in size anymore
            stcVertical.FixedPanel = FixedPanel.None
            stcVertical.IsSplitterFixed = False
            ' Put back the minimise size to the original
            stcVertical.Panel1MinSize = 25
            ' Calculate the correct splitter we want to put back
            stcVertical.SplitterDistance = _widthLeftRight
            ' Change header to be horizontal and button to far edge
            ' ''hgListaReportes.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
            ' ''hgFiltros.HeaderPositionPrimary = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top
            'bsaVistaPreviaGS.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Far
            'bsaVistaPreviaGS.Orientation = ComponentFactory.Krypton.Toolkit.PaletteButtonOrientation.Inherit
            'bsaGenerarGuiaRemision.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Far
            'bsaGenerarGuiaRemision.Orientation = ComponentFactory.Krypton.Toolkit.PaletteButtonOrientation.Inherit
            'bsaVistaPreviaGR.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Far
            'bsaVistaPreviaGR.Orientation = ComponentFactory.Krypton.Toolkit.PaletteButtonOrientation.Inherit
        End If
        stcVertical.ResumeLayout()
    End Sub

End Class
