Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class cgaji_Par_Gaji_Pokok
    'Dim TmpGaji
    Private Sub tbl_Keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbl_Keluar.Click
        Me.Close()
    End Sub

    Private Sub cgaji_Par_Gaji_Pokok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil_tabel()
    End Sub
    Sub tampil_tabel()
        'Dim mmkondisi As String = ""

        Dim mmkondisi As String = ""
        If Open_eSumsel_Tampil() = False Then Exit Sub
        If mGol.Text.Trim = "" Then
        Else
            mmkondisi = " where Tahun='" & mTahun.Text & "' and Gol='" & mGol.Text & "'"
        End If

        Dim sql_Text_Comman As String = "SELECT " _
                                    & " Tahun AS [Tahun], " _
                                    & " Gol AS [Gol], " _
                                    & " Masa_Kerja AS [Masa_Kerja], " _
                                    & " Gaji_Pokok AS [Gaji_Pokok] " _
                                    & " FROM cgaji_Par_Gaji_Pokok " & mmkondisi _
                                    & " ORDER By Gol, Masa_Kerja"

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
        dg_TampilData.Columns(1).Width = (dg_TampilData.Width / 10) * 1.0
        dg_TampilData.Columns(2).Width = (dg_TampilData.Width / 10) * 2
        dg_TampilData.Columns(3).Width = (dg_TampilData.Width / 10) * 5.6
        dg_TampilData.Columns(3).DefaultCellStyle.Format = "###,###.00"
        dg_TampilData.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg_TampilData.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg_TampilData.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg_TampilData.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        'dg_User.Columns(4).Width = (dg_User.Width / 10) * 1.7
        'dg_User.Columns(5).Width = (dg_User.Width / 10) * 1
        'dg_User.Columns(6).Width = (dg_User.Width / 10) * 3.5
    End Sub
    Private Sub tblCari01_Click(sender As Object, e As EventArgs) Handles tblCari01.Click
        view_bPar_Gol_Pangkat.mKodePanggil.Text = "cgaji_Par_Gaji_Pokok"
        view_bPar_Gol_Pangkat.ShowDialog(Me)

        tampil_tabel()
    End Sub

    Private Sub tblBaru_Click(sender As Object, e As EventArgs) Handles tblBaru.Click
        'mTahun.Text = ""
        mGol.Text = ""
        mPangkat.Text = ""
        mMasa_Kerja.Value = 0
        mGaji_Pokok.Text = ""
    End Sub

    Private Sub tblSimpan_Click(sender As Object, e As EventArgs) Handles tblSimpan.Click
        If mGol.Text.Trim = "" Then
            MsgBox("Golongan tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If

        If mMasa_Kerja.Value <= 0 Then
            MsgBox("Masa kerja tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If
        If mGaji_Pokok.Text = "" Then
            MsgBox("Gaji pokok tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If

        If Open_eSumsel() = False Then Exit Sub
        Dim Cari As String = "T"
        Rs_Simpan.Open("Select Gol, Masa_Kerja from cgaji_Par_Gaji_Pokok where " _
                       & " Tahun='" & mTahun.Text & "' and " _
                       & " Gol = '" & mGol.Text & "' and " _
                       & " Masa_Kerja = " & mMasa_Kerja.Value & " ", cn_eSumsel)
        If Rs_Simpan.RecordCount > 0 Then
            Cari = "Y"
        End If
        Rs_Simpan.Close()

        Dim DeKlare_Data As String = " set dateformat DMY " _
                       & " Declare @Tahun Char(4)" _
                       & " Declare @Gol Char(5)" _
                       & " Declare @Masa_Kerja  tinyint" _
                       & " Declare @Gaji_Pokok money" _
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
                       & " Set @Masa_Kerja = '" & mMasa_Kerja.Value & "' " _
                       & " Set @Gaji_Pokok= '" & Val(mGaji_Pokok.Text) & "' " _
                       & " Set @UserID_Entry = '" & MenuUtama.mUserID.Text.Trim & "' " _
                       & " Set @komputer = '" & Environment.MachineName.Trim & "' " _
                       & " Set @MAC0 = '" & MenuUtama.mMAC0.Text.Trim & "' " _
                       & " Set @MAC1 = '" & MenuUtama.mMAC1.Text.Trim & "' " _
                       & " Set @IPAdress = '" & MenuUtama.mIPAdress.Text.Trim & "' " _
                       & " Set @MBId = '" & MenuUtama.mMotherBoardID.Text.Trim & "' " _
                       & " Set @ProcId = '" & MenuUtama.mProcessorID.Text.Trim & "' " _
                       & " Set @Tanggal = '" & str_TanggalServer_DMY() & "' " _
                       & " Set @Kode_Dokumen = '" & str_TanggalServer_DMY() & "' "

        Dim Insert_Data As String = " " _
                   & "INSERT INTO cgaji_Par_Gaji_Pokok" _
                   & "(Tahun,Gol,Masa_Kerja,Gaji_Pokok,UserID_Entry,komputer,MAC0,MAC1,IPAdress,MBId,ProcId,Tanggal,Kode_Dokumen) values " _
                   & "(@Tahun,@Gol,@Masa_Kerja,@Gaji_Pokok,@UserID_Entry,@komputer,@MAC0,@MAC1,@IPAdress,@MBId,@ProcId,@Tanggal,@Kode_Dokumen)"

        Dim Update_Data As String = " " _
            & " Update cgaji_Par_Gaji_Pokok Set" _
            & " Tahun = @Tahun, " _
            & " Gol   = @Gol, " _
            & " Masa_Kerja= @Masa_Kerja, " _
            & " Gaji_Pokok= @Gaji_Pokok, " _
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
            & " Where Tahun = @Tahun and Gol = @Gol and Masa_Kerja= @Masa_Kerja "

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

    Private Sub mMasa_Kerja_ValueChanged(sender As Object, e As EventArgs) Handles mMasa_Kerja.ValueChanged
        tampil_gaji()
    End Sub

    Sub tampil_gaji()
        If Open_eSumsel() = False Then Exit Sub
        mGaji_Pokok.Text = ""
        Dim Cari As String = "T"
        Rs_Baca.Open("Select * from cgaji_Par_Gaji_Pokok where " _
                     & " Tahun='" & mTahun.Text & "' and " _
                     & " Gol = '" & mGol.Text.Trim & "' and " _
                     & " Masa_Kerja='" & mMasa_Kerja.Value & "'", cn_eSumsel)
        If Rs_Baca.RecordCount > 0 Then
            Cari = "Y"
            Rs_Baca.MoveFirst()
            mGaji_Pokok.Text = Format(Rs_Baca.Fields("Gaji_Pokok").Value, "###,###.00")
            'TmpGaji = Rs_Baca.Fields("Gaji_Pokok").Value.ToString.Trim
        End If
        Rs_Baca.Close()
        Close_eSumsel()
    End Sub


    Private Sub tblHapus_Click(sender As Object, e As EventArgs) Handles tblHapus.Click
        Dim Pesan = MsgBox("Yakin Data Tahun: " & mTahun.Text.Trim & " , Gol: " & mGol.Text.Trim & " dan Masa Kerja: " & mMasa_Kerja.Value & " ini akan di Hapus [Y/T] ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Informasi")
        If Pesan = MsgBoxResult.Yes Then
            If Open_eSumsel() = False Then Exit Sub
            Rs_Simpan.Open("Delete from cgaji_Par_Gaji_Pokok where Tahun='" & mTahun.Text & "' and Gol = '" & mGol.Text.Trim & "' and Masa_Kerja= " & mMasa_Kerja.Value & " ", cn_eSumsel)

            Close_eSumsel()

            'Hapus yang berhubungan dengan user id ini

            '==========================
            'yyHis_aPar_UserID("2") '0 = Inset,1=Update,2=Hapus
            '==========================
            'dg_TampilData.Rows.Remove(dg_TampilData.CurrentRow)
            tampil_tabel()
            tblBaru_Click(tblBaru, New EventArgs)
            MsgBox("Data telah dihapus.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Informasi")
        End If
    End Sub


    Private Sub dg_TampilData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_TampilData.CellDoubleClick
        mTahun.Text = dg_TampilData.Item(0, dg_TampilData.CurrentRow.Index).Value
        mGol.Text = dg_TampilData.Item(1, dg_TampilData.CurrentRow.Index).Value
        mMasa_Kerja.Value = dg_TampilData.Item(2, dg_TampilData.CurrentRow.Index).Value
        mGaji_Pokok.Text = Val(dg_TampilData.Item(3, dg_TampilData.CurrentRow.Index).Value)
        'TmpGaji = Val(mGaji_Pokok.Text)
    End Sub

    Private Sub mTahun_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mTahun.SelectedIndexChanged
        'tampil_tabel()
    End Sub

    Private Sub mTahun_TextChanged(sender As Object, e As EventArgs) Handles mTahun.TextChanged

    End Sub

    Private Sub mTahun_LostFocus(sender As Object, e As EventArgs) Handles mTahun.LostFocus
        tampil_tabel()
    End Sub

    Private Sub mGaji_Pokok_TextChanged(sender As Object, e As EventArgs) Handles mGaji_Pokok.TextChanged

    End Sub

    Private Sub mGaji_Pokok_GotFocus(sender As Object, e As EventArgs) Handles mGaji_Pokok.GotFocus
        mGaji_Pokok.Text = Format(ValChip(mGaji_Pokok.Text), "######.##")
    End Sub

    Private Sub mGaji_Pokok_LostFocus(sender As Object, e As EventArgs) Handles mGaji_Pokok.LostFocus
        mGaji_Pokok.Text = Format(ValChip(mGaji_Pokok.Text), "###,###.00")
    End Sub

    Private Sub mTahun_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mTahun.KeyPress
        e.Handled = True
    End Sub


End Class