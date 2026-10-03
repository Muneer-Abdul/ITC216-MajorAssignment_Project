Public Class frmOrganisationDashboard

    Private loggedInName As String
    Private loggedInRole As String

    Public Sub New(fullName As String, role As String)

        InitializeComponent()

        loggedInName = fullName
        loggedInRole = role

    End Sub

    Private Sub frmOrganisationDashboard_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        lblWelcome.Text = "Welcome, " & loggedInName

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

    Private Sub btnFoodExchange_Click(sender As Object, e As EventArgs) Handles btnFoodExchange.Click

        Dim exchangeForm As New frmFoodExchange()

        exchangeForm.TopLevel = False
        exchangeForm.FormBorderStyle = FormBorderStyle.None
        exchangeForm.Dock = DockStyle.Fill

        pnlContent.Controls.Clear()
        pnlContent.Controls.Add(exchangeForm)

        exchangeForm.Show()

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
End Class