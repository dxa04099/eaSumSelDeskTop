Imports System.Data.SqlClient
Public Class cPar_OPD_4Sub_OPD

    Private Sub tbl_Keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbl_Keluar.Click
        Me.Close()
    End Sub

    Private Sub tbCari01_Click(sender As Object, e As EventArgs) Handles tbCari01.Click
        view_cPar_OPD_3OPD.mKodePanggil.Text = "cPar_OPD_4Sub_OPD"
        view_cPar_OPD_3OPD.ShowDialog(Me)
    End Sub

    Public Sub mKode_Fungsi_getName()
        If mKode_Fungsi.Text.Trim.Length = 1 Then mKode_Fungsi.Text = "0" & mKode_Fungsi.Text.Trim
        If Open_eSumsel() = False Then Exit Sub

        Dim sql_Text_Comman As String = "SELECT " _
                                    & " Nama_Fungsi" _
                                    & " FROM bPar_OPD_Fungsi " _
                                    & " WHERE Kode_Fungsi = '" & mKode_Fungsi.Text.Trim & "' "
        Rs_Baca.Open(sql_Text_Comman, cn_eSumsel)

        If Rs_Baca.RecordCount > 0 Then
            mNama_Fungsi.Text = Rs_Baca.Fields("Nama_Fungsi").Value.ToString.Trim
        End If

        Rs_Baca.Close()
        Close_eSumsel()
    End Sub

    Private Sub tblSimpan_Click(sender As Object, e As EventArgs) Handles tblSimpan.Click
        If mKode_Sub_OPD.Text.Trim = "" Then
            MsgBox("Data tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If
        If mNama_Sub_OPD.Text.Trim = "" Then
            MsgBox("Datatidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If
        If ch_BLUD.Text.Trim = "" Or ch_Keu.Text.Trim = "" Or ch_Gaji_PNS.Text.Trim = "" Or ch_TPP.Text.Trim = "" Or ch_Gaji_Non_PNS.Text.Trim = "" Or ch_Perjadin.Text.Trim = "" Or ch_BOS.Text.Trim = "" Then
            MsgBox("Data tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If
        'If mKode_Dokumen.Text.Trim = "" Then
        'MsgBox("User Id Induk tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
        'Exit Sub
        'End If
        Dim ch_Jenisi As Integer
        If ch_Jenis.Checked = True Then
            ch_Jenisi = "1"
        Else
            ch_Jenisi = "0"
        End If
        Dim ch_BLUDi As Integer
        If ch_BLUD.Checked = True Then
            ch_BLUDi = "1"
        Else
            ch_BLUDi = "0"
        End If
        Dim ch_Keui As Integer
        If ch_Keu.Checked = True Then
            ch_Keui = "1"
        Else
            ch_Keui = "0"
        End If
        Dim ch_Gaji_PNSi As Integer
        If ch_Gaji_PNS.Checked = True Then
            ch_Gaji_PNSi = "1"
        Else
            ch_Gaji_PNSi = "0"
        End If
        Dim ch_TPPi As Integer
        If ch_TPP.Checked = True Then
            ch_TPPi = "1"
        Else
            ch_TPPi = "0"
        End If
        Dim ch_Gaji_Non_PNSi As Integer
        If ch_Gaji_Non_PNS.Checked = True Then
            ch_Gaji_Non_PNSi = "1"
        Else
            ch_Gaji_Non_PNSi = "0"
        End If
        Dim ch_Perjadini As Integer
        If ch_Perjadin.Checked = True Then
            ch_Perjadini = "1"
        Else
            ch_Perjadini = "0"
        End If
        Dim ch_BOSi As Integer
        If ch_BOS.Checked = True Then
            ch_BOSi = "1"
        Else
            ch_BOSi = "0"
        End If

        If Open_eSumsel() = False Then Exit Sub
        Dim Cari As String = "T"
        Rs_Simpan.Open("Select Kode_Urusan,Kode_Bidang,Kode_OPD,Kode_Sub_OPD from cPar_OPD_4Sub_OPD  where Kode_Urusan = '" & mKode_Urusan.Text & "'  And Kode_Bidang='" & mKode_Bidang.Text & "'  and Kode_OPD='" & mKode_OPD.Text & "' and Kode_Sub_OPD='" & mKode_Sub_OPD.Text & "'", cn_eSumsel)
        If Rs_Simpan.RecordCount > 0 Then
            MsgBox("Data Berhasil Diupdate..")

            Cari = "Y"
        End If
        Rs_Simpan.Close()

        Dim DeKlare_Data As String = " set dateformat DMY " _
        & " Declare @Kode_Urusan Char(1)" _
        & " Declare @Kode_Bidang Char(2)" _
        & " Declare @Kode_OPD    Char(2)" _
        & " Declare @Kode_Sub_OPD    Char(2)" _
        & " Declare @Nama_Sub_OPD    Char(100)" _
        & " Declare @Jenis   Char(1)" _
        & " Declare @Keu Char(1)" _
        & " Declare @Gaji_PNS    Char(1)" _
        & " Declare @TPP Char(1)" _
        & " Declare @Gaji_Non_PNS    Char(1)" _
        & " Declare @Perjadin    Char(1)" _
        & " Declare @Bos Char(1)" _
        & " Declare @BLUD    Char(1)" _
        & " Declare @Kode_Dokumen Char(100) " _
        & " Declare @MAC0    Char(20) " _
        & " Declare @MAC1    Char(20) " _
        & " Declare @IPAdress    Char(20) " _
        & " Declare @MBId    Char(20) " _
        & " Declare @ProcId  Char(20) " _
        & " Declare @Tanggal DateTime " _
        & " Declare @komputer    Char(100) " _
        & " " _
        & " Set @Kode_Urusan = '" & mKode_Urusan.Text & "' " _
        & " Set @Kode_Bidang = '" & mKode_Bidang.Text.Trim & "' " _
        & " Set @Kode_OPD = '" & mKode_OPD.Text.Trim & "' " _
        & " Set @Kode_Sub_OPD = '" & mKode_Sub_OPD.Text.Trim & "' " _
        & " Set @Nama_Sub_OPD = '" & mNama_Sub_OPD.Text.Trim & "' " _
        & " Set @Jenis = '" & ch_Jenisi & "' " _
        & " Set @Keu = '" & ch_Keui & "' " _
        & " Set @Gaji_PNS = '" & ch_Gaji_PNSi & "' " _
        & " Set @TPP = '" & ch_TPPi & "' " _
        & " Set @Gaji_Non_PNS = '" & ch_Gaji_Non_PNSi & "' " _
        & " Set @Perjadin = '" & ch_Perjadini & "' " _
        & " Set @Bos = '" & ch_BOSi & "' " _
        & " Set @BLUD = '" & ch_BLUDi & "' " _
        & " Set @Kode_Dokumen = '" & mKode_Dokumen.Text.Trim & "' " _
        & " Set @MAC0 = '" & MenuUtama.mMAC0.Text.Trim & "' " _
        & " Set @MAC1 = '" & MenuUtama.mMAC1.Text.Trim & "' " _
        & " Set @IPAdress = '" & MenuUtama.mIPAdress.Text.Trim & "' " _
        & " Set @MBId = '" & MenuUtama.mMotherBoardID.Text.Trim & "' " _
        & " Set @ProcId = '" & MenuUtama.mProcessorID.Text.Trim & "' " _
        & " Set @Tanggal = '" & str_TanggalServer_DMY() & "' " _
        & " Set @komputer = '" & Environment.MachineName.Trim & "' "

        Dim Insert_Data As String = " " _
                        & " insert into cPar_OPD_4Sub_OPD " _
                        & " (Kode_Urusan,Kode_Bidang,Kode_OPD,Kode_Sub_OPD,Nama_Sub_OPD,Jenis,Keu,Gaji_PNS,TPP,Gaji_Non_PNS,Perjadin,Bos,BLUD,Kode_Dokumen,MAC0,MAC1,IPAdress,MBId,ProcId,Tanggal,komputer) values " _
                        & " (@Kode_Urusan,@Kode_Bidang,@Kode_OPD,@Kode_Sub_OPD,@Nama_Sub_OPD,@Jenis,@Keu,@Gaji_PNS,@TPP,@Gaji_Non_PNS,@Perjadin,@Bos,@BLUD,@Kode_Dokumen,@MAC0,@MAC1,@IPAdress,@MBId,@ProcId,@Tanggal,@komputer) "
        Dim Update_Data As String = " " _
            & " Update cPar_OPD_4Sub_OPD Set " _
            & " @Kode_Urusan = @Kode_Urusan, " _
            & " @Kode_Bidang = @Kode_Bidang, " _
            & " @Kode_OPD = @Kode_OPD, " _
            & " @Kode_Sub_OPD = @Kode_Sub_OPD, " _
            & " @Nama_Sub_OPD = @Nama_Sub_OPD, " _
            & " @Jenis = @Jenis, " _
            & " @Keu = @Keu, " _
            & " @Gaji_PNS = @Gaji_PNS, " _
            & " @TPP = @TPP, " _
            & " @Gaji_Non_PNS = @Gaji_Non_PNS, " _
            & " @Perjadin = @Perjadin, " _
            & " @Bos = @Bos, " _
            & " @BLUD = @BLUD, " _
            & " Kode_Dokumen= @Kode_Dokumen, " _
            & " komputer= @komputer, " _
            & " MAC0= @MAC0, " _
            & " MAC1= @MAC1, " _
            & " IPAdress= @IPAdress, " _
            & " MBId= @MBId, " _
            & " ProcId= @ProcId, " _
            & " Tanggal= @Tanggal " _
            & " " _
            & " Where Kode_Urusan = @Kode_Urusan and Kode_Bidang=@Kode_Bidang and Kode_OPD=@Kode_OPD and Kode_Sub_OPD=@Kode_Sub_OPD   "

        Dim Nilai_Histori As String = "0"
        If Cari = "Y" Then
            Nilai_Histori = "1"
            Rs_Simpan.Open(DeKlare_Data & Update_Data, cn_eSumsel)
        Else
            Rs_Simpan.Open(DeKlare_Data & Insert_Data, cn_eSumsel)
        End If
        Close_eSumsel()
        tampil()
        reset()
        '==========================
        'yyHis_cPar_OPD_3OPD(Nilai_Histori) '0 = Inset,1=Update,2=Hapus
        '==========================
        MsgBox("Data telah disimpan.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Informasi")
    End Sub

    Sub tampil()
        If Open_eSumsel_Tampil() = False Then Exit Sub

        Dim sql_Text_Comman As String = "SELECT " _
                                    & " Kode_Urusan + '.' + Kode_Bidang +'.' + Kode_OPD + '.' + Kode_Sub_OPD  as [Kode Sub OPD],Nama_Sub_OPD, Jenis, " _
                                    & " Keu, Gaji_PNS, TPP, Gaji_Non_PNS, Perjadin, Bos, BLUD " _
                                    & " FROM cPar_OPD_4Sub_OPD " _
                                    & " ORDER By Kode_Urusan, Kode_Bidang, Kode_OPD, Kode_Sub_OPD "
        Dim Tampil_data As New SqlCommand(sql_Text_Comman, cn_eSumsel_Tmpl)
        Tampil_data.CommandType = CommandType.Text

        Dim OleDA_Tampil As New SqlDataAdapter(Tampil_data)

        Dim ODS_Tampil As New DataSet
        OleDA_Tampil.Fill(ODS_Tampil, "OPD")
        Dim ODV_Tampil As New DataView(ODS_Tampil.Tables("OPD"))
        dg_Sub_OPD.DataSource = ODV_Tampil
        ODS_Tampil.Dispose()
        OleDA_Tampil.Dispose()

        Close_eSumsel_Tampil()

        dg_Sub_OPD.Columns(0).Width = (dg_Sub_OPD.Width / 10) * 1.8
        dg_Sub_OPD.Columns(1).Width = (dg_Sub_OPD.Width / 10) * 4
        dg_Sub_OPD.Columns(2).Width = (dg_Sub_OPD.Width / 10) * 1
        dg_Sub_OPD.Columns(3).Width = (dg_Sub_OPD.Width / 10) * 1
        dg_Sub_OPD.Columns(4).Width = (dg_Sub_OPD.Width / 10) * 1
        dg_Sub_OPD.Columns(5).Width = (dg_Sub_OPD.Width / 10) * 1
        dg_Sub_OPD.Columns(6).Width = (dg_Sub_OPD.Width / 10) * 1
        dg_Sub_OPD.Columns(7).Width = (dg_Sub_OPD.Width / 10) * 1
    End Sub

    Private Sub cPar_OPD_4Sub_OPD_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        tampil()
    End Sub

    Private Sub tblHapus_Click(sender As Object, e As EventArgs) Handles tblHapus.Click
        Dim Pesan = MsgBox("Yakin User ID " & mKode_Urusan.Text.Trim & " " & mKode_Bidang.Text.Trim & " " & mKode_OPD.Text.Trim & " ini akan di Hapus [Y/T] ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Informasi")
        If Pesan = MsgBoxResult.Yes Then
            If Open_eSumsel() = False Then Exit Sub
            Rs_Simpan.Open("Delete from cPar_OPD_4Sub_OPD  where Kode_Urusan = '" & mKode_Urusan.Text & "' and Kode_Bidang = '" & mKode_Bidang.Text & "' and Kode_OPD = '" & mKode_OPD.Text & "' and Kode_Sub_OPD = '" & mKode_Sub_OPD.Text & "' ", cn_eSumsel)
            Rs_Simpan.Open("Delete from cPar_OPD_4Sub_OPD  where Kode_Urusan = '" & mKode_Urusan.Text & "' and Kode_Bidang = '" & mKode_Bidang.Text & "' and Kode_OPD = '" & mKode_OPD.Text & "' and Kode_Sub_OPD = '" & mKode_Sub_OPD.Text & "' ", cn_eSumsel)
            Close_eSumsel()

            'Hapus yang berhubungan dengan user id ini

            '==========================
            'yyHis_aPar_UserID("2") '0 = Inset,1=Update,2=Hapus
            '==========================
            tampil()
            Call reset()
            'tblBaru_Click(tblBaru, New EventArgs)
            MsgBox("Kode OPD " & mKode_Urusan.Text.Trim & " Data telah dihapus.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Informasi")
        End If
    End Sub
    Sub reset()
        mKode_Urusan.Text = ""
        mKode_Bidang.Text = ""
        mKode_OPD.Text = ""
        mNama_OPD.Text = ""
        mKode_Sub_OPD.Text = ""
        mNama_Sub_OPD.Text = ""
        mKode_Fungsi.Text = ""
        mNama_Fungsi.Text = ""
        ch_Jenis.Checked = False
        ch_BLUD.Checked = False
        ch_BOS.Checked = False
        ch_Gaji_Non_PNS.Checked = False
        ch_Gaji_PNS.Checked = False
        ch_Keu.Checked = False
        ch_Perjadin.Checked = False
        ch_TPP.Checked = False
    End Sub

    Private Sub tblBaru_Click(sender As Object, e As EventArgs) Handles tblBaru.Click
        reset()
    End Sub

    Private Sub mKode_Sub_OPD_LostFocus(sender As Object, e As EventArgs) Handles mKode_Sub_OPD.LostFocus
        If mKode_Sub_OPD.Text.Trim.Length = 1 Then mKode_Sub_OPD.Text = "0" & mKode_Sub_OPD.Text.Trim
        If Open_eSumsel() = False Then Exit Sub

        Dim sql_Text_Comman As String = "SELECT " _
                                    & " Kode_Urusan ," _
                                    & " Kode_Bidang ," _
                                    & " Kode_OPD ," _
                                    & " Kode_Sub_OPD ," _
                                    & " Nama_Sub_OPD," _
                                    & " Jenis, " _
                                    & " Keu, " _
                                    & " Gaji_PNS, " _
                                    & " TPP, " _
                                    & " Gaji_Non_PNS, " _
                                    & " Perjadin," _
                                    & " Bos," _
                                    & " BLUD" _
                                    & " FROM cPar_OPD_4Sub_OPD " _
                                    & " WHERE Kode_Urusan = '" & mKode_Urusan.Text.Trim & "'  and Kode_Bidang = '" & mKode_Bidang.Text.Trim & "' and Kode_OPD = '" & mKode_OPD.Text.Trim & "' and Kode_Sub_OPD = '" & mKode_Sub_OPD.Text.Trim & "' "
        Rs_Baca.Open(sql_Text_Comman, cn_eSumsel)

        If Rs_Baca.RecordCount > 0 Then
            mKode_Sub_OPD.Text = Rs_Baca.Fields("Kode_Sub_OPD").Value.ToString.Trim
            mNama_Sub_OPD.Text = Rs_Baca.Fields("Nama_Sub_OPD").Value.ToString.Trim
            If Rs_Baca.Fields("Jenis").Value = 1 Then
                ch_Jenis.Checked = True
            End If
            If Rs_Baca.Fields("BLUD").Value = 1 Then
                ch_BLUD.Checked = True
            End If
            If Rs_Baca.Fields("Keu").Value = 1 Then
                ch_Keu.Checked = True
            End If
            If Rs_Baca.Fields("Gaji_PNS").Value = 1 Then
                ch_Gaji_PNS.Checked = True
            End If
            If Rs_Baca.Fields("TPP").Value = 1 Then
                ch_TPP.Checked = True
            End If
            If Rs_Baca.Fields("Gaji_Non_PNS").Value = 1 Then
                ch_Gaji_Non_PNS.Checked = True
            End If
            If Rs_Baca.Fields("Perjadin").Value = 1 Then
                ch_Perjadin.Checked = True
            End If
            If Rs_Baca.Fields("Bos").Value = 1 Then
                ch_BOS.Checked = True
            End If

            MsgBox("Yakin Data Diupdate")
        End If
        Rs_Baca.Close()
        Close_eSumsel()
    End Sub
End Class