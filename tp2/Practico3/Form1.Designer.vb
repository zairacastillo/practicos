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
        LNyA = New Label()
        LDni = New Label()
        LApellido = New Label()
        LNombre = New Label()
        LModificar = New Label()
        TGuardar = New Button()
        TEliminar = New Button()
        TDni = New TextBox()
        TNombre = New TextBox()
        TApellido = New TextBox()
        SuspendLayout()
        ' 
        ' LNyA
        ' 
        LNyA.AutoSize = True
        LNyA.Location = New Point(32, 51)
        LNyA.Name = "LNyA"
        LNyA.Size = New Size(110, 15)
        LNyA.TabIndex = 0
        LNyA.Text = "Nombre y Apellido:"
        ' 
        ' LDni
        ' 
        LDni.AutoSize = True
        LDni.Location = New Point(32, 97)
        LDni.Name = "LDni"
        LDni.Size = New Size(27, 15)
        LDni.TabIndex = 1
        LDni.Text = "DNI"
        ' 
        ' LApellido
        ' 
        LApellido.AutoSize = True
        LApellido.Location = New Point(32, 139)
        LApellido.Name = "LApellido"
        LApellido.Size = New Size(51, 15)
        LApellido.TabIndex = 2
        LApellido.Text = "Apellido"
        ' 
        ' LNombre
        ' 
        LNombre.AutoSize = True
        LNombre.Location = New Point(32, 185)
        LNombre.Name = "LNombre"
        LNombre.Size = New Size(51, 15)
        LNombre.TabIndex = 3
        LNombre.Text = "Nombre"
        ' 
        ' LModificar
        ' 
        LModificar.AutoSize = True
        LModificar.ForeColor = Color.Red
        LModificar.Location = New Point(259, 51)
        LModificar.Name = "LModificar"
        LModificar.Size = New Size(58, 15)
        LModificar.TabIndex = 4
        LModificar.Text = "modificar"
        ' 
        ' TGuardar
        ' 
        TGuardar.ForeColor = Color.Black
        TGuardar.Location = New Point(98, 265)
        TGuardar.Name = "TGuardar"
        TGuardar.Size = New Size(75, 23)
        TGuardar.TabIndex = 5
        TGuardar.Text = "Guardar"
        TGuardar.UseVisualStyleBackColor = True
        ' 
        ' TEliminar
        ' 
        TEliminar.ForeColor = Color.Black
        TEliminar.Location = New Point(259, 265)
        TEliminar.Name = "TEliminar"
        TEliminar.Size = New Size(75, 23)
        TEliminar.TabIndex = 6
        TEliminar.Text = "Eliminar"
        TEliminar.UseVisualStyleBackColor = True
        ' 
        ' TDni
        ' 
        TDni.Location = New Point(227, 101)
        TDni.Name = "TDni"
        TDni.Size = New Size(136, 23)
        TDni.TabIndex = 7
        ' 
        ' TNombre
        ' 
        TNombre.Location = New Point(227, 185)
        TNombre.Name = "TNombre"
        TNombre.Size = New Size(136, 23)
        TNombre.TabIndex = 8
        ' 
        ' TApellido
        ' 
        TApellido.Location = New Point(227, 139)
        TApellido.Name = "TApellido"
        TApellido.Size = New Size(136, 23)
        TApellido.TabIndex = 9
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(490, 450)
        Controls.Add(TApellido)
        Controls.Add(TNombre)
        Controls.Add(TDni)
        Controls.Add(TEliminar)
        Controls.Add(TGuardar)
        Controls.Add(LModificar)
        Controls.Add(LNombre)
        Controls.Add(LApellido)
        Controls.Add(LDni)
        Controls.Add(LNyA)
        Name = "Form1"
        Text = "Pequeño Formulario"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LNyA As Label
    Friend WithEvents LDni As Label
    Friend WithEvents LApellido As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents LModificar As Label
    Friend WithEvents TGuardar As Button
    Friend WithEvents TEliminar As Button
    Friend WithEvents TDni As TextBox
    Friend WithEvents TNombre As TextBox
    Friend WithEvents TApellido As TextBox
End Class
