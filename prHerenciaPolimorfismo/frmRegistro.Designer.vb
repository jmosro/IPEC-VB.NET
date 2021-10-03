<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistro
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.cmbContrato = New System.Windows.Forms.ComboBox()
        Me.txtDocumento = New System.Windows.Forms.TextBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sueldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRegistrar)
        Me.GroupBox1.Controls.Add(Me.cmbContrato)
        Me.GroupBox1.Controls.Add(Me.txtDocumento)
        Me.GroupBox1.Controls.Add(Me.txtApellidos)
        Me.GroupBox1.Controls.Add(Me.txtNombres)
        Me.GroupBox1.Controls.Add(Me.cmbTipo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(311, 175)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(199, 115)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(100, 23)
        Me.btnRegistrar.TabIndex = 9
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'cmbContrato
        '
        Me.cmbContrato.FormattingEnabled = True
        Me.cmbContrato.Items.AddRange(New Object() {"C", "N"})
        Me.cmbContrato.Location = New System.Drawing.Point(92, 112)
        Me.cmbContrato.Name = "cmbContrato"
        Me.cmbContrato.Size = New System.Drawing.Size(100, 23)
        Me.cmbContrato.TabIndex = 8
        Me.cmbContrato.Text = "C"
        '
        'txtDocumento
        '
        Me.txtDocumento.Location = New System.Drawing.Point(92, 82)
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(100, 23)
        Me.txtDocumento.TabIndex = 7
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(199, 51)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(100, 23)
        Me.txtApellidos.TabIndex = 6
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(92, 52)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(100, 23)
        Me.txtNombres.TabIndex = 5
        '
        'cmbTipo
        '
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Items.AddRange(New Object() {"Vendedor", "Cajero", "Administrador"})
        Me.cmbTipo.Location = New System.Drawing.Point(91, 21)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(121, 23)
        Me.cmbTipo.TabIndex = 4
        Me.cmbTipo.Text = "Vendedor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Contrato:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Documento:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombres:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo:"
        '
        'dgvEmpleados
        '
        Me.dgvEmpleados.AllowUserToAddRows = False
        Me.dgvEmpleados.AllowUserToOrderColumns = True
        Me.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Tipo, Me.Nombres, Me.Apellidos, Me.Documento, Me.Sueldo})
        Me.dgvEmpleados.Location = New System.Drawing.Point(330, 13)
        Me.dgvEmpleados.Name = "dgvEmpleados"
        Me.dgvEmpleados.RowTemplate.Height = 25
        Me.dgvEmpleados.Size = New System.Drawing.Size(555, 175)
        Me.dgvEmpleados.TabIndex = 1
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        '
        'Nombres
        '
        Me.Nombres.HeaderText = "Nombres"
        Me.Nombres.Name = "Nombres"
        '
        'Apellidos
        '
        Me.Apellidos.HeaderText = "Apellidos"
        Me.Apellidos.Name = "Apellidos"
        '
        'Documento
        '
        Me.Documento.HeaderText = "Documento"
        Me.Documento.Name = "Documento"
        '
        'Sueldo
        '
        Me.Sueldo.HeaderText = "Sueldo"
        Me.Sueldo.Name = "Sueldo"
        '
        'frmRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 210)
        Me.Controls.Add(Me.dgvEmpleados)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmRegistro"
        Me.Text = "Registro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvEmpleados As DataGridView
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents cmbContrato As ComboBox
    Friend WithEvents txtDocumento As TextBox
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents cmbTipo As ComboBox
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Nombres As DataGridViewTextBoxColumn
    Friend WithEvents Apellidos As DataGridViewTextBoxColumn
    Friend WithEvents Documento As DataGridViewTextBoxColumn
    Friend WithEvents Sueldo As DataGridViewTextBoxColumn
End Class
