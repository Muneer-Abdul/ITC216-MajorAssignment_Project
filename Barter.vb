Imports System.Data.SQLite

Public Class frmBarter

    Private Sub frmBarter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBarterData()
    End Sub

    Private Sub btnAddBarter_Click(sender As Object, e As EventArgs) Handles btnAddBarter.Click

        'Validate input
        If txtName.Text.Trim() = "" OrElse
           txtNumber.Text.Trim() = "" OrElse
           txtOfferedProduce.Text.Trim() = "" OrElse
           txtOfferedQuantity.Text.Trim() = "" OrElse
           txtRequestedProduce.Text.Trim() = "" OrElse
           txtRequestedQuantity.Text.Trim() = "" OrElse
           txtCommunity.Text.Trim() = "" Then

            MessageBox.Show("Please fill in all fields.")
            Return

        End If

        Dim offeredQuantity As Double
        Dim requestedQuantity As Double

        If Not Double.TryParse(
            txtOfferedQuantity.Text,
            offeredQuantity
        ) OrElse offeredQuantity <= 0 Then

            MessageBox.Show("Enter a valid offered quantity.")
            Return

        End If

        If Not Double.TryParse(
            txtRequestedQuantity.Text,
            requestedQuantity
        ) OrElse requestedQuantity <= 0 Then

            MessageBox.Show("Enter a valid requested quantity.")
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
                "Barter offer added successfully!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            ClearFields()
            LoadBarterData()

        Catch ex As Exception

            MessageBox.Show(
                "Error adding barter offer: " & ex.Message
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
                "Error loading barter records: " & ex.Message
            )

        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

End Class