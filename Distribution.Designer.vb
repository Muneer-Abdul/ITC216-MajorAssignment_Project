<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDistribution
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbProduce = New System.Windows.Forms.ComboBox()
        Me.cmbRecipient = New System.Windows.Forms.ComboBox()
        Me.cmbDistributionMethod = New System.Windows.Forms.ComboBox()
        Me.txtAvailableQuantity = New System.Windows.Forms.TextBox()
        Me.txtDistributionQuantity = New System.Windows.Forms.TextBox()
        Me.dtpDistributionDate = New System.Windows.Forms.DateTimePicker()
        Me.btnDistribute = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.dgvDistribution = New System.Windows.Forms.DataGridView()
        CType(Me.dgvDistribution, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(844, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Produce Distribution   "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(115, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Select Produce:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(115, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Available Quantity:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(115, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Select Recipient:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(602, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Distribution Quantity:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(602, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Distribution Date:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(602, 243)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Distribution Method:"
        '
        'cmbProduce
        '
        Me.cmbProduce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProduce.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProduce.FormattingEnabled = True
        Me.cmbProduce.Location = New System.Drawing.Point(280, 122)
        Me.cmbProduce.Name = "cmbProduce"
        Me.cmbProduce.Size = New System.Drawing.Size(272, 28)
        Me.cmbProduce.TabIndex = 0
        '
        'cmbRecipient
        '
        Me.cmbRecipient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRecipient.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRecipient.FormattingEnabled = True
        Me.cmbRecipient.Location = New System.Drawing.Point(280, 183)
        Me.cmbRecipient.Name = "cmbRecipient"
        Me.cmbRecipient.Size = New System.Drawing.Size(272, 28)
        Me.cmbRecipient.TabIndex = 1
        '
        'cmbDistributionMethod
        '
        Me.cmbDistributionMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDistributionMethod.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDistributionMethod.FormattingEnabled = True
        Me.cmbDistributionMethod.Location = New System.Drawing.Point(776, 237)
        Me.cmbDistributionMethod.Name = "cmbDistributionMethod"
        Me.cmbDistributionMethod.Size = New System.Drawing.Size(272, 28)
        Me.cmbDistributionMethod.TabIndex = 5
        '
        'txtAvailableQuantity
        '
        Me.txtAvailableQuantity.BackColor = System.Drawing.Color.White
        Me.txtAvailableQuantity.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvailableQuantity.Location = New System.Drawing.Point(280, 243)
        Me.txtAvailableQuantity.Name = "txtAvailableQuantity"
        Me.txtAvailableQuantity.ReadOnly = True
        Me.txtAvailableQuantity.Size = New System.Drawing.Size(272, 27)
        Me.txtAvailableQuantity.TabIndex = 2
        '
        'txtDistributionQuantity
        '
        Me.txtDistributionQuantity.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDistributionQuantity.Location = New System.Drawing.Point(776, 126)
        Me.txtDistributionQuantity.Name = "txtDistributionQuantity"
        Me.txtDistributionQuantity.Size = New System.Drawing.Size(272, 27)
        Me.txtDistributionQuantity.TabIndex = 3
        '
        'dtpDistributionDate
        '
        Me.dtpDistributionDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDistributionDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDistributionDate.Location = New System.Drawing.Point(776, 186)
        Me.dtpDistributionDate.Name = "dtpDistributionDate"
        Me.dtpDistributionDate.Size = New System.Drawing.Size(272, 27)
        Me.dtpDistributionDate.TabIndex = 4
        '
        'btnDistribute
        '
        Me.btnDistribute.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnDistribute.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDistribute.ForeColor = System.Drawing.Color.White
        Me.btnDistribute.Location = New System.Drawing.Point(375, 322)
        Me.btnDistribute.Name = "btnDistribute"
        Me.btnDistribute.Size = New System.Drawing.Size(177, 50)
        Me.btnDistribute.TabIndex = 6
        Me.btnDistribute.Text = "&Distribute"
        Me.btnDistribute.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(606, 322)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(177, 50)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'dgvDistribution
        '
        Me.dgvDistribution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDistribution.Location = New System.Drawing.Point(128, 402)
        Me.dgvDistribution.Name = "dgvDistribution"
        Me.dgvDistribution.RowHeadersWidth = 51
        Me.dgvDistribution.RowTemplate.Height = 24
        Me.dgvDistribution.Size = New System.Drawing.Size(871, 311)
        Me.dgvDistribution.TabIndex = 15
        '
        'frmDistribution
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1151, 765)
        Me.Controls.Add(Me.dgvDistribution)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDistribute)
        Me.Controls.Add(Me.dtpDistributionDate)
        Me.Controls.Add(Me.txtDistributionQuantity)
        Me.Controls.Add(Me.txtAvailableQuantity)
        Me.Controls.Add(Me.cmbDistributionMethod)
        Me.Controls.Add(Me.cmbRecipient)
        Me.Controls.Add(Me.cmbProduce)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmDistribution"
        Me.Text = "ss"
        CType(Me.dgvDistribution, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbProduce As ComboBox
    Friend WithEvents cmbRecipient As ComboBox
    Friend WithEvents cmbDistributionMethod As ComboBox
    Friend WithEvents txtAvailableQuantity As TextBox
    Friend WithEvents txtDistributionQuantity As TextBox
    Friend WithEvents dtpDistributionDate As DateTimePicker
    Friend WithEvents btnDistribute As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents dgvDistribution As DataGridView
End Class
