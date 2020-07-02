'Imports System.Data
Imports System.Data.SqlClient
'Imports System.Windows.Forms
Public Class conexion

    'Data Source= DESKTOP-FA1HDUQ//el valor de data source varia de acuerdo al nombre del servidor en sql
    'Catalog es el nombre de la base de datos

    Public conexion As SqlConnection = New SqlConnection("Data Source= DESKTOP-FA1HDUQ;Initial Catalog=Ejemplo; Integrated Security=True")
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public comando As SqlCommand
    Public cmd As New SqlCommand
    'Public dr As New SqlDataReader
    ' se crea un procedimiento para conectar a la base de datos y en el caso de existir alguna excepcion que esta la retorne 
    Public Sub conectar()
        Try
            'conexion es el nombre de la clase; open() abre la conexion con sql, si se abre la conexion muestra e msj conectado sino cierra la conexion
            conexion.Open()
            MessageBox.Show("Conectado")
        Catch ex As Exception
            MessageBox.Show("Error al conectar")
        Finally
            conexion.Close()
        End Try
    End Sub
    'Función que retornará y asigna en el datagrid los valores que encuentre en la tabla
    Public Function consulta() As DataTable
        Try
            'La consulta sql es un procedimiento almacenado llamado 'consultaEstudiante', es por ello que no se muestra
            'select * from personas.empleado, el procedimiento almacenado se encuentra en el query: storeProcedure
            conexion.Open()
            'SQLcommand requiere dos parametros: 1. Instruccion sql o en este caso el procedimientoAlmacenado 
            '2. Establecer una comunicacion con la base de datos
            Dim cmd As New SqlCommand("consultaEstudiante", conexion)
            'Se le especifica que la instruccion sql es un tipo procedimiento almacenado
            cmd.CommandType = CommandType.StoredProcedure
            'cmd.ExecuteNonQuery= Ejecuta una instrucción Transact-SQL contra la conexión y devuelve el número de filas afectadas.
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
                'conexion.Close()
            Else
                Return Nothing ' Sino encuentra nada en la base de datos dejará vacío el datagrid
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    'Función para insertar registros en una tabla, requiere de la consulta sql que recibirá del boton guardar, 'Byval sql'
    Function insertar(ByVal sql)
        conexion.Open()
        comando = New SqlCommand(sql, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        conexion.Close()
        'Si existe al menos un registro nuevo este sera agregado a la base de datos
        If (i > 0) Then
            Return True
        Else
            Return False 'Si no existe nada no realizara ninguna operación
        End If
    End Function

    'Funcion eliminar registro de la tabla: necesita de dos parametros que serán enviados del boton eliminar especificando el codigo a eliminar y la tabla afectada
    Function eliminar(ByVal tabla, ByVal condicion)
        conexion.Open()
        Dim eliminarE As String = "delete from " + tabla + " where " + condicion
        comando = New SqlCommand(eliminarE, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    'Función modificar: requiere de 3 parametros que se asignarán en el boton modificar que son: 1. la tabla a modificar registros, 2. Los campos afectados, 3, La condición en este caso el código del registro a modificar
    Function modificar(ByVal tabla, ByVal campos, ByVal condicion)
        conexion.Open()
        Dim modificarE As String = "update " + tabla + " set " + campos + " where " + condicion
        'SQLcommand requiere dos parametros: 1. Instruccion sql que será modificarE, almacena la instrucción sql
        '2. Establecer una comunicacion con la base de datos, conexion
        comando = New SqlCommand(modificarE, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    'Función buscar estudiante por medio de su código: requiere el código que este sera enviado en el boton buscar o en el txtCodigo como busqueda por sugerencia con Like
    Function buscarEstudiante(ByVal condicion) As DataTable
        Try
            conexion.Open()
            Dim buscar As String = "select * from personas.estudiante " + " where " + condicion
            'SQLcommand requiere dos parametros: 1. Instruccion sql que será 'buscar', almacena la instrucción sql
            '2. Establecer una comunicacion con la base de datos, conexion
            Dim cmd As New SqlCommand(buscar, conexion)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

End Class
