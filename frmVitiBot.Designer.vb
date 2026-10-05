<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVitiBot
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.rtbChat = New System.Windows.Forms.RichTextBox()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(209, 29)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(194, 16)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "VitiBot — Viti FoodLink Assistant"
        '
        'rtbChat
        '
        Me.rtbChat.Location = New System.Drawing.Point(100, 68)
        Me.rtbChat.Name = "rtbChat"
        Me.rtbChat.ReadOnly = True
        Me.rtbChat.Size = New System.Drawing.Size(363, 238)
        Me.rtbChat.TabIndex = 1
        Me.rtbChat.Text = ""
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(100, 355)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(168, 22)
        Me.txtMessage.TabIndex = 2
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(241, 430)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(106, 62)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(298, 355)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(107, 32)
        Me.btnSend.TabIndex = 4
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'frmVitiBot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 555)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.rtbChat)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmVitiBot"
        Me.Text = "frmVitiBot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents rtbChat As RichTextBox
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSend As Button
End Class
