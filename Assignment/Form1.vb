Public Class Form1

    Private Sub btnExecute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExecute.Click
        Dim y As Integer = 40
        For x As Integer = 1 To Val(txtNum.Text)
            Dim tb As New TextBox
            tb.Name = "txtbox" + x.ToString()
            tb.Location() = New Point(20, y)
            Me.Controls.Add(tb)
            y = y + 30
        Next
        Dim btn As New Button
        btn.Name = "btnAdd"
        btn.Text = "Add"
        btn.Location() = New Point(140, 40)
        AddHandler btn.Click, AddressOf AddNumbers
        Me.Controls.Add(btn)
    End Sub
    Private Sub AddNumbers(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim sum As Integer = 0
        For Each ctrl As Control In Me.Controls
            If ctrl.GetType Is GetType(TextBox) Then
                sum = sum + Val(ctrl.Text)
            End If
        Next
        MessageBox.Show(sum - Val(txtNum.Text))
    End Sub

End Class
