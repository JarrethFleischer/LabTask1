<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDescription
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDescription))
        Me.noButton2 = New System.Windows.Forms.Button()
        Me.yesButton3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'noButton2
        '
        Me.noButton2.Font = New System.Drawing.Font("Javanese Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.noButton2.Location = New System.Drawing.Point(455, 307)
        Me.noButton2.Name = "noButton2"
        Me.noButton2.Size = New System.Drawing.Size(209, 100)
        Me.noButton2.TabIndex = 7
        Me.noButton2.Text = "Back"
        Me.noButton2.UseVisualStyleBackColor = True
        '
        'yesButton3
        '
        Me.yesButton3.Font = New System.Drawing.Font("Javanese Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.yesButton3.Location = New System.Drawing.Point(183, 307)
        Me.yesButton3.Name = "yesButton3"
        Me.yesButton3.Size = New System.Drawing.Size(209, 100)
        Me.yesButton3.TabIndex = 6
        Me.yesButton3.Text = "Yes"
        Me.yesButton3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Stencil", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(300, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 33)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Are you ready?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(26, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(797, 92)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "When you are playing the game, you must complete all missions given to you " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and " &
    "you can collect rare items to your inventory " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for future use that can help you " &
    "fight the final boss." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormDescription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(847, 496)
        Me.Controls.Add(Me.noButton2)
        Me.Controls.Add(Me.yesButton3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormDescription"
        Me.Text = "Description"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents noButton2 As Button
    Friend WithEvents yesButton3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
