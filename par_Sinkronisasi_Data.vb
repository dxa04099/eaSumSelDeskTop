Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.OleDb

Imports System.Text
Imports ADOX
Imports System.Runtime.InteropServices


Public Class par_Sinkronisasi_Data

    Private Sub tblProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblProses.Click
        pgProses.Visible = True
        If Open_eSumsel() = False Then Exit Sub
        If cn_Lokal.State = ConnectionState.Closed Then cn_Lokal.Open()
        '==========Provinsi================================
        If ch_Wilayah_Provinsi.Checked = True Then
            Rs_Baca.Open("Delete  from  cPar_PKKKKD_1Provinsi", cn_Lokal)
            Rs_Baca.Open("Select * From  cPar_PKKKKD_1Provinsi", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    pgProses.Value = (Rs_Baca.AbsolutePosition / Rs_Baca.RecordCount) * 100
                    '===================
                    Rs_Simpan.Open(" Insert into cPar_PKKKKD_1Provinsi (" _
                            & " Kode_Provinsi," _
                            & " Nama_Provinsi) Values" _
                            & " " _
                            & "('" & Rs_Baca.Fields("Kode_Provinsi").Value & "'," _
                            & "'" & Rs_Baca.Fields("Nama_Provinsi").Value & "')", cn_Lokal)

                    '===================
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
        End If
        '==========Kab/Kota================================
        If ch_Wilayah_Kab_Kota.Checked = True Then
            Rs_Baca.Open("Delete  from  cPar_PKKKKD_2KabKota", cn_Lokal)
            Rs_Baca.Open("Select * From  cPar_PKKKKD_2KabKota", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    pgProses.Value = (Rs_Baca.AbsolutePosition / Rs_Baca.RecordCount) * 100
                    '===================
                    Rs_Simpan.Open(" Insert into cPar_PKKKKD_2KabKota (" _
                            & " Kode_Provinsi," _
                            & " Kode_KabKota," _
                            & " Nama_KabKota) Values" _
                            & " " _
                            & "('" & Rs_Baca.Fields("Kode_Provinsi").Value & "'," _
                            & "'" & Rs_Baca.Fields("Kode_KabKota").Value & "'," _
                            & "'" & Rs_Baca.Fields("Nama_KabKota").Value & "')", cn_Lokal)

                    '===================
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
        End If
        '==========Kecamatan================================
        If ch_Wilayah_Kecamatan.Checked = True Then
            Rs_Baca.Open("Delete  from  cPar_PKKKKD_3Kecamatan", cn_Lokal)
            Rs_Baca.Open("Select * From  cPar_PKKKKD_3Kecamatan", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    pgProses.Value = (Rs_Baca.AbsolutePosition / Rs_Baca.RecordCount) * 100
                    '===================
                    Rs_Simpan.Open(" Insert into cPar_PKKKKD_3Kecamatan (" _
                            & " Kode_Provinsi," _
                            & " Kode_KabKota," _
                            & " Kode_Kecamatan," _
                            & " Nama_Kecamatan) Values" _
                            & " " _
                            & "('" & Rs_Baca.Fields("Kode_Provinsi").Value & "'," _
                            & "'" & Rs_Baca.Fields("Kode_KabKota").Value & "'," _
                            & "'" & Rs_Baca.Fields("Kode_Kecamatan").Value & "'," _
                            & "'" & Rs_Baca.Fields("Nama_Kecamatan").Value & "')", cn_Lokal)

                    '===================
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
        End If
        '==========Desa Kelurahan================================
        If ch_Wilayah_Desa_Kelurahan.Checked = True Then
            Rs_Baca.Open("Delete  from  cPar_PKKKKD_4KelDesa", cn_Lokal)
            Rs_Baca.Open("Select * From  cPar_PKKKKD_4KelDesa", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    pgProses.Value = (Rs_Baca.AbsolutePosition / Rs_Baca.RecordCount) * 100
                    '===================
                    Rs_Simpan.Open(" Insert into cPar_PKKKKD_4KelDesa (" _
                            & " Kode_Provinsi," _
                            & " Kode_KabKota," _
                            & " Kode_Kecamatan," _
                            & " Kode_KelDesa," _
                            & " Nama_KelDesa) Values" _
                            & " " _
                            & "('" & Rs_Baca.Fields("Kode_Provinsi").Value & "'," _
                            & "'" & Rs_Baca.Fields("Kode_KabKota").Value & "'," _
                            & "'" & Rs_Baca.Fields("Kode_Kecamatan").Value & "'," _
                            & "'" & Rs_Baca.Fields("Kode_KelDesa").Value & "'," _
                            & "'" & Rs_Baca.Fields("Nama_KelDesa").Value & "')", cn_Lokal)

                    '===================
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
        End If
        '==========Program================================
        If ch_Par_OPD_Program.Checked = True Then
            Rs_Baca.Open("Delete  from  cPar_ProgKeg_Program", cn_Lokal)
            Rs_Baca.Open("Select * From  cPar_ProgKeg_Program", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    pgProses.Value = (Rs_Baca.AbsolutePosition / Rs_Baca.RecordCount) * 100
                    '===================
                    Rs_Simpan.Open(" Insert into cPar_ProgKeg_Program (" _
                            & " Kd_Urusan_Program," _
                            & " Kd_Bidang_Program," _
                            & " Kd_Prog," _
                            & " Nama_Program) Values" _
                            & " " _
                            & "('" & Rs_Baca.Fields("Kd_Urusan_Program").Value & "'," _
                            & "'" & Rs_Baca.Fields("Kd_Bidang_Program").Value & "'," _
                            & "'" & Rs_Baca.Fields("Kd_Prog").Value & "'," _
                            & "'" & Rs_Baca.Fields("Nama_Program").Value & "')", cn_Lokal)

                    '===================
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
        End If
        '==========Kegiatan================================
        If ch_Par_OPD_Kegiatan.Checked = True Then

            Rs_Baca.Open("Delete  from  cPar_ProgKeg_Kegiatan", cn_Lokal)
            Rs_Baca.Open("Select * From  cPar_ProgKeg_Kegiatan", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    pgProses.Value = (Rs_Baca.AbsolutePosition / Rs_Baca.RecordCount) * 100
                    '===================
                    Rs_Simpan.Open(" Insert into cPar_ProgKeg_Kegiatan (" _
                            & " Kd_Urusan_Program," _
                            & " Kd_Bidang_Program," _
                            & " Kd_Prog," _
                            & " Kd_Keg," _
                            & " Nama_Kegiatan) Values" _
                            & " " _
                            & "('" & Rs_Baca.Fields("Kd_Urusan_Program").Value & "'," _
                            & "'" & Rs_Baca.Fields("Kd_Bidang_Program").Value & "'," _
                            & "'" & Rs_Baca.Fields("Kd_Prog").Value & "'," _
                            & "'" & Rs_Baca.Fields("Kd_Keg").Value & "'," _
                            & "'" & Rs_Baca.Fields("Nama_Kegiatan").Value & "')", cn_Lokal)

                    '===================
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
        End If
        '==========Sumber Dana================================
        If ch_Sumber_Dana.Checked = True Then

            Rs_Baca.Open("Delete  from  cPar_RekAPBD_Sumber_Dana", cn_Lokal)
            Rs_Baca.Open("Select * From  cPar_RekAPBD_Sumber_Dana", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    pgProses.Value = (Rs_Baca.AbsolutePosition / Rs_Baca.RecordCount) * 100
                    '===================
                    Rs_Simpan.Open("Insert Into cPar_RekAPBD_Sumber_Dana (SD_Rek_Pos,SD_Rek_Kelompok,SD_Rek_Jenis,SD_Rek_Objek,SD_Nama_Rek_Objek) Values " _
                                & "('" & Rs_Baca.Fields("SD_Rek_Pos").Value & "'," _
                                & "'" & Rs_Baca.Fields("SD_Rek_Kelompok").Value & "'," _
                                & "'" & Rs_Baca.Fields("SD_Rek_Jenis").Value & "'," _
                                & "'" & Rs_Baca.Fields("SD_Rek_Objek").Value & "'," _
                                & "'" & Rs_Baca.Fields("SD_Nama_Rek_Objek").Value & "')", cn_Lokal)
                    '===================
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
        End If
        '================================
        If ch_Parameter_Tetap.Checked = True Then
            Rs_Baca.Open("Delete  from bGaji_Par_Hitung_Gaji", cn_Lokal)
            Rs_Baca.Open("Delete  from bgaji_Par_JaFung_Kel", cn_Lokal)
            Rs_Baca.Open("Delete  from bGaji_Par_Jenis_Gaji", cn_Lokal)
            Rs_Baca.Open("Delete  from bGaji_Par_Jenis_Kekurangan", cn_Lokal)
            Rs_Baca.Open("Delete  from bPar_Agama", cn_Lokal)
            Rs_Baca.Open("Delete  from bPar_Dokumen", cn_Lokal)
            Rs_Baca.Open("Delete  from bPar_EditData", cn_Lokal)
            Rs_Baca.Open("Delete  from bPar_Esselon", cn_Lokal)
            Rs_Baca.Open("Delete  from bPar_Gol_Pangkat", cn_Lokal)
            Rs_Baca.Open("Delete  from bPar_Hubungan_Keluarga", cn_Lokal)
            Rs_Baca.Open("Delete  from bPar_Indikator", cn_Lokal)
            Rs_Baca.Open("Delete  from bPar_Jabatan_Keuangan", cn_Lokal)
            Rs_Baca.Open("Delete  from bPar_Jenis_Guru", cn_Lokal)
            Rs_Baca.Open("Delete  from bPar_Jenis_SPP", cn_Lokal)
            Rs_Baca.Open("Delete  from bPar_Jenis_Tagihan", cn_Lokal)
            Rs_Baca.Open("Delete  from bPar_Jurnal", cn_Lokal)
            Rs_Baca.Open("Delete  from bPar_OPD_Fungsi", cn_Lokal)
            Rs_Baca.Open("Delete  from bPar_Pendidikan_Akhir", cn_Lokal)
            Rs_Baca.Open("Delete  from bPar_Peraturan", cn_Lokal)
            Rs_Baca.Open("Delete  from bPar_Perubahan", cn_Lokal)
            Rs_Baca.Open("Delete  from bPar_PTKP", cn_Lokal)
            Rs_Baca.Open("Delete  from bPar_Status_Kawin", cn_Lokal)
            Rs_Baca.Open("Delete  from bPar_Status_Pegawai", cn_Lokal)
            Rs_Baca.Open("Delete  from bPerjadin_Par_Kelompok", cn_Lokal)
            '============================
            Rs_Baca.Open("Select * From  bGaji_Par_Hitung_Gaji", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    pgProses.Value = (Rs_Baca.AbsolutePosition / Rs_Baca.RecordCount) * 100
                    Rs_Simpan.Open(" insert into bGaji_Par_Hitung_Gaji (Kode_Hitung_Gaji,ket_Hitung_Gaji) Values " _
                    & "('" & Rs_Baca.Fields("Kode_Hitung_Gaji").Value & "'," _
                    & "'" & Rs_Baca.Fields("ket_Hitung_Gaji").Value & "')", cn_Lokal)
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
            '============================
            Rs_Baca.Open("Select * From  bgaji_Par_JaFung_Kel", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    Rs_Simpan.Open(" insert into bgaji_Par_JaFung_Kel (Kode_Kel_JaFung,Kel_JaFung) Values  " _
                            & "('" & Rs_Baca.Fields("Kode_Kel_JaFung").Value & "'," _
                            & "'" & Rs_Baca.Fields("Kel_JaFung").Value & "')", cn_Lokal)

                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
            '============================
            Rs_Baca.Open("Select * From bGaji_Par_Jenis_Gaji ", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    Rs_Simpan.Open(" insert into bGaji_Par_Jenis_Gaji (Kode_Jenis_Gaji,Jenis_Gaji) Values  " _
                            & "('" & Rs_Baca.Fields("Kode_Jenis_Gaji").Value & "'," _
                            & "'" & Rs_Baca.Fields("Jenis_Gaji").Value & "')", cn_Lokal)

                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
            '============================
            Rs_Baca.Open("Select * From  bGaji_Par_Jenis_Kekurangan", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    Rs_Simpan.Open(" insert into bGaji_Par_Jenis_Kekurangan (Kode_Kekurangan_Gaji,Kekurangan_Gaji) Values  " _
                            & "('" & Rs_Baca.Fields("Kode_Kekurangan_Gaji").Value & "'," _
                            & "'" & Rs_Baca.Fields("Kekurangan_Gaji").Value & "')", cn_Lokal)
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
            '============================
            Rs_Baca.Open("Select * From  bPar_Agama", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    Rs_Simpan.Open(" insert into bPar_Agama (Kode_Agama, Agama) Values  " _
                                & "('" & Rs_Baca.Fields("Kode_Agama").Value & "'," _
                                & "'" & Rs_Baca.Fields("Agama").Value & "')", cn_Lokal)

                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
            '============================
            Rs_Baca.Open("Select * From  bPar_Dokumen", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    Rs_Simpan.Open(" insert into bPar_Dokumen (Kode_Dokumen, Nama_Dokumen) Values  " _
                            & "('" & Rs_Baca.Fields("Kode_Dokumen").Value & "'," _
                            & "'" & Rs_Baca.Fields("Nama_Dokumen").Value & "')", cn_Lokal)

                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
            '============================
            Rs_Baca.Open("Select * From bPar_EditData ", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    Rs_Simpan.Open(" insert into bPar_EditData (Kode_Edit,Uraian) Values  " _
                                & "('" & Rs_Baca.Fields("Kode_Edit").Value & "'," _
                                & "'" & Rs_Baca.Fields("Uraian").Value & "')", cn_Lokal)

                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
            '============================
            Rs_Baca.Open("Select * From bPar_Esselon ", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    Rs_Simpan.Open(" insert into bPar_Esselon (Kode_Ess,Esselon) Values  " _
                            & "('" & Rs_Baca.Fields("Kode_Ess").Value & "'," _
                            & "'" & Rs_Baca.Fields("Esselon").Value & "')", cn_Lokal)

                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
            '============================
            Rs_Baca.Open("Select * From  bPar_Gol_Pangkat", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    Rs_Simpan.Open(" insert into bPar_Gol_Pangkat (Gol,Pangkat) Values  " _
                            & "('" & Rs_Baca.Fields("Gol").Value & "'," _
                            & "'" & Rs_Baca.Fields("Pangkat").Value & "')", cn_Lokal)

                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
            '============================
            Rs_Baca.Open("Select * From  bPar_Hubungan_Keluarga", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    Rs_Simpan.Open(" insert into bPar_Hubungan_Keluarga (Kode_Hub_Keluarga, Hub_Keluarga) Values  " _
                            & "('" & Rs_Baca.Fields("Kode_Hub_Keluarga").Value & "'," _
                            & "'" & Rs_Baca.Fields("Hub_Keluarga").Value & "')", cn_Lokal)

                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
            '============================
            Rs_Baca.Open("Select * From  bPar_Indikator", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    Rs_Simpan.Open(" insert into bPar_Indikator (Kode_Indikator, Uraian_Indikator) Values  " _
                            & "('" & Rs_Baca.Fields("Kode_Indikator").Value & "'," _
                            & "'" & Rs_Baca.Fields("Uraian_Indikator").Value & "')", cn_Lokal)
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
            '============================
            Rs_Baca.Open("Select * From  bPar_Jabatan_Keuangan", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    Rs_Simpan.Open(" insert into bPar_Jabatan_Keuangan (Kode_Jabatan, Nama_Jabatan) Values  " _
                            & "('" & Rs_Baca.Fields("Kode_Jabatan").Value & "'," _
                            & "'" & Rs_Baca.Fields("Nama_Jabatan").Value & "')", cn_Lokal)
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
            '============================
            Rs_Baca.Open("Select * From  bPar_Jenis_Guru", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    Rs_Simpan.Open(" insert into bPar_Jenis_Guru (Kode_GURU, Jensi_Guru) Values  " _
                            & "('" & Rs_Baca.Fields("Kode_GURU").Value & "'," _
                            & "'" & Rs_Baca.Fields("Jensi_Guru").Value & "')", cn_Lokal)
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
            '============================
            Rs_Baca.Open("Select * From  bPar_Jenis_SPP", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    Rs_Simpan.Open(" insert into bPar_Jenis_SPP (Kode_Jenis_SPP, Uraian_Jenis_SPP, Kelompok, Nihil) Values  " _
                            & "('" & Rs_Baca.Fields("Kode_Jenis_SPP").Value & "'," _
                            & "'" & Rs_Baca.Fields("Uraian_Jenis_SPP").Value & "'," _
                            & "'" & Rs_Baca.Fields("Kelompok").Value & "'," _
                            & "'" & Rs_Baca.Fields("Nihil").Value & "')", cn_Lokal)
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
            '============================
            Rs_Baca.Open("Select * From  bPar_Jenis_Tagihan", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    Rs_Simpan.Open(" insert into bPar_Jenis_Tagihan (Kode_Jns_Tagihan,Nama_Tagihan) Values  " _
                                & "('" & Rs_Baca.Fields("Kode_Jns_Tagihan").Value & "'," _
                                & "'" & Rs_Baca.Fields("Nama_Tagihan").Value & "')", cn_Lokal)
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
            '============================
            Rs_Baca.Open("Select * From  bPar_Jurnal", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    Rs_Simpan.Open(" insert into bPar_Jurnal (Kode_Jurnal, Nama_Jurnal) Values  " _
                            & "('" & Rs_Baca.Fields("Kode_Jurnal").Value & "'," _
                            & "'" & Rs_Baca.Fields("Nama_Jurnal").Value & "')", cn_Lokal)
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
            '============================
            Rs_Baca.Open("Select * From bPar_OPD_Fungsi ", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    Rs_Simpan.Open(" insert into bPar_OPD_Fungsi (Kode_Fungsi, Nama_Fungsi) Values  " _
                            & "('" & Rs_Baca.Fields("Kode_Fungsi").Value & "'," _
                            & "'" & Rs_Baca.Fields("Nama_Fungsi").Value & "')", cn_Lokal)
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
            '============================
            Rs_Baca.Open("Select * From  bPar_Pendidikan_Akhir", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    Rs_Simpan.Open(" insert into bPar_Pendidikan_Akhir (Kode_Pendidikan,Pendidikan_akhir,Nomor_Urut) Values  " _
                                & "('" & Rs_Baca.Fields("Kode_Pendidikan").Value & "'," _
                                & "'" & Rs_Baca.Fields("Pendidikan_akhir").Value & "'," _
                                & "'" & Rs_Baca.Fields("Nomor_Urut").Value & "')", cn_Lokal)
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
            '============================
            Rs_Baca.Open("Select * From  bPar_Peraturan", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    Rs_Simpan.Open(" insert into bPar_Peraturan (Kode_Peraturan, Nama_Peraturan) Values  " _
                            & "('" & Rs_Baca.Fields("Kode_Peraturan").Value & "'," _
                            & "'" & Rs_Baca.Fields("Nama_Peraturan").Value & "')", cn_Lokal)
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
            '============================
            Rs_Baca.Open("Select * From  bPar_Perubahan", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    Rs_Simpan.Open(" insert into bPar_Perubahan (Kode_Perubahan,Uraian_Perubahan) Values  " _
                            & "('" & Rs_Baca.Fields("Kode_Perubahan").Value & "'," _
                            & "'" & Rs_Baca.Fields("Uraian_Perubahan").Value & "')", cn_Lokal)
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
            '============================
            Rs_Baca.Open("Select * From  bPar_PTKP", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    Rs_Simpan.Open(" insert into bPar_PTKP (Kode_Status_Kawin,Jml_Istri_Suami,Jml_Anak,Jml_Jiwa,PTKP_Sebulan,PTKP_Setahun) Values  " _
                            & "('" & Rs_Baca.Fields("Kode_Status_Kawin").Value & "'," _
                            & "'" & Rs_Baca.Fields("Jml_Istri_Suami").Value & "'," _
                            & "'" & Rs_Baca.Fields("Jml_Anak").Value & "'," _
                            & "'" & Rs_Baca.Fields("Jml_Jiwa").Value & "'," _
                            & "'" & Rs_Baca.Fields("PTKP_Sebulan").Value & "'," _
                            & "'" & Rs_Baca.Fields("PTKP_Setahun").Value & "')", cn_Lokal)
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
            '============================
            Rs_Baca.Open("Select * From  bPar_Status_Kawin", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    Rs_Simpan.Open(" insert into bPar_Status_Kawin (Kode_Status_Kawin, Staus_Kawin, No_Urut) Values  " _
                            & "('" & Rs_Baca.Fields("Kode_Status_Kawin").Value & "'," _
                            & "'" & Rs_Baca.Fields("Staus_Kawin").Value & "'," _
                            & "'" & Rs_Baca.Fields("No_Urut").Value & "')", cn_Lokal)
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
            '============================
            Rs_Baca.Open("Select * From  bPar_Status_Pegawai", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    Rs_Simpan.Open(" insert into bPar_Status_Pegawai (Kode_Sts_Pegawai,Sts_Pegawai,PNS_NON) Values  " _
                            & "('" & Rs_Baca.Fields("Kode_Sts_Pegawai").Value & "'," _
                            & "'" & Rs_Baca.Fields("Sts_Pegawai").Value & "'," _
                            & "'" & Rs_Baca.Fields("PNS_NON").Value & "')", cn_Lokal)
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
            '============================
            Rs_Baca.Open("Select * From  bPerjadin_Par_Kelompok", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    Rs_Simpan.Open(" insert into bPerjadin_Par_Kelompok (Kode_Kelompok,Kelompok,PNS_NON) Values  " _
                            & "('" & Rs_Baca.Fields("Kode_Kelompok").Value & "'," _
                            & "'" & Rs_Baca.Fields("Kelompok").Value & "'," _
                            & "'" & Rs_Baca.Fields("PNS_NON").Value & "')", cn_Lokal)
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()

        End If
        '================================
        If ch_Par_OPD_Urusan.Checked = True Then
            pgProses.Visible = True

            'If cn_Lokal.State =CONNECTDATA cn_Lokal.Open() Then
            Rs_Baca.Open("Delete  from   	cPar_OPD_1Urusan	", cn_Lokal)

            Rs_Baca.Open("Select * From  cPar_OPD_1Urusan", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    pgProses.Value = (Rs_Baca.AbsolutePosition / Rs_Baca.RecordCount) * 100
                    Rs_Simpan.Open(" insert Into cPar_OPD_1Urusan (Kode_Urusan,Nama_Urusan) Values " _
                        & "('" & Rs_Baca.Fields("Kode_Urusan").Value & "'," _
                        & "'" & Rs_Baca.Fields("Nama_Urusan").Value & "')", cn_Lokal)
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()

            'cn_Lokal.Close()
        End If
        '================================
        If ch_Par_OPD_Bidang.Checked = True Then



            Rs_Baca.Open("Delete  from  	cPar_OPD_2Bidang	", cn_Lokal)
            Rs_Baca.Open("Select * From  cPar_OPD_2Bidang", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    pgProses.Value = (Rs_Baca.AbsolutePosition / Rs_Baca.RecordCount) * 100
                    '===================
                    Rs_Simpan.Open(" insert Into cPar_OPD_2Bidang " _
                       & "(Kode_Urusan,Kode_Bidang,Nama_Bidang,Kode_Fungsi) Values " _
                       & " " _
                       & "('" & Rs_Baca.Fields("Kode_Urusan").Value & "'," _
                       & "'" & Rs_Baca.Fields("Kode_Bidang").Value & "'," _
                       & "'" & Rs_Baca.Fields("Nama_Bidang").Value & "'," _
                       & "'" & Rs_Baca.Fields("Kode_Fungsi").Value & "')", cn_Lokal)
                    '===================
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()


        End If
        '================================
        If ch_Par_OPD_Unit.Checked = True Then

            Rs_Baca.Open("Delete  from  	cPar_OPD_3OPD	", cn_Lokal)
            Rs_Baca.Open("Select * From  cPar_OPD_3OPD", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    pgProses.Value = (Rs_Baca.AbsolutePosition / Rs_Baca.RecordCount) * 100
                    '===================
                    Rs_Simpan.Open(" insert Into cPar_OPD_3OPD " _
                       & "(Kode_Urusan,Kode_Bidang,Kode_OPD,Nama_OPD,Kode_Fungsi) Values " _
                       & " " _
                       & "('" & Rs_Baca.Fields("Kode_Urusan").Value & "'," _
                       & "'" & Rs_Baca.Fields("Kode_Bidang").Value & "'," _
                       & "'" & Rs_Baca.Fields("Kode_OPD").Value & "'," _
                       & "'" & Rs_Baca.Fields("Nama_OPD").Value & "'," _
                       & "'" & Rs_Baca.Fields("Kode_Fungsi").Value & "')", cn_Lokal)
                    '===================
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()

        End If
        '================================
        If ch_Par_OPD_SubOPD.Checked = True Then

            Rs_Baca.Open("Delete  from  	cPar_OPD_4Sub_OPD	", cn_Lokal)
            Rs_Baca.Open("Select * From  cPar_OPD_4Sub_OPD", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    pgProses.Value = (Rs_Baca.AbsolutePosition / Rs_Baca.RecordCount) * 100
                    '===================
                    Rs_Simpan.Open(" insert Into cPar_OPD_4Sub_OPD " _
                       & "(Kode_Urusan,Kode_Bidang,Kode_OPD,Kode_Sub_OPD,Nama_Sub_OPD,Keu,Gaji_PNS,TPP,Gaji_Non_PNS,Perjadin,Bos,BLUD) Values " _
                       & " " _
                       & "('" & Rs_Baca.Fields("Kode_Urusan").Value & "'," _
                       & "'" & Rs_Baca.Fields("Kode_Bidang").Value & "'," _
                       & "'" & Rs_Baca.Fields("Kode_OPD").Value & "'," _
                       & "'" & Rs_Baca.Fields("Kode_Sub_OPD").Value & "'," _
                       & "'" & Rs_Baca.Fields("Nama_Sub_OPD").Value & "'," _
                       & "'" & Rs_Baca.Fields("Keu").Value & "'," _
                       & "'" & Rs_Baca.Fields("Gaji_PNS").Value & "'," _
                       & "'" & Rs_Baca.Fields("TPP").Value & "'," _
                       & "'" & Rs_Baca.Fields("Gaji_Non_PNS").Value & "'," _
                       & "'" & Rs_Baca.Fields("Perjadin").Value & "'," _
                       & "'" & Rs_Baca.Fields("Bos").Value & "'," _
                       & "'" & Rs_Baca.Fields("BLUD").Value & "')", cn_Lokal)
                    '===================
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()

        End If
        '================================
        If ch_Par_OPD_Sub_Sub_OPD.Checked = True Then

            Rs_Baca.Open("Delete  from  	cPar_OPD_5Sub_Sub_OPD	", cn_Lokal)
            Rs_Baca.Open("Select * From  cPar_OPD_5Sub_Sub_OPD", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    pgProses.Value = (Rs_Baca.AbsolutePosition / Rs_Baca.RecordCount) * 100
                    '===================
                    Rs_Simpan.Open(" insert Into cPar_OPD_5Sub_Sub_OPD " _
                        & "(Kode_Urusan,Kode_Bidang,Kode_OPD,Kode_Sub_OPD,Kode_Sub_Sub_OPD,Nama_Sub_Sub_OPD,Keu,Gaji_PNS,TPP,Gaji_Non_PNS,Perjadin,Bos,BLUD) Values " _
                        & " " _
                        & "('" & Rs_Baca.Fields("Kode_Urusan").Value & "'," _
                        & "'" & Rs_Baca.Fields("Kode_Bidang").Value & "'," _
                        & "'" & Rs_Baca.Fields("Kode_OPD").Value & "'," _
                        & "'" & Rs_Baca.Fields("Kode_Sub_OPD").Value & "'," _
                        & "'" & Rs_Baca.Fields("Kode_Sub_Sub_OPD").Value & "'," _
                        & "'" & Rs_Baca.Fields("Nama_Sub_Sub_OPD").Value & "'," _
                        & "'" & Rs_Baca.Fields("Keu").Value & "'," _
                        & "'" & Rs_Baca.Fields("Gaji_PNS").Value & "'," _
                        & "'" & Rs_Baca.Fields("TPP").Value & "'," _
                        & "'" & Rs_Baca.Fields("Gaji_Non_PNS").Value & "'," _
                        & "'" & Rs_Baca.Fields("Perjadin").Value & "'," _
                        & "'" & Rs_Baca.Fields("Bos").Value & "'," _
                        & "'" & Rs_Baca.Fields("BLUD").Value & "')", cn_Lokal)
                    '===================
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()

        End If
        '================================
        If ch_REK_SAP_Pos.Checked = True Then

            Rs_Baca.Open("Delete  from  	cPar_RekLRA_1	", cn_Lokal)
            Rs_Baca.Open("Select * From cPar_RekLRA_1 ", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    pgProses.Value = (Rs_Baca.AbsolutePosition / Rs_Baca.RecordCount) * 100
                    '===================
                    Rs_Simpan.Open("Insert Into cPar_RekLRA_1 (Rek_LRA_Pos,Nama_Rek_LRA_Pos) Values " _
                                & "('" & Rs_Baca.Fields("Rek_LRA_Pos").Value & "'," _
                                & "'" & Rs_Baca.Fields("Nama_Rek_LRA_Pos").Value & "')", cn_Lokal)
                    '===================
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
        End If
        '================================
        If ch_REK_SAP_Kelompok.Checked = True Then

            Rs_Baca.Open("Delete  from  cPar_RekLRA_2", cn_Lokal)
            Rs_Baca.Open("Select * From cPar_RekLRA_2 ", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    pgProses.Value = (Rs_Baca.AbsolutePosition / Rs_Baca.RecordCount) * 100
                    '===================
                    Rs_Simpan.Open("Insert Into cPar_RekLRA_2 (Rek_LRA_Pos,Rek_LRA_Kelompok,Nama_Rek_LRA_Kelompok) Values " _
                                & "('" & Rs_Baca.Fields("Rek_LRA_Pos").Value & "'," _
                                & "'" & Rs_Baca.Fields("Rek_LRA_Kelompok").Value & "'," _
                                & "'" & Rs_Baca.Fields("Nama_Rek_LRA_Kelompok").Value & "')", cn_Lokal)
                    '===================
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
        End If
        '================================
        If ch_REK_SAP_Jenis.Checked = True Then

            Rs_Baca.Open("Delete  from  cPar_RekLRA_3", cn_Lokal)
            Rs_Baca.Open("Select * From  cPar_RekLRA_3", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    pgProses.Value = (Rs_Baca.AbsolutePosition / Rs_Baca.RecordCount) * 100
                    '===================
                    Rs_Simpan.Open("Insert Into cPar_RekLRA_3 (Rek_LRA_Pos,Rek_LRA_Kelompok,Rek_LRA_Jenis,Nama_Rek_LRA_Jenis) Values " _
                                & "('" & Rs_Baca.Fields("Rek_LRA_Pos").Value & "'," _
                                & "'" & Rs_Baca.Fields("Rek_LRA_Kelompok").Value & "'," _
                                & "'" & Rs_Baca.Fields("Rek_LRA_Jenis").Value & "'," _
                                & "'" & Rs_Baca.Fields("Nama_Rek_LRA_Jenis").Value & "')", cn_Lokal)

                    '===================
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
        End If
        '================================
        If ch_REK_SAP_Objek.Checked = True Then

            Rs_Baca.Open("Delete  from  cPar_RekLRA_4", cn_Lokal)
            Rs_Baca.Open("Select * From  cPar_RekLRA_4", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    pgProses.Value = (Rs_Baca.AbsolutePosition / Rs_Baca.RecordCount) * 100
                    '===================
                    Rs_Simpan.Open("Insert Into cPar_RekLRA_4 (Rek_LRA_Pos,Rek_LRA_Kelompok,Rek_LRA_Jenis,Rek_LRA_Objek,Nama_Rek_LRA_Objek) Values " _
                                & "('" & Rs_Baca.Fields("Rek_LRA_Pos").Value & "'," _
                                & "'" & Rs_Baca.Fields("Rek_LRA_Kelompok").Value & "'," _
                                & "'" & Rs_Baca.Fields("Rek_LRA_Jenis").Value & "'," _
                                & "'" & Rs_Baca.Fields("Rek_LRA_Objek").Value & "'," _
                                & "'" & Rs_Baca.Fields("Nama_Rek_LRA_Objek").Value & "')", cn_Lokal)

                    '===================
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
        End If
        '================================
        If ch_REK_APBD_Pos.Checked = True Then
            Rs_Baca.Open("Delete  from  cPar_RekAPBD_1", cn_Lokal)
            Rs_Baca.Open("Select * From  cPar_RekAPBD_1", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    pgProses.Value = (Rs_Baca.AbsolutePosition / Rs_Baca.RecordCount) * 100
                    '===================
                    Rs_Simpan.Open("Insert Into cPar_RekAPBD_1 ( " _
                            & "Rek_Pos, " _
                            & "Nama_Rek_Pos) Values ( " _
                            & " " _
                            & "'" & Rs_Baca.Fields("Rek_Pos").Value & "'," _
                            & "'" & Rs_Baca.Fields("Nama_Rek_Pos").Value & "')", cn_Lokal)
                    '===================
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
        End If
        '================================
        If ch_REK_APBD_Kelompok.Checked = True Then
            Rs_Baca.Open("Delete  from  cPar_RekAPBD_2", cn_Lokal)
            Rs_Baca.Open("Select * From cPar_RekAPBD_2 ", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    pgProses.Value = (Rs_Baca.AbsolutePosition / Rs_Baca.RecordCount) * 100
                    '===================
                    Rs_Simpan.Open("Insert Into cPar_RekAPBD_2 ( " _
                            & "Rek_Pos, " _
                            & "Rek_Kelompok, " _
                            & "Nama_Rek_Kelompok) Values ( " _
                            & " " _
                            & "'" & Rs_Baca.Fields("Rek_Pos").Value & "'," _
                            & "'" & Rs_Baca.Fields("Rek_Kelompok").Value & "'," _
                            & "'" & Rs_Baca.Fields("Nama_Rek_Kelompok").Value & "')", cn_Lokal)
                    '===================
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
        End If
        '================================
        If ch_REK_APBD_Jenis.Checked = True Then
            Rs_Baca.Open("Delete  from  cPar_RekAPBD_3", cn_Lokal)
            Rs_Baca.Open("Select * From  cPar_RekAPBD_3", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    pgProses.Value = (Rs_Baca.AbsolutePosition / Rs_Baca.RecordCount) * 100
                    '===================
                    Rs_Simpan.Open("Insert Into cPar_RekAPBD_3 ( " _
                            & "Rek_Pos, " _
                            & "Rek_Kelompok, " _
                            & "Rek_Jenis,DK, " _
                            & "Nama_Rek_Jenis) Values ( " _
                            & " " _
                            & "'" & Rs_Baca.Fields("Rek_Pos").Value & "'," _
                            & "'" & Rs_Baca.Fields("Rek_Kelompok").Value & "'," _
                            & "'" & Rs_Baca.Fields("Rek_Jenis").Value & "'," _
                            & "'" & Rs_Baca.Fields("DK").Value & "'," _
                            & "'" & Rs_Baca.Fields("Nama_Rek_Jenis").Value & "')", cn_Lokal)
                    '===================
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
        End If
        '================================
        If ch_REK_APBD_Objek.Checked = True Then
            Rs_Baca.Open("Delete  from  cPar_RekAPBD_4", cn_Lokal)
            Rs_Baca.Open("Select * From cPar_RekAPBD_4 ", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    pgProses.Value = (Rs_Baca.AbsolutePosition / Rs_Baca.RecordCount) * 100
                    '===================
                    Rs_Simpan.Open("Insert Into cPar_RekAPBD_4 ( " _
                            & "Rek_Pos, " _
                            & "Rek_Kelompok, " _
                            & "Rek_Jenis, " _
                            & "Rek_Objek, " _
                            & "Nama_Rek_Objek) Values ( " _
                            & " " _
                            & "'" & Rs_Baca.Fields("Rek_Pos").Value & "'," _
                            & "'" & Rs_Baca.Fields("Rek_Kelompok").Value & "'," _
                            & "'" & Rs_Baca.Fields("Rek_Jenis").Value & "'," _
                            & "'" & Rs_Baca.Fields("Rek_Objek").Value & "'," _
                            & "'" & Rs_Baca.Fields("Nama_Rek_Objek").Value & "')", cn_Lokal)
                    '===================
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
        End If
        '================================
        If ch_REK_APBD_Rincian_Objek.Checked = True Then
            Rs_Baca.Open("Delete  from  cPar_RekAPBD_5", cn_Lokal)
            Rs_Baca.Open("Select * From  cPar_RekAPBD_5", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    pgProses.Value = (Rs_Baca.AbsolutePosition / Rs_Baca.RecordCount) * 100
                    '===================
                    Rs_Simpan.Open("Insert Into cPar_RekAPBD_5 ( " _
                            & "Rek_Pos, " _
                            & "Rek_Kelompok, " _
                            & "Rek_Jenis, " _
                            & "Rek_Objek, " _
                            & "Rek_Rincian_Objek, " _
                            & "Nama_Rek_Rincian_Objek) Values ( " _
                            & " " _
                            & "'" & Rs_Baca.Fields("Rek_Pos").Value & "'," _
                            & "'" & Rs_Baca.Fields("Rek_Kelompok").Value & "'," _
                            & "'" & Rs_Baca.Fields("Rek_Jenis").Value & "'," _
                            & "'" & Rs_Baca.Fields("Rek_Objek").Value & "'," _
                            & "'" & Rs_Baca.Fields("Rek_Rincian_Objek").Value & "'," _
                            & "'" & Rs_Baca.Fields("Nama_Rek_Rincian_Objek").Value & "')", cn_Lokal)
                    '===================
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
        End If
        '================================
        If ch_REK_APBD_Uraian_Rincian_Objek.Checked = True Then
            Rs_Baca.Open("Delete  from  cPar_RekAPBD_6", cn_Lokal)
            Rs_Baca.Open("Select * From  cPar_RekAPBD_6", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    pgProses.Value = (Rs_Baca.AbsolutePosition / Rs_Baca.RecordCount) * 100
                    '===================
                    Rs_Simpan.Open("Insert Into cPar_RekAPBD_6 ( " _
                            & "Rek_Pos, " _
                            & "Rek_Kelompok, " _
                            & "Rek_Jenis, " _
                            & "Rek_Objek, " _
                            & "Rek_Rincian_Objek, " _
                            & "Kode_Provinsi, " _
                            & "Kode_KabKota, " _
                            & "Rek_Rincian_Objek_kd_1, " _
                            & "Nama_Rek_Rincian_Objek_kd_1) Values ( " _
                            & " " _
                            & "'" & Rs_Baca.Fields("Rek_Pos").Value & "'," _
                            & "'" & Rs_Baca.Fields("Rek_Kelompok").Value & "'," _
                            & "'" & Rs_Baca.Fields("Rek_Jenis").Value & "'," _
                            & "'" & Rs_Baca.Fields("Rek_Objek").Value & "'," _
                            & "'" & Rs_Baca.Fields("Rek_Rincian_Objek").Value & "'," _
                            & "'" & Rs_Baca.Fields("Kode_Provinsi").Value & "'," _
                            & "'" & Rs_Baca.Fields("Kode_KabKota").Value & "'," _
                            & "'" & Rs_Baca.Fields("Rek_Rincian_Objek_kd_1").Value & "'," _
                            & "'" & Rs_Baca.Fields("Nama_Rek_Rincian_Objek_kd_1").Value & "')", cn_Lokal)
                    '===================
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
        End If
        '================================
        If ch_REK_APBD_Sub_Uraian_Rincian_Objek.Checked = True Then
            Rs_Baca.Open("Delete  from  cPar_RekAPBD_7", cn_Lokal)
            Rs_Baca.Open("Select * From  cPar_RekAPBD_7", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    pgProses.Value = (Rs_Baca.AbsolutePosition / Rs_Baca.RecordCount) * 100
                    '===================
                    Rs_Simpan.Open("Insert Into cPar_RekAPBD_7 ( " _
                            & "Rek_Pos, " _
                            & "Rek_Kelompok, " _
                            & "Rek_Jenis, " _
                            & "Rek_Objek, " _
                            & "Rek_Rincian_Objek, " _
                            & "Kode_Provinsi, " _
                            & "Kode_KabKota, " _
                            & "Rek_Rincian_Objek_kd_1, " _
                            & "Rek_Rincian_Objek_kd_2, " _
                            & "Nama_Rek_Rincian_Objek_kd_2) Values ( " _
                            & " " _
                            & "'" & Rs_Baca.Fields("Rek_Pos").Value & "'," _
                            & "'" & Rs_Baca.Fields("Rek_Kelompok").Value & "'," _
                            & "'" & Rs_Baca.Fields("Rek_Jenis").Value & "'," _
                            & "'" & Rs_Baca.Fields("Rek_Objek").Value & "'," _
                            & "'" & Rs_Baca.Fields("Rek_Rincian_Objek").Value & "'," _
                            & "'" & Rs_Baca.Fields("Kode_Provinsi").Value & "'," _
                            & "'" & Rs_Baca.Fields("Kode_KabKota").Value & "'," _
                            & "'" & Rs_Baca.Fields("Rek_Rincian_Objek_kd_1").Value & "'," _
                            & "'" & Rs_Baca.Fields("Rek_Rincian_Objek_kd_2").Value & "'," _
                            & "'" & Rs_Baca.Fields("Nama_Rek_Rincian_Objek_kd_2").Value & "')", cn_Lokal)
                    '===================
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
        End If
        '================================
        If ch_REK_APBD_Sub_Sub_Uraian_Rincian_Objek.Checked = True Then
            Rs_Baca.Open("Delete  from  cPar_RekAPBD_8", cn_Lokal)
            Rs_Baca.Open("Select * From  cPar_RekAPBD_8", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    pgProses.Value = (Rs_Baca.AbsolutePosition / Rs_Baca.RecordCount) * 100
                    '===================
                    Rs_Simpan.Open("Insert Into cPar_RekAPBD_8 ( " _
                            & "Rek_Pos, " _
                            & "Rek_Kelompok, " _
                            & "Rek_Jenis, " _
                            & "Rek_Objek, " _
                            & "Rek_Rincian_Objek, " _
                            & "Kode_Provinsi, " _
                            & "Kode_KabKota, " _
                            & "Rek_Rincian_Objek_kd_1, " _
                            & "Rek_Rincian_Objek_kd_2, " _
                            & "Rek_Rincian_Objek_kd_3, " _
                            & "Nama_Rek_Rincian_Objek_kd_3, " _
                            & "Spesifikasi_YaTidak, " _
                            & "Spesifikasi, " _
                            & "Satuan, " _
                            & "Harga) Values ( " _
                            & " " _
                            & "'" & Rs_Baca.Fields("Rek_Pos").Value & "'," _
                            & "'" & Rs_Baca.Fields("Rek_Kelompok").Value & "'," _
                            & "'" & Rs_Baca.Fields("Rek_Jenis").Value & "'," _
                            & "'" & Rs_Baca.Fields("Rek_Objek").Value & "'," _
                            & "'" & Rs_Baca.Fields("Rek_Rincian_Objek").Value & "'," _
                            & "'" & Rs_Baca.Fields("Kode_Provinsi").Value & "'," _
                            & "'" & Rs_Baca.Fields("Kode_KabKota").Value & "'," _
                            & "'" & Rs_Baca.Fields("Rek_Rincian_Objek_kd_1").Value & "'," _
                            & "'" & Rs_Baca.Fields("Rek_Rincian_Objek_kd_2").Value & "'," _
                            & "'" & Rs_Baca.Fields("Rek_Rincian_Objek_kd_3").Value & "'," _
                            & "'" & Rs_Baca.Fields("Nama_Rek_Rincian_Objek_kd_3").Value & "'," _
                            & "'" & Rs_Baca.Fields("Spesifikasi_YaTidak").Value & "'," _
                            & "'" & Rs_Baca.Fields("Spesifikasi").Value & "'," _
                            & "'" & Rs_Baca.Fields("Satuan").Value & "'," _
                            & "'" & Rs_Baca.Fields("Harga").Value & "')", cn_Lokal)
                    '===================
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
        End If
        '================================
        If ch_REK_Akrl_Pos.Checked = True Then
            Rs_Baca.Open("Delete  from  cPar_RekAkrual_1", cn_Lokal)
            Rs_Baca.Open("Select * From  cPar_RekAkrual_1", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    pgProses.Value = (Rs_Baca.AbsolutePosition / Rs_Baca.RecordCount) * 100
                    '===================
                    Rs_Simpan.Open("Insert Into cPar_RekAkrual_1 ( " _
                            & "akr_Rek_Pos, " _
                            & "akr_Nama_Rek_Pos) Values ( " _
                            & " " _
                            & "'" & Rs_Baca.Fields("akr_Rek_Pos").Value & "'," _
                            & "'" & Rs_Baca.Fields("akr_Nama_Rek_Pos").Value & "')", cn_Lokal)
                    '===================
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
        End If
        '================================
        If ch_REK_Akrl_Kelompok.Checked = True Then
            Rs_Baca.Open("Delete  from  cPar_RekAkrual_2", cn_Lokal)
            Rs_Baca.Open("Select * From cPar_RekAkrual_2 ", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    pgProses.Value = (Rs_Baca.AbsolutePosition / Rs_Baca.RecordCount) * 100
                    '===================
                    Rs_Simpan.Open("Insert Into cPar_RekAkrual_2 ( " _
                            & "akr_Rek_Pos, " _
                            & "akr_Rek_Kelompok, " _
                            & "akr_Nama_Rek_Kelompok) Values ( " _
                            & " " _
                            & "'" & Rs_Baca.Fields("akr_Rek_Pos").Value & "'," _
                            & "'" & Rs_Baca.Fields("akr_Rek_Kelompok").Value & "'," _
                            & "'" & Rs_Baca.Fields("akr_Nama_Rek_Kelompok").Value & "')", cn_Lokal)
                    '===================
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
        End If
        '================================
        If ch_REK_Akrl_Jenis.Checked = True Then
            Rs_Baca.Open("Delete  from  cPar_RekAkrual_3", cn_Lokal)
            Rs_Baca.Open("Select * From  cPar_RekAkrual_3", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    pgProses.Value = (Rs_Baca.AbsolutePosition / Rs_Baca.RecordCount) * 100
                    '===================
                    Rs_Simpan.Open("Insert Into cPar_RekAkrual_3 ( " _
                            & "akr_Rek_Pos, " _
                            & "akr_Rek_Kelompok, " _
                            & "akr_Rek_Jenis,DK, " _
                            & "akr_Nama_Rek_Jenis) Values ( " _
                            & " " _
                            & "'" & Rs_Baca.Fields("akr_Rek_Pos").Value & "'," _
                            & "'" & Rs_Baca.Fields("akr_Rek_Kelompok").Value & "'," _
                            & "'" & Rs_Baca.Fields("akr_Rek_Jenis").Value & "'," _
                            & "'" & Rs_Baca.Fields("DK").Value & "'," _
                            & "'" & Rs_Baca.Fields("akr_Nama_Rek_Jenis").Value & "')", cn_Lokal)
                    '===================
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
        End If
        '================================
        If ch_REK_Akrl_Objek.Checked = True Then
            Rs_Baca.Open("Delete  from  cPar_RekAkrual_4", cn_Lokal)
            Rs_Baca.Open("Select * From cPar_RekAkrual_4 ", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    pgProses.Value = (Rs_Baca.AbsolutePosition / Rs_Baca.RecordCount) * 100
                    '===================
                    Rs_Simpan.Open("Insert Into cPar_RekAkrual_4 ( " _
                            & "akr_Rek_Pos, " _
                            & "akr_Rek_Kelompok, " _
                            & "akr_Rek_Jenis, " _
                            & "akr_Rek_Objek, " _
                            & "akr_Nama_Rek_Objek) Values ( " _
                            & " " _
                            & "'" & Rs_Baca.Fields("akr_Rek_Pos").Value & "'," _
                            & "'" & Rs_Baca.Fields("akr_Rek_Kelompok").Value & "'," _
                            & "'" & Rs_Baca.Fields("akr_Rek_Jenis").Value & "'," _
                            & "'" & Rs_Baca.Fields("akr_Rek_Objek").Value & "'," _
                            & "'" & Rs_Baca.Fields("akr_Nama_Rek_Objek").Value & "')", cn_Lokal)
                    '===================
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
        End If
        '================================
        If ch_REK_Akrl_Rincian_Objek.Checked = True Then
            Rs_Baca.Open("Delete  from  cPar_RekAkrual_5", cn_Lokal)
            Rs_Baca.Open("Select * From  cPar_RekAkrual_5", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                Do While Rs_Baca.EOF = False
                    pgProses.Value = (Rs_Baca.AbsolutePosition / Rs_Baca.RecordCount) * 100
                    '===================
                    Rs_Simpan.Open("Insert Into cPar_RekAkrual_5 ( " _
                            & "akr_Rek_Pos, " _
                            & "akr_Rek_Kelompok, " _
                            & "akr_Rek_Jenis, " _
                            & "akr_Rek_Objek, " _
                            & "akr_Rek_Rincian_Objek, " _
                            & "akr_Nama_Rek_Rincian_Objek) Values ( " _
                            & " " _
                            & "'" & Rs_Baca.Fields("akr_Rek_Pos").Value & "'," _
                            & "'" & Rs_Baca.Fields("akr_Rek_Kelompok").Value & "'," _
                            & "'" & Rs_Baca.Fields("akr_Rek_Jenis").Value & "'," _
                            & "'" & Rs_Baca.Fields("akr_Rek_Objek").Value & "'," _
                            & "'" & Rs_Baca.Fields("akr_Rek_Rincian_Objek").Value & "'," _
                            & "'" & Rs_Baca.Fields("akr_Nama_Rek_Rincian_Objek").Value & "')", cn_Lokal)
                    '===================
                    Rs_Baca.MoveNext()
                Loop
            End If
            Rs_Baca.Close()
        End If

        cn_Lokal.Close()
        Close_eSumsel()
        pgProses.Visible = False
        MsgBox("Proses Sinkronisasi data Server ke Client telah selesai...", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Informasi")
    End Sub
    Private Sub tblKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblKeluar.Click
        Me.Close()
    End Sub
End Class