'
' @brief   Crear una matriz de 3x3 posiciones, donde inserte números e indique cuál es el mayor.
' @brief   Guía de Trabajo Autónomo - GTA.
' @brief   Fuente: https://youtu.be/P69F7co8O-M Canal: Sistematts. Descripción: VÍDEO #11 - VECTORES O MATRICES MULTIDIMENSIONALES EN VISUAL BASIC(WINDOWS FORMS)
' @class   FrmArreglosMultidimensionales
' @author  Jesús Alberto Moscoso Agüero
' @author  J. Mosro - jmosro.14@gmail.com
' @date    2021-septiembre-01
' @version 1
'
Public Class FrmArreglosMultidimensionales

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        FrmInicio.Show()
        Me.Close()
    End Sub

    Private Sub Ejecutar_Click(sender As Object, e As EventArgs) Handles Ejecutar.Click
        Dim matriz(3, 3) As Integer
        Dim mayor As Integer
        'matriz(0, 0) = 5
        'matriz(0, 1) = 10
        'matriz(0, 2) = 8
        'matriz(0, 3) = 2

        'matriz(1, 0) = 20
        'matriz(1, 1) = 30
        'matriz(1, 2) = 40
        'matriz(1, 3) = 100

        'matriz(2, 0) = 1
        'matriz(2, 1) = 80
        'matriz(2, 2) = 82
        'matriz(2, 3) = 19

        'matriz(3, 0) = 150
        'matriz(3, 1) = 26
        'matriz(3, 2) = 18
        'matriz(3, 3) = 76

        For x = 0 To matriz.GetLength(0) - 1
            For y = 0 To matriz.GetLength(0) - 1
                matriz(x, y) = CInt((100 - 1) * Rnd() + 1)
            Next
        Next

        For x = 0 To matriz.GetLength(0) - 1
            For y = 0 To matriz.GetLength(0) - 1
                If matriz(x, y) > mayor Then
                    mayor = matriz(x, y)
                End If
                lbNumerosMatriz.Items.Add("Posicion (" & x & "," & y & "): " & matriz(x, y))
            Next
        Next
        txtbNumeroMayor.Text = mayor
    End Sub
End Class