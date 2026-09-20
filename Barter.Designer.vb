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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtOfferedProduce = New System.Windows.Forms.TextBox()
        Me.txtOfferedQuantity = New System.Windows.Forms.TextBox()
        Me.txtRequestedProduce = New System.Windows.Forms.TextBox()
        Me.txtRequestedQuantity = New System.Windows.Forms.TextBox()
        Me.txtCommunity = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.dgvBarter = New System.Windows.Forms.DataGridView()
        Me.btnAddBarter = New System.Windows.Forms.Button()
        CType(Me.dgvBarter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(396, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "  FOOD BARTER EXCHANGE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Offered Produce:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Offered Quantity:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Requested Produce:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Requested Quantity:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(51, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Community: "
        '
        'txtOfferedProduce
        '
        Me.txtOfferedProduce.Location = New System.Drawing.Point(219, 65)
        Me.txtOfferedProduce.Name = "txtOfferedProduce"
        Me.txtOfferedProduce.Size = New System.Drawing.Size(120, 22)
        Me.txtOfferedProduce.TabIndex = 6
        '
        'txtOfferedQuantity
        '
        Me.txtOfferedQuantity.Location = New System.Drawing.Point(219, 100)
        Me.txtOfferedQuantity.Name = "txtOfferedQuantity"
        Me.txtOfferedQuantity.Size = New System.Drawing.Size(120, 22)
        Me.txtOfferedQuantity.TabIndex = 7
        '
        'txtRequestedProduce
        '
        Me.txtRequestedProduce.Location = New System.Drawing.Point(219, 141)
        Me.txtRequestedProduce.Name = "txtRequestedProduce"
        Me.txtRequestedProduce.Size = New System.Drawing.Size(120, 22)
        Me.txtRequestedProduce.TabIndex = 8
        '
        'txtRequestedQuantity
        '
        Me.txtRequestedQuantity.Location = New System.Drawing.Point(219, 171)
        Me.txtRequestedQuantity.Name = "txtRequestedQuantity"
        Me.txtRequestedQuantity.Size = New System.Drawing.Size(120, 22)
        Me.txtRequestedQuantity.TabIndex = 9
        '
        'txtCommunity
        '
        Me.txtCommunity.Location = New System.Drawing.Point(219, 210)
        Me.txtCommunity.Name = "txtCommunity"
        Me.txtCommunity.Size = New System.Drawing.Size(120, 22)
        Me.txtCommunity.TabIndex = 10
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(623, 126)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(104, 52)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear Fields"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'dgvBarter
        '
        Me.dgvBarter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBarter.Location = New System.Drawing.Point(46, 266)
        Me.dgvBarter.Name = "dgvBarter"
        Me.dgvBarter.RowHeadersWidth = 51
        Me.dgvBarter.RowTemplate.Height = 24
        Me.dgvBarter.Size = New System.Drawing.Size(789, 184)
        Me.dgvBarter.TabIndex = 12
        '
        'btnAddBarter
        '
        Me.btnAddBarter.Location = New System.Drawing.Point(458, 127)
        Me.btnAddBarter.Name = "btnAddBarter"
        Me.btnAddBarter.Size = New System.Drawing.Size(104, 51)
        Me.btnAddBarter.TabIndex = 13
        Me.btnAddBarter.Text = "Add Barter"
        Me.btnAddBarter.UseVisualStyleBackColor = True
        '
        'frmBarter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 462)
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
        Me.Name = "frmBarter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barter"
        CType(Me.dgvBarter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtOfferedProduce As TextBox
    Friend WithEvents txtOfferedQuantity As TextBox
    Friend WithEvents txtRequestedProduce As TextBox
    Friend WithEvents txtRequestedQuantity As TextBox
    Friend WithEvents txtCommunity As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents dgvBarter As DataGridView
    Friend WithEvents btnAddBarter As Button
End Class
