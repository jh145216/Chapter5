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

    Private Sub btnComboBoxDemo_Click(sender As Object, e As EventArgs) Handles btnComboBoxDemo.Click
        Dim box = New Combo_Box_Demo()
        box.Show()
    End Sub

    Private Sub btnCoinToss_Click(sender As Object, e As EventArgs) Handles btnCoinToss.Click
        Dim box = New The_Coin_Toss_Form()
        box.Show()
    End Sub

    Private Sub btnTestScore_Click(sender As Object, e As EventArgs) Handles btnTestScore.Click
        Dim box = New Test_Score()
        box.Show()
    End Sub

    Private Sub btnRunningTotal_Click(sender As Object, e As EventArgs) Handles btnRunningTotal.Click
        Dim box = New Running_Total()
        box.Show()
    End Sub
End Class