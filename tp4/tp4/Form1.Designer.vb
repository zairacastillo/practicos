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
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.BBorrargrafico = New System.Windows.Forms.Button()
        Me.BGrafico = New System.Windows.Forms.Button()
        Me.BBorrarlistado = New System.Windows.Forms.Button()
        Me.BPrimos = New System.Windows.Forms.Button()
        Me.BImpares = New System.Windows.Forms.Button()
        Me.BPares = New System.Windows.Forms.Button()
        Me.BGenerar = New System.Windows.Forms.Button()
        Me.LHasta = New System.Windows.Forms.Label()
        Me.LDesde = New System.Windows.Forms.Label()
        Me.TBHasta = New System.Windows.Forms.TextBox()
        Me.TBDesde = New System.Windows.Forms.TextBox()
        Me.LListanumeros = New System.Windows.Forms.Label()
        Me.LBNumeros = New System.Windows.Forms.ListBox()
        Me.CGrafico = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.CGrafico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BBorrargrafico
        '
        Me.BBorrargrafico.Location = New System.Drawing.Point(853, 385)
        Me.BBorrargrafico.Name = "BBorrargrafico"
        Me.BBorrargrafico.Size = New System.Drawing.Size(108, 23)
        Me.BBorrargrafico.TabIndex = 74
        Me.BBorrargrafico.Text = "Borrar Gráfico"
        Me.BBorrargrafico.UseVisualStyleBackColor = True
        '
        'BGrafico
        '
        Me.BGrafico.Location = New System.Drawing.Point(621, 385)
        Me.BGrafico.Name = "BGrafico"
        Me.BGrafico.Size = New System.Drawing.Size(108, 23)
        Me.BGrafico.TabIndex = 73
        Me.BGrafico.Text = "Generar Gráfico"
        Me.BGrafico.UseVisualStyleBackColor = True
        '
        'BBorrarlistado
        '
        Me.BBorrarlistado.Location = New System.Drawing.Point(355, 385)
        Me.BBorrarlistado.Name = "BBorrarlistado"
        Me.BBorrarlistado.Size = New System.Drawing.Size(108, 23)
        Me.BBorrarlistado.TabIndex = 72
        Me.BBorrarlistado.Text = "Borrar Listado"
        Me.BBorrarlistado.UseVisualStyleBackColor = True
        '
        'BPrimos
        '
        Me.BPrimos.Location = New System.Drawing.Point(45, 330)
        Me.BPrimos.Name = "BPrimos"
        Me.BPrimos.Size = New System.Drawing.Size(109, 23)
        Me.BPrimos.TabIndex = 71
        Me.BPrimos.Text = "Numeros Primos"
        Me.BPrimos.UseVisualStyleBackColor = True
        '
        'BImpares
        '
        Me.BImpares.Location = New System.Drawing.Point(48, 292)
        Me.BImpares.Name = "BImpares"
        Me.BImpares.Size = New System.Drawing.Size(106, 23)
        Me.BImpares.TabIndex = 70
        Me.BImpares.Text = "Numeros Impares"
        Me.BImpares.UseVisualStyleBackColor = True
        '
        'BPares
        '
        Me.BPares.Location = New System.Drawing.Point(45, 248)
        Me.BPares.Name = "BPares"
        Me.BPares.Size = New System.Drawing.Size(109, 23)
        Me.BPares.TabIndex = 69
        Me.BPares.Text = "Numeros Pares"
        Me.BPares.UseVisualStyleBackColor = True
        '
        'BGenerar
        '
        Me.BGenerar.Location = New System.Drawing.Point(45, 205)
        Me.BGenerar.Name = "BGenerar"
        Me.BGenerar.Size = New System.Drawing.Size(106, 23)
        Me.BGenerar.TabIndex = 68
        Me.BGenerar.Text = "Generar Funcion"
        Me.BGenerar.UseVisualStyleBackColor = True
        '
        'LHasta
        '
        Me.LHasta.AutoSize = True
        Me.LHasta.Location = New System.Drawing.Point(26, 158)
        Me.LHasta.Name = "LHasta"
        Me.LHasta.Size = New System.Drawing.Size(38, 13)
        Me.LHasta.TabIndex = 67
        Me.LHasta.Text = "Hasta "
        '
        'LDesde
        '
        Me.LDesde.AutoSize = True
        Me.LDesde.Location = New System.Drawing.Point(23, 113)
        Me.LDesde.Name = "LDesde"
        Me.LDesde.Size = New System.Drawing.Size(41, 13)
        Me.LDesde.TabIndex = 66
        Me.LDesde.Text = "Desde "
        '
        'TBHasta
        '
        Me.TBHasta.Location = New System.Drawing.Point(96, 151)
        Me.TBHasta.Name = "TBHasta"
        Me.TBHasta.Size = New System.Drawing.Size(100, 20)
        Me.TBHasta.TabIndex = 65
        '
        'TBDesde
        '
        Me.TBDesde.Location = New System.Drawing.Point(96, 106)
        Me.TBDesde.Name = "TBDesde"
        Me.TBDesde.Size = New System.Drawing.Size(100, 20)
        Me.TBDesde.TabIndex = 64
        '
        'LListanumeros
        '
        Me.LListanumeros.AutoSize = True
        Me.LListanumeros.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LListanumeros.Location = New System.Drawing.Point(192, 42)
        Me.LListanumeros.Name = "LListanumeros"
        Me.LListanumeros.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LListanumeros.Size = New System.Drawing.Size(180, 25)
        Me.LListanumeros.TabIndex = 63
        Me.LListanumeros.Text = "Lista de Números"
        '
        'LBNumeros
        '
        Me.LBNumeros.FormattingEnabled = True
        Me.LBNumeros.Location = New System.Drawing.Point(273, 106)
        Me.LBNumeros.Name = "LBNumeros"
        Me.LBNumeros.Size = New System.Drawing.Size(258, 225)
        Me.LBNumeros.TabIndex = 62
        '
        'CGrafico
        '
        ChartArea1.Name = "ChartArea1"
        Me.CGrafico.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.CGrafico.Legends.Add(Legend1)
        Me.CGrafico.Location = New System.Drawing.Point(583, 94)
        Me.CGrafico.Name = "CGrafico"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Desde / Hasta"
        Me.CGrafico.Series.Add(Series1)
        Me.CGrafico.Size = New System.Drawing.Size(359, 246)
        Me.CGrafico.TabIndex = 75
        Me.CGrafico.Text = "Chart1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 450)
        Me.Controls.Add(Me.CGrafico)
        Me.Controls.Add(Me.BBorrargrafico)
        Me.Controls.Add(Me.BGrafico)
        Me.Controls.Add(Me.BBorrarlistado)
        Me.Controls.Add(Me.BPrimos)
        Me.Controls.Add(Me.BImpares)
        Me.Controls.Add(Me.BPares)
        Me.Controls.Add(Me.BGenerar)
        Me.Controls.Add(Me.LHasta)
        Me.Controls.Add(Me.LDesde)
        Me.Controls.Add(Me.TBHasta)
        Me.Controls.Add(Me.TBDesde)
        Me.Controls.Add(Me.LListanumeros)
        Me.Controls.Add(Me.LBNumeros)
        Me.Name = "Form1"
        Me.Text = "Formulario4"
        CType(Me.CGrafico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BBorrargrafico As Button
    Friend WithEvents BGrafico As Button
    Friend WithEvents BBorrarlistado As Button
    Friend WithEvents BPrimos As Button
    Friend WithEvents BImpares As Button
    Friend WithEvents BPares As Button
    Friend WithEvents BGenerar As Button
    Friend WithEvents LHasta As Label
    Friend WithEvents LDesde As Label
    Friend WithEvents TBHasta As TextBox
    Friend WithEvents TBDesde As TextBox
    Friend WithEvents LListanumeros As Label
    Friend WithEvents LBNumeros As ListBox
    Friend WithEvents CGrafico As DataVisualization.Charting.Chart
End Class
