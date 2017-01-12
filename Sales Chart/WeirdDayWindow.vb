Imports WHLClasses

Public Class WeirdDayWindow
    Private Sub RegisterBtn_Click(sender As Object, e As EventArgs) Handles RegisterBtn.Click
        'Check count
        Try
            'Preset Data
            Dim weird As String = ""
            If WeirdDayBox.Checked Then
                weird = "Yes"
            Else
                weird = "No"
            End If
            Dim DateString As String = WeirdDate.Value.ToString("yyyy/MM/dd")

            'Does a row exist in the table?
            Dim returned As ArrayList = MySQL.SelectData("SELECT * FROM whldata.salesdata_weirddays WHERE date='" + DateString + "';")

            'If so, replace. If not, insert.
            If returned.Count > 0 Then
                'Replace
                Dim replaced As Integer = MySQL.insertUpdate("UPDATE whldata.salesdata_weirddays SET weird='" + weird + "' WHERE date='" + DateString + "';")
                If replaced > 0 Then
                    'Succeeded
                Else
                    'Ded.
                End If
            Else
                'Insert
                Dim inserted As Integer = MySQL.insertUpdate("INSERT INTO whldata.salesdata_weirddays (date, weird) VALUES ('" + DateString + "', '" + weird + "');")
                If inserted > 0 Then
                    'Succeeded

                Else
                    'Ded.

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class