Imports System.Text
Imports System.IO
Imports System.String
Imports System.Data.SqlClient
Public Class f_LogON
    Private Sub mBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mBatal.Click
        Me.Close()
        End
    End Sub
    Private Sub mthnAnggaran_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mthnAnggaran.KeyPress
        e.Handled = True
    End Sub
    Private Sub f_LogON_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim myFileV As FileVersionInfo = FileVersionInfo.GetVersionInfo(My.Application.Info.DirectoryPath + "\si_SPPDRUN.exe")
        LblVersi.Text = "Versi : 0.0.0.0" '& myFileV.FileVersion.ToString.Trim

        ' PilhMenuFalse()
        'pb_LogOn.Image = Nothing
        If Open_eSumsel() = False Then Exit Sub
        Rs_Baca.Open("select Logo from d0Tr_Pemda  where Aktif = '1' ", cn_eSumsel)
        If Rs_Baca.RecordCount > 0 Then
            Rs_Baca.MoveFirst()
            If IsDBNull(Rs_Baca.Fields("logo").Value) = False Then
                Dim arrPicture_GB_01() As Byte = CType(Rs_Baca.Fields("logo").Value, Byte())
                Dim ms_GB_01 As New MemoryStream(arrPicture_GB_01)
                pb_LogOn.Image = Image.FromStream(ms_GB_01)
                'M'e.BackgroundImage = Image.FromStream(ms_GB_01)
                ms_GB_01.Close()
                ms_GB_01.Dispose()
                ms_GB_01.Close()
            End If
        End If
        Rs_Baca.Close()
        Close_eSumsel()


        'mIdUser.Text = "admin"
        'mPassword.Text = "hatori"
    End Sub
    Public Function FieldToFile(ByVal sFileName As String, ByVal theField As Object) As Boolean
        ' Exceptions are handled by the caller
        If theField IsNot DBNull.Value Then
            Using oStream As New System.IO.FileStream(sFileName, IO.FileMode.Create, IO.FileAccess.Write)
                If oStream IsNot Nothing Then
                    Dim aBytes As Byte()
                    aBytes = DirectCast(theField, Byte())
                    oStream.Write(aBytes, 0, aBytes.Length)
                    oStream.Close()
                End If
            End Using
        End If
        Return True
    End Function
    Private Sub mOke_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mOke.Click
        If mthnAnggaran.Text.Trim = "" Then
            MsgBox("tahun anggaran harus diisi...", MsgBoxStyle.OkOnly, "informasi")
            Exit Sub
        End If

        If mUserID.Text.Trim = "" Or mPWD.Text.Trim = "" Or mUserID.Text.Trim = "xxxxxxxxxxxxxxxxxx" Then Exit Sub
        Dim datakosong As String = "T"
        Dim cari As String = "T"

        If Open_eSumsel() = False Then Exit Sub
        Rs_Baca.Open("Select * from aPar_UserID where UserID ='" & mUserID.Text & "' ", cn_eSumsel)
        'and " _
        '& " pwd = '" & UbahPswKeAsci(mPassword.Text.Trim, mIdUser.Text.Trim) & "'  and " _
        '& " IdUserEntry <> 'hapus' ", cn_SPPD)
        If Rs_Baca.RecordCount > 0 Then
            If mPWD.Text = AmbilPWD(Rs_Baca.Fields("PWD").Value, mUserID.Text) Then
                'MsgBox(mPWD.Text & "=" & AmbilPWD(Rs_Baca.Fields("PWD").Value, mUserID.Text))
                cari = "Y"
                MenuUtama.mKd_Level.Text = UbahPswKechr(Rs_Baca.Fields("Kd_Level").Value, mUserID.Text)
                MenuUtama.mNama.Text = Rs_Baca.Fields("Nama").Value.ToString.Trim
                MenuUtama.mUserID.Text = mUserID.Text

                If MenuUtama.mKd_Level.Text.Trim = "1" Or MenuUtama.mKd_Level.Text.Trim = "2" Then
                    MenuUtama.FileMenu_UserManagement.Enabled = True
                Else
                    MenuUtama.FileMenu_UserManagement.Enabled = False
                End If
                'Else
                'MsgBox(mPWD.Text & "=" & AmbilPWD(Rs_Baca.Fields("PWD").Value, mUserID.Text))
            End If
        End If
        Rs_Baca.Close()


        If cari = "Y" Then
            'cari apakah sudah pernah login
            Dim Pernah_Login As String = "T"
            Rs_Baca.Open("select UserID from yyHis_Login where UserID = '" & mUserID.Text.Trim & "'", cn_eSumsel)
            If Rs_Baca.RecordCount > 0 Then
                Rs_Baca.MoveFirst()
                If IsDBNull(Rs_Baca.Fields("UserID").Value) = False Then
                    Pernah_Login = "Y"
                End If
            End If
            Rs_Baca.Close()
            If Pernah_Login = "T" Then
                f_UserManagement_GntPasword.mUserID.Text = mUserID.Text
                f_UserManagement_GntPasword.mPwd0.Text = mPWD.Text.Trim
                f_UserManagement_GntPasword.mNama.Text = MenuUtama.mNama.Text

                MsgBox("Selamat Datang di e-Sumsel, Anda baru pertama Log In, silahkan ganti Pasword anda dengan Password baru...", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
                'Me.Close()
                f_UserManagement_GntPasword.ShowDialog(Me)
            End If

             
            '==========
            SimpanLogin(mUserID.Text.Trim, "0") ' 0= Login
            '==========
            MenuUtama.Visible = True
            Me.Close()
        Else
            MsgBox("id user / pasword salah..", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "informasi")
        End If

        Close_eSumsel()

    End Sub
    Sub PilhMenuFalse()

    End Sub
    Sub Pilihmenuseuaihak()

    End Sub
    Private Sub mPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mPWD.KeyPress
        If e.KeyChar = Chr(13) Then
            mOke_Click(mOke, New EventArgs)
        End If
    End Sub
End Class