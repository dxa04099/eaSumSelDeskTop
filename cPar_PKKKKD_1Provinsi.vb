Imports System.Text
Imports System.IO
Imports System.Data.SqlClient
Public Class cPar_PKKKKD_1Provinsi

    Private Sub tbl_Keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbl_Keluar.Click
        Me.Close()
    End Sub

    Private Sub tblBaru_Click(sender As Object, e As EventArgs) Handles tblBaru.Click
        mKode_Provinsi.Text = ""
        mNama_Provinsi.Text = ""
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

        If Open_eSumsel() = False Then Exit Sub
        Dim Cari As String = "T"
        Rs_Simpan.Open("Select Kode_Provinsi from cPar_PKKKKD_1Provinsi  where Kode_Provinsi = '" & mKode_Provinsi.Text & "' ", cn_eSumsel)
        If Rs_Simpan.RecordCount > 0 Then
            Cari = "Y"
        End If
        Rs_Simpan.Close()

        Dim DeKlare_Data As String = " set dateformat DMY " _
                        & " Declare @Kode_Provinsi char(2)  " _
                        & " Declare @Nama_Provinsi char(20)  " _
                        & " Declare @MAC0 char(20) " _
                        & " Declare @MAC1 char(20) " _
                        & " Declare @IPAdress char(20) " _
                        & " Declare @MBId char(20) " _
                        & " Declare @ProcId char(20) " _
                        & " Declare @Tanggal datetime " _
                        & " Declare @komputer char(100) " _
                        & " " _
                        & " Set @Kode_Provinsi = '" & mKode_Provinsi.Text & "' " _
                        & " Set @Nama_Provinsi = '" & mNama_Provinsi.Text.Trim & "' " _
                        & " Set @MAC0 = '" & MenuUtama.mMAC0.Text.Trim & "' " _
                        & " Set @MAC1 = '" & MenuUtama.mMAC1.Text.Trim & "' " _
                        & " Set @IPAdress = '" & MenuUtama.mIPAdress.Text.Trim & "' " _
                        & " Set @MBId = '" & MenuUtama.mMotherBoardID.Text.Trim & "' " _
                        & " Set @ProcId = '" & MenuUtama.mProcessorID.Text.Trim & "' " _
                        & " Set @Tanggal = '" & str_TanggalServer_DMY() & "' " _
                        & " Set @komputer = '" & Environment.MachineName.Trim & "' "

        Dim Insert_Data As String = " " _
                        & " insert into cPar_PKKKKD_1Provinsi " _
                        & " (Kode_Provinsi,Nama_Provinsi,komputer,MAC0,MAC1,IPAdress,MBId,ProcId,Tanggal) values " _
                        & " (@Kode_Provinsi,@Nama_Provinsi,@komputer,@MAC0,@MAC1,@IPAdress,@MBId,@ProcId,@Tanggal) "

        Dim Update_Data As String = " " _
           & " Update cPar_PKKKKD_1Provinsi Set " _
           & " Kode_Provinsi = @Kode_Provinsi, " _
           & " Nama_Provinsi   = @Nama_Provinsi, " _
           & " MAC0= @MAC0, " _
           & " MAC1= @MAC1, " _
           & " IPAdress= @IPAdress, " _
           & " MBId= @MBId, " _
           & " ProcId= @ProcId, " _
           & " Tanggal= @Tanggal, " _
           & " komputer= @komputer " _
           & " " _
           & " Where Kode_Provinsi = @Kode_Provinsi "

        Dim Nilai_Histori As String = "0"
        If Cari = "Y" Then
            Nilai_Histori = "1"
            Rs_Simpan.Open(DeKlare_Data & Update_Data, cn_eSumsel)
        Else
            Rs_Simpan.Open(DeKlare_Data & Insert_Data, cn_eSumsel)
        End If
        Close_eSumsel()
        tampil_provinsi()
        mKode_Provinsi.Text = ""
        mNama_Provinsi.Text = ""

        '==========================
        'yyHis_aPar_UserID(Nilai_Histori) '0 = Inset,1=Update,2=Hapus
        '==========================
        MsgBox("Data telah disimpan.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Informasi")


    End Sub

    Sub tampil_provinsi()
        If Open_eSumsel_Tampil() = False Then Exit Sub
        Dim sql_Text_Comman As String = "SELECT " _
                                    & " Kode_Provinsi AS [Kode Provinsi], " _
                                    & " Nama_Provinsi AS [Nama Provinsi] " _
                                    & " FROM cPar_PKKKKD_1Provinsi " _
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
    End Sub

    Sub tampil_provinsi_cari()
        If Open_eSumsel_Tampil() = False Then Exit Sub
        Dim sql_Text_Comman As String = "SELECT " _
                                    & " Kode_Provinsi AS [Kode Provinsi], " _
                                    & " Nama_Provinsi AS [Nama Provinsi] " _
                                    & " FROM cPar_PKKKKD_1Provinsi " _
                                    & " WHERE Nama_Provinsi like '%" & mcari.Text.Trim & "%' " _
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

        dg_TampilData.Columns(0).Width = dg_TampilData.Width / 5
        dg_TampilData.Columns(1).Width = dg_TampilData.Width - (dg_TampilData.Columns(0).Width + 50)
    End Sub

    Sub clearField()
        mKode_Provinsi.Text = ""
        mNama_Provinsi.Text = ""
    End Sub
    Private Sub cPar_PKKKKD_1Provinsi_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        tampil_provinsi()
    End Sub

    Private Sub tblHapus_Click(sender As Object, e As EventArgs) Handles tblHapus.Click

        If mKode_Provinsi.Text.Trim = "" Then
            MsgBox("Harap pilih provinsi yang akan dihapus...", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If
        If mNama_Provinsi.Text.Trim = "" Then
            MsgBox("Harap pilih provinsi yang akan dihapus...", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If

        Dim Pesan = MsgBox("Yakin provinsi " & mNama_Provinsi.Text.Trim & " ini akan di Hapus [Y/T] ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Informasi")
        If Pesan = MsgBoxResult.Yes Then
            If Open_eSumsel() = False Then Exit Sub
            Rs_Simpan.Open("Delete from cPar_PKKKKD_1Provinsi  where Kode_Provinsi = '" & mKode_Provinsi.Text & "' ", cn_eSumsel)
            Close_eSumsel()

            'Hapus yang berhubungan dengan user id ini

            '==========================
            'yyHis_aPar_UserID("2") '0 = Inset,1=Update,2=Hapus
            '==========================
            tampil_provinsi()
            tblBaru_Click(tblBaru, New EventArgs)
            MsgBox("provinsi " & mNama_Provinsi.Text.Trim & " telah dihapus.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Informasi")
        End If
        mKode_Provinsi.Text = ""
        mNama_Provinsi.Text = ""
    End Sub

    Private Sub mcari_TextChanged(sender As Object, e As EventArgs) Handles mcari.TextChanged
        tampil_provinsi_cari()
    End Sub

    Private Sub mKode_Provinsi_Leave(sender As Object, e As EventArgs) Handles mKode_Provinsi.LostFocus

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

    Private Sub dg_TampilData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_TampilData.CellDoubleClick
        mKode_Provinsi.Text = dg_TampilData.Item(0, dg_TampilData.CurrentRow.Index).Value.ToString.Trim
        mNama_Provinsi.Text = dg_TampilData.Item(1, dg_TampilData.CurrentRow.Index).Value.ToString.Trim
    End Sub
End Class