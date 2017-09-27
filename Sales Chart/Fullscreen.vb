Public Class Fullscreen
    Public formReference As SalesDataForm
    Public RowHeight As Integer = 40

    Private Sub RefreshTimer_Tick(sender As Object, e As EventArgs) Handles RefreshTimer.Tick
        formReference.GenerateButton.PerformClick()
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

    Private Sub SwitchFocus_Click(sender As Object, e As EventArgs) Handles Progress.Click
        formReference.Focus()
    End Sub

    Private Sub RowHeightUp_Click(sender As Object, e As EventArgs) Handles RowHeightUp.Click
        RowHeight += 5
        If RowHeight > 80 Then
            RowHeight = 80
        End If
        ChangeRowHeight()
    End Sub

    Private Sub RowHeightDown_Click(sender As Object, e As EventArgs) Handles RowHeightDown.Click
        RowHeight -= 5
        If RowHeight < 10 Then
            RowHeight = 10
        End If
        ChangeRowHeight()
    End Sub

    Private Sub ChangeRowHeight()
        For Each row As DataGridViewRow In SalesGrid.Rows
            If Not IsNothing(row.Tag) Then
                If row.Tag = "Clonerow" Then
                    row.Height = RowHeight
                End If
            End If
        Next
    End Sub
End Class