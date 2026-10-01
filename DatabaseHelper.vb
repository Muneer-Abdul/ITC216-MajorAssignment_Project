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

        Using conn As SQLiteConnection = GetConnection()

            conn.Open()

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
            '
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

            Dim barterQuery As String =
                "CREATE TABLE IF NOT EXISTS Barter (" &
                "BarterID INTEGER PRIMARY KEY AUTOINCREMENT, " &
                "OfferedProduce TEXT NOT NULL, " &
                "OfferedQuantity REAL NOT NULL, " &
                "RequestedProduce TEXT NOT NULL, " &
                "RequestedQuantity REAL NOT NULL, " &
                "Community TEXT NOT NULL, " &
                "BarterDate TEXT NOT NULL" &
                ");"

            Using barterCmd As New SQLiteCommand(barterQuery, conn)
                barterCmd.ExecuteNonQuery()
            End Using

            ' Add Status column to Barter table if it does not already exist
            Dim statusExists As Boolean = False

            Dim checkStatusQuery As String =
    "PRAGMA table_info(Barter);"

            Using checkCmd As New SQLiteCommand(checkStatusQuery, conn)

                Using reader As SQLiteDataReader = checkCmd.ExecuteReader()

                    While reader.Read()

                        If reader("name").ToString().Equals(
                "Status",
                StringComparison.OrdinalIgnoreCase) Then

                            statusExists = True
                            Exit While

                        End If

                    End While

                End Using

            End Using

            If Not statusExists Then

                Dim addStatusQuery As String =
        "ALTER TABLE Barter " &
        "ADD COLUMN Status TEXT NOT NULL DEFAULT 'Available';"

                Using addStatusCmd As New SQLiteCommand(addStatusQuery, conn)

                    addStatusCmd.ExecuteNonQuery()

                End Using

            End If

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
End Module