<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginn
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginn))
        Me.rtlogin = New System.Windows.Forms.RichTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Picunloc = New System.Windows.Forms.PictureBox
        Me.Label80 = New System.Windows.Forms.Label
        Me.Label73 = New System.Windows.Forms.Label
        Me.Label72 = New System.Windows.Forms.Label
        Me.Label71 = New System.Windows.Forms.Label
        Me.Label70 = New System.Windows.Forms.Label
        Me.Label69 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.rtpass = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.PicReduire = New System.Windows.Forms.PictureBox
        Me.PictFermer = New System.Windows.Forms.PictureBox
        Me.Piclock = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        CType(Me.Picunloc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PicReduire, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictFermer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Piclock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rtlogin
        '
        Me.rtlogin.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtlogin.Location = New System.Drawing.Point(174, 321)
        Me.rtlogin.Name = "rtlogin"
        Me.rtlogin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rtlogin.Size = New System.Drawing.Size(299, 25)
        Me.rtlogin.TabIndex = 22
        Me.rtlogin.Text = "اسم"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label7.Location = New System.Drawing.Point(10, 459)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(270, 45)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Copyright © 2011-2012, Porjet de Fin Formation." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Realisé par Mustapha Es-sanhaji." & _
            "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tous droits réservés."
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(337, 418)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 37)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = " الخروج "
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(486, 368)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 19)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "كلمة المرور"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(512, 319)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 19)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "  اسم"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Silver
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(204, 418)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 37)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "الدخول"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(50, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(553, 114)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "مصلحةالتصاميم" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Picunloc
        '
        Me.Picunloc.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources._9fal
        Me.Picunloc.Location = New System.Drawing.Point(35, 299)
        Me.Picunloc.Name = "Picunloc"
        Me.Picunloc.Size = New System.Drawing.Size(78, 109)
        Me.Picunloc.TabIndex = 25
        Me.Picunloc.TabStop = False
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.BackColor = System.Drawing.Color.Transparent
        Me.Label80.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.Location = New System.Drawing.Point(6, 41)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(170, 16)
        Me.Label80.TabIndex = 68
        Me.Label80.Text = "الجماعة الحضرية لجرسيف" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.BackColor = System.Drawing.Color.Transparent
        Me.Label73.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.Location = New System.Drawing.Point(435, 100)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(170, 16)
        Me.Label73.TabIndex = 67
        Me.Label73.Text = "الجماعة الحضرية لجرسيف" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.BackColor = System.Drawing.Color.Transparent
        Me.Label72.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.Location = New System.Drawing.Point(452, 84)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(128, 16)
        Me.Label72.TabIndex = 66
        Me.Label72.Text = "باشوية جــرســيــف" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label71
        '
        Me.Label71.BackColor = System.Drawing.Color.Transparent
        Me.Label71.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.Location = New System.Drawing.Point(467, 67)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(119, 16)
        Me.Label71.TabIndex = 65
        Me.Label71.Text = "عمالـــة إقليم جرسيف                             " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.BackColor = System.Drawing.Color.Transparent
        Me.Label70.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.Location = New System.Drawing.Point(459, 51)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(103, 16)
        Me.Label70.TabIndex = 64
        Me.Label70.Text = "وزارة الداخليـــة" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.BackColor = System.Drawing.Color.Transparent
        Me.Label69.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.Location = New System.Drawing.Point(455, 35)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(110, 16)
        Me.Label69.TabIndex = 63
        Me.Label69.Text = "المملكة المغربية"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Silver
        Me.Button3.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.cmdaff
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(470, 418)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 37)
        Me.Button3.TabIndex = 69
        Me.Button3.Text = "& مسح    "
        Me.Button3.UseVisualStyleBackColor = False
        '
        'rtpass
        '
        Me.rtpass.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtpass.Location = New System.Drawing.Point(174, 371)
        Me.rtpass.Name = "rtpass"
        Me.rtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.rtpass.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.rtpass.Size = New System.Drawing.Size(299, 27)
        Me.rtpass.TabIndex = 70
        Me.rtpass.Text = "12345"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.logo
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PicReduire)
        Me.Panel1.Controls.Add(Me.PictFermer)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(623, 31)
        Me.Panel1.TabIndex = 71
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Algerian", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "حساب "
        '
        'PicReduire
        '
        Me.PicReduire.BackColor = System.Drawing.Color.Transparent
        Me.PicReduire.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Ball_Reduire_64
        Me.PicReduire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicReduire.Location = New System.Drawing.Point(559, 0)
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
        Me.PictFermer.Location = New System.Drawing.Point(591, 0)
        Me.PictFermer.Name = "PictFermer"
        Me.PictFermer.Size = New System.Drawing.Size(31, 27)
        Me.PictFermer.TabIndex = 0
        Me.PictFermer.TabStop = False
        '
        'Piclock
        '
        Me.Piclock.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources._9falOVER
        Me.Piclock.Location = New System.Drawing.Point(35, 298)
        Me.Piclock.Name = "Piclock"
        Me.Piclock.Size = New System.Drawing.Size(78, 109)
        Me.Piclock.TabIndex = 72
        Me.Piclock.TabStop = False
        Me.Piclock.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(520, 466)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar1.TabIndex = 73
        '
        'loginn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.bureau11
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(623, 515)
        Me.ControlBox = False
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Piclock)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.rtpass)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label80)
        Me.Controls.Add(Me.Label73)
        Me.Controls.Add(Me.Label72)
        Me.Controls.Add(Me.Label71)
        Me.Controls.Add(Me.Label70)
        Me.Controls.Add(Me.Label69)
        Me.Controls.Add(Me.Picunloc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rtlogin)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "loginn"
        Me.Opacity = 0.96
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "حساب "
        CType(Me.Picunloc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PicReduire, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictFermer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Piclock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rtlogin As System.Windows.Forms.RichTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Picunloc As System.Windows.Forms.PictureBox
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents rtpass As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PicReduire As System.Windows.Forms.PictureBox
    Friend WithEvents PictFermer As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Piclock As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
End Class
