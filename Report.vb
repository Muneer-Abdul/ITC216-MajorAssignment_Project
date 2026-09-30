Imports System.Data.SQLite
Imports System.IO

Public Class Report

    Private loggedInRole As String

    Public Sub New(role As String)

        InitializeComponent()

        loggedInRole = role

    End Sub

    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not loggedInRole.Equals("Admin", StringComparison.OrdinalIgnoreCase) Then

            MessageBox.Show(
            "Access denied. Only administrators can access Reports.",
            "Access Denied",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        )

            Me.Close()
            Return

        End If

        LoadReportStatistics()
        LoadReportData()
        LoadReportFilters()
        LoadDateFilters()

    End Sub

    Private Sub LoadReportStatistics()

        Try
            Using conn As SQLiteConnection = DatabaseHelper.GetConnection()

                conn.Open()

                'Total available produce
                Dim availableQuery As String =
                    "SELECT IFNULL(SUM(Quantity), 0) FROM SurplusProduce"

                Using cmd As New SQLiteCommand(availableQuery, conn)
                    Dim availableQuantity As Object = cmd.ExecuteScalar()
                    lblAvailableValue.Text = availableQuantity.ToString() & " kg"
                End Using

                'Total distributed produce
                Dim distributedQuery As String =
                    "SELECT IFNULL(SUM(DistributionQuantity), 0) FROM Distribution"

                Using cmd As New SQLiteCommand(distributedQuery, conn)
                    Dim distributedQuantity As Object = cmd.ExecuteScalar()
                    lblDistributedValue.Text = distributedQuantity.ToString() & " kg"
                End Using

                'Total registered recipients
                Dim recipientsQuery As String =
                    "SELECT COUNT(*) FROM Recipients"

                Using cmd As New SQLiteCommand(recipientsQuery, conn)
                    Dim recipientCount As Object = cmd.ExecuteScalar()
                    lblRecipientsValue.Text = recipientCount.ToString()
                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show("Error loading report statistics: " & ex.Message)

        End Try

    End Sub

    Private Sub LoadReportData()

        Try
            Using conn As SQLiteConnection = DatabaseHelper.GetConnection()

                conn.Open()

                Dim query As String =
                "SELECT d.DistributionID, " &
                "s.ProduceName, " &
                "r.RecipientName, " &
                "d.DistributionQuantity, " &
                "d.DistributionDate, " &
                "d.DistributionMethod " &
                "FROM Distribution d " &
                "INNER JOIN SurplusProduce s ON d.ProduceID = s.ProduceID " &
                "INNER JOIN Recipients r ON d.RecipientID = r.RecipientID "

                Dim conditions As New List(Of String)

                'Distribution method filter
                If cmbReportFilter.SelectedIndex > 0 Then
                    conditions.Add("d.DistributionMethod = @method")
                End If

                'Date filter
                If cmbDateFilter.SelectedIndex = 1 Then
                    conditions.Add("DATE(d.DistributionDate) = DATE('now', 'localtime')")

                ElseIf cmbDateFilter.SelectedIndex = 2 Then
                    conditions.Add(
                    "strftime('%Y-%m', d.DistributionDate) = strftime('%Y-%m', 'now', 'localtime')"
                )

                ElseIf cmbDateFilter.SelectedIndex = 3 Then
                    conditions.Add(
                    "strftime('%Y', d.DistributionDate) = strftime('%Y', 'now', 'localtime')"
                )
                End If

                'Add conditions to query
                If conditions.Count > 0 Then
                    query &= "WHERE " & String.Join(" AND ", conditions)
                End If

                query &= " ORDER BY d.DistributionID DESC"

                Using cmd As New SQLiteCommand(query, conn)

                    'Method parameter
                    If cmbReportFilter.SelectedIndex > 0 Then
                        cmd.Parameters.AddWithValue(
                        "@method",
                        cmbReportFilter.SelectedItem.ToString()
                    )
                    End If

                    Using adapter As New SQLiteDataAdapter(cmd)

                        Dim table As New DataTable()
                        adapter.Fill(table)

                        dgvReport.DataSource = table

                        'Formatting
                        dgvReport.AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.Fill

                        dgvReport.ReadOnly = True

                        dgvReport.AllowUserToAddRows = False

                        dgvReport.SelectionMode =
                        DataGridViewSelectionMode.FullRowSelect

                        dgvReport.EnableHeadersVisualStyles = False

                        dgvReport.ColumnHeadersDefaultCellStyle.Font =
                        New Font("Segoe UI", 10, FontStyle.Bold)

                        dgvReport.ColumnHeadersHeight = 35

                        dgvReport.RowTemplate.Height = 30

                        dgvReport.Columns("DistributionQuantity").DefaultCellStyle.Format = "0.00"

                        dgvReport.Columns("DistributionDate").MinimumWidth = 130

                        'Column headings
                        dgvReport.Columns("DistributionID").HeaderText = "Distribution ID"
                        dgvReport.Columns("ProduceName").HeaderText = "Produce Name"
                        dgvReport.Columns("RecipientName").HeaderText = "Recipient Name"
                        dgvReport.Columns("DistributionQuantity").HeaderText = "Quantity (kg)"
                        dgvReport.Columns("DistributionDate").HeaderText = "Distribution Date"
                        dgvReport.Columns("DistributionMethod").HeaderText = "Distribution Method"

                    End Using

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show("Error loading report data: " & ex.Message)

        End Try

    End Sub

    Private Sub LoadReportFilters()

        cmbReportFilter.Items.Clear()

        cmbReportFilter.Items.Add("All Records")
        cmbReportFilter.Items.Add("Direct Donation")
        cmbReportFilter.Items.Add("Community Distribution")
        cmbReportFilter.Items.Add("Barter Exchange")
        cmbReportFilter.Items.Add("Charity Distribution")

        cmbReportFilter.SelectedIndex = 0

    End Sub

    Private Sub cmbReportFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbReportFilter.SelectedIndexChanged
        LoadReportData()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

        Try

            If dgvReport.Rows.Count = 0 Then

                MessageBox.Show("There are no records to export.")
                Return

            End If

            Dim saveDialog As New SaveFileDialog()

            saveDialog.Filter = "CSV Files (*.csv)|*.csv"
            saveDialog.Title = "Export Distribution Report"
            saveDialog.FileName = "VitiFoodLink_Report.csv"

            If saveDialog.ShowDialog() = DialogResult.OK Then

                Using writer As New StreamWriter(saveDialog.FileName)

                    'Export column headers
                    For i As Integer = 0 To dgvReport.Columns.Count - 1

                        writer.Write(dgvReport.Columns(i).HeaderText)

                        If i < dgvReport.Columns.Count - 1 Then
                            writer.Write(",")
                        End If

                    Next

                    writer.WriteLine()

                    'Export rows
                    For Each row As DataGridViewRow In dgvReport.Rows

                        If Not row.IsNewRow Then

                            For i As Integer = 0 To dgvReport.Columns.Count - 1

                                Dim value As String =
                                row.Cells(i).Value?.ToString()

                                value = value.Replace("""", """""")

                                writer.Write("""" & value & """")

                                If i < dgvReport.Columns.Count - 1 Then
                                    writer.Write(",")
                                End If

                            Next

                            writer.WriteLine()

                        End If

                    Next

                End Using

                MessageBox.Show(
                "Report exported successfully!",
                "Export Complete",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            End If

        Catch ex As Exception

            MessageBox.Show(
            "Error exporting report: " & ex.Message,
            "Export Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )

        End Try

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        LoadReportStatistics()
        LoadReportData()

        MessageBox.Show(
        "Report refreshed successfully!",
        "Refresh Complete",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information
    )

    End Sub

    Private Sub LoadDateFilters()

        cmbDateFilter.Items.Clear()

        cmbDateFilter.Items.Add("All Dates")
        cmbDateFilter.Items.Add("Today")
        cmbDateFilter.Items.Add("This Month")
        cmbDateFilter.Items.Add("This Year")

        cmbDateFilter.SelectedIndex = 0

    End Sub

    Private Sub cmbDateFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDateFilter.SelectedIndexChanged
        LoadReportData()

    End Sub
End Class