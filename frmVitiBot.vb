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

                lblTitle.Text = "VitiBot — Viti FoodLink Assistant"
                btnSend.Text = "&Send"
                btnClear.Text = "&Clear"

            Case "Itaukei"

                lblTitle.Text = "VitiBot — Viti FoodLink Assistant"
                btnSend.Text = "Vakauta"
                btnClear.Text = "Sereka"

            Case "Fiji Hindi"

                lblTitle.Text = "VitiBot — Viti FoodLink Assistant"
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

        ' Normalize the message so short phrases and punctuation are easier to recognize.
        Dim q As String = question.ToLowerInvariant().Trim()
        q = q.Replace("?", " ").Replace("!", " ").Replace(".", " ")
        q = q.Replace(",", " ").Replace(":", " ").Replace(";", " ")
        q = System.Text.RegularExpressions.Regex.Replace(q, "\s+", " ").Trim()

        ' HELP: show the full list of supported topics and example questions.
        If IsOneOf(q, "help", "commands", "options", "what can you do", "what can you help with", "how can you help", "show help") Then
            Return GetText(
                "Here are things you can ask me about:" & Environment.NewLine & Environment.NewLine &
                "GIVE FOOD / DONATE" & Environment.NewLine &
                "• give food" & Environment.NewLine &
                "• donate" & Environment.NewLine &
                "• how do I add surplus food?" & Environment.NewLine &
                "• how do I add supplies?" & Environment.NewLine & Environment.NewLine &
                "REQUEST FOOD" & Environment.NewLine &
                "• request food" & Environment.NewLine &
                "• request" & Environment.NewLine &
                "• how do I ask for food?" & Environment.NewLine & Environment.NewLine &
                "BARTER / EXCHANGE" & Environment.NewLine &
                "• barter" & Environment.NewLine &
                "• exchange food" & Environment.NewLine &
                "• how does food barter work?" & Environment.NewLine & Environment.NewLine &
                "ACCOUNTS AND PROFILES" & Environment.NewLine &
                "• register / registration" & Environment.NewLine &
                "• login" & Environment.NewLine &
                "• profile / change my name" & Environment.NewLine & Environment.NewLine &
                "SYSTEM FEATURES" & Environment.NewLine &
                "• recipients" & Environment.NewLine &
                "• recommendation" & Environment.NewLine &
                "• distribution" & Environment.NewLine &
                "• reports" & Environment.NewLine &
                "• admin / community organisation / user" & Environment.NewLine &
                "• language" & Environment.NewLine &
                "• what is Viti FoodLink?" & Environment.NewLine &
                "• hello" & Environment.NewLine & Environment.NewLine &
                "You can type a short keyword or a full question. Some features depend on your account role.",
                "Oqo eso na ka o rawa ni taroga vei au:" & Environment.NewLine & Environment.NewLine &
                "SOLIA NA KAKANA / DONATE" & Environment.NewLine &
                "• solia na kakana" & Environment.NewLine &
                "• donate" & Environment.NewLine &
                "• vakacuruma na kakana e vo" & Environment.NewLine & Environment.NewLine &
                "KEREA NA KAKANA" & Environment.NewLine &
                "• kerea na kakana" & Environment.NewLine &
                "• request" & Environment.NewLine &
                "• au gadreva na kakana" & Environment.NewLine & Environment.NewLine &
                "VEISAU NI KAKANA / BARTER" & Environment.NewLine &
                "• barter" & Environment.NewLine &
                "• veisau ni kakana" & Environment.NewLine & Environment.NewLine &
                "ACCOUNT KEI NA PROFILE" & Environment.NewLine &
                "• registration / login" & Environment.NewLine &
                "• profile / veisautaka na yaca" & Environment.NewLine & Environment.NewLine &
                "VEIKA NI SYSTEM" & Environment.NewLine &
                "• recipients / dauciqomi" & Environment.NewLine &
                "• recommendation" & Environment.NewLine &
                "• distribution / veisoliyaki" & Environment.NewLine &
                "• reports" & Environment.NewLine &
                "• admin / community organisation / user" & Environment.NewLine &
                "• language / vosa" & Environment.NewLine &
                "• na cava na Viti FoodLink?" & Environment.NewLine &
                "• bula" & Environment.NewLine & Environment.NewLine &
                "E rawa ni o vakayagataka e dua ga na vosa se dua na taro taucoko. Eso na cakacaka e vakatau ena nomu itavi.",
                "Aap mujhse in topics ke baare mein pooch sakte hain:" & Environment.NewLine & Environment.NewLine &
                "KHANA DENA / DONATE" & Environment.NewLine &
                "• give food" & Environment.NewLine &
                "• donate" & Environment.NewLine &
                "• surplus" & Environment.NewLine &
                "• surplus khana kaise add karein?" & Environment.NewLine & Environment.NewLine &
                "KHANA REQUEST KARNA" & Environment.NewLine &
                "• request food" & Environment.NewLine &
                "• request" & Environment.NewLine &
                "• mujhe khana chahiye" & Environment.NewLine & Environment.NewLine &
                "BARTER / EXCHANGE" & Environment.NewLine &
                "• barter" & Environment.NewLine &
                "• exchange food" & Environment.NewLine & Environment.NewLine &
                "ACCOUNT AUR PROFILE" & Environment.NewLine &
                "• register / registration" & Environment.NewLine &
                "• login" & Environment.NewLine &
                "• profile / change my name" & Environment.NewLine & Environment.NewLine &
                "SYSTEM FEATURES" & Environment.NewLine &
                "• recipients" & Environment.NewLine &
                "• recommendation" & Environment.NewLine &
                "• distribution" & Environment.NewLine &
                "• reports" & Environment.NewLine &
                "• admin / community organisation / user" & Environment.NewLine &
                "• language" & Environment.NewLine &
                "• Viti FoodLink kya hai?" & Environment.NewLine &
                "• hello" & Environment.NewLine & Environment.NewLine &
                "Aap ek chhota keyword ya poora question likh sakte hain. Kuch features account role par depend karte hain."
            )
        End If

        ' ABOUT VITI FOODLINK
        If ContainsAny(q, "what is viti foodlink", "what is viti", "about viti foodlink", "viti foodlink", "about the system") Then
            Return GetText(
                "Viti FoodLink is a community-based food management system designed to help manage surplus food, food requests, recipients, food distribution and food barter.",
                "Viti FoodLink e dua na ivakarau ni veiliutaki ni kakana ena itikotiko, me vukea na kena qaravi na kakana e vo, kerekere ni kakana, dauciqomi, veisoliyaki ni kakana kei na veisau ni kakana.",
                "Viti FoodLink ek community-based food management system hai jo surplus khana, food requests, recipients, food distribution aur food barter ko manage karne mein madad karta hai."
            )
        End If

        ' GIVE FOOD: recognize full questions and short keywords.
        If ContainsAny(q, "give food", "donate food", "donate", "donation", "surplus food", "add surplus", "surplus", "give", "supplies", "supply", "food donation", "offer food") Then
            Return GetText(
                "To give surplus food, open the Give Food or Supplies section. Enter the produce name, quantity, donor information, expiry date, source and community, then save the record.",
                "Me solia na kakana e vo, dolava na iwase ni Solia na Kakana se iYau. Vakacuruma na yaca ni kakana, levu, itukutuku ni dau solia, siga ni oti, vanua e lako mai kina kei na tikina, oti maroroya na ivolatukutuku.",
                "Surplus khana dene ke liye Give Food ya Supplies section kholo. Produce ka naam, quantity, donor information, expiry date, source aur community enter karke record save karo."
            )
        End If

        ' REQUEST FOOD
        If ContainsAny(q, "request food", "food request", "need food", "request", "requesting", "ask for food", "want food", "food help", "help with food", "khana chahiye") Then
            Return GetText(
                "To request food, open Request Food. Enter your name, the food needed, quantity, recipient type, community, urgency and reason for the request, then submit it.",
                "Me kerea na kakana, dolava na Kerea na Kakana. Vakacuruma na yacamu, kakana e gadrevi, levu, mataqali dauciqomi, tikina, bibi kei na vuna ni kerekere, oti vakauta.",
                "Khana request karne ke liye Request Food kholo. Apna naam, chahiye hua khana, quantity, recipient type, community, urgency aur reason enter karke submit karo."
            )
        End If

        ' BARTER
        If ContainsAny(q, "barter", "exchange food", "exchange", "food exchange", "trade food", "swap food", "swap") Then
            Return GetText(
                "The Viti FoodLink barter system allows users to offer one type of produce in exchange for another type of produce. Open the Barter or Food Exchange section to add an offer or view available barter records.",
                "Na veisau ni Viti FoodLink e rawa kina vei ira na vakayagataka mera solia e dua na mataqali kakana me veisau kei na dua tale na mataqali kakana. Dolava na Barter se Food Exchange mo vakuria kina e dua na solisoli se raica na ivolatukutuku ni veisau.",
                "Viti FoodLink barter system mein users ek type ka produce doosre type ke produce ke badle offer kar sakte hain. Offer add karne ya available records dekhne ke liye Barter ya Food Exchange section kholo."
            )
        End If

        ' REGISTRATION AND LOGIN
        If ContainsAny(q, "register", "registration", "sign up", "create account", "new account", "signup") Then
            Return GetText(
                "To register, open the Registration form and enter the details requested by the application. Submit the form to create your account. If registration is unavailable on your screen, ask the administrator for assistance.",
                "Me rejisita, dolava na Registration form ka vakacuruma na itukutuku e kerea na application. Vakauta na form mo bulia kina na nomu account. Kevaka e sega ni tiko na registration, kerea na veivuke ni admin.",
                "Register karne ke liye Registration form kholo aur application ke maange gaye details bharo. Account banane ke liye form submit karo. Agar registration option nahi dikhe, administrator se madad maango."
            )
        End If

        If ContainsAny(q, "login", "log in", "sign in", "cannot log in", "forgot password", "password") Then
            Return GetText(
                "To log in, open the Login form and enter your registered username and password. If your details are rejected or your account is inactive, contact the administrator.",
                "Me curu, dolava na Login form ka vakacuruma na username kei na password o rejisita kina. Kevaka e sega ni ciqomi na itukutuku se sega ni active na account, veitaratara kei na admin.",
                "Login karne ke liye Login form kholo aur registered username aur password enter karo. Agar details accept nahi hoti ya account inactive hai, administrator se contact karo."
            )
        End If

        ' RECIPIENTS
        If ContainsAny(q, "recipient", "recipients", "add recipient", "manage recipient", "beneficiary", "food recipient") Then
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
        If ContainsAny(q, "recommendation", "recommend", "recommended recipient", "matching", "match food", "suitable recipient") Then
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
        If ContainsAny(q, "distribution", "distribute food", "distribute", "distributed food", "food delivery", "deliver food") Then
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
        If ContainsAny(q, "report", "reports", "system report", "statistics", "export report", "csv") Then
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

        ' ADMIN ROLE
        If ContainsAny(q, "admin", "administrator", "admin role", "admin dashboard") Then
            Return GetText(
                "The administrator manages the main Viti FoodLink operations, including supplies, recipients, recommendations, food distribution, reports, food exchange and barter records.",
                "Na admin e qarava na cakacaka levu ni Viti FoodLink, wili kina na iYau, Dauciqomi, Recommendation, veisoliyaki ni kakana, Reports, veisau ni kakana kei na ivolatukutuku ni veisau.",
                "Administrator Viti FoodLink ke main operations manage karta hai, jisme supplies, recipients, recommendations, food distribution, reports, food exchange aur barter records shamil hain."
            )
        End If

        ' COMMUNITY ORGANISATION ROLE
        If ContainsAny(q, "community organisation", "community organization", "organisation", "organization", "community dashboard") Then
            Return GetText(
                "Community organisations can manage supplies and recipients and use food-related functions available through their organisation dashboard.",
                "Na mataisoqosoqo ni veiqaravi e rawa ni qarava na iYau kei na Dauciqomi ka vakayagataka na cakacaka ni kakana ena nodra dashboard.",
                "Community organisations supplies aur recipients manage kar sakte hain aur organisation dashboard ke food-related functions use kar sakte hain."
            )
        End If

        ' USER ROLE / DASHBOARD
        If ContainsAny(q, "user", "my dashboard", "dashboard", "what can i do") Then
            Return GetText(
                "Users can give surplus food, request food, use the barter system and manage their profile. Available functions depend on the account role.",
                "O ira na vakayagataka e rawa ni ra solia na kakana e vo, kerea na kakana, vakayagataka na veisau ni kakana ka qarava na nodra profile. E vakatau ena itavi ni account na cakacaka e rawa ni vakayagataki.",
                "Users surplus khana de sakte hain, khana request kar sakte hain, barter system use kar sakte hain aur apna profile manage kar sakte hain. Available functions account role par depend karte hain."
            )
        End If

        ' PROFILE
        If ContainsAny(q, "profile", "change my name", "edit profile", "update profile", "my name", "full name") Then
            Return GetText(
                "You can open your profile by clicking the profile picture on your dashboard. You can edit your Full Name and save the change. Username, Role and Status cannot be changed from the profile.",
                "E rawa ni o dolava na nomu profile ena nomu tabaka na profile picture ena dashboard. E rawa ni o veisautaka na Yaca Taucoko ka maroroya. Na Username, iTavi kei na iTuvaki e sega ni rawa ni veisautaki ena profile.",
                "Dashboard par profile picture click karke apna profile kholo. Full Name edit aur save kar sakte hain. Username, Role aur Status profile se change nahi kiye ja sakte."
            )
        End If

        ' LANGUAGE
        If ContainsAny(q, "language", "change language", "english", "itaukei", "fiji hindi", "hindi", "vosa") Then
            Return GetText(
                "You can choose English, iTaukei or Fiji Hindi on the Welcome screen before continuing to Login. Return to the Welcome screen if you need to choose another language.",
                "E rawa ni o digitaka na English, iTaukei se Fiji Hindi ena Welcome screen ni bera ni o lako ki na Login. Lesu tale ki na Welcome screen kevaka o via digitaka e dua tale na vosa.",
                "Login se pehle Welcome screen par English, iTaukei ya Fiji Hindi choose kar sakte hain. Doosri language chunne ke liye Welcome screen par wapas jaayein."
            )
        End If

        ' GREETING: exact/short greeting matching avoids matching words inside unrelated sentences.
        If IsOneOf(q, "hello", "hi", "hey", "bula", "namaste", "good morning", "good afternoon", "good evening") Then
            Return GetText(
                "Hello! I am VitiBot, your Viti FoodLink Assistant. Type help to see the topics I can assist with.",
                "Bula! Oi au o VitiBot, nomu Viti FoodLink Assistant. Vakacuruma na help mo raica na veika au rawa ni vukei iko kina.",
                "Namaste! Main VitiBot, aapka Viti FoodLink Assistant hoon. Main kin topics mein madad kar sakta hoon dekhne ke liye help type karein."
            )
        End If

        ' UNKNOWN QUESTION
        Return GetText(
            "I'm sorry, I don't have an answer for that yet. Type help to see example questions, or ask about Give Food, Request Food, Barter, Registration, Login, Recipients, Recommendations, Distribution, Reports, Profiles or Language.",
            "Vosoti au, au se sega ni kila na kena isau ena gauna oqo. Vakacuruma na help mo raica na taro ivakaraitaki, se taroga na Solia na Kakana, Kerea na Kakana, Barter, Registration, Login, Dauciqomi, Recommendation, Distribution, Reports, Profile se Vosa.",
            "Maaf kijiye, mere paas abhi iska answer nahi hai. Example questions ke liye help type karein, ya Give Food, Request Food, Barter, Registration, Login, Recipients, Recommendations, Distribution, Reports, Profile ya Language ke baare mein poochhein."
        )

    End Function

    Private Function ContainsAny(text As String, ParamArray keywords() As String) As Boolean
        For Each keyword As String In keywords
            If text.Contains(keyword) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Function IsOneOf(text As String, ParamArray values() As String) As Boolean
        For Each value As String In values
            If text.Equals(value, StringComparison.OrdinalIgnoreCase) Then
                Return True
            End If
        Next
        Return False
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