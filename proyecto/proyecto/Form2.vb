Public Class BASEDEDATOS

    Shared Sub Swow()
        Throw New NotImplementedException
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1___copiaDataSet.PRODUCTOS' Puede moverla o quitarla según sea necesario.
        Me.PRODUCTOSTableAdapter1.Fill(Me._PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1___copiaDataSet.PRODUCTOS)
        'TODO: esta línea de código carga datos en la tabla '_PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1___copiaDataSet.PRODUCTOS' Puede moverla o quitarla según sea necesario.
        Me.PRODUCTOSTableAdapter1.Fill(Me._PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1___copiaDataSet.PRODUCTOS)
        'TODO: esta línea de código carga datos en la tabla 'PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1DataSet.PRODUCTOS' Puede moverla o quitarla según sea necesario.
        Me.PRODUCTOSTableAdapter.Fill(Me.PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1DataSet.PRODUCTOS)

    End Sub

    Private Sub PRODUCTOSBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRODUCTOSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PRODUCTOSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PROYECTO_BASE_DE_DATOS_X_PROGRAMACION1DataSet)

    End Sub

    Private Sub PRODUCTOSDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub
End Class