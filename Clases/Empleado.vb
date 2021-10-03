'
' @brief   Crear un programa para demostrar el uso de la herencia en Empleado.
' @brief   Guía de Trabajo Autónomo - GTA.
' @brief   Fuente: https://youtu.be/d0Z1yDovLYc Canal: Juan Carlos Arcila Díaz. Descripción: Herencia y Polimorfismo POO (24-25) Programación en Visual Basic Net con Visual Studio 2013
' @class   Empleado
' @author  Jesús Alberto Moscoso Agüero
' @author  J. Mosro - jmosro.14@gmail.com
' @date    2021-septiembre-01
' @version 1
'
Public Class Empleado
    Inherits Persona
    'Atributos
    Private _tipoContrato As String
    Private _sueldo As Double
    'Propiedades
    Public Property TipoContrato As String
        Get
            Return _tipoContrato
        End Get
        Set(value As String)
            _tipoContrato = value
        End Set
    End Property
    Public Property Sueldo As String
        Get
            Return _sueldo
        End Get
        Set(value As String)
            _sueldo = value

        End Set
    End Property
    'Operaciones
    Public Sub calcularSueldo(sueldoBase As Double)
        If (Me.TipoContrato = "C") Then
            Me.Sueldo = sueldoBase + 350
        ElseIf (Me.TipoContrato = "N") Then
            Me.Sueldo = sueldoBase + 750
        Else
            Me.Sueldo = 0
        End If
    End Sub
End Class
