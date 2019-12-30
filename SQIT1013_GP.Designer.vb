<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim YEARLabel As System.Windows.Forms.Label
        Dim Total_Number_of_Water_Treatment_PlantsLabel As System.Windows.Forms.Label
        Dim Number_of__Water_Treatment_Plants_With_Fluoride_FeedersLabel As System.Windows.Forms.Label
        Dim Percentage_of__Water_Treatment_Plants_With_Fluoride_FeedersLabel As System.Windows.Forms.Label
        Dim Total_PopulationLabel As System.Windows.Forms.Label
        Dim Number_of_Estimated_Population_Receiving_Fluoridated_WaterLabel As System.Windows.Forms.Label
        Dim Percentage_of_Estimated_Population_Receiving_Fluoridated_WaterLabel As System.Windows.Forms.Label
        Me.WaterDataSet = New SQIT1013_GP.WaterDataSet()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table1TableAdapter = New SQIT1013_GP.WaterDataSetTableAdapters.Table1TableAdapter()
        Me.TableAdapterManager = New SQIT1013_GP.WaterDataSetTableAdapters.TableAdapterManager()
        Me.Table1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Table1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Table1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YEARTextBox = New System.Windows.Forms.TextBox()
        Me.Total_Number_of_Water_Treatment_PlantsTextBox = New System.Windows.Forms.TextBox()
        Me.Number_of__Water_Treatment_Plants_With_Fluoride_FeedersTextBox = New System.Windows.Forms.TextBox()
        Me.Percentage_of__Water_Treatment_Plants_With_Fluoride_FeedersTextBox = New System.Windows.Forms.TextBox()
        Me.Total_PopulationTextBox = New System.Windows.Forms.TextBox()
        Me.Number_of_Estimated_Population_Receiving_Fluoridated_WaterTextBox = New System.Windows.Forms.TextBox()
        Me.Percentage_of_Estimated_Population_Receiving_Fluoridated_WaterTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        YEARLabel = New System.Windows.Forms.Label()
        Total_Number_of_Water_Treatment_PlantsLabel = New System.Windows.Forms.Label()
        Number_of__Water_Treatment_Plants_With_Fluoride_FeedersLabel = New System.Windows.Forms.Label()
        Percentage_of__Water_Treatment_Plants_With_Fluoride_FeedersLabel = New System.Windows.Forms.Label()
        Total_PopulationLabel = New System.Windows.Forms.Label()
        Number_of_Estimated_Population_Receiving_Fluoridated_WaterLabel = New System.Windows.Forms.Label()
        Percentage_of_Estimated_Population_Receiving_Fluoridated_WaterLabel = New System.Windows.Forms.Label()
        CType(Me.WaterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Table1BindingNavigator.SuspendLayout()
        CType(Me.Table1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WaterDataSet
        '
        Me.WaterDataSet.DataSetName = "WaterDataSet"
        Me.WaterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.WaterDataSet
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Table1TableAdapter = Me.Table1TableAdapter
        Me.TableAdapterManager.UpdateOrder = SQIT1013_GP.WaterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Table1BindingNavigator
        '
        Me.Table1BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Table1BindingNavigator.BindingSource = Me.Table1BindingSource
        Me.Table1BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Table1BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Table1BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Table1BindingNavigatorSaveItem})
        Me.Table1BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Table1BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Table1BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Table1BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Table1BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Table1BindingNavigator.Name = "Table1BindingNavigator"
        Me.Table1BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Table1BindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.Table1BindingNavigator.TabIndex = 0
        Me.Table1BindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Table1BindingNavigatorSaveItem
        '
        Me.Table1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Table1BindingNavigatorSaveItem.Image = CType(resources.GetObject("Table1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Table1BindingNavigatorSaveItem.Name = "Table1BindingNavigatorSaveItem"
        Me.Table1BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Table1BindingNavigatorSaveItem.Text = "Save Data"
        '
        'Table1DataGridView
        '
        Me.Table1DataGridView.AutoGenerateColumns = False
        Me.Table1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.Table1DataGridView.DataSource = Me.Table1BindingSource
        Me.Table1DataGridView.Location = New System.Drawing.Point(29, 463)
        Me.Table1DataGridView.Name = "Table1DataGridView"
        Me.Table1DataGridView.Size = New System.Drawing.Size(737, 220)
        Me.Table1DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "YEAR"
        Me.DataGridViewTextBoxColumn1.HeaderText = "YEAR"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Total Number of Water Treatment Plants"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Total Number of Water Treatment Plants"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Number of  Water Treatment Plants With Fluoride Feeders"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Number of  Water Treatment Plants With Fluoride Feeders"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Percentage of  Water Treatment Plants With Fluoride Feeders"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Percentage of  Water Treatment Plants With Fluoride Feeders"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Total Population"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Total Population"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Number of Estimated Population Receiving Fluoridated Water"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Number of Estimated Population Receiving Fluoridated Water"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Percentage of Estimated Population Receiving Fluoridated Water"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Percentage of Estimated Population Receiving Fluoridated Water"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'YEARLabel
        '
        YEARLabel.AutoSize = True
        YEARLabel.Location = New System.Drawing.Point(121, 188)
        YEARLabel.Name = "YEARLabel"
        YEARLabel.Size = New System.Drawing.Size(39, 13)
        YEARLabel.TabIndex = 2
        YEARLabel.Text = "YEAR:"
        '
        'YEARTextBox
        '
        Me.YEARTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "YEAR", True))
        Me.YEARTextBox.Location = New System.Drawing.Point(444, 185)
        Me.YEARTextBox.Name = "YEARTextBox"
        Me.YEARTextBox.Size = New System.Drawing.Size(100, 20)
        Me.YEARTextBox.TabIndex = 3
        '
        'Total_Number_of_Water_Treatment_PlantsLabel
        '
        Total_Number_of_Water_Treatment_PlantsLabel.AutoSize = True
        Total_Number_of_Water_Treatment_PlantsLabel.Location = New System.Drawing.Point(121, 214)
        Total_Number_of_Water_Treatment_PlantsLabel.Name = "Total_Number_of_Water_Treatment_PlantsLabel"
        Total_Number_of_Water_Treatment_PlantsLabel.Size = New System.Drawing.Size(201, 13)
        Total_Number_of_Water_Treatment_PlantsLabel.TabIndex = 4
        Total_Number_of_Water_Treatment_PlantsLabel.Text = "Total Number of Water Treatment Plants:"
        '
        'Total_Number_of_Water_Treatment_PlantsTextBox
        '
        Me.Total_Number_of_Water_Treatment_PlantsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Total Number of Water Treatment Plants", True))
        Me.Total_Number_of_Water_Treatment_PlantsTextBox.Location = New System.Drawing.Point(444, 211)
        Me.Total_Number_of_Water_Treatment_PlantsTextBox.Name = "Total_Number_of_Water_Treatment_PlantsTextBox"
        Me.Total_Number_of_Water_Treatment_PlantsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Total_Number_of_Water_Treatment_PlantsTextBox.TabIndex = 5
        '
        'Number_of__Water_Treatment_Plants_With_Fluoride_FeedersLabel
        '
        Number_of__Water_Treatment_Plants_With_Fluoride_FeedersLabel.AutoSize = True
        Number_of__Water_Treatment_Plants_With_Fluoride_FeedersLabel.Location = New System.Drawing.Point(121, 240)
        Number_of__Water_Treatment_Plants_With_Fluoride_FeedersLabel.Name = "Number_of__Water_Treatment_Plants_With_Fluoride_FeedersLabel"
        Number_of__Water_Treatment_Plants_With_Fluoride_FeedersLabel.Size = New System.Drawing.Size(283, 13)
        Number_of__Water_Treatment_Plants_With_Fluoride_FeedersLabel.TabIndex = 6
        Number_of__Water_Treatment_Plants_With_Fluoride_FeedersLabel.Text = "Number of  Water Treatment Plants With Fluoride Feeders:"
        '
        'Number_of__Water_Treatment_Plants_With_Fluoride_FeedersTextBox
        '
        Me.Number_of__Water_Treatment_Plants_With_Fluoride_FeedersTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Number of  Water Treatment Plants With Fluoride Feeders", True))
        Me.Number_of__Water_Treatment_Plants_With_Fluoride_FeedersTextBox.Location = New System.Drawing.Point(444, 237)
        Me.Number_of__Water_Treatment_Plants_With_Fluoride_FeedersTextBox.Name = "Number_of__Water_Treatment_Plants_With_Fluoride_FeedersTextBox"
        Me.Number_of__Water_Treatment_Plants_With_Fluoride_FeedersTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Number_of__Water_Treatment_Plants_With_Fluoride_FeedersTextBox.TabIndex = 7
        '
        'Percentage_of__Water_Treatment_Plants_With_Fluoride_FeedersLabel
        '
        Percentage_of__Water_Treatment_Plants_With_Fluoride_FeedersLabel.AutoSize = True
        Percentage_of__Water_Treatment_Plants_With_Fluoride_FeedersLabel.Location = New System.Drawing.Point(121, 266)
        Percentage_of__Water_Treatment_Plants_With_Fluoride_FeedersLabel.Name = "Percentage_of__Water_Treatment_Plants_With_Fluoride_FeedersLabel"
        Percentage_of__Water_Treatment_Plants_With_Fluoride_FeedersLabel.Size = New System.Drawing.Size(301, 13)
        Percentage_of__Water_Treatment_Plants_With_Fluoride_FeedersLabel.TabIndex = 8
        Percentage_of__Water_Treatment_Plants_With_Fluoride_FeedersLabel.Text = "Percentage of  Water Treatment Plants With Fluoride Feeders:"
        '
        'Percentage_of__Water_Treatment_Plants_With_Fluoride_FeedersTextBox
        '
        Me.Percentage_of__Water_Treatment_Plants_With_Fluoride_FeedersTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Percentage of  Water Treatment Plants With Fluoride Feeders", True))
        Me.Percentage_of__Water_Treatment_Plants_With_Fluoride_FeedersTextBox.Location = New System.Drawing.Point(444, 263)
        Me.Percentage_of__Water_Treatment_Plants_With_Fluoride_FeedersTextBox.Name = "Percentage_of__Water_Treatment_Plants_With_Fluoride_FeedersTextBox"
        Me.Percentage_of__Water_Treatment_Plants_With_Fluoride_FeedersTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Percentage_of__Water_Treatment_Plants_With_Fluoride_FeedersTextBox.TabIndex = 9
        '
        'Total_PopulationLabel
        '
        Total_PopulationLabel.AutoSize = True
        Total_PopulationLabel.Location = New System.Drawing.Point(121, 292)
        Total_PopulationLabel.Name = "Total_PopulationLabel"
        Total_PopulationLabel.Size = New System.Drawing.Size(87, 13)
        Total_PopulationLabel.TabIndex = 10
        Total_PopulationLabel.Text = "Total Population:"
        '
        'Total_PopulationTextBox
        '
        Me.Total_PopulationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Total Population", True))
        Me.Total_PopulationTextBox.Location = New System.Drawing.Point(444, 289)
        Me.Total_PopulationTextBox.Name = "Total_PopulationTextBox"
        Me.Total_PopulationTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Total_PopulationTextBox.TabIndex = 11
        '
        'Number_of_Estimated_Population_Receiving_Fluoridated_WaterLabel
        '
        Number_of_Estimated_Population_Receiving_Fluoridated_WaterLabel.AutoSize = True
        Number_of_Estimated_Population_Receiving_Fluoridated_WaterLabel.Location = New System.Drawing.Point(121, 318)
        Number_of_Estimated_Population_Receiving_Fluoridated_WaterLabel.Name = "Number_of_Estimated_Population_Receiving_Fluoridated_WaterLabel"
        Number_of_Estimated_Population_Receiving_Fluoridated_WaterLabel.Size = New System.Drawing.Size(299, 13)
        Number_of_Estimated_Population_Receiving_Fluoridated_WaterLabel.TabIndex = 12
        Number_of_Estimated_Population_Receiving_Fluoridated_WaterLabel.Text = "Number of Estimated Population Receiving Fluoridated Water:"
        '
        'Number_of_Estimated_Population_Receiving_Fluoridated_WaterTextBox
        '
        Me.Number_of_Estimated_Population_Receiving_Fluoridated_WaterTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Number of Estimated Population Receiving Fluoridated Water", True))
        Me.Number_of_Estimated_Population_Receiving_Fluoridated_WaterTextBox.Location = New System.Drawing.Point(444, 315)
        Me.Number_of_Estimated_Population_Receiving_Fluoridated_WaterTextBox.Name = "Number_of_Estimated_Population_Receiving_Fluoridated_WaterTextBox"
        Me.Number_of_Estimated_Population_Receiving_Fluoridated_WaterTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Number_of_Estimated_Population_Receiving_Fluoridated_WaterTextBox.TabIndex = 13
        '
        'Percentage_of_Estimated_Population_Receiving_Fluoridated_WaterLabel
        '
        Percentage_of_Estimated_Population_Receiving_Fluoridated_WaterLabel.AutoSize = True
        Percentage_of_Estimated_Population_Receiving_Fluoridated_WaterLabel.Location = New System.Drawing.Point(121, 344)
        Percentage_of_Estimated_Population_Receiving_Fluoridated_WaterLabel.Name = "Percentage_of_Estimated_Population_Receiving_Fluoridated_WaterLabel"
        Percentage_of_Estimated_Population_Receiving_Fluoridated_WaterLabel.Size = New System.Drawing.Size(317, 13)
        Percentage_of_Estimated_Population_Receiving_Fluoridated_WaterLabel.TabIndex = 14
        Percentage_of_Estimated_Population_Receiving_Fluoridated_WaterLabel.Text = "Percentage of Estimated Population Receiving Fluoridated Water:"
        '
        'Percentage_of_Estimated_Population_Receiving_Fluoridated_WaterTextBox
        '
        Me.Percentage_of_Estimated_Population_Receiving_Fluoridated_WaterTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Percentage of Estimated Population Receiving Fluoridated Water", True))
        Me.Percentage_of_Estimated_Population_Receiving_Fluoridated_WaterTextBox.Location = New System.Drawing.Point(444, 341)
        Me.Percentage_of_Estimated_Population_Receiving_Fluoridated_WaterTextBox.Name = "Percentage_of_Estimated_Population_Receiving_Fluoridated_WaterTextBox"
        Me.Percentage_of_Estimated_Population_Receiving_Fluoridated_WaterTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Percentage_of_Estimated_Population_Receiving_Fluoridated_WaterTextBox.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(610, 46)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "NUMBER OF WATER TREATMENT PLANTS AND POPULATION" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RECEIVING FLUORIDATED WATER SUPP" &
    "LIES, MALAYSIA (1996 - 2017)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(125, 421)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 28
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(297, 421)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 27
        Me.Button5.Text = "Delete"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(469, 421)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 26
        Me.Button6.Text = "Close"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(469, 382)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "Next"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(297, 382)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Add New"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(125, 382)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Previous"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(579, 288)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(156, 69)
        Me.Button7.TabIndex = 29
        Me.Button7.Text = "Graph"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 730)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(YEARLabel)
        Me.Controls.Add(Me.YEARTextBox)
        Me.Controls.Add(Total_Number_of_Water_Treatment_PlantsLabel)
        Me.Controls.Add(Me.Total_Number_of_Water_Treatment_PlantsTextBox)
        Me.Controls.Add(Number_of__Water_Treatment_Plants_With_Fluoride_FeedersLabel)
        Me.Controls.Add(Me.Number_of__Water_Treatment_Plants_With_Fluoride_FeedersTextBox)
        Me.Controls.Add(Percentage_of__Water_Treatment_Plants_With_Fluoride_FeedersLabel)
        Me.Controls.Add(Me.Percentage_of__Water_Treatment_Plants_With_Fluoride_FeedersTextBox)
        Me.Controls.Add(Total_PopulationLabel)
        Me.Controls.Add(Me.Total_PopulationTextBox)
        Me.Controls.Add(Number_of_Estimated_Population_Receiving_Fluoridated_WaterLabel)
        Me.Controls.Add(Me.Number_of_Estimated_Population_Receiving_Fluoridated_WaterTextBox)
        Me.Controls.Add(Percentage_of_Estimated_Population_Receiving_Fluoridated_WaterLabel)
        Me.Controls.Add(Me.Percentage_of_Estimated_Population_Receiving_Fluoridated_WaterTextBox)
        Me.Controls.Add(Me.Table1DataGridView)
        Me.Controls.Add(Me.Table1BindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.WaterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Table1BindingNavigator.ResumeLayout(False)
        Me.Table1BindingNavigator.PerformLayout()
        CType(Me.Table1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WaterDataSet As WaterDataSet
    Friend WithEvents Table1BindingSource As BindingSource
    Friend WithEvents Table1TableAdapter As WaterDataSetTableAdapters.Table1TableAdapter
    Friend WithEvents TableAdapterManager As WaterDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Table1BindingNavigator As BindingNavigator
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
    Friend WithEvents Table1BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Table1DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents YEARTextBox As TextBox
    Friend WithEvents Total_Number_of_Water_Treatment_PlantsTextBox As TextBox
    Friend WithEvents Number_of__Water_Treatment_Plants_With_Fluoride_FeedersTextBox As TextBox
    Friend WithEvents Percentage_of__Water_Treatment_Plants_With_Fluoride_FeedersTextBox As TextBox
    Friend WithEvents Total_PopulationTextBox As TextBox
    Friend WithEvents Number_of_Estimated_Population_Receiving_Fluoridated_WaterTextBox As TextBox
    Friend WithEvents Percentage_of_Estimated_Population_Receiving_Fluoridated_WaterTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button7 As Button
End Class
