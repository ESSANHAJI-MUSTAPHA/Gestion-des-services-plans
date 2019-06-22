Public Class loginn
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Confirmation.Show()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        rtlogin.Text = ""
        rtpass.Text = ""
    End Sub

    Private Sub PicReduire_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PicReduire.MouseEnter
        PicReduire.BackgroundImage = My.Resources.Ball_reduire2
    End Sub

    Private Sub PicReduire_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PicReduire.MouseLeave
        PicReduire.BackgroundImage = My.Resources.Ball_Reduire_64
    End Sub

    Private Sub PictFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictFermer.Click
        Confirmation.Show()
    End Sub

    Private Sub PictFermer_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictFermer.MouseEnter
        PictFermer.BackgroundImage = My.Resources.Ball_stop
    End Sub

    Private Sub PictFermer_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictFermer.MouseLeave
        PictFermer.BackgroundImage = My.Resources.Ball_stop_64
    End Sub

    Private Sub PicReduire_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicReduire.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
     
        If rtpass.Text = "12345" Then
            Picunloc.Visible = False
            Piclock.Visible = True
            If ProgressBar1.Value < ProgressBar1.Maximum Then
                ProgressBar1.Increment(100)
                Timer1.Enabled = False
                serviceplan.Show()
                Me.Hide()
            End If

        Else
            MsgBox("login ou password erroné")
        End If


    End Sub

  
End Class