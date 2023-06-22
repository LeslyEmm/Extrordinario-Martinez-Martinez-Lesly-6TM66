Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim valor3 As Integer
        Dim suma As Integer
        valor1 = TextBox1.Text
        valor2 = TextBox2.Text
        valor3 = TextBox3.Text
        suma = valor1 + valor2 + valor3
        Label5.Text = suma
    End Sub
End Class
