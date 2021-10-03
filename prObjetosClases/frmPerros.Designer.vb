<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPerros
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnPerro1 = New System.Windows.Forms.Button()
        Me.btnPerro2 = New System.Windows.Forms.Button()
        Me.btnPerro3 = New System.Windows.Forms.Button()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnPerro1
        '
        Me.btnPerro1.Location = New System.Drawing.Point(111, 35)
        Me.btnPerro1.Name = "btnPerro1"
        Me.btnPerro1.Size = New System.Drawing.Size(75, 23)
        Me.btnPerro1.TabIndex = 0
        Me.btnPerro1.Text = "Perro 1"
        Me.btnPerro1.UseVisualStyleBackColor = True
        '
        'btnPerro2
        '
        Me.btnPerro2.Location = New System.Drawing.Point(111, 84)
        Me.btnPerro2.Name = "btnPerro2"
        Me.btnPerro2.Size = New System.Drawing.Size(75, 23)
        Me.btnPerro2.TabIndex = 1
        Me.btnPerro2.Text = "Perro 2"
        Me.btnPerro2.UseVisualStyleBackColor = True
        '
        'btnPerro3
        '
        Me.btnPerro3.Location = New System.Drawing.Point(111, 131)
        Me.btnPerro3.Name = "btnPerro3"
        Me.btnPerro3.Size = New System.Drawing.Size(75, 23)
        Me.btnPerro3.TabIndex = 2
        Me.btnPerro3.Text = "Perro 3"
        Me.btnPerro3.UseVisualStyleBackColor = True
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(12, 184)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(267, 23)
        Me.txtResultado.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 239)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.btnPerro3)
        Me.Controls.Add(Me.btnPerro2)
        Me.Controls.Add(Me.btnPerro1)
        Me.Name = "Form1"
        Me.Text = "Clases y Objetos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPerro1 As Button
    Friend WithEvents btnPerro2 As Button
    Friend WithEvents btnPerro3 As Button
    Friend WithEvents txtResultado As TextBox
End Class
