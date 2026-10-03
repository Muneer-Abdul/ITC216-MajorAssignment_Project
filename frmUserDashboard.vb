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

        lblWelcome.Text = "Welcome, " & loggedInName

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

        Dim barterMenu As New frmBarterMenu()

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

End Class