
Imports System.Data.SQLite

Public Class frmBarter

    Private loggedInUserID As Integer
    Private loggedInName As String

    Public Sub New(userID As Integer, fullName As String)
        InitializeComponent()
        loggedInUserID = userID
        loggedInName = fullName
    End Sub

    Private Sub frmBarter_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        LoadBarterData()
        ApplyLanguage()

        'Use the logged-in user's name as the default offer name.
        If Not String.IsNullOrWhiteSpace(loggedInName) Then
            txtName.Text = loggedInName
        End If
    End Sub

    Private Sub btnAddBarter_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnAddBarter.Click

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
                    "Yalovinaka ni vakalewena na vanua kece.",
                    "Kripya sabhi fields bhariye."
                ),
                "Viti FoodLink",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            Return
        End If

        Dim offeredQuantity As Double
        Dim requestedQuantity As Double

        If Not Double.TryParse(
            txtOfferedQuantity.Text.Trim(),
            offeredQuantity
        ) OrElse offeredQuantity <= 0 Then

            MessageBox.Show(
                GetText(
                    "Enter a valid offered quantity greater than zero.",
                    "Vola na levu ni kakana e soli e dodonu.",
                    "Di gayi quantity sahi aur zero se zyada honi chahiye."
                )
            )
            Return
        End If

        If Not Double.TryParse(
            txtRequestedQuantity.Text.Trim(),
            requestedQuantity
        ) OrElse requestedQuantity <= 0 Then

            MessageBox.Show(
                GetText(
                    "Enter a valid requested quantity greater than zero.",
                    "Vola na levu ni kakana e kerei e dodonu.",
                    "Maangi gayi quantity sahi aur zero se zyada honi chahiye."
                )
            )
            Return
        End If

        Try
            Using conn As SQLiteConnection = DatabaseHelper.GetConnection()
                conn.Open()

                Dim query As String =
                    "INSERT INTO Barter " &
                    "(PersonName, ContactNumber, OfferedProduce, " &
                    "OfferedQuantity, RequestedProduce, " &
                    "RequestedQuantity, Community, BarterDate, Status, " &
                    "CreatorUserID, CreatorName) " &
                    "VALUES " &
                    "(@personName, @contactNumber, @offeredProduce, " &
                    "@offeredQuantity, @requestedProduce, " &
                    "@requestedQuantity, @community, @barterDate, " &
                    "'Available', @creatorUserID, @creatorName)"

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

                    cmd.Parameters.AddWithValue(
                        "@creatorUserID",
                        loggedInUserID
                    )

                    cmd.Parameters.AddWithValue(
                        "@creatorName",
                        loggedInName
                    )

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show(
                GetText(
                    "Barter offer added successfully!",
                    "Sa rawarawa na nomuni soli veisau!",
                    "Barter offer safalta se add ho gaya!"
                ),
                "Viti FoodLink",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            ClearFields()
            LoadBarterData()

        Catch ex As Exception

            MessageBox.Show(
                GetText(
                    "Error adding barter offer: ",
                    "E sega ni rawa ni vakacurumi na soli veisau: ",
                    "Barter offer add karne mein error: "
                ) & ex.Message,
                "Viti FoodLink",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
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
            Using conn As SQLiteConnection = DatabaseHelper.GetConnection()
                conn.Open()

                Dim query As String =
                    "SELECT BarterID, PersonName, ContactNumber, " &
                    "OfferedProduce, OfferedQuantity, " &
                    "RequestedProduce, RequestedQuantity, " &
                    "Community, BarterDate, Status " &
                    "FROM Barter ORDER BY BarterID DESC"

                Using adapter As New SQLiteDataAdapter(query, conn)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    dgvBarter.DataSource = table
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
                    "E sega ni rawa ni vakaraitaki na itukutuku ni soli veisau: ",
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
        'Keep your existing ApplyLanguage implementation here.
        'Preserve your current English, iTaukei and Fiji Hindi labels.

        If LanguageHelper.CurrentLanguage = "English" Then

            'Label7.Text = "Food Barter Exchange"
            Label7.Text = "Person Name:"
            Label8.Text = "Contact Number:"
            Label2.Text = "Offered Produce:"
            Label3.Text = "Offered Quantity:"
            Label4.Text = "Requested Produce:"
            Label5.Text = "Requested Quantity:"
            Label6.Text = "Community:"

            btnAddBarter.Text = "&Add Barter"
            btnClear.Text = "&Clear Fields"

        ElseIf LanguageHelper.CurrentLanguage = "Itaukei" OrElse
               LanguageHelper.CurrentLanguage = "iTaukei" Then

            Label1.Text = "Veisau ni Kakana"
            Label7.Text = "Yaca ni Tamata:"
            Label8.Text = "Naba ni Veitaratara:"
            Label2.Text = "Kakana e Soli:"
            Label3.Text = "Levu ni Kakana e Soli:"
            Label4.Text = "Kakana e Kerei:"
            Label5.Text = "Levu ni Kakana e Kerei:"
            Label6.Text = "Tikina:"

            btnAddBarter.Text = "Vakacuruma na Barter"
            btnClear.Text = "Vakasavasavataka"

        ElseIf LanguageHelper.CurrentLanguage = "Fiji Hindi" Then

            Label1.Text = "Khana Badlao"
            Label7.Text = "Aadmi ke Naam:"
            Label8.Text = "Contact Number:"
            Label2.Text = "Diya Gaya Khana:"
            Label3.Text = "Diya Gaya Quantity:"
            Label4.Text = "Maanga Gaya Khana:"
            Label5.Text = "Maanga Gaya Quantity:"
            Label6.Text = "Community:"

            btnAddBarter.Text = "Barter Jodo"
            btnClear.Text = "Fields Saaf Karo"

        End If

    End Sub

    Private Function GetText(
        englishText As String,
        itaukeiText As String,
        hindiText As String
    ) As String

        Select Case LanguageHelper.CurrentLanguage
            Case "iTaukei"
                Return itaukeiText

            Case "Fiji Hindi"
                Return hindiText

            Case Else
                Return englishText
        End Select

    End Function


End Class
