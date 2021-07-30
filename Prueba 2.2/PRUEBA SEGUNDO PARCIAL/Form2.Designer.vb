<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataCliente = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoría = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CboxCategoria = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CboxSexo = New System.Windows.Forms.ComboBox()
        Me.TxtMaterno = New System.Windows.Forms.TextBox()
        Me.Seguro = New System.Windows.Forms.TextBox()
        Me.TxtPaterno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft JhengHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(634, 55)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 44)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "GUARDAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataCliente
        '
        Me.DataCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column1, Me.Column2, Me.Sexo, Me.Categoría})
        Me.DataCliente.Location = New System.Drawing.Point(127, 356)
        Me.DataCliente.Name = "DataCliente"
        Me.DataCliente.RowHeadersWidth = 51
        Me.DataCliente.RowTemplate.Height = 24
        Me.DataCliente.Size = New System.Drawing.Size(667, 237)
        Me.DataCliente.TabIndex = 24
        '
        'Column3
        '
        Me.Column3.HeaderText = "CODIGO"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 120
        '
        'Column1
        '
        Me.Column1.HeaderText = "APELLIDO PATERNO"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "APELLIDO MATERNO"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Sexo
        '
        Me.Sexo.HeaderText = "SEXO"
        Me.Sexo.MinimumWidth = 6
        Me.Sexo.Name = "Sexo"
        Me.Sexo.Width = 125
        '
        'Categoría
        '
        Me.Categoría.HeaderText = "CATEGORIA"
        Me.Categoría.MinimumWidth = 6
        Me.Categoría.Name = "Categoría"
        Me.Categoría.Width = 125
        '
        'CboxCategoria
        '
        Me.CboxCategoria.Font = New System.Drawing.Font("Microsoft JhengHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboxCategoria.FormattingEnabled = True
        Me.CboxCategoria.Items.AddRange(New Object() {"NUEVO", "ANTIGUO"})
        Me.CboxCategoria.Location = New System.Drawing.Point(378, 250)
        Me.CboxCategoria.Name = "CboxCategoria"
        Me.CboxCategoria.Size = New System.Drawing.Size(121, 30)
        Me.CboxCategoria.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft JhengHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(105, 263)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 24)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "CATEGORIA"
        '
        'CboxSexo
        '
        Me.CboxSexo.Font = New System.Drawing.Font("Microsoft JhengHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboxSexo.FormattingEnabled = True
        Me.CboxSexo.Items.AddRange(New Object() {"MASCULINO", "", "FEMENINO"})
        Me.CboxSexo.Location = New System.Drawing.Point(379, 188)
        Me.CboxSexo.Name = "CboxSexo"
        Me.CboxSexo.Size = New System.Drawing.Size(156, 30)
        Me.CboxSexo.TabIndex = 21
        '
        'TxtMaterno
        '
        Me.TxtMaterno.Font = New System.Drawing.Font("Microsoft JhengHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMaterno.Location = New System.Drawing.Point(379, 96)
        Me.TxtMaterno.Name = "TxtMaterno"
        Me.TxtMaterno.Size = New System.Drawing.Size(203, 29)
        Me.TxtMaterno.TabIndex = 20
        '
        'Seguro
        '
        Me.Seguro.Font = New System.Drawing.Font("Microsoft JhengHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Seguro.Location = New System.Drawing.Point(379, 140)
        Me.Seguro.Name = "Seguro"
        Me.Seguro.Size = New System.Drawing.Size(203, 29)
        Me.Seguro.TabIndex = 19
        '
        'TxtPaterno
        '
        Me.TxtPaterno.Font = New System.Drawing.Font("Microsoft JhengHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPaterno.Location = New System.Drawing.Point(379, 53)
        Me.TxtPaterno.Name = "TxtPaterno"
        Me.TxtPaterno.Size = New System.Drawing.Size(203, 29)
        Me.TxtPaterno.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft JhengHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(106, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 24)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "SEXO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft JhengHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(106, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(258, 24)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "NUMERO SEGURO SOCIAL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft JhengHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(106, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 24)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "APELLIDO MATERNO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(106, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 24)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "APELLIDO PATERNO"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft JhengHei UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(634, 206)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 44)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "ATRAS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 519)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 17)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Label6"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(898, 646)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataCliente)
        Me.Controls.Add(Me.CboxCategoria)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CboxSexo)
        Me.Controls.Add(Me.TxtMaterno)
        Me.Controls.Add(Me.Seguro)
        Me.Controls.Add(Me.TxtPaterno)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form2"
        Me.Text = "CLIENTE"
        CType(Me.DataCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents DataCliente As DataGridView
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Sexo As DataGridViewTextBoxColumn
    Friend WithEvents Categoría As DataGridViewTextBoxColumn
    Friend WithEvents CboxCategoria As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CboxSexo As ComboBox
    Friend WithEvents TxtMaterno As TextBox
    Friend WithEvents Seguro As TextBox
    Friend WithEvents TxtPaterno As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
End Class
