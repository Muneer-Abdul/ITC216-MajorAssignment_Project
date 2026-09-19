Public Class frmWelcome


    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click

        If Not (rdoEnglish.Checked OrElse
            rdoItaukei.Checked OrElse
            rdoFijiHindi.Checked) Then

            MessageBox.Show("Please select a language.")
            Return

        End If

        Dim loginForm As New frmLogin()
        loginForm.Show()
        Me.Hide()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub frmWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        InitializeDatabase()

    End Sub
End Class
