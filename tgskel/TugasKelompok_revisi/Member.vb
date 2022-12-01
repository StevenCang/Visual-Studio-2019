Public Class Member

    Private Sub picbtnmaximize_Click_1(sender As Object, e As EventArgs)
        If Me.WindowState = WindowState.Normal Then
            Me.WindowState = WindowState.Maximized
        ElseIf Me.WindowState = WindowState.Maximized Then
            Me.WindowState = WindowState.Normal
        End If
    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click

        If fntxtbox.Text = "" Or lntxtbox.Text = "" Or passtxtbox.Text = "" Or pass1txtbox.Text = "" Or citycbbox.Text = "" Or
            pctxtbox.Text = "" Or pntxtbox.Text = "" Or emailtxtbox.Text = "" Then
            MessageBox.Show("Missing field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            MessageBox.Show("You Are Register", "Member", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim frm1 As New Form1
            frm1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Member_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        citycbbox.Items.Add("Jakarta")
        citycbbox.Items.Add("Bogor")
        citycbbox.Items.Add("Depok")
        citycbbox.Items.Add("Tanggerang")
        citycbbox.Items.Add("Bekasi")
        citycbbox.Items.Add("Semarang")
        citycbbox.Items.Add("PekanBaru")
        citycbbox.Items.Add("Dumai")
        citycbbox.Items.Add("SelatPanjang")
        citycbbox.Items.Add("Jambi")
        citycbbox.Items.Add("Bengkulu")
        citycbbox.Items.Add("Cirebon")
        citycbbox.Items.Add("Sukabumi")
        citycbbox.Items.Add("Medan")
        citycbbox.Items.Add("Yogyakarta")
        citycbbox.Items.Add("Padang")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim wlcm As New welcomepage
        wlcm.Show()
        Me.Close()
    End Sub
End Class