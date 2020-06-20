Public Class Form1
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        TextBox1.Text = NumericUpDown1.Value
    End Sub
End Class
