<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWelcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWelcome))
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpLanguage = New System.Windows.Forms.GroupBox()
        Me.rdoFijiHindi = New System.Windows.Forms.RadioButton()
        Me.rdoItaukei = New System.Windows.Forms.RadioButton()
        Me.rdoEnglish = New System.Windows.Forms.RadioButton()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pbDecorativeBorder = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLanguage.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDecorativeBorder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnContinue
        '
        Me.btnContinue.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnContinue.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinue.ForeColor = System.Drawing.Color.White
        Me.btnContinue.Location = New System.Drawing.Point(170, 714)
        Me.btnContinue.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(375, 48)
        Me.btnContinue.TabIndex = 0
        Me.btnContinue.Text = "Continue To Login "
        Me.btnContinue.UseVisualStyleBackColor = False
        Me.btnContinue.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(246, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 48)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = " Viti FoodLink"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(289, 104)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(173, 154)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(223, 312)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(304, 78)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Reduce food waste, support communities, and share resources through Viti FoodLink" &
    "."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(177, 271)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(411, 28)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Connecting Surplus Food with communities"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(272, 506)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(226, 28)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = " Select Your Language "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpLanguage
        '
        Me.grpLanguage.Controls.Add(Me.rdoFijiHindi)
        Me.grpLanguage.Controls.Add(Me.rdoItaukei)
        Me.grpLanguage.Controls.Add(Me.rdoEnglish)
        Me.grpLanguage.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLanguage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.grpLanguage.Location = New System.Drawing.Point(302, 536)
        Me.grpLanguage.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpLanguage.Name = "grpLanguage"
        Me.grpLanguage.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpLanguage.Size = New System.Drawing.Size(152, 149)
        Me.grpLanguage.TabIndex = 6
        Me.grpLanguage.TabStop = False
        '
        'rdoFijiHindi
        '
        Me.rdoFijiHindi.AutoSize = True
        Me.rdoFijiHindi.Location = New System.Drawing.Point(24, 109)
        Me.rdoFijiHindi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdoFijiHindi.Name = "rdoFijiHindi"
        Me.rdoFijiHindi.Size = New System.Drawing.Size(112, 29)
        Me.rdoFijiHindi.TabIndex = 2
        Me.rdoFijiHindi.Text = "Fiji Hindi"
        Me.rdoFijiHindi.UseVisualStyleBackColor = True
        '
        'rdoItaukei
        '
        Me.rdoItaukei.AutoSize = True
        Me.rdoItaukei.Location = New System.Drawing.Point(24, 71)
        Me.rdoItaukei.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdoItaukei.Name = "rdoItaukei"
        Me.rdoItaukei.Size = New System.Drawing.Size(96, 29)
        Me.rdoItaukei.TabIndex = 1
        Me.rdoItaukei.Text = "Itaukei"
        Me.rdoItaukei.UseVisualStyleBackColor = True
        '
        'rdoEnglish
        '
        Me.rdoEnglish.AutoSize = True
        Me.rdoEnglish.Checked = True
        Me.rdoEnglish.Location = New System.Drawing.Point(24, 32)
        Me.rdoEnglish.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rdoEnglish.Name = "rdoEnglish"
        Me.rdoEnglish.Size = New System.Drawing.Size(98, 29)
        Me.rdoEnglish.TabIndex = 0
        Me.rdoEnglish.TabStop = True
        Me.rdoEnglish.Text = "English"
        Me.rdoEnglish.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(171, 770)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(375, 38)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(135, 407)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(485, 69)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'pbDecorativeBorder
        '
        Me.pbDecorativeBorder.BackColor = System.Drawing.Color.Transparent
        Me.pbDecorativeBorder.Image = CType(resources.GetObject("pbDecorativeBorder.Image"), System.Drawing.Image)
        Me.pbDecorativeBorder.Location = New System.Drawing.Point(-6, 0)
        Me.pbDecorativeBorder.Name = "pbDecorativeBorder"
        Me.pbDecorativeBorder.Size = New System.Drawing.Size(753, 909)
        Me.pbDecorativeBorder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbDecorativeBorder.TabIndex = 11
        Me.pbDecorativeBorder.TabStop = False
        '
        'frmWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(744, 889)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grpLanguage)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.pbDecorativeBorder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimizeBox = False
        Me.Name = "frmWelcome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome Page"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLanguage.ResumeLayout(False)
        Me.grpLanguage.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDecorativeBorder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnContinue As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents grpLanguage As GroupBox
    Friend WithEvents rdoFijiHindi As RadioButton
    Friend WithEvents rdoItaukei As RadioButton
    Friend WithEvents rdoEnglish As RadioButton
    Friend WithEvents btnExit As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents pbDecorativeBorder As PictureBox
End Class
