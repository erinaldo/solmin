Public Class CompletColumn
    Inherits DataGridViewColumn

    Public Sub New()
        MyBase.New(New CompletCell())
    End Sub


    Private _dtTemp As DataTable
    Public Property dtTemp() As DataTable
        Get
            Return _dtTemp
        End Get
        Set(ByVal value As DataTable)
            _dtTemp = value
        End Set
    End Property

    Public Overrides Property CellTemplate() As DataGridViewCell
        Get
            Return MyBase.CellTemplate
        End Get
        Set(ByVal value As DataGridViewCell)

            ' Ensure that the cell used for the template is a CalendarCell.
            If (value IsNot Nothing) AndAlso _
                Not value.GetType().IsAssignableFrom(GetType(CompletCell)) _
                Then
                Throw New InvalidCastException("Must be a complet")
            End If
            MyBase.CellTemplate = value

        End Set
    End Property

End Class

Public Class CompletCell
    Inherits DataGridViewTextBoxCell


    Public Sub New()
        ' Use the short date format.
        Me.Style.Format = "d"

    End Sub

    Private _dtTemp As DataTable

    Public Property dtTemp() As DataTable
        Get
            Return _dtTemp
        End Get
        Set(ByVal value As DataTable)
            _dtTemp = value
        End Set
    End Property

    Public Overrides Sub InitializeEditingControl(ByVal rowIndex As Integer, _
                                            ByVal initialFormattedValue As Object, _
                                            ByVal dataGridViewCellStyle As DataGridViewCellStyle)
        ' Set the value of the editing control to the current cell value.
        MyBase.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle)
        Dim ctl As CompletEditingControl = CType(DataGridView.EditingControl, CompletEditingControl)

        Try

            

            If Me.Value Is Nothing OrElse Me.Value Is DBNull.Value Then
                ctl.Value = Now
            Else
                ctl.Value = CType(Me.Value, DateTime)
            End If
        Catch ex As Exception
        End Try

    End Sub

    Public Overrides ReadOnly Property EditType() As Type
        Get
            ' Return the type of the editing contol that CalendarCell uses.
            Return GetType(CalendarEditingControl)
        End Get
    End Property

    Public Overrides ReadOnly Property ValueType() As Type
        Get
            ' Return the type of the value that CalendarCell contains.
            Return GetType(DateTime)
        End Get
    End Property

    Public Overrides ReadOnly Property DefaultNewRowValue() As Object
        Get
            ' Use the current date and time as the default value.
            Return DateTime.Now
        End Get
    End Property

End Class

Class CompletEditingControl
    Inherits TextBox
    Implements IDataGridViewEditingControl

    Private dataGridViewControl As DataGridView
    Private valueIsChanged As Boolean = False
    Private rowIndexNum As Integer

    Public Sub New()
        ' Me. = DateTimePickerFormat.Short
        Me.AutoCompleteMode = Windows.Forms.AutoCompleteMode.Append
        Me.AutoCompleteSource = Windows.Forms.AutoCompleteSource.CustomSource
    End Sub

    Public Property EditingControlFormattedValue() As Object _
        Implements IDataGridViewEditingControl.EditingControlFormattedValue
        Get
            Return Me.Value
        End Get
        Set(ByVal value As Object)
            If TypeOf value Is String Then

                If Not (value.ToString.Trim = "" Or value.ToString.Trim = "0") Then
                    Me.Value = DateTime.Parse(CStr(value))
                End If

            End If
        End Set
    End Property

    Public Function GetEditingControlFormattedValue(ByVal context _
        As DataGridViewDataErrorContexts) As Object _
        Implements IDataGridViewEditingControl.GetEditingControlFormattedValue
        Return Me.Value.ToShortDateString()
    End Function

    Public Sub ApplyCellStyleToEditingControl(ByVal dataGridViewCellStyle As _
        DataGridViewCellStyle) _
        Implements IDataGridViewEditingControl.ApplyCellStyleToEditingControl
        Me.Font = dataGridViewCellStyle.Font
        Me.CalendarForeColor = dataGridViewCellStyle.ForeColor
        Me.CalendarMonthBackground = dataGridViewCellStyle.BackColor
    End Sub

    Public Property EditingControlRowIndex() As Integer _
        Implements IDataGridViewEditingControl.EditingControlRowIndex
        Get
            Return rowIndexNum
        End Get
        Set(ByVal value As Integer)
            rowIndexNum = value
        End Set
    End Property

    Public Function EditingControlWantsInputKey(ByVal key As Keys, _
        ByVal dataGridViewWantsInputKey As Boolean) As Boolean _
        Implements IDataGridViewEditingControl.EditingControlWantsInputKey
        ' Let the DateTimePicker handle the keys listed.
        Select Case key And Keys.KeyCode
            Case Keys.Left, Keys.Up, Keys.Down, Keys.Right, _
                Keys.Home, Keys.End, Keys.PageDown, Keys.PageUp
                Return True
            Case Else
                Return Not dataGridViewWantsInputKey
        End Select
    End Function

    Public Sub PrepareEditingControlForEdit(ByVal selectAll As Boolean) _
        Implements IDataGridViewEditingControl.PrepareEditingControlForEdit
        ' No preparation needs to be done.
    End Sub

    Public ReadOnly Property RepositionEditingControlOnValueChange() _
        As Boolean Implements _
        IDataGridViewEditingControl.RepositionEditingControlOnValueChange

        Get
            Return False
        End Get

    End Property

    Public Property EditingControlDataGridView() As DataGridView _
        Implements IDataGridViewEditingControl.EditingControlDataGridView

        Get
            Return dataGridViewControl
        End Get
        Set(ByVal value As DataGridView)
            dataGridViewControl = value
        End Set

    End Property

    Public Property EditingControlValueChanged() As Boolean _
        Implements IDataGridViewEditingControl.EditingControlValueChanged

        Get
            Return valueIsChanged
        End Get
        Set(ByVal value As Boolean)
            valueIsChanged = value
        End Set

    End Property

    Public ReadOnly Property EditingControlCursor() As Cursor _
        Implements IDataGridViewEditingControl.EditingPanelCursor

        Get
            Return MyBase.Cursor
        End Get

    End Property

    Protected Overrides Sub OnValueChanged(ByVal eventargs As EventArgs) Implements IDataGridViewEditingControl.EditingPanelCursor

        ' Notify the DataGridView that the contents of the cell have changed.
        valueIsChanged = True
        Me.EditingControlDataGridView.NotifyCurrentCellDirty(True)
        MyBase.OnValueChanged(eventargs)

    End Sub

    Protected Sub Validated(ByVal sender As Object, ByVal e As System.EventArgs) Implements CompletEditingControl.EditingPanelCursor
        sUnidadActual = txtUnidad.Text
    End Sub

    Private Overrides Sub txtUnidad_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Implements CompletEditingControl.Validating
        If sUnidadActual.ToUpper.Trim <> txtUnidad.Text.ToUpper.Trim Then
            Dim sTemp As String = ""
            For Each sTemp In txtUnidad.AutoCompleteCustomSource
                If sTemp.ToUpper.Trim = txtUnidad.Text.ToUpper.Trim Then
                    txtUnidad.Text = sTemp
                    Exit Sub
                End If
            Next
        End If
    End Sub

End Class