<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewBarter
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
        Me.dgvBarter = New System.Windows.Forms.DataGridView()
        Me.btnConfirmBarter = New System.Windows.Forms.Button()
        CType(Me.dgvBarter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(1047, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Available Barter"
        '
        'dgvBarter
        '
        Me.dgvBarter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvBarter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBarter.EnableHeadersVisualStyles = False
        Me.dgvBarter.Location = New System.Drawing.Point(29, 189)
        Me.dgvBarter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvBarter.Name = "dgvBarter"
        Me.dgvBarter.RowHeadersWidth = 51
        Me.dgvBarter.RowTemplate.Height = 24
        Me.dgvBarter.Size = New System.Drawing.Size(1233, 484)
        Me.dgvBarter.TabIndex = 2
        '
        'btnConfirmBarter
        '
        Me.btnConfirmBarter.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnConfirmBarter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmBarter.ForeColor = System.Drawing.Color.White
        Me.btnConfirmBarter.Location = New System.Drawing.Point(585, 773)
        Me.btnConfirmBarter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnConfirmBarter.Name = "btnConfirmBarter"
        Me.btnConfirmBarter.Size = New System.Drawing.Size(161, 66)
        Me.btnConfirmBarter.TabIndex = 0
        Me.btnConfirmBarter.Text = "Confirm Barter"
        Me.btnConfirmBarter.UseVisualStyleBackColor = False
        '
        'frmViewBarter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1292, 959)
        Me.Controls.Add(Me.btnConfirmBarter)
        Me.Controls.Add(Me.dgvBarter)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmViewBarter"
        Me.Text = "  "
        CType(Me.dgvBarter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnConfirmBarter As Button
    Protected WithEvents dgvBarter As DataGridView
End Class
