<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHangman
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHangman))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblCategoy = New System.Windows.Forms.Label()
        Me.lblAttempts = New System.Windows.Forms.Label()
        Me.txtAttempts = New System.Windows.Forms.TextBox()
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.picHangMan = New System.Windows.Forms.PictureBox()
        Me.ImageListHangmanPic = New System.Windows.Forms.ImageList(Me.components)
        Me.btnQ = New System.Windows.Forms.Button()
        Me.btnW = New System.Windows.Forms.Button()
        Me.btnE = New System.Windows.Forms.Button()
        Me.btnNextWord = New System.Windows.Forms.Button()
        Me.btnR = New System.Windows.Forms.Button()
        Me.btnT = New System.Windows.Forms.Button()
        Me.btnY = New System.Windows.Forms.Button()
        Me.btnU = New System.Windows.Forms.Button()
        Me.btnI = New System.Windows.Forms.Button()
        Me.btnO = New System.Windows.Forms.Button()
        Me.btnP = New System.Windows.Forms.Button()
        Me.btnA = New System.Windows.Forms.Button()
        Me.btnS = New System.Windows.Forms.Button()
        Me.btnD = New System.Windows.Forms.Button()
        Me.btnF = New System.Windows.Forms.Button()
        Me.btnG = New System.Windows.Forms.Button()
        Me.btnH = New System.Windows.Forms.Button()
        Me.btnJ = New System.Windows.Forms.Button()
        Me.btnK = New System.Windows.Forms.Button()
        Me.btnL = New System.Windows.Forms.Button()
        Me.btnZ = New System.Windows.Forms.Button()
        Me.btnX = New System.Windows.Forms.Button()
        Me.btnC = New System.Windows.Forms.Button()
        Me.btnV = New System.Windows.Forms.Button()
        Me.btnB = New System.Windows.Forms.Button()
        Me.btnN = New System.Windows.Forms.Button()
        Me.btnM = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblInst = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picHangMan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(747, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CategoriesToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CategoriesToolStripMenuItem
        '
        Me.CategoriesToolStripMenuItem.Name = "CategoriesToolStripMenuItem"
        Me.CategoriesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CategoriesToolStripMenuItem.Text = "Categories"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'lblCategoy
        '
        Me.lblCategoy.AutoSize = True
        Me.lblCategoy.BackColor = System.Drawing.Color.Transparent
        Me.lblCategoy.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoy.ForeColor = System.Drawing.Color.Maroon
        Me.lblCategoy.Location = New System.Drawing.Point(134, 24)
        Me.lblCategoy.Name = "lblCategoy"
        Me.lblCategoy.Size = New System.Drawing.Size(170, 42)
        Me.lblCategoy.TabIndex = 1
        Me.lblCategoy.Text = "Category"
        '
        'lblAttempts
        '
        Me.lblAttempts.AutoSize = True
        Me.lblAttempts.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAttempts.ForeColor = System.Drawing.Color.Maroon
        Me.lblAttempts.Location = New System.Drawing.Point(12, 156)
        Me.lblAttempts.Name = "lblAttempts"
        Me.lblAttempts.Size = New System.Drawing.Size(110, 48)
        Me.lblAttempts.TabIndex = 2
        Me.lblAttempts.Text = "Remaining" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Attempts:"
        '
        'txtAttempts
        '
        Me.txtAttempts.Cursor = System.Windows.Forms.Cursors.Cross
        Me.txtAttempts.Enabled = False
        Me.txtAttempts.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAttempts.ForeColor = System.Drawing.Color.Maroon
        Me.txtAttempts.Location = New System.Drawing.Point(52, 217)
        Me.txtAttempts.Name = "txtAttempts"
        Me.txtAttempts.Size = New System.Drawing.Size(33, 47)
        Me.txtAttempts.TabIndex = 3
        Me.txtAttempts.Text = "6"
        Me.txtAttempts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtWord
        '
        Me.txtWord.Enabled = False
        Me.txtWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWord.Location = New System.Drawing.Point(139, 304)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(412, 44)
        Me.txtWord.TabIndex = 4
        Me.txtWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'picHangMan
        '
        Me.picHangMan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picHangMan.Image = CType(resources.GetObject("picHangMan.Image"), System.Drawing.Image)
        Me.picHangMan.Location = New System.Drawing.Point(141, 80)
        Me.picHangMan.Name = "picHangMan"
        Me.picHangMan.Size = New System.Drawing.Size(410, 218)
        Me.picHangMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHangMan.TabIndex = 5
        Me.picHangMan.TabStop = False
        '
        'ImageListHangmanPic
        '
        Me.ImageListHangmanPic.ImageStream = CType(resources.GetObject("ImageListHangmanPic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListHangmanPic.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListHangmanPic.Images.SetKeyName(0, "hm6.jpg")
        Me.ImageListHangmanPic.Images.SetKeyName(1, "hm5.jpg")
        Me.ImageListHangmanPic.Images.SetKeyName(2, "hm4.jpg")
        Me.ImageListHangmanPic.Images.SetKeyName(3, "hm3.jpg")
        Me.ImageListHangmanPic.Images.SetKeyName(4, "hm1.jpg")
        Me.ImageListHangmanPic.Images.SetKeyName(5, "601269.jpg")
        '
        'btnQ
        '
        Me.btnQ.BackColor = System.Drawing.Color.Goldenrod
        Me.btnQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQ.ForeColor = System.Drawing.Color.DarkRed
        Me.btnQ.Location = New System.Drawing.Point(67, 354)
        Me.btnQ.Name = "btnQ"
        Me.btnQ.Size = New System.Drawing.Size(46, 43)
        Me.btnQ.TabIndex = 6
        Me.btnQ.Text = "Q"
        Me.btnQ.UseVisualStyleBackColor = False
        '
        'btnW
        '
        Me.btnW.BackColor = System.Drawing.Color.Goldenrod
        Me.btnW.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnW.ForeColor = System.Drawing.Color.DarkRed
        Me.btnW.Location = New System.Drawing.Point(119, 354)
        Me.btnW.Name = "btnW"
        Me.btnW.Size = New System.Drawing.Size(46, 43)
        Me.btnW.TabIndex = 7
        Me.btnW.Text = "W"
        Me.btnW.UseVisualStyleBackColor = False
        '
        'btnE
        '
        Me.btnE.BackColor = System.Drawing.Color.Goldenrod
        Me.btnE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnE.ForeColor = System.Drawing.Color.DarkRed
        Me.btnE.Location = New System.Drawing.Point(171, 354)
        Me.btnE.Name = "btnE"
        Me.btnE.Size = New System.Drawing.Size(46, 43)
        Me.btnE.TabIndex = 8
        Me.btnE.Text = "E"
        Me.btnE.UseVisualStyleBackColor = False
        '
        'btnNextWord
        '
        Me.btnNextWord.BackColor = System.Drawing.Color.Goldenrod
        Me.btnNextWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextWord.ForeColor = System.Drawing.Color.Maroon
        Me.btnNextWord.Location = New System.Drawing.Point(616, 206)
        Me.btnNextWord.Name = "btnNextWord"
        Me.btnNextWord.Size = New System.Drawing.Size(101, 58)
        Me.btnNextWord.TabIndex = 9
        Me.btnNextWord.Text = "Next " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Word"
        Me.btnNextWord.UseVisualStyleBackColor = False
        Me.btnNextWord.Visible = False
        '
        'btnR
        '
        Me.btnR.BackColor = System.Drawing.Color.Goldenrod
        Me.btnR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnR.ForeColor = System.Drawing.Color.DarkRed
        Me.btnR.Location = New System.Drawing.Point(223, 354)
        Me.btnR.Name = "btnR"
        Me.btnR.Size = New System.Drawing.Size(46, 43)
        Me.btnR.TabIndex = 10
        Me.btnR.Text = "R"
        Me.btnR.UseVisualStyleBackColor = False
        '
        'btnT
        '
        Me.btnT.BackColor = System.Drawing.Color.Goldenrod
        Me.btnT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnT.ForeColor = System.Drawing.Color.DarkRed
        Me.btnT.Location = New System.Drawing.Point(275, 354)
        Me.btnT.Name = "btnT"
        Me.btnT.Size = New System.Drawing.Size(46, 43)
        Me.btnT.TabIndex = 11
        Me.btnT.Text = "T"
        Me.btnT.UseVisualStyleBackColor = False
        '
        'btnY
        '
        Me.btnY.BackColor = System.Drawing.Color.Goldenrod
        Me.btnY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnY.ForeColor = System.Drawing.Color.DarkRed
        Me.btnY.Location = New System.Drawing.Point(327, 354)
        Me.btnY.Name = "btnY"
        Me.btnY.Size = New System.Drawing.Size(46, 43)
        Me.btnY.TabIndex = 12
        Me.btnY.Text = "Y"
        Me.btnY.UseVisualStyleBackColor = False
        '
        'btnU
        '
        Me.btnU.BackColor = System.Drawing.Color.Goldenrod
        Me.btnU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnU.ForeColor = System.Drawing.Color.DarkRed
        Me.btnU.Location = New System.Drawing.Point(381, 354)
        Me.btnU.Name = "btnU"
        Me.btnU.Size = New System.Drawing.Size(46, 43)
        Me.btnU.TabIndex = 13
        Me.btnU.Text = "U"
        Me.btnU.UseVisualStyleBackColor = False
        '
        'btnI
        '
        Me.btnI.BackColor = System.Drawing.Color.Goldenrod
        Me.btnI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnI.ForeColor = System.Drawing.Color.DarkRed
        Me.btnI.Location = New System.Drawing.Point(435, 354)
        Me.btnI.Name = "btnI"
        Me.btnI.Size = New System.Drawing.Size(46, 43)
        Me.btnI.TabIndex = 14
        Me.btnI.Text = "I"
        Me.btnI.UseVisualStyleBackColor = False
        '
        'btnO
        '
        Me.btnO.BackColor = System.Drawing.Color.Goldenrod
        Me.btnO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnO.ForeColor = System.Drawing.Color.DarkRed
        Me.btnO.Location = New System.Drawing.Point(487, 354)
        Me.btnO.Name = "btnO"
        Me.btnO.Size = New System.Drawing.Size(46, 43)
        Me.btnO.TabIndex = 15
        Me.btnO.Text = "O"
        Me.btnO.UseVisualStyleBackColor = False
        '
        'btnP
        '
        Me.btnP.BackColor = System.Drawing.Color.Goldenrod
        Me.btnP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnP.ForeColor = System.Drawing.Color.DarkRed
        Me.btnP.Location = New System.Drawing.Point(539, 354)
        Me.btnP.Name = "btnP"
        Me.btnP.Size = New System.Drawing.Size(46, 43)
        Me.btnP.TabIndex = 16
        Me.btnP.Text = "P"
        Me.btnP.UseVisualStyleBackColor = False
        '
        'btnA
        '
        Me.btnA.BackColor = System.Drawing.Color.Goldenrod
        Me.btnA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnA.ForeColor = System.Drawing.Color.DarkRed
        Me.btnA.Location = New System.Drawing.Point(89, 403)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(46, 43)
        Me.btnA.TabIndex = 17
        Me.btnA.Text = "A"
        Me.btnA.UseVisualStyleBackColor = False
        '
        'btnS
        '
        Me.btnS.BackColor = System.Drawing.Color.Goldenrod
        Me.btnS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnS.ForeColor = System.Drawing.Color.DarkRed
        Me.btnS.Location = New System.Drawing.Point(141, 403)
        Me.btnS.Name = "btnS"
        Me.btnS.Size = New System.Drawing.Size(46, 43)
        Me.btnS.TabIndex = 18
        Me.btnS.Text = "S"
        Me.btnS.UseVisualStyleBackColor = False
        '
        'btnD
        '
        Me.btnD.BackColor = System.Drawing.Color.Goldenrod
        Me.btnD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnD.ForeColor = System.Drawing.Color.DarkRed
        Me.btnD.Location = New System.Drawing.Point(193, 403)
        Me.btnD.Name = "btnD"
        Me.btnD.Size = New System.Drawing.Size(46, 43)
        Me.btnD.TabIndex = 19
        Me.btnD.Text = "D"
        Me.btnD.UseVisualStyleBackColor = False
        '
        'btnF
        '
        Me.btnF.BackColor = System.Drawing.Color.Goldenrod
        Me.btnF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnF.ForeColor = System.Drawing.Color.DarkRed
        Me.btnF.Location = New System.Drawing.Point(245, 403)
        Me.btnF.Name = "btnF"
        Me.btnF.Size = New System.Drawing.Size(46, 43)
        Me.btnF.TabIndex = 20
        Me.btnF.Text = "F"
        Me.btnF.UseVisualStyleBackColor = False
        '
        'btnG
        '
        Me.btnG.BackColor = System.Drawing.Color.Goldenrod
        Me.btnG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnG.ForeColor = System.Drawing.Color.DarkRed
        Me.btnG.Location = New System.Drawing.Point(297, 403)
        Me.btnG.Name = "btnG"
        Me.btnG.Size = New System.Drawing.Size(46, 43)
        Me.btnG.TabIndex = 21
        Me.btnG.Text = "G"
        Me.btnG.UseVisualStyleBackColor = False
        '
        'btnH
        '
        Me.btnH.BackColor = System.Drawing.Color.Goldenrod
        Me.btnH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnH.ForeColor = System.Drawing.Color.DarkRed
        Me.btnH.Location = New System.Drawing.Point(349, 403)
        Me.btnH.Name = "btnH"
        Me.btnH.Size = New System.Drawing.Size(46, 43)
        Me.btnH.TabIndex = 22
        Me.btnH.Text = "H"
        Me.btnH.UseVisualStyleBackColor = False
        '
        'btnJ
        '
        Me.btnJ.BackColor = System.Drawing.Color.Goldenrod
        Me.btnJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJ.ForeColor = System.Drawing.Color.DarkRed
        Me.btnJ.Location = New System.Drawing.Point(401, 403)
        Me.btnJ.Name = "btnJ"
        Me.btnJ.Size = New System.Drawing.Size(46, 43)
        Me.btnJ.TabIndex = 23
        Me.btnJ.Text = "J"
        Me.btnJ.UseVisualStyleBackColor = False
        '
        'btnK
        '
        Me.btnK.BackColor = System.Drawing.Color.Goldenrod
        Me.btnK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnK.ForeColor = System.Drawing.Color.DarkRed
        Me.btnK.Location = New System.Drawing.Point(453, 403)
        Me.btnK.Name = "btnK"
        Me.btnK.Size = New System.Drawing.Size(46, 43)
        Me.btnK.TabIndex = 24
        Me.btnK.Text = "K"
        Me.btnK.UseVisualStyleBackColor = False
        '
        'btnL
        '
        Me.btnL.BackColor = System.Drawing.Color.Goldenrod
        Me.btnL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnL.ForeColor = System.Drawing.Color.DarkRed
        Me.btnL.Location = New System.Drawing.Point(505, 403)
        Me.btnL.Name = "btnL"
        Me.btnL.Size = New System.Drawing.Size(46, 43)
        Me.btnL.TabIndex = 25
        Me.btnL.Text = "L"
        Me.btnL.UseVisualStyleBackColor = False
        '
        'btnZ
        '
        Me.btnZ.BackColor = System.Drawing.Color.Goldenrod
        Me.btnZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZ.ForeColor = System.Drawing.Color.DarkRed
        Me.btnZ.Location = New System.Drawing.Point(119, 452)
        Me.btnZ.Name = "btnZ"
        Me.btnZ.Size = New System.Drawing.Size(46, 43)
        Me.btnZ.TabIndex = 26
        Me.btnZ.Text = "Z"
        Me.btnZ.UseVisualStyleBackColor = False
        '
        'btnX
        '
        Me.btnX.BackColor = System.Drawing.Color.Goldenrod
        Me.btnX.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnX.ForeColor = System.Drawing.Color.DarkRed
        Me.btnX.Location = New System.Drawing.Point(171, 452)
        Me.btnX.Name = "btnX"
        Me.btnX.Size = New System.Drawing.Size(46, 43)
        Me.btnX.TabIndex = 27
        Me.btnX.Text = "X"
        Me.btnX.UseVisualStyleBackColor = False
        '
        'btnC
        '
        Me.btnC.BackColor = System.Drawing.Color.Goldenrod
        Me.btnC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC.ForeColor = System.Drawing.Color.DarkRed
        Me.btnC.Location = New System.Drawing.Point(223, 452)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(46, 43)
        Me.btnC.TabIndex = 28
        Me.btnC.Text = "C"
        Me.btnC.UseVisualStyleBackColor = False
        '
        'btnV
        '
        Me.btnV.BackColor = System.Drawing.Color.Goldenrod
        Me.btnV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnV.ForeColor = System.Drawing.Color.DarkRed
        Me.btnV.Location = New System.Drawing.Point(275, 452)
        Me.btnV.Name = "btnV"
        Me.btnV.Size = New System.Drawing.Size(46, 43)
        Me.btnV.TabIndex = 29
        Me.btnV.Text = "V"
        Me.btnV.UseVisualStyleBackColor = False
        '
        'btnB
        '
        Me.btnB.BackColor = System.Drawing.Color.Goldenrod
        Me.btnB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnB.ForeColor = System.Drawing.Color.DarkRed
        Me.btnB.Location = New System.Drawing.Point(327, 452)
        Me.btnB.Name = "btnB"
        Me.btnB.Size = New System.Drawing.Size(46, 43)
        Me.btnB.TabIndex = 30
        Me.btnB.Text = "B"
        Me.btnB.UseVisualStyleBackColor = False
        '
        'btnN
        '
        Me.btnN.BackColor = System.Drawing.Color.Goldenrod
        Me.btnN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnN.ForeColor = System.Drawing.Color.DarkRed
        Me.btnN.Location = New System.Drawing.Point(381, 452)
        Me.btnN.Name = "btnN"
        Me.btnN.Size = New System.Drawing.Size(46, 43)
        Me.btnN.TabIndex = 31
        Me.btnN.Text = "N"
        Me.btnN.UseVisualStyleBackColor = False
        '
        'btnM
        '
        Me.btnM.BackColor = System.Drawing.Color.Goldenrod
        Me.btnM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnM.ForeColor = System.Drawing.Color.DarkRed
        Me.btnM.Location = New System.Drawing.Point(433, 452)
        Me.btnM.Name = "btnM"
        Me.btnM.Size = New System.Drawing.Size(46, 43)
        Me.btnM.TabIndex = 32
        Me.btnM.Text = "M"
        Me.btnM.UseVisualStyleBackColor = False
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(592, 80)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(150, 80)
        Me.lblInstructions.TabIndex = 33
        Me.lblInstructions.Text = "Select a letter from " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the keyboard below" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "*  Guess Correct (green)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "*  Guess Wro" &
    "ng   (Red)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    6 tries to get correct" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblInst
        '
        Me.lblInst.AutoSize = True
        Me.lblInst.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInst.Location = New System.Drawing.Point(608, 46)
        Me.lblInst.Name = "lblInst"
        Me.lblInst.Size = New System.Drawing.Size(109, 16)
        Me.lblInst.TabIndex = 34
        Me.lblInst.Text = "INSTRUCTIONS"
        Me.lblInst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmHangman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(747, 509)
        Me.Controls.Add(Me.lblInst)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnM)
        Me.Controls.Add(Me.btnN)
        Me.Controls.Add(Me.btnB)
        Me.Controls.Add(Me.btnV)
        Me.Controls.Add(Me.btnC)
        Me.Controls.Add(Me.btnX)
        Me.Controls.Add(Me.btnZ)
        Me.Controls.Add(Me.btnL)
        Me.Controls.Add(Me.btnK)
        Me.Controls.Add(Me.btnJ)
        Me.Controls.Add(Me.btnH)
        Me.Controls.Add(Me.btnG)
        Me.Controls.Add(Me.btnF)
        Me.Controls.Add(Me.btnD)
        Me.Controls.Add(Me.btnS)
        Me.Controls.Add(Me.btnA)
        Me.Controls.Add(Me.btnP)
        Me.Controls.Add(Me.btnO)
        Me.Controls.Add(Me.btnI)
        Me.Controls.Add(Me.btnU)
        Me.Controls.Add(Me.btnY)
        Me.Controls.Add(Me.btnT)
        Me.Controls.Add(Me.btnR)
        Me.Controls.Add(Me.btnNextWord)
        Me.Controls.Add(Me.btnE)
        Me.Controls.Add(Me.btnW)
        Me.Controls.Add(Me.btnQ)
        Me.Controls.Add(Me.picHangMan)
        Me.Controls.Add(Me.txtWord)
        Me.Controls.Add(Me.txtAttempts)
        Me.Controls.Add(Me.lblAttempts)
        Me.Controls.Add(Me.lblCategoy)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmHangman"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hangman"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picHangMan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblCategoy As Label
    Friend WithEvents lblAttempts As Label
    Friend WithEvents txtAttempts As TextBox
    Friend WithEvents txtWord As TextBox
    Friend WithEvents picHangMan As PictureBox
    Friend WithEvents ImageListHangmanPic As ImageList
    Friend WithEvents btnQ As Button
    Friend WithEvents btnW As Button
    Friend WithEvents btnE As Button
    Friend WithEvents btnNextWord As Button
    Friend WithEvents btnR As Button
    Friend WithEvents btnT As Button
    Friend WithEvents btnY As Button
    Friend WithEvents btnU As Button
    Friend WithEvents btnI As Button
    Friend WithEvents btnO As Button
    Friend WithEvents btnP As Button
    Friend WithEvents btnA As Button
    Friend WithEvents btnS As Button
    Friend WithEvents btnD As Button
    Friend WithEvents btnF As Button
    Friend WithEvents btnG As Button
    Friend WithEvents btnH As Button
    Friend WithEvents btnJ As Button
    Friend WithEvents btnK As Button
    Friend WithEvents btnL As Button
    Friend WithEvents btnZ As Button
    Friend WithEvents btnX As Button
    Friend WithEvents btnC As Button
    Friend WithEvents btnV As Button
    Friend WithEvents btnB As Button
    Friend WithEvents btnN As Button
    Friend WithEvents btnM As Button
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblInst As Label
End Class
