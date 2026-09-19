Imports System.Data.SQLite

Public Class frmRegistration

    Private Sub frmRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbRole.Items.Clear()

        cmbRole.Items.Add("Food Donor")
        cmbRole.Items.Add("Recipient")
        cmbRole.Items.Add("Community Organisation")

        cmbRole.SelectedIndex = 0

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        If txtFullName.Text.Trim() = "" OrElse
       txtUsername.Text.Trim() = "" OrElse
       txtPassword.Text = "" OrElse
       txtConfirmPassword.Text = "" OrElse
       cmbRole.SelectedIndex = -1 Then

            MessageBox.Show("Please complete all fields.")
            Return
        End If

        If txtPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Passwords do not match.")
            Return
        End If

        Try
            Using conn As SQLiteConnection = GetConnection()

                conn.Open()

                Dim query As String =
                "INSERT INTO Users " &
                "(FullName, Username, Password, Role, Status) " &
                "VALUES (@FullName, @Username, @Password, @Role, @Status)"

                Using cmd As New SQLiteCommand(query, conn)

                    cmd.Parameters.AddWithValue("@FullName", txtFullName.Text.Trim())
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim())
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
                    cmd.Parameters.AddWithValue("@Role", cmbRole.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@Status", "Active")

                    cmd.ExecuteNonQuery()

                End Using

            End Using

            MessageBox.Show("Registration successful!")

            Me.Close()

        Catch ex As SQLiteException

            If ex.Message.Contains("UNIQUE") Then
                MessageBox.Show("Username already exists.")
            Else
                MessageBox.Show("Database error: " & ex.Message)
            End If

        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message)

        End Try

    End Sub
End Class