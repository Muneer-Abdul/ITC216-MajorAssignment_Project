Imports System.Data.SQLite

Public Class frmUserProfile

    Private loggedInUserID As Integer
    Private originalFullName As String

    Public Sub New(userID As Integer)

        InitializeComponent()

        loggedInUserID = userID

    End Sub


    Private Sub frmUserProfile_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        txtFullName.ReadOnly = True
        txtUsername.ReadOnly = True
        txtRole.ReadOnly = True
        txtStatus.ReadOnly = True

        btnSave.Enabled = False
        btnCancel.Enabled = False

        LoadUserProfile()
        ApplyLanguage()

    End Sub


    Private Sub LoadUserProfile()

        Try

            Using conn As SQLiteConnection =
                GetConnection()

                conn.Open()

                Dim query As String =
                    "SELECT FullName, Username, Role, Status " &
                    "FROM Users " &
                    "WHERE UserID = @UserID"

                Using cmd As New SQLiteCommand(
                    query,
                    conn
                )

                    cmd.Parameters.AddWithValue(
                        "@UserID",
                        loggedInUserID
                    )

                    Using reader As SQLiteDataReader =
                        cmd.ExecuteReader()

                        If reader.Read() Then

                            txtFullName.Text =
                                reader("FullName").ToString()

                            txtUsername.Text =
                                reader("Username").ToString()

                            txtRole.Text =
                                reader("Role").ToString()

                            txtStatus.Text =
                                reader("Status").ToString()

                            originalFullName =
                                txtFullName.Text

                        End If

                    End Using

                End Using

            End Using


        Catch ex As Exception

            MessageBox.Show(
                GetText(
                    "Error loading profile: ",
                    "Sega ni rawa ni vakaraitaka na profile: ",
                    "Profile load karne mein error: "
                ) & ex.Message,
                GetText(
                    "Profile Error",
                    "Sega ni Rawa na Profile",
                    "Profile Error"
                ),
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    Private Sub btnEdit_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnEdit.Click

        txtFullName.ReadOnly = False

        btnSave.Enabled = True
        btnCancel.Enabled = True

        txtFullName.Focus()

    End Sub


    Private Sub btnSave_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnSave.Click

        If txtFullName.Text.Trim() = "" Then

            MessageBox.Show(
                GetText(
                    "Full Name cannot be empty.",
                    "Na rawa ni lala na Yaca Taucoko.",
                    "Full Name khaali nahi ho sakta."
                ),
                GetText(
                    "Validation",
                    "Vakadeitaki",
                    "Validation"
                ),
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return

        End If


        Try

            Using conn As SQLiteConnection =
                GetConnection()

                conn.Open()

                Dim query As String =
                    "UPDATE Users " &
                    "SET FullName = @FullName " &
                    "WHERE UserID = @UserID"

                Using cmd As New SQLiteCommand(
                    query,
                    conn
                )

                    cmd.Parameters.AddWithValue(
                        "@FullName",
                        txtFullName.Text.Trim()
                    )

                    cmd.Parameters.AddWithValue(
                        "@UserID",
                        loggedInUserID
                    )

                    cmd.ExecuteNonQuery()

                End Using

            End Using


            originalFullName =
                txtFullName.Text.Trim()

            txtFullName.ReadOnly = True

            btnSave.Enabled = False
            btnCancel.Enabled = False


            MessageBox.Show(
                GetText(
                    "Profile updated successfully.",
                    "Saumi na vakavoutaki ni profile.",
                    "Profile successfully update ho gaya."
                ),
                GetText(
                    "Profile Updated",
                    "Profile sa Vakavoutaki",
                    "Profile Updated"
                ),
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )


        Catch ex As Exception

            MessageBox.Show(
                GetText(
                    "Error updating profile: ",
                    "Sega ni rawa ni vakavoutaka na profile: ",
                    "Profile update karne mein error: "
                ) & ex.Message,
                GetText(
                    "Update Error",
                    "Sega ni Rawa na Vakavoutaki",
                    "Update Error"
                ),
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    Private Sub btnCancel_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnCancel.Click

        txtFullName.Text =
            originalFullName

        txtFullName.ReadOnly = True

        btnSave.Enabled = False
        btnCancel.Enabled = False

    End Sub


    Private Sub ApplyLanguage()

        If LanguageHelper.CurrentLanguage = "English" Then

            lblTitle.Text = "User Profile"
            lblFullName.Text = "Full Name"
            lblUsername.Text = "Username"
            lblRole.Text = "Role"
            lblStatus.Text = "Status"

            btnEdit.Text = "&Edit"
            btnSave.Text = "&Save"
            btnCancel.Text = "&Cancel"


        ElseIf LanguageHelper.CurrentLanguage = "Itaukei" Then

            lblTitle.Text = "Profile ni Vakayagataki"
            lblFullName.Text = "Yaca Taucoko"
            lblUsername.Text = "Yaca ni Vakayagataki"
            lblRole.Text = "iTavi"
            lblStatus.Text = "iTuvaki"

            btnEdit.Text = "Veisautaka"
            btnSave.Text = "Maroroya"
            btnCancel.Text = "Kansela"


        ElseIf LanguageHelper.CurrentLanguage = "Fiji Hindi" Then

            lblTitle.Text = "User Profile"
            lblFullName.Text = "Pura Naam"
            lblUsername.Text = "Username"
            lblRole.Text = "Role"
            lblStatus.Text = "Status"

            btnEdit.Text = "Edit Karo"
            btnSave.Text = "Save Karo"
            btnCancel.Text = "Cancel Karo"

        End If

    End Sub


    Private Function GetText(
        englishText As String,
        itaukeiText As String,
        hindiText As String
    ) As String

        If LanguageHelper.CurrentLanguage = "Itaukei" Then

            Return itaukeiText

        ElseIf LanguageHelper.CurrentLanguage = "Fiji Hindi" Then

            Return hindiText

        Else

            Return englishText

        End If

    End Function

End Class