Public Class Form1

    Dim p_file As String
    Dim m1_x, m1_y As Integer
    Dim m2_x, m2_y As Integer
    Dim m3_x, m3_y As Integer
    Dim p_str() As String, n As String = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'open
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.Filter = "密码库(*.txt)|*.txt|所有文件(*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            TextBox1.Text = "Open default password is " & FileName
            Dim txt As IO.StreamReader = New IO.StreamReader(FileName, System.Text.Encoding.Default)

            Do Until txt.EndOfStream
                n = n + 1
                ReDim Preserve p_str(n)
                p_str(n) = txt.ReadLine()
            Loop
            txt.Close()
            MsgBox("打开成功，一共 " & p_str.Length - 1 & " 条密码！", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            Button5.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = True
        Button2.Enabled = False
        TextBox2.Text = ""
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        m1_x = System.Windows.Forms.Cursor.Position.X
        m1_y = System.Windows.Forms.Cursor.Position.Y
        TextBox2.Text = "Get Mouse Location(x,y) is " & m1_x & "," & m1_y
        Button2.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer2.Enabled = True
        Button3.Enabled = False
        TextBox3.Text = ""
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Enabled = False
        m2_x = System.Windows.Forms.Cursor.Position.X
        m2_y = System.Windows.Forms.Cursor.Position.Y
        TextBox3.Text = "Get Mouse Location(x,y) is " & m2_x & "," & m2_y
        Button3.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Timer3.Enabled = True
        Button4.Enabled = False
        TextBox4.Text = ""
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Timer3.Enabled = False
        m3_x = System.Windows.Forms.Cursor.Position.X
        m3_y = System.Windows.Forms.Cursor.Position.Y
        TextBox4.Text = "Get Mouse Location(x,y) is " & m3_x & "," & m3_y
        Button4.Enabled = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Start
        Timer4.Enabled = True
        Button5.Enabled = False
        Button6.Enabled = True
        ProgressBar1.Maximum = p_str.Length + 1
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Timer4.Enabled = False
        Button5.Enabled = True
        Button6.Enabled = False
        ProgressBar1.Value = 0
    End Sub

    Dim now_p_l As Integer
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        'go to 
        Dim mMouseLocationTrue As Boolean
m1:
        MouseMoveWork(m1_x, m1_y)
        System.Threading.Thread.Sleep(100)
        'if Mouse Location is true then go

        While Not mMouseLocationTrue
            If System.Windows.Forms.Cursor.Position.X = m1_x And System.Windows.Forms.Cursor.Position.Y = m1_y Then
                mMouseLocationTrue = True
            Else
                MouseMoveWork(m1_x, m1_y)
                GoTo m1
            End If
        End While
        MouseModule.MouseAction("LeftMouseDown")
        System.Threading.Thread.Sleep(250)
        MouseModule.MouseAction("LeftMouseUp")
        MouseModule.MouseAction("LeftMouseDown")
        System.Threading.Thread.Sleep(250)
        MouseModule.MouseAction("LeftMouseUp")

        'enter pw
        now_p_l = now_p_l + 1
        If now_p_l < p_str.Length Then
            SendKeys.Send(p_str(now_p_l))
            System.Threading.Thread.Sleep(20)
            Me.Text = "Hello Password, Number of attempts: " & now_p_l
            Try
                ProgressBar1.Value = now_p_l + 1
            Catch ex As Exception
                ProgressBar1.Value = ProgressBar1.Maximum
            End Try
        Else
            Timer4.Enabled = False
            Button5.Enabled = True
            Button6.Enabled = False
            ProgressBar1.Value = 0
        End If

m2:
        MouseMoveWork(m2_x, m2_y)
        System.Threading.Thread.Sleep(100)
        'if Mouse Location is true then go
        While Not mMouseLocationTrue
            If System.Windows.Forms.Cursor.Position.X = m2_x And System.Windows.Forms.Cursor.Position.Y = m2_y Then
                mMouseLocationTrue = True
            Else
                MouseMoveWork(m2_x, m2_y)
                GoTo m1
            End If
        End While
        MouseModule.MouseAction("LeftMouseDown")
        System.Threading.Thread.Sleep(500)
        MouseModule.MouseAction("LeftMouseUp")

m3:
        MouseMoveWork(m3_x, m3_y)
        System.Threading.Thread.Sleep(100)
        'if Mouse Location is true then go
        While Not mMouseLocationTrue
            If System.Windows.Forms.Cursor.Position.X = m3_x And System.Windows.Forms.Cursor.Position.Y = m3_y Then
                mMouseLocationTrue = True
            Else
                MouseMoveWork(m3_x, m3_y)
                GoTo m1
            End If
        End While
        MouseModule.MouseAction("LeftMouseDown")
        System.Threading.Thread.Sleep(500)
        MouseModule.MouseAction("LeftMouseUp")

    End Sub
    ''' <summary>
    ''' 控制鼠标坐标
    ''' </summary>
    ''' <param name="x"></param>
    ''' <param name="y"></param>
    ''' <remarks></remarks>
    Public Sub MouseMoveWork(ByVal x As Integer, ByVal y As Integer)
        System.Windows.Forms.Cursor.Position = New System.Drawing.Point(x, y)
    End Sub

End Class
