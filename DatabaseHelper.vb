
Imports System.Data.SQLite
Imports System.IO

Module DatabaseHelper

    Private ReadOnly DatabasePath As String =
        Path.Combine(
            Application.StartupPath,
            "Database",
            "VitiFoodLink.db"
        )

    Public ReadOnly ConnectionString As String =
        "Data Source=" & DatabasePath & ";Version=3;"

    Public Function GetConnection() As SQLiteConnection
        Return New SQLiteConnection(ConnectionString)
    End Function

    Public Sub InitializeDatabase()

        Dim databaseFolder As String =
            Path.Combine(Application.StartupPath, "Database")

        If Not Directory.Exists(databaseFolder) Then
            Directory.CreateDirectory(databaseFolder)
        End If

        Using conn As SQLiteConnection = GetConnection()

            conn.Open()

            ' USERS TABLE
            Dim query As String =
                "CREATE TABLE IF NOT EXISTS Users (" &
                "UserID INTEGER PRIMARY KEY AUTOINCREMENT, " &
                "FullName TEXT NOT NULL, " &
                "Username TEXT NOT NULL UNIQUE, " &
                "Password TEXT NOT NULL, " &
                "Role TEXT NOT NULL, " &
                "Status TEXT NOT NULL DEFAULT 'Active'" &
                ");"

            Using cmd As New SQLiteCommand(query, conn)
                cmd.ExecuteNonQuery()
            End Using

            ' ADD EMAIL COLUMN TO EXISTING USERS TABLE
            AddUserColumnIfMissing(
                conn,
                "Email",
                "TEXT"
            )

            ' SURPLUS PRODUCE TABLE
            Dim surplusQuery As String =
                "CREATE TABLE IF NOT EXISTS SurplusProduce (" &
                "ProduceID INTEGER PRIMARY KEY AUTOINCREMENT, " &
                "ProduceName TEXT NOT NULL, " &
                "Quantity REAL NOT NULL, " &
                "Donor TEXT NOT NULL, " &
                "ExpiryDate TEXT NOT NULL, " &
                "ProduceSource TEXT NOT NULL, " &
                "Community TEXT NOT NULL" &
                ");"

            Using surplusCmd As New SQLiteCommand(surplusQuery, conn)
                surplusCmd.ExecuteNonQuery()
            End Using

            ' BARTER TABLE
            Dim barterQuery As String =
                "CREATE TABLE IF NOT EXISTS Barter (" &
                "BarterID INTEGER PRIMARY KEY AUTOINCREMENT, " &
                "PersonName TEXT NOT NULL DEFAULT '', " &
                "ContactNumber TEXT NOT NULL DEFAULT '', " &
                "OfferedProduce TEXT NOT NULL, " &
                "OfferedQuantity REAL NOT NULL, " &
                "RequestedProduce TEXT NOT NULL, " &
                "RequestedQuantity REAL NOT NULL, " &
                "Community TEXT NOT NULL, " &
                "BarterDate TEXT NOT NULL, " &
                "Status TEXT NOT NULL DEFAULT 'Available', " &
                "CreatorUserID INTEGER NOT NULL DEFAULT 0, " &
                "CreatorName TEXT NOT NULL DEFAULT '', " &
                "ConfirmedByUserID INTEGER, " &
                "ConfirmedByName TEXT NOT NULL DEFAULT '', " &
                "ConfirmedAt TEXT" &
                ");"

            Using barterCmd As New SQLiteCommand(barterQuery, conn)
                barterCmd.ExecuteNonQuery()
            End Using

            ' MIGRATE EXISTING BARTER TABLES
            AddBarterColumnIfMissing(
                conn, "PersonName", "TEXT NOT NULL DEFAULT ''")

            AddBarterColumnIfMissing(
                conn, "ContactNumber", "TEXT NOT NULL DEFAULT ''")

            AddBarterColumnIfMissing(
                conn, "Status", "TEXT NOT NULL DEFAULT 'Available'")

            AddBarterColumnIfMissing(
                conn, "CreatorUserID", "INTEGER NOT NULL DEFAULT 0")

            AddBarterColumnIfMissing(
                conn, "CreatorName", "TEXT NOT NULL DEFAULT ''")

            AddBarterColumnIfMissing(
                conn, "ConfirmedByUserID", "INTEGER")

            AddBarterColumnIfMissing(
                conn, "ConfirmedByName", "TEXT NOT NULL DEFAULT ''")

            AddBarterColumnIfMissing(
                conn, "ConfirmedAt", "TEXT")

            ' FOOD REQUESTS TABLE
            Dim requestQuery As String =
                "CREATE TABLE IF NOT EXISTS FoodRequests (" &
                "RequestID INTEGER PRIMARY KEY AUTOINCREMENT, " &
                "RequesterName TEXT NOT NULL, " &
                "FoodNeeded TEXT NOT NULL, " &
                "QuantityNeeded REAL NOT NULL, " &
                "RecipientType TEXT NOT NULL, " &
                "Community TEXT NOT NULL, " &
                "Urgency TEXT NOT NULL, " &
                "RequestReason TEXT NOT NULL, " &
                "RequestDate TEXT NOT NULL, " &
                "Status TEXT NOT NULL DEFAULT 'Pending'" &
                ");"

            Using requestCmd As New SQLiteCommand(requestQuery, conn)
                requestCmd.ExecuteNonQuery()
            End Using

        End Using

    End Sub

    ' CHECK WHETHER A USERS COLUMN EXISTS
    Private Function UserColumnExists(
        conn As SQLiteConnection,
        columnName As String
    ) As Boolean

        Using checkCmd As New SQLiteCommand(
            "PRAGMA table_info(Users);", conn)

            Using reader As SQLiteDataReader = checkCmd.ExecuteReader()

                While reader.Read()

                    If reader("name").ToString().Equals(
                        columnName,
                        StringComparison.OrdinalIgnoreCase
                    ) Then
                        Return True
                    End If

                End While

            End Using
        End Using

        Return False

    End Function

    ' ADD A USERS COLUMN ONLY IF IT IS MISSING
    Private Sub AddUserColumnIfMissing(
        conn As SQLiteConnection,
        columnName As String,
        columnDefinition As String
    )

        If Not UserColumnExists(conn, columnName) Then

            Dim alterQuery As String =
                "ALTER TABLE Users ADD COLUMN " &
                columnName & " " & columnDefinition & ";"

            Using alterCmd As New SQLiteCommand(alterQuery, conn)
                alterCmd.ExecuteNonQuery()
            End Using

        End If

    End Sub

    ' CHECK WHETHER A BARTER COLUMN EXISTS
    Private Function BarterColumnExists(
        conn As SQLiteConnection,
        columnName As String
    ) As Boolean

        Using checkCmd As New SQLiteCommand(
            "PRAGMA table_info(Barter);", conn)

            Using reader As SQLiteDataReader = checkCmd.ExecuteReader()

                While reader.Read()

                    If reader("name").ToString().Equals(
                        columnName,
                        StringComparison.OrdinalIgnoreCase
                    ) Then
                        Return True
                    End If

                End While

            End Using
        End Using

        Return False

    End Function

    ' ADD A BARTER COLUMN ONLY IF IT IS MISSING
    Private Sub AddBarterColumnIfMissing(
        conn As SQLiteConnection,
        columnName As String,
        columnDefinition As String
    )

        If Not BarterColumnExists(conn, columnName) Then

            Dim alterQuery As String =
                "ALTER TABLE Barter ADD COLUMN " &
                columnName & " " & columnDefinition & ";"

            Using alterCmd As New SQLiteCommand(alterQuery, conn)
                alterCmd.ExecuteNonQuery()
            End Using

        End If

    End Sub

End Module
