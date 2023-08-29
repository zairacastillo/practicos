<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Lmodificar = New System.Windows.Forms.Label()
        Me.Tdni = New System.Windows.Forms.TextBox()
        Me.Tapellido = New System.Windows.Forms.TextBox()
        Me.Tnombre = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Ttelefono = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RBvaron = New System.Windows.Forms.RadioButton()
        Me.RBmujer = New System.Windows.Forms.RadioButton()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Bsalir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Bguardar = New System.Windows.Forms.Button()
        Me.Beliminar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre y Apellido:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "* DNI"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "* Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "* Nombre"
        '
        'Lmodificar
        '
        Me.Lmodificar.AutoSize = True
        Me.Lmodificar.ForeColor = System.Drawing.Color.Red
        Me.Lmodificar.Location = New System.Drawing.Point(164, 13)
        Me.Lmodificar.Name = "Lmodificar"
        Me.Lmodificar.Size = New System.Drawing.Size(49, 13)
        Me.Lmodificar.TabIndex = 4
        Me.Lmodificar.Text = "modificar"
        '
        'Tdni
        '
        Me.Tdni.Location = New System.Drawing.Point(128, 57)
        Me.Tdni.Name = "Tdni"
        Me.Tdni.Size = New System.Drawing.Size(86, 20)
        Me.Tdni.TabIndex = 5
        '
        'Tapellido
        '
        Me.Tapellido.Location = New System.Drawing.Point(128, 111)
        Me.Tapellido.Name = "Tapellido"
        Me.Tapellido.Size = New System.Drawing.Size(86, 20)
        Me.Tapellido.TabIndex = 6
        '
        'Tnombre
        '
        Me.Tnombre.Location = New System.Drawing.Point(128, 166)
        Me.Tnombre.Name = "Tnombre"
        Me.Tnombre.Size = New System.Drawing.Size(86, 20)
        Me.Tnombre.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.CheckBox3)
        Me.Panel1.Controls.Add(Me.CheckBox2)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Ttelefono)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Tnombre)
        Me.Panel1.Controls.Add(Me.Tapellido)
        Me.Panel1.Controls.Add(Me.Tdni)
        Me.Panel1.Controls.Add(Me.Lmodificar)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(21, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(246, 362)
        Me.Panel1.TabIndex = 10
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(128, 321)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(79, 17)
        Me.CheckBox3.TabIndex = 15
        Me.CheckBox3.Text = "Mastercard"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(128, 299)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(46, 17)
        Me.CheckBox2.TabIndex = 14
        Me.CheckBox2.Text = "Visa"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(128, 277)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(63, 17)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.Text = "Naranja"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 277)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Tarjeta de creditos:"
        '
        'Ttelefono
        '
        Me.Ttelefono.Location = New System.Drawing.Point(128, 219)
        Me.Ttelefono.Name = "Ttelefono"
        Me.Ttelefono.Size = New System.Drawing.Size(86, 20)
        Me.Ttelefono.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Telefono"
        '
        'RBvaron
        '
        Me.RBvaron.AutoSize = True
        Me.RBvaron.Checked = True
        Me.RBvaron.Location = New System.Drawing.Point(292, 231)
        Me.RBvaron.Name = "RBvaron"
        Me.RBvaron.Size = New System.Drawing.Size(53, 17)
        Me.RBvaron.TabIndex = 12
        Me.RBvaron.TabStop = True
        Me.RBvaron.Text = "Varon"
        Me.RBvaron.UseVisualStyleBackColor = True
        '
        'RBmujer
        '
        Me.RBmujer.AutoSize = True
        Me.RBmujer.Location = New System.Drawing.Point(357, 231)
        Me.RBmujer.Name = "RBmujer"
        Me.RBmujer.Size = New System.Drawing.Size(51, 17)
        Me.RBmujer.TabIndex = 13
        Me.RBmujer.Text = "Mujer"
        Me.RBmujer.UseVisualStyleBackColor = True
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 26.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label7.Location = New System.Drawing.Point(94, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(253, 47)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Nuevo Cliente"
        '
        'Bsalir
        '
        Me.Bsalir.Image = Global.tp3.My.Resources.Resources.cerrar_sesion
        Me.Bsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bsalir.Location = New System.Drawing.Point(316, 444)
        Me.Bsalir.Name = "Bsalir"
        Me.Bsalir.Size = New System.Drawing.Size(69, 42)
        Me.Bsalir.TabIndex = 14
        Me.Bsalir.Text = "Salir"
        Me.Bsalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bsalir.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = Global.tp3.My.Resources.Resources.hombre
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(292, 82)
        Me.PictureBox1.MaximumSize = New System.Drawing.Size(110, 111)
        Me.PictureBox1.MinimumSize = New System.Drawing.Size(110, 111)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 111)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Bguardar
        '
        Me.Bguardar.Image = Global.tp3.My.Resources.Resources.disco_flexible
        Me.Bguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bguardar.Location = New System.Drawing.Point(32, 444)
        Me.Bguardar.Name = "Bguardar"
        Me.Bguardar.Size = New System.Drawing.Size(84, 42)
        Me.Bguardar.TabIndex = 8
        Me.Bguardar.Text = "Guardar"
        Me.Bguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bguardar.UseVisualStyleBackColor = True
        '
        'Beliminar
        '
        Me.Beliminar.Image = Global.tp3.My.Resources.Resources.boton_eliminar
        Me.Beliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Beliminar.Location = New System.Drawing.Point(149, 444)
        Me.Beliminar.Name = "Beliminar"
        Me.Beliminar.Size = New System.Drawing.Size(86, 42)
        Me.Beliminar.TabIndex = 9
        Me.Beliminar.Text = "Eliminar"
        Me.Beliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Beliminar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 503)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Bsalir)
        Me.Controls.Add(Me.RBmujer)
        Me.Controls.Add(Me.RBvaron)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Bguardar)
        Me.Controls.Add(Me.Beliminar)
        Me.Name = "Form1"
        Me.Text = "Pequeño Formulario"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Lmodificar As Label
    Friend WithEvents Tdni As TextBox
    Friend WithEvents Tapellido As TextBox
    Friend WithEvents Tnombre As TextBox
    Friend WithEvents Bguardar As Button
    Friend WithEvents Beliminar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Ttelefono As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RBvaron As RadioButton
    Friend WithEvents RBmujer As RadioButton
    Friend WithEvents Bsalir As Button
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents Label7 As Label
End Class
