﻿Public Class Sum_of_Number_form

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnEnterNumber_Click(sender As Object, e As EventArgs) Handles btnEnterNumber.Click
        Dim intSum As Integer
        Dim input As Integer

        input = InputBox("Enter a positive integer value.")
        For i As Integer = 0 To input
            intSum += i
        Next

        MessageBox.Show("The sum of the numbers 1 though " & input & " is " & intSum)
    End Sub
End Class