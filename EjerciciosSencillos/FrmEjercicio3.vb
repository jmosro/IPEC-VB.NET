'
' @brief   Se requiere de un programa que calcule el área del triángulo, cuadrado, rectángulo y rombo.
' @brief   Guía de Trabajo Autónomo - GTA.
' @brief   Fuente: https://youtu.be/HNO2NyndsjE Canal: Sistematts. Descripción: VÍDEO #9 - EJERCICIOS BÁSICOS EN VISUAL BASIC - PARTE 2(WINDOWS FORMS)
' @class   FrmEjercicio3
' @author  Jesús Alberto Moscoso Agüero
' @author  J. Mosro - jmosro.14@gmail.com
' @date    2021-septiembre-01
' @version 1
'
Public Class FrmEjercicio3
    Private Sub BtnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
        Dim altura, base, area, lado, diagonalmenor, diagonalmayor As Single
        lbDatos.Items.Clear()
        txbResultado.Text = ""
        If cmbArea.Text = "Triángulo" Then
            Try
                altura = InputBox("Ingrese altura (h):")
                Try
                    base = InputBox("Ingrese base (b):")
                Catch ex As Exception
                    MsgBox("Base debe ser tipo numérico.", MsgBoxStyle.Critical, "Error")
                    altura = 0
                    base = 0
                End Try
            Catch ex As Exception
                MsgBox("Altura debe ser tipo numérico.", MsgBoxStyle.Critical, "Error")
                altura = 0
                base = 0
            End Try
            area = (altura * base) / 2
            lbDatos.Items.Add("Altura (h): " & altura)
            lbDatos.Items.Add("Base (b): " & base)
            txbResultado.Text = area
        ElseIf cmbArea.Text = "Cuadrado" Then
            Try
                lado = InputBox("Ingrese lado (l): ")
            Catch ex As Exception
                MsgBox("Lado debe ser tipo numérico.", MsgBoxStyle.Critical)
                lado = 0
            End Try
            area = (lado ^ 2)
            lbDatos.Items.Add("Lado (l): " & lado)
            txbResultado.Text = area
        ElseIf cmbArea.Text = "Rectángulo" Then
            Try
                altura = InputBox("Ingrese altura (h):")
                Try
                    base = InputBox("Ingrese base (b):")
                Catch ex As Exception
                    MsgBox("Base debe ser tipo numérico.", MsgBoxStyle.Critical, "Error")
                    altura = 0
                    base = 0
                End Try
            Catch ex As Exception
                MsgBox("Altura debe ser tipo numérico.", MsgBoxStyle.Critical, "Error")
                altura = 0
                base = 0
            End Try
            area = (altura * base)
            lbDatos.Items.Add("Altura (h): " & altura)
            lbDatos.Items.Add("Base (b): " & base)
            txbResultado.Text = area
        ElseIf cmbArea.Text = "Rombo" Then
            Try
                diagonalmenor = InputBox("Ingrese diagonal menor (d):")
                Try
                    diagonalmayor = InputBox("Ingrese diagonal mayor (D):")
                Catch ex As Exception
                    MsgBox("Diagonal mayor debe ser tipo numérico.", MsgBoxStyle.Critical, "Error")
                    diagonalmenor = 0
                    diagonalmayor = 0
                End Try
            Catch ex As Exception
                MsgBox("Diagonal menor debe ser tipo numérico.", MsgBoxStyle.Critical, "Error")
                diagonalmenor = 0
                diagonalmayor = 0
            End Try
            area = (diagonalmenor * diagonalmayor) / 2
            lbDatos.Items.Add("Diagonal menor (d): " & diagonalmenor)
            lbDatos.Items.Add("Diagonal mayor (D): " & diagonalmayor)
            txbResultado.Text = area
        Else
            MsgBox("Por favor seleccionar un área que desea calcular.", MsgBoxStyle.Exclamation, "Aviso")
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        FrmInicio.Show()
        Me.Close()
    End Sub
End Class