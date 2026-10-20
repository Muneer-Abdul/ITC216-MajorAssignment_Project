Imports System.Data.SQLite

Public Class frmFoodRequest

    Private Sub frmFoodRequest_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        LoadRecipientTypes()
        LoadUrgencyOptions()
        LoadRequestData()
        ApplyLanguage()

    End Sub


    Private Sub btnSubmitRequest_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnSubmitRequest.Click

        'Validate required fields
        If txtRequesterName.Text.Trim() = "" OrElse
           txtFoodNeeded.Text.Trim() = "" OrElse
           txtQuantityNeeded.Text.Trim() = "" OrElse
           cmbRecipientType.SelectedIndex = -1 OrElse
           txtCommunity.Text.Trim() = "" OrElse
           cmbUrgency.SelectedIndex = -1 OrElse
           txtRequestReason.Text.Trim() = "" Then

            MessageBox.Show(
                GetText("Please fill in all fields.",
                        "Yalovinaka ni vakalewena kece na vanua.",
                        "Sab field bhar ke submit karo.")
            )

            Return

        End If


        Dim quantityNeeded As Double

        If Not Double.TryParse(
            txtQuantityNeeded.Text,
            quantityNeeded
        ) OrElse quantityNeeded <= 0 Then

            MessageBox.Show(
                GetText("Enter a valid quantity.",
                        "Vakamacala e dua na levu ni kakana dodonu.",
                        "Sahi quantity daalo.")
            )

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
                GetText(
                    "Food request submitted successfully!",
                    "Kerekere ni kakana saumi!",
                    "Food request successfully submit ho gaya!"
                ),
                GetText("Success", "Saumi", "Safalta"),
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )


            ClearFields()
            LoadRequestData()


        Catch ex As Exception

            MessageBox.Show(
                GetText(
                    "Error submitting request: ",
                    "Sega ni rawa ni vakauta na kerekere: ",
                    "Request submit karne mein error: "
                ) & ex.Message
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
                GetText(
                    "Error loading food requests: ",
                    "Sega ni rawa ni vakaraitaka na kerekere ni kakana: ",
                    "Food requests load karne mein error: "
                ) & ex.Message
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


    Private Sub ApplyLanguage()

        If LanguageHelper.CurrentLanguage = "English" Then

            Label1.Text = "Food Request"
            Label2.Text = "Requester Name"
            Label3.Text = "Food Needed"
            Label4.Text = "Quantity Needed"
            Label5.Text = "Recipient Type"
            Label6.Text = "Community"
            Label7.Text = "Urgency"
            Label8.Text = "Request Reason"
            btnSubmitRequest.Text = "&Submit Request"
            btnClear.Text = "&Clear"


        ElseIf LanguageHelper.CurrentLanguage = "Itaukei" Then

            Label1.Text = "Kerekere ni Kakana"
            Label2.Text = "Yaca ni Dau Kerekere"
            Label3.Text = "Kakana e Kere"
            Label4.Text = "Levu ni Kakana e Kere"
            Label5.Text = "Mataqali Dauciqomi"
            Label6.Text = "Tikina"
            Label7.Text = "Bibi ni Kerekere"
            Label8.Text = "Vuna ni Kerekere"
            btnSubmitRequest.Text = "Vakauta na Kerekere"


        ElseIf LanguageHelper.CurrentLanguage = "Fiji Hindi" Then

            Label1.Text = "Food Request"
            Label2.Text = "Maangne Wala ke Naam"
            Label3.Text = "Kaun Sa Khana Chahiye"
            Label4.Text = "Kitna Khana Chahiye"
            Label5.Text = "Recipient Type"
            Label6.Text = "Community"
            Label7.Text = "Jarurat"
            Label8.Text = "Request ke Karan"
            btnSubmitRequest.Text = "Request Submit Karo"

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

    Private Sub cmbRecipientType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRecipientType.SelectedIndexChanged

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtRequesterName.Clear()
        txtFoodNeeded.Clear()
        txtQuantityNeeded.Clear()
        txtCommunity.Clear()
        txtRequestReason.Clear()

    End Sub
End Class