<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecipients
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRecipientName = New System.Windows.Forms.TextBox()
        Me.txtOrganisation = New System.Windows.Forms.TextBox()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.txtCommunity = New System.Windows.Forms.TextBox()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbRecipientType = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.dgvRecipients = New System.Windows.Forms.DataGridView()
        CType(Me.dgvRecipients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(451, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Recipients Management"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Recipient Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Organisation:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Contact Number:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 255)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Community:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(52, 303)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Location:"
        '
        'txtRecipientName
        '
        Me.txtRecipientName.Location = New System.Drawing.Point(165, 128)
        Me.txtRecipientName.Name = "txtRecipientName"
        Me.txtRecipientName.Size = New System.Drawing.Size(124, 22)
        Me.txtRecipientName.TabIndex = 6
        '
        'txtOrganisation
        '
        Me.txtOrganisation.Location = New System.Drawing.Point(165, 166)
        Me.txtOrganisation.Name = "txtOrganisation"
        Me.txtOrganisation.Size = New System.Drawing.Size(124, 22)
        Me.txtOrganisation.TabIndex = 7
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Location = New System.Drawing.Point(165, 212)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(124, 22)
        Me.txtContactNumber.TabIndex = 8
        '
        'txtCommunity
        '
        Me.txtCommunity.Location = New System.Drawing.Point(165, 264)
        Me.txtCommunity.Name = "txtCommunity"
        Me.txtCommunity.Size = New System.Drawing.Size(124, 22)
        Me.txtCommunity.TabIndex = 9
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(165, 303)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(124, 22)
        Me.txtLocation.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(380, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Recipient Type:"
        '
        'cmbRecipientType
        '
        Me.cmbRecipientType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRecipientType.FormattingEnabled = True
        Me.cmbRecipientType.Items.AddRange(New Object() {"Community Organisation", "Individual", "School", "Charity", "Other"})
        Me.cmbRecipientType.Location = New System.Drawing.Point(506, 130)
        Me.cmbRecipientType.Name = "cmbRecipientType"
        Me.cmbRecipientType.Size = New System.Drawing.Size(131, 24)
        Me.cmbRecipientType.TabIndex = 13
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(55, 499)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(118, 51)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(236, 499)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(118, 51)
        Me.btnUpdate.TabIndex = 15
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(441, 499)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(118, 51)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(614, 499)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(118, 51)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'dgvRecipients
        '
        Me.dgvRecipients.AllowUserToAddRows = False
        Me.dgvRecipients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRecipients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecipients.Location = New System.Drawing.Point(352, 185)
        Me.dgvRecipients.Name = "dgvRecipients"
        Me.dgvRecipients.ReadOnly = True
        Me.dgvRecipients.RowHeadersWidth = 51
        Me.dgvRecipients.RowTemplate.Height = 24
        Me.dgvRecipients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRecipients.Size = New System.Drawing.Size(515, 213)
        Me.dgvRecipients.TabIndex = 18
        '
        'frmRecipients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 581)
        Me.Controls.Add(Me.dgvRecipients)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cmbRecipientType)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.txtCommunity)
        Me.Controls.Add(Me.txtContactNumber)
        Me.Controls.Add(Me.txtOrganisation)
        Me.Controls.Add(Me.txtRecipientName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRecipients"
        Me.Text = "Recipients Management"
        CType(Me.dgvRecipients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtRecipientName As TextBox
    Friend WithEvents txtOrganisation As TextBox
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents txtCommunity As TextBox
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbRecipientType As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents dgvRecipients As DataGridView
End Class
