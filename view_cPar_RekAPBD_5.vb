﻿Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class view_cPar_RekAPBD_5
    Private Sub tbl_Keluar_Click(sender As Object, e As EventArgs) Handles tbl_Keluar.Click
        Me.Close()
    End Sub
    Sub Tampil_Data()
        If cn_Lokal_Tmpl.State = ConnectionState.Closed Then cn_Lokal_Tmpl.Open()
        Dim sql_kondisi_rek = ""
        If mRek_Pos.Text.Trim <> "" Then
            sql_kondisi_rek = sql_kondisi_rek & " and Rek_Pos = '" & mRek_Pos.Text.Trim & "' "
        End If
        If mRek_Kelompok.Text.Trim <> "" Then
            sql_kondisi_rek = sql_kondisi_rek & "and Rek_Kelompok = '" & mRek_Kelompok.Text.Trim & "' "
        End If

        If mRek_Jenis.Text.Trim <> "" Then
            sql_kondisi_rek = sql_kondisi_rek & "and Rek_Jenis = '" & mRek_Jenis.Text.Trim & "' "
        End If
        If mRek_Objek.Text.Trim <> "" Then
            sql_kondisi_rek = sql_kondisi_rek & "and Rek_Objek = '" & mRek_Objek.Text.Trim & "' "
        End If

        Dim sql_Kondisi As String = ""
        If mCari.Text.Trim = "" Then
            If sql_kondisi_rek.Trim <> "" Then
                sql_Kondisi = "where " & Mid(sql_kondisi_rek.Trim, 4, sql_kondisi_rek.Trim.Length - 3)
            End If
        Else
            sql_Kondisi = " where Nama_Rek_Rincian_Objek like '%" & mCari.Text.Trim & "%' " & sql_kondisi_rek.Trim
        End If

        Dim sql_Perintah As String = " SELECT       " _
                        & " " _
                        & " Rek_Pos  & '.' &   " _
                        & " Rek_Kelompok & '.' &   " _
                        & " Rek_Jenis &  '.' &  " _
                        & " Rek_Objek  &  '.' &  " _
                        & " Rek_Rincian_Objek  as [Kd Rekening],  " _
                        & " Nama_Rek_Rincian_Objek as [Rekening Rincian Objek], " _
                        & " Rek_Pos,  " _
                        & " Rek_Kelompok,  " _
                        & " Rek_Jenis,  " _
                        & " Rek_Objek,  " _
                        & " Rek_Rincian_Objek  " _
                        & " FROM         cPar_RekAPBD_5 " & sql_Kondisi _
                        & " ORDER BY  " _
                        & " Rek_Pos,  " _
                        & " Rek_Kelompok,  " _
                        & " Rek_Jenis,  " _
                        & " Rek_Objek,Rek_Rincian_Objek "

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
        dg_TampilData.Columns(5).Visible = False
        dg_TampilData.Columns(6).Visible = False
    End Sub

    Private Sub mCari_TextChanged(sender As Object, e As EventArgs) Handles mCari.TextChanged
        Tampil_Data()
    End Sub

    Private Sub tblGunakan_Click(sender As Object, e As EventArgs) Handles tblGunakan.Click
        If dg_TampilData.RowCount <= 0 Then Exit Sub
        If mKodePanggil.Text.Trim = "aaa" Then
            'aaa.kd__.Text  = dg_TampilData.Item(0, dg_TampilData.CurrentRow.Index).Value
            'aaa.kd__.Text  = dg_TampilData.Item(1, dg_TampilData.CurrentRow.Index).Value
        End If

    End Sub

    Private Sub view_cPar_RekAPBD_5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 10
        Me.Left = MenuUtama.Width - (Me.Width + 25)
        Tampil_Data()
    End Sub
End Class