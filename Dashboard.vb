Public Class frmDashboard
    Private currentForm As Form = Nothing

    Private Sub OpenChildForm(childForm As Form)

        If currentForm IsNot Nothing Then
            currentForm.Close()
        End If

        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill

        pnlContent.Controls.Add(childForm)
        pnlContent.Tag = childForm

        childForm.BringToFront()
        childForm.Show()

    End Sub

    Private Sub btnSupplies_Click(sender As Object, e As EventArgs) Handles btnSupplies.Click

        OpenChildForm(New frmSurplus())

    End Sub


    Private loggedInName As String
    Private loggedInRole As String

    Public Sub New(fullName As String, role As String)

        InitializeComponent()

        loggedInName = fullName
        loggedInRole = role

    End Sub

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ApplyLanguage()
        ApplyRolePermissions()

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Dim result As DialogResult = MessageBox.Show(
        "Are you sure you want to logout?",
        "Logout",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    )

        If result = DialogResult.Yes Then

            Dim loginForm As New frmLogin()
            loginForm.Show()

            Me.Close()

        End If

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

    Private Sub btnRecommendation_Click(sender As Object, e As EventArgs) Handles btnRecommendation.Click

        Dim recommendationForm As New frmRecommendationEngine(loggedInRole)

        recommendationForm.TopLevel = False
        recommendationForm.FormBorderStyle = FormBorderStyle.None
        recommendationForm.Dock = DockStyle.Fill

        pnlContent.Controls.Clear()
        pnlContent.Controls.Add(recommendationForm)

        recommendationForm.Show()

    End Sub

    Private Sub btnDistribution_Click(sender As Object, e As EventArgs) Handles btnDistribution.Click

        Dim distributionForm As New frmDistribution(loggedInRole)

        distributionForm.TopLevel = False
        distributionForm.FormBorderStyle = FormBorderStyle.None
        distributionForm.Dock = DockStyle.Fill

        pnlContent.Controls.Clear()
        pnlContent.Controls.Add(distributionForm)

        distributionForm.Show()

    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click

        Dim reportForm As New Report(loggedInRole)

        reportForm.TopLevel = False
        reportForm.FormBorderStyle = FormBorderStyle.None
        reportForm.Dock = DockStyle.Fill

        pnlContent.Controls.Clear()
        pnlContent.Controls.Add(reportForm)

        reportForm.Show()

    End Sub

    Private Sub btnExchange_Click(sender As Object, e As EventArgs) Handles btnExchange.Click

        Dim foodExchangeForm As New frmFoodExchange()

        foodExchangeForm.TopLevel = False
        foodExchangeForm.FormBorderStyle = FormBorderStyle.None
        foodExchangeForm.Dock = DockStyle.Fill

        pnlContent.Controls.Clear()
        pnlContent.Controls.Add(foodExchangeForm)

        foodExchangeForm.Show()

    End Sub

    Private Sub ApplyLanguage()

        If LanguageHelper.CurrentLanguage = "English" Then

            btnSupplies.Text = "Supplies"
            btnRecipients.Text = "Recipients"
            btnRecommendation.Text = "Recommendation"
            btnDistribution.Text = "Distribution"
            btnExchange.Text = "Food Exchange"
            btnReports.Text = "Reports"
            btnLogout.Text = "Logout"

            lblUserLoggedIn.Text = "Logged in: " & loggedInName &
                                  " (" & loggedInRole & ")"

        ElseIf LanguageHelper.CurrentLanguage = "Itaukei" Then

            btnSupplies.Text = "iYau ni Kakana"
            btnRecipients.Text = "O ira e ciqoma"
            btnRecommendation.Text = "Vakatura"
            btnDistribution.Text = "Veisoliyaki"
            btnExchange.Text = "Veisau Kakana"
            btnReports.Text = "Ripote"
            btnLogout.Text = "Curu Yani"

            lblUserLoggedIn.Text = "Curu: " & loggedInName &
                                  " (" & loggedInRole & ")"

        ElseIf LanguageHelper.CurrentLanguage = "Fiji Hindi" Then

            btnSupplies.Text = "Khana Dena"
            btnRecipients.Text = "Khana Lene Wale"
            btnRecommendation.Text = "Sujhav"
            btnDistribution.Text = "Khana Baatna"
            btnExchange.Text = "Khana Exchange"
            btnReports.Text = "Reports"
            btnLogout.Text = "Logout"

            lblUserLoggedIn.Text = "Login: " & loggedInName &
                                  " (" & loggedInRole & ")"

        End If

    End Sub

    Private Sub ApplyRolePermissions()

        If loggedInRole.Equals("Admin", StringComparison.OrdinalIgnoreCase) Then

            btnSupplies.Visible = True
            btnRecipients.Visible = True
            btnRecommendation.Visible = True
            btnDistribution.Visible = True
            btnExchange.Visible = True
            btnBarter.Visible = True
            btnReports.Visible = True

        ElseIf loggedInRole.Equals("Community Organisation", StringComparison.OrdinalIgnoreCase) Then

            btnSupplies.Visible = True
            btnRecipients.Visible = True
            btnRecommendation.Visible = False
            btnDistribution.Visible = False
            btnExchange.Visible = False
            btnBarter.Visible = False
            btnReports.Visible = False

        ElseIf loggedInRole.Equals("User", StringComparison.OrdinalIgnoreCase) Then

            btnSupplies.Visible = False
            btnRecipients.Visible = False
            btnRecommendation.Visible = False
            btnDistribution.Visible = False
            btnExchange.Visible = True
            btnBarter.Visible = True
            btnReports.Visible = False

        End If

    End Sub

    Private Sub btnBarter_Click(sender As Object, e As EventArgs) Handles btnBarter.Click
        Dim barterMenu As New frmBarterMenu()

        barterMenu.TopLevel = False
        barterMenu.FormBorderStyle = FormBorderStyle.None
        barterMenu.Dock = DockStyle.Fill

        pnlContent.Controls.Clear()
        pnlContent.Controls.Add(barterMenu)
        barterMenu.Show()

    End Sub
End Class