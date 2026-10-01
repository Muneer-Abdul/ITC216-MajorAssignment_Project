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
        Me.Label1.Location = New System.Drawing.Point(302, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AVAILABLE BARTER"
        '
        'dgvBarter
        '
        Me.dgvBarter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBarter.Location = New System.Drawing.Point(32, 126)
        Me.dgvBarter.Name = "dgvBarter"
        Me.dgvBarter.RowHeadersWidth = 51
        Me.dgvBarter.RowTemplate.Height = 24
        Me.dgvBarter.Size = New System.Drawing.Size(756, 210)
        Me.dgvBarter.TabIndex = 2
        '
        'btnConfirmBarter
        '
        Me.btnConfirmBarter.Location = New System.Drawing.Point(305, 353)
        Me.btnConfirmBarter.Name = "btnConfirmBarter"
        Me.btnConfirmBarter.Size = New System.Drawing.Size(143, 53)
        Me.btnConfirmBarter.TabIndex = 3
        Me.btnConfirmBarter.Text = "Confirm Barter"
        Me.btnConfirmBarter.UseVisualStyleBackColor = True
        '
        'frmViewBarter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnConfirmBarter)
        Me.Controls.Add(Me.dgvBarter)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmViewBarter"
        Me.Text = "View Barter"
        CType(Me.dgvBarter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvBarter As DataGridView
    Friend WithEvents btnConfirmBarter As Button
End Class
