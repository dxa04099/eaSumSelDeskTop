Imports System.Text
Imports System.IO
Imports System.Data.SqlClient

Public Class cPar_RekAkrual_2

    Private Sub tbl_Keluar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbl_Keluar.Click
        Me.Close()
    End Sub

    Private Sub cPar_RekAkrual_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tbCari01_Click(sender As Object, e As EventArgs) Handles tbCari01.Click
        view_cPar_RekAkrual_1.mKodePanggil.Text = "cPar_RekAkrual_2"
        view_cPar_RekAkrual_1.ShowDialog(Me)
        Tampil_Rek_Akrual_Kelompok()
    End Sub

    Private Sub Tampil_Rek_Akrual_Kelompok()
        If Open_eSumsel_Tampil() = False Then Exit Sub

        Dim sql_kondisi_rek = ""
        If mRek_Pos.Text.Trim <> "" Then
            sql_kondisi_rek = sql_kondisi_rek & " and akr_Rek_Pos = '" & mRek_Pos.Text.Trim & "' "
        End If

        If mRek_Kelompok.Text.Trim <> "" Then
            sql_kondisi_rek = sql_kondisi_rek & " and akr_Rek_Kelompok = '" & mRek_Kelompok.Text.Trim & "' "
        End If

        Dim sql_Kondisi As String = ""
        If mcari.Text.Trim = "" Then
            If sql_kondisi_rek.Trim <> "" Then
                sql_Kondisi = "where " & Mid(sql_kondisi_rek.Trim, 4, sql_kondisi_rek.Trim.Length - 3)
            End If
        Else
            sql_Kondisi = " where akr_Nama_Rek_Kelompok like '%" & mcari.Text.Trim & "%' " & sql_kondisi_rek.Trim
        End If

        Dim sql_Text_Comman As String = " SELECT akr_Rek_Pos + '.' + akr_Rek_Kelompok  AS [Rekening] " _
                                        & "  ,akr_Nama_Rek_Kelompok AS [Nama Rekening Akrual Kelompok] " _
                                        & "  ,akr_Rek_Pos" _
                                        & "  ,akr_Rek_Kelompok" _
                                        & " FROM cPar_RekAkrual_2 " & sql_Kondisi _
                                        & " ORDER By akr_Rek_Pos "
        Dim Tampil_data As New SqlCommand(sql_Text_Comman, cn_eSumsel_Tmpl)
        Tampil_data.CommandType = CommandType.Text

        Dim OleDA_Tampil As New SqlDataAdapter(Tampil_data)

        Dim ODS_Tampil As New DataSet
        OleDA_Tampil.Fill(ODS_Tampil, "a_user")
        Dim ODV_Tampil As New DataView(ODS_Tampil.Tables("a_user"))
        dg_TampilData.DataSource = ODV_Tampil
        ODS_Tampil.Dispose()
        OleDA_Tampil.Dispose()

        Close_eSumsel_Tampil()

        dg_TampilData.Columns(0).Width = (dg_TampilData.Width / 10) * 2
        dg_TampilData.Columns(1).Width = (dg_TampilData.Width / 10) * 7.6

        dg_TampilData.Columns(2).Visible = False
        dg_TampilData.Columns(3).Visible = False

        'dg_TampilData.Columns(2).Visible = False
    End Sub

    Private Sub tblBaru_Click(sender As Object, e As EventArgs) Handles tblBaru.Click
        clearForm()
    End Sub

    Sub clearForm()
        mRek_Pos.Text = ""
        mRek_Kelompok.Text = ""
        mNama_Rek_Pos.Text = ""
        mNama_Rek_Kelompok.Text = ""
    End Sub

    Private Sub cPar_RekAkrual_2_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Tampil_Rek_Akrual_Kelompok()
    End Sub

    Private Sub mcari_TextChanged(sender As Object, e As EventArgs) Handles mcari.TextChanged
        Tampil_Rek_Akrual_Kelompok()
    End Sub

    Private Sub tblSimpan_Click(sender As Object, e As EventArgs) Handles tblSimpan.Click
        If mRek_Pos.Text.Trim = "" Then
            MsgBox("Rekening Akrual Pos tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If
        If mNama_Rek_Pos.Text.Trim = "" Then
            MsgBox("Nama Rekening Akrual Pos  tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If

        If mRek_Kelompok.Text.Trim = "" Then
            MsgBox("Rekening Akrual Kelompok tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If
        If mNama_Rek_Kelompok.Text.Trim = "" Then
            MsgBox("Nama Rekening Akrual Kelompok  tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If

        If Open_eSumsel() = False Then Exit Sub
        Dim Cari As String = "T"
        Rs_Simpan.Open("Select akr_Rek_Kelompok from cPar_RekAkrual_2  where akr_Rek_Pos = '" & mRek_Pos.Text.Trim & "' AND akr_Rek_Kelompok = '" & mRek_Kelompok.Text.Trim & "' ", cn_eSumsel)
        If Rs_Simpan.RecordCount > 0 Then
            Cari = "Y"
        End If
        Rs_Simpan.Close()

        Dim DeKlare_Data As String = " set dateformat DMY " _
                                    & "Declare @akr_Rek_Pos char(1) " _
                                    & "Declare @akr_Rek_Kelompok char(1) " _
                                    & "Declare @akr_Nama_Rek_Kelompok char(100) " _
                                    & "Declare @MAC0 char(20) " _
                                    & "Declare @MAC1 char(20) " _
                                    & "Declare @IPAdress char(20) " _
                                    & "Declare @MBId char(20) " _
                                    & "Declare @ProcId char(20) " _
                                    & "Declare @Tanggal datetime " _
                                    & "Declare @komputer char(100) " _
                                    & " " _
                                    & " Set @akr_Rek_Pos = '" & mRek_Pos.Text.Trim & "' " _
                                    & " Set @akr_Rek_Kelompok = '" & mRek_Kelompok.Text.Trim & "' " _
                                    & " Set @akr_Nama_Rek_Kelompok = '" & mNama_Rek_Kelompok.Text.Trim & "' " _
                                    & " Set @MAC0 = '" & MenuUtama.mMAC0.Text.Trim & "' " _
                                    & " Set @MAC1 = '" & MenuUtama.mMAC1.Text.Trim & "' " _
                                    & " Set @IPAdress = '" & MenuUtama.mIPAdress.Text.Trim & "' " _
                                    & " Set @MBId = '" & MenuUtama.mMotherBoardID.Text.Trim & "' " _
                                    & " Set @ProcId = '" & MenuUtama.mProcessorID.Text.Trim & "' " _
                                    & " Set @Tanggal = '" & str_TanggalServer_DMY() & "' " _
                                    & " Set @komputer = '" & Environment.MachineName.Trim & "' "

        Dim Insert_Data As String = " INSERT INTO cPar_RekAkrual_2 " _
                                    & " (akr_Rek_Pos,akr_Rek_Kelompok,akr_Nama_Rek_Kelompok,MAC0,MAC1,IPAdress,MBId,ProcId,Tanggal,komputer) VALUES " _
                                    & " (@akr_Rek_Pos,@akr_Rek_Kelompok,@akr_Nama_Rek_Kelompok, @MAC0, @MAC1, @IPAdress, @MBId, @ProcId, @Tanggal, @komputer) "

        Dim Update_Data As String = "UPDATE cPar_RekAkrual_2 " _
                                    & " SET akr_Rek_Pos = @akr_Rek_Pos, " _
                                    & " akr_Rek_Kelompok = @akr_Rek_Kelompok, " _
                                    & " akr_Nama_Rek_Kelompok = @akr_Nama_Rek_Kelompok, " _
                                    & " MAC0 = @MAC0, " _
                                    & " MAC1 = @MAC1, " _
                                    & " IPAdress = @IPAdress, " _
                                    & " MBId = @MBId, " _
                                    & " ProcId = @ProcId, " _
                                    & " Tanggal = @Tanggal, " _
                                    & " komputer = @komputer " _
                                    & " WHERE akr_Rek_Pos = '" & mRek_Pos.Text.Trim & "' AND akr_Rek_Kelompok = '" & mRek_Kelompok.Text.Trim & "' "

        Dim Nilai_Histori As String = "0"
        If Cari = "Y" Then
            Nilai_Histori = "1"
            Dim cek As String = DeKlare_Data & Update_Data
            Rs_Simpan.Open(DeKlare_Data & Update_Data, cn_eSumsel)
        Else
            Rs_Simpan.Open(DeKlare_Data & Insert_Data, cn_eSumsel)
        End If
        Close_eSumsel()
        Tampil_Rek_Akrual_Kelompok()
        tblBaru_Click(tblBaru, New EventArgs)
        MsgBox("Data telah disimpan.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Informasi")
    End Sub

    Private Sub tblHapus_Click(sender As Object, e As EventArgs) Handles tblHapus.Click
        If mRek_Pos.Text.Trim = "" Then
            MsgBox("Rekening Akrual Pos tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If
        If mNama_Rek_Pos.Text.Trim = "" Then
            MsgBox("Nama Rekening Akrual Pos  tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If

        If mRek_Kelompok.Text.Trim = "" Then
            MsgBox("Rekening Akrual Kelompok tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If
        If mNama_Rek_Kelompok.Text.Trim = "" Then
            MsgBox("Nama Rekening Akrual Kelompok  tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If

        Dim Pesan = MsgBox("Yakin Rekening Akrual Kelompok " & mNama_Rek_Kelompok.Text.Trim & " ini akan di Hapus [Y/T] ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Informasi")
        If Pesan = MsgBoxResult.Yes Then
            If Open_eSumsel() = False Then Exit Sub
            Rs_Simpan.Open("Delete from cPar_RekAkrual_2  where akr_Rek_Pos = '" & mRek_Pos.Text.Trim & "'  AND akr_Rek_Kelompok = '" & mRek_Kelompok.Text.Trim & "' ", cn_eSumsel)
            Close_eSumsel()

            'Hapus yang berhubungan dengan user id ini

            '==========================
            'yyHis_aPar_UserID("2") '0 = Inset,1=Update,2=Hapus
            '==========================
            Tampil_Rek_Akrual_Kelompok()
            tblBaru_Click(tblBaru, New EventArgs)
            MsgBox("Rekening Akrual Kelompok " & mNama_Rek_Kelompok.Text.Trim & " telah dihapus.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Informasi")
        End If

    End Sub

    Private Sub mRek_Kelompok_LostFocus(sender As Object, e As EventArgs) Handles mRek_Kelompok.LostFocus
        If Open_eSumsel() = False Then Exit Sub
        Dim sql_Text_Comman As String = "SELECT " _
                                            & " akr_Nama_Rek_Kelompok" _
                                            & " FROM cPar_RekAkrual_2 " _
                                            & " WHERE akr_Rek_Pos = '" & mRek_Pos.Text.Trim & "'  AND akr_Rek_Kelompok = '" & mRek_Kelompok.Text.Trim & "' " _
                                            & " ORDER By akr_Nama_Rek_Kelompok "
        Rs_Baca.Open(sql_Text_Comman, cn_eSumsel)

        mNama_Rek_Kelompok.Text = ""
        If Rs_Baca.RecordCount > 0 Then
            mNama_Rek_Kelompok.Text = Rs_Baca.Fields("akr_Nama_Rek_Kelompok").Value.ToString.Trim
        End If

        Rs_Baca.Close()
        Close_eSumsel()
    End Sub

    Sub get_nama_rek_pos()
        If Open_eSumsel() = False Then Exit Sub
        Dim sql_Text_Comman As String = "SELECT " _
                                            & " akr_Nama_Rek_Pos" _
                                            & " FROM cPar_RekAkrual_1 " _
                                            & " WHERE akr_Rek_Pos = '" & mRek_Pos.Text.Trim & "' " _
                                            & " ORDER By akr_Nama_Rek_Pos "
        Rs_Baca.Open(sql_Text_Comman, cn_eSumsel)

        mNama_Rek_Pos.Text = ""
        If Rs_Baca.RecordCount > 0 Then
            mNama_Rek_Pos.Text = Rs_Baca.Fields("akr_Nama_Rek_Pos").Value.ToString.Trim
        End If

        Rs_Baca.Close()
        Close_eSumsel()
    End Sub

    Private Sub dg_TampilData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_TampilData.CellDoubleClick
        mRek_Pos.Text = dg_TampilData.Item(2, dg_TampilData.CurrentRow.Index).Value.ToString.Trim
        get_nama_rek_pos()
        mRek_Kelompok.Text = dg_TampilData.Item(3, dg_TampilData.CurrentRow.Index).Value.ToString.Trim
        mNama_Rek_Kelompok.Text = dg_TampilData.Item(1, dg_TampilData.CurrentRow.Index).Value.ToString.Trim
    End Sub
End Class