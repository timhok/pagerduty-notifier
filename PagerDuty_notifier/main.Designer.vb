<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.components = New System.ComponentModel.Container()
        Me.dupdate = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tx_org = New System.Windows.Forms.TextBox()
        Me.set_org = New System.Windows.Forms.Button()
        Me.set_token = New System.Windows.Forms.Button()
        Me.tx_token = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.set_freq = New System.Windows.Forms.Button()
        Me.tx_freq = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.set_nf_stay = New System.Windows.Forms.Button()
        Me.tx_nf_stay = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.set_wav = New System.Windows.Forms.Button()
        Me.tx_wav = New System.Windows.Forms.TextBox()
        Me.ch_wav = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'dupdate
        '
        Me.dupdate.Enabled = True
        Me.dupdate.Interval = 5000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Last checked: -"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Org. subdomain"
        '
        'tx_org
        '
        Me.tx_org.Location = New System.Drawing.Point(99, 29)
        Me.tx_org.Name = "tx_org"
        Me.tx_org.Size = New System.Drawing.Size(125, 20)
        Me.tx_org.TabIndex = 2
        Me.tx_org.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'set_org
        '
        Me.set_org.Location = New System.Drawing.Point(230, 29)
        Me.set_org.Name = "set_org"
        Me.set_org.Size = New System.Drawing.Size(50, 19)
        Me.set_org.TabIndex = 3
        Me.set_org.Text = "Set"
        Me.set_org.UseVisualStyleBackColor = True
        '
        'set_token
        '
        Me.set_token.Location = New System.Drawing.Point(230, 55)
        Me.set_token.Name = "set_token"
        Me.set_token.Size = New System.Drawing.Size(50, 19)
        Me.set_token.TabIndex = 6
        Me.set_token.Text = "Set"
        Me.set_token.UseVisualStyleBackColor = True
        '
        'tx_token
        '
        Me.tx_token.Location = New System.Drawing.Point(99, 55)
        Me.tx_token.Name = "tx_token"
        Me.tx_token.Size = New System.Drawing.Size(125, 20)
        Me.tx_token.TabIndex = 5
        Me.tx_token.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Token"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'set_freq
        '
        Me.set_freq.Location = New System.Drawing.Point(230, 81)
        Me.set_freq.Name = "set_freq"
        Me.set_freq.Size = New System.Drawing.Size(50, 19)
        Me.set_freq.TabIndex = 9
        Me.set_freq.Text = "Set"
        Me.set_freq.UseVisualStyleBackColor = True
        '
        'tx_freq
        '
        Me.tx_freq.Location = New System.Drawing.Point(99, 81)
        Me.tx_freq.Name = "tx_freq"
        Me.tx_freq.Size = New System.Drawing.Size(125, 20)
        Me.tx_freq.TabIndex = 8
        Me.tx_freq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Update freq"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'set_nf_stay
        '
        Me.set_nf_stay.Location = New System.Drawing.Point(230, 107)
        Me.set_nf_stay.Name = "set_nf_stay"
        Me.set_nf_stay.Size = New System.Drawing.Size(50, 19)
        Me.set_nf_stay.TabIndex = 12
        Me.set_nf_stay.Text = "Set"
        Me.set_nf_stay.UseVisualStyleBackColor = True
        '
        'tx_nf_stay
        '
        Me.tx_nf_stay.Location = New System.Drawing.Point(99, 107)
        Me.tx_nf_stay.Name = "tx_nf_stay"
        Me.tx_nf_stay.Size = New System.Drawing.Size(125, 20)
        Me.tx_nf_stay.TabIndex = 11
        Me.tx_nf_stay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Notify stay"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'set_wav
        '
        Me.set_wav.Location = New System.Drawing.Point(230, 133)
        Me.set_wav.Name = "set_wav"
        Me.set_wav.Size = New System.Drawing.Size(50, 19)
        Me.set_wav.TabIndex = 15
        Me.set_wav.Text = "Set"
        Me.set_wav.UseVisualStyleBackColor = True
        '
        'tx_wav
        '
        Me.tx_wav.Location = New System.Drawing.Point(99, 133)
        Me.tx_wav.Name = "tx_wav"
        Me.tx_wav.Size = New System.Drawing.Size(125, 20)
        Me.tx_wav.TabIndex = 14
        Me.tx_wav.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ch_wav
        '
        Me.ch_wav.Checked = True
        Me.ch_wav.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ch_wav.Location = New System.Drawing.Point(15, 134)
        Me.ch_wav.Name = "ch_wav"
        Me.ch_wav.Size = New System.Drawing.Size(81, 19)
        Me.ch_wav.TabIndex = 17
        Me.ch_wav.Text = "Alert sound"
        Me.ch_wav.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ch_wav.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 159)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 25)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "sound test"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(102, 159)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(81, 25)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "notify test"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(189, 159)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(91, 25)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "response test"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 192)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ch_wav)
        Me.Controls.Add(Me.set_wav)
        Me.Controls.Add(Me.tx_wav)
        Me.Controls.Add(Me.set_nf_stay)
        Me.Controls.Add(Me.tx_nf_stay)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.set_freq)
        Me.Controls.Add(Me.tx_freq)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.set_token)
        Me.Controls.Add(Me.tx_token)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.set_org)
        Me.Controls.Add(Me.tx_org)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "main"
        Me.Text = "PagerDuty Notifier"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dupdate As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tx_org As System.Windows.Forms.TextBox
    Friend WithEvents set_org As System.Windows.Forms.Button
    Friend WithEvents set_token As System.Windows.Forms.Button
    Friend WithEvents tx_token As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents set_freq As System.Windows.Forms.Button
    Friend WithEvents tx_freq As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents set_nf_stay As System.Windows.Forms.Button
    Friend WithEvents tx_nf_stay As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents set_wav As System.Windows.Forms.Button
    Friend WithEvents tx_wav As System.Windows.Forms.TextBox
    Friend WithEvents ch_wav As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
