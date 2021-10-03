'
' @brief   Crear un vector de 5 posiciones, cargue esas cinco posiciones con nombres de personas,
' @brief   cree una opción de buscar nombre y recorra el vector en las cinco posiciones,
' @brief   si encuentra el nombre que lo indique, sino que diga valor no encontrado.
' @brief   Guía de Trabajo Autónomo - GTA.
' @brief   Fuente: https://youtu.be/wxeaZ3kROR8 Canal: Sistematts. Descripción: VÍDEO #10 - VECTORES O ARREGLOS UNIDIMENSIONALES EN VISUAL BASIC(WINDOWS FORMS)
' @class   FrmArreglosUnidimensionales
' @author  Jesús Alberto Moscoso Agüero
' @author  J. Mosro - jmosro.14@gmail.com
' @date    2021-septiembre-01
' @version 1
'
Public Class FrmArreglosUnidimensionales
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        FrmInicio.Show()
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim vector(4) As String
        Dim buscar, posicion As String
        posicion = ""
        vector(0) = "Mario"
        vector(1) = "Sofia"
        vector(2) = "Pedro"
        vector(3) = "Jimenez"
        vector(4) = "Pepito"
        'MsgBox(vector(2))
        'MsgBox(vector.Length - 1)

        buscar = Me.txtbBuscar.Text
        For i = 0 To vector.Length - 1
            If buscar = vector(i) Then
                posicion = i
            End If
            MsgBox(vector(i), MsgBoxStyle.Exclamation, "Lista")
        Next
        If posicion = "" Then
            MsgBox("No se encontró el dato", MsgBoxStyle.Information, "Aviso")
        Else
            MsgBox("La posición dentro del vector de la búsqueda es: " & posicion, MsgBoxStyle.Information, "Encontrado")
        End If
    End Sub
End Class