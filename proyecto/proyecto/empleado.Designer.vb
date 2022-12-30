<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class empleado
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(empleado))
        Me._PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1___copiaDataSet = New proyecto._PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1___copiaDataSet()
        Me.PERSONALBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PERSONALTableAdapter = New proyecto._PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1___copiaDataSetTableAdapters.PERSONALTableAdapter()
        Me.TableAdapterManager = New proyecto._PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1___copiaDataSetTableAdapters.TableAdapterManager()
        Me.PERSONALBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PERSONALBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PERSONALDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PERSONALBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DefinitivaDataSet1 = New proyecto.definitivaDataSet1()
        Me.PERSONALTableAdapter1 = New proyecto.definitivaDataSet1TableAdapters.PERSONALTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me._PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1___copiaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PERSONALBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PERSONALBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PERSONALBindingNavigator.SuspendLayout()
        CType(Me.PERSONALDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PERSONALBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DefinitivaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1___copiaDataSet
        '
        Me._PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1___copiaDataSet.DataSetName = "_PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1___copiaDataSet"
        Me._PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1___copiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PERSONALBindingSource
        '
        Me.PERSONALBindingSource.DataMember = "PERSONAL"
        Me.PERSONALBindingSource.DataSource = Me._PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1___copiaDataSet
        '
        'PERSONALTableAdapter
        '
        Me.PERSONALTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CLIENTESTableAdapter = Nothing
        Me.TableAdapterManager.PERSONALTableAdapter = Me.PERSONALTableAdapter
        Me.TableAdapterManager.PRODUCTOSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = proyecto._PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1___copiaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PERSONALBindingNavigator
        '
        Me.PERSONALBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PERSONALBindingNavigator.BindingSource = Me.PERSONALBindingSource
        Me.PERSONALBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PERSONALBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PERSONALBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PERSONALBindingNavigatorSaveItem})
        Me.PERSONALBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PERSONALBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PERSONALBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PERSONALBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PERSONALBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PERSONALBindingNavigator.Name = "PERSONALBindingNavigator"
        Me.PERSONALBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PERSONALBindingNavigator.Size = New System.Drawing.Size(736, 25)
        Me.PERSONALBindingNavigator.TabIndex = 0
        Me.PERSONALBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
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
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'PERSONALBindingNavigatorSaveItem
        '
        Me.PERSONALBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PERSONALBindingNavigatorSaveItem.Image = CType(resources.GetObject("PERSONALBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PERSONALBindingNavigatorSaveItem.Name = "PERSONALBindingNavigatorSaveItem"
        Me.PERSONALBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PERSONALBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'PERSONALDataGridView
        '
        Me.PERSONALDataGridView.AutoGenerateColumns = False
        Me.PERSONALDataGridView.BackgroundColor = System.Drawing.Color.BurlyWood
        Me.PERSONALDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PERSONALDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PERSONALDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.PERSONALDataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PERSONALDataGridView.DataSource = Me.PERSONALBindingSource1
        Me.PERSONALDataGridView.Location = New System.Drawing.Point(0, 86)
        Me.PERSONALDataGridView.Name = "PERSONALDataGridView"
        Me.PERSONALDataGridView.Size = New System.Drawing.Size(736, 308)
        Me.PERSONALDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Apellido"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Apellido"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Edad"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Edad"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Nacionalidad"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Nacionalidad"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Cargo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cargo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Cedula"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Cedula"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Direccion"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Direccion"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'PERSONALBindingSource1
        '
        Me.PERSONALBindingSource1.DataMember = "PERSONAL"
        Me.PERSONALBindingSource1.DataSource = Me.DefinitivaDataSet1
        '
        'DefinitivaDataSet1
        '
        Me.DefinitivaDataSet1.DataSetName = "definitivaDataSet1"
        Me.DefinitivaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PERSONALTableAdapter1
        '
        Me.PERSONALTableAdapter1.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(365, 35)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Base De Datos Empleados"
        '
        'empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackgroundImage = Global.proyecto.My.Resources.Resources.color_degradado_fondos_degradados_multicolor_51200_1500x938
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(736, 393)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PERSONALDataGridView)
        Me.Controls.Add(Me.PERSONALBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "empleado"
        Me.Text = "EMPLEADOS"
        CType(Me._PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1___copiaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PERSONALBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PERSONALBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PERSONALBindingNavigator.ResumeLayout(False)
        Me.PERSONALBindingNavigator.PerformLayout()
        CType(Me.PERSONALDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PERSONALBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DefinitivaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1___copiaDataSet As proyecto._PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1___copiaDataSet
    Friend WithEvents PERSONALBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PERSONALTableAdapter As proyecto._PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1___copiaDataSetTableAdapters.PERSONALTableAdapter
    Friend WithEvents TableAdapterManager As proyecto._PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1___copiaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PERSONALBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PERSONALBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PERSONALDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DefinitivaDataSet1 As proyecto.definitivaDataSet1
    Friend WithEvents PERSONALBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PERSONALTableAdapter1 As proyecto.definitivaDataSet1TableAdapters.PERSONALTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
