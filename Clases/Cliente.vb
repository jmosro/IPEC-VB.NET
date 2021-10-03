'
' @brief   Crear un programa para demostrar el uso de la herencia en Empleado.
' @brief   Guía de Trabajo Autónomo - GTA.
' @brief   Fuente: https://youtu.be/d0Z1yDovLYc Canal: Juan Carlos Arcila Díaz. Descripción: Herencia y Polimorfismo POO (24-25) Programación en Visual Basic Net con Visual Studio 2013
' @class   Cliente
' @author  Jesús Alberto Moscoso Agüero
' @author  J. Mosro - jmosro.14@gmail.com
' @date    2021-septiembre-01
' @version 1
'
Public Class Cliente
    Inherits Persona
    'Atributos
    Private _categoria As String
    Private _codigo As String
    'Propiedades
    Public Property Categoria As String
        Get
            Return _categoria
        End Get
        Set(value As String)
            _categoria = value
        End Set
    End Property
    Public Property Codigo As String
        Get
            Return _codigo
        End Get
        Set(value As String)
            _codigo = value
        End Set
    End Property
    'Operaciones
    Public Sub generarCodigo()
        Me.Codigo = "C" & Me.Apellidos.Substring(0, 3) & "16"
    End Sub
End Class
