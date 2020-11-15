Imports System.Net
Public Class MainForm


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Height = 311
        Button1.Enabled = False
        Button2.Enabled = False
        Panel3.Height = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lform = New LoginForm
        lform.Show()
        Me.Hide()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Panel1.Height -= 5
        If Panel1.Height <= 0 Then
            Timer1.Stop()
            Button1.Enabled = True
            Button2.Enabled = True
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        PanelRed.Width += 2
        If PanelRed.Width >= 520 Then
            Timer2.Stop()
            Timer3.Stop()
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        'Untuk memposisikan ditengah
        'Dim p As New Point
        'p.X = (Me.Width / 2) - (Label1.Width / 2)
        'p.Y = Label1.Top

        If Label1.Text = "Loading..." Then
            Label1.Text = "Loading"
        ElseIf Label1.Text = "Loading" Then
            Label1.Text = "Loading."
        ElseIf Label1.Text = "Loading." Then
            Label1.Text = "Loading.."
        ElseIf Label1.Text = "Loading.." Then
            Label1.Text = "Loading..."
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer4.Start()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Panel3.Height += 5
        If Panel3.Height >= 311 Then
            Timer4.Stop()
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Panel3.Height -= 5
        If Panel3.Height <= 0 Then
            Timer5.Stop()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Process.Start("https://pastebin.com/raw/3Px0qBPk")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim wc As New WebClient
        Dim strings As String
        strings = wc.DownloadString("https://pastebin.com/raw/3Px0qBPk")
        Dim user As String
        user = TextBox1.Text
        Dim ar() As String = strings.Split(New String() {" "}, StringSplitOptions.RemoveEmptyEntries)
        If ar(0) = TextBox2.Text Then
            MessageBox.Show("Welcome " + user, "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Timer5.Start()
            Me.Text = "WinForm: " + TextBox1.Text

        Else
            MessageBox.Show("Wrong Password Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Timer5.Start()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TopMost = True
        Else
            TopMost = False
        End If
    End Sub
End Class
