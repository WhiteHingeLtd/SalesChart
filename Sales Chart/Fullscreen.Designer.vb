﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fullscreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RefreshTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SalesGrid = New System.Windows.Forms.DataGridView()
        Me.Week = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SatCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SunCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tuesday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Wednesday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Thursday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Friday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LastRefreshLbl = New System.Windows.Forms.Label()
        Me.Progress = New System.Windows.Forms.ProgressBar()
        Me.RowHeightUp = New System.Windows.Forms.Button()
        Me.RowHeightDown = New System.Windows.Forms.Button()
        Me.DumbRowTxt = New System.Windows.Forms.Label()
        CType(Me.SalesGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RefreshTimer
        '
        Me.RefreshTimer.Interval = 15000
        '
        'SalesGrid
        '
        Me.SalesGrid.AllowUserToAddRows = False
        Me.SalesGrid.AllowUserToDeleteRows = False
        Me.SalesGrid.AllowUserToResizeRows = False
        Me.SalesGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.SalesGrid.BackgroundColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Semilight", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SalesGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.SalesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SalesGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Week, Me.SatCol, Me.SunCol, Me.Monday, Me.Tuesday, Me.Wednesday, Me.Thursday, Me.Friday, Me.Total})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Semilight", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SalesGrid.DefaultCellStyle = DataGridViewCellStyle6
        Me.SalesGrid.EnableHeadersVisualStyles = False
        Me.SalesGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SalesGrid.Location = New System.Drawing.Point(0, 0)
        Me.SalesGrid.MultiSelect = False
        Me.SalesGrid.Name = "SalesGrid"
        Me.SalesGrid.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI Semilight", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SalesGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.SalesGrid.RowHeadersVisible = False
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI Semibold", 23.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SalesGrid.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.SalesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SalesGrid.Size = New System.Drawing.Size(1895, 991)
        Me.SalesGrid.TabIndex = 0
        '
        'Week
        '
        Me.Week.HeaderText = "Date (Sat)"
        Me.Week.Name = "Week"
        Me.Week.ReadOnly = True
        Me.Week.Width = 250
        '
        'SatCol
        '
        Me.SatCol.HeaderText = "Sat"
        Me.SatCol.Name = "SatCol"
        Me.SatCol.ReadOnly = True
        Me.SatCol.Width = 200
        '
        'SunCol
        '
        Me.SunCol.HeaderText = "Sun"
        Me.SunCol.Name = "SunCol"
        Me.SunCol.ReadOnly = True
        Me.SunCol.Width = 200
        '
        'Monday
        '
        Me.Monday.HeaderText = "Mon"
        Me.Monday.Name = "Monday"
        Me.Monday.ReadOnly = True
        Me.Monday.Width = 200
        '
        'Tuesday
        '
        Me.Tuesday.HeaderText = "Tue"
        Me.Tuesday.Name = "Tuesday"
        Me.Tuesday.ReadOnly = True
        Me.Tuesday.Width = 200
        '
        'Wednesday
        '
        Me.Wednesday.HeaderText = "Wed"
        Me.Wednesday.Name = "Wednesday"
        Me.Wednesday.ReadOnly = True
        Me.Wednesday.Width = 200
        '
        'Thursday
        '
        Me.Thursday.HeaderText = "Thu"
        Me.Thursday.Name = "Thursday"
        Me.Thursday.ReadOnly = True
        Me.Thursday.Width = 200
        '
        'Friday
        '
        Me.Friday.HeaderText = "Fri"
        Me.Friday.Name = "Friday"
        Me.Friday.ReadOnly = True
        Me.Friday.Width = 200
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 200
        '
        'CloseBtn
        '
        Me.CloseBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseBtn.FlatAppearance.BorderSize = 0
        Me.CloseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.CloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseBtn.Location = New System.Drawing.Point(1869, 12)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(48, 60)
        Me.CloseBtn.TabIndex = 4
        Me.CloseBtn.Text = "X"
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.SalesGrid)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1895, 991)
        Me.Panel1.TabIndex = 13
        '
        'LastRefreshLbl
        '
        Me.LastRefreshLbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LastRefreshLbl.BackColor = System.Drawing.Color.Transparent
        Me.LastRefreshLbl.Font = New System.Drawing.Font("Segoe UI Semilight", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastRefreshLbl.Location = New System.Drawing.Point(100, 1003)
        Me.LastRefreshLbl.Name = "LastRefreshLbl"
        Me.LastRefreshLbl.Size = New System.Drawing.Size(1700, 34)
        Me.LastRefreshLbl.TabIndex = 14
        Me.LastRefreshLbl.Text = "Last Refresh: "
        Me.LastRefreshLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Progress
        '
        Me.Progress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Progress.BackColor = System.Drawing.Color.Black
        Me.Progress.Location = New System.Drawing.Point(100, 1039)
        Me.Progress.Name = "Progress"
        Me.Progress.Size = New System.Drawing.Size(1700, 10)
        Me.Progress.TabIndex = 15
        '
        'RowHeightUp
        '
        Me.RowHeightUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RowHeightUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RowHeightUp.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RowHeightUp.Location = New System.Drawing.Point(1831, 1003)
        Me.RowHeightUp.Name = "RowHeightUp"
        Me.RowHeightUp.Size = New System.Drawing.Size(34, 34)
        Me.RowHeightUp.TabIndex = 16
        Me.RowHeightUp.Text = "▲"
        Me.RowHeightUp.UseVisualStyleBackColor = True
        '
        'RowHeightDown
        '
        Me.RowHeightDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RowHeightDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RowHeightDown.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RowHeightDown.Location = New System.Drawing.Point(1874, 1003)
        Me.RowHeightDown.Name = "RowHeightDown"
        Me.RowHeightDown.Size = New System.Drawing.Size(34, 34)
        Me.RowHeightDown.TabIndex = 17
        Me.RowHeightDown.Text = "▼"
        Me.RowHeightDown.UseVisualStyleBackColor = True
        '
        'DumbRowTxt
        '
        Me.DumbRowTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DumbRowTxt.BackColor = System.Drawing.Color.Transparent
        Me.DumbRowTxt.Font = New System.Drawing.Font("Segoe UI Semilight", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DumbRowTxt.Location = New System.Drawing.Point(3, 1015)
        Me.DumbRowTxt.Name = "DumbRowTxt"
        Me.DumbRowTxt.Size = New System.Drawing.Size(91, 34)
        Me.DumbRowTxt.TabIndex = 18
        Me.DumbRowTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Fullscreen
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1920, 1045)
        Me.Controls.Add(Me.DumbRowTxt)
        Me.Controls.Add(Me.RowHeightDown)
        Me.Controls.Add(Me.RowHeightUp)
        Me.Controls.Add(Me.Progress)
        Me.Controls.Add(Me.LastRefreshLbl)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Fullscreen"
        Me.Text = "Fullscreen"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.SalesGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RefreshTimer As Timer
    Friend WithEvents SalesGrid As DataGridView
    Friend WithEvents CloseBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LastRefreshLbl As Label
    Friend WithEvents Week As DataGridViewTextBoxColumn
    Friend WithEvents SatCol As DataGridViewTextBoxColumn
    Friend WithEvents SunCol As DataGridViewTextBoxColumn
    Friend WithEvents Monday As DataGridViewTextBoxColumn
    Friend WithEvents Tuesday As DataGridViewTextBoxColumn
    Friend WithEvents Wednesday As DataGridViewTextBoxColumn
    Friend WithEvents Thursday As DataGridViewTextBoxColumn
    Friend WithEvents Friday As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Progress As ProgressBar
    Friend WithEvents RowHeightUp As Button
    Friend WithEvents RowHeightDown As Button
    Friend WithEvents DumbRowTxt As Label
End Class
