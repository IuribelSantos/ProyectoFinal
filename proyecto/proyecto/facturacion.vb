Public Class facturacion
    Sub producto()
        Txtcodigo.Text = "1"
        txtnombre.Text = "television"
        txtdescripcion.Text = "LG Smart tv 32"
        txtpreciounitario.Text = "17000"


    End Sub
    Sub producto1()
        Txtcodigo.Text = "2"
        txtnombre.Text = "jueo de mesa"
        txtdescripcion.Text = "caonabe Roble oscuro"
        txtpreciounitario.Text = "12000"
    End Sub


    Sub producto2()
        Txtcodigo.Text = "3"
        txtnombre.Text = "inversor"
        txtdescripcion.Text = " last power xx2300"
        txtpreciounitario.Text = "7000"
    End Sub
    Sub producto3()
        Txtcodigo.Text = "4"
        txtnombre.Text = "television"
        txtdescripcion.Text = "samsung smart tv 32"
        txtpreciounitario.Text = "27000"
    End Sub
    Sub producto4()
        Txtcodigo.Text = "5"
        txtnombre.Text = "lavadora"
        txtdescripcion.Text = " dawaio lcd 20 l"
        txtpreciounitario.Text = "8000"

    End Sub
    Sub producto5()
        Txtcodigo.Text = "6"
        txtnombre.Text = "estufa"
        txtdescripcion.Text = " mabe t3000"
        txtpreciounitario.Text = "12500"
    End Sub
    Sub producto6()
        Txtcodigo.Text = "7"
        txtnombre.Text = "television"
        txtdescripcion.Text = " panasonic smart tv 42 4K"
        txtpreciounitario.Text = "67000"
    End Sub
    Sub producto7()
        Txtcodigo.Text = "8"
        txtnombre.Text = "television"
        txtdescripcion.Text = " sonic UHD 55"
        txtpreciounitario.Text = "54000"
    End Sub
    Sub producto8()
        Txtcodigo.Text = "9"
        txtnombre.Text = "nevera"
        txtdescripcion.Text = " LG uh 200"
        txtpreciounitario.Text = "14000"
    End Sub
    Sub producto9()
        Txtcodigo.Text = "10"
        txtnombre.Text = "lavadora"
        txtdescripcion.Text = " celtan kn 8000 12L"
        txtpreciounitario.Text = "12700"
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If Txtcodigo.Text = "1" Then
            Call producto()
            txtcantidad.Focus()
        ElseIf Txtcodigo.Text = "2" Then
            Call producto1()
            txtcantidad.Focus()
        ElseIf Txtcodigo.Text = "3" Then
            Call producto2()
            txtcantidad.Focus()
        ElseIf Txtcodigo.Text = "4" Then
            Call producto3()
            txtcantidad.Focus()
        ElseIf Txtcodigo.Text = "5" Then
            Call producto4()
            txtcantidad.Focus()
        ElseIf Txtcodigo.Text = "6" Then
            Call producto5()
            txtcantidad.Focus()
        ElseIf Txtcodigo.Text = "7" Then
            Call producto6()
            txtcantidad.Focus()
        ElseIf Txtcodigo.Text = "8" Then
            Call producto7()
            txtcantidad.Focus()
        ElseIf Txtcodigo.Text = "9" Then
            Call producto8()
            txtcantidad.Focus()
        ElseIf Txtcodigo.Text = "10" Then
            Call producto9()
            txtcantidad.Focus()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        txtsubtotal.Text = (txtcantidad.Text) * (txtpreciounitario.Text)
        DataGridView1.Rows.Add(Txtcodigo.Text, txtnombre.Text, txtdescripcion.Text, txtpreciounitario.Text, txtcantidad.Text, txtsubtotal.Text)
        Dim total As Double = 0
        Dim fila As DataGridViewRow = New DataGridViewRow()
        For Each fila In DataGridView1.Rows
            total += Convert.ToDouble(fila.Cells("Column6").Value)
        Next
        TextBox1.Text = Convert.ToString(total)
    End Sub

    Private Sub limpiarcampos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles limpiarcampos.Click
        Txtcodigo.Clear()
        txtnombre.Clear()
        txtdescripcion.Clear()
        txtcantidad.Clear()
        txtpreciounitario.Clear()
        txttotal.Clear()
        txtsubtotal.Clear()
        txtiva.Clear()
        TextBox1.Clear()
        Txtcodigo.Focus()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        txtiva.Text = (CDbl(TextBox1.Text) * 12 / 100)
        txttotal.Text = (CDbl(TextBox1.Text) + (txtiva.Text))
    End Sub

    Private Sub hora_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hora.Tick
        Label12.Text = TimeOfDay
        Label15.Text = DateString
    End Sub

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.Click

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.Print()
        End If



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ficha.Text = vbCrLf & "STSMElecro Muebles Valdez o zeen dominica" & vbCrLf &
            vbCrLf & "Venta de Inversores y Electrdomesticos santo domingo" & vbCrLf &
            vbCrLf & "Villa Tropicalia, Santo Domingo Este." & vbCrLf &
            vbCrLf & "Tel.:(809) 695-1735" & vbCrLf &
            vbCrLf & "FT CONSUMIDOR FINAL" & vbCrLf &
            vbCrLf & "Fecha.:" & Label15.Text & vbCrLf & Label12.Text &
            vbCrLf & "NOMBRE DE CLIENTE : " & TextBox2.Text & vbCrLf &
            vbCrLf & "CEDULA : " & TextBox3.Text & vbCrLf &
            vbCrLf & "DIRECCION: " & TextBox4.Text & vbCrLf &
            vbCrLf & "TELEFONO: " & TextBox5.Text & vbCrLf &
            vbCrLf & "VENDEDOR: " & TextBox6.Text & vbCrLf & vbCrLf &
            vbCrLf & "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ " & vbCrLf & vbCrLf &
            vbCrLf & "Cantidad       Precio      Importe" & vbCrLf &
            vbCrLf & "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ " & vbCrLf & vbCrLf &
            vbCrLf & txtdescripcion.Text & vbCrLf &
            vbCrLf & txtcantidad.Text & vbCr & txtpreciounitario.Text & vbCr & txtiva.Text & vbCrLf &
            vbCrLf & "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ " & vbCrLf & vbCrLf &
            vbCrLf & "Sub Total : " & txtsubtotal.Text & vbCrLf &
            vbCrLf & "Impuestos : " & txtiva.Text & vbCrLf &
            vbCrLf & "Total : " & txttotal.Text & vbCrLf & vbCrLf &
            vbCrLf & "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ " & vbCrLf & vbCrLf &
            vbCrLf & vbCrLf & vbCrLf & "                         FIRMA" & vbCrLf





    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim LAPIZ As New SolidBrush(ficha.ForeColor)
        Dim AREA_IMPRESION As Graphics = e.Graphics
        AREA_IMPRESION.DrawString(ficha.Text, ficha.Font, LAPIZ, 0, 0)
    End Sub

    Private Sub facturacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
