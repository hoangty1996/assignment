Imports System.Data.SqlClient
Imports System.Data.DataSet
Public Class frmtimkiemKH
    Dim db As New DataTable
    'Dim chuoiketnoi As String = "server=ADMIN-PC\SQLEXPRESS;database=QL_GIAY;trusted_connection=false;uid=sa;pwd=1"'
    Dim chuoiketnoi As String = "workstation id=QuanlyGiay.mssql.somee.com;packet size=4096;user id=hoagyoyo_SQLLogin_1;pwd=cgp1jm784t;data source=QuanlyGiay.mssql.somee.com;persist security info=False;initial catalog=QuanlyGiay"
    Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnXemall_Click(sender As Object, e As EventArgs) Handles btnXemall.Click
        'Dim hienthi As New Class1
        'dgvXemsp.DataSource = hienthi.Loadsanpham.Tables(0)
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim timkiem As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã Khách Hàng' ,HoTen as 'Họ và tên', DiaChi as 'Địa chỉ', SoDienThoai as 'Số điện thoại', Email as 'Email' from KHACH_HANG", connect)
        Try
            db.Clear()
            dgvXemsp.DataSource = Nothing
            timkiem.Fill(db)
            If db.Rows.Count > 0 Then
                dgvXemsp.DataSource = db.DefaultView
                txtMAKH.Text = Nothing
            Else
                MessageBox.Show("Không tìm được")
                txtMAKH.Text = Nothing
            End If

            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnXem_Click(sender As Object, e As EventArgs) Handles btnXem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim timkiem As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã Khách Hàng' ,HoTen as 'Họ và tên', DiaChi as 'Địa chỉ', SoDienThoai as 'Số điện thoại', Email as 'Email' from KHACH_HANG where KHACH_HANG.MaKH ='" & txtMAKH.Text & "' ", connect)
        Try
            If txtMAKH.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã sản phẩm", "Nhập thiếu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                db.Clear()
                dgvXemsp.DataSource = Nothing
                timkiem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvXemsp.DataSource = db.DefaultView
                    txtMAKH.Text = Nothing
                Else
                    MessageBox.Show("Không tìm được")
                    txtMAKH.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnTenSP_Click(sender As Object, e As EventArgs) Handles btnTenKH.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim timkiem As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã Khách Hàng' ,HoTen as 'Họ và tên', DiaChi as 'Địa chỉ', SoDienThoai as 'Số điện thoại', Email as 'Email' from KHACH_HANG where KHACH_HANG.HoTen like '%" & txtTenKH.Text & "%' ", connect)
        Try
            If txtTenKH.Text = "" Then
                MessageBox.Show("Bạn cần nhập tên sản phẩm", "Nhập thiếu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                db.Clear()
                dgvXemsp.DataSource = Nothing
                timkiem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvXemsp.DataSource = db.DefaultView
                    txtMAKH.Text = Nothing
                Else
                    MessageBox.Show("Không tìm được")
                    txtMAKH.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnDong_Click_2(sender As Object, e As EventArgs) Handles btnDong.Click
        frmchu.Show()
        Me.Hide()
    End Sub

End Class