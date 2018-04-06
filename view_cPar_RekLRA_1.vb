﻿Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class view_cPar_RekLRA_1
    Private Sub tbl_Keluar_Click(sender As Object, e As EventArgs) Handles tbl_Keluar.Click
        Me.Close()
    End Sub
    Sub Tampil_Data()


        Dim sql_Perintah As String = " SELECT       " _
                        & " " _
                        & " Rek_LRA_Pos     as [Kd Rekening],  " _
                        & " Nama_Rek_LRA_Pos    " _
                        & " FROM         cPar_RekLRA_1 " _
                        & " ORDER BY  " _
                        & " Rek_LRA_Pos  "

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


    End Sub

    Private Sub mCari_TextChanged(sender As Object, e As EventArgs)
        Tampil_Data()
    End Sub

    Private Sub tblGunakan_Click(sender As Object, e As EventArgs) Handles tblGunakan.Click
        If dg_TampilData.RowCount <= 0 Then Exit Sub
        If mKodePanggil.Text.Trim = "cPar_RekLRA_2" Then
            cPar_RekLRA_2.mRek_LRA_Pos.Text = dg_TampilData.Item(0, dg_TampilData.CurrentRow.Index).Value
            cPar_RekLRA_2.mNama_Rek_LRA_Pos.Text = dg_TampilData.Item(1, dg_TampilData.CurrentRow.Index).Value
        End If
        If mKodePanggil.Text.Trim = "cPar_RekLRA_3" Then
            cPar_RekLRA_3.mRek_LRA_Pos.Text = dg_TampilData.Item(0, dg_TampilData.CurrentRow.Index).Value
        End If
        If mKodePanggil.Text.Trim = "cPar_RekLRA_4" Then
            cPar_RekLRA_4.mRek_LRA_Pos.Text = dg_TampilData.Item(0, dg_TampilData.CurrentRow.Index).Value
        End If


        Me.Close()
    End Sub

    Private Sub view_cPar_RekLRA_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 10
        Me.Left = MenuUtama.Width - (Me.Width + 25)
        Tampil_Data()
    End Sub
End Class