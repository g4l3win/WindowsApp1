Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = TBUsername.Text
        'ini komen
        If TBUsername.Text = "admin" And TBPassword.Text = "admin" Then
            MessageBox.Show("ini isinya", "ini judulnya", MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Information
                            )
        Else

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TBUsername.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CheckBox1.Checked Then
            TextBox1.Text = TextBox1.Text + CheckBox1.Text + "is checked" + vbCrLf

        ElseIf CheckBox2.Checked Then
            TextBox1.Text = TextBox1.Text + CheckBox2.Text + "is checked" + vbCrLf

        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        MessageBox.Show("udah dibilang jangan dicentang")

    End Sub
End Class
