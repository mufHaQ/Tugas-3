Imports System.Net

Public Class LoginForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Offline Login
        'If TextBox2.Text = "g@nk0291" Then
        '    Dim mform = New MainForm
        '    mform.Show()
        '    Me.Hide()
        '    mform.Text = "WinForm: " + Me.TextBox1.Text
        'ElseIf TextBox2.Text = "" Then
        '    MessageBox.Show("Tolong masukkan password!")
        'Else
        '    MessageBox.Show("Tolong masukkan password yang benar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If

        'cek Update
        'Online Login ambil dari pastebin
        Dim wc As New WebClient
        Dim strings As String
        strings = wc.DownloadString("https://pastebin.com/raw/3Px0qBPk")
        Dim user As String
        user = TextBox1.Text
        Dim ar() As String = strings.Split(New String() {" "}, StringSplitOptions.RemoveEmptyEntries)
        If ar(0) = TextBox2.Text Then
            MessageBox.Show("Welcome " + user, "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MainForm.Show()
            MainForm.Text = "WinForm: " + Me.TextBox1.Text
            Me.Close()
        Else
            MessageBox.Show("Wrong Password Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("https://pastebin.com/raw/3Px0qBPk")
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TopMost = True
        Else
            TopMost = False
        End If
    End Sub
End Class