Imports System.CodeDom

Public Class Form1
    Dim x As Integer
    Dim res As String
    Dim v As Boolean

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LB1.Click

    End Sub

    Private Sub BTN_Click(sender As Object, e As EventArgs) Handles BTN.Click
        v = True
        If CMB.Text = "" Then
            v = False
        Else
            res = "la taille choisit est :  " + CMB.Text + " Le type de Croute est : "
        End If


        If CF.Checked Then
            res += CF.Text
        ElseIf CC.Checked Then
            res += CC.Text
        ElseIf CE.Checked Then
            res += CE.Text
        Else
            v = False
        End If
        res += vbNewLine + " et les ingredients sont: "
        If Ch.Checked Then
            res += Ch.Text + " ,"
        End If
        If Ol.Checked Then
            res += Ol.Text + " ,"
        End If
        If Po.Checked Then
            res += Po.Text + " ,"
        End If
        If FS.Checked Then
            res += FS.Text + " ,"
        End If
        If v Then
            res = res.Substring(0, res.Length - 1)
            LBL2.Text = res
        Else
            MessageBox.Show("completer le formulaire", "pizza0", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If



    End Sub




End Class
