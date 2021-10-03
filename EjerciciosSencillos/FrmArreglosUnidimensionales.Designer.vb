<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmArreglosUnidimensionales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmArreglosUnidimensionales))
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.txtbBuscar = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.pbxEjercicio1 = New System.Windows.Forms.PictureBox()
        CType(Me.pbxEjercicio1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(22, 22)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(42, 15)
        Me.lblBuscar.TabIndex = 0
        Me.lblBuscar.Text = "Buscar"
        '
        'txtbBuscar
        '
        Me.txtbBuscar.Location = New System.Drawing.Point(22, 46)
        Me.txtbBuscar.Name = "txtbBuscar"
        Me.txtbBuscar.Size = New System.Drawing.Size(201, 23)
        Me.txtbBuscar.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(46, 87)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(127, 87)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 3
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'pbxEjercicio1
        '
        Me.pbxEjercicio1.Image = CType(resources.GetObject("pbxEjercicio1.Image"), System.Drawing.Image)
        Me.pbxEjercicio1.Location = New System.Drawing.Point(57, 124)
        Me.pbxEjercicio1.Name = "pbxEjercicio1"
        Me.pbxEjercicio1.Size = New System.Drawing.Size(122, 91)
        Me.pbxEjercicio1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxEjercicio1.TabIndex = 7
        Me.pbxEjercicio1.TabStop = False
        '
        'FrmArreglosUnidimensionales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(247, 233)
        Me.Controls.Add(Me.pbxEjercicio1)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtbBuscar)
        Me.Controls.Add(Me.lblBuscar)
        Me.Name = "FrmArreglosUnidimensionales"
        Me.Text = "Unidimensionales"
        CType(Me.pbxEjercicio1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBuscar As Label
    Friend WithEvents txtbBuscar As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents pbxEjercicio1 As PictureBox
End Class
