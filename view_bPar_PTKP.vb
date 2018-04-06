Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class view_bPar_PTKP
    Private Sub tbl_Keluar_Click(sender As Object, e As EventArgs) Handles tbl_Keluar.Click
        Me.Close()
    End Sub

    Private Sub view_bPar_PTKP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 10
        Me.Left = MenuUtama.Width - (Me.Width + 25)
        Tampil_Data()
    End Sub
    Sub Tampil_Data()
        If cn_Lokal_Tmpl.State = ConnectionState.Closed Then cn_Lokal_Tmpl.Open()

        Dim sql_Kondisi As String = ""
        If mCari.Text.Trim = "" Then
        Else
            sql_Kondisi = " where bPar_PTKP.Kode_Status_Kawin like '%" & mCari.Text.Trim & "%' or bPar_Status_Kawin.Staus_Kawin like '%" & mCari.Text.Trim & "%' "
        End If

        Dim sql_Perintah As String = " SELECT       " _
                    & " bPar_PTKP.Kode_Status_Kawin as [Kode],  " _
                    & " bPar_Status_Kawin.Staus_Kawin as [Sts Kawin],  " _
                    & " bPar_PTKP.Jml_Istri_Suami as [Jml Is/Su],  " _
                    & " bPar_PTKP.Jml_Anak as [Jml Anak],  " _
                    & " bPar_PTKP.Jml_Jiwa as [Jml Jiwa],  " _
                    & " bPar_PTKP.PTKP_Sebulan as [PTKP / Bln], " _
                    & " bPar_PTKP.PTKP_Setahun as [PTKP / Thn]" _
                    & " FROM         bPar_PTKP LEFT OUTER JOIN " _
                    & "              bPar_Status_Kawin ON  " _
                    & " bPar_PTKP.Kode_Status_Kawin = bPar_Status_Kawin.Kode_Status_Kawin " & sql_Kondisi _
                    & " ORDER BY bPar_PTKP.Kode_Status_Kawin "

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

        dg_TampilData.Columns(0).Width = (dg_TampilData.Width / 10) * 1
        dg_TampilData.Columns(1).Width = (dg_TampilData.Width / 10) * 2.8
        dg_TampilData.Columns(2).Width = (dg_TampilData.Width / 10) * 1.2
        dg_TampilData.Columns(3).Width = (dg_TampilData.Width / 10) * 0.7
        dg_TampilData.Columns(4).Width = (dg_TampilData.Width / 10) * 0.7
        dg_TampilData.Columns(5).Width = (dg_TampilData.Width / 10) * 1.5
        dg_TampilData.Columns(6).Width = (dg_TampilData.Width / 10) * 1.6
        dg_TampilData.Columns(5).DefaultCellStyle.Format = "###,###.00"
        dg_TampilData.Columns(6).DefaultCellStyle.Format = "###,###.00"

        dg_TampilData.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dg_TampilData.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
    End Sub

    Private Sub mCari_TextChanged(sender As Object, e As EventArgs) Handles mCari.TextChanged
        Tampil_Data()
    End Sub
End Class