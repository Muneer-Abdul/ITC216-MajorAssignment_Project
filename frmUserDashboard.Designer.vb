<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserDashboard))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnGiveFood = New System.Windows.Forms.Button()
        Me.btnRequestFood = New System.Windows.Forms.Button()
        Me.btnBarter = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.picVitiBot = New System.Windows.Forms.PictureBox()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.lblMainMenu = New System.Windows.Forms.Label()
        Me.lblVitiFoodLink = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.pnlHeaderLine = New System.Windows.Forms.Panel()
        Me.pnlContent.SuspendLayout()
        CType(Me.picVitiBot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlHeaderLine.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(757, 108)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(270, 38)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "USER DASHBOARD"
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(1305, 60)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(129, 25)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "Welcome, User"
        '
        'btnGiveFood
        '
        Me.btnGiveFood.BackColor = System.Drawing.Color.Transparent
        Me.btnGiveFood.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnGiveFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGiveFood.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGiveFood.ForeColor = System.Drawing.Color.White
        Me.btnGiveFood.Location = New System.Drawing.Point(40, 149)
        Me.btnGiveFood.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGiveFood.Name = "btnGiveFood"
        Me.btnGiveFood.Size = New System.Drawing.Size(156, 98)
        Me.btnGiveFood.TabIndex = 0
        Me.btnGiveFood.Text = "Give Food"
        Me.btnGiveFood.UseVisualStyleBackColor = False
        '
        'btnRequestFood
        '
        Me.btnRequestFood.BackColor = System.Drawing.Color.Transparent
        Me.btnRequestFood.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnRequestFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRequestFood.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRequestFood.ForeColor = System.Drawing.Color.White
        Me.btnRequestFood.Location = New System.Drawing.Point(40, 278)
        Me.btnRequestFood.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRequestFood.Name = "btnRequestFood"
        Me.btnRequestFood.Size = New System.Drawing.Size(156, 92)
        Me.btnRequestFood.TabIndex = 1
        Me.btnRequestFood.Text = "Request Food"
        Me.btnRequestFood.UseVisualStyleBackColor = False
        '
        'btnBarter
        '
        Me.btnBarter.BackColor = System.Drawing.Color.Transparent
        Me.btnBarter.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBarter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBarter.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBarter.ForeColor = System.Drawing.Color.White
        Me.btnBarter.Location = New System.Drawing.Point(40, 412)
        Me.btnBarter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBarter.Name = "btnBarter"
        Me.btnBarter.Size = New System.Drawing.Size(156, 92)
        Me.btnBarter.TabIndex = 2
        Me.btnBarter.Text = "Barter System"
        Me.btnBarter.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Red
        Me.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(38, 731)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(156, 92)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "&Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'pnlContent
        '
        Me.pnlContent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlContent.Controls.Add(Me.picVitiBot)
        Me.pnlContent.Location = New System.Drawing.Point(250, 165)
        Me.pnlContent.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(1333, 948)
        Me.pnlContent.TabIndex = 7
        '
        'picVitiBot
        '
        Me.picVitiBot.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picVitiBot.Image = CType(resources.GetObject("picVitiBot.Image"), System.Drawing.Image)
        Me.picVitiBot.Location = New System.Drawing.Point(1234, 794)
        Me.picVitiBot.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picVitiBot.Name = "picVitiBot"
        Me.picVitiBot.Size = New System.Drawing.Size(81, 72)
        Me.picVitiBot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picVitiBot.TabIndex = 9
        Me.picVitiBot.TabStop = False
        '
        'picProfile
        '
        Me.picProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picProfile.Image = CType(resources.GetObject("picProfile.Image"), System.Drawing.Image)
        Me.picProfile.Location = New System.Drawing.Point(1472, 35)
        Me.picProfile.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(82, 75)
        Me.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picProfile.TabIndex = 8
        Me.picProfile.TabStop = False
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.lblMainMenu)
        Me.pnlSidebar.Controls.Add(Me.btnLogout)
        Me.pnlSidebar.Controls.Add(Me.btnBarter)
        Me.pnlSidebar.Controls.Add(Me.btnRequestFood)
        Me.pnlSidebar.Controls.Add(Me.btnGiveFood)
        Me.pnlSidebar.Location = New System.Drawing.Point(1, 228)
        Me.pnlSidebar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(238, 866)
        Me.pnlSidebar.TabIndex = 9
        '
        'lblMainMenu
        '
        Me.lblMainMenu.AutoSize = True
        Me.lblMainMenu.BackColor = System.Drawing.Color.Transparent
        Me.lblMainMenu.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainMenu.ForeColor = System.Drawing.Color.White
        Me.lblMainMenu.Location = New System.Drawing.Point(12, 29)
        Me.lblMainMenu.Name = "lblMainMenu"
        Me.lblMainMenu.Size = New System.Drawing.Size(212, 48)
        Me.lblMainMenu.TabIndex = 7
        Me.lblMainMenu.Text = "Main Menu"
        '
        'lblVitiFoodLink
        '
        Me.lblVitiFoodLink.AutoSize = True
        Me.lblVitiFoodLink.BackColor = System.Drawing.Color.Transparent
        Me.lblVitiFoodLink.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVitiFoodLink.ForeColor = System.Drawing.Color.Black
        Me.lblVitiFoodLink.Location = New System.Drawing.Point(32, 25)
        Me.lblVitiFoodLink.Name = "lblVitiFoodLink"
        Me.lblVitiFoodLink.Size = New System.Drawing.Size(270, 54)
        Me.lblVitiFoodLink.TabIndex = 10
        Me.lblVitiFoodLink.Text = "Viti FoodLink"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtitle.ForeColor = System.Drawing.Color.Black
        Me.lblSubtitle.Location = New System.Drawing.Point(37, 90)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(326, 25)
        Me.lblSubtitle.TabIndex = 11
        Me.lblSubtitle.Text = "Community Food Surplus Management"
        '
        'pnlHeaderLine
        '
        Me.pnlHeaderLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlHeaderLine.Controls.Add(Me.lblSubtitle)
        Me.pnlHeaderLine.Controls.Add(Me.lblVitiFoodLink)
        Me.pnlHeaderLine.Controls.Add(Me.picProfile)
        Me.pnlHeaderLine.Controls.Add(Me.lblWelcome)
        Me.pnlHeaderLine.Controls.Add(Me.lblTitle)
        Me.pnlHeaderLine.Location = New System.Drawing.Point(-2, -2)
        Me.pnlHeaderLine.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlHeaderLine.Name = "pnlHeaderLine"
        Me.pnlHeaderLine.Size = New System.Drawing.Size(1584, 161)
        Me.pnlHeaderLine.TabIndex = 12
        '
        'frmUserDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1583, 1108)
        Me.Controls.Add(Me.pnlHeaderLine)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.pnlContent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmUserDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Dashboard"
        Me.pnlContent.ResumeLayout(False)
        CType(Me.picVitiBot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlSidebar.PerformLayout()
        Me.pnlHeaderLine.ResumeLayout(False)
        Me.pnlHeaderLine.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnGiveFood As Button
    Friend WithEvents btnRequestFood As Button
    Friend WithEvents btnBarter As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents pnlContent As Panel
    Friend WithEvents picProfile As PictureBox
    Friend WithEvents picVitiBot As PictureBox
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents lblMainMenu As Label
    Friend WithEvents lblVitiFoodLink As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents pnlHeaderLine As Panel
End Class
