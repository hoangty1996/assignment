﻿Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmKH
    Dim db As New DataTable
    'Dim chuoiketnoi As String = "server=ADMIN-PC\SQLEXPRESS;database=QL_GIAY;trusted_connection=false;uid=sa;pwd=1"'
    Dim chuoiketnoi As String = "workstation id=QuanlyGiay.mssql.somee.com;packet size=4096;user id=hoagyoyo_SQLLogin_1;pwd=cgp1jm784t;data source=QuanlyGiay.mssql.somee.com;persist security info=False;initial catalog=QuanlyGiay"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        reset()
    End Sub
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã Khách Hàng' ,HoTen as 'Họ và tên', DiaChi as 'Địa chỉ', SoDienThoai as 'Số điện thoại', Email as 'Email' from KHACH_HANG", conn)
        db.Clear()
        refesh.Fill(db)
        DataGridView1.DataSource = db.DefaultView
        conn.Close()
    End Sub
    Private Sub reset()
        txtMaKH.Text = ""
        txtTenKH.Text = ""
        txtDiaChi.Text = ""
        txtSDT.Text = ""
        txtEmail.Text = ""
        txtMaKH.Focus()
    End Sub
    Private Sub frmSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If txtMaKH.Text = "" Then
            MessageBox.Show("Chua nhập mã khách hàng")
            txtMaKH.Focus()
        ElseIf txtTenKH.Text = "" Then
            MessageBox.Show("Chua nhập Tên sản phẩm")
            txtTenKH.Focus()
        ElseIf txtDiaChi.Text = "" Then
            MessageBox.Show("Chua nhập địa chỉ")
            txtDiaChi.Focus()
        ElseIf txtSDT.Text = "" Then
            MessageBox.Show("Chua nhập số điện thoại")
            txtSDT.Focus()
        ElseIf txtEmail.Text = "" Then
            MessageBox.Show("Chua nhập email")
            txtEmail.Focus()
        Else
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "insert into KHACH_HANG values(@MaKH,@HoTen,@DiaChi,@SoDienThoai,@Email)"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
            save.Parameters.AddWithValue("@HoTen", txtTenKH.Text)
            save.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text)
            save.Parameters.AddWithValue("@SoDienThoai", txtSDT.Text)
            save.Parameters.AddWithValue("@Email", txtEmail.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Lưu thành công")
            LoadData()
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If txtMaKH.Text = "" Then
            MessageBox.Show("Nhap MaKH cần xóa")
            txtMaKH.Focus()
        Else
            Dim delquery As String = "delete from KHACH_HANG where MaKH=@MaKH"
            Dim delete As SqlCommand = New SqlCommand(delquery, conn)
            Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resulft = Windows.Forms.DialogResult.Yes Then
                conn.Open()
                delete.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
                delete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Xóa thành công")
                LoadData()
            End If
        End If
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If btnSua.Text = "Sửa" Then
            txtMaKH.ReadOnly = True
            btnSua.Text = "Update"
            txtMaKH.Focus()
        ElseIf btnSua.Text = "Update" Then
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "update KHACH_HANG set HoTen=@HoTen, DiaChi=@DiaChi, SoDienThoai=@SoDienThoai where MaKH=@MaKH"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
            save.Parameters.AddWithValue("@HoTen", txtTenKH.Text)
            save.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text)
            save.Parameters.AddWithValue("@SoDienThoai", txtSDT.Text)
            save.Parameters.AddWithValue("@Email", txtEmail.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Update thành công")
            txtMaKH.ReadOnly = False
            btnSua.Text = "Sửa"
            LoadData()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim click As Integer = DataGridView1.CurrentCell.RowIndex
        txtMaKH.Text = DataGridView1.Item(0, click).Value
        txtTenKH.Text = DataGridView1.Item(1, click).Value
        txtDiaChi.Text = DataGridView1.Item(2, click).Value
        txtSDT.Text = DataGridView1.Item(3, click).Value
        txtEmail.Text = DataGridView1.Item(4, click).Value

    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        frmchu.Show()
        Me.Hide()
    End Sub
End Class
