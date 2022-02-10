Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Text
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

<DefaultProperty("Text"), ToolboxData("<{0}:DataCombo runat=server></{0}:DataCombo>")> _
Public Class DataCombo
    Inherits DropDownList

    Public Overrides Property ID() As String
        Get
            Return MyBase.ID
        End Get
        Set(ByVal value As String)
            MyBase.ID = value
        End Set
    End Property

    Protected Overrides Sub RenderContents(ByVal output As HtmlTextWriter)
        output.Write(Text)
    End Sub

    Private Sub RenderWebControl(ByVal out As HtmlTextWriter)

    End Sub

End Class
