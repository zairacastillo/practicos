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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LNombre = New System.Windows.Forms.Label()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.LFecha = New System.Windows.Forms.Label()
        Me.LSexo = New System.Windows.Forms.Label()
        Me.lSaldo = New System.Windows.Forms.Label()
        Me.TNombre = New System.Windows.Forms.TextBox()
        Me.TApellido = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TSaldo = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BFoto = New System.Windows.Forms.Button()
        Me.TxTFoto = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.RBHombre = New System.Windows.Forms.RadioButton()
        Me.RBMujer = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LNombre.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombre.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LNombre.Location = New System.Drawing.Point(98, 32)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(106, 36)
        Me.LNombre.TabIndex = 0
        Me.LNombre.Text = "Nombre:"
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LApellido.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LApellido.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LApellido.Location = New System.Drawing.Point(98, 88)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(106, 36)
        Me.LApellido.TabIndex = 1
        Me.LApellido.Text = "Apellido:"
        '
        'LFecha
        '
        Me.LFecha.AutoSize = True
        Me.LFecha.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LFecha.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFecha.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LFecha.Location = New System.Drawing.Point(98, 148)
        Me.LFecha.Name = "LFecha"
        Me.LFecha.Size = New System.Drawing.Size(209, 36)
        Me.LFecha.TabIndex = 2
        Me.LFecha.Text = "Fecha Nacimiento:"
        '
        'LSexo
        '
        Me.LSexo.AutoSize = True
        Me.LSexo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LSexo.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSexo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LSexo.Location = New System.Drawing.Point(98, 202)
        Me.LSexo.Name = "LSexo"
        Me.LSexo.Size = New System.Drawing.Size(68, 36)
        Me.LSexo.TabIndex = 3
        Me.LSexo.Text = "Sexo:"
        '
        'lSaldo
        '
        Me.lSaldo.AutoSize = True
        Me.lSaldo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lSaldo.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lSaldo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lSaldo.Location = New System.Drawing.Point(98, 259)
        Me.lSaldo.Name = "lSaldo"
        Me.lSaldo.Size = New System.Drawing.Size(78, 36)
        Me.lSaldo.TabIndex = 4
        Me.lSaldo.Text = "Saldo:"
        '
        'TNombre
        '
        Me.TNombre.Location = New System.Drawing.Point(226, 44)
        Me.TNombre.Name = "TNombre"
        Me.TNombre.Size = New System.Drawing.Size(100, 20)
        Me.TNombre.TabIndex = 5
        '
        'TApellido
        '
        Me.TApellido.Location = New System.Drawing.Point(226, 88)
        Me.TApellido.Name = "TApellido"
        Me.TApellido.Size = New System.Drawing.Size(100, 20)
        Me.TApellido.TabIndex = 6
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = ""
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(323, 157)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 7
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'TSaldo
        '
        Me.TSaldo.Location = New System.Drawing.Point(226, 271)
        Me.TSaldo.Name = "TSaldo"
        Me.TSaldo.Size = New System.Drawing.Size(100, 20)
        Me.TSaldo.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(480, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 250)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'BGuardar
        '
        Me.BGuardar.Location = New System.Drawing.Point(214, 375)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BGuardar.TabIndex = 13
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BFoto
        '
        Me.BFoto.Location = New System.Drawing.Point(101, 320)
        Me.BFoto.Name = "BFoto"
        Me.BFoto.Size = New System.Drawing.Size(75, 23)
        Me.BFoto.TabIndex = 14
        Me.BFoto.Text = "Foto"
        Me.BFoto.UseVisualStyleBackColor = True
        '
        'TxTFoto
        '
        Me.TxTFoto.Location = New System.Drawing.Point(226, 320)
        Me.TxTFoto.Name = "TxTFoto"
        Me.TxTFoto.Size = New System.Drawing.Size(100, 20)
        Me.TxTFoto.TabIndex = 15
        '
        'DataGridView1
        '
        Me.DataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DataGridView1.Location = New System.Drawing.Point(25, 404)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(895, 194)
        Me.DataGridView1.TabIndex = 16
        '
        'RBHombre
        '
        Me.RBHombre.AutoSize = True
        Me.RBHombre.Checked = True
        Me.RBHombre.Location = New System.Drawing.Point(226, 215)
        Me.RBHombre.Name = "RBHombre"
        Me.RBHombre.Size = New System.Drawing.Size(62, 17)
        Me.RBHombre.TabIndex = 17
        Me.RBHombre.TabStop = True
        Me.RBHombre.Text = "Hombre"
        Me.RBHombre.UseVisualStyleBackColor = True
        '
        'RBMujer
        '
        Me.RBMujer.AutoSize = True
        Me.RBMujer.Location = New System.Drawing.Point(306, 215)
        Me.RBMujer.Name = "RBMujer"
        Me.RBMujer.Size = New System.Drawing.Size(51, 17)
        Me.RBMujer.TabIndex = 18
        Me.RBMujer.Text = "Mujer"
        Me.RBMujer.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 622)
        Me.Controls.Add(Me.RBMujer)
        Me.Controls.Add(Me.RBHombre)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TxTFoto)
        Me.Controls.Add(Me.BFoto)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TSaldo)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TApellido)
        Me.Controls.Add(Me.TNombre)
        Me.Controls.Add(Me.lSaldo)
        Me.Controls.Add(Me.LSexo)
        Me.Controls.Add(Me.LFecha)
        Me.Controls.Add(Me.LApellido)
        Me.Controls.Add(Me.LNombre)
        Me.Name = "Form1"
        Me.Text = "Formulario con grid"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LNombre As Label
    Friend WithEvents LApellido As Label
    Friend WithEvents LFecha As Label
    Friend WithEvents LSexo As Label
    Friend WithEvents lSaldo As Label
    Friend WithEvents TNombre As TextBox
    Friend WithEvents TApellido As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents TSaldo As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BGuardar As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BFoto As Button
    Friend WithEvents TxTFoto As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents RBHombre As RadioButton
    Friend WithEvents RBMujer As RadioButton
End Class
