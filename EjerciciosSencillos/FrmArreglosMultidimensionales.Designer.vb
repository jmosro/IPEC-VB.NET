<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmArreglosMultidimensionales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmArreglosMultidimensionales))
        Me.lblNumerosMatriz = New System.Windows.Forms.Label()
        Me.lblNumeroMayor = New System.Windows.Forms.Label()
        Me.Ejecutar = New System.Windows.Forms.Button()
        Me.txtbNumeroMayor = New System.Windows.Forms.TextBox()
        Me.lbNumerosMatriz = New System.Windows.Forms.ListBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.pbxEjercicio1 = New System.Windows.Forms.PictureBox()
        CType(Me.pbxEjercicio1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNumerosMatriz
        '
        Me.lblNumerosMatriz.AutoSize = True
        Me.lblNumerosMatriz.Location = New System.Drawing.Point(76, 25)
        Me.lblNumerosMatriz.Name = "lblNumerosMatriz"
        Me.lblNumerosMatriz.Size = New System.Drawing.Size(120, 15)
        Me.lblNumerosMatriz.TabIndex = 0
        Me.lblNumerosMatriz.Text = "Números de la Matriz"
        '
        'lblNumeroMayor
        '
        Me.lblNumeroMayor.AutoSize = True
        Me.lblNumeroMayor.Location = New System.Drawing.Point(90, 300)
        Me.lblNumeroMayor.Name = "lblNumeroMayor"
        Me.lblNumeroMayor.Size = New System.Drawing.Size(88, 15)
        Me.lblNumeroMayor.TabIndex = 1
        Me.lblNumeroMayor.Text = "Número Mayor"
        '
        'Ejecutar
        '
        Me.Ejecutar.Location = New System.Drawing.Point(41, 263)
        Me.Ejecutar.Name = "Ejecutar"
        Me.Ejecutar.Size = New System.Drawing.Size(88, 23)
        Me.Ejecutar.TabIndex = 2
        Me.Ejecutar.Text = "Ejecutar"
        Me.Ejecutar.UseVisualStyleBackColor = True
        '
        'txtbNumeroMayor
        '
        Me.txtbNumeroMayor.Location = New System.Drawing.Point(90, 318)
        Me.txtbNumeroMayor.Name = "txtbNumeroMayor"
        Me.txtbNumeroMayor.Size = New System.Drawing.Size(88, 23)
        Me.txtbNumeroMayor.TabIndex = 3
        '
        'lbNumerosMatriz
        '
        Me.lbNumerosMatriz.FormattingEnabled = True
        Me.lbNumerosMatriz.ItemHeight = 15
        Me.lbNumerosMatriz.Location = New System.Drawing.Point(48, 48)
        Me.lbNumerosMatriz.Name = "lbNumerosMatriz"
        Me.lbNumerosMatriz.Size = New System.Drawing.Size(173, 199)
        Me.lbNumerosMatriz.TabIndex = 4
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(140, 263)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(88, 23)
        Me.btnVolver.TabIndex = 5
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'pbxEjercicio1
        '
        Me.pbxEjercicio1.Image = CType(resources.GetObject("pbxEjercicio1.Image"), System.Drawing.Image)
        Me.pbxEjercicio1.Location = New System.Drawing.Point(74, 353)
        Me.pbxEjercicio1.Name = "pbxEjercicio1"
        Me.pbxEjercicio1.Size = New System.Drawing.Size(122, 91)
        Me.pbxEjercicio1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxEjercicio1.TabIndex = 7
        Me.pbxEjercicio1.TabStop = False
        '
        'FrmArreglosMultidimensionales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 461)
        Me.Controls.Add(Me.pbxEjercicio1)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lbNumerosMatriz)
        Me.Controls.Add(Me.txtbNumeroMayor)
        Me.Controls.Add(Me.Ejecutar)
        Me.Controls.Add(Me.lblNumeroMayor)
        Me.Controls.Add(Me.lblNumerosMatriz)
        Me.Name = "FrmArreglosMultidimensionales"
        Me.Text = "Multidimensionales"
        CType(Me.pbxEjercicio1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumerosMatriz As Label
    Friend WithEvents lblNumeroMayor As Label
    Friend WithEvents Ejecutar As Button
    Friend WithEvents txtbNumeroMayor As TextBox
    Friend WithEvents lbNumerosMatriz As ListBox
    Friend WithEvents btnVolver As Button
    Friend WithEvents pbxEjercicio1 As PictureBox
End Class
