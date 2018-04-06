Public Class cPar_RekAPBD_Sumber_Dana

    Private Sub tbl_Keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbl_Keluar.Click
        Me.Close()
    End Sub

    Private Sub tblBaru_Click(sender As Object, e As EventArgs) Handles tblBaru.Click
        mSD_Rek_Pos.Text = ""
        mSD_Rek_Kelompok.Text = ""
        mSD_Rek_Jenis.Text = ""
        mSD_Nama_Rek_Jenis.Text = ""
        mSD_Rek_Pos.Focus()
    End Sub

    Private Sub tblSimpan_Click(sender As Object, e As EventArgs) Handles tblSimpan.Click
        If mSD_Rek_Pos.Text.Trim = "" Then
            MsgBox("Rekening tidak boleh kosong...", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If
        If mSD_Rek_Kelompok.Text.Trim = "" Then
            MsgBox("Rekening tidak boleh kosong...", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If
        If mSD_Rek_Jenis.Text.Trim = "" Then
            MsgBox("Rekening tidak boleh kosong...", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If
        If mSD_Nama_Rek_Jenis.Text.Trim = "" Then
            MsgBox("Nama Sumber Dana tidak boleh kosong...", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If

    End Sub
End Class