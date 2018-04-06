Public Class cPar_Penomoran_Dokumen

    Private Sub tbl_Keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbl_Keluar.Click
        Me.Close()
    End Sub
 
    Private Sub mKolom_2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mKolom_2.TextChanged, mKolom_1.TextChanged
        lblHasil.Text = mKolom_1.Text.Trim & mKolom_2.Text.Trim
    End Sub
     
End Class