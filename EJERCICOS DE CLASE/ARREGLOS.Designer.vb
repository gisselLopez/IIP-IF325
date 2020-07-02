<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MENU
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
        Me.PanelMenuLateral = New System.Windows.Forms.Panel()
        Me.Panelsubmenu = New System.Windows.Forms.Panel()
        Me.btnejercicio2 = New System.Windows.Forms.Button()
        Me.btnejercicios1 = New System.Windows.Forms.Button()
        Me.btnmenu = New System.Windows.Forms.Button()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panelformulario = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TimerOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.TimerMostrar = New System.Windows.Forms.Timer(Me.components)
        Me.PanelMenuLateral.SuspendLayout()
        Me.Panelsubmenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelformulario.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenuLateral
        '
        Me.PanelMenuLateral.AutoScroll = True
        Me.PanelMenuLateral.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PanelMenuLateral.Controls.Add(Me.Panelsubmenu)
        Me.PanelMenuLateral.Controls.Add(Me.btnmenu)
        Me.PanelMenuLateral.Controls.Add(Me.PanelLogo)
        Me.PanelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenuLateral.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenuLateral.Name = "PanelMenuLateral"
        Me.PanelMenuLateral.Size = New System.Drawing.Size(115, 413)
        Me.PanelMenuLateral.TabIndex = 0
        '
        'Panelsubmenu
        '
        Me.Panelsubmenu.AutoScroll = True
        Me.Panelsubmenu.BackColor = System.Drawing.Color.Black
        Me.Panelsubmenu.Controls.Add(Me.btnejercicio2)
        Me.Panelsubmenu.Controls.Add(Me.btnejercicios1)
        Me.Panelsubmenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panelsubmenu.Location = New System.Drawing.Point(0, 159)
        Me.Panelsubmenu.Name = "Panelsubmenu"
        Me.Panelsubmenu.Size = New System.Drawing.Size(115, 81)
        Me.Panelsubmenu.TabIndex = 2
        '
        'btnejercicio2
        '
        Me.btnejercicio2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnejercicio2.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnejercicio2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnejercicio2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnejercicio2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnejercicio2.Location = New System.Drawing.Point(0, 34)
        Me.btnejercicio2.Name = "btnejercicio2"
        Me.btnejercicio2.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnejercicio2.Size = New System.Drawing.Size(115, 33)
        Me.btnejercicio2.TabIndex = 1
        Me.btnejercicio2.Text = "Ejercicio 2"
        Me.btnejercicio2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnejercicio2.UseVisualStyleBackColor = False
        '
        'btnejercicios1
        '
        Me.btnejercicios1.BackColor = System.Drawing.SystemColors.Window
        Me.btnejercicios1.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnejercicios1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnejercicios1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnejercicios1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnejercicios1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnejercicios1.Location = New System.Drawing.Point(0, 0)
        Me.btnejercicios1.Name = "btnejercicios1"
        Me.btnejercicios1.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnejercicios1.Size = New System.Drawing.Size(115, 34)
        Me.btnejercicios1.TabIndex = 0
        Me.btnejercicios1.Text = "Ejercicio 1"
        Me.btnejercicios1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnejercicios1.UseVisualStyleBackColor = False
        '
        'btnmenu
        '
        Me.btnmenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnmenu.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia
        Me.btnmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmenu.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnmenu.Location = New System.Drawing.Point(0, 109)
        Me.btnmenu.Name = "btnmenu"
        Me.btnmenu.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnmenu.Size = New System.Drawing.Size(115, 50)
        Me.btnmenu.TabIndex = 1
        Me.btnmenu.Text = "Menu"
        Me.btnmenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmenu.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.PictureBox1)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(115, 109)
        Me.PanelLogo.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EJERCICOS_DE_CLASE.My.Resources.Resources.LOGO
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(117, 109)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panelformulario
        '
        Me.Panelformulario.BackColor = System.Drawing.Color.MediumOrchid
        Me.Panelformulario.Controls.Add(Me.Panel4)
        Me.Panelformulario.Controls.Add(Me.Panel3)
        Me.Panelformulario.Controls.Add(Me.Panel2)
        Me.Panelformulario.Controls.Add(Me.Panel1)
        Me.Panelformulario.Controls.Add(Me.PictureBox2)
        Me.Panelformulario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panelformulario.Location = New System.Drawing.Point(115, 0)
        Me.Panelformulario.Name = "Panelformulario"
        Me.Panelformulario.Size = New System.Drawing.Size(601, 413)
        Me.Panelformulario.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(10, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(581, 14)
        Me.Panel4.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(10, 398)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(581, 15)
        Me.Panel3.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 413)
        Me.Panel2.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(591, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 413)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.EJERCICOS_DE_CLASE.My.Resources.Resources.gif_ingenieria
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(601, 413)
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
        'MENU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumVioletRed
        Me.ClientSize = New System.Drawing.Size(716, 413)
        Me.Controls.Add(Me.Panelformulario)
        Me.Controls.Add(Me.PanelMenuLateral)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MENU"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MENU"
        Me.PanelMenuLateral.ResumeLayout(False)
        Me.Panelsubmenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelformulario.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenuLateral As Panel
    Friend WithEvents Panelsubmenu As Panel
    Friend WithEvents btnejercicios1 As Button
    Friend WithEvents btnmenu As Button
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents Panelformulario As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TimerOcultarMenu As Timer
    Friend WithEvents TimerMostrar As Timer
    Friend WithEvents btnejercicio2 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
End Class
