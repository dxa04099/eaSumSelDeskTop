Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class view_cPar_PKKKKD_3Kecamatan
    Private Sub tbl_Keluar_Click(sender As Object, e As EventArgs) Handles tbl_Keluar.Click
        Me.Close()
    End Sub
    Sub Tampil_Data()
        Dim sql_kondisi_rek = ""
        If mKode_Provinsi.Text.Trim <> "" Then
            sql_kondisi_rek = sql_kondisi_rek & " and Kode_Provinsi = '" & mKode_Provinsi.Text.Trim & "' "
        End If
        If mKode_KabKota.Text.Trim <> "" Then
            sql_kondisi_rek = sql_kondisi_rek & "and Kode_KabKota = '" & mKode_KabKota.Text.Trim & "' "
        End If


        Dim sql_Kondisi As String = ""
        If mCari.Text.Trim = "" Then
            If sql_kondisi_rek.Trim <> "" Then
                sql_Kondisi = "where " & Mid(sql_kondisi_rek.Trim, 4, sql_kondisi_rek.Trim.Length - 3)
            End If
        Else
            sql_Kondisi = " where (Nama_Kecamatan like '%" & mCari.Text.Trim & "%' ) " & sql_kondisi_rek.Trim
        End If

        Dim sql_Perintah As String = " SELECT       " _
                        & "      " _
                        & " Kode_Provinsi & '.' &  " _
                        & " Kode_KabKota & '.' &  " _
                        & " Kode_Kecamatan  as [kode],  " _
                        & " Nama_Kecamatan as [Kecamatan], " _
                        & " Kode_Provinsi,  " _
                        & " Kode_KabKota,  " _
                        & " Kode_Kecamatan  " _
                        & "  " _
                        & " FROM   cPar_PKKKKD_3Kecamatan " & sql_Kondisi _
                        & " ORDER BY  " _
                        & " Kode_Provinsi,  " _
                        & " Kode_KabKota,  " _
                        & " Kode_Kecamatan "

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

        dg_TampilData.Columns(0).Width = (dg_TampilData.Width / 10) * 1.5
        dg_TampilData.Columns(1).Width = (dg_TampilData.Width / 10) * 8

        dg_TampilData.Columns(2).Visible = False
        dg_TampilData.Columns(3).Visible = False
        dg_TampilData.Columns(4).Visible = False
        'dg_TampilData.Columns(1).Visible = False


    End Sub

    Private Sub mCari_TextChanged(sender As Object, e As EventArgs) Handles mCari.TextChanged
        Tampil_Data()
    End Sub

    Private Sub tblGunakan_Click(sender As Object, e As EventArgs) Handles tblGunakan.Click
        If dg_TampilData.RowCount <= 0 Then Exit Sub
        If mKodePanggil.Text.Trim = "cPar_PKKKKD_4KelDesa" Then
            cPar_PKKKKD_4KelDesa.mKode_Kecamatan.Text = dg_TampilData.Item(4, dg_TampilData.CurrentRow.Index).Value
            cPar_PKKKKD_4KelDesa.mNama_Kecamatan.Text = dg_TampilData.Item(1, dg_TampilData.CurrentRow.Index).Value
            'aaa.kd__.Text  = dg_TampilData.Item(0, dg_TampilData.CurrentRow.Index).Value
            'aaa.kd__.Text  = dg_TampilData.Item(1, dg_TampilData.CurrentRow.Index).Value
        End If
        Me.Close()

    End Sub

    Private Sub view_cPar_PKKKKD_3Kecamatan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 10
        Me.Left = MenuUtama.Width - (Me.Width + 25)
        Tampil_Data()
    End Sub
End Class