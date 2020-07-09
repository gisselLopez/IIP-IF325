Imports System.ComponentModel

Public Class FrmEstudiante
    ' se instancia la clase conexion.vb con el nombre conexion para ser utilizada dentro del formulario y poder acceder a las funciones
    Dim conexion As conexion = New conexion()
    Dim dt As New DataTable
    Private Sub FrmEstudiante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'en el evento load del formulario se abre la conexion a la base de datos
        'conexion.conectar()
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        mostrarDatos()
    End Sub
    Public Sub Limpiar()
        txtCodigo.Enabled = True
        txtCodigo.Clear()
        TxtNombre.Clear()
        txtPrimerApellido.Clear()
        txtSegundoApellido.Clear()
        txtEdad.Clear()
        btnEliminar.Enabled = False
        btnModificar.Enabled = False
        btnGuardar.Enabled = True
        conexion.conexion.Close()
        'cmbSexo.Items.Clear()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar() 'Llama el procedimiento limpiar cajas de texto
    End Sub
    'Muestra los datos en el datagrid, estos los obtiene de la funcion 'consulta' en la clase conexion.vb


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            'Ejemplo: insert into personas.estudiante 
            'values(36,'Luis','Perez','Martinez',26,'M','IF-325')
            Dim guardar As String =
             "insert into personas.estudiante values(" + txtCodigo.Text + ",'" + TxtNombre.Text + "','" + txtPrimerApellido.Text + "',
             '" + txtSegundoApellido.Text + "','" + txtEdad.Text + "','" + cmbsexo.Text + "','" + CmbCodigoClase.Text + "')"

            If (conexion.insertar(guardar)) Then
                MessageBox.Show("Guardado")
                mostrarDatos() 'Llama la función que rellena el datagrid con la info actualizada
                Limpiar() 'Limpia las casillas de texto
                conexion.conexion.Close() 'Cierra conexion, para poder realizar otra operación
            Else
                MessageBox.Show("Error al guardar")
                conexion.conexion.Close() 'Cierra conexion, para poder realizar otra operación en el caso que falle la insercion
            End If
            If txtCodigo.Text = "" Or txtEdad.Text = "" Or txtPrimerApellido.Text = "" Or txtSegundoApellido.Text = "" Or TxtNombre.Text = "" Or cmbsexo.SelectedIndex = "" Or CmbCodigoClase.SelectedIndex = "" Then
                MsgBox("debe de llenar los campos solicitados")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            'Ejemplo: delete from personas.estudiante where codigo = 0036 '8836 es txtCodigo'
            'Parametros enviados son la tabla: personas.estudinte, La condicion="codigo=" + txtCodigo.Text
            If (conexion.eliminar("personas.estudiante", "codigo=" + txtCodigo.Text)) Then
                MessageBox.Show("Eliminado")
                mostrarDatos()
                Limpiar()
                conexion.conexion.Close()
            Else
                MessageBox.Show("Error al Eliminar")
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DtgRegistros_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtgRegistros.CellContentClick
        btnGuardar.Enabled = False
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
        txtCodigo.Enabled = False
        llenarCampos(e)
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            'Ejemplo
            'UPDATE personas.estudiante 
            'set nombre='Olman', primerApellido='Mendez', segundoApellido='Mendez', edad=27, codigoClase='IF-325'
            'WHERE codigo ='36'
            Dim modificar As String =
            "nombre='" + TxtNombre.Text + "', primerApellido='" + txtPrimerApellido.Text + "', segundoApellido='" + txtSegundoApellido.Text + "', edad='" + txtEdad.Text + "', codigoClase='" + CmbCodigoClase.Text + "'"
            'Se envían 3 parametros;1. tabla,2. el estbalecer los campos que pueden ser modificados,3. la condición
            If (conexion.modificar("personas.estudiante", modificar, " codigo=" + txtCodigo.Text)) Then
                MessageBox.Show("Actualizado")
                mostrarDatos()
                Limpiar()
                conexion.conexion.Close()
            Else
                MessageBox.Show("Error al actualizar")
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    'Muestra los datos en el datagrid, estos los obtiene de la funcion 'consulta' en la clase conexion.vb
    Private Sub mostrarDatos()
        Try
            'asigna a la variable datatable la consulta realizada a la base de datos y si existen registros los asigna al datagrid'
            'caso contrario no muestra nada en el datagrid
            dt = conexion.consulta
            If dt.Rows.Count <> 0 Then
                DtgRegistros.DataSource = dt
                conexion.conexion.Close()
            Else
                DtgRegistros.DataSource = Nothing
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub llenarCampos(e As DataGridViewCellEventArgs)
        'Rellena los campos en los textbox, asignando de acuerdo a la posicion que se encuentra en el datagrid
        Try
            Dim dtg As DataGridViewRow = DtgRegistros.Rows(e.RowIndex)
            txtCodigo.Text = dtg.Cells(0).Value.ToString()
            TxtNombre.Text = dtg.Cells(1).Value.ToString()
            txtPrimerApellido.Text = dtg.Cells(2).Value.ToString()
            txtSegundoApellido.Text = dtg.Cells(3).Value.ToString()
            txtEdad.Text = dtg.Cells(4).Value.ToString()
            cmbsexo.Text = dtg.Cells(5).Value.ToString()
            CmbCodigoClase.Text = dtg.Cells(6).Value.ToString()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub mostrarBusqueda()
        'Buscar por codigo ejemplo: select * from personas.estudiante where codigo Like '%88%'
        Try
            'Se envía lo que contiene el txtCodigo como parametro de búsqueda
            ''%" + txtCodigo.Text + "%'"= con un numero que se encuentre de coincidencia este retornará las sugerencias
            'en el datagrid
            dt = conexion.buscarEstudiante("codigo like '%" + txtCodigo.Text + "%'")
            If dt.Rows.Count <> 0 Then
                DtgRegistros.DataSource = dt 'Rellena el datagrid
                conexion.conexion.Close()
            Else
                DtgRegistros.DataSource = Nothing 'No retorna nada, deja vació el datagrid ya que no existe un codigo
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Al ingresar al menos un valor que se encuentre en el codigo del estudiante este mostrará las sugerencias, 
    'primero ingresar el código despúes presionar clic en el boton buscar
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        mostrarBusqueda()
    End Sub


    Private Sub TxtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub txtPrimerApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrimerApellido.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub txtSegundoApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSegundoApellido.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtEdad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEdad.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub txtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCodigo_Validating(sender As Object, e As CancelEventArgs) Handles txtCodigo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtEdad_Validating(sender As Object, e As CancelEventArgs) Handles txtEdad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
            If (Val(txtEdad.Text) - Int(Val(txtEdad.Text)) = 0) Then
                Me.ErrorProvider.SetError(sender, "")
            Else
                Me.ErrorProvider.SetError(sender, "Ingrese una edad valida")
            End If
        Else
            Me.ErrorProvider.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtSegundoApellido_Validating(sender As Object, e As CancelEventArgs) Handles txtSegundoApellido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtPrimerApellido_Validating(sender As Object, e As CancelEventArgs) Handles txtPrimerApellido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub TxtNombre_Validating(sender As Object, e As CancelEventArgs) Handles TxtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub



    Private Sub txtCodigo_MouseHover(sender As Object, e As EventArgs) Handles txtCodigo.MouseHover
        ToolTip.SetToolTip(txtEdad, "codigo")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub



    Private Sub txtEdad_MouseHover(sender As Object, e As EventArgs) Handles txtEdad.MouseHover
        ToolTip.SetToolTip(txtEdad, "Edad")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub TxtNombre_MouseHover(sender As Object, e As EventArgs) Handles TxtNombre.MouseHover
        ToolTip.SetToolTip(txtEdad, "Nombre")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub



    Private Sub txtPrimerApellido_MouseHover(sender As Object, e As EventArgs) Handles txtPrimerApellido.MouseHover
        ToolTip.SetToolTip(txtEdad, "primer Apellido")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtSegundoApellido_MouseHover(sender As Object, e As EventArgs) Handles txtSegundoApellido.MouseHover
        ToolTip.SetToolTip(txtEdad, "segundo Apellido")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub cmbsexo_MouseHover(sender As Object, e As EventArgs) Handles cmbsexo.MouseHover
        ToolTip.SetToolTip(txtEdad, "su sexo")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub CmbCodigoClase_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCodigoClase.SelectedIndexChanged
        ToolTip.SetToolTip(txtEdad, "Codigo Clase")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged

    End Sub
End Class