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
        Me.Label1.Location = New System.Drawing.Point(431, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SYSTEM REPORT   "
        '
        'pnlAvailable
        '
        Me.pnlAvailable.Controls.Add(Me.lblAvailableValue)
        Me.pnlAvailable.Controls.Add(Me.Label2)
        Me.pnlAvailable.Location = New System.Drawing.Point(179, 89)
        Me.pnlAvailable.Name = "pnlAvailable"
        Me.pnlAvailable.Size = New System.Drawing.Size(180, 128)
        Me.pnlAvailable.TabIndex = 1
        '
        'lblAvailableValue
        '
        Me.lblAvailableValue.AutoSize = True
        Me.lblAvailableValue.Location = New System.Drawing.Point(67, 72)
        Me.lblAvailableValue.Name = "lblAvailableValue"
        Me.lblAvailableValue.Size = New System.Drawing.Size(35, 16)
        Me.lblAvailableValue.TabIndex = 8
        Me.lblAvailableValue.Text = "0 KG"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Available Produce"
        '
        'pnlDistributed
        '
        Me.pnlDistributed.Controls.Add(Me.lblDistributedValue)
        Me.pnlDistributed.Controls.Add(Me.Label3)
        Me.pnlDistributed.Location = New System.Drawing.Point(441, 89)
        Me.pnlDistributed.Name = "pnlDistributed"
        Me.pnlDistributed.Size = New System.Drawing.Size(180, 128)
        Me.pnlDistributed.TabIndex = 2
        '
        'lblDistributedValue
        '
        Me.lblDistributedValue.AutoSize = True
        Me.lblDistributedValue.Location = New System.Drawing.Point(59, 88)
        Me.lblDistributedValue.Name = "lblDistributedValue"
        Me.lblDistributedValue.Size = New System.Drawing.Size(35, 16)
        Me.lblDistributedValue.TabIndex = 9
        Me.lblDistributedValue.Text = "0 KG"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Distributed Produce"
        '
        'pnlRecipients
        '
        Me.pnlRecipients.Controls.Add(Me.lblRecipientsValue)
        Me.pnlRecipients.Controls.Add(Me.Label4)
        Me.pnlRecipients.Location = New System.Drawing.Point(680, 89)
        Me.pnlRecipients.Name = "pnlRecipients"
        Me.pnlRecipients.Size = New System.Drawing.Size(180, 135)
        Me.pnlRecipients.TabIndex = 3
        '
        'lblRecipientsValue
        '
        Me.lblRecipientsValue.AutoSize = True
        Me.lblRecipientsValue.Location = New System.Drawing.Point(57, 88)
        Me.lblRecipientsValue.Name = "lblRecipientsValue"
        Me.lblRecipientsValue.Size = New System.Drawing.Size(14, 16)
        Me.lblRecipientsValue.TabIndex = 7
        Me.lblRecipientsValue.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Total Recipients"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(221, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Report Filter:"
        '
        'cmbReportFilter
        '
        Me.cmbReportFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReportFilter.FormattingEnabled = True
        Me.cmbReportFilter.Location = New System.Drawing.Point(337, 242)
        Me.cmbReportFilter.Name = "cmbReportFilter"
        Me.cmbReportFilter.Size = New System.Drawing.Size(121, 24)
        Me.cmbReportFilter.TabIndex = 5
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(534, 242)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(98, 30)
        Me.btnRefresh.TabIndex = 6
        Me.btnRefresh.Text = "REFRESH"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(445, 534)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(159, 35)
        Me.btnExport.TabIndex = 7
        Me.btnExport.Text = "EXPORT REPORT"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'dgvReport
        '
        Me.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReport.Location = New System.Drawing.Point(90, 302)
        Me.dgvReport.Name = "dgvReport"
        Me.dgvReport.RowHeadersWidth = 51
        Me.dgvReport.RowTemplate.Height = 24
        Me.dgvReport.Size = New System.Drawing.Size(871, 199)
        Me.dgvReport.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(679, 249)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Date Filter:"
        '
        'cmbDateFilter
        '
        Me.cmbDateFilter.FormattingEnabled = True
        Me.cmbDateFilter.Location = New System.Drawing.Point(774, 246)
        Me.cmbDateFilter.Name = "cmbDateFilter"
        Me.cmbDateFilter.Size = New System.Drawing.Size(99, 24)
        Me.cmbDateFilter.TabIndex = 10
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1088, 655)
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
        Me.Name = "Report"
        Me.Text = "Report"
        Me.pnlAvailable.ResumeLayout(False)
        Me.pnlAvailable.PerformLayout()
        Me.pnlDistributed.ResumeLayout(False)
        Me.pnlDistributed.PerformLayout()
        Me.pnlRecipients.ResumeLayout(False)
        Me.pnlRecipients.PerformLayout()
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
