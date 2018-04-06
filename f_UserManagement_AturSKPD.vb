Imports System.Text
Imports System.IO
Imports System.Data.SqlClient
Public Class f_UserManagement_AturSKPD
    Private Sub tblKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblKeluar.Click
        Me.Close()
    End Sub
    Private Sub f_UserManagement_AturSKPD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil_SKPDUser()
    End Sub
    Sub tampil_SKPDUser()
        If Open_eSumsel() = False Then Exit Sub
        Dim sql_Perintah As String = "  SELECT      " _
            & " aPar_UserID_OPD.Kode_Urusan + '.' +  " _
            & " aPar_UserID_OPD.Kode_Bidang + '.' +   " _
            & " aPar_UserID_OPD.Kode_OPD + '.' +   " _
            & " aPar_UserID_OPD.Kode_Sub_OPD + '.' +   " _
            & " aPar_UserID_OPD.Kode_Sub_Sub_OPD as [Kode OPD],  " _
            & " cPar_OPD_5Sub_Sub_OPD.Nama_Sub_Sub_OPD as [Nama OPD] " _
            & " FROM         aPar_UserID_OPD LEFT OUTER JOIN cPar_OPD_5Sub_Sub_OPD ON  " _
            & " aPar_UserID_OPD.Kode_Urusan         = cPar_OPD_5Sub_Sub_OPD.Kode_Urusan AND  " _
            & " aPar_UserID_OPD.Kode_Bidang         = cPar_OPD_5Sub_Sub_OPD.Kode_Bidang AND  " _
            & " aPar_UserID_OPD.Kode_OPD            = cPar_OPD_5Sub_Sub_OPD.Kode_OPD AND  " _
            & " aPar_UserID_OPD.Kode_Sub_OPD        = cPar_OPD_5Sub_Sub_OPD.Kode_Sub_OPD AND  " _
            & " aPar_UserID_OPD.Kode_Sub_Sub_OPD    = cPar_OPD_5Sub_Sub_OPD.Kode_Sub_Sub_OPD " _
            & " where  aPar_UserID_OPD.UserID       = '" & mUserID.Text.Trim & "' "
         

        Dim Tampil_data As New SqlCommand(sql_Perintah, cn_eSumsel_Tmpl)
        Tampil_data.CommandType = CommandType.Text

        Dim OleDA_Tampil As New SqlDataAdapter(Tampil_data)

        Dim ODS_Tampil As New DataSet
        OleDA_Tampil.Fill(ODS_Tampil, "a_user")
        Dim ODV_Tampil As New DataView(ODS_Tampil.Tables("a_user"))
        dg_User.DataSource = ODV_Tampil
        ODS_Tampil.Dispose()
        OleDA_Tampil.Dispose()
         Close_eSumsel_Tampil()

        dg_User.Columns(0).Width = (dg_User.Width / 10) * 1
        dg_User.Columns(1).Width = (dg_User.Width / 10) * 1.4
        dg_User.Columns(2).Width = (dg_User.Width / 10) * 7.4
        For x = 0 To dg_User.RowCount - 1
            dg_User.Item(0, x).Value = "hapus"
        Next
        dg_User.Columns(0).DefaultCellStyle.ForeColor = Color.Red

    End Sub

    Private Sub dg_User_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_User.CellClick
        If e.ColumnIndex = 0 Then
            Dim Pesan = MsgBox("Yakin akan menghapus Kode OPD " & dg_User.Item(1, e.RowIndex).Value.ToString.Trim & " untuk User ini....", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Informasi")
            If Pesan = MsgBoxResult.Yes Then
                If Open_eSumsel() = False Then Exit Sub
                Rs_Baca.Open("Delete from aPar_UserID_OPD where " _
                        & " UserID	        = '" & mUserID.Text.Trim & "' and " _
                        & " Kode_Urusan	    = '" & Mid(dg_User.Item(1, e.RowIndex).Value.ToString.Trim, 1, 1) & "' and " _
                        & " Kode_Bidang	    = '" & Mid(dg_User.Item(1, e.RowIndex).Value.ToString.Trim, 3, 2) & "' and " _
                        & " Kode_OPD	    = '" & Mid(dg_User.Item(1, e.RowIndex).Value.ToString.Trim, 6, 2) & "' and " _
                        & " Kode_Sub_OPD	= '" & Mid(dg_User.Item(1, e.RowIndex).Value.ToString.Trim, 9, 2) & "' and " _
                        & " Kode_Sub_Sub_OPD= '" & Mid(dg_User.Item(1, e.RowIndex).Value.ToString.Trim, 12, 3) & "' ", cn_eSumsel)
                Close_eSumsel()
                '0= Insert , 1= Update, 2=Hapus
                yyHis_aPar_UserID_OPD("2", mUserID.Text.Trim, Mid(dg_User.Item(1, e.RowIndex).Value.ToString.Trim, 1, 1), _
                          Mid(dg_User.Item(1, e.RowIndex).Value.ToString.Trim, 3, 2), _
                          Mid(dg_User.Item(1, e.RowIndex).Value.ToString.Trim, 6, 2), _
                          Mid(dg_User.Item(1, e.RowIndex).Value.ToString.Trim, 9, 2), _
                          Mid(dg_User.Item(1, e.RowIndex).Value.ToString.Trim, 12, 3))
                tampil_SKPDUser()
            End If

        End If
    End Sub
    Private Sub dg_User_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dg_User.KeyDown
        If e.KeyCode = 46 Then
            '0.00.00.0000
            '1234567890
            If dg_User.RowCount = 0 Then Exit Sub
            'Rs_Baca.Open("delete from aSKPD_User where " _
            '         & " kodepd ='" & Mid(dg_User.Item(0, dg_User.CurrentRow.Index).Value.ToString.Trim, 1, 1) & "' and " _
            '         & " kodeurusanpd='" & Mid(dg_User.Item(0, dg_User.CurrentRow.Index).Value.ToString.Trim, 3, 2) & "' and " _
            '         & " kodeskpd ='" & Mid(dg_User.Item(0, dg_User.CurrentRow.Index).Value.ToString.Trim, 6, 2) & "' and " _
            '         & " kodeSUBskpd ='" & Mid(dg_User.Item(0, dg_User.CurrentRow.Index).Value.ToString.Trim, 9, 4) & "'", cn_SPPD)
            'tampil_SKPDUser()
        End If
    End Sub
    Private Sub Tbl_CariSKPD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_CariSKPD.Click
        view_DaftarSubOPD.mKodeKelompokPilih.Text = "f_UserManagement_AturSKPD"
        view_DaftarSubOPD.mKodePanggil.Text = "f_UserManagement_AturSKPD"
        'view_DaftarSubOPD.Tampil_SKPD("SUBSKPD", 0)
        view_DaftarSubOPD.ShowDialog(Me)
    End Sub

    Private Sub tbl_Gunakan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbl_Gunakan.Click
        If mKode_Urusan.Text.Trim = "" Or mNama_Sub_Sub_OPD.Text.Trim = "" Then
            MsgBox("skpd harus diisi...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "informasi")
            Exit Sub
        End If
        Dim cari As String = "T"
        'cek keberadaan User ID di tabel User
        If Open_eSumsel() = False Then Exit Sub
        Rs_Baca.Open("select UserID from aPar_UserID where " _
        & " UserID	        = '" & mUserID.Text.Trim & "'  ", cn_eSumsel)
        If Rs_Baca.RecordCount > 0 Then cari = "Y"
        Rs_Baca.Close()

        If cari = "T" Then
            MsgBox("User ID Belum tersimpan di database,... simpan dulu User ID, sebelum setting OPD untuk User ini....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If

        cari = "T"
        Rs_Baca.Open("select UserID from aPar_UserID_OPD where " _
                    & " UserID	        = '" & mUserID.Text.Trim & "' and " _
                    & " Kode_Urusan	    = '" & mKode_Urusan.Text.Trim & "' and " _
                    & " Kode_Bidang	    = '" & mKode_Bidang.Text.Trim & "' and " _
                    & " Kode_OPD	    = '" & mKode_OPD.Text.Trim & "' and " _
                    & " Kode_Sub_OPD	= '" & mKode_Sub_OPD.Text.Trim & "' and " _
                    & " Kode_Sub_Sub_OPD= '" & mKode_Sub_Sub_OPD.Text.Trim & "' ", cn_eSumsel)
        If Rs_Baca.RecordCount > 0 Then cari = "Y"
        Rs_Baca.Close()

        Dim DeKlare_Data As String = " set dateformat DMY " _
                    & " Declare @UserID char(20)" _
                    & " Declare @Kode_Urusan char(1)" _
                    & " Declare @Kode_Bidang char(2)" _
                    & " Declare @Kode_OPD char(2)" _
                    & " Declare @Kode_Sub_OPD char(2)" _
                    & " Declare @Kode_Sub_Sub_OPD char(3)" _
                    & " Declare @komputer char(100)" _
                    & " Declare @MAC0 char(20)" _
                    & " Declare @MAC1 char(20)" _
                    & " Declare @IPAdress char(20)" _
                    & " Declare @MBId char(20)" _
                    & " Declare @ProcId char(20)" _
                    & " Declare @Tanggal  datetime " _
                    & " " _
                    & " Set @UserID= '" & mUserID.Text.Trim & "' " _
                    & " Set @Kode_Urusan= '" & mKode_Urusan.Text.Trim & "' " _
                    & " Set @Kode_Bidang= '" & mKode_Bidang.Text.Trim & "' " _
                    & " Set @Kode_OPD= '" & mKode_OPD.Text.Trim & "' " _
                    & " Set @Kode_Sub_OPD= '" & mKode_Sub_OPD.Text.Trim & "' " _
                    & " Set @Kode_Sub_Sub_OPD= '" & mKode_Sub_Sub_OPD.Text.Trim & "' " _
                    & " Set @komputer= '" & Environment.MachineName.Trim & "' " _
                    & " Set @MAC0= '" & MenuUtama.mMAC0.Text.Trim & "' " _
                    & " Set @MAC1= '" & MenuUtama.mMAC1.Text.Trim & "' " _
                    & " Set @IPAdress= '" & MenuUtama.mIPAdress.Text.Trim & "' " _
                    & " Set @MBId= '" & MenuUtama.mMotherBoardID.Text.Trim & "' " _
                    & " Set @ProcId= '" & MenuUtama.mProcessorID.Text.Trim & "' " _
                    & " Set @Tanggal= '" & str_TanggalServer_DMY() & "' "

        Dim Insert_Data As String = " " _
                    & " Insert Into aPar_UserID_OPD " _
                    & " (UserID,Kode_Urusan,Kode_Bidang,Kode_OPD,Kode_Sub_OPD,Kode_Sub_Sub_OPD,komputer,MAC0,MAC1,IPAdress,MBId,ProcId,Tanggal) Values " _
                    & " (@UserID,@Kode_Urusan,@Kode_Bidang,@Kode_OPD,@Kode_Sub_OPD,@Kode_Sub_Sub_OPD,@komputer,@MAC0,@MAC1,@IPAdress,@MBId,@ProcId,@Tanggal) "
        Dim Update_Data As String = " " _
                    & " Update aPar_UserID_OPD Set " _
                    & " UserID= @UserID," _
                    & " Kode_Urusan= @Kode_Urusan," _
                    & " Kode_Bidang= @Kode_Bidang," _
                    & " Kode_OPD= @Kode_OPD," _
                    & " Kode_Sub_OPD= @Kode_Sub_OPD," _
                    & " Kode_Sub_Sub_OPD= @Kode_Sub_Sub_OPD," _
                    & " komputer= @komputer," _
                    & " MAC0= @MAC0," _
                    & " MAC1= @MAC1," _
                    & " IPAdress= @IPAdress," _
                    & " MBId= @MBId," _
                    & " ProcId= @ProcId," _
                    & " Tanggal= @Tanggal"

        If cari = "Y" Then
            Rs_Simpan.Open(DeKlare_Data & Update_Data, cn_eSumsel)
        Else
            Rs_Simpan.Open(DeKlare_Data & Insert_Data, cn_eSumsel)
        End If
        Close_eSumsel()

        '===Histori hanya disimpan pada saat insert data saja, 
        'sedang update tidak disimpan, Karena tidak ada data yg diubah... 
        If cari <> "Y" Then
            '0= Insert , 1= Update, 2=Hapus
            yyHis_aPar_UserID_OPD("0", mUserID.Text.Trim, _
                        mKode_Urusan.Text, _
                        mKode_Bidang.Text, _
                        mKode_OPD.Text, _
                        mKode_Sub_OPD.Text, _
                        mKode_Sub_Sub_OPD.Text)

        End If

        tampil_SKPDUser()
        mKode_Urusan.Text = ""
        mKode_Bidang.Text = ""
        mKode_OPD.Text = ""
        mKode_Sub_OPD.Text = ""
        mKode_Sub_Sub_OPD.Text = ""
        mNama_Sub_Sub_OPD.Text = ""


    End Sub
    Sub yyHis_aPar_UserID_OPD(ByVal Nilai_his As String, _
                              ByVal mmUid_data As String, _
                                ByVal mmKode_Urusan As String, _
                                ByVal mmKode_Bidang As String, _
                                ByVal mmKode_OPD As String, _
                                ByVal mmKode_Sub_OPD As String, _
                                ByVal mmKode_Sub_Sub_OPD As String)

        If Open_eSumsel() = False Then Exit Sub
        Dim DeKlare_Data As String = " set dateformat DMY " _
                   & " Declare @UserID char(20)" _
                   & " Declare @Kode_Urusan char(1)" _
                   & " Declare @Kode_Bidang char(2)" _
                   & " Declare @Kode_OPD char(2)" _
                   & " Declare @Kode_Sub_OPD char(2)" _
                   & " Declare @Kode_Sub_Sub_OPD char(3)" _
                   & " Declare @komputer char(100)" _
                   & " Declare @MAC0 char(20)" _
                   & " Declare @MAC1 char(20)" _
                   & " Declare @IPAdress char(20)" _
                   & " Declare @MBId char(20)" _
                   & " Declare @ProcId char(20)" _
                   & " Declare @Tanggal  datetime " _
                   & " " _
                   & " Set @UserID= '" & mmUid_data & "' " _
                   & " Set @Kode_Urusan= '" & mmKode_Urusan & "' " _
                   & " Set @Kode_Bidang= '" & mmKode_Bidang & "' " _
                   & " Set @Kode_OPD= '" & mmKode_OPD & "' " _
                   & " Set @Kode_Sub_OPD= '" & mmKode_Sub_OPD & "' " _
                   & " Set @Kode_Sub_Sub_OPD= '" & mmKode_Sub_Sub_OPD & "' " _
                   & " Set @komputer= '" & Environment.MachineName.Trim & "' " _
                   & " Set @MAC0= '" & MenuUtama.mMAC0.Text.Trim & "' " _
                   & " Set @MAC1= '" & MenuUtama.mMAC1.Text.Trim & "' " _
                   & " Set @IPAdress= '" & MenuUtama.mIPAdress.Text.Trim & "' " _
                   & " Set @MBId= '" & MenuUtama.mMotherBoardID.Text.Trim & "' " _
                   & " Set @ProcId= '" & MenuUtama.mProcessorID.Text.Trim & "' " _
                   & " Set @Tanggal= '" & str_TanggalServer_DMY() & "' "

        Dim Insert_Data As String = " " _
                    & " Insert Into yyHis_aPar_UserID_OPD " _
                    & " (Aktipitas,UserID_Login,UserID,Kode_Urusan,Kode_Bidang,Kode_OPD,Kode_Sub_OPD,Kode_Sub_Sub_OPD,komputer,MAC0,MAC1,IPAdress,MBId,ProcId,Tanggal) Values " _
                    & " ('" & Nilai_his & "','" & MenuUtama.mUserID.Text.Trim & "',@UserID,@Kode_Urusan,@Kode_Bidang,@Kode_OPD,@Kode_Sub_OPD,@Kode_Sub_Sub_OPD,@komputer,@MAC0,@MAC1,@IPAdress,@MBId,@ProcId,@Tanggal) "


        Rs_Simpan.Open(DeKlare_Data & Insert_Data, cn_eSumsel)

        Close_eSumsel()
    End Sub
    Private Sub dg_User_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg_User.CellContentClick

    End Sub
End Class