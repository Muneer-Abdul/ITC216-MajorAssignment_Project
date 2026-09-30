Public Class frmBarterMenu
    Private Sub btnAddBarter_Click(sender As Object, e As EventArgs) Handles btnAddBarter.Click
        Dim barterForm As New frmBarter()

        barterForm.TopLevel = False
        barterForm.FormBorderStyle = FormBorderStyle.None
        barterForm.Dock = DockStyle.Fill

        Me.Controls.Clear()
        Me.Controls.Add(barterForm)
        barterForm.Show()

    End Sub

    Private Sub btnViewBarter_Click(sender As Object, e As EventArgs) Handles btnViewBarter.Click

        Dim viewBarterForm As New frmViewBarter()

        viewBarterForm.TopLevel = False
        viewBarterForm.FormBorderStyle = FormBorderStyle.None
        viewBarterForm.Dock = DockStyle.Fill

        Me.Controls.Clear()
        Me.Controls.Add(viewBarterForm)
        viewBarterForm.Show()

    End Sub
End Class