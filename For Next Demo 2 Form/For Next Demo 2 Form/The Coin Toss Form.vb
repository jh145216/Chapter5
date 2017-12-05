Public Class The_Coin_Toss_Form
    Dim HeadsTotal As Integer   ' Declared a global form variable
    Dim TailsTotal As Integer   ' Declared a global form variable
    Private Sub btnToss_Click(sender As Object, e As EventArgs) Handles btnToss.Click
        Dim intSideUp As Integer     ' To indicate which side is up
        Dim rand As New Random       ' Random number generator

        ' Get a random in thre range of 0 through 1.
        ' 0 means tails up, and 1 means heads up.
        intSideUp = rand.Next(2)

        ' Display the side that is up.
        If intSideUp = 0 Then
            ' 0 means tails is up, so display the tails
            ' image and hide the head  image.
            picTails.Visible = True
            picHeads.Visible = False
            TailsTotal = TailsTotal + 1
        Else
            ' 1 means heads is up, so display the heads
            ' image and hide the tails image.
            picHeads.Visible = True
            picTails.Visible = False
            HeadsTotal = HeadsTotal + 1
        End If

        lblTailsTotal.Text = TailsTotal
        lblHeadsTotal.Text = HeadsTotal
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class