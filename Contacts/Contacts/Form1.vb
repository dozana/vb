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
                DataGridView1.Rows.Add(dr.Item("id"), dr.Item("first_name"), dr.Item("last_name"), dr.Item("email"), dr.Item("birth_date"), dr.Item("zodiac"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Save()
        DGV_load()
    End Sub

    Public Sub Save()
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
        id.Clear()
        firstName.Clear()
        lastName.Clear()
        email.Clear()
        birthDate.Value = Now
        zodiac.Text = ""
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        id.Text = DataGridView1.CurrentRow.Cells(0).Value
        firstName.Text = DataGridView1.CurrentRow.Cells(1).Value
        lastName.Text = DataGridView1.CurrentRow.Cells(2).Value
        email.Text = DataGridView1.CurrentRow.Cells(3).Value
        birthDate.Text = DataGridView1.CurrentRow.Cells(4).Value
        zodiac.Text = DataGridView1.CurrentRow.Cells(5).Value

        id.ReadOnly = True
        btn_save.Enabled = False
    End Sub

    Sub Edit()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `contacts` SET `first_name`=@first_name, `last_name`=@last_name, `email`=@email, `birth_date`=@birth_date, `zodiac`=@zodiac WHERE `id`=@id", conn)
            cmd.Parameters.AddWithValue("@id", id.Text)
            cmd.Parameters.AddWithValue("@first_name", firstName.Text)
            cmd.Parameters.AddWithValue("@last_name", lastName.Text)
            cmd.Parameters.AddWithValue("@email", email.Text)
            cmd.Parameters.AddWithValue("@birth_date", CDate(birthDate.Value))
            cmd.Parameters.AddWithValue("@zodiac", zodiac.Text)

            i = cmd.ExecuteNonQuery()

            If i > 0 Then
                MessageBox.Show("Record updated", "Contacts", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Update failed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Edit()
        DGV_load()
    End Sub

    Public Sub Delete()
        If MsgBox("Are you sure delete this record", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE FROM `contacts` WHERE `id`=@id", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@id", id.Text)

                i = cmd.ExecuteNonQuery

                If i > 0 Then
                    MessageBox.Show("Record deleted", "Contacts", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Delete failed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try

            clear()
            DGV_load()
        Else
            Return
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Delete()
        DGV_load()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        clear()
        DGV_load()
    End Sub

    Private Sub search_TextChanged(sender As Object, e As EventArgs) Handles search.TextChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM `contacts` WHERE id LIKE '%" & search.Text & "%' OR first_name LIKE '%" & search.Text & "%' OR last_name LIKE '%" & search.Text & "%' OR email LIKE '%" & search.Text & "%'", conn)

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

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        id.ReadOnly = False
        btn_save.Enabled = True
        DGV_load()
    End Sub

    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click
        Dim currentRowIndex As Integer = DataGridView1.CurrentRow.Index
        Dim nextRowIndex As Integer = currentRowIndex + 1

        ' Check if the next row index is within the bounds
        If nextRowIndex < DataGridView1.Rows.Count Then
            DataGridView1.CurrentCell = DataGridView1.Rows(nextRowIndex).Cells(0) ' Assuming you want to select the first cell in the next row
        End If
    End Sub

    Private Sub btn_previous_Click(sender As Object, e As EventArgs) Handles btn_previous.Click
        Dim currentRowIndex As Integer = DataGridView1.CurrentRow.Index
        Dim previousRowIndex As Integer = currentRowIndex - 1

        ' Check if the previous row index is within the bounds
        If previousRowIndex >= 0 Then
            DataGridView1.CurrentCell = DataGridView1.Rows(previousRowIndex).Cells(0) ' Assuming you want to select the first cell in the previous row
        End If
    End Sub

    Private Sub btn_first_Click(sender As Object, e As EventArgs) Handles btn_first.Click
        ' Move to the first row
        If DataGridView1.Rows.Count > 0 Then
            DataGridView1.CurrentCell = DataGridView1.Rows(0).Cells(0)
        End If
    End Sub

    Private Sub btn_last_Click(sender As Object, e As EventArgs) Handles btn_last.Click
        ' Move to the last row
        Dim lastRowIndex As Integer = DataGridView1.Rows.Count - 1
        If lastRowIndex >= 0 Then
            DataGridView1.CurrentCell = DataGridView1.Rows(lastRowIndex).Cells(0)
        End If
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Close()
    End Sub
End Class
