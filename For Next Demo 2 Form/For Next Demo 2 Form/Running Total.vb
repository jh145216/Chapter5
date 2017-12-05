Public Class Running_Total

    Private Sub btnEnterSales_Click(sender As Object, e As EventArgs) Handles btnEnterSales.Click
        Const intNUM_DAYS As Integer = 5        ' The number of days
        Dim intCount As Integer = 1         ' Loop counter
        Dim decSales As Integer = 0         ' To hold daily sales
        Dim decTotal As Integer = 0         ' To hold the total sales
        Dim strInput As String              ' To hold string input

        Do While intCount <= intNUM_DAYS
            strInput = InputBox("Enter the sales for day " & intCount.ToString)
            If Decimal.TryParse(strInput, decSales) Then
                'decTotal =+ decSlaes
                decTotal = decSales + decTotal
                'intCount += 1 'shortcut version
                intCount = intCount + 1
            Else
                MessageBox.Show("Enter a numeric value")
            End If
        Loop
        lblTotal.Text = decTotal.ToString("c")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class