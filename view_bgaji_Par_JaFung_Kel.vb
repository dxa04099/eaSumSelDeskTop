Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class view_bgaji_Par_JaFung_Kel
    Private Sub tbl_Keluar_Click(sender As Object, e As EventArgs) Handles tbl_Keluar.Click
        Me.Close()
    End Sub

    Private Sub view_bgaji_Par_JaFung_Kel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 10
        Me.Left = MenuUtama.Width - (Me.Width + 25)
        Tampil_Data()
    End Sub
    Sub Tampil_Data()
        If cn_Lokal_Tmpl.State = ConnectionState.Closed Then cn_Lokal_Tmpl.Open()
        Dim sql_Kondisi As String = ""
        If mCari.Text.Trim = "" Then
        Else
            sql_Kondisi = " where Kel_JaFung like '%" & mCari.Text.Trim & "%' or Kode_Kel_JaFung like '%" & mCari.Text.Trim & "%' "
        End If

        Dim sql_Perintah As String = " SELECT       " _
            & " Kode_Kel_JaFung as [Kode],  " _
            & " Kel_JaFung as [Kelompok Jabatan Fungsional] " _
            & " FROM          " _
            & " bgaji_Par_JaFung_Kel " & sql_Kondisi _
            & " ORDER BY Kode_Kel_JaFung "


        Dim da As OleDbDataAdapter
        Dim ds As DataSet
        Dim tables As DataTableCollection
        Dim source1 As New BindingSource
        cn_Lokal_Tmpl = New OleDbConnection
        cn_Lokal_Tmpl.ConnectionString = connString_Lokal
        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter(sql_Perintah, cn_Lokal_Tmpl) 'Change items to your database name
        da.Fill(ds, "items") 'Change items to your database name
        Dim view As New DataView(tables(0))
        source1.DataSource = view
        dg_TampilData.DataSource = view

        If cn_Lokal_Tmpl.State = ConnectionState.Open Then cn_Lokal_Tmpl.Close()

        dg_TampilData.Columns(0).Width = (dg_TampilData.Width / 10) * 0.5
        dg_TampilData.Columns(1).Width = (dg_TampilData.Width / 10) * 9.2
        'mCari.Focus()
    End Sub

    Private Sub mCari_TextChanged(sender As Object, e As EventArgs) Handles mCari.TextChanged
        Tampil_Data()
    End Sub

    Private Sub tblGunakan_Click(sender As Object, e As EventArgs) Handles tblGunakan.Click
        If dg_TampilData.RowCount <= 0 Then Exit Sub

        If mKodePanggil.Text = "cgaji_Par_Tunj_fung" Then
            cgaji_Par_Tunj_fung.mKode_Kel_JaFung.Text = dg_TampilData.Item(0, dg_TampilData.CurrentRow.Index).Value
            cgaji_Par_Tunj_fung.mKel_JaFung.Text = dg_TampilData.Item(1, dg_TampilData.CurrentRow.Index).Value

        End If

        If mKodePanggil.Text = "cgaji_Par_Tunj_fung_Khusus" Then
            cgaji_Par_Tunj_fung_Khusus.mKode_Kel_JaFung.Text = dg_TampilData.Item(0, dg_TampilData.CurrentRow.Index).Value
            cgaji_Par_Tunj_fung_Khusus.mKel_JaFung.Text = dg_TampilData.Item(1, dg_TampilData.CurrentRow.Index).Value

        End If
        Me.Close()
    End Sub
End Class