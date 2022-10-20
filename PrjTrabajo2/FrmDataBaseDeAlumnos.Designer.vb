<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDataBaseDeAlumnos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnSi = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnNo = New System.Windows.Forms.Button()
        Me.GbDatos = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumerodeCelular = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechadeNacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Genero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Editar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TxtNombres = New System.Windows.Forms.TextBox()
        Me.TxtDNI = New System.Windows.Forms.TextBox()
        Me.TxtApellidos = New System.Windows.Forms.TextBox()
        Me.TxtNumeroDeCelular = New System.Windows.Forms.TextBox()
        Me.CmbDia = New System.Windows.Forms.ComboBox()
        Me.CmbMes = New System.Windows.Forms.ComboBox()
        Me.TxtAño = New System.Windows.Forms.TextBox()
        Me.LblNombres = New System.Windows.Forms.Label()
        Me.LblApellidos = New System.Windows.Forms.Label()
        Me.LblDNI = New System.Windows.Forms.Label()
        Me.LblNumeroDeCelular = New System.Windows.Forms.Label()
        Me.LblDia = New System.Windows.Forms.Label()
        Me.LblMes = New System.Windows.Forms.Label()
        Me.LblAño = New System.Windows.Forms.Label()
        Me.LblFechaDeNacimiento = New System.Windows.Forms.Label()
        Me.LblGenero = New System.Windows.Forms.Label()
        Me.CmbGenero = New System.Windows.Forms.ComboBox()
        Me.BtnEliminarTodo = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.GbDatos.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSi
        '
        Me.BtnSi.Location = New System.Drawing.Point(20, 152)
        Me.BtnSi.Name = "BtnSi"
        Me.BtnSi.Size = New System.Drawing.Size(75, 23)
        Me.BtnSi.TabIndex = 10
        Me.BtnSi.Text = "SI"
        Me.BtnSi.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(428, 12)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregar.TabIndex = 8
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnNo
        '
        Me.BtnNo.Location = New System.Drawing.Point(112, 152)
        Me.BtnNo.Name = "BtnNo"
        Me.BtnNo.Size = New System.Drawing.Size(75, 23)
        Me.BtnNo.TabIndex = 11
        Me.BtnNo.Text = "NO"
        Me.BtnNo.UseVisualStyleBackColor = True
        '
        'GbDatos
        '
        Me.GbDatos.Controls.Add(Me.Label1)
        Me.GbDatos.Controls.Add(Me.Label2)
        Me.GbDatos.Controls.Add(Me.BtnSi)
        Me.GbDatos.Controls.Add(Me.BtnNo)
        Me.GbDatos.Location = New System.Drawing.Point(631, 12)
        Me.GbDatos.Name = "GbDatos"
        Me.GbDatos.Size = New System.Drawing.Size(204, 183)
        Me.GbDatos.TabIndex = 6
        Me.GbDatos.TabStop = False
        Me.GbDatos.Text = "Datos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Nombres:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Nombres:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Apellidos, Me.DNI, Me.NumerodeCelular, Me.FechadeNacimiento, Me.Genero, Me.Editar, Me.Eliminar})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 207)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(833, 103)
        Me.DataGridView1.TabIndex = 12
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Apellidos
        '
        Me.Apellidos.HeaderText = "Apellidos"
        Me.Apellidos.Name = "Apellidos"
        '
        'DNI
        '
        Me.DNI.HeaderText = "DNI"
        Me.DNI.Name = "DNI"
        '
        'NumerodeCelular
        '
        Me.NumerodeCelular.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NumerodeCelular.HeaderText = "Número de Celular"
        Me.NumerodeCelular.Name = "NumerodeCelular"
        '
        'FechadeNacimiento
        '
        Me.FechadeNacimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FechadeNacimiento.HeaderText = "Fecha de Nacimiento"
        Me.FechadeNacimiento.Name = "FechadeNacimiento"
        '
        'Genero
        '
        Me.Genero.HeaderText = "Genero"
        Me.Genero.Name = "Genero"
        '
        'Editar
        '
        Me.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Editar.HeaderText = "Editar"
        Me.Editar.Name = "Editar"
        Me.Editar.Width = 40
        '
        'Eliminar
        '
        Me.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Width = 49
        '
        'TxtNombres
        '
        Me.TxtNombres.Location = New System.Drawing.Point(108, 12)
        Me.TxtNombres.Name = "TxtNombres"
        Me.TxtNombres.Size = New System.Drawing.Size(130, 20)
        Me.TxtNombres.TabIndex = 0
        '
        'TxtDNI
        '
        Me.TxtDNI.Location = New System.Drawing.Point(108, 64)
        Me.TxtDNI.Name = "TxtDNI"
        Me.TxtDNI.Size = New System.Drawing.Size(130, 20)
        Me.TxtDNI.TabIndex = 2
        '
        'TxtApellidos
        '
        Me.TxtApellidos.Location = New System.Drawing.Point(108, 38)
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.Size = New System.Drawing.Size(130, 20)
        Me.TxtApellidos.TabIndex = 1
        '
        'TxtNumeroDeCelular
        '
        Me.TxtNumeroDeCelular.Location = New System.Drawing.Point(108, 90)
        Me.TxtNumeroDeCelular.Name = "TxtNumeroDeCelular"
        Me.TxtNumeroDeCelular.Size = New System.Drawing.Size(130, 20)
        Me.TxtNumeroDeCelular.TabIndex = 3
        '
        'CmbDia
        '
        Me.CmbDia.FormattingEnabled = True
        Me.CmbDia.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"})
        Me.CmbDia.Location = New System.Drawing.Point(141, 142)
        Me.CmbDia.Name = "CmbDia"
        Me.CmbDia.Size = New System.Drawing.Size(46, 21)
        Me.CmbDia.TabIndex = 4
        '
        'CmbMes
        '
        Me.CmbMes.FormattingEnabled = True
        Me.CmbMes.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.CmbMes.Location = New System.Drawing.Point(193, 142)
        Me.CmbMes.Name = "CmbMes"
        Me.CmbMes.Size = New System.Drawing.Size(45, 21)
        Me.CmbMes.TabIndex = 5
        '
        'TxtAño
        '
        Me.TxtAño.Location = New System.Drawing.Point(244, 143)
        Me.TxtAño.Name = "TxtAño"
        Me.TxtAño.Size = New System.Drawing.Size(66, 20)
        Me.TxtAño.TabIndex = 6
        '
        'LblNombres
        '
        Me.LblNombres.AutoSize = True
        Me.LblNombres.Location = New System.Drawing.Point(9, 12)
        Me.LblNombres.Name = "LblNombres"
        Me.LblNombres.Size = New System.Drawing.Size(52, 13)
        Me.LblNombres.TabIndex = 8
        Me.LblNombres.Text = "Nombres:"
        '
        'LblApellidos
        '
        Me.LblApellidos.AutoSize = True
        Me.LblApellidos.Location = New System.Drawing.Point(9, 38)
        Me.LblApellidos.Name = "LblApellidos"
        Me.LblApellidos.Size = New System.Drawing.Size(52, 13)
        Me.LblApellidos.TabIndex = 9
        Me.LblApellidos.Text = "Apellidos:"
        '
        'LblDNI
        '
        Me.LblDNI.AutoSize = True
        Me.LblDNI.Location = New System.Drawing.Point(9, 64)
        Me.LblDNI.Name = "LblDNI"
        Me.LblDNI.Size = New System.Drawing.Size(29, 13)
        Me.LblDNI.TabIndex = 10
        Me.LblDNI.Text = "DNI:"
        '
        'LblNumeroDeCelular
        '
        Me.LblNumeroDeCelular.AutoSize = True
        Me.LblNumeroDeCelular.Location = New System.Drawing.Point(9, 90)
        Me.LblNumeroDeCelular.Name = "LblNumeroDeCelular"
        Me.LblNumeroDeCelular.Size = New System.Drawing.Size(97, 13)
        Me.LblNumeroDeCelular.TabIndex = 11
        Me.LblNumeroDeCelular.Text = "Número de Celular:"
        '
        'LblDia
        '
        Me.LblDia.AutoSize = True
        Me.LblDia.Location = New System.Drawing.Point(151, 126)
        Me.LblDia.Name = "LblDia"
        Me.LblDia.Size = New System.Drawing.Size(25, 13)
        Me.LblDia.TabIndex = 12
        Me.LblDia.Text = "Día"
        '
        'LblMes
        '
        Me.LblMes.AutoSize = True
        Me.LblMes.Location = New System.Drawing.Point(202, 126)
        Me.LblMes.Name = "LblMes"
        Me.LblMes.Size = New System.Drawing.Size(27, 13)
        Me.LblMes.TabIndex = 13
        Me.LblMes.Text = "Mes"
        '
        'LblAño
        '
        Me.LblAño.AutoSize = True
        Me.LblAño.Location = New System.Drawing.Point(264, 126)
        Me.LblAño.Name = "LblAño"
        Me.LblAño.Size = New System.Drawing.Size(26, 13)
        Me.LblAño.TabIndex = 14
        Me.LblAño.Text = "Año"
        '
        'LblFechaDeNacimiento
        '
        Me.LblFechaDeNacimiento.AutoSize = True
        Me.LblFechaDeNacimiento.Location = New System.Drawing.Point(9, 126)
        Me.LblFechaDeNacimiento.Name = "LblFechaDeNacimiento"
        Me.LblFechaDeNacimiento.Size = New System.Drawing.Size(111, 13)
        Me.LblFechaDeNacimiento.TabIndex = 15
        Me.LblFechaDeNacimiento.Text = "Fecha de Nacimiento:"
        '
        'LblGenero
        '
        Me.LblGenero.AutoSize = True
        Me.LblGenero.Location = New System.Drawing.Point(9, 174)
        Me.LblGenero.Name = "LblGenero"
        Me.LblGenero.Size = New System.Drawing.Size(45, 13)
        Me.LblGenero.TabIndex = 16
        Me.LblGenero.Text = "Genero:"
        '
        'CmbGenero
        '
        Me.CmbGenero.FormattingEnabled = True
        Me.CmbGenero.Items.AddRange(New Object() {"Femenino", "Masculino", "Otros..."})
        Me.CmbGenero.Location = New System.Drawing.Point(108, 174)
        Me.CmbGenero.Name = "CmbGenero"
        Me.CmbGenero.Size = New System.Drawing.Size(95, 21)
        Me.CmbGenero.TabIndex = 7
        '
        'BtnEliminarTodo
        '
        Me.BtnEliminarTodo.Location = New System.Drawing.Point(509, 12)
        Me.BtnEliminarTodo.Name = "BtnEliminarTodo"
        Me.BtnEliminarTodo.Size = New System.Drawing.Size(117, 23)
        Me.BtnEliminarTodo.TabIndex = 9
        Me.BtnEliminarTodo.Text = "Eliminar Todo"
        Me.BtnEliminarTodo.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(508, 169)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(117, 23)
        Me.BtnCancelar.TabIndex = 17
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'FrmDataBaseDeAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 322)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnEliminarTodo)
        Me.Controls.Add(Me.CmbGenero)
        Me.Controls.Add(Me.LblGenero)
        Me.Controls.Add(Me.LblFechaDeNacimiento)
        Me.Controls.Add(Me.LblAño)
        Me.Controls.Add(Me.LblMes)
        Me.Controls.Add(Me.LblDia)
        Me.Controls.Add(Me.LblNumeroDeCelular)
        Me.Controls.Add(Me.LblDNI)
        Me.Controls.Add(Me.LblApellidos)
        Me.Controls.Add(Me.LblNombres)
        Me.Controls.Add(Me.TxtAño)
        Me.Controls.Add(Me.CmbMes)
        Me.Controls.Add(Me.CmbDia)
        Me.Controls.Add(Me.TxtNumeroDeCelular)
        Me.Controls.Add(Me.TxtApellidos)
        Me.Controls.Add(Me.TxtDNI)
        Me.Controls.Add(Me.TxtNombres)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GbDatos)
        Me.Controls.Add(Me.BtnAgregar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmDataBaseDeAlumnos"
        Me.Text = "Data Base de Alumnos"
        Me.GbDatos.ResumeLayout(False)
        Me.GbDatos.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSi As System.Windows.Forms.Button
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents BtnNo As System.Windows.Forms.Button
    Friend WithEvents GbDatos As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellidos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DNI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumerodeCelular As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechadeNacimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Genero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Editar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents TxtNombres As System.Windows.Forms.TextBox
    Friend WithEvents TxtDNI As System.Windows.Forms.TextBox
    Friend WithEvents TxtApellidos As System.Windows.Forms.TextBox
    Friend WithEvents TxtNumeroDeCelular As System.Windows.Forms.TextBox
    Friend WithEvents CmbDia As System.Windows.Forms.ComboBox
    Friend WithEvents CmbMes As System.Windows.Forms.ComboBox
    Friend WithEvents TxtAño As System.Windows.Forms.TextBox
    Friend WithEvents LblNombres As System.Windows.Forms.Label
    Friend WithEvents LblApellidos As System.Windows.Forms.Label
    Friend WithEvents LblDNI As System.Windows.Forms.Label
    Friend WithEvents LblNumeroDeCelular As System.Windows.Forms.Label
    Friend WithEvents LblDia As System.Windows.Forms.Label
    Friend WithEvents LblMes As System.Windows.Forms.Label
    Friend WithEvents LblAño As System.Windows.Forms.Label
    Friend WithEvents LblFechaDeNacimiento As System.Windows.Forms.Label
    Friend WithEvents LblGenero As System.Windows.Forms.Label
    Friend WithEvents CmbGenero As System.Windows.Forms.ComboBox
    Friend WithEvents BtnEliminarTodo As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button

End Class
