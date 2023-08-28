Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim colApe, colNom, colFechaNacimiento, colSexo, colSaldo, colRuta As New System.Windows.Forms.DataGridViewTextBoxColumn
        Dim colFoto As New System.Windows.Forms.DataGridViewImageColumn
        Dim colBoton As New System.Windows.Forms.DataGridViewButtonColumn

        colApe.Name = "Apellido"
        colNom.Name = "Nombre"
        colFechaNacimiento.Name = "Fecha Nacimiento"
        colSexo.Name = "Sexo"
        colBoton.Name = "Eliminar"
        colSaldo.Name = "Saldo"
        colFoto.Name = "Foto"
        colFoto.ImageLayout = DataGridViewImageCellLayout.Stretch
        colRuta.Name = "Ruta"

        DataGridView1.RowTemplate.Height = 70

        DataGridView1.Columns.Add(colApe)
        DataGridView1.Columns.Add(colNom)
        DataGridView1.Columns.Add(colFechaNacimiento)
        DataGridView1.Columns.Add(colSexo)
        DataGridView1.Columns.Add(colBoton)
        DataGridView1.Columns.Add(colSaldo)
        DataGridView1.Columns.Add(colFoto)
        DataGridView1.Columns.Add(colRuta)

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
                        Dim FilaSeleccionada As Integer = DataGridView1.CurrentRow.Index
                        DataGridView1.Rows.Remove(DataGridView1.Rows(FilaSeleccionada))
                        'DataGridView1.Rows.Remove()


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

        DataGridView1.Rows.Add(TApellido.Text, TNombre.Text, DateTimePicker1.Value, sexo, colBoton.Text, TSaldo.Text, Image.FromFile(TxTFoto.Text), TxTFoto.Text)
    End Sub

End Class
