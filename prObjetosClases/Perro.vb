'
' @brief   Crear un programa para demostrar el uso del objeto Perro.
' @brief   Guía de Trabajo Autónomo - GTA.
' @brief   Fuente: https://youtu.be/zt29PaBvyTw Canal: Juan Carlos Arcila Díaz. Descripción: Clases y Objetos POO (23-25) Programación en Visual Basic Net con Visual Studio 2013
' @class   Perro
' @author  Jesús Alberto Moscoso Agüero
' @author  J. Mosro - jmosro.14@gmail.com
' @date    2021-septiembre-01
' @version 1
'
Public Class Perro
    'Propiedades
    Public nombre As String
    Public raza As String
    Public altura As String

    'Constructor
    Public Sub New()

    End Sub
    Public Sub New(nombre As String, raza As String, altura As String)
        Me.nombre = nombre
        Me.raza = raza
        Me.altura = altura
    End Sub
    Public Sub New(nombre As String, altura As String)
        Me.nombre = nombre
        Me.altura = altura & " cm"
    End Sub

    'Métodos
    Public Sub dormir()

    End Sub
    Public Sub ladrar()

    End Sub
    Public Function comer(carne As String) As String
        Return Me.nombre & " mide " & Me.altura & " y comerá " & carne
    End Function
End Class
