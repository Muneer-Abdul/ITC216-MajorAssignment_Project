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
        Me.pnlContent.SuspendLayout()
        CType(Me.picVitiBot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSidebar.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.Black
        Me.lblWelcome.Location = New System.Drawing.Point(59, 47)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(270, 54)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Viti FoodLink"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(63, 101)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(326, 25)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Community Food Surplus Management"
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(1166, 1524)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(423, 203)
        Me.btnLogout.TabIndex = 6
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'pnlContent
        '
        Me.pnlContent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlContent.Controls.Add(Me.picVitiBot)
        Me.pnlContent.Location = New System.Drawing.Point(289, 163)
        Me.pnlContent.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1296, 948)
        Me.pnlContent.TabIndex = 7
        '
        'picVitiBot
        '
        Me.picVitiBot.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picVitiBot.Image = CType(resources.GetObject("picVitiBot.Image"), System.Drawing.Image)
        Me.picVitiBot.Location = New System.Drawing.Point(1170, 807)
        Me.picVitiBot.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picVitiBot.Name = "picVitiBot"
        Me.picVitiBot.Size = New System.Drawing.Size(85, 74)
        Me.picVitiBot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picVitiBot.TabIndex = 10
        Me.picVitiBot.TabStop = False
        '
        'picProfile
        '
        Me.picProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picProfile.Image = CType(resources.GetObject("picProfile.Image"), System.Drawing.Image)
        Me.picProfile.Location = New System.Drawing.Point(1474, 47)
        Me.picProfile.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(87, 71)
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
        Me.btnFoodRequests.Location = New System.Drawing.Point(68, 443)
        Me.btnFoodRequests.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnFoodRequests.Name = "btnFoodRequests"
        Me.btnFoodRequests.Size = New System.Drawing.Size(148, 98)
        Me.btnFoodRequests.TabIndex = 5
        Me.btnFoodRequests.Text = "Food Requests"
        Me.btnFoodRequests.UseVisualStyleBackColor = True
        '
        'btnRecipients
        '
        Me.btnRecipients.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnRecipients.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecipients.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecipients.ForeColor = System.Drawing.Color.White
        Me.btnRecipients.Location = New System.Drawing.Point(68, 297)
        Me.btnRecipients.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRecipients.Name = "btnRecipients"
        Me.btnRecipients.Size = New System.Drawing.Size(148, 98)
        Me.btnRecipients.TabIndex = 3
        Me.btnRecipients.Text = "Recipients"
        Me.btnRecipients.UseVisualStyleBackColor = True
        '
        'btnSupplies
        '
        Me.btnSupplies.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSupplies.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupplies.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupplies.ForeColor = System.Drawing.Color.White
        Me.btnSupplies.Location = New System.Drawing.Point(68, 153)
        Me.btnSupplies.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSupplies.Name = "btnSupplies"
        Me.btnSupplies.Size = New System.Drawing.Size(148, 97)
        Me.btnSupplies.TabIndex = 2
        Me.btnSupplies.Text = "Supplies"
        Me.btnSupplies.UseVisualStyleBackColor = True
        '
        'lblMainMenu
        '
        Me.lblMainMenu.AutoSize = True
        Me.lblMainMenu.BackColor = System.Drawing.Color.Transparent
        Me.lblMainMenu.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainMenu.ForeColor = System.Drawing.Color.White
        Me.lblMainMenu.Location = New System.Drawing.Point(48, 45)
        Me.lblMainMenu.Name = "lblMainMenu"
        Me.lblMainMenu.Size = New System.Drawing.Size(191, 45)
        Me.lblMainMenu.TabIndex = 12
        Me.lblMainMenu.Text = "Main Menu"
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.Button1)
        Me.pnlSidebar.Controls.Add(Me.lblMainMenu)
        Me.pnlSidebar.Controls.Add(Me.btnSupplies)
        Me.pnlSidebar.Controls.Add(Me.btnRecipients)
        Me.pnlSidebar.Controls.Add(Me.btnFoodRequests)
        Me.pnlSidebar.Location = New System.Drawing.Point(12, 238)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(277, 756)
        Me.pnlSidebar.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(68, 591)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 89)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Logout*"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblOrganisationDashboard
        '
        Me.lblOrganisationDashboard.AutoSize = True
        Me.lblOrganisationDashboard.BackColor = System.Drawing.Color.Transparent
        Me.lblOrganisationDashboard.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrganisationDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lblOrganisationDashboard.Location = New System.Drawing.Point(767, 119)
        Me.lblOrganisationDashboard.Name = "lblOrganisationDashboard"
        Me.lblOrganisationDashboard.Size = New System.Drawing.Size(327, 38)
        Me.lblOrganisationDashboard.TabIndex = 12
        Me.lblOrganisationDashboard.Text = "Organisation Dashboard"
        '
        'frmOrganisationDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1583, 1112)
        Me.Controls.Add(Me.lblOrganisationDashboard)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.picProfile)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblWelcome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimizeBox = False
        Me.Name = "frmOrganisationDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OrganisationDashboard"
        Me.pnlContent.ResumeLayout(False)
        CType(Me.picVitiBot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlSidebar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
End Class
