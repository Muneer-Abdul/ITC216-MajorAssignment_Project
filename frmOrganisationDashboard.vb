Public Class frmOrganisationDashboard

    Private loggedInUserID As Integer
    Private loggedInName As String
    Private loggedInRole As String

    Public Sub New(userID As Integer, fullName As String, role As String)

        InitializeComponent()

        loggedInUserID = userID
        loggedInName = fullName
        loggedInRole = role

    End Sub

    Private Sub frmOrganisationDashboard_Load(
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

    Private Sub btnSupplies_Click(sender As Object, e As EventArgs) Handles btnSupplies.Click

        Dim suppliesForm As New frmSurplus()

        suppliesForm.TopLevel = False
        suppliesForm.FormBorderStyle = FormBorderStyle.None
        suppliesForm.Dock = DockStyle.Fill

        pnlContent.Controls.Clear()
        pnlContent.Controls.Add(suppliesForm)

        suppliesForm.Show()

    End Sub

    Private Sub btnRecipients_Click(sender As Object, e As EventArgs) Handles btnRecipients.Click

        Dim recipientsForm As New frmRecipients()

        recipientsForm.TopLevel = False
        recipientsForm.FormBorderStyle = FormBorderStyle.None
        recipientsForm.Dock = DockStyle.Fill

        pnlContent.Controls.Clear()
        pnlContent.Controls.Add(recipientsForm)

        recipientsForm.Show()

    End Sub

    Private Sub btnFoodRequests_Click(sender As Object, e As EventArgs) Handles btnFoodRequests.Click

        Dim requestForm As New frmFoodRequest()

        requestForm.TopLevel = False
        requestForm.FormBorderStyle = FormBorderStyle.None
        requestForm.Dock = DockStyle.Fill

        pnlContent.Controls.Clear()
        pnlContent.Controls.Add(requestForm)

        requestForm.Show()

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        frmLogin.Show()
        Me.Close()

    End Sub

    Private Sub picProfile_Click(sender As Object, e As EventArgs) Handles picProfile.Click

        Dim profileForm As New frmUserProfile(loggedInUserID)

        profileForm.TopLevel = False
        profileForm.FormBorderStyle = FormBorderStyle.None
        profileForm.Dock = DockStyle.Fill

        pnlContent.Controls.Clear()
        pnlContent.Controls.Add(profileForm)

        profileForm.Show()

    End Sub

    Private Sub picVitiBot_Click(sender As Object, e As EventArgs) Handles picVitiBot.Click

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

            lblTitle.Text = "Community Organisation Dashboard"
            btnSupplies.Text = "&Supplies"
            btnRecipients.Text = "&Recipients"
            'btnFoodExchange.Text = "Food Exchange"
            btnFoodRequests.Text = "&Food Requests"
            btnLogout.Text = "&Logout"

        ElseIf LanguageHelper.CurrentLanguage = "Itaukei" Then

            lblTitle.Text = "Dashboard ni Mataisoqosoqo ni Veiqaravi"
            btnSupplies.Text = "iYau"
            btnRecipients.Text = "Dauciqomi"
            'btnFoodExchange.Text = "Veisau Kakana"
            btnFoodRequests.Text = "Kerekere ni Kakana"
            btnLogout.Text = "Curu i Tuba"

        ElseIf LanguageHelper.CurrentLanguage = "Fiji Hindi" Then

            lblTitle.Text = "Community Organisation Dashboard"
            btnSupplies.Text = "Food Supplies"
            btnRecipients.Text = "Recipients"
            'btnFoodExchange.Text = "Food Exchange"
            btnFoodRequests.Text = "Food Requests"
            btnLogout.Text = "Logout"

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmLogin.Show()
        Me.Close()
    End Sub

End Class