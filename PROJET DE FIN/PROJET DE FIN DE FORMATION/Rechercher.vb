Public Class Rechercher

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Try
            If rbcin.Checked Then
                Cn.Open()
                If Cn.State = ConnectionState.Open Then
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "select * from T_plan  where Cin like '%" & TXTRECH.Text & "%'"
                    cmd.Connection = Cn
                    dr = cmd.ExecuteReader
                    DataGridView1.DataSource = ""
                    If dr.HasRows Then
                        Dim t As New DataTable
                        t.Load(dr)
                        DataGridView1.DataSource = t
                        dr.Close()
                        Cn.Close()
                    Else
                        MsgBox("Acun resultat trouve", 0 + 40, "Attention")

                    End If
                Else
                    MsgBox("Ereur de la conixion", 0 + 16, "Erreur")
                End If

            End If
            '-----------------------------------------------
            If rbNdossier.Checked Then
                Cn.Open()
                If Cn.State = ConnectionState.Open Then
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "select * from T_plan  where numdossier like '%" & TXTRECH.Text & "%'"
                    cmd.Connection = Cn
                    dr = cmd.ExecuteReader
                    DataGridView1.DataSource = ""

                    If dr.HasRows Then
                        Dim t As New DataTable
                        t.Load(dr)
                        DataGridView1.DataSource = t
                        dr.Close()
                        Cn.Close()
                    Else
                        MsgBox("Acun resultat trouve", 0 + 40, "Attention")
                        dr.Close()
                        Cn.Close()
                    End If
                Else
                    MsgBox("Ereur de la conixion", 0 + 16, "Erreur")
                End If
            End If
            '------------------------------------------------------
            If rbNP.Checked Then
                Cn.Open()
                If Cn.State = ConnectionState.Open Then
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "select * from T_plan  where nomprenom like '%" & TXTRECH.Text & "%'"
                    cmd.Connection = Cn
                    dr = cmd.ExecuteReader
                    DataGridView1.DataSource = ""
                    If dr.HasRows Then
                        Dim t As New DataTable
                        t.Load(dr)
                        DataGridView1.DataSource = t
                        dr.Close()
                        Cn.Close()
                    Else
                        MsgBox("Acun resultat trouve", 0 + 40, "Attention")
                    End If
                Else
                    MsgBox("Ereur de la conixion", 0 + 16, "Erreur")
                End If
            End If
            '-------------------------------------------------
            If rbNpermission.Checked Then
                Cn.Open()
                If Cn.State = ConnectionState.Open Then
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "select * from T_plan  where commisiontechniquenum like '%" & TXTRECH.Text & "%'"
                    cmd.Connection = Cn
                    dr = cmd.ExecuteReader
                    DataGridView1.DataSource = ""
                    If dr.HasRows Then
                        Dim t As New DataTable
                        t.Load(dr)
                        DataGridView1.DataSource = t
                        dr.Close()
                        Cn.Close()
                    Else
                        MsgBox("Acun resultat trouve", 0 + 40, "Attention")
                    End If
                Else
                    MsgBox("Ereur de la conixion", 0 + 16, "Erreur")
                End If
            End If
            '----------------------------

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        TXTRECH.Text = ""
    End Sub


    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        DataGridView1.DataSource = ds.Tables("T_plan")
    End Sub

   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        serviceplan.Show()
        Me.Hide()
    End Sub

    Private Sub PictFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictFermer.Click
        Me.Close()
        serviceplan.Show()
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
    Private Sub PicReduire_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PicReduire.MouseEnter
        PicReduire.BackgroundImage = My.Resources.Ball_reduire2
    End Sub

    Private Sub PicReduire_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PicReduire.MouseLeave
        PicReduire.BackgroundImage = My.Resources.Ball_Reduire_64
    End Sub

   

End Class