Public Class Form1
    Private Sub foodbtn_Click(sender As Object, e As EventArgs) Handles foodbtn.Click
        pnlposition.Height = foodbtn.Height
        pnlposition.Top = foodbtn.Top
        foods.Visible = True
        drinks.Visible = False
        desserts.Visible = False
        snacks.Visible = False

    End Sub

    Private Sub drinkbtn_Click(sender As Object, e As EventArgs) Handles drinkbtn.Click
        pnlposition.Height = drinkbtn.Height
        pnlposition.Top = drinkbtn.Top
        foods.Visible = False
        drinks.Visible = True
        desserts.Visible = False
        snacks.Visible = False

    End Sub

    Private Sub dessertbtn_Click(sender As Object, e As EventArgs) Handles dessertbtn.Click
        pnlposition.Height = dessertbtn.Height
        pnlposition.Top = dessertbtn.Top
        foods.Visible = False
        drinks.Visible = False
        desserts.Visible = True
        snacks.Visible = False

    End Sub

    Private Sub snacksbtn_Click(sender As Object, e As EventArgs) Handles snacksbtn.Click
        pnlposition.Height = snacksbtn.Height
        pnlposition.Top = snacksbtn.Top
        foods.Visible = False
        drinks.Visible = False
        desserts.Visible = False
        snacks.Visible = True
    End Sub

    Private Sub picbtnclose_Click(sender As Object, e As EventArgs) Handles picbtnclose.Click
        Me.Close()
    End Sub

    Private Sub Nextbtn_Click(sender As Object, e As EventArgs) Handles Nextbtn.Click
        Dim nextbtn As New Form2
        nextbtn.Show()
        Me.Close()
    End Sub
End Class
