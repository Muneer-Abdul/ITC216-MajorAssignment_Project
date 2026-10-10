<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFoodExchange
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFoodExchange))
        Me.btnGiveFood = New System.Windows.Forms.Button()
        Me.btnRequestFood = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbloption = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGiveFood
        '
        Me.btnGiveFood.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnGiveFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGiveFood.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGiveFood.ForeColor = System.Drawing.Color.White
        Me.btnGiveFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGiveFood.Location = New System.Drawing.Point(230, 391)
        Me.btnGiveFood.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGiveFood.Name = "btnGiveFood"
        Me.btnGiveFood.Size = New System.Drawing.Size(336, 129)
        Me.btnGiveFood.TabIndex = 0
        Me.btnGiveFood.Text = "GIVE FOOD"
        Me.btnGiveFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGiveFood.UseVisualStyleBackColor = False
        '
        'btnRequestFood
        '
        Me.btnRequestFood.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnRequestFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRequestFood.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRequestFood.ForeColor = System.Drawing.Color.White
        Me.btnRequestFood.Location = New System.Drawing.Point(725, 391)
        Me.btnRequestFood.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRequestFood.Name = "btnRequestFood"
        Me.btnRequestFood.Size = New System.Drawing.Size(336, 129)
        Me.btnRequestFood.TabIndex = 1
        Me.btnRequestFood.Text = "REQUEST FOOD"
        Me.btnRequestFood.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(1050, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 38)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = " Food Exchange"
        '
        'lbloption
        '
        Me.lbloption.AutoSize = True
        Me.lbloption.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbloption.Location = New System.Drawing.Point(508, 318)
        Me.lbloption.Name = "lbloption"
        Me.lbloption.Size = New System.Drawing.Size(272, 28)
        Me.lbloption.TabIndex = 5
        Me.lbloption.Text = "Choose an option to continue"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(873, 398)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(380, 398)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(43, 38)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'frmFoodExchange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1293, 959)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbloption)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRequestFood)
        Me.Controls.Add(Me.btnGiveFood)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmFoodExchange"
        Me.Text = "FoodExchange"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGiveFood As Button
    Friend WithEvents btnRequestFood As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lbloption As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
