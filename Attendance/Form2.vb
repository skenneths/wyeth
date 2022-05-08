Public Class admin
    Private Sub signout_Click(sender As Object, e As EventArgs) Handles signout.Click
        If (MsgBox("Logging Out?", MessageBoxButtons.YesNo + MsgBoxStyle.Question, "Sign Out")) = DialogResult.Yes Then
            Form1.Show()
            Me.Close()
        Else

        End If
    End Sub

    Private Sub teacherbtn_Click(sender As Object, e As EventArgs) Handles teacherbtn.Click
        adminteachersattendance.Show()
        Me.Hide()
    End Sub

    Private Sub studentbtn_Click(sender As Object, e As EventArgs) Handles studentbtn.Click
        adminstudentsattendance.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form6.Show()
        Me.Hide()

    End Sub

    Private Sub admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class