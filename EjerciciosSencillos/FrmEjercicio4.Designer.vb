<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEjercicio4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEjercicio4))
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.lblNumeroEstudiantes = New System.Windows.Forms.Label()
        Me.btnEjecutar = New System.Windows.Forms.Button()
        Me.lblPromedios = New System.Windows.Forms.Label()
        Me.lbPromedios = New System.Windows.Forms.ListBox()
        Me.txbNumeroEstudiantes = New System.Windows.Forms.TextBox()
        Me.lblNumeroNotas = New System.Windows.Forms.Label()
        Me.txbNumeroNotas = New System.Windows.Forms.TextBox()
        Me.pbxEjercicio4 = New System.Windows.Forms.PictureBox()
        CType(Me.pbxEjercicio4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(148, 133)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 17
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'lblNumeroEstudiantes
        '
        Me.lblNumeroEstudiantes.AutoSize = True
        Me.lblNumeroEstudiantes.Location = New System.Drawing.Point(12, 16)
        Me.lblNumeroEstudiantes.Name = "lblNumeroEstudiantes"
        Me.lblNumeroEstudiantes.Size = New System.Drawing.Size(130, 15)
        Me.lblNumeroEstudiantes.TabIndex = 16
        Me.lblNumeroEstudiantes.Text = "Número de Estudiantes"
        '
        'btnEjecutar
        '
        Me.btnEjecutar.Location = New System.Drawing.Point(67, 133)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(75, 23)
        Me.btnEjecutar.TabIndex = 15
        Me.btnEjecutar.Text = "Ejecutar"
        Me.btnEjecutar.UseVisualStyleBackColor = True
        '
        'lblPromedios
        '
        Me.lblPromedios.AutoSize = True
        Me.lblPromedios.Location = New System.Drawing.Point(12, 168)
        Me.lblPromedios.Name = "lblPromedios"
        Me.lblPromedios.Size = New System.Drawing.Size(64, 15)
        Me.lblPromedios.TabIndex = 14
        Me.lblPromedios.Text = "Promedios"
        '
        'lbPromedios
        '
        Me.lbPromedios.FormattingEnabled = True
        Me.lbPromedios.ItemHeight = 15
        Me.lbPromedios.Location = New System.Drawing.Point(12, 191)
        Me.lbPromedios.Name = "lbPromedios"
        Me.lbPromedios.Size = New System.Drawing.Size(258, 79)
        Me.lbPromedios.TabIndex = 13
        '
        'txbNumeroEstudiantes
        '
        Me.txbNumeroEstudiantes.Location = New System.Drawing.Point(12, 39)
        Me.txbNumeroEstudiantes.Name = "txbNumeroEstudiantes"
        Me.txbNumeroEstudiantes.Size = New System.Drawing.Size(130, 23)
        Me.txbNumeroEstudiantes.TabIndex = 12
        '
        'lblNumeroNotas
        '
        Me.lblNumeroNotas.AutoSize = True
        Me.lblNumeroNotas.Location = New System.Drawing.Point(12, 70)
        Me.lblNumeroNotas.Name = "lblNumeroNotas"
        Me.lblNumeroNotas.Size = New System.Drawing.Size(101, 15)
        Me.lblNumeroNotas.TabIndex = 19
        Me.lblNumeroNotas.Text = "Número de Notas"
        '
        'txbNumeroNotas
        '
        Me.txbNumeroNotas.Location = New System.Drawing.Point(12, 93)
        Me.txbNumeroNotas.Name = "txbNumeroNotas"
        Me.txbNumeroNotas.Size = New System.Drawing.Size(130, 23)
        Me.txbNumeroNotas.TabIndex = 18
        '
        'pbxEjercicio4
        '
        Me.pbxEjercicio4.Image = CType(resources.GetObject("pbxEjercicio4.Image"), System.Drawing.Image)
        Me.pbxEjercicio4.Location = New System.Drawing.Point(148, 16)
        Me.pbxEjercicio4.Name = "pbxEjercicio4"
        Me.pbxEjercicio4.Size = New System.Drawing.Size(122, 91)
        Me.pbxEjercicio4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxEjercicio4.TabIndex = 20
        Me.pbxEjercicio4.TabStop = False
        '
        'FrmEjercicio4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 289)
        Me.Controls.Add(Me.pbxEjercicio4)
        Me.Controls.Add(Me.lblNumeroNotas)
        Me.Controls.Add(Me.txbNumeroNotas)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lblNumeroEstudiantes)
        Me.Controls.Add(Me.btnEjecutar)
        Me.Controls.Add(Me.lblPromedios)
        Me.Controls.Add(Me.lbPromedios)
        Me.Controls.Add(Me.txbNumeroEstudiantes)
        Me.Name = "FrmEjercicio4"
        Me.Text = "Ejercicio 4"
        CType(Me.pbxEjercicio4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVolver As Button
    Friend WithEvents lblNumeroEstudiantes As Label
    Friend WithEvents btnEjecutar As Button
    Friend WithEvents lblPromedios As Label
    Friend WithEvents lbPromedios As ListBox
    Friend WithEvents txbNumeroEstudiantes As TextBox
    Friend WithEvents lblNumeroNotas As Label
    Friend WithEvents txbNumeroNotas As TextBox
    Friend WithEvents pbxEjercicio4 As PictureBox
End Class
