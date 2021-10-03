<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCuenta
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTitular = New System.Windows.Forms.TextBox()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIngresar = New System.Windows.Forms.TextBox()
        Me.txtRetirar = New System.Windows.Forms.TextBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.btnRetirar = New System.Windows.Forms.Button()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Titular:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Saldo:"
        '
        'txtTitular
        '
        Me.txtTitular.Location = New System.Drawing.Point(91, 23)
        Me.txtTitular.Name = "txtTitular"
        Me.txtTitular.Size = New System.Drawing.Size(197, 23)
        Me.txtTitular.TabIndex = 2
        '
        'txtSaldo
        '
        Me.txtSaldo.Enabled = False
        Me.txtSaldo.Location = New System.Drawing.Point(91, 60)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(100, 23)
        Me.txtSaldo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ingresar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Retirar"
        '
        'txtIngresar
        '
        Me.txtIngresar.Location = New System.Drawing.Point(91, 95)
        Me.txtIngresar.Name = "txtIngresar"
        Me.txtIngresar.Size = New System.Drawing.Size(100, 23)
        Me.txtIngresar.TabIndex = 6
        '
        'txtRetirar
        '
        Me.txtRetirar.Location = New System.Drawing.Point(91, 131)
        Me.txtRetirar.Name = "txtRetirar"
        Me.txtRetirar.Size = New System.Drawing.Size(100, 23)
        Me.txtRetirar.TabIndex = 7
        '
        'btnIngresar
        '
        Me.btnIngresar.Enabled = False
        Me.btnIngresar.Location = New System.Drawing.Point(198, 94)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(90, 23)
        Me.btnIngresar.TabIndex = 8
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'btnRetirar
        '
        Me.btnRetirar.Enabled = False
        Me.btnRetirar.Location = New System.Drawing.Point(197, 131)
        Me.btnRetirar.Name = "btnRetirar"
        Me.btnRetirar.Size = New System.Drawing.Size(91, 23)
        Me.btnRetirar.TabIndex = 9
        Me.btnRetirar.Text = "Retirar"
        Me.btnRetirar.UseVisualStyleBackColor = True
        '
        'btnCrear
        '
        Me.btnCrear.Location = New System.Drawing.Point(197, 59)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(91, 23)
        Me.btnCrear.TabIndex = 10
        Me.btnCrear.Text = "Crear Cuenta"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'frmCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 185)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.btnRetirar)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.txtRetirar)
        Me.Controls.Add(Me.txtIngresar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.txtTitular)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCuenta"
        Me.Text = "Cuenta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTitular As TextBox
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIngresar As TextBox
    Friend WithEvents txtRetirar As TextBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents btnRetirar As Button
    Friend WithEvents btnCrear As Button
End Class
