Public Class frmConfig
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pbClient.Click
        MsgBox("Hello World")

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles pbInvoice.Click

    End Sub

    Private Sub frmConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles pbOrder.Click

    End Sub

    Private Sub pbClient_MouseHover(sender As Object, e As EventArgs) Handles pbClient.MouseHover
        pbClient.Image = Proton.My.Resources.clients2
    End Sub
End Class