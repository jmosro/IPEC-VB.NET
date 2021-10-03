'
' @brief   Crear un programa para demostrar el uso de la herencia en Empleado.
' @brief   Guía de Trabajo Autónomo - GTA.
' @brief   Fuente: https://youtu.be/d0Z1yDovLYc Canal: Juan Carlos Arcila Díaz. Descripción: Herencia y Polimorfismo POO (24-25) Programación en Visual Basic Net con Visual Studio 2013
' @class   frmRegistro
' @author  Jesús Alberto Moscoso Agüero
' @author  J. Mosro - jmosro.14@gmail.com
' @date    2021-septiembre-01
' @version 1
'
Imports Clases
Public Class frmRegistro
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim empleado1 As Empleado = New Empleado()
        empleado1.Nombres = txtNombres.Text
        empleado1.Apellidos = txtApellidos.Text
        empleado1.Documento = txtDocumento.Text
        empleado1.Tipo = cmbTipo.Text
        empleado1.TipoContrato = cmbContrato.Text
        empleado1.calcularSueldo(750)

        dgvEmpleados.Rows.Insert(0, empleado1.Tipo,
                                    empleado1.Nombres,
                                    empleado1.Apellidos,
                                    empleado1.Documento,
                                    empleado1.Sueldo)
    End Sub
End Class
