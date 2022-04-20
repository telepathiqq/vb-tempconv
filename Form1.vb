Public Class Form1
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim myInput As Integer
        myInput = txtCelsius.Text
        lblKelvin.Text = myInput + 273.15
        lblFahrenheit.Text = (myInput * 9 / 5) + 32
    End Sub
End Class
