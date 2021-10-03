'
' @brief   Crear un programa para ingresar o retirar dinero de una cuenta titular.
' @brief   Guía de Trabajo Autónomo - GTA.
' @brief   Fuente: https://youtu.be/UXSmop6dA68 Canal: DiscoDurodeRoer. Descripción: Ejercicios Visual Basic .NET - POO #1 - Cuenta de ahorro
' @class   frmCuenta
' @author  Jesús Alberto Moscoso Agüero
' @author  J. Mosro - jmosro.14@gmail.com
' @date    2021-septiembre-01
' @version 1
'
Public Class frmCuenta
    Dim cuenta1 As New Cuenta("Default")
    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        If txtTitular.Text.Length = 0 Then
            cuenta1.propTitular = "Persona Default"
        Else
            cuenta1.propTitular = txtTitular.Text
        End If
        cuenta1.propCantidad = 0
        txtSaldo.Text = cuenta1.propCantidad
        txtTitular.Text = cuenta1.propTitular
        btnIngresar.Enabled = True
        btnRetirar.Enabled = True
    End Sub
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            If txtIngresar.Text.Length = 0 Then
                MsgBox("La cantidad a ingresar no debe ser vacio.", MsgBoxStyle.Information, "Aviso")
                Exit Sub
            End If
            cuenta1.ingresar(txtIngresar.Text)
            txtSaldo.Text = cuenta1.propCantidad
        Catch ex As Exception
            MsgBox("Cantidad a ingresar con formato incorrecto.", MsgBoxStyle.Critical, "Error.")
        End Try
    End Sub

    Private Sub btnRetirar_Click(sender As Object, e As EventArgs) Handles btnRetirar.Click
        Try
            If txtRetirar.Text.Length = 0 Then
                MsgBox("La cantidad a retirar no debe ser vacio.", MsgBoxStyle.Information, "Aviso")
                Exit Sub
            End If
            cuenta1.retirar(txtRetirar.Text)
            txtSaldo.Text = cuenta1.propCantidad
        Catch ex As Exception
            MsgBox("Cantidad a ingresar con formato incorrecto.", MsgBoxStyle.Critical, "Error.")
        End Try
    End Sub
End Class
