Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports MySql.Data.MySqlClient

Public Class Reports
    Private delim As String = ","

    Private Sub ViewUsersButton_Click(sender As Object, e As EventArgs) Handles ViewUsersButton.Click
        If PDFOption.Checked Or BothOption.Checked Then
            Dim userReport As New Document(PageSize.LETTER.Rotate(), 10, 10, 30, 30)
            Dim fname As String = "Users " & DateTime.Now.ToString("yyyyMMdd HHmm") & ".pdf"
            Dim fpath As String = Path.Combine(My.Computer.FileSystem.SpecialDirectories.Desktop, fname)
            Dim stream As New FileStream(fpath, FileMode.Create)
            Dim pdfWriter As PdfWriter = pdf.PdfWriter.GetInstance(userReport, stream)

            With userReport
                .AddAuthor("Group 10")
                .AddSubject("Summary of all users registered in the system")
                .AddTitle("User Report")
                .AddCreationDate()
                .Open()
            End With

            Dim table As New PdfPTable(9)
            table.WidthPercentage = 90
            Dim widths = New Integer() {40, 120, 135, 200, 100, 100, 100, 100, 325}
            table.SetWidths(widths)
            Dim cell As New PdfPCell(New Phrase("Users"))
            cell.Colspan = 9
            cell.HorizontalAlignment = 1
            table.AddCell(cell)

            table.AddCell("ID")
            table.AddCell("Username")
            table.AddCell("Name")
            table.AddCell("Address")
            table.AddCell("Postal Code")
            table.AddCell("City")
            table.AddCell("Province")
            table.AddCell("Country")
            table.AddCell("Email")

            Dim dbconn As MySqlConnection = SQLConnection.Instance.GetConnection()
            Using sqlComm As New MySqlCommand()
                With sqlComm
                    .Connection = dbconn
                    .CommandText = "SELECT Username, FirstName, LastName, StreetAddress, PostalCode, City, State, Country, Email, EID FROM User JOIN Employee ON User.PersonID = Employee.EID"
                    .CommandType = CommandType.Text
                End With
                Try
                    Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                    While sqlReader.Read()
                        table.AddCell(sqlReader("EID").ToString())
                        table.AddCell(sqlReader("Username").ToString())
                        table.AddCell(sqlReader("FirstName").ToString() & " " & sqlReader("LastName").ToString())
                        table.AddCell(sqlReader("StreetAddress").ToString())
                        table.AddCell(sqlReader("PostalCode").ToString())
                        table.AddCell(sqlReader("City").ToString())
                        table.AddCell(sqlReader("State"))
                        table.AddCell(sqlReader("Country").ToString())
                        table.AddCell(sqlReader("Email").ToString())
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
            SQLConnection.Instance.CloseConnection()

            userReport.Add(table)
            userReport.Close()
            pdfWriter.Close()
            stream.Close()

            MsgBox("Report saved to " & fpath)

            If PDFOption.Checked Then
                Process.Start(fpath)
            End If
        End If

        ' Excel start >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        If ExcelOption.Checked Or BothOption.Checked Then
            Dim report As String = ""
            Dim fname As String = "Users " & DateTime.Now.ToString("yyyyMMdd HHmm") & ".csv"
            Dim fpath As String = Path.Combine(My.Computer.FileSystem.SpecialDirectories.Desktop, fname)
            Dim writer As New StreamWriter(fpath, True)
            writer.Write("EID,Username,Name,Address,PostalCode,City,State,Country,Email")


            Dim dbconn As MySqlConnection = SQLConnection.Instance.GetConnection()
            Using sqlComm As New MySqlCommand()
                With sqlComm
                    .Connection = dbconn
                    .CommandText = "SELECT Username, FirstName, LastName, StreetAddress, PostalCode, City, State, Country, Email, EID FROM User JOIN Employee ON User.PersonID = Employee.EID"
                    .CommandType = CommandType.Text
                End With
                Try
                    Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                    While sqlReader.Read()
                        Dim eid As Integer = CInt(sqlReader("EID").ToString())
                        Dim username As String = sqlReader("Username").ToString()
                        Dim name As String = sqlReader("FirstName").ToString() & " " & sqlReader("LastName").ToString()
                        Dim address As String = sqlReader("StreetAddress").ToString()
                        Dim postcode As String = sqlReader("PostalCode").ToString()
                        Dim city As String = sqlReader("City").ToString()
                        Dim state As String = sqlReader("State")
                        Dim country As String = sqlReader("Country").ToString()
                        Dim email As String = sqlReader("Email").ToString()

                        Dim row As String = String.Format("{0}" & delim & "{1}" & delim & "{2}" & delim & "{3}" & delim & "{4}" & delim & "{5}" & delim & "{6}" & delim & "{7}" & delim & "{8}",
                                                          eid, username, name, address, postcode, city, state, country, email)

                        writer.Write(vbCrLf & row)
                    End While
                    writer.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
            SQLConnection.Instance.CloseConnection()

            MsgBox("Report saved to " & fpath)

            If ExcelOption.Checked Then
                Process.Start(fpath)
            End If
        End If
    End Sub

    Private Sub HelpButton_Click(sender As Object, e As EventArgs) Handles HelpButton.Click
        Help.GetHelp("reports")
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Close()
    End Sub

    Private Sub FeedbackButton_Click(sender As Object, e As EventArgs) Handles FeedbackButton.Click
        If PDFOption.Checked Or BothOption.Checked Then
            Dim feedbackReport As New Document(PageSize.LETTER, 10, 10, 30, 30)
            Dim fname As String = "Feedback " & DateTime.Now.ToString("yyyyMMdd HHmm") & ".pdf"
            Dim fpath As String = Path.Combine(My.Computer.FileSystem.SpecialDirectories.Desktop, fname)
            Dim stream As New FileStream(fpath, FileMode.Create)
            Dim pdfWriter As PdfWriter = PdfWriter.GetInstance(feedbackReport, stream)

            With feedbackReport
                .AddAuthor("Group 10")
                .AddSubject("Summary of feedback left on the system")
                .AddTitle("Feedback Report")
                .AddCreationDate()
                .Open()
            End With

            Dim table As New PdfPTable(3)
            table.WidthPercentage = 90
            Dim widths = New Integer() {2, 1, 10}
            table.SetWidths(widths)
            Dim cell As New PdfPCell(New Phrase("Feedback"))
            cell.Colspan = 3
            cell.HorizontalAlignment = 1
            table.AddCell(cell)

            table.AddCell("Transaction ID")
            table.AddCell("Rating")
            table.AddCell("Comments")

            Dim dbconn As MySqlConnection = SQLConnection.Instance.GetConnection()
            Using sqlComm As New MySqlCommand()
                With sqlComm
                    .Connection = dbconn
                    .CommandText = "SELECT TID, ExperienceRating, ReviewComments FROM Transaction"
                    .CommandType = CommandType.Text
                End With
                Try
                    Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                    While sqlReader.Read()
                        table.AddCell(sqlReader("TID").ToString())
                        table.AddCell(sqlReader("ExperienceRating").ToString())
                        table.AddCell(sqlReader("ReviewComments").ToString())
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
            SQLConnection.Instance.CloseConnection()

            feedbackReport.Add(table)
            feedbackReport.Close()
            pdfWriter.Close()
            stream.Close()

            MsgBox("Report saved to " & fpath)

            If PDFOption.Checked Then
                Process.Start(fpath)
            End If
        End If

        If ExcelOption.Checked Or BothOption.Checked Then
            Dim report As String = ""
            Dim fname As String = "Feedback " & DateTime.Now.ToString("yyyyMMdd HHmm") & ".csv"
            Dim fpath As String = Path.Combine(My.Computer.FileSystem.SpecialDirectories.Desktop, fname)
            Dim writer As New StreamWriter(fpath, True)
            writer.Write("TID,Rating,Comments")


            Dim dbconn As MySqlConnection = SQLConnection.Instance.GetConnection()
            Using sqlComm As New MySqlCommand()
                With sqlComm
                    .Connection = dbconn
                    .CommandText = "SELECT TID, ExperienceRating, ReviewComments FROM Transaction"
                    .CommandType = CommandType.Text
                End With
                Try
                    Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                    While sqlReader.Read()
                        Dim tid As Integer = CInt(sqlReader("TID").ToString())
                        Dim rating As Integer = CInt(sqlReader("ExperienceRating").ToString())
                        Dim comments As String = sqlReader("ReviewComments").ToString().Replace(",", ";").Replace(vbCr, " ").Replace(vbLf, " ").Replace(vbCrLf, " ")

                        Dim row As String = String.Format("{0}" & delim & "{1}" & delim & "{2}",
                                                         tid, rating, comments)

                        writer.Write(vbCrLf & row)
                    End While
                    writer.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
            SQLConnection.Instance.CloseConnection()

            MsgBox("Report saved to " & fpath)

            If ExcelOption.Checked Then
                Process.Start(fpath)
            End If
        End If
    End Sub

    Private Sub BranchButton_Click(sender As Object, e As EventArgs) Handles BranchButton.Click
        If PDFOption.Checked Or BothOption.Checked Then
            Dim branchReport As New Document(PageSize.LETTER.Rotate(), 10, 10, 30, 30)
            Dim fname As String = "Branches " & DateTime.Now.ToString("yyyyMMdd HHmm") & ".pdf"
            Dim fpath As String = Path.Combine(My.Computer.FileSystem.SpecialDirectories.Desktop, fname)
            Dim stream As New FileStream(fpath, FileMode.Create)
            Dim pdfWriter As PdfWriter = PdfWriter.GetInstance(branchReport, stream)

            With branchReport
                .AddAuthor("Group 10")
                .AddSubject("Summary of branches our company owns.")
                .AddTitle("Branch Report")
                .AddCreationDate()
                .Open()
            End With

            Dim table As New PdfPTable(6)
            table.WidthPercentage = 90
            Dim widths = New Integer() {1, 1, 1, 1, 1, 1}
            table.SetWidths(widths)
            Dim cell As New PdfPCell(New Phrase("Branches"))
            cell.Colspan = 6
            cell.HorizontalAlignment = 1
            table.AddCell(cell)

            table.AddCell("Branch ID")
            table.AddCell("Address")
            table.AddCell("Email")
            table.AddCell("Phone")
            table.AddCell("Fax")
            table.AddCell("Manager")

            Dim dbconn As MySqlConnection = SQLConnection.Instance.GetConnection()
            Using sqlComm As New MySqlCommand()
                With sqlComm
                    .Connection = dbconn
                    .CommandText = "SELECT BID, Branch.StreetAddress, Branch.PostalCode, Branch.City, Branch.State, Branch.Country, Branch.Email, Branch.Phone, Fax, FirstName, LastName FROM Branch JOIN Employee ON Branch.ManagerID = Employee.EID"
                    .CommandType = CommandType.Text
                End With
                Try
                    Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                    While sqlReader.Read()
                        table.AddCell(sqlReader("BID").ToString())

                        Dim address As String = sqlReader("StreetAddress").ToString() & " "
                        address &= sqlReader("PostalCode").ToString() & " "
                        address &= sqlReader("City").ToString() & " "
                        address &= sqlReader("State").ToString() & " "
                        address &= sqlReader("PostalCode").ToString() & " "
                        address &= sqlReader("Country").ToString()
                        table.AddCell(address)

                        table.AddCell(sqlReader("Email").ToString())
                        table.AddCell(sqlReader("Phone").ToString())
                        table.AddCell(sqlReader("Fax").ToString())

                        Dim name As String = sqlReader("FirstName").ToString() & " " & sqlReader("LastName").ToString()
                        table.AddCell(name)
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
            SQLConnection.Instance.CloseConnection()

            branchReport.Add(table)
            branchReport.Close()
            pdfWriter.Close()
            stream.Close()

            MsgBox("Report saved to " & fpath)

            If PDFOption.Checked Then
                Process.Start(fpath)
            End If
        End If

        If ExcelOption.Checked Or BothOption.Checked Then
            Dim report As String = ""
            Dim fname As String = "Branches " & DateTime.Now.ToString("yyyyMMdd HHmm") & ".csv"
            Dim fpath As String = Path.Combine(My.Computer.FileSystem.SpecialDirectories.Desktop, fname)
            Dim writer As New StreamWriter(fpath, True)
            writer.Write("Branch ID, Address, Email, Phone, Fax, Manager")


            Dim dbconn As MySqlConnection = SQLConnection.Instance.GetConnection()
            Using sqlComm As New MySqlCommand()
                With sqlComm
                    .Connection = dbconn
                    .CommandText = "SELECT BID, Branch.StreetAddress, Branch.PostalCode, Branch.City, Branch.State, Branch.Country, Branch.Email, Branch.Phone, Fax, FirstName, LastName FROM Branch JOIN Employee ON Branch.ManagerID = Employee.EID"
                    .CommandType = CommandType.Text
                End With
                Try
                    Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                    While sqlReader.Read()
                        Dim bid As Integer = CInt(sqlReader("BID").ToString())

                        Dim address As String = sqlReader("StreetAddress").ToString() & " "
                        address &= sqlReader("PostalCode").ToString() & " "
                        address &= sqlReader("City").ToString() & " "
                        address &= sqlReader("State").ToString() & " "
                        address &= sqlReader("PostalCode").ToString() & " "
                        address &= sqlReader("Country").ToString()
                        address = address.Replace(",", ";").Replace(vbCr, " ").Replace(vbLf, " ").Replace(vbCrLf, " ")

                        Dim email As String = sqlReader("Email").ToString().Replace(",", ";").Replace(vbCr, " ").Replace(vbLf, " ").Replace(vbCrLf, " ")
                        Dim phone As String = sqlReader("Phone").ToString().Replace(",", ";").Replace(vbCr, " ").Replace(vbLf, " ").Replace(vbCrLf, " ")
                        Dim fax As String = sqlReader("Fax").ToString().Replace(",", ";").Replace(vbCr, " ").Replace(vbLf, " ").Replace(vbCrLf, " ")
                        Dim manager As String = (sqlReader("FirstName").ToString() & " " & sqlReader("LastName").ToString()).Replace(",", ";").Replace(vbCr, " ").Replace(vbLf, " ").Replace(vbCrLf, " ")

                        ' Little trick to ensure the phone and fax are recognized as strings
                        phone &= vbTab
                        fax &= vbTab

                        Dim row As String = String.Format("{0}" & delim & "{1}" & delim & "{2}" & delim & "{3}" & delim & "{4}" & delim & "{5}",
                                                         bid, address, email, phone, fax, manager)

                        writer.Write(vbCrLf & row)
                    End While
                    writer.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
            SQLConnection.Instance.CloseConnection()

            MsgBox("Report saved to " & fpath)

            If ExcelOption.Checked Then
                Process.Start(fpath)
            End If
        End If
    End Sub

    Private Sub TypeButton_Click(sender As Object, e As EventArgs) Handles TypeButton.Click
        If PDFOption.Checked Or BothOption.Checked Then
            Dim branchReport As New Document(PageSize.LETTER, 10, 10, 30, 30)
            Dim fname As String = "Types " & DateTime.Now.ToString("yyyyMMdd HHmm") & ".pdf"
            Dim fpath As String = Path.Combine(My.Computer.FileSystem.SpecialDirectories.Desktop, fname)
            Dim stream As New FileStream(fpath, FileMode.Create)
            Dim pdfWriter As PdfWriter = PdfWriter.GetInstance(branchReport, stream)

            With branchReport
                .AddAuthor("Group 10")
                .AddSubject("Summary of vehicle types being offered.")
                .AddTitle("Type Report")
                .AddCreationDate()
                .Open()
            End With

            Dim table As New PdfPTable(4)
            table.WidthPercentage = 90
            Dim widths = New Integer() {1, 1, 1, 1}
            table.SetWidths(widths)
            Dim cell As New PdfPCell(New Phrase("Types"))
            cell.Colspan = 4
            cell.HorizontalAlignment = 1
            table.AddCell(cell)

            table.AddCell("Type")
            table.AddCell("Daily Rate")
            table.AddCell("Weekly Rate")
            table.AddCell("Monthly Rate")

            Dim dbconn As MySqlConnection = SQLConnection.Instance.GetConnection()
            Using sqlComm As New MySqlCommand()
                With sqlComm
                    .Connection = dbconn
                    .CommandText = "SELECT Type, DailyRate, WeeklyRate, MonthlyRate FROM Types"
                    .CommandType = CommandType.Text
                End With
                Try
                    Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                    While sqlReader.Read()
                        table.AddCell(sqlReader("Type").ToString())
                        table.AddCell(sqlReader("DailyRate").ToString())
                        table.AddCell(sqlReader("WeeklyRate").ToString())
                        table.AddCell(sqlReader("MonthlyRate").ToString())
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
            SQLConnection.Instance.CloseConnection()

            branchReport.Add(table)
            branchReport.Close()
            pdfWriter.Close()
            stream.Close()

            MsgBox("Report saved to " & fpath)

            If PDFOption.Checked Then
                Process.Start(fpath)
            End If
        End If

        If ExcelOption.Checked Or BothOption.Checked Then
            Dim report As String = ""
            Dim fname As String = "Types " & DateTime.Now.ToString("yyyyMMdd HHmm") & ".csv"
            Dim fpath As String = Path.Combine(My.Computer.FileSystem.SpecialDirectories.Desktop, fname)
            Dim writer As New StreamWriter(fpath, True)
            writer.Write("Type, Daily Rate, Weekly Rate, Monthly Rate")


            Dim dbconn As MySqlConnection = SQLConnection.Instance.GetConnection()
            Using sqlComm As New MySqlCommand()
                With sqlComm
                    .Connection = dbconn
                    .CommandText = "SELECT Type, DailyRate, WeeklyRate, MonthlyRate FROM Types"
                    .CommandType = CommandType.Text
                End With
                Try
                    Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                    While sqlReader.Read()
                        Dim type As String = sqlReader("Type").ToString().Replace(",", ";").Replace(vbCr, " ").Replace(vbLf, " ").Replace(vbCrLf, " ")
                        Dim drate As String = sqlReader("DailyRate").ToString().Replace(",", ";").Replace(vbCr, " ").Replace(vbLf, " ").Replace(vbCrLf, " ")
                        Dim wrate As String = sqlReader("WeeklyRate").ToString().Replace(",", ";").Replace(vbCr, " ").Replace(vbLf, " ").Replace(vbCrLf, " ")
                        Dim mrate As String = sqlReader("MonthlyRate").ToString().Replace(",", ";").Replace(vbCr, " ").Replace(vbLf, " ").Replace(vbCrLf, " ")


                        Dim row As String = String.Format("{0}" & delim & "{1}" & delim & "{2}" & delim & "{3}",
                                                         type, drate, wrate, mrate)

                        writer.Write(vbCrLf & row)
                    End While
                    writer.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
            SQLConnection.Instance.CloseConnection()

            MsgBox("Report saved to " & fpath)

            If ExcelOption.Checked Then
                Process.Start(fpath)
            End If
        End If
    End Sub
End Class