Public Class frmFoodExchange

    Private Sub frmFoodExchange_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        ApplyLanguage()

    End Sub


    Private Sub btnGiveFood_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnGiveFood.Click

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


    Private Sub btnRequestFood_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnRequestFood.Click

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


    Private Sub ApplyLanguage()

        If LanguageHelper.CurrentLanguage = "English" Then

            btnGiveFood.Text = "Give Food"
            'btnBarterExchange.Text = "Barter Exchange"
            btnRequestFood.Text = "Request Food"


        ElseIf LanguageHelper.CurrentLanguage = "Itaukei" Then

            btnGiveFood.Text = "Solia na Kakana"
            'btnBarterExchange.Text = "Veisau Kakana"
            btnRequestFood.Text = "Kerea na Kakana"


        ElseIf LanguageHelper.CurrentLanguage = "Fiji Hindi" Then

            btnGiveFood.Text = "Khana Do"
            'btnBarterExchange.Text = "Khana Badlao"
            btnRequestFood.Text = "Khana Maango"

        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class