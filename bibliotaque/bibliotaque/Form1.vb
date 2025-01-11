Imports Microsoft.SqlServer.Server

Public Class Form1

    Public Sub placeForm(app As Form)
        Panel1.Controls.Clear()
        app.TopLevel = False
        app.FormBorderStyle = FormBorderStyle.None
        app.Dock = DockStyle.Fill
        Panel1.Controls.Add(app)
        app.Show()
    End Sub

    Private Sub AjouterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjouterToolStripMenuItem.Click
        placeForm(Form2)

    End Sub

    Private Sub ListOfBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListOfBooksToolStripMenuItem.Click
        placeForm(Form4)
    End Sub

    Private Sub AffivhageDetailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AffivhageDetailToolStripMenuItem.Click
        placeForm(Form3)
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        placeForm(Form2)
    End Sub
End Class