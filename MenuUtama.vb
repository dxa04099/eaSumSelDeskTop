Imports System.Windows.Forms
Imports System.IO
Imports System.Data.SqlClient
Imports System.Text
Imports ADOX
Imports System.Runtime.InteropServices
Imports System.Net.NetworkInformation
Imports System.Management
Imports System
Imports System.Data.OleDb
Public Class MenuUtama
      
    Private Sub FileMenu_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileMenu_Exit.Click
        '==========
        'SimpanLogin(mUserID.Text.Trim, "2") '0=Login, 2=Keluar Aplikasi / Tutup Aplikasi, 1 = Ganti PSW, 3 = Log OFF
        '==========
        Me.Close()
        End
    End Sub
    Function getMacAddress(ByVal nilai As Integer)
        Dim nics() As NetworkInterface = _
              NetworkInterface.GetAllNetworkInterfaces
        Return nics(nilai).GetPhysicalAddress.ToString
    End Function


    Private Function GetIPv4Address() As String
        GetIPv4Address = String.Empty
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim iphe As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(strHostName)

        For Each ipheal As System.Net.IPAddress In iphe.AddressList
            If ipheal.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then
                GetIPv4Address = ipheal.ToString()
            End If
        Next

    End Function
    Private Function GetProcessorId() As String
        Dim strProcessorId As String = String.Empty
        Dim query As New SelectQuery("Win32_processor")
        Dim search As New ManagementObjectSearcher(query)
        Dim info As ManagementObject

        For Each info In search.Get()
            strProcessorId = info("processorId").ToString()
        Next
        Return strProcessorId
    End Function
    Private Function GetMotherBoardID() As String
        Dim strMotherBoardID As String = String.Empty
        Dim query As New SelectQuery("Win32_BaseBoard")
        Dim search As New ManagementObjectSearcher(query)
        Dim info As ManagementObject
        For Each info In search.Get()
            strMotherBoardID = info("SerialNumber").ToString()
        Next
        Return strMotherBoardID
    End Function
    Private Sub MenuUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mKd_Level.Text = "1"
        mUserID.Text = "admin"
        'Dim conn As ADODB.Connection
        cn_Lokal = New ADODB.Connection
        With cn_Lokal
            .Provider = "Microsoft.ACE.OLEDB.12.0"
            .Mode = ADODB.ConnectModeEnum.adModeReadWrite
            .ConnectionString = "Data Source=" & My.Application.Info.DirectoryPath & "\dbLokal.mdb" 'D:\APLIKASII_DESAIN\eSumsel\bin\Debug\dbLokal.mdb"
            .Open()
        End With

        'Dim cn_Lokal1 As New ADODB.Connection
        'cn_Lokal.ConnectionString = " Provider=Provider=Microsoft.Jet.OLEDB.4.0; Data Source= " & My.Application.Info.DirectoryPath & "\dbLokal.mdb" & " "
        'cn_Lokal.ConnectionString = " Provider=Provider=Microsoft.Jet.OLEDB.4.0; Data Source= D:\APLIKASII_DESAIN\eSumsel\bin\Debug\dbLokal.mdb" & " "
        '
        '& " Persist Security Info=False;Jet OLEDB:Engine Type=5"
        'cn_Lokal.Open()
        'Dim hw As New clsComputerInfo



        Dim jarak As Integer = (Me.Width / 6) - eUsulan_Warga.Width
        'MsgBox(Me.Width)
        eKomposisi_Kegiatan.Left = jarak / 2
        eUsulan_Warga.Left = jarak / 2 + eKomposisi_Kegiatan.Width + jarak
        ePenganggaran.Left = jarak / 2 + eKomposisi_Kegiatan.Width + jarak + eUsulan_Warga.Width + jarak
        ePenatausahaan.Left = jarak / 2 + eKomposisi_Kegiatan.Width + jarak + eUsulan_Warga.Width + jarak + ePenganggaran.Width + jarak

        eAkuntansi.Left = jarak / 2 + eKomposisi_Kegiatan.Width + jarak + eUsulan_Warga.Width + jarak + ePenganggaran.Width + jarak + ePenatausahaan.Width + jarak
        eMonev.Left = jarak / 2 + eKomposisi_Kegiatan.Width + jarak + eUsulan_Warga.Width + jarak + ePenganggaran.Width + jarak + ePenatausahaan.Width + jarak + eAkuntansi.Width + jarak

        eSatuan_Harga.Left = eKomposisi_Kegiatan.Left
        eSatuan_Biaya.Left = eKomposisi_Kegiatan.Left

        'Kolom 2
        ePokir_DPRD.Left = eUsulan_Warga.Left
        eMusrenbang.Left = eUsulan_Warga.Left
        eRenja.Left = eUsulan_Warga.Left

        'Kolom 4
        eGaji_PNS.Left = ePenatausahaan.Left
        eGaji_NON_PNS.Left = ePenatausahaan.Left
        eTPP.Left = ePenatausahaan.Left
        ePerjadin.Left = ePenatausahaan.Left
        eDana_BLUD.Left = ePenatausahaan.Left
        eDana_BLUD.Left = ePenatausahaan.Left
        eDana_Bos.Left = ePenatausahaan.Left


        Rs_Simpan = New ADODB.Recordset
        Rs_Simpan.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        Rs_Simpan.CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        Rs_Simpan.LockType = ADODB.LockTypeEnum.adLockOptimistic

        Rs_Baca = New ADODB.Recordset
        Rs_Baca.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        Rs_Baca.CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        Rs_Baca.LockType = ADODB.LockTypeEnum.adLockOptimistic

        'cek keberadaan file dblokal jika tidak ada buat databse dan tabelnya
        If File.Exists(My.Application.Info.DirectoryPath & "\dblokal.mdb") = False Then
            'If CreateAccessDatabase(My.Application.Info.DirectoryPath & "\dblokal.mdb") = False Then
            MsgBox(" file dbLokal.mdb tidak ada... " & Chr(13) _
                     & " silahkan download atau dapat kan dari admin file tersebut.., " _
                     & " letakan file tersebut di : " & My.Application.Info.DirectoryPath & "\", MsgBoxStyle.OkOnly, "informasi")
            Me.Close()
            End

        End If

        'malamatfile.Text = System.Environment.CurrentDirectory
        '===Cek keberadaaan File config.ini pada folder aflikasi
        If File.Exists(My.Application.Info.DirectoryPath & "\config.ini") = False Then
            'Timer1.Enabled = False
            f_UserManagementSetServer.ShowDialog(Me)
        End If
        '===bentuk conection string----
        vNamaServer = AmbilPWD(CariDatapadFiletext(My.Application.Info.DirectoryPath & "\config.ini", "namaserver=").ToString.Trim, "sunarsip")
        vNamaDataBase = CariDatapadFiletext(My.Application.Info.DirectoryPath & "\config.ini", "namadatabase=").ToString.Trim
        vUserIDDB = AmbilPWD(CariDatapadFiletext(My.Application.Info.DirectoryPath & "\config.ini", "user id=").ToString.Trim, "sunarsip")
        vPasswordDB = AmbilPWD(CariDatapadFiletext(My.Application.Info.DirectoryPath & "\config.ini", "password=").ToString.Trim, "sunarsip")
        'MsgBox("nama server = " & vNamaServer & "---nama databse = " & vNamaDataBase & "---id = " & vUserIDDB & "---psw = " & vPasswordDB)
        '================


        mMAC1.Text = getMacAddress(1)
        mMAC0.Text = getMacAddress(0)
        mIPAdress.Text = GetIPv4Address()
        mProcessorID.Text = GetProcessorId()
        mMotherBoardID.Text = GetMotherBoardID()
    End Sub
     
  

    Private Sub eKomposisi_Kegiatan_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles eKomposisi_Kegiatan.MouseLeave
        eKomposisi_Kegiatan.BackColor = Color.White
        eKomposisi_Kegiatan.ForeColor = Color.Black
        eKomposisi_Kegiatan.Font = New Font(eKomposisi_Kegiatan.Font, FontStyle.Regular)
    End Sub

    Private Sub eKomposisi_Kegiatan_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles eKomposisi_Kegiatan.MouseMove
        eKomposisi_Kegiatan.BackColor = Color.AliceBlue
        eKomposisi_Kegiatan.ForeColor = Color.Blue
        eKomposisi_Kegiatan.Font = New Font(eKomposisi_Kegiatan.Font, FontStyle.Italic + FontStyle.Underline)

    End Sub

    Private Sub FileMenu_UserManagement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileMenu_UserManagement.Click
        f_UserManagement.ShowDialog(Me)
    End Sub
    Private Sub FileMenu_Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileMenu_Login.Click
        Me.Visible = False
        f_LogON.mUserID.Text = ""
        f_LogON.mPWD.Text = ""
        f_LogON.ShowDialog(Me)
    End Sub

    Private Sub FileMenu_GantiPWD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileMenu_GantiPWD.Click
        If mUserID.Text.Trim = "" Then
            MsgBox("Anda belum login.....", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
            Exit Sub
        End If
        f_UserManagement_GntPasword.mUserID.Text = mUserID.Text.Trim
        f_UserManagement_GntPasword.mNama.Text = mNama.Text.Trim

        f_UserManagement_GntPasword.ShowDialog(Me)
    End Sub

   

    Private Sub FileMenu_Logoff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileMenu_Logoff.Click
        MsgBox("Matikan semua menu yang terbuka...")
        '0=Login, 2=Keluar Aplikasi / Tutup Aplikasi, 1 = Ganti PSW, 3 = Log OFF
    End Sub

    Private Sub ParameterMenu_Sinkronisasi_Data_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_Sinkronisasi_Data.Click
        par_Sinkronisasi_Data.ShowDialog(Me)
    End Sub

    Private Sub parMenu_OPD_Unit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_OPD_Unit.Click
        cPar_OPD_3OPD.Show(Me)
    End Sub
    Private Sub parMenu_OPD_Sub_OPD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_OPD_Sub_OPD.Click
        cPar_OPD_4Sub_OPD.Show(Me)
    End Sub
    Private Sub parMenu_OPD_Sub_Sub_OPD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_OPD_Sub_Sub_OPD.Click
        cPar_OPD_5Sub_Sub_OPD.Show(Me)
    End Sub
    Private Sub parMenu_Rek_APBD_Jenis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_Rek_APBD_Jenis.Click
        cPar_RekAPBD_3.Show(Me)
    End Sub
    Private Sub parMenu_Rek_APBD_Objek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_Rek_APBD_Objek.Click
        cPar_RekAPBD_4.Show(Me)
    End Sub
    Private Sub parMenu_Rek_APBD_Rincian_Objek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_Rek_APBD_Rincian_Objek.Click
        cPar_RekAPBD_5.Show(Me)
    End Sub
    Private Sub parMenu_Rek_APBD_Sub_Sub_Uraian_Rinc_Objek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_Rek_APBD_Sub_Sub_Uraian_Rinc_Objek.Click
        cPar_RekAPBD_8.Show(Me)
    End Sub
    Private Sub parMenu_Rek_APBD_Sub_Uraian_Rinc_Objek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_Rek_APBD_Sub_Uraian_Rinc_Objek.Click
        cPar_RekAPBD_7.Show(Me)
    End Sub
    Private Sub parMenu_Rek_APBD_Uraian_Rin_Objek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_Rek_APBD_Uraian_Rin_Objek.Click
        cPar_RekAPBD_6.Show(Me)
    End Sub

    Private Sub parMenu_Rek_APBD_POS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_Rek_APBD_POS.Click
        cPar_RekAPBD_1.Show(Me)
    End Sub
    Private Sub parMenu_Rek_APBD_Kelompok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_Rek_APBD_Kelompok.Click
        cPar_RekAPBD_2.Show(Me)
    End Sub

    Private Sub parMenu_Rek_LRA_POS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_Rek_LRA_POS.Click
        cPar_RekLRA_1.Show(Me)
    End Sub

    Private Sub parMenu_Rek_LRA_Kelompok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_Rek_LRA_Kelompok.Click
        cPar_RekLRA_2.Show(Me)
    End Sub

    Private Sub parMenu_Rek_LRA_Jenis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_Rek_LRA_Jenis.Click
        cPar_RekLRA_3.Show(Me)
    End Sub

    Private Sub parMenu_Rek_LRA_Objek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_Rek_LRA_Objek.Click
        cPar_RekLRA_4.Show(Me)
    End Sub

    Private Sub parMenu_Rek_Akrual_POS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_Rek_Akrual_POS.Click
        cPar_RekAkrual_1.Show(Me)
    End Sub

    Private Sub parMenu_Rek_Akrual_Kelompok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_Rek_Akrual_Kelompok.Click
        cPar_RekAkrual_2.Show(Me)
    End Sub

    Private Sub parMenu_Rek_Akrual_Jenis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_Rek_Akrual_Jenis.Click
        cPar_RekAkrual_3.Show(Me)
    End Sub

    Private Sub parMenu_Rek_Akrual_Objek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_Rek_Akrual_Objek.Click
        cPar_RekAkrual_4.Show(Me)
    End Sub

    Private Sub parMenu_Rek_Akrual_Rincian_Objek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_Rek_Akrual_Rincian_Objek.Click
        cPar_RekAkrual_5.Show(Me)
    End Sub

    Private Sub parMenu_Wilayah_Provinsi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_Wilayah_Provinsi.Click
        cPar_PKKKKD_1Provinsi.Show(Me)
    End Sub

    Private Sub parMenu_Wilayah_KabKota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_Wilayah_KabKota.Click
        cPar_PKKKKD_2KabKota.Show(Me)
    End Sub

    Private Sub parMenu_Wilayah_Kecamatan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_Wilayah_Kecamatan.Click
        cPar_PKKKKD_3Kecamatan.Show(Me)
    End Sub

    Private Sub parMenu_Wilayah_DesaKel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_Wilayah_DesaKel.Click
        cPar_PKKKKD_4KelDesa.Show(Me)
    End Sub

    Private Sub parMenu_DataUmumPemda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_DataUmumPemda.Click
        d0Tr_Pemda.Show(Me)
    End Sub
    Private Sub parMenu_Program_Kegiatan_Program_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_Program_Kegiatan_Program.Click
        cPar_ProgKeg_Program.Show(Me)
    End Sub
    Private Sub parMenu_Program_Kegiatan_Kegiatan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_Program_Kegiatan_Kegiatan.Click
        cPar_ProgKeg_Kegiatan.Show(Me)
    End Sub
    Private Sub parMenu_Program_Kegiatan_Komposisi_Rekening_Keg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_Program_Kegiatan_Komposisi_Rekening_Keg.Click
        cPar_ProgKeg_Rekening.Show(Me)
    End Sub
    Private Sub parMenu_OPD_Data_Umum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_OPD_Data_Umum.Click
        d0Tr_OPD_DataUmum.Show(Me)
    End Sub
    Private Sub parMenu_OPD_Jabatan_Keuangan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_OPD_Jabatan_Keuangan.Click
        d0Tr_OPD_Jabatan_Keuangan.Show(Me)
    End Sub
    Private Sub parMenu_Gaji_Gaji_Pokok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_Gaji_Gaji_Pokok.Click
        cgaji_Par_Gaji_Pokok.Show(Me)
    End Sub
    Private Sub parMenu_Gaji_Tunj_Ess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_Gaji_Tunj_Ess.Click
        cGaji_Par_Tunj_Esselon.Show(Me)
    End Sub
    Private Sub parMenu_Gaji_Tunj_Fungsional_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_Gaji_Tunj_Fungsional.Click
        cgaji_Par_Tunj_fung.Show(Me)
    End Sub
    Private Sub parMenu_Gaji_Tunj_Fungsional_Khusu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_Gaji_Tunj_Fungsional_Khusu.Click
        cgaji_Par_Tunj_fung_Khusus.Show(Me)
    End Sub
    Private Sub parMenu_Gaji_Tunj_Fungsional_Umum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_Gaji_Tunj_Fungsional_Umum.Click
        cGaji_Par_Tunj_Umum.Show(Me)
    End Sub
    Private Sub parMenu_Gaji_Tunj_Kemahalan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_Gaji_Tunj_Kemahalan.Click
        cGaji_Par_Tunj_TKD.Show(Me)
    End Sub

    Private Sub parMenu_Gaji_Tunj_Daerah_Tertinggal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_Gaji_Tunj_Daerah_Tertinggal.Click
        cGaji_Par_Tunj_DT.Show(Me)
    End Sub

    Private Sub parMenu_DL_LUar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_DL_LUar.Click
        cPerjadin_Par_Tarif_Luar_Daerah.Show(Me)
    End Sub

    Private Sub parMenu_Perjadin_DL_DD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_Perjadin_DL_DD.Click
        cPerjadin_Par_Tarif_Dalam_Daerah.Show(Me)
    End Sub

    Private Sub parMenu_Perjadin_DL_DKABKOTA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_Perjadin_DL_DKABKOTA.Click
        cPerjadin_Par_Tarid_Dalam_KabKota.Show(Me)
    End Sub
    Private Sub parMenu_Lkreditur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_kreditur.Click
        cPar_Kreditur.Show(Me)
    End Sub
    Private Sub parMenu_Bank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_Bank.Click
        cPar_Bank.Show(Me)
    End Sub

    Private Sub parMenu_Sumber_Dana_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_Sumber_Dana.Click
        cPar_RekAPBD_Sumber_Dana.Show(Me)
    End Sub
    Private Sub parMenu_TAPD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_TAPD.Click
        d0Tr_Tim_Anggaran.Show(Me)
    End Sub

    Private Sub parMenu_Peraturan_Daerah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_Peraturan_Daerah.Click
        d0Tr_Peraturan.Show(Me)
    End Sub
    Private Sub parMenu_Penandatangan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_Penandatangan_Dokumen.Click
        cPar_Penandatangan_Dokumen.Show(Me)
    End Sub

    Private Sub parMenu_FormatPenomoran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parMenu_FormatPenomoran.Click
        cPar_Penomoran_Dokumen.Show(Me)
    End Sub
    Private Sub eKomposisi_Kegiatan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eKomposisi_Kegiatan.Click

        'If NumericUpDown1.Value = 1 Then view_cgaji_Par_Gaji_Pokok.ShowDialog(Me)
        'If NumericUpDown1.Value = 2 Then view_cGaji_Par_setting.ShowDialog(Me)
        'If NumericUpDown1.Value = 3 Then view_cGaji_Par_Tunj_DT.ShowDialog(Me)
        'If NumericUpDown1.Value = 4 Then view_cGaji_Par_Tunj_Esselon.ShowDialog(Me)
        'If NumericUpDown1.Value = 5 Then view_cgaji_Par_Tunj_fung.ShowDialog(Me)
        'If NumericUpDown1.Value = 6 Then view_cgaji_Par_Tunj_fung_Khusus.ShowDialog(Me)
        'If NumericUpDown1.Value = 7 Then view_cGaji_Par_Tunj_TKD.ShowDialog(Me)
        'If NumericUpDown1.Value = 8 Then view_cGaji_Par_Tunj_Umum.ShowDialog(Me)
        'If NumericUpDown1.Value = 9 Then view_cPar_Bank.ShowDialog(Me)
        'If NumericUpDown1.Value = 10 Then view_cPar_Kreditur.ShowDialog(Me)
        'If NumericUpDown1.Value = 11 Then view_cPar_OPD_1Urusan.ShowDialog(Me)
        'If NumericUpDown1.Value = 12 Then view_cPar_OPD_2Bidang.ShowDialog(Me)
        'If NumericUpDown1.Value = 13 Then view_cPar_OPD_3OPD.ShowDialog(Me)
        'If NumericUpDown1.Value = 14 Then view_cPar_OPD_4Sub_OPD.ShowDialog(Me)
        'If NumericUpDown1.Value = 15 Then view_cPar_OPD_5Sub_Sub_OPD.ShowDialog(Me)
        'If NumericUpDown1.Value = 16 Then view_cPar_Penandatangan_Dokumen.ShowDialog(Me)
        'If NumericUpDown1.Value = 17 Then view_cPar_Penomoran_Dokumen.ShowDialog(Me)
        'If NumericUpDown1.Value = 18 Then view_cPar_PKKKKD_1Provinsi.ShowDialog(Me)
        'If NumericUpDown1.Value = 19 Then view_cPar_PKKKKD_2KabKota.ShowDialog(Me)
        'If NumericUpDown1.Value = 20 Then view_cPar_PKKKKD_3Kecamatan.ShowDialog(Me)
        'If NumericUpDown1.Value = 21 Then view_cPar_PKKKKD_4KelDesa.ShowDialog(Me)
        'If NumericUpDown1.Value = 22 Then view_cPar_Potongan_SPM.ShowDialog(Me)
        'If NumericUpDown1.Value = 23 Then view_cPar_Potongan_SPM_Rek.ShowDialog(Me)
        'If NumericUpDown1.Value = 24 Then view_cPar_ProgKeg_Kegiatan.ShowDialog(Me)
        'If NumericUpDown1.Value = 25 Then view_cPar_ProgKeg_Program.ShowDialog(Me)
        'If NumericUpDown1.Value = 26 Then View_cPar_ProgKeg_Rekening.ShowDialog(Me)
        'If NumericUpDown1.Value = 27 Then view_cPar_RekAkrual_1.ShowDialog(Me)
        'If NumericUpDown1.Value = 28 Then view_cPar_RekAkrual_2.ShowDialog(Me)
        'If NumericUpDown1.Value = 29 Then view_cPar_RekAkrual_3.ShowDialog(Me)
        'If NumericUpDown1.Value = 30 Then view_cPar_RekAkrual_4.ShowDialog(Me)
        'If NumericUpDown1.Value = 31 Then view_cPar_RekAkrual_5.ShowDialog(Me)
        'If NumericUpDown1.Value = 32 Then view_cPar_RekAPBD_1.ShowDialog(Me)
        'If NumericUpDown1.Value = 33 Then view_cPar_RekAPBD_2.ShowDialog(Me)
        'If NumericUpDown1.Value = 34 Then view_cPar_RekAPBD_3.ShowDialog(Me)
        'If NumericUpDown1.Value = 35 Then view_cPar_RekAPBD_4.ShowDialog(Me)
        'If NumericUpDown1.Value = 36 Then view_cPar_RekAPBD_5.ShowDialog(Me)
        'If NumericUpDown1.Value = 37 Then view_cPar_RekAPBD_6.ShowDialog(Me)
        'If NumericUpDown1.Value = 38 Then view_cPar_RekAPBD_7.ShowDialog(Me)
        'If NumericUpDown1.Value = 39 Then view_cPar_RekAPBD_8.ShowDialog(Me)
        'If NumericUpDown1.Value = 40 Then view_cPar_RekAPBD_Sumber_Dana.ShowDialog(Me)
        'If NumericUpDown1.Value = 41 Then view_cPar_RekAPBD_Wajib_Mengikat.ShowDialog(Me)
        'If NumericUpDown1.Value = 42 Then view_cPar_RekLRA_1.ShowDialog(Me)
        'If NumericUpDown1.Value = 43 Then view_cPar_RekLRA_2.ShowDialog(Me)
        'If NumericUpDown1.Value = 44 Then view_cPar_RekLRA_3.ShowDialog(Me)
        'If NumericUpDown1.Value = 45 Then view_cPar_RekLRA_4.ShowDialog(Me)
        'If NumericUpDown1.Value = 46 Then view_cPar_Satuan.ShowDialog(Me)
        'If NumericUpDown1.Value = 47 Then view_cPerjadin_Par_Tarid_Dalam_KabKota.ShowDialog(Me)
        'If NumericUpDown1.Value = 48 Then view_cPerjadin_Par_Tarif_Dalam_Daerah.ShowDialog(Me)
        'If NumericUpDown1.Value = 49 Then view_cPerjadin_Par_Tarif_Luar_Daerah.ShowDialog(Me)
        'NumericUpDown1.Value = NumericUpDown1.Value - 1
    End Sub

    Private Sub eSatuan_Harga_Click(sender As Object, e As EventArgs) Handles eSatuan_Harga.Click
        'If NumericUpDown1.Value = 1 Then view_bGaji_Par_Hitung_Gaji.ShowDialog(Me)
        'If NumericUpDown1.Value = 2 Then view_bgaji_Par_JaFung_Kel.ShowDialog(Me)
        'If NumericUpDown1.Value = 3 Then view_bGaji_Par_Jenis_Gaji.ShowDialog(Me)
        'If NumericUpDown1.Value = 4 Then view_bGaji_Par_Jenis_Kekurangan.ShowDialog(Me)
        'If NumericUpDown1.Value = 5 Then view_bPar_Agama.ShowDialog(Me)
        'If NumericUpDown1.Value = 6 Then view_bPar_Dokumen.ShowDialog(Me)
        'If NumericUpDown1.Value = 7 Then view_bPar_EditData.ShowDialog(Me)
        'If NumericUpDown1.Value = 8 Then view_bPar_Esselon.ShowDialog(Me)
        'If NumericUpDown1.Value = 9 Then view_bPar_Gol_Pangkat.ShowDialog(Me)
        'If NumericUpDown1.Value = 10 Then view_bPar_Hubungan_Keluarga.ShowDialog(Me)
        'If NumericUpDown1.Value = 11 Then view_bPar_Indikator.ShowDialog(Me)
        'If NumericUpDown1.Value = 12 Then view_bPar_Jabatan_Keuangan.ShowDialog(Me)
        'If NumericUpDown1.Value = 13 Then view_bPar_Jenis_Guru.ShowDialog(Me)
        'If NumericUpDown1.Value = 14 Then view_bPar_Jenis_SPP.ShowDialog(Me)
        'If NumericUpDown1.Value = 15 Then view_bPar_Jenis_Tagihan.ShowDialog(Me)
        'I 'f NumericUpDown1.Value = 16 Then view_bPar_Jurnal.ShowDialog(Me)
        'If' NumericUpDown1.Value = 17 Then view_bPar_OPD_Fungsi.ShowDialog(Me)
        'If NumericUpDown1.Value = 18 Then view_bPar_Pendidikan_Akhir.ShowDialog(Me)
        'If NumericUpDown1.Value = 19 Then view_bPar_Peraturan.ShowDialog(Me)
        'If NumericUpDown1.Value = 20 Then view_bPar_Perubahan.ShowDialog(Me)
        'If NumericUpDown1.Value = 21 Then view_bPar_PTKP.ShowDialog(Me)
        'If NumericUpDown1.Value = 22 Then view_bPar_Status_Kawin.ShowDialog(Me)
        'If NumericUpDown1.Value = 23 Then view_bPar_Status_Pegawai.ShowDialog(Me)
        'If NumericUpDown1.Value = 24 Then view_bPerjadin_Par_Kelompok.ShowDialog(Me)
        'NumericUpDown1.Value = NumericUpDown1.Value + 1
    End Sub

    Private Sub parMenu_DokumenPendukung_Click(sender As Object, e As EventArgs) Handles parMenu_DokumenPendukung.Click
        d0Tr_Dokumen_Pendukung.Show(Me)
    End Sub

End Class
