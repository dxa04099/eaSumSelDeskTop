﻿Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class cGaji_Par_Tunj_DT

    Private Sub tbl_Keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbl_Keluar.Click
        Me.Close()
    End Sub

    Private Sub cGaji_Par_Tunj_DT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil_tabel()
    End Sub
    Sub tampil_tabel()
        Dim mmkondisi As String = ""
        If mGol.Text.Trim <> "" Then
            mmkondisi = " where Tahun = '" & mTahun.Text.Trim & "' "
        End If
        If Open_eSumsel_Tampil() = False Then Exit Sub

        Dim sql_Text_Comman As String = "SELECT " _
                                        & " Tahun AS [Tahun], " _
                                        & " Gol AS [Gol], " _
                                        & " Pangkat AS [Pangkat], " _
                                        & " Tunjangan_DT AS [Tunjangan_DT] " _
                                        & " FROM cGaji_Par_Tunj_DT " & mmkondisi _
                                        & " ORDER By Gol, Pangkat, Tahun"
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

        dg_TampilData.Columns(0).Width = (dg_TampilData.Width / 10) * 1.95
        dg_TampilData.Columns(1).Width = (dg_TampilData.Width / 10) * 1.95
        dg_TampilData.Columns(2).Width = (dg_TampilData.Width / 10) * 3.6
        dg_TampilData.Columns(3).Width = (dg_TampilData.Width / 10) * 2

        dg_TampilData.Columns(3).DefaultCellStyle.Format = "###,###.00"
        dg_TampilData.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    Private Sub tblBaru_Click(sender As Object, e As EventArgs) Handles tblBaru.Click
        'mTahun.Text = ""
        mGol.Text = ""
        mPangkat.Text = ""
        mTunjangan_DT.Text = ""
        mKode_Dokumen.Text = ""
    End Sub
    Private Sub mTahun_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mTahun.KeyPress
        e.Handled = True
    End Sub
    Private Sub tblCari01_Click(sender As Object, e As EventArgs) Handles tblCari01.Click
        view_bPar_Gol_Pangkat.mKodePanggil.Text = "cGaji_Par_Tunj_DT"
        view_bPar_Gol_Pangkat.ShowDialog(Me)

        mTunjangan_DT.Text = ""

        If Open_eSumsel() = False Then Exit Sub
        Rs_Baca.Open("Select * from cGaji_Par_Tunj_DT where " _
                     & " Tahun = '" & mTahun.Text.Trim & "' and " _
                     & " Gol = '" & mGol.Text.Trim & "'", cn_eSumsel)

        If Rs_Baca.RecordCount > 0 Then
            Rs_Baca.MoveFirst()
            mTunjangan_DT.Text = Format(Rs_Baca.Fields("Tunjangan_DT").Value, "###,###.00")
        End If
        Rs_Baca.Close()
        Close_eSumsel()
        tampil_tabel()
    End Sub

    Private Sub dg_TampilData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_TampilData.CellDoubleClick
        mTahun.Text = dg_TampilData.Item(0, dg_TampilData.CurrentRow.Index).Value.ToString.Trim
        mGol.Text = dg_TampilData.Item(1, dg_TampilData.CurrentRow.Index).Value.ToString.Trim
        mPangkat.Text = dg_TampilData.Item(2, dg_TampilData.CurrentRow.Index).Value.ToString.Trim
        mTunjangan_DT.Text = Format(dg_TampilData.Item(3, dg_TampilData.CurrentRow.Index).Value, "###,###.00")
    End Sub

    Private Sub tblSimpan_Click(sender As Object, e As EventArgs) Handles tblSimpan.Click
        If mTahun.Text = "" Then
            MsgBox("Tahun tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If

        If mGol.Text.Trim = "" Then
            MsgBox("Golongan tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If

        If Val(mTunjangan_DT.Text) <= 0 Then
            MsgBox("Tunjangan tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If

        If Open_eSumsel() = False Then Exit Sub
        Dim Cari As String = "T"
        Rs_Simpan.Open("Select Tahun from cGaji_Par_Tunj_DT where Tahun='" & mTahun.Text & "' and Gol = '" & mGol.Text & "' ", cn_eSumsel)
        If Rs_Simpan.RecordCount > 0 Then
            Cari = "Y"
        End If
        Rs_Simpan.Close()

        Dim DeKlare_Data As String = " set dateformat DMY " _
                       & " Declare @Tahun Char(4)" _
                       & " Declare @Gol	Char(5)" _
                       & " Declare @Pangkat	Char(25)" _
                       & " Declare @Tunjangan_DT   money" _
                       & " Declare @UserID_Entry Char(20)" _
                       & " Declare @komputer    Char(100)" _
                       & " Declare @MAC0    Char(20)" _
                       & " Declare @MAC1    Char(20)" _
                       & " Declare @IPAdress    Char(20)" _
                       & " Declare @MBId    Char(20)" _
                       & " Declare @ProcId  Char(20)" _
                       & " Declare @Tanggal DateTime" _
                       & " Declare @Kode_Dokumen Char(50)" _
                       & " " _
                        & " Set @Tahun= '" & mTahun.Text & "' " _
                        & " Set @Gol= '" & mGol.Text & "' " _
                        & " Set @Pangkat= '" & mPangkat.Text & "' " _
                        & " Set @Tunjangan_DT= '" & mTunjangan_DT.Text & "' " _
                       & " Set @UserID_Entry = '" & MenuUtama.mUserID.Text.Trim & "' " _
                       & " Set @komputer = '" & Environment.MachineName.Trim & "' " _
                       & " Set @MAC0 = '" & MenuUtama.mMAC0.Text.Trim & "' " _
                       & " Set @MAC1 = '" & MenuUtama.mMAC1.Text.Trim & "' " _
                       & " Set @IPAdress = '" & MenuUtama.mIPAdress.Text.Trim & "' " _
                       & " Set @MBId = '" & MenuUtama.mMotherBoardID.Text.Trim & "' " _
                       & " Set @ProcId = '" & MenuUtama.mProcessorID.Text.Trim & "' " _
                       & " Set @Tanggal = '" & str_TanggalServer_DMY() & "' " _
                        & " Set @Kode_Dokumen = '" & mKode_Dokumen.Text & "' "

        Dim Insert_Data As String = " " _
                   & "INSERT INTO cGaji_Par_Tunj_DT" _
                   & "(Tahun,Gol,Pangkat,Tunjangan_DT,UserID_Entry,komputer,MAC0,MAC1,IPAdress,MBId,ProcId,Tanggal,Kode_Dokumen) values " _
                   & "(@Tahun,@Gol,@Pangkat,@Tunjangan_DT,@UserID_Entry,@komputer,@MAC0,@MAC1,@IPAdress,@MBId,@ProcId,@Tanggal,@Kode_Dokumen)"

        Dim Update_Data As String = " " _
            & " Update cGaji_Par_Tunj_DT Set" _
            & " Tahun = @Tahun, " _
            & " Gol= @Gol, " _
            & " Pangkat= @Pangkat, " _
            & " Tunjangan_DT= @Tunjangan_DT, " _
            & " UserID_Entry= @UserID_Entry, " _
            & " komputer= @komputer, " _
            & " MAC0= @MAC0, " _
            & " MAC1= @MAC1, " _
            & " IPAdress= @IPAdress, " _
            & " MBId= @MBId, " _
            & " ProcId= @ProcId, " _
            & " Tanggal= @Tanggal, " _
            & " Kode_Dokumen= @Kode_Dokumen " _
            & " " _
            & " Where Tahun = @Tahun and Gol=@Gol  "

        Dim Nilai_Histori As String = "0"
        If Cari = "Y" Then
            Nilai_Histori = "1"
            Rs_Simpan.Open(DeKlare_Data & Update_Data, cn_eSumsel)
        Else
            Rs_Simpan.Open(DeKlare_Data & Insert_Data, cn_eSumsel)

        End If

        Close_eSumsel()

        tampil_tabel()

        '==========================
        'yyHis_aPar_UserID(Nilai_Histori) '0 = Inset,1=Update,2=Hapus
        '==========================
        tblBaru_Click(tblBaru, New EventArgs)
        MsgBox("Data telah disimpan.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Informasi")
    End Sub

    Private Sub tblHapus_Click(sender As Object, e As EventArgs) Handles tblHapus.Click
        Dim Pesan = MsgBox("Yakin Data Tahun: " & mTahun.Text.Trim & " , Gol : " & mGol.Text.Trim & " , Pangkat : " & mPangkat.Text.Trim & " ini akan di Hapus [Y/T] ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Informasi")
        If Pesan = MsgBoxResult.Yes Then
            If Open_eSumsel() = False Then Exit Sub
            Rs_Simpan.Open("Delete from cGaji_Par_Tunj_DT where Tahun='" & mTahun.Text & "' and Gol = '" & mGol.Text.Trim & "'  ", cn_eSumsel)

            Close_eSumsel()

            'Hapus yang berhubungan dengan user id ini

            '==========================
            'yyHis_aPar_UserID("2") '0 = Inset,1=Update,2=Hapus
            '==========================
            dg_TampilData.Rows.Remove(dg_TampilData.CurrentRow)
            tblBaru_Click(tblBaru, New EventArgs)
            MsgBox("Data telah dihapus.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

    Private Sub mTunjangan_DT_GotFocus(sender As Object, e As EventArgs) Handles mTunjangan_DT.GotFocus
        mTunjangan_DT.Text = Format(ValChip(mTunjangan_DT.Text), "######.##")
    End Sub

    Private Sub mTunjangan_DT_LostFocus(sender As Object, e As EventArgs) Handles mTunjangan_DT.LostFocus
        mTunjangan_DT.Text = Format(ValChip(mTunjangan_DT.Text), "###,###.00")
    End Sub
End Class