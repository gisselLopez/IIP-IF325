<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.PanelLateral = New System.Windows.Forms.Panel()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnMaximizar = New System.Windows.Forms.PictureBox()
        Me.btncerrar = New System.Windows.Forms.PictureBox()
        Me.Panelmenu = New System.Windows.Forms.Panel()
        Me.Panelsubmenu = New System.Windows.Forms.Panel()
        Me.btnEjercicio1 = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelFormulario = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TimerOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.TimerMostrar = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTipMSJ = New System.Windows.Forms.ToolTip(Me.components)
        Me.PanelLateral.SuspendLayout()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btncerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelmenu.SuspendLayout()
        Me.Panelsubmenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFormulario.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelLateral
        '
        Me.PanelLateral.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelLateral.Controls.Add(Me.btnMinimizar)
        Me.PanelLateral.Controls.Add(Me.btnMaximizar)
        Me.PanelLateral.Controls.Add(Me.btncerrar)
        Me.PanelLateral.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLateral.Location = New System.Drawing.Point(0, 0)
        Me.PanelLateral.Name = "PanelLateral"
        Me.PanelLateral.Size = New System.Drawing.Size(750, 29)
        Me.PanelLateral.TabIndex = 0
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Image = Global.TAREAS_ENTORNOS.My.Resources.Resources.Minimizar
        Me.btnMinimizar.Location = New System.Drawing.Point(616, 2)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(33, 21)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMinimizar.TabIndex = 2
        Me.btnMinimizar.TabStop = False
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Image = Global.TAREAS_ENTORNOS.My.Resources.Resources.Maximizar
        Me.btnMaximizar.Location = New System.Drawing.Point(655, 2)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(43, 21)
        Me.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMaximizar.TabIndex = 1
        Me.btnMaximizar.TabStop = False
        '
        'btncerrar
        '
        Me.btncerrar.Image = Global.TAREAS_ENTORNOS.My.Resources.Resources.cerrar
        Me.btncerrar.Location = New System.Drawing.Point(704, 3)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(34, 21)
        Me.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btncerrar.TabIndex = 0
        Me.btncerrar.TabStop = False
        '
        'Panelmenu
        '
        Me.Panelmenu.AutoScroll = True
        Me.Panelmenu.BackColor = System.Drawing.Color.Black
        Me.Panelmenu.Controls.Add(Me.Panelsubmenu)
        Me.Panelmenu.Controls.Add(Me.btnMenu)
        Me.Panelmenu.Controls.Add(Me.PanelLogo)
        Me.Panelmenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panelmenu.Location = New System.Drawing.Point(0, 29)
        Me.Panelmenu.Name = "Panelmenu"
        Me.Panelmenu.Size = New System.Drawing.Size(114, 384)
        Me.Panelmenu.TabIndex = 1
        '
        'Panelsubmenu
        '
        Me.Panelsubmenu.Controls.Add(Me.btnEjercicio1)
        Me.Panelsubmenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panelsubmenu.Location = New System.Drawing.Point(0, 135)
        Me.Panelsubmenu.Name = "Panelsubmenu"
        Me.Panelsubmenu.Size = New System.Drawing.Size(114, 76)
        Me.Panelsubmenu.TabIndex = 2
        '
        'btnEjercicio1
        '
        Me.btnEjercicio1.BackColor = System.Drawing.Color.Purple
        Me.btnEjercicio1.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEjercicio1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEjercicio1.Location = New System.Drawing.Point(0, 0)
        Me.btnEjercicio1.Name = "btnEjercicio1"
        Me.btnEjercicio1.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.btnEjercicio1.Size = New System.Drawing.Size(114, 35)
        Me.btnEjercicio1.TabIndex = 0
        Me.btnEjercicio1.Text = "Ejercicio 1"
        Me.btnEjercicio1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEjercicio1.UseVisualStyleBackColor = False
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMenu.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMenu.Location = New System.Drawing.Point(0, 100)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnMenu.Size = New System.Drawing.Size(114, 35)
        Me.btnMenu.TabIndex = 1
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.PictureBox1)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(114, 100)
        Me.PanelLogo.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TAREAS_ENTORNOS.My.Resources.Resources.LOGO
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(105, 91)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelFormulario
        '
        Me.PanelFormulario.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelFormulario.Controls.Add(Me.PictureBox2)
        Me.PanelFormulario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormulario.Location = New System.Drawing.Point(114, 29)
        Me.PanelFormulario.Name = "PanelFormulario"
        Me.PanelFormulario.Size = New System.Drawing.Size(636, 384)
        Me.PanelFormulario.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.TAREAS_ENTORNOS.My.Resources.Resources.gif
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(636, 384)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'TimerOcultarMenu
        '
        '
        'TimerMostrar
        '
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 413)
        Me.Controls.Add(Me.PanelFormulario)
        Me.Controls.Add(Me.Panelmenu)
        Me.Controls.Add(Me.PanelLateral)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.PanelLateral.ResumeLayout(False)
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btncerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelmenu.ResumeLayout(False)
        Me.Panelsubmenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFormulario.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelLateral As Panel
    Friend WithEvents Panelmenu As Panel
    Friend WithEvents Panelsubmenu As Panel
    Friend WithEvents btnEjercicio1 As Button
    Friend WithEvents btnMenu As Button
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelFormulario As Panel
    Friend WithEvents TimerOcultarMenu As Timer
    Friend WithEvents TimerMostrar As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnMaximizar As PictureBox
    Friend WithEvents btncerrar As PictureBox
    Friend WithEvents ToolTipMSJ As ToolTip
End Class
