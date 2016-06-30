<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKH))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtSDT = New System.Windows.Forms.TextBox()
        Me.txtTenKH = New System.Windows.Forms.TextBox()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Địa chỉ:"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(118, 115)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(182, 20)
        Me.txtDiaChi.TabIndex = 56
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(180, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(232, 25)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Quản Lý Khách hàng"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 209)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(577, 183)
        Me.DataGridView1.TabIndex = 54
        '
        'btnLuu
        '
        Me.btnLuu.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnLuu.BackgroundImage = Global.assignment.My.Resources.Resources.luu_hang_loat_nhieu_anh
        Me.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLuu.Location = New System.Drawing.Point(336, 153)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(59, 50)
        Me.btnLuu.TabIndex = 53
        Me.btnLuu.UseVisualStyleBackColor = False
        '
        'btnXoa
        '
        Me.btnXoa.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnXoa.BackgroundImage = Global.assignment.My.Resources.Resources.tải_xuống
        Me.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnXoa.Location = New System.Drawing.Point(169, 153)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(59, 50)
        Me.btnXoa.TabIndex = 51
        Me.btnXoa.UseVisualStyleBackColor = False
        '
        'btnSua
        '
        Me.btnSua.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSua.BackgroundImage = Global.assignment.My.Resources.Resources._16278993_Update_icon_glossy_orange_button_Stock_Photo
        Me.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSua.Location = New System.Drawing.Point(255, 153)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(59, 50)
        Me.btnSua.TabIndex = 52
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = False
        '
        'btnThem
        '
        Me.btnThem.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnThem.BackgroundImage = Global.assignment.My.Resources.Resources.tải_xuống__1_
        Me.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnThem.Location = New System.Drawing.Point(88, 153)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(59, 50)
        Me.btnThem.TabIndex = 50
        Me.btnThem.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(313, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Email:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Họ và tên:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(313, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Số điện thoại:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Mã Khách hàng:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(405, 86)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(151, 20)
        Me.txtEmail.TabIndex = 48
        '
        'txtSDT
        '
        Me.txtSDT.Location = New System.Drawing.Point(405, 57)
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.Size = New System.Drawing.Size(125, 20)
        Me.txtSDT.TabIndex = 47
        '
        'txtTenKH
        '
        Me.txtTenKH.Location = New System.Drawing.Point(118, 89)
        Me.txtTenKH.Name = "txtTenKH"
        Me.txtTenKH.Size = New System.Drawing.Size(164, 20)
        Me.txtTenKH.TabIndex = 46
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(118, 60)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(100, 20)
        Me.txtMaKH.TabIndex = 41
        '
        'btnDong
        '
        Me.btnDong.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnDong.BackgroundImage = Global.assignment.My.Resources.Resources.go_back_29209
        Me.btnDong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDong.Location = New System.Drawing.Point(415, 153)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(63, 50)
        Me.btnDong.TabIndex = 86
        Me.btnDong.UseVisualStyleBackColor = False
        '
        'WebBrowser2
        '
        Me.WebBrowser2.Location = New System.Drawing.Point(432, 11)
        Me.WebBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.Name = "WebBrowser2"
        Me.WebBrowser2.Size = New System.Drawing.Size(174, 25)
        Me.WebBrowser2.TabIndex = 92
        Me.WebBrowser2.Url = New System.Uri(resources.GetString("WebBrowser2.Url"), System.UriKind.Absolute)
        '
        'frmKH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = Global.assignment.My.Resources.Resources.banner
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(601, 406)
        Me.Controls.Add(Me.WebBrowser2)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtSDT)
        Me.Controls.Add(Me.txtTenKH)
        Me.Controls.Add(Me.txtMaKH)
        Me.Name = "frmKH"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Khách hàng"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDiaChi As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnLuu As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtSDT As System.Windows.Forms.TextBox
    Friend WithEvents txtTenKH As System.Windows.Forms.TextBox
    Friend WithEvents txtMaKH As System.Windows.Forms.TextBox
    Friend WithEvents btnDong As System.Windows.Forms.Button
    Friend WithEvents WebBrowser2 As System.Windows.Forms.WebBrowser

End Class
