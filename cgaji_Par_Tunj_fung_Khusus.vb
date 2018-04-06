Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class cgaji_Par_Tunj_fung_Khusus

    Private Sub tbl_Keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbl_Keluar.Click
        Me.Close()
    End Sub

    Private Sub cgaji_Par_Tunj_fung_Khusus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil_tabel()
    End Sub
    Sub tampil_tabel()
        ' Dim mmkondisi As String = ""
        If Open_eSumsel_Tampil() = False Then Exit Sub

        Dim sql_kondisi_rek = ""
        If mKode_Kel_JaFung.Text.Trim <> "" Then
            sql_kondisi_rek = sql_kondisi_rek & " and Kode_Kel_JaFung = '" & mKode_Kel_JaFung.Text.Trim & "' "
        End If
        If mKode_JaFung_Khusus.Text.Trim <> "" Then
            sql_kondisi_rek = sql_kondisi_rek & "and Kode_JaFung_Khusus = '" & mKode_JaFung_Khusus.Text.Trim & "' "
        End If

        Dim sql_Kondisi As String = ""
        If mcari.Text.Trim = "" Then
            If sql_kondisi_rek.Trim <> "" Then
                sql_Kondisi = "where " & Mid(sql_kondisi_rek.Trim, 4, sql_kondisi_rek.Trim.Length - 3)
            End If
        Else
            sql_Kondisi = " where (JaFung_Khusus like '%" & mcari.Text.Trim & "%' ) " & sql_kondisi_rek.Trim
        End If
        Dim sql_Text_Comman As String = "SELECT " _
                                        & " Tahun AS [Tahun], " _
                                        & " Kode_Kel_JaFung + '.' + " _
                                        & " Kode_JaFung_Khusus AS [KodeJab. Fung Khusus], " _
                                        & " JaFung_Khusus AS [Jab. Fungsional Khusus], " _
                                        & " Tunjangan_Fung_Khusus AS [Tunjangan Fungsional Khusus], " _
                                        & " Kode_Kel_JaFung,Kode_JaFung_Khusus " _
                                        & " FROM cgaji_Par_Tunj_fung_Khusus " & sql_Kondisi _
                                        & " ORDER By Kode_Kel_JaFung, Kode_JaFung_Khusus, Tahun"
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

        dg_TampilData.Columns(0).Width = (dg_TampilData.Width / 10) * 1
        dg_TampilData.Columns(1).Width = (dg_TampilData.Width / 10) * 1.5
        dg_TampilData.Columns(2).Width = (dg_TampilData.Width / 10) * 5.2
        dg_TampilData.Columns(3).Width = (dg_TampilData.Width / 10) * 2

        dg_TampilData.Columns(4).Visible = False
        dg_TampilData.Columns(5).Visible = False

        dg_TampilData.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg_TampilData.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg_TampilData.Columns(3).DefaultCellStyle.Format = "###,###.00"
        dg_TampilData.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    Private Sub tbCari01_Click(sender As Object, e As EventArgs) Handles tbCari01.Click
        view_bgaji_Par_JaFung_Kel.mKodePanggil.Text = "cgaji_Par_Tunj_fung_Khusus"
        view_bgaji_Par_JaFung_Kel.ShowDialog(Me)
        tampil_tabel()
    End Sub

    Private Sub tblBaru_Click(sender As Object, e As EventArgs) Handles tblBaru.Click
        'mTahun.Text = ""
        mKode_Kel_JaFung.Text = ""
        mKel_JaFung.Text = ""
        mKode_JaFung_Khusus.Text = ""
        mJaFung_Khusus.Text = ""
        mTunjangan_Fung_Khusus.Text = ""
        mKode_Dokumen.Text = ""
        tampil_tabel()
    End Sub


    Private Sub mKode_JaFung_Khusus_LostFocus(sender As Object, e As EventArgs) Handles mKode_JaFung_Khusus.LostFocus
        If Open_eSumsel() = False Then Exit Sub
        Dim Cari As String = "T"
        Rs_Baca.Open("Select * from cgaji_Par_Tunj_fung_Khusus where Tahun='" & mTahun.Text & "' and Kode_Kel_JaFung = '" & mKode_Kel_JaFung.Text & "' and Kode_JaFung_Khusus = '" & mKode_JaFung_Khusus.Text & "'", cn_eSumsel)
        mJaFung_Khusus.Text = ""
        mTunjangan_Fung_Khusus.Text = ""
        If Rs_Baca.RecordCount > 0 Then
            mJaFung_Khusus.Text = Rs_Baca.Fields("JaFung_Khusus").Value.ToString.Trim
            mTunjangan_Fung_Khusus.Text = Format(Rs_Baca.Fields("Tunjangan_Fung_Khusus").Value, "###,###.00")
        End If
        Rs_Baca.Close()
    End Sub

    Private Sub tblSimpan_Click(sender As Object, e As EventArgs) Handles tblSimpan.Click
        If mKode_Kel_JaFung.Text.Trim = "" Then
            MsgBox("Kode Kelompok Jabatan Fungsional tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If

        If mKode_JaFung_Khusus.Text.Trim = "" Then
            MsgBox("Kode Jabatan Fungsional Khusus tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If

        If mJaFung_Khusus.Text.Trim = "" Then
            MsgBox("Nama Jabatan Fungsional Khusus tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If


        If Val(mTunjangan_Fung_Khusus.Text) <= 0 Then
            MsgBox("Tunjangan tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If



        If Open_eSumsel() = False Then Exit Sub
        Dim Cari As String = "T"
        Rs_Simpan.Open("Select Tahun from cgaji_Par_Tunj_fung_Khusus where " _
                       & " Tahun = '" & mTahun.Text & "' and " _
                       & " Kode_Kel_JaFung = '" & mKode_Kel_JaFung.Text & "' and " _
                       & " Kode_JaFung_Khusus = '" & mKode_JaFung_Khusus.Text & "'", cn_eSumsel)
        If Rs_Simpan.RecordCount > 0 Then
            Cari = "Y"
        End If
        Rs_Simpan.Close()

        Dim DeKlare_Data As String = " set dateformat DMY " _
                       & " Declare @Tahun Char(4)" _
                       & " Declare @Kode_Kel_JaFung	Char(2)" _
                       & " Declare @Kode_JaFung_Khusus Char(3)" _
                       & " Declare @JaFung_Khusus  Char(75)" _
                       & " Declare @Tunjangan_Fung_Khusus   money" _
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
                        & " Set @Kode_Kel_JaFung= '" & mKode_Kel_JaFung.Text & "' " _
                        & " Set @Kode_JaFung_Khusus= '" & mKode_JaFung_Khusus.Text & "' " _
                        & " Set @JaFung_Khusus= '" & mJaFung_Khusus.Text & "' " _
                        & " Set @Tunjangan_Fung_Khusus = '" & mTunjangan_Fung_Khusus.Text & "' " _
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
                   & "INSERT INTO cgaji_Par_Tunj_fung_Khusus" _
                   & "(Tahun,Kode_Kel_JaFung,Kode_JaFung_Khusus,JaFung_Khusus,Tunjangan_Fung_Khusus,UserID_Entry,komputer,MAC0,MAC1,IPAdress,MBId,ProcId,Tanggal,Kode_Dokumen) values " _
                   & "(@Tahun,@Kode_Kel_JaFung,@Kode_JaFung_Khusus,@JaFung_Khusus,@Tunjangan_Fung_Khusus,@UserID_Entry,@komputer,@MAC0,@MAC1,@IPAdress,@MBId,@ProcId,@Tanggal,@Kode_Dokumen)"

        Dim Update_Data As String = " " _
            & " Update cgaji_Par_Tunj_fung_Khusus Set" _
            & " Tahun = @Tahun, " _
            & " Kode_Kel_JaFung= @Kode_Kel_JaFung, " _
            & " Kode_JaFung_Khusus= @Kode_JaFung_Khusus, " _
            & " JaFung_Khusus= @JaFung_Khusus, " _
            & " Tunjangan_Fung_Khusus= @Tunjangan_Fung_Khusus, " _
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
            & " Where Tahun = @Tahun and Kode_Kel_JaFung= @Kode_Kel_JaFung and Kode_JaFung_Khusus=@Kode_JaFung_Khusus"

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

    Private Sub dg_TampilData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_TampilData.CellContentClick

    End Sub

    Private Sub dg_TampilData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_TampilData.CellDoubleClick
        mTahun.Text = dg_TampilData.Item(0, dg_TampilData.CurrentRow.Index).Value
        mKode_Kel_JaFung.Text = dg_TampilData.Item(4, dg_TampilData.CurrentRow.Index).Value
        mKode_JaFung_Khusus.Text = dg_TampilData.Item(5, dg_TampilData.CurrentRow.Index).Value
        mJaFung_Khusus.Text = dg_TampilData.Item(2, dg_TampilData.CurrentRow.Index).Value
        mTunjangan_Fung_Khusus.Text = Format(dg_TampilData.Item(3, dg_TampilData.CurrentRow.Index).Value, "###,###.00")

        If Open_eSumsel() = False Then Exit Sub
        'Dim Cari As String = "T"
        Rs_Baca.Open("Select * from bgaji_Par_JaFung_Kel where Kode_Kel_JaFung = '" & mKode_Kel_JaFung.Text & "'", cn_eSumsel)
        If Rs_Baca.RecordCount > 0 Then
            mKel_JaFung.Text = Rs_Baca.Fields("Kel_JaFung").Value
        End If
        Rs_Baca.Close()
        Close_eSumsel()
    End Sub

    Private Sub tblHapus_Click(sender As Object, e As EventArgs) Handles tblHapus.Click
        Dim Pesan = MsgBox("Yakin Data Tahun: " & mTahun.Text.Trim & " , Kode Kelompok Jabatan Fungsional : " & mKode_Kel_JaFung.Text.Trim & " , Kode Jabatan Fungsional : " & mKode_JaFung_Khusus.Text & " ini akan di Hapus [Y/T] ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Informasi")
        If Pesan = MsgBoxResult.Yes Then
            If Open_eSumsel() = False Then Exit Sub
            Rs_Simpan.Open("Delete from cgaji_Par_Tunj_fung_Khusus where Tahun='" & mTahun.Text & "' and Kode_Kel_JaFung = '" & mKode_Kel_JaFung.Text & "' and Kode_JaFung_Khusus = '" & mKode_JaFung_Khusus.Text & "'", cn_eSumsel)

            Close_eSumsel()

            'Hapus yang berhubungan dengan user id ini

            '==========================
            'yyHis_aPar_UserID("2") '0 = Inset,1=Update,2=Hapus
            '==========================
            ' dg_TampilData.Rows.Remove(dg_TampilData.CurrentRow)
            tampil_tabel()
            tblBaru_Click(tblBaru, New EventArgs)
            MsgBox("Data telah dihapus.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Informasi")
        End If
    End Sub


    Private Sub mTahun_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mTahun.KeyPress
        e.Handled = True
    End Sub

    Private Sub mTunjangan_Fung_Khusus_GotFocus(sender As Object, e As EventArgs) Handles mTunjangan_Fung_Khusus.GotFocus
        mTunjangan_Fung_Khusus.Text = Format(ValChip(mTunjangan_Fung_Khusus.Text), "######.##")
    End Sub

    Private Sub mTunjangan_Fung_Khusus_LostFocus(sender As Object, e As EventArgs) Handles mTunjangan_Fung_Khusus.LostFocus
        mTunjangan_Fung_Khusus.Text = Format(ValChip(mTunjangan_Fung_Khusus.Text), "###,###.00")
    End Sub
End Class