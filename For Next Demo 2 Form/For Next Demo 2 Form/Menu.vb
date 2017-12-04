Public Class Menu

    Private Sub btnRockPaperScissors_Click(sender As Object, e As EventArgs) Handles btnRockPaperScissors.Click
        Dim box = New Rock_Paper_Scissors()
        box.Show()
    End Sub

    Private Sub BtnForNextDemo2_Click(sender As Object, e As EventArgs) Handles BtnForNextDemo2.Click
        Dim box = New For_Next_Demo_2()
        box.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class