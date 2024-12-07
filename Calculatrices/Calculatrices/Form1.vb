Public Class Calculatrices
    Dim An As Double
    Dim Bn As Double
    Dim Eq As Double

    Dim op As Char = ControlChars.NullChar



    Private Sub plus_Click(sender As Object, e As EventArgs) Handles plus.Click
        op = "+"
    End Sub

    Private Sub minis_Click(sender As Object, e As EventArgs) Handles minis.Click
        op = "-"
    End Sub

    Private Sub Times_Click(sender As Object, e As EventArgs) Handles Times.Click
        op = "*"
    End Sub

    Private Sub div_Click(sender As Object, e As EventArgs) Handles div.Click
        op = "/"
    End Sub



    Private Sub equal_Click_1(sender As Object, e As EventArgs) Handles equal.Click
        If Not A.Text = "" And Not B.Text = "" And Double.TryParse(A.Text, An) And Double.TryParse(B.Text, Bn) Then
            An = CInt(Int(A.Text))
            Bn = CInt(Int(B.Text))
        Else
            MessageBox.Show("You should enter a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
        If op = ControlChars.NullChar Then

            MessageBox.Show("please put an  operator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Select Case op
                Case "+"
                    Eq = An + Bn
                Case "-"
                    Eq = An - Bn
                Case "*"
                    Eq = An * Bn
                Case "/"
                    If Bn = 0 Then
                        MessageBox.Show("You can't divide by zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        Eq = An / Bn

                    End If

            End Select
            final.Text = "result " & Eq.ToString
        End If

    End Sub

    Private Sub rest_Click(sender As Object, e As EventArgs) Handles rest.Click
        A.Text = ""
        B.Text = ""
    End Sub
End Class
