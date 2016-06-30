<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtimkiemKH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmtimkiemKH))
        Me.dgvXemsp = New System.Windows.Forms.DataGridView()
        Me.btnXemall = New System.Windows.Forms.Button()
        Me.btnTenKH = New System.Windows.Forms.Button()
        Me.txtTenKH = New System.Windows.Forms.TextBox()
        Me.btnXem = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMAKH = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser()
        CType(Me.dgvXemsp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvXemsp
        '
        Me.dgvXemsp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvXemsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvXemsp.Location = New System.Drawing.Point(12, 142)
        Me.dgvXemsp.Name = "dgvXemsp"
        Me.dgvXemsp.Size = New System.Drawing.Size(570, 209)
        Me.dgvXemsp.TabIndex = 12
        '
        'btnXemall
        '
        Me.btnXemall.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnXemall.BackgroundImage = Global.assignment.My.Resources.Resources.images
        Me.btnXemall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnXemall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXemall.Location = New System.Drawing.Point(413, 95)
        Me.btnXemall.Name = "btnXemall"
        Me.btnXemall.Size = New System.Drawing.Size(106, 41)
        Me.btnXemall.TabIndex = 9
        Me.btnXemall.Text = "Xem tất cả"
        Me.btnXemall.UseVisualStyleBackColor = False
        '
        'btnTenKH
        '
        Me.btnTenKH.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnTenKH.BackgroundImage = Global.assignment.My.Resources.Resources.search_icon_dailyviettel
        Me.btnTenKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnTenKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTenKH.Location = New System.Drawing.Point(307, 95)
        Me.btnTenKH.Name = "btnTenKH"
        Me.btnTenKH.Size = New System.Drawing.Size(100, 41)
        Me.btnTenKH.TabIndex = 10
        Me.btnTenKH.Text = "Tim TenKH"
        Me.btnTenKH.UseVisualStyleBackColor = False
        '
        'txtTenKH
        '
        Me.txtTenKH.Location = New System.Drawing.Point(141, 102)
        Me.txtTenKH.Name = "txtTenKH"
        Me.txtTenKH.Size = New System.Drawing.Size(160, 20)
        Me.txtTenKH.TabIndex = 7
        '
        'btnXem
        '
        Me.btnXem.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnXem.BackgroundImage = Global.assignment.My.Resources.Resources.search_icon_dailyviettel
        Me.btnXem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnXem.Location = New System.Drawing.Point(307, 50)
        Me.btnXem.Name = "btnXem"
        Me.btnXem.Size = New System.Drawing.Size(100, 39)
        Me.btnXem.TabIndex = 11
        Me.btnXem.Text = "Tim MaKH"
        Me.btnXem.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Họ tên đầy đủ:"
        '
        'txtMAKH
        '
        Me.txtMAKH.Location = New System.Drawing.Point(141, 57)
        Me.txtMAKH.Name = "txtMAKH"
        Me.txtMAKH.Size = New System.Drawing.Size(160, 20)
        Me.txtMAKH.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Mã khách hàng:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(168, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(235, 25)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Tìm kiếm khách hàng"
        '
        'btnDong
        '
        Me.btnDong.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDong.BackgroundImage = Global.assignment.My.Resources.Resources.go_back_29209
        Me.btnDong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDong.Location = New System.Drawing.Point(413, 50)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(106, 39)
        Me.btnDong.TabIndex = 87
        Me.btnDong.UseVisualStyleBackColor = False
        '
        'WebBrowser2
        '
        Me.WebBrowser2.Location = New System.Drawing.Point(427, 9)
        Me.WebBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.Name = "WebBrowser2"
        Me.WebBrowser2.Size = New System.Drawing.Size(174, 25)
        Me.WebBrowser2.TabIndex = 91
        Me.WebBrowser2.Url = New System.Uri(resources.GetString("WebBrowser2.Url"), System.UriKind.Absolute)
        '
        'frmtimkiemKH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = Global.assignment.My.Resources.Resources.converse_SS15_banner
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(599, 363)
        Me.Controls.Add(Me.WebBrowser2)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgvXemsp)
        Me.Controls.Add(Me.btnXemall)
        Me.Controls.Add(Me.btnTenKH)
        Me.Controls.Add(Me.txtTenKH)
        Me.Controls.Add(Me.btnXem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMAKH)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmtimkiemKH"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tìm kiếm khách hàng"
        CType(Me.dgvXemsp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvXemsp As System.Windows.Forms.DataGridView
    Friend WithEvents btnXemall As System.Windows.Forms.Button
    Friend WithEvents btnTenKH As System.Windows.Forms.Button
    Friend WithEvents txtTenKH As System.Windows.Forms.TextBox
    Friend WithEvents btnXem As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMAKH As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnDong As System.Windows.Forms.Button
    Friend WithEvents WebBrowser2 As System.Windows.Forms.WebBrowser
End Class
