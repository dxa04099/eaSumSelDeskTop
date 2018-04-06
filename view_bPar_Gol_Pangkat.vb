Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class view_bPar_Gol_Pangkat
    Private Sub tbl_Keluar_Click(sender As Object, e As EventArgs) Handles tbl_Keluar.Click
        Me.Close()
    End Sub

    Private Sub view_bPar_Gol_Pangkat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 10
        Me.Left = MenuUtama.Width - (Me.Width + 25)
        Tampil_Data()
    End Sub
    Sub Tampil_Data()
        If cn_Lokal_Tmpl.State = ConnectionState.Closed Then cn_Lokal_Tmpl.Open()


        Dim sql_Perintah As String = " SELECT      " _
                & " Gol,  " _
                & " Pangkat " _
                & " FROM         bPar_Gol_Pangkat " _
                & " ORDER BY Gol "

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

    Private Sub tblGunakan_Click(sender As Object, e As EventArgs) Handles tblGunakan.Click
        If dg_TampilData.RowCount <= 0 Then Exit Sub

        If mKodePanggil.Text = "cgaji_Par_Gaji_Pokok" Then
            cgaji_Par_Gaji_Pokok.mGol.Text = dg_TampilData.Item(0, dg_TampilData.CurrentRow.Index).Value
            cgaji_Par_Gaji_Pokok.mPangkat.Text = dg_TampilData.Item(1, dg_TampilData.CurrentRow.Index).Value

        End If

        If mKodePanggil.Text = "cGaji_Par_Tunj_Umum" Then
            cGaji_Par_Tunj_Umum.mGol.Text = dg_TampilData.Item(0, dg_TampilData.CurrentRow.Index).Value
            cGaji_Par_Tunj_Umum.mPangkat.Text = dg_TampilData.Item(1, dg_TampilData.CurrentRow.Index).Value

        End If

        If mKodePanggil.Text = "cGaji_Par_Tunj_TKD" Then
            cGaji_Par_Tunj_TKD.mGol.Text = dg_TampilData.Item(0, dg_TampilData.CurrentRow.Index).Value
            cGaji_Par_Tunj_TKD.mPangkat.Text = dg_TampilData.Item(1, dg_TampilData.CurrentRow.Index).Value

        End If

        If mKodePanggil.Text = "cGaji_Par_Tunj_DT" Then
            cGaji_Par_Tunj_DT.mGol.Text = dg_TampilData.Item(0, dg_TampilData.CurrentRow.Index).Value
            cGaji_Par_Tunj_DT.mPangkat.Text = dg_TampilData.Item(1, dg_TampilData.CurrentRow.Index).Value

        End If
        Me.Close()
    End Sub
End Class