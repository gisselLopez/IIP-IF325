<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ARREGLOSCLASE
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btngenerar = New System.Windows.Forms.Button()
        Me.btnGenerarprecio = New System.Windows.Forms.Button()
        Me.Cmbcomputadoras = New System.Windows.Forms.ComboBox()
        Me.CmbPrecios = New System.Windows.Forms.ComboBox()
        Me.btnsolicitar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbcompus = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.CmbPrecios)
        Me.GroupBox1.Controls.Add(Me.Cmbcomputadoras)
        Me.GroupBox1.Controls.Add(Me.btnGenerarprecio)
        Me.GroupBox1.Controls.Add(Me.btngenerar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(241, 264)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbcompus)
        Me.GroupBox2.Controls.Add(Me.btnsolicitar)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtcantidad)
        Me.GroupBox2.Location = New System.Drawing.Point(272, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(249, 264)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'btngenerar
        '
        Me.btngenerar.Location = New System.Drawing.Point(30, 46)
        Me.btngenerar.Name = "btngenerar"
        Me.btngenerar.Size = New System.Drawing.Size(75, 36)
        Me.btngenerar.TabIndex = 0
        Me.btngenerar.Text = "Generar"
        Me.btngenerar.UseVisualStyleBackColor = True
        '
        'btnGenerarprecio
        '
        Me.btnGenerarprecio.Location = New System.Drawing.Point(137, 46)
        Me.btnGenerarprecio.Name = "btnGenerarprecio"
        Me.btnGenerarprecio.Size = New System.Drawing.Size(75, 36)
        Me.btnGenerarprecio.TabIndex = 1
        Me.btnGenerarprecio.Text = "Generar Precio"
        Me.btnGenerarprecio.UseVisualStyleBackColor = True
        '
        'Cmbcomputadoras
        '
        Me.Cmbcomputadoras.FormattingEnabled = True
        Me.Cmbcomputadoras.Location = New System.Drawing.Point(6, 139)
        Me.Cmbcomputadoras.Name = "Cmbcomputadoras"
        Me.Cmbcomputadoras.Size = New System.Drawing.Size(99, 21)
        Me.Cmbcomputadoras.TabIndex = 2
        '
        'CmbPrecios
        '
        Me.CmbPrecios.FormattingEnabled = True
        Me.CmbPrecios.Location = New System.Drawing.Point(126, 139)
        Me.CmbPrecios.Name = "CmbPrecios"
        Me.CmbPrecios.Size = New System.Drawing.Size(109, 21)
        Me.CmbPrecios.TabIndex = 3
        '
        'btnsolicitar
        '
        Me.btnsolicitar.Location = New System.Drawing.Point(104, 69)
        Me.btnsolicitar.Name = "btnsolicitar"
        Me.btnsolicitar.Size = New System.Drawing.Size(75, 23)
        Me.btnsolicitar.TabIndex = 4
        Me.btnsolicitar.Text = "Solicitar"
        Me.btnsolicitar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(30, 199)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 5
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(79, 32)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtcantidad.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "cantidad"
        '
        'cmbcompus
        '
        Me.cmbcompus.FormattingEnabled = True
        Me.cmbcompus.Location = New System.Drawing.Point(79, 98)
        Me.cmbcompus.Name = "cmbcompus"
        Me.cmbcompus.Size = New System.Drawing.Size(121, 21)
        Me.cmbcompus.TabIndex = 2
        '
        'ARREGLOSCLASE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 303)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ARREGLOSCLASE"
        Me.Text = "ARREGLOSCLASE"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnsolicitar As Button
    Friend WithEvents CmbPrecios As ComboBox
    Friend WithEvents Cmbcomputadoras As ComboBox
    Friend WithEvents btnGenerarprecio As Button
    Friend WithEvents btngenerar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents cmbcompus As ComboBox
End Class
