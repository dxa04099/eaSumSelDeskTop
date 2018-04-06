Imports System.Text
Imports System.IO
Imports System.Data.SqlClient

Public Class cPar_ProgKeg_Program

    Private Sub tbl_Keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbl_Keluar.Click
        Me.Close()
    End Sub

    Private Sub tbCari01_Click(sender As Object, e As EventArgs) Handles tbCari01.Click
        'MsgBox("as")
        ' view_cPar_ProgKeg_Program.mKodePanggil.Text = "cPar_ProgKeg_Program"
        'view_cPar_ProgKeg_Program.mKd_Urusan_Program.Text = "cPar_ProgKeg_Program"
        'view_cPar_ProgKeg_Program.mKd_Bidang_Program.Text = "cPar_ProgKeg_Program"
        'view_DaftarSubOPD.Tampil_SKPD("SUBSKPD", 0)
        view_cPar_OPD_2Bidang.ShowDialog(Me)


    End Sub

    Sub tampil_prog()
        If Open_eSumsel_Tampil() = False Then Exit Sub

        Dim sql_Text_Comman As String = "SELECT " _
                                    & " Kd_Urusan_Program + '.' +   Kd_Bidang_Program + '.' +   Kd_Prog as [kkk], Nama_Program, " _
                                    & " Kd_Urusan_Program ,Kd_Bidang_Program ,Kd_Prog " _
                                    & " FROM cPar_ProgKeg_Program " _
                                    & " ORDER By Kd_Prog"
        Dim Tampil_data As New SqlCommand(sql_Text_Comman, cn_eSumsel_Tmpl)
        Tampil_data.CommandType = CommandType.Text

        Dim OleDA_Tampil As New SqlDataAdapter(Tampil_data)


        Dim ODS_Tampil As New DataSet
        OleDA_Tampil.Fill(ODS_Tampil, "program")
        Dim ODV_Tampil As New DataView(ODS_Tampil.Tables("program"))
        dg_TampilData.DataSource = ODV_Tampil
        ODS_Tampil.Dispose()
        OleDA_Tampil.Dispose()

        Close_eSumsel_Tampil()

        dg_TampilData.Columns(0).Width = (dg_TampilData.Width / 10) * 1.8
        dg_TampilData.Columns(1).Width = (dg_TampilData.Width / 10) * 1.5
        dg_TampilData.Columns(2).Visible = False
        dg_TampilData.Columns(3).Visible = False
        dg_TampilData.Columns(4).Visible = False

        'dg_TampilData.Columns(2).Width = (dg_TampilData.Width / 10) * 1.8
        'dg_TampilData.Columns(3).Width = (dg_TampilData.Width / 10) * 3.7
        'dg_User.Columns(4).Width = (dg_User.Width / 10) * 1.7
        'dg_User.Columns(5).Width = (dg_User.Width / 10) * 1
        'dg_User.Columns(6).Width = (dg_User.Width / 10) * 3.5
    End Sub


    Private Sub dg_TampilData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_TampilData.CellContentClick

    End Sub

    Private Sub cPar_ProgKeg_Program_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tblSimpan_Click(sender As Object, e As EventArgs) Handles tblSimpan.Click
        If mKd_Prog.Text.Trim = "" Then
            MsgBox("Nama Program tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If
        If mNama_Program.Text.Trim = "" Then
            MsgBox("Nama Program tidak boleh kosong.....", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Informasi")
            Exit Sub
        End If
    End Sub

    Private Sub cPar_ProgKeg_Program_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        tampil_prog()
    End Sub

    Private Sub mKd_Prog_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mKd_Prog.MaskInputRejected

    End Sub

    Private Sub dg_TampilData_DoubleClick(sender As Object, e As EventArgs) Handles dg_TampilData.DoubleClick
        mKd_Prog.Text = dg_TampilData.Item(4, dg_TampilData.CurrentRow.Index).Value
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        mKd_Urusan_Program.Text = "0"
        mKd_Bidang_Program.Text = "00"
        mNama_Urusan.Text = "Program Rutin/Setiap OPD"
        mKd_Urusan_Program.Enabled = False
        mKd_Bidang_Program.Enabled = False
        tbCari01.Enabled = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        mKd_Urusan_Program.Text = ""
        mKd_Bidang_Program.Text = ""
        mKd_Urusan_Program.Enabled = False
        mKd_Bidang_Program.Enabled = False
        mNama_Urusan.Text = ""
        tbCari01.Enabled = True
    End Sub
End Class