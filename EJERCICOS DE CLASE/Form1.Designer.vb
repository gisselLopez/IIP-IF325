<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
        Me.components = New System.ComponentModel.Container()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnEmpleados = New System.Windows.Forms.Button()
        Me.Panelsuperior = New System.Windows.Forms.FlowLayoutPanel()
        Me.TimerOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.TimerMostrar = New System.Windows.Forms.Timer(Me.components)
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.PanelLateral = New System.Windows.Forms.Panel()
        Me.Panelforms = New System.Windows.Forms.Panel()
        Me.BtnProducto = New System.Windows.Forms.Button()
        Me.PanelLateral.SuspendLayout()
        Me.Panelforms.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(412, 341)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Location = New System.Drawing.Point(412, 312)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(75, 23)
        Me.btnMaximizar.TabIndex = 1
        Me.btnMaximizar.Text = "Maximizar"
        Me.btnMaximizar.UseVisualStyleBackColor = True
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Location = New System.Drawing.Point(412, 283)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(75, 23)
        Me.btnMinimizar.TabIndex = 2
        Me.btnMinimizar.Text = "Minimizar"
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Location = New System.Drawing.Point(412, 254)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(75, 23)
        Me.btnRestaurar.TabIndex = 3
        Me.btnRestaurar.Text = "Restaurar"
        Me.btnRestaurar.UseVisualStyleBackColor = True
        '
        'btnEmpleados
        '
        Me.btnEmpleados.Location = New System.Drawing.Point(3, 52)
        Me.btnEmpleados.Name = "btnEmpleados"
        Me.btnEmpleados.Size = New System.Drawing.Size(75, 23)
        Me.btnEmpleados.TabIndex = 5
        Me.btnEmpleados.Text = "Empleados"
        Me.btnEmpleados.UseVisualStyleBackColor = True
        '
        'Panelsuperior
        '
        Me.Panelsuperior.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panelsuperior.Location = New System.Drawing.Point(0, 0)
        Me.Panelsuperior.Name = "Panelsuperior"
        Me.Panelsuperior.Size = New System.Drawing.Size(490, 28)
        Me.Panelsuperior.TabIndex = 6
        '
        'TimerOcultarMenu
        '
        '
        'TimerMostrar
        '
        '
        'btnMenu
        '
        Me.btnMenu.Location = New System.Drawing.Point(412, 225)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(75, 23)
        Me.btnMenu.TabIndex = 7
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'PanelLateral
        '
        Me.PanelLateral.Controls.Add(Me.BtnProducto)
        Me.PanelLateral.Controls.Add(Me.btnEmpleados)
        Me.PanelLateral.Location = New System.Drawing.Point(3, 0)
        Me.PanelLateral.Name = "PanelLateral"
        Me.PanelLateral.Size = New System.Drawing.Size(193, 362)
        Me.PanelLateral.TabIndex = 8
        '
        'Panelforms
        '
        Me.Panelforms.Controls.Add(Me.PanelLateral)
        Me.Panelforms.Controls.Add(Me.btnMenu)
        Me.Panelforms.Controls.Add(Me.btnCerrar)
        Me.Panelforms.Controls.Add(Me.btnMaximizar)
        Me.Panelforms.Controls.Add(Me.btnMinimizar)
        Me.Panelforms.Controls.Add(Me.btnRestaurar)
        Me.Panelforms.Location = New System.Drawing.Point(0, 25)
        Me.Panelforms.Name = "Panelforms"
        Me.Panelforms.Size = New System.Drawing.Size(490, 365)
        Me.Panelforms.TabIndex = 7
        '
        'BtnProducto
        '
        Me.BtnProducto.Location = New System.Drawing.Point(0, 110)
        Me.BtnProducto.Name = "BtnProducto"
        Me.BtnProducto.Size = New System.Drawing.Size(75, 23)
        Me.BtnProducto.TabIndex = 6
        Me.BtnProducto.Text = "Productos"
        Me.BtnProducto.UseVisualStyleBackColor = True
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 389)
        Me.Controls.Add(Me.Panelforms)
        Me.Controls.Add(Me.Panelsuperior)
        Me.Name = "FormMenu"
        Me.Text = "Form1"
        Me.PanelLateral.ResumeLayout(False)
        Me.Panelforms.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents btnEmpleados As Button
    Friend WithEvents Panelsuperior As FlowLayoutPanel
    Friend WithEvents TimerOcultarMenu As Timer
    Friend WithEvents TimerMostrar As Timer
    Friend WithEvents btnMenu As Button
    Friend WithEvents PanelLateral As Panel
    Friend WithEvents BtnProducto As Button
    Friend WithEvents Panelforms As Panel
End Class
