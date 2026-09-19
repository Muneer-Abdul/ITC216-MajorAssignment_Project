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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLanguage.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(494, 659)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(79, 71)
        Me.btnContinue.TabIndex = 0
        Me.btnContinue.Text = "Continue To Login"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(273, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Viti FoodLink"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(245, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(154, 123)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(197, 263)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(270, 62)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Reduce food waste, support communities, and share resources through Viti FoodLink" &
    "."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(220, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(260, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Connecting Surplus Food with communities"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(220, 364)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = " Select Your Language "
        '
        'grpLanguage
        '
        Me.grpLanguage.Controls.Add(Me.rdoFijiHindi)
        Me.grpLanguage.Controls.Add(Me.rdoItaukei)
        Me.grpLanguage.Controls.Add(Me.rdoEnglish)
        Me.grpLanguage.Location = New System.Drawing.Point(202, 419)
        Me.grpLanguage.Name = "grpLanguage"
        Me.grpLanguage.Size = New System.Drawing.Size(197, 158)
        Me.grpLanguage.TabIndex = 6
        Me.grpLanguage.TabStop = False
        Me.grpLanguage.Text = "GroupBox1"
        '
        'rdoFijiHindi
        '
        Me.rdoFijiHindi.AutoSize = True
        Me.rdoFijiHindi.Location = New System.Drawing.Point(21, 87)
        Me.rdoFijiHindi.Name = "rdoFijiHindi"
        Me.rdoFijiHindi.Size = New System.Drawing.Size(79, 20)
        Me.rdoFijiHindi.TabIndex = 2
        Me.rdoFijiHindi.Text = "Fiji Hindi"
        Me.rdoFijiHindi.UseVisualStyleBackColor = True
        '
        'rdoItaukei
        '
        Me.rdoItaukei.AutoSize = True
        Me.rdoItaukei.Location = New System.Drawing.Point(21, 61)
        Me.rdoItaukei.Name = "rdoItaukei"
        Me.rdoItaukei.Size = New System.Drawing.Size(67, 20)
        Me.rdoItaukei.TabIndex = 1
        Me.rdoItaukei.Text = "Itaukei"
        Me.rdoItaukei.UseVisualStyleBackColor = True
        '
        'rdoEnglish
        '
        Me.rdoEnglish.AutoSize = True
        Me.rdoEnglish.Checked = True
        Me.rdoEnglish.Location = New System.Drawing.Point(21, 35)
        Me.rdoEnglish.Name = "rdoEnglish"
        Me.rdoEnglish.Size = New System.Drawing.Size(72, 20)
        Me.rdoEnglish.TabIndex = 0
        Me.rdoEnglish.TabStop = True
        Me.rdoEnglish.Text = "English"
        Me.rdoEnglish.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(92, 672)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(82, 45)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 953)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grpLanguage)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnContinue)
        Me.Name = "frmWelcome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome Page"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLanguage.ResumeLayout(False)
        Me.grpLanguage.PerformLayout()
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
End Class
