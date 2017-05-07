Public Class frmHangman
    Dim numGuesses As Integer = 0
    Dim attemptsRemaining As Integer = 6
    Dim msgOne = "You Lost Do You Wish To Contiue?"
    Dim msgTwo = "Congratulations You Guessed It"
    Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2
    Dim letter As String
    Dim array As Char()
    Dim theWord As String
    Dim chkWord As String
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub frmHangman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        theWord = frmCategories._word
        For position As Integer = 0 To theWord.Length - 1
            txtWord.Text = txtWord.Text & "-"
        Next
        chkWord = theWord.Replace(" ", "-")
        array = theWord.Replace(" ", "-").ToCharArray()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtWord.TextChanged

    End Sub

    Private Sub btnNextWord_Click(sender As Object, e As EventArgs) Handles btnNextWord.Click
        Dim frmHangman As New frmHangman
        Dim frmCategories As New frmCategories
        Dim newWord = frmCategories._picked
        Dim lblWord = frmCategories._categorie
        frmCategories.Pick(newWord)
        frmHangman.lblCategoy.Text = lblWord
        Hide()
        frmHangman.ShowDialog()
    End Sub

    Sub checkWord(ByVal Word As String)
        ' This sub prodcedure checks if the string word is equal to the selected word
        If Word = chkWord Then
            MsgBox(msgTwo)
            btnNextWord.Visible = True
        End If
    End Sub

    Sub checkAttempts(ByVal attempt As Integer)
        If attempt = 0 Then
            txtWord.Text = chkWord
            Dim response = MsgBox(msgOne, style)
            If response = MsgBoxResult.Yes Then
                Dim frmHangman As New frmHangman
                Dim frmCategories As New frmCategories
                Dim lblWord = frmCategories._categorie
                Dim newWord = frmCategories._picked
                frmCategories.Pick(newWord)
                frmHangman.lblCategoy.Text = lblWord
                Hide()
                frmHangman.ShowDialog()
            Else
                Dim categories As New frmCategories
                Hide()
                categories.ShowDialog()
            End If
        End If
    End Sub


    ' FIRST ROW
    Private Sub btnQ_Click(sender As Object, e As EventArgs) Handles btnQ.Click
        letter = "Q"
        Dim found As Boolean = False
        For i As Integer = 0 To Integer.Parse(array.Length - 1)
            If array(i) = letter Then
                txtWord.Text = txtWord.Text.Remove(i, 1)
                txtWord.Text = txtWord.Text.Insert(i, letter)
                btnQ.ForeColor = Color.LawnGreen
                btnQ.BackColor = Color.Gray
                found = True
            End If
        Next
        If found = False Then
            MsgBox("Wrong Guess Guess Again")
            picHangMan.Image = ImageListHangmanPic.Images(numGuesses)
            txtAttempts.Text = attemptsRemaining - 1
            numGuesses = numGuesses + 1
            attemptsRemaining = Convert.ToInt32(txtAttempts.Text)
            btnQ.ForeColor = Color.Red
            btnQ.BackColor = Color.Gray
        End If
        checkWord(txtWord.Text)
        checkAttempts(attemptsRemaining)
    End Sub

    Private Sub btnW_Click(sender As Object, e As EventArgs) Handles btnW.Click
        letter = "W"
        Dim found As Boolean = False
        For i As Integer = 0 To Integer.Parse(array.Length - 1)
            If array(i) = letter Then
                txtWord.Text = txtWord.Text.Remove(i, 1)
                txtWord.Text = txtWord.Text.Insert(i, letter)
                btnW.ForeColor = Color.LawnGreen
                btnW.BackColor = Color.Gray
                found = True
            End If
        Next
        If found = False Then
            MsgBox("Wrong Guess Guess Again")
            picHangMan.Image = ImageListHangmanPic.Images(numGuesses)
            txtAttempts.Text = attemptsRemaining - 1
            numGuesses = numGuesses + 1
            attemptsRemaining = Convert.ToInt32(txtAttempts.Text)
            btnW.ForeColor = Color.Red
            btnW.BackColor = Color.Gray
        End If
        checkWord(txtWord.Text)
        checkAttempts(attemptsRemaining)
    End Sub

    Private Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        letter = "E"
        Dim found As Boolean = False
        For i As Integer = 0 To Integer.Parse(array.Length - 1)
            If array(i) = letter Then
                txtWord.Text = txtWord.Text.Remove(i, 1)
                txtWord.Text = txtWord.Text.Insert(i, letter)
                btnE.ForeColor = Color.LawnGreen
                btnE.BackColor = Color.Gray
                found = True
            End If
        Next
        If found = False Then
            MsgBox("Wrong Guess Guess Again")
            picHangMan.Image = ImageListHangmanPic.Images(numGuesses)
            txtAttempts.Text = attemptsRemaining - 1
            numGuesses = numGuesses + 1
            attemptsRemaining = Convert.ToInt32(txtAttempts.Text)
            btnE.ForeColor = Color.Red
            btnE.BackColor = Color.Gray
        End If
        checkWord(txtWord.Text)
        checkAttempts(attemptsRemaining)
    End Sub

    Private Sub btnR_Click(sender As Object, e As EventArgs) Handles btnR.Click
        letter = "R"
        Dim found As Boolean = False
        For i As Integer = 0 To Integer.Parse(array.Length - 1)
            If array(i) = letter Then
                txtWord.Text = txtWord.Text.Remove(i, 1)
                txtWord.Text = txtWord.Text.Insert(i, letter)
                btnR.ForeColor = Color.LawnGreen
                btnR.BackColor = Color.Gray
                found = True
            End If
        Next
        If found = False Then
            MsgBox("Wrong Guess Guess Again")
            picHangMan.Image = ImageListHangmanPic.Images(numGuesses)
            txtAttempts.Text = attemptsRemaining - 1
            numGuesses = numGuesses + 1
            attemptsRemaining = Convert.ToInt32(txtAttempts.Text)
            btnR.ForeColor = Color.Red
            btnR.BackColor = Color.Gray
        End If
        checkWord(txtWord.Text)
        checkAttempts(attemptsRemaining)
    End Sub

    Private Sub btnT_Click(sender As Object, e As EventArgs) Handles btnT.Click
        letter = "T"
        Dim found As Boolean = False
        For i As Integer = 0 To Integer.Parse(array.Length - 1)
            If array(i) = letter Then
                txtWord.Text = txtWord.Text.Remove(i, 1)
                txtWord.Text = txtWord.Text.Insert(i, letter)
                btnT.ForeColor = Color.LawnGreen
                btnT.BackColor = Color.Gray
                found = True
            End If
        Next
        If found = False Then
            MsgBox("Wrong Guess Guess Again")
            picHangMan.Image = ImageListHangmanPic.Images(numGuesses)
            txtAttempts.Text = attemptsRemaining - 1
            numGuesses = numGuesses + 1
            attemptsRemaining = Convert.ToInt32(txtAttempts.Text)
            btnT.ForeColor = Color.Red
            btnT.BackColor = Color.Gray
        End If
        checkWord(txtWord.Text)
        checkAttempts(attemptsRemaining)
    End Sub

    Private Sub btnY_Click(sender As Object, e As EventArgs) Handles btnY.Click
        letter = "Y"
        Dim found As Boolean = False
        For i As Integer = 0 To Integer.Parse(array.Length - 1)
            If array(i) = letter Then
                txtWord.Text = txtWord.Text.Remove(i, 1)
                txtWord.Text = txtWord.Text.Insert(i, letter)
                btnY.ForeColor = Color.LawnGreen
                btnY.BackColor = Color.Gray
                found = True
            End If
        Next
        If found = False Then
            MsgBox("Wrong Guess Guess Again")
            picHangMan.Image = ImageListHangmanPic.Images(numGuesses)
            txtAttempts.Text = attemptsRemaining - 1
            numGuesses = numGuesses + 1
            attemptsRemaining = Convert.ToInt32(txtAttempts.Text)
            btnY.ForeColor = Color.Red
            btnY.BackColor = Color.Gray
        End If
        checkWord(txtWord.Text)
        checkAttempts(attemptsRemaining)
    End Sub

    Private Sub btnU_Click(sender As Object, e As EventArgs) Handles btnU.Click
        letter = "U"
        Dim found As Boolean = False
        For i As Integer = 0 To Integer.Parse(array.Length - 1)
            If array(i) = letter Then
                txtWord.Text = txtWord.Text.Remove(i, 1)
                txtWord.Text = txtWord.Text.Insert(i, letter)
                btnU.ForeColor = Color.LawnGreen
                btnU.BackColor = Color.Gray
                found = True
            End If
        Next
        If found = False Then
            MsgBox("Wrong Guess Guess Again")
            picHangMan.Image = ImageListHangmanPic.Images(numGuesses)
            txtAttempts.Text = attemptsRemaining - 1
            numGuesses = numGuesses + 1
            attemptsRemaining = Convert.ToInt32(txtAttempts.Text)
            btnU.ForeColor = Color.Red
            btnU.BackColor = Color.Gray
        End If
        checkWord(txtWord.Text)
        checkAttempts(attemptsRemaining)
    End Sub

    Private Sub btnI_Click(sender As Object, e As EventArgs) Handles btnI.Click
        letter = "I"
        Dim found As Boolean = False
        For i As Integer = 0 To Integer.Parse(array.Length - 1)
            If array(i) = letter Then
                txtWord.Text = txtWord.Text.Remove(i, 1)
                txtWord.Text = txtWord.Text.Insert(i, letter)
                btnI.ForeColor = Color.LawnGreen
                btnI.BackColor = Color.Gray
                found = True
            End If
        Next
        If found = False Then
            MsgBox("Wrong Guess Guess Again")
            picHangMan.Image = ImageListHangmanPic.Images(numGuesses)
            txtAttempts.Text = attemptsRemaining - 1
            numGuesses = numGuesses + 1
            attemptsRemaining = Convert.ToInt32(txtAttempts.Text)
            btnI.ForeColor = Color.Red
            btnI.BackColor = Color.Gray
        End If
        checkWord(txtWord.Text)
        checkAttempts(attemptsRemaining)
    End Sub

    Private Sub btnO_Click(sender As Object, e As EventArgs) Handles btnO.Click
        letter = "O"
        Dim found As Boolean = False
        For i As Integer = 0 To Integer.Parse(array.Length - 1)
            If array(i) = letter Then
                txtWord.Text = txtWord.Text.Remove(i, 1)
                txtWord.Text = txtWord.Text.Insert(i, letter)
                btnO.ForeColor = Color.LawnGreen
                btnO.BackColor = Color.Gray
                found = True
            End If
        Next
        If found = False Then
            MsgBox("Wrong Guess Guess Again")
            picHangMan.Image = ImageListHangmanPic.Images(numGuesses)
            txtAttempts.Text = attemptsRemaining - 1
            numGuesses = numGuesses + 1
            attemptsRemaining = Convert.ToInt32(txtAttempts.Text)
            btnO.ForeColor = Color.Red
            btnO.BackColor = Color.Gray
        End If
        checkWord(txtWord.Text)
        checkAttempts(attemptsRemaining)
    End Sub

    Private Sub btnP_Click(sender As Object, e As EventArgs) Handles btnP.Click
        letter = "P"
        Dim found As Boolean = False
        For i As Integer = 0 To Integer.Parse(array.Length - 1)
            If array(i) = letter Then
                txtWord.Text = txtWord.Text.Remove(i, 1)
                txtWord.Text = txtWord.Text.Insert(i, letter)
                btnP.ForeColor = Color.LawnGreen
                btnP.BackColor = Color.Gray
                found = True
            End If
        Next
        If found = False Then
            MsgBox("Wrong Guess Guess Again")
            picHangMan.Image = ImageListHangmanPic.Images(numGuesses)
            txtAttempts.Text = attemptsRemaining - 1
            numGuesses = numGuesses + 1
            attemptsRemaining = Convert.ToInt32(txtAttempts.Text)
            btnP.ForeColor = Color.Red
            btnP.BackColor = Color.Gray
        End If
        checkWord(txtWord.Text)
        checkAttempts(attemptsRemaining)
    End Sub


    ' SECOND ROW
    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        letter = "A"
        Dim found As Boolean = False
        For i As Integer = 0 To Integer.Parse(array.Length - 1)
            If array(i) = letter Then
                txtWord.Text = txtWord.Text.Remove(i, 1)
                txtWord.Text = txtWord.Text.Insert(i, letter)
                btnA.ForeColor = Color.LawnGreen
                btnA.BackColor = Color.Gray
                found = True
            End If
        Next
        If found = False Then
            MsgBox("Wrong Guess Guess Again")
            picHangMan.Image = ImageListHangmanPic.Images(numGuesses)
            txtAttempts.Text = attemptsRemaining - 1
            numGuesses = numGuesses + 1
            attemptsRemaining = Convert.ToInt32(txtAttempts.Text)
            btnA.ForeColor = Color.Red
            btnA.BackColor = Color.Gray
        End If
        checkWord(txtWord.Text)
        checkAttempts(attemptsRemaining)
    End Sub

    Private Sub btnS_Click(sender As Object, e As EventArgs) Handles btnS.Click
        letter = "S"
        Dim found As Boolean = False
        For i As Integer = 0 To Integer.Parse(array.Length - 1)
            If array(i) = letter Then
                txtWord.Text = txtWord.Text.Remove(i, 1)
                txtWord.Text = txtWord.Text.Insert(i, letter)
                btnS.ForeColor = Color.LawnGreen
                btnS.BackColor = Color.Gray
                found = True
            End If
        Next
        If found = False Then
            MsgBox("Wrong Guess Guess Again")
            picHangMan.Image = ImageListHangmanPic.Images(numGuesses)
            txtAttempts.Text = attemptsRemaining - 1
            numGuesses = numGuesses + 1
            attemptsRemaining = Convert.ToInt32(txtAttempts.Text)
            btnS.ForeColor = Color.Red
            btnS.BackColor = Color.Gray
        End If
        checkWord(txtWord.Text)
        checkAttempts(attemptsRemaining)
    End Sub

    Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        letter = "D"
        Dim found As Boolean = False
        For i As Integer = 0 To Integer.Parse(array.Length - 1)
            If array(i) = letter Then
                txtWord.Text = txtWord.Text.Remove(i, 1)
                txtWord.Text = txtWord.Text.Insert(i, letter)
                btnD.ForeColor = Color.LawnGreen
                btnD.BackColor = Color.Gray
                found = True
            End If
        Next
        If found = False Then
            MsgBox("Wrong Guess Guess Again")
            picHangMan.Image = ImageListHangmanPic.Images(numGuesses)
            txtAttempts.Text = attemptsRemaining - 1
            numGuesses = numGuesses + 1
            attemptsRemaining = Convert.ToInt32(txtAttempts.Text)
            btnD.ForeColor = Color.Red
            btnD.BackColor = Color.Gray
        End If
        checkWord(txtWord.Text)
        checkAttempts(attemptsRemaining)
    End Sub

    Private Sub btnF_Click(sender As Object, e As EventArgs) Handles btnF.Click
        letter = "F"
        Dim found As Boolean = False
        For i As Integer = 0 To Integer.Parse(array.Length - 1)
            If array(i) = letter Then
                txtWord.Text = txtWord.Text.Remove(i, 1)
                txtWord.Text = txtWord.Text.Insert(i, letter)
                btnF.ForeColor = Color.LawnGreen
                btnF.BackColor = Color.Gray
                found = True
            End If
        Next
        If found = False Then
            MsgBox("Wrong Guess Guess Again")
            picHangMan.Image = ImageListHangmanPic.Images(numGuesses)
            txtAttempts.Text = attemptsRemaining - 1
            numGuesses = numGuesses + 1
            attemptsRemaining = Convert.ToInt32(txtAttempts.Text)
            btnF.ForeColor = Color.Red
            btnF.BackColor = Color.Gray
        End If
        checkWord(txtWord.Text)
        checkAttempts(attemptsRemaining)
    End Sub

    Private Sub btnG_Click(sender As Object, e As EventArgs) Handles btnG.Click
        letter = "G"
        Dim found As Boolean = False
        For i As Integer = 0 To Integer.Parse(array.Length - 1)
            If array(i) = letter Then
                txtWord.Text = txtWord.Text.Remove(i, 1)
                txtWord.Text = txtWord.Text.Insert(i, letter)
                btnG.ForeColor = Color.LawnGreen
                btnG.BackColor = Color.Gray
                found = True
            End If
        Next
        If found = False Then
            MsgBox("Wrong Guess Guess Again")
            picHangMan.Image = ImageListHangmanPic.Images(numGuesses)
            txtAttempts.Text = attemptsRemaining - 1
            numGuesses = numGuesses + 1
            attemptsRemaining = Convert.ToInt32(txtAttempts.Text)
            btnG.ForeColor = Color.Red
            btnG.BackColor = Color.Gray
        End If
        checkWord(txtWord.Text)
        checkAttempts(attemptsRemaining)
    End Sub

    Private Sub btnH_Click(sender As Object, e As EventArgs) Handles btnH.Click
        letter = "H"
        Dim found As Boolean = False
        For i As Integer = 0 To Integer.Parse(array.Length - 1)
            If array(i) = letter Then
                txtWord.Text = txtWord.Text.Remove(i, 1)
                txtWord.Text = txtWord.Text.Insert(i, letter)
                btnH.ForeColor = Color.LawnGreen
                btnH.BackColor = Color.Gray
                found = True
            End If
        Next
        If found = False Then
            MsgBox("Wrong Guess Guess Again")
            picHangMan.Image = ImageListHangmanPic.Images(numGuesses)
            txtAttempts.Text = attemptsRemaining - 1
            numGuesses = numGuesses + 1
            attemptsRemaining = Convert.ToInt32(txtAttempts.Text)
            btnH.ForeColor = Color.Red
            btnH.BackColor = Color.Gray
        End If
        checkWord(txtWord.Text)
        checkAttempts(attemptsRemaining)
    End Sub

    Private Sub btnJ_Click(sender As Object, e As EventArgs) Handles btnJ.Click
        letter = "J"
        Dim found As Boolean = False
        For i As Integer = 0 To Integer.Parse(array.Length - 1)
            If array(i) = letter Then
                txtWord.Text = txtWord.Text.Remove(i, 1)
                txtWord.Text = txtWord.Text.Insert(i, letter)
                btnJ.ForeColor = Color.LawnGreen
                btnJ.BackColor = Color.Gray
                found = True
            End If
        Next
        If found = False Then
            MsgBox("Wrong Guess Guess Again")
            picHangMan.Image = ImageListHangmanPic.Images(numGuesses)
            txtAttempts.Text = attemptsRemaining - 1
            numGuesses = numGuesses + 1
            attemptsRemaining = Convert.ToInt32(txtAttempts.Text)
            btnJ.ForeColor = Color.Red
            btnJ.BackColor = Color.Gray
        End If
        checkWord(txtWord.Text)
        checkAttempts(attemptsRemaining)
    End Sub

    Private Sub btnK_Click(sender As Object, e As EventArgs) Handles btnK.Click
        letter = "K"
        Dim found As Boolean = False
        For i As Integer = 0 To Integer.Parse(array.Length - 1)
            If array(i) = letter Then
                txtWord.Text = txtWord.Text.Remove(i, 1)
                txtWord.Text = txtWord.Text.Insert(i, letter)
                btnK.ForeColor = Color.LawnGreen
                btnK.BackColor = Color.Gray
                found = True
            End If
        Next
        If found = False Then
            MsgBox("Wrong Guess Guess Again")
            picHangMan.Image = ImageListHangmanPic.Images(numGuesses)
            txtAttempts.Text = attemptsRemaining - 1
            numGuesses = numGuesses + 1
            attemptsRemaining = Convert.ToInt32(txtAttempts.Text)
            btnK.ForeColor = Color.Red
            btnK.BackColor = Color.Gray
        End If
        checkWord(txtWord.Text)
        checkAttempts(attemptsRemaining)
    End Sub

    Private Sub btnL_Click(sender As Object, e As EventArgs) Handles btnL.Click
        letter = "L"
        Dim found As Boolean = False
        For i As Integer = 0 To Integer.Parse(array.Length - 1)
            If array(i) = letter Then
                txtWord.Text = txtWord.Text.Remove(i, 1)
                txtWord.Text = txtWord.Text.Insert(i, letter)
                btnL.ForeColor = Color.LawnGreen
                btnL.BackColor = Color.Gray
                found = True
            End If
        Next
        If found = False Then
            MsgBox("Wrong Guess Guess Again")
            picHangMan.Image = ImageListHangmanPic.Images(numGuesses)
            txtAttempts.Text = attemptsRemaining - 1
            numGuesses = numGuesses + 1
            attemptsRemaining = Convert.ToInt32(txtAttempts.Text)
            btnL.ForeColor = Color.Red
            btnL.BackColor = Color.Gray
        End If
        checkWord(txtWord.Text)
        checkAttempts(attemptsRemaining)
    End Sub

    ' THIRD ROW
    Private Sub btnZ_Click(sender As Object, e As EventArgs) Handles btnZ.Click
        letter = "Z"
        Dim found As Boolean = False
        For i As Integer = 0 To Integer.Parse(array.Length - 1)
            If array(i) = letter Then
                txtWord.Text = txtWord.Text.Remove(i, 1)
                txtWord.Text = txtWord.Text.Insert(i, letter)
                btnZ.ForeColor = Color.LawnGreen
                btnZ.BackColor = Color.Gray
                found = True
            End If
        Next
        If found = False Then
            MsgBox("Wrong Guess Guess Again")
            picHangMan.Image = ImageListHangmanPic.Images(numGuesses)
            txtAttempts.Text = attemptsRemaining - 1
            numGuesses = numGuesses + 1
            attemptsRemaining = Convert.ToInt32(txtAttempts.Text)
            btnZ.ForeColor = Color.Red
            btnZ.BackColor = Color.Gray
        End If
        checkWord(txtWord.Text)
        checkAttempts(attemptsRemaining)
    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        letter = "X"
        Dim found As Boolean = False
        For i As Integer = 0 To Integer.Parse(array.Length - 1)
            If array(i) = letter Then
                txtWord.Text = txtWord.Text.Remove(i, 1)
                txtWord.Text = txtWord.Text.Insert(i, letter)
                btnX.ForeColor = Color.LawnGreen
                btnX.BackColor = Color.Gray
                found = True
            End If
        Next
        If found = False Then
            MsgBox("Wrong Guess Guess Again")
            picHangMan.Image = ImageListHangmanPic.Images(numGuesses)
            txtAttempts.Text = attemptsRemaining - 1
            numGuesses = numGuesses + 1
            attemptsRemaining = Convert.ToInt32(txtAttempts.Text)
            btnX.ForeColor = Color.Red
            btnX.BackColor = Color.Gray
        End If
        checkWord(txtWord.Text)
        checkAttempts(attemptsRemaining)
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        letter = "C"
        Dim found As Boolean = False
        For i As Integer = 0 To Integer.Parse(array.Length - 1)
            If array(i) = letter Then
                txtWord.Text = txtWord.Text.Remove(i, 1)
                txtWord.Text = txtWord.Text.Insert(i, letter)
                btnC.ForeColor = Color.LawnGreen
                btnC.BackColor = Color.Gray
                found = True
            End If
        Next
        If found = False Then
            MsgBox("Wrong Guess Guess Again")
            picHangMan.Image = ImageListHangmanPic.Images(numGuesses)
            txtAttempts.Text = attemptsRemaining - 1
            numGuesses = numGuesses + 1
            attemptsRemaining = Convert.ToInt32(txtAttempts.Text)
            btnC.ForeColor = Color.Red
            btnC.BackColor = Color.Gray
        End If
        checkWord(txtWord.Text)
        checkAttempts(attemptsRemaining)
    End Sub

    Private Sub btnV_Click(sender As Object, e As EventArgs) Handles btnV.Click
        letter = "V"
        Dim found As Boolean = False
        For i As Integer = 0 To Integer.Parse(array.Length - 1)
            If array(i) = letter Then
                txtWord.Text = txtWord.Text.Remove(i, 1)
                txtWord.Text = txtWord.Text.Insert(i, letter)
                btnV.ForeColor = Color.LawnGreen
                btnV.BackColor = Color.Gray
                found = True
            End If
        Next
        If found = False Then
            MsgBox("Wrong Guess Guess Again")
            picHangMan.Image = ImageListHangmanPic.Images(numGuesses)
            txtAttempts.Text = attemptsRemaining - 1
            numGuesses = numGuesses + 1
            attemptsRemaining = Convert.ToInt32(txtAttempts.Text)
            btnV.ForeColor = Color.Red
            btnV.BackColor = Color.Gray
        End If
        checkWord(txtWord.Text)
        checkAttempts(attemptsRemaining)
    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        letter = "B"
        Dim found As Boolean = False
        For i As Integer = 0 To Integer.Parse(array.Length - 1)
            If array(i) = letter Then
                txtWord.Text = txtWord.Text.Remove(i, 1)
                txtWord.Text = txtWord.Text.Insert(i, letter)
                btnB.ForeColor = Color.LawnGreen
                btnB.BackColor = Color.Gray
                found = True
            End If
        Next
        If found = False Then
            MsgBox("Wrong Guess Guess Again")
            picHangMan.Image = ImageListHangmanPic.Images(numGuesses)
            txtAttempts.Text = attemptsRemaining - 1
            numGuesses = numGuesses + 1
            attemptsRemaining = Convert.ToInt32(txtAttempts.Text)
            btnB.ForeColor = Color.Red
            btnB.BackColor = Color.Gray
        End If
        checkWord(txtWord.Text)
        checkAttempts(attemptsRemaining)
    End Sub

    Private Sub btnN_Click(sender As Object, e As EventArgs) Handles btnN.Click
        letter = "N"
        Dim found As Boolean = False
        For i As Integer = 0 To Integer.Parse(array.Length - 1)
            If array(i) = letter Then
                txtWord.Text = txtWord.Text.Remove(i, 1)
                txtWord.Text = txtWord.Text.Insert(i, letter)
                btnN.ForeColor = Color.LawnGreen
                btnN.BackColor = Color.Gray
                found = True
            End If
        Next
        If found = False Then
            MsgBox("Wrong Guess Guess Again")
            picHangMan.Image = ImageListHangmanPic.Images(numGuesses)
            txtAttempts.Text = attemptsRemaining - 1
            numGuesses = numGuesses + 1
            attemptsRemaining = Convert.ToInt32(txtAttempts.Text)
            btnN.ForeColor = Color.Red
            btnN.BackColor = Color.Gray
        End If
        checkWord(txtWord.Text)
        checkAttempts(attemptsRemaining)
    End Sub

    Private Sub btnM_Click(sender As Object, e As EventArgs) Handles btnM.Click
        letter = "M"
        Dim found As Boolean = False
        For i As Integer = 0 To Integer.Parse(array.Length - 1)
            If array(i) = letter Then
                txtWord.Text = txtWord.Text.Remove(i, 1)
                txtWord.Text = txtWord.Text.Insert(i, letter)
                btnM.ForeColor = Color.LawnGreen
                btnM.BackColor = Color.Gray
                found = True
            End If
        Next
        If found = False Then
            MsgBox("Wrong Guess Guess Again")
            picHangMan.Image = ImageListHangmanPic.Images(numGuesses)
            txtAttempts.Text = attemptsRemaining - 1
            numGuesses = numGuesses + 1
            attemptsRemaining = Convert.ToInt32(txtAttempts.Text)
            btnM.ForeColor = Color.Red
            btnM.BackColor = Color.Gray
        End If
        checkWord(txtWord.Text)
        checkAttempts(attemptsRemaining)
    End Sub

    Private Sub CategoriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriesToolStripMenuItem.Click
        Dim frmCategories As New frmCategories
        Hide()
        frmCategories.ShowDialog()
    End Sub

    Private Sub lblInstructions_Click(sender As Object, e As EventArgs) Handles lblInstructions.Click

    End Sub
End Class