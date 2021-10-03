'
' @brief   Crear un programa para generar password y determinar si es un password fuerte.
' @brief   Guía de Trabajo Autónomo - GTA.
' @brief   Fuente: https://youtu.be/Z8Uvk9A0XQY Canal: DiscoDurodeRoer. Descripción: Ejercicios Visual Basic .NET - POO #3 - Clase Password
' @class   Password
' @author  Jesús Alberto Moscoso Agüero
' @author  J. Mosro - jmosro.14@gmail.com
' @date    2021-septiembre-01
' @version 1
'
Public Class Password
    'Atributos
    Public Const LONGITUD_DEF As Int32 = 8
    Public Const A_MINUS_CHAR As Int32 = 97
    Public Const Z_MINUS_CHAR As Int32 = 122
    Public Const A_MAYUS_CHAR As Int32 = 65
    Public Const Z_MAYUS_CHAR As Int32 = 90
    Public Const ZERO_CHAR As Int32 = 48
    Public Const NINE_CHAR As Int32 = 57
    Public Const NUM_MIN_NUMBERS As Int32 = 5
    Public Const NUM_MIN_MINUS As Int32 = 1
    Public Const NUM_MIN_MAYUS As Int32 = 2

    Private _longitud As Int32
    Private _contrasenna As String
    'Properties
    Public Property Longitud As Integer
        Get
            Return _longitud
        End Get
        Set(value As Integer)
            _longitud = value
        End Set
    End Property
    Public ReadOnly Property Contrasenna As String
        Get
            Return _contrasenna
        End Get
    End Property
    'Contructor
    Sub New(longitud As Int32)
        Me.Longitud = longitud
        generarPassword()
    End Sub
    'Métodos
    Private Sub generarPassword()
        Dim password As String = ""

        For index = 1 To Longitud
            Dim eleccion As Int32 = New Funciones().numAleatorioEntre(1, 3)
            If eleccion = 1 Then
                Dim minus As Char = Convert.ToChar(
                    New Funciones().numAleatorioEntre(A_MINUS_CHAR, Z_MINUS_CHAR))
                password += minus
            ElseIf eleccion = 2 Then
                Dim mayus As Char = Convert.ToChar(
                    New Funciones().numAleatorioEntre(A_MAYUS_CHAR, Z_MAYUS_CHAR))
                password += mayus
            Else
                Dim number As Char = Convert.ToChar(
                    New Funciones().numAleatorioEntre(ZERO_CHAR, NINE_CHAR))
                password += number
            End If
        Next

        Me._contrasenna = password
    End Sub
    Function esFuerte() As Boolean
        Dim minusculas As Int32 = 0
        Dim mayusculas As Int32 = 0
        Dim numeros As Int32 = 0

        For Each c As Char In Contrasenna
            Dim code As Int32 = Convert.ToInt32(c)
            If code >= A_MINUS_CHAR And code <= Z_MINUS_CHAR Then
                minusculas += 1

            ElseIf code >= A_MAYUS_CHAR And code <= Z_MAYUS_CHAR Then
                mayusculas += 1
            Else
                numeros += 1
            End If
        Next

        If numeros >= NUM_MIN_NUMBERS And minusculas >= NUM_MIN_MINUS And
                mayusculas >= NUM_MIN_MAYUS Then
            Return True
        Else
            Return False
        End If

    End Function
End Class
