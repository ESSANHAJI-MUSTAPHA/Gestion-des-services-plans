Public Class Form1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If ProgressBar1.Value < ProgressBar1.Maximum Then
            ProgressBar1.Increment(1)
        Else

            Timer1.Enabled = False
            Me.Hide()
            loginn.Show()
        End If

    End Sub

End Class