<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim Device_NameLabel As System.Windows.Forms.Label
        Dim ModelLabel As System.Windows.Forms.Label
        Dim ProcessorLabel As System.Windows.Forms.Label
        Dim RamLabel As System.Windows.Forms.Label
        Dim GPULabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim ManufactureLabel1 As System.Windows.Forms.Label
        Me.TRIAssets = New TRI_Assets.TRIAssets()
        Me.AssetTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AssetTableTableAdapter = New TRI_Assets.TRIAssetsTableAdapters.AssetTableTableAdapter()
        Me.TableAdapterManager = New TRI_Assets.TRIAssetsTableAdapters.TableAdapterManager()
        Me.AssetTableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AssetTableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Device_NameTextBox = New System.Windows.Forms.TextBox()
        Me.ModelTextBox = New System.Windows.Forms.TextBox()
        Me.ProcessorListBox = New System.Windows.Forms.ListBox()
        Me.RamListBox = New System.Windows.Forms.ListBox()
        Me.GPUTextBox = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnNEW = New System.Windows.Forms.Button()
        Me.ManufactureComboBox = New System.Windows.Forms.ComboBox()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        Device_NameLabel = New System.Windows.Forms.Label()
        ModelLabel = New System.Windows.Forms.Label()
        ProcessorLabel = New System.Windows.Forms.Label()
        RamLabel = New System.Windows.Forms.Label()
        GPULabel = New System.Windows.Forms.Label()
        ManufactureLabel1 = New System.Windows.Forms.Label()
        CType(Me.TRIAssets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssetTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssetTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AssetTableBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_NameLabel.Location = New System.Drawing.Point(12, 129)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(89, 21)
        First_NameLabel.TabIndex = 3
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_NameLabel.Location = New System.Drawing.Point(14, 163)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(87, 21)
        Last_NameLabel.TabIndex = 5
        Last_NameLabel.Text = "Last Name:"
        '
        'Device_NameLabel
        '
        Device_NameLabel.AutoSize = True
        Device_NameLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Device_NameLabel.Location = New System.Drawing.Point(-4, 199)
        Device_NameLabel.Name = "Device_NameLabel"
        Device_NameLabel.Size = New System.Drawing.Size(105, 21)
        Device_NameLabel.TabIndex = 7
        Device_NameLabel.Text = "Device Name:"
        '
        'ModelLabel
        '
        ModelLabel.AutoSize = True
        ModelLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ModelLabel.Location = New System.Drawing.Point(320, 121)
        ModelLabel.Name = "ModelLabel"
        ModelLabel.Size = New System.Drawing.Size(57, 21)
        ModelLabel.TabIndex = 11
        ModelLabel.Text = "Model:"
        '
        'ProcessorLabel
        '
        ProcessorLabel.AutoSize = True
        ProcessorLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProcessorLabel.Location = New System.Drawing.Point(296, 160)
        ProcessorLabel.Name = "ProcessorLabel"
        ProcessorLabel.Size = New System.Drawing.Size(81, 21)
        ProcessorLabel.TabIndex = 13
        ProcessorLabel.Text = "Processor:"
        '
        'RamLabel
        '
        RamLabel.AutoSize = True
        RamLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RamLabel.Location = New System.Drawing.Point(332, 238)
        RamLabel.Name = "RamLabel"
        RamLabel.Size = New System.Drawing.Size(45, 21)
        RamLabel.TabIndex = 15
        RamLabel.Text = "Ram:"
        '
        'GPULabel
        '
        GPULabel.AutoSize = True
        GPULabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GPULabel.Location = New System.Drawing.Point(333, 298)
        GPULabel.Name = "GPULabel"
        GPULabel.Size = New System.Drawing.Size(44, 21)
        GPULabel.TabIndex = 17
        GPULabel.Text = "GPU:"
        '
        'TRIAssets
        '
        Me.TRIAssets.DataSetName = "TRIAssets"
        Me.TRIAssets.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AssetTableBindingSource
        '
        Me.AssetTableBindingSource.DataMember = "AssetTable"
        Me.AssetTableBindingSource.DataSource = Me.TRIAssets
        '
        'AssetTableTableAdapter
        '
        Me.AssetTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AssetTableTableAdapter = Me.AssetTableTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = TRI_Assets.TRIAssetsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AssetTableBindingNavigator
        '
        Me.AssetTableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AssetTableBindingNavigator.BindingSource = Me.AssetTableBindingSource
        Me.AssetTableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AssetTableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AssetTableBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.AssetTableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AssetTableBindingNavigatorSaveItem})
        Me.AssetTableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AssetTableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AssetTableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AssetTableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AssetTableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AssetTableBindingNavigator.Name = "AssetTableBindingNavigator"
        Me.AssetTableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AssetTableBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.AssetTableBindingNavigator.TabIndex = 0
        Me.AssetTableBindingNavigator.Text = "BindingNavigator1"
        Me.AssetTableBindingNavigator.Visible = False
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'AssetTableBindingNavigatorSaveItem
        '
        Me.AssetTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AssetTableBindingNavigatorSaveItem.Image = CType(resources.GetObject("AssetTableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AssetTableBindingNavigatorSaveItem.Name = "AssetTableBindingNavigatorSaveItem"
        Me.AssetTableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AssetTableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssetTableBindingSource, "First Name", True))
        Me.First_NameTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First_NameTextBox.Location = New System.Drawing.Point(107, 129)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(120, 29)
        Me.First_NameTextBox.TabIndex = 4
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssetTableBindingSource, "Last Name", True))
        Me.Last_NameTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(107, 164)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(120, 29)
        Me.Last_NameTextBox.TabIndex = 6
        '
        'Device_NameTextBox
        '
        Me.Device_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssetTableBindingSource, "Device Name", True))
        Me.Device_NameTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Device_NameTextBox.Location = New System.Drawing.Point(107, 199)
        Me.Device_NameTextBox.Name = "Device_NameTextBox"
        Me.Device_NameTextBox.Size = New System.Drawing.Size(120, 29)
        Me.Device_NameTextBox.TabIndex = 8
        '
        'ModelTextBox
        '
        Me.ModelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssetTableBindingSource, "Model", True))
        Me.ModelTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModelTextBox.Location = New System.Drawing.Point(383, 121)
        Me.ModelTextBox.Name = "ModelTextBox"
        Me.ModelTextBox.Size = New System.Drawing.Size(120, 29)
        Me.ModelTextBox.TabIndex = 12
        '
        'ProcessorListBox
        '
        Me.ProcessorListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AssetTableBindingSource, "Processor", True))
        Me.ProcessorListBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProcessorListBox.FormattingEnabled = True
        Me.ProcessorListBox.ItemHeight = 21
        Me.ProcessorListBox.Items.AddRange(New Object() {"I5 6700", "I7 7700", "N/A"})
        Me.ProcessorListBox.Location = New System.Drawing.Point(383, 163)
        Me.ProcessorListBox.Name = "ProcessorListBox"
        Me.ProcessorListBox.Size = New System.Drawing.Size(120, 46)
        Me.ProcessorListBox.TabIndex = 14
        '
        'RamListBox
        '
        Me.RamListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AssetTableBindingSource, "Ram", True))
        Me.RamListBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RamListBox.FormattingEnabled = True
        Me.RamListBox.ItemHeight = 21
        Me.RamListBox.Items.AddRange(New Object() {"2GB", "4GB", "6GB", "8GB", "12GB", "16GB", "20GB", "24GB", "32GB", "N/A"})
        Me.RamListBox.Location = New System.Drawing.Point(383, 230)
        Me.RamListBox.Name = "RamListBox"
        Me.RamListBox.Size = New System.Drawing.Size(120, 46)
        Me.RamListBox.TabIndex = 16
        '
        'GPUTextBox
        '
        Me.GPUTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssetTableBindingSource, "GPU", True))
        Me.GPUTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GPUTextBox.Location = New System.Drawing.Point(383, 298)
        Me.GPUTextBox.Name = "GPUTextBox"
        Me.GPUTextBox.Size = New System.Drawing.Size(120, 29)
        Me.GPUTextBox.TabIndex = 18
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(383, 361)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(101, 52)
        Me.btnAdd.TabIndex = 19
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(107, 361)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(101, 52)
        Me.btnDelete.TabIndex = 20
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnNEW
        '
        Me.btnNEW.Location = New System.Drawing.Point(29, 24)
        Me.btnNEW.Name = "btnNEW"
        Me.btnNEW.Size = New System.Drawing.Size(101, 52)
        Me.btnNEW.TabIndex = 21
        Me.btnNEW.Text = "NEW"
        Me.btnNEW.UseVisualStyleBackColor = True
        '
        'ManufactureLabel1
        '
        ManufactureLabel1.AutoSize = True
        ManufactureLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ManufactureLabel1.Location = New System.Drawing.Point(0, 255)
        ManufactureLabel1.Name = "ManufactureLabel1"
        ManufactureLabel1.Size = New System.Drawing.Size(101, 21)
        ManufactureLabel1.TabIndex = 21
        ManufactureLabel1.Text = "Manufacture:"
        '
        'ManufactureComboBox
        '
        Me.ManufactureComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AssetTableBindingSource, "Manufacture", True))
        Me.ManufactureComboBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManufactureComboBox.FormattingEnabled = True
        Me.ManufactureComboBox.Items.AddRange(New Object() {"Lenovo", "HP"})
        Me.ManufactureComboBox.Location = New System.Drawing.Point(107, 255)
        Me.ManufactureComboBox.Name = "ManufactureComboBox"
        Me.ManufactureComboBox.Size = New System.Drawing.Size(121, 29)
        Me.ManufactureComboBox.TabIndex = 22
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 584)
        Me.Controls.Add(ManufactureLabel1)
        Me.Controls.Add(Me.ManufactureComboBox)
        Me.Controls.Add(Me.btnNEW)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(Device_NameLabel)
        Me.Controls.Add(Me.Device_NameTextBox)
        Me.Controls.Add(ModelLabel)
        Me.Controls.Add(Me.ModelTextBox)
        Me.Controls.Add(ProcessorLabel)
        Me.Controls.Add(Me.ProcessorListBox)
        Me.Controls.Add(RamLabel)
        Me.Controls.Add(Me.RamListBox)
        Me.Controls.Add(GPULabel)
        Me.Controls.Add(Me.GPUTextBox)
        Me.Controls.Add(Me.AssetTableBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.TRIAssets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssetTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssetTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AssetTableBindingNavigator.ResumeLayout(False)
        Me.AssetTableBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TRIAssets As TRIAssets
    Friend WithEvents AssetTableBindingSource As BindingSource
    Friend WithEvents AssetTableTableAdapter As TRIAssetsTableAdapters.AssetTableTableAdapter
    Friend WithEvents TableAdapterManager As TRIAssetsTableAdapters.TableAdapterManager
    Friend WithEvents AssetTableBindingNavigator As BindingNavigator
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
    Friend WithEvents AssetTableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents Device_NameTextBox As TextBox
    Friend WithEvents ModelTextBox As TextBox
    Friend WithEvents ProcessorListBox As ListBox
    Friend WithEvents RamListBox As ListBox
    Friend WithEvents GPUTextBox As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnNEW As Button
    Friend WithEvents ManufactureComboBox As ComboBox
End Class
