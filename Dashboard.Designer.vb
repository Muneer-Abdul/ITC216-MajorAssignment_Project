<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblUserLoggedIn = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnBarter = New System.Windows.Forms.Button()
        Me.btnDistribution = New System.Windows.Forms.Button()
        Me.btnRecommendation = New System.Windows.Forms.Button()
        Me.btnRecipients = New System.Windows.Forms.Button()
        Me.btnSupplies = New System.Windows.Forms.Button()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.pnlHeader.SuspendLayout()
        Me.pnlSidebar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.lblUserLoggedIn)
        Me.pnlHeader.Controls.Add(Me.Label1)
        Me.pnlHeader.Location = New System.Drawing.Point(12, 3)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1157, 68)
        Me.pnlHeader.TabIndex = 0
        '
        'lblUserLoggedIn
        '
        Me.lblUserLoggedIn.AutoSize = True
        Me.lblUserLoggedIn.Location = New System.Drawing.Point(920, 34)
        Me.lblUserLoggedIn.Name = "lblUserLoggedIn"
        Me.lblUserLoggedIn.Size = New System.Drawing.Size(99, 16)
        Me.lblUserLoggedIn.TabIndex = 1
        Me.lblUserLoggedIn.Text = "Logged in User"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Viti FoodLink"
        '
        'pnlSidebar
        '
        Me.pnlSidebar.Controls.Add(Me.btnLogout)
        Me.pnlSidebar.Controls.Add(Me.btnReports)
        Me.pnlSidebar.Controls.Add(Me.btnBarter)
        Me.pnlSidebar.Controls.Add(Me.btnDistribution)
        Me.pnlSidebar.Controls.Add(Me.btnRecommendation)
        Me.pnlSidebar.Controls.Add(Me.btnRecipients)
        Me.pnlSidebar.Controls.Add(Me.btnSupplies)
        Me.pnlSidebar.Location = New System.Drawing.Point(12, 77)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(237, 570)
        Me.pnlSidebar.TabIndex = 1
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(61, 460)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(138, 47)
        Me.btnLogout.TabIndex = 6
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.Location = New System.Drawing.Point(48, 315)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(138, 47)
        Me.btnReports.TabIndex = 5
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'btnBarter
        '
        Me.btnBarter.Location = New System.Drawing.Point(49, 262)
        Me.btnBarter.Name = "btnBarter"
        Me.btnBarter.Size = New System.Drawing.Size(138, 47)
        Me.btnBarter.TabIndex = 4
        Me.btnBarter.Text = "Barter"
        Me.btnBarter.UseVisualStyleBackColor = True
        '
        'btnDistribution
        '
        Me.btnDistribution.Location = New System.Drawing.Point(48, 200)
        Me.btnDistribution.Name = "btnDistribution"
        Me.btnDistribution.Size = New System.Drawing.Size(138, 47)
        Me.btnDistribution.TabIndex = 3
        Me.btnDistribution.Text = "Distribution"
        Me.btnDistribution.UseVisualStyleBackColor = True
        '
        'btnRecommendation
        '
        Me.btnRecommendation.Location = New System.Drawing.Point(48, 137)
        Me.btnRecommendation.Name = "btnRecommendation"
        Me.btnRecommendation.Size = New System.Drawing.Size(138, 47)
        Me.btnRecommendation.TabIndex = 2
        Me.btnRecommendation.Text = "Recommendation"
        Me.btnRecommendation.UseVisualStyleBackColor = True
        '
        'btnRecipients
        '
        Me.btnRecipients.Location = New System.Drawing.Point(48, 84)
        Me.btnRecipients.Name = "btnRecipients"
        Me.btnRecipients.Size = New System.Drawing.Size(138, 47)
        Me.btnRecipients.TabIndex = 1
        Me.btnRecipients.Text = "Recipients"
        Me.btnRecipients.UseVisualStyleBackColor = True
        '
        'btnSupplies
        '
        Me.btnSupplies.Location = New System.Drawing.Point(48, 21)
        Me.btnSupplies.Name = "btnSupplies"
        Me.btnSupplies.Size = New System.Drawing.Size(138, 47)
        Me.btnSupplies.TabIndex = 0
        Me.btnSupplies.Text = "Supplies"
        Me.btnSupplies.UseVisualStyleBackColor = True
        '
        'pnlContent
        '
        Me.pnlContent.Location = New System.Drawing.Point(255, 77)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(914, 570)
        Me.pnlContent.TabIndex = 2
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1209, 669)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.pnlHeader)
        Me.Name = "frmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlSidebar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblUserLoggedIn As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlContent As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnBarter As Button
    Friend WithEvents btnDistribution As Button
    Friend WithEvents btnRecommendation As Button
    Friend WithEvents btnRecipients As Button
    Friend WithEvents btnSupplies As Button
End Class
