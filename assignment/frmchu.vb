Public Class frmchu

    Private Sub ThôngTinKháchHàngToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ThôngTinKháchHàngToolStripMenuItem1.Click
        frmKH.Show()
        Me.Hide()
    End Sub

    Private Sub TìmKháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TìmKháchHàngToolStripMenuItem.Click
        frmtimkiemKH.Show()
        Me.Hide()
    End Sub

    Private Sub ThôngTinSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThôngTinSảnPhẩmToolStripMenuItem.Click
        frmphanloaisp.Show()
        Me.Hide()
    End Sub

    Private Sub ChiTiếtHóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChiTiếtHóaĐơnToolStripMenuItem.Click
        frmchitiethoadon.Show()
        Me.Hide()
    End Sub

    Private Sub CuộcChiếnXuyênThếKỷToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuộcChiếnXuyênThếKỷToolStripMenuItem.Click
        cuocchienxuentheky.Show()
        Me.Hide()
    End Sub

    Private Sub DoraemonTìmBánhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoraemonTìmBánhToolStripMenuItem.Click
        Doraemontimbanh.Show()
        Me.Hide()
    End Sub
End Class