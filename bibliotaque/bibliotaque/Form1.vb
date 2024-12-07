﻿Imports bibliotaque.Form1
Imports bibliotaque.Form2
Public Class Form1
    Public Structure Livre
        Dim ISBN As Integer
        Dim titre As String
        Dim auteur As String
    End Structure

    Public Shared bibliotheque As New List(Of Livre)




    Function AjoutLivre(l As Livre) As Boolean
        If bibliotheque.Count < 100 Then
            bibliotheque.Add(l)

            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btn_ajout_Click(sender As Object, e As EventArgs) Handles btn_ajout.Click
        Dim l As Livre
        If Not Integer.TryParse(t_ISBN.Text, l.ISBN) Then
            MessageBox.Show("Veuillez entrer un ISBN valide (entier).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            l.ISBN = t_ISBN.Text
            l.titre = t_titre.Text
            l.auteur = t_auteur.Text
            If AjoutLivre(l) Then
                MessageBox.Show("ajout du livre avec succes", "procisor d'ajoutage", MessageBoxButtons.OK, MessageBoxIcon.Information)
                t_ISBN.Clear()
                t_titre.Clear()
                t_auteur.Clear()
            Else
                MessageBox.Show("le tableau bibliotheque est saturé", "procisor d'ajoutage", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_affich_Click(sender As Object, e As EventArgs) Handles btn_affich.Click
        Dim form2 As New Form2()
        For Each livre As Livre In bibliotheque
            form2.L1.Items.Add(livre.ISBN)
            form2.L2.Items.Add(livre.titre)
            form2.L3.Items.Add(livre.auteur)
        Next


        form2.Show()

    End Sub
End Class







