<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DateAndTime
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
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.btn_Set = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl_timer = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.btn_Countdown = New System.Windows.Forms.Button()
        Me.lbl_Countdown = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(543, 18)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'lbl_time
        '
        Me.lbl_time.AutoSize = True
        Me.lbl_time.Location = New System.Drawing.Point(42, 99)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(39, 13)
        Me.lbl_time.TabIndex = 1
        Me.lbl_time.Text = "Label1"
        '
        'btn_Set
        '
        Me.btn_Set.Location = New System.Drawing.Point(87, 94)
        Me.btn_Set.Name = "btn_Set"
        Me.btn_Set.Size = New System.Drawing.Size(75, 23)
        Me.btn_Set.TabIndex = 2
        Me.btn_Set.Text = "Show Time"
        Me.btn_Set.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(87, 254)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbl_timer
        '
        Me.lbl_timer.AutoSize = True
        Me.lbl_timer.Location = New System.Drawing.Point(104, 280)
        Me.lbl_timer.Name = "lbl_timer"
        Me.lbl_timer.Size = New System.Drawing.Size(39, 13)
        Me.lbl_timer.TabIndex = 4
        Me.lbl_timer.Text = "Label1"
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'btn_Countdown
        '
        Me.btn_Countdown.Location = New System.Drawing.Point(491, 233)
        Me.btn_Countdown.Name = "btn_Countdown"
        Me.btn_Countdown.Size = New System.Drawing.Size(75, 23)
        Me.btn_Countdown.TabIndex = 5
        Me.btn_Countdown.Text = "Countdown"
        Me.btn_Countdown.UseVisualStyleBackColor = True
        '
        'lbl_Countdown
        '
        Me.lbl_Countdown.AutoSize = True
        Me.lbl_Countdown.Location = New System.Drawing.Point(515, 264)
        Me.lbl_Countdown.Name = "lbl_Countdown"
        Me.lbl_Countdown.Size = New System.Drawing.Size(25, 13)
        Me.lbl_Countdown.TabIndex = 6
        Me.lbl_Countdown.Text = "100"
        '
        'DateAndTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 468)
        Me.Controls.Add(Me.lbl_Countdown)
        Me.Controls.Add(Me.btn_Countdown)
        Me.Controls.Add(Me.lbl_timer)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_Set)
        Me.Controls.Add(Me.lbl_time)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Name = "DateAndTime"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents lbl_time As System.Windows.Forms.Label
    Friend WithEvents btn_Set As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbl_timer As System.Windows.Forms.Label
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents btn_Countdown As System.Windows.Forms.Button
    Friend WithEvents lbl_Countdown As System.Windows.Forms.Label

End Class
