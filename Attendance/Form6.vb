Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles back.Click
        admin.Show()
        Me.Hide()
    End Sub

    Private Sub tchr_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles tchr.LinkClicked
        Dim needhelptchr As New Form()
        Panel1.Controls.Clear()
        Form9.TopLevel = False
        Form9.WindowState = FormWindowState.Maximized
        Form9.Visible = True
        Panel1.Controls.Add(Form9)
        Form9.Show()


    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim needhelptchr As New Form()
        Panel1.Controls.Clear()
        Form10.TopLevel = False
        Form10.WindowState = FormWindowState.Maximized
        Form10.Visible = True
        Panel1.Controls.Add(Form10)
        Form10.Show()
    End Sub
End Class