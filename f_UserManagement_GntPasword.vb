Imports System.Text
Imports System.IO
Imports System.Data.SqlClient
Public Class f_UserManagement_GntPasword
    Private Sub tbl_Keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbl_Keluar.Click
        Me.Close()
        'End
    End Sub
    Private Sub f_UserManagement_GntPasword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'mIDUser.Text = MenuUtama.midUser.Text.Trim
        'mNama.Text = MenuUtama.mNama.Text.Trim
        'Tampil_BagForm()
        ''mPwd0.Text = ""
        mPWD1.Text = ""
        mPWD2.Text = ""
        mPwd0.Focus()
    End Sub

    Private Sub tblSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblSimpan.Click
        If mUserID.Text.Trim = "" Then
            MsgBox("id user tidak boleh kosong", MsgBoxStyle.OkOnly, "Informasi")
            Exit Sub
        End If
        '==cek kebenaran pasword 0
        Dim cari As String = "T"
         Dim pwd_tersimpan As String = ""
        If Open_eSumsel() = False Then Exit Sub
        Rs_Baca.Open("Select * from aPar_UserID where UserID ='" & mUserID.Text & "' ", cn_eSumsel)
        If Rs_Baca.RecordCount > 0 Then
            cari = "Y"
            pwd_tersimpan = AmbilPWD(Rs_Baca.Fields("PWD").Value, mUserID.Text)
        End If
        Rs_Baca.Close()

        If pwd_tersimpan <> mPwd0.Text Then
            MsgBox("pasword [lama] salah, Masukan Pasword lama dengan benar..", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
            Exit Sub
        End If
        If cari = "T" Then
            MsgBox("User ID Tidak ditemukan..", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
            Exit Sub
        End If
        'cek kesamaan pwd1 n pwd2
        If mPWD1.Text.Trim <> mPWD2.Text.Trim Then
            MsgBox("pasword [baru] dan konfrmasi password salah, Masukan Pasword Baru dan Konfirmasi Pasword Baru dengan benar..", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
            Exit Sub
        End If

        Rs_Baca.Open("update aPar_UserID set pwd = '" & SimpanPWD(mPWD1.Text.Trim, mUserID.Text.Trim) & "' where USerID ='" & mUserID.Text.Trim & "' ", cn_eSumsel)
        Close_eSumsel()
        '==========
        '0=Login, 2=Keluar Aplikasi / Tutup Aplikasi, 1 = Ganti PSW, 3 = Log OFF
        SimpanLogin(mUserID.Text.Trim, "1")
        '==========
        MsgBox("pasword telah diganti dengan password baru..", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Informasi")

        Me.Close()
    End Sub
     
End Class