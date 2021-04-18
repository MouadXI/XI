Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'choose between to games "fliping a coin or choose a number"
        If RadioButton1.Checked = True Then Form2.Show()
        If RadioButton2.Checked = True Then Form3.Show()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class