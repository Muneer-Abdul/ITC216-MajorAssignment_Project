Imports System.Data.SQLite

Public Class frmRecipients

    Dim selectedRecipientID As Integer = 0
    Private Sub LoadRecipients()

        Try

            Using conn As SQLiteConnection = DatabaseHelper.GetConnection()

                conn.Open()

                Dim query As String = "SELECT * FROM Recipients"

                Using adapter As New SQLiteDataAdapter(query, conn)

                    Dim table As New DataTable()

                    adapter.Fill(table)

                    dgvRecipients.DataSource = table

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show("Error loading recipients: " & ex.Message)

        End Try

    End Sub

    Private Sub frmRecipients_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadRecipients()

    End Sub

    Private Sub ClearFields()

        txtRecipientName.Clear()
        txtOrganisation.Clear()
        txtContactNumber.Clear()
        txtCommunity.Clear()
        txtLocation.Clear()
        cmbRecipientType.SelectedIndex = -1

    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtRecipientName.Text = "" OrElse
       txtOrganisation.Text = "" OrElse
       txtContactNumber.Text = "" OrElse
       txtCommunity.Text = "" OrElse
       txtLocation.Text = "" OrElse
       cmbRecipientType.SelectedIndex = -1 Then

            MessageBox.Show("Please complete all fields.")
            Exit Sub

        End If

        Try

            Using conn As SQLiteConnection = DatabaseHelper.GetConnection()

                conn.Open()

                Dim query As String =
                "INSERT INTO Recipients " &
                "(RecipientName, Organisation, ContactNumber, Community, Location, RecipientType) " &
                "VALUES (@name, @organisation, @contact, @community, @location, @type)"

                Using cmd As New SQLiteCommand(query, conn)

                    cmd.Parameters.AddWithValue("@name", txtRecipientName.Text.Trim())
                    cmd.Parameters.AddWithValue("@organisation", txtOrganisation.Text.Trim())
                    cmd.Parameters.AddWithValue("@contact", txtContactNumber.Text.Trim())
                    cmd.Parameters.AddWithValue("@community", txtCommunity.Text.Trim())
                    cmd.Parameters.AddWithValue("@location", txtLocation.Text.Trim())
                    cmd.Parameters.AddWithValue("@type", cmbRecipientType.Text)

                    cmd.ExecuteNonQuery()

                End Using

            End Using

            MessageBox.Show("Recipient added successfully!")

            LoadRecipients()

            ClearFields()

        Catch ex As Exception

            MessageBox.Show("Error adding recipient: " & ex.Message)

        End Try

    End Sub

    Private Sub dgvRecipients_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRecipients.CellContentClick

        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow = dgvRecipients.Rows(e.RowIndex)

            selectedRecipientID = Convert.ToInt32(row.Cells("RecipientID").Value)

            txtRecipientName.Text = row.Cells("RecipientName").Value.ToString()
            txtOrganisation.Text = row.Cells("Organisation").Value.ToString()
            txtContactNumber.Text = row.Cells("ContactNumber").Value.ToString()
            txtCommunity.Text = row.Cells("Community").Value.ToString()
            txtLocation.Text = row.Cells("Location").Value.ToString()
            cmbRecipientType.Text = row.Cells("RecipientType").Value.ToString()

        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If selectedRecipientID = 0 Then
            MessageBox.Show("Please select a recipient to update.")
            Return
        End If

        If txtRecipientName.Text.Trim() = "" OrElse
       txtOrganisation.Text.Trim() = "" OrElse
       txtContactNumber.Text.Trim() = "" OrElse
       txtCommunity.Text.Trim() = "" OrElse
       txtLocation.Text.Trim() = "" OrElse
       cmbRecipientType.SelectedIndex = -1 Then

            MessageBox.Show("Please complete all fields.")
            Return
        End If

        Try
            Using conn As SQLiteConnection = DatabaseHelper.GetConnection()
                conn.Open()

                Dim query As String =
                "UPDATE Recipients SET " &
                "RecipientName = @name, " &
                "Organisation = @organisation, " &
                "ContactNumber = @contact, " &
                "Community = @community, " &
                "Location = @location, " &
                "RecipientType = @type " &
                "WHERE RecipientID = @id"

                Using cmd As New SQLiteCommand(query, conn)

                    cmd.Parameters.AddWithValue("@name", txtRecipientName.Text.Trim())
                    cmd.Parameters.AddWithValue("@organisation", txtOrganisation.Text.Trim())
                    cmd.Parameters.AddWithValue("@contact", txtContactNumber.Text.Trim())
                    cmd.Parameters.AddWithValue("@community", txtCommunity.Text.Trim())
                    cmd.Parameters.AddWithValue("@location", txtLocation.Text.Trim())
                    cmd.Parameters.AddWithValue("@type", cmbRecipientType.Text)
                    cmd.Parameters.AddWithValue("@id", selectedRecipientID)

                    cmd.ExecuteNonQuery()

                End Using
            End Using

            MessageBox.Show("Recipient updated successfully!")

            LoadRecipients()
            ClearFields()
            selectedRecipientID = 0

        Catch ex As Exception
            MessageBox.Show("Error updating recipient: " & ex.Message)
        End Try

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If selectedRecipientID = 0 Then
            MessageBox.Show("Please select a recipient to delete.")
            Return
        End If

        Dim result As DialogResult = MessageBox.Show(
        "Are you sure you want to delete this recipient?",
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
                "DELETE FROM Recipients WHERE RecipientID = @id"

                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", selectedRecipientID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Recipient deleted successfully!")

            LoadRecipients()
            ClearFields()
            selectedRecipientID = 0

        Catch ex As Exception
            MessageBox.Show("Error deleting recipient: " & ex.Message)
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ClearFields()

        selectedRecipientID = 0
    End Sub
End Class