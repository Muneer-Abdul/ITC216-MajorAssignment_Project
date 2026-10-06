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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.dgvRequests = New System.Windows.Forms.DataGridView()
        CType(Me.dgvRequests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(419, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Food Request"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Requester Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Food Needed"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Quantity Needed"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Community"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(61, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Recipient Type"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(61, 261)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Urgency"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(61, 297)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Request Reason:"
        '
        'txtRequesterName
        '
        Me.txtRequesterName.Location = New System.Drawing.Point(185, 75)
        Me.txtRequesterName.Name = "txtRequesterName"
        Me.txtRequesterName.Size = New System.Drawing.Size(115, 22)
        Me.txtRequesterName.TabIndex = 8
        '
        'txtFoodNeeded
        '
        Me.txtFoodNeeded.Location = New System.Drawing.Point(185, 117)
        Me.txtFoodNeeded.Name = "txtFoodNeeded"
        Me.txtFoodNeeded.Size = New System.Drawing.Size(115, 22)
        Me.txtFoodNeeded.TabIndex = 9
        '
        'txtQuantityNeeded
        '
        Me.txtQuantityNeeded.Location = New System.Drawing.Point(185, 157)
        Me.txtQuantityNeeded.Name = "txtQuantityNeeded"
        Me.txtQuantityNeeded.Size = New System.Drawing.Size(115, 22)
        Me.txtQuantityNeeded.TabIndex = 10
        '
        'txtCommunity
        '
        Me.txtCommunity.Location = New System.Drawing.Point(185, 233)
        Me.txtCommunity.Name = "txtCommunity"
        Me.txtCommunity.Size = New System.Drawing.Size(115, 22)
        Me.txtCommunity.TabIndex = 11
        '
        'txtRequestReason
        '
        Me.txtRequestReason.Location = New System.Drawing.Point(185, 297)
        Me.txtRequestReason.Name = "txtRequestReason"
        Me.txtRequestReason.Size = New System.Drawing.Size(115, 22)
        Me.txtRequestReason.TabIndex = 12
        '
        'cmbRecipientType
        '
        Me.cmbRecipientType.FormattingEnabled = True
        Me.cmbRecipientType.Location = New System.Drawing.Point(185, 194)
        Me.cmbRecipientType.Name = "cmbRecipientType"
        Me.cmbRecipientType.Size = New System.Drawing.Size(121, 24)
        Me.cmbRecipientType.TabIndex = 13
        '
        'cmbUrgency
        '
        Me.cmbUrgency.FormattingEnabled = True
        Me.cmbUrgency.Location = New System.Drawing.Point(185, 267)
        Me.cmbUrgency.Name = "cmbUrgency"
        Me.cmbUrgency.Size = New System.Drawing.Size(121, 24)
        Me.cmbUrgency.TabIndex = 14
        '
        'btnSubmitRequest
        '
        Me.btnSubmitRequest.Location = New System.Drawing.Point(64, 366)
        Me.btnSubmitRequest.Name = "btnSubmitRequest"
        Me.btnSubmitRequest.Size = New System.Drawing.Size(100, 56)
        Me.btnSubmitRequest.TabIndex = 15
        Me.btnSubmitRequest.Text = "Submit Request"
        Me.btnSubmitRequest.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(231, 366)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 56)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(385, 366)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 56)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'dgvRequests
        '
        Me.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRequests.Location = New System.Drawing.Point(335, 101)
        Me.dgvRequests.Name = "dgvRequests"
        Me.dgvRequests.RowHeadersWidth = 51
        Me.dgvRequests.RowTemplate.Height = 24
        Me.dgvRequests.Size = New System.Drawing.Size(518, 190)
        Me.dgvRequests.TabIndex = 18
        '
        'frmFoodRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 463)
        Me.Controls.Add(Me.dgvRequests)
        Me.Controls.Add(Me.Button3)
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
    Friend WithEvents Button3 As Button
    Friend WithEvents dgvRequests As DataGridView
End Class
