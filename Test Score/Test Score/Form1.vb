Public Class Form1

    Private Sub btnGetScores_Click(sender As Object, e As EventArgs) Handles btnGetScores.Click
        ' This procedure gets the test scores, then caluclates and
        ' display the average.
        Dim intNumScores As Integer = 5     ' The number of test scores
        Dim dblTestScores As Double         ' To hold a test score
        Dim dblTotal As Double = 0          ' Accumulator, initialized to 0
        Dim dblAverage As Double            ' The Average of the test scores
        Dim strInput As String              ' To hold user input
        Dim intCount As Integer = 1         ' Counter variable, initialized

        ' Prompt the user for the number of test scores.
        strInput = InputBox("How many test scores do you want to average?")

        ' Convert the input to an integer.
        If Integer.TryParse(strInput, intNumScores) Then

            ' Get the test scores.
            Do Until intCount > intNumScores

                ' Prompt the user for a score.
                strInput = InputBox("Enter test score " & intCount.ToString())

                ' Convert the input to a Double.
                If Double.TryParse(strInput, dblTestScores) Then

                    dblTotal += dblTestScores
                    ' Add 1 to the counter.
                    intCount += 1
                Else
                    ' Invalid test score.
                    MessageBox.Show("Enter a numeric test score.")
                End If
            Loop

            ' Calculate and display the average.
            If intNumScores > 0 Then
                dblAverage = dblTotal / intNumScores
                lblTestAvg.Text = dblAverage.ToString()
            End If

        Else
            ' Invaild number of test scores.
            MessageBox.Show("Enter an integer value for number of test scores.")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the Form
        Me.Close()
    End Sub
End Class
