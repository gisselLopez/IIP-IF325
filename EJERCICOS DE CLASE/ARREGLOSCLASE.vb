Public Class ARREGLOSCLASE
    Private Sub btngenerar_Click(sender As Object, e As EventArgs) Handles btngenerar.Click
        Dim computadoras(3) As String
        computadoras(0) = "Toshiba"
        computadoras(1) = "Dell"
        computadoras(2) = "Asus"
        computadoras(3) = "MAC"
        For i = 0 To (computadoras.Length - 1) Step 1
            Cmbcomputadoras.Items.Add(computadoras(i))
        Next

    End Sub

    Private Sub btnGenerarPrecio_Click(sender As Object, e As EventArgs) Handles btnGenerarprecio.Click
        Dim precio(3) As Integer
        precio(0) = 22500
        precio(1) = 21000
        precio(2) = 29000
        precio(3) = 42000
        For i = 0 To (precio.Length - 1) Step 1
            cmbPrecios.Items.Add(precio(i))
        Next
    End Sub

    Private Sub btnsolicitar_Click(sender As Object, e As EventArgs) Handles btnsolicitar.Click
        Dim cant As Integer
        Dim comp() As String
        'Asignar tamaño
        cant = Val(txtcantidad.Text)
        ReDim comp(cant)
        'Solicitar la informacion
        For i = 0 To (comp.Length - 1) Step 1
            comp(i) = InputBox("Ingrese la marca de la pc", "Ingreso")
        Next
        'Mostrar la informacion
        For j = 0 To (comp.Length - 1) Step 1
            cmbCompus.Items.Add(comp(j))
        Next
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Cmbcomputadoras.Items.Clear()
        CmbPrecios.Items.Clear()
    End Sub
End Class