Public Class Form1
    Private Sub GenerateGUID() Handles Button1.Click
        Dim sGUID As String
        sGUID = System.Guid.NewGuid.ToString()
        Label1.Text = sGUID
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
