Imports System.Data.SQLite

Public Class frmFoodRequest

    Private Sub frmFoodRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRecipientTypes()
        LoadUrgencyOptions()
        LoadRequestData()
    End Sub
    Private Sub btnSubmitRequest_Click(sender As Object, e As EventArgs) Handles btnSubmitRequest.Click

        'Validate required fields
        If txtRequesterName.Text.Trim() = "" OrElse
       txtFoodNeeded.Text.Trim() = "" OrElse
       txtQuantityNeeded.Text.Trim() = "" OrElse
       cmbRecipientType.SelectedIndex = -1 OrElse
       txtCommunity.Text.Trim() = "" OrElse
       cmbUrgency.SelectedIndex = -1 OrElse
       txtRequestReason.Text.Trim() = "" Then

            MessageBox.Show("Please fill in all fields.")
            Return

        End If

        Dim quantityNeeded As Double

        If Not Double.TryParse(
        txtQuantityNeeded.Text,
        quantityNeeded
    ) OrElse quantityNeeded <= 0 Then

            MessageBox.Show("Enter a valid quantity.")
            Return

        End If

        Try

            Using conn As SQLiteConnection =
            DatabaseHelper.GetConnection()

                conn.Open()

                Dim query As String =
                "INSERT INTO FoodRequests " &
                "(RequesterName, FoodNeeded, QuantityNeeded, " &
                "RecipientType, Community, Urgency, " &
                "RequestReason, RequestDate, Status) " &
                "VALUES " &
                "(@requesterName, @foodNeeded, @quantityNeeded, " &
                "@recipientType, @community, @urgency, " &
                "@requestReason, @requestDate, 'Pending')"

                Using cmd As New SQLiteCommand(query, conn)

                    cmd.Parameters.AddWithValue(
                    "@requesterName",
                    txtRequesterName.Text.Trim()
                )

                    cmd.Parameters.AddWithValue(
                    "@foodNeeded",
                    txtFoodNeeded.Text.Trim()
                )

                    cmd.Parameters.AddWithValue(
                    "@quantityNeeded",
                    quantityNeeded
                )

                    cmd.Parameters.AddWithValue(
                    "@recipientType",
                    cmbRecipientType.SelectedItem.ToString()
                )

                    cmd.Parameters.AddWithValue(
                    "@community",
                    txtCommunity.Text.Trim()
                )

                    cmd.Parameters.AddWithValue(
                    "@urgency",
                    cmbUrgency.SelectedItem.ToString()
                )

                    cmd.Parameters.AddWithValue(
                    "@requestReason",
                    txtRequestReason.Text.Trim()
                )

                    cmd.Parameters.AddWithValue(
                    "@requestDate",
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                )

                    cmd.ExecuteNonQuery()

                End Using

            End Using

            MessageBox.Show(
            "Food request submitted successfully!",
            "Success",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )

            ClearFields()
            LoadRequestData()

        Catch ex As Exception

            MessageBox.Show(
            "Error submitting request: " & ex.Message
        )

        End Try

    End Sub

    Private Sub ClearFields()

        txtRequesterName.Clear()
        txtFoodNeeded.Clear()
        txtQuantityNeeded.Clear()
        txtCommunity.Clear()
        txtRequestReason.Clear()

        cmbRecipientType.SelectedIndex = -1
        cmbUrgency.SelectedIndex = -1

    End Sub

    Private Sub LoadRequestData()

        Try

            Using conn As SQLiteConnection =
                DatabaseHelper.GetConnection()

                conn.Open()

                Dim query As String =
                    "SELECT RequestID, RequesterName, FoodNeeded, " &
                    "QuantityNeeded, RecipientType, Community, " &
                    "Urgency, RequestReason, RequestDate, Status " &
                    "FROM FoodRequests " &
                    "ORDER BY RequestID DESC"

                Using adapter As New SQLiteDataAdapter(query, conn)

                    Dim table As New DataTable()

                    adapter.Fill(table)

                    dgvRequests.DataSource = table

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show(
                "Error loading food requests: " & ex.Message
            )

        End Try

    End Sub

    Private Sub LoadRecipientTypes()

        cmbRecipientType.Items.Clear()

        cmbRecipientType.Items.Add("Individual")
        cmbRecipientType.Items.Add("Family")
        cmbRecipientType.Items.Add("Community Organisation")
        cmbRecipientType.Items.Add("Charity")
        cmbRecipientType.Items.Add("School")

        cmbRecipientType.SelectedIndex = -1

    End Sub

    Private Sub LoadUrgencyOptions()

        cmbUrgency.Items.Clear()

        cmbUrgency.Items.Add("Low")
        cmbUrgency.Items.Add("Medium")
        cmbUrgency.Items.Add("High")

        cmbUrgency.SelectedIndex = -1

    End Sub
End Class