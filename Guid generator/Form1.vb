Public Class Form1
    Public Sub GenerateGUID() Handles Button2.Click
        Dim sGUID As String
        sGUID = System.Guid.NewGuid.ToString()
        Label1.Text = sGUID
        Label1.Location = New Point(39, 9)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GenerateGUID(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sGUID As String
        sGUID = System.Guid.NewGuid.ToString()
        Label1.Text = "{" & sGUID & "}"
        Label1.Location = New Point(32, 9)
    End Sub
End Class
