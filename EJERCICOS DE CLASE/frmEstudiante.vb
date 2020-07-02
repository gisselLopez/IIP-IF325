Public Class frmEstudiante
    ' se instancia la clase conexion.vb con el nombre conexion para ser utilizada dentro del formulario y poder acceder a las funciones
    Dim conexion As conexion = New conexion()
    Dim dt As New DataTable
    Private Sub frmEstudiante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'en el evento load del formulario se abre la conexion a la base de datos
        'conexion.conectar()
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        mostrarDatos()
    End Sub

    Public Sub Limpiar()
        txtCodigo.Enabled = True
        txtCodigo.Clear()
        txtNombre.Clear()
        txtPrimerApellido.Clear()
        txtSegApellido.Clear()
        txtEdad.Clear()
        btnEliminar.Enabled = False
        btnModificar.Enabled = False
        btnGuardar.Enabled = True
        conexion.conexion.Close()
        'cmbSexo.Items.Clear()
    End Sub

    'Muestra los datos en el datagrid, estos los obtiene de la funcion 'consulta' en la clase conexion.vb
    Private Sub mostrarDatos()
        Try
            'asigna a la variable datatable la consulta realizada a la base de datos y si existen registros los asigna al datagrid'
            'caso contrario no muestra nada en el datagrid
            dt = conexion.consulta
            If dt.Rows.Count <> 0 Then
                dtgRegistros.DataSource = dt
                conexion.conexion.Close()
            Else
                dtgRegistros.DataSource = Nothing
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            'Ejemplo: insert into personas.estudiante 
            'values(36,'Luis','Perez','Martinez',26,'M','IF-325')
            Dim guardar As String =
             "insert into personas.estudiante values(" + txtCodigo.Text + ",'" + txtNombre.Text + "','" + txtPrimerApellido.Text + "',
             '" + txtSegApellido.Text + "','" + txtEdad.Text + "','" + cmbSexo.Text + "','" + cmbCodigoClase.Text + "')"

            If (conexion.insertar(guardar)) Then
                MessageBox.Show("Guardado")
                mostrarDatos() 'Llama la función que rellena el datagrid con la info actualizada
                Limpiar() 'Limpia las casillas de texto
                conexion.conexion.Close() 'Cierra conexion, para poder realizar otra operación
            Else
                MessageBox.Show("Error al guardar")
                conexion.conexion.Close() 'Cierra conexion, para poder realizar otra operación en el caso que falle la insercion
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

    Private Sub dtgRegistros_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgRegistros.CellContentClick
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
            "nombre='" + txtNombre.Text + "', primerApellido='" + txtPrimerApellido.Text + "', segundoApellido='" + txtSegApellido.Text + "', edad='" + txtEdad.Text + "', codigoClase='" + cmbCodigoClase.Text + "'"
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

    Private Sub llenarCampos(e As DataGridViewCellEventArgs)
        'Rellena los campos en los textbox, asignando de acuerdo a la posicion que se encuentra en el datagrid
        Try
            Dim dtg As DataGridViewRow = dtgRegistros.Rows(e.RowIndex)
            txtCodigo.Text = dtg.Cells(0).Value.ToString()
            txtNombre.Text = dtg.Cells(1).Value.ToString()
            txtPrimerApellido.Text = dtg.Cells(2).Value.ToString()
            txtSegApellido.Text = dtg.Cells(3).Value.ToString()
            txtEdad.Text = dtg.Cells(4).Value.ToString()
            cmbSexo.Text = dtg.Cells(5).Value.ToString()
            cmbCodigoClase.Text = dtg.Cells(6).Value.ToString()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar() 'Llama el procedimiento limpiar cajas de texto
    End Sub

    Private Sub mostrarBusqueda()
        'Buscar por codigo ejemplo: select * from personas.estudiante where codigo Like '%88%'
        Try
            'Se envía lo que contiene el txtCodigo como parametro de búsqueda
            ''%" + txtCodigo.Text + "%'"= con un numero que se encuentre de coincidencia este retornará las sugerencias
            'en el datagrid
            dt = conexion.buscarEstudiante("codigo like '%" + txtCodigo.Text + "%'")
            If dt.Rows.Count <> 0 Then
                dtgRegistros.DataSource = dt 'Rellena el datagrid
                conexion.conexion.Close()
            Else
                dtgRegistros.DataSource = Nothing 'No retorna nada, deja vació el datagrid ya que no existe un codigo
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
End Class

