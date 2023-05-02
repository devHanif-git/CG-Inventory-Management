Public Class Loading
    Private Sub Loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Left = (Label1.Parent.Width \ 2) - (Label1.Width \ 2) 'horizontal centering
    End Sub
End Class