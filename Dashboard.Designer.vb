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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblDashboard = New System.Windows.Forms.Label()
        Me.lblSubheading = New System.Windows.Forms.Label()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.lblUserLoggedIn = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.lblMainMenu = New System.Windows.Forms.Label()
        Me.btnBarter = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnExchange = New System.Windows.Forms.Button()
        Me.btnDistribution = New System.Windows.Forms.Button()
        Me.btnRecommendation = New System.Windows.Forms.Button()
        Me.btnRecipients = New System.Windows.Forms.Button()
        Me.btnSupplies = New System.Windows.Forms.Button()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlHeader.SuspendLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSidebar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlHeader.Controls.Add(Me.lblDashboard)
        Me.pnlHeader.Controls.Add(Me.lblSubheading)
        Me.pnlHeader.Controls.Add(Me.picProfile)
        Me.pnlHeader.Controls.Add(Me.lblUserLoggedIn)
        Me.pnlHeader.Controls.Add(Me.Label1)
        Me.pnlHeader.Location = New System.Drawing.Point(-10, -3)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1433, 86)
        Me.pnlHeader.TabIndex = 0
        '
        'lblDashboard
        '
        Me.lblDashboard.AutoSize = True
        Me.lblDashboard.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lblDashboard.Location = New System.Drawing.Point(736, 48)
        Me.lblDashboard.Name = "lblDashboard"
        Me.lblDashboard.Size = New System.Drawing.Size(157, 37)
        Me.lblDashboard.TabIndex = 11
        Me.lblDashboard.Text = "Dashboard"
        '
        'lblSubheading
        '
        Me.lblSubheading.AutoSize = True
        Me.lblSubheading.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubheading.Location = New System.Drawing.Point(35, 48)
        Me.lblSubheading.Name = "lblSubheading"
        Me.lblSubheading.Size = New System.Drawing.Size(251, 17)
        Me.lblSubheading.TabIndex = 10
        Me.lblSubheading.Text = "Community Food Surplus Management"
        '
        'picProfile
        '
        Me.picProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picProfile.Image = CType(resources.GetObject("picProfile.Image"), System.Drawing.Image)
        Me.picProfile.Location = New System.Drawing.Point(1338, 14)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(62, 50)
        Me.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picProfile.TabIndex = 9
        Me.picProfile.TabStop = False
        '
        'lblUserLoggedIn
        '
        Me.lblUserLoggedIn.AutoSize = True
        Me.lblUserLoggedIn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserLoggedIn.ForeColor = System.Drawing.Color.Black
        Me.lblUserLoggedIn.Location = New System.Drawing.Point(1085, 28)
        Me.lblUserLoggedIn.Name = "lblUserLoggedIn"
        Me.lblUserLoggedIn.Size = New System.Drawing.Size(109, 20)
        Me.lblUserLoggedIn.TabIndex = 1
        Me.lblUserLoggedIn.Text = "Logged in User"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(28, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Viti FoodLink"
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.PictureBox1)
        Me.pnlSidebar.Controls.Add(Me.lblMainMenu)
        Me.pnlSidebar.Controls.Add(Me.btnBarter)
        Me.pnlSidebar.Controls.Add(Me.btnLogout)
        Me.pnlSidebar.Controls.Add(Me.btnReports)
        Me.pnlSidebar.Controls.Add(Me.btnExchange)
        Me.pnlSidebar.Controls.Add(Me.btnDistribution)
        Me.pnlSidebar.Controls.Add(Me.btnRecommendation)
        Me.pnlSidebar.Controls.Add(Me.btnRecipients)
        Me.pnlSidebar.Controls.Add(Me.btnSupplies)
        Me.pnlSidebar.Location = New System.Drawing.Point(1, 89)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(244, 803)
        Me.pnlSidebar.TabIndex = 1
        '
        'lblMainMenu
        '
        Me.lblMainMenu.AutoSize = True
        Me.lblMainMenu.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainMenu.ForeColor = System.Drawing.Color.White
        Me.lblMainMenu.Location = New System.Drawing.Point(17, 42)
        Me.lblMainMenu.Name = "lblMainMenu"
        Me.lblMainMenu.Size = New System.Drawing.Size(204, 46)
        Me.lblMainMenu.TabIndex = 10
        Me.lblMainMenu.Text = "Main Menu"
        '
        'btnBarter
        '
        Me.btnBarter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBarter.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBarter.ForeColor = System.Drawing.Color.White
        Me.btnBarter.Location = New System.Drawing.Point(29, 466)
        Me.btnBarter.Name = "btnBarter"
        Me.btnBarter.Size = New System.Drawing.Size(189, 39)
        Me.btnBarter.TabIndex = 7
        Me.btnBarter.Text = "Barter"
        Me.btnBarter.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Red
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(25, 741)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(185, 42)
        Me.btnLogout.TabIndex = 6
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnReports
        '
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReports.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.ForeColor = System.Drawing.Color.White
        Me.btnReports.Location = New System.Drawing.Point(29, 530)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(189, 38)
        Me.btnReports.TabIndex = 5
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'btnExchange
        '
        Me.btnExchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExchange.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExchange.ForeColor = System.Drawing.Color.White
        Me.btnExchange.Location = New System.Drawing.Point(27, 398)
        Me.btnExchange.Name = "btnExchange"
        Me.btnExchange.Size = New System.Drawing.Size(189, 41)
        Me.btnExchange.TabIndex = 4
        Me.btnExchange.Text = "Food Exchange"
        Me.btnExchange.UseVisualStyleBackColor = True
        '
        'btnDistribution
        '
        Me.btnDistribution.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDistribution.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDistribution.ForeColor = System.Drawing.Color.White
        Me.btnDistribution.Location = New System.Drawing.Point(28, 334)
        Me.btnDistribution.Name = "btnDistribution"
        Me.btnDistribution.Size = New System.Drawing.Size(189, 39)
        Me.btnDistribution.TabIndex = 3
        Me.btnDistribution.Text = "Distribution"
        Me.btnDistribution.UseVisualStyleBackColor = True
        '
        'btnRecommendation
        '
        Me.btnRecommendation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecommendation.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecommendation.ForeColor = System.Drawing.Color.White
        Me.btnRecommendation.Location = New System.Drawing.Point(27, 266)
        Me.btnRecommendation.Name = "btnRecommendation"
        Me.btnRecommendation.Size = New System.Drawing.Size(189, 42)
        Me.btnRecommendation.TabIndex = 2
        Me.btnRecommendation.Text = "Recommendation"
        Me.btnRecommendation.UseVisualStyleBackColor = True
        '
        'btnRecipients
        '
        Me.btnRecipients.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecipients.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecipients.ForeColor = System.Drawing.Color.White
        Me.btnRecipients.Location = New System.Drawing.Point(29, 198)
        Me.btnRecipients.Name = "btnRecipients"
        Me.btnRecipients.Size = New System.Drawing.Size(189, 42)
        Me.btnRecipients.TabIndex = 1
        Me.btnRecipients.Text = "Recipients"
        Me.btnRecipients.UseVisualStyleBackColor = True
        '
        'btnSupplies
        '
        Me.btnSupplies.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupplies.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupplies.ForeColor = System.Drawing.Color.White
        Me.btnSupplies.Location = New System.Drawing.Point(29, 138)
        Me.btnSupplies.Name = "btnSupplies"
        Me.btnSupplies.Size = New System.Drawing.Size(189, 37)
        Me.btnSupplies.TabIndex = 0
        Me.btnSupplies.Text = "Surplus"
        Me.btnSupplies.UseVisualStyleBackColor = True
        '
        'pnlContent
        '
        Me.pnlContent.Location = New System.Drawing.Point(255, 82)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1168, 810)
        Me.pnlContent.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(81, 627)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 56)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1430, 899)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlSidebar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblUserLoggedIn As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlContent As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnExchange As Button
    Friend WithEvents btnDistribution As Button
    Friend WithEvents btnRecommendation As Button
    Friend WithEvents btnRecipients As Button
    Friend WithEvents btnSupplies As Button
    Friend WithEvents btnBarter As Button
    Friend WithEvents picProfile As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblMainMenu As Label
    Friend WithEvents lblSubheading As Label
    Friend WithEvents lblDashboard As Label
End Class
