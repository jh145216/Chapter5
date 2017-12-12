Public Class Random_Number_Game
    Dim rand As New Random
    Dim PCNumber As Integer
    Dim userGuess As Integer
    Dim Wrong As Integer


    Sub RNG()
        userGuess = InputBox("Enter a number between 1 and 100")
        If userGuess > PCNumber Then
            MessageBox.Show("Guess to High! Try again.")
            Wrong = Wrong + 1
        ElseIf userGuess < PCNumber Then
            MessageBox.Show("Guess to Low! Try again.")
        End If

    End Sub

    Private Sub btnGuess_Click(sender As Object, e As EventArgs) Handles btnGuess.Click


        PCNumber = rand.Next(100)

        Do While userGuess <> PCNumber
            RNG()

        Loop
        lblGotWrong.Text = ("You got " & Wrong.ToString & "guesses wrong.")
        lblAnwser.Text = ("Correct! The number was " & PCNumber & "!")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class