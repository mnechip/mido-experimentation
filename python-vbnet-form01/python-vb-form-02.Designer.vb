<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class midiForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.scriptButton = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkArrayShow = New System.Windows.Forms.CheckBox()
        Me.sortButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pathBox = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.versionLabel = New System.Windows.Forms.Label()
        Me.pathLabel = New System.Windows.Forms.Label()
        Me.pathTitle = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.listBoxSorted = New System.Windows.Forms.ListBox()
        Me.listBoxFiles = New System.Windows.Forms.ListBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'scriptButton
        '
        Me.scriptButton.FlatAppearance.BorderSize = 0
        Me.scriptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.scriptButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scriptButton.ForeColor = System.Drawing.Color.White
        Me.scriptButton.Location = New System.Drawing.Point(1, 27)
        Me.scriptButton.Name = "scriptButton"
        Me.scriptButton.Size = New System.Drawing.Size(123, 52)
        Me.scriptButton.TabIndex = 0
        Me.scriptButton.Text = "Run .py Script"
        Me.scriptButton.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.AllowDrop = True
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.chkArrayShow)
        Me.Panel1.Controls.Add(Me.sortButton)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.pathBox)
        Me.Panel1.Controls.Add(Me.scriptButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(129, 349)
        Me.Panel1.TabIndex = 3
        '
        'chkArrayShow
        '
        Me.chkArrayShow.AutoSize = True
        Me.chkArrayShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkArrayShow.Location = New System.Drawing.Point(18, 296)
        Me.chkArrayShow.Name = "chkArrayShow"
        Me.chkArrayShow.Size = New System.Drawing.Size(81, 17)
        Me.chkArrayShow.TabIndex = 12
        Me.chkArrayShow.Text = "Show Array"
        Me.chkArrayShow.UseVisualStyleBackColor = True
        '
        'sortButton
        '
        Me.sortButton.FlatAppearance.BorderSize = 0
        Me.sortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sortButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sortButton.ForeColor = System.Drawing.Color.White
        Me.sortButton.Location = New System.Drawing.Point(3, 82)
        Me.sortButton.Name = "sortButton"
        Me.sortButton.Size = New System.Drawing.Size(123, 52)
        Me.sortButton.TabIndex = 11
        Me.sortButton.Text = "Run Sort"
        Me.sortButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Beige
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 246)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 21)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Debug Tools"
        '
        'pathBox
        '
        Me.pathBox.AutoSize = True
        Me.pathBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pathBox.Location = New System.Drawing.Point(18, 273)
        Me.pathBox.Name = "pathBox"
        Me.pathBox.Size = New System.Drawing.Size(95, 17)
        Me.pathBox.TabIndex = 9
        Me.pathBox.Text = "Directory Path"
        Me.pathBox.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Panel2.Controls.Add(Me.versionLabel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(129, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(500, 37)
        Me.Panel2.TabIndex = 4
        '
        'versionLabel
        '
        Me.versionLabel.AutoSize = True
        Me.versionLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.versionLabel.Location = New System.Drawing.Point(6, 9)
        Me.versionLabel.Name = "versionLabel"
        Me.versionLabel.Size = New System.Drawing.Size(255, 21)
        Me.versionLabel.TabIndex = 5
        Me.versionLabel.Text = "VB/Python 3.9 MIDI Interface v0.1.1"
        '
        'pathLabel
        '
        Me.pathLabel.AutoSize = True
        Me.pathLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pathLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pathLabel.Location = New System.Drawing.Point(140, 121)
        Me.pathLabel.Name = "pathLabel"
        Me.pathLabel.Size = New System.Drawing.Size(53, 15)
        Me.pathLabel.TabIndex = 5
        Me.pathLabel.Text = "File Path"
        '
        'pathTitle
        '
        Me.pathTitle.AutoSize = True
        Me.pathTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pathTitle.Location = New System.Drawing.Point(139, 102)
        Me.pathTitle.Name = "pathTitle"
        Me.pathTitle.Size = New System.Drawing.Size(56, 17)
        Me.pathTitle.TabIndex = 6
        Me.pathTitle.Text = "File Path"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'listBoxSorted
        '
        Me.listBoxSorted.FormattingEnabled = True
        Me.listBoxSorted.Location = New System.Drawing.Point(269, 151)
        Me.listBoxSorted.Name = "listBoxSorted"
        Me.listBoxSorted.Size = New System.Drawing.Size(121, 173)
        Me.listBoxSorted.TabIndex = 8
        '
        'listBoxFiles
        '
        Me.listBoxFiles.FormattingEnabled = True
        Me.listBoxFiles.Location = New System.Drawing.Point(142, 151)
        Me.listBoxFiles.Name = "listBoxFiles"
        Me.listBoxFiles.Size = New System.Drawing.Size(121, 173)
        Me.listBoxFiles.TabIndex = 7
        '
        'midiForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 349)
        Me.Controls.Add(Me.listBoxSorted)
        Me.Controls.Add(Me.listBoxFiles)
        Me.Controls.Add(Me.pathTitle)
        Me.Controls.Add(Me.pathLabel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "midiForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MIDI Interface v0.1.0"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents scriptButton As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents versionLabel As Label
    Friend WithEvents pathLabel As Label
    Friend WithEvents pathBox As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pathTitle As Label
    Friend WithEvents sortButton As Button
    Friend WithEvents chkArrayShow As CheckBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents listBoxSorted As ListBox
    Friend WithEvents listBoxFiles As ListBox
End Class
