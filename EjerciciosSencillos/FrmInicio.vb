'
' @brief   Menú de Ejercicios Sencillos.
' @brief   Guía de Trabajo Autónomo - GTA.
' @class   FrmInicio
' @author  Jesús Alberto Moscoso Agüero
' @author  J. Mosro - jmosro.14@gmail.com
' @date    2021-septiembre-01
' @version 1
'
Public Class FrmInicio
    Private Sub PbxEjercicio1_Click(sender As Object, e As EventArgs) Handles pbxEjercicio1.Click
        FrmEjercicio1.Show()
        Me.Hide()
    End Sub

    Private Sub PbxEjercicio2_Click(sender As Object, e As EventArgs) Handles pbxEjercicio2.Click
        FrmEjercicio2.Show()
        Me.Hide()
    End Sub

    Private Sub PbxEjercicio3_Click(sender As Object, e As EventArgs) Handles pbxEjercicio3.Click
        FrmEjercicio3.Show()
        Me.Hide()
    End Sub

    Private Sub PbxEjercicio4_Click(sender As Object, e As EventArgs) Handles pbxEjercicio4.Click
        FrmEjercicio4.Show()
        Me.Hide()
    End Sub

    Private Sub pbxEjercicio5_Click(sender As Object, e As EventArgs) Handles pbxEjercicio5.Click
        FrmArreglosUnidimensionales.Show()
        Me.Hide()
    End Sub

    Private Sub pbxEjercicio6_Click(sender As Object, e As EventArgs) Handles pbxEjercicio6.Click
        FrmArreglosMultidimensionales.Show()
        Me.Hide()
    End Sub
End Class
