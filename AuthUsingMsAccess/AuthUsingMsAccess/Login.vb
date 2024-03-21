Public Class Login
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click

    End Sub

    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        Register.Show()
        Me.Hide()
    End Sub
End Class
