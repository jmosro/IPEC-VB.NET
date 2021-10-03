'
' @brief   Crear un programa para generar password y determinar si es un password fuerte.
' @brief   Guía de Trabajo Autónomo - GTA.
' @brief   Fuente: https://youtu.be/Z8Uvk9A0XQY Canal: DiscoDurodeRoer. Descripción: Ejercicios Visual Basic .NET - POO #3 - Clase Password
' @class   Funciones
' @author  Jesús Alberto Moscoso Agüero
' @author  J. Mosro - jmosro.14@gmail.com
' @date    2021-septiembre-01
' @version 1
'
Public Class Funciones
    Function numAleatorioEntre(ByVal minimo As Integer, ByVal maximo As Integer) As Integer
        Randomize()
        Return CLng((minimo - maximo) * Rnd() + maximo)
    End Function
End Class
