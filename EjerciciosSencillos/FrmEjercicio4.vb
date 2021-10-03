'
' @brief   Se requiere de un programa que permita el ingreso de N de estudiantes y un N de notas y calcule el promedio de cada estudiante.
' @brief   Guía de Trabajo Autónomo - GTA.
' @brief   Fuente: https://youtu.be/HNO2NyndsjE Canal: Sistematts. Descripción: VÍDEO #9 - EJERCICIOS BÁSICOS EN VISUAL BASIC - PARTE 2(WINDOWS FORMS)
' @class   FrmEjercicio4
' @author  Jesús Alberto Moscoso Agüero
' @author  J. Mosro - jmosro.14@gmail.com
' @date    2021-septiembre-01
' @version 1
'
Public Class FrmEjercicio4
    Private Sub BtnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
        Dim numnotas, numestudiantes As Integer
        Dim promedio, nota, acumulado As Single
        Try
            If txbNumeroEstudiantes.Text.Length = 0 Then
                MsgBox("Número de Estudiantes no puede ser en blanco.", MsgBoxStyle.Information, "Aviso")
                Exit Sub
            End If
            numestudiantes = txbNumeroEstudiantes.Text
        Catch ex As Exception
            MsgBox("Número de Estudiantes debe ser tipo numérico.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End Try
        Try
            If txbNumeroEstudiantes.Text.Length = 0 Then
                MsgBox("Número de Estudiantes no puede ser en blanco.", MsgBoxStyle.Information, "Aviso")
                Exit Sub
            End If
            numnotas = txbNumeroNotas.Text
        Catch ex As Exception
            MsgBox("Número de Notas debe ser tipo numérico.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End Try
        acumulado = 0
        lbPromedios.Items.Clear()
        If numnotas > 0 And numestudiantes > 0 Then
            For i = 1 To numestudiantes
                For j = 1 To numnotas
                    Try
                        nota = InputBox("Ingrese nota #" & j & " del estudiante #" & i)
                    Catch ex As Exception
                        MsgBox("Nota #" & j & " del estudiante #" & i & " con formato incorrecto. Se asigna valor 0.", MsgBoxStyle.Critical, "Error")
                        nota = 0
                    End Try
                    acumulado += nota
                Next
                promedio = acumulado / numnotas
                lbPromedios.Items.Add("Promedio estudiante #" & i & " = " & promedio)
                acumulado = 0
            Next
        ElseIf numestudiantes <= 0 Then
            MsgBox("Número de Estudiante debe ser mayor a 0.", MsgBoxStyle.Information, "Aviso")
        ElseIf numnotas <= 0 Then
            MsgBox("Número de Notas debe ser mayor a 0.", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        FrmInicio.Show()
        Me.Close()
    End Sub
End Class