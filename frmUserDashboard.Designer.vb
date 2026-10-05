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
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.picVitiBot = New System.Windows.Forms.PictureBox()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVitiBot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(427, 35)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(134, 16)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "USER DASHBOARD"
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Location = New System.Drawing.Point(427, 77)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(100, 16)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "Welcome, User"
        '
        'btnGiveFood
        '
        Me.btnGiveFood.Location = New System.Drawing.Point(57, 122)
        Me.btnGiveFood.Name = "btnGiveFood"
        Me.btnGiveFood.Size = New System.Drawing.Size(129, 66)
        Me.btnGiveFood.TabIndex = 2
        Me.btnGiveFood.Text = "Give Food"
        Me.btnGiveFood.UseVisualStyleBackColor = True
        '
        'btnRequestFood
        '
        Me.btnRequestFood.Location = New System.Drawing.Point(57, 212)
        Me.btnRequestFood.Name = "btnRequestFood"
        Me.btnRequestFood.Size = New System.Drawing.Size(129, 66)
        Me.btnRequestFood.TabIndex = 3
        Me.btnRequestFood.Text = "Request Food"
        Me.btnRequestFood.UseVisualStyleBackColor = True
        '
        'btnBarter
        '
        Me.btnBarter.Location = New System.Drawing.Point(57, 300)
        Me.btnBarter.Name = "btnBarter"
        Me.btnBarter.Size = New System.Drawing.Size(129, 66)
        Me.btnBarter.TabIndex = 5
        Me.btnBarter.Text = "Barter System"
        Me.btnBarter.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(57, 481)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(129, 66)
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
        Me.pnlContent.Location = New System.Drawing.Point(208, 122)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(873, 478)
        Me.pnlContent.TabIndex = 7
        '
        'picProfile
        '
        Me.picProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picProfile.Image = CType(resources.GetObject("picProfile.Image"), System.Drawing.Image)
        Me.picProfile.Location = New System.Drawing.Point(964, 32)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(73, 60)
        Me.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picProfile.TabIndex = 8
        Me.picProfile.TabStop = False
        '
        'picVitiBot
        '
        Me.picVitiBot.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picVitiBot.Image = CType(resources.GetObject("picVitiBot.Image"), System.Drawing.Image)
        Me.picVitiBot.Location = New System.Drawing.Point(1017, 606)
        Me.picVitiBot.Name = "picVitiBot"
        Me.picVitiBot.Size = New System.Drawing.Size(78, 70)
        Me.picVitiBot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picVitiBot.TabIndex = 9
        Me.picVitiBot.TabStop = False
        '
        'frmUserDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1143, 680)
        Me.Controls.Add(Me.picVitiBot)
        Me.Controls.Add(Me.picProfile)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnBarter)
        Me.Controls.Add(Me.btnRequestFood)
        Me.Controls.Add(Me.btnGiveFood)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmUserDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Dashboard"
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVitiBot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
End Class
