Public Class frmFoodExchange
    Private Sub btnGiveFood_Click(sender As Object, e As EventArgs) Handles btnGiveFood.Click


        Dim surplusForm As New frmSurplus()

        surplusForm.TopLevel = False
        surplusForm.FormBorderStyle = FormBorderStyle.None
        surplusForm.Dock = DockStyle.Fill

        Dim parentPanel As Control = Me.Parent

        If parentPanel IsNot Nothing Then

            parentPanel.Controls.Clear()
            parentPanel.Controls.Add(surplusForm)

            surplusForm.Show()

        End If

    End Sub

    Private Sub btnBarterExchange_Click(sender As Object, e As EventArgs) Handles btnBarterExchange.Click

        Dim barterForm As New frmBarter()

        barterForm.TopLevel = False
        barterForm.FormBorderStyle = FormBorderStyle.None
        barterForm.Dock = DockStyle.Fill

        Dim parentPanel As Control = Me.Parent

        If parentPanel IsNot Nothing Then

            parentPanel.Controls.Clear()
            parentPanel.Controls.Add(barterForm)

            barterForm.Show()

        End If

    End Sub

    Private Sub btnRequestFood_Click(sender As Object, e As EventArgs) Handles btnRequestFood.Click


        Dim requestForm As New frmFoodRequest()

        requestForm.TopLevel = False
        requestForm.FormBorderStyle = FormBorderStyle.None
        requestForm.Dock = DockStyle.Fill

        Dim parentPanel As Control = Me.Parent

        If parentPanel IsNot Nothing Then

            parentPanel.Controls.Clear()
            parentPanel.Controls.Add(requestForm)

            requestForm.Show()

        End If

    End Sub
End Class