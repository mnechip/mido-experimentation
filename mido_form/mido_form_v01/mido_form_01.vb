Public Class mido_form_01
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ReturnValue
        ReturnValue = Process.Start("C:\python39\python ""C:\Users\abc\source\repos\mnechip\mido-experimentation.py"" ", vbHide)
    End Sub
End Class
