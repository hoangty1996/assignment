<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmphanloaisp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmphanloaisp))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTenLoai_SP = New System.Windows.Forms.TextBox()
        Me.txtMaLoai_SP = New System.Windows.Forms.TextBox()
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(46, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(220, 25)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Phân loại sản phầm"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 179)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(338, 158)
        Me.DataGridView1.TabIndex = 53
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(5, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Tên loại sản phẩm:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(9, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Mã loại sản phẩm:"
        '
        'txtTenLoai_SP
        '
        Me.txtTenLoai_SP.Location = New System.Drawing.Point(108, 89)
        Me.txtTenLoai_SP.Name = "txtTenLoai_SP"
        Me.txtTenLoai_SP.Size = New System.Drawing.Size(138, 20)
        Me.txtTenLoai_SP.TabIndex = 48
        '
        'txtMaLoai_SP
        '
        Me.txtMaLoai_SP.Location = New System.Drawing.Point(108, 60)
        Me.txtMaLoai_SP.Name = "txtMaLoai_SP"
        Me.txtMaLoai_SP.Size = New System.Drawing.Size(100, 20)
        Me.txtMaLoai_SP.TabIndex = 45
        '
        'btnLuu
        '
        Me.btnLuu.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnLuu.BackgroundImage = Global.assignment.My.Resources.Resources.luu_hang_loat_nhieu_anh
        Me.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLuu.Location = New System.Drawing.Point(207, 123)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(59, 50)
        Me.btnLuu.TabIndex = 90
        Me.btnLuu.UseVisualStyleBackColor = False
        '
        'btnXoa
        '
        Me.btnXoa.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnXoa.BackgroundImage = Global.assignment.My.Resources.Resources.tải_xuống
        Me.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnXoa.Location = New System.Drawing.Point(77, 123)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(59, 50)
        Me.btnXoa.TabIndex = 88
        Me.btnXoa.UseVisualStyleBackColor = False
        '
        'btnSua
        '
        Me.btnSua.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSua.BackgroundImage = Global.assignment.My.Resources.Resources._16278993_Update_icon_glossy_orange_button_Stock_Photo
        Me.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSua.Location = New System.Drawing.Point(142, 123)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(59, 50)
        Me.btnSua.TabIndex = 89
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = False
        '
        'btnThem
        '
        Me.btnThem.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnThem.BackgroundImage = Global.assignment.My.Resources.Resources.tải_xuống__1_
        Me.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnThem.Location = New System.Drawing.Point(12, 123)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(59, 50)
        Me.btnThem.TabIndex = 87
        Me.btnThem.UseVisualStyleBackColor = False
        '
        'btnDong
        '
        Me.btnDong.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnDong.BackgroundImage = Global.assignment.My.Resources.Resources.go_back_29209
        Me.btnDong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDong.Location = New System.Drawing.Point(272, 123)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(63, 50)
        Me.btnDong.TabIndex = 91
        Me.btnDong.UseVisualStyleBackColor = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(272, 2)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(92, 85)
        Me.WebBrowser1.TabIndex = 92
        Me.WebBrowser1.Url = New System.Uri(resources.GetString("WebBrowser1.Url"), System.UriKind.Absolute)
        '
        'frmphanloaisp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImage = Global.assignment.My.Resources.Resources._358fc18374881_560bc27c0b144
        Me.ClientSize = New System.Drawing.Size(362, 354)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTenLoai_SP)
        Me.Controls.Add(Me.txtMaLoai_SP)
        Me.Name = "frmphanloaisp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Phân loại sản phẩm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTenLoai_SP As System.Windows.Forms.TextBox
    Friend WithEvents txtMaLoai_SP As System.Windows.Forms.TextBox
    Friend WithEvents btnLuu As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnDong As System.Windows.Forms.Button
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
End Class
