Imports System.Data.SqlClient
Public Class cPar_RekAPBD_2

    Private Sub tbl_Keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbl_Keluar.Click
        Me.Close()
    End Sub
    Private Sub tbCari01_Click(sender As Object, e As EventArgs) Handles tbCari01.Click
        view_cPar_RekAPBD_1.mKodePanggil.Text = "cPar_RekAPBD_2"
        view_cPar_RekAPBD_1.ShowDialog(Me)
    End Sub

    Private Sub mRek_Kelompok_LostFocus(sender As Object, e As EventArgs) Handles mRek_Kelompok.LostFocus
        If Open_eSumsel() = False Then Exit Sub
        Rs_Baca.Open("Select Nama_Rek_Kelompok from cPar_RekAPBD_2  where " _
                     & " Rek_Pos = '" & mRek_Pos.Text & "' and " _
                     & " Rek_Kelompok = '" & mRek_Kelompok.Text & "' ", cn_eSumsel)
        If Rs_Baca.RecordCount > 0 Then
            mNama_Rek_Kelompok.Text = Rs_Baca.Fields("Nama_Rek_Kelompok").Value.ToString.Trim
        End If
        Rs_Baca.Close()
        Close_eSumsel()
    End Sub

    Private Sub tblBaru_Click(sender As Object, e As EventArgs) Handles tblBaru.Click
        mRek_Pos.Text = ""
        mRek_Kelompok.Text = ""
        mNama_Rek_Kelompok.Text = ""
        mNama_Rek_Pos.Text = ""
    End Sub

    Private Sub tblSimpan_Click(sender As Object, e As EventArgs) Handles tblSimpan.Click
        If mRek_Pos.Text.Trim = "" Then
            MsgBox("Kode Rekning Pos tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If

        If mNama_Rek_Pos.Text.Trim = "" Then
            MsgBox("Nama Rekening tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If

        If mRek_Kelompok.Text.Trim = "" Then
            MsgBox("Kode Rekning Kelompok tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If

        If mNama_Rek_Kelompok.Text.Trim = "" Then
            MsgBox("Nama Rekning Kelompok tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If

        If Open_eSumsel() = False Then Exit Sub
        Dim Cari As String = "T"
        Rs_Baca.Open("Select Nama_Rek_Kelompok from cPar_RekAPBD_2  where " _
                       & " Rek_Pos = '" & mRek_Pos.Text & "' and " _
                       & " Rek_Kelompok = '" & mRek_Kelompok.Text & "' ", cn_eSumsel)
        If Rs_Baca.RecordCount > 0 Then
            Cari = "Y"
        End If
        Rs_Baca.Close()



        Dim DeKlare_Data As String = " set dateformat DMY " _
                        & " Declare @Rek_Pos char(1)  " _
                        & " Declare @Rek_Kelompok char(1)  " _
                        & " Declare @Nama_Rek_Kelompok char(100) " _
                        & " Declare @UserID_Entry char(20) " _
                        & " Declare @komputer char(100) " _
                        & " Declare @MAC0 char(20) " _
                        & " Declare @MAC1 char(20) " _
                        & " Declare @IPAdress char(20) " _
                        & " Declare @MBId char(20) " _
                        & " Declare @ProcId char(20) " _
                        & " Declare @Tanggal datetime " _
                        & " " _
                        & " Set @Rek_Pos = '" & mRek_Pos.Text & "' " _
                        & " Set @Rek_Kelompok = '" & mRek_Kelompok.Text & "' " _
                        & " Set @Nama_Rek_Kelompok = '" & mNama_Rek_Kelompok.Text.Trim & "' " _
                        & " Set @komputer = '" & Environment.MachineName.Trim & "' " _
                        & " Set @MAC0 = '" & MenuUtama.mMAC0.Text.Trim & "' " _
                        & " Set @MAC1 = '" & MenuUtama.mMAC1.Text.Trim & "' " _
                        & " Set @IPAdress = '" & MenuUtama.mIPAdress.Text.Trim & "' " _
                        & " Set @MBId = '" & MenuUtama.mMotherBoardID.Text.Trim & "' " _
                        & " Set @ProcId = '" & MenuUtama.mProcessorID.Text.Trim & "' " _
                        & " Set @Tanggal = '" & str_TanggalServer_DMY() & "' "

        Dim Insert_Data As String = " " _
                        & " insert into cPar_RekAPBD_2 " _
                        & " (Rek_Pos,Rek_Kelompok,Nama_Rek_Kelompok,UserID_Entry,komputer,MAC0,MAC1,IPAdress,MBId,ProcId,Tanggal) values " _
                        & " (@Rek_Pos,@Rek_Kelompok,@Nama_Rek_Kelompok,@UserID_Entry,@komputer,@MAC0,@MAC1,@IPAdress,@MBId,@ProcId,@Tanggal) "

        Dim Update_Data As String = " " _
            & " Update cPar_RekAPBD_1 Set " _
            & " Rek_Pos = @Rek_Pos, " _
            & " Rek_Kelompok = @Rek_Kelompok, " _
            & " Nama_Rek_Kelompok   = @Nama_Rek_Kelompok, " _
            & " UserID_Entry= @UserID_Entry, " _
            & " komputer= @komputer, " _
            & " MAC0= @MAC0, " _
            & " MAC1= @MAC1, " _
            & " IPAdress= @IPAdress, " _
            & " MBId= @MBId, " _
            & " ProcId= @ProcId, " _
            & " Tanggal= @Tanggal " _
            & " " _
            & " Where Rek_Pos = @Rek_Pos "

        Dim Nilai_Histori As String = "0"
        If Cari = "Y" Then
            Nilai_Histori = "1"
            Rs_Simpan.Open(DeKlare_Data & Update_Data, cn_eSumsel)
        Else
            Rs_Simpan.Open(DeKlare_Data & Insert_Data, cn_eSumsel)
        End If
        Close_eSumsel()
        tampil_Data()

        '==========================log belu
        'yyHis_aPar_UserID(Nilai_Histori) '0 = Inset,1=Update,2=Hapus
        '==========================
        tblBaru_Click(tblBaru, New EventArgs)
        MsgBox("Data telah disimpan.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Informasi")
    End Sub

    Private Sub tblHapus_Click(sender As Object, e As EventArgs) Handles tblHapus.Click
        Dim Pesan = MsgBox("Yakin Rekening " & mNama_Rek_Kelompok.Text.Trim & " ini akan di Hapus [Y/T] ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Informasi")
        If Pesan = MsgBoxResult.Yes Then
            If Open_eSumsel() = False Then Exit Sub
            Dim Cari As String = "T"
            Rs_Baca.Open("Select Nama_Rek_Kelompok from cPar_RekAPBD_2  where Rek_Pos = '" & mRek_Pos.Text & "' and Rek_Kelompok = '" & mRek_Kelompok.Text & "' ", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Cari = "Y"
            End If
            Rs_Baca.Close()
            If Cari = "Y" Then
                '==cek ke tabel belum selsesai...
                Rs_Baca.Open("Delete    from cPar_RekAPBD_2  where Rek_Pos = '" & mRek_Pos.Text & "' and Rek_Kelompok = '" & mRek_Kelompok.Text & "' ", cn_eSumsel)
            End If
            Close_eSumsel()

            'Hapus yang berhubungan dengan user id ini

            '==========================
            'yyHis_aPar_UserID("2") '0 = Inset,1=Update,2=Hapus
            '==========================
            tampil_Data()
            tblBaru_Click(tblBaru, New EventArgs)
            MsgBox("Rekening :" & mNama_Rek_Pos.Text.Trim & " telah dihapus.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Informasi")
        End If
    End Sub
    Sub tampil_Data()

        If Open_eSumsel_Tampil() = False Then Exit Sub
        Dim mmKondisi As String = ""
        If mcari.Text.Trim = "" Then
        Else
            mmKondisi = " where Nama_Rek_Kelompok like '%" & mcari.Text.Trim & "%' "
        End If
        Dim sql_Text_Comman As String = "SELECT " _
                                    & " Rek_Pos + '.' + Rek_Kelompok AS [Kode Rekening], " _
                                    & " Nama_Rek_Kelompok,Rek_Pos,Rek_Kelompok From cPar_RekAPBD_2 " & mmKondisi _
                                    & " ORDER By Rek_Pos,Rek_Kelompok "
        Dim Tampil_data As New SqlCommand(sql_Text_Comman, cn_eSumsel_Tmpl)
        Tampil_data.CommandType = CommandType.Text

        Dim OleDA_Tampil As New SqlDataAdapter(Tampil_data)

        Dim ODS_Tampil As New DataSet
        OleDA_Tampil.Fill(ODS_Tampil, "item")
        Dim ODV_Tampil As New DataView(ODS_Tampil.Tables("item"))
        dg_TampilData.DataSource = ODV_Tampil
        ODS_Tampil.Dispose()
        OleDA_Tampil.Dispose()

        Close_eSumsel_Tampil()

        dg_TampilData.Columns(0).Width = (dg_TampilData.Width / 10) * 1.8
        dg_TampilData.Columns(1).Width = (dg_TampilData.Width / 10) * 7.7

        dg_TampilData.Columns(2).Visible = False
        dg_TampilData.Columns(3).Visible = False

    End Sub

    Private Sub cPar_RekAPBD_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil_Data()
    End Sub

    Private Sub mcari_TextChanged(sender As Object, e As EventArgs) Handles mcari.TextChanged
        tampil_Data()
    End Sub

    Private Sub dg_TampilData_DoubleClick(sender As Object, e As EventArgs) Handles dg_TampilData.DoubleClick
        mRek_Pos.Text = dg_TampilData.Item(2, dg_TampilData.CurrentRow.Index).Value.ToString.Trim
        mRek_Kelompok.Text = dg_TampilData.Item(3, dg_TampilData.CurrentRow.Index).Value.ToString.Trim
        mNama_Rek_Kelompok.Text = dg_TampilData.Item(1, dg_TampilData.CurrentRow.Index).Value.ToString.Trim
        'cari nama rekening pos
        If Open_eSumsel() = False Then Exit Sub
        Rs_Baca.Open("Select Nama_Rek_Pos from cPar_RekAPBD_1  where Rek_Pos = '" & mRek_Pos.Text & "' ", cn_eSumsel)
        If Rs_Baca.RecordCount > 0 Then
            mNama_Rek_Pos.Text = Rs_Baca.Fields("Nama_Rek_Pos").Value.ToString.Trim
        End If
        Rs_Baca.Close()
        Close_eSumsel()
    End Sub

    Private Sub dg_TampilData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_TampilData.CellContentClick

    End Sub
End Class