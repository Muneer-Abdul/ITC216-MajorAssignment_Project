
Imports System.Data.SQLite

Public Class frmViewBarter

    Private loggedInUserID As Integer
    Private loggedInName As String

    Public Sub New(userID As Integer, fullName As String)
        InitializeComponent()
        loggedInUserID = userID
        loggedInName = fullName
    End Sub

    Private Sub frmViewBarter_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        LoadBarterData()
        ApplyLanguage()

    End Sub

    Private Sub LoadBarterData()

        Try
            Using conn As SQLiteConnection = DatabaseHelper.GetConnection()
                conn.Open()

                Dim query As String =
                    "SELECT BarterID, PersonName, ContactNumber, " &
                    "OfferedProduce, OfferedQuantity, " &
                    "RequestedProduce, RequestedQuantity, " &
                    "Community, BarterDate, Status, " &
                    "CreatorUserID, CreatorName, " &
                    "ConfirmedByUserID, ConfirmedByName, ConfirmedAt " &
                    "FROM Barter ORDER BY BarterID DESC"

                Using adapter As New SQLiteDataAdapter(query, conn)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    dgvBarter.DataSource = table
                End Using
            End Using

            dgvBarter.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill
            dgvBarter.ReadOnly = True
            dgvBarter.AllowUserToAddRows = False
            dgvBarter.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect
            dgvBarter.MultiSelect = False
            dgvBarter.EnableHeadersVisualStyles = False
            dgvBarter.ColumnHeadersDefaultCellStyle.Font =
                New Font("Segoe UI", 10, FontStyle.Bold)
            dgvBarter.ColumnHeadersHeight = 35
            dgvBarter.RowTemplate.Height = 30

            If dgvBarter.Columns.Contains("CreatorName") Then
                dgvBarter.Columns("CreatorName").HeaderText =
                    "Offer Created By"
            End If

            If dgvBarter.Columns.Contains("ConfirmedByName") Then
                dgvBarter.Columns("ConfirmedByName").HeaderText =
                    "Confirmed By"
            End If

            If dgvBarter.Columns.Contains("ConfirmedAt") Then
                dgvBarter.Columns("ConfirmedAt").HeaderText =
                    "Confirmation Date"
            End If

        Catch ex As Exception
            MessageBox.Show(
                GetText(
                    "Error loading barter records: ",
                    "Sega ni rawa ni vakaraitaka na itukutuku ni veisau: ",
                    "Barter records load karne mein error: "
                ) & ex.Message,
                GetText("Barter", "Veisau", "Barter"),
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try

    End Sub

    Private Sub btnConfirmBarter_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnConfirmBarter.Click

        If dgvBarter.SelectedRows.Count = 0 Then
            MessageBox.Show(
                GetText(
                    "Please select a barter from the list.",
                    "Yalovinaka ni digitaka e dua na veisau mai na lisi.",
                    "List se ek barter select karo."
                ),
                GetText(
                    "Confirm Barter",
                    "Vakadeitaka na Veisau",
                    "Barter Confirm Karo"
                ),
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )
            Return
        End If

        Dim selectedRow As DataGridViewRow = dgvBarter.SelectedRows(0)

        Dim barterID As Integer =
            Convert.ToInt32(selectedRow.Cells("BarterID").Value)

        Dim currentStatus As String =
            Convert.ToString(selectedRow.Cells("Status").Value)

        Dim creatorUserID As Integer = 0

        If dgvBarter.Columns.Contains("CreatorUserID") AndAlso
           selectedRow.Cells("CreatorUserID").Value IsNot Nothing AndAlso
           Not IsDBNull(selectedRow.Cells("CreatorUserID").Value) Then

            Integer.TryParse(
                Convert.ToString(selectedRow.Cells("CreatorUserID").Value),
                creatorUserID
            )
        End If

        If currentStatus.Equals(
            "Confirmed",
            StringComparison.OrdinalIgnoreCase
        ) Then
            MessageBox.Show(
                GetText(
                    "This barter has already been confirmed.",
                    "Sa vakadeitaki oti na veisau oqo.",
                    "Yeh barter pehle hi confirm ho chuka hai."
                )
            )
            Return
        End If

        If creatorUserID <> 0 AndAlso creatorUserID = loggedInUserID Then
            MessageBox.Show(
                GetText(
                    "You cannot confirm your own barter offer.",
                    "E sega ni rawa ni o vakadeitaka na nomu soli veisau.",
                    "Aap apna khud ka barter offer confirm nahi kar sakte."
                )
            )
            Return
        End If

        ' Capture all row information BEFORE refreshing the grid.
        Dim offeredProduce As String =
            Convert.ToString(selectedRow.Cells("OfferedProduce").Value)

        Dim requestedProduce As String =
            Convert.ToString(selectedRow.Cells("RequestedProduce").Value)

        Dim result As DialogResult = MessageBox.Show(
            GetText(
                "Confirm this barter offer?",
                "Vakadeitaka na soli veisau oqo?",
                "Ee barter offer confirm karein?"
            ),
            GetText(
                "Confirm Barter",
                "Vakadeitaka na Veisau",
                "Barter Confirm Karo"
            ),
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result <> DialogResult.Yes Then Return

        Try
            Dim confirmedAt As String =
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

            ' Update the database first.
            Using conn As SQLiteConnection = DatabaseHelper.GetConnection()
                conn.Open()

                Dim query As String =
                    "UPDATE Barter SET " &
                    "Status = 'Confirmed', " &
                    "ConfirmedByUserID = @userID, " &
                    "ConfirmedByName = @userName, " &
                    "ConfirmedAt = @confirmedAt " &
                    "WHERE BarterID = @barterID " &
                    "AND Status = 'Available' " &
                    "AND (CreatorUserID = 0 OR CreatorUserID <> @userID)"

                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@userID", loggedInUserID)
                    cmd.Parameters.AddWithValue("@userName", loggedInName)
                    cmd.Parameters.AddWithValue("@confirmedAt", confirmedAt)
                    cmd.Parameters.AddWithValue("@barterID", barterID)

                    Dim rowsUpdated As Integer = cmd.ExecuteNonQuery()

                    If rowsUpdated = 0 Then
                        MessageBox.Show(
                            "The offer is no longer available or cannot be confirmed. Refreshing the list."
                        )
                        LoadBarterData()
                        Return
                    End If
                End Using
            End Using

            ' Database update succeeded. Retrieve both email addresses.
            Dim creatorEmail As String = GetUserEmail(creatorUserID)
            Dim confirmerEmail As String = GetUserEmail(loggedInUserID)

            ' Refresh only after capturing the data needed for the emails.
            LoadBarterData()

            Dim emailBody As String =
                "Hello," & Environment.NewLine & Environment.NewLine &
                "A barter offer in Viti FoodLink has been confirmed." &
                Environment.NewLine & Environment.NewLine &
                "Barter ID: " & barterID & Environment.NewLine &
                "Offered produce: " & offeredProduce & Environment.NewLine &
                "Requested produce: " & requestedProduce & Environment.NewLine &
                "Confirmed by: " & loggedInName & Environment.NewLine &
                "Confirmation time: " & confirmedAt & Environment.NewLine &
                Environment.NewLine &
                "Please contact the other party to arrange the exchange." &
                Environment.NewLine & Environment.NewLine &
                "Regards," & Environment.NewLine &
                "Viti FoodLink"

            Dim creatorEmailSent As Boolean = False
            Dim confirmerEmailSent As Boolean = False
            Dim emailErrors As String = ""

            ' Notify the offer creator.
            If creatorUserID > 0 AndAlso
               Not String.IsNullOrWhiteSpace(creatorEmail) Then

                Try
                    EmailHelper.SendEmail(
                        creatorEmail,
                        "Viti FoodLink - Barter Confirmed",
                        emailBody
                    )
                    creatorEmailSent = True

                Catch ex As Exception
                    emailErrors &=
                        "Creator email failed: " & ex.Message &
                        Environment.NewLine
                End Try

            Else
                emailErrors &=
                    "Creator email unavailable: no linked user ID or email address." &
                    Environment.NewLine
            End If

            ' Notify the person who confirmed the barter.
            If Not String.IsNullOrWhiteSpace(confirmerEmail) Then

                Try
                    EmailHelper.SendEmail(
                        confirmerEmail,
                        "Viti FoodLink - Barter Confirmation Receipt",
                        emailBody
                    )
                    confirmerEmailSent = True

                Catch ex As Exception
                    emailErrors &=
                        "Confirmer email failed: " & ex.Message &
                        Environment.NewLine
                End Try

            Else
                emailErrors &=
                    "Your email address is missing from your account." &
                    Environment.NewLine
            End If

            Dim summary As String =
                "Barter confirmed successfully." & Environment.NewLine &
                "Creator email sent: " &
                If(creatorEmailSent, "Yes", "No") &
                Environment.NewLine &
                "Confirmer email sent: " &
                If(confirmerEmailSent, "Yes", "No")

            If emailErrors <> "" Then
                summary &= Environment.NewLine & Environment.NewLine &
                    "Email notification details:" & Environment.NewLine &
                    emailErrors
            End If

            MessageBox.Show(
                summary,
                "Viti FoodLink",
                MessageBoxButtons.OK,
                If(emailErrors = "",
                   MessageBoxIcon.Information,
                   MessageBoxIcon.Warning)
            )

        Catch ex As Exception
            MessageBox.Show(
                "Error confirming barter: " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try

    End Sub

    Private Sub ApplyLanguage()

        If LanguageHelper.CurrentLanguage = "English" Then
            Label1.Text = "View Barter"
            btnConfirmBarter.Text = "&Confirm Barter"

        ElseIf LanguageHelper.CurrentLanguage = "Itaukei" Then
            Label1.Text = "Raica na Veisau"
            btnConfirmBarter.Text = "Vakadeitaka na Veisau"

        ElseIf LanguageHelper.CurrentLanguage = "Fiji Hindi" Then
            Label1.Text = "Barter Dekho"
            btnConfirmBarter.Text = "Barter Confirm Karo"
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

    Private Sub btnTestEmail_Click(
        sender As Object,
        e As EventArgs
    )

        Try
            Dim recipient As String =
                Environment.GetEnvironmentVariable("VITIFOODLINK_EMAIL")

            EmailHelper.SendEmail(
                recipient,
                "Viti FoodLink Email Test",
                "Success! Viti FoodLink can send emails through Gmail."
            )

            MessageBox.Show(
                "Test email sent successfully. Check your inbox.",
                "Email Test",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

        Catch ex As Exception
            MessageBox.Show(
                "Email test failed: " & ex.Message,
                "Email Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try

    End Sub

    Private Function GetUserEmail(userID As Integer) As String

        If userID <= 0 Then Return ""

        Using conn As SQLiteConnection = DatabaseHelper.GetConnection()
            conn.Open()

            Dim query As String =
                "SELECT Email FROM Users WHERE UserID = @userID"

            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@userID", userID)

                Dim result As Object = cmd.ExecuteScalar()

                If result IsNot Nothing AndAlso
                   result IsNot DBNull.Value Then
                    Return result.ToString().Trim()
                End If
            End Using
        End Using

        Return ""

    End Function

End Class
