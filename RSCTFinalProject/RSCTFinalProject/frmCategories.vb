Public Class frmCategories
    Public Shared _word As String
    Public Shared _picked As String
    Dim frmHangman As New frmHangman
    Public Shared _categorie As String


    Public Shared fruit = "C:\Users\Reginald Swan Jr\Dropbox\skool\comp science\GUI\RS_CT_project\RSCTFinalProject\txtFiles\Fruits.txt"
    Public Shared sports = "C:\Users\Reginald Swan Jr\Dropbox\skool\comp science\GUI\RS_CT_project\RSCTFinalProject\txtFiles\Sports.txt"
    Public Shared colors = "C:\Users\Reginald Swan Jr\Dropbox\skool\comp science\GUI\RS_CT_project\RSCTFinalProject\txtFiles\Colors.txt"

    Public Shared animals = "C:\Users\Reginald Swan Jr\Dropbox\skool\comp science\GUI\RS_CT_project\RSCTFinalProject\txtFiles\Animals.txt"
    Public Shared marvelSH = "C:\Users\Reginald Swan Jr\Dropbox\skool\comp science\GUI\RS_CT_project\RSCTFinalProject\txtFiles\MarvelSuperHeroes.txt"
    Public Shared usStates = "C:\Users\Reginald Swan Jr\Dropbox\skool\comp science\GUI\RS_CT_project\RSCTFinalProject\txtFiles\UsStates.txt"

    Public Shared compParts = "C:\Users\Reginald Swan Jr\Dropbox\skool\comp science\GUI\RS_CT_project\RSCTFinalProject\txtFiles\compParts.txt"
    Public Shared harryPotter = "C:\Users\Reginald Swan Jr\Dropbox\skool\comp science\GUI\RS_CT_project\RSCTFinalProject\txtFiles\HarryPotter.txt"
    Public Shared greekAlphabet = "C:\Users\Reginald Swan Jr\Dropbox\skool\comp science\GUI\RS_CT_project\RSCTFinalProject\txtFiles\greekAlphabet.txt"


    Private Sub frmCategories_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub



    Public Sub Pick(ByVal location As String)
        Dim filereader As IO.StreamReader
        Dim list As New List(Of String)
        Dim random As New Random()
        Dim line As New Integer
        If IO.File.Exists(location) Then
            filereader = IO.File.OpenText(location)
            Do While filereader.Peek <> -1
                list.Add(filereader.ReadLine())
            Loop
        End If

        line = random.Next(0, list.Count - 1)
        _word = list(line)
    End Sub

    Private Sub btnSports_Click(sender As Object, e As EventArgs) Handles btnSports.Click
        _picked = sports
        _categorie = "Sports"
        Pick(sports)
        Hide()
        frmHangman.lblCategoy.Text = _categorie
        frmHangman.ShowDialog()
    End Sub

    Private Sub btnAnimals_Click(sender As Object, e As EventArgs) Handles btnAnimals.Click
        _picked = animals
        _categorie = "Animals"
        Pick(animals)
        Hide()
        frmHangman.lblCategoy.Text = _categorie
        frmHangman.ShowDialog()
    End Sub

    Private Sub btnGreek_Click(sender As Object, e As EventArgs) Handles btnGreek.Click
        _picked = greekAlphabet
        _categorie = "Greek Alphabet"
        Pick(greekAlphabet)
        Hide()
        frmHangman.lblCategoy.Text = _categorie
        frmHangman.ShowDialog()
    End Sub

    Private Sub btnUSStates_Click(sender As Object, e As EventArgs) Handles btnUSStates.Click
        _picked = usStates
        _categorie = "U.S. States"
        Pick(usStates)
        Hide()
        frmHangman.lblCategoy.Text = _categorie
        frmHangman.ShowDialog()
    End Sub

    Private Sub btnColors_Click(sender As Object, e As EventArgs) Handles btnColors.Click
        _picked = colors
        _categorie = "Colors"
        Pick(colors)
        Hide()
        frmHangman.lblCategoy.Text = _categorie
        frmHangman.ShowDialog()
    End Sub

    Private Sub btnCompParts_Click(sender As Object, e As EventArgs) Handles btnCompParts.Click
        _picked = compParts
        _categorie = "Computer Parts"
        Pick(compParts)
        Hide()
        frmHangman.lblCategoy.Text = _categorie
        frmHangman.ShowDialog()
    End Sub

    Private Sub btnLOTR_Click(sender As Object, e As EventArgs) Handles btnLOTR.Click
        _picked = harryPotter
        _categorie = "Harry Potter"
        Pick(harryPotter)
        Hide()
        frmHangman.lblCategoy.Text = _categorie
        frmHangman.ShowDialog()
    End Sub

    Private Sub btnFruit_Click(sender As Object, e As EventArgs) Handles btnFruit.Click
        _picked = fruit
        _categorie = "Fruit"
        Pick(fruit)
        Hide()
        frmHangman.lblCategoy.Text = _categorie
        frmHangman.ShowDialog()
    End Sub

    Private Sub btnSuperHeros_Click(sender As Object, e As EventArgs) Handles btnSuperHeros.Click
        _picked = marvelSH
        _categorie = "Marvel Super Heroes"
        Pick(marvelSH)
        Hide()
        frmHangman.lblCategoy.Text = _categorie
        frmHangman.ShowDialog()
    End Sub
End Class