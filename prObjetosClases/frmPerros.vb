'
' @brief   Crear un programa para demostrar el uso del objeto Perro.
' @brief   Guía de Trabajo Autónomo - GTA.
' @brief   Fuente: https://youtu.be/zt29PaBvyTw Canal: Juan Carlos Arcila Díaz. Descripción: Clases y Objetos POO (23-25) Programación en Visual Basic Net con Visual Studio 2013
' @class   frmPerros
' @author  Jesús Alberto Moscoso Agüero
' @author  J. Mosro - jmosro.14@gmail.com
' @date    2021-septiembre-01
' @version 1
'
Public Class frmPerros
    Private Sub btnPerro1_Click(sender As Object, e As EventArgs) Handles btnPerro1.Click
        Dim perrito1 As Perro = New Perro()
        perrito1.nombre = "Chizu"
        perrito1.raza = "Pastor Alemán"
        perrito1.altura = "0.70 cm"
        txtResultado.Text = perrito1.comer("Carne Res")
    End Sub

    Private Sub btnPerro2_Click(sender As Object, e As EventArgs) Handles btnPerro2.Click
        Dim perrito2 As Perro = New Perro()
        perrito2.nombre = "Lasy"
        perrito2.altura = "0.60"
        txtResultado.Text = perrito2.comer("Pollo")
    End Sub

    Private Sub btnPerro3_Click(sender As Object, e As EventArgs) Handles btnPerro3.Click
        Dim perrito3 As Perro = New Perro("Peluchin", "0.50")
        txtResultado.Text = perrito3.comer("Pan")
    End Sub
End Class
