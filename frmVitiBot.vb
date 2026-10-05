Public Class frmVitiBot

    Private loggedInRole As String = "User"

    Public Sub New(role As String)
        InitializeComponent()
        loggedInRole = role
    End Sub

    Private Sub frmVitiBot_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        rtbChat.ReadOnly = True

        rtbChat.Clear()

        rtbChat.SelectionColor = Color.DarkGreen
        rtbChat.SelectionFont = New Font(rtbChat.Font, FontStyle.Bold)

        rtbChat.AppendText("VitiBot" & Environment.NewLine)

        rtbChat.SelectionColor = Color.Black
        rtbChat.SelectionFont = New Font(rtbChat.Font, FontStyle.Regular)

        rtbChat.AppendText(
        "Hello! I am the Viti FoodLink Assistant." &
        Environment.NewLine &
        "I can help you with the features and functions of Viti FoodLink." &
        Environment.NewLine &
        Environment.NewLine &
        "Try asking:" &
        Environment.NewLine &
        "• How do I give food?" &
        Environment.NewLine &
        "• How do I request food?" &
        Environment.NewLine &
        "• What is the barter system?" &
        Environment.NewLine &
        "• What can I do?" &
        Environment.NewLine &
        Environment.NewLine
    )

        txtMessage.Focus()

    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click

        Dim question As String = txtMessage.Text.Trim()

        If question = "" Then
            Return
        End If

        ' Display user's message
        rtbChat.SelectionColor = Color.DarkBlue
        rtbChat.SelectionFont = New Font(rtbChat.Font, FontStyle.Bold)

        rtbChat.AppendText("You" & Environment.NewLine)

        rtbChat.SelectionColor = Color.Black
        rtbChat.SelectionFont = New Font(rtbChat.Font, FontStyle.Regular)

        rtbChat.AppendText(question & Environment.NewLine & Environment.NewLine)

        ' Get VitiBot response
        Dim answer As String = GetBotResponse(question)

        ' Display VitiBot response
        rtbChat.SelectionColor = Color.DarkGreen
        rtbChat.SelectionFont = New Font(rtbChat.Font, FontStyle.Bold)

        rtbChat.AppendText("VitiBot" & Environment.NewLine)

        rtbChat.SelectionColor = Color.Black
        rtbChat.SelectionFont = New Font(rtbChat.Font, FontStyle.Regular)

        rtbChat.AppendText(answer & Environment.NewLine & Environment.NewLine)

        ' Scroll to latest message
        rtbChat.SelectionStart = rtbChat.Text.Length
        rtbChat.ScrollToCaret()

        txtMessage.Clear()
        txtMessage.Focus()

    End Sub

    Private Function GetBotResponse(question As String) As String

        Dim q As String = question.ToLower().Trim()

        ' ABOUT VITI FOODLINK
        If q.Contains("what is viti foodlink") OrElse
           q.Contains("what is viti") OrElse
           q.Contains("about viti foodlink") Then

            Return "Viti FoodLink is a community-based food management system designed to help manage surplus food, food requests, recipients, food distribution and food barter."

        End If


        ' GIVE FOOD
        If q.Contains("give food") OrElse
           q.Contains("donate food") OrElse
           q.Contains("surplus food") OrElse
           q.Contains("add surplus") Then

            Return "To give surplus food, open the Give Food or Supplies section. Enter the produce name, quantity, donor information, expiry date, source and community, then save the record."

        End If


        ' REQUEST FOOD
        If q.Contains("request food") OrElse
           q.Contains("need food") OrElse
           q.Contains("food request") Then

            Return "To request food, open Request Food. Enter your name, the food needed, quantity, recipient type, community, urgency and reason for the request, then submit it."

        End If


        ' BARTER
        If q.Contains("barter") OrElse
           q.Contains("exchange food") Then

            Return "The Viti FoodLink barter system allows users to offer one type of produce in exchange for another type of produce. You can add a barter offer and view available barter records."

        End If


        ' RECIPIENTS
        If q.Contains("recipient") OrElse
           q.Contains("add recipient") Then

            If loggedInRole.Equals("Admin", StringComparison.OrdinalIgnoreCase) OrElse
               loggedInRole.Equals("Community Organisation", StringComparison.OrdinalIgnoreCase) Then

                Return "Recipients can be managed from the Recipients section. You can add recipient information such as name, organisation, contact number, community, location and recipient type."

            Else

                Return "Recipient management is available to administrators and community organisations."

            End If

        End If


        ' RECOMMENDATION
        If q.Contains("recommendation") OrElse
           q.Contains("recommend") Then

            If loggedInRole.Equals("Admin", StringComparison.OrdinalIgnoreCase) Then

                Return "The Recommendation Engine helps the administrator identify suitable recipients for available surplus produce based on recipient type and community."

            Else

                Return "The Recommendation Engine is an administrator feature in Viti FoodLink."

            End If

        End If


        ' DISTRIBUTION
        If q.Contains("distribution") OrElse
           q.Contains("distribute food") Then

            If loggedInRole.Equals("Admin", StringComparison.OrdinalIgnoreCase) Then

                Return "The Distribution section allows the administrator to record the distribution of available produce to recipients and track the distribution method and date."

            Else

                Return "Food distribution is managed by the administrator."

            End If

        End If


        ' REPORTS
        If q.Contains("report") OrElse
           q.Contains("reports") Then

            If loggedInRole.Equals("Admin", StringComparison.OrdinalIgnoreCase) Then

                Return "The Reports section provides information about available produce, distributed produce, recipients and distribution records. Reports can also be filtered and exported."

            Else

                Return "Reports are available to administrators only."

            End If

        End If


        ' ADMIN
        If q.Contains("admin") OrElse
           q.Contains("administrator") Then

            Return "The administrator manages the main Viti FoodLink operations, including supplies, recipients, recommendations, food distribution, reports, food exchange and barter records."

        End If


        ' COMMUNITY ORGANISATION
        If q.Contains("community organisation") OrElse
           q.Contains("community organization") Then

            Return "Community organisations can manage supplies and recipients and use food-related functions available through their organisation dashboard."

        End If


        ' USER
        If q.Contains("user") OrElse
           q.Contains("my dashboard") Then

            Return "Users can give surplus food, request food, use the barter system and manage their profile."

        End If


        ' PROFILE
        If q.Contains("profile") OrElse
           q.Contains("change my name") Then

            Return "You can open your profile by clicking the profile picture on your dashboard. You can edit your Full Name and save the change. Username, Role and Status cannot be changed from the profile."

        End If


        ' HELP
        If q.Contains("help") OrElse
           q.Contains("what can you do") OrElse
           q.Contains("how can you help") Then

            Return "I can help you understand Viti FoodLink features such as giving food, requesting food, barter, recipients, recommendations, distribution, reports and user profiles."

        End If


        ' GREETING
        If q.Contains("hello") OrElse
           q.Contains("hi") OrElse
           q.Contains("hey") Then

            Return "Hello! I am VitiBot, your Viti FoodLink Assistant. How can I help you?"

        End If


        ' UNKNOWN QUESTION
        Return "I'm sorry, I don't have an answer for that yet. Please ask me about Viti FoodLink features such as Give Food, Request Food, Barter, Recipients, Recommendations, Distribution, Reports or Profiles."

    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        rtbChat.Clear()

        rtbChat.AppendText(
        "VitiBot: Hello! I am the Viti FoodLink Assistant." &
        Environment.NewLine &
        "I can help you understand how to use the Viti FoodLink system." &
        Environment.NewLine &
        "Ask me a question to get started." &
        Environment.NewLine &
        Environment.NewLine
    )

        txtMessage.Focus()

    End Sub

    Private Sub txtMessage_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMessage.KeyDown

        If e.KeyCode = Keys.Enter Then

            e.SuppressKeyPress = True
            btnSend.PerformClick()

        End If

    End Sub
End Class