Public Class frmUserDashboard

    Private loggedInUserID As Integer
    Private loggedInName As String
    Private loggedInRole As String

    Public Sub New(userID As Integer, fullName As String, role As String)

        InitializeComponent()

        loggedInUserID = userID
        loggedInName = fullName
        loggedInRole = role

    End Sub


    Private Sub frmUserDashboard_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        ApplyLanguage()

        If LanguageHelper.CurrentLanguage = "English" Then
            lblWelcome.Text = "Welcome, " & loggedInName

        ElseIf LanguageHelper.CurrentLanguage = "Itaukei" Then
            lblWelcome.Text = "Bula, " & loggedInName

        ElseIf LanguageHelper.CurrentLanguage = "Fiji Hindi" Then
            lblWelcome.Text = "Namaste, " & loggedInName
        End If

    End Sub


    Private Sub btnGiveFood_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnGiveFood.Click

        Dim suppliesForm As New frmSurplus()

        suppliesForm.TopLevel = False
        suppliesForm.FormBorderStyle = FormBorderStyle.None
        suppliesForm.Dock = DockStyle.Fill

        pnlContent.Controls.Clear()
        pnlContent.Controls.Add(suppliesForm)

        suppliesForm.Show()

    End Sub


    Private Sub btnRequestFood_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnRequestFood.Click

        Dim requestForm As New frmFoodRequest()

        requestForm.TopLevel = False
        requestForm.FormBorderStyle = FormBorderStyle.None
        requestForm.Dock = DockStyle.Fill

        pnlContent.Controls.Clear()
        pnlContent.Controls.Add(requestForm)

        requestForm.Show()

    End Sub


    Private Sub btnBarter_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnBarter.Click

        Dim barterMenu As New frmBarterMenu(loggedInUserID, loggedInName)

        barterMenu.TopLevel = False
        barterMenu.FormBorderStyle = FormBorderStyle.None
        barterMenu.Dock = DockStyle.Fill

        pnlContent.Controls.Clear()
        pnlContent.Controls.Add(barterMenu)

        barterMenu.Show()

    End Sub


    Private Sub btnLogout_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnLogout.Click

        frmLogin.Show()
        Me.Close()

    End Sub


    Private Sub picProfile_Click(
        sender As Object,
        e As EventArgs
    ) Handles picProfile.Click

        Dim profileForm As New frmUserProfile(loggedInUserID)

        profileForm.TopLevel = False
        profileForm.FormBorderStyle = FormBorderStyle.None
        profileForm.Dock = DockStyle.Fill

        pnlContent.Controls.Clear()
        pnlContent.Controls.Add(profileForm)

        profileForm.Show()

    End Sub


    Private Sub picVitiBot_Click(
        sender As Object,
        e As EventArgs
    ) Handles picVitiBot.Click

        Dim botForm As New frmVitiBot(loggedInRole)

        botForm.TopLevel = False
        botForm.FormBorderStyle = FormBorderStyle.None
        botForm.Dock = DockStyle.Fill

        pnlContent.Controls.Clear()
        pnlContent.Controls.Add(botForm)

        botForm.Show()

    End Sub


    Private Sub ApplyLanguage()

        If LanguageHelper.CurrentLanguage = "English" Then

            lblTitle.Text = "User Dashboard"
            btnGiveFood.Text = "&Give Food"
            btnRequestFood.Text = "&Request Food"
            btnBarter.Text = "&Barter"
            btnLogout.Text = "&Logout"


        ElseIf LanguageHelper.CurrentLanguage = "Itaukei" Then

            lblTitle.Text = "Dashboard ni Vakayagataki"
            btnGiveFood.Text = "Solia na Kakana"
            btnRequestFood.Text = "Kerea na Kakana"
            btnBarter.Text = "Veisau"
            btnLogout.Text = "Curu i Tuba"


        ElseIf LanguageHelper.CurrentLanguage = "Fiji Hindi" Then

            lblTitle.Text = "User Dashboard"
            btnGiveFood.Text = "Khana Do"
            btnRequestFood.Text = "Khana Maango"
            btnBarter.Text = "Badlao"
            btnLogout.Text = "Logout"

        End If

    End Sub

End Class