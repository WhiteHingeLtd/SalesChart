<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesDataForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GenerateButton = New System.Windows.Forms.Button()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WeeksBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SetWeirdBtn = New System.Windows.Forms.Button()
        Me.FullscreenBtn = New System.Windows.Forms.Button()
        Me.CBDirect = New System.Windows.Forms.CheckBox()
        Me.CBWebsite = New System.Windows.Forms.CheckBox()
        Me.CBAmazon = New System.Windows.Forms.CheckBox()
        Me.CBEbay = New System.Windows.Forms.CheckBox()
        Me.LetMeLoadThatForYou = New System.ComponentModel.BackgroundWorker()
        Me.Progress = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.progressLabel = New System.Windows.Forms.Label()
        CType(Me.SalesGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GenerateButton
        '
        Me.GenerateButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GenerateButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GenerateButton.FlatAppearance.BorderSize = 0
        Me.GenerateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GenerateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GenerateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GenerateButton.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenerateButton.Location = New System.Drawing.Point(646, 474)
        Me.GenerateButton.Name = "GenerateButton"
        Me.GenerateButton.Size = New System.Drawing.Size(176, 27)
        Me.GenerateButton.TabIndex = 4
        Me.GenerateButton.Text = "Generate Sales Data"
        Me.GenerateButton.UseVisualStyleBackColor = False
        '
        'SalesGrid
        '
        Me.SalesGrid.AllowUserToAddRows = False
        Me.SalesGrid.AllowUserToDeleteRows = False
        Me.SalesGrid.AllowUserToResizeRows = False
        Me.SalesGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SalesGrid.BackgroundColor = System.Drawing.Color.Black
        Me.SalesGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SalesGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.SalesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SalesGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Week, Me.SatCol, Me.SunCol, Me.Monday, Me.Tuesday, Me.Wednesday, Me.Thursday, Me.Friday, Me.Total})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SalesGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.SalesGrid.EnableHeadersVisualStyles = False
        Me.SalesGrid.GridColor = System.Drawing.Color.Black
        Me.SalesGrid.Location = New System.Drawing.Point(7, 3)
        Me.SalesGrid.Name = "SalesGrid"
        Me.SalesGrid.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SalesGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.SalesGrid.RowHeadersVisible = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SalesGrid.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.SalesGrid.Size = New System.Drawing.Size(925, 422)
        Me.SalesGrid.TabIndex = 0
        '
        'Week
        '
        Me.Week.HeaderText = "Date (Sat)"
        Me.Week.Name = "Week"
        Me.Week.ReadOnly = True
        '
        'SatCol
        '
        Me.SatCol.HeaderText = "Sat"
        Me.SatCol.Name = "SatCol"
        Me.SatCol.ReadOnly = True
        '
        'SunCol
        '
        Me.SunCol.HeaderText = "Sun"
        Me.SunCol.Name = "SunCol"
        Me.SunCol.ReadOnly = True
        '
        'Monday
        '
        Me.Monday.HeaderText = "Mon"
        Me.Monday.Name = "Monday"
        Me.Monday.ReadOnly = True
        '
        'Tuesday
        '
        Me.Tuesday.HeaderText = "Tue"
        Me.Tuesday.Name = "Tuesday"
        Me.Tuesday.ReadOnly = True
        '
        'Wednesday
        '
        Me.Wednesday.HeaderText = "Wed"
        Me.Wednesday.Name = "Wednesday"
        Me.Wednesday.ReadOnly = True
        '
        'Thursday
        '
        Me.Thursday.HeaderText = "Thu"
        Me.Thursday.Name = "Thursday"
        Me.Thursday.ReadOnly = True
        '
        'Friday
        '
        Me.Friday.HeaderText = "Fri"
        Me.Friday.Name = "Friday"
        Me.Friday.ReadOnly = True
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(877, 477)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Weeks"
        '
        'WeeksBox
        '
        Me.WeeksBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WeeksBox.BackColor = System.Drawing.Color.Black
        Me.WeeksBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WeeksBox.ForeColor = System.Drawing.Color.White
        Me.WeeksBox.Location = New System.Drawing.Point(828, 474)
        Me.WeeksBox.Name = "WeeksBox"
        Me.WeeksBox.Size = New System.Drawing.Size(43, 27)
        Me.WeeksBox.TabIndex = 5
        Me.WeeksBox.Text = "16"
        Me.WeeksBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.SalesGrid)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(935, 428)
        Me.Panel1.TabIndex = 12
        '
        'SetWeirdBtn
        '
        Me.SetWeirdBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SetWeirdBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SetWeirdBtn.FlatAppearance.BorderSize = 0
        Me.SetWeirdBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SetWeirdBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SetWeirdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetWeirdBtn.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetWeirdBtn.Location = New System.Drawing.Point(828, 503)
        Me.SetWeirdBtn.Name = "SetWeirdBtn"
        Me.SetWeirdBtn.Size = New System.Drawing.Size(119, 27)
        Me.SetWeirdBtn.TabIndex = 19
        Me.SetWeirdBtn.Text = "Set Weirds"
        Me.SetWeirdBtn.UseVisualStyleBackColor = False
        '
        'FullscreenBtn
        '
        Me.FullscreenBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FullscreenBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FullscreenBtn.FlatAppearance.BorderSize = 0
        Me.FullscreenBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FullscreenBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FullscreenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FullscreenBtn.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullscreenBtn.Location = New System.Drawing.Point(646, 503)
        Me.FullscreenBtn.Name = "FullscreenBtn"
        Me.FullscreenBtn.Size = New System.Drawing.Size(176, 27)
        Me.FullscreenBtn.TabIndex = 18
        Me.FullscreenBtn.Text = "Fullscreen"
        Me.FullscreenBtn.UseVisualStyleBackColor = False
        '
        'CBDirect
        '
        Me.CBDirect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBDirect.AutoSize = True
        Me.CBDirect.Checked = True
        Me.CBDirect.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBDirect.Location = New System.Drawing.Point(557, 504)
        Me.CBDirect.Name = "CBDirect"
        Me.CBDirect.Size = New System.Drawing.Size(66, 24)
        Me.CBDirect.TabIndex = 7
        Me.CBDirect.Text = "Direct"
        Me.CBDirect.UseVisualStyleBackColor = True
        '
        'CBWebsite
        '
        Me.CBWebsite.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBWebsite.AutoSize = True
        Me.CBWebsite.Checked = True
        Me.CBWebsite.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBWebsite.Location = New System.Drawing.Point(470, 504)
        Me.CBWebsite.Name = "CBWebsite"
        Me.CBWebsite.Size = New System.Drawing.Size(81, 24)
        Me.CBWebsite.TabIndex = 6
        Me.CBWebsite.Text = "Website"
        Me.CBWebsite.UseVisualStyleBackColor = True
        '
        'CBAmazon
        '
        Me.CBAmazon.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBAmazon.AutoSize = True
        Me.CBAmazon.Checked = True
        Me.CBAmazon.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBAmazon.Location = New System.Drawing.Point(557, 475)
        Me.CBAmazon.Name = "CBAmazon"
        Me.CBAmazon.Size = New System.Drawing.Size(83, 24)
        Me.CBAmazon.TabIndex = 5
        Me.CBAmazon.Text = "Amazon"
        Me.CBAmazon.UseVisualStyleBackColor = True
        '
        'CBEbay
        '
        Me.CBEbay.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBEbay.AutoSize = True
        Me.CBEbay.Checked = True
        Me.CBEbay.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBEbay.Location = New System.Drawing.Point(470, 475)
        Me.CBEbay.Name = "CBEbay"
        Me.CBEbay.Size = New System.Drawing.Size(60, 24)
        Me.CBEbay.TabIndex = 4
        Me.CBEbay.Text = "Ebay"
        Me.CBEbay.UseVisualStyleBackColor = True
        '
        'LetMeLoadThatForYou
        '
        Me.LetMeLoadThatForYou.WorkerReportsProgress = True
        '
        'Progress
        '
        Me.Progress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Progress.BackColor = System.Drawing.Color.Black
        Me.Progress.Location = New System.Drawing.Point(12, 446)
        Me.Progress.Name = "Progress"
        Me.Progress.Size = New System.Drawing.Size(935, 22)
        Me.Progress.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 506)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Progress:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(8, 477)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Total:"
        '
        'totalLabel
        '
        Me.totalLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.totalLabel.AutoSize = True
        Me.totalLabel.BackColor = System.Drawing.Color.Black
        Me.totalLabel.Location = New System.Drawing.Point(71, 478)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(17, 20)
        Me.totalLabel.TabIndex = 17
        Me.totalLabel.Text = "0"
        '
        'progressLabel
        '
        Me.progressLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.progressLabel.AutoSize = True
        Me.progressLabel.BackColor = System.Drawing.Color.Black
        Me.progressLabel.Location = New System.Drawing.Point(71, 506)
        Me.progressLabel.Name = "progressLabel"
        Me.progressLabel.Size = New System.Drawing.Size(17, 20)
        Me.progressLabel.TabIndex = 16
        Me.progressLabel.Text = "0"
        '
        'SalesDataForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(959, 536)
        Me.Controls.Add(Me.CBDirect)
        Me.Controls.Add(Me.WeeksBox)
        Me.Controls.Add(Me.CBWebsite)
        Me.Controls.Add(Me.SetWeirdBtn)
        Me.Controls.Add(Me.CBAmazon)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.CBEbay)
        Me.Controls.Add(Me.FullscreenBtn)
        Me.Controls.Add(Me.progressLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Progress)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GenerateButton)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MinimumSize = New System.Drawing.Size(975, 575)
        Me.Name = "SalesDataForm"
        Me.Text = "Sales Records"
        CType(Me.SalesGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SalesGrid As DataGridView
    Friend WithEvents GenerateButton As Button
    Friend WithEvents WeeksBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LetMeLoadThatForYou As System.ComponentModel.BackgroundWorker
    Friend WithEvents Progress As ProgressBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents totalLabel As Label
    Friend WithEvents progressLabel As Label
    Friend WithEvents CBDirect As CheckBox
    Friend WithEvents CBWebsite As CheckBox
    Friend WithEvents CBAmazon As CheckBox
    Friend WithEvents CBEbay As CheckBox
    Friend WithEvents FullscreenBtn As Button
    Friend WithEvents SetWeirdBtn As Button
    Friend WithEvents Week As DataGridViewTextBoxColumn
    Friend WithEvents SatCol As DataGridViewTextBoxColumn
    Friend WithEvents SunCol As DataGridViewTextBoxColumn
    Friend WithEvents Monday As DataGridViewTextBoxColumn
    Friend WithEvents Tuesday As DataGridViewTextBoxColumn
    Friend WithEvents Wednesday As DataGridViewTextBoxColumn
    Friend WithEvents Thursday As DataGridViewTextBoxColumn
    Friend WithEvents Friday As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
End Class
