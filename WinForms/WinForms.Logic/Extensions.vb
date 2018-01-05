Imports System.Windows.Forms
Imports System.Runtime.CompilerServices

Public Module Extensions
    ''' <summary>
    ''' Clear all fields inside a form.
    ''' </summary>
    ''' <param name="container"></param>
    ''' <remarks></remarks>
    <Extension()>
    Public Sub ClearFields(ByVal container As Windows.Forms.Form)
        For Each _control In container.Controls
            If _control.GetType() = GetType(TextBox) Then
                CType(_control, TextBox).Clear()
            ElseIf _control.GetType() = GetType(MaskedTextBox) Then
                CType(_control, MaskedTextBox).Clear()
            ElseIf _control.GetType() = GetType(ListBox) Then
                CType(_control, ListBox).SelectedItem = Nothing
            ElseIf _control.GetType() = GetType(ComboBox) Then
                CType(_control, ComboBox).SelectedItem = Nothing
            End If
            If _control.GetType() = GetType(Panel) Then
                For Each _panelControl In CType(_control, Panel).Controls

                    If _panelControl.GetType() = GetType(RadioButton) Then
                        CType(_panelControl, RadioButton).Checked = False
                    End If
                Next
            End If
        Next
    End Sub

    <Extension()>
    Public Function GetSelectedRadio(ByVal container As Windows.Forms.Form, ByVal containerName As String) As String
        Dim _iAmPanel As System.Windows.Forms.ScrollableControl = container.Controls.Item(containerName)
        Dim _tempResult = ""
        For Each radio In _iAmPanel.Controls
            If radio.GetType() = GetType(RadioButton) Then
                If CType(radio, RadioButton).Checked Then
                    _tempResult = CType(radio, RadioButton).Text
                End If
            End If
        Next
        Return _tempResult
    End Function
End Module
