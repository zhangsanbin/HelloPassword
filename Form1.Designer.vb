<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(548, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "打开"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "密码字典："
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(148, 31)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(394, 21)
        Me.TextBox1.TabIndex = 2
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(148, 153)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(72, 16)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "连续尝试"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(490, 60)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(133, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "定位输入框"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(148, 62)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(327, 21)
        Me.TextBox2.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 12)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "密码框坐标识别："
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(490, 92)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(133, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "定位确定按钮"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "确定按钮坐标识别："
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(148, 94)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(327, 21)
        Me.TextBox3.TabIndex = 6
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(490, 124)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(133, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "定位确定按钮"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 12)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "提示框按钮坐标识别："
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(148, 126)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(327, 21)
        Me.TextBox4.TabIndex = 6
        '
        'Button5
        '
        Me.Button5.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button5.Enabled = False
        Me.Button5.Location = New System.Drawing.Point(342, 255)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(133, 41)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "开始运行"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button6.Enabled = False
        Me.Button6.Location = New System.Drawing.Point(160, 255)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(133, 41)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "停止运行"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(146, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(389, 12)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "保持系统不进入睡眠模式，不进入屏保模式，所监控的软件不被最小化。"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(146, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(281, 12)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "请保持鼠标准确定位后等待，直到提示框更新坐标。"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(146, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(269, 12)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "每当触发鼠标位置定位，10秒后会读取鼠标坐标。"
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'Timer2
        '
        Me.Timer2.Interval = 5000
        '
        'Timer3
        '
        Me.Timer3.Interval = 5000
        '
        'Timer4
        '
        Me.Timer4.Interval = 3000
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(3, 311)
        Me.ProgressBar1.Maximum = 100000000
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(629, 23)
        Me.ProgressBar1.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button6
        Me.ClientSize = New System.Drawing.Size(634, 346)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(650, 385)
        Me.Name = "Form1"
        Me.Text = "Hello Password"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar

End Class
