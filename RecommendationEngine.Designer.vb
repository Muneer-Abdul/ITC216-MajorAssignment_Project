<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecommendationEngine
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnRecommend = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.cmbProduce = New System.Windows.Forms.ComboBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.cmbRecipientType = New System.Windows.Forms.ComboBox()
        Me.txtCommunity = New System.Windows.Forms.TextBox()
        Me.grpResult = New System.Windows.Forms.GroupBox()
        Me.txtPriority = New System.Windows.Forms.TextBox()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.txtReason = New System.Windows.Forms.TextBox()
        Me.txtRecommendedRecipient = New System.Windows.Forms.TextBox()
        Me.grpResult.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(442, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Recommendation Engine"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Select Produce: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Available Quantity:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Recipient Type:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 286)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Community: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(164, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Recommended Recipient:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Suitability Score:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(44, 132)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Priority Level:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(44, 168)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Reason: "
        '
        'btnRecommend
        '
        Me.btnRecommend.Location = New System.Drawing.Point(72, 360)
        Me.btnRecommend.Name = "btnRecommend"
        Me.btnRecommend.Size = New System.Drawing.Size(158, 55)
        Me.btnRecommend.TabIndex = 9
        Me.btnRecommend.Text = "FIND RECOMMENDATION"
        Me.btnRecommend.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(137, 255)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(111, 55)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'cmbProduce
        '
        Me.cmbProduce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProduce.FormattingEnabled = True
        Me.cmbProduce.Location = New System.Drawing.Point(189, 101)
        Me.cmbProduce.Name = "cmbProduce"
        Me.cmbProduce.Size = New System.Drawing.Size(147, 24)
        Me.cmbProduce.TabIndex = 11
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(189, 161)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.ReadOnly = True
        Me.txtQuantity.Size = New System.Drawing.Size(125, 22)
        Me.txtQuantity.TabIndex = 12
        '
        'cmbRecipientType
        '
        Me.cmbRecipientType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRecipientType.FormattingEnabled = True
        Me.cmbRecipientType.Location = New System.Drawing.Point(186, 229)
        Me.cmbRecipientType.Name = "cmbRecipientType"
        Me.cmbRecipientType.Size = New System.Drawing.Size(127, 24)
        Me.cmbRecipientType.TabIndex = 13
        '
        'txtCommunity
        '
        Me.txtCommunity.Location = New System.Drawing.Point(182, 286)
        Me.txtCommunity.Name = "txtCommunity"
        Me.txtCommunity.Size = New System.Drawing.Size(131, 22)
        Me.txtCommunity.TabIndex = 14
        '
        'grpResult
        '
        Me.grpResult.Controls.Add(Me.txtPriority)
        Me.grpResult.Controls.Add(Me.txtScore)
        Me.grpResult.Controls.Add(Me.txtReason)
        Me.grpResult.Controls.Add(Me.txtRecommendedRecipient)
        Me.grpResult.Controls.Add(Me.Label6)
        Me.grpResult.Controls.Add(Me.Label7)
        Me.grpResult.Controls.Add(Me.Label8)
        Me.grpResult.Controls.Add(Me.Label9)
        Me.grpResult.Controls.Add(Me.btnClear)
        Me.grpResult.Location = New System.Drawing.Point(408, 105)
        Me.grpResult.Name = "grpResult"
        Me.grpResult.Size = New System.Drawing.Size(484, 332)
        Me.grpResult.TabIndex = 15
        Me.grpResult.TabStop = False
        Me.grpResult.Text = "Recommendation Result"
        '
        'txtPriority
        '
        Me.txtPriority.Location = New System.Drawing.Point(170, 129)
        Me.txtPriority.Name = "txtPriority"
        Me.txtPriority.ReadOnly = True
        Me.txtPriority.Size = New System.Drawing.Size(148, 22)
        Me.txtPriority.TabIndex = 14
        '
        'txtScore
        '
        Me.txtScore.Location = New System.Drawing.Point(170, 92)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.ReadOnly = True
        Me.txtScore.Size = New System.Drawing.Size(148, 22)
        Me.txtScore.TabIndex = 13
        '
        'txtReason
        '
        Me.txtReason.Location = New System.Drawing.Point(170, 162)
        Me.txtReason.Multiline = True
        Me.txtReason.Name = "txtReason"
        Me.txtReason.ReadOnly = True
        Me.txtReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReason.Size = New System.Drawing.Size(250, 63)
        Me.txtReason.TabIndex = 12
        '
        'txtRecommendedRecipient
        '
        Me.txtRecommendedRecipient.Location = New System.Drawing.Point(218, 59)
        Me.txtRecommendedRecipient.Name = "txtRecommendedRecipient"
        Me.txtRecommendedRecipient.ReadOnly = True
        Me.txtRecommendedRecipient.Size = New System.Drawing.Size(148, 22)
        Me.txtRecommendedRecipient.TabIndex = 11
        '
        'frmRecommendationEngine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 662)
        Me.Controls.Add(Me.grpResult)
        Me.Controls.Add(Me.txtCommunity)
        Me.Controls.Add(Me.cmbRecipientType)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.cmbProduce)
        Me.Controls.Add(Me.btnRecommend)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRecommendationEngine"
        Me.Text = "Recommendation Engine"
        Me.grpResult.ResumeLayout(False)
        Me.grpResult.PerformLayout()
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
    Friend WithEvents Label9 As Label
    Friend WithEvents btnRecommend As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents cmbProduce As ComboBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents cmbRecipientType As ComboBox
    Friend WithEvents txtCommunity As TextBox
    Friend WithEvents grpResult As GroupBox
    Friend WithEvents txtPriority As TextBox
    Friend WithEvents txtScore As TextBox
    Friend WithEvents txtReason As TextBox
    Friend WithEvents txtRecommendedRecipient As TextBox
End Class
