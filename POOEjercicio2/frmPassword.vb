'
' @brief   Crear un programa para generar password y determinar si es un password fuerte.
' @brief   Guía de Trabajo Autónomo - GTA.
' @brief   Fuente: https://youtu.be/Z8Uvk9A0XQY Canal: DiscoDurodeRoer. Descripción: Ejercicios Visual Basic .NET - POO #3 - Clase Password
' @class   frmPassword
' @author  Jesús Alberto Moscoso Agüero
' @author  J. Mosro - jmosro.14@gmail.com
' @date    2021-septiembre-01
' @version 1
'
Public Class frmPassword
    Private Sub btnGenerarPassword_Click(sender As Object, e As EventArgs) Handles btnGenerarPassword.Click
        Try
            If txtLongitud.Text.Length = 0 Then
                MsgBox("La logitud de password no debe ser vacio.", MsgBoxStyle.Information, "Aviso")
                Exit Sub
            End If
            Dim password1 As New Password(txtLongitud.Text)
            If password1.esFuerte() Then
                lbHistorialPassword.Items.Add(password1.Contrasenna & " es fuerte.")
            Else
                lbHistorialPassword.Items.Add(password1.Contrasenna & " no es fuerte.")
            End If
        Catch ex As Exception
            MsgBox("Longitud de password con formato incorrecto.", MsgBoxStyle.Critical, "Error.")
        End Try
    End Sub
End Class