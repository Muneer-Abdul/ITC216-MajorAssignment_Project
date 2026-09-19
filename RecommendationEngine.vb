Imports System.Data.SQLite
Imports Microsoft.VisualBasic.Logging

Public Class frmRecommendationEngine
    Private Sub LoadProduce()

        Try
            Using conn As SQLiteConnection = DatabaseHelper.GetConnection()
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

    Private Sub frmRecommendationEngine_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadProduce()
        LoadRecipientTypes()

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

    Private Sub cmbProduce_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProduce.SelectedIndexChanged

        If cmbProduce.SelectedIndex = -1 OrElse
       cmbProduce.SelectedValue Is Nothing Then

            txtQuantity.Clear()
            Return
        End If

        Try
            Using conn As SQLiteConnection = DatabaseHelper.GetConnection()
                conn.Open()

                Dim query As String =
                "SELECT Quantity FROM SurplusProduce " &
                "WHERE ProduceID = @id"

                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", cmbProduce.SelectedValue)

                    Dim quantity As Object = cmd.ExecuteScalar()

                    If quantity IsNot Nothing Then
                        txtQuantity.Text = quantity.ToString()
                    End If

                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading quantity: " & ex.Message)
        End Try

    End Sub

    Private Sub btnRecommend_Click(sender As Object, e As EventArgs) Handles btnRecommend.Click

        If cmbProduce.SelectedIndex = -1 Then
            MessageBox.Show("Please select a produce item.")
            Return
        End If

        If cmbRecipientType.SelectedIndex = -1 Then
            MessageBox.Show("Please select a recipient type.")
            Return
        End If

        If txtCommunity.Text.Trim() = "" Then
            MessageBox.Show("Please enter a community.")
            Return
        End If

        Try
            Using conn As SQLiteConnection =
            DatabaseHelper.GetConnection()

                conn.Open()

                Dim query As String =
                "SELECT RecipientName, Organisation, " &
                "Community, Location, RecipientType " &
                "FROM Recipients"

                Using cmd As New SQLiteCommand(query, conn)

                    Using reader As SQLiteDataReader =
                    cmd.ExecuteReader()

                        Dim bestRecipient As String = ""
                        Dim bestScore As Integer = 0
                        Dim bestReason As String = ""

                        While reader.Read()

                            Dim score As Integer = 0
                            Dim reasons As New List(Of String)

                            Dim recipientType As String =
                            reader("RecipientType").ToString()

                            Dim community As String =
                            reader("Community").ToString()

                            Dim selectedType As String =
                            cmbRecipientType.Text.Trim()

                            Dim selectedCommunity As String =
                            txtCommunity.Text.Trim()

                            'Recipient Type Match: 40 points
                            If String.Equals(
                            recipientType,
                            selectedType,
                            StringComparison.OrdinalIgnoreCase) Then

                                score += 40
                                reasons.Add("Recipient type matches")

                            End If

                            'Exact Community Match: 60 points
                            If String.Equals(
                            community,
                            selectedCommunity,
                            StringComparison.OrdinalIgnoreCase) Then

                                score += 60
                                reasons.Add("Community matches exactly")

                            End If

                            'Save the highest-scoring recipient
                            If score > bestScore Then

                                bestScore = score

                                bestRecipient =
                                reader("RecipientName").ToString()

                                bestReason =
                                String.Join(" and ", reasons)

                            End If

                        End While

                        If bestScore > 0 Then

                            txtRecommendedRecipient.Text =
                            bestRecipient

                            txtScore.Text =
                            bestScore.ToString() & "%"

                            If bestScore >= 80 Then
                                txtPriority.Text = "High"

                            ElseIf bestScore >= 50 Then
                                txtPriority.Text = "Medium"

                            Else
                                txtPriority.Text = "Low"

                            End If

                            txtReason.Text =
                            bestReason

                        Else

                            MessageBox.Show(
                            "No suitable recipient found.")

                            txtRecommendedRecipient.Clear()
                            txtScore.Clear()
                            txtPriority.Clear()
                            txtReason.Clear()

                        End If

                    End Using
                End Using
            End Using

        Catch ex As Exception

            MessageBox.Show(
            "Error finding recommendation: " &
            ex.Message)

        End Try
        'Matching recipient type And community → 100%, High
        'Matching community only → 60%, Medium
        'Matching recipient type only → 40%, Low
        'No matching criteria → No suitable recipient found
    End Sub
End Class