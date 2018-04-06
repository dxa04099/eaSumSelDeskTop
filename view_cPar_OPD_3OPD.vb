Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class view_cPar_OPD_3OPD
    Private Sub tbl_Keluar_Click(sender As Object, e As EventArgs) Handles tbl_Keluar.Click
        Me.Close()
    End Sub
    Sub Tampil_Data()
        If cn_Lokal_Tmpl.State = ConnectionState.Closed Then cn_Lokal_Tmpl.Open()

        Dim sql_kondisi_rek = ""
        If mKode_Urusan.Text.Trim <> "" Then
            sql_kondisi_rek = sql_kondisi_rek & " and Kode_Urusan = '" & mKode_Urusan.Text.Trim & "' "
        End If
        If mKode_Bidang.Text.Trim <> "" Then
            sql_kondisi_rek = sql_kondisi_rek & "and Kode_Bidang = '" & mKode_Bidang.Text.Trim & "' "
        End If

        Dim sql_Kondisi As String = ""
        If mCari.Text.Trim = "" Then
            If sql_kondisi_rek.Trim <> "" Then
                sql_Kondisi = "where " & Mid(sql_kondisi_rek.Trim, 4, sql_kondisi_rek.Trim.Length - 3)
            End If
        Else
            sql_Kondisi = " where (Nama_OPD like '%" & mCari.Text.Trim & "%' ) " & sql_kondisi_rek.Trim
        End If


        Dim sql_Perintah As String = " SELECT       " _
                    & "       " _
                    & " Kode_Urusan & '.' &   " _
                    & " Kode_Bidang & '.' &   " _
                    & " Kode_OPD   as [Kode],  " _
                    & " Nama_OPD as [Nama Sub-Sub OPD], " _
                    & " Kode_Urusan,  " _
                    & " Kode_Bidang,  " _
                    & " Kode_OPD,  " _
                    & " Kode_Fungsi " _
                    & " FROM          " _
                    & " cPar_OPD_3OPD " & sql_Kondisi _
                    & " ORDER BY  " _
                    & " Kode_Urusan,  " _
                    & " Kode_Bidang,  " _
                    & " Kode_OPD "

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

        dg_TampilData.Columns(0).Width = (dg_TampilData.Width / 10) * 1.8
        dg_TampilData.Columns(1).Width = (dg_TampilData.Width / 10) * 7.7

        dg_TampilData.Columns(2).Visible = False
        dg_TampilData.Columns(3).Visible = False
        dg_TampilData.Columns(4).Visible = False
        'dg_TampilData.Columns(5).Visible = False
        'dg_TampilData.Columns(6).Visible = False
    End Sub

    Private Sub mCari_TextChanged(sender As Object, e As EventArgs) Handles mCari.TextChanged
        Tampil_Data()
    End Sub

    Private Sub tblGunakan_Click(sender As Object, e As EventArgs) Handles tblGunakan.Click
        If dg_TampilData.RowCount <= 0 Then Exit Sub
        If mKodePanggil.Text = "cPar_OPD_4Sub_OPD" Then
            cPar_OPD_4Sub_OPD.mKode_Urusan.Text = dg_TampilData.Item(2, dg_TampilData.CurrentRow.Index).Value
            cPar_OPD_4Sub_OPD.mKode_Bidang.Text = dg_TampilData.Item(3, dg_TampilData.CurrentRow.Index).Value
            cPar_OPD_4Sub_OPD.mKode_OPD.Text = dg_TampilData.Item(4, dg_TampilData.CurrentRow.Index).Value
            cPar_OPD_4Sub_OPD.mNama_OPD.Text = dg_TampilData.Item(1, dg_TampilData.CurrentRow.Index).Value
            cPar_OPD_4Sub_OPD.mKode_Fungsi.Text = dg_TampilData.Item(5, dg_TampilData.CurrentRow.Index).Value
            cPar_OPD_4Sub_OPD.mKode_Fungsi_getName()

        End If
        Me.Close()
    End Sub

    Private Sub view_cPar_OPD_3OPD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 10
        Me.Left = MenuUtama.Width - (Me.Width + 25)
        Tampil_Data()
    End Sub
End Class