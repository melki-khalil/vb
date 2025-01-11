Imports bibliotaque.Form1
Imports bibliotaque.Form2

Public Class Form3


    Private Sub btn_affichd_Click(sender As Object, e As EventArgs) Handles btn_affichd.Click
        Dim form3 As New Form4()




        Form1.placeForm(Form4)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each livre As Livre In bibliotheque
            L1.Items.Add(livre.ISBN)
            L2.Items.Add(livre.titre)
            L3.Items.Add(livre.auteur)
        Next
    End Sub
End Class