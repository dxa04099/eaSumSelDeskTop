Imports System.IO
Imports System.Data.SqlClient
'Imports System.Int32
'Imports System.IO.Ports
'Imports System.Drawing.Printing
'Imports Microsoft.Win32
'Imports System.Data
'Imports System.Data.OleDb
Public Class f_UserManagementSetServer
    Private Sub tblKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblKeluar.Click
        End
        Me.Close()
    End Sub
    Private Sub tblTesKoneksi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblTesKoneksi.Click
        If CheckDatabaseExists(mNama_Server.Text.Trim, _
                               mNama_Data_Base.Text.Trim, _
                               mID_.Text.Trim, mPasswordd_1.Text.Trim) = False Then

            MsgBox("Data Base " & mNama_Data_Base.Text.Trim & " tidak ada ")
            'tbl_simpan.Enabled = False
            Exit Sub
        Else
            MsgBox("Koneksi berhasil ..")
            tbl_simpan.Enabled = True
            Exit Sub
        End If
    End Sub
    Public Shared Function CheckDatabaseExists(ByVal server As String, _
                                               ByVal database As String, _
                                               ByVal userid As String, _
                                               ByVal passw As String) As Boolean
        On Error GoTo akhir
        Dim connString As String = ("Integrated Security=True;Data Source=" & server & ";" _
                                  & "Initial Catalog=master;" _
                                  & "User ID=" & userid & "; " _
                                  & "Password=" & passw & ";")
        '& "" _
        'Data Source=chip;Initial Catalog=gaji;User ID=sa;Password=12345

        Dim cmdText As String = ("select * from master.sysdatabases where name='" & database & "'")
        Dim bRet As Boolean = False
        Using sqlConnection As SqlConnection = New SqlConnection(connString)
            sqlConnection.Open()
            Using sqlCmd As SqlCommand = New SqlCommand(cmdText, sqlConnection)
                Using reader As SqlDataReader = sqlCmd.ExecuteReader
                    bRet = reader.HasRows
                End Using
            End Using
        End Using
        Return bRet
        Exit Function
akhir:
        MsgBox(Err.Description, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Informasi")
        bRet = False
        Return bRet
    End Function
    Private Sub tbl_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbl_simpan.Click
        Using writer As StreamWriter = New StreamWriter(My.Application.Info.DirectoryPath & "\config.ini")
            writer.WriteLine("namaserver=" & SimpanPWD(mNama_Server.Text.Trim, "sunarsip"))
            writer.WriteLine("namadatabase=" & mNama_Data_Base.Text.Trim)
            writer.WriteLine("user id=" & SimpanPWD(mID_.Text.Trim, "sunarsip"))
            writer.WriteLine("password=" & SimpanPWD(mPasswordd_1.Text.Trim, "sunarsip"))
        End Using
        Me.Close()
    End Sub

    Private Sub f_UserManagementSetServer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class