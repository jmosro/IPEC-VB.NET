<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEjercicio3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEjercicio3))
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.btnEjecutar = New System.Windows.Forms.Button()
        Me.lblDatos = New System.Windows.Forms.Label()
        Me.lbDatos = New System.Windows.Forms.ListBox()
        Me.txbResultado = New System.Windows.Forms.TextBox()
        Me.cmbArea = New System.Windows.Forms.ComboBox()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.pbxEjercicio3 = New System.Windows.Forms.PictureBox()
        CType(Me.pbxEjercicio3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(159, 183)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 11
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Location = New System.Drawing.Point(140, 120)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(59, 15)
        Me.lblResultado.TabIndex = 10
        Me.lblResultado.Text = "Resultado"
        '
        'btnEjecutar
        '
        Me.btnEjecutar.Location = New System.Drawing.Point(78, 183)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(75, 23)
        Me.btnEjecutar.TabIndex = 9
        Me.btnEjecutar.Text = "Ejecutar"
        Me.btnEjecutar.UseVisualStyleBackColor = True
        '
        'lblDatos
        '
        Me.lblDatos.AutoSize = True
        Me.lblDatos.Location = New System.Drawing.Point(140, 18)
        Me.lblDatos.Name = "lblDatos"
        Me.lblDatos.Size = New System.Drawing.Size(37, 15)
        Me.lblDatos.TabIndex = 8
        Me.lblDatos.Text = "Datos"
        '
        'lbDatos
        '
        Me.lbDatos.FormattingEnabled = True
        Me.lbDatos.ItemHeight = 15
        Me.lbDatos.Location = New System.Drawing.Point(140, 41)
        Me.lbDatos.Name = "lbDatos"
        Me.lbDatos.Size = New System.Drawing.Size(155, 64)
        Me.lbDatos.TabIndex = 7
        '
        'txbResultado
        '
        Me.txbResultado.Enabled = False
        Me.txbResultado.Location = New System.Drawing.Point(140, 143)
        Me.txbResultado.Name = "txbResultado"
        Me.txbResultado.Size = New System.Drawing.Size(155, 23)
        Me.txbResultado.TabIndex = 6
        '
        'cmbArea
        '
        Me.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbArea.FormattingEnabled = True
        Me.cmbArea.Items.AddRange(New Object() {"Triángulo", "Cuadrado", "Rectángulo", "Rombo"})
        Me.cmbArea.Location = New System.Drawing.Point(12, 41)
        Me.cmbArea.Name = "cmbArea"
        Me.cmbArea.Size = New System.Drawing.Size(121, 23)
        Me.cmbArea.TabIndex = 12
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Location = New System.Drawing.Point(12, 18)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(31, 15)
        Me.lblArea.TabIndex = 13
        Me.lblArea.Text = "Área"
        '
        'pbxEjercicio3
        '
        Me.pbxEjercicio3.Image = CType(resources.GetObject("pbxEjercicio3.Image"), System.Drawing.Image)
        Me.pbxEjercicio3.Location = New System.Drawing.Point(12, 75)
        Me.pbxEjercicio3.Name = "pbxEjercicio3"
        Me.pbxEjercicio3.Size = New System.Drawing.Size(122, 91)
        Me.pbxEjercicio3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxEjercicio3.TabIndex = 14
        Me.pbxEjercicio3.TabStop = False
        '
        'FrmEjercicio3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 221)
        Me.Controls.Add(Me.pbxEjercicio3)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.cmbArea)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.btnEjecutar)
        Me.Controls.Add(Me.lblDatos)
        Me.Controls.Add(Me.lbDatos)
        Me.Controls.Add(Me.txbResultado)
        Me.Name = "FrmEjercicio3"
        Me.Text = "Ejercicio 3"
        CType(Me.pbxEjercicio3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVolver As Button
    Friend WithEvents lblResultado As Label
    Friend WithEvents btnEjecutar As Button
    Friend WithEvents LblNumeros As Label
    Friend WithEvents LbxNumeros As ListBox
    Friend WithEvents txbResultado As TextBox
    Friend WithEvents cmbArea As ComboBox
    Friend WithEvents lblDatos As Label
    Friend WithEvents lblArea As Label
    Friend WithEvents lbDatos As ListBox
    Friend WithEvents pbxEjercicio3 As PictureBox
End Class
