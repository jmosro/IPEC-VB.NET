<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPassword
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
        Me.btnGenerarPassword = New System.Windows.Forms.Button()
        Me.lbHistorialPassword = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLongitud = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnGenerarPassword
        '
        Me.btnGenerarPassword.Location = New System.Drawing.Point(168, 19)
        Me.btnGenerarPassword.Name = "btnGenerarPassword"
        Me.btnGenerarPassword.Size = New System.Drawing.Size(141, 23)
        Me.btnGenerarPassword.TabIndex = 0
        Me.btnGenerarPassword.Text = "Generar Password"
        Me.btnGenerarPassword.UseVisualStyleBackColor = True
        '
        'lbHistorialPassword
        '
        Me.lbHistorialPassword.FormattingEnabled = True
        Me.lbHistorialPassword.ItemHeight = 15
        Me.lbHistorialPassword.Location = New System.Drawing.Point(26, 56)
        Me.lbHistorialPassword.Name = "lbHistorialPassword"
        Me.lbHistorialPassword.Size = New System.Drawing.Size(283, 184)
        Me.lbHistorialPassword.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Longitud:"
        '
        'txtLongitud
        '
        Me.txtLongitud.Location = New System.Drawing.Point(90, 20)
        Me.txtLongitud.Name = "txtLongitud"
        Me.txtLongitud.Size = New System.Drawing.Size(63, 23)
        Me.txtLongitud.TabIndex = 3
        '
        'frmPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 252)
        Me.Controls.Add(Me.txtLongitud)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbHistorialPassword)
        Me.Controls.Add(Me.btnGenerarPassword)
        Me.Name = "frmPassword"
        Me.Text = "Generar Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGenerarPassword As Button
    Friend WithEvents lbHistorialPassword As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLongitud As TextBox
End Class
