Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Register

    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database.accdb"
    Dim myConn As New OleDbConnection(connectionString)

    Private Sub btn_goBack_Click(sender As Object, e As EventArgs) Handles btn_goBack.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        Try
            myConn.Open()

            Dim firstName As String = txt_firstName.Text
            Dim lastName As String = txt_lastName.Text
            Dim email As String = txt_email.Text
            Dim username As String = txt_username.Text
            Dim password As String = txt_password.Text

            Dim sqlQuery As String = "INSERT INTO account(first_name, last_name, email, username, password) VALUES ('" & firstName & "','" & lastName & "','" & email & "','" & username & "','" & password & "')"

            Dim myCmd As New OleDbCommand(sqlQuery, myConn)
            myCmd.ExecuteNonQuery()

            MessageBox.Show("Registration successful!")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If myConn.State = ConnectionState.Open Then
                myConn.Close()
            End If
        End Try
    End Sub
End Class