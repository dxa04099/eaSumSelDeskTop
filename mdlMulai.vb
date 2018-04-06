Imports System
Imports System.Drawing.Printing
Imports Microsoft.Win32
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
 Module mdlMulai
    Public Rs_Baca As New ADODB.Recordset
    Public Rs_Simpan As New ADODB.Recordset

    Public cn_Lokal As New ADODB.Connection
    Public connString_Lokal As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " & My.Application.Info.DirectoryPath & "\dbLokal.mdb" & ";"


    Public cn_Lokal_Tmpl As New OleDbConnection(connString_Lokal)

    '"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\Jimmy\Documents\Merchandise.accdb"

    Public cn_eSumsel As New ADODB.Connection
    Public cn_eSumsel_Tmpl As New SqlConnection( _
    " User ID='sa';" _
    & " Data Source= LocalHost;" _
    & " Initial Catalog=db_Dokumen;" _
    & " Workstation ID= LocalHost ")
    Public vNamaServer As String = ""
    Public vNamaDataBase As String = ""
    Public vUserIDDB As String = ""
    Public vPasswordDB As String = ""
    Sub Close_eSumsel_Tampil()
        If cn_eSumsel_Tmpl.State = ConnectionState.Open Then cn_eSumsel_Tmpl.Close()
    End Sub
    Function ValChip(ByRef Nilai As String) As Decimal
        If Nilai.Trim = "" Then
            ValChip = 0
            Exit Function
        End If

        Dim minnes As String = "T"
        Nilai = Trim(Nilai)
        If Mid(Nilai, 1, 1) = "-" Then minnes = "Y"

        Dim x As Integer
        Dim Nilaia As String
        Dim Nilaib As String
        Dim NilaiNol As String
        Dim Pembagi As String
        Nilaia = ""
        Nilaib = ""
        NilaiNol = "000000000000000000000000000"
        'MsgBox(Mid(Format("1000000000", "###,###,###.00"), 2, 1))
        If Mid(Format(1000000000, "###,###,###.00"), 2, 1) = "." Then

            For x = 1 To Len(Nilai)
                If Mid(Nilai, x, 1) = "0" Or Mid(Nilai, x, 1) = "1" Or Mid(Nilai, x, 1) = "2" Or Mid(Nilai, x, 1) = "3" Or Mid(Nilai, x, 1) = "4" Or Mid(Nilai, x, 1) = "5" Or Mid(Nilai, x, 1) = "6" Or Mid(Nilai, x, 1) = "7" Or Mid(Nilai, x, 1) = "8" Or Mid(Nilai, x, 1) = "9" Then
                    Nilaia = Nilaia & Mid(Nilai, x, 1)
                Else
                    If Mid(Nilai, x, 1) = "," Then
                        '123568,123
                        '1234567890
                        Nilaib = Trim(Mid(Nilai, x + 1, Len(Nilai) - (x)))
                        Exit For
                    End If
                End If
            Next

            If Nilaib <> "" Then
                Pembagi = "1" & Mid(NilaiNol, 1, Len(Nilaib))
                ValChip = Val(Nilaia) + (Val(Nilaib) / Val(Pembagi))
            Else
                ValChip = Val(Nilaia)
            End If
            If minnes = "Y" Then ValChip = ValChip * -1
        Else
            For x = 1 To Len(Nilai)
                If Mid(Nilai, x, 1) = "0" Or Mid(Nilai, x, 1) = "1" Or Mid(Nilai, x, 1) = "2" Or Mid(Nilai, x, 1) = "3" Or Mid(Nilai, x, 1) = "4" Or Mid(Nilai, x, 1) = "5" Or Mid(Nilai, x, 1) = "6" Or Mid(Nilai, x, 1) = "7" Or Mid(Nilai, x, 1) = "8" Or Mid(Nilai, x, 1) = "9" Then
                    Nilaia = Nilaia & Mid(Nilai, x, 1)
                Else
                    If Mid(Nilai, x, 1) = "." Then
                        '123568,12
                        '123456789
                        Nilaib = Trim(Mid(Nilai, x + 1, Len(Nilai) - (x)))
                        Exit For
                    End If
                End If
            Next

            If Nilaib <> "" Then
                Pembagi = "1" & Mid(NilaiNol, 1, Len(Nilaib))
                ValChip = Val(Nilaia) + (Val(Nilaib) / Val(Pembagi))
            Else
                ValChip = Val(Nilaia)
            End If
            If minnes = "Y" Then ValChip = ValChip * -1
        End If
    End Function
    Public Function Open_eSumsel_Tampil() As Boolean
        Open_eSumsel_Tampil = False
        If My.Computer.Network.IsAvailable Then
            'MsgBox("Komputer ")
        Else
            'MsgBox("Komputer ini tidak terkoneksi ke INTERNET...", MsgBoxStyle.OkOnly, "Informasi")
            'Open_eSumsel = False
            'Exit Function
        End If
        If cn_eSumsel_Tmpl.State = ConnectionState.Open Then cn_eSumsel_Tmpl.Close()
        cn_eSumsel_Tmpl.ConnectionString = " User ID='" & vUserIDDB & "';" _
        & " Password=" & vPasswordDB & "; " _
        & " Data Source= " & vNamaServer & ";" _
        & " Initial Catalog=" & vNamaDataBase & " ;" _
        & " Workstation ID= " & vNamaServer & " "

        If cn_eSumsel_Tmpl.State = ConnectionState.Closed Then cn_eSumsel_Tmpl.Open()
        Open_eSumsel_Tampil = True
    End Function
    Public Function Open_eSumsel() As Boolean
        Open_eSumsel = False
        If My.Computer.Network.IsAvailable Then
            'MsgBox("Komputer ")
        Else
            'MsgBox("Komputer ini tidak terkoneksi ke INTERNET...", MsgBoxStyle.OkOnly, "Informasi")
            'Open_eSumsel = False
            'Exit Function
        End If
        If cn_eSumsel.State = ConnectionState.Open Then cn_eSumsel.Close()
        cn_eSumsel.ConnectionString = " " _
        & " Provider=SQLOLEDB.4; " _
        & " Persist Security Info=True; " _
        & " User ID=" & vUserIDDB & "; " _
        & " Password=" & vPasswordDB & "; " _
        & " Initial Catalog=" & vNamaDataBase & "; " _
        & " Data Source = " & vNamaServer & " "
        If cn_eSumsel.State = ConnectionState.Closed Then cn_eSumsel.Open()
        Open_eSumsel = True
    End Function
    Sub Close_eSumsel()
        If cn_eSumsel.State = ConnectionState.Open Then cn_eSumsel.Close()
    End Sub
    Function UbahPswKeAsci(ByVal mmxxPasword As String, ByVal mmIdPassword As String) As String
        UbahPswKeAsci = ""
        Dim AscUjung_IdPws As Integer = 0

        AscUjung_IdPws = Asc(Mid(mmIdPassword.Trim, mmIdPassword.Trim.Length, 1)) Mod 10

        For x = 1 To mmxxPasword.Trim.Length
            UbahPswKeAsci = UbahPswKeAsci & Chr(Asc(Mid(mmxxPasword.Trim, x, 1)) + AscUjung_IdPws + 127)
        Next
    End Function
    Function UbahPswKechr(ByVal mmxxPasword As String, ByVal mmIdPassword As String) As String
        UbahPswKechr = ""
        Dim AscUjung_IdPws As Integer = 0
        AscUjung_IdPws = Asc(Mid(mmIdPassword.Trim, mmIdPassword.Trim.Length, 1)) Mod 10
        For x = 1 To mmxxPasword.Trim.Length

            UbahPswKechr = UbahPswKechr & Chr(Asc(Mid(mmxxPasword.Trim, x, 1)) - AscUjung_IdPws - 127)

        Next
    End Function
    Function TanggalServer() As DateTime
        Dim cn_eSumselTanggal As New ADODB.Connection
        cn_eSumselTanggal.ConnectionString = " " _
       & " Provider=SQLOLEDB.4; " _
       & " Persist Security Info=True; " _
       & " User ID=" & vUserIDDB & "; " _
       & " Password=" & vPasswordDB & "; " _
       & " Initial Catalog=" & vNamaDataBase & "; " _
       & " Data Source = " & vNamaServer & " "
        If cn_eSumselTanggal.State = ConnectionState.Closed Then cn_eSumselTanggal.Open()

        Dim Rs_tt As New ADODB.Recordset
        Rs_tt = New ADODB.Recordset
        Rs_tt.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        Rs_tt.CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        Rs_tt.LockType = ADODB.LockTypeEnum.adLockOptimistic

        Rs_tt.Open("select GETDATE() as tanggal", cn_eSumselTanggal)
        TanggalServer = Rs_tt.Fields("tanggal").Value
        Rs_tt.Close()
        cn_eSumselTanggal.Close()
    End Function
    Function str_TanggalServer_DMY() As String
        Dim cn_eSumselTanggal_STR As New ADODB.Connection
        cn_eSumselTanggal_STR.ConnectionString = " " _
       & " Provider=SQLOLEDB.4; " _
       & " Persist Security Info=True; " _
       & " User ID=" & vUserIDDB & "; " _
       & " Password=" & vPasswordDB & "; " _
       & " Initial Catalog=" & vNamaDataBase & "; " _
       & " Data Source = " & vNamaServer & " "
        If cn_eSumselTanggal_STR.State = ConnectionState.Closed Then cn_eSumselTanggal_STR.Open()

        Dim Rs_tt As New ADODB.Recordset
        Rs_tt = New ADODB.Recordset
        Rs_tt.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        Rs_tt.CursorType = ADODB.CursorTypeEnum.adOpenDynamic
        Rs_tt.LockType = ADODB.LockTypeEnum.adLockOptimistic

        Rs_tt.Open("select GETDATE() as tanggal", cn_eSumselTanggal_STR)

        Dim date_TanggalServer As Date = Rs_tt.Fields("tanggal").Value

        str_TanggalServer_DMY = Format(date_TanggalServer.Day, "00") & "-" _
                & Format(date_TanggalServer.Month, "00") & "-" _
                & Format(date_TanggalServer.Year, "0000") & " " _
                & Format(date_TanggalServer.Hour, "00") & ":" _
                & Format(date_TanggalServer.Minute, "00") & ":" _
                & Format(date_TanggalServer.Second, "00")

        Rs_tt.Close()
        cn_eSumselTanggal_STR.Close()
    End Function

    Dim Misal_Pjg_PWD As String = "abcdefghijklmnopqrstuvwxy"
    Public Function SimpanPWD(ByVal cPasword As String, ByVal cIdPassword As String)
        'abcdefghijklmnopqrstuvwxy
        '1234567890123456789012345

        Dim Pnj_PWD As String = Chr(Asc(Mid(Misal_Pjg_PWD, cPasword.Length, 1)) + 127)

        SimpanPWD = ""
        Dim NilaiPWD As Integer = 0

        For xx = 1 To cPasword.Length
            NilaiPWD = NilaiPWD + Asc(Mid(cPasword, xx, 1))
        Next
        For xx = 1 To cIdPassword.Length
            NilaiPWD = NilaiPWD + Asc(Mid(cIdPassword, xx, 1))
        Next
        NilaiPWD = NilaiPWD / (cPasword.Length + cIdPassword.Length)
        'Form1.mNAsciiPWDID.Text = NilaiPWD


        Dim cPaswordConvert As String = ""
        For xy = 1 To cPasword.Length
            'MsgBox(xy)
            cPaswordConvert = cPaswordConvert & Chr(Asc(Mid(cPasword, xy, 1)) + NilaiPWD)
            'Form1.DataGridView1.Item(2, xy - 1).Value = Asc(Mid(cPasword, xy, 1))
            'Form1.DataGridView1.Item(3, xy - 1).Value = Asc(Mid(cPasword, xy, 1)) + NilaiPWD

            'Form1.DataGridView1.Item(4, xy - 1).Value = Chr(Asc(Mid(cPasword, xy, 1)) + NilaiPWD)
        Next
        'Form1.mPWDTersimpan.Text = cPaswordConvert


        Dim PosCari As Integer = 1
        Dim PosPWD(25) As Integer
        For xx = 1 To 25
            PosPWD(xx) = 0
        Next

        Dim B As New Random
        Dim cukup As String = "T"
        Do While cukup <> "Y"
            PosCari = B.Next(120)
            Dim CaridiArai As String = "T"
            For x = 1 To 25
                If PosPWD(x) = PosCari Then
                    CaridiArai = "Y"
                    Exit For
                End If
            Next
            If CaridiArai = "T" Then
                For x = 1 To 25
                    If PosPWD(x) = 0 Then
                        PosPWD(x) = PosCari
                        Exit For
                    End If
                Next
            End If
            ''cek apakah sudah terisi semua
            CaridiArai = "T"
            For x = 1 To 25
                If PosPWD(x) = 0 Then CaridiArai = "Y"
            Next
            If CaridiArai = "T" Then cukup = "Y"
        Loop

        'For xx = 1 To 25
        'Form1.DataGridView1.Item(0, xx - 1).Value = xx
        'Form1.DataGridView1.Item(1, xx - 1).Value = PosPWD(xx)
        ' Next
        Dim mmpwdpostampil As String = ""
        'Form1.mPWDPosisiTmpl.Text = ""
        For xvx = 1 To 25
            mmpwdpostampil = mmpwdpostampil + Chr(PosPWD(xvx) + 128)
            'MsgBox(Chr(PosPWD(xvx) + 127))
        Next
        'Form1.mPWDPosisiTmpl.Text = mmpwdpostampil


        Dim pwdgabung As String = KarakterTampil()
        Dim pwdgabung_Awal As String = ""
        Dim pwdgabung_Ujung As String = ""
        Dim pwdgabung_tengah As String = ""
        'Dim PosisiPwd As Integer = 0
        For by = 1 To cPaswordConvert.Length
            'PosisiPwd = PosPWD(by) + NilaiPWD
            pwdgabung_Awal = Mid(pwdgabung, 1, PosPWD(by) - 1)
            pwdgabung_Ujung = Mid(pwdgabung, PosPWD(by) + 1, pwdgabung.Length - PosPWD(by))
            pwdgabung_tengah = Mid(cPaswordConvert, by, 1)
            '1234567890

            pwdgabung = pwdgabung_Awal & pwdgabung_tengah & pwdgabung_Ujung
        Next

        SimpanPWD = mmpwdpostampil & pwdgabung & Pnj_PWD & Chr(NilaiPWD)

        Dim Pnj_pwd_int As Integer = Asc(Mid(SimpanPWD, 151, 1)) - 127 'Chr(Asc(cPasword.Length) + 127)

        'Dim Misal_Pjg_PWD As String = "abcdefghijklmnopqrstuvwxy"
        'Dim Pnj_PWD As String = Chr(Asc(Mid(Misal_Pjg_PWD, cPasword.Length, 1)) + 127)


    End Function
    Public Function AmbilPWD(ByVal cPasword As String, ByVal cIdPassword As String)
        AmbilPWD = ""
        'Pnj_pwd_int=====================================================================================================
        Dim Pnj_pwd_int As Integer = 0 '
        Dim pwd_asc151 As String = Mid(cPasword, 151, 1)
        For xx = 1 To 25
            If Mid(Misal_Pjg_PWD, xx, 1) = Chr(Asc(pwd_asc151) - 127) Then
                Pnj_pwd_int = xx
                Exit For
            End If
        Next
        'MsgBox(pwd_asc151 & "-" & Asc(pwd_asc151) - 127 & "-" & Chr(Asc(pwd_asc151) - 127) & "-" & Pjg_pwd)
        'NilaiPWD=====================================================================================================

        Dim NilaiPWD As Integer = Asc(Mid(cPasword, 152, 1))

        'For xx = 1 To cPasword.Length '
        ' NilaiPWD = NilaiPWD + Asc(Mid(cPasword, xx, 1))
        ' Next
        'For xx = 1 To cIdPassword.Length
        ' NilaiPWD = NilaiPWD + Asc(Mid(cIdPassword, xx, 1))
        ' Next
        ' NilaiPWD = NilaiPWD / (cPasword.Length + cIdPassword.Length)

        'PosPWD()=====================================================================================================

        'Dim PosCari As Integer = 1
        Dim PosPWD(25) As Integer
        For xx = 1 To 25
            PosPWD(xx) = 0
        Next

        '=Cari Posisi Pwd
        For xvx = 1 To 25
            PosPWD(xvx) = Asc(Mid(cPasword, xvx, 1)) - 128 ' Asc(Mid(cPasword, xvx, 1)) - 128
            'MsgBox("Posisi PWD = " & PosPWD(xvx))
        Next
        'PWDTampil=====================================================================================================
        Dim PWDTampil As String = ""
        For yy = 1 To Pnj_pwd_int
            PWDTampil = PWDTampil & Mid(cPasword, PosPWD(yy) + 25, 1)
            'MsgBox(PosPWD(yy) & "-" & )
        Next
        'mmpwdpostampil = mmpwdpostampil + Chr(PosPWD(xvx) + 128)

        'cPaswordConvert=====================================================================================================
        Dim cPaswordConvert As String = ""
        Dim cPwd1 As String = ""
        For xy = 1 To PWDTampil.Length
            cPwd1 = Mid(PWDTampil, xy, 1)


            cPaswordConvert = cPaswordConvert & Chr(Asc(cPwd1) - NilaiPWD)
            ' MsgBox("NilaiPWD =" & NilaiPWD & ",  " & Asc(cPwd1) - NilaiPWD)
            'cPaswordConvert = cPaswordConvert & Chr(  Asc(  Mid(cPasword, xy, 1)   ) + NilaiPWD)
        Next

        AmbilPWD = cPaswordConvert


    End Function
    Public Function KarakterTampil() As String
        KarakterTampil = ""
        Dim a As New Random
        Do While KarakterTampil.Length <= 125
            Dim aa As Integer = a.Next(127)
            'Dim psn = MsgBox(aa.ToString & "=" & Asc(aa + 127) & "=" & Chr(aa + 127), MsgBoxStyle.YesNo, "informasi")
            'If psn = MsgBoxResult.Yes Then Exit Function
            KarakterTampil = KarakterTampil & Chr(aa + 127)
        Loop
        'KarakterTampil = "12345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345"
        KarakterTampil = Mid(KarakterTampil, 1, 125)
    End Function
    Public Function CariDatapadFiletext(ByVal FullPath As String, ByVal ygdicari As String)
        Dim fileReader As StreamReader
        Dim content As String = ""
        Dim cari As String = "T"
        Try
            fileReader = New StreamReader(FullPath)
            Do While fileReader.EndOfStream = False
                content = fileReader.ReadLine()
                If ygdicari = Mid(content, 1, ygdicari.Length) Then
                    cari = "Y"
                    Exit Do
                End If

            Loop
            fileReader.Close()
        Catch x As Exception
            MsgBox(x.Message)
        End Try

        Dim i As Integer = 0
        For i = 1 To content.Length
            If Mid(content, i, 1) = "=" Then
                content = Mid(content, i + 1, content.Length - i).Trim
                'MsgBox(content)
                Exit For
            End If
        Next
        If cari = "T" Then content = ""
        Return content
    End Function
End Module
