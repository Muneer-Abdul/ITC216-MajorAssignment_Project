
Imports System
Imports System.Net
Imports System.Net.Mail

Public Module EmailHelper

    Public Function SendEmail(
        recipientEmail As String,
        subject As String,
        messageBody As String
    ) As Boolean

        Dim senderEmail As String =
            Environment.GetEnvironmentVariable("VITIFOODLINK_EMAIL")

        Dim appPassword As String =
            Environment.GetEnvironmentVariable("VITIFOODLINK_APP_PASSWORD")

        If String.IsNullOrWhiteSpace(senderEmail) OrElse
           String.IsNullOrWhiteSpace(appPassword) Then

            Throw New InvalidOperationException(
                "Viti FoodLink email settings are missing. " &
                "Check your Windows environment variables."
            )
        End If

        If String.IsNullOrWhiteSpace(recipientEmail) Then
            Throw New ArgumentException(
                "The recipient email address is missing."
            )
        End If

        Using mail As New MailMessage()
            mail.From = New MailAddress(senderEmail, "Viti FoodLink")
            mail.To.Add(New MailAddress(recipientEmail))
            mail.Subject = subject
            mail.Body = messageBody
            mail.IsBodyHtml = False

            Using smtp As New SmtpClient("smtp.gmail.com", 587)
                smtp.EnableSsl = True
                smtp.UseDefaultCredentials = False
                smtp.Credentials = New NetworkCredential(
                    senderEmail,
                    appPassword
                )
                smtp.Timeout = 15000

                smtp.Send(mail)
            End Using
        End Using

        Return True

    End Function

End Module
