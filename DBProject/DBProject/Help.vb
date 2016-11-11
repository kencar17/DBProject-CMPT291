Imports System.IO
Imports DBProject.My.Resources

Public Class Help
    Public Shared Sub GetHelp(Optional section As String = Nothing)
        Dim url As String = "https://elln2.github.io/DBProject/"
        If Not section Is Nothing Then
            url = url & section
        End If
        Process.Start(url)
    End Sub
End Class
