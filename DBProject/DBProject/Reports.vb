Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports MySql.Data.MySqlClient

Public Class Reports
    Private Sub ViewUsersButton_Click(sender As Object, e As EventArgs) Handles ViewUsersButton.Click
        Dim userReport As New Document(PageSize.LETTER.Rotate(), 10, 10, 30, 30)
        Dim fname As String = "Users " & DateTime.Now.ToString("yyyyMMdd HHmm") & ".pdf"
        Dim fpath As String = Path.Combine(My.Computer.FileSystem.SpecialDirectories.Desktop, fname)
        Dim stream As New FileStream(fpath, FileMode.Create)
        Dim pdfWriter As PdfWriter = pdf.PdfWriter.GetInstance(userReport, stream)

        userReport.AddAuthor("Group 10")
        userReport.AddSubject("Summary of all users registered in the system")
        userReport.AddTitle("User Report")
        userReport.AddCreationDate()
        userReport.Open()

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
                    Dim email As String = sqlReader("Email").ToString()
                    Dim emailLink As New Anchor(email)
                    emailLink.Reference = "mailto:" & email
                    table.AddCell(emailLink)
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
        Process.Start(fpath)
    End Sub

    Private Sub HelpButton_Click(sender As Object, e As EventArgs) Handles HelpButton.Click
        Help.GetHelp("reports")
    End Sub
End Class