Imports System.Data.SQLite

Public Class frmSurplus

    Private Sub ClearFields()

        txtProduceName.Clear()
        txtQuantity.Clear()
        cmbDonor.SelectedIndex = -1
        cmbProduceSource.SelectedIndex = -1
        txtCommunity.Clear()
        dtpExpiryDate.Value = DateTime.Now

    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtProduceName.Text.Trim() = "" OrElse
       txtQuantity.Text.Trim() = "" OrElse
       cmbDonor.Text.Trim() = "" OrElse
       cmbProduceSource.Text.Trim() = "" OrElse
       txtCommunity.Text.Trim() = "" Then

            MessageBox.Show("Please complete all fields.")
            Return
        End If

        Dim quantity As Double

        If Not Double.TryParse(txtQuantity.Text, quantity) OrElse quantity <= 0 Then
            MessageBox.Show("Please enter a valid quantity.")
            Return
        End If

        Try
            Using conn As SQLiteConnection = GetConnection()

                conn.Open()

                Dim query As String =
                "INSERT INTO SurplusProduce " &
                "(ProduceName, Quantity, Donor, ExpiryDate, ProduceSource, Community) " &
                "VALUES (@ProduceName, @Quantity, @Donor, @ExpiryDate, @ProduceSource, @Community)"

                Using cmd As New SQLiteCommand(query, conn)

                    cmd.Parameters.AddWithValue("@ProduceName", txtProduceName.Text.Trim())
                    cmd.Parameters.AddWithValue("@Quantity", quantity)
                    cmd.Parameters.AddWithValue("@Donor", cmbDonor.Text.Trim())
                    cmd.Parameters.AddWithValue("@ExpiryDate", dtpExpiryDate.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@ProduceSource", cmbProduceSource.Text.Trim())
                    cmd.Parameters.AddWithValue("@Community", txtCommunity.Text.Trim())

                    cmd.ExecuteNonQuery()

                End Using

            End Using

            MessageBox.Show("Produce added successfully!")

            ClearFields()
            LoadSurplusData()

        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message)

        End Try

    End Sub

    Private Sub LoadSurplusData()

        Try
            Using conn As SQLiteConnection = GetConnection()

                conn.Open()

                Dim query As String =
                    "SELECT ProduceID, ProduceName, Quantity, Donor, " &
                    "ExpiryDate, ProduceSource, Community " &
                    "FROM SurplusProduce"

                Using adapter As New SQLiteDataAdapter(query, conn)

                    Dim table As New DataTable()
                    adapter.Fill(table)

                    dgvSurplus.DataSource = table

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show("Error loading records: " & ex.Message)

        End Try

    End Sub

    Private Sub Surplus_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadSurplusData()

    End Sub

    Private selectedProduceID As Integer = 0

    Private Sub dgvSurplus_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSurplus.CellClick

        If e.RowIndex < 0 Then Return

        Dim row As DataGridViewRow = dgvSurplus.Rows(e.RowIndex)

        If row.Cells("ProduceID").Value Is Nothing Then Return

        selectedProduceID = Convert.ToInt32(row.Cells("ProduceID").Value)

        txtProduceName.Text = row.Cells("ProduceName").Value.ToString()
        txtQuantity.Text = row.Cells("Quantity").Value.ToString()
        cmbDonor.Text = row.Cells("Donor").Value.ToString()
        cmbProduceSource.Text = row.Cells("ProduceSource").Value.ToString()
        txtCommunity.Text = row.Cells("Community").Value.ToString()

        dtpExpiryDate.Value = DateTime.Parse(row.Cells("ExpiryDate").Value.ToString())

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If selectedProduceID = 0 Then
            MessageBox.Show("Please select a record to update.")
            Return
        End If

        Dim quantity As Double

        If Not Double.TryParse(txtQuantity.Text, quantity) OrElse quantity <= 0 Then
            MessageBox.Show("Please enter a valid quantity.")
            Return
        End If

        Try
            Using conn As SQLiteConnection = GetConnection()

                conn.Open()

                Dim query As String =
                    "UPDATE SurplusProduce SET " &
                    "ProduceName = @ProduceName, " &
                    "Quantity = @Quantity, " &
                    "Donor = @Donor, " &
                    "ExpiryDate = @ExpiryDate, " &
                    "ProduceSource = @ProduceSource, " &
                    "Community = @Community " &
                    "WHERE ProduceID = @ProduceID"

                Using cmd As New SQLiteCommand(query, conn)

                    cmd.Parameters.AddWithValue("@ProduceName", txtProduceName.Text.Trim())
                    cmd.Parameters.AddWithValue("@Quantity", quantity)
                    cmd.Parameters.AddWithValue("@Donor", cmbDonor.Text.Trim())
                    cmd.Parameters.AddWithValue("@ExpiryDate", dtpExpiryDate.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@ProduceSource", cmbProduceSource.Text.Trim())
                    cmd.Parameters.AddWithValue("@Community", txtCommunity.Text.Trim())
                    cmd.Parameters.AddWithValue("@ProduceID", selectedProduceID)

                    cmd.ExecuteNonQuery()

                End Using

            End Using

            MessageBox.Show("Record updated successfully!")

            ClearFields()
            selectedProduceID = 0
            LoadSurplusData()

        Catch ex As Exception

            MessageBox.Show("Update error: " & ex.Message)

        End Try

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If selectedProduceID = 0 Then
            MessageBox.Show("Please select a produce record to delete.")
            Return
        End If

        Dim result As DialogResult = MessageBox.Show(
        "Are you sure you want to delete this produce record?",
        "Confirm Delete",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning)

        If result = DialogResult.No Then
            Return
        End If

        Try
            Using conn As SQLiteConnection = DatabaseHelper.GetConnection()
                conn.Open()

                Dim query As String =
                "DELETE FROM SurplusProduce WHERE ProduceID = @id"

                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", selectedProduceID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Produce deleted successfully!")

            LoadSurplusData()
            ClearFields()
            selectedProduceID = 0

        Catch ex As Exception
            MessageBox.Show("Error deleting produce: " & ex.Message)
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()

        selectedProduceID = 0
    End Sub
End Class