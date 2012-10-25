<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameSpace
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameSpace))
        Me.tmr_move = New System.Windows.Forms.Timer(Me.components)
        Me.tmr_down = New System.Windows.Forms.Timer(Me.components)
        Me.tmr_left = New System.Windows.Forms.Timer(Me.components)
        Me.tmr_right = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_lose = New System.Windows.Forms.Label()
        Me.lbl_loc1 = New System.Windows.Forms.Label()
        Me.lbl_loc2 = New System.Windows.Forms.Label()
        Me.tmr_winmove = New System.Windows.Forms.Timer(Me.components)
        Me.tmr_deathcheck = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_pointerlocation = New System.Windows.Forms.Label()
        Me.lbl_move = New System.Windows.Forms.PictureBox()
        CType(Me.lbl_move, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmr_move
        '
        Me.tmr_move.Interval = 10
        '
        'tmr_down
        '
        Me.tmr_down.Interval = 10
        '
        'tmr_left
        '
        Me.tmr_left.Interval = 10
        '
        'tmr_right
        '
        Me.tmr_right.Interval = 10
        '
        'lbl_lose
        '
        Me.lbl_lose.AutoSize = True
        Me.lbl_lose.Location = New System.Drawing.Point(26, 9)
        Me.lbl_lose.Name = "lbl_lose"
        Me.lbl_lose.Size = New System.Drawing.Size(30, 13)
        Me.lbl_lose.TabIndex = 1
        Me.lbl_lose.Text = "Lose"
        '
        'lbl_loc1
        '
        Me.lbl_loc1.AutoSize = True
        Me.lbl_loc1.Location = New System.Drawing.Point(12, 350)
        Me.lbl_loc1.Name = "lbl_loc1"
        Me.lbl_loc1.Size = New System.Drawing.Size(39, 13)
        Me.lbl_loc1.TabIndex = 2
        Me.lbl_loc1.Text = "Label1"
        '
        'lbl_loc2
        '
        Me.lbl_loc2.AutoSize = True
        Me.lbl_loc2.Location = New System.Drawing.Point(342, 350)
        Me.lbl_loc2.Name = "lbl_loc2"
        Me.lbl_loc2.Size = New System.Drawing.Size(39, 13)
        Me.lbl_loc2.TabIndex = 3
        Me.lbl_loc2.Text = "Label2"
        '
        'tmr_winmove
        '
        Me.tmr_winmove.Interval = 20
        '
        'tmr_deathcheck
        '
        Me.tmr_deathcheck.Interval = 500
        '
        'lbl_pointerlocation
        '
        Me.lbl_pointerlocation.AutoSize = True
        Me.lbl_pointerlocation.Location = New System.Drawing.Point(178, 350)
        Me.lbl_pointerlocation.Name = "lbl_pointerlocation"
        Me.lbl_pointerlocation.Size = New System.Drawing.Size(39, 13)
        Me.lbl_pointerlocation.TabIndex = 4
        Me.lbl_pointerlocation.Text = "Label1"
        '
        'lbl_move
        '
        Me.lbl_move.Image = CType(resources.GetObject("lbl_move.Image"), System.Drawing.Image)
        Me.lbl_move.Location = New System.Drawing.Point(313, 230)
        Me.lbl_move.Name = "lbl_move"
        Me.lbl_move.Size = New System.Drawing.Size(20, 20)
        Me.lbl_move.TabIndex = 5
        Me.lbl_move.TabStop = False
        '
        'GameSpace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 372)
        Me.Controls.Add(Me.lbl_move)
        Me.Controls.Add(Me.lbl_pointerlocation)
        Me.Controls.Add(Me.lbl_loc2)
        Me.Controls.Add(Me.lbl_loc1)
        Me.Controls.Add(Me.lbl_lose)
        Me.Name = "GameSpace"
        Me.Text = "Form1"
        CType(Me.lbl_move, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmr_move As System.Windows.Forms.Timer
    Friend WithEvents tmr_down As System.Windows.Forms.Timer
    Friend WithEvents tmr_left As System.Windows.Forms.Timer
    Friend WithEvents tmr_right As System.Windows.Forms.Timer
    Friend WithEvents lbl_lose As System.Windows.Forms.Label
    Friend WithEvents lbl_loc1 As System.Windows.Forms.Label
    Friend WithEvents lbl_loc2 As System.Windows.Forms.Label
    Friend WithEvents tmr_winmove As System.Windows.Forms.Timer
    Friend WithEvents tmr_deathcheck As System.Windows.Forms.Timer
    Friend WithEvents lbl_pointerlocation As System.Windows.Forms.Label
    Friend WithEvents lbl_move As System.Windows.Forms.PictureBox

End Class
