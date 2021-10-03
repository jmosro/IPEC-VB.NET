<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEjercicio2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEjercicio2))
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.btnEjecutar = New System.Windows.Forms.Button()
        Me.lblTablaMultiplicar = New System.Windows.Forms.Label()
        Me.lbTablaMultiplicar = New System.Windows.Forms.ListBox()
        Me.txbNumero = New System.Windows.Forms.TextBox()
        Me.pbxEjercicio2 = New System.Windows.Forms.PictureBox()
        CType(Me.pbxEjercicio2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(138, 204)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 11
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(138, 15)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(51, 15)
        Me.lblNumero.TabIndex = 10
        Me.lblNumero.Text = "Número"
        '
        'btnEjecutar
        '
        Me.btnEjecutar.Location = New System.Drawing.Point(57, 204)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(75, 23)
        Me.btnEjecutar.TabIndex = 9
        Me.btnEjecutar.Text = "Ejecutar"
        Me.btnEjecutar.UseVisualStyleBackColor = True
        '
        'lblTablaMultiplicar
        '
        Me.lblTablaMultiplicar.AutoSize = True
        Me.lblTablaMultiplicar.Location = New System.Drawing.Point(12, 15)
        Me.lblTablaMultiplicar.Name = "lblTablaMultiplicar"
        Me.lblTablaMultiplicar.Size = New System.Drawing.Size(110, 15)
        Me.lblTablaMultiplicar.TabIndex = 8
        Me.lblTablaMultiplicar.Text = "Tabla de Multiplicar"
        '
        'lbTablaMultiplicar
        '
        Me.lbTablaMultiplicar.FormattingEnabled = True
        Me.lbTablaMultiplicar.ItemHeight = 15
        Me.lbTablaMultiplicar.Location = New System.Drawing.Point(12, 38)
        Me.lbTablaMultiplicar.Name = "lbTablaMultiplicar"
        Me.lbTablaMultiplicar.Size = New System.Drawing.Size(120, 154)
        Me.lbTablaMultiplicar.TabIndex = 7
        '
        'txbNumero
        '
        Me.txbNumero.Location = New System.Drawing.Point(138, 38)
        Me.txbNumero.Name = "txbNumero"
        Me.txbNumero.Size = New System.Drawing.Size(122, 23)
        Me.txbNumero.TabIndex = 6
        '
        'pbxEjercicio2
        '
        Me.pbxEjercicio2.Image = CType(resources.GetObject("pbxEjercicio2.Image"), System.Drawing.Image)
        Me.pbxEjercicio2.Location = New System.Drawing.Point(138, 101)
        Me.pbxEjercicio2.Name = "pbxEjercicio2"
        Me.pbxEjercicio2.Size = New System.Drawing.Size(122, 91)
        Me.pbxEjercicio2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxEjercicio2.TabIndex = 12
        Me.pbxEjercicio2.TabStop = False
        '
        'FrmEjercicio2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 239)
        Me.Controls.Add(Me.pbxEjercicio2)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.btnEjecutar)
        Me.Controls.Add(Me.lblTablaMultiplicar)
        Me.Controls.Add(Me.lbTablaMultiplicar)
        Me.Controls.Add(Me.txbNumero)
        Me.Name = "FrmEjercicio2"
        Me.Text = "Ejercicio 2"
        CType(Me.pbxEjercicio2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVolver As Button
    Friend WithEvents lblNumero As Label
    Friend WithEvents btnEjecutar As Button
    Friend WithEvents lblTablaMultiplicar As Label
    Friend WithEvents lbTablaMultiplicar As ListBox
    Friend WithEvents txbNumero As TextBox
    Friend WithEvents pbxEjercicio2 As PictureBox
End Class
