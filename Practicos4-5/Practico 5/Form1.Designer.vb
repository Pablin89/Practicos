<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaNacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Foto = New System.Windows.Forms.DataGridViewImageColumn()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.LFecha = New System.Windows.Forms.Label()
        Me.LSexo = New System.Windows.Forms.Label()
        Me.LSaldo = New System.Windows.Forms.Label()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.TApellido = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TSaldo = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.Rbhombre = New System.Windows.Forms.RadioButton()
        Me.Rbmujer = New System.Windows.Forms.RadioButton()
        Me.ErrorNombre = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorApellido = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorSaldo = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorApellido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Apellido, Me.Nombre, Me.FechaNacimiento, Me.Sexo, Me.Saldo, Me.Eliminar, Me.Foto})
        Me.DataGridView1.Location = New System.Drawing.Point(3, 308)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(828, 175)
        Me.DataGridView1.TabIndex = 0
        '
        'Apellido
        '
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'FechaNacimiento
        '
        Me.FechaNacimiento.HeaderText = "Fecha Nacimiento"
        Me.FechaNacimiento.Name = "FechaNacimiento"
        Me.FechaNacimiento.ReadOnly = True
        '
        'Sexo
        '
        Me.Sexo.HeaderText = "Sexo"
        Me.Sexo.Name = "Sexo"
        Me.Sexo.ReadOnly = True
        '
        'Saldo
        '
        Me.Saldo.HeaderText = "Saldo"
        Me.Saldo.Name = "Saldo"
        Me.Saldo.ReadOnly = True
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'Foto
        '
        Me.Foto.HeaderText = "Foto"
        Me.Foto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.Foto.Name = "Foto"
        Me.Foto.ReadOnly = True
        Me.Foto.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Foto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.LNombre.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombre.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LNombre.Location = New System.Drawing.Point(48, 40)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(90, 29)
        Me.LNombre.TabIndex = 1
        Me.LNombre.Text = "Nombre"
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.LApellido.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LApellido.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LApellido.Location = New System.Drawing.Point(48, 78)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(93, 29)
        Me.LApellido.TabIndex = 2
        Me.LApellido.Text = "Apellido"
        '
        'LFecha
        '
        Me.LFecha.AutoSize = True
        Me.LFecha.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.LFecha.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFecha.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LFecha.Location = New System.Drawing.Point(48, 125)
        Me.LFecha.Name = "LFecha"
        Me.LFecha.Size = New System.Drawing.Size(216, 29)
        Me.LFecha.TabIndex = 3
        Me.LFecha.Text = "Fecha de Nacimiento"
        '
        'LSexo
        '
        Me.LSexo.AutoSize = True
        Me.LSexo.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.LSexo.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSexo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LSexo.Location = New System.Drawing.Point(48, 169)
        Me.LSexo.Name = "LSexo"
        Me.LSexo.Size = New System.Drawing.Size(62, 29)
        Me.LSexo.TabIndex = 4
        Me.LSexo.Text = "Sexo"
        '
        'LSaldo
        '
        Me.LSaldo.AutoSize = True
        Me.LSaldo.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.LSaldo.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSaldo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LSaldo.Location = New System.Drawing.Point(48, 210)
        Me.LSaldo.Name = "LSaldo"
        Me.LSaldo.Size = New System.Drawing.Size(69, 29)
        Me.LSaldo.TabIndex = 5
        Me.LSaldo.Text = "Saldo"
        '
        'TNombre
        '
        Me.TNombre.Location = New System.Drawing.Point(195, 49)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(202, 20)
        Me.TNombre.TabIndex = 6
        '
        'TApellido
        '
        Me.TApellido.Location = New System.Drawing.Point(195, 87)
        Me.TApellido.Name = "TApellido"
        Me.TApellido.Size = New System.Drawing.Size(202, 20)
        Me.TApellido.TabIndex = 7
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(269, 130)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(128, 20)
        Me.DateTimePicker1.TabIndex = 8
        '
        'TSaldo
        '
        Me.TSaldo.Location = New System.Drawing.Point(195, 219)
        Me.TSaldo.Name = "TSaldo"
        Me.TSaldo.Size = New System.Drawing.Size(202, 20)
        Me.TSaldo.TabIndex = 10
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BAgregar
        '
        Me.BAgregar.Location = New System.Drawing.Point(160, 265)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(117, 25)
        Me.BAgregar.TabIndex = 12
        Me.BAgregar.Text = "Agregar"
        Me.BAgregar.UseVisualStyleBackColor = True
        '
        'BBuscar
        '
        Me.BBuscar.Location = New System.Drawing.Point(563, 215)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(117, 39)
        Me.BBuscar.TabIndex = 13
        Me.BBuscar.Text = "Buscar Imagen"
        Me.BBuscar.UseVisualStyleBackColor = True
        '
        'Rbhombre
        '
        Me.Rbhombre.AutoSize = True
        Me.Rbhombre.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Rbhombre.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbhombre.Location = New System.Drawing.Point(195, 175)
        Me.Rbhombre.Name = "Rbhombre"
        Me.Rbhombre.Size = New System.Drawing.Size(82, 25)
        Me.Rbhombre.TabIndex = 14
        Me.Rbhombre.TabStop = True
        Me.Rbhombre.Text = "Hombre"
        Me.Rbhombre.UseVisualStyleBackColor = False
        '
        'Rbmujer
        '
        Me.Rbmujer.AutoSize = True
        Me.Rbmujer.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Rbmujer.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbmujer.Location = New System.Drawing.Point(307, 175)
        Me.Rbmujer.Name = "Rbmujer"
        Me.Rbmujer.Size = New System.Drawing.Size(67, 25)
        Me.Rbmujer.TabIndex = 15
        Me.Rbmujer.TabStop = True
        Me.Rbmujer.Text = "Mujer"
        Me.Rbmujer.UseVisualStyleBackColor = False
        '
        'ErrorNombre
        '
        Me.ErrorNombre.ContainerControl = Me
        '
        'ErrorApellido
        '
        Me.ErrorApellido.ContainerControl = Me
        '
        'ErrorSaldo
        '
        Me.ErrorSaldo.ContainerControl = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Practico_5.My.Resources.Resources.avatar
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(520, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(207, 154)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ClientSize = New System.Drawing.Size(831, 485)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Rbmujer)
        Me.Controls.Add(Me.Rbhombre)
        Me.Controls.Add(Me.BBuscar)
        Me.Controls.Add(Me.BAgregar)
        Me.Controls.Add(Me.TSaldo)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TApellido)
        Me.Controls.Add(Me.TNombre)
        Me.Controls.Add(Me.LSaldo)
        Me.Controls.Add(Me.LSexo)
        Me.Controls.Add(Me.LFecha)
        Me.Controls.Add(Me.LApellido)
        Me.Controls.Add(Me.LNombre)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Formulario con DataGrid"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorApellido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LNombre As Label
    Friend WithEvents LApellido As Label
    Friend WithEvents LFecha As Label
    Friend WithEvents LSexo As Label
    Friend WithEvents LSaldo As Label
    Friend WithEvents TNombre As TextBox
    Friend WithEvents TApellido As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TSaldo As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BAgregar As Button
    Friend WithEvents BBuscar As Button
    Friend WithEvents Rbhombre As RadioButton
    Friend WithEvents Rbmujer As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents FechaNacimiento As DataGridViewTextBoxColumn
    Friend WithEvents Sexo As DataGridViewTextBoxColumn
    Friend WithEvents Saldo As DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As DataGridViewButtonColumn
    Friend WithEvents Foto As DataGridViewImageColumn
    Friend WithEvents ErrorNombre As ErrorProvider
    Friend WithEvents ErrorApellido As ErrorProvider
    Friend WithEvents ErrorSaldo As ErrorProvider
End Class
