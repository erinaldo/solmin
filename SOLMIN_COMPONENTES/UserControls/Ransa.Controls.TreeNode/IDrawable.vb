Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Drawing

Public Interface IDrawable
    Function GetSize(ByVal gr As Graphics, ByVal font As Font) As SizeF
    Function IsAtPoint(ByVal gr As Graphics, ByVal font As Font, ByVal center_pt As PointF, ByVal target_pt As PointF) As Boolean
    Sub Draw(ByVal x As Single, ByVal y As Single, ByVal gr As Graphics, ByVal pen As Pen, ByVal bg_brush As TextureBrush, ByVal text_brush As Brush, ByVal font As Font)
End Interface
