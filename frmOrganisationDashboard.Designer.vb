<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrganisationDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrganisationDashboard))
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.picVitiBot = New System.Windows.Forms.PictureBox()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.btnFoodRequests = New System.Windows.Forms.Button()
        Me.btnRecipients = New System.Windows.Forms.Button()
        Me.btnSupplies = New System.Windows.Forms.Button()
        Me.lblMainMenu = New System.Windows.Forms.Label()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblOrganisationDashboard = New System.Windows.Forms.Label()
        Me.pnlHeading = New System.Windows.Forms.Panel()
        CType(Me.picVitiBot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlHeading.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.Black
        Me.lblWelcome.Location = New System.Drawing.Point(51, 36)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(233, 46)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Viti FoodLink"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(54, 79)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(267, 20)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Community Food Surplus Management"
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(1036, 1219)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(376, 162)
        Me.btnLogout.TabIndex = 6
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'pnlContent
        '
        Me.pnlContent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlContent.Location = New System.Drawing.Point(239, 118)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1151, 762)
        Me.pnlContent.TabIndex = 7
        '
        'picVitiBot
        '
        Me.picVitiBot.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picVitiBot.Image = CType(resources.GetObject("picVitiBot.Image"), System.Drawing.Image)
        Me.picVitiBot.Location = New System.Drawing.Point(90, 443)
        Me.picVitiBot.Name = "picVitiBot"
        Me.picVitiBot.Size = New System.Drawing.Size(76, 59)
        Me.picVitiBot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picVitiBot.TabIndex = 10
        Me.picVitiBot.TabStop = False
        '
        'picProfile
        '
        Me.picProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picProfile.Image = CType(resources.GetObject("picProfile.Image"), System.Drawing.Image)
        Me.picProfile.Location = New System.Drawing.Point(1308, 36)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(77, 57)
        Me.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picProfile.TabIndex = 9
        Me.picProfile.TabStop = False
        '
        'btnFoodRequests
        '
        Me.btnFoodRequests.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnFoodRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFoodRequests.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFoodRequests.ForeColor = System.Drawing.Color.White
        Me.btnFoodRequests.Location = New System.Drawing.Point(60, 354)
        Me.btnFoodRequests.Name = "btnFoodRequests"
        Me.btnFoodRequests.Size = New System.Drawing.Size(132, 78)
        Me.btnFoodRequests.TabIndex = 2
        Me.btnFoodRequests.Text = "Food Requests"
        Me.btnFoodRequests.UseVisualStyleBackColor = True
        '
        'btnRecipients
        '
        Me.btnRecipients.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnRecipients.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecipients.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecipients.ForeColor = System.Drawing.Color.White
        Me.btnRecipients.Location = New System.Drawing.Point(60, 230)
        Me.btnRecipients.Name = "btnRecipients"
        Me.btnRecipients.Size = New System.Drawing.Size(132, 78)
        Me.btnRecipients.TabIndex = 1
        Me.btnRecipients.Text = "Recipients"
        Me.btnRecipients.UseVisualStyleBackColor = True
        '
        'btnSupplies
        '
        Me.btnSupplies.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSupplies.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupplies.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupplies.ForeColor = System.Drawing.Color.White
        Me.btnSupplies.Location = New System.Drawing.Point(60, 108)
        Me.btnSupplies.Name = "btnSupplies"
        Me.btnSupplies.Size = New System.Drawing.Size(132, 78)
        Me.btnSupplies.TabIndex = 0
        Me.btnSupplies.Text = "Supplies"
        Me.btnSupplies.UseVisualStyleBackColor = True
        '
        'lblMainMenu
        '
        Me.lblMainMenu.AutoSize = True
        Me.lblMainMenu.BackColor = System.Drawing.Color.Transparent
        Me.lblMainMenu.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainMenu.ForeColor = System.Drawing.Color.White
        Me.lblMainMenu.Location = New System.Drawing.Point(42, 29)
        Me.lblMainMenu.Name = "lblMainMenu"
        Me.lblMainMenu.Size = New System.Drawing.Size(162, 37)
        Me.lblMainMenu.TabIndex = 12
        Me.lblMainMenu.Text = "Main Menu"
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.picVitiBot)
        Me.pnlSidebar.Controls.Add(Me.Button1)
        Me.pnlSidebar.Controls.Add(Me.lblMainMenu)
        Me.pnlSidebar.Controls.Add(Me.btnSupplies)
        Me.pnlSidebar.Controls.Add(Me.btnRecipients)
        Me.pnlSidebar.Controls.Add(Me.btnFoodRequests)
        Me.pnlSidebar.Location = New System.Drawing.Point(-5, 117)
        Me.pnlSidebar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(238, 736)
        Me.pnlSidebar.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(59, 588)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 82)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "&Logout"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblOrganisationDashboard
        '
        Me.lblOrganisationDashboard.AutoSize = True
        Me.lblOrganisationDashboard.BackColor = System.Drawing.Color.Transparent
        Me.lblOrganisationDashboard.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrganisationDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lblOrganisationDashboard.Location = New System.Drawing.Point(642, 79)
        Me.lblOrganisationDashboard.Name = "lblOrganisationDashboard"
        Me.lblOrganisationDashboard.Size = New System.Drawing.Size(293, 32)
        Me.lblOrganisationDashboard.TabIndex = 12
        Me.lblOrganisationDashboard.Text = "Organisation Dashboard"
        '
        'pnlHeading
        '
        Me.pnlHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlHeading.Controls.Add(Me.lblOrganisationDashboard)
        Me.pnlHeading.Controls.Add(Me.picProfile)
        Me.pnlHeading.Controls.Add(Me.lblTitle)
        Me.pnlHeading.Controls.Add(Me.lblWelcome)
        Me.pnlHeading.Location = New System.Drawing.Point(-5, -10)
        Me.pnlHeading.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlHeading.Name = "pnlHeading"
        Me.pnlHeading.Size = New System.Drawing.Size(1422, 123)
        Me.pnlHeading.TabIndex = 13
        '
        'frmOrganisationDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1407, 881)
        Me.Controls.Add(Me.pnlHeading)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.btnLogout)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "frmOrganisationDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OrganisationDashboard"
        CType(Me.picVitiBot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlSidebar.PerformLayout()
        Me.pnlHeading.ResumeLayout(False)
        Me.pnlHeading.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents pnlContent As Panel
    Friend WithEvents picProfile As PictureBox
    Friend WithEvents picVitiBot As PictureBox
    Friend WithEvents btnFoodRequests As Button
    Friend WithEvents btnRecipients As Button
    Friend WithEvents btnSupplies As Button
    Friend WithEvents lblMainMenu As Label
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents lblOrganisationDashboard As Label
    Friend WithEvents pnlHeading As Panel
End Class
