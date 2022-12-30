Public Class informacion

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RichTextBox2.Visible = False And Button2.Visible = False Then
            RichTextBox2.Visible = True
            Button2.Visible = True
       
        Else
            RichTextBox2.Visible = False
            Button2.Visible = False


        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If RichTextBox2.Visible = True And Button2.Visible = True Then
            RichTextBox2.Visible = False
            Button2.Visible = False

        Else
            RichTextBox2.Visible = True
            Button2.Visible = True
        End If

    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class