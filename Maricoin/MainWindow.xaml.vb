Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Try
            Dim finalscore
            finalscore = coinno.Text Mod 256
            coinscore.Content = finalscore
        Catch ex As Exception
            MessageBox.Show("Something happened. Please try again.", "Maricoin: Something happened")
        End Try
    End Sub
End Class
