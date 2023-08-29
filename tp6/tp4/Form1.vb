Imports System.Text.RegularExpressions ' Regular Expressions Namespace
Public Class Form1

    'funcion que verifica si esta vacio o no un campo de texto
    Private Function CheckEmpty(ByVal uno As String) As Boolean
        If Regex.IsMatch(uno.Trim, "^\S+$") = True Then
            Return True
        Else
            Return False
        End If
    End Function

    'funcion que convierte a entero un string
    Private Function ConvertToInteger(ByRef value As String) As Integer
        If String.IsNullOrEmpty(value) Then
            value = "0"
        End If
        Return Convert.ToInt32(value)
    End Function

    'funcion para validacion de campos
    Private Function ValidateFields(ByVal valor As String, ByVal tipo As String) As Boolean

        'segun tipo de validacion
        Select Case tipo
            'numeros positivos
            Case "positivos"
                If Regex.IsMatch(valor.Trim, "^[0-9]*$") = True Then
                    Return True
                Else
                    Return False
                End If
            'numeros enteros
            Case "enteros"
                Dim i As Integer
                If Integer.TryParse(valor.Trim, i) Then
                    Return True
                Else
                    Return False

                End If
            'numeros pares impares mod
            Case "mod"
                Dim a As Integer = ConvertToInteger(valor.Trim)
                If (a Mod 2) <> 0 Then
                    Return False
                Else
                    Return True
                End If
            'numeros primos
            Case "primos"
                Dim a As Integer = 0
                Dim b As Integer = 0
                If ValidateFields(valor, "positivos") Then
                    b = ConvertToInteger(valor.Trim)
                    For i As Integer = 1 To b + 1
                        If b Mod i = 0 Then
                            a = a + 1
                        End If
                    Next i
                    If a <> 2 Then
                        Return False
                    Else
                        Return True
                    End If
                Else
                    Return False
                End If
        End Select

        Return False

    End Function



    'Generar listado Desde Hasta
    Private Sub BGenerar_Click(sender As Object, e As EventArgs) Handles BGenerar.Click
        If ValidateFields(TBDesde.Text, "enteros") And ValidateFields(TBDesde.Text, "positivos") Then
            If ValidateFields(TBHasta.Text, "enteros") And ValidateFields(TBHasta.Text, "positivos") Then
                Dim a As Integer = ConvertToInteger(TBDesde.Text.Trim)
                Dim b As Integer = ConvertToInteger(TBHasta.Text.Trim)
                If a < b Then
                    LBNumeros.Items.Clear()
                    For i As Integer = a To b
                        LBNumeros.Items.Add(i)
                    Next
                Else
                    MsgBox("Desde debe ser menor a Hasta", vbCritical)
                End If
            Else
                MsgBox("Hasta debe ser numérico entero positivo", vbCritical)
            End If
        Else
            MsgBox("Desde debe ser numérico entero positivo", vbCritical)
        End If
    End Sub

    'Listado Pares
    Private Sub BPares_Click(sender As Object, e As EventArgs) Handles BPares.Click
        If ValidateFields(TBDesde.Text, "enteros") Then
            If ValidateFields(TBHasta.Text, "enteros") Then
                Dim a As Integer = ConvertToInteger(TBDesde.Text.Trim)
                Dim b As Integer = ConvertToInteger(TBHasta.Text.Trim)
                If a < b Then
                    LBNumeros.Items.Clear()
                    For i As Integer = a To b
                        If ValidateFields(i, "mod") Then
                            LBNumeros.Items.Add(i)
                        End If
                    Next
                Else
                    MsgBox("Desde debe ser menor que Hasta", vbCritical)
                End If
            Else
                MsgBox("Hasta debe ser numérico entero", vbCritical)
            End If
        Else
            MsgBox("Desde debe ser numérico entero", vbCritical)
        End If
    End Sub

    'Generar Impares
    Private Sub BImpares_Click(sender As Object, e As EventArgs) Handles BImpares.Click
        If ValidateFields(TBDesde.Text, "enteros") Then
            If ValidateFields(TBHasta.Text, "enteros") Then
                Dim a As Integer = ConvertToInteger(TBDesde.Text.Trim)
                Dim b As Integer = ConvertToInteger(TBHasta.Text.Trim)
                If a < b Then
                    LBNumeros.Items.Clear()
                    For i As Integer = a To b
                        If ValidateFields(i, "mod") <> True Then
                            LBNumeros.Items.Add(i)
                        End If
                    Next
                Else
                    MsgBox("Desde debe ser menor que Hasta", vbCritical)
                End If
            Else
                MsgBox("Hasta debe ser numérico entero", vbCritical)
            End If
        Else
            MsgBox("Desde debe ser numérico entero", vbCritical)
        End If
    End Sub

    'Generar Primos
    Private Sub BPrimos_Click(sender As Object, e As EventArgs) Handles BPrimos.Click
        If ValidateFields(TBDesde.Text, "enteros") And ValidateFields(TBDesde.Text, "positivos") Then
            If ValidateFields(TBHasta.Text, "enteros") And ValidateFields(TBHasta.Text, "positivos") Then
                Dim a As Integer = ConvertToInteger(TBDesde.Text.Trim)
                Dim b As Integer = ConvertToInteger(TBHasta.Text.Trim)
                If a < b Then
                    LBNumeros.Items.Clear()
                    For i As Integer = a To b
                        If ValidateFields(i, "primos") Then
                            LBNumeros.Items.Add(i)
                        End If
                    Next
                Else
                    MsgBox("Desde debe ser menor a Hasta", vbCritical)
                End If
            Else
                MsgBox("Hasta debe ser numérico entero positivo", vbCritical)
            End If
        Else
            MsgBox("Desde debe ser numérico entero positivo", vbCritical)
        End If
    End Sub

    'Generar graficos
    Private Sub BGrafico_Click(sender As Object, e As EventArgs) Handles BGrafico.Click

        'si existen elementos en el listado
        If LBNumeros.Items.Count > 0 Then
            'recorremos el listado
            For i = 0 To LBNumeros.Items.Count - 1
                'agregamos items a la serie del grafico
                CGrafico.Series("Desde / Hasta").Points.AddXY(LBNumeros.Items(i).ToString, LBNumeros.Items(i).ToString)
            Next
        Else
            'informe de vacio
            MsgBox("Listado Vacío", vbCritical)

        End If

    End Sub

    'Borrar Listado
    Private Sub BBorrarlistado_Click(sender As Object, e As EventArgs) Handles BBorrarlistado.Click
        LBNumeros.Items.Clear()
    End Sub

    'Borrar Grafico
    Private Sub BBorrargrafico_Click(sender As Object, e As EventArgs) Handles BBorrargrafico.Click
        CGrafico.Series("Desde / Hasta").Points.Clear()
    End Sub


End Class