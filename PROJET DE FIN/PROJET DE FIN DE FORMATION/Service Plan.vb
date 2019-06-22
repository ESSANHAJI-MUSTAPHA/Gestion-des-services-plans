Imports System.IO
Imports Microsoft.Office.Interop
Imports System.Data.OleDb
Public Class serviceplan
    'Public Cn As New SqlConnection("Data source =.\SQLEXPRESS; Initial Catalog=serviceplan;Integrated Security =True;")
    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Try
            Dim oWord As New Word.Application
            Dim oDoc As Word.Document
            oDoc = oWord.Documents.Open("D:\client.doc")
            oDoc.Bookmarks.Item("Ref").Range.Text = txtref.Text
            oDoc.Bookmarks.Item("Date").Range.Text = Mtxtdate.Text
            oDoc.Bookmarks.Item("Nom").Range.Text = txtnom.Text
            oDoc.Bookmarks("Adresse").Range.Text = txtadresse.Text
            oDoc.Bookmarks("Objet").Range.Text = txtobjet.Text
            oDoc.Bookmarks("Contenu").Range.Text = Rtbcontenu.Text
            oWord.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim oWord As New Word.Application
            Dim oDoc As Word.Document
            oDoc = oWord.Documents.Open("D:\قــــــــــرار.doc")
            oDoc.Bookmarks.Item("Permision").Range.Text = txtnmper1.Text
            oDoc.Bookmarks.Item("dateperm").Range.Text = txtdateper1.Text
            oDoc.Bookmarks.Item("Nom").Range.Text = txtnp1.Text
            oDoc.Bookmarks.Item("NOM1").Range.Text = txtnp1.Text
            oDoc.Bookmarks("Adresse").Range.Text = rtbadress1.Text
            oDoc.Bookmarks("Typeob").Range.Text = cbtypeobj1.Text
            oDoc.Bookmarks("TYPEOBJ1").Range.Text = cbtypeobj1.Text
            oDoc.Bookmarks.Item("datecom").Range.Text = MSKDATECOM.Text
            oWord.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtnomprenomM_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnomprenomM.GotFocus
        CHANGELONG()
    End Sub
    Public Sub CHANGELONG()
        Dim cultureInfo As System.Globalization.CultureInfo = _
         New System.Globalization.CultureInfo("ar-MA")
        InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(cultureInfo)
    End Sub

    Private Sub txtpalceobjM_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpalceobjM.GotFocus
        CHANGELONG()
    End Sub

    Private Sub RichTextBox3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcoC.GotFocus
        CHANGELONG()
    End Sub

    Private Sub txtnom_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnom.GotFocus
        CHANGELONG()
    End Sub

    Private Sub txtadresse_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtadresse.GotFocus
        CHANGELONG()
    End Sub

    Private Sub txtobjet_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtobjet.GotFocus
        CHANGELONG()
    End Sub

    Private Sub Rtbcontenu_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rtbcontenu.GotFocus
        CHANGELONG()
    End Sub

    Private Sub txtnp1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnp1.GotFocus
        CHANGELONG()
    End Sub

    Private Sub rtbadress1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtbadress1.GotFocus
        CHANGELONG()
    End Sub

    Private Sub cbtypeobj1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbtypeobj1.GotFocus
        CHANGELONG()
    End Sub

    Private Sub btnajouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnajouter.Click

        Try
            Dim trouv As Boolean = False
            For i As Integer = 0 To ds.Tables("T_plan").Rows.Count - 1
                If ds.Tables("T_plan").Rows(i)(0) = txtcinM.Text Then
                    MsgBox("deja exist")
                    trouv = True
                End If
            Next
            If trouv = False Then
                Dim li As DataRow = ds.Tables("T_plan").NewRow
                li(0) = txtcinM.Text
                li(1) = txtnomprenomM.Text
                li(2) = txttypeobjetM.Text
                li(3) = txtpalceobjM.Text
                li(4) = txtnumdossierM.Text
                li(5) = txtdatedossierM.Text
                li(6) = txtnumcomisionM.Text
                li(7) = txtdatecomisionM.Text
                li(8) = txtd.Text
                li(9) = msk.Text
                ds.Tables("T_plan").Rows.Add(li)
                MsgBox("ajouter avec seccess")
            End If
            da.Update(ds, "T_plan")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub serviceplan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
                'MsgBox("bien reussi")
                da.Fill(ds, "T_plan")
                Cn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnmodifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodifier.Click
        Try
            For i As Integer = 0 To ds.Tables("T_plan").Rows.Count - 1
                With ds.Tables("T_plan")
                    If .Rows(i)(0) = txtcinM.Text Then
                        .Rows(i)(1) = txtnomprenomM.Text
                        .Rows(i)(2) = txttypeobjetM.Text
                        .Rows(i)(3) = txtpalceobjM.Text
                        .Rows(i)(4) = txtnumdossierM.Text
                        .Rows(i)(5) = txtdatedossierM.Text
                        .Rows(i)(6) = txtnumcomisionM.Text
                        .Rows(i)(7) = txtdatecomisionM.Text
                        .Rows(i)(8) = txtd.Text
                        .Rows(i)(9) = msk.Text
                    End If
                End With
            Next
            da.Update(ds, "T_plan")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnfermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfermer.Click
        Confirmation.Show()
    End Sub

    Private Sub btnreche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreche.Click
        Try
            Dim Trove As Boolean = False
            Dim code As String = InputBox(" Saisir cin a rechercher ")
            For i As Integer = 0 To ds.Tables("T_plan").Rows.Count - 1
                If ds.Tables("T_plan").Rows(i)(0) = code Then
                    txtcinM.Text = ds.Tables("T_plan").Rows(i)(0)
                    txtnomprenomM.Text = ds.Tables("T_plan").Rows(i)(1)
                    txttypeobjetM.Text = ds.Tables("T_plan").Rows(i)(2)
                    txtpalceobjM.Text = ds.Tables("T_plan").Rows(i)(3)
                    txtnumdossierM.Text = ds.Tables("T_plan").Rows(i)(4)
                    txtdatedossierM.Text = ds.Tables("T_plan").Rows(i)(5)
                    txtnumcomisionM.Text = ds.Tables("T_plan").Rows(i)(6)
                    txtdatecomisionM.Text = ds.Tables("T_plan").Rows(i)(7)
                    txtd.Text = ds.Tables("T_plan").Rows(i)(8)
                    msk.Text = ds.Tables("T_plan").Rows(i)(9)
                    Trove = True

                End If
            Next
            If Trove = False Then
                MsgBox("n'exists pas")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub SupprimerAltSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupprimerAltSToolStripMenuItem.Click
        Try
            Dim T As Boolean = False
            For i As Integer = 0 To ds.Tables("T_plan").Rows.Count - 1
                If ds.Tables("T_plan").Rows(i)(0) = txtcinM.Text Then
                    ds.Tables("T_plan").Rows(i).Delete()
                    T = True
                End If
            Next
            If T = False Then
                MsgBox("introvable !!!")
            End If
            EnregesterToolStripMenuItem_Click(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub RechercherToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RechercherToolStripMenuItem.Click

        Rechercher.Show()
        Me.Hide()
    End Sub

    Private Sub InfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InfoToolStripMenuItem.Click
        MsgBox("Copyright © 2012-2013, Application de service plan.Realisé par Mustapha Es-sanhaji.Tous droits réservés.", MsgBoxStyle.Information, "Information")
    End Sub


    Private Sub EnregesterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnregesterToolStripMenuItem.Click
        Try
            da.Update(ds, "T_plan")
            MsgBox("Enregistre bien effectue")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub AjouterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjouterToolStripMenuItem.Click
        btnajouter_Click(sender, e)
    End Sub

    Private Sub MToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MToolStripMenuItem.Click
        btnmodifier_Click(sender, e)
    End Sub

    Private Sub btnsuivant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TabControl1.SelectedIndex -= 1
        If TabControl1.TabIndex > TabControl1.TabCount - 1 Then
            TabControl1.SelectedIndex = TabControl1.TabCount + 1
        End If
    End Sub

    Private Sub QuiterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuiterToolStripMenuItem.Click
       
        Confirmation.Show()

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TabControl1.SelectedIndex -= 1
        If TabControl1.TabIndex > TabControl1.TabCount - 1 Then
            TabControl1.SelectedIndex = TabControl1.TabCount + 1
        End If
    End Sub


    Private Sub DossierDeConstruireToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DossierDeConstruireToolStripMenuItem.Click
        tpconstruire.Show()
    End Sub

    Private Sub CommissionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommissionToolStripMenuItem.Click
        tpcommision.Show()
    End Sub

    Private Sub FichierStatiqueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FichierStatiqueToolStripMenuItem.Click
        tpstatique.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtcinM.Text = ""
        txtnomprenomM.Text = ""
        txttypeobjetM.Text = ""
        txtpalceobjM.Text = ""
        txtnumdossierM.Text = ""
        txtdatedossierM.Text() = ""
        txtnumcomisionM.Text() = ""
        txtdatecomisionM.Text() = ""
        txtd.Text = ""
        msk.Text = ""
    End Sub


  
    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Dim oWord As New Word.Application
        Dim oDoc As Word.Document
        oDoc = oWord.Documents.Open("D:\محضر .doc")
        oDoc.Bookmarks.Item("Comisionnum").Range.Text = txtcomi.Text
        oDoc.Bookmarks.Item("DATE").Range.Text = mtdat.Text
        oDoc.Bookmarks.Item("text").Range.Text = txtcoC.Text
        oWord.Visible = True
    End Sub

    Private Sub tpcommision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tpcommision.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        mtdat.Text = ""
        txtcomi.Text = ""
        txtcoC.Text = ""
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox7.Text = ""
        MaskedTextBox4.Text = ""
        txtref.Text = ""
        Mtxtdate.Text = ""
        txtnom.Text = ""
        txtadresse.Text = ""
        txtobjet.Text = ""
        Rtbcontenu.Text = ""
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        MSKDATECOM.Text = ""
        txtnmper1.Text = ""
        txtdateper1.Text = ""
        txtnp1.Text = ""
        cbtypeobj1.Text = ""
        rtbadress1.Text = ""
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

    Private Sub PictFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictFermer.Click
        Confirmation.Show()
    End Sub

    Private Sub PictFermer_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictFermer.MouseEnter
        PictFermer.BackgroundImage = My.Resources.Ball_stop
    End Sub

    Private Sub PictFermer_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictFermer.MouseLeave
        PictFermer.BackgroundImage = My.Resources.Ball_stop_64
    End Sub
End Class