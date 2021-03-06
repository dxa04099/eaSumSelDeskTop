﻿Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class view_cPar_OPD_5Sub_Sub_OPD
    Private Sub tbl_Keluar_Click(sender As Object, e As EventArgs) Handles tbl_Keluar.Click
        Me.Close()
    End Sub
    Sub Tampil_Data(mmPilihan As Integer)

        If cn_Lokal_Tmpl.State = ConnectionState.Closed Then cn_Lokal_Tmpl.Open()
        '1=Keu, 2=Gaji_PNS, 3=TPP, 4=Gaji_Non_PNS, 5=Perjadin, 6=Bos, 7=BLUD

        Dim mmKondisi_Pilih As String = " and Keu = '1'"
        If mmPilihan = 1 Then mmKondisi_Pilih = " and Keu = '1'"
        If mmPilihan = 2 Then mmKondisi_Pilih = " and Gaji_PNS = '1'"
        If mmPilihan = 3 Then mmKondisi_Pilih = " and TPP = '1'"
        If mmPilihan = 4 Then mmKondisi_Pilih = " and Gaji_Non_PNS = '1'"
        If mmPilihan = 5 Then mmKondisi_Pilih = " and Perjadin = '1'"
        If mmPilihan = 6 Then mmKondisi_Pilih = " and Bos = '1'"
        If mmPilihan = 7 Then mmKondisi_Pilih = " and BLUD = '1'"

        Dim sql_kondisi_rek = ""
        If mKode_Urusan.Text.Trim <> "" Then
            sql_kondisi_rek = sql_kondisi_rek & " and Kode_Urusan = '" & mKode_Urusan.Text.Trim & "' "
        End If
        If mKode_Bidang.Text.Trim <> "" Then
            sql_kondisi_rek = sql_kondisi_rek & "and Kode_Bidang = '" & mKode_Bidang.Text.Trim & "' "
        End If

        If mKode_OPD.Text.Trim <> "" Then
            sql_kondisi_rek = sql_kondisi_rek & "and Kode_OPD = '" & mKode_OPD.Text.Trim & "' "
        End If
        If mKode_Sub_OPD.Text.Trim <> "" Then
            sql_kondisi_rek = sql_kondisi_rek & "and Kode_Sub_OPD = '" & mKode_Sub_OPD.Text.Trim & "' "
        End If
        Dim sql_Kondisi As String = ""
        If mCari.Text.Trim = "" Then
            If sql_kondisi_rek.Trim <> "" Then
                sql_Kondisi = "where " & Mid(sql_kondisi_rek.Trim, 4, sql_kondisi_rek.Trim.Length - 3) & mmKondisi_Pilih
            End If
        Else
            sql_Kondisi = " where  Nama_Sub_Sub_OPD like '%" & mCari.Text.Trim & "%'  " & sql_kondisi_rek.Trim & mmKondisi_Pilih
        End If


        Dim sql_Perintah As String = " SELECT       " _
                    & "       " _
                    & " Kode_Urusan & '.' &   " _
                    & " Kode_Bidang & '.' &   " _
                    & " Kode_OPD & '.' &  " _
                    & " Kode_Sub_OPD & '.' &  " _
                    & " Kode_Sub_Sub_OPD as [Kode],  " _
                    & " Nama_Sub_Sub_OPD as [Nama Sub-Sub OPD], " _
                    & " Kode_Urusan,  " _
                    & " Kode_Bidang,  " _
                    & " Kode_OPD,  " _
                    & " Kode_Sub_OPD,  " _
                    & " Kode_Sub_Sub_OPD " _
                    & " FROM          " _
                    & " cPar_OPD_5Sub_Sub_OPD " & sql_Kondisi _
                    & " ORDER BY  " _
                    & " Kode_Urusan,  " _
                    & " Kode_Bidang,  " _
                    & " Kode_OPD,  " _
                    & " Kode_Sub_OPD,  " _
                    & " Kode_Sub_Sub_OPD "

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
        dg_TampilData.Columns(5).Visible = False
        dg_TampilData.Columns(6).Visible = False
    End Sub

    Private Sub mCari_TextChanged(sender As Object, e As EventArgs) Handles mCari.TextChanged
        Tampil_Data(mPilihan.Text.Trim)
    End Sub

    Private Sub tblGunakan_Click(sender As Object, e As EventArgs) Handles tblGunakan.Click
        If dg_TampilData.RowCount <= 0 Then Exit Sub
        If mKodePanggil.Text.Trim = "d0Tr_Dokumen_Pendukung" Then
            d0Tr_Dokumen_Pendukung.mKode_Urusan.Text = dg_TampilData.Item(2, dg_TampilData.CurrentRow.Index).Value
            d0Tr_Dokumen_Pendukung.mKode_Bidang.Text = dg_TampilData.Item(3, dg_TampilData.CurrentRow.Index).Value
            d0Tr_Dokumen_Pendukung.mKode_OPD.Text = dg_TampilData.Item(4, dg_TampilData.CurrentRow.Index).Value
            d0Tr_Dokumen_Pendukung.mKode_Sub_OPD.Text = dg_TampilData.Item(5, dg_TampilData.CurrentRow.Index).Value
            d0Tr_Dokumen_Pendukung.mKode_Sub_Sub_OPD.Text = dg_TampilData.Item(6, dg_TampilData.CurrentRow.Index).Value

            d0Tr_Dokumen_Pendukung.mNama_Sub_Sub_OPD.Text = dg_TampilData.Item(1, dg_TampilData.CurrentRow.Index).Value
        End If

    End Sub

    Private Sub view_cPar_OPD_5Sub_Sub_OPD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 10
        Me.Left = MenuUtama.Width - (Me.Width + 25)
        Tampil_Data(mPilihan.Text.Trim)
    End Sub
End Class