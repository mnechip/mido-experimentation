Public Class debug_tools_popup
    Dim debugToolsPopup As New Form
    Dim path As String = My.Application.Info.DirectoryPath 'Sets 'path' variable to the current app dir
    Dim FILE_NAME As String = path & "\Resources\midiOutput.txt"
    Private Sub debug_tools_popup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = System.Drawing.ColorTranslator.FromHtml("#A9D1D4")
        Me.Text = "Debug Tools"
    End Sub

    Private Sub btnOpenOutput_Click(sender As Object, e As EventArgs) Handles btnOpenOutput.Click
        If System.IO.File.Exists(FILE_NAME) = True Then
            Process.Start(FILE_NAME)
        Else
            MsgBox("File does not exist.")
        End If
    End Sub
End Class