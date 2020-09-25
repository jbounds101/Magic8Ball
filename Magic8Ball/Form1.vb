Public Class Form1
    Dim num As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        GetNumber()
    End Sub
    Private Sub GetNumber()
        num = Math.Ceiling(Rnd() * 10)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Select Case (Val(num))
            Case Is = 1
                Answer.Text = "Yes"
            Case Is = 2
                Answer.Text = "No"
            Case Is = 3
                Answer.Text = "Maybe"
            Case Is = 4
                Answer.Text = "Unlikely"
            Case Is = 5
                Answer.Text = "Likely"
            Case Is = 6
                Answer.Text = "Perhaps"
            Case Is = 7
                Answer.Text = "It is decidedly so"
            Case Is = 8
                Answer.Text = "Without a doubt"
            Case Is = 9
                Answer.Text = "Ask again later"
            Case Is = 10
                Answer.Text = "As I see it, yes"
        End Select

        GetNumber()
        Question.Text = ""
    End Sub
End Class