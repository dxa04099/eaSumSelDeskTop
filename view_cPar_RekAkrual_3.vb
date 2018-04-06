﻿Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class view_cPar_RekAkrual_3
    Private Sub tbl_Keluar_Click(sender As Object, e As EventArgs) Handles tbl_Keluar.Click
        Me.Close()
    End Sub
    Sub Tampil_Data()
        If cn_Lokal_Tmpl.State = ConnectionState.Closed Then cn_Lokal_Tmpl.Open()
        Dim sql_kondisi_rek = ""
        If makr_Rek_Pos.Text.Trim <> "" Then
            sql_kondisi_rek = sql_kondisi_rek & " and akr_Rek_Pos = '" & makr_Rek_Pos.Text.Trim & "' "
        End If
        If makr_Rek_Kelompok.Text.Trim <> "" Then
            sql_kondisi_rek = sql_kondisi_rek & "and akr_Rek_Kelompok = '" & makr_Rek_Kelompok.Text.Trim & "' "
        End If


        Dim sql_Kondisi As String = ""
        If mCari.Text.Trim = "" Then
            If sql_kondisi_rek.Trim <> "" Then
                sql_Kondisi = "where " & Mid(sql_kondisi_rek.Trim, 4, sql_kondisi_rek.Trim.Length - 3)
            End If
        Else
            sql_Kondisi = " where akr_Nama_Rek_Jenis like '%" & mCari.Text.Trim & "%' " & sql_kondisi_rek.Trim
        End If

        Dim sql_Perintah As String = " SELECT       " _
                        & " " _
                        & " akr_Rek_Pos  & '.' &   " _
                        & " akr_Rek_Kelompok & '.' &   " _
                        & " akr_Rek_Jenis   as [Kd Rekening],  " _
                        & " akr_Nama_Rek_Jenis as [Rekening Jenis], " _
                        & " akr_Rek_Pos,  " _
                        & " akr_Rek_Kelompok,  " _
                        & " akr_Rek_Jenis   " _
                        & " FROM         cPar_RekAkrual_3 " & sql_Kondisi _
                        & " ORDER BY  " _
                        & " akr_Rek_Pos,  " _
                        & " akr_Rek_Kelompok,  " _
                        & " akr_Rek_Jenis  "

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

    Private Sub view_cPar_RekAkrual_3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 10
        Me.Left = MenuUtama.Width - (Me.Width + 25)
        Tampil_Data()
    End Sub
End Class