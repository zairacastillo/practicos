Public Class Form1


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
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub

    Private Sub Tapellido_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TApellido.KeyPress
        SoloLetras(e)
    End Sub

    Private Sub Tnombre_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TNombre.KeyPress
        SoloLetras(e)
    End Sub

    Private Sub Tdni_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TDni.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TGuardar_Click(sender As Object, e As EventArgs) Handles TGuardar.Click
        LModificar.Text = TNombre.Text + " " + TApellido.Text
        Dim ask As MsgBoxResult

        If (TDni.Text Is "" OrElse TNombre.Text Is "" OrElse TApellido.Text Is "") Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Critical, "Error")
        Else
            ask = MsgBox("¿Seguro desea insertar un nuevo cliente?", vbYesNo + vbQuestion, "confirmar insersion")

            If ask = vbYes Then
                MsgBox("El cliente: " + LModificar.Text + " se inserto correctamente", MsgBoxStyle.Information, "Guardar")
            End If
        End If
    End Sub


    Private Sub TEliminar_Click(sender As Object, e As EventArgs) Handles TEliminar.Click

        Dim ask As MsgBoxResult
        ask = MsgBox("Está apunto de eliminar el cliente: " + TNombre.Text + " " + TApellido.Text, vbYesNo + vbExclamation + vbDefaultButton2, "confirmar eliminacion")

        If ask = vbYes Then
            MsgBox("El cliente: " + TNombre.Text + " " + TApellido.Text + " se elimino correctamente", MsgBoxStyle.Information, "Eliminar")
            LModificar.Text = "modificar"
            TNombre.Clear()
            TApellido.Clear()
            TDni.Clear()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class



