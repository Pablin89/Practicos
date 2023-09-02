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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.LDesde = New System.Windows.Forms.Label()
        Me.LHasta = New System.Windows.Forms.Label()
        Me.BFuncion = New System.Windows.Forms.Button()
        Me.TDesde = New System.Windows.Forms.TextBox()
        Me.THasta = New System.Windows.Forms.TextBox()
        Me.LLista = New System.Windows.Forms.Label()
        Me.BPares = New System.Windows.Forms.Button()
        Me.BImpares = New System.Windows.Forms.Button()
        Me.BPrimos = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.Location = New System.Drawing.Point(306, 68)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(305, 186)
        Me.ListBox1.TabIndex = 0
        '
        'LDesde
        '
        Me.LDesde.AutoSize = True
        Me.LDesde.Location = New System.Drawing.Point(114, 73)
        Me.LDesde.Name = "LDesde"
        Me.LDesde.Size = New System.Drawing.Size(38, 13)
        Me.LDesde.TabIndex = 1
        Me.LDesde.Text = "Desde"
        '
        'LHasta
        '
        Me.LHasta.AutoSize = True
        Me.LHasta.Location = New System.Drawing.Point(114, 122)
        Me.LHasta.Name = "LHasta"
        Me.LHasta.Size = New System.Drawing.Size(35, 13)
        Me.LHasta.TabIndex = 2
        Me.LHasta.Text = "Hasta"
        '
        'BFuncion
        '
        Me.BFuncion.Location = New System.Drawing.Point(137, 162)
        Me.BFuncion.Name = "BFuncion"
        Me.BFuncion.Size = New System.Drawing.Size(108, 20)
        Me.BFuncion.TabIndex = 3
        Me.BFuncion.Text = "Generar Funciòn"
        Me.BFuncion.UseVisualStyleBackColor = True
        '
        'TDesde
        '
        Me.TDesde.Location = New System.Drawing.Point(165, 70)
        Me.TDesde.Name = "TDesde"
        Me.TDesde.Size = New System.Drawing.Size(100, 20)
        Me.TDesde.TabIndex = 4
        '
        'THasta
        '
        Me.THasta.Location = New System.Drawing.Point(165, 119)
        Me.THasta.Name = "THasta"
        Me.THasta.Size = New System.Drawing.Size(100, 20)
        Me.THasta.TabIndex = 5
        '
        'LLista
        '
        Me.LLista.AutoSize = True
        Me.LLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLista.Location = New System.Drawing.Point(237, 12)
        Me.LLista.Name = "LLista"
        Me.LLista.Size = New System.Drawing.Size(177, 25)
        Me.LLista.TabIndex = 6
        Me.LLista.Text = "Lista de números"
        Me.LLista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BPares
        '
        Me.BPares.Location = New System.Drawing.Point(137, 204)
        Me.BPares.Name = "BPares"
        Me.BPares.Size = New System.Drawing.Size(108, 23)
        Me.BPares.TabIndex = 7
        Me.BPares.Text = "Numeros Pares"
        Me.BPares.UseVisualStyleBackColor = True
        '
        'BImpares
        '
        Me.BImpares.Location = New System.Drawing.Point(137, 233)
        Me.BImpares.Name = "BImpares"
        Me.BImpares.Size = New System.Drawing.Size(108, 23)
        Me.BImpares.TabIndex = 8
        Me.BImpares.Text = "Numeros Impares"
        Me.BImpares.UseVisualStyleBackColor = True
        '
        'BPrimos
        '
        Me.BPrimos.Location = New System.Drawing.Point(137, 262)
        Me.BPrimos.Name = "BPrimos"
        Me.BPrimos.Size = New System.Drawing.Size(108, 23)
        Me.BPrimos.TabIndex = 9
        Me.BPrimos.Text = "Numeros Primos"
        Me.BPrimos.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(292, 260)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Size = New System.Drawing.Size(334, 169)
        Me.Chart1.TabIndex = 10
        Me.Chart1.Text = "Chart1"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.LLista)
        Me.Panel1.Location = New System.Drawing.Point(12, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(708, 46)
        Me.Panel1.TabIndex = 11
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(23, 208)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 12
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(23, 237)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox2.TabIndex = 13
        Me.CheckBox2.Text = "CheckBox2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(23, 266)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox3.TabIndex = 14
        Me.CheckBox3.Text = "CheckBox3"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 448)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.BPrimos)
        Me.Controls.Add(Me.BImpares)
        Me.Controls.Add(Me.BPares)
        Me.Controls.Add(Me.THasta)
        Me.Controls.Add(Me.TDesde)
        Me.Controls.Add(Me.BFuncion)
        Me.Controls.Add(Me.LHasta)
        Me.Controls.Add(Me.LDesde)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Formulario4"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents LDesde As Label
    Friend WithEvents LHasta As Label
    Friend WithEvents BFuncion As Button
    Friend WithEvents TDesde As TextBox
    Friend WithEvents THasta As TextBox
    Friend WithEvents LLista As Label
    Friend WithEvents BPares As Button
    Friend WithEvents BImpares As Button
    Friend WithEvents BPrimos As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
End Class
