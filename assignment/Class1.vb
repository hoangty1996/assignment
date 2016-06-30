Imports System.Data.SqlClient
Imports System.Data
Public Class Class1
    Public Function Loadkhachang() As DataSet
        Dim chuoiketnoi As String = "server=ADMIN-PC\SQLEXPRESS;database=QL_GIAY;trusted_connection=false;uid=sa;pwd=1"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadKH As New SqlDataAdapter("select MaKH as 'Mã Khách Hàng' ,HoTen as 'Họ và tên', DiaChi as 'Địa chỉ', SoDienThoai as 'Số điện thoại', Email as 'Email' from KHACH_HANG", conn)
        Dim db As New DataSet
        conn.Open()
        LoadKH.Fill(db)
        conn.Close()
        Return db
    End Function
    Public Function Loadsanpham() As DataSet
        Dim chuoiketnoi As String = "server=ADMIN-PC\SQLEXPRESS;database=QL_GIAY;trusted_connection=false;uid=sa;pwd=1"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadSP As New SqlDataAdapter("select MaKH as 'Mã Khách Hàng' ,HoTen as 'Họ và tên', DiaChi as 'Địa chỉ', SoDienThoai as 'Số điện thoại', Email as 'Email' from KHACH_HANG", conn)
        Dim db As New DataSet
        conn.Open()
        LoadSP.Fill(db)
        conn.Close()
        Return db '
    End Function
End Class