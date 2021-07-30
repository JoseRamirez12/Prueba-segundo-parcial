Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim empleado1 As Empleado = New Empleado()
        empleado1.ApellidoPaterno = TxtPaterno.Text
        empleado1.ApellidoMaterno = TxtMaterno.Text
        empleado1.NumeroSeguroSocial = Seguro.Text
        empleado1.TipoContrato = CboxContra.Text
        empleado1.CalcularElSueldo(750)
        DataEmpleado.Rows.Insert(0, empleado1.ApellidoPaterno, empleado1.ApellidoMaterno, empleado1.NumeroSeguroSocial, empleado1.TipoContrato, empleado1.Sueldo)
    End Sub


End Class