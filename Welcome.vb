Public Class frmWelcome

    Private Sub frmWelcome_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        ' Initialize and update the database
        ' every time the application starts.
        InitializeDatabase()

    End Sub


    Private Sub btnContinue_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnContinue.Click

        If rdoEnglish.Checked Then

            LanguageHelper.CurrentLanguage = "English"

        ElseIf rdoItaukei.Checked Then

            LanguageHelper.CurrentLanguage = "Itaukei"

        ElseIf rdoFijiHindi.Checked Then

            LanguageHelper.CurrentLanguage = "Fiji Hindi"

        Else

            MessageBox.Show(
                "Please select a language.",
                "Language Selection",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return

        End If

        Dim loginForm As New frmLogin()

        loginForm.Show()
        Me.Hide()

    End Sub


    Private Sub btnExit_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnExit.Click

        Dim result As DialogResult

        result = MessageBox.Show(
            "Are you sure you want to exit Viti FoodLink?",
            "Exit Application",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result = DialogResult.Yes Then

            Application.Exit()

        End If

    End Sub

End Class