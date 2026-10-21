Imports System.Data.SQLite

Public Class frmDistribution

    Private loggedInRole As String

    Public Sub New(role As String)

        InitializeComponent()

        loggedInRole = role

    End Sub
    Private Sub LoadProduce()

        Try
            Using conn As SQLiteConnection =
                DatabaseHelper.GetConnection()

                conn.Open()

                Dim query As String =
                    "SELECT ProduceID, ProduceName " &
                    "FROM SurplusProduce " &
                    "WHERE Quantity > 0"

                Using adapter As New SQLiteDataAdapter(query, conn)

                    Dim table As New DataTable()
                    adapter.Fill(table)

                    cmbProduce.DataSource = table
                    cmbProduce.DisplayMember = "ProduceName"
                    cmbProduce.ValueMember = "ProduceID"

                    cmbProduce.SelectedIndex = -1

                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading produce: " & ex.Message)
        End Try

    End Sub

    Private Sub frmDistribution_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not loggedInRole.Equals("Admin", StringComparison.OrdinalIgnoreCase) Then

            MessageBox.Show(
            "Access denied. Only administrators can access Produce Distribution.",
            "Access Denied",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        )

            Me.Close()
            Return

        End If

        ApplyLanguage()
        LoadProduce()
        LoadRecipients()
        LoadDistributionMethods()
        LoadDistributionData()

    End Sub

    Private Sub cmbProduce_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProduce.SelectedIndexChanged

        If cmbProduce.SelectedIndex = -1 OrElse
       cmbProduce.SelectedValue Is Nothing Then

            txtAvailableQuantity.Clear()
            Return
        End If

        Try
            Using conn As SQLiteConnection =
            DatabaseHelper.GetConnection()

                conn.Open()

                Dim query As String =
                "SELECT Quantity FROM SurplusProduce " &
                "WHERE ProduceID = @id"

                Using cmd As New SQLiteCommand(query, conn)

                    cmd.Parameters.AddWithValue(
                    "@id",
                    cmbProduce.SelectedValue)

                    Dim quantity As Object = cmd.ExecuteScalar()

                    If quantity IsNot Nothing Then
                        txtAvailableQuantity.Text =
                        quantity.ToString()
                    End If

                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show(
            "Error loading quantity: " &
            ex.Message)
        End Try

    End Sub

    Private Sub LoadRecipients()

        Try
            Using conn As SQLiteConnection =
                DatabaseHelper.GetConnection()

                conn.Open()

                Dim query As String =
                    "SELECT RecipientID, RecipientName " &
                    "FROM Recipients"

                Using adapter As New SQLiteDataAdapter(query, conn)

                    Dim table As New DataTable()
                    adapter.Fill(table)

                    cmbRecipient.DataSource = table
                    cmbRecipient.DisplayMember = "RecipientName"
                    cmbRecipient.ValueMember = "RecipientID"

                    cmbRecipient.SelectedIndex = -1

                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show(
                "Error loading recipients: " &
                ex.Message)
        End Try

    End Sub

    Private Sub btnDistribute_Click(sender As Object, e As EventArgs) Handles btnDistribute.Click

        If cmbProduce.SelectedIndex = -1 Then
            MessageBox.Show("Please select produce.")
            Return
        End If

        If cmbRecipient.SelectedIndex = -1 Then
            MessageBox.Show("Please select a recipient.")
            Return
        End If

        If cmbDistributionMethod.SelectedIndex = -1 Then
            MessageBox.Show("Please select a distribution method.")
            Return
        End If

        Dim availableQuantity As Double
        Dim distributionQuantity As Double

        If Not Double.TryParse(
        txtAvailableQuantity.Text,
        availableQuantity) Then

            MessageBox.Show("Invalid available quantity.")
            Return
        End If

        If Not Double.TryParse(
        txtDistributionQuantity.Text,
        distributionQuantity) OrElse
        distributionQuantity <= 0 Then

            MessageBox.Show("Please enter a valid quantity.")
            Return
        End If

        If distributionQuantity > availableQuantity Then

            MessageBox.Show(
            "Distribution quantity cannot exceed " &
            "available quantity.")

            Return
        End If

        Try
            Using conn As SQLiteConnection =
            DatabaseHelper.GetConnection()

                conn.Open()

                Using transaction As SQLiteTransaction =
                conn.BeginTransaction()

                    'Save distribution record
                    Dim insertQuery As String =
                    "INSERT INTO Distribution " &
                    "(ProduceID, RecipientID, " &
                    "DistributionQuantity, DistributionDate, " &
                    "DistributionMethod) " &
                    "VALUES (@produceID, @recipientID, " &
                    "@quantity, @date, @method)"

                    Using cmd As New SQLiteCommand(
                    insertQuery, conn, transaction)

                        cmd.Parameters.AddWithValue(
                        "@produceID", cmbProduce.SelectedValue)

                        cmd.Parameters.AddWithValue(
                        "@recipientID", cmbRecipient.SelectedValue)

                        cmd.Parameters.AddWithValue(
                        "@quantity", distributionQuantity)

                        cmd.Parameters.AddWithValue(
                        "@date",
                        dtpDistributionDate.Value.ToString(
                            "yyyy-MM-dd"))

                        cmd.Parameters.AddWithValue(
                        "@method",
                        cmbDistributionMethod.Text)

                        cmd.ExecuteNonQuery()

                    End Using

                    'Reduce available produce quantity
                    Dim updateQuery As String =
                    "UPDATE SurplusProduce " &
                    "SET Quantity = Quantity - @quantity " &
                    "WHERE ProduceID = @produceID " &
                    "AND Quantity >= @quantity"

                    Using updateCmd As New SQLiteCommand(
                    updateQuery, conn, transaction)

                        updateCmd.Parameters.AddWithValue(
                        "@quantity", distributionQuantity)

                        updateCmd.Parameters.AddWithValue(
                        "@produceID", cmbProduce.SelectedValue)

                        Dim rowsAffected As Integer =
                        updateCmd.ExecuteNonQuery()

                        If rowsAffected = 0 Then
                            transaction.Rollback()

                            MessageBox.Show(
                            "Insufficient available quantity.")

                            Return
                        End If

                    End Using

                    transaction.Commit()

                End Using
            End Using

            MessageBox.Show(
            "Produce distributed successfully!")

            txtDistributionQuantity.Clear()

            LoadProduce()
            LoadDistributionData()

            txtAvailableQuantity.Clear()

        Catch ex As Exception

            MessageBox.Show(
            "Error saving distribution: " &
            ex.Message)

        End Try

    End Sub

    Private Sub LoadDistributionMethods()

        cmbDistributionMethod.Items.Clear()

        cmbDistributionMethod.Items.Add("Direct Donation")
        cmbDistributionMethod.Items.Add("Community Distribution")
        cmbDistributionMethod.Items.Add("Barter Exchange")
        cmbDistributionMethod.Items.Add("Charity Distribution")

        cmbDistributionMethod.SelectedIndex = -1

    End Sub

    Private Sub LoadDistributionData()

        Try
            Using conn As SQLiteConnection =
                DatabaseHelper.GetConnection()

                conn.Open()

                Dim query As String =
                    "SELECT " &
                    "d.DistributionID, " &
                    "s.ProduceName, " &
                    "r.RecipientName, " &
                    "d.DistributionQuantity, " &
                    "d.DistributionDate, " &
                    "d.DistributionMethod " &
                    "FROM Distribution d " &
                    "INNER JOIN SurplusProduce s " &
                    "ON d.ProduceID = s.ProduceID " &
                    "INNER JOIN Recipients r " &
                    "ON d.RecipientID = r.RecipientID " &
                    "ORDER BY d.DistributionID DESC"

                Using adapter As New SQLiteDataAdapter(
                    query, conn)

                    Dim table As New DataTable()
                    adapter.Fill(table)

                    dgvDistribution.DataSource = table

                End Using
            End Using

        Catch ex As Exception

            MessageBox.Show(
                "Error loading distribution records: " &
                ex.Message)

        End Try

    End Sub

    Private Sub ApplyLanguage()

        If LanguageHelper.CurrentLanguage = "English" Then

            Me.Text = "Distribution"

            Label1.Text = "Produce Distribution"
            Label2.Text = "Select Produce:"
            Label3.Text = "Available Quantity:"
            Label4.Text = "Select Recipient:"
            Label5.Text = "Distribution Quantity:"
            Label6.Text = "Distribution Date:"
            Label7.Text = "Distribution Method:"

            btnDistribute.Text = "&DISTRIBUTE"
            btnClear.Text = "&CLEAR"

        ElseIf LanguageHelper.CurrentLanguage = "Itaukei" Then

            Me.Text = "Veisoliyaki ni Kakana"

            Label1.Text = "VEISOLIYAKI NI KAKANA"
            Label2.Text = "Digitaka na Kakana:"
            Label3.Text = "Levu ni Kakana:"
            Label4.Text = "Digitaka na Ciqoma:"
            Label5.Text = "Levu ni Veisoliyaki:"
            Label6.Text = "Siga ni Veisoliyaki:"
            Label7.Text = "Sala ni Veisoliyaki:"

            btnDistribute.Text = "SOLIA"
            btnClear.Text = "VAKASAVASAVATAKA"

        ElseIf LanguageHelper.CurrentLanguage = "Fiji Hindi" Then

            Me.Text = "Khana Baatna"

            Label1.Text = "KHANA BAATNA"
            Label2.Text = "Khana Chuniye:"
            Label3.Text = "Khana ke Quantity:"
            Label4.Text = "Lene Wala Chuniye:"
            Label5.Text = "Baatne ke Quantity:"
            Label6.Text = "Baatne ke Date:"
            Label7.Text = "Baatne ka Tarika:"

            btnDistribute.Text = "BAANTE"
            btnClear.Text = "SAaf KARE"

        End If

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class