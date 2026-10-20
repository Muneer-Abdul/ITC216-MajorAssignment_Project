Imports System.Data.SQLite

Public Class frmViewBarter

    Private Sub frmViewBarter_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        LoadBarterData()
        ApplyLanguage()

    End Sub


    Private Sub LoadBarterData()

        Try

            Using conn As SQLiteConnection =
                GetConnection()

                conn.Open()

                Dim query As String =
                    "SELECT BarterID, PersonName, ContactNumber, " &
                    "OfferedProduce, OfferedQuantity, " &
                    "RequestedProduce, RequestedQuantity, " &
                    "Community, BarterDate, Status " &
                    "FROM Barter " &
                    "ORDER BY BarterID DESC"

                Using cmd As New SQLiteCommand(query, conn)

                    Using adapter As New SQLiteDataAdapter(cmd)

                        Dim table As New DataTable()

                        adapter.Fill(table)

                        dgvBarter.DataSource = table

                    End Using

                End Using

            End Using


            'Improve DataGridView appearance
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


        Catch ex As Exception

            MessageBox.Show(
                GetText(
                    "Error loading barter records: ",
                    "Sega ni rawa ni vakaraitaka na itukutuku ni veisau: ",
                    "Barter records load karne mein error: "
                ) & ex.Message,
                GetText(
                    "Barter",
                    "Veisau",
                    "Barter"
                ),
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


        Dim selectedRow As DataGridViewRow =
            dgvBarter.SelectedRows(0)


        Dim barterID As Integer =
            Convert.ToInt32(
                selectedRow.Cells("BarterID").Value
            )


        Dim currentStatus As String =
            selectedRow.Cells("Status").Value.ToString()


        If currentStatus.Equals(
            "Confirmed",
            StringComparison.OrdinalIgnoreCase
        ) Then

            MessageBox.Show(
                GetText(
                    "This barter has already been confirmed.",
                    "Sa vakadeitaki oti na veisau oqo.",
                    "Ee barter pehle se confirmed hai."
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


        Dim result As DialogResult =
            MessageBox.Show(
                GetText(
                    "Are you sure you want to confirm this barter?",
                    "O sa vakadeitaka ni o vinakata mo vakadeitaka na veisau oqo?",
                    "Kya aap is barter ko confirm karna chahte ho?"
                ),
                GetText(
                    "Confirm Barter",
                    "Vakadeitaka na Veisau",
                    "Barter Confirm Karo"
                ),
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )


        If result <> DialogResult.Yes Then
            Return
        End If


        Try

            Using conn As SQLiteConnection =
                GetConnection()

                conn.Open()

                Dim query As String =
                    "UPDATE Barter " &
                    "SET Status = 'Confirmed' " &
                    "WHERE BarterID = @BarterID"

                Using cmd As New SQLiteCommand(
                    query,
                    conn
                )

                    cmd.Parameters.AddWithValue(
                        "@BarterID",
                        barterID
                    )

                    cmd.ExecuteNonQuery()

                End Using

            End Using


            MessageBox.Show(
                GetText(
                    "Barter confirmed successfully.",
                    "Saumi na vakadeitaki ni veisau.",
                    "Barter successfully confirm ho gaya."
                ),
                GetText(
                    "Barter Confirmed",
                    "Veisau sa Vakadeitaki",
                    "Barter Confirmed"
                ),
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )


            LoadBarterData()


        Catch ex As Exception

            MessageBox.Show(
                GetText(
                    "Error confirming barter: ",
                    "Sega ni rawa ni vakadeitaka na veisau: ",
                    "Barter confirm karne mein error: "
                ) & ex.Message,
                GetText(
                    "Error",
                    "Sega ni Rawa",
                    "Error"
                ),
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