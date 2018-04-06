Imports System.Text
Imports System.IO
Imports System.Data.SqlClient
Public Class cPar_RekAkrual_3

    Private Sub tbl_Keluar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbl_Keluar.Click
        Me.Close()
    End Sub

    Private Sub tbCari01_Click(sender As Object, e As EventArgs) Handles tbCari01.Click
        view_cPar_RekAkrual_2.mKodePanggil.Text = "cPar_RekAkrual_3"
        view_cPar_RekAkrual_2.ShowDialog(Me)
        Tampil_Rek_Akrual_Jenis()
    End Sub

    Sub Tampil_Rek_Akrual_Jenis()
        If Open_eSumsel_Tampil() = False Then Exit Sub

        Dim sql_kondisi_rek = ""
        If mRek_Pos.Text.Trim <> "" Then
            sql_kondisi_rek = sql_kondisi_rek & " and akr_Rek_Pos = '" & mRek_Pos.Text.Trim & "' "
        End If

        If mRek_Kelompok.Text.Trim <> "" Then
            sql_kondisi_rek = sql_kondisi_rek & " and akr_Rek_Kelompok = '" & mRek_Kelompok.Text.Trim & "' "
        End If

        If mRek_Jenis.Text.Trim <> "" Then
            sql_kondisi_rek = sql_kondisi_rek & " and akr_Rek_Jenis = '" & mRek_Jenis.Text.Trim & "' "
        End If

        Dim sql_Kondisi As String = ""
        If mcari.Text.Trim = "" Then
            If sql_kondisi_rek.Trim <> "" Then
                sql_Kondisi = "where " & Mid(sql_kondisi_rek.Trim, 4, sql_kondisi_rek.Trim.Length - 3)
            End If
        Else
            sql_Kondisi = " where akr_Nama_Rek_Jenis like '%" & mcari.Text.Trim & "%' " & sql_kondisi_rek.Trim
        End If

        Dim sql_Text_Comman As String = " SELECT akr_Rek_Pos + '.' + akr_Rek_Kelompok + '.' + akr_Rek_Jenis AS [Rekening] " _
                                        & "  ,DK AS [Debit / Kredit] " _
                                        & "  ,akr_Nama_Rek_Jenis AS [Nama Rekening Akrual Jenis] " _
                                        & "  ,akr_Rek_Pos" _
                                        & "  ,akr_Rek_Kelompok" _
                                        & "  ,akr_Rek_Jenis" _
                                        & " FROM cPar_RekAkrual_3 " & sql_Kondisi _
                                        & " ORDER By akr_Rek_Pos "
        Dim Tampil_data As New SqlCommand(sql_Text_Comman, cn_eSumsel_Tmpl)
        Tampil_data.CommandType = CommandType.Text

        Dim OleDA_Tampil As New SqlDataAdapter(Tampil_data)

        Dim ODS_Tampil As New DataSet
        OleDA_Tampil.Fill(ODS_Tampil, "a_user")
        Dim ODV_Tampil As New DataView(ODS_Tampil.Tables("a_user"))
        dg_TampilData.DataSource = ODV_Tampil
        ODS_Tampil.Dispose()
        OleDA_Tampil.Dispose()

        Close_eSumsel_Tampil()

        dg_TampilData.Columns(0).Width = (dg_TampilData.Width / 10) * 1
        dg_TampilData.Columns(1).Width = (dg_TampilData.Width / 10) * 1
        dg_TampilData.Columns(2).Width = (dg_TampilData.Width / 10) * 7.6

        dg_TampilData.Columns(3).Visible = False
        dg_TampilData.Columns(4).Visible = False
        dg_TampilData.Columns(5).Visible = False
    End Sub

    Private Sub cPar_RekAkrual_3_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Tampil_Rek_Akrual_Jenis()
    End Sub

    Private Sub mcari_TextChanged(sender As Object, e As EventArgs) Handles mcari.TextChanged
        Tampil_Rek_Akrual_Jenis()
    End Sub

    Private Sub tblBaru_Click(sender As Object, e As EventArgs) Handles tblBaru.Click
        clearField()
    End Sub

    Sub clearField()
        mRek_Pos.Text = ""
        mRek_Kelompok.Text = ""
        mRek_Jenis.Text = ""
        mNama_Rek_Kelompok.Text = ""
        mNama_Rek_Jenis.Text = ""
        rd_Debit.Checked = False
        rd_Kredit.Checked = False
    End Sub

    Private Sub mRek_Jenis_LostFocus(sender As Object, e As EventArgs) Handles mRek_Jenis.LostFocus
        If Open_eSumsel() = False Then Exit Sub
        Dim sql_Text_Comman As String = "SELECT " _
                                            & " akr_Nama_Rek_Jenis" _
                                            & " DK" _
                                            & " FROM cPar_RekAkrual_3 " _
                                            & " WHERE akr_Rek_Pos = '" & mRek_Pos.Text.Trim & "'  AND akr_Rek_Kelompok = '" & mRek_Kelompok.Text.Trim & "' AND akr_Nama_Rek_Jenis = '" & mRek_Jenis.Text.Trim & "' " _
                                            & " ORDER By akr_Nama_Rek_Jenis "
        Rs_Baca.Open(sql_Text_Comman, cn_eSumsel)

        mNama_Rek_Jenis.Text = ""
        rd_Debit.Checked = False
        rd_Kredit.Checked = False

        If Rs_Baca.RecordCount > 0 Then
            mNama_Rek_Jenis.Text = Rs_Baca.Fields("akr_Nama_Rek_Jenis").Value.ToString.Trim
            If Rs_Baca.Fields("DK").Value.ToString = "D" Then
                rd_Debit.Checked = True
            Else
                rd_Kredit.Checked = True
            End If
        End If

        Rs_Baca.Close()
        Close_eSumsel()
    End Sub

    Sub get_nama_rek_kelompok()
        If Open_eSumsel() = False Then Exit Sub
        Dim sql_Text_Comman As String = "SELECT " _
                                            & " akr_Nama_Rek_Kelompok" _
                                            & " FROM cPar_RekAkrual_2 " _
                                            & " WHERE akr_Rek_Pos = '" & mRek_Pos.Text.Trim & "'  AND akr_Rek_Kelompok = '" & mRek_Kelompok.Text.Trim & "' " _
                                            & " ORDER By akr_Nama_Rek_Kelompok "
        Rs_Baca.Open(sql_Text_Comman, cn_eSumsel)

        mNama_Rek_Kelompok.Text = ""
        If Rs_Baca.RecordCount > 0 Then
            mNama_Rek_Kelompok.Text = Rs_Baca.Fields("akr_Nama_Rek_Kelompok").Value.ToString.Trim
        End If

        Rs_Baca.Close()
        Close_eSumsel()
    End Sub

    Private Sub dg_TampilData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_TampilData.CellDoubleClick
        mRek_Pos.Text = dg_TampilData.Item(3, dg_TampilData.CurrentRow.Index).Value.ToString.Trim
        mRek_Kelompok.Text = dg_TampilData.Item(4, dg_TampilData.CurrentRow.Index).Value.ToString.Trim
        get_nama_rek_kelompok()
        mRek_Jenis.Text = dg_TampilData.Item(5, dg_TampilData.CurrentRow.Index).Value.ToString.Trim
        mNama_Rek_Jenis.Text = dg_TampilData.Item(2, dg_TampilData.CurrentRow.Index).Value.ToString.Trim
        rd_Debit.Checked = False
        rd_Kredit.Checked = False
        If dg_TampilData.Item(1, dg_TampilData.CurrentRow.Index).Value.ToString.Trim = "D" Then
            rd_Debit.Checked = True
        Else
            rd_Kredit.Checked = True
        End If
    End Sub
End Class