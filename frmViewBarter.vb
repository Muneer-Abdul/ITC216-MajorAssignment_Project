
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
                    "CreatorName, ConfirmedByName, ConfirmedAt " &
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

            'Make the confirmation information easier to find.
            If dgvBarter.Columns.Contains("CreatorName") Then
                dgvBarter.Columns("CreatorName").HeaderText = "Offer Created By"
            End If

            If dgvBarter.Columns.Contains("ConfirmedByName") Then
                dgvBarter.Columns("ConfirmedByName").HeaderText = "Confirmed By"
            End If

            If dgvBarter.Columns.Contains("ConfirmedAt") Then
                dgvBarter.Columns("ConfirmedAt").HeaderText = "Confirmation Date"
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

        'Older offers may not have creator IDs.
        If dgvBarter.Columns.Contains("CreatorUserID") AndAlso
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

            Dim confirmer As String =
                Convert.ToString(selectedRow.Cells("ConfirmedByName").Value)

            Dim confirmedAt As String =
                Convert.ToString(selectedRow.Cells("ConfirmedAt").Value)

            MessageBox.Show(
                GetText(
                    "This barter has already been confirmed by ",
                    "Sa vakadeitaki oti na veisau oqo mai vei ",
                    "Ee barter pehle hi confirm ho chuka hai: "
                ) & If(String.IsNullOrWhiteSpace(confirmer),
                       GetText("another user.", "e dua tale na dauvakayagataka.", "dusre user ne."),
                       confirmer) &
                Environment.NewLine &
                GetText("Confirmation date: ", "Tikinisiga ni vakadeitaki: ", "Confirm date: ") &
                confirmedAt,
                GetText("Barter Confirmed", "Veisau sa Vakadeitaki", "Barter Confirmed"),
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )
            Return
        End If

        'Prevent the creator from confirming their own offer.
        If creatorUserID <> 0 AndAlso creatorUserID = loggedInUserID Then
            MessageBox.Show(
                GetText(
                    "You cannot confirm your own barter offer.",
                    "E sega ni rawa ni o vakadeitaka na nomu solisoli veisau.",
                    "Aap apna khud ka barter offer confirm nahi kar sakte."
                ),
                GetText("Not Allowed", "E Sega ni Vakadonui", "Allowed Nahi Hai"),
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            Return
        End If

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
                    cmd.Parameters.AddWithValue(
                        "@confirmedAt",
                        DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                    )
                    cmd.Parameters.AddWithValue("@barterID", barterID)

                    Dim rowsUpdated As Integer = cmd.ExecuteNonQuery()

                    If rowsUpdated = 0 Then
                        MessageBox.Show(
                            GetText(
                                "The offer is no longer available or you cannot confirm your own offer. Refreshing the list.",
                                "Sa sega ni tiko na soli veisau se o sega ni rawa ni vakadeitaka na nomu soli veisau. Vakarautaka tale na lisi.",
                                "Offer ab available nahi hai ya aap apna offer confirm nahi kar sakte. List refresh ho rahi hai."
                            ),
                            GetText("Barter", "Veisau", "Barter"),
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        )

                        LoadBarterData()
                        Return
                    End If
                End Using
            End Using

            LoadBarterData()

            MessageBox.Show(
                GetText(
                    "Barter confirmed successfully. Your name and confirmation time have been recorded.",
                    "Sa vakadeitaki na veisau. Sa maroroi na yacamu kei na gauna ni vakadeitaki.",
                    "Barter confirm ho gaya. Aapka naam aur confirmation time save ho gaya."
                ),
                GetText(
                    "Barter Confirmed",
                    "Veisau sa Vakadeitaki",
                    "Barter Confirmed"
                ),
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

        Catch ex As Exception
            MessageBox.Show(
                GetText(
                    "Error confirming barter: ",
                    "Sega ni rawa ni vakadeitaka na veisau: ",
                    "Barter confirm karne mein error: "
                ) & ex.Message,
                GetText("Error", "Sega ni Rawa", "Error"),
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

End Class
