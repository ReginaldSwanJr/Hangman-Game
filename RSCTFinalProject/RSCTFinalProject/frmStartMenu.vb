Public Class frmStartMenu
    Private Sub frmStartMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        ' When clicked the form Categories launches
        Dim formCategories As New frmCategories
        Hide()
        formCategories.ShowDialog()

    End Sub
End Class
