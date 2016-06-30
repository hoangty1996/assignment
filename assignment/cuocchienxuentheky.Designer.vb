<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cuocchienxuentheky
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cuocchienxuentheky))
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 51)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(853, 502)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.Url = New System.Uri(resources.GetString("WebBrowser1.Url"), System.UriKind.Absolute)
        '
        'btnDong
        '
        Me.btnDong.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnDong.BackgroundImage = Global.assignment.My.Resources.Resources.go_back_29209
        Me.btnDong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDong.Location = New System.Drawing.Point(748, 6)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(93, 39)
        Me.btnDong.TabIndex = 88
        Me.btnDong.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(39, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(348, 25)
        Me.Label5.TabIndex = 89
        Me.Label5.Text = "Chúc các bạn chơi game vui vẻ!"
        '
        'WebBrowser2
        '
        Me.WebBrowser2.Location = New System.Drawing.Point(483, 7)
        Me.WebBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.Name = "WebBrowser2"
        Me.WebBrowser2.Size = New System.Drawing.Size(250, 38)
        Me.WebBrowser2.TabIndex = 90
        Me.WebBrowser2.Url = New System.Uri(resources.GetString("WebBrowser2.Url"), System.UriKind.Absolute)
        '
        'cuocchienxuentheky
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(853, 535)
        Me.Controls.Add(Me.WebBrowser2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Name = "cuocchienxuentheky"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game cuộc chiến xuyên thế kỷ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents btnDong As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents WebBrowser2 As System.Windows.Forms.WebBrowser
End Class
