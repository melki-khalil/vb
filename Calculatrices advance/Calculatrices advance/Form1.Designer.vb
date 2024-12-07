<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.final = New System.Windows.Forms.Label()
        Me.div = New System.Windows.Forms.Button()
        Me.Times = New System.Windows.Forms.Button()
        Me.rest = New System.Windows.Forms.Button()
        Me.equal = New System.Windows.Forms.Button()
        Me.minis = New System.Windows.Forms.Button()
        Me.plus = New System.Windows.Forms.Button()
        Me.nb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'final
        '
        Me.final.AutoSize = True
        Me.final.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.final.Location = New System.Drawing.Point(516, 45)
        Me.final.Name = "final"
        Me.final.Size = New System.Drawing.Size(59, 25)
        Me.final.TabIndex = 21
        Me.final.Text = "result"
        '
        'div
        '
        Me.div.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.div.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.div.Location = New System.Drawing.Point(175, 184)
        Me.div.Name = "div"
        Me.div.Size = New System.Drawing.Size(109, 50)
        Me.div.TabIndex = 20
        Me.div.Text = "/"
        Me.div.UseVisualStyleBackColor = False
        '
        'Times
        '
        Me.Times.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Times.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Times.Location = New System.Drawing.Point(46, 184)
        Me.Times.Name = "Times"
        Me.Times.Size = New System.Drawing.Size(109, 50)
        Me.Times.TabIndex = 19
        Me.Times.Text = "x"
        Me.Times.UseVisualStyleBackColor = False
        '
        'rest
        '
        Me.rest.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.rest.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.rest.Location = New System.Drawing.Point(129, 262)
        Me.rest.Name = "rest"
        Me.rest.Size = New System.Drawing.Size(144, 55)
        Me.rest.TabIndex = 18
        Me.rest.Text = "anuller"
        Me.rest.UseVisualStyleBackColor = False
        '
        'equal
        '
        Me.equal.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.equal.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.equal.Location = New System.Drawing.Point(48, 262)
        Me.equal.Name = "equal"
        Me.equal.Size = New System.Drawing.Size(75, 55)
        Me.equal.TabIndex = 17
        Me.equal.Text = "="
        Me.equal.UseVisualStyleBackColor = False
        '
        'minis
        '
        Me.minis.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.minis.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.minis.Location = New System.Drawing.Point(175, 117)
        Me.minis.Name = "minis"
        Me.minis.Size = New System.Drawing.Size(109, 50)
        Me.minis.TabIndex = 16
        Me.minis.Text = "-"
        Me.minis.UseVisualStyleBackColor = False
        '
        'plus
        '
        Me.plus.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.plus.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.plus.Location = New System.Drawing.Point(46, 117)
        Me.plus.Name = "plus"
        Me.plus.Size = New System.Drawing.Size(109, 50)
        Me.plus.TabIndex = 15
        Me.plus.Text = "+"
        Me.plus.UseVisualStyleBackColor = False
        '
        'nb
        '
        Me.nb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.nb.Location = New System.Drawing.Point(64, 42)
        Me.nb.Name = "nb"
        Me.nb.Size = New System.Drawing.Size(100, 30)
        Me.nb.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(23, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 25)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "nb"
        '
        'Form1
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
        Me.Controls.Add(Me.nb)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents final As Label
    Friend WithEvents div As Button
    Friend WithEvents Times As Button
    Friend WithEvents rest As Button
    Friend WithEvents equal As Button
    Friend WithEvents minis As Button
    Friend WithEvents plus As Button
    Friend WithEvents nb As TextBox
    Friend WithEvents Label1 As Label
End Class
