Imports System.IO
Imports System.Net

Public Class d0Tr_Dokumen_Pendukung
    Private Sub tbl_Keluar_Click(sender As Object, e As EventArgs) Handles tbl_Keluar.Click
        Me.Close()
    End Sub

    Private Sub tblBaru_Click(sender As Object, e As EventArgs) Handles tblBaru.Click
        mKode_Dokumen.Text = ""
        mNama_Dokumen.Text = ""
        mTgl_Dokumen.Text = ""
        mAsal_Penerbit_Dokumen.Text = ""
        mKeterangan.Text = ""
        mNamaFile_Asal.Text = ""
        mKode_Dokumen.Focus()

    End Sub

    Private Sub tblSimpan_Click(sender As Object, e As EventArgs) Handles tblSimpan.Click
        If mKode_Dokumen.Text.Trim = "" Then
            MsgBox("Kode Dokumen tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If
        If mNama_Dokumen.Text.Trim = "" Then
            MsgBox("Nama Dokumen tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If
        'If mTgl_Dokumen.Text.Trim = "" Then
        ' MsgBox("Tanggal Dokumen tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
        ' Exit Sub
        'End If
        If mAsal_Penerbit_Dokumen.Text.Trim = "" Then
            MsgBox("Asal Dokumen tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If
        If mKeterangan.Text.Trim = "" Then
            MsgBox("Keterangan tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If

        If Open_eSumsel() = False Then Exit Sub
        Dim Cari As String = "T"
        Rs_Simpan.Open("Select Kode_Dokumen from d0Tr_Dokumen_Pendukung  where Kode_Dokumen = '" & mKode_Dokumen.Text & "' ", cn_eSumsel)
        If Rs_Simpan.RecordCount > 0 Then
            Cari = "Y"
        End If
        Rs_Simpan.Close()

        Dim DeKlare_Data As String = " set dateformat DMY " _
                     & " Declare @Kode_Dokumen char(50) " _
                     & " Declare @Nama_Dokumen char(100) " _
                     & " Declare @Tgl_Dokumen datetime " _
                     & " Declare @Asal_Penerbit_Dokumen char(100) " _
                     & " Declare @Keterangan varchar(MAX)  " _
                     & " Declare @komputer char(100) " _
                     & " Declare @MAC0 char(20) " _
                     & " Declare @MAC1 char(20) " _
                     & " Declare @IPAdress char(20) " _
                     & " Declare @MBId char(20) " _
                     & " Declare @ProcId char(20) " _
                     & " Declare @Tanggal datetime " _
                     & " Declare @UserID_Entry char(20) " _
                     & "  " _
                     & " Set @Kode_Dokumen = '" & mKode_Dokumen.Text.Trim & "' " _
                     & " Set @Nama_Dokumen = '" & mNama_Dokumen.Text.Trim & "' " _
                     & " Set @Tgl_Dokumen = '" & mTgl_Dokumen.Text.Trim & "' " _
                     & " Set @Asal_Penerbit_Dokumen = '" & mAsal_Penerbit_Dokumen.Text.Trim & "' " _
                     & " Set @Keterangan = '" & mKeterangan.Text.Trim & "' " _
                     & " Set @komputer    = '" & Environment.MachineName.ToString.Trim & "' " _
                     & " Set @MAC0        = '" & MenuUtama.mMAC0.Text.Trim & "' " _
                     & " Set @MAC1        = '" & MenuUtama.mMAC1.Text.Trim & "' " _
                     & " Set @IPAdress    = '" & MenuUtama.mIPAdress.Text.Trim & "' " _
                     & " Set @MBId        = '" & MenuUtama.mMotherBoardID.Text.Trim & "' " _
                     & " Set @ProcId    = '" & MenuUtama.mProcessorID.Text.Trim & "' " _
                     & " Set @Tanggal    = '" & str_TanggalServer_DMY() & "' " _
                     & " Set @UserID_Entry= '" & MenuUtama.mUserID.Text.Trim & "' "

        Dim Insert_Data As String = " " _
                    & " Insert Into d0Tr_Dokumen_Pendukung ( " _
                    & " Kode_Dokumen, " _
                    & " Nama_Dokumen, " _
                    & " Tgl_Dokumen, " _
                    & " Asal_Penerbit_Dokumen, " _
                    & " Keterangan, " _
                    & " komputer, " _
                    & " MAC0, " _
                    & " MAC1, " _
                    & " IPAdress, " _
                    & " MBId, " _
                    & " ProcId, " _
                    & " Tanggal, " _
                    & " UserID_Entry) Values  " _
                    & " (@Kode_Dokumen, " _
                    & " @Nama_Dokumen, " _
                    & " @Tgl_Dokumen, " _
                    & " @Asal_Penerbit_Dokumen, " _
                    & " @Keterangan, " _
                    & " @komputer, " _
                    & " @MAC0, " _
                    & " @MAC1, " _
                    & " @IPAdress, " _
                    & " @MBId, " _
                    & " @ProcId, " _
                    & " @Tanggal, " _
                    & " @UserID_Entry)   "

        Dim Update_Data As String = " " _
            & " Update d0Tr_Dokumen_Pendukung Set " _
            & " Kode_Dokumen = @Kode_Dokumen, " _
            & " Nama_Dokumen = @Nama_Dokumen, " _
            & " Tgl_Dokumen    = @Tgl_Dokumen, " _
            & " Asal_Penerbit_Dokumen = @Asal_Penerbit_Dokumen, " _
            & " Keterangan    = @Keterangan, " _
            & " komputer    = @komputer, " _
            & " MAC0        = @MAC0, " _
            & " MAC1        = @MAC1, " _
            & " IPAdress    = @IPAdress, " _
            & " MBId        = @MBId, " _
            & " ProcId        = @ProcId, " _
            & " Tanggal        = @Tanggal, " _
            & " UserID_Entry = @UserID_Entry where Kode_Dokumen = '" & mKode_Dokumen.Text.Trim & "'"

        Dim Nilai_Histori As String = "0"
        If Cari = "Y" Then
            Nilai_Histori = "1"
            Rs_Simpan.Open(DeKlare_Data & Update_Data, cn_eSumsel)
        Else
            Rs_Simpan.Open(DeKlare_Data & Insert_Data, cn_eSumsel)
        End If
        Close_eSumsel()
        'tampil_iduser()

        '==========================log belu
        ' yyHis_aPar_UserID(Nilai_Histori) '0 = Inset,1=Update,2=Hapus
        '==========================
        MsgBox("Data telah disimpan.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Informasi")

    End Sub

    Private Sub tblBrowse_Click(sender As Object, e As EventArgs) Handles tblBrowse.Click
        'ofd_CariFileDokumen.Filter=*
        ofd_CariFileDokumen.ShowDialog(Me)
        If ofd_CariFileDokumen.FileNames.ToString.Trim = "" Then
        Else
            mNamaFile_Asal.Text = ofd_CariFileDokumen.FileName.Trim
        End If
    End Sub

    Private Sub tblHapus_Click(sender As Object, e As EventArgs) Handles tblHapus.Click

    End Sub

    Private Sub mKode_Dokumen_TextChanged(sender As Object, e As EventArgs) Handles mKode_Dokumen.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub mNama_Dokumen_TextChanged(sender As Object, e As EventArgs) Handles mNama_Dokumen.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub mTgl_Dokumen_ValueChanged(sender As Object, e As EventArgs) Handles mTgl_Dokumen.ValueChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub mAsal_Penerbit_Dokumen_TextChanged(sender As Object, e As EventArgs) Handles mAsal_Penerbit_Dokumen.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub mKeterangan_TextChanged(sender As Object, e As EventArgs) Handles mKeterangan.TextChanged

    End Sub

    Private Sub ofd_CariFileDokumen_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ofd_CariFileDokumen.FileOk

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub mNamaFile_Asal_TextChanged(sender As Object, e As EventArgs) Handles mNamaFile_Asal.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub dg_TampilData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_TampilData.CellContentClick

    End Sub

    Private Sub mcari_TextChanged(sender As Object, e As EventArgs) Handles mcari.TextChanged

    End Sub

    Private Sub L11_Click(sender As Object, e As EventArgs) Handles L11.Click

    End Sub

    Private Sub Tbl_CariSKPD_Click(sender As Object, e As EventArgs) Handles Tbl_CariSKPD.Click
        view_cPar_OPD_5Sub_Sub_OPD.mPilihan.Text = "2"
        view_cPar_OPD_5Sub_Sub_OPD.mKodePanggil.Text = "d0Tr_Dokumen_Pendukung"
        view_cPar_OPD_5Sub_Sub_OPD.ShowDialog(Me)
    End Sub
End Class