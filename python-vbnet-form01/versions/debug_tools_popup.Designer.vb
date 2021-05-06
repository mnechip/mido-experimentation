<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class debug_tools_popup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.leftPanel = New System.Windows.Forms.Panel()
        Me.btnOpenOutput = New System.Windows.Forms.Button()
        Me.filePathPanel = New System.Windows.Forms.Panel()
        Me.filePathLabel = New System.Windows.Forms.Label()
        Me.centerPanel = New System.Windows.Forms.Panel()
        Me.rightPanel = New System.Windows.Forms.Panel()
        Me.dcrFilePathPanel = New System.Windows.Forms.Panel()
        Me.dcrFilePathLbl = New System.Windows.Forms.Label()
        Me.leftPanel.SuspendLayout()
        Me.filePathPanel.SuspendLayout()
        Me.dcrFilePathPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'leftPanel
        '
        Me.leftPanel.BackColor = System.Drawing.Color.LightCyan
        Me.leftPanel.Controls.Add(Me.btnOpenOutput)
        Me.leftPanel.Location = New System.Drawing.Point(33, 73)
        Me.leftPanel.Name = "leftPanel"
        Me.leftPanel.Size = New System.Drawing.Size(122, 232)
        Me.leftPanel.TabIndex = 0
        '
        'btnOpenOutput
        '
        Me.btnOpenOutput.Location = New System.Drawing.Point(8, 8)
        Me.btnOpenOutput.Name = "btnOpenOutput"
        Me.btnOpenOutput.Size = New System.Drawing.Size(106, 23)
        Me.btnOpenOutput.TabIndex = 0
        Me.btnOpenOutput.Text = "Open midiOutput"
        Me.btnOpenOutput.UseVisualStyleBackColor = True
        '
        'filePathPanel
        '
        Me.filePathPanel.BackColor = System.Drawing.Color.LightCyan
        Me.filePathPanel.Controls.Add(Me.filePathLabel)
        Me.filePathPanel.Location = New System.Drawing.Point(33, 42)
        Me.filePathPanel.Name = "filePathPanel"
        Me.filePathPanel.Size = New System.Drawing.Size(378, 25)
        Me.filePathPanel.TabIndex = 1
        '
        'filePathLabel
        '
        Me.filePathLabel.AutoSize = True
        Me.filePathLabel.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.filePathLabel.Location = New System.Drawing.Point(4, 6)
        Me.filePathLabel.Name = "filePathLabel"
        Me.filePathLabel.Size = New System.Drawing.Size(51, 13)
        Me.filePathLabel.TabIndex = 1
        Me.filePathLabel.Text = "File Path"
        '
        'centerPanel
        '
        Me.centerPanel.BackColor = System.Drawing.Color.LightCyan
        Me.centerPanel.Location = New System.Drawing.Point(161, 73)
        Me.centerPanel.Name = "centerPanel"
        Me.centerPanel.Size = New System.Drawing.Size(122, 232)
        Me.centerPanel.TabIndex = 1
        '
        'rightPanel
        '
        Me.rightPanel.BackColor = System.Drawing.Color.LightCyan
        Me.rightPanel.Location = New System.Drawing.Point(289, 73)
        Me.rightPanel.Name = "rightPanel"
        Me.rightPanel.Size = New System.Drawing.Size(122, 232)
        Me.rightPanel.TabIndex = 2
        '
        'dcrFilePathPanel
        '
        Me.dcrFilePathPanel.BackColor = System.Drawing.Color.LightCyan
        Me.dcrFilePathPanel.Controls.Add(Me.dcrFilePathLbl)
        Me.dcrFilePathPanel.Location = New System.Drawing.Point(33, 12)
        Me.dcrFilePathPanel.Name = "dcrFilePathPanel"
        Me.dcrFilePathPanel.Size = New System.Drawing.Size(67, 25)
        Me.dcrFilePathPanel.TabIndex = 2
        '
        'dcrFilePathLbl
        '
        Me.dcrFilePathLbl.AutoSize = True
        Me.dcrFilePathLbl.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.dcrFilePathLbl.Location = New System.Drawing.Point(6, 3)
        Me.dcrFilePathLbl.Name = "dcrFilePathLbl"
        Me.dcrFilePathLbl.Size = New System.Drawing.Size(56, 17)
        Me.dcrFilePathLbl.TabIndex = 0
        Me.dcrFilePathLbl.Text = "File Path"
        '
        'debug_tools_popup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 319)
        Me.Controls.Add(Me.dcrFilePathPanel)
        Me.Controls.Add(Me.rightPanel)
        Me.Controls.Add(Me.centerPanel)
        Me.Controls.Add(Me.filePathPanel)
        Me.Controls.Add(Me.leftPanel)
        Me.Name = "debug_tools_popup"
        Me.Text = "9-"
        Me.leftPanel.ResumeLayout(False)
        Me.filePathPanel.ResumeLayout(False)
        Me.filePathPanel.PerformLayout()
        Me.dcrFilePathPanel.ResumeLayout(False)
        Me.dcrFilePathPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents leftPanel As Panel
    Friend WithEvents filePathPanel As Panel
    Friend WithEvents centerPanel As Panel
    Friend WithEvents rightPanel As Panel
    Friend WithEvents dcrFilePathPanel As Panel
    Friend WithEvents filePathLabel As Label
    Friend WithEvents dcrFilePathLbl As Label
    Friend WithEvents btnOpenOutput As Button
End Class
