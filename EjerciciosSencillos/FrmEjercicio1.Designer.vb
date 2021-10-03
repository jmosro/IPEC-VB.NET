<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEjercicio1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEjercicio1))
        Me.txbResultado = New System.Windows.Forms.TextBox()
        Me.lbNumeros = New System.Windows.Forms.ListBox()
        Me.lblNumeros = New System.Windows.Forms.Label()
        Me.btnEjecutar = New System.Windows.Forms.Button()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.pbxEjercicio1 = New System.Windows.Forms.PictureBox()
        CType(Me.pbxEjercicio1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txbResultado
        '
        Me.txbResultado.Enabled = False
        Me.txbResultado.Location = New System.Drawing.Point(100, 138)
        Me.txbResultado.Name = "txbResultado"
        Me.txbResultado.Size = New System.Drawing.Size(122, 23)
        Me.txbResultado.TabIndex = 0
        '
        'lbNumeros
        '
        Me.lbNumeros.FormattingEnabled = True
        Me.lbNumeros.ItemHeight = 15
        Me.lbNumeros.Location = New System.Drawing.Point(12, 37)
        Me.lbNumeros.Name = "lbNumeros"
        Me.lbNumeros.Size = New System.Drawing.Size(78, 124)
        Me.lbNumeros.TabIndex = 1
        '
        'lblNumeros
        '
        Me.lblNumeros.AutoSize = True
        Me.lblNumeros.Location = New System.Drawing.Point(12, 14)
        Me.lblNumeros.Name = "lblNumeros"
        Me.lblNumeros.Size = New System.Drawing.Size(56, 15)
        Me.lblNumeros.TabIndex = 2
        Me.lblNumeros.Text = "Números"
        '
        'btnEjecutar
        '
        Me.btnEjecutar.Location = New System.Drawing.Point(42, 174)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(75, 23)
        Me.btnEjecutar.TabIndex = 3
        Me.btnEjecutar.Text = "Ejecutar"
        Me.btnEjecutar.UseVisualStyleBackColor = True
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Location = New System.Drawing.Point(100, 115)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(59, 15)
        Me.lblResultado.TabIndex = 4
        Me.lblResultado.Text = "Resultado"
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(123, 174)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 5
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'pbxEjercicio1
        '
        Me.pbxEjercicio1.Image = CType(resources.GetObject("pbxEjercicio1.Image"), System.Drawing.Image)
        Me.pbxEjercicio1.Location = New System.Drawing.Point(100, 12)
        Me.pbxEjercicio1.Name = "pbxEjercicio1"
        Me.pbxEjercicio1.Size = New System.Drawing.Size(122, 91)
        Me.pbxEjercicio1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxEjercicio1.TabIndex = 6
        Me.pbxEjercicio1.TabStop = False
        '
        'FrmEjercicio1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(240, 214)
        Me.Controls.Add(Me.pbxEjercicio1)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.btnEjecutar)
        Me.Controls.Add(Me.lblNumeros)
        Me.Controls.Add(Me.lbNumeros)
        Me.Controls.Add(Me.txbResultado)
        Me.Name = "FrmEjercicio1"
        Me.Text = "Ejercicio 1"
        CType(Me.pbxEjercicio1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txbResultado As TextBox
    Friend WithEvents lbNumeros As ListBox
    Friend WithEvents lblNumeros As Label
    Friend WithEvents btnEjecutar As Button
    Friend WithEvents lblResultado As Label
    Friend WithEvents btnVolver As Button
    Friend WithEvents pbxEjercicio1 As PictureBox
End Class
