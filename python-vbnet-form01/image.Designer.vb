<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class imageBox
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
        Me.newYearBox = New System.Windows.Forms.PictureBox()
        CType(Me.newYearBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'newYearBox
        '
        Me.newYearBox.Location = New System.Drawing.Point(12, 12)
        Me.newYearBox.Name = "newYearBox"
        Me.newYearBox.Size = New System.Drawing.Size(253, 213)
        Me.newYearBox.TabIndex = 0
        Me.newYearBox.TabStop = False
        '
        'imageBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 237)
        Me.Controls.Add(Me.newYearBox)
        Me.Name = "imageBox"
        Me.Text = "image"
        CType(Me.newYearBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents newYearBox As PictureBox
End Class
