Public Class frmVitiBot

    Private loggedInRole As String = "User"

    Public Sub New(role As String)
        InitializeComponent()
        loggedInRole = role
    End Sub

    Private Sub frmVitiBot_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        rtbChat.ReadOnly = True

        ApplyLanguage()

        ShowWelcomeMessage()

        txtMessage.Focus()

    End Sub

    Private Sub ApplyLanguage()

        Select Case LanguageHelper.CurrentLanguage

            Case "English"

                lblTitle.Text = "VitiBot"
                btnSend.Text = "Send"
                btnClear.Text = "Clear"

            Case "Itaukei"

                lblTitle.Text = "VitiBot"
                btnSend.Text = "Vakauta"
                btnClear.Text = "Sereka"

            Case "Fiji Hindi"

                lblTitle.Text = "VitiBot"
                btnSend.Text = "Bhejo"
                btnClear.Text = "Saaf Karo"

        End Select

    End Sub

    Private Sub ShowWelcomeMessage()

        rtbChat.Clear()

        rtbChat.SelectionColor = Color.DarkGreen
        rtbChat.SelectionFont = New Font(rtbChat.Font, FontStyle.Bold)

        rtbChat.AppendText("VitiBot" & Environment.NewLine)

        rtbChat.SelectionColor = Color.Black
        rtbChat.SelectionFont = New Font(rtbChat.Font, FontStyle.Regular)

        Select Case LanguageHelper.CurrentLanguage

            Case "English"

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

            Case "Itaukei"

                rtbChat.AppendText(
                    "Bula! Au Viti FoodLink Assistant." &
                    Environment.NewLine &
                    "Au rawa ni vukei iko ena veika kei na cakacaka ni Viti FoodLink." &
                    Environment.NewLine &
                    Environment.NewLine &
                    "Tovolea mo taroga:" &
                    Environment.NewLine &
                    "• E rawa vakacava meu solia na kakana?" &
                    Environment.NewLine &
                    "• E rawa vakacava meu kerea na kakana?" &
                    Environment.NewLine &
                    "• Na cava na veisau ni kakana?" &
                    Environment.NewLine &
                    "• Na cava au rawa ni cakava?" &
                    Environment.NewLine &
                    Environment.NewLine
                )

            Case "Fiji Hindi"

                rtbChat.AppendText(
                    "Namaste! Main Viti FoodLink Assistant hoon." &
                    Environment.NewLine &
                    "Main aapko Viti FoodLink ke features aur functions ke baare mein madad kar sakta hoon." &
                    Environment.NewLine &
                    Environment.NewLine &
                    "Aap pooch sakte hain:" &
                    Environment.NewLine &
                    "• Main khana kaise de sakta hoon?" &
                    Environment.NewLine &
                    "• Main khana kaise maang sakta hoon?" &
                    Environment.NewLine &
                    "• Barter system kya hai?" &
                    Environment.NewLine &
                    "• Main kya kar sakta hoon?" &
                    Environment.NewLine &
                    Environment.NewLine
                )

        End Select

    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click

        Dim question As String = txtMessage.Text.Trim()

        If question = "" Then
            Return
        End If

        ' Display user's message
        rtbChat.SelectionColor = Color.DarkBlue
        rtbChat.SelectionFont = New Font(rtbChat.Font, FontStyle.Bold)

        Select Case LanguageHelper.CurrentLanguage

            Case "English"
                rtbChat.AppendText("You" & Environment.NewLine)

            Case "Itaukei"
                rtbChat.AppendText("O iko" & Environment.NewLine)

            Case "Fiji Hindi"
                rtbChat.AppendText("Aap" & Environment.NewLine)

        End Select

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

            Return GetText(
                "Viti FoodLink is a community-based food management system designed to help manage surplus food, food requests, recipients, food distribution and food barter.",
                "Viti FoodLink e dua na ivakarau ni veiliutaki ni kakana ena itikotiko, me vukea na kena qaravi na kakana e vo, kerekere ni kakana, dauciqomi, veisoliyaki ni kakana kei na veisau ni kakana.",
                "Viti FoodLink ek community-based food management system hai jo surplus khana, food requests, recipients, food distribution aur food barter ko manage karne mein madad karta hai."
            )

        End If


        ' GIVE FOOD
        If q.Contains("give food") OrElse
           q.Contains("donate food") OrElse
           q.Contains("surplus food") OrElse
           q.Contains("add surplus") Then

            Return GetText(
                "To give surplus food, open the Give Food or Supplies section. Enter the produce name, quantity, donor information, expiry date, source and community, then save the record.",
                "Me solia na kakana e vo, dolava na iwase ni Solia na Kakana se iYau. Vakacuruma na yaca ni kakana, levu, itukutuku ni dau solia, siga ni oti, vanua e lako mai kina kei na tikina, oti maroroya na ivolatukutuku.",
                "Surplus khana dene ke liye Give Food ya Supplies section kholo. Produce ka naam, quantity, donor information, expiry date, source aur community enter karke record save karo."
            )

        End If


        ' REQUEST FOOD
        If q.Contains("request food") OrElse
           q.Contains("need food") OrElse
           q.Contains("food request") Then

            Return GetText(
                "To request food, open Request Food. Enter your name, the food needed, quantity, recipient type, community, urgency and reason for the request, then submit it.",
                "Me kerea na kakana, dolava na Kerea na Kakana. Vakacuruma na yacamu, kakana e gadrevi, levu, mataqali dauciqomi, tikina, bibi kei na vuna ni kerekere, oti vakauta.",
                "Khana request karne ke liye Request Food kholo. Apna naam, chahiye hua khana, quantity, recipient type, community, urgency aur reason enter karke submit karo."
            )

        End If


        ' BARTER
        If q.Contains("barter") OrElse
           q.Contains("exchange food") Then

            Return GetText(
                "The Viti FoodLink barter system allows users to offer one type of produce in exchange for another type of produce. You can add a barter offer and view available barter records.",
                "Na veisau ni Viti FoodLink e rawa kina vei ira na vakayagataka mera solia e dua na mataqali kakana me veisau kei na dua tale na mataqali kakana. E rawa ni o vakuria ka raica na ivolatukutuku ni veisau.",
                "Viti FoodLink barter system mein users ek type ka produce doosre type ke produce ke badle offer kar sakte hain. Aap barter offer add aur available barter records dekh sakte hain."
            )

        End If


        ' RECIPIENTS
        If q.Contains("recipient") OrElse
           q.Contains("add recipient") Then

            If loggedInRole.Equals("Admin", StringComparison.OrdinalIgnoreCase) OrElse
               loggedInRole.Equals("Community Organisation", StringComparison.OrdinalIgnoreCase) Then

                Return GetText(
                    "Recipients can be managed from the Recipients section. You can add recipient information such as name, organisation, contact number, community, location and recipient type.",
                    "E rawa ni qaravi na dauciqomi ena iwase ni Dauciqomi. E rawa ni vakacurumi na yaca, isoqosoqo, naba ni veitaratara, tikina, vanua kei na mataqali dauciqomi.",
                    "Recipients section se recipients manage kiye ja sakte hain. Naam, organisation, contact number, community, location aur recipient type add kar sakte hain."
                )

            Else

                Return GetText(
                    "Recipient management is available to administrators and community organisations.",
                    "Na qaravi ni dauciqomi e nodra cakacaka na admin kei na mataisoqosoqo ni veiqaravi.",
                    "Recipient management administrators aur community organisations ke liye available hai."
                )

            End If

        End If


        ' RECOMMENDATION
        If q.Contains("recommendation") OrElse
           q.Contains("recommend") Then

            If loggedInRole.Equals("Admin", StringComparison.OrdinalIgnoreCase) Then

                Return GetText(
                    "The Recommendation Engine helps the administrator identify suitable recipients for available surplus produce based on recipient type and community.",
                    "Na Recommendation Engine e vukea na admin me kunea na dauciqomi e veiganiti kei na kakana e vo, me yavutaki ena mataqali dauciqomi kei na tikina.",
                    "Recommendation Engine administrator ko available surplus produce ke liye suitable recipients identify karne mein madad karta hai, recipient type aur community ke base par."
                )

            Else

                Return GetText(
                    "The Recommendation Engine is an administrator feature in Viti FoodLink.",
                    "Na Recommendation Engine e dua na cakacaka e nodra na admin ena Viti FoodLink.",
                    "Recommendation Engine Viti FoodLink mein administrator feature hai."
                )

            End If

        End If


        ' DISTRIBUTION
        If q.Contains("distribution") OrElse
           q.Contains("distribute food") Then

            If loggedInRole.Equals("Admin", StringComparison.OrdinalIgnoreCase) Then

                Return GetText(
                    "The Distribution section allows the administrator to record the distribution of available produce to recipients and track the distribution method and date.",
                    "Na iwase ni Distribution e rawa kina vua na admin me vola na kena soli na kakana e tiko vei ira na dauciqomi, kei na kena ivakarau kei na siga e soli kina.",
                    "Distribution section administrator ko available produce recipients ko distribute karne aur distribution method aur date track karne deta hai."
                )

            Else

                Return GetText(
                    "Food distribution is managed by the administrator.",
                    "Na veisoliyaki ni kakana e qaravi mai vua na admin.",
                    "Food distribution administrator manage karta hai."
                )

            End If

        End If


        ' REPORTS
        If q.Contains("report") OrElse
           q.Contains("reports") Then

            If loggedInRole.Equals("Admin", StringComparison.OrdinalIgnoreCase) Then

                Return GetText(
                    "The Reports section provides information about available produce, distributed produce, recipients and distribution records. Reports can also be filtered and exported.",
                    "Na iwase ni Reports e vakarautaka na itukutuku me baleta na kakana e tiko, kakana e soli, dauciqomi kei na ivolatukutuku ni veisoliyaki. E rawa tale ga ni vakadigidigi ka vakau yani na reports.",
                    "Reports section available produce, distributed produce, recipients aur distribution records ki information deta hai. Reports filter aur export bhi kiye ja sakte hain."
                )

            Else

                Return GetText(
                    "Reports are available to administrators only.",
                    "Na Reports era vakarautaki ga vei ira na admin.",
                    "Reports sirf administrators ke liye available hain."
                )

            End If

        End If


        ' ADMIN
        If q.Contains("admin") OrElse
           q.Contains("administrator") Then

            Return GetText(
                "The administrator manages the main Viti FoodLink operations, including supplies, recipients, recommendations, food distribution, reports, food exchange and barter records.",
                "Na admin e qarava na cakacaka levu ni Viti FoodLink, wili kina na iYau, Dauciqomi, Recommendation, veisoliyaki ni kakana, Reports, veisau ni kakana kei na ivolatukutuku ni veisau.",
                "Administrator Viti FoodLink ke main operations manage karta hai, jisme supplies, recipients, recommendations, food distribution, reports, food exchange aur barter records shamil hain."
            )

        End If


        ' COMMUNITY ORGANISATION
        If q.Contains("community organisation") OrElse
           q.Contains("community organization") Then

            Return GetText(
                "Community organisations can manage supplies and recipients and use food-related functions available through their organisation dashboard.",
                "Na mataisoqosoqo ni veiqaravi e rawa ni qarava na iYau kei na Dauciqomi ka vakayagataka na cakacaka ni kakana ena nodra dashboard.",
                "Community organisations supplies aur recipients manage kar sakte hain aur organisation dashboard ke food-related functions use kar sakte hain."
            )

        End If


        ' USER
        If q.Contains("user") OrElse
           q.Contains("my dashboard") Then

            Return GetText(
                "Users can give surplus food, request food, use the barter system and manage their profile.",
                "O ira na vakayagataka e rawa ni ra solia na kakana e vo, kerea na kakana, vakayagataka na veisau ni kakana ka qarava na nodra profile.",
                "Users surplus khana de sakte hain, khana request kar sakte hain, barter system use kar sakte hain aur apna profile manage kar sakte hain."
            )

        End If


        ' PROFILE
        If q.Contains("profile") OrElse
           q.Contains("change my name") Then

            Return GetText(
                "You can open your profile by clicking the profile picture on your dashboard. You can edit your Full Name and save the change. Username, Role and Status cannot be changed from the profile.",
                "E rawa ni o dolava na nomu profile ena nomu tabaka na profile picture ena dashboard. E rawa ni o veisautaka na Yaca Taucoko ka maroroya. Na Username, iTavi kei na iTuvaki e sega ni rawa ni veisautaki ena profile.",
                "Dashboard par profile picture click karke apna profile kholo. Full Name edit aur save kar sakte hain. Username, Role aur Status profile se change nahi kiye ja sakte."
            )

        End If


        ' HELP
        If q.Contains("help") OrElse
           q.Contains("what can you do") OrElse
           q.Contains("how can you help") Then

            Return GetText(
                "I can help you understand Viti FoodLink features such as giving food, requesting food, barter, recipients, recommendations, distribution, reports and user profiles.",
                "Au rawa ni vukei iko mo kila na veika ni Viti FoodLink me vaka na solia na kakana, kerea na kakana, veisau, dauciqomi, recommendation, veisoliyaki, reports kei na user profiles.",
                "Main aapko Viti FoodLink ke features samajhne mein madad kar sakta hoon jaise khana dena, khana request karna, barter, recipients, recommendations, distribution, reports aur user profiles."
            )

        End If


        ' GREETING
        If q.Contains("hello") OrElse
           q.Contains("hi") OrElse
           q.Contains("hey") Then

            Return GetText(
                "Hello! I am VitiBot, your Viti FoodLink Assistant. How can I help you?",
                "Bula! Oi au o VitiBot, nomu Viti FoodLink Assistant. E rawa vakacava meu vukei iko?",
                "Namaste! Main VitiBot, aapka Viti FoodLink Assistant hoon. Main aapki kaise madad kar sakta hoon?"
            )

        End If


        ' UNKNOWN QUESTION
        Return GetText(
            "I'm sorry, I don't have an answer for that yet. Please ask me about Viti FoodLink features such as Give Food, Request Food, Barter, Recipients, Recommendations, Distribution, Reports or Profiles.",
            "Vosoti au, au se sega ni kila na kena isau ena gauna oqo. Kerekere mo taroga me baleta na veika ni Viti FoodLink me vaka Solia na Kakana, Kerea na Kakana, Veisau, Dauciqomi, Recommendation, Distribution, Reports se Profiles.",
            "Maaf kijiye, mere paas abhi iska answer nahi hai. Viti FoodLink ke features jaise Give Food, Request Food, Barter, Recipients, Recommendations, Distribution, Reports ya Profiles ke baare mein poochiye."
        )

    End Function

    Private Function GetText(englishText As String,
                             itaukeiText As String,
                             fijiHindiText As String) As String

        Select Case LanguageHelper.CurrentLanguage

            Case "Itaukei"
                Return itaukeiText

            Case "Fiji Hindi"
                Return fijiHindiText

            Case Else
                Return englishText

        End Select

    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ShowWelcomeMessage()

        txtMessage.Focus()

    End Sub

    Private Sub txtMessage_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMessage.KeyDown

        If e.KeyCode = Keys.Enter Then

            e.SuppressKeyPress = True
            btnSend.PerformClick()

        End If

    End Sub

End Class