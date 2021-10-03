'
' @brief   Crear un programa para ingresar o retirar dinero de una cuenta titular.
' @brief   Guía de Trabajo Autónomo - GTA.
' @brief   Fuente: https://youtu.be/UXSmop6dA68 Canal: DiscoDurodeRoer. Descripción: Ejercicios Visual Basic .NET - POO #1 - Cuenta de ahorro
' @class   Cuenta
' @author  Jesús Alberto Moscoso Agüero
' @author  J. Mosro - jmosro.14@gmail.com
' @date    2021-septiembre-01
' @version 1
'
Public Class Cuenta
    'Atributos
    Private titular As String
    Private cantidad As Double
    'Constructores
    Public Sub New(titular As String, cantidad As Double)
        Me.titular = titular
        Me.cantidad = cantidad
    End Sub
    Public Sub New(titular As String)
        Me.titular = titular
        Me.cantidad = 0
    End Sub
    'Properties
    Public Property propTitular() As String
        Get
            Return titular
        End Get
        Set(value As String)
            Me.titular = value
        End Set
    End Property
    Public Property propCantidad() As Double
        Get
            Return cantidad
        End Get
        Set(value As Double)
            Me.cantidad = value
        End Set
    End Property
    'ToString
    Public Overrides Function ToString() As String
        Return "El titular es " & propTitular & " y la cantidad es " & propCantidad
    End Function
    'Métodos
    Public Sub ingresar(cantidad As Double)
        If cantidad > 0 Then
            Me.cantidad += cantidad
        End If
    End Sub
    Public Sub retirar(cantidad As Double)
        If Me.cantidad - cantidad < 0 Then
            Me.cantidad = 0
        Else
            Me.cantidad -= cantidad
        End If
    End Sub
End Class
