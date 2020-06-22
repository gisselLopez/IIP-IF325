Public Class ARREGLOSCLASE
    Private mcomputadoras() As String
    Private cantcomputadoras As Integer
    Private index As Byte
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
            CmbPrecios.Items.Add(precio(i))
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
            cmbcompus.Items.Add(comp(j))
        Next
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Cmbcomputadoras.Items.Clear()
        CmbPrecios.Items.Clear()
    End Sub

    Private Sub ARREGLOSCLASE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMarca.Visible = False
        txtmodelo.Visible = False
        txtprecio.Visible = False
        txtcantibuscar.Visible = False
    End Sub

    Private Sub btnregistrar_Click(sender As Object, e As EventArgs) Handles btnregistrar.Click
        cantcomputadoras = Val(txtcantidadingresar.Text)
        ReDim mcomputadoras(cantcomputadoras, 3)
        'matriz 3x3=comienza a contar desde 0
        For i = 0 To (cantcomputadoras - 1) Step 1
            mcomputadoras(i, 0) = InputBox("ingrese la marca N." & (i + 1), "registro")
            mcomputadoras(i, 1) = InputBox("ingrese la modelo N." & (i + 1), "registro")
            mcomputadoras(i, 2) = InputBox("ingrese la precio N." & (i + 1), "registro")
            mcomputadoras(i, 3) = InputBox("ingrese la cantidad N." & (i + 1), "registro")
            Index = i
        Next

    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim marca As String
        marca = txtMarca.Text
        For i = 0 To (cantcomputadoras - 1) Step 1
            If (mcomputadoras(i, 0) = marca) Then
                txtmodelo.Text = mcomputadoras(i. 1)
                txtprecio.Text = mcomputadoras(i. 2)
                txtcantibuscar.Text = mcomputadoras(i. 3)
                encuentra = True
                btnbuscar.Enabled = True
                btnvender.Enabled = True
            End If
        Next
        If (encuentra = False) Then
            MessageBox.Show("No existe", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnvender_Click(sender As Object, e As EventArgs) Handles btnvender.Click
        Dim cantidadVender, stock As Integer
        cantidadVender = Val(txtvender.Text)
        stock = mcomputadoras(index, 3)
        If (cantidadVender >= stock) Then
            MessageBox.Show("sin stock", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            mcomputadoras(index, 3) = stock - cantidadVender
            MessageBox.Show("venta realizada", "venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class