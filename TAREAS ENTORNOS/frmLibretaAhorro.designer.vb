<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLibretaAhorro
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
        Me.cmbpais = New System.Windows.Forms.ComboBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtedad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAperturar = New System.Windows.Forms.Button()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnRetirar = New System.Windows.Forms.Button()
        Me.btnDepositar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.Saldo = New System.Windows.Forms.Label()
        Me.lstRetiros = New System.Windows.Forms.ListBox()
        Me.lstDepositos = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.cmbpais)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.txtedad)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnAperturar)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(9, 4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(316, 220)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de información"
        '
        'cmbpais
        '
        Me.cmbpais.FormattingEnabled = True
        Me.cmbpais.Items.AddRange(New Object() {"Afganistán: Kabul.", "Albania: Tirana.", "Alemania: Berlín.", "Andorra: Andorra la Vieja.", "Angola: Luanda.", "Antigua y Barbuda: Saint John's.", "Arabia Saudita: Riad.", "Argelia: Argel.", "Argentina: Buenos Aires.", "Armenia: Ereván.", "Australia: Camberra.", "Austria: Viena.", "Azerbaiyán: Bakú.", "Bahamas: Nasáu.", "Bangladés: Daca.", "Barbados: Bridgetown.", "Baréin: Manama.", "Bélgica: Bruselas.", "Belice: Belmopán.", "Benín: Porto Novo y Cotonú.", "Bielorrusia: Minsk.", "Birmania: Naipyidó.", "Bolivia: Sucre. (*)", "Bosnia y Herzegovina: Sarajevo.", "Botsuana: Gaborone.", "Brasil: Brasilia.", "Brunéi: Bandar Seri Begawan.", "Bulgaria: Sofía.", "Burkina Faso: Uagadugú.", "Burundi: Gitega.", "Bután: Timbu.", "Cabo Verde: Praia.", "Camboya: Nom Pen.", "Camerún: Yaundé.", "Canadá: Ottawa.", "Catar: Doha.", "Chad: Yamena.", "Chile: Santiago de Chile.", "China: Pekín.", "Chipre: Nicosia.", "Ciudad del Vaticano: Ciudad del Vaticano.", "Colombia: Bogotá.", "Comoras: Moroni.", "Corea del Norte: Pionyang.", "Corea del Sur: Seúl.", "Costa de Marfil: Yamusukro.", "Costa Rica: San José.", "Croacia: Zagreb.", "Cuba: La Habana.", "Dinamarca: Copenhague.", "Dominica: Roseau.", "Ecuador: Quito.", "Egipto: El Cairo.", "El Salvador: San Salvador.", "Emiratos Árabes Unidos: Abu Dabi.", "Eritrea: Asmara.", "Eslovaquia: Bratislava.", "Eslovenia: Liubliana.", "España: Madrid.", "Estados Unidos: Washington D. C.", "Estonia: Tallin.", "Etiopía: Adís Abeba.", "Filipinas: Manila.", "Finlandia: Helsinki.", "Fiyi: Suva.", "Francia: París.", "Gabón: Libreville.", "Gambia: Banjul.", "Georgia: Tiflis.", "Ghana: Acra.", "Granada: Saint George.", "Grecia: Atenas.", "Guatemala: Ciudad de Guatemala.", "Guyana: Georgetown.", "Guinea: Conakri.", "Guinea-Bisáu: Bisáu.", "Guinea Ecuatorial: Malabo.", "Haití: Puerto Príncipe.", "Honduras: Tegucigalpa.", "Hungría: Budapest.", "India: Nueva Delhi.", "Indonesia: Yakarta.", "Irak: Bagdad.", "Irán: Teherán.", "Irlanda: Dublín.", "Islandia: Reikiavik.", "Islas Marshall: Majuro.", "Islas Salomón: Honiara.", "Israel: Jerusalén.", "Italia: Roma.", "Jamaica: Kingston.", "Japón: Tokio.", "Jordania: Amán.", "Kazajistán: Astaná.", "Kenia: Nairobi.", "Kirguistán: Biskek.", "Kiribati: Tarawa.", "Kuwait: Kuwait.", "Laos: Vientián.", "Lesoto: Maseru.", "Letonia: Riga.", "Líbano: Beirut.", "Liberia: Monrovia.", "Libia: Trípoli.", "Liechtenstein: Vaduz.", "Lituania: Vilna.", "Luxemburgo: Luxemburgo.", "Macedonia del Norte: Skopie.", "Madagascar: Antananarivo.", "Malasia: Kuala Lumpur.", "Malaui: Lilongüe.", "Maldivas: Malé.", "Malí: Bamako.", "Malta: La Valeta.", "Marruecos: Rabat.", "Mauricio: Port-Louis.", "Mauritania: Nuakchot.", "México: Ciudad de México. (*)", "Micronesia: Palikir.", "Moldavia: Chisináu.", "Mónaco: Mónaco.", "Mongolia: Ulán Bator.", "Montenegro: Podgorica.", "Mozambique: Maputo.", "Namibia: Windhoek.", "Nauru: Yaren.", "Nepal: Katmandú.", "Nicaragua: Managua.", "Níger: Niamey.", "Nigeria: Abuya.", "Noruega: Oslo.", "Nueva Zelanda: Wellington.", "Omán: Mascate.", "Países Bajos: Ámsterdam. (*)", "Pakistán: Islamabad.", "Palaos: Melekeok.", "Panamá: Panamá.", "Papúa Nueva Guinea: Port Moresby.", "Paraguay: Asunción.", "Perú: Lima.", "Polonia: Varsovia.", "Portugal: Lisboa.", "Reino Unido de Gran Bretaña e Irlanda del Norte: Londres. (*)", "República Centroafricana: Bangui.", "República Checa: Praga.", "República del Congo: Brazzaville.", "República Democrática del Congo: Kinsasa.", "República Dominicana: Santo Domingo.", "República Sudafricana: Bloemfontein, Ciudad Del Cabo y Pretoria. (*)", "Ruanda: Kigali.", "Rumanía: Bucarest.", "Rusia: Moscú.", "Samoa: Apia.", "San Cristóbal y Nieves: Basseterre.", "San Marino: San Marino.", "San Vicente y las Granadinas: Kingstown.", "Santa Lucía: Castries.", "Santo Tomé y Príncipe: Santo Tomé.", "Senegal: Dakar.", "Serbia: Belgrado.", "Seychelles: Victoria.", "Sierra Leona: Freetown.", "Singapur: Singapur.", "Siria: Damasco.", "Somalia: Mogadiscio.", "Sri Lanka: Sri Jayewardenepura ", "Suazilandia: Babane y Lobamba.", "Sudán: Jartum.", "Sudán del Sur: Yuba.", "Suecia: Estocolmo.", "Suiza: Berna.", "Surinam: Paramaribo.", "Tailandia: Bangkok.", "Tanzania: Dodoma.", "Tayikistán: Dusambé.", "Timor Oriental: Dili.", "Togo: Lomé.", "Tonga: Nukualofa.", "Trinidad y Tobago: Puerto España.", "Túnez: Túnez.", "Turkmenistán: Asjabad.", "Turquía: Ankara.", "Tuvalu: Fongafale.", "Ucrania: Kiev.", "Uganda: Kampala.", "Uruguay: Montevideo.", "Uzbekistán: Taskent.", "Vanuatu: Port Vila.", "Venezuela: Caracas.", "Vietnam: Hanói.", "Yemen: Saná.", "Yibuti: Yibuti.", "Zambia: Lusaka.", "Zimbabue: Harare."})
        Me.cmbpais.Location = New System.Drawing.Point(7, 182)
        Me.cmbpais.Name = "cmbpais"
        Me.cmbpais.Size = New System.Drawing.Size(207, 23)
        Me.cmbpais.TabIndex = 10
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(120, 122)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(108, 21)
        Me.txtId.TabIndex = 9
        '
        'txtedad
        '
        Me.txtedad.Location = New System.Drawing.Point(120, 86)
        Me.txtedad.Name = "txtedad"
        Me.txtedad.Size = New System.Drawing.Size(108, 21)
        Me.txtedad.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Pais(ciudad)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Identidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Edad"
        '
        'btnAperturar
        '
        Me.btnAperturar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAperturar.Location = New System.Drawing.Point(233, 150)
        Me.btnAperturar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAperturar.Name = "btnAperturar"
        Me.btnAperturar.Size = New System.Drawing.Size(79, 42)
        Me.btnAperturar.TabIndex = 4
        Me.btnAperturar.Text = "Aperturar Cuenta"
        Me.btnAperturar.UseVisualStyleBackColor = True
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(120, 55)
        Me.txtMonto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(108, 21)
        Me.txtMonto.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(120, 30)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(108, 21)
        Me.txtNombre.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 55)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Monto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Usuario"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.btnRetirar)
        Me.GroupBox2.Controls.Add(Me.btnDepositar)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Location = New System.Drawing.Point(9, 235)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(310, 59)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Operaciones"
        '
        'btnRetirar
        '
        Me.btnRetirar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRetirar.Location = New System.Drawing.Point(132, 17)
        Me.btnRetirar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRetirar.Name = "btnRetirar"
        Me.btnRetirar.Size = New System.Drawing.Size(80, 37)
        Me.btnRetirar.TabIndex = 1
        Me.btnRetirar.Text = "Retirar"
        Me.btnRetirar.UseVisualStyleBackColor = True
        '
        'btnDepositar
        '
        Me.btnDepositar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDepositar.Location = New System.Drawing.Point(17, 17)
        Me.btnDepositar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDepositar.Name = "btnDepositar"
        Me.btnDepositar.Size = New System.Drawing.Size(82, 37)
        Me.btnDepositar.TabIndex = 0
        Me.btnDepositar.Text = "Depositar"
        Me.btnDepositar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.btnLimpiar)
        Me.GroupBox3.Controls.Add(Me.txtSaldo)
        Me.GroupBox3.Controls.Add(Me.Saldo)
        Me.GroupBox3.Controls.Add(Me.lstRetiros)
        Me.GroupBox3.Controls.Add(Me.lstDepositos)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox3.Location = New System.Drawing.Point(329, 4)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(224, 290)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Historial"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnLimpiar.Location = New System.Drawing.Point(135, 236)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(64, 37)
        Me.btnLimpiar.TabIndex = 6
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'txtSaldo
        '
        Me.txtSaldo.Location = New System.Drawing.Point(119, 184)
        Me.txtSaldo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(80, 21)
        Me.txtSaldo.TabIndex = 5
        '
        'Saldo
        '
        Me.Saldo.AutoSize = True
        Me.Saldo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Saldo.Location = New System.Drawing.Point(119, 150)
        Me.Saldo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Saldo.Name = "Saldo"
        Me.Saldo.Size = New System.Drawing.Size(80, 15)
        Me.Saldo.TabIndex = 2
        Me.Saldo.Text = "Saldo Total"
        '
        'lstRetiros
        '
        Me.lstRetiros.FormattingEnabled = True
        Me.lstRetiros.ItemHeight = 15
        Me.lstRetiros.Location = New System.Drawing.Point(10, 164)
        Me.lstRetiros.Margin = New System.Windows.Forms.Padding(2)
        Me.lstRetiros.Name = "lstRetiros"
        Me.lstRetiros.Size = New System.Drawing.Size(105, 109)
        Me.lstRetiros.TabIndex = 1
        '
        'lstDepositos
        '
        Me.lstDepositos.FormattingEnabled = True
        Me.lstDepositos.ItemHeight = 15
        Me.lstDepositos.Location = New System.Drawing.Point(10, 17)
        Me.lstDepositos.Margin = New System.Windows.Forms.Padding(2)
        Me.lstDepositos.Name = "lstDepositos"
        Me.lstDepositos.Size = New System.Drawing.Size(109, 124)
        Me.lstDepositos.TabIndex = 0
        '
        'frmLibretaAhorro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(534, 301)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmLibretaAhorro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLibretaAhorro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAperturar As Button
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnRetirar As Button
    Friend WithEvents btnDepositar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents Saldo As Label
    Friend WithEvents lstRetiros As ListBox
    Friend WithEvents lstDepositos As ListBox
    Friend WithEvents cmbpais As ComboBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtedad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
