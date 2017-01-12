<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WeirdDayWindow
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
        Me.WeirdDayBox = New System.Windows.Forms.CheckBox()
        Me.WeirdDate = New System.Windows.Forms.DateTimePicker()
        Me.RegisterBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WeirdDayBox
        '
        Me.WeirdDayBox.AutoSize = True
        Me.WeirdDayBox.Location = New System.Drawing.Point(214, 20)
        Me.WeirdDayBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.WeirdDayBox.Name = "WeirdDayBox"
        Me.WeirdDayBox.Size = New System.Drawing.Size(85, 25)
        Me.WeirdDayBox.TabIndex = 0
        Me.WeirdDayBox.Text = "Is Weird"
        Me.WeirdDayBox.UseVisualStyleBackColor = True
        '
        'WeirdDate
        '
        Me.WeirdDate.Location = New System.Drawing.Point(18, 19)
        Me.WeirdDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.WeirdDate.Name = "WeirdDate"
        Me.WeirdDate.Size = New System.Drawing.Size(177, 29)
        Me.WeirdDate.TabIndex = 1
        '
        'RegisterBtn
        '
        Me.RegisterBtn.Location = New System.Drawing.Point(321, 19)
        Me.RegisterBtn.Name = "RegisterBtn"
        Me.RegisterBtn.Size = New System.Drawing.Size(85, 29)
        Me.RegisterBtn.TabIndex = 2
        Me.RegisterBtn.Text = "Register"
        Me.RegisterBtn.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(429, 66)
        Me.Controls.Add(Me.RegisterBtn)
        Me.Controls.Add(Me.WeirdDate)
        Me.Controls.Add(Me.WeirdDayBox)
        Me.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form2"
        Me.Text = "Weird Days"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WeirdDayBox As CheckBox
    Friend WithEvents WeirdDate As DateTimePicker
    Friend WithEvents RegisterBtn As Button
End Class
