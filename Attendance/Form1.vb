Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label3.Click, Label2.Click

    End Sub

    Private Sub signin_Click(sender As Object, e As EventArgs) Handles signin.Click
        If username.Text = "admin" And password.Text = "admin" Then
            MsgBox("Note: Admin can edit the attendance of Teachers and Students", MsgBoxStyle.Information, "Welcome Admin")
            admin.Show()
            Me.Hide()
            username.Text = ""
            password.Text = ""
        ElseIf username.Text = "teacher" And password.Text = "teacher" Then
            MsgBox("Note: Teachers can check the attendance of the Students", MsgBoxStyle.Information, "Welcome Admin")
            teacher.Show()
            Me.Hide()
            username.Text = ""
            password.Text = ""
        Else
            MsgBox("Wrong input of Username or Password", MessageBoxButtons.RetryCancel + MsgBoxStyle.Exclamation, "Warning!")
            username.Text = ""
            password.Text = ""
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("Don't ask me baybeh", MsgBoxStyle.Information, "I dunno")
    End Sub
End Class
