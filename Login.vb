Imports System.Data.SQLite
Public Class frmLogin
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        Dim registrationForm As New frmRegistration()
        registrationForm.Show()
        Me.Hide()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtUsername.Text.Trim() = "" OrElse
       txtPassword.Text = "" Then

            MessageBox.Show("Please enter your username and password.")
            Return
        End If

        Try
            Using conn As SQLiteConnection = GetConnection()

                conn.Open()

                Dim query As String =
                "SELECT UserID, FullName, Role FROM Users " &
                "WHERE Username = @Username " &
                "AND Password = @Password " &
                "AND Status = 'Active'"

                Using cmd As New SQLiteCommand(query, conn)

                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim())
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text)

                    Using reader As SQLiteDataReader = cmd.ExecuteReader()

                        If reader.Read() Then

                            MessageBox.Show("Login successful!")

                            Dim fullName As String = reader("FullName").ToString()
                            Dim role As String = reader("Role").ToString()

                            Dim dashboard As New frmDashboard(fullName, role)
                            dashboard.Show()

                            Me.Hide()

                        Else

                            MessageBox.Show("Invalid username or password.")

                        End If

                    End Using

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show("Login error: " & ex.Message)

        End Try

    End Sub

    Private Sub ApplyLanguage()

        If LanguageHelper.CurrentLanguage = "English" Then

            Label1.Text = "Welcome Back"
            Label2.Text = "Username"
            Label3.Text = "Password"
            btnLogin.Text = "Login"
            btnRegister.Text = "Create Account"
            btnBack.Text = "Back"

        ElseIf LanguageHelper.CurrentLanguage = "Itaukei" Then

            Label1.Text = "Ni Bula Tale"
            Label2.Text = "Yaca ni Vakayagataki"
            Label3.Text = "Vosa ni Maroroi"
            btnLogin.Text = "Curu"
            btnRegister.Text = "Dolava na Akaude"
            btnBack.Text = "Lesu"

        ElseIf LanguageHelper.CurrentLanguage = "Fiji Hindi" Then

            Label1.Text = "Phir Se Swagat Hai"
            Label2.Text = "Username"
            Label3.Text = "Password"
            btnLogin.Text = "Login"
            btnRegister.Text = "Naya Account Banai"
            btnBack.Text = "Peechhe"

        End If

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyLanguage()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmWelcome.Show()
        Me.Hide()
    End Sub
End Class