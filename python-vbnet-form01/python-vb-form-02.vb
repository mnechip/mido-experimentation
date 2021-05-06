Public Class midiForm
    Dim path As String = My.Application.Info.DirectoryPath 'Sets 'path' variable to the current app dir
    Dim ExitYN As System.Windows.Forms.DialogResult
    Dim FileYN As System.Windows.Forms.DialogResult
    Dim popUpOne As imageBox
    Dim filesArray(5) As String
    Dim filesList As List(Of String) = New List(Of String)()

    'Loads sample objects for list
    Private Sub midiForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pathLabel.Visible = False
        listBoxFiles.Visible = True
        CreateMenu()
        filesList.Add("test1")
        filesList.Add("Atest1")
        filesList.Add("Btest10")

        'For each item in list, add items to list object
        For Each item In filesList
            listBoxFiles.Items.Add(item)
        Next
    End Sub

    'Midi sorting script button
    Private Sub scriptButton_Click(sender As Object, e As EventArgs) Handles scriptButton.Click
        FileYN = MsgBox("Run python script?", MsgBoxStyle.YesNo)
        If FileYN = MsgBoxResult.Yes Then
            Process.Start(path & "\Resources\mido_experimentation.exe", vbHide) 'Starts the python executable from directory
        Else
        End If
    End Sub

    'Exit button code
    Private Sub exitButton_Click(sender As Object, e As EventArgs)
        ExitYN = MsgBox("Do you really want to exit?", MsgBoxStyle.YesNo)
        If ExitYN = MsgBoxResult.Yes Then
            Application.Exit() 'Code to handle quit button, with Y/N interface
        Else
        End If
    End Sub

    'File path label visibility
    Private Sub pathBox_CheckedChanged(sender As Object, e As EventArgs) Handles pathBox.CheckedChanged
        If pathBox.Checked = True Then
            pathLabel.Visible = True
            pathLabel.Text = path
        End If
        If pathBox.Checked = False Then
            pathLabel.Visible = False
        End If
    End Sub

    'ListBoxFiles visibility
    Private Sub chkArrayShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkArrayShow.CheckedChanged
        If chkArrayShow.Checked = True Then
            listBoxFiles.Visible = True
        End If
        If chkArrayShow.Checked = False Then
            listBoxFiles.Visible = False
        End If
    End Sub
    Public Sub CreateMenu()

        '1.Define Main Menu and top level MenuItem
        Dim menuStrip1 As New MenuStrip
        Dim toolStripFileMenuItem As New ToolStripMenuItem("File")
        Dim toolStripEditMenuItem As New ToolStripMenuItem("Edit")
        Dim toolStripRunMenuItem As New ToolStripMenuItem("Run")
        '2.Define and Add sub menu items under File Menu
        Dim openFileItem As New ToolStripMenuItem("&Open")
        Dim exitMenuItem As New ToolStripMenuItem("&Exit")
        toolStripFileMenuItem.DropDownItems.Add(openFileItem)
        toolStripFileMenuItem.DropDownItems.Add(exitMenuItem)

        '2.1 Add Edit Submenu Items
        Dim clearTextItem As New ToolStripMenuItem("&Clear Midi Output")
        toolStripEditMenuItem.DropDownItems.Add(clearTextItem)

        '2.5. Add Run Submenu Items
        Dim runMidReadItem As New ToolStripMenuItem("&Run Midi Reader")
        Dim runPopupItem As New ToolStripMenuItem("&Run Popup Test")
        toolStripRunMenuItem.DropDownItems.Add(runMidReadItem)
        toolStripRunMenuItem.DropDownItems.Add(runPopupItem)

        '3.Add File Menu to MenuStrip
        menuStrip1.Items.Add(toolStripFileMenuItem)
        menuStrip1.Items.Add(toolStripEditMenuItem)
        menuStrip1.Items.Add(toolStripRunMenuitem)

        '4.Add Menu Strip to the Form.
        Me.Controls.Add(menuStrip1)
        Me.MainMenuStrip = menuStrip1

        '5.Adding functionality to the Exit MenuItem using Click event 
        AddHandler exitMenuItem.Click, AddressOf Me.exitMenuItem_Click
        AddHandler runMidReadItem.Click, AddressOf Me.runMidiReadItem_Click
        AddHandler runPopupItem.Click, AddressOf Me.runPopupItem_Click

    End Sub

    Private Sub exitMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        ExitYN = MsgBox("Do you really want to exit?", MsgBoxStyle.YesNo)
        If ExitYN = MsgBoxResult.Yes Then
            Application.Exit() 'Code to handle quit button, with Y/N interface
        Else
        End If
    End Sub
    Private Sub runMidiReadItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        FileYN = MsgBox("Run python script?", MsgBoxStyle.YesNo)
        If FileYN = MsgBoxResult.Yes Then
            Process.Start(path & "\Resources\mido_experimentation.exe", vbHide) 'Starts the python executable from directory
        Else
        End If
    End Sub
    Private Sub runPopupItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        imageBox.newYearBox.Image = Image.FromFile(path & "\Resources\placeholder.jpg")
        imageBox.Show()
    End Sub

End Class

