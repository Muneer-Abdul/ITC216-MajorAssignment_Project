<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFoodRequest
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRequesterName = New System.Windows.Forms.TextBox()
        Me.txtFoodNeeded = New System.Windows.Forms.TextBox()
        Me.txtQuantityNeeded = New System.Windows.Forms.TextBox()
        Me.txtCommunity = New System.Windows.Forms.TextBox()
        Me.txtRequestReason = New System.Windows.Forms.TextBox()
        Me.cmbRecipientType = New System.Windows.Forms.ComboBox()
        Me.cmbUrgency = New System.Windows.Forms.ComboBox()
        Me.btnSubmitRequest = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.dgvRequests = New System.Windows.Forms.DataGridView()
        CType(Me.dgvRequests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(1037, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Food Request"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(151, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Requester Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(151, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Food Needed"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(151, 268)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Quantity Needed"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(151, 352)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Community"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(714, 268)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Recipient Type"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(714, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 25)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Urgency"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(714, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(141, 25)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Request Reason:"
        '
        'txtRequesterName
        '
        Me.txtRequesterName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRequesterName.Location = New System.Drawing.Point(364, 112)
        Me.txtRequesterName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRequesterName.Name = "txtRequesterName"
        Me.txtRequesterName.Size = New System.Drawing.Size(194, 31)
        Me.txtRequesterName.TabIndex = 0
        '
        'txtFoodNeeded
        '
        Me.txtFoodNeeded.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFoodNeeded.Location = New System.Drawing.Point(364, 190)
        Me.txtFoodNeeded.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtFoodNeeded.Name = "txtFoodNeeded"
        Me.txtFoodNeeded.Size = New System.Drawing.Size(194, 31)
        Me.txtFoodNeeded.TabIndex = 1
        '
        'txtQuantityNeeded
        '
        Me.txtQuantityNeeded.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantityNeeded.Location = New System.Drawing.Point(364, 261)
        Me.txtQuantityNeeded.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtQuantityNeeded.Name = "txtQuantityNeeded"
        Me.txtQuantityNeeded.Size = New System.Drawing.Size(194, 31)
        Me.txtQuantityNeeded.TabIndex = 2
        '
        'txtCommunity
        '
        Me.txtCommunity.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCommunity.Location = New System.Drawing.Point(364, 346)
        Me.txtCommunity.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCommunity.Name = "txtCommunity"
        Me.txtCommunity.Size = New System.Drawing.Size(194, 31)
        Me.txtCommunity.TabIndex = 3
        '
        'txtRequestReason
        '
        Me.txtRequestReason.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRequestReason.Location = New System.Drawing.Point(914, 112)
        Me.txtRequestReason.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRequestReason.Name = "txtRequestReason"
        Me.txtRequestReason.Size = New System.Drawing.Size(194, 31)
        Me.txtRequestReason.TabIndex = 4
        '
        'cmbRecipientType
        '
        Me.cmbRecipientType.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRecipientType.FormattingEnabled = True
        Me.cmbRecipientType.Location = New System.Drawing.Point(914, 259)
        Me.cmbRecipientType.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbRecipientType.Name = "cmbRecipientType"
        Me.cmbRecipientType.Size = New System.Drawing.Size(194, 33)
        Me.cmbRecipientType.TabIndex = 6
        '
        'cmbUrgency
        '
        Me.cmbUrgency.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUrgency.FormattingEnabled = True
        Me.cmbUrgency.Location = New System.Drawing.Point(914, 192)
        Me.cmbUrgency.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbUrgency.Name = "cmbUrgency"
        Me.cmbUrgency.Size = New System.Drawing.Size(194, 33)
        Me.cmbUrgency.TabIndex = 5
        '
        'btnSubmitRequest
        '
        Me.btnSubmitRequest.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnSubmitRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmitRequest.ForeColor = System.Drawing.Color.White
        Me.btnSubmitRequest.Location = New System.Drawing.Point(374, 441)
        Me.btnSubmitRequest.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSubmitRequest.Name = "btnSubmitRequest"
        Me.btnSubmitRequest.Size = New System.Drawing.Size(158, 70)
        Me.btnSubmitRequest.TabIndex = 7
        Me.btnSubmitRequest.Text = "&Submit Request"
        Me.btnSubmitRequest.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(719, 441)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(158, 70)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'dgvRequests
        '
        Me.dgvRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRequests.EnableHeadersVisualStyles = False
        Me.dgvRequests.Location = New System.Drawing.Point(14, 556)
        Me.dgvRequests.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvRequests.Name = "dgvRequests"
        Me.dgvRequests.RowHeadersWidth = 51
        Me.dgvRequests.RowTemplate.Height = 24
        Me.dgvRequests.Size = New System.Drawing.Size(1269, 352)
        Me.dgvRequests.TabIndex = 18
        '
        'frmFoodRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1296, 958)
        Me.Controls.Add(Me.dgvRequests)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmitRequest)
        Me.Controls.Add(Me.cmbUrgency)
        Me.Controls.Add(Me.cmbRecipientType)
        Me.Controls.Add(Me.txtRequestReason)
        Me.Controls.Add(Me.txtCommunity)
        Me.Controls.Add(Me.txtQuantityNeeded)
        Me.Controls.Add(Me.txtFoodNeeded)
        Me.Controls.Add(Me.txtRequesterName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmFoodRequest"
        Me.Text = "FoodRequest"
        CType(Me.dgvRequests, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label8 As Label
    Friend WithEvents txtRequesterName As TextBox
    Friend WithEvents txtFoodNeeded As TextBox
    Friend WithEvents txtQuantityNeeded As TextBox
    Friend WithEvents txtCommunity As TextBox
    Friend WithEvents txtRequestReason As TextBox
    Friend WithEvents cmbRecipientType As ComboBox
    Friend WithEvents cmbUrgency As ComboBox
    Friend WithEvents btnSubmitRequest As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents dgvRequests As DataGridView
End Class
