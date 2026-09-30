<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFoodExchange
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
        Me.btnGiveFood = New System.Windows.Forms.Button()
        Me.btnRequestFood = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGiveFood
        '
        Me.btnGiveFood.Location = New System.Drawing.Point(301, 101)
        Me.btnGiveFood.Name = "btnGiveFood"
        Me.btnGiveFood.Size = New System.Drawing.Size(127, 69)
        Me.btnGiveFood.TabIndex = 0
        Me.btnGiveFood.Text = "GIVE FOOD"
        Me.btnGiveFood.UseVisualStyleBackColor = True
        '
        'btnRequestFood
        '
        Me.btnRequestFood.Location = New System.Drawing.Point(301, 206)
        Me.btnRequestFood.Name = "btnRequestFood"
        Me.btnRequestFood.Size = New System.Drawing.Size(127, 69)
        Me.btnRequestFood.TabIndex = 1
        Me.btnRequestFood.Text = "REQUEST FOOD"
        Me.btnRequestFood.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(310, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = " FOOD EXCHANGE "
        '
        'frmFoodExchange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRequestFood)
        Me.Controls.Add(Me.btnGiveFood)
        Me.Name = "frmFoodExchange"
        Me.Text = "FoodExchange"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGiveFood As Button
    Friend WithEvents btnRequestFood As Button
    Friend WithEvents Label1 As Label
End Class
