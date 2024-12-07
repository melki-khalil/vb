Imports bibliotaque.Form1

Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lV.View = View.Details
        lV.Columns.Add("Raw", 75)
        lV.Columns.Add("ISBN", 100)
        lv.Columns.Add("Titre", 50)
        lv.Columns.Add("Auteur", 50)

        Dim i As Integer = 0
        For Each livre As Livre In bibliotheque
            i += 1

            lV.Items.Add(New ListViewItem({i, livre.ISBN, livre.titre, livre.auteur}))

        Next

    End Sub

    Private Sub lV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lV.SelectedIndexChanged

    End Sub
End Class