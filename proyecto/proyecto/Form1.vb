Public Class Form1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox3.Text = TextBox2.Text Then

            My.Settings.Usuario = TextBox1.Text
            My.Settings.Save()
            My.Settings.Reload()



            My.Settings.Clave = TextBox2.Text
            My.Settings.Save()
            My.Settings.Reload()
            Label4.Visible = False

            Label5.Visible = True

        Else

            Label4.Visible = True

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox4.Text = My.Settings.usuario And TextBox5.Text = My.Settings.clave Then


            Me.Visible = False
            principal.Visible = True


        Else
            Label10.Visible = True
        End If


    End Sub

    Private Sub mide()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
