Module mdlSimpan_Histori
    Sub SimpanLogin(ByVal uid As String, ByVal kdsimpan As String)
        Dim cn_eSumselSLog As New ADODB.Connection
        If cn_eSumselSLog.State = ConnectionState.Open Then cn_eSumselSLog.Close()
        cn_eSumselSLog.ConnectionString = " " _
       & " Provider=SQLOLEDB.4; " _
       & " Persist Security Info=True; " _
       & " User ID=" & vUserIDDB & "; " _
       & " Password=" & vPasswordDB & "; " _
       & " Initial Catalog=" & vNamaDataBase & "; " _
       & " Data Source = " & vNamaServer & " "
        If cn_eSumselSLog.State = ConnectionState.Closed Then cn_eSumselSLog.Open()

        Dim DeKlare_Data As String = "  set dateformat DMY " _
                            & " Declare  @UserID char(20) " _
                            & " Declare  @komputer char(100) " _
                            & " Declare  @MAC0 char(20) " _
                            & " Declare  @MAC1 char(20) " _
                            & " Declare  @IPAdress char(20) " _
                            & " Declare  @MBId char(20) " _
                            & " Declare  @ProcId char(20) " _
                            & " Declare  @Tanggal datetime " _
                            & "  " _
                    & " Set @UserID = '" & uid & "' " _
                    & " Set @komputer = '" & Environment.MachineName.Trim & "' " _
                    & " Set @MAC0 = '" & MenuUtama.mMAC0.Text.Trim & "' " _
                    & " Set @MAC1 = '" & MenuUtama.mMAC1.Text.Trim & "' " _
                    & " Set @IPAdress = '" & MenuUtama.mIPAdress.Text.Trim & "' " _
                    & " Set @MBId = '" & MenuUtama.mMotherBoardID.Text.Trim & "' " _
                    & " Set @ProcId = '" & MenuUtama.mProcessorID.Text.Trim & "' " _
                    & " Set @Tanggal = '" & str_TanggalServer_DMY() & "' " _
                        & "  " _
                        & " Insert Into yyHis_Login " _
                        & " (UserID,Aktivitas,komputer,MAC0,MAC1,IPAdress,MBId,ProcId,Tanggal) Values " _
                        & " (@UserID,'" & Mid(kdsimpan.Trim, 1, 1) & "', @komputer,@MAC0,@MAC1,@IPAdress,@MBId,@ProcId,@Tanggal) "

        Rs_Simpan.Open(DeKlare_Data, cn_eSumselSLog)
        cn_eSumselSLog.Close()
    End Sub
End Module
