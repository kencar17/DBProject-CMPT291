Imports System.IO
Imports DBProject.My.Resources

Public Class Help
    Public Shared Sub GetHelp(Optional section As String = Nothing)
        Dim cwd As String = Directory.GetCurrentDirectory()
        Dim url As String = "file://" & cwd & "\Help\index.html"
        If Not section Is Nothing Then
            url = url & "#" & section
        End If
        Console.WriteLine(url)
        Process.Start(url)
    End Sub
End Class
