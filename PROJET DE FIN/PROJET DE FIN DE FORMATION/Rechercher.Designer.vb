<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rechercher
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.PicReduire = New System.Windows.Forms.PictureBox
        Me.PictFermer = New System.Windows.Forms.PictureBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label73 = New System.Windows.Forms.Label
        Me.Label72 = New System.Windows.Forms.Label
        Me.Label71 = New System.Windows.Forms.Label
        Me.Label70 = New System.Windows.Forms.Label
        Me.Label69 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button14 = New System.Windows.Forms.Button
        Me.Button13 = New System.Windows.Forms.Button
        Me.Label79 = New System.Windows.Forms.Label
        Me.TXTRECH = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbNpermission = New System.Windows.Forms.RadioButton
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.rbNdossier = New System.Windows.Forms.RadioButton
        Me.rbcin = New System.Windows.Forms.RadioButton
        Me.rbNP = New System.Windows.Forms.RadioButton
        Me.Panel1.SuspendLayout()
        CType(Me.PicReduire, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictFermer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.logo
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PicReduire)
        Me.Panel1.Controls.Add(Me.PictFermer)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(873, 31)
        Me.Panel1.TabIndex = 73
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Algerian", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Rechercher"
        '
        'PicReduire
        '
        Me.PicReduire.BackColor = System.Drawing.Color.Transparent
        Me.PicReduire.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Ball_Reduire_64
        Me.PicReduire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicReduire.Location = New System.Drawing.Point(800, 0)
        Me.PicReduire.Name = "PicReduire"
        Me.PicReduire.Size = New System.Drawing.Size(31, 27)
        Me.PicReduire.TabIndex = 1
        Me.PicReduire.TabStop = False
        '
        'PictFermer
        '
        Me.PictFermer.BackColor = System.Drawing.Color.Transparent
        Me.PictFermer.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Ball_stop_64
        Me.PictFermer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictFermer.Location = New System.Drawing.Point(832, 0)
        Me.PictFermer.Name = "PictFermer"
        Me.PictFermer.Size = New System.Drawing.Size(31, 27)
        Me.PictFermer.TabIndex = 0
        Me.PictFermer.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(17, 333)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(840, 221)
        Me.DataGridView1.TabIndex = 86
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Precedent
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Location = New System.Drawing.Point(317, 276)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 36)
        Me.Button1.TabIndex = 85
        Me.Button1.Text = "&Retour"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.BackColor = System.Drawing.Color.Transparent
        Me.Label73.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.Location = New System.Drawing.Point(687, 109)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(170, 16)
        Me.Label73.TabIndex = 84
        Me.Label73.Text = "الجماعة الحضرية لجرسيف" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.BackColor = System.Drawing.Color.Transparent
        Me.Label72.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.Location = New System.Drawing.Point(711, 93)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(128, 16)
        Me.Label72.TabIndex = 83
        Me.Label72.Text = "باشوية جــرســيــف" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label71
        '
        Me.Label71.BackColor = System.Drawing.Color.Transparent
        Me.Label71.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.Location = New System.Drawing.Point(726, 76)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(119, 16)
        Me.Label71.TabIndex = 82
        Me.Label71.Text = "عمالـــة إقليم جرسيف                             " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.BackColor = System.Drawing.Color.Transparent
        Me.Label70.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.Location = New System.Drawing.Point(718, 60)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(103, 16)
        Me.Label70.TabIndex = 81
        Me.Label70.Text = "وزارة الداخليـــة" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.BackColor = System.Drawing.Color.Transparent
        Me.Label69.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.Location = New System.Drawing.Point(714, 44)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(110, 16)
        Me.Label69.TabIndex = 80
        Me.Label69.Text = "المملكة المغربية"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(261, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(369, 39)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "لا ئحة الرخص الممنوحة" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Button14
        '
        Me.Button14.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.listchercher
        Me.Button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button14.Location = New System.Drawing.Point(65, 276)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(110, 36)
        Me.Button14.TabIndex = 78
        Me.Button14.Text = "&Rechercher"
        Me.Button14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.delete
        Me.Button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button13.Location = New System.Drawing.Point(195, 276)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(97, 36)
        Me.Button13.TabIndex = 77
        Me.Button13.Text = "&Annuler"
        Me.Button13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.BackColor = System.Drawing.Color.Transparent
        Me.Label79.Location = New System.Drawing.Point(113, 221)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(62, 13)
        Me.Label79.TabIndex = 76
        Me.Label79.Text = "Rechercher"
        '
        'TXTRECH
        '
        Me.TXTRECH.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TXTRECH.Location = New System.Drawing.Point(204, 218)
        Me.TXTRECH.Name = "TXTRECH"
        Me.TXTRECH.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXTRECH.Size = New System.Drawing.Size(253, 20)
        Me.TXTRECH.TabIndex = 75
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rbNpermission)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.rbNdossier)
        Me.GroupBox1.Controls.Add(Me.rbcin)
        Me.GroupBox1.Controls.Add(Me.rbNP)
        Me.GroupBox1.Location = New System.Drawing.Point(548, 206)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(263, 106)
        Me.GroupBox1.TabIndex = 74
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Critére de recherche"
        '
        'rbNpermission
        '
        Me.rbNpermission.AutoSize = True
        Me.rbNpermission.Location = New System.Drawing.Point(80, 51)
        Me.rbNpermission.Name = "rbNpermission"
        Me.rbNpermission.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rbNpermission.Size = New System.Drawing.Size(71, 17)
        Me.rbNpermission.TabIndex = 4
        Me.rbNpermission.TabStop = True
        Me.rbNpermission.Text = "رقم رخصة"
        Me.rbNpermission.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(203, 78)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioButton4.Size = New System.Drawing.Size(45, 17)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "الكل"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'rbNdossier
        '
        Me.rbNdossier.AutoSize = True
        Me.rbNdossier.Location = New System.Drawing.Point(181, 51)
        Me.rbNdossier.Name = "rbNdossier"
        Me.rbNdossier.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rbNdossier.Size = New System.Drawing.Size(72, 17)
        Me.rbNdossier.TabIndex = 2
        Me.rbNdossier.TabStop = True
        Me.rbNdossier.Text = "رقم الملف"
        Me.rbNdossier.UseVisualStyleBackColor = True
        '
        'rbcin
        '
        Me.rbcin.AutoSize = True
        Me.rbcin.Checked = True
        Me.rbcin.Location = New System.Drawing.Point(6, 28)
        Me.rbcin.Name = "rbcin"
        Me.rbcin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rbcin.Size = New System.Drawing.Size(145, 17)
        Me.rbcin.TabIndex = 1
        Me.rbcin.TabStop = True
        Me.rbcin.Text = "رقم بطاقة التعريف الوطنية "
        Me.rbcin.UseVisualStyleBackColor = True
        '
        'rbNP
        '
        Me.rbNP.AutoSize = True
        Me.rbNP.Location = New System.Drawing.Point(168, 28)
        Me.rbNP.Name = "rbNP"
        Me.rbNP.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rbNP.Size = New System.Drawing.Size(86, 17)
        Me.rbNP.TabIndex = 0
        Me.rbNP.TabStop = True
        Me.rbNP.Text = "الاسم الكامل"
        Me.rbNP.UseVisualStyleBackColor = True
        '
        'Rechercher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.bureau11
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(875, 560)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label73)
        Me.Controls.Add(Me.Label72)
        Me.Controls.Add(Me.Label71)
        Me.Controls.Add(Me.Label70)
        Me.Controls.Add(Me.Label69)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Label79)
        Me.Controls.Add(Me.TXTRECH)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Rechercher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rechercher2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PicReduire, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictFermer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PicReduire As System.Windows.Forms.PictureBox
    Friend WithEvents PictFermer As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents TXTRECH As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbNpermission As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents rbNdossier As System.Windows.Forms.RadioButton
    Friend WithEvents rbcin As System.Windows.Forms.RadioButton
    Friend WithEvents rbNP As System.Windows.Forms.RadioButton
End Class
