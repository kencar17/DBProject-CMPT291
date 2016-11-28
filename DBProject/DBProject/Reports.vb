Imports System.IO
Imports System.Reflection
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports MySql.Data.MySqlClient

Public Class Reports
    Private delim As String = ","
    Dim sql As String
    Dim params As New Dictionary(Of String, String)
    Dim columns As List(Of String)
    Dim results As List(Of Dictionary(Of String, String))

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

            sql = "SELECT Username, FirstName, LastName, StreetAddress, PostalCode, City, State, Country, Email, EID FROM User JOIN Employee ON User.PersonID = Employee.EID"
            columns = New List(Of String)
            With columns
                .Add("EID")
                .Add("Username")
                .Add("FirstName")
                .Add("LastName")
                .Add("StreetAddress")
                .Add("PostalCode")
                .Add("City")
                .Add("State")
                .Add("Email")
                .Add("Country")
            End With
            results = SQLConnection.DoQuery(sql, params, columns)

            For Each result As Dictionary(Of String, String) In results
                With table
                    .AddCell(result("EID"))
                    .AddCell(result("Username"))
                    .AddCell(result("FirstName") & " " & result("LastName"))
                    .AddCell(result("StreetAddress"))
                    .AddCell(result("PostalCode"))
                    .AddCell(result("City"))
                    .AddCell(result("State"))
                    .AddCell(result("Country"))
                    .AddCell(result("Email"))
                End With
            Next

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
            Dim writer As New StreamWriter(fpath, False)
            writer.Write("EID,Username,Name,Address,PostalCode,City,State,Country,Email")

            sql = "SELECT Username, FirstName, LastName, StreetAddress, PostalCode, City, State, Country, Email, EID FROM User JOIN Employee ON User.PersonID = Employee.EID"
            columns = New List(Of String)
            With columns
                .Add("EID")
                .Add("Username")
                .Add("FirstName")
                .Add("LastName")
                .Add("StreetAddress")
                .Add("PostalCode")
                .Add("City")
                .Add("Country")
                .Add("State")
                .Add("Email")
            End With
            results = SQLConnection.DoQuery(sql, params, columns)

            For Each result As Dictionary(Of String, String) In results
                Dim row As String = String.Format("{0}" & delim & "{1}" & delim & "{2}" & delim & "{3}" & delim & "{4}" & delim & "{5}" & delim & "{6}" & delim & "{7}" & delim & "{8}",
                                                          result("EID"), result("Username"), result("FirstName") & " " & result("LastName"),
                                                  result("StreetAddress"), result("PostalCode"), result("City"), result("State"), result("Country"), result("Email"))
                writer.Write(vbCrLf & row)
            Next
            writer.Close()

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

            sql = "SELECT TID, ExperienceRating, ReviewComments FROM Transaction"
            columns = New List(Of String)
            With columns
                .Add("TID")
                .Add("ExperienceRating")
                .Add("ReviewComments")
            End With
            results = SQLConnection.DoQuery(sql, params, columns)
            For Each result As Dictionary(Of String, String) In results
                With table
                    .AddCell(result("TID"))
                    .AddCell(result("ExperienceRating"))
                    .AddCell(result("ReviewComments"))
                End With
            Next


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
            Dim writer As New StreamWriter(fpath, False)
            writer.Write("TID,Rating,Comments")

            sql = "SELECT TID, ExperienceRating, ReviewComments FROM Transaction"
            columns = New List(Of String)
            With columns
                .Add("TID")
                .Add("ExperienceRating")
                .Add("ReviewComments")
            End With
            results = SQLConnection.DoQuery(sql, params, columns)
            For Each result As Dictionary(Of String, String) In results
                Dim row As String = String.Format("{0}" & delim & "{1}" & delim & "{2}",
                                                         result("TID"), result("ExperienceRating"), result("ReviewComments"))
                writer.Write(vbCrLf & row)
            Next
            writer.Close()

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

            Dim table As New PdfPTable(7)
            table.WidthPercentage = 90
            Dim widths = New Integer() {1, 4, 3, 2, 2, 2, 1}
            table.SetWidths(widths)
            Dim cell As New PdfPCell(New Phrase("Branches"))
            cell.Colspan = 7
            cell.HorizontalAlignment = 1
            table.AddCell(cell)

            table.AddCell("Branch ID")
            table.AddCell("Address")
            table.AddCell("Email")
            table.AddCell("Phone")
            table.AddCell("Fax")
            table.AddCell("Manager")
            table.AddCell("Vehicles")

            sql = "SELECT Branch.BID, Branch.StreetAddress, Branch.PostalCode, Branch.City, Branch.State, Branch.Country, Branch.Email, Branch.Phone, Fax, FirstName, LastName, Count(*) AS counter FROM Branch JOIN Employee ON Branch.ManagerID = Employee.EID JOIN Vehicle ON Vehicle.BID = Branch.BID GROUP BY Branch.BID"
            columns = New List(Of String)
            With columns
                .Add("BID")
                .Add("StreetAddress")
                .Add("PostalCode")
                .Add("City")
                .Add("State")
                .Add("Country")
                .Add("Email")
                .Add("Phone")
                .Add("Fax")
                .Add("FirstName")
                .Add("LastName")
                .Add("counter")
            End With
            results = SQLConnection.DoQuery(sql, params, columns)
            For Each result As Dictionary(Of String, String) In results
                With table
                    .AddCell(result("BID"))
                    Dim address As String = result("StreetAddress") & " "
                    address &= result("City") & " "
                    address &= result("State") & " "
                    address &= result("Country") & " "
                    address &= result("PostalCode") & " "
                    .AddCell(address)
                    .AddCell(result("Email"))
                    .AddCell(result("Phone"))
                    .AddCell(result("Fax"))
                    .AddCell(result("FirstName") & " " & result("LastName"))
                    .AddCell(result("counter"))
                End With
            Next


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
            Dim writer As New StreamWriter(fpath, False)
            writer.Write("Branch ID, Address, Email, Phone, Fax, Manager, Vehicles")

            sql = "SELECT Branch.BID, Branch.StreetAddress, Branch.PostalCode, Branch.City, Branch.State, Branch.Country, Branch.Email, Branch.Phone, Fax, FirstName, LastName, Count(*) AS counter FROM Branch JOIN Employee ON Branch.ManagerID = Employee.EID JOIN Vehicle ON Vehicle.BID = Branch.BID GROUP BY Branch.BID"
            columns = New List(Of String)
            With columns
                .Add("BID")
                .Add("StreetAddress")
                .Add("PostalCode")
                .Add("City")
                .Add("State")
                .Add("Country")
                .Add("Email")
                .Add("Phone")
                .Add("Fax")
                .Add("FirstName")
                .Add("LastName")
                .Add("counter")
            End With
            results = SQLConnection.DoQuery(sql, params, columns)
            For Each result As Dictionary(Of String, String) In results
                Dim address As String = result("StreetAddress") & " "
                address &= result("City") & " "
                address &= result("State") & " "
                address &= result("Country") & " "
                address &= result("PostalCode") & " "
                Dim row As String = String.Format("{0}" & delim & "{1}" & delim & "{2}" & delim & "{3}" & delim & "{4}" & delim & "{5}" & delim & "{6}",
                                                         result("BID"), address, result("Email"), result("Phone") & vbTab, result("Fax") & vbTab, result("FirstName") & " " & result("LastName"), result("counter"))
                writer.Write(vbCrLf & row)
            Next
            writer.Close()

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

            sql = "SELECT Type, DailyRate, WeeklyRate, MonthlyRate FROM Types"
            columns = New List(Of String)
            With columns
                .Add("Type")
                .Add("DailyRate")
                .Add("WeeklyRate")
                .Add("MonthlyRate")
            End With
            results = SQLConnection.DoQuery(sql, params, columns)
            For Each result As Dictionary(Of String, String) In results
                With table
                    .AddCell(result("Type"))
                    .AddCell(result("DailyRate"))
                    .AddCell(result("WeeklyRate"))
                    .AddCell(result("MonthlyRate"))
                End With
            Next

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
            Dim writer As New StreamWriter(fpath, False)
            writer.Write("Type, Daily Rate, Weekly Rate, Monthly Rate")

            sql = "SELECT Type, DailyRate, WeeklyRate, MonthlyRate FROM Types"
            columns = New List(Of String)
            With columns
                .Add("Type")
                .Add("DailyRate")
                .Add("WeeklyRate")
                .Add("MonthlyRate")
            End With
            results = SQLConnection.DoQuery(sql, params, columns)
            For Each result As Dictionary(Of String, String) In results
                Dim type As String = result("Type").Replace(",", ";").Replace(vbCr, " ").Replace(vbLf, " ").Replace(vbCrLf, " ")
                Dim drate As String = result("DailyRate").Replace(",", ";").Replace(vbCr, " ").Replace(vbLf, " ").Replace(vbCrLf, " ")
                Dim wrate As String = result("WeeklyRate").Replace(",", ";").Replace(vbCr, " ").Replace(vbLf, " ").Replace(vbCrLf, " ")
                Dim mrate As String = result("MonthlyRate").Replace(",", ";").Replace(vbCr, " ").Replace(vbLf, " ").Replace(vbCrLf, " ")


                Dim row As String = String.Format("{0}" & delim & "{1}" & delim & "{2}" & delim & "{3}",
                                                 type, drate, wrate, mrate)

                writer.Write(vbCrLf & row)
            Next
            writer.Close()

            MsgBox("Report saved to " & fpath)

            If ExcelOption.Checked Then
                Process.Start(fpath)
            End If
        End If
    End Sub

    Private Sub VehicleButton_Click(sender As Object, e As EventArgs) Handles VehicleButton.Click
        Dim sql As String = "SELECT Vehicle.VIN, Make, Model, Class, Km, Year, Seats, GVWR, Transmission, License, Available, Coverage, Branch.StreetAddress, Branch.City, Branch.State, COUNT(Transaction.VIN) AS Rentals FROM Vehicle LEFT JOIN Transaction ON Vehicle.VIN = Transaction.VIN JOIN Branch ON Vehicle.BID = Branch.BID GROUP BY Vehicle.VIN"
        Dim params As New Dictionary(Of String, String)
        Dim columns As New List(Of String)
        With columns
            .Add("VIN")
            .Add("Make")
            .Add("Model")
            .Add("Class")
            .Add("Km")
            .Add("Year")
            .Add("Seats")
            .Add("GVWR")
            .Add("Transmission")
            .Add("License")
            .Add("Available")
            .Add("Coverage")
            .Add("StreetAddress")
            .Add("City")
            .Add("State")
            .Add("Rentals")
        End With

        Dim vehicles As New List(Of Vehicle)
        For Each result As Dictionary(Of String, String) In SQLConnection.DoQuery(sql, params, columns)
            Dim newvehicle As New Vehicle
            With newvehicle
                .VinProperty = result("VIN")
                .MakeProperty = result("Make")
                .ModelProperty = result("Model")
                .VClassProperty = result("Class")
                .KmProperty = result("Km")
                .YearProperty = result("Year")
                .SeatsProperty = result("Seats")
                .GvwrProperty = result("GVWR")
                .TransmissionProperty = If(result("Transmission").Equals("0"), "Standard", "Automatic")
                .LicenseProperty = result("License")
                .AvailableProperty = result("Available")
                .CoverageProperty = result("Coverage")
                .StreetAddressProperty = result("StreetAddress")
                .CityProperty = result("City")
                .StateProperty = result("State")
                .RentalsProperty = result("Rentals")
            End With
            vehicles.Add(newvehicle)
        Next

        ' Start PDF

        If PDFOption.Checked Or BothOption.Checked Then
            Dim branchReport As New Document(PageSize.A3.Rotate(), 10, 10, 30, 30)
            Dim fname As String = "Vehicles " & DateTime.Now.ToString("yyyyMMdd HHmm") & ".pdf"
            Dim fpath As String = Path.Combine(My.Computer.FileSystem.SpecialDirectories.Desktop, fname)
            Dim stream As New FileStream(fpath, FileMode.Create)
            Dim pdfWriter As PdfWriter = PdfWriter.GetInstance(branchReport, stream)

            With branchReport
                .AddAuthor("Group 10")
                .AddSubject("Summary of vehicles being offered.")
                .AddTitle("Vehicle Report")
                .AddCreationDate()
                .Open()
            End With

            Dim table As New PdfPTable(16)
            table.WidthPercentage = 90
            Dim widths = New Integer() {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}
            table.SetWidths(widths)
            Dim cell As New PdfPCell(New Phrase("Vehicles"))
            cell.Colspan = 16
            cell.HorizontalAlignment = 1
            table.AddCell(cell)

            With table
                .AddCell("VIN")
                .AddCell("Make")
                .AddCell("Model")
                .AddCell("Class")
                .AddCell("KM")
                .AddCell("Year")
                .AddCell("Seats")
                .AddCell("GVWR")
                .AddCell("Transmission")
                .AddCell("License")
                .AddCell("Available")
                .AddCell("Coverage")
                .AddCell("Street Address")
                .AddCell("City")
                .AddCell("State")
                .AddCell("Rentals")
            End With

            For Each vehicle In vehicles
                For Each value As PropertyInfo In vehicle.GetType().GetProperties()
                    If value.CanRead Then
                        table.AddCell(value.GetValue(vehicle, Nothing))
                    End If
                Next
            Next

            branchReport.Add(table)
            branchReport.Close()
            pdfWriter.Close()
            stream.Close()

            MsgBox("Report saved to " & fpath)

            If PDFOption.Checked Then
                Process.Start(fpath)
            End If
        End If

        ' Start Excel

        If ExcelOption.Checked Or BothOption.Checked Then
            Dim report As String = ""
            Dim fname As String = "Types " & DateTime.Now.ToString("yyyyMMdd HHmm") & ".csv"
            Dim fpath As String = Path.Combine(My.Computer.FileSystem.SpecialDirectories.Desktop, fname)
            Dim writer As New StreamWriter(fpath, False)
            writer.Write("VIN, Make, Model, Class, KM, Year, Seats, GVWR, Transmission, License, Available, Coverage, Street Address, City, State, Rentals")

            For Each vehicle In vehicles
                With vehicle
                    Dim row As String = String.Format("{0}" & delim & "{1}" & delim & "{2}" & delim & "{3}" & delim & "{4}" & delim & "{5}" & delim & "{6}" & delim & "{7}" & delim & "{8}" & delim & "{9}" & delim & "{10}" & delim & "{11}" & delim & "{12}" & delim & "{13}" & delim & "{14}" & delim & "{15}",
                                                      .VinProperty & vbTab, .MakeProperty, .ModelProperty, .VClassProperty, .KmProperty, .YearProperty,
                                                      .SeatsProperty, .GvwrProperty, .TransmissionProperty, .LicenseProperty, .AvailableProperty,
                                                      .CoverageProperty, .StreetAddressProperty, .CityProperty, .StateProperty, .RentalsProperty)
                    writer.Write(vbCrLf & row)
                End With
            Next
            writer.Close()

            MsgBox("Report saved to " & fpath)

            If ExcelOption.Checked Then
                Process.Start(fpath)
            End If
        End If
    End Sub

    Private Class Vehicle
        Private VIN As String
        Private Make As String
        Private Model As String
        Private VClass As String
        Private Km As String
        Private Year As String
        Private Seats As String
        Private GVWR As String
        Private Transmission As String
        Private License As String
        Private Available As String
        Private Coverage As String
        Private StreetAddress As String
        Private City As String
        Private State As String
        Private Rentals As String

        Public Property VinProperty As String
            Get
                Return VIN
            End Get
            Set
                VIN = Value
            End Set
        End Property

        Public Property MakeProperty As String
            Get
                Return Make
            End Get
            Set
                Make = Value
            End Set
        End Property

        Public Property ModelProperty As String
            Get
                Return Model
            End Get
            Set
                Model = Value
            End Set
        End Property

        Public Property VClassProperty As String
            Get
                Return VClass
            End Get
            Set
                VClass = Value
            End Set
        End Property

        Public Property KmProperty As String
            Get
                Return Km
            End Get
            Set
                Km = Value
            End Set
        End Property

        Public Property YearProperty As String
            Get
                Return Year
            End Get
            Set
                Year = Value
            End Set
        End Property

        Public Property SeatsProperty As String
            Get
                Return Seats
            End Get
            Set
                Seats = Value
            End Set
        End Property

        Public Property GvwrProperty As String
            Get
                Return GVWR
            End Get
            Set
                GVWR = Value
            End Set
        End Property

        Public Property TransmissionProperty As String
            Get
                Return Transmission
            End Get
            Set
                Transmission = Value
            End Set
        End Property

        Public Property LicenseProperty As String
            Get
                Return License
            End Get
            Set
                License = Value
            End Set
        End Property

        Public Property AvailableProperty As String
            Get
                Return Available
            End Get
            Set
                Available = Value
            End Set
        End Property

        Public Property CoverageProperty As String
            Get
                Return Coverage
            End Get
            Set
                Coverage = Value
            End Set
        End Property

        Public Property StreetAddressProperty As String
            Get
                Return StreetAddress
            End Get
            Set
                StreetAddress = Value
            End Set
        End Property

        Public Property CityProperty As String
            Get
                Return City
            End Get
            Set
                City = Value
            End Set
        End Property

        Public Property StateProperty As String
            Get
                Return State
            End Get
            Set
                State = Value
            End Set
        End Property

        Public Property RentalsProperty As String
            Get
                Return Rentals
            End Get
            Set
                Rentals = Value
            End Set
        End Property
    End Class
End Class
