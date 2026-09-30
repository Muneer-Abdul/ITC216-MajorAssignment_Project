Imports System.Data.SQLite

Public Class frmViewBarter

    Private Sub frmViewBarter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadBarterData()

    End Sub

    Private Sub LoadBarterData()

        Try

            Using conn As SQLiteConnection = GetConnection()

                conn.Open()

                Dim query As String =
                    "SELECT BarterID, OfferedProduce, OfferedQuantity, " &
                    "RequestedProduce, RequestedQuantity, Community, BarterDate, Status " &
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

            ' Make the grid easier to read
            dgvBarter.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill

            dgvBarter.ReadOnly = True
            dgvBarter.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect

            dgvBarter.MultiSelect = False

        Catch ex As Exception

            MessageBox.Show(
                "Error loading barter records: " & ex.Message,
                "Barter",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    Private Sub btnConfirmBarter_Click(sender As Object, e As EventArgs) Handles btnConfirmBarter.Click
        If dgvBarter.SelectedRows.Count = 0 Then

            MessageBox.Show(
            "Please select a barter from the list.",
            "Confirm Barter",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )

            Return

        End If

        Dim selectedRow As DataGridViewRow =
        dgvBarter.SelectedRows(0)

        Dim barterID As Integer =
        Convert.ToInt32(selectedRow.Cells("BarterID").Value)

        Dim currentStatus As String =
        selectedRow.Cells("Status").Value.ToString()

        If currentStatus.Equals("Confirmed",
                            StringComparison.OrdinalIgnoreCase) Then

            MessageBox.Show(
            "This barter has already been confirmed.",
            "Confirm Barter",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )

            Return

        End If

        Dim result As DialogResult =
        MessageBox.Show(
            "Are you sure you want to confirm this barter?",
            "Confirm Barter",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result <> DialogResult.Yes Then
            Return
        End If

        Try

            Using conn As SQLiteConnection = GetConnection()

                conn.Open()

                Dim query As String =
                "UPDATE Barter " &
                "SET Status = 'Confirmed' " &
                "WHERE BarterID = @BarterID"

                Using cmd As New SQLiteCommand(query, conn)

                    cmd.Parameters.AddWithValue("@BarterID", barterID)

                    cmd.ExecuteNonQuery()

                End Using

            End Using

            MessageBox.Show(
            "Barter confirmed successfully.",
            "Barter Confirmed",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )

            LoadBarterData()

        Catch ex As Exception

            MessageBox.Show(
            "Error confirming barter: " & ex.Message,
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )

        End Try

    End Sub
End Class