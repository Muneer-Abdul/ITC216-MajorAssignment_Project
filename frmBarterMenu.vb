Public Class frmBarterMenu

    Private Sub frmBarterMenu_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        ApplyLanguage()

    End Sub


    Private Sub btnAddBarter_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnAddBarter.Click

        Dim barterForm As New frmBarter()

        barterForm.TopLevel = False
        barterForm.FormBorderStyle = FormBorderStyle.None
        barterForm.Dock = DockStyle.Fill

        Me.Controls.Clear()
        Me.Controls.Add(barterForm)

        barterForm.Show()

    End Sub


    Private Sub btnViewBarter_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnViewBarter.Click

        Dim viewBarterForm As New frmViewBarter()

        viewBarterForm.TopLevel = False
        viewBarterForm.FormBorderStyle = FormBorderStyle.None
        viewBarterForm.Dock = DockStyle.Fill

        Me.Controls.Clear()
        Me.Controls.Add(viewBarterForm)

        viewBarterForm.Show()

    End Sub


    Private Sub ApplyLanguage()

        If LanguageHelper.CurrentLanguage = "English" Then

            Label1.Text = "Barter Menu"
            btnAddBarter.Text = "&Add Barter"
            btnViewBarter.Text = "&View Barter"


        ElseIf LanguageHelper.CurrentLanguage = "Itaukei" Then

            Label1.Text = "Menu ni Veisau"
            btnAddBarter.Text = "Vakuria na Veisau"
            btnViewBarter.Text = "Raica na Veisau"


        ElseIf LanguageHelper.CurrentLanguage = "Fiji Hindi" Then

            Label1.Text = "Barter Menu"
            btnAddBarter.Text = "Barter Add Karo"
            btnViewBarter.Text = "Barter Dekho"

        End If

    End Sub

End Class