<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Benvinguda
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Benvinguda))
        Me.DataSet1 = New Receptes.DataSet1()
        Me.ReceptaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuscarButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbSeleccio = New System.Windows.Forms.ComboBox()
        Me.cbTriar = New System.Windows.Forms.ComboBox()
        Me.IngredientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceptaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.IngredientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReceptaBindingSource
        '
        Me.ReceptaBindingSource.DataMember = "Recepta"
        Me.ReceptaBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1BindingSource
        '
        Me.DataSet1BindingSource.DataSource = Me.DataSet1
        Me.DataSet1BindingSource.Position = 0
        '
        'BuscarButton
        '
        Me.BuscarButton.BackColor = System.Drawing.Color.OliveDrab
        Me.BuscarButton.ForeColor = System.Drawing.Color.White
        Me.BuscarButton.Location = New System.Drawing.Point(951, 17)
        Me.BuscarButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BuscarButton.Name = "BuscarButton"
        Me.BuscarButton.Size = New System.Drawing.Size(92, 34)
        Me.BuscarButton.TabIndex = 4
        Me.BuscarButton.Text = "Buscar"
        Me.BuscarButton.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cbSeleccio)
        Me.Panel1.Controls.Add(Me.cbTriar)
        Me.Panel1.Controls.Add(Me.BuscarButton)
        Me.Panel1.Location = New System.Drawing.Point(64, 14)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1068, 74)
        Me.Panel1.TabIndex = 9
        '
        'cbSeleccio
        '
        Me.cbSeleccio.Enabled = False
        Me.cbSeleccio.FormattingEnabled = True
        Me.cbSeleccio.Location = New System.Drawing.Point(390, 17)
        Me.cbSeleccio.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbSeleccio.Name = "cbSeleccio"
        Me.cbSeleccio.Size = New System.Drawing.Size(514, 28)
        Me.cbSeleccio.TabIndex = 5
        '
        'cbTriar
        '
        Me.cbTriar.FormattingEnabled = True
        Me.cbTriar.Items.AddRange(New Object() {"Nom recepta", "Categoria", "Raccions", "Dificultat", "Preferit", "Ingredients", "Totes les receptes", "Sortir"})
        Me.cbTriar.Location = New System.Drawing.Point(4, 17)
        Me.cbTriar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbTriar.Name = "cbTriar"
        Me.cbTriar.Size = New System.Drawing.Size(325, 28)
        Me.cbTriar.TabIndex = 3
        '
        'IngredientBindingSource
        '
        Me.IngredientBindingSource.DataMember = "Ingredient"
        Me.IngredientBindingSource.DataSource = Me.DataSet1
        '
        'Benvinguda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1185, 695)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Benvinguda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Benvinguda Receptes "
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceptaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.IngredientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents ReceptaBindingSource As BindingSource
    Friend WithEvents BuscarButton As Button
    Friend WithEvents cbTriar As ComboBox
    Friend WithEvents DataSet1BindingSource As BindingSource
    Friend WithEvents cbSeleccio As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents IngredientBindingSource As BindingSource
End Class
