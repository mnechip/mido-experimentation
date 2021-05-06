<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DebugTools
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
        Me.pathTitle = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pathTitle
        '
        Me.pathTitle.AutoSize = True
        Me.pathTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pathTitle.Location = New System.Drawing.Point(50, 37)
        Me.pathTitle.Name = "pathTitle"
        Me.pathTitle.Size = New System.Drawing.Size(56, 17)
        Me.pathTitle.TabIndex = 7
        Me.pathTitle.Text = "File Path"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pathTitle)
        Me.Panel1.Location = New System.Drawing.Point(12, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 100)
        Me.Panel1.TabIndex = 8
        '
        'DebugTools
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ClientSize = New System.Drawing.Size(540, 414)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "DebugTools"
        Me.Text = "DebugTools"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pathTitle As Label
    Friend WithEvents Panel1 As Panel
End Class
