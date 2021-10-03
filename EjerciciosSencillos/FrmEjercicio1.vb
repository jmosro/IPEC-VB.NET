'
' @brief   Se requiere de un programa que permita el ingreso de N números enteros mayores a 0 y realice
' @brief   la sumatoria de los números ingresados, el programa debe finalizar al ingresar 0.
' @brief   Guía de Trabajo Autónomo - GTA.
' @brief   Fuente: https://youtu.be/tu1ISB77Myk Canal: Sistematts. Descripción: VÍDEO #8 - EJERCICIOS BÁSICOS EN VISUAL BASIC - PARTE 1(WINDOWS FORMS)
' @class   FrmEjercicio1
' @author  Jesús Alberto Moscoso Agüero
' @author  J. Mosro - jmosro.14@gmail.com
' @date    2021-septiembre-01
' @version 1
'
Public Class FrmEjercicio1
    Private Sub BtnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
        Dim numero, sumatoria As Integer
        numero = 1
        sumatoria = 0
        Me.lbNumeros.Items.Clear()
        Me.txbResultado.Text = 0
        While (numero <> 0)
            Try
                Dim temporal As String
                temporal = InputBox("Ingrese un número." & vbCrLf & "Escribir 0 para Salir.")
                If temporal.Length = 0 Then
                    MsgBox("No se permite dejar el campo en blanco.", MsgBoxStyle.Information, "Aviso")
                    numero = 1
                Else
                    numero = CInt(temporal)
                    sumatoria += numero
                    Me.lbNumeros.Items.Add(numero)
                End If
            Catch ex As Exception
                MsgBox("Debe ingresar un número válido.", MsgBoxStyle.Critical, "Error")
                numero = 1
            End Try
        End While
        Me.txbResultado.Text = sumatoria
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        FrmInicio.Show()
        Me.Close()
    End Sub
End Class