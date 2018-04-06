Imports System.Text
Imports System.IO
Imports System.Data.SqlClient
Public Class cPar_RekAPBD_1
    Private Sub tbl_Keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbl_Keluar.Click
        Me.Close()
    End Sub

    Private Sub tblBaru_Click(sender As Object, e As EventArgs) Handles tblBaru.Click
        mRek_Pos.Text = ""
        mNama_Rek_Pos.Text = ""
        mRek_Pos.Focus()
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


        If Open_eSumsel() = False Then Exit Sub
        Dim Cari As String = "T"
        Rs_Simpan.Open("Select Rek_Pos from cPar_RekAPBD_1  where Rek_Pos = '" & mRek_Pos.Text & "' ", cn_eSumsel)
        If Rs_Simpan.RecordCount > 0 Then
            Cari = "Y"
        End If
        Rs_Simpan.Close()



        Dim DeKlare_Data As String = " set dateformat DMY " _
                        & " Declare @Rek_Pos char(1)  " _
                        & " Declare @Nama_Rek_Pos char(100) " _
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
                        & " Set @Nama_Rek_Pos = '" & mNama_Rek_Pos.Text.Trim & "' " _
                        & " Set @komputer = '" & Environment.MachineName.Trim & "' " _
                        & " Set @MAC0 = '" & MenuUtama.mMAC0.Text.Trim & "' " _
                        & " Set @MAC1 = '" & MenuUtama.mMAC1.Text.Trim & "' " _
                        & " Set @IPAdress = '" & MenuUtama.mIPAdress.Text.Trim & "' " _
                        & " Set @MBId = '" & MenuUtama.mMotherBoardID.Text.Trim & "' " _
                        & " Set @ProcId = '" & MenuUtama.mProcessorID.Text.Trim & "' " _
                        & " Set @Tanggal = '" & str_TanggalServer_DMY() & "' "

        Dim Insert_Data As String = " " _
                        & " insert into cPar_RekAPBD_1 " _
                        & " (Rek_Pos,Nama_Rek_Pos,UserID_Entry,komputer,MAC0,MAC1,IPAdress,MBId,ProcId,Tanggal) values " _
                        & " (@Rek_Pos,@Nama_Rek_Pos,@UserID_Entry,@komputer,@MAC0,@MAC1,@IPAdress,@MBId,@ProcId,@Tanggal) "

        Dim Update_Data As String = " " _
            & " Update cPar_RekAPBD_1 Set " _
            & " Rek_Pos = @Rek_Pos, " _
            & " Nama_Rek_Pos   = @Nama_Rek_Pos, " _
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
    Sub tampil_Data()

        If Open_eSumsel_Tampil() = False Then Exit Sub

        Dim sql_Text_Comman As String = "SELECT " _
                                    & " Rek_Pos AS [Kode Rekening], " _
                                    & " Nama_Rek_Pos From cPar_RekAPBD_1 " _
                                    & " ORDER By Rek_Pos "
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

    End Sub

    Private Sub cPar_RekAPBD_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tblBaru_Click(tblBaru, New EventArgs)
        tampil_Data()
    End Sub

    Private Sub mRek_Pos_LostFocus(sender As Object, e As EventArgs) Handles mRek_Pos.LostFocus
        If Open_eSumsel() = False Then Exit Sub
        Rs_Baca.Open("Select Nama_Rek_Pos from cPar_RekAPBD_1  where Rek_Pos = '" & mRek_Pos.Text & "' ", cn_eSumsel)
        If Rs_Baca.RecordCount > 0 Then
            mNama_Rek_Pos.Text = Rs_Baca.Fields("Nama_Rek_Pos").Value.ToString.Trim
        End If
        Rs_Baca.Close()
        Close_eSumsel()

    End Sub

    Private Sub tblHapus_Click(sender As Object, e As EventArgs) Handles tblHapus.Click
        Dim Pesan = MsgBox("Yakin Rekening " & mNama_Rek_Pos.Text.Trim & " ini akan di Hapus [Y/T] ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Informasi")
        If Pesan = MsgBoxResult.Yes Then
            If Open_eSumsel() = False Then Exit Sub
            Dim Cari As String = "T"
            Rs_Simpan.Open("Select Rek_Pos from cPar_RekAPBD_1  where Rek_Pos = '" & mRek_Pos.Text & "' ", cn_eSumsel)
            If Rs_Simpan.RecordCount > 0 Then
                Cari = "Y"
            End If
            Rs_Simpan.Close()
            If Cari = "Y" Then
                '==cek ke tabel belum selsesai...
                Rs_Simpan.Open("Delete    from cPar_RekAPBD_1  where Rek_Pos = '" & mRek_Pos.Text & "' ", cn_eSumsel)

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

    Private Sub dg_TampilData_DoubleClick(sender As Object, e As EventArgs) Handles dg_TampilData.DoubleClick
        mRek_Pos.Text = dg_TampilData.Item(0, dg_TampilData.CurrentRow.Index).Value.ToString.Trim
        mNama_Rek_Pos.Text = dg_TampilData.Item(1, dg_TampilData.CurrentRow.Index).Value.ToString.Trim
    End Sub
End Class