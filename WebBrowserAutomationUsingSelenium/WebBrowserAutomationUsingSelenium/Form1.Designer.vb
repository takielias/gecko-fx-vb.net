<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mainform
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
        Me.AutomateGoogleButton = New System.Windows.Forms.Button()
        Me.AutomateUsingFirefox = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AutomateGoogleButton
        '
        Me.AutomateGoogleButton.Location = New System.Drawing.Point(12, 50)
        Me.AutomateGoogleButton.Name = "AutomateGoogleButton"
        Me.AutomateGoogleButton.Size = New System.Drawing.Size(121, 34)
        Me.AutomateGoogleButton.TabIndex = 0
        Me.AutomateGoogleButton.Text = "AutomateGoogleUsingChrome"
        Me.AutomateGoogleButton.UseVisualStyleBackColor = True
        '
        'AutomateUsingFirefox
        '
        Me.AutomateUsingFirefox.Location = New System.Drawing.Point(202, 50)
        Me.AutomateUsingFirefox.Name = "AutomateUsingFirefox"
        Me.AutomateUsingFirefox.Size = New System.Drawing.Size(130, 34)
        Me.AutomateUsingFirefox.TabIndex = 1
        Me.AutomateUsingFirefox.Text = "AutomateUsingFirefox"
        Me.AutomateUsingFirefox.UseVisualStyleBackColor = True
        '
        'Mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 294)
        Me.Controls.Add(Me.AutomateUsingFirefox)
        Me.Controls.Add(Me.AutomateGoogleButton)
        Me.Name = "Mainform"
        Me.Text = "MainForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AutomateGoogleButton As System.Windows.Forms.Button
    Friend WithEvents AutomateUsingFirefox As System.Windows.Forms.Button

End Class
