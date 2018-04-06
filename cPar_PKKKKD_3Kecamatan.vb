﻿Imports System.Text
Imports System.IO
Imports System.Data.SqlClient
Public Class cPar_PKKKKD_3Kecamatan

    Private Sub tbl_Keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbl_Keluar.Click
        Me.Close()
    End Sub

    Private Sub tbCari01_Click(sender As Object, e As EventArgs) Handles tbCari01.Click
        view_cPar_PKKKKD_1Provinsi.mKodePanggil.Text = "cPar_PKKKKD_3Kecamatan"
        view_cPar_PKKKKD_1Provinsi.ShowDialog(Me)
        tampil_kecamatan()
    End Sub

    Private Sub tbCari02_Click(sender As Object, e As EventArgs) Handles tbCari02.Click

        If mKode_Provinsi.Text.Trim = "" Then
            MsgBox("Kode Provinsi tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If
        view_cPar_PKKKKD_2KabKota.mKodePanggil.Text = "cPar_PKKKKD_3Kecamatan"
        view_cPar_PKKKKD_2KabKota.mKode_Provinsi.Text = mKode_Provinsi.Text.Trim
        view_cPar_PKKKKD_2KabKota.ShowDialog(Me)
        tampil_kecamatan()
    End Sub

    Private Sub tblBaru_Click(sender As Object, e As EventArgs) Handles tblBaru.Click
        mKode_KabKota.Text = ""
        mKode_Kecamatan.Text = ""
        mKode_Provinsi.Text = ""
        mNama_KabKota.Text = ""
        mNama_Kecamatan.Text = ""
        mNama_Provinsi.Text = ""
    End Sub

    Private Sub mKode_Kecamatan_LostFocus(sender As Object, e As EventArgs) Handles mKode_Kecamatan.LostFocus
        'Me.UseWaitCursor = True

        If mKode_Kecamatan.Text.Trim.Length = 1 Then mKode_Kecamatan.Text = "0" & mKode_Kecamatan.Text.Trim
        If Open_eSumsel() = False Then Exit Sub

        Dim sql_Text_Comman As String = "SELECT " _
                                    & " Nama_Kecamatan" _
                                    & " FROM cPar_PKKKKD_3Kecamatan " _
                                    & " WHERE Kode_Provinsi = '" & mKode_Provinsi.Text.Trim & "' " _
                                    & " AND Kode_KabKota = '" & mKode_KabKota.Text.Trim & "' " _
                                    & " AND Kode_Kecamatan = '" & mKode_Kecamatan.Text.Trim & "' " _
                                    & " ORDER By Nama_Kecamatan "
        Rs_Baca.Open(sql_Text_Comman, cn_eSumsel)

        mNama_Kecamatan.Text = ""
        If Rs_Baca.RecordCount > 0 Then
            mNama_Kecamatan.Text = Rs_Baca.Fields("Nama_Kecamatan").Value.ToString.Trim
        End If

        Rs_Baca.Close()
        Close_eSumsel()
        'Me.UseWaitCursor = False
    End Sub

    Private Sub tblSimpan_Click(sender As Object, e As EventArgs) Handles tblSimpan.Click
        If mKode_Provinsi.Text.Trim = "" Then
            MsgBox("Kode Provinsi tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If
        If mNama_Provinsi.Text.Trim = "" Then
            MsgBox("Nama Provinsi tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If
        If mKode_KabKota.Text.Trim = "" Then
            MsgBox("Kode Kabupaten / Kota tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If
        If mNama_KabKota.Text.Trim = "" Then
            MsgBox("Nama Kabupaten / Kota tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If
        If mKode_Kecamatan.Text.Trim = "" Then
            MsgBox("Kode Kecamatan tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If
        If mNama_Kecamatan.Text.Trim = "" Then
            MsgBox("Nama Kecamatan tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If

        If Open_eSumsel() = False Then Exit Sub
        Dim Cari As String = "T"
        Rs_Simpan.Open("Select Kode_Kecamatan from cPar_PKKKKD_3Kecamatan  where " _
                       & " Kode_KabKota = '" & mKode_KabKota.Text.Trim & "'  AND " _
                       & " Kode_Provinsi = '" & mKode_Provinsi.Text.Trim & "' AND " _
                       & " Kode_Kecamatan = '" & mKode_Kecamatan.Text.Trim & " '", cn_eSumsel)
        If Rs_Simpan.RecordCount > 0 Then
            Cari = "Y"
        End If
        Rs_Simpan.Close()

        Dim DeKlare_Data As String = " set dateformat DMY " _
                                & "Declare @Kode_Provinsi	char(2) " _
                                & "Declare @Kode_KabKota	char(2) " _
                                & "Declare @Kode_Kecamatan	char(2) " _
                                & "Declare @Nama_Kecamatan	char(50) " _
                                & "Declare @MAC0 char(20) " _
                                & "Declare @MAC1 char(20) " _
                                & "Declare @IPAdress char(20) " _
                                & "Declare @MBId char(20) " _
                                & "Declare @ProcId char(20) " _
                                & "Declare @Tanggal datetime " _
                                & "Declare @komputer char(100) " _
                                & " " _
                                & " Set @Kode_Provinsi = '" & mKode_Provinsi.Text.Trim & "' " _
                                & " Set @Kode_KabKota = '" & mKode_KabKota.Text.Trim & "' " _
                                & " Set @Kode_Kecamatan = '" & mKode_Kecamatan.Text.Trim & "' " _
                                & " Set @Nama_Kecamatan = '" & mNama_Kecamatan.Text.Trim & "' " _
                                & " Set @MAC0 = '" & MenuUtama.mMAC0.Text.Trim & "' " _
                                & " Set @MAC1 = '" & MenuUtama.mMAC1.Text.Trim & "' " _
                                & " Set @IPAdress = '" & MenuUtama.mIPAdress.Text.Trim & "' " _
                                & " Set @MBId = '" & MenuUtama.mMotherBoardID.Text.Trim & "' " _
                                & " Set @ProcId = '" & MenuUtama.mProcessorID.Text.Trim & "' " _
                                & " Set @Tanggal = '" & str_TanggalServer_DMY() & "' " _
                                & " Set @komputer = '" & Environment.MachineName.Trim & "' "

        Dim Insert_Data As String = " INSERT INTO cPar_PKKKKD_3Kecamatan " _
                                    & " (Kode_Provinsi,Kode_KabKota,Kode_Kecamatan,Nama_Kecamatan,MAC0,MAC1,IPAdress,MBId,ProcId,Tanggal,komputer) VALUES " _
                                    & " (@Kode_Provinsi,@Kode_KabKota,@Kode_Kecamatan,@Nama_Kecamatan, @MAC0, @MAC1, @IPAdress, @MBId, @ProcId, @Tanggal, @komputer) "

        Dim Update_Data As String = "UPDATE cPar_PKKKKD_3Kecamatan " _
                                  & " SET Kode_Provinsi = @Kode_Provinsi ," _
                                  & " Kode_KabKota = @Kode_KabKota ," _
                                  & " Kode_Kecamatan = @Kode_Kecamatan ," _
                                  & " Nama_Kecamatan = @Nama_Kecamatan ," _
                                  & " MAC0 = @MAC0 ," _
                                  & " MAC1 = @MAC1 ," _
                                  & " IPAdress = @IPAdress ," _
                                  & " MBId = @MBId ," _
                                  & " ProcId = @ProcId ," _
                                  & " Tanggal = @Tanggal ," _
                                  & " komputer = @komputer " _
                                  & " WHERE " _
                                  & " Kode_Provinsi = '" & mKode_Provinsi.Text.Trim & "' " _
                                  & " AND Kode_KabKota = '" & mKode_KabKota.Text.Trim & "'  AND  " _
                                  & " Kode_Kecamatan = '" & mKode_Kecamatan.Text.Trim & "'"

        Dim Nilai_Histori As String = "0"
        If Cari = "Y" Then
            Nilai_Histori = "1"
            Dim cek As String = DeKlare_Data & Update_Data
            Rs_Simpan.Open(DeKlare_Data & Update_Data, cn_eSumsel)
        Else
            Rs_Simpan.Open(DeKlare_Data & Insert_Data, cn_eSumsel)
        End If
        Close_eSumsel()
        tampil_kecamatan()

        tblBaru_Click(tblBaru, New EventArgs)
        '==========================
        'yyHis_aPar_UserID(Nilai_Histori) '0 = Inset,1=Update,2=Hapus
        '==========================
        MsgBox("Data telah disimpan.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Informasi")

    End Sub

    Sub tampil_kecamatan()
        If Open_eSumsel_Tampil() = False Then Exit Sub

        Dim sql_kondisi_rek = ""
        If mKode_Provinsi.Text.Trim <> "" Then
            sql_kondisi_rek = sql_kondisi_rek & " and Kode_Provinsi = '" & mKode_Provinsi.Text.Trim & "' "
        End If
        If mKode_KabKota.Text.Trim <> "" Then
            sql_kondisi_rek = sql_kondisi_rek & "and Kode_KabKota = '" & mKode_KabKota.Text.Trim & "' "
        End If

        Dim sql_Kondisi As String = ""
        If mcari.Text.Trim = "" Then
            If sql_kondisi_rek.Trim <> "" Then
                sql_Kondisi = "where " & Mid(sql_kondisi_rek.Trim, 4, sql_kondisi_rek.Trim.Length - 3)
            End If
        Else
            sql_Kondisi = " where (Nama_Kecamatan like '%" & mcari.Text.Trim & "%' ) " & sql_kondisi_rek.Trim
        End If

        Dim sql_Text_Comman As String = " SELECT Kode_Provinsi + '.' + Kode_KabKota + '.' + Kode_Kecamatan  AS [Kode] " _
                                        & "  ,Nama_Kecamatan AS [Nama Kecamatan] " _
                                        & "  ,Kode_Provinsi" _
                                        & "  ,Kode_KabKota" _
                                        & "  ,Kode_Kecamatan" _
                                        & " FROM cPar_PKKKKD_3Kecamatan " & sql_Kondisi _
                                        & " ORDER By Kode_Provinsi "
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

        'dg_TampilData.Columns(2).DefaultCellStyle.Format = "###,###.00"
        'dg_TampilData.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight

        dg_TampilData.Columns(2).Visible = False
        dg_TampilData.Columns(3).Visible = False
        dg_TampilData.Columns(4).Visible = False

    End Sub


    Private Sub tblHapus_Click(sender As Object, e As EventArgs) Handles tblHapus.Click
        If mKode_Provinsi.Text.Trim = "" Then
            MsgBox("Kode Provinsi tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If

        If mKode_KabKota.Text.Trim = "" Then
            MsgBox("Kode Kabupaten / Kota tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If

        If mKode_Kecamatan.Text.Trim = "" Then
            MsgBox("Kode Kecamatan tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If

        Dim Pesan = MsgBox("Yakin Kecamatan " & mNama_Kecamatan.Text.Trim & " ini akan di Hapus [Y/T] ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Informasi")
        If Pesan = MsgBoxResult.Yes Then
            If Open_eSumsel() = False Then Exit Sub
            Rs_Simpan.Open("Delete from cPar_PKKKKD_3Kecamatan  where Kode_Provinsi = '" & mKode_Provinsi.Text & "' " _
                            & "and Kode_KabKota = '" & mKode_KabKota.Text.Trim & "' " _
                            & "and Kode_Kecamatan = '" & mKode_Kecamatan.Text.Trim & "' ", cn_eSumsel)
            Close_eSumsel()

            'Hapus yang berhubungan dengan user id ini

            '==========================
            'yyHis_aPar_UserID("2") '0 = Inset,1=Update,2=Hapus
            '==========================
            tampil_kecamatan()
            tblBaru_Click(tblBaru, New EventArgs)
            MsgBox("provinsi " & mNama_Provinsi.Text.Trim & " telah dihapus.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Informasi")
        End If
        mKode_Provinsi.Text = ""
        mNama_Provinsi.Text = ""
        mKode_KabKota.Text = ""
        mNama_KabKota.Text = ""
        mNama_Kecamatan.Text = ""
        mKode_Kecamatan.Text = ""
    End Sub

    Private Sub mcari_TextChanged(sender As Object, e As EventArgs) Handles mcari.TextChanged
        tampil_kecamatan()
    End Sub

    Private Sub dg_TampilData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_TampilData.CellDoubleClick
        mKode_Provinsi.Text = dg_TampilData.Item(2, dg_TampilData.CurrentRow.Index).Value.ToString.Trim
        get_nama_Provinsi()
        mKode_KabKota.Text = dg_TampilData.Item(3, dg_TampilData.CurrentRow.Index).Value.ToString.Trim
        get_nama_KabKota()
        mKode_Kecamatan.Text = dg_TampilData.Item(4, dg_TampilData.CurrentRow.Index).Value.ToString.Trim
        mNama_Kecamatan.Text = dg_TampilData.Item(1, dg_TampilData.CurrentRow.Index).Value.ToString.Trim
    End Sub
    Private Sub get_nama_Provinsi()
        If mKode_Provinsi.Text.Trim.Length = 1 Then mKode_Provinsi.Text = "0" & mKode_Provinsi.Text.Trim
        If Open_eSumsel() = False Then Exit Sub

        Dim sql_Text_Comman As String = "SELECT " _
                                    & " Nama_Provinsi" _
                                    & " FROM cPar_PKKKKD_1Provinsi " _
                                    & " WHERE Kode_Provinsi = '" & mKode_Provinsi.Text.Trim & "' " _
                                    & " ORDER By Nama_Provinsi "
        Rs_Baca.Open(sql_Text_Comman, cn_eSumsel)

        mNama_Provinsi.Text = ""
        If Rs_Baca.RecordCount > 0 Then
            mNama_Provinsi.Text = Rs_Baca.Fields("Nama_Provinsi").Value.ToString.Trim
        End If

        Rs_Baca.Close()
        Close_eSumsel()
    End Sub

    Private Sub get_nama_KabKota()
        If mKode_Provinsi.Text.Trim.Length = 1 Then mKode_Provinsi.Text = "0" & mKode_Provinsi.Text.Trim
        If Open_eSumsel() = False Then Exit Sub

        Dim sql_Text_Comman As String = "SELECT " _
                                    & " Nama_KabKota" _
                                    & " FROM cPar_PKKKKD_2KabKota " _
                                    & " WHERE Kode_Provinsi = '" & mKode_Provinsi.Text.Trim & "' " _
                                    & " AND Kode_KabKota = '" & mKode_KabKota.Text.Trim & "' " _
                                    & " ORDER By Nama_KabKota "
        Rs_Baca.Open(sql_Text_Comman, cn_eSumsel)

        mNama_KabKota.Text = ""
        If Rs_Baca.RecordCount > 0 Then
            mNama_KabKota.Text = Rs_Baca.Fields("Nama_KabKota").Value.ToString.Trim
        End If

        Rs_Baca.Close()
        Close_eSumsel()
    End Sub
    Private Sub cPar_PKKKKD_3Kecamatan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil_kecamatan()
    End Sub

    Private Sub dg_TampilData_DoubleClick(sender As Object, e As EventArgs) Handles dg_TampilData.DoubleClick

    End Sub
End Class