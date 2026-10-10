<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBarterMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBarterMenu))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddBarter = New System.Windows.Forms.Button()
        Me.btnViewBarter = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbloption = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(1056, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FOOD BARTER"
        '
        'btnAddBarter
        '
        Me.btnAddBarter.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnAddBarter.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBarter.ForeColor = System.Drawing.Color.White
        Me.btnAddBarter.Location = New System.Drawing.Point(231, 388)
        Me.btnAddBarter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAddBarter.Name = "btnAddBarter"
        Me.btnAddBarter.Size = New System.Drawing.Size(336, 129)
        Me.btnAddBarter.TabIndex = 1
        Me.btnAddBarter.Text = "ADD BARTER"
        Me.btnAddBarter.UseVisualStyleBackColor = False
        '
        'btnViewBarter
        '
        Me.btnViewBarter.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnViewBarter.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewBarter.ForeColor = System.Drawing.Color.White
        Me.btnViewBarter.Location = New System.Drawing.Point(701, 388)
        Me.btnViewBarter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnViewBarter.Name = "btnViewBarter"
        Me.btnViewBarter.Size = New System.Drawing.Size(336, 129)
        Me.btnViewBarter.TabIndex = 2
        Me.btnViewBarter.Text = "VIEW BARTER"
        Me.btnViewBarter.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(381, 396)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(848, 396)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(45, 41)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'lbloption
        '
        Me.lbloption.AutoSize = True
        Me.lbloption.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbloption.Location = New System.Drawing.Point(500, 318)
        Me.lbloption.Name = "lbloption"
        Me.lbloption.Size = New System.Drawing.Size(272, 28)
        Me.lbloption.TabIndex = 6
        Me.lbloption.Text = "Choose an option to continue"
        '
        'frmBarterMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1289, 959)
        Me.Controls.Add(Me.lbloption)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnViewBarter)
        Me.Controls.Add(Me.btnAddBarter)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmBarterMenu"
        Me.Text = "BarterMenu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddBarter As Button
    Friend WithEvents btnViewBarter As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lbloption As Label
End Class
