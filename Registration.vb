Imports System.Data.SQLite

Public Class frmRegistration

    Private Sub frmRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ApplyLanguage()
        cmbRole.Items.Clear()

        'cmbRole.Items.Add("Food Donor")
        'cmbRole.Items.Add("Recipient")
        cmbRole.Items.Add("Community Organisation")
        cmbRole.Items.Add("User")

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

    Private Sub ApplyLanguage()

        If LanguageHelper.CurrentLanguage = "English" Then

            Label1.Text = "Create Account"
            Label2.Text = "Full Name:"
            Label3.Text = "Username:"
            Label4.Text = "Password:"
            Label5.Text = "Confirm Password:"
            Label6.Text = "Role"
            btnRegister.Text = "Register"
            btnBack.Text = "Back to Login"

        ElseIf LanguageHelper.CurrentLanguage = "Itaukei" Then

            Label1.Text = "Dolava na Akaude"
            Label2.Text = "Yaca Taucoko:"
            Label3.Text = "Yaca ni Vakayagataki:"
            Label4.Text = "Vosa ni Maroroi:"
            Label5.Text = "Vakadeitaka na Vosa ni Maroroi:"
            Label6.Text = "Itutu"
            btnRegister.Text = "Rejisita"
            btnBack.Text = "Lesu ki na Curu"

        ElseIf LanguageHelper.CurrentLanguage = "Fiji Hindi" Then

            Label1.Text = "Naya Account Banai"
            Label2.Text = "Pura Naam:"
            Label3.Text = "Username:"
            Label4.Text = "Password:"
            Label5.Text = "Password Dobara Likho:"
            Label6.Text = "Role"
            btnRegister.Text = "Register Karo"
            btnBack.Text = "Login Par Jao"

        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub cmbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRole.SelectedIndexChanged

    End Sub
End Class