Public Class cPerjadin_Par_Tarif_Luar_Daerah

    Private Sub tbl_Keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbl_Keluar.Click
        Me.Close()
    End Sub
 
    Private Sub tblCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblCopy.Click
        cPerjadin_Par_Tarif_Luar_Daerah_Copy.ShowDialog(Me)
    End Sub
End Class