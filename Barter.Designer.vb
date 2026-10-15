<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBarter
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCommunity = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.dgvBarter = New System.Windows.Forms.DataGridView()
        Me.btnAddBarter = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtOfferedProduce = New System.Windows.Forms.TextBox()
        Me.txtOfferedQuantity = New System.Windows.Forms.TextBox()
        Me.txtRequestedQuantity = New System.Windows.Forms.TextBox()
        Me.txtRequestedProduce = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        CType(Me.dgvBarter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(945, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "  Food Barter Exchange"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(707, 270)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Community: "
        '
        'txtCommunity
        '
        Me.txtCommunity.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCommunity.Location = New System.Drawing.Point(913, 264)
        Me.txtCommunity.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCommunity.Name = "txtCommunity"
        Me.txtCommunity.Size = New System.Drawing.Size(201, 31)
        Me.txtCommunity.TabIndex = 10
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(751, 503)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(199, 63)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear Fields"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'dgvBarter
        '
        Me.dgvBarter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBarter.Location = New System.Drawing.Point(12, 607)
        Me.dgvBarter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvBarter.Name = "dgvBarter"
        Me.dgvBarter.RowHeadersWidth = 51
        Me.dgvBarter.RowTemplate.Height = 24
        Me.dgvBarter.Size = New System.Drawing.Size(1267, 336)
        Me.dgvBarter.TabIndex = 12
        '
        'btnAddBarter
        '
        Me.btnAddBarter.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnAddBarter.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBarter.ForeColor = System.Drawing.Color.White
        Me.btnAddBarter.Location = New System.Drawing.Point(341, 503)
        Me.btnAddBarter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAddBarter.Name = "btnAddBarter"
        Me.btnAddBarter.Size = New System.Drawing.Size(203, 63)
        Me.btnAddBarter.TabIndex = 13
        Me.btnAddBarter.Text = "Add Barter"
        Me.btnAddBarter.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(116, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Offered Produce:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(116, 344)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Offered Quantity:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(707, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Requested Produce:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(707, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Requested Quantity:"
        '
        'txtOfferedProduce
        '
        Me.txtOfferedProduce.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOfferedProduce.Location = New System.Drawing.Point(292, 267)
        Me.txtOfferedProduce.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtOfferedProduce.Name = "txtOfferedProduce"
        Me.txtOfferedProduce.Size = New System.Drawing.Size(201, 31)
        Me.txtOfferedProduce.TabIndex = 6
        '
        'txtOfferedQuantity
        '
        Me.txtOfferedQuantity.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOfferedQuantity.Location = New System.Drawing.Point(293, 338)
        Me.txtOfferedQuantity.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtOfferedQuantity.Name = "txtOfferedQuantity"
        Me.txtOfferedQuantity.Size = New System.Drawing.Size(201, 31)
        Me.txtOfferedQuantity.TabIndex = 7
        '
        'txtRequestedQuantity
        '
        Me.txtRequestedQuantity.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRequestedQuantity.Location = New System.Drawing.Point(913, 202)
        Me.txtRequestedQuantity.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRequestedQuantity.Name = "txtRequestedQuantity"
        Me.txtRequestedQuantity.Size = New System.Drawing.Size(201, 31)
        Me.txtRequestedQuantity.TabIndex = 9
        '
        'txtRequestedProduce
        '
        Me.txtRequestedProduce.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRequestedProduce.Location = New System.Drawing.Point(913, 134)
        Me.txtRequestedProduce.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRequestedProduce.Name = "txtRequestedProduce"
        Me.txtRequestedProduce.Size = New System.Drawing.Size(201, 31)
        Me.txtRequestedProduce.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(116, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 25)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Person Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(116, 208)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(143, 25)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Contact Number"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(293, 134)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(201, 31)
        Me.txtName.TabIndex = 16
        '
        'txtNumber
        '
        Me.txtNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber.Location = New System.Drawing.Point(293, 202)
        Me.txtNumber.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(201, 31)
        Me.txtNumber.TabIndex = 17
        '
        'frmBarter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1291, 956)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnAddBarter)
        Me.Controls.Add(Me.dgvBarter)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtCommunity)
        Me.Controls.Add(Me.txtRequestedQuantity)
        Me.Controls.Add(Me.txtRequestedProduce)
        Me.Controls.Add(Me.txtOfferedQuantity)
        Me.Controls.Add(Me.txtOfferedProduce)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmBarter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barter"
        CType(Me.dgvBarter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCommunity As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents dgvBarter As DataGridView
    Friend WithEvents btnAddBarter As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtOfferedProduce As TextBox
    Friend WithEvents txtOfferedQuantity As TextBox
    Friend WithEvents txtRequestedQuantity As TextBox
    Friend WithEvents txtRequestedProduce As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtNumber As TextBox
End Class
