Public Class adminstudentsattendance
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        admin.Show()
        Me.Hide()
    End Sub

    Private Sub adminstudentsattendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub


    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        addstdnt.Show()
        Me.Hide()

    End Sub
End Class