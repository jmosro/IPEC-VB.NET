'
' @brief   Crear un programa para demostrar el uso de la herencia en Empleado.
' @brief   Guía de Trabajo Autónomo - GTA.
' @brief   Fuente: https://youtu.be/d0Z1yDovLYc Canal: Juan Carlos Arcila Díaz. Descripción: Herencia y Polimorfismo POO (24-25) Programación en Visual Basic Net con Visual Studio 2013
' @class   Persona
' @author  Jesús Alberto Moscoso Agüero
' @author  J. Mosro - jmosro.14@gmail.com
' @date    2021-septiembre-01
' @version 1
'
Public Class Persona
    'Atributos
    Private _apellidos As String
    Private _nombres As String
    Private _documento As String
    Private _tipo As String

    'Propiedades
    Public Property Apellidos As String
        Get
            Return _apellidos
        End Get
        Set(value As String)
            _apellidos = value
        End Set
    End Property
    Public Property Nombres As String
        Get
            Return _nombres
        End Get
        Set(value As String)
            _nombres = value
        End Set
    End Property
    Public Property Documento As String
        Get
            Return _documento
        End Get
        Set(value As String)
            _documento = value
        End Set
    End Property
    Public Property Tipo As String
        Get
            Return _tipo
        End Get
        Set(value As String)
            _tipo = value
        End Set
    End Property
End Class
