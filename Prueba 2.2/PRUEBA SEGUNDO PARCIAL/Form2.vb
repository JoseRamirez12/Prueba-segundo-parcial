Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cliente1 As Cliente = New Cliente()

        cliente1.ApellidoPaterno = TxtPaterno.Text
        cliente1.ApellidoMaterno = TxtMaterno.Text
        cliente1.NumeroSeguroSocial = Seguro.Text
        cliente1.Sexo = CboxSexo.Text
        cliente1.Categoria = CboxCategoria.Text
        cliente1.generarCodigo()
        DataCliente.Rows.Insert(0, cliente1.Codigo, cliente1.ApellidoPaterno, cliente1.ApellidoMaterno, cliente1.Sexo, cliente1.categoria)
    End Sub
End Class