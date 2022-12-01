Public Class Form2
    Private Sub countBtn_Click(sender As Object, e As EventArgs) Handles countBtn.Click
        If meatRadio.Checked Then
            hargaFood = 20000
            TextBox1.Text = TextBox1.Text + meatRadio.Text + " Rp.20000" + vbCrLf
            hargaTambah += hargaFood
        ElseIf boiledRadio.Checked Then
            hargaFood = 15000
            TextBox1.Text = TextBox1.Text + boiledRadio.Text + " Rp.15000" + vbCrLf
            hargaTambah += hargaFood
        ElseIf noodleRadio.Checked Then
            hargaFood = 18000
            TextBox1.Text = TextBox1.Text + noodleRadio.Text + " Rp.18000" + vbCrLf
            hargaTambah += hargaFood
        ElseIf riceRadio.Checked Then
            hargaFood = 12000
            TextBox1.Text = TextBox1.Text + riceRadio.Text + " Rp.12000" + vbCrLf
            hargaTambah += hargaFood
        ElseIf seafoodRadio.Checked Then
            hargaFood = 13000
            TextBox1.Text = TextBox1.Text + seafoodRadio.Text + " Rp.13000" + vbCrLf
            hargaTambah += hargaFood
        End If

        If coffeeRadio.Checked Then
            hargaDrink = 5000
            TextBox1.Text = TextBox1.Text + coffeeRadio.Text + " Rp.5000" + vbCrLf
            hargaTambah += hargaDrink
        ElseIf milkshakeRadio.Checked Then
            hargaDrink = 4000
            TextBox1.Text = TextBox1.Text + milkshakeRadio.Text + " Rp.4000" + vbCrLf
            hargaTambah += hargaDrink
        ElseIf juiceRadio.Checked Then
            hargaDrink = 6000
            TextBox1.Text = TextBox1.Text + juiceRadio.Text + " Rp.6000" + vbCrLf
            hargaTambah += hargaDrink
        ElseIf teaRadio.Checked Then
            hargaDrink = 5000
            TextBox1.Text = TextBox1.Text + teaRadio.Text + " Rp.5000" + vbCrLf
            hargaTambah += hargaDrink
        ElseIf softdrinkRadio.Checked Then
            hargaDrink = 7000
            TextBox1.Text = TextBox1.Text + softdrinkRadio.Text + " Rp.7000" + vbCrLf
            hargaTambah += hargaDrink
        End If


        If puddingRadio.Checked Then
            hargaDessert = 8000
            TextBox1.Text = TextBox1.Text + puddingRadio.Text + " Rp.8000" + vbCrLf
            hargaTambah += hargaDessert
        ElseIf cakeRadio.Checked Then
            hargaDessert = 4000
            TextBox1.Text = TextBox1.Text + cakeRadio.Text + " Rp.4000" + vbCrLf
            hargaTambah += hargaDessert
        ElseIf icecreamRadio.Checked Then
            hargaDessert = 6000
            TextBox1.Text = TextBox1.Text + icecreamRadio.Text + " Rp.6000" + vbCrLf
            hargaTambah += hargaDessert
        End If

        If chocolateRadio.Checked Then
            hargaSnack = 4500
            TextBox1.Text = TextBox1.Text + chocolateRadio.Text + " Rp.4500" + vbCrLf
            hargaTambah += hargaSnack
        ElseIf candyRadio.Checked Then
            hargaSnack = 3000
            TextBox1.Text = TextBox1.Text + candyRadio.Text + " Rp.3000" + vbCrLf
            hargaTambah += hargaSnack
        ElseIf chipRadio.Checked Then
            hargaSnack = 3500
            TextBox1.Text = TextBox1.Text + chipRadio.Text + " Rp.3500" + vbCrLf
            hargaTambah += hargaSnack
        End If


        total = hargaFood + hargaDrink + hargaDessert + hargaSnack

        If bayarTxtbox.Text = "" Then
            MessageBox.Show("Masukan Uang Anda")
            totalLabel.Text = total
            kembalianLabel.Text = "--"

        End If
    End Sub

    Private Sub picbtnminimize_Click(sender As Object, e As EventArgs) Handles picbtnminimize.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub picbtnmaximize_Click(sender As Object, e As EventArgs) Handles picbtnmaximize.Click
        If Me.WindowState = WindowState.Normal Then
            Me.WindowState = WindowState.Maximized
        ElseIf Me.WindowState = WindowState.Maximized Then
            Me.WindowState = WindowState.Normal
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim kembalian As Integer
        kembalian = Val(bayarTxtbox.Text) - total
        kembalianLabel.Text = kembalian
        totalLabel.Text = total
    End Sub

    Private Sub picbtnclose_Click(sender As Object, e As EventArgs) Handles picbtnclose.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm1 As New Form1
        frm1.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("You Are Log Out", "Byeee", MessageBoxButtons.OK)
        Dim wlcm As New welcomepage
        wlcm.Show()
        Me.Close()
    End Sub
End Class