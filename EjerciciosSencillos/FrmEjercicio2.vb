'
' @brief   Se requiere de un programa que permita el ingreso de un número y muestre en pantalla las tablas de multiplicar.
' @brief   Guía de Trabajo Autónomo - GTA.
' @brief   Fuente: https://youtu.be/tu1ISB77Myk Canal: Sistematts. Descripción: VÍDEO #8 - EJERCICIOS BÁSICOS EN VISUAL BASIC - PARTE 1(WINDOWS FORMS)
' @class   FrmEjercicio2
' @author  Jesús Alberto Moscoso Agüero
' @author  J. Mosro - jmosro.14@gmail.com
' @date    2021-septiembre-01
' @version 1
'
Public Class FrmEjercicio2
    Private Sub BtnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
        Dim numero, multiplicacion As Integer
        Me.lbTablaMultiplicar.Items.Clear()
        Try
            If Me.txbNumero.Text.Length = 0 Then
                MsgBox("No se permite dejar el número en blanco.", MsgBoxStyle.Information, "Aviso")
            Else
                numero = Me.txbNumero.Text
                For i = 1 To 10
                    multiplicacion = numero * i
                    Me.lbTablaMultiplicar.Items.Add(numero & " x " & i & " = " & multiplicacion)
                Next
            End If
        Catch ex As Exception
            MsgBox("Número debe ser un tipo entero.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        FrmInicio.Show()
        Me.Close()
    End Sub
End Class