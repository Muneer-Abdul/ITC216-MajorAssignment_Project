<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlAvailable = New System.Windows.Forms.Panel()
        Me.lblAvailableValue = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlDistributed = New System.Windows.Forms.Panel()
        Me.lblDistributedValue = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlRecipients = New System.Windows.Forms.Panel()
        Me.lblRecipientsValue = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbReportFilter = New System.Windows.Forms.ComboBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.dgvReport = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbDateFilter = New System.Windows.Forms.ComboBox()
        Me.pnlAvailable.SuspendLayout()
        Me.pnlDistributed.SuspendLayout()
        Me.pnlRecipients.SuspendLayout()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(1012, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "System Report"
        '
        'pnlAvailable
        '
        Me.pnlAvailable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAvailable.Controls.Add(Me.lblAvailableValue)
        Me.pnlAvailable.Controls.Add(Me.Label2)
        Me.pnlAvailable.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlAvailable.Location = New System.Drawing.Point(492, 158)
        Me.pnlAvailable.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlAvailable.Name = "pnlAvailable"
        Me.pnlAvailable.Size = New System.Drawing.Size(325, 160)
        Me.pnlAvailable.TabIndex = 1
        '
        'lblAvailableValue
        '
        Me.lblAvailableValue.AutoSize = True
        Me.lblAvailableValue.Location = New System.Drawing.Point(140, 78)
        Me.lblAvailableValue.Name = "lblAvailableValue"
        Me.lblAvailableValue.Size = New System.Drawing.Size(53, 28)
        Me.lblAvailableValue.TabIndex = 8
        Me.lblAvailableValue.Text = "0 KG"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(76, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 38)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Available Produce"
        '
        'pnlDistributed
        '
        Me.pnlDistributed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDistributed.Controls.Add(Me.lblDistributedValue)
        Me.pnlDistributed.Controls.Add(Me.Label3)
        Me.pnlDistributed.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlDistributed.Location = New System.Drawing.Point(27, 158)
        Me.pnlDistributed.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlDistributed.Name = "pnlDistributed"
        Me.pnlDistributed.Size = New System.Drawing.Size(325, 160)
        Me.pnlDistributed.TabIndex = 2
        '
        'lblDistributedValue
        '
        Me.lblDistributedValue.AutoSize = True
        Me.lblDistributedValue.Location = New System.Drawing.Point(136, 78)
        Me.lblDistributedValue.Name = "lblDistributedValue"
        Me.lblDistributedValue.Size = New System.Drawing.Size(53, 28)
        Me.lblDistributedValue.TabIndex = 9
        Me.lblDistributedValue.Text = "0 KG"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(68, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(254, 38)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Distributed Produce"
        '
        'pnlRecipients
        '
        Me.pnlRecipients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlRecipients.Controls.Add(Me.lblRecipientsValue)
        Me.pnlRecipients.Controls.Add(Me.Label4)
        Me.pnlRecipients.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlRecipients.Location = New System.Drawing.Point(940, 158)
        Me.pnlRecipients.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlRecipients.Name = "pnlRecipients"
        Me.pnlRecipients.Size = New System.Drawing.Size(325, 160)
        Me.pnlRecipients.TabIndex = 3
        '
        'lblRecipientsValue
        '
        Me.lblRecipientsValue.Location = New System.Drawing.Point(163, 78)
        Me.lblRecipientsValue.Name = "lblRecipientsValue"
        Me.lblRecipientsValue.Size = New System.Drawing.Size(143, 38)
        Me.lblRecipientsValue.TabIndex = 7
        Me.lblRecipientsValue.Text = "0"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(71, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(216, 38)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Total Recipients"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(687, 392)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Report Filter:"
        '
        'cmbReportFilter
        '
        Me.cmbReportFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReportFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReportFilter.FormattingEnabled = True
        Me.cmbReportFilter.Location = New System.Drawing.Point(385, 384)
        Me.cmbReportFilter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbReportFilter.Name = "cmbReportFilter"
        Me.cmbReportFilter.Size = New System.Drawing.Size(235, 33)
        Me.cmbReportFilter.TabIndex = 5
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(331, 474)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(206, 61)
        Me.btnRefresh.TabIndex = 6
        Me.btnRefresh.Text = "&Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnExport.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.ForeColor = System.Drawing.Color.White
        Me.btnExport.Location = New System.Drawing.Point(765, 474)
        Me.btnExport.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(206, 61)
        Me.btnExport.TabIndex = 7
        Me.btnExport.Text = "&Export Report"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'dgvReport
        '
        Me.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReport.Location = New System.Drawing.Point(28, 579)
        Me.dgvReport.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvReport.Name = "dgvReport"
        Me.dgvReport.RowHeadersWidth = 51
        Me.dgvReport.RowTemplate.Height = 24
        Me.dgvReport.Size = New System.Drawing.Size(1238, 335)
        Me.dgvReport.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(227, 392)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 25)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Date Filter:"
        '
        'cmbDateFilter
        '
        Me.cmbDateFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDateFilter.FormattingEnabled = True
        Me.cmbDateFilter.Location = New System.Drawing.Point(891, 389)
        Me.cmbDateFilter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbDateFilter.Name = "cmbDateFilter"
        Me.cmbDateFilter.Size = New System.Drawing.Size(235, 33)
        Me.cmbDateFilter.TabIndex = 10
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1292, 954)
        Me.Controls.Add(Me.cmbDateFilter)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgvReport)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.cmbReportFilter)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.pnlRecipients)
        Me.Controls.Add(Me.pnlDistributed)
        Me.Controls.Add(Me.pnlAvailable)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Report"
        Me.Text = " "
        Me.pnlAvailable.ResumeLayout(False)
        Me.pnlAvailable.PerformLayout()
        Me.pnlDistributed.ResumeLayout(False)
        Me.pnlDistributed.PerformLayout()
        Me.pnlRecipients.ResumeLayout(False)
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents pnlAvailable As Panel
    Friend WithEvents pnlDistributed As Panel
    Friend WithEvents pnlRecipients As Panel
    Friend WithEvents lblAvailableValue As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDistributedValue As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblRecipientsValue As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbReportFilter As ComboBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents dgvReport As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbDateFilter As ComboBox
End Class
