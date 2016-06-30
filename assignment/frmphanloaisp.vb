Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmphanloaisp
    Dim db As New DataTable
    'Dim chuoiketnoi As String = "server=ADMIN-PC\SQLEXPRESS;database=QL_GIAY;trusted_connection=false;uid=sa;pwd=1"'
    Dim chuoiketnoi As String = "workstation id=QuanlyGiay.mssql.somee.com;packet size=4096;user id=hoagyoyo_SQLLogin_1;pwd=cgp1jm784t;data source=QuanlyGiay.mssql.somee.com;persist security info=False;initial catalog=QuanlyGiay"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaLoai_SP as 'Mã loại sẩn phẩm' ,TenLoai_SP as 'Tên loại sản phẩm' from LOAI_SAN_PHAM", conn)
        db.Clear()
        refesh.Fill(db)
        DataGridView1.DataSource = db.DefaultView
        conn.Close()
    End Sub
    Private Sub reset()
        txtMaLoai_SP.Text = ""
        txtTenLoai_SP.Text = ""
        txtMaLoai_SP.Focus()
    End Sub
    Private Sub frmSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim click As Integer = DataGridView1.CurrentCell.RowIndex
        txtMaLoai_SP.Text = DataGridView1.Item(0, click).Value
        txtTenLoai_SP.Text = DataGridView1.Item(1, click).Value
    End Sub

    Private Sub btnThem_Click_1(sender As Object, e As EventArgs) Handles btnThem.Click
        reset()
    End Sub

    Private Sub btnXoa_Click_1(sender As Object, e As EventArgs) Handles btnXoa.Click
        If txtMaLoai_SP.Text = "" Then
            MessageBox.Show("Nhap MaLoai_SP cần xóa")
            txtMaLoai_SP.Focus()
        Else
            Dim delquery As String = "delete from LOAI_SAN_PHAM where MaLoai_SP=@MaLoai_SP"
            Dim delete As SqlCommand = New SqlCommand(delquery, conn)
            Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resulft = Windows.Forms.DialogResult.Yes Then
                conn.Open()
                delete.Parameters.AddWithValue("@MaLoai_SP", txtMaLoai_SP.Text)
                delete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Xóa thành công")
                LoadData()
            End If
        End If
    End Sub

    Private Sub btnSua_Click_1(sender As Object, e As EventArgs) Handles btnSua.Click
        If btnSua.Text = "Sửa" Then
            txtMaLoai_SP.ReadOnly = True
            btnSua.Text = "Update"
            txtMaLoai_SP.Focus()
        ElseIf btnSua.Text = "Update" Then
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "update LOAI_SAN_PHAM set TenLoai_SP=@TenLoai_SP where MaLoai_SP=@MaLoai_SP"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MaLoai_SP", txtMaLoai_SP.Text)
            save.Parameters.AddWithValue("@TenLoai_SP", txtTenLoai_SP.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Update thành công")
            txtMaLoai_SP.ReadOnly = False
            btnSua.Text = "Sửa"
            LoadData()
        End If
    End Sub

    Private Sub btnLuu_Click_1(sender As Object, e As EventArgs) Handles btnLuu.Click
        If txtMaLoai_SP.Text = "" Then
            MessageBox.Show("Chưa nhập mã loại sản phẩm")
            txtMaLoai_SP.Focus()
        ElseIf txtTenLoai_SP.Text = "" Then
            MessageBox.Show("Chưa nhập tên loại sản phẩm")
            txtTenLoai_SP.Focus()
        Else
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "insert into LOAI_SAN_PHAM values(@MaLoai_SP,@TenLoai_SP)"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MaLoai_SP", txtMaLoai_SP.Text)
            save.Parameters.AddWithValue("@TenLoai_SP", txtTenLoai_SP.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Lưu thành công")
            LoadData()
        End If
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        frmchu.Show()
        Me.Hide()
    End Sub
End Class
