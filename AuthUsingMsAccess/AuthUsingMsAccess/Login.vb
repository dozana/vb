Imports System.Data.OleDb

Public Class Login
    Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\users_db.mdb"
    Dim myConn As New OleDbConnection(connectionString)

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Try
            myConn.Open()

            Dim username As String = txt_username.Text
            Dim password As String = txt_password.Text

            Dim sqlQuery As String = "SELECT * FROM users WHERE username = '" & username & "' AND pwd = '" & password & "'"
            Dim myCmd As New OleDbCommand(sqlQuery, myConn)

            Dim reader As OleDbDataReader = myCmd.ExecuteReader()

            If reader.Read() Then
                MessageBox.Show("Success")

                ' Clear data
                txt_username.Clear()
                txt_password.Clear()

                ' Open dashboard
                Dashboard.Show()
                Me.Hide()
            Else
                MsgBox("The password or username is incorrect")
            End If

            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If myConn.State = ConnectionState.Open Then
                myConn.Close()
            End If
        End Try
    End Sub


    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        Register.Show()
        Me.Hide()
    End Sub
End Class
