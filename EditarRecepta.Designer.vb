<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarRecepta
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
        Me.components = New System.ComponentModel.Container()
        Dim CategoriaLabel As System.Windows.Forms.Label
        Dim RaccionsLabel As System.Windows.Forms.Label
        Dim ElaboracióLabel As System.Windows.Forms.Label
        Dim DificultatLabel1 As System.Windows.Forms.Label
        Dim PreferitLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditarRecepta))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ReceptaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ReceptaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Receptes.DataSet1()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ReceptaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.SortirButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.NomReceptaTextBox = New System.Windows.Forms.TextBox()
        Me.ImatgeTextBox = New System.Windows.Forms.TextBox()
        Me.RaccionsTextBox = New System.Windows.Forms.TextBox()
        Me.ElaboracióTextBox = New System.Windows.Forms.TextBox()
        Me.IngredientDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ingredients = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Recepta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IngredientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PreferitCheckBox = New System.Windows.Forms.CheckBox()
        Me.IDReceptaTextBox = New System.Windows.Forms.TextBox()
        Me.DificultatComboBox = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CategoriaComboBox = New System.Windows.Forms.ComboBox()
        CategoriaLabel = New System.Windows.Forms.Label()
        RaccionsLabel = New System.Windows.Forms.Label()
        ElaboracióLabel = New System.Windows.Forms.Label()
        DificultatLabel1 = New System.Windows.Forms.Label()
        PreferitLabel = New System.Windows.Forms.Label()
        CType(Me.ReceptaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ReceptaBindingNavigator.SuspendLayout()
        CType(Me.ReceptaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IngredientDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IngredientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CategoriaLabel
        '
        CategoriaLabel.AutoSize = True
        CategoriaLabel.Location = New System.Drawing.Point(64, 235)
        CategoriaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CategoriaLabel.Name = "CategoriaLabel"
        CategoriaLabel.Size = New System.Drawing.Size(82, 20)
        CategoriaLabel.TabIndex = 22
        CategoriaLabel.Text = "Categoria:"
        '
        'RaccionsLabel
        '
        RaccionsLabel.AutoSize = True
        RaccionsLabel.Location = New System.Drawing.Point(222, 235)
        RaccionsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        RaccionsLabel.Name = "RaccionsLabel"
        RaccionsLabel.Size = New System.Drawing.Size(79, 20)
        RaccionsLabel.TabIndex = 26
        RaccionsLabel.Text = "Raccions:"
        '
        'ElaboracióLabel
        '
        ElaboracióLabel.AutoSize = True
        ElaboracióLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ElaboracióLabel.Location = New System.Drawing.Point(560, 372)
        ElaboracióLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ElaboracióLabel.Name = "ElaboracióLabel"
        ElaboracióLabel.Size = New System.Drawing.Size(288, 29)
        ElaboracióLabel.TabIndex = 30
        ElaboracióLabel.Text = "Pasos per a la preparació"
        AddHandler ElaboracióLabel.Click, AddressOf Me.ElaboracióLabel_Click
        '
        'DificultatLabel1
        '
        DificultatLabel1.AutoSize = True
        DificultatLabel1.Location = New System.Drawing.Point(375, 235)
        DificultatLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DificultatLabel1.Name = "DificultatLabel1"
        DificultatLabel1.Size = New System.Drawing.Size(75, 20)
        DificultatLabel1.TabIndex = 36
        DificultatLabel1.Text = "Dificultat:"
        '
        'PreferitLabel
        '
        PreferitLabel.AutoSize = True
        PreferitLabel.Location = New System.Drawing.Point(86, 57)
        PreferitLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PreferitLabel.Name = "PreferitLabel"
        PreferitLabel.Size = New System.Drawing.Size(60, 20)
        PreferitLabel.TabIndex = 39
        PreferitLabel.Text = "Preferit"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ReceptaBindingNavigator
        '
        Me.ReceptaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ReceptaBindingNavigator.BindingSource = Me.ReceptaBindingSource
        Me.ReceptaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ReceptaBindingNavigator.DeleteItem = Nothing
        Me.ReceptaBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ReceptaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ReceptaBindingNavigatorSaveItem, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.SortirButton, Me.ToolStripSeparator2})
        Me.ReceptaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ReceptaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ReceptaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ReceptaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ReceptaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ReceptaBindingNavigator.Name = "ReceptaBindingNavigator"
        Me.ReceptaBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.ReceptaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ReceptaBindingNavigator.Size = New System.Drawing.Size(1185, 33)
        Me.ReceptaBindingNavigator.TabIndex = 18
        Me.ReceptaBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorAddNewItem.Text = "Afegir nova recepta"
        Me.BindingNavigatorAddNewItem.Visible = False
        '
        'ReceptaBindingSource
        '
        Me.ReceptaBindingSource.DataMember = "Recepta"
        Me.ReceptaBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(57, 28)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        Me.BindingNavigatorCountItem.Visible = False
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        Me.BindingNavigatorMoveFirstItem.Visible = False
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        Me.BindingNavigatorMovePreviousItem.Visible = False
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 33)
        Me.BindingNavigatorSeparator.Visible = False
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(73, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        Me.BindingNavigatorPositionItem.Visible = False
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 33)
        Me.BindingNavigatorSeparator1.Visible = False
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        Me.BindingNavigatorMoveNextItem.Visible = False
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        Me.BindingNavigatorMoveLastItem.Visible = False
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 33)
        Me.BindingNavigatorSeparator2.Visible = False
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorDeleteItem.Text = "Esborrar recepta seleccionada"
        Me.BindingNavigatorDeleteItem.Visible = False
        '
        'ReceptaBindingNavigatorSaveItem
        '
        Me.ReceptaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ReceptaBindingNavigatorSaveItem.Image = CType(resources.GetObject("ReceptaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ReceptaBindingNavigatorSaveItem.Name = "ReceptaBindingNavigatorSaveItem"
        Me.ReceptaBindingNavigatorSaveItem.Size = New System.Drawing.Size(34, 28)
        Me.ReceptaBindingNavigatorSaveItem.Text = "Guardad Canvis"
        Me.ReceptaBindingNavigatorSaveItem.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 33)
        Me.ToolStripSeparator1.Visible = False
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(34, 28)
        Me.ToolStripButton1.Text = "Editar Receptes"
        '
        'SortirButton
        '
        Me.SortirButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SortirButton.Image = CType(resources.GetObject("SortirButton.Image"), System.Drawing.Image)
        Me.SortirButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SortirButton.Name = "SortirButton"
        Me.SortirButton.Size = New System.Drawing.Size(34, 28)
        Me.SortirButton.Text = "Tornar a benvinguda"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 33)
        '
        'NomReceptaTextBox
        '
        Me.NomReceptaTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.NomReceptaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NomReceptaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceptaBindingSource, "NomRecepta", True))
        Me.NomReceptaTextBox.Enabled = False
        Me.NomReceptaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomReceptaTextBox.Location = New System.Drawing.Point(38, 103)
        Me.NomReceptaTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NomReceptaTextBox.Multiline = True
        Me.NomReceptaTextBox.Name = "NomReceptaTextBox"
        Me.NomReceptaTextBox.Size = New System.Drawing.Size(668, 94)
        Me.NomReceptaTextBox.TabIndex = 21
        '
        'ImatgeTextBox
        '
        Me.ImatgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceptaBindingSource, "Imatge", True))
        Me.ImatgeTextBox.Enabled = False
        Me.ImatgeTextBox.Location = New System.Drawing.Point(813, 65)
        Me.ImatgeTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ImatgeTextBox.Name = "ImatgeTextBox"
        Me.ImatgeTextBox.Size = New System.Drawing.Size(154, 26)
        Me.ImatgeTextBox.TabIndex = 25
        '
        'RaccionsTextBox
        '
        Me.RaccionsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceptaBindingSource, "Raccions", True))
        Me.RaccionsTextBox.Enabled = False
        Me.RaccionsTextBox.Location = New System.Drawing.Point(226, 260)
        Me.RaccionsTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RaccionsTextBox.Name = "RaccionsTextBox"
        Me.RaccionsTextBox.Size = New System.Drawing.Size(72, 26)
        Me.RaccionsTextBox.TabIndex = 27
        '
        'ElaboracióTextBox
        '
        Me.ElaboracióTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceptaBindingSource, "Elaboració", True))
        Me.ElaboracióTextBox.Enabled = False
        Me.ElaboracióTextBox.Location = New System.Drawing.Point(564, 415)
        Me.ElaboracióTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ElaboracióTextBox.Multiline = True
        Me.ElaboracióTextBox.Name = "ElaboracióTextBox"
        Me.ElaboracióTextBox.Size = New System.Drawing.Size(608, 442)
        Me.ElaboracióTextBox.TabIndex = 31
        Me.ElaboracióTextBox.UseSystemPasswordChar = True
        '
        'IngredientDataGridView
        '
        Me.IngredientDataGridView.AllowUserToOrderColumns = True
        Me.IngredientDataGridView.AutoGenerateColumns = False
        Me.IngredientDataGridView.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IngredientDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.IngredientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IngredientDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.Ingredients, Me.Recepta})
        Me.IngredientDataGridView.DataSource = Me.IngredientBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.IngredientDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.IngredientDataGridView.Enabled = False
        Me.IngredientDataGridView.Location = New System.Drawing.Point(0, 415)
        Me.IngredientDataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IngredientDataGridView.Name = "IngredientDataGridView"
        Me.IngredientDataGridView.RowHeadersWidth = 62
        Me.IngredientDataGridView.Size = New System.Drawing.Size(556, 445)
        Me.IngredientDataGridView.TabIndex = 33
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Quantitat"
        Me.DataGridViewTextBoxColumn3.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn3.Frozen = True
        Me.DataGridViewTextBoxColumn3.HeaderText = "Quantitat"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 60
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "UnitatsMesura"
        Me.DataGridViewTextBoxColumn4.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn4.Frozen = True
        Me.DataGridViewTextBoxColumn4.HeaderText = ""
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 60
        '
        'Ingredients
        '
        Me.Ingredients.DataPropertyName = "Ingredients"
        Me.Ingredients.Frozen = True
        Me.Ingredients.HeaderText = "Ingredients"
        Me.Ingredients.MinimumWidth = 8
        Me.Ingredients.Name = "Ingredients"
        Me.Ingredients.Width = 180
        '
        'Recepta
        '
        Me.Recepta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Recepta.DataPropertyName = "Recepta"
        Me.Recepta.HeaderText = "Recepta"
        Me.Recepta.MinimumWidth = 8
        Me.Recepta.Name = "Recepta"
        Me.Recepta.ReadOnly = True
        Me.Recepta.Visible = False
        Me.Recepta.Width = 8
        '
        'IngredientBindingSource
        '
        Me.IngredientBindingSource.DataMember = "FK_Recepta _Ingredient"
        Me.IngredientBindingSource.DataSource = Me.ReceptaBindingSource
        '
        'PreferitCheckBox
        '
        Me.PreferitCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PreferitCheckBox.Checked = True
        Me.PreferitCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PreferitCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ReceptaBindingSource, "Preferit", True))
        Me.PreferitCheckBox.Enabled = False
        Me.PreferitCheckBox.Location = New System.Drawing.Point(38, 46)
        Me.PreferitCheckBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PreferitCheckBox.Name = "PreferitCheckBox"
        Me.PreferitCheckBox.Size = New System.Drawing.Size(39, 45)
        Me.PreferitCheckBox.TabIndex = 33
        Me.PreferitCheckBox.UseVisualStyleBackColor = True
        '
        'IDReceptaTextBox
        '
        Me.IDReceptaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceptaBindingSource, "IDRecepta", True))
        Me.IDReceptaTextBox.Location = New System.Drawing.Point(558, 55)
        Me.IDReceptaTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IDReceptaTextBox.Name = "IDReceptaTextBox"
        Me.IDReceptaTextBox.Size = New System.Drawing.Size(148, 26)
        Me.IDReceptaTextBox.TabIndex = 36
        Me.IDReceptaTextBox.Visible = False
        '
        'DificultatComboBox
        '
        Me.DificultatComboBox.AutoCompleteCustomSource.AddRange(New String() {"Fàcil", "Mitja", "Alta"})
        Me.DificultatComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.DificultatComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.DificultatComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceptaBindingSource, "Dificultat", True))
        Me.DificultatComboBox.Enabled = False
        Me.DificultatComboBox.FormattingEnabled = True
        Me.DificultatComboBox.Items.AddRange(New Object() {"Fàcil", "Mitja", "Alta"})
        Me.DificultatComboBox.Location = New System.Drawing.Point(356, 258)
        Me.DificultatComboBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DificultatComboBox.Name = "DificultatComboBox"
        Me.DificultatComboBox.Size = New System.Drawing.Size(115, 28)
        Me.DificultatComboBox.TabIndex = 37
        '
        'PictureBox1
        '
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Location = New System.Drawing.Point(734, 14)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(420, 352)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "Dobleclick per seleccionar imatge"
        '
        'CategoriaComboBox
        '
        Me.CategoriaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReceptaBindingSource, "Categoria", True))
        Me.CategoriaComboBox.Enabled = False
        Me.CategoriaComboBox.FormattingEnabled = True
        Me.CategoriaComboBox.Items.AddRange(New Object() {"Pastas", "Carns", "Peixos", "Entrants", "Begudes", "Postres", "Pans"})
        Me.CategoriaComboBox.Location = New System.Drawing.Point(38, 258)
        Me.CategoriaComboBox.Name = "CategoriaComboBox"
        Me.CategoriaComboBox.Size = New System.Drawing.Size(128, 28)
        Me.CategoriaComboBox.TabIndex = 38
        '
        'EditarRecepta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1185, 702)
        Me.Controls.Add(PreferitLabel)
        Me.Controls.Add(Me.CategoriaComboBox)
        Me.Controls.Add(DificultatLabel1)
        Me.Controls.Add(Me.DificultatComboBox)
        Me.Controls.Add(Me.IDReceptaTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.IngredientDataGridView)
        Me.Controls.Add(Me.NomReceptaTextBox)
        Me.Controls.Add(CategoriaLabel)
        Me.Controls.Add(Me.ImatgeTextBox)
        Me.Controls.Add(RaccionsLabel)
        Me.Controls.Add(Me.RaccionsTextBox)
        Me.Controls.Add(ElaboracióLabel)
        Me.Controls.Add(Me.ElaboracióTextBox)
        Me.Controls.Add(Me.PreferitCheckBox)
        Me.Controls.Add(Me.ReceptaBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "EditarRecepta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receptes"
        CType(Me.ReceptaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ReceptaBindingNavigator.ResumeLayout(False)
        Me.ReceptaBindingNavigator.PerformLayout()
        CType(Me.ReceptaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IngredientDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IngredientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub ElaboracióLabel_Click(sender As Object, e As EventArgs)
        Throw New NotImplementedException()
    End Sub

    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ReceptaBindingSource As BindingSource
    Friend WithEvents ReceptaBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ReceptaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NomReceptaTextBox As TextBox
    Friend WithEvents ImatgeTextBox As TextBox
    Friend WithEvents RaccionsTextBox As TextBox
    Friend WithEvents ElaboracióTextBox As TextBox
    Friend WithEvents PreferitCheckBox As CheckBox
    Friend WithEvents IngredientBindingSource As BindingSource
    Friend WithEvents IngredientDataGridView As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SortirButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents IDReceptaTextBox As TextBox
    Friend WithEvents DificultatComboBox As ComboBox
    Friend WithEvents CategoriaComboBox As ComboBox
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Ingredients As DataGridViewTextBoxColumn
    Friend WithEvents Recepta As DataGridViewTextBoxColumn
End Class
