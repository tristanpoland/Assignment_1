Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Blue
        BtnBlue.Visible = False
        BtnRed.Visible = True
        Me.Width = 350
        BtnGrow.Visible = True
        BtnShrink.Visible = False
    End Sub

    Private Sub BtnRed_Click(sender As Object, e As EventArgs) Handles BtnRed.Click
        Me.BackColor = Color.Red
        BtnBlue.Visible = True
        BtnRed.Visible = False
    End Sub

    Private Sub BtnBlue_Click(sender As Object, e As EventArgs) Handles BtnBlue.Click
        Me.BackColor = Color.Blue
        BtnBlue.Visible = False
        BtnRed.Visible = True
    End Sub

    Private Sub BtnShrink_Click(sender As Object, e As EventArgs) Handles BtnShrink.Click
        Me.Width = 350
        BtnGrow.Visible = True
        BtnShrink.Visible = False
    End Sub

    Private Sub BtnGrow_Click(sender As Object, e As EventArgs) Handles BtnGrow.Click
        Me.Width = 600
        BtnGrow.Visible = False
        BtnShrink.Visible = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LblTest.Click
        LblTest.Text = "Dont click me please"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Hello World", "Test Popup", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
