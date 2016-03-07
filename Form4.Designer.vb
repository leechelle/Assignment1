<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MemberInfo = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtBack = New System.Windows.Forms.Button()
        Me.ButtExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(133, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Membership Information"
        '
        'MemberInfo
        '
        Me.MemberInfo.FormattingEnabled = True
        Me.MemberInfo.Location = New System.Drawing.Point(131, 116)
        Me.MemberInfo.Name = "MemberInfo"
        Me.MemberInfo.Size = New System.Drawing.Size(121, 21)
        Me.MemberInfo.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(49, 239)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Display"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ButtBack
        '
        Me.ButtBack.Location = New System.Drawing.Point(158, 239)
        Me.ButtBack.Name = "ButtBack"
        Me.ButtBack.Size = New System.Drawing.Size(75, 23)
        Me.ButtBack.TabIndex = 5
        Me.ButtBack.Text = "Back"
        Me.ButtBack.UseVisualStyleBackColor = True
        '
        'ButtExit
        '
        Me.ButtExit.Location = New System.Drawing.Point(277, 239)
        Me.ButtExit.Name = "ButtExit"
        Me.ButtExit.Size = New System.Drawing.Size(75, 23)
        Me.ButtExit.TabIndex = 6
        Me.ButtExit.Text = "Exit"
        Me.ButtExit.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 326)
        Me.Controls.Add(Me.ButtExit)
        Me.Controls.Add(Me.ButtBack)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MemberInfo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MemberInfo As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ButtBack As Button
    Friend WithEvents ButtExit As Button
End Class
