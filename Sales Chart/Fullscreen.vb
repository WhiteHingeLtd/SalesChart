Public Class Fullscreen
    Public formReference As SalesDataForm

    Private Sub RefreshTimer_Tick(sender As Object, e As EventArgs) Handles RefreshTimer.Tick
        formReference.GenerateButton.PerformClick()
        LoadingLbl.Visible = True
    End Sub

    Private Sub Fullscreen_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        formReference.Close()
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub SalesGrid_Click(sender As Object, e As EventArgs) Handles SalesGrid.Click
        For Each row As DataGridViewRow In SalesGrid.Rows
            row.Selected = False
        Next
    End Sub

    Private Sub Fullscreen_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        SalesGrid.BorderStyle = BorderStyle.None
    End Sub

    Private Sub SwitchFocus_Click(sender As Object, e As EventArgs) Handles SwitchFocus.Click
        formReference.Focus()
    End Sub
End Class