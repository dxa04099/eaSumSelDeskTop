Imports System.Text
Imports System.IO
Imports System.Data.SqlClient
Public Class f_UserManagement

    Private Sub tblBaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblBaru.Click

        mUserID.Text = ""
        mNama.Text = ""
        mKelamin.Text = ""
        mKd_Level.Text = ""
        mKd_Level.Enabled = False
        mPWD1.Text = ""
        mKeterangan.Text = ""
        mKd_Level.Text = ""
        mUserID_Induk.Text = ""
        'tampil_iduser()
        mUserID.Focus()
    End Sub
    Private Sub tbl_Keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbl_Keluar.Click
        Me.Close()
    End Sub

    Private Sub f_UserManagement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tblBaru_Click(tblBaru, New EventArgs)
        'If Open_eSumsel() = False Then Exit Sub

        'mIDGroup.Items.Clear()
        'Rs_Baca.Open("Select IDGroup from aPar_UserID_Group order by   IDGroup", cn_eSumsel)
        'If Rs_Baca.RecordCount > 0 Then
        '    Rs_Baca.MoveFirst()
        '    Do While Rs_Baca.EOF = False
        '        mIDGroup.Items.Add(Rs_Baca.Fields("IDGroup").Value.ToString.Trim)
        '        Rs_Baca.MoveNext()
        '    Loop
        'End If
        'Rs_Baca.Close()
        'Close_eSumsel()
        Buka_Tutup_Tampila_PWD()
        tampil_iduser()
    End Sub

    Sub Buka_Tutup_Kd_Level()
        If MenuUtama.mKd_Level.Text.Trim = "1" Then
            mKd_Level.Enabled = True
        Else
            mKd_Level.Text = "3. Operator"
            mKd_Level.Enabled = False
        End If
    End Sub
    Sub Buka_Tutup_Tampila_PWD()
        If MenuUtama.mUserID.Text.Trim.ToUpper = "ADMIN" Or MenuUtama.mUserID.Text.Trim.ToUpper = mUserID_Induk.Text.ToUpper Then
            mPWD1.PasswordChar = ""
        Else
            mPWD1.PasswordChar = "X"
        End If
    End Sub
    Private Sub mIDGroup_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub


    Private Sub mJabatan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mKd_Level.KeyPress
        e.Handled = True
    End Sub

    Private Sub mKelamin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mKelamin.KeyPress
        e.Handled = True
    End Sub

    Sub mIDUser_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles mUserID.LostFocus
        mKd_Level.Enabled = False
        tbCari01.Visible = False
        mUserID_Induk.Text = MenuUtama.mUserID.Text.Trim

        If mUserID.Text.Trim = "" Then Exit Sub
        If mUserID.Text.Trim.ToUpper = "ADMIN" Then
            mUserID.Text = "admin"
            If MenuUtama.mUserID.Text.Trim.ToUpper = "ADMIN" Then
                mKd_Level.Enabled = True
                mUserID_Induk.Text = "admin"
                mPWD1.PasswordChar = ""
            Else
                MsgBox("anda tidak berhak mengakses User admin..", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
                mUserID.Text = ""
                Exit Sub

            End If
        Else
            If MenuUtama.mKd_Level.Text.Trim = "1" Then
                mPWD1.PasswordChar = "X"
                mKd_Level.Enabled = True
            Else
                mKd_Level.Enabled = False
                mKd_Level.Text = "3. Operator"

            End If
        End If

        If Open_eSumsel() = False Then Exit Sub
        Dim Cari As String = "T"
        Rs_Baca.Open("Select * from aPar_UserID   where UserID = '" & mUserID.Text & "' ", cn_eSumsel)
        If Rs_Baca.RecordCount > 0 Then
            Cari = "Y"
            Rs_Baca.MoveFirst()
            mNama.Text = Rs_Baca.Fields("Nama").Value.ToString.Trim
            mKelamin.Text = Rs_Baca.Fields("Jenis_Kelamin").Value.ToString.Trim
            mKd_Level.Text = UbahPswKechr(Rs_Baca.Fields("Kd_Level").Value, mUserID.Text)
            mUserID_Induk.Text = Rs_Baca.Fields("UserID_Induk").Value
            mPWD1.Text = AmbilPWD(Rs_Baca.Fields("Pwd").Value, mUserID.Text)
            mKeterangan.Text = Rs_Baca.Fields("Keterangan").Value.ToString.Trim
            If mKd_Level.Text.Trim = "1" Then
                mKd_Level.Text = "1. Admin"
            Else
                If mKd_Level.Text.Trim = "2" Then
                    mKd_Level.Text = "2. Sub Admin"
                Else
                    mKd_Level.Text = "3. Operator"
                End If
            End If
        End If
        Rs_Baca.Close()

        If Cari = "Y" Then
            tbCari01.Visible = False
            If MenuUtama.mUserID.Text.Trim.ToUpper = "ADMIN" Then
                mPWD1.PasswordChar = ""
                mKd_Level.Enabled = True
                'Jika Memanggil dirinya sendiri atau orang lain
                If mUserID.Text.Trim.ToUpper = "ADMIN" Then
                    mUserID_Induk.Text = "admin"
                Else
                    'User Induk bisa diubah dengan memilih User yg level 2
                    tbCari01.Visible = True
                End If
            Else
                mPWD1.PasswordChar = "X"
                'MsgBox(mUserID_Induk.Text & "=" & MenuUtama.mUserID.Text & " or " & mUserID.Text & "=" & MenuUtama.mUserID.Text)

                If mUserID_Induk.Text.Trim = MenuUtama.mUserID.Text.Trim Or mUserID.Text.Trim = MenuUtama.mUserID.Text.Trim Then
                Else
                    MsgBox("Anda tidak berhak mengakse user ini, Hanya User yang berinduk pada user anda yg bisa di akses...", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
                    tblBaru_Click(tblBaru, New EventArgs)
                End If
                If MenuUtama.mKd_Level.Text.Trim = "1" Then
                    If mUserID.Text.Trim = MenuUtama.mUserID.Text.Trim Then
                        mKd_Level.Enabled = False
                    Else
                        mKd_Level.Enabled = True
                        mKd_Level.Items.Clear()
                        mKd_Level.Items.Add("2. Sub Admin")
                        mKd_Level.Items.Add("3. Operator")
                    End If
                Else
                    If mUserID.Text.Trim = MenuUtama.mUserID.Text.Trim Then
                        mKd_Level.Enabled = False
                    Else
                        mKd_Level.Enabled = False
                        mUserID_Induk.Text = MenuUtama.mUserID.Text
                        mKd_Level.Text = "3. Operator"
                    End If

                End If
            End If
        End If

        Buka_Tutup_Tampila_PWD()
    End Sub
    Private Sub tblSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblSimpan.Click
        If mUserID.Text.Trim = "" Then
            MsgBox("Id User tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If
        If mNama.Text.Trim = "" Then
            MsgBox("Nama tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If
        If mKelamin.Text.Trim = "" Then
            MsgBox("Jenis Kelamin tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If
        If mKd_Level.Text.Trim = "" Then
            MsgBox("Kode Level tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If
        If mUserID_Induk.Text.Trim = "" Then
            MsgBox("User Id Induk tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If
        If mPWD1.Text.Trim = "" Then
            MsgBox("Password tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If
        If mKeterangan.Text.Trim = "" Then
            MsgBox("Keterangan tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If


        If Open_eSumsel() = False Then Exit Sub
        Dim Cari As String = "T"
        Rs_Simpan.Open("Select UserID from aPar_UserID  where UserID = '" & mUserID.Text & "' ", cn_eSumsel)
        If Rs_Simpan.RecordCount > 0 Then
            Cari = "Y"
        End If
        Rs_Simpan.Close()

        Dim DeKlare_Data As String = " set dateformat DMY " _
                        & " Declare @UserID char(20)  " _
                        & " Declare @Nama char(50) " _
                        & " Declare @Jenis_Kelamin char(10) " _
                        & " Declare @Kd_Level char(1) " _
                        & " Declare @UserID_Induk char(155) " _
                        & " Declare @Pwd char(155) " _
                        & " Declare @Keterangan varchar(MAX) " _
                        & " Declare @IDGroup char(155) " _
                        & " Declare @UserID_Entry char(20) " _
                        & " Declare @komputer char(100) " _
                        & " Declare @MAC0 char(20) " _
                        & " Declare @MAC1 char(20) " _
                        & " Declare @IPAdress char(20) " _
                        & " Declare @MBId char(20) " _
                        & " Declare @ProcId char(20) " _
                        & " Declare @Tanggal datetime " _
                        & " " _
                        & " Set @UserID = '" & mUserID.Text & "' " _
                        & " Set @Nama = '" & mNama.Text.Trim & "' " _
                        & " Set @Jenis_Kelamin = '" & mKelamin.Text.Trim & "' " _
                        & " Set @Kd_Level = '" & UbahPswKeAsci(Mid(mKd_Level.Text.Trim, 1, 1), mUserID.Text) & "' " _
                        & " Set @UserID_Induk = '" & mUserID_Induk.Text.Trim & "' " _
                        & " Set @Pwd = '" & SimpanPWD(mPWD1.Text, mUserID.Text) & "' " _
                        & " Set @Keterangan = '" & mKeterangan.Text.Trim & "' " _
                        & " Set @UserID_Entry = '" & MenuUtama.mUserID.Text.Trim & "' " _
                        & " Set @komputer = '" & Environment.MachineName.Trim & "' " _
                        & " Set @MAC0 = '" & MenuUtama.mMAC0.Text.Trim & "' " _
                        & " Set @MAC1 = '" & MenuUtama.mMAC1.Text.Trim & "' " _
                        & " Set @IPAdress = '" & MenuUtama.mIPAdress.Text.Trim & "' " _
                        & " Set @MBId = '" & MenuUtama.mMotherBoardID.Text.Trim & "' " _
                        & " Set @ProcId = '" & MenuUtama.mProcessorID.Text.Trim & "' " _
                        & " Set @Tanggal = '" & str_TanggalServer_DMY() & "' "

        Dim Insert_Data As String = " " _
                        & " insert into aPar_UserID " _
                        & " (UserID,Nama,Jenis_Kelamin,Kd_Level,UserID_Induk,Pwd,Keterangan,UserID_Entry,komputer,MAC0,MAC1,IPAdress,MBId,ProcId,Tanggal) values " _
                        & " (@UserID,@Nama,@Jenis_Kelamin,@Kd_Level,@UserID_Induk,@Pwd,@Keterangan,@UserID_Entry,@komputer,@MAC0,@MAC1,@IPAdress,@MBId,@ProcId,@Tanggal) "
        Dim Update_Data As String = " " _
            & " Update aPar_UserID Set " _
            & " UserID = @UserID, " _
            & " Nama   = @Nama, " _
            & " Jenis_Kelamin= @Jenis_Kelamin, " _
            & " Kd_Level= @Kd_Level, " _
            & " UserID_Induk= @UserID_Induk, " _
            & " Pwd= @Pwd, " _
            & " Keterangan= @Keterangan, " _
            & " UserID_Entry= @UserID_Entry, " _
            & " komputer= @komputer, " _
            & " MAC0= @MAC0, " _
            & " MAC1= @MAC1, " _
            & " IPAdress= @IPAdress, " _
            & " MBId= @MBId, " _
            & " ProcId= @ProcId, " _
            & " Tanggal= @Tanggal " _
            & " " _
            & " Where UserID = @UserID "

        Dim Nilai_Histori As String = "0"
        If Cari = "Y" Then
            Nilai_Histori = "1"
            Rs_Simpan.Open(DeKlare_Data & Update_Data, cn_eSumsel)
        Else
            Rs_Simpan.Open(DeKlare_Data & Insert_Data, cn_eSumsel)
        End If
        Close_eSumsel()
        tampil_iduser()

        '==========================log belu
        yyHis_aPar_UserID(Nilai_Histori) '0 = Inset,1=Update,2=Hapus
        '==========================
        MsgBox("Data telah disimpan.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Informasi")
    End Sub
    Sub yyHis_aPar_UserID(ByVal NilaiAktv As String)
        'Aktivitas 1=Simpan, 2 = Hapus
        If Open_eSumsel() = False Then Exit Sub


        Dim DeKlare_Data As String = " set dateformat DMY " _
                        & " Declare @UserID char(20)  " _
                        & " Declare @Nama char(50) " _
                        & " Declare @Jenis_Kelamin char(10) " _
                        & " Declare @Kd_Level char(1) " _
                        & " Declare @UserID_Induk char(155) " _
                        & " Declare @Pwd char(155) " _
                        & " Declare @Keterangan varchar(MAX) " _
                        & " Declare @IDGroup char(155) " _
                        & " Declare @UserID_Entry char(20) " _
                        & " Declare @komputer char(100) " _
                        & " Declare @MAC0 char(20) " _
                        & " Declare @MAC1 char(20) " _
                        & " Declare @IPAdress char(20) " _
                        & " Declare @MBId char(20) " _
                        & " Declare @ProcId char(20) " _
                        & " Declare @Tanggal datetime " _
                        & " " _
                        & " Set @UserID = '" & mUserID.Text & "' " _
                        & " Set @Nama = '" & mNama.Text.Trim & "' " _
                        & " Set @Jenis_Kelamin = '" & mKelamin.Text.Trim & "' " _
                        & " Set @Kd_Level = '" & UbahPswKeAsci(Mid(mKd_Level.Text.Trim, 1, 1), mUserID.Text) & "' " _
                        & " Set @UserID_Induk = '" & mUserID_Induk.Text.Trim & "' " _
                        & " Set @Pwd = '" & SimpanPWD(mPWD1.Text, mUserID.Text) & "' " _
                        & " Set @Keterangan = '" & mKeterangan.Text.Trim & "' " _
                        & " Set @UserID_Entry = '" & MenuUtama.mUserID.Text.Trim & "' " _
                        & " Set @komputer = '" & Environment.MachineName.Trim & "' " _
                        & " Set @MAC0 = '" & MenuUtama.mMAC0.Text.Trim & "' " _
                        & " Set @MAC1 = '" & MenuUtama.mMAC1.Text.Trim & "' " _
                        & " Set @IPAdress = '" & MenuUtama.mIPAdress.Text.Trim & "' " _
                        & " Set @MBId = '" & MenuUtama.mMotherBoardID.Text.Trim & "' " _
                        & " Set @ProcId = '" & MenuUtama.mProcessorID.Text.Trim & "' " _
                        & " Set @Tanggal = '" & str_TanggalServer_DMY() & "' "

        Dim Insert_Data As String = " " _
                        & " insert into yyHis_aPar_UserID " _
                        & " (UserID_Login,Aktivitas,UserID,Nama,Jenis_Kelamin,Kd_Level,UserID_Induk,Pwd,Keterangan,UserID_Entry,komputer,MAC0,MAC1,IPAdress,MBId,ProcId,Tanggal) values " _
                        & " ('" & MenuUtama.mUserID.Text.Trim & "','" & Mid(NilaiAktv.Trim, 1, 1) & "',@UserID,@Nama,@Jenis_Kelamin,@Kd_Level,@UserID_Induk,@Pwd,@Keterangan,@UserID_Entry,@komputer,@MAC0,@MAC1,@IPAdress,@MBId,@ProcId,@Tanggal) "


        Rs_Simpan.Open(DeKlare_Data & Insert_Data, cn_eSumsel)

        Close_eSumsel()
    End Sub
    Sub tampil_iduser()
        Dim mmkondisi As String = ""
        If MenuUtama.mUserID.Text.Trim.ToUpper = "ADMIN" Then
            If mcari.Text.Trim = "" Then
                mmkondisi = " "
            Else
                mmkondisi = " where " _
                & " (UserID like '%" & mcari.Text.Trim & "%' or " _
                & " Nama like '%" & mcari.Text.Trim & "%' or " _
                & " UserID_Induk like '%" & mcari.Text.Trim & "%' or " _
                & " Keterangan like '%" & mcari.Text.Trim & "%' or " _
                & " Jenis_Kelamin like '%" & mcari.Text.Trim & "%')  "
            End If
        Else
            If mcari.Text.Trim = "" Then
                mmkondisi = " where " _
                & " UserID_Induk = '" & MenuUtama.mUserID.Text.Trim & "' "
            Else
                mmkondisi = " where " _
                & " (UserID like '%" & mcari.Text.Trim & "%' or " _
                & " Nama like '%" & mcari.Text.Trim & "%' or " _
                & " UserID_Induk like '%" & mcari.Text.Trim & "%' or " _
                & " Keterangan like '%" & mcari.Text.Trim & "%' or " _
                & " Jenis_Kelamin like '%" & mcari.Text.Trim & "%')  and " _
                & " UserID_Induk = '" & MenuUtama.mUserID.Text.Trim & "' "
            End If

        End If
        If Open_eSumsel_Tampil() = False Then Exit Sub

        Dim sql_Text_Comman As String = "SELECT " _
                                    & " UserID AS [id user], " _
                                    & " nama, " _
                                    & " UserID_Induk  as [User Induk], " _
                                    & " Keterangan " _
                                    & " FROM aPar_UserID " & mmkondisi _
                                    & " ORDER By UserID "
        Dim Tampil_data As New SqlCommand(sql_Text_Comman, cn_eSumsel_Tmpl)
        Tampil_data.CommandType = CommandType.Text

        Dim OleDA_Tampil As New SqlDataAdapter(Tampil_data)

        Dim ODS_Tampil As New DataSet
        OleDA_Tampil.Fill(ODS_Tampil, "a_user")
        Dim ODV_Tampil As New DataView(ODS_Tampil.Tables("a_user"))
        dg_User.DataSource = ODV_Tampil
        ODS_Tampil.Dispose()
        OleDA_Tampil.Dispose()

        Close_eSumsel_Tampil()

        dg_User.Columns(0).Width = (dg_User.Width / 10) * 1.8
        dg_User.Columns(1).Width = (dg_User.Width / 10) * 2.5
        dg_User.Columns(2).Width = (dg_User.Width / 10) * 1.8
        dg_User.Columns(3).Width = (dg_User.Width / 10) * 3.7
        'dg_User.Columns(4).Width = (dg_User.Width / 10) * 1.7
        'dg_User.Columns(5).Width = (dg_User.Width / 10) * 1
        'dg_User.Columns(6).Width = (dg_User.Width / 10) * 3.5
    End Sub

    Private Sub mcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mcari.TextChanged
        tampil_iduser()
    End Sub

    Private Sub tblHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblHapus.Click
        Dim Pesan = MsgBox("Yakin User ID " & mUserID.Text.Trim & " ini akan di Hapus [Y/T] ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Informasi")
        If Pesan = MsgBoxResult.Yes Then
            If Open_eSumsel() = False Then Exit Sub
            Dim Cari As String = "T"
            Rs_Simpan.Open("Select UserID from aPar_UserID  where UserID = '" & mUserID.Text & "' ", cn_eSumsel)
            If Rs_Simpan.RecordCount > 0 Then
                Cari = "Y"
            End If
            Rs_Simpan.Close()
            If Cari = "Y" Then
                '==cek ke tabel belum selsesai...
                Rs_Simpan.Open("Delete from aPar_UserID  where UserID = '" & mUserID.Text & "' ", cn_eSumsel)
                Rs_Simpan.Open("Delete from aPar_UserID_OPD  where UserID = '" & mUserID.Text & "' ", cn_eSumsel)
            End If
            Close_eSumsel()

            'Hapus yang berhubungan dengan user id ini

            '==========================
            yyHis_aPar_UserID("2") '0 = Inset,1=Update,2=Hapus
                '==========================
                tampil_iduser()
                tblBaru_Click(tblBaru, New EventArgs)
                MsgBox("User ID " & mUserID.Text.Trim & " telah dihapus.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Informasi")
            End If

    End Sub


    Private Sub tbCari01_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbCari01.MouseLeave
        tbCari01.Width = 23
        tbCari01.Height = 20
    End Sub

    Private Sub tbCari01_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbCari01.MouseMove
        tbCari01.Width = 50
        tbCari01.Height = 50
    End Sub
    Private Sub tblaturaaksesSKPD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblaturaaksesSKPD.Click
        If mUserID.Text.Trim = "" Then
            MsgBox("User id tidak boleh kosong...", MsgBoxStyle.OkCancel + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If

        f_UserManagement_AturSKPD.mUserID.Text = mUserID.Text
        f_UserManagement_AturSKPD.mNama.Text = mNama.Text
        f_UserManagement_AturSKPD.ShowDialog(Me)
    End Sub
    Private Sub dg_User_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg_User.DoubleClick
        mUserID.Text = dg_User.Item(0, dg_User.CurrentRow.Index).Value.ToString.Trim
        mIDUser_LostFocus(mUserID, New EventArgs)
    End Sub

    Private Sub dg_User_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_User.CellContentClick

    End Sub

    Private Sub mNama_TextChanged(sender As Object, e As EventArgs) Handles mNama.TextChanged

    End Sub
End Class