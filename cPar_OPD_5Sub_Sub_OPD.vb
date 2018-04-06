Public Class cPar_OPD_5Sub_Sub_OPD
    Private Sub tbl_Keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbl_Keluar.Click
        Me.Close()
    End Sub

    Private Sub tbCari01_Click(sender As Object, e As EventArgs) Handles tbCari01.Click
        view_cPar_OPD_3OPD.ShowDialog(Me)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        view_cPar_OPD_4Sub_OPD.ShowDialog(Me)
    End Sub
End Class