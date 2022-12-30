Public Class clientes

    Private Sub CLIENTESBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLIENTESBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CLIENTESBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1___copiaDataSet)

    End Sub

    Private Sub clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DefinitivaDataSet.CLIENTES' Puede moverla o quitarla según sea necesario.
        Me.CLIENTESTableAdapter1.Fill(Me.DefinitivaDataSet.CLIENTES)
        'TODO: esta línea de código carga datos en la tabla '_PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1___copiaDataSet.CLIENTES' Puede moverla o quitarla según sea necesario.
        Me.CLIENTESTableAdapter.Fill(Me._PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1___copiaDataSet.CLIENTES)

    End Sub
End Class