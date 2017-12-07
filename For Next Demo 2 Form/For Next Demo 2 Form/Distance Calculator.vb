Public Class Distance_Calculator

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblDistanceTraveled As Double
        Dim dblX As Double = 0

        Do While dblX < (txtHours.Text)
            dblX = dblX + 1
            dblDistanceTraveled = (txtSpeed.Text) * dblX

            ListResults.Items.Add(dblX & "         " & dblDistanceTraveled)

        Loop

    End Sub
End Class