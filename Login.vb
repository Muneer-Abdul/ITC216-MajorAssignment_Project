Imports System.Data.SQLite
Imports Microsoft.VisualBasic.ApplicationServices

Public Class frmLogin

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        frmRegistration.Show()
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

                    cmd.Parameters.AddWithValue(
                        "@Username",
                        txtUsername.Text.Trim()
                    )

                    cmd.Parameters.AddWithValue(
                        "@Password",
                        txtPassword.Text
                    )

                    Using reader As SQLiteDataReader = cmd.ExecuteReader()

                        If reader.Read() Then

                            MessageBox.Show("Login successful!")

                            Dim userID As Integer = Convert.ToInt32(reader("UserID"))

                            Dim fullName As String = reader("FullName").ToString()

                            Dim role As String = reader("Role").ToString()


                            '========================================
                            ' OPEN DASHBOARD BASED ON USER ROLE
                            '========================================

                            If role.Equals(
                                "Admin",
                                StringComparison.OrdinalIgnoreCase
                            ) Then

                                Dim dashboard As New frmDashboard(
                                    userID,
                                    fullName,
                                    role
                                )

                                dashboard.Show()


                            ElseIf role.Equals(
                                "Community Organisation",
                                StringComparison.OrdinalIgnoreCase
                            ) Then

                                Dim organisationDashboard As New frmOrganisationDashboard(userID,
                                    fullName, role
                                )

                                organisationDashboard.Show()


                            ElseIf role.Equals(
                                "User",
                                StringComparison.OrdinalIgnoreCase
                            ) Then

                                Dim userDashboard As New frmUserDashboard(userID,
                                    fullName,
                                    role
                                )

                                userDashboard.Show()

                            End If

                            Me.Hide()

                        Else

                            MessageBox.Show(
                                "Invalid username or password."
                            )

                        End If

                    End Using

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show(
                "Login error: " & ex.Message
            )

        End Try

    End Sub


    Private Sub ApplyLanguage()

        If LanguageHelper.CurrentLanguage = "English" Then

            Label1.Text = "Welcome Back"
            Label2.Text = "Username:"
            Label3.Text = "Password:"
            btnLogin.Text = "&Login"
            btnRegister.Text = "&Create Account"
            btnBack.Text = "&Back"

        ElseIf LanguageHelper.CurrentLanguage = "Itaukei" Then

            Label1.Text = "Ni Bula Tale"
            Label2.Text = "Yaca ni Vakayagataki:"
            Label3.Text = "Vosa ni Maroroi:"
            btnLogin.Text = "Curu"
            btnRegister.Text = "Dolava na Akaude"
            btnBack.Text = "Lesu"

        ElseIf LanguageHelper.CurrentLanguage = "Fiji Hindi" Then

            Label1.Text = "Phir Se Swagat Hai"
            Label2.Text = "Username:"
            Label3.Text = "Password:"
            btnLogin.Text = "Login"
            btnRegister.Text = "Naya Account Banai"
            btnBack.Text = "Peechhe"

        End If

    End Sub


    Private Sub frmLogin_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        ApplyLanguage()

    End Sub


    Private Sub btnBack_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnBack.Click

        frmWelcome.Show()
        Me.Hide()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged, chkShowPassword.CheckedChanged


        If chkShowPassword.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If

    End Sub
End Class