Public Class empleado
   

    Private Sub PERSONALBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PERSONALBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PERSONALBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1___copiaDataSet)

    End Sub

    Private Sub empleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DefinitivaDataSet1.PERSONAL' Puede moverla o quitarla según sea necesario.
        Me.PERSONALTableAdapter1.Fill(Me.DefinitivaDataSet1.PERSONAL)
        'TODO: esta línea de código carga datos en la tabla '_PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1___copiaDataSet.PERSONAL' Puede moverla o quitarla según sea necesario.
        Me.PERSONALTableAdapter.Fill(Me._PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1___copiaDataSet.PERSONAL)

    End Sub

  
End Class