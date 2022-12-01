Public Class welcomepage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "StevenCang" And TextBox2.Text = "123" Then
            MessageBox.Show("You Are Login", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim form1 As New Form1
            form1.Show()
            Me.Close()
        ElseIf TextBox1.Text = "YuliaLim" And TextBox2.Text = "123" Then
            MessageBox.Show("You Are Login", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim form1 As New Form1
            form1.Show()
            Me.Close()
        ElseIf TextBox1.Text = "WilsonVitori" And TextBox2.Text = "123" Then
            MessageBox.Show("You Are Login", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim form1 As New Form1
            form1.Show()
            Me.Close()
        Else
            MessageBox.Show("Username/Password Wrong!")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim member As New Member
        member.Show()
        Me.Close()
    End Sub
End Class