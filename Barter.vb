Imports System.Data.SQLite

Public Class frmBarter

    Private Sub frmBarter_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        LoadBarterData()
        ApplyLanguage()

    End Sub


    Private Sub btnAddBarter_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnAddBarter.Click

        'Validate input
        If txtName.Text.Trim() = "" OrElse
           txtNumber.Text.Trim() = "" OrElse
           txtOfferedProduce.Text.Trim() = "" OrElse
           txtOfferedQuantity.Text.Trim() = "" OrElse
           txtRequestedProduce.Text.Trim() = "" OrElse
           txtRequestedQuantity.Text.Trim() = "" OrElse
           txtCommunity.Text.Trim() = "" Then

            MessageBox.Show(
                GetText(
                    "Please fill in all fields.",
                    "Yalovinaka ni vakalewena kece na vanua.",
                    "Sab field bhar ke submit karo."
                )
            )

            Return

        End If


        Dim offeredQuantity As Double
        Dim requestedQuantity As Double


        If Not Double.TryParse(
            txtOfferedQuantity.Text,
            offeredQuantity
        ) OrElse offeredQuantity <= 0 Then

            MessageBox.Show(
                GetText(
                    "Enter a valid offered quantity.",
                    "Vakamacala e dua na levu ni kakana e soli.",
                    "Sahi offered quantity daalo."
                )
            )

            Return

        End If


        If Not Double.TryParse(
            txtRequestedQuantity.Text,
            requestedQuantity
        ) OrElse requestedQuantity <= 0 Then

            MessageBox.Show(
                GetText(
                    "Enter a valid requested quantity.",
                    "Vakamacala e dua na levu ni kakana e kerei.",
                    "Sahi requested quantity daalo."
                )
            )

            Return

        End If


        Try

            Using conn As SQLiteConnection =
                DatabaseHelper.GetConnection()

                conn.Open()

                Dim query As String =
                    "INSERT INTO Barter " &
                    "(PersonName, ContactNumber, OfferedProduce, " &
                    "OfferedQuantity, RequestedProduce, " &
                    "RequestedQuantity, Community, BarterDate) " &
                    "VALUES " &
                    "(@personName, @contactNumber, @offeredProduce, " &
                    "@offeredQuantity, @requestedProduce, " &
                    "@requestedQuantity, @community, @barterDate)"

                Using cmd As New SQLiteCommand(query, conn)

                    cmd.Parameters.AddWithValue(
                        "@personName",
                        txtName.Text.Trim()
                    )

                    cmd.Parameters.AddWithValue(
                        "@contactNumber",
                        txtNumber.Text.Trim()
                    )

                    cmd.Parameters.AddWithValue(
                        "@offeredProduce",
                        txtOfferedProduce.Text.Trim()
                    )

                    cmd.Parameters.AddWithValue(
                        "@offeredQuantity",
                        offeredQuantity
                    )

                    cmd.Parameters.AddWithValue(
                        "@requestedProduce",
                        txtRequestedProduce.Text.Trim()
                    )

                    cmd.Parameters.AddWithValue(
                        "@requestedQuantity",
                        requestedQuantity
                    )

                    cmd.Parameters.AddWithValue(
                        "@community",
                        txtCommunity.Text.Trim()
                    )

                    cmd.Parameters.AddWithValue(
                        "@barterDate",
                        DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                    )

                    cmd.ExecuteNonQuery()

                End Using

            End Using


            MessageBox.Show(
                GetText(
                    "Barter offer added successfully!",
                    "Saumi na veisau ni kakana!",
                    "Barter offer successfully add ho gaya!"
                ),
                GetText(
                    "Success",
                    "Saumi",
                    "Safalta"
                ),
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )


            ClearFields()
            LoadBarterData()


        Catch ex As Exception

            MessageBox.Show(
                GetText(
                    "Error adding barter offer: ",
                    "Sega ni rawa ni vakuria na veisau: ",
                    "Barter offer add karne mein error: "
                ) & ex.Message
            )

        End Try

    End Sub


    Private Sub ClearFields()

        txtName.Clear()
        txtNumber.Clear()
        txtOfferedProduce.Clear()
        txtOfferedQuantity.Clear()
        txtRequestedProduce.Clear()
        txtRequestedQuantity.Clear()
        txtCommunity.Clear()

    End Sub


    Private Sub LoadBarterData()

        Try

            Using conn As SQLiteConnection =
                DatabaseHelper.GetConnection()

                conn.Open()

                Dim query As String =
                    "SELECT BarterID, PersonName, ContactNumber, " &
                    "OfferedProduce, OfferedQuantity, " &
                    "RequestedProduce, RequestedQuantity, " &
                    "Community, BarterDate, Status " &
                    "FROM Barter " &
                    "ORDER BY BarterID DESC"

                Using adapter As New SQLiteDataAdapter(
                    query,
                    conn
                )

                    Dim table As New DataTable()

                    adapter.Fill(table)

                    dgvBarter.DataSource = table


                    'Improve DataGridView appearance
                    dgvBarter.AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.Fill

                    dgvBarter.ReadOnly = True

                    dgvBarter.AllowUserToAddRows = False

                    dgvBarter.SelectionMode =
                        DataGridViewSelectionMode.FullRowSelect

                    dgvBarter.EnableHeadersVisualStyles = False

                    dgvBarter.ColumnHeadersDefaultCellStyle.Font =
                        New Font("Segoe UI", 10, FontStyle.Bold)

                    dgvBarter.ColumnHeadersHeight = 35

                    dgvBarter.RowTemplate.Height = 30

                End Using

            End Using


        Catch ex As Exception

            MessageBox.Show(
                GetText(
                    "Error loading barter records: ",
                    "Sega ni rawa ni vakaraitaka na itukutuku ni veisau: ",
                    "Barter records load karne mein error: "
                ) & ex.Message
            )

        End Try

    End Sub


    Private Sub btnClear_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnClear.Click

        ClearFields()

    End Sub


    Private Sub ApplyLanguage()

        If LanguageHelper.CurrentLanguage = "English" Then

            Label1.Text = "Barter"
            Label7.Text = "Name"
            Label8.Text = "Contact Number"
            Label2.Text = "Offered Produce"
            Label3.Text = "Offered Quantity"
            Label4.Text = "Requested Produce"
            Label5.Text = "Requested Quantity"
            Label6.Text = "Community"

            btnAddBarter.Text = "Add Barter"
            btnClear.Text = "Clear"


        ElseIf LanguageHelper.CurrentLanguage = "Itaukei" Then

            Label1.Text = "Veisau"
            Label7.Text = "Yaca"
            Label8.Text = "Naba ni Veitaratara"
            Label2.Text = "Kakana e Soli"
            Label3.Text = "Levu ni Kakana e Soli"
            Label4.Text = "Kakana e Kerei"
            Label5.Text = "Levu ni Kakana e Kerei"
            Label6.Text = "Tikina"

            btnAddBarter.Text = "Vakuria na Veisau"
            btnClear.Text = "Sereka"


        ElseIf LanguageHelper.CurrentLanguage = "Fiji Hindi" Then

            Label1.Text = "Barter"
            Label7.Text = "Naam"
            Label8.Text = "Contact Number"
            Label2.Text = "Jo Khana De Rahe Ho"
            Label3.Text = "Diye Wala Quantity"
            Label4.Text = "Jo Khana Maang Rahe Ho"
            Label5.Text = "Maanga Hua Quantity"
            Label6.Text = "Community"

            btnAddBarter.Text = "Barter Add Karo"
            btnClear.Text = "Clear"

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