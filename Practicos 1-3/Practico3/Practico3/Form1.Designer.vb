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
        Me.LNya = New System.Windows.Forms.Label()
        Me.LDni = New System.Windows.Forms.Label()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.Lmodificar = New System.Windows.Forms.Label()
        Me.TDni = New System.Windows.Forms.TextBox()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.TApellido = New System.Windows.Forms.TextBox()
        Me.TGuardar = New System.Windows.Forms.Button()
        Me.TEliminar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LNya
        '
        Me.LNya.AutoSize = True
        Me.LNya.Location = New System.Drawing.Point(32, 36)
        Me.LNya.Name = "LNya"
        Me.LNya.Size = New System.Drawing.Size(92, 13)
        Me.LNya.TabIndex = 0
        Me.LNya.Text = "Nombre y Apellido"
        '
        'LDni
        '
        Me.LDni.AutoSize = True
        Me.LDni.Location = New System.Drawing.Point(32, 78)
        Me.LDni.Name = "LDni"
        Me.LDni.Size = New System.Drawing.Size(26, 13)
        Me.LDni.TabIndex = 1
        Me.LDni.Text = "DNI"
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.Location = New System.Drawing.Point(32, 118)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(44, 13)
        Me.LApellido.TabIndex = 2
        Me.LApellido.Text = "Apellido"
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(32, 159)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(44, 13)
        Me.LNombre.TabIndex = 3
        Me.LNombre.Text = "Nombre"
        '
        'Lmodificar
        '
        Me.Lmodificar.AutoSize = True
        Me.Lmodificar.ForeColor = System.Drawing.Color.Red
        Me.Lmodificar.Location = New System.Drawing.Point(148, 36)
        Me.Lmodificar.Name = "Lmodificar"
        Me.Lmodificar.Size = New System.Drawing.Size(50, 13)
        Me.Lmodificar.TabIndex = 4
        Me.Lmodificar.Text = "Modificar"
        '
        'TDni
        '
        Me.TDni.Location = New System.Drawing.Point(110, 75)
        Me.TDni.Name = "TDni"
        Me.TDni.Size = New System.Drawing.Size(100, 20)
        Me.TDni.TabIndex = 5
        '
        'TNombre
        '
        Me.TNombre.Location = New System.Drawing.Point(110, 156)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(100, 20)
        Me.TNombre.TabIndex = 6
        '
        'TApellido
        '
        Me.TApellido.Location = New System.Drawing.Point(110, 115)
        Me.TApellido.Name = "TApellido"
        Me.TApellido.Size = New System.Drawing.Size(100, 20)
        Me.TApellido.TabIndex = 7
        '
        'TGuardar
        '
        Me.TGuardar.Location = New System.Drawing.Point(35, 246)
        Me.TGuardar.Name = "TGuardar"
        Me.TGuardar.Size = New System.Drawing.Size(75, 23)
        Me.TGuardar.TabIndex = 8
        Me.TGuardar.Text = "Guardar"
        Me.TGuardar.UseVisualStyleBackColor = True
        '
        'TEliminar
        '
        Me.TEliminar.Location = New System.Drawing.Point(151, 246)
        Me.TEliminar.Name = "TEliminar"
        Me.TEliminar.Size = New System.Drawing.Size(75, 23)
        Me.TEliminar.TabIndex = 9
        Me.TEliminar.Text = "Eliminar"
        Me.TEliminar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 306)
        Me.Controls.Add(Me.TEliminar)
        Me.Controls.Add(Me.TGuardar)
        Me.Controls.Add(Me.TApellido)
        Me.Controls.Add(Me.TNombre)
        Me.Controls.Add(Me.TDni)
        Me.Controls.Add(Me.Lmodificar)
        Me.Controls.Add(Me.LNombre)
        Me.Controls.Add(Me.LApellido)
        Me.Controls.Add(Me.LDni)
        Me.Controls.Add(Me.LNya)
        Me.Name = "Form1"
        Me.Text = "Pequeño Formulario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LNya As Label
    Friend WithEvents LDni As Label
    Friend WithEvents LApellido As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents Lmodificar As Label
    Friend WithEvents TDni As TextBox
    Friend WithEvents TNombre As TextBox
    Friend WithEvents TApellido As TextBox
    Friend WithEvents TGuardar As Button
    Friend WithEvents TEliminar As Button
End Class
