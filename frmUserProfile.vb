Imports System.Data.SQLite

Public Class frmUserProfile

    Private loggedInUserID As Integer
    Private originalFullName As String

    Public Sub New(userID As Integer)
        InitializeComponent()
        loggedInUserID = userID
    End Sub

    Private Sub frmUserProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtFullName.ReadOnly = True
        txtUsername.ReadOnly = True
        txtRole.ReadOnly = True
        txtStatus.ReadOnly = True

        btnSave.Enabled = False
        btnCancel.Enabled = False

        LoadUserProfile()

    End Sub

    Private Sub LoadUserProfile()

        Try
            Using conn As SQLiteConnection = GetConnection()

                conn.Open()

                Dim query As String =
                    "SELECT FullName, Username, Role, Status " &
                    "FROM Users " &
                    "WHERE UserID = @UserID"

                Using cmd As New SQLiteCommand(query, conn)

                    cmd.Parameters.AddWithValue("@UserID", loggedInUserID)

                    Using reader As SQLiteDataReader = cmd.ExecuteReader()

                        If reader.Read() Then

                            txtFullName.Text = reader("FullName").ToString()
                            txtUsername.Text = reader("Username").ToString()
                            txtRole.Text = reader("Role").ToString()
                            txtStatus.Text = reader("Status").ToString()

                            originalFullName = txtFullName.Text

                        End If

                    End Using

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show(
                "Error loading profile: " & ex.Message,
                "Profile Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        txtFullName.ReadOnly = False

        btnSave.Enabled = True
        btnCancel.Enabled = True

        txtFullName.Focus()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtFullName.Text.Trim() = "" Then

            MessageBox.Show(
                "Full Name cannot be empty.",
                "Validation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return

        End If

        Try
            Using conn As SQLiteConnection = GetConnection()

                conn.Open()

                Dim query As String =
                    "UPDATE Users " &
                    "SET FullName = @FullName " &
                    "WHERE UserID = @UserID"

                Using cmd As New SQLiteCommand(query, conn)

                    cmd.Parameters.AddWithValue("@FullName", txtFullName.Text.Trim())
                    cmd.Parameters.AddWithValue("@UserID", loggedInUserID)

                    cmd.ExecuteNonQuery()

                End Using

            End Using

            originalFullName = txtFullName.Text.Trim()

            txtFullName.ReadOnly = True

            btnSave.Enabled = False
            btnCancel.Enabled = False

            MessageBox.Show(
                "Profile updated successfully.",
                "Profile Updated",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

        Catch ex As Exception

            MessageBox.Show(
                "Error updating profile: " & ex.Message,
                "Update Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        txtFullName.Text = originalFullName

        txtFullName.ReadOnly = True

        btnSave.Enabled = False
        btnCancel.Enabled = False

    End Sub

End Class