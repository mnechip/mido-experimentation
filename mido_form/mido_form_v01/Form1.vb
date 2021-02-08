Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        obj = CreateObject("Wscript.Shell")
        obj.run("C:\Users\abc\source\repos\mnechip\mido-experimentation")
    End Sub
End Class
