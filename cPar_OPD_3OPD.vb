Imports System.Data.SqlClient
Public Class cPar_OPD_3OPD

    Private Sub tbl_Keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbl_Keluar.Click
        Me.Close()
    End Sub

    Private Sub tbCari01_Click(sender As Object, e As EventArgs) Handles tbCari01.Click
        view_bPar_OPD_Fungsi.mKodePanggil.Text = "cPar_OPD_3OPD"
        view_bPar_OPD_Fungsi.ShowDialog(Me)
    End Sub

    Private Sub tblSimpan_Click(sender As Object, e As EventArgs) Handles tblSimpan.Click
        If mKode_Urusan.Text.Trim = "" Then
            MsgBox("Data tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If
        If mKode_Bidang.Text.Trim = "" Then
            MsgBox("Datatidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If
        If mNama_OPD.Text.Trim = "" Then
            MsgBox("Data tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If
        If mKode_OPD.Text.Trim = "" Then
            MsgBox("Data tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If
        If mKode_Fungsi.Text.Trim = "" Then
            MsgBox("Data tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If
        'If mKode_Dokumen.Text.Trim = "" Then
        'MsgBox("User Id Induk tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
        'Exit Sub
        'End If


        If Open_eSumsel() = False Then Exit Sub
        Dim Cari As String = "T"
        Rs_Simpan.Open("Select Kode_Urusan,Kode_Bidang,Kode_OPD from cPar_OPD_3OPD  where Kode_Urusan = '" & mKode_Urusan.Text & "'  And Kode_Bidang='" & mKode_Bidang.Text & "'  and Kode_OPD='" & mKode_OPD.Text & "'", cn_eSumsel)
        If Rs_Simpan.RecordCount > 0 Then
            MsgBox("Data Berhasil Diupdate..")

            Cari = "Y"
        End If
        Rs_Simpan.Close()

        Dim DeKlare_Data As String = " set dateformat DMY " _
        & " Declare @Kode_Urusan Char(1) " _
        & " Declare @Kode_Bidang Char(2) " _
        & " Declare @Kode_OPD    Char(2) " _
        & " Declare @Nama_OPD    Char(100) " _
        & " Declare @Kode_Fungsi Char(2) " _
        & " Declare @Kode_Dokumen Char(100) " _
        & " Declare @MAC0    Char(20) " _
        & " Declare @MAC1    Char(20) " _
        & " Declare @IPAdress    Char(20) " _
        & " Declare @MBId    Char(20) " _
        & " Declare @ProcId  Char(20) " _
        & " Declare @Tanggal DateTime " _
        & " Declare @komputer    Char(100) " _
        & " " _
        & " Set @Kode_Urusan = '" & mKode_Urusan.Text & "' " _
        & " Set @Kode_Bidang = '" & mKode_Bidang.Text.Trim & "' " _
        & " Set @Kode_OPD = '" & mKode_OPD.Text.Trim & "' " _
        & " Set @Nama_OPD = '" & mNama_OPD.Text.Trim & "' " _
        & " Set @Kode_Fungsi = '" & mKode_Fungsi.Text.Trim & "' " _
        & " Set @Kode_Dokumen = '" & mKode_Dokumen.Text.Trim & "' " _
        & " Set @MAC0 = '" & MenuUtama.mMAC0.Text.Trim & "' " _
        & " Set @MAC1 = '" & MenuUtama.mMAC1.Text.Trim & "' " _
        & " Set @IPAdress = '" & MenuUtama.mIPAdress.Text.Trim & "' " _
        & " Set @MBId = '" & MenuUtama.mMotherBoardID.Text.Trim & "' " _
        & " Set @ProcId = '" & MenuUtama.mProcessorID.Text.Trim & "' " _
        & " Set @Tanggal = '" & str_TanggalServer_DMY() & "' " _
        & " Set @komputer = '" & Environment.MachineName.Trim & "' "

        Dim Insert_Data As String = " " _
                        & " insert into cPar_OPD_3OPD " _
                        & " (Kode_Urusan,Kode_Bidang,Kode_OPD,Nama_OPD,Kode_Fungsi,Kode_Dokumen,MAC0,MAC1,IPAdress,MBId,ProcId,Tanggal,komputer) values " _
                        & " (@Kode_Urusan,@Kode_Bidang,@Kode_OPD,@Nama_OPD,@Kode_Fungsi,@Kode_Dokumen,@MAC0,@MAC1,@IPAdress,@MBId,@ProcId,@Tanggal,@komputer) "
        Dim Update_Data As String = " " _
            & " Update cPar_OPD_3OPD Set " _
            & " Kode_Urusan = @Kode_Urusan, " _
            & " Kode_Bidang   = @Kode_Bidang, " _
            & " Kode_OPD= @Kode_OPD, " _
            & " Nama_OPD= @Nama_OPD, " _
            & " Kode_Fungsi= @Kode_Fungsi, " _
            & " Kode_Dokumen= @Kode_Dokumen, " _
            & " komputer= @komputer, " _
            & " MAC0= @MAC0, " _
            & " MAC1= @MAC1, " _
            & " IPAdress= @IPAdress, " _
            & " MBId= @MBId, " _
            & " ProcId= @ProcId, " _
            & " Tanggal= @Tanggal " _
            & " " _
            & " Where Kode_Urusan = @Kode_Urusan and Kode_Bidang=@Kode_Bidang and Kode_OPD=@Kode_OPD   "

        Dim Nilai_Histori As String = "0"
        If Cari = "Y" Then
            Nilai_Histori = "1"
            Rs_Simpan.Open(DeKlare_Data & Update_Data, cn_eSumsel)
        Else
            Rs_Simpan.Open(DeKlare_Data & Insert_Data, cn_eSumsel)
        End If
        Close_eSumsel()
        tampil_OPD()
        reset()
        '==========================
        'yyHis_cPar_OPD_3OPD(Nilai_Histori) '0 = Inset,1=Update,2=Hapus
        '==========================
        MsgBox("Data telah disimpan.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Informasi")
    End Sub
    Sub tampil_OPD()
        If Open_eSumsel_Tampil() = False Then Exit Sub

        Dim sql_Text_Comman As String = "SELECT " _
                                    & " Kode_Urusan + '.' + Kode_Bidang +'.' + Kode_OPD as [Kode OPD], Nama_OPD, Kode_Fungsi" _
                                    & " FROM cPar_OPD_3OPD " _
                                    & " ORDER By Kode_Urusan, Kode_Bidang, Kode_OPD"
        Dim Tampil_data As New SqlCommand(sql_Text_Comman, cn_eSumsel_Tmpl)
        Tampil_data.CommandType = CommandType.Text

        Dim OleDA_Tampil As New SqlDataAdapter(Tampil_data)

        Dim ODS_Tampil As New DataSet
        OleDA_Tampil.Fill(ODS_Tampil, "OPD")
        Dim ODV_Tampil As New DataView(ODS_Tampil.Tables("OPD"))
        dg_OPD.DataSource = ODV_Tampil
        ODS_Tampil.Dispose()
        OleDA_Tampil.Dispose()

        Close_eSumsel_Tampil()

        dg_OPD.Columns(0).Width = (dg_OPD.Width / 10) * 1.8
        dg_OPD.Columns(1).Width = (dg_OPD.Width / 10) * 6
        dg_OPD.Columns(2).Width = (dg_OPD.Width / 10) * 2
        'dg_OPD.Columns(3).Width = (dg_OPD.Width / 10) * 3.7
        'dg_User.Columns(4).Width = (dg_User.Width / 10) * 1.7
        'dg_User.Columns(5).Width = (dg_User.Width / 10) * 1
        'dg_User.Columns(6).Width = (dg_User.Width / 10) * 3.5
    End Sub

    Private Sub tblHapus_Click(sender As Object, e As EventArgs) Handles tblHapus.Click
        Dim Pesan = MsgBox("Yakin User ID " & mKode_Urusan.Text.Trim & " " & mKode_Bidang.Text.Trim & " " & mKode_OPD.Text.Trim & " ini akan di Hapus [Y/T] ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Informasi")
        If Pesan = MsgBoxResult.Yes Then
            If Open_eSumsel() = False Then Exit Sub
            Rs_Simpan.Open("Delete from cPar_OPD_3OPD  where Kode_Urusan = '" & mKode_Urusan.Text & "' and Kode_Bidang = '" & mKode_Bidang.Text & "' and Kode_OPD = '" & mKode_OPD.Text & "' ", cn_eSumsel)
            Rs_Simpan.Open("Delete from cPar_OPD_3OPD  where Kode_Urusan = '" & mKode_Urusan.Text & "' and Kode_Bidang = '" & mKode_Bidang.Text & "' and Kode_OPD = '" & mKode_OPD.Text & "' ", cn_eSumsel)
            Close_eSumsel()

            'Hapus yang berhubungan dengan user id ini

            '==========================
            'yyHis_aPar_UserID("2") '0 = Inset,1=Update,2=Hapus
            '==========================
            tampil_OPD()
            tblBaru_Click(tblBaru, New EventArgs)
            MsgBox("Kode OPD " & mKode_Urusan.Text.Trim & " telah dihapus.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

    Private Sub tblBaru_Click(sender As Object, e As EventArgs) Handles tblBaru.Click
        Reset()
    End Sub

    Private Sub cPar_OPD_3OPD_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        tampil_OPD()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        view_cPar_OPD_2Bidang.mKodePanggil.Text = "cPar_OPD_3OPD"
        view_cPar_OPD_2Bidang.mKode_Urusan.Text = "cPar_OPD_3OPD"
        view_cPar_OPD_2Bidang.ShowDialog(Me)
    End Sub

    Private Sub mKode_Bidang_LostFocus(sender As Object, e As EventArgs) Handles mKode_Bidang.LostFocus

    End Sub

    Private Sub mKode_OPD_LostFocus(sender As Object, e As EventArgs) Handles mKode_OPD.LostFocus
        If mKode_OPD.Text.Trim.Length = 1 Then mKode_OPD.Text = "0" & mKode_OPD.Text.Trim
        If Open_eSumsel() = False Then Exit Sub

        Dim sql_Text_Comman As String = "SELECT " _
                                    & " cPar_OPD_3OPD.Nama_OPD ," _
                                    & " cPar_OPD_3OPD.Kode_Fungsi," _
                                    & " bPar_OPD_Fungsi.Nama_Fungsi" _
                                    & " FROM cPar_OPD_3OPD inner join bPar_OPD_Fungsi on cPar_OPD_3OPD.Kode_Fungsi=bPar_OPD_Fungsi.Kode_Fungsi  " _
                                    & " WHERE cPar_OPD_3OPD.Kode_Urusan = '" & mKode_Urusan.Text.Trim & "'  and cPar_OPD_3OPD.Kode_Bidang = '" & mKode_Bidang.Text.Trim & "' and cPar_OPD_3OPD.Kode_OPD = '" & mKode_OPD.Text.Trim & "' "
        Rs_Baca.Open(sql_Text_Comman, cn_eSumsel)

        If Rs_Baca.RecordCount > 0 Then
            mNama_OPD.Text = Rs_Baca.Fields("Nama_OPD").Value.ToString.Trim
            mKode_Fungsi.Text = Rs_Baca.Fields("Kode_Fungsi").Value.ToString.Trim
            mNama_Fungsi.Text = Rs_Baca.Fields("Nama_Fungsi").Value.ToString.Trim
        End If
        MsgBox("Yakin Data Diupdate")
        Rs_Baca.Close()
        Close_eSumsel()
    End Sub
    Sub reset()
        mKode_Urusan.Text = ""
        mKode_Bidang.Text = ""
        mKode_OPD.Text = ""
        mNama_OPD.Text = ""
        mKode_Fungsi.Text = ""
        mNama_Fungsi.Text = ""
        mNama_Bidang.Text = ""
    End Sub
    Private Sub dg_OPD_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_OPD.DoubleClick


    End Sub
End Class