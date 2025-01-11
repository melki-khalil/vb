Imports bibliotaque.Form2

Public Class Form4
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lV.View = View.Details
        lV.Columns.Add("Raw", 75)
        lV.Columns.Add("ISBN", 100)
        lV.Columns.Add("Titre", 50)
        lV.Columns.Add("Auteur", 50)

        Dim i As Integer = 0
        For Each livre As Livre In bibliotheque
            i += 1

            lV.Items.Add(New ListViewItem({i, livre.ISBN, livre.titre, livre.auteur}))

        Next

    End Sub

End Class