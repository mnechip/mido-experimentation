Public Class midiForm
    Dim path As String = My.Application.Info.DirectoryPath 'Sets 'path' variable to the current app dir
    Dim ExitYN As System.Windows.Forms.DialogResult
    Private Sub midiForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pathLabel.Visible = False
        pathTitle.Visible = False
    End Sub

    Private Sub scriptButton_Click(sender As Object, e As EventArgs) Handles scriptButton.Click
        Process.Start(path & "\Resources\mido_experimentation.exe", vbHide) 'Starts the python executable from directory
    End Sub
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        ExitYN = MsgBox("Do you really want to exit?", MsgBoxStyle.YesNo)
        If ExitYN = MsgBoxResult.Yes Then
            Application.Exit() 'Code to handle quit button, with Y/N interface
        Else
        End If
    End Sub
    Private Sub pathBox_CheckedChanged(sender As Object, e As EventArgs) Handles pathBox.CheckedChanged
        If pathBox.Checked = True Then
            pathLabel.Visible = True
            pathTitle.Visible = True
            pathLabel.Text = path
        End If
        If pathBox.Checked = False Then
            pathLabel.Visible = False
            pathTitle.Visible = False
        End If
    End Sub

    Private Sub pathLabel_Click(sender As Object, e As EventArgs) Handles pathLabel.Click

    End Sub
End Class
