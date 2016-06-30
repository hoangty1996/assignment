Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmchitiethoadon
    Dim db As New DataTable
    'Dim chuoiketnoi As String = "server=ADMIN-PC\SQLEXPRESS;database=QL_GIAY;trusted_connection=false;uid=sa;pwd=1"'
    Dim chuoiketnoi As String = "workstation id=QuanlyGiay.mssql.somee.com;packet size=4096;user id=hoagyoyo_SQLLogin_1;pwd=cgp1jm784t;data source=QuanlyGiay.mssql.somee.com;persist security info=False;initial catalog=QuanlyGiay"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)

    Private Sub btnXemall_Click(sender As Object, e As EventArgs) Handles btnXemall.Click
        'Dim hienthi As New Class1
        'dgvXemsp.DataSource = hienthi.Loadsanpham.Tables(0)
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim timkiem As SqlDataAdapter = New SqlDataAdapter("select  KHACH_HANG.MaKH, HoTen, DiaChi,NgayLapHD, CHITIET_HD.MaSP, SoLuong, TenSP, DonGia, DonViTinh from KHACH_HANG join HOA_DON on KHACH_HANG.MaKH = Hoa_Don.MaKH inner join CHITIET_HD on Hoa_Don.MaHD =CHITIET_HD.MaHD inner join SAN_PHAM on CHITIET_HD.MaSP =SAN_PHAM.MaSP", connect)
        Try
            db.Clear()
            dgvXemsp.DataSource = Nothing
            timkiem.Fill(db)
            If db.Rows.Count > 0 Then
                dgvXemsp.DataSource = db.DefaultView
                txtMaKH.Text = Nothing
            Else
                MessageBox.Show("Không tìm được")
                txtMaKH.Text = Nothing
            End If

            connect.Close()
        Catch ex As Exception
        End Try
    End Sub


    Private Sub btnDong_Click_1(sender As Object, e As EventArgs) Handles btnDong.Click
        frmchu.Show()
        Me.Hide()
    End Sub

    Private Sub frmchitiethoadon_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class