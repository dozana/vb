Imports MySql.Data.MySqlClient
Public Class Form1
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=db_contacts")
    Dim i As Integer
    Dim dr As MySqlDataReader

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_load()
    End Sub

    Public Sub DGV_load()
        DataGridView1.Rows.Clear()
        Try
        conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM `contacts`", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("first_name"), dr.Item("last_name"), dr.Item("email"), dr.Item("birth_date"), dr.Item("zodiac"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        save()
    End Sub

    Public Sub save()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO `contacts`(`first_name`, `last_name`, `email`, `birth_date`, `zodiac`) VALUES(@first_name,@last_name,@email,@birth_date,@zodiac)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@first_name", firstName.Text)
            cmd.Parameters.AddWithValue("@last_name", lastName.Text)
            cmd.Parameters.AddWithValue("@email", email.Text)
            cmd.Parameters.AddWithValue("@birth_date", CDate(birthDate.Value))
            cmd.Parameters.AddWithValue("@zodiac", zodiac.Text)

            i = cmd.ExecuteNonQuery

            If i > 0 Then
                MessageBox.Show("Record saved", "Contacts", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Save failed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        clear()

    End Sub

    Public Sub clear()
        firstName.Clear()
        lastName.Clear()
        email.Clear()
        birthDate.Text = ""
        zodiac.Text = Now()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        firstName.Text = DataGridView1.CurrentRow.Cells(0).Value
        lastName.Text = DataGridView1.CurrentRow.Cells(1).Value
        email.Text = DataGridView1.CurrentRow.Cells(2).Value
        birthDate.Text = DataGridView1.CurrentRow.Cells(3).Value
        zodiac.Text = DataGridView1.CurrentRow.Cells(4).Value

        btn_save.Enabled = False
    End Sub

    Sub Edit()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `contacts` SET `first_name`=@firstName,`last_name`=@lastName,`email`=@email,`birth_date`=@birthDate,`zodiac`=@zodiac WHERE `zodiac`=@id", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@first_name", firstName.Text)
            cmd.Parameters.AddWithValue("@last_name", lastName.Text)
            cmd.Parameters.AddWithValue("@email", email.Text)
            cmd.Parameters.AddWithValue("@birth_date", CDate(birthDate.Value))
            cmd.Parameters.AddWithValue("@zodiac", zodiac.Text)



            i = cmd.ExecuteNonQuery

            If i > 0 Then
                MessageBox.Show("Record updated", "Contacts", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Update failed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        clear()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

    End Sub
End Class
