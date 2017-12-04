Public Class For_Next_Demo_2

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim intCount1, intCount2, intCount3 As Integer     ' Loop counter
        Dim rand As New Random

        ' Move the image across the form.
        For intCount1 = 16 To rand.Next(250) + 150
            picMcLarenP1.Left = intCount1
        Next
        ' Move the image across the form.
        For intCount2 = 16 To rand.Next(250) + 150
            picLamborghiniAventadorSVRoadster.Left = intCount2
        Next
        ' Move the image across the form.
        For intCount3 = 16 To rand.Next(250) + 150
            picLaFerrari.Left = intCount3
        Next
        MessageBox.Show(intCount1)
        MessageBox.Show(intCount2)
        MessageBox.Show(intCount3)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        picMcLarenP1.Left = 16
        picLamborghiniAventadorSVRoadster.Left = 16
        picLaFerrari.Left = 16
    End Sub
End Class
