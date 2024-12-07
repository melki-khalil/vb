Imports System.Security.Cryptography.X509Certificates

Public Class Form1
    Dim A As Double
    Dim B As Double
    Dim Eq As Double
    Dim nbc As String
    Dim pnb As String
    Dim op1 As Char
    Dim op2 As Char

    Private Sub plus_Click(sender As Object, e As EventArgs) Handles plus.Click
        If String.IsNullOrEmpty(nb.Text) OrElse "x+-/".Contains(nb.Text.Last) Then
            MessageBox.Show("You can't place operator here", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            nb.Text += "+"
        End If
    End Sub

    Private Sub minis_Click(sender As Object, e As EventArgs) Handles minis.Click
        If String.IsNullOrEmpty(nb.Text) OrElse "x+-/".Contains(nb.Text.Last) Then
            MessageBox.Show("You can't place operator here", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            nb.Text += "-"
        End If
    End Sub

    Private Sub Times_Click(sender As Object, e As EventArgs) Handles Times.Click
        If String.IsNullOrEmpty(nb.Text) OrElse "x+-/".Contains(nb.Text.Last) Then
            MessageBox.Show("You can't place operator here", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            nb.Text += "x"
        End If
    End Sub

    Private Sub div_Click(sender As Object, e As EventArgs) Handles div.Click
        If String.IsNullOrEmpty(nb.Text) OrElse "x+-/".Contains(nb.Text.Last) Then
            MessageBox.Show("You can't place operator here", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            nb.Text += "/"
        End If
    End Sub


    Public Function cacule(nbc, pnb)


        Dim plusIndex As Integer = nbc.IndexOf("+")
            Dim minisIndex As Integer = nbc.IndexOf("-")
            Dim timesIndex As Integer = nbc.IndexOf("x")
            Dim divIndex As Integer = nbc.IndexOf("/")
            Dim j As Integer = Math.Min(plusIndex, minisIndex)
            Dim k As Integer = Math.Min(timesIndex, divIndex)
            Dim i As Integer
            If j = -1 Then
                i = k
            ElseIf k = -1 Then
                i = j
            Else
                i = Math.Min(k, j)

            End If
            If i = -1 Then
            Return ""
        Else
               
                pnb = nbc.Substring(0, i)
                nbc = nbc.Substring(i + 1)
                Return nbc(i)
            End If

    End Function
    Private Sub equal_Click(sender As Object, e As EventArgs) Handles equal.Click
        nbc = nb.Text
        A = Double.Parse(pnb)

        op1 = cacule(nbc, pnb)

        While String.IsNullOrEmpty(nbc)



            op2 = cacule(nbc, pnb)
            B = Double.Parse(pnb)
            If op2 = "" Then
                Select Case op1
                    Case "+"
                        Eq += A
                    Case "-"
                        Eq -= A
                    Case "x"
                        A *= B

                        Eq += A
                    Case "/"
                        A /= B
                        Eq += A

                End Select
            ElseIf op2 = "+" Or op2 = "-" Then
                Select Case op1
                    Case "x"
                        A *= B


                    Case "/"
                        A /= B


                End Select

                Eq += A
                op2 = cacule(nbc, pnb)
                A = Double.Parse(pnb)
            Else
                If op1 = "-" Then
                    A = -A
                End If
                Eq += A
                A = B
                op1 = op2
                op2 = cacule(nbc, pnb)
                B = Double.Parse(pnb)
                Select Case op1
                    Case "x"
                        A *= B


                    Case "/"
                        A /= B


                End Select





            End If

            op1 = op2


        End While
        final.Text = Eq



    End Sub
End Class
