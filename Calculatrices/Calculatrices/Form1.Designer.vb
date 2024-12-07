<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculatrices
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.A = New System.Windows.Forms.TextBox()
        Me.B = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.plus = New System.Windows.Forms.Button()
        Me.minis = New System.Windows.Forms.Button()
        Me.rest = New System.Windows.Forms.Button()
        Me.equal = New System.Windows.Forms.Button()
        Me.div = New System.Windows.Forms.Button()
        Me.Times = New System.Windows.Forms.Button()
        Me.final = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(30, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "A"
        '
        'A
        '
        Me.A.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.A.Location = New System.Drawing.Point(71, 32)
        Me.A.Name = "A"
        Me.A.Size = New System.Drawing.Size(100, 30)
        Me.A.TabIndex = 1
        '
        'B
        '
        Me.B.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.B.Location = New System.Drawing.Point(71, 89)
        Me.B.Name = "B"
        Me.B.Size = New System.Drawing.Size(100, 30)
        Me.B.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(30, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "B"
        '
        'plus
        '
        Me.plus.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.plus.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.plus.Location = New System.Drawing.Point(205, 32)
        Me.plus.Name = "plus"
        Me.plus.Size = New System.Drawing.Size(75, 55)
        Me.plus.TabIndex = 4
        Me.plus.Text = "+"
        Me.plus.UseVisualStyleBackColor = False
        '
        'minis
        '
        Me.minis.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.minis.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.minis.Location = New System.Drawing.Point(286, 32)
        Me.minis.Name = "minis"
        Me.minis.Size = New System.Drawing.Size(75, 55)
        Me.minis.TabIndex = 5
        Me.minis.Text = "-"
        Me.minis.UseVisualStyleBackColor = False
        '
        'rest
        '
        Me.rest.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.rest.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.rest.Location = New System.Drawing.Point(173, 299)
        Me.rest.Name = "rest"
        Me.rest.Size = New System.Drawing.Size(107, 55)
        Me.rest.TabIndex = 7
        Me.rest.Text = "anuller"
        Me.rest.UseVisualStyleBackColor = False
        '
        'equal
        '
        Me.equal.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.equal.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.equal.Location = New System.Drawing.Point(26, 299)
        Me.equal.Name = "equal"
        Me.equal.Size = New System.Drawing.Size(75, 55)
        Me.equal.TabIndex = 6
        Me.equal.Text = "="
        Me.equal.UseVisualStyleBackColor = False
        '
        'div
        '
        Me.div.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.div.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.div.Location = New System.Drawing.Point(286, 99)
        Me.div.Name = "div"
        Me.div.Size = New System.Drawing.Size(75, 55)
        Me.div.TabIndex = 9
        Me.div.Text = "/"
        Me.div.UseVisualStyleBackColor = False
        '
        'Times
        '
        Me.Times.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Times.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Times.Location = New System.Drawing.Point(205, 99)
        Me.Times.Name = "Times"
        Me.Times.Size = New System.Drawing.Size(75, 55)
        Me.Times.TabIndex = 8
        Me.Times.Text = "x"
        Me.Times.UseVisualStyleBackColor = False
        '
        'final
        '
        Me.final.AutoSize = True
        Me.final.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.final.Location = New System.Drawing.Point(21, 188)
        Me.final.Name = "final"
        Me.final.Size = New System.Drawing.Size(59, 25)
        Me.final.TabIndex = 10
        Me.final.Text = "result"
        '
        'Calculatrices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.final)
        Me.Controls.Add(Me.div)
        Me.Controls.Add(Me.Times)
        Me.Controls.Add(Me.rest)
        Me.Controls.Add(Me.equal)
        Me.Controls.Add(Me.minis)
        Me.Controls.Add(Me.plus)
        Me.Controls.Add(Me.B)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.A)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Calculatrices"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents A As TextBox
    Friend WithEvents B As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents plus As Button
    Friend WithEvents minis As Button
    Friend WithEvents rest As Button
    Friend WithEvents equal As Button
    Friend WithEvents div As Button
    Friend WithEvents Times As Button
    Friend WithEvents final As Label
End Class
