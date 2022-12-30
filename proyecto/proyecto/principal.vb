Public Class principal

    Private Sub Panel2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel2.MouseHover
        Panel2.Size = New Size(140, 104)

    End Sub

    Private Sub Panel2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel2.MouseLeave
        Panel2.Size = New Size(137, 101)
    End Sub

    Private Sub Panel3_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel3.MouseHover
        Panel3.Size = New Size(140, 104)
    End Sub

    Private Sub Panel3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel3.MouseLeave
        Panel3.Size = New Size(137, 101)
    End Sub

    Private Sub Panel5_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel5.MouseHover
        Panel5.Size = New Size(140, 104)
    End Sub

    Private Sub Panel5_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel5.MouseLeave
        Panel5.Size = New Size(137, 101)
    End Sub

    Private Sub Panel3_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseClick
        Dim BASEDEDATO As New BASEDEDATOS
        BASEDEDATO.MdiParent = Me
        If BASEDEDATO.Visible = True Then
            BASEDEDATO.Visible = False
        Else
            BASEDEDATO.Visible = True
        End If


        BASEDEDATO.Show()



    End Sub

    Private Function splitcontainer1() As Object
        Throw New NotImplementedException
    End Function

    Private Sub Panel2_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseClick
        Dim FACTURA As New facturacion
        FACTURA.MdiParent = Me
        If FACTURA.Visible = True Then
            FACTURA.Visible = False
        Else
            FACTURA.Visible = True
        End If


        FACTURA.Show()
    End Sub

    Private Sub Panel4_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel4.MouseHover
        Panel4.Size = New Size(140, 104)
    End Sub

    Private Sub Panel4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel4.MouseLeave
        Panel4.Size = New Size(137, 101)
    End Sub

    Private Sub Panel4_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel4.MouseClick
        Dim CLIENTE As New clientes
        CLIENTE.MdiParent = Me
        If CLIENTE.Visible = True Then
            CLIENTE.Visible = False
        Else
            CLIENTE.Visible = True
        End If
    End Sub

    Private Sub Panel6_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel6.MouseHover
        Panel6.Size = New Size(140, 104)
    End Sub

    Private Sub Panel6_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel6.MouseLeave
        Panel6.Size = New Size(137, 101)
    End Sub

    Private Sub Panel6_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel6.MouseClick
        Dim EMPLEADO As New empleado
        EMPLEADO.MdiParent = Me
        If EMPLEADO.Visible = True Then
            EMPLEADO.Visible = False
        Else
            EMPLEADO.Visible = True
           
        End If

    End Sub

    Private Sub Panel6_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub





   

   

    Private Sub Panel5_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel5.MouseClick
        Dim INFORMACION As New informacion
        INFORMACION.MdiParent = Me
        If INFORMACION.Visible = True Then
            INFORMACION.Visible = False
        Else
            INFORMACION.Visible = True

        End If
    End Sub
End Class