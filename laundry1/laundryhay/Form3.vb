Public Class Form3
    Private Sub cbJenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbJenis.SelectedIndexChanged
        If cbJenis.Text = "Pakaian" Then
            txtHarga.Text = "7000"
        ElseIf cbJenis.Text = "Sepatu" Then
            txtHarga.Text = "10000"
        ElseIf cbJenis.Text = "Selimut" Then
            txtHarga.Text = "12000"
        ElseIf cbJenis.Text = "Boneka" Then
            txtHarga.Text = "9000"
        End If

    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        Dim a, b As Integer
        Dim c = "5000"
        Dim hasil As Integer
        a = txtBerat.Text
        b = txtHarga.Text
        c = "5000"
        hasil = a * b
        txtTotal.Text = hasil
        If RadioButton2.Checked Then
            txtTotal.Text = hasil + c
        End If
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim p, q, Kembalian As Integer
        p = txtUang.Text
        q = txtTotal.Text
        Kembalian = p - q
        txtKembali.Text = Kembalian
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtNama.Text = ""
        txtBerat.Text = ""
        txtHarga.Text = ""
        txtTotal.Text = ""
        txtUang.Text = ""
        txtKembali.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Form4.DataGridView1.Rows.Add(1)
        Form4.DataGridView1.Rows(Form4.DataGridView1.RowCount - 2).Cells(0).Value = txtNama.Text
        Form4.DataGridView1.Rows(Form4.DataGridView1.RowCount - 2).Cells(1).Value = txtBerat.Text
        Form4.DataGridView1.Rows(Form4.DataGridView1.RowCount - 2).Cells(2).Value = cbJenis.Text
        Form4.DataGridView1.Rows(Form4.DataGridView1.RowCount - 2).Cells(3).Value = txtTotal.Text
        Form4.DataGridView1.Rows(Form4.DataGridView1.RowCount - 2).Cells(4).Value = DateTimePicker1.Value
        MsgBox("Data Disimpan", MsgBoxStyle.Information)
        Form4.Show()
        Me.Hide()
    End Sub
End Class