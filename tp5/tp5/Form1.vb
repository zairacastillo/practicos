Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.RowTemplate.Height = 70

    End Sub

    'Funcion para que solo permite el ingreso de caracteres tipo letra
    Sub SoloLetras(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo texto", MsgBoxStyle.Exclamation, "Error")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub

    'Funcion para que solo permite el ingreso de caracteres tipo numerico
    Sub SoloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub

    Function StrSacaValoresString(ByVal RutaPathFichero As String) As String ' Esta funcion obtiene el nombre del aricho que selecciono
        Dim ChrsIn As String, ChrsOut As String, IdX As Integer, Chrs As Integer
        On Error GoTo StrSacaValoresString_General_ErrTrap
        If RutaPathFichero = "" Then MsgBox("Debe seleccionar un archivo")
        ChrsIn = RutaPathFichero
        'Devuelve el nombre del fichero original
        If InStr(ChrsIn, "\") Then
            For IdX = Len(ChrsIn) To 1 Step -1
                If Mid(ChrsIn, IdX, 1) = "\" Then
                    ChrsOut = Mid(ChrsIn, IdX + 1)
                    Exit For
                End If
            Next IdX
        ElseIf InStr(ChrsIn, ":") = 2 Then
            ChrsOut = Mid(ChrsIn, 3)
        Else
            ChrsOut = ChrsIn
        End If
        StrSacaValoresString = ChrsOut
        Exit Function
StrSacaValoresString_General_ErrTrap:
        MsgBox("Error: " & Err.Number & " - Procedimiento: StrSacaValoresString" & vbCrLf & Err.Description, vbExclamation + vbOKOnly, "AVISO DE ERROR")
    End Function


    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim strm As System.IO.Stream

        strm = OpenFileDialog1.OpenFile()
        Dim cadena As String = IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.GetName.CodeBase).Remove(0, 6) 'Obtiene la ruta del direcotiro donde esta el proyecto
        Dim Source = OpenFileDialog1.FileName.ToString() 'Obtiene el nombre copleto de la ruta donde esta el archivo que vamos a copiar
        Dim archivo = StrSacaValoresString(Source) 'Obtiene el nombre del archivo
        Dim Destination = cadena + "\Fotos\" + archivo 'Es la carpeta destino donde voy a copiar los archivos
        TxTFoto.Text = Destination
        If Not (System.IO.File.Exists(Destination)) Then
            System.IO.File.Copy(Source, Destination)
        End If
        PictureBox1.Image = Image.FromFile(Destination)
    End Sub


    Private Sub BFoto_Click(sender As Object, e As EventArgs) Handles BFoto.Click
        OpenFileDialog1.Filter = "Archivos Imagenes|*.png|Archivos Imagenes|*.bmp|Archivos Imagenes|*.jpg" 'Permite filtrar archivos de imagenes para que el usuario no elija otro tipo de archivos
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DDatos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim respuesta As MsgBoxResult
        Dim cell As DataGridViewButtonCell = TryCast(DataGridView1.CurrentCell, DataGridViewButtonCell)
        If cell IsNot Nothing Then 'Verifica que la celdas tengan informacion
            Dim bc As DataGridViewButtonColumn = TryCast(DataGridView1.Columns(e.ColumnIndex), DataGridViewButtonColumn) 'Genero una variable que contiene el boton en el datagrid
            If bc IsNot Nothing Then
                Dim s As String = Convert.ToString(cell.Value)
                Select Case bc.Name
                    Case "Eliminar" 'Poner el nombre de la columna donde se desa dar un evento
                        'aquí dentro poner las acciones cuando se precione el botón eliminar

                        respuesta = MsgBox("Está apunto de eliminar el cliente: " + TNombre.Text + " " + TApellido.Text, vbYesNo + vbExclamation + vbDefaultButton2, "confirmar eliminacion")

                        If respuesta = vbYes Then
                            Dim FilaSeleccionada As Integer = DataGridView1.CurrentRow.Index
                            DataGridView1.Rows.Remove(DataGridView1.Rows(FilaSeleccionada))
                        End If

                        Exit Select
                End Select
            End If
        End If

    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        Dim colBoton As New System.Windows.Forms.DataGridViewButtonColumn
        colBoton.Text = "Eliminar"
        Dim sexo As String
        If RBHombre.Checked Then
            sexo = "Hombre"
        Else
            sexo = "Mujer"
        End If


        If Not TxTFoto.Text = "" And Not TSaldo.Text = "" And Not TApellido.Text = "" And Not TNombre.Text = "" Then
            Dim saldo As Double = Convert.ToDouble(TSaldo.Text)
            DataGridView1.Rows.Add(TApellido.Text, TNombre.Text, DateTimePicker1.Value, sexo, colBoton.Text, saldo, Image.FromFile(TxTFoto.Text), TxTFoto.Text)

            If saldo < 50 Then

                DataGridView1.Rows(DataGridView1.Rows.Count() - 2).DefaultCellStyle.BackColor = Color.Red
            End If

            PictureBox1.Image = PictureBox1.InitialImage
            TApellido.Clear()
            TNombre.Clear()
            TSaldo.Clear()
            TxTFoto.Clear()
        Else
            MsgBox("Debe agregar una foto de perfil y/o completar los demas campos")
        End If


    End Sub


    Private Sub TNombre_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TNombre.KeyPress
        SoloLetras(e)
    End Sub

    Private Sub TApellido_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TApellido.KeyPress
        SoloLetras(e)
    End Sub

    Private Sub TSaldo_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TSaldo.KeyPress
        SoloNumeros(e)
    End Sub

End Class
