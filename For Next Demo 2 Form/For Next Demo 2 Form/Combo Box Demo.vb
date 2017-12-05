Public Class Combo_Box_Demo

    Private Sub btnShowSelections_Click(sender As Object, e As EventArgs) Handles btnShowSelections.Click
        ' Display the combo boxes.
        txtCountry.Text = cboCountry.Text
        txtPlay.Text = cboPlay.Text
        txtArtist.Text = cboArtist.Text
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnResetForm_Click(sender As Object, e As EventArgs) Handles btnResetForm.Click
        ' Reset the combo boxes.
        cboCountry.SelectedIndex = -1
        cboCountry.Text = String.Empty
        cboPlay.SelectedIndex = -1
        cboPlay.Text = String.Empty
        cboArtist.SelectedIndex = -1
        cboArtist.Text = String.Empty
        ' Note: cboAtrists.Text is read-only

        ' Reset the labels
        lblCountry.Text = String.Empty
        lblPlay.Text = String.Empty
        lblArtist.Text = String.Empty
    End Sub
End Class