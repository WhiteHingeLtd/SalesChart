Imports WHLClasses

Public Class SalesDataForm

    Dim SalesDataList As New ArrayList
    Dim WeirdDayList As New ArrayList
    Dim gridRowColl As New List(Of DataGridViewRow)
    Dim fullscreenForm As New Fullscreen

    Private Sub GenerateButton_Click(sender As Object, e As EventArgs) Handles GenerateButton.Click

        If Not LetMeLoadThatForYou.IsBusy Then
            If SalesGrid.Rows.Count > 0 Then
                SalesGrid.Rows.Clear()
            End If
            GenerateButton.Enabled = False
            WeeksBox.Enabled = False

            salesTotal = 0
            progressTotal = 0

            LetMeLoadThatForYou.RunWorkerAsync()
        End If

    End Sub

    Public MonRec As New KeyValuePair(Of Integer, String)
    Public TueRec As New KeyValuePair(Of Integer, String)
    Public WedRec As New KeyValuePair(Of Integer, String)
    Public ThuRec As New KeyValuePair(Of Integer, String)
    Public FriRec As New KeyValuePair(Of Integer, String)
    Public SatRec As New KeyValuePair(Of Integer, String)
    Public SunRec As New KeyValuePair(Of Integer, String)

    Private Sub LetMeLoadThatForYou_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles LetMeLoadThatForYou.DoWork
        'Set up KVPs
        Dim newKVP As KeyValuePair(Of Integer, String) = New KeyValuePair(Of Integer, String)(0, "")
        MonRec = newKVP
        TueRec = newKVP
        WedRec = newKVP
        ThuRec = newKVP
        FriRec = newKVP
        SatRec = newKVP
        SunRec = newKVP
        'Know what today's date is in an easily obtained Date value
        Dim StartDate As Date = Today
        Dim WeeksToGet As Integer = 0
        If IsNumeric(WeeksBox.Text.Trim) Then WeeksToGet = Convert.ToInt32(WeeksBox.Text.Trim) - 1

        'If today isn't monday, go back to when it was.
        While Not StartDate.DayOfWeek = 1
            StartDate = StartDate.AddDays(-1)
        End While
        'Cool, now get the end date.
        Dim EndDate As Date = StartDate.AddDays(-7 * WeeksToGet)

        Dim QueryFailed As Boolean = False
        'WHY ARE WE DOING PER-DAY QUERIES??? Do one instead, much simpler.
        Try
            If SalesDataList.Count > 0 Then
                SalesDataList.Clear()
            End If

            Dim extraSixteenWeeks As Date = EndDate.AddDays(-112) '7 * 16

            GetSalesDataList(extraSixteenWeeks)
            salesTotal = SalesDataList.Count
        Catch ex As Exception
            QueryFailed = True 'In the event things go sideways
        End Try

        Dim WeekLoop As Integer = 0 'Our incrementing figure
        If Not QueryFailed Then 'Things didn't go sideways
            While WeekLoop <= WeeksToGet + 16 'Plus 16 weeks
                Dim Weekdate = StartDate.AddDays(WeekLoop * -7) 'So we go back a week from our current day. If we start at zero, we dont want a multiplier of 0 so we add that multiplier.
                Dim NewLine As New DataGridViewRow
                NewLine.CreateCells(SalesGrid)
                NewLine.Cells.Item(0).Value = Weekdate.AddDays(5).ToString("yyyy/MM/dd") 'We apparently use the NEXT saturday, because thats not fucking confusing

                'Saturdays - Weird how suddenly weekends are possible.
                Dim saturdaylist As New ArrayList
                Dim sundaylist As New ArrayList
                Dim mondaylist As New ArrayList
                Dim tuesdaylist As New ArrayList
                Dim wednesdaylist As New ArrayList
                Dim thursdaylist As New ArrayList
                Dim fridaylist As New ArrayList
                For Each AL As ArrayList In SalesDataList
                    'An actual order. What day?
                    If AL(2) = Weekdate.AddDays(-2).ToString("yyyy-MM-dd") Then
                        'Saturday
                        saturdaylist.Add(AL)
                        progressTotal += 1
                    ElseIf AL(2) = Weekdate.AddDays(-1).ToString("yyyy-MM-dd") Then
                        'Sunday
                        sundaylist.Add(AL)
                        progressTotal += 1
                    ElseIf AL(2) = Weekdate.ToString("yyyy-MM-dd") Then
                        'Monday
                        mondaylist.Add(AL)
                        progressTotal += 1
                    ElseIf AL(2) = Weekdate.AddDays(1).ToString("yyyy-MM-dd") Then
                        'Tuesday
                        tuesdaylist.Add(AL)
                        progressTotal += 1
                    ElseIf AL(2) = Weekdate.AddDays(2).ToString("yyyy-MM-dd") Then
                        'Wednesday
                        wednesdaylist.Add(AL)
                        progressTotal += 1
                    ElseIf AL(2) = Weekdate.AddDays(3).ToString("yyyy-MM-dd") Then
                        'Thursday
                        thursdaylist.Add(AL)
                        progressTotal += 1
                    ElseIf AL(2) = Weekdate.AddDays(4).ToString("yyyy-MM-dd") Then
                        'Friday
                        fridaylist.Add(AL)
                        progressTotal += 1
                    End If
                Next

                'Saturday
                Try
                    'Total
                    Dim satTot As Integer = 0
                    For Each saturdayTotal As ArrayList In saturdaylist
                        satTot += saturdayTotal(4)
                    Next
                    If satTot > SatRec.Key Then
                        SatRec = New KeyValuePair(Of Integer, String)(satTot, Weekdate.AddDays(-2).ToString("yyyy-MM-dd"))
                    End If

                    If satTot > 0 Then
                        NewLine.Cells(1).Value = satTot
                    ElseIf Weekdate.AddDays(-2) > Today Then
                        NewLine.Cells(1).Value = ""
                    Else
                        NewLine.Cells(1).Value = 0
                    End If

                    'Weird check for blue
                    For Each WL As ArrayList In WeirdDayList
                        If WL(0) = Weekdate.AddDays(-2).ToString("yyyy/MM/dd") Then
                            NewLine.Cells(1).Tag = WL(1)
                            Exit For
                        End If
                    Next

                Catch ex As Exception
                    NewLine.Cells(1).Value = "No data"
                    NewLine.Cells(1).Style.BackColor = Color.Pink
                End Try

                'Sunday
                Try
                    'Total
                    Dim sunTot As Integer = 0
                    For Each sundayTotal As ArrayList In sundaylist
                        sunTot += sundayTotal(4)
                    Next
                    If sunTot > SunRec.Key Then
                        SunRec = New KeyValuePair(Of Integer, String)(sunTot, Weekdate.AddDays(-1).ToString("yyyy-MM-dd"))
                    End If

                    If sunTot > 0 Then
                        NewLine.Cells(2).Value = sunTot
                    ElseIf Weekdate.AddDays(-1) > Today Then
                        NewLine.Cells(2).Value = ""
                    Else
                        NewLine.Cells(2).Value = 0
                    End If

                    'Weird
                    For Each WL As ArrayList In WeirdDayList
                        If WL(0) = Weekdate.AddDays(-1).ToString("yyyy/MM/dd") Then
                            NewLine.Cells(2).Tag = WL(1)
                            Exit For
                        End If
                    Next

                Catch ex As Exception
                    NewLine.Cells(2).Value = "No data"
                    NewLine.Cells(2).Style.BackColor = Color.Pink
                End Try

                'Monday
                Try
                    'Total
                    Dim monTot As Integer = 0
                    For Each mondayTotal As ArrayList In mondaylist
                        monTot += mondayTotal(4)
                    Next
                    If monTot > MonRec.Key Then
                        MonRec = New KeyValuePair(Of Integer, String)(monTot, Weekdate.ToString("yyyy-MM-dd"))
                    End If

                    If monTot > 0 Then
                        NewLine.Cells(3).Value = monTot
                    ElseIf Weekdate > Today Then
                        NewLine.Cells(3).Value = ""
                    Else
                        NewLine.Cells(3).Value = 0
                    End If

                    'Weird
                    For Each WL As ArrayList In WeirdDayList
                        If WL(0) = Weekdate.ToString("yyyy/MM/dd") Then
                            NewLine.Cells(3).Tag = WL(1)
                            Exit For
                        End If
                    Next

                Catch ex As Exception
                    NewLine.Cells(3).Value = "No data"
                    NewLine.Cells(3).Style.BackColor = Color.Pink
                End Try

                'Tuesday
                Try
                    'Total
                    Dim tuesTot As Integer = 0
                    For Each tuesdayTotal As ArrayList In tuesdaylist
                        tuesTot += tuesdayTotal(4)
                    Next
                    If tuesTot > TueRec.Key Then
                        TueRec = New KeyValuePair(Of Integer, String)(tuesTot, Weekdate.AddDays(1).ToString("yyyy-MM-dd"))
                    End If

                    If tuesTot > 0 Then
                        NewLine.Cells(4).Value = tuesTot
                    ElseIf Weekdate.AddDays(1) > Today Then
                        NewLine.Cells(4).Value = ""
                    Else
                        NewLine.Cells(4).Value = 0
                    End If

                    'Weird
                    For Each WL As ArrayList In WeirdDayList
                        If WL(0) = Weekdate.AddDays(1).ToString("yyyy/MM/dd") Then
                            NewLine.Cells(4).Tag = WL(1)
                            Exit For
                        End If
                    Next

                Catch ex As Exception
                    NewLine.Cells(4).Value = "No data"
                    NewLine.Cells(4).Style.BackColor = Color.Pink
                End Try

                'Wednesday
                Try
                    'Total
                    Dim wednesTot As Integer = 0
                    For Each wednesdayTotal As ArrayList In wednesdaylist
                        wednesTot += wednesdayTotal(4)
                    Next
                    If wednesTot > WedRec.Key Then
                        WedRec = New KeyValuePair(Of Integer, String)(wednesTot, Weekdate.AddDays(2).ToString("yyyy-MM-dd"))
                    End If

                    If wednesTot > 0 Then
                        NewLine.Cells(5).Value = wednesTot
                    ElseIf Weekdate.AddDays(2) > Today Then
                        NewLine.Cells(5).Value = ""
                    Else
                        NewLine.Cells(5).Value = 0
                    End If

                    'Weird
                    For Each WL As ArrayList In WeirdDayList
                        If WL(0) = Weekdate.AddDays(2).ToString("yyyy/MM/dd") Then
                            NewLine.Cells(5).Tag = WL(1)
                            Exit For
                        End If
                    Next

                Catch ex As Exception
                    NewLine.Cells(5).Value = "No data"
                    NewLine.Cells(5).Style.BackColor = Color.Pink
                End Try

                'Thursday
                Try
                    'Total
                    Dim thursTot As Integer = 0
                    For Each thursdayTotal As ArrayList In thursdaylist
                        thursTot += thursdayTotal(4)
                    Next
                    If thursTot > ThuRec.Key Then
                        ThuRec = New KeyValuePair(Of Integer, String)(thursTot, Weekdate.AddDays(3).ToString("yyyy-MM-dd"))
                    End If

                    If thursTot > 0 Then
                        NewLine.Cells(6).Value = thursTot
                    ElseIf Weekdate.AddDays(3) > Today Then
                        NewLine.Cells(6).Value = ""
                    Else
                        NewLine.Cells(6).Value = 0
                    End If

                    'Weird
                    For Each WL As ArrayList In WeirdDayList
                        If WL(0) = Weekdate.AddDays(3).ToString("yyyy/MM/dd") Then
                            NewLine.Cells(6).Tag = WL(1)
                            Exit For
                        End If
                    Next

                Catch ex As Exception
                    NewLine.Cells(6).Value = "No data"
                    NewLine.Cells(6).Style.BackColor = Color.Pink
                End Try

                'Friday
                Try
                    'Total
                    Dim friTot As Integer = 0
                    For Each fridayTotal As ArrayList In fridaylist
                        friTot += fridayTotal(4)
                    Next
                    If friTot > FriRec.Key Then
                        FriRec = New KeyValuePair(Of Integer, String)(friTot, Weekdate.AddDays(4).ToString("yyyy-MM-dd"))
                    End If

                    If friTot > 0 Then
                        NewLine.Cells(7).Value = friTot
                    ElseIf Weekdate.AddDays(4) > Today Then
                        NewLine.Cells(7).Value = ""
                    Else
                        NewLine.Cells(7).Value = 0
                    End If

                    'Weird
                    For Each WL As ArrayList In WeirdDayList
                        If WL(0) = Weekdate.AddDays(4).ToString("yyyy/MM/dd") Then
                            NewLine.Cells(7).Tag = WL(1)
                            Exit For
                        End If
                    Next

                Catch ex As Exception
                    NewLine.Cells(7).Value = "No data"
                    NewLine.Cells(7).Style.BackColor = Color.Pink
                End Try

                'Complete total
                Try
                    Dim newtotalvalue As Integer = 0
                    'Add Sat
                    If Not IsNothing(NewLine.Cells(1).Value) Then
                        If IsNumeric(NewLine.Cells(1).Value) Then
                            newtotalvalue += NewLine.Cells(1).Value
                        End If
                    End If
                    'Add Sun
                    If Not IsNothing(NewLine.Cells(2).Value) Then
                        If IsNumeric(NewLine.Cells(2).Value) Then
                            newtotalvalue += NewLine.Cells(2).Value
                        End If
                    End If
                    'Add Mon
                    If Not IsNothing(NewLine.Cells(3).Value) Then
                        If IsNumeric(NewLine.Cells(3).Value) Then
                            newtotalvalue += NewLine.Cells(3).Value
                        End If
                    End If
                    'Add Tue
                    If Not IsNothing(NewLine.Cells(4).Value) Then
                        If IsNumeric(NewLine.Cells(4).Value) Then
                            newtotalvalue += NewLine.Cells(4).Value
                        End If
                    End If
                    'Add Wed
                    If Not IsNothing(NewLine.Cells(5).Value) Then
                        If IsNumeric(NewLine.Cells(5).Value) Then
                            newtotalvalue += NewLine.Cells(5).Value
                        End If
                    End If
                    'Add Thu
                    If Not IsNothing(NewLine.Cells(6).Value) Then
                        If IsNumeric(NewLine.Cells(6).Value) Then
                            newtotalvalue += NewLine.Cells(6).Value
                        End If
                    End If
                    'Add Fri
                    If Not IsNothing(NewLine.Cells(7).Value) Then
                        If IsNumeric(NewLine.Cells(7).Value) Then
                            newtotalvalue += NewLine.Cells(7).Value
                        End If
                    End If

                    NewLine.Cells(8).Value = newtotalvalue
                    For Each celltag As DataGridViewCell In NewLine.Cells
                        If Not IsNothing(celltag.Tag) Then
                            If celltag.Tag = "Yes" Then
                                NewLine.Cells(8).Tag = "Yes"
                                Exit For
                            End If
                        End If
                    Next
                Catch ex As Exception
                    NewLine.Cells(8).Value = "No data"
                    NewLine.Cells(8).Style.BackColor = Color.Pink
                End Try

                For Each cell As DataGridViewCell In NewLine.Cells
                    If Not IsNothing(cell.Tag) Then
                        If cell.Tag = "Yes" Then
                            cell.Style.BackColor = Color.FromArgb(20, 20, 80)
                        End If
                    End If
                Next

                gridRowColl.Add(NewLine)

                LetMeLoadThatForYou.ReportProgress(1)

                WeekLoop += 1
            End While
        Else

        End If
    End Sub

    Dim salesTotal As Integer = 0
    Dim progressTotal As Integer = 0

    Private Sub LetMeLoadThatForYou_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles LetMeLoadThatForYou.RunWorkerCompleted

        GenerateButton.Enabled = True
        Dim cutoffDate As Date = Today.AddDays(-7 * (Convert.ToInt32(WeeksBox.Text.Trim) - 1))
        Dim FirstDateToDisplay As String = cutoffDate.ToString("yyyy/MM/dd")
        WeeksBox.Enabled = True


        If SalesGrid.Rows.Count > 0 Then
            SalesGrid.Rows.Clear()
        End If

        If showfullscreen Then
            If newScreen Then 'One time
                fullscreenForm = New Fullscreen
                fullscreenForm.formReference = Me
                fullscreenForm.Show()
                fullscreenForm.RefreshTimer.Enabled = True
                newScreen = False
            End If
            If fullscreenForm.SalesGrid.Rows.Count > 0 Then
                fullscreenForm.SalesGrid.Rows.Clear()
            End If
        End If

        'RECORDS
        Dim RecordRow As New DataGridViewRow
        Dim DateRow As New DataGridViewRow
        If showfullscreen Then
            RecordRow.CreateCells(fullscreenForm.SalesGrid)
            DateRow.CreateCells(fullscreenForm.SalesGrid)
            RecordRow.Height = 50
            DateRow.Height = 50
        Else
            RecordRow.CreateCells(SalesGrid)
            DateRow.CreateCells(SalesGrid)
        End If

        RecordRow.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DateRow.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        RecordRow.Cells(0).Value = "Records"
        DateRow.Cells(0).Value = "Rec. Date"
        'Get records

        RecordRow.Cells(1).Value = SatRec.Key
        DateRow.Cells(1).Value = SatRec.Value

        RecordRow.Cells(2).Value = SunRec.Key
        DateRow.Cells(2).Value = SunRec.Value

        RecordRow.Cells(3).Value = MonRec.Key
        DateRow.Cells(3).Value = MonRec.Value

        RecordRow.Cells(4).Value = TueRec.Key
        DateRow.Cells(4).Value = TueRec.Value

        RecordRow.Cells(5).Value = WedRec.Key
        DateRow.Cells(5).Value = WedRec.Value

        RecordRow.Cells(6).Value = ThuRec.Key
        DateRow.Cells(6).Value = ThuRec.Value

        RecordRow.Cells(7).Value = FriRec.Key
        DateRow.Cells(7).Value = FriRec.Value

        'SPACER
        Dim newrow As New DataGridViewRow
        If showfullscreen Then
            newrow.CreateCells(fullscreenForm.SalesGrid)
            newrow.Height = 20
        Else
            newrow.CreateCells(SalesGrid)
            newrow.Height = 5
        End If
        'WEEKLY ROWS
        Dim rowcollection As New List(Of DataGridViewRow)
        Dim topTotal As Integer = 0
        Dim topTotalDate As String = ""

        Dim SatTotals As New List(Of Integer)
        Dim SunTotals As New List(Of Integer)
        Dim MonTotals As New List(Of Integer)
        Dim TueTotals As New List(Of Integer)
        Dim WedTotals As New List(Of Integer)
        Dim ThuTotals As New List(Of Integer)
        Dim FriTotals As New List(Of Integer)
        Dim TotTotals As New List(Of Integer)
        For Each row As DataGridViewRow In gridRowColl

            Dim clonerow As New DataGridViewRow
            clonerow.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            If showfullscreen Then
                clonerow.CreateCells(fullscreenForm.SalesGrid)
                clonerow.Height = fullscreenForm.RowHeight
                clonerow.Tag = "Clonerow"
            Else
                clonerow.CreateCells(SalesGrid)
            End If
            clonerow.Cells(0).Value = row.Cells(0).Value
            clonerow.Cells(1).Value = row.Cells(1).Value
            clonerow.Cells(1).Style.BackColor = row.Cells(1).Style.BackColor
            clonerow.Cells(2).Value = row.Cells(2).Value
            clonerow.Cells(2).Style.BackColor = row.Cells(2).Style.BackColor
            clonerow.Cells(3).Value = row.Cells(3).Value
            clonerow.Cells(3).Style.BackColor = row.Cells(3).Style.BackColor
            clonerow.Cells(4).Value = row.Cells(4).Value
            clonerow.Cells(4).Style.BackColor = row.Cells(4).Style.BackColor
            clonerow.Cells(5).Value = row.Cells(5).Value
            clonerow.Cells(5).Style.BackColor = row.Cells(5).Style.BackColor
            clonerow.Cells(6).Value = row.Cells(6).Value
            clonerow.Cells(6).Style.BackColor = row.Cells(6).Style.BackColor
            clonerow.Cells(7).Value = row.Cells(7).Value
            clonerow.Cells(7).Style.BackColor = row.Cells(7).Style.BackColor
            clonerow.Cells(8).Value = row.Cells(8).Value
            clonerow.Cells(8).Style.BackColor = row.Cells(8).Style.BackColor
            rowcollection.Add(clonerow)

            If row.Cells(8).Value > topTotal Then
                topTotal = row.Cells(8).Value
                topTotalDate = row.Cells(0).Value
            End If
        Next
        'Final record retrieval
        RecordRow.Cells(8).Value = topTotal
        DateRow.Cells(8).Value = topTotalDate

        'Add the rows
        If showfullscreen Then
            fullscreenForm.SalesGrid.Rows.Add(RecordRow)
            fullscreenForm.SalesGrid.Rows.Add(DateRow)
            fullscreenForm.SalesGrid.Rows.Add(newrow)
        Else
            SalesGrid.Rows.Add(RecordRow)
            SalesGrid.Rows.Add(DateRow)
            SalesGrid.Rows.Add(newrow)
        End If
        rowcollection.Reverse()

        Dim fontSize As Integer = 0
        If showfullscreen Then
            fontSize = 25
        Else
            fontSize = 11.25
        End If

        'Debug stuff!
        'Dim DumbRows As Integer = 0
        For Each row As DataGridViewRow In rowcollection
            'Total check for green, ignoring cells that have a blue background or have no numeric value.
            'Sat
            If Not row.Cells(1).Style.BackColor = Color.FromArgb(20, 20, 80) And IsNumeric(row.Cells(1).Value) Then
                Dim totCheck As Integer = 0
                For Each dayTotal As Integer In SatTotals
                    If dayTotal > row.Cells(1).Value Then
                        totCheck += 1
                    End If
                Next
                SatTotals.Add(row.Cells(1).Value)
                If totCheck > 3 Then
                    'No change
                Else
                    row.Cells(1).Style.BackColor = Color.FromArgb(20, 60, 20)
                    If totCheck = 0 Then
                        row.Cells(1).Style.BackColor = Color.FromArgb(30, 80, 30)
                    End If
                End If
                totCheck = 0
            End If
            'Sun
            If Not row.Cells(2).Style.BackColor = Color.FromArgb(20, 20, 80) And IsNumeric(row.Cells(2).Value) Then
                Dim totCheck As Integer = 0
                For Each dayTotal As Integer In SunTotals
                    If dayTotal > row.Cells(2).Value Then
                        totCheck += 1
                    End If
                Next
                SunTotals.Add(row.Cells(2).Value)
                If totCheck > 3 Then
                    'No change
                Else
                    row.Cells(2).Style.BackColor = Color.FromArgb(20, 60, 20)
                    If totCheck = 0 Then
                        row.Cells(2).Style.BackColor = Color.FromArgb(30, 80, 30)
                    End If
                End If
                totCheck = 0
            End If
            'Mon
            If Not row.Cells(3).Style.BackColor = Color.FromArgb(20, 20, 80) And IsNumeric(row.Cells(3).Value) Then
                Dim totCheck As Integer = 0
                For Each dayTotal As Integer In MonTotals
                    If dayTotal > row.Cells(3).Value Then
                        totCheck += 1
                    End If
                Next
                MonTotals.Add(row.Cells(3).Value)
                If totCheck > 3 Then
                    'No change
                Else
                    row.Cells(3).Style.BackColor = Color.FromArgb(20, 60, 20)
                    If totCheck = 0 Then
                        row.Cells(3).Style.BackColor = Color.FromArgb(30, 80, 30)
                    End If
                End If
                totCheck = 0
            End If
            'Tue
            If Not row.Cells(4).Style.BackColor = Color.FromArgb(20, 20, 80) And IsNumeric(row.Cells(4).Value) Then
                Dim totCheck As Integer = 0
                For Each dayTotal As Integer In TueTotals
                    If dayTotal > row.Cells(4).Value Then
                        totCheck += 1
                    End If
                Next
                TueTotals.Add(row.Cells(4).Value)
                If totCheck > 3 Then
                    'No change
                Else
                    row.Cells(4).Style.BackColor = Color.FromArgb(20, 60, 20)
                    If totCheck = 0 Then
                        row.Cells(4).Style.BackColor = Color.FromArgb(30, 80, 30)
                    End If
                End If
                totCheck = 0
            End If
            'Wed
            If Not row.Cells(5).Style.BackColor = Color.FromArgb(20, 20, 80) And IsNumeric(row.Cells(5).Value) Then
                Dim totCheck As Integer = 0
                For Each dayTotal As Integer In WedTotals
                    If dayTotal > row.Cells(5).Value Then
                        totCheck += 1
                    End If
                Next
                WedTotals.Add(row.Cells(5).Value)
                If totCheck > 3 Then
                    'No change
                Else
                    row.Cells(5).Style.BackColor = Color.FromArgb(20, 60, 20)
                    If totCheck = 0 Then
                        row.Cells(5).Style.BackColor = Color.FromArgb(30, 80, 30)
                    End If
                End If
                totCheck = 0
            End If
            'Thu
            If Not row.Cells(6).Style.BackColor = Color.FromArgb(20, 20, 80) And IsNumeric(row.Cells(6).Value) Then
                Dim totCheck As Integer = 0
                For Each dayTotal As Integer In ThuTotals
                    If dayTotal > row.Cells(6).Value Then
                        totCheck += 1
                    End If
                Next
                ThuTotals.Add(row.Cells(6).Value)
                If totCheck > 3 Then
                    'No change
                Else
                    row.Cells(6).Style.BackColor = Color.FromArgb(20, 60, 20)
                    If totCheck = 0 Then
                        row.Cells(6).Style.BackColor = Color.FromArgb(30, 80, 30)
                    End If
                End If
                totCheck = 0
            End If
            'Fri
            If Not row.Cells(7).Style.BackColor = Color.FromArgb(20, 20, 80) And IsNumeric(row.Cells(7).Value) Then
                Dim totCheck As Integer = 0
                For Each dayTotal As Integer In FriTotals
                    If dayTotal > row.Cells(7).Value Then
                        totCheck += 1
                    End If
                Next
                FriTotals.Add(row.Cells(7).Value)
                If totCheck > 3 Then
                    'No change
                Else
                    row.Cells(7).Style.BackColor = Color.FromArgb(20, 60, 20)
                    If totCheck = 0 Then
                        row.Cells(7).Style.BackColor = Color.FromArgb(30, 80, 30)
                    End If
                End If
                totCheck = 0
            End If

            'Total Column
            If Not row.Cells(8).Style.BackColor = Color.FromArgb(20, 20, 80) And IsNumeric(row.Cells(8).Value) Then
                Dim totCheck As Integer = 0
                For Each dayTotal As Integer In TotTotals
                    If dayTotal > row.Cells(8).Value Then
                        totCheck += 1
                    End If
                Next
                TotTotals.Add(row.Cells(8).Value)
                If totCheck > 3 Then
                    'No change
                Else
                    row.Cells(8).Style.BackColor = Color.FromArgb(20, 60, 20)
                    If totCheck = 0 Then
                        row.Cells(8).Style.BackColor = Color.FromArgb(30, 80, 30)
                    End If
                End If
                totCheck = 0
            End If




            'Only show up from the date we want
            If row.Cells(0).Value > FirstDateToDisplay Then
                If showfullscreen Then
                    fullscreenForm.SalesGrid.Rows.Add(row)
                Else
                    SalesGrid.Rows.Add(row)
                End If
                'Else
                '    DumbRows += 1
            End If
        Next


        If showfullscreen Then
            For Each row As DataGridViewRow In fullscreenForm.SalesGrid.Rows
                row.Selected = False
            Next
            fullscreenForm.LastRefreshLbl.Text = "Last Refresh: " + Now.ToString("dddd HH:mm:ss").ToUpper
            'If Not DumbRows.ToString = "16" Then
            'fullscreenForm.DumbRowTxt.Text = DumbRows.ToString
            'Else
            'fullscreenForm.DumbRowTxt.Text = ""
            'End If
        Else
            For Each row As DataGridViewRow In SalesGrid.Rows
                row.Selected = False
            Next
        End If
        fullscreenForm.Progress.Visible = False
        gridRowColl.Clear()

    End Sub

    Private Sub LetMeLoadThatForYou_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles LetMeLoadThatForYou.ProgressChanged
        If showfullscreen Then
            fullscreenForm.Progress.Visible = True
            fullscreenForm.Progress.Maximum = salesTotal
            fullscreenForm.Progress.Value = progressTotal
        Else
            Progress.Maximum = salesTotal
            totalLabel.Text = salesTotal
            progressLabel.Text = progressTotal
            Progress.Value = progressTotal
        End If
    End Sub

    Private Sub GetSalesDataList(EndDate As Date)
        'All ticked, or all unticked
        If (Not CBEbay.Checked And Not CBAmazon.Checked And Not CBWebsite.Checked And Not CBDirect.Checked) Or (CBEbay.Checked And CBAmazon.Checked And CBWebsite.Checked And CBDirect.Checked) Then
            'All
            SalesDataList = MySQL.SelectData("SELECT * FROM whldata.newsales_dailysourcetotals WHERE ((TLSource = 'DIRECT' AND subsourceText = '') OR (TLSource != 'DIRECT')) AND totalDate BETWEEN '" + EndDate.ToString("yyyy-MM-dd") + "' AND '" + Today.ToString("yyyy-MM-dd") + "';")
        Else
            'Looks like we want something specific
            Dim datastring As String = "SELECT * FROM whldata.newsales_dailysourcetotals WHERE ("

            If CBEbay.Checked Then
                datastring += "TLSource = 'EBAY' "
                If CBAmazon.Checked Or CBWebsite.Checked Or CBDirect.Checked Then
                    datastring += "OR "
                End If
            End If

            If CBAmazon.Checked Then
                datastring += "TLSource = 'AMAZON' "
                If CBWebsite.Checked Or CBDirect.Checked Then
                    datastring += "OR "
                End If
            End If

            If CBWebsite.Checked Then
                datastring += "TLSource = 'MAGENTO' "
                If CBDirect.Checked Then
                    datastring += "OR "
                End If
            End If

            If CBDirect.Checked Then
                datastring += "(TLSource = 'DIRECT' AND subsourceText = '') "
            End If

            datastring += ") AND totalDate BETWEEN '" + EndDate.ToString("yyyy-MM-dd") + "' AND '" + Today.ToString("yyyy-MM-dd") + "';"

            SalesDataList = MySQL.SelectData(datastring)
        End If

        WeirdDayList = MySQL.SelectData("SELECT * FROM whldata.salesdata_weirddays WHERE date BETWEEN '" + EndDate.ToString("yyyy/MM/dd") + "' AND '" + Today.ToString("yyyy/MM/dd") + "';")

    End Sub

    Dim showfullscreen As Boolean = False
    Dim newScreen As Boolean = False
    Private Sub FullscreenBtn_Click(sender As Object, e As EventArgs) Handles FullscreenBtn.Click
        showfullscreen = True
        GenerateButton.PerformClick()
        FullscreenBtn.Enabled = False
        newScreen = True
    End Sub

    Private Sub SetWeirdBtn_Click(sender As Object, e As EventArgs) Handles SetWeirdBtn.Click
        If Not LetMeLoadThatForYou.IsBusy Then
            Dim newWeirdWindow As New WeirdDayWindow
            newWeirdWindow.ShowDialog()
        End If
    End Sub

End Class
